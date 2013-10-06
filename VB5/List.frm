VERSION 5.00
Begin VB.Form List 
   BackColor       =   &H00FF0000&
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   "Obsah tohoto èísla"
   ClientHeight    =   4320
   ClientLeft      =   1890
   ClientTop       =   1005
   ClientWidth     =   5535
   ClipControls    =   0   'False
   ForeColor       =   &H00FF00FF&
   Icon            =   "List.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   NegotiateMenus  =   0   'False
   PaletteMode     =   1  'UseZOrder
   ScaleHeight     =   288
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   369
   ShowInTaskbar   =   0   'False
   Begin VB.Label Uvodnik 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "Ú&vodník"
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
      Left            =   240
      TabIndex        =   15
      Top             =   120
      Width           =   1065
   End
   Begin VB.Label PCGamez 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "&PC Games"
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
      Left            =   240
      TabIndex        =   14
      Top             =   600
      Width           =   1455
   End
   Begin VB.Label Soft 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "&Software"
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
      Left            =   240
      TabIndex        =   13
      Top             =   1080
      Width           =   1200
   End
   Begin VB.Label Reda 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "&Redakce"
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
      Left            =   240
      TabIndex        =   12
      Top             =   1560
      Width           =   1170
   End
   Begin VB.Label CD 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "Obsah CD"
      Enabled         =   0   'False
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
      Left            =   4200
      TabIndex        =   11
      Top             =   3840
      Width           =   1380
   End
   Begin VB.Label Ankh 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "&Anketa"
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
      Left            =   240
      TabIndex        =   10
      Top             =   2040
      Width           =   915
   End
   Begin VB.Label Inet 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "Pøipojit se k &WWW"
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
      Left            =   240
      TabIndex        =   9
      Top             =   2520
      Width           =   2490
   End
   Begin VB.Label Letterz 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "&Dopisy"
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
      Left            =   3840
      TabIndex        =   8
      Top             =   3000
      Width           =   900
   End
   Begin VB.Label Future 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "Pohled do &Budoucna"
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
      Left            =   240
      TabIndex        =   7
      Top             =   3000
      Width           =   2700
   End
   Begin VB.Label Moviez 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "&Filmy + TV"
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
      Left            =   3840
      TabIndex        =   6
      Top             =   120
      Width           =   1425
   End
   Begin VB.Label Learn 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "&Výuka"
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
      Left            =   3840
      TabIndex        =   5
      Top             =   600
      Width           =   810
   End
   Begin VB.Label Mjuzik 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "&Muzika"
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
      Left            =   3840
      TabIndex        =   4
      Top             =   1080
      Width           =   915
   End
   Begin VB.Label Inz 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "&Inzerce"
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
      Left            =   3840
      TabIndex        =   3
      Top             =   1560
      Width           =   960
   End
   Begin VB.Label Ruzne 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "Rùz&né"
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
      Left            =   3840
      TabIndex        =   2
      Top             =   2040
      Width           =   810
   End
   Begin VB.Label Bux 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "&Literatùra"
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
      Left            =   3840
      TabIndex        =   1
      Top             =   2520
      Width           =   1260
   End
   Begin VB.Label Back 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "<<< &Zpìt"
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
      Left            =   240
      TabIndex        =   0
      Top             =   3720
      Width           =   1230
   End
   Begin VB.Image imgBackGround 
      Height          =   5175
      Left            =   0
      Top             =   0
      Width           =   6375
   End
End
Attribute VB_Name = "List"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Private Sub MoveFocus(ByVal bTn As Label, ByVal iMg As Image)
With iMg
.Left = bTn.Left
.Top = bTn.Top
.Height = bTn.Height
.Width = bTn.Width
End With
End Sub

Private Sub Ankh_Click()
PlaySound 11
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Window", setting:="Anketa"
TextFRM.Pix.Enabled = True
TextFRM.CaP.Caption = "Anketa"
Unload Me
TextFRM.Show 'vbmodal
End Sub

Private Sub Ankh_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
 
Uvodnik.ForeColor = &HFFFF&
PCGamez.ForeColor = &HFFFF&
Soft.ForeColor = &HFFFF&
Reda.ForeColor = &HFFFF&
CD.ForeColor = &HFFFF&
Ankh.ForeColor = &HC000C0
Inet.ForeColor = &HFFFF&
Moviez.ForeColor = &HFFFF&
Learn.ForeColor = &HFFFF&
Mjuzik.ForeColor = &HFFFF&
Inz.ForeColor = &HFFFF&
Ruzne.ForeColor = &HFFFF&
Letterz.ForeColor = &HFFFF&
Future.ForeColor = &HFFFF&
Back.ForeColor = &HFFFF&
Bux.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub


