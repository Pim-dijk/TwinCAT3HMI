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
        Me.GantryAReady = New KremerControlsWin32.KremerVariable(Me.components)
        Me.InitGantryAComplete = New KremerControlsWin32.KremerLight()
        Me.GantryBReady = New KremerControlsWin32.KremerVariable(Me.components)
        Me.InitGantryBComplete = New KremerControlsWin32.KremerLight()
        Me.InitalizationsComplete = New KremerControlsWin32.KremerVariable(Me.components)
        Me.InitComplete = New KremerControlsWin32.KremerLight()
        Me.ProductHandlingReady = New KremerControlsWin32.KremerVariable(Me.components)
        Me.InitProductHandling = New KremerControlsWin32.KremerLight()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.KSB_IMD = New KremerControlsWin32.KremerStatusBox()
        Me.KSB_ProductHandling = New KremerControlsWin32.KremerStatusBox()
        Me.KSB_TransferMold = New KremerControlsWin32.KremerStatusBox()
        Me.KSB_ProductForming = New KremerControlsWin32.KremerStatusBox()
        Me.KSB_TopMoldA = New KremerControlsWin32.KremerStatusBox()
        Me.KSB_BottomMoldA = New KremerControlsWin32.KremerStatusBox()
        Me.KSB_TopMoldB = New KremerControlsWin32.KremerStatusBox()
        Me.KSB_BottomMoldB = New KremerControlsWin32.KremerStatusBox()
        Me.KSB_GantryA = New KremerControlsWin32.KremerStatusBox()
        Me.KSB_GantryB = New KremerControlsWin32.KremerStatusBox()
        Me.IMDstate = New KremerControlsWin32.KremerVariable(Me.components)
        Me.TrState = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ProductFormingState = New KremerControlsWin32.KremerVariable(Me.components)
        Me.TopMoldAState = New KremerControlsWin32.KremerVariable(Me.components)
        Me.TopMoldBState = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BotMoldAState = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BotMoldBState = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ProductHandlingState = New KremerControlsWin32.KremerVariable(Me.components)
        Me.GantryAState = New KremerControlsWin32.KremerVariable(Me.components)
        Me.GantryBState = New KremerControlsWin32.KremerVariable(Me.components)
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
        Me.krVarCollector.Variables.Add(Me.GantryAReady)
        Me.krVarCollector.Variables.Add(Me.GantryBReady)
        Me.krVarCollector.Variables.Add(Me.InitalizationsComplete)
        Me.krVarCollector.Variables.Add(Me.ProductHandlingReady)
        Me.krVarCollector.Variables.Add(Me.IMDstate)
        Me.krVarCollector.Variables.Add(Me.TrState)
        Me.krVarCollector.Variables.Add(Me.ProductFormingState)
        Me.krVarCollector.Variables.Add(Me.TopMoldAState)
        Me.krVarCollector.Variables.Add(Me.BotMoldAState)
        Me.krVarCollector.Variables.Add(Me.TopMoldBState)
        Me.krVarCollector.Variables.Add(Me.BotMoldBState)
        Me.krVarCollector.Variables.Add(Me.ProductHandlingState)
        Me.krVarCollector.Variables.Add(Me.GantryAState)
        Me.krVarCollector.Variables.Add(Me.GantryBState)
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
        Me.btnStartINIT.Location = New System.Drawing.Point(285, 39)
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
        Me.btnStopINIT.Location = New System.Drawing.Point(405, 39)
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
        Me.InitTransferComplete.Location = New System.Drawing.Point(15, 140)
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
        Me.InitProductFormingComplete.Location = New System.Drawing.Point(15, 171)
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
        Me.InitTopMoldAComplete.Location = New System.Drawing.Point(15, 202)
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
        Me.InitBottomMoldAComplete.Location = New System.Drawing.Point(15, 233)
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
        Me.InitTopMoldBComplete.Location = New System.Drawing.Point(15, 264)
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
        Me.InitBottomMoldBComplete.Location = New System.Drawing.Point(15, 292)
        Me.InitBottomMoldBComplete.Name = "InitBottomMoldBComplete"
        Me.InitBottomMoldBComplete.Size = New System.Drawing.Size(25, 25)
        Me.InitBottomMoldBComplete.TabIndex = 379
        Me.InitBottomMoldBComplete.Text = "KremerLight6"
        Me.InitBottomMoldBComplete.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
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
        Me.InitGantryAComplete.Location = New System.Drawing.Point(15, 373)
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
        Me.InitGantryBComplete.Location = New System.Drawing.Point(14, 404)
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
        Me.InitComplete.Location = New System.Drawing.Point(15, 104)
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
        Me.InitProductHandling.Location = New System.Drawing.Point(15, 342)
        Me.InitProductHandling.Name = "InitProductHandling"
        Me.InitProductHandling.Size = New System.Drawing.Size(25, 25)
        Me.InitProductHandling.TabIndex = 388
        Me.InitProductHandling.Text = "KremerLight1"
        Me.InitProductHandling.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 149)
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
        Me.Label2.Location = New System.Drawing.Point(46, 180)
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
        Me.Label3.Location = New System.Drawing.Point(45, 242)
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
        Me.Label4.Location = New System.Drawing.Point(46, 211)
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
        Me.Label5.Location = New System.Drawing.Point(46, 273)
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
        Me.Label6.Location = New System.Drawing.Point(46, 301)
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
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 441)
        Me.ShapeContainer1.TabIndex = 385
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.BorderWidth = 2
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 800
        Me.LineShape4.X2 = 0
        Me.LineShape4.Y1 = 100
        Me.LineShape4.Y2 = 100
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 250
        Me.LineShape3.X2 = 250
        Me.LineShape3.Y1 = 100
        Me.LineShape3.Y2 = 450
        '
        'LineShape2
        '
        Me.LineShape2.BorderWidth = 2
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 800
        Me.LineShape2.X2 = 0
        Me.LineShape2.Y1 = 134
        Me.LineShape2.Y2 = 134
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 2
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 800
        Me.LineShape1.X2 = 0
        Me.LineShape1.Y1 = 369
        Me.LineShape1.Y2 = 369
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(51, 347)
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
        Me.Label9.Location = New System.Drawing.Point(44, 109)
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
        Me.Label7.Location = New System.Drawing.Point(45, 413)
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
        Me.Label11.Location = New System.Drawing.Point(46, 382)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 16)
        Me.Label11.TabIndex = 392
        Me.Label11.Tag = "464"
        Me.Label11.Text = "Gantry A"
        '
        'KSB_IMD
        '
        Me.KSB_IMD.BackColor = System.Drawing.SystemColors.HighlightText
        Me.KSB_IMD.BackColorOn = System.Drawing.Color.Empty
        Me.KSB_IMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KSB_IMD.Data = 0
        Me.KSB_IMD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KSB_IMD.ForeColorOn = System.Drawing.Color.Empty
        Me.KSB_IMD.Location = New System.Drawing.Point(252, 106)
        Me.KSB_IMD.Name = "KSB_IMD"
        Me.KSB_IMD.Size = New System.Drawing.Size(545, 23)
        Me.KSB_IMD.State = False
        Me.KSB_IMD.StatusText = New String(-1) {}
        Me.KSB_IMD.TabIndex = 397
        Me.KSB_IMD.Text = "bla"
        '
        'KSB_ProductHandling
        '
        Me.KSB_ProductHandling.BackColor = System.Drawing.SystemColors.HighlightText
        Me.KSB_ProductHandling.BackColorOn = System.Drawing.Color.Empty
        Me.KSB_ProductHandling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KSB_ProductHandling.Data = 0
        Me.KSB_ProductHandling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KSB_ProductHandling.ForeColorOn = System.Drawing.Color.Empty
        Me.KSB_ProductHandling.Location = New System.Drawing.Point(252, 344)
        Me.KSB_ProductHandling.Name = "KSB_ProductHandling"
        Me.KSB_ProductHandling.Size = New System.Drawing.Size(545, 23)
        Me.KSB_ProductHandling.State = False
        Me.KSB_ProductHandling.StatusText = New String() {Nothing}
        Me.KSB_ProductHandling.TabIndex = 398
        Me.KSB_ProductHandling.Text = "KremerStatusBox2"
        '
        'KSB_TransferMold
        '
        Me.KSB_TransferMold.BackColor = System.Drawing.SystemColors.HighlightText
        Me.KSB_TransferMold.BackColorOn = System.Drawing.Color.Empty
        Me.KSB_TransferMold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KSB_TransferMold.Data = 0
        Me.KSB_TransferMold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KSB_TransferMold.ForeColorOn = System.Drawing.Color.Empty
        Me.KSB_TransferMold.Location = New System.Drawing.Point(252, 142)
        Me.KSB_TransferMold.Name = "KSB_TransferMold"
        Me.KSB_TransferMold.Size = New System.Drawing.Size(545, 23)
        Me.KSB_TransferMold.State = False
        Me.KSB_TransferMold.StatusText = New String() {Nothing}
        Me.KSB_TransferMold.TabIndex = 399
        Me.KSB_TransferMold.Text = "KremerStatusBox3"
        '
        'KSB_ProductForming
        '
        Me.KSB_ProductForming.BackColor = System.Drawing.SystemColors.HighlightText
        Me.KSB_ProductForming.BackColorOn = System.Drawing.Color.Empty
        Me.KSB_ProductForming.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KSB_ProductForming.Data = 0
        Me.KSB_ProductForming.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KSB_ProductForming.ForeColorOn = System.Drawing.Color.Empty
        Me.KSB_ProductForming.Location = New System.Drawing.Point(252, 173)
        Me.KSB_ProductForming.Name = "KSB_ProductForming"
        Me.KSB_ProductForming.Size = New System.Drawing.Size(545, 23)
        Me.KSB_ProductForming.State = False
        Me.KSB_ProductForming.StatusText = New String() {Nothing}
        Me.KSB_ProductForming.TabIndex = 400
        Me.KSB_ProductForming.Text = "KremerStatusBox4"
        '
        'KSB_TopMoldA
        '
        Me.KSB_TopMoldA.BackColor = System.Drawing.SystemColors.HighlightText
        Me.KSB_TopMoldA.BackColorOn = System.Drawing.Color.Empty
        Me.KSB_TopMoldA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KSB_TopMoldA.Data = 0
        Me.KSB_TopMoldA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KSB_TopMoldA.ForeColorOn = System.Drawing.Color.Empty
        Me.KSB_TopMoldA.Location = New System.Drawing.Point(252, 204)
        Me.KSB_TopMoldA.Name = "KSB_TopMoldA"
        Me.KSB_TopMoldA.Size = New System.Drawing.Size(545, 23)
        Me.KSB_TopMoldA.State = False
        Me.KSB_TopMoldA.StatusText = New String() {Nothing}
        Me.KSB_TopMoldA.TabIndex = 401
        Me.KSB_TopMoldA.Text = "KremerStatusBox5"
        '
        'KSB_BottomMoldA
        '
        Me.KSB_BottomMoldA.BackColor = System.Drawing.SystemColors.HighlightText
        Me.KSB_BottomMoldA.BackColorOn = System.Drawing.Color.Empty
        Me.KSB_BottomMoldA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KSB_BottomMoldA.Data = 0
        Me.KSB_BottomMoldA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KSB_BottomMoldA.ForeColorOn = System.Drawing.Color.Empty
        Me.KSB_BottomMoldA.Location = New System.Drawing.Point(252, 235)
        Me.KSB_BottomMoldA.Name = "KSB_BottomMoldA"
        Me.KSB_BottomMoldA.Size = New System.Drawing.Size(545, 23)
        Me.KSB_BottomMoldA.State = False
        Me.KSB_BottomMoldA.StatusText = New String() {Nothing}
        Me.KSB_BottomMoldA.TabIndex = 402
        Me.KSB_BottomMoldA.Text = "KremerStatusBox6"
        '
        'KSB_TopMoldB
        '
        Me.KSB_TopMoldB.BackColor = System.Drawing.SystemColors.HighlightText
        Me.KSB_TopMoldB.BackColorOn = System.Drawing.Color.Empty
        Me.KSB_TopMoldB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KSB_TopMoldB.Data = 0
        Me.KSB_TopMoldB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KSB_TopMoldB.ForeColorOn = System.Drawing.Color.Empty
        Me.KSB_TopMoldB.Location = New System.Drawing.Point(252, 266)
        Me.KSB_TopMoldB.Name = "KSB_TopMoldB"
        Me.KSB_TopMoldB.Size = New System.Drawing.Size(545, 23)
        Me.KSB_TopMoldB.State = False
        Me.KSB_TopMoldB.StatusText = New String() {Nothing}
        Me.KSB_TopMoldB.TabIndex = 403
        Me.KSB_TopMoldB.Text = "KremerStatusBox7"
        '
        'KSB_BottomMoldB
        '
        Me.KSB_BottomMoldB.BackColor = System.Drawing.SystemColors.HighlightText
        Me.KSB_BottomMoldB.BackColorOn = System.Drawing.Color.Empty
        Me.KSB_BottomMoldB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KSB_BottomMoldB.Data = 0
        Me.KSB_BottomMoldB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KSB_BottomMoldB.ForeColorOn = System.Drawing.Color.Empty
        Me.KSB_BottomMoldB.Location = New System.Drawing.Point(252, 297)
        Me.KSB_BottomMoldB.Name = "KSB_BottomMoldB"
        Me.KSB_BottomMoldB.Size = New System.Drawing.Size(545, 23)
        Me.KSB_BottomMoldB.State = False
        Me.KSB_BottomMoldB.StatusText = New String() {Nothing}
        Me.KSB_BottomMoldB.TabIndex = 404
        Me.KSB_BottomMoldB.Text = "KremerStatusBox8"
        '
        'KSB_GantryA
        '
        Me.KSB_GantryA.BackColor = System.Drawing.SystemColors.HighlightText
        Me.KSB_GantryA.BackColorOn = System.Drawing.Color.Empty
        Me.KSB_GantryA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KSB_GantryA.Data = 0
        Me.KSB_GantryA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KSB_GantryA.ForeColorOn = System.Drawing.Color.Empty
        Me.KSB_GantryA.Location = New System.Drawing.Point(252, 375)
        Me.KSB_GantryA.Name = "KSB_GantryA"
        Me.KSB_GantryA.Size = New System.Drawing.Size(545, 23)
        Me.KSB_GantryA.State = False
        Me.KSB_GantryA.StatusText = New String() {Nothing}
        Me.KSB_GantryA.TabIndex = 405
        Me.KSB_GantryA.Text = "KremerStatusBox9"
        '
        'KSB_GantryB
        '
        Me.KSB_GantryB.BackColor = System.Drawing.SystemColors.HighlightText
        Me.KSB_GantryB.BackColorOn = System.Drawing.Color.Empty
        Me.KSB_GantryB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.KSB_GantryB.Data = 0
        Me.KSB_GantryB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KSB_GantryB.ForeColorOn = System.Drawing.Color.Empty
        Me.KSB_GantryB.Location = New System.Drawing.Point(252, 406)
        Me.KSB_GantryB.Name = "KSB_GantryB"
        Me.KSB_GantryB.Size = New System.Drawing.Size(545, 23)
        Me.KSB_GantryB.State = False
        Me.KSB_GantryB.StatusText = New String() {Nothing}
        Me.KSB_GantryB.TabIndex = 406
        Me.KSB_GantryB.Text = "KremerStatusBox10"
        '
        'IMDstate
        '
        Me.IMDstate.BindControl = Me.KSB_IMD
        Me.IMDstate.BindProperty = "Data"
        Me.IMDstate.Data = Nothing
        Me.IMDstate.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.IMDstate.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.IMDstate.VariableName = "MAIN.InMoldDrying.miInitState"
        '
        'TrState
        '
        Me.TrState.BindControl = Me.KSB_TransferMold
        Me.TrState.BindProperty = "Data"
        Me.TrState.Data = Nothing
        Me.TrState.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.TrState.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TrState.VariableName = "MAIN.InMoldDrying.TransferMold.miInitState"
        '
        'ProductFormingState
        '
        Me.ProductFormingState.BindControl = Me.KSB_ProductForming
        Me.ProductFormingState.BindProperty = "Data"
        Me.ProductFormingState.Data = Nothing
        Me.ProductFormingState.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.ProductFormingState.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ProductFormingState.VariableName = "MAIN.InMoldDrying.ProductForming.miInitState"
        '
        'TopMoldAState
        '
        Me.TopMoldAState.BindControl = Me.KSB_TopMoldA
        Me.TopMoldAState.BindProperty = "Data"
        Me.TopMoldAState.Data = Nothing
        Me.TopMoldAState.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.TopMoldAState.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TopMoldAState.VariableName = "MAIN.InMoldDrying.TopMoldA.miInitState"
        '
        'TopMoldBState
        '
        Me.TopMoldBState.BindControl = Me.KSB_TopMoldB
        Me.TopMoldBState.BindProperty = "Data"
        Me.TopMoldBState.Data = Nothing
        Me.TopMoldBState.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.TopMoldBState.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TopMoldBState.VariableName = "MAIN.InMoldDrying.TopMoldB.miInitState"
        '
        'BotMoldAState
        '
        Me.BotMoldAState.BindControl = Me.KSB_BottomMoldA
        Me.BotMoldAState.BindProperty = "Data"
        Me.BotMoldAState.Data = Nothing
        Me.BotMoldAState.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.BotMoldAState.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BotMoldAState.VariableName = "MAIN.InMoldDrying.BottomMoldA.miInitState"
        '
        'BotMoldBState
        '
        Me.BotMoldBState.BindControl = Me.KSB_BottomMoldB
        Me.BotMoldBState.BindProperty = "Data"
        Me.BotMoldBState.Data = Nothing
        Me.BotMoldBState.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.BotMoldBState.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BotMoldBState.VariableName = "MAIN.InMoldDrying.BottomMoldB.miInitState"
        '
        'ProductHandlingState
        '
        Me.ProductHandlingState.BindControl = Me.KSB_ProductHandling
        Me.ProductHandlingState.BindProperty = "Data"
        Me.ProductHandlingState.Data = Nothing
        Me.ProductHandlingState.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.ProductHandlingState.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ProductHandlingState.VariableName = "MAIN.ProductHandling.miInitState"
        '
        'GantryAState
        '
        Me.GantryAState.BindControl = Me.KSB_GantryA
        Me.GantryAState.BindProperty = "Data"
        Me.GantryAState.Data = Nothing
        Me.GantryAState.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.GantryAState.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GantryAState.VariableName = "MAIN.ProductHandling.GantryA.miInitState"
        '
        'GantryBState
        '
        Me.GantryBState.BindControl = Me.KSB_GantryB
        Me.GantryBState.BindProperty = "Data"
        Me.GantryBState.Data = Nothing
        Me.GantryBState.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.GantryBState.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GantryBState.VariableName = "MAIN.ProductHandling.GantryB.miInitState"
        '
        'Init
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KSB_GantryB)
        Me.Controls.Add(Me.KSB_GantryA)
        Me.Controls.Add(Me.KSB_BottomMoldB)
        Me.Controls.Add(Me.KSB_TopMoldB)
        Me.Controls.Add(Me.KSB_BottomMoldA)
        Me.Controls.Add(Me.KSB_TopMoldA)
        Me.Controls.Add(Me.KSB_ProductForming)
        Me.Controls.Add(Me.KSB_TransferMold)
        Me.Controls.Add(Me.KSB_ProductHandling)
        Me.Controls.Add(Me.KSB_IMD)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.InitGantryBComplete)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.InitGantryAComplete)
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
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents KSB_IMD As KremerControlsWin32.KremerStatusBox
    Friend WithEvents KSB_ProductHandling As KremerControlsWin32.KremerStatusBox
    Friend WithEvents KSB_TransferMold As KremerControlsWin32.KremerStatusBox
    Friend WithEvents KSB_ProductForming As KremerControlsWin32.KremerStatusBox
    Friend WithEvents KSB_TopMoldA As KremerControlsWin32.KremerStatusBox
    Friend WithEvents KSB_BottomMoldA As KremerControlsWin32.KremerStatusBox
    Friend WithEvents KSB_TopMoldB As KremerControlsWin32.KremerStatusBox
    Friend WithEvents KSB_BottomMoldB As KremerControlsWin32.KremerStatusBox
    Friend WithEvents KSB_GantryB As KremerControlsWin32.KremerStatusBox
    Friend WithEvents KSB_GantryA As KremerControlsWin32.KremerStatusBox
    Friend WithEvents IMDstate As KremerControlsWin32.KremerVariable
    Friend WithEvents TrState As KremerControlsWin32.KremerVariable
    Friend WithEvents ProductFormingState As KremerControlsWin32.KremerVariable
    Friend WithEvents TopMoldAState As KremerControlsWin32.KremerVariable
    Friend WithEvents BotMoldAState As KremerControlsWin32.KremerVariable
    Friend WithEvents TopMoldBState As KremerControlsWin32.KremerVariable
    Friend WithEvents BotMoldBState As KremerControlsWin32.KremerVariable
    Friend WithEvents ProductHandlingState As KremerControlsWin32.KremerVariable
    Friend WithEvents GantryAState As KremerControlsWin32.KremerVariable
    Friend WithEvents GantryBState As KremerControlsWin32.KremerVariable

End Class
