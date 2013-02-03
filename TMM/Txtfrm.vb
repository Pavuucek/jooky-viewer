Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6
Friend Class TextFRM
	Inherits System.Windows.Forms.Form
	Private Sub Back4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Back4.Click
		Dim em As Object
		Dim wdw As String
		PlaySound(11)
		'UPGRADE_WARNING: Couldn't resolve default property of object em. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		em = GetSetting("Harley Software", "Jooky-Viewer", "EditMode")
		wdw = GetSetting("Harley Software", "Jooky-Viewer", "Window")
		Select Case em
			Case "1"
				WriteIniFile("ini\main.ini", "List", "Last" & wdw, CStr(List1.Items.Count))
			Case Else
		End Select
		Me.Close()
		List.Enabled = True
		With List
			.Show()
			.Icon = Main_Renamed.Icon
		End With
		
	End Sub
	
	
	Private Sub File1_Click()
	End Sub
	
	
	
	Private Sub Back4_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Back4.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Back4.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		PrN.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Pix.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property TextFRM.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property TextFRM.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	Private Sub TextFRM_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim makx, em, uhc As Object
		Dim mohc As String
		On Error GoTo 1
		DrawBckGround(Me, "TextViewer", True)
		'UPGRADE_WARNING: Couldn't resolve default property of object em. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		em = GetSetting("Harley Software", "Jooky-Viewer", "EditMode")
		ProgressBar1.Value = 0
		'mizz = 0
		'UPGRADE_ISSUE: Constant vbPixels was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_ISSUE: Form property TextFRM.ScaleMode is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8027179A-CB3B-45C0-9863-FAA1AF983B59"'
		Me.ScaleMode = vbPixels
		PrN.Visible = False
		Me.Icon = Main_Renamed.Icon
		Select Case DetRes
			Case "640x480"
				RichTextBox1.Height = 361 - CaP.Height
				RichTextBox1.Width = 640
				RichTextBox1.RightMargin = VB6.TwipsToPixelsX(RichTextBox1.Width - 40)
				List1.Top = 368
			Case "800x600"
				RichTextBox1.Height = 481 - CaP.Height
				RichTextBox1.Width = 800
				RichTextBox1.RightMargin = VB6.TwipsToPixelsX(RichTextBox1.Width - 60)
				List1.Top = 488
			Case "1024x768"
				RichTextBox1.Height = 649 - CaP.Height
				RichTextBox1.Width = 1024
				RichTextBox1.RightMargin = VB6.TwipsToPixelsX(RichTextBox1.Width - 40)
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
		'UPGRADE_WARNING: Couldn't resolve default property of object makx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		makx = GetSetting("Harley Software", "Jooky-Viewer", "Window")
		'UPGRADE_WARNING: Couldn't resolve default property of object makx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ConsoleWrite("TEXTVIEWER.section=" & makx)
		'UPGRADE_WARNING: Couldn't resolve default property of object makx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		mohc = ReadIniFile("ini\main.ini", "List", "Last" & makx)
		'UPGRADE_WARNING: Couldn't resolve default property of object uhc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		uhc = 0
		RichTextBox1.ReadOnly = True
		PrN.Visible = False
		PrN.Enabled = False
		Save.Visible = False
		Save.Enabled = False
		'UPGRADE_WARNING: Couldn't resolve default property of object em. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If em = "1" Then
			RichTextBox1.ReadOnly = False
			PrN.Visible = True
			PrN.Enabled = True
			Save.Visible = True
			Save.Enabled = True
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object makx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If FileExists("data\text\" & ReadIniFile("ini\main.ini", "Clanky", makx)) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object makx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			RichTextBox1.LoadFile("data\text\" & ReadIniFile("ini\main.ini", "Clanky", makx))
			'UPGRADE_ISSUE: RichTextLib.RichTextBox property RichTextBox1.filename was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			ConsoleWrite("TEXTVIEWER.introfile=" & RichTextBox1.FileName)
		Else
			Err.Raise(53)
		End If
		For uhc = 1 To CInt(mohc)
			'UPGRADE_WARNING: Couldn't resolve default property of object uhc. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object makx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			List1.Items.Add(ReadIniFile("ini\main.ini", makx & uhc, "Name"))
		Next uhc
		GoTo 2
1: 
		DetError(Err.Number, "textviewer")
		WaitFRM.Close()
		Exit Sub
		GoTo 2
2: 
	End Sub
	
	Private Sub GM1_Click()
		
	End Sub
	
	
	Private Sub PrintBTN_Click()
		Dim Printer As New Printer
		PlaySound(11)
		Printer.Write(RichTextBox1.Text)
	End Sub
	
	
	Private Sub TextFRM_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = eventArgs.X
		Dim Y As Single = eventArgs.Y
		Back4.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		PrN.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Pix.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub TextFRM_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		List1.Items.Clear()
	End Sub
	
	Private Sub Image1_Click()
		
	End Sub
	
	Private Sub Label1_Click()
		
	End Sub
	
	Private Sub imgbackground_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles imgbackground.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Back4.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		PrN.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Pix.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	
	'UPGRADE_WARNING: Event List1.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub List1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles List1.SelectedIndexChanged
		Dim makz As String
		On Error GoTo 1
		PlaySound(11)
		WaitFRM.Show()
		System.Windows.Forms.Application.DoEvents()
		Fil = VB6.GetItemString(List1, List1.SelectedIndex)
		ConsoleWrite("TEXTVIEWER.list.#=" & List1.SelectedIndex)
		makz = GetSetting("Harley Software", "Jooky-Viewer", "Window")
		'ExtractFile "data.jkd", ReadIniFile("ini\main.ini", makz & List1.ListIndex + 1, "File")
		If FileExists("data\text\" & ReadIniFile("ini\main.ini", makz & List1.SelectedIndex + 1, "File")) Then
			RichTextBox1.LoadFile("data\text\" & ReadIniFile("ini\main.ini", makz & List1.SelectedIndex + 1, "File"))
			Select Case ReadIniFile("ini\main.ini", makz & List1.SelectedIndex + 1, "Verdikt")
				Case CStr(0) To CStr(11)
					ProgressBar1.Value = CSng(ReadIniFile("ini\main.ini", makz & List1.SelectedIndex + 1, "Verdikt"))
				Case Else
					ProgressBar1.Value = 0
			End Select
			'UPGRADE_ISSUE: RichTextLib.RichTextBox property RichTextBox1.filename was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			ConsoleWrite("TEXTVIEWER.file=" & RichTextBox1.FileName)
		Else
			Err.Raise(53)
		End If
		WaitFRM.Close()
		GoTo 2
1: 
		DetError(Err.Number, "textviewer")
		WaitFRM.Close()
		Exit Sub
		GoTo 2
2: 
	End Sub
	
	
	Private Sub List1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles List1.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Back4.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		PrN.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Pix.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property TextFRM.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property TextFRM.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub Pix_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Pix.Click
		Dim makx As String
		On Error GoTo 1
		PlaySound(11)
		makx = GetSetting("Harley Software", "Jooky-Viewer", "Window")
		If Fil = "" Then
			MsgBox("Nic si nezvolil",  , "WARNING !!!")
		Else
			PixFRM.Text = "Obrázky"
			PixFRM.File1.Path = ReadIniFile("ini\main.ini", makx & List1.SelectedIndex + 1, "PixPath")
			If Err.Number Then DetError(Err.Number, "textviewer/pixviewer")
			SaveSetting("Harley Software", "Jooky-Viewer", "Clanek", makx & List1.SelectedIndex + 1)
			ConsoleWrite("PIXVIEWER.path=" & PixFRM.File1.Path)
			Me.Enabled = False
			List.Hide()
			PixFRM.Show() 'vbmodal
		End If
		GoTo 2
1: 
		If Err.Number Then DetError(Err.Number, "textviewer/pixviewer")
		GoTo 2
2: 
	End Sub
	
	
	Private Sub Pix_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Pix.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Back4.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		PrN.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Pix.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		'UPGRADE_ISSUE: Form property TextFRM.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property TextFRM.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub PrN_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PrN.Click
		Dim wdw As Object
		Dim NaM As String
		PlaySound(11)
		'UPGRADE_WARNING: Couldn't resolve default property of object wdw. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		wdw = GetSetting("Harley Software", "Jooky-Viewer", "Window")
		'UPGRADE_WARNING: Couldn't resolve default property of object wdw. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		NaM = InputBox("Zadej jméno nového èlánku v sekci " & wdw & ".", wdw)
		'UPGRADE_WARNING: Couldn't resolve default property of object wdw. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteIniFile("ini\main.ini", wdw & List1.Items.Count + 1, "Name", NaM)
		'UPGRADE_WARNING: Couldn't resolve default property of object wdw. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteIniFile("ini\main.ini", wdw & List1.Items.Count + 1, "File", InputBox("Zadej jméno souboru, do kterého uložit èlánek. (i s pøíponou)", wdw))
		'UPGRADE_WARNING: Couldn't resolve default property of object wdw. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WriteIniFile("ini\main.ini", wdw & List1.Items.Count + 1, "Verdikt", InputBox("Zadej hodnocení pøíslušného èlánku. Od 0 do 11. Pokud èlánek nemá hodnocení, zadejte nulu.", wdw))
		'UPGRADE_WARNING: Couldn't resolve default property of object wdw. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Not FileExists("data\text\" & ReadIniFile("ini\main.ini", wdw & List1.Items.Count + 1, "File")) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object wdw. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FileOpen(1, "data\text\" & ReadIniFile("ini\main.ini", wdw & List1.Items.Count + 1, "File"), OpenMode.Random)
			FileClose(1)
		End If
		List1.Items.Add(NaM)
		'UPGRADE_WARNING: Couldn't resolve default property of object wdw. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		RichTextBox1.LoadFile("data\text\" & ReadIniFile("ini\main.ini", wdw & List1.Items.Count + 1, "File"))
		RichTextBox1.Focus()
	End Sub
	
	Private Sub PrN_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles PrN.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Back4.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		PrN.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		Pix.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property TextFRM.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property TextFRM.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub progressbar1_MouseMoveEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxComctlLib.IProgressBarEvents_MouseMoveEvent) Handles progressbar1.MouseMoveEvent
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	
	Private Sub RichTextBox1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles RichTextBox1.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Back4.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		PrN.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Pix.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property TextFRM.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: RichTextLib.RichTextBox property LOGboX.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: RichTextLib.RichTextBox property RichTextBox1.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		RichTextBox1.MouseIcon = Console.LOGboX.MouseIcon
		
	End Sub
	
	
	Private Sub Save_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Save.Click
		'UPGRADE_ISSUE: RichTextLib.RichTextBox property RichTextBox1.filename was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		FileOpen(1, RichTextBox1.FileName, OpenMode.Output)
		PrintLine(1, RichTextBox1.RTF)
		FileClose(1)
	End Sub
	
	
	Private Sub Verdiktomer_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Verdiktomer.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
End Class