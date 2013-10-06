Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6
Friend Class Help
	Inherits System.Windows.Forms.Form
	Private Sub Back4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Back4.Click
		Me.Close()
	End Sub
	
	
	Private Sub Back6_Click(ByRef index As Short)
	End Sub
	
	
	Private Sub Back4_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Back4.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Back4.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		NFO.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property Help.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property Help.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	'UPGRADE_WARNING: Form event Help.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub Help_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		Dim res As String
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 9600 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 7200 Then res = "640x480"
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 12000 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 9000 Then res = "800x600"
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) >= 15360 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) >= 11520 Then res = "1024x768"
		
		Select Case res
			Case "640x480"
				RichTextBox1.Height = 361
				RichTextBox1.Width = 640
				NFO.Top = 368
			Case "800x600"
				RichTextBox1.Height = 481
				RichTextBox1.Width = 800
				NFO.Top = 488
			Case "1024x768"
				RichTextBox1.Height = 649
				RichTextBox1.Width = 1024
				NFO.Top = 656
		End Select
		CaP.Text = Me.Text
		RichTextBox1.Top = CaP.Top + CaP.Height + 5
		RichTextBox1.RightMargin = VB6.TwipsToPixelsX(RichTextBox1.Width)
		Back4.Left = 240
		NFO.Left = 8
		NFO.Top = NFO.Top + CaP.Height + 2
		Back4.Top = NFO.Top
		ConsoleWrite("HELP.init")
		
	End Sub
	
	Private Sub Help_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim res As String
		On Error GoTo 1
		WaitFRM.Show()
		System.Windows.Forms.Application.DoEvents()
		'UPGRADE_ISSUE: Constant vbPixels was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_ISSUE: Form property Help.ScaleMode is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8027179A-CB3B-45C0-9863-FAA1AF983B59"'
		Me.ScaleMode = vbPixels
		'Main.Hide
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 9600 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 7200 Then res = "640x480"
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 12000 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 9000 Then res = "800x600"
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) >= 15360 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) >= 11520 Then res = "1024x768"
		
		Select Case res
			Case "640x480"
				RichTextBox1.Height = 361
				RichTextBox1.Width = 640
				NFO.Top = 368
			Case "800x600"
				RichTextBox1.Height = 481
				RichTextBox1.Width = 800
				NFO.Top = 488
			Case "1024x768"
				RichTextBox1.Height = 649
				RichTextBox1.Width = 1024
				NFO.Top = 656
		End Select
		CaP.Text = Me.Text
		RichTextBox1.Top = CaP.Top + CaP.Height + 5
		RichTextBox1.RightMargin = VB6.TwipsToPixelsX(RichTextBox1.Width)
		Back4.Left = 240
		NFO.Left = 8
		NFO.Top = NFO.Top + CaP.Height + 2
		Back4.Top = NFO.Top
		ConsoleWrite("HELP.init")
		Me.Icon = Main_Renamed.Icon
		DrawBckGround(Me, "Help", True)
		RichTextBox1.LoadFile("data\text\help.rtf")
		GoTo 2
1: 
		If Err.Number Then DetError(Err.Number, "help")
		GoTo 2
2: 
		WaitFRM.Close()
	End Sub
	
	Private Sub SysInfo_Click(ByRef index As Short)
		Me.Enabled = False
	End Sub
	
	
	Private Sub PrintBTN_Click()
		Dim Printer As New Printer
		PlaySound(11)
		Printer.Write(RichTextBox1.Text)
	End Sub
	
	
	Private Sub Info_Click()
		PlaySound(11)
		Me.Enabled = False
		PRGinF.Show()
	End Sub
	
	
	Private Sub Help_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = eventArgs.X
		Dim Y As Single = eventArgs.Y
		NFO.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back4.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	Private Sub Help_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		PlaySound(11)
		Main_Renamed.Enabled = True
		ConsoleWrite("HELP.uninit")
		Main_Renamed.Show()
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	
	Private Sub Image1_Click()
		
	End Sub
	
	Private Sub imgbackground_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles imgbackground.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		NFO.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back4.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	
	Private Sub NFO_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles NFO.Click
		PlaySound(11)
		PRGinF.Show()
	End Sub
	
	Private Sub NFO_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles NFO.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		NFO.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		Back4.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property Help.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property Help.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub RichTextBox1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles RichTextBox1.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		NFO.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Back4.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property Help.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: RichTextLib.RichTextBox property LOGboX.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: RichTextLib.RichTextBox property RichTextBox1.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		RichTextBox1.MouseIcon = Console.LOGboX.MouseIcon
		
	End Sub
End Class