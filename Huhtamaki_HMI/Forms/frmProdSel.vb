Public Class frmProdSel

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        If lstProducts.Items.Count > 0 Then
            ProductDB.SetProductID(CInt(Me.lstProducts.FocusedItem.Text))
        End If
        Me.Close()
    End Sub


    Private Sub frmProdSel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If HmiUserInfo.Level >= 500 Then
            btnDelete.Enabled = True
        Else
            btnDelete.Enabled = False
        End If

        'Me.Top = (Screen.PrimaryScreen.WorkingArea.Height / 2) - (Me.Height / 2)
        'Me.Left = (Screen.PrimaryScreen.WorkingArea.Width / 2) - (Me.Width / 2)
        Me.Text = GetSingleLabel(36)
        GetLabel(Me)
        ProductDB.ReadAllProducts(Me.lstProducts)
        If lstProducts.Items.Count > 0 Then
            lstProducts.Items(0).Selected = True
            lstProducts.Items(0).Focused = True
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        ProductDB.DeleteProduct(CInt(Me.lstProducts.FocusedItem.Text))
        ProductDB.ReadAllProducts(Me.lstProducts)
        If lstProducts.Items.Count > 0 Then
            lstProducts.Items(0).Selected = True
            lstProducts.Items(0).Focused = True
        End If
    End Sub
End Class