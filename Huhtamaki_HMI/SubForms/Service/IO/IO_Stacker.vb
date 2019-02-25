Imports KremerControlsWin32

Public Class IO_Stacker

    Private Sub InitControls()

        GetStatus(36, PressHighProd.StatusText)
        GetStatus(37, PickUp_LimitSwitch0.StatusText)
        GetStatus(38, PickUp_LimitSwitch180.StatusText)
        GetStatus(39, PickUp_ProdHeadA.StatusText)
        GetStatus(40, PickUp_ProdHeadB.StatusText)
        GetStatus(41, StackGrid_HighProdA.StatusText)
        GetStatus(42, StackGrid_HighProdB.StatusText)
        GetStatus(43, StackGrid_Up.StatusText)
        GetStatus(44, StackGrid_Down.StatusText)
        GetStatus(45, Stop_FrontAUp.StatusText)
        GetStatus(46, Stop_FrontADown.StatusText)
        GetStatus(47, Stop_RearAUp.StatusText)
        GetStatus(48, Stop_RearADown.StatusText)
        GetStatus(49, Stop_FrontBUp.StatusText)
        GetStatus(50, Stop_FrontBDown.StatusText)
        GetStatus(51, Stop_RearBUp.StatusText)
        GetStatus(52, Stop_RearBDown.StatusText)
        GetStatus(53, LiftA_SwitchUp.StatusText)
        GetStatus(54, LiftA_SwitchDown.StatusText)
        GetStatus(55, LiftA_HomSensor.StatusText)
        GetStatus(57, LiftA_GridFrontClose.StatusText)
        GetStatus(59, LiftA_GridRearClose.StatusText)
        GetStatus(60, LiftB_SwitchUp.StatusText)
        GetStatus(61, LiftB_SwitchDown.StatusText)
        GetStatus(62, LiftB_HomSensor.StatusText)
        GetStatus(64, LiftB_GridFrontClose.StatusText)
        GetStatus(66, LiftB_GridRearClose.StatusText)

        For Each StatCtrl As Control In Me.Controls
            If TypeOf StatCtrl Is KremerStatusBox Then CType(StatCtrl, KremerStatusBox).Data = (CInt(btnToggleText.Data) * -1)
        Next

        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
        Next

    End Sub

    Private Sub IO_Stacker_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ParentChanged
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


    Private Sub IO_Zipper_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
