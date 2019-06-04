<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IO_Hydraulics
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
        Me.IO_OilTemp = New KremerControlsWin32.KremerIoField(Me.components)
        Me.KL_24V = New KremerControlsWin32.KremerLight()
        Me.KL_CabinetCoolerErr = New KremerControlsWin32.KremerLight()
        Me.KL_T40 = New KremerControlsWin32.KremerLight()
        Me.KL_T55 = New KremerControlsWin32.KremerLight()
        Me.KL_TempHigh = New KremerControlsWin32.KremerLight()
        Me.KL_P75 = New KremerControlsWin32.KremerLight()
        Me.KL_P100 = New KremerControlsWin32.KremerLight()
        Me.KL_Aux75 = New KremerControlsWin32.KremerLight()
        Me.KL_Aux100 = New KremerControlsWin32.KremerLight()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.KL_OilLvlLow = New KremerControlsWin32.KremerLight()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.KL_OilLvlTooLow = New KremerControlsWin32.KremerLight()
        Me.KL_PmpSSerr = New KremerControlsWin32.KremerLight()
        Me.KL_PmpMaint = New KremerControlsWin32.KremerLight()
        Me.KL_PmpRunning = New KremerControlsWin32.KremerLight()
        Me.KL_FilterThermal = New KremerControlsWin32.KremerLight()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.KL_FilterMaint = New KremerControlsWin32.KremerLight()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.KL_CoolingMotMaint = New KremerControlsWin32.KremerLight()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.KL_CoolingMotThermal = New KremerControlsWin32.KremerLight()
        Me.KL_HydraulicPmp = New KremerControlsWin32.KremerLight()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.KL_CoolinFan = New KremerControlsWin32.KremerLight()
        Me.KL_FiltMotor = New KremerControlsWin32.KremerLight()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.KL_PressurizePumpValve = New KremerControlsWin32.KremerLight()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.KL_IsolationValve = New KremerControlsWin32.KremerLight()
        Me.KL_AccuDrainValve = New KremerControlsWin32.KremerLight()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.IO_SysPress = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Cabinet24V = New KremerControlsWin32.KremerVariable(Me.components)
        Me.CabinetCoolerErr = New KremerControlsWin32.KremerVariable(Me.components)
        Me.T40c = New KremerControlsWin32.KremerVariable(Me.components)
        Me.T55c = New KremerControlsWin32.KremerVariable(Me.components)
        Me.P75 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.P100 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Aux75 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Aux100 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.OilTooLow = New KremerControlsWin32.KremerVariable(Me.components)
        Me.OilLow = New KremerControlsWin32.KremerVariable(Me.components)
        Me.PmpSSFail = New KremerControlsWin32.KremerVariable(Me.components)
        Me.PmpMaint = New KremerControlsWin32.KremerVariable(Me.components)
        Me.PmpRunning = New KremerControlsWin32.KremerVariable(Me.components)
        Me.FiltThermal = New KremerControlsWin32.KremerVariable(Me.components)
        Me.FiltMaint = New KremerControlsWin32.KremerVariable(Me.components)
        Me.CoolingTherm = New KremerControlsWin32.KremerVariable(Me.components)
        Me.CoolingMaint = New KremerControlsWin32.KremerVariable(Me.components)
        Me.HydraulicPmp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.FiltMotor = New KremerControlsWin32.KremerVariable(Me.components)
        Me.CoolingFan = New KremerControlsWin32.KremerVariable(Me.components)
        Me.PressurizePumpValve = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AccuDrainValve = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IsolationValve = New KremerControlsWin32.KremerVariable(Me.components)
        Me.OilTemp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.MainSysPress = New KremerControlsWin32.KremerVariable(Me.components)
        Me.TempToHigh = New KremerControlsWin32.KremerVariable(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.OilTemp)
        Me.VarCollector.Variables.Add(Me.MainSysPress)
        Me.VarCollector.Variables.Add(Me.Cabinet24V)
        Me.VarCollector.Variables.Add(Me.CabinetCoolerErr)
        Me.VarCollector.Variables.Add(Me.T40c)
        Me.VarCollector.Variables.Add(Me.T55c)
        Me.VarCollector.Variables.Add(Me.TempToHigh)
        Me.VarCollector.Variables.Add(Me.P75)
        Me.VarCollector.Variables.Add(Me.P100)
        Me.VarCollector.Variables.Add(Me.Aux75)
        Me.VarCollector.Variables.Add(Me.Aux100)
        Me.VarCollector.Variables.Add(Me.OilTooLow)
        Me.VarCollector.Variables.Add(Me.OilLow)
        Me.VarCollector.Variables.Add(Me.PmpSSFail)
        Me.VarCollector.Variables.Add(Me.PmpMaint)
        Me.VarCollector.Variables.Add(Me.PmpRunning)
        Me.VarCollector.Variables.Add(Me.FiltThermal)
        Me.VarCollector.Variables.Add(Me.FiltMaint)
        Me.VarCollector.Variables.Add(Me.CoolingTherm)
        Me.VarCollector.Variables.Add(Me.CoolingMaint)
        Me.VarCollector.Variables.Add(Me.HydraulicPmp)
        Me.VarCollector.Variables.Add(Me.FiltMotor)
        Me.VarCollector.Variables.Add(Me.CoolingFan)
        Me.VarCollector.Variables.Add(Me.PressurizePumpValve)
        Me.VarCollector.Variables.Add(Me.AccuDrainValve)
        Me.VarCollector.Variables.Add(Me.IsolationValve)
        '
        'IO_OilTemp
        '
        Me.IO_OilTemp.Audit = Nothing
        Me.IO_OilTemp.AuditEnabled = False
        Me.IO_OilTemp.AuditMessage = "KremerIoField changed:"
        Me.IO_OilTemp.AuditSource = "KremerIoField"
        Me.IO_OilTemp.AutoSize = True
        Me.IO_OilTemp.Data = 0.0R
        Me.IO_OilTemp.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_OilTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_OilTemp.InitialValue = True
        Me.IO_OilTemp.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_OilTemp.Location = New System.Drawing.Point(7, 37)
        Me.IO_OilTemp.LowerBound = 0.0R
        Me.IO_OilTemp.Name = "IO_OilTemp"
        Me.IO_OilTemp.OutputFormat = "0.0 "
        Me.IO_OilTemp.Size = New System.Drawing.Size(28, 16)
        Me.IO_OilTemp.TabIndex = 316
        Me.IO_OilTemp.Text = "0.0 "
        Me.IO_OilTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_OilTemp.UpperBound = 1000.0R
        Me.IO_OilTemp.UserInfo = Nothing
        Me.IO_OilTemp.UserLevel = 0
        '
        'KL_24V
        '
        Me.KL_24V.ColorOff = System.Drawing.Color.Red
        Me.KL_24V.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_24V.Data = False
        Me.KL_24V.Line = True
        Me.KL_24V.LineSize = 1
        Me.KL_24V.Location = New System.Drawing.Point(10, 25)
        Me.KL_24V.Name = "KL_24V"
        Me.KL_24V.Size = New System.Drawing.Size(20, 20)
        Me.KL_24V.TabIndex = 290
        Me.KL_24V.Text = "KL_24Err"
        Me.KL_24V.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_CabinetCoolerErr
        '
        Me.KL_CabinetCoolerErr.ColorOff = System.Drawing.Color.Red
        Me.KL_CabinetCoolerErr.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_CabinetCoolerErr.Data = False
        Me.KL_CabinetCoolerErr.Line = True
        Me.KL_CabinetCoolerErr.LineSize = 1
        Me.KL_CabinetCoolerErr.Location = New System.Drawing.Point(10, 46)
        Me.KL_CabinetCoolerErr.Name = "KL_CabinetCoolerErr"
        Me.KL_CabinetCoolerErr.Size = New System.Drawing.Size(20, 20)
        Me.KL_CabinetCoolerErr.TabIndex = 292
        Me.KL_CabinetCoolerErr.Text = "KL_CabinetCoolerErr"
        Me.KL_CabinetCoolerErr.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_T40
        '
        Me.KL_T40.ColorOff = System.Drawing.Color.Red
        Me.KL_T40.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_T40.Data = False
        Me.KL_T40.Line = True
        Me.KL_T40.LineSize = 1
        Me.KL_T40.Location = New System.Drawing.Point(10, 67)
        Me.KL_T40.Name = "KL_T40"
        Me.KL_T40.Size = New System.Drawing.Size(20, 20)
        Me.KL_T40.TabIndex = 294
        Me.KL_T40.Text = "KL_T40"
        Me.KL_T40.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_T55
        '
        Me.KL_T55.ColorOff = System.Drawing.Color.Red
        Me.KL_T55.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_T55.Data = False
        Me.KL_T55.Line = True
        Me.KL_T55.LineSize = 1
        Me.KL_T55.Location = New System.Drawing.Point(10, 87)
        Me.KL_T55.Name = "KL_T55"
        Me.KL_T55.Size = New System.Drawing.Size(20, 20)
        Me.KL_T55.TabIndex = 296
        Me.KL_T55.Text = "KremerLight2"
        Me.KL_T55.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_TempHigh
        '
        Me.KL_TempHigh.ColorOff = System.Drawing.Color.Red
        Me.KL_TempHigh.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_TempHigh.Data = False
        Me.KL_TempHigh.Line = True
        Me.KL_TempHigh.LineSize = 1
        Me.KL_TempHigh.Location = New System.Drawing.Point(10, 108)
        Me.KL_TempHigh.Name = "KL_TempHigh"
        Me.KL_TempHigh.Size = New System.Drawing.Size(20, 20)
        Me.KL_TempHigh.TabIndex = 298
        Me.KL_TempHigh.Text = "KremerLight9"
        Me.KL_TempHigh.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_P75
        '
        Me.KL_P75.ColorOff = System.Drawing.Color.Red
        Me.KL_P75.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_P75.Data = False
        Me.KL_P75.Line = True
        Me.KL_P75.LineSize = 1
        Me.KL_P75.Location = New System.Drawing.Point(10, 129)
        Me.KL_P75.Name = "KL_P75"
        Me.KL_P75.Size = New System.Drawing.Size(20, 20)
        Me.KL_P75.TabIndex = 300
        Me.KL_P75.Text = "KremerLight10"
        Me.KL_P75.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_P100
        '
        Me.KL_P100.ColorOff = System.Drawing.Color.Red
        Me.KL_P100.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_P100.Data = False
        Me.KL_P100.Line = True
        Me.KL_P100.LineSize = 1
        Me.KL_P100.Location = New System.Drawing.Point(10, 150)
        Me.KL_P100.Name = "KL_P100"
        Me.KL_P100.Size = New System.Drawing.Size(20, 20)
        Me.KL_P100.TabIndex = 302
        Me.KL_P100.Text = "KremerLight11"
        Me.KL_P100.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_Aux75
        '
        Me.KL_Aux75.ColorOff = System.Drawing.Color.Red
        Me.KL_Aux75.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_Aux75.Data = False
        Me.KL_Aux75.Line = True
        Me.KL_Aux75.LineSize = 1
        Me.KL_Aux75.Location = New System.Drawing.Point(10, 171)
        Me.KL_Aux75.Name = "KL_Aux75"
        Me.KL_Aux75.Size = New System.Drawing.Size(20, 20)
        Me.KL_Aux75.TabIndex = 304
        Me.KL_Aux75.Text = "KremerLight12"
        Me.KL_Aux75.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_Aux100
        '
        Me.KL_Aux100.ColorOff = System.Drawing.Color.Red
        Me.KL_Aux100.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_Aux100.Data = False
        Me.KL_Aux100.Line = True
        Me.KL_Aux100.LineSize = 1
        Me.KL_Aux100.Location = New System.Drawing.Point(10, 192)
        Me.KL_Aux100.Name = "KL_Aux100"
        Me.KL_Aux100.Size = New System.Drawing.Size(20, 20)
        Me.KL_Aux100.TabIndex = 306
        Me.KL_Aux100.Text = "KremerLight13"
        Me.KL_Aux100.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(68, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 20)
        Me.Label5.TabIndex = 291
        Me.Label5.Tag = ""
        Me.Label5.Text = "Cabinet 24V error"
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
        Me.Label1.Text = "Cabinet cooler error"
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
        Me.Label3.Text = "Temperature switch 40c"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.KL_CoolingMotMaint)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.KL_CoolingMotThermal)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.KL_FilterMaint)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.KL_OilLvlLow)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.KL_OilLvlTooLow)
        Me.GroupBox1.Controls.Add(Me.KL_PmpSSerr)
        Me.GroupBox1.Controls.Add(Me.KL_PmpMaint)
        Me.GroupBox1.Controls.Add(Me.KL_PmpRunning)
        Me.GroupBox1.Controls.Add(Me.KL_FilterThermal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.KL_TempHigh)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.KL_24V)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.KL_CabinetCoolerErr)
        Me.GroupBox1.Controls.Add(Me.KL_T40)
        Me.GroupBox1.Controls.Add(Me.KL_T55)
        Me.GroupBox1.Controls.Add(Me.KL_P75)
        Me.GroupBox1.Controls.Add(Me.KL_P100)
        Me.GroupBox1.Controls.Add(Me.KL_Aux75)
        Me.GroupBox1.Controls.Add(Me.KL_Aux100)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 429)
        Me.GroupBox1.TabIndex = 306
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hydraulics inputs"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(68, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(181, 20)
        Me.Label12.TabIndex = 297
        Me.Label12.Tag = ""
        Me.Label12.Text = "Temperature switch 55c"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(68, 192)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(181, 20)
        Me.Label19.TabIndex = 307
        Me.Label19.Tag = ""
        Me.Label19.Text = "Aux filter 100"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(68, 171)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(181, 20)
        Me.Label18.TabIndex = 305
        Me.Label18.Tag = ""
        Me.Label18.Text = "Aux filter 75"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(68, 150)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(181, 20)
        Me.Label17.TabIndex = 303
        Me.Label17.Tag = ""
        Me.Label17.Text = "Pressure filter 100"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(68, 129)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(181, 20)
        Me.Label16.TabIndex = 301
        Me.Label16.Tag = ""
        Me.Label16.Text = "Pressure filter 75"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(68, 108)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(181, 20)
        Me.Label15.TabIndex = 299
        Me.Label15.Tag = ""
        Me.Label15.Text = "Temperature too high"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.KL_PressurizePumpValve)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.KL_IsolationValve)
        Me.GroupBox2.Controls.Add(Me.KL_AccuDrainValve)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.KL_HydraulicPmp)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.KL_CoolinFan)
        Me.GroupBox2.Controls.Add(Me.KL_FiltMotor)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(267, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 212)
        Me.GroupBox2.TabIndex = 318
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hydraulic outputs"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(68, 33)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(181, 20)
        Me.Label20.TabIndex = 317
        Me.Label20.Tag = ""
        Me.Label20.Text = "Oil Temperature"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 20)
        Me.Label2.TabIndex = 309
        Me.Label2.Tag = ""
        Me.Label2.Text = "Oil level too low"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(68, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 20)
        Me.Label4.TabIndex = 319
        Me.Label4.Tag = ""
        Me.Label4.Text = "Filter motor thermal"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_OilLvlLow
        '
        Me.KL_OilLvlLow.ColorOff = System.Drawing.Color.Red
        Me.KL_OilLvlLow.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_OilLvlLow.Data = False
        Me.KL_OilLvlLow.Line = True
        Me.KL_OilLvlLow.LineSize = 1
        Me.KL_OilLvlLow.Location = New System.Drawing.Point(10, 233)
        Me.KL_OilLvlLow.Name = "KL_OilLvlLow"
        Me.KL_OilLvlLow.Size = New System.Drawing.Size(20, 20)
        Me.KL_OilLvlLow.TabIndex = 310
        Me.KL_OilLvlLow.Text = "KremerLight9"
        Me.KL_OilLvlLow.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(68, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 20)
        Me.Label6.TabIndex = 317
        Me.Label6.Tag = ""
        Me.Label6.Text = "Pump is running"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(68, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 20)
        Me.Label7.TabIndex = 315
        Me.Label7.Tag = ""
        Me.Label7.Text = "Pump maintenance switch"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(68, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 20)
        Me.Label8.TabIndex = 313
        Me.Label8.Tag = ""
        Me.Label8.Text = "Pump softstarter failure"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(68, 233)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(181, 20)
        Me.Label9.TabIndex = 311
        Me.Label9.Tag = ""
        Me.Label9.Text = "Oil level low"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_OilLvlTooLow
        '
        Me.KL_OilLvlTooLow.ColorOff = System.Drawing.Color.Red
        Me.KL_OilLvlTooLow.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_OilLvlTooLow.Data = False
        Me.KL_OilLvlTooLow.Line = True
        Me.KL_OilLvlTooLow.LineSize = 1
        Me.KL_OilLvlTooLow.Location = New System.Drawing.Point(10, 212)
        Me.KL_OilLvlTooLow.Name = "KL_OilLvlTooLow"
        Me.KL_OilLvlTooLow.Size = New System.Drawing.Size(20, 20)
        Me.KL_OilLvlTooLow.TabIndex = 308
        Me.KL_OilLvlTooLow.Text = "KremerLight2"
        Me.KL_OilLvlTooLow.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_PmpSSerr
        '
        Me.KL_PmpSSerr.ColorOff = System.Drawing.Color.Red
        Me.KL_PmpSSerr.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_PmpSSerr.Data = False
        Me.KL_PmpSSerr.Line = True
        Me.KL_PmpSSerr.LineSize = 1
        Me.KL_PmpSSerr.Location = New System.Drawing.Point(10, 254)
        Me.KL_PmpSSerr.Name = "KL_PmpSSerr"
        Me.KL_PmpSSerr.Size = New System.Drawing.Size(20, 20)
        Me.KL_PmpSSerr.TabIndex = 312
        Me.KL_PmpSSerr.Text = "KremerLight10"
        Me.KL_PmpSSerr.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_PmpMaint
        '
        Me.KL_PmpMaint.ColorOff = System.Drawing.Color.Red
        Me.KL_PmpMaint.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_PmpMaint.Data = False
        Me.KL_PmpMaint.Line = True
        Me.KL_PmpMaint.LineSize = 1
        Me.KL_PmpMaint.Location = New System.Drawing.Point(10, 275)
        Me.KL_PmpMaint.Name = "KL_PmpMaint"
        Me.KL_PmpMaint.Size = New System.Drawing.Size(20, 20)
        Me.KL_PmpMaint.TabIndex = 314
        Me.KL_PmpMaint.Text = "KremerLight11"
        Me.KL_PmpMaint.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_PmpRunning
        '
        Me.KL_PmpRunning.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_PmpRunning.ColorOn = System.Drawing.Color.Lime
        Me.KL_PmpRunning.Data = False
        Me.KL_PmpRunning.Line = True
        Me.KL_PmpRunning.LineSize = 1
        Me.KL_PmpRunning.Location = New System.Drawing.Point(10, 296)
        Me.KL_PmpRunning.Name = "KL_PmpRunning"
        Me.KL_PmpRunning.Size = New System.Drawing.Size(20, 20)
        Me.KL_PmpRunning.TabIndex = 316
        Me.KL_PmpRunning.Text = "KremerLight12"
        Me.KL_PmpRunning.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_FilterThermal
        '
        Me.KL_FilterThermal.ColorOff = System.Drawing.Color.Red
        Me.KL_FilterThermal.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_FilterThermal.Data = False
        Me.KL_FilterThermal.Line = True
        Me.KL_FilterThermal.LineSize = 1
        Me.KL_FilterThermal.Location = New System.Drawing.Point(10, 317)
        Me.KL_FilterThermal.Name = "KL_FilterThermal"
        Me.KL_FilterThermal.Size = New System.Drawing.Size(20, 20)
        Me.KL_FilterThermal.TabIndex = 318
        Me.KL_FilterThermal.Text = "KremerLight13"
        Me.KL_FilterThermal.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(68, 337)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(181, 20)
        Me.Label10.TabIndex = 321
        Me.Label10.Tag = ""
        Me.Label10.Text = "Filter motor maintenance switch"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_FilterMaint
        '
        Me.KL_FilterMaint.ColorOff = System.Drawing.Color.Red
        Me.KL_FilterMaint.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_FilterMaint.Data = False
        Me.KL_FilterMaint.Line = True
        Me.KL_FilterMaint.LineSize = 1
        Me.KL_FilterMaint.Location = New System.Drawing.Point(10, 337)
        Me.KL_FilterMaint.Name = "KL_FilterMaint"
        Me.KL_FilterMaint.Size = New System.Drawing.Size(20, 20)
        Me.KL_FilterMaint.TabIndex = 320
        Me.KL_FilterMaint.Text = "KremerLight13"
        Me.KL_FilterMaint.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(68, 377)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(181, 20)
        Me.Label11.TabIndex = 325
        Me.Label11.Tag = ""
        Me.Label11.Text = "Cooling motor maint. switch"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_CoolingMotMaint
        '
        Me.KL_CoolingMotMaint.ColorOff = System.Drawing.Color.Red
        Me.KL_CoolingMotMaint.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_CoolingMotMaint.Data = False
        Me.KL_CoolingMotMaint.Line = True
        Me.KL_CoolingMotMaint.LineSize = 1
        Me.KL_CoolingMotMaint.Location = New System.Drawing.Point(10, 377)
        Me.KL_CoolingMotMaint.Name = "KL_CoolingMotMaint"
        Me.KL_CoolingMotMaint.Size = New System.Drawing.Size(20, 20)
        Me.KL_CoolingMotMaint.TabIndex = 324
        Me.KL_CoolingMotMaint.Text = "KremerLight13"
        Me.KL_CoolingMotMaint.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(68, 357)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(181, 20)
        Me.Label13.TabIndex = 323
        Me.Label13.Tag = ""
        Me.Label13.Text = "Cooling motor thermal"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_CoolingMotThermal
        '
        Me.KL_CoolingMotThermal.ColorOff = System.Drawing.Color.Red
        Me.KL_CoolingMotThermal.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_CoolingMotThermal.Data = False
        Me.KL_CoolingMotThermal.Line = True
        Me.KL_CoolingMotThermal.LineSize = 1
        Me.KL_CoolingMotThermal.Location = New System.Drawing.Point(10, 357)
        Me.KL_CoolingMotThermal.Name = "KL_CoolingMotThermal"
        Me.KL_CoolingMotThermal.Size = New System.Drawing.Size(20, 20)
        Me.KL_CoolingMotThermal.TabIndex = 322
        Me.KL_CoolingMotThermal.Text = "KremerLight13"
        Me.KL_CoolingMotThermal.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_HydraulicPmp
        '
        Me.KL_HydraulicPmp.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_HydraulicPmp.ColorOn = System.Drawing.Color.Lime
        Me.KL_HydraulicPmp.Data = False
        Me.KL_HydraulicPmp.Line = True
        Me.KL_HydraulicPmp.LineSize = 1
        Me.KL_HydraulicPmp.Location = New System.Drawing.Point(10, 25)
        Me.KL_HydraulicPmp.Name = "KL_HydraulicPmp"
        Me.KL_HydraulicPmp.Size = New System.Drawing.Size(20, 20)
        Me.KL_HydraulicPmp.TabIndex = 318
        Me.KL_HydraulicPmp.Text = "KremerLight2"
        Me.KL_HydraulicPmp.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(67, 66)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(181, 20)
        Me.Label24.TabIndex = 323
        Me.Label24.Tag = ""
        Me.Label24.Text = "Cooling fan"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(67, 45)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(181, 20)
        Me.Label26.TabIndex = 321
        Me.Label26.Tag = ""
        Me.Label26.Text = "Filter motor"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_CoolinFan
        '
        Me.KL_CoolinFan.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_CoolinFan.ColorOn = System.Drawing.Color.Lime
        Me.KL_CoolinFan.Data = False
        Me.KL_CoolinFan.Line = True
        Me.KL_CoolinFan.LineSize = 1
        Me.KL_CoolinFan.Location = New System.Drawing.Point(10, 65)
        Me.KL_CoolinFan.Name = "KL_CoolinFan"
        Me.KL_CoolinFan.Size = New System.Drawing.Size(20, 20)
        Me.KL_CoolinFan.TabIndex = 322
        Me.KL_CoolinFan.Text = "KremerLight3"
        Me.KL_CoolinFan.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_FiltMotor
        '
        Me.KL_FiltMotor.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_FiltMotor.ColorOn = System.Drawing.Color.Lime
        Me.KL_FiltMotor.Data = False
        Me.KL_FiltMotor.Line = True
        Me.KL_FiltMotor.LineSize = 1
        Me.KL_FiltMotor.Location = New System.Drawing.Point(10, 45)
        Me.KL_FiltMotor.Name = "KL_FiltMotor"
        Me.KL_FiltMotor.Size = New System.Drawing.Size(20, 20)
        Me.KL_FiltMotor.TabIndex = 320
        Me.KL_FiltMotor.Text = "KremerLight4"
        Me.KL_FiltMotor.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(67, 25)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(181, 20)
        Me.Label29.TabIndex = 319
        Me.Label29.Tag = ""
        Me.Label29.Text = "Hydraulic pump"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_PressurizePumpValve
        '
        Me.KL_PressurizePumpValve.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_PressurizePumpValve.ColorOn = System.Drawing.Color.Lime
        Me.KL_PressurizePumpValve.Data = False
        Me.KL_PressurizePumpValve.Line = True
        Me.KL_PressurizePumpValve.LineSize = 1
        Me.KL_PressurizePumpValve.Location = New System.Drawing.Point(10, 87)
        Me.KL_PressurizePumpValve.Name = "KL_PressurizePumpValve"
        Me.KL_PressurizePumpValve.Size = New System.Drawing.Size(20, 20)
        Me.KL_PressurizePumpValve.TabIndex = 324
        Me.KL_PressurizePumpValve.Text = "KremerLight2"
        Me.KL_PressurizePumpValve.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(67, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(181, 20)
        Me.Label14.TabIndex = 329
        Me.Label14.Tag = ""
        Me.Label14.Text = "Isolation valve"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(67, 107)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(181, 20)
        Me.Label22.TabIndex = 327
        Me.Label22.Tag = ""
        Me.Label22.Text = "Accu drain valve"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_IsolationValve
        '
        Me.KL_IsolationValve.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_IsolationValve.ColorOn = System.Drawing.Color.Lime
        Me.KL_IsolationValve.Data = False
        Me.KL_IsolationValve.Line = True
        Me.KL_IsolationValve.LineSize = 1
        Me.KL_IsolationValve.Location = New System.Drawing.Point(10, 127)
        Me.KL_IsolationValve.Name = "KL_IsolationValve"
        Me.KL_IsolationValve.Size = New System.Drawing.Size(20, 20)
        Me.KL_IsolationValve.TabIndex = 328
        Me.KL_IsolationValve.Text = "KremerLight3"
        Me.KL_IsolationValve.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_AccuDrainValve
        '
        Me.KL_AccuDrainValve.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_AccuDrainValve.ColorOn = System.Drawing.Color.Lime
        Me.KL_AccuDrainValve.Data = False
        Me.KL_AccuDrainValve.Line = True
        Me.KL_AccuDrainValve.LineSize = 1
        Me.KL_AccuDrainValve.Location = New System.Drawing.Point(10, 107)
        Me.KL_AccuDrainValve.Name = "KL_AccuDrainValve"
        Me.KL_AccuDrainValve.Size = New System.Drawing.Size(20, 20)
        Me.KL_AccuDrainValve.TabIndex = 326
        Me.KL_AccuDrainValve.Text = "KremerLight4"
        Me.KL_AccuDrainValve.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(67, 87)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(181, 20)
        Me.Label23.TabIndex = 325
        Me.Label23.Tag = ""
        Me.Label23.Text = "Pressurize pump valve"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.IO_SysPress)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.IO_OilTemp)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(267, 220)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(258, 212)
        Me.GroupBox3.TabIndex = 330
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hydraulic Analog inputs"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(68, 53)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(181, 20)
        Me.Label21.TabIndex = 319
        Me.Label21.Tag = ""
        Me.Label21.Text = "Main system pressure"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IO_SysPress
        '
        Me.IO_SysPress.Audit = Nothing
        Me.IO_SysPress.AuditEnabled = False
        Me.IO_SysPress.AuditMessage = "KremerIoField changed:"
        Me.IO_SysPress.AuditSource = "KremerIoField"
        Me.IO_SysPress.AutoSize = True
        Me.IO_SysPress.Data = 0.0R
        Me.IO_SysPress.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_SysPress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_SysPress.InitialValue = True
        Me.IO_SysPress.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_SysPress.Location = New System.Drawing.Point(7, 57)
        Me.IO_SysPress.LowerBound = 0.0R
        Me.IO_SysPress.Name = "IO_SysPress"
        Me.IO_SysPress.OutputFormat = "0.0 "
        Me.IO_SysPress.Size = New System.Drawing.Size(28, 16)
        Me.IO_SysPress.TabIndex = 318
        Me.IO_SysPress.Text = "0.0 "
        Me.IO_SysPress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_SysPress.UpperBound = 1000.0R
        Me.IO_SysPress.UserInfo = Nothing
        Me.IO_SysPress.UserLevel = 0
        '
        'Cabinet24V
        '
        Me.Cabinet24V.BindControl = Me.KL_24V
        Me.Cabinet24V.BindProperty = "Data"
        Me.Cabinet24V.Data = Nothing
        Me.Cabinet24V.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Cabinet24V.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Cabinet24V.VariableName = "MAIN.InMoldDrying.HydraulicsMain.ixHydraulicsMcc24vError"
        '
        'CabinetCoolerErr
        '
        Me.CabinetCoolerErr.BindControl = Me.KL_CabinetCoolerErr
        Me.CabinetCoolerErr.BindProperty = "Data"
        Me.CabinetCoolerErr.Data = Nothing
        Me.CabinetCoolerErr.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.CabinetCoolerErr.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.CabinetCoolerErr.VariableName = "MAIN.InMoldDrying.HydraulicsMain.ixCabinetCoolerError"
        '
        'T40c
        '
        Me.T40c.BindControl = Me.KL_T40
        Me.T40c.BindProperty = "Data"
        Me.T40c.Data = Nothing
        Me.T40c.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.T40c.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.T40c.VariableName = "MAIN.InMoldDrying.HydraulicsMain.ixTemperatureSwitch40c"
        '
        'T55c
        '
        Me.T55c.BindControl = Me.KL_T55
        Me.T55c.BindProperty = "Data"
        Me.T55c.Data = Nothing
        Me.T55c.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.T55c.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.T55c.VariableName = "MAIN.InMoldDrying.HydraulicsMain.ixTemperatureSwitch55c"
        '
        'P75
        '
        Me.P75.BindControl = Me.KL_P75
        Me.P75.BindProperty = "Data"
        Me.P75.Data = Nothing
        Me.P75.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.P75.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.P75.VariableName = "MAIN.InMoldDrying.HydraulicsMain.ixPressureFilterAt75"
        '
        'P100
        '
        Me.P100.BindControl = Me.KL_P100
        Me.P100.BindProperty = "Data"
        Me.P100.Data = Nothing
        Me.P100.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.P100.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.P100.VariableName = "MAIN.InMoldDrying.HydraulicsMain.ixPressureFilterAt100"
        '
        'Aux75
        '
        Me.Aux75.BindControl = Me.KL_Aux75
        Me.Aux75.BindProperty = "Data"
        Me.Aux75.Data = Nothing
        Me.Aux75.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Aux75.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Aux75.VariableName = "MAIN.InMoldDrying.HydraulicsMain.ixAuxFilterAt75"
        '
        'Aux100
        '
        Me.Aux100.BindControl = Me.KL_Aux100
        Me.Aux100.BindProperty = "Data"
        Me.Aux100.Data = Nothing
        Me.Aux100.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Aux100.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Aux100.VariableName = "MAIN.InMoldDrying.HydraulicsMain.ixAuxFilterAt100"
        '
        'OilTooLow
        '
        Me.OilTooLow.BindControl = Me.KL_OilLvlTooLow
        Me.OilTooLow.BindProperty = "Data"
        Me.OilTooLow.Data = Nothing
        Me.OilTooLow.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.OilTooLow.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.OilTooLow.VariableName = "MAIN.InMoldDrying.HydraulicsMain.ixOilLvlTooLow"
        '
        'OilLow
        '
        Me.OilLow.BindControl = Me.KL_OilLvlLow
        Me.OilLow.BindProperty = "Data"
        Me.OilLow.Data = Nothing
        Me.OilLow.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.OilLow.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.OilLow.VariableName = "MAIN.InMoldDrying.HydraulicsMain.ixOilLvlLow"
        '
        'PmpSSFail
        '
        Me.PmpSSFail.BindControl = Me.KL_PmpSSerr
        Me.PmpSSFail.BindProperty = "Data"
        Me.PmpSSFail.Data = Nothing
        Me.PmpSSFail.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PmpSSFail.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PmpSSFail.VariableName = "MAIN.InMoldDrying.HydraulicsMain.HydraulicPump.ixSSFailure"
        '
        'PmpMaint
        '
        Me.PmpMaint.BindControl = Me.KL_PmpMaint
        Me.PmpMaint.BindProperty = "Data"
        Me.PmpMaint.Data = Nothing
        Me.PmpMaint.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PmpMaint.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PmpMaint.VariableName = "MAIN.InMoldDrying.HydraulicsMain.HydraulicPump.ixMaintenance"
        '
        'PmpRunning
        '
        Me.PmpRunning.BindControl = Me.KL_PmpRunning
        Me.PmpRunning.BindProperty = "Data"
        Me.PmpRunning.Data = Nothing
        Me.PmpRunning.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PmpRunning.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PmpRunning.VariableName = "MAIN.InMoldDrying.HydraulicsMain.HydraulicPump.ixIsRunning"
        '
        'FiltThermal
        '
        Me.FiltThermal.BindControl = Me.KL_FilterThermal
        Me.FiltThermal.BindProperty = "Data"
        Me.FiltThermal.Data = Nothing
        Me.FiltThermal.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.FiltThermal.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FiltThermal.VariableName = "MAIN.InMoldDrying.HydraulicsMain.FilterMotor.ixThermal"
        '
        'FiltMaint
        '
        Me.FiltMaint.BindControl = Me.KL_FilterMaint
        Me.FiltMaint.BindProperty = "Data"
        Me.FiltMaint.Data = Nothing
        Me.FiltMaint.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.FiltMaint.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FiltMaint.VariableName = "MAIN.InMoldDrying.HydraulicsMain.FilterMotor.ixMaintenance"
        '
        'CoolingTherm
        '
        Me.CoolingTherm.BindControl = Me.KL_CoolingMotThermal
        Me.CoolingTherm.BindProperty = "Data"
        Me.CoolingTherm.Data = Nothing
        Me.CoolingTherm.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.CoolingTherm.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.CoolingTherm.VariableName = "MAIN.InMoldDrying.HydraulicsMain.CoolingFan.ixThermal"
        '
        'CoolingMaint
        '
        Me.CoolingMaint.BindControl = Me.KL_CoolingMotMaint
        Me.CoolingMaint.BindProperty = "Data"
        Me.CoolingMaint.Data = Nothing
        Me.CoolingMaint.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.CoolingMaint.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.CoolingMaint.VariableName = "MAIN.InMoldDrying.HydraulicsMain.CoolingFan.ixMaintenance"
        '
        'HydraulicPmp
        '
        Me.HydraulicPmp.BindControl = Me.KL_HydraulicPmp
        Me.HydraulicPmp.BindProperty = "Data"
        Me.HydraulicPmp.Data = Nothing
        Me.HydraulicPmp.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.HydraulicPmp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.HydraulicPmp.VariableName = "MAIN.InMoldDrying.HydraulicsMain.HydraulicPump.Q"
        '
        'FiltMotor
        '
        Me.FiltMotor.BindControl = Me.KL_FiltMotor
        Me.FiltMotor.BindProperty = "Data"
        Me.FiltMotor.Data = Nothing
        Me.FiltMotor.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.FiltMotor.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FiltMotor.VariableName = "MAIN.InMoldDrying.HydraulicsMain.FilterMotor.Q"
        '
        'CoolingFan
        '
        Me.CoolingFan.BindControl = Me.KL_CoolinFan
        Me.CoolingFan.BindProperty = "Data"
        Me.CoolingFan.Data = Nothing
        Me.CoolingFan.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.CoolingFan.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.CoolingFan.VariableName = "MAIN.InMoldDrying.HydraulicsMain.CoolingFan.Q"
        '
        'PressurizePumpValve
        '
        Me.PressurizePumpValve.BindControl = Me.KL_PressurizePumpValve
        Me.PressurizePumpValve.BindProperty = "Data"
        Me.PressurizePumpValve.Data = Nothing
        Me.PressurizePumpValve.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PressurizePumpValve.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PressurizePumpValve.VariableName = "MAIN.InMoldDrying.HydraulicsMain.PressurizePumpValve.Q"
        '
        'AccuDrainValve
        '
        Me.AccuDrainValve.BindControl = Me.KL_AccuDrainValve
        Me.AccuDrainValve.BindProperty = "Data"
        Me.AccuDrainValve.Data = Nothing
        Me.AccuDrainValve.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.AccuDrainValve.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AccuDrainValve.VariableName = "MAIN.InMoldDrying.HydraulicsMain.AccuDrainValve.Q"
        '
        'IsolationValve
        '
        Me.IsolationValve.BindControl = Me.KL_IsolationValve
        Me.IsolationValve.BindProperty = "Data"
        Me.IsolationValve.Data = Nothing
        Me.IsolationValve.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.IsolationValve.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.IsolationValve.VariableName = "MAIN.InMoldDrying.HydraulicsMain.IsolationValve.Q"
        '
        'OilTemp
        '
        Me.OilTemp.BindControl = Me.IO_OilTemp
        Me.OilTemp.BindProperty = "Data"
        Me.OilTemp.Data = Nothing
        Me.OilTemp.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.OilTemp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.OilTemp.VariableName = "MAIN.InMoldDrying.HydraulicsMain.OilTemperature.RawInput"
        '
        'MainSysPress
        '
        Me.MainSysPress.BindControl = Me.IO_SysPress
        Me.MainSysPress.BindProperty = "Data"
        Me.MainSysPress.Data = Nothing
        Me.MainSysPress.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.MainSysPress.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.MainSysPress.VariableName = "MAIN.InMoldDrying.HydraulicsMain.MainSystemPressure.RawInput"
        '
        'TempToHigh
        '
        Me.TempToHigh.BindControl = Me.KL_TempHigh
        Me.TempToHigh.BindProperty = "Data"
        Me.TempToHigh.Data = Nothing
        Me.TempToHigh.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TempToHigh.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TempToHigh.VariableName = "MAIN.InMoldDrying.HydraulicsMain.ixTemperatureSwitchTooHigh"
        '
        'IO_Hydraulics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "IO_Hydraulics"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "540"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents KL_CabinetCoolerErr As KremerControlsWin32.KremerLight
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents KL_24V As KremerControlsWin32.KremerLight
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents KL_T40 As KremerControlsWin32.KremerLight
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents KL_P100 As KremerControlsWin32.KremerLight
    Friend WithEvents KL_Aux75 As KremerControlsWin32.KremerLight
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents KL_Aux100 As KremerControlsWin32.KremerLight
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents KL_T55 As KremerControlsWin32.KremerLight
    Friend WithEvents KL_TempHigh As KremerControlsWin32.KremerLight
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents KL_P75 As KremerControlsWin32.KremerLight
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents IO_OilTemp As KremerControlsWin32.KremerIoField
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents KL_CoolingMotMaint As KremerControlsWin32.KremerLight
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents KL_CoolingMotThermal As KremerControlsWin32.KremerLight
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents KL_FilterMaint As KremerControlsWin32.KremerLight
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents KL_OilLvlLow As KremerControlsWin32.KremerLight
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents KL_OilLvlTooLow As KremerControlsWin32.KremerLight
    Friend WithEvents KL_PmpSSerr As KremerControlsWin32.KremerLight
    Friend WithEvents KL_PmpMaint As KremerControlsWin32.KremerLight
    Friend WithEvents KL_PmpRunning As KremerControlsWin32.KremerLight
    Friend WithEvents KL_FilterThermal As KremerControlsWin32.KremerLight
    Friend WithEvents KL_PressurizePumpValve As KremerControlsWin32.KremerLight
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents KL_IsolationValve As KremerControlsWin32.KremerLight
    Friend WithEvents KL_AccuDrainValve As KremerControlsWin32.KremerLight
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents KL_HydraulicPmp As KremerControlsWin32.KremerLight
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents KL_CoolinFan As KremerControlsWin32.KremerLight
    Friend WithEvents KL_FiltMotor As KremerControlsWin32.KremerLight
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents IO_SysPress As KremerControlsWin32.KremerIoField
    Friend WithEvents Cabinet24V As KremerControlsWin32.KremerVariable
    Friend WithEvents CabinetCoolerErr As KremerControlsWin32.KremerVariable
    Friend WithEvents T40c As KremerControlsWin32.KremerVariable
    Friend WithEvents T55c As KremerControlsWin32.KremerVariable
    Friend WithEvents P75 As KremerControlsWin32.KremerVariable
    Friend WithEvents P100 As KremerControlsWin32.KremerVariable
    Friend WithEvents Aux75 As KremerControlsWin32.KremerVariable
    Friend WithEvents Aux100 As KremerControlsWin32.KremerVariable
    Friend WithEvents OilTooLow As KremerControlsWin32.KremerVariable
    Friend WithEvents OilLow As KremerControlsWin32.KremerVariable
    Friend WithEvents PmpSSFail As KremerControlsWin32.KremerVariable
    Friend WithEvents PmpMaint As KremerControlsWin32.KremerVariable
    Friend WithEvents PmpRunning As KremerControlsWin32.KremerVariable
    Friend WithEvents FiltThermal As KremerControlsWin32.KremerVariable
    Friend WithEvents FiltMaint As KremerControlsWin32.KremerVariable
    Friend WithEvents CoolingTherm As KremerControlsWin32.KremerVariable
    Friend WithEvents CoolingMaint As KremerControlsWin32.KremerVariable
    Friend WithEvents HydraulicPmp As KremerControlsWin32.KremerVariable
    Friend WithEvents FiltMotor As KremerControlsWin32.KremerVariable
    Friend WithEvents CoolingFan As KremerControlsWin32.KremerVariable
    Friend WithEvents PressurizePumpValve As KremerControlsWin32.KremerVariable
    Friend WithEvents AccuDrainValve As KremerControlsWin32.KremerVariable
    Friend WithEvents IsolationValve As KremerControlsWin32.KremerVariable
    Friend WithEvents OilTemp As KremerControlsWin32.KremerVariable
    Friend WithEvents MainSysPress As KremerControlsWin32.KremerVariable
    Friend WithEvents TempToHigh As KremerControlsWin32.KremerVariable

End Class
