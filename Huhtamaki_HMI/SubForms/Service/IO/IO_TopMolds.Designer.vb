<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IO_TopMolds
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
        Me.TMA_HydraulicValve = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TMAHydraulicValve = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TMA_Bot = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TMABotSidePressure = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TMB_Bot = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TMBBotSidePressure = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TMA_Rod = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TMA_RodSidePressure = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TMB_Rod = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TMB_RodSidePressure = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TMA_EsA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMA_EsA = New KremerControlsWin32.KremerLight()
        Me.TMA_EsB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMA_EsB = New KremerControlsWin32.KremerLight()
        Me.TMA_MspaRTO = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMA_MspaRTO = New KremerControlsWin32.KremerLight()
        Me.TMA_Zone1 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMAZone1 = New KremerControlsWin32.KremerLight()
        Me.TMA_Zone2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMAZone2 = New KremerControlsWin32.KremerLight()
        Me.TMA_Zone3 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMAZone3 = New KremerControlsWin32.KremerLight()
        Me.TMA_Zone4 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMAZone4 = New KremerControlsWin32.KremerLight()
        Me.TMA_Zone5 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMAZone5 = New KremerControlsWin32.KremerLight()
        Me.TMB_HydraulicValve = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TMBHydraulicValve = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TMA_Zone6 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMAZone6 = New KremerControlsWin32.KremerLight()
        Me.TMA_Blowoff = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMABlowOff = New KremerControlsWin32.KremerLight()
        Me.TMA_Vacuum = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMAVacuum = New KremerControlsWin32.KremerLight()
        Me.TMA_MspaEnable = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMA_MSPAEnable = New KremerControlsWin32.KremerLight()
        Me.TMB_EsA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMB_EsA = New KremerControlsWin32.KremerLight()
        Me.TMB_EsB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.TMB_MspaRTO = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMB_MspaRTO = New KremerControlsWin32.KremerLight()
        Me.TMB_ZoneError1 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMBZone1 = New KremerControlsWin32.KremerLight()
        Me.TMB_ZoneError2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMBZone2 = New KremerControlsWin32.KremerLight()
        Me.TMB_ZoneError3 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMBZone3 = New KremerControlsWin32.KremerLight()
        Me.TMB_ZoneError4 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMBZone4 = New KremerControlsWin32.KremerLight()
        Me.TMB_ZoneError5 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMBZone5 = New KremerControlsWin32.KremerLight()
        Me.TMB_ZoneError6 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMBZone6 = New KremerControlsWin32.KremerLight()
        Me.TMB_Blowoff = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMBBlowOff = New KremerControlsWin32.KremerLight()
        Me.TMB_Vacuum = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMBVacuum = New KremerControlsWin32.KremerLight()
        Me.TMB_MspaEnable = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMB_MSPAEnable = New KremerControlsWin32.KremerLight()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.KL_TMB_EsB = New KremerControlsWin32.KremerLight()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.TMA_HydraulicValve)
        Me.VarCollector.Variables.Add(Me.TMB_HydraulicValve)
        Me.VarCollector.Variables.Add(Me.TMA_Bot)
        Me.VarCollector.Variables.Add(Me.TMB_Bot)
        Me.VarCollector.Variables.Add(Me.TMA_Rod)
        Me.VarCollector.Variables.Add(Me.TMB_Rod)
        Me.VarCollector.Variables.Add(Me.TMA_EsA)
        Me.VarCollector.Variables.Add(Me.TMA_EsB)
        Me.VarCollector.Variables.Add(Me.TMA_MspaRTO)
        Me.VarCollector.Variables.Add(Me.TMA_Zone1)
        Me.VarCollector.Variables.Add(Me.TMA_Zone2)
        Me.VarCollector.Variables.Add(Me.TMA_Zone3)
        Me.VarCollector.Variables.Add(Me.TMA_Zone4)
        Me.VarCollector.Variables.Add(Me.TMA_Zone5)
        Me.VarCollector.Variables.Add(Me.TMA_Zone6)
        Me.VarCollector.Variables.Add(Me.TMA_Blowoff)
        Me.VarCollector.Variables.Add(Me.TMA_Vacuum)
        Me.VarCollector.Variables.Add(Me.TMA_MspaEnable)
        Me.VarCollector.Variables.Add(Me.TMB_EsA)
        Me.VarCollector.Variables.Add(Me.TMB_EsB)
        Me.VarCollector.Variables.Add(Me.TMB_MspaRTO)
        Me.VarCollector.Variables.Add(Me.TMB_ZoneError1)
        Me.VarCollector.Variables.Add(Me.TMB_ZoneError2)
        Me.VarCollector.Variables.Add(Me.TMB_ZoneError3)
        Me.VarCollector.Variables.Add(Me.TMB_ZoneError4)
        Me.VarCollector.Variables.Add(Me.TMB_ZoneError5)
        Me.VarCollector.Variables.Add(Me.TMB_ZoneError6)
        Me.VarCollector.Variables.Add(Me.TMB_Blowoff)
        Me.VarCollector.Variables.Add(Me.TMB_Vacuum)
        Me.VarCollector.Variables.Add(Me.TMB_MspaEnable)
        '
        'TMA_HydraulicValve
        '
        Me.TMA_HydraulicValve.BindControl = Me.IO_TMAHydraulicValve
        Me.TMA_HydraulicValve.BindProperty = "Data"
        Me.TMA_HydraulicValve.Data = Nothing
        Me.TMA_HydraulicValve.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.TMA_HydraulicValve.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMA_HydraulicValve.VariableName = "MAIN.InMoldDrying.TopMoldA.HydraulicCilinder.HydraulicValve.qwOutput"
        '
        'IO_TMAHydraulicValve
        '
        Me.IO_TMAHydraulicValve.Audit = Nothing
        Me.IO_TMAHydraulicValve.AuditEnabled = False
        Me.IO_TMAHydraulicValve.AuditMessage = "KremerIoField changed:"
        Me.IO_TMAHydraulicValve.AuditSource = "KremerIoField"
        Me.IO_TMAHydraulicValve.AutoSize = True
        Me.IO_TMAHydraulicValve.Data = 0.0R
        Me.IO_TMAHydraulicValve.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TMAHydraulicValve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TMAHydraulicValve.InitialValue = True
        Me.IO_TMAHydraulicValve.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TMAHydraulicValve.Location = New System.Drawing.Point(6, 390)
        Me.IO_TMAHydraulicValve.LowerBound = 0.0R
        Me.IO_TMAHydraulicValve.Name = "IO_TMAHydraulicValve"
        Me.IO_TMAHydraulicValve.OutputFormat = "0.0 "
        Me.IO_TMAHydraulicValve.Size = New System.Drawing.Size(28, 16)
        Me.IO_TMAHydraulicValve.TabIndex = 316
        Me.IO_TMAHydraulicValve.Text = "0.0 "
        Me.IO_TMAHydraulicValve.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TMAHydraulicValve.UpperBound = 1000.0R
        Me.IO_TMAHydraulicValve.UserInfo = Nothing
        Me.IO_TMAHydraulicValve.UserLevel = 0
        '
        'TMA_Bot
        '
        Me.TMA_Bot.BindControl = Me.IO_TMABotSidePressure
        Me.TMA_Bot.BindProperty = "Data"
        Me.TMA_Bot.Data = Nothing
        Me.TMA_Bot.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.TMA_Bot.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMA_Bot.VariableName = "MAIN.InMoldDrying.TopMoldA.HydraulicCilinder.BottomSidePressure.RawInput"
        '
        'IO_TMABotSidePressure
        '
        Me.IO_TMABotSidePressure.Audit = Nothing
        Me.IO_TMABotSidePressure.AuditEnabled = False
        Me.IO_TMABotSidePressure.AuditMessage = "KremerIoField changed:"
        Me.IO_TMABotSidePressure.AuditSource = "KremerIoField"
        Me.IO_TMABotSidePressure.AutoSize = True
        Me.IO_TMABotSidePressure.Data = 0.0R
        Me.IO_TMABotSidePressure.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TMABotSidePressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TMABotSidePressure.InitialValue = True
        Me.IO_TMABotSidePressure.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TMABotSidePressure.Location = New System.Drawing.Point(7, 251)
        Me.IO_TMABotSidePressure.LowerBound = 0.0R
        Me.IO_TMABotSidePressure.Name = "IO_TMABotSidePressure"
        Me.IO_TMABotSidePressure.OutputFormat = "0.0 "
        Me.IO_TMABotSidePressure.Size = New System.Drawing.Size(28, 16)
        Me.IO_TMABotSidePressure.TabIndex = 308
        Me.IO_TMABotSidePressure.Text = "0.0 "
        Me.IO_TMABotSidePressure.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TMABotSidePressure.UpperBound = 1000.0R
        Me.IO_TMABotSidePressure.UserInfo = Nothing
        Me.IO_TMABotSidePressure.UserLevel = 0
        '
        'TMB_Bot
        '
        Me.TMB_Bot.BindControl = Me.IO_TMBBotSidePressure
        Me.TMB_Bot.BindProperty = "Data"
        Me.TMB_Bot.Data = Nothing
        Me.TMB_Bot.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.TMB_Bot.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMB_Bot.VariableName = "MAIN.InMoldDrying.TopMoldA.HydraulicCilinder.BottomSidePressure.RawInput"
        '
        'IO_TMBBotSidePressure
        '
        Me.IO_TMBBotSidePressure.Audit = Nothing
        Me.IO_TMBBotSidePressure.AuditEnabled = False
        Me.IO_TMBBotSidePressure.AuditMessage = "KremerIoField changed:"
        Me.IO_TMBBotSidePressure.AuditSource = "KremerIoField"
        Me.IO_TMBBotSidePressure.AutoSize = True
        Me.IO_TMBBotSidePressure.Data = 0.0R
        Me.IO_TMBBotSidePressure.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TMBBotSidePressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TMBBotSidePressure.InitialValue = True
        Me.IO_TMBBotSidePressure.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TMBBotSidePressure.Location = New System.Drawing.Point(7, 251)
        Me.IO_TMBBotSidePressure.LowerBound = 0.0R
        Me.IO_TMBBotSidePressure.Name = "IO_TMBBotSidePressure"
        Me.IO_TMBBotSidePressure.OutputFormat = "0.0 "
        Me.IO_TMBBotSidePressure.Size = New System.Drawing.Size(28, 16)
        Me.IO_TMBBotSidePressure.TabIndex = 308
        Me.IO_TMBBotSidePressure.Text = "0.0 "
        Me.IO_TMBBotSidePressure.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TMBBotSidePressure.UpperBound = 1000.0R
        Me.IO_TMBBotSidePressure.UserInfo = Nothing
        Me.IO_TMBBotSidePressure.UserLevel = 0
        '
        'TMA_Rod
        '
        Me.TMA_Rod.BindControl = Me.IO_TMA_RodSidePressure
        Me.TMA_Rod.BindProperty = "Data"
        Me.TMA_Rod.Data = Nothing
        Me.TMA_Rod.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.TMA_Rod.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMA_Rod.VariableName = "MAIN.InMoldDrying.TopMoldA.HydraulicCilinder.RodSidePressure.RawInput"
        '
        'IO_TMA_RodSidePressure
        '
        Me.IO_TMA_RodSidePressure.Audit = Nothing
        Me.IO_TMA_RodSidePressure.AuditEnabled = False
        Me.IO_TMA_RodSidePressure.AuditMessage = "KremerIoField changed:"
        Me.IO_TMA_RodSidePressure.AuditSource = "KremerIoField"
        Me.IO_TMA_RodSidePressure.AutoSize = True
        Me.IO_TMA_RodSidePressure.Data = 0.0R
        Me.IO_TMA_RodSidePressure.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TMA_RodSidePressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TMA_RodSidePressure.InitialValue = True
        Me.IO_TMA_RodSidePressure.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TMA_RodSidePressure.Location = New System.Drawing.Point(7, 233)
        Me.IO_TMA_RodSidePressure.LowerBound = 0.0R
        Me.IO_TMA_RodSidePressure.Name = "IO_TMA_RodSidePressure"
        Me.IO_TMA_RodSidePressure.OutputFormat = "0.0 "
        Me.IO_TMA_RodSidePressure.Size = New System.Drawing.Size(28, 16)
        Me.IO_TMA_RodSidePressure.TabIndex = 307
        Me.IO_TMA_RodSidePressure.Text = "0.0 "
        Me.IO_TMA_RodSidePressure.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TMA_RodSidePressure.UpperBound = 1000.0R
        Me.IO_TMA_RodSidePressure.UserInfo = Nothing
        Me.IO_TMA_RodSidePressure.UserLevel = 0
        '
        'TMB_Rod
        '
        Me.TMB_Rod.BindControl = Me.IO_TMB_RodSidePressure
        Me.TMB_Rod.BindProperty = "Data"
        Me.TMB_Rod.Data = Nothing
        Me.TMB_Rod.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.TMB_Rod.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMB_Rod.VariableName = "MAIN.InMoldDrying.TopMoldA.HydraulicCilinder.RodSidePressure.RawInput"
        '
        'IO_TMB_RodSidePressure
        '
        Me.IO_TMB_RodSidePressure.Audit = Nothing
        Me.IO_TMB_RodSidePressure.AuditEnabled = False
        Me.IO_TMB_RodSidePressure.AuditMessage = "KremerIoField changed:"
        Me.IO_TMB_RodSidePressure.AuditSource = "KremerIoField"
        Me.IO_TMB_RodSidePressure.AutoSize = True
        Me.IO_TMB_RodSidePressure.Data = 0.0R
        Me.IO_TMB_RodSidePressure.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TMB_RodSidePressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TMB_RodSidePressure.InitialValue = True
        Me.IO_TMB_RodSidePressure.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TMB_RodSidePressure.Location = New System.Drawing.Point(7, 233)
        Me.IO_TMB_RodSidePressure.LowerBound = 0.0R
        Me.IO_TMB_RodSidePressure.Name = "IO_TMB_RodSidePressure"
        Me.IO_TMB_RodSidePressure.OutputFormat = "0.0 "
        Me.IO_TMB_RodSidePressure.Size = New System.Drawing.Size(28, 16)
        Me.IO_TMB_RodSidePressure.TabIndex = 307
        Me.IO_TMB_RodSidePressure.Text = "0.0 "
        Me.IO_TMB_RodSidePressure.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TMB_RodSidePressure.UpperBound = 1000.0R
        Me.IO_TMB_RodSidePressure.UserInfo = Nothing
        Me.IO_TMB_RodSidePressure.UserLevel = 0
        '
        'TMA_EsA
        '
        Me.TMA_EsA.BindControl = Me.KL_TMA_EsA
        Me.TMA_EsA.BindProperty = "Data"
        Me.TMA_EsA.Data = Nothing
        Me.TMA_EsA.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMA_EsA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMA_EsA.VariableName = "MAIN.InMoldDrying.TopMoldA.HydraulicCilinder.ixEndSwitchA"
        '
        'KL_TMA_EsA
        '
        Me.KL_TMA_EsA.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMA_EsA.ColorOn = System.Drawing.Color.Lime
        Me.KL_TMA_EsA.Data = False
        Me.KL_TMA_EsA.Line = True
        Me.KL_TMA_EsA.LineSize = 1
        Me.KL_TMA_EsA.Location = New System.Drawing.Point(10, 25)
        Me.KL_TMA_EsA.Name = "KL_TMA_EsA"
        Me.KL_TMA_EsA.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMA_EsA.TabIndex = 290
        Me.KL_TMA_EsA.Text = "KL_TMA_EsA"
        Me.KL_TMA_EsA.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMA_EsB
        '
        Me.TMA_EsB.BindControl = Me.KL_TMA_EsB
        Me.TMA_EsB.BindProperty = "Data"
        Me.TMA_EsB.Data = Nothing
        Me.TMA_EsB.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMA_EsB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMA_EsB.VariableName = "MAIN.InMoldDrying.TopMoldA.HydraulicCilinder.ixEndSwitchB"
        '
        'KL_TMA_EsB
        '
        Me.KL_TMA_EsB.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMA_EsB.ColorOn = System.Drawing.Color.Lime
        Me.KL_TMA_EsB.Data = False
        Me.KL_TMA_EsB.Line = True
        Me.KL_TMA_EsB.LineSize = 1
        Me.KL_TMA_EsB.Location = New System.Drawing.Point(10, 46)
        Me.KL_TMA_EsB.Name = "KL_TMA_EsB"
        Me.KL_TMA_EsB.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMA_EsB.TabIndex = 292
        Me.KL_TMA_EsB.Text = "KL_TMA_EsB"
        Me.KL_TMA_EsB.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMA_MspaRTO
        '
        Me.TMA_MspaRTO.BindControl = Me.KL_TMA_MspaRTO
        Me.TMA_MspaRTO.BindProperty = "Data"
        Me.TMA_MspaRTO.Data = Nothing
        Me.TMA_MspaRTO.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMA_MspaRTO.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMA_MspaRTO.VariableName = "MAIN.InMoldDrying.TopMoldA.HydraulicCilinder.ixMSPAReadyToOperate"
        '
        'KL_TMA_MspaRTO
        '
        Me.KL_TMA_MspaRTO.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMA_MspaRTO.ColorOn = System.Drawing.Color.Lime
        Me.KL_TMA_MspaRTO.Data = False
        Me.KL_TMA_MspaRTO.Line = True
        Me.KL_TMA_MspaRTO.LineSize = 1
        Me.KL_TMA_MspaRTO.Location = New System.Drawing.Point(10, 67)
        Me.KL_TMA_MspaRTO.Name = "KL_TMA_MspaRTO"
        Me.KL_TMA_MspaRTO.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMA_MspaRTO.TabIndex = 294
        Me.KL_TMA_MspaRTO.Text = "KL_TMA_MspaRTO"
        Me.KL_TMA_MspaRTO.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMA_Zone1
        '
        Me.TMA_Zone1.BindControl = Me.KL_TMAZone1
        Me.TMA_Zone1.BindProperty = "Data"
        Me.TMA_Zone1.Data = Nothing
        Me.TMA_Zone1.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMA_Zone1.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMA_Zone1.VariableName = "MAIN.InMoldDrying.TopMoldA.HeatingZone[1].ixThermal"
        '
        'KL_TMAZone1
        '
        Me.KL_TMAZone1.ColorOff = System.Drawing.Color.Red
        Me.KL_TMAZone1.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMAZone1.Data = False
        Me.KL_TMAZone1.Line = True
        Me.KL_TMAZone1.LineSize = 1
        Me.KL_TMAZone1.Location = New System.Drawing.Point(10, 87)
        Me.KL_TMAZone1.Name = "KL_TMAZone1"
        Me.KL_TMAZone1.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMAZone1.TabIndex = 296
        Me.KL_TMAZone1.Text = "KremerLight2"
        Me.KL_TMAZone1.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMA_Zone2
        '
        Me.TMA_Zone2.BindControl = Me.KL_TMAZone2
        Me.TMA_Zone2.BindProperty = "Data"
        Me.TMA_Zone2.Data = Nothing
        Me.TMA_Zone2.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMA_Zone2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMA_Zone2.VariableName = "MAIN.InMoldDrying.TopMoldA.HeatingZone[2].ixThermal"
        '
        'KL_TMAZone2
        '
        Me.KL_TMAZone2.ColorOff = System.Drawing.Color.Red
        Me.KL_TMAZone2.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMAZone2.Data = False
        Me.KL_TMAZone2.Line = True
        Me.KL_TMAZone2.LineSize = 1
        Me.KL_TMAZone2.Location = New System.Drawing.Point(10, 108)
        Me.KL_TMAZone2.Name = "KL_TMAZone2"
        Me.KL_TMAZone2.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMAZone2.TabIndex = 298
        Me.KL_TMAZone2.Text = "KremerLight9"
        Me.KL_TMAZone2.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMA_Zone3
        '
        Me.TMA_Zone3.BindControl = Me.KL_TMAZone3
        Me.TMA_Zone3.BindProperty = "Data"
        Me.TMA_Zone3.Data = Nothing
        Me.TMA_Zone3.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMA_Zone3.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMA_Zone3.VariableName = "MAIN.InMoldDrying.TopMoldA.HeatingZone[3].ixThermal"
        '
        'KL_TMAZone3
        '
        Me.KL_TMAZone3.ColorOff = System.Drawing.Color.Red
        Me.KL_TMAZone3.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMAZone3.Data = False
        Me.KL_TMAZone3.Line = True
        Me.KL_TMAZone3.LineSize = 1
        Me.KL_TMAZone3.Location = New System.Drawing.Point(10, 129)
        Me.KL_TMAZone3.Name = "KL_TMAZone3"
        Me.KL_TMAZone3.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMAZone3.TabIndex = 300
        Me.KL_TMAZone3.Text = "KremerLight10"
        Me.KL_TMAZone3.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMA_Zone4
        '
        Me.TMA_Zone4.BindControl = Me.KL_TMAZone4
        Me.TMA_Zone4.BindProperty = "Data"
        Me.TMA_Zone4.Data = Nothing
        Me.TMA_Zone4.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMA_Zone4.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMA_Zone4.VariableName = "MAIN.InMoldDrying.TopMoldA.HeatingZone[4].ixThermal"
        '
        'KL_TMAZone4
        '
        Me.KL_TMAZone4.ColorOff = System.Drawing.Color.Red
        Me.KL_TMAZone4.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMAZone4.Data = False
        Me.KL_TMAZone4.Line = True
        Me.KL_TMAZone4.LineSize = 1
        Me.KL_TMAZone4.Location = New System.Drawing.Point(10, 150)
        Me.KL_TMAZone4.Name = "KL_TMAZone4"
        Me.KL_TMAZone4.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMAZone4.TabIndex = 302
        Me.KL_TMAZone4.Text = "KremerLight11"
        Me.KL_TMAZone4.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMA_Zone5
        '
        Me.TMA_Zone5.BindControl = Me.KL_TMAZone5
        Me.TMA_Zone5.BindProperty = "Data"
        Me.TMA_Zone5.Data = Nothing
        Me.TMA_Zone5.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMA_Zone5.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMA_Zone5.VariableName = "MAIN.InMoldDrying.TopMoldA.HeatingZone[5].ixThermal"
        '
        'KL_TMAZone5
        '
        Me.KL_TMAZone5.ColorOff = System.Drawing.Color.Red
        Me.KL_TMAZone5.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMAZone5.Data = False
        Me.KL_TMAZone5.Line = True
        Me.KL_TMAZone5.LineSize = 1
        Me.KL_TMAZone5.Location = New System.Drawing.Point(10, 171)
        Me.KL_TMAZone5.Name = "KL_TMAZone5"
        Me.KL_TMAZone5.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMAZone5.TabIndex = 304
        Me.KL_TMAZone5.Text = "KremerLight12"
        Me.KL_TMAZone5.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMB_HydraulicValve
        '
        Me.TMB_HydraulicValve.BindControl = Me.IO_TMBHydraulicValve
        Me.TMB_HydraulicValve.BindProperty = "Data"
        Me.TMB_HydraulicValve.Data = Nothing
        Me.TMB_HydraulicValve.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.TMB_HydraulicValve.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMB_HydraulicValve.VariableName = "MAIN.InMoldDrying.TopMoldB.HydraulicCilinder.HydraulicValve.qwOutput"
        '
        'IO_TMBHydraulicValve
        '
        Me.IO_TMBHydraulicValve.Audit = Nothing
        Me.IO_TMBHydraulicValve.AuditEnabled = False
        Me.IO_TMBHydraulicValve.AuditMessage = "KremerIoField changed:"
        Me.IO_TMBHydraulicValve.AuditSource = "KremerIoField"
        Me.IO_TMBHydraulicValve.AutoSize = True
        Me.IO_TMBHydraulicValve.Data = 0.0R
        Me.IO_TMBHydraulicValve.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TMBHydraulicValve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TMBHydraulicValve.InitialValue = True
        Me.IO_TMBHydraulicValve.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TMBHydraulicValve.Location = New System.Drawing.Point(6, 390)
        Me.IO_TMBHydraulicValve.LowerBound = 0.0R
        Me.IO_TMBHydraulicValve.Name = "IO_TMBHydraulicValve"
        Me.IO_TMBHydraulicValve.OutputFormat = "0.0 "
        Me.IO_TMBHydraulicValve.Size = New System.Drawing.Size(28, 16)
        Me.IO_TMBHydraulicValve.TabIndex = 316
        Me.IO_TMBHydraulicValve.Text = "0.0 "
        Me.IO_TMBHydraulicValve.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TMBHydraulicValve.UpperBound = 1000.0R
        Me.IO_TMBHydraulicValve.UserInfo = Nothing
        Me.IO_TMBHydraulicValve.UserLevel = 0
        '
        'TMA_Zone6
        '
        Me.TMA_Zone6.BindControl = Me.KL_TMAZone6
        Me.TMA_Zone6.BindProperty = "Data"
        Me.TMA_Zone6.Data = Nothing
        Me.TMA_Zone6.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMA_Zone6.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMA_Zone6.VariableName = "MAIN.InMoldDrying.TopMoldA.HeatingZone[6].ixThermal"
        '
        'KL_TMAZone6
        '
        Me.KL_TMAZone6.ColorOff = System.Drawing.Color.Red
        Me.KL_TMAZone6.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMAZone6.Data = False
        Me.KL_TMAZone6.Line = True
        Me.KL_TMAZone6.LineSize = 1
        Me.KL_TMAZone6.Location = New System.Drawing.Point(10, 192)
        Me.KL_TMAZone6.Name = "KL_TMAZone6"
        Me.KL_TMAZone6.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMAZone6.TabIndex = 306
        Me.KL_TMAZone6.Text = "KremerLight13"
        Me.KL_TMAZone6.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMA_Blowoff
        '
        Me.TMA_Blowoff.BindControl = Me.KL_TMABlowOff
        Me.TMA_Blowoff.BindProperty = "Data"
        Me.TMA_Blowoff.Data = Nothing
        Me.TMA_Blowoff.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMA_Blowoff.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMA_Blowoff.VariableName = "MAIN.InMoldDrying.TopMoldA.BlowOff.Q"
        '
        'KL_TMABlowOff
        '
        Me.KL_TMABlowOff.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMABlowOff.ColorOn = System.Drawing.Color.Lime
        Me.KL_TMABlowOff.Data = False
        Me.KL_TMABlowOff.Line = True
        Me.KL_TMABlowOff.LineSize = 1
        Me.KL_TMABlowOff.Location = New System.Drawing.Point(10, 305)
        Me.KL_TMABlowOff.Name = "KL_TMABlowOff"
        Me.KL_TMABlowOff.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMABlowOff.TabIndex = 290
        Me.KL_TMABlowOff.Text = "KremerLight2"
        Me.KL_TMABlowOff.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMA_Vacuum
        '
        Me.TMA_Vacuum.BindControl = Me.KL_TMAVacuum
        Me.TMA_Vacuum.BindProperty = "Data"
        Me.TMA_Vacuum.Data = Nothing
        Me.TMA_Vacuum.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMA_Vacuum.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMA_Vacuum.VariableName = "MAIN.InMoldDrying.TopMoldA.Vacuum.Q"
        '
        'KL_TMAVacuum
        '
        Me.KL_TMAVacuum.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMAVacuum.ColorOn = System.Drawing.Color.Lime
        Me.KL_TMAVacuum.Data = False
        Me.KL_TMAVacuum.Line = True
        Me.KL_TMAVacuum.LineSize = 1
        Me.KL_TMAVacuum.Location = New System.Drawing.Point(10, 325)
        Me.KL_TMAVacuum.Name = "KL_TMAVacuum"
        Me.KL_TMAVacuum.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMAVacuum.TabIndex = 292
        Me.KL_TMAVacuum.Text = "KremerLight4"
        Me.KL_TMAVacuum.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMA_MspaEnable
        '
        Me.TMA_MspaEnable.BindControl = Me.KL_TMA_MSPAEnable
        Me.TMA_MspaEnable.BindProperty = "Data"
        Me.TMA_MspaEnable.Data = Nothing
        Me.TMA_MspaEnable.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMA_MspaEnable.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMA_MspaEnable.VariableName = "MAIN.InMoldDrying.TopMoldA.HydraulicCilinder.qxMSPAEnable"
        '
        'KL_TMA_MSPAEnable
        '
        Me.KL_TMA_MSPAEnable.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMA_MSPAEnable.ColorOn = System.Drawing.Color.Lime
        Me.KL_TMA_MSPAEnable.Data = False
        Me.KL_TMA_MSPAEnable.Line = True
        Me.KL_TMA_MSPAEnable.LineSize = 1
        Me.KL_TMA_MSPAEnable.Location = New System.Drawing.Point(10, 345)
        Me.KL_TMA_MSPAEnable.Name = "KL_TMA_MSPAEnable"
        Me.KL_TMA_MSPAEnable.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMA_MSPAEnable.TabIndex = 294
        Me.KL_TMA_MSPAEnable.Text = "KremerLight3"
        Me.KL_TMA_MSPAEnable.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMB_EsA
        '
        Me.TMB_EsA.BindControl = Me.KL_TMB_EsA
        Me.TMB_EsA.BindProperty = "Data"
        Me.TMB_EsA.Data = Nothing
        Me.TMB_EsA.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMB_EsA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMB_EsA.VariableName = "MAIN.InMoldDrying.TopMoldB.HydraulicCilinder.ixEndSwitchA"
        '
        'KL_TMB_EsA
        '
        Me.KL_TMB_EsA.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMB_EsA.ColorOn = System.Drawing.Color.Lime
        Me.KL_TMB_EsA.Data = False
        Me.KL_TMB_EsA.Line = True
        Me.KL_TMB_EsA.LineSize = 1
        Me.KL_TMB_EsA.Location = New System.Drawing.Point(10, 25)
        Me.KL_TMB_EsA.Name = "KL_TMB_EsA"
        Me.KL_TMB_EsA.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMB_EsA.TabIndex = 290
        Me.KL_TMB_EsA.Text = "KremerLight5"
        Me.KL_TMB_EsA.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMB_EsB
        '
        Me.TMB_EsB.BindControl = Me.KL_TMA_EsB
        Me.TMB_EsB.BindProperty = "Data"
        Me.TMB_EsB.Data = Nothing
        Me.TMB_EsB.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMB_EsB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMB_EsB.VariableName = "MAIN.InMoldDrying.TopMoldB.HydraulicCilinder.ixEndSwitchB"
        '
        'TMB_MspaRTO
        '
        Me.TMB_MspaRTO.BindControl = Me.KL_TMB_MspaRTO
        Me.TMB_MspaRTO.BindProperty = "Data"
        Me.TMB_MspaRTO.Data = Nothing
        Me.TMB_MspaRTO.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMB_MspaRTO.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMB_MspaRTO.VariableName = "MAIN.InMoldDrying.TopMoldB.HydraulicCilinder.ixMSPAReadyToOperate"
        '
        'KL_TMB_MspaRTO
        '
        Me.KL_TMB_MspaRTO.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMB_MspaRTO.ColorOn = System.Drawing.Color.Lime
        Me.KL_TMB_MspaRTO.Data = False
        Me.KL_TMB_MspaRTO.Line = True
        Me.KL_TMB_MspaRTO.LineSize = 1
        Me.KL_TMB_MspaRTO.Location = New System.Drawing.Point(10, 67)
        Me.KL_TMB_MspaRTO.Name = "KL_TMB_MspaRTO"
        Me.KL_TMB_MspaRTO.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMB_MspaRTO.TabIndex = 294
        Me.KL_TMB_MspaRTO.Text = "KremerLight7"
        Me.KL_TMB_MspaRTO.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMB_ZoneError1
        '
        Me.TMB_ZoneError1.BindControl = Me.KL_TMBZone1
        Me.TMB_ZoneError1.BindProperty = "Data"
        Me.TMB_ZoneError1.Data = Nothing
        Me.TMB_ZoneError1.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMB_ZoneError1.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMB_ZoneError1.VariableName = "MAIN.InMoldDrying.TopMoldB.HeatingZone[1].ixThermal"
        '
        'KL_TMBZone1
        '
        Me.KL_TMBZone1.ColorOff = System.Drawing.Color.Red
        Me.KL_TMBZone1.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMBZone1.Data = False
        Me.KL_TMBZone1.Line = True
        Me.KL_TMBZone1.LineSize = 1
        Me.KL_TMBZone1.Location = New System.Drawing.Point(10, 87)
        Me.KL_TMBZone1.Name = "KL_TMBZone1"
        Me.KL_TMBZone1.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMBZone1.TabIndex = 296
        Me.KL_TMBZone1.Text = "KremerLight2"
        Me.KL_TMBZone1.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMB_ZoneError2
        '
        Me.TMB_ZoneError2.BindControl = Me.KL_TMBZone2
        Me.TMB_ZoneError2.BindProperty = "Data"
        Me.TMB_ZoneError2.Data = Nothing
        Me.TMB_ZoneError2.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMB_ZoneError2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMB_ZoneError2.VariableName = "MAIN.InMoldDrying.TopMoldB.HeatingZone[2].ixThermal"
        '
        'KL_TMBZone2
        '
        Me.KL_TMBZone2.ColorOff = System.Drawing.Color.Red
        Me.KL_TMBZone2.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMBZone2.Data = False
        Me.KL_TMBZone2.Line = True
        Me.KL_TMBZone2.LineSize = 1
        Me.KL_TMBZone2.Location = New System.Drawing.Point(10, 108)
        Me.KL_TMBZone2.Name = "KL_TMBZone2"
        Me.KL_TMBZone2.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMBZone2.TabIndex = 298
        Me.KL_TMBZone2.Text = "KremerLight9"
        Me.KL_TMBZone2.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMB_ZoneError3
        '
        Me.TMB_ZoneError3.BindControl = Me.KL_TMBZone3
        Me.TMB_ZoneError3.BindProperty = "Data"
        Me.TMB_ZoneError3.Data = Nothing
        Me.TMB_ZoneError3.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMB_ZoneError3.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMB_ZoneError3.VariableName = "MAIN.InMoldDrying.TopMoldB.HeatingZone[3].ixThermal"
        '
        'KL_TMBZone3
        '
        Me.KL_TMBZone3.ColorOff = System.Drawing.Color.Red
        Me.KL_TMBZone3.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMBZone3.Data = False
        Me.KL_TMBZone3.Line = True
        Me.KL_TMBZone3.LineSize = 1
        Me.KL_TMBZone3.Location = New System.Drawing.Point(10, 129)
        Me.KL_TMBZone3.Name = "KL_TMBZone3"
        Me.KL_TMBZone3.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMBZone3.TabIndex = 300
        Me.KL_TMBZone3.Text = "KremerLight10"
        Me.KL_TMBZone3.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMB_ZoneError4
        '
        Me.TMB_ZoneError4.BindControl = Me.KL_TMBZone4
        Me.TMB_ZoneError4.BindProperty = "Data"
        Me.TMB_ZoneError4.Data = Nothing
        Me.TMB_ZoneError4.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMB_ZoneError4.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMB_ZoneError4.VariableName = "MAIN.InMoldDrying.TopMoldB.HeatingZone[4].ixThermal"
        '
        'KL_TMBZone4
        '
        Me.KL_TMBZone4.ColorOff = System.Drawing.Color.Red
        Me.KL_TMBZone4.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMBZone4.Data = False
        Me.KL_TMBZone4.Line = True
        Me.KL_TMBZone4.LineSize = 1
        Me.KL_TMBZone4.Location = New System.Drawing.Point(10, 150)
        Me.KL_TMBZone4.Name = "KL_TMBZone4"
        Me.KL_TMBZone4.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMBZone4.TabIndex = 302
        Me.KL_TMBZone4.Text = "KremerLight11"
        Me.KL_TMBZone4.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMB_ZoneError5
        '
        Me.TMB_ZoneError5.BindControl = Me.KL_TMBZone5
        Me.TMB_ZoneError5.BindProperty = "Data"
        Me.TMB_ZoneError5.Data = Nothing
        Me.TMB_ZoneError5.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMB_ZoneError5.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMB_ZoneError5.VariableName = "MAIN.InMoldDrying.TopMoldB.HeatingZone[5].ixThermal"
        '
        'KL_TMBZone5
        '
        Me.KL_TMBZone5.ColorOff = System.Drawing.Color.Red
        Me.KL_TMBZone5.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMBZone5.Data = False
        Me.KL_TMBZone5.Line = True
        Me.KL_TMBZone5.LineSize = 1
        Me.KL_TMBZone5.Location = New System.Drawing.Point(10, 171)
        Me.KL_TMBZone5.Name = "KL_TMBZone5"
        Me.KL_TMBZone5.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMBZone5.TabIndex = 304
        Me.KL_TMBZone5.Text = "KremerLight12"
        Me.KL_TMBZone5.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMB_ZoneError6
        '
        Me.TMB_ZoneError6.BindControl = Me.KL_TMBZone6
        Me.TMB_ZoneError6.BindProperty = "Data"
        Me.TMB_ZoneError6.Data = Nothing
        Me.TMB_ZoneError6.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMB_ZoneError6.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMB_ZoneError6.VariableName = "MAIN.InMoldDrying.TopMoldB.HeatingZone[6].ixThermal"
        '
        'KL_TMBZone6
        '
        Me.KL_TMBZone6.ColorOff = System.Drawing.Color.Red
        Me.KL_TMBZone6.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMBZone6.Data = False
        Me.KL_TMBZone6.Line = True
        Me.KL_TMBZone6.LineSize = 1
        Me.KL_TMBZone6.Location = New System.Drawing.Point(10, 192)
        Me.KL_TMBZone6.Name = "KL_TMBZone6"
        Me.KL_TMBZone6.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMBZone6.TabIndex = 306
        Me.KL_TMBZone6.Text = "KremerLight13"
        Me.KL_TMBZone6.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMB_Blowoff
        '
        Me.TMB_Blowoff.BindControl = Me.KL_TMBBlowOff
        Me.TMB_Blowoff.BindProperty = "Data"
        Me.TMB_Blowoff.Data = Nothing
        Me.TMB_Blowoff.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMB_Blowoff.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMB_Blowoff.VariableName = "MAIN.InMoldDrying.TopMoldB.BlowOff.Q"
        '
        'KL_TMBBlowOff
        '
        Me.KL_TMBBlowOff.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMBBlowOff.ColorOn = System.Drawing.Color.Lime
        Me.KL_TMBBlowOff.Data = False
        Me.KL_TMBBlowOff.Line = True
        Me.KL_TMBBlowOff.LineSize = 1
        Me.KL_TMBBlowOff.Location = New System.Drawing.Point(10, 305)
        Me.KL_TMBBlowOff.Name = "KL_TMBBlowOff"
        Me.KL_TMBBlowOff.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMBBlowOff.TabIndex = 290
        Me.KL_TMBBlowOff.Text = "KremerLight2"
        Me.KL_TMBBlowOff.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMB_Vacuum
        '
        Me.TMB_Vacuum.BindControl = Me.KL_TMBVacuum
        Me.TMB_Vacuum.BindProperty = "Data"
        Me.TMB_Vacuum.Data = Nothing
        Me.TMB_Vacuum.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMB_Vacuum.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMB_Vacuum.VariableName = "MAIN.InMoldDrying.TopMoldB.Vacuum.Q"
        '
        'KL_TMBVacuum
        '
        Me.KL_TMBVacuum.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMBVacuum.ColorOn = System.Drawing.Color.Lime
        Me.KL_TMBVacuum.Data = False
        Me.KL_TMBVacuum.Line = True
        Me.KL_TMBVacuum.LineSize = 1
        Me.KL_TMBVacuum.Location = New System.Drawing.Point(10, 325)
        Me.KL_TMBVacuum.Name = "KL_TMBVacuum"
        Me.KL_TMBVacuum.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMBVacuum.TabIndex = 292
        Me.KL_TMBVacuum.Text = "KremerLight4"
        Me.KL_TMBVacuum.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMB_MspaEnable
        '
        Me.TMB_MspaEnable.BindControl = Me.KL_TMB_MSPAEnable
        Me.TMB_MspaEnable.BindProperty = "Data"
        Me.TMB_MspaEnable.Data = Nothing
        Me.TMB_MspaEnable.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMB_MspaEnable.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMB_MspaEnable.VariableName = "MAIN.InMoldDrying.TopMoldB.HydraulicCilinder.qxMSPAEnable"
        '
        'KL_TMB_MSPAEnable
        '
        Me.KL_TMB_MSPAEnable.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMB_MSPAEnable.ColorOn = System.Drawing.Color.Lime
        Me.KL_TMB_MSPAEnable.Data = False
        Me.KL_TMB_MSPAEnable.Line = True
        Me.KL_TMB_MSPAEnable.LineSize = 1
        Me.KL_TMB_MSPAEnable.Location = New System.Drawing.Point(10, 345)
        Me.KL_TMB_MSPAEnable.Name = "KL_TMB_MSPAEnable"
        Me.KL_TMB_MSPAEnable.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMB_MSPAEnable.TabIndex = 294
        Me.KL_TMB_MSPAEnable.Text = "KremerLight3"
        Me.KL_TMB_MSPAEnable.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(68, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 20)
        Me.Label5.TabIndex = 291
        Me.Label5.Tag = ""
        Me.Label5.Text = "End switch A"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 20)
        Me.Label1.TabIndex = 293
        Me.Label1.Tag = ""
        Me.Label1.Text = "End switch B"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 20)
        Me.Label3.TabIndex = 295
        Me.Label3.Tag = ""
        Me.Label3.Text = "MSPA ready to operate"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.IO_TMAHydraulicValve)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.KL_TMABlowOff)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.KL_TMA_MSPAEnable)
        Me.GroupBox1.Controls.Add(Me.IO_TMABotSidePressure)
        Me.GroupBox1.Controls.Add(Me.KL_TMAVacuum)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.IO_TMA_RodSidePressure)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.KL_TMAZone2)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.KL_TMA_EsA)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.KL_TMA_EsB)
        Me.GroupBox1.Controls.Add(Me.KL_TMA_MspaRTO)
        Me.GroupBox1.Controls.Add(Me.KL_TMAZone1)
        Me.GroupBox1.Controls.Add(Me.KL_TMAZone3)
        Me.GroupBox1.Controls.Add(Me.KL_TMAZone4)
        Me.GroupBox1.Controls.Add(Me.KL_TMAZone5)
        Me.GroupBox1.Controls.Add(Me.KL_TMAZone6)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 429)
        Me.GroupBox1.TabIndex = 306
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Top mold A"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(67, 386)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(181, 20)
        Me.Label10.TabIndex = 317
        Me.Label10.Tag = ""
        Me.Label10.Text = "Hydraulic valve"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 366)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(242, 20)
        Me.Label9.TabIndex = 315
        Me.Label9.Tag = ""
        Me.Label9.Text = "Analog Outputs"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(242, 20)
        Me.Label8.TabIndex = 314
        Me.Label8.Tag = ""
        Me.Label8.Text = "Outputs"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(241, 20)
        Me.Label4.TabIndex = 313
        Me.Label4.Tag = ""
        Me.Label4.Text = "Analog inputs"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 346)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 20)
        Me.Label2.TabIndex = 295
        Me.Label2.Tag = ""
        Me.Label2.Text = "MSPA enable"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(68, 229)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(180, 20)
        Me.Label11.TabIndex = 309
        Me.Label11.Tag = ""
        Me.Label11.Text = "Rod side pressure"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(67, 325)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 20)
        Me.Label6.TabIndex = 293
        Me.Label6.Tag = ""
        Me.Label6.Text = "Vacuum"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(67, 305)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 20)
        Me.Label7.TabIndex = 291
        Me.Label7.Tag = ""
        Me.Label7.Text = "Blowoff"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(68, 247)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(181, 20)
        Me.Label13.TabIndex = 310
        Me.Label13.Tag = ""
        Me.Label13.Text = "Bot side pressure"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(68, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(181, 20)
        Me.Label12.TabIndex = 297
        Me.Label12.Tag = ""
        Me.Label12.Text = "Zone 1 Thermal error"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(68, 192)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(181, 20)
        Me.Label19.TabIndex = 307
        Me.Label19.Tag = ""
        Me.Label19.Text = "Zone 6 Thermal error"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(68, 171)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(181, 20)
        Me.Label18.TabIndex = 305
        Me.Label18.Tag = ""
        Me.Label18.Text = "Zone 5 Thermal error"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(68, 150)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(181, 20)
        Me.Label17.TabIndex = 303
        Me.Label17.Tag = ""
        Me.Label17.Text = "Zone 4 Thermal error"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(68, 129)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(181, 20)
        Me.Label16.TabIndex = 301
        Me.Label16.Tag = ""
        Me.Label16.Text = "Zone 3 Thermal error"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(68, 108)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(181, 20)
        Me.Label15.TabIndex = 299
        Me.Label15.Tag = ""
        Me.Label15.Text = "Zone 2 Thermal error"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.IO_TMBHydraulicValve)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.KL_TMBBlowOff)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.KL_TMB_MSPAEnable)
        Me.GroupBox2.Controls.Add(Me.IO_TMBBotSidePressure)
        Me.GroupBox2.Controls.Add(Me.KL_TMBVacuum)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.IO_TMB_RodSidePressure)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.KL_TMBZone2)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.KL_TMB_EsA)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.KL_TMB_EsB)
        Me.GroupBox2.Controls.Add(Me.KL_TMB_MspaRTO)
        Me.GroupBox2.Controls.Add(Me.KL_TMBZone1)
        Me.GroupBox2.Controls.Add(Me.KL_TMBZone3)
        Me.GroupBox2.Controls.Add(Me.KL_TMBZone4)
        Me.GroupBox2.Controls.Add(Me.KL_TMBZone5)
        Me.GroupBox2.Controls.Add(Me.KL_TMBZone6)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(267, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 429)
        Me.GroupBox2.TabIndex = 318
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Top mold B"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(67, 386)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(181, 20)
        Me.Label20.TabIndex = 317
        Me.Label20.Tag = ""
        Me.Label20.Text = "Hydraulic valve"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 366)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(242, 20)
        Me.Label21.TabIndex = 315
        Me.Label21.Tag = ""
        Me.Label21.Text = "Analog Outputs"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 285)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(242, 20)
        Me.Label22.TabIndex = 314
        Me.Label22.Tag = ""
        Me.Label22.Text = "Outputs"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(7, 213)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(241, 20)
        Me.Label23.TabIndex = 313
        Me.Label23.Tag = ""
        Me.Label23.Text = "Analog inputs"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(67, 346)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(181, 20)
        Me.Label24.TabIndex = 295
        Me.Label24.Tag = ""
        Me.Label24.Text = "MSPA enable"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(68, 229)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(180, 20)
        Me.Label25.TabIndex = 309
        Me.Label25.Tag = ""
        Me.Label25.Text = "Rod side pressure"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(67, 325)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(181, 20)
        Me.Label26.TabIndex = 293
        Me.Label26.Tag = ""
        Me.Label26.Text = "Vacuum"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(68, 25)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(181, 20)
        Me.Label27.TabIndex = 291
        Me.Label27.Tag = ""
        Me.Label27.Text = "End switch A"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(67, 305)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(181, 20)
        Me.Label29.TabIndex = 291
        Me.Label29.Tag = ""
        Me.Label29.Text = "Blowoff"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(68, 247)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(181, 20)
        Me.Label30.TabIndex = 310
        Me.Label30.Tag = ""
        Me.Label30.Text = "Bot side pressure"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(68, 46)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(181, 20)
        Me.Label31.TabIndex = 293
        Me.Label31.Tag = ""
        Me.Label31.Text = "End switch B"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(68, 87)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(181, 20)
        Me.Label32.TabIndex = 297
        Me.Label32.Tag = ""
        Me.Label32.Text = "Zone 1 Thermal error"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(68, 192)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(181, 20)
        Me.Label33.TabIndex = 307
        Me.Label33.Tag = ""
        Me.Label33.Text = "Zone 6 Thermal error"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(68, 171)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(181, 20)
        Me.Label34.TabIndex = 305
        Me.Label34.Tag = ""
        Me.Label34.Text = "Zone 5 Thermal error"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(68, 150)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(181, 20)
        Me.Label35.TabIndex = 303
        Me.Label35.Tag = ""
        Me.Label35.Text = "Zone 4 Thermal error"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(68, 67)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(181, 20)
        Me.Label36.TabIndex = 295
        Me.Label36.Tag = ""
        Me.Label36.Text = "MSPA ready to operate"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(68, 129)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(181, 20)
        Me.Label37.TabIndex = 301
        Me.Label37.Tag = ""
        Me.Label37.Text = "Zone 3 Thermal error"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(68, 108)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(181, 20)
        Me.Label38.TabIndex = 299
        Me.Label38.Tag = ""
        Me.Label38.Text = "Zone 2 Thermal error"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_TMB_EsB
        '
        Me.KL_TMB_EsB.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMB_EsB.ColorOn = System.Drawing.Color.Lime
        Me.KL_TMB_EsB.Data = False
        Me.KL_TMB_EsB.Line = True
        Me.KL_TMB_EsB.LineSize = 1
        Me.KL_TMB_EsB.Location = New System.Drawing.Point(10, 46)
        Me.KL_TMB_EsB.Name = "KL_TMB_EsB"
        Me.KL_TMB_EsB.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMB_EsB.TabIndex = 292
        Me.KL_TMB_EsB.Text = "KremerLight6"
        Me.KL_TMB_EsB.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'IO_TopMolds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "IO_TopMolds"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "540"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents KL_TMA_EsB As KremerControlsWin32.KremerLight
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents KL_TMA_EsA As KremerControlsWin32.KremerLight
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents KL_TMA_MspaRTO As KremerControlsWin32.KremerLight
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents KL_TMAZone4 As KremerControlsWin32.KremerLight
    Friend WithEvents KL_TMAZone5 As KremerControlsWin32.KremerLight
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents KL_TMAZone6 As KremerControlsWin32.KremerLight
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents KL_TMAZone1 As KremerControlsWin32.KremerLight
    Friend WithEvents KL_TMAZone2 As KremerControlsWin32.KremerLight
    Friend WithEvents IO_TMABotSidePressure As KremerControlsWin32.KremerIoField
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents KL_TMAZone3 As KremerControlsWin32.KremerLight
    Friend WithEvents IO_TMA_RodSidePressure As KremerControlsWin32.KremerIoField
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents KL_TMABlowOff As KremerControlsWin32.KremerLight
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents KL_TMA_MSPAEnable As KremerControlsWin32.KremerLight
    Friend WithEvents KL_TMAVacuum As KremerControlsWin32.KremerLight
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents IO_TMAHydraulicValve As KremerControlsWin32.KremerIoField
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents IO_TMBHydraulicValve As KremerControlsWin32.KremerIoField
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents KL_TMBBlowOff As KremerControlsWin32.KremerLight
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents KL_TMB_MSPAEnable As KremerControlsWin32.KremerLight
    Friend WithEvents IO_TMBBotSidePressure As KremerControlsWin32.KremerIoField
    Friend WithEvents KL_TMBVacuum As KremerControlsWin32.KremerLight
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents IO_TMB_RodSidePressure As KremerControlsWin32.KremerIoField
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents KL_TMBZone2 As KremerControlsWin32.KremerLight
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents KL_TMB_EsA As KremerControlsWin32.KremerLight
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents KL_TMB_EsB As KremerControlsWin32.KremerLight
    Friend WithEvents KL_TMB_MspaRTO As KremerControlsWin32.KremerLight
    Friend WithEvents KL_TMBZone1 As KremerControlsWin32.KremerLight
    Friend WithEvents KL_TMBZone3 As KremerControlsWin32.KremerLight
    Friend WithEvents KL_TMBZone4 As KremerControlsWin32.KremerLight
    Friend WithEvents KL_TMBZone5 As KremerControlsWin32.KremerLight
    Friend WithEvents KL_TMBZone6 As KremerControlsWin32.KremerLight
    Friend WithEvents TMA_EsA As KremerControlsWin32.KremerVariable
    Friend WithEvents TMA_EsB As KremerControlsWin32.KremerVariable
    Friend WithEvents TMA_MspaRTO As KremerControlsWin32.KremerVariable
    Friend WithEvents TMA_Zone1 As KremerControlsWin32.KremerVariable
    Friend WithEvents TMA_Zone2 As KremerControlsWin32.KremerVariable
    Friend WithEvents TMA_Zone3 As KremerControlsWin32.KremerVariable
    Friend WithEvents TMA_Zone4 As KremerControlsWin32.KremerVariable
    Friend WithEvents TMA_Zone5 As KremerControlsWin32.KremerVariable
    Friend WithEvents TMA_Zone6 As KremerControlsWin32.KremerVariable
    Friend WithEvents TMA_Rod As KremerControlsWin32.KremerVariable
    Friend WithEvents TMA_Bot As KremerControlsWin32.KremerVariable
    Friend WithEvents TMA_Blowoff As KremerControlsWin32.KremerVariable
    Friend WithEvents TMA_Vacuum As KremerControlsWin32.KremerVariable
    Friend WithEvents TMA_MspaEnable As KremerControlsWin32.KremerVariable
    Friend WithEvents TMA_HydraulicValve As KremerControlsWin32.KremerVariable
    Friend WithEvents TMB_EsA As KremerControlsWin32.KremerVariable
    Friend WithEvents TMB_EsB As KremerControlsWin32.KremerVariable
    Friend WithEvents TMB_MspaRTO As KremerControlsWin32.KremerVariable
    Friend WithEvents TMB_ZoneError1 As KremerControlsWin32.KremerVariable
    Friend WithEvents TMB_ZoneError2 As KremerControlsWin32.KremerVariable
    Friend WithEvents TMB_ZoneError3 As KremerControlsWin32.KremerVariable
    Friend WithEvents TMB_ZoneError4 As KremerControlsWin32.KremerVariable
    Friend WithEvents TMB_ZoneError5 As KremerControlsWin32.KremerVariable
    Friend WithEvents TMB_ZoneError6 As KremerControlsWin32.KremerVariable
    Friend WithEvents TMB_Rod As KremerControlsWin32.KremerVariable
    Friend WithEvents TMB_Bot As KremerControlsWin32.KremerVariable
    Friend WithEvents TMB_Blowoff As KremerControlsWin32.KremerVariable
    Friend WithEvents TMB_Vacuum As KremerControlsWin32.KremerVariable
    Friend WithEvents TMB_MspaEnable As KremerControlsWin32.KremerVariable
    Friend WithEvents TMB_HydraulicValve As KremerControlsWin32.KremerVariable

End Class