Private Sub back_Click()
Unload Me
End Sub

Private Sub Bublinx_Click()
PlaySound 11
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Window", setting:="0"
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Window", setting:="Bublinky"
TextFRM.Pix.Enabled = True
TextFRM.Caption = "Bublinky"
Unload Me
TextFRM.Show
End Sub


Private Sub Back_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
 
Uvodnik.ForeColor = &HFFFF&
PCGamez.ForeColor = &HFFFF&
Soft.ForeColor = &HFFFF&
Reda.ForeColor = &HFFFF&
CD.ForeColor = &HFFFF&
Ankh.ForeColor = &HFFFF&
Inet.ForeColor = &HFFFF&
Moviez.ForeColor = &HFFFF&
Learn.ForeColor = &HFFFF&
Mjuzik.ForeColor = &HFFFF&
Inz.ForeColor = &HFFFF&
Ruzne.ForeColor = &HFFFF&
Letterz.ForeColor = &HFFFF&
Future.ForeColor = &HFFFF&
Back.ForeColor = &HC000C0
Bux.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub

Private Sub Bux_Click()
PlaySound 11
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Window", setting:="Knihy"
TextFRM.Pix.Enabled = True
TextFRM.CaP.Caption = "Literatùra"
Unload Me
TextFRM.Show 'vbmodal
End Sub

Private Sub Bux_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
 
Uvodnik.ForeColor = &HFFFF&
PCGamez.ForeColor = &HFFFF&
Soft.ForeColor = &HFFFF&
Reda.ForeColor = &HFFFF&
CD.ForeColor = &HFFFF&
Ankh.ForeColor = &HFFFF&
Inet.ForeColor = &HFFFF&
Moviez.ForeColor = &HFFFF&
Learn.ForeColor = &HFFFF&
Mjuzik.ForeColor = &HFFFF&
Inz.ForeColor = &HFFFF&
Ruzne.ForeColor = &HFFFF&
Letterz.ForeColor = &HFFFF&
Future.ForeColor = &HFFFF&
Back.ForeColor = &HFFFF&
Bux.ForeColor = &HC000C0
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub


Private Sub CD_Click()
PlaySound 11
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Window", setting:="CD"
TextFRM.Pix.Enabled = True
TextFRM.CaP.Caption = "Obsah CD"
Unload Me
TextFRM.Show
End Sub

Private Sub Command1_Click()
back_Click
End Sub

Private Sub CD_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
 
Uvodnik.ForeColor = &HFFFF&
PCGamez.ForeColor = &HFFFF&
Soft.ForeColor = &HFFFF&
Reda.ForeColor = &HFFFF&
CD.ForeColor = &HC000C0
Ankh.ForeColor = &HFFFF&
Inet.ForeColor = &HFFFF&
Moviez.ForeColor = &HFFFF&
Learn.ForeColor = &HFFFF&
Mjuzik.ForeColor = &HFFFF&
Inz.ForeColor = &HFFFF&
Ruzne.ForeColor = &HFFFF&
Letterz.ForeColor = &HFFFF&
Future.ForeColor = &HFFFF&
Back.ForeColor = &HFFFF&
Bux.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub

Private Sub Form_Load()
CenterForm Me
DrawBckGround Me, "List"
ConsoleWrite "LIST.init"
CD.Enabled = False
CD.Visible = False
Me.MousePointer = vbDefault
End Sub

Private Sub Form_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Uvodnik.ForeColor = &HFFFF&
PCGamez.ForeColor = &HFFFF&
Soft.ForeColor = &HFFFF&
Reda.ForeColor = &HFFFF&
CD.ForeColor = &HFFFF&
Ankh.ForeColor = &HFFFF&
Inet.ForeColor = &HFFFF&
Moviez.ForeColor = &HFFFF&
Learn.ForeColor = &HFFFF&
Mjuzik.ForeColor = &HFFFF&
Inz.ForeColor = &HFFFF&
Ruzne.ForeColor = &HFFFF&
Letterz.ForeColor = &HFFFF&
Future.ForeColor = &HFFFF&
Back.ForeColor = &HFFFF&
Bux.ForeColor = &HFFFF&
Me.MousePointer = vbDefault
End Sub


Private Sub Form_Unload(Cancel As Integer)
PlaySound 11
ConsoleWrite "LIST.uninit"
Main.Show
Main.Enabled = True
End Sub

Private Sub Future_Click()
PlaySound 11
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Window", setting:="Budoucno"
TextFRM.Pix.Enabled = True
TextFRM.CaP.Caption = "Pohled do Budoucna"
Unload Me
TextFRM.Show 'vbmodal
End Sub

