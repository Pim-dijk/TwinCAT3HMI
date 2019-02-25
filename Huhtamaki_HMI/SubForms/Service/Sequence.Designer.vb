<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sequence
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
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bottom mold A")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Top Mold A")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transfer Mold")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Forming")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bottom Mold B")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Top Mold B")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("In Mold Drying", New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode14, TreeNode15, TreeNode16, TreeNode17, TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gantry A")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gantry B")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Conveyor")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Product Handling", New System.Windows.Forms.TreeNode() {TreeNode20, TreeNode21, TreeNode22})
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Machine", New System.Windows.Forms.TreeNode() {TreeNode19, TreeNode23})
        Me.krConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.krVarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.IMD_inRest = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plInMoldDryingRest = New KremerControlsWin32.KremerLight()
        Me.PH_InRest = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plProductHandlingRest = New KremerControlsWin32.KremerLight()
        Me.InMoldDrying = New KremerControlsWin32.KremerVariable(Me.components)
        Me.txtImd = New KremerControlsWin32.KremerTextField(Me.components)
        Me.BottomA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.txtBottomMoldA = New KremerControlsWin32.KremerTextField(Me.components)
        Me.TopA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.txtTopMoldA = New KremerControlsWin32.KremerTextField(Me.components)
        Me.TransferMold = New KremerControlsWin32.KremerVariable(Me.components)
        Me.txtTransfermold = New KremerControlsWin32.KremerTextField(Me.components)
        Me.MachinePond = New KremerControlsWin32.KremerVariable(Me.components)
        Me.txtMachinePond = New KremerControlsWin32.KremerTextField(Me.components)
        Me.BottomB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.txtBottomMoldB = New KremerControlsWin32.KremerTextField(Me.components)
        Me.TopB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.txtTopMoldB = New KremerControlsWin32.KremerTextField(Me.components)
        Me.ProductHandling = New KremerControlsWin32.KremerVariable(Me.components)
        Me.txtProductHandling = New KremerControlsWin32.KremerTextField(Me.components)
        Me.GantryA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.txtGantryA = New KremerControlsWin32.KremerTextField(Me.components)
        Me.GantryB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.txtGantryB = New KremerControlsWin32.KremerTextField(Me.components)
        Me.ProductConveyor = New KremerControlsWin32.KremerVariable(Me.components)
        Me.txtProductConveyor = New KremerControlsWin32.KremerTextField(Me.components)
        Me.btnMasterReset = New KremerControlsWin32.KremerButton()
        Me.btnEnableForcedInit = New KremerControlsWin32.KremerButton()
        Me.tvInline = New System.Windows.Forms.TreeView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'krConnector
        '
        Me.krConnector.VarCollector = Nothing
        '
        'krVarCollector
        '
        Me.krVarCollector.Variables.Add(Me.IMD_inRest)
        Me.krVarCollector.Variables.Add(Me.PH_InRest)
        Me.krVarCollector.Variables.Add(Me.InMoldDrying)
        Me.krVarCollector.Variables.Add(Me.BottomA)
        Me.krVarCollector.Variables.Add(Me.TopA)
        Me.krVarCollector.Variables.Add(Me.TransferMold)
        Me.krVarCollector.Variables.Add(Me.MachinePond)
        Me.krVarCollector.Variables.Add(Me.BottomB)
        Me.krVarCollector.Variables.Add(Me.TopB)
        Me.krVarCollector.Variables.Add(Me.ProductHandling)
        Me.krVarCollector.Variables.Add(Me.GantryA)
        Me.krVarCollector.Variables.Add(Me.GantryB)
        Me.krVarCollector.Variables.Add(Me.ProductConveyor)
        '
        'IMD_inRest
        '
        Me.IMD_inRest.BindControl = Me.plInMoldDryingRest
        Me.IMD_inRest.BindProperty = "Data"
        Me.IMD_inRest.Data = Nothing
        Me.IMD_inRest.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.IMD_inRest.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.IMD_inRest.VariableName = "MAIN.InMoldDrying.mxCycleBusy"
        '
        'plInMoldDryingRest
        '
        Me.plInMoldDryingRest.ColorOff = System.Drawing.Color.Lime
        Me.plInMoldDryingRest.ColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plInMoldDryingRest.Data = False
        Me.plInMoldDryingRest.Line = True
        Me.plInMoldDryingRest.LineSize = 1
        Me.plInMoldDryingRest.Location = New System.Drawing.Point(302, 410)
        Me.plInMoldDryingRest.Name = "plInMoldDryingRest"
        Me.plInMoldDryingRest.Size = New System.Drawing.Size(25, 25)
        Me.plInMoldDryingRest.TabIndex = 368
        Me.plInMoldDryingRest.Text = "KremerLight3"
        Me.plInMoldDryingRest.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'PH_InRest
        '
        Me.PH_InRest.BindControl = Me.plProductHandlingRest
        Me.PH_InRest.BindProperty = "Data"
        Me.PH_InRest.Data = Nothing
        Me.PH_InRest.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PH_InRest.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PH_InRest.VariableName = "MAIN.ProductHandling.mxCycleBusy"
        '
        'plProductHandlingRest
        '
        Me.plProductHandlingRest.ColorOff = System.Drawing.Color.Lime
        Me.plProductHandlingRest.ColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plProductHandlingRest.Data = False
        Me.plProductHandlingRest.Line = True
        Me.plProductHandlingRest.LineSize = 1
        Me.plProductHandlingRest.Location = New System.Drawing.Point(411, 410)
        Me.plProductHandlingRest.Name = "plProductHandlingRest"
        Me.plProductHandlingRest.Size = New System.Drawing.Size(25, 25)
        Me.plProductHandlingRest.TabIndex = 376
        Me.plProductHandlingRest.Text = "KremerLight3"
        Me.plProductHandlingRest.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'InMoldDrying
        '
        Me.InMoldDrying.BindControl = Me.txtImd
        Me.InMoldDrying.BindProperty = "Data"
        Me.InMoldDrying.Data = Nothing
        Me.InMoldDrying.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.InMoldDrying.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.InMoldDrying.VariableName = "MAIN.InMoldDrying.sCycleStateText"
        '
        'txtImd
        '
        Me.txtImd.Audit = Nothing
        Me.txtImd.AuditEnabled = False
        Me.txtImd.AuditMessage = "KremerTextField changed:"
        Me.txtImd.AuditSource = "KremerTextField"
        Me.txtImd.BackColor = System.Drawing.Color.White
        Me.txtImd.BackColorOn = System.Drawing.Color.Empty
        Me.txtImd.Data = "Text"
        Me.txtImd.ForeColor = System.Drawing.Color.Navy
        Me.txtImd.ForeColorOn = System.Drawing.Color.Empty
        Me.txtImd.InitialValue = True
        Me.txtImd.IOType = KremerControlsWin32.KremerTextField.IO_Type.Output
        Me.txtImd.Location = New System.Drawing.Point(176, 29)
        Me.txtImd.Name = "txtImd"
        Me.txtImd.PasswordMask = False
        Me.txtImd.Size = New System.Drawing.Size(240, 14)
        Me.txtImd.State = False
        Me.txtImd.TabIndex = 5
        Me.txtImd.Text = "Cycle State"
        Me.txtImd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtImd.UserInfo = Nothing
        Me.txtImd.UserLevel = 0
        '
        'BottomA
        '
        Me.BottomA.BindControl = Me.txtBottomMoldA
        Me.BottomA.BindProperty = "Data"
        Me.BottomA.Data = Nothing
        Me.BottomA.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.BottomA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BottomA.VariableName = "MAIN.InMoldDrying.BottomMoldA.sCycleStateText"
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
        Me.txtBottomMoldA.Location = New System.Drawing.Point(176, 44)
        Me.txtBottomMoldA.Name = "txtBottomMoldA"
        Me.txtBottomMoldA.PasswordMask = False
        Me.txtBottomMoldA.Size = New System.Drawing.Size(240, 14)
        Me.txtBottomMoldA.State = False
        Me.txtBottomMoldA.TabIndex = 6
        Me.txtBottomMoldA.Text = "Cycle State"
        Me.txtBottomMoldA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtBottomMoldA.UserInfo = Nothing
        Me.txtBottomMoldA.UserLevel = 0
        '
        'TopA
        '
        Me.TopA.BindControl = Me.txtTopMoldA
        Me.TopA.BindProperty = "Data"
        Me.TopA.Data = Nothing
        Me.TopA.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.TopA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TopA.VariableName = "MAIN.InMoldDrying.TopMoldA.sCycleStateText"
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
        Me.txtTopMoldA.Location = New System.Drawing.Point(176, 60)
        Me.txtTopMoldA.Name = "txtTopMoldA"
        Me.txtTopMoldA.PasswordMask = False
        Me.txtTopMoldA.Size = New System.Drawing.Size(240, 14)
        Me.txtTopMoldA.State = False
        Me.txtTopMoldA.TabIndex = 7
        Me.txtTopMoldA.Text = "Cycle State"
        Me.txtTopMoldA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtTopMoldA.UserInfo = Nothing
        Me.txtTopMoldA.UserLevel = 0
        '
        'TransferMold
        '
        Me.TransferMold.BindControl = Me.txtTransfermold
        Me.TransferMold.BindProperty = "Data"
        Me.TransferMold.Data = Nothing
        Me.TransferMold.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.TransferMold.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TransferMold.VariableName = "MAIN.InMoldDrying.TransferMold.sCycleStateText"
        '
        'txtTransfermold
        '
        Me.txtTransfermold.Audit = Nothing
        Me.txtTransfermold.AuditEnabled = False
        Me.txtTransfermold.AuditMessage = "KremerTextField changed:"
        Me.txtTransfermold.AuditSource = "KremerTextField"
        Me.txtTransfermold.BackColor = System.Drawing.Color.White
        Me.txtTransfermold.BackColorOn = System.Drawing.Color.Empty
        Me.txtTransfermold.Data = "Text"
        Me.txtTransfermold.ForeColor = System.Drawing.Color.Navy
        Me.txtTransfermold.ForeColorOn = System.Drawing.Color.Empty
        Me.txtTransfermold.InitialValue = True
        Me.txtTransfermold.IOType = KremerControlsWin32.KremerTextField.IO_Type.Output
        Me.txtTransfermold.Location = New System.Drawing.Point(176, 76)
        Me.txtTransfermold.Name = "txtTransfermold"
        Me.txtTransfermold.PasswordMask = False
        Me.txtTransfermold.Size = New System.Drawing.Size(240, 14)
        Me.txtTransfermold.State = False
        Me.txtTransfermold.TabIndex = 8
        Me.txtTransfermold.Text = "Cycle State"
        Me.txtTransfermold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtTransfermold.UserInfo = Nothing
        Me.txtTransfermold.UserLevel = 0
        '
        'MachinePond
        '
        Me.MachinePond.BindControl = Me.txtMachinePond
        Me.MachinePond.BindProperty = "Data"
        Me.MachinePond.Data = Nothing
        Me.MachinePond.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.MachinePond.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.MachinePond.VariableName = "MAIN.InMoldDrying.ProductForming.sCycleStateText"
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
        Me.txtMachinePond.Location = New System.Drawing.Point(176, 92)
        Me.txtMachinePond.Name = "txtMachinePond"
        Me.txtMachinePond.PasswordMask = False
        Me.txtMachinePond.Size = New System.Drawing.Size(240, 14)
        Me.txtMachinePond.State = False
        Me.txtMachinePond.TabIndex = 378
        Me.txtMachinePond.Text = "Cycle State"
        Me.txtMachinePond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtMachinePond.UserInfo = Nothing
        Me.txtMachinePond.UserLevel = 0
        '
        'BottomB
        '
        Me.BottomB.BindControl = Me.txtBottomMoldB
        Me.BottomB.BindProperty = "Data"
        Me.BottomB.Data = Nothing
        Me.BottomB.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.BottomB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BottomB.VariableName = "MAIN.InMoldDrying.BottomMoldB.sCycleStateText"
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
        Me.txtBottomMoldB.Location = New System.Drawing.Point(176, 108)
        Me.txtBottomMoldB.Name = "txtBottomMoldB"
        Me.txtBottomMoldB.PasswordMask = False
        Me.txtBottomMoldB.Size = New System.Drawing.Size(240, 14)
        Me.txtBottomMoldB.State = False
        Me.txtBottomMoldB.TabIndex = 9
        Me.txtBottomMoldB.Text = "Cycle State"
        Me.txtBottomMoldB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtBottomMoldB.UserInfo = Nothing
        Me.txtBottomMoldB.UserLevel = 0
        '
        'TopB
        '
        Me.TopB.BindControl = Me.txtTopMoldB
        Me.TopB.BindProperty = "Data"
        Me.TopB.Data = Nothing
        Me.TopB.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.TopB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TopB.VariableName = "MAIN.InMoldDrying.TopMoldB.sCycleStateText"
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
        Me.txtTopMoldB.Location = New System.Drawing.Point(176, 124)
        Me.txtTopMoldB.Name = "txtTopMoldB"
        Me.txtTopMoldB.PasswordMask = False
        Me.txtTopMoldB.Size = New System.Drawing.Size(240, 14)
        Me.txtTopMoldB.State = False
        Me.txtTopMoldB.TabIndex = 10
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
        Me.ProductHandling.VariableName = "MAIN.ProductHandling.sCycleStateText"
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
        Me.txtProductHandling.Location = New System.Drawing.Point(176, 140)
        Me.txtProductHandling.Name = "txtProductHandling"
        Me.txtProductHandling.PasswordMask = False
        Me.txtProductHandling.Size = New System.Drawing.Size(240, 14)
        Me.txtProductHandling.State = False
        Me.txtProductHandling.TabIndex = 17
        Me.txtProductHandling.Text = "Cycle State"
        Me.txtProductHandling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtProductHandling.UserInfo = Nothing
        Me.txtProductHandling.UserLevel = 0
        '
        'GantryA
        '
        Me.GantryA.BindControl = Me.txtGantryA
        Me.GantryA.BindProperty = "Data"
        Me.GantryA.Data = Nothing
        Me.GantryA.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.GantryA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GantryA.VariableName = "MAIN.ProductHandling.GantryA.sCycleStateText"
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
        Me.txtGantryA.Location = New System.Drawing.Point(176, 156)
        Me.txtGantryA.Name = "txtGantryA"
        Me.txtGantryA.PasswordMask = False
        Me.txtGantryA.Size = New System.Drawing.Size(240, 14)
        Me.txtGantryA.State = False
        Me.txtGantryA.TabIndex = 365
        Me.txtGantryA.Text = "Cycle State"
        Me.txtGantryA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtGantryA.UserInfo = Nothing
        Me.txtGantryA.UserLevel = 0
        '
        'GantryB
        '
        Me.GantryB.BindControl = Me.txtGantryB
        Me.GantryB.BindProperty = "Data"
        Me.GantryB.Data = Nothing
        Me.GantryB.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.GantryB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GantryB.VariableName = "MAIN.ProductHandling.GantryB.sCycleStateText"
        '
        'txtGantryB
        '
        Me.txtGantryB.Audit = Nothing
        Me.txtGantryB.AuditEnabled = False
        Me.txtGantryB.AuditMessage = "KremerTextField changed:"
        Me.txtGantryB.AuditSource = "KremerTextField"
        Me.txtGantryB.BackColor = System.Drawing.Color.White
        Me.txtGantryB.BackColorOn = System.Drawing.Color.Empty
        Me.txtGantryB.Data = "Text"
        Me.txtGantryB.ForeColor = System.Drawing.Color.Navy
        Me.txtGantryB.ForeColorOn = System.Drawing.Color.Empty
        Me.txtGantryB.InitialValue = True
        Me.txtGantryB.IOType = KremerControlsWin32.KremerTextField.IO_Type.Output
        Me.txtGantryB.Location = New System.Drawing.Point(176, 172)
        Me.txtGantryB.Name = "txtGantryB"
        Me.txtGantryB.PasswordMask = False
        Me.txtGantryB.Size = New System.Drawing.Size(240, 14)
        Me.txtGantryB.State = False
        Me.txtGantryB.TabIndex = 18
        Me.txtGantryB.Text = "Cycle State"
        Me.txtGantryB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtGantryB.UserInfo = Nothing
        Me.txtGantryB.UserLevel = 0
        '
        'ProductConveyor
        '
        Me.ProductConveyor.BindControl = Me.txtProductConveyor
        Me.ProductConveyor.BindProperty = "Data"
        Me.ProductConveyor.Data = Nothing
        Me.ProductConveyor.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.ProductConveyor.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ProductConveyor.VariableName = "MAIN.ProductHandling.OutfeedConveyor.sCycleStateText"
        '
        'txtProductConveyor
        '
        Me.txtProductConveyor.Audit = Nothing
        Me.txtProductConveyor.AuditEnabled = False
        Me.txtProductConveyor.AuditMessage = "KremerTextField changed:"
        Me.txtProductConveyor.AuditSource = "KremerTextField"
        Me.txtProductConveyor.BackColor = System.Drawing.Color.White
        Me.txtProductConveyor.BackColorOn = System.Drawing.Color.Empty
        Me.txtProductConveyor.Data = "Text"
        Me.txtProductConveyor.ForeColor = System.Drawing.Color.Navy
        Me.txtProductConveyor.ForeColorOn = System.Drawing.Color.Empty
        Me.txtProductConveyor.InitialValue = True
        Me.txtProductConveyor.IOType = KremerControlsWin32.KremerTextField.IO_Type.Output
        Me.txtProductConveyor.Location = New System.Drawing.Point(176, 188)
        Me.txtProductConveyor.Name = "txtProductConveyor"
        Me.txtProductConveyor.PasswordMask = False
        Me.txtProductConveyor.Size = New System.Drawing.Size(240, 14)
        Me.txtProductConveyor.State = False
        Me.txtProductConveyor.TabIndex = 20
        Me.txtProductConveyor.Text = "Cycle State"
        Me.txtProductConveyor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtProductConveyor.UserInfo = Nothing
        Me.txtProductConveyor.UserLevel = 0
        '
        'btnMasterReset
        '
        Me.btnMasterReset.Audit = Nothing
        Me.btnMasterReset.AuditEnabled = False
        Me.btnMasterReset.AuditMessage = "KremerPushButton pressed!"
        Me.btnMasterReset.AuditSource = "KremerPushButton"
        Me.btnMasterReset.BackColorOn = System.Drawing.Color.Blue
        Me.btnMasterReset.BackGroundImageOn = Nothing
        Me.btnMasterReset.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.btnMasterReset.Data = False
        Me.btnMasterReset.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnMasterReset.ForeColorOn = System.Drawing.Color.White
        Me.btnMasterReset.Location = New System.Drawing.Point(610, 330)
        Me.btnMasterReset.Name = "btnMasterReset"
        Me.btnMasterReset.Size = New System.Drawing.Size(170, 55)
        Me.btnMasterReset.State = False
        Me.btnMasterReset.StateIsData = True
        Me.btnMasterReset.StateText = New String() {Nothing, Nothing}
        Me.btnMasterReset.TabIndex = 320
        Me.btnMasterReset.Tag = "173"
        Me.btnMasterReset.Text = "Reset" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cycles"
        Me.btnMasterReset.UserInfo = Nothing
        Me.btnMasterReset.UserLevel = 500
        Me.btnMasterReset.UseStateText = False
        Me.btnMasterReset.UseVisualStyleBackColor = False
        '
        'btnEnableForcedInit
        '
        Me.btnEnableForcedInit.Audit = Nothing
        Me.btnEnableForcedInit.AuditEnabled = False
        Me.btnEnableForcedInit.AuditMessage = "KremerPushButton pressed!"
        Me.btnEnableForcedInit.AuditSource = "KremerPushButton"
        Me.btnEnableForcedInit.BackColorOn = System.Drawing.Color.Blue
        Me.btnEnableForcedInit.BackGroundImageOn = Nothing
        Me.btnEnableForcedInit.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.btnEnableForcedInit.Data = False
        Me.btnEnableForcedInit.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnEnableForcedInit.ForeColorOn = System.Drawing.Color.White
        Me.btnEnableForcedInit.Location = New System.Drawing.Point(434, 330)
        Me.btnEnableForcedInit.Name = "btnEnableForcedInit"
        Me.btnEnableForcedInit.Size = New System.Drawing.Size(170, 55)
        Me.btnEnableForcedInit.State = False
        Me.btnEnableForcedInit.StateIsData = True
        Me.btnEnableForcedInit.StateText = New String() {Nothing, Nothing}
        Me.btnEnableForcedInit.TabIndex = 343
        Me.btnEnableForcedInit.Tag = "172"
        Me.btnEnableForcedInit.Text = "Enable Forced Init"
        Me.btnEnableForcedInit.UserInfo = Nothing
        Me.btnEnableForcedInit.UserLevel = 500
        Me.btnEnableForcedInit.UseStateText = False
        Me.btnEnableForcedInit.UseVisualStyleBackColor = False
        '
        'tvInline
        '
        Me.tvInline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvInline.ForeColor = System.Drawing.Color.Navy
        Me.tvInline.FullRowSelect = True
        Me.tvInline.LineColor = System.Drawing.Color.Red
        Me.tvInline.Location = New System.Drawing.Point(2, 10)
        Me.tvInline.Name = "tvInline"
        TreeNode13.Checked = True
        TreeNode13.Name = "Node2"
        TreeNode13.Text = "Bottom mold A"
        TreeNode14.Checked = True
        TreeNode14.Name = "Node4"
        TreeNode14.Text = "Top Mold A"
        TreeNode15.Checked = True
        TreeNode15.Name = "Node5"
        TreeNode15.Text = "Transfer Mold"
        TreeNode16.Checked = True
        TreeNode16.Name = "Node7"
        TreeNode16.Text = "Product Forming"
        TreeNode17.Checked = True
        TreeNode17.Name = "Node9"
        TreeNode17.Text = "Bottom Mold B"
        TreeNode18.Checked = True
        TreeNode18.Name = "Node10"
        TreeNode18.Text = "Top Mold B"
        TreeNode19.Checked = True
        TreeNode19.Name = "Node1"
        TreeNode19.Text = "In Mold Drying"
        TreeNode20.Checked = True
        TreeNode20.Name = "Node13"
        TreeNode20.Text = "Gantry A"
        TreeNode21.Checked = True
        TreeNode21.Name = "Node15"
        TreeNode21.Text = "Gantry B"
        TreeNode22.Checked = True
        TreeNode22.Name = "Node16"
        TreeNode22.Text = "Product Conveyor"
        TreeNode23.Checked = True
        TreeNode23.Name = "Node12"
        TreeNode23.Text = "Product Handling"
        TreeNode24.Checked = True
        TreeNode24.Name = "Node0"
        TreeNode24.Text = "Machine"
        Me.tvInline.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode24})
        Me.tvInline.ShowPlusMinus = False
        Me.tvInline.ShowRootLines = False
        Me.tvInline.Size = New System.Drawing.Size(415, 375)
        Me.tvInline.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(300, 385)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 25)
        Me.Label7.TabIndex = 369
        Me.Label7.Text = "IMD in rest"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(409, 385)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(149, 25)
        Me.Label11.TabIndex = 377
        Me.Label11.Text = "Product handling in rest"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Sequence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtMachinePond)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.plProductHandlingRest)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.plInMoldDryingRest)
        Me.Controls.Add(Me.txtGantryA)
        Me.Controls.Add(Me.btnEnableForcedInit)
        Me.Controls.Add(Me.btnMasterReset)
        Me.Controls.Add(Me.txtProductConveyor)
        Me.Controls.Add(Me.txtGantryB)
        Me.Controls.Add(Me.txtProductHandling)
        Me.Controls.Add(Me.txtTopMoldB)
        Me.Controls.Add(Me.txtBottomMoldB)
        Me.Controls.Add(Me.txtTransfermold)
        Me.Controls.Add(Me.txtTopMoldA)
        Me.Controls.Add(Me.txtBottomMoldA)
        Me.Controls.Add(Me.txtImd)
        Me.Controls.Add(Me.tvInline)
        Me.Name = "Sequence"
        Me.Size = New System.Drawing.Size(800, 441)
        Me.Tag = "501"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents krConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents krVarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents tvInline As System.Windows.Forms.TreeView
    Friend WithEvents txtImd As KremerControlsWin32.KremerTextField
    Friend WithEvents txtBottomMoldA As KremerControlsWin32.KremerTextField
    Friend WithEvents txtTopMoldA As KremerControlsWin32.KremerTextField
    Friend WithEvents txtTransfermold As KremerControlsWin32.KremerTextField
    Friend WithEvents txtBottomMoldB As KremerControlsWin32.KremerTextField
    Friend WithEvents txtTopMoldB As KremerControlsWin32.KremerTextField
    Friend WithEvents txtProductHandling As KremerControlsWin32.KremerTextField
    Friend WithEvents txtGantryB As KremerControlsWin32.KremerTextField
    Friend WithEvents txtProductConveyor As KremerControlsWin32.KremerTextField
    Friend WithEvents btnMasterReset As KremerControlsWin32.KremerButton
    Friend WithEvents btnEnableForcedInit As KremerControlsWin32.KremerButton
    Friend WithEvents txtGantryA As KremerControlsWin32.KremerTextField
    Friend WithEvents plInMoldDryingRest As KremerControlsWin32.KremerLight
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents plProductHandlingRest As KremerControlsWin32.KremerLight
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents InMoldDrying As KremerControlsWin32.KremerVariable
    Friend WithEvents BottomA As KremerControlsWin32.KremerVariable
    Friend WithEvents TopA As KremerControlsWin32.KremerVariable
    Friend WithEvents TransferMold As KremerControlsWin32.KremerVariable
    Friend WithEvents MachinePond As KremerControlsWin32.KremerVariable
    Friend WithEvents BottomB As KremerControlsWin32.KremerVariable
    Friend WithEvents TopB As KremerControlsWin32.KremerVariable
    Friend WithEvents ProductHandling As KremerControlsWin32.KremerVariable
    Friend WithEvents GantryA As KremerControlsWin32.KremerVariable
    Friend WithEvents GantryB As KremerControlsWin32.KremerVariable
    Friend WithEvents ProductConveyor As KremerControlsWin32.KremerVariable
    Friend WithEvents txtMachinePond As KremerControlsWin32.KremerTextField
    Friend WithEvents IMD_inRest As KremerControlsWin32.KremerVariable
    Friend WithEvents PH_InRest As KremerControlsWin32.KremerVariable

End Class
