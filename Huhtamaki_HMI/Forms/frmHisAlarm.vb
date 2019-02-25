Public Class frmHisAlarm
    Dim CurrentDate As DateTime = DateTime.Now
    Dim IsLoaded As Boolean = False

    Private Sub frmAlarm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetLabel(Me)

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

    Private Sub Btn_ACT_ALARM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ACT_ALARM.Click
        Me.Hide()
        frmMain.AlarmForm.Show()
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