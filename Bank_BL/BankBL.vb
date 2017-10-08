Public Class BankBL

    ''' <summary>
    ''' Berechnet den Saldo über alle Konten
    ''' </summary>
    ''' <param name="konten"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Saldieren(konten() As IKonto) As Double
        Dim saldo As Double
        For Each Konto In konten
            saldo += Konto.Guthaben
        Next
        Return saldo
    End Function

End Class