Private Sub Future_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
 
Uvodnik.ForeColor = &HFFFF&
PCGamez.ForeColor = &HFFFF&
Soft.ForeColor = &HFFFF&
Reda.ForeColor = &HFFFF&
CD.ForeColor = &HFFFF&
Ankh.ForeColor = &HFFFF&
Inet.ForeColor = &HFFFF&
Moviez.ForeColor = &HFFFF&
Learn.ForeColor = &HFFFF&
Mjuzik.ForeColor = &HFFFF&
Inz.ForeColor = &HFFFF&
Ruzne.ForeColor = &HFFFF&
Letterz.ForeColor = &HFFFF&
Future.ForeColor = &HC000C0
Back.ForeColor = &HFFFF&
Bux.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub


Private Sub Image1_Click()

End Sub

Private Sub Image1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)

End Sub


Private Sub imgbackground_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Uvodnik.ForeColor = &HFFFF&
PCGamez.ForeColor = &HFFFF&
Soft.ForeColor = &HFFFF&
Reda.ForeColor = &HFFFF&
CD.ForeColor = &HFFFF&
Ankh.ForeColor = &HFFFF&
Inet.ForeColor = &HFFFF&
Moviez.ForeColor = &HFFFF&
Learn.ForeColor = &HFFFF&
Mjuzik.ForeColor = &HFFFF&
Inz.ForeColor = &HFFFF&
Ruzne.ForeColor = &HFFFF&
Letterz.ForeColor = &HFFFF&
Future.ForeColor = &HFFFF&
Back.ForeColor = &HFFFF&
Bux.ForeColor = &HFFFF&
Me.MousePointer = vbDefault

End Sub


Private Sub Inet_Click()
PlaySound 11
If GetSetting(appname:="Harley Software", section:="Jooky-Viewer", Key:="EditMode") = "1" Then
  WriteIniFile "ini\main.ini", "Common", "WWW", UCase(InputBox("Zadej adresu k Internetovému Serveru." & Chr(10) & "(napø. http://www.mujweb.cz/www/engine", "Editace URL Adresy)"))
Else
  WWWconnect
End If
End Sub

Private Sub Inet_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
 
Uvodnik.ForeColor = &HFFFF&
PCGamez.ForeColor = &HFFFF&
Soft.ForeColor = &HFFFF&
Reda.ForeColor = &HFFFF&
CD.ForeColor = &HFFFF&
Ankh.ForeColor = &HFFFF&
Inet.ForeColor = &HC000C0
Moviez.ForeColor = &HFFFF&
Learn.ForeColor = &HFFFF&
Mjuzik.ForeColor = &HFFFF&
Inz.ForeColor = &HFFFF&
Ruzne.ForeColor = &HFFFF&
Letterz.ForeColor = &HFFFF&
Future.ForeColor = &HFFFF&
Back.ForeColor = &HFFFF&
Bux.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub


Private Sub Inz_Click()
PlaySound 11
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Window", setting:="Inzerce"
TextFRM.Pix.Enabled = True
TextFRM.CaP.Caption = "Inzerce"
Unload Me
TextFRM.Show 'vbmodal
End Sub

Private Sub Label1_Click()

End Sub

Private Sub Inz_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
 
Uvodnik.ForeColor = &HFFFF&
PCGamez.ForeColor = &HFFFF&
Soft.ForeColor = &HFFFF&
Reda.ForeColor = &HFFFF&
CD.ForeColor = &HFFFF&
Ankh.ForeColor = &HFFFF&
Inet.ForeColor = &HFFFF&
Moviez.ForeColor = &HFFFF&
Learn.ForeColor = &HFFFF&
Mjuzik.ForeColor = &HFFFF&
Inz.ForeColor = &HC000C0
Ruzne.ForeColor = &HFFFF&
Letterz.ForeColor = &HFFFF&
Future.ForeColor = &HFFFF&
Back.ForeColor = &HFFFF&
Bux.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub

Private Sub Learn_Click()
PlaySound 11
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Window", setting:="Vyuka"
TextFRM.Pix.Enabled = True
TextFRM.CaP.Caption = "Výuka"
Unload Me
TextFRM.Show 'vbmodal
End Sub

Private Sub Learn_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
 
