VERSION 4.00
Begin VB.Form WaitFRM 
   BorderStyle     =   3  'Fixed Dialog
   ClientHeight    =   765
   ClientLeft      =   585
   ClientTop       =   2340
   ClientWidth     =   4800
   ControlBox      =   0   'False
   Height          =   1170
   Left            =   525
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   MousePointer    =   99  'Custom
   ScaleHeight     =   765
   ScaleWidth      =   4800
   ShowInTaskbar   =   0   'False
   Top             =   1995
   Width           =   4920
   Begin VB.Label stav 
      Alignment       =   2  'Center
      AutoSize        =   -1  'True
      BackColor       =   &H00000000&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "Loading, please wait ..."
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
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
Attribute VB_Creatable = False
Attribute VB_Exposed = False
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


