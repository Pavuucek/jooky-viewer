Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Module Main_Engine
	
	Public i As Short
	Public WindoW As Short
	Public ble As Short
	Public PoPiSeK As String
	Public MaSkA As String
	Public Fil As String
	Public prgz As String
	Public pthz As String
	Public RexX As String
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
	Declare Function sndPlaySound Lib "winmm.dll"  Alias "sndPlaySoundA"(ByVal lpszSoundName As Any, ByVal uFlags As Integer) As Integer
	Public Const SND_ASYNC As Integer = &H1 ' Play asynchronously
	Public Const SND_NODEFAULT As Integer = &H2 ' Don't use default sound
	Public Const SND_MEMORY As Integer = &H4 ' lpszSoundName points to a memory file
	Public Const gstrSEP_DIR As String = "\" ' Directory separator character
	
	Public SoundBuffer As String
	
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
	Declare Function GetPrivateProfileString Lib "kernel32"  Alias "GetPrivateProfileStringA"(ByVal lpApplicationName As String, ByVal lpKeyName As Any, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
	'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
	Declare Function WritePrivateProfileString Lib "kernel32"  Alias "WritePrivateProfileStringA"(ByVal lpApplicationName As String, ByVal lpKeyName As Any, ByVal lpString As Any, ByVal lpFileName As String) As Integer
	
	Declare Function ShellExecute Lib "shell32.dll"  Alias "ShellExecuteA"(ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
	Public Const gintMAX_SIZE As Short = 255
	Public Const gstrNULL As String = ""
	Public Declare Function GetSystemMetrics Lib "user32" (ByVal nIndex As Integer) As Integer
	Public Const SM_CLEANBOOT As Short = 67
	
	
	
	Function DetRes() As String
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) < 9600 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) < 7200 Then DetRes = "less"
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 9600 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 7200 Then DetRes = "640x480"
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 12000 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 9000 Then DetRes = "800x600"
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 15360 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 11520 Then DetRes = "1024x768"
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) > 15360 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) > 11520 Then DetRes = "more"
	End Function
	
	
	Sub DrawBckGround(ByVal frm As System.Windows.Forms.Form, ByVal NaM As String, Optional ByVal Mx As Object = Nothing)
		On Error GoTo 1
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Mx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If IsNothing(Mx) Then Mx = False
		Dim sCm As Object
		'UPGRADE_ISSUE: Form property frm.ScaleMode is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8027179A-CB3B-45C0-9863-FAA1AF983B59"'
		'UPGRADE_WARNING: Couldn't resolve default property of object sCm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sCm = frm.ScaleMode
		'UPGRADE_ISSUE: Constant vbTwips was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_ISSUE: Form property frm.ScaleMode is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8027179A-CB3B-45C0-9863-FAA1AF983B59"'
		frm.ScaleMode = vbTwips
		'UPGRADE_ISSUE: Control imgbackground could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
		With frm.imgbackground
			'UPGRADE_ISSUE: Control imgbackground could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
			.Stretch = True
			'UPGRADE_ISSUE: Control imgbackground could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
			.Left = 0
			'UPGRADE_ISSUE: Control imgbackground could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
			.Top = 0
		End With
		'UPGRADE_ISSUE: Constant vbPixels was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_ISSUE: Form property frm.ScaleMode is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8027179A-CB3B-45C0-9863-FAA1AF983B59"'
		frm.ScaleMode = vbPixels
		'UPGRADE_WARNING: Couldn't resolve default property of object Mx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Mx = True Then
			Select Case DetRes
				Case "640x480"
					'UPGRADE_ISSUE: Constant vbPixels was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
					'UPGRADE_ISSUE: Form property frm.ScaleMode is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8027179A-CB3B-45C0-9863-FAA1AF983B59"'
					frm.ScaleMode = vbPixels
					'UPGRADE_ISSUE: Control imgbackground could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					frm.imgbackground.Height = 480
					'UPGRADE_ISSUE: Control imgbackground could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					frm.imgbackground.Width = 640
				Case "800x600"
					'UPGRADE_ISSUE: Constant vbPixels was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
					'UPGRADE_ISSUE: Form property frm.ScaleMode is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8027179A-CB3B-45C0-9863-FAA1AF983B59"'
					frm.ScaleMode = vbPixels
					'UPGRADE_ISSUE: Control imgbackground could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					frm.imgbackground.Height = 600
					'UPGRADE_ISSUE: Control imgbackground could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					frm.imgbackground.Width = 800
				Case "1024x768"
					'UPGRADE_ISSUE: Constant vbPixels was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
					'UPGRADE_ISSUE: Form property frm.ScaleMode is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8027179A-CB3B-45C0-9863-FAA1AF983B59"'
					frm.ScaleMode = vbPixels
					'UPGRADE_ISSUE: Control imgbackground could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					frm.imgbackground.Height = 768
					'UPGRADE_ISSUE: Control imgbackground could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					frm.imgbackground.Width = 1024
			End Select
		Else
			'UPGRADE_ISSUE: Constant vbTwips was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
			'UPGRADE_ISSUE: Form property frm.ScaleMode is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8027179A-CB3B-45C0-9863-FAA1AF983B59"'
			frm.ScaleMode = vbTwips
			'UPGRADE_ISSUE: Control imgbackground could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
			frm.imgbackground.Height = VB6.PixelsToTwipsY(frm.Height)
			'UPGRADE_ISSUE: Control imgbackground could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
			frm.imgbackground.Width = VB6.PixelsToTwipsX(frm.Width)
		End If
		'UPGRADE_ISSUE: Constant vbTwips was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_ISSUE: Form property frm.ScaleMode is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8027179A-CB3B-45C0-9863-FAA1AF983B59"'
		frm.ScaleMode = vbTwips
		If ReadIniFile("ini\graphics.ini", "BackGrounds", NaM) <> "" And FileExists("data\pictures\" & ReadIniFile("ini\graphics.ini", "BackGrounds", NaM)) Then
			'UPGRADE_ISSUE: Control imgbackground could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
			frm.imgbackground.Picture = System.Drawing.Image.FromFile("data\pictures\" & ReadIniFile("ini\graphics.ini", "BackGrounds", NaM))
		Else
			'UPGRADE_ISSUE: Control imgbackground could not be resolved because it was within the generic namespace Form. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
			frm.imgbackground.Picture = Console.imbPozadi.Image
		End If
		'UPGRADE_ISSUE: Form property frm.ScaleMode is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8027179A-CB3B-45C0-9863-FAA1AF983B59"'
		'UPGRADE_WARNING: Couldn't resolve default property of object sCm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		frm.ScaleMode = sCm
		GoTo 2
1: 
		DetError(Err.Number, "ChangeBackGround")
		GoTo 2
2: 
	End Sub
	
	Function SearchINI() As Boolean
		Dim oK As Short
		oK = 0
		If FileExists("ini\main.ini") Then oK = oK + 1
		If FileExists("ini\graphics.ini") Then oK = oK + 1
		If FileExists("ini\sounds.ini") Then oK = oK + 1
		If FileExists("ini\music.ini") Then oK = oK + 1
		
		If oK < 4 Then
			MsgBox("Nenalezl jsem nìkterý z dùležitých .INI souborù " & Chr(10) & "BALIM TO !!!!!", MsgBoxStyle.Critical, "Jooky-Viewer -  FATAL ERROR !!!!")
			SearchINI = False
		Else
			SearchINI = True
		End If
	End Function
	
	Sub InitMusic()
		On Error GoTo 1
		Dim Counter As String
		Dim Nahoda As String
		'MCIfrm.Hide
		MCIfrm.AMOVIE1.Command = "Stop"
		MCIfrm.AMOVIE1.Command = "Close"
		Select Case LCase(ReadIniFile("ini\music.ini", "Common", "Music"))
			Case "random"
				Randomize()
				Nahoda = CStr(Int((Rnd() * CDbl(ReadIniFile("ini\music.ini", "Common", "Last_Music"))) + 1))
				If Not FileExists("data\music\" & ReadIniFile("ini\music.ini", "Files", "Music" & Nahoda)) Then Err.Raise(53)
				MCIfrm.AMOVIE1.filename = "data\music\" & ReadIniFile("ini\music.ini", "Files", "Music" & Nahoda)
			Case Else
				MCIfrm.AMOVIE1.filename = "data\music\" & ReadIniFile("ini\music.ini", "Common", "Music")
		End Select
		Select Case LCase(Right(MCIfrm.AMOVIE1.filename, 3))
			Case "mid"
				MCIfrm.AMOVIE1.DeviceType = "Sequencer"
			Case "wav"
				MCIfrm.AMOVIE1.DeviceType = "WaveAudio"
			Case Else
		End Select
		MCIfrm.AMOVIE1.Command = "Open"
		MCIfrm.AMOVIE1.Command = "Play"
		GoTo 2
1: 
		DetError(Err.Number, "initmusic")
		GoTo 2
2: 
	End Sub
	
	
	'-----------------------------------------------------------
	' FUNCTION: StripTerminator
	'
	' Returns a string without any zero terminator.  Typically,
	' this was a string returned by a Windows API call.
	'
	' IN: [strString] - String to remove terminator from
	'
	' Returns: The value of the string passed in minus any
	'          terminating zero.
	'-----------------------------------------------------------
	'
	Function StripTerminator(ByVal strString As String) As String
		Dim intZeroPos As Short
		
		intZeroPos = InStr(strString, Chr(0))
		If intZeroPos > 0 Then
			StripTerminator = Left(strString, intZeroPos - 1)
		Else
			StripTerminator = strString
		End If
	End Function
	
	
	
	
	Function ReadIniFile(ByVal strIniFile As String, ByVal strSECTION As String, ByVal strKey As String) As String
		Dim strBuffer As String
		Dim intPos As Short
		
		'
		'If successful read of .INI file, strip any trailing zero returned by the Windows API GetPrivateProfileString
		'
		strBuffer = Space(gintMAX_SIZE)
		
		If GetPrivateProfileString(strSECTION, strKey, gstrNULL, strBuffer, gintMAX_SIZE, strIniFile) > 0 Then
			ReadIniFile = RTrim(StripTerminator(strBuffer))
		Else
			ReadIniFile = gstrNULL
		End If
	End Function
	
	
	Sub WriteIniFile(ByVal strIniFile As String, ByVal strSECTION As String, ByVal strKey As String, ByVal strValue As String)
		Dim strBuffer As String
		Dim intPos As Short
		Dim Buffer As Object
		strBuffer = Space(gintMAX_SIZE)
		'UPGRADE_WARNING: Couldn't resolve default property of object Buffer. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Buffer = WritePrivateProfileString(strSECTION, strKey, strValue, strIniFile)
	End Sub
	
	
	Public Sub DetError(ByRef Num As Short, ByRef Location As String)
		Dim MsgText As String
		Dim MsgTxt As String
		PlaySound(10)
		If Num = 3 Then
			MsgText = "Error : Použit RETURN bez GOSUB"
		ElseIf Num = 5 Then 
			MsgText = "Error : Chybné volání procedùry"
		ElseIf Num = 6 Then 
			MsgText = "Error : Pøeteèení"
		ElseIf Num = 7 Then 
			MsgText = "Error : Málo Pamìti"
		ElseIf Num = 9 Then 
			MsgText = "Error : Index mimo rozsah"
		ElseIf Num = 11 Then 
			MsgText = "Error : Pole je pevné nebo zamknuté"
		ElseIf Num = 13 Then 
			MsgText = "Error : Typ Nesouhlasí"
		ElseIf Num = 14 Then 
			MsgText = "Error : Nedostatek místa v øetìzci"
		ElseIf Num = 16 Then 
			MsgText = "Error : Pøíliš složitý výraz"
		ElseIf Num = 17 Then 
			MsgText = "Error : Nelze provést"
		ElseIf Num = 18 Then 
			MsgText = "Error : Pøerušeno uživatelem"
		ElseIf Num = 20 Then 
			MsgText = "Error : Použití RESUME bez chyby"
		ElseIf Num = 28 Then 
			MsgText = "Error : Málo místa v zásobníku"
		ElseIf Num = 35 Then 
			MsgText = "Error : Procedùra,funkce nebo vlastnost neni definována"
		ElseIf Num = 47 Then 
			MsgText = "Error : DLL využívá moc aplikací"
		ElseIf Num = 48 Then 
			MsgText = "Error : Chyba pøi naèítání DLL"
		ElseIf Num = 49 Then 
			MsgText = "Error : Chybná konvence volání knihovny DLL"
		ElseIf Num = 51 Then 
			MsgText = "Error : Interní chyba"
		ElseIf Num = 52 Then 
			MsgText = "Error : Špatný název nebo èíslo souboru"
		ElseIf Num = 53 Then 
			MsgText = "Error : Soubor Nenalezen"
		ElseIf Num = 54 Then 
			MsgText = "Error : Špatný Režim Souboru"
		ElseIf Num = 55 Then 
			MsgText = "Error : Soubor je už otevøen"
		ElseIf Num = 57 Then 
			MsgText = "Error : I/O chyba"
		ElseIf Num = 58 Then 
			MsgText = "Error : Soubor už existuje"
		ElseIf Num = 59 Then 
			MsgText = "Error : Chybná délka záznamu"
		ElseIf Num = 61 Then 
			MsgText = "Error : Disk je plný"
		ElseIf Num = 62 Then 
			MsgText = "Error : Vstup za koncem souboru"
		ElseIf Num = 63 Then 
			MsgText = "Error : Chybné èíslo záznamu"
		ElseIf Num = 67 Then 
			MsgText = "Error : Pøíliš souborù"
		ElseIf Num = 68 Then 
			MsgText = "Error : Zaøízení není dostupné"
		ElseIf Num = 70 Then 
			MsgText = "Error : Pøístup odmítnut"
		ElseIf Num = 71 Then 
			MsgText = "Error : Disk není pøipraven"
		ElseIf Num = 74 Then 
			MsgText = "Error : Nejde pøesunout na jinou jednotku"
		ElseIf Num = 75 Then 
			MsgText = "Error : Chyba v pøístupu k souboru"
		ElseIf Num = 76 Then 
			MsgText = "Error : Cesta nenalezena"
		ElseIf Num = 91 Then 
			MsgText = "Error : Není nastavená objektová promìná nebo promìnná WITH"
		ElseIf Num = 92 Then 
			MsgText = "Error : Neinicializovaná smyèka FOR"
		ElseIf Num = 93 Then 
			MsgText = "Error : Chybný øetìzec vzorku"
		ElseIf Num = 94 Then 
			MsgText = "Error : Chybné použití NULL"
		ElseIf Num = 444 Then 
			MsgText = "Error : Metoda se nedá použít v tomto kontextu"
		ElseIf Num = 452 Then 
			MsgText = "Error : Chybné èíslo procedùry v DLL"
		ElseIf Num = 453 Then 
			MsgText = "Error : Funkce v DLL nenalezena"
		ElseIf Num = 481 Then 
			MsgText = "Error : Chybný Obrázek"
		ElseIf Num = 482 Then 
			MsgText = "Error : Chyba Tiskárny"
		Else
			MsgText = "Error : Neznámá Chyba" & Chr(10) & Err.Description
		End If
		MsgTxt = "Byl zjištìn Error èíslo " & Num & " v sekci " & UCase(Location) & Chr(10) & MsgText
		MsgBox(MsgText, MsgBoxStyle.Critical, "ERROR")
		ConsoleWrite("ERROR " & Num & " in " & UCase(Location) & " = " & Err.Description)
		Err.Clear()
	End Sub
	
	Sub PlaySound(ByVal ResourceId As Short)
		On Error GoTo 1
		Dim Ret As Object
		Dim iD As String
		Select Case ResourceId
			Case 11
				If ReadIniFile("ini\sounds.ini", "SystemSounds", "Click") <> "" And FileExists("data\sounds\" & ReadIniFile("ini\sounds.ini", "SystemSounds", "Click")) Then
					'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Ret = sndPlaySound("data\sounds\" & ReadIniFile("ini\sounds.ini", "SystemSounds", "Click"), SND_ASYNC)
					System.Windows.Forms.Application.DoEvents()
				End If
			Case 14
				If ReadIniFile("ini\sounds.ini", "SystemSounds", "Click") <> "" And FileExists("data\sounds\" & ReadIniFile("ini\sounds.ini", "SystemSounds", "RequestShutDown")) Then
					'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Ret = sndPlaySound("data\sounds\" & ReadIniFile("ini\sounds.ini", "SystemSounds", "RequestShutDown"), SND_ASYNC)
					System.Windows.Forms.Application.DoEvents()
				End If
			Case 10
				If ReadIniFile("ini\sounds.ini", "SystemSounds", "Click") <> "" And FileExists("data\sounds\" & ReadIniFile("ini\sounds.ini", "SystemSounds", "Error")) Then
					'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Ret = sndPlaySound("data\sounds\" & ReadIniFile("ini\sounds.ini", "SystemSounds", "Error"), SND_ASYNC)
					System.Windows.Forms.Application.DoEvents()
				End If
			Case 13
				If ReadIniFile("ini\sounds.ini", "SystemSounds", "Click") <> "" And FileExists("data\sounds\" & ReadIniFile("ini\sounds.ini", "SystemSounds", "ShutDown")) Then
					'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Ret = sndPlaySound("data\sounds\" & ReadIniFile("ini\sounds.ini", "SystemSounds", "ShutDown"), SND_ASYNC)
					System.Windows.Forms.Application.DoEvents()
				End If
			Case 12
				If ReadIniFile("ini\sounds.ini", "SystemSounds", "Click") <> "" And FileExists("data\sounds\" & ReadIniFile("ini\sounds.ini", "SystemSounds", "IntroSound")) Then
					'UPGRADE_WARNING: Couldn't resolve default property of object Ret. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Ret = sndPlaySound("data\sounds\" & ReadIniFile("ini\sounds.ini", "SystemSounds", "IntroSound"), 0)
				End If
			Case Else
		End Select
		GoTo 2
1: 
		DetError(Err.Number, "PlaySound")
		GoTo 2
2: 
	End Sub
	
	
	
	Sub WWWconnect()
		On Error GoTo 1
		ShellExecute(Main_Renamed.Handle.ToInt32, "open", ReadIniFile("ini\main.ini", "Common", "WWW"), "", "", 1)
		ConsoleWrite("WWW.connect=" & ReadIniFile("ini\main.ini", "Common", "WWW"))
		GoTo 2
1: 
		If Err.Number Then DetError(Err.Number, "WWW.Connect")
		GoTo 2
2: 
	End Sub
	
	
	
	Sub Pause(ByVal nSecond As Single)
		Dim t0 As Single
		Dim dummy As Short
		
		t0 = VB.Timer()
		Do While VB.Timer() - t0 < nSecond
			'UPGRADE_ISSUE: DoEvents does not return a value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8D115264-E27F-4472-A684-865A00B5E826"'
			dummy = System.Windows.Forms.Application.DoEvents()
			If VB.Timer() < t0 Then
				t0 = t0 - 24 * 3600
			End If
		Loop 
	End Sub
End Module