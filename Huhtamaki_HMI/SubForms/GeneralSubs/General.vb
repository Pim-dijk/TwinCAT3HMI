Imports KremerControlsWin32

Public Class General

    Dim WithEvents LoginPad As New KremerControlsWin32.KremerNumPad

    Private Sub InitControls()

        'User level check
        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerButton Then CType(IoCtl, KremerButton).UserInfo = HmiUserInfo
        Next

        'If frmMain.KremerAlarmLogDB.initialised Then
        'BTN_ReinitAlarm.Visible = False
        'Else
        'BTN_ReinitAlarm.Visible = True
        'End If

    End Sub

    Private Sub General_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Disposed
        LoginPad.Dispose()
    End Sub

    Private Sub General_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ParentChanged
        If Not Me.Parent Is Nothing Then
            GetControlLabel(Me.Controls)
            InitControls()


            lblcurrentProduct.Text = CurrentProduct

            If ProductDataLoaded Then
                lblcurrentProduct.ForeColor = Color.Black

            Else
                lblcurrentProduct.ForeColor = Color.Red
            End If

            krConnector.PLC = frmMain.CX1020
            krConnector.VarCollector = Me.krVarCollector
            krConnector.Connect()

        Else
            krConnector.Disconnect()
        End If
    End Sub

    Private Sub btnLang_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLang.Click

        frmLangSel.StartPosition = FormStartPosition.CenterParent

        If frmLangSel.ShowDialog() = Windows.Forms.DialogResult.OK Then
            GetLabel(frmMain)
            GetControlLabel(Me.Controls)
            frmMain.lblTitle.Text = GetSingleLabel(CInt(Me.Tag))
            frmMain.InitAlarmViewer()

            InitControls()
        End If
    End Sub

    Private Sub btnLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        GeneratePasswords()
        LoginPad.PasswordMask = True
        LoginPad.PasswordLenght = 6
        LoginPad.StartPosition = FormStartPosition.CenterParent
        LoginPad.DataType = KremerControlsWin32.KremerNumPad.NumDataType.INT
        LoginPad.InitialValue = ""
        LoginPad.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        LogOut()
        frmMain.sUserName.Data = HmiUserInfo.Name
        frmMain.miUserLevel.Data = HmiUserInfo.Level
        InitControls()

    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If HmiUserInfo.Level >= 800 Then
            KremerAddLogLine("HMI Closed with button")
            frmMain.Close()
        End If
    End Sub

    Private Sub btnCleanScreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCleanScreen.Click
        frmCleanScreen.ShowDialog()
    End Sub

    Private Sub LoginPad_NumPadValueChanged(ByVal Value As Object) Handles LoginPad.NumPadValueChanged
        Dim LoginString As String
        LoginString = LoginPad.Data.ToString

        'passwaord is generated
        If Value.ToString.Length = 6 Then

            If LoginString = Password.AdminCodeString Then
                frmMain.sUserName.Data = "Admin"
                frmMain.miUserLevel.Data = 999

            ElseIf LoginString = EngineerCodeString Then
                frmMain.sUserName.Data = "Engineer"
                frmMain.miUserLevel.Data = 950

            ElseIf LoginString = LocalAdminCodeString Then
                frmMain.sUserName.Data = "Local admin"
                frmMain.miUserLevel.Data = 901

            ElseIf LoginString = SupervisorCodeString Then
                frmMain.sUserName.Data = "Supervisor"
                frmMain.miUserLevel.Data = 811
            End If

        ElseIf Value.ToString.Length = 4 Then 'password is 4 chars long (in user.sdf)
            If Login(Value) Then
                If HmiUserInfo.Level <= 800 Then
                    frmMain.sUserName.Data = HmiUserInfo.Name
                    frmMain.miUserLevel.Data = HmiUserInfo.Level
                Else
                    HmiUserInfo.Name = "None"
                    HmiUserInfo.Level = 0
                    frmMain.sUserName.Data = "None"
                    frmMain.miUserLevel.Data = 0
                    frmMain.krMessage.ShowMessage(GetSingleLabel(49), GetSingleLabel(24))
                End If
            Else
                HmiUserInfo.Name = "None"
                HmiUserInfo.Level = 0
                frmMain.sUserName.Data = "None"
                frmMain.miUserLevel.Data = 0
                frmMain.krMessage.ShowMessage(GetSingleLabel(49), GetSingleLabel(24))
            End If
        Else
            frmMain.krMessage.ShowMessage(GetSingleLabel(49), GetSingleLabel(24))
        End If
        InitControls()
    End Sub

    Private Sub btnUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsers.Click
        frmUsers.StartPosition = FormStartPosition.CenterParent
        frmUsers.ShowDialog()
    End Sub

    Private Sub btnShutDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShutDown.Click
        System.Diagnostics.Process.Start("shutdown", "-s")
    End Sub

    Private Sub ReInitAlarm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmMain.KremerAlarmLogDB.InitDB()
    End Sub


End Class
