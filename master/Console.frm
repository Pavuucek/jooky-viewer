VERSION 4.00
Begin VB.Form Console 
   BackColor       =   &H00FF0000&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Jooky-Viewer - Command Console"
   ClientHeight    =   4125
   ClientLeft      =   1500
   ClientTop       =   1845
   ClientWidth     =   6675
   ClipControls    =   0   'False
   Height          =   4635
   Icon            =   "Console.frx":0000
   Left            =   1440
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   NegotiateMenus  =   0   'False
   ScaleHeight     =   4125
   ScaleWidth      =   6675
   Top             =   1395
   Width           =   6795
   WindowState     =   1  'Minimized
   Begin VB.TextBox Text1 
      BackColor       =   &H00000000&
      Height          =   285
      Left            =   120
      TabIndex        =   0
      Text            =   "Text1"
      Top             =   600
      Width           =   6495
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Label1"
      ForeColor       =   &H00FFFFFF&
      Height          =   195
      Left            =   120
      TabIndex        =   2
      Top             =   120
      Width           =   480
   End
   Begin VB.Image imbPozadi 
      Height          =   375
      Left            =   0
      Picture         =   "Console.frx":000C
      Stretch         =   -1  'True
      Top             =   0
      Width           =   1095
   End
   Begin RichTextLib.RichTextBox LOGboX 
      Height          =   3015
      Left            =   120
      TabIndex        =   1
      Top             =   960
      Width           =   6495
      _ExtentX        =   11456
      _ExtentY        =   5318
      _Version        =   393217
      BackColor       =   0
      Enabled         =   -1  'True
      ReadOnly        =   -1  'True
      ScrollBars      =   2
      MousePointer    =   99
      MouseIcon       =   "Console.frx":6F44
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   238
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
End
Attribute VB_Name = "Console"
Attribute VB_Creatable = False
Attribute VB_Exposed = False
Option Explicit
Private Sub Form_Load()
On Error GoTo 1
imbPozadi.Height = Me.Height
imbPozadi.Width = Me.Width
LOGboX.SelColor = &HFFFFFF
Text1.ForeColor = &HFFFFFF
Me.Icon = Main.Icon
Text1.Text = ""
Label1.Caption = "Konzole slouží k monitorování èinnosti diskmagu a k jeho èásteènému ovládání." & Chr(10) & "Pokud nejste èlovìk pøíkazùznalý, tak konzoli radši nechte napokoji."
GoTo 2
1:
  If Err Then DetError Err.Number, "console"
  GoTo 2
2:

End Sub


Private Sub Form_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Me.MousePointer = vbDefault
End Sub


Private Sub Form_Unload(Cancel As Integer)
PlaySound 13
Text1.Text = UCase("unload me")
MsgBox "Nemùžeš zavøít konzoli !!!" & Chr(10) & "Pøíkazem 'UNLOAD ME' se zavøe celý DiskMag"
Cancel = True
End Sub


Private Sub RichTextBox1_Change()

End Sub

Private Sub Label1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Me.MousePointer = vbDefault
End Sub


