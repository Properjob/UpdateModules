Module SysUtils
    Function checkRegKey(RegKey As String, Value As String) As Boolean
        Dim shellObj As Object
        Dim Val As String

        On Error GoTo ErrorHandler
        'access Windows scripting
        shellObj = CreateObject("WScript.Shell")
        'try to read the registry key
        Val = shellObj.RegRead(RegKey)
        If Value <> Val Then GoTo ErrorHandler
        'key was found
        checkRegKey = True
        Exit Function

ErrorHandler:
        'key was not found
        checkRegKey = False
    End Function

    Function getRegKeyVal(RegKey As String) As Object
        Dim shellObj As Object
        Dim Val As String

        On Error GoTo ErrorHandler
        'access Windows scripting
        shellObj = CreateObject("WScript.Shell")
        'try to read the registry key
        Val = shellObj.RegRead(RegKey)
        'key was found
        getRegKeyVal = Val
        Exit Function

ErrorHandler:
        'key was not found
        getRegKeyVal = ""
    End Function

    Sub setRegKey(RegKey As String, Value As String)
        Dim shellObj As Object
        On Error GoTo ErrorHandler
        shellObj = CreateObject("WScript.Shell")
        '
        shellObj.RegWrite(RegKey, Value)
ErrorHandler:
    End Sub

    Sub setRegKeyDWord(RegKey As String, Value As Integer)
        Dim shellObj As Object
        On Error GoTo ErrorHandler
        shellObj = CreateObject("WScript.Shell")
        '
        shellObj.RegWrite(RegKey, Value, "REG_DWORD")
ErrorHandler:
    End Sub

End Module

