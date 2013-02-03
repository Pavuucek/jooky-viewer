Attribute VB_Name = "Main_Engine"
Option Explicit

Public i As Integer
Public WindoW As Integer
Public ble As Integer
Public PoPiSeK As String
Public MaSkA As String
Public Fil As String
Public prgz As String
Public pthz As String
Public RexX As String
Declare Function sndPlaySound Lib "winmm.dll" Alias "sndPlaySoundA" _
        (ByVal lpszSoundName As Any, ByVal uFlags As Long) As Long
Global Const SND_ASYNC = &H1     ' Play asynchronously
Global Const SND_NODEFAULT = &H2 ' Don't use default sound
Global Const SND_MEMORY = &H4    ' lpszSoundName points to a memory file
Global Const gstrSEP_DIR$ = "\"  ' Directory separator character

Global SoundBuffer As String

Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Any, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Long, ByVal lpFileName As String) As Long
Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As Any, ByVal lpString As Any, ByVal lpFileName As String) As Long

Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
Global Const gintMAX_SIZE% = 255
Global Const gstrNULL$ = ""
Option Explicit
Public Declare Function GetSystemMetrics Lib "user32" (ByVal nIndex As Long) As Long
Public Const SM_CLEANBOOT = 67



Function DetRes() As String
If Screen.Width < 9600 And Screen.Height < 7200 Then DetRes = "less"
If Screen.Width = 9600 And Screen.Height = 7200 Then DetRes = "640x480"
If Screen.Width = 12000 And Screen.Height = 9000 Then DetRes = "800x600"
If Screen.Width = 15360 And Screen.Height = 11520 Then DetRes = "1024x768"
If Screen.Width > 15360 And Screen.Height > 11520 Then DetRes = "more"
End Function


Sub DrawBckGround(ByVal frm As Form, ByVal NaM As String, Optional ByVal Mx)
On Error GoTo 1
If IsMissing(Mx) Then Mx = False
Dim sCm
sCm = frm.ScaleMode
frm.ScaleMode = vbTwips
With frm.imgbackground
.Stretch = True
.Left = 0
.Top = 0
End With
frm.ScaleMode = vbPixels
If Mx = True Then
  Select Case DetRes
  Case "640x480"
    frm.ScaleMode = vbPixels
    frm.imgbackground.Height = 480
    frm.imgbackground.Width = 640
  Case "800x600"
    frm.ScaleMode = vbPixels
    frm.imgbackground.Height = 600
    frm.imgbackground.Width = 800
  Case "1024x768"
    frm.ScaleMode = vbPixels
    frm.imgbackground.Height = 768
    frm.imgbackground.Width = 1024
  End Select
