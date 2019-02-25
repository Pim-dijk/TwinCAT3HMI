Imports KremerControlsWin32

Public Class AlarmsSub

    Private Sub InitControls()
        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
        Next
        EnableHisButton()
    End Sub

    'Connecting the kremer connector
    Private Sub AlarmsSub_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ParentChanged
        If Not Me.Parent Is Nothing Then

            InitControls()

            GetControlLabel(Me.Controls)

            KrConnector.PLC = frmMain.CX1020
            KrConnector.VarCollector = Me.VarCollector
            KrConnector.Connect()

            frmMain.AlarmForm.krAlarmView.SetAlarmColumns(frmMain.AlarmColumnText)
            GetLabel(frmMain.AlarmForm)

            Me.krAlarmView.AlarmData = frmMain.krAlarmData

            krAlarmView.InitAlarmViewer()

        Else
            Me.krAlarmView.AlarmData = Nothing
            KrConnector.Disconnect()
        End If
    End Sub

    Private Sub btnHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistory.Click
        frmMain.SubFormChange(frmMain.SubHisAlarms)
    End Sub

    Private Sub btnSortType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSortType.Click
        If krAlarmView.SortOrderString = "KremerAlarmTypes ASC, TimeStamp DESC" Then
            krAlarmView.SortOrderString = "KremerAlarmTypes DESC, TimeStamp DESC"
        Else
            krAlarmView.SortOrderString = "KremerAlarmTypes ASC, TimeStamp DESC"
        End If
    End Sub

    Private Sub btnSortChrono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSortChrono.Click
        If krAlarmView.SortOrderString = "TimeStamp ASC" Then
            krAlarmView.SortOrderString = "TimeStamp DESC"
        Else
            krAlarmView.SortOrderString = "TimeStamp ASC"
        End If
    End Sub

    'Button Enable history
    Private Sub EnableHisButton()
        If UserLevel.Data >= 500 Then
            btnHistory.Enabled = True
        Else
            btnHistory.Enabled = False
        End If
    End Sub

    Private Sub UserLevel_DataChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UserLevel.DataChanged
        EnableHisButton()
    End Sub
End Class
