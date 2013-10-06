VERSION 5.00
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Object = "{6B7E6392-850A-101B-AFC0-4210102A8DA7}#1.3#0"; "COMCTL32.OCX"
Begin VB.Form TextFRM 
   AutoRedraw      =   -1  'True
   BackColor       =   &H00FF0000&
   BorderStyle     =   0  'None
   Caption         =   "#"
   ClientHeight    =   4125
   ClientLeft      =   1455
   ClientTop       =   1860
   ClientWidth     =   6690
   ControlBox      =   0   'False
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   NegotiateMenus  =   0   'False
   PaletteMode     =   1  'UseZOrder
   ScaleHeight     =   275
   ScaleMode       =   3  'Pixel
   ScaleWidth      =   446
   ShowInTaskbar   =   0   'False
   WindowState     =   2  'Maximized
   Begin VB.ListBox List1 
      BackColor       =   &H00000000&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   238
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FFFFFF&
      Height          =   1260
      Left            =   120
      TabIndex        =   1
      Top             =   4920
      Width           =   3375
   End
   Begin VB.CommandButton Save 
      Caption         =   "Save"
      Height          =   255
      Left            =   2280
      TabIndex        =   0
      Top             =   0
      Width           =   495
   End
   Begin ComctlLib.ProgressBar ProgressBar1 
      Height          =   615
      Left            =   3600
      TabIndex        =   8
      Top             =   5280
      Width           =   4335
      _ExtentX        =   7646
      _ExtentY        =   1085
      _Version        =   327682
      Appearance      =   1
   End
   Begin RichTextLib.RichTextBox RichTextBox1 
      Height          =   4095
      Left            =   0
      TabIndex        =   7
      Top             =   360
      Width           =   3615
      _ExtentX        =   6376
      _ExtentY        =   7223
      _Version        =   393217
      BackColor       =   16777215
      BorderStyle     =   0
      Enabled         =   -1  'True
      HideSelection   =   0   'False
      ReadOnly        =   -1  'True
      ScrollBars      =   3
      MousePointer    =   99
      RightMargin     =   800
      TextRTF         =   $"Txtfrm.frx":0000
      MouseIcon       =   "Txtfrm.frx":0086
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   238
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
   Begin VB.Label Pix 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "&Obrázky"
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
      Left            =   3600
      TabIndex        =   6
      Top             =   4920
      Width           =   1110
   End
   Begin VB.Label PrN 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "&Nový èl."
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
      Left            =   4920
      TabIndex        =   5
      Top             =   4920
      Width           =   1035
   End
   Begin VB.Label Back4 
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
      Left            =   6720
      TabIndex        =   4
      Top             =   4920
      Width           =   1230
   End
   Begin VB.Label Verdiktomer 
      AutoSize        =   -1  'True
      BackColor       =   &H00FF0000&
      BackStyle       =   0  'Transparent
      Caption         =   "Mìøiè Hodnocení"
      BeginProperty Font 
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
      Left            =   3600
      TabIndex        =   3
      Top             =   5880
      Width           =   1770
   End
   Begin VB.Label CaP 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "#"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   15
         Charset         =   238
         Weight          =   700
         Underline       =   -1  'True
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FFFF&
      Height          =   360
      Left            =   240
      TabIndex        =   2
      Top             =   0
      Width           =   165
   End
   Begin VB.Image imgBackGround 
      Height          =   6735
      Left            =   0
      Top             =   0
      Width           =   8775
   End
End
Attribute VB_Name = "TextFRM"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Private Sub Back4_Click()
Dim em, wdw As String
PlaySound 11
em = GetSetting(appname:="Harley Software", section:="Jooky-Viewer", Key:="EditMode")
wdw = GetSetting(appname:="Harley Software", section:="Jooky-Viewer", Key:="Window")
Select Case em
Case "1"
  WriteIniFile "ini\main.ini", "List", "Last" & wdw, List1.ListCount
Case Else
End Select
Unload Me
List.Enabled = True
With List
.Show
.Icon = Main.Icon
End With

End Sub


Private Sub File1_Click()
End Sub



Private Sub Back4_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Back4.ForeColor = &HC000C0
PrN.ForeColor = &HFFFF&
Pix.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub

