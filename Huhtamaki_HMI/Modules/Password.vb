Module Password
    Public Days, Years, Month, DayYear, AdminCode, EngineerCode, LocalAdminCode, SupervisorCode As Double
    Public AdminCodeString, EngineerCodeString, LocalAdminCodeString, SupervisorCodeString As String

    Public Sub GeneratePasswords()
        Days = Now.DayOfYear
        Years = Now.Year
        Month = Now.Month
        DayYear = Days * 10000 + Years

        AdminCode = DayYear ^ 2 * Math.PI
        EngineerCode = 13 * DayYear ^ 2 + 13 * DayYear + 13
        LocalAdminCode = Math.Sqrt(13 * DayYear ^ 3 + 13 * DayYear ^ 2 + 13 * DayYear + 13)
        SupervisorCode = 13 * Month * Years ^ 2 + 13 * Years * Month + 13 * Years + 13

        AdminCodeString = 7 & Strings.Mid(AdminCode.ToString, 3, 5)
        EngineerCodeString = 3 & Strings.Mid(EngineerCode.ToString, 4, 5)
        LocalAdminCodeString = 5 & Strings.Mid(LocalAdminCode.ToString, 3, 5)
        SupervisorCodeString = 1 & Strings.Mid(SupervisorCode.ToString, 2, 5)

    End Sub
End Module
