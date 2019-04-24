Imports KremerControlsWin32

Public Class MachinePond_Settings_New

    Private Sub InitControls()
        'User level check
        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
        Next
    End Sub


    'Connecting the kremer connector
    Private Sub MachinePond_Settings_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ParentChanged
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
        frmMain.SubFormChange(frmMain.SubMachinePond_Overview)
    End Sub

    Private Sub Btn_Manual_Click(sender As Object, e As EventArgs) Handles Btn_Manual.Click
        frmMain.SubFormChange(frmMain.SubMachinePond_Manual)
    End Sub

    Private Sub mxAutomode_DataChanged(sender As Object, e As EventArgs) Handles mxAutomode.DataChanged
        Btn_Manual.Enabled = Not mxAutomode.Data
    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub
End Class
