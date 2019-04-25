<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Product
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ioProductId = New KremerControlsWin32.KremerIoField(Me.components)
        Me.btnSave = New KremerControlsWin32.KremerButton()
        Me.btnLoad = New KremerControlsWin32.KremerButton()
        Me.btnSaveNew = New KremerControlsWin32.KremerButton()
        Me.krConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.krVarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.GTYABlowOffTime = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_GYABlowOff = New KremerControlsWin32.KremerIoField(Me.components)
        Me.GTYBBlowOffTime = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_GYBBlowOff = New KremerControlsWin32.KremerIoField(Me.components)
        Me.GYAVertPickUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_GYAVerticalPickup = New KremerControlsWin32.KremerIoField(Me.components)
        Me.GYAVertDropOff = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_GYAVerticalDropOff = New KremerControlsWin32.KremerIoField(Me.components)
        Me.GTYBVertDropOff = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_GYBVerticalDropOff = New KremerControlsWin32.KremerIoField(Me.components)
        Me.GTYBVertPickUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_GYBVerticalPickup = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TMDownStop = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TMDownStop = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TMDownOpen = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TMDownOpen = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TMTransferOpen = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TMOpen = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TMTransferStopA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TMTransferStopA = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TMTransferStopB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TMTransferStopB = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TopADownStop = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TopADownStop = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TopBDownStop = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TopBDownStop = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TopAOpen = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TopAOpen = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TopBOpen = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TopBOpen = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ReleaseToA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_ReleaseToBMA = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ReleaseToB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_ReleaseToBMB = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ioProductName = New KremerControlsWin32.KremerTextField(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Lable15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ioProductId
        '
        Me.ioProductId.Audit = Nothing
        Me.ioProductId.AuditEnabled = False
        Me.ioProductId.AuditMessage = "KremerIoField changed:"
        Me.ioProductId.AuditSource = "KremerIoField"
        Me.ioProductId.Data = 0R
        Me.ioProductId.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioProductId.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ioProductId.InitialValue = True
        Me.ioProductId.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.ioProductId.Location = New System.Drawing.Point(743, 4)
        Me.ioProductId.LowerBound = 0R
        Me.ioProductId.Name = "ioProductId"
        Me.ioProductId.OutputFormat = "0"
        Me.ioProductId.Size = New System.Drawing.Size(43, 18)
        Me.ioProductId.TabIndex = 166
        Me.ioProductId.Text = "0"
        Me.ioProductId.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.ioProductId.UpperBound = 1000.0R
        Me.ioProductId.UserInfo = Nothing
        Me.ioProductId.UserLevel = 0
        Me.ioProductId.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Audit = Nothing
        Me.btnSave.AuditEnabled = False
        Me.btnSave.AuditMessage = "KremerPushButton pressed!"
        Me.btnSave.AuditSource = "KremerPushButton"
        Me.btnSave.BackColorOn = System.Drawing.Color.Empty
        Me.btnSave.BackGroundImageOn = Nothing
        Me.btnSave.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.btnSave.Data = False
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColorOn = System.Drawing.Color.Empty
        Me.btnSave.Location = New System.Drawing.Point(594, 390)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 48)
        Me.btnSave.State = False
        Me.btnSave.StateIsData = True
        Me.btnSave.StateText = New String() {Nothing, Nothing}
        Me.btnSave.TabIndex = 116
        Me.btnSave.Tag = "40"
        Me.btnSave.Text = "Save"
        Me.btnSave.UserInfo = Nothing
        Me.btnSave.UserLevel = 0
        Me.btnSave.UseStateText = False
        '
        'btnLoad
        '
        Me.btnLoad.Audit = Nothing
        Me.btnLoad.AuditEnabled = False
        Me.btnLoad.AuditMessage = "KremerPushButton pressed!"
        Me.btnLoad.AuditSource = "KremerPushButton"
        Me.btnLoad.BackColorOn = System.Drawing.Color.Empty
        Me.btnLoad.BackGroundImageOn = Nothing
        Me.btnLoad.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.btnLoad.Data = False
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLoad.ForeColorOn = System.Drawing.Color.Empty
        Me.btnLoad.Location = New System.Drawing.Point(495, 390)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(100, 48)
        Me.btnLoad.State = False
        Me.btnLoad.StateIsData = True
        Me.btnLoad.StateText = New String() {Nothing, Nothing}
        Me.btnLoad.TabIndex = 115
        Me.btnLoad.Tag = "38"
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UserInfo = Nothing
        Me.btnLoad.UserLevel = 0
        Me.btnLoad.UseStateText = False
        '
        'btnSaveNew
        '
        Me.btnSaveNew.Audit = Nothing
        Me.btnSaveNew.AuditEnabled = False
        Me.btnSaveNew.AuditMessage = "KremerPushButton pressed!"
        Me.btnSaveNew.AuditSource = "KremerPushButton"
        Me.btnSaveNew.BackColorOn = System.Drawing.Color.Empty
        Me.btnSaveNew.BackGroundImageOn = Nothing
        Me.btnSaveNew.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.btnSaveNew.Data = False
        Me.btnSaveNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveNew.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveNew.ForeColorOn = System.Drawing.Color.Empty
        Me.btnSaveNew.Location = New System.Drawing.Point(693, 390)
        Me.btnSaveNew.Name = "btnSaveNew"
        Me.btnSaveNew.Size = New System.Drawing.Size(100, 48)
        Me.btnSaveNew.State = False
        Me.btnSaveNew.StateIsData = True
        Me.btnSaveNew.StateText = New String() {Nothing, Nothing}
        Me.btnSaveNew.TabIndex = 162
        Me.btnSaveNew.Tag = "62"
        Me.btnSaveNew.Text = "Save as New"
        Me.btnSaveNew.UserInfo = Nothing
        Me.btnSaveNew.UserLevel = 0
        Me.btnSaveNew.UseStateText = False
        '
        'krConnector
        '
        Me.krConnector.VarCollector = Nothing
        '
        'krVarCollector
        '
        Me.krVarCollector.Variables.Add(Me.GTYABlowOffTime)
        Me.krVarCollector.Variables.Add(Me.GTYBBlowOffTime)
        Me.krVarCollector.Variables.Add(Me.GYAVertPickUp)
        Me.krVarCollector.Variables.Add(Me.GYAVertDropOff)
        Me.krVarCollector.Variables.Add(Me.GTYBVertDropOff)
        Me.krVarCollector.Variables.Add(Me.GTYBVertPickUp)
        Me.krVarCollector.Variables.Add(Me.TMDownStop)
        Me.krVarCollector.Variables.Add(Me.TMDownOpen)
        Me.krVarCollector.Variables.Add(Me.TMTransferOpen)
        Me.krVarCollector.Variables.Add(Me.TMTransferStopA)
        Me.krVarCollector.Variables.Add(Me.TMTransferStopB)
        Me.krVarCollector.Variables.Add(Me.TopADownStop)
        Me.krVarCollector.Variables.Add(Me.TopBDownStop)
        Me.krVarCollector.Variables.Add(Me.TopAOpen)
        Me.krVarCollector.Variables.Add(Me.TopBOpen)
        Me.krVarCollector.Variables.Add(Me.ReleaseToA)
        Me.krVarCollector.Variables.Add(Me.ReleaseToB)
        '
        'GTYABlowOffTime
        '
        Me.GTYABlowOffTime.BindControl = Me.IO_GYABlowOff
        Me.GTYABlowOffTime.BindProperty = "Data"
        Me.GTYABlowOffTime.Data = Nothing
        Me.GTYABlowOffTime.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.GTYABlowOffTime.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GTYABlowOffTime.VariableName = "MAIN.ProductPar.ProductHandling.GantryA.BlowOffTime"
        '
        'IO_GYABlowOff
        '
        Me.IO_GYABlowOff.Audit = Nothing
        Me.IO_GYABlowOff.AuditEnabled = False
        Me.IO_GYABlowOff.AuditMessage = "KremerIoField changed:"
        Me.IO_GYABlowOff.AuditSource = "KremerIoField"
        Me.IO_GYABlowOff.BackColor = System.Drawing.Color.White
        Me.IO_GYABlowOff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO_GYABlowOff.Data = 0R
        Me.IO_GYABlowOff.DataType = KremerControlsWin32.KremerIoField.NumDataType.DINT
        Me.IO_GYABlowOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IO_GYABlowOff.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_GYABlowOff.InitialValue = True
        Me.IO_GYABlowOff.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_GYABlowOff.Location = New System.Drawing.Point(697, 90)
        Me.IO_GYABlowOff.LowerBound = -5000.0R
        Me.IO_GYABlowOff.Name = "IO_GYABlowOff"
        Me.IO_GYABlowOff.OutputFormat = "0 ms"
        Me.IO_GYABlowOff.Size = New System.Drawing.Size(100, 24)
        Me.IO_GYABlowOff.TabIndex = 389
        Me.IO_GYABlowOff.Tag = "449"
        Me.IO_GYABlowOff.Text = "0 ms"
        Me.IO_GYABlowOff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_GYABlowOff.UpperBound = 5000.0R
        Me.IO_GYABlowOff.UserInfo = Nothing
        Me.IO_GYABlowOff.UserLevel = 0
        '
        'GTYBBlowOffTime
        '
        Me.GTYBBlowOffTime.BindControl = Me.IO_GYBBlowOff
        Me.GTYBBlowOffTime.BindProperty = "Data"
        Me.GTYBBlowOffTime.Data = Nothing
        Me.GTYBBlowOffTime.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.GTYBBlowOffTime.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GTYBBlowOffTime.VariableName = "MAIN.ProductPar.ProductHandling.GantryB.BlowOffTime"
        '
        'IO_GYBBlowOff
        '
        Me.IO_GYBBlowOff.Audit = Nothing
        Me.IO_GYBBlowOff.AuditEnabled = False
        Me.IO_GYBBlowOff.AuditMessage = "KremerIoField changed:"
        Me.IO_GYBBlowOff.AuditSource = "KremerIoField"
        Me.IO_GYBBlowOff.BackColor = System.Drawing.Color.White
        Me.IO_GYBBlowOff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO_GYBBlowOff.Data = 0R
        Me.IO_GYBBlowOff.DataType = KremerControlsWin32.KremerIoField.NumDataType.DINT
        Me.IO_GYBBlowOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IO_GYBBlowOff.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_GYBBlowOff.InitialValue = True
        Me.IO_GYBBlowOff.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_GYBBlowOff.Location = New System.Drawing.Point(696, 185)
        Me.IO_GYBBlowOff.LowerBound = -5000.0R
        Me.IO_GYBBlowOff.Name = "IO_GYBBlowOff"
        Me.IO_GYBBlowOff.OutputFormat = "0 ms"
        Me.IO_GYBBlowOff.Size = New System.Drawing.Size(100, 24)
        Me.IO_GYBBlowOff.TabIndex = 391
        Me.IO_GYBBlowOff.Tag = "450"
        Me.IO_GYBBlowOff.Text = "0 ms"
        Me.IO_GYBBlowOff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_GYBBlowOff.UpperBound = 5000.0R
        Me.IO_GYBBlowOff.UserInfo = Nothing
        Me.IO_GYBBlowOff.UserLevel = 0
        '
        'GYAVertPickUp
        '
        Me.GYAVertPickUp.BindControl = Me.IO_GYAVerticalPickup
        Me.GYAVertPickUp.BindProperty = "Data"
        Me.GYAVertPickUp.Data = Nothing
        Me.GYAVertPickUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.GYAVertPickUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GYAVertPickUp.VariableName = "MAIN.ProductPar.ProductHandling.GantryA.PositionVerticalPickup"
        '
        'IO_GYAVerticalPickup
        '
        Me.IO_GYAVerticalPickup.Audit = Nothing
        Me.IO_GYAVerticalPickup.AuditEnabled = False
        Me.IO_GYAVerticalPickup.AuditMessage = "KremerIoField changed:"
        Me.IO_GYAVerticalPickup.AuditSource = "KremerIoField"
        Me.IO_GYAVerticalPickup.BackColor = System.Drawing.Color.White
        Me.IO_GYAVerticalPickup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO_GYAVerticalPickup.Data = 0R
        Me.IO_GYAVerticalPickup.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_GYAVerticalPickup.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_GYAVerticalPickup.InitialValue = True
        Me.IO_GYAVerticalPickup.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_GYAVerticalPickup.Location = New System.Drawing.Point(697, 45)
        Me.IO_GYAVerticalPickup.LowerBound = -5000.0R
        Me.IO_GYAVerticalPickup.Name = "IO_GYAVerticalPickup"
        Me.IO_GYAVerticalPickup.OutputFormat = "0.0 mm"
        Me.IO_GYAVerticalPickup.Size = New System.Drawing.Size(100, 24)
        Me.IO_GYAVerticalPickup.TabIndex = 371
        Me.IO_GYAVerticalPickup.Text = "0.0 mm"
        Me.IO_GYAVerticalPickup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_GYAVerticalPickup.UpperBound = 5000.0R
        Me.IO_GYAVerticalPickup.UserInfo = Nothing
        Me.IO_GYAVerticalPickup.UserLevel = 0
        '
        'GYAVertDropOff
        '
        Me.GYAVertDropOff.BindControl = Me.IO_GYAVerticalDropOff
        Me.GYAVertDropOff.BindProperty = "Data"
        Me.GYAVertDropOff.Data = Nothing
        Me.GYAVertDropOff.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.GYAVertDropOff.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GYAVertDropOff.VariableName = "MAIN.ProductPar.ProductHandling.GantryA.PositionVerticalDropOff"
        '
        'IO_GYAVerticalDropOff
        '
        Me.IO_GYAVerticalDropOff.Audit = Nothing
        Me.IO_GYAVerticalDropOff.AuditEnabled = False
        Me.IO_GYAVerticalDropOff.AuditMessage = "KremerIoField changed:"
        Me.IO_GYAVerticalDropOff.AuditSource = "KremerIoField"
        Me.IO_GYAVerticalDropOff.BackColor = System.Drawing.Color.White
        Me.IO_GYAVerticalDropOff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO_GYAVerticalDropOff.Data = 0R
        Me.IO_GYAVerticalDropOff.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_GYAVerticalDropOff.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_GYAVerticalDropOff.InitialValue = True
        Me.IO_GYAVerticalDropOff.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_GYAVerticalDropOff.Location = New System.Drawing.Point(697, 67)
        Me.IO_GYAVerticalDropOff.LowerBound = -5000.0R
        Me.IO_GYAVerticalDropOff.Name = "IO_GYAVerticalDropOff"
        Me.IO_GYAVerticalDropOff.OutputFormat = "0.0 mm"
        Me.IO_GYAVerticalDropOff.Size = New System.Drawing.Size(100, 24)
        Me.IO_GYAVerticalDropOff.TabIndex = 373
        Me.IO_GYAVerticalDropOff.Text = "0.0 mm"
        Me.IO_GYAVerticalDropOff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_GYAVerticalDropOff.UpperBound = 5000.0R
        Me.IO_GYAVerticalDropOff.UserInfo = Nothing
        Me.IO_GYAVerticalDropOff.UserLevel = 0
        '
        'GTYBVertDropOff
        '
        Me.GTYBVertDropOff.BindControl = Me.IO_GYBVerticalDropOff
        Me.GTYBVertDropOff.BindProperty = "Data"
        Me.GTYBVertDropOff.Data = Nothing
        Me.GTYBVertDropOff.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.GTYBVertDropOff.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GTYBVertDropOff.VariableName = "MAIN.ProductPar.ProductHandling.GantryB.PositionVerticalDropOff"
        '
        'IO_GYBVerticalDropOff
        '
        Me.IO_GYBVerticalDropOff.Audit = Nothing
        Me.IO_GYBVerticalDropOff.AuditEnabled = False
        Me.IO_GYBVerticalDropOff.AuditMessage = "KremerIoField changed:"
        Me.IO_GYBVerticalDropOff.AuditSource = "KremerIoField"
        Me.IO_GYBVerticalDropOff.BackColor = System.Drawing.Color.White
        Me.IO_GYBVerticalDropOff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO_GYBVerticalDropOff.Data = 0R
        Me.IO_GYBVerticalDropOff.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_GYBVerticalDropOff.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_GYBVerticalDropOff.InitialValue = True
        Me.IO_GYBVerticalDropOff.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_GYBVerticalDropOff.Location = New System.Drawing.Point(696, 162)
        Me.IO_GYBVerticalDropOff.LowerBound = -5000.0R
        Me.IO_GYBVerticalDropOff.Name = "IO_GYBVerticalDropOff"
        Me.IO_GYBVerticalDropOff.OutputFormat = "0.0 mm"
        Me.IO_GYBVerticalDropOff.Size = New System.Drawing.Size(100, 24)
        Me.IO_GYBVerticalDropOff.TabIndex = 375
        Me.IO_GYBVerticalDropOff.Text = "0.0 mm"
        Me.IO_GYBVerticalDropOff.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_GYBVerticalDropOff.UpperBound = 5000.0R
        Me.IO_GYBVerticalDropOff.UserInfo = Nothing
        Me.IO_GYBVerticalDropOff.UserLevel = 0
        '
        'GTYBVertPickUp
        '
        Me.GTYBVertPickUp.BindControl = Me.IO_GYBVerticalPickup
        Me.GTYBVertPickUp.BindProperty = "Data"
        Me.GTYBVertPickUp.Data = Nothing
        Me.GTYBVertPickUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.GTYBVertPickUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GTYBVertPickUp.VariableName = "MAIN.ProductPar.ProductHandling.GantryB.PositionVerticalPickup"
        '
        'IO_GYBVerticalPickup
        '
        Me.IO_GYBVerticalPickup.Audit = Nothing
        Me.IO_GYBVerticalPickup.AuditEnabled = False
        Me.IO_GYBVerticalPickup.AuditMessage = "KremerIoField changed:"
        Me.IO_GYBVerticalPickup.AuditSource = "KremerIoField"
        Me.IO_GYBVerticalPickup.BackColor = System.Drawing.Color.White
        Me.IO_GYBVerticalPickup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO_GYBVerticalPickup.Data = 0R
        Me.IO_GYBVerticalPickup.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_GYBVerticalPickup.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_GYBVerticalPickup.InitialValue = True
        Me.IO_GYBVerticalPickup.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_GYBVerticalPickup.Location = New System.Drawing.Point(696, 139)
        Me.IO_GYBVerticalPickup.LowerBound = -5000.0R
        Me.IO_GYBVerticalPickup.Name = "IO_GYBVerticalPickup"
        Me.IO_GYBVerticalPickup.OutputFormat = "0.0 mm"
        Me.IO_GYBVerticalPickup.Size = New System.Drawing.Size(100, 24)
        Me.IO_GYBVerticalPickup.TabIndex = 377
        Me.IO_GYBVerticalPickup.Text = "0.0 mm"
        Me.IO_GYBVerticalPickup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_GYBVerticalPickup.UpperBound = 5000.0R
        Me.IO_GYBVerticalPickup.UserInfo = Nothing
        Me.IO_GYBVerticalPickup.UserLevel = 0
        '
        'TMDownStop
        '
        Me.TMDownStop.BindControl = Me.IO_TMDownStop
        Me.TMDownStop.BindProperty = "Data"
        Me.TMDownStop.Data = Nothing
        Me.TMDownStop.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.TMDownStop.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMDownStop.VariableName = "MAIN.InMoldDrying.ProdParameters.TransferMold.PositionDownStop"
        '
        'IO_TMDownStop
        '
        Me.IO_TMDownStop.Audit = Nothing
        Me.IO_TMDownStop.AuditEnabled = False
        Me.IO_TMDownStop.AuditMessage = "KremerIoField changed:"
        Me.IO_TMDownStop.AuditSource = "KremerIoField"
        Me.IO_TMDownStop.BackColor = System.Drawing.Color.White
        Me.IO_TMDownStop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO_TMDownStop.Data = 0R
        Me.IO_TMDownStop.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TMDownStop.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TMDownStop.InitialValue = True
        Me.IO_TMDownStop.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TMDownStop.Location = New System.Drawing.Point(293, 45)
        Me.IO_TMDownStop.LowerBound = -5000.0R
        Me.IO_TMDownStop.Name = "IO_TMDownStop"
        Me.IO_TMDownStop.OutputFormat = "0.0 mm"
        Me.IO_TMDownStop.Size = New System.Drawing.Size(100, 24)
        Me.IO_TMDownStop.TabIndex = 398
        Me.IO_TMDownStop.Text = "0.0 mm"
        Me.IO_TMDownStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TMDownStop.UpperBound = 5000.0R
        Me.IO_TMDownStop.UserInfo = Nothing
        Me.IO_TMDownStop.UserLevel = 0
        '
        'TMDownOpen
        '
        Me.TMDownOpen.BindControl = Me.IO_TMDownOpen
        Me.TMDownOpen.BindProperty = "Data"
        Me.TMDownOpen.Data = Nothing
        Me.TMDownOpen.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.TMDownOpen.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMDownOpen.VariableName = "MAIN.InMoldDrying.ProdParameters.TransferMold.PositionDownOpen"
        '
        'IO_TMDownOpen
        '
        Me.IO_TMDownOpen.Audit = Nothing
        Me.IO_TMDownOpen.AuditEnabled = False
        Me.IO_TMDownOpen.AuditMessage = "KremerIoField changed:"
        Me.IO_TMDownOpen.AuditSource = "KremerIoField"
        Me.IO_TMDownOpen.BackColor = System.Drawing.Color.White
        Me.IO_TMDownOpen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO_TMDownOpen.Data = 0R
        Me.IO_TMDownOpen.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TMDownOpen.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TMDownOpen.InitialValue = True
        Me.IO_TMDownOpen.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TMDownOpen.Location = New System.Drawing.Point(293, 68)
        Me.IO_TMDownOpen.LowerBound = -5000.0R
        Me.IO_TMDownOpen.Name = "IO_TMDownOpen"
        Me.IO_TMDownOpen.OutputFormat = "0.0 mm"
        Me.IO_TMDownOpen.Size = New System.Drawing.Size(100, 24)
        Me.IO_TMDownOpen.TabIndex = 397
        Me.IO_TMDownOpen.Text = "0.0 mm"
        Me.IO_TMDownOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TMDownOpen.UpperBound = 5000.0R
        Me.IO_TMDownOpen.UserInfo = Nothing
        Me.IO_TMDownOpen.UserLevel = 0
        '
        'TMTransferOpen
        '
        Me.TMTransferOpen.BindControl = Me.IO_TMOpen
        Me.TMTransferOpen.BindProperty = "Data"
        Me.TMTransferOpen.Data = Nothing
        Me.TMTransferOpen.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.TMTransferOpen.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMTransferOpen.VariableName = "MAIN.InMoldDrying.ProdParameters.TransferMold.PositionTransferOpen"
        '
        'IO_TMOpen
        '
        Me.IO_TMOpen.Audit = Nothing
        Me.IO_TMOpen.AuditEnabled = False
        Me.IO_TMOpen.AuditMessage = "KremerIoField changed:"
        Me.IO_TMOpen.AuditSource = "KremerIoField"
        Me.IO_TMOpen.BackColor = System.Drawing.Color.White
        Me.IO_TMOpen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO_TMOpen.Data = 0R
        Me.IO_TMOpen.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TMOpen.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TMOpen.InitialValue = True
        Me.IO_TMOpen.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TMOpen.Location = New System.Drawing.Point(294, 110)
        Me.IO_TMOpen.LowerBound = -5000.0R
        Me.IO_TMOpen.Name = "IO_TMOpen"
        Me.IO_TMOpen.OutputFormat = "0.0 mm"
        Me.IO_TMOpen.Size = New System.Drawing.Size(100, 24)
        Me.IO_TMOpen.TabIndex = 394
        Me.IO_TMOpen.Text = "0.0 mm"
        Me.IO_TMOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TMOpen.UpperBound = 5000.0R
        Me.IO_TMOpen.UserInfo = Nothing
        Me.IO_TMOpen.UserLevel = 0
        '
        'TMTransferStopA
        '
        Me.TMTransferStopA.BindControl = Me.IO_TMTransferStopA
        Me.TMTransferStopA.BindProperty = "Data"
        Me.TMTransferStopA.Data = Nothing
        Me.TMTransferStopA.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.TMTransferStopA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMTransferStopA.VariableName = "MAIN.InMoldDrying.ProdParameters.TransferMold.PositionTransferStopA"
        '
        'IO_TMTransferStopA
        '
        Me.IO_TMTransferStopA.Audit = Nothing
        Me.IO_TMTransferStopA.AuditEnabled = False
        Me.IO_TMTransferStopA.AuditMessage = "KremerIoField changed:"
        Me.IO_TMTransferStopA.AuditSource = "KremerIoField"
        Me.IO_TMTransferStopA.BackColor = System.Drawing.Color.White
        Me.IO_TMTransferStopA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO_TMTransferStopA.Data = 0R
        Me.IO_TMTransferStopA.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TMTransferStopA.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TMTransferStopA.InitialValue = True
        Me.IO_TMTransferStopA.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TMTransferStopA.Location = New System.Drawing.Point(294, 133)
        Me.IO_TMTransferStopA.LowerBound = -5000.0R
        Me.IO_TMTransferStopA.Name = "IO_TMTransferStopA"
        Me.IO_TMTransferStopA.OutputFormat = "0.0 mm"
        Me.IO_TMTransferStopA.Size = New System.Drawing.Size(100, 24)
        Me.IO_TMTransferStopA.TabIndex = 393
        Me.IO_TMTransferStopA.Text = "0.0 mm"
        Me.IO_TMTransferStopA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TMTransferStopA.UpperBound = 5000.0R
        Me.IO_TMTransferStopA.UserInfo = Nothing
        Me.IO_TMTransferStopA.UserLevel = 0
        '
        'TMTransferStopB
        '
        Me.TMTransferStopB.BindControl = Me.IO_TMTransferStopB
        Me.TMTransferStopB.BindProperty = "Data"
        Me.TMTransferStopB.Data = Nothing
        Me.TMTransferStopB.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.TMTransferStopB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMTransferStopB.VariableName = "MAIN.InMoldDrying.ProdParameters.TransferMold.PositionTransferStopB"
        '
        'IO_TMTransferStopB
        '
        Me.IO_TMTransferStopB.Audit = Nothing
        Me.IO_TMTransferStopB.AuditEnabled = False
        Me.IO_TMTransferStopB.AuditMessage = "KremerIoField changed:"
        Me.IO_TMTransferStopB.AuditSource = "KremerIoField"
        Me.IO_TMTransferStopB.BackColor = System.Drawing.Color.White
        Me.IO_TMTransferStopB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO_TMTransferStopB.Data = 0R
        Me.IO_TMTransferStopB.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TMTransferStopB.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TMTransferStopB.InitialValue = True
        Me.IO_TMTransferStopB.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TMTransferStopB.Location = New System.Drawing.Point(294, 156)
        Me.IO_TMTransferStopB.LowerBound = -5000.0R
        Me.IO_TMTransferStopB.Name = "IO_TMTransferStopB"
        Me.IO_TMTransferStopB.OutputFormat = "0.0 mm"
        Me.IO_TMTransferStopB.Size = New System.Drawing.Size(100, 24)
        Me.IO_TMTransferStopB.TabIndex = 395
        Me.IO_TMTransferStopB.Text = "0.0 mm"
        Me.IO_TMTransferStopB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TMTransferStopB.UpperBound = 5000.0R
        Me.IO_TMTransferStopB.UserInfo = Nothing
        Me.IO_TMTransferStopB.UserLevel = 0
        '
        'TopADownStop
        '
        Me.TopADownStop.BindControl = Me.IO_TopADownStop
        Me.TopADownStop.BindProperty = "Data"
        Me.TopADownStop.Data = Nothing
        Me.TopADownStop.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.TopADownStop.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TopADownStop.VariableName = "MAIN.InMoldDrying.ProdParameters.TopMoldA.PositionDownStop"
        '
        'IO_TopADownStop
        '
        Me.IO_TopADownStop.Audit = Nothing
        Me.IO_TopADownStop.AuditEnabled = False
        Me.IO_TopADownStop.AuditMessage = "KremerIoField changed:"
        Me.IO_TopADownStop.AuditSource = "KremerIoField"
        Me.IO_TopADownStop.BackColor = System.Drawing.Color.White
        Me.IO_TopADownStop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO_TopADownStop.Data = 0R
        Me.IO_TopADownStop.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TopADownStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IO_TopADownStop.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TopADownStop.InitialValue = True
        Me.IO_TopADownStop.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TopADownStop.Location = New System.Drawing.Point(294, 244)
        Me.IO_TopADownStop.LowerBound = -5000.0R
        Me.IO_TopADownStop.Name = "IO_TopADownStop"
        Me.IO_TopADownStop.OutputFormat = "0.0 mm"
        Me.IO_TopADownStop.Size = New System.Drawing.Size(100, 24)
        Me.IO_TopADownStop.TabIndex = 264
        Me.IO_TopADownStop.Text = "0.0 mm"
        Me.IO_TopADownStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TopADownStop.UpperBound = 5000.0R
        Me.IO_TopADownStop.UserInfo = Nothing
        Me.IO_TopADownStop.UserLevel = 0
        '
        'TopBDownStop
        '
        Me.TopBDownStop.BindControl = Me.IO_TopBDownStop
        Me.TopBDownStop.BindProperty = "Data"
        Me.TopBDownStop.Data = Nothing
        Me.TopBDownStop.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.TopBDownStop.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TopBDownStop.VariableName = "MAIN.InMoldDrying.ProdParameters.TopMoldB.PositionDownStop"
        '
        'IO_TopBDownStop
        '
        Me.IO_TopBDownStop.Audit = Nothing
        Me.IO_TopBDownStop.AuditEnabled = False
        Me.IO_TopBDownStop.AuditMessage = "KremerIoField changed:"
        Me.IO_TopBDownStop.AuditSource = "KremerIoField"
        Me.IO_TopBDownStop.BackColor = System.Drawing.Color.White
        Me.IO_TopBDownStop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO_TopBDownStop.Data = 0R
        Me.IO_TopBDownStop.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TopBDownStop.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TopBDownStop.InitialValue = True
        Me.IO_TopBDownStop.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TopBDownStop.Location = New System.Drawing.Point(294, 267)
        Me.IO_TopBDownStop.LowerBound = -5000.0R
        Me.IO_TopBDownStop.Name = "IO_TopBDownStop"
        Me.IO_TopBDownStop.OutputFormat = "0.0 mm"
        Me.IO_TopBDownStop.Size = New System.Drawing.Size(100, 24)
        Me.IO_TopBDownStop.TabIndex = 354
        Me.IO_TopBDownStop.Text = "0.0 mm"
        Me.IO_TopBDownStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TopBDownStop.UpperBound = 5000.0R
        Me.IO_TopBDownStop.UserInfo = Nothing
        Me.IO_TopBDownStop.UserLevel = 0
        '
        'TopAOpen
        '
        Me.TopAOpen.BindControl = Me.IO_TopAOpen
        Me.TopAOpen.BindProperty = "Data"
        Me.TopAOpen.Data = Nothing
        Me.TopAOpen.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.TopAOpen.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TopAOpen.VariableName = "MAIN.InMoldDrying.TopMoldA.ProdParameters.PositionDownOpen"
        '
        'IO_TopAOpen
        '
        Me.IO_TopAOpen.Audit = Nothing
        Me.IO_TopAOpen.AuditEnabled = False
        Me.IO_TopAOpen.AuditMessage = "KremerIoField changed:"
        Me.IO_TopAOpen.AuditSource = "KremerIoField"
        Me.IO_TopAOpen.BackColor = System.Drawing.Color.White
        Me.IO_TopAOpen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO_TopAOpen.Data = 0R
        Me.IO_TopAOpen.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TopAOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IO_TopAOpen.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TopAOpen.InitialValue = True
        Me.IO_TopAOpen.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TopAOpen.Location = New System.Drawing.Point(294, 290)
        Me.IO_TopAOpen.LowerBound = -5000.0R
        Me.IO_TopAOpen.Name = "IO_TopAOpen"
        Me.IO_TopAOpen.OutputFormat = "0.0 mm"
        Me.IO_TopAOpen.Size = New System.Drawing.Size(100, 24)
        Me.IO_TopAOpen.TabIndex = 438
        Me.IO_TopAOpen.Text = "0.0 mm"
        Me.IO_TopAOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TopAOpen.UpperBound = 5000.0R
        Me.IO_TopAOpen.UserInfo = Nothing
        Me.IO_TopAOpen.UserLevel = 0
        '
        'TopBOpen
        '
        Me.TopBOpen.BindControl = Me.IO_TopBOpen
        Me.TopBOpen.BindProperty = "Data"
        Me.TopBOpen.Data = Nothing
        Me.TopBOpen.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.TopBOpen.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TopBOpen.VariableName = "MAIN.InMoldDrying.TopMoldB.ProdParameters.PositionDownOpen"
        '
        'IO_TopBOpen
        '
        Me.IO_TopBOpen.Audit = Nothing
        Me.IO_TopBOpen.AuditEnabled = False
        Me.IO_TopBOpen.AuditMessage = "KremerIoField changed:"
        Me.IO_TopBOpen.AuditSource = "KremerIoField"
        Me.IO_TopBOpen.BackColor = System.Drawing.Color.White
        Me.IO_TopBOpen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO_TopBOpen.Data = 0R
        Me.IO_TopBOpen.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TopBOpen.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TopBOpen.InitialValue = True
        Me.IO_TopBOpen.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TopBOpen.Location = New System.Drawing.Point(294, 313)
        Me.IO_TopBOpen.LowerBound = -5000.0R
        Me.IO_TopBOpen.Name = "IO_TopBOpen"
        Me.IO_TopBOpen.OutputFormat = "0.0 mm"
        Me.IO_TopBOpen.Size = New System.Drawing.Size(100, 24)
        Me.IO_TopBOpen.TabIndex = 439
        Me.IO_TopBOpen.Text = "0.0 mm"
        Me.IO_TopBOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TopBOpen.UpperBound = 5000.0R
        Me.IO_TopBOpen.UserInfo = Nothing
        Me.IO_TopBOpen.UserLevel = 0
        '
        'ReleaseToA
        '
        Me.ReleaseToA.BindControl = Me.IO_ReleaseToBMA
        Me.ReleaseToA.BindProperty = "Data"
        Me.ReleaseToA.Data = Nothing
        Me.ReleaseToA.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.ReleaseToA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ReleaseToA.VariableName = "MAIN.InMoldDrying.TransferMold.ProdParameters.ReleaseBmMovementOffset"
        '
        'IO_ReleaseToBMA
        '
        Me.IO_ReleaseToBMA.Audit = Nothing
        Me.IO_ReleaseToBMA.AuditEnabled = False
        Me.IO_ReleaseToBMA.AuditMessage = "KremerIoField changed:"
        Me.IO_ReleaseToBMA.AuditSource = "KremerIoField"
        Me.IO_ReleaseToBMA.BackColor = System.Drawing.Color.White
        Me.IO_ReleaseToBMA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO_ReleaseToBMA.Data = 0R
        Me.IO_ReleaseToBMA.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_ReleaseToBMA.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_ReleaseToBMA.InitialValue = True
        Me.IO_ReleaseToBMA.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_ReleaseToBMA.Location = New System.Drawing.Point(294, 179)
        Me.IO_ReleaseToBMA.LowerBound = -5000.0R
        Me.IO_ReleaseToBMA.Name = "IO_ReleaseToBMA"
        Me.IO_ReleaseToBMA.OutputFormat = "0.0 mm"
        Me.IO_ReleaseToBMA.Size = New System.Drawing.Size(100, 24)
        Me.IO_ReleaseToBMA.TabIndex = 442
        Me.IO_ReleaseToBMA.Text = "0.0 mm"
        Me.IO_ReleaseToBMA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_ReleaseToBMA.UpperBound = 5000.0R
        Me.IO_ReleaseToBMA.UserInfo = Nothing
        Me.IO_ReleaseToBMA.UserLevel = 0
        '
        'ReleaseToB
        '
        Me.ReleaseToB.BindControl = Me.IO_ReleaseToBMB
        Me.ReleaseToB.BindProperty = "Data"
        Me.ReleaseToB.Data = Nothing
        Me.ReleaseToB.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.ReleaseToB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ReleaseToB.VariableName = "MAIN.InMoldDrying.TransferMold.ProdParameters.ReleaseBmMovementOffset"
        '
        'IO_ReleaseToBMB
        '
        Me.IO_ReleaseToBMB.Audit = Nothing
        Me.IO_ReleaseToBMB.AuditEnabled = False
        Me.IO_ReleaseToBMB.AuditMessage = "KremerIoField changed:"
        Me.IO_ReleaseToBMB.AuditSource = "KremerIoField"
        Me.IO_ReleaseToBMB.BackColor = System.Drawing.Color.White
        Me.IO_ReleaseToBMB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO_ReleaseToBMB.Data = 0R
        Me.IO_ReleaseToBMB.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_ReleaseToBMB.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_ReleaseToBMB.InitialValue = True
        Me.IO_ReleaseToBMB.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_ReleaseToBMB.Location = New System.Drawing.Point(294, 202)
        Me.IO_ReleaseToBMB.LowerBound = -5000.0R
        Me.IO_ReleaseToBMB.Name = "IO_ReleaseToBMB"
        Me.IO_ReleaseToBMB.OutputFormat = "0.0 mm"
        Me.IO_ReleaseToBMB.Size = New System.Drawing.Size(100, 24)
        Me.IO_ReleaseToBMB.TabIndex = 443
        Me.IO_ReleaseToBMB.Text = "0.0 mm"
        Me.IO_ReleaseToBMB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_ReleaseToBMB.UpperBound = 5000.0R
        Me.IO_ReleaseToBMB.UserInfo = Nothing
        Me.IO_ReleaseToBMB.UserLevel = 0
        Me.IO_ReleaseToBMB.Visible = False
        '
        'ioProductName
        '
        Me.ioProductName.Audit = Nothing
        Me.ioProductName.AuditEnabled = False
        Me.ioProductName.AuditMessage = "KremerTextField changed:"
        Me.ioProductName.AuditSource = "KremerTextField"
        Me.ioProductName.BackColor = System.Drawing.SystemColors.Control
        Me.ioProductName.BackColorOn = System.Drawing.Color.Empty
        Me.ioProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ioProductName.Data = "Product name"
        Me.ioProductName.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.ioProductName.ForeColorOn = System.Drawing.Color.Empty
        Me.ioProductName.InitialValue = True
        Me.ioProductName.IOType = KremerControlsWin32.KremerTextField.IO_Type.InputOutput
        Me.ioProductName.Location = New System.Drawing.Point(290, -6)
        Me.ioProductName.Name = "ioProductName"
        Me.ioProductName.PasswordMask = False
        Me.ioProductName.Size = New System.Drawing.Size(403, 29)
        Me.ioProductName.State = False
        Me.ioProductName.TabIndex = 266
        Me.ioProductName.Text = "Product name"
        Me.ioProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ioProductName.UserInfo = Nothing
        Me.ioProductName.UserLevel = 800
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(184, -4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 26)
        Me.Label9.TabIndex = 270
        Me.Label9.Tag = "16"
        Me.Label9.Text = "Product:"
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 290
        Me.LineShape1.X2 = 290
        Me.LineShape1.Y1 = 20
        Me.LineShape1.Y2 = 440
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = -3
        Me.LineShape4.X2 = 400
        Me.LineShape4.Y1 = 23
        Me.LineShape4.Y2 = 23
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5, Me.LineShape3, Me.LineShape2, Me.LineShape4, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 441)
        Me.ShapeContainer1.TabIndex = 271
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 693
        Me.LineShape5.X2 = 693
        Me.LineShape5.Y1 = 23
        Me.LineShape5.Y2 = 400
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 396
        Me.LineShape3.X2 = 396
        Me.LineShape3.Y1 = 20
        Me.LineShape3.Y2 = 441
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 401
        Me.LineShape2.X2 = 804
        Me.LineShape2.Y1 = 23
        Me.LineShape2.Y2 = 23
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-1, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(290, 24)
        Me.Label2.TabIndex = 357
        Me.Label2.Tag = "433"
        Me.Label2.Text = "Top Mold B-Position down stop"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-1, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(290, 24)
        Me.Label4.TabIndex = 360
        Me.Label4.Tag = ""
        Me.Label4.Text = "Position transfer stop A"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-2, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(290, 24)
        Me.Label5.TabIndex = 362
        Me.Label5.Tag = ""
        Me.Label5.Text = "Position transfer stop B"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-1, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(290, 24)
        Me.Label6.TabIndex = 364
        Me.Label6.Tag = "437"
        Me.Label6.Text = "Position transfer open"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(-1, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(290, 24)
        Me.Label11.TabIndex = 368
        Me.Label11.Tag = ""
        Me.Label11.Text = "Position down open"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(-1, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(290, 24)
        Me.Label12.TabIndex = 370
        Me.Label12.Tag = ""
        Me.Label12.Text = "Position down stop"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(399, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(290, 24)
        Me.Label13.TabIndex = 372
        Me.Label13.Tag = "441"
        Me.Label13.Text = "Gantry A-Vertical Pick-up position"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(400, 142)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(290, 24)
        Me.Label16.TabIndex = 374
        Me.Label16.Tag = "444"
        Me.Label16.Text = "Gantry B-Vertical Pick-up position"
        '
        'Lable15
        '
        Me.Lable15.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lable15.Location = New System.Drawing.Point(400, 165)
        Me.Lable15.Name = "Lable15"
        Me.Lable15.Size = New System.Drawing.Size(290, 24)
        Me.Lable15.TabIndex = 378
        Me.Lable15.Tag = "443"
        Me.Lable15.Text = "Gantry B-Vertical Drop-off position"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(400, 70)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(290, 24)
        Me.Label14.TabIndex = 376
        Me.Label14.Tag = "442"
        Me.Label14.Text = "Gantry A-Vertical Drop-off position"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(400, 93)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(290, 24)
        Me.Label21.TabIndex = 388
        Me.Label21.Tag = ""
        Me.Label21.Text = "Gantry A-Pick up head blow off time"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(400, 188)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(290, 24)
        Me.Label22.TabIndex = 390
        Me.Label22.Tag = ""
        Me.Label22.Text = "Gantry B-Pick up head blow off time"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(-5, 223)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(294, 23)
        Me.Label26.TabIndex = 407
        Me.Label26.Tag = ""
        Me.Label26.Text = "Top molds                                                     "
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(-4, 87)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(290, 23)
        Me.Label27.TabIndex = 408
        Me.Label27.Tag = ""
        Me.Label27.Text = "Transfermold to bottommold    "
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(-4, 24)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(294, 23)
        Me.Label28.TabIndex = 409
        Me.Label28.Tag = ""
        Me.Label28.Text = "Transfermold to forming        "
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(399, 24)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(294, 23)
        Me.Label30.TabIndex = 411
        Me.Label30.Tag = ""
        Me.Label30.Text = "Gantry A                                    "
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(399, 113)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(294, 23)
        Me.Label31.TabIndex = 412
        Me.Label31.Tag = ""
        Me.Label31.Text = "Gantry B                                    "
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(-1, 293)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(290, 24)
        Me.Label33.TabIndex = 436
        Me.Label33.Tag = ""
        Me.Label33.Text = "Top Mold A-Position open"
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label32.Location = New System.Drawing.Point(0, 316)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(290, 24)
        Me.Label32.TabIndex = 437
        Me.Label32.Tag = ""
        Me.Label32.Text = "Top Mold B-Position open"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-1, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(290, 24)
        Me.Label7.TabIndex = 268
        Me.Label7.Tag = "431"
        Me.Label7.Text = "Top Mold A-Position down stop"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-2, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(290, 24)
        Me.Label3.TabIndex = 440
        Me.Label3.Tag = ""
        Me.Label3.Text = "Position to release bottommolds"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 24)
        Me.Label1.TabIndex = 441
        Me.Label1.Tag = ""
        Me.Label1.Text = "Invisible but in db (remove later)"
        Me.Label1.Visible = False
        '
        'Product
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.IO_ReleaseToBMB)
        Me.Controls.Add(Me.IO_ReleaseToBMA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IO_TopBOpen)
        Me.Controls.Add(Me.IO_TopAOpen)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.IO_TMDownStop)
        Me.Controls.Add(Me.IO_TMDownOpen)
        Me.Controls.Add(Me.IO_TMTransferStopB)
        Me.Controls.Add(Me.IO_TMOpen)
        Me.Controls.Add(Me.IO_TMTransferStopA)
        Me.Controls.Add(Me.IO_GYBBlowOff)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.IO_GYABlowOff)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Lable15)
        Me.Controls.Add(Me.IO_GYBVerticalPickup)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.IO_GYBVerticalDropOff)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.IO_GYAVerticalDropOff)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.IO_GYAVerticalPickup)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IO_TopBDownStop)
        Me.Controls.Add(Me.ioProductName)
        Me.Controls.Add(Me.IO_TopADownStop)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnSaveNew)
        Me.Controls.Add(Me.ioProductId)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Product"
        Me.Size = New System.Drawing.Size(800, 441)
        Me.Tag = "5"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ioProductId As KremerControlsWin32.KremerIoField
    Friend WithEvents btnSave As KremerControlsWin32.KremerButton
    Friend WithEvents btnLoad As KremerControlsWin32.KremerButton
    Friend WithEvents krConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents krVarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents btnSaveNew As KremerControlsWin32.KremerButton
    Friend WithEvents ioProductName As KremerControlsWin32.KremerTextField
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents IO_TopBDownStop As KremerControlsWin32.KremerIoField
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TopADownStop As KremerControlsWin32.KremerVariable
    Friend WithEvents TopBDownStop As KremerControlsWin32.KremerVariable
    Friend WithEvents TMTransferStopA As KremerControlsWin32.KremerVariable
    Friend WithEvents TMTransferStopB As KremerControlsWin32.KremerVariable
    Friend WithEvents TMTransferOpen As KremerControlsWin32.KremerVariable
    Friend WithEvents TMDownOpen As KremerControlsWin32.KremerVariable
    Friend WithEvents TMDownStop As KremerControlsWin32.KremerVariable
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents IO_GYAVerticalPickup As KremerControlsWin32.KremerIoField
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents IO_GYAVerticalDropOff As KremerControlsWin32.KremerIoField
    Friend WithEvents Lable15 As System.Windows.Forms.Label
    Friend WithEvents IO_GYBVerticalPickup As KremerControlsWin32.KremerIoField
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents IO_GYBVerticalDropOff As KremerControlsWin32.KremerIoField
    Friend WithEvents GYAVertPickUp As KremerControlsWin32.KremerVariable
    Friend WithEvents GYAVertDropOff As KremerControlsWin32.KremerVariable
    Friend WithEvents GTYBVertDropOff As KremerControlsWin32.KremerVariable
    Friend WithEvents GTYBVertPickUp As KremerControlsWin32.KremerVariable
    Friend WithEvents GTYABlowOffTime As KremerControlsWin32.KremerVariable
    Friend WithEvents GTYBBlowOffTime As KremerControlsWin32.KremerVariable
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents IO_GYABlowOff As KremerControlsWin32.KremerIoField
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents IO_GYBBlowOff As KremerControlsWin32.KremerIoField
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents IO_TMTransferStopA As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_TMOpen As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_TMTransferStopB As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_TMDownOpen As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_TMDownStop As KremerControlsWin32.KremerIoField
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents IO_TopADownStop As KremerControlsWin32.KremerIoField
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents IO_TopBOpen As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_TopAOpen As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_ReleaseToBMA As KremerControlsWin32.KremerIoField
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TopAOpen As KremerControlsWin32.KremerVariable
    Friend WithEvents TopBOpen As KremerControlsWin32.KremerVariable
    Friend WithEvents ReleaseToA As KremerControlsWin32.KremerVariable
    Friend WithEvents ReleaseToB As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_ReleaseToBMB As KremerControlsWin32.KremerIoField
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
