<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSplash
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
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents MK As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents LblOS As System.Windows.Forms.Label
	Public WithEvents LblJV As System.Windows.Forms.Label
	Public WithEvents lblML As System.Windows.Forms.Label
	Public WithEvents LblCredits As System.Windows.Forms.Label
	Public WithEvents stav As System.Windows.Forms.Label
	Public WithEvents imgLogo As System.Windows.Forms.PictureBox
	Public WithEvents lblCopyright As System.Windows.Forms.Label
	Public WithEvents lblCompany As System.Windows.Forms.Label
	Public WithEvents lblVersion As System.Windows.Forms.Label
	Public WithEvents lblPlatform As System.Windows.Forms.Label
	Public WithEvents lblProductName As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents ProgressBar1 As AxComctlLib.AxProgressBar
	Public WithEvents StatCon As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSplash))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Image1 = New System.Windows.Forms.PictureBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.MK = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.LblOS = New System.Windows.Forms.Label
		Me.LblJV = New System.Windows.Forms.Label
		Me.lblML = New System.Windows.Forms.Label
		Me.LblCredits = New System.Windows.Forms.Label
		Me.stav = New System.Windows.Forms.Label
		Me.imgLogo = New System.Windows.Forms.PictureBox
		Me.lblCopyright = New System.Windows.Forms.Label
		Me.lblCompany = New System.Windows.Forms.Label
		Me.lblVersion = New System.Windows.Forms.Label
		Me.lblPlatform = New System.Windows.Forms.Label
		Me.lblProductName = New System.Windows.Forms.Label
		Me.ProgressBar1 = New AxComctlLib.AxProgressBar
		Me.StatCon = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.ProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.ControlBox = False
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.ClientSize = New System.Drawing.Size(510, 288)
		Me.Location = New System.Drawing.Point(17, 94)
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.Enabled = True
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmSplash"
		Me.Frame1.Size = New System.Drawing.Size(495, 270)
		Me.Frame1.Location = New System.Drawing.Point(8, 8)
		Me.Frame1.TabIndex = 0
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.Image1.Size = New System.Drawing.Size(122, 90)
		Me.Image1.Location = New System.Drawing.Point(368, 176)
		Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
		Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.Image1.Enabled = True
		Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image1.Visible = True
		Me.Image1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image1.Name = "Image1"
		Me.Label3.Text = "Jooky - Viewer"
		Me.Label3.ForeColor = System.Drawing.Color.Black
		Me.Label3.Size = New System.Drawing.Size(110, 16)
		Me.Label3.Location = New System.Drawing.Point(8, 0)
		Me.Label3.TabIndex = 14
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = True
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label2.Text = "Toto je náš Maskot"
		Me.Label2.Size = New System.Drawing.Size(91, 13)
		Me.Label2.Location = New System.Drawing.Point(8, 160)
		Me.Label2.TabIndex = 13
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = True
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.MK.Text = "Michal ""Spider"" Kuncl"
		Me.MK.Size = New System.Drawing.Size(104, 13)
		Me.MK.Location = New System.Drawing.Point(112, 200)
		Me.MK.TabIndex = 12
		Me.MK.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.MK.BackColor = System.Drawing.Color.Transparent
		Me.MK.Enabled = True
		Me.MK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.MK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.MK.UseMnemonic = True
		Me.MK.Visible = True
		Me.MK.AutoSize = True
		Me.MK.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.MK.Name = "MK"
		Me.Label1.Text = "PROGRAMMER:"
		Me.Label1.Size = New System.Drawing.Size(94, 13)
		Me.Label1.Location = New System.Drawing.Point(112, 184)
		Me.Label1.TabIndex = 11
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = True
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.LblOS.Text = "Oldøich Strachota"
		Me.LblOS.Size = New System.Drawing.Size(83, 13)
		Me.LblOS.Location = New System.Drawing.Point(8, 232)
		Me.LblOS.TabIndex = 10
		Me.LblOS.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.LblOS.BackColor = System.Drawing.SystemColors.Control
		Me.LblOS.Enabled = True
		Me.LblOS.ForeColor = System.Drawing.SystemColors.ControlText
		Me.LblOS.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.LblOS.UseMnemonic = True
		Me.LblOS.Visible = True
		Me.LblOS.AutoSize = True
		Me.LblOS.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.LblOS.Name = "LblOS"
		Me.LblJV.Text = "Jaromír Víša"
		Me.LblJV.Size = New System.Drawing.Size(58, 13)
		Me.LblJV.Location = New System.Drawing.Point(8, 216)
		Me.LblJV.TabIndex = 9
		Me.LblJV.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.LblJV.BackColor = System.Drawing.SystemColors.Control
		Me.LblJV.Enabled = True
		Me.LblJV.ForeColor = System.Drawing.SystemColors.ControlText
		Me.LblJV.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.LblJV.UseMnemonic = True
		Me.LblJV.Visible = True
		Me.LblJV.AutoSize = True
		Me.LblJV.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.LblJV.Name = "LblJV"
		Me.lblML.Text = "Martin Lux"
		Me.lblML.Size = New System.Drawing.Size(49, 13)
		Me.lblML.Location = New System.Drawing.Point(8, 200)
		Me.lblML.TabIndex = 8
		Me.lblML.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblML.BackColor = System.Drawing.SystemColors.Control
		Me.lblML.Enabled = True
		Me.lblML.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblML.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblML.UseMnemonic = True
		Me.lblML.Visible = True
		Me.lblML.AutoSize = True
		Me.lblML.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblML.Name = "lblML"
		Me.LblCredits.Text = "CREDITS:"
		Me.LblCredits.Size = New System.Drawing.Size(59, 13)
		Me.LblCredits.Location = New System.Drawing.Point(8, 184)
		Me.LblCredits.TabIndex = 7
		Me.LblCredits.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.LblCredits.BackColor = System.Drawing.SystemColors.Control
		Me.LblCredits.Enabled = True
		Me.LblCredits.ForeColor = System.Drawing.SystemColors.ControlText
		Me.LblCredits.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.LblCredits.UseMnemonic = True
		Me.LblCredits.Visible = True
		Me.LblCredits.AutoSize = True
		Me.LblCredits.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.LblCredits.Name = "LblCredits"
		Me.stav.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.stav.Text = "Formating Hard Drive ..."
		Me.stav.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.stav.ForeColor = System.Drawing.Color.FromARGB(0, 128, 0)
		Me.stav.Size = New System.Drawing.Size(310, 33)
		Me.stav.Location = New System.Drawing.Point(136, 128)
		Me.stav.TabIndex = 6
		Me.stav.BackColor = System.Drawing.SystemColors.Control
		Me.stav.Enabled = True
		Me.stav.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.stav.UseMnemonic = True
		Me.stav.Visible = True
		Me.stav.AutoSize = True
		Me.stav.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.stav.Name = "stav"
		Me.imgLogo.Size = New System.Drawing.Size(150, 150)
		Me.imgLogo.Location = New System.Drawing.Point(8, 24)
		Me.imgLogo.Image = CType(resources.GetObject("imgLogo.Image"), System.Drawing.Image)
		Me.imgLogo.Enabled = True
		Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.imgLogo.Visible = True
		Me.imgLogo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.imgLogo.Name = "imgLogo"
		Me.lblCopyright.Text = "Václav ""DarkLogic"" Návrat"
		Me.lblCopyright.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCopyright.Size = New System.Drawing.Size(128, 14)
		Me.lblCopyright.Location = New System.Drawing.Point(8, 248)
		Me.lblCopyright.TabIndex = 2
		Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCopyright.BackColor = System.Drawing.SystemColors.Control
		Me.lblCopyright.Enabled = True
		Me.lblCopyright.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCopyright.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCopyright.UseMnemonic = True
		Me.lblCopyright.Visible = True
		Me.lblCopyright.AutoSize = True
		Me.lblCopyright.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCopyright.Name = "lblCopyright"
		Me.lblCompany.Text = "© Harley Software  Ltd. 1997 - 1999"
		Me.lblCompany.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCompany.Size = New System.Drawing.Size(176, 14)
		Me.lblCompany.Location = New System.Drawing.Point(112, 216)
		Me.lblCompany.TabIndex = 1
		Me.lblCompany.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblCompany.BackColor = System.Drawing.SystemColors.Control
		Me.lblCompany.Enabled = True
		Me.lblCompany.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCompany.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblCompany.UseMnemonic = True
		Me.lblCompany.Visible = True
		Me.lblCompany.AutoSize = True
		Me.lblCompany.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblCompany.Name = "lblCompany"
		Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblVersion.Text = "verze 1.0"
		Me.lblVersion.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVersion.ForeColor = System.Drawing.Color.Red
		Me.lblVersion.Size = New System.Drawing.Size(68, 19)
		Me.lblVersion.Location = New System.Drawing.Point(424, 64)
		Me.lblVersion.TabIndex = 3
		Me.lblVersion.BackColor = System.Drawing.SystemColors.Control
		Me.lblVersion.Enabled = True
		Me.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVersion.UseMnemonic = True
		Me.lblVersion.Visible = True
		Me.lblVersion.AutoSize = True
		Me.lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVersion.Name = "lblVersion"
		Me.lblPlatform.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblPlatform.Text = "for Windows 98, 95 nebo NT 4.0"
		Me.lblPlatform.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPlatform.Size = New System.Drawing.Size(318, 24)
		Me.lblPlatform.Location = New System.Drawing.Point(142, 80)
		Me.lblPlatform.TabIndex = 4
		Me.lblPlatform.BackColor = System.Drawing.SystemColors.Control
		Me.lblPlatform.Enabled = True
		Me.lblPlatform.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPlatform.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPlatform.UseMnemonic = True
		Me.lblPlatform.Visible = True
		Me.lblPlatform.AutoSize = True
		Me.lblPlatform.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPlatform.Name = "lblPlatform"
		Me.lblProductName.Text = "DiskMag ENGINE"
		Me.lblProductName.Font = New System.Drawing.Font("Arial", 32.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProductName.ForeColor = System.Drawing.Color.Blue
		Me.lblProductName.Size = New System.Drawing.Size(355, 51)
		Me.lblProductName.Location = New System.Drawing.Point(136, 16)
		Me.lblProductName.TabIndex = 5
		Me.lblProductName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblProductName.BackColor = System.Drawing.SystemColors.Control
		Me.lblProductName.Enabled = True
		Me.lblProductName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblProductName.UseMnemonic = True
		Me.lblProductName.Visible = True
		Me.lblProductName.AutoSize = True
		Me.lblProductName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblProductName.Name = "lblProductName"
		ProgressBar1.OcxState = CType(resources.GetObject("ProgressBar1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.ProgressBar1.Size = New System.Drawing.Size(481, 41)
		Me.ProgressBar1.Location = New System.Drawing.Point(88, 336)
		Me.ProgressBar1.TabIndex = 16
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.StatCon.Text = "@@@"
		Me.StatCon.Size = New System.Drawing.Size(37, 13)
		Me.StatCon.Location = New System.Drawing.Point(8, 280)
		Me.StatCon.TabIndex = 15
		Me.StatCon.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.StatCon.BackColor = System.Drawing.SystemColors.Control
		Me.StatCon.Enabled = True
		Me.StatCon.ForeColor = System.Drawing.SystemColors.ControlText
		Me.StatCon.Cursor = System.Windows.Forms.Cursors.Default
		Me.StatCon.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.StatCon.UseMnemonic = True
		Me.StatCon.Visible = True
		Me.StatCon.AutoSize = True
		Me.StatCon.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.StatCon.Name = "StatCon"
		Me.Controls.Add(Frame1)
		Me.Controls.Add(ProgressBar1)
		Me.Controls.Add(StatCon)
		Me.Frame1.Controls.Add(Image1)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(MK)
		Me.Frame1.Controls.Add(Label1)
		Me.Frame1.Controls.Add(LblOS)
		Me.Frame1.Controls.Add(LblJV)
		Me.Frame1.Controls.Add(lblML)
		Me.Frame1.Controls.Add(LblCredits)
		Me.Frame1.Controls.Add(stav)
		Me.Frame1.Controls.Add(imgLogo)
		Me.Frame1.Controls.Add(lblCopyright)
		Me.Frame1.Controls.Add(lblCompany)
		Me.Frame1.Controls.Add(lblVersion)
		Me.Frame1.Controls.Add(lblPlatform)
		Me.Frame1.Controls.Add(lblProductName)
		CType(Me.ProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class