Module Kremer_HMI
    Dim AppDir As String
    Dim NumPadAsPassw As Boolean
    Dim NumPadValue As String
    Dim UpperBound As Double
    Dim LowerBound As Double
    Dim ErrorMessage As String
    Public ManualScreens() As Integer = {103, 104}
    Public SettingScreens() As Integer = {100, 101, 102}
    Public AlarmColumns() As Integer = {0, 7, 14, 8}
    Public CleanScreenTags() As Integer = {56, 57}

    Public Const BasicHeight As Single = 600
    Public Const BasicWidth As Single = 800

    Public Sub SetErrorMessage(ByVal sMessage As String)
        ErrorMessage = sMessage
    End Sub
    Public Function GetErrorMessage() As String
        GetErrorMessage = ErrorMessage
    End Function

    Public Sub SetNumPadValue(ByVal sValue As String)
        NumPadValue = sValue
    End Sub
    Public Function GetNumPadValue() As String
        GetNumPadValue = NumPadValue
    End Function
    Public Sub SetNumPadAsPassw(ByVal bEnable As Boolean)
        NumPadAsPassw = bEnable
    End Sub
    Public Function GetNumPadAsPassw() As Boolean
        GetNumPadAsPassw = NumPadAsPassw
    End Function
    Public Sub SetAppDir(ByVal sAppdir As String)
        AppDir = sAppdir
    End Sub

    Public Function GetAppDir() As String
        GetAppDir = AppDir
    End Function

    Public Sub SetUpperBound(ByVal dValue As Double)
        UpperBound = dValue
    End Sub

    Public Function GetUpperBound() As Double
        GetUpperBound = UpperBound
    End Function

    Public Sub SetLowerBound(ByVal dValue As Double)
        LowerBound = dValue
    End Sub

    Public Function GetLowerBound() As Double
        GetLowerBound = LowerBound
    End Function
End Module
