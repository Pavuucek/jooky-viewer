Attribute VB_Name = "Console_Engine"
Option Explicit
Function IsScript(Script As String) As Boolean
On Error GoTo 1
If FileExists(Script) And LCase(ReadIniFile(Script, "FileInfo", "ID")) = "jooky_script" Then
  IsScript = True
Else
  MsgBox Title:="Jooky-Script", prompt:="File " & Script & "is missing or it isn't valid script", Buttons:=vbExclamation
  IsScript = False
  Exit Function
End If
GoTo 2
1:
DetError Err.Number, "READSCRIPT"
GoTo 2
2:
End Function

Sub Maskot()
On Error GoTo ass
XtrA = GetSetting(appname:="Harley Software", section:="Jooky-Viewer", Key:="GOD_Mode")
If XtrA <> "1" Then
  MsgBox Title:="The Secret Section", prompt:="Nemáš zapnutý tzv. 'GOD mód', ten je potøeba pro vstup do tajné sekce !!!", Buttons:=vbExclamation
  Exit Sub
End If
passwordik = LCase(InputBox("Pro vstup do tajné sekce je nutno nejprve vložit heslo !!!", "The Secret Section"))
ConsoleWrite "PIXVIEWER.SecretSection.init"
Select Case LCase(passwordik)
Case LCase(ReadIniFile("ini\main.ini", "Common", "Heslo"))
    WaitFRM.Show
    DoEvents
    If Not FileExists("data\pictures\secret.65") Then Err.Raise 53
    Sexret.Image1.Picture = LoadPicture("data\pictures\secret.65")
    ConsoleWrite "PIXVIEWER.SecretSection.Password=" & passwordik
    ConsoleWrite "PIXVIEWER.SecretSection=ACCESS ALLOWED"
    ConsoleWrite "Opening secret section ..."
    Sexret.Show
    Unload WaitFRM
Case vbCancel
  Exit Sub
Case Else
  MsgBox Title:="Špatnì !!!", prompt:="Špatné heslo !!!" & Chr(10) & Chr(10) & "ACCESS DENIED !!!"
  ConsoleWrite "PIXVIEWER.SecretSection=ACCESS NOT ALLOWED !!!"
End Select

ass:
If Err.Number = 53 Then
    MsgBox Title:="ERROR", prompt:="Obrázek NEJNI !!!" & Chr(10) & "Zobrazuji náhradní.", Buttons:=vbInformation
    ConsoleWrite "PIXVIEWER.error=NO SECRET PICTURE DETECTED"
    Sexret.Image1.Picture = frmSplash.imglogo
    Sexret.Show
    Exit Sub
End If
End Sub



Sub ConsoleWrite(what As String)
Console.LOGboX.Text = Console.LOGboX.Text & Chr(10) & what
End Sub
Sub WriteLOG()
Open "C:\JKV.LOG" For Output As 1
    Print #1, Console.LOGboX.Text
    Close 1
End Sub


