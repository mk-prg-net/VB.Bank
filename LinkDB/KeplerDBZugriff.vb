Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class KeplerDBZugriff

    <TestMethod()> Public Sub KeplerDBZugriff_Einfache_Abfragen()

        ' 1) Objektrelationalen Mapper anlegen
        Dim orm = New KeplerDBEntities()

        ' Der Connectionstring wird aus der config- Datei geladen
        'orm.Database.Connection.ConnectionString = "..."


        ' 2) Liste aller Himmelskörper ausgeben
        For Each hk In orm.HimmelskoerperTab

            Debug.WriteLine(hk.Name & " " & hk.Masse_in_kg & " " & hk.HimmelskoerperTypenTab.Name)

        Next

        Debug.WriteLine("---------------------------------------------------------------")

        ' 3) Alle Planeten, sortiert nach dem Abstand zur Sonne
        For Each hk In orm.HimmelskoerperTab _
            .Where(Function(hk1) hk1.HimmelskoerperTypenTab.Name = "Planet") _
            .OrderBy(Function(hk1) hk1.UmlaufbahnenTab.Laenge_grosse_Halbachse_in_km)

            Debug.WriteLine(hk.Name & " " & hk.Masse_in_kg & " " & hk.HimmelskoerperTypenTab.Name)

        Next

        ' 4) Bestimmen der Erdmasse
        Dim Erdmasse = orm.HimmelskoerperTab.First(Function(hk) hk.Name = "Erde").Masse_in_kg

        Debug.WriteLine("---------------------------------------------------------------")
        ' 5) Alle Planeten, sortiert nach dem Abstand zur Sonne, mit Masse in Vielfachen der Erdmasse
        For Each hk In orm.HimmelskoerperTab _
            .Where(Function(hk1) hk1.HimmelskoerperTypenTab.Name = "Planet") _
            .OrderBy(Function(hk1) hk1.UmlaufbahnenTab.Laenge_grosse_Halbachse_in_km) _
            .Select(Function(hk1) New With {.Name = hk1.Name, _
                                            .xErdmasse = hk1.Masse_in_kg / Erdmasse, _
                                            .Durchmesser = hk1.Sterne_Planeten_MondeTab.Aequatordurchmesser_in_km, _
                                            .Typ = hk1.HimmelskoerperTypenTab.Name})

            Debug.WriteLine(hk.Name & " Masse= " & hk.xErdmasse & " D= " & hk.Durchmesser & " " & hk.Typ)

        Next



        Dim HimmelsQuery = orm.HimmelskoerperTab _
            .Where(Function(hk1) hk1.HimmelskoerperTypenTab.Name = "Planet") _
            .OrderBy(Function(hk1) hk1.UmlaufbahnenTab.Laenge_grosse_Halbachse_in_km) _
            .Select(Function(hk1) New With {.Name = hk1.Name, _
                                            .xErdmasse = hk1.Masse_in_kg / Erdmasse, _
                                            .Durchmesser = hk1.Sterne_Planeten_MondeTab.Aequatordurchmesser_in_km, _
                                            .Typ = hk1.HimmelskoerperTypenTab.Name})

        Dim Sql = HimmelsQuery.ToString()

        Debug.WriteLine("Das generierte SQL")
        Debug.WriteLine(Sql)

        ' Selbstgebastelte SQL- Abfragen über EntityFramework ausführen

        Dim alleHkManuell = orm.Database.SqlQuery(Of HimmelskoerperTab)("Select * from dbo.HimmelskoerperTab")

        ' Abfrage wird nun ausgeführt
        Dim ergbnis = alleHkManuell.ToArray()

        Dim alleHkManuell2 = orm.Database.SqlQuery(Of HimmelskoerperMitTyp)( _
            "Select A.Name as Name, A.Masse_in_kg as Masse, B.Name as Typ " + _
            "from dbo.HimmelskoerperTab as A Join dbo.HimmelskoerperTypenTab as B on A.HimmelskoerperTyp_ID = B.ID")

        Dim ergebnis2 = alleHkManuell2.ToArray()

    End Sub

    Class HimmelskoerperMitTyp
        Property Name As String
        Property Masse As Double
        Property Typ As String
    End Class


    <TestMethod()> Sub KEplerDBZugriff_CUD()

        ' Using- Block ruft automatisch am Blockende die Dispose- Methode von orm auf
        Using orm = New KeplerDBEntities()

            Try

                ' neuen Himmelskoerper anlegen
                ' 1) neues Himmelskoerperobjekt schaffen mittesl Klassenfabrik der Himmelskoerpertabelle
                Dim neueHK_1 As New HimmelskoerperTab()
                Dim neuerHk = orm.HimmelskoerperTab.Create()

                neuerHk.Name = "Eros"
                neuerHk.Masse_in_kg = 1.0E+22

                ' Art des Himmelskoepers definieren, indem seiner Navigationseigenschaft ein HimmelskoeperTyp- Datensatz zugwiesen
                ' -> Objketgraph
                Dim TypAsteroid = orm.HimmelskoerperTypenTab.Single(Function(typ) typ.Name = "Asteroid")
                neuerHk.HimmelskoerperTypenTab = TypAsteroid

                Dim Umlaufbahn = orm.UmlaufbahnenTab.Create()
                neuerHk.UmlaufbahnenTab = Umlaufbahn
                Umlaufbahn.Laenge_grosse_Halbachse_in_km = 1000000000.0
                Umlaufbahn.Zentralkoerper = orm.HimmelskoerperTab.Single(Function(hk) hk.Name = "Sonne")

                ' Jetzt wird der neue Himmelskörper der Tabelle HimmelskoeperTab hinzugefügt
                orm.HimmelskoerperTab.Add(neuerHk)

                ' Das ganze mit der Datenbank synchronisieren
                orm.SaveChanges()

                Dim anz = orm.HimmelskoerperTab.Where(Function(hk) hk.Name = "Eros").Count()
                Assert.IsTrue(anz > 0)

                ' Update
                Dim Eros = orm.HimmelskoerperTab.First(Function(hk) hk.Name = "Eros")
                Eros.UmlaufbahnenTab.Mittlere_Umlaufgeschwindigkeit_in_km_pro_sec = 20
                orm.SaveChanges()

                Eros = Nothing
                Eros = orm.HimmelskoerperTab.First(Function(hk) hk.Name = "Eros")

                Assert.AreEqual(20.0, Eros.UmlaufbahnenTab.Mittlere_Umlaufgeschwindigkeit_in_km_pro_sec)

                ' Delete
                orm.HimmelskoerperTab.Remove(Eros)
                orm.SaveChanges()

                Assert.IsFalse(orm.HimmelskoerperTab.Any(Function(hk) hk.Name = "Eros"))


            Catch ex As Exception

            End Try

        End Using


    End Sub

End Class