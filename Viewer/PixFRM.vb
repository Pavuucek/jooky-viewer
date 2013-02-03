Option Strict Off
Option Explicit On
Friend Class PixFRM
	Inherits System.Windows.Forms.Form
	Private Sub Back3_Click()
	End Sub
	
	
	Private Sub back_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles back.Click
		PlaySound(11)
		Me.Close()
		TextFRM.Enabled = True
		TextFRM.Show()
	End Sub
	
	
	Private Sub Back_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Back.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		PrN.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		'UPGRADE_ISSUE: Form property PixFRM.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property PixFRM.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub File1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles File1.SelectedIndexChanged
		On Error GoTo 1
		Dim clx As Object
		Dim em As String
		PlaySound(11)
		WaitFRM.Show()
		System.Windows.Forms.Application.DoEvents()
		ConsoleWrite("PIXVIEWER.file=" & File1.FileName)
		Err.Clear()
		Image1.Image = System.Drawing.Image.FromFile(File1.Path & "\" & File1.FileName)
		'UPGRADE_WARNING: Couldn't resolve default property of object clx. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		clx = GetSetting("Harley Software", "Jooky-Viewer", "Clanek")
		em = GetSetting("Harley Software", "Jooky-Viewer", "EditMode")
		'UPGRADE_WARNING: Couldn't resolve default property of object clx. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If em = "1" And ReadIniFile("ini\main.ini", clx, File1.FileName) = "" Then
			PopiseK.Text = "Klepnìte sem pro zadání popisku k obrázku"
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object clx. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			PopiseK.Text = ReadIniFile("ini\main.ini", clx, File1.FileName)
		End If
		GoTo 2
1: 
		If Err.Number Then DetError(Err.Number, "pixviewer")
		GoTo 2
2: 
		WaitFRM.Close()
	End Sub
	
	
	Private Sub PrintBTN_Click()
		PlaySound(11)
		'UPGRADE_ISSUE: Printer object was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer method Printer.Print was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Print(CStr(CObj(Me.BackgroundImage)))
	End Sub
	
	
	Private Sub File1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles File1.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		'UPGRADE_ISSUE: Form property PixFRM.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property PixFRM.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	'UPGRADE_WARNING: Form event PixFRM.Activate has a new behavior. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub PixFRM_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		Dim res As String
		Image1.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Back.Top) + 2)
		Image1.Left = 0
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 9600 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 7200 Then res = "640x480"
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 12000 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 9000 Then res = "800x600"
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) >= 15360 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) >= 11520 Then res = "1024x768"
		'UPGRADE_ISSUE: Constant vbPixels was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_ISSUE: Form property PixFRM.ScaleMode is not supported. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="8027179A-CB3B-45C0-9863-FAA1AF983B59"'
		Me.ScaleMode = vbPixels
		Select Case res
			Case "640x480"
				Image1.Width = VB6.TwipsToPixelsX(640)
				Image1.Height = VB6.TwipsToPixelsY(480 - VB6.PixelsToTwipsY(Back.Top) + 2)
			Case "800x600"
				Image1.Width = VB6.TwipsToPixelsX(800)
				Image1.Height = VB6.TwipsToPixelsY(600 - VB6.PixelsToTwipsY(Back.Top) + 2)
			Case "1024x768"
				Image1.Width = VB6.TwipsToPixelsX(1024)
				Image1.Height = VB6.TwipsToPixelsY(768 - VB6.PixelsToTwipsY(Back.Top) + 2)
		End Select
		PrN.Enabled = False
		PrN.Visible = False
		PopiseK.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Image1.Width) - VB6.PixelsToTwipsX(PopiseK.Left) - 10)
	End Sub
	
	Private Sub PixFRM_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim res As String
		On Error GoTo 1
		Me.Icon = Main_Renamed.Icon
		ConsoleWrite("PIXVIEWER.init")
		File1.Pattern = "*.BMP;*.JPG;*.GIF"
		Image1.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Back.Top) + 2)
		Image1.Left = 0
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 9600 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 7200 Then res = "640x480"
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 12000 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 9000 Then res = "800x600"
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) >= 15360 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) >= 11520 Then res = "1024x768"
		'UPGRADE_ISSUE: Constant vbPixels was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_ISSUE: Form property PixFRM.ScaleMode is not supported. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="8027179A-CB3B-45C0-9863-FAA1AF983B59"'
		Me.ScaleMode = vbPixels
		Select Case res
			Case "640x480"
				Image1.Width = VB6.TwipsToPixelsX(640)
				Image1.Height = VB6.TwipsToPixelsY(480 - VB6.PixelsToTwipsY(Back.Top) + 2)
			Case "800x600"
				Image1.Width = VB6.TwipsToPixelsX(800)
				Image1.Height = VB6.TwipsToPixelsY(600 - VB6.PixelsToTwipsY(Back.Top) + 2)
			Case "1024x768"
				Image1.Width = VB6.TwipsToPixelsX(1024)
				Image1.Height = VB6.TwipsToPixelsY(768 - VB6.PixelsToTwipsY(Back.Top) + 2)
		End Select
		PopiseK.Text = ""
		PopiseK.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Image1.Width) - VB6.PixelsToTwipsX(PopiseK.Left) - 10)
		PrN.Enabled = False
		PrN.Visible = False
		GoTo 2
1: 
		DetError(Err.Number, "pixviewer")
		GoTo 2
2: 
	End Sub
	
	
	Private Sub PixFRM_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		PrN.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	
	Private Sub PixFRM_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		ConsoleWrite("PIXVIEWER.uninit")
	End Sub
	
	
	Private Sub Image1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Image1.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		PrN.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub PoPiSeK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PoPiSeK.Click
		Dim clx, em As Object
		Dim ib As String
		'UPGRADE_WARNING: Couldn't resolve default property of object clx. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		clx = GetSetting("Harley Software", "Jooky-Viewer", "Clanek")
		'UPGRADE_WARNING: Couldn't resolve default property of object em. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		em = GetSetting("Harley Software", "Jooky-Viewer", "EditMode")
		'UPGRADE_WARNING: Couldn't resolve default property of object em. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If em = "1" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object clx. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ib = InputBox("Zadej popisek k obrázku...", clx)
			PopiseK.Text = ib
			'UPGRADE_WARNING: Couldn't resolve default property of object clx. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WriteIniFile("ini\main.ini", clx, File1.FileName, ib)
		End If
	End Sub
	
	Private Sub PoPiSeK_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles PoPiSeK.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	
	Private Sub PrN_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PrN.Click
		PlaySound(11)
		'UPGRADE_WARNING: Couldn't resolve default property of object Me.Picture.filename. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ConsoleWrite("DEVICEUSE.printer=" & Me.BackgroundImage.filename)
		File1.Visible = False
		PrN.Visible = False
		Back.Visible = False
		'UPGRADE_ISSUE: Form method PixFRM.PrintForm was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		PrintForm()
		'UPGRADE_ISSUE: Printer method Printer.EndDoc was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.EndDoc()
		File1.Visible = True
		PrN.Visible = True
		Back.Visible = True
	End Sub
	
	
	Private Sub Rec_Click()
		
	End Sub
	
	
	Private Sub PrN_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles PrN.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		PrN.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		Back.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
	End Sub
End Class