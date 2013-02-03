Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class MCIfrm
	Inherits System.Windows.Forms.Form
	
	Private Sub AMOVIE1_Error(ByVal SCode As Short, ByVal Description As String, ByVal Source As String, ByRef CancelDisplay As Boolean)
		If Err.Number Then DetError(Err.Number, "controlpanel")
	End Sub
	
	Private Sub AMOVIE1_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single)
		PrNSeTuP.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CloseB.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property MCIfrm.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property MCIfrm.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	Private Sub AMOVIE1_OpenComplete()
		
	End Sub
	
	
	Private Sub AMOVIE1_StateChange(ByVal oldState As Integer, ByVal newState As Integer)
		
	End Sub
	
	
	Private Sub AMOVIE1_Timer()
		
	End Sub
	
	Private Sub AMOVIE1_Done(ByVal eventSender As System.Object, ByVal eventArgs As AxMCI.DmciEvents_DoneEvent) Handles AMOVIE1.Done
		Select Case GetSetting("Harley Software", "Jooky-Viewer", "Play_Ready")
			Case "1"
				InitMusic()
				ConsoleWrite("INITMUSIC.filename=" & Me.AMOVIE1.filename)
			Case Else
				Exit Sub
		End Select
	End Sub
	
	Private Sub CloseB_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CloseB.Click
		PlaySound(11)
		ConsoleWrite("CONTROLPANEL.uninit")
		Me.Hide()
	End Sub
	
	Private Sub CloseB_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles CloseB.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		PrNSeTuP.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CloseB.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		'UPGRADE_ISSUE: Form property MCIfrm.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property MCIfrm.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub File1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles File1.SelectedIndexChanged
		On Error GoTo 1
		PlaySound(11)
		ConsoleWrite("CONTROLPANEL.file=" & File1.FileName)
		ConsoleWrite(" Playing new music")
		AMOVIE1.Command = "Stop"
		AMOVIE1.Command = "Close"
		AMOVIE1.filename = "data\music\" & File1.FileName
		Select Case LCase(VB.Right(File1.FileName, 3))
			Case "mid"
				AMOVIE1.DeviceType = "Sequencer"
			Case "wav"
				AMOVIE1.DeviceType = "WaveAudio"
		End Select
		AMOVIE1.Command = "Open"
		AMOVIE1.Command = "Play"
		GoTo 2
1: 
		If Err.Number Then DetError(Err.Number, "controlpanel")
		GoTo 2
2: 
	End Sub
	
	Private Sub File1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles File1.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		PrNSeTuP.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CloseB.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		'UPGRADE_ISSUE: Form property MCIfrm.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property MCIfrm.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub MCIfrm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		CenterForm(Me)
		DrawBckGround(Me, "ControlPanel")
		PrNSeTuP.Visible = False
		Me.Icon = Main_Renamed.Icon
		File1.Path = "data\music"
		File1.Pattern = "*.MID;*.WAV"
	End Sub
	
	
	Private Sub MCIfrm_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		PrNSeTuP.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CloseB.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		RNDmus.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	
	
	Private Sub Label3_Click()
		PlaySound(11)
		InitMusic()
	End Sub
	
	Private Sub imgbackground_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles imgbackground.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		PrNSeTuP.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		CloseB.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		RNDmus.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
	End Sub
	
	
	Private Sub Label1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Me.Cursor = System.Windows.Forms.Cursors.Default
	End Sub
	
	
	Private Sub MMControl1_Done(ByRef NotifyCode As Short)
		
	End Sub
	
	Private Sub PrNseTuP_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles PrNseTuP.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		PrNSeTuP.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		CloseB.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFF)
	End Sub
	
	
	Private Sub Timer1_Timer()
	End Sub
	
	
	Private Sub Timer2_Timer()
	End Sub
	
	
	Private Sub rndmus_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles rndmus.Click
		PlaySound(11)
		InitMusic()
		ConsoleWrite("INITMUSIC.random=" & Me.AMOVIE1.filename)
	End Sub
	
	Private Sub rndmus_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles rndmus.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		RNDmus.ForeColor = System.Drawing.ColorTranslator.FromOle(&HC000C0)
		'UPGRADE_ISSUE: Form property MCIfrm.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property MCIfrm.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	
	Private Sub SldWave_Change()
	End Sub
	
	Private Sub Slider1_Change()
	End Sub
End Class