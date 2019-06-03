<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MachinePond_Settings_New
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
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.PondDownStop = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_MP_DownStop = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PondDownSlow = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_MP_DownSlow = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PondUpStop = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_MP_UpStop = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PondUpSlow = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_MP_UpSlow = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PondOffsetSlow = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_MP_OffsetSlow = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PondOffsetAlarm = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_MP_OffsetAlarm = New KremerControlsWin32.KremerIoField(Me.components)
        Me.FormVacTime = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_1Vacuumtime = New KremerControlsWin32.KremerIoField(Me.components)
        Me.FormBubbleTime = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_FM_BubbleTime = New KremerControlsWin32.KremerIoField(Me.components)
        Me.FormBlowOfftime = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_FM_BlowOffTime = New KremerControlsWin32.KremerIoField(Me.components)
        Me.FormAfterblow = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_FM_BlowAfterTime = New KremerControlsWin32.KremerIoField(Me.components)
        Me.IO_2Vacuumtime = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PondUpWaitTime = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_MP_WaitTime = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PondFeedingPulpTime = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_MP_PulpTime = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PulpFeedingGTError = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_PF_GTError = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PulpFeedingGTWarningIn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_PF_GTWarningIn = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PulpFeedingGTWarningOut = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_PF_GTWarningOut = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ActPos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_MP_Pos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PhyscalMeasuredPos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_PhysicalMeasuredPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.mxAutoMode = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_Overview = New KremerControlsWin32.KremerButton()
        Me.Btn_Manual = New KremerControlsWin32.KremerButton()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape10 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_puh = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.IO_3Vacuumtime = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label26 = New System.Windows.Forms.Label()
        Me.IO_PondPosForBubbleStart = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Form2ndVacTime = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Form3thVacTime = New KremerControlsWin32.KremerVariable(Me.components)
        Me.FormStartBubblePos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.PondDownStop)
        Me.VarCollector.Variables.Add(Me.PondDownSlow)
        Me.VarCollector.Variables.Add(Me.PondUpStop)
        Me.VarCollector.Variables.Add(Me.PondUpSlow)
        Me.VarCollector.Variables.Add(Me.PondOffsetSlow)
        Me.VarCollector.Variables.Add(Me.PondOffsetAlarm)
        Me.VarCollector.Variables.Add(Me.FormVacTime)
        Me.VarCollector.Variables.Add(Me.Form2ndVacTime)
        Me.VarCollector.Variables.Add(Me.Form3thVacTime)
        Me.VarCollector.Variables.Add(Me.FormBubbleTime)
        Me.VarCollector.Variables.Add(Me.FormBlowOfftime)
        Me.VarCollector.Variables.Add(Me.FormAfterblow)
        Me.VarCollector.Variables.Add(Me.PondUpWaitTime)
        Me.VarCollector.Variables.Add(Me.PondFeedingPulpTime)
        Me.VarCollector.Variables.Add(Me.PulpFeedingGTError)
        Me.VarCollector.Variables.Add(Me.PulpFeedingGTWarningIn)
        Me.VarCollector.Variables.Add(Me.PulpFeedingGTWarningOut)
        Me.VarCollector.Variables.Add(Me.FormStartBubblePos)
        Me.VarCollector.Variables.Add(Me.ActPos)
        Me.VarCollector.Variables.Add(Me.PhyscalMeasuredPos)
        Me.VarCollector.Variables.Add(Me.mxAutoMode)
        '
        'PondDownStop
        '
        Me.PondDownStop.BindControl = Me.IO_MP_DownStop
        Me.PondDownStop.BindProperty = "Data"
        Me.PondDownStop.Data = Nothing
        Me.PondDownStop.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.PondDownStop.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PondDownStop.VariableName = "MAIN.InMoldDrying.MachParameters.ProductForming.MachinePond.PositionDownStop"
        '
        'IO_MP_DownStop
        '
        Me.IO_MP_DownStop.Audit = Nothing
        Me.IO_MP_DownStop.AuditEnabled = False
        Me.IO_MP_DownStop.AuditMessage = "KremerIoField changed:"
        Me.IO_MP_DownStop.AuditSource = "KremerIoField"
        Me.IO_MP_DownStop.BackColor = System.Drawing.Color.White
        Me.IO_MP_DownStop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_MP_DownStop.Data = 0.0R
        Me.IO_MP_DownStop.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_MP_DownStop.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_MP_DownStop.InitialValue = True
        Me.IO_MP_DownStop.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_MP_DownStop.Location = New System.Drawing.Point(274, 33)
        Me.IO_MP_DownStop.LowerBound = -5000.0R
        Me.IO_MP_DownStop.Name = "IO_MP_DownStop"
        Me.IO_MP_DownStop.OutputFormat = "0.0 mm"
        Me.IO_MP_DownStop.Size = New System.Drawing.Size(100, 22)
        Me.IO_MP_DownStop.TabIndex = 274
        Me.IO_MP_DownStop.Text = "0.0 mm"
        Me.IO_MP_DownStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_MP_DownStop.UpperBound = 5000.0R
        Me.IO_MP_DownStop.UserInfo = Nothing
        Me.IO_MP_DownStop.UserLevel = 0
        '
        'PondDownSlow
        '
        Me.PondDownSlow.BindControl = Me.IO_MP_DownSlow
        Me.PondDownSlow.BindProperty = "Data"
        Me.PondDownSlow.Data = Nothing
        Me.PondDownSlow.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.PondDownSlow.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PondDownSlow.VariableName = "MAIN.InMoldDrying.MachParameters.ProductForming.MachinePond.PositionDownSlow"
        '
        'IO_MP_DownSlow
        '
        Me.IO_MP_DownSlow.Audit = Nothing
        Me.IO_MP_DownSlow.AuditEnabled = False
        Me.IO_MP_DownSlow.AuditMessage = "KremerIoField changed:"
        Me.IO_MP_DownSlow.AuditSource = "KremerIoField"
        Me.IO_MP_DownSlow.BackColor = System.Drawing.Color.White
        Me.IO_MP_DownSlow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_MP_DownSlow.Data = 0.0R
        Me.IO_MP_DownSlow.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_MP_DownSlow.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_MP_DownSlow.InitialValue = True
        Me.IO_MP_DownSlow.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_MP_DownSlow.Location = New System.Drawing.Point(274, 56)
        Me.IO_MP_DownSlow.LowerBound = -5000.0R
        Me.IO_MP_DownSlow.Name = "IO_MP_DownSlow"
        Me.IO_MP_DownSlow.OutputFormat = "0.0 mm"
        Me.IO_MP_DownSlow.Size = New System.Drawing.Size(100, 22)
        Me.IO_MP_DownSlow.TabIndex = 289
        Me.IO_MP_DownSlow.Text = "0.0 mm"
        Me.IO_MP_DownSlow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_MP_DownSlow.UpperBound = 5000.0R
        Me.IO_MP_DownSlow.UserInfo = Nothing
        Me.IO_MP_DownSlow.UserLevel = 0
        '
        'PondUpStop
        '
        Me.PondUpStop.BindControl = Me.IO_MP_UpStop
        Me.PondUpStop.BindProperty = "Data"
        Me.PondUpStop.Data = Nothing
        Me.PondUpStop.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.PondUpStop.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PondUpStop.VariableName = "MAIN.InMoldDrying.MachParameters.ProductForming.MachinePond.PositionUpStop"
        '
        'IO_MP_UpStop
        '
        Me.IO_MP_UpStop.Audit = Nothing
        Me.IO_MP_UpStop.AuditEnabled = False
        Me.IO_MP_UpStop.AuditMessage = "KremerIoField changed:"
        Me.IO_MP_UpStop.AuditSource = "KremerIoField"
        Me.IO_MP_UpStop.BackColor = System.Drawing.Color.White
        Me.IO_MP_UpStop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_MP_UpStop.Data = 0.0R
        Me.IO_MP_UpStop.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_MP_UpStop.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_MP_UpStop.InitialValue = True
        Me.IO_MP_UpStop.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_MP_UpStop.Location = New System.Drawing.Point(274, 78)
        Me.IO_MP_UpStop.LowerBound = -5000.0R
        Me.IO_MP_UpStop.Name = "IO_MP_UpStop"
        Me.IO_MP_UpStop.OutputFormat = "0.0 mm"
        Me.IO_MP_UpStop.Size = New System.Drawing.Size(100, 22)
        Me.IO_MP_UpStop.TabIndex = 278
        Me.IO_MP_UpStop.Text = "0.0 mm"
        Me.IO_MP_UpStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_MP_UpStop.UpperBound = 5000.0R
        Me.IO_MP_UpStop.UserInfo = Nothing
        Me.IO_MP_UpStop.UserLevel = 0
        '
        'PondUpSlow
        '
        Me.PondUpSlow.BindControl = Me.IO_MP_UpSlow
        Me.PondUpSlow.BindProperty = "Data"
        Me.PondUpSlow.Data = Nothing
        Me.PondUpSlow.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.PondUpSlow.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PondUpSlow.VariableName = "MAIN.InMoldDrying.MachParameters.ProductForming.MachinePond.PositionUpSlow"
        '
        'IO_MP_UpSlow
        '
        Me.IO_MP_UpSlow.Audit = Nothing
        Me.IO_MP_UpSlow.AuditEnabled = False
        Me.IO_MP_UpSlow.AuditMessage = "KremerIoField changed:"
        Me.IO_MP_UpSlow.AuditSource = "KremerIoField"
        Me.IO_MP_UpSlow.BackColor = System.Drawing.Color.White
        Me.IO_MP_UpSlow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_MP_UpSlow.Data = 0.0R
        Me.IO_MP_UpSlow.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_MP_UpSlow.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_MP_UpSlow.InitialValue = True
        Me.IO_MP_UpSlow.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_MP_UpSlow.Location = New System.Drawing.Point(274, 101)
        Me.IO_MP_UpSlow.LowerBound = -5000.0R
        Me.IO_MP_UpSlow.Name = "IO_MP_UpSlow"
        Me.IO_MP_UpSlow.OutputFormat = "0.0 mm"
        Me.IO_MP_UpSlow.Size = New System.Drawing.Size(100, 22)
        Me.IO_MP_UpSlow.TabIndex = 316
        Me.IO_MP_UpSlow.Text = "0.0 mm"
        Me.IO_MP_UpSlow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_MP_UpSlow.UpperBound = 5000.0R
        Me.IO_MP_UpSlow.UserInfo = Nothing
        Me.IO_MP_UpSlow.UserLevel = 0
        '
        'PondOffsetSlow
        '
        Me.PondOffsetSlow.BindControl = Me.IO_MP_OffsetSlow
        Me.PondOffsetSlow.BindProperty = "Data"
        Me.PondOffsetSlow.Data = Nothing
        Me.PondOffsetSlow.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.PondOffsetSlow.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PondOffsetSlow.VariableName = "MAIN.InMoldDrying.MachParameters.ProductForming.MachinePond.PositionOffsetSlowRan" & _
    "ge"
        '
        'IO_MP_OffsetSlow
        '
        Me.IO_MP_OffsetSlow.Audit = Nothing
        Me.IO_MP_OffsetSlow.AuditEnabled = False
        Me.IO_MP_OffsetSlow.AuditMessage = "KremerIoField changed:"
        Me.IO_MP_OffsetSlow.AuditSource = "KremerIoField"
        Me.IO_MP_OffsetSlow.BackColor = System.Drawing.Color.White
        Me.IO_MP_OffsetSlow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_MP_OffsetSlow.Data = 0.0R
        Me.IO_MP_OffsetSlow.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_MP_OffsetSlow.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_MP_OffsetSlow.InitialValue = True
        Me.IO_MP_OffsetSlow.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_MP_OffsetSlow.Location = New System.Drawing.Point(274, 125)
        Me.IO_MP_OffsetSlow.LowerBound = -5000.0R
        Me.IO_MP_OffsetSlow.Name = "IO_MP_OffsetSlow"
        Me.IO_MP_OffsetSlow.OutputFormat = "0.0 mm"
        Me.IO_MP_OffsetSlow.Size = New System.Drawing.Size(100, 22)
        Me.IO_MP_OffsetSlow.TabIndex = 338
        Me.IO_MP_OffsetSlow.Text = "0.0 mm"
        Me.IO_MP_OffsetSlow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_MP_OffsetSlow.UpperBound = 5000.0R
        Me.IO_MP_OffsetSlow.UserInfo = Nothing
        Me.IO_MP_OffsetSlow.UserLevel = 0
        '
        'PondOffsetAlarm
        '
        Me.PondOffsetAlarm.BindControl = Me.IO_MP_OffsetAlarm
        Me.PondOffsetAlarm.BindProperty = "Data"
        Me.PondOffsetAlarm.Data = Nothing
        Me.PondOffsetAlarm.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.PondOffsetAlarm.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PondOffsetAlarm.VariableName = "MAIN.InMoldDrying.MachParameters.ProductForming.MachinePond.PositionOffsetAlarm"
        '
        'IO_MP_OffsetAlarm
        '
        Me.IO_MP_OffsetAlarm.Audit = Nothing
        Me.IO_MP_OffsetAlarm.AuditEnabled = False
        Me.IO_MP_OffsetAlarm.AuditMessage = "KremerIoField changed:"
        Me.IO_MP_OffsetAlarm.AuditSource = "KremerIoField"
        Me.IO_MP_OffsetAlarm.BackColor = System.Drawing.Color.White
        Me.IO_MP_OffsetAlarm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_MP_OffsetAlarm.Data = 0.0R
        Me.IO_MP_OffsetAlarm.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_MP_OffsetAlarm.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_MP_OffsetAlarm.InitialValue = True
        Me.IO_MP_OffsetAlarm.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_MP_OffsetAlarm.Location = New System.Drawing.Point(274, 147)
        Me.IO_MP_OffsetAlarm.LowerBound = -5000.0R
        Me.IO_MP_OffsetAlarm.Name = "IO_MP_OffsetAlarm"
        Me.IO_MP_OffsetAlarm.OutputFormat = "0.0 mm"
        Me.IO_MP_OffsetAlarm.Size = New System.Drawing.Size(100, 22)
        Me.IO_MP_OffsetAlarm.TabIndex = 337
        Me.IO_MP_OffsetAlarm.Text = "0.0 mm"
        Me.IO_MP_OffsetAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_MP_OffsetAlarm.UpperBound = 5000.0R
        Me.IO_MP_OffsetAlarm.UserInfo = Nothing
        Me.IO_MP_OffsetAlarm.UserLevel = 0
        '
        'FormVacTime
        '
        Me.FormVacTime.BindControl = Me.IO_1Vacuumtime
        Me.FormVacTime.BindProperty = "Data"
        Me.FormVacTime.Data = Nothing
        Me.FormVacTime.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.FormVacTime.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FormVacTime.VariableName = "MAIN.InMoldDrying.MachParameters.ProductForming.FormingMold.VacuumTime"
        '
        'IO_1Vacuumtime
        '
        Me.IO_1Vacuumtime.Audit = Nothing
        Me.IO_1Vacuumtime.AuditEnabled = False
        Me.IO_1Vacuumtime.AuditMessage = "KremerIoField changed:"
        Me.IO_1Vacuumtime.AuditSource = "KremerIoField"
        Me.IO_1Vacuumtime.BackColor = System.Drawing.Color.White
        Me.IO_1Vacuumtime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_1Vacuumtime.Data = 0.0R
        Me.IO_1Vacuumtime.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_1Vacuumtime.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_1Vacuumtime.InitialValue = True
        Me.IO_1Vacuumtime.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_1Vacuumtime.Location = New System.Drawing.Point(671, 103)
        Me.IO_1Vacuumtime.LowerBound = -5000.0R
        Me.IO_1Vacuumtime.Name = "IO_1Vacuumtime"
        Me.IO_1Vacuumtime.OutputFormat = "0.0 ms"
        Me.IO_1Vacuumtime.Size = New System.Drawing.Size(100, 22)
        Me.IO_1Vacuumtime.TabIndex = 387
        Me.IO_1Vacuumtime.Text = "0.0 ms"
        Me.IO_1Vacuumtime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_1Vacuumtime.UpperBound = 10000.0R
        Me.IO_1Vacuumtime.UserInfo = Nothing
        Me.IO_1Vacuumtime.UserLevel = 0
        '
        'FormBubbleTime
        '
        Me.FormBubbleTime.BindControl = Me.IO_FM_BubbleTime
        Me.FormBubbleTime.BindProperty = "Data"
        Me.FormBubbleTime.Data = Nothing
        Me.FormBubbleTime.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.FormBubbleTime.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FormBubbleTime.VariableName = "MAIN.InMoldDrying.MachParameters.ProductForming.FormingMold.BubbleTime"
        '
        'IO_FM_BubbleTime
        '
        Me.IO_FM_BubbleTime.Audit = Nothing
        Me.IO_FM_BubbleTime.AuditEnabled = False
        Me.IO_FM_BubbleTime.AuditMessage = "KremerIoField changed:"
        Me.IO_FM_BubbleTime.AuditSource = "KremerIoField"
        Me.IO_FM_BubbleTime.BackColor = System.Drawing.Color.White
        Me.IO_FM_BubbleTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_FM_BubbleTime.Data = 0.0R
        Me.IO_FM_BubbleTime.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_FM_BubbleTime.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_FM_BubbleTime.InitialValue = True
        Me.IO_FM_BubbleTime.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_FM_BubbleTime.Location = New System.Drawing.Point(671, 80)
        Me.IO_FM_BubbleTime.LowerBound = -5000.0R
        Me.IO_FM_BubbleTime.Name = "IO_FM_BubbleTime"
        Me.IO_FM_BubbleTime.OutputFormat = "0.0 ms"
        Me.IO_FM_BubbleTime.Size = New System.Drawing.Size(100, 22)
        Me.IO_FM_BubbleTime.TabIndex = 388
        Me.IO_FM_BubbleTime.Text = "0.0 ms"
        Me.IO_FM_BubbleTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_FM_BubbleTime.UpperBound = 5000.0R
        Me.IO_FM_BubbleTime.UserInfo = Nothing
        Me.IO_FM_BubbleTime.UserLevel = 0
        '
        'FormBlowOfftime
        '
        Me.FormBlowOfftime.BindControl = Me.IO_FM_BlowOffTime
        Me.FormBlowOfftime.BindProperty = "Data"
        Me.FormBlowOfftime.Data = Nothing
        Me.FormBlowOfftime.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.FormBlowOfftime.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FormBlowOfftime.VariableName = "MAIN.InMoldDrying.MachParameters.ProductForming.FormingMold.BlowOffTime"
        '
        'IO_FM_BlowOffTime
        '
        Me.IO_FM_BlowOffTime.Audit = Nothing
        Me.IO_FM_BlowOffTime.AuditEnabled = False
        Me.IO_FM_BlowOffTime.AuditMessage = "KremerIoField changed:"
        Me.IO_FM_BlowOffTime.AuditSource = "KremerIoField"
        Me.IO_FM_BlowOffTime.BackColor = System.Drawing.Color.White
        Me.IO_FM_BlowOffTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_FM_BlowOffTime.Data = 0.0R
        Me.IO_FM_BlowOffTime.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_FM_BlowOffTime.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_FM_BlowOffTime.InitialValue = True
        Me.IO_FM_BlowOffTime.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_FM_BlowOffTime.Location = New System.Drawing.Point(274, 280)
        Me.IO_FM_BlowOffTime.LowerBound = -5000.0R
        Me.IO_FM_BlowOffTime.Name = "IO_FM_BlowOffTime"
        Me.IO_FM_BlowOffTime.OutputFormat = "0.0 ms"
        Me.IO_FM_BlowOffTime.Size = New System.Drawing.Size(100, 22)
        Me.IO_FM_BlowOffTime.TabIndex = 393
        Me.IO_FM_BlowOffTime.Text = "0.0 ms"
        Me.IO_FM_BlowOffTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_FM_BlowOffTime.UpperBound = 5000.0R
        Me.IO_FM_BlowOffTime.UserInfo = Nothing
        Me.IO_FM_BlowOffTime.UserLevel = 0
        '
        'FormAfterblow
        '
        Me.FormAfterblow.BindControl = Me.IO_FM_BlowAfterTime
        Me.FormAfterblow.BindProperty = "Data"
        Me.FormAfterblow.Data = Nothing
        Me.FormAfterblow.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.FormAfterblow.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FormAfterblow.VariableName = "MAIN.InMoldDrying.MachParameters.ProductForming.FormingMold.AfterBlowOffTime"
        '
        'IO_FM_BlowAfterTime
        '
        Me.IO_FM_BlowAfterTime.Audit = Nothing
        Me.IO_FM_BlowAfterTime.AuditEnabled = False
        Me.IO_FM_BlowAfterTime.AuditMessage = "KremerIoField changed:"
        Me.IO_FM_BlowAfterTime.AuditSource = "KremerIoField"
        Me.IO_FM_BlowAfterTime.BackColor = System.Drawing.Color.White
        Me.IO_FM_BlowAfterTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_FM_BlowAfterTime.Data = 0.0R
        Me.IO_FM_BlowAfterTime.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_FM_BlowAfterTime.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_FM_BlowAfterTime.InitialValue = True
        Me.IO_FM_BlowAfterTime.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_FM_BlowAfterTime.Location = New System.Drawing.Point(274, 303)
        Me.IO_FM_BlowAfterTime.LowerBound = -5000.0R
        Me.IO_FM_BlowAfterTime.Name = "IO_FM_BlowAfterTime"
        Me.IO_FM_BlowAfterTime.OutputFormat = "0.0 ms"
        Me.IO_FM_BlowAfterTime.Size = New System.Drawing.Size(100, 22)
        Me.IO_FM_BlowAfterTime.TabIndex = 395
        Me.IO_FM_BlowAfterTime.Text = "0.0 ms"
        Me.IO_FM_BlowAfterTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_FM_BlowAfterTime.UpperBound = 5000.0R
        Me.IO_FM_BlowAfterTime.UserInfo = Nothing
        Me.IO_FM_BlowAfterTime.UserLevel = 0
        '
        'IO_2Vacuumtime
        '
        Me.IO_2Vacuumtime.Audit = Nothing
        Me.IO_2Vacuumtime.AuditEnabled = False
        Me.IO_2Vacuumtime.AuditMessage = "KremerIoField changed:"
        Me.IO_2Vacuumtime.AuditSource = "KremerIoField"
        Me.IO_2Vacuumtime.BackColor = System.Drawing.Color.White
        Me.IO_2Vacuumtime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_2Vacuumtime.Data = 0.0R
        Me.IO_2Vacuumtime.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_2Vacuumtime.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_2Vacuumtime.InitialValue = True
        Me.IO_2Vacuumtime.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_2Vacuumtime.Location = New System.Drawing.Point(671, 125)
        Me.IO_2Vacuumtime.LowerBound = 0.0R
        Me.IO_2Vacuumtime.Name = "IO_2Vacuumtime"
        Me.IO_2Vacuumtime.OutputFormat = "0.0 ms"
        Me.IO_2Vacuumtime.Size = New System.Drawing.Size(100, 22)
        Me.IO_2Vacuumtime.TabIndex = 401
        Me.IO_2Vacuumtime.Text = "0.0 ms"
        Me.IO_2Vacuumtime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_2Vacuumtime.UpperBound = 15000.0R
        Me.IO_2Vacuumtime.UserInfo = Nothing
        Me.IO_2Vacuumtime.UserLevel = 0
        '
        'PondUpWaitTime
        '
        Me.PondUpWaitTime.BindControl = Me.IO_MP_WaitTime
        Me.PondUpWaitTime.BindProperty = "Data"
        Me.PondUpWaitTime.Data = Nothing
        Me.PondUpWaitTime.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.PondUpWaitTime.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PondUpWaitTime.VariableName = "MAIN.InMoldDrying.MachParameters.ProductForming.MachinePond.PondUpWaitTime"
        '
        'IO_MP_WaitTime
        '
        Me.IO_MP_WaitTime.Audit = Nothing
        Me.IO_MP_WaitTime.AuditEnabled = False
        Me.IO_MP_WaitTime.AuditMessage = "KremerIoField changed:"
        Me.IO_MP_WaitTime.AuditSource = "KremerIoField"
        Me.IO_MP_WaitTime.BackColor = System.Drawing.Color.White
        Me.IO_MP_WaitTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_MP_WaitTime.Data = 0.0R
        Me.IO_MP_WaitTime.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_MP_WaitTime.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_MP_WaitTime.InitialValue = True
        Me.IO_MP_WaitTime.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_MP_WaitTime.Location = New System.Drawing.Point(671, 34)
        Me.IO_MP_WaitTime.LowerBound = -5000.0R
        Me.IO_MP_WaitTime.Name = "IO_MP_WaitTime"
        Me.IO_MP_WaitTime.OutputFormat = "0.0 ms"
        Me.IO_MP_WaitTime.Size = New System.Drawing.Size(100, 22)
        Me.IO_MP_WaitTime.TabIndex = 320
        Me.IO_MP_WaitTime.Text = "0.0 ms"
        Me.IO_MP_WaitTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_MP_WaitTime.UpperBound = 5000.0R
        Me.IO_MP_WaitTime.UserInfo = Nothing
        Me.IO_MP_WaitTime.UserLevel = 0
        '
        'PondFeedingPulpTime
        '
        Me.PondFeedingPulpTime.BindControl = Me.IO_MP_PulpTime
        Me.PondFeedingPulpTime.BindProperty = "Data"
        Me.PondFeedingPulpTime.Data = Nothing
        Me.PondFeedingPulpTime.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.PondFeedingPulpTime.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PondFeedingPulpTime.VariableName = "MAIN.InMoldDrying.MachParameters.ProductForming.MachinePond.FeedingPulpTime"
        '
        'IO_MP_PulpTime
        '
        Me.IO_MP_PulpTime.Audit = Nothing
        Me.IO_MP_PulpTime.AuditEnabled = False
        Me.IO_MP_PulpTime.AuditMessage = "KremerIoField changed:"
        Me.IO_MP_PulpTime.AuditSource = "KremerIoField"
        Me.IO_MP_PulpTime.BackColor = System.Drawing.Color.White
        Me.IO_MP_PulpTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_MP_PulpTime.Data = 0.0R
        Me.IO_MP_PulpTime.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_MP_PulpTime.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_MP_PulpTime.InitialValue = True
        Me.IO_MP_PulpTime.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_MP_PulpTime.Location = New System.Drawing.Point(671, 57)
        Me.IO_MP_PulpTime.LowerBound = -5000.0R
        Me.IO_MP_PulpTime.Name = "IO_MP_PulpTime"
        Me.IO_MP_PulpTime.OutputFormat = "0.0 ms"
        Me.IO_MP_PulpTime.Size = New System.Drawing.Size(100, 22)
        Me.IO_MP_PulpTime.TabIndex = 322
        Me.IO_MP_PulpTime.Text = "0.0 ms"
        Me.IO_MP_PulpTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_MP_PulpTime.UpperBound = 5000.0R
        Me.IO_MP_PulpTime.UserInfo = Nothing
        Me.IO_MP_PulpTime.UserLevel = 0
        '
        'PulpFeedingGTError
        '
        Me.PulpFeedingGTError.BindControl = Me.IO_PF_GTError
        Me.PulpFeedingGTError.BindProperty = "Data"
        Me.PulpFeedingGTError.Data = Nothing
        Me.PulpFeedingGTError.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.PulpFeedingGTError.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PulpFeedingGTError.VariableName = "MAIN.InMoldDrying.MachParameters.ProductForming.MachinePond.FeedingPulp.T_GuardTi" & _
    "meError"
        '
        'IO_PF_GTError
        '
        Me.IO_PF_GTError.Audit = Nothing
        Me.IO_PF_GTError.AuditEnabled = False
        Me.IO_PF_GTError.AuditMessage = "KremerIoField changed:"
        Me.IO_PF_GTError.AuditSource = "KremerIoField"
        Me.IO_PF_GTError.BackColor = System.Drawing.Color.White
        Me.IO_PF_GTError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_PF_GTError.Data = 0.0R
        Me.IO_PF_GTError.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_PF_GTError.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_PF_GTError.InitialValue = True
        Me.IO_PF_GTError.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_PF_GTError.Location = New System.Drawing.Point(671, 235)
        Me.IO_PF_GTError.LowerBound = -5000.0R
        Me.IO_PF_GTError.Name = "IO_PF_GTError"
        Me.IO_PF_GTError.OutputFormat = "0.0 ms"
        Me.IO_PF_GTError.Size = New System.Drawing.Size(100, 22)
        Me.IO_PF_GTError.TabIndex = 373
        Me.IO_PF_GTError.Text = "0.0 ms"
        Me.IO_PF_GTError.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_PF_GTError.UpperBound = 5000.0R
        Me.IO_PF_GTError.UserInfo = Nothing
        Me.IO_PF_GTError.UserLevel = 0
        '
        'PulpFeedingGTWarningIn
        '
        Me.PulpFeedingGTWarningIn.BindControl = Me.IO_PF_GTWarningIn
        Me.PulpFeedingGTWarningIn.BindProperty = "Data"
        Me.PulpFeedingGTWarningIn.Data = Nothing
        Me.PulpFeedingGTWarningIn.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.PulpFeedingGTWarningIn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PulpFeedingGTWarningIn.VariableName = "MAIN.InMoldDrying.MachParameters.ProductForming.MachinePond.FeedingPulp.T_GuardTi" & _
    "meWarning_IN"
        '
        'IO_PF_GTWarningIn
        '
        Me.IO_PF_GTWarningIn.Audit = Nothing
        Me.IO_PF_GTWarningIn.AuditEnabled = False
        Me.IO_PF_GTWarningIn.AuditMessage = "KremerIoField changed:"
        Me.IO_PF_GTWarningIn.AuditSource = "KremerIoField"
        Me.IO_PF_GTWarningIn.BackColor = System.Drawing.Color.White
        Me.IO_PF_GTWarningIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_PF_GTWarningIn.Data = 0.0R
        Me.IO_PF_GTWarningIn.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_PF_GTWarningIn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_PF_GTWarningIn.InitialValue = True
        Me.IO_PF_GTWarningIn.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_PF_GTWarningIn.Location = New System.Drawing.Point(671, 259)
        Me.IO_PF_GTWarningIn.LowerBound = -5000.0R
        Me.IO_PF_GTWarningIn.Name = "IO_PF_GTWarningIn"
        Me.IO_PF_GTWarningIn.OutputFormat = "0.0 ms"
        Me.IO_PF_GTWarningIn.Size = New System.Drawing.Size(100, 22)
        Me.IO_PF_GTWarningIn.TabIndex = 374
        Me.IO_PF_GTWarningIn.Text = "0.0 ms"
        Me.IO_PF_GTWarningIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_PF_GTWarningIn.UpperBound = 5000.0R
        Me.IO_PF_GTWarningIn.UserInfo = Nothing
        Me.IO_PF_GTWarningIn.UserLevel = 0
        '
        'PulpFeedingGTWarningOut
        '
        Me.PulpFeedingGTWarningOut.BindControl = Me.IO_PF_GTWarningOut
        Me.PulpFeedingGTWarningOut.BindProperty = "Data"
        Me.PulpFeedingGTWarningOut.Data = Nothing
        Me.PulpFeedingGTWarningOut.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.PulpFeedingGTWarningOut.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PulpFeedingGTWarningOut.VariableName = "MAIN.InMoldDrying.MachParameters.ProductForming.MachinePond.FeedingPulp.T_GuardTi" & _
    "meWarning_OUT"
        '
        'IO_PF_GTWarningOut
        '
        Me.IO_PF_GTWarningOut.Audit = Nothing
        Me.IO_PF_GTWarningOut.AuditEnabled = False
        Me.IO_PF_GTWarningOut.AuditMessage = "KremerIoField changed:"
        Me.IO_PF_GTWarningOut.AuditSource = "KremerIoField"
        Me.IO_PF_GTWarningOut.BackColor = System.Drawing.Color.White
        Me.IO_PF_GTWarningOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_PF_GTWarningOut.Data = 0.0R
        Me.IO_PF_GTWarningOut.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_PF_GTWarningOut.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_PF_GTWarningOut.InitialValue = True
        Me.IO_PF_GTWarningOut.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_PF_GTWarningOut.Location = New System.Drawing.Point(671, 282)
        Me.IO_PF_GTWarningOut.LowerBound = -5000.0R
        Me.IO_PF_GTWarningOut.Name = "IO_PF_GTWarningOut"
        Me.IO_PF_GTWarningOut.OutputFormat = "0.0 ms"
        Me.IO_PF_GTWarningOut.Size = New System.Drawing.Size(100, 22)
        Me.IO_PF_GTWarningOut.TabIndex = 375
        Me.IO_PF_GTWarningOut.Text = "0.0 ms"
        Me.IO_PF_GTWarningOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_PF_GTWarningOut.UpperBound = 5000.0R
        Me.IO_PF_GTWarningOut.UserInfo = Nothing
        Me.IO_PF_GTWarningOut.UserLevel = 0
        '
        'ActPos
        '
        Me.ActPos.BindControl = Me.IO_MP_Pos
        Me.ActPos.BindProperty = "Data"
        Me.ActPos.Data = Nothing
        Me.ActPos.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.ActPos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ActPos.VariableName = "MAIN.InMoldDrying.ProductForming.PondHydraulicCilinder.ActPosition"
        '
        'IO_MP_Pos
        '
        Me.IO_MP_Pos.Audit = Nothing
        Me.IO_MP_Pos.AuditEnabled = False
        Me.IO_MP_Pos.AuditMessage = "KremerIoField changed:"
        Me.IO_MP_Pos.AuditSource = "KremerIoField"
        Me.IO_MP_Pos.Data = 0.0R
        Me.IO_MP_Pos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_MP_Pos.InitialValue = True
        Me.IO_MP_Pos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_MP_Pos.Location = New System.Drawing.Point(306, 7)
        Me.IO_MP_Pos.LowerBound = 0.0R
        Me.IO_MP_Pos.Name = "IO_MP_Pos"
        Me.IO_MP_Pos.OutputFormat = "0.0 mm"
        Me.IO_MP_Pos.Size = New System.Drawing.Size(71, 21)
        Me.IO_MP_Pos.TabIndex = 334
        Me.IO_MP_Pos.Text = "0,0 mm"
        Me.IO_MP_Pos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IO_MP_Pos.UpperBound = 1000.0R
        Me.IO_MP_Pos.UserInfo = Nothing
        Me.IO_MP_Pos.UserLevel = 0
        '
        'PhyscalMeasuredPos
        '
        Me.PhyscalMeasuredPos.BindControl = Me.IO_PhysicalMeasuredPos
        Me.PhyscalMeasuredPos.BindProperty = "Data"
        Me.PhyscalMeasuredPos.Data = Nothing
        Me.PhyscalMeasuredPos.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.PhyscalMeasuredPos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PhyscalMeasuredPos.VariableName = "MAIN.InMoldDrying.MachParameters.ProductForming.MachinePond.PositionPhyscialMeasu" & _
    "red"
        '
        'IO_PhysicalMeasuredPos
        '
        Me.IO_PhysicalMeasuredPos.Audit = Nothing
        Me.IO_PhysicalMeasuredPos.AuditEnabled = False
        Me.IO_PhysicalMeasuredPos.AuditMessage = "KremerIoField changed:"
        Me.IO_PhysicalMeasuredPos.AuditSource = "KremerIoField"
        Me.IO_PhysicalMeasuredPos.BackColor = System.Drawing.Color.White
        Me.IO_PhysicalMeasuredPos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_PhysicalMeasuredPos.Data = 0.0R
        Me.IO_PhysicalMeasuredPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_PhysicalMeasuredPos.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_PhysicalMeasuredPos.InitialValue = True
        Me.IO_PhysicalMeasuredPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_PhysicalMeasuredPos.Location = New System.Drawing.Point(274, 170)
        Me.IO_PhysicalMeasuredPos.LowerBound = -10000.0R
        Me.IO_PhysicalMeasuredPos.Name = "IO_PhysicalMeasuredPos"
        Me.IO_PhysicalMeasuredPos.OutputFormat = "0.0 mm"
        Me.IO_PhysicalMeasuredPos.Size = New System.Drawing.Size(100, 22)
        Me.IO_PhysicalMeasuredPos.TabIndex = 397
        Me.IO_PhysicalMeasuredPos.Text = "0.0 mm"
        Me.IO_PhysicalMeasuredPos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_PhysicalMeasuredPos.UpperBound = 10000.0R
        Me.IO_PhysicalMeasuredPos.UserInfo = Nothing
        Me.IO_PhysicalMeasuredPos.UserLevel = 0
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
        Me.Btn_Overview.Location = New System.Drawing.Point(683, 326)
        Me.Btn_Overview.Name = "Btn_Overview"
        Me.Btn_Overview.Size = New System.Drawing.Size(114, 50)
        Me.Btn_Overview.State = False
        Me.Btn_Overview.StateIsData = True
        Me.Btn_Overview.StateText = New String() {Nothing, Nothing}
        Me.Btn_Overview.TabIndex = 242
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
        Me.Btn_Manual.Location = New System.Drawing.Point(683, 382)
        Me.Btn_Manual.Name = "Btn_Manual"
        Me.Btn_Manual.Size = New System.Drawing.Size(114, 50)
        Me.Btn_Manual.State = False
        Me.Btn_Manual.StateIsData = True
        Me.Btn_Manual.StateText = New String() {Nothing, Nothing}
        Me.Btn_Manual.TabIndex = 241
        Me.Btn_Manual.Tag = "192"
        Me.Btn_Manual.Text = "Manual Control"
        Me.Btn_Manual.UserInfo = Nothing
        Me.Btn_Manual.UserLevel = 0
        Me.Btn_Manual.UseStateText = False
        Me.Btn_Manual.UseVisualStyleBackColor = True
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 25
        Me.LineShape4.X2 = 375
        Me.LineShape4.Y1 = 30
        Me.LineShape4.Y2 = 30
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape10, Me.LineShape9, Me.LineShape6, Me.LineShape5, Me.LineShape3, Me.LineShape2, Me.LineShape1, Me.LineShape4})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 435)
        Me.ShapeContainer1.TabIndex = 272
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape10
        '
        Me.LineShape10.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape10.Name = "LineShape10"
        Me.LineShape10.X1 = 26
        Me.LineShape10.X2 = 376
        Me.LineShape10.Y1 = 272
        Me.LineShape10.Y2 = 272
        '
        'LineShape9
        '
        Me.LineShape9.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape9.Name = "LineShape9"
        Me.LineShape9.X1 = 271
        Me.LineShape9.X2 = 271
        Me.LineShape9.Y1 = 272
        Me.LineShape9.Y2 = 430
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 421
        Me.LineShape6.X2 = 771
        Me.LineShape6.Y1 = 232
        Me.LineShape6.Y2 = 232
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 666
        Me.LineShape5.X2 = 666
        Me.LineShape5.Y1 = 232
        Me.LineShape5.Y2 = 312
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 422
        Me.LineShape3.X2 = 772
        Me.LineShape3.Y1 = 30
        Me.LineShape3.Y2 = 30
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 667
        Me.LineShape2.X2 = 667
        Me.LineShape2.Y1 = 30
        Me.LineShape2.Y2 = 175
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 270
        Me.LineShape1.X2 = 270
        Me.LineShape1.Y1 = 30
        Me.LineShape1.Y2 = 227
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 23)
        Me.Label2.TabIndex = 276
        Me.Label2.Tag = "303"
        Me.Label2.Text = "Machine pond up stop"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 23)
        Me.Label1.TabIndex = 275
        Me.Label1.Tag = "301"
        Me.Label1.Text = "Machine pond down stop"
        '
        'lbl_puh
        '
        Me.lbl_puh.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_puh.Location = New System.Drawing.Point(21, 7)
        Me.lbl_puh.Name = "lbl_puh"
        Me.lbl_puh.Size = New System.Drawing.Size(273, 23)
        Me.lbl_puh.TabIndex = 273
        Me.lbl_puh.Tag = "300"
        Me.lbl_puh.Text = "Machine pond positions"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(247, 23)
        Me.Label9.TabIndex = 290
        Me.Label9.Tag = "302"
        Me.Label9.Text = "Machine pond down slow"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(21, 103)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(247, 23)
        Me.Label22.TabIndex = 315
        Me.Label22.Tag = "304"
        Me.Label22.Text = "Machine pond up slow"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(418, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 23)
        Me.Label3.TabIndex = 319
        Me.Label3.Tag = "320"
        Me.Label3.Text = "Timing:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(418, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(247, 23)
        Me.Label6.TabIndex = 327
        Me.Label6.Tag = "322"
        Me.Label6.Text = "Feeding pulp time"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(418, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(247, 23)
        Me.Label8.TabIndex = 325
        Me.Label8.Tag = "321"
        Me.Label8.Text = "Pond up wait time"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 23)
        Me.Label4.TabIndex = 335
        Me.Label4.Tag = "305"
        Me.Label4.Text = "Position offset slow range"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 23)
        Me.Label5.TabIndex = 336
        Me.Label5.Tag = "306"
        Me.Label5.Text = "Position offset alarm range"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(418, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(247, 23)
        Me.Label7.TabIndex = 378
        Me.Label7.Tag = "173"
        Me.Label7.Text = "Guard time warning out"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(418, 262)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(247, 23)
        Me.Label10.TabIndex = 377
        Me.Label10.Tag = "172"
        Me.Label10.Text = "Guard time warning in"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(418, 238)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(247, 23)
        Me.Label18.TabIndex = 376
        Me.Label18.Tag = "171"
        Me.Label18.Text = "Guard time error"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.Location = New System.Drawing.Point(418, 208)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(353, 23)
        Me.Label21.TabIndex = 372
        Me.Label21.Tag = "326"
        Me.Label21.Text = "Timing pulp feeding valve"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(21, 304)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(247, 23)
        Me.Label15.TabIndex = 396
        Me.Label15.Tag = "315"
        Me.Label15.Text = "Forming mold after blow time"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(21, 281)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(247, 23)
        Me.Label16.TabIndex = 394
        Me.Label16.Tag = "314"
        Me.Label16.Text = "Forming mold blow off time"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(418, 81)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(247, 23)
        Me.Label20.TabIndex = 391
        Me.Label20.Tag = "313"
        Me.Label20.Text = "Forming mold bubble time"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(418, 104)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(247, 23)
        Me.Label23.TabIndex = 390
        Me.Label23.Tag = ""
        Me.Label23.Text = "1st vacuum time (forming)"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label24.Location = New System.Drawing.Point(22, 247)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(273, 23)
        Me.Label24.TabIndex = 386
        Me.Label24.Tag = "310"
        Me.Label24.Text = "Forming mold settings"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(21, 173)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(247, 23)
        Me.Label19.TabIndex = 398
        Me.Label19.Tag = ""
        Me.Label19.Text = "Physical measured position"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(417, 126)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(247, 23)
        Me.Label25.TabIndex = 399
        Me.Label25.Tag = "382"
        Me.Label25.Text = "2nd vacuum time"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(418, 147)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(160, 23)
        Me.Label17.TabIndex = 402
        Me.Label17.Tag = "382"
        Me.Label17.Text = "3th vacuum time"
        '
        'IO_3Vacuumtime
        '
        Me.IO_3Vacuumtime.Audit = Nothing
        Me.IO_3Vacuumtime.AuditEnabled = False
        Me.IO_3Vacuumtime.AuditMessage = "KremerIoField changed:"
        Me.IO_3Vacuumtime.AuditSource = "KremerIoField"
        Me.IO_3Vacuumtime.BackColor = System.Drawing.SystemColors.Control
        Me.IO_3Vacuumtime.Data = 0.0R
        Me.IO_3Vacuumtime.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_3Vacuumtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IO_3Vacuumtime.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_3Vacuumtime.InitialValue = True
        Me.IO_3Vacuumtime.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_3Vacuumtime.Location = New System.Drawing.Point(671, 148)
        Me.IO_3Vacuumtime.LowerBound = 0.0R
        Me.IO_3Vacuumtime.Name = "IO_3Vacuumtime"
        Me.IO_3Vacuumtime.OutputFormat = "0.0 ms"
        Me.IO_3Vacuumtime.Size = New System.Drawing.Size(100, 22)
        Me.IO_3Vacuumtime.TabIndex = 403
        Me.IO_3Vacuumtime.Text = "0.0 ms"
        Me.IO_3Vacuumtime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_3Vacuumtime.UpperBound = 15000.0R
        Me.IO_3Vacuumtime.UserInfo = Nothing
        Me.IO_3Vacuumtime.UserLevel = 0
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(21, 194)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(247, 23)
        Me.Label26.TabIndex = 404
        Me.Label26.Tag = "313"
        Me.Label26.Text = "Pond offset for bubble start"
        '
        'IO_PondPosForBubbleStart
        '
        Me.IO_PondPosForBubbleStart.Audit = Nothing
        Me.IO_PondPosForBubbleStart.AuditEnabled = False
        Me.IO_PondPosForBubbleStart.AuditMessage = "KremerIoField changed:"
        Me.IO_PondPosForBubbleStart.AuditSource = "KremerIoField"
        Me.IO_PondPosForBubbleStart.BackColor = System.Drawing.Color.White
        Me.IO_PondPosForBubbleStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_PondPosForBubbleStart.Data = 0.0R
        Me.IO_PondPosForBubbleStart.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_PondPosForBubbleStart.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_PondPosForBubbleStart.InitialValue = True
        Me.IO_PondPosForBubbleStart.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_PondPosForBubbleStart.Location = New System.Drawing.Point(274, 193)
        Me.IO_PondPosForBubbleStart.LowerBound = -10000.0R
        Me.IO_PondPosForBubbleStart.Name = "IO_PondPosForBubbleStart"
        Me.IO_PondPosForBubbleStart.OutputFormat = "0.0 mm"
        Me.IO_PondPosForBubbleStart.Size = New System.Drawing.Size(100, 22)
        Me.IO_PondPosForBubbleStart.TabIndex = 405
        Me.IO_PondPosForBubbleStart.Text = "0.0 mm"
        Me.IO_PondPosForBubbleStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_PondPosForBubbleStart.UpperBound = 10000.0R
        Me.IO_PondPosForBubbleStart.UserInfo = Nothing
        Me.IO_PondPosForBubbleStart.UserLevel = 0
        '
        'Form2ndVacTime
        '
        Me.Form2ndVacTime.BindControl = Me.IO_2Vacuumtime
        Me.Form2ndVacTime.BindProperty = "Data"
        Me.Form2ndVacTime.Data = Nothing
        Me.Form2ndVacTime.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.Form2ndVacTime.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Form2ndVacTime.VariableName = "MAIN.InMoldDrying.MachParameters.ProductForming.FormingMold.SecondVacuum"
        '
        'Form3thVacTime
        '
        Me.Form3thVacTime.BindControl = Me.IO_3Vacuumtime
        Me.Form3thVacTime.BindProperty = "Data"
        Me.Form3thVacTime.Data = Nothing
        Me.Form3thVacTime.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.Form3thVacTime.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Form3thVacTime.VariableName = "MAIN.InMoldDrying.MachParameters.ProductForming.FormingMold.ThirdVacuum"
        '
        'FormStartBubblePos
        '
        Me.FormStartBubblePos.BindControl = Me.IO_PondPosForBubbleStart
        Me.FormStartBubblePos.BindProperty = "Data"
        Me.FormStartBubblePos.Data = Nothing
        Me.FormStartBubblePos.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.FormStartBubblePos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FormStartBubblePos.VariableName = "MAIN.InMoldDrying.MachParameters.ProductForming.MachinePond.BubblingPositionOffse" & _
    "t"
        '
        'MachinePond_Settings_New
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.IO_PondPosForBubbleStart)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.IO_3Vacuumtime)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.IO_2Vacuumtime)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.IO_PhysicalMeasuredPos)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.IO_FM_BlowAfterTime)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.IO_FM_BlowOffTime)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.IO_FM_BubbleTime)
        Me.Controls.Add(Me.IO_1Vacuumtime)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.IO_PF_GTWarningOut)
        Me.Controls.Add(Me.IO_PF_GTWarningIn)
        Me.Controls.Add(Me.IO_PF_GTError)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.IO_MP_OffsetSlow)
        Me.Controls.Add(Me.IO_MP_OffsetAlarm)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.IO_MP_Pos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.IO_MP_PulpTime)
        Me.Controls.Add(Me.IO_MP_WaitTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IO_MP_UpSlow)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.IO_MP_DownSlow)
        Me.Controls.Add(Me.IO_MP_UpStop)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IO_MP_DownStop)
        Me.Controls.Add(Me.lbl_puh)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Controls.Add(Me.Btn_Manual)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "MachinePond_Settings_New"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "88"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_Manual As KremerControlsWin32.KremerButton
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents IO_MP_UpStop As KremerControlsWin32.KremerIoField
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IO_MP_DownStop As KremerControlsWin32.KremerIoField
    Friend WithEvents lbl_puh As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents IO_MP_DownSlow As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_MP_UpSlow As KremerControlsWin32.KremerIoField
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents IO_MP_PulpTime As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_MP_WaitTime As KremerControlsWin32.KremerIoField
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents IO_MP_Pos As KremerControlsWin32.KremerIoField
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents IO_MP_OffsetSlow As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_MP_OffsetAlarm As KremerControlsWin32.KremerIoField
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents IO_PF_GTWarningOut As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_PF_GTWarningIn As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_PF_GTError As KremerControlsWin32.KremerIoField
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents LineShape10 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape9 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents IO_FM_BlowAfterTime As KremerControlsWin32.KremerIoField
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents IO_FM_BlowOffTime As KremerControlsWin32.KremerIoField
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents IO_FM_BubbleTime As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_1Vacuumtime As KremerControlsWin32.KremerIoField
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents PondDownStop As KremerControlsWin32.KremerVariable
    Friend WithEvents PondDownSlow As KremerControlsWin32.KremerVariable
    Friend WithEvents PondUpStop As KremerControlsWin32.KremerVariable
    Friend WithEvents PondUpSlow As KremerControlsWin32.KremerVariable
    Friend WithEvents PondOffsetSlow As KremerControlsWin32.KremerVariable
    Friend WithEvents PondOffsetAlarm As KremerControlsWin32.KremerVariable
    Friend WithEvents FormVacTime As KremerControlsWin32.KremerVariable
    Friend WithEvents FormBubbleTime As KremerControlsWin32.KremerVariable
    Friend WithEvents FormBlowOfftime As KremerControlsWin32.KremerVariable
    Friend WithEvents FormAfterblow As KremerControlsWin32.KremerVariable
    Friend WithEvents PondUpWaitTime As KremerControlsWin32.KremerVariable
    Friend WithEvents PondFeedingPulpTime As KremerControlsWin32.KremerVariable
    Friend WithEvents PulpFeedingGTError As KremerControlsWin32.KremerVariable
    Friend WithEvents PulpFeedingGTWarningIn As KremerControlsWin32.KremerVariable
    Friend WithEvents PulpFeedingGTWarningOut As KremerControlsWin32.KremerVariable
    Friend WithEvents ActPos As KremerControlsWin32.KremerVariable
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents IO_PhysicalMeasuredPos As KremerControlsWin32.KremerIoField
    Friend WithEvents PhyscalMeasuredPos As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_2Vacuumtime As KremerControlsWin32.KremerIoField
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents mxAutoMode As KremerControlsWin32.KremerVariable
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents IO_3Vacuumtime As KremerControlsWin32.KremerIoField
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents IO_PondPosForBubbleStart As KremerControlsWin32.KremerIoField
    Friend WithEvents Form2ndVacTime As KremerControlsWin32.KremerVariable
    Friend WithEvents Form3thVacTime As KremerControlsWin32.KremerVariable
    Friend WithEvents FormStartBubblePos As KremerControlsWin32.KremerVariable

End Class
