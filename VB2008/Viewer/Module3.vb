Option Strict Off
Option Explicit On
Module Jooky00
	Public mstrLastCreatedShellGroup As String
	Declare Function OSfCreateShellGroup Lib "JOOKY00.DLL"  Alias "fCreateShellFolder"(ByVal lpstrDirName As String) As Integer
	Declare Function OSfCreateShellLink Lib "JOOKY00.DLL"  Alias "fCreateShellLink"(ByVal lpstrFolderName As String, ByVal lpstrLinkName As String, ByVal lpstrLinkPath As String, ByVal lpstrLinkArguments As String) As Integer
	Declare Function OSfRemoveShellLink Lib "JOOKY00.DLL"  Alias "fRemoveShellLink"(ByVal lpstrFolderName As String, ByVal lpstrLinkName As String) As Integer
	
	Const gstrSEP_DIR As String = "\"
	'-----------------------------------------------------------
	' FUNCTION: DirExists
	'
	' Determines whether the specified directory name exists.
	' This function is used (for example) to determine whether
	' an installation floppy is in the drive by passing in
	' something like 'A:\'.
	'
	' IN: [strDirName] - name of directory to check for
	'
	' Returns: True if the directory exists, False otherwise
	'-----------------------------------------------------------
	'
	Function DirExists(ByVal strDirName As String) As Short
		Const strWILDCARD As String = "*.*"
		Const ATTR_DIRECTORY As Short = 16
		Const gstrNULL As String = ""
		
		Dim strDummy As String
		
		On Error Resume Next
		
		AddDirSep(strDirName)
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		strDummy = Dir(strDirName & strWILDCARD, FileAttribute.Directory)
#If Win16 Then
		'UPGRADE_NOTE: #If #EndIf block was not upgraded because the expression Win16 did not evaluate to True or was not evaluated. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="27EE2C3C-05AF-4C04-B2AF-657B4FB6B5FC"'
		DirExists = IIf(Err, False, True)
#Else
		DirExists = IIf(strDummy = gstrNULL, False, True)
#End If
		
		Err.Clear()
	End Function
	'-----------------------------------------------------------
	' SUB: AddDirSep
	' Add a trailing directory path separator (back slash) to the
	' end of a pathname unless one already exists
	'
	' IN/OUT: [strPathName] - path to add separator to
	'-----------------------------------------------------------
	'
	Sub AddDirSep(ByRef strPathName As String)
		If Right(RTrim(strPathName), Len(gstrSEP_DIR)) <> gstrSEP_DIR Then
			strPathName = RTrim(strPathName) & gstrSEP_DIR
		End If
	End Sub
	
	'-----------------------------------------------------------
	' FUNCTION: FileExists
	' Determines whether the specified file exists
	'
	' IN: [strPathName] - file to check for
	'
	' Returns: True if file exists, False otherwise
	'-----------------------------------------------------------
	'
	Function FileExists(ByVal strPathName As String) As Short
		Dim intFileNum As Short
		On Error Resume Next
		
		'
		'Remove any trailing directory separator character
		'
		If Right(strPathName, 1) = gstrSEP_DIR Then
			strPathName = Left(strPathName, Len(strPathName) - 1)
		End If
		
		'
		'Attempt to open the file, return value of this function is False
		'if an error occurs on open, True otherwise
		'
		intFileNum = FreeFile
		FileOpen(intFileNum, strPathName, OpenMode.Input)
		
		FileExists = IIf(Err.Number, False, True)
		
		FileClose(intFileNum)
		
		Err.Clear()
	End Function
	
	
	Sub CenterForm(ByRef frm As System.Windows.Forms.Form)
		
		frm.Top = VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) * 0.85) \ 2 - VB6.PixelsToTwipsY(frm.Height) \ 2)
		frm.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) \ 2 - VB6.PixelsToTwipsX(frm.Width) \ 2)
		
	End Sub
	
	'-----------------------------------------------------------
	' SUB: CreateShellGroup
	'
	' Creates a new program group off of Start>Programs in the
	' Windows 95 shell if the specified folder doesn't already exist.
	'
	' IN: [strFolderName] - text name of the folder.
	'                      This parameter may not contain
	'                      backslashes.
	'                      ex: "My Application" - this creates
	'                        the folder Start>Programs>My Application
	'-----------------------------------------------------------
	'
	
	Sub CreateShellGroup(ByVal strFolderName As String)
		
		ReplaceDoubleQuotes(strFolderName)
		
		'Save this folder name for use with the next call
		'to CreateShellLink()
		mstrLastCreatedShellGroup = strFolderName
		
		If strFolderName = "" Then
			Exit Sub
		End If
		
