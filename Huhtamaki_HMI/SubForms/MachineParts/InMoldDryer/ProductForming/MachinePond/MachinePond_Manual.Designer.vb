<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MachinePond_Manual
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
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lbl_puh = New System.Windows.Forms.Label()
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.BtnMPPulpFeedingOpen = New KremerControlsWin32.KremerButton()
        Me.btn_Settings = New KremerControlsWin32.KremerButton()
        Me.Btn_Overview = New KremerControlsWin32.KremerButton()
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.PulpFeedingOpen = New KremerControlsWin32.KremerVariable(Me.components)
        Me.PulpFeedingClose = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnMPPulpFeedingClose = New KremerControlsWin32.KremerButton()
        Me.HydrUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnHydrUp = New KremerControlsWin32.KremerButton()
        Me.HydrDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnHydrDown = New KremerControlsWin32.KremerButton()
        Me.HydrSlow = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnHydrSlow = New KremerControlsWin32.KremerButton()
        Me.HydrSlowState = New KremerControlsWin32.KremerVariable(Me.components)
        Me.VacuumOn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnFormingVacuumOn = New KremerControlsWin32.KremerButton()
        Me.BlowOffOn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnFormingBlowOffOn = New KremerControlsWin32.KremerButton()
        Me.ActPos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_ActPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 435)
        Me.ShapeContainer1.TabIndex = 205
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 419
        Me.LineShape3.X2 = 789
        Me.LineShape3.Y1 = 42
        Me.LineShape3.Y2 = 42
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 25
        Me.LineShape2.X2 = 395
        Me.LineShape2.Y1 = 215
        Me.LineShape2.Y2 = 215
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 21
        Me.LineShape1.X2 = 391
        Me.LineShape1.Y1 = 43
        Me.LineShape1.Y2 = 43
        '
        'lbl_puh
        '
        Me.lbl_puh.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_puh.Location = New System.Drawing.Point(20, 19)
        Me.lbl_puh.Name = "lbl_puh"
        Me.lbl_puh.Size = New System.Drawing.Size(291, 23)
        Me.lbl_puh.TabIndex = 206
        Me.lbl_puh.Tag = "385"
        Me.lbl_puh.Text = "Machine pond valves"
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'BtnMPPulpFeedingOpen
        '
        Me.BtnMPPulpFeedingOpen.Audit = Nothing
        Me.BtnMPPulpFeedingOpen.AuditEnabled = False
        Me.BtnMPPulpFeedingOpen.AuditMessage = "KremerPushButton pressed!"
        Me.BtnMPPulpFeedingOpen.AuditSource = "KremerPushButton"
        Me.BtnMPPulpFeedingOpen.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnMPPulpFeedingOpen.BackGroundImageOn = Nothing
        Me.BtnMPPulpFeedingOpen.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnMPPulpFeedingOpen.Data = False
        Me.BtnMPPulpFeedingOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMPPulpFeedingOpen.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnMPPulpFeedingOpen.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnMPPulpFeedingOpen.Location = New System.Drawing.Point(175, 50)
        Me.BtnMPPulpFeedingOpen.Name = "BtnMPPulpFeedingOpen"
        Me.BtnMPPulpFeedingOpen.Size = New System.Drawing.Size(106, 36)
        Me.BtnMPPulpFeedingOpen.State = False
        Me.BtnMPPulpFeedingOpen.StateIsData = True
        Me.BtnMPPulpFeedingOpen.StateText = New String() {Nothing, Nothing}
        Me.BtnMPPulpFeedingOpen.TabIndex = 209
        Me.BtnMPPulpFeedingOpen.Tag = "60"
        Me.BtnMPPulpFeedingOpen.Text = "Open"
        Me.BtnMPPulpFeedingOpen.UserInfo = Nothing
        Me.BtnMPPulpFeedingOpen.UserLevel = 0
        Me.BtnMPPulpFeedingOpen.UseStateText = False
        '
        'btn_Settings
        '
        Me.btn_Settings.Audit = Nothing
        Me.btn_Settings.AuditEnabled = False
        Me.btn_Settings.AuditMessage = "KremerPushButton pressed!"
        Me.btn_Settings.AuditSource = "KremerPushButton"
        Me.btn_Settings.BackColorOn = System.Drawing.Color.Empty
        Me.btn_Settings.BackGroundImageOn = Nothing
        Me.btn_Settings.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.btn_Settings.Data = False
        Me.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Settings.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Settings.ForeColorOn = System.Drawing.Color.Empty
        Me.btn_Settings.Location = New System.Drawing.Point(684, 324)
        Me.btn_Settings.Name = "btn_Settings"
        Me.btn_Settings.Size = New System.Drawing.Size(113, 50)
        Me.btn_Settings.State = False
        Me.btn_Settings.StateIsData = True
        Me.btn_Settings.StateText = New String() {Nothing, Nothing}
        Me.btn_Settings.TabIndex = 4
        Me.btn_Settings.Tag = "193"
        Me.btn_Settings.Text = "Settings"
        Me.btn_Settings.UserInfo = Nothing
        Me.btn_Settings.UserLevel = 0
        Me.btn_Settings.UseStateText = False
        Me.btn_Settings.UseVisualStyleBackColor = True
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
        Me.Btn_Overview.Location = New System.Drawing.Point(684, 380)
        Me.Btn_Overview.Name = "Btn_Overview"
        Me.Btn_Overview.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Overview.State = False
        Me.Btn_Overview.StateIsData = True
        Me.Btn_Overview.StateText = New String() {Nothing, Nothing}
        Me.Btn_Overview.TabIndex = 2
        Me.Btn_Overview.Tag = "194"
        Me.Btn_Overview.Text = "Overview"
        Me.Btn_Overview.UserInfo = Nothing
        Me.Btn_Overview.UserLevel = 0
        Me.Btn_Overview.UseStateText = False
        Me.Btn_Overview.UseVisualStyleBackColor = True
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.PulpFeedingOpen)
        Me.VarCollector.Variables.Add(Me.PulpFeedingClose)
        Me.VarCollector.Variables.Add(Me.HydrUp)
        Me.VarCollector.Variables.Add(Me.HydrDown)
        Me.VarCollector.Variables.Add(Me.HydrSlow)
        Me.VarCollector.Variables.Add(Me.HydrSlowState)
        Me.VarCollector.Variables.Add(Me.VacuumOn)
        Me.VarCollector.Variables.Add(Me.BlowOffOn)
        Me.VarCollector.Variables.Add(Me.ActPos)
        '
        'PulpFeedingOpen
        '
        Me.PulpFeedingOpen.BindControl = Me.BtnMPPulpFeedingOpen
        Me.PulpFeedingOpen.BindProperty = "Data"
        Me.PulpFeedingOpen.Data = Nothing
        Me.PulpFeedingOpen.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PulpFeedingOpen.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PulpFeedingOpen.VariableName = "MAIN.InMoldDrying.ProductForming.FeedingPulp.mxHMI_Open"
        '
        'PulpFeedingClose
        '
        Me.PulpFeedingClose.BindControl = Me.BtnMPPulpFeedingClose
        Me.PulpFeedingClose.BindProperty = "Data"
        Me.PulpFeedingClose.Data = Nothing
        Me.PulpFeedingClose.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PulpFeedingClose.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PulpFeedingClose.VariableName = "MAIN.InMoldDrying.ProductForming.FeedingPulp.mxHMI_Close"
        '
        'BtnMPPulpFeedingClose
        '
        Me.BtnMPPulpFeedingClose.Audit = Nothing
        Me.BtnMPPulpFeedingClose.AuditEnabled = False
        Me.BtnMPPulpFeedingClose.AuditMessage = "KremerPushButton pressed!"
        Me.BtnMPPulpFeedingClose.AuditSource = "KremerPushButton"
        Me.BtnMPPulpFeedingClose.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnMPPulpFeedingClose.BackGroundImageOn = Nothing
        Me.BtnMPPulpFeedingClose.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnMPPulpFeedingClose.Data = False
        Me.BtnMPPulpFeedingClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMPPulpFeedingClose.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnMPPulpFeedingClose.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnMPPulpFeedingClose.Location = New System.Drawing.Point(287, 50)
        Me.BtnMPPulpFeedingClose.Name = "BtnMPPulpFeedingClose"
        Me.BtnMPPulpFeedingClose.Size = New System.Drawing.Size(106, 36)
        Me.BtnMPPulpFeedingClose.State = False
        Me.BtnMPPulpFeedingClose.StateIsData = True
        Me.BtnMPPulpFeedingClose.StateText = New String() {Nothing, Nothing}
        Me.BtnMPPulpFeedingClose.TabIndex = 299
        Me.BtnMPPulpFeedingClose.Tag = "61"
        Me.BtnMPPulpFeedingClose.Text = "Close"
        Me.BtnMPPulpFeedingClose.UserInfo = Nothing
        Me.BtnMPPulpFeedingClose.UserLevel = 0
        Me.BtnMPPulpFeedingClose.UseStateText = False
        '
        'HydrUp
        '
        Me.HydrUp.BindControl = Me.BtnHydrUp
        Me.HydrUp.BindProperty = "Data"
        Me.HydrUp.Data = Nothing
        Me.HydrUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.HydrUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.HydrUp.VariableName = "MAIN.InMoldDrying.ProductForming.PondHydraulicCilinder.HydraulicIn.mxHMI_On"
        '
        'BtnHydrUp
        '
        Me.BtnHydrUp.Audit = Nothing
        Me.BtnHydrUp.AuditEnabled = False
        Me.BtnHydrUp.AuditMessage = "KremerPushButton pressed!"
        Me.BtnHydrUp.AuditSource = "KremerPushButton"
        Me.BtnHydrUp.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnHydrUp.BackGroundImageOn = Nothing
        Me.BtnHydrUp.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnHydrUp.Data = False
        Me.BtnHydrUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHydrUp.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnHydrUp.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnHydrUp.Location = New System.Drawing.Point(175, 220)
        Me.BtnHydrUp.Name = "BtnHydrUp"
        Me.BtnHydrUp.Size = New System.Drawing.Size(106, 36)
        Me.BtnHydrUp.State = False
        Me.BtnHydrUp.StateIsData = True
        Me.BtnHydrUp.StateText = New String() {Nothing, Nothing}
        Me.BtnHydrUp.TabIndex = 243
        Me.BtnHydrUp.Tag = "29"
        Me.BtnHydrUp.Text = "Up"
        Me.BtnHydrUp.UserInfo = Nothing
        Me.BtnHydrUp.UserLevel = 0
        Me.BtnHydrUp.UseStateText = False
        '
        'HydrDown
        '
        Me.HydrDown.BindControl = Me.BtnHydrDown
        Me.HydrDown.BindProperty = "Data"
        Me.HydrDown.Data = Nothing
        Me.HydrDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.HydrDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.HydrDown.VariableName = "MAIN.InMoldDrying.ProductForming.PondHydraulicCilinder.HydraulicOut.mxHMI_On"
        '
        'BtnHydrDown
        '
        Me.BtnHydrDown.Audit = Nothing
        Me.BtnHydrDown.AuditEnabled = False
        Me.BtnHydrDown.AuditMessage = "KremerPushButton pressed!"
        Me.BtnHydrDown.AuditSource = "KremerPushButton"
        Me.BtnHydrDown.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnHydrDown.BackGroundImageOn = Nothing
        Me.BtnHydrDown.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnHydrDown.Data = False
        Me.BtnHydrDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHydrDown.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnHydrDown.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnHydrDown.Location = New System.Drawing.Point(287, 220)
        Me.BtnHydrDown.Name = "BtnHydrDown"
        Me.BtnHydrDown.Size = New System.Drawing.Size(106, 36)
        Me.BtnHydrDown.State = False
        Me.BtnHydrDown.StateIsData = True
        Me.BtnHydrDown.StateText = New String() {Nothing, Nothing}
        Me.BtnHydrDown.TabIndex = 244
        Me.BtnHydrDown.Tag = "30"
        Me.BtnHydrDown.Text = "Down"
        Me.BtnHydrDown.UserInfo = Nothing
        Me.BtnHydrDown.UserLevel = 0
        Me.BtnHydrDown.UseStateText = False
        '
        'HydrSlow
        '
        Me.HydrSlow.BindControl = Me.BtnHydrSlow
        Me.HydrSlow.BindProperty = "Data"
        Me.HydrSlow.Data = Nothing
        Me.HydrSlow.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.HydrSlow.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.HydrSlow.VariableName = "MAIN.InMoldDrying.ProductForming.PondHydraulicCilinder.HydraulicSlow.mxHMI_On"
        '
        'BtnHydrSlow
        '
        Me.BtnHydrSlow.Audit = Nothing
        Me.BtnHydrSlow.AuditEnabled = False
        Me.BtnHydrSlow.AuditMessage = "KremerPushButton pressed!"
        Me.BtnHydrSlow.AuditSource = "KremerPushButton"
        Me.BtnHydrSlow.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnHydrSlow.BackGroundImageOn = Nothing
        Me.BtnHydrSlow.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.BtnHydrSlow.Data = False
        Me.BtnHydrSlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHydrSlow.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnHydrSlow.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnHydrSlow.Location = New System.Drawing.Point(175, 262)
        Me.BtnHydrSlow.Name = "BtnHydrSlow"
        Me.BtnHydrSlow.Size = New System.Drawing.Size(106, 36)
        Me.BtnHydrSlow.State = True
        Me.BtnHydrSlow.StateIsData = True
        Me.BtnHydrSlow.StateText = New String() {Nothing, Nothing}
        Me.BtnHydrSlow.TabIndex = 245
        Me.BtnHydrSlow.Tag = "292"
        Me.BtnHydrSlow.Text = "Slow"
        Me.BtnHydrSlow.UserInfo = Nothing
        Me.BtnHydrSlow.UserLevel = 0
        Me.BtnHydrSlow.UseStateText = False
        Me.BtnHydrSlow.UseVisualStyleBackColor = False
        '
        'HydrSlowState
        '
        Me.HydrSlowState.BindControl = Me.BtnHydrSlow
        Me.HydrSlowState.BindProperty = "State"
        Me.HydrSlowState.Data = Nothing
        Me.HydrSlowState.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.HydrSlowState.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.HydrSlowState.VariableName = "MAIN.InMoldDrying.ProductForming.PondHydraulicCilinder.HydraulicSlow.mxIsOn"
        '
        'VacuumOn
        '
        Me.VacuumOn.BindControl = Me.BtnFormingVacuumOn
        Me.VacuumOn.BindProperty = "Data"
        Me.VacuumOn.Data = Nothing
        Me.VacuumOn.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.VacuumOn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.VacuumOn.VariableName = "MAIN.InMoldDrying.ProductForming.MoldVacuum.mxHMI_On"
        '
        'BtnFormingVacuumOn
        '
        Me.BtnFormingVacuumOn.Audit = Nothing
        Me.BtnFormingVacuumOn.AuditEnabled = False
        Me.BtnFormingVacuumOn.AuditMessage = "KremerPushButton pressed!"
        Me.BtnFormingVacuumOn.AuditSource = "KremerPushButton"
        Me.BtnFormingVacuumOn.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnFormingVacuumOn.BackGroundImageOn = Nothing
        Me.BtnFormingVacuumOn.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.BtnFormingVacuumOn.Data = False
        Me.BtnFormingVacuumOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormingVacuumOn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnFormingVacuumOn.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnFormingVacuumOn.Location = New System.Drawing.Point(662, 50)
        Me.BtnFormingVacuumOn.Name = "BtnFormingVacuumOn"
        Me.BtnFormingVacuumOn.Size = New System.Drawing.Size(106, 36)
        Me.BtnFormingVacuumOn.State = False
        Me.BtnFormingVacuumOn.StateIsData = True
        Me.BtnFormingVacuumOn.StateText = New String() {Nothing, Nothing}
        Me.BtnFormingVacuumOn.TabIndex = 296
        Me.BtnFormingVacuumOn.Tag = "26"
        Me.BtnFormingVacuumOn.Text = "On"
        Me.BtnFormingVacuumOn.UserInfo = Nothing
        Me.BtnFormingVacuumOn.UserLevel = 0
        Me.BtnFormingVacuumOn.UseStateText = False
        '
        'BlowOffOn
        '
        Me.BlowOffOn.BindControl = Me.BtnFormingBlowOffOn
        Me.BlowOffOn.BindProperty = "Data"
        Me.BlowOffOn.Data = Nothing
        Me.BlowOffOn.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BlowOffOn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BlowOffOn.VariableName = "MAIN.InMoldDrying.ProductForming.MoldBlowOff.mxHMI_On"
        '
        'BtnFormingBlowOffOn
        '
        Me.BtnFormingBlowOffOn.Audit = Nothing
        Me.BtnFormingBlowOffOn.AuditEnabled = False
        Me.BtnFormingBlowOffOn.AuditMessage = "KremerPushButton pressed!"
        Me.BtnFormingBlowOffOn.AuditSource = "KremerPushButton"
        Me.BtnFormingBlowOffOn.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnFormingBlowOffOn.BackGroundImageOn = Nothing
        Me.BtnFormingBlowOffOn.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.BtnFormingBlowOffOn.Data = False
        Me.BtnFormingBlowOffOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormingBlowOffOn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnFormingBlowOffOn.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnFormingBlowOffOn.Location = New System.Drawing.Point(662, 90)
        Me.BtnFormingBlowOffOn.Name = "BtnFormingBlowOffOn"
        Me.BtnFormingBlowOffOn.Size = New System.Drawing.Size(106, 36)
        Me.BtnFormingBlowOffOn.State = False
        Me.BtnFormingBlowOffOn.StateIsData = True
        Me.BtnFormingBlowOffOn.StateText = New String() {Nothing, Nothing}
        Me.BtnFormingBlowOffOn.TabIndex = 298
        Me.BtnFormingBlowOffOn.Tag = "26"
        Me.BtnFormingBlowOffOn.Text = "On"
        Me.BtnFormingBlowOffOn.UserInfo = Nothing
        Me.BtnFormingBlowOffOn.UserLevel = 0
        Me.BtnFormingBlowOffOn.UseStateText = False
        '
        'ActPos
        '
        Me.ActPos.BindControl = Me.IO_ActPos
        Me.ActPos.BindProperty = "Data"
        Me.ActPos.Data = Nothing
        Me.ActPos.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.ActPos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ActPos.VariableName = "MAIN.InMoldDrying.ProductForming.PondHydraulicCilinder.ActPosition"
        '
        'IO_ActPos
        '
        Me.IO_ActPos.Audit = Nothing
        Me.IO_ActPos.AuditEnabled = False
        Me.IO_ActPos.AuditMessage = "KremerIoField changed:"
        Me.IO_ActPos.AuditSource = "KremerIoField"
        Me.IO_ActPos.Data = 0.0R
        Me.IO_ActPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_ActPos.InitialValue = True
        Me.IO_ActPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_ActPos.Location = New System.Drawing.Point(325, 185)
        Me.IO_ActPos.LowerBound = 0.0R
        Me.IO_ActPos.Name = "IO_ActPos"
        Me.IO_ActPos.OutputFormat = "0.0 mm"
        Me.IO_ActPos.Size = New System.Drawing.Size(71, 21)
        Me.IO_ActPos.TabIndex = 270
        Me.IO_ActPos.Text = "0,0 mm"
        Me.IO_ActPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IO_ActPos.UpperBound = 1000.0R
        Me.IO_ActPos.UserInfo = Nothing
        Me.IO_ActPos.UserLevel = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 23)
        Me.Label2.TabIndex = 234
        Me.Label2.Tag = "386"
        Me.Label2.Text = "Pulp feeding"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(21, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(291, 23)
        Me.Label3.TabIndex = 238
        Me.Label3.Tag = ""
        Me.Label3.Text = "Hydraulics"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 23)
        Me.Label4.TabIndex = 242
        Me.Label4.Tag = "289"
        Me.Label4.Text = "Hydraulic cylinder"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(416, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(240, 23)
        Me.Label6.TabIndex = 297
        Me.Label6.Tag = "287"
        Me.Label6.Text = "Blowoff valve"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(416, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(240, 23)
        Me.Label7.TabIndex = 295
        Me.Label7.Tag = "286"
        Me.Label7.Text = "Vacuum valve"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(416, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(291, 23)
        Me.Label8.TabIndex = 294
        Me.Label8.Tag = "389"
        Me.Label8.Text = "Forming valves"
        '
        'MachinePond_Manual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnMPPulpFeedingClose)
        Me.Controls.Add(Me.BtnFormingBlowOffOn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnFormingVacuumOn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.IO_ActPos)
        Me.Controls.Add(Me.BtnHydrSlow)
        Me.Controls.Add(Me.BtnHydrDown)
        Me.Controls.Add(Me.BtnHydrUp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnMPPulpFeedingOpen)
        Me.Controls.Add(Me.lbl_puh)
        Me.Controls.Add(Me.btn_Settings)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "MachinePond_Manual"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "86"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents btn_Settings As KremerControlsWin32.KremerButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lbl_puh As System.Windows.Forms.Label
    Friend WithEvents BtnMPPulpFeedingOpen As KremerControlsWin32.KremerButton
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnHydrDown As KremerControlsWin32.KremerButton
    Friend WithEvents BtnHydrUp As KremerControlsWin32.KremerButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnHydrSlow As KremerControlsWin32.KremerButton
    Friend WithEvents IO_ActPos As KremerControlsWin32.KremerIoField
    Friend WithEvents BtnFormingBlowOffOn As KremerControlsWin32.KremerButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnFormingVacuumOn As KremerControlsWin32.KremerButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents BtnMPPulpFeedingClose As KremerControlsWin32.KremerButton
    Friend WithEvents PulpFeedingOpen As KremerControlsWin32.KremerVariable
    Friend WithEvents PulpFeedingClose As KremerControlsWin32.KremerVariable
    Friend WithEvents HydrUp As KremerControlsWin32.KremerVariable
    Friend WithEvents HydrDown As KremerControlsWin32.KremerVariable
    Friend WithEvents HydrSlow As KremerControlsWin32.KremerVariable
    Friend WithEvents VacuumOn As KremerControlsWin32.KremerVariable
    Friend WithEvents BlowOffOn As KremerControlsWin32.KremerVariable
    Friend WithEvents ActPos As KremerControlsWin32.KremerVariable
    Friend WithEvents HydrSlowState As KremerControlsWin32.KremerVariable

End Class
