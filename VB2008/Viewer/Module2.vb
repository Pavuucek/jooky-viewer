Option Strict Off
Option Explicit On
Module Console_Engine
	Function IsScript(ByRef Script As String) As Boolean
		On Error GoTo 1
		If FileExists(Script) And LCase(ReadIniFile(Script, "FileInfo", "ID")) = "jooky_script" Then
			IsScript = True
		Else
			MsgBox("File " & Script & "is missing or it isn't valid script", MsgBoxStyle.Exclamation, "Jooky-Script")
			IsScript = False
			Exit Function
		End If
		GoTo 2
1: 
		DetError(Err.Number, "READSCRIPT")
		GoTo 2
2: 
	End Function
	
	Sub Maskot()
		Dim XtrA As Object
		Dim passwordik As String
		On Error GoTo ass
		'UPGRADE_WARNING: Couldn't resolve default property of object XtrA. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		XtrA = GetSetting("Harley Software", "Jooky-Viewer", "GOD_Mode")
		'UPGRADE_WARNING: Couldn't resolve default property of object XtrA. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If XtrA <> "1" Then
			MsgBox("Nemáš zapnutý tzv. 'GOD mód', ten je potøeba pro vstup do tajné sekce !!!", MsgBoxStyle.Exclamation, "The Secret Section")
			Exit Sub
		End If
		passwordik = LCase(InputBox("Pro vstup do tajné sekce je nutno nejprve vložit heslo !!!", "The Secret Section"))
		ConsoleWrite("PIXVIEWER.SecretSection.init")
		Select Case LCase(passwordik)
			Case LCase(ReadIniFile("ini\main.ini", "Common", "Heslo"))
				WaitFRM.Show()
				System.Windows.Forms.Application.DoEvents()
				If Not FileExists("data\pictures\secret.65") Then Err.Raise(53)
				Sexret.Image1.Image = System.Drawing.Image.FromFile("data\pictures\secret.65")
				ConsoleWrite("PIXVIEWER.SecretSection.Password=" & passwordik)
				ConsoleWrite("PIXVIEWER.SecretSection=ACCESS ALLOWED")
				ConsoleWrite("Opening secret section ...")
				Sexret.Show()
				WaitFRM.Close()
			Case CStr(MsgBoxResult.Cancel)
				Exit Sub
			Case Else
				MsgBox("Špatné heslo !!!" & Chr(10) & Chr(10) & "ACCESS DENIED !!!",  , "Špatnì !!!")
				ConsoleWrite("PIXVIEWER.SecretSection=ACCESS NOT ALLOWED !!!")
		End Select
		
ass: 
		If Err.Number = 53 Then
			MsgBox("Obrázek NEJNI !!!" & Chr(10) & "Zobrazuji náhradní.", MsgBoxStyle.Information, "ERROR")
			ConsoleWrite("PIXVIEWER.error=NO SECRET PICTURE DETECTED")
			Sexret.Image1.Image = frmSplash.imglogo.Image
			Sexret.Show()
			Exit Sub
		End If
	End Sub
	
	
	
	Sub ConsoleWrite(ByRef what As String)
		Console.LOGboX.Text = Console.LOGboX.Text & Chr(10) & what
	End Sub
	Sub WriteLOG()
		FileOpen(1, "C:\JKV.LOG", OpenMode.Output)
		PrintLine(1, Console.LOGboX.Text)
		FileClose(1)
	End Sub
End Module