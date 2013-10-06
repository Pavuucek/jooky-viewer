Option Strict Off
Option Explicit On
Friend Class Console
	Inherits System.Windows.Forms.Form
	Private Sub Console_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		On Error GoTo 1
		imbPozadi.Height = Me.Height
		imbPozadi.Width = Me.Width
		LOGboX.SelectionColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
		Text1.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
		Me.Icon = Main_Renamed.Icon
		Text1.Text = ""
		Label1.Text = "Konzole slou�� k monitorov�n� �innosti diskmagu a k jeho ��ste�n�mu ovl�d�n�." & Chr(10) & "Pokud nejste �lov�k p��kaz�znal�, tak konzoli rad�i nechte napokoji."
		GoTo 2
1: 
		If Err.Number Then DetError(Err.Number, "console")
		GoTo 2
2: 
		
	End Sub
	
	
	Private Sub Console_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	
	Private Sub Console_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		PlaySound(13)
		Text1.Text = UCase("unload me")
		MsgBox("Nem��e� zav��t konzoli !!!" & Chr(10) & "P��kazem 'UNLOAD ME' se zav�e cel� DiskMag")
		'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
		Cancel = True
	End Sub
	
	
	Private Sub RichTextBox1_Change()
		
	End Sub
	
	Private Sub Label1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	
	Private Sub Text1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Text1.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		On Error GoTo 1
		Dim cmd As Object
		Dim passwordicek, XtrA As Object
		Dim User As String
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			LOGboX.Text = LOGboX.Text & Chr(10) & "Command: " & UCase(Text1.Text)
			Select Case LCase(Text1.Text)
				Case "show secret"
					Maskot()
				Case "unload me"
					ConsoleWrite("Sending Shutdown command ...")
					Main_Renamed.Close()
				Case "unload now"
					ConsoleWrite("ShutDown CONSOLE")
					WriteLOG()
					End
				Case "run dos"
					Shell("c:\command.com", AppWinStyle.MaximizedFocus)
					ConsoleWrite("Running MS-DOS ...")
				Case "run xplr"
					Shell("explorer.exe", AppWinStyle.MaximizedFocus)
					ConsoleWrite("Running EXPLORER ...")
				Case "show errorlist"
					ErrorList.Show()
				Case "edit main.ini"
					Shell("notepad ini\main.ini", AppWinStyle.MaximizedFocus)
				Case "show password"
					MsgBox("Heslo je : " & UCase(ReadIniFile("ini\main.ini", "Common", "Heslo")), MsgBoxStyle.Critical, "Heslo k tajn� ��sti")
				Case "run www"
					WWWconnect()
				Case "show www"
					ConsoleWrite("WWW.ADDRESS=" & UCase(ReadIniFile("ini\main.ini", "Common", "WWW")))
					MsgBox("Adresa na ENGINE On-Line je : " & UCase(ReadIniFile("ini\main.ini", "Common", "WWW")), MsgBoxStyle.Information, "Internetov� adresa")
				Case "show list"
					List.Show()
				Case "show player"
					AMovieFRM.Show()
				Case "show about"
					PRGinF.Show()
				Case "show cp", "show control panel", "show controlpanel"
					ConsoleWrite("CONTROLPANEL.init")
					MCIfrm.Show()
				Case "show installer"
					Installer.Show()
				Case "show help"
					Help.Show()
				Case "god mode on"
					MsgBox("Tento p��kaz je ur�en pro aktivov�n� tzv. 'GOD m�du', pokud jsi k tomu opr�vn�n, tak zadej heslo !!!!", MsgBoxStyle.Exclamation, "!!! WARNING !!!")
					'UPGRADE_WARNING: Couldn't resolve default property of object passwordicek. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					passwordicek = LCase(InputBox("Pro pro aktivov�n� 'GOD m�du' je nutno nejprve vlo�it heslo !!!", "Activating 'GOD mode'"))
					'UPGRADE_WARNING: Couldn't resolve default property of object passwordicek. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If LCase(passwordicek) = ReadIniFile("ini\main.ini", "Common", "Heslo") Then SaveSetting("Harley Software", "Jooky-Viewer", "GOD_Mode", "1")
					MsgBox("Nyn� zadej sv� jm�no ...", MsgBoxStyle.Exclamation, "!!! WARNING !!!")
					SaveSetting("Harley Software", "Jooky-Viewer", "User_Name", InputBox("Zadej sv� jm�no :", "Activating 'GOD mode'"))
					'UPGRADE_WARNING: Couldn't resolve default property of object XtrA. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					XtrA = GetSetting("Harley Software", "Jooky-Viewer", "GOD_Mode")
					User = GetSetting("Harley Software", "Jooky-Viewer", "User_Name")
					'UPGRADE_WARNING: Couldn't resolve default property of object XtrA. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If XtrA = "1" Then
						Main_Renamed.Usr.Visible = True
						Main_Renamed.Usr.Text = "GOD Mode ON" & Chr(10) & "User : " & User
						Main_Renamed.Usr.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Main_Renamed.XitBTN.Left) + VB6.PixelsToTwipsX(Main_Renamed.XitBTN.Width) - VB6.PixelsToTwipsX(Main_Renamed.Usr.Width) - 5)
						Main_Renamed.Usr.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Main_Renamed.NuMx.Top) + VB6.PixelsToTwipsY(Main_Renamed.NuMx.Height) + 3)
					End If
				Case "god mode off"
					DeleteSetting("Harley Software", "Jooky-Viewer", "GOD_Mode")
					Main_Renamed.Usr.Visible = False
					MsgBox("'GOD m�d' byl deaktivov�n !!!", MsgBoxStyle.Exclamation, "!!! WARNING !!!")
				Case "satan mode on", "satan mode off"
					MsgBox("'SATAN mode' ZAT�M nevedeme !!!", MsgBoxStyle.Exclamation, "!!! WARNING !!!")
				Case "editmode"
					If GetSetting("Harley Software", "Jooky-Viewer", "GOD_Mode") = "1" Then
						SaveSetting("Harley Software", "Jooky-Viewer", "EditMode", "1")
						MsgBox("Byly zapnuty edita�n� vlastnosti programu !!!", MsgBoxStyle.Exclamation, "Jooky-Viewer")
					Else
						MsgBox("Pro aktivaci edita�n�ch vlastnost� je nutno spustit GOD MODE !!!", MsgBoxStyle.Exclamation, "Jooky-Viewer")
					End If
				Case "initmusic"
					InitMusic()
					ConsoleWrite("INITMUSIC.filename=" & MCIfrm.AMOVIE1.filename)
				Case Else
					MsgBox("Bad Command or File Name !!!", MsgBoxStyle.Exclamation, "Jooky-Viewer")
					LOGboX.Text = LOGboX.Text & " is not valid command"
			End Select
			Text1.Text = ""
		End If
		GoTo 2
1: 
		If Err.Number Then DetError(Err.Number, "console")
		GoTo 2
2: 
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub Text1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Text1.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		'UPGRADE_ISSUE: Form property Console.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: RichTextLib.RichTextBox property LOGboX.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property Console.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = LOGboX.MouseIcon
		
	End Sub
End Class