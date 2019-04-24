<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransferMold_Manual
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
        Me.Btn_Settings = New KremerControlsWin32.KremerButton()
        Me.Btn_Overview = New KremerControlsWin32.KremerButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.mxAutomode = New KremerControlsWin32.KremerVariable(Me.components)
        Me.VacuumOn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_VacuumValve = New KremerControlsWin32.KremerButton()
        Me.BlowoffOn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_BlowOffValve = New KremerControlsWin32.KremerButton()
        Me.Up = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TransferUp = New KremerControlsWin32.KremerButton()
        Me.SlowUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnTransferUpSlow = New KremerControlsWin32.KremerButton()
        Me.CreepUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnTransferUpCreep = New KremerControlsWin32.KremerButton()
        Me.Down = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TransferDown = New KremerControlsWin32.KremerButton()
        Me.SlowDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnTransferDownSlow = New KremerControlsWin32.KremerButton()
        Me.CreepDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnTransferDownCreep = New KremerControlsWin32.KremerButton()
        Me.CylinderPos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.io_ActPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Settings
        '
        Me.Btn_Settings.Audit = Nothing
        Me.Btn_Settings.AuditEnabled = False
        Me.Btn_Settings.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_Settings.AuditSource = "KremerPushButton"
        Me.Btn_Settings.BackColorOn = System.Drawing.Color.Empty
        Me.Btn_Settings.BackGroundImageOn = Nothing
        Me.Btn_Settings.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_Settings.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_Settings.Data = False
        Me.Btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Settings.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Settings.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_Settings.Location = New System.Drawing.Point(684, 324)
        Me.Btn_Settings.Name = "Btn_Settings"
        Me.Btn_Settings.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Settings.State = False
        Me.Btn_Settings.StateIsData = True
        Me.Btn_Settings.StateText = New String() {Nothing, Nothing}
        Me.Btn_Settings.TabIndex = 8
        Me.Btn_Settings.Tag = "193"
        Me.Btn_Settings.Text = "Settings"
        Me.Btn_Settings.UserInfo = Nothing
        Me.Btn_Settings.UserLevel = 0
        Me.Btn_Settings.UseStateText = False
        Me.Btn_Settings.UseVisualStyleBackColor = True
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
        Me.Btn_Overview.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Overview.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_Overview.Location = New System.Drawing.Point(684, 380)
        Me.Btn_Overview.Name = "Btn_Overview"
        Me.Btn_Overview.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Overview.State = False
        Me.Btn_Overview.StateIsData = True
        Me.Btn_Overview.StateText = New String() {Nothing, Nothing}
        Me.Btn_Overview.TabIndex = 7
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
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 435)
        Me.ShapeContainer1.TabIndex = 242
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 25
        Me.LineShape3.X2 = 395
        Me.LineShape3.Y1 = 50
        Me.LineShape3.Y2 = 50
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 18
        Me.LineShape2.X2 = 388
        Me.LineShape2.Y1 = 203
        Me.LineShape2.Y2 = 203
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(21, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(291, 23)
        Me.Label3.TabIndex = 243
        Me.Label3.Tag = "285"
        Me.Label3.Text = "Valves"
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Me.VarCollector
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.mxAutomode)
        Me.VarCollector.Variables.Add(Me.VacuumOn)
        Me.VarCollector.Variables.Add(Me.BlowoffOn)
        Me.VarCollector.Variables.Add(Me.Up)
        Me.VarCollector.Variables.Add(Me.SlowUp)
        Me.VarCollector.Variables.Add(Me.CreepUp)
        Me.VarCollector.Variables.Add(Me.Down)
        Me.VarCollector.Variables.Add(Me.SlowDown)
        Me.VarCollector.Variables.Add(Me.CreepDown)
        Me.VarCollector.Variables.Add(Me.CylinderPos)
        '
        'mxAutomode
        '
        Me.mxAutomode.BindControl = Nothing
        Me.mxAutomode.BindProperty = "Data"
        Me.mxAutomode.Data = Nothing
        Me.mxAutomode.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.mxAutomode.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.mxAutomode.VariableName = "HMI.mxAutomode"
        '
        'VacuumOn
        '
        Me.VacuumOn.BindControl = Me.IO_VacuumValve
        Me.VacuumOn.BindProperty = "Data"
        Me.VacuumOn.Data = Nothing
        Me.VacuumOn.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.VacuumOn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.VacuumOn.VariableName = "MAIN.InMoldDrying.TransferMold.Vacuum.mxHMI_On"
        '
        'IO_VacuumValve
        '
        Me.IO_VacuumValve.Audit = Nothing
        Me.IO_VacuumValve.AuditEnabled = False
        Me.IO_VacuumValve.AuditMessage = "KremerPushButton pressed!"
        Me.IO_VacuumValve.AuditSource = "KremerPushButton"
        Me.IO_VacuumValve.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IO_VacuumValve.BackGroundImageOn = Nothing
        Me.IO_VacuumValve.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.IO_VacuumValve.Data = False
        Me.IO_VacuumValve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IO_VacuumValve.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.IO_VacuumValve.ForeColorOn = System.Drawing.Color.Yellow
        Me.IO_VacuumValve.Location = New System.Drawing.Point(284, 53)
        Me.IO_VacuumValve.Name = "IO_VacuumValve"
        Me.IO_VacuumValve.Size = New System.Drawing.Size(106, 36)
        Me.IO_VacuumValve.State = False
        Me.IO_VacuumValve.StateIsData = True
        Me.IO_VacuumValve.StateText = New String() {Nothing, Nothing}
        Me.IO_VacuumValve.TabIndex = 295
        Me.IO_VacuumValve.Tag = "293"
        Me.IO_VacuumValve.Text = "On"
        Me.IO_VacuumValve.UserInfo = Nothing
        Me.IO_VacuumValve.UserLevel = 0
        Me.IO_VacuumValve.UseStateText = False
        '
        'BlowoffOn
        '
        Me.BlowoffOn.BindControl = Me.IO_BlowOffValve
        Me.BlowoffOn.BindProperty = "Data"
        Me.BlowoffOn.Data = Nothing
        Me.BlowoffOn.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BlowoffOn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BlowoffOn.VariableName = "MAIN.InMoldDrying.TransferMold.BlowOff.mxHMI_On"
        '
        'IO_BlowOffValve
        '
        Me.IO_BlowOffValve.Audit = Nothing
        Me.IO_BlowOffValve.AuditEnabled = False
        Me.IO_BlowOffValve.AuditMessage = "KremerPushButton pressed!"
        Me.IO_BlowOffValve.AuditSource = "KremerPushButton"
        Me.IO_BlowOffValve.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IO_BlowOffValve.BackGroundImageOn = Nothing
        Me.IO_BlowOffValve.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.IO_BlowOffValve.Data = False
        Me.IO_BlowOffValve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IO_BlowOffValve.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.IO_BlowOffValve.ForeColorOn = System.Drawing.Color.Yellow
        Me.IO_BlowOffValve.Location = New System.Drawing.Point(284, 93)
        Me.IO_BlowOffValve.Name = "IO_BlowOffValve"
        Me.IO_BlowOffValve.Size = New System.Drawing.Size(106, 36)
        Me.IO_BlowOffValve.State = False
        Me.IO_BlowOffValve.StateIsData = True
        Me.IO_BlowOffValve.StateText = New String() {Nothing, Nothing}
        Me.IO_BlowOffValve.TabIndex = 297
        Me.IO_BlowOffValve.Tag = "293"
        Me.IO_BlowOffValve.Text = "On"
        Me.IO_BlowOffValve.UserInfo = Nothing
        Me.IO_BlowOffValve.UserLevel = 0
        Me.IO_BlowOffValve.UseStateText = False
        '
        'Up
        '
        Me.Up.BindControl = Me.IO_TransferUp
        Me.Up.BindProperty = "Data"
        Me.Up.Data = Nothing
        Me.Up.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Up.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Up.VariableName = "MAIN.InMoldDrying.TransferMold.HydraulicCilinder.ManUp"
        '
        'IO_TransferUp
        '
        Me.IO_TransferUp.Audit = Nothing
        Me.IO_TransferUp.AuditEnabled = False
        Me.IO_TransferUp.AuditMessage = "KremerPushButton pressed!"
        Me.IO_TransferUp.AuditSource = "KremerPushButton"
        Me.IO_TransferUp.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IO_TransferUp.BackGroundImageOn = Nothing
        Me.IO_TransferUp.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.IO_TransferUp.Data = False
        Me.IO_TransferUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IO_TransferUp.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.IO_TransferUp.ForeColorOn = System.Drawing.Color.Yellow
        Me.IO_TransferUp.Location = New System.Drawing.Point(172, 211)
        Me.IO_TransferUp.Name = "IO_TransferUp"
        Me.IO_TransferUp.Size = New System.Drawing.Size(106, 36)
        Me.IO_TransferUp.State = False
        Me.IO_TransferUp.StateIsData = True
        Me.IO_TransferUp.StateText = New String() {Nothing, Nothing}
        Me.IO_TransferUp.TabIndex = 267
        Me.IO_TransferUp.Tag = "290"
        Me.IO_TransferUp.Text = "Up"
        Me.IO_TransferUp.UserInfo = Nothing
        Me.IO_TransferUp.UserLevel = 0
        Me.IO_TransferUp.UseStateText = False
        '
        'SlowUp
        '
        Me.SlowUp.BindControl = Me.BtnTransferUpSlow
        Me.SlowUp.BindProperty = "Data"
        Me.SlowUp.Data = Nothing
        Me.SlowUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.SlowUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SlowUp.VariableName = "MAIN.InMoldDrying.TransferMold.HydraulicCilinder.ManSlowUp"
        '
        'BtnTransferUpSlow
        '
        Me.BtnTransferUpSlow.Audit = Nothing
        Me.BtnTransferUpSlow.AuditEnabled = False
        Me.BtnTransferUpSlow.AuditMessage = "KremerPushButton pressed!"
        Me.BtnTransferUpSlow.AuditSource = "KremerPushButton"
        Me.BtnTransferUpSlow.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnTransferUpSlow.BackGroundImageOn = Nothing
        Me.BtnTransferUpSlow.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnTransferUpSlow.Data = False
        Me.BtnTransferUpSlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTransferUpSlow.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnTransferUpSlow.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnTransferUpSlow.Location = New System.Drawing.Point(172, 253)
        Me.BtnTransferUpSlow.Name = "BtnTransferUpSlow"
        Me.BtnTransferUpSlow.Size = New System.Drawing.Size(106, 36)
        Me.BtnTransferUpSlow.State = False
        Me.BtnTransferUpSlow.StateIsData = True
        Me.BtnTransferUpSlow.StateText = New String() {Nothing, Nothing}
        Me.BtnTransferUpSlow.TabIndex = 346
        Me.BtnTransferUpSlow.Tag = "295"
        Me.BtnTransferUpSlow.Text = "Up slow"
        Me.BtnTransferUpSlow.UserInfo = Nothing
        Me.BtnTransferUpSlow.UserLevel = 0
        Me.BtnTransferUpSlow.UseStateText = False
        Me.BtnTransferUpSlow.UseVisualStyleBackColor = False
        '
        'CreepUp
        '
        Me.CreepUp.BindControl = Me.BtnTransferUpCreep
        Me.CreepUp.BindProperty = "Data"
        Me.CreepUp.Data = Nothing
        Me.CreepUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.CreepUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.CreepUp.VariableName = "MAIN.InMoldDrying.TransferMold.HydraulicCilinder.ManCreepUp"
        '
        'BtnTransferUpCreep
        '
        Me.BtnTransferUpCreep.Audit = Nothing
        Me.BtnTransferUpCreep.AuditEnabled = False
        Me.BtnTransferUpCreep.AuditMessage = "KremerPushButton pressed!"
        Me.BtnTransferUpCreep.AuditSource = "KremerPushButton"
        Me.BtnTransferUpCreep.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnTransferUpCreep.BackGroundImageOn = Nothing
        Me.BtnTransferUpCreep.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnTransferUpCreep.Data = False
        Me.BtnTransferUpCreep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTransferUpCreep.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnTransferUpCreep.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnTransferUpCreep.Location = New System.Drawing.Point(172, 295)
        Me.BtnTransferUpCreep.Name = "BtnTransferUpCreep"
        Me.BtnTransferUpCreep.Size = New System.Drawing.Size(106, 36)
        Me.BtnTransferUpCreep.State = False
        Me.BtnTransferUpCreep.StateIsData = True
        Me.BtnTransferUpCreep.StateText = New String() {Nothing, Nothing}
        Me.BtnTransferUpCreep.TabIndex = 347
        Me.BtnTransferUpCreep.Tag = "297"
        Me.BtnTransferUpCreep.Text = "Up creep"
        Me.BtnTransferUpCreep.UserInfo = Nothing
        Me.BtnTransferUpCreep.UserLevel = 0
        Me.BtnTransferUpCreep.UseStateText = False
        Me.BtnTransferUpCreep.UseVisualStyleBackColor = False
        '
        'Down
        '
        Me.Down.BindControl = Me.IO_TransferDown
        Me.Down.BindProperty = "Data"
        Me.Down.Data = Nothing
        Me.Down.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Down.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Down.VariableName = "MAIN.InMoldDrying.TransferMold.HydraulicCilinder.ManDown"
        '
        'IO_TransferDown
        '
        Me.IO_TransferDown.Audit = Nothing
        Me.IO_TransferDown.AuditEnabled = False
        Me.IO_TransferDown.AuditMessage = "KremerPushButton pressed!"
        Me.IO_TransferDown.AuditSource = "KremerPushButton"
        Me.IO_TransferDown.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IO_TransferDown.BackGroundImageOn = Nothing
        Me.IO_TransferDown.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.IO_TransferDown.Data = False
        Me.IO_TransferDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IO_TransferDown.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.IO_TransferDown.ForeColorOn = System.Drawing.Color.Yellow
        Me.IO_TransferDown.Location = New System.Drawing.Point(284, 211)
        Me.IO_TransferDown.Name = "IO_TransferDown"
        Me.IO_TransferDown.Size = New System.Drawing.Size(106, 36)
        Me.IO_TransferDown.State = False
        Me.IO_TransferDown.StateIsData = True
        Me.IO_TransferDown.StateText = New String() {Nothing, Nothing}
        Me.IO_TransferDown.TabIndex = 268
        Me.IO_TransferDown.Tag = "291"
        Me.IO_TransferDown.Text = "Down"
        Me.IO_TransferDown.UserInfo = Nothing
        Me.IO_TransferDown.UserLevel = 0
        Me.IO_TransferDown.UseStateText = False
        '
        'SlowDown
        '
        Me.SlowDown.BindControl = Me.BtnTransferDownSlow
        Me.SlowDown.BindProperty = "Data"
        Me.SlowDown.Data = Nothing
        Me.SlowDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.SlowDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SlowDown.VariableName = "MAIN.InMoldDrying.TransferMold.HydraulicCilinder.ManSlowDown"
        '
        'BtnTransferDownSlow
        '
        Me.BtnTransferDownSlow.Audit = Nothing
        Me.BtnTransferDownSlow.AuditEnabled = False
        Me.BtnTransferDownSlow.AuditMessage = "KremerPushButton pressed!"
        Me.BtnTransferDownSlow.AuditSource = "KremerPushButton"
        Me.BtnTransferDownSlow.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnTransferDownSlow.BackGroundImageOn = Nothing
        Me.BtnTransferDownSlow.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnTransferDownSlow.Data = False
        Me.BtnTransferDownSlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTransferDownSlow.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnTransferDownSlow.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnTransferDownSlow.Location = New System.Drawing.Point(284, 253)
        Me.BtnTransferDownSlow.Name = "BtnTransferDownSlow"
        Me.BtnTransferDownSlow.Size = New System.Drawing.Size(106, 36)
        Me.BtnTransferDownSlow.State = False
        Me.BtnTransferDownSlow.StateIsData = True
        Me.BtnTransferDownSlow.StateText = New String() {Nothing, Nothing}
        Me.BtnTransferDownSlow.TabIndex = 348
        Me.BtnTransferDownSlow.Tag = "296"
        Me.BtnTransferDownSlow.Text = "Down slow"
        Me.BtnTransferDownSlow.UserInfo = Nothing
        Me.BtnTransferDownSlow.UserLevel = 0
        Me.BtnTransferDownSlow.UseStateText = False
        '
        'CreepDown
        '
        Me.CreepDown.BindControl = Me.BtnTransferDownCreep
        Me.CreepDown.BindProperty = "Data"
        Me.CreepDown.Data = Nothing
        Me.CreepDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.CreepDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.CreepDown.VariableName = "MAIN.InMoldDrying.TransferMold.HydraulicCilinder.ManCreepDown"
        '
        'BtnTransferDownCreep
        '
        Me.BtnTransferDownCreep.Audit = Nothing
        Me.BtnTransferDownCreep.AuditEnabled = False
        Me.BtnTransferDownCreep.AuditMessage = "KremerPushButton pressed!"
        Me.BtnTransferDownCreep.AuditSource = "KremerPushButton"
        Me.BtnTransferDownCreep.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnTransferDownCreep.BackGroundImageOn = Nothing
        Me.BtnTransferDownCreep.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnTransferDownCreep.Data = False
        Me.BtnTransferDownCreep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTransferDownCreep.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnTransferDownCreep.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnTransferDownCreep.Location = New System.Drawing.Point(284, 295)
        Me.BtnTransferDownCreep.Name = "BtnTransferDownCreep"
        Me.BtnTransferDownCreep.Size = New System.Drawing.Size(106, 36)
        Me.BtnTransferDownCreep.State = False
        Me.BtnTransferDownCreep.StateIsData = True
        Me.BtnTransferDownCreep.StateText = New String() {Nothing, Nothing}
        Me.BtnTransferDownCreep.TabIndex = 349
        Me.BtnTransferDownCreep.Tag = "298"
        Me.BtnTransferDownCreep.Text = "Down creep"
        Me.BtnTransferDownCreep.UserInfo = Nothing
        Me.BtnTransferDownCreep.UserLevel = 0
        Me.BtnTransferDownCreep.UseStateText = False
        Me.BtnTransferDownCreep.UseVisualStyleBackColor = False
        '
        'CylinderPos
        '
        Me.CylinderPos.BindControl = Me.io_ActPos
        Me.CylinderPos.BindProperty = "Data"
        Me.CylinderPos.Data = Nothing
        Me.CylinderPos.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.CylinderPos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.CylinderPos.VariableName = "MAIN.InMoldDrying.TransferMold.HydraulicCilinder.ActPosition"
        '
        'io_ActPos
        '
        Me.io_ActPos.Audit = Nothing
        Me.io_ActPos.AuditEnabled = False
        Me.io_ActPos.AuditMessage = "KremerIoField changed:"
        Me.io_ActPos.AuditSource = "KremerIoField"
        Me.io_ActPos.Data = 0.0R
        Me.io_ActPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.io_ActPos.InitialValue = True
        Me.io_ActPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.io_ActPos.Location = New System.Drawing.Point(318, 179)
        Me.io_ActPos.LowerBound = 0.0R
        Me.io_ActPos.Name = "io_ActPos"
        Me.io_ActPos.OutputFormat = "0.0 mm"
        Me.io_ActPos.Size = New System.Drawing.Size(71, 21)
        Me.io_ActPos.TabIndex = 261
        Me.io_ActPos.Text = "0,0 mm"
        Me.io_ActPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.io_ActPos.UpperBound = 1000.0R
        Me.io_ActPos.UserInfo = Nothing
        Me.io_ActPos.UserLevel = 0
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 23)
        Me.Label4.TabIndex = 266
        Me.Label4.Tag = "289"
        Me.Label4.Text = "Hydraulic cylinder"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(14, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 23)
        Me.Label1.TabIndex = 262
        Me.Label1.Tag = "288"
        Me.Label1.Text = "Cylinder"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 23)
        Me.Label2.TabIndex = 296
        Me.Label2.Tag = "287"
        Me.Label2.Text = "Blowoff valve"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(240, 23)
        Me.Label5.TabIndex = 294
        Me.Label5.Tag = "286"
        Me.Label5.Text = "Vacuum valve"
        '
        'TransferMold_Manual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnTransferDownCreep)
        Me.Controls.Add(Me.BtnTransferDownSlow)
        Me.Controls.Add(Me.BtnTransferUpCreep)
        Me.Controls.Add(Me.BtnTransferUpSlow)
        Me.Controls.Add(Me.IO_BlowOffValve)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IO_VacuumValve)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.IO_TransferDown)
        Me.Controls.Add(Me.IO_TransferUp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.io_ActPos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btn_Settings)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "TransferMold_Manual"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "94"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Settings As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents mxAutomode As KremerControlsWin32.KremerVariable
    Friend WithEvents io_ActPos As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_TransferDown As KremerControlsWin32.KremerButton
    Friend WithEvents IO_TransferUp As KremerControlsWin32.KremerButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents IO_BlowOffValve As KremerControlsWin32.KremerButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IO_VacuumValve As KremerControlsWin32.KremerButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents VacuumOn As KremerControlsWin32.KremerVariable
    Friend WithEvents BlowoffOn As KremerControlsWin32.KremerVariable
    Friend WithEvents Up As KremerControlsWin32.KremerVariable
    Friend WithEvents Down As KremerControlsWin32.KremerVariable
    Friend WithEvents SlowUp As KremerControlsWin32.KremerVariable
    Friend WithEvents CylinderPos As KremerControlsWin32.KremerVariable
    Friend WithEvents BtnTransferDownCreep As KremerControlsWin32.KremerButton
    Friend WithEvents BtnTransferDownSlow As KremerControlsWin32.KremerButton
    Friend WithEvents BtnTransferUpCreep As KremerControlsWin32.KremerButton
    Friend WithEvents BtnTransferUpSlow As KremerControlsWin32.KremerButton
    Friend WithEvents CreepUp As KremerControlsWin32.KremerVariable
    Friend WithEvents SlowDown As KremerControlsWin32.KremerVariable
    Friend WithEvents CreepDown As KremerControlsWin32.KremerVariable

End Class
