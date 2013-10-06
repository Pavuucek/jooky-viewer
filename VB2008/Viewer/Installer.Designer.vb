<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Installer
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
	Public WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
	Public WithEvents cmdOk As System.Windows.Forms.Label
	Public WithEvents cmdCancel As System.Windows.Forms.Label
	Public WithEvents imgBackGround As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Installer))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.File1 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
		Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
		Me.cmdOk = New System.Windows.Forms.Label
		Me.cmdCancel = New System.Windows.Forms.Label
		Me.imgBackGround = New System.Windows.Forms.PictureBox
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.BackColor = System.Drawing.Color.Blue
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Instalátor"
		Me.ClientSize = New System.Drawing.Size(480, 212)
		Me.Location = New System.Drawing.Point(4, 152)
		Me.Icon = CType(resources.GetObject("Installer.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ControlBox = True
		Me.Enabled = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "Installer"
		Me.File1.BackColor = System.Drawing.Color.Black
		Me.File1.ForeColor = System.Drawing.Color.White
		Me.File1.Size = New System.Drawing.Size(161, 150)
		Me.File1.Location = New System.Drawing.Point(312, 8)
		Me.File1.Pattern = "*.ZXC"
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
		Me.RichTextBox1.Size = New System.Drawing.Size(297, 193)
		Me.RichTextBox1.Location = New System.Drawing.Point(8, 8)
		Me.RichTextBox1.TabIndex = 1
		Me.RichTextBox1.BackColor = System.Drawing.Color.White
		Me.RichTextBox1.ReadOnly = True
		Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both
		Me.RichTextBox1.RTF = resources.GetString("RichTextBox1.TextRTF")
		Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.cmdOk.BackColor = System.Drawing.Color.Transparent
		Me.cmdOk.Text = "I&nstalovat"
		Me.cmdOk.Font = New System.Drawing.Font("Arial", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.cmdOk.ForeColor = System.Drawing.Color.Yellow
		Me.cmdOk.Size = New System.Drawing.Size(84, 23)
		Me.cmdOk.Location = New System.Drawing.Point(312, 176)
		Me.cmdOk.TabIndex = 3
		Me.cmdOk.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.cmdOk.Enabled = True
		Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOk.UseMnemonic = True
		Me.cmdOk.Visible = True
		Me.cmdOk.AutoSize = True
		Me.cmdOk.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.cmdOk.Name = "cmdOk"
		Me.cmdCancel.BackColor = System.Drawing.Color.Transparent
		Me.cmdCancel.Text = "&Zavøít"
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.cmdCancel.ForeColor = System.Drawing.Color.Yellow
		Me.cmdCancel.Size = New System.Drawing.Size(51, 23)
		Me.cmdCancel.Location = New System.Drawing.Point(424, 176)
		Me.cmdCancel.TabIndex = 2
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.UseMnemonic = True
		Me.cmdCancel.Visible = True
		Me.cmdCancel.AutoSize = True
		Me.cmdCancel.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.cmdCancel.Name = "cmdCancel"
		Me.imgBackGround.Size = New System.Drawing.Size(545, 249)
		Me.imgBackGround.Location = New System.Drawing.Point(0, 0)
		Me.imgBackGround.Enabled = True
		Me.imgBackGround.Cursor = System.Windows.Forms.Cursors.Default
		Me.imgBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.imgBackGround.Visible = True
		Me.imgBackGround.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.imgBackGround.Name = "imgBackGround"
		Me.Controls.Add(File1)
		Me.Controls.Add(RichTextBox1)
		Me.Controls.Add(cmdOk)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(imgBackGround)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class