<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class MCIfrm
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
	Public WithEvents AMOVIE1 As AxMCI.AxMMControl
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents CloseB As System.Windows.Forms.Label
	Public WithEvents PrNSeTuP As System.Windows.Forms.Label
	Public WithEvents RNDmus As System.Windows.Forms.Label
	Public WithEvents imgBackGround As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MCIfrm))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.File1 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
		Me.AMOVIE1 = New AxMCI.AxMMControl
		Me.Label1 = New System.Windows.Forms.Label
		Me.CloseB = New System.Windows.Forms.Label
		Me.PrNSeTuP = New System.Windows.Forms.Label
		Me.RNDmus = New System.Windows.Forms.Label
		Me.imgBackGround = New System.Windows.Forms.PictureBox
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.AMOVIE1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.BackColor = System.Drawing.Color.Blue
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Ovládací Panel"
		Me.ClientSize = New System.Drawing.Size(504, 245)
		Me.Location = New System.Drawing.Point(51, 114)
		Me.ControlBox = False
		Me.Icon = CType(resources.GetObject("MCIfrm.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "MCIfrm"
		Me.File1.BackColor = System.Drawing.Color.Black
		Me.File1.ForeColor = System.Drawing.Color.White
		Me.File1.Size = New System.Drawing.Size(241, 123)
		Me.File1.Location = New System.Drawing.Point(8, 8)
		Me.File1.Pattern = "*.mid"
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
		AMOVIE1.OcxState = CType(resources.GetObject("AMOVIE1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.AMOVIE1.Size = New System.Drawing.Size(489, 73)
		Me.AMOVIE1.Location = New System.Drawing.Point(8, 160)
		Me.AMOVIE1.TabIndex = 5
		Me.AMOVIE1.Name = "AMOVIE1"
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Text = "Výbìr hudby se provádí zvolením požadovaného souboru v oknì nalevo. Ovládacími prvky napravo se mìní hlasitost."
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Size = New System.Drawing.Size(185, 57)
		Me.Label1.Location = New System.Drawing.Point(256, 56)
		Me.Label1.TabIndex = 4
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.Enabled = True
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.CloseB.BackColor = System.Drawing.Color.Transparent
		Me.CloseB.Text = "&Zavøít"
		Me.CloseB.Font = New System.Drawing.Font("Arial", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.CloseB.ForeColor = System.Drawing.Color.Yellow
		Me.CloseB.Size = New System.Drawing.Size(51, 23)
		Me.CloseB.Location = New System.Drawing.Point(312, 16)
		Me.CloseB.TabIndex = 3
		Me.CloseB.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.CloseB.Enabled = True
		Me.CloseB.Cursor = System.Windows.Forms.Cursors.Default
		Me.CloseB.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CloseB.UseMnemonic = True
		Me.CloseB.Visible = True
		Me.CloseB.AutoSize = True
		Me.CloseB.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.CloseB.Name = "CloseB"
		Me.PrNSeTuP.BackColor = System.Drawing.Color.Transparent
		Me.PrNSeTuP.Text = "Nastavení tiskárny"
		Me.PrNSeTuP.Font = New System.Drawing.Font("Arial", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.PrNSeTuP.ForeColor = System.Drawing.Color.Yellow
		Me.PrNSeTuP.Size = New System.Drawing.Size(161, 23)
		Me.PrNSeTuP.Location = New System.Drawing.Point(264, 32)
		Me.PrNSeTuP.TabIndex = 2
		Me.PrNSeTuP.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.PrNSeTuP.Enabled = True
		Me.PrNSeTuP.Cursor = System.Windows.Forms.Cursors.Default
		Me.PrNSeTuP.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.PrNSeTuP.UseMnemonic = True
		Me.PrNSeTuP.Visible = True
		Me.PrNSeTuP.AutoSize = True
		Me.PrNSeTuP.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.PrNSeTuP.Name = "PrNSeTuP"
		Me.RNDmus.BackColor = System.Drawing.Color.Transparent
		Me.RNDmus.Text = "&Vylosovat Hudbu"
		Me.RNDmus.Font = New System.Drawing.Font("Arial", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.RNDmus.ForeColor = System.Drawing.Color.Yellow
		Me.RNDmus.Size = New System.Drawing.Size(146, 23)
		Me.RNDmus.Location = New System.Drawing.Point(280, 112)
		Me.RNDmus.TabIndex = 1
		Me.RNDmus.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.RNDmus.Enabled = True
		Me.RNDmus.Cursor = System.Windows.Forms.Cursors.Default
		Me.RNDmus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.RNDmus.UseMnemonic = True
		Me.RNDmus.Visible = True
		Me.RNDmus.AutoSize = True
		Me.RNDmus.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.RNDmus.Name = "RNDmus"
		Me.imgBackGround.Size = New System.Drawing.Size(449, 161)
		Me.imgBackGround.Location = New System.Drawing.Point(0, 0)
		Me.imgBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.imgBackGround.Enabled = True
		Me.imgBackGround.Cursor = System.Windows.Forms.Cursors.Default
		Me.imgBackGround.Visible = True
		Me.imgBackGround.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.imgBackGround.Name = "imgBackGround"
		Me.Controls.Add(File1)
		Me.Controls.Add(AMOVIE1)
		Me.Controls.Add(Label1)
		Me.Controls.Add(CloseB)
		Me.Controls.Add(PrNSeTuP)
		Me.Controls.Add(RNDmus)
		Me.Controls.Add(imgBackGround)
		CType(Me.AMOVIE1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class