Uvodnik.ForeColor = &HFFFF&
PCGamez.ForeColor = &HFFFF&
Soft.ForeColor = &HFFFF&
Reda.ForeColor = &HFFFF&
CD.ForeColor = &HFFFF&
Ankh.ForeColor = &HFFFF&
Inet.ForeColor = &HFFFF&
Moviez.ForeColor = &HFFFF&
Learn.ForeColor = &HC000C0
Mjuzik.ForeColor = &HFFFF&
Inz.ForeColor = &HFFFF&
Ruzne.ForeColor = &HFFFF&
Letterz.ForeColor = &HFFFF&
Future.ForeColor = &HFFFF&
Back.ForeColor = &HFFFF&
Bux.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub


Private Sub Letterz_Click()
PlaySound 11
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Window", setting:="Dopisy"
TextFRM.Pix.Enabled = True
TextFRM.CaP.Caption = "Dopisy"
Unload Me
TextFRM.Show 'vbmodal
End Sub

Private Sub Letterz_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
 
Uvodnik.ForeColor = &HFFFF&
PCGamez.ForeColor = &HFFFF&
Soft.ForeColor = &HFFFF&
Reda.ForeColor = &HFFFF&
CD.ForeColor = &HFFFF&
Ankh.ForeColor = &HFFFF&
Inet.ForeColor = &HFFFF&
Moviez.ForeColor = &HFFFF&
Learn.ForeColor = &HFFFF&
Mjuzik.ForeColor = &HFFFF&
Inz.ForeColor = &HFFFF&
Ruzne.ForeColor = &HFFFF&
Letterz.ForeColor = &HC000C0
Future.ForeColor = &HFFFF&
Back.ForeColor = &HFFFF&
Bux.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub


Private Sub Mjuzik_Click()
PlaySound 11
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Window", setting:="Muzika"
TextFRM.Pix.Enabled = True
TextFRM.CaP.Caption = "Muzika"
Unload Me
TextFRM.Show 'vbmodal
End Sub

Private Sub Msg_Click()
PlaySound 11
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Window", setting:="0"
TextFRM.List1.Clear
TextFRM.Pix.Enabled = True
TextFRM.RichTextBox1.filename = "data\text\messages.rtf"
TextFRM.Caption = "Vzkazy"
Unload Me
TextFRM.Show
End Sub

Private Sub NFO_Click()
PlaySound 11
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Window", setting:="Informace"
TextFRM.Pix.Enabled = True
TextFRM.Caption = "Informace"
Unload Me
TextFRM.Show
End Sub

Private Sub Mjuzik_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
 
Uvodnik.ForeColor = &HFFFF&
PCGamez.ForeColor = &HFFFF&
Soft.ForeColor = &HFFFF&
Reda.ForeColor = &HFFFF&
CD.ForeColor = &HFFFF&
Ankh.ForeColor = &HFFFF&
Inet.ForeColor = &HFFFF&
Moviez.ForeColor = &HFFFF&
Learn.ForeColor = &HFFFF&
Mjuzik.ForeColor = &HC000C0
Inz.ForeColor = &HFFFF&
Ruzne.ForeColor = &HFFFF&
Letterz.ForeColor = &HFFFF&
Future.ForeColor = &HFFFF&
Back.ForeColor = &HFFFF&
Bux.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub

Private Sub Moviez_Click()
PlaySound 11
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Window", setting:="Filmy"
TextFRM.Pix.Enabled = True
TextFRM.CaP.Caption = "Filmy"
Unload Me
TextFRM.Show 'vbmodal

End Sub

Private Sub Music_Click()

End Sub

Private Sub Moviez_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
 
Uvodnik.ForeColor = &HFFFF&
PCGamez.ForeColor = &HFFFF&
Soft.ForeColor = &HFFFF&
Reda.ForeColor = &HFFFF&
CD.ForeColor = &HFFFF&
Ankh.ForeColor = &HFFFF&
Inet.ForeColor = &HFFFF&
Moviez.ForeColor = &HC000C0
Learn.ForeColor = &HFFFF&
Mjuzik.ForeColor = &HFFFF&
Inz.ForeColor = &HFFFF&
Ruzne.ForeColor = &HFFFF&
Letterz.ForeColor = &HFFFF&
Future.ForeColor = &HFFFF&
Back.ForeColor = &HFFFF&
Bux.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub

Private Sub PCGamez_Click()
PlaySound 11

PCGames.Show 'vbmodal
End Sub


Private Sub PCGamez_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
 
Uvodnik.ForeColor = &HFFFF&
Soft.ForeColor = &HFFFF&
Reda.ForeColor = &HFFFF&
CD.ForeColor = &HFFFF&
Ankh.ForeColor = &HFFFF&
Inet.ForeColor = &HFFFF&
PCGamez.ForeColor = &HC000C0
Moviez.ForeColor = &HFFFF&
Learn.ForeColor = &HFFFF&
Mjuzik.ForeColor = &HFFFF&
Inz.ForeColor = &HFFFF&
Ruzne.ForeColor = &HFFFF&
Letterz.ForeColor = &HFFFF&
Future.ForeColor = &HFFFF&
Back.ForeColor = &HFFFF&
Bux.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub


