Option Strict Off
Option Explicit On
Friend Class Installer
	Inherits System.Windows.Forms.Form
	
	
	
	Private Sub cmdcancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdcancel.Click
		PlaySound(11)
		Me.Close()
		ConsoleWrite("INSTALLER.uninit")
		SaveSetting("Harley Software", "Jooky-Viewer", "Inst_File", "")
		
	End Sub
	
	
	Private Sub dirDirs_Change()
		
	End Sub
	
	
	Private Sub drvDrives_Change()
		
	End Sub
	
	Private Sub cmdCancel_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdCancel.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		cmdOk.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		cmdCancel.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		'UPGRADE_ISSUE: Form property Installer.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property Installer.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
		On Error GoTo 1
		prgz = GetSetting("Harley Software", "Jooky-Viewer", "Inst_File")
		PlaySound(11)
		If prgz = "" Then
			MsgBox("Nic si nezvolil !!!", MsgBoxStyle.Exclamation, "WARNING")
		Else
			Shell("cd\" & prgz, AppWinStyle.NormalFocus)
			ConsoleWrite("INSTALLER.extract=" & prgz)
		End If
		GoTo 2
1: 
		DetError(Err.Number, "installer")
		GoTo 2
2: 
	End Sub
	
	Private Sub cmdOK_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdOK.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		cmdOk.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		cmdCancel.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property Installer.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property Installer.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub dir1_Change()
	End Sub
	
	Private Sub dir1_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single)
		cmdOk.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		cmdCancel.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		
	End Sub
	
	
	Private Sub drive1_Change()
	End Sub
	
	Private Sub File1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles File1.SelectedIndexChanged
		PlaySound(11)
		SaveSetting("Harley Software", "Jooky-Viewer", "Inst_File", File1.FileName)
		RichTextBox1.LoadFile(ReadIniFile("ini\main.ini", "Files", File1.FileName))
	End Sub
	
	Private Sub File1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles File1.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		cmdOk.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		cmdCancel.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property Installer.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property Installer.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub Installer_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		On Error GoTo 1
		DrawBckGround(Me, "Installer")
		CenterForm(Me)
		ConsoleWrite("INSTALLER.init")
		RichTextBox1.Text = "Zvol si jméno souboru a místo tohoto textu se zobrazí informace o daném programu. Pokud si ho budeš chtít nainstalovat, zmáèkni na tlaèítko 'Instalovat'. Pokud se zobrazí nìjaké chybové hlášení, tak bude asi nìco v nepoøádku s daným souborem."
		File1.Path = "cd"
		RichTextBox1.RightMargin = VB6.TwipsToPixelsX(RichTextBox1.Width - 40)
		Me.Enabled = True
		GoTo 2
1: 
		If Err.Number Then DetError(Err.Number, "installer")
		GoTo 2
2: 
	End Sub
	
	Private Sub lblDrives_Click()
		
	End Sub
	
	
	Private Sub lblPath_Click()
		
	End Sub
	
	
	Private Sub lblPrompt_Click()
		
	End Sub
	
	
	Private Sub Timer1_Timer()
	End Sub
	
	
	Private Sub Timer2_Timer()
	End Sub
	
	
	Private Sub Installer_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = eventArgs.X
		Dim Y As Single = eventArgs.Y
		cmdOk.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		cmdCancel.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	
	Private Sub Label1_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single)
		cmdOk.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		cmdCancel.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		
	End Sub
	
	
	Private Sub Image1_Click()
		
	End Sub
	
	Private Sub imgbackground_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles imgbackground.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		cmdOk.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		cmdCancel.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	
	Private Sub RichTextBox1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles RichTextBox1.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		cmdOk.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		cmdCancel.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property Installer.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: RichTextLib.RichTextBox property LOGboX.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property Installer.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Console.LOGboX.MouseIcon
		
	End Sub
End Class