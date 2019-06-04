Imports KremerControlsWin32

Public Class ServiceSettings

    Private Sub InitControls()
        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerButton Then CType(IoCtl, KremerButton).UserInfo = HmiUserInfo
        Next

    End Sub

    Private Sub Service_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ParentChanged
        If Not Me.Parent Is Nothing Then
            GetControlLabel(Me.Controls)
            InitControls()

            krConnector.PLC = frmMain.CX1020
            krConnector.VarCollector = Me.krVarCollector
            krConnector.Connect()
        Else
            krConnector.Disconnect()

        End If
    End Sub

    Private Sub Btn_Settings2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Settings2.Click
        'frmMain.SubFormChange(frmMain.SubServiceSettings2)
    End Sub

End Class
