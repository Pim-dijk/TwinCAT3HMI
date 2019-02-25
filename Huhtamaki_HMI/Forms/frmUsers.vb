Public Class frmUsers
    Dim NewLogin As Integer = 1000
    Dim ConfirmLogin As Integer = 9999
    Dim WithEvents NewLoginPad As New KremerControlsWin32.KremerNumPad
    Dim WithEvents ConfirmLoginPad As New KremerControlsWin32.KremerNumPad

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmUsers_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Disposed
        NewLoginPad.Dispose()
        ConfirmLoginPad.Dispose()
    End Sub

    Private Sub frmUsers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NewLogin = 0
        ConfirmLogin = 9999

        'Me.Top = (Screen.PrimaryScreen.WorkingArea.Height / 2) - (Me.Height / 2)
        'Me.Left = (Screen.PrimaryScreen.WorkingArea.Width / 2) - (Me.Width / 2)
        Me.Text = GetSingleLabel(70)
        GetLabel(Me)
        UserDB.ReadAllUsers(lstUsers)
        lstUsers.Items(0).Selected = True
        lstUsers.Items(0).Focused = True

    End Sub

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If NewLogin <> ConfirmLogin Then
            frmMain.krMessage.ShowMessage(GetSingleLabel(73), GetSingleLabel(70))
        Else
            ChangeLoginCode(lblUser.Text, NewLogin)
            Me.Close()
        End If
    End Sub

    Private Sub lstUsers_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstUsers.SelectedIndexChanged
        Dim indexes As ListView.SelectedIndexCollection = lstUsers.SelectedIndices
        Dim index As Integer
        For Each index In indexes
            lblUser.Text = lstUsers.Items(index).Text
            Exit For
        Next
    End Sub

    Private Sub txtNewLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNewLogin.Click
        NewLoginPad.PasswordMask = True
        NewLoginPad.DataType = KremerControlsWin32.KremerNumPad.NumDataType.INT
        NewLoginPad.ShowDialog()
    End Sub

    Private Sub txtConfirmLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConfirmLogin.Click
        ConfirmLoginPad.PasswordMask = True
        ConfirmLoginPad.DataType = KremerControlsWin32.KremerNumPad.NumDataType.INT
        ConfirmLoginPad.ShowDialog()
    End Sub

    Private Sub NewLoginPad_NumPadValueChanged(ByVal Value As Object) Handles NewLoginPad.NumPadValueChanged
        NewLogin = CInt(Value)
    End Sub

    Private Sub ConfirmLoginPad_NumPadValueChanged(ByVal Value As Object) Handles ConfirmLoginPad.NumPadValueChanged
        ConfirmLogin = CInt(Value)
    End Sub
End Class