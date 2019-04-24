<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DryingMold_Manual
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
        Me.TopBlowOff = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnTopBlowOffOn = New KremerControlsWin32.KremerButton()
        Me.TopVacuum = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnTopVacuumOn = New KremerControlsWin32.KremerButton()
        Me.TopHydrUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnTopHydrUp = New KremerControlsWin32.KremerButton()
        Me.TopHydrUpSlow = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnTopHydrUpSlow = New KremerControlsWin32.KremerButton()
        Me.TopHydrUpCreep = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnTopHydrUpCreep = New KremerControlsWin32.KremerButton()
        Me.TopHydrDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnTopHydrDown = New KremerControlsWin32.KremerButton()
        Me.TopHydrDownSlow = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnTopHydrDownSlow = New KremerControlsWin32.KremerButton()
        Me.TopHydrDownCreep = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnTopHydrDownCreep = New KremerControlsWin32.KremerButton()
        Me.BottomVacuum = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnBotVacuumOn = New KremerControlsWin32.KremerButton()
        Me.BM_In = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnBotHydrIn = New KremerControlsWin32.KremerButton()
        Me.BM_Out = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnBotHydrOut = New KremerControlsWin32.KremerButton()
        Me.TopPos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TopPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.BotPos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_BotPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Btn_Overview = New KremerControlsWin32.KremerButton()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_puh = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Me.VarCollector
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.mxAutomode)
        Me.VarCollector.Variables.Add(Me.TopBlowOff)
        Me.VarCollector.Variables.Add(Me.TopVacuum)
        Me.VarCollector.Variables.Add(Me.TopHydrUp)
        Me.VarCollector.Variables.Add(Me.TopHydrUpSlow)
        Me.VarCollector.Variables.Add(Me.TopHydrUpCreep)
        Me.VarCollector.Variables.Add(Me.TopHydrDown)
        Me.VarCollector.Variables.Add(Me.TopHydrDownSlow)
        Me.VarCollector.Variables.Add(Me.TopHydrDownCreep)
        Me.VarCollector.Variables.Add(Me.BottomVacuum)
        Me.VarCollector.Variables.Add(Me.BM_In)
        Me.VarCollector.Variables.Add(Me.BM_Out)
        Me.VarCollector.Variables.Add(Me.TopPos)
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
        'TopBlowOff
        '
        Me.TopBlowOff.BindControl = Me.BtnTopBlowOffOn
        Me.TopBlowOff.BindProperty = "Data"
        Me.TopBlowOff.Data = Nothing
        Me.TopBlowOff.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TopBlowOff.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TopBlowOff.VariableName = "MAIN.InMoldDrying.Top[Position1].BlowOff.mxHMI_On"
        '
        'BtnTopBlowOffOn
        '
        Me.BtnTopBlowOffOn.Audit = Nothing
        Me.BtnTopBlowOffOn.AuditEnabled = False
        Me.BtnTopBlowOffOn.AuditMessage = "KremerPushButton pressed!"
        Me.BtnTopBlowOffOn.AuditSource = "KremerPushButton"
        Me.BtnTopBlowOffOn.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnTopBlowOffOn.BackGroundImageOn = Nothing
        Me.BtnTopBlowOffOn.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.BtnTopBlowOffOn.Data = False
        Me.BtnTopBlowOffOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTopBlowOffOn.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnTopBlowOffOn.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnTopBlowOffOn.Location = New System.Drawing.Point(290, 38)
        Me.BtnTopBlowOffOn.Name = "BtnTopBlowOffOn"
        Me.BtnTopBlowOffOn.Size = New System.Drawing.Size(106, 36)
        Me.BtnTopBlowOffOn.State = False
        Me.BtnTopBlowOffOn.StateIsData = True
        Me.BtnTopBlowOffOn.StateText = New String() {Nothing, Nothing}
        Me.BtnTopBlowOffOn.TabIndex = 315
        Me.BtnTopBlowOffOn.Tag = "26"
        Me.BtnTopBlowOffOn.Text = "On"
        Me.BtnTopBlowOffOn.UserInfo = Nothing
        Me.BtnTopBlowOffOn.UserLevel = 0
        Me.BtnTopBlowOffOn.UseStateText = False
        '
        'TopVacuum
        '
        Me.TopVacuum.BindControl = Me.BtnTopVacuumOn
        Me.TopVacuum.BindProperty = "Data"
        Me.TopVacuum.Data = Nothing
        Me.TopVacuum.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TopVacuum.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TopVacuum.VariableName = "MAIN.InMoldDrying.Top[Position1].Vacuum.mxHMI_On"
        '
        'BtnTopVacuumOn
        '
        Me.BtnTopVacuumOn.Audit = Nothing
        Me.BtnTopVacuumOn.AuditEnabled = False
        Me.BtnTopVacuumOn.AuditMessage = "KremerPushButton pressed!"
        Me.BtnTopVacuumOn.AuditSource = "KremerPushButton"
        Me.BtnTopVacuumOn.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnTopVacuumOn.BackGroundImageOn = Nothing
        Me.BtnTopVacuumOn.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.BtnTopVacuumOn.Data = False
        Me.BtnTopVacuumOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTopVacuumOn.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnTopVacuumOn.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnTopVacuumOn.Location = New System.Drawing.Point(290, 80)
        Me.BtnTopVacuumOn.Name = "BtnTopVacuumOn"
        Me.BtnTopVacuumOn.Size = New System.Drawing.Size(106, 36)
        Me.BtnTopVacuumOn.State = False
        Me.BtnTopVacuumOn.StateIsData = True
        Me.BtnTopVacuumOn.StateText = New String() {Nothing, Nothing}
        Me.BtnTopVacuumOn.TabIndex = 326
        Me.BtnTopVacuumOn.Tag = "26"
        Me.BtnTopVacuumOn.Text = "On"
        Me.BtnTopVacuumOn.UserInfo = Nothing
        Me.BtnTopVacuumOn.UserLevel = 0
        Me.BtnTopVacuumOn.UseStateText = False
        '
        'TopHydrUp
        '
        Me.TopHydrUp.BindControl = Me.BtnTopHydrUp
        Me.TopHydrUp.BindProperty = "Data"
        Me.TopHydrUp.Data = Nothing
        Me.TopHydrUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TopHydrUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TopHydrUp.VariableName = "MAIN.InMoldDrying.Top[Position1].HydraulicCilinder.ManUp"
        '
        'BtnTopHydrUp
        '
        Me.BtnTopHydrUp.Audit = Nothing
        Me.BtnTopHydrUp.AuditEnabled = False
        Me.BtnTopHydrUp.AuditMessage = "KremerPushButton pressed!"
        Me.BtnTopHydrUp.AuditSource = "KremerPushButton"
        Me.BtnTopHydrUp.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnTopHydrUp.BackGroundImageOn = Nothing
        Me.BtnTopHydrUp.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnTopHydrUp.Data = False
        Me.BtnTopHydrUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTopHydrUp.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnTopHydrUp.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnTopHydrUp.Location = New System.Drawing.Point(178, 168)
        Me.BtnTopHydrUp.Name = "BtnTopHydrUp"
        Me.BtnTopHydrUp.Size = New System.Drawing.Size(106, 36)
        Me.BtnTopHydrUp.State = False
        Me.BtnTopHydrUp.StateIsData = True
        Me.BtnTopHydrUp.StateText = New String() {Nothing, Nothing}
        Me.BtnTopHydrUp.TabIndex = 322
        Me.BtnTopHydrUp.Tag = "29"
        Me.BtnTopHydrUp.Text = "Up"
        Me.BtnTopHydrUp.UserInfo = Nothing
        Me.BtnTopHydrUp.UserLevel = 0
        Me.BtnTopHydrUp.UseStateText = False
        '
        'TopHydrUpSlow
        '
        Me.TopHydrUpSlow.BindControl = Me.BtnTopHydrUpSlow
        Me.TopHydrUpSlow.BindProperty = "Data"
        Me.TopHydrUpSlow.Data = Nothing
        Me.TopHydrUpSlow.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TopHydrUpSlow.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TopHydrUpSlow.VariableName = "MAIN.InMoldDrying.Top[Position1].HydraulicCilinder.ManSlowUp"
        '
        'BtnTopHydrUpSlow
        '
        Me.BtnTopHydrUpSlow.Audit = Nothing
        Me.BtnTopHydrUpSlow.AuditEnabled = False
        Me.BtnTopHydrUpSlow.AuditMessage = "KremerPushButton pressed!"
        Me.BtnTopHydrUpSlow.AuditSource = "KremerPushButton"
        Me.BtnTopHydrUpSlow.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnTopHydrUpSlow.BackGroundImageOn = Nothing
        Me.BtnTopHydrUpSlow.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnTopHydrUpSlow.Data = False
        Me.BtnTopHydrUpSlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTopHydrUpSlow.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnTopHydrUpSlow.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnTopHydrUpSlow.Location = New System.Drawing.Point(178, 210)
        Me.BtnTopHydrUpSlow.Name = "BtnTopHydrUpSlow"
        Me.BtnTopHydrUpSlow.Size = New System.Drawing.Size(106, 36)
        Me.BtnTopHydrUpSlow.State = False
        Me.BtnTopHydrUpSlow.StateIsData = True
        Me.BtnTopHydrUpSlow.StateText = New String() {Nothing, Nothing}
        Me.BtnTopHydrUpSlow.TabIndex = 324
        Me.BtnTopHydrUpSlow.Tag = "295"
        Me.BtnTopHydrUpSlow.Text = "Up slow"
        Me.BtnTopHydrUpSlow.UserInfo = Nothing
        Me.BtnTopHydrUpSlow.UserLevel = 0
        Me.BtnTopHydrUpSlow.UseStateText = False
        Me.BtnTopHydrUpSlow.UseVisualStyleBackColor = False
        '
        'TopHydrUpCreep
        '
        Me.TopHydrUpCreep.BindControl = Me.BtnTopHydrUpCreep
        Me.TopHydrUpCreep.BindProperty = "Data"
        Me.TopHydrUpCreep.Data = Nothing
        Me.TopHydrUpCreep.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TopHydrUpCreep.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TopHydrUpCreep.VariableName = "MAIN.InMoldDrying.Top[Position1].HydraulicCilinder.ManCreepUp"
        '
        'BtnTopHydrUpCreep
        '
        Me.BtnTopHydrUpCreep.Audit = Nothing
        Me.BtnTopHydrUpCreep.AuditEnabled = False
        Me.BtnTopHydrUpCreep.AuditMessage = "KremerPushButton pressed!"
        Me.BtnTopHydrUpCreep.AuditSource = "KremerPushButton"
        Me.BtnTopHydrUpCreep.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnTopHydrUpCreep.BackGroundImageOn = Nothing
        Me.BtnTopHydrUpCreep.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnTopHydrUpCreep.Data = False
        Me.BtnTopHydrUpCreep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTopHydrUpCreep.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnTopHydrUpCreep.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnTopHydrUpCreep.Location = New System.Drawing.Point(178, 252)
        Me.BtnTopHydrUpCreep.Name = "BtnTopHydrUpCreep"
        Me.BtnTopHydrUpCreep.Size = New System.Drawing.Size(106, 36)
        Me.BtnTopHydrUpCreep.State = False
        Me.BtnTopHydrUpCreep.StateIsData = True
        Me.BtnTopHydrUpCreep.StateText = New String() {Nothing, Nothing}
        Me.BtnTopHydrUpCreep.TabIndex = 341
        Me.BtnTopHydrUpCreep.Tag = "297"
        Me.BtnTopHydrUpCreep.Text = "Up creep"
        Me.BtnTopHydrUpCreep.UserInfo = Nothing
        Me.BtnTopHydrUpCreep.UserLevel = 0
        Me.BtnTopHydrUpCreep.UseStateText = False
        Me.BtnTopHydrUpCreep.UseVisualStyleBackColor = False
        '
        'TopHydrDown
        '
        Me.TopHydrDown.BindControl = Me.BtnTopHydrDown
        Me.TopHydrDown.BindProperty = "Data"
        Me.TopHydrDown.Data = Nothing
        Me.TopHydrDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TopHydrDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TopHydrDown.VariableName = "MAIN.InMoldDrying.Top[Position1].HydraulicCilinder.ManDown"
        '
        'BtnTopHydrDown
        '
        Me.BtnTopHydrDown.Audit = Nothing
        Me.BtnTopHydrDown.AuditEnabled = False
        Me.BtnTopHydrDown.AuditMessage = "KremerPushButton pressed!"
        Me.BtnTopHydrDown.AuditSource = "KremerPushButton"
        Me.BtnTopHydrDown.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnTopHydrDown.BackGroundImageOn = Nothing
        Me.BtnTopHydrDown.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnTopHydrDown.Data = False
        Me.BtnTopHydrDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTopHydrDown.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnTopHydrDown.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnTopHydrDown.Location = New System.Drawing.Point(290, 168)
        Me.BtnTopHydrDown.Name = "BtnTopHydrDown"
        Me.BtnTopHydrDown.Size = New System.Drawing.Size(106, 36)
        Me.BtnTopHydrDown.State = False
        Me.BtnTopHydrDown.StateIsData = True
        Me.BtnTopHydrDown.StateText = New String() {Nothing, Nothing}
        Me.BtnTopHydrDown.TabIndex = 323
        Me.BtnTopHydrDown.Tag = "30"
        Me.BtnTopHydrDown.Text = "Down"
        Me.BtnTopHydrDown.UserInfo = Nothing
        Me.BtnTopHydrDown.UserLevel = 0
        Me.BtnTopHydrDown.UseStateText = False
        '
        'TopHydrDownSlow
        '
        Me.TopHydrDownSlow.BindControl = Me.BtnTopHydrDownSlow
        Me.TopHydrDownSlow.BindProperty = "Data"
        Me.TopHydrDownSlow.Data = Nothing
        Me.TopHydrDownSlow.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TopHydrDownSlow.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TopHydrDownSlow.VariableName = "MAIN.InMoldDrying.Top[Position1].HydraulicCilinder.ManSlowDown"
        '
        'BtnTopHydrDownSlow
        '
        Me.BtnTopHydrDownSlow.Audit = Nothing
        Me.BtnTopHydrDownSlow.AuditEnabled = False
        Me.BtnTopHydrDownSlow.AuditMessage = "KremerPushButton pressed!"
        Me.BtnTopHydrDownSlow.AuditSource = "KremerPushButton"
        Me.BtnTopHydrDownSlow.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnTopHydrDownSlow.BackGroundImageOn = Nothing
        Me.BtnTopHydrDownSlow.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnTopHydrDownSlow.Data = False
        Me.BtnTopHydrDownSlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTopHydrDownSlow.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnTopHydrDownSlow.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnTopHydrDownSlow.Location = New System.Drawing.Point(290, 210)
        Me.BtnTopHydrDownSlow.Name = "BtnTopHydrDownSlow"
        Me.BtnTopHydrDownSlow.Size = New System.Drawing.Size(106, 36)
        Me.BtnTopHydrDownSlow.State = False
        Me.BtnTopHydrDownSlow.StateIsData = True
        Me.BtnTopHydrDownSlow.StateText = New String() {Nothing, Nothing}
        Me.BtnTopHydrDownSlow.TabIndex = 342
        Me.BtnTopHydrDownSlow.Tag = "296"
        Me.BtnTopHydrDownSlow.Text = "Down slow"
        Me.BtnTopHydrDownSlow.UserInfo = Nothing
        Me.BtnTopHydrDownSlow.UserLevel = 0
        Me.BtnTopHydrDownSlow.UseStateText = False
        '
        'TopHydrDownCreep
        '
        Me.TopHydrDownCreep.BindControl = Me.BtnTopHydrDownCreep
        Me.TopHydrDownCreep.BindProperty = "Data"
        Me.TopHydrDownCreep.Data = Nothing
        Me.TopHydrDownCreep.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TopHydrDownCreep.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TopHydrDownCreep.VariableName = "MAIN.InMoldDrying.Top[Position1].HydraulicCilinder.ManCreepDown"
        '
        'BtnTopHydrDownCreep
        '
        Me.BtnTopHydrDownCreep.Audit = Nothing
        Me.BtnTopHydrDownCreep.AuditEnabled = False
        Me.BtnTopHydrDownCreep.AuditMessage = "KremerPushButton pressed!"
        Me.BtnTopHydrDownCreep.AuditSource = "KremerPushButton"
        Me.BtnTopHydrDownCreep.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnTopHydrDownCreep.BackGroundImageOn = Nothing
        Me.BtnTopHydrDownCreep.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnTopHydrDownCreep.Data = False
        Me.BtnTopHydrDownCreep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTopHydrDownCreep.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnTopHydrDownCreep.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnTopHydrDownCreep.Location = New System.Drawing.Point(290, 252)
        Me.BtnTopHydrDownCreep.Name = "BtnTopHydrDownCreep"
        Me.BtnTopHydrDownCreep.Size = New System.Drawing.Size(106, 36)
        Me.BtnTopHydrDownCreep.State = False
        Me.BtnTopHydrDownCreep.StateIsData = True
        Me.BtnTopHydrDownCreep.StateText = New String() {Nothing, Nothing}
        Me.BtnTopHydrDownCreep.TabIndex = 343
        Me.BtnTopHydrDownCreep.Tag = "298"
        Me.BtnTopHydrDownCreep.Text = "Down creep"
        Me.BtnTopHydrDownCreep.UserInfo = Nothing
        Me.BtnTopHydrDownCreep.UserLevel = 0
        Me.BtnTopHydrDownCreep.UseStateText = False
        Me.BtnTopHydrDownCreep.UseVisualStyleBackColor = False
        '
        'BottomVacuum
        '
        Me.BottomVacuum.BindControl = Me.BtnBotVacuumOn
        Me.BottomVacuum.BindProperty = "Data"
        Me.BottomVacuum.Data = Nothing
        Me.BottomVacuum.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BottomVacuum.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BottomVacuum.VariableName = "MAIN.InMoldDrying.Bottom[Position1].Vacuum.mxHMI_On"
        '
        'BtnBotVacuumOn
        '
        Me.BtnBotVacuumOn.Audit = Nothing
        Me.BtnBotVacuumOn.AuditEnabled = False
        Me.BtnBotVacuumOn.AuditMessage = "KremerPushButton pressed!"
        Me.BtnBotVacuumOn.AuditSource = "KremerPushButton"
        Me.BtnBotVacuumOn.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnBotVacuumOn.BackGroundImageOn = Nothing
        Me.BtnBotVacuumOn.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.BtnBotVacuumOn.Data = False
        Me.BtnBotVacuumOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBotVacuumOn.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBotVacuumOn.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnBotVacuumOn.Location = New System.Drawing.Point(686, 42)
        Me.BtnBotVacuumOn.Name = "BtnBotVacuumOn"
        Me.BtnBotVacuumOn.Size = New System.Drawing.Size(106, 36)
        Me.BtnBotVacuumOn.State = False
        Me.BtnBotVacuumOn.StateIsData = True
        Me.BtnBotVacuumOn.StateText = New String() {Nothing, Nothing}
        Me.BtnBotVacuumOn.TabIndex = 333
        Me.BtnBotVacuumOn.Tag = "26"
        Me.BtnBotVacuumOn.Text = "On"
        Me.BtnBotVacuumOn.UserInfo = Nothing
        Me.BtnBotVacuumOn.UserLevel = 0
        Me.BtnBotVacuumOn.UseStateText = False
        '
        'BM_In
        '
        Me.BM_In.BindControl = Me.BtnBotHydrIn
        Me.BM_In.BindProperty = "Data"
        Me.BM_In.Data = Nothing
        Me.BM_In.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BM_In.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BM_In.VariableName = "MAIN.InMoldDrying.Bottom[Position1].HorizontalAxis.HMI_Backward"
        '
        'BtnBotHydrIn
        '
        Me.BtnBotHydrIn.Audit = Nothing
        Me.BtnBotHydrIn.AuditEnabled = False
        Me.BtnBotHydrIn.AuditMessage = "KremerPushButton pressed!"
        Me.BtnBotHydrIn.AuditSource = "KremerPushButton"
        Me.BtnBotHydrIn.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnBotHydrIn.BackGroundImageOn = Nothing
        Me.BtnBotHydrIn.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnBotHydrIn.Data = False
        Me.BtnBotHydrIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBotHydrIn.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBotHydrIn.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnBotHydrIn.Location = New System.Drawing.Point(574, 168)
        Me.BtnBotHydrIn.Name = "BtnBotHydrIn"
        Me.BtnBotHydrIn.Size = New System.Drawing.Size(106, 36)
        Me.BtnBotHydrIn.State = False
        Me.BtnBotHydrIn.StateIsData = True
        Me.BtnBotHydrIn.StateText = New String() {Nothing, Nothing}
        Me.BtnBotHydrIn.TabIndex = 336
        Me.BtnBotHydrIn.Tag = "33"
        Me.BtnBotHydrIn.Text = "In"
        Me.BtnBotHydrIn.UserInfo = Nothing
        Me.BtnBotHydrIn.UserLevel = 0
        Me.BtnBotHydrIn.UseStateText = False
        '
        'BM_Out
        '
        Me.BM_Out.BindControl = Me.BtnBotHydrOut
        Me.BM_Out.BindProperty = "Data"
        Me.BM_Out.Data = Nothing
        Me.BM_Out.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BM_Out.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BM_Out.VariableName = "MAIN.InMoldDrying.Bottom[Position1].HorizontalAxis.HMI_Forward"
        '
        'BtnBotHydrOut
        '
        Me.BtnBotHydrOut.Audit = Nothing
        Me.BtnBotHydrOut.AuditEnabled = False
        Me.BtnBotHydrOut.AuditMessage = "KremerPushButton pressed!"
        Me.BtnBotHydrOut.AuditSource = "KremerPushButton"
        Me.BtnBotHydrOut.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnBotHydrOut.BackGroundImageOn = Nothing
        Me.BtnBotHydrOut.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnBotHydrOut.Data = False
        Me.BtnBotHydrOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBotHydrOut.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBotHydrOut.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnBotHydrOut.Location = New System.Drawing.Point(686, 168)
        Me.BtnBotHydrOut.Name = "BtnBotHydrOut"
        Me.BtnBotHydrOut.Size = New System.Drawing.Size(106, 36)
        Me.BtnBotHydrOut.State = False
        Me.BtnBotHydrOut.StateIsData = True
        Me.BtnBotHydrOut.StateText = New String() {Nothing, Nothing}
        Me.BtnBotHydrOut.TabIndex = 337
        Me.BtnBotHydrOut.Tag = "34"
        Me.BtnBotHydrOut.Text = "Out"
        Me.BtnBotHydrOut.UserInfo = Nothing
        Me.BtnBotHydrOut.UserLevel = 0
        Me.BtnBotHydrOut.UseStateText = False
        '
        'TopPos
        '
        Me.TopPos.BindControl = Me.IO_TopPos
        Me.TopPos.BindProperty = "Data"
        Me.TopPos.Data = Nothing
        Me.TopPos.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.TopPos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TopPos.VariableName = "MAIN.InMoldDrying.Top[Position1].HydraulicCilinder.ActPosition"
        '
        'IO_TopPos
        '
        Me.IO_TopPos.Audit = Nothing
        Me.IO_TopPos.AuditEnabled = False
        Me.IO_TopPos.AuditMessage = "KremerIoField changed:"
        Me.IO_TopPos.AuditSource = "KremerIoField"
        Me.IO_TopPos.Data = 0.0R
        Me.IO_TopPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TopPos.InitialValue = True
        Me.IO_TopPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_TopPos.Location = New System.Drawing.Point(325, 136)
        Me.IO_TopPos.LowerBound = 0.0R
        Me.IO_TopPos.Name = "IO_TopPos"
        Me.IO_TopPos.OutputFormat = "0.0 mm"
        Me.IO_TopPos.Size = New System.Drawing.Size(71, 21)
        Me.IO_TopPos.TabIndex = 311
        Me.IO_TopPos.Text = "0.0 mm"
        Me.IO_TopPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IO_TopPos.UpperBound = 1000.0R
        Me.IO_TopPos.UserInfo = Nothing
        Me.IO_TopPos.UserLevel = 0
        '
        'BotPos
        '
        Me.BotPos.BindControl = Me.IO_BotPos
        Me.BotPos.BindProperty = "Data"
        Me.BotPos.Data = Nothing
        Me.BotPos.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.BotPos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BotPos.VariableName = "MAIN.InMoldDrying.Bottom[Position1].HorizontalAxis.ActPosition"
        '
        'IO_BotPos
        '
        Me.IO_BotPos.Audit = Nothing
        Me.IO_BotPos.AuditEnabled = False
        Me.IO_BotPos.AuditMessage = "KremerIoField changed:"
        Me.IO_BotPos.AuditSource = "KremerIoField"
        Me.IO_BotPos.Data = 0.0R
        Me.IO_BotPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_BotPos.InitialValue = True
        Me.IO_BotPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_BotPos.Location = New System.Drawing.Point(720, 136)
        Me.IO_BotPos.LowerBound = 0.0R
        Me.IO_BotPos.Name = "IO_BotPos"
        Me.IO_BotPos.OutputFormat = "0.0 mm"
        Me.IO_BotPos.Size = New System.Drawing.Size(71, 21)
        Me.IO_BotPos.TabIndex = 340
        Me.IO_BotPos.Text = "0.0 mm"
        Me.IO_BotPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IO_BotPos.UpperBound = 1000.0R
        Me.IO_BotPos.UserInfo = Nothing
        Me.IO_BotPos.UserLevel = 0
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
        Me.Btn_Overview.Location = New System.Drawing.Point(685, 385)
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
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 20
        Me.LineShape2.X2 = 390
        Me.LineShape2.Y1 = 159
        Me.LineShape2.Y2 = 159
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 20
        Me.LineShape1.X2 = 390
        Me.LineShape1.Y1 = 35
        Me.LineShape1.Y2 = 35
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape1, Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 435)
        Me.ShapeContainer1.TabIndex = 308
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 424
        Me.LineShape4.X2 = 794
        Me.LineShape4.Y1 = 158
        Me.LineShape4.Y2 = 158
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 423
        Me.LineShape3.X2 = 793
        Me.LineShape3.Y1 = 36
        Me.LineShape3.Y2 = 36
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 23)
        Me.Label4.TabIndex = 321
        Me.Label4.Tag = ""
        Me.Label4.Text = "Hydraulic cylinder"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(24, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(291, 23)
        Me.Label3.TabIndex = 317
        Me.Label3.Tag = "377"
        Me.Label3.Text = "Top mold hydrolics"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 23)
        Me.Label1.TabIndex = 314
        Me.Label1.Tag = "287"
        Me.Label1.Text = "Blow Off"
        '
        'lbl_puh
        '
        Me.lbl_puh.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_puh.Location = New System.Drawing.Point(23, 8)
        Me.lbl_puh.Name = "lbl_puh"
        Me.lbl_puh.Size = New System.Drawing.Size(291, 23)
        Me.lbl_puh.TabIndex = 309
        Me.lbl_puh.Tag = "375"
        Me.lbl_puh.Text = "Top mold valves"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 23)
        Me.Label6.TabIndex = 325
        Me.Label6.Tag = "286"
        Me.Label6.Text = "Vacuum"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(419, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 23)
        Me.Label5.TabIndex = 332
        Me.Label5.Tag = "286"
        Me.Label5.Text = "Vacuum"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(419, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(291, 23)
        Me.Label9.TabIndex = 327
        Me.Label9.Tag = "376"
        Me.Label9.Text = "Bottom mold valves"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(420, 175)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 23)
        Me.Label10.TabIndex = 335
        Me.Label10.Tag = "81"
        Me.Label10.Text = "Axis"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(420, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(291, 23)
        Me.Label11.TabIndex = 334
        Me.Label11.Tag = ""
        Me.Label11.Text = "Bottom mold servo"
        '
        'DryingMold_Manual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnTopHydrDownCreep)
        Me.Controls.Add(Me.BtnTopHydrDownSlow)
        Me.Controls.Add(Me.BtnTopHydrUpCreep)
        Me.Controls.Add(Me.IO_BotPos)
        Me.Controls.Add(Me.BtnBotHydrOut)
        Me.Controls.Add(Me.BtnBotHydrIn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BtnBotVacuumOn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnTopVacuumOn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnTopHydrUpSlow)
        Me.Controls.Add(Me.BtnTopHydrDown)
        Me.Controls.Add(Me.BtnTopHydrUp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnTopBlowOffOn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IO_TopPos)
        Me.Controls.Add(Me.lbl_puh)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "DryingMold_Manual"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "79"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents mxAutomode As KremerControlsWin32.KremerVariable
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents BtnTopHydrUpSlow As KremerControlsWin32.KremerButton
    Friend WithEvents BtnTopHydrDown As KremerControlsWin32.KremerButton
    Friend WithEvents BtnTopHydrUp As KremerControlsWin32.KremerButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnTopBlowOffOn As KremerControlsWin32.KremerButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IO_TopPos As KremerControlsWin32.KremerIoField
    Friend WithEvents lbl_puh As System.Windows.Forms.Label
    Friend WithEvents BtnTopVacuumOn As KremerControlsWin32.KremerButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents BtnBotVacuumOn As KremerControlsWin32.KremerButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnBotHydrOut As KremerControlsWin32.KremerButton
    Friend WithEvents BtnBotHydrIn As KremerControlsWin32.KremerButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TopBlowOff As KremerControlsWin32.KremerVariable
    Friend WithEvents TopVacuum As KremerControlsWin32.KremerVariable
    Friend WithEvents TopHydrUp As KremerControlsWin32.KremerVariable
    Friend WithEvents TopHydrDown As KremerControlsWin32.KremerVariable
    Friend WithEvents TopHydrDownSlow As KremerControlsWin32.KremerVariable
    Friend WithEvents BottomVacuum As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_BotPos As KremerControlsWin32.KremerIoField
    Friend WithEvents TopPos As KremerControlsWin32.KremerVariable
    Friend WithEvents BotPos As KremerControlsWin32.KremerVariable
    Friend WithEvents TopHydrUpSlow As KremerControlsWin32.KremerVariable
    Friend WithEvents TopHydrDownCreep As KremerControlsWin32.KremerVariable
    Friend WithEvents TopHydrUpCreep As KremerControlsWin32.KremerVariable
    Friend WithEvents BtnTopHydrUpCreep As KremerControlsWin32.KremerButton
    Friend WithEvents BtnTopHydrDownSlow As KremerControlsWin32.KremerButton
    Friend WithEvents BtnTopHydrDownCreep As KremerControlsWin32.KremerButton
    Friend WithEvents BM_In As KremerControlsWin32.KremerVariable
    Friend WithEvents BM_Out As KremerControlsWin32.KremerVariable

End Class
