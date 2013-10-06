<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class TextFRM
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
	Public WithEvents List1 As System.Windows.Forms.ListBox
	Public WithEvents Save As System.Windows.Forms.Button
	Public WithEvents ProgressBar1 As AxComctlLib.AxProgressBar
	Public WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
	Public WithEvents Pix As System.Windows.Forms.Label
	Public WithEvents PrN As System.Windows.Forms.Label
	Public WithEvents Back4 As System.Windows.Forms.Label
	Public WithEvents Verdiktomer As System.Windows.Forms.Label
	Public WithEvents CaP As System.Windows.Forms.Label
	Public WithEvents imgBackGround As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TextFRM))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.List1 = New System.Windows.Forms.ListBox
		Me.Save = New System.Windows.Forms.Button
		Me.ProgressBar1 = New AxComctlLib.AxProgressBar
		Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
		Me.Pix = New System.Windows.Forms.Label
		Me.PrN = New System.Windows.Forms.Label
		Me.Back4 = New System.Windows.Forms.Label
		Me.Verdiktomer = New System.Windows.Forms.Label
		Me.CaP = New System.Windows.Forms.Label
		Me.imgBackGround = New System.Windows.Forms.PictureBox
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.ProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.BackColor = System.Drawing.Color.Blue
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Text = "#"
		Me.ClientSize = New System.Drawing.Size(446, 275)
		Me.Location = New System.Drawing.Point(97, 124)
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
		Me.Name = "TextFRM"
		Me.List1.BackColor = System.Drawing.Color.Black
		Me.List1.ForeColor = System.Drawing.Color.White
		Me.List1.Size = New System.Drawing.Size(225, 87)
		Me.List1.Location = New System.Drawing.Point(8, 328)
		Me.List1.TabIndex = 1
		Me.List1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.List1.CausesValidation = True
		Me.List1.Enabled = True
		Me.List1.IntegralHeight = True
		Me.List1.Cursor = System.Windows.Forms.Cursors.Default
		Me.List1.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.List1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.List1.Sorted = False
		Me.List1.TabStop = True
		Me.List1.Visible = True
		Me.List1.MultiColumn = False
		Me.List1.Name = "List1"
		Me.Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Save.Text = "Save"
		Me.Save.Size = New System.Drawing.Size(33, 17)
		Me.Save.Location = New System.Drawing.Point(152, 0)
		Me.Save.TabIndex = 0
		Me.Save.BackColor = System.Drawing.SystemColors.Control
		Me.Save.CausesValidation = True
		Me.Save.Enabled = True
		Me.Save.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Save.Cursor = System.Windows.Forms.Cursors.Default
		Me.Save.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Save.TabStop = True
		Me.Save.Name = "Save"
		ProgressBar1.OcxState = CType(resources.GetObject("ProgressBar1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.ProgressBar1.Size = New System.Drawing.Size(289, 41)
		Me.ProgressBar1.Location = New System.Drawing.Point(240, 352)
		Me.ProgressBar1.TabIndex = 8
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.RichTextBox1.Size = New System.Drawing.Size(241, 273)
		Me.RichTextBox1.Location = New System.Drawing.Point(0, 24)
		Me.RichTextBox1.TabIndex = 7
		Me.RichTextBox1.BackColor = System.Drawing.Color.White
		Me.RichTextBox1.Enabled = True
		Me.RichTextBox1.HideSelection = False
		Me.RichTextBox1.ReadOnly = True
		Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both
		Me.RichTextBox1.RightMargin = 54
		Me.RichTextBox1.RTF = resources.GetString("RichTextBox1.TextRTF")
		Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.Pix.BackColor = System.Drawing.Color.Transparent
		Me.Pix.Text = "&Obrázky"
		Me.Pix.Font = New System.Drawing.Font("Arial", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.Pix.ForeColor = System.Drawing.Color.Yellow
		Me.Pix.Size = New System.Drawing.Size(74, 23)
		Me.Pix.Location = New System.Drawing.Point(240, 328)
		Me.Pix.TabIndex = 6
		Me.Pix.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Pix.Enabled = True
		Me.Pix.Cursor = System.Windows.Forms.Cursors.Default
		Me.Pix.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Pix.UseMnemonic = True
		Me.Pix.Visible = True
		Me.Pix.AutoSize = True
		Me.Pix.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Pix.Name = "Pix"
		Me.PrN.BackColor = System.Drawing.Color.Transparent
		Me.PrN.Text = "&Nový èl."
		Me.PrN.Font = New System.Drawing.Font("Arial", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.PrN.ForeColor = System.Drawing.Color.Yellow
		Me.PrN.Size = New System.Drawing.Size(69, 23)
		Me.PrN.Location = New System.Drawing.Point(328, 328)
		Me.PrN.TabIndex = 5
		Me.PrN.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.PrN.Enabled = True
		Me.PrN.Cursor = System.Windows.Forms.Cursors.Default
		Me.PrN.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PrN.UseMnemonic = True
		Me.PrN.Visible = True
		Me.PrN.AutoSize = True
		Me.PrN.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.PrN.Name = "PrN"
		Me.Back4.BackColor = System.Drawing.Color.Transparent
		Me.Back4.Text = "<<< &Zpìt"
		Me.Back4.Font = New System.Drawing.Font("Arial", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.Back4.ForeColor = System.Drawing.Color.Yellow
		Me.Back4.Size = New System.Drawing.Size(82, 23)
		Me.Back4.Location = New System.Drawing.Point(448, 328)
		Me.Back4.TabIndex = 4
		Me.Back4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Back4.Enabled = True
		Me.Back4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Back4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Back4.UseMnemonic = True
		Me.Back4.Visible = True
		Me.Back4.AutoSize = True
		Me.Back4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Back4.Name = "Back4"
		Me.Verdiktomer.BackColor = System.Drawing.Color.Transparent
		Me.Verdiktomer.Text = "Mìøiè Hodnocení"
		Me.Verdiktomer.ForeColor = System.Drawing.Color.Yellow
		Me.Verdiktomer.Size = New System.Drawing.Size(118, 16)
		Me.Verdiktomer.Location = New System.Drawing.Point(240, 392)
		Me.Verdiktomer.TabIndex = 3
		Me.Verdiktomer.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Verdiktomer.Enabled = True
		Me.Verdiktomer.Cursor = System.Windows.Forms.Cursors.Default
		Me.Verdiktomer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Verdiktomer.UseMnemonic = True
		Me.Verdiktomer.Visible = True
		Me.Verdiktomer.AutoSize = True
		Me.Verdiktomer.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Verdiktomer.Name = "Verdiktomer"
		Me.CaP.Text = "#"
		Me.CaP.Font = New System.Drawing.Font("Arial", 15!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.CaP.ForeColor = System.Drawing.Color.Yellow
		Me.CaP.Size = New System.Drawing.Size(11, 24)
		Me.CaP.Location = New System.Drawing.Point(16, 0)
		Me.CaP.TabIndex = 2
		Me.CaP.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.CaP.BackColor = System.Drawing.Color.Transparent
		Me.CaP.Enabled = True
		Me.CaP.Cursor = System.Windows.Forms.Cursors.Default
		Me.CaP.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CaP.UseMnemonic = True
		Me.CaP.Visible = True
		Me.CaP.AutoSize = True
		Me.CaP.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.CaP.Name = "CaP"
		Me.imgBackGround.Size = New System.Drawing.Size(585, 449)
		Me.imgBackGround.Location = New System.Drawing.Point(0, 0)
		Me.imgBackGround.Enabled = True
		Me.imgBackGround.Cursor = System.Windows.Forms.Cursors.Default
		Me.imgBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.imgBackGround.Visible = True
		Me.imgBackGround.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.imgBackGround.Name = "imgBackGround"
		Me.Controls.Add(List1)
		Me.Controls.Add(Save)
		Me.Controls.Add(ProgressBar1)
		Me.Controls.Add(RichTextBox1)
		Me.Controls.Add(Pix)
		Me.Controls.Add(PrN)
		Me.Controls.Add(Back4)
		Me.Controls.Add(Verdiktomer)
		Me.Controls.Add(CaP)
		Me.Controls.Add(imgBackGround)
		CType(Me.ProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class