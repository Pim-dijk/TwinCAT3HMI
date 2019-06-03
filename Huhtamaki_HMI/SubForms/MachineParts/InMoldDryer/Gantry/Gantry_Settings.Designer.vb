<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gantry_Settings
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
        Me.LineShape10 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.mxAutoMode = New KremerControlsWin32.KremerVariable(Me.components)
        Me.VER_MAN_VELO = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_VertManualVelo = New KremerControlsWin32.KremerIoField(Me.components)
        Me.VER_AUTO_VELO = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_VertAutoVelo = New KremerControlsWin32.KremerIoField(Me.components)
        Me.VER_POS_TRANSPORT = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_VertTranspPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.VER_ACT_POS = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_VertActPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.HOR_MAN_VELO = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_HorManualVelo = New KremerControlsWin32.KremerIoField(Me.components)
        Me.HOR_AUTO_VELO = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_HorAutoVelo = New KremerControlsWin32.KremerIoField(Me.components)
        Me.HOR_PICKUP_POS = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_PickUpPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.HOR_ACT_POS = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_HorActPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.HOR_DROP_POS = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_DropOffpos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.RestPositionOffset = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_Vert_RestPosOffset = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PickupDownTime = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_GantryDownPickUp = New KremerControlsWin32.KremerIoField(Me.components)
        Me.EN_VAC_1 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_Vac1 = New KremerControlsWin32.KremerButton()
        Me.EN_VAC_2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_Vac2 = New KremerControlsWin32.KremerButton()
        Me.EN_VAC_3 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_Vac3 = New KremerControlsWin32.KremerButton()
        Me.EN_VAC_4 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_Vac4 = New KremerControlsWin32.KremerButton()
        Me.EN_VAC_5 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_Vac5 = New KremerControlsWin32.KremerButton()
        Me.EN_VAC_6 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_Vac6 = New KremerControlsWin32.KremerButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
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
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape10, Me.LineShape9, Me.LineShape8, Me.LineShape7})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 435)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
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
        Me.LineShape9.Y2 = 115
        '
        'LineShape8
        '
        Me.LineShape8.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape8.Name = "LineShape8"
        Me.LineShape8.X1 = 679
        Me.LineShape8.X2 = 679
        Me.LineShape8.Y1 = 36
        Me.LineShape8.Y2 = 115
        '
        'LineShape7
        '
        Me.LineShape7.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 434
        Me.LineShape7.X2 = 784
        Me.LineShape7.Y1 = 36
        Me.LineShape7.Y2 = 36
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.mxAutoMode)
        Me.VarCollector.Variables.Add(Me.VER_MAN_VELO)
        Me.VarCollector.Variables.Add(Me.VER_AUTO_VELO)
        Me.VarCollector.Variables.Add(Me.VER_POS_TRANSPORT)
        Me.VarCollector.Variables.Add(Me.VER_ACT_POS)
        Me.VarCollector.Variables.Add(Me.HOR_MAN_VELO)
        Me.VarCollector.Variables.Add(Me.HOR_AUTO_VELO)
        Me.VarCollector.Variables.Add(Me.HOR_PICKUP_POS)
        Me.VarCollector.Variables.Add(Me.HOR_ACT_POS)
        Me.VarCollector.Variables.Add(Me.HOR_DROP_POS)
        Me.VarCollector.Variables.Add(Me.RestPositionOffset)
        Me.VarCollector.Variables.Add(Me.PickupDownTime)
        Me.VarCollector.Variables.Add(Me.EN_VAC_1)
        Me.VarCollector.Variables.Add(Me.EN_VAC_2)
        Me.VarCollector.Variables.Add(Me.EN_VAC_3)
        Me.VarCollector.Variables.Add(Me.EN_VAC_4)
        Me.VarCollector.Variables.Add(Me.EN_VAC_5)
        Me.VarCollector.Variables.Add(Me.EN_VAC_6)
        '
        'mxAutoMode
        '
        Me.mxAutoMode.BindControl = Nothing
        Me.mxAutoMode.BindProperty = "Data"
        Me.mxAutoMode.Data = Nothing
        Me.mxAutoMode.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.mxAutoMode.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.mxAutoMode.VariableName = "Main.mxAutoMode"
        '
        'VER_MAN_VELO
        '
        Me.VER_MAN_VELO.BindControl = Me.IO_VertManualVelo
        Me.VER_MAN_VELO.BindProperty = "Data"
        Me.VER_MAN_VELO.Data = Nothing
        Me.VER_MAN_VELO.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.VER_MAN_VELO.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.VER_MAN_VELO.VariableName = "MAIN.ProductHandling.MachParameters.[Position1].Vert_VelocityManual"
        '
        'IO_VertManualVelo
        '
        Me.IO_VertManualVelo.Audit = Nothing
        Me.IO_VertManualVelo.AuditEnabled = False
        Me.IO_VertManualVelo.AuditMessage = "KremerIoField changed:"
        Me.IO_VertManualVelo.AuditSource = "KremerIoField"
        Me.IO_VertManualVelo.BackColor = System.Drawing.Color.White
        Me.IO_VertManualVelo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_VertManualVelo.Data = 0.0R
        Me.IO_VertManualVelo.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_VertManualVelo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_VertManualVelo.InitialValue = True
        Me.IO_VertManualVelo.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_VertManualVelo.Location = New System.Drawing.Point(271, 39)
        Me.IO_VertManualVelo.LowerBound = 0.0R
        Me.IO_VertManualVelo.Name = "IO_VertManualVelo"
        Me.IO_VertManualVelo.OutputFormat = "0.0 mm/s"
        Me.IO_VertManualVelo.Size = New System.Drawing.Size(100, 22)
        Me.IO_VertManualVelo.TabIndex = 393
        Me.IO_VertManualVelo.Text = "0.0 mm/s"
        Me.IO_VertManualVelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_VertManualVelo.UpperBound = 2000.0R
        Me.IO_VertManualVelo.UserInfo = Nothing
        Me.IO_VertManualVelo.UserLevel = 0
        '
        'VER_AUTO_VELO
        '
        Me.VER_AUTO_VELO.BindControl = Me.IO_VertAutoVelo
        Me.VER_AUTO_VELO.BindProperty = "Data"
        Me.VER_AUTO_VELO.Data = Nothing
        Me.VER_AUTO_VELO.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.VER_AUTO_VELO.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.VER_AUTO_VELO.VariableName = "MAIN.ProductHandling.MachParameters.[Position1].Vert_VelocityAuto"
        '
        'IO_VertAutoVelo
        '
        Me.IO_VertAutoVelo.Audit = Nothing
        Me.IO_VertAutoVelo.AuditEnabled = False
        Me.IO_VertAutoVelo.AuditMessage = "KremerIoField changed:"
        Me.IO_VertAutoVelo.AuditSource = "KremerIoField"
        Me.IO_VertAutoVelo.BackColor = System.Drawing.Color.White
        Me.IO_VertAutoVelo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_VertAutoVelo.Data = 0.0R
        Me.IO_VertAutoVelo.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_VertAutoVelo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_VertAutoVelo.InitialValue = True
        Me.IO_VertAutoVelo.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_VertAutoVelo.Location = New System.Drawing.Point(271, 63)
        Me.IO_VertAutoVelo.LowerBound = 0.0R
        Me.IO_VertAutoVelo.Name = "IO_VertAutoVelo"
        Me.IO_VertAutoVelo.OutputFormat = "0.0 mm/s"
        Me.IO_VertAutoVelo.Size = New System.Drawing.Size(100, 22)
        Me.IO_VertAutoVelo.TabIndex = 395
        Me.IO_VertAutoVelo.Text = "0.0 mm/s"
        Me.IO_VertAutoVelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_VertAutoVelo.UpperBound = 2000.0R
        Me.IO_VertAutoVelo.UserInfo = Nothing
        Me.IO_VertAutoVelo.UserLevel = 0
        '
        'VER_POS_TRANSPORT
        '
        Me.VER_POS_TRANSPORT.BindControl = Me.IO_VertTranspPos
        Me.VER_POS_TRANSPORT.BindProperty = "Data"
        Me.VER_POS_TRANSPORT.Data = Nothing
        Me.VER_POS_TRANSPORT.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.VER_POS_TRANSPORT.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.VER_POS_TRANSPORT.VariableName = "MAIN.ProductHandling.MachParameters.[Position1].Vert_PositionTransport"
        '
        'IO_VertTranspPos
        '
        Me.IO_VertTranspPos.Audit = Nothing
        Me.IO_VertTranspPos.AuditEnabled = False
        Me.IO_VertTranspPos.AuditMessage = "KremerIoField changed:"
        Me.IO_VertTranspPos.AuditSource = "KremerIoField"
        Me.IO_VertTranspPos.BackColor = System.Drawing.Color.White
        Me.IO_VertTranspPos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_VertTranspPos.Data = 0.0R
        Me.IO_VertTranspPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_VertTranspPos.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_VertTranspPos.InitialValue = True
        Me.IO_VertTranspPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_VertTranspPos.Location = New System.Drawing.Point(271, 87)
        Me.IO_VertTranspPos.LowerBound = 0.0R
        Me.IO_VertTranspPos.Name = "IO_VertTranspPos"
        Me.IO_VertTranspPos.OutputFormat = "0.0 mm"
        Me.IO_VertTranspPos.Size = New System.Drawing.Size(100, 22)
        Me.IO_VertTranspPos.TabIndex = 373
        Me.IO_VertTranspPos.Text = "0.0 mm"
        Me.IO_VertTranspPos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_VertTranspPos.UpperBound = 2000.0R
        Me.IO_VertTranspPos.UserInfo = Nothing
        Me.IO_VertTranspPos.UserLevel = 0
        '
        'VER_ACT_POS
        '
        Me.VER_ACT_POS.BindControl = Me.IO_VertActPos
        Me.VER_ACT_POS.BindProperty = "Data"
        Me.VER_ACT_POS.Data = Nothing
        Me.VER_ACT_POS.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.VER_ACT_POS.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.VER_ACT_POS.VariableName = "MAIN.ProductHandling.[Position1].VerticalAxis.ActPosition"
        '
        'IO_VertActPos
        '
        Me.IO_VertActPos.Audit = Nothing
        Me.IO_VertActPos.AuditEnabled = False
        Me.IO_VertActPos.AuditMessage = "KremerIoField changed:"
        Me.IO_VertActPos.AuditSource = "KremerIoField"
        Me.IO_VertActPos.Data = 0.0R
        Me.IO_VertActPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_VertActPos.InitialValue = True
        Me.IO_VertActPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_VertActPos.Location = New System.Drawing.Point(300, 15)
        Me.IO_VertActPos.LowerBound = 0.0R
        Me.IO_VertActPos.Name = "IO_VertActPos"
        Me.IO_VertActPos.OutputFormat = "0.0 mm"
        Me.IO_VertActPos.Size = New System.Drawing.Size(71, 21)
        Me.IO_VertActPos.TabIndex = 400
        Me.IO_VertActPos.Text = "0,0 mm"
        Me.IO_VertActPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IO_VertActPos.UpperBound = 1000.0R
        Me.IO_VertActPos.UserInfo = Nothing
        Me.IO_VertActPos.UserLevel = 0
        '
        'HOR_MAN_VELO
        '
        Me.HOR_MAN_VELO.BindControl = Me.IO_HorManualVelo
        Me.HOR_MAN_VELO.BindProperty = "Data"
        Me.HOR_MAN_VELO.Data = Nothing
        Me.HOR_MAN_VELO.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.HOR_MAN_VELO.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.HOR_MAN_VELO.VariableName = "MAIN.ProductHandling.MachParameters.[Position1].Hor_VelocityManual"
        '
        'IO_HorManualVelo
        '
        Me.IO_HorManualVelo.Audit = Nothing
        Me.IO_HorManualVelo.AuditEnabled = False
        Me.IO_HorManualVelo.AuditMessage = "KremerIoField changed:"
        Me.IO_HorManualVelo.AuditSource = "KremerIoField"
        Me.IO_HorManualVelo.BackColor = System.Drawing.Color.White
        Me.IO_HorManualVelo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_HorManualVelo.Data = 0.0R
        Me.IO_HorManualVelo.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_HorManualVelo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_HorManualVelo.InitialValue = True
        Me.IO_HorManualVelo.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_HorManualVelo.Location = New System.Drawing.Point(682, 39)
        Me.IO_HorManualVelo.LowerBound = 0.0R
        Me.IO_HorManualVelo.Name = "IO_HorManualVelo"
        Me.IO_HorManualVelo.OutputFormat = "0.0 mm/s"
        Me.IO_HorManualVelo.Size = New System.Drawing.Size(100, 22)
        Me.IO_HorManualVelo.TabIndex = 397
        Me.IO_HorManualVelo.Text = "0.0 mm/s"
        Me.IO_HorManualVelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_HorManualVelo.UpperBound = 2000.0R
        Me.IO_HorManualVelo.UserInfo = Nothing
        Me.IO_HorManualVelo.UserLevel = 0
        '
        'HOR_AUTO_VELO
        '
        Me.HOR_AUTO_VELO.BindControl = Me.IO_HorAutoVelo
        Me.HOR_AUTO_VELO.BindProperty = "Data"
        Me.HOR_AUTO_VELO.Data = Nothing
        Me.HOR_AUTO_VELO.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.HOR_AUTO_VELO.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.HOR_AUTO_VELO.VariableName = "MAIN.ProductHandling.MachParameters.[Position1].Hor_VelocityAuto"
        '
        'IO_HorAutoVelo
        '
        Me.IO_HorAutoVelo.Audit = Nothing
        Me.IO_HorAutoVelo.AuditEnabled = False
        Me.IO_HorAutoVelo.AuditMessage = "KremerIoField changed:"
        Me.IO_HorAutoVelo.AuditSource = "KremerIoField"
        Me.IO_HorAutoVelo.BackColor = System.Drawing.Color.White
        Me.IO_HorAutoVelo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_HorAutoVelo.Data = 0.0R
        Me.IO_HorAutoVelo.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_HorAutoVelo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_HorAutoVelo.InitialValue = True
        Me.IO_HorAutoVelo.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_HorAutoVelo.Location = New System.Drawing.Point(682, 63)
        Me.IO_HorAutoVelo.LowerBound = 0.0R
        Me.IO_HorAutoVelo.Name = "IO_HorAutoVelo"
        Me.IO_HorAutoVelo.OutputFormat = "0.0 mm/s"
        Me.IO_HorAutoVelo.Size = New System.Drawing.Size(100, 22)
        Me.IO_HorAutoVelo.TabIndex = 399
        Me.IO_HorAutoVelo.Text = "0.0 mm/s"
        Me.IO_HorAutoVelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_HorAutoVelo.UpperBound = 2000.0R
        Me.IO_HorAutoVelo.UserInfo = Nothing
        Me.IO_HorAutoVelo.UserLevel = 0
        '
        'HOR_PICKUP_POS
        '
        Me.HOR_PICKUP_POS.BindControl = Me.IO_PickUpPos
        Me.HOR_PICKUP_POS.BindProperty = "Data"
        Me.HOR_PICKUP_POS.Data = Nothing
        Me.HOR_PICKUP_POS.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.HOR_PICKUP_POS.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.HOR_PICKUP_POS.VariableName = "MAIN.ProductHandling.MachParameters.[Position1].PositionHorizontalPickup"
        '
        'IO_PickUpPos
        '
        Me.IO_PickUpPos.Audit = Nothing
        Me.IO_PickUpPos.AuditEnabled = False
        Me.IO_PickUpPos.AuditMessage = "KremerIoField changed:"
        Me.IO_PickUpPos.AuditSource = "KremerIoField"
        Me.IO_PickUpPos.BackColor = System.Drawing.Color.White
        Me.IO_PickUpPos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_PickUpPos.Data = 0.0R
        Me.IO_PickUpPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_PickUpPos.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_PickUpPos.InitialValue = True
        Me.IO_PickUpPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_PickUpPos.Location = New System.Drawing.Point(682, 88)
        Me.IO_PickUpPos.LowerBound = 0.0R
        Me.IO_PickUpPos.Name = "IO_PickUpPos"
        Me.IO_PickUpPos.OutputFormat = "0.0 mm"
        Me.IO_PickUpPos.Size = New System.Drawing.Size(100, 22)
        Me.IO_PickUpPos.TabIndex = 422
        Me.IO_PickUpPos.Text = "0.0 mm"
        Me.IO_PickUpPos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_PickUpPos.UpperBound = 4000.0R
        Me.IO_PickUpPos.UserInfo = Nothing
        Me.IO_PickUpPos.UserLevel = 0
        '
        'HOR_ACT_POS
        '
        Me.HOR_ACT_POS.BindControl = Me.IO_HorActPos
        Me.HOR_ACT_POS.BindProperty = "Data"
        Me.HOR_ACT_POS.Data = Nothing
        Me.HOR_ACT_POS.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.HOR_ACT_POS.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.HOR_ACT_POS.VariableName = "MAIN.ProductHandling.[Position1].HorizontalAxis.ActPosition"
        '
        'IO_HorActPos
        '
        Me.IO_HorActPos.Audit = Nothing
        Me.IO_HorActPos.AuditEnabled = False
        Me.IO_HorActPos.AuditMessage = "KremerIoField changed:"
        Me.IO_HorActPos.AuditSource = "KremerIoField"
        Me.IO_HorActPos.Data = 0.0R
        Me.IO_HorActPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_HorActPos.InitialValue = True
        Me.IO_HorActPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_HorActPos.Location = New System.Drawing.Point(711, 15)
        Me.IO_HorActPos.LowerBound = 0.0R
        Me.IO_HorActPos.Name = "IO_HorActPos"
        Me.IO_HorActPos.OutputFormat = "0.0 mm"
        Me.IO_HorActPos.Size = New System.Drawing.Size(71, 21)
        Me.IO_HorActPos.TabIndex = 401
        Me.IO_HorActPos.Text = "0,0 mm"
        Me.IO_HorActPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IO_HorActPos.UpperBound = 1000.0R
        Me.IO_HorActPos.UserInfo = Nothing
        Me.IO_HorActPos.UserLevel = 0
        '
        'HOR_DROP_POS
        '
        Me.HOR_DROP_POS.BindControl = Me.IO_DropOffpos
        Me.HOR_DROP_POS.BindProperty = "Data"
        Me.HOR_DROP_POS.Data = Nothing
        Me.HOR_DROP_POS.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.HOR_DROP_POS.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.HOR_DROP_POS.VariableName = "MAIN.ProductHandling.MachParameters.[Position1].PositionHorizontalDropOff"
        '
        'IO_DropOffpos
        '
        Me.IO_DropOffpos.Audit = Nothing
        Me.IO_DropOffpos.AuditEnabled = False
        Me.IO_DropOffpos.AuditMessage = "KremerIoField changed:"
        Me.IO_DropOffpos.AuditSource = "KremerIoField"
        Me.IO_DropOffpos.BackColor = System.Drawing.Color.White
        Me.IO_DropOffpos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_DropOffpos.Data = 0.0R
        Me.IO_DropOffpos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_DropOffpos.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_DropOffpos.InitialValue = True
        Me.IO_DropOffpos.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_DropOffpos.Location = New System.Drawing.Point(682, 112)
        Me.IO_DropOffpos.LowerBound = 0.0R
        Me.IO_DropOffpos.Name = "IO_DropOffpos"
        Me.IO_DropOffpos.OutputFormat = "0.0 mm"
        Me.IO_DropOffpos.Size = New System.Drawing.Size(100, 22)
        Me.IO_DropOffpos.TabIndex = 424
        Me.IO_DropOffpos.Text = "0.0 mm"
        Me.IO_DropOffpos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_DropOffpos.UpperBound = 4000.0R
        Me.IO_DropOffpos.UserInfo = Nothing
        Me.IO_DropOffpos.UserLevel = 0
        '
        'RestPositionOffset
        '
        Me.RestPositionOffset.BindControl = Me.IO_Vert_RestPosOffset
        Me.RestPositionOffset.BindProperty = "Data"
        Me.RestPositionOffset.Data = Nothing
        Me.RestPositionOffset.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.RestPositionOffset.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.RestPositionOffset.VariableName = "MAIN.ProductHandling.MachParameters.[Position1].Vert_PickUpRestPosOffset"
        '
        'IO_Vert_RestPosOffset
        '
        Me.IO_Vert_RestPosOffset.Audit = Nothing
        Me.IO_Vert_RestPosOffset.AuditEnabled = False
        Me.IO_Vert_RestPosOffset.AuditMessage = "KremerIoField changed:"
        Me.IO_Vert_RestPosOffset.AuditSource = "KremerIoField"
        Me.IO_Vert_RestPosOffset.BackColor = System.Drawing.Color.White
        Me.IO_Vert_RestPosOffset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_Vert_RestPosOffset.Data = 0.0R
        Me.IO_Vert_RestPosOffset.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_Vert_RestPosOffset.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_Vert_RestPosOffset.InitialValue = True
        Me.IO_Vert_RestPosOffset.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_Vert_RestPosOffset.Location = New System.Drawing.Point(271, 111)
        Me.IO_Vert_RestPosOffset.LowerBound = 0.0R
        Me.IO_Vert_RestPosOffset.Name = "IO_Vert_RestPosOffset"
        Me.IO_Vert_RestPosOffset.OutputFormat = "0.0 mm"
        Me.IO_Vert_RestPosOffset.Size = New System.Drawing.Size(100, 22)
        Me.IO_Vert_RestPosOffset.TabIndex = 426
        Me.IO_Vert_RestPosOffset.Text = "0.0 mm"
        Me.IO_Vert_RestPosOffset.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_Vert_RestPosOffset.UpperBound = 4000.0R
        Me.IO_Vert_RestPosOffset.UserInfo = Nothing
        Me.IO_Vert_RestPosOffset.UserLevel = 0
        '
        'PickupDownTime
        '
        Me.PickupDownTime.BindControl = Me.IO_GantryDownPickUp
        Me.PickupDownTime.BindProperty = "Data"
        Me.PickupDownTime.Data = Nothing
        Me.PickupDownTime.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.PickupDownTime.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PickupDownTime.VariableName = "MAIN.ProductHandling.MachParameters.[Position1].GantryPickupTime"
        '
        'IO_GantryDownPickUp
        '
        Me.IO_GantryDownPickUp.Audit = Nothing
        Me.IO_GantryDownPickUp.AuditEnabled = False
        Me.IO_GantryDownPickUp.AuditMessage = "KremerIoField changed:"
        Me.IO_GantryDownPickUp.AuditSource = "KremerIoField"
        Me.IO_GantryDownPickUp.BackColor = System.Drawing.Color.White
        Me.IO_GantryDownPickUp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_GantryDownPickUp.Data = 0.0R
        Me.IO_GantryDownPickUp.DataType = KremerControlsWin32.KremerIoField.NumDataType.INT
        Me.IO_GantryDownPickUp.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_GantryDownPickUp.InitialValue = True
        Me.IO_GantryDownPickUp.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_GantryDownPickUp.Location = New System.Drawing.Point(684, 188)
        Me.IO_GantryDownPickUp.LowerBound = 0.0R
        Me.IO_GantryDownPickUp.Name = "IO_GantryDownPickUp"
        Me.IO_GantryDownPickUp.OutputFormat = "0 ms"
        Me.IO_GantryDownPickUp.Size = New System.Drawing.Size(100, 22)
        Me.IO_GantryDownPickUp.TabIndex = 428
        Me.IO_GantryDownPickUp.Text = "0 ms"
        Me.IO_GantryDownPickUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_GantryDownPickUp.UpperBound = 4000.0R
        Me.IO_GantryDownPickUp.UserInfo = Nothing
        Me.IO_GantryDownPickUp.UserLevel = 0
        '
        'EN_VAC_1
        '
        Me.EN_VAC_1.BindControl = Me.Btn_Vac1
        Me.EN_VAC_1.BindProperty = "Data"
        Me.EN_VAC_1.Data = Nothing
        Me.EN_VAC_1.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.EN_VAC_1.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.EN_VAC_1.VariableName = "MAIN.ProductHandling.MachParameters.[Position1].EnableVacuumSection[1]"
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
        Me.Btn_Vac1.Location = New System.Drawing.Point(271, 196)
        Me.Btn_Vac1.Name = "Btn_Vac1"
        Me.Btn_Vac1.Size = New System.Drawing.Size(106, 36)
        Me.Btn_Vac1.State = False
        Me.Btn_Vac1.StateIsData = True
        Me.Btn_Vac1.StateText = New String() {Nothing, Nothing}
        Me.Btn_Vac1.TabIndex = 411
        Me.Btn_Vac1.Tag = "293"
        Me.Btn_Vac1.Text = "On"
        Me.Btn_Vac1.UserInfo = Nothing
        Me.Btn_Vac1.UserLevel = 0
        Me.Btn_Vac1.UseStateText = False
        '
        'EN_VAC_2
        '
        Me.EN_VAC_2.BindControl = Me.Btn_Vac2
        Me.EN_VAC_2.BindProperty = "Data"
        Me.EN_VAC_2.Data = Nothing
        Me.EN_VAC_2.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.EN_VAC_2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.EN_VAC_2.VariableName = "MAIN.ProductHandling.MachParameters.[Position1].EnableVacuumSection[2]"
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
        Me.Btn_Vac2.Location = New System.Drawing.Point(271, 233)
        Me.Btn_Vac2.Name = "Btn_Vac2"
        Me.Btn_Vac2.Size = New System.Drawing.Size(106, 36)
        Me.Btn_Vac2.State = False
        Me.Btn_Vac2.StateIsData = True
        Me.Btn_Vac2.StateText = New String() {Nothing, Nothing}
        Me.Btn_Vac2.TabIndex = 405
        Me.Btn_Vac2.Tag = "293"
        Me.Btn_Vac2.Text = "On"
        Me.Btn_Vac2.UserInfo = Nothing
        Me.Btn_Vac2.UserLevel = 0
        Me.Btn_Vac2.UseStateText = False
        '
        'EN_VAC_3
        '
        Me.EN_VAC_3.BindControl = Me.Btn_Vac3
        Me.EN_VAC_3.BindProperty = "Data"
        Me.EN_VAC_3.Data = Nothing
        Me.EN_VAC_3.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.EN_VAC_3.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.EN_VAC_3.VariableName = "MAIN.ProductHandling.MachParameters.[Position1].EnableVacuumSection[3]"
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
        Me.Btn_Vac3.Location = New System.Drawing.Point(271, 270)
        Me.Btn_Vac3.Name = "Btn_Vac3"
        Me.Btn_Vac3.Size = New System.Drawing.Size(106, 36)
        Me.Btn_Vac3.State = False
        Me.Btn_Vac3.StateIsData = True
        Me.Btn_Vac3.StateText = New String() {Nothing, Nothing}
        Me.Btn_Vac3.TabIndex = 407
        Me.Btn_Vac3.Tag = "293"
        Me.Btn_Vac3.Text = "On"
        Me.Btn_Vac3.UserInfo = Nothing
        Me.Btn_Vac3.UserLevel = 0
        Me.Btn_Vac3.UseStateText = False
        '
        'EN_VAC_4
        '
        Me.EN_VAC_4.BindControl = Me.Btn_Vac4
        Me.EN_VAC_4.BindProperty = "Data"
        Me.EN_VAC_4.Data = Nothing
        Me.EN_VAC_4.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.EN_VAC_4.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.EN_VAC_4.VariableName = "MAIN.ProductHandling.MachParameters.[Position1].EnableVacuumSection[4]"
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
        Me.Btn_Vac4.Location = New System.Drawing.Point(271, 307)
        Me.Btn_Vac4.Name = "Btn_Vac4"
        Me.Btn_Vac4.Size = New System.Drawing.Size(106, 36)
        Me.Btn_Vac4.State = False
        Me.Btn_Vac4.StateIsData = True
        Me.Btn_Vac4.StateText = New String() {Nothing, Nothing}
        Me.Btn_Vac4.TabIndex = 409
        Me.Btn_Vac4.Tag = "293"
        Me.Btn_Vac4.Text = "On"
        Me.Btn_Vac4.UserInfo = Nothing
        Me.Btn_Vac4.UserLevel = 0
        Me.Btn_Vac4.UseStateText = False
        '
        'EN_VAC_5
        '
        Me.EN_VAC_5.BindControl = Me.Btn_Vac5
        Me.EN_VAC_5.BindProperty = "Data"
        Me.EN_VAC_5.Data = Nothing
        Me.EN_VAC_5.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.EN_VAC_5.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.EN_VAC_5.VariableName = "MAIN.ProductHandling.MachParameters.[Position1].EnableVacuumSection[5]"
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
        Me.Btn_Vac5.Location = New System.Drawing.Point(271, 344)
        Me.Btn_Vac5.Name = "Btn_Vac5"
        Me.Btn_Vac5.Size = New System.Drawing.Size(106, 36)
        Me.Btn_Vac5.State = False
        Me.Btn_Vac5.StateIsData = True
        Me.Btn_Vac5.StateText = New String() {Nothing, Nothing}
        Me.Btn_Vac5.TabIndex = 412
        Me.Btn_Vac5.Tag = "293"
        Me.Btn_Vac5.Text = "On"
        Me.Btn_Vac5.UserInfo = Nothing
        Me.Btn_Vac5.UserLevel = 0
        Me.Btn_Vac5.UseStateText = False
        '
        'EN_VAC_6
        '
        Me.EN_VAC_6.BindControl = Me.Btn_Vac6
        Me.EN_VAC_6.BindProperty = "Data"
        Me.EN_VAC_6.Data = Nothing
        Me.EN_VAC_6.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.EN_VAC_6.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.EN_VAC_6.VariableName = "MAIN.ProductHandling.MachParameters.[Position1].EnableVacuumSection[6]"
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
        Me.Btn_Vac6.Location = New System.Drawing.Point(271, 381)
        Me.Btn_Vac6.Name = "Btn_Vac6"
        Me.Btn_Vac6.Size = New System.Drawing.Size(106, 36)
        Me.Btn_Vac6.State = False
        Me.Btn_Vac6.StateIsData = True
        Me.Btn_Vac6.StateText = New String() {Nothing, Nothing}
        Me.Btn_Vac6.TabIndex = 415
        Me.Btn_Vac6.Tag = "293"
        Me.Btn_Vac6.Text = "On"
        Me.Btn_Vac6.UserInfo = Nothing
        Me.Btn_Vac6.UserLevel = 0
        Me.Btn_Vac6.UseStateText = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(19, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 23)
        Me.Label2.TabIndex = 372
        Me.Label2.Tag = "85"
        Me.Label2.Text = "Vertical axis"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 23)
        Me.Label5.TabIndex = 376
        Me.Label5.Tag = "113"
        Me.Label5.Text = "Transport position"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.Location = New System.Drawing.Point(431, 10)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(273, 23)
        Me.Label21.TabIndex = 322
        Me.Label21.Tag = "84"
        Me.Label21.Text = "Horizontal axis"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(18, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(247, 23)
        Me.Label17.TabIndex = 394
        Me.Label17.Tag = "108"
        Me.Label17.Text = "Automatic velocity"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 23)
        Me.Label1.TabIndex = 392
        Me.Label1.Tag = "107"
        Me.Label1.Text = "Manual velocity"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(431, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 23)
        Me.Label3.TabIndex = 398
        Me.Label3.Tag = "108"
        Me.Label3.Text = "Automatic velocity"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(431, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 23)
        Me.Label4.TabIndex = 396
        Me.Label4.Tag = "107"
        Me.Label4.Text = "Manual velocity"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 388)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(243, 23)
        Me.Label7.TabIndex = 414
        Me.Label7.Tag = "487"
        Me.Label7.Text = "Vacuum section 6"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 350)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(243, 23)
        Me.Label8.TabIndex = 413
        Me.Label8.Tag = "486"
        Me.Label8.Text = "Vacuum section 5"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(22, 208)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(243, 23)
        Me.Label15.TabIndex = 410
        Me.Label15.Tag = "482"
        Me.Label15.Text = "Vacuum section 1"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(21, 314)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(243, 23)
        Me.Label14.TabIndex = 408
        Me.Label14.Tag = "485"
        Me.Label14.Text = "Vacuum section 4"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(22, 277)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(243, 23)
        Me.Label13.TabIndex = 406
        Me.Label13.Tag = "484"
        Me.Label13.Text = "Vacuum section 3"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(22, 240)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(243, 23)
        Me.Label12.TabIndex = 404
        Me.Label12.Tag = "483"
        Me.Label12.Text = "Vacuum section 2"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(429, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(247, 23)
        Me.Label11.TabIndex = 423
        Me.Label11.Tag = ""
        Me.Label11.Text = "Pickup \ rest position"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(429, 113)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(247, 23)
        Me.Label16.TabIndex = 425
        Me.Label16.Tag = ""
        Me.Label16.Text = "Drop off position"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(247, 23)
        Me.Label10.TabIndex = 427
        Me.Label10.Tag = ""
        Me.Label10.Text = "Rest position offset"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(431, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(247, 23)
        Me.Label9.TabIndex = 429
        Me.Label9.Tag = ""
        Me.Label9.Text = "Gantry pickup down time"
        '
        'Gantry_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.IO_GantryDownPickUp)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.IO_Vert_RestPosOffset)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.IO_DropOffpos)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.IO_PickUpPos)
        Me.Controls.Add(Me.Btn_Vac6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Btn_Vac5)
        Me.Controls.Add(Me.Btn_Vac1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Btn_Vac4)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Btn_Vac3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Btn_Vac2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.IO_HorActPos)
        Me.Controls.Add(Me.IO_VertActPos)
        Me.Controls.Add(Me.IO_HorAutoVelo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IO_HorManualVelo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.IO_VertAutoVelo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.IO_VertManualVelo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.IO_VertTranspPos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Controls.Add(Me.Btn_Manual)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Gantry_Settings"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "103"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_Manual As KremerControlsWin32.KremerButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents LineShape8 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape10 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape9 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents IO_VertTranspPos As KremerControlsWin32.KremerIoField
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents IO_VertAutoVelo As KremerControlsWin32.KremerIoField
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents IO_VertManualVelo As KremerControlsWin32.KremerIoField
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IO_HorAutoVelo As KremerControlsWin32.KremerIoField
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents IO_HorManualVelo As KremerControlsWin32.KremerIoField
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents IO_VertActPos As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_HorActPos As KremerControlsWin32.KremerIoField
    Friend WithEvents VER_MAN_VELO As KremerControlsWin32.KremerVariable
    Friend WithEvents VER_AUTO_VELO As KremerControlsWin32.KremerVariable
    Friend WithEvents VER_POS_TRANSPORT As KremerControlsWin32.KremerVariable
    Friend WithEvents HOR_MAN_VELO As KremerControlsWin32.KremerVariable
    Friend WithEvents HOR_AUTO_VELO As KremerControlsWin32.KremerVariable
    Friend WithEvents VER_ACT_POS As KremerControlsWin32.KremerVariable
    Friend WithEvents HOR_ACT_POS As KremerControlsWin32.KremerVariable
    Friend WithEvents EN_VAC_1 As KremerControlsWin32.KremerVariable
    Friend WithEvents EN_VAC_2 As KremerControlsWin32.KremerVariable
    Friend WithEvents EN_VAC_3 As KremerControlsWin32.KremerVariable
    Friend WithEvents EN_VAC_4 As KremerControlsWin32.KremerVariable
    Friend WithEvents EN_VAC_5 As KremerControlsWin32.KremerVariable
    Friend WithEvents EN_VAC_6 As KremerControlsWin32.KremerVariable
    Friend WithEvents Btn_Vac1 As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_Vac6 As KremerControlsWin32.KremerButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Btn_Vac5 As KremerControlsWin32.KremerButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Btn_Vac4 As KremerControlsWin32.KremerButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Btn_Vac3 As KremerControlsWin32.KremerButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Btn_Vac2 As KremerControlsWin32.KremerButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents mxAutoMode As KremerControlsWin32.KremerVariable
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents IO_PickUpPos As KremerControlsWin32.KremerIoField
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents IO_DropOffpos As KremerControlsWin32.KremerIoField
    Friend WithEvents HOR_PICKUP_POS As KremerControlsWin32.KremerVariable
    Friend WithEvents HOR_DROP_POS As KremerControlsWin32.KremerVariable
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents IO_Vert_RestPosOffset As KremerControlsWin32.KremerIoField
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents IO_GantryDownPickUp As KremerControlsWin32.KremerIoField
    Friend WithEvents RestPositionOffset As KremerControlsWin32.KremerVariable
    Friend WithEvents PickupDownTime As KremerControlsWin32.KremerVariable

End Class
