<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.LogTabPage = New System.Windows.Forms.TabPage()
        Me.LogListBox = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.KundeDonaldTabPage = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.KontenVonDonaldListBox = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DonaldsKontoGuthabenTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DonaldsKontonummerTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEinzahlen = New System.Windows.Forms.Button()
        Me.btnAbheben = New System.Windows.Forms.Button()
        Me.BetragTextBox = New System.Windows.Forms.TextBox()
        Me.btnDonaldsKontoSchliessen = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnNeuesKontoFuerDonald = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.LogTabPage.SuspendLayout()
        Me.KundeDonaldTabPage.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(661, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "&Datei"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.BeendenToolStripMenuItem.Text = "beenden"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 382)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(661, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.LogTabPage)
        Me.TabControl1.Controls.Add(Me.KundeDonaldTabPage)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(661, 358)
        Me.TabControl1.TabIndex = 2
        '
        'LogTabPage
        '
        Me.LogTabPage.Controls.Add(Me.LogListBox)
        Me.LogTabPage.Controls.Add(Me.Panel1)
        Me.LogTabPage.Location = New System.Drawing.Point(4, 22)
        Me.LogTabPage.Name = "LogTabPage"
        Me.LogTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.LogTabPage.Size = New System.Drawing.Size(653, 332)
        Me.LogTabPage.TabIndex = 0
        Me.LogTabPage.Text = "Log"
        Me.LogTabPage.UseVisualStyleBackColor = True
        '
        'LogListBox
        '
        Me.LogListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogListBox.FormattingEnabled = True
        Me.LogListBox.Location = New System.Drawing.Point(3, 63)
        Me.LogListBox.Name = "LogListBox"
        Me.LogListBox.Size = New System.Drawing.Size(647, 266)
        Me.LogListBox.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(647, 60)
        Me.Panel1.TabIndex = 0
        '
        'KundeDonaldTabPage
        '
        Me.KundeDonaldTabPage.Controls.Add(Me.SplitContainer1)
        Me.KundeDonaldTabPage.Controls.Add(Me.Panel2)
        Me.KundeDonaldTabPage.Location = New System.Drawing.Point(4, 22)
        Me.KundeDonaldTabPage.Name = "KundeDonaldTabPage"
        Me.KundeDonaldTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.KundeDonaldTabPage.Size = New System.Drawing.Size(653, 332)
        Me.KundeDonaldTabPage.TabIndex = 1
        Me.KundeDonaldTabPage.Text = "Kunde Donald"
        Me.KundeDonaldTabPage.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 68)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.KontenVonDonaldListBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(647, 261)
        Me.SplitContainer1.SplitterDistance = 306
        Me.SplitContainer1.TabIndex = 1
        '
        'KontenVonDonaldListBox
        '
        Me.KontenVonDonaldListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KontenVonDonaldListBox.FormattingEnabled = True
        Me.KontenVonDonaldListBox.Location = New System.Drawing.Point(0, 0)
        Me.KontenVonDonaldListBox.Name = "KontenVonDonaldListBox"
        Me.KontenVonDonaldListBox.Size = New System.Drawing.Size(306, 261)
        Me.KontenVonDonaldListBox.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.54303!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.45697!))
        Me.TableLayoutPanel1.Controls.Add(Me.DonaldsKontoGuthabenTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DonaldsKontonummerTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnEinzahlen, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAbheben, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.BetragTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDonaldsKontoSchliessen, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(337, 261)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'DonaldsKontoGuthabenTextBox
        '
        Me.DonaldsKontoGuthabenTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DonaldsKontoGuthabenTextBox.Location = New System.Drawing.Point(143, 33)
        Me.DonaldsKontoGuthabenTextBox.Name = "DonaldsKontoGuthabenTextBox"
        Me.DonaldsKontoGuthabenTextBox.ReadOnly = True
        Me.DonaldsKontoGuthabenTextBox.Size = New System.Drawing.Size(191, 20)
        Me.DonaldsKontoGuthabenTextBox.TabIndex = 3
        Me.DonaldsKontoGuthabenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kontonummer"
        '
        'DonaldsKontonummerTextBox
        '
        Me.DonaldsKontonummerTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DonaldsKontonummerTextBox.Location = New System.Drawing.Point(143, 3)
        Me.DonaldsKontonummerTextBox.Name = "DonaldsKontonummerTextBox"
        Me.DonaldsKontonummerTextBox.ReadOnly = True
        Me.DonaldsKontonummerTextBox.Size = New System.Drawing.Size(191, 20)
        Me.DonaldsKontonummerTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Guthaben in Eur"
        '
        'btnEinzahlen
        '
        Me.btnEinzahlen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEinzahlen.Location = New System.Drawing.Point(3, 63)
        Me.btnEinzahlen.Name = "btnEinzahlen"
        Me.btnEinzahlen.Size = New System.Drawing.Size(134, 24)
        Me.btnEinzahlen.TabIndex = 4
        Me.btnEinzahlen.Text = "Einzahlen"
        Me.btnEinzahlen.UseVisualStyleBackColor = True
        '
        'btnAbheben
        '
        Me.btnAbheben.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAbheben.Location = New System.Drawing.Point(3, 93)
        Me.btnAbheben.Name = "btnAbheben"
        Me.btnAbheben.Size = New System.Drawing.Size(134, 24)
        Me.btnAbheben.TabIndex = 5
        Me.btnAbheben.Text = "Abheben"
        Me.btnAbheben.UseVisualStyleBackColor = True
        '
        'BetragTextBox
        '
        Me.BetragTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BetragTextBox.Location = New System.Drawing.Point(143, 93)
        Me.BetragTextBox.Name = "BetragTextBox"
        Me.BetragTextBox.Size = New System.Drawing.Size(191, 20)
        Me.BetragTextBox.TabIndex = 6
        '
        'btnDonaldsKontoSchliessen
        '
        Me.btnDonaldsKontoSchliessen.Location = New System.Drawing.Point(143, 123)
        Me.btnDonaldsKontoSchliessen.Name = "btnDonaldsKontoSchliessen"
        Me.btnDonaldsKontoSchliessen.Size = New System.Drawing.Size(115, 23)
        Me.btnDonaldsKontoSchliessen.TabIndex = 7
        Me.btnDonaldsKontoSchliessen.Text = "Konto schliessen"
        Me.btnDonaldsKontoSchliessen.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.btnNeuesKontoFuerDonald)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(647, 65)
        Me.Panel2.TabIndex = 0
        '
        'btnNeuesKontoFuerDonald
        '
        Me.btnNeuesKontoFuerDonald.Location = New System.Drawing.Point(16, 16)
        Me.btnNeuesKontoFuerDonald.Name = "btnNeuesKontoFuerDonald"
        Me.btnNeuesKontoFuerDonald.Size = New System.Drawing.Size(124, 23)
        Me.btnNeuesKontoFuerDonald.TabIndex = 0
        Me.btnNeuesKontoFuerDonald.Text = "Neue Konto öffnen"
        Me.btnNeuesKontoFuerDonald.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 404)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Bankhaus Dagobert"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.LogTabPage.ResumeLayout(False)
        Me.KundeDonaldTabPage.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents LogTabPage As System.Windows.Forms.TabPage
    Friend WithEvents KundeDonaldTabPage As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents KontenVonDonaldListBox As System.Windows.Forms.ListBox
    Friend WithEvents DonaldsKontoGuthabenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnEinzahlen As System.Windows.Forms.Button
    Friend WithEvents btnAbheben As System.Windows.Forms.Button
    Friend WithEvents BetragTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnDonaldsKontoSchliessen As System.Windows.Forms.Button
    Friend WithEvents btnNeuesKontoFuerDonald As System.Windows.Forms.Button
    Protected WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Protected WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Protected WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Protected WithEvents TabControl1 As System.Windows.Forms.TabControl
    Protected WithEvents LogListBox As System.Windows.Forms.ListBox
    Protected WithEvents Panel1 As System.Windows.Forms.Panel
    Protected WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Protected WithEvents Panel2 As System.Windows.Forms.Panel
    Protected WithEvents DonaldsKontonummerTextBox As System.Windows.Forms.TextBox

End Class
