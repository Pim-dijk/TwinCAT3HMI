<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DryingMoldSettings2
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
        Me.SpeedUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_SpeedUp = New KremerControlsWin32.KremerIoField(Me.components)
        Me.SpeedUpSlow = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_SpeedUpSlow = New KremerControlsWin32.KremerIoField(Me.components)
        Me.SpeedUpCreep = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_SpeedUpCreep = New KremerControlsWin32.KremerIoField(Me.components)
        Me.SpeedDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_SpeedDown = New KremerControlsWin32.KremerIoField(Me.components)
        Me.SpeedDownSlow = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_SpeedDownSlow = New KremerControlsWin32.KremerIoField(Me.components)
        Me.SpeedDownCreep = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_SpeedDownCreep = New KremerControlsWin32.KremerIoField(Me.components)
        Me.SpeedOpen = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_SpeedOpen = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PressingSpeed = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_SpeedDownLock = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PressingPressure = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_PressingStoppingPress = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ManVelo = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_BMManualVelo = New KremerControlsWin32.KremerIoField(Me.components)
        Me.AutoVelo = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_BMAutoVelo = New KremerControlsWin32.KremerIoField(Me.components)
        Me.InitVelo = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_BMInitVelocity = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Btn_Overview = New KremerControlsWin32.KremerButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape10 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Settings = New System.Windows.Forms.Button()
        Me.Btn_Settings2 = New System.Windows.Forms.Button()
        Me.Btn_Manual = New KremerControlsWin32.KremerButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.IO_BotSidePressAlm = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.IO_RodSidePressAlm = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label17 = New System.Windows.Forms.Label()
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
        Me.VarCollector.Variables.Add(Me.SpeedUp)
        Me.VarCollector.Variables.Add(Me.SpeedUpSlow)
        Me.VarCollector.Variables.Add(Me.SpeedUpCreep)
        Me.VarCollector.Variables.Add(Me.SpeedDown)
        Me.VarCollector.Variables.Add(Me.SpeedDownSlow)
        Me.VarCollector.Variables.Add(Me.SpeedDownCreep)
        Me.VarCollector.Variables.Add(Me.SpeedOpen)
        Me.VarCollector.Variables.Add(Me.PressingSpeed)
        Me.VarCollector.Variables.Add(Me.PressingPressure)
        Me.VarCollector.Variables.Add(Me.ManVelo)
        Me.VarCollector.Variables.Add(Me.AutoVelo)
        Me.VarCollector.Variables.Add(Me.InitVelo)
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
        'SpeedUp
        '
        Me.SpeedUp.BindControl = Me.IO_SpeedUp
        Me.SpeedUp.BindProperty = "Data"
        Me.SpeedUp.Data = Nothing
        Me.SpeedUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.SpeedUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SpeedUp.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].SpeedUpNormal"
        '
        'IO_SpeedUp
        '
        Me.IO_SpeedUp.Audit = Nothing
        Me.IO_SpeedUp.AuditEnabled = False
        Me.IO_SpeedUp.AuditMessage = "KremerIoField changed:"
        Me.IO_SpeedUp.AuditSource = "KremerIoField"
        Me.IO_SpeedUp.BackColor = System.Drawing.Color.White
        Me.IO_SpeedUp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_SpeedUp.Data = 0.0R
        Me.IO_SpeedUp.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_SpeedUp.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_SpeedUp.InitialValue = True
        Me.IO_SpeedUp.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_SpeedUp.Location = New System.Drawing.Point(279, 35)
        Me.IO_SpeedUp.LowerBound = -10000.0R
        Me.IO_SpeedUp.Name = "IO_SpeedUp"
        Me.IO_SpeedUp.OutputFormat = "0.0 '%'"
        Me.IO_SpeedUp.Size = New System.Drawing.Size(100, 22)
        Me.IO_SpeedUp.TabIndex = 406
        Me.IO_SpeedUp.Text = "0.0 %"
        Me.IO_SpeedUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_SpeedUp.UpperBound = 10000.0R
        Me.IO_SpeedUp.UserInfo = Nothing
        Me.IO_SpeedUp.UserLevel = 0
        '
        'SpeedUpSlow
        '
        Me.SpeedUpSlow.BindControl = Me.IO_SpeedUpSlow
        Me.SpeedUpSlow.BindProperty = "Data"
        Me.SpeedUpSlow.Data = Nothing
        Me.SpeedUpSlow.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.SpeedUpSlow.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SpeedUpSlow.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].SpeedUpSlow"
        '
        'IO_SpeedUpSlow
        '
        Me.IO_SpeedUpSlow.Audit = Nothing
        Me.IO_SpeedUpSlow.AuditEnabled = False
        Me.IO_SpeedUpSlow.AuditMessage = "KremerIoField changed:"
        Me.IO_SpeedUpSlow.AuditSource = "KremerIoField"
        Me.IO_SpeedUpSlow.BackColor = System.Drawing.Color.White
        Me.IO_SpeedUpSlow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_SpeedUpSlow.Data = 0.0R
        Me.IO_SpeedUpSlow.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_SpeedUpSlow.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_SpeedUpSlow.InitialValue = True
        Me.IO_SpeedUpSlow.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_SpeedUpSlow.Location = New System.Drawing.Point(279, 58)
        Me.IO_SpeedUpSlow.LowerBound = -10000.0R
        Me.IO_SpeedUpSlow.Name = "IO_SpeedUpSlow"
        Me.IO_SpeedUpSlow.OutputFormat = "0.0 '%'"
        Me.IO_SpeedUpSlow.Size = New System.Drawing.Size(100, 22)
        Me.IO_SpeedUpSlow.TabIndex = 407
        Me.IO_SpeedUpSlow.Text = "0.0 %"
        Me.IO_SpeedUpSlow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_SpeedUpSlow.UpperBound = 10000.0R
        Me.IO_SpeedUpSlow.UserInfo = Nothing
        Me.IO_SpeedUpSlow.UserLevel = 0
        '
        'SpeedUpCreep
        '
        Me.SpeedUpCreep.BindControl = Me.IO_SpeedUpCreep
        Me.SpeedUpCreep.BindProperty = "Data"
        Me.SpeedUpCreep.Data = Nothing
        Me.SpeedUpCreep.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.SpeedUpCreep.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SpeedUpCreep.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].SpeedUpCreep"
        '
        'IO_SpeedUpCreep
        '
        Me.IO_SpeedUpCreep.Audit = Nothing
        Me.IO_SpeedUpCreep.AuditEnabled = False
        Me.IO_SpeedUpCreep.AuditMessage = "KremerIoField changed:"
        Me.IO_SpeedUpCreep.AuditSource = "KremerIoField"
        Me.IO_SpeedUpCreep.BackColor = System.Drawing.Color.White
        Me.IO_SpeedUpCreep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_SpeedUpCreep.Data = 0.0R
        Me.IO_SpeedUpCreep.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_SpeedUpCreep.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_SpeedUpCreep.InitialValue = True
        Me.IO_SpeedUpCreep.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_SpeedUpCreep.Location = New System.Drawing.Point(279, 81)
        Me.IO_SpeedUpCreep.LowerBound = -10000.0R
        Me.IO_SpeedUpCreep.Name = "IO_SpeedUpCreep"
        Me.IO_SpeedUpCreep.OutputFormat = "0.0 '%'"
        Me.IO_SpeedUpCreep.Size = New System.Drawing.Size(100, 22)
        Me.IO_SpeedUpCreep.TabIndex = 413
        Me.IO_SpeedUpCreep.Text = "0.0 %"
        Me.IO_SpeedUpCreep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_SpeedUpCreep.UpperBound = 10000.0R
        Me.IO_SpeedUpCreep.UserInfo = Nothing
        Me.IO_SpeedUpCreep.UserLevel = 0
        '
        'SpeedDown
        '
        Me.SpeedDown.BindControl = Me.IO_SpeedDown
        Me.SpeedDown.BindProperty = "Data"
        Me.SpeedDown.Data = Nothing
        Me.SpeedDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.SpeedDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SpeedDown.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].SpeedDownNormal"
        '
        'IO_SpeedDown
        '
        Me.IO_SpeedDown.Audit = Nothing
        Me.IO_SpeedDown.AuditEnabled = False
        Me.IO_SpeedDown.AuditMessage = "KremerIoField changed:"
        Me.IO_SpeedDown.AuditSource = "KremerIoField"
        Me.IO_SpeedDown.BackColor = System.Drawing.Color.White
        Me.IO_SpeedDown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_SpeedDown.Data = 0.0R
        Me.IO_SpeedDown.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_SpeedDown.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_SpeedDown.InitialValue = True
        Me.IO_SpeedDown.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_SpeedDown.Location = New System.Drawing.Point(279, 126)
        Me.IO_SpeedDown.LowerBound = -10000.0R
        Me.IO_SpeedDown.Name = "IO_SpeedDown"
        Me.IO_SpeedDown.OutputFormat = "0.0 '%'"
        Me.IO_SpeedDown.Size = New System.Drawing.Size(100, 22)
        Me.IO_SpeedDown.TabIndex = 408
        Me.IO_SpeedDown.Text = "0.0 %"
        Me.IO_SpeedDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_SpeedDown.UpperBound = 10000.0R
        Me.IO_SpeedDown.UserInfo = Nothing
        Me.IO_SpeedDown.UserLevel = 0
        '
        'SpeedDownSlow
        '
        Me.SpeedDownSlow.BindControl = Me.IO_SpeedDownSlow
        Me.SpeedDownSlow.BindProperty = "Data"
        Me.SpeedDownSlow.Data = Nothing
        Me.SpeedDownSlow.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.SpeedDownSlow.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SpeedDownSlow.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].SpeedDownSlow"
        '
        'IO_SpeedDownSlow
        '
        Me.IO_SpeedDownSlow.Audit = Nothing
        Me.IO_SpeedDownSlow.AuditEnabled = False
        Me.IO_SpeedDownSlow.AuditMessage = "KremerIoField changed:"
        Me.IO_SpeedDownSlow.AuditSource = "KremerIoField"
        Me.IO_SpeedDownSlow.BackColor = System.Drawing.Color.White
        Me.IO_SpeedDownSlow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_SpeedDownSlow.Data = 0.0R
        Me.IO_SpeedDownSlow.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_SpeedDownSlow.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_SpeedDownSlow.InitialValue = True
        Me.IO_SpeedDownSlow.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_SpeedDownSlow.Location = New System.Drawing.Point(279, 150)
        Me.IO_SpeedDownSlow.LowerBound = -10000.0R
        Me.IO_SpeedDownSlow.Name = "IO_SpeedDownSlow"
        Me.IO_SpeedDownSlow.OutputFormat = "0.0 '%'"
        Me.IO_SpeedDownSlow.Size = New System.Drawing.Size(100, 22)
        Me.IO_SpeedDownSlow.TabIndex = 409
        Me.IO_SpeedDownSlow.Text = "0.0 %"
        Me.IO_SpeedDownSlow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_SpeedDownSlow.UpperBound = 10000.0R
        Me.IO_SpeedDownSlow.UserInfo = Nothing
        Me.IO_SpeedDownSlow.UserLevel = 0
        '
        'SpeedDownCreep
        '
        Me.SpeedDownCreep.BindControl = Me.IO_SpeedDownCreep
        Me.SpeedDownCreep.BindProperty = "Data"
        Me.SpeedDownCreep.Data = Nothing
        Me.SpeedDownCreep.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.SpeedDownCreep.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SpeedDownCreep.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].SpeedDownCreep"
        '
        'IO_SpeedDownCreep
        '
        Me.IO_SpeedDownCreep.Audit = Nothing
        Me.IO_SpeedDownCreep.AuditEnabled = False
        Me.IO_SpeedDownCreep.AuditMessage = "KremerIoField changed:"
        Me.IO_SpeedDownCreep.AuditSource = "KremerIoField"
        Me.IO_SpeedDownCreep.BackColor = System.Drawing.Color.White
        Me.IO_SpeedDownCreep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_SpeedDownCreep.Data = 0.0R
        Me.IO_SpeedDownCreep.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_SpeedDownCreep.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_SpeedDownCreep.InitialValue = True
        Me.IO_SpeedDownCreep.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_SpeedDownCreep.Location = New System.Drawing.Point(279, 173)
        Me.IO_SpeedDownCreep.LowerBound = -10000.0R
        Me.IO_SpeedDownCreep.Name = "IO_SpeedDownCreep"
        Me.IO_SpeedDownCreep.OutputFormat = "0.0 '%'"
        Me.IO_SpeedDownCreep.Size = New System.Drawing.Size(100, 22)
        Me.IO_SpeedDownCreep.TabIndex = 415
        Me.IO_SpeedDownCreep.Text = "0.0 %"
        Me.IO_SpeedDownCreep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_SpeedDownCreep.UpperBound = 10000.0R
        Me.IO_SpeedDownCreep.UserInfo = Nothing
        Me.IO_SpeedDownCreep.UserLevel = 0
        '
        'SpeedOpen
        '
        Me.SpeedOpen.BindControl = Me.IO_SpeedOpen
        Me.SpeedOpen.BindProperty = "Data"
        Me.SpeedOpen.Data = Nothing
        Me.SpeedOpen.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.SpeedOpen.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SpeedOpen.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].SpeedOpening"
        '
        'IO_SpeedOpen
        '
        Me.IO_SpeedOpen.Audit = Nothing
        Me.IO_SpeedOpen.AuditEnabled = False
        Me.IO_SpeedOpen.AuditMessage = "KremerIoField changed:"
        Me.IO_SpeedOpen.AuditSource = "KremerIoField"
        Me.IO_SpeedOpen.BackColor = System.Drawing.Color.White
        Me.IO_SpeedOpen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_SpeedOpen.Data = 0.0R
        Me.IO_SpeedOpen.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_SpeedOpen.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_SpeedOpen.InitialValue = True
        Me.IO_SpeedOpen.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_SpeedOpen.Location = New System.Drawing.Point(279, 103)
        Me.IO_SpeedOpen.LowerBound = -10000.0R
        Me.IO_SpeedOpen.Name = "IO_SpeedOpen"
        Me.IO_SpeedOpen.OutputFormat = "0.0 '%'"
        Me.IO_SpeedOpen.Size = New System.Drawing.Size(100, 22)
        Me.IO_SpeedOpen.TabIndex = 432
        Me.IO_SpeedOpen.Text = "0.0 %"
        Me.IO_SpeedOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_SpeedOpen.UpperBound = 10000.0R
        Me.IO_SpeedOpen.UserInfo = Nothing
        Me.IO_SpeedOpen.UserLevel = 0
        '
        'PressingSpeed
        '
        Me.PressingSpeed.BindControl = Me.IO_SpeedDownLock
        Me.PressingSpeed.BindProperty = "Data"
        Me.PressingSpeed.Data = Nothing
        Me.PressingSpeed.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.PressingSpeed.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PressingSpeed.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].PressSpeed"
        '
        'IO_SpeedDownLock
        '
        Me.IO_SpeedDownLock.Audit = Nothing
        Me.IO_SpeedDownLock.AuditEnabled = False
        Me.IO_SpeedDownLock.AuditMessage = "KremerIoField changed:"
        Me.IO_SpeedDownLock.AuditSource = "KremerIoField"
        Me.IO_SpeedDownLock.BackColor = System.Drawing.Color.White
        Me.IO_SpeedDownLock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_SpeedDownLock.Data = 0.0R
        Me.IO_SpeedDownLock.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_SpeedDownLock.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_SpeedDownLock.InitialValue = True
        Me.IO_SpeedDownLock.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_SpeedDownLock.Location = New System.Drawing.Point(279, 196)
        Me.IO_SpeedDownLock.LowerBound = -10000.0R
        Me.IO_SpeedDownLock.Name = "IO_SpeedDownLock"
        Me.IO_SpeedDownLock.OutputFormat = "0.0 '%'"
        Me.IO_SpeedDownLock.Size = New System.Drawing.Size(100, 22)
        Me.IO_SpeedDownLock.TabIndex = 410
        Me.IO_SpeedDownLock.Text = "0.0 %"
        Me.IO_SpeedDownLock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_SpeedDownLock.UpperBound = 10000.0R
        Me.IO_SpeedDownLock.UserInfo = Nothing
        Me.IO_SpeedDownLock.UserLevel = 0
        '
        'PressingPressure
        '
        Me.PressingPressure.BindControl = Me.IO_PressingStoppingPress
        Me.PressingPressure.BindProperty = "Data"
        Me.PressingPressure.Data = Nothing
        Me.PressingPressure.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.PressingPressure.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PressingPressure.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].PressStop"
        '
        'IO_PressingStoppingPress
        '
        Me.IO_PressingStoppingPress.Audit = Nothing
        Me.IO_PressingStoppingPress.AuditEnabled = False
        Me.IO_PressingStoppingPress.AuditMessage = "KremerIoField changed:"
        Me.IO_PressingStoppingPress.AuditSource = "KremerIoField"
        Me.IO_PressingStoppingPress.BackColor = System.Drawing.Color.White
        Me.IO_PressingStoppingPress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_PressingStoppingPress.Data = 0.0R
        Me.IO_PressingStoppingPress.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_PressingStoppingPress.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_PressingStoppingPress.InitialValue = True
        Me.IO_PressingStoppingPress.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_PressingStoppingPress.Location = New System.Drawing.Point(278, 261)
        Me.IO_PressingStoppingPress.LowerBound = -10000.0R
        Me.IO_PressingStoppingPress.Name = "IO_PressingStoppingPress"
        Me.IO_PressingStoppingPress.OutputFormat = "0 Bar"
        Me.IO_PressingStoppingPress.Size = New System.Drawing.Size(100, 22)
        Me.IO_PressingStoppingPress.TabIndex = 425
        Me.IO_PressingStoppingPress.Text = "0 Bar"
        Me.IO_PressingStoppingPress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_PressingStoppingPress.UpperBound = 10000.0R
        Me.IO_PressingStoppingPress.UserInfo = Nothing
        Me.IO_PressingStoppingPress.UserLevel = 0
        '
        'ManVelo
        '
        Me.ManVelo.BindControl = Me.IO_BMManualVelo
        Me.ManVelo.BindProperty = "Data"
        Me.ManVelo.Data = Nothing
        Me.ManVelo.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.ManVelo.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ManVelo.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].AxisVelocityManual"
        '
        'IO_BMManualVelo
        '
        Me.IO_BMManualVelo.Audit = Nothing
        Me.IO_BMManualVelo.AuditEnabled = False
        Me.IO_BMManualVelo.AuditMessage = "KremerIoField changed:"
        Me.IO_BMManualVelo.AuditSource = "KremerIoField"
        Me.IO_BMManualVelo.BackColor = System.Drawing.Color.White
        Me.IO_BMManualVelo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_BMManualVelo.Data = 0.0R
        Me.IO_BMManualVelo.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_BMManualVelo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_BMManualVelo.InitialValue = True
        Me.IO_BMManualVelo.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_BMManualVelo.Location = New System.Drawing.Point(666, 35)
        Me.IO_BMManualVelo.LowerBound = 0.0R
        Me.IO_BMManualVelo.Name = "IO_BMManualVelo"
        Me.IO_BMManualVelo.OutputFormat = "0.0 mm/s"
        Me.IO_BMManualVelo.Size = New System.Drawing.Size(100, 22)
        Me.IO_BMManualVelo.TabIndex = 417
        Me.IO_BMManualVelo.Text = "0.0 mm/s"
        Me.IO_BMManualVelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_BMManualVelo.UpperBound = 2000.0R
        Me.IO_BMManualVelo.UserInfo = Nothing
        Me.IO_BMManualVelo.UserLevel = 0
        '
        'AutoVelo
        '
        Me.AutoVelo.BindControl = Me.IO_BMAutoVelo
        Me.AutoVelo.BindProperty = "Data"
        Me.AutoVelo.Data = Nothing
        Me.AutoVelo.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.AutoVelo.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AutoVelo.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].AxisVelocityAuto"
        '
        'IO_BMAutoVelo
        '
        Me.IO_BMAutoVelo.Audit = Nothing
        Me.IO_BMAutoVelo.AuditEnabled = False
        Me.IO_BMAutoVelo.AuditMessage = "KremerIoField changed:"
        Me.IO_BMAutoVelo.AuditSource = "KremerIoField"
        Me.IO_BMAutoVelo.BackColor = System.Drawing.Color.White
        Me.IO_BMAutoVelo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_BMAutoVelo.Data = 0.0R
        Me.IO_BMAutoVelo.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_BMAutoVelo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_BMAutoVelo.InitialValue = True
        Me.IO_BMAutoVelo.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_BMAutoVelo.Location = New System.Drawing.Point(666, 59)
        Me.IO_BMAutoVelo.LowerBound = 0.0R
        Me.IO_BMAutoVelo.Name = "IO_BMAutoVelo"
        Me.IO_BMAutoVelo.OutputFormat = "0.0 mm/s"
        Me.IO_BMAutoVelo.Size = New System.Drawing.Size(100, 22)
        Me.IO_BMAutoVelo.TabIndex = 419
        Me.IO_BMAutoVelo.Text = "0.0 mm/s"
        Me.IO_BMAutoVelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_BMAutoVelo.UpperBound = 2000.0R
        Me.IO_BMAutoVelo.UserInfo = Nothing
        Me.IO_BMAutoVelo.UserLevel = 0
        '
        'InitVelo
        '
        Me.InitVelo.BindControl = Me.IO_BMInitVelocity
        Me.InitVelo.BindProperty = "Data"
        Me.InitVelo.Data = Nothing
        Me.InitVelo.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.InitVelo.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.InitVelo.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].AxisVelocityInit"
        '
        'IO_BMInitVelocity
        '
        Me.IO_BMInitVelocity.Audit = Nothing
        Me.IO_BMInitVelocity.AuditEnabled = False
        Me.IO_BMInitVelocity.AuditMessage = "KremerIoField changed:"
        Me.IO_BMInitVelocity.AuditSource = "KremerIoField"
        Me.IO_BMInitVelocity.BackColor = System.Drawing.Color.White
        Me.IO_BMInitVelocity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_BMInitVelocity.Data = 0.0R
        Me.IO_BMInitVelocity.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_BMInitVelocity.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_BMInitVelocity.InitialValue = True
        Me.IO_BMInitVelocity.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_BMInitVelocity.Location = New System.Drawing.Point(666, 83)
        Me.IO_BMInitVelocity.LowerBound = 0.0R
        Me.IO_BMInitVelocity.Name = "IO_BMInitVelocity"
        Me.IO_BMInitVelocity.OutputFormat = "0.0 mm/s"
        Me.IO_BMInitVelocity.Size = New System.Drawing.Size(100, 22)
        Me.IO_BMInitVelocity.TabIndex = 421
        Me.IO_BMInitVelocity.Text = "0.0 mm/s"
        Me.IO_BMInitVelocity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_BMInitVelocity.UpperBound = 2000.0R
        Me.IO_BMInitVelocity.UserInfo = Nothing
        Me.IO_BMInitVelocity.UserLevel = 0
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
        Me.Btn_Overview.Location = New System.Drawing.Point(685, 383)
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
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape9, Me.LineShape10, Me.LineShape4, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 435)
        Me.ShapeContainer1.TabIndex = 308
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 29
        Me.LineShape3.X2 = 379
        Me.LineShape3.Y1 = 256
        Me.LineShape3.Y2 = 256
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 274
        Me.LineShape2.X2 = 273
        Me.LineShape2.Y1 = 256
        Me.LineShape2.Y2 = 291
        '
        'LineShape9
        '
        Me.LineShape9.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape9.Name = "LineShape9"
        Me.LineShape9.X1 = 662
        Me.LineShape9.X2 = 662
        Me.LineShape9.Y1 = 32
        Me.LineShape9.Y2 = 112
        '
        'LineShape10
        '
        Me.LineShape10.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape10.Name = "LineShape10"
        Me.LineShape10.X1 = 417
        Me.LineShape10.X2 = 767
        Me.LineShape10.Y1 = 32
        Me.LineShape10.Y2 = 32
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 275
        Me.LineShape4.X2 = 274
        Me.LineShape4.Y1 = 32
        Me.LineShape4.Y2 = 201
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 30
        Me.LineShape1.X2 = 380
        Me.LineShape1.Y1 = 32
        Me.LineShape1.Y2 = 32
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Btn_Settings)
        Me.Panel1.Controls.Add(Me.Btn_Settings2)
        Me.Panel1.Location = New System.Drawing.Point(514, 329)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(165, 106)
        Me.Panel1.TabIndex = 390
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 23)
        Me.Label1.TabIndex = 257
        Me.Label1.Tag = "80"
        Me.Label1.Text = "More Settings"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_Settings
        '
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
        Me.Btn_Manual.Location = New System.Drawing.Point(685, 329)
        Me.Btn_Manual.Name = "Btn_Manual"
        Me.Btn_Manual.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Manual.State = False
        Me.Btn_Manual.StateIsData = True
        Me.Btn_Manual.StateText = New String() {Nothing, Nothing}
        Me.Btn_Manual.TabIndex = 391
        Me.Btn_Manual.Tag = "192"
        Me.Btn_Manual.Text = "Manual" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Control"
        Me.Btn_Manual.UserInfo = Nothing
        Me.Btn_Manual.UserLevel = 0
        Me.Btn_Manual.UseStateText = False
        Me.Btn_Manual.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 23)
        Me.Label4.TabIndex = 395
        Me.Label4.Tag = "245"
        Me.Label4.Text = "Speed down slow"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(247, 23)
        Me.Label6.TabIndex = 394
        Me.Label6.Tag = "244"
        Me.Label6.Text = "Speed down"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(247, 23)
        Me.Label7.TabIndex = 393
        Me.Label7.Tag = "242"
        Me.Label7.Text = "Speed up slow"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(247, 23)
        Me.Label9.TabIndex = 392
        Me.Label9.Tag = "241"
        Me.Label9.Text = "Speed up"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(27, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(352, 23)
        Me.Label10.TabIndex = 398
        Me.Label10.Tag = ""
        Me.Label10.Text = "Top mold Speed"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 23)
        Me.Label5.TabIndex = 412
        Me.Label5.Tag = "243"
        Me.Label5.Text = "Speed up creep"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 174)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(247, 23)
        Me.Label8.TabIndex = 414
        Me.Label8.Tag = "246"
        Me.Label8.Text = "Speed down creep"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(413, 6)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(273, 23)
        Me.Label20.TabIndex = 422
        Me.Label20.Tag = ""
        Me.Label20.Text = "Velocities Bottom mold"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(415, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(247, 23)
        Me.Label13.TabIndex = 420
        Me.Label13.Tag = "109"
        Me.Label13.Text = "Init Velocity"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(413, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 23)
        Me.Label2.TabIndex = 418
        Me.Label2.Tag = "108"
        Me.Label2.Text = "Automatic velocity"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(413, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(247, 23)
        Me.Label11.TabIndex = 416
        Me.Label11.Tag = "107"
        Me.Label11.Text = "Manual velocity"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 23)
        Me.Label3.TabIndex = 396
        Me.Label3.Tag = ""
        Me.Label3.Text = "Speed during press"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(24, 232)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(352, 23)
        Me.Label12.TabIndex = 423
        Me.Label12.Tag = "146"
        Me.Label12.Text = "Topmold pressures"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(23, 262)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(247, 23)
        Me.Label14.TabIndex = 424
        Me.Label14.Tag = "147"
        Me.Label14.Text = "Pressing stopping pressure"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(24, 307)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(247, 23)
        Me.Label15.TabIndex = 430
        Me.Label15.Tag = "230"
        Me.Label15.Text = "Max bot side pressure alarm"
        Me.Label15.Visible = False
        '
        'IO_BotSidePressAlm
        '
        Me.IO_BotSidePressAlm.Audit = Nothing
        Me.IO_BotSidePressAlm.AuditEnabled = False
        Me.IO_BotSidePressAlm.AuditMessage = "KremerIoField changed:"
        Me.IO_BotSidePressAlm.AuditSource = "KremerIoField"
        Me.IO_BotSidePressAlm.BackColor = System.Drawing.Color.White
        Me.IO_BotSidePressAlm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_BotSidePressAlm.Data = 0.0R
        Me.IO_BotSidePressAlm.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_BotSidePressAlm.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_BotSidePressAlm.InitialValue = True
        Me.IO_BotSidePressAlm.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_BotSidePressAlm.Location = New System.Drawing.Point(277, 307)
        Me.IO_BotSidePressAlm.LowerBound = -5000.0R
        Me.IO_BotSidePressAlm.Name = "IO_BotSidePressAlm"
        Me.IO_BotSidePressAlm.OutputFormat = "0 Bar"
        Me.IO_BotSidePressAlm.Size = New System.Drawing.Size(100, 22)
        Me.IO_BotSidePressAlm.TabIndex = 429
        Me.IO_BotSidePressAlm.Text = "0 Bar"
        Me.IO_BotSidePressAlm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_BotSidePressAlm.UpperBound = 5000.0R
        Me.IO_BotSidePressAlm.UserInfo = Nothing
        Me.IO_BotSidePressAlm.UserLevel = 0
        Me.IO_BotSidePressAlm.Visible = False
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(24, 284)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(247, 23)
        Me.Label16.TabIndex = 428
        Me.Label16.Tag = "229"
        Me.Label16.Text = "Max rod side pressure alarm"
        Me.Label16.Visible = False
        '
        'IO_RodSidePressAlm
        '
        Me.IO_RodSidePressAlm.Audit = Nothing
        Me.IO_RodSidePressAlm.AuditEnabled = False
        Me.IO_RodSidePressAlm.AuditMessage = "KremerIoField changed:"
        Me.IO_RodSidePressAlm.AuditSource = "KremerIoField"
        Me.IO_RodSidePressAlm.BackColor = System.Drawing.Color.White
        Me.IO_RodSidePressAlm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_RodSidePressAlm.Data = 0.0R
        Me.IO_RodSidePressAlm.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_RodSidePressAlm.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_RodSidePressAlm.InitialValue = True
        Me.IO_RodSidePressAlm.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_RodSidePressAlm.Location = New System.Drawing.Point(277, 284)
        Me.IO_RodSidePressAlm.LowerBound = -5000.0R
        Me.IO_RodSidePressAlm.Name = "IO_RodSidePressAlm"
        Me.IO_RodSidePressAlm.OutputFormat = "0 Bar"
        Me.IO_RodSidePressAlm.Size = New System.Drawing.Size(100, 22)
        Me.IO_RodSidePressAlm.TabIndex = 427
        Me.IO_RodSidePressAlm.Text = "0 Bar"
        Me.IO_RodSidePressAlm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_RodSidePressAlm.UpperBound = 5000.0R
        Me.IO_RodSidePressAlm.UserInfo = Nothing
        Me.IO_RodSidePressAlm.UserLevel = 0
        Me.IO_RodSidePressAlm.Visible = False
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(24, 105)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(247, 23)
        Me.Label17.TabIndex = 431
        Me.Label17.Tag = ""
        Me.Label17.Text = "Speed open"
        '
        'DryingMoldSettings2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.IO_SpeedOpen)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.IO_BotSidePressAlm)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.IO_RodSidePressAlm)
        Me.Controls.Add(Me.IO_PressingStoppingPress)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.IO_BMInitVelocity)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.IO_BMAutoVelo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IO_BMManualVelo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.IO_SpeedDownCreep)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.IO_SpeedUpCreep)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.IO_SpeedDownLock)
        Me.Controls.Add(Me.IO_SpeedDownSlow)
        Me.Controls.Add(Me.IO_SpeedDown)
        Me.Controls.Add(Me.IO_SpeedUpSlow)
        Me.Controls.Add(Me.IO_SpeedUp)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Btn_Manual)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "DryingMoldSettings2"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "79"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents mxAutomode As KremerControlsWin32.KremerVariable
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Settings As System.Windows.Forms.Button
    Friend WithEvents Btn_Settings2 As System.Windows.Forms.Button
    Friend WithEvents Btn_Manual As KremerControlsWin32.KremerButton
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents SpeedUp As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_SpeedUp As KremerControlsWin32.KremerIoField
    Friend WithEvents SpeedUpSlow As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_SpeedUpSlow As KremerControlsWin32.KremerIoField
    Friend WithEvents SpeedDown As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_SpeedDown As KremerControlsWin32.KremerIoField
    Friend WithEvents SpeedDownSlow As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_SpeedDownSlow As KremerControlsWin32.KremerIoField
    Friend WithEvents SpeedUpCreep As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_SpeedUpCreep As KremerControlsWin32.KremerIoField
    Friend WithEvents SpeedDownCreep As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_SpeedDownCreep As KremerControlsWin32.KremerIoField
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LineShape9 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape10 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents IO_BMInitVelocity As KremerControlsWin32.KremerIoField
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents IO_BMAutoVelo As KremerControlsWin32.KremerIoField
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IO_BMManualVelo As KremerControlsWin32.KremerIoField
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents IO_SpeedDownLock As KremerControlsWin32.KremerIoField
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents IO_PressingStoppingPress As KremerControlsWin32.KremerIoField
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents IO_BotSidePressAlm As KremerControlsWin32.KremerIoField
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents IO_RodSidePressAlm As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_SpeedOpen As KremerControlsWin32.KremerIoField
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ManVelo As KremerControlsWin32.KremerVariable
    Friend WithEvents AutoVelo As KremerControlsWin32.KremerVariable
    Friend WithEvents InitVelo As KremerControlsWin32.KremerVariable
    Friend WithEvents SpeedOpen As KremerControlsWin32.KremerVariable
    Friend WithEvents PressingSpeed As KremerControlsWin32.KremerVariable
    Friend WithEvents PressingPressure As KremerControlsWin32.KremerVariable

End Class
