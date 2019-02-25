

Public Class frmAlarm

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub

    Private Sub frmAlarm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetLabel(Me)
    End Sub

    Private Sub btnReset_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnReset.MouseDown
        frmMain.hmiReset.Data = True
    End Sub

    Private Sub btnReset_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnReset.MouseUp
        frmMain.hmiReset.Data = False
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        frmMain.AlarmHisForm.Show()
    End Sub

    Private Sub frmAlarm_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged

        If Me.Visible = True Then
            frmMain.AlarmForm.krAlarmView.SetAlarmColumns(frmMain.AlarmColumnText)
            GetLabel(frmMain.AlarmForm)
        End If

    End Sub

End Class