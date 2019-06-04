<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IO_VDenester
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
        Me.components = New System.ComponentModel.Container
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.BSLevel60 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plBSLevel60 = New KremerControlsWin32.KremerLight
        Me.BSDropDownBundle = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plBSLevelDropDownBundle = New KremerControlsWin32.KremerLight
        Me.BSLevel10 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plBSLevel10 = New KremerControlsWin32.KremerLight
        Me.BSLevelEmpty1 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plBSLevelEmpty1 = New KremerControlsWin32.KremerLight
        Me.BSLevelEmpty2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plBSLevelEmpty2 = New KremerControlsWin32.KremerLight
        Me.BSLowerClampLeftOff = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plBSClampLeftOn = New KremerControlsWin32.KremerLight
        Me.BSLowerClampRightOff = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plBSClampRightOn = New KremerControlsWin32.KremerLight
        Me.BSSeparatorOn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plBSSeparatorOn = New KremerControlsWin32.KremerLight
        Me.BSSeparatorOff = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plBSSeparatorOff = New KremerControlsWin32.KremerLight
        Me.BSForcedLimit = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plBSForcedLimit = New KremerControlsWin32.KremerLight
        Me.CLHomeSensor = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plCLHomeSensor = New KremerControlsWin32.KremerLight
        Me.CLNeedleLeftOn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plCLNeedleLeftOn = New KremerControlsWin32.KremerLight
        Me.CLNeedleLeftOff = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plCLNeedleLeftOff = New KremerControlsWin32.KremerLight
        Me.CLNeedleRightOn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plCLNeedleRightOn = New KremerControlsWin32.KremerLight
        Me.CLNeedleRightoff = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plCLNeedleRightoff = New KremerControlsWin32.KremerLight
        Me.HTProductSensor = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plHTProductSensor = New KremerControlsWin32.KremerLight
        Me.HTLimitLeft = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plHTLimitLeft = New KremerControlsWin32.KremerLight
        Me.HTLimitRight = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plHTLimitRight = New KremerControlsWin32.KremerLight
        Me.HTHighProduct = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plHTHighProduct = New KremerControlsWin32.KremerLight
        Me.PHProductSensor = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plPHProductSensor = New KremerControlsWin32.KremerLight
        Me.PHLimitLeft = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plPHLimitLeft = New KremerControlsWin32.KremerLight
        Me.PHLimitRight = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plPHLimitRight = New KremerControlsWin32.KremerLight
        Me.Btn_Overview = New KremerControlsWin32.KremerButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.btnToggleText = New KremerControlsWin32.KremerButton
        Me.VD_BS_Level60 = New KremerControlsWin32.KremerStatusBox
        Me.VD_BS_LvlDropBundle = New KremerControlsWin32.KremerStatusBox
        Me.VD_BS_Level10 = New KremerControlsWin32.KremerStatusBox
        Me.VD_BS_LvlEmpty1 = New KremerControlsWin32.KremerStatusBox
        Me.VD_BS_LvlEmpty2 = New KremerControlsWin32.KremerStatusBox
        Me.VD_BS_ClampLeftOff = New KremerControlsWin32.KremerStatusBox
        Me.VD_BS_ClampRightOff = New KremerControlsWin32.KremerStatusBox
        Me.VD_BS_SeperatorOn = New KremerControlsWin32.KremerStatusBox
        Me.VD_BS_SeperatorOff = New KremerControlsWin32.KremerStatusBox
        Me.VD_BS_ForcedLimitSens = New KremerControlsWin32.KremerStatusBox
        Me.VD_PH_ProdSensor = New KremerControlsWin32.KremerStatusBox
        Me.VD_PH_LimitSensLeft = New KremerControlsWin32.KremerStatusBox
        Me.VD_PH_LimitSensRight = New KremerControlsWin32.KremerStatusBox
        Me.VD_CL_NeedleLeftOff = New KremerControlsWin32.KremerStatusBox
        Me.VD_CL_NeedleRightOff = New KremerControlsWin32.KremerStatusBox
        Me.VD_CL_HomingSens = New KremerControlsWin32.KremerStatusBox
        Me.VD_CL_NeedleLeftOn = New KremerControlsWin32.KremerStatusBox
        Me.VD_CL_NeedleRightOn = New KremerControlsWin32.KremerStatusBox
        Me.VD_HTD_ProductSens = New KremerControlsWin32.KremerStatusBox
        Me.VD_HTD_LimitSensLeft = New KremerControlsWin32.KremerStatusBox
        Me.VD_HTD_LimitSensRight = New KremerControlsWin32.KremerStatusBox
        Me.VD_HTD_HighProduct = New KremerControlsWin32.KremerStatusBox
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.BSLevel60)
        Me.VarCollector.Variables.Add(Me.BSDropDownBundle)
        Me.VarCollector.Variables.Add(Me.BSLevel10)
        Me.VarCollector.Variables.Add(Me.BSLevelEmpty1)
        Me.VarCollector.Variables.Add(Me.BSLevelEmpty2)
        Me.VarCollector.Variables.Add(Me.BSLowerClampLeftOff)
        Me.VarCollector.Variables.Add(Me.BSLowerClampRightOff)
        Me.VarCollector.Variables.Add(Me.BSSeparatorOn)
        Me.VarCollector.Variables.Add(Me.BSSeparatorOff)
        Me.VarCollector.Variables.Add(Me.BSForcedLimit)
        Me.VarCollector.Variables.Add(Me.CLHomeSensor)
        Me.VarCollector.Variables.Add(Me.CLNeedleLeftOn)
        Me.VarCollector.Variables.Add(Me.CLNeedleLeftOff)
        Me.VarCollector.Variables.Add(Me.CLNeedleRightOn)
        Me.VarCollector.Variables.Add(Me.CLNeedleRightoff)
        Me.VarCollector.Variables.Add(Me.HTProductSensor)
        Me.VarCollector.Variables.Add(Me.HTLimitLeft)
        Me.VarCollector.Variables.Add(Me.HTLimitRight)
        Me.VarCollector.Variables.Add(Me.HTHighProduct)
        Me.VarCollector.Variables.Add(Me.PHProductSensor)
        Me.VarCollector.Variables.Add(Me.PHLimitLeft)
        Me.VarCollector.Variables.Add(Me.PHLimitRight)
        '
        'BSLevel60
        '
        Me.BSLevel60.BindControl = Me.plBSLevel60
        Me.BSLevel60.BindProperty = "Data"
        Me.BSLevel60.Data = Nothing
        Me.BSLevel60.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BSLevel60.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BSLevel60.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.BundleStorage.ixLevelHigh"
        '
        'plBSLevel60
        '
        Me.plBSLevel60.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plBSLevel60.ColorOn = System.Drawing.Color.Lime
        Me.plBSLevel60.Data = False
        Me.plBSLevel60.Line = True
        Me.plBSLevel60.LineSize = 1
        Me.plBSLevel60.Location = New System.Drawing.Point(15, 38)
        Me.plBSLevel60.Name = "plBSLevel60"
        Me.plBSLevel60.Size = New System.Drawing.Size(24, 24)
        Me.plBSLevel60.TabIndex = 37
        Me.plBSLevel60.Text = "KremerLight1"
        Me.plBSLevel60.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BSDropDownBundle
        '
        Me.BSDropDownBundle.BindControl = Me.plBSLevelDropDownBundle
        Me.BSDropDownBundle.BindProperty = "Data"
        Me.BSDropDownBundle.Data = Nothing
        Me.BSDropDownBundle.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BSDropDownBundle.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BSDropDownBundle.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.BundleStorage.ixLevelDropNewAutom" & _
            "aticBundle"
        '
        'plBSLevelDropDownBundle
        '
        Me.plBSLevelDropDownBundle.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plBSLevelDropDownBundle.ColorOn = System.Drawing.Color.Lime
        Me.plBSLevelDropDownBundle.Data = False
        Me.plBSLevelDropDownBundle.Line = True
        Me.plBSLevelDropDownBundle.LineSize = 1
        Me.plBSLevelDropDownBundle.Location = New System.Drawing.Point(15, 63)
        Me.plBSLevelDropDownBundle.Name = "plBSLevelDropDownBundle"
        Me.plBSLevelDropDownBundle.Size = New System.Drawing.Size(24, 24)
        Me.plBSLevelDropDownBundle.TabIndex = 394
        Me.plBSLevelDropDownBundle.Text = "KremerLight1"
        Me.plBSLevelDropDownBundle.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BSLevel10
        '
        Me.BSLevel10.BindControl = Me.plBSLevel10
        Me.BSLevel10.BindProperty = "Data"
        Me.BSLevel10.Data = Nothing
        Me.BSLevel10.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BSLevel10.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BSLevel10.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.BundleStorage.ixLevelLow"
        '
        'plBSLevel10
        '
        Me.plBSLevel10.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plBSLevel10.ColorOn = System.Drawing.Color.Lime
        Me.plBSLevel10.Data = False
        Me.plBSLevel10.Line = True
        Me.plBSLevel10.LineSize = 1
        Me.plBSLevel10.Location = New System.Drawing.Point(15, 88)
        Me.plBSLevel10.Name = "plBSLevel10"
        Me.plBSLevel10.Size = New System.Drawing.Size(24, 24)
        Me.plBSLevel10.TabIndex = 287
        Me.plBSLevel10.Text = "KremerLight1"
        Me.plBSLevel10.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BSLevelEmpty1
        '
        Me.BSLevelEmpty1.BindControl = Me.plBSLevelEmpty1
        Me.BSLevelEmpty1.BindProperty = "Data"
        Me.BSLevelEmpty1.Data = Nothing
        Me.BSLevelEmpty1.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BSLevelEmpty1.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BSLevelEmpty1.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.BundleStorage.ixLevelEmptySensor1" & _
            ""
        '
        'plBSLevelEmpty1
        '
        Me.plBSLevelEmpty1.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plBSLevelEmpty1.ColorOn = System.Drawing.Color.Lime
        Me.plBSLevelEmpty1.Data = False
        Me.plBSLevelEmpty1.Line = True
        Me.plBSLevelEmpty1.LineSize = 1
        Me.plBSLevelEmpty1.Location = New System.Drawing.Point(15, 113)
        Me.plBSLevelEmpty1.Name = "plBSLevelEmpty1"
        Me.plBSLevelEmpty1.Size = New System.Drawing.Size(24, 24)
        Me.plBSLevelEmpty1.TabIndex = 311
        Me.plBSLevelEmpty1.Text = "KremerLight1"
        Me.plBSLevelEmpty1.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BSLevelEmpty2
        '
        Me.BSLevelEmpty2.BindControl = Me.plBSLevelEmpty2
        Me.BSLevelEmpty2.BindProperty = "Data"
        Me.BSLevelEmpty2.Data = Nothing
        Me.BSLevelEmpty2.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BSLevelEmpty2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BSLevelEmpty2.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.BundleStorage.ixLevelEmptySensor2" & _
            ""
        '
        'plBSLevelEmpty2
        '
        Me.plBSLevelEmpty2.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plBSLevelEmpty2.ColorOn = System.Drawing.Color.Lime
        Me.plBSLevelEmpty2.Data = False
        Me.plBSLevelEmpty2.Line = True
        Me.plBSLevelEmpty2.LineSize = 1
        Me.plBSLevelEmpty2.Location = New System.Drawing.Point(181, 114)
        Me.plBSLevelEmpty2.Name = "plBSLevelEmpty2"
        Me.plBSLevelEmpty2.Size = New System.Drawing.Size(24, 24)
        Me.plBSLevelEmpty2.TabIndex = 392
        Me.plBSLevelEmpty2.Text = "KremerLight1"
        Me.plBSLevelEmpty2.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BSLowerClampLeftOff
        '
        Me.BSLowerClampLeftOff.BindControl = Me.plBSClampLeftOn
        Me.BSLowerClampLeftOff.BindProperty = "Data"
        Me.BSLowerClampLeftOff.Data = Nothing
        Me.BSLowerClampLeftOff.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BSLowerClampLeftOff.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BSLowerClampLeftOff.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.BundleStorage.BundleClampLower_L." & _
            "mxCilinderIsIn"
        '
        'plBSClampLeftOn
        '
        Me.plBSClampLeftOn.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plBSClampLeftOn.ColorOn = System.Drawing.Color.Lime
        Me.plBSClampLeftOn.Data = False
        Me.plBSClampLeftOn.Line = True
        Me.plBSClampLeftOn.LineSize = 1
        Me.plBSClampLeftOn.Location = New System.Drawing.Point(15, 140)
        Me.plBSClampLeftOn.Name = "plBSClampLeftOn"
        Me.plBSClampLeftOn.Size = New System.Drawing.Size(24, 24)
        Me.plBSClampLeftOn.TabIndex = 354
        Me.plBSClampLeftOn.Text = "KremerLight1"
        Me.plBSClampLeftOn.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BSLowerClampRightOff
        '
        Me.BSLowerClampRightOff.BindControl = Me.plBSClampRightOn
        Me.BSLowerClampRightOff.BindProperty = "Data"
        Me.BSLowerClampRightOff.Data = Nothing
        Me.BSLowerClampRightOff.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BSLowerClampRightOff.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BSLowerClampRightOff.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.BundleStorage.BundleClampLower_R." & _
            "mxCilinderIsIn"
        '
        'plBSClampRightOn
        '
        Me.plBSClampRightOn.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plBSClampRightOn.ColorOn = System.Drawing.Color.Lime
        Me.plBSClampRightOn.Data = False
        Me.plBSClampRightOn.Line = True
        Me.plBSClampRightOn.LineSize = 1
        Me.plBSClampRightOn.Location = New System.Drawing.Point(15, 165)
        Me.plBSClampRightOn.Name = "plBSClampRightOn"
        Me.plBSClampRightOn.Size = New System.Drawing.Size(24, 24)
        Me.plBSClampRightOn.TabIndex = 371
        Me.plBSClampRightOn.Text = "KremerLight1"
        Me.plBSClampRightOn.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BSSeparatorOn
        '
        Me.BSSeparatorOn.BindControl = Me.plBSSeparatorOn
        Me.BSSeparatorOn.BindProperty = "Data"
        Me.BSSeparatorOn.Data = Nothing
        Me.BSSeparatorOn.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BSSeparatorOn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BSSeparatorOn.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.BundleStorage.Separator.mxCilinde" & _
            "rIsOut"
        '
        'plBSSeparatorOn
        '
        Me.plBSSeparatorOn.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plBSSeparatorOn.ColorOn = System.Drawing.Color.Lime
        Me.plBSSeparatorOn.Data = False
        Me.plBSSeparatorOn.Line = True
        Me.plBSSeparatorOn.LineSize = 1
        Me.plBSSeparatorOn.Location = New System.Drawing.Point(15, 190)
        Me.plBSSeparatorOn.Name = "plBSSeparatorOn"
        Me.plBSSeparatorOn.Size = New System.Drawing.Size(24, 24)
        Me.plBSSeparatorOn.TabIndex = 373
        Me.plBSSeparatorOn.Text = "KremerLight1"
        Me.plBSSeparatorOn.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BSSeparatorOff
        '
        Me.BSSeparatorOff.BindControl = Me.plBSSeparatorOff
        Me.BSSeparatorOff.BindProperty = "Data"
        Me.BSSeparatorOff.Data = Nothing
        Me.BSSeparatorOff.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BSSeparatorOff.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BSSeparatorOff.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.BundleStorage.Separator.mxCilinde" & _
            "rIsIn"
        '
        'plBSSeparatorOff
        '
        Me.plBSSeparatorOff.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plBSSeparatorOff.ColorOn = System.Drawing.Color.Lime
        Me.plBSSeparatorOff.Data = False
        Me.plBSSeparatorOff.Line = True
        Me.plBSSeparatorOff.LineSize = 1
        Me.plBSSeparatorOff.Location = New System.Drawing.Point(15, 215)
        Me.plBSSeparatorOff.Name = "plBSSeparatorOff"
        Me.plBSSeparatorOff.Size = New System.Drawing.Size(24, 24)
        Me.plBSSeparatorOff.TabIndex = 375
        Me.plBSSeparatorOff.Text = "KremerLight1"
        Me.plBSSeparatorOff.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BSForcedLimit
        '
        Me.BSForcedLimit.BindControl = Me.plBSForcedLimit
        Me.BSForcedLimit.BindProperty = "Data"
        Me.BSForcedLimit.Data = Nothing
        Me.BSForcedLimit.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BSForcedLimit.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BSForcedLimit.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.BundleStorage.ixForceLimitSeparat" & _
            "or"
        '
        'plBSForcedLimit
        '
        Me.plBSForcedLimit.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plBSForcedLimit.ColorOn = System.Drawing.Color.Lime
        Me.plBSForcedLimit.Data = False
        Me.plBSForcedLimit.Line = True
        Me.plBSForcedLimit.LineSize = 1
        Me.plBSForcedLimit.Location = New System.Drawing.Point(15, 240)
        Me.plBSForcedLimit.Name = "plBSForcedLimit"
        Me.plBSForcedLimit.Size = New System.Drawing.Size(24, 24)
        Me.plBSForcedLimit.TabIndex = 377
        Me.plBSForcedLimit.Text = "KremerLight1"
        Me.plBSForcedLimit.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'CLHomeSensor
        '
        Me.CLHomeSensor.BindControl = Me.plCLHomeSensor
        Me.CLHomeSensor.BindProperty = "Data"
        Me.CLHomeSensor.Data = Nothing
        Me.CLHomeSensor.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.CLHomeSensor.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.CLHomeSensor.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.CartonLift.ixRefSensor"
        '
        'plCLHomeSensor
        '
        Me.plCLHomeSensor.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plCLHomeSensor.ColorOn = System.Drawing.Color.Lime
        Me.plCLHomeSensor.Data = False
        Me.plCLHomeSensor.Line = True
        Me.plCLHomeSensor.LineSize = 1
        Me.plCLHomeSensor.Location = New System.Drawing.Point(415, 88)
        Me.plCLHomeSensor.Name = "plCLHomeSensor"
        Me.plCLHomeSensor.Size = New System.Drawing.Size(24, 24)
        Me.plCLHomeSensor.TabIndex = 356
        Me.plCLHomeSensor.Text = "KremerLight1"
        Me.plCLHomeSensor.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'CLNeedleLeftOn
        '
        Me.CLNeedleLeftOn.BindControl = Me.plCLNeedleLeftOn
        Me.CLNeedleLeftOn.BindProperty = "Data"
        Me.CLNeedleLeftOn.Data = Nothing
        Me.CLNeedleLeftOn.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.CLNeedleLeftOn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.CLNeedleLeftOn.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.CartonLift.GripperNeedle_L.mxCili" & _
            "nderIsOut"
        '
        'plCLNeedleLeftOn
        '
        Me.plCLNeedleLeftOn.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plCLNeedleLeftOn.ColorOn = System.Drawing.Color.Lime
        Me.plCLNeedleLeftOn.Data = False
        Me.plCLNeedleLeftOn.Line = True
        Me.plCLNeedleLeftOn.LineSize = 1
        Me.plCLNeedleLeftOn.Location = New System.Drawing.Point(415, 113)
        Me.plCLNeedleLeftOn.Name = "plCLNeedleLeftOn"
        Me.plCLNeedleLeftOn.Size = New System.Drawing.Size(24, 24)
        Me.plCLNeedleLeftOn.TabIndex = 358
        Me.plCLNeedleLeftOn.Text = "KremerLight1"
        Me.plCLNeedleLeftOn.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'CLNeedleLeftOff
        '
        Me.CLNeedleLeftOff.BindControl = Me.plCLNeedleLeftOff
        Me.CLNeedleLeftOff.BindProperty = "Data"
        Me.CLNeedleLeftOff.Data = Nothing
        Me.CLNeedleLeftOff.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.CLNeedleLeftOff.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.CLNeedleLeftOff.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.CartonLift.GripperNeedle_L.mxCili" & _
            "nderIsIn"
        '
        'plCLNeedleLeftOff
        '
        Me.plCLNeedleLeftOff.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plCLNeedleLeftOff.ColorOn = System.Drawing.Color.Lime
        Me.plCLNeedleLeftOff.Data = False
        Me.plCLNeedleLeftOff.Line = True
        Me.plCLNeedleLeftOff.LineSize = 1
        Me.plCLNeedleLeftOff.Location = New System.Drawing.Point(415, 38)
        Me.plCLNeedleLeftOff.Name = "plCLNeedleLeftOff"
        Me.plCLNeedleLeftOff.Size = New System.Drawing.Size(24, 24)
        Me.plCLNeedleLeftOff.TabIndex = 381
        Me.plCLNeedleLeftOff.Text = "KremerLight1"
        Me.plCLNeedleLeftOff.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'CLNeedleRightOn
        '
        Me.CLNeedleRightOn.BindControl = Me.plCLNeedleRightOn
        Me.CLNeedleRightOn.BindProperty = "Data"
        Me.CLNeedleRightOn.Data = Nothing
        Me.CLNeedleRightOn.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.CLNeedleRightOn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.CLNeedleRightOn.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.CartonLift.GripperNeedle_R.mxCili" & _
            "nderIsOut"
        '
        'plCLNeedleRightOn
        '
        Me.plCLNeedleRightOn.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plCLNeedleRightOn.ColorOn = System.Drawing.Color.Lime
        Me.plCLNeedleRightOn.Data = False
        Me.plCLNeedleRightOn.Line = True
        Me.plCLNeedleRightOn.LineSize = 1
        Me.plCLNeedleRightOn.Location = New System.Drawing.Point(415, 138)
        Me.plCLNeedleRightOn.Name = "plCLNeedleRightOn"
        Me.plCLNeedleRightOn.Size = New System.Drawing.Size(24, 24)
        Me.plCLNeedleRightOn.TabIndex = 379
        Me.plCLNeedleRightOn.Text = "KremerLight11"
        Me.plCLNeedleRightOn.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'CLNeedleRightoff
        '
        Me.CLNeedleRightoff.BindControl = Me.plCLNeedleRightoff
        Me.CLNeedleRightoff.BindProperty = "Data"
        Me.CLNeedleRightoff.Data = Nothing
        Me.CLNeedleRightoff.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.CLNeedleRightoff.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.CLNeedleRightoff.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.CartonLift.GripperNeedle_R.mxCili" & _
            "nderIsIn"
        '
        'plCLNeedleRightoff
        '
        Me.plCLNeedleRightoff.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plCLNeedleRightoff.ColorOn = System.Drawing.Color.Lime
        Me.plCLNeedleRightoff.Data = False
        Me.plCLNeedleRightoff.Line = True
        Me.plCLNeedleRightoff.LineSize = 1
        Me.plCLNeedleRightoff.Location = New System.Drawing.Point(415, 63)
        Me.plCLNeedleRightoff.Name = "plCLNeedleRightoff"
        Me.plCLNeedleRightoff.Size = New System.Drawing.Size(24, 24)
        Me.plCLNeedleRightoff.TabIndex = 383
        Me.plCLNeedleRightoff.Text = "KremerLight12"
        Me.plCLNeedleRightoff.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'HTProductSensor
        '
        Me.HTProductSensor.BindControl = Me.plHTProductSensor
        Me.HTProductSensor.BindProperty = "Data"
        Me.HTProductSensor.Data = Nothing
        Me.HTProductSensor.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.HTProductSensor.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.HTProductSensor.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.HorizontalTransport.ixProductSens" & _
            "or"
        '
        'plHTProductSensor
        '
        Me.plHTProductSensor.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plHTProductSensor.ColorOn = System.Drawing.Color.Lime
        Me.plHTProductSensor.Data = False
        Me.plHTProductSensor.Line = True
        Me.plHTProductSensor.LineSize = 1
        Me.plHTProductSensor.Location = New System.Drawing.Point(415, 202)
        Me.plHTProductSensor.Name = "plHTProductSensor"
        Me.plHTProductSensor.Size = New System.Drawing.Size(24, 24)
        Me.plHTProductSensor.TabIndex = 361
        Me.plHTProductSensor.Text = "KremerLight1"
        Me.plHTProductSensor.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'HTLimitLeft
        '
        Me.HTLimitLeft.BindControl = Me.plHTLimitLeft
        Me.HTLimitLeft.BindProperty = "Data"
        Me.HTLimitLeft.Data = Nothing
        Me.HTLimitLeft.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.HTLimitLeft.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.HTLimitLeft.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.HorizontalTransport.ixLimit_Left"
        '
        'plHTLimitLeft
        '
        Me.plHTLimitLeft.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plHTLimitLeft.ColorOn = System.Drawing.Color.Lime
        Me.plHTLimitLeft.Data = False
        Me.plHTLimitLeft.Line = True
        Me.plHTLimitLeft.LineSize = 1
        Me.plHTLimitLeft.Location = New System.Drawing.Point(415, 227)
        Me.plHTLimitLeft.Name = "plHTLimitLeft"
        Me.plHTLimitLeft.Size = New System.Drawing.Size(24, 24)
        Me.plHTLimitLeft.TabIndex = 363
        Me.plHTLimitLeft.Text = "KremerLight1"
        Me.plHTLimitLeft.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'HTLimitRight
        '
        Me.HTLimitRight.BindControl = Me.plHTLimitRight
        Me.HTLimitRight.BindProperty = "Data"
        Me.HTLimitRight.Data = Nothing
        Me.HTLimitRight.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.HTLimitRight.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.HTLimitRight.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.HorizontalTransport.ixLimit_Right" & _
            ""
        '
        'plHTLimitRight
        '
        Me.plHTLimitRight.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plHTLimitRight.ColorOn = System.Drawing.Color.Lime
        Me.plHTLimitRight.Data = False
        Me.plHTLimitRight.Line = True
        Me.plHTLimitRight.LineSize = 1
        Me.plHTLimitRight.Location = New System.Drawing.Point(415, 252)
        Me.plHTLimitRight.Name = "plHTLimitRight"
        Me.plHTLimitRight.Size = New System.Drawing.Size(24, 24)
        Me.plHTLimitRight.TabIndex = 386
        Me.plHTLimitRight.Text = "KremerLight1"
        Me.plHTLimitRight.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'HTHighProduct
        '
        Me.HTHighProduct.BindControl = Me.plHTHighProduct
        Me.HTHighProduct.BindProperty = "Data"
        Me.HTHighProduct.Data = Nothing
        Me.HTHighProduct.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.HTHighProduct.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.HTHighProduct.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.HorizontalTransport.ixHighProduct" & _
            ""
        '
        'plHTHighProduct
        '
        Me.plHTHighProduct.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plHTHighProduct.ColorOn = System.Drawing.Color.Lime
        Me.plHTHighProduct.Data = False
        Me.plHTHighProduct.Line = True
        Me.plHTHighProduct.LineSize = 1
        Me.plHTHighProduct.Location = New System.Drawing.Point(415, 277)
        Me.plHTHighProduct.Name = "plHTHighProduct"
        Me.plHTHighProduct.Size = New System.Drawing.Size(24, 24)
        Me.plHTHighProduct.TabIndex = 390
        Me.plHTHighProduct.Text = "KremerLight1"
        Me.plHTHighProduct.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'PHProductSensor
        '
        Me.PHProductSensor.BindControl = Me.plPHProductSensor
        Me.PHProductSensor.BindProperty = "Data"
        Me.PHProductSensor.Data = Nothing
        Me.PHProductSensor.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PHProductSensor.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PHProductSensor.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.PickupHead.ixProductSensor"
        '
        'plPHProductSensor
        '
        Me.plPHProductSensor.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plPHProductSensor.ColorOn = System.Drawing.Color.Lime
        Me.plPHProductSensor.Data = False
        Me.plPHProductSensor.Line = True
        Me.plPHProductSensor.LineSize = 1
        Me.plPHProductSensor.Location = New System.Drawing.Point(15, 309)
        Me.plPHProductSensor.Name = "plPHProductSensor"
        Me.plPHProductSensor.Size = New System.Drawing.Size(24, 24)
        Me.plPHProductSensor.TabIndex = 366
        Me.plPHProductSensor.Text = "KremerLight1"
        Me.plPHProductSensor.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'PHLimitLeft
        '
        Me.PHLimitLeft.BindControl = Me.plPHLimitLeft
        Me.PHLimitLeft.BindProperty = "Data"
        Me.PHLimitLeft.Data = Nothing
        Me.PHLimitLeft.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PHLimitLeft.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PHLimitLeft.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.PickupHead.ixLimit_Left"
        '
        'plPHLimitLeft
        '
        Me.plPHLimitLeft.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plPHLimitLeft.ColorOn = System.Drawing.Color.Lime
        Me.plPHLimitLeft.Data = False
        Me.plPHLimitLeft.Line = True
        Me.plPHLimitLeft.LineSize = 1
        Me.plPHLimitLeft.Location = New System.Drawing.Point(15, 334)
        Me.plPHLimitLeft.Name = "plPHLimitLeft"
        Me.plPHLimitLeft.Size = New System.Drawing.Size(24, 24)
        Me.plPHLimitLeft.TabIndex = 368
        Me.plPHLimitLeft.Text = "KremerLight1"
        Me.plPHLimitLeft.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'PHLimitRight
        '
        Me.PHLimitRight.BindControl = Me.plPHLimitRight
        Me.PHLimitRight.BindProperty = "Data"
        Me.PHLimitRight.Data = Nothing
        Me.PHLimitRight.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PHLimitRight.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PHLimitRight.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.PickupHead.ixLimit_Right"
        '
        'plPHLimitRight
        '
        Me.plPHLimitRight.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plPHLimitRight.ColorOn = System.Drawing.Color.Lime
        Me.plPHLimitRight.Data = False
        Me.plPHLimitRight.Line = True
        Me.plPHLimitRight.LineSize = 1
        Me.plPHLimitRight.Location = New System.Drawing.Point(15, 359)
        Me.plPHLimitRight.Name = "plPHLimitRight"
        Me.plPHLimitRight.Size = New System.Drawing.Size(24, 24)
        Me.plPHLimitRight.TabIndex = 388
        Me.plPHLimitRight.Text = "KremerLight1"
        Me.plPHLimitRight.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Btn_Overview
        '
        Me.Btn_Overview.Audit = Nothing
        Me.Btn_Overview.AuditEnabled = False
        Me.Btn_Overview.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_Overview.AuditSource = "KremerPushButton"
        Me.Btn_Overview.BackColorOn = System.Drawing.Color.Empty
        Me.Btn_Overview.BackGroundImageOn = Nothing
        Me.Btn_Overview.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_Overview.Data = False
        Me.Btn_Overview.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Overview.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_Overview.Location = New System.Drawing.Point(685, 385)
        Me.Btn_Overview.Name = "Btn_Overview"
        Me.Btn_Overview.Size = New System.Drawing.Size(114, 50)
        Me.Btn_Overview.State = False
        Me.Btn_Overview.StateIsData = True
        Me.Btn_Overview.StateText = New String() {Nothing, Nothing}
        Me.Btn_Overview.TabIndex = 5
        Me.Btn_Overview.Tag = "194"
        Me.Btn_Overview.Text = "Overview"
        Me.Btn_Overview.UserInfo = Nothing
        Me.Btn_Overview.UserLevel = 0
        Me.Btn_Overview.UseStateText = False
        Me.Btn_Overview.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(411, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(282, 25)
        Me.Label6.TabIndex = 365
        Me.Label6.Tag = ""
        Me.Label6.Text = "Horizontal Transport Denester"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 281)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(256, 25)
        Me.Label9.TabIndex = 370
        Me.Label9.Tag = ""
        Me.Label9.Text = "Pick-up head Denester"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(11, 10)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(231, 25)
        Me.Label29.TabIndex = 339
        Me.Label29.Tag = ""
        Me.Label29.Text = "Bundle Storage"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(411, 10)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(231, 25)
        Me.Label19.TabIndex = 385
        Me.Label19.Tag = ""
        Me.Label19.Text = "Carton Lift"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(446, 63)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(304, 25)
        Me.Label20.TabIndex = 384
        Me.Label20.Tag = ""
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnToggleText
        '
        Me.btnToggleText.Audit = Nothing
        Me.btnToggleText.AuditEnabled = False
        Me.btnToggleText.AuditMessage = "KremerPushButton pressed!"
        Me.btnToggleText.AuditSource = "KremerPushButton"
        Me.btnToggleText.BackColorOn = System.Drawing.Color.Empty
        Me.btnToggleText.BackGroundImageOn = Nothing
        Me.btnToggleText.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.btnToggleText.Data = False
        Me.btnToggleText.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnToggleText.ForeColorOn = System.Drawing.Color.Empty
        Me.btnToggleText.Location = New System.Drawing.Point(571, 385)
        Me.btnToggleText.Name = "btnToggleText"
        Me.btnToggleText.Size = New System.Drawing.Size(114, 50)
        Me.btnToggleText.State = False
        Me.btnToggleText.StateIsData = True
        Me.btnToggleText.StateText = New String() {Nothing, Nothing}
        Me.btnToggleText.TabIndex = 396
        Me.btnToggleText.Tag = "547"
        Me.btnToggleText.Text = "Toggle Text"
        Me.btnToggleText.UserInfo = Nothing
        Me.btnToggleText.UserLevel = 0
        Me.btnToggleText.UseStateText = False
        Me.btnToggleText.UseVisualStyleBackColor = True
        '
        'VD_BS_Level60
        '
        Me.VD_BS_Level60.BackColor = System.Drawing.SystemColors.Control
        Me.VD_BS_Level60.BackColorOn = System.Drawing.Color.Lime
        Me.VD_BS_Level60.Data = 0
        Me.VD_BS_Level60.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.VD_BS_Level60.ForeColor = System.Drawing.Color.Black
        Me.VD_BS_Level60.ForeColorOn = System.Drawing.Color.Black
        Me.VD_BS_Level60.Location = New System.Drawing.Point(46, 38)
        Me.VD_BS_Level60.Name = "VD_BS_Level60"
        Me.VD_BS_Level60.Size = New System.Drawing.Size(330, 25)
        Me.VD_BS_Level60.State = False
        Me.VD_BS_Level60.StatusText = Nothing
        Me.VD_BS_Level60.TabIndex = 397
        Me.VD_BS_Level60.Text = "Level 60 cartons / Enter new bundle"
        Me.VD_BS_Level60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VD_BS_LvlDropBundle
        '
        Me.VD_BS_LvlDropBundle.BackColor = System.Drawing.SystemColors.Control
        Me.VD_BS_LvlDropBundle.BackColorOn = System.Drawing.Color.Lime
        Me.VD_BS_LvlDropBundle.Data = 0
        Me.VD_BS_LvlDropBundle.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.VD_BS_LvlDropBundle.ForeColor = System.Drawing.Color.Black
        Me.VD_BS_LvlDropBundle.ForeColorOn = System.Drawing.Color.Black
        Me.VD_BS_LvlDropBundle.Location = New System.Drawing.Point(46, 63)
        Me.VD_BS_LvlDropBundle.Name = "VD_BS_LvlDropBundle"
        Me.VD_BS_LvlDropBundle.Size = New System.Drawing.Size(330, 25)
        Me.VD_BS_LvlDropBundle.State = False
        Me.VD_BS_LvlDropBundle.StatusText = Nothing
        Me.VD_BS_LvlDropBundle.TabIndex = 397
        Me.VD_BS_LvlDropBundle.Text = "Level drop down bundle"
        Me.VD_BS_LvlDropBundle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VD_BS_Level10
        '
        Me.VD_BS_Level10.BackColor = System.Drawing.SystemColors.Control
        Me.VD_BS_Level10.BackColorOn = System.Drawing.Color.Lime
        Me.VD_BS_Level10.Data = 0
        Me.VD_BS_Level10.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.VD_BS_Level10.ForeColor = System.Drawing.Color.Black
        Me.VD_BS_Level10.ForeColorOn = System.Drawing.Color.Black
        Me.VD_BS_Level10.Location = New System.Drawing.Point(46, 88)
        Me.VD_BS_Level10.Name = "VD_BS_Level10"
        Me.VD_BS_Level10.Size = New System.Drawing.Size(330, 25)
        Me.VD_BS_Level10.State = False
        Me.VD_BS_Level10.StatusText = Nothing
        Me.VD_BS_Level10.TabIndex = 397
        Me.VD_BS_Level10.Text = "Level 10 cartons"
        Me.VD_BS_Level10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VD_BS_LvlEmpty1
        '
        Me.VD_BS_LvlEmpty1.BackColor = System.Drawing.SystemColors.Control
        Me.VD_BS_LvlEmpty1.BackColorOn = System.Drawing.Color.Lime
        Me.VD_BS_LvlEmpty1.Data = 0
        Me.VD_BS_LvlEmpty1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.VD_BS_LvlEmpty1.ForeColor = System.Drawing.Color.Black
        Me.VD_BS_LvlEmpty1.ForeColorOn = System.Drawing.Color.Black
        Me.VD_BS_LvlEmpty1.Location = New System.Drawing.Point(46, 114)
        Me.VD_BS_LvlEmpty1.Name = "VD_BS_LvlEmpty1"
        Me.VD_BS_LvlEmpty1.Size = New System.Drawing.Size(130, 25)
        Me.VD_BS_LvlEmpty1.State = False
        Me.VD_BS_LvlEmpty1.StatusText = Nothing
        Me.VD_BS_LvlEmpty1.TabIndex = 397
        Me.VD_BS_LvlEmpty1.Text = "Level empty 1"
        Me.VD_BS_LvlEmpty1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VD_BS_LvlEmpty2
        '
        Me.VD_BS_LvlEmpty2.BackColor = System.Drawing.SystemColors.Control
        Me.VD_BS_LvlEmpty2.BackColorOn = System.Drawing.Color.Lime
        Me.VD_BS_LvlEmpty2.Data = 0
        Me.VD_BS_LvlEmpty2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.VD_BS_LvlEmpty2.ForeColor = System.Drawing.Color.Black
        Me.VD_BS_LvlEmpty2.ForeColorOn = System.Drawing.Color.Black
        Me.VD_BS_LvlEmpty2.Location = New System.Drawing.Point(211, 114)
        Me.VD_BS_LvlEmpty2.Name = "VD_BS_LvlEmpty2"
        Me.VD_BS_LvlEmpty2.Size = New System.Drawing.Size(130, 25)
        Me.VD_BS_LvlEmpty2.State = False
        Me.VD_BS_LvlEmpty2.StatusText = Nothing
        Me.VD_BS_LvlEmpty2.TabIndex = 397
        Me.VD_BS_LvlEmpty2.Text = "Level empty 2"
        Me.VD_BS_LvlEmpty2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VD_BS_ClampLeftOff
        '
        Me.VD_BS_ClampLeftOff.BackColor = System.Drawing.SystemColors.Control
        Me.VD_BS_ClampLeftOff.BackColorOn = System.Drawing.Color.Lime
        Me.VD_BS_ClampLeftOff.Data = 0
        Me.VD_BS_ClampLeftOff.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.VD_BS_ClampLeftOff.ForeColor = System.Drawing.Color.Black
        Me.VD_BS_ClampLeftOff.ForeColorOn = System.Drawing.Color.Black
        Me.VD_BS_ClampLeftOff.Location = New System.Drawing.Point(46, 140)
        Me.VD_BS_ClampLeftOff.Name = "VD_BS_ClampLeftOff"
        Me.VD_BS_ClampLeftOff.Size = New System.Drawing.Size(330, 25)
        Me.VD_BS_ClampLeftOff.State = False
        Me.VD_BS_ClampLeftOff.StatusText = Nothing
        Me.VD_BS_ClampLeftOff.TabIndex = 397
        Me.VD_BS_ClampLeftOff.Text = "Bundle clamp infeed side Off"
        Me.VD_BS_ClampLeftOff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VD_BS_ClampRightOff
        '
        Me.VD_BS_ClampRightOff.BackColor = System.Drawing.SystemColors.Control
        Me.VD_BS_ClampRightOff.BackColorOn = System.Drawing.Color.Lime
        Me.VD_BS_ClampRightOff.Data = 0
        Me.VD_BS_ClampRightOff.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.VD_BS_ClampRightOff.ForeColor = System.Drawing.Color.Black
        Me.VD_BS_ClampRightOff.ForeColorOn = System.Drawing.Color.Black
        Me.VD_BS_ClampRightOff.Location = New System.Drawing.Point(46, 165)
        Me.VD_BS_ClampRightOff.Name = "VD_BS_ClampRightOff"
        Me.VD_BS_ClampRightOff.Size = New System.Drawing.Size(330, 25)
        Me.VD_BS_ClampRightOff.State = False
        Me.VD_BS_ClampRightOff.StatusText = Nothing
        Me.VD_BS_ClampRightOff.TabIndex = 397
        Me.VD_BS_ClampRightOff.Text = "Bundle clamp outfeed side Off"
        Me.VD_BS_ClampRightOff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VD_BS_SeperatorOn
        '
        Me.VD_BS_SeperatorOn.BackColor = System.Drawing.SystemColors.Control
        Me.VD_BS_SeperatorOn.BackColorOn = System.Drawing.Color.Lime
        Me.VD_BS_SeperatorOn.Data = 0
        Me.VD_BS_SeperatorOn.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.VD_BS_SeperatorOn.ForeColor = System.Drawing.Color.Black
        Me.VD_BS_SeperatorOn.ForeColorOn = System.Drawing.Color.Black
        Me.VD_BS_SeperatorOn.Location = New System.Drawing.Point(46, 191)
        Me.VD_BS_SeperatorOn.Name = "VD_BS_SeperatorOn"
        Me.VD_BS_SeperatorOn.Size = New System.Drawing.Size(330, 25)
        Me.VD_BS_SeperatorOn.State = False
        Me.VD_BS_SeperatorOn.StatusText = Nothing
        Me.VD_BS_SeperatorOn.TabIndex = 397
        Me.VD_BS_SeperatorOn.Text = "Separator On"
        Me.VD_BS_SeperatorOn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VD_BS_SeperatorOff
        '
        Me.VD_BS_SeperatorOff.BackColor = System.Drawing.SystemColors.Control
        Me.VD_BS_SeperatorOff.BackColorOn = System.Drawing.Color.Lime
        Me.VD_BS_SeperatorOff.Data = 0
        Me.VD_BS_SeperatorOff.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.VD_BS_SeperatorOff.ForeColor = System.Drawing.Color.Black
        Me.VD_BS_SeperatorOff.ForeColorOn = System.Drawing.Color.Black
        Me.VD_BS_SeperatorOff.Location = New System.Drawing.Point(46, 216)
        Me.VD_BS_SeperatorOff.Name = "VD_BS_SeperatorOff"
        Me.VD_BS_SeperatorOff.Size = New System.Drawing.Size(330, 25)
        Me.VD_BS_SeperatorOff.State = False
        Me.VD_BS_SeperatorOff.StatusText = Nothing
        Me.VD_BS_SeperatorOff.TabIndex = 397
        Me.VD_BS_SeperatorOff.Text = "Separator Off"
        Me.VD_BS_SeperatorOff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VD_BS_ForcedLimitSens
        '
        Me.VD_BS_ForcedLimitSens.BackColor = System.Drawing.SystemColors.Control
        Me.VD_BS_ForcedLimitSens.BackColorOn = System.Drawing.Color.Lime
        Me.VD_BS_ForcedLimitSens.Data = 0
        Me.VD_BS_ForcedLimitSens.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.VD_BS_ForcedLimitSens.ForeColor = System.Drawing.Color.Black
        Me.VD_BS_ForcedLimitSens.ForeColorOn = System.Drawing.Color.Black
        Me.VD_BS_ForcedLimitSens.Location = New System.Drawing.Point(46, 239)
        Me.VD_BS_ForcedLimitSens.Name = "VD_BS_ForcedLimitSens"
        Me.VD_BS_ForcedLimitSens.Size = New System.Drawing.Size(330, 25)
        Me.VD_BS_ForcedLimitSens.State = False
        Me.VD_BS_ForcedLimitSens.StatusText = Nothing
        Me.VD_BS_ForcedLimitSens.TabIndex = 397
        Me.VD_BS_ForcedLimitSens.Text = "Forced limit sensor"
        Me.VD_BS_ForcedLimitSens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VD_PH_ProdSensor
        '
        Me.VD_PH_ProdSensor.BackColor = System.Drawing.SystemColors.Control
        Me.VD_PH_ProdSensor.BackColorOn = System.Drawing.Color.Lime
        Me.VD_PH_ProdSensor.Data = 0
        Me.VD_PH_ProdSensor.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.VD_PH_ProdSensor.ForeColor = System.Drawing.Color.Black
        Me.VD_PH_ProdSensor.ForeColorOn = System.Drawing.Color.Black
        Me.VD_PH_ProdSensor.Location = New System.Drawing.Point(46, 309)
        Me.VD_PH_ProdSensor.Name = "VD_PH_ProdSensor"
        Me.VD_PH_ProdSensor.Size = New System.Drawing.Size(330, 25)
        Me.VD_PH_ProdSensor.State = False
        Me.VD_PH_ProdSensor.StatusText = Nothing
        Me.VD_PH_ProdSensor.TabIndex = 397
        Me.VD_PH_ProdSensor.Text = "Product sensor"
        Me.VD_PH_ProdSensor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VD_PH_LimitSensLeft
        '
        Me.VD_PH_LimitSensLeft.BackColor = System.Drawing.SystemColors.Control
        Me.VD_PH_LimitSensLeft.BackColorOn = System.Drawing.Color.Lime
        Me.VD_PH_LimitSensLeft.Data = 0
        Me.VD_PH_LimitSensLeft.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.VD_PH_LimitSensLeft.ForeColor = System.Drawing.Color.Black
        Me.VD_PH_LimitSensLeft.ForeColorOn = System.Drawing.Color.Black
        Me.VD_PH_LimitSensLeft.Location = New System.Drawing.Point(46, 334)
        Me.VD_PH_LimitSensLeft.Name = "VD_PH_LimitSensLeft"
        Me.VD_PH_LimitSensLeft.Size = New System.Drawing.Size(330, 25)
        Me.VD_PH_LimitSensLeft.State = False
        Me.VD_PH_LimitSensLeft.StatusText = Nothing
        Me.VD_PH_LimitSensLeft.TabIndex = 397
        Me.VD_PH_LimitSensLeft.Text = "Limit sensor Left"
        Me.VD_PH_LimitSensLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VD_PH_LimitSensRight
        '
        Me.VD_PH_LimitSensRight.BackColor = System.Drawing.SystemColors.Control
        Me.VD_PH_LimitSensRight.BackColorOn = System.Drawing.Color.Lime
        Me.VD_PH_LimitSensRight.Data = 0
        Me.VD_PH_LimitSensRight.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.VD_PH_LimitSensRight.ForeColor = System.Drawing.Color.Black
        Me.VD_PH_LimitSensRight.ForeColorOn = System.Drawing.Color.Black
        Me.VD_PH_LimitSensRight.Location = New System.Drawing.Point(46, 359)
        Me.VD_PH_LimitSensRight.Name = "VD_PH_LimitSensRight"
        Me.VD_PH_LimitSensRight.Size = New System.Drawing.Size(330, 25)
        Me.VD_PH_LimitSensRight.State = False
        Me.VD_PH_LimitSensRight.StatusText = Nothing
        Me.VD_PH_LimitSensRight.TabIndex = 397
        Me.VD_PH_LimitSensRight.Text = "Limit sensor Right"
        Me.VD_PH_LimitSensRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VD_CL_NeedleLeftOff
        '
        Me.VD_CL_NeedleLeftOff.BackColor = System.Drawing.SystemColors.Control
        Me.VD_CL_NeedleLeftOff.BackColorOn = System.Drawing.Color.Lime
        Me.VD_CL_NeedleLeftOff.Data = 0
        Me.VD_CL_NeedleLeftOff.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.VD_CL_NeedleLeftOff.ForeColor = System.Drawing.Color.Black
        Me.VD_CL_NeedleLeftOff.ForeColorOn = System.Drawing.Color.Black
        Me.VD_CL_NeedleLeftOff.Location = New System.Drawing.Point(446, 38)
        Me.VD_CL_NeedleLeftOff.Name = "VD_CL_NeedleLeftOff"
        Me.VD_CL_NeedleLeftOff.Size = New System.Drawing.Size(330, 25)
        Me.VD_CL_NeedleLeftOff.State = False
        Me.VD_CL_NeedleLeftOff.StatusText = Nothing
        Me.VD_CL_NeedleLeftOff.TabIndex = 397
        Me.VD_CL_NeedleLeftOff.Text = "Needle infeed side Off"
        Me.VD_CL_NeedleLeftOff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VD_CL_NeedleRightOff
        '
        Me.VD_CL_NeedleRightOff.BackColor = System.Drawing.SystemColors.Control
        Me.VD_CL_NeedleRightOff.BackColorOn = System.Drawing.Color.Lime
        Me.VD_CL_NeedleRightOff.Data = 0
        Me.VD_CL_NeedleRightOff.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.VD_CL_NeedleRightOff.ForeColor = System.Drawing.Color.Black
        Me.VD_CL_NeedleRightOff.ForeColorOn = System.Drawing.Color.Black
        Me.VD_CL_NeedleRightOff.Location = New System.Drawing.Point(446, 63)
        Me.VD_CL_NeedleRightOff.Name = "VD_CL_NeedleRightOff"
        Me.VD_CL_NeedleRightOff.Size = New System.Drawing.Size(330, 25)
        Me.VD_CL_NeedleRightOff.State = False
        Me.VD_CL_NeedleRightOff.StatusText = Nothing
        Me.VD_CL_NeedleRightOff.TabIndex = 397
        Me.VD_CL_NeedleRightOff.Text = "Needle outfeed side Off"
        Me.VD_CL_NeedleRightOff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VD_CL_HomingSens
        '
        Me.VD_CL_HomingSens.BackColor = System.Drawing.SystemColors.Control
        Me.VD_CL_HomingSens.BackColorOn = System.Drawing.Color.Lime
        Me.VD_CL_HomingSens.Data = 0
        Me.VD_CL_HomingSens.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.VD_CL_HomingSens.ForeColor = System.Drawing.Color.Black
        Me.VD_CL_HomingSens.ForeColorOn = System.Drawing.Color.Black
        Me.VD_CL_HomingSens.Location = New System.Drawing.Point(446, 88)
        Me.VD_CL_HomingSens.Name = "VD_CL_HomingSens"
        Me.VD_CL_HomingSens.Size = New System.Drawing.Size(330, 25)
        Me.VD_CL_HomingSens.State = False
        Me.VD_CL_HomingSens.StatusText = Nothing
        Me.VD_CL_HomingSens.TabIndex = 397
        Me.VD_CL_HomingSens.Text = "Homing sensor"
        Me.VD_CL_HomingSens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VD_CL_NeedleLeftOn
        '
        Me.VD_CL_NeedleLeftOn.BackColor = System.Drawing.SystemColors.Control
        Me.VD_CL_NeedleLeftOn.BackColorOn = System.Drawing.Color.Lime
        Me.VD_CL_NeedleLeftOn.Data = 0
        Me.VD_CL_NeedleLeftOn.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.VD_CL_NeedleLeftOn.ForeColor = System.Drawing.Color.Black
        Me.VD_CL_NeedleLeftOn.ForeColorOn = System.Drawing.Color.Black
        Me.VD_CL_NeedleLeftOn.Location = New System.Drawing.Point(446, 114)
        Me.VD_CL_NeedleLeftOn.Name = "VD_CL_NeedleLeftOn"
        Me.VD_CL_NeedleLeftOn.Size = New System.Drawing.Size(330, 25)
        Me.VD_CL_NeedleLeftOn.State = False
        Me.VD_CL_NeedleLeftOn.StatusText = Nothing
        Me.VD_CL_NeedleLeftOn.TabIndex = 397
        Me.VD_CL_NeedleLeftOn.Text = "Needle infeed side On"
        Me.VD_CL_NeedleLeftOn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VD_CL_NeedleRightOn
        '
        Me.VD_CL_NeedleRightOn.BackColor = System.Drawing.SystemColors.Control
        Me.VD_CL_NeedleRightOn.BackColorOn = System.Drawing.Color.Lime
        Me.VD_CL_NeedleRightOn.Data = 0
        Me.VD_CL_NeedleRightOn.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.VD_CL_NeedleRightOn.ForeColor = System.Drawing.Color.Black
        Me.VD_CL_NeedleRightOn.ForeColorOn = System.Drawing.Color.Black
        Me.VD_CL_NeedleRightOn.Location = New System.Drawing.Point(446, 138)
        Me.VD_CL_NeedleRightOn.Name = "VD_CL_NeedleRightOn"
        Me.VD_CL_NeedleRightOn.Size = New System.Drawing.Size(330, 25)
        Me.VD_CL_NeedleRightOn.State = False
        Me.VD_CL_NeedleRightOn.StatusText = Nothing
        Me.VD_CL_NeedleRightOn.TabIndex = 397
        Me.VD_CL_NeedleRightOn.Text = "Needle outfeed side On"
        Me.VD_CL_NeedleRightOn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VD_HTD_ProductSens
        '
        Me.VD_HTD_ProductSens.BackColor = System.Drawing.SystemColors.Control
        Me.VD_HTD_ProductSens.BackColorOn = System.Drawing.Color.Lime
        Me.VD_HTD_ProductSens.Data = 0
        Me.VD_HTD_ProductSens.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.VD_HTD_ProductSens.ForeColor = System.Drawing.Color.Black
        Me.VD_HTD_ProductSens.ForeColorOn = System.Drawing.Color.Black
        Me.VD_HTD_ProductSens.Location = New System.Drawing.Point(446, 203)
        Me.VD_HTD_ProductSens.Name = "VD_HTD_ProductSens"
        Me.VD_HTD_ProductSens.Size = New System.Drawing.Size(330, 25)
        Me.VD_HTD_ProductSens.State = False
        Me.VD_HTD_ProductSens.StatusText = Nothing
        Me.VD_HTD_ProductSens.TabIndex = 397
        Me.VD_HTD_ProductSens.Text = "Product sensor"
        Me.VD_HTD_ProductSens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VD_HTD_LimitSensLeft
        '
        Me.VD_HTD_LimitSensLeft.BackColor = System.Drawing.SystemColors.Control
        Me.VD_HTD_LimitSensLeft.BackColorOn = System.Drawing.Color.Lime
        Me.VD_HTD_LimitSensLeft.Data = 0
        Me.VD_HTD_LimitSensLeft.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.VD_HTD_LimitSensLeft.ForeColor = System.Drawing.Color.Black
        Me.VD_HTD_LimitSensLeft.ForeColorOn = System.Drawing.Color.Black
        Me.VD_HTD_LimitSensLeft.Location = New System.Drawing.Point(446, 227)
        Me.VD_HTD_LimitSensLeft.Name = "VD_HTD_LimitSensLeft"
        Me.VD_HTD_LimitSensLeft.Size = New System.Drawing.Size(330, 25)
        Me.VD_HTD_LimitSensLeft.State = False
        Me.VD_HTD_LimitSensLeft.StatusText = Nothing
        Me.VD_HTD_LimitSensLeft.TabIndex = 397
        Me.VD_HTD_LimitSensLeft.Text = "Limit sensor Left"
        Me.VD_HTD_LimitSensLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VD_HTD_LimitSensRight
        '
        Me.VD_HTD_LimitSensRight.BackColor = System.Drawing.SystemColors.Control
        Me.VD_HTD_LimitSensRight.BackColorOn = System.Drawing.Color.Lime
        Me.VD_HTD_LimitSensRight.Data = 0
        Me.VD_HTD_LimitSensRight.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.VD_HTD_LimitSensRight.ForeColor = System.Drawing.Color.Black
        Me.VD_HTD_LimitSensRight.ForeColorOn = System.Drawing.Color.Black
        Me.VD_HTD_LimitSensRight.Location = New System.Drawing.Point(446, 252)
        Me.VD_HTD_LimitSensRight.Name = "VD_HTD_LimitSensRight"
        Me.VD_HTD_LimitSensRight.Size = New System.Drawing.Size(330, 25)
        Me.VD_HTD_LimitSensRight.State = False
        Me.VD_HTD_LimitSensRight.StatusText = Nothing
        Me.VD_HTD_LimitSensRight.TabIndex = 397
        Me.VD_HTD_LimitSensRight.Text = "Limit sensor Right"
        Me.VD_HTD_LimitSensRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VD_HTD_HighProduct
        '
        Me.VD_HTD_HighProduct.BackColor = System.Drawing.SystemColors.Control
        Me.VD_HTD_HighProduct.BackColorOn = System.Drawing.Color.Lime
        Me.VD_HTD_HighProduct.Data = 0
        Me.VD_HTD_HighProduct.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.VD_HTD_HighProduct.ForeColor = System.Drawing.Color.Black
        Me.VD_HTD_HighProduct.ForeColorOn = System.Drawing.Color.Black
        Me.VD_HTD_HighProduct.Location = New System.Drawing.Point(446, 277)
        Me.VD_HTD_HighProduct.Name = "VD_HTD_HighProduct"
        Me.VD_HTD_HighProduct.Size = New System.Drawing.Size(330, 25)
        Me.VD_HTD_HighProduct.State = False
        Me.VD_HTD_HighProduct.StatusText = Nothing
        Me.VD_HTD_HighProduct.TabIndex = 397
        Me.VD_HTD_HighProduct.Text = "High Product"
        Me.VD_HTD_HighProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IO_VDenester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.VD_BS_LvlEmpty2)
        Me.Controls.Add(Me.VD_BS_LvlEmpty1)
        Me.Controls.Add(Me.VD_BS_Level10)
        Me.Controls.Add(Me.VD_BS_SeperatorOff)
        Me.Controls.Add(Me.VD_HTD_HighProduct)
        Me.Controls.Add(Me.VD_HTD_LimitSensRight)
        Me.Controls.Add(Me.VD_PH_LimitSensRight)
        Me.Controls.Add(Me.VD_HTD_LimitSensLeft)
        Me.Controls.Add(Me.VD_PH_LimitSensLeft)
        Me.Controls.Add(Me.VD_PH_ProdSensor)
        Me.Controls.Add(Me.VD_BS_ForcedLimitSens)
        Me.Controls.Add(Me.VD_BS_SeperatorOn)
        Me.Controls.Add(Me.VD_BS_ClampRightOff)
        Me.Controls.Add(Me.VD_BS_ClampLeftOff)
        Me.Controls.Add(Me.VD_BS_LvlDropBundle)
        Me.Controls.Add(Me.VD_CL_HomingSens)
        Me.Controls.Add(Me.VD_CL_NeedleRightOff)
        Me.Controls.Add(Me.VD_HTD_ProductSens)
        Me.Controls.Add(Me.VD_CL_NeedleRightOn)
        Me.Controls.Add(Me.VD_CL_NeedleLeftOn)
        Me.Controls.Add(Me.VD_CL_NeedleLeftOff)
        Me.Controls.Add(Me.VD_BS_Level60)
        Me.Controls.Add(Me.btnToggleText)
        Me.Controls.Add(Me.plBSLevelDropDownBundle)
        Me.Controls.Add(Me.plBSLevelEmpty2)
        Me.Controls.Add(Me.plHTHighProduct)
        Me.Controls.Add(Me.plPHLimitRight)
        Me.Controls.Add(Me.plHTLimitRight)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.plCLNeedleRightoff)
        Me.Controls.Add(Me.plCLNeedleLeftOff)
        Me.Controls.Add(Me.plCLNeedleRightOn)
        Me.Controls.Add(Me.plBSForcedLimit)
        Me.Controls.Add(Me.plBSSeparatorOff)
        Me.Controls.Add(Me.plBSSeparatorOn)
        Me.Controls.Add(Me.plBSClampRightOn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.plPHLimitLeft)
        Me.Controls.Add(Me.plPHProductSensor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.plHTLimitLeft)
        Me.Controls.Add(Me.plHTProductSensor)
        Me.Controls.Add(Me.plCLNeedleLeftOn)
        Me.Controls.Add(Me.plCLHomeSensor)
        Me.Controls.Add(Me.plBSClampLeftOn)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.plBSLevelEmpty1)
        Me.Controls.Add(Me.plBSLevel10)
        Me.Controls.Add(Me.plBSLevel60)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Name = "IO_VDenester"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "545"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents plBSLevelEmpty1 As KremerControlsWin32.KremerLight
    Friend WithEvents BSLevel60 As KremerControlsWin32.KremerVariable
    Friend WithEvents plBSClampLeftOn As KremerControlsWin32.KremerLight
    Friend WithEvents plCLNeedleLeftOn As KremerControlsWin32.KremerLight
    Friend WithEvents plCLHomeSensor As KremerControlsWin32.KremerLight
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents plHTLimitLeft As KremerControlsWin32.KremerLight
    Friend WithEvents plHTProductSensor As KremerControlsWin32.KremerLight
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents plPHLimitLeft As KremerControlsWin32.KremerLight
    Friend WithEvents plPHProductSensor As KremerControlsWin32.KremerLight
    Friend WithEvents plBSLevel60 As KremerControlsWin32.KremerLight
    Friend WithEvents plBSLevel10 As KremerControlsWin32.KremerLight
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents plBSClampRightOn As KremerControlsWin32.KremerLight
    Friend WithEvents plBSSeparatorOn As KremerControlsWin32.KremerLight
    Friend WithEvents plBSSeparatorOff As KremerControlsWin32.KremerLight
    Friend WithEvents plBSForcedLimit As KremerControlsWin32.KremerLight
    Friend WithEvents plCLNeedleRightOn As KremerControlsWin32.KremerLight
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents plCLNeedleRightoff As KremerControlsWin32.KremerLight
    Friend WithEvents plCLNeedleLeftOff As KremerControlsWin32.KremerLight
    Friend WithEvents plHTLimitRight As KremerControlsWin32.KremerLight
    Friend WithEvents plPHLimitRight As KremerControlsWin32.KremerLight
    Friend WithEvents BSLevel10 As KremerControlsWin32.KremerVariable
    Friend WithEvents BSLevelEmpty1 As KremerControlsWin32.KremerVariable
    Friend WithEvents BSLowerClampLeftOff As KremerControlsWin32.KremerVariable
    Friend WithEvents BSLowerClampRightOff As KremerControlsWin32.KremerVariable
    Friend WithEvents BSSeparatorOn As KremerControlsWin32.KremerVariable
    Friend WithEvents BSSeparatorOff As KremerControlsWin32.KremerVariable
    Friend WithEvents BSForcedLimit As KremerControlsWin32.KremerVariable
    Friend WithEvents CLHomeSensor As KremerControlsWin32.KremerVariable
    Friend WithEvents CLNeedleLeftOn As KremerControlsWin32.KremerVariable
    Friend WithEvents CLNeedleRightOn As KremerControlsWin32.KremerVariable
    Friend WithEvents CLNeedleLeftOff As KremerControlsWin32.KremerVariable
    Friend WithEvents CLNeedleRightoff As KremerControlsWin32.KremerVariable
    Friend WithEvents HTProductSensor As KremerControlsWin32.KremerVariable
    Friend WithEvents HTLimitLeft As KremerControlsWin32.KremerVariable
    Friend WithEvents HTLimitRight As KremerControlsWin32.KremerVariable
    Friend WithEvents PHProductSensor As KremerControlsWin32.KremerVariable
    Friend WithEvents PHLimitLeft As KremerControlsWin32.KremerVariable
    Friend WithEvents PHLimitRight As KremerControlsWin32.KremerVariable
    Friend WithEvents HTHighProduct As KremerControlsWin32.KremerVariable
    Friend WithEvents plHTHighProduct As KremerControlsWin32.KremerLight
    Friend WithEvents plBSLevelEmpty2 As KremerControlsWin32.KremerLight
    Friend WithEvents BSLevelEmpty2 As KremerControlsWin32.KremerVariable
    Friend WithEvents BSDropDownBundle As KremerControlsWin32.KremerVariable
    Friend WithEvents plBSLevelDropDownBundle As KremerControlsWin32.KremerLight
    Friend WithEvents btnToggleText As KremerControlsWin32.KremerButton
    Friend WithEvents VD_BS_Level60 As KremerControlsWin32.KremerStatusBox
    Friend WithEvents VD_BS_LvlDropBundle As KremerControlsWin32.KremerStatusBox
    Friend WithEvents VD_BS_Level10 As KremerControlsWin32.KremerStatusBox
    Friend WithEvents VD_BS_LvlEmpty1 As KremerControlsWin32.KremerStatusBox
    Friend WithEvents VD_BS_LvlEmpty2 As KremerControlsWin32.KremerStatusBox
    Friend WithEvents VD_BS_ClampLeftOff As KremerControlsWin32.KremerStatusBox
    Friend WithEvents VD_BS_ClampRightOff As KremerControlsWin32.KremerStatusBox
    Friend WithEvents VD_BS_SeperatorOn As KremerControlsWin32.KremerStatusBox
    Friend WithEvents VD_BS_SeperatorOff As KremerControlsWin32.KremerStatusBox
    Friend WithEvents VD_BS_ForcedLimitSens As KremerControlsWin32.KremerStatusBox
    Friend WithEvents VD_PH_ProdSensor As KremerControlsWin32.KremerStatusBox
    Friend WithEvents VD_PH_LimitSensLeft As KremerControlsWin32.KremerStatusBox
    Friend WithEvents VD_PH_LimitSensRight As KremerControlsWin32.KremerStatusBox
    Friend WithEvents VD_CL_NeedleLeftOff As KremerControlsWin32.KremerStatusBox
    Friend WithEvents VD_CL_NeedleRightOff As KremerControlsWin32.KremerStatusBox
    Friend WithEvents VD_CL_HomingSens As KremerControlsWin32.KremerStatusBox
    Friend WithEvents VD_CL_NeedleLeftOn As KremerControlsWin32.KremerStatusBox
    Friend WithEvents VD_CL_NeedleRightOn As KremerControlsWin32.KremerStatusBox
    Friend WithEvents VD_HTD_ProductSens As KremerControlsWin32.KremerStatusBox
    Friend WithEvents VD_HTD_LimitSensLeft As KremerControlsWin32.KremerStatusBox
    Friend WithEvents VD_HTD_LimitSensRight As KremerControlsWin32.KremerStatusBox
    Friend WithEvents VD_HTD_HighProduct As KremerControlsWin32.KremerStatusBox

End Class
