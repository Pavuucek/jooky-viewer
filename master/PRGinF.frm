VERSION 4.00
Begin VB.Form PRGinF 
   BackColor       =   &H00FF0000&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Informace o Programu"
   ClientHeight    =   4980
   ClientLeft      =   2340
   ClientTop       =   2265
   ClientWidth     =   4830
   ClipControls    =   0   'False
   ControlBox      =   0   'False
   Height          =   5490
   Left            =   2280
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   NegotiateMenus  =   0   'False
   ScaleHeight     =   4980
   ScaleWidth      =   4830
   Top             =   1815
   Width           =   4950
   Begin VB.Image Image1 
      Height          =   2535
      Left            =   120
      Stretch         =   -1  'True
      Top             =   1800
      Width           =   4335
   End
   Begin VB.Label CloseX 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
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
      Left            =   1800
      TabIndex        =   6
      Top             =   4440
      Width           =   765
   End
   Begin VB.Label Label6 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      Caption         =   "Toto je verze pro WINDOWS 95/98"
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
      Height          =   240
      Left            =   120
      TabIndex        =   5
      Top             =   1440
      Width           =   3615
   End
   Begin VB.Label Label5 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      Caption         =   "e-mail     : MKuncl@POST.CZ"
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
      Height          =   240
      Left            =   120
      TabIndex        =   4
      Top             =   1080
      Width           =   3000
   End
   Begin VB.Label Label4 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      Caption         =   "Adresa   : Smetanova 448, Votice 259 01"
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
      Height          =   240
      Left            =   120
      TabIndex        =   3
      Top             =   720
      Width           =   4155
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      Caption         =   "Firma      : Harley Software ltd."
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
      Height          =   240
      Left            =   120
      TabIndex        =   2
      Top             =   480
      Width           =   3105
   End
   Begin VB.Label Label2 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      Caption         =   "Autor       : Michal Kuncl"
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
      Height          =   240
      Left            =   120
      TabIndex        =   1
      Top             =   240
      Width           =   2385
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      Caption         =   "Program : Jooky-Viewer - DiskMag ENGINE"
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
      Height          =   240
      Left            =   120
      TabIndex        =   0
      Top             =   0
      Width           =   4515
   End
End
Attribute VB_Name = "PRGinF"
Attribute VB_Creatable = False
Attribute VB_Exposed = False

Option Explicit
Private Sub CloseX_Click()
PlaySound 11
ConsoleWrite "ABOUT.uninit"
Unload Me
End Sub

Private Sub CloseX_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
CloseX.ForeColor = &HC000C0
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub


Private Sub Form_Load()
ConsoleWrite "ABOUT.init"
Image1.Picture = List.Icon
CenterForm Me
Me.Icon = Main.Icon
End Sub


Private Sub Form_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
CloseX.ForeColor = &HFFFF&
Me.MousePointer = vbDefault
End Sub


Private Sub Image1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
CloseX.ForeColor = &HFFFF&
Me.MousePointer = vbDefault
End Sub


