<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TakeOutUnit_Settings
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
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape10 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.mxAutoMode = New KremerControlsWin32.KremerVariable(Me.components)
        Me.En1 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.btn_Enable1 = New KremerControlsWin32.KremerButton()
        Me.En2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.btn_Enable2 = New KremerControlsWin32.KremerButton()
        Me.En3 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.btn_Enable3 = New KremerControlsWin32.KremerButton()
        Me.En4 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.btn_Enable4 = New KremerControlsWin32.KremerButton()
        Me.En5 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.btn_Enable5 = New KremerControlsWin32.KremerButton()
        Me.En6 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.btn_Enable6 = New KremerControlsWin32.KremerButton()
        Me.HOR_GT_Error = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_GT_Error = New KremerControlsWin32.KremerIoField(Me.components)
        Me.HOR_GT_WarningIn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_GT_WarningIn = New KremerControlsWin32.KremerIoField(Me.components)
        Me.HOR_GT_WarningOut = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_GT_WarningOut = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_puh = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.IO_BotVertCilUpdelay = New KremerControlsWin32.KremerIoField(Me.components)
        Me.VertUpDelay = New KremerControlsWin32.KremerVariable(Me.components)
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
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape10, Me.LineShape9})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 435)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 268
        Me.LineShape3.X2 = 268
        Me.LineShape3.Y1 = 218
        Me.LineShape3.Y2 = 357
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 23
        Me.LineShape2.X2 = 373
        Me.LineShape2.Y1 = 218
        Me.LineShape2.Y2 = 218
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
        Me.LineShape9.Y2 = 160
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.mxAutoMode)
        Me.VarCollector.Variables.Add(Me.En1)
        Me.VarCollector.Variables.Add(Me.En2)
        Me.VarCollector.Variables.Add(Me.En3)
        Me.VarCollector.Variables.Add(Me.En4)
        Me.VarCollector.Variables.Add(Me.En5)
        Me.VarCollector.Variables.Add(Me.En6)
        Me.VarCollector.Variables.Add(Me.HOR_GT_Error)
        Me.VarCollector.Variables.Add(Me.HOR_GT_WarningIn)
        Me.VarCollector.Variables.Add(Me.HOR_GT_WarningOut)
        Me.VarCollector.Variables.Add(Me.VertUpDelay)
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
        'En1
        '
        Me.En1.BindControl = Me.btn_Enable1
        Me.En1.BindProperty = "Data"
        Me.En1.Data = Nothing
        Me.En1.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.En1.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.En1.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].EnableVacuumSection[1]"
        '
        'btn_Enable1
        '
        Me.btn_Enable1.Audit = Nothing
        Me.btn_Enable1.AuditEnabled = False
        Me.btn_Enable1.AuditMessage = "KremerPushButton pressed!"
        Me.btn_Enable1.AuditSource = "KremerPushButton"
        Me.btn_Enable1.BackColorOn = System.Drawing.Color.Blue
        Me.btn_Enable1.BackGroundImageOn = Nothing
        Me.btn_Enable1.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.btn_Enable1.Data = False
        Me.btn_Enable1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Enable1.ForeColorOn = System.Drawing.Color.Yellow
        Me.btn_Enable1.Location = New System.Drawing.Point(271, 222)
        Me.btn_Enable1.Name = "btn_Enable1"
        Me.btn_Enable1.Size = New System.Drawing.Size(100, 23)
        Me.btn_Enable1.State = False
        Me.btn_Enable1.StateIsData = True
        Me.btn_Enable1.StateText = New String() {Nothing, Nothing}
        Me.btn_Enable1.TabIndex = 397
        Me.btn_Enable1.Tag = "64"
        Me.btn_Enable1.Text = "Enable"
        Me.btn_Enable1.UserInfo = Nothing
        Me.btn_Enable1.UserLevel = 0
        Me.btn_Enable1.UseStateText = False
        Me.btn_Enable1.UseVisualStyleBackColor = True
        '
        'En2
        '
        Me.En2.BindControl = Me.btn_Enable2
        Me.En2.BindProperty = "Data"
        Me.En2.Data = Nothing
        Me.En2.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.En2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.En2.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].EnableVacuumSection[2]"
        '
        'btn_Enable2
        '
        Me.btn_Enable2.Audit = Nothing
        Me.btn_Enable2.AuditEnabled = False
        Me.btn_Enable2.AuditMessage = "KremerPushButton pressed!"
        Me.btn_Enable2.AuditSource = "KremerPushButton"
        Me.btn_Enable2.BackColorOn = System.Drawing.Color.Blue
        Me.btn_Enable2.BackGroundImageOn = Nothing
        Me.btn_Enable2.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.btn_Enable2.Data = False
        Me.btn_Enable2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Enable2.ForeColorOn = System.Drawing.Color.Yellow
        Me.btn_Enable2.Location = New System.Drawing.Point(271, 245)
        Me.btn_Enable2.Name = "btn_Enable2"
        Me.btn_Enable2.Size = New System.Drawing.Size(100, 23)
        Me.btn_Enable2.State = False
        Me.btn_Enable2.StateIsData = True
        Me.btn_Enable2.StateText = New String() {Nothing, Nothing}
        Me.btn_Enable2.TabIndex = 398
        Me.btn_Enable2.Tag = "64"
        Me.btn_Enable2.Text = "Enable"
        Me.btn_Enable2.UserInfo = Nothing
        Me.btn_Enable2.UserLevel = 0
        Me.btn_Enable2.UseStateText = False
        Me.btn_Enable2.UseVisualStyleBackColor = True
        '
        'En3
        '
        Me.En3.BindControl = Me.btn_Enable3
        Me.En3.BindProperty = "Data"
        Me.En3.Data = Nothing
        Me.En3.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.En3.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.En3.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].EnableVacuumSection[3]"
        '
        'btn_Enable3
        '
        Me.btn_Enable3.Audit = Nothing
        Me.btn_Enable3.AuditEnabled = False
        Me.btn_Enable3.AuditMessage = "KremerPushButton pressed!"
        Me.btn_Enable3.AuditSource = "KremerPushButton"
        Me.btn_Enable3.BackColorOn = System.Drawing.Color.Blue
        Me.btn_Enable3.BackGroundImageOn = Nothing
        Me.btn_Enable3.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.btn_Enable3.Data = False
        Me.btn_Enable3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Enable3.ForeColorOn = System.Drawing.Color.Yellow
        Me.btn_Enable3.Location = New System.Drawing.Point(271, 268)
        Me.btn_Enable3.Name = "btn_Enable3"
        Me.btn_Enable3.Size = New System.Drawing.Size(100, 23)
        Me.btn_Enable3.State = False
        Me.btn_Enable3.StateIsData = True
        Me.btn_Enable3.StateText = New String() {Nothing, Nothing}
        Me.btn_Enable3.TabIndex = 399
        Me.btn_Enable3.Tag = "64"
        Me.btn_Enable3.Text = "Enable"
        Me.btn_Enable3.UserInfo = Nothing
        Me.btn_Enable3.UserLevel = 0
        Me.btn_Enable3.UseStateText = False
        Me.btn_Enable3.UseVisualStyleBackColor = True
        '
        'En4
        '
        Me.En4.BindControl = Me.btn_Enable4
        Me.En4.BindProperty = "Data"
        Me.En4.Data = Nothing
        Me.En4.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.En4.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.En4.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].EnableVacuumSection[4]"
        '
        'btn_Enable4
        '
        Me.btn_Enable4.Audit = Nothing
        Me.btn_Enable4.AuditEnabled = False
        Me.btn_Enable4.AuditMessage = "KremerPushButton pressed!"
        Me.btn_Enable4.AuditSource = "KremerPushButton"
        Me.btn_Enable4.BackColorOn = System.Drawing.Color.Blue
        Me.btn_Enable4.BackGroundImageOn = Nothing
        Me.btn_Enable4.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.btn_Enable4.Data = False
        Me.btn_Enable4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Enable4.ForeColorOn = System.Drawing.Color.Yellow
        Me.btn_Enable4.Location = New System.Drawing.Point(271, 291)
        Me.btn_Enable4.Name = "btn_Enable4"
        Me.btn_Enable4.Size = New System.Drawing.Size(100, 23)
        Me.btn_Enable4.State = False
        Me.btn_Enable4.StateIsData = True
        Me.btn_Enable4.StateText = New String() {Nothing, Nothing}
        Me.btn_Enable4.TabIndex = 400
        Me.btn_Enable4.Tag = "64"
        Me.btn_Enable4.Text = "Enable"
        Me.btn_Enable4.UserInfo = Nothing
        Me.btn_Enable4.UserLevel = 0
        Me.btn_Enable4.UseStateText = False
        Me.btn_Enable4.UseVisualStyleBackColor = True
        '
        'En5
        '
        Me.En5.BindControl = Me.btn_Enable5
        Me.En5.BindProperty = "Data"
        Me.En5.Data = Nothing
        Me.En5.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.En5.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.En5.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].EnableVacuumSection[5]"
        '
        'btn_Enable5
        '
        Me.btn_Enable5.Audit = Nothing
        Me.btn_Enable5.AuditEnabled = False
        Me.btn_Enable5.AuditMessage = "KremerPushButton pressed!"
        Me.btn_Enable5.AuditSource = "KremerPushButton"
        Me.btn_Enable5.BackColorOn = System.Drawing.Color.Blue
        Me.btn_Enable5.BackGroundImageOn = Nothing
        Me.btn_Enable5.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.btn_Enable5.Data = False
        Me.btn_Enable5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Enable5.ForeColorOn = System.Drawing.Color.Yellow
        Me.btn_Enable5.Location = New System.Drawing.Point(271, 314)
        Me.btn_Enable5.Name = "btn_Enable5"
        Me.btn_Enable5.Size = New System.Drawing.Size(100, 23)
        Me.btn_Enable5.State = False
        Me.btn_Enable5.StateIsData = True
        Me.btn_Enable5.StateText = New String() {Nothing, Nothing}
        Me.btn_Enable5.TabIndex = 401
        Me.btn_Enable5.Tag = "64"
        Me.btn_Enable5.Text = "Enable"
        Me.btn_Enable5.UserInfo = Nothing
        Me.btn_Enable5.UserLevel = 0
        Me.btn_Enable5.UseStateText = False
        Me.btn_Enable5.UseVisualStyleBackColor = True
        '
        'En6
        '
        Me.En6.BindControl = Me.btn_Enable6
        Me.En6.BindProperty = "Data"
        Me.En6.Data = Nothing
        Me.En6.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.En6.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.En6.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].EnableVacuumSection[6]"
        '
        'btn_Enable6
        '
        Me.btn_Enable6.Audit = Nothing
        Me.btn_Enable6.AuditEnabled = False
        Me.btn_Enable6.AuditMessage = "KremerPushButton pressed!"
        Me.btn_Enable6.AuditSource = "KremerPushButton"
        Me.btn_Enable6.BackColorOn = System.Drawing.Color.Blue
        Me.btn_Enable6.BackGroundImageOn = Nothing
        Me.btn_Enable6.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.btn_Enable6.Data = False
        Me.btn_Enable6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Enable6.ForeColorOn = System.Drawing.Color.Yellow
        Me.btn_Enable6.Location = New System.Drawing.Point(271, 337)
        Me.btn_Enable6.Name = "btn_Enable6"
        Me.btn_Enable6.Size = New System.Drawing.Size(100, 23)
        Me.btn_Enable6.State = False
        Me.btn_Enable6.StateIsData = True
        Me.btn_Enable6.StateText = New String() {Nothing, Nothing}
        Me.btn_Enable6.TabIndex = 402
        Me.btn_Enable6.Tag = "64"
        Me.btn_Enable6.Text = "Enable"
        Me.btn_Enable6.UserInfo = Nothing
        Me.btn_Enable6.UserLevel = 0
        Me.btn_Enable6.UseStateText = False
        Me.btn_Enable6.UseVisualStyleBackColor = True
        '
        'HOR_GT_Error
        '
        Me.HOR_GT_Error.BindControl = Me.IO_GT_Error
        Me.HOR_GT_Error.BindProperty = "Data"
        Me.HOR_GT_Error.Data = Nothing
        Me.HOR_GT_Error.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.HOR_GT_Error.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.HOR_GT_Error.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].HorizontalCilinder.T_GuardTime" & _
    "Error"
        '
        'IO_GT_Error
        '
        Me.IO_GT_Error.Audit = Nothing
        Me.IO_GT_Error.AuditEnabled = False
        Me.IO_GT_Error.AuditMessage = "KremerIoField changed:"
        Me.IO_GT_Error.AuditSource = "KremerIoField"
        Me.IO_GT_Error.BackColor = System.Drawing.Color.White
        Me.IO_GT_Error.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_GT_Error.Data = 0.0R
        Me.IO_GT_Error.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_GT_Error.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_GT_Error.InitialValue = True
        Me.IO_GT_Error.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_GT_Error.Location = New System.Drawing.Point(271, 39)
        Me.IO_GT_Error.LowerBound = -5000.0R
        Me.IO_GT_Error.Name = "IO_GT_Error"
        Me.IO_GT_Error.OutputFormat = "0.0 ms"
        Me.IO_GT_Error.Size = New System.Drawing.Size(100, 22)
        Me.IO_GT_Error.TabIndex = 373
        Me.IO_GT_Error.Text = "0.0 ms"
        Me.IO_GT_Error.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_GT_Error.UpperBound = 5000.0R
        Me.IO_GT_Error.UserInfo = Nothing
        Me.IO_GT_Error.UserLevel = 0
        '
        'HOR_GT_WarningIn
        '
        Me.HOR_GT_WarningIn.BindControl = Me.IO_GT_WarningIn
        Me.HOR_GT_WarningIn.BindProperty = "Data"
        Me.HOR_GT_WarningIn.Data = Nothing
        Me.HOR_GT_WarningIn.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.HOR_GT_WarningIn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.HOR_GT_WarningIn.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].HorizontalCilinder.T_GuardTime" & _
    "Warning_IN"
        '
        'IO_GT_WarningIn
        '
        Me.IO_GT_WarningIn.Audit = Nothing
        Me.IO_GT_WarningIn.AuditEnabled = False
        Me.IO_GT_WarningIn.AuditMessage = "KremerIoField changed:"
        Me.IO_GT_WarningIn.AuditSource = "KremerIoField"
        Me.IO_GT_WarningIn.BackColor = System.Drawing.Color.White
        Me.IO_GT_WarningIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_GT_WarningIn.Data = 0.0R
        Me.IO_GT_WarningIn.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_GT_WarningIn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_GT_WarningIn.InitialValue = True
        Me.IO_GT_WarningIn.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_GT_WarningIn.Location = New System.Drawing.Point(271, 63)
        Me.IO_GT_WarningIn.LowerBound = -5000.0R
        Me.IO_GT_WarningIn.Name = "IO_GT_WarningIn"
        Me.IO_GT_WarningIn.OutputFormat = "0.0 ms"
        Me.IO_GT_WarningIn.Size = New System.Drawing.Size(100, 22)
        Me.IO_GT_WarningIn.TabIndex = 374
        Me.IO_GT_WarningIn.Text = "0.0 ms"
        Me.IO_GT_WarningIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_GT_WarningIn.UpperBound = 5000.0R
        Me.IO_GT_WarningIn.UserInfo = Nothing
        Me.IO_GT_WarningIn.UserLevel = 0
        '
        'HOR_GT_WarningOut
        '
        Me.HOR_GT_WarningOut.BindControl = Me.IO_GT_WarningOut
        Me.HOR_GT_WarningOut.BindProperty = "Data"
        Me.HOR_GT_WarningOut.Data = Nothing
        Me.HOR_GT_WarningOut.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.HOR_GT_WarningOut.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.HOR_GT_WarningOut.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].HorizontalCilinder.T_GuardTime" & _
    "Warning_OUT"
        '
        'IO_GT_WarningOut
        '
        Me.IO_GT_WarningOut.Audit = Nothing
        Me.IO_GT_WarningOut.AuditEnabled = False
        Me.IO_GT_WarningOut.AuditMessage = "KremerIoField changed:"
        Me.IO_GT_WarningOut.AuditSource = "KremerIoField"
        Me.IO_GT_WarningOut.BackColor = System.Drawing.Color.White
        Me.IO_GT_WarningOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_GT_WarningOut.Data = 0.0R
        Me.IO_GT_WarningOut.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_GT_WarningOut.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_GT_WarningOut.InitialValue = True
        Me.IO_GT_WarningOut.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_GT_WarningOut.Location = New System.Drawing.Point(271, 86)
        Me.IO_GT_WarningOut.LowerBound = -5000.0R
        Me.IO_GT_WarningOut.Name = "IO_GT_WarningOut"
        Me.IO_GT_WarningOut.OutputFormat = "0.0 ms"
        Me.IO_GT_WarningOut.Size = New System.Drawing.Size(100, 22)
        Me.IO_GT_WarningOut.TabIndex = 375
        Me.IO_GT_WarningOut.Text = "0.0 ms"
        Me.IO_GT_WarningOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_GT_WarningOut.UpperBound = 5000.0R
        Me.IO_GT_WarningOut.UserInfo = Nothing
        Me.IO_GT_WarningOut.UserLevel = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(19, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 23)
        Me.Label2.TabIndex = 372
        Me.Label2.Tag = "170"
        Me.Label2.Text = "Timing horizontal cylinder"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 23)
        Me.Label3.TabIndex = 378
        Me.Label3.Tag = "173"
        Me.Label3.Text = "Guard time warning out"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 23)
        Me.Label4.TabIndex = 377
        Me.Label4.Tag = "172"
        Me.Label4.Text = "Guard time warning in"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 23)
        Me.Label5.TabIndex = 376
        Me.Label5.Tag = "171"
        Me.Label5.Text = "Guard time error"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(18, 337)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(247, 23)
        Me.Label16.TabIndex = 396
        Me.Label16.Tag = "181"
        Me.Label16.Text = "Vacuum section 6"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(18, 314)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(247, 23)
        Me.Label19.TabIndex = 395
        Me.Label19.Tag = "180"
        Me.Label19.Text = "Vacuum section 5"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(18, 291)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(247, 23)
        Me.Label23.TabIndex = 394
        Me.Label23.Tag = "179"
        Me.Label23.Text = "Vacuum section 4"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(18, 268)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(247, 23)
        Me.Label15.TabIndex = 393
        Me.Label15.Tag = "178"
        Me.Label15.Text = "Vacuum section 3"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(247, 23)
        Me.Label8.TabIndex = 392
        Me.Label8.Tag = "177"
        Me.Label8.Text = "Vacuum section 2"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(247, 23)
        Me.Label6.TabIndex = 391
        Me.Label6.Tag = "176"
        Me.Label6.Text = "Vacuum section 1"
        '
        'lbl_puh
        '
        Me.lbl_puh.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_puh.Location = New System.Drawing.Point(19, 192)
        Me.lbl_puh.Name = "lbl_puh"
        Me.lbl_puh.Size = New System.Drawing.Size(352, 23)
        Me.lbl_puh.TabIndex = 390
        Me.lbl_puh.Tag = "175"
        Me.lbl_puh.Text = "Vacuum sections in bottom molds"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(15, 111)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(247, 23)
        Me.Label25.TabIndex = 404
        Me.Label25.Tag = ""
        Me.Label25.Text = "Time Vertical air cil. up delay"
        '
        'IO_BotVertCilUpdelay
        '
        Me.IO_BotVertCilUpdelay.Audit = Nothing
        Me.IO_BotVertCilUpdelay.AuditEnabled = False
        Me.IO_BotVertCilUpdelay.AuditMessage = "KremerIoField changed:"
        Me.IO_BotVertCilUpdelay.AuditSource = "KremerIoField"
        Me.IO_BotVertCilUpdelay.BackColor = System.Drawing.Color.White
        Me.IO_BotVertCilUpdelay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_BotVertCilUpdelay.Data = 0.0R
        Me.IO_BotVertCilUpdelay.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_BotVertCilUpdelay.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_BotVertCilUpdelay.InitialValue = True
        Me.IO_BotVertCilUpdelay.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_BotVertCilUpdelay.Location = New System.Drawing.Point(271, 109)
        Me.IO_BotVertCilUpdelay.LowerBound = 0.0R
        Me.IO_BotVertCilUpdelay.Name = "IO_BotVertCilUpdelay"
        Me.IO_BotVertCilUpdelay.OutputFormat = "0.0 ms"
        Me.IO_BotVertCilUpdelay.Size = New System.Drawing.Size(100, 22)
        Me.IO_BotVertCilUpdelay.TabIndex = 403
        Me.IO_BotVertCilUpdelay.Text = "0.0 ms"
        Me.IO_BotVertCilUpdelay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_BotVertCilUpdelay.UpperBound = 120000.0R
        Me.IO_BotVertCilUpdelay.UserInfo = Nothing
        Me.IO_BotVertCilUpdelay.UserLevel = 0
        '
        'VertUpDelay
        '
        Me.VertUpDelay.BindControl = Me.IO_BotVertCilUpdelay
        Me.VertUpDelay.BindProperty = "Data"
        Me.VertUpDelay.Data = Nothing
        Me.VertUpDelay.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.VertUpDelay.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.VertUpDelay.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].VerticalCilinderUpDelay"
        '
        'TakeOutUnit_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.IO_BotVertCilUpdelay)
        Me.Controls.Add(Me.btn_Enable6)
        Me.Controls.Add(Me.btn_Enable5)
        Me.Controls.Add(Me.btn_Enable4)
        Me.Controls.Add(Me.btn_Enable3)
        Me.Controls.Add(Me.btn_Enable2)
        Me.Controls.Add(Me.btn_Enable1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl_puh)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.IO_GT_WarningOut)
        Me.Controls.Add(Me.IO_GT_WarningIn)
        Me.Controls.Add(Me.IO_GT_Error)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Controls.Add(Me.Btn_Manual)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "TakeOutUnit_Settings"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "103"
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents IO_GT_WarningOut As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_GT_WarningIn As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_GT_Error As KremerControlsWin32.KremerIoField
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btn_Enable6 As KremerControlsWin32.KremerButton
    Friend WithEvents btn_Enable5 As KremerControlsWin32.KremerButton
    Friend WithEvents btn_Enable4 As KremerControlsWin32.KremerButton
    Friend WithEvents btn_Enable3 As KremerControlsWin32.KremerButton
    Friend WithEvents btn_Enable2 As KremerControlsWin32.KremerButton
    Friend WithEvents btn_Enable1 As KremerControlsWin32.KremerButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_puh As System.Windows.Forms.Label
    Friend WithEvents En1 As KremerControlsWin32.KremerVariable
    Friend WithEvents En2 As KremerControlsWin32.KremerVariable
    Friend WithEvents En3 As KremerControlsWin32.KremerVariable
    Friend WithEvents En4 As KremerControlsWin32.KremerVariable
    Friend WithEvents En5 As KremerControlsWin32.KremerVariable
    Friend WithEvents En6 As KremerControlsWin32.KremerVariable
    Friend WithEvents HOR_GT_Error As KremerControlsWin32.KremerVariable
    Friend WithEvents HOR_GT_WarningIn As KremerControlsWin32.KremerVariable
    Friend WithEvents HOR_GT_WarningOut As KremerControlsWin32.KremerVariable
    Friend WithEvents mxAutoMode As KremerControlsWin32.KremerVariable
    Friend WithEvents VertUpDelay As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_BotVertCilUpdelay As KremerControlsWin32.KremerIoField
    Friend WithEvents Label25 As System.Windows.Forms.Label

End Class
