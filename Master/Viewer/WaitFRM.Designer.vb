<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class WaitFRM
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
	Public WithEvents stav As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(WaitFRM))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.stav = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.ControlBox = False
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.ClientSize = New System.Drawing.Size(320, 51)
		Me.Location = New System.Drawing.Point(39, 156)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.Enabled = True
		Me.KeyPreview = False
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "WaitFRM"
		Me.stav.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.stav.BackColor = System.Drawing.Color.Black
		Me.stav.Text = "Loading, please wait ..."
		Me.stav.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.stav.ForeColor = System.Drawing.Color.Yellow
		Me.stav.Size = New System.Drawing.Size(303, 37)
		Me.stav.Location = New System.Drawing.Point(8, 8)
		Me.stav.TabIndex = 0
		Me.stav.Enabled = True
		Me.stav.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.stav.UseMnemonic = True
		Me.stav.Visible = True
		Me.stav.AutoSize = True
		Me.stav.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.stav.Name = "stav"
		Me.Controls.Add(stav)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class