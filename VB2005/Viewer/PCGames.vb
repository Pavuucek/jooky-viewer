Option Strict Off
Option Explicit On
Friend Class PCGames
	Inherits System.Windows.Forms.Form
	Private Sub Back3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Back3.Click
		Me.Close()
	End Sub
	
	
	Private Sub Back3_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Back3.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		Rec.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Cheatz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back3.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		Nav.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Newz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property PCGames.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property PCGames.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub Cheatz_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cheatz.Click
		PlaySound(11)
		SaveSetting("Harley Software", "Jooky-Viewer", "Window", "Cheaty")
		TextFRM.CaP.Text = "PC Games - Cheaty"
		
		Me.Close()
		TextFRM.Show() 'vbmodal
	End Sub
	
	
	Private Sub Cheatz_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Cheatz.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		Rec.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Cheatz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		Back3.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Nav.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property PCGames.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property PCGames.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		Newz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
	End Sub
	
	
	Private Sub PCGames_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.Icon = Main_Renamed.Icon
		Me.Top = List.Top
		Me.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(List.Left) - VB6.PixelsToTwipsX(Me.Width) - 10)
		DrawBckGround(Me, "PCGames")
	End Sub
	
	Private Sub PCGames_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Rec.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Cheatz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back3.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Nav.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Newz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	
	Private Sub PCGames_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		PlaySound(11)
		List.Enabled = True
		List.Visible = True
		List.Show()
	End Sub
	
	Private Sub Image1_Click()
		
	End Sub
	
	Private Sub imgbackground_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles imgbackground.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Rec.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Cheatz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back3.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Nav.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Newz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	
	Private Sub Nav_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Nav.Click
		PlaySound(11)
		SaveSetting("Harley Software", "Jooky-Viewer", "Window", "Navody")
		TextFRM.CaP.Text = "PC Games - Návody"
		TextFRM.Pix.Enabled = True
		Me.Close()
		TextFRM.Show() 'vbmodal
	End Sub
	
	
	Private Sub Nav_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Nav.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		Rec.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Cheatz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back3.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Nav.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		Newz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property PCGames.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property PCGames.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub Newz_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Newz.Click
		PlaySound(11)
		SaveSetting("Harley Software", "Jooky-Viewer", "Window", "Novinky")
		TextFRM.CaP.Text = "PC Games - Novinky"
		Me.Close()
		TextFRM.Show() 'vbmodal
	End Sub
	
	
	Private Sub Newz_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Newz.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		Rec.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Cheatz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back3.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Nav.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Newz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		'UPGRADE_ISSUE: Form property PCGames.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property PCGames.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub Rec_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Rec.Click
		PlaySound(11)
		SaveSetting("Harley Software", "Jooky-Viewer", "Window", "Recenze")
		TextFRM.CaP.Text = "PC Games - Recenze"
		Me.Close()
		TextFRM.Show() 'vbmodal
	End Sub
	
	
	Private Sub Uvodnik_Click()
		
	End Sub
	
	
	Private Sub Rec_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Rec.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		Rec.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		Cheatz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back3.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Nav.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Newz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property PCGames.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property PCGames.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	Private Sub Timer1_Timer()
	End Sub
	
	
	Private Sub Timer2_Timer()
	End Sub
End Class