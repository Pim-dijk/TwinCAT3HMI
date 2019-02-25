Imports KremerControlsWin32

Public Class EtherCatTopology

    Private Sub InitControls()
        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
        Next

    End Sub

    Private Sub Service_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ParentChanged
        If Not Me.Parent Is Nothing Then
            GetControlLabel(Me.Controls)
            InitControls()

            krConnector.PLC = frmMain.CX1020
            krConnector.VarCollector = Me.krVarCollector
            krConnector.Connect()

            Load_DeviceID_AmsNetID()

            AxEcTopologyCtrl1.ZoomFactor = 1
            AxEcTopologyCtrl1.ShowOnlineTopology()
        Else
            krConnector.Disconnect()
        End If
    End Sub

    Private Sub Btn_Zoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Zoom.Click
        If AxEcTopologyCtrl1.ZoomFactor = 1 Then
            AxEcTopologyCtrl1.ZoomFactor = 1.5
        ElseIf AxEcTopologyCtrl1.ZoomFactor = 1.5 Then
            AxEcTopologyCtrl1.ZoomFactor = 2
        Else
            AxEcTopologyCtrl1.ZoomFactor = 1
        End If
    End Sub

    Private Sub Load_DeviceID_AmsNetID()
        Try
            AxEcTopologyCtrl1.DeviceId = VarDeviceID.Data
            AxEcTopologyCtrl1.TargetNetId = VarAmsNetID.Data.ToString
        Catch ex As Exception
        End Try

    End Sub

End Class
