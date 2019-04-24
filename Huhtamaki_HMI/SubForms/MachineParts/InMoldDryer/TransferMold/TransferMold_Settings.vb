Imports KremerControlsWin32

Public Class TransferMold_Settings

    Private Sub InitControls()
        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
        Next
    End Sub

    Private Sub TransferMold_Settings_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ParentChanged
        If Not Me.Parent Is Nothing Then

            InitControls()

            GetControlLabel(Me.Controls)

            KrConnector.PLC = frmMain.CX1020
            KrConnector.VarCollector = Me.VarCollector
            KrConnector.Connect()
        Else
            KrConnector.Disconnect()
        End If
    End Sub

    Private Sub Btn_Overview_Click(sender As Object, e As EventArgs) Handles Btn_Overview.Click
        frmMain.SubFormChange(frmMain.SubTransferMold_Overview)
    End Sub

    Private Sub Btn_Manual_Click(sender As Object, e As EventArgs) Handles Btn_Manual.Click
        frmMain.SubFormChange(frmMain.SubTransferMold_Manual)
    End Sub

    Private Sub Btn_Settings2_Click(sender As Object, e As EventArgs) Handles Btn_Settings2.Click
        frmMain.SubFormChange(frmMain.SubTransferMold_Settings2)
    End Sub

    Private Sub mxAutomode_DataChanged(sender As Object, e As EventArgs) Handles mxAutomode.DataChanged
        Btn_Manual.Enabled = Not mxAutomode.Data
    End Sub

End Class
