Attribute VB_Name = "DataFile"
Public Const DataFileHeader = "Jooky_Data_$_"
Public TempDir As String
Sub CreateTemp()
On Error GoTo 1
If DirExists(Environ("temp") & "\Jooky_$_") Then
  Kill Environ("temp") & "\Jooky_$_\*.*"
  RmDir Environ("temp") & "\Jooky_$_"
End If
MkDir Environ("temp") & "\Jooky_$_"
GoTo 2
1:
DetError Err.Number, "CreateTemp"
GoTo 2
2:
End Sub


Sub DeleteTemp()
On Error GoTo 1
If DirExists(Environ("temp") & "\Jooky_$_") Then
  Kill Environ("temp") & "\Jooky_$_\*.*"
  RmDir Environ("temp") & "\Jooky_$_"
End If
GoTo 2
1:
DetError Err.Number, "DeleteTemp"
GoTo 2
2:
End Sub

Sub ExtractFile(ByVal DataFile As String, ByVal Fil As String)
'On Error GoTo 1
Dim FajL, hhj
Dim FilX, mEzi, tempik, fuJ As String
Dim FileStart, FileLength As Boolean
If Not HeaderOK(DataFile) Then Exit Sub
mEzi = ""
Select Case ReadIniFile("ini\files.ini", "Cabinet " & UCase(DataFile), Fil & ".Start")
  Case ""
    Err.Raise 53
    FileStart = False
  Case Else
    FileStart = True
End Select
Select Case ReadIniFile("ini\files.ini", "Cabinet " & UCase(DataFile), Fil & ".Length")
  Case ""
    Err.Raise 53
    FileLength = False
  Case Else
    FileLength = True
End Select
If Not FileStart = True And FileLength = True Then Err.Raise 53
Open DataFile For Binary As #1
Open TempDir & "\" & Fil For Output As #2
Seek 1, ReadIniFile("ini\files.ini", "Cabinet " & UCase(DataFile), Fil & ".Start")
tempik = InputB(Int(ReadIniFile("ini\files.ini", "Cabinet " & UCase(DataFile), Fil & ".Length")), 1)
tempik = StrConv(tempik, vbUnicode)
'MsgBox tempik
Print #2, tempik
Close 2
Close 1
GoTo 2
1:
DetError Err.Number, "EXTRACT_FILE"
GoTo 2
2:
End Sub


Function HeaderOK(ByVal FajL As String) As Boolean
Dim FileNum, firstbytes
FileNum = FreeFile
If Not FileExists(FajL) Then
  HeaderOK = False
  Exit Function
End If
Open FajL For Input As FileNum
  firstbytes = Input(Len(DataFileHeader), #FileNum)
  HeaderOK = IIf(firstbytes = DataFileHeader, True, False)
Close FileNum
End Function


Function ReadChar(ByVal StR As String, ByVal PoS As Integer) As String
Dim TmPx
TmPx = Left(StR, PoS)
ReadChar = Right(TmPx, 1)
End Function


