<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class PCGames
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
	Public WithEvents Rec As System.Windows.Forms.Label
	Public WithEvents Newz As System.Windows.Forms.Label
	Public WithEvents Nav As System.Windows.Forms.Label
	Public WithEvents Cheatz As System.Windows.Forms.Label
	Public WithEvents Back3 As System.Windows.Forms.Label
	Public WithEvents imgBackGround As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PCGames))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Rec = New System.Windows.Forms.Label
		Me.Newz = New System.Windows.Forms.Label
		Me.Nav = New System.Windows.Forms.Label
		Me.Cheatz = New System.Windows.Forms.Label
		Me.Back3 = New System.Windows.Forms.Label
		Me.imgBackGround = New System.Windows.Forms.PictureBox
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.BackColor = System.Drawing.Color.Blue
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Text = "PC Games"
		Me.ClientSize = New System.Drawing.Size(115, 171)
		Me.Location = New System.Drawing.Point(164, 179)
		Me.ForeColor = System.Drawing.Color.Blue
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "PCGames"
		Me.Rec.BackColor = System.Drawing.Color.Transparent
		Me.Rec.Text = "&Recenze"
		Me.Rec.Font = New System.Drawing.Font("Arial", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.Rec.ForeColor = System.Drawing.Color.Yellow
		Me.Rec.Size = New System.Drawing.Size(76, 23)
		Me.Rec.Location = New System.Drawing.Point(16, 0)
		Me.Rec.TabIndex = 4
		Me.Rec.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Rec.Enabled = True
		Me.Rec.Cursor = System.Windows.Forms.Cursors.Default
		Me.Rec.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Rec.UseMnemonic = True
		Me.Rec.Visible = True
		Me.Rec.AutoSize = True
		Me.Rec.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Rec.Name = "Rec"
		Me.Newz.BackColor = System.Drawing.Color.Transparent
		Me.Newz.Text = "N&ovinky"
		Me.Newz.Font = New System.Drawing.Font("Arial", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.Newz.ForeColor = System.Drawing.Color.Yellow
		Me.Newz.Size = New System.Drawing.Size(67, 23)
		Me.Newz.Location = New System.Drawing.Point(16, 32)
		Me.Newz.TabIndex = 3
		Me.Newz.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Newz.Enabled = True
		Me.Newz.Cursor = System.Windows.Forms.Cursors.Default
		Me.Newz.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Newz.UseMnemonic = True
		Me.Newz.Visible = True
		Me.Newz.AutoSize = True
		Me.Newz.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Newz.Name = "Newz"
		Me.Nav.BackColor = System.Drawing.Color.Transparent
		Me.Nav.Text = "&Návody"
		Me.Nav.Font = New System.Drawing.Font("Arial", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.Nav.ForeColor = System.Drawing.Color.Yellow
		Me.Nav.Size = New System.Drawing.Size(65, 23)
		Me.Nav.Location = New System.Drawing.Point(16, 64)
		Me.Nav.TabIndex = 2
		Me.Nav.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Nav.Enabled = True
		Me.Nav.Cursor = System.Windows.Forms.Cursors.Default
		Me.Nav.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Nav.UseMnemonic = True
		Me.Nav.Visible = True
		Me.Nav.AutoSize = True
		Me.Nav.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Nav.Name = "Nav"
		Me.Cheatz.BackColor = System.Drawing.Color.Transparent
		Me.Cheatz.Text = "&Cheaty"
		Me.Cheatz.Font = New System.Drawing.Font("Arial", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.Cheatz.ForeColor = System.Drawing.Color.Yellow
		Me.Cheatz.Size = New System.Drawing.Size(62, 23)
		Me.Cheatz.Location = New System.Drawing.Point(16, 96)
		Me.Cheatz.TabIndex = 1
		Me.Cheatz.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Cheatz.Enabled = True
		Me.Cheatz.Cursor = System.Windows.Forms.Cursors.Default
		Me.Cheatz.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Cheatz.UseMnemonic = True
		Me.Cheatz.Visible = True
		Me.Cheatz.AutoSize = True
		Me.Cheatz.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Cheatz.Name = "Cheatz"
		Me.Back3.BackColor = System.Drawing.Color.Transparent
		Me.Back3.Text = "<<< &Zpìt"
		Me.Back3.Font = New System.Drawing.Font("Arial", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.Back3.ForeColor = System.Drawing.Color.Yellow
		Me.Back3.Size = New System.Drawing.Size(82, 23)
		Me.Back3.Location = New System.Drawing.Point(8, 136)
		Me.Back3.TabIndex = 0
		Me.Back3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Back3.Enabled = True
		Me.Back3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Back3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Back3.UseMnemonic = True
		Me.Back3.Visible = True
		Me.Back3.AutoSize = True
		Me.Back3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Back3.Name = "Back3"
		Me.imgBackGround.Size = New System.Drawing.Size(161, 201)
		Me.imgBackGround.Location = New System.Drawing.Point(0, 0)
		Me.imgBackGround.Enabled = True
		Me.imgBackGround.Cursor = System.Windows.Forms.Cursors.Default
		Me.imgBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.imgBackGround.Visible = True
		Me.imgBackGround.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.imgBackGround.Name = "imgBackGround"
		Me.Controls.Add(Rec)
		Me.Controls.Add(Newz)
		Me.Controls.Add(Nav)
		Me.Controls.Add(Cheatz)
		Me.Controls.Add(Back3)
		Me.Controls.Add(imgBackGround)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class