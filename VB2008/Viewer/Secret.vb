Option Strict Off
Option Explicit On
Friend Class Sexret
	Inherits System.Windows.Forms.Form
	
	'UPGRADE_WARNING: Form event Sexret.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub Sexret_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		With Image1
			.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height
			.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
		End With
		Me.Icon = Main_Renamed.Icon
	End Sub
	
	Private Sub Sexret_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		With Image1
			.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height
			.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
		End With
		Me.Icon = Main_Renamed.Icon
	End Sub
	
	
	Private Sub Sexret_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		WaitFRM.Close()
		ConsoleWrite("PIXVIEWER.SecretSection.uninit")
	End Sub
End Class