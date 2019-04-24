Imports KremerControlsWin32

Public Class ZeroAbsEncoder
    Private Sub InitControls()
        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerButton Then CType(IoCtl, KremerButton).UserInfo = HmiUserInfo
        Next

        InitZeroGantryAHor()
        InitZeroGantryAvert()
        InitZeroGantryBHor()
        InitZeroGantryBVert()
        InitZeroSb()
        InitZeroBMA()
        InitZeroBMB()
    End Sub

#Region "Disable button sub"

    Private Sub InitZeroGantryAHor()
        If GA_Hor_AxDis.Data Then 'And (UserLevel.Data >= 500) Then
            Btn_ZeroGantryAHor.Enabled = True
        Else
            Btn_ZeroGantryAHor.Enabled = False
        End If
    End Sub

    Private Sub InitZeroGantryAvert()
        If GA_Vert_AxDis.Data Then 'And (UserLevel.Data >= 500) Then
            Btn_ZeroGantryAVert.Enabled = True
        Else
            Btn_ZeroGantryAVert.Enabled = False
        End If
    End Sub

    Private Sub InitZeroGantryBHor()
        If GB_Hor_AxDis.Data Then 'And (UserLevel.Data >= 500) Then
            BtnZeroGantryBHor.Enabled = True
        Else
            BtnZeroGantryBHor.Enabled = False
        End If
    End Sub

    Private Sub InitZeroGantryBVert()
        If GB_Vert_AxDis.Data Then 'And (UserLevel.Data >= 500) Then
            BtnZeroGantryBVert.Enabled = True
        Else
            BtnZeroGantryBVert.Enabled = False
        End If
    End Sub

    Private Sub InitZeroSb()
        If SB_AxDis.Data Then 'And (UserLevel.Data >= 500) Then
            Btn_ZeroSB.Enabled = True
        Else
            Btn_ZeroSB.Enabled = False
        End If
    End Sub

    Private Sub InitZeroBMA()
        If BMA_AxDis.Data Then 'And (UserLevel.Data >= 500) Then
            BtnZeroBMA.Enabled = True
        Else
            BtnZeroBMA.Enabled = False
        End If
    End Sub

    Private Sub InitZeroBMB()
        If BMB_AxDis.Data Then 'And (UserLevel.Data >= 500) Then
            BtnZeroBMB.Enabled = True
        Else
            BtnZeroBMB.Enabled = False
        End If
    End Sub

#End Region

    Private Sub Service_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ParentChanged
        If Not Me.Parent Is Nothing Then
            GetControlLabel(Me.Controls)
            InitControls()

            KrConnector.PLC = frmMain.CX1020
            KrConnector.VarCollector = Me.krVarCollector
            KrConnector.Connect()
        Else
            KrConnector.Disconnect()
        End If
    End Sub




    Private Sub UserLevel_DataChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        InitControls()
    End Sub

    Private Sub AxisDisabled_DataChanged(sender As Object, e As EventArgs) Handles GA_Hor_AxDis.DataChanged, GA_Vert_AxDis.DataChanged, GB_Hor_AxDis.DataChanged, _
                                                                                GB_Vert_AxDis.DataChanged, SB_AxDis.DataChanged, BMA_AxDis.DataChanged, _
                                                                                BMB_AxDis.DataChanged
        InitControls()
    End Sub
End Class
