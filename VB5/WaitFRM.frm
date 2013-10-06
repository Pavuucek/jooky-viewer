VERSION 5.00
Begin VB.Form WaitFRM 
   BorderStyle     =   3  'Fixed Dialog
   ClientHeight    =   765
   ClientLeft      =   585
   ClientTop       =   2340
   ClientWidth     =   4800
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   MousePointer    =   99  'Custom
   PaletteMode     =   1  'UseZOrder
   ScaleHeight     =   765
   ScaleWidth      =   4800
   ShowInTaskbar   =   0   'False
   Begin VB.Label stav 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      BackColor       =   &H00000000&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Loading, please wait ..."
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   21.75
         Charset         =   238
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   555
      Left            =   120
      MousePointer    =   99  'Custom
      TabIndex        =   0
      Top             =   120
      Width           =   4545
   End
End
Attribute VB_Name = "WaitFRM"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Option Explicit
Private Sub Form_Load()
Me.MousePointer = 99
Me.MouseIcon = frmSplash.MouseIcon
CenterForm Me
End Sub


Private Sub Form_Unload(Cancel As Integer)
Me.MousePointer = vbDefault
End Sub


Private Sub stav_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Me.MousePointer = frmSplash.MousePointer
End Sub


