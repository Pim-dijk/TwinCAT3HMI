<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IO_TransferMold
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
        Me.TMA_HydraulicValve = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TMHydraulicValve = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TMA_Bot = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TMABotSidePressure = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TMA_Rod = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TMA_RodSidePressure = New KremerControlsWin32.KremerIoField(Me.components)
        Me.TMA_EsA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TM_EsA = New KremerControlsWin32.KremerLight()
        Me.TMA_EsB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TM_EsB = New KremerControlsWin32.KremerLight()
        Me.TMA_MspaRTO = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TM_MspaRTO = New KremerControlsWin32.KremerLight()
        Me.TMA_MspaEn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TM_MSPAEnable = New KremerControlsWin32.KremerLight()
        Me.blowoff = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMBlowOff = New KremerControlsWin32.KremerLight()
        Me.vacuum = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_TMVacuum = New KremerControlsWin32.KremerLight()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.TMA_HydraulicValve)
        Me.VarCollector.Variables.Add(Me.TMA_Bot)
        Me.VarCollector.Variables.Add(Me.TMA_Rod)
        Me.VarCollector.Variables.Add(Me.TMA_EsA)
        Me.VarCollector.Variables.Add(Me.TMA_EsB)
        Me.VarCollector.Variables.Add(Me.TMA_MspaRTO)
        Me.VarCollector.Variables.Add(Me.TMA_MspaEn)
        Me.VarCollector.Variables.Add(Me.blowoff)
        Me.VarCollector.Variables.Add(Me.vacuum)
        '
        'TMA_HydraulicValve
        '
        Me.TMA_HydraulicValve.BindControl = Me.IO_TMHydraulicValve
        Me.TMA_HydraulicValve.BindProperty = "Data"
        Me.TMA_HydraulicValve.Data = Nothing
        Me.TMA_HydraulicValve.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.TMA_HydraulicValve.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMA_HydraulicValve.VariableName = "MAIN.InMoldDrying.TransferMold.HydraulicCilinder.HydraulicValve.qwOutput"
        '
        'IO_TMHydraulicValve
        '
        Me.IO_TMHydraulicValve.Audit = Nothing
        Me.IO_TMHydraulicValve.AuditEnabled = False
        Me.IO_TMHydraulicValve.AuditMessage = "KremerIoField changed:"
        Me.IO_TMHydraulicValve.AuditSource = "KremerIoField"
        Me.IO_TMHydraulicValve.AutoSize = True
        Me.IO_TMHydraulicValve.Data = 0.0R
        Me.IO_TMHydraulicValve.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TMHydraulicValve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TMHydraulicValve.InitialValue = True
        Me.IO_TMHydraulicValve.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TMHydraulicValve.Location = New System.Drawing.Point(6, 263)
        Me.IO_TMHydraulicValve.LowerBound = 0.0R
        Me.IO_TMHydraulicValve.Name = "IO_TMHydraulicValve"
        Me.IO_TMHydraulicValve.OutputFormat = "0.0 "
        Me.IO_TMHydraulicValve.Size = New System.Drawing.Size(28, 16)
        Me.IO_TMHydraulicValve.TabIndex = 316
        Me.IO_TMHydraulicValve.Text = "0.0 "
        Me.IO_TMHydraulicValve.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TMHydraulicValve.UpperBound = 1000.0R
        Me.IO_TMHydraulicValve.UserInfo = Nothing
        Me.IO_TMHydraulicValve.UserLevel = 0
        '
        'TMA_Bot
        '
        Me.TMA_Bot.BindControl = Me.IO_TMABotSidePressure
        Me.TMA_Bot.BindProperty = "Data"
        Me.TMA_Bot.Data = Nothing
        Me.TMA_Bot.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.TMA_Bot.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMA_Bot.VariableName = "MAIN.InMoldDrying.TransferMold.HydraulicCilinder.BottomSidePressure.RawInput"
        '
        'IO_TMABotSidePressure
        '
        Me.IO_TMABotSidePressure.Audit = Nothing
        Me.IO_TMABotSidePressure.AuditEnabled = False
        Me.IO_TMABotSidePressure.AuditMessage = "KremerIoField changed:"
        Me.IO_TMABotSidePressure.AuditSource = "KremerIoField"
        Me.IO_TMABotSidePressure.AutoSize = True
        Me.IO_TMABotSidePressure.Data = 0.0R
        Me.IO_TMABotSidePressure.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TMABotSidePressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TMABotSidePressure.InitialValue = True
        Me.IO_TMABotSidePressure.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TMABotSidePressure.Location = New System.Drawing.Point(7, 136)
        Me.IO_TMABotSidePressure.LowerBound = 0.0R
        Me.IO_TMABotSidePressure.Name = "IO_TMABotSidePressure"
        Me.IO_TMABotSidePressure.OutputFormat = "0.0 "
        Me.IO_TMABotSidePressure.Size = New System.Drawing.Size(28, 16)
        Me.IO_TMABotSidePressure.TabIndex = 308
        Me.IO_TMABotSidePressure.Text = "0.0 "
        Me.IO_TMABotSidePressure.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TMABotSidePressure.UpperBound = 1000.0R
        Me.IO_TMABotSidePressure.UserInfo = Nothing
        Me.IO_TMABotSidePressure.UserLevel = 0
        '
        'TMA_Rod
        '
        Me.TMA_Rod.BindControl = Me.IO_TMA_RodSidePressure
        Me.TMA_Rod.BindProperty = "Data"
        Me.TMA_Rod.Data = Nothing
        Me.TMA_Rod.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.TMA_Rod.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMA_Rod.VariableName = "MAIN.InMoldDrying.TopMoldA.HydraulicCilinder.RodSidePressure.RawInput"
        '
        'IO_TMA_RodSidePressure
        '
        Me.IO_TMA_RodSidePressure.Audit = Nothing
        Me.IO_TMA_RodSidePressure.AuditEnabled = False
        Me.IO_TMA_RodSidePressure.AuditMessage = "KremerIoField changed:"
        Me.IO_TMA_RodSidePressure.AuditSource = "KremerIoField"
        Me.IO_TMA_RodSidePressure.AutoSize = True
        Me.IO_TMA_RodSidePressure.Data = 0.0R
        Me.IO_TMA_RodSidePressure.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TMA_RodSidePressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TMA_RodSidePressure.InitialValue = True
        Me.IO_TMA_RodSidePressure.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TMA_RodSidePressure.Location = New System.Drawing.Point(7, 118)
        Me.IO_TMA_RodSidePressure.LowerBound = 0.0R
        Me.IO_TMA_RodSidePressure.Name = "IO_TMA_RodSidePressure"
        Me.IO_TMA_RodSidePressure.OutputFormat = "0.0 "
        Me.IO_TMA_RodSidePressure.Size = New System.Drawing.Size(28, 16)
        Me.IO_TMA_RodSidePressure.TabIndex = 307
        Me.IO_TMA_RodSidePressure.Text = "0.0 "
        Me.IO_TMA_RodSidePressure.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TMA_RodSidePressure.UpperBound = 1000.0R
        Me.IO_TMA_RodSidePressure.UserInfo = Nothing
        Me.IO_TMA_RodSidePressure.UserLevel = 0
        '
        'TMA_EsA
        '
        Me.TMA_EsA.BindControl = Me.KL_TM_EsA
        Me.TMA_EsA.BindProperty = "Data"
        Me.TMA_EsA.Data = Nothing
        Me.TMA_EsA.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMA_EsA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMA_EsA.VariableName = "MAIN.InMoldDrying.TransferMold.HydraulicCilinder.ixEndSwitchA"
        '
        'KL_TM_EsA
        '
        Me.KL_TM_EsA.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TM_EsA.ColorOn = System.Drawing.Color.Lime
        Me.KL_TM_EsA.Data = False
        Me.KL_TM_EsA.Line = True
        Me.KL_TM_EsA.LineSize = 1
        Me.KL_TM_EsA.Location = New System.Drawing.Point(10, 25)
        Me.KL_TM_EsA.Name = "KL_TM_EsA"
        Me.KL_TM_EsA.Size = New System.Drawing.Size(20, 20)
        Me.KL_TM_EsA.TabIndex = 290
        Me.KL_TM_EsA.Text = "KL_TMA_EsA"
        Me.KL_TM_EsA.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMA_EsB
        '
        Me.TMA_EsB.BindControl = Me.KL_TM_EsB
        Me.TMA_EsB.BindProperty = "Data"
        Me.TMA_EsB.Data = Nothing
        Me.TMA_EsB.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMA_EsB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMA_EsB.VariableName = "MAIN.InMoldDrying.TransferMold.HydraulicCilinder.ixEndSwitchB"
        '
        'KL_TM_EsB
        '
        Me.KL_TM_EsB.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TM_EsB.ColorOn = System.Drawing.Color.Lime
        Me.KL_TM_EsB.Data = False
        Me.KL_TM_EsB.Line = True
        Me.KL_TM_EsB.LineSize = 1
        Me.KL_TM_EsB.Location = New System.Drawing.Point(10, 46)
        Me.KL_TM_EsB.Name = "KL_TM_EsB"
        Me.KL_TM_EsB.Size = New System.Drawing.Size(20, 20)
        Me.KL_TM_EsB.TabIndex = 292
        Me.KL_TM_EsB.Text = "KL_TMA_EsB"
        Me.KL_TM_EsB.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMA_MspaRTO
        '
        Me.TMA_MspaRTO.BindControl = Me.KL_TM_MspaRTO
        Me.TMA_MspaRTO.BindProperty = "Data"
        Me.TMA_MspaRTO.Data = Nothing
        Me.TMA_MspaRTO.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMA_MspaRTO.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMA_MspaRTO.VariableName = "MAIN.InMoldDrying.TransferMold.HydraulicCilinder.ixMSPAReadyToOperate"
        '
        'KL_TM_MspaRTO
        '
        Me.KL_TM_MspaRTO.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TM_MspaRTO.ColorOn = System.Drawing.Color.Lime
        Me.KL_TM_MspaRTO.Data = False
        Me.KL_TM_MspaRTO.Line = True
        Me.KL_TM_MspaRTO.LineSize = 1
        Me.KL_TM_MspaRTO.Location = New System.Drawing.Point(10, 67)
        Me.KL_TM_MspaRTO.Name = "KL_TM_MspaRTO"
        Me.KL_TM_MspaRTO.Size = New System.Drawing.Size(20, 20)
        Me.KL_TM_MspaRTO.TabIndex = 294
        Me.KL_TM_MspaRTO.Text = "KL_TMA_MspaRTO"
        Me.KL_TM_MspaRTO.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TMA_MspaEn
        '
        Me.TMA_MspaEn.BindControl = Me.KL_TM_MSPAEnable
        Me.TMA_MspaEn.BindProperty = "Data"
        Me.TMA_MspaEn.Data = Nothing
        Me.TMA_MspaEn.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TMA_MspaEn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TMA_MspaEn.VariableName = "MAIN.InMoldDrying.TransferMold.HydraulicCilinder.qxMSPAEnable"
        '
        'KL_TM_MSPAEnable
        '
        Me.KL_TM_MSPAEnable.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TM_MSPAEnable.ColorOn = System.Drawing.Color.Lime
        Me.KL_TM_MSPAEnable.Data = False
        Me.KL_TM_MSPAEnable.Line = True
        Me.KL_TM_MSPAEnable.LineSize = 1
        Me.KL_TM_MSPAEnable.Location = New System.Drawing.Point(10, 218)
        Me.KL_TM_MSPAEnable.Name = "KL_TM_MSPAEnable"
        Me.KL_TM_MSPAEnable.Size = New System.Drawing.Size(20, 20)
        Me.KL_TM_MSPAEnable.TabIndex = 294
        Me.KL_TM_MSPAEnable.Text = "KremerLight3"
        Me.KL_TM_MSPAEnable.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'blowoff
        '
        Me.blowoff.BindControl = Me.KL_TMBlowOff
        Me.blowoff.BindProperty = "Data"
        Me.blowoff.Data = Nothing
        Me.blowoff.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.blowoff.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.blowoff.VariableName = "MAIN.InMoldDrying.TransferMold.BlowOff.Q"
        '
        'KL_TMBlowOff
        '
        Me.KL_TMBlowOff.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMBlowOff.ColorOn = System.Drawing.Color.Lime
        Me.KL_TMBlowOff.Data = False
        Me.KL_TMBlowOff.Line = True
        Me.KL_TMBlowOff.LineSize = 1
        Me.KL_TMBlowOff.Location = New System.Drawing.Point(10, 178)
        Me.KL_TMBlowOff.Name = "KL_TMBlowOff"
        Me.KL_TMBlowOff.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMBlowOff.TabIndex = 290
        Me.KL_TMBlowOff.Text = "KremerLight2"
        Me.KL_TMBlowOff.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'vacuum
        '
        Me.vacuum.BindControl = Me.KL_TMVacuum
        Me.vacuum.BindProperty = "Data"
        Me.vacuum.Data = Nothing
        Me.vacuum.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.vacuum.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.vacuum.VariableName = "MAIN.InMoldDrying.TransferMold.Vacuum.Q"
        '
        'KL_TMVacuum
        '
        Me.KL_TMVacuum.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TMVacuum.ColorOn = System.Drawing.Color.Lime
        Me.KL_TMVacuum.Data = False
        Me.KL_TMVacuum.Line = True
        Me.KL_TMVacuum.LineSize = 1
        Me.KL_TMVacuum.Location = New System.Drawing.Point(10, 198)
        Me.KL_TMVacuum.Name = "KL_TMVacuum"
        Me.KL_TMVacuum.Size = New System.Drawing.Size(20, 20)
        Me.KL_TMVacuum.TabIndex = 292
        Me.KL_TMVacuum.Text = "KremerLight4"
        Me.KL_TMVacuum.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(68, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 20)
        Me.Label5.TabIndex = 291
        Me.Label5.Tag = ""
        Me.Label5.Text = "End switch A"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 20)
        Me.Label1.TabIndex = 293
        Me.Label1.Tag = ""
        Me.Label1.Text = "End switch B"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 20)
        Me.Label3.TabIndex = 295
        Me.Label3.Tag = ""
        Me.Label3.Text = "MSPA ready to operate"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.IO_TMHydraulicValve)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.KL_TMBlowOff)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.KL_TM_MSPAEnable)
        Me.GroupBox1.Controls.Add(Me.IO_TMABotSidePressure)
        Me.GroupBox1.Controls.Add(Me.KL_TMVacuum)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.IO_TMA_RodSidePressure)
        Me.GroupBox1.Controls.Add(Me.KL_TM_EsA)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.KL_TM_EsB)
        Me.GroupBox1.Controls.Add(Me.KL_TM_MspaRTO)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 429)
        Me.GroupBox1.TabIndex = 306
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transfermold"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(67, 259)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(181, 20)
        Me.Label10.TabIndex = 317
        Me.Label10.Tag = ""
        Me.Label10.Text = "Hydraulic valve"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(242, 20)
        Me.Label9.TabIndex = 315
        Me.Label9.Tag = ""
        Me.Label9.Text = "Analog Outputs"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(242, 20)
        Me.Label8.TabIndex = 314
        Me.Label8.Tag = ""
        Me.Label8.Text = "Outputs"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(241, 20)
        Me.Label4.TabIndex = 313
        Me.Label4.Tag = ""
        Me.Label4.Text = "Analog inputs"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 20)
        Me.Label2.TabIndex = 295
        Me.Label2.Tag = ""
        Me.Label2.Text = "MSPA enable"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(68, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(180, 20)
        Me.Label11.TabIndex = 309
        Me.Label11.Tag = ""
        Me.Label11.Text = "Rod side pressure"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(67, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 20)
        Me.Label6.TabIndex = 293
        Me.Label6.Tag = ""
        Me.Label6.Text = "Vacuum"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(67, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 20)
        Me.Label7.TabIndex = 291
        Me.Label7.Tag = ""
        Me.Label7.Text = "Blowoff"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(68, 132)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(181, 20)
        Me.Label13.TabIndex = 310
        Me.Label13.Tag = ""
        Me.Label13.Text = "Bot side pressure"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IO_TransferMold
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "IO_TransferMold"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "504"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents KL_TM_EsB As KremerControlsWin32.KremerLight
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents KL_TM_EsA As KremerControlsWin32.KremerLight
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents KL_TM_MspaRTO As KremerControlsWin32.KremerLight
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents IO_TMABotSidePressure As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_TMA_RodSidePressure As KremerControlsWin32.KremerIoField
    Friend WithEvents KL_TMBlowOff As KremerControlsWin32.KremerLight
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents KL_TM_MSPAEnable As KremerControlsWin32.KremerLight
    Friend WithEvents KL_TMVacuum As KremerControlsWin32.KremerLight
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents IO_TMHydraulicValve As KremerControlsWin32.KremerIoField
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TMA_EsA As KremerControlsWin32.KremerVariable
    Friend WithEvents TMA_EsB As KremerControlsWin32.KremerVariable
    Friend WithEvents TMA_MspaRTO As KremerControlsWin32.KremerVariable
    Friend WithEvents TMA_Rod As KremerControlsWin32.KremerVariable
    Friend WithEvents TMA_Bot As KremerControlsWin32.KremerVariable
    Friend WithEvents TMA_HydraulicValve As KremerControlsWin32.KremerVariable
    Friend WithEvents TMA_MspaEn As KremerControlsWin32.KremerVariable
    Friend WithEvents blowoff As KremerControlsWin32.KremerVariable
    Friend WithEvents vacuum As KremerControlsWin32.KremerVariable

End Class
