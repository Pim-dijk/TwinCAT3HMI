<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IO_BundleAutomation
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
        Me.XaxisLimitback = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plXaxisLimitback = New KremerControlsWin32.KremerLight
        Me.XaxisLimitfront = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plXaxisLimitfront = New KremerControlsWin32.KremerLight
        Me.YaxisLeft = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plYaxisLeft = New KremerControlsWin32.KremerLight
        Me.YaxisRight = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plYaxisRight = New KremerControlsWin32.KremerLight
        Me.ZaxisUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plZaxisUp = New KremerControlsWin32.KremerLight
        Me.ZaxisDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plZaxisDown = New KremerControlsWin32.KremerLight
        Me.GrParkingPos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plParkingPosition = New KremerControlsWin32.KremerLight
        Me.GrBundleInGripper = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plGrBundleInGripper = New KremerControlsWin32.KremerLight
        Me.GrLiftFingerLeftIn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plGrLiftFingerLeftIn = New KremerControlsWin32.KremerLight
        Me.GrLiftFingerLeftOut = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plGrLiftFingerLeftOut = New KremerControlsWin32.KremerLight
        Me.GrLiftFingerRightIn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plGrLiftFingerRightIn = New KremerControlsWin32.KremerLight
        Me.GrLiftFingerRightOut = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plGrLiftFingerRightOut = New KremerControlsWin32.KremerLight
        Me.BackdoorLeftIn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plBackdoorLeftIn = New KremerControlsWin32.KremerLight
        Me.BackdoorLeftOut = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plBackdoorLeftOut = New KremerControlsWin32.KremerLight
        Me.BackdoorRightIn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plBackdoorRightIn = New KremerControlsWin32.KremerLight
        Me.BackdoorRightOut = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plBackdoorRightOut = New KremerControlsWin32.KremerLight
        Me.Btn_Overview = New KremerControlsWin32.KremerButton
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.btnToggleText = New KremerControlsWin32.KremerButton
        Me.BTU_ParkPosition = New KremerControlsWin32.KremerStatusBox
        Me.BTU_X_LimitBack = New KremerControlsWin32.KremerStatusBox
        Me.BTU_X_LimitFront = New KremerControlsWin32.KremerStatusBox
        Me.BTU_Y_LimitLeft = New KremerControlsWin32.KremerStatusBox
        Me.BTU_Y_LimitRight = New KremerControlsWin32.KremerStatusBox
        Me.BTU_Z_LimitUp = New KremerControlsWin32.KremerStatusBox
        Me.BTU_Z_LimitDown = New KremerControlsWin32.KremerStatusBox
        Me.BTU_BundleInGripper = New KremerControlsWin32.KremerStatusBox
        Me.BTU_FingerLeftOpen = New KremerControlsWin32.KremerStatusBox
        Me.BTU_FingerLeftClosed = New KremerControlsWin32.KremerStatusBox
        Me.BTU_FingerRightOpen = New KremerControlsWin32.KremerStatusBox
        Me.BTU_FingerRightClosed = New KremerControlsWin32.KremerStatusBox
        Me.BackDoorLeftOpen = New KremerControlsWin32.KremerStatusBox
        Me.BackDoorLeftClosed = New KremerControlsWin32.KremerStatusBox
        Me.BackDoorRightOpen = New KremerControlsWin32.KremerStatusBox
        Me.BackDoorRightClosed = New KremerControlsWin32.KremerStatusBox
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.XaxisLimitback)
        Me.VarCollector.Variables.Add(Me.XaxisLimitfront)
        Me.VarCollector.Variables.Add(Me.YaxisLeft)
        Me.VarCollector.Variables.Add(Me.YaxisRight)
        Me.VarCollector.Variables.Add(Me.ZaxisUp)
        Me.VarCollector.Variables.Add(Me.ZaxisDown)
        Me.VarCollector.Variables.Add(Me.GrParkingPos)
        Me.VarCollector.Variables.Add(Me.GrBundleInGripper)
        Me.VarCollector.Variables.Add(Me.GrLiftFingerLeftIn)
        Me.VarCollector.Variables.Add(Me.GrLiftFingerLeftOut)
        Me.VarCollector.Variables.Add(Me.GrLiftFingerRightIn)
        Me.VarCollector.Variables.Add(Me.GrLiftFingerRightOut)
        Me.VarCollector.Variables.Add(Me.BackdoorLeftIn)
        Me.VarCollector.Variables.Add(Me.BackdoorLeftOut)
        Me.VarCollector.Variables.Add(Me.BackdoorRightIn)
        Me.VarCollector.Variables.Add(Me.BackdoorRightOut)
        '
        'XaxisLimitback
        '
        Me.XaxisLimitback.BindControl = Me.plXaxisLimitback
        Me.XaxisLimitback.BindProperty = "Data"
        Me.XaxisLimitback.Data = Nothing
        Me.XaxisLimitback.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.XaxisLimitback.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.XaxisLimitback.VariableName = "InlineAutomation.Inline.Zipper.BundleAutomation.XAxisGantry.ixHome"
        '
        'plXaxisLimitback
        '
        Me.plXaxisLimitback.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plXaxisLimitback.ColorOn = System.Drawing.Color.Lime
        Me.plXaxisLimitback.Data = False
        Me.plXaxisLimitback.Line = True
        Me.plXaxisLimitback.LineSize = 1
        Me.plXaxisLimitback.Location = New System.Drawing.Point(273, 38)
        Me.plXaxisLimitback.Name = "plXaxisLimitback"
        Me.plXaxisLimitback.Size = New System.Drawing.Size(24, 24)
        Me.plXaxisLimitback.TabIndex = 346
        Me.plXaxisLimitback.Text = "KremerLight1"
        Me.plXaxisLimitback.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'XaxisLimitfront
        '
        Me.XaxisLimitfront.BindControl = Me.plXaxisLimitfront
        Me.XaxisLimitfront.BindProperty = "Data"
        Me.XaxisLimitfront.Data = Nothing
        Me.XaxisLimitfront.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.XaxisLimitfront.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.XaxisLimitfront.VariableName = "InlineAutomation.Inline.Zipper.BundleAutomation.XAxisGantry.ixLimit"
        '
        'plXaxisLimitfront
        '
        Me.plXaxisLimitfront.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plXaxisLimitfront.ColorOn = System.Drawing.Color.Lime
        Me.plXaxisLimitfront.Data = False
        Me.plXaxisLimitfront.Line = True
        Me.plXaxisLimitfront.LineSize = 1
        Me.plXaxisLimitfront.Location = New System.Drawing.Point(273, 63)
        Me.plXaxisLimitfront.Name = "plXaxisLimitfront"
        Me.plXaxisLimitfront.Size = New System.Drawing.Size(24, 24)
        Me.plXaxisLimitfront.TabIndex = 348
        Me.plXaxisLimitfront.Text = "KremerLight1"
        Me.plXaxisLimitfront.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'YaxisLeft
        '
        Me.YaxisLeft.BindControl = Me.plYaxisLeft
        Me.YaxisLeft.BindProperty = "Data"
        Me.YaxisLeft.Data = Nothing
        Me.YaxisLeft.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.YaxisLeft.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.YaxisLeft.VariableName = "InlineAutomation.Inline.Zipper.BundleAutomation.YAxisGantry.ixHome"
        '
        'plYaxisLeft
        '
        Me.plYaxisLeft.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plYaxisLeft.ColorOn = System.Drawing.Color.Lime
        Me.plYaxisLeft.Data = False
        Me.plYaxisLeft.Line = True
        Me.plYaxisLeft.LineSize = 1
        Me.plYaxisLeft.Location = New System.Drawing.Point(273, 130)
        Me.plYaxisLeft.Name = "plYaxisLeft"
        Me.plYaxisLeft.Size = New System.Drawing.Size(24, 24)
        Me.plYaxisLeft.TabIndex = 372
        Me.plYaxisLeft.Text = "KremerLight1"
        Me.plYaxisLeft.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'YaxisRight
        '
        Me.YaxisRight.BindControl = Me.plYaxisRight
        Me.YaxisRight.BindProperty = "Data"
        Me.YaxisRight.Data = Nothing
        Me.YaxisRight.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.YaxisRight.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.YaxisRight.VariableName = "InlineAutomation.Inline.Zipper.BundleAutomation.YAxisGantry.ixLimit"
        '
        'plYaxisRight
        '
        Me.plYaxisRight.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plYaxisRight.ColorOn = System.Drawing.Color.Lime
        Me.plYaxisRight.Data = False
        Me.plYaxisRight.Line = True
        Me.plYaxisRight.LineSize = 1
        Me.plYaxisRight.Location = New System.Drawing.Point(273, 155)
        Me.plYaxisRight.Name = "plYaxisRight"
        Me.plYaxisRight.Size = New System.Drawing.Size(24, 24)
        Me.plYaxisRight.TabIndex = 374
        Me.plYaxisRight.Text = "KremerLight1"
        Me.plYaxisRight.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'ZaxisUp
        '
        Me.ZaxisUp.BindControl = Me.plZaxisUp
        Me.ZaxisUp.BindProperty = "Data"
        Me.ZaxisUp.Data = Nothing
        Me.ZaxisUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ZaxisUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ZaxisUp.VariableName = "InlineAutomation.Inline.Zipper.BundleAutomation.ZAxisGantry.ixHome"
        '
        'plZaxisUp
        '
        Me.plZaxisUp.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plZaxisUp.ColorOn = System.Drawing.Color.Lime
        Me.plZaxisUp.Data = False
        Me.plZaxisUp.Line = True
        Me.plZaxisUp.LineSize = 1
        Me.plZaxisUp.Location = New System.Drawing.Point(273, 222)
        Me.plZaxisUp.Name = "plZaxisUp"
        Me.plZaxisUp.Size = New System.Drawing.Size(24, 24)
        Me.plZaxisUp.TabIndex = 377
        Me.plZaxisUp.Text = "KremerLight1"
        Me.plZaxisUp.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'ZaxisDown
        '
        Me.ZaxisDown.BindControl = Me.plZaxisDown
        Me.ZaxisDown.BindProperty = "Data"
        Me.ZaxisDown.Data = Nothing
        Me.ZaxisDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ZaxisDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ZaxisDown.VariableName = "InlineAutomation.Inline.Zipper.BundleAutomation.ZAxisGantry.ixLimit"
        '
        'plZaxisDown
        '
        Me.plZaxisDown.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plZaxisDown.ColorOn = System.Drawing.Color.Lime
        Me.plZaxisDown.Data = False
        Me.plZaxisDown.Line = True
        Me.plZaxisDown.LineSize = 1
        Me.plZaxisDown.Location = New System.Drawing.Point(273, 247)
        Me.plZaxisDown.Name = "plZaxisDown"
        Me.plZaxisDown.Size = New System.Drawing.Size(24, 24)
        Me.plZaxisDown.TabIndex = 379
        Me.plZaxisDown.Text = "KremerLight3"
        Me.plZaxisDown.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'GrParkingPos
        '
        Me.GrParkingPos.BindControl = Me.plParkingPosition
        Me.GrParkingPos.BindProperty = "Data"
        Me.GrParkingPos.Data = Nothing
        Me.GrParkingPos.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GrParkingPos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GrParkingPos.VariableName = "InlineAutomation.mxBundleAutomationOnParkingPosition"
        '
        'plParkingPosition
        '
        Me.plParkingPosition.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plParkingPosition.ColorOn = System.Drawing.Color.Lime
        Me.plParkingPosition.Data = False
        Me.plParkingPosition.Line = True
        Me.plParkingPosition.LineSize = 1
        Me.plParkingPosition.Location = New System.Drawing.Point(15, 38)
        Me.plParkingPosition.Name = "plParkingPosition"
        Me.plParkingPosition.Size = New System.Drawing.Size(24, 24)
        Me.plParkingPosition.TabIndex = 37
        Me.plParkingPosition.Text = "KremerLight1"
        Me.plParkingPosition.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'GrBundleInGripper
        '
        Me.GrBundleInGripper.BindControl = Me.plGrBundleInGripper
        Me.GrBundleInGripper.BindProperty = "Data"
        Me.GrBundleInGripper.Data = Nothing
        Me.GrBundleInGripper.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GrBundleInGripper.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GrBundleInGripper.VariableName = "InlineAutomation.Inline.Zipper.BundleAutomation.Gripper.ixBundlePresent"
        '
        'plGrBundleInGripper
        '
        Me.plGrBundleInGripper.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plGrBundleInGripper.ColorOn = System.Drawing.Color.Lime
        Me.plGrBundleInGripper.Data = False
        Me.plGrBundleInGripper.Line = True
        Me.plGrBundleInGripper.LineSize = 1
        Me.plGrBundleInGripper.Location = New System.Drawing.Point(543, 38)
        Me.plGrBundleInGripper.Name = "plGrBundleInGripper"
        Me.plGrBundleInGripper.Size = New System.Drawing.Size(24, 24)
        Me.plGrBundleInGripper.TabIndex = 359
        Me.plGrBundleInGripper.Text = "KremerLight1"
        Me.plGrBundleInGripper.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'GrLiftFingerLeftIn
        '
        Me.GrLiftFingerLeftIn.BindControl = Me.plGrLiftFingerLeftIn
        Me.GrLiftFingerLeftIn.BindProperty = "Data"
        Me.GrLiftFingerLeftIn.Data = Nothing
        Me.GrLiftFingerLeftIn.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GrLiftFingerLeftIn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GrLiftFingerLeftIn.VariableName = "InlineAutomation.Inline.Zipper.BundleAutomation.Gripper.FingerLeft.ixIn"
        '
        'plGrLiftFingerLeftIn
        '
        Me.plGrLiftFingerLeftIn.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plGrLiftFingerLeftIn.ColorOn = System.Drawing.Color.Lime
        Me.plGrLiftFingerLeftIn.Data = False
        Me.plGrLiftFingerLeftIn.Line = True
        Me.plGrLiftFingerLeftIn.LineSize = 1
        Me.plGrLiftFingerLeftIn.Location = New System.Drawing.Point(543, 63)
        Me.plGrLiftFingerLeftIn.Name = "plGrLiftFingerLeftIn"
        Me.plGrLiftFingerLeftIn.Size = New System.Drawing.Size(24, 24)
        Me.plGrLiftFingerLeftIn.TabIndex = 364
        Me.plGrLiftFingerLeftIn.Text = "KremerLight1"
        Me.plGrLiftFingerLeftIn.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'GrLiftFingerLeftOut
        '
        Me.GrLiftFingerLeftOut.BindControl = Me.plGrLiftFingerLeftOut
        Me.GrLiftFingerLeftOut.BindProperty = "Data"
        Me.GrLiftFingerLeftOut.Data = Nothing
        Me.GrLiftFingerLeftOut.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GrLiftFingerLeftOut.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GrLiftFingerLeftOut.VariableName = "InlineAutomation.Inline.Zipper.BundleAutomation.Gripper.FingerLeft.ixOut"
        '
        'plGrLiftFingerLeftOut
        '
        Me.plGrLiftFingerLeftOut.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plGrLiftFingerLeftOut.ColorOn = System.Drawing.Color.Lime
        Me.plGrLiftFingerLeftOut.Data = False
        Me.plGrLiftFingerLeftOut.Line = True
        Me.plGrLiftFingerLeftOut.LineSize = 1
        Me.plGrLiftFingerLeftOut.Location = New System.Drawing.Point(543, 90)
        Me.plGrLiftFingerLeftOut.Name = "plGrLiftFingerLeftOut"
        Me.plGrLiftFingerLeftOut.Size = New System.Drawing.Size(24, 24)
        Me.plGrLiftFingerLeftOut.TabIndex = 366
        Me.plGrLiftFingerLeftOut.Text = "KremerLight2"
        Me.plGrLiftFingerLeftOut.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'GrLiftFingerRightIn
        '
        Me.GrLiftFingerRightIn.BindControl = Me.plGrLiftFingerRightIn
        Me.GrLiftFingerRightIn.BindProperty = "Data"
        Me.GrLiftFingerRightIn.Data = Nothing
        Me.GrLiftFingerRightIn.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GrLiftFingerRightIn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GrLiftFingerRightIn.VariableName = "InlineAutomation.Inline.Zipper.BundleAutomation.Gripper.FingerRight.ixIn"
        '
        'plGrLiftFingerRightIn
        '
        Me.plGrLiftFingerRightIn.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plGrLiftFingerRightIn.ColorOn = System.Drawing.Color.Lime
        Me.plGrLiftFingerRightIn.Data = False
        Me.plGrLiftFingerRightIn.Line = True
        Me.plGrLiftFingerRightIn.LineSize = 1
        Me.plGrLiftFingerRightIn.Location = New System.Drawing.Point(543, 115)
        Me.plGrLiftFingerRightIn.Name = "plGrLiftFingerRightIn"
        Me.plGrLiftFingerRightIn.Size = New System.Drawing.Size(24, 24)
        Me.plGrLiftFingerRightIn.TabIndex = 368
        Me.plGrLiftFingerRightIn.Text = "KremerLight3"
        Me.plGrLiftFingerRightIn.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'GrLiftFingerRightOut
        '
        Me.GrLiftFingerRightOut.BindControl = Me.plGrLiftFingerRightOut
        Me.GrLiftFingerRightOut.BindProperty = "Data"
        Me.GrLiftFingerRightOut.Data = Nothing
        Me.GrLiftFingerRightOut.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GrLiftFingerRightOut.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GrLiftFingerRightOut.VariableName = "InlineAutomation.Inline.Zipper.BundleAutomation.Gripper.FingerRight.ixOut"
        '
        'plGrLiftFingerRightOut
        '
        Me.plGrLiftFingerRightOut.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plGrLiftFingerRightOut.ColorOn = System.Drawing.Color.Lime
        Me.plGrLiftFingerRightOut.Data = False
        Me.plGrLiftFingerRightOut.Line = True
        Me.plGrLiftFingerRightOut.LineSize = 1
        Me.plGrLiftFingerRightOut.Location = New System.Drawing.Point(543, 140)
        Me.plGrLiftFingerRightOut.Name = "plGrLiftFingerRightOut"
        Me.plGrLiftFingerRightOut.Size = New System.Drawing.Size(24, 24)
        Me.plGrLiftFingerRightOut.TabIndex = 370
        Me.plGrLiftFingerRightOut.Text = "KremerLight4"
        Me.plGrLiftFingerRightOut.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BackdoorLeftIn
        '
        Me.BackdoorLeftIn.BindControl = Me.plBackdoorLeftIn
        Me.BackdoorLeftIn.BindProperty = "Data"
        Me.BackdoorLeftIn.Data = Nothing
        Me.BackdoorLeftIn.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BackdoorLeftIn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BackdoorLeftIn.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.BundleStorage.BackdoorSupport.ixI" & _
            "n"
        '
        'plBackdoorLeftIn
        '
        Me.plBackdoorLeftIn.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plBackdoorLeftIn.ColorOn = System.Drawing.Color.Lime
        Me.plBackdoorLeftIn.Data = False
        Me.plBackdoorLeftIn.Line = True
        Me.plBackdoorLeftIn.LineSize = 1
        Me.plBackdoorLeftIn.Location = New System.Drawing.Point(543, 222)
        Me.plBackdoorLeftIn.Name = "plBackdoorLeftIn"
        Me.plBackdoorLeftIn.Size = New System.Drawing.Size(24, 25)
        Me.plBackdoorLeftIn.TabIndex = 385
        Me.plBackdoorLeftIn.Text = "KremerLight1"
        Me.plBackdoorLeftIn.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BackdoorLeftOut
        '
        Me.BackdoorLeftOut.BindControl = Me.plBackdoorLeftOut
        Me.BackdoorLeftOut.BindProperty = "Data"
        Me.BackdoorLeftOut.Data = Nothing
        Me.BackdoorLeftOut.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BackdoorLeftOut.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BackdoorLeftOut.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.BundleStorage.BackdoorSupport.ixO" & _
            "ut"
        '
        'plBackdoorLeftOut
        '
        Me.plBackdoorLeftOut.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plBackdoorLeftOut.ColorOn = System.Drawing.Color.Lime
        Me.plBackdoorLeftOut.Data = False
        Me.plBackdoorLeftOut.Line = True
        Me.plBackdoorLeftOut.LineSize = 1
        Me.plBackdoorLeftOut.Location = New System.Drawing.Point(543, 247)
        Me.plBackdoorLeftOut.Name = "plBackdoorLeftOut"
        Me.plBackdoorLeftOut.Size = New System.Drawing.Size(24, 25)
        Me.plBackdoorLeftOut.TabIndex = 387
        Me.plBackdoorLeftOut.Text = "KremerLight2"
        Me.plBackdoorLeftOut.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BackdoorRightIn
        '
        Me.BackdoorRightIn.BindControl = Me.plBackdoorRightIn
        Me.BackdoorRightIn.BindProperty = "Data"
        Me.BackdoorRightIn.Data = Nothing
        Me.BackdoorRightIn.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BackdoorRightIn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BackdoorRightIn.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.BundleStorage.BackdoorSupportR.ix" & _
            "In"
        '
        'plBackdoorRightIn
        '
        Me.plBackdoorRightIn.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plBackdoorRightIn.ColorOn = System.Drawing.Color.Lime
        Me.plBackdoorRightIn.Data = False
        Me.plBackdoorRightIn.Line = True
        Me.plBackdoorRightIn.LineSize = 1
        Me.plBackdoorRightIn.Location = New System.Drawing.Point(543, 272)
        Me.plBackdoorRightIn.Name = "plBackdoorRightIn"
        Me.plBackdoorRightIn.Size = New System.Drawing.Size(24, 25)
        Me.plBackdoorRightIn.TabIndex = 389
        Me.plBackdoorRightIn.Text = "KremerLight3"
        Me.plBackdoorRightIn.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BackdoorRightOut
        '
        Me.BackdoorRightOut.BindControl = Me.plBackdoorRightOut
        Me.BackdoorRightOut.BindProperty = "Data"
        Me.BackdoorRightOut.Data = Nothing
        Me.BackdoorRightOut.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BackdoorRightOut.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BackdoorRightOut.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.BundleStorage.BackdoorSupportR.ix" & _
            "Out"
        '
        'plBackdoorRightOut
        '
        Me.plBackdoorRightOut.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plBackdoorRightOut.ColorOn = System.Drawing.Color.Lime
        Me.plBackdoorRightOut.Data = False
        Me.plBackdoorRightOut.Line = True
        Me.plBackdoorRightOut.LineSize = 1
        Me.plBackdoorRightOut.Location = New System.Drawing.Point(543, 297)
        Me.plBackdoorRightOut.Name = "plBackdoorRightOut"
        Me.plBackdoorRightOut.Size = New System.Drawing.Size(24, 25)
        Me.plBackdoorRightOut.TabIndex = 391
        Me.plBackdoorRightOut.Text = "KremerLight4"
        Me.plBackdoorRightOut.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
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
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(12, 10)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(231, 25)
        Me.Label29.TabIndex = 339
        Me.Label29.Tag = ""
        Me.Label29.Text = "Gantry"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(270, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(231, 25)
        Me.Label6.TabIndex = 350
        Me.Label6.Tag = ""
        Me.Label6.Text = "X-axis gantry"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(540, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(231, 25)
        Me.Label12.TabIndex = 361
        Me.Label12.Tag = ""
        Me.Label12.Text = "Gripper"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(270, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 25)
        Me.Label1.TabIndex = 376
        Me.Label1.Tag = ""
        Me.Label1.Text = "Y-axis gantry"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(270, 194)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(231, 25)
        Me.Label14.TabIndex = 381
        Me.Label14.Tag = ""
        Me.Label14.Text = "Z-axis gantry"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(540, 193)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(231, 26)
        Me.Label21.TabIndex = 384
        Me.Label21.Tag = ""
        Me.Label21.Text = "Backdoor Support"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnToggleText.TabIndex = 393
        Me.btnToggleText.Tag = "547"
        Me.btnToggleText.Text = "Toggle Text"
        Me.btnToggleText.UserInfo = Nothing
        Me.btnToggleText.UserLevel = 0
        Me.btnToggleText.UseStateText = False
        Me.btnToggleText.UseVisualStyleBackColor = True
        '
        'BTU_ParkPosition
        '
        Me.BTU_ParkPosition.BackColor = System.Drawing.SystemColors.Control
        Me.BTU_ParkPosition.BackColorOn = System.Drawing.Color.Lime
        Me.BTU_ParkPosition.Data = 0
        Me.BTU_ParkPosition.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BTU_ParkPosition.ForeColor = System.Drawing.Color.Black
        Me.BTU_ParkPosition.ForeColorOn = System.Drawing.Color.Black
        Me.BTU_ParkPosition.Location = New System.Drawing.Point(46, 38)
        Me.BTU_ParkPosition.Name = "BTU_ParkPosition"
        Me.BTU_ParkPosition.Size = New System.Drawing.Size(195, 25)
        Me.BTU_ParkPosition.State = False
        Me.BTU_ParkPosition.StatusText = Nothing
        Me.BTU_ParkPosition.TabIndex = 394
        Me.BTU_ParkPosition.Text = "Park position"
        Me.BTU_ParkPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTU_X_LimitBack
        '
        Me.BTU_X_LimitBack.BackColor = System.Drawing.SystemColors.Control
        Me.BTU_X_LimitBack.BackColorOn = System.Drawing.Color.Lime
        Me.BTU_X_LimitBack.Data = 0
        Me.BTU_X_LimitBack.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BTU_X_LimitBack.ForeColor = System.Drawing.Color.Black
        Me.BTU_X_LimitBack.ForeColorOn = System.Drawing.Color.Black
        Me.BTU_X_LimitBack.Location = New System.Drawing.Point(304, 38)
        Me.BTU_X_LimitBack.Name = "BTU_X_LimitBack"
        Me.BTU_X_LimitBack.Size = New System.Drawing.Size(195, 25)
        Me.BTU_X_LimitBack.State = False
        Me.BTU_X_LimitBack.StatusText = Nothing
        Me.BTU_X_LimitBack.TabIndex = 394
        Me.BTU_X_LimitBack.Text = "Limit switch back"
        Me.BTU_X_LimitBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTU_X_LimitFront
        '
        Me.BTU_X_LimitFront.BackColor = System.Drawing.SystemColors.Control
        Me.BTU_X_LimitFront.BackColorOn = System.Drawing.Color.Lime
        Me.BTU_X_LimitFront.Data = 0
        Me.BTU_X_LimitFront.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BTU_X_LimitFront.ForeColor = System.Drawing.Color.Black
        Me.BTU_X_LimitFront.ForeColorOn = System.Drawing.Color.Black
        Me.BTU_X_LimitFront.Location = New System.Drawing.Point(304, 63)
        Me.BTU_X_LimitFront.Name = "BTU_X_LimitFront"
        Me.BTU_X_LimitFront.Size = New System.Drawing.Size(195, 25)
        Me.BTU_X_LimitFront.State = False
        Me.BTU_X_LimitFront.StatusText = Nothing
        Me.BTU_X_LimitFront.TabIndex = 394
        Me.BTU_X_LimitFront.Text = "Limit switch front"
        Me.BTU_X_LimitFront.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTU_Y_LimitLeft
        '
        Me.BTU_Y_LimitLeft.BackColor = System.Drawing.SystemColors.Control
        Me.BTU_Y_LimitLeft.BackColorOn = System.Drawing.Color.Lime
        Me.BTU_Y_LimitLeft.Data = 0
        Me.BTU_Y_LimitLeft.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BTU_Y_LimitLeft.ForeColor = System.Drawing.Color.Black
        Me.BTU_Y_LimitLeft.ForeColorOn = System.Drawing.Color.Black
        Me.BTU_Y_LimitLeft.Location = New System.Drawing.Point(304, 131)
        Me.BTU_Y_LimitLeft.Name = "BTU_Y_LimitLeft"
        Me.BTU_Y_LimitLeft.Size = New System.Drawing.Size(195, 25)
        Me.BTU_Y_LimitLeft.State = False
        Me.BTU_Y_LimitLeft.StatusText = Nothing
        Me.BTU_Y_LimitLeft.TabIndex = 394
        Me.BTU_Y_LimitLeft.Text = "Limit switch left"
        Me.BTU_Y_LimitLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTU_Y_LimitRight
        '
        Me.BTU_Y_LimitRight.BackColor = System.Drawing.SystemColors.Control
        Me.BTU_Y_LimitRight.BackColorOn = System.Drawing.Color.Lime
        Me.BTU_Y_LimitRight.Data = 0
        Me.BTU_Y_LimitRight.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BTU_Y_LimitRight.ForeColor = System.Drawing.Color.Black
        Me.BTU_Y_LimitRight.ForeColorOn = System.Drawing.Color.Black
        Me.BTU_Y_LimitRight.Location = New System.Drawing.Point(304, 156)
        Me.BTU_Y_LimitRight.Name = "BTU_Y_LimitRight"
        Me.BTU_Y_LimitRight.Size = New System.Drawing.Size(195, 25)
        Me.BTU_Y_LimitRight.State = False
        Me.BTU_Y_LimitRight.StatusText = Nothing
        Me.BTU_Y_LimitRight.TabIndex = 394
        Me.BTU_Y_LimitRight.Text = "Limit switch right"
        Me.BTU_Y_LimitRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTU_Z_LimitUp
        '
        Me.BTU_Z_LimitUp.BackColor = System.Drawing.SystemColors.Control
        Me.BTU_Z_LimitUp.BackColorOn = System.Drawing.Color.Lime
        Me.BTU_Z_LimitUp.Data = 0
        Me.BTU_Z_LimitUp.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BTU_Z_LimitUp.ForeColor = System.Drawing.Color.Black
        Me.BTU_Z_LimitUp.ForeColorOn = System.Drawing.Color.Black
        Me.BTU_Z_LimitUp.Location = New System.Drawing.Point(304, 223)
        Me.BTU_Z_LimitUp.Name = "BTU_Z_LimitUp"
        Me.BTU_Z_LimitUp.Size = New System.Drawing.Size(195, 25)
        Me.BTU_Z_LimitUp.State = False
        Me.BTU_Z_LimitUp.StatusText = Nothing
        Me.BTU_Z_LimitUp.TabIndex = 394
        Me.BTU_Z_LimitUp.Text = "Limit switch up"
        Me.BTU_Z_LimitUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTU_Z_LimitDown
        '
        Me.BTU_Z_LimitDown.BackColor = System.Drawing.SystemColors.Control
        Me.BTU_Z_LimitDown.BackColorOn = System.Drawing.Color.Lime
        Me.BTU_Z_LimitDown.Data = 0
        Me.BTU_Z_LimitDown.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BTU_Z_LimitDown.ForeColor = System.Drawing.Color.Black
        Me.BTU_Z_LimitDown.ForeColorOn = System.Drawing.Color.Black
        Me.BTU_Z_LimitDown.Location = New System.Drawing.Point(304, 247)
        Me.BTU_Z_LimitDown.Name = "BTU_Z_LimitDown"
        Me.BTU_Z_LimitDown.Size = New System.Drawing.Size(195, 25)
        Me.BTU_Z_LimitDown.State = False
        Me.BTU_Z_LimitDown.StatusText = Nothing
        Me.BTU_Z_LimitDown.TabIndex = 394
        Me.BTU_Z_LimitDown.Text = "Limit switch down"
        Me.BTU_Z_LimitDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTU_BundleInGripper
        '
        Me.BTU_BundleInGripper.BackColor = System.Drawing.SystemColors.Control
        Me.BTU_BundleInGripper.BackColorOn = System.Drawing.Color.Lime
        Me.BTU_BundleInGripper.Data = 0
        Me.BTU_BundleInGripper.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BTU_BundleInGripper.ForeColor = System.Drawing.Color.Black
        Me.BTU_BundleInGripper.ForeColorOn = System.Drawing.Color.Black
        Me.BTU_BundleInGripper.Location = New System.Drawing.Point(576, 38)
        Me.BTU_BundleInGripper.Name = "BTU_BundleInGripper"
        Me.BTU_BundleInGripper.Size = New System.Drawing.Size(220, 25)
        Me.BTU_BundleInGripper.State = False
        Me.BTU_BundleInGripper.StatusText = Nothing
        Me.BTU_BundleInGripper.TabIndex = 394
        Me.BTU_BundleInGripper.Text = "Bundle in gripper"
        Me.BTU_BundleInGripper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTU_FingerLeftOpen
        '
        Me.BTU_FingerLeftOpen.BackColor = System.Drawing.SystemColors.Control
        Me.BTU_FingerLeftOpen.BackColorOn = System.Drawing.Color.Lime
        Me.BTU_FingerLeftOpen.Data = 0
        Me.BTU_FingerLeftOpen.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BTU_FingerLeftOpen.ForeColor = System.Drawing.Color.Black
        Me.BTU_FingerLeftOpen.ForeColorOn = System.Drawing.Color.Black
        Me.BTU_FingerLeftOpen.Location = New System.Drawing.Point(576, 63)
        Me.BTU_FingerLeftOpen.Name = "BTU_FingerLeftOpen"
        Me.BTU_FingerLeftOpen.Size = New System.Drawing.Size(220, 25)
        Me.BTU_FingerLeftOpen.State = False
        Me.BTU_FingerLeftOpen.StatusText = Nothing
        Me.BTU_FingerLeftOpen.TabIndex = 394
        Me.BTU_FingerLeftOpen.Text = "Finger infeed side is open"
        Me.BTU_FingerLeftOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTU_FingerLeftClosed
        '
        Me.BTU_FingerLeftClosed.BackColor = System.Drawing.SystemColors.Control
        Me.BTU_FingerLeftClosed.BackColorOn = System.Drawing.Color.Lime
        Me.BTU_FingerLeftClosed.Data = 0
        Me.BTU_FingerLeftClosed.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BTU_FingerLeftClosed.ForeColor = System.Drawing.Color.Black
        Me.BTU_FingerLeftClosed.ForeColorOn = System.Drawing.Color.Black
        Me.BTU_FingerLeftClosed.Location = New System.Drawing.Point(576, 90)
        Me.BTU_FingerLeftClosed.Name = "BTU_FingerLeftClosed"
        Me.BTU_FingerLeftClosed.Size = New System.Drawing.Size(220, 25)
        Me.BTU_FingerLeftClosed.State = False
        Me.BTU_FingerLeftClosed.StatusText = Nothing
        Me.BTU_FingerLeftClosed.TabIndex = 394
        Me.BTU_FingerLeftClosed.Text = "Finger infeed side is closed"
        Me.BTU_FingerLeftClosed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTU_FingerRightOpen
        '
        Me.BTU_FingerRightOpen.BackColor = System.Drawing.SystemColors.Control
        Me.BTU_FingerRightOpen.BackColorOn = System.Drawing.Color.Lime
        Me.BTU_FingerRightOpen.Data = 0
        Me.BTU_FingerRightOpen.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BTU_FingerRightOpen.ForeColor = System.Drawing.Color.Black
        Me.BTU_FingerRightOpen.ForeColorOn = System.Drawing.Color.Black
        Me.BTU_FingerRightOpen.Location = New System.Drawing.Point(576, 115)
        Me.BTU_FingerRightOpen.Name = "BTU_FingerRightOpen"
        Me.BTU_FingerRightOpen.Size = New System.Drawing.Size(220, 25)
        Me.BTU_FingerRightOpen.State = False
        Me.BTU_FingerRightOpen.StatusText = Nothing
        Me.BTU_FingerRightOpen.TabIndex = 394
        Me.BTU_FingerRightOpen.Text = "Finger outfeed side is open"
        Me.BTU_FingerRightOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BTU_FingerRightClosed
        '
        Me.BTU_FingerRightClosed.BackColor = System.Drawing.SystemColors.Control
        Me.BTU_FingerRightClosed.BackColorOn = System.Drawing.Color.Lime
        Me.BTU_FingerRightClosed.Data = 0
        Me.BTU_FingerRightClosed.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BTU_FingerRightClosed.ForeColor = System.Drawing.Color.Black
        Me.BTU_FingerRightClosed.ForeColorOn = System.Drawing.Color.Black
        Me.BTU_FingerRightClosed.Location = New System.Drawing.Point(576, 140)
        Me.BTU_FingerRightClosed.Name = "BTU_FingerRightClosed"
        Me.BTU_FingerRightClosed.Size = New System.Drawing.Size(220, 25)
        Me.BTU_FingerRightClosed.State = False
        Me.BTU_FingerRightClosed.StatusText = Nothing
        Me.BTU_FingerRightClosed.TabIndex = 394
        Me.BTU_FingerRightClosed.Text = "Finger outfeed side is closed"
        Me.BTU_FingerRightClosed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BackDoorLeftOpen
        '
        Me.BackDoorLeftOpen.BackColor = System.Drawing.SystemColors.Control
        Me.BackDoorLeftOpen.BackColorOn = System.Drawing.Color.Lime
        Me.BackDoorLeftOpen.Data = 0
        Me.BackDoorLeftOpen.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BackDoorLeftOpen.ForeColor = System.Drawing.Color.Black
        Me.BackDoorLeftOpen.ForeColorOn = System.Drawing.Color.Black
        Me.BackDoorLeftOpen.Location = New System.Drawing.Point(576, 223)
        Me.BackDoorLeftOpen.Name = "BackDoorLeftOpen"
        Me.BackDoorLeftOpen.Size = New System.Drawing.Size(220, 25)
        Me.BackDoorLeftOpen.State = False
        Me.BackDoorLeftOpen.StatusText = Nothing
        Me.BackDoorLeftOpen.TabIndex = 394
        Me.BackDoorLeftOpen.Text = "Door infeed side is open"
        Me.BackDoorLeftOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BackDoorLeftClosed
        '
        Me.BackDoorLeftClosed.BackColor = System.Drawing.SystemColors.Control
        Me.BackDoorLeftClosed.BackColorOn = System.Drawing.Color.Lime
        Me.BackDoorLeftClosed.Data = 0
        Me.BackDoorLeftClosed.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BackDoorLeftClosed.ForeColor = System.Drawing.Color.Black
        Me.BackDoorLeftClosed.ForeColorOn = System.Drawing.Color.Black
        Me.BackDoorLeftClosed.Location = New System.Drawing.Point(576, 247)
        Me.BackDoorLeftClosed.Name = "BackDoorLeftClosed"
        Me.BackDoorLeftClosed.Size = New System.Drawing.Size(220, 25)
        Me.BackDoorLeftClosed.State = False
        Me.BackDoorLeftClosed.StatusText = Nothing
        Me.BackDoorLeftClosed.TabIndex = 394
        Me.BackDoorLeftClosed.Text = "Door infeed side is closed"
        Me.BackDoorLeftClosed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BackDoorRightOpen
        '
        Me.BackDoorRightOpen.BackColor = System.Drawing.SystemColors.Control
        Me.BackDoorRightOpen.BackColorOn = System.Drawing.Color.Lime
        Me.BackDoorRightOpen.Data = 0
        Me.BackDoorRightOpen.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BackDoorRightOpen.ForeColor = System.Drawing.Color.Black
        Me.BackDoorRightOpen.ForeColorOn = System.Drawing.Color.Black
        Me.BackDoorRightOpen.Location = New System.Drawing.Point(576, 272)
        Me.BackDoorRightOpen.Name = "BackDoorRightOpen"
        Me.BackDoorRightOpen.Size = New System.Drawing.Size(220, 25)
        Me.BackDoorRightOpen.State = False
        Me.BackDoorRightOpen.StatusText = Nothing
        Me.BackDoorRightOpen.TabIndex = 394
        Me.BackDoorRightOpen.Text = "Door outfeed side is open"
        Me.BackDoorRightOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BackDoorRightClosed
        '
        Me.BackDoorRightClosed.BackColor = System.Drawing.SystemColors.Control
        Me.BackDoorRightClosed.BackColorOn = System.Drawing.Color.Lime
        Me.BackDoorRightClosed.Data = 0
        Me.BackDoorRightClosed.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BackDoorRightClosed.ForeColor = System.Drawing.Color.Black
        Me.BackDoorRightClosed.ForeColorOn = System.Drawing.Color.Black
        Me.BackDoorRightClosed.Location = New System.Drawing.Point(576, 297)
        Me.BackDoorRightClosed.Name = "BackDoorRightClosed"
        Me.BackDoorRightClosed.Size = New System.Drawing.Size(220, 25)
        Me.BackDoorRightClosed.State = False
        Me.BackDoorRightClosed.StatusText = Nothing
        Me.BackDoorRightClosed.TabIndex = 394
        Me.BackDoorRightClosed.Text = "Door outfeed side is closed"
        Me.BackDoorRightClosed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IO_BundleAutomation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BTU_X_LimitFront)
        Me.Controls.Add(Me.BTU_Y_LimitRight)
        Me.Controls.Add(Me.BTU_Z_LimitDown)
        Me.Controls.Add(Me.BTU_Z_LimitUp)
        Me.Controls.Add(Me.BTU_Y_LimitLeft)
        Me.Controls.Add(Me.BTU_FingerLeftClosed)
        Me.Controls.Add(Me.BackDoorRightClosed)
        Me.Controls.Add(Me.BackDoorRightOpen)
        Me.Controls.Add(Me.BackDoorLeftClosed)
        Me.Controls.Add(Me.BackDoorLeftOpen)
        Me.Controls.Add(Me.BTU_FingerRightClosed)
        Me.Controls.Add(Me.BTU_FingerRightOpen)
        Me.Controls.Add(Me.BTU_FingerLeftOpen)
        Me.Controls.Add(Me.BTU_BundleInGripper)
        Me.Controls.Add(Me.BTU_X_LimitBack)
        Me.Controls.Add(Me.BTU_ParkPosition)
        Me.Controls.Add(Me.btnToggleText)
        Me.Controls.Add(Me.plBackdoorRightOut)
        Me.Controls.Add(Me.plBackdoorRightIn)
        Me.Controls.Add(Me.plBackdoorLeftOut)
        Me.Controls.Add(Me.plBackdoorLeftIn)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.plZaxisDown)
        Me.Controls.Add(Me.plZaxisUp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.plYaxisRight)
        Me.Controls.Add(Me.plYaxisLeft)
        Me.Controls.Add(Me.plGrLiftFingerRightOut)
        Me.Controls.Add(Me.plGrLiftFingerRightIn)
        Me.Controls.Add(Me.plGrLiftFingerLeftOut)
        Me.Controls.Add(Me.plGrLiftFingerLeftIn)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.plGrBundleInGripper)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.plXaxisLimitfront)
        Me.Controls.Add(Me.plXaxisLimitback)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.plParkingPosition)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Name = "IO_BundleAutomation"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "546"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents plParkingPosition As KremerControlsWin32.KremerLight
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents plXaxisLimitfront As KremerControlsWin32.KremerLight
    Friend WithEvents plXaxisLimitback As KremerControlsWin32.KremerLight
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents plGrBundleInGripper As KremerControlsWin32.KremerLight
    Friend WithEvents GrParkingPos As KremerControlsWin32.KremerVariable
    Friend WithEvents plGrLiftFingerLeftIn As KremerControlsWin32.KremerLight
    Friend WithEvents plGrLiftFingerLeftOut As KremerControlsWin32.KremerLight
    Friend WithEvents plGrLiftFingerRightIn As KremerControlsWin32.KremerLight
    Friend WithEvents plGrLiftFingerRightOut As KremerControlsWin32.KremerLight
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents plYaxisRight As KremerControlsWin32.KremerLight
    Friend WithEvents plYaxisLeft As KremerControlsWin32.KremerLight
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents plZaxisDown As KremerControlsWin32.KremerLight
    Friend WithEvents plZaxisUp As KremerControlsWin32.KremerLight
    Friend WithEvents XaxisLimitback As KremerControlsWin32.KremerVariable
    Friend WithEvents XaxisLimitfront As KremerControlsWin32.KremerVariable
    Friend WithEvents YaxisLeft As KremerControlsWin32.KremerVariable
    Friend WithEvents YaxisRight As KremerControlsWin32.KremerVariable
    Friend WithEvents ZaxisUp As KremerControlsWin32.KremerVariable
    Friend WithEvents ZaxisDown As KremerControlsWin32.KremerVariable
    Friend WithEvents GrBundleInGripper As KremerControlsWin32.KremerVariable
    Friend WithEvents GrLiftFingerLeftIn As KremerControlsWin32.KremerVariable
    Friend WithEvents GrLiftFingerLeftOut As KremerControlsWin32.KremerVariable
    Friend WithEvents GrLiftFingerRightIn As KremerControlsWin32.KremerVariable
    Friend WithEvents GrLiftFingerRightOut As KremerControlsWin32.KremerVariable
    Friend WithEvents plBackdoorRightOut As KremerControlsWin32.KremerLight
    Friend WithEvents plBackdoorRightIn As KremerControlsWin32.KremerLight
    Friend WithEvents plBackdoorLeftOut As KremerControlsWin32.KremerLight
    Friend WithEvents plBackdoorLeftIn As KremerControlsWin32.KremerLight
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents BackdoorLeftIn As KremerControlsWin32.KremerVariable
    Friend WithEvents BackdoorLeftOut As KremerControlsWin32.KremerVariable
    Friend WithEvents BackdoorRightIn As KremerControlsWin32.KremerVariable
    Friend WithEvents BackdoorRightOut As KremerControlsWin32.KremerVariable
    Friend WithEvents btnToggleText As KremerControlsWin32.KremerButton
    Friend WithEvents BTU_ParkPosition As KremerControlsWin32.KremerStatusBox
    Friend WithEvents BTU_X_LimitBack As KremerControlsWin32.KremerStatusBox
    Friend WithEvents BTU_X_LimitFront As KremerControlsWin32.KremerStatusBox
    Friend WithEvents BTU_Y_LimitLeft As KremerControlsWin32.KremerStatusBox
    Friend WithEvents BTU_Y_LimitRight As KremerControlsWin32.KremerStatusBox
    Friend WithEvents BTU_Z_LimitUp As KremerControlsWin32.KremerStatusBox
    Friend WithEvents BTU_Z_LimitDown As KremerControlsWin32.KremerStatusBox
    Friend WithEvents BTU_BundleInGripper As KremerControlsWin32.KremerStatusBox
    Friend WithEvents BTU_FingerLeftOpen As KremerControlsWin32.KremerStatusBox
    Friend WithEvents BTU_FingerLeftClosed As KremerControlsWin32.KremerStatusBox
    Friend WithEvents BTU_FingerRightOpen As KremerControlsWin32.KremerStatusBox
    Friend WithEvents BTU_FingerRightClosed As KremerControlsWin32.KremerStatusBox
    Friend WithEvents BackDoorLeftOpen As KremerControlsWin32.KremerStatusBox
    Friend WithEvents BackDoorLeftClosed As KremerControlsWin32.KremerStatusBox
    Friend WithEvents BackDoorRightOpen As KremerControlsWin32.KremerStatusBox
    Friend WithEvents BackDoorRightClosed As KremerControlsWin32.KremerStatusBox

End Class
