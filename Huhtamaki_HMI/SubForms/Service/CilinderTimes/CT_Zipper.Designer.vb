<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CT_Zipper
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
        Me.UpperInfeedUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioUpperInfeedUp = New KremerControlsWin32.KremerIoField(Me.components)
        Me.UpperInfeedDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioUpperInfeedDown = New KremerControlsWin32.KremerIoField(Me.components)
        Me.StopperUpperInfeed1UpA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioStopperUpperInfeed1UpA = New KremerControlsWin32.KremerIoField(Me.components)
        Me.StopperUpperInfeed1DownA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioStopperUpperInfeed1DownA = New KremerControlsWin32.KremerIoField(Me.components)
        Me.StopperUpperInfeed2UpA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioStopperUpperInfeed2UpA = New KremerControlsWin32.KremerIoField(Me.components)
        Me.StopperUpperInfeed2DownA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioStopperUpperInfeed2DownA = New KremerControlsWin32.KremerIoField(Me.components)
        Me.StopperUpperInfeed1UpB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioStopperUpperInfeed1UpB = New KremerControlsWin32.KremerIoField(Me.components)
        Me.StopperUpperInfeed1DownB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioStopperUpperInfeed1DownB = New KremerControlsWin32.KremerIoField(Me.components)
        Me.StopperUpperInfeed2UpB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioStopperUpperInfeed2UpB = New KremerControlsWin32.KremerIoField(Me.components)
        Me.StopperUpperInfeed2DownB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioStopperUpperInfeed2DownB = New KremerControlsWin32.KremerIoField(Me.components)
        Me.StopperTibUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioStopperTibUp = New KremerControlsWin32.KremerIoField(Me.components)
        Me.StopperTibDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioStopperTibDown = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Btn_Overview = New KremerControlsWin32.KremerButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.UpperInfeedUp)
        Me.VarCollector.Variables.Add(Me.UpperInfeedDown)
        Me.VarCollector.Variables.Add(Me.StopperUpperInfeed1UpA)
        Me.VarCollector.Variables.Add(Me.StopperUpperInfeed1DownA)
        Me.VarCollector.Variables.Add(Me.StopperUpperInfeed2UpA)
        Me.VarCollector.Variables.Add(Me.StopperUpperInfeed2DownA)
        Me.VarCollector.Variables.Add(Me.StopperUpperInfeed1UpB)
        Me.VarCollector.Variables.Add(Me.StopperUpperInfeed1DownB)
        Me.VarCollector.Variables.Add(Me.StopperUpperInfeed2UpB)
        Me.VarCollector.Variables.Add(Me.StopperUpperInfeed2DownB)
        Me.VarCollector.Variables.Add(Me.StopperTibUp)
        Me.VarCollector.Variables.Add(Me.StopperTibDown)
        '
        'UpperInfeedUp
        '
        Me.UpperInfeedUp.BindControl = Me.ioUpperInfeedUp
        Me.UpperInfeedUp.BindProperty = "Data"
        Me.UpperInfeedUp.Data = Nothing
        Me.UpperInfeedUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.UpperInfeedUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.UpperInfeedUp.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.Cilinder.Check.LastTime_Cil_Out"
        '
        'ioUpperInfeedUp
        '
        Me.ioUpperInfeedUp.Audit = Nothing
        Me.ioUpperInfeedUp.AuditEnabled = False
        Me.ioUpperInfeedUp.AuditMessage = "KremerIoField changed:"
        Me.ioUpperInfeedUp.AuditSource = "KremerIoField"
        Me.ioUpperInfeedUp.AutoSize = True
        Me.ioUpperInfeedUp.Data = 0
        Me.ioUpperInfeedUp.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioUpperInfeedUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioUpperInfeedUp.InitialValue = True
        Me.ioUpperInfeedUp.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioUpperInfeedUp.Location = New System.Drawing.Point(189, 40)
        Me.ioUpperInfeedUp.LowerBound = 0
        Me.ioUpperInfeedUp.Name = "ioUpperInfeedUp"
        Me.ioUpperInfeedUp.OutputFormat = "0 ms"
        Me.ioUpperInfeedUp.Size = New System.Drawing.Size(41, 18)
        Me.ioUpperInfeedUp.TabIndex = 359
        Me.ioUpperInfeedUp.Text = "0 ms"
        Me.ioUpperInfeedUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioUpperInfeedUp.UpperBound = 1000
        Me.ioUpperInfeedUp.UserInfo = Nothing
        Me.ioUpperInfeedUp.UserLevel = 0
        '
        'UpperInfeedDown
        '
        Me.UpperInfeedDown.BindControl = Me.ioUpperInfeedDown
        Me.UpperInfeedDown.BindProperty = "Data"
        Me.UpperInfeedDown.Data = Nothing
        Me.UpperInfeedDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.UpperInfeedDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.UpperInfeedDown.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.Cilinder.Check.LastTime_Cil_In"
        '
        'ioUpperInfeedDown
        '
        Me.ioUpperInfeedDown.Audit = Nothing
        Me.ioUpperInfeedDown.AuditEnabled = False
        Me.ioUpperInfeedDown.AuditMessage = "KremerIoField changed:"
        Me.ioUpperInfeedDown.AuditSource = "KremerIoField"
        Me.ioUpperInfeedDown.AutoSize = True
        Me.ioUpperInfeedDown.Data = 0
        Me.ioUpperInfeedDown.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioUpperInfeedDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioUpperInfeedDown.InitialValue = True
        Me.ioUpperInfeedDown.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioUpperInfeedDown.Location = New System.Drawing.Point(189, 65)
        Me.ioUpperInfeedDown.LowerBound = 0
        Me.ioUpperInfeedDown.Name = "ioUpperInfeedDown"
        Me.ioUpperInfeedDown.OutputFormat = "0 ms"
        Me.ioUpperInfeedDown.Size = New System.Drawing.Size(41, 18)
        Me.ioUpperInfeedDown.TabIndex = 360
        Me.ioUpperInfeedDown.Text = "0 ms"
        Me.ioUpperInfeedDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioUpperInfeedDown.UpperBound = 1000
        Me.ioUpperInfeedDown.UserInfo = Nothing
        Me.ioUpperInfeedDown.UserLevel = 0
        '
        'StopperUpperInfeed1UpA
        '
        Me.StopperUpperInfeed1UpA.BindControl = Me.ioStopperUpperInfeed1UpA
        Me.StopperUpperInfeed1UpA.BindProperty = "Data"
        Me.StopperUpperInfeed1UpA.Data = Nothing
        Me.StopperUpperInfeed1UpA.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.StopperUpperInfeed1UpA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StopperUpperInfeed1UpA.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.Stoppers_A.Stopper1.Check.LastTime_Cil" & _
            "_Out"
        '
        'ioStopperUpperInfeed1UpA
        '
        Me.ioStopperUpperInfeed1UpA.Audit = Nothing
        Me.ioStopperUpperInfeed1UpA.AuditEnabled = False
        Me.ioStopperUpperInfeed1UpA.AuditMessage = "KremerIoField changed:"
        Me.ioStopperUpperInfeed1UpA.AuditSource = "KremerIoField"
        Me.ioStopperUpperInfeed1UpA.AutoSize = True
        Me.ioStopperUpperInfeed1UpA.Data = 0
        Me.ioStopperUpperInfeed1UpA.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioStopperUpperInfeed1UpA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioStopperUpperInfeed1UpA.InitialValue = True
        Me.ioStopperUpperInfeed1UpA.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioStopperUpperInfeed1UpA.Location = New System.Drawing.Point(460, 40)
        Me.ioStopperUpperInfeed1UpA.LowerBound = 0
        Me.ioStopperUpperInfeed1UpA.Name = "ioStopperUpperInfeed1UpA"
        Me.ioStopperUpperInfeed1UpA.OutputFormat = "0 ms"
        Me.ioStopperUpperInfeed1UpA.Size = New System.Drawing.Size(41, 18)
        Me.ioStopperUpperInfeed1UpA.TabIndex = 365
        Me.ioStopperUpperInfeed1UpA.Text = "0 ms"
        Me.ioStopperUpperInfeed1UpA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioStopperUpperInfeed1UpA.UpperBound = 1000
        Me.ioStopperUpperInfeed1UpA.UserInfo = Nothing
        Me.ioStopperUpperInfeed1UpA.UserLevel = 0
        '
        'StopperUpperInfeed1DownA
        '
        Me.StopperUpperInfeed1DownA.BindControl = Me.ioStopperUpperInfeed1DownA
        Me.StopperUpperInfeed1DownA.BindProperty = "Data"
        Me.StopperUpperInfeed1DownA.Data = Nothing
        Me.StopperUpperInfeed1DownA.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.StopperUpperInfeed1DownA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StopperUpperInfeed1DownA.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.Stoppers_A.Stopper1.Check.LastTime_Cil" & _
            "_In"
        '
        'ioStopperUpperInfeed1DownA
        '
        Me.ioStopperUpperInfeed1DownA.Audit = Nothing
        Me.ioStopperUpperInfeed1DownA.AuditEnabled = False
        Me.ioStopperUpperInfeed1DownA.AuditMessage = "KremerIoField changed:"
        Me.ioStopperUpperInfeed1DownA.AuditSource = "KremerIoField"
        Me.ioStopperUpperInfeed1DownA.AutoSize = True
        Me.ioStopperUpperInfeed1DownA.Data = 0
        Me.ioStopperUpperInfeed1DownA.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioStopperUpperInfeed1DownA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioStopperUpperInfeed1DownA.InitialValue = True
        Me.ioStopperUpperInfeed1DownA.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioStopperUpperInfeed1DownA.Location = New System.Drawing.Point(460, 65)
        Me.ioStopperUpperInfeed1DownA.LowerBound = 0
        Me.ioStopperUpperInfeed1DownA.Name = "ioStopperUpperInfeed1DownA"
        Me.ioStopperUpperInfeed1DownA.OutputFormat = "0 ms"
        Me.ioStopperUpperInfeed1DownA.Size = New System.Drawing.Size(41, 18)
        Me.ioStopperUpperInfeed1DownA.TabIndex = 366
        Me.ioStopperUpperInfeed1DownA.Text = "0 ms"
        Me.ioStopperUpperInfeed1DownA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioStopperUpperInfeed1DownA.UpperBound = 1000
        Me.ioStopperUpperInfeed1DownA.UserInfo = Nothing
        Me.ioStopperUpperInfeed1DownA.UserLevel = 0
        '
        'StopperUpperInfeed2UpA
        '
        Me.StopperUpperInfeed2UpA.BindControl = Me.ioStopperUpperInfeed2UpA
        Me.StopperUpperInfeed2UpA.BindProperty = "Data"
        Me.StopperUpperInfeed2UpA.Data = Nothing
        Me.StopperUpperInfeed2UpA.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.StopperUpperInfeed2UpA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StopperUpperInfeed2UpA.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.Stoppers_A.Stopper2.Check.LastTime_Cil" & _
            "_In"
        '
        'ioStopperUpperInfeed2UpA
        '
        Me.ioStopperUpperInfeed2UpA.Audit = Nothing
        Me.ioStopperUpperInfeed2UpA.AuditEnabled = False
        Me.ioStopperUpperInfeed2UpA.AuditMessage = "KremerIoField changed:"
        Me.ioStopperUpperInfeed2UpA.AuditSource = "KremerIoField"
        Me.ioStopperUpperInfeed2UpA.AutoSize = True
        Me.ioStopperUpperInfeed2UpA.Data = 0
        Me.ioStopperUpperInfeed2UpA.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioStopperUpperInfeed2UpA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioStopperUpperInfeed2UpA.InitialValue = True
        Me.ioStopperUpperInfeed2UpA.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioStopperUpperInfeed2UpA.Location = New System.Drawing.Point(460, 90)
        Me.ioStopperUpperInfeed2UpA.LowerBound = 0
        Me.ioStopperUpperInfeed2UpA.Name = "ioStopperUpperInfeed2UpA"
        Me.ioStopperUpperInfeed2UpA.OutputFormat = "0 ms"
        Me.ioStopperUpperInfeed2UpA.Size = New System.Drawing.Size(41, 18)
        Me.ioStopperUpperInfeed2UpA.TabIndex = 367
        Me.ioStopperUpperInfeed2UpA.Text = "0 ms"
        Me.ioStopperUpperInfeed2UpA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioStopperUpperInfeed2UpA.UpperBound = 1000
        Me.ioStopperUpperInfeed2UpA.UserInfo = Nothing
        Me.ioStopperUpperInfeed2UpA.UserLevel = 0
        '
        'StopperUpperInfeed2DownA
        '
        Me.StopperUpperInfeed2DownA.BindControl = Me.ioStopperUpperInfeed2DownA
        Me.StopperUpperInfeed2DownA.BindProperty = "Data"
        Me.StopperUpperInfeed2DownA.Data = Nothing
        Me.StopperUpperInfeed2DownA.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.StopperUpperInfeed2DownA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StopperUpperInfeed2DownA.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.Stoppers_A.Stopper2.Check.LastTime_Cil" & _
            "_Out"
        '
        'ioStopperUpperInfeed2DownA
        '
        Me.ioStopperUpperInfeed2DownA.Audit = Nothing
        Me.ioStopperUpperInfeed2DownA.AuditEnabled = False
        Me.ioStopperUpperInfeed2DownA.AuditMessage = "KremerIoField changed:"
        Me.ioStopperUpperInfeed2DownA.AuditSource = "KremerIoField"
        Me.ioStopperUpperInfeed2DownA.AutoSize = True
        Me.ioStopperUpperInfeed2DownA.Data = 0
        Me.ioStopperUpperInfeed2DownA.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioStopperUpperInfeed2DownA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioStopperUpperInfeed2DownA.InitialValue = True
        Me.ioStopperUpperInfeed2DownA.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioStopperUpperInfeed2DownA.Location = New System.Drawing.Point(460, 115)
        Me.ioStopperUpperInfeed2DownA.LowerBound = 0
        Me.ioStopperUpperInfeed2DownA.Name = "ioStopperUpperInfeed2DownA"
        Me.ioStopperUpperInfeed2DownA.OutputFormat = "0 ms"
        Me.ioStopperUpperInfeed2DownA.Size = New System.Drawing.Size(41, 18)
        Me.ioStopperUpperInfeed2DownA.TabIndex = 368
        Me.ioStopperUpperInfeed2DownA.Text = "0 ms"
        Me.ioStopperUpperInfeed2DownA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioStopperUpperInfeed2DownA.UpperBound = 1000
        Me.ioStopperUpperInfeed2DownA.UserInfo = Nothing
        Me.ioStopperUpperInfeed2DownA.UserLevel = 0
        '
        'StopperUpperInfeed1UpB
        '
        Me.StopperUpperInfeed1UpB.BindControl = Me.ioStopperUpperInfeed1UpB
        Me.StopperUpperInfeed1UpB.BindProperty = "Data"
        Me.StopperUpperInfeed1UpB.Data = Nothing
        Me.StopperUpperInfeed1UpB.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.StopperUpperInfeed1UpB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StopperUpperInfeed1UpB.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.Stoppers_B.Stopper1.Check.LastTime_Cil" & _
            "_Out"
        '
        'ioStopperUpperInfeed1UpB
        '
        Me.ioStopperUpperInfeed1UpB.Audit = Nothing
        Me.ioStopperUpperInfeed1UpB.AuditEnabled = False
        Me.ioStopperUpperInfeed1UpB.AuditMessage = "KremerIoField changed:"
        Me.ioStopperUpperInfeed1UpB.AuditSource = "KremerIoField"
        Me.ioStopperUpperInfeed1UpB.AutoSize = True
        Me.ioStopperUpperInfeed1UpB.Data = 0
        Me.ioStopperUpperInfeed1UpB.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioStopperUpperInfeed1UpB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioStopperUpperInfeed1UpB.InitialValue = True
        Me.ioStopperUpperInfeed1UpB.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioStopperUpperInfeed1UpB.Location = New System.Drawing.Point(460, 140)
        Me.ioStopperUpperInfeed1UpB.LowerBound = 0
        Me.ioStopperUpperInfeed1UpB.Name = "ioStopperUpperInfeed1UpB"
        Me.ioStopperUpperInfeed1UpB.OutputFormat = "0 ms"
        Me.ioStopperUpperInfeed1UpB.Size = New System.Drawing.Size(41, 18)
        Me.ioStopperUpperInfeed1UpB.TabIndex = 369
        Me.ioStopperUpperInfeed1UpB.Text = "0 ms"
        Me.ioStopperUpperInfeed1UpB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioStopperUpperInfeed1UpB.UpperBound = 1000
        Me.ioStopperUpperInfeed1UpB.UserInfo = Nothing
        Me.ioStopperUpperInfeed1UpB.UserLevel = 0
        '
        'StopperUpperInfeed1DownB
        '
        Me.StopperUpperInfeed1DownB.BindControl = Me.ioStopperUpperInfeed1DownB
        Me.StopperUpperInfeed1DownB.BindProperty = "Data"
        Me.StopperUpperInfeed1DownB.Data = Nothing
        Me.StopperUpperInfeed1DownB.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.StopperUpperInfeed1DownB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StopperUpperInfeed1DownB.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.Stoppers_B.Stopper1.Check.LastTime_Cil" & _
            "_In"
        '
        'ioStopperUpperInfeed1DownB
        '
        Me.ioStopperUpperInfeed1DownB.Audit = Nothing
        Me.ioStopperUpperInfeed1DownB.AuditEnabled = False
        Me.ioStopperUpperInfeed1DownB.AuditMessage = "KremerIoField changed:"
        Me.ioStopperUpperInfeed1DownB.AuditSource = "KremerIoField"
        Me.ioStopperUpperInfeed1DownB.AutoSize = True
        Me.ioStopperUpperInfeed1DownB.Data = 0
        Me.ioStopperUpperInfeed1DownB.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioStopperUpperInfeed1DownB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioStopperUpperInfeed1DownB.InitialValue = True
        Me.ioStopperUpperInfeed1DownB.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioStopperUpperInfeed1DownB.Location = New System.Drawing.Point(460, 165)
        Me.ioStopperUpperInfeed1DownB.LowerBound = 0
        Me.ioStopperUpperInfeed1DownB.Name = "ioStopperUpperInfeed1DownB"
        Me.ioStopperUpperInfeed1DownB.OutputFormat = "0 ms"
        Me.ioStopperUpperInfeed1DownB.Size = New System.Drawing.Size(41, 18)
        Me.ioStopperUpperInfeed1DownB.TabIndex = 370
        Me.ioStopperUpperInfeed1DownB.Text = "0 ms"
        Me.ioStopperUpperInfeed1DownB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioStopperUpperInfeed1DownB.UpperBound = 1000
        Me.ioStopperUpperInfeed1DownB.UserInfo = Nothing
        Me.ioStopperUpperInfeed1DownB.UserLevel = 0
        '
        'StopperUpperInfeed2UpB
        '
        Me.StopperUpperInfeed2UpB.BindControl = Me.ioStopperUpperInfeed2UpB
        Me.StopperUpperInfeed2UpB.BindProperty = "Data"
        Me.StopperUpperInfeed2UpB.Data = Nothing
        Me.StopperUpperInfeed2UpB.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.StopperUpperInfeed2UpB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StopperUpperInfeed2UpB.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.Stoppers_B.Stopper2.Check.LastTime_Cil" & _
            "_In"
        '
        'ioStopperUpperInfeed2UpB
        '
        Me.ioStopperUpperInfeed2UpB.Audit = Nothing
        Me.ioStopperUpperInfeed2UpB.AuditEnabled = False
        Me.ioStopperUpperInfeed2UpB.AuditMessage = "KremerIoField changed:"
        Me.ioStopperUpperInfeed2UpB.AuditSource = "KremerIoField"
        Me.ioStopperUpperInfeed2UpB.AutoSize = True
        Me.ioStopperUpperInfeed2UpB.Data = 0
        Me.ioStopperUpperInfeed2UpB.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioStopperUpperInfeed2UpB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioStopperUpperInfeed2UpB.InitialValue = True
        Me.ioStopperUpperInfeed2UpB.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioStopperUpperInfeed2UpB.Location = New System.Drawing.Point(460, 190)
        Me.ioStopperUpperInfeed2UpB.LowerBound = 0
        Me.ioStopperUpperInfeed2UpB.Name = "ioStopperUpperInfeed2UpB"
        Me.ioStopperUpperInfeed2UpB.OutputFormat = "0 ms"
        Me.ioStopperUpperInfeed2UpB.Size = New System.Drawing.Size(41, 18)
        Me.ioStopperUpperInfeed2UpB.TabIndex = 371
        Me.ioStopperUpperInfeed2UpB.Text = "0 ms"
        Me.ioStopperUpperInfeed2UpB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioStopperUpperInfeed2UpB.UpperBound = 1000
        Me.ioStopperUpperInfeed2UpB.UserInfo = Nothing
        Me.ioStopperUpperInfeed2UpB.UserLevel = 0
        '
        'StopperUpperInfeed2DownB
        '
        Me.StopperUpperInfeed2DownB.BindControl = Me.ioStopperUpperInfeed2DownB
        Me.StopperUpperInfeed2DownB.BindProperty = "Data"
        Me.StopperUpperInfeed2DownB.Data = Nothing
        Me.StopperUpperInfeed2DownB.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.StopperUpperInfeed2DownB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StopperUpperInfeed2DownB.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.Stoppers_B.Stopper2.Check.LastTime_Cil" & _
            "_Out"
        '
        'ioStopperUpperInfeed2DownB
        '
        Me.ioStopperUpperInfeed2DownB.Audit = Nothing
        Me.ioStopperUpperInfeed2DownB.AuditEnabled = False
        Me.ioStopperUpperInfeed2DownB.AuditMessage = "KremerIoField changed:"
        Me.ioStopperUpperInfeed2DownB.AuditSource = "KremerIoField"
        Me.ioStopperUpperInfeed2DownB.AutoSize = True
        Me.ioStopperUpperInfeed2DownB.Data = 0
        Me.ioStopperUpperInfeed2DownB.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioStopperUpperInfeed2DownB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioStopperUpperInfeed2DownB.InitialValue = True
        Me.ioStopperUpperInfeed2DownB.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioStopperUpperInfeed2DownB.Location = New System.Drawing.Point(460, 215)
        Me.ioStopperUpperInfeed2DownB.LowerBound = 0
        Me.ioStopperUpperInfeed2DownB.Name = "ioStopperUpperInfeed2DownB"
        Me.ioStopperUpperInfeed2DownB.OutputFormat = "0 ms"
        Me.ioStopperUpperInfeed2DownB.Size = New System.Drawing.Size(41, 18)
        Me.ioStopperUpperInfeed2DownB.TabIndex = 372
        Me.ioStopperUpperInfeed2DownB.Text = "0 ms"
        Me.ioStopperUpperInfeed2DownB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioStopperUpperInfeed2DownB.UpperBound = 1000
        Me.ioStopperUpperInfeed2DownB.UserInfo = Nothing
        Me.ioStopperUpperInfeed2DownB.UserLevel = 0
        '
        'StopperTibUp
        '
        Me.StopperTibUp.BindControl = Me.ioStopperTibUp
        Me.StopperTibUp.BindProperty = "Data"
        Me.StopperTibUp.Data = Nothing
        Me.StopperTibUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.StopperTibUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StopperTibUp.VariableName = "InlineAutomation.Inline.TimingInfeed.Stopper2.Stopper.Check.LastTime_Cil_Out"
        '
        'ioStopperTibUp
        '
        Me.ioStopperTibUp.Audit = Nothing
        Me.ioStopperTibUp.AuditEnabled = False
        Me.ioStopperTibUp.AuditMessage = "KremerIoField changed:"
        Me.ioStopperTibUp.AuditSource = "KremerIoField"
        Me.ioStopperTibUp.AutoSize = True
        Me.ioStopperTibUp.Data = 0
        Me.ioStopperTibUp.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioStopperTibUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioStopperTibUp.InitialValue = True
        Me.ioStopperTibUp.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioStopperTibUp.Location = New System.Drawing.Point(723, 40)
        Me.ioStopperTibUp.LowerBound = 0
        Me.ioStopperTibUp.Name = "ioStopperTibUp"
        Me.ioStopperTibUp.OutputFormat = "0 ms"
        Me.ioStopperTibUp.Size = New System.Drawing.Size(41, 18)
        Me.ioStopperTibUp.TabIndex = 373
        Me.ioStopperTibUp.Text = "0 ms"
        Me.ioStopperTibUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioStopperTibUp.UpperBound = 1000
        Me.ioStopperTibUp.UserInfo = Nothing
        Me.ioStopperTibUp.UserLevel = 0
        '
        'StopperTibDown
        '
        Me.StopperTibDown.BindControl = Me.ioStopperTibDown
        Me.StopperTibDown.BindProperty = "Data"
        Me.StopperTibDown.Data = Nothing
        Me.StopperTibDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.StopperTibDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StopperTibDown.VariableName = "InlineAutomation.Inline.TimingInfeed.Stopper2.Stopper.Check.LastTime_Cil_In"
        '
        'ioStopperTibDown
        '
        Me.ioStopperTibDown.Audit = Nothing
        Me.ioStopperTibDown.AuditEnabled = False
        Me.ioStopperTibDown.AuditMessage = "KremerIoField changed:"
        Me.ioStopperTibDown.AuditSource = "KremerIoField"
        Me.ioStopperTibDown.AutoSize = True
        Me.ioStopperTibDown.Data = 0
        Me.ioStopperTibDown.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioStopperTibDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioStopperTibDown.InitialValue = True
        Me.ioStopperTibDown.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioStopperTibDown.Location = New System.Drawing.Point(723, 65)
        Me.ioStopperTibDown.LowerBound = 0
        Me.ioStopperTibDown.Name = "ioStopperTibDown"
        Me.ioStopperTibDown.OutputFormat = "0 ms"
        Me.ioStopperTibDown.Size = New System.Drawing.Size(41, 18)
        Me.ioStopperTibDown.TabIndex = 374
        Me.ioStopperTibDown.Text = "0 ms"
        Me.ioStopperTibDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioStopperTibDown.UpperBound = 1000
        Me.ioStopperTibDown.UserInfo = Nothing
        Me.ioStopperTibDown.UserLevel = 0
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
        Me.Label6.Location = New System.Drawing.Point(280, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 25)
        Me.Label6.TabIndex = 296
        Me.Label6.Tag = ""
        Me.Label6.Text = "Stopper 1 Up A"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(280, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(171, 25)
        Me.Label9.TabIndex = 300
        Me.Label9.Tag = ""
        Me.Label9.Text = "Stopper 2 Down A"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(280, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(171, 25)
        Me.Label11.TabIndex = 308
        Me.Label11.Tag = ""
        Me.Label11.Text = "Stopper 1 Down A"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(280, 90)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(171, 25)
        Me.Label13.TabIndex = 304
        Me.Label13.Tag = ""
        Me.Label13.Text = "Stopper 2 Up A"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(550, 65)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(167, 25)
        Me.Label16.TabIndex = 336
        Me.Label16.Tag = ""
        Me.Label16.Text = "Stopper Down"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(550, 10)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(231, 25)
        Me.Label27.TabIndex = 337
        Me.Label27.Tag = ""
        Me.Label27.Text = "Timing Infeed Belt"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(280, 10)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(231, 25)
        Me.Label28.TabIndex = 338
        Me.Label28.Tag = ""
        Me.Label28.Text = "Stoppers Infeed"
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
        Me.Label30.Text = "Upper Infeed"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(11, 65)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(167, 25)
        Me.Label37.TabIndex = 355
        Me.Label37.Tag = ""
        Me.Label37.Text = "UpperInfeed Down"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(11, 40)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(167, 25)
        Me.Label38.TabIndex = 353
        Me.Label38.Tag = ""
        Me.Label38.Text = "UpperInfeed Up"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 25)
        Me.Label1.TabIndex = 364
        Me.Label1.Tag = ""
        Me.Label1.Text = "Stopper 2 Down B"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(280, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 25)
        Me.Label2.TabIndex = 363
        Me.Label2.Tag = ""
        Me.Label2.Text = "Stopper 1 Down B"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(280, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 25)
        Me.Label3.TabIndex = 362
        Me.Label3.Tag = ""
        Me.Label3.Text = "Stopper 2 Up B"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(280, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 25)
        Me.Label4.TabIndex = 361
        Me.Label4.Tag = ""
        Me.Label4.Text = "Stopper 1 Up B"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(550, 40)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(157, 25)
        Me.Label22.TabIndex = 334
        Me.Label22.Tag = ""
        Me.Label22.Text = "Stopper Up"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CT_Zipper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ioStopperTibDown)
        Me.Controls.Add(Me.ioStopperTibUp)
        Me.Controls.Add(Me.ioStopperUpperInfeed2DownB)
        Me.Controls.Add(Me.ioStopperUpperInfeed2UpB)
        Me.Controls.Add(Me.ioStopperUpperInfeed1DownB)
        Me.Controls.Add(Me.ioStopperUpperInfeed1UpB)
        Me.Controls.Add(Me.ioStopperUpperInfeed2DownA)
        Me.Controls.Add(Me.ioStopperUpperInfeed2UpA)
        Me.Controls.Add(Me.ioStopperUpperInfeed1DownA)
        Me.Controls.Add(Me.ioStopperUpperInfeed1UpA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ioUpperInfeedDown)
        Me.Controls.Add(Me.ioUpperInfeedUp)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Name = "CT_Zipper"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "556"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents ioUpperInfeedUp As KremerControlsWin32.KremerIoField
    Friend WithEvents ioUpperInfeedDown As KremerControlsWin32.KremerIoField
    Friend WithEvents UpperInfeedUp As KremerControlsWin32.KremerVariable
    Friend WithEvents UpperInfeedDown As KremerControlsWin32.KremerVariable
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ioStopperUpperInfeed1DownA As KremerControlsWin32.KremerIoField
    Friend WithEvents ioStopperUpperInfeed1UpA As KremerControlsWin32.KremerIoField
    Friend WithEvents ioStopperUpperInfeed2DownA As KremerControlsWin32.KremerIoField
    Friend WithEvents ioStopperUpperInfeed2UpA As KremerControlsWin32.KremerIoField
    Friend WithEvents ioStopperUpperInfeed1DownB As KremerControlsWin32.KremerIoField
    Friend WithEvents ioStopperUpperInfeed1UpB As KremerControlsWin32.KremerIoField
    Friend WithEvents ioStopperUpperInfeed2DownB As KremerControlsWin32.KremerIoField
    Friend WithEvents ioStopperUpperInfeed2UpB As KremerControlsWin32.KremerIoField
    Friend WithEvents ioStopperTibDown As KremerControlsWin32.KremerIoField
    Friend WithEvents ioStopperTibUp As KremerControlsWin32.KremerIoField
    Friend WithEvents StopperUpperInfeed1UpA As KremerControlsWin32.KremerVariable
    Friend WithEvents StopperUpperInfeed1DownA As KremerControlsWin32.KremerVariable
    Friend WithEvents StopperUpperInfeed2UpA As KremerControlsWin32.KremerVariable
    Friend WithEvents StopperUpperInfeed2DownA As KremerControlsWin32.KremerVariable
    Friend WithEvents StopperUpperInfeed1UpB As KremerControlsWin32.KremerVariable
    Friend WithEvents StopperUpperInfeed1DownB As KremerControlsWin32.KremerVariable
    Friend WithEvents StopperUpperInfeed2UpB As KremerControlsWin32.KremerVariable
    Friend WithEvents StopperUpperInfeed2DownB As KremerControlsWin32.KremerVariable
    Friend WithEvents StopperTibUp As KremerControlsWin32.KremerVariable
    Friend WithEvents StopperTibDown As KremerControlsWin32.KremerVariable

End Class