Private Sub Reda_Click()
PlaySound 11
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Window", setting:="Redakce"
TextFRM.Pix.Enabled = True
TextFRM.CaP.Caption = "Redakce"
Unload Me
TextFRM.Show 'vbmodal
End Sub

Private Sub Reklama_Click()
 
MsgBox Title:="Reklama", prompt:="Reklama se pøesunula, je tam, kde jí mají i jiné DiskMagy (zobrazuje se pøed ukonèením)."
End Sub


Private Sub Reda_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
 
Uvodnik.ForeColor = &HFFFF&
PCGamez.ForeColor = &HFFFF&
Soft.ForeColor = &HFFFF&
Reda.ForeColor = &HC000C0
CD.ForeColor = &HFFFF&
Ankh.ForeColor = &HFFFF&
Inet.ForeColor = &HFFFF&
Moviez.ForeColor = &HFFFF&
Learn.ForeColor = &HFFFF&
Mjuzik.ForeColor = &HFFFF&
Inz.ForeColor = &HFFFF&
Ruzne.ForeColor = &HFFFF&
Letterz.ForeColor = &HFFFF&
Future.ForeColor = &HFFFF&
Back.ForeColor = &HFFFF&
Bux.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub

Private Sub Ruzne_Click()
PlaySound 11
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Window", setting:="Ruzne"
TextFRM.Pix.Enabled = True
TextFRM.CaP.Caption = "Rùzné"
Unload Me
TextFRM.Show 'vbmodal

End Sub

Private Sub Ruzne_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
 
Uvodnik.ForeColor = &HFFFF&
PCGamez.ForeColor = &HFFFF&
Soft.ForeColor = &HFFFF&
Reda.ForeColor = &HFFFF&
CD.ForeColor = &HFFFF&
Ankh.ForeColor = &HFFFF&
Inet.ForeColor = &HFFFF&
Moviez.ForeColor = &HFFFF&
Learn.ForeColor = &HFFFF&
Mjuzik.ForeColor = &HFFFF&
Inz.ForeColor = &HFFFF&
Ruzne.ForeColor = &HC000C0
Letterz.ForeColor = &HFFFF&
Future.ForeColor = &HFFFF&
Back.ForeColor = &HFFFF&
Bux.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub


Private Sub Soft_Click()
PlaySound 11
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Window", setting:="Software"
TextFRM.Pix.Enabled = True
TextFRM.CaP.Caption = "Software"
Unload Me
TextFRM.Show 'vbmodal
End Sub

Private Sub Soft_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
 
Uvodnik.ForeColor = &HFFFF&
PCGamez.ForeColor = &HFFFF&
Soft.ForeColor = &HC000C0
Reda.ForeColor = &HFFFF&
CD.ForeColor = &HFFFF&
Ankh.ForeColor = &HFFFF&
Inet.ForeColor = &HFFFF&
Moviez.ForeColor = &HFFFF&
Learn.ForeColor = &HFFFF&
Mjuzik.ForeColor = &HFFFF&
Inz.ForeColor = &HFFFF&
Ruzne.ForeColor = &HFFFF&
Letterz.ForeColor = &HFFFF&
Future.ForeColor = &HFFFF&
Back.ForeColor = &HFFFF&
Bux.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub




Private Sub Uvodnik_Click()
PlaySound 11
SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Window", setting:="Uvodnik"
TextFRM.Pix.Enabled = True
TextFRM.CaP.Caption = "Úvodník"
Unload Me
TextFRM.Show 'vbmodal
End Sub


Private Sub Uvodnik_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon
Uvodnik.ForeColor = &HC000C0
PCGamez.ForeColor = &HFFFF&
Soft.ForeColor = &HFFFF&
Reda.ForeColor = &HFFFF&
CD.ForeColor = &HFFFF&
Ankh.ForeColor = &HFFFF&
Inet.ForeColor = &HFFFF&
Moviez.ForeColor = &HFFFF&
Learn.ForeColor = &HFFFF&
Mjuzik.ForeColor = &HFFFF&
Inz.ForeColor = &HFFFF&
Ruzne.ForeColor = &HFFFF&
Letterz.ForeColor = &HFFFF&
Future.ForeColor = &HFFFF&
Back.ForeColor = &HFFFF&
Bux.ForeColor = &HFFFF&
End Sub


