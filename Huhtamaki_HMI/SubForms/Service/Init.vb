Imports KremerControlsWin32


Public Class Init

    Private Sub InitControls()

        GetStatus(0, KSB_IMD.StatusText)
        GetStatus(1, KSB_TransferMold.StatusText)
        GetStatus(2, KSB_ProductForming.StatusText)
        GetStatus(3, KSB_TopMoldA.StatusText)
        GetStatus(4, KSB_BottomMoldA.StatusText)
        GetStatus(5, KSB_TopMoldB.StatusText)
        GetStatus(6, KSB_BottomMoldB.StatusText)
        GetStatus(7, KSB_ProductHandling.StatusText)
        GetStatus(8, KSB_GantryA.StatusText)
        GetStatus(9, KSB_GantryB.StatusText)

        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerButton Then CType(IoCtl, KremerButton).UserInfo = HmiUserInfo
        Next
      
    End Sub

    Private Sub Service_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ParentChanged
        If Not Me.Parent Is Nothing Then
            GetControlLabel(Me.Controls)
            InitControls()

            krConnector.PLC = frmMain.CX1020
            krConnector.VarCollector = Me.krVarCollector
            krConnector.Connect()
        Else
            krConnector.Disconnect()
        End If
    End Sub

 

End Class
