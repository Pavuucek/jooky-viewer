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
		MsgText = "Seznam 'ERRORù' generovaných programem podle èísla " & Chr(10) & Chr(10)
		MsgText = MsgText & " 3 : Použit RETURN bez GOSUB" & Chr(10) & " 5 : Chybné volání procedùry" & Chr(10) & " 6 : Pøeteèení" & Chr(10) & " 7 : Málo Pamìti" & Chr(10) & " 9 : Index mimo rozsah" & Chr(10) & " 11 : Pole je pevné nebo zamknuté" & Chr(10) & " 13 : Typ Nesouhlasí" & Chr(10) & " 14 : Nedostatek místa v øetìzci" & Chr(10) & " 15 : Pøíliš složitý výraz" & Chr(10) & " 17 : Nelze provést" & Chr(10) & " 18 : Pøerušeno uživatelem" & Chr(10) & " 20 : Použití RESUME bez chyby" & Chr(10) & " 28 : Málo místa v zásobníku" & Chr(10) & " 35 : Procedùra, funkce nebo vlastnost neni definována" & Chr(10) & " 47 : DLL využívá moc aplikací" & Chr(10) & " 48 : Chyba pøi naèítání DLL" & Chr(10) & " 49 : Chybná konvence volání knihovny DLL" & Chr(10) & " 51 : Interní chyba" & Chr(10) & " 52 : Špatný název nebo èíslo souboru" & Chr(10) & " 53 : Soubor Nenalezen" & Chr(10) & " 54 : Špatný Režim Souboru" & Chr(10) & " 56 : Soubor je už otevøen" & Chr(10) & " 57 : I/O chyba" & Chr(10)
		MsgText = MsgText & " 58 : Soubor už existuje" & Chr(10) & " 59 : Chybná délka záznamu" & Chr(10)
		MsgText = MsgText & " 61 : Disk je plný" & Chr(10) & " 62 : Vstup za koncem souboru" & Chr(10) & " 63 : Chybné èíslo záznamu" & Chr(10) & " 67 : Pøíliš souborù" & Chr(10) & " 68 : Zaøízení není dostupné" & Chr(10) & " 70 : Pøístup odmítnut" & Chr(10) & " 71 : Disk není pøipraven" & Chr(10) & " 74 : Nejde pøesunout na jinou jednotku" & Chr(10) & " 75 : Chyba v pøístupu k souboru" & Chr(10) & " 76 : Cesta nenalezena" & Chr(10) & " 91 : Není nastavená objektová promìná nebo promìnná WITH" & Chr(10) & " 92 : Neinicializovaná smyèka FOR" & Chr(10) & " 93 : Chybný øetìzec vzorku" & Chr(10) & " 94 : Chybné použití NULL" & Chr(10) & " 444 : Metoda se nedá použít v tomto kontextu" & Chr(10) & " 452 : Chybné èíslo procedùry v DLL" & Chr(10) & " 453 : Funkce v DLL nenalezena" & Chr(10) & " 481 : Chybný Obrázek" & Chr(10) & " 482 : Chyba Tiskárny" & Chr(10) & " Jiné èíslo : Neznámá Chyba"
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