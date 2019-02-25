Imports System.Data.SqlServerCe
Imports System.Collections.ObjectModel
Module LanguageDB
    Private LangCnn As SqlCeConnection

    Dim LanguageID As Integer = 1
    Dim LabelText(0) As String
    Dim AlarmText(0) As String
    Dim AlarmColumn(3) As String
    Dim CleanScreenLang(2) As String
    Dim StatusText(0, 0) As String
    Private Sub OpenLanguageDB()

        LangCnn = New SqlCeConnection("Data Source= " & GetAppDir() & "\Database\KREMER_DB.sdf")
        LangCnn.Open()

    End Sub

    Private Sub CloseLanguageDB()

        LangCnn.Close()
        LangCnn.Dispose()

    End Sub

    Private Sub SetLanguageID(ByVal LangID As Integer)
        LanguageID = LangID
    End Sub

    Public Function GetLanguageID() As Integer
        Return LanguageID
    End Function

    Public Sub ChangeLanguage(ByVal LangID As Integer)
        OpenLanguageDB()

        CloseLanguageDB()
    End Sub
    Public Sub ReadLanguage(ByVal pLstVw As ListView)

        Dim cmd As SqlCeCommand = Nothing
        Dim rdr As SqlCeDataReader = Nothing
        Dim lItem As ListViewItem = Nothing


        pLstVw.Items.Clear()
        Try
            OpenLanguageDB()

            cmd = New SqlCeCommand("select * from tblLanguage order by ID;", LangCnn)
            rdr = cmd.ExecuteReader
            ' Iterate through the results
            '
            While rdr.Read()
                Dim LangID As Integer = rdr.GetInt32(0)
                Dim Language As String = rdr.GetString(1)
                lItem = pLstVw.Items.Add(New ListViewItem(CStr(LangID)))
                lItem.SubItems.Add(Language)
            End While
        Finally
            ' Always call Close when done reading
            rdr.Close()
            rdr.Dispose()
            cmd.Dispose()
            CloseLanguageDB()
        End Try
    End Sub
    Private Sub ResetCurrentLanguage()
        Dim cmd As New SqlCeCommand

        Try
            cmd.Connection = LangCnn
            cmd.CommandText = "update tblLanguage set Active=0;"
            cmd.ExecuteNonQuery()
        Finally
            cmd.Dispose()
        End Try
    End Sub
    Public Sub SetCurrentLanguage(ByVal LangID As Integer)
        Dim cmd As New SqlCeCommand

        Try
            OpenLanguageDB()
            ResetCurrentLanguage()
            cmd.Connection = LangCnn
            cmd.CommandText = "update tblLanguage set Active=1 where ID=" & LangID & ";"
            cmd.ExecuteNonQuery()

            ReadLabelText(LangID)
            ReadAlarmText(LangID)
            ReadStatusText(LangID)
            SetLanguageID(LangID)

        Finally
            cmd.Dispose()
            CloseLanguageDB()
        End Try


    End Sub
    Public Function CurrentLanguage() As Integer
        Dim cmd As SqlCeCommand = Nothing
        Dim rdr As SqlCeDataReader = Nothing
        Dim Language As Integer
        Try
            OpenLanguageDB()

            cmd = New SqlCeCommand("select ID from tblLanguage where Active=1;", LangCnn)
            rdr = cmd.ExecuteReader
            ' Iterate through the results
            '
            While rdr.Read()
                Language = rdr.GetInt32(0)
            End While

            ReadLabelText(Language)
            ReadAlarmText(Language)
            ReadStatusText(Language)
            SetLanguageID(Language)
        Finally
            ' Always call Close when done reading
            rdr.Close()
            rdr.Dispose()
            cmd.Dispose()
            CloseLanguageDB()
        End Try

    End Function

    Private Sub ReadLabelText(ByVal LangID As Integer)

        Dim cmd As SqlCeCommand = Nothing
        Dim rdr As SqlCeDataReader = Nothing

        Try

            cmd = New SqlCeCommand("select LabelID, Text from tblLabelText where LangID=" & _
            LangID & " order by LabelID;", LangCnn)
            rdr = cmd.ExecuteReader
            ' Iterate through the results
            '
            ReDim LabelText(0)

            While rdr.Read()
                Dim LabelID As Integer = rdr.GetInt32(0)
                Dim Label As String = rdr.GetString(1)
                ReDim Preserve LabelText(LabelID)
                LabelText(LabelID) = Label
            End While
        Finally
            ' Always call Close when done reading
            rdr.Close()
            rdr.Dispose()
            cmd.Dispose()
        End Try

    End Sub
    Private Sub ReadAlarmText(ByVal LangID As Integer)

        Dim cmd As SqlCeCommand = Nothing
        Dim rdr As SqlCeDataReader = Nothing

        Try

            cmd = New SqlCeCommand("select AlarmID, Text from tblAlarmText where LangID=" & _
            LangID & " order by AlarmID;", LangCnn)
            rdr = cmd.ExecuteReader
            ' Iterate through the results
            '
            ReDim AlarmText(0)

            While rdr.Read()
                Dim AlarmID As Integer = rdr.GetInt32(0)
                Dim Text As String = rdr.GetString(1)
                ReDim Preserve AlarmText(AlarmID)
                AlarmText(AlarmID) = Text
            End While
        Finally
            ' Always call Close when done reading
            rdr.Close()
            rdr.Dispose()
            cmd.Dispose()
        End Try

    End Sub

    Private Sub ReadStatusText(ByVal LangID As Integer)

        Dim cmd As SqlCeCommand = Nothing
        Dim rdr As SqlCeDataReader = Nothing

        Try

            cmd = New SqlCeCommand("select max(cycle) as MaxCycle, max(State) as MaxState from tblStatusText", LangCnn)
            rdr = cmd.ExecuteReader
            While rdr.Read()
                Dim MaxCycle As Integer = rdr.GetValue(0)
                Dim MaxState As Integer = rdr.GetValue(1)
                ReDim StatusText(MaxCycle, MaxState)
            End While

            cmd.CommandText = "select Cycle, State, Text from tblStatusText where LangID=" & _
            LangID & " order by Cycle, State;"
            cmd.Connection = LangCnn
            rdr = cmd.ExecuteReader
            ' Iterate through the results
            '

            While rdr.Read()
                Dim Cycle As Integer = rdr.GetInt32(0)
                Dim State As Integer = rdr.GetInt32(1)
                Dim Status As String = rdr.GetString(2)

                StatusText(Cycle, State) = Status
            End While
        Finally
            ' Always call Close when done reading
            rdr.Close()
            rdr.Dispose()
            cmd.Dispose()
        End Try

    End Sub

    Public Sub GetLabel(ByRef fForm As Form)
        Dim cCtrl As Control

        For Each cCtrl In fForm.Controls
            If Not IsNothing(cCtrl.Tag) And Not cCtrl.Tag = "" Then
                If Not CInt(cCtrl.Tag) > LabelText.GetUpperBound(0) Then
                    cCtrl.Text = LabelText(CInt(cCtrl.Tag))
                Else
                    cCtrl.Text = ""
                End If
            End If
        Next
    End Sub
    Public Sub GetControlLabel(ByRef LanguageControls As Object)
        Dim cCtrl As Control

        For Each cCtrl In LanguageControls
            If Not IsNothing(cCtrl.Tag) And Not cCtrl.Tag = "" Then
                If Not CInt(cCtrl.Tag) > LabelText.GetUpperBound(0) Then
                    cCtrl.Text = LabelText(CInt(cCtrl.Tag))
                Else
                    cCtrl.Text = ""
                End If
            End If
        Next
    End Sub
    Public Function GetSingleLabel(ByVal LabelID As Integer) As String
        If Not LabelID > LabelText.GetUpperBound(0) Then
            Return LabelText(LabelID)
        Else
            Return ""
        End If
    End Function

    Public Sub GetAlarmText(ByRef Alarms As Collection(Of String))
        Dim i As Integer

        Alarms.Clear()

        For i = 0 To AlarmText.GetUpperBound(0)
            Alarms.Add(AlarmText(i))
        Next

    End Sub

    Public Function GetStatusText(ByVal CycleID As Integer, ByVal StateID As Integer) As String
        If Not CycleID > StatusText.GetUpperBound(0) And Not StateID > StatusText.GetUpperBound(1) Then
            Return StatusText(CycleID, StateID)
        Else
            Return ""
        End If
    End Function

    Public Sub GetStatus(ByVal CycleID As Integer, ByRef Status() As String)
        If Not CycleID > StatusText.GetUpperBound(0) Then
            ReDim Status(StatusText.GetUpperBound(1))
            For i As Integer = 0 To StatusText.GetUpperBound(1)
                Status(i) = StatusText(CycleID, i)
            Next
        End If
    End Sub

    Public Sub GetStateText(ByRef State() As String, ByVal FalseId As Integer, ByVal TrueId As Integer)
        If State.GetUpperBound(0) >= 1 Then
            State(0) = "False"
            State(1) = "True"
            If Not FalseId > LabelText.GetUpperBound(0) Then State(0) = LabelText(FalseId)
            If Not TrueId > LabelText.GetUpperBound(0) Then State(1) = LabelText(TrueId)
        End If
    End Sub

    Public Sub GetComboItems(ByRef cCombo As ComboBox, ByRef iItems() As Integer)
        Dim i As Integer
        cCombo.Items.Clear()

        For i = 0 To iItems.GetUpperBound(0)
            cCombo.Items.Add(LabelText(iItems(i)))
        Next

    End Sub

    Public Sub GetAlarmColumns(ByVal Columns() As Integer, ByRef ColumnText() As String)
        For i As Integer = 0 To Columns.GetUpperBound(0)
            If CInt(Columns(i)) <> 0 Then
                ColumnText(i) = LabelText(Columns(i))
            End If
        Next
    End Sub
    Public Sub GetCleanScreenLanguages(ByVal CleanScreenTags() As Integer, ByRef CleanScreenLang() As String)
        For i As Integer = 0 To CleanScreenTags.GetUpperBound(0)
            If CInt(CleanScreenTags(i)) <> 0 Then
                CleanScreenLang(i) = LabelText(CleanScreenTags(i))
            End If
        Next
    End Sub

End Module
