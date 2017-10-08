Public Class Sparkonto
    Implements IKonto

    ''' <summary>
    ''' Konstruktor: wird beim Anlegen eines neuen Objektes mittels
    ''' New Operator aufgerufen
    ''' </summary>
    ''' <param name="KtoNr"></param>
    ''' <remarks></remarks>
    Public Sub New(KtoNr As String)
        _KtoNr = KtoNr
        ' Als Neukunde gibt ein tolles Startguthaben
        _Guthaben = 10
    End Sub

    Public ReadOnly Property KtoNr As String Implements IKonto.KtoNr
        ' Der Getter berechnet den Wert der Eigenschaft Kontonummer
        Get
            Return _KtoNr
        End Get
    End Property
    ' Eine private Variable. Ist von aussen nicht sichtbar. 
    ' Dient zur Implementierung der KtoNr
    Dim _KtoNr As String

    Public Const Sparzins As Double = 0.12

    Public ReadOnly Property Guthaben As Double Implements IKonto.Guthaben
        Get
            Return _Guthaben
        End Get
    End Property

    Dim _Guthaben As Double

    Public Sub Einzahlen(Betrag As Double) Implements IKonto.Einzahlen
        '_Guthaben = _Guthaben + Betrag
        ' Diese Zeile entspricht der Vorausgegangenen
        _Guthaben += Betrag
    End Sub

    Public Sub Abheben(Betrag As Double) Implements IKonto.Abheben
        If _Guthaben - Betrag >= 0 Then
            _Guthaben -= Betrag
        Else
            Throw New Exception("Zu wenig gespart")
        End If
    End Sub

    Public Function CompareTo(other As IKonto) As Integer Implements IComparable(Of IKonto).CompareTo
        If other.Guthaben > Guthaben Then
            Return -1
        ElseIf other.Guthaben < Guthaben Then
            Return 1
        Else
            Return 0
        End If
    End Function
End Class
