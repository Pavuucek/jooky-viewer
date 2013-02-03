VERSION 4.00
Begin VB.Form MCIfrm 
   BackColor       =   &H00FF0000&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Ovládací Panel"
   ClientHeight    =   3675
   ClientLeft      =   765
   ClientTop       =   1710
   ClientWidth     =   7560
   ClipControls    =   0   'False
   ControlBox      =   0   'False
   Height          =   4185
   Icon            =   "MCIfrm.frx":0000
   Left            =   705
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   NegotiateMenus  =   0   'False
   ScaleHeight     =   3675
   ScaleWidth      =   7560
   Top             =   1260
   Width           =   7680
   Begin VB.FileListBox File1 
      BackColor       =   &H00000000&
      ForeColor       =   &H00FFFFFF&
      Height          =   2010
      Left            =   120
      Pattern         =   "*.mid"
      TabIndex        =   0
      Top             =   120
      Width           =   3615
   End
   Begin MCI.MMControl AMOVIE1 
      Height          =   1095
      Left            =   120
      TabIndex        =   5
      Top             =   2400
      Width           =   7335
      _ExtentX        =   12938
      _ExtentY        =   1931
      _Version        =   393216
      DeviceType      =   ""
      FileName        =   ""
   End
   Begin VB.Label Label1 
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "Výbìr hudby se provádí zvolením požadovaného souboru v oknì nalevo. Ovládacími prvky napravo se mìní hlasitost."
      ForeColor       =   &H00FFFFFF&
      Height          =   855
      Left            =   3840
      TabIndex        =   4
      Top             =   840
      Width           =   2775
   End
   Begin VB.Label CloseB 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "&Zavøít"
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
      Left            =   4680
      TabIndex        =   3
      Top             =   240
      Width           =   765
   End
   Begin VB.Label PrNSeTuP 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "Nastavení tiskárny"
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
      Left            =   3960
      TabIndex        =   2
      Top             =   480
      Width           =   2415
   End
   Begin VB.Label RNDmus 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "&Vylosovat Hudbu"
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
      Left            =   4200
      TabIndex        =   1
      Top             =   1680
      Width           =   2190
   End
   Begin VB.Image imgBackGround 
      Height          =   2415
      Left            =   0
      Stretch         =   -1  'True
      Top             =   0
      Width           =   6735
   End
End
Attribute VB_Name = "MCIfrm"
Attribute VB_Creatable = False
Attribute VB_Exposed = False
Option Explicit

Private Sub AMOVIE1_Error(ByVal SCode As Integer, ByVal Description As String, ByVal Source As String, CancelDisplay As Boolean)
If Err Then DetError Err.Number, "controlpanel"
End Sub

Private Sub AMOVIE1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
PrNseTuP.ForeColor = &HFFFF&
CloseB.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub

Private Sub AMOVIE1_OpenComplete()

End Sub


Private Sub AMOVIE1_StateChange(ByVal oldState As Long, ByVal newState As Long)

End Sub


Private Sub AMOVIE1_Timer()

End Sub

Private Sub AMOVIE1_Done(NotifyCode As Integer)
Select Case GetSetting(appname:="Harley Software", section:="Jooky-Viewer", Key:="Play_Ready")
Case "1"
  InitMusic
  ConsoleWrite "INITMUSIC.filename=" & MCIfrm.AMOVIE1.filename
Case Else
  Exit Sub
End Select
End Sub

Private Sub CloseB_Click()
PlaySound 11
ConsoleWrite "CONTROLPANEL.uninit"
Me.Hide
End Sub

Private Sub CloseB_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
PrNseTuP.ForeColor = &HFFFF&
CloseB.ForeColor = &HC000C0
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub


Private Sub File1_Click()
On Error GoTo 1
PlaySound 11
ConsoleWrite "CONTROLPANEL.file=" & File1.filename
ConsoleWrite " Playing new music"
AMOVIE1.Command = "Stop"
AMOVIE1.Command = "Close"
AMOVIE1.filename = "data\music\" & File1.filename
Select Case LCase(Right(File1.filename, 3))
  Case "mid"
    AMOVIE1.DeviceType = "Sequencer"
  Case "wav"
    AMOVIE1.DeviceType = "WaveAudio"
End Select
AMOVIE1.Command = "Open"
AMOVIE1.Command = "Play"
GoTo 2
1:
If Err Then DetError Err.Number, "controlpanel"
GoTo 2
2:
End Sub

Private Sub File1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
PrNseTuP.ForeColor = &HFFFF&
CloseB.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub


Private Sub Form_Load()
CenterForm Me
DrawBckGround Me, "ControlPanel"
PrNseTuP.Visible = False
Me.Icon = Main.Icon
File1.Path = "data\music"
File1.Pattern = "*.MID;*.WAV"
End Sub


Private Sub Form_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
PrNseTuP.ForeColor = &HFFFF&
CloseB.ForeColor = &HFFFF&
rndmus.ForeColor = &HFFFF&
Me.MousePointer = vbDefault
End Sub



Private Sub Label3_Click()
PlaySound 11
InitMusic
End Sub

Private Sub imgbackground_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
PrNseTuP.ForeColor = &HFFFF&
CloseB.ForeColor = &HFFFF&
rndmus.ForeColor = &HFFFF&
Me.MousePointer = vbDefault

End Sub


Private Sub Label1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Me.MousePointer = vbDefault
End Sub


Private Sub MMControl1_Done(NotifyCode As Integer)

End Sub

Private Sub PrNseTuP_Click()
PlaySound 11
ConsoleWrite "CONTROLPANEL.printersetup"
CommonDialog1.Flags = &H40
CommonDialog1.ShowPrinter
End Sub


Private Sub PrNseTuP_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
PrNseTuP.ForeColor = &HC000C0
CloseB.ForeColor = &HFFFF&
End Sub


Private Sub Timer1_Timer()
Me.Top = Me.Top + 300
If Me.Top >= 1300 Then
  Me.Top = 1350
  ConsoleWrite "CONTROLPANEL.init"
  Timer1.Enabled = False
End If
End Sub


Private Sub Timer2_Timer()
Me.Top = Me.Top - 300
If Me.Top <= -5000 Then
  Me.Hide
  Me.Enabled = False
  Main.Enabled = True
  Main.Show
  ConsoleWrite "CONTROLPANEL.uninit"
  Timer2.Enabled = False
End If
End Sub


Private Sub rndmus_Click()
PlaySound 11
InitMusic
ConsoleWrite "INITMUSIC.random=" & MCIfrm.AMOVIE1.filename
End Sub

Private Sub rndmus_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
rndmus.ForeColor = &HC000C0
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub


Private Sub SldWave_Change()
ConsoleWrite "PLAYER.ChangeWaveVolume=" & SldWave.Value
'wavehlas = waveOutSetVolume(2, 65000 - (6500 * SldWave.Value))
End Sub

Private Sub Slider1_Change()
ConsoleWrite "PLAYER.ChangeMidiVolume=" & Slider1.Value
'hlas = midiOutSetVolume(2, 65000 - (Slider1.Value * 6500))
End Sub

