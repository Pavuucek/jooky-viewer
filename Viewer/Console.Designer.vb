<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Console
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
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents LOGboX As System.Windows.Forms.RichTextBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents imbPozadi As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Console))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Text1 = New System.Windows.Forms.TextBox
		Me.LOGboX = New System.Windows.Forms.RichTextBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.imbPozadi = New System.Windows.Forms.PictureBox
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.BackColor = System.Drawing.Color.Blue
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Jooky-Viewer - Command Console"
		Me.ClientSize = New System.Drawing.Size(445, 275)
		Me.Location = New System.Drawing.Point(100, 123)
		Me.MaximizeBox = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.Name = "Console"
		Me.Text1.AutoSize = False
		Me.Text1.BackColor = System.Drawing.Color.Black
		Me.Text1.Size = New System.Drawing.Size(433, 19)
		Me.Text1.Location = New System.Drawing.Point(8, 40)
		Me.Text1.TabIndex = 0
		Me.Text1.Text = "Text1"
		Me.Text1.AcceptsReturn = True
		Me.Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text1.CausesValidation = True
		Me.Text1.Enabled = True
		Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text1.HideSelection = True
		Me.Text1.ReadOnly = False
		Me.Text1.Maxlength = 0
		Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text1.MultiLine = False
		Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text1.TabStop = True
		Me.Text1.Visible = True
		Me.Text1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text1.Name = "Text1"
		Me.LOGboX.Size = New System.Drawing.Size(433, 201)
		Me.LOGboX.Location = New System.Drawing.Point(8, 64)
		Me.LOGboX.TabIndex = 1
		Me.LOGboX.BackColor = System.Drawing.Color.Black
		Me.LOGboX.Enabled = True
		Me.LOGboX.ReadOnly = True
		Me.LOGboX.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
		Me.LOGboX.RTF = resources.GetString("LOGboX.TextRTF")
		Me.LOGboX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.LOGboX.Name = "LOGboX"
		Me.Label1.Text = "Label1"
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Size = New System.Drawing.Size(32, 13)
		Me.Label1.Location = New System.Drawing.Point(8, 8)
		Me.Label1.TabIndex = 2
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Enabled = True
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = True
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.imbPozadi.Size = New System.Drawing.Size(73, 25)
		Me.imbPozadi.Location = New System.Drawing.Point(0, 0)
		Me.imbPozadi.Image = CType(resources.GetObject("imbPozadi.Image"), System.Drawing.Image)
		Me.imbPozadi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.imbPozadi.Enabled = True
		Me.imbPozadi.Cursor = System.Windows.Forms.Cursors.Default
		Me.imbPozadi.Visible = True
		Me.imbPozadi.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.imbPozadi.Name = "imbPozadi"
		Me.Controls.Add(Text1)
		Me.Controls.Add(LOGboX)
		Me.Controls.Add(Label1)
		Me.Controls.Add(imbPozadi)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class