Public Class frmLangSel

    Private Sub frmLangSel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Top = (Screen.PrimaryScreen.WorkingArea.Height / 2) - (Me.Height / 2)
        'Me.Left = (Screen.PrimaryScreen.WorkingArea.Width / 2) - (Me.Width / 2)
        LanguageDB.ReadLanguage(lstLang)
        lstLang.Items(0).Selected = True
        lstLang.Items(0).Focused = True
    End Sub

    Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        LanguageDB.SetCurrentLanguage(CInt(Me.lstLang.FocusedItem.Text))
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class