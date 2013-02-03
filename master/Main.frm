VERSION 5.00
Begin VB.Form Main 
   AutoRedraw      =   -1  'True
   BackColor       =   &H00FF0000&
   BorderStyle     =   0  'None
   Caption         =   "DiskMag ENGINE"
   ClientHeight    =   3570
   ClientLeft      =   1170
   ClientTop       =   2295
   ClientWidth     =   9480
   Icon            =   "Main.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   PaletteMode     =   1  'UseZOrder
   ScaleHeight     =   238
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   632
   ShowInTaskbar   =   0   'False
   WindowState     =   2  'Maximized
   Begin VB.CommandButton Secret 
      Height          =   195
      Left            =   0
      TabIndex        =   0
      Top             =   5280
      Width           =   75
   End
   Begin VB.Image XitBTN 
      Height          =   495
      Left            =   11160
      MouseIcon       =   "Main.frx":030A
      MousePointer    =   99  'Custom
      Stretch         =   -1  'True
      Top             =   0
      Width           =   855
   End
   Begin VB.Image Image1 
      Height          =   9975
      Left            =   0
      Stretch         =   -1  'True
      Top             =   1200
      Width           =   15375
   End
   Begin VB.Label Lis 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "&Obsah tohoto ËÌsla"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   238
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   330
      Left            =   120
      TabIndex        =   7
      Top             =   480
      Width           =   2385
   End
   Begin VB.Label HelpBTN 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "&N·povÏda"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   238
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   330
      Left            =   2760
      TabIndex        =   6
      Top             =   840
      Width           =   1290
   End
   Begin VB.Label CP 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "Ovl·da&cÌ Panel"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   238
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   330
      Left            =   4200
      TabIndex        =   5
      Top             =   720
      Width           =   1920
   End
   Begin VB.Label Install 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "&Instalace program˘"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   238
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   330
      Left            =   120
      TabIndex        =   4
      Top             =   840
      Width           =   2430
   End
   Begin VB.Label VHS 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "&P¯ehr·vaË"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   238
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   330
      Left            =   2760
      TabIndex        =   3
      Top             =   480
      Width           =   1275
   End
   Begin VB.Image imgtitle 
      Height          =   480
      Left            =   0
      Picture         =   "Main.frx":0614
      Stretch         =   -1  'True
      Top             =   0
      Visible         =   0   'False
      Width           =   12150
   End
   Begin VB.Label NuMx 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "Numero"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   238
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   330
      Left            =   6240
      TabIndex        =   2
      Top             =   600
      Width           =   1005
   End
   Begin VB.Label Usr 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "U$er"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   238
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00C0FFC0&
      Height          =   270
      Left            =   7560
      TabIndex        =   1
      Top             =   720
      Width           =   540
   End
   Begin VB.Image imgBackGround 
      Height          =   8295
      Left            =   0
      Top             =   0
      Width           =   12015
   End
End
Attribute VB_Name = "Main"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Private Sub Command1_Click()
RemoveShellLink "", "Harley Software ltd"
End Sub

Private Sub CP_Click()
PlaySound 11
ConsoleWrite "CONTROLPANEL.init"
With MCIfrm
.Show 'vbmodal
.Enabled = True
End With
End Sub

Private Sub CP_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Lis.ForeColor = &HFFFF&
Install.ForeColor = &HFFFF&
HelpBTN.ForeColor = &HFFFF&
CP.ForeColor = &HC000C0
'xitBTN.ForeColor = &HFFFF&
VHS.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = XitBTN.MouseIcon

End Sub


Private Sub Form_Activate()
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

Private Sub Form_Load()
Dim numero As Integer
On Error GoTo 1
'TempDir = Environ("temp") & "\Jooky_$_"
'CreateTemp
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="EditMode", setting:="0"
Dim XtrA
Dim User
Dim VaLuEE As Integer
Dim SuP As String
frmSplash.ProgressBar1.Value = 0
Select Case LCase(Command)
  Case "-shortcut"
    SuP = "shortcut"
  Case "-launcher"
    SuP = "launcher"
  Case Else
    SuP = "direct"
