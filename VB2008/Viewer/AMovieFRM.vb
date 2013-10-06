Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class AMovieFRM
	Inherits System.Windows.Forms.Form
	Private Sub ActiveXPlugin1_GotFocus()
	End Sub
	
	
	Private Sub ActiveMovie1_Error(ByVal eventSender As System.Object, ByVal eventArgs As AxAMovie.DActiveMovieEvents2_ErrorEvent) Handles ActiveMovie1.Error
		Err.Description = Description
		DetError(eventArgs.SCode, "PLAYER")
	End Sub
	
	Private Sub ActiveMovie1_MouseDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxAMovie.DActiveMovieEvents2_MouseDownEvent) Handles ActiveMovie1.MouseDownEvent
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	
	Private Sub ActiveMovie1_OpenComplete(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ActiveMovie1.OpenComplete
		WaitFRM.Close()
	End Sub
	
	
	Private Sub Back6_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Back6.Click
		PlaySound(11)
		Me.Close()
		ActiveMovie1.Stop()
		ConsoleWrite("PLAYER.GetMusic")
		MCIfrm.AMOVIE1.filename = GetSetting("Harley Software", "Jooky-Viewer", "Current_Music")
		Select Case LCase(VB.Right(MCIfrm.AMOVIE1.filename, 3))
			Case "mid"
				MCIfrm.AMOVIE1.DeviceType = "Sequencer"
			Case "wav"
				MCIfrm.AMOVIE1.DeviceType = "WaveAudio"
			Case Else
		End Select
		MCIfrm.AMOVIE1.Command = "Open"
		MCIfrm.AMOVIE1.Command = "Play"
		SaveSetting("Harley Software", "Jooky-Viewer", "Play_Ready", "1")
	End Sub
	
	
	Private Sub Check1_Click()
		ActiveMovie1.FullScreenMode = True
	End Sub
	
	Private Sub Back6_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Back6.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Back6.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		'Option1.ForeColor = &HFFFF&
		'Option2.ForeColor = &HFFFF&
		'UPGRADE_ISSUE: Form property AMovieFRM.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property AMovieFRM.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
	End Sub
	
	Private Sub File1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles File1.SelectedIndexChanged
		WaitFRM.Show()
		System.Windows.Forms.Application.DoEvents()
		PlaySound(11)
		ConsoleWrite("PLAYER.file=" & File1.FileName)
		ActiveMovie1.filename = "data\video\" & File1.FileName
	End Sub
	
	
	Private Sub File1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles File1.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Dim res As String
		Back6.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 9600 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 7200 Then res = "640x480"
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 12000 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 9000 Then res = "800x600"
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) >= 15360 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) >= 11520 Then res = "1024x768"
		
		Select Case res
			Case "640x480"
				ActiveMovie1.Height = 361
				ActiveMovie1.Width = 640
			Case "800x600"
				ActiveMovie1.Height = 481
				ActiveMovie1.Width = 800
			Case "1024x768"
				ActiveMovie1.Height = 649
				ActiveMovie1.Width = 1024
		End Select
		
		'UPGRADE_ISSUE: Form property AMovieFRM.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property AMovieFRM.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	
	'UPGRADE_WARNING: Form event AMovieFRM.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub AMovieFRM_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		Dim res As String
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 9600 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 7200 Then res = "640x480"
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 12000 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 9000 Then res = "800x600"
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) >= 15360 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) >= 11520 Then res = "1024x768"
		
		Select Case res
			Case "640x480"
				ActiveMovie1.Height = 361 - CaP.Height - 2
				ActiveMovie1.Width = 640
				File1.Top = 368 + CaP.Height
			Case "800x600"
				ActiveMovie1.Height = 481 - CaP.Height - 2
				ActiveMovie1.Width = 800
				File1.Top = 488 + CaP.Height
			Case "1024x768"
				ActiveMovie1.Height = 649 - CaP.Height - 2
				ActiveMovie1.Width = 1024
				File1.Top = 656 + CaP.Height
		End Select
		Back6.Top = File1.Top
	End Sub
	
	Private Sub AMovieFRM_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		On Error GoTo 1
		Dim res As Object
		ConsoleWrite("PLAYER.init")
		'UPGRADE_WARNING: Couldn't resolve default property of object res. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 9600 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 7200 Then res = "640x480"
		'UPGRADE_WARNING: Couldn't resolve default property of object res. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 12000 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 9000 Then res = "800x600"
		'UPGRADE_WARNING: Couldn't resolve default property of object res. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) >= 15360 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) >= 11520 Then res = "1024x768"
		
		Select Case res
			Case "640x480"
				ActiveMovie1.Height = 361 - CaP.Height - 2
				ActiveMovie1.Width = 640
				File1.Top = 368 + CaP.Height
			Case "800x600"
				ActiveMovie1.Height = 481 - CaP.Height - 2
				ActiveMovie1.Width = 800
				File1.Top = 488 + CaP.Height
			Case "1024x768"
				ActiveMovie1.Height = 649 - CaP.Height - 2
				ActiveMovie1.Width = 1024
				File1.Top = 656 + CaP.Height
		End Select
		Back6.Top = File1.Top
		File1.Path = "data\video"
		File1.Pattern = "*.AVI;*.FLC;*.FLI;*.CEL;*.MPG;*.MOV;*.QT;*.MID;*.WAV;*.RMI"
		'ConsoleWrite "PLAYER.SaveMusic"
		SaveSetting("Harley Software", "Jooky-Viewer", "Current_Music", MCIfrm.AMOVIE1.filename)
		SaveSetting("Harley Software", "Jooky-Viewer", "Play_Ready", "0")
		DrawBckGround(Me, "VidPlayer", True)
		MCIfrm.AMOVIE1.Command = "Stop"
		MCIfrm.AMOVIE1.Command = "Close"
		GoTo 2
