<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gantry_Manual
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
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.BlowOff1 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_BlowOff1 = New KremerControlsWin32.KremerButton()
        Me.BlowOff2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_BlowOff2 = New KremerControlsWin32.KremerButton()
        Me.BlowOff3 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_BlowOff3 = New KremerControlsWin32.KremerButton()
        Me.BlowOff4 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_BlowOff4 = New KremerControlsWin32.KremerButton()
        Me.BlowOff5 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_BlowOff5 = New KremerControlsWin32.KremerButton()
        Me.BlowOff6 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_BlowOff6 = New KremerControlsWin32.KremerButton()
        Me.Vac1 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_Vac1 = New KremerControlsWin32.KremerButton()
        Me.Vac2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_Vac2 = New KremerControlsWin32.KremerButton()
        Me.Vac3 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_Vac3 = New KremerControlsWin32.KremerButton()
        Me.Vac4 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_Vac4 = New KremerControlsWin32.KremerButton()
        Me.Vac5 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_Vac5 = New KremerControlsWin32.KremerButton()
        Me.Vac6 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_Vac6 = New KremerControlsWin32.KremerButton()
        Me.HorzForward = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_H_In = New KremerControlsWin32.KremerButton()
        Me.HorzBackward = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_H_Out = New KremerControlsWin32.KremerButton()
        Me.VerticalUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_V_Up = New KremerControlsWin32.KremerButton()
        Me.VerticalDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_V_Down = New KremerControlsWin32.KremerButton()
        Me.HorizontalPos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_HorActPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.VerticalPos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_VertActPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
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
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.LineShape3, Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 435)
        Me.ShapeContainer1.TabIndex = 242
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 436
        Me.LineShape1.X2 = 786
        Me.LineShape1.Y1 = 27
        Me.LineShape1.Y2 = 27
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 22
        Me.LineShape3.X2 = 372
        Me.LineShape3.Y1 = 176
        Me.LineShape3.Y2 = 176
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 23
        Me.LineShape2.X2 = 373
        Me.LineShape2.Y1 = 25
        Me.LineShape2.Y2 = 25
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Me.VarCollector
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.BlowOff1)
        Me.VarCollector.Variables.Add(Me.BlowOff2)
        Me.VarCollector.Variables.Add(Me.BlowOff3)
        Me.VarCollector.Variables.Add(Me.BlowOff4)
        Me.VarCollector.Variables.Add(Me.BlowOff5)
        Me.VarCollector.Variables.Add(Me.BlowOff6)
        Me.VarCollector.Variables.Add(Me.Vac1)
        Me.VarCollector.Variables.Add(Me.Vac2)
        Me.VarCollector.Variables.Add(Me.Vac3)
        Me.VarCollector.Variables.Add(Me.Vac4)
        Me.VarCollector.Variables.Add(Me.Vac5)
        Me.VarCollector.Variables.Add(Me.Vac6)
        Me.VarCollector.Variables.Add(Me.HorzForward)
        Me.VarCollector.Variables.Add(Me.HorzBackward)
        Me.VarCollector.Variables.Add(Me.VerticalUp)
        Me.VarCollector.Variables.Add(Me.VerticalDown)
        Me.VarCollector.Variables.Add(Me.HorizontalPos)
        Me.VarCollector.Variables.Add(Me.VerticalPos)
        '
        'BlowOff1
        '
        Me.BlowOff1.BindControl = Me.Btn_BlowOff1
        Me.BlowOff1.BindProperty = "Data"
        Me.BlowOff1.Data = Nothing
        Me.BlowOff1.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BlowOff1.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BlowOff1.VariableName = "MAIN.ProductHandling.[Position1].BlowOff[1].mxHMI_On"
        '
        'Btn_BlowOff1
        '
        Me.Btn_BlowOff1.Audit = Nothing
        Me.Btn_BlowOff1.AuditEnabled = False
        Me.Btn_BlowOff1.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_BlowOff1.AuditSource = "KremerPushButton"
        Me.Btn_BlowOff1.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_BlowOff1.BackGroundImageOn = Nothing
        Me.Btn_BlowOff1.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.Btn_BlowOff1.Data = False
        Me.Btn_BlowOff1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BlowOff1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_BlowOff1.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_BlowOff1.Location = New System.Drawing.Point(681, 31)
        Me.Btn_BlowOff1.Name = "Btn_BlowOff1"
        Me.Btn_BlowOff1.Size = New System.Drawing.Size(106, 36)
        Me.Btn_BlowOff1.State = False
        Me.Btn_BlowOff1.StateIsData = True
        Me.Btn_BlowOff1.StateText = New String() {Nothing, Nothing}
        Me.Btn_BlowOff1.TabIndex = 378
        Me.Btn_BlowOff1.Tag = "293"
        Me.Btn_BlowOff1.Text = "On"
        Me.Btn_BlowOff1.UserInfo = Nothing
        Me.Btn_BlowOff1.UserLevel = 0
        Me.Btn_BlowOff1.UseStateText = False
        '
        'BlowOff2
        '
        Me.BlowOff2.BindControl = Me.Btn_BlowOff2
        Me.BlowOff2.BindProperty = "Data"
        Me.BlowOff2.Data = Nothing
        Me.BlowOff2.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BlowOff2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BlowOff2.VariableName = "MAIN.ProductHandling.[Position1].BlowOff[2].mxHMI_On"
        '
        'Btn_BlowOff2
        '
        Me.Btn_BlowOff2.Audit = Nothing
        Me.Btn_BlowOff2.AuditEnabled = False
        Me.Btn_BlowOff2.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_BlowOff2.AuditSource = "KremerPushButton"
        Me.Btn_BlowOff2.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_BlowOff2.BackGroundImageOn = Nothing
        Me.Btn_BlowOff2.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.Btn_BlowOff2.Data = False
        Me.Btn_BlowOff2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BlowOff2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_BlowOff2.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_BlowOff2.Location = New System.Drawing.Point(681, 68)
        Me.Btn_BlowOff2.Name = "Btn_BlowOff2"
        Me.Btn_BlowOff2.Size = New System.Drawing.Size(106, 36)
        Me.Btn_BlowOff2.State = False
        Me.Btn_BlowOff2.StateIsData = True
        Me.Btn_BlowOff2.StateText = New String() {Nothing, Nothing}
        Me.Btn_BlowOff2.TabIndex = 372
        Me.Btn_BlowOff2.Tag = "293"
        Me.Btn_BlowOff2.Text = "On"
        Me.Btn_BlowOff2.UserInfo = Nothing
        Me.Btn_BlowOff2.UserLevel = 0
        Me.Btn_BlowOff2.UseStateText = False
        '
        'BlowOff3
        '
        Me.BlowOff3.BindControl = Me.Btn_BlowOff3
        Me.BlowOff3.BindProperty = "Data"
        Me.BlowOff3.Data = Nothing
        Me.BlowOff3.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BlowOff3.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BlowOff3.VariableName = "MAIN.ProductHandling.[Position1].BlowOff[3].mxHMI_On"
        '
        'Btn_BlowOff3
        '
        Me.Btn_BlowOff3.Audit = Nothing
        Me.Btn_BlowOff3.AuditEnabled = False
        Me.Btn_BlowOff3.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_BlowOff3.AuditSource = "KremerPushButton"
        Me.Btn_BlowOff3.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_BlowOff3.BackGroundImageOn = Nothing
        Me.Btn_BlowOff3.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.Btn_BlowOff3.Data = False
        Me.Btn_BlowOff3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BlowOff3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_BlowOff3.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_BlowOff3.Location = New System.Drawing.Point(681, 105)
        Me.Btn_BlowOff3.Name = "Btn_BlowOff3"
        Me.Btn_BlowOff3.Size = New System.Drawing.Size(106, 36)
        Me.Btn_BlowOff3.State = False
        Me.Btn_BlowOff3.StateIsData = True
        Me.Btn_BlowOff3.StateText = New String() {Nothing, Nothing}
        Me.Btn_BlowOff3.TabIndex = 374
        Me.Btn_BlowOff3.Tag = "293"
        Me.Btn_BlowOff3.Text = "On"
        Me.Btn_BlowOff3.UserInfo = Nothing
        Me.Btn_BlowOff3.UserLevel = 0
        Me.Btn_BlowOff3.UseStateText = False
        '
        'BlowOff4
        '
        Me.BlowOff4.BindControl = Me.Btn_BlowOff4
        Me.BlowOff4.BindProperty = "Data"
        Me.BlowOff4.Data = Nothing
        Me.BlowOff4.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BlowOff4.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BlowOff4.VariableName = "MAIN.ProductHandling.[Position1].BlowOff[4].mxHMI_On"
        '
        'Btn_BlowOff4
        '
        Me.Btn_BlowOff4.Audit = Nothing
        Me.Btn_BlowOff4.AuditEnabled = False
        Me.Btn_BlowOff4.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_BlowOff4.AuditSource = "KremerPushButton"
        Me.Btn_BlowOff4.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_BlowOff4.BackGroundImageOn = Nothing
        Me.Btn_BlowOff4.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.Btn_BlowOff4.Data = False
        Me.Btn_BlowOff4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BlowOff4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_BlowOff4.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_BlowOff4.Location = New System.Drawing.Point(681, 142)
        Me.Btn_BlowOff4.Name = "Btn_BlowOff4"
        Me.Btn_BlowOff4.Size = New System.Drawing.Size(106, 36)
        Me.Btn_BlowOff4.State = False
        Me.Btn_BlowOff4.StateIsData = True
        Me.Btn_BlowOff4.StateText = New String() {Nothing, Nothing}
        Me.Btn_BlowOff4.TabIndex = 376
        Me.Btn_BlowOff4.Tag = "293"
        Me.Btn_BlowOff4.Text = "On"
        Me.Btn_BlowOff4.UserInfo = Nothing
        Me.Btn_BlowOff4.UserLevel = 0
        Me.Btn_BlowOff4.UseStateText = False
        '
        'BlowOff5
        '
        Me.BlowOff5.BindControl = Me.Btn_BlowOff5
        Me.BlowOff5.BindProperty = "Data"
        Me.BlowOff5.Data = Nothing
        Me.BlowOff5.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BlowOff5.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BlowOff5.VariableName = "MAIN.ProductHandling.[Position1].BlowOff[5].mxHMI_On"
        '
        'Btn_BlowOff5
        '
        Me.Btn_BlowOff5.Audit = Nothing
        Me.Btn_BlowOff5.AuditEnabled = False
        Me.Btn_BlowOff5.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_BlowOff5.AuditSource = "KremerPushButton"
        Me.Btn_BlowOff5.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_BlowOff5.BackGroundImageOn = Nothing
        Me.Btn_BlowOff5.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.Btn_BlowOff5.Data = False
        Me.Btn_BlowOff5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BlowOff5.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_BlowOff5.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_BlowOff5.Location = New System.Drawing.Point(681, 179)
        Me.Btn_BlowOff5.Name = "Btn_BlowOff5"
        Me.Btn_BlowOff5.Size = New System.Drawing.Size(106, 36)
        Me.Btn_BlowOff5.State = False
        Me.Btn_BlowOff5.StateIsData = True
        Me.Btn_BlowOff5.StateText = New String() {Nothing, Nothing}
        Me.Btn_BlowOff5.TabIndex = 379
        Me.Btn_BlowOff5.Tag = "293"
        Me.Btn_BlowOff5.Text = "On"
        Me.Btn_BlowOff5.UserInfo = Nothing
        Me.Btn_BlowOff5.UserLevel = 0
        Me.Btn_BlowOff5.UseStateText = False
        '
        'BlowOff6
        '
        Me.BlowOff6.BindControl = Me.Btn_BlowOff6
        Me.BlowOff6.BindProperty = "Data"
        Me.BlowOff6.Data = Nothing
        Me.BlowOff6.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BlowOff6.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BlowOff6.VariableName = "MAIN.ProductHandling.[Position1].BlowOff[6].mxHMI_On"
        '
        'Btn_BlowOff6
        '
        Me.Btn_BlowOff6.Audit = Nothing
        Me.Btn_BlowOff6.AuditEnabled = False
        Me.Btn_BlowOff6.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_BlowOff6.AuditSource = "KremerPushButton"
        Me.Btn_BlowOff6.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_BlowOff6.BackGroundImageOn = Nothing
        Me.Btn_BlowOff6.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.Btn_BlowOff6.Data = False
        Me.Btn_BlowOff6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BlowOff6.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_BlowOff6.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_BlowOff6.Location = New System.Drawing.Point(681, 216)
        Me.Btn_BlowOff6.Name = "Btn_BlowOff6"
        Me.Btn_BlowOff6.Size = New System.Drawing.Size(106, 36)
        Me.Btn_BlowOff6.State = False
        Me.Btn_BlowOff6.StateIsData = True
        Me.Btn_BlowOff6.StateText = New String() {Nothing, Nothing}
        Me.Btn_BlowOff6.TabIndex = 383
        Me.Btn_BlowOff6.Tag = "293"
        Me.Btn_BlowOff6.Text = "On"
        Me.Btn_BlowOff6.UserInfo = Nothing
        Me.Btn_BlowOff6.UserLevel = 0
        Me.Btn_BlowOff6.UseStateText = False
        '
        'Vac1
        '
        Me.Vac1.BindControl = Me.Btn_Vac1
        Me.Vac1.BindProperty = "Data"
        Me.Vac1.Data = Nothing
        Me.Vac1.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Vac1.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Vac1.VariableName = "MAIN.ProductHandling.[Position1].VacuumValve[1].mxHMI_On"
        '
        'Btn_Vac1
        '
        Me.Btn_Vac1.Audit = Nothing
        Me.Btn_Vac1.AuditEnabled = False
        Me.Btn_Vac1.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_Vac1.AuditSource = "KremerPushButton"
        Me.Btn_Vac1.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Vac1.BackGroundImageOn = Nothing
        Me.Btn_Vac1.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.Btn_Vac1.Data = False
        Me.Btn_Vac1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Vac1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Vac1.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_Vac1.Location = New System.Drawing.Point(268, 179)
        Me.Btn_Vac1.Name = "Btn_Vac1"
        Me.Btn_Vac1.Size = New System.Drawing.Size(106, 36)
        Me.Btn_Vac1.State = False
        Me.Btn_Vac1.StateIsData = True
        Me.Btn_Vac1.StateText = New String() {Nothing, Nothing}
        Me.Btn_Vac1.TabIndex = 361
        Me.Btn_Vac1.Tag = "293"
        Me.Btn_Vac1.Text = "On"
        Me.Btn_Vac1.UserInfo = Nothing
        Me.Btn_Vac1.UserLevel = 0
        Me.Btn_Vac1.UseStateText = False
        '
        'Vac2
        '
        Me.Vac2.BindControl = Me.Btn_Vac2
        Me.Vac2.BindProperty = "Data"
        Me.Vac2.Data = Nothing
        Me.Vac2.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Vac2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Vac2.VariableName = "MAIN.ProductHandling.[Position1].VacuumValve[2].mxHMI_On"
        '
        'Btn_Vac2
        '
        Me.Btn_Vac2.Audit = Nothing
        Me.Btn_Vac2.AuditEnabled = False
        Me.Btn_Vac2.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_Vac2.AuditSource = "KremerPushButton"
        Me.Btn_Vac2.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Vac2.BackGroundImageOn = Nothing
        Me.Btn_Vac2.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.Btn_Vac2.Data = False
        Me.Btn_Vac2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Vac2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Vac2.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_Vac2.Location = New System.Drawing.Point(268, 216)
        Me.Btn_Vac2.Name = "Btn_Vac2"
        Me.Btn_Vac2.Size = New System.Drawing.Size(106, 36)
        Me.Btn_Vac2.State = False
        Me.Btn_Vac2.StateIsData = True
        Me.Btn_Vac2.StateText = New String() {Nothing, Nothing}
        Me.Btn_Vac2.TabIndex = 355
        Me.Btn_Vac2.Tag = "293"
        Me.Btn_Vac2.Text = "On"
        Me.Btn_Vac2.UserInfo = Nothing
        Me.Btn_Vac2.UserLevel = 0
        Me.Btn_Vac2.UseStateText = False
        '
        'Vac3
        '
        Me.Vac3.BindControl = Me.Btn_Vac3
        Me.Vac3.BindProperty = "Data"
        Me.Vac3.Data = Nothing
        Me.Vac3.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Vac3.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Vac3.VariableName = "MAIN.ProductHandling.[Position1].VacuumValve[3].mxHMI_On"
        '
        'Btn_Vac3
        '
        Me.Btn_Vac3.Audit = Nothing
        Me.Btn_Vac3.AuditEnabled = False
        Me.Btn_Vac3.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_Vac3.AuditSource = "KremerPushButton"
        Me.Btn_Vac3.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Vac3.BackGroundImageOn = Nothing
        Me.Btn_Vac3.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.Btn_Vac3.Data = False
        Me.Btn_Vac3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Vac3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Vac3.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_Vac3.Location = New System.Drawing.Point(268, 253)
        Me.Btn_Vac3.Name = "Btn_Vac3"
        Me.Btn_Vac3.Size = New System.Drawing.Size(106, 36)
        Me.Btn_Vac3.State = False
        Me.Btn_Vac3.StateIsData = True
        Me.Btn_Vac3.StateText = New String() {Nothing, Nothing}
        Me.Btn_Vac3.TabIndex = 357
        Me.Btn_Vac3.Tag = "293"
        Me.Btn_Vac3.Text = "On"
        Me.Btn_Vac3.UserInfo = Nothing
        Me.Btn_Vac3.UserLevel = 0
        Me.Btn_Vac3.UseStateText = False
        '
        'Vac4
        '
        Me.Vac4.BindControl = Me.Btn_Vac4
        Me.Vac4.BindProperty = "Data"
        Me.Vac4.Data = Nothing
        Me.Vac4.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Vac4.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Vac4.VariableName = "MAIN.ProductHandling.[Position1].VacuumValve[4].mxHMI_On"
        '
        'Btn_Vac4
        '
        Me.Btn_Vac4.Audit = Nothing
        Me.Btn_Vac4.AuditEnabled = False
        Me.Btn_Vac4.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_Vac4.AuditSource = "KremerPushButton"
        Me.Btn_Vac4.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Vac4.BackGroundImageOn = Nothing
        Me.Btn_Vac4.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.Btn_Vac4.Data = False
        Me.Btn_Vac4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Vac4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Vac4.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_Vac4.Location = New System.Drawing.Point(268, 290)
        Me.Btn_Vac4.Name = "Btn_Vac4"
        Me.Btn_Vac4.Size = New System.Drawing.Size(106, 36)
        Me.Btn_Vac4.State = False
        Me.Btn_Vac4.StateIsData = True
        Me.Btn_Vac4.StateText = New String() {Nothing, Nothing}
        Me.Btn_Vac4.TabIndex = 359
        Me.Btn_Vac4.Tag = "293"
        Me.Btn_Vac4.Text = "On"
        Me.Btn_Vac4.UserInfo = Nothing
        Me.Btn_Vac4.UserLevel = 0
        Me.Btn_Vac4.UseStateText = False
        '
        'Vac5
        '
        Me.Vac5.BindControl = Me.Btn_Vac5
        Me.Vac5.BindProperty = "Data"
        Me.Vac5.Data = Nothing
        Me.Vac5.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Vac5.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Vac5.VariableName = "MAIN.ProductHandling.[Position1].VacuumValve[5].mxHMI_On"
        '
        'Btn_Vac5
        '
        Me.Btn_Vac5.Audit = Nothing
        Me.Btn_Vac5.AuditEnabled = False
        Me.Btn_Vac5.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_Vac5.AuditSource = "KremerPushButton"
        Me.Btn_Vac5.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Vac5.BackGroundImageOn = Nothing
        Me.Btn_Vac5.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.Btn_Vac5.Data = False
        Me.Btn_Vac5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Vac5.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Vac5.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_Vac5.Location = New System.Drawing.Point(268, 327)
        Me.Btn_Vac5.Name = "Btn_Vac5"
        Me.Btn_Vac5.Size = New System.Drawing.Size(106, 36)
        Me.Btn_Vac5.State = False
        Me.Btn_Vac5.StateIsData = True
        Me.Btn_Vac5.StateText = New String() {Nothing, Nothing}
        Me.Btn_Vac5.TabIndex = 363
        Me.Btn_Vac5.Tag = "293"
        Me.Btn_Vac5.Text = "On"
        Me.Btn_Vac5.UserInfo = Nothing
        Me.Btn_Vac5.UserLevel = 0
        Me.Btn_Vac5.UseStateText = False
        '
        'Vac6
        '
        Me.Vac6.BindControl = Me.Btn_Vac6
        Me.Vac6.BindProperty = "Data"
        Me.Vac6.Data = Nothing
        Me.Vac6.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Vac6.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Vac6.VariableName = "MAIN.ProductHandling.[Position1].VacuumValve[6].mxHMI_On"
        '
        'Btn_Vac6
        '
        Me.Btn_Vac6.Audit = Nothing
        Me.Btn_Vac6.AuditEnabled = False
        Me.Btn_Vac6.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_Vac6.AuditSource = "KremerPushButton"
        Me.Btn_Vac6.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Vac6.BackGroundImageOn = Nothing
        Me.Btn_Vac6.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.Btn_Vac6.Data = False
        Me.Btn_Vac6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Vac6.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Vac6.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_Vac6.Location = New System.Drawing.Point(268, 364)
        Me.Btn_Vac6.Name = "Btn_Vac6"
        Me.Btn_Vac6.Size = New System.Drawing.Size(106, 36)
        Me.Btn_Vac6.State = False
        Me.Btn_Vac6.StateIsData = True
        Me.Btn_Vac6.StateText = New String() {Nothing, Nothing}
        Me.Btn_Vac6.TabIndex = 367
        Me.Btn_Vac6.Tag = "293"
        Me.Btn_Vac6.Text = "On"
        Me.Btn_Vac6.UserInfo = Nothing
        Me.Btn_Vac6.UserLevel = 0
        Me.Btn_Vac6.UseStateText = False
        '
        'HorzForward
        '
        Me.HorzForward.BindControl = Me.Btn_H_In
        Me.HorzForward.BindProperty = "Data"
        Me.HorzForward.Data = Nothing
        Me.HorzForward.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.HorzForward.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.HorzForward.VariableName = "MAIN.ProductHandling.[Position1].HorizontalAxis.HMI_Forward"
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
        Me.Btn_H_In.Location = New System.Drawing.Point(161, 31)
        Me.Btn_H_In.Name = "Btn_H_In"
        Me.Btn_H_In.Size = New System.Drawing.Size(106, 36)
        Me.Btn_H_In.State = False
        Me.Btn_H_In.StateIsData = True
        Me.Btn_H_In.StateText = New String() {Nothing, Nothing}
        Me.Btn_H_In.TabIndex = 345
        Me.Btn_H_In.Tag = "31"
        Me.Btn_H_In.Text = "Forward"
        Me.Btn_H_In.UserInfo = Nothing
        Me.Btn_H_In.UserLevel = 0
        Me.Btn_H_In.UseStateText = False
        '
        'HorzBackward
        '
        Me.HorzBackward.BindControl = Me.Btn_H_Out
        Me.HorzBackward.BindProperty = "Data"
        Me.HorzBackward.Data = Nothing
        Me.HorzBackward.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.HorzBackward.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.HorzBackward.VariableName = "MAIN.ProductHandling.[Position1].HorizontalAxis.HMI_Backward"
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
        Me.Btn_H_Out.Location = New System.Drawing.Point(270, 31)
        Me.Btn_H_Out.Name = "Btn_H_Out"
        Me.Btn_H_Out.Size = New System.Drawing.Size(106, 36)
        Me.Btn_H_Out.State = False
        Me.Btn_H_Out.StateIsData = True
        Me.Btn_H_Out.StateText = New String() {Nothing, Nothing}
        Me.Btn_H_Out.TabIndex = 341
        Me.Btn_H_Out.Tag = "32"
        Me.Btn_H_Out.Text = "Backward"
        Me.Btn_H_Out.UserInfo = Nothing
        Me.Btn_H_Out.UserLevel = 0
        Me.Btn_H_Out.UseStateText = False
        '
        'VerticalUp
        '
        Me.VerticalUp.BindControl = Me.Btn_V_Up
        Me.VerticalUp.BindProperty = "Data"
        Me.VerticalUp.Data = Nothing
        Me.VerticalUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.VerticalUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.VerticalUp.VariableName = "MAIN.ProductHandling.[Position1].VerticalAxis.HMI_Forward"
        '
        'Btn_V_Up
        '
        Me.Btn_V_Up.Audit = Nothing
        Me.Btn_V_Up.AuditEnabled = False
        Me.Btn_V_Up.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_V_Up.AuditSource = "KremerPushButton"
        Me.Btn_V_Up.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_V_Up.BackGroundImageOn = Nothing
        Me.Btn_V_Up.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_V_Up.Data = False
        Me.Btn_V_Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_V_Up.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_V_Up.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_V_Up.Location = New System.Drawing.Point(161, 93)
        Me.Btn_V_Up.Name = "Btn_V_Up"
        Me.Btn_V_Up.Size = New System.Drawing.Size(106, 36)
        Me.Btn_V_Up.State = False
        Me.Btn_V_Up.StateIsData = True
        Me.Btn_V_Up.StateText = New String() {Nothing, Nothing}
        Me.Btn_V_Up.TabIndex = 346
        Me.Btn_V_Up.Tag = ""
        Me.Btn_V_Up.Text = "Up"
        Me.Btn_V_Up.UserInfo = Nothing
        Me.Btn_V_Up.UserLevel = 0
        Me.Btn_V_Up.UseStateText = False
        '
        'VerticalDown
        '
        Me.VerticalDown.BindControl = Me.Btn_V_Down
        Me.VerticalDown.BindProperty = "Data"
        Me.VerticalDown.Data = Nothing
        Me.VerticalDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.VerticalDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.VerticalDown.VariableName = "MAIN.ProductHandling.[Position1].VerticalAxis.HMI_Backward"
        '
        'Btn_V_Down
        '
        Me.Btn_V_Down.Audit = Nothing
        Me.Btn_V_Down.AuditEnabled = False
        Me.Btn_V_Down.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_V_Down.AuditSource = "KremerPushButton"
        Me.Btn_V_Down.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_V_Down.BackGroundImageOn = Nothing
        Me.Btn_V_Down.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_V_Down.Data = False
        Me.Btn_V_Down.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_V_Down.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_V_Down.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_V_Down.Location = New System.Drawing.Point(270, 93)
        Me.Btn_V_Down.Name = "Btn_V_Down"
        Me.Btn_V_Down.Size = New System.Drawing.Size(106, 36)
        Me.Btn_V_Down.State = False
        Me.Btn_V_Down.StateIsData = True
        Me.Btn_V_Down.StateText = New String() {Nothing, Nothing}
        Me.Btn_V_Down.TabIndex = 344
        Me.Btn_V_Down.Tag = ""
        Me.Btn_V_Down.Text = "Down"
        Me.Btn_V_Down.UserInfo = Nothing
        Me.Btn_V_Down.UserLevel = 0
        Me.Btn_V_Down.UseStateText = False
        '
        'HorizontalPos
        '
        Me.HorizontalPos.BindControl = Me.IO_HorActPos
        Me.HorizontalPos.BindProperty = "Data"
        Me.HorizontalPos.Data = Nothing
        Me.HorizontalPos.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.HorizontalPos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.HorizontalPos.VariableName = "MAIN.ProductHandling.[Position1].HorizontalAxis.ActPosition"
        '
        'IO_HorActPos
        '
        Me.IO_HorActPos.Audit = Nothing
        Me.IO_HorActPos.AuditEnabled = False
        Me.IO_HorActPos.AuditMessage = "KremerIoField changed:"
        Me.IO_HorActPos.AuditSource = "KremerIoField"
        Me.IO_HorActPos.Data = 0R
        Me.IO_HorActPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_HorActPos.InitialValue = True
        Me.IO_HorActPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_HorActPos.Location = New System.Drawing.Point(302, 3)
        Me.IO_HorActPos.LowerBound = 0R
        Me.IO_HorActPos.Name = "IO_HorActPos"
        Me.IO_HorActPos.OutputFormat = "0.0 mm"
        Me.IO_HorActPos.Size = New System.Drawing.Size(71, 21)
        Me.IO_HorActPos.TabIndex = 403
        Me.IO_HorActPos.Text = "0,0 mm"
        Me.IO_HorActPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IO_HorActPos.UpperBound = 1000.0R
        Me.IO_HorActPos.UserInfo = Nothing
        Me.IO_HorActPos.UserLevel = 0
        '
        'VerticalPos
        '
        Me.VerticalPos.BindControl = Me.IO_VertActPos
        Me.VerticalPos.BindProperty = "Data"
        Me.VerticalPos.Data = Nothing
        Me.VerticalPos.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.VerticalPos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.VerticalPos.VariableName = "MAIN.ProductHandling.[Position1].VerticalAxis.ActPosition"
        '
        'IO_VertActPos
        '
        Me.IO_VertActPos.Audit = Nothing
        Me.IO_VertActPos.AuditEnabled = False
        Me.IO_VertActPos.AuditMessage = "KremerIoField changed:"
        Me.IO_VertActPos.AuditSource = "KremerIoField"
        Me.IO_VertActPos.Data = 0R
        Me.IO_VertActPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_VertActPos.InitialValue = True
        Me.IO_VertActPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_VertActPos.Location = New System.Drawing.Point(305, 70)
        Me.IO_VertActPos.LowerBound = 0R
        Me.IO_VertActPos.Name = "IO_VertActPos"
        Me.IO_VertActPos.OutputFormat = "0.0 mm"
        Me.IO_VertActPos.Size = New System.Drawing.Size(71, 21)
        Me.IO_VertActPos.TabIndex = 402
        Me.IO_VertActPos.Text = "0,0 mm"
        Me.IO_VertActPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IO_VertActPos.UpperBound = 1000.0R
        Me.IO_VertActPos.UserInfo = Nothing
        Me.IO_VertActPos.UserLevel = 0
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(21, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(291, 23)
        Me.Label10.TabIndex = 280
        Me.Label10.Tag = "81"
        Me.Label10.Text = "Axis"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 23)
        Me.Label7.TabIndex = 343
        Me.Label7.Tag = "83"
        Me.Label7.Text = "Vertical"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 23)
        Me.Label8.TabIndex = 342
        Me.Label8.Tag = "82"
        Me.Label8.Text = "Horizontal"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(19, 191)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(243, 23)
        Me.Label15.TabIndex = 360
        Me.Label15.Tag = "470"
        Me.Label15.Text = "Vacuum valve section 1"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(18, 297)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(243, 23)
        Me.Label14.TabIndex = 358
        Me.Label14.Tag = "473"
        Me.Label14.Text = "Vacuum valve section 4"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(19, 260)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(243, 23)
        Me.Label13.TabIndex = 356
        Me.Label13.Tag = "472"
        Me.Label13.Text = "Vacuum valve section 3"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 223)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(243, 23)
        Me.Label12.TabIndex = 354
        Me.Label12.Tag = "471"
        Me.Label12.Text = "Vacuum valve section 2"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(19, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 23)
        Me.Label1.TabIndex = 364
        Me.Label1.Tag = "286"
        Me.Label1.Text = "Vacuum valve "
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 333)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 23)
        Me.Label2.TabIndex = 365
        Me.Label2.Tag = "474"
        Me.Label2.Text = "Vacuum valve section 5"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 371)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(243, 23)
        Me.Label3.TabIndex = 366
        Me.Label3.Tag = "475"
        Me.Label3.Text = "Vacuum valve section 6"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(431, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(243, 23)
        Me.Label5.TabIndex = 382
        Me.Label5.Tag = "481"
        Me.Label5.Text = "Blow off valve 6"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(431, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(243, 23)
        Me.Label6.TabIndex = 381
        Me.Label6.Tag = "480"
        Me.Label6.Text = "Blow off valve 5"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(432, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(329, 23)
        Me.Label9.TabIndex = 380
        Me.Label9.Tag = "287"
        Me.Label9.Text = "Blow off valve "
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(432, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(243, 23)
        Me.Label11.TabIndex = 377
        Me.Label11.Tag = "476"
        Me.Label11.Text = "Blow off valve 1"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(431, 149)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(243, 23)
        Me.Label16.TabIndex = 375
        Me.Label16.Tag = "479"
        Me.Label16.Text = "Blow off valve 4"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(432, 112)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(243, 23)
        Me.Label17.TabIndex = 373
        Me.Label17.Tag = "478"
        Me.Label17.Text = "Blow off valve 3"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(432, 75)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(243, 23)
        Me.Label18.TabIndex = 371
        Me.Label18.Tag = "477"
        Me.Label18.Text = "Blow off valve 2"
        '
        'Gantry_Manual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.IO_HorActPos)
        Me.Controls.Add(Me.IO_VertActPos)
        Me.Controls.Add(Me.Btn_BlowOff6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Btn_BlowOff5)
        Me.Controls.Add(Me.Btn_BlowOff1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Btn_BlowOff4)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Btn_BlowOff3)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Btn_BlowOff2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Btn_Vac6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Vac5)
        Me.Controls.Add(Me.Btn_Vac1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Btn_Vac4)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Btn_Vac3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Btn_Vac2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Btn_V_Up)
        Me.Controls.Add(Me.Btn_H_In)
        Me.Controls.Add(Me.Btn_V_Down)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Btn_H_Out)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Btn_Settings)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Gantry_Manual"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "102"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Settings As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Btn_V_Up As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_H_In As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_V_Down As KremerControlsWin32.KremerButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Btn_H_Out As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_Vac5 As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_Vac1 As KremerControlsWin32.KremerButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Btn_Vac4 As KremerControlsWin32.KremerButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Btn_Vac3 As KremerControlsWin32.KremerButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Btn_Vac2 As KremerControlsWin32.KremerButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Btn_Vac6 As KremerControlsWin32.KremerButton
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Btn_BlowOff6 As KremerControlsWin32.KremerButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Btn_BlowOff5 As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_BlowOff1 As KremerControlsWin32.KremerButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Btn_BlowOff4 As KremerControlsWin32.KremerButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Btn_BlowOff3 As KremerControlsWin32.KremerButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Btn_BlowOff2 As KremerControlsWin32.KremerButton
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents BlowOff1 As KremerControlsWin32.KremerVariable
    Friend WithEvents BlowOff2 As KremerControlsWin32.KremerVariable
    Friend WithEvents BlowOff3 As KremerControlsWin32.KremerVariable
    Friend WithEvents BlowOff4 As KremerControlsWin32.KremerVariable
    Friend WithEvents BlowOff5 As KremerControlsWin32.KremerVariable
    Friend WithEvents BlowOff6 As KremerControlsWin32.KremerVariable
    Friend WithEvents Vac1 As KremerControlsWin32.KremerVariable
    Friend WithEvents Vac2 As KremerControlsWin32.KremerVariable
    Friend WithEvents Vac3 As KremerControlsWin32.KremerVariable
    Friend WithEvents Vac4 As KremerControlsWin32.KremerVariable
    Friend WithEvents Vac5 As KremerControlsWin32.KremerVariable
    Friend WithEvents Vac6 As KremerControlsWin32.KremerVariable
    Friend WithEvents HorzForward As KremerControlsWin32.KremerVariable
    Friend WithEvents HorzBackward As KremerControlsWin32.KremerVariable
    Friend WithEvents VerticalUp As KremerControlsWin32.KremerVariable
    Friend WithEvents VerticalDown As KremerControlsWin32.KremerVariable
    Friend WithEvents HorizontalPos As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_HorActPos As KremerControlsWin32.KremerIoField
    Friend WithEvents VerticalPos As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_VertActPos As KremerControlsWin32.KremerIoField

End Class
