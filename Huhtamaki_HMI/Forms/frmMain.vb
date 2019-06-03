Imports System
Imports System.IO
Imports System.Windows.Forms
Imports System.Reflection
Imports System.ComponentModel
Imports KremerControlsWin32

Public Class frmMain

#Region "form and subform related declarations"

    'Declare Main overview page
    Public SubOverview As New Overview

    'Declare machine parts:

    'DryingMolds (A/B) (dynamic)
    Public SubDryingMold_Overview As New DryingMold_Overview
    Public SubDryingMold_Settings As New DryingMoldSettings
    Public SubDryingMold_Settings2 As New DryingMoldSettings2
    Public SubDryingMold_Manual As New DryingMold_Manual

    Public SubDryingMoldDetail_Top_Settings As New DryingMoldDetail_Top_Settings
    Public SubDryingMoldDetail_Top As New DryingMoldDetail_Top

    Public SubDryingMoldDetail_Bot_Settings As New DryingMoldDetail_Bot_Settings
    Public SubDryingMoldDetail_bot As New DryingMoldDetail_Bot

    'Pulp
    Public SubPulp_Overview As New ProductForming_Overview

    'Machine pond
    Public SubMachinePond_Manual As New MachinePond_Manual
    Public SubMachinePond_Overview As New MachinePond_Overview
    Public SubMachinePond_Settings As New MachinePond_Settings

    'Spraybar
    Public SubSprayBar_Manual As New Spraybar_Manual
    Public SubSprayBar_Overview As New Spraybar_overview
    Public SubSprayBar_Settings As New Spraybar_Settings

    'Take out unit A/B (dynamic)
    Public SubTakeOutUnit_Overview As New TakeOutUnit_Overview
    Public SubTakeOutUnit_Settings As New TakeOutUnit_Settings
    Public SubTakeOutUnit_Manual As New TakeOutUnit_Manual

    'Transfermold
    Public SubTransferMold_Manual As New TransferMold_Manual
    Public SubTransferMold_Overview As New Transfermold_Overview
    Public SubTransferMold_Settings As New TransferMold_Settings
    Public SubTransferMold_Settings2 As New TransferMold_Settings2


    'Gantry A/B
    Public SubGantry_Manual As New Gantry_Manual
    Public SubGantry_Overview As New Gantry_Overview
    Public SubGantry_Settings As New Gantry_Settings

    'SpeedControl
    Public SubSpeedControl_Manual As New SpeedControl_Manual
    Public SubSpeedControl_Overview As New SpeedControl_Overview
    Public SubSpeedControl_Settings As New SpeedControl_Settings

    'Declare other subs
    Public SubGeneral As New General
    Public SubSettings As New Settings
    Public SubProduct As New Product
    Public SubAlarms As New AlarmsSub
    Public SubHisAlarms As New HisAlarmsSub


    'Service
    Public SubService As New Service
    Public SubSequence As New Sequence
    Public SubInit As New Init
    Public SubSequenceInit As New SequenceInit
    Public SubZeroAbsEnc As New ZeroAbsEncoder
    'Public SubEtherCatTop As New EtherCatTopology
    Public SubServiceSettings As New ServiceSettings
    Public SubServiceSettings2 As New ServiceSettings2

    Public SubCT As New CT
    Public SubI2TSettings As New I2T_Settings
    
    'Service IO
    Public subIO_Overview As New IO_Overview
    Public subIO_TopMolds As New IO_TopMolds
    Public subIO_BottomMolds As New IO_BottomMolds
    Public subIO_TransferMold As New IO_TransferMold
    Public SubIO_ProductForming As New IO_ProductForming
    Public SubIO_Hydraulics As New IO_Hydraulics
    Public SubIO_ProductHandling As New IO_ProductHandling
    
    'alarm form declaration
    Public WithEvents AlarmForm As New frmAlarm
    Public AlarmHisForm As New frmHisAlarm
    Dim UpdateAlarmForm As Boolean
    Dim VarsConnected As Boolean = False
    Dim VarsConnectedSpeed As Boolean = False
    Public krMessage As New KremerControlsWin32.KremerMessageBox
    Public AlarmColumnText(3) As String

#End Region