End Select
frmSplash.StatCon.Caption = ""
Me.ScaleMode = vbPixels
imgtitle.Visible = True
imgtitle.Top = 0
imgtitle.Left = 0
'Image1.Top = imgtitle.Top + imgtitle.Height
Dim res
Select Case LCase(DetRes)
  Case "640x480", "800x600", "1024x768"
    res = DetRes
  Case "less"
    MsgBox prompt:="M·ö nastavenÈ moc MAL… rozliöenÌ Plochy, skus jedno z tÏchto : 640x480, 800x600, 1024x768" & Chr(10) & "BALIM TO !!!", Buttons:=vbInformation
    End
  Case "more"
    MsgBox prompt:="M·ö nastavenÈ moc VELK… rozliöenÌ Plochy, skus jedno z tÏchto : 640x480, 800x600, 1024x768" & Chr(10) & "BALIM TO !!!", Buttons:=vbInformation
    End
End Select
Dim Statu$
If Not SearchINI Then End
Select Case ReadIniFile("ini\main.ini", "Common", "InitString")
Case ""
  frmSplash.stav.Caption = "Formating Hard Disk ..."
Case Else
  frmSplash.stav.Caption = ReadIniFile("ini\main.ini", "Common", "InitString")
End Select
frmSplash.Show
DoEvents
'Clearnuti erroru je nekdy dobre udelat co nejdriv
Err.Clear
'Otestujeme si jak se windows pustili
Select Case GetSystemMetrics(SM_CLEANBOOT)
     Case 1
       MsgBox prompt:="Nouzov˝ reûim odmÌt·m tolerovat !!!" & Chr(10) & "Spusù Windowsy norm·lnÏ.", Buttons:=vbCritical
       End
     Case 2
       MsgBox prompt:="Nouzov˝ reûim odmÌt·m tolerovat !!!" & Chr(10) & "A to jak se sÌtÌ, tak bez nÌ !!! " & Chr(10) & "Spusù Windowsy norm·lnÏ.", Buttons:=vbCritical
       End
     Case Else
       Statu$ = "ok"
End Select
frmSplash.ProgressBar1.Value = frmSplash.ProgressBar1.Value + 1
'Otestujeme, jestli uzivatel nepousti program dvakrat
If App.PrevInstance = True Then
  MsgBox Title:="JOOKY-VIEWER - DiskMag ENGINE", prompt:="Program je uû jednou spuötÏn. Zm·Ëni OK a program se zav¯e", Buttons:=vbExclamation
  End
End If
frmSplash.ProgressBar1.Value = frmSplash.ProgressBar1.Value + 1
Usr.Visible = False
VaLuEE = False
If XtrA = "1" Then
  Usr.Visible = True
  Usr.Caption = "GOD Mode ON" & Chr(10) & "User : " & User
  VaLuEE = True
End If
PlaySound 12
frmSplash.ProgressBar1.Value = frmSplash.ProgressBar1.Value + 1
Me.Icon = Main.Icon
numero = ReadIniFile("ini\main.ini", "Common", "Cislo")
Main.Height = Screen.Height
Main.Width = Screen.Width
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
  MsgBox Title:="Jooky-Viewer - ERROR !!!", prompt:="M·te nastavenÈ moc velkÈ rozliöenÌ plochy, nastavte si rozliöenÌ na jedno z tÏchto : 640x480, 800x600, 1024x768 a spusùte program znovu !!!!", Buttons:=vbExclamation
  End
Case "less"
  MsgBox Title:="Jooky-Viewer - ERROR !!!", prompt:="M·te nastavenÈ moc malÈ rozliöenÌ plochy, nastavte si rozliöenÌ na jedno z tÏchto : 640x480, 800x600, 1024x768 a spusùte program znovu !!!!", Buttons:=vbExclamation
  End
