Imports System.Linq
Public Class Kunde

    Dim _KundenNr As String

    Public Sub New(KundenNr As String)
        _KundenNr = KundenNr
    End Sub

    Dim _Konten As New List(Of Konto)

    ' Neues Konten für Kunden eröffnen
    ' Die Kontonummer wird zurückgeliefert
    Public Function NeuerKontoEroeffnen() As String
        Dim newKtoNr = Guid.NewGuid.ToString()
        Dim newKto = New Konto(newKtoNr)

        _Konten.Add(newKto)

        Return newKtoNr
    End Function

    ' Vorhandenes Konto schliessen
    Public Sub KontoSchliessen(KtoNr As String)

        ' 1) Prüfen, ob das Konto mit der Nummer überhaupt vorhanden ist
        If _Konten.Any(Function(pKonto) pKonto.KtoNr = KtoNr) Then
            ' 2) Zugriff auf zu löschendes Konto und es aus der Liste löschen
            Dim zu_löschendes_Konto = _Konten.First(Function(pKonto) pKonto.KtoNr = KtoNr)
            _Konten.Remove(zu_löschendes_Konto)
        Else
            Throw New Exception("Das Konto " & KtoNr & " sollte gelöscht werden, existiert jedoch nicht")
        End If

    End Sub

    ' Liste alle Konten vom Kunden abrufen
    Public ReadOnly Property Konten As IEnumerable(Of Konto)
        Get
            Return _Konten
        End Get
    End Property


End Class