#Region "FrmMain load, close , finalize"

    Private Sub frmMain_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        On Error Resume Next


        CX1020.Disconnect()
        SpeedControl.Disconnect()

        'General:
        SubOverview.Dispose()
        SubGeneral.Dispose()
        AlarmForm.Dispose()

        krConnector = Nothing
        CX1020 = Nothing
        SpeedControl = Nothing
        krConnectorSpeed = Nothing
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ScaleApp()

        SetAppDir(Path.GetDirectoryName(Application.ExecutablePath))

        CurrentLanguage()
        GetLabel(Me)

        InitAlarmViewer()

        'CX1020.Connect("172.18.138.40.1.1", 851)
        CX1020.Connect("", 851)
        SpeedControl.Connect("", 852)


        'CX1020.Connect()

        InitControls()

        'AlarmLogging
        'KremerAlarmLogDB.InitDB()
        'KremerAlarmLogDB.InitLog()

        KremerAddLogLine("HMI Started")
        'Initialise alarm viewer:
        'GetAlarmColumns(AlarmColumns, AlarmColumnText)
    End Sub

    Protected Overrides Sub Finalize()
        KremerAddLogLine("HMI reached finalized function")
        MyBase.Finalize()
    End Sub

#End Region

#Region "Template functions"


    Sub ScaleApp()
        Dim ScaleForm As System.Drawing.SizeF
        ScaleForm.Height = My.Computer.Screen.Bounds.Height / BasicHeight
        ScaleForm.Width = My.Computer.Screen.Bounds.Width / BasicWidth

        'Scale Main Form
        Me.Scale(ScaleForm)

        'Service
        'SubService.Scale(ScaleForm)
        'SubSequence.Scale(ScaleForm)
        'SubInit.Scale(ScaleForm)
        'SubSequenceInit.Scale(ScaleForm)
        'SubZeroAbsEnc.Scale(ScaleForm)
        'SubEtherCatTop.Scale(ScaleForm)
        'SubServiceSettings.Scale(ScaleForm)
        'SubServiceSettings2.Scale(ScaleForm)

        'Service IO
        'SubIoOverview.Scale(ScaleForm)
        'SubIoOverview_Mirrored.Scale(ScaleForm)
        'SubIoZipper.Scale(ScaleForm)
        'SubIoBBT.Scale(ScaleForm)
        'SubIoOutfeed.Scale(ScaleForm)
        'SubIoStacker.Scale(ScaleForm)

        'Service CilinderTimes
        'SubCT_Overview.Scale(ScaleForm)
        'SubCT_Overview_Mirrored.Scale(ScaleForm)
        'SubCT_Zipper.Scale(ScaleForm)
        'SubCT_VDenester.Scale(ScaleForm)
        'SubCT_BundleAutomation.Scale(ScaleForm)
        'SubCT_Stacker.Scale(ScaleForm)
        'SubCT_Outfeed.Scale(ScaleForm)
        'SubCT_BBT.Scale(ScaleForm)

        'I2T Settings
        'SubI2TSettings.Scale(ScaleForm)
        'SubI2TSettings2.Scale(ScaleForm)

        'General:
        SubOverview.Scale(ScaleForm)
        SubGeneral.Scale(ScaleForm)
        AlarmForm.Scale(ScaleForm)

    End Sub

    Private Sub InitControls()
        'User level check
        For Each IoCtl As Control In Me.Controls
            If TypeOf IoCtl Is KremerIoField Then CType(IoCtl, KremerIoField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerTextField Then CType(IoCtl, KremerTextField).UserInfo = HmiUserInfo
            If TypeOf IoCtl Is KremerButton Then CType(IoCtl, KremerButton).UserInfo = HmiUserInfo
        Next

        ' Added by bateu 20190321
        If mxManualAutomode.Data Then
            btnInit.Enabled = True
        Else
            btnInit.Enabled = False
        End If
    End Sub

    Private Sub CloseApp(ByVal sReason As String)
        KremerAddLogLine("App was forced to close (Errorcode 102)")
        krMessage.ShowMessage(sReason, "Kremer HMI")
        Me.Close()
    End Sub


    ''' <summary>
    ''' Function that handles the change of the subform in the template.
    ''' </summary>
    ''' <param name="oSubForm">"The instance of the screen that the subform needs to change to."</param>
    ''' <remarks></remarks>
    Public Sub SubFormChange(ByRef oSubForm As Control)
        pnlSub.Controls.Clear()
        pnlSub.Controls.Add(oSubForm)
        lblTitle.Text = Replace(GetSingleLabel(CInt(oSubForm.Tag)), "\r\n", " ")
        oSubForm.Focus()
    End Sub

    ''' <summary>
    ''' Function overload that handles the change of the subform in the template.
    ''' </summary>
    ''' <param name="oSubForm">"The instance of the screen that the subform needs to change to."</param>
    ''' <remarks></remarks>
    Public Sub SubFormChange(ByRef oSubForm As Control, ByVal supressTitle As Boolean)
        pnlSub.Controls.Clear()
        pnlSub.Controls.Add(oSubForm)
        If Not supressTitle Then
            lblTitle.Text = Replace(GetSingleLabel(CInt(oSubForm.Tag)), "\r\n", " ")
        End If
        oSubForm.Focus()
    End Sub

    Public Sub InitAlarmViewer()
        GetAlarmText(krAlarmData.AlarmText)

        GetAlarmColumns(AlarmColumns, AlarmColumnText)

        'AlarmForm.krAlarmView.AlarmData = Nothing
        krAlarmView.SetAlarmColumns(AlarmColumnText)
        'AlarmForm.krAlarmView.SetAlarmColumns(AlarmColumnText)
        AlarmHisForm.KremerHistoryAlarmViewer1.SetAlarmColumns(AlarmColumnText)
        SubAlarms.krAlarmView.AlarmData = Me.krAlarmData
    End Sub

#End Region

#Region "Usermanagement / Datetime"

    Private Sub lblLevel_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblLevel.TextChanged
        HmiUserInfo.Level = CInt(lblLevel.Text)
    End Sub

    Private Sub lblUser_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblUser.TextChanged
        HmiUserInfo.Name = CStr(lblUser.Text)
    End Sub

    Private Sub miUserLevel_DataChanged() Handles miUserLevel.DataChanged
        InitControls()
    End Sub

    Private Sub tmrWatch_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrWatch.Tick
        Dim lDateTime As DateTime
        lDateTime = Now
        lblDate.Text = lDateTime.ToShortTimeString & "      " & lDateTime.ToShortDateString
    End Sub

#End Region

#Region "PLC connection and events"

    Private Sub CX1020_Connected() Handles CX1020.Connected
        krConnector.PLC = CX1020
        krConnector.VarCollector = Me.krVarCollector
        krConnector.Connect()
        VarsConnected = True

        'Reset product loaded.
        mxProduktDataLoaded.Data = False

        SubFormChange(SubOverview)
        'pnlSub.Controls.Add(SubOverview)
        lblTitle.Text = GetSingleLabel(CInt(SubOverview.Tag))
    End Sub

    Private Sub CX1020_ConnectError() Handles CX1020.ConnectError
        KremerAddLogLine("No connection with the PLC could be establised.")
        CloseApp(GetSingleLabel(75))
    End Sub

    Private Sub CX1020_DisConnected() Handles CX1020.DisConnected
        krConnector.Disconnect()
        VarsConnected = False
    End Sub

    Private Sub CX1020_Started() Handles CX1020.Started

        CX1020.Connect("172.18.138.40.1.1", 851)
    End Sub

    Private Sub CX1020_Stopped() Handles CX1020.Stopped
        pnlSub.Controls.Clear()

        krConnector.Disconnect()
        VarsConnected = False

        CX1020.Disconnect()
    End Sub

    Private Sub SpeedControl_Connected() Handles SpeedControl.Connected
        krConnectorSpeed.PLC = SpeedControl
        krConnectorSpeed.VarCollector = Me.krVarCollectorSpeed
        krConnectorSpeed.Connect()
        VarsConnectedSpeed = True

        SubFormChange(SubOverview)
        'pnlSub.Controls.Add(SubOverview)
        lblTitle.Text = GetSingleLabel(CInt(SubOverview.Tag))
    End Sub

    Private Sub SpeedControl_ConnectError() Handles SpeedControl.ConnectError
        KremerAddLogLine("No connection with the PLC could be establised.")
        CloseApp(GetSingleLabel(75))
    End Sub

    Private Sub SpeedControl_DisConnected() Handles SpeedControl.DisConnected
        krConnectorSpeed.Disconnect()
        VarsConnectedSpeed = False
    End Sub

    Private Sub SpeedControl_Started() Handles SpeedControl.Started

        SpeedControl.Connect("", 852)
    End Sub

    Private Sub SpeedControl_Stopped() Handles SpeedControl.Stopped
        pnlSub.Controls.Clear()

        krConnectorSpeed.Disconnect()
        VarsConnectedSpeed = False

        SpeedControl.Disconnect()
    End Sub

#End Region

#Region "Navigational button events"

    Private Sub btnAlarms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlarms.Click, krAlarmView.ItemClick
        SubFormChange(SubAlarms)
    End Sub

    Private Sub BtnOverview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOverview.Click
        SubFormChange(SubOverview)
    End Sub

    Private Sub BtnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSettings.Click
        SubFormChange(SubSettings)
    End Sub

    Private Sub Btn_Service_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Service.Click
        SubFormChange(SubService)
    End Sub

    Private Sub Btn_Init_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInit.Click
        SubFormChange(SubInit)
    End Sub

    Private Sub btnProduct_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProduct.Click
        SubFormChange(SubProduct)
    End Sub

    Private Sub btnGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeneral.Click
        SubFormChange(SubGeneral)
    End Sub

    Private Sub lstAlarms_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs)
        SubFormChange(SubAlarms)
    End Sub

