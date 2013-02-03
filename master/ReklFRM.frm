VERSION 4.00
Begin VB.Form ReklFRM 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Reklama"
   ClientHeight    =   4140
   ClientLeft      =   1155
   ClientTop       =   1530
   ClientWidth     =   6690
   ClipControls    =   0   'False
   ControlBox      =   0   'False
   Height          =   4545
   Left            =   1095
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   NegotiateMenus  =   0   'False
   ScaleHeight     =   276
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   446
   Top             =   1185
   Width           =   6810
   WindowState     =   2  'Maximized
   Begin VB.Image Image1 
      Height          =   3855
      Left            =   0
      Stretch         =   -1  'True
      Top             =   0
      Width           =   5055
   End
End
Attribute VB_Name = "ReklFRM"
Attribute VB_Creatable = False
Attribute VB_Exposed = False
Private Sub ContinueX_Click()
End Sub

Private Sub ContinueX_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
ContinueX.ForeColor = &HFFFFFF
ContinueX.BackColor = &HFF0000
End Sub


Private Sub Form_Click()
On Error GoTo 1
If Screen.Width = 9600 And Screen.Height = 7200 Then Re$ = "640x480"
If Screen.Width = 12000 And Screen.Height = 9000 Then Re$ = "800x600"
If Screen.Width >= 15360 And Screen.Height >= 11520 Then Re$ = "1024x768"
Select Case Re$
Case "640x480"
  Image1.Height = 480
  Image1.Width = 640
Case "800x600"
  Image1.Height = 600
  Image1.Width = 800
Case "1024x768"
  Image1.Height = 768
  Image1.Width = 1024
End Select
PlaySound 11
RexX = ReadIniFile("ini\main.ini", "Common", "Last_Reklama")
ReXTE = ReadIniFile("ini\main.ini", "Common", "ReklamaEXT")
If ble <> RexX Then
  WaitFRM.Show
  DoEvents
  ble = ble + 1
  ConsoleWrite "PIXVIEWER.REKLAMA.file=data\pictures\rekl0" & ble & "." & ReXTE
  Image1.Picture = LoadPicture("data\pictures\rekl0" & ble & "." & ReXTE)
  If Err Then DetError Err.Number, "REKLAMA"
  Unload WaitFRM
Else
  PlaySound 13
  ConsoleWrite "Shutdown NOW"
  WriteLOG
  Me.MousePointer = vbDefault
  MsgBox Title:="Už koneènì Konec", prompt:="Ètìte DiskMag ENGINE." & Chr(10) & Chr(10) & "See you next time."
'  DeleteSetting appname:="Harley Software", section:="Jooky-Viewer"
  End
End If
GoTo 2
1:
  DetError Err.Number, "REKLAMA"
  GoTo 2
2:


End Sub

Private Sub Form_Load()
On Error GoTo 1
WaitFRM.Show
DoEvents
If Screen.Width = 9600 And Screen.Height = 7200 Then Re$ = "640x480"
If Screen.Width = 12000 And Screen.Height = 9000 Then Re$ = "800x600"
If Screen.Width >= 15360 And Screen.Height >= 11520 Then Re$ = "1024x768"
Select Case Re$
Case "640x480"
  Image1.Height = 480
  Image1.Width = 640
Case "800x600"
  Image1.Height = 600
  Image1.Width = 800
Case "1024x768"
  Image1.Height = 768
  Image1.Width = 1024
End Select

ble = 0
ConsoleWrite "PIXVIEWER.initREKLAMA"
ConsoleWrite "PIXVIEWER.REKLAMA.LastPix=" & ReadIniFile("ini\main.ini", "Common", "Last_Reklama")
ConsoleWrite "PIXVIEWER.REKLAMA.Extension=" & ReadIniFile("ini\main.ini", "Common", "ReklamaEXT")
ConsoleWrite "PIXVIEWER.REKLAMA.file=data\pictures\rekl00." & ReadIniFile("ini\main.ini", "Common", "ReklamaEXT")
Image1.Picture = LoadPicture("data\pictures\rekl00." & ReadIniFile("ini\main.ini", "Common", "ReklamaEXT"))
GoTo 2
1:
DetError Err.Number, "PIXVIEWER.REKLAMA"
GoTo 2
2:
Unload WaitFRM
End Sub


Private Sub Form_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub

Private Sub Image1_Click()
On Error GoTo 1
PlaySound 11
RexX = ReadIniFile("ini\main.ini", "Common", "Last_Reklama")
ReXTE = ReadIniFile("ini\main.ini", "Common", "ReklamaEXT")
If ble <> RexX Then
  WaitFRM.Show
  DoEvents
  ble = ble + 1
  ConsoleWrite "PIXVIEWER.REKLAMA.file=data\pictures\rekl0" & ble & "." & ReXTE
  Image1.Picture = LoadPicture("data\pictures\rekl0" & ble & "." & ReXTE)
  If Err Then DetError Err.Number, "REKLAMA"
  Unload WaitFRM
Else
  PlaySound 13
  ConsoleWrite "Shutdown NOW"
  WriteLOG
  MsgBox Title:="Už koneènì Konec", prompt:="Ètìte DiskMag ENGINE." & Chr(10) & Chr(10) & "See you next time."
'  DeleteSetting appname:="Harley Software", section:="Jooky-Viewer"
  End
End If
GoTo 2
1:
  DetError Err.Number, "REKLAMA"
  GoTo 2
2:
End Sub

Private Sub Image1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub


