<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class LauncherMain
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
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Close_Renamed As System.Windows.Forms.Button
	Public WithEvents RunE As System.Windows.Forms.Button
	Public WithEvents imgLogo As System.Windows.Forms.PictureBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(LauncherMain))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Command1 = New System.Windows.Forms.Button
		Me.Close_Renamed = New System.Windows.Forms.Button
		Me.RunE = New System.Windows.Forms.Button
		Me.imgLogo = New System.Windows.Forms.PictureBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.ControlBox = False
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.ClientSize = New System.Drawing.Size(376, 189)
		Me.Location = New System.Drawing.Point(145, 195)
		Me.Icon = CType(resources.GetObject("LauncherMain.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "LauncherMain"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "Vytvoøit zástupce"
		Me.Command1.Size = New System.Drawing.Size(113, 25)
		Me.Command1.Location = New System.Drawing.Point(144, 88)
		Me.Command1.TabIndex = 3
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.Close_Renamed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Close_Renamed.Text = "Zavøít"
		Me.Close_Renamed.Size = New System.Drawing.Size(113, 25)
		Me.Close_Renamed.Location = New System.Drawing.Point(144, 120)
		Me.Close_Renamed.TabIndex = 2
		Me.Close_Renamed.BackColor = System.Drawing.SystemColors.Control
		Me.Close_Renamed.CausesValidation = True
		Me.Close_Renamed.Enabled = True
		Me.Close_Renamed.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Close_Renamed.Cursor = System.Windows.Forms.Cursors.Default
		Me.Close_Renamed.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Close_Renamed.TabStop = True
		Me.Close_Renamed.Name = "Close_Renamed"
		Me.RunE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.RunE.Text = "Spustit DiskMag"
		Me.RunE.Size = New System.Drawing.Size(113, 25)
		Me.RunE.Location = New System.Drawing.Point(144, 56)
		Me.RunE.TabIndex = 1
		Me.RunE.BackColor = System.Drawing.SystemColors.Control
		Me.RunE.CausesValidation = True
		Me.RunE.Enabled = True
		Me.RunE.ForeColor = System.Drawing.SystemColors.ControlText
		Me.RunE.Cursor = System.Windows.Forms.Cursors.Default
		Me.RunE.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.RunE.TabStop = True
		Me.RunE.Name = "RunE"
		Me.imgLogo.Size = New System.Drawing.Size(150, 150)
		Me.imgLogo.Location = New System.Drawing.Point(8, 40)
		Me.imgLogo.Cursor = System.Windows.Forms.Cursors.WaitCursor
		Me.imgLogo.Image = CType(resources.GetObject("imgLogo.Image"), System.Drawing.Image)
		Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.imgLogo.Enabled = True
		Me.imgLogo.Visible = True
		Me.imgLogo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.imgLogo.Name = "imgLogo"
		Me.Label1.Text = "DiskMag ENGINE Launcher"
		Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Blue
		Me.Label1.Size = New System.Drawing.Size(359, 38)
		Me.Label1.Location = New System.Drawing.Point(8, 8)
		Me.Label1.TabIndex = 0
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = True
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Controls.Add(Command1)
		Me.Controls.Add(Close_Renamed)
		Me.Controls.Add(RunE)
		Me.Controls.Add(imgLogo)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class