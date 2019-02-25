Public Class frmCleanScreen
    Dim Counter As Integer
    Const strCopyright As String = "Industrial Automation Kremer BV "
    Private Sub frmCleanScreen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Counter += 1
    End Sub

    Private Sub frmCleanScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetLabel(Me)
        lblKremer.Text = strCopyright & Year(Now).ToString
        picEaster.Visible = False
        Labelthanks.Visible = False
        pbRemaining.Value = pbRemaining.Maximum
        tmrClean.Enabled = True
        Counter = 0
    End Sub

    Private Sub tmrClean_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrClean.Tick
        On Error Resume Next
        If pbRemaining.Value > 0 Then
            pbRemaining.Value -= 1
            lblTime.Text = pbRemaining.Value
        Else
            tmrClean.Enabled = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If

        If Counter >= 2 Then
            picEaster.Visible = True
            Labelthanks.Visible = True
        End If
        Counter = 0
    End Sub

    Private Sub Label2_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class