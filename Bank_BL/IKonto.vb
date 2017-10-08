Public Interface IKonto
    Inherits IComparable(Of IKonto)

    ReadOnly Property KtoNr As String

    ReadOnly Property Guthaben As Double

    Sub Einzahlen(Betrag As Double)

    Sub Abheben(Betrag As Double)

End Interface
