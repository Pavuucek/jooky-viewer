<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class PixFRM
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents File1 As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
	Public WithEvents PopiseK As System.Windows.Forms.Label
	Public WithEvents CaP As System.Windows.Forms.Label
	Public WithEvents Back As System.Windows.Forms.Label
	Public WithEvents PrN As System.Windows.Forms.Label
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PixFRM))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.File1 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
		Me.PopiseK = New System.Windows.Forms.Label
		Me.CaP = New System.Windows.Forms.Label
		Me.Back = New System.Windows.Forms.Label
		Me.PrN = New System.Windows.Forms.Label
		Me.Image1 = New System.Windows.Forms.PictureBox
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.BackColor = System.Drawing.Color.Blue
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Text = "Obrázky"
		Me.ClientSize = New System.Drawing.Size(445, 276)
		Me.Location = New System.Drawing.Point(94, 175)
		Me.ControlBox = False
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.Name = "PixFRM"
		Me.File1.BackColor = System.Drawing.Color.Black
		Me.File1.ForeColor = System.Drawing.Color.White
		Me.File1.Size = New System.Drawing.Size(65, 58)
		Me.File1.Location = New System.Drawing.Point(8, 64)
		Me.File1.Pattern = "*.bmp"
		Me.File1.TabIndex = 0
		Me.File1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.File1.Archive = True
		Me.File1.CausesValidation = True
		Me.File1.Enabled = True
		Me.File1.Hidden = False
		Me.File1.Cursor = System.Windows.Forms.Cursors.Default
		Me.File1.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.File1.Normal = True
		Me.File1.ReadOnly = True
		Me.File1.System = False
		Me.File1.TabStop = True
		Me.File1.TopIndex = 0
		Me.File1.Visible = True
		Me.File1.Name = "File1"
		Me.PopiseK.BackColor = System.Drawing.Color.Transparent
		Me.PopiseK.Text = "@@@"
		Me.PopiseK.ForeColor = System.Drawing.Color.Yellow
		Me.PopiseK.Size = New System.Drawing.Size(65, 41)
		Me.PopiseK.Location = New System.Drawing.Point(96, 16)
		Me.PopiseK.TabIndex = 4
		Me.PopiseK.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.PopiseK.Enabled = True
		Me.PopiseK.Cursor = System.Windows.Forms.Cursors.Default
		Me.PopiseK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PopiseK.UseMnemonic = True
		Me.PopiseK.Visible = True
		Me.PopiseK.AutoSize = False
		Me.PopiseK.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.PopiseK.Name = "PopiseK"
		Me.CaP.BackColor = System.Drawing.Color.Transparent
		Me.CaP.Text = "Obrázky"
		Me.CaP.Font = New System.Drawing.Font("Arial", 15!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline Or System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.CaP.ForeColor = System.Drawing.Color.Yellow
		Me.CaP.Size = New System.Drawing.Size(79, 24)
		Me.CaP.Location = New System.Drawing.Point(0, 0)
		Me.CaP.TabIndex = 3
		Me.CaP.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.CaP.Enabled = True
		Me.CaP.Cursor = System.Windows.Forms.Cursors.Default
		Me.CaP.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CaP.UseMnemonic = True
		Me.CaP.Visible = True
		Me.CaP.AutoSize = True
		Me.CaP.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.CaP.Name = "CaP"
		Me.Back.BackColor = System.Drawing.Color.Transparent
		Me.Back.Text = "Zpìt"
		Me.Back.Font = New System.Drawing.Font("Arial", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.Back.ForeColor = System.Drawing.Color.Yellow
		Me.Back.Size = New System.Drawing.Size(40, 23)
		Me.Back.Location = New System.Drawing.Point(0, 32)
		Me.Back.TabIndex = 2
		Me.Back.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Back.Enabled = True
		Me.Back.Cursor = System.Windows.Forms.Cursors.Default
		Me.Back.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Back.UseMnemonic = True
		Me.Back.Visible = True
		Me.Back.AutoSize = True
		Me.Back.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Back.Name = "Back"
		Me.PrN.BackColor = System.Drawing.Color.Transparent
		Me.PrN.Text = "Tisk"
		Me.PrN.Font = New System.Drawing.Font("Arial", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.PrN.ForeColor = System.Drawing.Color.Yellow
		Me.PrN.Size = New System.Drawing.Size(36, 23)
		Me.PrN.Location = New System.Drawing.Point(48, 32)
		Me.PrN.TabIndex = 1
		Me.PrN.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.PrN.Enabled = True
		Me.PrN.Cursor = System.Windows.Forms.Cursors.Default
		Me.PrN.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PrN.UseMnemonic = True
		Me.PrN.Visible = True
		Me.PrN.AutoSize = True
		Me.PrN.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.PrN.Name = "PrN"
		Me.Image1.Size = New System.Drawing.Size(289, 233)
		Me.Image1.Location = New System.Drawing.Point(56, 216)
		Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.Image1.Enabled = True
		Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image1.Visible = True
		Me.Image1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image1.Name = "Image1"
		Me.Controls.Add(File1)
		Me.Controls.Add(PopiseK)
		Me.Controls.Add(CaP)
		Me.Controls.Add(Back)
		Me.Controls.Add(PrN)
		Me.Controls.Add(Image1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class