Option Strict Off
Option Explicit On
Friend Class LauncherMain
	Inherits System.Windows.Forms.Form
	Private Sub Close_Renamed_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Close_Renamed.Click
		End
	End Sub
	
	Private Sub Command2_Click()
		
	End Sub
	
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		CreateShellGroup("DiskMag ENGINE")
		CreateShellLink(My.Application.Info.DirectoryPath & "\engine.exe", "-shortcut", "DiskMag ENGINE")
	End Sub
	
	
	Private Sub LauncherMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		If Not FileExists("jooky00.dll") Then
			Command1.Enabled = False
		End If
		CenterForm(Me)
	End Sub
	
	
	Private Sub RunE_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles RunE.Click
		If FileExists(My.Application.Info.DirectoryPath & "\engine.exe") Then
			Shell(My.Application.Info.DirectoryPath & "\engine.exe -launcher")
		Else
			MsgBox("Soubor nebyl nalezen, ujistìte se, že Launcher a DiskMag ENGINE jsou ve stejné složce.", MsgBoxStyle.Exclamation, "Launcher")
		End If
	End Sub
End Class