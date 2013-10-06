Option Strict Off
Option Explicit On
Friend Class ReklFRM
	Inherits System.Windows.Forms.Form
	Private Sub ContinueX_Click()
	End Sub
	
	Private Sub ContinueX_MouseMove(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single)
	End Sub
	
	
	Private Sub ReklFRM_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Click
		Dim res, RexX As Object
		Dim ReXTE As String
		On Error GoTo 1
		'UPGRADE_WARNING: Couldn't resolve default property of object res. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 9600 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 7200 Then res = "640x480"
		'UPGRADE_WARNING: Couldn't resolve default property of object res. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 12000 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 9000 Then res = "800x600"
		'UPGRADE_WARNING: Couldn't resolve default property of object res. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) >= 15360 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) >= 11520 Then res = "1024x768"
		Select Case res
			Case "640x480"
				Image1.Height = 480
				Image1.Width = 640
			Case "800x600"
				Image1.Height = 600
				Image1.Width = 800
			Case "1024x768"
				Image1.Height = 768
				Image1.Width = 1024
		End Select
		PlaySound(11)
		'UPGRADE_WARNING: Couldn't resolve default property of object RexX. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		RexX = ReadIniFile("ini\main.ini", "Common", "Last_Reklama")
		ReXTE = ReadIniFile("ini\main.ini", "Common", "ReklamaEXT")
		'UPGRADE_WARNING: Couldn't resolve default property of object RexX. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ble <> RexX Then
			WaitFRM.Show()
			System.Windows.Forms.Application.DoEvents()
			ble = ble + 1
			ConsoleWrite("PIXVIEWER.REKLAMA.file=data\pictures\rekl0" & ble & "." & ReXTE)
			Image1.Image = System.Drawing.Image.FromFile("data\pictures\rekl0" & ble & "." & ReXTE)
			If Err.Number Then DetError(Err.Number, "REKLAMA")
			WaitFRM.Close()
		Else
			PlaySound(13)
			ConsoleWrite("Shutdown NOW")
			WriteLOG()
			Me.Cursor = System.Windows.Forms.Cursors.Default
			MsgBox("Ètìte DiskMag ENGINE." & Chr(10) & Chr(10) & "See you next time.",  , "Už koneènì Konec")
			'  DeleteSetting appname:="Harley Software", section:="Jooky-Viewer"
			End
		End If
		GoTo 2
1: 
		DetError(Err.Number, "REKLAMA")
		GoTo 2
2: 
		
		
	End Sub
	
	Private Sub ReklFRM_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim res As String
		On Error GoTo 1
		WaitFRM.Show()
		System.Windows.Forms.Application.DoEvents()
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 9600 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 7200 Then res = "640x480"
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) = 12000 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) = 9000 Then res = "800x600"
		If VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) >= 15360 And VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) >= 11520 Then res = "1024x768"
		Select Case res
			Case "640x480"
				Image1.Height = 480
				Image1.Width = 640
			Case "800x600"
				Image1.Height = 600
				Image1.Width = 800
			Case "1024x768"
				Image1.Height = 768
				Image1.Width = 1024
		End Select
		
		ble = 0
		ConsoleWrite("PIXVIEWER.initREKLAMA")
		ConsoleWrite("PIXVIEWER.REKLAMA.LastPix=" & ReadIniFile("ini\main.ini", "Common", "Last_Reklama"))
		ConsoleWrite("PIXVIEWER.REKLAMA.Extension=" & ReadIniFile("ini\main.ini", "Common", "ReklamaEXT"))
		ConsoleWrite("PIXVIEWER.REKLAMA.file=data\pictures\rekl00." & ReadIniFile("ini\main.ini", "Common", "ReklamaEXT"))
		Image1.Image = System.Drawing.Image.FromFile("data\pictures\rekl00." & ReadIniFile("ini\main.ini", "Common", "ReklamaEXT"))
		GoTo 2
1: 
		DetError(Err.Number, "PIXVIEWER.REKLAMA")
		GoTo 2
2: 
		WaitFRM.Close()
	End Sub
	
	
	Private Sub ReklFRM_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = eventArgs.X
		Dim Y As Single = eventArgs.Y
		'UPGRADE_ISSUE: Form property ReklFRM.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property ReklFRM.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
	
	Private Sub Image1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Image1.Click
		Dim RexX As Object
		Dim ReXTE As String
		On Error GoTo 1
		PlaySound(11)
		'UPGRADE_WARNING: Couldn't resolve default property of object RexX. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		RexX = ReadIniFile("ini\main.ini", "Common", "Last_Reklama")
		ReXTE = ReadIniFile("ini\main.ini", "Common", "ReklamaEXT")
		'UPGRADE_WARNING: Couldn't resolve default property of object RexX. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ble <> RexX Then
			WaitFRM.Show()
			System.Windows.Forms.Application.DoEvents()
			ble = ble + 1
			ConsoleWrite("PIXVIEWER.REKLAMA.file=data\pictures\rekl0" & ble & "." & ReXTE)
			Image1.Image = System.Drawing.Image.FromFile("data\pictures\rekl0" & ble & "." & ReXTE)
			If Err.Number Then DetError(Err.Number, "REKLAMA")
			WaitFRM.Close()
		Else
			PlaySound(13)
			ConsoleWrite("Shutdown NOW")
			WriteLOG()
			MsgBox("Ètìte DiskMag ENGINE." & Chr(10) & Chr(10) & "See you next time.",  , "Už koneènì Konec")
			'  DeleteSetting appname:="Harley Software", section:="Jooky-Viewer"
			End
		End If
		GoTo 2
1: 
		DetError(Err.Number, "REKLAMA")
		GoTo 2
2: 
	End Sub
	
	Private Sub Image1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Image1.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		'UPGRADE_ISSUE: Form property ReklFRM.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
		Me.Cursor = vbCustom
		'UPGRADE_ISSUE: Image property XitBTN.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		'UPGRADE_ISSUE: Form property ReklFRM.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		Me.MouseIcon = Main_Renamed.XitBTN.MouseIcon
		
	End Sub
End Class