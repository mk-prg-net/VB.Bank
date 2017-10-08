Public Class ChildForm

    Private Sub ChildForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInfo.Text = Now.ToLongTimeString()
    End Sub
End Class