Imports System.Data.SqlServerCe

Module UserDB
    Private UserCnn As SqlCeConnection

    Public WithEvents HmiUserInfo As New KremerControlsWin32.KremerUserInfo

    Private Sub OpenUserDB()

        UserCnn = New SqlCeConnection("Data Source= " & GetAppDir() & "\Database\User_DB.sdf")
        UserCnn.Open()

    End Sub

    Private Sub CloseUserDB()

        UserCnn.Close()
        UserCnn.Dispose()

    End Sub

    Public Sub ChangeLoginCode(ByVal User As String, ByVal Code As Integer)

        Dim cmd As SqlCeCommand = Nothing
        Try
            OpenUserDB()

            cmd = New SqlCeCommand("update tblUsers set " & _
                "Password=" & Code & _
                " where [Name]='" & User & "'", UserCnn)

            cmd.ExecuteNonQuery()

        Finally
            cmd.Dispose()
            CloseUserDB()

        End Try

    End Sub

    Public Sub ReadAllUsers(ByVal pLstVw As ListView)

        Dim cmd As SqlCeCommand = Nothing
        Dim rdr As SqlCeDataReader = Nothing
        Dim lItem As ListViewItem

        pLstVw.Columns(0).Text = GetSingleLabel(69)

        pLstVw.Items.Clear()
        Try
            OpenUserDB()

            cmd = New SqlCeCommand("select * from tblUsers where Level<999 order by Level;", UserCnn)
            rdr = cmd.ExecuteReader
            ' Iterate through the results
            '
            While rdr.Read()
                Dim User As String = rdr.GetString(1)
                lItem = pLstVw.Items.Add(New ListViewItem(User))
            End While

        Finally
            ' Always call Close when done reading
            rdr.Close()
            rdr.Dispose()
            cmd.Dispose()
            CloseUserDB()
        End Try

    End Sub

    Public Function Login(ByVal Passw As String) As Boolean
        Dim cmd As SqlCeCommand = Nothing
        Dim rdr As SqlCeDataReader = Nothing

        Try
            Login = False
            OpenUserDB()

            cmd = New SqlCeCommand("select * from tblUsers where Password=" & Passw, UserCnn)
            rdr = cmd.ExecuteReader()

            While rdr.Read()
                HmiUserInfo.Name = rdr.GetString(1)
                HmiUserInfo.Level = rdr.GetInt32(2)
                Login = True
            End While

        Finally
            rdr.Close()
            rdr.Dispose()
            cmd.Dispose()
            CloseUserDB()
        End Try
    End Function

    Public Sub LogOut()
        HmiUserInfo.Name = "NONE"
        HmiUserInfo.Level = 0
    End Sub

End Module
