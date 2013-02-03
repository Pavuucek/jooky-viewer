VERSION 4.00
Begin VB.Form PCGames 
   BackColor       =   &H00FF0000&
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   "PC Games"
   ClientHeight    =   2565
   ClientLeft      =   2460
   ClientTop       =   2685
   ClientWidth     =   1725
   ClipControls    =   0   'False
   ForeColor       =   &H00FF0000&
   Height          =   3075
   Left            =   2400
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   NegotiateMenus  =   0   'False
   ScaleHeight     =   2565
   ScaleWidth      =   1725
   ShowInTaskbar   =   0   'False
   Top             =   2235
   Width           =   1845
   Begin VB.Label Rec 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "&Recenze"
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
      Left            =   240
      TabIndex        =   4
      Top             =   0
      Width           =   1140
   End
   Begin VB.Label Newz 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "N&ovinky"
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
      Left            =   240
      TabIndex        =   3
      Top             =   480
      Width           =   1005
   End
   Begin VB.Label Nav 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "&Návody"
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
      Left            =   240
      TabIndex        =   2
      Top             =   960
      Width           =   975
   End
   Begin VB.Label Cheatz 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "&Cheaty"
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
      Left            =   240
      TabIndex        =   1
      Top             =   1440
      Width           =   930
   End
   Begin VB.Label Back3 
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
      Left            =   120
      TabIndex        =   0
      Top             =   2040
      Width           =   1230
   End
   Begin VB.Image imgBackGround 
      Height          =   3015
      Left            =   0
      Top             =   0
      Width           =   2415
   End
End
Attribute VB_Name = "PCGames"
Attribute VB_Creatable = False
Attribute VB_Exposed = False
Option Explicit
Private Sub Back3_Click()
Unload Me
End Sub


Private Sub Back3_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
 
Rec.ForeColor = &HFFFF&
Cheatz.ForeColor = &HFFFF&
Back3.ForeColor = &HC000C0
Nav.ForeColor = &HFFFF&
Newz.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub


Private Sub Cheatz_Click()
PlaySound 11
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Window", setting:="Cheaty"
TextFRM.CaP.Caption = "PC Games - Cheaty"

Unload Me
TextFRM.Show 'vbmodal
End Sub


Private Sub Cheatz_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
 
Rec.ForeColor = &HFFFF&
Cheatz.ForeColor = &HC000C0
Back3.ForeColor = &HFFFF&
Nav.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon
Newz.ForeColor = &HFFFF&
End Sub


Private Sub Form_Load()
Me.Icon = Main.Icon
Me.Top = List.Top
Me.Left = List.Left - Me.Width - 10
DrawBckGround Me, "PCGames"
End Sub

Private Sub Form_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Rec.ForeColor = &HFFFF&
Cheatz.ForeColor = &HFFFF&
Back3.ForeColor = &HFFFF&
Nav.ForeColor = &HFFFF&
Newz.ForeColor = &HFFFF&
Me.MousePointer = vbDefault
End Sub


Private Sub Form_Unload(Cancel As Integer)
PlaySound 11
List.Enabled = True
List.Visible = True
List.Show
End Sub

Private Sub Image1_Click()

End Sub

Private Sub imgbackground_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Rec.ForeColor = &HFFFF&
Cheatz.ForeColor = &HFFFF&
Back3.ForeColor = &HFFFF&
Nav.ForeColor = &HFFFF&
Newz.ForeColor = &HFFFF&
Me.MousePointer = vbDefault

End Sub


Private Sub Nav_Click()
PlaySound 11
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Window", setting:="Navody"
TextFRM.CaP.Caption = "PC Games - Návody"
TextFRM.Pix.Enabled = True
Unload Me
TextFRM.Show 'vbmodal
End Sub


Private Sub Nav_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
 
Rec.ForeColor = &HFFFF&
Cheatz.ForeColor = &HFFFF&
Back3.ForeColor = &HFFFF&
Nav.ForeColor = &HC000C0
Newz.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub


Private Sub Newz_Click()
PlaySound 11
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Window", setting:="Novinky"
TextFRM.CaP.Caption = "PC Games - Novinky"
Unload Me
TextFRM.Show 'vbmodal
End Sub


Private Sub Newz_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
 
Rec.ForeColor = &HFFFF&
Cheatz.ForeColor = &HFFFF&
Back3.ForeColor = &HFFFF&
Nav.ForeColor = &HFFFF&
Newz.ForeColor = &HC000C0
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub


Private Sub Rec_Click()
PlaySound 11
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Window", setting:="Recenze"
TextFRM.CaP.Caption = "PC Games - Recenze"
Unload Me
TextFRM.Show 'vbmodal
End Sub


Private Sub Uvodnik_Click()

End Sub


Private Sub Rec_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
 
Rec.ForeColor = &HC000C0
Cheatz.ForeColor = &HFFFF&
Back3.ForeColor = &HFFFF&
Nav.ForeColor = &HFFFF&
Newz.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub

Private Sub Timer1_Timer()
Me.Height = Me.Height + 100
Me.Width = Me.Width + 100
If Me.Height >= 2800 Then
  Me.Height = 2850
End If
If Me.Width >= 1600 Then
  Me.Height = 2850
  Me.Width = 1680
  Timer2.Enabled = False
  Timer1.Enabled = False
End If
End Sub


Private Sub Timer2_Timer()
Me.Height = Me.Height - 100
Me.Width = Me.Width - 100
If Me.Height <= 410 And Me.Width <= 700 Then
  Me.Height = 10
  Me.Width = 10
  Unload Me
  Timer1.Enabled = False
  Timer2.Enabled = False
End If
End Sub


