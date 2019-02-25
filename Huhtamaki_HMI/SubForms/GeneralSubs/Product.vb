Imports KremerControlsWin32
Public Class Product
    Private Sub InitControls()
        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerButton Then CType(IoCtl, KremerButton).UserInfo = HmiUserInfo
        Next

        If ioProductName.UserLevel <= frmMain.miUserLevel.Data Then
            ioProductName.BackColor = Color.White
        Else
            ioProductName.BackColor = Panel.DefaultBackColor
        End If

    End Sub

    Private Sub Product_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ParentChanged
        If Not Me.Parent Is Nothing Then

            GetControlLabel(Me.Controls)
            'GetStateText(btnSingleDoubleCarton.StateText, 186, 187)

            InitControls()

            krConnector.PLC = frmMain.CX1020
            krConnector.VarCollector = Me.krVarCollector
            krConnector.Connect()
        Else
            krConnector.Disconnect()
        End If
    End Sub

    Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        frmMain.mxProduktDataLoaded.Data = False

        frmProdSel.Text = "ProductName"
        frmProdSel.StartPosition = FormStartPosition.CenterParent

        If frmProdSel.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If ProductDB.LoadProduct(Me, GetProductID) Then
                frmMain.mxProduktDataLoaded.Data = True
                CurrentProduct = ioProductName.Data
            End If
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ProductDataLoaded Then
            ProductDB.SaveProduct(Me, ioProductId.Data)
        End If
    End Sub

    Private Sub btnSaveNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveNew.Click
        ProductDB.SaveAsNewProduct(Me)
    End Sub
End Class