Retry: 
		Dim fSuccess As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object fSuccess. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		fSuccess = OSfCreateShellGroup(strFolderName)
		'   MsgBox mstrLastCreatedShellGroup
	End Sub
	
	'-----------------------------------------------------------
	' SUB: CreateShellLink
	'
	' Creates (or replaces) a link in either Start>Programs or
	' any of its immediate subfolders in the Windows 95 shell.
	'
	' IN: [strLinkPath] - full path to the target of the link
	'                     Ex: 'c:\Program Files\My Application\MyApp.exe"
	'     [strLinkArguments] - command-line arguments for the link
	'                     Ex: '-f -c "c:\Program Files\My Application\MyApp.dat" -q'
	'     [strLinkName] - text caption for the link
	'     [fLog] - Whether or not to write to the logfile (default
	'                is true if missing)
	'
	' OUT:
	'   The link will be created in the most recent folder created
	'   by a call to CreateShellGroup.  If this function has
	'   never been called, then the link will be created directly
	'   in the Start>Programs menu, and not in any subfolder.
	
	'-----------------------------------------------------------
	'
	Sub CreateShellLink(ByVal strLinkPath As String, ByVal strLinkArguments As String, ByVal strLinkName As String)
		
		ReplaceDoubleQuotes(strLinkName)
		
