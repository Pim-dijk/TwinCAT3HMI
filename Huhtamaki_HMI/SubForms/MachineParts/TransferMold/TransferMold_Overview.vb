﻿Imports KremerControlsWin32

Public Class Transfermold_Overview

    Private Sub InitControls()
        GetStatus(1, State_HorTransport.StatusText)

        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
        Next

    End Sub

    Private Sub Transfermold_Overview_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ParentChanged
        If Not Me.Parent Is Nothing Then

            'init the language for the labels
            InitControls()

            GetControlLabel(Me.Controls)
            GetControlLabel(Me.Pnl_Status_init.Controls)

            'connect the PLC to the mainfrom plc
            KrConnector.PLC = frmMain.CX1020
            KrConnector.VarCollector = Me.VarCollector
            KrConnector.Connect()
        Else
            KrConnector.Disconnect()
        End If
    End Sub



    Private Sub Btn_Settings_Click(sender As Object, e As EventArgs) Handles Btn_Settings.Click
        frmMain.SubFormChange(frmMain.SubTransferMold_Settings)
    End Sub


    Private Sub Btn_Manual_Click(sender As Object, e As EventArgs) Handles Btn_Manual.Click
        frmMain.SubFormChange(frmMain.SubTransferMold_Manual)
    End Sub

    Private Sub mxAutomode_DataChanged(sender As Object, e As EventArgs) Handles mxAutomode.DataChanged
        Btn_Manual.Enabled = Not mxAutomode.Data
    End Sub

End Class
