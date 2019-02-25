<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Init
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
        Me.StartInit = New KremerControlsWin32.KremerVariable(Me.components)
        Me.btnStartINIT = New KremerControlsWin32.KremerButton()
        Me.StopInit = New KremerControlsWin32.KremerVariable(Me.components)
        Me.btnStopINIT = New KremerControlsWin32.KremerButton()
        Me.TransferReady = New KremerControlsWin32.KremerVariable(Me.components)
        Me.InitTransferComplete = New KremerControlsWin32.KremerLight()
        Me.ProductFormingReady = New KremerControlsWin32.KremerVariable(Me.components)
        Me.InitProductFormingComplete = New KremerControlsWin32.KremerLight()
        Me.TopMoldAReady = New KremerControlsWin32.KremerVariable(Me.components)
        Me.InitTopMoldAComplete = New KremerControlsWin32.KremerLight()
        Me.BottomMoldReady = New KremerControlsWin32.KremerVariable(Me.components)
        Me.InitBottomMoldAComplete = New KremerControlsWin32.KremerLight()
        Me.TopMoldBReady = New KremerControlsWin32.KremerVariable(Me.components)
        Me.InitTopMoldBComplete = New KremerControlsWin32.KremerLight()
        Me.BottomMoldBReady = New KremerControlsWin32.KremerVariable(Me.components)
        Me.InitBottomMoldBComplete = New KremerControlsWin32.KremerLight()
        Me.ProductConveyorReady = New KremerControlsWin32.KremerVariable(Me.components)
        Me.InitPrConveyorComplete = New KremerControlsWin32.KremerLight()
        Me.GantryAReady = New KremerControlsWin32.KremerVariable(Me.components)
        Me.InitGantryAComplete = New KremerControlsWin32.KremerLight()
        Me.GantryBReady = New KremerControlsWin32.KremerVariable(Me.components)
        Me.InitGantryBComplete = New KremerControlsWin32.KremerLight()
        Me.InitalizationsComplete = New KremerControlsWin32.KremerVariable(Me.components)
        Me.InitComplete = New KremerControlsWin32.KremerLight()
        Me.ProductHandlingReady = New KremerControlsWin32.KremerVariable(Me.components)
        Me.InitProductHandling = New KremerControlsWin32.KremerLight()
        Me.BTN_NavtoSequenceInit = New KremerControlsWin32.KremerButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'krConnector
        '
        Me.krConnector.VarCollector = Nothing
        '
        'krVarCollector
        '
        Me.krVarCollector.Variables.Add(Me.StartInit)
        Me.krVarCollector.Variables.Add(Me.StopInit)
        Me.krVarCollector.Variables.Add(Me.TransferReady)
        Me.krVarCollector.Variables.Add(Me.ProductFormingReady)
        Me.krVarCollector.Variables.Add(Me.TopMoldAReady)
        Me.krVarCollector.Variables.Add(Me.BottomMoldReady)
        Me.krVarCollector.Variables.Add(Me.TopMoldBReady)
        Me.krVarCollector.Variables.Add(Me.BottomMoldBReady)
        Me.krVarCollector.Variables.Add(Me.ProductConveyorReady)
        Me.krVarCollector.Variables.Add(Me.GantryAReady)
        Me.krVarCollector.Variables.Add(Me.GantryBReady)
        Me.krVarCollector.Variables.Add(Me.InitalizationsComplete)
        Me.krVarCollector.Variables.Add(Me.ProductHandlingReady)
        '
        'StartInit
        '
        Me.StartInit.BindControl = Me.btnStartINIT
        Me.StartInit.BindProperty = "Data"
        Me.StartInit.Data = Nothing
        Me.StartInit.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.StartInit.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StartInit.VariableName = "MAIN.mxHMI_StartInit"
        '
        'btnStartINIT
        '
        Me.btnStartINIT.Audit = Nothing
        Me.btnStartINIT.AuditEnabled = False
        Me.btnStartINIT.AuditMessage = "KremerPushButton pressed!"
        Me.btnStartINIT.AuditSource = "KremerPushButton"
        Me.btnStartINIT.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStartINIT.BackGroundImageOn = Nothing
        Me.btnStartINIT.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.btnStartINIT.Data = False
        Me.btnStartINIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartINIT.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnStartINIT.ForeColorOn = System.Drawing.Color.Yellow
        Me.btnStartINIT.Location = New System.Drawing.Point(320, 9)
        Me.btnStartINIT.Name = "btnStartINIT"
        Me.btnStartINIT.Size = New System.Drawing.Size(114, 50)
        Me.btnStartINIT.State = False
        Me.btnStartINIT.StateIsData = False
        Me.btnStartINIT.StateText = New String() {Nothing, Nothing}
        Me.btnStartINIT.TabIndex = 365
        Me.btnStartINIT.Tag = "58"
        Me.btnStartINIT.Text = "Start INIT"
        Me.btnStartINIT.UserInfo = Nothing
        Me.btnStartINIT.UserLevel = 0
        Me.btnStartINIT.UseStateText = False
        Me.btnStartINIT.UseVisualStyleBackColor = False
        '
        'StopInit
        '
        Me.StopInit.BindControl = Me.btnStopINIT
        Me.StopInit.BindProperty = "Data"
        Me.StopInit.Data = Nothing
        Me.StopInit.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.StopInit.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StopInit.VariableName = "MAIN.mxHMI_StopInit"
        '
        'btnStopINIT
        '
        Me.btnStopINIT.Audit = Nothing
        Me.btnStopINIT.AuditEnabled = False
        Me.btnStopINIT.AuditMessage = "KremerPushButton pressed!"
        Me.btnStopINIT.AuditSource = "KremerPushButton"
        Me.btnStopINIT.BackColorOn = System.Drawing.Color.Red
        Me.btnStopINIT.BackGroundImageOn = Nothing
        Me.btnStopINIT.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.btnStopINIT.Data = False
        Me.btnStopINIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStopINIT.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnStopINIT.ForeColorOn = System.Drawing.SystemColors.ControlText
        Me.btnStopINIT.Location = New System.Drawing.Point(440, 9)
        Me.btnStopINIT.Name = "btnStopINIT"
        Me.btnStopINIT.Size = New System.Drawing.Size(114, 50)
        Me.btnStopINIT.State = False
        Me.btnStopINIT.StateIsData = False
        Me.btnStopINIT.StateText = New String() {Nothing, Nothing}
        Me.btnStopINIT.TabIndex = 365
        Me.btnStopINIT.Tag = "59"
        Me.btnStopINIT.Text = "Stop INIT"
        Me.btnStopINIT.UserInfo = Nothing
        Me.btnStopINIT.UserLevel = 0
        Me.btnStopINIT.UseStateText = False
        Me.btnStopINIT.UseVisualStyleBackColor = True
        '
        'TransferReady
        '
        Me.TransferReady.BindControl = Me.InitTransferComplete
        Me.TransferReady.BindProperty = "Data"
        Me.TransferReady.Data = Nothing
        Me.TransferReady.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TransferReady.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TransferReady.VariableName = "MAIN.InMoldDrying.TransferMold.mxInitialized"
        '
        'InitTransferComplete
        '
        Me.InitTransferComplete.ColorOff = System.Drawing.Color.Gray
        Me.InitTransferComplete.ColorOn = System.Drawing.Color.Lime
        Me.InitTransferComplete.Data = False
        Me.InitTransferComplete.Line = True
        Me.InitTransferComplete.LineSize = 1
        Me.InitTransferComplete.Location = New System.Drawing.Point(15, 47)
        Me.InitTransferComplete.Name = "InitTransferComplete"
        Me.InitTransferComplete.Size = New System.Drawing.Size(25, 25)
        Me.InitTransferComplete.TabIndex = 371
        Me.InitTransferComplete.Text = "KremerLight1"
        Me.InitTransferComplete.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'ProductFormingReady
        '
        Me.ProductFormingReady.BindControl = Me.InitProductFormingComplete
        Me.ProductFormingReady.BindProperty = "Data"
        Me.ProductFormingReady.Data = Nothing
        Me.ProductFormingReady.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ProductFormingReady.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ProductFormingReady.VariableName = "MAIN.InMoldDrying.ProductForming.mxInitialized"
        '
        'InitProductFormingComplete
        '
        Me.InitProductFormingComplete.ColorOff = System.Drawing.Color.Gray
        Me.InitProductFormingComplete.ColorOn = System.Drawing.Color.Lime
        Me.InitProductFormingComplete.Data = False
        Me.InitProductFormingComplete.Line = True
        Me.InitProductFormingComplete.LineSize = 1
        Me.InitProductFormingComplete.Location = New System.Drawing.Point(15, 78)
        Me.InitProductFormingComplete.Name = "InitProductFormingComplete"
        Me.InitProductFormingComplete.Size = New System.Drawing.Size(25, 25)
        Me.InitProductFormingComplete.TabIndex = 373
        Me.InitProductFormingComplete.Text = "KremerLight2"
        Me.InitProductFormingComplete.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TopMoldAReady
        '
        Me.TopMoldAReady.BindControl = Me.InitTopMoldAComplete
        Me.TopMoldAReady.BindProperty = "Data"
        Me.TopMoldAReady.Data = Nothing
        Me.TopMoldAReady.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TopMoldAReady.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TopMoldAReady.VariableName = "MAIN.InMoldDrying.TopMoldA.mxInitialized"
        '
        'InitTopMoldAComplete
        '
        Me.InitTopMoldAComplete.ColorOff = System.Drawing.Color.Gray
        Me.InitTopMoldAComplete.ColorOn = System.Drawing.Color.Lime
        Me.InitTopMoldAComplete.Data = False
        Me.InitTopMoldAComplete.Line = True
        Me.InitTopMoldAComplete.LineSize = 1
        Me.InitTopMoldAComplete.Location = New System.Drawing.Point(15, 109)
        Me.InitTopMoldAComplete.Name = "InitTopMoldAComplete"
        Me.InitTopMoldAComplete.Size = New System.Drawing.Size(25, 25)
        Me.InitTopMoldAComplete.TabIndex = 377
        Me.InitTopMoldAComplete.Text = "KremerLight4"
        Me.InitTopMoldAComplete.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BottomMoldReady
        '
        Me.BottomMoldReady.BindControl = Me.InitBottomMoldAComplete
        Me.BottomMoldReady.BindProperty = "Data"
        Me.BottomMoldReady.Data = Nothing
        Me.BottomMoldReady.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BottomMoldReady.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BottomMoldReady.VariableName = "MAIN.InMoldDrying.BottomMoldA.mxInitialized"
        '
        'InitBottomMoldAComplete
        '
        Me.InitBottomMoldAComplete.ColorOff = System.Drawing.Color.Gray
        Me.InitBottomMoldAComplete.ColorOn = System.Drawing.Color.Lime
        Me.InitBottomMoldAComplete.Data = False
        Me.InitBottomMoldAComplete.Line = True
        Me.InitBottomMoldAComplete.LineSize = 1
        Me.InitBottomMoldAComplete.Location = New System.Drawing.Point(15, 140)
        Me.InitBottomMoldAComplete.Name = "InitBottomMoldAComplete"
        Me.InitBottomMoldAComplete.Size = New System.Drawing.Size(25, 25)
        Me.InitBottomMoldAComplete.TabIndex = 375
        Me.InitBottomMoldAComplete.Text = "KremerLight3"
        Me.InitBottomMoldAComplete.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TopMoldBReady
        '
        Me.TopMoldBReady.BindControl = Me.InitTopMoldBComplete
        Me.TopMoldBReady.BindProperty = "Data"
        Me.TopMoldBReady.Data = Nothing
        Me.TopMoldBReady.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TopMoldBReady.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TopMoldBReady.VariableName = "MAIN.InMoldDrying.TopMoldB.mxInitialized"
        '
        'InitTopMoldBComplete
        '
        Me.InitTopMoldBComplete.ColorOff = System.Drawing.Color.Gray
        Me.InitTopMoldBComplete.ColorOn = System.Drawing.Color.Lime
        Me.InitTopMoldBComplete.Data = False
        Me.InitTopMoldBComplete.Line = True
        Me.InitTopMoldBComplete.LineSize = 1
        Me.InitTopMoldBComplete.Location = New System.Drawing.Point(236, 109)
        Me.InitTopMoldBComplete.Name = "InitTopMoldBComplete"
        Me.InitTopMoldBComplete.Size = New System.Drawing.Size(25, 25)
        Me.InitTopMoldBComplete.TabIndex = 381
        Me.InitTopMoldBComplete.Text = "KremerLight5"
        Me.InitTopMoldBComplete.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BottomMoldBReady
        '
        Me.BottomMoldBReady.BindControl = Me.InitBottomMoldBComplete
        Me.BottomMoldBReady.BindProperty = "Data"
        Me.BottomMoldBReady.Data = Nothing
        Me.BottomMoldBReady.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BottomMoldBReady.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BottomMoldBReady.VariableName = "MAIN.InMoldDrying.BottomMoldB.mxInitialized"
        '
        'InitBottomMoldBComplete
        '
        Me.InitBottomMoldBComplete.ColorOff = System.Drawing.Color.Gray
        Me.InitBottomMoldBComplete.ColorOn = System.Drawing.Color.Lime
        Me.InitBottomMoldBComplete.Data = False
        Me.InitBottomMoldBComplete.Line = True
        Me.InitBottomMoldBComplete.LineSize = 1
        Me.InitBottomMoldBComplete.Location = New System.Drawing.Point(236, 137)
        Me.InitBottomMoldBComplete.Name = "InitBottomMoldBComplete"
        Me.InitBottomMoldBComplete.Size = New System.Drawing.Size(25, 25)
        Me.InitBottomMoldBComplete.TabIndex = 379
        Me.InitBottomMoldBComplete.Text = "KremerLight6"
        Me.InitBottomMoldBComplete.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'ProductConveyorReady
        '
        Me.ProductConveyorReady.BindControl = Me.InitPrConveyorComplete
        Me.ProductConveyorReady.BindProperty = "Data"
        Me.ProductConveyorReady.Data = Nothing
        Me.ProductConveyorReady.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ProductConveyorReady.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ProductConveyorReady.VariableName = "MAIN.ProductHandling.OutfeedConveyor.mxInitialized"
        '
        'InitPrConveyorComplete
        '
        Me.InitPrConveyorComplete.ColorOff = System.Drawing.Color.Gray
        Me.InitPrConveyorComplete.ColorOn = System.Drawing.Color.Lime
        Me.InitPrConveyorComplete.Data = False
        Me.InitPrConveyorComplete.Line = True
        Me.InitPrConveyorComplete.LineSize = 1
        Me.InitPrConveyorComplete.Location = New System.Drawing.Point(15, 226)
        Me.InitPrConveyorComplete.Name = "InitPrConveyorComplete"
        Me.InitPrConveyorComplete.Size = New System.Drawing.Size(25, 25)
        Me.InitPrConveyorComplete.TabIndex = 389
        Me.InitPrConveyorComplete.Text = "KremerLight1S"
        Me.InitPrConveyorComplete.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'GantryAReady
        '
        Me.GantryAReady.BindControl = Me.InitGantryAComplete
        Me.GantryAReady.BindProperty = "Data"
        Me.GantryAReady.Data = Nothing
        Me.GantryAReady.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GantryAReady.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GantryAReady.VariableName = "MAIN.ProductHandling.GantryA.mxInitialized"
        '
        'InitGantryAComplete
        '
        Me.InitGantryAComplete.ColorOff = System.Drawing.Color.Gray
        Me.InitGantryAComplete.ColorOn = System.Drawing.Color.Lime
        Me.InitGantryAComplete.Data = False
        Me.InitGantryAComplete.Line = True
        Me.InitGantryAComplete.LineSize = 1
        Me.InitGantryAComplete.Location = New System.Drawing.Point(15, 257)
        Me.InitGantryAComplete.Name = "InitGantryAComplete"
        Me.InitGantryAComplete.Size = New System.Drawing.Size(25, 25)
        Me.InitGantryAComplete.TabIndex = 391
        Me.InitGantryAComplete.Text = "KremerLight2"
        Me.InitGantryAComplete.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'GantryBReady
        '
        Me.GantryBReady.BindControl = Me.InitGantryBComplete
        Me.GantryBReady.BindProperty = "Data"
        Me.GantryBReady.Data = Nothing
        Me.GantryBReady.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GantryBReady.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GantryBReady.VariableName = "MAIN.ProductHandling.GantryB.mxInitialized"
        '
        'InitGantryBComplete
        '
        Me.InitGantryBComplete.ColorOff = System.Drawing.Color.Gray
        Me.InitGantryBComplete.ColorOn = System.Drawing.Color.Lime
        Me.InitGantryBComplete.Data = False
        Me.InitGantryBComplete.Line = True
        Me.InitGantryBComplete.LineSize = 1
        Me.InitGantryBComplete.Location = New System.Drawing.Point(236, 257)
        Me.InitGantryBComplete.Name = "InitGantryBComplete"
        Me.InitGantryBComplete.Size = New System.Drawing.Size(25, 25)
        Me.InitGantryBComplete.TabIndex = 395
        Me.InitGantryBComplete.Text = "KremerLight4"
        Me.InitGantryBComplete.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'InitalizationsComplete
        '
        Me.InitalizationsComplete.BindControl = Me.InitComplete
        Me.InitalizationsComplete.BindProperty = "Data"
        Me.InitalizationsComplete.Data = Nothing
        Me.InitalizationsComplete.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.InitalizationsComplete.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.InitalizationsComplete.VariableName = "MAIN.InMoldDrying.mxInitialized"
        '
        'InitComplete
        '
        Me.InitComplete.ColorOff = System.Drawing.Color.Gray
        Me.InitComplete.ColorOn = System.Drawing.Color.Lime
        Me.InitComplete.Data = False
        Me.InitComplete.Line = True
        Me.InitComplete.LineSize = 1
        Me.InitComplete.Location = New System.Drawing.Point(15, 3)
        Me.InitComplete.Name = "InitComplete"
        Me.InitComplete.Size = New System.Drawing.Size(25, 25)
        Me.InitComplete.TabIndex = 383
        Me.InitComplete.Text = "KremerLight1"
        Me.InitComplete.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'ProductHandlingReady
        '
        Me.ProductHandlingReady.BindControl = Me.InitProductHandling
        Me.ProductHandlingReady.BindProperty = "Data"
        Me.ProductHandlingReady.Data = Nothing
        Me.ProductHandlingReady.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ProductHandlingReady.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ProductHandlingReady.VariableName = "MAIN.ProductHandling.mxInitialized"
        '
        'InitProductHandling
        '
        Me.InitProductHandling.ColorOff = System.Drawing.Color.Gray
        Me.InitProductHandling.ColorOn = System.Drawing.Color.Lime
        Me.InitProductHandling.Data = False
        Me.InitProductHandling.Line = True
        Me.InitProductHandling.LineSize = 1
        Me.InitProductHandling.Location = New System.Drawing.Point(15, 182)
        Me.InitProductHandling.Name = "InitProductHandling"
        Me.InitProductHandling.Size = New System.Drawing.Size(25, 25)
        Me.InitProductHandling.TabIndex = 388
        Me.InitProductHandling.Text = "KremerLight1"
        Me.InitProductHandling.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BTN_NavtoSequenceInit
        '
        Me.BTN_NavtoSequenceInit.Audit = Nothing
        Me.BTN_NavtoSequenceInit.AuditEnabled = False
        Me.BTN_NavtoSequenceInit.AuditMessage = "KremerPushButton pressed!"
        Me.BTN_NavtoSequenceInit.AuditSource = "KremerPushButton"
        Me.BTN_NavtoSequenceInit.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTN_NavtoSequenceInit.BackGroundImageOn = Nothing
        Me.BTN_NavtoSequenceInit.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BTN_NavtoSequenceInit.Data = False
        Me.BTN_NavtoSequenceInit.Enabled = False
        Me.BTN_NavtoSequenceInit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BTN_NavtoSequenceInit.ForeColorOn = System.Drawing.Color.Yellow
        Me.BTN_NavtoSequenceInit.Location = New System.Drawing.Point(683, 388)
        Me.BTN_NavtoSequenceInit.Name = "BTN_NavtoSequenceInit"
        Me.BTN_NavtoSequenceInit.Size = New System.Drawing.Size(114, 50)
        Me.BTN_NavtoSequenceInit.State = False
        Me.BTN_NavtoSequenceInit.StateIsData = False
        Me.BTN_NavtoSequenceInit.StateText = New String() {Nothing, Nothing}
        Me.BTN_NavtoSequenceInit.TabIndex = 370
        Me.BTN_NavtoSequenceInit.Tag = ""
        Me.BTN_NavtoSequenceInit.Text = "Details"
        Me.BTN_NavtoSequenceInit.UserInfo = Nothing
        Me.BTN_NavtoSequenceInit.UserLevel = 0
        Me.BTN_NavtoSequenceInit.UseStateText = False
        Me.BTN_NavtoSequenceInit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 16)
        Me.Label1.TabIndex = 372
        Me.Label1.Tag = "456"
        Me.Label1.Text = "Transfer mold initialized"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 16)
        Me.Label2.TabIndex = 374
        Me.Label2.Tag = "457"
        Me.Label2.Text = "Product forming initalized"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 16)
        Me.Label3.TabIndex = 376
        Me.Label3.Tag = "459"
        Me.Label3.Text = "Bottom mold A initalized"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 16)
        Me.Label4.TabIndex = 378
        Me.Label4.Tag = "458"
        Me.Label4.Text = "Topmold A initalized"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(267, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 16)
        Me.Label5.TabIndex = 382
        Me.Label5.Tag = "460"
        Me.Label5.Text = "Topmold B initalized"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(267, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 16)
        Me.Label6.TabIndex = 380
        Me.Label6.Tag = "461"
        Me.Label6.Text = "Bottom mold B initalized"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 441)
        Me.ShapeContainer1.TabIndex = 385
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 305
        Me.LineShape2.X2 = 15
        Me.LineShape2.Y1 = 32
        Me.LineShape2.Y2 = 32
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 304
        Me.LineShape1.X2 = 14
        Me.LineShape1.Y1 = 210
        Me.LineShape1.Y2 = 210
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(51, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 20)
        Me.Label8.TabIndex = 386
        Me.Label8.Tag = "462"
        Me.Label8.Text = "Product handling"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(44, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 20)
        Me.Label9.TabIndex = 387
        Me.Label9.Tag = "455"
        Me.Label9.Text = "In mold drying"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(267, 266)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 16)
        Me.Label7.TabIndex = 396
        Me.Label7.Tag = "465"
        Me.Label7.Text = "Gantry B"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(46, 266)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 16)
        Me.Label11.TabIndex = 392
        Me.Label11.Tag = "464"
        Me.Label11.Text = "Gantry A"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(46, 235)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 16)
        Me.Label12.TabIndex = 390
        Me.Label12.Tag = "463"
        Me.Label12.Text = "Product Conveyor"
        '
        'Init
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.InitGantryBComplete)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.InitGantryAComplete)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.InitPrConveyorComplete)
        Me.Controls.Add(Me.InitProductHandling)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.InitComplete)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.InitTopMoldBComplete)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.InitBottomMoldBComplete)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.InitTopMoldAComplete)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.InitBottomMoldAComplete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.InitProductFormingComplete)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InitTransferComplete)
        Me.Controls.Add(Me.BTN_NavtoSequenceInit)
        Me.Controls.Add(Me.btnStopINIT)
        Me.Controls.Add(Me.btnStartINIT)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Init"
        Me.Size = New System.Drawing.Size(800, 441)
        Me.Tag = "3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents krConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents krVarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents StartInit As KremerControlsWin32.KremerVariable
    Friend WithEvents btnStartINIT As KremerControlsWin32.KremerButton
    Friend WithEvents btnStopINIT As KremerControlsWin32.KremerButton
    Friend WithEvents BTN_NavtoSequenceInit As KremerControlsWin32.KremerButton
    Friend WithEvents StopInit As KremerControlsWin32.KremerVariable
    Friend WithEvents InitTransferComplete As KremerControlsWin32.KremerLight
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents InitProductFormingComplete As KremerControlsWin32.KremerLight
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents InitBottomMoldAComplete As KremerControlsWin32.KremerLight
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents InitTopMoldAComplete As KremerControlsWin32.KremerLight
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents InitTopMoldBComplete As KremerControlsWin32.KremerLight
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents InitBottomMoldBComplete As KremerControlsWin32.KremerLight
    Friend WithEvents TransferReady As KremerControlsWin32.KremerVariable
    Friend WithEvents ProductFormingReady As KremerControlsWin32.KremerVariable
    Friend WithEvents TopMoldAReady As KremerControlsWin32.KremerVariable
    Friend WithEvents BottomMoldReady As KremerControlsWin32.KremerVariable
    Friend WithEvents TopMoldBReady As KremerControlsWin32.KremerVariable
    Friend WithEvents BottomMoldBReady As KremerControlsWin32.KremerVariable
    Friend WithEvents InitalizationsComplete As KremerControlsWin32.KremerVariable
    Friend WithEvents InitComplete As KremerControlsWin32.KremerLight
    Friend WithEvents ProductConveyorReady As KremerControlsWin32.KremerVariable
    Friend WithEvents InitPrConveyorComplete As KremerControlsWin32.KremerLight
    Friend WithEvents GantryAReady As KremerControlsWin32.KremerVariable
    Friend WithEvents InitGantryAComplete As KremerControlsWin32.KremerLight
    Friend WithEvents GantryBReady As KremerControlsWin32.KremerVariable
    Friend WithEvents InitGantryBComplete As KremerControlsWin32.KremerLight
    Friend WithEvents ProductHandlingReady As KremerControlsWin32.KremerVariable
    Friend WithEvents InitProductHandling As KremerControlsWin32.KremerLight
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label

End Class