Retry: 
		
		Dim fSuccess As Boolean
		fSuccess = OSfCreateShellLink(mstrLastCreatedShellGroup & "", strLinkName, strLinkPath, strLinkArguments & "") 'the path should never be enclosed in double quotes
	End Sub
	
	'-----------------------------------------------------------
	' SUB: RemoveShellLink
	'
	' Removes a link in either Start>Programs or any of its
	' immediate subfolders in the Windows 95 shell.
	'
	' IN: [strFolderName] - text name of the immediate folder
	'                       in which the link to be removed
	'                       currently exists, or else the
	'                       empty string ("") to indicate that
	'                       the link can be found directly in
	'                       the Start>Programs menu.
	'     [strLinkName] - text caption for the link
	'
	' This action is never logged in the app removal logfile.
	'
	' PRECONDITION: strFolderName has already been created and is
	'               an immediate subfolder of Start>Programs, if it
	'               is not equal to ""
	'-----------------------------------------------------------
	'
	Sub RemoveShellLink(ByVal strFolderName As String, ByVal strLinkName As String)
		Dim fSuccess As Boolean
		
		ReplaceDoubleQuotes(strFolderName)
		ReplaceDoubleQuotes(strLinkName)
		
		fSuccess = OSfRemoveShellLink(strFolderName, strLinkName)
		MsgBox(fSuccess)
	End Sub
	
	'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Public Sub ReplaceDoubleQuotes(ByRef str_Renamed As String)
		Dim i As Short
		
		For i = 1 To Len(str_Renamed)
			If Mid(str_Renamed, i, 1) = """" Then
				Mid(str_Renamed, i, 1) = "'"
			End If
		Next i
	End Sub
	
	'-----------------------------------------------------------
	' FUNCTION: GetFileSize
	'
	' Determine the size (in bytes) of the specified file
	'
	' IN: [strFileName] - name of file to get size of
	'
	' Returns: size of file in bytes, or -1 if an error occurs
	'-----------------------------------------------------------
	'
	Function GetFileSize(ByRef strFileName As String) As Integer
		On Error Resume Next
		
		GetFileSize = FileLen(strFileName)
		
		If Err.Number > 0 Then
			GetFileSize = -1
			Err.Clear()
		End If
	End Function
	
	'-----------------------------------------------------------
	' SUB: UpdateStatus
	'
	' "Fill" (by percentage) inside the PictureBox and also
	' display the percentage filled
	'
	' IN: [pic] - PictureBox used to bound "fill" region
	'     [sngPercent] - Percentage of the shape to fill
	'     [fBorderCase] - Indicates whether the percentage
	'        specified is a "border case", i.e. exactly 0%
	'        or exactly 100%.  Unless fBorderCase is True,
	'        the values 0% and 100% will be assumed to be
	'        "close" to these values, and 1% and 99% will
	'        be used instead.
	'
	' Notes: Set AutoRedraw property of the PictureBox to True
	'        so that the status bar and percentage can be auto-
	'        matically repainted if necessary
	'-----------------------------------------------------------
	'
	Sub UpdateStatus(ByRef pic As System.Windows.Forms.PictureBox, ByVal sngPercent As Single, Optional ByVal fBorderCase As Object = Nothing)
		Dim strPercent As String
		Dim intX As Short
		Dim intY As Short
		Dim intWidth As Short
		Dim intHeight As Short
		
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		'UPGRADE_WARNING: Couldn't resolve default property of object fBorderCase. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If IsNothing(fBorderCase) Then fBorderCase = False
		
		'For this to work well, we need a white background and any color foreground (blue)
		Const colBackground As Integer = &HFFFFFF ' white
		Const colForeground As Integer = &H800000 ' dark blue
		
		pic.ForeColor = System.Drawing.ColorTranslator.FromOle(colForeground)
		pic.BackColor = System.Drawing.ColorTranslator.FromOle(colBackground)
		
		'
		'Format percentage and get attributes of text
		'
		Dim intPercent As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object intPercent. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		intPercent = Int(100 * sngPercent + 0.5)
		
		'Never allow the percentage to be 0 or 100 unless it is exactly that value.  This
		'prevents, for instance, the status bar from reaching 100% until we are entirely done.
		'UPGRADE_WARNING: Couldn't resolve default property of object intPercent. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If intPercent = 0 Then
			If Not fBorderCase Then
				'UPGRADE_WARNING: Couldn't resolve default property of object intPercent. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				intPercent = 1
			End If
			'UPGRADE_WARNING: Couldn't resolve default property of object intPercent. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ElseIf intPercent = 100 Then 
			If Not fBorderCase Then
				'UPGRADE_WARNING: Couldn't resolve default property of object intPercent. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				intPercent = 99
			End If
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object intPercent. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		strPercent = VB6.Format(intPercent) & "%"
		'UPGRADE_ISSUE: PictureBox method pic.TextWidth was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		intWidth = pic.TextWidth(strPercent)
		'UPGRADE_ISSUE: PictureBox method pic.TextHeight was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		intHeight = pic.TextHeight(strPercent)
		
		'
		'Now set intX and intY to the starting location for printing the percentage
		'
		intX = VB6.PixelsToTwipsX(pic.Width) / 2 - intWidth / 2
		intY = VB6.PixelsToTwipsY(pic.Height) / 2 - intHeight / 2
		
		'
		'Need to draw a filled box with the pics background color to wipe out previous
		'percentage display (if any)
		'
		'UPGRADE_ISSUE: PictureBox property pic.DrawMode was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		pic.DrawMode = 13 ' Copy Pen
		'UPGRADE_ISSUE: PictureBox method pic.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		pic.Line (intX, intY) - Step(intWidth, intHeight), System.Drawing.ColorTranslator.ToOle(pic.BackColor), BF
		
		'
		'Back to the center print position and print the text
		'
		'UPGRADE_ISSUE: PictureBox property pic.CurrentX was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		pic.CurrentX = intX
		'UPGRADE_ISSUE: PictureBox property pic.CurrentY was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		pic.CurrentY = intY
		'UPGRADE_ISSUE: PictureBox method pic.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		pic.Print(strPercent)
		
		'
		'Now fill in the box with the ribbon color to the desired percentage
		'If percentage is 0, fill the whole box with the background color to clear it
		'Use the "Not XOR" pen so that we change the color of the text to white
		'wherever we touch it, and change the color of the background to blue
		'wherever we touch it.
		'
		'UPGRADE_ISSUE: PictureBox property pic.DrawMode was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
		pic.DrawMode = 10 ' Not XOR Pen
		If sngPercent > 0 Then
			'UPGRADE_ISSUE: PictureBox method pic.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			pic.Line (0, 0) - (VB6.PixelsToTwipsX(pic.Width) * sngPercent, VB6.PixelsToTwipsY(pic.Height)), System.Drawing.ColorTranslator.ToOle(pic.ForeColor), BF
		Else
			'UPGRADE_ISSUE: PictureBox method pic.Line was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			pic.Line (0, 0) - (VB6.PixelsToTwipsX(pic.Width), VB6.PixelsToTwipsY(pic.Height)), System.Drawing.ColorTranslator.ToOle(pic.BackColor), BF
		End If
		
		pic.Refresh()
	End Sub
End Module