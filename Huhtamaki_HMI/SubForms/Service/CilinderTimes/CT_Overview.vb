Imports KremerControlsWin32

Public Class CT_Overview

#Region "Machine part button mouse up and down events "

#Region "Mouse DOWN events"
    Private Sub StackerMouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnStacker.MouseDown
        BtnStacker.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BufferBundleTrackMouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnBufferBundleTrack.MouseDown
        BtnBufferBundleTrack.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub ZipperMouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnZipper.MouseDown
        BtnZipper.FlatAppearance.BorderSize = 1
        BtnZipperExtended.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub Zipper2Mousedown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnZipperExtended.MouseDown
        BtnZipper.FlatAppearance.BorderSize = 1
        BtnZipperExtended.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub VerticalDenesterMouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnVerticalDenester.MouseDown
        BtnVerticalDenester.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BundleOutfeedMouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnBundleOutfeed.MouseDown
        BtnBundleOutfeed.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub BtnBundleAutom1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnBundleAutom1.MouseDown
        BtnBundleAutom1.FlatAppearance.BorderSize = 1
    End Sub

#End Region

#Region " Mouse UP events"

    Private Sub StackerMouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnStacker.MouseUp
        frmMain.SubFormChange(frmMain.SubCT_Stacker)
        BtnStacker.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub BufferBundleTrackMouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnBufferBundleTrack.MouseUp
        frmMain.SubFormChange(frmMain.SubCT_BBT)
        BtnBufferBundleTrack.FlatAppearance.BorderSize = 0
    End Sub

    'Leftside part of zipper
    Private Sub ZipperMouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnZipper.MouseUp
        frmMain.SubFormChange(frmMain.SubCT_Zipper)
        BtnZipper.FlatAppearance.BorderSize = 0
        BtnZipperExtended.FlatAppearance.BorderSize = 0
    End Sub

    'Rightside part of zipper
    Private Sub Zipper2MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnZipperExtended.MouseUp
        frmMain.SubFormChange(frmMain.SubCT_Zipper)
        BtnZipper.FlatAppearance.BorderSize = 0
        BtnZipperExtended.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub VerticalDenesterMouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnVerticalDenester.MouseUp
        frmMain.SubFormChange(frmMain.SubCT_VDenester)
        BtnVerticalDenester.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub BundleOutfeedMouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnBundleOutfeed.MouseUp
        frmMain.SubFormChange(frmMain.SubCT_Outfeed)
        BtnBundleOutfeed.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub BtnBundleAutom1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles BtnBundleAutom1.MouseUp
        frmMain.SubFormChange(frmMain.SubCT_BundleAutomation)
        BtnBundleAutom1.FlatAppearance.BorderSize = 0
    End Sub

#End Region

#End Region

    Private Sub InitControls()

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

End Class
