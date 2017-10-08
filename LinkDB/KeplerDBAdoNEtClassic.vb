Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Data
Imports System.Data.Common

<TestClass()> Public Class KeplerDBAdoNEtClassic

    <TestMethod()> Public Sub KeplerDBAdoNEtClassic_EinfacheAbfragen()

        ' Programmieren Datenbankprovider- unabhängig
        ' 1) Klassenfabrik für ADO.NET Objekte
        ' Die möglichen Provider sind in der machine.config unter DbProviderFactories abgelegt
        Dim classFactory As DbProviderFactory = DbProviderFactories.GetFactory("System.Data.SqlClient")

        ' 2) Ein Verbindungsobjekt erzeugen
        Dim conn = classFactory.CreateConnection()

        ' 2.1) Hilfsklasse zum erzeugen einer Verbindungszeichenfolge <=> Daten über die Verbindung
        Dim connStringBld As DbConnectionStringBuilder = classFactory.CreateConnectionStringBuilder()
        connStringBld.ConnectionString = "Data Source=(localdb)\ProjectsV12;Initial Catalog=KeplerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False"

        Dim connStringBldForSqlServer As New System.Data.SqlClient.SqlConnectionStringBuilder()

        connStringBldForSqlServer.ConnectionString = "Data Source=(localdb)\ProjectsV12;Initial Catalog=KeplerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False"
        ' Erlauben, innerhalb einer laufenden Abfrage weitere Abfragen zu starten
        connStringBldForSqlServer.MultipleActiveResultSets = True

        conn.ConnectionString = connStringBldForSqlServer.ConnectionString
        Try
            conn.Open()

            Dim sql = "Select A.Name as Name, A.Masse_in_kg as Masse, B.Name as Typ " + _
                        "from dbo.HimmelskoerperTab as A Join dbo.HimmelskoerperTypenTab as B on A.HimmelskoerperTyp_ID = B.ID " +
                        "where B.Name = 'Planet'"


            Dim cmd As DbCommand = classFactory.CreateCommand()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql

            ' 3) Abfrage ausführen
            Dim reader = cmd.ExecuteReader()

            Dim NameColMap As New System.Collections.Generic.Dictionary(Of String, Integer)

            Dim first As Boolean = True
            While reader.Read()

                If first Then
                    first = False

                    For i = 0 To reader.FieldCount - 1
                        Dim NameSpalte = reader.GetName(i)
                        Dim TypSpalte = reader.GetFieldType(i)

                        NameColMap.Add(NameSpalte, i)
                        ' Kurzform:
                        'NameColMap(NameSpalte) = i

                        Debug.Write(NameSpalte & ":" & TypSpalte.Name & " ")
                    Next

                    Debug.WriteLine("")

                End If

                Dim Name = reader.GetString(NameColMap("Name"))
                Dim Masse_in_kg = reader.GetDouble(NameColMap("Masse"))
                Dim Typ = reader.GetString(NameColMap("Typ"))


                Debug.WriteLine(Name & " " & Masse_in_kg & " " & Typ)

            End While

        Catch ex As Exception
            Assert.Fail()
        Finally
            conn.Close()
        End Try

    End Sub

End Class