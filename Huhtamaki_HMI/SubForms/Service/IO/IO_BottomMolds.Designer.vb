<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IO_BottomMolds
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
        Me.BMA_Zone1 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_BMA_Zone1 = New KremerControlsWin32.KremerLight()
        Me.BMA_Zone2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_BMA_Zone2 = New KremerControlsWin32.KremerLight()
        Me.BMA_Zone3 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_BMA_Zone3 = New KremerControlsWin32.KremerLight()
        Me.BMA_Zone4 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_BMA_Zone4 = New KremerControlsWin32.KremerLight()
        Me.BMA_Zone5 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_BMA_Zone5 = New KremerControlsWin32.KremerLight()
        Me.BMA_Zone6 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_BMA_Zone6 = New KremerControlsWin32.KremerLight()
        Me.BMA_Vacuum = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_BMA_Vacuum = New KremerControlsWin32.KremerLight()
        Me.BMB_Zone1 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_BMB_Zone1 = New KremerControlsWin32.KremerLight()
        Me.BMB_Zone2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_BMB_Zone2 = New KremerControlsWin32.KremerLight()
        Me.BMB_Zone3 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BMB_Zone4 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_BMB_Zone4 = New KremerControlsWin32.KremerLight()
        Me.BMB_Zone5 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_BMB_Zone5 = New KremerControlsWin32.KremerLight()
        Me.BMB_Zone6 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_BMB_Zone6 = New KremerControlsWin32.KremerLight()
        Me.BMB_Vacuum = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_BMB_Vacuum = New KremerControlsWin32.KremerLight()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.KL_BMB_Zone3 = New KremerControlsWin32.KremerLight()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.BMA_Zone1)
        Me.VarCollector.Variables.Add(Me.BMA_Zone2)
        Me.VarCollector.Variables.Add(Me.BMA_Zone3)
        Me.VarCollector.Variables.Add(Me.BMA_Zone4)
        Me.VarCollector.Variables.Add(Me.BMA_Zone5)
        Me.VarCollector.Variables.Add(Me.BMA_Zone6)
        Me.VarCollector.Variables.Add(Me.BMA_Vacuum)
        Me.VarCollector.Variables.Add(Me.BMB_Zone1)
        Me.VarCollector.Variables.Add(Me.BMB_Zone2)
        Me.VarCollector.Variables.Add(Me.BMB_Zone3)
        Me.VarCollector.Variables.Add(Me.BMB_Zone4)
        Me.VarCollector.Variables.Add(Me.BMB_Zone5)
        Me.VarCollector.Variables.Add(Me.BMB_Zone6)
        Me.VarCollector.Variables.Add(Me.BMB_Vacuum)
        '
        'BMA_Zone1
        '
        Me.BMA_Zone1.BindControl = Me.KL_BMA_Zone1
        Me.BMA_Zone1.BindProperty = "Data"
        Me.BMA_Zone1.Data = Nothing
        Me.BMA_Zone1.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BMA_Zone1.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMA_Zone1.VariableName = "MAIN.InMoldDrying.BottomMoldA.HeatingZone[1].ixThermal"
        '
        'KL_BMA_Zone1
        '
        Me.KL_BMA_Zone1.ColorOff = System.Drawing.Color.Red
        Me.KL_BMA_Zone1.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BMA_Zone1.Data = False
        Me.KL_BMA_Zone1.Line = True
        Me.KL_BMA_Zone1.LineSize = 1
        Me.KL_BMA_Zone1.Location = New System.Drawing.Point(13, 22)
        Me.KL_BMA_Zone1.Name = "KL_BMA_Zone1"
        Me.KL_BMA_Zone1.Size = New System.Drawing.Size(20, 20)
        Me.KL_BMA_Zone1.TabIndex = 296
        Me.KL_BMA_Zone1.Text = "KL_BMA_Zone1"
        Me.KL_BMA_Zone1.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BMA_Zone2
        '
        Me.BMA_Zone2.BindControl = Me.KL_BMA_Zone2
        Me.BMA_Zone2.BindProperty = "Data"
        Me.BMA_Zone2.Data = Nothing
        Me.BMA_Zone2.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BMA_Zone2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMA_Zone2.VariableName = "MAIN.InMoldDrying.BottomMoldA.HeatingZone[2].ixThermal"
        '
        'KL_BMA_Zone2
        '
        Me.KL_BMA_Zone2.ColorOff = System.Drawing.Color.Red
        Me.KL_BMA_Zone2.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BMA_Zone2.Data = False
        Me.KL_BMA_Zone2.Line = True
        Me.KL_BMA_Zone2.LineSize = 1
        Me.KL_BMA_Zone2.Location = New System.Drawing.Point(13, 43)
        Me.KL_BMA_Zone2.Name = "KL_BMA_Zone2"
        Me.KL_BMA_Zone2.Size = New System.Drawing.Size(20, 20)
        Me.KL_BMA_Zone2.TabIndex = 298
        Me.KL_BMA_Zone2.Text = "KL_BMA_Zone2"
        Me.KL_BMA_Zone2.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BMA_Zone3
        '
        Me.BMA_Zone3.BindControl = Me.KL_BMA_Zone3
        Me.BMA_Zone3.BindProperty = "Data"
        Me.BMA_Zone3.Data = Nothing
        Me.BMA_Zone3.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BMA_Zone3.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMA_Zone3.VariableName = "MAIN.InMoldDrying.BottomMoldA.HeatingZone[3].ixThermal"
        '
        'KL_BMA_Zone3
        '
        Me.KL_BMA_Zone3.ColorOff = System.Drawing.Color.Red
        Me.KL_BMA_Zone3.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BMA_Zone3.Data = False
        Me.KL_BMA_Zone3.Line = True
        Me.KL_BMA_Zone3.LineSize = 1
        Me.KL_BMA_Zone3.Location = New System.Drawing.Point(13, 64)
        Me.KL_BMA_Zone3.Name = "KL_BMA_Zone3"
        Me.KL_BMA_Zone3.Size = New System.Drawing.Size(20, 20)
        Me.KL_BMA_Zone3.TabIndex = 300
        Me.KL_BMA_Zone3.Text = "KL_BMA_Zone3"
        Me.KL_BMA_Zone3.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BMA_Zone4
        '
        Me.BMA_Zone4.BindControl = Me.KL_BMA_Zone4
        Me.BMA_Zone4.BindProperty = "Data"
        Me.BMA_Zone4.Data = Nothing
        Me.BMA_Zone4.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BMA_Zone4.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMA_Zone4.VariableName = "MAIN.InMoldDrying.BottomMoldA.HeatingZone[4].ixThermal"
        '
        'KL_BMA_Zone4
        '
        Me.KL_BMA_Zone4.ColorOff = System.Drawing.Color.Red
        Me.KL_BMA_Zone4.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BMA_Zone4.Data = False
        Me.KL_BMA_Zone4.Line = True
        Me.KL_BMA_Zone4.LineSize = 1
        Me.KL_BMA_Zone4.Location = New System.Drawing.Point(13, 85)
        Me.KL_BMA_Zone4.Name = "KL_BMA_Zone4"
        Me.KL_BMA_Zone4.Size = New System.Drawing.Size(20, 20)
        Me.KL_BMA_Zone4.TabIndex = 302
        Me.KL_BMA_Zone4.Text = "KremerLight11"
        Me.KL_BMA_Zone4.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BMA_Zone5
        '
        Me.BMA_Zone5.BindControl = Me.KL_BMA_Zone5
        Me.BMA_Zone5.BindProperty = "Data"
        Me.BMA_Zone5.Data = Nothing
        Me.BMA_Zone5.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BMA_Zone5.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMA_Zone5.VariableName = "MAIN.InMoldDrying.BottomMoldA.HeatingZone[5].ixThermal"
        '
        'KL_BMA_Zone5
        '
        Me.KL_BMA_Zone5.ColorOff = System.Drawing.Color.Red
        Me.KL_BMA_Zone5.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BMA_Zone5.Data = False
        Me.KL_BMA_Zone5.Line = True
        Me.KL_BMA_Zone5.LineSize = 1
        Me.KL_BMA_Zone5.Location = New System.Drawing.Point(13, 106)
        Me.KL_BMA_Zone5.Name = "KL_BMA_Zone5"
        Me.KL_BMA_Zone5.Size = New System.Drawing.Size(20, 20)
        Me.KL_BMA_Zone5.TabIndex = 304
        Me.KL_BMA_Zone5.Text = "KremerLight12"
        Me.KL_BMA_Zone5.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BMA_Zone6
        '
        Me.BMA_Zone6.BindControl = Me.KL_BMA_Zone6
        Me.BMA_Zone6.BindProperty = "Data"
        Me.BMA_Zone6.Data = Nothing
        Me.BMA_Zone6.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BMA_Zone6.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMA_Zone6.VariableName = "MAIN.InMoldDrying.BottomMoldA.HeatingZone[6].ixThermal"
        '
        'KL_BMA_Zone6
        '
        Me.KL_BMA_Zone6.ColorOff = System.Drawing.Color.Red
        Me.KL_BMA_Zone6.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BMA_Zone6.Data = False
        Me.KL_BMA_Zone6.Line = True
        Me.KL_BMA_Zone6.LineSize = 1
        Me.KL_BMA_Zone6.Location = New System.Drawing.Point(13, 127)
        Me.KL_BMA_Zone6.Name = "KL_BMA_Zone6"
        Me.KL_BMA_Zone6.Size = New System.Drawing.Size(20, 20)
        Me.KL_BMA_Zone6.TabIndex = 306
        Me.KL_BMA_Zone6.Text = "KremerLight13"
        Me.KL_BMA_Zone6.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BMA_Vacuum
        '
        Me.BMA_Vacuum.BindControl = Me.KL_BMA_Vacuum
        Me.BMA_Vacuum.BindProperty = "Data"
        Me.BMA_Vacuum.Data = Nothing
        Me.BMA_Vacuum.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BMA_Vacuum.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMA_Vacuum.VariableName = "MAIN.InMoldDrying.BottomMoldA.Vacuum.Q"
        '
        'KL_BMA_Vacuum
        '
        Me.KL_BMA_Vacuum.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BMA_Vacuum.ColorOn = System.Drawing.Color.Lime
        Me.KL_BMA_Vacuum.Data = False
        Me.KL_BMA_Vacuum.Line = True
        Me.KL_BMA_Vacuum.LineSize = 1
        Me.KL_BMA_Vacuum.Location = New System.Drawing.Point(13, 190)
        Me.KL_BMA_Vacuum.Name = "KL_BMA_Vacuum"
        Me.KL_BMA_Vacuum.Size = New System.Drawing.Size(20, 20)
        Me.KL_BMA_Vacuum.TabIndex = 290
        Me.KL_BMA_Vacuum.Text = "KremerLight2"
        Me.KL_BMA_Vacuum.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BMB_Zone1
        '
        Me.BMB_Zone1.BindControl = Me.KL_BMB_Zone1
        Me.BMB_Zone1.BindProperty = "Data"
        Me.BMB_Zone1.Data = Nothing
        Me.BMB_Zone1.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BMB_Zone1.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMB_Zone1.VariableName = "MAIN.InMoldDrying.BottomMoldB.HeatingZone[1].ixThermal"
        '
        'KL_BMB_Zone1
        '
        Me.KL_BMB_Zone1.ColorOff = System.Drawing.Color.Red
        Me.KL_BMB_Zone1.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BMB_Zone1.Data = False
        Me.KL_BMB_Zone1.Line = True
        Me.KL_BMB_Zone1.LineSize = 1
        Me.KL_BMB_Zone1.Location = New System.Drawing.Point(13, 22)
        Me.KL_BMB_Zone1.Name = "KL_BMB_Zone1"
        Me.KL_BMB_Zone1.Size = New System.Drawing.Size(20, 20)
        Me.KL_BMB_Zone1.TabIndex = 321
        Me.KL_BMB_Zone1.Text = "KremerLight2"
        Me.KL_BMB_Zone1.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BMB_Zone2
        '
        Me.BMB_Zone2.BindControl = Me.KL_BMB_Zone2
        Me.BMB_Zone2.BindProperty = "Data"
        Me.BMB_Zone2.Data = Nothing
        Me.BMB_Zone2.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BMB_Zone2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMB_Zone2.VariableName = "MAIN.InMoldDrying.BottomMoldB.HeatingZone[2].ixThermal"
        '
        'KL_BMB_Zone2
        '
        Me.KL_BMB_Zone2.ColorOff = System.Drawing.Color.Red
        Me.KL_BMB_Zone2.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BMB_Zone2.Data = False
        Me.KL_BMB_Zone2.Line = True
        Me.KL_BMB_Zone2.LineSize = 1
        Me.KL_BMB_Zone2.Location = New System.Drawing.Point(13, 43)
        Me.KL_BMB_Zone2.Name = "KL_BMB_Zone2"
        Me.KL_BMB_Zone2.Size = New System.Drawing.Size(20, 20)
        Me.KL_BMB_Zone2.TabIndex = 323
        Me.KL_BMB_Zone2.Text = "KremerLight9"
        Me.KL_BMB_Zone2.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BMB_Zone3
        '
        Me.BMB_Zone3.BindControl = Me.KL_BMB_Zone3
        Me.BMB_Zone3.BindProperty = "Data"
        Me.BMB_Zone3.Data = Nothing
        Me.BMB_Zone3.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BMB_Zone3.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMB_Zone3.VariableName = "MAIN.InMoldDrying.BottomMoldB.HeatingZone[3].ixThermal"
        '
        'BMB_Zone4
        '
        Me.BMB_Zone4.BindControl = Me.KL_BMB_Zone4
        Me.BMB_Zone4.BindProperty = "Data"
        Me.BMB_Zone4.Data = Nothing
        Me.BMB_Zone4.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BMB_Zone4.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMB_Zone4.VariableName = "MAIN.InMoldDrying.BottomMoldB.HeatingZone[4].ixThermal"
        '
        'KL_BMB_Zone4
        '
        Me.KL_BMB_Zone4.ColorOff = System.Drawing.Color.Red
        Me.KL_BMB_Zone4.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BMB_Zone4.Data = False
        Me.KL_BMB_Zone4.Line = True
        Me.KL_BMB_Zone4.LineSize = 1
        Me.KL_BMB_Zone4.Location = New System.Drawing.Point(13, 85)
        Me.KL_BMB_Zone4.Name = "KL_BMB_Zone4"
        Me.KL_BMB_Zone4.Size = New System.Drawing.Size(20, 20)
        Me.KL_BMB_Zone4.TabIndex = 327
        Me.KL_BMB_Zone4.Text = "KremerLight11"
        Me.KL_BMB_Zone4.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BMB_Zone5
        '
        Me.BMB_Zone5.BindControl = Me.KL_BMB_Zone5
        Me.BMB_Zone5.BindProperty = "Data"
        Me.BMB_Zone5.Data = Nothing
        Me.BMB_Zone5.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BMB_Zone5.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMB_Zone5.VariableName = "MAIN.InMoldDrying.BottomMoldB.HeatingZone[5].ixThermal"
        '
        'KL_BMB_Zone5
        '
        Me.KL_BMB_Zone5.ColorOff = System.Drawing.Color.Red
        Me.KL_BMB_Zone5.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BMB_Zone5.Data = False
        Me.KL_BMB_Zone5.Line = True
        Me.KL_BMB_Zone5.LineSize = 1
        Me.KL_BMB_Zone5.Location = New System.Drawing.Point(13, 106)
        Me.KL_BMB_Zone5.Name = "KL_BMB_Zone5"
        Me.KL_BMB_Zone5.Size = New System.Drawing.Size(20, 20)
        Me.KL_BMB_Zone5.TabIndex = 329
        Me.KL_BMB_Zone5.Text = "KremerLight12"
        Me.KL_BMB_Zone5.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BMB_Zone6
        '
        Me.BMB_Zone6.BindControl = Me.KL_BMB_Zone6
        Me.BMB_Zone6.BindProperty = "Data"
        Me.BMB_Zone6.Data = Nothing
        Me.BMB_Zone6.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BMB_Zone6.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMB_Zone6.VariableName = "MAIN.InMoldDrying.BottomMoldB.HeatingZone[6].ixThermal"
        '
        'KL_BMB_Zone6
        '
        Me.KL_BMB_Zone6.ColorOff = System.Drawing.Color.Red
        Me.KL_BMB_Zone6.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BMB_Zone6.Data = False
        Me.KL_BMB_Zone6.Line = True
        Me.KL_BMB_Zone6.LineSize = 1
        Me.KL_BMB_Zone6.Location = New System.Drawing.Point(13, 127)
        Me.KL_BMB_Zone6.Name = "KL_BMB_Zone6"
        Me.KL_BMB_Zone6.Size = New System.Drawing.Size(20, 20)
        Me.KL_BMB_Zone6.TabIndex = 331
        Me.KL_BMB_Zone6.Text = "KremerLight13"
        Me.KL_BMB_Zone6.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BMB_Vacuum
        '
        Me.BMB_Vacuum.BindControl = Me.KL_BMB_Vacuum
        Me.BMB_Vacuum.BindProperty = "Data"
        Me.BMB_Vacuum.Data = Nothing
        Me.BMB_Vacuum.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BMB_Vacuum.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMB_Vacuum.VariableName = "MAIN.InMoldDrying.BottomMoldB.Vacuum.Q"
        '
        'KL_BMB_Vacuum
        '
        Me.KL_BMB_Vacuum.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BMB_Vacuum.ColorOn = System.Drawing.Color.Lime
        Me.KL_BMB_Vacuum.Data = False
        Me.KL_BMB_Vacuum.Line = True
        Me.KL_BMB_Vacuum.LineSize = 1
        Me.KL_BMB_Vacuum.Location = New System.Drawing.Point(13, 190)
        Me.KL_BMB_Vacuum.Name = "KL_BMB_Vacuum"
        Me.KL_BMB_Vacuum.Size = New System.Drawing.Size(20, 20)
        Me.KL_BMB_Vacuum.TabIndex = 315
        Me.KL_BMB_Vacuum.Text = "KremerLight2"
        Me.KL_BMB_Vacuum.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.KL_BMA_Vacuum)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.KL_BMA_Zone2)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.KL_BMA_Zone1)
        Me.GroupBox1.Controls.Add(Me.KL_BMA_Zone3)
        Me.GroupBox1.Controls.Add(Me.KL_BMA_Zone4)
        Me.GroupBox1.Controls.Add(Me.KL_BMA_Zone5)
        Me.GroupBox1.Controls.Add(Me.KL_BMA_Zone6)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 429)
        Me.GroupBox1.TabIndex = 306
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bottom mold A"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(242, 20)
        Me.Label8.TabIndex = 314
        Me.Label8.Tag = ""
        Me.Label8.Text = "Outputs"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(70, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 20)
        Me.Label7.TabIndex = 291
        Me.Label7.Tag = ""
        Me.Label7.Text = "Vacuum"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(71, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(181, 20)
        Me.Label12.TabIndex = 297
        Me.Label12.Tag = ""
        Me.Label12.Text = "Zone 1 Thermal error"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(71, 127)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(181, 20)
        Me.Label19.TabIndex = 307
        Me.Label19.Tag = ""
        Me.Label19.Text = "Zone 6 Thermal error"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(71, 106)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(181, 20)
        Me.Label18.TabIndex = 305
        Me.Label18.Tag = ""
        Me.Label18.Text = "Zone 5 Thermal error"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(71, 85)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(181, 20)
        Me.Label17.TabIndex = 303
        Me.Label17.Tag = ""
        Me.Label17.Text = "Zone 4 Thermal error"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(71, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(181, 20)
        Me.Label16.TabIndex = 301
        Me.Label16.Tag = ""
        Me.Label16.Text = "Zone 3 Thermal error"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(71, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(181, 20)
        Me.Label15.TabIndex = 299
        Me.Label15.Tag = ""
        Me.Label15.Text = "Zone 2 Thermal error"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.KL_BMB_Vacuum)
        Me.GroupBox2.Controls.Add(Me.KL_BMB_Zone6)
        Me.GroupBox2.Controls.Add(Me.KL_BMB_Zone5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.KL_BMB_Zone4)
        Me.GroupBox2.Controls.Add(Me.KL_BMB_Zone3)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.KL_BMB_Zone1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.KL_BMB_Zone2)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(267, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 429)
        Me.GroupBox2.TabIndex = 318
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bottom mold B"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 20)
        Me.Label2.TabIndex = 333
        Me.Label2.Tag = ""
        Me.Label2.Text = "Outputs"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(70, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 20)
        Me.Label4.TabIndex = 318
        Me.Label4.Tag = ""
        Me.Label4.Text = "Vacuum"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_BMB_Zone3
        '
        Me.KL_BMB_Zone3.ColorOff = System.Drawing.Color.Red
        Me.KL_BMB_Zone3.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BMB_Zone3.Data = False
        Me.KL_BMB_Zone3.Line = True
        Me.KL_BMB_Zone3.LineSize = 1
        Me.KL_BMB_Zone3.Location = New System.Drawing.Point(13, 64)
        Me.KL_BMB_Zone3.Name = "KL_BMB_Zone3"
        Me.KL_BMB_Zone3.Size = New System.Drawing.Size(20, 20)
        Me.KL_BMB_Zone3.TabIndex = 325
        Me.KL_BMB_Zone3.Text = "KremerLight10"
        Me.KL_BMB_Zone3.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(71, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(181, 20)
        Me.Label9.TabIndex = 322
        Me.Label9.Tag = ""
        Me.Label9.Text = "Zone 1 Thermal error"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(71, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(181, 20)
        Me.Label10.TabIndex = 332
        Me.Label10.Tag = ""
        Me.Label10.Text = "Zone 6 Thermal error"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(71, 43)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(181, 20)
        Me.Label20.TabIndex = 324
        Me.Label20.Tag = ""
        Me.Label20.Text = "Zone 2 Thermal error"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(71, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(181, 20)
        Me.Label11.TabIndex = 330
        Me.Label11.Tag = ""
        Me.Label11.Text = "Zone 5 Thermal error"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(71, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(181, 20)
        Me.Label14.TabIndex = 326
        Me.Label14.Tag = ""
        Me.Label14.Text = "Zone 3 Thermal error"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(71, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(181, 20)
        Me.Label13.TabIndex = 328
        Me.Label13.Tag = ""
        Me.Label13.Text = "Zone 4 Thermal error"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IO_BottomMolds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "IO_BottomMolds"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "509"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents KL_BMA_Zone4 As KremerControlsWin32.KremerLight
    Friend WithEvents KL_BMA_Zone5 As KremerControlsWin32.KremerLight
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents KL_BMA_Zone6 As KremerControlsWin32.KremerLight
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents KL_BMA_Zone1 As KremerControlsWin32.KremerLight
    Friend WithEvents KL_BMA_Zone2 As KremerControlsWin32.KremerLight
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents KL_BMA_Zone3 As KremerControlsWin32.KremerLight
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents KL_BMA_Vacuum As KremerControlsWin32.KremerLight
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents KL_BMB_Vacuum As KremerControlsWin32.KremerLight
    Friend WithEvents KL_BMB_Zone6 As KremerControlsWin32.KremerLight
    Friend WithEvents KL_BMB_Zone5 As KremerControlsWin32.KremerLight
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents KL_BMB_Zone4 As KremerControlsWin32.KremerLight
    Friend WithEvents KL_BMB_Zone3 As KremerControlsWin32.KremerLight
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents KL_BMB_Zone1 As KremerControlsWin32.KremerLight
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents KL_BMB_Zone2 As KremerControlsWin32.KremerLight
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BMA_Zone1 As KremerControlsWin32.KremerVariable
    Friend WithEvents BMA_Zone2 As KremerControlsWin32.KremerVariable
    Friend WithEvents BMA_Zone3 As KremerControlsWin32.KremerVariable
    Friend WithEvents BMA_Zone4 As KremerControlsWin32.KremerVariable
    Friend WithEvents BMA_Zone5 As KremerControlsWin32.KremerVariable
    Friend WithEvents BMA_Zone6 As KremerControlsWin32.KremerVariable
    Friend WithEvents BMA_Vacuum As KremerControlsWin32.KremerVariable
    Friend WithEvents BMB_Zone1 As KremerControlsWin32.KremerVariable
    Friend WithEvents BMB_Zone2 As KremerControlsWin32.KremerVariable
    Friend WithEvents BMB_Zone3 As KremerControlsWin32.KremerVariable
    Friend WithEvents BMB_Zone4 As KremerControlsWin32.KremerVariable
    Friend WithEvents BMB_Zone5 As KremerControlsWin32.KremerVariable
    Friend WithEvents BMB_Zone6 As KremerControlsWin32.KremerVariable
    Friend WithEvents BMB_Vacuum As KremerControlsWin32.KremerVariable

End Class
