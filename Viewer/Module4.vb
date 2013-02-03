Option Strict Off
Option Explicit On
Module DataFile
	
	Public Const DataFileHeader As String = "Jooky_Data_$_"
	Public TempDir As String
	Sub CreateTemp()
		On Error GoTo 1
		If DirExists(Environ("temp") & "\Jooky_$_") Then
			Kill(Environ("temp") & "\Jooky_$_\*.*")
			RmDir(Environ("temp") & "\Jooky_$_")
		End If
		MkDir(Environ("temp") & "\Jooky_$_")
		GoTo 2
1: 
		DetError(Err.Number, "CreateTemp")
		GoTo 2
2: 
	End Sub
	
	
	Sub DeleteTemp()
		On Error GoTo 1
		If DirExists(Environ("temp") & "\Jooky_$_") Then
			Kill(Environ("temp") & "\Jooky_$_\*.*")
			RmDir(Environ("temp") & "\Jooky_$_")
		End If
		GoTo 2
1: 
		DetError(Err.Number, "DeleteTemp")
		GoTo 2
2: 
	End Sub
	
	Sub ExtractFile(ByVal DataFile As String, ByVal Fil As String)
		'On Error GoTo 1
		Dim FajL, hhj As Object
		Dim mEzi, FilX, tempik As Object
		Dim fuJ As String
		Dim FileStart As Object
		Dim FileLength As Boolean
		If Not HeaderOK(DataFile) Then Exit Sub
		'UPGRADE_WARNING: Couldn't resolve default property of object mEzi. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		mEzi = ""
		Select Case ReadIniFile("ini\files.ini", "Cabinet " & UCase(DataFile), Fil & ".Start")
			Case ""
				Err.Raise(53)
				'UPGRADE_WARNING: Couldn't resolve default property of object FileStart. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				FileStart = False
			Case Else
				'UPGRADE_WARNING: Couldn't resolve default property of object FileStart. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				FileStart = True
		End Select
		Select Case ReadIniFile("ini\files.ini", "Cabinet " & UCase(DataFile), Fil & ".Length")
			Case ""
				Err.Raise(53)
				FileLength = False
			Case Else
				FileLength = True
		End Select
		'UPGRADE_WARNING: Couldn't resolve default property of object FileStart. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Not FileStart = True And FileLength = True Then Err.Raise(53)
		FileOpen(1, DataFile, OpenMode.Binary)
		FileOpen(2, TempDir & "\" & Fil, OpenMode.Output)
		Seek(1, CInt(ReadIniFile("ini\files.ini", "Cabinet " & UCase(DataFile), Fil & ".Start")))
		'UPGRADE_ISSUE: InputB function is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="367764E5-F3F8-4E43-AC3E-7FE0B5E074E2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object tempik. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		tempik = InputB(Int(CDbl(ReadIniFile("ini\files.ini", "Cabinet " & UCase(DataFile), Fil & ".Length"))), 1)
		'UPGRADE_ISSUE: Constant vbUnicode was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_WARNING: Couldn't resolve default property of object tempik. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		tempik = StrConv(tempik, vbUnicode)
		'MsgBox tempik
		PrintLine(2, tempik)
		FileClose(2)
		FileClose(1)
		GoTo 2
1: 
		DetError(Err.Number, "EXTRACT_FILE")
		GoTo 2
2: 
	End Sub
	
	
	Function HeaderOK(ByVal FajL As String) As Boolean
		Dim FileNum, firstbytes As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object FileNum. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileNum = FreeFile
		If Not FileExists(FajL) Then
			HeaderOK = False
			Exit Function
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object FileNum. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileOpen(FileNum, FajL, OpenMode.Input)
		'UPGRADE_WARNING: Couldn't resolve default property of object FileNum. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object firstbytes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		firstbytes = InputString(FileNum, Len(DataFileHeader))
		'UPGRADE_WARNING: Couldn't resolve default property of object firstbytes. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HeaderOK = IIf(firstbytes = DataFileHeader, True, False)
		'UPGRADE_WARNING: Couldn't resolve default property of object FileNum. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileClose(FileNum)
	End Function
	
	
	'UPGRADE_NOTE: StR was upgraded to StR_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Function ReadChar(ByVal StR_Renamed As String, ByVal PoS As Short) As String
		Dim TmPx As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object TmPx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		TmPx = Left(StR_Renamed, PoS)
		'UPGRADE_WARNING: Couldn't resolve default property of object TmPx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ReadChar = Right(TmPx, 1)
	End Function
End Module