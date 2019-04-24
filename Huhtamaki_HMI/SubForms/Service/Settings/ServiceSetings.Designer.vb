<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiceSettings
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.krConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.krVarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.GodModeData = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnGodMode = New KremerControlsWin32.KremerButton()
        Me.GodModeState = New KremerControlsWin32.KremerVariable(Me.components)
        Me.RHSR_TRinBTM = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TR_In_BotTemp = New KremerControlsWin32.KremerIoField(Me.components)
        Me.MinTrPosRHSR = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_MinTrPosRHSR = New KremerControlsWin32.KremerIoField(Me.components)
        Me.MinTrDowntoSprayReleaseRHSR = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_MinTrDwnSprayReleaseRHSR = New KremerControlsWin32.KremerIoField(Me.components)
        Me.MinTrUpFromSprayReleasePosRHSR = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_MinTrUpSprayReleasePosRHSR = New KremerControlsWin32.KremerIoField(Me.components)
        Me.MinTmAPostoAllowMoveRHSR = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_MinTmAPosToAllowBmMoveRHSR = New KremerControlsWin32.KremerIoField(Me.components)
        Me.MinTmBPostoAllowMoveRHSR = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_MinTmBPosToAllowBmMoveRHSR = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Settings = New System.Windows.Forms.Button()
        Me.Btn_Settings2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Input_EndOfTrack_Pos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.KremerIoField4 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.KremerIoField1 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.KremerIoField12 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.lbl_puh = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.IO_SpraybarRestBackOffset = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.SpraybarOffsetPosRHSR = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'krConnector
        '
        Me.krConnector.VarCollector = Nothing
        '
        'krVarCollector
        '
        Me.krVarCollector.Variables.Add(Me.GodModeData)
        Me.krVarCollector.Variables.Add(Me.GodModeState)
        Me.krVarCollector.Variables.Add(Me.RHSR_TRinBTM)
        Me.krVarCollector.Variables.Add(Me.MinTrPosRHSR)
        Me.krVarCollector.Variables.Add(Me.MinTrDowntoSprayReleaseRHSR)
        Me.krVarCollector.Variables.Add(Me.MinTrUpFromSprayReleasePosRHSR)
        Me.krVarCollector.Variables.Add(Me.MinTmAPostoAllowMoveRHSR)
        Me.krVarCollector.Variables.Add(Me.MinTmBPostoAllowMoveRHSR)
        Me.krVarCollector.Variables.Add(Me.SpraybarOffsetPosRHSR)
        '
        'GodModeData
        '
        Me.GodModeData.BindControl = Me.BtnGodMode
        Me.GodModeData.BindProperty = "Data"
        Me.GodModeData.Data = Nothing
        Me.GodModeData.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GodModeData.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GodModeData.VariableName = "MAIN.InMoldDrying.MachParameters.CommisioningMode"
        '
        'BtnGodMode
        '
        Me.BtnGodMode.Audit = Nothing
        Me.BtnGodMode.AuditEnabled = False
        Me.BtnGodMode.AuditMessage = "KremerPushButton pressed!"
        Me.BtnGodMode.AuditSource = "KremerPushButton"
        Me.BtnGodMode.BackColorOn = System.Drawing.Color.Blue
        Me.BtnGodMode.BackGroundImageOn = Nothing
        Me.BtnGodMode.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.BtnGodMode.Data = False
        Me.BtnGodMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGodMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGodMode.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnGodMode.Location = New System.Drawing.Point(256, 36)
        Me.BtnGodMode.Name = "BtnGodMode"
        Me.BtnGodMode.Size = New System.Drawing.Size(104, 47)
        Me.BtnGodMode.State = False
        Me.BtnGodMode.StateIsData = False
        Me.BtnGodMode.StateText = New String() {Nothing, Nothing}
        Me.BtnGodMode.TabIndex = 379
        Me.BtnGodMode.Text = "ON"
        Me.BtnGodMode.UserInfo = Nothing
        Me.BtnGodMode.UserLevel = 0
        Me.BtnGodMode.UseStateText = False
        Me.BtnGodMode.UseVisualStyleBackColor = False
        '
        'GodModeState
        '
        Me.GodModeState.BindControl = Me.BtnGodMode
        Me.GodModeState.BindProperty = "State"
        Me.GodModeState.Data = Nothing
        Me.GodModeState.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GodModeState.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GodModeState.VariableName = "MAIN.InMoldDrying.MachParameters.CommisioningMode"
        '
        'RHSR_TRinBTM
        '
        Me.RHSR_TRinBTM.BindControl = Me.IO_TR_In_BotTemp
        Me.RHSR_TRinBTM.BindProperty = "Data"
        Me.RHSR_TRinBTM.Data = Nothing
        Me.RHSR_TRinBTM.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.RHSR_TRinBTM.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.RHSR_TRinBTM.VariableName = "MAIN.InMoldDrying.MachParameters.MinTempAlowTransferToBot"
        '
        'IO_TR_In_BotTemp
        '
        Me.IO_TR_In_BotTemp.Audit = Nothing
        Me.IO_TR_In_BotTemp.AuditEnabled = False
        Me.IO_TR_In_BotTemp.AuditMessage = "KremerIoField changed:"
        Me.IO_TR_In_BotTemp.AuditSource = "KremerIoField"
        Me.IO_TR_In_BotTemp.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.IO_TR_In_BotTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO_TR_In_BotTemp.Data = 0.0R
        Me.IO_TR_In_BotTemp.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TR_In_BotTemp.InitialValue = True
        Me.IO_TR_In_BotTemp.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TR_In_BotTemp.Location = New System.Drawing.Point(256, 166)
        Me.IO_TR_In_BotTemp.LowerBound = 0.0R
        Me.IO_TR_In_BotTemp.Name = "IO_TR_In_BotTemp"
        Me.IO_TR_In_BotTemp.OutputFormat = "0.0 °C"
        Me.IO_TR_In_BotTemp.Size = New System.Drawing.Size(104, 34)
        Me.IO_TR_In_BotTemp.TabIndex = 383
        Me.IO_TR_In_BotTemp.Text = "0.0 °C"
        Me.IO_TR_In_BotTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IO_TR_In_BotTemp.UpperBound = 400.0R
        Me.IO_TR_In_BotTemp.UserInfo = Nothing
        Me.IO_TR_In_BotTemp.UserLevel = 0
        '
        'MinTrPosRHSR
        '
        Me.MinTrPosRHSR.BindControl = Me.IO_MinTrPosRHSR
        Me.MinTrPosRHSR.BindProperty = "Data"
        Me.MinTrPosRHSR.Data = Nothing
        Me.MinTrPosRHSR.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.MinTrPosRHSR.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.MinTrPosRHSR.VariableName = "MAIN.MachPar.InMoldDrying.MinimumTransferPosRHSR"
        '
        'IO_MinTrPosRHSR
        '
        Me.IO_MinTrPosRHSR.Audit = Nothing
        Me.IO_MinTrPosRHSR.AuditEnabled = False
        Me.IO_MinTrPosRHSR.AuditMessage = "KremerIoField changed:"
        Me.IO_MinTrPosRHSR.AuditSource = "KremerIoField"
        Me.IO_MinTrPosRHSR.BackColor = System.Drawing.Color.White
        Me.IO_MinTrPosRHSR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_MinTrPosRHSR.Data = 0.0R
        Me.IO_MinTrPosRHSR.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_MinTrPosRHSR.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_MinTrPosRHSR.InitialValue = True
        Me.IO_MinTrPosRHSR.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_MinTrPosRHSR.Location = New System.Drawing.Point(689, 36)
        Me.IO_MinTrPosRHSR.LowerBound = 0.0R
        Me.IO_MinTrPosRHSR.Name = "IO_MinTrPosRHSR"
        Me.IO_MinTrPosRHSR.OutputFormat = "0.0 mm"
        Me.IO_MinTrPosRHSR.Size = New System.Drawing.Size(100, 22)
        Me.IO_MinTrPosRHSR.TabIndex = 416
        Me.IO_MinTrPosRHSR.Text = "0.0 mm"
        Me.IO_MinTrPosRHSR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_MinTrPosRHSR.UpperBound = 1000.0R
        Me.IO_MinTrPosRHSR.UserInfo = Nothing
        Me.IO_MinTrPosRHSR.UserLevel = 500
        '
        'MinTrDowntoSprayReleaseRHSR
        '
        Me.MinTrDowntoSprayReleaseRHSR.BindControl = Me.IO_MinTrDwnSprayReleaseRHSR
        Me.MinTrDowntoSprayReleaseRHSR.BindProperty = "Data"
        Me.MinTrDowntoSprayReleaseRHSR.Data = Nothing
        Me.MinTrDowntoSprayReleaseRHSR.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.MinTrDowntoSprayReleaseRHSR.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.MinTrDowntoSprayReleaseRHSR.VariableName = "MAIN.MachPar.InMoldDrying.MinimumTrDownSprayReleasePosRHSR"
        '
        'IO_MinTrDwnSprayReleaseRHSR
        '
        Me.IO_MinTrDwnSprayReleaseRHSR.Audit = Nothing
        Me.IO_MinTrDwnSprayReleaseRHSR.AuditEnabled = False
        Me.IO_MinTrDwnSprayReleaseRHSR.AuditMessage = "KremerIoField changed:"
        Me.IO_MinTrDwnSprayReleaseRHSR.AuditSource = "KremerIoField"
        Me.IO_MinTrDwnSprayReleaseRHSR.BackColor = System.Drawing.Color.White
        Me.IO_MinTrDwnSprayReleaseRHSR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_MinTrDwnSprayReleaseRHSR.Data = 0.0R
        Me.IO_MinTrDwnSprayReleaseRHSR.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_MinTrDwnSprayReleaseRHSR.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_MinTrDwnSprayReleaseRHSR.InitialValue = True
        Me.IO_MinTrDwnSprayReleaseRHSR.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_MinTrDwnSprayReleaseRHSR.Location = New System.Drawing.Point(691, 241)
        Me.IO_MinTrDwnSprayReleaseRHSR.LowerBound = 0.0R
        Me.IO_MinTrDwnSprayReleaseRHSR.Name = "IO_MinTrDwnSprayReleaseRHSR"
        Me.IO_MinTrDwnSprayReleaseRHSR.OutputFormat = "0.0 mm"
        Me.IO_MinTrDwnSprayReleaseRHSR.Size = New System.Drawing.Size(100, 22)
        Me.IO_MinTrDwnSprayReleaseRHSR.TabIndex = 419
        Me.IO_MinTrDwnSprayReleaseRHSR.Text = "0.0 mm"
        Me.IO_MinTrDwnSprayReleaseRHSR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_MinTrDwnSprayReleaseRHSR.UpperBound = 1000.0R
        Me.IO_MinTrDwnSprayReleaseRHSR.UserInfo = Nothing
        Me.IO_MinTrDwnSprayReleaseRHSR.UserLevel = 500
        '
        'MinTrUpFromSprayReleasePosRHSR
        '
        Me.MinTrUpFromSprayReleasePosRHSR.BindControl = Me.IO_MinTrUpSprayReleasePosRHSR
        Me.MinTrUpFromSprayReleasePosRHSR.BindProperty = "Data"
        Me.MinTrUpFromSprayReleasePosRHSR.Data = Nothing
        Me.MinTrUpFromSprayReleasePosRHSR.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.MinTrUpFromSprayReleasePosRHSR.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.MinTrUpFromSprayReleasePosRHSR.VariableName = "MAIN.MachPar.InMoldDrying.MinimumTrUpSprayReleasePosRHSR"
        '
        'IO_MinTrUpSprayReleasePosRHSR
        '
        Me.IO_MinTrUpSprayReleasePosRHSR.Audit = Nothing
        Me.IO_MinTrUpSprayReleasePosRHSR.AuditEnabled = False
        Me.IO_MinTrUpSprayReleasePosRHSR.AuditMessage = "KremerIoField changed:"
        Me.IO_MinTrUpSprayReleasePosRHSR.AuditSource = "KremerIoField"
        Me.IO_MinTrUpSprayReleasePosRHSR.BackColor = System.Drawing.Color.White
        Me.IO_MinTrUpSprayReleasePosRHSR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_MinTrUpSprayReleasePosRHSR.Data = 0.0R
        Me.IO_MinTrUpSprayReleasePosRHSR.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_MinTrUpSprayReleasePosRHSR.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_MinTrUpSprayReleasePosRHSR.InitialValue = True
        Me.IO_MinTrUpSprayReleasePosRHSR.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_MinTrUpSprayReleasePosRHSR.Location = New System.Drawing.Point(689, 166)
        Me.IO_MinTrUpSprayReleasePosRHSR.LowerBound = 0.0R
        Me.IO_MinTrUpSprayReleasePosRHSR.Name = "IO_MinTrUpSprayReleasePosRHSR"
        Me.IO_MinTrUpSprayReleasePosRHSR.OutputFormat = "0.0 mm"
        Me.IO_MinTrUpSprayReleasePosRHSR.Size = New System.Drawing.Size(100, 22)
        Me.IO_MinTrUpSprayReleasePosRHSR.TabIndex = 421
        Me.IO_MinTrUpSprayReleasePosRHSR.Text = "0.0 mm"
        Me.IO_MinTrUpSprayReleasePosRHSR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_MinTrUpSprayReleasePosRHSR.UpperBound = 1000.0R
        Me.IO_MinTrUpSprayReleasePosRHSR.UserInfo = Nothing
        Me.IO_MinTrUpSprayReleasePosRHSR.UserLevel = 500
        '
        'MinTmAPostoAllowMoveRHSR
        '
        Me.MinTmAPostoAllowMoveRHSR.BindControl = Me.IO_MinTmAPosToAllowBmMoveRHSR
        Me.MinTmAPostoAllowMoveRHSR.BindProperty = "Data"
        Me.MinTmAPostoAllowMoveRHSR.Data = Nothing
        Me.MinTmAPostoAllowMoveRHSR.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.MinTmAPostoAllowMoveRHSR.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.MinTmAPostoAllowMoveRHSR.VariableName = "MAIN.MachPar.InMoldDrying.MinimumTmAPosToAllowBmMove"
        '
        'IO_MinTmAPosToAllowBmMoveRHSR
        '
        Me.IO_MinTmAPosToAllowBmMoveRHSR.Audit = Nothing
        Me.IO_MinTmAPosToAllowBmMoveRHSR.AuditEnabled = False
        Me.IO_MinTmAPosToAllowBmMoveRHSR.AuditMessage = "KremerIoField changed:"
        Me.IO_MinTmAPosToAllowBmMoveRHSR.AuditSource = "KremerIoField"
        Me.IO_MinTmAPosToAllowBmMoveRHSR.BackColor = System.Drawing.Color.White
        Me.IO_MinTmAPosToAllowBmMoveRHSR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_MinTmAPosToAllowBmMoveRHSR.Data = 0.0R
        Me.IO_MinTmAPosToAllowBmMoveRHSR.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_MinTmAPosToAllowBmMoveRHSR.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_MinTmAPosToAllowBmMoveRHSR.InitialValue = True
        Me.IO_MinTmAPosToAllowBmMoveRHSR.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_MinTmAPosToAllowBmMoveRHSR.Location = New System.Drawing.Point(689, 87)
        Me.IO_MinTmAPosToAllowBmMoveRHSR.LowerBound = 0.0R
        Me.IO_MinTmAPosToAllowBmMoveRHSR.Name = "IO_MinTmAPosToAllowBmMoveRHSR"
        Me.IO_MinTmAPosToAllowBmMoveRHSR.OutputFormat = "0.0 mm"
        Me.IO_MinTmAPosToAllowBmMoveRHSR.Size = New System.Drawing.Size(100, 22)
        Me.IO_MinTmAPosToAllowBmMoveRHSR.TabIndex = 423
        Me.IO_MinTmAPosToAllowBmMoveRHSR.Text = "0.0 mm"
        Me.IO_MinTmAPosToAllowBmMoveRHSR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_MinTmAPosToAllowBmMoveRHSR.UpperBound = 5000.0R
        Me.IO_MinTmAPosToAllowBmMoveRHSR.UserInfo = Nothing
        Me.IO_MinTmAPosToAllowBmMoveRHSR.UserLevel = 800
        '
        'MinTmBPostoAllowMoveRHSR
        '
        Me.MinTmBPostoAllowMoveRHSR.BindControl = Me.IO_MinTmBPosToAllowBmMoveRHSR
        Me.MinTmBPostoAllowMoveRHSR.BindProperty = "Data"
        Me.MinTmBPostoAllowMoveRHSR.Data = Nothing
        Me.MinTmBPostoAllowMoveRHSR.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.MinTmBPostoAllowMoveRHSR.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.MinTmBPostoAllowMoveRHSR.VariableName = "MAIN.MachPar.InMoldDrying.MinimumTmBPosToAllowBmMove"
        '
        'IO_MinTmBPosToAllowBmMoveRHSR
        '
        Me.IO_MinTmBPosToAllowBmMoveRHSR.Audit = Nothing
        Me.IO_MinTmBPosToAllowBmMoveRHSR.AuditEnabled = False
        Me.IO_MinTmBPosToAllowBmMoveRHSR.AuditMessage = "KremerIoField changed:"
        Me.IO_MinTmBPosToAllowBmMoveRHSR.AuditSource = "KremerIoField"
        Me.IO_MinTmBPosToAllowBmMoveRHSR.BackColor = System.Drawing.Color.White
        Me.IO_MinTmBPosToAllowBmMoveRHSR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_MinTmBPosToAllowBmMoveRHSR.Data = 0.0R
        Me.IO_MinTmBPosToAllowBmMoveRHSR.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_MinTmBPosToAllowBmMoveRHSR.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_MinTmBPosToAllowBmMoveRHSR.InitialValue = True
        Me.IO_MinTmBPosToAllowBmMoveRHSR.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_MinTmBPosToAllowBmMoveRHSR.Location = New System.Drawing.Point(689, 112)
        Me.IO_MinTmBPosToAllowBmMoveRHSR.LowerBound = 0.0R
        Me.IO_MinTmBPosToAllowBmMoveRHSR.Name = "IO_MinTmBPosToAllowBmMoveRHSR"
        Me.IO_MinTmBPosToAllowBmMoveRHSR.OutputFormat = "0.0 mm"
        Me.IO_MinTmBPosToAllowBmMoveRHSR.Size = New System.Drawing.Size(100, 22)
        Me.IO_MinTmBPosToAllowBmMoveRHSR.TabIndex = 425
        Me.IO_MinTmBPosToAllowBmMoveRHSR.Text = "0.0 mm"
        Me.IO_MinTmBPosToAllowBmMoveRHSR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_MinTmBPosToAllowBmMoveRHSR.UpperBound = 5000.0R
        Me.IO_MinTmBPosToAllowBmMoveRHSR.UserInfo = Nothing
        Me.IO_MinTmBPosToAllowBmMoveRHSR.UserLevel = 800
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape7, Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 441)
        Me.ShapeContainer1.TabIndex = 355
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 397
        Me.LineShape5.X2 = 776
        Me.LineShape5.Y1 = 85
        Me.LineShape5.Y2 = 85
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 396
        Me.LineShape4.X2 = 775
        Me.LineShape4.Y1 = 34
        Me.LineShape4.Y2 = 34
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 20
        Me.LineShape3.X2 = 360
        Me.LineShape3.Y1 = 285
        Me.LineShape3.Y2 = 285
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 18
        Me.LineShape2.X2 = 360
        Me.LineShape2.Y1 = 152
        Me.LineShape2.Y2 = 152
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 15
        Me.LineShape1.X2 = 360
        Me.LineShape1.Y1 = 33
        Me.LineShape1.Y2 = 33
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(-1, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(165, 23)
        Me.Label18.TabIndex = 257
        Me.Label18.Tag = "97"
        Me.Label18.Text = "More Settings"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Btn_Settings)
        Me.Panel1.Controls.Add(Me.Btn_Settings2)
        Me.Panel1.Location = New System.Drawing.Point(632, 332)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(165, 106)
        Me.Panel1.TabIndex = 364
        '
        'Btn_Settings
        '
        Me.Btn_Settings.Enabled = False
        Me.Btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Settings.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Settings.Location = New System.Drawing.Point(3, 26)
        Me.Btn_Settings.Name = "Btn_Settings"
        Me.Btn_Settings.Size = New System.Drawing.Size(75, 75)
        Me.Btn_Settings.TabIndex = 255
        Me.Btn_Settings.Text = "<"
        Me.Btn_Settings.UseVisualStyleBackColor = True
        '
        'Btn_Settings2
        '
        Me.Btn_Settings2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Settings2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Settings2.Location = New System.Drawing.Point(84, 26)
        Me.Btn_Settings2.Name = "Btn_Settings2"
        Me.Btn_Settings2.Size = New System.Drawing.Size(75, 75)
        Me.Btn_Settings2.TabIndex = 254
        Me.Btn_Settings2.Text = ">"
        Me.Btn_Settings2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 82)
        Me.Label2.TabIndex = 378
        Me.Label2.Tag = ""
        Me.Label2.Text = "Disables all safety rules, and alows free movement of all parts. But beware, it c" & _
    "an destroy machine parts!"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 23)
        Me.Label1.TabIndex = 380
        Me.Label1.Tag = ""
        Me.Label1.Text = "Godmode"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(12, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 23)
        Me.Label3.TabIndex = 381
        Me.Label3.Tag = ""
        Me.Label3.Text = "Temperature for RHSR"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(246, 94)
        Me.Label4.TabIndex = 382
        Me.Label4.Tag = ""
        Me.Label4.Text = "Minimum temperature at which transfermold can still go into the bottomolds. Below" & _
    " this temperature movement is blocked by safety rule"
        '
        'Input_EndOfTrack_Pos
        '
        Me.Input_EndOfTrack_Pos.Audit = Nothing
        Me.Input_EndOfTrack_Pos.AuditEnabled = False
        Me.Input_EndOfTrack_Pos.AuditMessage = "KremerIoField changed:"
        Me.Input_EndOfTrack_Pos.AuditSource = "KremerIoField"
        Me.Input_EndOfTrack_Pos.BackColor = System.Drawing.Color.White
        Me.Input_EndOfTrack_Pos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Input_EndOfTrack_Pos.Data = 0.0R
        Me.Input_EndOfTrack_Pos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.Input_EndOfTrack_Pos.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input_EndOfTrack_Pos.InitialValue = True
        Me.Input_EndOfTrack_Pos.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.Input_EndOfTrack_Pos.Location = New System.Drawing.Point(256, 357)
        Me.Input_EndOfTrack_Pos.LowerBound = 0.0R
        Me.Input_EndOfTrack_Pos.Name = "Input_EndOfTrack_Pos"
        Me.Input_EndOfTrack_Pos.OutputFormat = "0.0 mm"
        Me.Input_EndOfTrack_Pos.Size = New System.Drawing.Size(100, 22)
        Me.Input_EndOfTrack_Pos.TabIndex = 414
        Me.Input_EndOfTrack_Pos.Text = "0.0 mm"
        Me.Input_EndOfTrack_Pos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Input_EndOfTrack_Pos.UpperBound = 5000.0R
        Me.Input_EndOfTrack_Pos.UserInfo = Nothing
        Me.Input_EndOfTrack_Pos.UserLevel = 800
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 359)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 23)
        Me.Label5.TabIndex = 413
        Me.Label5.Tag = ""
        Me.Label5.Text = "Machine pond Position zero offset"
        '
        'KremerIoField4
        '
        Me.KremerIoField4.Audit = Nothing
        Me.KremerIoField4.AuditEnabled = False
        Me.KremerIoField4.AuditMessage = "KremerIoField changed:"
        Me.KremerIoField4.AuditSource = "KremerIoField"
        Me.KremerIoField4.BackColor = System.Drawing.Color.White
        Me.KremerIoField4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KremerIoField4.Data = 0.0R
        Me.KremerIoField4.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.KremerIoField4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerIoField4.InitialValue = True
        Me.KremerIoField4.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.KremerIoField4.Location = New System.Drawing.Point(256, 334)
        Me.KremerIoField4.LowerBound = 0.0R
        Me.KremerIoField4.Name = "KremerIoField4"
        Me.KremerIoField4.OutputFormat = "0.0 mm"
        Me.KremerIoField4.Size = New System.Drawing.Size(100, 22)
        Me.KremerIoField4.TabIndex = 412
        Me.KremerIoField4.Text = "0.0 mm"
        Me.KremerIoField4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.KremerIoField4.UpperBound = 1000.0R
        Me.KremerIoField4.UserInfo = Nothing
        Me.KremerIoField4.UserLevel = 500
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 336)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(247, 23)
        Me.Label6.TabIndex = 411
        Me.Label6.Tag = ""
        Me.Label6.Text = "Transfermold offset Zero"
        '
        'KremerIoField1
        '
        Me.KremerIoField1.Audit = Nothing
        Me.KremerIoField1.AuditEnabled = False
        Me.KremerIoField1.AuditMessage = "KremerIoField changed:"
        Me.KremerIoField1.AuditSource = "KremerIoField"
        Me.KremerIoField1.BackColor = System.Drawing.Color.White
        Me.KremerIoField1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KremerIoField1.Data = 0.0R
        Me.KremerIoField1.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.KremerIoField1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerIoField1.InitialValue = True
        Me.KremerIoField1.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.KremerIoField1.Location = New System.Drawing.Point(256, 311)
        Me.KremerIoField1.LowerBound = 0.0R
        Me.KremerIoField1.Name = "KremerIoField1"
        Me.KremerIoField1.OutputFormat = "0.0 mm"
        Me.KremerIoField1.Size = New System.Drawing.Size(100, 22)
        Me.KremerIoField1.TabIndex = 410
        Me.KremerIoField1.Text = "0.0 mm"
        Me.KremerIoField1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.KremerIoField1.UpperBound = 1000.0R
        Me.KremerIoField1.UserInfo = Nothing
        Me.KremerIoField1.UserLevel = 500
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(14, 313)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(236, 23)
        Me.Label13.TabIndex = 409
        Me.Label13.Tag = ""
        Me.Label13.Text = "Top mold B offset zero"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(14, 290)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(236, 23)
        Me.Label17.TabIndex = 408
        Me.Label17.Tag = ""
        Me.Label17.Text = "Top mold A offset zero"
        '
        'KremerIoField12
        '
        Me.KremerIoField12.Audit = Nothing
        Me.KremerIoField12.AuditEnabled = False
        Me.KremerIoField12.AuditMessage = "KremerIoField changed:"
        Me.KremerIoField12.AuditSource = "KremerIoField"
        Me.KremerIoField12.BackColor = System.Drawing.Color.White
        Me.KremerIoField12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KremerIoField12.Data = 0.0R
        Me.KremerIoField12.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.KremerIoField12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerIoField12.InitialValue = True
        Me.KremerIoField12.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.KremerIoField12.Location = New System.Drawing.Point(256, 288)
        Me.KremerIoField12.LowerBound = 0.0R
        Me.KremerIoField12.Name = "KremerIoField12"
        Me.KremerIoField12.OutputFormat = "0.0 mm"
        Me.KremerIoField12.Size = New System.Drawing.Size(100, 22)
        Me.KremerIoField12.TabIndex = 407
        Me.KremerIoField12.Text = "0.0 mm"
        Me.KremerIoField12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.KremerIoField12.UpperBound = 1000.0R
        Me.KremerIoField12.UserInfo = Nothing
        Me.KremerIoField12.UserLevel = 500
        '
        'lbl_puh
        '
        Me.lbl_puh.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_puh.Location = New System.Drawing.Point(14, 259)
        Me.lbl_puh.Name = "lbl_puh"
        Me.lbl_puh.Size = New System.Drawing.Size(247, 23)
        Me.lbl_puh.TabIndex = 406
        Me.lbl_puh.Tag = ""
        Me.lbl_puh.Text = "Offset position settings"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(392, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(397, 23)
        Me.Label7.TabIndex = 415
        Me.Label7.Tag = ""
        Me.Label7.Text = "RHSR Trmold and bottommold move"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(392, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(291, 23)
        Me.Label8.TabIndex = 422
        Me.Label8.Tag = ""
        Me.Label8.Text = "Min TMA pos to allow bot to move"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(392, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(291, 23)
        Me.Label9.TabIndex = 420
        Me.Label9.Tag = ""
        Me.Label9.Text = "Min Tr Pos up to release spraybar"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(394, 241)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(291, 23)
        Me.Label10.TabIndex = 418
        Me.Label10.Tag = ""
        Me.Label10.Text = "Min TR Pos down release spraybar"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(392, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(291, 23)
        Me.Label11.TabIndex = 417
        Me.Label11.Tag = ""
        Me.Label11.Text = "Min TR pos to move bot"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(392, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(291, 23)
        Me.Label12.TabIndex = 424
        Me.Label12.Tag = ""
        Me.Label12.Text = "Min TMB pos to allow bot to move"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(392, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(397, 23)
        Me.Label14.TabIndex = 426
        Me.Label14.Tag = ""
        Me.Label14.Text = "RHSR Topmold and bottommold move"
        '
        'IO_SpraybarRestBackOffset
        '
        Me.IO_SpraybarRestBackOffset.Audit = Nothing
        Me.IO_SpraybarRestBackOffset.AuditEnabled = False
        Me.IO_SpraybarRestBackOffset.AuditMessage = "KremerIoField changed:"
        Me.IO_SpraybarRestBackOffset.AuditSource = "KremerIoField"
        Me.IO_SpraybarRestBackOffset.BackColor = System.Drawing.Color.White
        Me.IO_SpraybarRestBackOffset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_SpraybarRestBackOffset.Data = 0.0R
        Me.IO_SpraybarRestBackOffset.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_SpraybarRestBackOffset.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_SpraybarRestBackOffset.InitialValue = True
        Me.IO_SpraybarRestBackOffset.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_SpraybarRestBackOffset.Location = New System.Drawing.Point(689, 189)
        Me.IO_SpraybarRestBackOffset.LowerBound = 0.0R
        Me.IO_SpraybarRestBackOffset.Name = "IO_SpraybarRestBackOffset"
        Me.IO_SpraybarRestBackOffset.OutputFormat = "0.0 mm"
        Me.IO_SpraybarRestBackOffset.Size = New System.Drawing.Size(100, 22)
        Me.IO_SpraybarRestBackOffset.TabIndex = 428
        Me.IO_SpraybarRestBackOffset.Text = "0.0 mm"
        Me.IO_SpraybarRestBackOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_SpraybarRestBackOffset.UpperBound = 1000.0R
        Me.IO_SpraybarRestBackOffset.UserInfo = Nothing
        Me.IO_SpraybarRestBackOffset.UserLevel = 500
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(392, 189)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(291, 23)
        Me.Label15.TabIndex = 427
        Me.Label15.Tag = ""
        Me.Label15.Text = "Spraybar rest back offset pos"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(392, 139)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(397, 23)
        Me.Label16.TabIndex = 429
        Me.Label16.Tag = ""
        Me.Label16.Text = "RHSR Tr moves up, spraybar starts moving"
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 398
        Me.LineShape6.X2 = 777
        Me.LineShape6.Y1 = 163
        Me.LineShape6.Y2 = 163
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(392, 215)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(397, 23)
        Me.Label19.TabIndex = 430
        Me.Label19.Tag = ""
        Me.Label19.Text = "RHSR Tr moves down, spraybar starts"
        '
        'LineShape7
        '
        Me.LineShape7.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 396
        Me.LineShape7.X2 = 775
        Me.LineShape7.Y1 = 239
        Me.LineShape7.Y2 = 239
        '
        'SpraybarOffsetPosRHSR
        '
        Me.SpraybarOffsetPosRHSR.BindControl = Me.IO_SpraybarRestBackOffset
        Me.SpraybarOffsetPosRHSR.BindProperty = "Data"
        Me.SpraybarOffsetPosRHSR.Data = Nothing
        Me.SpraybarOffsetPosRHSR.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.SpraybarOffsetPosRHSR.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SpraybarOffsetPosRHSR.VariableName = "MAIN.MachPar.InMoldDrying.SprayBTrCollisionOffset"
        '
        'ServiceSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.IO_SpraybarRestBackOffset)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.IO_MinTmBPosToAllowBmMoveRHSR)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.IO_MinTmAPosToAllowBmMoveRHSR)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.IO_MinTrUpSprayReleasePosRHSR)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.IO_MinTrDwnSprayReleaseRHSR)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.IO_MinTrPosRHSR)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Input_EndOfTrack_Pos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.KremerIoField4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.KremerIoField1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.KremerIoField12)
        Me.Controls.Add(Me.lbl_puh)
        Me.Controls.Add(Me.IO_TR_In_BotTemp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnGodMode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "ServiceSettings"
        Me.Size = New System.Drawing.Size(800, 441)
        Me.Tag = "503"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents krConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents krVarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btn_Settings As System.Windows.Forms.Button
    Friend WithEvents Btn_Settings2 As System.Windows.Forms.Button
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnGodMode As KremerControlsWin32.KremerButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GodModeData As KremerControlsWin32.KremerVariable
    Friend WithEvents GodModeState As KremerControlsWin32.KremerVariable
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents IO_TR_In_BotTemp As KremerControlsWin32.KremerIoField
    Friend WithEvents RHSR_TRinBTM As KremerControlsWin32.KremerVariable
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Input_EndOfTrack_Pos As KremerControlsWin32.KremerIoField
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents KremerIoField4 As KremerControlsWin32.KremerIoField
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents KremerIoField1 As KremerControlsWin32.KremerIoField
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents KremerIoField12 As KremerControlsWin32.KremerIoField
    Friend WithEvents lbl_puh As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MinTrPosRHSR As KremerControlsWin32.KremerVariable
    Friend WithEvents MinTrDowntoSprayReleaseRHSR As KremerControlsWin32.KremerVariable
    Friend WithEvents MinTrUpFromSprayReleasePosRHSR As KremerControlsWin32.KremerVariable
    Friend WithEvents MinTmAPostoAllowMoveRHSR As KremerControlsWin32.KremerVariable
    Friend WithEvents MinTmBPostoAllowMoveRHSR As KremerControlsWin32.KremerVariable
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents IO_MinTmAPosToAllowBmMoveRHSR As KremerControlsWin32.KremerIoField
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents IO_MinTrUpSprayReleasePosRHSR As KremerControlsWin32.KremerIoField
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents IO_MinTrDwnSprayReleaseRHSR As KremerControlsWin32.KremerIoField
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents IO_MinTrPosRHSR As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_MinTmBPosToAllowBmMoveRHSR As KremerControlsWin32.KremerIoField
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents IO_SpraybarRestBackOffset As KremerControlsWin32.KremerIoField
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents SpraybarOffsetPosRHSR As KremerControlsWin32.KremerVariable

End Class
