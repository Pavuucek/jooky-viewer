VERSION 4.00
Begin VB.Form Installer 
   BackColor       =   &H00FF0000&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Instalátor"
   ClientHeight    =   3180
   ClientLeft      =   60
   ClientTop       =   2280
   ClientWidth     =   7200
   ClipControls    =   0   'False
   BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
      Name            =   "MS Sans Serif"
      Size            =   8.25
      Charset         =   238
      Weight          =   700
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Height          =   3690
   Icon            =   "Installer.frx":0000
   KeyPreview      =   -1  'True
   Left            =   0
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   212
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   480
   Top             =   1830
   Width           =   7320
   Begin VB.FileListBox File1 
      BackColor       =   &H00000000&
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   238
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   2460
      Left            =   4680
      Pattern         =   "*.ZXC"
      TabIndex        =   0
      Top             =   120
      Width           =   2415
   End
   Begin VB.Label cmdOk 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "I&nstalovat"
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
      Top             =   2640
      Width           =   1260
   End
   Begin VB.Label cmdCancel 
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
      Left            =   6360
      TabIndex        =   2
      Top             =   2640
      Width           =   765
   End
   Begin VB.Image imgBackGround 
      Height          =   3735
      Left            =   0
      Top             =   0
      Width           =   8175
   End
   Begin RichTextLib.RichTextBox RichTextBox1 
      Height          =   2895
      Left            =   120
      TabIndex        =   1
      Top             =   120
      Width           =   4455
      _ExtentX        =   7858
      _ExtentY        =   5106
      _Version        =   393217
      BackColor       =   16777215
      ReadOnly        =   -1  'True
      ScrollBars      =   3
      TextRTF         =   $"Installer.frx":0442
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   238
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
End
Attribute VB_Name = "Installer"
Attribute VB_Creatable = False
Attribute VB_Exposed = False
Option Explicit



Private Sub cmdcancel_Click()
PlaySound 11
Unload Me
ConsoleWrite "INSTALLER.uninit"
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Inst_File", setting:=""

End Sub


Private Sub dirDirs_Change()

End Sub


Private Sub drvDrives_Change()

End Sub

Private Sub cmdCancel_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
cmdOK.ForeColor = &HFFFF&
cmdCancel.ForeColor = &HC000C0
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub

Private Sub cmdOK_Click()
On Error GoTo 1
prgz = GetSetting(appname:="Harley Software", section:="Jooky-Viewer", Key:="Inst_File")
PlaySound 11
If prgz = "" Then
    MsgBox Title:="WARNING", prompt:="Nic si nezvolil !!!", Buttons:=vbExclamation
  Else
    Shell "cd\" & prgz, vbNormalFocus
    ConsoleWrite "INSTALLER.extract=" & prgz
End If
GoTo 2
1:
DetError Err.Number, "installer"
GoTo 2
2:
End Sub

Private Sub cmdOK_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
cmdOK.ForeColor = &HC000C0
cmdCancel.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub


Private Sub dir1_Change()

pthz = dir1.Path
End Sub

Private Sub dir1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
cmdOK.ForeColor = &HFFFF&
cmdCancel.ForeColor = &HFFFF&

End Sub


Private Sub drive1_Change()
On Error GoTo 1
dir1.Path = drive1.Drive
1:
If Err.Number = 68 Then
  MsgBox Title:="DRIVE ERROR WARNING", prompt:="Disk není pøipraven, nebo s nim nìco je, udìlej s tim nìco. Až zmáèkneš OK, tak se pokusim nastavit disk C:"
  drive1.Drive = "c:"
  Resume
End If
End Sub

Private Sub File1_Click()
PlaySound 11
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Inst_File", setting:=File1.filename
RichTextBox1.filename = ReadIniFile("ini\main.ini", "Files", File1.filename)
End Sub

Private Sub File1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
cmdOK.ForeColor = &HFFFF&
cmdCancel.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub


Private Sub Form_Load()
On Error GoTo 1
DrawBckGround Me, "Installer"
CenterForm Me
ConsoleWrite "INSTALLER.init"
RichTextBox1.Text = "Zvol si jméno souboru a místo tohoto textu se zobrazí informace o daném programu. Pokud si ho budeš chtít nainstalovat, zmáèkni na tlaèítko 'Instalovat'. Pokud se zobrazí nìjaké chybové hlášení, tak bude asi nìco v nepoøádku s daným souborem."
File1.Path = "cd"
RichTextBox1.RightMargin = RichTextBox1.Width - 40
Me.Enabled = True
GoTo 2
1:
If Err Then DetError Err.Number, "installer"
GoTo 2
2:
End Sub

Private Sub lblDrives_Click()

End Sub


Private Sub lblPath_Click()

End Sub


Private Sub lblPrompt_Click()

End Sub


Private Sub Timer1_Timer()
Installer.Left = Installer.Left + 300
If Installer.Left >= 100 Then
  Installer.Left = 105
  Timer1.Enabled = False
End If
End Sub


Private Sub Timer2_Timer()
Installer.Left = Installer.Left - 300
If Installer.Left <= -10000 Then
  Me.Left = -10000
  Unload Me
  Main.Enabled = True
  Main.Show
  Timer1.Enabled = False
  Timer2.Enabled = False
  ConsoleWrite "INSTALLER.uninit"
End If
End Sub


Private Sub Form_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
cmdOK.ForeColor = &HFFFF&
cmdCancel.ForeColor = &HFFFF&
Me.MousePointer = vbDefault
End Sub


Private Sub Label1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
cmdOK.ForeColor = &HFFFF&
cmdCancel.ForeColor = &HFFFF&

End Sub


Private Sub Image1_Click()

End Sub

Private Sub imgbackground_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
cmdOK.ForeColor = &HFFFF&
cmdCancel.ForeColor = &HFFFF&
Me.MousePointer = vbDefault

End Sub


Private Sub RichTextBox1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
cmdOK.ForeColor = &HFFFF&
cmdCancel.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Console.LOGboX.MouseIcon

End Sub


