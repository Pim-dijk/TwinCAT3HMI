Imports KremerControlsWin32

Public Class IO_Zipper

    Private Sub InitControls()

        GetStatus(5, ZipperHomingSensor.StatusText)
        GetStatus(6, ZipperHighProduct.StatusText)
        GetStatus(7, UpperInfHomSensA.StatusText)
        GetStatus(8, UpperInfHomSensB.StatusText)
        GetStatus(9, UpperInfIsUp.StatusText)
        GetStatus(10, UpperInfIsDown.StatusText)
        GetStatus(11, TelHomingSensor.StatusText)
        GetStatus(12, TelLimitSwitch.StatusText)
        GetStatus(13, TelBeltIn.StatusText)
        GetStatus(14, CartonAtStop1.StatusText)
        GetStatus(15, CartonAtStop2A.StatusText)
        GetStatus(16, CartonAtStop2B.StatusText)
        GetStatus(17, Stop1UpA.StatusText)
        GetStatus(18, Stop1UpB.StatusText)
        GetStatus(19, Stop1DownA.StatusText)
        GetStatus(20, Stop1DownB.StatusText)
        GetStatus(21, Stop2UpA.StatusText)
        GetStatus(22, Stop2UpB.StatusText)
        GetStatus(23, Stop2DownA.StatusText)
        GetStatus(24, Stop2DownB.StatusText)
        GetStatus(25, CartonInPockA.StatusText)
        GetStatus(26, CartonInPockB.StatusText)
        GetStatus(27, TIB_ProdFree.StatusText)
        GetStatus(28, TIB_ProdSens1.StatusText)
        GetStatus(29, TIB_ProdSens2.StatusText)
        GetStatus(30, TIB_ProdSens3.StatusText)
        GetStatus(31, TIB_ProdSens4.StatusText)
        GetStatus(32, TIB_ProdSens5.StatusText)
        GetStatus(33, TIB_ProdSens6.StatusText)
        GetStatus(34, TIB_StopperUp.StatusText)
        GetStatus(35, TIB_StopperDown.StatusText)

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
