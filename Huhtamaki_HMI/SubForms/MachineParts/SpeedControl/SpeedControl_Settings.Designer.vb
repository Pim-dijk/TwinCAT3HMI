<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpeedControl_Settings
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
        Me.Btn_Manual = New KremerControlsWin32.KremerButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape10 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.mxAutoMode = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ConManVelo = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_ConManVelo = New KremerControlsWin32.KremerIoField(Me.components)
        Me.StartSpeed = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_startSpeed = New KremerControlsWin32.KremerIoField(Me.components)
        Me.EnableIMD1 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BTN_EnableIMD1 = New KremerControlsWin32.KremerButton()
        Me.EnableIMD2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BTN_EnableIMD2 = New KremerControlsWin32.KremerButton()
        Me.Modulo = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_Modulo = New KremerControlsWin32.KremerIoField(Me.components)
        Me.SpeedKO_FTL = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_SpeedFTL = New KremerControlsWin32.KremerIoField(Me.components)
        Me.NrOfSheets = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_nrOfSheets = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PitchGantry = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_GantryPitch = New KremerControlsWin32.KremerIoField(Me.components)
        Me.RampNrOfModulo = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_RampNrModulo = New KremerControlsWin32.KremerIoField(Me.components)
        Me.GantryOffset = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_SensorAoffset = New KremerControlsWin32.KremerIoField(Me.components)
        Me.DetectionSensorFree = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_DetectionSensorActive = New KremerControlsWin32.KremerIoField(Me.components)
        Me.SheetSize = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_SheetSize = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
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
        Me.Btn_Overview.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_Overview.Data = False
        Me.Btn_Overview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Overview.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Overview.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_Overview.Location = New System.Drawing.Point(684, 326)
        Me.Btn_Overview.Name = "Btn_Overview"
        Me.Btn_Overview.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Overview.State = False
        Me.Btn_Overview.StateIsData = True
        Me.Btn_Overview.StateText = New String() {Nothing, Nothing}
        Me.Btn_Overview.TabIndex = 8
        Me.Btn_Overview.Tag = "194"
        Me.Btn_Overview.Text = "Overview"
        Me.Btn_Overview.UserInfo = Nothing
        Me.Btn_Overview.UserLevel = 0
        Me.Btn_Overview.UseStateText = False
        Me.Btn_Overview.UseVisualStyleBackColor = True
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
        Me.Btn_Manual.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Manual.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_Manual.Location = New System.Drawing.Point(684, 382)
        Me.Btn_Manual.Name = "Btn_Manual"
        Me.Btn_Manual.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Manual.State = False
        Me.Btn_Manual.StateIsData = True
        Me.Btn_Manual.StateText = New String() {Nothing, Nothing}
        Me.Btn_Manual.TabIndex = 7
        Me.Btn_Manual.Tag = "192"
        Me.Btn_Manual.Text = "Manual Control"
        Me.Btn_Manual.UserInfo = Nothing
        Me.Btn_Manual.UserLevel = 0
        Me.Btn_Manual.UseStateText = False
        Me.Btn_Manual.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1, Me.LineShape10, Me.LineShape9})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 435)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 663
        Me.LineShape6.X2 = 663
        Me.LineShape6.Y1 = 202
        Me.LineShape6.Y2 = 253
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 403
        Me.LineShape5.X2 = 775
        Me.LineShape5.Y1 = 201
        Me.LineShape5.Y2 = 201
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 403
        Me.LineShape4.X2 = 775
        Me.LineShape4.Y1 = 36
        Me.LineShape4.Y2 = 36
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 663
        Me.LineShape3.X2 = 663
        Me.LineShape3.Y1 = 37
        Me.LineShape3.Y2 = 88
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 268
        Me.LineShape2.X2 = 268
        Me.LineShape2.Y1 = 201
        Me.LineShape2.Y2 = 300
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 23
        Me.LineShape1.X2 = 373
        Me.LineShape1.Y1 = 201
        Me.LineShape1.Y2 = 201
        '
        'LineShape10
        '
        Me.LineShape10.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape10.Name = "LineShape10"
        Me.LineShape10.X1 = 23
        Me.LineShape10.X2 = 373
        Me.LineShape10.Y1 = 36
        Me.LineShape10.Y2 = 36
        '
        'LineShape9
        '
        Me.LineShape9.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape9.Name = "LineShape9"
        Me.LineShape9.X1 = 268
        Me.LineShape9.X2 = 268
        Me.LineShape9.Y1 = 36
        Me.LineShape9.Y2 = 120
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.mxAutoMode)
        Me.VarCollector.Variables.Add(Me.ConManVelo)
        Me.VarCollector.Variables.Add(Me.StartSpeed)
        Me.VarCollector.Variables.Add(Me.EnableIMD1)
        Me.VarCollector.Variables.Add(Me.EnableIMD2)
        Me.VarCollector.Variables.Add(Me.Modulo)
        Me.VarCollector.Variables.Add(Me.SpeedKO_FTL)
        Me.VarCollector.Variables.Add(Me.NrOfSheets)
        Me.VarCollector.Variables.Add(Me.PitchGantry)
        Me.VarCollector.Variables.Add(Me.RampNrOfModulo)
        Me.VarCollector.Variables.Add(Me.GantryOffset)
        Me.VarCollector.Variables.Add(Me.DetectionSensorFree)
        Me.VarCollector.Variables.Add(Me.SheetSize)
        '
        'mxAutoMode
        '
        Me.mxAutoMode.BindControl = Nothing
        Me.mxAutoMode.BindProperty = "Data"
        Me.mxAutoMode.Data = Nothing
        Me.mxAutoMode.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.mxAutoMode.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.mxAutoMode.VariableName = "Main.mxAutomode"
        '
        'ConManVelo
        '
        Me.ConManVelo.BindControl = Me.IO_ConManVelo
        Me.ConManVelo.BindProperty = "Data"
        Me.ConManVelo.Data = Nothing
        Me.ConManVelo.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.ConManVelo.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ConManVelo.VariableName = "MAIN.Conveyor.MachParameters.VelocityManual"
        '
        'IO_ConManVelo
        '
        Me.IO_ConManVelo.Audit = Nothing
        Me.IO_ConManVelo.AuditEnabled = False
        Me.IO_ConManVelo.AuditMessage = "KremerIoField changed:"
        Me.IO_ConManVelo.AuditSource = "KremerIoField"
        Me.IO_ConManVelo.BackColor = System.Drawing.Color.White
        Me.IO_ConManVelo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_ConManVelo.Data = 0.0R
        Me.IO_ConManVelo.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_ConManVelo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_ConManVelo.InitialValue = True
        Me.IO_ConManVelo.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_ConManVelo.Location = New System.Drawing.Point(272, 39)
        Me.IO_ConManVelo.LowerBound = -5000.0R
        Me.IO_ConManVelo.Name = "IO_ConManVelo"
        Me.IO_ConManVelo.OutputFormat = "0.0 mm/s"
        Me.IO_ConManVelo.Size = New System.Drawing.Size(100, 22)
        Me.IO_ConManVelo.TabIndex = 397
        Me.IO_ConManVelo.Text = "0.0 mm/s"
        Me.IO_ConManVelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_ConManVelo.UpperBound = 5000.0R
        Me.IO_ConManVelo.UserInfo = Nothing
        Me.IO_ConManVelo.UserLevel = 0
        '
        'StartSpeed
        '
        Me.StartSpeed.BindControl = Me.IO_startSpeed
        Me.StartSpeed.BindProperty = "Data"
        Me.StartSpeed.Data = Nothing
        Me.StartSpeed.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.StartSpeed.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StartSpeed.VariableName = "MAIN.Conveyor.MachParameters.VelocityAuto"
        '
        'IO_startSpeed
        '
        Me.IO_startSpeed.Audit = Nothing
        Me.IO_startSpeed.AuditEnabled = False
        Me.IO_startSpeed.AuditMessage = "KremerIoField changed:"
        Me.IO_startSpeed.AuditSource = "KremerIoField"
        Me.IO_startSpeed.BackColor = System.Drawing.Color.White
        Me.IO_startSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_startSpeed.Data = 0.0R
        Me.IO_startSpeed.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_startSpeed.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_startSpeed.InitialValue = True
        Me.IO_startSpeed.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_startSpeed.Location = New System.Drawing.Point(272, 295)
        Me.IO_startSpeed.LowerBound = 1.0R
        Me.IO_startSpeed.Name = "IO_startSpeed"
        Me.IO_startSpeed.OutputFormat = "0.0 KO"
        Me.IO_startSpeed.Size = New System.Drawing.Size(100, 22)
        Me.IO_startSpeed.TabIndex = 413
        Me.IO_startSpeed.Text = "0.0 KO"
        Me.IO_startSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_startSpeed.UpperBound = 20.0R
        Me.IO_startSpeed.UserInfo = Nothing
        Me.IO_startSpeed.UserLevel = 0
        '
        'EnableIMD1
        '
        Me.EnableIMD1.BindControl = Me.BTN_EnableIMD1
        Me.EnableIMD1.BindProperty = "Data"
        Me.EnableIMD1.Data = Nothing
        Me.EnableIMD1.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.EnableIMD1.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.EnableIMD1.VariableName = "MAIN.Conveyor.MachParameters.IMD1_Enabled"
        '
        'BTN_EnableIMD1
        '
        Me.BTN_EnableIMD1.Audit = Nothing
        Me.BTN_EnableIMD1.AuditEnabled = False
        Me.BTN_EnableIMD1.AuditMessage = "KremerPushButton pressed!"
        Me.BTN_EnableIMD1.AuditSource = "KremerPushButton"
        Me.BTN_EnableIMD1.BackColorOn = System.Drawing.Color.Blue
        Me.BTN_EnableIMD1.BackGroundImageOn = Nothing
        Me.BTN_EnableIMD1.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.BTN_EnableIMD1.Data = False
        Me.BTN_EnableIMD1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_EnableIMD1.ForeColorOn = System.Drawing.Color.Yellow
        Me.BTN_EnableIMD1.Location = New System.Drawing.Point(672, 204)
        Me.BTN_EnableIMD1.Name = "BTN_EnableIMD1"
        Me.BTN_EnableIMD1.Size = New System.Drawing.Size(100, 23)
        Me.BTN_EnableIMD1.State = False
        Me.BTN_EnableIMD1.StateIsData = True
        Me.BTN_EnableIMD1.StateText = New String() {Nothing, Nothing}
        Me.BTN_EnableIMD1.TabIndex = 442
        Me.BTN_EnableIMD1.Tag = "64"
        Me.BTN_EnableIMD1.Text = "Enable"
        Me.BTN_EnableIMD1.UserInfo = Nothing
        Me.BTN_EnableIMD1.UserLevel = 0
        Me.BTN_EnableIMD1.UseStateText = False
        Me.BTN_EnableIMD1.UseVisualStyleBackColor = True
        '
        'EnableIMD2
        '
        Me.EnableIMD2.BindControl = Me.BTN_EnableIMD2
        Me.EnableIMD2.BindProperty = "Data"
        Me.EnableIMD2.Data = Nothing
        Me.EnableIMD2.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.EnableIMD2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.EnableIMD2.VariableName = "MAIN.Conveyor.MachParameters.IMD2_Enabled"
        '
        'BTN_EnableIMD2
        '
        Me.BTN_EnableIMD2.Audit = Nothing
        Me.BTN_EnableIMD2.AuditEnabled = False
        Me.BTN_EnableIMD2.AuditMessage = "KremerPushButton pressed!"
        Me.BTN_EnableIMD2.AuditSource = "KremerPushButton"
        Me.BTN_EnableIMD2.BackColorOn = System.Drawing.Color.Blue
        Me.BTN_EnableIMD2.BackGroundImageOn = Nothing
        Me.BTN_EnableIMD2.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.BTN_EnableIMD2.Data = False
        Me.BTN_EnableIMD2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_EnableIMD2.ForeColorOn = System.Drawing.Color.Yellow
        Me.BTN_EnableIMD2.Location = New System.Drawing.Point(672, 227)
        Me.BTN_EnableIMD2.Name = "BTN_EnableIMD2"
        Me.BTN_EnableIMD2.Size = New System.Drawing.Size(100, 23)
        Me.BTN_EnableIMD2.State = False
        Me.BTN_EnableIMD2.StateIsData = True
        Me.BTN_EnableIMD2.StateText = New String() {Nothing, Nothing}
        Me.BTN_EnableIMD2.TabIndex = 445
        Me.BTN_EnableIMD2.Tag = "64"
        Me.BTN_EnableIMD2.Text = "Enable"
        Me.BTN_EnableIMD2.UserInfo = Nothing
        Me.BTN_EnableIMD2.UserLevel = 0
        Me.BTN_EnableIMD2.UseStateText = False
        Me.BTN_EnableIMD2.UseVisualStyleBackColor = True
        '
        'Modulo
        '
        Me.Modulo.BindControl = Me.IO_Modulo
        Me.Modulo.BindProperty = "Data"
        Me.Modulo.Data = Nothing
        Me.Modulo.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.Modulo.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Modulo.VariableName = "MAIN.ProdPar.Conveyor.BlowOff_Prod.Modulo"
        '
        'IO_Modulo
        '
        Me.IO_Modulo.Audit = Nothing
        Me.IO_Modulo.AuditEnabled = False
        Me.IO_Modulo.AuditMessage = "KremerIoField changed:"
        Me.IO_Modulo.AuditSource = "KremerIoField"
        Me.IO_Modulo.BackColor = System.Drawing.Color.White
        Me.IO_Modulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_Modulo.Data = 0.0R
        Me.IO_Modulo.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_Modulo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_Modulo.InitialValue = True
        Me.IO_Modulo.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_Modulo.Location = New System.Drawing.Point(272, 62)
        Me.IO_Modulo.LowerBound = -5000.0R
        Me.IO_Modulo.Name = "IO_Modulo"
        Me.IO_Modulo.OutputFormat = "0.0 mm"
        Me.IO_Modulo.Size = New System.Drawing.Size(100, 22)
        Me.IO_Modulo.TabIndex = 402
        Me.IO_Modulo.Text = "0.0 mm"
        Me.IO_Modulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_Modulo.UpperBound = 5000.0R
        Me.IO_Modulo.UserInfo = Nothing
        Me.IO_Modulo.UserLevel = 0
        '
        'SpeedKO_FTL
        '
        Me.SpeedKO_FTL.BindControl = Me.IO_SpeedFTL
        Me.SpeedKO_FTL.BindProperty = "Data"
        Me.SpeedKO_FTL.Data = Nothing
        Me.SpeedKO_FTL.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.SpeedKO_FTL.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SpeedKO_FTL.VariableName = "MAIN.ComSpeedControl_FTL.FTL_SpeedControl.MaximumSpeed"
        '
        'IO_SpeedFTL
        '
        Me.IO_SpeedFTL.Audit = Nothing
        Me.IO_SpeedFTL.AuditEnabled = False
        Me.IO_SpeedFTL.AuditMessage = "KremerIoField changed:"
        Me.IO_SpeedFTL.AuditSource = "KremerIoField"
        Me.IO_SpeedFTL.BackColor = System.Drawing.Color.White
        Me.IO_SpeedFTL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_SpeedFTL.Data = 0.0R
        Me.IO_SpeedFTL.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_SpeedFTL.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_SpeedFTL.InitialValue = True
        Me.IO_SpeedFTL.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_SpeedFTL.Location = New System.Drawing.Point(272, 85)
        Me.IO_SpeedFTL.LowerBound = -5000.0R
        Me.IO_SpeedFTL.Name = "IO_SpeedFTL"
        Me.IO_SpeedFTL.OutputFormat = "0.0 Sh/m"
        Me.IO_SpeedFTL.Size = New System.Drawing.Size(100, 22)
        Me.IO_SpeedFTL.TabIndex = 419
        Me.IO_SpeedFTL.Text = "0.0 Sh/m"
        Me.IO_SpeedFTL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_SpeedFTL.UpperBound = 5000.0R
        Me.IO_SpeedFTL.UserInfo = Nothing
        Me.IO_SpeedFTL.UserLevel = 0
        '
        'NrOfSheets
        '
        Me.NrOfSheets.BindControl = Me.IO_nrOfSheets
        Me.NrOfSheets.BindProperty = "Data"
        Me.NrOfSheets.Data = Nothing
        Me.NrOfSheets.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.NrOfSheets.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.NrOfSheets.VariableName = "MAIN.ProdPar.Conveyor.BlowOff_Prod.NrOfSheets"
        '
        'IO_nrOfSheets
        '
        Me.IO_nrOfSheets.Audit = Nothing
        Me.IO_nrOfSheets.AuditEnabled = False
        Me.IO_nrOfSheets.AuditMessage = "KremerIoField changed:"
        Me.IO_nrOfSheets.AuditSource = "KremerIoField"
        Me.IO_nrOfSheets.BackColor = System.Drawing.Color.White
        Me.IO_nrOfSheets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_nrOfSheets.Data = 0.0R
        Me.IO_nrOfSheets.DataType = KremerControlsWin32.KremerIoField.NumDataType.DINT
        Me.IO_nrOfSheets.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_nrOfSheets.InitialValue = True
        Me.IO_nrOfSheets.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_nrOfSheets.Location = New System.Drawing.Point(272, 204)
        Me.IO_nrOfSheets.LowerBound = 1.0R
        Me.IO_nrOfSheets.Name = "IO_nrOfSheets"
        Me.IO_nrOfSheets.OutputFormat = "0"
        Me.IO_nrOfSheets.Size = New System.Drawing.Size(100, 22)
        Me.IO_nrOfSheets.TabIndex = 404
        Me.IO_nrOfSheets.Text = "0"
        Me.IO_nrOfSheets.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_nrOfSheets.UpperBound = 4.0R
        Me.IO_nrOfSheets.UserInfo = Nothing
        Me.IO_nrOfSheets.UserLevel = 0
        '
        'PitchGantry
        '
        Me.PitchGantry.BindControl = Me.IO_GantryPitch
        Me.PitchGantry.BindProperty = "Data"
        Me.PitchGantry.Data = Nothing
        Me.PitchGantry.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.PitchGantry.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PitchGantry.VariableName = "MAIN.ProdPar.Conveyor.BlowOff_Prod.PitchGantry"
        '
        'IO_GantryPitch
        '
        Me.IO_GantryPitch.Audit = Nothing
        Me.IO_GantryPitch.AuditEnabled = False
        Me.IO_GantryPitch.AuditMessage = "KremerIoField changed:"
        Me.IO_GantryPitch.AuditSource = "KremerIoField"
        Me.IO_GantryPitch.BackColor = System.Drawing.Color.White
        Me.IO_GantryPitch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_GantryPitch.Data = 0.0R
        Me.IO_GantryPitch.DataType = KremerControlsWin32.KremerIoField.NumDataType.DINT
        Me.IO_GantryPitch.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_GantryPitch.InitialValue = True
        Me.IO_GantryPitch.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_GantryPitch.Location = New System.Drawing.Point(272, 227)
        Me.IO_GantryPitch.LowerBound = 0.0R
        Me.IO_GantryPitch.Name = "IO_GantryPitch"
        Me.IO_GantryPitch.OutputFormat = "0 mm"
        Me.IO_GantryPitch.Size = New System.Drawing.Size(100, 22)
        Me.IO_GantryPitch.TabIndex = 405
        Me.IO_GantryPitch.Text = "0 mm"
        Me.IO_GantryPitch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_GantryPitch.UpperBound = 5000.0R
        Me.IO_GantryPitch.UserInfo = Nothing
        Me.IO_GantryPitch.UserLevel = 0
        '
        'RampNrOfModulo
        '
        Me.RampNrOfModulo.BindControl = Me.IO_RampNrModulo
        Me.RampNrOfModulo.BindProperty = "Data"
        Me.RampNrOfModulo.Data = Nothing
        Me.RampNrOfModulo.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.RampNrOfModulo.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.RampNrOfModulo.VariableName = "MAIN.Conveyor.MachParameters.ModuloRamp"
        '
        'IO_RampNrModulo
        '
        Me.IO_RampNrModulo.Audit = Nothing
        Me.IO_RampNrModulo.AuditEnabled = False
        Me.IO_RampNrModulo.AuditMessage = "KremerIoField changed:"
        Me.IO_RampNrModulo.AuditSource = "KremerIoField"
        Me.IO_RampNrModulo.BackColor = System.Drawing.Color.White
        Me.IO_RampNrModulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_RampNrModulo.Data = 0.0R
        Me.IO_RampNrModulo.DataType = KremerControlsWin32.KremerIoField.NumDataType.DINT
        Me.IO_RampNrModulo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_RampNrModulo.InitialValue = True
        Me.IO_RampNrModulo.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_RampNrModulo.Location = New System.Drawing.Point(272, 273)
        Me.IO_RampNrModulo.LowerBound = 1.0R
        Me.IO_RampNrModulo.Name = "IO_RampNrModulo"
        Me.IO_RampNrModulo.OutputFormat = "0"
        Me.IO_RampNrModulo.Size = New System.Drawing.Size(100, 22)
        Me.IO_RampNrModulo.TabIndex = 406
        Me.IO_RampNrModulo.Text = "0"
        Me.IO_RampNrModulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_RampNrModulo.UpperBound = 20.0R
        Me.IO_RampNrModulo.UserInfo = Nothing
        Me.IO_RampNrModulo.UserLevel = 0
        '
        'GantryOffset
        '
        Me.GantryOffset.BindControl = Me.IO_SensorAoffset
        Me.GantryOffset.BindProperty = "Data"
        Me.GantryOffset.Data = Nothing
        Me.GantryOffset.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.GantryOffset.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GantryOffset.VariableName = "MAIN.ProdPar.Conveyor.BlowOff_Prod.ModuloOffsetSensorFree"
        '
        'IO_SensorAoffset
        '
        Me.IO_SensorAoffset.Audit = Nothing
        Me.IO_SensorAoffset.AuditEnabled = False
        Me.IO_SensorAoffset.AuditMessage = "KremerIoField changed:"
        Me.IO_SensorAoffset.AuditSource = "KremerIoField"
        Me.IO_SensorAoffset.BackColor = System.Drawing.Color.White
        Me.IO_SensorAoffset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_SensorAoffset.Data = 0.0R
        Me.IO_SensorAoffset.DataType = KremerControlsWin32.KremerIoField.NumDataType.DINT
        Me.IO_SensorAoffset.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_SensorAoffset.InitialValue = True
        Me.IO_SensorAoffset.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_SensorAoffset.Location = New System.Drawing.Point(667, 38)
        Me.IO_SensorAoffset.LowerBound = 0.0R
        Me.IO_SensorAoffset.Name = "IO_SensorAoffset"
        Me.IO_SensorAoffset.OutputFormat = "0 mm"
        Me.IO_SensorAoffset.Size = New System.Drawing.Size(100, 22)
        Me.IO_SensorAoffset.TabIndex = 416
        Me.IO_SensorAoffset.Text = "0 mm"
        Me.IO_SensorAoffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_SensorAoffset.UpperBound = 2000.0R
        Me.IO_SensorAoffset.UserInfo = Nothing
        Me.IO_SensorAoffset.UserLevel = 0
        '
        'DetectionSensorFree
        '
        Me.DetectionSensorFree.BindControl = Me.IO_DetectionSensorActive
        Me.DetectionSensorFree.BindProperty = "Data"
        Me.DetectionSensorFree.Data = Nothing
        Me.DetectionSensorFree.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.DetectionSensorFree.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.DetectionSensorFree.VariableName = "MAIN.ProdPar.Conveyor.BlowOff_Prod.ModuloDetectionSensorFree"
        '
        'IO_DetectionSensorActive
        '
        Me.IO_DetectionSensorActive.Audit = Nothing
        Me.IO_DetectionSensorActive.AuditEnabled = False
        Me.IO_DetectionSensorActive.AuditMessage = "KremerIoField changed:"
        Me.IO_DetectionSensorActive.AuditSource = "KremerIoField"
        Me.IO_DetectionSensorActive.BackColor = System.Drawing.Color.White
        Me.IO_DetectionSensorActive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_DetectionSensorActive.Data = 0.0R
        Me.IO_DetectionSensorActive.DataType = KremerControlsWin32.KremerIoField.NumDataType.DINT
        Me.IO_DetectionSensorActive.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_DetectionSensorActive.InitialValue = True
        Me.IO_DetectionSensorActive.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_DetectionSensorActive.Location = New System.Drawing.Point(667, 62)
        Me.IO_DetectionSensorActive.LowerBound = 0.0R
        Me.IO_DetectionSensorActive.Name = "IO_DetectionSensorActive"
        Me.IO_DetectionSensorActive.OutputFormat = "0 mm"
        Me.IO_DetectionSensorActive.Size = New System.Drawing.Size(100, 22)
        Me.IO_DetectionSensorActive.TabIndex = 447
        Me.IO_DetectionSensorActive.Text = "0 mm"
        Me.IO_DetectionSensorActive.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_DetectionSensorActive.UpperBound = 1000.0R
        Me.IO_DetectionSensorActive.UserInfo = Nothing
        Me.IO_DetectionSensorActive.UserLevel = 0
        '
        'SheetSize
        '
        Me.SheetSize.BindControl = Me.IO_SheetSize
        Me.SheetSize.BindProperty = "Data"
        Me.SheetSize.Data = Nothing
        Me.SheetSize.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.SheetSize.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SheetSize.VariableName = "MAIN.ProdPar.Conveyor.BlowOff_Prod.SheetSize"
        '
        'IO_SheetSize
        '
        Me.IO_SheetSize.Audit = Nothing
        Me.IO_SheetSize.AuditEnabled = False
        Me.IO_SheetSize.AuditMessage = "KremerIoField changed:"
        Me.IO_SheetSize.AuditSource = "KremerIoField"
        Me.IO_SheetSize.BackColor = System.Drawing.Color.White
        Me.IO_SheetSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_SheetSize.Data = 0.0R
        Me.IO_SheetSize.DataType = KremerControlsWin32.KremerIoField.NumDataType.DINT
        Me.IO_SheetSize.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_SheetSize.InitialValue = True
        Me.IO_SheetSize.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_SheetSize.Location = New System.Drawing.Point(272, 250)
        Me.IO_SheetSize.LowerBound = 0.0R
        Me.IO_SheetSize.Name = "IO_SheetSize"
        Me.IO_SheetSize.OutputFormat = "0 mm"
        Me.IO_SheetSize.Size = New System.Drawing.Size(100, 22)
        Me.IO_SheetSize.TabIndex = 449
        Me.IO_SheetSize.Text = "0 mm"
        Me.IO_SheetSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_SheetSize.UpperBound = 5000.0R
        Me.IO_SheetSize.UserInfo = Nothing
        Me.IO_SheetSize.UserLevel = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(19, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 23)
        Me.Label2.TabIndex = 372
        Me.Label2.Tag = ""
        Me.Label2.Text = "Speed Control Belt Settings"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 23)
        Me.Label1.TabIndex = 396
        Me.Label1.Tag = "107"
        Me.Label1.Text = "Manual velocity"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(244, 23)
        Me.Label3.TabIndex = 403
        Me.Label3.Tag = ""
        Me.Label3.Text = "Modulo"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(19, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(273, 23)
        Me.Label4.TabIndex = 407
        Me.Label4.Tag = ""
        Me.Label4.Text = "Speed Control parameters"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(244, 23)
        Me.Label5.TabIndex = 408
        Me.Label5.Tag = ""
        Me.Label5.Text = "Number of sheets"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(244, 23)
        Me.Label6.TabIndex = 409
        Me.Label6.Tag = ""
        Me.Label6.Text = "Gantry Pitch"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(244, 23)
        Me.Label7.TabIndex = 410
        Me.Label7.Tag = ""
        Me.Label7.Text = "Ramp, number of modulo's"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 294)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(244, 23)
        Me.Label9.TabIndex = 414
        Me.Label9.Tag = ""
        Me.Label9.Text = "Start speed"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(399, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(273, 23)
        Me.Label10.TabIndex = 415
        Me.Label10.Tag = ""
        Me.Label10.Text = "Speed Control parameters"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(400, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(257, 23)
        Me.Label12.TabIndex = 418
        Me.Label12.Tag = ""
        Me.Label12.Text = "Gantry A modulo offset sensor"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(244, 23)
        Me.Label8.TabIndex = 420
        Me.Label8.Tag = ""
        Me.Label8.Text = "Speed Sheets/min FTL"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(400, 203)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(247, 23)
        Me.Label14.TabIndex = 443
        Me.Label14.Tag = ""
        Me.Label14.Text = "IMD1"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(399, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(273, 23)
        Me.Label13.TabIndex = 444
        Me.Label13.Tag = ""
        Me.Label13.Text = "Enable IMD's"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(400, 226)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(247, 23)
        Me.Label11.TabIndex = 446
        Me.Label11.Tag = ""
        Me.Label11.Text = "IMD2"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(400, 61)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(257, 23)
        Me.Label15.TabIndex = 448
        Me.Label15.Tag = ""
        Me.Label15.Text = "Detection sensor active skip"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(22, 249)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(244, 23)
        Me.Label16.TabIndex = 450
        Me.Label16.Tag = ""
        Me.Label16.Text = "Sheet Size"
        '
        'SpeedControl_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.IO_SheetSize)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.IO_DetectionSensorActive)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BTN_EnableIMD2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.BTN_EnableIMD1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.IO_SpeedFTL)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.IO_SensorAoffset)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.IO_startSpeed)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.IO_RampNrModulo)
        Me.Controls.Add(Me.IO_GantryPitch)
        Me.Controls.Add(Me.IO_nrOfSheets)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IO_Modulo)
        Me.Controls.Add(Me.IO_ConManVelo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Controls.Add(Me.Btn_Manual)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "SpeedControl_Settings"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "117"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_Manual As KremerControlsWin32.KremerButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents LineShape10 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape9 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ConManVelo As KremerControlsWin32.KremerVariable
    Friend WithEvents StartSpeed As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_ConManVelo As KremerControlsWin32.KremerIoField
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mxAutoMode As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_Modulo As KremerControlsWin32.KremerIoField
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents IO_RampNrModulo As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_GantryPitch As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_nrOfSheets As KremerControlsWin32.KremerIoField
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents IO_startSpeed As KremerControlsWin32.KremerIoField
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents IO_SensorAoffset As KremerControlsWin32.KremerIoField
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents IO_SpeedFTL As KremerControlsWin32.KremerIoField
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents BTN_EnableIMD1 As KremerControlsWin32.KremerButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BTN_EnableIMD2 As KremerControlsWin32.KremerButton
    Friend WithEvents EnableIMD1 As KremerControlsWin32.KremerVariable
    Friend WithEvents EnableIMD2 As KremerControlsWin32.KremerVariable
    Friend WithEvents Modulo As KremerControlsWin32.KremerVariable
    Friend WithEvents SpeedKO_FTL As KremerControlsWin32.KremerVariable
    Friend WithEvents NrOfSheets As KremerControlsWin32.KremerVariable
    Friend WithEvents PitchGantry As KremerControlsWin32.KremerVariable
    Friend WithEvents GantryOffset As KremerControlsWin32.KremerVariable
    Friend WithEvents RampNrOfModulo As KremerControlsWin32.KremerVariable
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents IO_DetectionSensorActive As KremerControlsWin32.KremerIoField
    Friend WithEvents DetectionSensorFree As KremerControlsWin32.KremerVariable
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents IO_SheetSize As KremerControlsWin32.KremerIoField
    Friend WithEvents SheetSize As KremerControlsWin32.KremerVariable

End Class
