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
        Me.NormalSpeedProfile = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_UseNormalProfile = New KremerControlsWin32.KremerButton()
        Me.NormaleSpeedProfileState = New KremerControlsWin32.KremerVariable(Me.components)
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
        Me.InitSpeedUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_InitSpeedUp = New KremerControlsWin32.KremerIoField(Me.components)
        Me.InitSpeedUpSlow = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_InitSpeedUpSlow = New KremerControlsWin32.KremerIoField(Me.components)
        Me.InitSpeedUpCreep = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_InitSpeedUpCreep = New KremerControlsWin32.KremerIoField(Me.components)
        Me.InitSpeedDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_InitSpeedDown = New KremerControlsWin32.KremerIoField(Me.components)
        Me.InitSpeedDownSlow = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_InitSpeedDownSlow = New KremerControlsWin32.KremerIoField(Me.components)
        Me.InitSpeedDownCreep = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_InitSpeedDownCreep = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ManSpeed = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_ManSpeed = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ManSpeedSlow = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_ManSpeedSlow = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ManSpeedCreep = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_ManSpeedCreep = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ManVelo = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_BMManualVelo = New KremerControlsWin32.KremerIoField(Me.components)
        Me.AutoVelo = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_BMAutoVelo = New KremerControlsWin32.KremerIoField(Me.components)
        Me.InitVelo = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_BMInitVelocity = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Btn_Overview = New KremerControlsWin32.KremerButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
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
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
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
        Me.VarCollector.Variables.Add(Me.NormalSpeedProfile)
        Me.VarCollector.Variables.Add(Me.NormaleSpeedProfileState)
        Me.VarCollector.Variables.Add(Me.SpeedUp)
        Me.VarCollector.Variables.Add(Me.SpeedUpSlow)
        Me.VarCollector.Variables.Add(Me.SpeedUpCreep)
        Me.VarCollector.Variables.Add(Me.SpeedDown)
        Me.VarCollector.Variables.Add(Me.SpeedDownSlow)
        Me.VarCollector.Variables.Add(Me.SpeedDownCreep)
        Me.VarCollector.Variables.Add(Me.SpeedOpen)
        Me.VarCollector.Variables.Add(Me.PressingSpeed)
        Me.VarCollector.Variables.Add(Me.PressingPressure)
        Me.VarCollector.Variables.Add(Me.InitSpeedUp)
        Me.VarCollector.Variables.Add(Me.InitSpeedUpSlow)
        Me.VarCollector.Variables.Add(Me.InitSpeedUpCreep)
        Me.VarCollector.Variables.Add(Me.InitSpeedDown)
        Me.VarCollector.Variables.Add(Me.InitSpeedDownSlow)
        Me.VarCollector.Variables.Add(Me.InitSpeedDownCreep)
        Me.VarCollector.Variables.Add(Me.ManSpeed)
        Me.VarCollector.Variables.Add(Me.ManSpeedSlow)
        Me.VarCollector.Variables.Add(Me.ManSpeedCreep)
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
        'NormalSpeedProfile
        '
        Me.NormalSpeedProfile.BindControl = Me.Btn_UseNormalProfile
        Me.NormalSpeedProfile.BindProperty = "Data"
        Me.NormalSpeedProfile.Data = Nothing
        Me.NormalSpeedProfile.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.NormalSpeedProfile.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.NormalSpeedProfile.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].UseNormalSpeedProfile"
        '
        'Btn_UseNormalProfile
        '
        Me.Btn_UseNormalProfile.Audit = Nothing
        Me.Btn_UseNormalProfile.AuditEnabled = False
        Me.Btn_UseNormalProfile.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_UseNormalProfile.AuditSource = "KremerPushButton"
        Me.Btn_UseNormalProfile.BackColorOn = System.Drawing.Color.Blue
        Me.Btn_UseNormalProfile.BackGroundImageOn = Nothing
        Me.Btn_UseNormalProfile.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.Btn_UseNormalProfile.Data = False
        Me.Btn_UseNormalProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_UseNormalProfile.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_UseNormalProfile.Location = New System.Drawing.Point(279, 219)
        Me.Btn_UseNormalProfile.Name = "Btn_UseNormalProfile"
        Me.Btn_UseNormalProfile.Size = New System.Drawing.Size(100, 23)
        Me.Btn_UseNormalProfile.State = False
        Me.Btn_UseNormalProfile.StateIsData = True
        Me.Btn_UseNormalProfile.StateText = New String() {Nothing, Nothing}
        Me.Btn_UseNormalProfile.TabIndex = 458
        Me.Btn_UseNormalProfile.Tag = ""
        Me.Btn_UseNormalProfile.Text = "Yes"
        Me.Btn_UseNormalProfile.UserInfo = Nothing
        Me.Btn_UseNormalProfile.UserLevel = 0
        Me.Btn_UseNormalProfile.UseStateText = False
        Me.Btn_UseNormalProfile.UseVisualStyleBackColor = True
        '
        'NormaleSpeedProfileState
        '
        Me.NormaleSpeedProfileState.BindControl = Me.Btn_UseNormalProfile
        Me.NormaleSpeedProfileState.BindProperty = "State"
        Me.NormaleSpeedProfileState.Data = Nothing
        Me.NormaleSpeedProfileState.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.NormaleSpeedProfileState.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.NormaleSpeedProfileState.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].UseNormalSpeedProfile"
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
        Me.IO_SpeedUp.LowerBound = 0.0R
        Me.IO_SpeedUp.Name = "IO_SpeedUp"
        Me.IO_SpeedUp.OutputFormat = "0.0 '%'"
        Me.IO_SpeedUp.Size = New System.Drawing.Size(100, 22)
        Me.IO_SpeedUp.TabIndex = 406
        Me.IO_SpeedUp.Text = "0.0 %"
        Me.IO_SpeedUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_SpeedUp.UpperBound = 70.0R
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
        Me.IO_SpeedUpSlow.LowerBound = 0.0R
        Me.IO_SpeedUpSlow.Name = "IO_SpeedUpSlow"
        Me.IO_SpeedUpSlow.OutputFormat = "0.0 '%'"
        Me.IO_SpeedUpSlow.Size = New System.Drawing.Size(100, 22)
        Me.IO_SpeedUpSlow.TabIndex = 407
        Me.IO_SpeedUpSlow.Text = "0.0 %"
        Me.IO_SpeedUpSlow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_SpeedUpSlow.UpperBound = 70.0R
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
        Me.IO_SpeedUpCreep.LowerBound = 0.0R
        Me.IO_SpeedUpCreep.Name = "IO_SpeedUpCreep"
        Me.IO_SpeedUpCreep.OutputFormat = "0.0 '%'"
        Me.IO_SpeedUpCreep.Size = New System.Drawing.Size(100, 22)
        Me.IO_SpeedUpCreep.TabIndex = 413
        Me.IO_SpeedUpCreep.Text = "0.0 %"
        Me.IO_SpeedUpCreep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_SpeedUpCreep.UpperBound = 70.0R
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
        Me.IO_SpeedDown.LowerBound = 0.0R
        Me.IO_SpeedDown.Name = "IO_SpeedDown"
        Me.IO_SpeedDown.OutputFormat = "0.0 '%'"
        Me.IO_SpeedDown.Size = New System.Drawing.Size(100, 22)
        Me.IO_SpeedDown.TabIndex = 408
        Me.IO_SpeedDown.Text = "0.0 %"
        Me.IO_SpeedDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_SpeedDown.UpperBound = 70.0R
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
        Me.IO_SpeedDownSlow.LowerBound = 0.0R
        Me.IO_SpeedDownSlow.Name = "IO_SpeedDownSlow"
        Me.IO_SpeedDownSlow.OutputFormat = "0.0 '%'"
        Me.IO_SpeedDownSlow.Size = New System.Drawing.Size(100, 22)
        Me.IO_SpeedDownSlow.TabIndex = 409
        Me.IO_SpeedDownSlow.Text = "0.0 %"
        Me.IO_SpeedDownSlow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_SpeedDownSlow.UpperBound = 70.0R
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
        Me.IO_SpeedDownCreep.LowerBound = 0.0R
        Me.IO_SpeedDownCreep.Name = "IO_SpeedDownCreep"
        Me.IO_SpeedDownCreep.OutputFormat = "0.0 '%'"
        Me.IO_SpeedDownCreep.Size = New System.Drawing.Size(100, 22)
        Me.IO_SpeedDownCreep.TabIndex = 415
        Me.IO_SpeedDownCreep.Text = "0.0 %"
        Me.IO_SpeedDownCreep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_SpeedDownCreep.UpperBound = 70.0R
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
        Me.IO_SpeedOpen.LowerBound = 0.0R
        Me.IO_SpeedOpen.Name = "IO_SpeedOpen"
        Me.IO_SpeedOpen.OutputFormat = "0.0 '%'"
        Me.IO_SpeedOpen.Size = New System.Drawing.Size(100, 22)
        Me.IO_SpeedOpen.TabIndex = 432
        Me.IO_SpeedOpen.Text = "0.0 %"
        Me.IO_SpeedOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_SpeedOpen.UpperBound = 70.0R
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
        Me.IO_PressingStoppingPress.Location = New System.Drawing.Point(277, 363)
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
        'InitSpeedUp
        '
        Me.InitSpeedUp.BindControl = Me.IO_InitSpeedUp
        Me.InitSpeedUp.BindProperty = "Data"
        Me.InitSpeedUp.Data = Nothing
        Me.InitSpeedUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.InitSpeedUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.InitSpeedUp.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].InitSpeedUpNormal"
        '
        'IO_InitSpeedUp
        '
        Me.IO_InitSpeedUp.Audit = Nothing
        Me.IO_InitSpeedUp.AuditEnabled = False
        Me.IO_InitSpeedUp.AuditMessage = "KremerIoField changed:"
        Me.IO_InitSpeedUp.AuditSource = "KremerIoField"
        Me.IO_InitSpeedUp.BackColor = System.Drawing.Color.White
        Me.IO_InitSpeedUp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_InitSpeedUp.Data = 0.0R
        Me.IO_InitSpeedUp.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_InitSpeedUp.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_InitSpeedUp.InitialValue = True
        Me.IO_InitSpeedUp.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_InitSpeedUp.Location = New System.Drawing.Point(668, 38)
        Me.IO_InitSpeedUp.LowerBound = 0.0R
        Me.IO_InitSpeedUp.Name = "IO_InitSpeedUp"
        Me.IO_InitSpeedUp.OutputFormat = "0.0 '%'"
        Me.IO_InitSpeedUp.Size = New System.Drawing.Size(100, 22)
        Me.IO_InitSpeedUp.TabIndex = 438
        Me.IO_InitSpeedUp.Text = "0.0 %"
        Me.IO_InitSpeedUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_InitSpeedUp.UpperBound = 40.0R
        Me.IO_InitSpeedUp.UserInfo = Nothing
        Me.IO_InitSpeedUp.UserLevel = 0
        '
        'InitSpeedUpSlow
        '
        Me.InitSpeedUpSlow.BindControl = Me.IO_InitSpeedUpSlow
        Me.InitSpeedUpSlow.BindProperty = "Data"
        Me.InitSpeedUpSlow.Data = Nothing
        Me.InitSpeedUpSlow.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.InitSpeedUpSlow.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.InitSpeedUpSlow.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].InitSpeedUpSlow"
        '
        'IO_InitSpeedUpSlow
        '
        Me.IO_InitSpeedUpSlow.Audit = Nothing
        Me.IO_InitSpeedUpSlow.AuditEnabled = False
        Me.IO_InitSpeedUpSlow.AuditMessage = "KremerIoField changed:"
        Me.IO_InitSpeedUpSlow.AuditSource = "KremerIoField"
        Me.IO_InitSpeedUpSlow.BackColor = System.Drawing.Color.White
        Me.IO_InitSpeedUpSlow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_InitSpeedUpSlow.Data = 0.0R
        Me.IO_InitSpeedUpSlow.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_InitSpeedUpSlow.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_InitSpeedUpSlow.InitialValue = True
        Me.IO_InitSpeedUpSlow.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_InitSpeedUpSlow.Location = New System.Drawing.Point(668, 61)
        Me.IO_InitSpeedUpSlow.LowerBound = 0.0R
        Me.IO_InitSpeedUpSlow.Name = "IO_InitSpeedUpSlow"
        Me.IO_InitSpeedUpSlow.OutputFormat = "0.0 '%'"
        Me.IO_InitSpeedUpSlow.Size = New System.Drawing.Size(100, 22)
        Me.IO_InitSpeedUpSlow.TabIndex = 439
        Me.IO_InitSpeedUpSlow.Text = "0.0 %"
        Me.IO_InitSpeedUpSlow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_InitSpeedUpSlow.UpperBound = 40.0R
        Me.IO_InitSpeedUpSlow.UserInfo = Nothing
        Me.IO_InitSpeedUpSlow.UserLevel = 0
        '
        'InitSpeedUpCreep
        '
        Me.InitSpeedUpCreep.BindControl = Me.IO_InitSpeedUpCreep
        Me.InitSpeedUpCreep.BindProperty = "Data"
        Me.InitSpeedUpCreep.Data = Nothing
        Me.InitSpeedUpCreep.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.InitSpeedUpCreep.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.InitSpeedUpCreep.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].InitSpeedUpCreep"
        '
        'IO_InitSpeedUpCreep
        '
        Me.IO_InitSpeedUpCreep.Audit = Nothing
        Me.IO_InitSpeedUpCreep.AuditEnabled = False
        Me.IO_InitSpeedUpCreep.AuditMessage = "KremerIoField changed:"
        Me.IO_InitSpeedUpCreep.AuditSource = "KremerIoField"
        Me.IO_InitSpeedUpCreep.BackColor = System.Drawing.Color.White
        Me.IO_InitSpeedUpCreep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_InitSpeedUpCreep.Data = 0.0R
        Me.IO_InitSpeedUpCreep.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_InitSpeedUpCreep.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_InitSpeedUpCreep.InitialValue = True
        Me.IO_InitSpeedUpCreep.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_InitSpeedUpCreep.Location = New System.Drawing.Point(668, 84)
        Me.IO_InitSpeedUpCreep.LowerBound = 0.0R
        Me.IO_InitSpeedUpCreep.Name = "IO_InitSpeedUpCreep"
        Me.IO_InitSpeedUpCreep.OutputFormat = "0.0 '%'"
        Me.IO_InitSpeedUpCreep.Size = New System.Drawing.Size(100, 22)
        Me.IO_InitSpeedUpCreep.TabIndex = 443
        Me.IO_InitSpeedUpCreep.Text = "0.0 %"
        Me.IO_InitSpeedUpCreep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_InitSpeedUpCreep.UpperBound = 40.0R
        Me.IO_InitSpeedUpCreep.UserInfo = Nothing
        Me.IO_InitSpeedUpCreep.UserLevel = 0
        '
        'InitSpeedDown
        '
        Me.InitSpeedDown.BindControl = Me.IO_InitSpeedDown
        Me.InitSpeedDown.BindProperty = "Data"
        Me.InitSpeedDown.Data = Nothing
        Me.InitSpeedDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.InitSpeedDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.InitSpeedDown.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].InitSpeedDownNormal"
        '
        'IO_InitSpeedDown
        '
        Me.IO_InitSpeedDown.Audit = Nothing
        Me.IO_InitSpeedDown.AuditEnabled = False
        Me.IO_InitSpeedDown.AuditMessage = "KremerIoField changed:"
        Me.IO_InitSpeedDown.AuditSource = "KremerIoField"
        Me.IO_InitSpeedDown.BackColor = System.Drawing.Color.White
        Me.IO_InitSpeedDown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_InitSpeedDown.Data = 0.0R
        Me.IO_InitSpeedDown.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_InitSpeedDown.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_InitSpeedDown.InitialValue = True
        Me.IO_InitSpeedDown.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_InitSpeedDown.Location = New System.Drawing.Point(668, 108)
        Me.IO_InitSpeedDown.LowerBound = 0.0R
        Me.IO_InitSpeedDown.Name = "IO_InitSpeedDown"
        Me.IO_InitSpeedDown.OutputFormat = "0.0 '%'"
        Me.IO_InitSpeedDown.Size = New System.Drawing.Size(100, 22)
        Me.IO_InitSpeedDown.TabIndex = 440
        Me.IO_InitSpeedDown.Text = "0.0 %"
        Me.IO_InitSpeedDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_InitSpeedDown.UpperBound = 40.0R
        Me.IO_InitSpeedDown.UserInfo = Nothing
        Me.IO_InitSpeedDown.UserLevel = 0
        '
        'InitSpeedDownSlow
        '
        Me.InitSpeedDownSlow.BindControl = Me.IO_InitSpeedDownSlow
        Me.InitSpeedDownSlow.BindProperty = "Data"
        Me.InitSpeedDownSlow.Data = Nothing
        Me.InitSpeedDownSlow.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.InitSpeedDownSlow.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.InitSpeedDownSlow.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].InitSpeedDownSlow"
        '
        'IO_InitSpeedDownSlow
        '
        Me.IO_InitSpeedDownSlow.Audit = Nothing
        Me.IO_InitSpeedDownSlow.AuditEnabled = False
        Me.IO_InitSpeedDownSlow.AuditMessage = "KremerIoField changed:"
        Me.IO_InitSpeedDownSlow.AuditSource = "KremerIoField"
        Me.IO_InitSpeedDownSlow.BackColor = System.Drawing.Color.White
        Me.IO_InitSpeedDownSlow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_InitSpeedDownSlow.Data = 0.0R
        Me.IO_InitSpeedDownSlow.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_InitSpeedDownSlow.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_InitSpeedDownSlow.InitialValue = True
        Me.IO_InitSpeedDownSlow.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_InitSpeedDownSlow.Location = New System.Drawing.Point(668, 131)
        Me.IO_InitSpeedDownSlow.LowerBound = 0.0R
        Me.IO_InitSpeedDownSlow.Name = "IO_InitSpeedDownSlow"
        Me.IO_InitSpeedDownSlow.OutputFormat = "0.0 '%'"
        Me.IO_InitSpeedDownSlow.Size = New System.Drawing.Size(100, 22)
        Me.IO_InitSpeedDownSlow.TabIndex = 441
        Me.IO_InitSpeedDownSlow.Text = "0.0 %"
        Me.IO_InitSpeedDownSlow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_InitSpeedDownSlow.UpperBound = 40.0R
        Me.IO_InitSpeedDownSlow.UserInfo = Nothing
        Me.IO_InitSpeedDownSlow.UserLevel = 0
        '
        'InitSpeedDownCreep
        '
        Me.InitSpeedDownCreep.BindControl = Me.IO_InitSpeedDownCreep
        Me.InitSpeedDownCreep.BindProperty = "Data"
        Me.InitSpeedDownCreep.Data = Nothing
        Me.InitSpeedDownCreep.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.InitSpeedDownCreep.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.InitSpeedDownCreep.VariableName = "MAIN.InMoldDrying.MachParameters.Top[Position1].InitSpeedDownCreep"
        '
        'IO_InitSpeedDownCreep
        '
        Me.IO_InitSpeedDownCreep.Audit = Nothing
        Me.IO_InitSpeedDownCreep.AuditEnabled = False
        Me.IO_InitSpeedDownCreep.AuditMessage = "KremerIoField changed:"
        Me.IO_InitSpeedDownCreep.AuditSource = "KremerIoField"
        Me.IO_InitSpeedDownCreep.BackColor = System.Drawing.Color.White
        Me.IO_InitSpeedDownCreep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_InitSpeedDownCreep.Data = 0.0R
        Me.IO_InitSpeedDownCreep.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_InitSpeedDownCreep.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_InitSpeedDownCreep.InitialValue = True
        Me.IO_InitSpeedDownCreep.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_InitSpeedDownCreep.Location = New System.Drawing.Point(668, 154)
        Me.IO_InitSpeedDownCreep.LowerBound = 0.0R
        Me.IO_InitSpeedDownCreep.Name = "IO_InitSpeedDownCreep"
        Me.IO_InitSpeedDownCreep.OutputFormat = "0.0 '%'"
        Me.IO_InitSpeedDownCreep.Size = New System.Drawing.Size(100, 22)
        Me.IO_InitSpeedDownCreep.TabIndex = 445
        Me.IO_InitSpeedDownCreep.Text = "0.0 %"
        Me.IO_InitSpeedDownCreep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_InitSpeedDownCreep.UpperBound = 40.0R
        Me.IO_InitSpeedDownCreep.UserInfo = Nothing
        Me.IO_InitSpeedDownCreep.UserLevel = 0
        '
        'ManSpeed
        '
        Me.ManSpeed.BindControl = Me.IO_ManSpeed
        Me.ManSpeed.BindProperty = "Data"
        Me.ManSpeed.Data = Nothing
        Me.ManSpeed.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.ManSpeed.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ManSpeed.VariableName = "MAIN.MachPar.InMoldDrying.Top[Position1].ManSpeed"
        '
        'IO_ManSpeed
        '
        Me.IO_ManSpeed.Audit = Nothing
        Me.IO_ManSpeed.AuditEnabled = False
        Me.IO_ManSpeed.AuditMessage = "KremerIoField changed:"
        Me.IO_ManSpeed.AuditSource = "KremerIoField"
        Me.IO_ManSpeed.BackColor = System.Drawing.Color.White
        Me.IO_ManSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_ManSpeed.Data = 0.0R
        Me.IO_ManSpeed.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_ManSpeed.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_ManSpeed.InitialValue = True
        Me.IO_ManSpeed.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_ManSpeed.Location = New System.Drawing.Point(668, 212)
        Me.IO_ManSpeed.LowerBound = 0.0R
        Me.IO_ManSpeed.Name = "IO_ManSpeed"
        Me.IO_ManSpeed.OutputFormat = "0.0 '%'"
        Me.IO_ManSpeed.Size = New System.Drawing.Size(100, 22)
        Me.IO_ManSpeed.TabIndex = 446
        Me.IO_ManSpeed.Text = "0.0 %"
        Me.IO_ManSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_ManSpeed.UpperBound = 32.0R
        Me.IO_ManSpeed.UserInfo = Nothing
        Me.IO_ManSpeed.UserLevel = 0
        '
        'ManSpeedSlow
        '
        Me.ManSpeedSlow.BindControl = Me.IO_ManSpeedSlow
        Me.ManSpeedSlow.BindProperty = "Data"
        Me.ManSpeedSlow.Data = Nothing
        Me.ManSpeedSlow.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.ManSpeedSlow.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ManSpeedSlow.VariableName = "MAIN.MachPar.InMoldDrying.Top[Position1].ManSpeedSlow"
        '
        'IO_ManSpeedSlow
        '
        Me.IO_ManSpeedSlow.Audit = Nothing
        Me.IO_ManSpeedSlow.AuditEnabled = False
        Me.IO_ManSpeedSlow.AuditMessage = "KremerIoField changed:"
        Me.IO_ManSpeedSlow.AuditSource = "KremerIoField"
        Me.IO_ManSpeedSlow.BackColor = System.Drawing.Color.White
        Me.IO_ManSpeedSlow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_ManSpeedSlow.Data = 0.0R
        Me.IO_ManSpeedSlow.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_ManSpeedSlow.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_ManSpeedSlow.InitialValue = True
        Me.IO_ManSpeedSlow.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_ManSpeedSlow.Location = New System.Drawing.Point(668, 235)
        Me.IO_ManSpeedSlow.LowerBound = 0.0R
        Me.IO_ManSpeedSlow.Name = "IO_ManSpeedSlow"
        Me.IO_ManSpeedSlow.OutputFormat = "0.0 '%'"
        Me.IO_ManSpeedSlow.Size = New System.Drawing.Size(100, 22)
        Me.IO_ManSpeedSlow.TabIndex = 447
        Me.IO_ManSpeedSlow.Text = "0.0 %"
        Me.IO_ManSpeedSlow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_ManSpeedSlow.UpperBound = 32.0R
        Me.IO_ManSpeedSlow.UserInfo = Nothing
        Me.IO_ManSpeedSlow.UserLevel = 0
        '
        'ManSpeedCreep
        '
        Me.ManSpeedCreep.BindControl = Me.IO_ManSpeedCreep
        Me.ManSpeedCreep.BindProperty = "Data"
        Me.ManSpeedCreep.Data = Nothing
        Me.ManSpeedCreep.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.ManSpeedCreep.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ManSpeedCreep.VariableName = "MAIN.MachPar.InMoldDrying.Top[Position1].ManSpeedCreep"
        '
        'IO_ManSpeedCreep
        '
        Me.IO_ManSpeedCreep.Audit = Nothing
        Me.IO_ManSpeedCreep.AuditEnabled = False
        Me.IO_ManSpeedCreep.AuditMessage = "KremerIoField changed:"
        Me.IO_ManSpeedCreep.AuditSource = "KremerIoField"
        Me.IO_ManSpeedCreep.BackColor = System.Drawing.Color.White
        Me.IO_ManSpeedCreep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_ManSpeedCreep.Data = 0.0R
        Me.IO_ManSpeedCreep.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_ManSpeedCreep.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_ManSpeedCreep.InitialValue = True
        Me.IO_ManSpeedCreep.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_ManSpeedCreep.Location = New System.Drawing.Point(668, 258)
        Me.IO_ManSpeedCreep.LowerBound = 0.0R
        Me.IO_ManSpeedCreep.Name = "IO_ManSpeedCreep"
        Me.IO_ManSpeedCreep.OutputFormat = "0.0 '%'"
        Me.IO_ManSpeedCreep.Size = New System.Drawing.Size(100, 22)
        Me.IO_ManSpeedCreep.TabIndex = 450
        Me.IO_ManSpeedCreep.Text = "0.0 %"
        Me.IO_ManSpeedCreep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_ManSpeedCreep.UpperBound = 32.0R
        Me.IO_ManSpeedCreep.UserInfo = Nothing
        Me.IO_ManSpeedCreep.UserLevel = 0
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
        Me.IO_BMManualVelo.Location = New System.Drawing.Point(280, 268)
        Me.IO_BMManualVelo.LowerBound = 0.0R
        Me.IO_BMManualVelo.Name = "IO_BMManualVelo"
        Me.IO_BMManualVelo.OutputFormat = "0.0 mm/s"
        Me.IO_BMManualVelo.Size = New System.Drawing.Size(100, 22)
        Me.IO_BMManualVelo.TabIndex = 417
        Me.IO_BMManualVelo.Text = "0.0 mm/s"
        Me.IO_BMManualVelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_BMManualVelo.UpperBound = 300.0R
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
        Me.IO_BMAutoVelo.Location = New System.Drawing.Point(280, 292)
        Me.IO_BMAutoVelo.LowerBound = 0.0R
        Me.IO_BMAutoVelo.Name = "IO_BMAutoVelo"
        Me.IO_BMAutoVelo.OutputFormat = "0.0 mm/s"
        Me.IO_BMAutoVelo.Size = New System.Drawing.Size(100, 22)
        Me.IO_BMAutoVelo.TabIndex = 419
        Me.IO_BMAutoVelo.Text = "0.0 mm/s"
        Me.IO_BMAutoVelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_BMAutoVelo.UpperBound = 1100.0R
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
        Me.IO_BMInitVelocity.Location = New System.Drawing.Point(280, 316)
        Me.IO_BMInitVelocity.LowerBound = 0.0R
        Me.IO_BMInitVelocity.Name = "IO_BMInitVelocity"
        Me.IO_BMInitVelocity.OutputFormat = "0.0 mm/s"
        Me.IO_BMInitVelocity.Size = New System.Drawing.Size(100, 22)
        Me.IO_BMInitVelocity.TabIndex = 421
        Me.IO_BMInitVelocity.Text = "0.0 mm/s"
        Me.IO_BMInitVelocity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_BMInitVelocity.UpperBound = 300.0R
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
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape8, Me.LineShape7, Me.LineShape6, Me.LineShape5, Me.LineShape3, Me.LineShape2, Me.LineShape9, Me.LineShape10, Me.LineShape4, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 435)
        Me.ShapeContainer1.TabIndex = 308
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape8
        '
        Me.LineShape8.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape8.Name = "LineShape8"
        Me.LineShape8.X1 = 419
        Me.LineShape8.X2 = 769
        Me.LineShape8.Y1 = 210
        Me.LineShape8.Y2 = 210
        '
        'LineShape7
        '
        Me.LineShape7.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 664
        Me.LineShape7.X2 = 663
        Me.LineShape7.Y1 = 210
        Me.LineShape7.Y2 = 275
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 419
        Me.LineShape6.X2 = 769
        Me.LineShape6.Y1 = 35
        Me.LineShape6.Y2 = 35
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 664
        Me.LineShape5.X2 = 663
        Me.LineShape5.Y1 = 35
        Me.LineShape5.Y2 = 175
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 29
        Me.LineShape3.X2 = 379
        Me.LineShape3.Y1 = 266
        Me.LineShape3.Y2 = 266
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 274
        Me.LineShape2.X2 = 273
        Me.LineShape2.Y1 = 266
        Me.LineShape2.Y2 = 335
        '
        'LineShape9
        '
        Me.LineShape9.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape9.Name = "LineShape9"
        Me.LineShape9.X1 = 274
        Me.LineShape9.X2 = 274
        Me.LineShape9.Y1 = 361
        Me.LineShape9.Y2 = 441
        '
        'LineShape10
        '
        Me.LineShape10.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape10.Name = "LineShape10"
        Me.LineShape10.X1 = 29
        Me.LineShape10.X2 = 379
        Me.LineShape10.Y1 = 361
        Me.LineShape10.Y2 = 361
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
        Me.Btn_Settings2.Enabled = False
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
        Me.Label20.Location = New System.Drawing.Point(27, 242)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(273, 23)
        Me.Label20.TabIndex = 422
        Me.Label20.Tag = ""
        Me.Label20.Text = "Velocities Bottom mold"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(29, 315)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(241, 23)
        Me.Label13.TabIndex = 420
        Me.Label13.Tag = "109"
        Me.Label13.Text = "Init Velocity"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 23)
        Me.Label2.TabIndex = 418
        Me.Label2.Tag = "108"
        Me.Label2.Text = "Automatic velocity"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(27, 270)
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
        Me.Label12.Location = New System.Drawing.Point(24, 336)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(352, 23)
        Me.Label12.TabIndex = 423
        Me.Label12.Tag = "146"
        Me.Label12.Text = "Topmold pressures"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(23, 366)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(247, 23)
        Me.Label14.TabIndex = 424
        Me.Label14.Tag = "147"
        Me.Label14.Text = "Pressing stopping pressure"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(24, 411)
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
        Me.IO_BotSidePressAlm.Location = New System.Drawing.Point(277, 409)
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
        Me.Label16.Location = New System.Drawing.Point(24, 388)
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
        Me.IO_RodSidePressAlm.Location = New System.Drawing.Point(277, 386)
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
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(413, 86)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(247, 23)
        Me.Label19.TabIndex = 442
        Me.Label19.Tag = "243"
        Me.Label19.Text = "Speed up creep"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.Location = New System.Drawing.Point(416, 10)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(352, 23)
        Me.Label21.TabIndex = 437
        Me.Label21.Tag = ""
        Me.Label21.Text = "Top mold init speeds"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(413, 132)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(247, 23)
        Me.Label22.TabIndex = 436
        Me.Label22.Tag = "245"
        Me.Label22.Text = "Speed down slow"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(413, 110)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(247, 23)
        Me.Label23.TabIndex = 435
        Me.Label23.Tag = "244"
        Me.Label23.Text = "Speed down"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(413, 63)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(247, 23)
        Me.Label24.TabIndex = 434
        Me.Label24.Tag = "242"
        Me.Label24.Text = "Speed up slow"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(413, 40)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(247, 23)
        Me.Label25.TabIndex = 433
        Me.Label25.Tag = "241"
        Me.Label25.Text = "Speed up"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(413, 155)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(247, 23)
        Me.Label18.TabIndex = 444
        Me.Label18.Tag = "246"
        Me.Label18.Text = "Speed down creep"
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(413, 260)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(247, 23)
        Me.Label27.TabIndex = 456
        Me.Label27.Tag = ""
        Me.Label27.Text = "Speed creep"
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(413, 237)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(247, 23)
        Me.Label30.TabIndex = 453
        Me.Label30.Tag = ""
        Me.Label30.Text = "Speed slow"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(413, 214)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(247, 23)
        Me.Label31.TabIndex = 452
        Me.Label31.Tag = ""
        Me.Label31.Text = "Speed"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label26.Location = New System.Drawing.Point(413, 185)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(352, 23)
        Me.Label26.TabIndex = 457
        Me.Label26.Tag = ""
        Me.Label26.Text = "Top mold manual speeds"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(22, 219)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(254, 23)
        Me.Label28.TabIndex = 459
        Me.Label28.Tag = ""
        Me.Label28.Text = "Disable creep / slow (down)"
        '
        'DryingMoldSettings2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Btn_UseNormalProfile)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.IO_ManSpeedCreep)
        Me.Controls.Add(Me.IO_ManSpeedSlow)
        Me.Controls.Add(Me.IO_ManSpeed)
        Me.Controls.Add(Me.IO_InitSpeedDownCreep)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.IO_InitSpeedUpCreep)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.IO_InitSpeedDownSlow)
        Me.Controls.Add(Me.IO_InitSpeedDown)
        Me.Controls.Add(Me.IO_InitSpeedUpSlow)
        Me.Controls.Add(Me.IO_InitSpeedUp)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
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
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents IO_InitSpeedUpCreep As KremerControlsWin32.KremerIoField
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents IO_InitSpeedDownSlow As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_InitSpeedDown As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_InitSpeedUpSlow As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_InitSpeedUp As KremerControlsWin32.KremerIoField
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents IO_InitSpeedDownCreep As KremerControlsWin32.KremerIoField
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents InitSpeedUp As KremerControlsWin32.KremerVariable
    Friend WithEvents InitSpeedUpSlow As KremerControlsWin32.KremerVariable
    Friend WithEvents InitSpeedUpCreep As KremerControlsWin32.KremerVariable
    Friend WithEvents InitSpeedDown As KremerControlsWin32.KremerVariable
    Friend WithEvents InitSpeedDownSlow As KremerControlsWin32.KremerVariable
    Friend WithEvents InitSpeedDownCreep As KremerControlsWin32.KremerVariable
    Friend WithEvents LineShape8 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents IO_ManSpeedCreep As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_ManSpeedSlow As KremerControlsWin32.KremerIoField
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents IO_ManSpeed As KremerControlsWin32.KremerIoField
    Friend WithEvents ManSpeed As KremerControlsWin32.KremerVariable
    Friend WithEvents ManSpeedSlow As KremerControlsWin32.KremerVariable
    Friend WithEvents ManSpeedCreep As KremerControlsWin32.KremerVariable
    Friend WithEvents NormalSpeedProfile As KremerControlsWin32.KremerVariable
    Friend WithEvents NormaleSpeedProfileState As KremerControlsWin32.KremerVariable
    Friend WithEvents Btn_UseNormalProfile As KremerControlsWin32.KremerButton
    Friend WithEvents Label28 As System.Windows.Forms.Label

End Class
