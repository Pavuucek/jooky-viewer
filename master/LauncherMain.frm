VERSION 4.00
Begin VB.Form LauncherMain 
   BorderStyle     =   3  'Fixed Dialog
   ClientHeight    =   2835
   ClientLeft      =   2175
   ClientTop       =   2925
   ClientWidth     =   5640
   ControlBox      =   0   'False
   Height          =   3240
   Icon            =   "LauncherMain.frx":0000
   Left            =   2115
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2835
   ScaleWidth      =   5640
   ShowInTaskbar   =   0   'False
   Top             =   2580
   Width           =   5760
   Begin VB.CommandButton Command1 
      Caption         =   "Vytvoøit zástupce"
      Height          =   375
      Left            =   2160
      TabIndex        =   3
      Top             =   1320
      Width           =   1695
   End
   Begin VB.CommandButton Close 
      Caption         =   "Zavøít"
      Height          =   375
      Left            =   2160
      TabIndex        =   2
      Top             =   1800
      Width           =   1695
   End
   Begin VB.CommandButton RunE 
      Caption         =   "Spustit DiskMag"
      Height          =   375
      Left            =   2160
      TabIndex        =   1
      Top             =   840
      Width           =   1695
   End
   Begin VB.Image imgLogo 
      Height          =   2250
      Left            =   120
      MousePointer    =   11  'Hourglass
      Picture         =   "LauncherMain.frx":0442
      Stretch         =   -1  'True
      Top             =   600
      Width           =   2250
   End
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      Caption         =   "DiskMag ENGINE Launcher"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "Comic Sans MS"
         Size            =   20.25
         Charset         =   0
         Weight          =   700
         Underline       =   -1  'True
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   570
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   5385
   End
End
Attribute VB_Name = "LauncherMain"
Attribute VB_Creatable = False
Attribute VB_Exposed = False
Private Sub Close_Click()
End
End Sub

Private Sub Command2_Click()

End Sub


Private Sub Command1_Click()
  CreateShellGroup "DiskMag ENGINE"
  CreateShellLink App.Path & "\engine.exe", "-shortcut", "DiskMag ENGINE"
End Sub


Private Sub Form_Load()
If Not FileExists("jooky00.dll") Then
  Command1.Enabled = False
End If
CenterForm Me
End Sub


Private Sub RunE_Click()
If FileExists(App.Path & "\engine.exe") Then
  Shell (App.Path & "\engine.exe -launcher")
Else
  MsgBox Title:="Launcher", prompt:="Soubor nebyl nalezen, ujistìte se, že Launcher a DiskMag ENGINE jsou ve stejné složce.", Buttons:=vbExclamation
End If
End Sub


