<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DryingMoldDetail_Bot_Settings
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
        Me.Btn_Overview = New KremerControlsWin32.KremerButton()
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.AutoBtn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnAuto = New KremerControlsWin32.KremerButton()
        Me.AutoBtnState = New KremerControlsWin32.KremerVariable(Me.components)
        Me.SetpointBtn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnSetpoint = New KremerControlsWin32.KremerButton()
        Me.SetpointBtnState = New KremerControlsWin32.KremerVariable(Me.components)
        Me.OutputBtn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnOut = New KremerControlsWin32.KremerButton()
        Me.OutputBtnState = New KremerControlsWin32.KremerVariable(Me.components)
        Me.SP_MAN = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_SPHand = New KremerControlsWin32.KremerIoField(Me.components)
        Me.SP_AUTO_TOTAL = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BAR_SP = New KremerControlsWin32.KremerShape()
        Me.SP_AUTOTOTAL2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_SP_AUTO = New KremerControlsWin32.KremerIoField(Me.components)
        Me.SP_Act = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_SP_ACT = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PV_ACT = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BAR_PV = New KremerControlsWin32.KremerShape()
        Me.PV_ACT2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_PVACT = New KremerControlsWin32.KremerIoField(Me.components)
        Me.OutACT = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BAR_CV = New KremerControlsWin32.KremerShape()
        Me.OutAct2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_OUTACT = New KremerControlsWin32.KremerIoField(Me.components)
        Me.P = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_Gain = New KremerControlsWin32.KremerIoField(Me.components)
        Me.I = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_Ti = New KremerControlsWin32.KremerIoField(Me.components)
        Me.D = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_Tv = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Dt = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_Td = New KremerControlsWin32.KremerIoField(Me.components)
        Me.DEADBAND = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_Deadband = New KremerControlsWin32.KremerIoField(Me.components)
        Me.SP_ROC_EXT = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_ROC_Limit_SP = New KremerControlsWin32.KremerIoField(Me.components)
        Me.OUT_ROC_UP = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_ROC_Limit_Out_Up = New KremerControlsWin32.KremerIoField(Me.components)
        Me.OUT_ROC_DOWN = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_ROC_Limit_OutDown = New KremerControlsWin32.KremerIoField(Me.components)
        Me.OUT_MIN = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_OutMin = New KremerControlsWin32.KremerIoField(Me.components)
        Me.OUT_MAX = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_OutMax = New KremerControlsWin32.KremerIoField(Me.components)
        Me.SP_MIN = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_SetpointMin = New KremerControlsWin32.KremerIoField(Me.components)
        Me.SP_MAX = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_SetpointMax = New KremerControlsWin32.KremerIoField(Me.components)
        Me.OutManVal = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_OUTHAND = New KremerControlsWin32.KremerIoField(Me.components)
        Me.CalcSteps = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_CalcStep = New KremerControlsWin32.KremerIoField(Me.components)
        Me.NumberOfSteps = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_NrOfSteps = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PVLag = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_1SteOrder = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PWMperiodtime = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_PWMperiod = New KremerControlsWin32.KremerIoField(Me.components)
        Me.WaitTimeAfterStepReached = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_StepTimeReached = New KremerControlsWin32.KremerIoField(Me.components)
        Me.LiftLine = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SPBarIO_MIN = New KremerControlsWin32.KremerIoField(Me.components)
        Me.SPBarIO_MAX = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PVBarIO_MAX = New KremerControlsWin32.KremerIoField(Me.components)
        Me.OutBarIO_MAX = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PVBarIO_MIN = New KremerControlsWin32.KremerIoField(Me.components)
        Me.OutBarIO_MIN = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.KremerIoField1 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.KremerIoField2 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.SuspendLayout()
        '
        'Btn_Overview
        '
        Me.Btn_Overview.Audit = Nothing
        Me.Btn_Overview.AuditEnabled = False
        Me.Btn_Overview.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_Overview.AuditSource = "KremerPushButton"
        Me.Btn_Overview.BackColorOn = System.Drawing.Color.Empty
        Me.Btn_Overview.BackGroundImageOn = Nothing
        Me.Btn_Overview.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_Overview.Data = False
        Me.Btn_Overview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Overview.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Overview.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_Overview.Location = New System.Drawing.Point(686, 385)
        Me.Btn_Overview.Name = "Btn_Overview"
        Me.Btn_Overview.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Overview.State = False
        Me.Btn_Overview.StateIsData = True
        Me.Btn_Overview.StateText = New String() {Nothing, Nothing}
        Me.Btn_Overview.TabIndex = 257
        Me.Btn_Overview.Tag = "194"
        Me.Btn_Overview.Text = "Overview"
        Me.Btn_Overview.UserInfo = Nothing
        Me.Btn_Overview.UserLevel = 0
        Me.Btn_Overview.UseStateText = False
        Me.Btn_Overview.UseVisualStyleBackColor = True
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Me.VarCollector
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.AutoBtn)
        Me.VarCollector.Variables.Add(Me.AutoBtnState)
        Me.VarCollector.Variables.Add(Me.SetpointBtn)
        Me.VarCollector.Variables.Add(Me.SetpointBtnState)
        Me.VarCollector.Variables.Add(Me.OutputBtn)
        Me.VarCollector.Variables.Add(Me.OutputBtnState)
        Me.VarCollector.Variables.Add(Me.SP_MAN)
        Me.VarCollector.Variables.Add(Me.SP_AUTO_TOTAL)
        Me.VarCollector.Variables.Add(Me.SP_AUTOTOTAL2)
        Me.VarCollector.Variables.Add(Me.SP_Act)
        Me.VarCollector.Variables.Add(Me.PV_ACT)
        Me.VarCollector.Variables.Add(Me.PV_ACT2)
        Me.VarCollector.Variables.Add(Me.OutACT)
        Me.VarCollector.Variables.Add(Me.OutAct2)
        Me.VarCollector.Variables.Add(Me.P)
        Me.VarCollector.Variables.Add(Me.I)
        Me.VarCollector.Variables.Add(Me.D)
        Me.VarCollector.Variables.Add(Me.Dt)
        Me.VarCollector.Variables.Add(Me.DEADBAND)
        Me.VarCollector.Variables.Add(Me.SP_ROC_EXT)
        Me.VarCollector.Variables.Add(Me.OUT_ROC_UP)
        Me.VarCollector.Variables.Add(Me.OUT_ROC_DOWN)
        Me.VarCollector.Variables.Add(Me.OUT_MIN)
        Me.VarCollector.Variables.Add(Me.OUT_MAX)
        Me.VarCollector.Variables.Add(Me.SP_MIN)
        Me.VarCollector.Variables.Add(Me.SP_MAX)
        Me.VarCollector.Variables.Add(Me.OutManVal)
        Me.VarCollector.Variables.Add(Me.CalcSteps)
        Me.VarCollector.Variables.Add(Me.NumberOfSteps)
        Me.VarCollector.Variables.Add(Me.PVLag)
        Me.VarCollector.Variables.Add(Me.PWMperiodtime)
        Me.VarCollector.Variables.Add(Me.WaitTimeAfterStepReached)
        '
        'AutoBtn
        '
        Me.AutoBtn.BindControl = Me.BtnAuto
        Me.AutoBtn.BindProperty = "Data"
        Me.AutoBtn.Data = Nothing
        Me.AutoBtn.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.AutoBtn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AutoBtn.VariableName = "MAIN.InMoldDrying.[Position1].HeatingZone[[Position2]].FB_Heating_Controller.HMI_" & _
    "AutoBtn"
        '
        'BtnAuto
        '
        Me.BtnAuto.Audit = Nothing
        Me.BtnAuto.AuditEnabled = False
        Me.BtnAuto.AuditMessage = "KremerPushButton pressed!"
        Me.BtnAuto.AuditSource = "KremerPushButton"
        Me.BtnAuto.BackColor = System.Drawing.SystemColors.Control
        Me.BtnAuto.BackColorOn = System.Drawing.Color.Blue
        Me.BtnAuto.BackGroundImageOn = Nothing
        Me.BtnAuto.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnAuto.Data = False
        Me.BtnAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAuto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAuto.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnAuto.Location = New System.Drawing.Point(426, 274)
        Me.BtnAuto.Name = "BtnAuto"
        Me.BtnAuto.Size = New System.Drawing.Size(100, 50)
        Me.BtnAuto.State = False
        Me.BtnAuto.StateIsData = False
        Me.BtnAuto.StateText = New String() {Nothing, Nothing}
        Me.BtnAuto.TabIndex = 344
        Me.BtnAuto.Tag = "214"
        Me.BtnAuto.Text = "Auto"
        Me.BtnAuto.UserInfo = Nothing
        Me.BtnAuto.UserLevel = 0
        Me.BtnAuto.UseStateText = False
        Me.BtnAuto.UseVisualStyleBackColor = False
        '
        'AutoBtnState
        '
        Me.AutoBtnState.BindControl = Me.BtnAuto
        Me.AutoBtnState.BindProperty = "State"
        Me.AutoBtnState.Data = Nothing
        Me.AutoBtnState.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.AutoBtnState.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AutoBtnState.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].PIDTempZone" & _
    ".AutoState"
        '
        'SetpointBtn
        '
        Me.SetpointBtn.BindControl = Me.BtnSetpoint
        Me.SetpointBtn.BindProperty = "Data"
        Me.SetpointBtn.Data = Nothing
        Me.SetpointBtn.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.SetpointBtn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SetpointBtn.VariableName = "MAIN.InMoldDrying.[Position1].HeatingZone[[Position2]].FB_Heating_Controller.HMI_" & _
    "SetpointBtn"
        '
        'BtnSetpoint
        '
        Me.BtnSetpoint.Audit = Nothing
        Me.BtnSetpoint.AuditEnabled = False
        Me.BtnSetpoint.AuditMessage = "KremerPushButton pressed!"
        Me.BtnSetpoint.AuditSource = "KremerPushButton"
        Me.BtnSetpoint.BackColorOn = System.Drawing.Color.Blue
        Me.BtnSetpoint.BackGroundImageOn = Nothing
        Me.BtnSetpoint.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnSetpoint.Data = False
        Me.BtnSetpoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSetpoint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSetpoint.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnSetpoint.Location = New System.Drawing.Point(546, 274)
        Me.BtnSetpoint.Name = "BtnSetpoint"
        Me.BtnSetpoint.Size = New System.Drawing.Size(100, 50)
        Me.BtnSetpoint.State = False
        Me.BtnSetpoint.StateIsData = False
        Me.BtnSetpoint.StateText = New String() {Nothing, Nothing}
        Me.BtnSetpoint.TabIndex = 337
        Me.BtnSetpoint.Tag = "215"
        Me.BtnSetpoint.Text = "Setpoint Manual"
        Me.BtnSetpoint.UserInfo = Nothing
        Me.BtnSetpoint.UserLevel = 0
        Me.BtnSetpoint.UseStateText = False
        Me.BtnSetpoint.UseVisualStyleBackColor = True
        '
        'SetpointBtnState
        '
        Me.SetpointBtnState.BindControl = Me.BtnSetpoint
        Me.SetpointBtnState.BindProperty = "State"
        Me.SetpointBtnState.Data = Nothing
        Me.SetpointBtnState.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.SetpointBtnState.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SetpointBtnState.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].PIDTempZone" & _
    ".SetpointState"
        '
        'OutputBtn
        '
        Me.OutputBtn.BindControl = Me.BtnOut
        Me.OutputBtn.BindProperty = "Data"
        Me.OutputBtn.Data = Nothing
        Me.OutputBtn.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.OutputBtn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.OutputBtn.VariableName = "MAIN.InMoldDrying.[Position1].HeatingZone[[Position2]].FB_Heating_Controller.HMI_" & _
    "OutputBtn"
        '
        'BtnOut
        '
        Me.BtnOut.Audit = Nothing
        Me.BtnOut.AuditEnabled = False
        Me.BtnOut.AuditMessage = "KremerPushButton pressed!"
        Me.BtnOut.AuditSource = "KremerPushButton"
        Me.BtnOut.BackColorOn = System.Drawing.Color.Blue
        Me.BtnOut.BackGroundImageOn = Nothing
        Me.BtnOut.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnOut.Data = False
        Me.BtnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOut.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOut.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnOut.Location = New System.Drawing.Point(679, 274)
        Me.BtnOut.Name = "BtnOut"
        Me.BtnOut.Size = New System.Drawing.Size(100, 50)
        Me.BtnOut.State = False
        Me.BtnOut.StateIsData = False
        Me.BtnOut.StateText = New String() {Nothing, Nothing}
        Me.BtnOut.TabIndex = 342
        Me.BtnOut.Tag = "216"
        Me.BtnOut.Text = "Out"
        Me.BtnOut.UserInfo = Nothing
        Me.BtnOut.UserLevel = 0
        Me.BtnOut.UseStateText = False
        Me.BtnOut.UseVisualStyleBackColor = True
        '
        'OutputBtnState
        '
        Me.OutputBtnState.BindControl = Me.BtnOut
        Me.OutputBtnState.BindProperty = "State"
        Me.OutputBtnState.Data = Nothing
        Me.OutputBtnState.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.OutputBtnState.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.OutputBtnState.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].PIDTempZone" & _
    ".OutState"
        '
        'SP_MAN
        '
        Me.SP_MAN.BindControl = Me.IO_SPHand
        Me.SP_MAN.BindProperty = "Data"
        Me.SP_MAN.Data = Nothing
        Me.SP_MAN.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.SP_MAN.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SP_MAN.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].PIDTempZone" & _
    ".SP_MAN"
        '
        'IO_SPHand
        '
        Me.IO_SPHand.Audit = Nothing
        Me.IO_SPHand.AuditEnabled = False
        Me.IO_SPHand.AuditMessage = "KremerIoField changed:"
        Me.IO_SPHand.AuditSource = "KremerIoField"
        Me.IO_SPHand.BackColor = System.Drawing.Color.White
        Me.IO_SPHand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_SPHand.Data = 0.0R
        Me.IO_SPHand.DataType = KremerControlsWin32.KremerIoField.NumDataType.INT
        Me.IO_SPHand.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_SPHand.InitialValue = True
        Me.IO_SPHand.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_SPHand.Location = New System.Drawing.Point(546, 327)
        Me.IO_SPHand.LowerBound = -1000.0R
        Me.IO_SPHand.Name = "IO_SPHand"
        Me.IO_SPHand.OutputFormat = "0.00 °C"
        Me.IO_SPHand.Size = New System.Drawing.Size(100, 22)
        Me.IO_SPHand.TabIndex = 339
        Me.IO_SPHand.Text = "0.00 °C"
        Me.IO_SPHand.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_SPHand.UpperBound = 1000.0R
        Me.IO_SPHand.UserInfo = Nothing
        Me.IO_SPHand.UserLevel = 0
        '
        'SP_AUTO_TOTAL
        '
        Me.SP_AUTO_TOTAL.BindControl = Me.BAR_SP
        Me.SP_AUTO_TOTAL.BindProperty = "FillLevel"
        Me.SP_AUTO_TOTAL.Data = Nothing
        Me.SP_AUTO_TOTAL.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.SP_AUTO_TOTAL.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SP_AUTO_TOTAL.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].PIDTempZone" & _
    ".SP_AUTO_TOTAL"
        '
        'BAR_SP
        '
        Me.BAR_SP.Data = False
        Me.BAR_SP.Fill = True
        Me.BAR_SP.FillColor = System.Drawing.Color.Blue
        Me.BAR_SP.FillColorOn = System.Drawing.SystemColors.Control
        Me.BAR_SP.FillDirection = KremerControlsWin32.KremerShape.Direction.Up
        Me.BAR_SP.FillLevel = 50.0!
        Me.BAR_SP.FillMaximum = 250.0!
        Me.BAR_SP.FillMinimum = 0.0!
        Me.BAR_SP.Line = True
        Me.BAR_SP.LineColor = System.Drawing.Color.Black
        Me.BAR_SP.LineColorOn = System.Drawing.Color.Black
        Me.BAR_SP.LineSize = 1
        Me.BAR_SP.Location = New System.Drawing.Point(470, 45)
        Me.BAR_SP.Name = "BAR_SP"
        Me.BAR_SP.Size = New System.Drawing.Size(15, 175)
        Me.BAR_SP.Style = KremerControlsWin32.KremerShape.LineStyle.Solid
        Me.BAR_SP.TabIndex = 335
        Me.BAR_SP.Text = "BAR_SP"
        Me.BAR_SP.Type = KremerControlsWin32.KremerShape.ShapeType.Rectangle
        '
        'SP_AUTOTOTAL2
        '
        Me.SP_AUTOTOTAL2.BindControl = Me.IO_SP_AUTO
        Me.SP_AUTOTOTAL2.BindProperty = "Data"
        Me.SP_AUTOTOTAL2.Data = Nothing
        Me.SP_AUTOTOTAL2.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.SP_AUTOTOTAL2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SP_AUTOTOTAL2.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].PIDTempZone" & _
    ".SP_AUTO_TOTAL"
        '
        'IO_SP_AUTO
        '
        Me.IO_SP_AUTO.Audit = Nothing
        Me.IO_SP_AUTO.AuditEnabled = False
        Me.IO_SP_AUTO.AuditMessage = "KremerIoField changed:"
        Me.IO_SP_AUTO.AuditSource = "KremerIoField"
        Me.IO_SP_AUTO.BackColor = System.Drawing.Color.White
        Me.IO_SP_AUTO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_SP_AUTO.Data = 0.0R
        Me.IO_SP_AUTO.DataType = KremerControlsWin32.KremerIoField.NumDataType.INT
        Me.IO_SP_AUTO.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_SP_AUTO.InitialValue = True
        Me.IO_SP_AUTO.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_SP_AUTO.Location = New System.Drawing.Point(426, 327)
        Me.IO_SP_AUTO.LowerBound = -1000.0R
        Me.IO_SP_AUTO.Name = "IO_SP_AUTO"
        Me.IO_SP_AUTO.OutputFormat = "0.0 °C"
        Me.IO_SP_AUTO.Size = New System.Drawing.Size(100, 22)
        Me.IO_SP_AUTO.TabIndex = 345
        Me.IO_SP_AUTO.Text = "0.0 °C"
        Me.IO_SP_AUTO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_SP_AUTO.UpperBound = 1000.0R
        Me.IO_SP_AUTO.UserInfo = Nothing
        Me.IO_SP_AUTO.UserLevel = 0
        '
        'SP_Act
        '
        Me.SP_Act.BindControl = Me.IO_SP_ACT
        Me.SP_Act.BindProperty = "Data"
        Me.SP_Act.Data = Nothing
        Me.SP_Act.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.SP_Act.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SP_Act.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].PIDTempZone" & _
    ".SP_AUTO"
        '
        'IO_SP_ACT
        '
        Me.IO_SP_ACT.Audit = Nothing
        Me.IO_SP_ACT.AuditEnabled = False
        Me.IO_SP_ACT.AuditMessage = "KremerIoField changed:"
        Me.IO_SP_ACT.AuditSource = "KremerIoField"
        Me.IO_SP_ACT.Data = 0.0R
        Me.IO_SP_ACT.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_SP_ACT.InitialValue = True
        Me.IO_SP_ACT.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_SP_ACT.Location = New System.Drawing.Point(429, 246)
        Me.IO_SP_ACT.LowerBound = 0.0R
        Me.IO_SP_ACT.Name = "IO_SP_ACT"
        Me.IO_SP_ACT.OutputFormat = "0.00°C"
        Me.IO_SP_ACT.Size = New System.Drawing.Size(100, 21)
        Me.IO_SP_ACT.TabIndex = 351
        Me.IO_SP_ACT.Text = "0.00°C"
        Me.IO_SP_ACT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IO_SP_ACT.UpperBound = 1000.0R
        Me.IO_SP_ACT.UserInfo = Nothing
        Me.IO_SP_ACT.UserLevel = 0
        '
        'PV_ACT
        '
        Me.PV_ACT.BindControl = Me.BAR_PV
        Me.PV_ACT.BindProperty = "FillLevel"
        Me.PV_ACT.Data = Nothing
        Me.PV_ACT.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.PV_ACT.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PV_ACT.VariableName = "MAIN.InMoldDrying.[Position1].HeatingZone[[Position2]].FB_Heating_Controller.PV_E" & _
    "XT"
        '
        'BAR_PV
        '
        Me.BAR_PV.Data = False
        Me.BAR_PV.Fill = True
        Me.BAR_PV.FillColor = System.Drawing.Color.Lime
        Me.BAR_PV.FillColorOn = System.Drawing.SystemColors.Control
        Me.BAR_PV.FillDirection = KremerControlsWin32.KremerShape.Direction.Up
        Me.BAR_PV.FillLevel = 50.0!
        Me.BAR_PV.FillMaximum = 100.0!
        Me.BAR_PV.FillMinimum = 0.0!
        Me.BAR_PV.Line = True
        Me.BAR_PV.LineColor = System.Drawing.Color.Black
        Me.BAR_PV.LineColorOn = System.Drawing.Color.Black
        Me.BAR_PV.LineSize = 1
        Me.BAR_PV.Location = New System.Drawing.Point(595, 45)
        Me.BAR_PV.Name = "BAR_PV"
        Me.BAR_PV.Size = New System.Drawing.Size(15, 175)
        Me.BAR_PV.Style = KremerControlsWin32.KremerShape.LineStyle.Solid
        Me.BAR_PV.TabIndex = 336
        Me.BAR_PV.Text = "BAR_PV"
        Me.BAR_PV.Type = KremerControlsWin32.KremerShape.ShapeType.Rectangle
        '
        'PV_ACT2
        '
        Me.PV_ACT2.BindControl = Me.IO_PVACT
        Me.PV_ACT2.BindProperty = "Data"
        Me.PV_ACT2.Data = Nothing
        Me.PV_ACT2.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.PV_ACT2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PV_ACT2.VariableName = "MAIN.InMoldDrying.[Position1].HeatingZone[[Position2]].FB_Heating_Controller.PV_E" & _
    "XT"
        '
        'IO_PVACT
        '
        Me.IO_PVACT.Audit = Nothing
        Me.IO_PVACT.AuditEnabled = False
        Me.IO_PVACT.AuditMessage = "KremerIoField changed:"
        Me.IO_PVACT.AuditSource = "KremerIoField"
        Me.IO_PVACT.Data = 0.0R
        Me.IO_PVACT.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_PVACT.InitialValue = True
        Me.IO_PVACT.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_PVACT.Location = New System.Drawing.Point(555, 245)
        Me.IO_PVACT.LowerBound = 0.0R
        Me.IO_PVACT.Name = "IO_PVACT"
        Me.IO_PVACT.OutputFormat = "0.00°C"
        Me.IO_PVACT.Size = New System.Drawing.Size(100, 21)
        Me.IO_PVACT.TabIndex = 352
        Me.IO_PVACT.Text = "0.00°C"
        Me.IO_PVACT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IO_PVACT.UpperBound = 1000.0R
        Me.IO_PVACT.UserInfo = Nothing
        Me.IO_PVACT.UserLevel = 0
        '
        'OutACT
        '
        Me.OutACT.BindControl = Me.BAR_CV
        Me.OutACT.BindProperty = "FillLevel"
        Me.OutACT.Data = Nothing
        Me.OutACT.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.OutACT.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.OutACT.VariableName = "MAIN.InMoldDrying.[Position1].HeatingZone[[Position2]].FB_Heating_Controller.OUT_" & _
    "PID"
        '
        'BAR_CV
        '
        Me.BAR_CV.Data = False
        Me.BAR_CV.Fill = True
        Me.BAR_CV.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BAR_CV.FillColorOn = System.Drawing.SystemColors.Control
        Me.BAR_CV.FillDirection = KremerControlsWin32.KremerShape.Direction.Up
        Me.BAR_CV.FillLevel = 50.0!
        Me.BAR_CV.FillMaximum = 100.0!
        Me.BAR_CV.FillMinimum = 0.0!
        Me.BAR_CV.Line = True
        Me.BAR_CV.LineColor = System.Drawing.Color.Black
        Me.BAR_CV.LineColorOn = System.Drawing.Color.Black
        Me.BAR_CV.LineSize = 1
        Me.BAR_CV.Location = New System.Drawing.Point(724, 45)
        Me.BAR_CV.Name = "BAR_CV"
        Me.BAR_CV.Size = New System.Drawing.Size(15, 175)
        Me.BAR_CV.Style = KremerControlsWin32.KremerShape.LineStyle.Solid
        Me.BAR_CV.TabIndex = 341
        Me.BAR_CV.Text = "BAR_SP"
        Me.BAR_CV.Type = KremerControlsWin32.KremerShape.ShapeType.Rectangle
        '
        'OutAct2
        '
        Me.OutAct2.BindControl = Me.IO_OUTACT
        Me.OutAct2.BindProperty = "Data"
        Me.OutAct2.Data = Nothing
        Me.OutAct2.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.OutAct2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.OutAct2.VariableName = "MAIN.InMoldDrying.[Position1].HeatingZone[[Position2]].FB_Heating_Controller.OUT_" & _
    "PID"
        '
        'IO_OUTACT
        '
        Me.IO_OUTACT.Audit = Nothing
        Me.IO_OUTACT.AuditEnabled = False
        Me.IO_OUTACT.AuditMessage = "KremerIoField changed:"
        Me.IO_OUTACT.AuditSource = "KremerIoField"
        Me.IO_OUTACT.Data = 0.0R
        Me.IO_OUTACT.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_OUTACT.InitialValue = True
        Me.IO_OUTACT.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_OUTACT.Location = New System.Drawing.Point(676, 246)
        Me.IO_OUTACT.LowerBound = 0.0R
        Me.IO_OUTACT.Name = "IO_OUTACT"
        Me.IO_OUTACT.OutputFormat = "0.00 "
        Me.IO_OUTACT.Size = New System.Drawing.Size(100, 21)
        Me.IO_OUTACT.TabIndex = 353
        Me.IO_OUTACT.Text = "0.00 "
        Me.IO_OUTACT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IO_OUTACT.UpperBound = 1000.0R
        Me.IO_OUTACT.UserInfo = Nothing
        Me.IO_OUTACT.UserLevel = 0
        '
        'P
        '
        Me.P.BindControl = Me.IO_Gain
        Me.P.BindProperty = "Data"
        Me.P.Data = Nothing
        Me.P.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.P.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.P.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].PIDTempZone" & _
    ".P"
        '
        'IO_Gain
        '
        Me.IO_Gain.Audit = Nothing
        Me.IO_Gain.AuditEnabled = False
        Me.IO_Gain.AuditMessage = "KremerIoField changed:"
        Me.IO_Gain.AuditSource = "KremerIoField"
        Me.IO_Gain.BackColor = System.Drawing.Color.White
        Me.IO_Gain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_Gain.Data = 0.0R
        Me.IO_Gain.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_Gain.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_Gain.InitialValue = True
        Me.IO_Gain.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_Gain.Location = New System.Drawing.Point(306, 24)
        Me.IO_Gain.LowerBound = -1000.0R
        Me.IO_Gain.Name = "IO_Gain"
        Me.IO_Gain.OutputFormat = "0.0000"
        Me.IO_Gain.Size = New System.Drawing.Size(100, 22)
        Me.IO_Gain.TabIndex = 321
        Me.IO_Gain.Text = "0.0000"
        Me.IO_Gain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_Gain.UpperBound = 25000.0R
        Me.IO_Gain.UserInfo = Nothing
        Me.IO_Gain.UserLevel = 0
        '
        'I
        '
        Me.I.BindControl = Me.IO_Ti
        Me.I.BindProperty = "Data"
        Me.I.Data = Nothing
        Me.I.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.I.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.I.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].PIDTempZone" & _
    ".I"
        '
        'IO_Ti
        '
        Me.IO_Ti.Audit = Nothing
        Me.IO_Ti.AuditEnabled = False
        Me.IO_Ti.AuditMessage = "KremerIoField changed:"
        Me.IO_Ti.AuditSource = "KremerIoField"
        Me.IO_Ti.BackColor = System.Drawing.Color.White
        Me.IO_Ti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_Ti.Data = 0.0R
        Me.IO_Ti.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_Ti.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_Ti.InitialValue = True
        Me.IO_Ti.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_Ti.Location = New System.Drawing.Point(306, 46)
        Me.IO_Ti.LowerBound = -1000.0R
        Me.IO_Ti.Name = "IO_Ti"
        Me.IO_Ti.OutputFormat = "0.000 s"
        Me.IO_Ti.Size = New System.Drawing.Size(100, 22)
        Me.IO_Ti.TabIndex = 318
        Me.IO_Ti.Text = "0.000 s"
        Me.IO_Ti.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_Ti.UpperBound = 25000.0R
        Me.IO_Ti.UserInfo = Nothing
        Me.IO_Ti.UserLevel = 0
        '
        'D
        '
        Me.D.BindControl = Me.IO_Tv
        Me.D.BindProperty = "Data"
        Me.D.Data = Nothing
        Me.D.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.D.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.D.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].PIDTempZone" & _
    ".D"
        '
        'IO_Tv
        '
        Me.IO_Tv.Audit = Nothing
        Me.IO_Tv.AuditEnabled = False
        Me.IO_Tv.AuditMessage = "KremerIoField changed:"
        Me.IO_Tv.AuditSource = "KremerIoField"
        Me.IO_Tv.BackColor = System.Drawing.Color.White
        Me.IO_Tv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_Tv.Data = 0.0R
        Me.IO_Tv.DataType = KremerControlsWin32.KremerIoField.NumDataType.REAL
        Me.IO_Tv.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_Tv.InitialValue = True
        Me.IO_Tv.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_Tv.Location = New System.Drawing.Point(306, 68)
        Me.IO_Tv.LowerBound = 0.0R
        Me.IO_Tv.Name = "IO_Tv"
        Me.IO_Tv.OutputFormat = "0.000 s"
        Me.IO_Tv.Size = New System.Drawing.Size(100, 22)
        Me.IO_Tv.TabIndex = 285
        Me.IO_Tv.Text = "0.000 s"
        Me.IO_Tv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_Tv.UpperBound = 25000.0R
        Me.IO_Tv.UserInfo = Nothing
        Me.IO_Tv.UserLevel = 0
        '
        'Dt
        '
        Me.Dt.BindControl = Me.IO_Td
        Me.Dt.BindProperty = "Data"
        Me.Dt.Data = Nothing
        Me.Dt.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.Dt.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Dt.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].PIDTempZone" & _
    ".Dtime"
        '
        'IO_Td
        '
        Me.IO_Td.Audit = Nothing
        Me.IO_Td.AuditEnabled = False
        Me.IO_Td.AuditMessage = "KremerIoField changed:"
        Me.IO_Td.AuditSource = "KremerIoField"
        Me.IO_Td.BackColor = System.Drawing.Color.White
        Me.IO_Td.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_Td.Data = 0.0R
        Me.IO_Td.DataType = KremerControlsWin32.KremerIoField.NumDataType.REAL
        Me.IO_Td.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_Td.InitialValue = True
        Me.IO_Td.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_Td.Location = New System.Drawing.Point(306, 90)
        Me.IO_Td.LowerBound = 0.0R
        Me.IO_Td.Name = "IO_Td"
        Me.IO_Td.OutputFormat = "0.000 s"
        Me.IO_Td.Size = New System.Drawing.Size(100, 22)
        Me.IO_Td.TabIndex = 286
        Me.IO_Td.Text = "0.000 s"
        Me.IO_Td.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_Td.UpperBound = 25000.0R
        Me.IO_Td.UserInfo = Nothing
        Me.IO_Td.UserLevel = 0
        '
        'DEADBAND
        '
        Me.DEADBAND.BindControl = Me.IO_Deadband
        Me.DEADBAND.BindProperty = "Data"
        Me.DEADBAND.Data = Nothing
        Me.DEADBAND.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.DEADBAND.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.DEADBAND.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].PIDTempZone" & _
    ".DEADBAND"
        '
        'IO_Deadband
        '
        Me.IO_Deadband.Audit = Nothing
        Me.IO_Deadband.AuditEnabled = False
        Me.IO_Deadband.AuditMessage = "KremerIoField changed:"
        Me.IO_Deadband.AuditSource = "KremerIoField"
        Me.IO_Deadband.BackColor = System.Drawing.Color.White
        Me.IO_Deadband.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_Deadband.Data = 0.0R
        Me.IO_Deadband.DataType = KremerControlsWin32.KremerIoField.NumDataType.INT
        Me.IO_Deadband.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_Deadband.InitialValue = True
        Me.IO_Deadband.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_Deadband.Location = New System.Drawing.Point(306, 134)
        Me.IO_Deadband.LowerBound = -1000.0R
        Me.IO_Deadband.Name = "IO_Deadband"
        Me.IO_Deadband.OutputFormat = "0.0 °C"
        Me.IO_Deadband.Size = New System.Drawing.Size(100, 22)
        Me.IO_Deadband.TabIndex = 323
        Me.IO_Deadband.Text = "0.0 °C"
        Me.IO_Deadband.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_Deadband.UpperBound = 25000.0R
        Me.IO_Deadband.UserInfo = Nothing
        Me.IO_Deadband.UserLevel = 0
        '
        'SP_ROC_EXT
        '
        Me.SP_ROC_EXT.BindControl = Me.IO_ROC_Limit_SP
        Me.SP_ROC_EXT.BindProperty = "Data"
        Me.SP_ROC_EXT.Data = Nothing
        Me.SP_ROC_EXT.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.SP_ROC_EXT.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SP_ROC_EXT.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].PIDTempZone" & _
    ".SP_ROC_EXT"
        '
        'IO_ROC_Limit_SP
        '
        Me.IO_ROC_Limit_SP.Audit = Nothing
        Me.IO_ROC_Limit_SP.AuditEnabled = False
        Me.IO_ROC_Limit_SP.AuditMessage = "KremerIoField changed:"
        Me.IO_ROC_Limit_SP.AuditSource = "KremerIoField"
        Me.IO_ROC_Limit_SP.BackColor = System.Drawing.Color.White
        Me.IO_ROC_Limit_SP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_ROC_Limit_SP.Data = 0.0R
        Me.IO_ROC_Limit_SP.DataType = KremerControlsWin32.KremerIoField.NumDataType.REAL
        Me.IO_ROC_Limit_SP.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_ROC_Limit_SP.InitialValue = True
        Me.IO_ROC_Limit_SP.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_ROC_Limit_SP.Location = New System.Drawing.Point(306, 156)
        Me.IO_ROC_Limit_SP.LowerBound = -1000.0R
        Me.IO_ROC_Limit_SP.Name = "IO_ROC_Limit_SP"
        Me.IO_ROC_Limit_SP.OutputFormat = "0.0 °C / sec"
        Me.IO_ROC_Limit_SP.Size = New System.Drawing.Size(100, 22)
        Me.IO_ROC_Limit_SP.TabIndex = 315
        Me.IO_ROC_Limit_SP.Text = "0.0 °C / sec"
        Me.IO_ROC_Limit_SP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_ROC_Limit_SP.UpperBound = 25000.0R
        Me.IO_ROC_Limit_SP.UserInfo = Nothing
        Me.IO_ROC_Limit_SP.UserLevel = 0
        '
        'OUT_ROC_UP
        '
        Me.OUT_ROC_UP.BindControl = Me.IO_ROC_Limit_Out_Up
        Me.OUT_ROC_UP.BindProperty = "Data"
        Me.OUT_ROC_UP.Data = Nothing
        Me.OUT_ROC_UP.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.OUT_ROC_UP.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.OUT_ROC_UP.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].PIDTempZone" & _
    ".OUT_ROC_UP"
        '
        'IO_ROC_Limit_Out_Up
        '
        Me.IO_ROC_Limit_Out_Up.Audit = Nothing
        Me.IO_ROC_Limit_Out_Up.AuditEnabled = False
        Me.IO_ROC_Limit_Out_Up.AuditMessage = "KremerIoField changed:"
        Me.IO_ROC_Limit_Out_Up.AuditSource = "KremerIoField"
        Me.IO_ROC_Limit_Out_Up.BackColor = System.Drawing.Color.White
        Me.IO_ROC_Limit_Out_Up.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_ROC_Limit_Out_Up.Data = 0.0R
        Me.IO_ROC_Limit_Out_Up.DataType = KremerControlsWin32.KremerIoField.NumDataType.REAL
        Me.IO_ROC_Limit_Out_Up.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_ROC_Limit_Out_Up.InitialValue = True
        Me.IO_ROC_Limit_Out_Up.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_ROC_Limit_Out_Up.Location = New System.Drawing.Point(306, 179)
        Me.IO_ROC_Limit_Out_Up.LowerBound = -1000.0R
        Me.IO_ROC_Limit_Out_Up.Name = "IO_ROC_Limit_Out_Up"
        Me.IO_ROC_Limit_Out_Up.OutputFormat = "0.0 '%' / sec"
        Me.IO_ROC_Limit_Out_Up.Size = New System.Drawing.Size(100, 23)
        Me.IO_ROC_Limit_Out_Up.TabIndex = 327
        Me.IO_ROC_Limit_Out_Up.Text = "0.0 % / sec"
        Me.IO_ROC_Limit_Out_Up.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_ROC_Limit_Out_Up.UpperBound = 25000.0R
        Me.IO_ROC_Limit_Out_Up.UserInfo = Nothing
        Me.IO_ROC_Limit_Out_Up.UserLevel = 0
        '
        'OUT_ROC_DOWN
        '
        Me.OUT_ROC_DOWN.BindControl = Me.IO_ROC_Limit_OutDown
        Me.OUT_ROC_DOWN.BindProperty = "Data"
        Me.OUT_ROC_DOWN.Data = Nothing
        Me.OUT_ROC_DOWN.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.OUT_ROC_DOWN.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.OUT_ROC_DOWN.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].PIDTempZone" & _
    ".OUT_ROC_DOWN"
        '
        'IO_ROC_Limit_OutDown
        '
        Me.IO_ROC_Limit_OutDown.Audit = Nothing
        Me.IO_ROC_Limit_OutDown.AuditEnabled = False
        Me.IO_ROC_Limit_OutDown.AuditMessage = "KremerIoField changed:"
        Me.IO_ROC_Limit_OutDown.AuditSource = "KremerIoField"
        Me.IO_ROC_Limit_OutDown.BackColor = System.Drawing.Color.White
        Me.IO_ROC_Limit_OutDown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_ROC_Limit_OutDown.Data = 0.0R
        Me.IO_ROC_Limit_OutDown.DataType = KremerControlsWin32.KremerIoField.NumDataType.REAL
        Me.IO_ROC_Limit_OutDown.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_ROC_Limit_OutDown.InitialValue = True
        Me.IO_ROC_Limit_OutDown.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_ROC_Limit_OutDown.Location = New System.Drawing.Point(306, 202)
        Me.IO_ROC_Limit_OutDown.LowerBound = -1000.0R
        Me.IO_ROC_Limit_OutDown.Name = "IO_ROC_Limit_OutDown"
        Me.IO_ROC_Limit_OutDown.OutputFormat = "0.0 '%' / sec"
        Me.IO_ROC_Limit_OutDown.Size = New System.Drawing.Size(100, 22)
        Me.IO_ROC_Limit_OutDown.TabIndex = 325
        Me.IO_ROC_Limit_OutDown.Text = "0.0 % / sec"
        Me.IO_ROC_Limit_OutDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_ROC_Limit_OutDown.UpperBound = 25000.0R
        Me.IO_ROC_Limit_OutDown.UserInfo = Nothing
        Me.IO_ROC_Limit_OutDown.UserLevel = 0
        '
        'OUT_MIN
        '
        Me.OUT_MIN.BindControl = Me.IO_OutMin
        Me.OUT_MIN.BindProperty = "Data"
        Me.OUT_MIN.Data = Nothing
        Me.OUT_MIN.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.OUT_MIN.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.OUT_MIN.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].PIDTempZone" & _
    ".OUT_LLM_EXT"
        '
        'IO_OutMin
        '
        Me.IO_OutMin.Audit = Nothing
        Me.IO_OutMin.AuditEnabled = False
        Me.IO_OutMin.AuditMessage = "KremerIoField changed:"
        Me.IO_OutMin.AuditSource = "KremerIoField"
        Me.IO_OutMin.BackColor = System.Drawing.Color.White
        Me.IO_OutMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_OutMin.Data = 0.0R
        Me.IO_OutMin.DataType = KremerControlsWin32.KremerIoField.NumDataType.INT
        Me.IO_OutMin.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_OutMin.InitialValue = True
        Me.IO_OutMin.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_OutMin.Location = New System.Drawing.Point(306, 224)
        Me.IO_OutMin.LowerBound = -1000.0R
        Me.IO_OutMin.Name = "IO_OutMin"
        Me.IO_OutMin.OutputFormat = "0.0 '%'"
        Me.IO_OutMin.Size = New System.Drawing.Size(100, 22)
        Me.IO_OutMin.TabIndex = 317
        Me.IO_OutMin.Text = "0.0 %"
        Me.IO_OutMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_OutMin.UpperBound = 25000.0R
        Me.IO_OutMin.UserInfo = Nothing
        Me.IO_OutMin.UserLevel = 0
        '
        'OUT_MAX
        '
        Me.OUT_MAX.BindControl = Me.IO_OutMax
        Me.OUT_MAX.BindProperty = "Data"
        Me.OUT_MAX.Data = Nothing
        Me.OUT_MAX.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.OUT_MAX.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.OUT_MAX.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].PIDTempZone" & _
    ".OUT_HLM_EXT"
        '
        'IO_OutMax
        '
        Me.IO_OutMax.Audit = Nothing
        Me.IO_OutMax.AuditEnabled = False
        Me.IO_OutMax.AuditMessage = "KremerIoField changed:"
        Me.IO_OutMax.AuditSource = "KremerIoField"
        Me.IO_OutMax.BackColor = System.Drawing.Color.White
        Me.IO_OutMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_OutMax.Data = 0.0R
        Me.IO_OutMax.DataType = KremerControlsWin32.KremerIoField.NumDataType.INT
        Me.IO_OutMax.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_OutMax.InitialValue = True
        Me.IO_OutMax.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_OutMax.Location = New System.Drawing.Point(306, 246)
        Me.IO_OutMax.LowerBound = -1000.0R
        Me.IO_OutMax.Name = "IO_OutMax"
        Me.IO_OutMax.OutputFormat = "0.0 '%'"
        Me.IO_OutMax.Size = New System.Drawing.Size(100, 22)
        Me.IO_OutMax.TabIndex = 329
        Me.IO_OutMax.Text = "0.0 %"
        Me.IO_OutMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_OutMax.UpperBound = 25000.0R
        Me.IO_OutMax.UserInfo = Nothing
        Me.IO_OutMax.UserLevel = 0
        '
        'SP_MIN
        '
        Me.SP_MIN.BindControl = Me.IO_SetpointMin
        Me.SP_MIN.BindProperty = "Data"
        Me.SP_MIN.Data = Nothing
        Me.SP_MIN.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.SP_MIN.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SP_MIN.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].PIDTempZone" & _
    ".SP_LLM_EXT"
        '
        'IO_SetpointMin
        '
        Me.IO_SetpointMin.Audit = Nothing
        Me.IO_SetpointMin.AuditEnabled = False
        Me.IO_SetpointMin.AuditMessage = "KremerIoField changed:"
        Me.IO_SetpointMin.AuditSource = "KremerIoField"
        Me.IO_SetpointMin.BackColor = System.Drawing.Color.White
        Me.IO_SetpointMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_SetpointMin.Data = 0.0R
        Me.IO_SetpointMin.DataType = KremerControlsWin32.KremerIoField.NumDataType.INT
        Me.IO_SetpointMin.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_SetpointMin.InitialValue = True
        Me.IO_SetpointMin.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_SetpointMin.Location = New System.Drawing.Point(306, 268)
        Me.IO_SetpointMin.LowerBound = -1000.0R
        Me.IO_SetpointMin.Name = "IO_SetpointMin"
        Me.IO_SetpointMin.OutputFormat = "0.0 °C"
        Me.IO_SetpointMin.Size = New System.Drawing.Size(100, 22)
        Me.IO_SetpointMin.TabIndex = 349
        Me.IO_SetpointMin.Text = "0.0 °C"
        Me.IO_SetpointMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_SetpointMin.UpperBound = 25000.0R
        Me.IO_SetpointMin.UserInfo = Nothing
        Me.IO_SetpointMin.UserLevel = 0
        '
        'SP_MAX
        '
        Me.SP_MAX.BindControl = Me.IO_SetpointMax
        Me.SP_MAX.BindProperty = "Data"
        Me.SP_MAX.Data = Nothing
        Me.SP_MAX.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.SP_MAX.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SP_MAX.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].PIDTempZone" & _
    ".SP_HLM_EXT"
        '
        'IO_SetpointMax
        '
        Me.IO_SetpointMax.Audit = Nothing
        Me.IO_SetpointMax.AuditEnabled = False
        Me.IO_SetpointMax.AuditMessage = "KremerIoField changed:"
        Me.IO_SetpointMax.AuditSource = "KremerIoField"
        Me.IO_SetpointMax.BackColor = System.Drawing.Color.White
        Me.IO_SetpointMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_SetpointMax.Data = 0.0R
        Me.IO_SetpointMax.DataType = KremerControlsWin32.KremerIoField.NumDataType.INT
        Me.IO_SetpointMax.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_SetpointMax.InitialValue = True
        Me.IO_SetpointMax.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_SetpointMax.Location = New System.Drawing.Point(306, 290)
        Me.IO_SetpointMax.LowerBound = -1000.0R
        Me.IO_SetpointMax.Name = "IO_SetpointMax"
        Me.IO_SetpointMax.OutputFormat = "0.0 °C"
        Me.IO_SetpointMax.Size = New System.Drawing.Size(100, 22)
        Me.IO_SetpointMax.TabIndex = 350
        Me.IO_SetpointMax.Text = "0.0 °C"
        Me.IO_SetpointMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_SetpointMax.UpperBound = 25000.0R
        Me.IO_SetpointMax.UserInfo = Nothing
        Me.IO_SetpointMax.UserLevel = 0
        '
        'OutManVal
        '
        Me.OutManVal.BindControl = Me.IO_OUTHAND
        Me.OutManVal.BindProperty = "Data"
        Me.OutManVal.Data = Nothing
        Me.OutManVal.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.OutManVal.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.OutManVal.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].PIDTempZone" & _
    ".OUT_MAN"
        '
        'IO_OUTHAND
        '
        Me.IO_OUTHAND.Audit = Nothing
        Me.IO_OUTHAND.AuditEnabled = False
        Me.IO_OUTHAND.AuditMessage = "KremerIoField changed:"
        Me.IO_OUTHAND.AuditSource = "KremerIoField"
        Me.IO_OUTHAND.BackColor = System.Drawing.Color.White
        Me.IO_OUTHAND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_OUTHAND.Data = 0.0R
        Me.IO_OUTHAND.DataType = KremerControlsWin32.KremerIoField.NumDataType.INT
        Me.IO_OUTHAND.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_OUTHAND.InitialValue = True
        Me.IO_OUTHAND.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_OUTHAND.Location = New System.Drawing.Point(679, 327)
        Me.IO_OUTHAND.LowerBound = -1000.0R
        Me.IO_OUTHAND.Name = "IO_OUTHAND"
        Me.IO_OUTHAND.OutputFormat = "0.00"
        Me.IO_OUTHAND.Size = New System.Drawing.Size(100, 22)
        Me.IO_OUTHAND.TabIndex = 343
        Me.IO_OUTHAND.Text = "0.00"
        Me.IO_OUTHAND.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_OUTHAND.UpperBound = 1000.0R
        Me.IO_OUTHAND.UserInfo = Nothing
        Me.IO_OUTHAND.UserLevel = 0
        '
        'CalcSteps
        '
        Me.CalcSteps.BindControl = Me.IO_CalcStep
        Me.CalcSteps.BindProperty = "Data"
        Me.CalcSteps.Data = Nothing
        Me.CalcSteps.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.CalcSteps.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.CalcSteps.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].PIDTempZone" & _
    ".SP_AUTO"
        '
        'IO_CalcStep
        '
        Me.IO_CalcStep.Audit = Nothing
        Me.IO_CalcStep.AuditEnabled = False
        Me.IO_CalcStep.AuditMessage = "KremerIoField changed:"
        Me.IO_CalcStep.AuditSource = "KremerIoField"
        Me.IO_CalcStep.BackColor = System.Drawing.SystemColors.Control
        Me.IO_CalcStep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_CalcStep.Data = 0.0R
        Me.IO_CalcStep.DataType = KremerControlsWin32.KremerIoField.NumDataType.INT
        Me.IO_CalcStep.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_CalcStep.InitialValue = True
        Me.IO_CalcStep.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_CalcStep.Location = New System.Drawing.Point(426, 357)
        Me.IO_CalcStep.LowerBound = -1000.0R
        Me.IO_CalcStep.Name = "IO_CalcStep"
        Me.IO_CalcStep.OutputFormat = "0.0 °C"
        Me.IO_CalcStep.Size = New System.Drawing.Size(100, 22)
        Me.IO_CalcStep.TabIndex = 367
        Me.IO_CalcStep.Text = "0.0 °C"
        Me.IO_CalcStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_CalcStep.UpperBound = 1000.0R
        Me.IO_CalcStep.UserInfo = Nothing
        Me.IO_CalcStep.UserLevel = 0
        '
        'NumberOfSteps
        '
        Me.NumberOfSteps.BindControl = Me.IO_NrOfSteps
        Me.NumberOfSteps.BindProperty = "Data"
        Me.NumberOfSteps.Data = Nothing
        Me.NumberOfSteps.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.NumberOfSteps.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.NumberOfSteps.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].nrOfSteps"
        '
        'IO_NrOfSteps
        '
        Me.IO_NrOfSteps.Audit = Nothing
        Me.IO_NrOfSteps.AuditEnabled = False
        Me.IO_NrOfSteps.AuditMessage = "KremerIoField changed:"
        Me.IO_NrOfSteps.AuditSource = "KremerIoField"
        Me.IO_NrOfSteps.BackColor = System.Drawing.Color.White
        Me.IO_NrOfSteps.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_NrOfSteps.Data = 0.0R
        Me.IO_NrOfSteps.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_NrOfSteps.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_NrOfSteps.InitialValue = True
        Me.IO_NrOfSteps.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_NrOfSteps.Location = New System.Drawing.Point(306, 356)
        Me.IO_NrOfSteps.LowerBound = -1000.0R
        Me.IO_NrOfSteps.Name = "IO_NrOfSteps"
        Me.IO_NrOfSteps.OutputFormat = "0"
        Me.IO_NrOfSteps.Size = New System.Drawing.Size(100, 22)
        Me.IO_NrOfSteps.TabIndex = 364
        Me.IO_NrOfSteps.Text = "0"
        Me.IO_NrOfSteps.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_NrOfSteps.UpperBound = 25000.0R
        Me.IO_NrOfSteps.UserInfo = Nothing
        Me.IO_NrOfSteps.UserLevel = 0
        '
        'PVLag
        '
        Me.PVLag.BindControl = Me.IO_1SteOrder
        Me.PVLag.BindProperty = "Data"
        Me.PVLag.Data = Nothing
        Me.PVLag.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.PVLag.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PVLag.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].PIDTempZone" & _
    ".PV_TMLAG"
        '
        'IO_1SteOrder
        '
        Me.IO_1SteOrder.Audit = Nothing
        Me.IO_1SteOrder.AuditEnabled = False
        Me.IO_1SteOrder.AuditMessage = "KremerIoField changed:"
        Me.IO_1SteOrder.AuditSource = "KremerIoField"
        Me.IO_1SteOrder.BackColor = System.Drawing.Color.White
        Me.IO_1SteOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_1SteOrder.Data = 0.0R
        Me.IO_1SteOrder.DataType = KremerControlsWin32.KremerIoField.NumDataType.DINT
        Me.IO_1SteOrder.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_1SteOrder.InitialValue = True
        Me.IO_1SteOrder.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_1SteOrder.Location = New System.Drawing.Point(306, 112)
        Me.IO_1SteOrder.LowerBound = -1000.0R
        Me.IO_1SteOrder.Name = "IO_1SteOrder"
        Me.IO_1SteOrder.OutputFormat = "0.0 s"
        Me.IO_1SteOrder.Size = New System.Drawing.Size(100, 22)
        Me.IO_1SteOrder.TabIndex = 287
        Me.IO_1SteOrder.Text = "0.0 s"
        Me.IO_1SteOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_1SteOrder.UpperBound = 25000.0R
        Me.IO_1SteOrder.UserInfo = Nothing
        Me.IO_1SteOrder.UserLevel = 0
        '
        'PWMperiodtime
        '
        Me.PWMperiodtime.BindControl = Me.IO_PWMperiod
        Me.PWMperiodtime.BindProperty = "Data"
        Me.PWMperiodtime.Data = Nothing
        Me.PWMperiodtime.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.PWMperiodtime.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PWMperiodtime.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].PWM_Paramet" & _
    "ers.tPWMPeriod"
        '
        'IO_PWMperiod
        '
        Me.IO_PWMperiod.Audit = Nothing
        Me.IO_PWMperiod.AuditEnabled = False
        Me.IO_PWMperiod.AuditMessage = "KremerIoField changed:"
        Me.IO_PWMperiod.AuditSource = "KremerIoField"
        Me.IO_PWMperiod.BackColor = System.Drawing.Color.White
        Me.IO_PWMperiod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_PWMperiod.Data = 0.0R
        Me.IO_PWMperiod.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_PWMperiod.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_PWMperiod.InitialValue = True
        Me.IO_PWMperiod.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_PWMperiod.Location = New System.Drawing.Point(306, 402)
        Me.IO_PWMperiod.LowerBound = 25.0R
        Me.IO_PWMperiod.Name = "IO_PWMperiod"
        Me.IO_PWMperiod.OutputFormat = "0 ms"
        Me.IO_PWMperiod.Size = New System.Drawing.Size(100, 22)
        Me.IO_PWMperiod.TabIndex = 361
        Me.IO_PWMperiod.Text = "0 ms"
        Me.IO_PWMperiod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_PWMperiod.UpperBound = 30000.0R
        Me.IO_PWMperiod.UserInfo = Nothing
        Me.IO_PWMperiod.UserLevel = 0
        '
        'WaitTimeAfterStepReached
        '
        Me.WaitTimeAfterStepReached.BindControl = Me.IO_StepTimeReached
        Me.WaitTimeAfterStepReached.BindProperty = "Data"
        Me.WaitTimeAfterStepReached.Data = Nothing
        Me.WaitTimeAfterStepReached.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.WaitTimeAfterStepReached.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.WaitTimeAfterStepReached.VariableName = "MAIN.InMoldDrying.MachParameters.[Position1].HeatingZone[[Position2]].WaitTimeAft" & _
    "erStepReached"
        '
        'IO_StepTimeReached
        '
        Me.IO_StepTimeReached.Audit = Nothing
        Me.IO_StepTimeReached.AuditEnabled = False
        Me.IO_StepTimeReached.AuditMessage = "KremerIoField changed:"
        Me.IO_StepTimeReached.AuditSource = "KremerIoField"
        Me.IO_StepTimeReached.BackColor = System.Drawing.Color.White
        Me.IO_StepTimeReached.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_StepTimeReached.Data = 0.0R
        Me.IO_StepTimeReached.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_StepTimeReached.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_StepTimeReached.InitialValue = True
        Me.IO_StepTimeReached.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_StepTimeReached.Location = New System.Drawing.Point(306, 378)
        Me.IO_StepTimeReached.LowerBound = -1000.0R
        Me.IO_StepTimeReached.Name = "IO_StepTimeReached"
        Me.IO_StepTimeReached.OutputFormat = "0 ms"
        Me.IO_StepTimeReached.Size = New System.Drawing.Size(100, 22)
        Me.IO_StepTimeReached.TabIndex = 366
        Me.IO_StepTimeReached.Text = "0 ms"
        Me.IO_StepTimeReached.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_StepTimeReached.UpperBound = 25000.0R
        Me.IO_StepTimeReached.UserInfo = Nothing
        Me.IO_StepTimeReached.UserLevel = 0
        '
        'LiftLine
        '
        Me.LiftLine.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LiftLine.Name = "LiftLine"
        Me.LiftLine.X1 = 15
        Me.LiftLine.X2 = 410
        Me.LiftLine.Y1 = 20
        Me.LiftLine.Y2 = 20
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape5, Me.LineShape4, Me.LineShape1, Me.LiftLine})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 435)
        Me.ShapeContainer1.TabIndex = 265
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 667
        Me.LineShape2.X2 = 667
        Me.LineShape2.Y1 = 38
        Me.LineShape2.Y2 = 350
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 540
        Me.LineShape5.X2 = 540
        Me.LineShape5.Y1 = 38
        Me.LineShape5.Y2 = 350
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 426
        Me.LineShape4.X2 = 786
        Me.LineShape4.Y1 = 38
        Me.LineShape4.Y2 = 38
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 300
        Me.LineShape1.X2 = 300
        Me.LineShape1.Y1 = 20
        Me.LineShape1.Y2 = 373
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(275, 23)
        Me.Label9.TabIndex = 284
        Me.Label9.Tag = "204"
        Me.Label9.Text = "Td"
        '
        'label
        '
        Me.label.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(20, 115)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(275, 17)
        Me.label.TabIndex = 283
        Me.label.Tag = "205"
        Me.label.Text = "1st order filter"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(20, 71)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(275, 23)
        Me.Label13.TabIndex = 282
        Me.Label13.Tag = "203"
        Me.Label13.Text = "Tv"
        '
        'LblTitle
        '
        Me.LblTitle.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LblTitle.Location = New System.Drawing.Point(12, -5)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(328, 23)
        Me.LblTitle.TabIndex = 288
        Me.LblTitle.Tag = "200"
        Me.LblTitle.Text = "PID controller bottom mold"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(422, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 23)
        Me.Label16.TabIndex = 308
        Me.Label16.Tag = "217"
        Me.Label16.Text = "SP"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(20, 159)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(275, 23)
        Me.Label20.TabIndex = 314
        Me.Label20.Tag = "207"
        Me.Label20.Text = "ROC. limit setpoint"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(20, 227)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(275, 23)
        Me.Label21.TabIndex = 316
        Me.Label21.Tag = "210"
        Me.Label21.Text = "Output minimum"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(20, 30)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(275, 22)
        Me.Label22.TabIndex = 320
        Me.Label22.Tag = "201"
        Me.Label22.Text = "Gain"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(20, 49)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(275, 22)
        Me.Label23.TabIndex = 319
        Me.Label23.Tag = "202"
        Me.Label23.Text = "Ti"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(275, 23)
        Me.Label6.TabIndex = 322
        Me.Label6.Tag = "206"
        Me.Label6.Text = "Deadband"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(20, 205)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(275, 23)
        Me.Label17.TabIndex = 324
        Me.Label17.Tag = "209"
        Me.Label17.Text = "ROC. limit OUT down"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(20, 182)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(275, 23)
        Me.Label19.TabIndex = 326
        Me.Label19.Tag = "208"
        Me.Label19.Text = "ROC. limit OUT up"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(275, 23)
        Me.Label2.TabIndex = 328
        Me.Label2.Tag = "211"
        Me.Label2.Text = "Output maximum"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(546, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 23)
        Me.Label1.TabIndex = 334
        Me.Label1.Tag = "218"
        Me.Label1.Text = "PV"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(672, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 23)
        Me.Label5.TabIndex = 346
        Me.Label5.Tag = "219"
        Me.Label5.Text = "OUT"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 23)
        Me.Label3.TabIndex = 347
        Me.Label3.Tag = "212"
        Me.Label3.Text = "Setpoint minimum"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(275, 23)
        Me.Label4.TabIndex = 348
        Me.Label4.Tag = "213"
        Me.Label4.Text = "Setpoint maximum"
        '
        'SPBarIO_MIN
        '
        Me.SPBarIO_MIN.Audit = Nothing
        Me.SPBarIO_MIN.AuditEnabled = False
        Me.SPBarIO_MIN.AuditMessage = "KremerIoField changed:"
        Me.SPBarIO_MIN.AuditSource = "KremerIoField"
        Me.SPBarIO_MIN.Data = 0.0R
        Me.SPBarIO_MIN.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.SPBarIO_MIN.InitialValue = True
        Me.SPBarIO_MIN.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.SPBarIO_MIN.Location = New System.Drawing.Point(412, 207)
        Me.SPBarIO_MIN.LowerBound = 0.0R
        Me.SPBarIO_MIN.Name = "SPBarIO_MIN"
        Me.SPBarIO_MIN.OutputFormat = "0.0°C"
        Me.SPBarIO_MIN.Size = New System.Drawing.Size(52, 21)
        Me.SPBarIO_MIN.TabIndex = 354
        Me.SPBarIO_MIN.Text = "0.0°C"
        Me.SPBarIO_MIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SPBarIO_MIN.UpperBound = 1000.0R
        Me.SPBarIO_MIN.UserInfo = Nothing
        Me.SPBarIO_MIN.UserLevel = 0
        '
        'SPBarIO_MAX
        '
        Me.SPBarIO_MAX.Audit = Nothing
        Me.SPBarIO_MAX.AuditEnabled = False
        Me.SPBarIO_MAX.AuditMessage = "KremerIoField changed:"
        Me.SPBarIO_MAX.AuditSource = "KremerIoField"
        Me.SPBarIO_MAX.Data = 0.0R
        Me.SPBarIO_MAX.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.SPBarIO_MAX.InitialValue = True
        Me.SPBarIO_MAX.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.SPBarIO_MAX.Location = New System.Drawing.Point(415, 39)
        Me.SPBarIO_MAX.LowerBound = 0.0R
        Me.SPBarIO_MAX.Name = "SPBarIO_MAX"
        Me.SPBarIO_MAX.OutputFormat = "0.0°C"
        Me.SPBarIO_MAX.Size = New System.Drawing.Size(52, 21)
        Me.SPBarIO_MAX.TabIndex = 355
        Me.SPBarIO_MAX.Text = "0.0°C"
        Me.SPBarIO_MAX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SPBarIO_MAX.UpperBound = 1000.0R
        Me.SPBarIO_MAX.UserInfo = Nothing
        Me.SPBarIO_MAX.UserLevel = 0
        '
        'PVBarIO_MAX
        '
        Me.PVBarIO_MAX.Audit = Nothing
        Me.PVBarIO_MAX.AuditEnabled = False
        Me.PVBarIO_MAX.AuditMessage = "KremerIoField changed:"
        Me.PVBarIO_MAX.AuditSource = "KremerIoField"
        Me.PVBarIO_MAX.Data = 0.0R
        Me.PVBarIO_MAX.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.PVBarIO_MAX.InitialValue = True
        Me.PVBarIO_MAX.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.PVBarIO_MAX.Location = New System.Drawing.Point(543, 39)
        Me.PVBarIO_MAX.LowerBound = 0.0R
        Me.PVBarIO_MAX.Name = "PVBarIO_MAX"
        Me.PVBarIO_MAX.OutputFormat = "0.0°C"
        Me.PVBarIO_MAX.Size = New System.Drawing.Size(52, 21)
        Me.PVBarIO_MAX.TabIndex = 356
        Me.PVBarIO_MAX.Text = "0.0°C"
        Me.PVBarIO_MAX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PVBarIO_MAX.UpperBound = 1000.0R
        Me.PVBarIO_MAX.UserInfo = Nothing
        Me.PVBarIO_MAX.UserLevel = 0
        '
        'OutBarIO_MAX
        '
        Me.OutBarIO_MAX.Audit = Nothing
        Me.OutBarIO_MAX.AuditEnabled = False
        Me.OutBarIO_MAX.AuditMessage = "KremerIoField changed:"
        Me.OutBarIO_MAX.AuditSource = "KremerIoField"
        Me.OutBarIO_MAX.Data = 0.0R
        Me.OutBarIO_MAX.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.OutBarIO_MAX.InitialValue = True
        Me.OutBarIO_MAX.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.OutBarIO_MAX.Location = New System.Drawing.Point(670, 40)
        Me.OutBarIO_MAX.LowerBound = 0.0R
        Me.OutBarIO_MAX.Name = "OutBarIO_MAX"
        Me.OutBarIO_MAX.OutputFormat = "0.0 '%'"
        Me.OutBarIO_MAX.Size = New System.Drawing.Size(52, 21)
        Me.OutBarIO_MAX.TabIndex = 357
        Me.OutBarIO_MAX.Text = "0.0 %"
        Me.OutBarIO_MAX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.OutBarIO_MAX.UpperBound = 1000.0R
        Me.OutBarIO_MAX.UserInfo = Nothing
        Me.OutBarIO_MAX.UserLevel = 0
        '
        'PVBarIO_MIN
        '
        Me.PVBarIO_MIN.Audit = Nothing
        Me.PVBarIO_MIN.AuditEnabled = False
        Me.PVBarIO_MIN.AuditMessage = "KremerIoField changed:"
        Me.PVBarIO_MIN.AuditSource = "KremerIoField"
        Me.PVBarIO_MIN.Data = 0.0R
        Me.PVBarIO_MIN.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.PVBarIO_MIN.InitialValue = True
        Me.PVBarIO_MIN.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.PVBarIO_MIN.Location = New System.Drawing.Point(543, 207)
        Me.PVBarIO_MIN.LowerBound = 0.0R
        Me.PVBarIO_MIN.Name = "PVBarIO_MIN"
        Me.PVBarIO_MIN.OutputFormat = "0.0°C"
        Me.PVBarIO_MIN.Size = New System.Drawing.Size(52, 21)
        Me.PVBarIO_MIN.TabIndex = 358
        Me.PVBarIO_MIN.Text = "0.0°C"
        Me.PVBarIO_MIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PVBarIO_MIN.UpperBound = 1000.0R
        Me.PVBarIO_MIN.UserInfo = Nothing
        Me.PVBarIO_MIN.UserLevel = 0
        '
        'OutBarIO_MIN
        '
        Me.OutBarIO_MIN.Audit = Nothing
        Me.OutBarIO_MIN.AuditEnabled = False
        Me.OutBarIO_MIN.AuditMessage = "KremerIoField changed:"
        Me.OutBarIO_MIN.AuditSource = "KremerIoField"
        Me.OutBarIO_MIN.Data = 0.0R
        Me.OutBarIO_MIN.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.OutBarIO_MIN.InitialValue = True
        Me.OutBarIO_MIN.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.OutBarIO_MIN.Location = New System.Drawing.Point(670, 207)
        Me.OutBarIO_MIN.LowerBound = 0.0R
        Me.OutBarIO_MIN.Name = "OutBarIO_MIN"
        Me.OutBarIO_MIN.OutputFormat = "00.0%"
        Me.OutBarIO_MIN.Size = New System.Drawing.Size(52, 21)
        Me.OutBarIO_MIN.TabIndex = 359
        Me.OutBarIO_MIN.Text = "00.0%"
        Me.OutBarIO_MIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.OutBarIO_MIN.UpperBound = 1000.0R
        Me.OutBarIO_MIN.UserInfo = Nothing
        Me.OutBarIO_MIN.UserLevel = 0
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 405)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(275, 23)
        Me.Label8.TabIndex = 362
        Me.Label8.Tag = "199"
        Me.Label8.Text = "PWM minimal period time"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 359)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(275, 23)
        Me.Label10.TabIndex = 363
        Me.Label10.Tag = ""
        Me.Label10.Text = "Number of setpoint steps (start-up)"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 381)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(275, 23)
        Me.Label11.TabIndex = 365
        Me.Label11.Tag = ""
        Me.Label11.Text = "Wait time after SP-step reached"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 337)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(275, 23)
        Me.Label7.TabIndex = 370
        Me.Label7.Tag = "211"
        Me.Label7.Text = "High Cut-off filter"
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
        Me.KremerIoField1.DataType = KremerControlsWin32.KremerIoField.NumDataType.INT
        Me.KremerIoField1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerIoField1.InitialValue = True
        Me.KremerIoField1.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.KremerIoField1.Location = New System.Drawing.Point(306, 312)
        Me.KremerIoField1.LowerBound = -1000.0R
        Me.KremerIoField1.Name = "KremerIoField1"
        Me.KremerIoField1.OutputFormat = "0.0 '%'"
        Me.KremerIoField1.Size = New System.Drawing.Size(100, 22)
        Me.KremerIoField1.TabIndex = 369
        Me.KremerIoField1.Text = "0.0 %"
        Me.KremerIoField1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.KremerIoField1.UpperBound = 25000.0R
        Me.KremerIoField1.UserInfo = Nothing
        Me.KremerIoField1.UserLevel = 0
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(20, 315)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(275, 23)
        Me.Label12.TabIndex = 368
        Me.Label12.Tag = ""
        Me.Label12.Text = "Low cutt-off filter"
        '
        'KremerIoField2
        '
        Me.KremerIoField2.Audit = Nothing
        Me.KremerIoField2.AuditEnabled = False
        Me.KremerIoField2.AuditMessage = "KremerIoField changed:"
        Me.KremerIoField2.AuditSource = "KremerIoField"
        Me.KremerIoField2.BackColor = System.Drawing.Color.White
        Me.KremerIoField2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KremerIoField2.Data = 0.0R
        Me.KremerIoField2.DataType = KremerControlsWin32.KremerIoField.NumDataType.INT
        Me.KremerIoField2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerIoField2.InitialValue = True
        Me.KremerIoField2.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.KremerIoField2.Location = New System.Drawing.Point(306, 334)
        Me.KremerIoField2.LowerBound = -1000.0R
        Me.KremerIoField2.Name = "KremerIoField2"
        Me.KremerIoField2.OutputFormat = "0.0 '%'"
        Me.KremerIoField2.Size = New System.Drawing.Size(100, 22)
        Me.KremerIoField2.TabIndex = 371
        Me.KremerIoField2.Text = "0.0 %"
        Me.KremerIoField2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.KremerIoField2.UpperBound = 25000.0R
        Me.KremerIoField2.UserInfo = Nothing
        Me.KremerIoField2.UserLevel = 0
        '
        'DryingMoldDetail_Bot_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KremerIoField2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.KremerIoField1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.IO_CalcStep)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.IO_PWMperiod)
        Me.Controls.Add(Me.OutBarIO_MIN)
        Me.Controls.Add(Me.PVBarIO_MIN)
        Me.Controls.Add(Me.OutBarIO_MAX)
        Me.Controls.Add(Me.PVBarIO_MAX)
        Me.Controls.Add(Me.SPBarIO_MAX)
        Me.Controls.Add(Me.SPBarIO_MIN)
        Me.Controls.Add(Me.IO_OUTACT)
        Me.Controls.Add(Me.IO_PVACT)
        Me.Controls.Add(Me.IO_SP_ACT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.IO_SP_AUTO)
        Me.Controls.Add(Me.BtnAuto)
        Me.Controls.Add(Me.IO_OUTHAND)
        Me.Controls.Add(Me.BtnOut)
        Me.Controls.Add(Me.BAR_CV)
        Me.Controls.Add(Me.IO_SPHand)
        Me.Controls.Add(Me.BtnSetpoint)
        Me.Controls.Add(Me.BAR_PV)
        Me.Controls.Add(Me.BAR_SP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IO_ROC_Limit_Out_Up)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.IO_ROC_Limit_OutDown)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.IO_Deadband)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.IO_Gain)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.IO_Ti)
        Me.Controls.Add(Me.IO_OutMin)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.IO_ROC_Limit_SP)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.IO_1SteOrder)
        Me.Controls.Add(Me.IO_Td)
        Me.Controls.Add(Me.IO_Tv)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Controls.Add(Me.IO_OutMax)
        Me.Controls.Add(Me.IO_SetpointMin)
        Me.Controls.Add(Me.IO_SetpointMax)
        Me.Controls.Add(Me.IO_NrOfSteps)
        Me.Controls.Add(Me.IO_StepTimeReached)
        Me.Name = "DryingMoldDetail_Bot_Settings"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "83"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents LiftLine As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents IO_1SteOrder As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_Td As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_Tv As KremerControlsWin32.KremerIoField
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents IO_ROC_Limit_SP As KremerControlsWin32.KremerIoField
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents IO_OutMin As KremerControlsWin32.KremerIoField
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents IO_Gain As KremerControlsWin32.KremerIoField
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents IO_Ti As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_Deadband As KremerControlsWin32.KremerIoField
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents IO_ROC_Limit_OutDown As KremerControlsWin32.KremerIoField
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents IO_ROC_Limit_Out_Up As KremerControlsWin32.KremerIoField
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents IO_OutMax As KremerControlsWin32.KremerIoField
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BAR_SP As KremerControlsWin32.KremerShape
    Friend WithEvents BAR_PV As KremerControlsWin32.KremerShape
    Friend WithEvents BtnSetpoint As KremerControlsWin32.KremerButton
    Friend WithEvents IO_SPHand As KremerControlsWin32.KremerIoField
    Friend WithEvents SP_MAN As KremerControlsWin32.KremerVariable
    Friend WithEvents SP_AUTO_TOTAL As KremerControlsWin32.KremerVariable
    Friend WithEvents PV_ACT As KremerControlsWin32.KremerVariable
    Friend WithEvents P As KremerControlsWin32.KremerVariable
    Friend WithEvents I As KremerControlsWin32.KremerVariable
    Friend WithEvents D As KremerControlsWin32.KremerVariable
    Friend WithEvents DEADBAND As KremerControlsWin32.KremerVariable
    Friend WithEvents SP_ROC_EXT As KremerControlsWin32.KremerVariable
    Friend WithEvents OUT_ROC_UP As KremerControlsWin32.KremerVariable
    Friend WithEvents OUT_ROC_DOWN As KremerControlsWin32.KremerVariable
    Friend WithEvents OUT_MIN As KremerControlsWin32.KremerVariable
    Friend WithEvents OUT_MAX As KremerControlsWin32.KremerVariable
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents IO_OUTHAND As KremerControlsWin32.KremerIoField
    Friend WithEvents BtnOut As KremerControlsWin32.KremerButton
    Friend WithEvents BAR_CV As KremerControlsWin32.KremerShape
    Friend WithEvents IO_SP_AUTO As KremerControlsWin32.KremerIoField
    Friend WithEvents BtnAuto As KremerControlsWin32.KremerButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OutACT As KremerControlsWin32.KremerVariable
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents IO_SetpointMin As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_SetpointMax As KremerControlsWin32.KremerIoField
    Friend WithEvents SP_MIN As KremerControlsWin32.KremerVariable
    Friend WithEvents SP_MAX As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_SP_ACT As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_PVACT As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_OUTACT As KremerControlsWin32.KremerIoField
    Friend WithEvents SPBarIO_MIN As KremerControlsWin32.KremerIoField
    Friend WithEvents SPBarIO_MAX As KremerControlsWin32.KremerIoField
    Friend WithEvents PVBarIO_MAX As KremerControlsWin32.KremerIoField
    Friend WithEvents OutBarIO_MAX As KremerControlsWin32.KremerIoField
    Friend WithEvents PVBarIO_MIN As KremerControlsWin32.KremerIoField
    Friend WithEvents OutBarIO_MIN As KremerControlsWin32.KremerIoField
    Friend WithEvents PV_ACT2 As KremerControlsWin32.KremerVariable
    Friend WithEvents OutAct2 As KremerControlsWin32.KremerVariable
    Friend WithEvents SP_AUTOTOTAL2 As KremerControlsWin32.KremerVariable
    Friend WithEvents AutoBtn As KremerControlsWin32.KremerVariable
    Friend WithEvents SetpointBtn As KremerControlsWin32.KremerVariable
    Friend WithEvents OutputBtn As KremerControlsWin32.KremerVariable
    Friend WithEvents OutManVal As KremerControlsWin32.KremerVariable
    Friend WithEvents SP_Act As KremerControlsWin32.KremerVariable
    Friend WithEvents PWMperiodtime As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_PWMperiod As KremerControlsWin32.KremerIoField
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PVLag As KremerControlsWin32.KremerVariable
    Friend WithEvents AutoBtnState As KremerControlsWin32.KremerVariable
    Friend WithEvents SetpointBtnState As KremerControlsWin32.KremerVariable
    Friend WithEvents OutputBtnState As KremerControlsWin32.KremerVariable
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents IO_NrOfSteps As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_StepTimeReached As KremerControlsWin32.KremerIoField
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents WaitTimeAfterStepReached As KremerControlsWin32.KremerVariable
    Friend WithEvents NumberOfSteps As KremerControlsWin32.KremerVariable
    Friend WithEvents CalcSteps As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_CalcStep As KremerControlsWin32.KremerIoField
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents KremerIoField1 As KremerControlsWin32.KremerIoField
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents KremerIoField2 As KremerControlsWin32.KremerIoField
    Friend WithEvents Dt As KremerControlsWin32.KremerVariable

End Class
