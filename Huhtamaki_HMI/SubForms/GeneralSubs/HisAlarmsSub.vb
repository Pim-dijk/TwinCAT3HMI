Imports KremerControlsWin32

Public Class HisAlarmsSub
    Dim CurrentDate As DateTime = DateTime.Now
    Dim IsLoaded As Boolean = False
    
    Private Sub InitControls()
        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
        Next
    End Sub


    'Connecting the kremer connector
    Private Sub HisAlarmsSub_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ParentChanged
        If Not Me.Parent Is Nothing Then

            InitControls()

            GetControlLabel(Me.Controls)

            KrConnector.PLC = frmMain.CX1020
            KrConnector.VarCollector = Me.VarCollector
            KrConnector.Connect()

            frmMain.AlarmForm.krAlarmView.SetAlarmColumns(frmMain.AlarmColumnText)
            GetLabel(frmMain.AlarmForm)

            'Me.krAlarmView.AlarmData = frmMain.krAlarmData

        Else
            'Me.krAlarmView.AlarmData = Nothing
            KrConnector.Disconnect()
        End If
    End Sub



    Private Sub frmAlarm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'GetLabel(Me)

        CurrentDate = DateTime.Now

        KremerHistoryAlarmViewer1.SqlServerConnection = frmMain.KremerAlarmLogDB.SqlServerConnection

        ' get new data from form main.
        KremerHistoryAlarmViewer1.AlarmData = frmMain.krAlarmData

        KremerHistoryAlarmViewer1.GetDateTimeAlarms(CurrentDate.AddDays(-1 * DaysSlider.Value), CurrentDate)

        LBL_DaysShown.Text = DaysSlider.Value.ToString()

        IsLoaded = True
    End Sub

    Private Sub BTN_AddDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_AddDay.Click
        CurrentDate = DateTime.Now
        If DaysSlider.Value > DaysSlider.Minimum Then
            DaysSlider.Value -= 1
            KremerHistoryAlarmViewer1.GetDateTimeAlarms(CurrentDate.AddDays(-1 * DaysSlider.Value), CurrentDate)
            LBL_DaysShown.Text = DaysSlider.Value.ToString()
        End If
    End Sub

    Private Sub BTN_SubstractDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_SubstractDay.Click

        CurrentDate = DateTime.Now
        If DaysSlider.Value < DaysSlider.Maximum Then
            DaysSlider.Value += 1
            KremerHistoryAlarmViewer1.GetDateTimeAlarms(CurrentDate.AddDays(-1 * DaysSlider.Value), CurrentDate)
            LBL_DaysShown.Text = DaysSlider.Value.ToString()
        End If
    End Sub


    Private Sub OnBecomingVisible(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        If IsLoaded Then
            If Me.Visible Then
                CurrentDate = DateTime.Now
                KremerHistoryAlarmViewer1.GetDateTimeAlarms(CurrentDate.AddDays(-1 * DaysSlider.Value), CurrentDate)

                LBL_DaysShown.Text = DaysSlider.Value.ToString()
            End If
        End If

        If Me.Visible Then
            frmMain.AlarmHisForm.KremerHistoryAlarmViewer1.SetAlarmColumns(frmMain.AlarmColumnText)
            GetLabel(frmMain.AlarmHisForm)
        End If

    End Sub

End Class
