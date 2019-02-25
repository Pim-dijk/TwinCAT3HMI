Imports KremerControlsWin32

Public Class ProductForming_Overview
    Private Sub InitControls()
        'Get status labels

        'User level check
        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerButton Then CType(IoCtl, KremerButton).UserInfo = HmiUserInfo
        Next

    End Sub

    'Connecting the kremer connector
    Private Sub Pulp_Overview_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ParentChanged
        If Not Me.Parent Is Nothing Then

            'init the language for the labels
            InitControls()

            'Get language for labels
            GetControlLabel(Me.Controls)


            'connect the PLC to the mainfrom plc
            KrConnector.PLC = frmMain.CX1020
            KrConnector.VarCollector = Me.VarCollector
            KrConnector.Connect()
        Else
            KrConnector.Disconnect()
        End If
    End Sub


    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        frmMain.SubFormChange(frmMain.SubSprayBar_Overview)
    End Sub


    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        frmMain.SubFormChange(frmMain.SubMachinePond_Overview)
    End Sub
End Class