Private Sub Form_Load()
Dim em, makx, uhc, mohc As String
On Error GoTo 1
DrawBckGround Me, "TextViewer", True
em = GetSetting(appname:="Harley Software", section:="Jooky-Viewer", Key:="EditMode")
ProgressBar1.Value = 0
'mizz = 0
Me.ScaleMode = vbPixels
PrN.Visible = False
Me.Icon = Main.Icon
Select Case DetRes
Case "640x480"
  RichTextBox1.Height = 361 - CaP.Height
  RichTextBox1.Width = 640
  RichTextBox1.RightMargin = RichTextBox1.Width - 40
  List1.Top = 368
Case "800x600"
  RichTextBox1.Height = 481 - CaP.Height
  RichTextBox1.Width = 800
  RichTextBox1.RightMargin = RichTextBox1.Width - 60
  List1.Top = 488
Case "1024x768"
  RichTextBox1.Height = 649 - CaP.Height
  RichTextBox1.Width = 1024
  RichTextBox1.RightMargin = RichTextBox1.Width - 40
  List1.Top = 656
End Select
PrN.Left = 338
Pix.Left = 250
List1.Left = 18
Back4.Left = List1.Left + List1.Width + 181
Back4.Top = List1.Top
PrN.Top = List1.Top
Pix.Top = List1.Top
ProgressBar1.Left = Pix.Left
ProgressBar1.Top = Pix.Top + 24
Verdiktomer.Left = Pix.Left
Verdiktomer.Top = Pix.Top + 64
makx = GetSetting(appname:="Harley Software", section:="Jooky-Viewer", Key:="Window")
ConsoleWrite "TEXTVIEWER.section=" & makx
mohc = ReadIniFile("ini\main.ini", "List", "Last" & makx)
uhc = 0
RichTextBox1.Locked = True
PrN.Visible = False
PrN.Enabled = False
Save.Visible = False
Save.Enabled = False
If em = "1" Then
  RichTextBox1.Locked = False
  PrN.Visible = True
  PrN.Enabled = True
  Save.Visible = True
  Save.Enabled = True
