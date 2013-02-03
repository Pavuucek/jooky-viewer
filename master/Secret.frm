VERSION 4.00
Begin VB.Form Sexret 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Tajný Obrázek, pro návrat zmáèknìte X ==>"
   ClientHeight    =   4140
   ClientLeft      =   1140
   ClientTop       =   1515
   ClientWidth     =   6690
   Height          =   4545
   Icon            =   "Secret.frx":0000
   Left            =   1080
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4140
   ScaleWidth      =   6690
   Top             =   1170
   Width           =   6810
   WindowState     =   2  'Maximized
   Begin VB.Image Image1 
      Height          =   855
      Left            =   0
      Stretch         =   -1  'True
      Top             =   0
      Width           =   615
   End
End
Attribute VB_Name = "Sexret"
Attribute VB_Creatable = False
Attribute VB_Exposed = False
Private Sub Form_Activate()
With Image1
.Height = Screen.Height
.Width = Screen.Width
End With
Me.Icon = Main.Icon
End Sub

Private Sub Form_Load()
With Image1
.Height = Screen.Height
.Width = Screen.Width
End With
Me.Icon = Main.Icon
End Sub


Private Sub Form_Unload(Cancel As Integer)
Unload WaitFRM
ConsoleWrite "PIXVIEWER.SecretSection.uninit"
End Sub


