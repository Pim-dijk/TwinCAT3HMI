<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TakeOutUnit_Manual
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
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.On1 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnOn1 = New KremerControlsWin32.KremerButton()
        Me.On2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnOn2 = New KremerControlsWin32.KremerButton()
        Me.On3 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnOn3 = New KremerControlsWin32.KremerButton()
        Me.On4 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnOn4 = New KremerControlsWin32.KremerButton()
        Me.On5 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnOn5 = New KremerControlsWin32.KremerButton()
        Me.On6 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnOn6 = New KremerControlsWin32.KremerButton()
        Me.H_in = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_H_In = New KremerControlsWin32.KremerButton()
        Me.H_Out = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_H_Out = New KremerControlsWin32.KremerButton()
        Me.V_In = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_V_In = New KremerControlsWin32.KremerButton()
        Me.V_Out = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_V_Out = New KremerControlsWin32.KremerButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
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
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 435)
        Me.ShapeContainer1.TabIndex = 242
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 424
        Me.LineShape2.X2 = 774
        Me.LineShape2.Y1 = 38
        Me.LineShape2.Y2 = 38
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 25
        Me.LineShape1.X2 = 375
        Me.LineShape1.Y1 = 37
        Me.LineShape1.Y2 = 37
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Me.VarCollector
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.On1)
        Me.VarCollector.Variables.Add(Me.On2)
        Me.VarCollector.Variables.Add(Me.On3)
        Me.VarCollector.Variables.Add(Me.On4)
        Me.VarCollector.Variables.Add(Me.On5)
        Me.VarCollector.Variables.Add(Me.On6)
        Me.VarCollector.Variables.Add(Me.H_in)
        Me.VarCollector.Variables.Add(Me.H_Out)
        Me.VarCollector.Variables.Add(Me.V_In)
        Me.VarCollector.Variables.Add(Me.V_Out)
        '
        'On1
        '
        Me.On1.BindControl = Me.BtnOn1
        Me.On1.BindProperty = "Data"
        Me.On1.Data = Nothing
        Me.On1.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.On1.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.On1.VariableName = "MAIN.InMoldDrying.Bottom[Position1].VacuumTakeout[1].mxHMI_On"
        '
        'BtnOn1
        '
        Me.BtnOn1.Audit = Nothing
        Me.BtnOn1.AuditEnabled = False
        Me.BtnOn1.AuditMessage = "KremerPushButton pressed!"
        Me.BtnOn1.AuditSource = "KremerPushButton"
        Me.BtnOn1.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnOn1.BackGroundImageOn = Nothing
        Me.BtnOn1.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.BtnOn1.Data = False
        Me.BtnOn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOn1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnOn1.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnOn1.Location = New System.Drawing.Point(270, 43)
        Me.BtnOn1.Name = "BtnOn1"
        Me.BtnOn1.Size = New System.Drawing.Size(106, 36)
        Me.BtnOn1.State = False
        Me.BtnOn1.StateIsData = True
        Me.BtnOn1.StateText = New String() {Nothing, Nothing}
        Me.BtnOn1.TabIndex = 353
        Me.BtnOn1.Tag = "293"
        Me.BtnOn1.Text = "On"
        Me.BtnOn1.UserInfo = Nothing
        Me.BtnOn1.UserLevel = 0
        Me.BtnOn1.UseStateText = False
        '
        'On2
        '
        Me.On2.BindControl = Me.BtnOn2
        Me.On2.BindProperty = "Data"
        Me.On2.Data = Nothing
        Me.On2.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.On2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.On2.VariableName = "MAIN.InMoldDrying.Bottom[Position1].VacuumTakeout[2].mxHMI_On"
        '
        'BtnOn2
        '
        Me.BtnOn2.Audit = Nothing
        Me.BtnOn2.AuditEnabled = False
        Me.BtnOn2.AuditMessage = "KremerPushButton pressed!"
        Me.BtnOn2.AuditSource = "KremerPushButton"
        Me.BtnOn2.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnOn2.BackGroundImageOn = Nothing
        Me.BtnOn2.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.BtnOn2.Data = False
        Me.BtnOn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOn2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnOn2.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnOn2.Location = New System.Drawing.Point(270, 85)
        Me.BtnOn2.Name = "BtnOn2"
        Me.BtnOn2.Size = New System.Drawing.Size(106, 36)
        Me.BtnOn2.State = False
        Me.BtnOn2.StateIsData = True
        Me.BtnOn2.StateText = New String() {Nothing, Nothing}
        Me.BtnOn2.TabIndex = 361
        Me.BtnOn2.Tag = "293"
        Me.BtnOn2.Text = "On"
        Me.BtnOn2.UserInfo = Nothing
        Me.BtnOn2.UserLevel = 0
        Me.BtnOn2.UseStateText = False
        '
        'On3
        '
        Me.On3.BindControl = Me.BtnOn3
        Me.On3.BindProperty = "Data"
        Me.On3.Data = Nothing
        Me.On3.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.On3.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.On3.VariableName = "MAIN.InMoldDrying.Bottom[Position1].VacuumTakeout[3].mxHMI_On"
        '
        'BtnOn3
        '
        Me.BtnOn3.Audit = Nothing
        Me.BtnOn3.AuditEnabled = False
        Me.BtnOn3.AuditMessage = "KremerPushButton pressed!"
        Me.BtnOn3.AuditSource = "KremerPushButton"
        Me.BtnOn3.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnOn3.BackGroundImageOn = Nothing
        Me.BtnOn3.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.BtnOn3.Data = False
        Me.BtnOn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOn3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnOn3.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnOn3.Location = New System.Drawing.Point(270, 127)
        Me.BtnOn3.Name = "BtnOn3"
        Me.BtnOn3.Size = New System.Drawing.Size(106, 36)
        Me.BtnOn3.State = False
        Me.BtnOn3.StateIsData = True
        Me.BtnOn3.StateText = New String() {Nothing, Nothing}
        Me.BtnOn3.TabIndex = 355
        Me.BtnOn3.Tag = "293"
        Me.BtnOn3.Text = "On"
        Me.BtnOn3.UserInfo = Nothing
        Me.BtnOn3.UserLevel = 0
        Me.BtnOn3.UseStateText = False
        '
        'On4
        '
        Me.On4.BindControl = Me.BtnOn4
        Me.On4.BindProperty = "Data"
        Me.On4.Data = Nothing
        Me.On4.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.On4.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.On4.VariableName = "MAIN.InMoldDrying.Bottom[Position1].VacuumTakeout[4].mxHMI_On"
        '
        'BtnOn4
        '
        Me.BtnOn4.Audit = Nothing
        Me.BtnOn4.AuditEnabled = False
        Me.BtnOn4.AuditMessage = "KremerPushButton pressed!"
        Me.BtnOn4.AuditSource = "KremerPushButton"
        Me.BtnOn4.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnOn4.BackGroundImageOn = Nothing
        Me.BtnOn4.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.BtnOn4.Data = False
        Me.BtnOn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOn4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnOn4.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnOn4.Location = New System.Drawing.Point(270, 167)
        Me.BtnOn4.Name = "BtnOn4"
        Me.BtnOn4.Size = New System.Drawing.Size(106, 36)
        Me.BtnOn4.State = False
        Me.BtnOn4.StateIsData = True
        Me.BtnOn4.StateText = New String() {Nothing, Nothing}
        Me.BtnOn4.TabIndex = 357
        Me.BtnOn4.Tag = "293"
        Me.BtnOn4.Text = "On"
        Me.BtnOn4.UserInfo = Nothing
        Me.BtnOn4.UserLevel = 0
        Me.BtnOn4.UseStateText = False
        '
        'On5
        '
        Me.On5.BindControl = Me.BtnOn5
        Me.On5.BindProperty = "Data"
        Me.On5.Data = Nothing
        Me.On5.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.On5.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.On5.VariableName = "MAIN.InMoldDrying.Bottom[Position1].VacuumTakeout[5].mxHMI_On"
        '
        'BtnOn5
        '
        Me.BtnOn5.Audit = Nothing
        Me.BtnOn5.AuditEnabled = False
        Me.BtnOn5.AuditMessage = "KremerPushButton pressed!"
        Me.BtnOn5.AuditSource = "KremerPushButton"
        Me.BtnOn5.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnOn5.BackGroundImageOn = Nothing
        Me.BtnOn5.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.BtnOn5.Data = False
        Me.BtnOn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOn5.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnOn5.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnOn5.Location = New System.Drawing.Point(270, 208)
        Me.BtnOn5.Name = "BtnOn5"
        Me.BtnOn5.Size = New System.Drawing.Size(106, 36)
        Me.BtnOn5.State = False
        Me.BtnOn5.StateIsData = True
        Me.BtnOn5.StateText = New String() {Nothing, Nothing}
        Me.BtnOn5.TabIndex = 359
        Me.BtnOn5.Tag = "293"
        Me.BtnOn5.Text = "On"
        Me.BtnOn5.UserInfo = Nothing
        Me.BtnOn5.UserLevel = 0
        Me.BtnOn5.UseStateText = False
        '
        'On6
        '
        Me.On6.BindControl = Me.BtnOn6
        Me.On6.BindProperty = "Data"
        Me.On6.Data = Nothing
        Me.On6.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.On6.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.On6.VariableName = "MAIN.InMoldDrying.Bottom[Position1].VacuumTakeout[6].mxHMI_On"
        '
        'BtnOn6
        '
        Me.BtnOn6.Audit = Nothing
        Me.BtnOn6.AuditEnabled = False
        Me.BtnOn6.AuditMessage = "KremerPushButton pressed!"
        Me.BtnOn6.AuditSource = "KremerPushButton"
        Me.BtnOn6.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnOn6.BackGroundImageOn = Nothing
        Me.BtnOn6.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.BtnOn6.Data = False
        Me.BtnOn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOn6.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnOn6.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnOn6.Location = New System.Drawing.Point(270, 250)
        Me.BtnOn6.Name = "BtnOn6"
        Me.BtnOn6.Size = New System.Drawing.Size(106, 36)
        Me.BtnOn6.State = False
        Me.BtnOn6.StateIsData = True
        Me.BtnOn6.StateText = New String() {Nothing, Nothing}
        Me.BtnOn6.TabIndex = 363
        Me.BtnOn6.Tag = "293"
        Me.BtnOn6.Text = "On"
        Me.BtnOn6.UserInfo = Nothing
        Me.BtnOn6.UserLevel = 0
        Me.BtnOn6.UseStateText = False
        '
        'H_in
        '
        Me.H_in.BindControl = Me.Btn_H_In
        Me.H_in.BindProperty = "Data"
        Me.H_in.Data = Nothing
        Me.H_in.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.H_in.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.H_in.VariableName = "MAIN.InMoldDrying.Bottom[Position1].HorizontalCilinder.mxHMI_In"
        '
        'Btn_H_In
        '
        Me.Btn_H_In.Audit = Nothing
        Me.Btn_H_In.AuditEnabled = False
        Me.Btn_H_In.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_H_In.AuditSource = "KremerPushButton"
        Me.Btn_H_In.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_H_In.BackGroundImageOn = Nothing
        Me.Btn_H_In.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_H_In.Data = False
        Me.Btn_H_In.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_H_In.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_H_In.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_H_In.Location = New System.Drawing.Point(578, 43)
        Me.Btn_H_In.Name = "Btn_H_In"
        Me.Btn_H_In.Size = New System.Drawing.Size(106, 36)
        Me.Btn_H_In.State = False
        Me.Btn_H_In.StateIsData = True
        Me.Btn_H_In.StateText = New String() {Nothing, Nothing}
        Me.Btn_H_In.TabIndex = 345
        Me.Btn_H_In.Tag = ""
        Me.Btn_H_In.Text = "In"
        Me.Btn_H_In.UserInfo = Nothing
        Me.Btn_H_In.UserLevel = 0
        Me.Btn_H_In.UseStateText = False
        '
        'H_Out
        '
        Me.H_Out.BindControl = Me.Btn_H_Out
        Me.H_Out.BindProperty = "Data"
        Me.H_Out.Data = Nothing
        Me.H_Out.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.H_Out.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.H_Out.VariableName = "MAIN.InMoldDrying.Bottom[Position1].HorizontalCilinder.mxHMI_Out"
        '
        'Btn_H_Out
        '
        Me.Btn_H_Out.Audit = Nothing
        Me.Btn_H_Out.AuditEnabled = False
        Me.Btn_H_Out.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_H_Out.AuditSource = "KremerPushButton"
        Me.Btn_H_Out.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_H_Out.BackGroundImageOn = Nothing
        Me.Btn_H_Out.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_H_Out.Data = False
        Me.Btn_H_Out.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_H_Out.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_H_Out.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_H_Out.Location = New System.Drawing.Point(687, 43)
        Me.Btn_H_Out.Name = "Btn_H_Out"
        Me.Btn_H_Out.Size = New System.Drawing.Size(106, 36)
        Me.Btn_H_Out.State = False
        Me.Btn_H_Out.StateIsData = True
        Me.Btn_H_Out.StateText = New String() {Nothing, Nothing}
        Me.Btn_H_Out.TabIndex = 341
        Me.Btn_H_Out.Tag = ""
        Me.Btn_H_Out.Text = "Out"
        Me.Btn_H_Out.UserInfo = Nothing
        Me.Btn_H_Out.UserLevel = 0
        Me.Btn_H_Out.UseStateText = False
        '
        'V_In
        '
        Me.V_In.BindControl = Me.Btn_V_In
        Me.V_In.BindProperty = "Data"
        Me.V_In.Data = Nothing
        Me.V_In.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.V_In.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.V_In.VariableName = "MAIN.InMoldDrying.Bottom[Position1].VerticalCilinder.mxHMI_In"
        '
        'Btn_V_In
        '
        Me.Btn_V_In.Audit = Nothing
        Me.Btn_V_In.AuditEnabled = False
        Me.Btn_V_In.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_V_In.AuditSource = "KremerPushButton"
        Me.Btn_V_In.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_V_In.BackGroundImageOn = Nothing
        Me.Btn_V_In.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_V_In.Data = False
        Me.Btn_V_In.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_V_In.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_V_In.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_V_In.Location = New System.Drawing.Point(578, 85)
        Me.Btn_V_In.Name = "Btn_V_In"
        Me.Btn_V_In.Size = New System.Drawing.Size(106, 36)
        Me.Btn_V_In.State = False
        Me.Btn_V_In.StateIsData = True
        Me.Btn_V_In.StateText = New String() {Nothing, Nothing}
        Me.Btn_V_In.TabIndex = 346
        Me.Btn_V_In.Tag = "290"
        Me.Btn_V_In.Text = "Up"
        Me.Btn_V_In.UserInfo = Nothing
        Me.Btn_V_In.UserLevel = 0
        Me.Btn_V_In.UseStateText = False
        '
        'V_Out
        '
        Me.V_Out.BindControl = Me.Btn_V_Out
        Me.V_Out.BindProperty = "Data"
        Me.V_Out.Data = Nothing
        Me.V_Out.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.V_Out.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.V_Out.VariableName = "MAIN.InMoldDrying.Bottom[Position1].VerticalCilinder.mxHMI_Out"
        '
        'Btn_V_Out
        '
        Me.Btn_V_Out.Audit = Nothing
        Me.Btn_V_Out.AuditEnabled = False
        Me.Btn_V_Out.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_V_Out.AuditSource = "KremerPushButton"
        Me.Btn_V_Out.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_V_Out.BackGroundImageOn = Nothing
        Me.Btn_V_Out.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_V_Out.Data = False
        Me.Btn_V_Out.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_V_Out.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_V_Out.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_V_Out.Location = New System.Drawing.Point(687, 85)
        Me.Btn_V_Out.Name = "Btn_V_Out"
        Me.Btn_V_Out.Size = New System.Drawing.Size(106, 36)
        Me.Btn_V_Out.State = False
        Me.Btn_V_Out.StateIsData = True
        Me.Btn_V_Out.StateText = New String() {Nothing, Nothing}
        Me.Btn_V_Out.TabIndex = 344
        Me.Btn_V_Out.Tag = "291"
        Me.Btn_V_Out.Text = "Down"
        Me.Btn_V_Out.UserInfo = Nothing
        Me.Btn_V_Out.UserLevel = 0
        Me.Btn_V_Out.UseStateText = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(421, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(291, 23)
        Me.Label10.TabIndex = 280
        Me.Label10.Tag = "294"
        Me.Label10.Text = "Air cylinder"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(420, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 23)
        Me.Label7.TabIndex = 343
        Me.Label7.Tag = "191"
        Me.Label7.Text = "Vertical cylinder"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(420, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 23)
        Me.Label8.TabIndex = 342
        Me.Label8.Tag = "190"
        Me.Label8.Text = "Horizontal cylinder"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(21, 262)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(164, 23)
        Me.Label16.TabIndex = 362
        Me.Label16.Tag = "189"
        Me.Label16.Text = "Vacuum take out 6"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(21, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(243, 23)
        Me.Label15.TabIndex = 360
        Me.Label15.Tag = "185"
        Me.Label15.Text = "Vacuum take out 2"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(21, 220)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(164, 23)
        Me.Label14.TabIndex = 358
        Me.Label14.Tag = "188"
        Me.Label14.Text = "Vacuum take out 5"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(21, 179)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(164, 23)
        Me.Label13.TabIndex = 356
        Me.Label13.Tag = "187"
        Me.Label13.Text = "Vacuum take out 4"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 135)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(164, 23)
        Me.Label12.TabIndex = 354
        Me.Label12.Tag = "186"
        Me.Label12.Text = "Vacuum take out 3"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 23)
        Me.Label5.TabIndex = 352
        Me.Label5.Tag = "184"
        Me.Label5.Text = "Vacuum take out 1"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(21, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(329, 23)
        Me.Label9.TabIndex = 351
        Me.Label9.Tag = "183"
        Me.Label9.Text = "Take out unit vacuum sections"
        '
        'TakeOutUnit_Manual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnOn6)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.BtnOn2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.BtnOn5)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.BtnOn4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BtnOn3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.BtnOn1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Btn_V_In)
        Me.Controls.Add(Me.Btn_H_In)
        Me.Controls.Add(Me.Btn_V_Out)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Btn_H_Out)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Btn_Settings)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "TakeOutUnit_Manual"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "102"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Settings As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Btn_V_In As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_H_In As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_V_Out As KremerControlsWin32.KremerButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Btn_H_Out As KremerControlsWin32.KremerButton
    Friend WithEvents BtnOn6 As KremerControlsWin32.KremerButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents BtnOn2 As KremerControlsWin32.KremerButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents BtnOn5 As KremerControlsWin32.KremerButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents BtnOn4 As KremerControlsWin32.KremerButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BtnOn3 As KremerControlsWin32.KremerButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BtnOn1 As KremerControlsWin32.KremerButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents On1 As KremerControlsWin32.KremerVariable
    Friend WithEvents On2 As KremerControlsWin32.KremerVariable
    Friend WithEvents On3 As KremerControlsWin32.KremerVariable
    Friend WithEvents On4 As KremerControlsWin32.KremerVariable
    Friend WithEvents On5 As KremerControlsWin32.KremerVariable
    Friend WithEvents On6 As KremerControlsWin32.KremerVariable
    Friend WithEvents H_in As KremerControlsWin32.KremerVariable
    Friend WithEvents H_Out As KremerControlsWin32.KremerVariable
    Friend WithEvents V_In As KremerControlsWin32.KremerVariable
    Friend WithEvents V_Out As KremerControlsWin32.KremerVariable

End Class
