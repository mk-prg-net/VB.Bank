Public Class Form1

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        ' BEenden der Endlosschleife- NAchricht an die Nachrichtenwarteschlange senden
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogListBox.Items.Add("gestartet um " & Date.Now.ToLongTimeString())
    End Sub


    Dim Donald As New Bank_BL.Kunde("4711")

    Private Sub btnNeuesKontoFuerDonald_Click(sender As Object, e As EventArgs) Handles btnNeuesKontoFuerDonald.Click

        Dim ktoNr = Donald.NeuerKontoEroeffnen()
        KontenVonDonaldListBox.Items.Add(ktoNr)


    End Sub

    ' Referenzvariable auf ein Konto 
    Dim aktKonto As Bank_BL.Konto

    Sub DisplayAktKonto()
        DonaldsKontoGuthabenTextBox.Text = aktKonto.Guthaben.ToString("C")
    End Sub

    Private Sub KontenVonDonaldListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KontenVonDonaldListBox.SelectedIndexChanged
        Dim ix = KontenVonDonaldListBox.SelectedIndex

        ' Items verhält sich wie ein Array
        Dim ktoNr = CType(KontenVonDonaldListBox.Items(ix), String)
        DonaldsKontonummerTextBox.Text = ktoNr

        aktKonto = Donald.Konten.First(Function(pKonto) pKonto.KtoNr = ktoNr)

        DisplayAktKonto()
    End Sub

    Sub MeldeFehler(Fehlermeldung As String)
        MessageBox.Show(Fehlermeldung, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ToolStripStatusLabel1.Text = "Error: " & Fehlermeldung
        LogListBox.Items.Add("Error: " & Fehlermeldung)
    End Sub

    Sub MeldeStatus(Statusmeldung As String)
        ToolStripStatusLabel1.Text = Statusmeldung
        LogListBox.Items.Add(Statusmeldung)
    End Sub


    Private Sub btnEinzahlen_Click(sender As Object, e As EventArgs) Handles btnEinzahlen.Click

        If Not aktKonto Is Nothing Then
            Dim betrag As Double
            If Double.TryParse(BetragTextBox.Text, betrag) Then
                aktKonto.Einzahlen(betrag)
                MeldeStatus("In Donalds Konto wurden " & betrag & " Eur eingezahlt.")
                DonaldsKontoGuthabenTextBox.Text = aktKonto.Guthaben.ToString("C")
            Else
                MeldeFehler("Der Betrag, der eingezahlt werden soll, ist keine Zahl")
            End If
        End If
    End Sub

    Private Sub btnAbheben_Click(sender As Object, e As EventArgs) Handles btnAbheben.Click
        If Not aktKonto Is Nothing Then
            Dim betrag As Double
            If Double.TryParse(BetragTextBox.Text, betrag) Then
                aktKonto.Abheben(betrag)
                MeldeStatus("Von Donalds Konto wurden " & betrag & " Eur abgehoben.")
                DonaldsKontoGuthabenTextBox.Text = aktKonto.Guthaben.ToString("C")
            Else
                MeldeFehler("Der Betrag, der abgehoben werden soll, ist keine Zahl")
            End If
        End If

    End Sub
End Class
