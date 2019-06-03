<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SequenceInit
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bottom mold A")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Top Mold A")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transfermold")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Machine pond")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bottom Mold B")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Top Mold B")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("In Mold drying", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gantry A")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gantry B")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product handling", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Machine", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode10})
        Me.krConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.krVarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.StartInit = New KremerControlsWin32.KremerVariable(Me.components)
        Me.btnStartINIT = New KremerControlsWin32.KremerButton()
        Me.StopInit = New KremerControlsWin32.KremerVariable(Me.components)
        Me.btnStopINIT = New KremerControlsWin32.KremerButton()
        Me.initIMD = New KremerControlsWin32.KremerVariable(Me.components)
        Me.txtInMoldDrying = New KremerControlsWin32.KremerTextField(Me.components)
        Me.initBottomA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.txtBottomMoldA = New KremerControlsWin32.KremerTextField(Me.components)
        Me.InitTopA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.txtTopMoldA = New KremerControlsWin32.KremerTextField(Me.components)
        Me.InitTransfer = New KremerControlsWin32.KremerVariable(Me.components)
        Me.txtTransferMold = New KremerControlsWin32.KremerTextField(Me.components)
        Me.InitMachinePond = New KremerControlsWin32.KremerVariable(Me.components)
        Me.txtMachinePond = New KremerControlsWin32.KremerTextField(Me.components)
        Me.InitBottomB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.txtBottomMoldB = New KremerControlsWin32.KremerTextField(Me.components)
        Me.InitTopB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.txtTopMoldB = New KremerControlsWin32.KremerTextField(Me.components)
        Me.ProductHandling = New KremerControlsWin32.KremerVariable(Me.components)
        Me.txtProductHandling = New KremerControlsWin32.KremerTextField(Me.components)
        Me.InitGantryA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.txtGantryA = New KremerControlsWin32.KremerTextField(Me.components)
        Me.InitGantryB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.GantryB = New KremerControlsWin32.KremerTextField(Me.components)
        Me.InitProductConv = New KremerControlsWin32.KremerVariable(Me.components)
        Me.txtInlineAutomation = New KremerControlsWin32.KremerStatusBox()
        Me.tvInline = New System.Windows.Forms.TreeView()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.krVarCollector.Variables.Add(Me.initIMD)
        Me.krVarCollector.Variables.Add(Me.initBottomA)
        Me.krVarCollector.Variables.Add(Me.InitTopA)
        Me.krVarCollector.Variables.Add(Me.InitTransfer)
        Me.krVarCollector.Variables.Add(Me.InitMachinePond)
        Me.krVarCollector.Variables.Add(Me.InitBottomB)
        Me.krVarCollector.Variables.Add(Me.InitTopB)
        Me.krVarCollector.Variables.Add(Me.ProductHandling)
        Me.krVarCollector.Variables.Add(Me.InitGantryA)
        Me.krVarCollector.Variables.Add(Me.InitGantryB)
        Me.krVarCollector.Variables.Add(Me.InitProductConv)
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
        Me.btnStartINIT.Location = New System.Drawing.Point(468, 214)
        Me.btnStartINIT.Name = "btnStartINIT"
        Me.btnStartINIT.Size = New System.Drawing.Size(114, 50)
        Me.btnStartINIT.State = False
        Me.btnStartINIT.StateIsData = False
        Me.btnStartINIT.StateText = New String() {Nothing, Nothing}
        Me.btnStartINIT.TabIndex = 369
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
        Me.btnStopINIT.Enabled = False
        Me.btnStopINIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStopINIT.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnStopINIT.ForeColorOn = System.Drawing.SystemColors.ControlText
        Me.btnStopINIT.Location = New System.Drawing.Point(635, 214)
        Me.btnStopINIT.Name = "btnStopINIT"
        Me.btnStopINIT.Size = New System.Drawing.Size(114, 50)
        Me.btnStopINIT.State = False
        Me.btnStopINIT.StateIsData = False
        Me.btnStopINIT.StateText = New String() {Nothing, Nothing}
        Me.btnStopINIT.TabIndex = 368
        Me.btnStopINIT.Text = "Stop INIT"
        Me.btnStopINIT.UserInfo = Nothing
        Me.btnStopINIT.UserLevel = 0
        Me.btnStopINIT.UseStateText = False
        Me.btnStopINIT.UseVisualStyleBackColor = True
        '
        'initIMD
        '
        Me.initIMD.BindControl = Me.txtInMoldDrying
        Me.initIMD.BindProperty = "Data"
        Me.initIMD.Data = Nothing
        Me.initIMD.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.initIMD.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.initIMD.VariableName = "MAIN.InMoldDrying.sInitStateText"
        '
        'txtInMoldDrying
        '
        Me.txtInMoldDrying.Audit = Nothing
        Me.txtInMoldDrying.AuditEnabled = False
        Me.txtInMoldDrying.AuditMessage = "KremerTextField changed:"
        Me.txtInMoldDrying.AuditSource = "KremerTextField"
        Me.txtInMoldDrying.BackColor = System.Drawing.Color.White
        Me.txtInMoldDrying.BackColorOn = System.Drawing.Color.Empty
        Me.txtInMoldDrying.Data = "Text"
        Me.txtInMoldDrying.ForeColor = System.Drawing.Color.Navy
        Me.txtInMoldDrying.ForeColorOn = System.Drawing.Color.Empty
        Me.txtInMoldDrying.InitialValue = True
        Me.txtInMoldDrying.IOType = KremerControlsWin32.KremerTextField.IO_Type.Output
        Me.txtInMoldDrying.Location = New System.Drawing.Point(153, 27)
        Me.txtInMoldDrying.Name = "txtInMoldDrying"
        Me.txtInMoldDrying.PasswordMask = False
        Me.txtInMoldDrying.Size = New System.Drawing.Size(240, 14)
        Me.txtInMoldDrying.State = False
        Me.txtInMoldDrying.TabIndex = 6
        Me.txtInMoldDrying.Text = "Cycle State"
        Me.txtInMoldDrying.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtInMoldDrying.UserInfo = Nothing
        Me.txtInMoldDrying.UserLevel = 0
        '
        'initBottomA
        '
        Me.initBottomA.BindControl = Me.txtBottomMoldA
        Me.initBottomA.BindProperty = "Data"
        Me.initBottomA.Data = Nothing
        Me.initBottomA.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.initBottomA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.initBottomA.VariableName = "MAIN.InMoldDrying.BottomMoldA.sInitStateText"
        '
        'txtBottomMoldA
        '
        Me.txtBottomMoldA.Audit = Nothing
        Me.txtBottomMoldA.AuditEnabled = False
        Me.txtBottomMoldA.AuditMessage = "KremerTextField changed:"
        Me.txtBottomMoldA.AuditSource = "KremerTextField"
        Me.txtBottomMoldA.BackColor = System.Drawing.Color.White
        Me.txtBottomMoldA.BackColorOn = System.Drawing.Color.Empty
        Me.txtBottomMoldA.Data = "Text"
        Me.txtBottomMoldA.ForeColor = System.Drawing.Color.Navy
        Me.txtBottomMoldA.ForeColorOn = System.Drawing.Color.Empty
        Me.txtBottomMoldA.InitialValue = True
        Me.txtBottomMoldA.IOType = KremerControlsWin32.KremerTextField.IO_Type.Output
        Me.txtBottomMoldA.Location = New System.Drawing.Point(153, 43)
        Me.txtBottomMoldA.Name = "txtBottomMoldA"
        Me.txtBottomMoldA.PasswordMask = False
        Me.txtBottomMoldA.Size = New System.Drawing.Size(240, 14)
        Me.txtBottomMoldA.State = False
        Me.txtBottomMoldA.TabIndex = 7
        Me.txtBottomMoldA.Text = "Cycle State"
        Me.txtBottomMoldA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtBottomMoldA.UserInfo = Nothing
        Me.txtBottomMoldA.UserLevel = 0
        '
        'InitTopA
        '
        Me.InitTopA.BindControl = Me.txtTopMoldA
        Me.InitTopA.BindProperty = "Data"
        Me.InitTopA.Data = Nothing
        Me.InitTopA.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.InitTopA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.InitTopA.VariableName = "MAIN.InMoldDrying.TopMoldA.sInitStateText"
        '
        'txtTopMoldA
        '
        Me.txtTopMoldA.Audit = Nothing
        Me.txtTopMoldA.AuditEnabled = False
        Me.txtTopMoldA.AuditMessage = "KremerTextField changed:"
        Me.txtTopMoldA.AuditSource = "KremerTextField"
        Me.txtTopMoldA.BackColor = System.Drawing.Color.White
        Me.txtTopMoldA.BackColorOn = System.Drawing.Color.Empty
        Me.txtTopMoldA.Data = "Text"
        Me.txtTopMoldA.ForeColor = System.Drawing.Color.Navy
        Me.txtTopMoldA.ForeColorOn = System.Drawing.Color.Empty
        Me.txtTopMoldA.InitialValue = True
        Me.txtTopMoldA.IOType = KremerControlsWin32.KremerTextField.IO_Type.Output
        Me.txtTopMoldA.Location = New System.Drawing.Point(153, 59)
        Me.txtTopMoldA.Name = "txtTopMoldA"
        Me.txtTopMoldA.PasswordMask = False
        Me.txtTopMoldA.Size = New System.Drawing.Size(240, 14)
        Me.txtTopMoldA.State = False
        Me.txtTopMoldA.TabIndex = 8
        Me.txtTopMoldA.Text = "Cycle State"
        Me.txtTopMoldA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtTopMoldA.UserInfo = Nothing
        Me.txtTopMoldA.UserLevel = 0
        '
        'InitTransfer
        '
        Me.InitTransfer.BindControl = Me.txtTransferMold
        Me.InitTransfer.BindProperty = "Data"
        Me.InitTransfer.Data = Nothing
        Me.InitTransfer.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.InitTransfer.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.InitTransfer.VariableName = "MAIN.InMoldDrying.TransferMold.sInitStateText"
        '
        'txtTransferMold
        '
        Me.txtTransferMold.Audit = Nothing
        Me.txtTransferMold.AuditEnabled = False
        Me.txtTransferMold.AuditMessage = "KremerTextField changed:"
        Me.txtTransferMold.AuditSource = "KremerTextField"
        Me.txtTransferMold.BackColor = System.Drawing.Color.White
        Me.txtTransferMold.BackColorOn = System.Drawing.Color.Empty
        Me.txtTransferMold.Data = "Text"
        Me.txtTransferMold.ForeColor = System.Drawing.Color.Navy
        Me.txtTransferMold.ForeColorOn = System.Drawing.Color.Empty
        Me.txtTransferMold.InitialValue = True
        Me.txtTransferMold.IOType = KremerControlsWin32.KremerTextField.IO_Type.Output
        Me.txtTransferMold.Location = New System.Drawing.Point(153, 75)
        Me.txtTransferMold.Name = "txtTransferMold"
        Me.txtTransferMold.PasswordMask = False
        Me.txtTransferMold.Size = New System.Drawing.Size(240, 14)
        Me.txtTransferMold.State = False
        Me.txtTransferMold.TabIndex = 9
        Me.txtTransferMold.Text = "Cycle State"
        Me.txtTransferMold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtTransferMold.UserInfo = Nothing
        Me.txtTransferMold.UserLevel = 0
        '
        'InitMachinePond
        '
        Me.InitMachinePond.BindControl = Me.txtMachinePond
        Me.InitMachinePond.BindProperty = "Data"
        Me.InitMachinePond.Data = Nothing
        Me.InitMachinePond.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.InitMachinePond.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.InitMachinePond.VariableName = "MAIN.InMoldDrying.ProductForming.sInitStateText"
        '
        'txtMachinePond
        '
        Me.txtMachinePond.Audit = Nothing
        Me.txtMachinePond.AuditEnabled = False
        Me.txtMachinePond.AuditMessage = "KremerTextField changed:"
        Me.txtMachinePond.AuditSource = "KremerTextField"
        Me.txtMachinePond.BackColor = System.Drawing.Color.White
        Me.txtMachinePond.BackColorOn = System.Drawing.Color.Empty
        Me.txtMachinePond.Data = "Text"
        Me.txtMachinePond.ForeColor = System.Drawing.Color.Navy
        Me.txtMachinePond.ForeColorOn = System.Drawing.Color.Empty
        Me.txtMachinePond.InitialValue = True
        Me.txtMachinePond.IOType = KremerControlsWin32.KremerTextField.IO_Type.Output
        Me.txtMachinePond.Location = New System.Drawing.Point(153, 91)
        Me.txtMachinePond.Name = "txtMachinePond"
        Me.txtMachinePond.PasswordMask = False
        Me.txtMachinePond.Size = New System.Drawing.Size(240, 14)
        Me.txtMachinePond.State = False
        Me.txtMachinePond.TabIndex = 10
        Me.txtMachinePond.Text = "Cycle State"
        Me.txtMachinePond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtMachinePond.UserInfo = Nothing
        Me.txtMachinePond.UserLevel = 0
        '
        'InitBottomB
        '
        Me.InitBottomB.BindControl = Me.txtBottomMoldB
        Me.InitBottomB.BindProperty = "Data"
        Me.InitBottomB.Data = Nothing
        Me.InitBottomB.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.InitBottomB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.InitBottomB.VariableName = "MAIN.InMoldDrying.BottomMoldB.sInitStateText"
        '
        'txtBottomMoldB
        '
        Me.txtBottomMoldB.Audit = Nothing
        Me.txtBottomMoldB.AuditEnabled = False
        Me.txtBottomMoldB.AuditMessage = "KremerTextField changed:"
        Me.txtBottomMoldB.AuditSource = "KremerTextField"
        Me.txtBottomMoldB.BackColor = System.Drawing.Color.White
        Me.txtBottomMoldB.BackColorOn = System.Drawing.Color.Empty
        Me.txtBottomMoldB.Data = "Text"
        Me.txtBottomMoldB.ForeColor = System.Drawing.Color.Navy
        Me.txtBottomMoldB.ForeColorOn = System.Drawing.Color.Empty
        Me.txtBottomMoldB.InitialValue = True
        Me.txtBottomMoldB.IOType = KremerControlsWin32.KremerTextField.IO_Type.Output
        Me.txtBottomMoldB.Location = New System.Drawing.Point(153, 107)
        Me.txtBottomMoldB.Name = "txtBottomMoldB"
        Me.txtBottomMoldB.PasswordMask = False
        Me.txtBottomMoldB.Size = New System.Drawing.Size(240, 14)
        Me.txtBottomMoldB.State = False
        Me.txtBottomMoldB.TabIndex = 11
        Me.txtBottomMoldB.Text = "Cycle State"
        Me.txtBottomMoldB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtBottomMoldB.UserInfo = Nothing
        Me.txtBottomMoldB.UserLevel = 0
        '
        'InitTopB
        '
        Me.InitTopB.BindControl = Me.txtTopMoldB
        Me.InitTopB.BindProperty = "Data"
        Me.InitTopB.Data = Nothing
        Me.InitTopB.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.InitTopB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.InitTopB.VariableName = "MAIN.InMoldDrying.TopMoldB.sInitStateText"
        '
        'txtTopMoldB
        '
        Me.txtTopMoldB.Audit = Nothing
        Me.txtTopMoldB.AuditEnabled = False
        Me.txtTopMoldB.AuditMessage = "KremerTextField changed:"
        Me.txtTopMoldB.AuditSource = "KremerTextField"
        Me.txtTopMoldB.BackColor = System.Drawing.Color.White
        Me.txtTopMoldB.BackColorOn = System.Drawing.Color.Empty
        Me.txtTopMoldB.Data = "Text"
        Me.txtTopMoldB.ForeColor = System.Drawing.Color.Navy
        Me.txtTopMoldB.ForeColorOn = System.Drawing.Color.Empty
        Me.txtTopMoldB.InitialValue = True
        Me.txtTopMoldB.IOType = KremerControlsWin32.KremerTextField.IO_Type.Output
        Me.txtTopMoldB.Location = New System.Drawing.Point(153, 123)
        Me.txtTopMoldB.Name = "txtTopMoldB"
        Me.txtTopMoldB.PasswordMask = False
        Me.txtTopMoldB.Size = New System.Drawing.Size(240, 14)
        Me.txtTopMoldB.State = False
        Me.txtTopMoldB.TabIndex = 347
        Me.txtTopMoldB.Text = "Cycle State"
        Me.txtTopMoldB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtTopMoldB.UserInfo = Nothing
        Me.txtTopMoldB.UserLevel = 0
        '
        'ProductHandling
        '
        Me.ProductHandling.BindControl = Me.txtProductHandling
        Me.ProductHandling.BindProperty = "Data"
        Me.ProductHandling.Data = Nothing
        Me.ProductHandling.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.ProductHandling.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ProductHandling.VariableName = "MAIN.ProductHandling.sInitStateText"
        '
        'txtProductHandling
        '
        Me.txtProductHandling.Audit = Nothing
        Me.txtProductHandling.AuditEnabled = False
        Me.txtProductHandling.AuditMessage = "KremerTextField changed:"
        Me.txtProductHandling.AuditSource = "KremerTextField"
        Me.txtProductHandling.BackColor = System.Drawing.Color.White
        Me.txtProductHandling.BackColorOn = System.Drawing.Color.Empty
        Me.txtProductHandling.Data = "Text"
        Me.txtProductHandling.ForeColor = System.Drawing.Color.Navy
        Me.txtProductHandling.ForeColorOn = System.Drawing.Color.Empty
        Me.txtProductHandling.InitialValue = True
        Me.txtProductHandling.IOType = KremerControlsWin32.KremerTextField.IO_Type.Output
        Me.txtProductHandling.Location = New System.Drawing.Point(153, 139)
        Me.txtProductHandling.Name = "txtProductHandling"
        Me.txtProductHandling.PasswordMask = False
        Me.txtProductHandling.Size = New System.Drawing.Size(240, 14)
        Me.txtProductHandling.State = False
        Me.txtProductHandling.TabIndex = 348
        Me.txtProductHandling.Text = "Cycle State"
        Me.txtProductHandling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtProductHandling.UserInfo = Nothing
        Me.txtProductHandling.UserLevel = 0
        '
        'InitGantryA
        '
        Me.InitGantryA.BindControl = Me.txtGantryA
        Me.InitGantryA.BindProperty = "Data"
        Me.InitGantryA.Data = Nothing
        Me.InitGantryA.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.InitGantryA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.InitGantryA.VariableName = "MAIN.ProductHandling.GantryA.sInitStateText"
        '
        'txtGantryA
        '
        Me.txtGantryA.Audit = Nothing
        Me.txtGantryA.AuditEnabled = False
        Me.txtGantryA.AuditMessage = "KremerTextField changed:"
        Me.txtGantryA.AuditSource = "KremerTextField"
        Me.txtGantryA.BackColor = System.Drawing.Color.White
        Me.txtGantryA.BackColorOn = System.Drawing.Color.Empty
        Me.txtGantryA.Data = "Text"
        Me.txtGantryA.ForeColor = System.Drawing.Color.Navy
        Me.txtGantryA.ForeColorOn = System.Drawing.Color.Empty
        Me.txtGantryA.InitialValue = True
        Me.txtGantryA.IOType = KremerControlsWin32.KremerTextField.IO_Type.Output
        Me.txtGantryA.Location = New System.Drawing.Point(153, 155)
        Me.txtGantryA.Name = "txtGantryA"
        Me.txtGantryA.PasswordMask = False
        Me.txtGantryA.Size = New System.Drawing.Size(240, 14)
        Me.txtGantryA.State = False
        Me.txtGantryA.TabIndex = 344
        Me.txtGantryA.Text = "Cycle State"
        Me.txtGantryA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtGantryA.UserInfo = Nothing
        Me.txtGantryA.UserLevel = 0
        '
        'InitGantryB
        '
        Me.InitGantryB.BindControl = Me.GantryB
        Me.InitGantryB.BindProperty = "Data"
        Me.InitGantryB.Data = Nothing
        Me.InitGantryB.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.InitGantryB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.InitGantryB.VariableName = "MAIN.ProductHandling.GantryB.sInitStateText"
        '
        'GantryB
        '
        Me.GantryB.Audit = Nothing
        Me.GantryB.AuditEnabled = False
        Me.GantryB.AuditMessage = "KremerTextField changed:"
        Me.GantryB.AuditSource = "KremerTextField"
        Me.GantryB.BackColor = System.Drawing.Color.White
        Me.GantryB.BackColorOn = System.Drawing.Color.Empty
        Me.GantryB.Data = "Text"
        Me.GantryB.ForeColor = System.Drawing.Color.Navy
        Me.GantryB.ForeColorOn = System.Drawing.Color.Empty
        Me.GantryB.InitialValue = True
        Me.GantryB.IOType = KremerControlsWin32.KremerTextField.IO_Type.Output
        Me.GantryB.Location = New System.Drawing.Point(153, 171)
        Me.GantryB.Name = "GantryB"
        Me.GantryB.PasswordMask = False
        Me.GantryB.Size = New System.Drawing.Size(240, 14)
        Me.GantryB.State = False
        Me.GantryB.TabIndex = 345
        Me.GantryB.Text = "Cycle State"
        Me.GantryB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GantryB.UserInfo = Nothing
        Me.GantryB.UserLevel = 0
        '
        'InitProductConv
        '
        Me.InitProductConv.BindControl = Nothing
        Me.InitProductConv.BindProperty = "Data"
        Me.InitProductConv.Data = Nothing
        Me.InitProductConv.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.InitProductConv.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.InitProductConv.VariableName = Nothing
        '
        'txtInlineAutomation
        '
        Me.txtInlineAutomation.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtInlineAutomation.BackColorOn = System.Drawing.Color.Lime
        Me.txtInlineAutomation.Data = 0
        Me.txtInlineAutomation.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.txtInlineAutomation.ForeColor = System.Drawing.Color.Navy
        Me.txtInlineAutomation.ForeColorOn = System.Drawing.Color.Black
        Me.txtInlineAutomation.Location = New System.Drawing.Point(496, 354)
        Me.txtInlineAutomation.Name = "txtInlineAutomation"
        Me.txtInlineAutomation.Size = New System.Drawing.Size(299, 30)
        Me.txtInlineAutomation.State = False
        Me.txtInlineAutomation.StatusText = Nothing
        Me.txtInlineAutomation.TabIndex = 370
        Me.txtInlineAutomation.Text = "State"
        Me.txtInlineAutomation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tvInline
        '
        Me.tvInline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvInline.ForeColor = System.Drawing.Color.Navy
        Me.tvInline.FullRowSelect = True
        Me.tvInline.LineColor = System.Drawing.Color.Red
        Me.tvInline.Location = New System.Drawing.Point(2, 10)
        Me.tvInline.Name = "tvInline"
        TreeNode1.Checked = True
        TreeNode1.Name = "Node8"
        TreeNode1.Text = "Bottom mold A"
        TreeNode2.Checked = True
        TreeNode2.Name = "Node9"
        TreeNode2.Text = "Top Mold A"
        TreeNode3.Checked = True
        TreeNode3.Name = "Node10"
        TreeNode3.Text = "Transfermold"
        TreeNode4.Checked = True
        TreeNode4.Name = "Node11"
        TreeNode4.Text = "Machine pond"
        TreeNode5.Checked = True
        TreeNode5.Name = "Node12"
        TreeNode5.Text = "Bottom Mold B"
        TreeNode5.ToolTipText = "Bottom mold B"
        TreeNode6.Checked = True
        TreeNode6.Name = "Node13"
        TreeNode6.Text = "Top Mold B"
        TreeNode7.Checked = True
        TreeNode7.Name = "Node0"
        TreeNode7.Text = "In Mold drying"
        TreeNode8.Checked = True
        TreeNode8.Name = "Node14"
        TreeNode8.Text = "Gantry A"
        TreeNode9.Checked = True
        TreeNode9.Name = "Node15"
        TreeNode9.Text = "Gantry B"
        TreeNode10.Checked = True
        TreeNode10.Name = "Node3"
        TreeNode10.Text = "Product handling"
        TreeNode11.Checked = True
        TreeNode11.Name = "Node0"
        TreeNode11.Text = "Machine"
        Me.tvInline.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode11})
        Me.tvInline.ShowPlusMinus = False
        Me.tvInline.ShowRootLines = False
        Me.tvInline.Size = New System.Drawing.Size(415, 375)
        Me.tvInline.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(420, 353)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 32)
        Me.Label1.TabIndex = 371
        Me.Label1.Tag = ""
        Me.Label1.Text = "Status:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SequenceInit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtInlineAutomation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStopINIT)
        Me.Controls.Add(Me.btnStartINIT)
        Me.Controls.Add(Me.txtProductHandling)
        Me.Controls.Add(Me.txtTopMoldB)
        Me.Controls.Add(Me.GantryB)
        Me.Controls.Add(Me.txtGantryA)
        Me.Controls.Add(Me.txtBottomMoldB)
        Me.Controls.Add(Me.txtMachinePond)
        Me.Controls.Add(Me.txtTransferMold)
        Me.Controls.Add(Me.txtTopMoldA)
        Me.Controls.Add(Me.txtBottomMoldA)
        Me.Controls.Add(Me.txtInMoldDrying)
        Me.Controls.Add(Me.tvInline)
        Me.Name = "SequenceInit"
        Me.Size = New System.Drawing.Size(800, 441)
        Me.Tag = "502"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents krConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents krVarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents tvInline As System.Windows.Forms.TreeView
    Friend WithEvents txtInMoldDrying As KremerControlsWin32.KremerTextField
    Friend WithEvents txtBottomMoldA As KremerControlsWin32.KremerTextField
    Friend WithEvents txtTopMoldA As KremerControlsWin32.KremerTextField
    Friend WithEvents txtTransferMold As KremerControlsWin32.KremerTextField
    Friend WithEvents txtMachinePond As KremerControlsWin32.KremerTextField
    Friend WithEvents txtBottomMoldB As KremerControlsWin32.KremerTextField
    Friend WithEvents txtProductHandling As KremerControlsWin32.KremerTextField
    Friend WithEvents txtTopMoldB As KremerControlsWin32.KremerTextField
    Friend WithEvents GantryB As KremerControlsWin32.KremerTextField
    Friend WithEvents txtGantryA As KremerControlsWin32.KremerTextField
    Friend WithEvents txtInlineAutomation As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnStopINIT As KremerControlsWin32.KremerButton
    Friend WithEvents btnStartINIT As KremerControlsWin32.KremerButton
    Friend WithEvents initIMD As KremerControlsWin32.KremerVariable
    Friend WithEvents initBottomA As KremerControlsWin32.KremerVariable
    Friend WithEvents InitTopA As KremerControlsWin32.KremerVariable
    Friend WithEvents InitTransfer As KremerControlsWin32.KremerVariable
    Friend WithEvents InitMachinePond As KremerControlsWin32.KremerVariable
    Friend WithEvents InitBottomB As KremerControlsWin32.KremerVariable
    Friend WithEvents InitTopB As KremerControlsWin32.KremerVariable
    Friend WithEvents ProductHandling As KremerControlsWin32.KremerVariable
    Friend WithEvents InitGantryA As KremerControlsWin32.KremerVariable
    Friend WithEvents InitGantryB As KremerControlsWin32.KremerVariable
    Friend WithEvents InitProductConv As KremerControlsWin32.KremerVariable
    Friend WithEvents StartInit As KremerControlsWin32.KremerVariable
    Friend WithEvents StopInit As KremerControlsWin32.KremerVariable

End Class
