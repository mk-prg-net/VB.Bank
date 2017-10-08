Public Class KontoauszugDruckenJaNeinDlg

    Private Sub btnJa_Click(sender As Object, e As EventArgs) Handles btnJa.Click
        Me.Hide()
    End Sub

    Private Sub btnNein_Click(sender As Object, e As EventArgs) Handles btnNein.Click
        Me.Hide()
    End Sub

    Private Sub KontoauszugDruckenJaNeinDlg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Dim _LogListBox As System.Windows.Forms.ListBox

    Public WriteOnly Property LogListBox As ListBox
        Set(value As ListBox)
            _LogListBox = value
        End Set
    End Property


    Protected Overrides Sub OnGotFocus(e As EventArgs)
        _LogListBox.Items.Add(Me.Text & " hat den Focus")
        MyBase.OnGotFocus(e)
    End Sub



    Private Sub KontoauszugDruckenJaNeinDlg_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        _LogListBox.Items.Add(Me.Text & " wurde aktiviert")
    End Sub
End Class
