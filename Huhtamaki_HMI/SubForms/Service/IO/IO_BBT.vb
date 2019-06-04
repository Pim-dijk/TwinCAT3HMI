Imports KremerControlsWin32

Public Class IO_BBT

    Private Sub InitControls()

        GetStatus(67, BBT_A_HomSensor.StatusText)
        GetStatus(68, BBT_A_LimitSwitch.StatusText)
        GetStatus(69, BBT_A_PillarSens.StatusText)
        GetStatus(70, BBT_A_Up.StatusText)
        GetStatus(71, BBT_A_Down.StatusText)
        GetStatus(72, BBT_B_HomSensor.StatusText)
        GetStatus(73, BBT_B_LimitSwitch.StatusText)
        GetStatus(74, BBT_B_PillarSens.StatusText)
        GetStatus(75, BBT_B_Up.StatusText)
        GetStatus(76, BBT_B_Down.StatusText)
        GetStatus(77, Bundle_BBT_Lift.StatusText)

        For Each StatCtrl As Control In Me.Controls
            If TypeOf StatCtrl Is KremerStatusBox Then CType(StatCtrl, KremerStatusBox).Data = (CInt(btnToggleText.Data) * -1)
        Next

        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
        Next

    End Sub

    Private Sub IO_BBT_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ParentChanged
        If Not Me.Parent Is Nothing Then

            'init the language for the labels
            InitControls()

            GetControlLabel(Me.Controls)

            'connect the PLC to the mainfrom plc
            KrConnector.PLC = frmMain.CX1020
            KrConnector.VarCollector = Me.VarCollector
            KrConnector.Connect()
        Else
            KrConnector.Disconnect()
        End If
    End Sub

    Private Sub Btn_Overview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Overview.Click
        frmMain.SubFormChange(frmMain.SubIoOverview)
    End Sub

    Private Sub btnToggleText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToggleText.Click
        For Each StatCtrl As Control In Me.Controls
            If TypeOf StatCtrl Is KremerStatusBox Then CType(StatCtrl, KremerStatusBox).Data = (CInt(btnToggleText.Data) * -1)
        Next
    End Sub

End Class
