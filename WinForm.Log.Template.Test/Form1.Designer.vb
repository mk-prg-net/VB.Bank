<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnKontoauszug = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LogListBox
        '
        Me.LogListBox.Items.AddRange(New Object() {"gestartet um 16:18:20", "gestartet um 16:12:11", "gestartet um 16:12:01", "gestartet um 16:11:03", "gestartet um 16:10:56", "gestartet um 16:10:03", "gestartet um 15:17:12", "gestartet um 14:27:06", "gestartet um 14:24:39", "gestartet um 14:14:00", "gestartet um 13:56:42", "gestartet um 13:47:21", "gestartet um 13:47:08"})
        Me.LogListBox.Size = New System.Drawing.Size(647, 264)
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.btnKontoauszug)
        Me.Panel2.Controls.SetChildIndex(Me.btnKontoauszug, 0)
        Me.Panel2.Controls.SetChildIndex(Me.TextBox1, 0)
        '
        'btnKontoauszug
        '
        Me.btnKontoauszug.Location = New System.Drawing.Point(162, 16)
        Me.btnKontoauszug.Name = "btnKontoauszug"
        Me.btnKontoauszug.Size = New System.Drawing.Size(118, 23)
        Me.btnKontoauszug.TabIndex = 1
        Me.btnKontoauszug.Text = "Kontoauszug"
        Me.btnKontoauszug.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(327, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(270, 31)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "HAllooooo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 404)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnKontoauszug As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