Else
frm.ScaleMode = vbTwips
frm.imgbackground.Height = frm.Height
frm.imgbackground.Width = frm.Width
End If
frm.ScaleMode = vbTwips
If ReadIniFile("ini\graphics.ini", "BackGrounds", NaM) <> "" And FileExists("data\pictures\" & ReadIniFile("ini\graphics.ini", "BackGrounds", NaM)) Then
  frm.imgbackground.Picture = LoadPicture("data\pictures\" & ReadIniFile("ini\graphics.ini", "BackGrounds", NaM))
Else
  frm.imgbackground.Picture = Console.imbPozadi.Picture
End If
frm.ScaleMode = sCm
GoTo 2
1:
DetError Err.Number, "ChangeBackGround"
GoTo 2
2:
End Sub

Function SearchINI() As Boolean
Dim oK As Integer
oK = 0
If FileExists("ini\main.ini") Then oK = oK + 1
If FileExists("ini\graphics.ini") Then oK = oK + 1
If FileExists("ini\sounds.ini") Then oK = oK + 1
If FileExists("ini\music.ini") Then oK = oK + 1

If oK < 4 Then
 MsgBox Title:="Jooky-Viewer -  FATAL ERROR !!!!", prompt:="Nenalezl jsem nìkterý z dùležitých .INI souborù " & Chr(10) & "BALIM TO !!!!!", Buttons:=vbCritical
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
  Randomize
  Nahoda = Int((Rnd * ReadIniFile("ini\music.ini", "Common", "Last_Music")) + 1)
  If Not FileExists("data\music\" & ReadIniFile("ini\music.ini", "Files", "Music" & Nahoda)) Then Err.Raise 53
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
DetError Err.Number, "initmusic"
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
    Dim intZeroPos As Integer

    intZeroPos = InStr(strString, Chr$(0))
    If intZeroPos > 0 Then
        StripTerminator = Left$(strString, intZeroPos - 1)
    Else
        StripTerminator = strString
    End If
End Function




Function ReadIniFile(ByVal strIniFile As String, ByVal strSECTION As String, ByVal strKey As String) As String
    Dim strBuffer As String
    Dim intPos As Integer

    '
    'If successful read of .INI file, strip any trailing zero returned by the Windows API GetPrivateProfileString
    '
    strBuffer = Space$(gintMAX_SIZE)
     
    If GetPrivateProfileString(strSECTION, strKey, gstrNULL, strBuffer, gintMAX_SIZE, strIniFile) > 0 Then
        ReadIniFile = RTrim$(StripTerminator(strBuffer))
    Else
        ReadIniFile = gstrNULL
    End If
End Function


Sub WriteIniFile(ByVal strIniFile As String, ByVal strSECTION As String, ByVal strKey As String, ByVal strValue As String)
    Dim strBuffer As String
    Dim intPos As Integer
    Dim Buffer
    strBuffer = Space$(gintMAX_SIZE)
    Buffer = WritePrivateProfileString(strSECTION, strKey, strValue, strIniFile)
End Sub


Public Sub DetError(Num As Integer, Location As String)
Dim MsgText As String
Dim MsgTxt As String
PlaySound 10
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
MsgBox Title:="ERROR", prompt:=MsgText, Buttons:=vbCritical
ConsoleWrite "ERROR " & Num & " in " & UCase(Location) & " = " & Err.Description
Err.Clear
End Sub

Sub PlaySound(ByVal ResourceId As Integer)
On Error GoTo 1
    Dim Ret As Variant
    Dim iD As String
    Select Case ResourceId
    Case 11
      If ReadIniFile("ini\sounds.ini", "SystemSounds", "Click") <> "" And FileExists("data\sounds\" & ReadIniFile("ini\sounds.ini", "SystemSounds", "Click")) Then
        Ret = sndPlaySound("data\sounds\" & ReadIniFile("ini\sounds.ini", "SystemSounds", "Click"), SND_ASYNC)
        DoEvents
      End If
    Case 14
      If ReadIniFile("ini\sounds.ini", "SystemSounds", "Click") <> "" And FileExists("data\sounds\" & ReadIniFile("ini\sounds.ini", "SystemSounds", "RequestShutDown")) Then
        Ret = sndPlaySound("data\sounds\" & ReadIniFile("ini\sounds.ini", "SystemSounds", "RequestShutDown"), SND_ASYNC)
        DoEvents
      End If
    Case 10
      If ReadIniFile("ini\sounds.ini", "SystemSounds", "Click") <> "" And FileExists("data\sounds\" & ReadIniFile("ini\sounds.ini", "SystemSounds", "Error")) Then
        Ret = sndPlaySound("data\sounds\" & ReadIniFile("ini\sounds.ini", "SystemSounds", "Error"), SND_ASYNC)
        DoEvents
      End If
    Case 13
      If ReadIniFile("ini\sounds.ini", "SystemSounds", "Click") <> "" And FileExists("data\sounds\" & ReadIniFile("ini\sounds.ini", "SystemSounds", "ShutDown")) Then
        Ret = sndPlaySound("data\sounds\" & ReadIniFile("ini\sounds.ini", "SystemSounds", "ShutDown"), SND_ASYNC)
        DoEvents
      End If
    Case 12
      If ReadIniFile("ini\sounds.ini", "SystemSounds", "Click") <> "" And FileExists("data\sounds\" & ReadIniFile("ini\sounds.ini", "SystemSounds", "IntroSound")) Then
        Ret = sndPlaySound("data\sounds\" & ReadIniFile("ini\sounds.ini", "SystemSounds", "IntroSound"), 0)
      End If
    Case Else
    End Select
    GoTo 2
1:
DetError Err.Number, "PlaySound"
GoTo 2
2:
End Sub



Sub WWWconnect()
On Error GoTo 1
ShellExecute Main.hwnd, "open", ReadIniFile("ini\main.ini", "Common", "WWW"), "", "", 1
ConsoleWrite "WWW.connect=" & ReadIniFile("ini\main.ini", "Common", "WWW")
GoTo 2
1:
  If Err Then DetError Err.Number, "WWW.Connect"
  GoTo 2
2:
End Sub



Sub Pause(ByVal nSecond As Single)
  Dim t0 As Single
  Dim dummy As Integer

  t0 = Timer
  Do While Timer - t0 < nSecond
    dummy = DoEvents()
    If Timer < t0 Then
      t0 = t0 - 24 * 3600
    End If
   Loop
End Sub


