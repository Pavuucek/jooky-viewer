Option Strict Off
Option Explicit On
Friend Class ErrorList
	Inherits System.Windows.Forms.Form
	
	Private Sub ErrorList_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim MsgText As String
		WaitFRM.Show()
		System.Windows.Forms.Application.DoEvents()
		CenterForm(Me)
		ConsoleWrite("ERRORLIST.init")
		Me.Icon = Main_Renamed.Icon
		MsgText = "Seznam 'ERROR�' generovan�ch programem podle ��sla " & Chr(10) & Chr(10)
		MsgText = MsgText & " 3 : Pou�it RETURN bez GOSUB" & Chr(10) & " 5 : Chybn� vol�n� proced�ry" & Chr(10) & " 6 : P�ete�en�" & Chr(10) & " 7 : M�lo Pam�ti" & Chr(10) & " 9 : Index mimo rozsah" & Chr(10) & " 11 : Pole je pevn� nebo zamknut�" & Chr(10) & " 13 : Typ Nesouhlas�" & Chr(10) & " 14 : Nedostatek m�sta v �et�zci" & Chr(10) & " 15 : P��li� slo�it� v�raz" & Chr(10) & " 17 : Nelze prov�st" & Chr(10) & " 18 : P�eru�eno u�ivatelem" & Chr(10) & " 20 : Pou�it� RESUME bez chyby" & Chr(10) & " 28 : M�lo m�sta v z�sobn�ku" & Chr(10) & " 35 : Proced�ra, funkce nebo vlastnost neni definov�na" & Chr(10) & " 47 : DLL vyu��v� moc aplikac�" & Chr(10) & " 48 : Chyba p�i na��t�n� DLL" & Chr(10) & " 49 : Chybn� konvence vol�n� knihovny DLL" & Chr(10) & " 51 : Intern� chyba" & Chr(10) & " 52 : �patn� n�zev nebo ��slo souboru" & Chr(10) & " 53 : Soubor Nenalezen" & Chr(10) & " 54 : �patn� Re�im Souboru" & Chr(10) & " 56 : Soubor je u� otev�en" & Chr(10) & " 57 : I/O chyba" & Chr(10)
		MsgText = MsgText & " 58 : Soubor u� existuje" & Chr(10) & " 59 : Chybn� d�lka z�znamu" & Chr(10)
		MsgText = MsgText & " 61 : Disk je pln�" & Chr(10) & " 62 : Vstup za koncem souboru" & Chr(10) & " 63 : Chybn� ��slo z�znamu" & Chr(10) & " 67 : P��li� soubor�" & Chr(10) & " 68 : Za��zen� nen� dostupn�" & Chr(10) & " 70 : P��stup odm�tnut" & Chr(10) & " 71 : Disk nen� p�ipraven" & Chr(10) & " 74 : Nejde p�esunout na jinou jednotku" & Chr(10) & " 75 : Chyba v p��stupu k souboru" & Chr(10) & " 76 : Cesta nenalezena" & Chr(10) & " 91 : Nen� nastaven� objektov� prom�n� nebo prom�nn� WITH" & Chr(10) & " 92 : Neinicializovan� smy�ka FOR" & Chr(10) & " 93 : Chybn� �et�zec vzorku" & Chr(10) & " 94 : Chybn� pou�it� NULL" & Chr(10) & " 444 : Metoda se ned� pou��t v tomto kontextu" & Chr(10) & " 452 : Chybn� ��slo proced�ry v DLL" & Chr(10) & " 453 : Funkce v DLL nenalezena" & Chr(10) & " 481 : Chybn� Obr�zek" & Chr(10) & " 482 : Chyba Tisk�rny" & Chr(10) & " Jin� ��slo : Nezn�m� Chyba"
		RichTextBox1.Text = MsgText
		WaitFRM.Close()
	End Sub
	
	
	Private Sub ErrorList_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	
	Private Sub ErrorList_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Me.Cursor = System.Windows.Forms.Cursors.Default
		ConsoleWrite("ERRORLIST.uninit")
	End Sub
	
	
	Private Sub RichTextBox1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles RichTextBox1.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		'UPGRADE_ISSUE: Form property ErrorList.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
        'Me.Cursor = vbCustom
		'UPGRADE_ISSUE: RichTextLib.RichTextBox property LOGboX.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property ErrorList.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Me.MouseIcon = Console.LOGboX.MouseIcon
		
	End Sub
End Class