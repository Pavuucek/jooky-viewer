<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class PRGinF
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
	Public WithEvents CloseX As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PRGinF))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Image1 = New System.Windows.Forms.PictureBox
		Me.CloseX = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.BackColor = System.Drawing.Color.Blue
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Informace o Programu"
		Me.ClientSize = New System.Drawing.Size(322, 332)
		Me.Location = New System.Drawing.Point(156, 151)
		Me.ControlBox = False
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
		Me.Name = "PRGinF"
		Me.Image1.Size = New System.Drawing.Size(289, 169)
		Me.Image1.Location = New System.Drawing.Point(8, 120)
		Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.Image1.Enabled = True
		Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image1.Visible = True
		Me.Image1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image1.Name = "Image1"
		Me.CloseX.BackColor = System.Drawing.Color.Blue
		Me.CloseX.Text = "&Zavøít"
		Me.CloseX.Font = New System.Drawing.Font("Arial", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
		Me.CloseX.ForeColor = System.Drawing.Color.Yellow
		Me.CloseX.Size = New System.Drawing.Size(51, 23)
		Me.CloseX.Location = New System.Drawing.Point(120, 296)
		Me.CloseX.TabIndex = 6
		Me.CloseX.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.CloseX.Enabled = True
		Me.CloseX.Cursor = System.Windows.Forms.Cursors.Default
		Me.CloseX.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CloseX.UseMnemonic = True
		Me.CloseX.Visible = True
		Me.CloseX.AutoSize = True
		Me.CloseX.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.CloseX.Name = "CloseX"
		Me.Label6.BackColor = System.Drawing.Color.Blue
		Me.Label6.Text = "Toto je verze pro WINDOWS 95/98"
		Me.Label6.ForeColor = System.Drawing.Color.Yellow
		Me.Label6.Size = New System.Drawing.Size(241, 16)
		Me.Label6.Location = New System.Drawing.Point(8, 96)
		Me.Label6.TabIndex = 5
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.Enabled = True
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = True
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Label5.BackColor = System.Drawing.Color.Blue
		Me.Label5.Text = "e-mail     : MKuncl@POST.CZ"
		Me.Label5.ForeColor = System.Drawing.Color.Yellow
		Me.Label5.Size = New System.Drawing.Size(200, 16)
		Me.Label5.Location = New System.Drawing.Point(8, 72)
		Me.Label5.TabIndex = 4
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.Enabled = True
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = True
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label4.BackColor = System.Drawing.Color.Blue
		Me.Label4.Text = "Adresa   : Smetanova 448, Votice 259 01"
		Me.Label4.ForeColor = System.Drawing.Color.Yellow
		Me.Label4.Size = New System.Drawing.Size(277, 16)
		Me.Label4.Location = New System.Drawing.Point(8, 48)
		Me.Label4.TabIndex = 3
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.Enabled = True
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = True
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label3.BackColor = System.Drawing.Color.Blue
		Me.Label3.Text = "Firma      : Harley Software ltd."
		Me.Label3.ForeColor = System.Drawing.Color.Yellow
		Me.Label3.Size = New System.Drawing.Size(207, 16)
		Me.Label3.Location = New System.Drawing.Point(8, 32)
		Me.Label3.TabIndex = 2
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.Enabled = True
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = True
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label2.BackColor = System.Drawing.Color.Blue
		Me.Label2.Text = "Autor       : Michal Kuncl"
		Me.Label2.ForeColor = System.Drawing.Color.Yellow
		Me.Label2.Size = New System.Drawing.Size(159, 16)
		Me.Label2.Location = New System.Drawing.Point(8, 16)
		Me.Label2.TabIndex = 1
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.Enabled = True
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = True
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.BackColor = System.Drawing.Color.Blue
		Me.Label1.Text = "Program : Jooky-Viewer - DiskMag ENGINE"
		Me.Label1.ForeColor = System.Drawing.Color.Yellow
		Me.Label1.Size = New System.Drawing.Size(301, 16)
		Me.Label1.Location = New System.Drawing.Point(8, 0)
		Me.Label1.TabIndex = 0
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.Enabled = True
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = True
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Controls.Add(Image1)
		Me.Controls.Add(CloseX)
		Me.Controls.Add(Label6)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class