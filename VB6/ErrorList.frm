VERSION 5.00
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Begin VB.Form ErrorList 
   AutoRedraw      =   -1  'True
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   "Seznam chybových èíslel"
   ClientHeight    =   4425
   ClientLeft      =   225
   ClientTop       =   780
   ClientWidth     =   6690
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   PaletteMode     =   1  'UseZOrder
   ScaleHeight     =   4425
   ScaleWidth      =   6690
   ShowInTaskbar   =   0   'False
   Begin RichTextLib.RichTextBox RichTextBox1 
      Height          =   4215
      Left            =   0
      TabIndex        =   0
      Top             =   120
      Width           =   6615
      _ExtentX        =   11668
      _ExtentY        =   7435
      _Version        =   393217
      ReadOnly        =   -1  'True
      ScrollBars      =   2
      TextRTF         =   $"ErrorList.frx":0000
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   238
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
   End
End
Attribute VB_Name = "ErrorList"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Form_Load()
Dim MsgText As String
WaitFRM.Show
DoEvents
CenterForm Me
ConsoleWrite "ERRORLIST.init"
Me.Icon = Main.Icon
MsgText = "Seznam 'ERRORù' generovaných programem podle èísla " & Chr(10) & Chr(10)
MsgText = MsgText & " 3 : Použit RETURN bez GOSUB" & Chr(10) & " 5 : Chybné volání procedùry" & Chr(10) & " 6 : Pøeteèení" & Chr(10) & " 7 : Málo Pamìti" & Chr(10) & " 9 : Index mimo rozsah" & Chr(10) & " 11 : Pole je pevné nebo zamknuté" & Chr(10) & " 13 : Typ Nesouhlasí" & Chr(10) & " 14 : Nedostatek místa v øetìzci" & Chr(10) & " 15 : Pøíliš složitý výraz" & Chr(10) & " 17 : Nelze provést" & Chr(10) & " 18 : Pøerušeno uživatelem" & Chr(10) & " 20 : Použití RESUME bez chyby" & Chr(10) & " 28 : Málo místa v zásobníku" & Chr(10) & " 35 : Procedùra, funkce nebo vlastnost neni definována" & Chr(10) & " 47 : DLL využívá moc aplikací" & Chr(10) & " 48 : Chyba pøi naèítání DLL" & Chr(10) & " 49 : Chybná konvence volání knihovny DLL" & Chr(10) & " 51 : Interní chyba" & Chr(10) & " 52 : Špatný název nebo èíslo souboru" & Chr(10) & " 53 : Soubor Nenalezen" & Chr(10) & " 54 : Špatný Režim Souboru" & Chr(10) & " 56 : Soubor je už otevøen" & Chr(10) & " 57 : I/O chyba" & Chr(10)
MsgText = MsgText & " 58 : Soubor už existuje" & Chr(10) & " 59 : Chybná délka záznamu" & Chr(10)
MsgText = MsgText & " 61 : Disk je plný" & Chr(10) & " 62 : Vstup za koncem souboru" & Chr(10) & " 63 : Chybné èíslo záznamu" & Chr(10) & " 67 : Pøíliš souborù" & Chr(10) & " 68 : Zaøízení není dostupné" & Chr(10) & " 70 : Pøístup odmítnut" & Chr(10) & " 71 : Disk není pøipraven" & Chr(10) & " 74 : Nejde pøesunout na jinou jednotku" & Chr(10) & " 75 : Chyba v pøístupu k souboru" & Chr(10) & " 76 : Cesta nenalezena" & Chr(10) & " 91 : Není nastavená objektová promìná nebo promìnná WITH" & Chr(10) & " 92 : Neinicializovaná smyèka FOR" & Chr(10) & " 93 : Chybný øetìzec vzorku" & Chr(10) & " 94 : Chybné použití NULL" & Chr(10) & " 444 : Metoda se nedá použít v tomto kontextu" & Chr(10) & " 452 : Chybné èíslo procedùry v DLL" & Chr(10) & " 453 : Funkce v DLL nenalezena" & Chr(10) & " 481 : Chybný Obrázek" & Chr(10) & " 482 : Chyba Tiskárny" & Chr(10) & " Jiné èíslo : Neznámá Chyba"
RichTextBox1.Text = MsgText
Unload WaitFRM
End Sub


Private Sub Form_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Me.MousePointer = vbDefault
End Sub


Private Sub Form_Unload(Cancel As Integer)
Me.MousePointer = vbDefault
ConsoleWrite "ERRORLIST.uninit"
End Sub


Private Sub RichTextBox1_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
Me.MousePointer = 99
Me.MouseIcon = Console.LOGboX.MouseIcon

End Sub


