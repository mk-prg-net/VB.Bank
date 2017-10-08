Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Linq

<TestClass()> Public Class BankTests


    Dim CarlosKonto As Konto

    <TestInitialize()> Sub Init()
        CarlosKonto = New Konto("1234")
    End Sub

    <TestCleanup> Sub CleanUp()
        CarlosKonto = Nothing
    End Sub

    <TestMethod()> Public Sub KontenTest()

        ' Ein Konto Anlegen, und damit was tun
        ' 1) Referenzvariable auf dem Stapel anlgen
        Dim DonaldsKonto As Konto

        ' 2) Objket im Heap erzeugen
        DonaldsKonto = New Konto("4711")

        ' Anlegen der Referenzvariable und Aufruf des Defaultkonstruktors 
        ' in einer Zeile
        Dim DaisysKonto As New Konto("4712")

        Assert.AreEqual(0.12, Konto.Überziehungszins)

        'DonaldsKonto.KtoNr = "4711"

        Assert.AreEqual("4711", DonaldsKonto.KtoNr)
        Assert.AreEqual("4712", DaisysKonto.KtoNr)


        Assert.AreEqual(10.0, DonaldsKonto.Guthaben)

        DonaldsKonto.Einzahlen(1000)
        Assert.AreEqual(1010.0, DonaldsKonto.Guthaben)

        DonaldsKonto.Abheben(500)
        Assert.AreEqual(510.0, DonaldsKonto.Guthaben)


        Dim sonne As New VB.OO.Klassenlib.Astro.Stern(1.0, VB.OO.Klassenlib.Spektralklasse.G)






    End Sub

    <TestMethod()> Sub KundenTest()

        Dim Donald As New Kunde("K9876")

        ' Kundennummer prüfen
        'Assert.AreEqual("9876",Donald.)

        ' Neue Konten von Donald
        Dim ktoNr1 = Donald.NeuerKontoEroeffnen()
        Dim ktoNr2 = Donald.NeuerKontoEroeffnen()

        Assert.AreEqual(2, Donald.Konten.Count())

        ' Zugriff auf das erste Konto
        Dim kto1 = Donald.Konten.First(Function(pKonto) pKonto.KtoNr = ktoNr1)

        Assert.AreEqual(ktoNr1, kto1.KtoNr)
        Assert.AreEqual(10.0, kto1.Guthaben)

        kto1.Einzahlen(300)
        Assert.AreEqual(310.0, kto1.Guthaben)

        ' Konto schliessen
        Donald.KontoSchliessen(ktoNr1)
        Assert.AreEqual(1, Donald.Konten.Count())

        Dim kto2 = Donald.Konten.First(Function(pKonto) pKonto.KtoNr = ktoNr2)
        Assert.IsNotNull(kto2)
        Assert.AreEqual(ktoNr2, kto2.KtoNr)








    End Sub


    <TestMethod> Sub IKonto_Test()

        Dim DonaldsSparkonto As New Sparkonto("1234")
        Dim DaisysGirokonto As New Konto("9999")

        DonaldsSparkonto.Einzahlen(330)
        DaisysGirokonto.Einzahlen(2500)

        Dim bank As New BankBL
        Dim ListeAllerKonten() As IKonto = {DonaldsSparkonto, DaisysGirokonto, CarlosKonto}
        Dim saldo = bank.Saldieren(ListeAllerKonten)
        'Dim saldo = bank.Saldieren(New IKonto() {DonaldsSparkonto, DaisysGirokonto})
        Assert.AreEqual(2860.0, saldo)

        ' Sortieren mittels im Framework eingebauter Algorithmen
        Dim zahlen() As Integer = {33, 1, 2, 7, 3, 6, 19, 12}
        Array.Sort(zahlen)

        Assert.AreEqual(1, zahlen(0))
        Assert.AreEqual(33, zahlen(7))

        Dim planeten() As String = {"Merkur", "Venus", "Erde", "Mars", "Jupiter"}
        Array.Sort(planeten)

        Assert.AreEqual("Erde", planeten(0))
        Assert.AreEqual("Venus", planeten(4))

        Array.Sort(ListeAllerKonten)







    End Sub

End Class