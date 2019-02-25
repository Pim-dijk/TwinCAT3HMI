<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Overview
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnTakeOutUnitA = New System.Windows.Forms.Button()
        Me.BtnDryingMoldA = New System.Windows.Forms.Button()
        Me.BtnTakeOutUnitB = New System.Windows.Forms.Button()
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.BtnPause = New KremerControlsWin32.KremerButton()
        Me.BtnStart = New KremerControlsWin32.KremerButton()
        Me.BtnStop = New KremerControlsWin32.KremerButton()
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.IMD_States = New KremerControlsWin32.KremerVariable(Me.components)
        Me.StatusIMD = New KremerControlsWin32.KremerTextField(Me.components)
        Me.PH_States = New KremerControlsWin32.KremerVariable(Me.components)
        Me.StatusPH = New KremerControlsWin32.KremerTextField(Me.components)
        Me.DoorZone1Left = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AL_Z1left = New KremerControlsWin32.KremerLight()
        Me.DoorZone1Right = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AL_Z1Right = New KremerControlsWin32.KremerLight()
        Me.DoorZone2Front = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AL_Z2Front = New KremerControlsWin32.KremerLight()
        Me.DoorZone2BackLeft = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AL_Z2BackLeft = New KremerControlsWin32.KremerLight()
        Me.DoorZone2BackRight = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AL_Z2BackRight = New KremerControlsWin32.KremerLight()
        Me.DoorZone3Front = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AL_Z3Front = New KremerControlsWin32.KremerLight()
        Me.DoorZone3BackLeft = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AL_Z3BackLeft = New KremerControlsWin32.KremerLight()
        Me.DoorZone3BackRight = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AL_Z3BackRight = New KremerControlsWin32.KremerLight()
        Me.DoorZone4Front = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AL_Z4Front = New KremerControlsWin32.KremerLight()
        Me.DoorZone4BackLeft = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AL_Z4BackLeft = New KremerControlsWin32.KremerLight()
        Me.DoorZone4BackRight = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AL_Z4BackRight = New KremerControlsWin32.KremerLight()
        Me.DoorZone5Left = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AL_Z5Left = New KremerControlsWin32.KremerLight()
        Me.DoorZone5Right = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AL_Z5Right = New KremerControlsWin32.KremerLight()
        Me.DoorZone6Back = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AL_Z6Back = New KremerControlsWin32.KremerLight()
        Me.DoorZone7back = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AL_Z7Back = New KremerControlsWin32.KremerLight()
        Me.mxManualAutomode = New KremerControlsWin32.KremerVariable(Me.components)
        Me.btnAutoManual = New KremerControlsWin32.KremerButton()
        Me.ActSingleSideA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_SingleA = New KremerControlsWin32.KremerButton()
        Me.StateSingleA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ActSingleSideB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_SingleB = New KremerControlsWin32.KremerButton()
        Me.StateSingleB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.EnableTakeout = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BTN_EnableTakeout = New KremerControlsWin32.KremerButton()
        Me.mxStart = New KremerControlsWin32.KremerVariable(Me.components)
        Me.mxPause = New KremerControlsWin32.KremerVariable(Me.components)
        Me.mxStop = New KremerControlsWin32.KremerVariable(Me.components)
        Me.StartState = New KremerControlsWin32.KremerVariable(Me.components)
        Me.StopState = New KremerControlsWin32.KremerVariable(Me.components)
        Me.PauseState = New KremerControlsWin32.KremerVariable(Me.components)
        Me.actKickofss = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_ActKickOffs = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnDryingMoldB = New System.Windows.Forms.Button()
        Me.BtnPulp = New System.Windows.Forms.Button()
        Me.BtnTransferMold = New System.Windows.Forms.Button()
        Me.BtnOutfeed = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnGantryB = New System.Windows.Forms.Button()
        Me.BtnGantryA = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.KremerLight10 = New KremerControlsWin32.KremerLight()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.KremerLight11 = New KremerControlsWin32.KremerLight()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.KremerLight14 = New KremerControlsWin32.KremerLight()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.KremerLight16 = New KremerControlsWin32.KremerLight()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.PnlDoors = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.PnlDoors.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnTakeOutUnitA
        '
        Me.BtnTakeOutUnitA.BackColor = System.Drawing.Color.Transparent
        Me.BtnTakeOutUnitA.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnTakeOutUnitA.FlatAppearance.BorderSize = 0
        Me.BtnTakeOutUnitA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnTakeOutUnitA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnTakeOutUnitA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTakeOutUnitA.Location = New System.Drawing.Point(59, 156)
        Me.BtnTakeOutUnitA.Name = "BtnTakeOutUnitA"
        Me.BtnTakeOutUnitA.Size = New System.Drawing.Size(79, 62)
        Me.BtnTakeOutUnitA.TabIndex = 2
        Me.BtnTakeOutUnitA.UseVisualStyleBackColor = False
        '
        'BtnDryingMoldA
        '
        Me.BtnDryingMoldA.BackColor = System.Drawing.Color.Transparent
        Me.BtnDryingMoldA.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnDryingMoldA.FlatAppearance.BorderSize = 0
        Me.BtnDryingMoldA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnDryingMoldA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnDryingMoldA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDryingMoldA.Location = New System.Drawing.Point(164, 125)
        Me.BtnDryingMoldA.Name = "BtnDryingMoldA"
        Me.BtnDryingMoldA.Size = New System.Drawing.Size(65, 76)
        Me.BtnDryingMoldA.TabIndex = 0
        Me.BtnDryingMoldA.UseVisualStyleBackColor = False
        '
        'BtnTakeOutUnitB
        '
        Me.BtnTakeOutUnitB.BackColor = System.Drawing.Color.Transparent
        Me.BtnTakeOutUnitB.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnTakeOutUnitB.FlatAppearance.BorderSize = 0
        Me.BtnTakeOutUnitB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnTakeOutUnitB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnTakeOutUnitB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTakeOutUnitB.Location = New System.Drawing.Point(418, 167)
        Me.BtnTakeOutUnitB.Name = "BtnTakeOutUnitB"
        Me.BtnTakeOutUnitB.Size = New System.Drawing.Size(81, 51)
        Me.BtnTakeOutUnitB.TabIndex = 3
        Me.BtnTakeOutUnitB.UseVisualStyleBackColor = False
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'BtnPause
        '
        Me.BtnPause.Audit = Nothing
        Me.BtnPause.AuditEnabled = False
        Me.BtnPause.AuditMessage = "KremerPushButton pressed!"
        Me.BtnPause.AuditSource = "KremerPushButton"
        Me.BtnPause.BackColor = System.Drawing.SystemColors.Control
        Me.BtnPause.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPause.BackGroundImageOn = Nothing
        Me.BtnPause.ButtonAction = KremerControlsWin32.KremerButton.Action.SetBool
        Me.BtnPause.Data = False
        Me.BtnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPause.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPause.ForeColorOn = System.Drawing.SystemColors.ControlDark
        Me.BtnPause.Location = New System.Drawing.Point(115, 385)
        Me.BtnPause.Name = "BtnPause"
        Me.BtnPause.Size = New System.Drawing.Size(114, 50)
        Me.BtnPause.State = False
        Me.BtnPause.StateIsData = False
        Me.BtnPause.StateText = New String() {Nothing, Nothing}
        Me.BtnPause.TabIndex = 285
        Me.BtnPause.Tag = "76"
        Me.BtnPause.Text = "Pause"
        Me.BtnPause.UserInfo = Nothing
        Me.BtnPause.UserLevel = 0
        Me.BtnPause.UseStateText = False
        Me.BtnPause.UseVisualStyleBackColor = False
        '
        'BtnStart
        '
        Me.BtnStart.Audit = Nothing
        Me.BtnStart.AuditEnabled = False
        Me.BtnStart.AuditMessage = "KremerPushButton pressed!"
        Me.BtnStart.AuditSource = "KremerPushButton"
        Me.BtnStart.BackColor = System.Drawing.SystemColors.Control
        Me.BtnStart.BackColorOn = System.Drawing.Color.Green
        Me.BtnStart.BackGroundImageOn = Nothing
        Me.BtnStart.ButtonAction = KremerControlsWin32.KremerButton.Action.SetBool
        Me.BtnStart.Data = False
        Me.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStart.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnStart.ForeColorOn = System.Drawing.Color.White
        Me.BtnStart.Location = New System.Drawing.Point(1, 385)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(114, 50)
        Me.BtnStart.State = False
        Me.BtnStart.StateIsData = False
        Me.BtnStart.StateText = New String() {Nothing, Nothing}
        Me.BtnStart.TabIndex = 284
        Me.BtnStart.Tag = "53"
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UserInfo = Nothing
        Me.BtnStart.UserLevel = 0
        Me.BtnStart.UseStateText = False
        Me.BtnStart.UseVisualStyleBackColor = False
        '
        'BtnStop
        '
        Me.BtnStop.Audit = Nothing
        Me.BtnStop.AuditEnabled = False
        Me.BtnStop.AuditMessage = "KremerPushButton pressed!"
        Me.BtnStop.AuditSource = "KremerPushButton"
        Me.BtnStop.BackColor = System.Drawing.SystemColors.Control
        Me.BtnStop.BackColorOn = System.Drawing.Color.Red
        Me.BtnStop.BackGroundImageOn = Nothing
        Me.BtnStop.ButtonAction = KremerControlsWin32.KremerButton.Action.SetBool
        Me.BtnStop.Data = False
        Me.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStop.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnStop.ForeColorOn = System.Drawing.Color.Black
        Me.BtnStop.Location = New System.Drawing.Point(229, 385)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(114, 50)
        Me.BtnStop.State = False
        Me.BtnStop.StateIsData = False
        Me.BtnStop.StateText = New String() {Nothing, Nothing}
        Me.BtnStop.TabIndex = 282
        Me.BtnStop.Tag = "54"
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.UserInfo = Nothing
        Me.BtnStop.UserLevel = 0
        Me.BtnStop.UseStateText = False
        Me.BtnStop.UseVisualStyleBackColor = False
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.IMD_States)
        Me.VarCollector.Variables.Add(Me.PH_States)
        Me.VarCollector.Variables.Add(Me.DoorZone1Left)
        Me.VarCollector.Variables.Add(Me.DoorZone1Right)
        Me.VarCollector.Variables.Add(Me.DoorZone2Front)
        Me.VarCollector.Variables.Add(Me.DoorZone2BackLeft)
        Me.VarCollector.Variables.Add(Me.DoorZone2BackRight)
        Me.VarCollector.Variables.Add(Me.DoorZone3Front)
        Me.VarCollector.Variables.Add(Me.DoorZone3BackLeft)
        Me.VarCollector.Variables.Add(Me.DoorZone3BackRight)
        Me.VarCollector.Variables.Add(Me.DoorZone4Front)
        Me.VarCollector.Variables.Add(Me.DoorZone4BackLeft)
        Me.VarCollector.Variables.Add(Me.DoorZone4BackRight)
        Me.VarCollector.Variables.Add(Me.DoorZone5Left)
        Me.VarCollector.Variables.Add(Me.DoorZone5Right)
        Me.VarCollector.Variables.Add(Me.DoorZone6Back)
        Me.VarCollector.Variables.Add(Me.DoorZone7back)
        Me.VarCollector.Variables.Add(Me.mxManualAutomode)
        Me.VarCollector.Variables.Add(Me.ActSingleSideA)
        Me.VarCollector.Variables.Add(Me.StateSingleA)
        Me.VarCollector.Variables.Add(Me.ActSingleSideB)
        Me.VarCollector.Variables.Add(Me.StateSingleB)
        Me.VarCollector.Variables.Add(Me.EnableTakeout)
        Me.VarCollector.Variables.Add(Me.mxStart)
        Me.VarCollector.Variables.Add(Me.mxPause)
        Me.VarCollector.Variables.Add(Me.mxStop)
        Me.VarCollector.Variables.Add(Me.StartState)
        Me.VarCollector.Variables.Add(Me.StopState)
        Me.VarCollector.Variables.Add(Me.PauseState)
        Me.VarCollector.Variables.Add(Me.actKickofss)
        '
        'IMD_States
        '
        Me.IMD_States.BindControl = Me.StatusIMD
        Me.IMD_States.BindProperty = "Data"
        Me.IMD_States.Data = Nothing
        Me.IMD_States.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.IMD_States.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.IMD_States.VariableName = "MAIN.InMoldDrying.sCycleStateText"
        '
        'StatusIMD
        '
        Me.StatusIMD.Audit = Nothing
        Me.StatusIMD.AuditEnabled = False
        Me.StatusIMD.AuditMessage = "KremerTextField changed:"
        Me.StatusIMD.AuditSource = "KremerTextField"
        Me.StatusIMD.AutoSize = True
        Me.StatusIMD.BackColorOn = System.Drawing.Color.Empty
        Me.StatusIMD.Data = "Text"
        Me.StatusIMD.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusIMD.ForeColorOn = System.Drawing.Color.Empty
        Me.StatusIMD.InitialValue = True
        Me.StatusIMD.IOType = KremerControlsWin32.KremerTextField.IO_Type.InputOutput
        Me.StatusIMD.Location = New System.Drawing.Point(147, 338)
        Me.StatusIMD.Name = "StatusIMD"
        Me.StatusIMD.PasswordMask = False
        Me.StatusIMD.Size = New System.Drawing.Size(39, 18)
        Me.StatusIMD.State = False
        Me.StatusIMD.TabIndex = 349
        Me.StatusIMD.Text = "Text"
        Me.StatusIMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StatusIMD.UserInfo = Nothing
        Me.StatusIMD.UserLevel = 0
        '
        'PH_States
        '
        Me.PH_States.BindControl = Me.StatusPH
        Me.PH_States.BindProperty = "Data"
        Me.PH_States.Data = Nothing
        Me.PH_States.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.PH_States.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PH_States.VariableName = "MAIN.ProductHandling.sCycleStateText"
        '
        'StatusPH
        '
        Me.StatusPH.Audit = Nothing
        Me.StatusPH.AuditEnabled = False
        Me.StatusPH.AuditMessage = "KremerTextField changed:"
        Me.StatusPH.AuditSource = "KremerTextField"
        Me.StatusPH.AutoSize = True
        Me.StatusPH.BackColorOn = System.Drawing.Color.Empty
        Me.StatusPH.Data = "Text"
        Me.StatusPH.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusPH.ForeColorOn = System.Drawing.Color.Empty
        Me.StatusPH.InitialValue = True
        Me.StatusPH.IOType = KremerControlsWin32.KremerTextField.IO_Type.InputOutput
        Me.StatusPH.Location = New System.Drawing.Point(147, 361)
        Me.StatusPH.Name = "StatusPH"
        Me.StatusPH.PasswordMask = False
        Me.StatusPH.Size = New System.Drawing.Size(39, 18)
        Me.StatusPH.State = False
        Me.StatusPH.TabIndex = 350
        Me.StatusPH.Text = "Text"
        Me.StatusPH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StatusPH.UserInfo = Nothing
        Me.StatusPH.UserLevel = 0
        '
        'DoorZone1Left
        '
        Me.DoorZone1Left.BindControl = Me.AL_Z1left
        Me.DoorZone1Left.BindProperty = "Data"
        Me.DoorZone1Left.Data = Nothing
        Me.DoorZone1Left.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.DoorZone1Left.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.DoorZone1Left.VariableName = "MAIN.Errors.exGantryB_FrontDoorLeft"
        '
        'AL_Z1left
        '
        Me.AL_Z1left.ColorOff = System.Drawing.Color.Silver
        Me.AL_Z1left.ColorOn = System.Drawing.Color.Red
        Me.AL_Z1left.Data = False
        Me.AL_Z1left.Line = True
        Me.AL_Z1left.LineSize = 1
        Me.AL_Z1left.Location = New System.Drawing.Point(20, 21)
        Me.AL_Z1left.Name = "AL_Z1left"
        Me.AL_Z1left.Size = New System.Drawing.Size(15, 15)
        Me.AL_Z1left.TabIndex = 10
        Me.AL_Z1left.Text = "KremerLight19"
        Me.AL_Z1left.Type = KremerControlsWin32.KremerLight.GraphicType.Rectangle
        '
        'DoorZone1Right
        '
        Me.DoorZone1Right.BindControl = Me.AL_Z1Right
        Me.DoorZone1Right.BindProperty = "Data"
        Me.DoorZone1Right.Data = Nothing
        Me.DoorZone1Right.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.DoorZone1Right.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.DoorZone1Right.VariableName = "MAIN.Errors.exGantryB_FrontDoorRight"
        '
        'AL_Z1Right
        '
        Me.AL_Z1Right.ColorOff = System.Drawing.Color.Silver
        Me.AL_Z1Right.ColorOn = System.Drawing.Color.Red
        Me.AL_Z1Right.Data = False
        Me.AL_Z1Right.Line = True
        Me.AL_Z1Right.LineSize = 1
        Me.AL_Z1Right.Location = New System.Drawing.Point(20, 7)
        Me.AL_Z1Right.Name = "AL_Z1Right"
        Me.AL_Z1Right.Size = New System.Drawing.Size(15, 15)
        Me.AL_Z1Right.TabIndex = 0
        Me.AL_Z1Right.Text = "KremerLight13"
        Me.AL_Z1Right.Type = KremerControlsWin32.KremerLight.GraphicType.Rectangle
        '
        'DoorZone2Front
        '
        Me.DoorZone2Front.BindControl = Me.AL_Z2Front
        Me.DoorZone2Front.BindProperty = "Data"
        Me.DoorZone2Front.Data = Nothing
        Me.DoorZone2Front.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.DoorZone2Front.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.DoorZone2Front.VariableName = "MAIN.Errors.exImdFrontDoorLeft"
        '
        'AL_Z2Front
        '
        Me.AL_Z2Front.ColorOff = System.Drawing.Color.Silver
        Me.AL_Z2Front.ColorOn = System.Drawing.Color.Red
        Me.AL_Z2Front.Data = False
        Me.AL_Z2Front.Line = True
        Me.AL_Z2Front.LineSize = 1
        Me.AL_Z2Front.Location = New System.Drawing.Point(8, 35)
        Me.AL_Z2Front.Name = "AL_Z2Front"
        Me.AL_Z2Front.Size = New System.Drawing.Size(15, 15)
        Me.AL_Z2Front.TabIndex = 7
        Me.AL_Z2Front.Text = "KremerLight7"
        Me.AL_Z2Front.Type = KremerControlsWin32.KremerLight.GraphicType.Rectangle
        '
        'DoorZone2BackLeft
        '
        Me.DoorZone2BackLeft.BindControl = Me.AL_Z2BackLeft
        Me.DoorZone2BackLeft.BindProperty = "Data"
        Me.DoorZone2BackLeft.Data = Nothing
        Me.DoorZone2BackLeft.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.DoorZone2BackLeft.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.DoorZone2BackLeft.VariableName = "MAIN.Errors.exImdBackDoorLeft1"
        '
        'AL_Z2BackLeft
        '
        Me.AL_Z2BackLeft.ColorOff = System.Drawing.Color.Silver
        Me.AL_Z2BackLeft.ColorOn = System.Drawing.Color.Red
        Me.AL_Z2BackLeft.Data = False
        Me.AL_Z2BackLeft.Line = True
        Me.AL_Z2BackLeft.LineSize = 1
        Me.AL_Z2BackLeft.Location = New System.Drawing.Point(0, -3)
        Me.AL_Z2BackLeft.Name = "AL_Z2BackLeft"
        Me.AL_Z2BackLeft.Size = New System.Drawing.Size(15, 15)
        Me.AL_Z2BackLeft.TabIndex = 4
        Me.AL_Z2BackLeft.Text = "AL_Z4BackLeft"
        Me.AL_Z2BackLeft.Type = KremerControlsWin32.KremerLight.GraphicType.Rectangle
        '
        'DoorZone2BackRight
        '
        Me.DoorZone2BackRight.BindControl = Me.AL_Z2BackRight
        Me.DoorZone2BackRight.BindProperty = "Data"
        Me.DoorZone2BackRight.Data = Nothing
        Me.DoorZone2BackRight.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.DoorZone2BackRight.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.DoorZone2BackRight.VariableName = "MAIN.Errors.exImdBackDoorLeft2"
        '
        'AL_Z2BackRight
        '
        Me.AL_Z2BackRight.ColorOff = System.Drawing.Color.Silver
        Me.AL_Z2BackRight.ColorOn = System.Drawing.Color.Red
        Me.AL_Z2BackRight.Data = False
        Me.AL_Z2BackRight.Line = True
        Me.AL_Z2BackRight.LineSize = 1
        Me.AL_Z2BackRight.Location = New System.Drawing.Point(16, -3)
        Me.AL_Z2BackRight.Name = "AL_Z2BackRight"
        Me.AL_Z2BackRight.Size = New System.Drawing.Size(15, 15)
        Me.AL_Z2BackRight.TabIndex = 4
        Me.AL_Z2BackRight.Text = "AL_Z4BackRight"
        Me.AL_Z2BackRight.Type = KremerControlsWin32.KremerLight.GraphicType.Rectangle
        '
        'DoorZone3Front
        '
        Me.DoorZone3Front.BindControl = Me.AL_Z3Front
        Me.DoorZone3Front.BindProperty = "Data"
        Me.DoorZone3Front.Data = Nothing
        Me.DoorZone3Front.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.DoorZone3Front.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.DoorZone3Front.VariableName = "MAIN.Errors.exImdFrontDoorMiddle"
        '
        'AL_Z3Front
        '
        Me.AL_Z3Front.ColorOff = System.Drawing.Color.Silver
        Me.AL_Z3Front.ColorOn = System.Drawing.Color.Red
        Me.AL_Z3Front.Data = False
        Me.AL_Z3Front.Line = True
        Me.AL_Z3Front.LineSize = 1
        Me.AL_Z3Front.Location = New System.Drawing.Point(8, 35)
        Me.AL_Z3Front.Name = "AL_Z3Front"
        Me.AL_Z3Front.Size = New System.Drawing.Size(15, 15)
        Me.AL_Z3Front.TabIndex = 7
        Me.AL_Z3Front.Text = "KremerLight2"
        Me.AL_Z3Front.Type = KremerControlsWin32.KremerLight.GraphicType.Rectangle
        '
        'DoorZone3BackLeft
        '
        Me.DoorZone3BackLeft.BindControl = Me.AL_Z3BackLeft
        Me.DoorZone3BackLeft.BindProperty = "Data"
        Me.DoorZone3BackLeft.Data = Nothing
        Me.DoorZone3BackLeft.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.DoorZone3BackLeft.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.DoorZone3BackLeft.VariableName = "MAIN.Errors.exImdBackDoorMiddle3"
        '
        'AL_Z3BackLeft
        '
        Me.AL_Z3BackLeft.ColorOff = System.Drawing.Color.Silver
        Me.AL_Z3BackLeft.ColorOn = System.Drawing.Color.Red
        Me.AL_Z3BackLeft.Data = False
        Me.AL_Z3BackLeft.Line = True
        Me.AL_Z3BackLeft.LineSize = 1
        Me.AL_Z3BackLeft.Location = New System.Drawing.Point(0, -3)
        Me.AL_Z3BackLeft.Name = "AL_Z3BackLeft"
        Me.AL_Z3BackLeft.Size = New System.Drawing.Size(15, 15)
        Me.AL_Z3BackLeft.TabIndex = 4
        Me.AL_Z3BackLeft.Text = "AL_Z3BackLeft"
        Me.AL_Z3BackLeft.Type = KremerControlsWin32.KremerLight.GraphicType.Rectangle
        '
        'DoorZone3BackRight
        '
        Me.DoorZone3BackRight.BindControl = Me.AL_Z3BackRight
        Me.DoorZone3BackRight.BindProperty = "Data"
        Me.DoorZone3BackRight.Data = Nothing
        Me.DoorZone3BackRight.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.DoorZone3BackRight.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.DoorZone3BackRight.VariableName = "MAIN.Errors.exImdBackDoorMiddle4"
        '
        'AL_Z3BackRight
        '
        Me.AL_Z3BackRight.ColorOff = System.Drawing.Color.Silver
        Me.AL_Z3BackRight.ColorOn = System.Drawing.Color.Red
        Me.AL_Z3BackRight.Data = False
        Me.AL_Z3BackRight.Line = True
        Me.AL_Z3BackRight.LineSize = 1
        Me.AL_Z3BackRight.Location = New System.Drawing.Point(16, -3)
        Me.AL_Z3BackRight.Name = "AL_Z3BackRight"
        Me.AL_Z3BackRight.Size = New System.Drawing.Size(15, 15)
        Me.AL_Z3BackRight.TabIndex = 4
        Me.AL_Z3BackRight.Text = "AL_Z3BackRight"
        Me.AL_Z3BackRight.Type = KremerControlsWin32.KremerLight.GraphicType.Rectangle
        '
        'DoorZone4Front
        '
        Me.DoorZone4Front.BindControl = Me.AL_Z4Front
        Me.DoorZone4Front.BindProperty = "Data"
        Me.DoorZone4Front.Data = Nothing
        Me.DoorZone4Front.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.DoorZone4Front.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.DoorZone4Front.VariableName = "MAIN.Errors.exImdFrontDoorRight"
        '
        'AL_Z4Front
        '
        Me.AL_Z4Front.ColorOff = System.Drawing.Color.Silver
        Me.AL_Z4Front.ColorOn = System.Drawing.Color.Red
        Me.AL_Z4Front.Data = False
        Me.AL_Z4Front.Line = True
        Me.AL_Z4Front.LineSize = 1
        Me.AL_Z4Front.Location = New System.Drawing.Point(8, 35)
        Me.AL_Z4Front.Name = "AL_Z4Front"
        Me.AL_Z4Front.Size = New System.Drawing.Size(15, 15)
        Me.AL_Z4Front.TabIndex = 7
        Me.AL_Z4Front.Text = "KremerLight8"
        Me.AL_Z4Front.Type = KremerControlsWin32.KremerLight.GraphicType.Rectangle
        '
        'DoorZone4BackLeft
        '
        Me.DoorZone4BackLeft.BindControl = Me.AL_Z4BackLeft
        Me.DoorZone4BackLeft.BindProperty = "Data"
        Me.DoorZone4BackLeft.Data = Nothing
        Me.DoorZone4BackLeft.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.DoorZone4BackLeft.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.DoorZone4BackLeft.VariableName = "MAIN.Errors.exImdBackDoorRight5"
        '
        'AL_Z4BackLeft
        '
        Me.AL_Z4BackLeft.ColorOff = System.Drawing.Color.Silver
        Me.AL_Z4BackLeft.ColorOn = System.Drawing.Color.Red
        Me.AL_Z4BackLeft.Data = False
        Me.AL_Z4BackLeft.Line = True
        Me.AL_Z4BackLeft.LineSize = 1
        Me.AL_Z4BackLeft.Location = New System.Drawing.Point(0, -3)
        Me.AL_Z4BackLeft.Name = "AL_Z4BackLeft"
        Me.AL_Z4BackLeft.Size = New System.Drawing.Size(15, 15)
        Me.AL_Z4BackLeft.TabIndex = 4
        Me.AL_Z4BackLeft.Text = "AL_Z4BackLeft"
        Me.AL_Z4BackLeft.Type = KremerControlsWin32.KremerLight.GraphicType.Rectangle
        '
        'DoorZone4BackRight
        '
        Me.DoorZone4BackRight.BindControl = Me.AL_Z4BackRight
        Me.DoorZone4BackRight.BindProperty = "Data"
        Me.DoorZone4BackRight.Data = Nothing
        Me.DoorZone4BackRight.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.DoorZone4BackRight.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.DoorZone4BackRight.VariableName = "MAIN.Errors.exImdBackDoorRight6"
        '
        'AL_Z4BackRight
        '
        Me.AL_Z4BackRight.ColorOff = System.Drawing.Color.Silver
        Me.AL_Z4BackRight.ColorOn = System.Drawing.Color.Red
        Me.AL_Z4BackRight.Data = False
        Me.AL_Z4BackRight.Line = True
        Me.AL_Z4BackRight.LineSize = 1
        Me.AL_Z4BackRight.Location = New System.Drawing.Point(16, -3)
        Me.AL_Z4BackRight.Name = "AL_Z4BackRight"
        Me.AL_Z4BackRight.Size = New System.Drawing.Size(15, 15)
        Me.AL_Z4BackRight.TabIndex = 4
        Me.AL_Z4BackRight.Text = "AL_Z4BackRight"
        Me.AL_Z4BackRight.Type = KremerControlsWin32.KremerLight.GraphicType.Rectangle
        '
        'DoorZone5Left
        '
        Me.DoorZone5Left.BindControl = Me.AL_Z5Left
        Me.DoorZone5Left.BindProperty = "Data"
        Me.DoorZone5Left.Data = Nothing
        Me.DoorZone5Left.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.DoorZone5Left.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.DoorZone5Left.VariableName = "MAIN.Errors.exGantryA_FrontDoorLeft"
        '
        'AL_Z5Left
        '
        Me.AL_Z5Left.ColorOff = System.Drawing.Color.Silver
        Me.AL_Z5Left.ColorOn = System.Drawing.Color.Red
        Me.AL_Z5Left.Data = False
        Me.AL_Z5Left.Line = True
        Me.AL_Z5Left.LineSize = 1
        Me.AL_Z5Left.Location = New System.Drawing.Point(-3, 7)
        Me.AL_Z5Left.Name = "AL_Z5Left"
        Me.AL_Z5Left.Size = New System.Drawing.Size(15, 15)
        Me.AL_Z5Left.TabIndex = 0
        Me.AL_Z5Left.Text = "KremerLight12"
        Me.AL_Z5Left.Type = KremerControlsWin32.KremerLight.GraphicType.Rectangle
        '
        'DoorZone5Right
        '
        Me.DoorZone5Right.BindControl = Me.AL_Z5Right
        Me.DoorZone5Right.BindProperty = "Data"
        Me.DoorZone5Right.Data = Nothing
        Me.DoorZone5Right.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.DoorZone5Right.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.DoorZone5Right.VariableName = "MAIN.Errors.exGantryA_FrontDoorRight"
        '
        'AL_Z5Right
        '
        Me.AL_Z5Right.ColorOff = System.Drawing.Color.Silver
        Me.AL_Z5Right.ColorOn = System.Drawing.Color.Red
        Me.AL_Z5Right.Data = False
        Me.AL_Z5Right.Line = True
        Me.AL_Z5Right.LineSize = 1
        Me.AL_Z5Right.Location = New System.Drawing.Point(-3, 21)
        Me.AL_Z5Right.Name = "AL_Z5Right"
        Me.AL_Z5Right.Size = New System.Drawing.Size(15, 15)
        Me.AL_Z5Right.TabIndex = 9
        Me.AL_Z5Right.Text = "KremerLight18"
        Me.AL_Z5Right.Type = KremerControlsWin32.KremerLight.GraphicType.Rectangle
        '
        'DoorZone6Back
        '
        Me.DoorZone6Back.BindControl = Me.AL_Z6Back
        Me.DoorZone6Back.BindProperty = "Data"
        Me.DoorZone6Back.Data = Nothing
        Me.DoorZone6Back.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.DoorZone6Back.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.DoorZone6Back.VariableName = "MAIN.Errors.exGantryA_BackDoor"
        '
        'AL_Z6Back
        '
        Me.AL_Z6Back.ColorOff = System.Drawing.Color.Silver
        Me.AL_Z6Back.ColorOn = System.Drawing.Color.Red
        Me.AL_Z6Back.Data = False
        Me.AL_Z6Back.Line = True
        Me.AL_Z6Back.LineSize = 1
        Me.AL_Z6Back.Location = New System.Drawing.Point(7, -3)
        Me.AL_Z6Back.Name = "AL_Z6Back"
        Me.AL_Z6Back.Size = New System.Drawing.Size(15, 15)
        Me.AL_Z6Back.TabIndex = 0
        Me.AL_Z6Back.Text = "KremerLight15"
        Me.AL_Z6Back.Type = KremerControlsWin32.KremerLight.GraphicType.Rectangle
        '
        'DoorZone7back
        '
        Me.DoorZone7back.BindControl = Me.AL_Z7Back
        Me.DoorZone7back.BindProperty = "Data"
        Me.DoorZone7back.Data = Nothing
        Me.DoorZone7back.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.DoorZone7back.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.DoorZone7back.VariableName = "MAIN.Errors.exGantryB_BackDoor"
        '
        'AL_Z7Back
        '
        Me.AL_Z7Back.ColorOff = System.Drawing.Color.Silver
        Me.AL_Z7Back.ColorOn = System.Drawing.Color.Red
        Me.AL_Z7Back.Data = False
        Me.AL_Z7Back.Line = True
        Me.AL_Z7Back.LineSize = 1
        Me.AL_Z7Back.Location = New System.Drawing.Point(8, -3)
        Me.AL_Z7Back.Name = "AL_Z7Back"
        Me.AL_Z7Back.Size = New System.Drawing.Size(15, 15)
        Me.AL_Z7Back.TabIndex = 0
        Me.AL_Z7Back.Text = "KremerLight17"
        Me.AL_Z7Back.Type = KremerControlsWin32.KremerLight.GraphicType.Rectangle
        '
        'mxManualAutomode
        '
        Me.mxManualAutomode.BindControl = Me.btnAutoManual
        Me.mxManualAutomode.BindProperty = "Data"
        Me.mxManualAutomode.Data = Nothing
        Me.mxManualAutomode.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.mxManualAutomode.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.mxManualAutomode.VariableName = "MAIN.mxAutoMode"
        '
        'btnAutoManual
        '
        Me.btnAutoManual.Audit = Nothing
        Me.btnAutoManual.AuditEnabled = False
        Me.btnAutoManual.AuditMessage = "KremerPushButton pressed!"
        Me.btnAutoManual.AuditSource = "KremerPushButton"
        Me.btnAutoManual.BackColor = System.Drawing.Color.Blue
        Me.btnAutoManual.BackColorOn = System.Drawing.SystemColors.Control
        Me.btnAutoManual.BackGroundImageOn = Nothing
        Me.btnAutoManual.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.btnAutoManual.Data = False
        Me.btnAutoManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAutoManual.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAutoManual.ForeColor = System.Drawing.Color.Yellow
        Me.btnAutoManual.ForeColorOn = System.Drawing.Color.Black
        Me.btnAutoManual.Location = New System.Drawing.Point(343, 385)
        Me.btnAutoManual.Name = "btnAutoManual"
        Me.btnAutoManual.Size = New System.Drawing.Size(114, 50)
        Me.btnAutoManual.State = False
        Me.btnAutoManual.StateIsData = True
        Me.btnAutoManual.StateText = New String() {Nothing, Nothing}
        Me.btnAutoManual.TabIndex = 335
        Me.btnAutoManual.Tag = "192"
        Me.btnAutoManual.Text = "Manual" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Control"
        Me.btnAutoManual.UserInfo = Nothing
        Me.btnAutoManual.UserLevel = 0
        Me.btnAutoManual.UseStateText = False
        Me.btnAutoManual.UseVisualStyleBackColor = False
        '
        'ActSingleSideA
        '
        Me.ActSingleSideA.BindControl = Me.Btn_SingleA
        Me.ActSingleSideA.BindProperty = "Data"
        Me.ActSingleSideA.Data = Nothing
        Me.ActSingleSideA.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ActSingleSideA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ActSingleSideA.VariableName = "MAIN.InMoldDrying.MachParameters.EnableEamcSideA"
        '
        'Btn_SingleA
        '
        Me.Btn_SingleA.Audit = Nothing
        Me.Btn_SingleA.AuditEnabled = False
        Me.Btn_SingleA.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_SingleA.AuditSource = "KremerPushButton"
        Me.Btn_SingleA.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_SingleA.BackColorOn = System.Drawing.Color.Blue
        Me.Btn_SingleA.BackGroundImageOn = Nothing
        Me.Btn_SingleA.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.Btn_SingleA.Data = False
        Me.Btn_SingleA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SingleA.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_SingleA.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_SingleA.Location = New System.Drawing.Point(571, 385)
        Me.Btn_SingleA.Name = "Btn_SingleA"
        Me.Btn_SingleA.Size = New System.Drawing.Size(114, 50)
        Me.Btn_SingleA.State = False
        Me.Btn_SingleA.StateIsData = False
        Me.Btn_SingleA.StateText = New String() {Nothing, Nothing}
        Me.Btn_SingleA.TabIndex = 344
        Me.Btn_SingleA.Tag = "111"
        Me.Btn_SingleA.Text = "Enable " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A-Side"
        Me.Btn_SingleA.UserInfo = Nothing
        Me.Btn_SingleA.UserLevel = 0
        Me.Btn_SingleA.UseStateText = False
        Me.Btn_SingleA.UseVisualStyleBackColor = False
        '
        'StateSingleA
        '
        Me.StateSingleA.BindControl = Me.Btn_SingleA
        Me.StateSingleA.BindProperty = "State"
        Me.StateSingleA.Data = Nothing
        Me.StateSingleA.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.StateSingleA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StateSingleA.VariableName = "MAIN.InMoldDrying.MachParameters.EnableEamcSideA"
        '
        'ActSingleSideB
        '
        Me.ActSingleSideB.BindControl = Me.Btn_SingleB
        Me.ActSingleSideB.BindProperty = "Data"
        Me.ActSingleSideB.Data = Nothing
        Me.ActSingleSideB.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ActSingleSideB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ActSingleSideB.VariableName = "MAIN.InMoldDrying.MachParameters.EnableEamcSideB"
        '
        'Btn_SingleB
        '
        Me.Btn_SingleB.Audit = Nothing
        Me.Btn_SingleB.AuditEnabled = False
        Me.Btn_SingleB.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_SingleB.AuditSource = "KremerPushButton"
        Me.Btn_SingleB.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_SingleB.BackColorOn = System.Drawing.Color.Blue
        Me.Btn_SingleB.BackGroundImageOn = Nothing
        Me.Btn_SingleB.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.Btn_SingleB.Data = False
        Me.Btn_SingleB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SingleB.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_SingleB.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_SingleB.Location = New System.Drawing.Point(685, 385)
        Me.Btn_SingleB.Name = "Btn_SingleB"
        Me.Btn_SingleB.Size = New System.Drawing.Size(114, 50)
        Me.Btn_SingleB.State = False
        Me.Btn_SingleB.StateIsData = False
        Me.Btn_SingleB.StateText = New String() {Nothing, Nothing}
        Me.Btn_SingleB.TabIndex = 345
        Me.Btn_SingleB.Tag = "112"
        Me.Btn_SingleB.Text = "Enable " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "B-Side"
        Me.Btn_SingleB.UserInfo = Nothing
        Me.Btn_SingleB.UserLevel = 0
        Me.Btn_SingleB.UseStateText = False
        Me.Btn_SingleB.UseVisualStyleBackColor = False
        '
        'StateSingleB
        '
        Me.StateSingleB.BindControl = Me.Btn_SingleB
        Me.StateSingleB.BindProperty = "State"
        Me.StateSingleB.Data = Nothing
        Me.StateSingleB.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.StateSingleB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StateSingleB.VariableName = "MAIN.InMoldDrying.MachParameters.EnableEamcSideB"
        '
        'EnableTakeout
        '
        Me.EnableTakeout.BindControl = Me.BTN_EnableTakeout
        Me.EnableTakeout.BindProperty = "Data"
        Me.EnableTakeout.Data = Nothing
        Me.EnableTakeout.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.EnableTakeout.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.EnableTakeout.VariableName = "MAIN.InMoldDrying.MachParameters.EnableTakeOutAB"
        '
        'BTN_EnableTakeout
        '
        Me.BTN_EnableTakeout.Audit = Nothing
        Me.BTN_EnableTakeout.AuditEnabled = False
        Me.BTN_EnableTakeout.AuditMessage = "KremerPushButton pressed!"
        Me.BTN_EnableTakeout.AuditSource = "KremerPushButton"
        Me.BTN_EnableTakeout.BackColor = System.Drawing.SystemColors.Control
        Me.BTN_EnableTakeout.BackColorOn = System.Drawing.Color.White
        Me.BTN_EnableTakeout.BackGroundImageOn = Nothing
        Me.BTN_EnableTakeout.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.BTN_EnableTakeout.Data = False
        Me.BTN_EnableTakeout.Enabled = False
        Me.BTN_EnableTakeout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_EnableTakeout.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_EnableTakeout.ForeColorOn = System.Drawing.Color.Black
        Me.BTN_EnableTakeout.Location = New System.Drawing.Point(457, 385)
        Me.BTN_EnableTakeout.Name = "BTN_EnableTakeout"
        Me.BTN_EnableTakeout.Size = New System.Drawing.Size(114, 50)
        Me.BTN_EnableTakeout.State = False
        Me.BTN_EnableTakeout.StateIsData = True
        Me.BTN_EnableTakeout.StateText = New String() {Nothing, Nothing}
        Me.BTN_EnableTakeout.TabIndex = 346
        Me.BTN_EnableTakeout.Tag = ""
        Me.BTN_EnableTakeout.UserInfo = Nothing
        Me.BTN_EnableTakeout.UserLevel = 0
        Me.BTN_EnableTakeout.UseStateText = False
        Me.BTN_EnableTakeout.UseVisualStyleBackColor = False
        '
        'mxStart
        '
        Me.mxStart.BindControl = Me.BtnStart
        Me.mxStart.BindProperty = "Data"
        Me.mxStart.Data = Nothing
        Me.mxStart.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.mxStart.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.mxStart.VariableName = "MAIN.mxHMI_Start"
        '
        'mxPause
        '
        Me.mxPause.BindControl = Me.BtnPause
        Me.mxPause.BindProperty = "Data"
        Me.mxPause.Data = Nothing
        Me.mxPause.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.mxPause.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.mxPause.VariableName = "MAIN.mxHMI_Pause"
        '
        'mxStop
        '
        Me.mxStop.BindControl = Me.BtnStop
        Me.mxStop.BindProperty = "Data"
        Me.mxStop.Data = Nothing
        Me.mxStop.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.mxStop.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.mxStop.VariableName = "MAIN.mxHMI_Stop"
        '
        'StartState
        '
        Me.StartState.BindControl = Me.BtnStart
        Me.StartState.BindProperty = "State"
        Me.StartState.Data = Nothing
        Me.StartState.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.StartState.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StartState.VariableName = "MAIN.mxHMI_StartState"
        '
        'StopState
        '
        Me.StopState.BindControl = Me.BtnStop
        Me.StopState.BindProperty = "State"
        Me.StopState.Data = Nothing
        Me.StopState.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.StopState.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StopState.VariableName = "MAIN.mxHMI_StopState"
        '
        'PauseState
        '
        Me.PauseState.BindControl = Me.BtnPause
        Me.PauseState.BindProperty = "State"
        Me.PauseState.Data = Nothing
        Me.PauseState.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PauseState.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PauseState.VariableName = "MAIN.InMoldDrying.mxPause"
        '
        'actKickofss
        '
        Me.actKickofss.BindControl = Me.IO_ActKickOffs
        Me.actKickofss.BindProperty = "Data"
        Me.actKickofss.Data = Nothing
        Me.actKickofss.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.actKickofss.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.actKickofss.VariableName = "MAIN.ActNrOfKickoffs"
        '
        'IO_ActKickOffs
        '
        Me.IO_ActKickOffs.Audit = Nothing
        Me.IO_ActKickOffs.AuditEnabled = False
        Me.IO_ActKickOffs.AuditMessage = "KremerIoField changed:"
        Me.IO_ActKickOffs.AuditSource = "KremerIoField"
        Me.IO_ActKickOffs.AutoSize = True
        Me.IO_ActKickOffs.Data = 0R
        Me.IO_ActKickOffs.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_ActKickOffs.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_ActKickOffs.InitialValue = True
        Me.IO_ActKickOffs.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_ActKickOffs.Location = New System.Drawing.Point(96, 3)
        Me.IO_ActKickOffs.LowerBound = 0R
        Me.IO_ActKickOffs.Name = "IO_ActKickOffs"
        Me.IO_ActKickOffs.OutputFormat = "0.00"
        Me.IO_ActKickOffs.Size = New System.Drawing.Size(40, 18)
        Me.IO_ActKickOffs.TabIndex = 354
        Me.IO_ActKickOffs.Text = "0.00"
        Me.IO_ActKickOffs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_ActKickOffs.UpperBound = 1000.0R
        Me.IO_ActKickOffs.UserInfo = Nothing
        Me.IO_ActKickOffs.UserLevel = 0
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(-2, 335)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 23)
        Me.Label10.TabIndex = 302
        Me.Label10.Tag = "455"
        Me.Label10.Text = "In Mold Drying"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnDryingMoldB
        '
        Me.BtnDryingMoldB.BackColor = System.Drawing.Color.Transparent
        Me.BtnDryingMoldB.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnDryingMoldB.FlatAppearance.BorderSize = 0
        Me.BtnDryingMoldB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnDryingMoldB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnDryingMoldB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDryingMoldB.Location = New System.Drawing.Point(320, 125)
        Me.BtnDryingMoldB.Name = "BtnDryingMoldB"
        Me.BtnDryingMoldB.Size = New System.Drawing.Size(78, 76)
        Me.BtnDryingMoldB.TabIndex = 319
        Me.BtnDryingMoldB.UseVisualStyleBackColor = False
        '
        'BtnPulp
        '
        Me.BtnPulp.BackColor = System.Drawing.Color.Transparent
        Me.BtnPulp.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnPulp.FlatAppearance.BorderSize = 0
        Me.BtnPulp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnPulp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnPulp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPulp.Location = New System.Drawing.Point(229, 224)
        Me.BtnPulp.Name = "BtnPulp"
        Me.BtnPulp.Size = New System.Drawing.Size(91, 88)
        Me.BtnPulp.TabIndex = 339
        Me.BtnPulp.UseVisualStyleBackColor = False
        '
        'BtnTransferMold
        '
        Me.BtnTransferMold.BackColor = System.Drawing.Color.Transparent
        Me.BtnTransferMold.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnTransferMold.FlatAppearance.BorderSize = 0
        Me.BtnTransferMold.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnTransferMold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnTransferMold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTransferMold.Location = New System.Drawing.Point(235, 125)
        Me.BtnTransferMold.Name = "BtnTransferMold"
        Me.BtnTransferMold.Size = New System.Drawing.Size(79, 93)
        Me.BtnTransferMold.TabIndex = 340
        Me.BtnTransferMold.UseVisualStyleBackColor = False
        '
        'BtnOutfeed
        '
        Me.BtnOutfeed.BackColor = System.Drawing.Color.Transparent
        Me.BtnOutfeed.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnOutfeed.FlatAppearance.BorderSize = 0
        Me.BtnOutfeed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnOutfeed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnOutfeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOutfeed.Location = New System.Drawing.Point(505, 204)
        Me.BtnOutfeed.Name = "BtnOutfeed"
        Me.BtnOutfeed.Size = New System.Drawing.Size(276, 99)
        Me.BtnOutfeed.TabIndex = 341
        Me.BtnOutfeed.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 358)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 23)
        Me.Label1.TabIndex = 342
        Me.Label1.Tag = "462"
        Me.Label1.Text = "Product handling"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnGantryB
        '
        Me.BtnGantryB.BackColor = System.Drawing.Color.Transparent
        Me.BtnGantryB.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnGantryB.FlatAppearance.BorderSize = 0
        Me.BtnGantryB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnGantryB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnGantryB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGantryB.Location = New System.Drawing.Point(418, 26)
        Me.BtnGantryB.Name = "BtnGantryB"
        Me.BtnGantryB.Size = New System.Drawing.Size(81, 135)
        Me.BtnGantryB.TabIndex = 347
        Me.BtnGantryB.UseVisualStyleBackColor = False
        '
        'BtnGantryA
        '
        Me.BtnGantryA.BackColor = System.Drawing.Color.Transparent
        Me.BtnGantryA.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnGantryA.FlatAppearance.BorderSize = 0
        Me.BtnGantryA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnGantryA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnGantryA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGantryA.Location = New System.Drawing.Point(59, 26)
        Me.BtnGantryA.Name = "BtnGantryA"
        Me.BtnGantryA.Size = New System.Drawing.Size(81, 135)
        Me.BtnGantryA.TabIndex = 348
        Me.BtnGantryA.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.AL_Z4BackLeft)
        Me.Panel4.Controls.Add(Me.AL_Z4Front)
        Me.Panel4.Controls.Add(Me.AL_Z4BackRight)
        Me.Panel4.Location = New System.Drawing.Point(105, 57)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(35, 50)
        Me.Panel4.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.AL_Z5Right)
        Me.Panel1.Controls.Add(Me.KremerLight10)
        Me.Panel1.Controls.Add(Me.AL_Z5Left)
        Me.Panel1.Location = New System.Drawing.Point(3, 57)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(35, 50)
        Me.Panel1.TabIndex = 9
        '
        'KremerLight10
        '
        Me.KremerLight10.ColorOff = System.Drawing.Color.DarkRed
        Me.KremerLight10.ColorOn = System.Drawing.Color.Red
        Me.KremerLight10.Data = False
        Me.KremerLight10.Line = True
        Me.KremerLight10.LineSize = 1
        Me.KremerLight10.Location = New System.Drawing.Point(96, 2)
        Me.KremerLight10.Name = "KremerLight10"
        Me.KremerLight10.Size = New System.Drawing.Size(20, 20)
        Me.KremerLight10.TabIndex = 8
        Me.KremerLight10.Text = "KremerLight10"
        Me.KremerLight10.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.AL_Z1left)
        Me.Panel2.Controls.Add(Me.KremerLight11)
        Me.Panel2.Controls.Add(Me.AL_Z1Right)
        Me.Panel2.Location = New System.Drawing.Point(139, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(35, 50)
        Me.Panel2.TabIndex = 10
        '
        'KremerLight11
        '
        Me.KremerLight11.ColorOff = System.Drawing.Color.DarkRed
        Me.KremerLight11.ColorOn = System.Drawing.Color.Red
        Me.KremerLight11.Data = False
        Me.KremerLight11.Line = True
        Me.KremerLight11.LineSize = 1
        Me.KremerLight11.Location = New System.Drawing.Point(96, 2)
        Me.KremerLight11.Name = "KremerLight11"
        Me.KremerLight11.Size = New System.Drawing.Size(20, 20)
        Me.KremerLight11.TabIndex = 8
        Me.KremerLight11.Text = "KremerLight11"
        Me.KremerLight11.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.KremerLight14)
        Me.Panel5.Controls.Add(Me.AL_Z6Back)
        Me.Panel5.Location = New System.Drawing.Point(3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(35, 56)
        Me.Panel5.TabIndex = 10
        '
        'KremerLight14
        '
        Me.KremerLight14.ColorOff = System.Drawing.Color.DarkRed
        Me.KremerLight14.ColorOn = System.Drawing.Color.Red
        Me.KremerLight14.Data = False
        Me.KremerLight14.Line = True
        Me.KremerLight14.LineSize = 1
        Me.KremerLight14.Location = New System.Drawing.Point(96, 2)
        Me.KremerLight14.Name = "KremerLight14"
        Me.KremerLight14.Size = New System.Drawing.Size(20, 20)
        Me.KremerLight14.TabIndex = 8
        Me.KremerLight14.Text = "KremerLight14"
        Me.KremerLight14.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.KremerLight16)
        Me.Panel6.Controls.Add(Me.AL_Z7Back)
        Me.Panel6.Location = New System.Drawing.Point(139, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(35, 56)
        Me.Panel6.TabIndex = 11
        '
        'KremerLight16
        '
        Me.KremerLight16.ColorOff = System.Drawing.Color.DarkRed
        Me.KremerLight16.ColorOn = System.Drawing.Color.Red
        Me.KremerLight16.Data = False
        Me.KremerLight16.Line = True
        Me.KremerLight16.LineSize = 1
        Me.KremerLight16.Location = New System.Drawing.Point(96, 2)
        Me.KremerLight16.Name = "KremerLight16"
        Me.KremerLight16.Size = New System.Drawing.Size(20, 20)
        Me.KremerLight16.TabIndex = 8
        Me.KremerLight16.Text = "KremerLight16"
        Me.KremerLight16.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.AL_Z3BackLeft)
        Me.Panel3.Controls.Add(Me.AL_Z3Front)
        Me.Panel3.Controls.Add(Me.AL_Z3BackRight)
        Me.Panel3.Location = New System.Drawing.Point(71, 57)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(35, 50)
        Me.Panel3.TabIndex = 8
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.AL_Z2BackLeft)
        Me.Panel7.Controls.Add(Me.AL_Z2Front)
        Me.Panel7.Controls.Add(Me.AL_Z2BackRight)
        Me.Panel7.Location = New System.Drawing.Point(37, 57)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(35, 50)
        Me.Panel7.TabIndex = 8
        '
        'PnlDoors
        '
        Me.PnlDoors.Controls.Add(Me.Panel1)
        Me.PnlDoors.Controls.Add(Me.Panel4)
        Me.PnlDoors.Controls.Add(Me.Panel7)
        Me.PnlDoors.Controls.Add(Me.Panel2)
        Me.PnlDoors.Controls.Add(Me.Panel3)
        Me.PnlDoors.Controls.Add(Me.Panel5)
        Me.PnlDoors.Controls.Add(Me.Panel6)
        Me.PnlDoors.Location = New System.Drawing.Point(622, 3)
        Me.PnlDoors.Name = "PnlDoors"
        Me.PnlDoors.Size = New System.Drawing.Size(178, 110)
        Me.PnlDoors.TabIndex = 352
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 23)
        Me.Label2.TabIndex = 353
        Me.Label2.Tag = "515"
        Me.Label2.Text = "Kickoffs/m:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 435)
        Me.ShapeContainer1.TabIndex = 355
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 2
        Me.LineShape1.X2 = 135
        Me.LineShape1.Y1 = 24
        Me.LineShape1.Y2 = 24
        '
        'Overview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = Global.InMoldDrying.My.Resources.Resources.Overview
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Controls.Add(Me.IO_ActKickOffs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PnlDoors)
        Me.Controls.Add(Me.StatusPH)
        Me.Controls.Add(Me.StatusIMD)
        Me.Controls.Add(Me.BtnGantryA)
        Me.Controls.Add(Me.BtnGantryB)
        Me.Controls.Add(Me.BTN_EnableTakeout)
        Me.Controls.Add(Me.Btn_SingleB)
        Me.Controls.Add(Me.Btn_SingleA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnOutfeed)
        Me.Controls.Add(Me.BtnTransferMold)
        Me.Controls.Add(Me.BtnPulp)
        Me.Controls.Add(Me.btnAutoManual)
        Me.Controls.Add(Me.BtnDryingMoldB)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BtnTakeOutUnitB)
        Me.Controls.Add(Me.BtnTakeOutUnitA)
        Me.Controls.Add(Me.BtnDryingMoldA)
        Me.Controls.Add(Me.BtnPause)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DoubleBuffered = True
        Me.Name = "Overview"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "194"
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.PnlDoors.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnDryingMoldA As System.Windows.Forms.Button
    Friend WithEvents BtnTakeOutUnitA As System.Windows.Forms.Button
    Friend WithEvents BtnTakeOutUnitB As System.Windows.Forms.Button
    Friend WithEvents BtnStop As KremerControlsWin32.KremerButton
    Friend WithEvents BtnPause As KremerControlsWin32.KremerButton
    Friend WithEvents BtnStart As KremerControlsWin32.KremerButton
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BtnDryingMoldB As System.Windows.Forms.Button
    Friend WithEvents mxManualAutomode As KremerControlsWin32.KremerVariable
    Friend WithEvents btnAutoManual As KremerControlsWin32.KremerButton
    Friend WithEvents BtnPulp As System.Windows.Forms.Button
    Friend WithEvents BtnTransferMold As System.Windows.Forms.Button
    Friend WithEvents BtnOutfeed As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_SingleA As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_SingleB As KremerControlsWin32.KremerButton
    Friend WithEvents BTN_EnableTakeout As KremerControlsWin32.KremerButton
    Friend WithEvents ActSingleSideA As KremerControlsWin32.KremerVariable
    Friend WithEvents ActSingleSideB As KremerControlsWin32.KremerVariable
    Friend WithEvents EnableTakeout As KremerControlsWin32.KremerVariable
    Friend WithEvents mxStart As KremerControlsWin32.KremerVariable
    Friend WithEvents mxPause As KremerControlsWin32.KremerVariable
    Friend WithEvents mxStop As KremerControlsWin32.KremerVariable
    Friend WithEvents BtnGantryB As System.Windows.Forms.Button
    Friend WithEvents BtnGantryA As System.Windows.Forms.Button
    Friend WithEvents StateSingleA As KremerControlsWin32.KremerVariable
    Friend WithEvents StateSingleB As KremerControlsWin32.KremerVariable
    Friend WithEvents StartState As KremerControlsWin32.KremerVariable
    Friend WithEvents StopState As KremerControlsWin32.KremerVariable
    Friend WithEvents IMD_States As KremerControlsWin32.KremerVariable
    Friend WithEvents PH_States As KremerControlsWin32.KremerVariable
    Friend WithEvents StatusIMD As KremerControlsWin32.KremerTextField
    Friend WithEvents StatusPH As KremerControlsWin32.KremerTextField
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents AL_Z4BackLeft As KremerControlsWin32.KremerLight
    Friend WithEvents AL_Z4Front As KremerControlsWin32.KremerLight
    Friend WithEvents AL_Z4BackRight As KremerControlsWin32.KremerLight
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AL_Z5Right As KremerControlsWin32.KremerLight
    Friend WithEvents KremerLight10 As KremerControlsWin32.KremerLight
    Friend WithEvents AL_Z5Left As KremerControlsWin32.KremerLight
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents AL_Z1left As KremerControlsWin32.KremerLight
    Friend WithEvents KremerLight11 As KremerControlsWin32.KremerLight
    Friend WithEvents AL_Z1Right As KremerControlsWin32.KremerLight
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents KremerLight14 As KremerControlsWin32.KremerLight
    Friend WithEvents AL_Z6Back As KremerControlsWin32.KremerLight
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents KremerLight16 As KremerControlsWin32.KremerLight
    Friend WithEvents AL_Z7Back As KremerControlsWin32.KremerLight
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents AL_Z3BackLeft As KremerControlsWin32.KremerLight
    Friend WithEvents AL_Z3Front As KremerControlsWin32.KremerLight
    Friend WithEvents AL_Z3BackRight As KremerControlsWin32.KremerLight
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents AL_Z2BackLeft As KremerControlsWin32.KremerLight
    Friend WithEvents AL_Z2Front As KremerControlsWin32.KremerLight
    Friend WithEvents AL_Z2BackRight As KremerControlsWin32.KremerLight
    Friend WithEvents PnlDoors As System.Windows.Forms.Panel
    Friend WithEvents DoorZone1Left As KremerControlsWin32.KremerVariable
    Friend WithEvents DoorZone1Right As KremerControlsWin32.KremerVariable
    Friend WithEvents DoorZone2Front As KremerControlsWin32.KremerVariable
    Friend WithEvents DoorZone2BackLeft As KremerControlsWin32.KremerVariable
    Friend WithEvents DoorZone2BackRight As KremerControlsWin32.KremerVariable
    Friend WithEvents DoorZone3Front As KremerControlsWin32.KremerVariable
    Friend WithEvents DoorZone3BackLeft As KremerControlsWin32.KremerVariable
    Friend WithEvents DoorZone3BackRight As KremerControlsWin32.KremerVariable
    Friend WithEvents DoorZone4Front As KremerControlsWin32.KremerVariable
    Friend WithEvents DoorZone4BackLeft As KremerControlsWin32.KremerVariable
    Friend WithEvents DoorZone4BackRight As KremerControlsWin32.KremerVariable
    Friend WithEvents DoorZone5Left As KremerControlsWin32.KremerVariable
    Friend WithEvents DoorZone5Right As KremerControlsWin32.KremerVariable
    Friend WithEvents DoorZone6Back As KremerControlsWin32.KremerVariable
    Friend WithEvents DoorZone7back As KremerControlsWin32.KremerVariable
    Friend WithEvents PauseState As KremerControlsWin32.KremerVariable
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IO_ActKickOffs As KremerControlsWin32.KremerIoField
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents actKickofss As KremerControlsWin32.KremerVariable
End Class
