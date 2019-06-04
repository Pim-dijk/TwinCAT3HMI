Imports KremerControlsWin32

Public Class IO_Outfeed

    Private Sub InitControls()

        GetStatus(118, Outfeed_BundleInLift.StatusText)
        GetStatus(119, Outfeed_LimitSwitch1.StatusText)
        GetStatus(120, Outfeed_LimitSwitch2.StatusText)
        GetStatus(121, Outfeed_LiftInPosition.StatusText)
        GetStatus(122, Outfeed_BundleInFingers.StatusText)
        GetStatus(123, Outfeed_FingerLeftIn.StatusText)
        GetStatus(124, Outfeed_FingerLeftOut.StatusText)
        GetStatus(125, Oufteed_FingerRightIn.StatusText)
        GetStatus(126, Oufteed_FingerRightOut.StatusText)
        GetStatus(127, Outfeed_LiftIsUp.StatusText)
        GetStatus(128, Outfeed_LiftIsDown.StatusText)

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
