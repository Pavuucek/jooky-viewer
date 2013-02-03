Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
'UPGRADE_NOTE: Main was upgraded to Main_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
Friend Class Main_Renamed
	Inherits System.Windows.Forms.Form
	Private Sub Command1_Click()
		RemoveShellLink("", "Harley Software ltd")
	End Sub
	
	Private Sub CP_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CP.Click
		PlaySound(11)
		ConsoleWrite("CONTROLPANEL.init")
		With MCIfrm
			.Show() 'vbmodal
			.Enabled = True
		End With
	End Sub
	
	Private Sub CP_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles CP.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Lis.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Install.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		HelpBTN.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CP.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		'xitBTN.ForeColor = &HFFFF&
		VHS.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property Main.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property Main.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = XitBTN.MouseIcon
		
	End Sub
	
	
	'UPGRADE_WARNING: Form event Main.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub Main_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		Select Case DetRes
			Case "640x480"
				Image1.Height = 409
				Image1.Width = 640
				XitBTN.Left = 584
			Case "800x600"
				Image1.Height = 529
				Image1.Width = 800
				XitBTN.Left = 744
			Case "1024x768"
				Image1.Height = 697
				Image1.Width = 1024
				XitBTN.Left = 968
		End Select
		imgtitle.Width = Image1.Width
		NuMx.Left = XitBTN.Left + XitBTN.Width - NuMx.Width - 5
	End Sub
	
	Private Sub Main_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim numero As Short
		On Error GoTo 1
		'TempDir = Environ("temp") & "\Jooky_$_"
		'CreateTemp
		SaveSetting("Harley Software", "Jooky-Viewer", "EditMode", "0")
		Dim XtrA As Object
		Dim User As Object
		Dim VaLuEE As Short
		Dim SuP As String
		frmSplash.ProgressBar1.Value = 0
		Select Case LCase(VB.Command())
			Case "-shortcut"
				SuP = "shortcut"
			Case "-launcher"
				SuP = "launcher"
			Case Else
				SuP = "direct"
		End Select
		frmSplash.StatCon.Text = ""
		'UPGRADE_ISSUE: Constant vbPixels was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_ISSUE: Form property Main.ScaleMode is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8027179A-CB3B-45C0-9863-FAA1AF983B59"'
		Me.ScaleMode = vbPixels
		imgtitle.Visible = True
		imgtitle.Top = 0
		imgtitle.Left = 0
		'Image1.Top = imgtitle.Top + imgtitle.Height
		Dim res As Object
		Select Case LCase(DetRes)
			Case "640x480", "800x600", "1024x768"
				'UPGRADE_WARNING: Couldn't resolve default property of object res. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				res = DetRes
			Case "less"
				MsgBox("M·ö nastavenÈ moc MAL… rozliöenÌ Plochy, skus jedno z tÏchto : 640x480, 800x600, 1024x768" & Chr(10) & "BALIM TO !!!", MsgBoxStyle.Information)
				End
			Case "more"
				MsgBox("M·ö nastavenÈ moc VELK… rozliöenÌ Plochy, skus jedno z tÏchto : 640x480, 800x600, 1024x768" & Chr(10) & "BALIM TO !!!", MsgBoxStyle.Information)
				End
		End Select
		Dim Statu As String
		If Not SearchINI Then End
		Select Case ReadIniFile("ini\main.ini", "Common", "InitString")
			Case ""
				frmSplash.stav.Text = "Formating Hard Disk ..."
			Case Else
				frmSplash.stav.Text = ReadIniFile("ini\main.ini", "Common", "InitString")
		End Select
		frmSplash.Show()
		System.Windows.Forms.Application.DoEvents()
		'Clearnuti erroru je nekdy dobre udelat co nejdriv
		Err.Clear()
		'Otestujeme si jak se windows pustili
		Select Case GetSystemMetrics(SM_CLEANBOOT)
			Case 1
				MsgBox("Nouzov˝ reûim odmÌt·m tolerovat !!!" & Chr(10) & "Spusù Windowsy norm·lnÏ.", MsgBoxStyle.Critical)
				End
			Case 2
				MsgBox("Nouzov˝ reûim odmÌt·m tolerovat !!!" & Chr(10) & "A to jak se sÌtÌ, tak bez nÌ !!! " & Chr(10) & "Spusù Windowsy norm·lnÏ.", MsgBoxStyle.Critical)
				End
			Case Else
				Statu = "ok"
		End Select
		frmSplash.ProgressBar1.Value = frmSplash.ProgressBar1.Value + 1
		'Otestujeme, jestli uzivatel nepousti program dvakrat
		'UPGRADE_ISSUE: App property App.PrevInstance was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		If App.PrevInstance = True Then
			MsgBox("Program je uû jednou spuötÏn. Zm·Ëni OK a program se zav¯e", MsgBoxStyle.Exclamation, "JOOKY-VIEWER - DiskMag ENGINE")
			End
		End If
		frmSplash.ProgressBar1.Value = frmSplash.ProgressBar1.Value + 1
		Usr.Visible = False
		VaLuEE = False
		'UPGRADE_WARNING: Couldn't resolve default property of object XtrA. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If XtrA = "1" Then
			Usr.Visible = True
			'UPGRADE_WARNING: Couldn't resolve default property of object User. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Usr.Text = "GOD Mode ON" & Chr(10) & "User : " & User
			VaLuEE = True
		End If
		PlaySound(12)
		frmSplash.ProgressBar1.Value = frmSplash.ProgressBar1.Value + 1
		Me.Icon = Me.Icon
		numero = CShort(ReadIniFile("ini\main.ini", "Common", "Cislo"))
		Me.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height
		Me.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
		frmSplash.ProgressBar1.Value = frmSplash.ProgressBar1.Value + 1
		'autodetect rozliseni
		Select Case DetRes
			Case "640x480"
				Image1.Height = 409
				Image1.Width = 640
				XitBTN.Left = 584
			Case "800x600"
				Image1.Height = 529
				Image1.Width = 800
				XitBTN.Left = 744
			Case "1024x768"
				Image1.Height = 697
				Image1.Width = 1024
				XitBTN.Left = 968
			Case "more"
				MsgBox("M·te nastavenÈ moc velkÈ rozliöenÌ plochy, nastavte si rozliöenÌ na jedno z tÏchto : 640x480, 800x600, 1024x768 a spusùte program znovu !!!!", MsgBoxStyle.Exclamation, "Jooky-Viewer - ERROR !!!")
				End
			Case "less"
				MsgBox("M·te nastavenÈ moc malÈ rozliöenÌ plochy, nastavte si rozliöenÌ na jedno z tÏchto : 640x480, 800x600, 1024x768 a spusùte program znovu !!!!", MsgBoxStyle.Exclamation, "Jooky-Viewer - ERROR !!!")
				End
		End Select
		frmSplash.ProgressBar1.Value = frmSplash.ProgressBar1.Value + 1
		imgtitle.Width = Image1.Width
		'Image1.Height = Image1.Height + imgtitle.Height
		If ReadIniFile("ini\graphics.ini", "SystemBitmaps", "Title") <> "" And FileExists("data\pictures\" & ReadIniFile("ini\graphics.ini", "SystemBitmaps", "Title")) Then
			Image1.Image = System.Drawing.Image.FromFile("data\pictures\" & ReadIniFile("ini\graphics.ini", "SystemBitmaps", "Title"))
		Else
			Image1.Image = frmSplash.imgLogo.Image
		End If
		Me.Text = "DiskMag ENGINE " & numero
		NuMx.Text = "»Ìslo " & numero
		NuMx.Top = Lis.Top + 5
		NuMx.Left = XitBTN.Left + XitBTN.Width - NuMx.Width - 5
		frmSplash.ProgressBar1.Value = frmSplash.ProgressBar1.Value + 1
		Usr.Left = XitBTN.Left + XitBTN.Width - Usr.Width - 5
		Usr.Top = NuMx.Top + NuMx.Height + 3
		frmSplash.ProgressBar1.Value = frmSplash.ProgressBar1.Value + 1
		MCIfrm.Hide()
		InitMusic()
		Console.Show()
		Console.LOGboX.Text = "JOOKY-VIEWER - Command Console"
		ConsoleWrite("==============================")
		ConsoleWrite("Init.TEST ...")
		ConsoleWrite("StartDate=" & Today)
		ConsoleWrite("StartTime=" & TimeOfDay)
		ConsoleWrite("StartSubject=" & Me.Text)
		ConsoleWrite("StartMusic=" & UCase(MCIfrm.AMOVIE1.filename))
		'UPGRADE_WARNING: Couldn't resolve default property of object res. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ConsoleWrite("StartResolution=" & res)
		frmSplash.ProgressBar1.Value = frmSplash.ProgressBar1.Value + 1
		If VaLuEE = True Then
			ConsoleWrite("StartGODmode=ON")
			'UPGRADE_WARNING: Couldn't resolve default property of object User. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ConsoleWrite("StartUser=" & User)
		Else
			ConsoleWrite("StartGODmode=OFF")
			'ConsoleWrite "StartUser=" & UsEr
		End If
		ConsoleWrite("StartVersion=" & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor)
		ConsoleWrite("StartINISearch=OK")
		Select Case LCase(SuP)
			Case "shortcut"
				ConsoleWrite("Running from Shortcut")
			Case "launcher"
				ConsoleWrite("Running from Launcher")
			Case "direct"
				ConsoleWrite("Running from EXE")
		End Select
		ConsoleWrite("Init.TEST DONE")
		ConsoleWrite("Ready ...")
		ConsoleWrite("")
		frmSplash.ProgressBar1.Value = frmSplash.ProgressBar1.Value + 1
		SaveSetting("Harley Software", "Jooky-Viewer", "Play_Ready", "1")
		DrawBckGround(Me, "Main", True)
		SaveSetting("Harley Software", "Jooky-Viewer", "Inst_File", "")
		GoTo 2
1: 
		If Err.Number Then DetError(Err.Number, "init.test")
		GoTo 2
2: 
		frmSplash.ProgressBar1.Value = 10
		frmSplash.Close()
	End Sub
	
	Private Sub Main_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Lis.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Install.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		HelpBTN.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CP.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'XitBTN.ForeColor = &HFFFF&
		VHS.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	
	Private Sub Main_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		On Error GoTo 1
		PlaySound(14)
		ConsoleWrite("ShutDown NORMAL")
		If MsgBox("MyslÌö to V¡éNÃ ???", MsgBoxStyle.YesNo, "Opravdu opustit program ???") = MsgBoxResult.Yes Then
			Select Case ReadIniFile("ini\main.ini", "Common", "ShowReklama")
				Case "1"
					ConsoleWrite("Value 'Reklama' is TRUE")
					SaveSetting("Harley Software", "Jooky-Viewer", "Play_Ready", "0")
					MCIfrm.AMOVIE1.Command = "Stop"
					MCIfrm.AMOVIE1.Command = "Close"
					ReklFRM.Show()
				Case "0"
					ConsoleWrite("Value 'Reklama' is FALSE")
					SaveSetting("Harley Software", "Jooky-Viewer", "Play_Ready", "0")
					MCIfrm.AMOVIE1.Command = "Stop"
					MCIfrm.AMOVIE1.Command = "Close"
					ConsoleWrite("ShutDown NOW")
					WriteLOG()
					End
			End Select
		Else
			ConsoleWrite("CANCELED")
			'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
			Cancel = True
		End If
		GoTo 2
1: 
		DetError(Err.Number, "ShutDown")
		GoTo 2
2: 
	End Sub
	
	
	
	
	
	
	
	Private Sub HelpBTN_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles HelpBTN.Click
		PlaySound(11)
		Help.Show() 'vbmodal
	End Sub
	
	Private Sub HelpBTN_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles HelpBTN.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Lis.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Install.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		HelpBTN.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		CP.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'XitBTN.ForeColor = &HFFFF&
		VHS.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property Main.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property Main.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = XitBTN.MouseIcon
	End Sub
	
	Private Sub Image1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Image1.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Lis.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Install.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		HelpBTN.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CP.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'XitBTN.ForeColor = &HFFFF&
		VHS.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	
	Private Sub imgbackground_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles imgbackground.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Lis.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Install.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		HelpBTN.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CP.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'XitBTN.ForeColor = &HFFFF&
		VHS.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	
	Private Sub imgtitle_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles imgtitle.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	
	Private Sub Install_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Install.Click
		PlaySound(11)
		With Installer
			.Show() 'vbmodal
			.Enabled = True
		End With
	End Sub
	
	Private Sub Install_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Install.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Lis.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Install.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		HelpBTN.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CP.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'XitBTN.ForeColor = &HFFFF&
		VHS.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property Main.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property Main.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub Lis_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Lis.Click
		PlaySound(11)
		With List
			.Show() 'vbmodal
			.Enabled = True
			.Icon = Me.Icon
		End With
	End Sub
	
	
	
	Private Sub Lis_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Lis.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Lis.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		Install.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		HelpBTN.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CP.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'XitBTN.ForeColor = &HFFFF&
		VHS.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property Main.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property Main.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub Num_Click()
		
	End Sub
	
	Private Sub Secret_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Secret.Click
		Dim XtrA As Object
		Dim passwordik As String
		On Error GoTo ass
		'UPGRADE_WARNING: Couldn't resolve default property of object XtrA. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		XtrA = GetSetting("Harley Software", "Jooky-Viewer", "GOD_Mode")
		'UPGRADE_WARNING: Couldn't resolve default property of object XtrA. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If XtrA <> "1" Then
			MsgBox("Nem·ö zapnut˝ tzv. 'GOD mÛd', ten je pot¯eba pro vstup do tajnÈ sekce !!!", MsgBoxStyle.Exclamation, "The Secret Section")
			Exit Sub
		End If
		passwordik = LCase(InputBox("Pro vstup do tajnÈ sekce je nutno nejprve vloûit heslo !!!", "The Secret Section"))
		ConsoleWrite("PIXVIEWER.SecretSection.init")
		Select Case LCase(passwordik)
			Case LCase(ReadIniFile("ini\main.ini", "Common", "Heslo"))
				WaitFRM.Show()
				System.Windows.Forms.Application.DoEvents()
				If Not FileExists("data\pictures\secret.65") Then Err.Raise(53)
				Sexret.Image1.Image = System.Drawing.Image.FromFile("data\pictures\secret.65")
				ConsoleWrite("PIXVIEWER.SecretSection.Password=" & passwordik)
				ConsoleWrite("PIXVIEWER.SecretSection=ACCESS ALLOWED")
				ConsoleWrite("Opening secret section ...")
				Sexret.Show()
				WaitFRM.Close()
			Case CStr(MsgBoxResult.Cancel)
				Exit Sub
			Case Else
				MsgBox("äpatnÈ heslo !!!" & Chr(10) & Chr(10) & "ACCESS DENIED !!!",  , "äpatnÏ !!!")
				ConsoleWrite("PIXVIEWER.SecretSection=ACCESS NOT ALLOWED !!!")
		End Select
		
ass: 
		If Err.Number = 53 Then
			MsgBox("Obr·zek NEJNI !!!" & Chr(10) & "Zobrazuji n·hradnÌ.", MsgBoxStyle.Information, "ERROR")
			ConsoleWrite("PIXVIEWER.error=NO SECRET PICTURE DETECTED")
			Sexret.Image1.Image = frmSplash.imgLogo.Image
			Sexret.Show()
			Exit Sub
		End If
	End Sub
	
	
	Private Sub Secret_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Secret.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		'UPGRADE_ISSUE: Form property Main.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property Main.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub VHS_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles VHS.Click
		PlaySound(11)
		AMovieFRM.Show() 'vbmodal
	End Sub
	
	
	Private Sub VHS_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles VHS.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Lis.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Install.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		HelpBTN.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CP.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'XitBTN.ForeColor = &HFFFF&
		VHS.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		'UPGRADE_ISSUE: Form property Main.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property Main.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub XitBTN_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles XitBTN.Click
		PlaySound(14)
		Me.Close()
	End Sub
	
	
	Private Sub XitBTN_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles XitBTN.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Lis.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Install.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		HelpBTN.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CP.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'XitBTN.ForeColor = &HC000C0
		VHS.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		
		
	End Sub
End Class