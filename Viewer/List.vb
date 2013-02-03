Option Strict Off
Option Explicit On
Friend Class List
	Inherits System.Windows.Forms.Form
	Private Sub MoveFocus(ByVal bTn As System.Windows.Forms.Label, ByVal iMg As System.Windows.Forms.PictureBox)
		With iMg
			.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(bTn.Left))
			.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(bTn.Top))
			.Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(bTn.Height))
			.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(bTn.Width))
		End With
	End Sub
	
	Private Sub Ankh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Ankh.Click
		PlaySound(11)
		SaveSetting("Harley Software", "Jooky-Viewer", "Window", "Anketa")
		TextFRM.Pix.Enabled = True
		TextFRM.CaP.Text = "Anketa"
		Me.Close()
		TextFRM.Show() 'vbmodal
	End Sub
	
	Private Sub Ankh_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Ankh.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		Uvodnik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		PCGamez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Soft.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Reda.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CD.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ankh.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		Inet.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Moviez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Learn.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Mjuzik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ruzne.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Letterz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Future.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Bux.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property List.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        'Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property List.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub back_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles back.Click
		Me.Close()
	End Sub
	
	Private Sub Bublinx_Click()
		PlaySound(11)
		SaveSetting("Harley Software", "Jooky-Viewer", "Window", "0")
		SaveSetting("Harley Software", "Jooky-Viewer", "Window", "Bublinky")
		TextFRM.Pix.Enabled = True
		TextFRM.Text = "Bublinky"
		Me.Close()
		TextFRM.Show()
	End Sub
	
	
	Private Sub Back_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Back.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		Uvodnik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		PCGamez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Soft.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Reda.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CD.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ankh.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inet.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Moviez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Learn.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Mjuzik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ruzne.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Letterz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Future.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		Bux.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property List.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        'Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property List.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	Private Sub Bux_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Bux.Click
		PlaySound(11)
		SaveSetting("Harley Software", "Jooky-Viewer", "Window", "Knihy")
		TextFRM.Pix.Enabled = True
		TextFRM.CaP.Text = "Literatùra"
		Me.Close()
		TextFRM.Show() 'vbmodal
	End Sub
	
	Private Sub Bux_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Bux.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		Uvodnik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		PCGamez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Soft.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Reda.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CD.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ankh.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inet.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Moviez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Learn.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Mjuzik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ruzne.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Letterz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Future.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Bux.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		'UPGRADE_ISSUE: Form property List.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        'Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property List.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub CD_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CD.Click
		PlaySound(11)
		SaveSetting("Harley Software", "Jooky-Viewer", "Window", "CD")
		TextFRM.Pix.Enabled = True
		TextFRM.CaP.Text = "Obsah CD"
		Me.Close()
		TextFRM.Show()
	End Sub
	
	Private Sub Command1_Click()
		back_Click(back, New System.EventArgs())
	End Sub
	
	Private Sub CD_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles CD.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		Uvodnik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		PCGamez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Soft.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Reda.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CD.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		Ankh.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inet.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Moviez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Learn.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Mjuzik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ruzne.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Letterz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Future.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Bux.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property List.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        'Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property List.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	Private Sub List_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		CenterForm(Me)
		DrawBckGround(Me, "List")
		ConsoleWrite("LIST.init")
		CD.Enabled = False
		CD.Visible = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub List_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = eventArgs.X
		Dim Y As Single = eventArgs.Y
		Uvodnik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		PCGamez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Soft.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Reda.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CD.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ankh.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inet.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Moviez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Learn.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Mjuzik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ruzne.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Letterz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Future.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Bux.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	
	Private Sub List_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		PlaySound(11)
		ConsoleWrite("LIST.uninit")
		Main_Renamed.Show()
		Main_Renamed.Enabled = True
	End Sub
	
	Private Sub Future_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Future.Click
		PlaySound(11)
		SaveSetting("Harley Software", "Jooky-Viewer", "Window", "Budoucno")
		TextFRM.Pix.Enabled = True
		TextFRM.CaP.Text = "Pohled do Budoucna"
		Me.Close()
		TextFRM.Show() 'vbmodal
	End Sub
	
	Private Sub Future_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Future.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		Uvodnik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		PCGamez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Soft.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Reda.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CD.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ankh.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inet.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Moviez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Learn.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Mjuzik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ruzne.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Letterz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Future.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		Back.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Bux.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property List.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        'Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property List.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub Image1_Click()
		
	End Sub
	
	Private Sub Image1_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single)
		
	End Sub
	
	
	Private Sub imgbackground_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles imgbackground.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Uvodnik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		PCGamez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Soft.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Reda.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CD.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ankh.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inet.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Moviez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Learn.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Mjuzik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ruzne.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Letterz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Future.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Bux.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	
	Private Sub Inet_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Inet.Click
		PlaySound(11)
		If GetSetting("Harley Software", "Jooky-Viewer", "EditMode") = "1" Then
			WriteIniFile("ini\main.ini", "Common", "WWW", UCase(InputBox("Zadej adresu k Internetovému Serveru." & Chr(10) & "(napø. http://www.mujweb.cz/www/engine", "Editace URL Adresy)")))
		Else
			WWWconnect()
		End If
	End Sub
	
	Private Sub Inet_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Inet.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		Uvodnik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		PCGamez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Soft.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Reda.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CD.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ankh.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inet.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		Moviez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Learn.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Mjuzik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ruzne.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Letterz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Future.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Bux.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property List.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        'Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property List.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub Inz_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Inz.Click
		PlaySound(11)
		SaveSetting("Harley Software", "Jooky-Viewer", "Window", "Inzerce")
		TextFRM.Pix.Enabled = True
		TextFRM.CaP.Text = "Inzerce"
		Me.Close()
		TextFRM.Show() 'vbmodal
	End Sub
	
	Private Sub Label1_Click()
		
	End Sub
	
	Private Sub Inz_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Inz.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		Uvodnik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		PCGamez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Soft.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Reda.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CD.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ankh.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inet.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Moviez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Learn.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Mjuzik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		Ruzne.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Letterz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Future.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Bux.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property List.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        'Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property List.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	Private Sub Learn_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Learn.Click
		PlaySound(11)
		SaveSetting("Harley Software", "Jooky-Viewer", "Window", "Vyuka")
		TextFRM.Pix.Enabled = True
		TextFRM.CaP.Text = "Výuka"
		Me.Close()
		TextFRM.Show() 'vbmodal
	End Sub
	
	Private Sub Learn_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Learn.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		Uvodnik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		PCGamez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Soft.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Reda.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CD.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ankh.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inet.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Moviez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Learn.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		Mjuzik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ruzne.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Letterz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Future.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Bux.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property List.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        'Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property List.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub Letterz_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Letterz.Click
		PlaySound(11)
		SaveSetting("Harley Software", "Jooky-Viewer", "Window", "Dopisy")
		TextFRM.Pix.Enabled = True
		TextFRM.CaP.Text = "Dopisy"
		Me.Close()
		TextFRM.Show() 'vbmodal
	End Sub
	
	Private Sub Letterz_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Letterz.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		Uvodnik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		PCGamez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Soft.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Reda.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CD.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ankh.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inet.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Moviez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Learn.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Mjuzik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ruzne.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Letterz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		Future.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Bux.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property List.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        'Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property List.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub Mjuzik_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Mjuzik.Click
		PlaySound(11)
		SaveSetting("Harley Software", "Jooky-Viewer", "Window", "Muzika")
		TextFRM.Pix.Enabled = True
		TextFRM.CaP.Text = "Muzika"
		Me.Close()
		TextFRM.Show() 'vbmodal
	End Sub
	
	Private Sub Msg_Click()
		PlaySound(11)
		SaveSetting("Harley Software", "Jooky-Viewer", "Window", "0")
		TextFRM.List1.Items.Clear()
		TextFRM.Pix.Enabled = True
		TextFRM.RichTextBox1.LoadFile("data\text\messages.rtf")
		TextFRM.Text = "Vzkazy"
		Me.Close()
		TextFRM.Show()
	End Sub
	
	Private Sub NFO_Click()
		PlaySound(11)
		SaveSetting("Harley Software", "Jooky-Viewer", "Window", "Informace")
		TextFRM.Pix.Enabled = True
		TextFRM.Text = "Informace"
		Me.Close()
		TextFRM.Show()
	End Sub
	
	Private Sub Mjuzik_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Mjuzik.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		Uvodnik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		PCGamez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Soft.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Reda.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CD.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ankh.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inet.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Moviez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Learn.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Mjuzik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		Inz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ruzne.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Letterz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Future.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Bux.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property List.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        'Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property List.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	Private Sub Moviez_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Moviez.Click
		PlaySound(11)
		SaveSetting("Harley Software", "Jooky-Viewer", "Window", "Filmy")
		TextFRM.Pix.Enabled = True
		TextFRM.CaP.Text = "Filmy"
		Me.Close()
		TextFRM.Show() 'vbmodal
		
	End Sub
	
	Private Sub Music_Click()
		
	End Sub
	
	Private Sub Moviez_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Moviez.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		Uvodnik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		PCGamez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Soft.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Reda.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CD.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ankh.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inet.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Moviez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		Learn.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Mjuzik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ruzne.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Letterz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Future.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Bux.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property List.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        'Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property List.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	Private Sub PCGamez_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PCGamez.Click
		PlaySound(11)
		
		PCGames.Show() 'vbmodal
	End Sub
	
	
	Private Sub PCGamez_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles PCGamez.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		Uvodnik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Soft.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Reda.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CD.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ankh.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inet.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		PCGamez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		Moviez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Learn.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Mjuzik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ruzne.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Letterz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Future.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Bux.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property List.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        'Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property List.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub Reda_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Reda.Click
		PlaySound(11)
		SaveSetting("Harley Software", "Jooky-Viewer", "Window", "Redakce")
		TextFRM.Pix.Enabled = True
		TextFRM.CaP.Text = "Redakce"
		Me.Close()
		TextFRM.Show() 'vbmodal
	End Sub
	
	Private Sub Reklama_Click()
		
		MsgBox("Reklama se pøesunula, je tam, kde jí mají i jiné DiskMagy (zobrazuje se pøed ukonèením).",  , "Reklama")
	End Sub
	
	
	Private Sub Reda_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Reda.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		Uvodnik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		PCGamez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Soft.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Reda.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		CD.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ankh.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inet.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Moviez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Learn.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Mjuzik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ruzne.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Letterz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Future.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Bux.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property List.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        'Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property List.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	Private Sub Ruzne_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Ruzne.Click
		PlaySound(11)
		SaveSetting("Harley Software", "Jooky-Viewer", "Window", "Ruzne")
		TextFRM.Pix.Enabled = True
		TextFRM.CaP.Text = "Rùzné"
		Me.Close()
		TextFRM.Show() 'vbmodal
		
	End Sub
	
	Private Sub Ruzne_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Ruzne.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		Uvodnik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		PCGamez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Soft.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Reda.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CD.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ankh.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inet.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Moviez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Learn.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Mjuzik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ruzne.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		Letterz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Future.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Bux.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property List.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        'Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property List.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub Soft_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Soft.Click
		PlaySound(11)
		SaveSetting("Harley Software", "Jooky-Viewer", "Window", "Software")
		TextFRM.Pix.Enabled = True
		TextFRM.CaP.Text = "Software"
		Me.Close()
		TextFRM.Show() 'vbmodal
	End Sub
	
	Private Sub Soft_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Soft.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		Uvodnik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		PCGamez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Soft.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		Reda.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CD.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ankh.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inet.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Moviez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Learn.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Mjuzik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ruzne.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Letterz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Future.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Bux.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property List.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        'Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property List.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	
	
	
	Private Sub Uvodnik_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Uvodnik.Click
		PlaySound(11)
		SaveSetting("Harley Software", "Jooky-Viewer", "Window", "Uvodnik")
		TextFRM.Pix.Enabled = True
		TextFRM.CaP.Text = "Úvodník"
		Me.Close()
		TextFRM.Show() 'vbmodal
	End Sub
	
	
	Private Sub Uvodnik_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Uvodnik.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		'UPGRADE_ISSUE: Form property List.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        'Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property List.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		Uvodnik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		PCGamez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Soft.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Reda.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CD.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ankh.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inet.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Moviez.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Learn.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Mjuzik.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Inz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Ruzne.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Letterz.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Future.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Bux.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
	End Sub
End Class