1: 
		If Err.Number Then DetError(Err.Number, "player")
		GoTo 2
2: 
	End Sub
	
	
	Private Sub AMovieFRM_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = eventArgs.X
		Dim Y As Single = eventArgs.Y
		Dim res As String
		Back6.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 9600 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 7200 Then res = "640x480"
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 12000 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 9000 Then res = "800x600"
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) >= 15360 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) >= 11520 Then res = "1024x768"
		
		Select Case res
			Case "640x480"
				ActiveMovie1.Height = 361
				ActiveMovie1.Width = 640
			Case "800x600"
				ActiveMovie1.Height = 481
				ActiveMovie1.Width = 800
			Case "1024x768"
				ActiveMovie1.Height = 649
				ActiveMovie1.Width = 1024
		End Select
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
		
	End Sub
	
	
	Private Sub AMovieFRM_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		ConsoleWrite("PLAYER.uninit")
	End Sub
	
	
	Private Sub Option1_Click()
		PlaySound(11)
		ConsoleWrite("PLAYER.mode=FULLSCREEN")
		ActiveMovie1.FullScreenMode = True
	End Sub
	
	
	Private Sub Option1_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single)
	End Sub
	
	
	Private Sub Option2_Click()
		PlaySound(11)
		ConsoleWrite("PLAYER.mode=WINDOWED")
		ActiveMovie1.FullScreenMode = False
	End Sub
	
	
	Private Sub Uvodnik_Click()
		
	End Sub
	
	
	Private Sub Option2_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single)
	End Sub
	
	
	Private Sub Image1_Click()
		
	End Sub
	
	
	Private Sub Image1_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single)
		
	End Sub
	
	
	Private Sub imgbackground_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles imgbackground.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Dim res As String
		Back6.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 9600 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 7200 Then res = "640x480"
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 12000 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 9000 Then res = "800x600"
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) >= 15360 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) >= 11520 Then res = "1024x768"
		
		Select Case res
			Case "640x480"
				ActiveMovie1.Height = 361
				ActiveMovie1.Width = 640
			Case "800x600"
				ActiveMovie1.Height = 481
				ActiveMovie1.Width = 800
			Case "1024x768"
				ActiveMovie1.Height = 649
				ActiveMovie1.Width = 1024
		End Select
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
End Class