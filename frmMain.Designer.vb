<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label01 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label07 = New System.Windows.Forms.Label()
        Me.Label08 = New System.Windows.Forms.Label()
        Me.txtINx1 = New System.Windows.Forms.TextBox()
        Me.txtINx3 = New System.Windows.Forms.TextBox()
        Me.txtINy3 = New System.Windows.Forms.TextBox()
        Me.progBar = New System.Windows.Forms.ProgressBar()
        Me.dgvTable = New System.Windows.Forms.DataGridView()
        Me.txtINx2 = New System.Windows.Forms.TextBox()
        Me.Label02 = New System.Windows.Forms.Label()
        Me.txtINy2 = New System.Windows.Forms.TextBox()
        Me.Label04 = New System.Windows.Forms.Label()
        Me.txtINy1 = New System.Windows.Forms.TextBox()
        Me.Label03 = New System.Windows.Forms.Label()
        Me.txtINz2 = New System.Windows.Forms.TextBox()
        Me.Label06 = New System.Windows.Forms.Label()
        Me.txtINz1 = New System.Windows.Forms.TextBox()
        Me.Label05 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(4, 128)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(754, 34)
        Me.Button1.TabIndex = 90
        Me.Button1.Text = "Create surface from table in Solidworks part"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label01
        '
        Me.Label01.AutoSize = True
        Me.Label01.Location = New System.Drawing.Point(4, 8)
        Me.Label01.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label01.Name = "Label01"
        Me.Label01.Size = New System.Drawing.Size(36, 13)
        Me.Label01.TabIndex = 3
        Me.Label01.Text = "X min:"
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(326, 98)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(432, 26)
        Me.Button2.TabIndex = 100
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label07
        '
        Me.Label07.AutoSize = True
        Me.Label07.Location = New System.Drawing.Point(224, 8)
        Me.Label07.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label07.Name = "Label07"
        Me.Label07.Size = New System.Drawing.Size(37, 13)
        Me.Label07.TabIndex = 6
        Me.Label07.Text = "Steps:"
        '
        'Label08
        '
        Me.Label08.AutoSize = True
        Me.Label08.Location = New System.Drawing.Point(224, 32)
        Me.Label08.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label08.Name = "Label08"
        Me.Label08.Size = New System.Drawing.Size(37, 13)
        Me.Label08.TabIndex = 8
        Me.Label08.Text = "Steps:"
        '
        'txtINx1
        '
        Me.txtINx1.Location = New System.Drawing.Point(44, 5)
        Me.txtINx1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtINx1.MaxLength = 0
        Me.txtINx1.Name = "txtINx1"
        Me.txtINx1.Size = New System.Drawing.Size(50, 20)
        Me.txtINx1.TabIndex = 0
        Me.txtINx1.Text = "0"
        '
        'txtINx3
        '
        Me.txtINx3.Location = New System.Drawing.Point(260, 5)
        Me.txtINx3.Margin = New System.Windows.Forms.Padding(2)
        Me.txtINx3.MaxLength = 0
        Me.txtINx3.Name = "txtINx3"
        Me.txtINx3.Size = New System.Drawing.Size(50, 20)
        Me.txtINx3.TabIndex = 20
        Me.txtINx3.Text = "20"
        '
        'txtINy3
        '
        Me.txtINy3.Location = New System.Drawing.Point(260, 29)
        Me.txtINy3.Margin = New System.Windows.Forms.Padding(2)
        Me.txtINy3.MaxLength = 0
        Me.txtINy3.Name = "txtINy3"
        Me.txtINy3.Size = New System.Drawing.Size(50, 20)
        Me.txtINy3.TabIndex = 50
        Me.txtINy3.Text = "10"
        '
        'progBar
        '
        Me.progBar.Location = New System.Drawing.Point(4, 78)
        Me.progBar.Name = "progBar"
        Me.progBar.Size = New System.Drawing.Size(306, 45)
        Me.progBar.TabIndex = 0
        '
        'dgvTable
        '
        Me.dgvTable.AllowUserToAddRows = False
        Me.dgvTable.AllowUserToDeleteRows = False
        Me.dgvTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTable.Location = New System.Drawing.Point(5, 167)
        Me.dgvTable.Name = "dgvTable"
        Me.dgvTable.Size = New System.Drawing.Size(752, 194)
        Me.dgvTable.TabIndex = 1000
        '
        'txtINx2
        '
        Me.txtINx2.Location = New System.Drawing.Point(154, 5)
        Me.txtINx2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtINx2.MaxLength = 0
        Me.txtINx2.Name = "txtINx2"
        Me.txtINx2.Size = New System.Drawing.Size(50, 20)
        Me.txtINx2.TabIndex = 10
        Me.txtINx2.Text = "200"
        '
        'Label02
        '
        Me.Label02.AutoSize = True
        Me.Label02.Location = New System.Drawing.Point(114, 8)
        Me.Label02.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label02.Name = "Label02"
        Me.Label02.Size = New System.Drawing.Size(39, 13)
        Me.Label02.TabIndex = 104
        Me.Label02.Text = "X max:"
        '
        'txtINy2
        '
        Me.txtINy2.Location = New System.Drawing.Point(154, 29)
        Me.txtINy2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtINy2.MaxLength = 0
        Me.txtINy2.Name = "txtINy2"
        Me.txtINy2.Size = New System.Drawing.Size(50, 20)
        Me.txtINy2.TabIndex = 40
        Me.txtINy2.Text = "100"
        '
        'Label04
        '
        Me.Label04.AutoSize = True
        Me.Label04.Location = New System.Drawing.Point(114, 32)
        Me.Label04.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label04.Name = "Label04"
        Me.Label04.Size = New System.Drawing.Size(39, 13)
        Me.Label04.TabIndex = 108
        Me.Label04.Text = "Y max:"
        '
        'txtINy1
        '
        Me.txtINy1.Location = New System.Drawing.Point(44, 29)
        Me.txtINy1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtINy1.MaxLength = 0
        Me.txtINy1.Name = "txtINy1"
        Me.txtINy1.Size = New System.Drawing.Size(50, 20)
        Me.txtINy1.TabIndex = 30
        Me.txtINy1.Text = "0"
        '
        'Label03
        '
        Me.Label03.AutoSize = True
        Me.Label03.Location = New System.Drawing.Point(4, 32)
        Me.Label03.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label03.Name = "Label03"
        Me.Label03.Size = New System.Drawing.Size(36, 13)
        Me.Label03.TabIndex = 106
        Me.Label03.Text = "Y min:"
        '
        'txtINz2
        '
        Me.txtINz2.Location = New System.Drawing.Point(154, 53)
        Me.txtINz2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtINz2.MaxLength = 0
        Me.txtINz2.Name = "txtINz2"
        Me.txtINz2.Size = New System.Drawing.Size(50, 20)
        Me.txtINz2.TabIndex = 70
        Me.txtINz2.Text = "10"
        '
        'Label06
        '
        Me.Label06.AutoSize = True
        Me.Label06.Location = New System.Drawing.Point(114, 56)
        Me.Label06.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label06.Name = "Label06"
        Me.Label06.Size = New System.Drawing.Size(39, 13)
        Me.Label06.TabIndex = 112
        Me.Label06.Text = "Z max:"
        '
        'txtINz1
        '
        Me.txtINz1.Location = New System.Drawing.Point(44, 53)
        Me.txtINz1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtINz1.MaxLength = 0
        Me.txtINz1.Name = "txtINz1"
        Me.txtINz1.Size = New System.Drawing.Size(50, 20)
        Me.txtINz1.TabIndex = 60
        Me.txtINz1.Text = "0"
        '
        'Label05
        '
        Me.Label05.AutoSize = True
        Me.Label05.Location = New System.Drawing.Point(4, 56)
        Me.Label05.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label05.Name = "Label05"
        Me.Label05.Size = New System.Drawing.Size(36, 13)
        Me.Label05.TabIndex = 110
        Me.Label05.Text = "Z min:"
        '
        'Button3
        '
        Me.Button3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(326, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(432, 30)
        Me.Button3.TabIndex = 80
        Me.Button3.Text = "Create table data from input"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(326, 36)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(432, 30)
        Me.Button4.TabIndex = 1001
        Me.Button4.Text = "Load table from CSV file..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(326, 67)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(432, 30)
        Me.Button5.TabIndex = 1002
        Me.Button5.Text = "Save table to CSV file..."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 363)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(761, 22)
        Me.StatusStrip1.TabIndex = 1003
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(248, 17)
        Me.ToolStripStatusLabel1.Text = " swTerrainGenerator v.2017.06 - Gianni Castelli"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.IsLink = True
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(141, 17)
        Me.ToolStripStatusLabel2.Text = "gianni.castelli@outlook.it"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 385)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtINz2)
        Me.Controls.Add(Me.Label06)
        Me.Controls.Add(Me.txtINz1)
        Me.Controls.Add(Me.Label05)
        Me.Controls.Add(Me.txtINy2)
        Me.Controls.Add(Me.Label04)
        Me.Controls.Add(Me.txtINy1)
        Me.Controls.Add(Me.Label03)
        Me.Controls.Add(Me.txtINx2)
        Me.Controls.Add(Me.Label02)
        Me.Controls.Add(Me.dgvTable)
        Me.Controls.Add(Me.progBar)
        Me.Controls.Add(Me.txtINy3)
        Me.Controls.Add(Me.txtINx3)
        Me.Controls.Add(Me.txtINx1)
        Me.Controls.Add(Me.Label08)
        Me.Controls.Add(Me.Label07)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label01)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(600, 300)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "swTerrainGenerator"
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label01 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label07 As System.Windows.Forms.Label
    Friend WithEvents Label08 As System.Windows.Forms.Label
    Friend WithEvents txtINx1 As System.Windows.Forms.TextBox
    Friend WithEvents txtINx3 As System.Windows.Forms.TextBox
    Friend WithEvents txtINy3 As System.Windows.Forms.TextBox
    Friend WithEvents progBar As System.Windows.Forms.ProgressBar
    Friend WithEvents dgvTable As System.Windows.Forms.DataGridView
    Friend WithEvents txtINx2 As System.Windows.Forms.TextBox
    Friend WithEvents Label02 As System.Windows.Forms.Label
    Friend WithEvents txtINy2 As System.Windows.Forms.TextBox
    Friend WithEvents Label04 As System.Windows.Forms.Label
    Friend WithEvents txtINy1 As System.Windows.Forms.TextBox
    Friend WithEvents Label03 As System.Windows.Forms.Label
    Friend WithEvents txtINz2 As System.Windows.Forms.TextBox
    Friend WithEvents Label06 As System.Windows.Forms.Label
    Friend WithEvents txtINz1 As System.Windows.Forms.TextBox
    Friend WithEvents Label05 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel

End Class
