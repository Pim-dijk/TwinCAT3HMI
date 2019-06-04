<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DryingMoldSettings
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
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.mxAutomode = New KremerControlsWin32.KremerVariable(Me.components)
        Me.TM_UpStop = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TM_UpStop = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TM_UpCreep = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_PosCreepUp = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TM_UpSlow = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TM_UpSlow = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TM_OffsetAlarm = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TM_OffsetAlarm = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TM_DownSlow = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TopDownSlow = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TM_DownCreep = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TopDownCreep = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TM_ClosedBlowOffTime = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TM_ClosedBlowOffTime = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TM_ClosedVacuumTime = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TM_ClosedVacuumTime = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TM_DryingTime = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TM_DryingTime = New KremerControlsWin32.KremerIoField(Me.components)
        Me.BM_VacTime = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_BotVacTime = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TM_VacEnable = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_EnableVacuum = New KremerControlsWin32.KremerButton()
        Me.TM_BlowOffEnable = New KremerControlsWin32.KremerVariable(Me.components)
        Me.btn_EnableBlowoff = New KremerControlsWin32.KremerButton()
        Me.BMVacEnable = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BTN_EnableBotVac = New KremerControlsWin32.KremerButton()
        Me.BlowOfToTakeOutTime = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TopMoldBlowOffTakeOut = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TopPos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IOTopPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PhysicalMeasTop = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_PhysicalMeasuredTop = New KremerControlsWin32.KremerIoField(Me.components)
        Me.BM_InStop = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_BM_InStop = New KremerControlsWin32.KremerIoField(Me.components)
        Me.BM_OutStop = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_BM_OutStop = New KremerControlsWin32.KremerIoField(Me.components)
        Me.StartVacAtTrPos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_StartVacAtTrPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.StopVacAtBotPos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_StopVacAtBotPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.BotPos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IOBotPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Btn_Overview = New KremerControlsWin32.KremerButton()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape10 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_puh = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Btn_Settings = New System.Windows.Forms.Button()
        Me.Btn_Settings2 = New System.Windows.Forms.Button()
        Me.Btn_Manual = New KremerControlsWin32.KremerButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Me.VarCollector
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.mxAutomode)
        Me.VarCollector.Variables.Add(Me.TM_UpStop)
        Me.VarCollector.Variables.Add(Me.TM_UpCreep)
        Me.VarCollector.Variables.Add(Me.TM_UpSlow)
        Me.VarCollector.Variables.Add(Me.TM_OffsetAlarm)
        Me.VarCollector.Variables.Add(Me.TM_DownSlow)
        Me.VarCollector.Variables.Add(Me.TM_DownCreep)
        Me.VarCollector.Variables.Add(Me.TM_ClosedBlowOffTime)
        Me.VarCollector.Variables.Add(Me.TM_ClosedVacuumTime)
        Me.VarCollector.Variables.Add(Me.TM_DryingTime)
        Me.VarCollector.Variables.Add(Me.BM_VacTime)
        Me.VarCollector.Variables.Add(Me.TM_VacEnable)
        Me.VarCollector.Variables.Add(Me.TM_BlowOffEnable)
        Me.VarCollector.Variables.Add(Me.BMVacEnable)
        Me.VarCollector.Variables.Add(Me.BlowOfToTakeOutTime)
        Me.VarCollector.Variables.Add(Me.TopPos)
        Me.VarCollector.Variables.Add(Me.PhysicalMeasTop)
        Me.VarCollector.Variables.Add(Me.BM_InStop)
        Me.VarCollector.Variables.Add(Me.BM_OutStop)
        Me.VarCollector.Variables.Add(Me.StartVacAtTrPos)
        Me.VarCollector.Variables.Add(Me.StopVacAtBotPos)
        Me.VarCollector.Variables.Add(Me.BotPos)
        '
        'mxAutomode
        '
        Me.mxAutomode.BindControl = Nothing
        Me.mxAutomode.BindProperty = "Data"
        Me.mxAutomode.Data = Nothing
        Me.mxAutomode.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.mxAutomode.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.mxAutomode.VariableName = "MAIN.mxAutomode"
        '
        'TM_UpStop
        '
        Me.TM_UpStop.BindControl = Me.IO_TM_UpStop
        Me.TM_UpStop.BindProperty = "Data"
        Me.TM_UpStop.Data = Nothing
        Me.TM_UpStop.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.TM_UpStop.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TM_UpStop.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].PositionUpStop"
        '
        'IO_TM_UpStop
        '
        Me.IO_TM_UpStop.Audit = Nothing
        Me.IO_TM_UpStop.AuditEnabled = False
        Me.IO_TM_UpStop.AuditMessage = "KremerIoField changed:"
        Me.IO_TM_UpStop.AuditSource = "KremerIoField"
        Me.IO_TM_UpStop.BackColor = System.Drawing.Color.White
        Me.IO_TM_UpStop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_TM_UpStop.Data = 0.0R
        Me.IO_TM_UpStop.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TM_UpStop.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TM_UpStop.InitialValue = True
        Me.IO_TM_UpStop.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TM_UpStop.Location = New System.Drawing.Point(306, 44)
        Me.IO_TM_UpStop.LowerBound = -10000.0R
        Me.IO_TM_UpStop.Name = "IO_TM_UpStop"
        Me.IO_TM_UpStop.OutputFormat = "0.0 mm"
        Me.IO_TM_UpStop.Size = New System.Drawing.Size(100, 22)
        Me.IO_TM_UpStop.TabIndex = 343
        Me.IO_TM_UpStop.Text = "0.0 mm"
        Me.IO_TM_UpStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TM_UpStop.UpperBound = 10000.0R
        Me.IO_TM_UpStop.UserInfo = Nothing
        Me.IO_TM_UpStop.UserLevel = 0
        '
        'TM_UpCreep
        '
        Me.TM_UpCreep.BindControl = Me.IO_PosCreepUp
        Me.TM_UpCreep.BindProperty = "Data"
        Me.TM_UpCreep.Data = Nothing
        Me.TM_UpCreep.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.TM_UpCreep.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TM_UpCreep.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].PositionUpCreep"
        '
        'IO_PosCreepUp
        '
        Me.IO_PosCreepUp.Audit = Nothing
        Me.IO_PosCreepUp.AuditEnabled = False
        Me.IO_PosCreepUp.AuditMessage = "KremerIoField changed:"
        Me.IO_PosCreepUp.AuditSource = "KremerIoField"
        Me.IO_PosCreepUp.BackColor = System.Drawing.Color.White
        Me.IO_PosCreepUp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_PosCreepUp.Data = 0.0R
        Me.IO_PosCreepUp.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_PosCreepUp.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_PosCreepUp.InitialValue = True
        Me.IO_PosCreepUp.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_PosCreepUp.Location = New System.Drawing.Point(306, 67)
        Me.IO_PosCreepUp.LowerBound = -10000.0R
        Me.IO_PosCreepUp.Name = "IO_PosCreepUp"
        Me.IO_PosCreepUp.OutputFormat = "0.0 mm"
        Me.IO_PosCreepUp.Size = New System.Drawing.Size(100, 22)
        Me.IO_PosCreepUp.TabIndex = 403
        Me.IO_PosCreepUp.Text = "0.0 mm"
        Me.IO_PosCreepUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_PosCreepUp.UpperBound = 10000.0R
        Me.IO_PosCreepUp.UserInfo = Nothing
        Me.IO_PosCreepUp.UserLevel = 0
        '
        'TM_UpSlow
        '
        Me.TM_UpSlow.BindControl = Me.IO_TM_UpSlow
        Me.TM_UpSlow.BindProperty = "Data"
        Me.TM_UpSlow.Data = Nothing
        Me.TM_UpSlow.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.TM_UpSlow.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TM_UpSlow.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].PositionUpSlow"
        '
        'IO_TM_UpSlow
        '
        Me.IO_TM_UpSlow.Audit = Nothing
        Me.IO_TM_UpSlow.AuditEnabled = False
        Me.IO_TM_UpSlow.AuditMessage = "KremerIoField changed:"
        Me.IO_TM_UpSlow.AuditSource = "KremerIoField"
        Me.IO_TM_UpSlow.BackColor = System.Drawing.Color.White
        Me.IO_TM_UpSlow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_TM_UpSlow.Data = 0.0R
        Me.IO_TM_UpSlow.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TM_UpSlow.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TM_UpSlow.InitialValue = True
        Me.IO_TM_UpSlow.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TM_UpSlow.Location = New System.Drawing.Point(306, 90)
        Me.IO_TM_UpSlow.LowerBound = -10000.0R
        Me.IO_TM_UpSlow.Name = "IO_TM_UpSlow"
        Me.IO_TM_UpSlow.OutputFormat = "0.0 mm"
        Me.IO_TM_UpSlow.Size = New System.Drawing.Size(100, 22)
        Me.IO_TM_UpSlow.TabIndex = 335
        Me.IO_TM_UpSlow.Text = "0.0 mm"
        Me.IO_TM_UpSlow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TM_UpSlow.UpperBound = 10000.0R
        Me.IO_TM_UpSlow.UserInfo = Nothing
        Me.IO_TM_UpSlow.UserLevel = 0
        '
        'TM_OffsetAlarm
        '
        Me.TM_OffsetAlarm.BindControl = Me.IO_TM_OffsetAlarm
        Me.TM_OffsetAlarm.BindProperty = "Data"
        Me.TM_OffsetAlarm.Data = Nothing
        Me.TM_OffsetAlarm.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.TM_OffsetAlarm.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TM_OffsetAlarm.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].PositionOffsetAlarm"
        '
        'IO_TM_OffsetAlarm
        '
        Me.IO_TM_OffsetAlarm.Audit = Nothing
        Me.IO_TM_OffsetAlarm.AuditEnabled = False
        Me.IO_TM_OffsetAlarm.AuditMessage = "KremerIoField changed:"
        Me.IO_TM_OffsetAlarm.AuditSource = "KremerIoField"
        Me.IO_TM_OffsetAlarm.BackColor = System.Drawing.Color.White
        Me.IO_TM_OffsetAlarm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_TM_OffsetAlarm.Data = 0.0R
        Me.IO_TM_OffsetAlarm.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TM_OffsetAlarm.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TM_OffsetAlarm.InitialValue = True
        Me.IO_TM_OffsetAlarm.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TM_OffsetAlarm.Location = New System.Drawing.Point(306, 160)
        Me.IO_TM_OffsetAlarm.LowerBound = -10000.0R
        Me.IO_TM_OffsetAlarm.Name = "IO_TM_OffsetAlarm"
        Me.IO_TM_OffsetAlarm.OutputFormat = "0.0 mm"
        Me.IO_TM_OffsetAlarm.Size = New System.Drawing.Size(100, 22)
        Me.IO_TM_OffsetAlarm.TabIndex = 362
        Me.IO_TM_OffsetAlarm.Text = "0.0 mm"
        Me.IO_TM_OffsetAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TM_OffsetAlarm.UpperBound = 10000.0R
        Me.IO_TM_OffsetAlarm.UserInfo = Nothing
        Me.IO_TM_OffsetAlarm.UserLevel = 0
        '
        'TM_DownSlow
        '
        Me.TM_DownSlow.BindControl = Me.IO_TopDownSlow
        Me.TM_DownSlow.BindProperty = "Data"
        Me.TM_DownSlow.Data = Nothing
        Me.TM_DownSlow.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.TM_DownSlow.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TM_DownSlow.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].PositionDownSlow"
        '
        'IO_TopDownSlow
        '
        Me.IO_TopDownSlow.Audit = Nothing
        Me.IO_TopDownSlow.AuditEnabled = False
        Me.IO_TopDownSlow.AuditMessage = "KremerIoField changed:"
        Me.IO_TopDownSlow.AuditSource = "KremerIoField"
        Me.IO_TopDownSlow.BackColor = System.Drawing.Color.White
        Me.IO_TopDownSlow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_TopDownSlow.Data = 0.0R
        Me.IO_TopDownSlow.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TopDownSlow.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TopDownSlow.InitialValue = True
        Me.IO_TopDownSlow.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TopDownSlow.Location = New System.Drawing.Point(306, 113)
        Me.IO_TopDownSlow.LowerBound = -5000.0R
        Me.IO_TopDownSlow.Name = "IO_TopDownSlow"
        Me.IO_TopDownSlow.OutputFormat = "0.0 mm"
        Me.IO_TopDownSlow.Size = New System.Drawing.Size(100, 24)
        Me.IO_TopDownSlow.TabIndex = 434
        Me.IO_TopDownSlow.Text = "0.0 mm"
        Me.IO_TopDownSlow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TopDownSlow.UpperBound = 5000.0R
        Me.IO_TopDownSlow.UserInfo = Nothing
        Me.IO_TopDownSlow.UserLevel = 0
        '
        'TM_DownCreep
        '
        Me.TM_DownCreep.BindControl = Me.IO_TopDownCreep
        Me.TM_DownCreep.BindProperty = "Data"
        Me.TM_DownCreep.Data = Nothing
        Me.TM_DownCreep.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.TM_DownCreep.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TM_DownCreep.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].PositionDownCreep"
        '
        'IO_TopDownCreep
        '
        Me.IO_TopDownCreep.Audit = Nothing
        Me.IO_TopDownCreep.AuditEnabled = False
        Me.IO_TopDownCreep.AuditMessage = "KremerIoField changed:"
        Me.IO_TopDownCreep.AuditSource = "KremerIoField"
        Me.IO_TopDownCreep.BackColor = System.Drawing.Color.White
        Me.IO_TopDownCreep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_TopDownCreep.Data = 0.0R
        Me.IO_TopDownCreep.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TopDownCreep.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TopDownCreep.InitialValue = True
        Me.IO_TopDownCreep.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TopDownCreep.Location = New System.Drawing.Point(306, 136)
        Me.IO_TopDownCreep.LowerBound = -5000.0R
        Me.IO_TopDownCreep.Name = "IO_TopDownCreep"
        Me.IO_TopDownCreep.OutputFormat = "0.0 mm"
        Me.IO_TopDownCreep.Size = New System.Drawing.Size(100, 24)
        Me.IO_TopDownCreep.TabIndex = 436
        Me.IO_TopDownCreep.Text = "0.0 mm"
        Me.IO_TopDownCreep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TopDownCreep.UpperBound = 5000.0R
        Me.IO_TopDownCreep.UserInfo = Nothing
        Me.IO_TopDownCreep.UserLevel = 0
        '
        'TM_ClosedBlowOffTime
        '
        Me.TM_ClosedBlowOffTime.BindControl = Me.IO_TM_ClosedBlowOffTime
        Me.TM_ClosedBlowOffTime.BindProperty = "Data"
        Me.TM_ClosedBlowOffTime.Data = Nothing
        Me.TM_ClosedBlowOffTime.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.TM_ClosedBlowOffTime.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TM_ClosedBlowOffTime.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].BlowOffTimeClosed"
        '
        'IO_TM_ClosedBlowOffTime
        '
        Me.IO_TM_ClosedBlowOffTime.Audit = Nothing
        Me.IO_TM_ClosedBlowOffTime.AuditEnabled = False
        Me.IO_TM_ClosedBlowOffTime.AuditMessage = "KremerIoField changed:"
        Me.IO_TM_ClosedBlowOffTime.AuditSource = "KremerIoField"
        Me.IO_TM_ClosedBlowOffTime.BackColor = System.Drawing.Color.White
        Me.IO_TM_ClosedBlowOffTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_TM_ClosedBlowOffTime.Data = 0.0R
        Me.IO_TM_ClosedBlowOffTime.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TM_ClosedBlowOffTime.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TM_ClosedBlowOffTime.InitialValue = True
        Me.IO_TM_ClosedBlowOffTime.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TM_ClosedBlowOffTime.Location = New System.Drawing.Point(675, 92)
        Me.IO_TM_ClosedBlowOffTime.LowerBound = -10000.0R
        Me.IO_TM_ClosedBlowOffTime.Name = "IO_TM_ClosedBlowOffTime"
        Me.IO_TM_ClosedBlowOffTime.OutputFormat = "0.0 ms"
        Me.IO_TM_ClosedBlowOffTime.Size = New System.Drawing.Size(100, 22)
        Me.IO_TM_ClosedBlowOffTime.TabIndex = 331
        Me.IO_TM_ClosedBlowOffTime.Text = "0.0 ms"
        Me.IO_TM_ClosedBlowOffTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TM_ClosedBlowOffTime.UpperBound = 10000.0R
        Me.IO_TM_ClosedBlowOffTime.UserInfo = Nothing
        Me.IO_TM_ClosedBlowOffTime.UserLevel = 0
        '
        'TM_ClosedVacuumTime
        '
        Me.TM_ClosedVacuumTime.BindControl = Me.IO_TM_ClosedVacuumTime
        Me.TM_ClosedVacuumTime.BindProperty = "Data"
        Me.TM_ClosedVacuumTime.Data = Nothing
        Me.TM_ClosedVacuumTime.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.TM_ClosedVacuumTime.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TM_ClosedVacuumTime.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].VacuumTimeClosed"
        '
        'IO_TM_ClosedVacuumTime
        '
        Me.IO_TM_ClosedVacuumTime.Audit = Nothing
        Me.IO_TM_ClosedVacuumTime.AuditEnabled = False
        Me.IO_TM_ClosedVacuumTime.AuditMessage = "KremerIoField changed:"
        Me.IO_TM_ClosedVacuumTime.AuditSource = "KremerIoField"
        Me.IO_TM_ClosedVacuumTime.BackColor = System.Drawing.Color.White
        Me.IO_TM_ClosedVacuumTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_TM_ClosedVacuumTime.Data = 0.0R
        Me.IO_TM_ClosedVacuumTime.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TM_ClosedVacuumTime.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TM_ClosedVacuumTime.InitialValue = True
        Me.IO_TM_ClosedVacuumTime.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TM_ClosedVacuumTime.Location = New System.Drawing.Point(675, 139)
        Me.IO_TM_ClosedVacuumTime.LowerBound = -10000.0R
        Me.IO_TM_ClosedVacuumTime.Name = "IO_TM_ClosedVacuumTime"
        Me.IO_TM_ClosedVacuumTime.OutputFormat = "0.0 ms"
        Me.IO_TM_ClosedVacuumTime.Size = New System.Drawing.Size(100, 22)
        Me.IO_TM_ClosedVacuumTime.TabIndex = 333
        Me.IO_TM_ClosedVacuumTime.Text = "0.0 ms"
        Me.IO_TM_ClosedVacuumTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TM_ClosedVacuumTime.UpperBound = 10000.0R
        Me.IO_TM_ClosedVacuumTime.UserInfo = Nothing
        Me.IO_TM_ClosedVacuumTime.UserLevel = 0
        '
        'TM_DryingTime
        '
        Me.TM_DryingTime.BindControl = Me.IO_TM_DryingTime
        Me.TM_DryingTime.BindProperty = "Data"
        Me.TM_DryingTime.Data = Nothing
        Me.TM_DryingTime.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.TM_DryingTime.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TM_DryingTime.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].DryingTime"
        '
        'IO_TM_DryingTime
        '
        Me.IO_TM_DryingTime.Audit = Nothing
        Me.IO_TM_DryingTime.AuditEnabled = False
        Me.IO_TM_DryingTime.AuditMessage = "KremerIoField changed:"
        Me.IO_TM_DryingTime.AuditSource = "KremerIoField"
        Me.IO_TM_DryingTime.BackColor = System.Drawing.Color.White
        Me.IO_TM_DryingTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_TM_DryingTime.Data = 0.0R
        Me.IO_TM_DryingTime.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TM_DryingTime.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TM_DryingTime.InitialValue = True
        Me.IO_TM_DryingTime.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TM_DryingTime.Location = New System.Drawing.Point(675, 47)
        Me.IO_TM_DryingTime.LowerBound = 0.0R
        Me.IO_TM_DryingTime.Name = "IO_TM_DryingTime"
        Me.IO_TM_DryingTime.OutputFormat = "0.0 ms"
        Me.IO_TM_DryingTime.Size = New System.Drawing.Size(100, 22)
        Me.IO_TM_DryingTime.TabIndex = 370
        Me.IO_TM_DryingTime.Text = "0.0 ms"
        Me.IO_TM_DryingTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TM_DryingTime.UpperBound = 120000.0R
        Me.IO_TM_DryingTime.UserInfo = Nothing
        Me.IO_TM_DryingTime.UserLevel = 0
        '
        'BM_VacTime
        '
        Me.BM_VacTime.BindControl = Me.IO_BotVacTime
        Me.BM_VacTime.BindProperty = "Data"
        Me.BM_VacTime.Data = Nothing
        Me.BM_VacTime.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.BM_VacTime.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BM_VacTime.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].BottomMoldVacuumClosed"
        '
        'IO_BotVacTime
        '
        Me.IO_BotVacTime.Audit = Nothing
        Me.IO_BotVacTime.AuditEnabled = False
        Me.IO_BotVacTime.AuditMessage = "KremerIoField changed:"
        Me.IO_BotVacTime.AuditSource = "KremerIoField"
        Me.IO_BotVacTime.BackColor = System.Drawing.Color.White
        Me.IO_BotVacTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_BotVacTime.Data = 0.0R
        Me.IO_BotVacTime.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_BotVacTime.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_BotVacTime.InitialValue = True
        Me.IO_BotVacTime.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_BotVacTime.Location = New System.Drawing.Point(676, 225)
        Me.IO_BotVacTime.LowerBound = 0.0R
        Me.IO_BotVacTime.Name = "IO_BotVacTime"
        Me.IO_BotVacTime.OutputFormat = "0.0 ms"
        Me.IO_BotVacTime.Size = New System.Drawing.Size(100, 22)
        Me.IO_BotVacTime.TabIndex = 438
        Me.IO_BotVacTime.Text = "0.0 ms"
        Me.IO_BotVacTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_BotVacTime.UpperBound = 60000.0R
        Me.IO_BotVacTime.UserInfo = Nothing
        Me.IO_BotVacTime.UserLevel = 0
        '
        'TM_VacEnable
        '
        Me.TM_VacEnable.BindControl = Me.Btn_EnableVacuum
        Me.TM_VacEnable.BindProperty = "Data"
        Me.TM_VacEnable.Data = Nothing
        Me.TM_VacEnable.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TM_VacEnable.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TM_VacEnable.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].EnableClosedVacuum"
        '
        'Btn_EnableVacuum
        '
        Me.Btn_EnableVacuum.Audit = Nothing
        Me.Btn_EnableVacuum.AuditEnabled = False
        Me.Btn_EnableVacuum.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_EnableVacuum.AuditSource = "KremerPushButton"
        Me.Btn_EnableVacuum.BackColorOn = System.Drawing.Color.Blue
        Me.Btn_EnableVacuum.BackGroundImageOn = Nothing
        Me.Btn_EnableVacuum.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.Btn_EnableVacuum.Data = False
        Me.Btn_EnableVacuum.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EnableVacuum.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_EnableVacuum.Location = New System.Drawing.Point(676, 163)
        Me.Btn_EnableVacuum.Name = "Btn_EnableVacuum"
        Me.Btn_EnableVacuum.Size = New System.Drawing.Size(100, 23)
        Me.Btn_EnableVacuum.State = False
        Me.Btn_EnableVacuum.StateIsData = True
        Me.Btn_EnableVacuum.StateText = New String() {Nothing, Nothing}
        Me.Btn_EnableVacuum.TabIndex = 429
        Me.Btn_EnableVacuum.Tag = "64"
        Me.Btn_EnableVacuum.Text = "Enable"
        Me.Btn_EnableVacuum.UserInfo = Nothing
        Me.Btn_EnableVacuum.UserLevel = 0
        Me.Btn_EnableVacuum.UseStateText = False
        Me.Btn_EnableVacuum.UseVisualStyleBackColor = True
        '
        'TM_BlowOffEnable
        '
        Me.TM_BlowOffEnable.BindControl = Me.btn_EnableBlowoff
        Me.TM_BlowOffEnable.BindProperty = "Data"
        Me.TM_BlowOffEnable.Data = Nothing
        Me.TM_BlowOffEnable.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TM_BlowOffEnable.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TM_BlowOffEnable.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].EnableClosedBlowOff"
        '
        'btn_EnableBlowoff
        '
        Me.btn_EnableBlowoff.Audit = Nothing
        Me.btn_EnableBlowoff.AuditEnabled = False
        Me.btn_EnableBlowoff.AuditMessage = "KremerPushButton pressed!"
        Me.btn_EnableBlowoff.AuditSource = "KremerPushButton"
        Me.btn_EnableBlowoff.BackColorOn = System.Drawing.Color.Blue
        Me.btn_EnableBlowoff.BackGroundImageOn = Nothing
        Me.btn_EnableBlowoff.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.btn_EnableBlowoff.Data = False
        Me.btn_EnableBlowoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_EnableBlowoff.ForeColorOn = System.Drawing.Color.Yellow
        Me.btn_EnableBlowoff.Location = New System.Drawing.Point(675, 116)
        Me.btn_EnableBlowoff.Name = "btn_EnableBlowoff"
        Me.btn_EnableBlowoff.Size = New System.Drawing.Size(100, 23)
        Me.btn_EnableBlowoff.State = False
        Me.btn_EnableBlowoff.StateIsData = True
        Me.btn_EnableBlowoff.StateText = New String() {Nothing, Nothing}
        Me.btn_EnableBlowoff.TabIndex = 428
        Me.btn_EnableBlowoff.Tag = "64"
        Me.btn_EnableBlowoff.Text = "Enable"
        Me.btn_EnableBlowoff.UserInfo = Nothing
        Me.btn_EnableBlowoff.UserLevel = 0
        Me.btn_EnableBlowoff.UseStateText = False
        Me.btn_EnableBlowoff.UseVisualStyleBackColor = True
        '
        'BMVacEnable
        '
        Me.BMVacEnable.BindControl = Me.BTN_EnableBotVac
        Me.BMVacEnable.BindProperty = "Data"
        Me.BMVacEnable.Data = Nothing
        Me.BMVacEnable.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BMVacEnable.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMVacEnable.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].ClosedVacEnabled"
        '
        'BTN_EnableBotVac
        '
        Me.BTN_EnableBotVac.Audit = Nothing
        Me.BTN_EnableBotVac.AuditEnabled = False
        Me.BTN_EnableBotVac.AuditMessage = "KremerPushButton pressed!"
        Me.BTN_EnableBotVac.AuditSource = "KremerPushButton"
        Me.BTN_EnableBotVac.BackColorOn = System.Drawing.Color.Blue
        Me.BTN_EnableBotVac.BackGroundImageOn = Nothing
        Me.BTN_EnableBotVac.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.BTN_EnableBotVac.Data = False
        Me.BTN_EnableBotVac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_EnableBotVac.ForeColorOn = System.Drawing.Color.Yellow
        Me.BTN_EnableBotVac.Location = New System.Drawing.Point(677, 249)
        Me.BTN_EnableBotVac.Name = "BTN_EnableBotVac"
        Me.BTN_EnableBotVac.Size = New System.Drawing.Size(100, 23)
        Me.BTN_EnableBotVac.State = False
        Me.BTN_EnableBotVac.StateIsData = True
        Me.BTN_EnableBotVac.StateText = New String() {Nothing, Nothing}
        Me.BTN_EnableBotVac.TabIndex = 440
        Me.BTN_EnableBotVac.Tag = "64"
        Me.BTN_EnableBotVac.Text = "Enable"
        Me.BTN_EnableBotVac.UserInfo = Nothing
        Me.BTN_EnableBotVac.UserLevel = 0
        Me.BTN_EnableBotVac.UseStateText = False
        Me.BTN_EnableBotVac.UseVisualStyleBackColor = True
        '
        'BlowOfToTakeOutTime
        '
        Me.BlowOfToTakeOutTime.BindControl = Me.IO_TopMoldBlowOffTakeOut
        Me.BlowOfToTakeOutTime.BindProperty = "Data"
        Me.BlowOfToTakeOutTime.Data = Nothing
        Me.BlowOfToTakeOutTime.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.BlowOfToTakeOutTime.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BlowOfToTakeOutTime.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].BlowOffToTakeOut"
        '
        'IO_TopMoldBlowOffTakeOut
        '
        Me.IO_TopMoldBlowOffTakeOut.Audit = Nothing
        Me.IO_TopMoldBlowOffTakeOut.AuditEnabled = False
        Me.IO_TopMoldBlowOffTakeOut.AuditMessage = "KremerIoField changed:"
        Me.IO_TopMoldBlowOffTakeOut.AuditSource = "KremerIoField"
        Me.IO_TopMoldBlowOffTakeOut.BackColor = System.Drawing.Color.White
        Me.IO_TopMoldBlowOffTakeOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_TopMoldBlowOffTakeOut.Data = 0.0R
        Me.IO_TopMoldBlowOffTakeOut.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TopMoldBlowOffTakeOut.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TopMoldBlowOffTakeOut.InitialValue = True
        Me.IO_TopMoldBlowOffTakeOut.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TopMoldBlowOffTakeOut.Location = New System.Drawing.Point(675, 69)
        Me.IO_TopMoldBlowOffTakeOut.LowerBound = 0.0R
        Me.IO_TopMoldBlowOffTakeOut.Name = "IO_TopMoldBlowOffTakeOut"
        Me.IO_TopMoldBlowOffTakeOut.OutputFormat = "0.0 ms"
        Me.IO_TopMoldBlowOffTakeOut.Size = New System.Drawing.Size(100, 22)
        Me.IO_TopMoldBlowOffTakeOut.TabIndex = 392
        Me.IO_TopMoldBlowOffTakeOut.Text = "0.0 ms"
        Me.IO_TopMoldBlowOffTakeOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TopMoldBlowOffTakeOut.UpperBound = 120000.0R
        Me.IO_TopMoldBlowOffTakeOut.UserInfo = Nothing
        Me.IO_TopMoldBlowOffTakeOut.UserLevel = 0
        '
        'TopPos
        '
        Me.TopPos.BindControl = Me.IOTopPos
        Me.TopPos.BindProperty = "Data"
        Me.TopPos.Data = Nothing
        Me.TopPos.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.TopPos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TopPos.VariableName = "MAIN.InMoldDrying.Top[Position1].HydraulicCilinder.ActPosition"
        '
        'IOTopPos
        '
        Me.IOTopPos.Audit = Nothing
        Me.IOTopPos.AuditEnabled = False
        Me.IOTopPos.AuditMessage = "KremerIoField changed:"
        Me.IOTopPos.AuditSource = "KremerIoField"
        Me.IOTopPos.Data = 0.0R
        Me.IOTopPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IOTopPos.InitialValue = True
        Me.IOTopPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IOTopPos.Location = New System.Drawing.Point(310, 17)
        Me.IOTopPos.LowerBound = 0.0R
        Me.IOTopPos.Name = "IOTopPos"
        Me.IOTopPos.OutputFormat = "0.0 mm"
        Me.IOTopPos.Size = New System.Drawing.Size(71, 21)
        Me.IOTopPos.TabIndex = 382
        Me.IOTopPos.Text = "0.0 mm"
        Me.IOTopPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IOTopPos.UpperBound = 1000.0R
        Me.IOTopPos.UserInfo = Nothing
        Me.IOTopPos.UserLevel = 0
        '
        'PhysicalMeasTop
        '
        Me.PhysicalMeasTop.BindControl = Me.IO_PhysicalMeasuredTop
        Me.PhysicalMeasTop.BindProperty = "Data"
        Me.PhysicalMeasTop.Data = Nothing
        Me.PhysicalMeasTop.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.PhysicalMeasTop.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PhysicalMeasTop.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].PositionPhyscialMeasured"
        '
        'IO_PhysicalMeasuredTop
        '
        Me.IO_PhysicalMeasuredTop.Audit = Nothing
        Me.IO_PhysicalMeasuredTop.AuditEnabled = False
        Me.IO_PhysicalMeasuredTop.AuditMessage = "KremerIoField changed:"
        Me.IO_PhysicalMeasuredTop.AuditSource = "KremerIoField"
        Me.IO_PhysicalMeasuredTop.BackColor = System.Drawing.Color.White
        Me.IO_PhysicalMeasuredTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_PhysicalMeasuredTop.Data = 0.0R
        Me.IO_PhysicalMeasuredTop.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_PhysicalMeasuredTop.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_PhysicalMeasuredTop.InitialValue = True
        Me.IO_PhysicalMeasuredTop.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_PhysicalMeasuredTop.Location = New System.Drawing.Point(306, 183)
        Me.IO_PhysicalMeasuredTop.LowerBound = -10000.0R
        Me.IO_PhysicalMeasuredTop.Name = "IO_PhysicalMeasuredTop"
        Me.IO_PhysicalMeasuredTop.OutputFormat = "0.0 mm"
        Me.IO_PhysicalMeasuredTop.Size = New System.Drawing.Size(100, 22)
        Me.IO_PhysicalMeasuredTop.TabIndex = 383
        Me.IO_PhysicalMeasuredTop.Text = "0.0 mm"
        Me.IO_PhysicalMeasuredTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_PhysicalMeasuredTop.UpperBound = 10000.0R
        Me.IO_PhysicalMeasuredTop.UserInfo = Nothing
        Me.IO_PhysicalMeasuredTop.UserLevel = 0
        '
        'BM_InStop
        '
        Me.BM_InStop.BindControl = Me.IO_BM_InStop
        Me.BM_InStop.BindProperty = "Data"
        Me.BM_InStop.Data = Nothing
        Me.BM_InStop.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.BM_InStop.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BM_InStop.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].PositionInStop"
        '
        'IO_BM_InStop
        '
        Me.IO_BM_InStop.Audit = Nothing
        Me.IO_BM_InStop.AuditEnabled = False
        Me.IO_BM_InStop.AuditMessage = "KremerIoField changed:"
        Me.IO_BM_InStop.AuditSource = "KremerIoField"
        Me.IO_BM_InStop.BackColor = System.Drawing.Color.White
        Me.IO_BM_InStop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_BM_InStop.Data = 0.0R
        Me.IO_BM_InStop.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_BM_InStop.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_BM_InStop.InitialValue = True
        Me.IO_BM_InStop.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_BM_InStop.Location = New System.Drawing.Point(306, 270)
        Me.IO_BM_InStop.LowerBound = -10000.0R
        Me.IO_BM_InStop.Name = "IO_BM_InStop"
        Me.IO_BM_InStop.OutputFormat = "0.0 mm"
        Me.IO_BM_InStop.Size = New System.Drawing.Size(100, 22)
        Me.IO_BM_InStop.TabIndex = 352
        Me.IO_BM_InStop.Text = "0.0 mm"
        Me.IO_BM_InStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_BM_InStop.UpperBound = 10000.0R
        Me.IO_BM_InStop.UserInfo = Nothing
        Me.IO_BM_InStop.UserLevel = 0
        '
        'BM_OutStop
        '
        Me.BM_OutStop.BindControl = Me.IO_BM_OutStop
        Me.BM_OutStop.BindProperty = "Data"
        Me.BM_OutStop.Data = Nothing
        Me.BM_OutStop.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.BM_OutStop.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BM_OutStop.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].PositionOutStop"
        '
        'IO_BM_OutStop
        '
        Me.IO_BM_OutStop.Audit = Nothing
        Me.IO_BM_OutStop.AuditEnabled = False
        Me.IO_BM_OutStop.AuditMessage = "KremerIoField changed:"
        Me.IO_BM_OutStop.AuditSource = "KremerIoField"
        Me.IO_BM_OutStop.BackColor = System.Drawing.Color.White
        Me.IO_BM_OutStop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_BM_OutStop.Data = 0.0R
        Me.IO_BM_OutStop.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_BM_OutStop.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_BM_OutStop.InitialValue = True
        Me.IO_BM_OutStop.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_BM_OutStop.Location = New System.Drawing.Point(306, 296)
        Me.IO_BM_OutStop.LowerBound = -10000.0R
        Me.IO_BM_OutStop.Name = "IO_BM_OutStop"
        Me.IO_BM_OutStop.OutputFormat = "0.0 mm"
        Me.IO_BM_OutStop.Size = New System.Drawing.Size(100, 22)
        Me.IO_BM_OutStop.TabIndex = 348
        Me.IO_BM_OutStop.Text = "0.0 mm"
        Me.IO_BM_OutStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_BM_OutStop.UpperBound = 10000.0R
        Me.IO_BM_OutStop.UserInfo = Nothing
        Me.IO_BM_OutStop.UserLevel = 0
        '
        'StartVacAtTrPos
        '
        Me.StartVacAtTrPos.BindControl = Me.IO_StartVacAtTrPos
        Me.StartVacAtTrPos.BindProperty = "Data"
        Me.StartVacAtTrPos.Data = Nothing
        Me.StartVacAtTrPos.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.StartVacAtTrPos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StartVacAtTrPos.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].StartVacAtTrPosOffset"
        '
        'IO_StartVacAtTrPos
        '
        Me.IO_StartVacAtTrPos.Audit = Nothing
        Me.IO_StartVacAtTrPos.AuditEnabled = False
        Me.IO_StartVacAtTrPos.AuditMessage = "KremerIoField changed:"
        Me.IO_StartVacAtTrPos.AuditSource = "KremerIoField"
        Me.IO_StartVacAtTrPos.BackColor = System.Drawing.Color.White
        Me.IO_StartVacAtTrPos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_StartVacAtTrPos.Data = 0.0R
        Me.IO_StartVacAtTrPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_StartVacAtTrPos.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_StartVacAtTrPos.InitialValue = True
        Me.IO_StartVacAtTrPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_StartVacAtTrPos.Location = New System.Drawing.Point(307, 369)
        Me.IO_StartVacAtTrPos.LowerBound = -5000.0R
        Me.IO_StartVacAtTrPos.Name = "IO_StartVacAtTrPos"
        Me.IO_StartVacAtTrPos.OutputFormat = "0.0 mm"
        Me.IO_StartVacAtTrPos.Size = New System.Drawing.Size(100, 22)
        Me.IO_StartVacAtTrPos.TabIndex = 426
        Me.IO_StartVacAtTrPos.Text = "0.0 mm"
        Me.IO_StartVacAtTrPos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_StartVacAtTrPos.UpperBound = 5000.0R
        Me.IO_StartVacAtTrPos.UserInfo = Nothing
        Me.IO_StartVacAtTrPos.UserLevel = 0
        '
        'StopVacAtBotPos
        '
        Me.StopVacAtBotPos.BindControl = Me.IO_StopVacAtBotPos
        Me.StopVacAtBotPos.BindProperty = "Data"
        Me.StopVacAtBotPos.Data = Nothing
        Me.StopVacAtBotPos.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.StopVacAtBotPos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StopVacAtBotPos.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].StopVacAtBmPosOffset"
        '
        'IO_StopVacAtBotPos
        '
        Me.IO_StopVacAtBotPos.Audit = Nothing
        Me.IO_StopVacAtBotPos.AuditEnabled = False
        Me.IO_StopVacAtBotPos.AuditMessage = "KremerIoField changed:"
        Me.IO_StopVacAtBotPos.AuditSource = "KremerIoField"
        Me.IO_StopVacAtBotPos.BackColor = System.Drawing.Color.White
        Me.IO_StopVacAtBotPos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_StopVacAtBotPos.Data = 0.0R
        Me.IO_StopVacAtBotPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_StopVacAtBotPos.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_StopVacAtBotPos.InitialValue = True
        Me.IO_StopVacAtBotPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_StopVacAtBotPos.Location = New System.Drawing.Point(307, 392)
        Me.IO_StopVacAtBotPos.LowerBound = -5000.0R
        Me.IO_StopVacAtBotPos.Name = "IO_StopVacAtBotPos"
        Me.IO_StopVacAtBotPos.OutputFormat = "0.0 mm"
        Me.IO_StopVacAtBotPos.Size = New System.Drawing.Size(100, 22)
        Me.IO_StopVacAtBotPos.TabIndex = 427
        Me.IO_StopVacAtBotPos.Text = "0.0 mm"
        Me.IO_StopVacAtBotPos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_StopVacAtBotPos.UpperBound = 5000.0R
        Me.IO_StopVacAtBotPos.UserInfo = Nothing
        Me.IO_StopVacAtBotPos.UserLevel = 0
        '
        'BotPos
        '
        Me.BotPos.BindControl = Me.IOBotPos
        Me.BotPos.BindProperty = "Data"
        Me.BotPos.Data = Nothing
        Me.BotPos.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.BotPos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BotPos.VariableName = "MAIN.InMoldDrying.Bottom[Position1].HorizontalAxis.ActPosition"
        '
        'IOBotPos
        '
        Me.IOBotPos.Audit = Nothing
        Me.IOBotPos.AuditEnabled = False
        Me.IOBotPos.AuditMessage = "KremerIoField changed:"
        Me.IOBotPos.AuditSource = "KremerIoField"
        Me.IOBotPos.Data = 0.0R
        Me.IOBotPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IOBotPos.InitialValue = True
        Me.IOBotPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IOBotPos.Location = New System.Drawing.Point(310, 245)
        Me.IOBotPos.LowerBound = 0.0R
        Me.IOBotPos.Name = "IOBotPos"
        Me.IOBotPos.OutputFormat = "0.0 mm"
        Me.IOBotPos.Size = New System.Drawing.Size(71, 21)
        Me.IOBotPos.TabIndex = 381
        Me.IOBotPos.Text = "0.0 mm"
        Me.IOBotPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IOBotPos.UpperBound = 1000.0R
        Me.IOBotPos.UserInfo = Nothing
        Me.IOBotPos.UserLevel = 0
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
        Me.Btn_Overview.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_Overview.Data = False
        Me.Btn_Overview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Overview.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Overview.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_Overview.Location = New System.Drawing.Point(684, 382)
        Me.Btn_Overview.Name = "Btn_Overview"
        Me.Btn_Overview.Size = New System.Drawing.Size(114, 50)
        Me.Btn_Overview.State = False
        Me.Btn_Overview.StateIsData = True
        Me.Btn_Overview.StateText = New String() {Nothing, Nothing}
        Me.Btn_Overview.TabIndex = 307
        Me.Btn_Overview.Tag = "194"
        Me.Btn_Overview.Text = "Overview"
        Me.Btn_Overview.UserInfo = Nothing
        Me.Btn_Overview.UserLevel = 0
        Me.Btn_Overview.UseStateText = False
        Me.Btn_Overview.UseVisualStyleBackColor = True
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 670
        Me.LineShape3.X2 = 670
        Me.LineShape3.Y1 = 40
        Me.LineShape3.Y2 = 179
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 425
        Me.LineShape2.X2 = 775
        Me.LineShape2.Y1 = 40
        Me.LineShape2.Y2 = 40
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape8, Me.LineShape7, Me.LineShape10, Me.LineShape9, Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape1, Me.LineShape2, Me.LineShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 435)
        Me.ShapeContainer1.TabIndex = 308
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape8
        '
        Me.LineShape8.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape8.Name = "LineShape8"
        Me.LineShape8.X1 = 427
        Me.LineShape8.X2 = 777
        Me.LineShape8.Y1 = 221
        Me.LineShape8.Y2 = 221
        '
        'LineShape7
        '
        Me.LineShape7.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 672
        Me.LineShape7.X2 = 672
        Me.LineShape7.Y1 = 221
        Me.LineShape7.Y2 = 275
        '
        'LineShape10
        '
        Me.LineShape10.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape10.Name = "LineShape10"
        Me.LineShape10.X1 = 303
        Me.LineShape10.X2 = 303
        Me.LineShape10.Y1 = 364
        Me.LineShape10.Y2 = 422
        '
        'LineShape9
        '
        Me.LineShape9.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape9.Name = "LineShape9"
        Me.LineShape9.X1 = 26
        Me.LineShape9.X2 = 405
        Me.LineShape9.Y1 = 364
        Me.LineShape9.Y2 = 364
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 26
        Me.LineShape6.X2 = 405
        Me.LineShape6.Y1 = 266
        Me.LineShape6.Y2 = 266
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 302
        Me.LineShape5.X2 = 302
        Me.LineShape5.Y1 = 266
        Me.LineShape5.Y2 = 324
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 302
        Me.LineShape4.X2 = 302
        Me.LineShape4.Y1 = 40
        Me.LineShape4.Y2 = 225
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 30
        Me.LineShape1.X2 = 405
        Me.LineShape1.Y1 = 40
        Me.LineShape1.Y2 = 40
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(26, 46)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(247, 23)
        Me.Label17.TabIndex = 344
        Me.Label17.Tag = "141"
        Me.Label17.Text = "Top mold up stop"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(247, 23)
        Me.Label7.TabIndex = 336
        Me.Label7.Tag = "143"
        Me.Label7.Text = "Top mold up slow offset"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(422, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(247, 23)
        Me.Label8.TabIndex = 334
        Me.Label8.Tag = "152"
        Me.Label8.Text = "Top closed vacuum time"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(422, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 23)
        Me.Label5.TabIndex = 332
        Me.Label5.Tag = "151"
        Me.Label5.Text = "Top closed blow off time"
        '
        'lbl_puh
        '
        Me.lbl_puh.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_puh.Location = New System.Drawing.Point(418, 15)
        Me.lbl_puh.Name = "lbl_puh"
        Me.lbl_puh.Size = New System.Drawing.Size(300, 23)
        Me.lbl_puh.TabIndex = 326
        Me.lbl_puh.Tag = "150"
        Me.lbl_puh.Text = "Blowoff and vacuum topmold"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(26, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 23)
        Me.Label2.TabIndex = 345
        Me.Label2.Tag = "140"
        Me.Label2.Text = "Positions top mold"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(22, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 23)
        Me.Label3.TabIndex = 354
        Me.Label3.Tag = "160"
        Me.Label3.Text = "Positions bottom mold"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 23)
        Me.Label4.TabIndex = 353
        Me.Label4.Tag = "161"
        Me.Label4.Text = "Bottom mold in stop"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(22, 294)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(247, 23)
        Me.Label10.TabIndex = 349
        Me.Label10.Tag = "163"
        Me.Label10.Text = "Bottom mold out stop"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 23)
        Me.Label1.TabIndex = 365
        Me.Label1.Tag = ""
        Me.Label1.Text = "Top mold offset alarm"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(421, 46)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(247, 23)
        Me.Label19.TabIndex = 371
        Me.Label19.Tag = "155"
        Me.Label19.Text = "Top drying time"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Btn_Settings)
        Me.Panel1.Controls.Add(Me.Btn_Settings2)
        Me.Panel1.Location = New System.Drawing.Point(514, 329)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(165, 106)
        Me.Panel1.TabIndex = 378
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(-1, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(165, 23)
        Me.Label23.TabIndex = 257
        Me.Label23.Tag = "80"
        Me.Label23.Text = "More Settings"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Btn_Manual
        '
        Me.Btn_Manual.Audit = Nothing
        Me.Btn_Manual.AuditEnabled = False
        Me.Btn_Manual.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_Manual.AuditSource = "KremerPushButton"
        Me.Btn_Manual.BackColorOn = System.Drawing.Color.Empty
        Me.Btn_Manual.BackGroundImageOn = Nothing
        Me.Btn_Manual.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_Manual.Data = False
        Me.Btn_Manual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Manual.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Manual.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_Manual.Location = New System.Drawing.Point(684, 329)
        Me.Btn_Manual.Name = "Btn_Manual"
        Me.Btn_Manual.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Manual.State = False
        Me.Btn_Manual.StateIsData = True
        Me.Btn_Manual.StateText = New String() {Nothing, Nothing}
        Me.Btn_Manual.TabIndex = 309
        Me.Btn_Manual.Tag = "192"
        Me.Btn_Manual.Text = "Manual" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Control"
        Me.Btn_Manual.UserInfo = Nothing
        Me.Btn_Manual.UserLevel = 0
        Me.Btn_Manual.UseStateText = False
        Me.Btn_Manual.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(26, 180)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(247, 23)
        Me.Label12.TabIndex = 384
        Me.Label12.Tag = ""
        Me.Label12.Text = "Physical measured position"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(422, 70)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(247, 23)
        Me.Label24.TabIndex = 393
        Me.Label24.Tag = "153"
        Me.Label24.Text = "Top blow off to take out"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(26, 68)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(247, 23)
        Me.Label21.TabIndex = 404
        Me.Label21.Tag = "142"
        Me.Label21.Text = "Top mold up creep offset"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(24, 340)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(331, 23)
        Me.Label11.TabIndex = 415
        Me.Label11.Tag = "165"
        Me.Label11.Text = "Offset positions vacuum blowoff"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 394)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(279, 23)
        Me.Label6.TabIndex = 424
        Me.Label6.Tag = "167"
        Me.Label6.Text = "Stop Vac. at BottomM pos offset"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(22, 371)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(272, 23)
        Me.Label13.TabIndex = 423
        Me.Label13.Tag = "166"
        Me.Label13.Text = "Start Vac. At Transfer pos offset"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(422, 118)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(247, 23)
        Me.Label15.TabIndex = 430
        Me.Label15.Tag = "156"
        Me.Label15.Text = "Closed blowoff "
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(421, 164)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(247, 23)
        Me.Label16.TabIndex = 431
        Me.Label16.Tag = "157"
        Me.Label16.Text = "Closed vacuum"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(267, 24)
        Me.Label9.TabIndex = 437
        Me.Label9.Tag = "146"
        Me.Label9.Text = "Top mold down creep offset"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(26, 113)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(267, 24)
        Me.Label20.TabIndex = 435
        Me.Label20.Tag = "145"
        Me.Label20.Text = "Top mold down slow offset"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(422, 250)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(247, 23)
        Me.Label14.TabIndex = 441
        Me.Label14.Tag = "157"
        Me.Label14.Text = "Closed vacuum"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(423, 227)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(247, 23)
        Me.Label18.TabIndex = 439
        Me.Label18.Tag = ""
        Me.Label18.Text = "Bottom closed vacuum time"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.Location = New System.Drawing.Point(423, 197)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(355, 23)
        Me.Label22.TabIndex = 442
        Me.Label22.Tag = ""
        Me.Label22.Text = "Blowoff and vacuum Bottommold"
        '
        'DryingMoldSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.BTN_EnableBotVac)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.IO_BotVacTime)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.IO_TopDownCreep)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.IO_TopDownSlow)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Btn_EnableVacuum)
        Me.Controls.Add(Me.btn_EnableBlowoff)
        Me.Controls.Add(Me.IO_StopVacAtBotPos)
        Me.Controls.Add(Me.IO_StartVacAtTrPos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.IO_PosCreepUp)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.IO_TopMoldBlowOffTakeOut)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.IO_PhysicalMeasuredTop)
        Me.Controls.Add(Me.IOTopPos)
        Me.Controls.Add(Me.IOBotPos)
        Me.Controls.Add(Me.Btn_Manual)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.IO_TM_DryingTime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IO_TM_OffsetAlarm)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.IO_BM_InStop)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.IO_BM_OutStop)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.IO_TM_UpStop)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.IO_TM_UpSlow)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.IO_TM_ClosedVacuumTime)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.IO_TM_ClosedBlowOffTime)
        Me.Controls.Add(Me.lbl_puh)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "DryingMoldSettings"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = ""
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents mxAutomode As KremerControlsWin32.KremerVariable
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents IO_TM_UpStop As KremerControlsWin32.KremerIoField
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents IO_TM_UpSlow As KremerControlsWin32.KremerIoField
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents IO_TM_ClosedVacuumTime As KremerControlsWin32.KremerIoField
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents IO_TM_ClosedBlowOffTime As KremerControlsWin32.KremerIoField
    Friend WithEvents lbl_puh As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents IO_BM_InStop As KremerControlsWin32.KremerIoField
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents IO_BM_OutStop As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_TM_OffsetAlarm As KremerControlsWin32.KremerIoField
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents IO_TM_DryingTime As KremerControlsWin32.KremerIoField
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Btn_Settings As System.Windows.Forms.Button
    Friend WithEvents Btn_Settings2 As System.Windows.Forms.Button
    Friend WithEvents Btn_Manual As KremerControlsWin32.KremerButton
    Friend WithEvents TM_UpStop As KremerControlsWin32.KremerVariable
    Friend WithEvents TM_UpSlow As KremerControlsWin32.KremerVariable
    Friend WithEvents TM_OffsetAlarm As KremerControlsWin32.KremerVariable
    Friend WithEvents TM_ClosedBlowOffTime As KremerControlsWin32.KremerVariable
    Friend WithEvents TM_ClosedVacuumTime As KremerControlsWin32.KremerVariable
    Friend WithEvents TM_DryingTime As KremerControlsWin32.KremerVariable
    Friend WithEvents BM_InStop As KremerControlsWin32.KremerVariable
    Friend WithEvents BM_OutStop As KremerControlsWin32.KremerVariable
    Friend WithEvents IOBotPos As KremerControlsWin32.KremerIoField
    Friend WithEvents TopPos As KremerControlsWin32.KremerVariable
    Friend WithEvents IOTopPos As KremerControlsWin32.KremerIoField
    Friend WithEvents BotPos As KremerControlsWin32.KremerVariable
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents IO_PhysicalMeasuredTop As KremerControlsWin32.KremerIoField
    Friend WithEvents PhysicalMeasTop As KremerControlsWin32.KremerVariable
    Friend WithEvents BlowOfToTakeOutTime As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_TopMoldBlowOffTakeOut As KremerControlsWin32.KremerIoField
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents IO_PosCreepUp As KremerControlsWin32.KremerIoField
    Friend WithEvents LineShape10 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape9 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents IO_StopVacAtBotPos As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_StartVacAtTrPos As KremerControlsWin32.KremerIoField
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btn_EnableBlowoff As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_EnableVacuum As KremerControlsWin32.KremerButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents IO_TopDownCreep As KremerControlsWin32.KremerIoField
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents IO_TopDownSlow As KremerControlsWin32.KremerIoField
    Friend WithEvents TM_UpCreep As KremerControlsWin32.KremerVariable
    Friend WithEvents TM_DownSlow As KremerControlsWin32.KremerVariable
    Friend WithEvents TM_DownCreep As KremerControlsWin32.KremerVariable
    Friend WithEvents StartVacAtTrPos As KremerControlsWin32.KremerVariable
    Friend WithEvents StopVacAtBotPos As KremerControlsWin32.KremerVariable
    Friend WithEvents BM_VacTime As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_BotVacTime As KremerControlsWin32.KremerIoField
    Friend WithEvents TM_VacEnable As KremerControlsWin32.KremerVariable
    Friend WithEvents TM_BlowOffEnable As KremerControlsWin32.KremerVariable
    Friend WithEvents BMVacEnable As KremerControlsWin32.KremerVariable
    Friend WithEvents BTN_EnableBotVac As KremerControlsWin32.KremerButton
    Friend WithEvents LineShape8 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label

End Class