Private Sub Text1_KeyPress(KeyAscii As Integer)
On Error GoTo 1
Dim cmd As Variant
If KeyAscii = vbKeyReturn Then
  LOGboX.Text = LOGboX.Text & Chr(10) & "Command: " & UCase(Text1.Text)
  Select Case LCase(Text1.Text)
  Case "show secret"
    Maskot
  Case "unload me"
    ConsoleWrite "Sending Shutdown command ..."
    Unload Main
  Case "unload now"
    ConsoleWrite "ShutDown CONSOLE"
    WriteLOG
    End
  Case "run dos"
    Shell ("c:\command.com"), vbMaximizedFocus
    ConsoleWrite "Running MS-DOS ..."
  Case "run xplr"
    Shell ("explorer.exe"), vbMaximizedFocus
    ConsoleWrite "Running EXPLORER ..."
  Case "show errorlist"
    ErrorList.Show
  Case "edit main.ini"
    Shell "notepad ini\main.ini", vbMaximizedFocus
  Case "show password"
    MsgBox Title:="Heslo k tajné èásti", prompt:="Heslo je : " & UCase(ReadIniFile("ini\main.ini", "Common", "Heslo")), Buttons:=vbCritical
  Case "run www"
    WWWconnect
  Case "show www"
    ConsoleWrite "WWW.ADDRESS=" & UCase(ReadIniFile("ini\main.ini", "Common", "WWW"))
    MsgBox Title:="Internetová adresa", prompt:="Adresa na ENGINE On-Line je : " & UCase(ReadIniFile("ini\main.ini", "Common", "WWW")), Buttons:=vbInformation
  Case "show list"
    List.Show
  Case "show player"
    AMovieFRM.Show
  Case "show about"
    PRGinF.Show
  Case "show cp", "show control panel", "show controlpanel"
    ConsoleWrite "CONTROLPANEL.init"
    MCIfrm.Show
  Case "show installer"
    Installer.Show
  Case "show help"
    Help.Show
  Case "god mode on"
    MsgBox Title:="!!! WARNING !!!", prompt:="Tento pøíkaz je urèen pro aktivování tzv. 'GOD módu', pokud jsi k tomu oprávnìn, tak zadej heslo !!!!", Buttons:=vbExclamation
    passwordicek = LCase(InputBox("Pro pro aktivování 'GOD módu' je nutno nejprve vložit heslo !!!", "Activating 'GOD mode'"))
    If LCase(passwordicek) = ReadIniFile("ini\main.ini", "Common", "Heslo") Then SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="GOD_Mode", setting:="1"
    MsgBox Title:="!!! WARNING !!!", prompt:="Nyní zadej své jméno ...", Buttons:=vbExclamation
    SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="User_Name", setting:=InputBox("Zadej své jméno :", "Activating 'GOD mode'")
    XtrA = GetSetting(appname:="Harley Software", section:="Jooky-Viewer", Key:="GOD_Mode")
    UsEr = GetSetting(appname:="Harley Software", section:="Jooky-Viewer", Key:="User_Name")
    If XtrA = "1" Then
      Main.Usr.Visible = True
      Main.Usr.Caption = "GOD Mode ON" & Chr(10) & "User : " & UsEr
      Main.Usr.Left = Main.XitBTN.Left + Main.XitBTN.Width - Main.Usr.Width - 5
      Main.Usr.Top = Main.NuMx.Top + Main.NuMx.Height + 3
    End If
  Case "god mode off"
    DeleteSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="GOD_Mode"
    Main.Usr.Visible = False
    MsgBox Title:="!!! WARNING !!!", prompt:="'GOD mód' byl deaktivován !!!", Buttons:=vbExclamation
  Case "satan mode on", "satan mode off"
    MsgBox Title:="!!! WARNING !!!", prompt:="'SATAN mode' ZATÍM nevedeme !!!", Buttons:=vbExclamation
  Case "editmode"
  If GetSetting(appname:="Harley Software", section:="Jooky-Viewer", Key:="GOD_Mode") = "1" Then
    SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="EditMode", setting:="1"
    MsgBox Title:="Jooky-Viewer", prompt:="Byly zapnuty editaèní vlastnosti programu !!!", Buttons:=vbExclamation
  Else
    MsgBox Title:="Jooky-Viewer", prompt:="Pro aktivaci editaèních vlastností je nutno spustit GOD MODE !!!", Buttons:=vbExclamation
  End If
  Case "initmusic"
    InitMusic
    ConsoleWrite "INITMUSIC.filename=" & MCIfrm.AMOVIE1.filename
  Case Else
    MsgBox Title:="Jooky-Viewer", prompt:="Bad Command or File Name !!!", Buttons:=vbExclamation
    LOGboX.Text = LOGboX.Text & " is not valid command"
  End Select
  Text1.Text = ""
End If
GoTo 2
1:
  If Err Then DetError Err.Number, "console"
  GoTo 2
2:

End Sub

Private Sub Text1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Me.MousePointer = 99
Me.MouseIcon = LOGboX.MouseIcon

End Sub


