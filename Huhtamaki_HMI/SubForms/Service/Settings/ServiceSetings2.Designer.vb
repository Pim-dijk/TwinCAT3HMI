<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiceSettings2
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
        Me.krConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.krVarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.StrokeAReset = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_ResetStrokeA = New KremerControlsWin32.KremerButton()
        Me.StrokeBReset = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_ResetStrokeB = New KremerControlsWin32.KremerButton()
        Me.GreasingStartA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnMoveToGreasingA = New KremerControlsWin32.KremerButton()
        Me.GreasingStartB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnMoveToGreasingB = New KremerControlsWin32.KremerButton()
        Me.GreasingPosA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_GreasingPosA = New KremerControlsWin32.KremerIoField(Me.components)
        Me.GreasingPosB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_GreasingPosb = New KremerControlsWin32.KremerIoField(Me.components)
        Me.GreasingVeloA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_GreasingVeloA = New KremerControlsWin32.KremerIoField(Me.components)
        Me.GreasingVeloB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_GreasingVeloB = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Settings = New System.Windows.Forms.Button()
        Me.Btn_Settings2 = New System.Windows.Forms.Button()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.IO_StrokesA = New KremerControlsWin32.KremerIoField(Me.components)
        Me.IO_StrokesB = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.NrStrokesA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.NrStrokesB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'krConnector
        '
        Me.krConnector.VarCollector = Nothing
        '
        'krVarCollector
        '
        Me.krVarCollector.Variables.Add(Me.StrokeAReset)
        Me.krVarCollector.Variables.Add(Me.StrokeBReset)
        Me.krVarCollector.Variables.Add(Me.GreasingStartA)
        Me.krVarCollector.Variables.Add(Me.GreasingStartB)
        Me.krVarCollector.Variables.Add(Me.GreasingPosA)
        Me.krVarCollector.Variables.Add(Me.GreasingPosB)
        Me.krVarCollector.Variables.Add(Me.GreasingVeloA)
        Me.krVarCollector.Variables.Add(Me.GreasingVeloB)
        Me.krVarCollector.Variables.Add(Me.NrStrokesA)
        Me.krVarCollector.Variables.Add(Me.NrStrokesB)
        '
        'StrokeAReset
        '
        Me.StrokeAReset.BindControl = Me.Btn_ResetStrokeA
        Me.StrokeAReset.BindProperty = "Data"
        Me.StrokeAReset.Data = Nothing
        Me.StrokeAReset.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.StrokeAReset.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StrokeAReset.VariableName = "MAIN.InMoldDrying.BottomMoldA.mxResetBotStroke"
        '
        'Btn_ResetStrokeA
        '
        Me.Btn_ResetStrokeA.Audit = Nothing
        Me.Btn_ResetStrokeA.AuditEnabled = False
        Me.Btn_ResetStrokeA.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_ResetStrokeA.AuditSource = "KremerPushButton"
        Me.Btn_ResetStrokeA.BackColorOn = System.Drawing.Color.Blue
        Me.Btn_ResetStrokeA.BackGroundImageOn = Nothing
        Me.Btn_ResetStrokeA.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_ResetStrokeA.Data = False
        Me.Btn_ResetStrokeA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ResetStrokeA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ResetStrokeA.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_ResetStrokeA.Location = New System.Drawing.Point(669, 48)
        Me.Btn_ResetStrokeA.Name = "Btn_ResetStrokeA"
        Me.Btn_ResetStrokeA.Size = New System.Drawing.Size(104, 47)
        Me.Btn_ResetStrokeA.State = False
        Me.Btn_ResetStrokeA.StateIsData = False
        Me.Btn_ResetStrokeA.StateText = New String() {Nothing, Nothing}
        Me.Btn_ResetStrokeA.TabIndex = 415
        Me.Btn_ResetStrokeA.Text = "Reset"
        Me.Btn_ResetStrokeA.UserInfo = Nothing
        Me.Btn_ResetStrokeA.UserLevel = 0
        Me.Btn_ResetStrokeA.UseStateText = False
        Me.Btn_ResetStrokeA.UseVisualStyleBackColor = False
        '
        'StrokeBReset
        '
        Me.StrokeBReset.BindControl = Me.Btn_ResetStrokeB
        Me.StrokeBReset.BindProperty = "Data"
        Me.StrokeBReset.Data = Nothing
        Me.StrokeBReset.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.StrokeBReset.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StrokeBReset.VariableName = "MAIN.InMoldDrying.BottomMoldB.mxResetBotStroke"
        '
        'Btn_ResetStrokeB
        '
        Me.Btn_ResetStrokeB.Audit = Nothing
        Me.Btn_ResetStrokeB.AuditEnabled = False
        Me.Btn_ResetStrokeB.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_ResetStrokeB.AuditSource = "KremerPushButton"
        Me.Btn_ResetStrokeB.BackColorOn = System.Drawing.Color.Blue
        Me.Btn_ResetStrokeB.BackGroundImageOn = Nothing
        Me.Btn_ResetStrokeB.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_ResetStrokeB.Data = False
        Me.Btn_ResetStrokeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ResetStrokeB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ResetStrokeB.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_ResetStrokeB.Location = New System.Drawing.Point(669, 172)
        Me.Btn_ResetStrokeB.Name = "Btn_ResetStrokeB"
        Me.Btn_ResetStrokeB.Size = New System.Drawing.Size(104, 47)
        Me.Btn_ResetStrokeB.State = False
        Me.Btn_ResetStrokeB.StateIsData = False
        Me.Btn_ResetStrokeB.StateText = New String() {Nothing, Nothing}
        Me.Btn_ResetStrokeB.TabIndex = 420
        Me.Btn_ResetStrokeB.Text = "Reset"
        Me.Btn_ResetStrokeB.UserInfo = Nothing
        Me.Btn_ResetStrokeB.UserLevel = 0
        Me.Btn_ResetStrokeB.UseStateText = False
        Me.Btn_ResetStrokeB.UseVisualStyleBackColor = False
        '
        'GreasingStartA
        '
        Me.GreasingStartA.BindControl = Me.BtnMoveToGreasingA
        Me.GreasingStartA.BindProperty = "Data"
        Me.GreasingStartA.Data = Nothing
        Me.GreasingStartA.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GreasingStartA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GreasingStartA.VariableName = "MAIN.InMoldDrying.BottomMoldA.mxHMI_MoveToGreasingPos"
        '
        'BtnMoveToGreasingA
        '
        Me.BtnMoveToGreasingA.Audit = Nothing
        Me.BtnMoveToGreasingA.AuditEnabled = False
        Me.BtnMoveToGreasingA.AuditMessage = "KremerPushButton pressed!"
        Me.BtnMoveToGreasingA.AuditSource = "KremerPushButton"
        Me.BtnMoveToGreasingA.BackColorOn = System.Drawing.Color.Blue
        Me.BtnMoveToGreasingA.BackGroundImageOn = Nothing
        Me.BtnMoveToGreasingA.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnMoveToGreasingA.Data = False
        Me.BtnMoveToGreasingA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMoveToGreasingA.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMoveToGreasingA.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnMoveToGreasingA.Location = New System.Drawing.Point(281, 46)
        Me.BtnMoveToGreasingA.Name = "BtnMoveToGreasingA"
        Me.BtnMoveToGreasingA.Size = New System.Drawing.Size(104, 47)
        Me.BtnMoveToGreasingA.State = False
        Me.BtnMoveToGreasingA.StateIsData = False
        Me.BtnMoveToGreasingA.StateText = New String() {Nothing, Nothing}
        Me.BtnMoveToGreasingA.TabIndex = 382
        Me.BtnMoveToGreasingA.Text = "Start"
        Me.BtnMoveToGreasingA.UserInfo = Nothing
        Me.BtnMoveToGreasingA.UserLevel = 0
        Me.BtnMoveToGreasingA.UseStateText = False
        Me.BtnMoveToGreasingA.UseVisualStyleBackColor = False
        '
        'GreasingStartB
        '
        Me.GreasingStartB.BindControl = Me.BtnMoveToGreasingB
        Me.GreasingStartB.BindProperty = "Data"
        Me.GreasingStartB.Data = Nothing
        Me.GreasingStartB.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GreasingStartB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GreasingStartB.VariableName = "MAIN.InMoldDrying.BottomMoldB.mxHMI_MoveToGreasingPos"
        '
        'BtnMoveToGreasingB
        '
        Me.BtnMoveToGreasingB.Audit = Nothing
        Me.BtnMoveToGreasingB.AuditEnabled = False
        Me.BtnMoveToGreasingB.AuditMessage = "KremerPushButton pressed!"
        Me.BtnMoveToGreasingB.AuditSource = "KremerPushButton"
        Me.BtnMoveToGreasingB.BackColorOn = System.Drawing.Color.Blue
        Me.BtnMoveToGreasingB.BackGroundImageOn = Nothing
        Me.BtnMoveToGreasingB.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnMoveToGreasingB.Data = False
        Me.BtnMoveToGreasingB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMoveToGreasingB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMoveToGreasingB.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnMoveToGreasingB.Location = New System.Drawing.Point(281, 167)
        Me.BtnMoveToGreasingB.Name = "BtnMoveToGreasingB"
        Me.BtnMoveToGreasingB.Size = New System.Drawing.Size(104, 47)
        Me.BtnMoveToGreasingB.State = False
        Me.BtnMoveToGreasingB.StateIsData = False
        Me.BtnMoveToGreasingB.StateText = New String() {Nothing, Nothing}
        Me.BtnMoveToGreasingB.TabIndex = 410
        Me.BtnMoveToGreasingB.Text = "Start"
        Me.BtnMoveToGreasingB.UserInfo = Nothing
        Me.BtnMoveToGreasingB.UserLevel = 0
        Me.BtnMoveToGreasingB.UseStateText = False
        Me.BtnMoveToGreasingB.UseVisualStyleBackColor = False
        '
        'GreasingPosA
        '
        Me.GreasingPosA.BindControl = Me.IO_GreasingPosA
        Me.GreasingPosA.BindProperty = "Data"
        Me.GreasingPosA.Data = Nothing
        Me.GreasingPosA.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.GreasingPosA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GreasingPosA.VariableName = "MAIN.MachPar.InMoldDrying.BottomMoldA.GreasingPosition"
        '
        'IO_GreasingPosA
        '
        Me.IO_GreasingPosA.Audit = Nothing
        Me.IO_GreasingPosA.AuditEnabled = False
        Me.IO_GreasingPosA.AuditMessage = "KremerIoField changed:"
        Me.IO_GreasingPosA.AuditSource = "KremerIoField"
        Me.IO_GreasingPosA.BackColor = System.Drawing.Color.White
        Me.IO_GreasingPosA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_GreasingPosA.Data = 0.0R
        Me.IO_GreasingPosA.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_GreasingPosA.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_GreasingPosA.InitialValue = True
        Me.IO_GreasingPosA.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_GreasingPosA.Location = New System.Drawing.Point(281, 96)
        Me.IO_GreasingPosA.LowerBound = 0.0R
        Me.IO_GreasingPosA.Name = "IO_GreasingPosA"
        Me.IO_GreasingPosA.OutputFormat = "0.0 mm"
        Me.IO_GreasingPosA.Size = New System.Drawing.Size(104, 22)
        Me.IO_GreasingPosA.TabIndex = 408
        Me.IO_GreasingPosA.Text = "0.0 mm"
        Me.IO_GreasingPosA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_GreasingPosA.UpperBound = 1000.0R
        Me.IO_GreasingPosA.UserInfo = Nothing
        Me.IO_GreasingPosA.UserLevel = 500
        '
        'GreasingPosB
        '
        Me.GreasingPosB.BindControl = Me.IO_GreasingPosb
        Me.GreasingPosB.BindProperty = "Data"
        Me.GreasingPosB.Data = Nothing
        Me.GreasingPosB.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.GreasingPosB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GreasingPosB.VariableName = "MAIN.MachPar.InMoldDrying.BottomMoldB.GreasingPosition"
        '
        'IO_GreasingPosb
        '
        Me.IO_GreasingPosb.Audit = Nothing
        Me.IO_GreasingPosb.AuditEnabled = False
        Me.IO_GreasingPosb.AuditMessage = "KremerIoField changed:"
        Me.IO_GreasingPosb.AuditSource = "KremerIoField"
        Me.IO_GreasingPosb.BackColor = System.Drawing.Color.White
        Me.IO_GreasingPosb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_GreasingPosb.Data = 0.0R
        Me.IO_GreasingPosb.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_GreasingPosb.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_GreasingPosb.InitialValue = True
        Me.IO_GreasingPosb.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_GreasingPosb.Location = New System.Drawing.Point(281, 217)
        Me.IO_GreasingPosb.LowerBound = 0.0R
        Me.IO_GreasingPosb.Name = "IO_GreasingPosb"
        Me.IO_GreasingPosb.OutputFormat = "0.0 mm"
        Me.IO_GreasingPosb.Size = New System.Drawing.Size(104, 22)
        Me.IO_GreasingPosb.TabIndex = 413
        Me.IO_GreasingPosb.Text = "0.0 mm"
        Me.IO_GreasingPosb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_GreasingPosb.UpperBound = 1000.0R
        Me.IO_GreasingPosb.UserInfo = Nothing
        Me.IO_GreasingPosb.UserLevel = 500
        '
        'GreasingVeloA
        '
        Me.GreasingVeloA.BindControl = Me.IO_GreasingVeloA
        Me.GreasingVeloA.BindProperty = "Data"
        Me.GreasingVeloA.Data = Nothing
        Me.GreasingVeloA.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.GreasingVeloA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GreasingVeloA.VariableName = "MAIN.MachPar.InMoldDrying.BottomMoldA.GreasingVelocity"
        '
        'IO_GreasingVeloA
        '
        Me.IO_GreasingVeloA.Audit = Nothing
        Me.IO_GreasingVeloA.AuditEnabled = False
        Me.IO_GreasingVeloA.AuditMessage = "KremerIoField changed:"
        Me.IO_GreasingVeloA.AuditSource = "KremerIoField"
        Me.IO_GreasingVeloA.BackColor = System.Drawing.Color.White
        Me.IO_GreasingVeloA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_GreasingVeloA.Data = 0.0R
        Me.IO_GreasingVeloA.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_GreasingVeloA.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_GreasingVeloA.InitialValue = True
        Me.IO_GreasingVeloA.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_GreasingVeloA.Location = New System.Drawing.Point(281, 119)
        Me.IO_GreasingVeloA.LowerBound = 0.0R
        Me.IO_GreasingVeloA.Name = "IO_GreasingVeloA"
        Me.IO_GreasingVeloA.OutputFormat = "0.0 mm/s"
        Me.IO_GreasingVeloA.Size = New System.Drawing.Size(104, 22)
        Me.IO_GreasingVeloA.TabIndex = 424
        Me.IO_GreasingVeloA.Text = "0.0 mm/s"
        Me.IO_GreasingVeloA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_GreasingVeloA.UpperBound = 1000.0R
        Me.IO_GreasingVeloA.UserInfo = Nothing
        Me.IO_GreasingVeloA.UserLevel = 500
        '
        'GreasingVeloB
        '
        Me.GreasingVeloB.BindControl = Me.IO_GreasingVeloB
        Me.GreasingVeloB.BindProperty = "Data"
        Me.GreasingVeloB.Data = Nothing
        Me.GreasingVeloB.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.GreasingVeloB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GreasingVeloB.VariableName = "MAIN.MachPar.InMoldDrying.BottomMoldB.GreasingVelocity"
        '
        'IO_GreasingVeloB
        '
        Me.IO_GreasingVeloB.Audit = Nothing
        Me.IO_GreasingVeloB.AuditEnabled = False
        Me.IO_GreasingVeloB.AuditMessage = "KremerIoField changed:"
        Me.IO_GreasingVeloB.AuditSource = "KremerIoField"
        Me.IO_GreasingVeloB.BackColor = System.Drawing.Color.White
        Me.IO_GreasingVeloB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_GreasingVeloB.Data = 0.0R
        Me.IO_GreasingVeloB.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_GreasingVeloB.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_GreasingVeloB.InitialValue = True
        Me.IO_GreasingVeloB.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_GreasingVeloB.Location = New System.Drawing.Point(281, 239)
        Me.IO_GreasingVeloB.LowerBound = 0.0R
        Me.IO_GreasingVeloB.Name = "IO_GreasingVeloB"
        Me.IO_GreasingVeloB.OutputFormat = "0.0 mm/s"
        Me.IO_GreasingVeloB.Size = New System.Drawing.Size(104, 22)
        Me.IO_GreasingVeloB.TabIndex = 426
        Me.IO_GreasingVeloB.Text = "0.0 mm/s"
        Me.IO_GreasingVeloB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_GreasingVeloB.UpperBound = 1000.0R
        Me.IO_GreasingVeloB.UserInfo = Nothing
        Me.IO_GreasingVeloB.UserLevel = 500
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(-1, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(165, 23)
        Me.Label18.TabIndex = 257
        Me.Label18.Tag = "97"
        Me.Label18.Text = "More Settings"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Btn_Settings)
        Me.Panel1.Controls.Add(Me.Btn_Settings2)
        Me.Panel1.Location = New System.Drawing.Point(632, 332)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(165, 106)
        Me.Panel1.TabIndex = 365
        '
        'Btn_Settings
        '
        Me.Btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Settings.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Settings.Location = New System.Drawing.Point(3, 26)
        Me.Btn_Settings.Name = "Btn_Settings"
        Me.Btn_Settings.Size = New System.Drawing.Size(75, 75)
        Me.Btn_Settings.TabIndex = 255
        Me.Btn_Settings.Text = "<"
        Me.Btn_Settings.UseVisualStyleBackColor = True
        '
        'Btn_Settings2
        '
        Me.Btn_Settings2.Enabled = False
        Me.Btn_Settings2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Settings2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Settings2.Location = New System.Drawing.Point(84, 26)
        Me.Btn_Settings2.Name = "Btn_Settings2"
        Me.Btn_Settings2.Size = New System.Drawing.Size(75, 75)
        Me.Btn_Settings2.TabIndex = 254
        Me.Btn_Settings2.Text = ">"
        Me.Btn_Settings2.UseVisualStyleBackColor = True
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 30
        Me.LineShape1.X2 = 375
        Me.LineShape1.Y1 = 44
        Me.LineShape1.Y2 = 44
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 441)
        Me.ShapeContainer1.TabIndex = 366
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 428
        Me.LineShape4.X2 = 773
        Me.LineShape4.Y1 = 167
        Me.LineShape4.Y2 = 167
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 427
        Me.LineShape3.X2 = 772
        Me.LineShape3.Y1 = 45
        Me.LineShape3.Y2 = 45
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 34
        Me.LineShape2.X2 = 379
        Me.LineShape2.Y1 = 165
        Me.LineShape2.Y2 = 165
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(37, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 23)
        Me.Label1.TabIndex = 383
        Me.Label1.Tag = ""
        Me.Label1.Text = "Bottommold A Greasing"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 47)
        Me.Label2.TabIndex = 381
        Me.Label2.Tag = ""
        Me.Label2.Text = "Bottommold A move to greasing position"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(237, 22)
        Me.Label3.TabIndex = 384
        Me.Label3.Tag = ""
        Me.Label3.Text = "Bottommold A Greasing pos"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 22)
        Me.Label4.TabIndex = 412
        Me.Label4.Tag = ""
        Me.Label4.Text = "Bottommold B Greasing pos"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(37, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(273, 23)
        Me.Label5.TabIndex = 411
        Me.Label5.Tag = ""
        Me.Label5.Text = "Bottommold B Greasing"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(237, 47)
        Me.Label6.TabIndex = 409
        Me.Label6.Tag = ""
        Me.Label6.Text = "Bottommold B move to greasing position"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(423, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(350, 23)
        Me.Label7.TabIndex = 414
        Me.Label7.Tag = ""
        Me.Label7.Text = "Bottommold A stroke counter"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(426, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(237, 47)
        Me.Label8.TabIndex = 416
        Me.Label8.Tag = ""
        Me.Label8.Text = "Reset bottommold A strokes counter to 0"
        '
        'IO_StrokesA
        '
        Me.IO_StrokesA.Audit = Nothing
        Me.IO_StrokesA.AuditEnabled = False
        Me.IO_StrokesA.AuditMessage = "KremerIoField changed:"
        Me.IO_StrokesA.AuditSource = "KremerIoField"
        Me.IO_StrokesA.BackColor = System.Drawing.SystemColors.Control
        Me.IO_StrokesA.Data = 0.0R
        Me.IO_StrokesA.DataType = KremerControlsWin32.KremerIoField.NumDataType.DINT
        Me.IO_StrokesA.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_StrokesA.InitialValue = True
        Me.IO_StrokesA.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_StrokesA.Location = New System.Drawing.Point(636, 98)
        Me.IO_StrokesA.LowerBound = 0.0R
        Me.IO_StrokesA.Name = "IO_StrokesA"
        Me.IO_StrokesA.OutputFormat = "0 "
        Me.IO_StrokesA.Size = New System.Drawing.Size(137, 22)
        Me.IO_StrokesA.TabIndex = 418
        Me.IO_StrokesA.Text = "0 "
        Me.IO_StrokesA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_StrokesA.UpperBound = 32768.0R
        Me.IO_StrokesA.UserInfo = Nothing
        Me.IO_StrokesA.UserLevel = 500
        '
        'IO_StrokesB
        '
        Me.IO_StrokesB.Audit = Nothing
        Me.IO_StrokesB.AuditEnabled = False
        Me.IO_StrokesB.AuditMessage = "KremerIoField changed:"
        Me.IO_StrokesB.AuditSource = "KremerIoField"
        Me.IO_StrokesB.BackColor = System.Drawing.SystemColors.Control
        Me.IO_StrokesB.Data = 0.0R
        Me.IO_StrokesB.DataType = KremerControlsWin32.KremerIoField.NumDataType.DINT
        Me.IO_StrokesB.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_StrokesB.InitialValue = True
        Me.IO_StrokesB.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_StrokesB.Location = New System.Drawing.Point(636, 222)
        Me.IO_StrokesB.LowerBound = 0.0R
        Me.IO_StrokesB.Name = "IO_StrokesB"
        Me.IO_StrokesB.OutputFormat = "0 "
        Me.IO_StrokesB.Size = New System.Drawing.Size(137, 22)
        Me.IO_StrokesB.TabIndex = 422
        Me.IO_StrokesB.Text = "0 "
        Me.IO_StrokesB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_StrokesB.UpperBound = 32768.0R
        Me.IO_StrokesB.UserInfo = Nothing
        Me.IO_StrokesB.UserLevel = 500
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(426, 170)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(237, 47)
        Me.Label9.TabIndex = 421
        Me.Label9.Tag = ""
        Me.Label9.Text = "Reset bottommold A strokes counter to 0"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(423, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(350, 23)
        Me.Label10.TabIndex = 419
        Me.Label10.Tag = ""
        Me.Label10.Text = "Bottommold A stroke counter"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(38, 119)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(237, 22)
        Me.Label11.TabIndex = 423
        Me.Label11.Tag = ""
        Me.Label11.Text = "Bottommold A Greasing Velo"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(38, 239)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(237, 22)
        Me.Label12.TabIndex = 425
        Me.Label12.Tag = ""
        Me.Label12.Text = "Bottommold B Greasing Velo"
        '
        'NrStrokesA
        '
        Me.NrStrokesA.BindControl = Me.IO_StrokesA
        Me.NrStrokesA.BindProperty = "Data"
        Me.NrStrokesA.Data = Nothing
        Me.NrStrokesA.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.NrStrokesA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.NrStrokesA.VariableName = "MAIN.MachPar.InMoldDrying.BottomMoldA.KickOffCounter"
        '
        'NrStrokesB
        '
        Me.NrStrokesB.BindControl = Me.IO_StrokesB
        Me.NrStrokesB.BindProperty = "Data"
        Me.NrStrokesB.Data = Nothing
        Me.NrStrokesB.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.NrStrokesB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.NrStrokesB.VariableName = "MAIN.MachPar.InMoldDrying.BottomMoldB.KickOffCounter"
        '
        'ServiceSettings2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.IO_GreasingVeloB)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.IO_GreasingVeloA)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.IO_StrokesB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Btn_ResetStrokeB)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.IO_StrokesA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Btn_ResetStrokeA)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.IO_GreasingPosb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnMoveToGreasingB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.IO_GreasingPosA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnMoveToGreasingA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "ServiceSettings2"
        Me.Size = New System.Drawing.Size(800, 441)
        Me.Tag = "529"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents krConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents krVarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btn_Settings As System.Windows.Forms.Button
    Friend WithEvents Btn_Settings2 As System.Windows.Forms.Button
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnMoveToGreasingA As KremerControlsWin32.KremerButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents IO_GreasingPosA As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_GreasingPosb As KremerControlsWin32.KremerIoField
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnMoveToGreasingB As KremerControlsWin32.KremerButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Btn_ResetStrokeA As KremerControlsWin32.KremerButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents IO_StrokesA As KremerControlsWin32.KremerIoField
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents IO_StrokesB As KremerControlsWin32.KremerIoField
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Btn_ResetStrokeB As KremerControlsWin32.KremerButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents StrokeAReset As KremerControlsWin32.KremerVariable
    Friend WithEvents StrokeBReset As KremerControlsWin32.KremerVariable
    Friend WithEvents GreasingStartA As KremerControlsWin32.KremerVariable
    Friend WithEvents GreasingStartB As KremerControlsWin32.KremerVariable
    Friend WithEvents GreasingPosA As KremerControlsWin32.KremerVariable
    Friend WithEvents GreasingPosB As KremerControlsWin32.KremerVariable
    Friend WithEvents GreasingVeloA As KremerControlsWin32.KremerVariable
    Friend WithEvents GreasingVeloB As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_GreasingVeloA As KremerControlsWin32.KremerIoField
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents IO_GreasingVeloB As KremerControlsWin32.KremerIoField
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents NrStrokesA As KremerControlsWin32.KremerVariable
    Friend WithEvents NrStrokesB As KremerControlsWin32.KremerVariable

End Class
