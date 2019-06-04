<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CT_Stacker
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
        Me.components = New System.ComponentModel.Container
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.ThrStopFrontAUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioThrStopFrontAUp = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ThrStopFrontADown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioThrStopFrontADown = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ThrStopRearAUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioThrStopRearAUp = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ThrStopRearADown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioThrStopRearADown = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ThrStopFrontBUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioThrStopFrontBUp = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ThrStopFrontBDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioThrStopFrontBDown = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ThrStopRearBUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioThrStopRearBUp = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ThrStopRearBDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioThrStopRearBDown = New KremerControlsWin32.KremerIoField(Me.components)
        Me.GridUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioGridUp = New KremerControlsWin32.KremerIoField(Me.components)
        Me.GridDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioGridDown = New KremerControlsWin32.KremerIoField(Me.components)
        Me.GridFingerFrontAOpen = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioGridFingerFrontAOpen = New KremerControlsWin32.KremerIoField(Me.components)
        Me.GridFingerFrontAClose = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioGridFingerFrontAClose = New KremerControlsWin32.KremerIoField(Me.components)
        Me.GridFingerRearAOpen = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioGridFingerRearAOpen = New KremerControlsWin32.KremerIoField(Me.components)
        Me.GridFingerRearAClose = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioGridFingerRearAClose = New KremerControlsWin32.KremerIoField(Me.components)
        Me.GridFingerFrontBOpen = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioGridFingerFrontBOpen = New KremerControlsWin32.KremerIoField(Me.components)
        Me.GridFingerFrontBClose = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioGridFingerFrontBClose = New KremerControlsWin32.KremerIoField(Me.components)
        Me.GridFingerRearBOpen = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioGridFingerRearBOpen = New KremerControlsWin32.KremerIoField(Me.components)
        Me.GridFingerRearBClose = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioGridFingerRearBClose = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Btn_Overview = New KremerControlsWin32.KremerButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.ThrStopFrontAUp)
        Me.VarCollector.Variables.Add(Me.ThrStopFrontADown)
        Me.VarCollector.Variables.Add(Me.ThrStopRearAUp)
        Me.VarCollector.Variables.Add(Me.ThrStopRearADown)
        Me.VarCollector.Variables.Add(Me.ThrStopFrontBUp)
        Me.VarCollector.Variables.Add(Me.ThrStopFrontBDown)
        Me.VarCollector.Variables.Add(Me.ThrStopRearBUp)
        Me.VarCollector.Variables.Add(Me.ThrStopRearBDown)
        Me.VarCollector.Variables.Add(Me.GridUp)
        Me.VarCollector.Variables.Add(Me.GridDown)
        Me.VarCollector.Variables.Add(Me.GridFingerFrontAOpen)
        Me.VarCollector.Variables.Add(Me.GridFingerFrontAClose)
        Me.VarCollector.Variables.Add(Me.GridFingerRearAOpen)
        Me.VarCollector.Variables.Add(Me.GridFingerRearAClose)
        Me.VarCollector.Variables.Add(Me.GridFingerFrontBOpen)
        Me.VarCollector.Variables.Add(Me.GridFingerFrontBClose)
        Me.VarCollector.Variables.Add(Me.GridFingerRearBOpen)
        Me.VarCollector.Variables.Add(Me.GridFingerRearBClose)
        '
        'ThrStopFrontAUp
        '
        Me.ThrStopFrontAUp.BindControl = Me.ioThrStopFrontAUp
        Me.ThrStopFrontAUp.BindProperty = "Data"
        Me.ThrStopFrontAUp.Data = Nothing
        Me.ThrStopFrontAUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.ThrStopFrontAUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ThrStopFrontAUp.VariableName = "InlineAutomation.Stacking.PickupHead.StopperFront_A.Check.LastTime_Cil_In"
        '
        'ioThrStopFrontAUp
        '
        Me.ioThrStopFrontAUp.Audit = Nothing
        Me.ioThrStopFrontAUp.AuditEnabled = False
        Me.ioThrStopFrontAUp.AuditMessage = "KremerIoField changed:"
        Me.ioThrStopFrontAUp.AuditSource = "KremerIoField"
        Me.ioThrStopFrontAUp.AutoSize = True
        Me.ioThrStopFrontAUp.Data = 0
        Me.ioThrStopFrontAUp.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioThrStopFrontAUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioThrStopFrontAUp.InitialValue = True
        Me.ioThrStopFrontAUp.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioThrStopFrontAUp.Location = New System.Drawing.Point(219, 43)
        Me.ioThrStopFrontAUp.LowerBound = 0
        Me.ioThrStopFrontAUp.Name = "ioThrStopFrontAUp"
        Me.ioThrStopFrontAUp.OutputFormat = "0 ms"
        Me.ioThrStopFrontAUp.Size = New System.Drawing.Size(41, 18)
        Me.ioThrStopFrontAUp.TabIndex = 395
        Me.ioThrStopFrontAUp.Text = "0 ms"
        Me.ioThrStopFrontAUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioThrStopFrontAUp.UpperBound = 1000
        Me.ioThrStopFrontAUp.UserInfo = Nothing
        Me.ioThrStopFrontAUp.UserLevel = 0
        '
        'ThrStopFrontADown
        '
        Me.ThrStopFrontADown.BindControl = Me.ioThrStopFrontADown
        Me.ThrStopFrontADown.BindProperty = "Data"
        Me.ThrStopFrontADown.Data = Nothing
        Me.ThrStopFrontADown.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.ThrStopFrontADown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ThrStopFrontADown.VariableName = "InlineAutomation.Stacking.PickupHead.StopperFront_A.Check.LastTime_Cil_Out"
        '
        'ioThrStopFrontADown
        '
        Me.ioThrStopFrontADown.Audit = Nothing
        Me.ioThrStopFrontADown.AuditEnabled = False
        Me.ioThrStopFrontADown.AuditMessage = "KremerIoField changed:"
        Me.ioThrStopFrontADown.AuditSource = "KremerIoField"
        Me.ioThrStopFrontADown.AutoSize = True
        Me.ioThrStopFrontADown.Data = 0
        Me.ioThrStopFrontADown.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioThrStopFrontADown.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioThrStopFrontADown.InitialValue = True
        Me.ioThrStopFrontADown.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioThrStopFrontADown.Location = New System.Drawing.Point(219, 68)
        Me.ioThrStopFrontADown.LowerBound = 0
        Me.ioThrStopFrontADown.Name = "ioThrStopFrontADown"
        Me.ioThrStopFrontADown.OutputFormat = "0 ms"
        Me.ioThrStopFrontADown.Size = New System.Drawing.Size(41, 18)
        Me.ioThrStopFrontADown.TabIndex = 396
        Me.ioThrStopFrontADown.Text = "0 ms"
        Me.ioThrStopFrontADown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioThrStopFrontADown.UpperBound = 1000
        Me.ioThrStopFrontADown.UserInfo = Nothing
        Me.ioThrStopFrontADown.UserLevel = 0
        '
        'ThrStopRearAUp
        '
        Me.ThrStopRearAUp.BindControl = Me.ioThrStopRearAUp
        Me.ThrStopRearAUp.BindProperty = "Data"
        Me.ThrStopRearAUp.Data = Nothing
        Me.ThrStopRearAUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.ThrStopRearAUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ThrStopRearAUp.VariableName = "InlineAutomation.Stacking.PickupHead.StopperRear_A.Check.LastTime_Cil_In"
        '
        'ioThrStopRearAUp
        '
        Me.ioThrStopRearAUp.Audit = Nothing
        Me.ioThrStopRearAUp.AuditEnabled = False
        Me.ioThrStopRearAUp.AuditMessage = "KremerIoField changed:"
        Me.ioThrStopRearAUp.AuditSource = "KremerIoField"
        Me.ioThrStopRearAUp.AutoSize = True
        Me.ioThrStopRearAUp.Data = 0
        Me.ioThrStopRearAUp.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioThrStopRearAUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioThrStopRearAUp.InitialValue = True
        Me.ioThrStopRearAUp.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioThrStopRearAUp.Location = New System.Drawing.Point(219, 93)
        Me.ioThrStopRearAUp.LowerBound = 0
        Me.ioThrStopRearAUp.Name = "ioThrStopRearAUp"
        Me.ioThrStopRearAUp.OutputFormat = "0 ms"
        Me.ioThrStopRearAUp.Size = New System.Drawing.Size(41, 18)
        Me.ioThrStopRearAUp.TabIndex = 397
        Me.ioThrStopRearAUp.Text = "0 ms"
        Me.ioThrStopRearAUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioThrStopRearAUp.UpperBound = 1000
        Me.ioThrStopRearAUp.UserInfo = Nothing
        Me.ioThrStopRearAUp.UserLevel = 0
        '
        'ThrStopRearADown
        '
        Me.ThrStopRearADown.BindControl = Me.ioThrStopRearADown
        Me.ThrStopRearADown.BindProperty = "Data"
        Me.ThrStopRearADown.Data = Nothing
        Me.ThrStopRearADown.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.ThrStopRearADown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ThrStopRearADown.VariableName = "InlineAutomation.Stacking.PickupHead.StopperRear_A.Check.LastTime_Cil_Out"
        '
        'ioThrStopRearADown
        '
        Me.ioThrStopRearADown.Audit = Nothing
        Me.ioThrStopRearADown.AuditEnabled = False
        Me.ioThrStopRearADown.AuditMessage = "KremerIoField changed:"
        Me.ioThrStopRearADown.AuditSource = "KremerIoField"
        Me.ioThrStopRearADown.AutoSize = True
        Me.ioThrStopRearADown.Data = 0
        Me.ioThrStopRearADown.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioThrStopRearADown.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioThrStopRearADown.InitialValue = True
        Me.ioThrStopRearADown.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioThrStopRearADown.Location = New System.Drawing.Point(219, 118)
        Me.ioThrStopRearADown.LowerBound = 0
        Me.ioThrStopRearADown.Name = "ioThrStopRearADown"
        Me.ioThrStopRearADown.OutputFormat = "0 ms"
        Me.ioThrStopRearADown.Size = New System.Drawing.Size(41, 18)
        Me.ioThrStopRearADown.TabIndex = 398
        Me.ioThrStopRearADown.Text = "0 ms"
        Me.ioThrStopRearADown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioThrStopRearADown.UpperBound = 1000
        Me.ioThrStopRearADown.UserInfo = Nothing
        Me.ioThrStopRearADown.UserLevel = 0
        '
        'ThrStopFrontBUp
        '
        Me.ThrStopFrontBUp.BindControl = Me.ioThrStopFrontBUp
        Me.ThrStopFrontBUp.BindProperty = "Data"
        Me.ThrStopFrontBUp.Data = Nothing
        Me.ThrStopFrontBUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.ThrStopFrontBUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ThrStopFrontBUp.VariableName = "InlineAutomation.Stacking.PickupHead.StopperFront_B.Check.LastTime_Cil_In"
        '
        'ioThrStopFrontBUp
        '
        Me.ioThrStopFrontBUp.Audit = Nothing
        Me.ioThrStopFrontBUp.AuditEnabled = False
        Me.ioThrStopFrontBUp.AuditMessage = "KremerIoField changed:"
        Me.ioThrStopFrontBUp.AuditSource = "KremerIoField"
        Me.ioThrStopFrontBUp.AutoSize = True
        Me.ioThrStopFrontBUp.Data = 0
        Me.ioThrStopFrontBUp.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioThrStopFrontBUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioThrStopFrontBUp.InitialValue = True
        Me.ioThrStopFrontBUp.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioThrStopFrontBUp.Location = New System.Drawing.Point(219, 143)
        Me.ioThrStopFrontBUp.LowerBound = 0
        Me.ioThrStopFrontBUp.Name = "ioThrStopFrontBUp"
        Me.ioThrStopFrontBUp.OutputFormat = "0 ms"
        Me.ioThrStopFrontBUp.Size = New System.Drawing.Size(41, 18)
        Me.ioThrStopFrontBUp.TabIndex = 399
        Me.ioThrStopFrontBUp.Text = "0 ms"
        Me.ioThrStopFrontBUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioThrStopFrontBUp.UpperBound = 1000
        Me.ioThrStopFrontBUp.UserInfo = Nothing
        Me.ioThrStopFrontBUp.UserLevel = 0
        '
        'ThrStopFrontBDown
        '
        Me.ThrStopFrontBDown.BindControl = Me.ioThrStopFrontBDown
        Me.ThrStopFrontBDown.BindProperty = "Data"
        Me.ThrStopFrontBDown.Data = Nothing
        Me.ThrStopFrontBDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.ThrStopFrontBDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ThrStopFrontBDown.VariableName = "InlineAutomation.Stacking.PickupHead.StopperFront_B.Check.LastTime_Cil_Out"
        '
        'ioThrStopFrontBDown
        '
        Me.ioThrStopFrontBDown.Audit = Nothing
        Me.ioThrStopFrontBDown.AuditEnabled = False
        Me.ioThrStopFrontBDown.AuditMessage = "KremerIoField changed:"
        Me.ioThrStopFrontBDown.AuditSource = "KremerIoField"
        Me.ioThrStopFrontBDown.AutoSize = True
        Me.ioThrStopFrontBDown.Data = 0
        Me.ioThrStopFrontBDown.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioThrStopFrontBDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioThrStopFrontBDown.InitialValue = True
        Me.ioThrStopFrontBDown.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioThrStopFrontBDown.Location = New System.Drawing.Point(219, 168)
        Me.ioThrStopFrontBDown.LowerBound = 0
        Me.ioThrStopFrontBDown.Name = "ioThrStopFrontBDown"
        Me.ioThrStopFrontBDown.OutputFormat = "0 ms"
        Me.ioThrStopFrontBDown.Size = New System.Drawing.Size(41, 18)
        Me.ioThrStopFrontBDown.TabIndex = 400
        Me.ioThrStopFrontBDown.Text = "0 ms"
        Me.ioThrStopFrontBDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioThrStopFrontBDown.UpperBound = 1000
        Me.ioThrStopFrontBDown.UserInfo = Nothing
        Me.ioThrStopFrontBDown.UserLevel = 0
        '
        'ThrStopRearBUp
        '
        Me.ThrStopRearBUp.BindControl = Me.ioThrStopRearBUp
        Me.ThrStopRearBUp.BindProperty = "Data"
        Me.ThrStopRearBUp.Data = Nothing
        Me.ThrStopRearBUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.ThrStopRearBUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ThrStopRearBUp.VariableName = "InlineAutomation.Stacking.PickupHead.StopperRear_B.Check.LastTime_Cil_In"
        '
        'ioThrStopRearBUp
        '
        Me.ioThrStopRearBUp.Audit = Nothing
        Me.ioThrStopRearBUp.AuditEnabled = False
        Me.ioThrStopRearBUp.AuditMessage = "KremerIoField changed:"
        Me.ioThrStopRearBUp.AuditSource = "KremerIoField"
        Me.ioThrStopRearBUp.AutoSize = True
        Me.ioThrStopRearBUp.Data = 0
        Me.ioThrStopRearBUp.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioThrStopRearBUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioThrStopRearBUp.InitialValue = True
        Me.ioThrStopRearBUp.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioThrStopRearBUp.Location = New System.Drawing.Point(219, 193)
        Me.ioThrStopRearBUp.LowerBound = 0
        Me.ioThrStopRearBUp.Name = "ioThrStopRearBUp"
        Me.ioThrStopRearBUp.OutputFormat = "0 ms"
        Me.ioThrStopRearBUp.Size = New System.Drawing.Size(41, 18)
        Me.ioThrStopRearBUp.TabIndex = 401
        Me.ioThrStopRearBUp.Text = "0 ms"
        Me.ioThrStopRearBUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioThrStopRearBUp.UpperBound = 1000
        Me.ioThrStopRearBUp.UserInfo = Nothing
        Me.ioThrStopRearBUp.UserLevel = 0
        '
        'ThrStopRearBDown
        '
        Me.ThrStopRearBDown.BindControl = Me.ioThrStopRearBDown
        Me.ThrStopRearBDown.BindProperty = "Data"
        Me.ThrStopRearBDown.Data = Nothing
        Me.ThrStopRearBDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.ThrStopRearBDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ThrStopRearBDown.VariableName = "InlineAutomation.Stacking.PickupHead.StopperRear_B.Check.LastTime_Cil_Out"
        '
        'ioThrStopRearBDown
        '
        Me.ioThrStopRearBDown.Audit = Nothing
        Me.ioThrStopRearBDown.AuditEnabled = False
        Me.ioThrStopRearBDown.AuditMessage = "KremerIoField changed:"
        Me.ioThrStopRearBDown.AuditSource = "KremerIoField"
        Me.ioThrStopRearBDown.AutoSize = True
        Me.ioThrStopRearBDown.Data = 0
        Me.ioThrStopRearBDown.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioThrStopRearBDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioThrStopRearBDown.InitialValue = True
        Me.ioThrStopRearBDown.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioThrStopRearBDown.Location = New System.Drawing.Point(219, 218)
        Me.ioThrStopRearBDown.LowerBound = 0
        Me.ioThrStopRearBDown.Name = "ioThrStopRearBDown"
        Me.ioThrStopRearBDown.OutputFormat = "0 ms"
        Me.ioThrStopRearBDown.Size = New System.Drawing.Size(41, 18)
        Me.ioThrStopRearBDown.TabIndex = 402
        Me.ioThrStopRearBDown.Text = "0 ms"
        Me.ioThrStopRearBDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioThrStopRearBDown.UpperBound = 1000
        Me.ioThrStopRearBDown.UserInfo = Nothing
        Me.ioThrStopRearBDown.UserLevel = 0
        '
        'GridUp
        '
        Me.GridUp.BindControl = Me.ioGridUp
        Me.GridUp.BindProperty = "Data"
        Me.GridUp.Data = Nothing
        Me.GridUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.GridUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GridUp.VariableName = "InlineAutomation.Stacking.StackingGrid.Cilinder.Check.LastTime_Cil_Out"
        '
        'ioGridUp
        '
        Me.ioGridUp.Audit = Nothing
        Me.ioGridUp.AuditEnabled = False
        Me.ioGridUp.AuditMessage = "KremerIoField changed:"
        Me.ioGridUp.AuditSource = "KremerIoField"
        Me.ioGridUp.AutoSize = True
        Me.ioGridUp.Data = 0
        Me.ioGridUp.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioGridUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioGridUp.InitialValue = True
        Me.ioGridUp.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioGridUp.Location = New System.Drawing.Point(473, 43)
        Me.ioGridUp.LowerBound = 0
        Me.ioGridUp.Name = "ioGridUp"
        Me.ioGridUp.OutputFormat = "0 ms"
        Me.ioGridUp.Size = New System.Drawing.Size(41, 18)
        Me.ioGridUp.TabIndex = 411
        Me.ioGridUp.Text = "0 ms"
        Me.ioGridUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioGridUp.UpperBound = 1000
        Me.ioGridUp.UserInfo = Nothing
        Me.ioGridUp.UserLevel = 0
        '
        'GridDown
        '
        Me.GridDown.BindControl = Me.ioGridDown
        Me.GridDown.BindProperty = "Data"
        Me.GridDown.Data = Nothing
        Me.GridDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.GridDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GridDown.VariableName = "InlineAutomation.Stacking.StackingGrid.Cilinder.Check.LastTime_Cil_In"
        '
        'ioGridDown
        '
        Me.ioGridDown.Audit = Nothing
        Me.ioGridDown.AuditEnabled = False
        Me.ioGridDown.AuditMessage = "KremerIoField changed:"
        Me.ioGridDown.AuditSource = "KremerIoField"
        Me.ioGridDown.AutoSize = True
        Me.ioGridDown.Data = 0
        Me.ioGridDown.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioGridDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioGridDown.InitialValue = True
        Me.ioGridDown.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioGridDown.Location = New System.Drawing.Point(473, 68)
        Me.ioGridDown.LowerBound = 0
        Me.ioGridDown.Name = "ioGridDown"
        Me.ioGridDown.OutputFormat = "0 ms"
        Me.ioGridDown.Size = New System.Drawing.Size(41, 18)
        Me.ioGridDown.TabIndex = 412
        Me.ioGridDown.Text = "0 ms"
        Me.ioGridDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioGridDown.UpperBound = 1000
        Me.ioGridDown.UserInfo = Nothing
        Me.ioGridDown.UserLevel = 0
        '
        'GridFingerFrontAOpen
        '
        Me.GridFingerFrontAOpen.BindControl = Me.ioGridFingerFrontAOpen
        Me.GridFingerFrontAOpen.BindProperty = "Data"
        Me.GridFingerFrontAOpen.Data = Nothing
        Me.GridFingerFrontAOpen.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.GridFingerFrontAOpen.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GridFingerFrontAOpen.VariableName = "InlineAutomation.Stacking.StackingGrid.Lift_A.GridFinger_Front.Check.LastTime_Cil" & _
            "_In"
        '
        'ioGridFingerFrontAOpen
        '
        Me.ioGridFingerFrontAOpen.Audit = Nothing
        Me.ioGridFingerFrontAOpen.AuditEnabled = False
        Me.ioGridFingerFrontAOpen.AuditMessage = "KremerIoField changed:"
        Me.ioGridFingerFrontAOpen.AuditSource = "KremerIoField"
        Me.ioGridFingerFrontAOpen.AutoSize = True
        Me.ioGridFingerFrontAOpen.Data = 0
        Me.ioGridFingerFrontAOpen.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioGridFingerFrontAOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioGridFingerFrontAOpen.InitialValue = True
        Me.ioGridFingerFrontAOpen.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioGridFingerFrontAOpen.Location = New System.Drawing.Point(473, 143)
        Me.ioGridFingerFrontAOpen.LowerBound = 0
        Me.ioGridFingerFrontAOpen.Name = "ioGridFingerFrontAOpen"
        Me.ioGridFingerFrontAOpen.OutputFormat = "0 ms"
        Me.ioGridFingerFrontAOpen.Size = New System.Drawing.Size(41, 18)
        Me.ioGridFingerFrontAOpen.TabIndex = 403
        Me.ioGridFingerFrontAOpen.Text = "0 ms"
        Me.ioGridFingerFrontAOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioGridFingerFrontAOpen.UpperBound = 1000
        Me.ioGridFingerFrontAOpen.UserInfo = Nothing
        Me.ioGridFingerFrontAOpen.UserLevel = 0
        '
        'GridFingerFrontAClose
        '
        Me.GridFingerFrontAClose.BindControl = Me.ioGridFingerFrontAClose
        Me.GridFingerFrontAClose.BindProperty = "Data"
        Me.GridFingerFrontAClose.Data = Nothing
        Me.GridFingerFrontAClose.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.GridFingerFrontAClose.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GridFingerFrontAClose.VariableName = "InlineAutomation.Stacking.StackingGrid.Lift_A.GridFinger_Front.Check.LastTime_Cil" & _
            "_Out"
        '
        'ioGridFingerFrontAClose
        '
        Me.ioGridFingerFrontAClose.Audit = Nothing
        Me.ioGridFingerFrontAClose.AuditEnabled = False
        Me.ioGridFingerFrontAClose.AuditMessage = "KremerIoField changed:"
        Me.ioGridFingerFrontAClose.AuditSource = "KremerIoField"
        Me.ioGridFingerFrontAClose.AutoSize = True
        Me.ioGridFingerFrontAClose.Data = 0
        Me.ioGridFingerFrontAClose.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioGridFingerFrontAClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioGridFingerFrontAClose.InitialValue = True
        Me.ioGridFingerFrontAClose.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioGridFingerFrontAClose.Location = New System.Drawing.Point(473, 168)
        Me.ioGridFingerFrontAClose.LowerBound = 0
        Me.ioGridFingerFrontAClose.Name = "ioGridFingerFrontAClose"
        Me.ioGridFingerFrontAClose.OutputFormat = "0 ms"
        Me.ioGridFingerFrontAClose.Size = New System.Drawing.Size(41, 18)
        Me.ioGridFingerFrontAClose.TabIndex = 404
        Me.ioGridFingerFrontAClose.Text = "0 ms"
        Me.ioGridFingerFrontAClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioGridFingerFrontAClose.UpperBound = 1000
        Me.ioGridFingerFrontAClose.UserInfo = Nothing
        Me.ioGridFingerFrontAClose.UserLevel = 0
        '
        'GridFingerRearAOpen
        '
        Me.GridFingerRearAOpen.BindControl = Me.ioGridFingerRearAOpen
        Me.GridFingerRearAOpen.BindProperty = "Data"
        Me.GridFingerRearAOpen.Data = Nothing
        Me.GridFingerRearAOpen.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.GridFingerRearAOpen.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GridFingerRearAOpen.VariableName = "InlineAutomation.Stacking.StackingGrid.Lift_A.GridFinger_Rear.Check.LastTime_Cil_" & _
            "In"
        '
        'ioGridFingerRearAOpen
        '
        Me.ioGridFingerRearAOpen.Audit = Nothing
        Me.ioGridFingerRearAOpen.AuditEnabled = False
        Me.ioGridFingerRearAOpen.AuditMessage = "KremerIoField changed:"
        Me.ioGridFingerRearAOpen.AuditSource = "KremerIoField"
        Me.ioGridFingerRearAOpen.AutoSize = True
        Me.ioGridFingerRearAOpen.Data = 0
        Me.ioGridFingerRearAOpen.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioGridFingerRearAOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioGridFingerRearAOpen.InitialValue = True
        Me.ioGridFingerRearAOpen.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioGridFingerRearAOpen.Location = New System.Drawing.Point(473, 193)
        Me.ioGridFingerRearAOpen.LowerBound = 0
        Me.ioGridFingerRearAOpen.Name = "ioGridFingerRearAOpen"
        Me.ioGridFingerRearAOpen.OutputFormat = "0 ms"
        Me.ioGridFingerRearAOpen.Size = New System.Drawing.Size(41, 18)
        Me.ioGridFingerRearAOpen.TabIndex = 405
        Me.ioGridFingerRearAOpen.Text = "0 ms"
        Me.ioGridFingerRearAOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioGridFingerRearAOpen.UpperBound = 1000
        Me.ioGridFingerRearAOpen.UserInfo = Nothing
        Me.ioGridFingerRearAOpen.UserLevel = 0
        '
        'GridFingerRearAClose
        '
        Me.GridFingerRearAClose.BindControl = Me.ioGridFingerRearAClose
        Me.GridFingerRearAClose.BindProperty = "Data"
        Me.GridFingerRearAClose.Data = Nothing
        Me.GridFingerRearAClose.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.GridFingerRearAClose.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GridFingerRearAClose.VariableName = "InlineAutomation.Stacking.StackingGrid.Lift_A.GridFinger_Rear.Check.LastTime_Cil_" & _
            "Out"
        '
        'ioGridFingerRearAClose
        '
        Me.ioGridFingerRearAClose.Audit = Nothing
        Me.ioGridFingerRearAClose.AuditEnabled = False
        Me.ioGridFingerRearAClose.AuditMessage = "KremerIoField changed:"
        Me.ioGridFingerRearAClose.AuditSource = "KremerIoField"
        Me.ioGridFingerRearAClose.AutoSize = True
        Me.ioGridFingerRearAClose.Data = 0
        Me.ioGridFingerRearAClose.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioGridFingerRearAClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioGridFingerRearAClose.InitialValue = True
        Me.ioGridFingerRearAClose.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioGridFingerRearAClose.Location = New System.Drawing.Point(473, 218)
        Me.ioGridFingerRearAClose.LowerBound = 0
        Me.ioGridFingerRearAClose.Name = "ioGridFingerRearAClose"
        Me.ioGridFingerRearAClose.OutputFormat = "0 ms"
        Me.ioGridFingerRearAClose.Size = New System.Drawing.Size(41, 18)
        Me.ioGridFingerRearAClose.TabIndex = 406
        Me.ioGridFingerRearAClose.Text = "0 ms"
        Me.ioGridFingerRearAClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioGridFingerRearAClose.UpperBound = 1000
        Me.ioGridFingerRearAClose.UserInfo = Nothing
        Me.ioGridFingerRearAClose.UserLevel = 0
        '
        'GridFingerFrontBOpen
        '
        Me.GridFingerFrontBOpen.BindControl = Me.ioGridFingerFrontBOpen
        Me.GridFingerFrontBOpen.BindProperty = "Data"
        Me.GridFingerFrontBOpen.Data = Nothing
        Me.GridFingerFrontBOpen.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.GridFingerFrontBOpen.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GridFingerFrontBOpen.VariableName = "InlineAutomation.Stacking.StackingGrid.Lift_B.GridFinger_Front.Check.LastTime_Cil" & _
            "_In"
        '
        'ioGridFingerFrontBOpen
        '
        Me.ioGridFingerFrontBOpen.Audit = Nothing
        Me.ioGridFingerFrontBOpen.AuditEnabled = False
        Me.ioGridFingerFrontBOpen.AuditMessage = "KremerIoField changed:"
        Me.ioGridFingerFrontBOpen.AuditSource = "KremerIoField"
        Me.ioGridFingerFrontBOpen.AutoSize = True
        Me.ioGridFingerFrontBOpen.Data = 0
        Me.ioGridFingerFrontBOpen.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioGridFingerFrontBOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioGridFingerFrontBOpen.InitialValue = True
        Me.ioGridFingerFrontBOpen.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioGridFingerFrontBOpen.Location = New System.Drawing.Point(736, 143)
        Me.ioGridFingerFrontBOpen.LowerBound = 0
        Me.ioGridFingerFrontBOpen.Name = "ioGridFingerFrontBOpen"
        Me.ioGridFingerFrontBOpen.OutputFormat = "0 ms"
        Me.ioGridFingerFrontBOpen.Size = New System.Drawing.Size(41, 18)
        Me.ioGridFingerFrontBOpen.TabIndex = 407
        Me.ioGridFingerFrontBOpen.Text = "0 ms"
        Me.ioGridFingerFrontBOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioGridFingerFrontBOpen.UpperBound = 1000
        Me.ioGridFingerFrontBOpen.UserInfo = Nothing
        Me.ioGridFingerFrontBOpen.UserLevel = 0
        '
        'GridFingerFrontBClose
        '
        Me.GridFingerFrontBClose.BindControl = Me.ioGridFingerFrontBClose
        Me.GridFingerFrontBClose.BindProperty = "Data"
        Me.GridFingerFrontBClose.Data = Nothing
        Me.GridFingerFrontBClose.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.GridFingerFrontBClose.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GridFingerFrontBClose.VariableName = "InlineAutomation.Stacking.StackingGrid.Lift_B.GridFinger_Front.Check.LastTime_Cil" & _
            "_Out"
        '
        'ioGridFingerFrontBClose
        '
        Me.ioGridFingerFrontBClose.Audit = Nothing
        Me.ioGridFingerFrontBClose.AuditEnabled = False
        Me.ioGridFingerFrontBClose.AuditMessage = "KremerIoField changed:"
        Me.ioGridFingerFrontBClose.AuditSource = "KremerIoField"
        Me.ioGridFingerFrontBClose.AutoSize = True
        Me.ioGridFingerFrontBClose.Data = 0
        Me.ioGridFingerFrontBClose.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioGridFingerFrontBClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioGridFingerFrontBClose.InitialValue = True
        Me.ioGridFingerFrontBClose.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioGridFingerFrontBClose.Location = New System.Drawing.Point(736, 168)
        Me.ioGridFingerFrontBClose.LowerBound = 0
        Me.ioGridFingerFrontBClose.Name = "ioGridFingerFrontBClose"
        Me.ioGridFingerFrontBClose.OutputFormat = "0 ms"
        Me.ioGridFingerFrontBClose.Size = New System.Drawing.Size(41, 18)
        Me.ioGridFingerFrontBClose.TabIndex = 408
        Me.ioGridFingerFrontBClose.Text = "0 ms"
        Me.ioGridFingerFrontBClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioGridFingerFrontBClose.UpperBound = 1000
        Me.ioGridFingerFrontBClose.UserInfo = Nothing
        Me.ioGridFingerFrontBClose.UserLevel = 0
        '
        'GridFingerRearBOpen
        '
        Me.GridFingerRearBOpen.BindControl = Me.ioGridFingerRearBOpen
        Me.GridFingerRearBOpen.BindProperty = "Data"
        Me.GridFingerRearBOpen.Data = Nothing
        Me.GridFingerRearBOpen.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.GridFingerRearBOpen.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GridFingerRearBOpen.VariableName = "InlineAutomation.Stacking.StackingGrid.Lift_B.GridFinger_Rear.Check.LastTime_Cil_" & _
            "In"
        '
        'ioGridFingerRearBOpen
        '
        Me.ioGridFingerRearBOpen.Audit = Nothing
        Me.ioGridFingerRearBOpen.AuditEnabled = False
        Me.ioGridFingerRearBOpen.AuditMessage = "KremerIoField changed:"
        Me.ioGridFingerRearBOpen.AuditSource = "KremerIoField"
        Me.ioGridFingerRearBOpen.AutoSize = True
        Me.ioGridFingerRearBOpen.Data = 0
        Me.ioGridFingerRearBOpen.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioGridFingerRearBOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioGridFingerRearBOpen.InitialValue = True
        Me.ioGridFingerRearBOpen.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioGridFingerRearBOpen.Location = New System.Drawing.Point(736, 193)
        Me.ioGridFingerRearBOpen.LowerBound = 0
        Me.ioGridFingerRearBOpen.Name = "ioGridFingerRearBOpen"
        Me.ioGridFingerRearBOpen.OutputFormat = "0 ms"
        Me.ioGridFingerRearBOpen.Size = New System.Drawing.Size(41, 18)
        Me.ioGridFingerRearBOpen.TabIndex = 409
        Me.ioGridFingerRearBOpen.Text = "0 ms"
        Me.ioGridFingerRearBOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioGridFingerRearBOpen.UpperBound = 1000
        Me.ioGridFingerRearBOpen.UserInfo = Nothing
        Me.ioGridFingerRearBOpen.UserLevel = 0
        '
        'GridFingerRearBClose
        '
        Me.GridFingerRearBClose.BindControl = Me.ioGridFingerRearBClose
        Me.GridFingerRearBClose.BindProperty = "Data"
        Me.GridFingerRearBClose.Data = Nothing
        Me.GridFingerRearBClose.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.GridFingerRearBClose.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GridFingerRearBClose.VariableName = "InlineAutomation.Stacking.StackingGrid.Lift_B.GridFinger_Rear.Check.LastTime_Cil_" & _
            "Out"
        '
        'ioGridFingerRearBClose
        '
        Me.ioGridFingerRearBClose.Audit = Nothing
        Me.ioGridFingerRearBClose.AuditEnabled = False
        Me.ioGridFingerRearBClose.AuditMessage = "KremerIoField changed:"
        Me.ioGridFingerRearBClose.AuditSource = "KremerIoField"
        Me.ioGridFingerRearBClose.AutoSize = True
        Me.ioGridFingerRearBClose.Data = 0
        Me.ioGridFingerRearBClose.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioGridFingerRearBClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioGridFingerRearBClose.InitialValue = True
        Me.ioGridFingerRearBClose.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioGridFingerRearBClose.Location = New System.Drawing.Point(736, 218)
        Me.ioGridFingerRearBClose.LowerBound = 0
        Me.ioGridFingerRearBClose.Name = "ioGridFingerRearBClose"
        Me.ioGridFingerRearBClose.OutputFormat = "0 ms"
        Me.ioGridFingerRearBClose.Size = New System.Drawing.Size(41, 18)
        Me.ioGridFingerRearBClose.TabIndex = 410
        Me.ioGridFingerRearBClose.Text = "0 ms"
        Me.ioGridFingerRearBClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioGridFingerRearBClose.UpperBound = 1000
        Me.ioGridFingerRearBClose.UserInfo = Nothing
        Me.ioGridFingerRearBClose.UserLevel = 0
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
        Me.Btn_Overview.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Overview.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_Overview.Location = New System.Drawing.Point(684, 382)
        Me.Btn_Overview.Name = "Btn_Overview"
        Me.Btn_Overview.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Overview.State = False
        Me.Btn_Overview.StateIsData = True
        Me.Btn_Overview.StateText = New String() {Nothing, Nothing}
        Me.Btn_Overview.TabIndex = 5
        Me.Btn_Overview.Tag = "194"
        Me.Btn_Overview.Text = "Overview"
        Me.Btn_Overview.UserInfo = Nothing
        Me.Btn_Overview.UserLevel = 0
        Me.Btn_Overview.UseStateText = False
        Me.Btn_Overview.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(279, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 25)
        Me.Label6.TabIndex = 296
        Me.Label6.Tag = ""
        Me.Label6.Text = "Gridfinger Front Open"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(279, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 25)
        Me.Label7.TabIndex = 298
        Me.Label7.Tag = ""
        Me.Label7.Text = "Gridfinger Front Close"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(279, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(178, 25)
        Me.Label8.TabIndex = 302
        Me.Label8.Tag = ""
        Me.Label8.Text = "Gridfinger Rear Close"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(279, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(178, 25)
        Me.Label9.TabIndex = 300
        Me.Label9.Tag = ""
        Me.Label9.Text = "Gridfinger Rear Open"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(11, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(183, 25)
        Me.Label14.TabIndex = 312
        Me.Label14.Tag = ""
        Me.Label14.Text = "Stopper Front A Up"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(11, 65)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(183, 25)
        Me.Label15.TabIndex = 314
        Me.Label15.Tag = ""
        Me.Label15.Text = "Stopper Front A Down"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(546, 112)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(231, 25)
        Me.Label27.TabIndex = 337
        Me.Label27.Tag = ""
        Me.Label27.Text = "Infeed Lift B"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(279, 112)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(231, 25)
        Me.Label28.TabIndex = 338
        Me.Label28.Tag = ""
        Me.Label28.Text = "Infeed Lift A"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(11, 10)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(231, 25)
        Me.Label30.TabIndex = 340
        Me.Label30.Tag = ""
        Me.Label30.Text = "Througfeed Stoppers"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(12, 165)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(183, 25)
        Me.Label33.TabIndex = 348
        Me.Label33.Tag = ""
        Me.Label33.Text = "Stopper Front B Down"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(12, 140)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(183, 25)
        Me.Label34.TabIndex = 346
        Me.Label34.Tag = ""
        Me.Label34.Text = "Stopper Front B Up"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(546, 215)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(178, 25)
        Me.Label10.TabIndex = 362
        Me.Label10.Tag = ""
        Me.Label10.Text = "Gridfinger Rear Close"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(546, 190)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(178, 25)
        Me.Label11.TabIndex = 360
        Me.Label11.Tag = ""
        Me.Label11.Text = "Gridfinger Rear Open"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(546, 165)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(178, 25)
        Me.Label12.TabIndex = 358
        Me.Label12.Tag = ""
        Me.Label12.Text = "Gridfinger Front Close"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(546, 140)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(178, 25)
        Me.Label13.TabIndex = 356
        Me.Label13.Tag = ""
        Me.Label13.Text = "Gridfinger Front Open"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(279, 65)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(178, 25)
        Me.Label19.TabIndex = 371
        Me.Label19.Tag = ""
        Me.Label19.Text = "Grid Is Down"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(279, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(178, 25)
        Me.Label20.TabIndex = 369
        Me.Label20.Tag = ""
        Me.Label20.Text = "Grid Is Up"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(279, 10)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(231, 25)
        Me.Label21.TabIndex = 367
        Me.Label21.Tag = ""
        Me.Label21.Text = "Stacking Grid"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(12, 115)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(183, 25)
        Me.Label25.TabIndex = 377
        Me.Label25.Tag = ""
        Me.Label25.Text = "Stopper Rear A Down"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(12, 90)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(183, 25)
        Me.Label26.TabIndex = 375
        Me.Label26.Tag = ""
        Me.Label26.Text = "Stopper Rear A Up"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(11, 215)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(183, 25)
        Me.Label35.TabIndex = 381
        Me.Label35.Tag = ""
        Me.Label35.Text = "Stopper Rear B Down"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(11, 190)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(183, 25)
        Me.Label36.TabIndex = 379
        Me.Label36.Tag = ""
        Me.Label36.Text = "Stopper Rear B Up"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CT_Stacker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ioGridDown)
        Me.Controls.Add(Me.ioGridUp)
        Me.Controls.Add(Me.ioGridFingerRearBClose)
        Me.Controls.Add(Me.ioGridFingerRearBOpen)
        Me.Controls.Add(Me.ioGridFingerFrontBClose)
        Me.Controls.Add(Me.ioGridFingerFrontBOpen)
        Me.Controls.Add(Me.ioGridFingerRearAClose)
        Me.Controls.Add(Me.ioGridFingerRearAOpen)
        Me.Controls.Add(Me.ioGridFingerFrontAClose)
        Me.Controls.Add(Me.ioGridFingerFrontAOpen)
        Me.Controls.Add(Me.ioThrStopRearBDown)
        Me.Controls.Add(Me.ioThrStopRearBUp)
        Me.Controls.Add(Me.ioThrStopFrontBDown)
        Me.Controls.Add(Me.ioThrStopFrontBUp)
        Me.Controls.Add(Me.ioThrStopRearADown)
        Me.Controls.Add(Me.ioThrStopRearAUp)
        Me.Controls.Add(Me.ioThrStopFrontADown)
        Me.Controls.Add(Me.ioThrStopFrontAUp)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Name = "CT_Stacker"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "557"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents ThrStopFrontAUp As KremerControlsWin32.KremerVariable
    Friend WithEvents ThrStopFrontADown As KremerControlsWin32.KremerVariable
    Friend WithEvents ThrStopRearAUp As KremerControlsWin32.KremerVariable
    Friend WithEvents ThrStopRearADown As KremerControlsWin32.KremerVariable
    Friend WithEvents ThrStopFrontBUp As KremerControlsWin32.KremerVariable
    Friend WithEvents ThrStopFrontBDown As KremerControlsWin32.KremerVariable
    Friend WithEvents ThrStopRearBUp As KremerControlsWin32.KremerVariable
    Friend WithEvents ThrStopRearBDown As KremerControlsWin32.KremerVariable
    Friend WithEvents GridUp As KremerControlsWin32.KremerVariable
    Friend WithEvents GridDown As KremerControlsWin32.KremerVariable
    Friend WithEvents GridFingerFrontAOpen As KremerControlsWin32.KremerVariable
    Friend WithEvents GridFingerFrontAClose As KremerControlsWin32.KremerVariable
    Friend WithEvents GridFingerRearAOpen As KremerControlsWin32.KremerVariable
    Friend WithEvents GridFingerRearAClose As KremerControlsWin32.KremerVariable
    Friend WithEvents GridFingerFrontBOpen As KremerControlsWin32.KremerVariable
    Friend WithEvents GridFingerFrontBClose As KremerControlsWin32.KremerVariable
    Friend WithEvents GridFingerRearBOpen As KremerControlsWin32.KremerVariable
    Friend WithEvents GridFingerRearBClose As KremerControlsWin32.KremerVariable
    Friend WithEvents ioThrStopFrontAUp As KremerControlsWin32.KremerIoField
    Friend WithEvents ioThrStopFrontADown As KremerControlsWin32.KremerIoField
    Friend WithEvents ioThrStopRearADown As KremerControlsWin32.KremerIoField
    Friend WithEvents ioThrStopRearAUp As KremerControlsWin32.KremerIoField
    Friend WithEvents ioThrStopRearBDown As KremerControlsWin32.KremerIoField
    Friend WithEvents ioThrStopRearBUp As KremerControlsWin32.KremerIoField
    Friend WithEvents ioThrStopFrontBDown As KremerControlsWin32.KremerIoField
    Friend WithEvents ioThrStopFrontBUp As KremerControlsWin32.KremerIoField
    Friend WithEvents ioGridFingerRearAClose As KremerControlsWin32.KremerIoField
    Friend WithEvents ioGridFingerRearAOpen As KremerControlsWin32.KremerIoField
    Friend WithEvents ioGridFingerFrontAClose As KremerControlsWin32.KremerIoField
    Friend WithEvents ioGridFingerFrontAOpen As KremerControlsWin32.KremerIoField
    Friend WithEvents ioGridFingerRearBClose As KremerControlsWin32.KremerIoField
    Friend WithEvents ioGridFingerRearBOpen As KremerControlsWin32.KremerIoField
    Friend WithEvents ioGridFingerFrontBClose As KremerControlsWin32.KremerIoField
    Friend WithEvents ioGridFingerFrontBOpen As KremerControlsWin32.KremerIoField
    Friend WithEvents ioGridDown As KremerControlsWin32.KremerIoField
    Friend WithEvents ioGridUp As KremerControlsWin32.KremerIoField

End Class