End Select
frmSplash.ProgressBar1.Value = frmSplash.ProgressBar1.Value + 1
imgtitle.Width = Image1.Width
'Image1.Height = Image1.Height + imgtitle.Height
If ReadIniFile("ini\graphics.ini", "SystemBitmaps", "Title") <> "" And FileExists("data\pictures\" & ReadIniFile("ini\graphics.ini", "SystemBitmaps", "Title")) Then
  Image1.Picture = LoadPicture("data\pictures\" & ReadIniFile("ini\graphics.ini", "SystemBitmaps", "Title"))
Else
  Image1.Picture = frmSplash.imgLogo
End If
Me.Caption = "DiskMag ENGINE " & numero
NuMx.Caption = "»Ìslo " & numero
NuMx.Top = Lis.Top + 5
NuMx.Left = XitBTN.Left + XitBTN.Width - NuMx.Width - 5
frmSplash.ProgressBar1.Value = frmSplash.ProgressBar1.Value + 1
Usr.Left = XitBTN.Left + XitBTN.Width - Usr.Width - 5
Usr.Top = NuMx.Top + NuMx.Height + 3
frmSplash.ProgressBar1.Value = frmSplash.ProgressBar1.Value + 1
MCIfrm.Hide
InitMusic
Console.Show
Console.LOGboX.Text = "JOOKY-VIEWER - Command Console"
ConsoleWrite "=============================="
ConsoleWrite "Init.TEST ..."
ConsoleWrite "StartDate=" & Date
ConsoleWrite "StartTime=" & Time
ConsoleWrite "StartSubject=" & Main.Caption
ConsoleWrite "StartMusic=" & UCase(MCIfrm.AMOVIE1.filename)
ConsoleWrite "StartResolution=" & res
frmSplash.ProgressBar1.Value = frmSplash.ProgressBar1.Value + 1
If VaLuEE = True Then
  ConsoleWrite "StartGODmode=ON"
  ConsoleWrite "StartUser=" & User
Else
  ConsoleWrite "StartGODmode=OFF"
  'ConsoleWrite "StartUser=" & UsEr
End If
ConsoleWrite "StartVersion=" & App.Major & "." & App.Minor
ConsoleWrite "StartINISearch=OK"
Select Case LCase(SuP)
  Case "shortcut"
    ConsoleWrite "Running from Shortcut"
  Case "launcher"
    ConsoleWrite "Running from Launcher"
  Case "direct"
    ConsoleWrite "Running from EXE"
End Select
ConsoleWrite "Init.TEST DONE"
ConsoleWrite "Ready ..."
ConsoleWrite ""
frmSplash.ProgressBar1.Value = frmSplash.ProgressBar1.Value + 1
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Play_Ready", setting:="1"
DrawBckGround Me, "Main", True
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Inst_File", setting:=""
GoTo 2
1:
If Err Then DetError Err.Number, "init.test"
GoTo 2
2:
frmSplash.ProgressBar1.Value = 10
Unload frmSplash
End Sub

Private Sub Form_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Lis.ForeColor = &HFFFF&
Install.ForeColor = &HFFFF&
HelpBTN.ForeColor = &HFFFF&
CP.ForeColor = &HFFFF&
'XitBTN.ForeColor = &HFFFF&
VHS.ForeColor = &HFFFF&
MousePointer = vbDefault
End Sub


Private Sub Form_Unload(Cancel As Integer)
On Error GoTo 1
PlaySound 14
ConsoleWrite "ShutDown NORMAL"
If MsgBox(Title:="Opravdu opustit program ???", prompt:="MyslÌö to V¡éNÃ ???", Buttons:=vbYesNo) = vbYes Then
  Select Case ReadIniFile("ini\main.ini", "Common", "ShowReklama")
  Case "1"
    ConsoleWrite "Value 'Reklama' is TRUE"
    SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Play_Ready", setting:="0"
    MCIfrm.AMOVIE1.Command = "Stop"
    MCIfrm.AMOVIE1.Command = "Close"
    ReklFRM.Show
  Case "0"
    ConsoleWrite "Value 'Reklama' is FALSE"
    SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Play_Ready", setting:="0"
    MCIfrm.AMOVIE1.Command = "Stop"
    MCIfrm.AMOVIE1.Command = "Close"
    ConsoleWrite "ShutDown NOW"
    WriteLOG
    End
  End Select
 Else
    ConsoleWrite "CANCELED"
    Cancel = True
    End If
GoTo 2
1:
DetError Err.Number, "ShutDown"
GoTo 2
2:
End Sub







Private Sub HelpBTN_Click()
PlaySound 11
Help.Show 'vbmodal
End Sub

Private Sub HelpBTN_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Lis.ForeColor = &HFFFF&
Install.ForeColor = &HFFFF&
HelpBTN.ForeColor = &HC000C0
CP.ForeColor = &HFFFF&
'XitBTN.ForeColor = &HFFFF&
VHS.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = XitBTN.MouseIcon
End Sub

Private Sub Image1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Lis.ForeColor = &HFFFF&
Install.ForeColor = &HFFFF&
HelpBTN.ForeColor = &HFFFF&
CP.ForeColor = &HFFFF&
'XitBTN.ForeColor = &HFFFF&
VHS.ForeColor = &HFFFF&
Me.MousePointer = vbDefault

End Sub


Private Sub imgbackground_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Lis.ForeColor = &HFFFF&
Install.ForeColor = &HFFFF&
HelpBTN.ForeColor = &HFFFF&
CP.ForeColor = &HFFFF&
'XitBTN.ForeColor = &HFFFF&
VHS.ForeColor = &HFFFF&
MousePointer = vbDefault

End Sub


Private Sub imgtitle_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Me.MousePointer = vbDefault

End Sub


Private Sub Install_Click()
PlaySound 11
With Installer
.Show 'vbmodal
.Enabled = True
End With
End Sub

Private Sub Install_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Lis.ForeColor = &HFFFF&
Install.ForeColor = &HC000C0
HelpBTN.ForeColor = &HFFFF&
CP.ForeColor = &HFFFF&
'XitBTN.ForeColor = &HFFFF&
VHS.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = XitBTN.MouseIcon

End Sub


Private Sub Lis_Click()
PlaySound 11
With List
.Show 'vbmodal
.Enabled = True
.Icon = Main.Icon
End With
End Sub



Private Sub Lis_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Lis.ForeColor = &HC000C0
Install.ForeColor = &HFFFF&
HelpBTN.ForeColor = &HFFFF&
CP.ForeColor = &HFFFF&
'XitBTN.ForeColor = &HFFFF&
VHS.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = XitBTN.MouseIcon

End Sub


Private Sub Num_Click()

End Sub

Private Sub Secret_Click()
Dim XtrA, passwordik As String
On Error GoTo ass
XtrA = GetSetting(appname:="Harley Software", section:="Jooky-Viewer", Key:="GOD_Mode")
If XtrA <> "1" Then
  MsgBox Title:="The Secret Section", prompt:="Nem·ö zapnut˝ tzv. 'GOD mÛd', ten je pot¯eba pro vstup do tajnÈ sekce !!!", Buttons:=vbExclamation
  Exit Sub
End If
passwordik = LCase(InputBox("Pro vstup do tajnÈ sekce je nutno nejprve vloûit heslo !!!", "The Secret Section"))
ConsoleWrite "PIXVIEWER.SecretSection.init"
Select Case LCase(passwordik)
Case LCase(ReadIniFile("ini\main.ini", "Common", "Heslo"))
    WaitFRM.Show
    DoEvents
    If Not FileExists("data\pictures\secret.65") Then Err.Raise 53
    Sexret.Image1.Picture = LoadPicture("data\pictures\secret.65")
    ConsoleWrite "PIXVIEWER.SecretSection.Password=" & passwordik
    ConsoleWrite "PIXVIEWER.SecretSection=ACCESS ALLOWED"
    ConsoleWrite "Opening secret section ..."
    Sexret.Show
    Unload WaitFRM
Case vbCancel
  Exit Sub
Case Else
  MsgBox Title:="äpatnÏ !!!", prompt:="äpatnÈ heslo !!!" & Chr(10) & Chr(10) & "ACCESS DENIED !!!"
  ConsoleWrite "PIXVIEWER.SecretSection=ACCESS NOT ALLOWED !!!"
End Select

ass:
If Err.Number = 53 Then
    MsgBox Title:="ERROR", prompt:="Obr·zek NEJNI !!!" & Chr(10) & "Zobrazuji n·hradnÌ.", Buttons:=vbInformation
    ConsoleWrite "PIXVIEWER.error=NO SECRET PICTURE DETECTED"
    Sexret.Image1.Picture = frmSplash.imgLogo.Picture
    Sexret.Show
    Exit Sub
End If
End Sub


Private Sub Secret_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Me.MousePointer = 99
Me.MouseIcon = XitBTN.MouseIcon

End Sub


Private Sub VHS_Click()
PlaySound 11
  AMovieFRM.Show 'vbmodal
End Sub


Private Sub VHS_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Lis.ForeColor = &HFFFF&
Install.ForeColor = &HFFFF&
HelpBTN.ForeColor = &HFFFF&
CP.ForeColor = &HFFFF&
'XitBTN.ForeColor = &HFFFF&
VHS.ForeColor = &HC000C0
Me.MousePointer = 99
Me.MouseIcon = XitBTN.MouseIcon

End Sub


Private Sub XitBTN_Click()
PlaySound 14
Unload Me
End Sub


Private Sub XitBTN_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Lis.ForeColor = &HFFFF&
Install.ForeColor = &HFFFF&
HelpBTN.ForeColor = &HFFFF&
CP.ForeColor = &HFFFF&
'XitBTN.ForeColor = &HC000C0
VHS.ForeColor = &HFFFF&


End Sub



