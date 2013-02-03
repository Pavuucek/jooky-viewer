VERSION 4.00
Begin VB.Form AMovieFRM 
   BackColor       =   &H00FF0000&
   BorderStyle     =   0  'None
   Caption         =   "Pøehrávaè"
   ClientHeight    =   4050
   ClientLeft      =   1140
   ClientTop       =   1635
   ClientWidth     =   6690
   ClipControls    =   0   'False
   ControlBox      =   0   'False
   Height          =   4560
   Left            =   1080
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   NegotiateMenus  =   0   'False
   ScaleHeight     =   270
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   446
   ShowInTaskbar   =   0   'False
   Top             =   1185
   Width           =   6810
   WindowState     =   2  'Maximized
   Begin VB.FileListBox File1 
      BackColor       =   &H00000000&
      ForeColor       =   &H00FFFFFF&
      Height          =   1230
      Left            =   120
      Pattern         =   "*.mid"
      TabIndex        =   0
      Top             =   5400
      Width           =   2895
   End
   Begin AMovieCtl.ActiveMovie ActiveMovie1 
      Height          =   1110
      Left            =   0
      TabIndex        =   3
      Top             =   360
      Width           =   3990
      _ExtentX        =   7038
      _ExtentY        =   1958
      ShowPositionControls=   -1  'True
      ShowSelectionControls=   -1  'True
      EnableSelectionControls=   0   'False
      AllowHideDisplay=   0   'False
      SelectionStart  =   -1
      Appearance      =   0
   End
   Begin VB.Label Back6 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "<<< &Zpìt"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   15
         Charset         =   238
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   345
      Left            =   6480
      TabIndex        =   2
      Top             =   5760
      Width           =   1230
   End
   Begin VB.Label CaP 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "Pøehrávaè"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   15
         Charset         =   238
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   345
      Left            =   0
      TabIndex        =   1
      Top             =   0
      Width           =   1335
   End
   Begin VB.Image imgBackGround 
      Height          =   8055
      Left            =   0
      Top             =   0
      Width           =   11415
   End
End
Attribute VB_Name = "AMovieFRM"
Attribute VB_Creatable = False
Attribute VB_Exposed = False
Option Explicit
Private Sub ActiveXPlugin1_GotFocus()
End Sub


Private Sub ActiveMovie1_Error(ByVal SCode As Integer, ByVal Description As String, ByVal Source As String, CancelDisplay As Boolean)
Err.Description = Description
DetError SCode, "PLAYER"
End Sub

Private Sub ActiveMovie1_MouseDown(Button As Integer, Shift As Integer, X As Single, Y As Single)
Me.MousePointer = vbDefault
End Sub


Private Sub ActiveMovie1_OpenComplete()
Unload WaitFRM
End Sub


Private Sub Back6_Click()
PlaySound 11
Unload Me
ActiveMovie1.Stop
ConsoleWrite "PLAYER.GetMusic"
MCIfrm.AMOVIE1.filename = GetSetting(appname:="Harley Software", section:="Jooky-Viewer", Key:="Current_Music")
  Select Case LCase(Right(MCIfrm.AMOVIE1.filename, 3))
    Case "mid"
      MCIfrm.AMOVIE1.DeviceType = "Sequencer"
    Case "wav"
      MCIfrm.AMOVIE1.DeviceType = "WaveAudio"
    Case Else
  End Select
MCIfrm.AMOVIE1.Command = "Open"
MCIfrm.AMOVIE1.Command = "Play"
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Play_Ready", setting:="1"
End Sub


Private Sub Check1_Click()
ActiveMovie1.FullScreenMode = True
End Sub

Private Sub Back6_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Back6.ForeColor = &HC000C0
'Option1.ForeColor = &HFFFF&
'Option2.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon
End Sub

Private Sub File1_Click()
WaitFRM.Show
DoEvents
PlaySound 11
ConsoleWrite "PLAYER.file=" & File1.filename
ActiveMovie1.filename = "data\video\" & File1.filename
End Sub


Private Sub File1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Dim res As String
Back6.ForeColor = &HFFFF&
If Screen.Width = 9600 And Screen.Height = 7200 Then res = "640x480"
If Screen.Width = 12000 And Screen.Height = 9000 Then res = "800x600"
If Screen.Width >= 15360 And Screen.Height >= 11520 Then res = "1024x768"

Select Case res
Case "640x480"
  ActiveMovie1.Height = 361
  ActiveMovie1.Width = 640
Case "800x600"
  ActiveMovie1.Height = 481
  ActiveMovie1.Width = 800
Case "1024x768"
  ActiveMovie1.Height = 649
  ActiveMovie1.Width = 1024
End Select

Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub


