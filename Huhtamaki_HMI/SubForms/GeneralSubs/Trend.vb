
Public Class Trend
    Private Sub InitControls()
        'todo
    End Sub

    Private Sub GetTrendData()
        Channel1.TrendData = frmMain.Channel1.LogData
        Channel2.TrendData = frmMain.Channel2.LogData
    End Sub


    Private Sub Trend_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ParentChanged
        If Not Me.Parent Is Nothing Then
            GetControlLabel(Me.Controls)

            InitControls()


            krConnector.PLC = frmMain.CX1020
            krConnector.VarCollector = Me.krVarCollector
            krConnector.Connect()

            GetTrendData()

            krTrend.Connect()
            krTrend.StartLiveTrend()

        Else
            krTrend.StopLiveTrend()
            krTrend.Disconnect()
            krConnector.Disconnect()
        End If
    End Sub
End Class