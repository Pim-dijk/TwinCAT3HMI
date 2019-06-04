Imports KremerControlsWin32

Public Class IO_VDenester

    Private Sub InitControls()

        GetStatus(78, VD_BS_Level60.StatusText)
        GetStatus(79, VD_BS_LvlDropBundle.StatusText)
        GetStatus(80, VD_BS_Level10.StatusText)
        GetStatus(81, VD_BS_LvlEmpty1.StatusText)
        GetStatus(82, VD_BS_LvlEmpty2.StatusText)
        GetStatus(85, VD_BS_ClampLeftOff.StatusText)
        GetStatus(86, VD_BS_ClampRightOff.StatusText)
        GetStatus(87, VD_BS_SeperatorOn.StatusText)
        GetStatus(88, VD_BS_SeperatorOff.StatusText)
        GetStatus(89, VD_BS_ForcedLimitSens.StatusText)
        GetStatus(90, VD_PH_ProdSensor.StatusText)
        GetStatus(91, VD_PH_LimitSensLeft.StatusText)
        GetStatus(92, VD_PH_LimitSensRight.StatusText)
        GetStatus(93, VD_CL_NeedleLeftOff.StatusText)
        GetStatus(94, VD_CL_NeedleRightOff.StatusText)
        GetStatus(95, VD_CL_HomingSens.StatusText)
        GetStatus(96, VD_CL_NeedleLeftOn.StatusText)
        GetStatus(97, VD_CL_NeedleRightOn.StatusText)
        GetStatus(98, VD_HTD_ProductSens.StatusText)
        GetStatus(99, VD_HTD_LimitSensLeft.StatusText)
        GetStatus(100, VD_HTD_LimitSensRight.StatusText)
        GetStatus(101, VD_HTD_HighProduct.StatusText)

        For Each StatCtrl As Control In Me.Controls
            If TypeOf StatCtrl Is KremerStatusBox Then CType(StatCtrl, KremerStatusBox).Data = (CInt(btnToggleText.Data) * -1)
        Next

        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
        Next

    End Sub

    Private Sub IO_Zipper_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ParentChanged
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
