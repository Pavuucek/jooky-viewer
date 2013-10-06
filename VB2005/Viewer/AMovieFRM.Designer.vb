<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class AMovieFRM
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
	Public WithEvents ActiveMovie1 As AxAMovie.AxActiveMovie
	Public WithEvents Back6 As System.Windows.Forms.Label
	Public WithEvents CaP As System.Windows.Forms.Label
	Public WithEvents imgBackGround As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(AMovieFRM))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.File1 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
		Me.ActiveMovie1 = New AxAMovie.AxActiveMovie
		Me.Back6 = New System.Windows.Forms.Label
		Me.CaP = New System.Windows.Forms.Label
		Me.imgBackGround = New System.Windows.Forms.PictureBox
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.ActiveMovie1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.BackColor = System.Drawing.Color.Blue
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Text = "Pøehrávaè"
		Me.ClientSize = New System.Drawing.Size(446, 270)
		Me.Location = New System.Drawing.Point(76, 109)
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
		Me.Name = "AMovieFRM"
		Me.File1.BackColor = System.Drawing.Color.Black
		Me.File1.ForeColor = System.Drawing.Color.White
		Me.File1.Size = New System.Drawing.Size(193, 71)
		Me.File1.Location = New System.Drawing.Point(8, 360)
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
		ActiveMovie1.OcxState = CType(resources.GetObject("ActiveMovie1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.ActiveMovie1.Size = New System.Drawing.Size(266, 74)
		Me.ActiveMovie1.Location = New System.Drawing.Point(0, 24)
		Me.ActiveMovie1.TabIndex = 3
		Me.ActiveMovie1.Name = "ActiveMovie1"
		Me.Back6.BackColor = System.Drawing.Color.Transparent
		Me.Back6.Text = "<<< &Zpìt"
		Me.Back6.Font = New System.Drawing.Font("Arial", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.Back6.ForeColor = System.Drawing.Color.Yellow
		Me.Back6.Size = New System.Drawing.Size(82, 23)
		Me.Back6.Location = New System.Drawing.Point(432, 384)
		Me.Back6.TabIndex = 2
		Me.Back6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Back6.Enabled = True
		Me.Back6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Back6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Back6.UseMnemonic = True
		Me.Back6.Visible = True
		Me.Back6.AutoSize = True
		Me.Back6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Back6.Name = "Back6"
		Me.CaP.BackColor = System.Drawing.Color.Transparent
		Me.CaP.Text = "Pøehrávaè"
		Me.CaP.Font = New System.Drawing.Font("Arial", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.CaP.ForeColor = System.Drawing.Color.Yellow
		Me.CaP.Size = New System.Drawing.Size(89, 23)
		Me.CaP.Location = New System.Drawing.Point(0, 0)
		Me.CaP.TabIndex = 1
		Me.CaP.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.CaP.Enabled = True
		Me.CaP.Cursor = System.Windows.Forms.Cursors.Default
		Me.CaP.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CaP.UseMnemonic = True
		Me.CaP.Visible = True
		Me.CaP.AutoSize = True
		Me.CaP.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.CaP.Name = "CaP"
		Me.imgBackGround.Size = New System.Drawing.Size(761, 537)
		Me.imgBackGround.Location = New System.Drawing.Point(0, 0)
		Me.imgBackGround.Enabled = True
		Me.imgBackGround.Cursor = System.Windows.Forms.Cursors.Default
		Me.imgBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.imgBackGround.Visible = True
		Me.imgBackGround.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.imgBackGround.Name = "imgBackGround"
		Me.Controls.Add(File1)
		Me.Controls.Add(ActiveMovie1)
		Me.Controls.Add(Back6)
		Me.Controls.Add(CaP)
		Me.Controls.Add(imgBackGround)
		CType(Me.ActiveMovie1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class