<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CT_VDenester
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
        Me.BundleClampInfeedOn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioBundleClampInfeedOn = New KremerControlsWin32.KremerIoField(Me.components)
        Me.BundleClampInfeedOff = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioBundleClampInfeedOff = New KremerControlsWin32.KremerIoField(Me.components)
        Me.BundleClampOutfeedOn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioBundleClampOutfeedOn = New KremerControlsWin32.KremerIoField(Me.components)
        Me.BundleClampOutfeedOff = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioBundleClampOutfeedOff = New KremerControlsWin32.KremerIoField(Me.components)
        Me.SeparatorOn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioSeparatorOn = New KremerControlsWin32.KremerIoField(Me.components)
        Me.SeparatorOff = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioSeparatorOff = New KremerControlsWin32.KremerIoField(Me.components)
        Me.NeedlesInfeedOn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioNeedlesInfeedOn = New KremerControlsWin32.KremerIoField(Me.components)
        Me.NeedlesInfeedOff = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioNeedlesInfeedOff = New KremerControlsWin32.KremerIoField(Me.components)
        Me.NeedlesOutfeedOn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioNeedlesOutfeedOn = New KremerControlsWin32.KremerIoField(Me.components)
        Me.NeedlesOutfeedOff = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioNeedlesOutfeedOff = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Btn_Overview = New KremerControlsWin32.KremerButton
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.BundleClampInfeedOn)
        Me.VarCollector.Variables.Add(Me.BundleClampInfeedOff)
        Me.VarCollector.Variables.Add(Me.BundleClampOutfeedOn)
        Me.VarCollector.Variables.Add(Me.BundleClampOutfeedOff)
        Me.VarCollector.Variables.Add(Me.SeparatorOn)
        Me.VarCollector.Variables.Add(Me.SeparatorOff)
        Me.VarCollector.Variables.Add(Me.NeedlesInfeedOn)
        Me.VarCollector.Variables.Add(Me.NeedlesInfeedOff)
        Me.VarCollector.Variables.Add(Me.NeedlesOutfeedOn)
        Me.VarCollector.Variables.Add(Me.NeedlesOutfeedOff)
        '
        'BundleClampInfeedOn
        '
        Me.BundleClampInfeedOn.BindControl = Me.ioBundleClampInfeedOn
        Me.BundleClampInfeedOn.BindProperty = "Data"
        Me.BundleClampInfeedOn.Data = Nothing
        Me.BundleClampInfeedOn.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.BundleClampInfeedOn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BundleClampInfeedOn.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.BundleStorage.BundleClampLower_L." & _
            "Check.LastTime_Cil_Out"
        '
        'ioBundleClampInfeedOn
        '
        Me.ioBundleClampInfeedOn.Audit = Nothing
        Me.ioBundleClampInfeedOn.AuditEnabled = False
        Me.ioBundleClampInfeedOn.AuditMessage = "KremerIoField changed:"
        Me.ioBundleClampInfeedOn.AuditSource = "KremerIoField"
        Me.ioBundleClampInfeedOn.AutoSize = True
        Me.ioBundleClampInfeedOn.Data = 0
        Me.ioBundleClampInfeedOn.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioBundleClampInfeedOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioBundleClampInfeedOn.InitialValue = True
        Me.ioBundleClampInfeedOn.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioBundleClampInfeedOn.Location = New System.Drawing.Point(227, 40)
        Me.ioBundleClampInfeedOn.LowerBound = 0
        Me.ioBundleClampInfeedOn.Name = "ioBundleClampInfeedOn"
        Me.ioBundleClampInfeedOn.OutputFormat = "0 ms"
        Me.ioBundleClampInfeedOn.Size = New System.Drawing.Size(41, 18)
        Me.ioBundleClampInfeedOn.TabIndex = 394
        Me.ioBundleClampInfeedOn.Text = "0 ms"
        Me.ioBundleClampInfeedOn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioBundleClampInfeedOn.UpperBound = 1000
        Me.ioBundleClampInfeedOn.UserInfo = Nothing
        Me.ioBundleClampInfeedOn.UserLevel = 0
        '
        'BundleClampInfeedOff
        '
        Me.BundleClampInfeedOff.BindControl = Me.ioBundleClampInfeedOff
        Me.BundleClampInfeedOff.BindProperty = "Data"
        Me.BundleClampInfeedOff.Data = Nothing
        Me.BundleClampInfeedOff.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.BundleClampInfeedOff.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BundleClampInfeedOff.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.BundleStorage.BundleClampLower_L." & _
            "Check.LastTime_Cil_In"
        '
        'ioBundleClampInfeedOff
        '
        Me.ioBundleClampInfeedOff.Audit = Nothing
        Me.ioBundleClampInfeedOff.AuditEnabled = False
        Me.ioBundleClampInfeedOff.AuditMessage = "KremerIoField changed:"
        Me.ioBundleClampInfeedOff.AuditSource = "KremerIoField"
        Me.ioBundleClampInfeedOff.AutoSize = True
        Me.ioBundleClampInfeedOff.Data = 0
        Me.ioBundleClampInfeedOff.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioBundleClampInfeedOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioBundleClampInfeedOff.InitialValue = True
        Me.ioBundleClampInfeedOff.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioBundleClampInfeedOff.Location = New System.Drawing.Point(227, 65)
        Me.ioBundleClampInfeedOff.LowerBound = 0
        Me.ioBundleClampInfeedOff.Name = "ioBundleClampInfeedOff"
        Me.ioBundleClampInfeedOff.OutputFormat = "0 ms"
        Me.ioBundleClampInfeedOff.Size = New System.Drawing.Size(41, 18)
        Me.ioBundleClampInfeedOff.TabIndex = 395
        Me.ioBundleClampInfeedOff.Text = "0 ms"
        Me.ioBundleClampInfeedOff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioBundleClampInfeedOff.UpperBound = 1000
        Me.ioBundleClampInfeedOff.UserInfo = Nothing
        Me.ioBundleClampInfeedOff.UserLevel = 0
        '
        'BundleClampOutfeedOn
        '
        Me.BundleClampOutfeedOn.BindControl = Me.ioBundleClampOutfeedOn
        Me.BundleClampOutfeedOn.BindProperty = "Data"
        Me.BundleClampOutfeedOn.Data = Nothing
        Me.BundleClampOutfeedOn.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.BundleClampOutfeedOn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BundleClampOutfeedOn.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.BundleStorage.BundleClampLower_R." & _
            "Check.LastTime_Cil_Out"
        '
        'ioBundleClampOutfeedOn
        '
        Me.ioBundleClampOutfeedOn.Audit = Nothing
        Me.ioBundleClampOutfeedOn.AuditEnabled = False
        Me.ioBundleClampOutfeedOn.AuditMessage = "KremerIoField changed:"
        Me.ioBundleClampOutfeedOn.AuditSource = "KremerIoField"
        Me.ioBundleClampOutfeedOn.AutoSize = True
        Me.ioBundleClampOutfeedOn.Data = 0
        Me.ioBundleClampOutfeedOn.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioBundleClampOutfeedOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioBundleClampOutfeedOn.InitialValue = True
        Me.ioBundleClampOutfeedOn.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioBundleClampOutfeedOn.Location = New System.Drawing.Point(227, 90)
        Me.ioBundleClampOutfeedOn.LowerBound = 0
        Me.ioBundleClampOutfeedOn.Name = "ioBundleClampOutfeedOn"
        Me.ioBundleClampOutfeedOn.OutputFormat = "0 ms"
        Me.ioBundleClampOutfeedOn.Size = New System.Drawing.Size(41, 18)
        Me.ioBundleClampOutfeedOn.TabIndex = 396
        Me.ioBundleClampOutfeedOn.Text = "0 ms"
        Me.ioBundleClampOutfeedOn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioBundleClampOutfeedOn.UpperBound = 1000
        Me.ioBundleClampOutfeedOn.UserInfo = Nothing
        Me.ioBundleClampOutfeedOn.UserLevel = 0
        '
        'BundleClampOutfeedOff
        '
        Me.BundleClampOutfeedOff.BindControl = Me.ioBundleClampOutfeedOff
        Me.BundleClampOutfeedOff.BindProperty = "Data"
        Me.BundleClampOutfeedOff.Data = Nothing
        Me.BundleClampOutfeedOff.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.BundleClampOutfeedOff.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BundleClampOutfeedOff.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.BundleStorage.BundleClampLower_R." & _
            "Check.LastTime_Cil_In"
        '
        'ioBundleClampOutfeedOff
        '
        Me.ioBundleClampOutfeedOff.Audit = Nothing
        Me.ioBundleClampOutfeedOff.AuditEnabled = False
        Me.ioBundleClampOutfeedOff.AuditMessage = "KremerIoField changed:"
        Me.ioBundleClampOutfeedOff.AuditSource = "KremerIoField"
        Me.ioBundleClampOutfeedOff.AutoSize = True
        Me.ioBundleClampOutfeedOff.Data = 0
        Me.ioBundleClampOutfeedOff.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioBundleClampOutfeedOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioBundleClampOutfeedOff.InitialValue = True
        Me.ioBundleClampOutfeedOff.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioBundleClampOutfeedOff.Location = New System.Drawing.Point(227, 115)
        Me.ioBundleClampOutfeedOff.LowerBound = 0
        Me.ioBundleClampOutfeedOff.Name = "ioBundleClampOutfeedOff"
        Me.ioBundleClampOutfeedOff.OutputFormat = "0 ms"
        Me.ioBundleClampOutfeedOff.Size = New System.Drawing.Size(41, 18)
        Me.ioBundleClampOutfeedOff.TabIndex = 397
        Me.ioBundleClampOutfeedOff.Text = "0 ms"
        Me.ioBundleClampOutfeedOff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioBundleClampOutfeedOff.UpperBound = 1000
        Me.ioBundleClampOutfeedOff.UserInfo = Nothing
        Me.ioBundleClampOutfeedOff.UserLevel = 0
        '
        'SeparatorOn
        '
        Me.SeparatorOn.BindControl = Me.ioSeparatorOn
        Me.SeparatorOn.BindProperty = "Data"
        Me.SeparatorOn.Data = Nothing
        Me.SeparatorOn.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.SeparatorOn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SeparatorOn.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.BundleStorage.Separator.Check.Las" & _
            "tTime_Cil_Out"
        '
        'ioSeparatorOn
        '
        Me.ioSeparatorOn.Audit = Nothing
        Me.ioSeparatorOn.AuditEnabled = False
        Me.ioSeparatorOn.AuditMessage = "KremerIoField changed:"
        Me.ioSeparatorOn.AuditSource = "KremerIoField"
        Me.ioSeparatorOn.AutoSize = True
        Me.ioSeparatorOn.Data = 0
        Me.ioSeparatorOn.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioSeparatorOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioSeparatorOn.InitialValue = True
        Me.ioSeparatorOn.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioSeparatorOn.Location = New System.Drawing.Point(227, 140)
        Me.ioSeparatorOn.LowerBound = 0
        Me.ioSeparatorOn.Name = "ioSeparatorOn"
        Me.ioSeparatorOn.OutputFormat = "0 ms"
        Me.ioSeparatorOn.Size = New System.Drawing.Size(41, 18)
        Me.ioSeparatorOn.TabIndex = 398
        Me.ioSeparatorOn.Text = "0 ms"
        Me.ioSeparatorOn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioSeparatorOn.UpperBound = 1000
        Me.ioSeparatorOn.UserInfo = Nothing
        Me.ioSeparatorOn.UserLevel = 0
        '
        'SeparatorOff
        '
        Me.SeparatorOff.BindControl = Me.ioSeparatorOff
        Me.SeparatorOff.BindProperty = "Data"
        Me.SeparatorOff.Data = Nothing
        Me.SeparatorOff.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.SeparatorOff.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SeparatorOff.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.BundleStorage.Separator.Check.Las" & _
            "tTime_Cil_In"
        '
        'ioSeparatorOff
        '
        Me.ioSeparatorOff.Audit = Nothing
        Me.ioSeparatorOff.AuditEnabled = False
        Me.ioSeparatorOff.AuditMessage = "KremerIoField changed:"
        Me.ioSeparatorOff.AuditSource = "KremerIoField"
        Me.ioSeparatorOff.AutoSize = True
        Me.ioSeparatorOff.Data = 0
        Me.ioSeparatorOff.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioSeparatorOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioSeparatorOff.InitialValue = True
        Me.ioSeparatorOff.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioSeparatorOff.Location = New System.Drawing.Point(227, 165)
        Me.ioSeparatorOff.LowerBound = 0
        Me.ioSeparatorOff.Name = "ioSeparatorOff"
        Me.ioSeparatorOff.OutputFormat = "0 ms"
        Me.ioSeparatorOff.Size = New System.Drawing.Size(41, 18)
        Me.ioSeparatorOff.TabIndex = 399
        Me.ioSeparatorOff.Text = "0 ms"
        Me.ioSeparatorOff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioSeparatorOff.UpperBound = 1000
        Me.ioSeparatorOff.UserInfo = Nothing
        Me.ioSeparatorOff.UserLevel = 0
        '
        'NeedlesInfeedOn
        '
        Me.NeedlesInfeedOn.BindControl = Me.ioNeedlesInfeedOn
        Me.NeedlesInfeedOn.BindProperty = "Data"
        Me.NeedlesInfeedOn.Data = Nothing
        Me.NeedlesInfeedOn.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.NeedlesInfeedOn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.NeedlesInfeedOn.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.CartonLift.GripperNeedle_L.Check." & _
            "LastTime_Cil_Out"
        '
        'ioNeedlesInfeedOn
        '
        Me.ioNeedlesInfeedOn.Audit = Nothing
        Me.ioNeedlesInfeedOn.AuditEnabled = False
        Me.ioNeedlesInfeedOn.AuditMessage = "KremerIoField changed:"
        Me.ioNeedlesInfeedOn.AuditSource = "KremerIoField"
        Me.ioNeedlesInfeedOn.AutoSize = True
        Me.ioNeedlesInfeedOn.Data = 0
        Me.ioNeedlesInfeedOn.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioNeedlesInfeedOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioNeedlesInfeedOn.InitialValue = True
        Me.ioNeedlesInfeedOn.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioNeedlesInfeedOn.Location = New System.Drawing.Point(648, 40)
        Me.ioNeedlesInfeedOn.LowerBound = 0
        Me.ioNeedlesInfeedOn.Name = "ioNeedlesInfeedOn"
        Me.ioNeedlesInfeedOn.OutputFormat = "0 ms"
        Me.ioNeedlesInfeedOn.Size = New System.Drawing.Size(41, 18)
        Me.ioNeedlesInfeedOn.TabIndex = 400
        Me.ioNeedlesInfeedOn.Text = "0 ms"
        Me.ioNeedlesInfeedOn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioNeedlesInfeedOn.UpperBound = 1000
        Me.ioNeedlesInfeedOn.UserInfo = Nothing
        Me.ioNeedlesInfeedOn.UserLevel = 0
        '
        'NeedlesInfeedOff
        '
        Me.NeedlesInfeedOff.BindControl = Me.ioNeedlesInfeedOff
        Me.NeedlesInfeedOff.BindProperty = "Data"
        Me.NeedlesInfeedOff.Data = Nothing
        Me.NeedlesInfeedOff.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.NeedlesInfeedOff.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.NeedlesInfeedOff.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.CartonLift.GripperNeedle_L.Check." & _
            "LastTime_Cil_In"
        '
        'ioNeedlesInfeedOff
        '
        Me.ioNeedlesInfeedOff.Audit = Nothing
        Me.ioNeedlesInfeedOff.AuditEnabled = False
        Me.ioNeedlesInfeedOff.AuditMessage = "KremerIoField changed:"
        Me.ioNeedlesInfeedOff.AuditSource = "KremerIoField"
        Me.ioNeedlesInfeedOff.AutoSize = True
        Me.ioNeedlesInfeedOff.Data = 0
        Me.ioNeedlesInfeedOff.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioNeedlesInfeedOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioNeedlesInfeedOff.InitialValue = True
        Me.ioNeedlesInfeedOff.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioNeedlesInfeedOff.Location = New System.Drawing.Point(648, 65)
        Me.ioNeedlesInfeedOff.LowerBound = 0
        Me.ioNeedlesInfeedOff.Name = "ioNeedlesInfeedOff"
        Me.ioNeedlesInfeedOff.OutputFormat = "0 ms"
        Me.ioNeedlesInfeedOff.Size = New System.Drawing.Size(41, 18)
        Me.ioNeedlesInfeedOff.TabIndex = 401
        Me.ioNeedlesInfeedOff.Text = "0 ms"
        Me.ioNeedlesInfeedOff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioNeedlesInfeedOff.UpperBound = 1000
        Me.ioNeedlesInfeedOff.UserInfo = Nothing
        Me.ioNeedlesInfeedOff.UserLevel = 0
        '
        'NeedlesOutfeedOn
        '
        Me.NeedlesOutfeedOn.BindControl = Me.ioNeedlesOutfeedOn
        Me.NeedlesOutfeedOn.BindProperty = "Data"
        Me.NeedlesOutfeedOn.Data = Nothing
        Me.NeedlesOutfeedOn.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.NeedlesOutfeedOn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.NeedlesOutfeedOn.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.CartonLift.GripperNeedle_R.Check." & _
            "LastTime_Cil_Out"
        '
        'ioNeedlesOutfeedOn
        '
        Me.ioNeedlesOutfeedOn.Audit = Nothing
        Me.ioNeedlesOutfeedOn.AuditEnabled = False
        Me.ioNeedlesOutfeedOn.AuditMessage = "KremerIoField changed:"
        Me.ioNeedlesOutfeedOn.AuditSource = "KremerIoField"
        Me.ioNeedlesOutfeedOn.AutoSize = True
        Me.ioNeedlesOutfeedOn.Data = 0
        Me.ioNeedlesOutfeedOn.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioNeedlesOutfeedOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioNeedlesOutfeedOn.InitialValue = True
        Me.ioNeedlesOutfeedOn.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioNeedlesOutfeedOn.Location = New System.Drawing.Point(648, 90)
        Me.ioNeedlesOutfeedOn.LowerBound = 0
        Me.ioNeedlesOutfeedOn.Name = "ioNeedlesOutfeedOn"
        Me.ioNeedlesOutfeedOn.OutputFormat = "0 ms"
        Me.ioNeedlesOutfeedOn.Size = New System.Drawing.Size(41, 18)
        Me.ioNeedlesOutfeedOn.TabIndex = 402
        Me.ioNeedlesOutfeedOn.Text = "0 ms"
        Me.ioNeedlesOutfeedOn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioNeedlesOutfeedOn.UpperBound = 1000
        Me.ioNeedlesOutfeedOn.UserInfo = Nothing
        Me.ioNeedlesOutfeedOn.UserLevel = 0
        '
        'NeedlesOutfeedOff
        '
        Me.NeedlesOutfeedOff.BindControl = Me.ioNeedlesOutfeedOff
        Me.NeedlesOutfeedOff.BindProperty = "Data"
        Me.NeedlesOutfeedOff.Data = Nothing
        Me.NeedlesOutfeedOff.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.NeedlesOutfeedOff.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.NeedlesOutfeedOff.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.CartonLift.GripperNeedle_R.Check." & _
            "LastTime_Cil_In"
        '
        'ioNeedlesOutfeedOff
        '
        Me.ioNeedlesOutfeedOff.Audit = Nothing
        Me.ioNeedlesOutfeedOff.AuditEnabled = False
        Me.ioNeedlesOutfeedOff.AuditMessage = "KremerIoField changed:"
        Me.ioNeedlesOutfeedOff.AuditSource = "KremerIoField"
        Me.ioNeedlesOutfeedOff.AutoSize = True
        Me.ioNeedlesOutfeedOff.Data = 0
        Me.ioNeedlesOutfeedOff.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioNeedlesOutfeedOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioNeedlesOutfeedOff.InitialValue = True
        Me.ioNeedlesOutfeedOff.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioNeedlesOutfeedOff.Location = New System.Drawing.Point(648, 115)
        Me.ioNeedlesOutfeedOff.LowerBound = 0
        Me.ioNeedlesOutfeedOff.Name = "ioNeedlesOutfeedOff"
        Me.ioNeedlesOutfeedOff.OutputFormat = "0 ms"
        Me.ioNeedlesOutfeedOff.Size = New System.Drawing.Size(41, 18)
        Me.ioNeedlesOutfeedOff.TabIndex = 403
        Me.ioNeedlesOutfeedOff.Text = "0 ms"
        Me.ioNeedlesOutfeedOff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioNeedlesOutfeedOff.UpperBound = 1000
        Me.ioNeedlesOutfeedOff.UserInfo = Nothing
        Me.ioNeedlesOutfeedOff.UserLevel = 0
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
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(11, 40)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(196, 25)
        Me.Label37.TabIndex = 355
        Me.Label37.Tag = ""
        Me.Label37.Text = "Bundle clamp infeed On"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(411, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 25)
        Me.Label3.TabIndex = 359
        Me.Label3.Tag = ""
        Me.Label3.Text = "Needle infeed side Off"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(11, 10)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(231, 25)
        Me.Label29.TabIndex = 339
        Me.Label29.Tag = ""
        Me.Label29.Text = "Bundle Storage"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(196, 25)
        Me.Label12.TabIndex = 372
        Me.Label12.Tag = ""
        Me.Label12.Text = "Bundle clamp infeed Off"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 140)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(257, 25)
        Me.Label13.TabIndex = 374
        Me.Label13.Tag = ""
        Me.Label13.Text = "Separator On"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(11, 165)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(196, 25)
        Me.Label16.TabIndex = 376
        Me.Label16.Tag = ""
        Me.Label16.Text = "Separator Off"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(411, 115)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(231, 25)
        Me.Label18.TabIndex = 380
        Me.Label18.Tag = ""
        Me.Label18.Text = "Needle outfeed side Off"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(411, 10)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(231, 25)
        Me.Label19.TabIndex = 385
        Me.Label19.Tag = ""
        Me.Label19.Text = "Carton Lift"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(411, 90)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(231, 25)
        Me.Label20.TabIndex = 384
        Me.Label20.Tag = ""
        Me.Label20.Text = "Needle outfeed side On"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(411, 40)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(231, 25)
        Me.Label21.TabIndex = 382
        Me.Label21.Tag = ""
        Me.Label21.Text = "Needle infeed side On"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 25)
        Me.Label1.TabIndex = 393
        Me.Label1.Tag = ""
        Me.Label1.Text = "Bundle clamp outfeed Off"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 25)
        Me.Label2.TabIndex = 392
        Me.Label2.Tag = ""
        Me.Label2.Text = "Bundle clamp outfeed On"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CT_VDenester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ioNeedlesOutfeedOff)
        Me.Controls.Add(Me.ioNeedlesOutfeedOn)
        Me.Controls.Add(Me.ioNeedlesInfeedOff)
        Me.Controls.Add(Me.ioNeedlesInfeedOn)
        Me.Controls.Add(Me.ioSeparatorOff)
        Me.Controls.Add(Me.ioSeparatorOn)
        Me.Controls.Add(Me.ioBundleClampOutfeedOff)
        Me.Controls.Add(Me.ioBundleClampOutfeedOn)
        Me.Controls.Add(Me.ioBundleClampInfeedOff)
        Me.Controls.Add(Me.ioBundleClampInfeedOn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Name = "CT_VDenester"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "560"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ioBundleClampInfeedOff As KremerControlsWin32.KremerIoField
    Friend WithEvents ioBundleClampInfeedOn As KremerControlsWin32.KremerIoField
    Friend WithEvents ioBundleClampOutfeedOff As KremerControlsWin32.KremerIoField
    Friend WithEvents ioBundleClampOutfeedOn As KremerControlsWin32.KremerIoField
    Friend WithEvents ioSeparatorOff As KremerControlsWin32.KremerIoField
    Friend WithEvents ioSeparatorOn As KremerControlsWin32.KremerIoField
    Friend WithEvents ioNeedlesOutfeedOff As KremerControlsWin32.KremerIoField
    Friend WithEvents ioNeedlesOutfeedOn As KremerControlsWin32.KremerIoField
    Friend WithEvents ioNeedlesInfeedOff As KremerControlsWin32.KremerIoField
    Friend WithEvents ioNeedlesInfeedOn As KremerControlsWin32.KremerIoField
    Friend WithEvents BundleClampInfeedOn As KremerControlsWin32.KremerVariable
    Friend WithEvents BundleClampInfeedOff As KremerControlsWin32.KremerVariable
    Friend WithEvents BundleClampOutfeedOn As KremerControlsWin32.KremerVariable
    Friend WithEvents BundleClampOutfeedOff As KremerControlsWin32.KremerVariable
    Friend WithEvents SeparatorOn As KremerControlsWin32.KremerVariable
    Friend WithEvents SeparatorOff As KremerControlsWin32.KremerVariable
    Friend WithEvents NeedlesInfeedOn As KremerControlsWin32.KremerVariable
    Friend WithEvents NeedlesInfeedOff As KremerControlsWin32.KremerVariable
    Friend WithEvents NeedlesOutfeedOn As KremerControlsWin32.KremerVariable
    Friend WithEvents NeedlesOutfeedOff As KremerControlsWin32.KremerVariable

End Class
