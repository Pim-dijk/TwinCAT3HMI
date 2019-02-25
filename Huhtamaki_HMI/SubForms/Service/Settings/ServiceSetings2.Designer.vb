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
        Me.TibRefVeloBelt = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioTIB_RefVelo = New KremerControlsWin32.KremerIoField(Me.components)
        Me.BClampCilTimeOut = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioBClampCilTimeOut = New KremerControlsWin32.KremerIoField(Me.components)
        Me.BClampCilTimeIn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioBClampCilTimeIn = New KremerControlsWin32.KremerIoField(Me.components)
        Me.BSepCilTimeOut = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioBSepCilTimeOut = New KremerControlsWin32.KremerIoField(Me.components)
        Me.BSepCilTimeIn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioBSepCilTimeIn = New KremerControlsWin32.KremerIoField(Me.components)
        Me.CLiftCamID = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioCLiftCamID = New KremerControlsWin32.KremerIoField(Me.components)
        Me.HTCamTableID = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioHTCamTableID = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PHCamTableID = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioPHCamTableID = New KremerControlsWin32.KremerIoField(Me.components)
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape14 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape13 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape11 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape10 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Settings = New System.Windows.Forms.Button()
        Me.Btn_Settings2 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblCartonLift = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape12 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IO_OffsetPosZero = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Input_EndOfTrack_Pos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.KremerIoField4 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.KremerIoField3 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.KremerIoField2 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.KremerIoField1 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.KremerIoField12 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.lbl_puh = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'krConnector
        '
        Me.krConnector.VarCollector = Nothing
        '
        'krVarCollector
        '
        Me.krVarCollector.Variables.Add(Me.TibRefVeloBelt)
        Me.krVarCollector.Variables.Add(Me.BClampCilTimeOut)
        Me.krVarCollector.Variables.Add(Me.BClampCilTimeIn)
        Me.krVarCollector.Variables.Add(Me.BSepCilTimeOut)
        Me.krVarCollector.Variables.Add(Me.BSepCilTimeIn)
        Me.krVarCollector.Variables.Add(Me.CLiftCamID)
        Me.krVarCollector.Variables.Add(Me.HTCamTableID)
        Me.krVarCollector.Variables.Add(Me.PHCamTableID)
        '
        'TibRefVeloBelt
        '
        Me.TibRefVeloBelt.BindControl = Me.ioTIB_RefVelo
        Me.TibRefVeloBelt.BindProperty = "Data"
        Me.TibRefVeloBelt.Data = Nothing
        Me.TibRefVeloBelt.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.TibRefVeloBelt.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TibRefVeloBelt.VariableName = "InlineAutomation.MachPar.Inline.TimingInfeed.Velocity_Belt_Reference"
        '
        'ioTIB_RefVelo
        '
        Me.ioTIB_RefVelo.Audit = Nothing
        Me.ioTIB_RefVelo.AuditEnabled = False
        Me.ioTIB_RefVelo.AuditMessage = "KremerIoField changed:"
        Me.ioTIB_RefVelo.AuditSource = "KremerIoField"
        Me.ioTIB_RefVelo.BackColor = System.Drawing.Color.White
        Me.ioTIB_RefVelo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ioTIB_RefVelo.Data = 0.0R
        Me.ioTIB_RefVelo.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioTIB_RefVelo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioTIB_RefVelo.InitialValue = True
        Me.ioTIB_RefVelo.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.ioTIB_RefVelo.Location = New System.Drawing.Point(279, 37)
        Me.ioTIB_RefVelo.LowerBound = 0.0R
        Me.ioTIB_RefVelo.Name = "ioTIB_RefVelo"
        Me.ioTIB_RefVelo.OutputFormat = "0 mm/s"
        Me.ioTIB_RefVelo.Size = New System.Drawing.Size(100, 22)
        Me.ioTIB_RefVelo.TabIndex = 368
        Me.ioTIB_RefVelo.Text = "0 mm/s"
        Me.ioTIB_RefVelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioTIB_RefVelo.UpperBound = 1303.0R
        Me.ioTIB_RefVelo.UserInfo = Nothing
        Me.ioTIB_RefVelo.UserLevel = 999
        '
        'BClampCilTimeOut
        '
        Me.BClampCilTimeOut.BindControl = Me.ioBClampCilTimeOut
        Me.BClampCilTimeOut.BindProperty = "Data"
        Me.BClampCilTimeOut.Data = Nothing
        Me.BClampCilTimeOut.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.BClampCilTimeOut.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BClampCilTimeOut.VariableName = "InlineAutomation.MachPar.Inline.Zipper.VerticalDenester.BundleStorage.BundleClamp" & _
    "_CilinderOutTime"
        '
        'ioBClampCilTimeOut
        '
        Me.ioBClampCilTimeOut.Audit = Nothing
        Me.ioBClampCilTimeOut.AuditEnabled = False
        Me.ioBClampCilTimeOut.AuditMessage = "KremerIoField changed:"
        Me.ioBClampCilTimeOut.AuditSource = "KremerIoField"
        Me.ioBClampCilTimeOut.BackColor = System.Drawing.Color.White
        Me.ioBClampCilTimeOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ioBClampCilTimeOut.Data = 0.0R
        Me.ioBClampCilTimeOut.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioBClampCilTimeOut.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioBClampCilTimeOut.InitialValue = True
        Me.ioBClampCilTimeOut.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.ioBClampCilTimeOut.Location = New System.Drawing.Point(279, 102)
        Me.ioBClampCilTimeOut.LowerBound = 0.0R
        Me.ioBClampCilTimeOut.Name = "ioBClampCilTimeOut"
        Me.ioBClampCilTimeOut.OutputFormat = "0 ms"
        Me.ioBClampCilTimeOut.Size = New System.Drawing.Size(100, 22)
        Me.ioBClampCilTimeOut.TabIndex = 371
        Me.ioBClampCilTimeOut.Text = "0 ms"
        Me.ioBClampCilTimeOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioBClampCilTimeOut.UpperBound = 2000.0R
        Me.ioBClampCilTimeOut.UserInfo = Nothing
        Me.ioBClampCilTimeOut.UserLevel = 999
        '
        'BClampCilTimeIn
        '
        Me.BClampCilTimeIn.BindControl = Me.ioBClampCilTimeIn
        Me.BClampCilTimeIn.BindProperty = "Data"
        Me.BClampCilTimeIn.Data = Nothing
        Me.BClampCilTimeIn.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.BClampCilTimeIn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BClampCilTimeIn.VariableName = "InlineAutomation.MachPar.Inline.Zipper.VerticalDenester.BundleStorage.BundleClamp" & _
    "_CilinderInTime"
        '
        'ioBClampCilTimeIn
        '
        Me.ioBClampCilTimeIn.Audit = Nothing
        Me.ioBClampCilTimeIn.AuditEnabled = False
        Me.ioBClampCilTimeIn.AuditMessage = "KremerIoField changed:"
        Me.ioBClampCilTimeIn.AuditSource = "KremerIoField"
        Me.ioBClampCilTimeIn.BackColor = System.Drawing.Color.White
        Me.ioBClampCilTimeIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ioBClampCilTimeIn.Data = 0.0R
        Me.ioBClampCilTimeIn.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioBClampCilTimeIn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioBClampCilTimeIn.InitialValue = True
        Me.ioBClampCilTimeIn.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.ioBClampCilTimeIn.Location = New System.Drawing.Point(279, 125)
        Me.ioBClampCilTimeIn.LowerBound = 0.0R
        Me.ioBClampCilTimeIn.Name = "ioBClampCilTimeIn"
        Me.ioBClampCilTimeIn.OutputFormat = "0 ms"
        Me.ioBClampCilTimeIn.Size = New System.Drawing.Size(100, 22)
        Me.ioBClampCilTimeIn.TabIndex = 373
        Me.ioBClampCilTimeIn.Text = "0 ms"
        Me.ioBClampCilTimeIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioBClampCilTimeIn.UpperBound = 2000.0R
        Me.ioBClampCilTimeIn.UserInfo = Nothing
        Me.ioBClampCilTimeIn.UserLevel = 999
        '
        'BSepCilTimeOut
        '
        Me.BSepCilTimeOut.BindControl = Me.ioBSepCilTimeOut
        Me.BSepCilTimeOut.BindProperty = "Data"
        Me.BSepCilTimeOut.Data = Nothing
        Me.BSepCilTimeOut.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.BSepCilTimeOut.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BSepCilTimeOut.VariableName = "InlineAutomation.MachPar.Inline.Zipper.VerticalDenester.BundleStorage.Separator_C" & _
    "ilinderOutTime"
        '
        'ioBSepCilTimeOut
        '
        Me.ioBSepCilTimeOut.Audit = Nothing
        Me.ioBSepCilTimeOut.AuditEnabled = False
        Me.ioBSepCilTimeOut.AuditMessage = "KremerIoField changed:"
        Me.ioBSepCilTimeOut.AuditSource = "KremerIoField"
        Me.ioBSepCilTimeOut.BackColor = System.Drawing.Color.White
        Me.ioBSepCilTimeOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ioBSepCilTimeOut.Data = 0.0R
        Me.ioBSepCilTimeOut.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioBSepCilTimeOut.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioBSepCilTimeOut.InitialValue = True
        Me.ioBSepCilTimeOut.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.ioBSepCilTimeOut.Location = New System.Drawing.Point(279, 190)
        Me.ioBSepCilTimeOut.LowerBound = 0.0R
        Me.ioBSepCilTimeOut.Name = "ioBSepCilTimeOut"
        Me.ioBSepCilTimeOut.OutputFormat = "0 ms"
        Me.ioBSepCilTimeOut.Size = New System.Drawing.Size(100, 22)
        Me.ioBSepCilTimeOut.TabIndex = 376
        Me.ioBSepCilTimeOut.Text = "0 ms"
        Me.ioBSepCilTimeOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioBSepCilTimeOut.UpperBound = 2000.0R
        Me.ioBSepCilTimeOut.UserInfo = Nothing
        Me.ioBSepCilTimeOut.UserLevel = 999
        '
        'BSepCilTimeIn
        '
        Me.BSepCilTimeIn.BindControl = Me.ioBSepCilTimeIn
        Me.BSepCilTimeIn.BindProperty = "Data"
        Me.BSepCilTimeIn.Data = Nothing
        Me.BSepCilTimeIn.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.BSepCilTimeIn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BSepCilTimeIn.VariableName = "InlineAutomation.MachPar.Inline.Zipper.VerticalDenester.BundleStorage.Separator_C" & _
    "ilinderInTime"
        '
        'ioBSepCilTimeIn
        '
        Me.ioBSepCilTimeIn.Audit = Nothing
        Me.ioBSepCilTimeIn.AuditEnabled = False
        Me.ioBSepCilTimeIn.AuditMessage = "KremerIoField changed:"
        Me.ioBSepCilTimeIn.AuditSource = "KremerIoField"
        Me.ioBSepCilTimeIn.BackColor = System.Drawing.Color.White
        Me.ioBSepCilTimeIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ioBSepCilTimeIn.Data = 0.0R
        Me.ioBSepCilTimeIn.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioBSepCilTimeIn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioBSepCilTimeIn.InitialValue = True
        Me.ioBSepCilTimeIn.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.ioBSepCilTimeIn.Location = New System.Drawing.Point(279, 213)
        Me.ioBSepCilTimeIn.LowerBound = 0.0R
        Me.ioBSepCilTimeIn.Name = "ioBSepCilTimeIn"
        Me.ioBSepCilTimeIn.OutputFormat = "0 ms"
        Me.ioBSepCilTimeIn.Size = New System.Drawing.Size(100, 22)
        Me.ioBSepCilTimeIn.TabIndex = 378
        Me.ioBSepCilTimeIn.Text = "0 ms"
        Me.ioBSepCilTimeIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioBSepCilTimeIn.UpperBound = 2000.0R
        Me.ioBSepCilTimeIn.UserInfo = Nothing
        Me.ioBSepCilTimeIn.UserLevel = 999
        '
        'CLiftCamID
        '
        Me.CLiftCamID.BindControl = Me.ioCLiftCamID
        Me.CLiftCamID.BindProperty = "Data"
        Me.CLiftCamID.Data = Nothing
        Me.CLiftCamID.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.CLiftCamID.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.CLiftCamID.VariableName = "InlineAutomation.MachPar.Inline.Zipper.VerticalDenester.CartonLift.ID_CamTable"
        '
        'ioCLiftCamID
        '
        Me.ioCLiftCamID.Audit = Nothing
        Me.ioCLiftCamID.AuditEnabled = False
        Me.ioCLiftCamID.AuditMessage = "KremerIoField changed:"
        Me.ioCLiftCamID.AuditSource = "KremerIoField"
        Me.ioCLiftCamID.BackColor = System.Drawing.Color.White
        Me.ioCLiftCamID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ioCLiftCamID.Data = 0.0R
        Me.ioCLiftCamID.DataType = KremerControlsWin32.KremerIoField.NumDataType.INT
        Me.ioCLiftCamID.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioCLiftCamID.InitialValue = True
        Me.ioCLiftCamID.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.ioCLiftCamID.Location = New System.Drawing.Point(279, 275)
        Me.ioCLiftCamID.LowerBound = 0.0R
        Me.ioCLiftCamID.Name = "ioCLiftCamID"
        Me.ioCLiftCamID.OutputFormat = "0"
        Me.ioCLiftCamID.Size = New System.Drawing.Size(100, 22)
        Me.ioCLiftCamID.TabIndex = 381
        Me.ioCLiftCamID.Text = "0"
        Me.ioCLiftCamID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioCLiftCamID.UpperBound = 20.0R
        Me.ioCLiftCamID.UserInfo = Nothing
        Me.ioCLiftCamID.UserLevel = 999
        '
        'HTCamTableID
        '
        Me.HTCamTableID.BindControl = Me.ioHTCamTableID
        Me.HTCamTableID.BindProperty = "Data"
        Me.HTCamTableID.Data = Nothing
        Me.HTCamTableID.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.HTCamTableID.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.HTCamTableID.VariableName = "InlineAutomation.MachPar.Inline.Zipper.VerticalDenester.HorizontalTransport.ID_Ca" & _
    "mTable"
        '
        'ioHTCamTableID
        '
        Me.ioHTCamTableID.Audit = Nothing
        Me.ioHTCamTableID.AuditEnabled = False
        Me.ioHTCamTableID.AuditMessage = "KremerIoField changed:"
        Me.ioHTCamTableID.AuditSource = "KremerIoField"
        Me.ioHTCamTableID.BackColor = System.Drawing.Color.White
        Me.ioHTCamTableID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ioHTCamTableID.Data = 0.0R
        Me.ioHTCamTableID.DataType = KremerControlsWin32.KremerIoField.NumDataType.INT
        Me.ioHTCamTableID.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioHTCamTableID.InitialValue = True
        Me.ioHTCamTableID.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.ioHTCamTableID.Location = New System.Drawing.Point(279, 344)
        Me.ioHTCamTableID.LowerBound = 0.0R
        Me.ioHTCamTableID.Name = "ioHTCamTableID"
        Me.ioHTCamTableID.OutputFormat = "0"
        Me.ioHTCamTableID.Size = New System.Drawing.Size(100, 22)
        Me.ioHTCamTableID.TabIndex = 390
        Me.ioHTCamTableID.Text = "0"
        Me.ioHTCamTableID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioHTCamTableID.UpperBound = 20.0R
        Me.ioHTCamTableID.UserInfo = Nothing
        Me.ioHTCamTableID.UserLevel = 999
        '
        'PHCamTableID
        '
        Me.PHCamTableID.BindControl = Me.ioPHCamTableID
        Me.PHCamTableID.BindProperty = "Data"
        Me.PHCamTableID.Data = Nothing
        Me.PHCamTableID.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.PHCamTableID.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PHCamTableID.VariableName = "InlineAutomation.MachPar.Inline.Zipper.VerticalDenester.PickupHead.ID_CamTable"
        '
        'ioPHCamTableID
        '
        Me.ioPHCamTableID.Audit = Nothing
        Me.ioPHCamTableID.AuditEnabled = False
        Me.ioPHCamTableID.AuditMessage = "KremerIoField changed:"
        Me.ioPHCamTableID.AuditSource = "KremerIoField"
        Me.ioPHCamTableID.BackColor = System.Drawing.Color.White
        Me.ioPHCamTableID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ioPHCamTableID.Data = 0.0R
        Me.ioPHCamTableID.DataType = KremerControlsWin32.KremerIoField.NumDataType.INT
        Me.ioPHCamTableID.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioPHCamTableID.InitialValue = True
        Me.ioPHCamTableID.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.ioPHCamTableID.Location = New System.Drawing.Point(676, 40)
        Me.ioPHCamTableID.LowerBound = 0.0R
        Me.ioPHCamTableID.Name = "ioPHCamTableID"
        Me.ioPHCamTableID.OutputFormat = "0"
        Me.ioPHCamTableID.Size = New System.Drawing.Size(100, 22)
        Me.ioPHCamTableID.TabIndex = 392
        Me.ioPHCamTableID.Text = "0"
        Me.ioPHCamTableID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioPHCamTableID.UpperBound = 20.0R
        Me.ioPHCamTableID.UserInfo = Nothing
        Me.ioPHCamTableID.UserLevel = 999
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 274
        Me.LineShape6.X2 = 274
        Me.LineShape6.Y1 = 33
        Me.LineShape6.Y2 = 65
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape12, Me.LineShape3, Me.LineShape14, Me.LineShape13, Me.LineShape5, Me.LineShape4, Me.LineShape11, Me.LineShape10, Me.LineShape9, Me.LineShape8, Me.LineShape7, Me.LineShape2, Me.LineShape1, Me.LineShape6})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 441)
        Me.ShapeContainer1.TabIndex = 355
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape14
        '
        Me.LineShape14.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape14.Name = "LineShape14"
        Me.LineShape14.X1 = 670
        Me.LineShape14.X2 = 670
        Me.LineShape14.Y1 = 35
        Me.LineShape14.Y2 = 67
        '
        'LineShape13
        '
        Me.LineShape13.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape13.Name = "LineShape13"
        Me.LineShape13.X1 = 405
        Me.LineShape13.X2 = 780
        Me.LineShape13.Y1 = 35
        Me.LineShape13.Y2 = 35
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 275
        Me.LineShape5.X2 = 275
        Me.LineShape5.Y1 = 340
        Me.LineShape5.Y2 = 372
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 10
        Me.LineShape4.X2 = 385
        Me.LineShape4.Y1 = 340
        Me.LineShape4.Y2 = 340
        '
        'LineShape11
        '
        Me.LineShape11.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape11.Name = "LineShape11"
        Me.LineShape11.X1 = 10
        Me.LineShape11.X2 = 385
        Me.LineShape11.Y1 = 33
        Me.LineShape11.Y2 = 33
        '
        'LineShape10
        '
        Me.LineShape10.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape10.Name = "LineShape10"
        Me.LineShape10.X1 = 274
        Me.LineShape10.X2 = 274
        Me.LineShape10.Y1 = 271
        Me.LineShape10.Y2 = 301
        '
        'LineShape9
        '
        Me.LineShape9.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape9.Name = "LineShape9"
        Me.LineShape9.X1 = 10
        Me.LineShape9.X2 = 385
        Me.LineShape9.Y1 = 270
        Me.LineShape9.Y2 = 270
        '
        'LineShape8
        '
        Me.LineShape8.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape8.Name = "LineShape8"
        Me.LineShape8.X1 = 274
        Me.LineShape8.X2 = 274
        Me.LineShape8.Y1 = 185
        Me.LineShape8.Y2 = 239
        '
        'LineShape7
        '
        Me.LineShape7.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 10
        Me.LineShape7.X2 = 385
        Me.LineShape7.Y1 = 185
        Me.LineShape7.Y2 = 185
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 274
        Me.LineShape2.X2 = 274
        Me.LineShape2.Y1 = 97
        Me.LineShape2.Y2 = 147
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 10
        Me.LineShape1.X2 = 385
        Me.LineShape1.Y1 = 97
        Me.LineShape1.Y2 = 97
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
        Me.Btn_Settings2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Settings2.Location = New System.Drawing.Point(84, 26)
        Me.Btn_Settings2.Name = "Btn_Settings2"
        Me.Btn_Settings2.Size = New System.Drawing.Size(75, 75)
        Me.Btn_Settings2.TabIndex = 254
        Me.Btn_Settings2.Text = ">"
        Me.Btn_Settings2.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(10, 9)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(330, 23)
        Me.Label19.TabIndex = 366
        Me.Label19.Tag = "213"
        Me.Label19.Text = "Timing Infeed:"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(10, 36)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(247, 23)
        Me.Label23.TabIndex = 367
        Me.Label23.Tag = "260"
        Me.Label23.Text = "Reference Velocity:"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(10, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(369, 23)
        Me.Label10.TabIndex = 369
        Me.Label10.Tag = "619"
        Me.Label10.Text = "Bundle clamp cilinders:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(263, 23)
        Me.Label8.TabIndex = 372
        Me.Label8.Tag = "624"
        Me.Label8.Text = "Cilinder time in:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(263, 23)
        Me.Label3.TabIndex = 370
        Me.Label3.Tag = "623"
        Me.Label3.Text = "Cilinder time out:"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(10, 158)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(369, 23)
        Me.Label16.TabIndex = 374
        Me.Label16.Tag = "620"
        Me.Label16.Text = "Bundle Separator cilinders:"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 214)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(238, 23)
        Me.Label14.TabIndex = 377
        Me.Label14.Tag = "624"
        Me.Label14.Text = "Cilinder time in:"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 191)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(238, 23)
        Me.Label15.TabIndex = 375
        Me.Label15.Tag = "623"
        Me.Label15.Text = "Cilinder time out:"
        '
        'lblCartonLift
        '
        Me.lblCartonLift.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblCartonLift.Location = New System.Drawing.Point(10, 246)
        Me.lblCartonLift.Name = "lblCartonLift"
        Me.lblCartonLift.Size = New System.Drawing.Size(246, 23)
        Me.lblCartonLift.TabIndex = 379
        Me.lblCartonLift.Tag = "606"
        Me.lblCartonLift.Text = "Carton Lift:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 23)
        Me.Label1.TabIndex = 380
        Me.Label1.Tag = "224"
        Me.Label1.Text = "Cam table ID:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(9, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(246, 23)
        Me.Label6.TabIndex = 387
        Me.Label6.Tag = "605"
        Me.Label6.Text = "Horizontal Transport:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(406, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(300, 23)
        Me.Label7.TabIndex = 388
        Me.Label7.Tag = "613"
        Me.Label7.Text = "Vert. denester Pickup Head:"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 344)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(245, 23)
        Me.Label9.TabIndex = 389
        Me.Label9.Tag = "224"
        Me.Label9.Text = "Cam table ID:"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(406, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(238, 23)
        Me.Label11.TabIndex = 391
        Me.Label11.Tag = "224"
        Me.Label11.Text = "Cam table ID:"
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 406
        Me.LineShape3.X2 = 781
        Me.LineShape3.Y1 = 111
        Me.LineShape3.Y2 = 111
        '
        'LineShape12
        '
        Me.LineShape12.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape12.Name = "LineShape12"
        Me.LineShape12.X1 = 670
        Me.LineShape12.X2 = 670
        Me.LineShape12.Y1 = 111
        Me.LineShape12.Y2 = 228
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(400, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 23)
        Me.Label4.TabIndex = 407
        Me.Label4.Tag = ""
        Me.Label4.Text = "Offset zero pos. spray bar"
        '
        'IO_OffsetPosZero
        '
        Me.IO_OffsetPosZero.Audit = Nothing
        Me.IO_OffsetPosZero.AuditEnabled = False
        Me.IO_OffsetPosZero.AuditMessage = "KremerIoField changed:"
        Me.IO_OffsetPosZero.AuditSource = "KremerIoField"
        Me.IO_OffsetPosZero.BackColor = System.Drawing.Color.White
        Me.IO_OffsetPosZero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_OffsetPosZero.Data = 0.0R
        Me.IO_OffsetPosZero.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_OffsetPosZero.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_OffsetPosZero.InitialValue = True
        Me.IO_OffsetPosZero.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_OffsetPosZero.Location = New System.Drawing.Point(676, 253)
        Me.IO_OffsetPosZero.LowerBound = 0.0R
        Me.IO_OffsetPosZero.Name = "IO_OffsetPosZero"
        Me.IO_OffsetPosZero.OutputFormat = "0.0 mm"
        Me.IO_OffsetPosZero.Size = New System.Drawing.Size(100, 22)
        Me.IO_OffsetPosZero.TabIndex = 406
        Me.IO_OffsetPosZero.Text = "0.0 mm"
        Me.IO_OffsetPosZero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_OffsetPosZero.UpperBound = 3000.0R
        Me.IO_OffsetPosZero.UserInfo = Nothing
        Me.IO_OffsetPosZero.UserLevel = 500
        '
        'Input_EndOfTrack_Pos
        '
        Me.Input_EndOfTrack_Pos.Audit = Nothing
        Me.Input_EndOfTrack_Pos.AuditEnabled = False
        Me.Input_EndOfTrack_Pos.AuditMessage = "KremerIoField changed:"
        Me.Input_EndOfTrack_Pos.AuditSource = "KremerIoField"
        Me.Input_EndOfTrack_Pos.BackColor = System.Drawing.Color.White
        Me.Input_EndOfTrack_Pos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Input_EndOfTrack_Pos.Data = 0.0R
        Me.Input_EndOfTrack_Pos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.Input_EndOfTrack_Pos.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input_EndOfTrack_Pos.InitialValue = True
        Me.Input_EndOfTrack_Pos.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.Input_EndOfTrack_Pos.Location = New System.Drawing.Point(676, 230)
        Me.Input_EndOfTrack_Pos.LowerBound = 0.0R
        Me.Input_EndOfTrack_Pos.Name = "Input_EndOfTrack_Pos"
        Me.Input_EndOfTrack_Pos.OutputFormat = "0.0 mm"
        Me.Input_EndOfTrack_Pos.Size = New System.Drawing.Size(100, 22)
        Me.Input_EndOfTrack_Pos.TabIndex = 405
        Me.Input_EndOfTrack_Pos.Text = "0.0 mm"
        Me.Input_EndOfTrack_Pos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Input_EndOfTrack_Pos.UpperBound = 5000.0R
        Me.Input_EndOfTrack_Pos.UserInfo = Nothing
        Me.Input_EndOfTrack_Pos.UserLevel = 800
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(400, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 23)
        Me.Label2.TabIndex = 404
        Me.Label2.Tag = ""
        Me.Label2.Text = "Machine pond Position zero offset"
        '
        'KremerIoField4
        '
        Me.KremerIoField4.Audit = Nothing
        Me.KremerIoField4.AuditEnabled = False
        Me.KremerIoField4.AuditMessage = "KremerIoField changed:"
        Me.KremerIoField4.AuditSource = "KremerIoField"
        Me.KremerIoField4.BackColor = System.Drawing.Color.White
        Me.KremerIoField4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KremerIoField4.Data = 0.0R
        Me.KremerIoField4.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.KremerIoField4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerIoField4.InitialValue = True
        Me.KremerIoField4.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.KremerIoField4.Location = New System.Drawing.Point(676, 207)
        Me.KremerIoField4.LowerBound = 0.0R
        Me.KremerIoField4.Name = "KremerIoField4"
        Me.KremerIoField4.OutputFormat = "0.0 mm"
        Me.KremerIoField4.Size = New System.Drawing.Size(100, 22)
        Me.KremerIoField4.TabIndex = 403
        Me.KremerIoField4.Text = "0.0 mm"
        Me.KremerIoField4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.KremerIoField4.UpperBound = 1000.0R
        Me.KremerIoField4.UserInfo = Nothing
        Me.KremerIoField4.UserLevel = 500
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(400, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 23)
        Me.Label5.TabIndex = 402
        Me.Label5.Tag = "262"
        Me.Label5.Text = "Transfermold offset Zero"
        '
        'KremerIoField3
        '
        Me.KremerIoField3.Audit = Nothing
        Me.KremerIoField3.AuditEnabled = False
        Me.KremerIoField3.AuditMessage = "KremerIoField changed:"
        Me.KremerIoField3.AuditSource = "KremerIoField"
        Me.KremerIoField3.BackColor = System.Drawing.Color.White
        Me.KremerIoField3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KremerIoField3.Data = 0.0R
        Me.KremerIoField3.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.KremerIoField3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerIoField3.InitialValue = True
        Me.KremerIoField3.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.KremerIoField3.Location = New System.Drawing.Point(676, 184)
        Me.KremerIoField3.LowerBound = 0.0R
        Me.KremerIoField3.Name = "KremerIoField3"
        Me.KremerIoField3.OutputFormat = "0.0 mm"
        Me.KremerIoField3.Size = New System.Drawing.Size(100, 22)
        Me.KremerIoField3.TabIndex = 401
        Me.KremerIoField3.Text = "0.0 mm"
        Me.KremerIoField3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.KremerIoField3.UpperBound = 1000.0R
        Me.KremerIoField3.UserInfo = Nothing
        Me.KremerIoField3.UserLevel = 500
        '
        'KremerIoField2
        '
        Me.KremerIoField2.Audit = Nothing
        Me.KremerIoField2.AuditEnabled = False
        Me.KremerIoField2.AuditMessage = "KremerIoField changed:"
        Me.KremerIoField2.AuditSource = "KremerIoField"
        Me.KremerIoField2.BackColor = System.Drawing.Color.White
        Me.KremerIoField2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KremerIoField2.Data = 0.0R
        Me.KremerIoField2.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.KremerIoField2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerIoField2.InitialValue = True
        Me.KremerIoField2.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.KremerIoField2.Location = New System.Drawing.Point(676, 162)
        Me.KremerIoField2.LowerBound = 0.0R
        Me.KremerIoField2.Name = "KremerIoField2"
        Me.KremerIoField2.OutputFormat = "0.0 mm"
        Me.KremerIoField2.Size = New System.Drawing.Size(100, 22)
        Me.KremerIoField2.TabIndex = 400
        Me.KremerIoField2.Text = "0.0 mm"
        Me.KremerIoField2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.KremerIoField2.UpperBound = 1000.0R
        Me.KremerIoField2.UserInfo = Nothing
        Me.KremerIoField2.UserLevel = 500
        '
        'KremerIoField1
        '
        Me.KremerIoField1.Audit = Nothing
        Me.KremerIoField1.AuditEnabled = False
        Me.KremerIoField1.AuditMessage = "KremerIoField changed:"
        Me.KremerIoField1.AuditSource = "KremerIoField"
        Me.KremerIoField1.BackColor = System.Drawing.Color.White
        Me.KremerIoField1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KremerIoField1.Data = 0.0R
        Me.KremerIoField1.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.KremerIoField1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerIoField1.InitialValue = True
        Me.KremerIoField1.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.KremerIoField1.Location = New System.Drawing.Point(676, 138)
        Me.KremerIoField1.LowerBound = 0.0R
        Me.KremerIoField1.Name = "KremerIoField1"
        Me.KremerIoField1.OutputFormat = "0.0 mm"
        Me.KremerIoField1.Size = New System.Drawing.Size(100, 22)
        Me.KremerIoField1.TabIndex = 399
        Me.KremerIoField1.Text = "0.0 mm"
        Me.KremerIoField1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.KremerIoField1.UpperBound = 1000.0R
        Me.KremerIoField1.UserInfo = Nothing
        Me.KremerIoField1.UserLevel = 500
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(400, 160)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(247, 23)
        Me.Label12.TabIndex = 398
        Me.Label12.Tag = "403"
        Me.Label12.Text = "Bottom mold A offset zero"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(400, 137)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(247, 23)
        Me.Label13.TabIndex = 397
        Me.Label13.Tag = "402"
        Me.Label13.Text = "Top mold B offset zero"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(400, 183)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(247, 23)
        Me.Label22.TabIndex = 396
        Me.Label22.Tag = "404"
        Me.Label22.Text = "Bottom mold B offset zero"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(400, 114)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(247, 23)
        Me.Label17.TabIndex = 395
        Me.Label17.Tag = "401"
        Me.Label17.Text = "Top mold A offset zero"
        '
        'KremerIoField12
        '
        Me.KremerIoField12.Audit = Nothing
        Me.KremerIoField12.AuditEnabled = False
        Me.KremerIoField12.AuditMessage = "KremerIoField changed:"
        Me.KremerIoField12.AuditSource = "KremerIoField"
        Me.KremerIoField12.BackColor = System.Drawing.Color.White
        Me.KremerIoField12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KremerIoField12.Data = 0.0R
        Me.KremerIoField12.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.KremerIoField12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerIoField12.InitialValue = True
        Me.KremerIoField12.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.KremerIoField12.Location = New System.Drawing.Point(676, 115)
        Me.KremerIoField12.LowerBound = 0.0R
        Me.KremerIoField12.Name = "KremerIoField12"
        Me.KremerIoField12.OutputFormat = "0.0 mm"
        Me.KremerIoField12.Size = New System.Drawing.Size(100, 22)
        Me.KremerIoField12.TabIndex = 394
        Me.KremerIoField12.Text = "0.0 mm"
        Me.KremerIoField12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.KremerIoField12.UpperBound = 1000.0R
        Me.KremerIoField12.UserInfo = Nothing
        Me.KremerIoField12.UserLevel = 500
        '
        'lbl_puh
        '
        Me.lbl_puh.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_puh.Location = New System.Drawing.Point(400, 83)
        Me.lbl_puh.Name = "lbl_puh"
        Me.lbl_puh.Size = New System.Drawing.Size(247, 23)
        Me.lbl_puh.TabIndex = 393
        Me.lbl_puh.Tag = "400"
        Me.lbl_puh.Text = "Offset position settings"
        '
        'ServiceSettings2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.IO_OffsetPosZero)
        Me.Controls.Add(Me.Input_EndOfTrack_Pos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.KremerIoField4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.KremerIoField3)
        Me.Controls.Add(Me.KremerIoField2)
        Me.Controls.Add(Me.KremerIoField1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.KremerIoField12)
        Me.Controls.Add(Me.lbl_puh)
        Me.Controls.Add(Me.ioPHCamTableID)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ioHTCamTableID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ioCLiftCamID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCartonLift)
        Me.Controls.Add(Me.ioBSepCilTimeIn)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ioBSepCilTimeOut)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ioBClampCilTimeIn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ioBClampCilTimeOut)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ioTIB_RefVelo)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label19)
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
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape8 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape10 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape9 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape11 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btn_Settings As System.Windows.Forms.Button
    Friend WithEvents Btn_Settings2 As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TibRefVeloBelt As KremerControlsWin32.KremerVariable
    Friend WithEvents ioTIB_RefVelo As KremerControlsWin32.KremerIoField
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ioBClampCilTimeIn As KremerControlsWin32.KremerIoField
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ioBClampCilTimeOut As KremerControlsWin32.KremerIoField
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ioBSepCilTimeIn As KremerControlsWin32.KremerIoField
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ioBSepCilTimeOut As KremerControlsWin32.KremerIoField
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents BClampCilTimeOut As KremerControlsWin32.KremerVariable
    Friend WithEvents BClampCilTimeIn As KremerControlsWin32.KremerVariable
    Friend WithEvents BSepCilTimeOut As KremerControlsWin32.KremerVariable
    Friend WithEvents BSepCilTimeIn As KremerControlsWin32.KremerVariable
    Friend WithEvents lblCartonLift As System.Windows.Forms.Label
    Friend WithEvents ioCLiftCamID As KremerControlsWin32.KremerIoField
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LineShape14 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape13 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ioHTCamTableID As KremerControlsWin32.KremerIoField
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ioPHCamTableID As KremerControlsWin32.KremerIoField
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CLiftCamID As KremerControlsWin32.KremerVariable
    Friend WithEvents HTCamTableID As KremerControlsWin32.KremerVariable
    Friend WithEvents PHCamTableID As KremerControlsWin32.KremerVariable
    Friend WithEvents LineShape12 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents IO_OffsetPosZero As KremerControlsWin32.KremerIoField
    Friend WithEvents Input_EndOfTrack_Pos As KremerControlsWin32.KremerIoField
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents KremerIoField4 As KremerControlsWin32.KremerIoField
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents KremerIoField3 As KremerControlsWin32.KremerIoField
    Friend WithEvents KremerIoField2 As KremerControlsWin32.KremerIoField
    Friend WithEvents KremerIoField1 As KremerControlsWin32.KremerIoField
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents KremerIoField12 As KremerControlsWin32.KremerIoField
    Friend WithEvents lbl_puh As System.Windows.Forms.Label

End Class
