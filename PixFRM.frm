VERSION 4.00
Begin VB.Form PixFRM 
   BackColor       =   &H00FF0000&
   BorderStyle     =   0  'None
   Caption         =   "Obrázky"
   ClientHeight    =   4140
   ClientLeft      =   1410
   ClientTop       =   2625
   ClientWidth     =   6675
   ClipControls    =   0   'False
   ControlBox      =   0   'False
   Height          =   4650
   Left            =   1350
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   NegotiateMenus  =   0   'False
   ScaleHeight     =   4140
   ScaleWidth      =   6675
   ShowInTaskbar   =   0   'False
   Top             =   2175
   Width           =   6795
   WindowState     =   2  'Maximized
   Begin VB.FileListBox File1 
      BackColor       =   &H00000000&
      ForeColor       =   &H00FFFFFF&
      Height          =   1035
      Left            =   120
      Pattern         =   "*.bmp"
      TabIndex        =   0
      Top             =   960
      Width           =   975
   End
   Begin VB.Label PopiseK 
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "@@@"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   238
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   615
      Left            =   1440
      TabIndex        =   4
      Top             =   240
      Width           =   975
   End
   Begin VB.Label CaP 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "Obrázky"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Arial"
         Size            =   15
         Charset         =   238
         Weight          =   700
         Underline       =   -1  'True
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   360
      Left            =   0
      TabIndex        =   3
      Top             =   0
      Width           =   1185
   End
   Begin VB.Label Back 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "Zpìt"
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
      TabIndex        =   2
      Top             =   480
      Width           =   600
   End
   Begin VB.Label PrN 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "Tisk"
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
      Left            =   720
      TabIndex        =   1
      Top             =   480
      Width           =   540
   End
   Begin VB.Image Image1 
      Height          =   3495
      Left            =   840
      Stretch         =   -1  'True
      Top             =   3240
      Width           =   4335
   End
End
Attribute VB_Name = "PixFRM"
Attribute VB_Creatable = False
Attribute VB_Exposed = False
Option Explicit
Private Sub Back3_Click()
End Sub


Private Sub back_Click()
PlaySound 11
Unload Me
TextFRM.Enabled = True
TextFRM.Show
End Sub


Private Sub Back_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
PrN.ForeColor = &HFFFF&
Back.ForeColor = &HC000C0
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub


Private Sub File1_Click()
On Error GoTo 1
Dim clx, em As String
PlaySound 11
WaitFRM.Show
DoEvents
ConsoleWrite "PIXVIEWER.file=" & File1.filename
Err.Clear
Image1.Picture = LoadPicture(File1.Path & "\" & File1.filename)
clx = GetSetting(appname:="Harley Software", section:="Jooky-Viewer", Key:="Clanek")
em = GetSetting(appname:="Harley Software", section:="Jooky-Viewer", Key:="EditMode")
If em = "1" And ReadIniFile("ini\main.ini", clx, File1.filename) = "" Then
  PoPiSeK.Caption = "Klepnìte sem pro zadání popisku k obrázku"
Else
  PoPiSeK.Caption = ReadIniFile("ini\main.ini", clx, File1.filename)
End If
GoTo 2
1:
If Err Then DetError Err.Number, "pixviewer"
GoTo 2
2:
Unload WaitFRM
End Sub


Private Sub PrintBTN_Click()
PlaySound 11
Printer.Print Me.Picture;
End Sub


Private Sub File1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub

Private Sub Form_Activate()
Dim res As String
Image1.Top = Back.Top + 2
Image1.Left = 0
If Screen.Width = 9600 And Screen.Height = 7200 Then res = "640x480"
If Screen.Width = 12000 And Screen.Height = 9000 Then res = "800x600"
If Screen.Width >= 15360 And Screen.Height >= 11520 Then res = "1024x768"
Me.ScaleMode = vbPixels
Select Case res
Case "640x480"
Image1.Width = 640
Image1.Height = 480 - Back.Top + 2
Case "800x600"
Image1.Width = 800
Image1.Height = 600 - Back.Top + 2
Case "1024x768"
Image1.Width = 1024
Image1.Height = 768 - Back.Top + 2
End Select
PrN.Enabled = False
PrN.Visible = False
PoPiSeK.Width = Image1.Width - PoPiSeK.Left - 10
End Sub

Private Sub Form_Load()
Dim res As String
On Error GoTo 1
Me.Icon = Main.Icon
ConsoleWrite "PIXVIEWER.init"
File1.Pattern = "*.BMP;*.JPG;*.GIF"
Image1.Top = Back.Top + 2
Image1.Left = 0
If Screen.Width = 9600 And Screen.Height = 7200 Then res = "640x480"
If Screen.Width = 12000 And Screen.Height = 9000 Then res = "800x600"
If Screen.Width >= 15360 And Screen.Height >= 11520 Then res = "1024x768"
Me.ScaleMode = vbPixels
Select Case res
Case "640x480"
Image1.Width = 640
Image1.Height = 480 - Back.Top + 2
Case "800x600"
Image1.Width = 800
Image1.Height = 600 - Back.Top + 2
Case "1024x768"
Image1.Width = 1024
Image1.Height = 768 - Back.Top + 2
End Select
PoPiSeK.Caption = ""
PoPiSeK.Width = Image1.Width - PoPiSeK.Left - 10
PrN.Enabled = False
PrN.Visible = False
GoTo 2
1:
DetError Err.Number, "pixviewer"
GoTo 2
2:
End Sub


Private Sub Form_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
PrN.ForeColor = &HFFFF&
Back.ForeColor = &HFFFF&
Me.MousePointer = vbDefault
End Sub


Private Sub Form_Unload(Cancel As Integer)
ConsoleWrite "PIXVIEWER.uninit"
End Sub


Private Sub Image1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
PrN.ForeColor = &HFFFF&
Back.ForeColor = &HFFFF&
Me.MousePointer = vbDefault
End Sub

Private Sub PoPiSeK_Click()
Dim clx, em, ib As String
clx = GetSetting(appname:="Harley Software", section:="Jooky-Viewer", Key:="Clanek")
em = GetSetting(appname:="Harley Software", section:="Jooky-Viewer", Key:="EditMode")
If em = "1" Then
  ib = InputBox("Zadej popisek k obrázku...", clx)
  PoPiSeK.Caption = ib
  WriteIniFile "ini\main.ini", clx, File1.filename, ib
End If
End Sub

Private Sub PoPiSeK_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Me.MousePointer = vbDefault
End Sub


Private Sub PrN_Click()
PlaySound 11
ConsoleWrite "DEVICEUSE.printer=" & Me.Picture.filename
File1.Visible = False
PrN.Visible = False
Back.Visible = False
PrintForm
Printer.EndDoc
File1.Visible = True
PrN.Visible = True
Back.Visible = True
End Sub


Private Sub Rec_Click()

End Sub


Private Sub PrN_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
PrN.ForeColor = &HC000C0
Back.ForeColor = &HFFFF&
End Sub


