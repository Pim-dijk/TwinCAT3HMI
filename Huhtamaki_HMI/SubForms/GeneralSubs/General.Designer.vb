<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class General
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShutDown = New KremerControlsWin32.KremerButton()
        Me.btnUsers = New KremerControlsWin32.KremerButton()
        Me.btnCleanScreen = New KremerControlsWin32.KremerButton()
        Me.btnLang = New KremerControlsWin32.KremerButton()
        Me.btnClose = New KremerControlsWin32.KremerButton()
        Me.btnLogout = New KremerControlsWin32.KremerButton()
        Me.btnLogin = New KremerControlsWin32.KremerButton()
        Me.KremerButton1 = New KremerControlsWin32.KremerButton()
        Me.krVarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.Pulplvl1 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_Tank1 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Pulplvl2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_Tank2 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TMAControl = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TMA_Percentage = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TMBControl = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TMB_Percentage = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TR_Control = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_Tr_Percentage = New KremerControlsWin32.KremerIoField(Me.components)
        Me.EnableHeating = New KremerControlsWin32.KremerVariable(Me.components)
        Me.btnEnableHeating = New KremerControlsWin32.KremerButton()
        Me.ActiveTank1 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KremerLight1 = New KremerControlsWin32.KremerLight()
        Me.ActiveTank2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KremerLight2 = New KremerControlsWin32.KremerLight()
        Me.PressFilt75 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_Press75 = New KremerControlsWin32.KremerLight()
        Me.PressFilt100 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_Press100 = New KremerControlsWin32.KremerLight()
        Me.PressAux75 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_Aux75 = New KremerControlsWin32.KremerLight()
        Me.PressAux100 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_Aux100 = New KremerControlsWin32.KremerLight()
        Me.Temp40 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_Temp40 = New KremerControlsWin32.KremerLight()
        Me.Temp55 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_Temp55 = New KremerControlsWin32.KremerLight()
        Me.TempTooHigh = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TempTooHigh = New KremerControlsWin32.KremerLight()
        Me.TopMoldReleasedFirst = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TopmoldReleasedFirst = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TransferReleasedFirst = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TransferReleasedFirst = New KremerControlsWin32.KremerIoField(Me.components)
        Me.mxStartHydraulics = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnStart = New KremerControlsWin32.KremerButton()
        Me.mxStartHydraulicsState = New KremerControlsWin32.KremerVariable(Me.components)
        Me.mxStopHydraulics = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnStop = New KremerControlsWin32.KremerButton()
        Me.mxStopHydraulicsState = New KremerControlsWin32.KremerVariable(Me.components)
        Me.mxHydraulicStateText = New KremerControlsWin32.KremerVariable(Me.components)
        Me.StatusHydraulics = New KremerControlsWin32.KremerTextField(Me.components)
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lbl_puh = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblcurrentProduct = New System.Windows.Forms.Label()
        Me.ProductPanel = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.KL_OilLvlTooLow = New KremerControlsWin32.KremerLight()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.KL_OilLvlLow = New KremerControlsWin32.KremerLight()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.ProductPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'krConnector
        '
        Me.krConnector.VarCollector = Nothing
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(4, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 22)
        Me.Label1.TabIndex = 317
        Me.Label1.Tag = ""
        Me.Label1.Text = "Hydraulic system"
        '
        'btnShutDown
        '
        Me.btnShutDown.Audit = Nothing
        Me.btnShutDown.AuditEnabled = False
        Me.btnShutDown.AuditMessage = "KremerPushButton pressed!"
        Me.btnShutDown.AuditSource = "KremerPushButton"
        Me.btnShutDown.BackColorOn = System.Drawing.Color.Blue
        Me.btnShutDown.BackGroundImageOn = Nothing
        Me.btnShutDown.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.btnShutDown.Data = False
        Me.btnShutDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShutDown.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnShutDown.ForeColorOn = System.Drawing.Color.Yellow
        Me.btnShutDown.Location = New System.Drawing.Point(571, 385)
        Me.btnShutDown.Name = "btnShutDown"
        Me.btnShutDown.Size = New System.Drawing.Size(114, 50)
        Me.btnShutDown.State = False
        Me.btnShutDown.StateIsData = True
        Me.btnShutDown.StateText = New String() {Nothing, Nothing}
        Me.btnShutDown.TabIndex = 320
        Me.btnShutDown.Tag = ""
        Me.btnShutDown.Text = "Shutdown PC"
        Me.btnShutDown.UserInfo = Nothing
        Me.btnShutDown.UserLevel = 800
        Me.btnShutDown.UseStateText = False
        Me.btnShutDown.UseVisualStyleBackColor = False
        '
        'btnUsers
        '
        Me.btnUsers.Audit = Nothing
        Me.btnUsers.AuditEnabled = False
        Me.btnUsers.AuditMessage = "KremerPushButton pressed!"
        Me.btnUsers.AuditSource = "KremerPushButton"
        Me.btnUsers.BackColorOn = System.Drawing.Color.Empty
        Me.btnUsers.BackGroundImageOn = Nothing
        Me.btnUsers.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.btnUsers.Data = False
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnUsers.ForeColorOn = System.Drawing.Color.Empty
        Me.btnUsers.Location = New System.Drawing.Point(229, 385)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(114, 50)
        Me.btnUsers.State = False
        Me.btnUsers.StateIsData = True
        Me.btnUsers.StateText = New String() {Nothing, Nothing}
        Me.btnUsers.TabIndex = 295
        Me.btnUsers.Tag = ""
        Me.btnUsers.Text = "Users"
        Me.btnUsers.UserInfo = Nothing
        Me.btnUsers.UserLevel = 800
        Me.btnUsers.UseStateText = False
        '
        'btnCleanScreen
        '
        Me.btnCleanScreen.Audit = Nothing
        Me.btnCleanScreen.AuditEnabled = False
        Me.btnCleanScreen.AuditMessage = "KremerPushButton pressed!"
        Me.btnCleanScreen.AuditSource = "KremerPushButton"
        Me.btnCleanScreen.BackColorOn = System.Drawing.Color.Empty
        Me.btnCleanScreen.BackGroundImageOn = Nothing
        Me.btnCleanScreen.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.btnCleanScreen.Data = False
        Me.btnCleanScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCleanScreen.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCleanScreen.ForeColorOn = System.Drawing.Color.Empty
        Me.btnCleanScreen.Location = New System.Drawing.Point(457, 385)
        Me.btnCleanScreen.Name = "btnCleanScreen"
        Me.btnCleanScreen.Size = New System.Drawing.Size(114, 50)
        Me.btnCleanScreen.State = False
        Me.btnCleanScreen.StateIsData = True
        Me.btnCleanScreen.StateText = New String() {Nothing, Nothing}
        Me.btnCleanScreen.TabIndex = 114
        Me.btnCleanScreen.Tag = "55"
        Me.btnCleanScreen.Text = "Clean Screen"
        Me.btnCleanScreen.UserInfo = Nothing
        Me.btnCleanScreen.UserLevel = 0
        Me.btnCleanScreen.UseStateText = False
        '
        'btnLang
        '
        Me.btnLang.Audit = Nothing
        Me.btnLang.AuditEnabled = False
        Me.btnLang.AuditMessage = "KremerPushButton pressed!"
        Me.btnLang.AuditSource = "KremerPushButton"
        Me.btnLang.BackColorOn = System.Drawing.Color.Empty
        Me.btnLang.BackGroundImageOn = Nothing
        Me.btnLang.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.btnLang.Data = False
        Me.btnLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLang.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLang.ForeColorOn = System.Drawing.Color.Empty
        Me.btnLang.Location = New System.Drawing.Point(343, 385)
        Me.btnLang.Name = "btnLang"
        Me.btnLang.Size = New System.Drawing.Size(114, 50)
        Me.btnLang.State = False
        Me.btnLang.StateIsData = True
        Me.btnLang.StateText = New String() {Nothing, Nothing}
        Me.btnLang.TabIndex = 102
        Me.btnLang.Text = "Language"
        Me.btnLang.UserInfo = Nothing
        Me.btnLang.UserLevel = 800
        Me.btnLang.UseStateText = False
        '
        'btnClose
        '
        Me.btnClose.Audit = Nothing
        Me.btnClose.AuditEnabled = False
        Me.btnClose.AuditMessage = "KremerPushButton pressed!"
        Me.btnClose.AuditSource = "KremerPushButton"
        Me.btnClose.BackColorOn = System.Drawing.Color.Empty
        Me.btnClose.BackGroundImageOn = Nothing
        Me.btnClose.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.btnClose.Data = False
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColorOn = System.Drawing.Color.Empty
        Me.btnClose.Location = New System.Drawing.Point(685, 385)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(114, 50)
        Me.btnClose.State = False
        Me.btnClose.StateIsData = True
        Me.btnClose.StateText = New String() {Nothing, Nothing}
        Me.btnClose.TabIndex = 89
        Me.btnClose.Tag = "28"
        Me.btnClose.Text = "Close HMI"
        Me.btnClose.UserInfo = Nothing
        Me.btnClose.UserLevel = 800
        Me.btnClose.UseStateText = False
        '
        'btnLogout
        '
        Me.btnLogout.Audit = Nothing
        Me.btnLogout.AuditEnabled = False
        Me.btnLogout.AuditMessage = "KremerPushButton pressed!"
        Me.btnLogout.AuditSource = "KremerPushButton"
        Me.btnLogout.BackColorOn = System.Drawing.Color.Empty
        Me.btnLogout.BackGroundImageOn = Nothing
        Me.btnLogout.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.btnLogout.Data = False
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColorOn = System.Drawing.Color.Empty
        Me.btnLogout.Location = New System.Drawing.Point(115, 385)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(114, 50)
        Me.btnLogout.State = False
        Me.btnLogout.StateIsData = True
        Me.btnLogout.StateText = New String() {Nothing, Nothing}
        Me.btnLogout.TabIndex = 88
        Me.btnLogout.Tag = "25"
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UserInfo = Nothing
        Me.btnLogout.UserLevel = 0
        Me.btnLogout.UseStateText = False
        '
        'btnLogin
        '
        Me.btnLogin.Audit = Nothing
        Me.btnLogin.AuditEnabled = False
        Me.btnLogin.AuditMessage = "KremerPushButton pressed!"
        Me.btnLogin.AuditSource = "KremerPushButton"
        Me.btnLogin.BackColorOn = System.Drawing.Color.Empty
        Me.btnLogin.BackGroundImageOn = Nothing
        Me.btnLogin.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.btnLogin.Data = False
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColorOn = System.Drawing.Color.Empty
        Me.btnLogin.Location = New System.Drawing.Point(1, 385)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(114, 50)
        Me.btnLogin.State = False
        Me.btnLogin.StateIsData = True
        Me.btnLogin.StateText = New String() {Nothing, Nothing}
        Me.btnLogin.TabIndex = 87
        Me.btnLogin.Tag = "24"
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UserInfo = Nothing
        Me.btnLogin.UserLevel = 0
        Me.btnLogin.UseStateText = False
        '
        'KremerButton1
        '
        Me.KremerButton1.Audit = Nothing
        Me.KremerButton1.AuditEnabled = False
        Me.KremerButton1.AuditMessage = "KremerPushButton pressed!"
        Me.KremerButton1.AuditSource = "KremerPushButton"
        Me.KremerButton1.BackColorOn = System.Drawing.Color.Empty
        Me.KremerButton1.BackGroundImageOn = Nothing
        Me.KremerButton1.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.KremerButton1.Data = False
        Me.KremerButton1.Enabled = False
        Me.KremerButton1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.KremerButton1.ForeColorOn = System.Drawing.Color.Empty
        Me.KremerButton1.Location = New System.Drawing.Point(457, 385)
        Me.KremerButton1.Name = "KremerButton1"
        Me.KremerButton1.Size = New System.Drawing.Size(114, 50)
        Me.KremerButton1.State = False
        Me.KremerButton1.StateIsData = True
        Me.KremerButton1.StateText = New String() {Nothing, Nothing}
        Me.KremerButton1.TabIndex = 313
        Me.KremerButton1.Tag = ""
        Me.KremerButton1.UserInfo = Nothing
        Me.KremerButton1.UserLevel = 0
        Me.KremerButton1.UseStateText = False
        '
        'krVarCollector
        '
        Me.krVarCollector.Variables.Add(Me.Pulplvl1)
        Me.krVarCollector.Variables.Add(Me.Pulplvl2)
        Me.krVarCollector.Variables.Add(Me.TMAControl)
        Me.krVarCollector.Variables.Add(Me.TMBControl)
        Me.krVarCollector.Variables.Add(Me.TR_Control)
        Me.krVarCollector.Variables.Add(Me.EnableHeating)
        Me.krVarCollector.Variables.Add(Me.ActiveTank1)
        Me.krVarCollector.Variables.Add(Me.ActiveTank2)
        Me.krVarCollector.Variables.Add(Me.PressFilt75)
        Me.krVarCollector.Variables.Add(Me.PressFilt100)
        Me.krVarCollector.Variables.Add(Me.PressAux75)
        Me.krVarCollector.Variables.Add(Me.PressAux100)
        Me.krVarCollector.Variables.Add(Me.Temp40)
        Me.krVarCollector.Variables.Add(Me.Temp55)
        Me.krVarCollector.Variables.Add(Me.TempTooHigh)
        Me.krVarCollector.Variables.Add(Me.TopMoldReleasedFirst)
        Me.krVarCollector.Variables.Add(Me.TransferReleasedFirst)
        Me.krVarCollector.Variables.Add(Me.mxStartHydraulics)
        Me.krVarCollector.Variables.Add(Me.mxStartHydraulicsState)
        Me.krVarCollector.Variables.Add(Me.mxStopHydraulics)
        Me.krVarCollector.Variables.Add(Me.mxStopHydraulicsState)
        Me.krVarCollector.Variables.Add(Me.mxHydraulicStateText)
        '
        'Pulplvl1
        '
        Me.Pulplvl1.BindControl = Me.IO_Tank1
        Me.Pulplvl1.BindProperty = "Data"
        Me.Pulplvl1.Data = Nothing
        Me.Pulplvl1.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.Pulplvl1.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Pulplvl1.VariableName = "MAIN.InMoldDrying.ProductForming.TankLevel01.EngUnits"
        '
        'IO_Tank1
        '
        Me.IO_Tank1.Audit = Nothing
        Me.IO_Tank1.AuditEnabled = False
        Me.IO_Tank1.AuditMessage = "KremerIoField changed:"
        Me.IO_Tank1.AuditSource = "KremerIoField"
        Me.IO_Tank1.BackColor = System.Drawing.SystemColors.Control
        Me.IO_Tank1.Data = 0R
        Me.IO_Tank1.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_Tank1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_Tank1.InitialValue = True
        Me.IO_Tank1.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_Tank1.Location = New System.Drawing.Point(712, 35)
        Me.IO_Tank1.LowerBound = 0R
        Me.IO_Tank1.Name = "IO_Tank1"
        Me.IO_Tank1.OutputFormat = "0.0 '%'"
        Me.IO_Tank1.Size = New System.Drawing.Size(80, 22)
        Me.IO_Tank1.TabIndex = 360
        Me.IO_Tank1.Text = "0.0 %"
        Me.IO_Tank1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_Tank1.UpperBound = 500.0R
        Me.IO_Tank1.UserInfo = Nothing
        Me.IO_Tank1.UserLevel = 800
        '
        'Pulplvl2
        '
        Me.Pulplvl2.BindControl = Me.IO_Tank2
        Me.Pulplvl2.BindProperty = "Data"
        Me.Pulplvl2.Data = Nothing
        Me.Pulplvl2.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.Pulplvl2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Pulplvl2.VariableName = "MAIN.InMoldDrying.ProductForming.TankLevel02.EngUnits"
        '
        'IO_Tank2
        '
        Me.IO_Tank2.Audit = Nothing
        Me.IO_Tank2.AuditEnabled = False
        Me.IO_Tank2.AuditMessage = "KremerIoField changed:"
        Me.IO_Tank2.AuditSource = "KremerIoField"
        Me.IO_Tank2.BackColor = System.Drawing.SystemColors.Control
        Me.IO_Tank2.Data = 0R
        Me.IO_Tank2.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_Tank2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_Tank2.InitialValue = True
        Me.IO_Tank2.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_Tank2.Location = New System.Drawing.Point(717, 61)
        Me.IO_Tank2.LowerBound = 0R
        Me.IO_Tank2.Name = "IO_Tank2"
        Me.IO_Tank2.OutputFormat = "0.0 '%'"
        Me.IO_Tank2.Size = New System.Drawing.Size(75, 22)
        Me.IO_Tank2.TabIndex = 361
        Me.IO_Tank2.Text = "0.0 %"
        Me.IO_Tank2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_Tank2.UpperBound = 5000.0R
        Me.IO_Tank2.UserInfo = Nothing
        Me.IO_Tank2.UserLevel = 800
        '
        'TMAControl
        '
        Me.TMAControl.BindControl = Me.IO_TMA_Percentage
        Me.TMAControl.BindProperty = "Data"
        Me.TMAControl.Data = Nothing
        Me.TMAControl.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.TMAControl.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMAControl.VariableName = "MAIN.InMoldDrying.TopMoldA.HydraulicCilinder.HydraulicValve.EngInput"
        '
        'IO_TMA_Percentage
        '
        Me.IO_TMA_Percentage.Audit = Nothing
        Me.IO_TMA_Percentage.AuditEnabled = False
        Me.IO_TMA_Percentage.AuditMessage = "KremerIoField changed:"
        Me.IO_TMA_Percentage.AuditSource = "KremerIoField"
        Me.IO_TMA_Percentage.BackColor = System.Drawing.SystemColors.Control
        Me.IO_TMA_Percentage.Data = 0R
        Me.IO_TMA_Percentage.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TMA_Percentage.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TMA_Percentage.InitialValue = True
        Me.IO_TMA_Percentage.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_TMA_Percentage.Location = New System.Drawing.Point(7, 117)
        Me.IO_TMA_Percentage.LowerBound = 0R
        Me.IO_TMA_Percentage.Name = "IO_TMA_Percentage"
        Me.IO_TMA_Percentage.OutputFormat = "0.0 '%'"
        Me.IO_TMA_Percentage.Size = New System.Drawing.Size(80, 22)
        Me.IO_TMA_Percentage.TabIndex = 398
        Me.IO_TMA_Percentage.Text = "0.0 %"
        Me.IO_TMA_Percentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TMA_Percentage.UpperBound = 500.0R
        Me.IO_TMA_Percentage.UserInfo = Nothing
        Me.IO_TMA_Percentage.UserLevel = 800
        '
        'TMBControl
        '
        Me.TMBControl.BindControl = Me.IO_TMB_Percentage
        Me.TMBControl.BindProperty = "Data"
        Me.TMBControl.Data = Nothing
        Me.TMBControl.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.TMBControl.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMBControl.VariableName = "MAIN.InMoldDrying.TopMoldB.HydraulicCilinder.HydraulicValve.EngInput"
        '
        'IO_TMB_Percentage
        '
        Me.IO_TMB_Percentage.Audit = Nothing
        Me.IO_TMB_Percentage.AuditEnabled = False
        Me.IO_TMB_Percentage.AuditMessage = "KremerIoField changed:"
        Me.IO_TMB_Percentage.AuditSource = "KremerIoField"
        Me.IO_TMB_Percentage.BackColor = System.Drawing.SystemColors.Control
        Me.IO_TMB_Percentage.Data = 0R
        Me.IO_TMB_Percentage.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TMB_Percentage.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TMB_Percentage.InitialValue = True
        Me.IO_TMB_Percentage.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_TMB_Percentage.Location = New System.Drawing.Point(309, 118)
        Me.IO_TMB_Percentage.LowerBound = 0R
        Me.IO_TMB_Percentage.Name = "IO_TMB_Percentage"
        Me.IO_TMB_Percentage.OutputFormat = "0.0 '%'"
        Me.IO_TMB_Percentage.Size = New System.Drawing.Size(80, 22)
        Me.IO_TMB_Percentage.TabIndex = 400
        Me.IO_TMB_Percentage.Text = "0.0 %"
        Me.IO_TMB_Percentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TMB_Percentage.UpperBound = 500.0R
        Me.IO_TMB_Percentage.UserInfo = Nothing
        Me.IO_TMB_Percentage.UserLevel = 800
        '
        'TR_Control
        '
        Me.TR_Control.BindControl = Me.IO_Tr_Percentage
        Me.TR_Control.BindProperty = "Data"
        Me.TR_Control.Data = Nothing
        Me.TR_Control.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.TR_Control.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TR_Control.VariableName = "MAIN.InMoldDrying.TransferMold.HydraulicCilinder.HydraulicValve.EngInput"
        '
        'IO_Tr_Percentage
        '
        Me.IO_Tr_Percentage.Audit = Nothing
        Me.IO_Tr_Percentage.AuditEnabled = False
        Me.IO_Tr_Percentage.AuditMessage = "KremerIoField changed:"
        Me.IO_Tr_Percentage.AuditSource = "KremerIoField"
        Me.IO_Tr_Percentage.BackColor = System.Drawing.SystemColors.Control
        Me.IO_Tr_Percentage.Data = 0R
        Me.IO_Tr_Percentage.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_Tr_Percentage.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_Tr_Percentage.InitialValue = True
        Me.IO_Tr_Percentage.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_Tr_Percentage.Location = New System.Drawing.Point(164, 118)
        Me.IO_Tr_Percentage.LowerBound = 0R
        Me.IO_Tr_Percentage.Name = "IO_Tr_Percentage"
        Me.IO_Tr_Percentage.OutputFormat = "0.0 '%'"
        Me.IO_Tr_Percentage.Size = New System.Drawing.Size(80, 22)
        Me.IO_Tr_Percentage.TabIndex = 399
        Me.IO_Tr_Percentage.Text = "0.0 %"
        Me.IO_Tr_Percentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_Tr_Percentage.UpperBound = 500.0R
        Me.IO_Tr_Percentage.UserInfo = Nothing
        Me.IO_Tr_Percentage.UserLevel = 800
        '
        'EnableHeating
        '
        Me.EnableHeating.BindControl = Me.btnEnableHeating
        Me.EnableHeating.BindProperty = "Data"
        Me.EnableHeating.Data = Nothing
        Me.EnableHeating.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.EnableHeating.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.EnableHeating.VariableName = "MAIN.mxHMI_EnableHeating"
        '
        'btnEnableHeating
        '
        Me.btnEnableHeating.Audit = Nothing
        Me.btnEnableHeating.AuditEnabled = False
        Me.btnEnableHeating.AuditMessage = "KremerPushButton pressed!"
        Me.btnEnableHeating.AuditSource = "KremerPushButton"
        Me.btnEnableHeating.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEnableHeating.BackGroundImageOn = Nothing
        Me.btnEnableHeating.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.btnEnableHeating.Data = False
        Me.btnEnableHeating.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnableHeating.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEnableHeating.ForeColorOn = System.Drawing.Color.Yellow
        Me.btnEnableHeating.Location = New System.Drawing.Point(285, 167)
        Me.btnEnableHeating.Name = "btnEnableHeating"
        Me.btnEnableHeating.Size = New System.Drawing.Size(106, 36)
        Me.btnEnableHeating.State = False
        Me.btnEnableHeating.StateIsData = True
        Me.btnEnableHeating.StateText = New String() {Nothing, Nothing}
        Me.btnEnableHeating.TabIndex = 347
        Me.btnEnableHeating.Tag = "26"
        Me.btnEnableHeating.Text = "On"
        Me.btnEnableHeating.UserInfo = Nothing
        Me.btnEnableHeating.UserLevel = 0
        Me.btnEnableHeating.UseStateText = False
        Me.btnEnableHeating.UseVisualStyleBackColor = False
        '
        'ActiveTank1
        '
        Me.ActiveTank1.BindControl = Me.KremerLight1
        Me.ActiveTank1.BindProperty = "Data"
        Me.ActiveTank1.Data = Nothing
        Me.ActiveTank1.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ActiveTank1.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ActiveTank1.VariableName = "MAIN.InMoldDrying.ProductForming.ixPulpTank01"
        '
        'KremerLight1
        '
        Me.KremerLight1.ColorOff = System.Drawing.Color.DarkGray
        Me.KremerLight1.ColorOn = System.Drawing.Color.Lime
        Me.KremerLight1.Data = False
        Me.KremerLight1.Line = True
        Me.KremerLight1.LineSize = 1
        Me.KremerLight1.Location = New System.Drawing.Point(682, 34)
        Me.KremerLight1.Name = "KremerLight1"
        Me.KremerLight1.Size = New System.Drawing.Size(24, 23)
        Me.KremerLight1.TabIndex = 364
        Me.KremerLight1.Text = "KL_Tank1"
        Me.KremerLight1.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'ActiveTank2
        '
        Me.ActiveTank2.BindControl = Me.KremerLight2
        Me.ActiveTank2.BindProperty = "Data"
        Me.ActiveTank2.Data = Nothing
        Me.ActiveTank2.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ActiveTank2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ActiveTank2.VariableName = "MAIN.InMoldDrying.ProductForming.ixPulpTank02"
        '
        'KremerLight2
        '
        Me.KremerLight2.ColorOff = System.Drawing.Color.DarkGray
        Me.KremerLight2.ColorOn = System.Drawing.Color.Lime
        Me.KremerLight2.Data = False
        Me.KremerLight2.Line = True
        Me.KremerLight2.LineSize = 1
        Me.KremerLight2.Location = New System.Drawing.Point(682, 57)
        Me.KremerLight2.Name = "KremerLight2"
        Me.KremerLight2.Size = New System.Drawing.Size(24, 23)
        Me.KremerLight2.TabIndex = 365
        Me.KremerLight2.Text = "KL_Tank2"
        Me.KremerLight2.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'PressFilt75
        '
        Me.PressFilt75.BindControl = Me.KL_Press75
        Me.PressFilt75.BindProperty = "Data"
        Me.PressFilt75.Data = Nothing
        Me.PressFilt75.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PressFilt75.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PressFilt75.VariableName = "MAIN.InMoldDrying.HydraulicsMain.ixPressureFilterAt75"
        '
        'KL_Press75
        '
        Me.KL_Press75.ColorOff = System.Drawing.Color.DarkGray
        Me.KL_Press75.ColorOn = System.Drawing.Color.Red
        Me.KL_Press75.Data = False
        Me.KL_Press75.Line = True
        Me.KL_Press75.LineSize = 1
        Me.KL_Press75.Location = New System.Drawing.Point(682, 117)
        Me.KL_Press75.Name = "KL_Press75"
        Me.KL_Press75.Size = New System.Drawing.Size(24, 23)
        Me.KL_Press75.TabIndex = 372
        Me.KL_Press75.Text = "KL_Press75"
        Me.KL_Press75.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'PressFilt100
        '
        Me.PressFilt100.BindControl = Me.KL_Press100
        Me.PressFilt100.BindProperty = "Data"
        Me.PressFilt100.Data = Nothing
        Me.PressFilt100.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PressFilt100.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PressFilt100.VariableName = "MAIN.InMoldDrying.HydraulicsMain.ixPressureFilterAt100"
        '
        'KL_Press100
        '
        Me.KL_Press100.ColorOff = System.Drawing.Color.Red
        Me.KL_Press100.ColorOn = System.Drawing.Color.DarkGray
        Me.KL_Press100.Data = False
        Me.KL_Press100.Line = True
        Me.KL_Press100.LineSize = 1
        Me.KL_Press100.Location = New System.Drawing.Point(682, 140)
        Me.KL_Press100.Name = "KL_Press100"
        Me.KL_Press100.Size = New System.Drawing.Size(24, 23)
        Me.KL_Press100.TabIndex = 373
        Me.KL_Press100.Text = "KL_Press100"
        Me.KL_Press100.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'PressAux75
        '
        Me.PressAux75.BindControl = Me.KL_Aux75
        Me.PressAux75.BindProperty = "Data"
        Me.PressAux75.Data = Nothing
        Me.PressAux75.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PressAux75.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PressAux75.VariableName = "MAIN.InMoldDrying.HydraulicsMain.ixAuxFilterAt75"
        '
        'KL_Aux75
        '
        Me.KL_Aux75.ColorOff = System.Drawing.Color.DarkGray
        Me.KL_Aux75.ColorOn = System.Drawing.Color.Red
        Me.KL_Aux75.Data = False
        Me.KL_Aux75.Line = True
        Me.KL_Aux75.LineSize = 1
        Me.KL_Aux75.Location = New System.Drawing.Point(682, 163)
        Me.KL_Aux75.Name = "KL_Aux75"
        Me.KL_Aux75.Size = New System.Drawing.Size(24, 23)
        Me.KL_Aux75.TabIndex = 375
        Me.KL_Aux75.Text = "KL_Aux75"
        Me.KL_Aux75.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'PressAux100
        '
        Me.PressAux100.BindControl = Me.KL_Aux100
        Me.PressAux100.BindProperty = "Data"
        Me.PressAux100.Data = Nothing
        Me.PressAux100.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PressAux100.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PressAux100.VariableName = "MAIN.InMoldDrying.HydraulicsMain.ixAuxFilterAt100"
        '
        'KL_Aux100
        '
        Me.KL_Aux100.ColorOff = System.Drawing.Color.Red
        Me.KL_Aux100.ColorOn = System.Drawing.Color.DarkGray
        Me.KL_Aux100.Data = False
        Me.KL_Aux100.Line = True
        Me.KL_Aux100.LineSize = 1
        Me.KL_Aux100.Location = New System.Drawing.Point(682, 186)
        Me.KL_Aux100.Name = "KL_Aux100"
        Me.KL_Aux100.Size = New System.Drawing.Size(24, 23)
        Me.KL_Aux100.TabIndex = 377
        Me.KL_Aux100.Text = "KL_Aux100"
        Me.KL_Aux100.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Temp40
        '
        Me.Temp40.BindControl = Me.KL_Temp40
        Me.Temp40.BindProperty = "Data"
        Me.Temp40.Data = Nothing
        Me.Temp40.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Temp40.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Temp40.VariableName = "MAIN.InMoldDrying.HydraulicsMain.ixTemperatureSwitch40c"
        '
        'KL_Temp40
        '
        Me.KL_Temp40.ColorOff = System.Drawing.Color.DarkGray
        Me.KL_Temp40.ColorOn = System.Drawing.Color.Red
        Me.KL_Temp40.Data = False
        Me.KL_Temp40.Line = True
        Me.KL_Temp40.LineSize = 1
        Me.KL_Temp40.Location = New System.Drawing.Point(683, 292)
        Me.KL_Temp40.Name = "KL_Temp40"
        Me.KL_Temp40.Size = New System.Drawing.Size(24, 23)
        Me.KL_Temp40.TabIndex = 381
        Me.KL_Temp40.Text = "KL_Temp40"
        Me.KL_Temp40.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Temp55
        '
        Me.Temp55.BindControl = Me.KL_Temp55
        Me.Temp55.BindProperty = "Data"
        Me.Temp55.Data = Nothing
        Me.Temp55.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Temp55.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Temp55.VariableName = "MAIN.InMoldDrying.HydraulicsMain.ixTemperatureSwitch55c"
        '
        'KL_Temp55
        '
        Me.KL_Temp55.ColorOff = System.Drawing.Color.DarkGray
        Me.KL_Temp55.ColorOn = System.Drawing.Color.Red
        Me.KL_Temp55.Data = False
        Me.KL_Temp55.Line = True
        Me.KL_Temp55.LineSize = 1
        Me.KL_Temp55.Location = New System.Drawing.Point(683, 315)
        Me.KL_Temp55.Name = "KL_Temp55"
        Me.KL_Temp55.Size = New System.Drawing.Size(24, 23)
        Me.KL_Temp55.TabIndex = 382
        Me.KL_Temp55.Text = "KL_Temp55"
        Me.KL_Temp55.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TempTooHigh
        '
        Me.TempTooHigh.BindControl = Me.KL_TempTooHigh
        Me.TempTooHigh.BindProperty = "Data"
        Me.TempTooHigh.Data = Nothing
        Me.TempTooHigh.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TempTooHigh.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TempTooHigh.VariableName = "MAIN.InMoldDrying.HydraulicsMain.ixTemperatureSwitchTooHigh"
        '
        'KL_TempTooHigh
        '
        Me.KL_TempTooHigh.ColorOff = System.Drawing.Color.Red
        Me.KL_TempTooHigh.ColorOn = System.Drawing.Color.DarkGray
        Me.KL_TempTooHigh.Data = False
        Me.KL_TempTooHigh.Line = True
        Me.KL_TempTooHigh.LineSize = 1
        Me.KL_TempTooHigh.Location = New System.Drawing.Point(683, 338)
        Me.KL_TempTooHigh.Name = "KL_TempTooHigh"
        Me.KL_TempTooHigh.Size = New System.Drawing.Size(24, 23)
        Me.KL_TempTooHigh.TabIndex = 384
        Me.KL_TempTooHigh.Text = "KL_TooHigh"
        Me.KL_TempTooHigh.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TopMoldReleasedFirst
        '
        Me.TopMoldReleasedFirst.BindControl = Me.IO_TopmoldReleasedFirst
        Me.TopMoldReleasedFirst.BindProperty = "Data"
        Me.TopMoldReleasedFirst.Data = Nothing
        Me.TopMoldReleasedFirst.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.TopMoldReleasedFirst.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TopMoldReleasedFirst.VariableName = "MAIN.InMoldDrying.TopLateTime"
        '
        'IO_TopmoldReleasedFirst
        '
        Me.IO_TopmoldReleasedFirst.Audit = Nothing
        Me.IO_TopmoldReleasedFirst.AuditEnabled = False
        Me.IO_TopmoldReleasedFirst.AuditMessage = "KremerIoField changed:"
        Me.IO_TopmoldReleasedFirst.AuditSource = "KremerIoField"
        Me.IO_TopmoldReleasedFirst.BackColor = System.Drawing.SystemColors.Control
        Me.IO_TopmoldReleasedFirst.Data = 0R
        Me.IO_TopmoldReleasedFirst.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TopmoldReleasedFirst.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TopmoldReleasedFirst.InitialValue = True
        Me.IO_TopmoldReleasedFirst.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_TopmoldReleasedFirst.Location = New System.Drawing.Point(314, 262)
        Me.IO_TopmoldReleasedFirst.LowerBound = 0R
        Me.IO_TopmoldReleasedFirst.Name = "IO_TopmoldReleasedFirst"
        Me.IO_TopmoldReleasedFirst.OutputFormat = "0 ms"
        Me.IO_TopmoldReleasedFirst.Size = New System.Drawing.Size(75, 22)
        Me.IO_TopmoldReleasedFirst.TabIndex = 394
        Me.IO_TopmoldReleasedFirst.Text = "0 ms"
        Me.IO_TopmoldReleasedFirst.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TopmoldReleasedFirst.UpperBound = 5000.0R
        Me.IO_TopmoldReleasedFirst.UserInfo = Nothing
        Me.IO_TopmoldReleasedFirst.UserLevel = 800
        '
        'TransferReleasedFirst
        '
        Me.TransferReleasedFirst.BindControl = Me.IO_TransferReleasedFirst
        Me.TransferReleasedFirst.BindProperty = "Data"
        Me.TransferReleasedFirst.Data = Nothing
        Me.TransferReleasedFirst.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.TransferReleasedFirst.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TransferReleasedFirst.VariableName = "MAIN.InMoldDrying.TransferLateTime"
        '
        'IO_TransferReleasedFirst
        '
        Me.IO_TransferReleasedFirst.Audit = Nothing
        Me.IO_TransferReleasedFirst.AuditEnabled = False
        Me.IO_TransferReleasedFirst.AuditMessage = "KremerIoField changed:"
        Me.IO_TransferReleasedFirst.AuditSource = "KremerIoField"
        Me.IO_TransferReleasedFirst.BackColor = System.Drawing.SystemColors.Control
        Me.IO_TransferReleasedFirst.Data = 0R
        Me.IO_TransferReleasedFirst.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TransferReleasedFirst.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TransferReleasedFirst.InitialValue = True
        Me.IO_TransferReleasedFirst.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_TransferReleasedFirst.Location = New System.Drawing.Point(314, 241)
        Me.IO_TransferReleasedFirst.LowerBound = 0R
        Me.IO_TransferReleasedFirst.Name = "IO_TransferReleasedFirst"
        Me.IO_TransferReleasedFirst.OutputFormat = "0 ms"
        Me.IO_TransferReleasedFirst.Size = New System.Drawing.Size(75, 22)
        Me.IO_TransferReleasedFirst.TabIndex = 393
        Me.IO_TransferReleasedFirst.Text = "0 ms"
        Me.IO_TransferReleasedFirst.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TransferReleasedFirst.UpperBound = 5000.0R
        Me.IO_TransferReleasedFirst.UserInfo = Nothing
        Me.IO_TransferReleasedFirst.UserLevel = 800
        '
        'mxStartHydraulics
        '
        Me.mxStartHydraulics.BindControl = Me.BtnStart
        Me.mxStartHydraulics.BindProperty = "Data"
        Me.mxStartHydraulics.Data = Nothing
        Me.mxStartHydraulics.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.mxStartHydraulics.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.mxStartHydraulics.VariableName = "MAIN.mxHMI_StartHydraulics"
        '
        'BtnStart
        '
        Me.BtnStart.Audit = Nothing
        Me.BtnStart.AuditEnabled = False
        Me.BtnStart.AuditMessage = "KremerPushButton pressed!"
        Me.BtnStart.AuditSource = "KremerPushButton"
        Me.BtnStart.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnStart.BackGroundImageOn = Nothing
        Me.BtnStart.ButtonAction = KremerControlsWin32.KremerButton.Action.SetBool
        Me.BtnStart.Data = False
        Me.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStart.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnStart.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnStart.Location = New System.Drawing.Point(173, 35)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(106, 36)
        Me.BtnStart.State = False
        Me.BtnStart.StateIsData = False
        Me.BtnStart.StateText = New String() {Nothing, Nothing}
        Me.BtnStart.TabIndex = 366
        Me.BtnStart.Tag = "53"
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UserInfo = Nothing
        Me.BtnStart.UserLevel = 0
        Me.BtnStart.UseStateText = False
        Me.BtnStart.UseVisualStyleBackColor = False
        '
        'mxStartHydraulicsState
        '
        Me.mxStartHydraulicsState.BindControl = Me.BtnStart
        Me.mxStartHydraulicsState.BindProperty = "State"
        Me.mxStartHydraulicsState.Data = Nothing
        Me.mxStartHydraulicsState.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.mxStartHydraulicsState.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.mxStartHydraulicsState.VariableName = "MAIN.mxHMI_StartHydraulicsState"
        '
        'mxStopHydraulics
        '
        Me.mxStopHydraulics.BindControl = Me.BtnStop
        Me.mxStopHydraulics.BindProperty = "Data"
        Me.mxStopHydraulics.Data = Nothing
        Me.mxStopHydraulics.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.mxStopHydraulics.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.mxStopHydraulics.VariableName = "MAIN.mxHMI_StopHydraulics"
        '
        'BtnStop
        '
        Me.BtnStop.Audit = Nothing
        Me.BtnStop.AuditEnabled = False
        Me.BtnStop.AuditMessage = "KremerPushButton pressed!"
        Me.BtnStop.AuditSource = "KremerPushButton"
        Me.BtnStop.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnStop.BackGroundImageOn = Nothing
        Me.BtnStop.ButtonAction = KremerControlsWin32.KremerButton.Action.SetBool
        Me.BtnStop.Data = False
        Me.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStop.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnStop.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnStop.Location = New System.Drawing.Point(285, 35)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(106, 36)
        Me.BtnStop.State = False
        Me.BtnStop.StateIsData = False
        Me.BtnStop.StateText = New String() {Nothing, Nothing}
        Me.BtnStop.TabIndex = 367
        Me.BtnStop.Tag = "54"
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.UserInfo = Nothing
        Me.BtnStop.UserLevel = 0
        Me.BtnStop.UseStateText = False
        Me.BtnStop.UseVisualStyleBackColor = False
        '
        'mxStopHydraulicsState
        '
        Me.mxStopHydraulicsState.BindControl = Me.BtnStop
        Me.mxStopHydraulicsState.BindProperty = "State"
        Me.mxStopHydraulicsState.Data = Nothing
        Me.mxStopHydraulicsState.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.mxStopHydraulicsState.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.mxStopHydraulicsState.VariableName = "MAIN.mxHMI_StopHydraulicsState"
        '
        'mxHydraulicStateText
        '
        Me.mxHydraulicStateText.BindControl = Me.StatusHydraulics
        Me.mxHydraulicStateText.BindProperty = "Data"
        Me.mxHydraulicStateText.Data = Nothing
        Me.mxHydraulicStateText.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.mxHydraulicStateText.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.mxHydraulicStateText.VariableName = "MAIN.InMoldDrying.HydraulicsMain.sCycleStateText"
        '
        'StatusHydraulics
        '
        Me.StatusHydraulics.Audit = Nothing
        Me.StatusHydraulics.AuditEnabled = False
        Me.StatusHydraulics.AuditMessage = "KremerTextField changed:"
        Me.StatusHydraulics.AuditSource = "KremerTextField"
        Me.StatusHydraulics.AutoSize = True
        Me.StatusHydraulics.BackColorOn = System.Drawing.Color.Empty
        Me.StatusHydraulics.Data = "Text"
        Me.StatusHydraulics.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusHydraulics.ForeColorOn = System.Drawing.Color.Empty
        Me.StatusHydraulics.InitialValue = True
        Me.StatusHydraulics.IOType = KremerControlsWin32.KremerTextField.IO_Type.InputOutput
        Me.StatusHydraulics.Location = New System.Drawing.Point(66, 74)
        Me.StatusHydraulics.Name = "StatusHydraulics"
        Me.StatusHydraulics.PasswordMask = False
        Me.StatusHydraulics.Size = New System.Drawing.Size(39, 18)
        Me.StatusHydraulics.State = False
        Me.StatusHydraulics.TabIndex = 369
        Me.StatusHydraulics.Text = "Text"
        Me.StatusHydraulics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StatusHydraulics.UserInfo = Nothing
        Me.StatusHydraulics.UserLevel = 0
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 8
        Me.LineShape2.X2 = 390
        Me.LineShape2.Y1 = 32
        Me.LineShape2.Y2 = 32
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape6, Me.LineShape4, Me.LineShape3, Me.LineShape1, Me.LineShape5, Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 435)
        Me.ShapeContainer1.TabIndex = 327
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 6
        Me.LineShape6.X2 = 388
        Me.LineShape6.Y1 = 237
        Me.LineShape6.Y2 = 237
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 412
        Me.LineShape4.X2 = 796
        Me.LineShape4.Y1 = 288
        Me.LineShape4.Y2 = 288
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 409
        Me.LineShape3.X2 = 791
        Me.LineShape3.Y1 = 32
        Me.LineShape3.Y2 = 32
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 8
        Me.LineShape1.X2 = 390
        Me.LineShape1.Y1 = 162
        Me.LineShape1.Y2 = 162
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 409
        Me.LineShape5.X2 = 793
        Me.LineShape5.Y1 = 112
        Me.LineShape5.Y2 = 112
        '
        'lbl_puh
        '
        Me.lbl_puh.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_puh.Location = New System.Drawing.Point(4, 8)
        Me.lbl_puh.Name = "lbl_puh"
        Me.lbl_puh.Size = New System.Drawing.Size(355, 23)
        Me.lbl_puh.TabIndex = 329
        Me.lbl_puh.Tag = ""
        Me.lbl_puh.Text = "Main Hydraulics"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(4, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(355, 23)
        Me.Label3.TabIndex = 348
        Me.Label3.Tag = ""
        Me.Label3.Text = "Heating"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(7, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 22)
        Me.Label4.TabIndex = 346
        Me.Label4.Tag = ""
        Me.Label4.Text = "Enable heating"
        '
        'lblcurrentProduct
        '
        Me.lblcurrentProduct.AutoSize = True
        Me.lblcurrentProduct.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcurrentProduct.Location = New System.Drawing.Point(109, 14)
        Me.lblcurrentProduct.Name = "lblcurrentProduct"
        Me.lblcurrentProduct.Size = New System.Drawing.Size(60, 23)
        Me.lblcurrentProduct.TabIndex = 357
        Me.lblcurrentProduct.Text = "None"
        '
        'ProductPanel
        '
        Me.ProductPanel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProductPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductPanel.Controls.Add(Me.Label12)
        Me.ProductPanel.Controls.Add(Me.lblcurrentProduct)
        Me.ProductPanel.Location = New System.Drawing.Point(11, 306)
        Me.ProductPanel.Name = "ProductPanel"
        Me.ProductPanel.Size = New System.Drawing.Size(374, 73)
        Me.ProductPanel.TabIndex = 358
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 23)
        Me.Label12.TabIndex = 358
        Me.Label12.Tag = "16"
        Me.Label12.Text = "Product:"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(407, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(291, 23)
        Me.Label13.TabIndex = 359
        Me.Label13.Tag = ""
        Me.Label13.Text = "Pulping information"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(407, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 23)
        Me.Label14.TabIndex = 363
        Me.Label14.Tag = ""
        Me.Label14.Text = "Tank 02"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(407, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 23)
        Me.Label15.TabIndex = 362
        Me.Label15.Tag = ""
        Me.Label15.Text = "Tank 01"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 23)
        Me.Label10.TabIndex = 368
        Me.Label10.Tag = ""
        Me.Label10.Text = "State:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(407, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(355, 23)
        Me.Label9.TabIndex = 351
        Me.Label9.Tag = ""
        Me.Label9.Text = "Hydraulic system details"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(407, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(243, 23)
        Me.Label5.TabIndex = 370
        Me.Label5.Tag = ""
        Me.Label5.Text = "Pressure filter 75% dirty"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(407, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 23)
        Me.Label2.TabIndex = 374
        Me.Label2.Tag = ""
        Me.Label2.Text = "Pressure filter 100% dirty"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(407, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(243, 23)
        Me.Label6.TabIndex = 376
        Me.Label6.Tag = ""
        Me.Label6.Text = "Auxilliary filter 75% dirty"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(407, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(243, 23)
        Me.Label7.TabIndex = 378
        Me.Label7.Tag = ""
        Me.Label7.Text = "Auxilliary filter 100% dirty"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(408, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(355, 23)
        Me.Label8.TabIndex = 379
        Me.Label8.Tag = ""
        Me.Label8.Text = "Hydraulic temperature details"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(408, 338)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(243, 23)
        Me.Label16.TabIndex = 385
        Me.Label16.Tag = ""
        Me.Label16.Text = "Oil temperature too high"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(408, 315)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(243, 23)
        Me.Label17.TabIndex = 383
        Me.Label17.Tag = ""
        Me.Label17.Text = "Temperature Higher than 55 degree"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(408, 292)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(243, 23)
        Me.Label18.TabIndex = 380
        Me.Label18.Tag = ""
        Me.Label18.Text = "Temperature Higher than 40 degree"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(408, 232)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(243, 23)
        Me.Label11.TabIndex = 389
        Me.Label11.Tag = ""
        Me.Label11.Text = "Oil level too low"
        '
        'KL_OilLvlTooLow
        '
        Me.KL_OilLvlTooLow.ColorOff = System.Drawing.Color.DarkGray
        Me.KL_OilLvlTooLow.ColorOn = System.Drawing.Color.Red
        Me.KL_OilLvlTooLow.Data = False
        Me.KL_OilLvlTooLow.Line = True
        Me.KL_OilLvlTooLow.LineSize = 1
        Me.KL_OilLvlTooLow.Location = New System.Drawing.Point(683, 232)
        Me.KL_OilLvlTooLow.Name = "KL_OilLvlTooLow"
        Me.KL_OilLvlTooLow.Size = New System.Drawing.Size(24, 23)
        Me.KL_OilLvlTooLow.TabIndex = 388
        Me.KL_OilLvlTooLow.Text = "KremerLight3"
        Me.KL_OilLvlTooLow.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(408, 209)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(243, 23)
        Me.Label19.TabIndex = 387
        Me.Label19.Tag = ""
        Me.Label19.Text = "Oil level low"
        '
        'KL_OilLvlLow
        '
        Me.KL_OilLvlLow.ColorOff = System.Drawing.Color.DarkGray
        Me.KL_OilLvlLow.ColorOn = System.Drawing.Color.Red
        Me.KL_OilLvlLow.Data = False
        Me.KL_OilLvlLow.Line = True
        Me.KL_OilLvlLow.LineSize = 1
        Me.KL_OilLvlLow.Location = New System.Drawing.Point(683, 209)
        Me.KL_OilLvlLow.Name = "KL_OilLvlLow"
        Me.KL_OilLvlLow.Size = New System.Drawing.Size(24, 23)
        Me.KL_OilLvlLow.TabIndex = 386
        Me.KL_OilLvlLow.Text = "KremerLight4"
        Me.KL_OilLvlLow.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(8, 242)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(243, 22)
        Me.Label20.TabIndex = 390
        Me.Label20.Tag = ""
        Me.Label20.Text = "Transfermold released first"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.Location = New System.Drawing.Point(4, 212)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(355, 23)
        Me.Label21.TabIndex = 391
        Me.Label21.Tag = ""
        Me.Label21.Text = "Process and drying time"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.Location = New System.Drawing.Point(8, 262)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(243, 22)
        Me.Label22.TabIndex = 392
        Me.Label22.Tag = ""
        Me.Label22.Text = "Topmold released first"
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(8, 95)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(86, 23)
        Me.Label23.TabIndex = 395
        Me.Label23.Tag = ""
        Me.Label23.Text = "Topmold A"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(174, 95)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(70, 23)
        Me.Label24.TabIndex = 396
        Me.Label24.Tag = ""
        Me.Label24.Text = "Transfer"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(311, 95)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 23)
        Me.Label25.TabIndex = 397
        Me.Label25.Tag = ""
        Me.Label25.Text = "Topmold B"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'General
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.IO_TMB_Percentage)
        Me.Controls.Add(Me.IO_Tr_Percentage)
        Me.Controls.Add(Me.IO_TMA_Percentage)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.IO_TopmoldReleasedFirst)
        Me.Controls.Add(Me.IO_TransferReleasedFirst)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.KL_OilLvlTooLow)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.KL_OilLvlLow)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.KL_TempTooHigh)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.KL_Temp55)
        Me.Controls.Add(Me.KL_Temp40)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.KL_Aux100)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.KL_Aux75)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.KL_Press100)
        Me.Controls.Add(Me.KL_Press75)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.StatusHydraulics)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.KremerLight2)
        Me.Controls.Add(Me.KremerLight1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.IO_Tank1)
        Me.Controls.Add(Me.IO_Tank2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ProductPanel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEnableHeating)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_puh)
        Me.Controls.Add(Me.btnShutDown)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUsers)
        Me.Controls.Add(Me.btnCleanScreen)
        Me.Controls.Add(Me.btnLang)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.KremerButton1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "General"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "6"
        Me.ProductPanel.ResumeLayout(False)
        Me.ProductPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLang As KremerControlsWin32.KremerButton
    Friend WithEvents btnClose As KremerControlsWin32.KremerButton
    Friend WithEvents btnLogout As KremerControlsWin32.KremerButton
    Friend WithEvents btnLogin As KremerControlsWin32.KremerButton
    Friend WithEvents btnCleanScreen As KremerControlsWin32.KremerButton
    Friend WithEvents krConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents krVarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents btnUsers As KremerControlsWin32.KremerButton
    Friend WithEvents KremerButton1 As KremerControlsWin32.KremerButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnShutDown As KremerControlsWin32.KremerButton
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lbl_puh As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnEnableHeating As KremerControlsWin32.KremerButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents EnableHeating As KremerControlsWin32.KremerVariable
    Friend WithEvents lblcurrentProduct As System.Windows.Forms.Label
    Friend WithEvents ProductPanel As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Pulplvl1 As KremerControlsWin32.KremerVariable
    Friend WithEvents Pulplvl2 As KremerControlsWin32.KremerVariable
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents IO_Tank2 As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_Tank1 As KremerControlsWin32.KremerIoField
    Friend WithEvents ActiveTank1 As KremerControlsWin32.KremerVariable
    Friend WithEvents KremerLight1 As KremerControlsWin32.KremerLight
    Friend WithEvents ActiveTank2 As KremerControlsWin32.KremerVariable
    Friend WithEvents KremerLight2 As KremerControlsWin32.KremerLight
    Friend WithEvents BtnStart As KremerControlsWin32.KremerButton
    Friend WithEvents BtnStop As KremerControlsWin32.KremerButton
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents StatusHydraulics As KremerControlsWin32.KremerTextField
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents KL_Press100 As KremerControlsWin32.KremerLight
    Friend WithEvents KL_Press75 As KremerControlsWin32.KremerLight
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents KL_Aux75 As KremerControlsWin32.KremerLight
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents KL_Aux100 As KremerControlsWin32.KremerLight
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents mxStartHydraulics As KremerControlsWin32.KremerVariable
    Friend WithEvents mxStopHydraulics As KremerControlsWin32.KremerVariable
    Friend WithEvents PressFilt75 As KremerControlsWin32.KremerVariable
    Friend WithEvents PressFilt100 As KremerControlsWin32.KremerVariable
    Friend WithEvents PressAux75 As KremerControlsWin32.KremerVariable
    Friend WithEvents PressAux100 As KremerControlsWin32.KremerVariable
    Friend WithEvents Temp40 As KremerControlsWin32.KremerVariable
    Friend WithEvents Temp55 As KremerControlsWin32.KremerVariable
    Friend WithEvents TempTooHigh As KremerControlsWin32.KremerVariable
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents KL_TempTooHigh As KremerControlsWin32.KremerLight
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents KL_Temp55 As KremerControlsWin32.KremerLight
    Friend WithEvents KL_Temp40 As KremerControlsWin32.KremerLight
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents KL_OilLvlTooLow As KremerControlsWin32.KremerLight
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents KL_OilLvlLow As KremerControlsWin32.KremerLight
    Friend WithEvents mxStartHydraulicsState As KremerControlsWin32.KremerVariable
    Friend WithEvents mxStopHydraulicsState As KremerControlsWin32.KremerVariable
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents IO_TransferReleasedFirst As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_TopmoldReleasedFirst As KremerControlsWin32.KremerIoField
    Friend WithEvents TransferReleasedFirst As KremerControlsWin32.KremerVariable
    Friend WithEvents TopMoldReleasedFirst As KremerControlsWin32.KremerVariable
    Friend WithEvents mxHydraulicStateText As KremerControlsWin32.KremerVariable
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents IO_TMA_Percentage As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_Tr_Percentage As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_TMB_Percentage As KremerControlsWin32.KremerIoField
    Friend WithEvents TMAControl As KremerControlsWin32.KremerVariable
    Friend WithEvents TMBControl As KremerControlsWin32.KremerVariable
    Friend WithEvents TR_Control As KremerControlsWin32.KremerVariable

End Class
