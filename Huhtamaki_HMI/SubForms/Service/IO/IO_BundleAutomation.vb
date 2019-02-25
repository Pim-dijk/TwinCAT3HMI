Imports KremerControlsWin32

Public Class IO_BundleAutomation

    Private Sub InitControls()

        GetStatus(102, BTU_ParkPosition.StatusText)
        GetStatus(103, BTU_X_LimitBack.StatusText)
        GetStatus(104, BTU_X_LimitFront.StatusText)
        GetStatus(105, BTU_Y_LimitLeft.StatusText)
        GetStatus(106, BTU_Y_LimitRight.StatusText)
        GetStatus(107, BTU_Z_LimitUp.StatusText)
        GetStatus(108, BTU_Z_LimitDown.StatusText)
        GetStatus(109, BTU_BundleInGripper.StatusText)
        GetStatus(110, BTU_FingerLeftOpen.StatusText)
        GetStatus(111, BTU_FingerLeftClosed.StatusText)
        GetStatus(112, BTU_FingerRightOpen.StatusText)
        GetStatus(113, BTU_FingerRightClosed.StatusText)
        GetStatus(114, BackDoorLeftOpen.StatusText)
        GetStatus(115, BackDoorLeftClosed.StatusText)
        GetStatus(116, BackDoorRightOpen.StatusText)
        GetStatus(117, BackDoorRightClosed.StatusText)

        For Each StatCtrl As Control In Me.Controls
            If TypeOf StatCtrl Is KremerStatusBox Then CType(StatCtrl, KremerStatusBox).Data = (CInt(btnToggleText.Data) * -1)
        Next

        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
        Next

    End Sub

    Private Sub IO_Outfeed_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ParentChanged
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
