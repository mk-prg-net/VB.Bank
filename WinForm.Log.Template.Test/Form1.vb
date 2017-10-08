Public Class Form1
    Inherits WinForm.Log.Template.Form1

    Private Sub btnKontoauszug_Click(sender As Object, e As EventArgs) Handles btnKontoauszug.Click

        Dim dlg As New KontoauszugDruckenJaNeinDlg

        dlg.LogListBox = LogListBox

        dlg.Show()
        'If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then

        'LogListBox.Items.Add("Der Kontoauszug wird jetzt gedruckt")

        'End If


    End Sub

    ReadOnly MwSt1 As Double

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        MwSt1 = My.Settings.MwStNormal

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Zugriff auf die Anwendungseinstellungen
        Me.Text = My.Settings.ProgTitle


    End Sub


    Protected Overrides Sub OnGotFocus(e As EventArgs)
        LogListBox.Items.Add(Me.Text & " hat den Focus")

        MyBase.OnGotFocus(e)
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        LogListBox.Items.Add(Me.Text & " wurde aktiviert")



    End Sub

    Private Sub TextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseClick

        TextBox1.Font = New Font(TextBox1.Font.FontFamily.Name, TextBox1.Font.Size * 2)

    End Sub

  
    Private Sub TextBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseDoubleClick
        TextBox1.Font = New Font(TextBox1.Font.FontFamily.Name, TextBox1.Font.Size / 2)
    End Sub
End Class
