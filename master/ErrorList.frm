VERSION 5.00
Object = "{3B7C8863-D78F-101B-B9B5-04021C009402}#1.2#0"; "RICHTX32.OCX"
Begin VB.Form ErrorList 
   AutoRedraw      =   -1  'True
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   "Seznam chybov�ch ��slel"
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
MsgText = "Seznam 'ERROR�' generovan�ch programem podle ��sla " & Chr(10) & Chr(10)
MsgText = MsgText & " 3 : Pou�it RETURN bez GOSUB" & Chr(10) & " 5 : Chybn� vol�n� proced�ry" & Chr(10) & " 6 : P�ete�en�" & Chr(10) & " 7 : M�lo Pam�ti" & Chr(10) & " 9 : Index mimo rozsah" & Chr(10) & " 11 : Pole je pevn� nebo zamknut�" & Chr(10) & " 13 : Typ Nesouhlas�" & Chr(10) & " 14 : Nedostatek m�sta v �et�zci" & Chr(10) & " 15 : P��li� slo�it� v�raz" & Chr(10) & " 17 : Nelze prov�st" & Chr(10) & " 18 : P�eru�eno u�ivatelem" & Chr(10) & " 20 : Pou�it� RESUME bez chyby" & Chr(10) & " 28 : M�lo m�sta v z�sobn�ku" & Chr(10) & " 35 : Proced�ra, funkce nebo vlastnost neni definov�na" & Chr(10) & " 47 : DLL vyu��v� moc aplikac�" & Chr(10) & " 48 : Chyba p�i na��t�n� DLL" & Chr(10) & " 49 : Chybn� konvence vol�n� knihovny DLL" & Chr(10) & " 51 : Intern� chyba" & Chr(10) & " 52 : �patn� n�zev nebo ��slo souboru" & Chr(10) & " 53 : Soubor Nenalezen" & Chr(10) & " 54 : �patn� Re�im Souboru" & Chr(10) & " 56 : Soubor je u� otev�en" & Chr(10) & " 57 : I/O chyba" & Chr(10)
MsgText = MsgText & " 58 : Soubor u� existuje" & Chr(10) & " 59 : Chybn� d�lka z�znamu" & Chr(10)
MsgText = MsgText & " 61 : Disk je pln�" & Chr(10) & " 62 : Vstup za koncem souboru" & Chr(10) & " 63 : Chybn� ��slo z�znamu" & Chr(10) & " 67 : P��li� soubor�" & Chr(10) & " 68 : Za��zen� nen� dostupn�" & Chr(10) & " 70 : P��stup odm�tnut" & Chr(10) & " 71 : Disk nen� p�ipraven" & Chr(10) & " 74 : Nejde p�esunout na jinou jednotku" & Chr(10) & " 75 : Chyba v p��stupu k souboru" & Chr(10) & " 76 : Cesta nenalezena" & Chr(10) & " 91 : Nen� nastaven� objektov� prom�n� nebo prom�nn� WITH" & Chr(10) & " 92 : Neinicializovan� smy�ka FOR" & Chr(10) & " 93 : Chybn� �et�zec vzorku" & Chr(10) & " 94 : Chybn� pou�it� NULL" & Chr(10) & " 444 : Metoda se ned� pou��t v tomto kontextu" & Chr(10) & " 452 : Chybn� ��slo proced�ry v DLL" & Chr(10) & " 453 : Funkce v DLL nenalezena" & Chr(10) & " 481 : Chybn� Obr�zek" & Chr(10) & " 482 : Chyba Tisk�rny" & Chr(10) & " Jin� ��slo : Nezn�m� Chyba"
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


