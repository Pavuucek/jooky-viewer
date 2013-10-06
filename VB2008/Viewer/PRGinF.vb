Option Strict Off
Option Explicit On
Friend Class PRGinF
	Inherits System.Windows.Forms.Form
	
	Private Sub CloseX_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CloseX.Click
		PlaySound(11)
		ConsoleWrite("ABOUT.uninit")
		Me.Close()
	End Sub
	
	Private Sub CloseX_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles CloseX.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		CloseX.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		'UPGRADE_ISSUE: Form property PRGinF.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property PRGinF.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub PRGinF_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		ConsoleWrite("ABOUT.init")
		Image1.Image = List.Icon.ToBitmap
		CenterForm(Me)
		Me.Icon = Main_Renamed.Icon
	End Sub
	
	
	Private Sub PRGinF_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		CloseX.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	
	Private Sub Image1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Image1.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		CloseX.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
End Class