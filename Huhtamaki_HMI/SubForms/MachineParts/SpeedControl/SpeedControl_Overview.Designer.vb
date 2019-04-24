<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpeedControl_Overview
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
        Me.Btn_Manual = New KremerControlsWin32.KremerButton()
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.mxAutomode = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_AutoManual = New KremerControlsWin32.KremerButton()
        Me.TotalModulo = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_Modulo = New KremerControlsWin32.KremerIoField(Me.components)
        Me.StartPosGantry1 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_StartPos1 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.StartPosGantry2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_StartPos2 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.StartPosGantry3 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_StartPos3 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.StartPosGantry4 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_StartPos4 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.hmiStart = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_StartAuto = New KremerControlsWin32.KremerButton()
        Me.hmiStop = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_StopAuto = New KremerControlsWin32.KremerButton()
        Me.FTL_RTO = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_RTO = New KremerControlsWin32.KremerButton()
        Me.ActualModulo = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_ActModulo = New KremerControlsWin32.KremerIoField(Me.components)
        Me.StartState = New KremerControlsWin32.KremerVariable(Me.components)
        Me.StopState = New KremerControlsWin32.KremerVariable(Me.components)
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape10 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape20 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape16 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.KremerShape11 = New KremerControlsWin32.KremerShape()
        Me.KremerShape14 = New KremerControlsWin32.KremerShape()
        Me.KremerLight2 = New KremerControlsWin32.KremerLight()
        Me.KremerLight3 = New KremerControlsWin32.KremerLight()
        Me.KremerLight4 = New KremerControlsWin32.KremerLight()
        Me.KremerLight5 = New KremerControlsWin32.KremerLight()
        Me.KremerLight15 = New KremerControlsWin32.KremerLight()
        Me.KremerShape1 = New KremerControlsWin32.KremerShape()
        Me.KremerShape2 = New KremerControlsWin32.KremerShape()
        Me.KremerShape3 = New KremerControlsWin32.KremerShape()
        Me.KremerShape4 = New KremerControlsWin32.KremerShape()
        Me.KremerShape5 = New KremerControlsWin32.KremerShape()
        Me.KremerShape6 = New KremerControlsWin32.KremerShape()
        Me.KremerShape7 = New KremerControlsWin32.KremerShape()
        Me.KremerShape8 = New KremerControlsWin32.KremerShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.KremerLight1 = New KremerControlsWin32.KremerLight()
        Me.KremerLight6 = New KremerControlsWin32.KremerLight()
        Me.KremerLight7 = New KremerControlsWin32.KremerLight()
        Me.KremerLight8 = New KremerControlsWin32.KremerLight()
        Me.KremerLight9 = New KremerControlsWin32.KremerLight()
        Me.KremerLight16 = New KremerControlsWin32.KremerLight()
        Me.KremerLight17 = New KremerControlsWin32.KremerLight()
        Me.KremerLight18 = New KremerControlsWin32.KremerLight()
        Me.KremerLight19 = New KremerControlsWin32.KremerLight()
        Me.KremerLight20 = New KremerControlsWin32.KremerLight()
        Me.KremerLight21 = New KremerControlsWin32.KremerLight()
        Me.KremerLight22 = New KremerControlsWin32.KremerLight()
        Me.KremerLight23 = New KremerControlsWin32.KremerLight()
        Me.KremerLight24 = New KremerControlsWin32.KremerLight()
        Me.KremerLight25 = New KremerControlsWin32.KremerLight()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.KremerIoField1 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.Btn_Settings.Location = New System.Drawing.Point(684, 326)
        Me.Btn_Settings.Name = "Btn_Settings"
        Me.Btn_Settings.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Settings.State = False
        Me.Btn_Settings.StateIsData = True
        Me.Btn_Settings.StateText = New String() {Nothing, Nothing}
        Me.Btn_Settings.TabIndex = 6
        Me.Btn_Settings.Tag = "193"
        Me.Btn_Settings.Text = "Settings"
        Me.Btn_Settings.UserInfo = Nothing
        Me.Btn_Settings.UserLevel = 0
        Me.Btn_Settings.UseStateText = False
        Me.Btn_Settings.UseVisualStyleBackColor = True
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
        Me.Btn_Manual.Location = New System.Drawing.Point(684, 378)
        Me.Btn_Manual.Name = "Btn_Manual"
        Me.Btn_Manual.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Manual.State = False
        Me.Btn_Manual.StateIsData = True
        Me.Btn_Manual.StateText = New String() {Nothing, Nothing}
        Me.Btn_Manual.TabIndex = 5
        Me.Btn_Manual.Tag = "192"
        Me.Btn_Manual.Text = "Manual Control"
        Me.Btn_Manual.UserInfo = Nothing
        Me.Btn_Manual.UserLevel = 0
        Me.Btn_Manual.UseStateText = False
        Me.Btn_Manual.UseVisualStyleBackColor = True
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.mxAutomode)
        Me.VarCollector.Variables.Add(Me.TotalModulo)
        Me.VarCollector.Variables.Add(Me.StartPosGantry1)
        Me.VarCollector.Variables.Add(Me.StartPosGantry2)
        Me.VarCollector.Variables.Add(Me.StartPosGantry3)
        Me.VarCollector.Variables.Add(Me.StartPosGantry4)
        Me.VarCollector.Variables.Add(Me.hmiStart)
        Me.VarCollector.Variables.Add(Me.hmiStop)
        Me.VarCollector.Variables.Add(Me.FTL_RTO)
        Me.VarCollector.Variables.Add(Me.ActualModulo)
        Me.VarCollector.Variables.Add(Me.StartState)
        Me.VarCollector.Variables.Add(Me.StopState)
        '
        'mxAutomode
        '
        Me.mxAutomode.BindControl = Me.Btn_AutoManual
        Me.mxAutomode.BindProperty = "Data"
        Me.mxAutomode.Data = Nothing
        Me.mxAutomode.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.mxAutomode.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.mxAutomode.VariableName = "Main.mxAutomode"
        '
        'Btn_AutoManual
        '
        Me.Btn_AutoManual.Audit = Nothing
        Me.Btn_AutoManual.AuditEnabled = False
        Me.Btn_AutoManual.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_AutoManual.AuditSource = "KremerPushButton"
        Me.Btn_AutoManual.BackColor = System.Drawing.Color.Blue
        Me.Btn_AutoManual.BackColorOn = System.Drawing.SystemColors.Info
        Me.Btn_AutoManual.BackGroundImageOn = Nothing
        Me.Btn_AutoManual.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.Btn_AutoManual.Data = False
        Me.Btn_AutoManual.ForeColor = System.Drawing.Color.Yellow
        Me.Btn_AutoManual.ForeColorOn = System.Drawing.Color.Black
        Me.Btn_AutoManual.Location = New System.Drawing.Point(316, 346)
        Me.Btn_AutoManual.Name = "Btn_AutoManual"
        Me.Btn_AutoManual.Size = New System.Drawing.Size(100, 40)
        Me.Btn_AutoManual.State = False
        Me.Btn_AutoManual.StateIsData = True
        Me.Btn_AutoManual.StateText = New String() {"Manual", "Auto"}
        Me.Btn_AutoManual.TabIndex = 386
        Me.Btn_AutoManual.Text = "Manual"
        Me.Btn_AutoManual.UserInfo = Nothing
        Me.Btn_AutoManual.UserLevel = 0
        Me.Btn_AutoManual.UseStateText = False
        Me.Btn_AutoManual.UseVisualStyleBackColor = False
        '
        'TotalModulo
        '
        Me.TotalModulo.BindControl = Me.IO_Modulo
        Me.TotalModulo.BindProperty = "Data"
        Me.TotalModulo.Data = Nothing
        Me.TotalModulo.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.TotalModulo.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TotalModulo.VariableName = "MAIN.ProdPar.Conveyor.BlowOff_Prod.Modulo"
        '
        'IO_Modulo
        '
        Me.IO_Modulo.Audit = Nothing
        Me.IO_Modulo.AuditEnabled = False
        Me.IO_Modulo.AuditMessage = "KremerIoField changed:"
        Me.IO_Modulo.AuditSource = "KremerIoField"
        Me.IO_Modulo.BackColor = System.Drawing.Color.Transparent
        Me.IO_Modulo.Data = 0.0R
        Me.IO_Modulo.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_Modulo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_Modulo.InitialValue = True
        Me.IO_Modulo.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_Modulo.Location = New System.Drawing.Point(324, 0)
        Me.IO_Modulo.LowerBound = -5000.0R
        Me.IO_Modulo.Name = "IO_Modulo"
        Me.IO_Modulo.OutputFormat = "0.0 mm"
        Me.IO_Modulo.Size = New System.Drawing.Size(100, 22)
        Me.IO_Modulo.TabIndex = 375
        Me.IO_Modulo.Text = "0.0 mm"
        Me.IO_Modulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IO_Modulo.UpperBound = 5000.0R
        Me.IO_Modulo.UserInfo = Nothing
        Me.IO_Modulo.UserLevel = 0
        '
        'StartPosGantry1
        '
        Me.StartPosGantry1.BindControl = Me.IO_StartPos1
        Me.StartPosGantry1.BindProperty = "Data"
        Me.StartPosGantry1.Data = Nothing
        Me.StartPosGantry1.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.StartPosGantry1.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StartPosGantry1.VariableName = "MAIN.Conveyor.IMD2_GantryA.mrModuloOffset"
        '
        'IO_StartPos1
        '
        Me.IO_StartPos1.Audit = Nothing
        Me.IO_StartPos1.AuditEnabled = False
        Me.IO_StartPos1.AuditMessage = "KremerIoField changed:"
        Me.IO_StartPos1.AuditSource = "KremerIoField"
        Me.IO_StartPos1.BackColor = System.Drawing.Color.Transparent
        Me.IO_StartPos1.Data = 0.0R
        Me.IO_StartPos1.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_StartPos1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_StartPos1.InitialValue = True
        Me.IO_StartPos1.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_StartPos1.Location = New System.Drawing.Point(81, 189)
        Me.IO_StartPos1.LowerBound = -5000.0R
        Me.IO_StartPos1.Name = "IO_StartPos1"
        Me.IO_StartPos1.OutputFormat = "0.0 mm"
        Me.IO_StartPos1.Size = New System.Drawing.Size(85, 22)
        Me.IO_StartPos1.TabIndex = 381
        Me.IO_StartPos1.Text = "0.0 mm"
        Me.IO_StartPos1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IO_StartPos1.UpperBound = 5000.0R
        Me.IO_StartPos1.UserInfo = Nothing
        Me.IO_StartPos1.UserLevel = 0
        '
        'StartPosGantry2
        '
        Me.StartPosGantry2.BindControl = Me.IO_StartPos2
        Me.StartPosGantry2.BindProperty = "Data"
        Me.StartPosGantry2.Data = Nothing
        Me.StartPosGantry2.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.StartPosGantry2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StartPosGantry2.VariableName = "MAIN.Conveyor.IMD1_GantryA.mrModuloOffset"
        '
        'IO_StartPos2
        '
        Me.IO_StartPos2.Audit = Nothing
        Me.IO_StartPos2.AuditEnabled = False
        Me.IO_StartPos2.AuditMessage = "KremerIoField changed:"
        Me.IO_StartPos2.AuditSource = "KremerIoField"
        Me.IO_StartPos2.BackColor = System.Drawing.Color.Transparent
        Me.IO_StartPos2.Data = 0.0R
        Me.IO_StartPos2.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_StartPos2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_StartPos2.InitialValue = True
        Me.IO_StartPos2.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_StartPos2.Location = New System.Drawing.Point(256, 138)
        Me.IO_StartPos2.LowerBound = -5000.0R
        Me.IO_StartPos2.Name = "IO_StartPos2"
        Me.IO_StartPos2.OutputFormat = "0.0 mm"
        Me.IO_StartPos2.Size = New System.Drawing.Size(100, 22)
        Me.IO_StartPos2.TabIndex = 380
        Me.IO_StartPos2.Text = "0.0 mm"
        Me.IO_StartPos2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IO_StartPos2.UpperBound = 5000.0R
        Me.IO_StartPos2.UserInfo = Nothing
        Me.IO_StartPos2.UserLevel = 0
        '
        'StartPosGantry3
        '
        Me.StartPosGantry3.BindControl = Me.IO_StartPos3
        Me.StartPosGantry3.BindProperty = "Data"
        Me.StartPosGantry3.Data = Nothing
        Me.StartPosGantry3.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.StartPosGantry3.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StartPosGantry3.VariableName = "MAIN.Conveyor.IMD2_GantryB.mrModuloOffset"
        '
        'IO_StartPos3
        '
        Me.IO_StartPos3.Audit = Nothing
        Me.IO_StartPos3.AuditEnabled = False
        Me.IO_StartPos3.AuditMessage = "KremerIoField changed:"
        Me.IO_StartPos3.AuditSource = "KremerIoField"
        Me.IO_StartPos3.BackColor = System.Drawing.Color.Transparent
        Me.IO_StartPos3.Data = 0.0R
        Me.IO_StartPos3.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_StartPos3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_StartPos3.InitialValue = True
        Me.IO_StartPos3.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_StartPos3.Location = New System.Drawing.Point(449, 87)
        Me.IO_StartPos3.LowerBound = -5000.0R
        Me.IO_StartPos3.Name = "IO_StartPos3"
        Me.IO_StartPos3.OutputFormat = "0.0 mm"
        Me.IO_StartPos3.Size = New System.Drawing.Size(85, 22)
        Me.IO_StartPos3.TabIndex = 382
        Me.IO_StartPos3.Text = "0.0 mm"
        Me.IO_StartPos3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IO_StartPos3.UpperBound = 5000.0R
        Me.IO_StartPos3.UserInfo = Nothing
        Me.IO_StartPos3.UserLevel = 0
        '
        'StartPosGantry4
        '
        Me.StartPosGantry4.BindControl = Me.IO_StartPos4
        Me.StartPosGantry4.BindProperty = "Data"
        Me.StartPosGantry4.Data = Nothing
        Me.StartPosGantry4.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.StartPosGantry4.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StartPosGantry4.VariableName = "MAIN.Conveyor.IMD1_GantryB.mrModuloOffset"
        '
        'IO_StartPos4
        '
        Me.IO_StartPos4.Audit = Nothing
        Me.IO_StartPos4.AuditEnabled = False
        Me.IO_StartPos4.AuditMessage = "KremerIoField changed:"
        Me.IO_StartPos4.AuditSource = "KremerIoField"
        Me.IO_StartPos4.BackColor = System.Drawing.Color.Transparent
        Me.IO_StartPos4.Data = 0.0R
        Me.IO_StartPos4.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_StartPos4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_StartPos4.InitialValue = True
        Me.IO_StartPos4.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_StartPos4.Location = New System.Drawing.Point(624, 38)
        Me.IO_StartPos4.LowerBound = -5000.0R
        Me.IO_StartPos4.Name = "IO_StartPos4"
        Me.IO_StartPos4.OutputFormat = "0.0 mm"
        Me.IO_StartPos4.Size = New System.Drawing.Size(85, 22)
        Me.IO_StartPos4.TabIndex = 383
        Me.IO_StartPos4.Text = "0.0 mm"
        Me.IO_StartPos4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IO_StartPos4.UpperBound = 5000.0R
        Me.IO_StartPos4.UserInfo = Nothing
        Me.IO_StartPos4.UserLevel = 0
        '
        'hmiStart
        '
        Me.hmiStart.BindControl = Me.Btn_StartAuto
        Me.hmiStart.BindProperty = "Data"
        Me.hmiStart.Data = Nothing
        Me.hmiStart.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.hmiStart.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.hmiStart.VariableName = "MAIN.mxHMI_Start"
        '
        'Btn_StartAuto
        '
        Me.Btn_StartAuto.Audit = Nothing
        Me.Btn_StartAuto.AuditEnabled = False
        Me.Btn_StartAuto.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_StartAuto.AuditSource = "KremerPushButton"
        Me.Btn_StartAuto.BackColorOn = System.Drawing.Color.Green
        Me.Btn_StartAuto.BackGroundImageOn = Nothing
        Me.Btn_StartAuto.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_StartAuto.Data = False
        Me.Btn_StartAuto.ForeColorOn = System.Drawing.Color.White
        Me.Btn_StartAuto.Location = New System.Drawing.Point(50, 346)
        Me.Btn_StartAuto.Name = "Btn_StartAuto"
        Me.Btn_StartAuto.Size = New System.Drawing.Size(100, 40)
        Me.Btn_StartAuto.State = False
        Me.Btn_StartAuto.StateIsData = False
        Me.Btn_StartAuto.StateText = New String() {Nothing, Nothing}
        Me.Btn_StartAuto.TabIndex = 384
        Me.Btn_StartAuto.Text = "Start"
        Me.Btn_StartAuto.UserInfo = Nothing
        Me.Btn_StartAuto.UserLevel = 0
        Me.Btn_StartAuto.UseStateText = False
        Me.Btn_StartAuto.UseVisualStyleBackColor = True
        '
        'hmiStop
        '
        Me.hmiStop.BindControl = Me.Btn_StopAuto
        Me.hmiStop.BindProperty = "Data"
        Me.hmiStop.Data = Nothing
        Me.hmiStop.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.hmiStop.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.hmiStop.VariableName = "MAIN.mxHMI_Stop"
        '
        'Btn_StopAuto
        '
        Me.Btn_StopAuto.Audit = Nothing
        Me.Btn_StopAuto.AuditEnabled = False
        Me.Btn_StopAuto.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_StopAuto.AuditSource = "KremerPushButton"
        Me.Btn_StopAuto.BackColorOn = System.Drawing.Color.Red
        Me.Btn_StopAuto.BackGroundImageOn = Nothing
        Me.Btn_StopAuto.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_StopAuto.Data = False
        Me.Btn_StopAuto.ForeColorOn = System.Drawing.Color.Black
        Me.Btn_StopAuto.Location = New System.Drawing.Point(161, 347)
        Me.Btn_StopAuto.Name = "Btn_StopAuto"
        Me.Btn_StopAuto.Size = New System.Drawing.Size(100, 40)
        Me.Btn_StopAuto.State = False
        Me.Btn_StopAuto.StateIsData = False
        Me.Btn_StopAuto.StateText = New String() {Nothing, Nothing}
        Me.Btn_StopAuto.TabIndex = 385
        Me.Btn_StopAuto.Text = "Stop"
        Me.Btn_StopAuto.UserInfo = Nothing
        Me.Btn_StopAuto.UserLevel = 0
        Me.Btn_StopAuto.UseStateText = False
        Me.Btn_StopAuto.UseVisualStyleBackColor = True
        '
        'FTL_RTO
        '
        Me.FTL_RTO.BindControl = Me.Btn_RTO
        Me.FTL_RTO.BindProperty = "Data"
        Me.FTL_RTO.Data = Nothing
        Me.FTL_RTO.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.FTL_RTO.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FTL_RTO.VariableName = "MAIN.ComSpeedControl_FTL.FTL_SpeedControl.RTO"
        '
        'Btn_RTO
        '
        Me.Btn_RTO.Audit = Nothing
        Me.Btn_RTO.AuditEnabled = False
        Me.Btn_RTO.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_RTO.AuditSource = "KremerPushButton"
        Me.Btn_RTO.BackColor = System.Drawing.SystemColors.Info
        Me.Btn_RTO.BackColorOn = System.Drawing.Color.Blue
        Me.Btn_RTO.BackGroundImageOn = Nothing
        Me.Btn_RTO.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.Btn_RTO.Data = False
        Me.Btn_RTO.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_RTO.Location = New System.Drawing.Point(476, 346)
        Me.Btn_RTO.Name = "Btn_RTO"
        Me.Btn_RTO.Size = New System.Drawing.Size(100, 40)
        Me.Btn_RTO.State = False
        Me.Btn_RTO.StateIsData = True
        Me.Btn_RTO.StateText = New String() {"Not Released by FTL", "Released by FTL"}
        Me.Btn_RTO.TabIndex = 387
        Me.Btn_RTO.Text = "FTL RTO"
        Me.Btn_RTO.UserInfo = Nothing
        Me.Btn_RTO.UserLevel = 0
        Me.Btn_RTO.UseStateText = False
        Me.Btn_RTO.UseVisualStyleBackColor = False
        '
        'ActualModulo
        '
        Me.ActualModulo.BindControl = Me.IO_ActModulo
        Me.ActualModulo.BindProperty = "Data"
        Me.ActualModulo.Data = Nothing
        Me.ActualModulo.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.ActualModulo.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ActualModulo.VariableName = "MAIN.Conveyor.mrActModPos"
        '
        'IO_ActModulo
        '
        Me.IO_ActModulo.Audit = Nothing
        Me.IO_ActModulo.AuditEnabled = False
        Me.IO_ActModulo.AuditMessage = "KremerIoField changed:"
        Me.IO_ActModulo.AuditSource = "KremerIoField"
        Me.IO_ActModulo.BackColor = System.Drawing.Color.Transparent
        Me.IO_ActModulo.Data = 0.0R
        Me.IO_ActModulo.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_ActModulo.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.IO_ActModulo.InitialValue = True
        Me.IO_ActModulo.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_ActModulo.Location = New System.Drawing.Point(161, 76)
        Me.IO_ActModulo.LowerBound = -5000.0R
        Me.IO_ActModulo.Name = "IO_ActModulo"
        Me.IO_ActModulo.OutputFormat = "0.0 mm"
        Me.IO_ActModulo.Size = New System.Drawing.Size(100, 22)
        Me.IO_ActModulo.TabIndex = 378
        Me.IO_ActModulo.Text = "0.0 mm"
        Me.IO_ActModulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.IO_ActModulo.UpperBound = 5000.0R
        Me.IO_ActModulo.UserInfo = Nothing
        Me.IO_ActModulo.UserLevel = 0
        '
        'StartState
        '
        Me.StartState.BindControl = Me.Btn_StartAuto
        Me.StartState.BindProperty = "State"
        Me.StartState.Data = Nothing
        Me.StartState.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.StartState.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StartState.VariableName = "MAIN.mxHMI_StartState"
        '
        'StopState
        '
        Me.StopState.BindControl = Me.Btn_StopAuto
        Me.StopState.BindProperty = "State"
        Me.StopState.Data = Nothing
        Me.StopState.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.StopState.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StopState.VariableName = "MAIN.mxHMI_StopState"
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.ForestGreen
        Me.LineShape2.BorderWidth = 3
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 50
        Me.LineShape2.X2 = 750
        Me.LineShape2.Y1 = 250
        Me.LineShape2.Y2 = 50
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape10, Me.LineShape9, Me.LineShape8, Me.LineShape7, Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape1, Me.LineShape20, Me.LineShape16, Me.LineShape3, Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 435)
        Me.ShapeContainer1.TabIndex = 7
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape10
        '
        Me.LineShape10.BorderColor = System.Drawing.Color.Black
        Me.LineShape10.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape10.Name = "LineShape10"
        Me.LineShape10.X1 = 575
        Me.LineShape10.X2 = 575
        Me.LineShape10.Y1 = 251
        Me.LineShape10.Y2 = 300
        '
        'LineShape9
        '
        Me.LineShape9.BorderColor = System.Drawing.Color.Black
        Me.LineShape9.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape9.Name = "LineShape9"
        Me.LineShape9.X1 = 400
        Me.LineShape9.X2 = 400
        Me.LineShape9.Y1 = 251
        Me.LineShape9.Y2 = 300
        '
        'LineShape8
        '
        Me.LineShape8.BorderColor = System.Drawing.Color.Black
        Me.LineShape8.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape8.Name = "LineShape8"
        Me.LineShape8.X1 = 224
        Me.LineShape8.X2 = 224
        Me.LineShape8.Y1 = 251
        Me.LineShape8.Y2 = 300
        '
        'LineShape7
        '
        Me.LineShape7.BorderColor = System.Drawing.Color.Black
        Me.LineShape7.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 49
        Me.LineShape7.X2 = 49
        Me.LineShape7.Y1 = 251
        Me.LineShape7.Y2 = 300
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape6.BorderWidth = 2
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 50
        Me.LineShape6.X2 = 750
        Me.LineShape6.Y1 = 260
        Me.LineShape6.Y2 = 260
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.ForestGreen
        Me.LineShape5.BorderWidth = 3
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 400
        Me.LineShape5.X2 = 400
        Me.LineShape5.Y1 = 150
        Me.LineShape5.Y2 = 250
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.ForestGreen
        Me.LineShape4.BorderWidth = 3
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 575
        Me.LineShape4.X2 = 575
        Me.LineShape4.Y1 = 100
        Me.LineShape4.Y2 = 250
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.ForestGreen
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 225
        Me.LineShape1.X2 = 225
        Me.LineShape1.Y1 = 200
        Me.LineShape1.Y2 = 250
        '
        'LineShape20
        '
        Me.LineShape20.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape20.BorderWidth = 2
        Me.LineShape20.Name = "LineShape20"
        Me.LineShape20.X1 = 50
        Me.LineShape20.X2 = 750
        Me.LineShape20.Y1 = 25
        Me.LineShape20.Y2 = 25
        '
        'LineShape16
        '
        Me.LineShape16.BorderColor = System.Drawing.Color.ForestGreen
        Me.LineShape16.BorderWidth = 3
        Me.LineShape16.Name = "LineShape16"
        Me.LineShape16.X1 = 0
        Me.LineShape16.X2 = 800
        Me.LineShape16.Y1 = 250
        Me.LineShape16.Y2 = 250
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.ForestGreen
        Me.LineShape3.BorderWidth = 3
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 750
        Me.LineShape3.X2 = 750
        Me.LineShape3.Y1 = 50
        Me.LineShape3.Y2 = 250
        '
        'KremerShape11
        '
        Me.KremerShape11.Data = False
        Me.KremerShape11.Fill = True
        Me.KremerShape11.FillColor = System.Drawing.SystemColors.Control
        Me.KremerShape11.FillColorOn = System.Drawing.SystemColors.Control
        Me.KremerShape11.FillDirection = KremerControlsWin32.KremerShape.Direction.Up
        Me.KremerShape11.FillLevel = 100.0!
        Me.KremerShape11.FillMaximum = 100.0!
        Me.KremerShape11.FillMinimum = 0.0!
        Me.KremerShape11.Line = True
        Me.KremerShape11.LineColor = System.Drawing.Color.Black
        Me.KremerShape11.LineColorOn = System.Drawing.Color.Black
        Me.KremerShape11.LineSize = 1
        Me.KremerShape11.Location = New System.Drawing.Point(737, 18)
        Me.KremerShape11.Name = "KremerShape11"
        Me.KremerShape11.Size = New System.Drawing.Size(15, 15)
        Me.KremerShape11.Style = KremerControlsWin32.KremerShape.LineStyle.Solid
        Me.KremerShape11.TabIndex = 274
        Me.KremerShape11.Text = "KremerShape11"
        Me.KremerShape11.Type = KremerControlsWin32.KremerShape.ShapeType.TriangleRight
        '
        'KremerShape14
        '
        Me.KremerShape14.Data = False
        Me.KremerShape14.Fill = True
        Me.KremerShape14.FillColor = System.Drawing.SystemColors.Control
        Me.KremerShape14.FillColorOn = System.Drawing.SystemColors.Control
        Me.KremerShape14.FillDirection = KremerControlsWin32.KremerShape.Direction.Up
        Me.KremerShape14.FillLevel = 100.0!
        Me.KremerShape14.FillMaximum = 100.0!
        Me.KremerShape14.FillMinimum = 0.0!
        Me.KremerShape14.Line = True
        Me.KremerShape14.LineColor = System.Drawing.Color.Black
        Me.KremerShape14.LineColorOn = System.Drawing.Color.Black
        Me.KremerShape14.LineSize = 1
        Me.KremerShape14.Location = New System.Drawing.Point(50, 18)
        Me.KremerShape14.Name = "KremerShape14"
        Me.KremerShape14.Size = New System.Drawing.Size(15, 15)
        Me.KremerShape14.Style = KremerControlsWin32.KremerShape.LineStyle.Solid
        Me.KremerShape14.TabIndex = 271
        Me.KremerShape14.Text = "KremerShape14"
        Me.KremerShape14.Type = KremerControlsWin32.KremerShape.ShapeType.TriangleLeft
        '
        'KremerLight2
        '
        Me.KremerLight2.ColorOff = System.Drawing.Color.LightGray
        Me.KremerLight2.ColorOn = System.Drawing.Color.Lime
        Me.KremerLight2.Data = False
        Me.KremerLight2.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerLight2.Line = True
        Me.KremerLight2.LineSize = 1
        Me.KremerLight2.Location = New System.Drawing.Point(148, 277)
        Me.KremerLight2.Name = "KremerLight2"
        Me.KremerLight2.Size = New System.Drawing.Size(18, 18)
        Me.KremerLight2.TabIndex = 346
        Me.KremerLight2.Tag = ""
        Me.KremerLight2.Text = "1"
        Me.KremerLight2.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KremerLight3
        '
        Me.KremerLight3.ColorOff = System.Drawing.Color.LightGray
        Me.KremerLight3.ColorOn = System.Drawing.Color.Lime
        Me.KremerLight3.Data = False
        Me.KremerLight3.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerLight3.Line = True
        Me.KremerLight3.LineSize = 1
        Me.KremerLight3.Location = New System.Drawing.Point(101, 277)
        Me.KremerLight3.Name = "KremerLight3"
        Me.KremerLight3.Size = New System.Drawing.Size(18, 18)
        Me.KremerLight3.TabIndex = 345
        Me.KremerLight3.Tag = ""
        Me.KremerLight3.Text = "1"
        Me.KremerLight3.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KremerLight4
        '
        Me.KremerLight4.ColorOff = System.Drawing.Color.LightGray
        Me.KremerLight4.ColorOn = System.Drawing.Color.Lime
        Me.KremerLight4.Data = False
        Me.KremerLight4.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerLight4.Line = True
        Me.KremerLight4.LineSize = 1
        Me.KremerLight4.Location = New System.Drawing.Point(84, 277)
        Me.KremerLight4.Name = "KremerLight4"
        Me.KremerLight4.Size = New System.Drawing.Size(18, 18)
        Me.KremerLight4.TabIndex = 344
        Me.KremerLight4.Tag = ""
        Me.KremerLight4.Text = "1"
        Me.KremerLight4.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KremerLight5
        '
        Me.KremerLight5.ColorOff = System.Drawing.Color.LightGray
        Me.KremerLight5.ColorOn = System.Drawing.Color.Lime
        Me.KremerLight5.Data = False
        Me.KremerLight5.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerLight5.Line = True
        Me.KremerLight5.LineSize = 1
        Me.KremerLight5.Location = New System.Drawing.Point(67, 277)
        Me.KremerLight5.Name = "KremerLight5"
        Me.KremerLight5.Size = New System.Drawing.Size(18, 18)
        Me.KremerLight5.TabIndex = 343
        Me.KremerLight5.Tag = ""
        Me.KremerLight5.Text = "1"
        Me.KremerLight5.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KremerLight15
        '
        Me.KremerLight15.ColorOff = System.Drawing.Color.LightGray
        Me.KremerLight15.ColorOn = System.Drawing.Color.Lime
        Me.KremerLight15.Data = False
        Me.KremerLight15.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerLight15.Line = True
        Me.KremerLight15.LineSize = 1
        Me.KremerLight15.Location = New System.Drawing.Point(50, 277)
        Me.KremerLight15.Name = "KremerLight15"
        Me.KremerLight15.Size = New System.Drawing.Size(18, 18)
        Me.KremerLight15.TabIndex = 342
        Me.KremerLight15.Tag = ""
        Me.KremerLight15.Text = "1"
        Me.KremerLight15.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KremerShape1
        '
        Me.KremerShape1.Data = False
        Me.KremerShape1.Fill = True
        Me.KremerShape1.FillColor = System.Drawing.SystemColors.Control
        Me.KremerShape1.FillColorOn = System.Drawing.SystemColors.Control
        Me.KremerShape1.FillDirection = KremerControlsWin32.KremerShape.Direction.Up
        Me.KremerShape1.FillLevel = 100.0!
        Me.KremerShape1.FillMaximum = 100.0!
        Me.KremerShape1.FillMinimum = 0.0!
        Me.KremerShape1.Line = True
        Me.KremerShape1.LineColor = System.Drawing.Color.Black
        Me.KremerShape1.LineColorOn = System.Drawing.Color.Black
        Me.KremerShape1.LineSize = 1
        Me.KremerShape1.Location = New System.Drawing.Point(209, 253)
        Me.KremerShape1.Name = "KremerShape1"
        Me.KremerShape1.Size = New System.Drawing.Size(15, 15)
        Me.KremerShape1.Style = KremerControlsWin32.KremerShape.LineStyle.Solid
        Me.KremerShape1.TabIndex = 347
        Me.KremerShape1.Text = "KremerShape1"
        Me.KremerShape1.Type = KremerControlsWin32.KremerShape.ShapeType.TriangleRight
        '
        'KremerShape2
        '
        Me.KremerShape2.Data = False
        Me.KremerShape2.Fill = True
        Me.KremerShape2.FillColor = System.Drawing.SystemColors.Control
        Me.KremerShape2.FillColorOn = System.Drawing.SystemColors.Control
        Me.KremerShape2.FillDirection = KremerControlsWin32.KremerShape.Direction.Up
        Me.KremerShape2.FillLevel = 100.0!
        Me.KremerShape2.FillMaximum = 100.0!
        Me.KremerShape2.FillMinimum = 0.0!
        Me.KremerShape2.Line = True
        Me.KremerShape2.LineColor = System.Drawing.Color.Black
        Me.KremerShape2.LineColorOn = System.Drawing.Color.Black
        Me.KremerShape2.LineSize = 1
        Me.KremerShape2.Location = New System.Drawing.Point(225, 253)
        Me.KremerShape2.Name = "KremerShape2"
        Me.KremerShape2.Size = New System.Drawing.Size(15, 15)
        Me.KremerShape2.Style = KremerControlsWin32.KremerShape.LineStyle.Solid
        Me.KremerShape2.TabIndex = 348
        Me.KremerShape2.Text = "KremerShape2"
        Me.KremerShape2.Type = KremerControlsWin32.KremerShape.ShapeType.TriangleLeft
        '
        'KremerShape3
        '
        Me.KremerShape3.Data = False
        Me.KremerShape3.Fill = True
        Me.KremerShape3.FillColor = System.Drawing.SystemColors.Control
        Me.KremerShape3.FillColorOn = System.Drawing.SystemColors.Control
        Me.KremerShape3.FillDirection = KremerControlsWin32.KremerShape.Direction.Up
        Me.KremerShape3.FillLevel = 100.0!
        Me.KremerShape3.FillMaximum = 100.0!
        Me.KremerShape3.FillMinimum = 0.0!
        Me.KremerShape3.Line = True
        Me.KremerShape3.LineColor = System.Drawing.Color.Black
        Me.KremerShape3.LineColorOn = System.Drawing.Color.Black
        Me.KremerShape3.LineSize = 1
        Me.KremerShape3.Location = New System.Drawing.Point(401, 253)
        Me.KremerShape3.Name = "KremerShape3"
        Me.KremerShape3.Size = New System.Drawing.Size(15, 15)
        Me.KremerShape3.Style = KremerControlsWin32.KremerShape.LineStyle.Solid
        Me.KremerShape3.TabIndex = 350
        Me.KremerShape3.Text = "KremerShape3"
        Me.KremerShape3.Type = KremerControlsWin32.KremerShape.ShapeType.TriangleLeft
        '
        'KremerShape4
        '
        Me.KremerShape4.Data = False
        Me.KremerShape4.Fill = True
        Me.KremerShape4.FillColor = System.Drawing.SystemColors.Control
        Me.KremerShape4.FillColorOn = System.Drawing.SystemColors.Control
        Me.KremerShape4.FillDirection = KremerControlsWin32.KremerShape.Direction.Up
        Me.KremerShape4.FillLevel = 100.0!
        Me.KremerShape4.FillMaximum = 100.0!
        Me.KremerShape4.FillMinimum = 0.0!
        Me.KremerShape4.Line = True
        Me.KremerShape4.LineColor = System.Drawing.Color.Black
        Me.KremerShape4.LineColorOn = System.Drawing.Color.Black
        Me.KremerShape4.LineSize = 1
        Me.KremerShape4.Location = New System.Drawing.Point(385, 253)
        Me.KremerShape4.Name = "KremerShape4"
        Me.KremerShape4.Size = New System.Drawing.Size(15, 15)
        Me.KremerShape4.Style = KremerControlsWin32.KremerShape.LineStyle.Solid
        Me.KremerShape4.TabIndex = 349
        Me.KremerShape4.Text = "KremerShape4"
        Me.KremerShape4.Type = KremerControlsWin32.KremerShape.ShapeType.TriangleRight
        '
        'KremerShape5
        '
        Me.KremerShape5.Data = False
        Me.KremerShape5.Fill = True
        Me.KremerShape5.FillColor = System.Drawing.SystemColors.Control
        Me.KremerShape5.FillColorOn = System.Drawing.SystemColors.Control
        Me.KremerShape5.FillDirection = KremerControlsWin32.KremerShape.Direction.Up
        Me.KremerShape5.FillLevel = 100.0!
        Me.KremerShape5.FillMaximum = 100.0!
        Me.KremerShape5.FillMinimum = 0.0!
        Me.KremerShape5.Line = True
        Me.KremerShape5.LineColor = System.Drawing.Color.Black
        Me.KremerShape5.LineColorOn = System.Drawing.Color.Black
        Me.KremerShape5.LineSize = 1
        Me.KremerShape5.Location = New System.Drawing.Point(576, 253)
        Me.KremerShape5.Name = "KremerShape5"
        Me.KremerShape5.Size = New System.Drawing.Size(15, 15)
        Me.KremerShape5.Style = KremerControlsWin32.KremerShape.LineStyle.Solid
        Me.KremerShape5.TabIndex = 352
        Me.KremerShape5.Text = "KremerShape5"
        Me.KremerShape5.Type = KremerControlsWin32.KremerShape.ShapeType.TriangleLeft
        '
        'KremerShape6
        '
        Me.KremerShape6.Data = False
        Me.KremerShape6.Fill = True
        Me.KremerShape6.FillColor = System.Drawing.SystemColors.Control
        Me.KremerShape6.FillColorOn = System.Drawing.SystemColors.Control
        Me.KremerShape6.FillDirection = KremerControlsWin32.KremerShape.Direction.Up
        Me.KremerShape6.FillLevel = 100.0!
        Me.KremerShape6.FillMaximum = 100.0!
        Me.KremerShape6.FillMinimum = 0.0!
        Me.KremerShape6.Line = True
        Me.KremerShape6.LineColor = System.Drawing.Color.Black
        Me.KremerShape6.LineColorOn = System.Drawing.Color.Black
        Me.KremerShape6.LineSize = 1
        Me.KremerShape6.Location = New System.Drawing.Point(560, 253)
        Me.KremerShape6.Name = "KremerShape6"
        Me.KremerShape6.Size = New System.Drawing.Size(15, 15)
        Me.KremerShape6.Style = KremerControlsWin32.KremerShape.LineStyle.Solid
        Me.KremerShape6.TabIndex = 351
        Me.KremerShape6.Text = "KremerShape6"
        Me.KremerShape6.Type = KremerControlsWin32.KremerShape.ShapeType.TriangleRight
        '
        'KremerShape7
        '
        Me.KremerShape7.Data = False
        Me.KremerShape7.Fill = True
        Me.KremerShape7.FillColor = System.Drawing.SystemColors.Control
        Me.KremerShape7.FillColorOn = System.Drawing.SystemColors.Control
        Me.KremerShape7.FillDirection = KremerControlsWin32.KremerShape.Direction.Up
        Me.KremerShape7.FillLevel = 100.0!
        Me.KremerShape7.FillMaximum = 100.0!
        Me.KremerShape7.FillMinimum = 0.0!
        Me.KremerShape7.Line = True
        Me.KremerShape7.LineColor = System.Drawing.Color.Black
        Me.KremerShape7.LineColorOn = System.Drawing.Color.Black
        Me.KremerShape7.LineSize = 1
        Me.KremerShape7.Location = New System.Drawing.Point(50, 253)
        Me.KremerShape7.Name = "KremerShape7"
        Me.KremerShape7.Size = New System.Drawing.Size(15, 15)
        Me.KremerShape7.Style = KremerControlsWin32.KremerShape.LineStyle.Solid
        Me.KremerShape7.TabIndex = 354
        Me.KremerShape7.Text = "KremerShape7"
        Me.KremerShape7.Type = KremerControlsWin32.KremerShape.ShapeType.TriangleLeft
        '
        'KremerShape8
        '
        Me.KremerShape8.Data = False
        Me.KremerShape8.Fill = True
        Me.KremerShape8.FillColor = System.Drawing.SystemColors.Control
        Me.KremerShape8.FillColorOn = System.Drawing.SystemColors.Control
        Me.KremerShape8.FillDirection = KremerControlsWin32.KremerShape.Direction.Up
        Me.KremerShape8.FillLevel = 100.0!
        Me.KremerShape8.FillMaximum = 100.0!
        Me.KremerShape8.FillMinimum = 0.0!
        Me.KremerShape8.Line = True
        Me.KremerShape8.LineColor = System.Drawing.Color.Black
        Me.KremerShape8.LineColorOn = System.Drawing.Color.Black
        Me.KremerShape8.LineSize = 1
        Me.KremerShape8.Location = New System.Drawing.Point(737, 253)
        Me.KremerShape8.Name = "KremerShape8"
        Me.KremerShape8.Size = New System.Drawing.Size(15, 15)
        Me.KremerShape8.Style = KremerControlsWin32.KremerShape.LineStyle.Solid
        Me.KremerShape8.TabIndex = 353
        Me.KremerShape8.Text = "KremerShape8"
        Me.KremerShape8.Type = KremerControlsWin32.KremerShape.ShapeType.TriangleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 7.25!)
        Me.Label1.Location = New System.Drawing.Point(65, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 12)
        Me.Label1.TabIndex = 355
        Me.Label1.Tag = ""
        Me.Label1.Text = "Drop-Off window A-Side IMD2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 7.25!)
        Me.Label2.Location = New System.Drawing.Point(241, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 12)
        Me.Label2.TabIndex = 356
        Me.Label2.Tag = ""
        Me.Label2.Text = "Drop-Off window A-Side IMD1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 7.25!)
        Me.Label3.Location = New System.Drawing.Point(416, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 12)
        Me.Label3.TabIndex = 357
        Me.Label3.Tag = ""
        Me.Label3.Text = "Drop-Off window B-Side IMD2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 7.25!)
        Me.Label4.Location = New System.Drawing.Point(591, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 12)
        Me.Label4.TabIndex = 358
        Me.Label4.Tag = ""
        Me.Label4.Text = "Drop-Off window B-Side IMD1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 7.25!)
        Me.Label5.Location = New System.Drawing.Point(325, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 12)
        Me.Label5.TabIndex = 359
        Me.Label5.Tag = ""
        Me.Label5.Text = "Total modulo of belt"
        '
        'KremerLight1
        '
        Me.KremerLight1.ColorOff = System.Drawing.Color.LightGray
        Me.KremerLight1.ColorOn = System.Drawing.Color.Lime
        Me.KremerLight1.Data = False
        Me.KremerLight1.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerLight1.Line = True
        Me.KremerLight1.LineSize = 1
        Me.KremerLight1.Location = New System.Drawing.Point(323, 277)
        Me.KremerLight1.Name = "KremerLight1"
        Me.KremerLight1.Size = New System.Drawing.Size(18, 18)
        Me.KremerLight1.TabIndex = 364
        Me.KremerLight1.Tag = ""
        Me.KremerLight1.Text = "1"
        Me.KremerLight1.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KremerLight6
        '
        Me.KremerLight6.ColorOff = System.Drawing.Color.LightGray
        Me.KremerLight6.ColorOn = System.Drawing.Color.Lime
        Me.KremerLight6.Data = False
        Me.KremerLight6.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerLight6.Line = True
        Me.KremerLight6.LineSize = 1
        Me.KremerLight6.Location = New System.Drawing.Point(276, 277)
        Me.KremerLight6.Name = "KremerLight6"
        Me.KremerLight6.Size = New System.Drawing.Size(18, 18)
        Me.KremerLight6.TabIndex = 363
        Me.KremerLight6.Tag = ""
        Me.KremerLight6.Text = "1"
        Me.KremerLight6.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KremerLight7
        '
        Me.KremerLight7.ColorOff = System.Drawing.Color.LightGray
        Me.KremerLight7.ColorOn = System.Drawing.Color.Lime
        Me.KremerLight7.Data = False
        Me.KremerLight7.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerLight7.Line = True
        Me.KremerLight7.LineSize = 1
        Me.KremerLight7.Location = New System.Drawing.Point(259, 277)
        Me.KremerLight7.Name = "KremerLight7"
        Me.KremerLight7.Size = New System.Drawing.Size(18, 18)
        Me.KremerLight7.TabIndex = 362
        Me.KremerLight7.Tag = ""
        Me.KremerLight7.Text = "1"
        Me.KremerLight7.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KremerLight8
        '
        Me.KremerLight8.ColorOff = System.Drawing.Color.LightGray
        Me.KremerLight8.ColorOn = System.Drawing.Color.Lime
        Me.KremerLight8.Data = False
        Me.KremerLight8.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerLight8.Line = True
        Me.KremerLight8.LineSize = 1
        Me.KremerLight8.Location = New System.Drawing.Point(242, 277)
        Me.KremerLight8.Name = "KremerLight8"
        Me.KremerLight8.Size = New System.Drawing.Size(18, 18)
        Me.KremerLight8.TabIndex = 361
        Me.KremerLight8.Tag = ""
        Me.KremerLight8.Text = "1"
        Me.KremerLight8.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KremerLight9
        '
        Me.KremerLight9.ColorOff = System.Drawing.Color.LightGray
        Me.KremerLight9.ColorOn = System.Drawing.Color.Lime
        Me.KremerLight9.Data = False
        Me.KremerLight9.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerLight9.Line = True
        Me.KremerLight9.LineSize = 1
        Me.KremerLight9.Location = New System.Drawing.Point(225, 277)
        Me.KremerLight9.Name = "KremerLight9"
        Me.KremerLight9.Size = New System.Drawing.Size(18, 18)
        Me.KremerLight9.TabIndex = 360
        Me.KremerLight9.Tag = ""
        Me.KremerLight9.Text = "1"
        Me.KremerLight9.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KremerLight16
        '
        Me.KremerLight16.ColorOff = System.Drawing.Color.LightGray
        Me.KremerLight16.ColorOn = System.Drawing.Color.Lime
        Me.KremerLight16.Data = False
        Me.KremerLight16.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerLight16.Line = True
        Me.KremerLight16.LineSize = 1
        Me.KremerLight16.Location = New System.Drawing.Point(499, 277)
        Me.KremerLight16.Name = "KremerLight16"
        Me.KremerLight16.Size = New System.Drawing.Size(18, 18)
        Me.KremerLight16.TabIndex = 369
        Me.KremerLight16.Tag = ""
        Me.KremerLight16.Text = "1"
        Me.KremerLight16.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KremerLight17
        '
        Me.KremerLight17.ColorOff = System.Drawing.Color.LightGray
        Me.KremerLight17.ColorOn = System.Drawing.Color.Lime
        Me.KremerLight17.Data = False
        Me.KremerLight17.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerLight17.Line = True
        Me.KremerLight17.LineSize = 1
        Me.KremerLight17.Location = New System.Drawing.Point(452, 277)
        Me.KremerLight17.Name = "KremerLight17"
        Me.KremerLight17.Size = New System.Drawing.Size(18, 18)
        Me.KremerLight17.TabIndex = 368
        Me.KremerLight17.Tag = ""
        Me.KremerLight17.Text = "1"
        Me.KremerLight17.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KremerLight18
        '
        Me.KremerLight18.ColorOff = System.Drawing.Color.LightGray
        Me.KremerLight18.ColorOn = System.Drawing.Color.Lime
        Me.KremerLight18.Data = False
        Me.KremerLight18.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerLight18.Line = True
        Me.KremerLight18.LineSize = 1
        Me.KremerLight18.Location = New System.Drawing.Point(435, 277)
        Me.KremerLight18.Name = "KremerLight18"
        Me.KremerLight18.Size = New System.Drawing.Size(18, 18)
        Me.KremerLight18.TabIndex = 367
        Me.KremerLight18.Tag = ""
        Me.KremerLight18.Text = "1"
        Me.KremerLight18.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KremerLight19
        '
        Me.KremerLight19.ColorOff = System.Drawing.Color.LightGray
        Me.KremerLight19.ColorOn = System.Drawing.Color.Lime
        Me.KremerLight19.Data = False
        Me.KremerLight19.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerLight19.Line = True
        Me.KremerLight19.LineSize = 1
        Me.KremerLight19.Location = New System.Drawing.Point(418, 277)
        Me.KremerLight19.Name = "KremerLight19"
        Me.KremerLight19.Size = New System.Drawing.Size(18, 18)
        Me.KremerLight19.TabIndex = 366
        Me.KremerLight19.Tag = ""
        Me.KremerLight19.Text = "1"
        Me.KremerLight19.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KremerLight20
        '
        Me.KremerLight20.ColorOff = System.Drawing.Color.LightGray
        Me.KremerLight20.ColorOn = System.Drawing.Color.Lime
        Me.KremerLight20.Data = False
        Me.KremerLight20.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerLight20.Line = True
        Me.KremerLight20.LineSize = 1
        Me.KremerLight20.Location = New System.Drawing.Point(401, 277)
        Me.KremerLight20.Name = "KremerLight20"
        Me.KremerLight20.Size = New System.Drawing.Size(18, 18)
        Me.KremerLight20.TabIndex = 365
        Me.KremerLight20.Tag = ""
        Me.KremerLight20.Text = "1"
        Me.KremerLight20.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KremerLight21
        '
        Me.KremerLight21.ColorOff = System.Drawing.Color.LightGray
        Me.KremerLight21.ColorOn = System.Drawing.Color.Lime
        Me.KremerLight21.Data = False
        Me.KremerLight21.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerLight21.Line = True
        Me.KremerLight21.LineSize = 1
        Me.KremerLight21.Location = New System.Drawing.Point(674, 277)
        Me.KremerLight21.Name = "KremerLight21"
        Me.KremerLight21.Size = New System.Drawing.Size(18, 18)
        Me.KremerLight21.TabIndex = 374
        Me.KremerLight21.Tag = ""
        Me.KremerLight21.Text = "1"
        Me.KremerLight21.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KremerLight22
        '
        Me.KremerLight22.ColorOff = System.Drawing.Color.LightGray
        Me.KremerLight22.ColorOn = System.Drawing.Color.Lime
        Me.KremerLight22.Data = False
        Me.KremerLight22.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerLight22.Line = True
        Me.KremerLight22.LineSize = 1
        Me.KremerLight22.Location = New System.Drawing.Point(627, 277)
        Me.KremerLight22.Name = "KremerLight22"
        Me.KremerLight22.Size = New System.Drawing.Size(18, 18)
        Me.KremerLight22.TabIndex = 373
        Me.KremerLight22.Tag = ""
        Me.KremerLight22.Text = "1"
        Me.KremerLight22.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KremerLight23
        '
        Me.KremerLight23.ColorOff = System.Drawing.Color.LightGray
        Me.KremerLight23.ColorOn = System.Drawing.Color.Lime
        Me.KremerLight23.Data = False
        Me.KremerLight23.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerLight23.Line = True
        Me.KremerLight23.LineSize = 1
        Me.KremerLight23.Location = New System.Drawing.Point(610, 277)
        Me.KremerLight23.Name = "KremerLight23"
        Me.KremerLight23.Size = New System.Drawing.Size(18, 18)
        Me.KremerLight23.TabIndex = 372
        Me.KremerLight23.Tag = ""
        Me.KremerLight23.Text = "1"
        Me.KremerLight23.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KremerLight24
        '
        Me.KremerLight24.ColorOff = System.Drawing.Color.LightGray
        Me.KremerLight24.ColorOn = System.Drawing.Color.Lime
        Me.KremerLight24.Data = False
        Me.KremerLight24.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerLight24.Line = True
        Me.KremerLight24.LineSize = 1
        Me.KremerLight24.Location = New System.Drawing.Point(593, 277)
        Me.KremerLight24.Name = "KremerLight24"
        Me.KremerLight24.Size = New System.Drawing.Size(18, 18)
        Me.KremerLight24.TabIndex = 371
        Me.KremerLight24.Tag = ""
        Me.KremerLight24.Text = "1"
        Me.KremerLight24.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KremerLight25
        '
        Me.KremerLight25.ColorOff = System.Drawing.Color.LightGray
        Me.KremerLight25.ColorOn = System.Drawing.Color.Lime
        Me.KremerLight25.Data = False
        Me.KremerLight25.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerLight25.Line = True
        Me.KremerLight25.LineSize = 1
        Me.KremerLight25.Location = New System.Drawing.Point(576, 277)
        Me.KremerLight25.Name = "KremerLight25"
        Me.KremerLight25.Size = New System.Drawing.Size(18, 18)
        Me.KremerLight25.TabIndex = 370
        Me.KremerLight25.Tag = ""
        Me.KremerLight25.Text = "1"
        Me.KremerLight25.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 23)
        Me.Label7.TabIndex = 377
        Me.Label7.Tag = ""
        Me.Label7.Text = "Actual modulo:"
        '
        'KremerIoField1
        '
        Me.KremerIoField1.Audit = Nothing
        Me.KremerIoField1.AuditEnabled = False
        Me.KremerIoField1.AuditMessage = "KremerIoField changed:"
        Me.KremerIoField1.AuditSource = "KremerIoField"
        Me.KremerIoField1.BackColor = System.Drawing.Color.Transparent
        Me.KremerIoField1.Data = 0.0R
        Me.KremerIoField1.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.KremerIoField1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.KremerIoField1.InitialValue = True
        Me.KremerIoField1.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.KremerIoField1.Location = New System.Drawing.Point(161, 99)
        Me.KremerIoField1.LowerBound = -5000.0R
        Me.KremerIoField1.Name = "KremerIoField1"
        Me.KremerIoField1.OutputFormat = "0.0"
        Me.KremerIoField1.Size = New System.Drawing.Size(100, 22)
        Me.KremerIoField1.TabIndex = 389
        Me.KremerIoField1.Text = "0.0"
        Me.KremerIoField1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.KremerIoField1.UpperBound = 5000.0R
        Me.KremerIoField1.UserInfo = Nothing
        Me.KremerIoField1.UserLevel = 0
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 23)
        Me.Label6.TabIndex = 388
        Me.Label6.Tag = ""
        Me.Label6.Text = "Actual KO:"
        '
        'SpeedControl_Overview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.Controls.Add(Me.KremerIoField1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Btn_RTO)
        Me.Controls.Add(Me.Btn_AutoManual)
        Me.Controls.Add(Me.Btn_StopAuto)
        Me.Controls.Add(Me.Btn_StartAuto)
        Me.Controls.Add(Me.IO_StartPos4)
        Me.Controls.Add(Me.IO_StartPos3)
        Me.Controls.Add(Me.IO_StartPos1)
        Me.Controls.Add(Me.IO_StartPos2)
        Me.Controls.Add(Me.IO_ActModulo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.IO_Modulo)
        Me.Controls.Add(Me.KremerLight21)
        Me.Controls.Add(Me.KremerLight22)
        Me.Controls.Add(Me.KremerLight23)
        Me.Controls.Add(Me.KremerLight24)
        Me.Controls.Add(Me.KremerLight25)
        Me.Controls.Add(Me.KremerLight16)
        Me.Controls.Add(Me.KremerLight17)
        Me.Controls.Add(Me.KremerLight18)
        Me.Controls.Add(Me.KremerLight19)
        Me.Controls.Add(Me.KremerLight20)
        Me.Controls.Add(Me.KremerLight1)
        Me.Controls.Add(Me.KremerLight6)
        Me.Controls.Add(Me.KremerLight7)
        Me.Controls.Add(Me.KremerLight8)
        Me.Controls.Add(Me.KremerLight9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.KremerShape7)
        Me.Controls.Add(Me.KremerShape8)
        Me.Controls.Add(Me.KremerShape5)
        Me.Controls.Add(Me.KremerShape6)
        Me.Controls.Add(Me.KremerShape3)
        Me.Controls.Add(Me.KremerShape4)
        Me.Controls.Add(Me.KremerShape2)
        Me.Controls.Add(Me.KremerShape1)
        Me.Controls.Add(Me.KremerLight2)
        Me.Controls.Add(Me.KremerLight3)
        Me.Controls.Add(Me.KremerLight4)
        Me.Controls.Add(Me.KremerLight5)
        Me.Controls.Add(Me.KremerLight15)
        Me.Controls.Add(Me.KremerShape11)
        Me.Controls.Add(Me.KremerShape14)
        Me.Controls.Add(Me.Btn_Settings)
        Me.Controls.Add(Me.Btn_Manual)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "SpeedControl_Overview"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "116"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Settings As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_Manual As KremerControlsWin32.KremerButton
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents mxAutomode As KremerControlsWin32.KremerVariable
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape16 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape20 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents KremerShape11 As KremerControlsWin32.KremerShape
    Friend WithEvents KremerShape14 As KremerControlsWin32.KremerShape
    Friend WithEvents KremerLight2 As KremerControlsWin32.KremerLight
    Friend WithEvents KremerLight3 As KremerControlsWin32.KremerLight
    Friend WithEvents KremerLight4 As KremerControlsWin32.KremerLight
    Friend WithEvents KremerLight5 As KremerControlsWin32.KremerLight
    Friend WithEvents KremerLight15 As KremerControlsWin32.KremerLight
    Friend WithEvents LineShape8 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents KremerShape1 As KremerControlsWin32.KremerShape
    Friend WithEvents KremerShape2 As KremerControlsWin32.KremerShape
    Friend WithEvents KremerShape3 As KremerControlsWin32.KremerShape
    Friend WithEvents KremerShape4 As KremerControlsWin32.KremerShape
    Friend WithEvents KremerShape5 As KremerControlsWin32.KremerShape
    Friend WithEvents KremerShape6 As KremerControlsWin32.KremerShape
    Friend WithEvents KremerShape7 As KremerControlsWin32.KremerShape
    Friend WithEvents KremerShape8 As KremerControlsWin32.KremerShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents KremerLight1 As KremerControlsWin32.KremerLight
    Friend WithEvents KremerLight6 As KremerControlsWin32.KremerLight
    Friend WithEvents KremerLight7 As KremerControlsWin32.KremerLight
    Friend WithEvents KremerLight8 As KremerControlsWin32.KremerLight
    Friend WithEvents KremerLight9 As KremerControlsWin32.KremerLight
    Friend WithEvents KremerLight16 As KremerControlsWin32.KremerLight
    Friend WithEvents KremerLight17 As KremerControlsWin32.KremerLight
    Friend WithEvents KremerLight18 As KremerControlsWin32.KremerLight
    Friend WithEvents KremerLight19 As KremerControlsWin32.KremerLight
    Friend WithEvents KremerLight20 As KremerControlsWin32.KremerLight
    Friend WithEvents KremerLight21 As KremerControlsWin32.KremerLight
    Friend WithEvents KremerLight22 As KremerControlsWin32.KremerLight
    Friend WithEvents KremerLight23 As KremerControlsWin32.KremerLight
    Friend WithEvents KremerLight24 As KremerControlsWin32.KremerLight
    Friend WithEvents KremerLight25 As KremerControlsWin32.KremerLight
    Friend WithEvents IO_Modulo As KremerControlsWin32.KremerIoField
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents IO_ActModulo As KremerControlsWin32.KremerIoField
    Friend WithEvents LineShape10 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape9 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents IO_StartPos2 As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_StartPos1 As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_StartPos3 As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_StartPos4 As KremerControlsWin32.KremerIoField
    Friend WithEvents TotalModulo As KremerControlsWin32.KremerVariable
    Friend WithEvents StartPosGantry1 As KremerControlsWin32.KremerVariable
    Friend WithEvents StartPosGantry2 As KremerControlsWin32.KremerVariable
    Friend WithEvents StartPosGantry3 As KremerControlsWin32.KremerVariable
    Friend WithEvents StartPosGantry4 As KremerControlsWin32.KremerVariable
    Friend WithEvents hmiStart As KremerControlsWin32.KremerVariable
    Friend WithEvents Btn_StartAuto As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_StopAuto As KremerControlsWin32.KremerButton
    Friend WithEvents hmiStop As KremerControlsWin32.KremerVariable
    Friend WithEvents Btn_AutoManual As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_RTO As KremerControlsWin32.KremerButton
    Friend WithEvents FTL_RTO As KremerControlsWin32.KremerVariable
    Friend WithEvents ActualModulo As KremerControlsWin32.KremerVariable
    Friend WithEvents StartState As KremerControlsWin32.KremerVariable
    Friend WithEvents StopState As KremerControlsWin32.KremerVariable
    Friend WithEvents KremerIoField1 As KremerControlsWin32.KremerIoField
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
