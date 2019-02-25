Imports KremerControlsWin32

Public Class Overview

    Private Sub InitControls()
        'GetStatus(0, State_InMoldDrying.StatusText)
        'GetStatus(1, State_ProductHandling.StatusText)
        'GetStatus(3, State_Press.StatusText)

        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
        Next

    End Sub

    'Connecting the kremer connector
    Private Sub Overview_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ParentChanged
        If Not Me.Parent Is Nothing Then

            InitControls()

            GetControlLabel(Me.Controls)

            KrConnector.PLC = frmMain.CX1020
            KrConnector.VarCollector = Me.VarCollector
            KrConnector.Connect()
        Else
            KrConnector.Disconnect()
        End If
    End Sub

#Region "Machine part button mouse up and down event handlers "


#Region "Pulp"

    Private Sub BtnPulp_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnPulp.MouseDown
        BtnPulp.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BtnPulp_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnPulp.MouseUp
        frmMain.SubFormChange(frmMain.SubPulp_Overview)
        BtnPulp.FlatAppearance.BorderSize = 0
    End Sub

#End Region

#Region "Transfermold"

    Private Sub BtnTransferMold_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnTransferMold.MouseDown
        BtnTransferMold.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BtnTransferMold_up(sender As Object, e As MouseEventArgs) Handles BtnTransferMold.MouseUp
        frmMain.SubFormChange(frmMain.SubTransferMold_Overview)
        BtnTransferMold.FlatAppearance.BorderSize = 0
    End Sub

#End Region

#Region "Drying molds A/B"

    Private Sub BtnDryingMoldA_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnDryingMoldA.MouseDown
        BtnDryingMoldA.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BtnDryingMoldA_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnDryingMoldA.MouseUp
        frmMain.SubDryingMold_Overview.IsASide = True
        frmMain.SubFormChange(frmMain.SubDryingMold_Overview, True)
        BtnDryingMoldA.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub BtnDryingMoldB_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnDryingMoldB.MouseDown
        BtnDryingMoldB.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BtnDryingMoldB_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnDryingMoldB.MouseUp
        frmMain.SubDryingMold_Overview.IsASide = False
        frmMain.SubFormChange(frmMain.SubDryingMold_Overview, True)
        BtnDryingMoldB.FlatAppearance.BorderSize = 0
    End Sub

#End Region

#Region "Take out unit A/B"

    Private Sub BtnTakeOutUnitB_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnTakeOutUnitB.MouseDown
        BtnTakeOutUnitB.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BtnTakeOutUnitB_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnTakeOutUnitB.MouseUp
        frmMain.SubTakeOutUnit_Overview.IsASide = False
        frmMain.SubFormChange(frmMain.SubTakeOutUnit_Overview, True)
        BtnTakeOutUnitB.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub BtnTakeOutUnitA_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnTakeOutUnitA.MouseDown
        BtnTakeOutUnitA.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BtnTakeOutUnitA_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnTakeOutUnitA.MouseUp
        frmMain.SubTakeOutUnit_Overview.IsASide = True
        frmMain.SubFormChange(frmMain.SubTakeOutUnit_Overview, True)
        BtnTakeOutUnitA.FlatAppearance.BorderSize = 0
    End Sub
#End Region

#Region "Gantry A/B"
    Private Sub BtngantryB_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnGantryB.MouseDown
        BtnGantryB.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BtnGantryB_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnGantryB.MouseUp
        frmMain.SubGantry_Overview.IsASide = False
        frmMain.SubFormChange(frmMain.SubGantry_Overview, True)
        BtnGantryB.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub BtnGantryA_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnGantryA.MouseDown
        BtnGantryA.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BtnGantryA_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnGantryA.MouseUp
        frmMain.SubGantry_Overview.IsASide = True
        frmMain.SubFormChange(frmMain.SubGantry_Overview, True)
        BtnGantryA.FlatAppearance.BorderSize = 0
    End Sub


#End Region

#Region "Outfeed"
    Private Sub BtnOutfeed_Down(sender As Object, e As MouseEventArgs) Handles BtnOutfeed.MouseDown
        BtnTransferMold.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BtnOutfeed_up(sender As Object, e As MouseEventArgs) Handles BtnOutfeed.MouseUp
        frmMain.SubFormChange(frmMain.SubConveyorBelt_Overview)
        BtnTransferMold.FlatAppearance.BorderSize = 0
    End Sub

#End Region

#End Region


    Private Sub DoorZone1Left_DataChanged(sender As Object, e As EventArgs) Handles DoorZone1Left.DataChanged,
        DoorZone1Right.DataChanged,
        DoorZone2BackLeft.DataChanged,
        DoorZone2BackRight.DataChanged,
        DoorZone2Front.DataChanged,
        DoorZone3BackLeft.DataChanged,
        DoorZone3BackRight.DataChanged,
        DoorZone3Front.DataChanged,
        DoorZone4BackLeft.DataChanged,
        DoorZone4BackRight.DataChanged,
        DoorZone4Front.DataChanged,
        DoorZone5Left.DataChanged,
        DoorZone5Right.DataChanged,
        DoorZone6Back.DataChanged,
        DoorZone7back.DataChanged

        If Not DoorZone1Left.Data And Not DoorZone1Right.Data And
            Not DoorZone2BackLeft.Data And Not DoorZone2BackRight.Data And Not DoorZone2Front.Data And
            Not DoorZone3BackLeft.Data And Not DoorZone3BackRight.Data And Not DoorZone3Front.Data And
            Not DoorZone4BackLeft.Data And Not DoorZone4BackRight.Data And Not DoorZone4Front.Data And
            Not DoorZone5Left.Data And Not DoorZone5Right.Data And
            Not DoorZone6Back.Data And
            Not DoorZone7back.Data Then

            PnlDoors.Visible = False
        Else
            PnlDoors.Visible = True
        End If


    End Sub
End Class