#End Region

#Region "AlarmWords"

#Region "IMD"

    Private Sub AlarmWord1_DataChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlarmWord1.DataChanged
        KremerAlarmWord1.Data = AlarmWord1.Data
    End Sub
    Private Sub AlarmWord2_DataChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlarmWord2.DataChanged
        KremerAlarmWord2.Data = AlarmWord2.Data
    End Sub
    Private Sub AlarmWord3_DataChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlarmWord3.DataChanged
        KremerAlarmWord3.Data = AlarmWord3.Data
    End Sub
    Private Sub AlarmWord4_DataChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlarmWord4.DataChanged
        KremerAlarmWord4.Data = AlarmWord4.Data
    End Sub
    Private Sub AlarmWord5_DataChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlarmWord5.DataChanged
        KremerAlarmWord5.Data = AlarmWord5.Data
    End Sub
    Private Sub AlarmWord6_DataChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlarmWord6.DataChanged
        KremerAlarmWord6.Data = AlarmWord6.Data
    End Sub
    Private Sub AlarmWord7_DataChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlarmWord7.DataChanged
        KremerAlarmWord7.Data = AlarmWord7.Data
    End Sub
    Private Sub AlarmWord8_DataChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlarmWord8.DataChanged
        KremerAlarmWord8.Data = AlarmWord8.Data
    End Sub
    Private Sub AlarmWord9_DataChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlarmWord9.DataChanged
        KremerAlarmWord9.Data = AlarmWord9.Data
    End Sub

    Private Sub AlarmWord10_DataChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlarmWord10.DataChanged
        KremerAlarmWord10.Data = AlarmWord10.Data
    End Sub

    Private Sub AlarmWord11_DataChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlarmWord11.DataChanged
        KremerAlarmWord11.Data = AlarmWord11.Data
    End Sub

    Private Sub AlarmWord12_DataChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlarmWord12.DataChanged
        KremerAlarmWord12.Data = AlarmWord12.Data
    End Sub

    Private Sub AlarmWord13_DataChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlarmWord13.DataChanged
        KremerAlarmWord13.Data = AlarmWord13.Data
    End Sub

    Private Sub AlarmWord14_DataChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlarmWord14.DataChanged
        KremerAlarmWord14.Data = AlarmWord14.Data
    End Sub

    Private Sub AlarmWord15_DataChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlarmWord15.DataChanged
        KremerAlarmWord15.Data = AlarmWord15.Data
    End Sub

    Private Sub AlarmWord16_DataChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlarmWord16.DataChanged
        KremerAlarmWord16.Data = AlarmWord16.Data
    End Sub

    Private Sub AlarmWord17_DataChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlarmWord17.DataChanged
        KremerAlarmWord17.Data = AlarmWord17.Data
    End Sub

    Private Sub AlarmWord18_DataChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlarmWord18.DataChanged
        KremerAlarmWord18.Data = AlarmWord18.Data
    End Sub

    Private Sub AlarmWord19_DataChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlarmWord19.DataChanged
        KremerAlarmWord19.Data = AlarmWord19.Data
    End Sub

    Private Sub AlarmWord20_DataChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles AlarmWord20.DataChanged
        KremerAlarmWord20.Data = AlarmWord20.Data
    End Sub

#End Region

#Region "Speed control"

    Private Sub Alarmword1SpdCtrl_DataChanged(sender As Object, e As EventArgs) Handles Alarmword1SpdCtrl.DataChanged
        SPDControlAlarmWord1.Data = Alarmword1SpdCtrl.Data
    End Sub

    Private Sub Alarmword2SpdCtrl_DataChanged(sender As Object, e As EventArgs) Handles Alarmword2SpdCtrl.DataChanged
        SPDControlAlarmWord2.Data = Alarmword2SpdCtrl.Data
    End Sub

#End Region



#End Region

#Region "PLC vars data changed"

    Private Sub mxProduktDataLoaded_DataChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mxProduktDataLoaded.DataChanged
        ProductDataLoaded = mxProduktDataLoaded.Data
    End Sub

    Private Sub mxManualAutomode_DataChanged() Handles mxManualAutomode.DataChanged
        If mxManualAutomode.Data Then
            btnInit.Enabled = True
        Else
            btnInit.Enabled = False
        End If
    End Sub

    Private Sub GodMode_DataChanged(sender As Object, e As EventArgs) Handles GodMode.DataChanged

        TxtGodMode.Visible = GodMode.Data

    End Sub

#End Region


End Class