<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DlgJaNein
    Inherits System.Windows.Forms.Form

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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNein = New System.Windows.Forms.Button()
        Me.btnJa = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.btnNein)
        Me.Panel1.Controls.Add(Me.btnJa)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 231)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(355, 31)
        Me.Panel1.TabIndex = 0
        '
        'btnNein
        '
        Me.btnNein.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNein.Location = New System.Drawing.Point(108, 5)
        Me.btnNein.Name = "btnNein"
        Me.btnNein.Size = New System.Drawing.Size(75, 23)
        Me.btnNein.TabIndex = 1
        Me.btnNein.Text = "Nein"
        Me.btnNein.UseVisualStyleBackColor = True
        '
        'btnJa
        '
        Me.btnJa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnJa.Location = New System.Drawing.Point(6, 5)
        Me.btnJa.Name = "btnJa"
        Me.btnJa.Size = New System.Drawing.Size(75, 23)
        Me.btnJa.TabIndex = 0
        Me.btnJa.Text = "Ja"
        Me.btnJa.UseVisualStyleBackColor = True
        '
        'DlgJaNein
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 262)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "DlgJaNein"
        Me.Text = "DlgJaNein"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Protected WithEvents btnNein As System.Windows.Forms.Button
    Protected WithEvents btnJa As System.Windows.Forms.Button
End Class