End If
If FileExists("data\text\" & ReadIniFile("ini\main.ini", "Clanky", makx)) Then
  RichTextBox1.filename = "data\text\" & ReadIniFile("ini\main.ini", "Clanky", makx)
  ConsoleWrite "TEXTVIEWER.introfile=" & RichTextBox1.filename
Else
 Err.Raise 53
End If
For uhc = 1 To mohc
  List1.AddItem ReadIniFile("ini\main.ini", makx & uhc, "Name")
Next uhc
GoTo 2
1:
DetError Err.Number, "textviewer"
Unload WaitFRM
Exit Sub
GoTo 2
2:
End Sub

Private Sub GM1_Click()

End Sub


Private Sub PrintBTN_Click()
PlaySound 11
Printer.Print RichTextBox1.Text;
End Sub


Private Sub Form_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Back4.ForeColor = &HFFFF&
PrN.ForeColor = &HFFFF&
Pix.ForeColor = &HFFFF&
Me.MousePointer = vbDefault
End Sub

Private Sub Form_Unload(Cancel As Integer)
List1.Clear
End Sub

Private Sub Image1_Click()

End Sub

Private Sub Label1_Click()

End Sub

Private Sub imgbackground_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Back4.ForeColor = &HFFFF&
PrN.ForeColor = &HFFFF&
Pix.ForeColor = &HFFFF&
Me.MousePointer = vbDefault

End Sub


Private Sub List1_Click()
Dim makz As String
On Error GoTo 1
PlaySound 11
WaitFRM.Show
DoEvents
Fil = List1.List(List1.ListIndex)
ConsoleWrite "TEXTVIEWER.list.#=" & List1.ListIndex
makz = GetSetting(appname:="Harley Software", section:="Jooky-Viewer", Key:="Window")
'ExtractFile "data.jkd", ReadIniFile("ini\main.ini", makz & List1.ListIndex + 1, "File")
If FileExists("data\text\" & ReadIniFile("ini\main.ini", makz & List1.ListIndex + 1, "File")) Then
  RichTextBox1.filename = "data\text\" & ReadIniFile("ini\main.ini", makz & List1.ListIndex + 1, "File")
  Select Case ReadIniFile("ini\main.ini", makz & List1.ListIndex + 1, "Verdikt")
  Case 0 To 11
    ProgressBar1.Value = ReadIniFile("ini\main.ini", makz & List1.ListIndex + 1, "Verdikt")
  Case Else
    ProgressBar1.Value = 0
  End Select
  ConsoleWrite "TEXTVIEWER.file=" & RichTextBox1.filename
Else
Err.Raise 53
End If
Unload WaitFRM
GoTo 2
1:
DetError Err.Number, "textviewer"
Unload WaitFRM
Exit Sub
GoTo 2
2:
End Sub


Private Sub List1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Back4.ForeColor = &HFFFF&
PrN.ForeColor = &HFFFF&
Pix.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub


Private Sub Pix_Click()
Dim makx As String
On Error GoTo 1
PlaySound 11
makx = GetSetting(appname:="Harley Software", section:="Jooky-Viewer", Key:="Window")
If Fil = "" Then
    MsgBox Title:="WARNING !!!", prompt:="Nic si nezvolil"
  Else
    PixFRM.Caption = "Obrázky"
    PixFRM.File1.Path = ReadIniFile("ini\main.ini", makx & List1.ListIndex + 1, "PixPath")
    If Err Then DetError Err.Number, "textviewer/pixviewer"
    SaveSetting appname:="Harley Software", section:="Jooky-Viewer", Key:="Clanek", setting:=makx & List1.ListIndex + 1
    ConsoleWrite "PIXVIEWER.path=" & PixFRM.File1.Path
    Me.Enabled = False
    List.Hide
    PixFRM.Show 'vbmodal
End If
GoTo 2
1:
If Err Then DetError Err.Number, "textviewer/pixviewer"
GoTo 2
2:
End Sub


Private Sub Pix_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Back4.ForeColor = &HFFFF&
PrN.ForeColor = &HFFFF&
Pix.ForeColor = &HC000C0
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub


Private Sub PrN_Click()
Dim wdw, NaM As String
PlaySound 11
wdw = GetSetting(appname:="Harley Software", section:="Jooky-Viewer", Key:="Window")
NaM = InputBox("Zadej jméno nového èlánku v sekci " & wdw & ".", wdw)
WriteIniFile "ini\main.ini", wdw & List1.ListCount + 1, "Name", NaM
WriteIniFile "ini\main.ini", wdw & List1.ListCount + 1, "File", InputBox("Zadej jméno souboru, do kterého uložit èlánek. (i s pøíponou)", wdw)
WriteIniFile "ini\main.ini", wdw & List1.ListCount + 1, "Verdikt", InputBox("Zadej hodnocení pøíslušného èlánku. Od 0 do 11. Pokud èlánek nemá hodnocení, zadejte nulu.", wdw)
If Not FileExists("data\text\" & ReadIniFile("ini\main.ini", wdw & List1.ListCount + 1, "File")) Then
  Open "data\text\" & ReadIniFile("ini\main.ini", wdw & List1.ListCount + 1, "File") For Random As #1
  Close #1
End If
List1.AddItem NaM
RichTextBox1.filename = "data\text\" & ReadIniFile("ini\main.ini", wdw & List1.ListCount + 1, "File")
RichTextBox1.SetFocus
End Sub

Private Sub PrN_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Back4.ForeColor = &HFFFF&
PrN.ForeColor = &HC000C0
Pix.ForeColor = &HFFFF&
Me.MousePointer = 99
Me.MouseIcon = Main.XitBTN.MouseIcon

End Sub


Private Sub progressbar1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Me.MousePointer = vbDefault
End Sub


Private Sub RichTextBox1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Back4.ForeColor = &HFFFF&
PrN.ForeColor = &HFFFF&
Pix.ForeColor = &HFFFF&
Me.MousePointer = 99
RichTextBox1.MouseIcon = Console.LOGboX.MouseIcon

End Sub


Private Sub Save_Click()
Open RichTextBox1.filename For Output As #1
Print #1, RichTextBox1.TextRTF
Close #1
End Sub


Private Sub Verdiktomer_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Me.MousePointer = vbDefault
End Sub


