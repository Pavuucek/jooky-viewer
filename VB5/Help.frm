VERSION 5.00
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Begin VB.Form Help 
   BackColor       =   &H00FF0000&
   BorderStyle     =   0  'None
   Caption         =   "Nápovìda"
   ClientHeight    =   4140
   ClientLeft      =   1140
   ClientTop       =   1515
   ClientWidth     =   6690
   ClipControls    =   0   'False
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   NegotiateMenus  =   0   'False
   PaletteMode     =   1  'UseZOrder
   ScaleHeight     =   276
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   446
   ShowInTaskbar   =   0   'False
   WindowState     =   2  'Maximized
   Begin RichTextLib.RichTextBox RichTextBox1 
      Height          =   5895
      Left            =   0
      TabIndex        =   3
      Top             =   120
      Width           =   9615
      _ExtentX        =   16960
      _ExtentY        =   10398
      _Version        =   393217
      BackColor       =   16777215
      HideSelection   =   0   'False
      ReadOnly        =   -1  'True
      ScrollBars      =   2
      MousePointer    =   99
      RightMargin     =   800
      TextRTF         =   $"Help.frx":0000
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
   Begin VB.Label Back4 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "<<< Zpìt"
      BeginProperty Font 
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
      Left            =   3240
      TabIndex        =   2
      Top             =   6120
      Width           =   1230
   End
   Begin VB.Label NFO 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "Informace o programu"
      BeginProperty Font 
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
      Left            =   120
      TabIndex        =   1
      Top             =   6120
      Width           =   2925
   End
   Begin VB.Label CaP 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "!@"
      BeginProperty Font 
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
      TabIndex        =   0
      Top             =   0
      Width           =   390
   End
   Begin VB.Image imgBackGround 
      Height          =   8055
      Left            =   0
      Top             =   0
      Width           =   10575
   End
End
Attribute VB_Name = "Help"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Private Sub Back4_Click()
Unload Me
End Sub


Private Sub Back6_Click(index As Integer)
End Sub


Private Sub Back4_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Back4.ForeColor = &HC000C0
NFO.ForeColor = &HFFFF&
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
  RichTextBox1.Height = 361
  RichTextBox1.Width = 640
  NFO.Top = 368
Case "800x600"
  RichTextBox1.Height = 481
  RichTextBox1.Width = 800
  NFO.Top = 488
Case "1024x768"
  RichTextBox1.Height = 649
  RichTextBox1.Width = 1024
  NFO.Top = 656
End Select
CaP.Caption = Me.Caption
RichTextBox1.Top = CaP.Top + CaP.Height + 5
RichTextBox1.RightMargin = RichTextBox1.Width
Back4.Left = 240
NFO.Left = 8
NFO.Top = NFO.Top + CaP.Height + 2
Back4.Top = NFO.Top
ConsoleWrite "HELP.init"

End Sub

Private Sub Form_Load()
Dim res As String
On Error GoTo 1
WaitFRM.Show
DoEvents
Me.ScaleMode = vbPixels
'Main.Hide
If Screen.Width = 9600 And Screen.Height = 7200 Then res = "640x480"
If Screen.Width = 12000 And Screen.Height = 9000 Then res = "800x600"
If Screen.Width >= 15360 And Screen.Height >= 11520 Then res = "1024x768"

Select Case res
Case "640x480"
  RichTextBox1.Height = 361
  RichTextBox1.Width = 640
  NFO.Top = 368
Case "800x600"
  RichTextBox1.Height = 481
  RichTextBox1.Width = 800
  NFO.Top = 488
Case "1024x768"
  RichTextBox1.Height = 649
  RichTextBox1.Width = 1024
  NFO.Top = 656
End Select
CaP.Caption = Me.Caption
RichTextBox1.Top = CaP.Top + CaP.Height + 5
RichTextBox1.RightMargin = RichTextBox1.Width
Back4.Left = 240
NFO.Left = 8
NFO.Top = NFO.Top + CaP.Height + 2
Back4.Top = NFO.Top
ConsoleWrite "HELP.init"
Me.Icon = Main.Icon
DrawBckGround Me, "Help", True
RichTextBox1.filename = "data\text\help.rtf"
GoTo 2
1:
If Err Then DetError Err.Number, "help"
GoTo 2
2:
Unload WaitFRM
End Sub

Private Sub SysInfo_Click(index As Integer)
Help.Enabled = False
End Sub


Private Sub PrintBTN_Click()
PlaySound 11
Printer.Print RichTextBox1.Text;
End Sub


Private Sub Info_Click()
PlaySound 11
Me.Enabled = False
PRGinF.Show
End Sub


Private Sub Form_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
NFO.ForeColor = &HFFFF&
Back4.ForeColor = &HFFFF&
Me.MousePointer = vbDefault
End Sub

Private Sub Form_Unload(Cancel As Integer)
PlaySound 11
Main.Enabled = True
ConsoleWrite "HELP.uninit"
Main.Show
Me.MousePointer = vbDefault
End Sub


Private Sub Image1_Click()

End Sub

Private Sub imgbackground_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
NFO.ForeColor = &HFFFF&
Back4.ForeColor = &HFFFF&
Me.MousePointer = vbDefault

End Sub


Private Sub NFO_Click()
PlaySound 11
PRGinF.Show
End Sub

Private Sub NFO_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
NFO.ForeColor = &HC000C0
Back4.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub


Private Sub RichTextBox1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
NFO.ForeColor = &HFFFF&
Back4.ForeColor = &HFFFF&
Me.MousePointer = 99
RichTextBox1.MouseIcon = Console.LOGboX.MouseIcon

End Sub