Private Sub Form_Activate()
Dim res As String
If Screen.Width = 9600 And Screen.Height = 7200 Then res = "640x480"
If Screen.Width = 12000 And Screen.Height = 9000 Then res = "800x600"
If Screen.Width >= 15360 And Screen.Height >= 11520 Then res = "1024x768"

Select Case res
Case "640x480"
  ActiveMovie1.Height = 361 - CaP.Height - 2
  ActiveMovie1.Width = 640
  File1.Top = 368 + CaP.Height
Case "800x600"
  ActiveMovie1.Height = 481 - CaP.Height - 2
  ActiveMovie1.Width = 800
  File1.Top = 488 + CaP.Height
Case "1024x768"
  ActiveMovie1.Height = 649 - CaP.Height - 2
  ActiveMovie1.Width = 1024
  File1.Top = 656 + CaP.Height
End Select
Back6.Top = File1.Top
End Sub

Private Sub Form_Load()
On Error GoTo 1
Dim res
ConsoleWrite "PLAYER.init"
If Screen.Width = 9600 And Screen.Height = 7200 Then res = "640x480"
If Screen.Width = 12000 And Screen.Height = 9000 Then res = "800x600"
If Screen.Width >= 15360 And Screen.Height >= 11520 Then res = "1024x768"

Select Case res
Case "640x480"
  ActiveMovie1.Height = 361 - CaP.Height - 2
  ActiveMovie1.Width = 640
  File1.Top = 368 + CaP.Height
Case "800x600"
  ActiveMovie1.Height = 481 - CaP.Height - 2
  ActiveMovie1.Width = 800
  File1.Top = 488 + CaP.Height
Case "1024x768"
  ActiveMovie1.Height = 649 - CaP.Height - 2
  ActiveMovie1.Width = 1024
  File1.Top = 656 + CaP.Height
End Select
Back6.Top = File1.Top
File1.Path = "data\video"
File1.Pattern = "*.AVI;*.FLC;*.FLI;*.CEL;*.MPG;*.MOV;*.QT;*.MID;*.WAV;*.RMI"
'ConsoleWrite "PLAYER.SaveMusic"
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Current_Music", setting:=MCIfrm.AMOVIE1.filename
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Play_Ready", setting:="0"
DrawBckGround Me, "VidPlayer", True
MCIfrm.AMOVIE1.Command = "Stop"
MCIfrm.AMOVIE1.Command = "Close"
GoTo 2
1:
If Err Then DetError Err.Number, "player"
GoTo 2
2:
End Sub


Private Sub Form_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Dim res As String
Back6.ForeColor = &HFFFF&
If Screen.Width = 9600 And Screen.Height = 7200 Then res = "640x480"
If Screen.Width = 12000 And Screen.Height = 9000 Then res = "800x600"
If Screen.Width >= 15360 And Screen.Height >= 11520 Then res = "1024x768"

Select Case res
Case "640x480"
  ActiveMovie1.Height = 361
  ActiveMovie1.Width = 640
Case "800x600"
  ActiveMovie1.Height = 481
  ActiveMovie1.Width = 800
Case "1024x768"
  ActiveMovie1.Height = 649
  ActiveMovie1.Width = 1024
End Select
Me.MousePointer = vbDefault


End Sub


Private Sub Form_Unload(Cancel As Integer)
ConsoleWrite "PLAYER.uninit"
End Sub


Private Sub Option1_Click()
PlaySound 11
ConsoleWrite "PLAYER.mode=FULLSCREEN"
ActiveMovie1.FullScreenMode = True
End Sub


Private Sub Option1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
End Sub


Private Sub Option2_Click()
PlaySound 11
ConsoleWrite "PLAYER.mode=WINDOWED"
ActiveMovie1.FullScreenMode = False
End Sub


Private Sub Uvodnik_Click()

End Sub


Private Sub Option2_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
End Sub


Private Sub Image1_Click()

End Sub


Private Sub Image1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)

End Sub


Private Sub imgbackground_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Dim res As String
Back6.ForeColor = &HFFFF&
If Screen.Width = 9600 And Screen.Height = 7200 Then res = "640x480"
If Screen.Width = 12000 And Screen.Height = 9000 Then res = "800x600"
If Screen.Width >= 15360 And Screen.Height >= 11520 Then res = "1024x768"

Select Case res
Case "640x480"
  ActiveMovie1.Height = 361
  ActiveMovie1.Width = 640
Case "800x600"
  ActiveMovie1.Height = 481
  ActiveMovie1.Width = 800
Case "1024x768"
  ActiveMovie1.Height = 649
  ActiveMovie1.Width = 1024
End Select
Me.MousePointer = vbDefault

End Sub


