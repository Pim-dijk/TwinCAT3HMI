Imports KremerControlsWin32

Public Class Service

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

    Private Sub Btn_SeqStat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_SeqStat.Click
        frmMain.SubFormChange(frmMain.SubSequence)
    End Sub

    Private Sub Btn_IOStat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_IOStat.Click
        frmMain.SubFormChange(frmMain.subIO_Overview)
    End Sub

    Private Sub Btn_Zero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Zero.Click
        frmMain.SubFormChange(frmMain.SubZeroAbsEnc)
    End Sub

    Private Sub btn_EtherCatTop_Enable(ByVal sender As Object, ByVal e As System.EventArgs)
        'If mxMachineInRest.Data Then 'And HmiUserInfo.Level >= 500 Then
        '    Btn_EtherCat_Topology.Enabled = True
        'Else
        '    Btn_EtherCat_Topology.Enabled = False
        'End If
    End Sub

    Private Sub Btn_EtherCat_Topology_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_EtherCat_Topology.Click
        'frmMain.SubFormChange(frmMain.SubEtherCatTop)
    End Sub

    Private Sub Btn_CilinderTimes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_CilinderTimes.Click
        frmMain.SubFormChange(frmMain.SubCT)
    End Sub

    Private Sub Btn_SeqInitStat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_SeqInitStat.Click
        frmMain.SubFormChange(frmMain.SubSequenceInit)
    End Sub

    Private Sub Btn_ServiceSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ServiceSettings.Click
        frmMain.SubFormChange(frmMain.SubServiceSettings)
    End Sub

    Private Sub Btn_I2T_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_I2T.Click
        frmMain.SubFormChange(frmMain.SubI2TSettings)
    End Sub
End Class
