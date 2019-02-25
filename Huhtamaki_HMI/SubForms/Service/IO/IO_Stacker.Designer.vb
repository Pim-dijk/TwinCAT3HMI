<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IO_Stacker
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
        Me.ixLimit_0 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plLimit0 = New KremerControlsWin32.KremerLight
        Me.ixLimit_180 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plLimit180 = New KremerControlsWin32.KremerLight
        Me.ixProductOnHead_A = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plProdA = New KremerControlsWin32.KremerLight
        Me.ixProductOnHead_B = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plProdB = New KremerControlsWin32.KremerLight
        Me.StopperFront_AUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plStopFrontUpA = New KremerControlsWin32.KremerLight
        Me.StopperFront_ADown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plStopFrontDownA = New KremerControlsWin32.KremerLight
        Me.StopperFront_BUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plStopFrontUpB = New KremerControlsWin32.KremerLight
        Me.StopperFront_BDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plStopFrontDownB = New KremerControlsWin32.KremerLight
        Me.StopperRear_AUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plStopRearUpA = New KremerControlsWin32.KremerLight
        Me.StopperRear_ADown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plStopRearDownA = New KremerControlsWin32.KremerLight
        Me.StopperRear_BUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plStopRearUpB = New KremerControlsWin32.KremerLight
        Me.StopperRear_BDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plStopRearDownB = New KremerControlsWin32.KremerLight
        Me.ixHighProduct_A = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plHighProdA = New KremerControlsWin32.KremerLight
        Me.ixHighProduct_B = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plHighProdB = New KremerControlsWin32.KremerLight
        Me.StackingGridUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plGridUp = New KremerControlsWin32.KremerLight
        Me.StackingGridDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plGridDown = New KremerControlsWin32.KremerLight
        Me.ixLimitPosA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plLimitUpA = New KremerControlsWin32.KremerLight
        Me.ixLimitPosB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plLimitUpB = New KremerControlsWin32.KremerLight
        Me.ixLimitNegA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plLimitDownA = New KremerControlsWin32.KremerLight
        Me.ixLimitNegB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plLimitDownB = New KremerControlsWin32.KremerLight
        Me.ixHomeA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plHomeA = New KremerControlsWin32.KremerLight
        Me.ixHomeB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plHomeB = New KremerControlsWin32.KremerLight
        Me.GridFinger_FrontCloseA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plGrdFiFrontCloseA = New KremerControlsWin32.KremerLight
        Me.GridFinger_FrontCloseB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plGrdFiFrontCloseB = New KremerControlsWin32.KremerLight
        Me.GridFinger_RearCloseA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plGrdFiRearCloseA = New KremerControlsWin32.KremerLight
        Me.GridFinger_RearCloseB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plGrdFiRearCloseB = New KremerControlsWin32.KremerLight
        Me.PressHighProduct = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plPressHighProduct = New KremerControlsWin32.KremerLight
        Me.Btn_Overview = New KremerControlsWin32.KremerButton
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.btnToggleText = New KremerControlsWin32.KremerButton
        Me.PressHighProd = New KremerControlsWin32.KremerStatusBox
        Me.PickUp_LimitSwitch0 = New KremerControlsWin32.KremerStatusBox
        Me.PickUp_LimitSwitch180 = New KremerControlsWin32.KremerStatusBox
        Me.PickUp_ProdHeadA = New KremerControlsWin32.KremerStatusBox
        Me.PickUp_ProdHeadB = New KremerControlsWin32.KremerStatusBox
        Me.StackGrid_HighProdA = New KremerControlsWin32.KremerStatusBox
        Me.StackGrid_HighProdB = New KremerControlsWin32.KremerStatusBox
        Me.StackGrid_Up = New KremerControlsWin32.KremerStatusBox
        Me.StackGrid_Down = New KremerControlsWin32.KremerStatusBox
        Me.Stop_FrontAUp = New KremerControlsWin32.KremerStatusBox
        Me.Stop_FrontADown = New KremerControlsWin32.KremerStatusBox
        Me.Stop_RearAUp = New KremerControlsWin32.KremerStatusBox
        Me.Stop_RearADown = New KremerControlsWin32.KremerStatusBox
        Me.Stop_FrontBUp = New KremerControlsWin32.KremerStatusBox
        Me.Stop_RearBUp = New KremerControlsWin32.KremerStatusBox
        Me.Stop_FrontBDown = New KremerControlsWin32.KremerStatusBox
        Me.Stop_RearBDown = New KremerControlsWin32.KremerStatusBox
        Me.LiftA_SwitchUp = New KremerControlsWin32.KremerStatusBox
        Me.LiftA_SwitchDown = New KremerControlsWin32.KremerStatusBox
        Me.LiftA_HomSensor = New KremerControlsWin32.KremerStatusBox
        Me.LiftA_GridFrontClose = New KremerControlsWin32.KremerStatusBox
        Me.LiftA_GridRearClose = New KremerControlsWin32.KremerStatusBox
        Me.LiftB_SwitchUp = New KremerControlsWin32.KremerStatusBox
        Me.LiftB_SwitchDown = New KremerControlsWin32.KremerStatusBox
        Me.LiftB_HomSensor = New KremerControlsWin32.KremerStatusBox
        Me.LiftB_GridFrontClose = New KremerControlsWin32.KremerStatusBox
        Me.LiftB_GridRearClose = New KremerControlsWin32.KremerStatusBox
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.ixLimit_0)
        Me.VarCollector.Variables.Add(Me.ixLimit_180)
        Me.VarCollector.Variables.Add(Me.ixProductOnHead_A)
        Me.VarCollector.Variables.Add(Me.ixProductOnHead_B)
        Me.VarCollector.Variables.Add(Me.StopperFront_AUp)
        Me.VarCollector.Variables.Add(Me.StopperFront_ADown)
        Me.VarCollector.Variables.Add(Me.StopperFront_BUp)
        Me.VarCollector.Variables.Add(Me.StopperFront_BDown)
        Me.VarCollector.Variables.Add(Me.StopperRear_AUp)
        Me.VarCollector.Variables.Add(Me.StopperRear_ADown)
        Me.VarCollector.Variables.Add(Me.StopperRear_BUp)
        Me.VarCollector.Variables.Add(Me.StopperRear_BDown)
        Me.VarCollector.Variables.Add(Me.ixHighProduct_A)
        Me.VarCollector.Variables.Add(Me.ixHighProduct_B)
        Me.VarCollector.Variables.Add(Me.StackingGridUp)
        Me.VarCollector.Variables.Add(Me.StackingGridDown)
        Me.VarCollector.Variables.Add(Me.ixLimitPosA)
        Me.VarCollector.Variables.Add(Me.ixLimitPosB)
        Me.VarCollector.Variables.Add(Me.ixLimitNegA)
        Me.VarCollector.Variables.Add(Me.ixLimitNegB)
        Me.VarCollector.Variables.Add(Me.ixHomeA)
        Me.VarCollector.Variables.Add(Me.ixHomeB)
        Me.VarCollector.Variables.Add(Me.GridFinger_FrontCloseA)
        Me.VarCollector.Variables.Add(Me.GridFinger_FrontCloseB)
        Me.VarCollector.Variables.Add(Me.GridFinger_RearCloseA)
        Me.VarCollector.Variables.Add(Me.GridFinger_RearCloseB)
        Me.VarCollector.Variables.Add(Me.PressHighProduct)
        '
        'ixLimit_0
        '
        Me.ixLimit_0.BindControl = Me.plLimit0
        Me.ixLimit_0.BindProperty = "Data"
        Me.ixLimit_0.Data = Nothing
        Me.ixLimit_0.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ixLimit_0.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ixLimit_0.VariableName = "InlineAutomation.Stacking.PickupHead.ixLimit_0"
        '
        'plLimit0
        '
        Me.plLimit0.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plLimit0.ColorOn = System.Drawing.Color.Lime
        Me.plLimit0.Data = False
        Me.plLimit0.Line = True
        Me.plLimit0.LineSize = 1
        Me.plLimit0.Location = New System.Drawing.Point(15, 38)
        Me.plLimit0.Name = "plLimit0"
        Me.plLimit0.Size = New System.Drawing.Size(24, 24)
        Me.plLimit0.TabIndex = 37
        Me.plLimit0.Text = "KremerLight1"
        Me.plLimit0.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'ixLimit_180
        '
        Me.ixLimit_180.BindControl = Me.plLimit180
        Me.ixLimit_180.BindProperty = "Data"
        Me.ixLimit_180.Data = Nothing
        Me.ixLimit_180.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ixLimit_180.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ixLimit_180.VariableName = "InlineAutomation.Stacking.PickupHead.ixLimit_180"
        '
        'plLimit180
        '
        Me.plLimit180.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plLimit180.ColorOn = System.Drawing.Color.Lime
        Me.plLimit180.Data = False
        Me.plLimit180.Line = True
        Me.plLimit180.LineSize = 1
        Me.plLimit180.Location = New System.Drawing.Point(15, 63)
        Me.plLimit180.Name = "plLimit180"
        Me.plLimit180.Size = New System.Drawing.Size(24, 24)
        Me.plLimit180.TabIndex = 287
        Me.plLimit180.Text = "KremerLight1"
        Me.plLimit180.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'ixProductOnHead_A
        '
        Me.ixProductOnHead_A.BindControl = Me.plProdA
        Me.ixProductOnHead_A.BindProperty = "Data"
        Me.ixProductOnHead_A.Data = Nothing
        Me.ixProductOnHead_A.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ixProductOnHead_A.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ixProductOnHead_A.VariableName = "InlineAutomation.Stacking.PickupHead.ixProductOnHead_A"
        '
        'plProdA
        '
        Me.plProdA.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plProdA.ColorOn = System.Drawing.Color.Lime
        Me.plProdA.Data = False
        Me.plProdA.Line = True
        Me.plProdA.LineSize = 1
        Me.plProdA.Location = New System.Drawing.Point(15, 88)
        Me.plProdA.Name = "plProdA"
        Me.plProdA.Size = New System.Drawing.Size(24, 24)
        Me.plProdA.TabIndex = 341
        Me.plProdA.Text = "KremerLight1"
        Me.plProdA.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'ixProductOnHead_B
        '
        Me.ixProductOnHead_B.BindControl = Me.plProdB
        Me.ixProductOnHead_B.BindProperty = "Data"
        Me.ixProductOnHead_B.Data = Nothing
        Me.ixProductOnHead_B.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ixProductOnHead_B.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ixProductOnHead_B.VariableName = "InlineAutomation.Stacking.PickupHead.ixProductOnHead_B"
        '
        'plProdB
        '
        Me.plProdB.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plProdB.ColorOn = System.Drawing.Color.Lime
        Me.plProdB.Data = False
        Me.plProdB.Line = True
        Me.plProdB.LineSize = 1
        Me.plProdB.Location = New System.Drawing.Point(15, 113)
        Me.plProdB.Name = "plProdB"
        Me.plProdB.Size = New System.Drawing.Size(24, 24)
        Me.plProdB.TabIndex = 343
        Me.plProdB.Text = "KremerLight2"
        Me.plProdB.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'StopperFront_AUp
        '
        Me.StopperFront_AUp.BindControl = Me.plStopFrontUpA
        Me.StopperFront_AUp.BindProperty = "Data"
        Me.StopperFront_AUp.Data = Nothing
        Me.StopperFront_AUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.StopperFront_AUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StopperFront_AUp.VariableName = "InlineAutomation.Stacking.PickupHead.StopperFront_A.mxCilinderIsOut"
        '
        'plStopFrontUpA
        '
        Me.plStopFrontUpA.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plStopFrontUpA.ColorOn = System.Drawing.Color.Lime
        Me.plStopFrontUpA.Data = False
        Me.plStopFrontUpA.Line = True
        Me.plStopFrontUpA.LineSize = 1
        Me.plStopFrontUpA.Location = New System.Drawing.Point(15, 187)
        Me.plStopFrontUpA.Name = "plStopFrontUpA"
        Me.plStopFrontUpA.Size = New System.Drawing.Size(24, 24)
        Me.plStopFrontUpA.TabIndex = 311
        Me.plStopFrontUpA.Text = "KremerLight1"
        Me.plStopFrontUpA.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'StopperFront_ADown
        '
        Me.StopperFront_ADown.BindControl = Me.plStopFrontDownA
        Me.StopperFront_ADown.BindProperty = "Data"
        Me.StopperFront_ADown.Data = Nothing
        Me.StopperFront_ADown.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.StopperFront_ADown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StopperFront_ADown.VariableName = "InlineAutomation.Stacking.PickupHead.StopperFront_A.mxCilinderIsIn"
        '
        'plStopFrontDownA
        '
        Me.plStopFrontDownA.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plStopFrontDownA.ColorOn = System.Drawing.Color.Lime
        Me.plStopFrontDownA.Data = False
        Me.plStopFrontDownA.Line = True
        Me.plStopFrontDownA.LineSize = 1
        Me.plStopFrontDownA.Location = New System.Drawing.Point(15, 212)
        Me.plStopFrontDownA.Name = "plStopFrontDownA"
        Me.plStopFrontDownA.Size = New System.Drawing.Size(24, 24)
        Me.plStopFrontDownA.TabIndex = 313
        Me.plStopFrontDownA.Text = "KremerLight1"
        Me.plStopFrontDownA.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'StopperFront_BUp
        '
        Me.StopperFront_BUp.BindControl = Me.plStopFrontUpB
        Me.StopperFront_BUp.BindProperty = "Data"
        Me.StopperFront_BUp.Data = Nothing
        Me.StopperFront_BUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.StopperFront_BUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StopperFront_BUp.VariableName = "InlineAutomation.Stacking.PickupHead.StopperFront_B.mxCilinderIsOut"
        '
        'plStopFrontUpB
        '
        Me.plStopFrontUpB.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plStopFrontUpB.ColorOn = System.Drawing.Color.Lime
        Me.plStopFrontUpB.Data = False
        Me.plStopFrontUpB.Line = True
        Me.plStopFrontUpB.LineSize = 1
        Me.plStopFrontUpB.Location = New System.Drawing.Point(16, 290)
        Me.plStopFrontUpB.Name = "plStopFrontUpB"
        Me.plStopFrontUpB.Size = New System.Drawing.Size(24, 24)
        Me.plStopFrontUpB.TabIndex = 345
        Me.plStopFrontUpB.Text = "KremerLight1"
        Me.plStopFrontUpB.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'StopperFront_BDown
        '
        Me.StopperFront_BDown.BindControl = Me.plStopFrontDownB
        Me.StopperFront_BDown.BindProperty = "Data"
        Me.StopperFront_BDown.Data = Nothing
        Me.StopperFront_BDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.StopperFront_BDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StopperFront_BDown.VariableName = "InlineAutomation.Stacking.PickupHead.StopperFront_B.mxCilinderIsIn"
        '
        'plStopFrontDownB
        '
        Me.plStopFrontDownB.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plStopFrontDownB.ColorOn = System.Drawing.Color.Lime
        Me.plStopFrontDownB.Data = False
        Me.plStopFrontDownB.Line = True
        Me.plStopFrontDownB.LineSize = 1
        Me.plStopFrontDownB.Location = New System.Drawing.Point(16, 315)
        Me.plStopFrontDownB.Name = "plStopFrontDownB"
        Me.plStopFrontDownB.Size = New System.Drawing.Size(24, 24)
        Me.plStopFrontDownB.TabIndex = 347
        Me.plStopFrontDownB.Text = "KremerLight1"
        Me.plStopFrontDownB.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'StopperRear_AUp
        '
        Me.StopperRear_AUp.BindControl = Me.plStopRearUpA
        Me.StopperRear_AUp.BindProperty = "Data"
        Me.StopperRear_AUp.Data = Nothing
        Me.StopperRear_AUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.StopperRear_AUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StopperRear_AUp.VariableName = "InlineAutomation.Stacking.PickupHead.StopperRear_A.mxCilinderIsOut"
        '
        'plStopRearUpA
        '
        Me.plStopRearUpA.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plStopRearUpA.ColorOn = System.Drawing.Color.Lime
        Me.plStopRearUpA.Data = False
        Me.plStopRearUpA.Line = True
        Me.plStopRearUpA.LineSize = 1
        Me.plStopRearUpA.Location = New System.Drawing.Point(16, 239)
        Me.plStopRearUpA.Name = "plStopRearUpA"
        Me.plStopRearUpA.Size = New System.Drawing.Size(24, 24)
        Me.plStopRearUpA.TabIndex = 374
        Me.plStopRearUpA.Text = "KremerLight1"
        Me.plStopRearUpA.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'StopperRear_ADown
        '
        Me.StopperRear_ADown.BindControl = Me.plStopRearDownA
        Me.StopperRear_ADown.BindProperty = "Data"
        Me.StopperRear_ADown.Data = Nothing
        Me.StopperRear_ADown.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.StopperRear_ADown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StopperRear_ADown.VariableName = "InlineAutomation.Stacking.PickupHead.StopperRear_A.mxCilinderIsIn"
        '
        'plStopRearDownA
        '
        Me.plStopRearDownA.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plStopRearDownA.ColorOn = System.Drawing.Color.Lime
        Me.plStopRearDownA.Data = False
        Me.plStopRearDownA.Line = True
        Me.plStopRearDownA.LineSize = 1
        Me.plStopRearDownA.Location = New System.Drawing.Point(16, 264)
        Me.plStopRearDownA.Name = "plStopRearDownA"
        Me.plStopRearDownA.Size = New System.Drawing.Size(24, 24)
        Me.plStopRearDownA.TabIndex = 376
        Me.plStopRearDownA.Text = "KremerLight1"
        Me.plStopRearDownA.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'StopperRear_BUp
        '
        Me.StopperRear_BUp.BindControl = Me.plStopRearUpB
        Me.StopperRear_BUp.BindProperty = "Data"
        Me.StopperRear_BUp.Data = Nothing
        Me.StopperRear_BUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.StopperRear_BUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StopperRear_BUp.VariableName = "InlineAutomation.Stacking.PickupHead.StopperRear_B.mxCilinderIsOut"
        '
        'plStopRearUpB
        '
        Me.plStopRearUpB.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plStopRearUpB.ColorOn = System.Drawing.Color.Lime
        Me.plStopRearUpB.Data = False
        Me.plStopRearUpB.Line = True
        Me.plStopRearUpB.LineSize = 1
        Me.plStopRearUpB.Location = New System.Drawing.Point(15, 340)
        Me.plStopRearUpB.Name = "plStopRearUpB"
        Me.plStopRearUpB.Size = New System.Drawing.Size(24, 24)
        Me.plStopRearUpB.TabIndex = 378
        Me.plStopRearUpB.Text = "KremerLight1"
        Me.plStopRearUpB.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'StopperRear_BDown
        '
        Me.StopperRear_BDown.BindControl = Me.plStopRearDownB
        Me.StopperRear_BDown.BindProperty = "Data"
        Me.StopperRear_BDown.Data = Nothing
        Me.StopperRear_BDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.StopperRear_BDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StopperRear_BDown.VariableName = "InlineAutomation.Stacking.PickupHead.StopperRear_B.mxCilinderIsIn"
        '
        'plStopRearDownB
        '
        Me.plStopRearDownB.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plStopRearDownB.ColorOn = System.Drawing.Color.Lime
        Me.plStopRearDownB.Data = False
        Me.plStopRearDownB.Line = True
        Me.plStopRearDownB.LineSize = 1
        Me.plStopRearDownB.Location = New System.Drawing.Point(15, 365)
        Me.plStopRearDownB.Name = "plStopRearDownB"
        Me.plStopRearDownB.Size = New System.Drawing.Size(24, 24)
        Me.plStopRearDownB.TabIndex = 380
        Me.plStopRearDownB.Text = "KremerLight1"
        Me.plStopRearDownB.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'ixHighProduct_A
        '
        Me.ixHighProduct_A.BindControl = Me.plHighProdA
        Me.ixHighProduct_A.BindProperty = "Data"
        Me.ixHighProduct_A.Data = Nothing
        Me.ixHighProduct_A.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ixHighProduct_A.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ixHighProduct_A.VariableName = "InlineAutomation.Stacking.StackingGrid.ixHighProduct_A"
        '
        'plHighProdA
        '
        Me.plHighProdA.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plHighProdA.ColorOn = System.Drawing.Color.Lime
        Me.plHighProdA.Data = False
        Me.plHighProdA.Line = True
        Me.plHighProdA.LineSize = 1
        Me.plHighProdA.Location = New System.Drawing.Point(283, 38)
        Me.plHighProdA.Name = "plHighProdA"
        Me.plHighProdA.Size = New System.Drawing.Size(24, 24)
        Me.plHighProdA.TabIndex = 363
        Me.plHighProdA.Text = "KremerLight1"
        Me.plHighProdA.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'ixHighProduct_B
        '
        Me.ixHighProduct_B.BindControl = Me.plHighProdB
        Me.ixHighProduct_B.BindProperty = "Data"
        Me.ixHighProduct_B.Data = Nothing
        Me.ixHighProduct_B.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ixHighProduct_B.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ixHighProduct_B.VariableName = "InlineAutomation.Stacking.StackingGrid.ixHighProduct_B"
        '
        'plHighProdB
        '
        Me.plHighProdB.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plHighProdB.ColorOn = System.Drawing.Color.Lime
        Me.plHighProdB.Data = False
        Me.plHighProdB.Line = True
        Me.plHighProdB.LineSize = 1
        Me.plHighProdB.Location = New System.Drawing.Point(283, 63)
        Me.plHighProdB.Name = "plHighProdB"
        Me.plHighProdB.Size = New System.Drawing.Size(24, 24)
        Me.plHighProdB.TabIndex = 372
        Me.plHighProdB.Text = "KremerLight1"
        Me.plHighProdB.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'StackingGridUp
        '
        Me.StackingGridUp.BindControl = Me.plGridUp
        Me.StackingGridUp.BindProperty = "Data"
        Me.StackingGridUp.Data = Nothing
        Me.StackingGridUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.StackingGridUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StackingGridUp.VariableName = "InlineAutomation.Stacking.StackingGrid.Cilinder.mxCilinderIsOut"
        '
        'plGridUp
        '
        Me.plGridUp.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plGridUp.ColorOn = System.Drawing.Color.Lime
        Me.plGridUp.Data = False
        Me.plGridUp.Line = True
        Me.plGridUp.LineSize = 1
        Me.plGridUp.Location = New System.Drawing.Point(283, 88)
        Me.plGridUp.Name = "plGridUp"
        Me.plGridUp.Size = New System.Drawing.Size(24, 24)
        Me.plGridUp.TabIndex = 368
        Me.plGridUp.Text = "KremerLight13"
        Me.plGridUp.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'StackingGridDown
        '
        Me.StackingGridDown.BindControl = Me.plGridDown
        Me.StackingGridDown.BindProperty = "Data"
        Me.StackingGridDown.Data = Nothing
        Me.StackingGridDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.StackingGridDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.StackingGridDown.VariableName = "InlineAutomation.Stacking.StackingGrid.Cilinder.mxCilinderIsIn"
        '
        'plGridDown
        '
        Me.plGridDown.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plGridDown.ColorOn = System.Drawing.Color.Lime
        Me.plGridDown.Data = False
        Me.plGridDown.Line = True
        Me.plGridDown.LineSize = 1
        Me.plGridDown.Location = New System.Drawing.Point(283, 113)
        Me.plGridDown.Name = "plGridDown"
        Me.plGridDown.Size = New System.Drawing.Size(24, 24)
        Me.plGridDown.TabIndex = 370
        Me.plGridDown.Text = "KremerLight12"
        Me.plGridDown.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'ixLimitPosA
        '
        Me.ixLimitPosA.BindControl = Me.plLimitUpA
        Me.ixLimitPosA.BindProperty = "Data"
        Me.ixLimitPosA.Data = Nothing
        Me.ixLimitPosA.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ixLimitPosA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ixLimitPosA.VariableName = "InlineAutomation.Stacking.StackingGrid.Lift_A.ixLimitPos"
        '
        'plLimitUpA
        '
        Me.plLimitUpA.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plLimitUpA.ColorOn = System.Drawing.Color.Lime
        Me.plLimitUpA.Data = False
        Me.plLimitUpA.Line = True
        Me.plLimitUpA.LineSize = 1
        Me.plLimitUpA.Location = New System.Drawing.Point(283, 187)
        Me.plLimitUpA.Name = "plLimitUpA"
        Me.plLimitUpA.Size = New System.Drawing.Size(24, 24)
        Me.plLimitUpA.TabIndex = 289
        Me.plLimitUpA.Text = "KremerLight1"
        Me.plLimitUpA.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'ixLimitPosB
        '
        Me.ixLimitPosB.BindControl = Me.plLimitUpB
        Me.ixLimitPosB.BindProperty = "Data"
        Me.ixLimitPosB.Data = Nothing
        Me.ixLimitPosB.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ixLimitPosB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ixLimitPosB.VariableName = "InlineAutomation.Stacking.StackingGrid.Lift_B.ixLimitPos"
        '
        'plLimitUpB
        '
        Me.plLimitUpB.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plLimitUpB.ColorOn = System.Drawing.Color.Lime
        Me.plLimitUpB.Data = False
        Me.plLimitUpB.Line = True
        Me.plLimitUpB.LineSize = 1
        Me.plLimitUpB.Location = New System.Drawing.Point(553, 187)
        Me.plLimitUpB.Name = "plLimitUpB"
        Me.plLimitUpB.Size = New System.Drawing.Size(24, 24)
        Me.plLimitUpB.TabIndex = 349
        Me.plLimitUpB.Text = "KremerLight1"
        Me.plLimitUpB.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'ixLimitNegA
        '
        Me.ixLimitNegA.BindControl = Me.plLimitDownA
        Me.ixLimitNegA.BindProperty = "Data"
        Me.ixLimitNegA.Data = Nothing
        Me.ixLimitNegA.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ixLimitNegA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ixLimitNegA.VariableName = "InlineAutomation.Stacking.StackingGrid.Lift_A.ixLimitNeg"
        '
        'plLimitDownA
        '
        Me.plLimitDownA.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plLimitDownA.ColorOn = System.Drawing.Color.Lime
        Me.plLimitDownA.Data = False
        Me.plLimitDownA.Line = True
        Me.plLimitDownA.LineSize = 1
        Me.plLimitDownA.Location = New System.Drawing.Point(283, 212)
        Me.plLimitDownA.Name = "plLimitDownA"
        Me.plLimitDownA.Size = New System.Drawing.Size(24, 24)
        Me.plLimitDownA.TabIndex = 291
        Me.plLimitDownA.Text = "KremerLight1"
        Me.plLimitDownA.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'ixLimitNegB
        '
        Me.ixLimitNegB.BindControl = Me.plLimitDownB
        Me.ixLimitNegB.BindProperty = "Data"
        Me.ixLimitNegB.Data = Nothing
        Me.ixLimitNegB.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ixLimitNegB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ixLimitNegB.VariableName = "InlineAutomation.Stacking.StackingGrid.Lift_B.ixLimitNeg"
        '
        'plLimitDownB
        '
        Me.plLimitDownB.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plLimitDownB.ColorOn = System.Drawing.Color.Lime
        Me.plLimitDownB.Data = False
        Me.plLimitDownB.Line = True
        Me.plLimitDownB.LineSize = 1
        Me.plLimitDownB.Location = New System.Drawing.Point(553, 212)
        Me.plLimitDownB.Name = "plLimitDownB"
        Me.plLimitDownB.Size = New System.Drawing.Size(24, 24)
        Me.plLimitDownB.TabIndex = 351
        Me.plLimitDownB.Text = "KremerLight1"
        Me.plLimitDownB.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'ixHomeA
        '
        Me.ixHomeA.BindControl = Me.plHomeA
        Me.ixHomeA.BindProperty = "Data"
        Me.ixHomeA.Data = Nothing
        Me.ixHomeA.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ixHomeA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ixHomeA.VariableName = "InlineAutomation.Stacking.StackingGrid.Lift_A.ixHome"
        '
        'plHomeA
        '
        Me.plHomeA.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plHomeA.ColorOn = System.Drawing.Color.Lime
        Me.plHomeA.Data = False
        Me.plHomeA.Line = True
        Me.plHomeA.LineSize = 1
        Me.plHomeA.Location = New System.Drawing.Point(283, 239)
        Me.plHomeA.Name = "plHomeA"
        Me.plHomeA.Size = New System.Drawing.Size(24, 24)
        Me.plHomeA.TabIndex = 293
        Me.plHomeA.Text = "KremerLight1"
        Me.plHomeA.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'ixHomeB
        '
        Me.ixHomeB.BindControl = Me.plHomeB
        Me.ixHomeB.BindProperty = "Data"
        Me.ixHomeB.Data = Nothing
        Me.ixHomeB.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ixHomeB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ixHomeB.VariableName = "InlineAutomation.Stacking.StackingGrid.Lift_B.ixHome"
        '
        'plHomeB
        '
        Me.plHomeB.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plHomeB.ColorOn = System.Drawing.Color.Lime
        Me.plHomeB.Data = False
        Me.plHomeB.Line = True
        Me.plHomeB.LineSize = 1
        Me.plHomeB.Location = New System.Drawing.Point(553, 239)
        Me.plHomeB.Name = "plHomeB"
        Me.plHomeB.Size = New System.Drawing.Size(24, 24)
        Me.plHomeB.TabIndex = 353
        Me.plHomeB.Text = "KremerLight1"
        Me.plHomeB.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'GridFinger_FrontCloseA
        '
        Me.GridFinger_FrontCloseA.BindControl = Me.plGrdFiFrontCloseA
        Me.GridFinger_FrontCloseA.BindProperty = "Data"
        Me.GridFinger_FrontCloseA.Data = Nothing
        Me.GridFinger_FrontCloseA.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GridFinger_FrontCloseA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GridFinger_FrontCloseA.VariableName = "InlineAutomation.Stacking.StackingGrid.Lift_A.GridFinger_Front.mxCilinderIsOut"
        '
        'plGrdFiFrontCloseA
        '
        Me.plGrdFiFrontCloseA.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plGrdFiFrontCloseA.ColorOn = System.Drawing.Color.Lime
        Me.plGrdFiFrontCloseA.Data = False
        Me.plGrdFiFrontCloseA.Line = True
        Me.plGrdFiFrontCloseA.LineSize = 1
        Me.plGrdFiFrontCloseA.Location = New System.Drawing.Point(283, 266)
        Me.plGrdFiFrontCloseA.Name = "plGrdFiFrontCloseA"
        Me.plGrdFiFrontCloseA.Size = New System.Drawing.Size(24, 24)
        Me.plGrdFiFrontCloseA.TabIndex = 297
        Me.plGrdFiFrontCloseA.Text = "KremerLight1"
        Me.plGrdFiFrontCloseA.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'GridFinger_FrontCloseB
        '
        Me.GridFinger_FrontCloseB.BindControl = Me.plGrdFiFrontCloseB
        Me.GridFinger_FrontCloseB.BindProperty = "Data"
        Me.GridFinger_FrontCloseB.Data = Nothing
        Me.GridFinger_FrontCloseB.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GridFinger_FrontCloseB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GridFinger_FrontCloseB.VariableName = "InlineAutomation.Stacking.StackingGrid.Lift_B.GridFinger_Front.mxCilinderIsOut"
        '
        'plGrdFiFrontCloseB
        '
        Me.plGrdFiFrontCloseB.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plGrdFiFrontCloseB.ColorOn = System.Drawing.Color.Lime
        Me.plGrdFiFrontCloseB.Data = False
        Me.plGrdFiFrontCloseB.Line = True
        Me.plGrdFiFrontCloseB.LineSize = 1
        Me.plGrdFiFrontCloseB.Location = New System.Drawing.Point(553, 266)
        Me.plGrdFiFrontCloseB.Name = "plGrdFiFrontCloseB"
        Me.plGrdFiFrontCloseB.Size = New System.Drawing.Size(24, 24)
        Me.plGrdFiFrontCloseB.TabIndex = 357
        Me.plGrdFiFrontCloseB.Text = "KremerLight1"
        Me.plGrdFiFrontCloseB.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'GridFinger_RearCloseA
        '
        Me.GridFinger_RearCloseA.BindControl = Me.plGrdFiRearCloseA
        Me.GridFinger_RearCloseA.BindProperty = "Data"
        Me.GridFinger_RearCloseA.Data = Nothing
        Me.GridFinger_RearCloseA.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GridFinger_RearCloseA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GridFinger_RearCloseA.VariableName = "InlineAutomation.Stacking.StackingGrid.Lift_A.GridFinger_Rear.mxCilinderIsOut"
        '
        'plGrdFiRearCloseA
        '
        Me.plGrdFiRearCloseA.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plGrdFiRearCloseA.ColorOn = System.Drawing.Color.Lime
        Me.plGrdFiRearCloseA.Data = False
        Me.plGrdFiRearCloseA.Line = True
        Me.plGrdFiRearCloseA.LineSize = 1
        Me.plGrdFiRearCloseA.Location = New System.Drawing.Point(283, 293)
        Me.plGrdFiRearCloseA.Name = "plGrdFiRearCloseA"
        Me.plGrdFiRearCloseA.Size = New System.Drawing.Size(24, 24)
        Me.plGrdFiRearCloseA.TabIndex = 301
        Me.plGrdFiRearCloseA.Text = "KremerLight1"
        Me.plGrdFiRearCloseA.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'GridFinger_RearCloseB
        '
        Me.GridFinger_RearCloseB.BindControl = Me.plGrdFiRearCloseB
        Me.GridFinger_RearCloseB.BindProperty = "Data"
        Me.GridFinger_RearCloseB.Data = Nothing
        Me.GridFinger_RearCloseB.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GridFinger_RearCloseB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GridFinger_RearCloseB.VariableName = "InlineAutomation.Stacking.StackingGrid.Lift_B.GridFinger_Rear.mxCilinderIsOut"
        '
        'plGrdFiRearCloseB
        '
        Me.plGrdFiRearCloseB.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plGrdFiRearCloseB.ColorOn = System.Drawing.Color.Lime
        Me.plGrdFiRearCloseB.Data = False
        Me.plGrdFiRearCloseB.Line = True
        Me.plGrdFiRearCloseB.LineSize = 1
        Me.plGrdFiRearCloseB.Location = New System.Drawing.Point(553, 293)
        Me.plGrdFiRearCloseB.Name = "plGrdFiRearCloseB"
        Me.plGrdFiRearCloseB.Size = New System.Drawing.Size(24, 24)
        Me.plGrdFiRearCloseB.TabIndex = 361
        Me.plGrdFiRearCloseB.Text = "KremerLight1"
        Me.plGrdFiRearCloseB.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'PressHighProduct
        '
        Me.PressHighProduct.BindControl = Me.plPressHighProduct
        Me.PressHighProduct.BindProperty = "Data"
        Me.PressHighProduct.Data = Nothing
        Me.PressHighProduct.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PressHighProduct.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PressHighProduct.VariableName = "InlineAutomation.Press.ixHighProduct"
        '
        'plPressHighProduct
        '
        Me.plPressHighProduct.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plPressHighProduct.ColorOn = System.Drawing.Color.Lime
        Me.plPressHighProduct.Data = False
        Me.plPressHighProduct.Line = True
        Me.plPressHighProduct.LineSize = 1
        Me.plPressHighProduct.Location = New System.Drawing.Point(553, 38)
        Me.plPressHighProduct.Name = "plPressHighProduct"
        Me.plPressHighProduct.Size = New System.Drawing.Size(24, 24)
        Me.plPressHighProduct.TabIndex = 382
        Me.plPressHighProduct.Text = "KremerLight1"
        Me.plPressHighProduct.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
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
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(549, 162)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(231, 25)
        Me.Label27.TabIndex = 337
        Me.Label27.Tag = ""
        Me.Label27.Text = "Infeed Lift B"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(279, 162)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(231, 25)
        Me.Label28.TabIndex = 338
        Me.Label28.Tag = ""
        Me.Label28.Text = "Infeed Lift A"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(11, 10)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(231, 25)
        Me.Label29.TabIndex = 339
        Me.Label29.Tag = ""
        Me.Label29.Text = "Pick-Up Head"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(11, 162)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(231, 25)
        Me.Label30.TabIndex = 340
        Me.Label30.Tag = ""
        Me.Label30.Text = "Througfeed Stoppers"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(279, 10)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(231, 25)
        Me.Label21.TabIndex = 367
        Me.Label21.Tag = ""
        Me.Label21.Text = "Stacking Grid"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(549, 10)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(231, 25)
        Me.Label22.TabIndex = 384
        Me.Label22.Tag = ""
        Me.Label22.Text = "Press"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnToggleText.TabIndex = 385
        Me.btnToggleText.Tag = "547"
        Me.btnToggleText.Text = "Toggle Text"
        Me.btnToggleText.UserInfo = Nothing
        Me.btnToggleText.UserLevel = 0
        Me.btnToggleText.UseStateText = False
        Me.btnToggleText.UseVisualStyleBackColor = True
        '
        'PressHighProd
        '
        Me.PressHighProd.BackColor = System.Drawing.SystemColors.Control
        Me.PressHighProd.BackColorOn = System.Drawing.Color.Lime
        Me.PressHighProd.Data = 0
        Me.PressHighProd.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.PressHighProd.ForeColor = System.Drawing.Color.Black
        Me.PressHighProd.ForeColorOn = System.Drawing.Color.Black
        Me.PressHighProd.Location = New System.Drawing.Point(584, 38)
        Me.PressHighProd.Name = "PressHighProd"
        Me.PressHighProd.Size = New System.Drawing.Size(196, 25)
        Me.PressHighProd.State = False
        Me.PressHighProd.StatusText = Nothing
        Me.PressHighProd.TabIndex = 386
        Me.PressHighProd.Text = "High Product"
        Me.PressHighProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PickUp_LimitSwitch0
        '
        Me.PickUp_LimitSwitch0.BackColor = System.Drawing.SystemColors.Control
        Me.PickUp_LimitSwitch0.BackColorOn = System.Drawing.Color.Lime
        Me.PickUp_LimitSwitch0.Data = 0
        Me.PickUp_LimitSwitch0.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.PickUp_LimitSwitch0.ForeColor = System.Drawing.Color.Black
        Me.PickUp_LimitSwitch0.ForeColorOn = System.Drawing.Color.Black
        Me.PickUp_LimitSwitch0.Location = New System.Drawing.Point(47, 38)
        Me.PickUp_LimitSwitch0.Name = "PickUp_LimitSwitch0"
        Me.PickUp_LimitSwitch0.Size = New System.Drawing.Size(196, 25)
        Me.PickUp_LimitSwitch0.State = False
        Me.PickUp_LimitSwitch0.StatusText = Nothing
        Me.PickUp_LimitSwitch0.TabIndex = 386
        Me.PickUp_LimitSwitch0.Text = "Limit Switch 0°"
        Me.PickUp_LimitSwitch0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PickUp_LimitSwitch180
        '
        Me.PickUp_LimitSwitch180.BackColor = System.Drawing.SystemColors.Control
        Me.PickUp_LimitSwitch180.BackColorOn = System.Drawing.Color.Lime
        Me.PickUp_LimitSwitch180.Data = 0
        Me.PickUp_LimitSwitch180.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.PickUp_LimitSwitch180.ForeColor = System.Drawing.Color.Black
        Me.PickUp_LimitSwitch180.ForeColorOn = System.Drawing.Color.Black
        Me.PickUp_LimitSwitch180.Location = New System.Drawing.Point(47, 63)
        Me.PickUp_LimitSwitch180.Name = "PickUp_LimitSwitch180"
        Me.PickUp_LimitSwitch180.Size = New System.Drawing.Size(196, 25)
        Me.PickUp_LimitSwitch180.State = False
        Me.PickUp_LimitSwitch180.StatusText = Nothing
        Me.PickUp_LimitSwitch180.TabIndex = 386
        Me.PickUp_LimitSwitch180.Text = "Limit Switch 180°"
        Me.PickUp_LimitSwitch180.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PickUp_ProdHeadA
        '
        Me.PickUp_ProdHeadA.BackColor = System.Drawing.SystemColors.Control
        Me.PickUp_ProdHeadA.BackColorOn = System.Drawing.Color.Lime
        Me.PickUp_ProdHeadA.Data = 0
        Me.PickUp_ProdHeadA.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.PickUp_ProdHeadA.ForeColor = System.Drawing.Color.Black
        Me.PickUp_ProdHeadA.ForeColorOn = System.Drawing.Color.Black
        Me.PickUp_ProdHeadA.Location = New System.Drawing.Point(47, 88)
        Me.PickUp_ProdHeadA.Name = "PickUp_ProdHeadA"
        Me.PickUp_ProdHeadA.Size = New System.Drawing.Size(196, 25)
        Me.PickUp_ProdHeadA.State = False
        Me.PickUp_ProdHeadA.StatusText = Nothing
        Me.PickUp_ProdHeadA.TabIndex = 386
        Me.PickUp_ProdHeadA.Text = "Product on Head A"
        Me.PickUp_ProdHeadA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PickUp_ProdHeadB
        '
        Me.PickUp_ProdHeadB.BackColor = System.Drawing.SystemColors.Control
        Me.PickUp_ProdHeadB.BackColorOn = System.Drawing.Color.Lime
        Me.PickUp_ProdHeadB.Data = 0
        Me.PickUp_ProdHeadB.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.PickUp_ProdHeadB.ForeColor = System.Drawing.Color.Black
        Me.PickUp_ProdHeadB.ForeColorOn = System.Drawing.Color.Black
        Me.PickUp_ProdHeadB.Location = New System.Drawing.Point(47, 112)
        Me.PickUp_ProdHeadB.Name = "PickUp_ProdHeadB"
        Me.PickUp_ProdHeadB.Size = New System.Drawing.Size(196, 25)
        Me.PickUp_ProdHeadB.State = False
        Me.PickUp_ProdHeadB.StatusText = Nothing
        Me.PickUp_ProdHeadB.TabIndex = 386
        Me.PickUp_ProdHeadB.Text = "Product on Head B"
        Me.PickUp_ProdHeadB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StackGrid_HighProdA
        '
        Me.StackGrid_HighProdA.BackColor = System.Drawing.SystemColors.Control
        Me.StackGrid_HighProdA.BackColorOn = System.Drawing.Color.Lime
        Me.StackGrid_HighProdA.Data = 0
        Me.StackGrid_HighProdA.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.StackGrid_HighProdA.ForeColor = System.Drawing.Color.Black
        Me.StackGrid_HighProdA.ForeColorOn = System.Drawing.Color.Black
        Me.StackGrid_HighProdA.Location = New System.Drawing.Point(314, 38)
        Me.StackGrid_HighProdA.Name = "StackGrid_HighProdA"
        Me.StackGrid_HighProdA.Size = New System.Drawing.Size(196, 25)
        Me.StackGrid_HighProdA.State = False
        Me.StackGrid_HighProdA.StatusText = Nothing
        Me.StackGrid_HighProdA.TabIndex = 386
        Me.StackGrid_HighProdA.Text = "High Product A"
        Me.StackGrid_HighProdA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StackGrid_HighProdB
        '
        Me.StackGrid_HighProdB.BackColor = System.Drawing.SystemColors.Control
        Me.StackGrid_HighProdB.BackColorOn = System.Drawing.Color.Lime
        Me.StackGrid_HighProdB.Data = 0
        Me.StackGrid_HighProdB.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.StackGrid_HighProdB.ForeColor = System.Drawing.Color.Black
        Me.StackGrid_HighProdB.ForeColorOn = System.Drawing.Color.Black
        Me.StackGrid_HighProdB.Location = New System.Drawing.Point(314, 63)
        Me.StackGrid_HighProdB.Name = "StackGrid_HighProdB"
        Me.StackGrid_HighProdB.Size = New System.Drawing.Size(196, 25)
        Me.StackGrid_HighProdB.State = False
        Me.StackGrid_HighProdB.StatusText = Nothing
        Me.StackGrid_HighProdB.TabIndex = 386
        Me.StackGrid_HighProdB.Text = "High Product B"
        Me.StackGrid_HighProdB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StackGrid_Up
        '
        Me.StackGrid_Up.BackColor = System.Drawing.SystemColors.Control
        Me.StackGrid_Up.BackColorOn = System.Drawing.Color.Lime
        Me.StackGrid_Up.Data = 0
        Me.StackGrid_Up.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.StackGrid_Up.ForeColor = System.Drawing.Color.Black
        Me.StackGrid_Up.ForeColorOn = System.Drawing.Color.Black
        Me.StackGrid_Up.Location = New System.Drawing.Point(314, 88)
        Me.StackGrid_Up.Name = "StackGrid_Up"
        Me.StackGrid_Up.Size = New System.Drawing.Size(196, 25)
        Me.StackGrid_Up.State = False
        Me.StackGrid_Up.StatusText = Nothing
        Me.StackGrid_Up.TabIndex = 386
        Me.StackGrid_Up.Text = "Grid Is Up"
        Me.StackGrid_Up.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StackGrid_Down
        '
        Me.StackGrid_Down.BackColor = System.Drawing.SystemColors.Control
        Me.StackGrid_Down.BackColorOn = System.Drawing.Color.Lime
        Me.StackGrid_Down.Data = 0
        Me.StackGrid_Down.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.StackGrid_Down.ForeColor = System.Drawing.Color.Black
        Me.StackGrid_Down.ForeColorOn = System.Drawing.Color.Black
        Me.StackGrid_Down.Location = New System.Drawing.Point(314, 112)
        Me.StackGrid_Down.Name = "StackGrid_Down"
        Me.StackGrid_Down.Size = New System.Drawing.Size(196, 25)
        Me.StackGrid_Down.State = False
        Me.StackGrid_Down.StatusText = Nothing
        Me.StackGrid_Down.TabIndex = 386
        Me.StackGrid_Down.Text = "Grid Is Down"
        Me.StackGrid_Down.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Stop_FrontAUp
        '
        Me.Stop_FrontAUp.BackColor = System.Drawing.SystemColors.Control
        Me.Stop_FrontAUp.BackColorOn = System.Drawing.Color.Lime
        Me.Stop_FrontAUp.Data = 0
        Me.Stop_FrontAUp.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Stop_FrontAUp.ForeColor = System.Drawing.Color.Black
        Me.Stop_FrontAUp.ForeColorOn = System.Drawing.Color.Black
        Me.Stop_FrontAUp.Location = New System.Drawing.Point(47, 187)
        Me.Stop_FrontAUp.Name = "Stop_FrontAUp"
        Me.Stop_FrontAUp.Size = New System.Drawing.Size(196, 25)
        Me.Stop_FrontAUp.State = False
        Me.Stop_FrontAUp.StatusText = Nothing
        Me.Stop_FrontAUp.TabIndex = 386
        Me.Stop_FrontAUp.Text = "Stopper Front A Up"
        Me.Stop_FrontAUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Stop_FrontADown
        '
        Me.Stop_FrontADown.BackColor = System.Drawing.SystemColors.Control
        Me.Stop_FrontADown.BackColorOn = System.Drawing.Color.Lime
        Me.Stop_FrontADown.Data = 0
        Me.Stop_FrontADown.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Stop_FrontADown.ForeColor = System.Drawing.Color.Black
        Me.Stop_FrontADown.ForeColorOn = System.Drawing.Color.Black
        Me.Stop_FrontADown.Location = New System.Drawing.Point(47, 212)
        Me.Stop_FrontADown.Name = "Stop_FrontADown"
        Me.Stop_FrontADown.Size = New System.Drawing.Size(196, 25)
        Me.Stop_FrontADown.State = False
        Me.Stop_FrontADown.StatusText = Nothing
        Me.Stop_FrontADown.TabIndex = 386
        Me.Stop_FrontADown.Text = "Stopper Front A Down"
        Me.Stop_FrontADown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Stop_RearAUp
        '
        Me.Stop_RearAUp.BackColor = System.Drawing.SystemColors.Control
        Me.Stop_RearAUp.BackColorOn = System.Drawing.Color.Lime
        Me.Stop_RearAUp.Data = 0
        Me.Stop_RearAUp.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Stop_RearAUp.ForeColor = System.Drawing.Color.Black
        Me.Stop_RearAUp.ForeColorOn = System.Drawing.Color.Black
        Me.Stop_RearAUp.Location = New System.Drawing.Point(47, 239)
        Me.Stop_RearAUp.Name = "Stop_RearAUp"
        Me.Stop_RearAUp.Size = New System.Drawing.Size(196, 25)
        Me.Stop_RearAUp.State = False
        Me.Stop_RearAUp.StatusText = Nothing
        Me.Stop_RearAUp.TabIndex = 386
        Me.Stop_RearAUp.Text = "Stopper Rear A Up"
        Me.Stop_RearAUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Stop_RearADown
        '
        Me.Stop_RearADown.BackColor = System.Drawing.SystemColors.Control
        Me.Stop_RearADown.BackColorOn = System.Drawing.Color.Lime
        Me.Stop_RearADown.Data = 0
        Me.Stop_RearADown.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Stop_RearADown.ForeColor = System.Drawing.Color.Black
        Me.Stop_RearADown.ForeColorOn = System.Drawing.Color.Black
        Me.Stop_RearADown.Location = New System.Drawing.Point(46, 264)
        Me.Stop_RearADown.Name = "Stop_RearADown"
        Me.Stop_RearADown.Size = New System.Drawing.Size(196, 25)
        Me.Stop_RearADown.State = False
        Me.Stop_RearADown.StatusText = Nothing
        Me.Stop_RearADown.TabIndex = 386
        Me.Stop_RearADown.Text = "Stopper Rear A Down"
        Me.Stop_RearADown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Stop_FrontBUp
        '
        Me.Stop_FrontBUp.BackColor = System.Drawing.SystemColors.Control
        Me.Stop_FrontBUp.BackColorOn = System.Drawing.Color.Lime
        Me.Stop_FrontBUp.Data = 0
        Me.Stop_FrontBUp.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Stop_FrontBUp.ForeColor = System.Drawing.Color.Black
        Me.Stop_FrontBUp.ForeColorOn = System.Drawing.Color.Black
        Me.Stop_FrontBUp.Location = New System.Drawing.Point(48, 290)
        Me.Stop_FrontBUp.Name = "Stop_FrontBUp"
        Me.Stop_FrontBUp.Size = New System.Drawing.Size(196, 25)
        Me.Stop_FrontBUp.State = False
        Me.Stop_FrontBUp.StatusText = Nothing
        Me.Stop_FrontBUp.TabIndex = 386
        Me.Stop_FrontBUp.Text = "Stopper Front B Up"
        Me.Stop_FrontBUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Stop_RearBUp
        '
        Me.Stop_RearBUp.BackColor = System.Drawing.SystemColors.Control
        Me.Stop_RearBUp.BackColorOn = System.Drawing.Color.Lime
        Me.Stop_RearBUp.Data = 0
        Me.Stop_RearBUp.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Stop_RearBUp.ForeColor = System.Drawing.Color.Black
        Me.Stop_RearBUp.ForeColorOn = System.Drawing.Color.Black
        Me.Stop_RearBUp.Location = New System.Drawing.Point(48, 340)
        Me.Stop_RearBUp.Name = "Stop_RearBUp"
        Me.Stop_RearBUp.Size = New System.Drawing.Size(196, 25)
        Me.Stop_RearBUp.State = False
        Me.Stop_RearBUp.StatusText = Nothing
        Me.Stop_RearBUp.TabIndex = 386
        Me.Stop_RearBUp.Text = "Stopper Rear B Up"
        Me.Stop_RearBUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Stop_FrontBDown
        '
        Me.Stop_FrontBDown.BackColor = System.Drawing.SystemColors.Control
        Me.Stop_FrontBDown.BackColorOn = System.Drawing.Color.Lime
        Me.Stop_FrontBDown.Data = 0
        Me.Stop_FrontBDown.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Stop_FrontBDown.ForeColor = System.Drawing.Color.Black
        Me.Stop_FrontBDown.ForeColorOn = System.Drawing.Color.Black
        Me.Stop_FrontBDown.Location = New System.Drawing.Point(48, 315)
        Me.Stop_FrontBDown.Name = "Stop_FrontBDown"
        Me.Stop_FrontBDown.Size = New System.Drawing.Size(196, 25)
        Me.Stop_FrontBDown.State = False
        Me.Stop_FrontBDown.StatusText = Nothing
        Me.Stop_FrontBDown.TabIndex = 386
        Me.Stop_FrontBDown.Text = "Stopper Front B Down"
        Me.Stop_FrontBDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Stop_RearBDown
        '
        Me.Stop_RearBDown.BackColor = System.Drawing.SystemColors.Control
        Me.Stop_RearBDown.BackColorOn = System.Drawing.Color.Lime
        Me.Stop_RearBDown.Data = 0
        Me.Stop_RearBDown.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Stop_RearBDown.ForeColor = System.Drawing.Color.Black
        Me.Stop_RearBDown.ForeColorOn = System.Drawing.Color.Black
        Me.Stop_RearBDown.Location = New System.Drawing.Point(47, 364)
        Me.Stop_RearBDown.Name = "Stop_RearBDown"
        Me.Stop_RearBDown.Size = New System.Drawing.Size(196, 25)
        Me.Stop_RearBDown.State = False
        Me.Stop_RearBDown.StatusText = Nothing
        Me.Stop_RearBDown.TabIndex = 386
        Me.Stop_RearBDown.Text = "Stopper Rear B Down"
        Me.Stop_RearBDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LiftA_SwitchUp
        '
        Me.LiftA_SwitchUp.BackColor = System.Drawing.SystemColors.Control
        Me.LiftA_SwitchUp.BackColorOn = System.Drawing.Color.Lime
        Me.LiftA_SwitchUp.Data = 0
        Me.LiftA_SwitchUp.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LiftA_SwitchUp.ForeColor = System.Drawing.Color.Black
        Me.LiftA_SwitchUp.ForeColorOn = System.Drawing.Color.Black
        Me.LiftA_SwitchUp.Location = New System.Drawing.Point(314, 187)
        Me.LiftA_SwitchUp.Name = "LiftA_SwitchUp"
        Me.LiftA_SwitchUp.Size = New System.Drawing.Size(196, 25)
        Me.LiftA_SwitchUp.State = False
        Me.LiftA_SwitchUp.StatusText = Nothing
        Me.LiftA_SwitchUp.TabIndex = 386
        Me.LiftA_SwitchUp.Text = "Limit Switch Up"
        Me.LiftA_SwitchUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LiftA_SwitchDown
        '
        Me.LiftA_SwitchDown.BackColor = System.Drawing.SystemColors.Control
        Me.LiftA_SwitchDown.BackColorOn = System.Drawing.Color.Lime
        Me.LiftA_SwitchDown.Data = 0
        Me.LiftA_SwitchDown.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LiftA_SwitchDown.ForeColor = System.Drawing.Color.Black
        Me.LiftA_SwitchDown.ForeColorOn = System.Drawing.Color.Black
        Me.LiftA_SwitchDown.Location = New System.Drawing.Point(314, 212)
        Me.LiftA_SwitchDown.Name = "LiftA_SwitchDown"
        Me.LiftA_SwitchDown.Size = New System.Drawing.Size(196, 25)
        Me.LiftA_SwitchDown.State = False
        Me.LiftA_SwitchDown.StatusText = Nothing
        Me.LiftA_SwitchDown.TabIndex = 386
        Me.LiftA_SwitchDown.Text = "Limit Switch Down"
        Me.LiftA_SwitchDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LiftA_HomSensor
        '
        Me.LiftA_HomSensor.BackColor = System.Drawing.SystemColors.Control
        Me.LiftA_HomSensor.BackColorOn = System.Drawing.Color.Lime
        Me.LiftA_HomSensor.Data = 0
        Me.LiftA_HomSensor.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LiftA_HomSensor.ForeColor = System.Drawing.Color.Black
        Me.LiftA_HomSensor.ForeColorOn = System.Drawing.Color.Black
        Me.LiftA_HomSensor.Location = New System.Drawing.Point(314, 239)
        Me.LiftA_HomSensor.Name = "LiftA_HomSensor"
        Me.LiftA_HomSensor.Size = New System.Drawing.Size(196, 25)
        Me.LiftA_HomSensor.State = False
        Me.LiftA_HomSensor.StatusText = Nothing
        Me.LiftA_HomSensor.TabIndex = 386
        Me.LiftA_HomSensor.Text = "Homing Sensor"
        Me.LiftA_HomSensor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LiftA_GridFrontClose
        '
        Me.LiftA_GridFrontClose.BackColor = System.Drawing.SystemColors.Control
        Me.LiftA_GridFrontClose.BackColorOn = System.Drawing.Color.Lime
        Me.LiftA_GridFrontClose.Data = 0
        Me.LiftA_GridFrontClose.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LiftA_GridFrontClose.ForeColor = System.Drawing.Color.Black
        Me.LiftA_GridFrontClose.ForeColorOn = System.Drawing.Color.Black
        Me.LiftA_GridFrontClose.Location = New System.Drawing.Point(314, 266)
        Me.LiftA_GridFrontClose.Name = "LiftA_GridFrontClose"
        Me.LiftA_GridFrontClose.Size = New System.Drawing.Size(196, 25)
        Me.LiftA_GridFrontClose.State = False
        Me.LiftA_GridFrontClose.StatusText = Nothing
        Me.LiftA_GridFrontClose.TabIndex = 386
        Me.LiftA_GridFrontClose.Text = "Gridfinger Front Close"
        Me.LiftA_GridFrontClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LiftA_GridRearClose
        '
        Me.LiftA_GridRearClose.BackColor = System.Drawing.SystemColors.Control
        Me.LiftA_GridRearClose.BackColorOn = System.Drawing.Color.Lime
        Me.LiftA_GridRearClose.Data = 0
        Me.LiftA_GridRearClose.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LiftA_GridRearClose.ForeColor = System.Drawing.Color.Black
        Me.LiftA_GridRearClose.ForeColorOn = System.Drawing.Color.Black
        Me.LiftA_GridRearClose.Location = New System.Drawing.Point(313, 293)
        Me.LiftA_GridRearClose.Name = "LiftA_GridRearClose"
        Me.LiftA_GridRearClose.Size = New System.Drawing.Size(196, 25)
        Me.LiftA_GridRearClose.State = False
        Me.LiftA_GridRearClose.StatusText = Nothing
        Me.LiftA_GridRearClose.TabIndex = 386
        Me.LiftA_GridRearClose.Text = "Gridfinger Rear Close"
        Me.LiftA_GridRearClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LiftB_SwitchUp
        '
        Me.LiftB_SwitchUp.BackColor = System.Drawing.SystemColors.Control
        Me.LiftB_SwitchUp.BackColorOn = System.Drawing.Color.Lime
        Me.LiftB_SwitchUp.Data = 0
        Me.LiftB_SwitchUp.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LiftB_SwitchUp.ForeColor = System.Drawing.Color.Black
        Me.LiftB_SwitchUp.ForeColorOn = System.Drawing.Color.Black
        Me.LiftB_SwitchUp.Location = New System.Drawing.Point(583, 187)
        Me.LiftB_SwitchUp.Name = "LiftB_SwitchUp"
        Me.LiftB_SwitchUp.Size = New System.Drawing.Size(196, 25)
        Me.LiftB_SwitchUp.State = False
        Me.LiftB_SwitchUp.StatusText = Nothing
        Me.LiftB_SwitchUp.TabIndex = 386
        Me.LiftB_SwitchUp.Text = "Limit Switch Up"
        Me.LiftB_SwitchUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LiftB_SwitchDown
        '
        Me.LiftB_SwitchDown.BackColor = System.Drawing.SystemColors.Control
        Me.LiftB_SwitchDown.BackColorOn = System.Drawing.Color.Lime
        Me.LiftB_SwitchDown.Data = 0
        Me.LiftB_SwitchDown.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LiftB_SwitchDown.ForeColor = System.Drawing.Color.Black
        Me.LiftB_SwitchDown.ForeColorOn = System.Drawing.Color.Black
        Me.LiftB_SwitchDown.Location = New System.Drawing.Point(583, 212)
        Me.LiftB_SwitchDown.Name = "LiftB_SwitchDown"
        Me.LiftB_SwitchDown.Size = New System.Drawing.Size(196, 25)
        Me.LiftB_SwitchDown.State = False
        Me.LiftB_SwitchDown.StatusText = Nothing
        Me.LiftB_SwitchDown.TabIndex = 386
        Me.LiftB_SwitchDown.Text = "Limit Switch Down"
        Me.LiftB_SwitchDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LiftB_HomSensor
        '
        Me.LiftB_HomSensor.BackColor = System.Drawing.SystemColors.Control
        Me.LiftB_HomSensor.BackColorOn = System.Drawing.Color.Lime
        Me.LiftB_HomSensor.Data = 0
        Me.LiftB_HomSensor.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LiftB_HomSensor.ForeColor = System.Drawing.Color.Black
        Me.LiftB_HomSensor.ForeColorOn = System.Drawing.Color.Black
        Me.LiftB_HomSensor.Location = New System.Drawing.Point(583, 239)
        Me.LiftB_HomSensor.Name = "LiftB_HomSensor"
        Me.LiftB_HomSensor.Size = New System.Drawing.Size(196, 25)
        Me.LiftB_HomSensor.State = False
        Me.LiftB_HomSensor.StatusText = Nothing
        Me.LiftB_HomSensor.TabIndex = 386
        Me.LiftB_HomSensor.Text = "Homing Sensor"
        Me.LiftB_HomSensor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LiftB_GridFrontClose
        '
        Me.LiftB_GridFrontClose.BackColor = System.Drawing.SystemColors.Control
        Me.LiftB_GridFrontClose.BackColorOn = System.Drawing.Color.Lime
        Me.LiftB_GridFrontClose.Data = 0
        Me.LiftB_GridFrontClose.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LiftB_GridFrontClose.ForeColor = System.Drawing.Color.Black
        Me.LiftB_GridFrontClose.ForeColorOn = System.Drawing.Color.Black
        Me.LiftB_GridFrontClose.Location = New System.Drawing.Point(583, 266)
        Me.LiftB_GridFrontClose.Name = "LiftB_GridFrontClose"
        Me.LiftB_GridFrontClose.Size = New System.Drawing.Size(196, 25)
        Me.LiftB_GridFrontClose.State = False
        Me.LiftB_GridFrontClose.StatusText = Nothing
        Me.LiftB_GridFrontClose.TabIndex = 386
        Me.LiftB_GridFrontClose.Text = "Gridfinger Front Close"
        Me.LiftB_GridFrontClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LiftB_GridRearClose
        '
        Me.LiftB_GridRearClose.BackColor = System.Drawing.SystemColors.Control
        Me.LiftB_GridRearClose.BackColorOn = System.Drawing.Color.Lime
        Me.LiftB_GridRearClose.Data = 0
        Me.LiftB_GridRearClose.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.LiftB_GridRearClose.ForeColor = System.Drawing.Color.Black
        Me.LiftB_GridRearClose.ForeColorOn = System.Drawing.Color.Black
        Me.LiftB_GridRearClose.Location = New System.Drawing.Point(582, 293)
        Me.LiftB_GridRearClose.Name = "LiftB_GridRearClose"
        Me.LiftB_GridRearClose.Size = New System.Drawing.Size(196, 25)
        Me.LiftB_GridRearClose.State = False
        Me.LiftB_GridRearClose.StatusText = Nothing
        Me.LiftB_GridRearClose.TabIndex = 386
        Me.LiftB_GridRearClose.Text = "Gridfinger Rear Close"
        Me.LiftB_GridRearClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IO_Stacker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PickUp_ProdHeadB)
        Me.Controls.Add(Me.PickUp_ProdHeadA)
        Me.Controls.Add(Me.PickUp_LimitSwitch180)
        Me.Controls.Add(Me.Stop_RearBDown)
        Me.Controls.Add(Me.Stop_FrontBDown)
        Me.Controls.Add(Me.Stop_RearADown)
        Me.Controls.Add(Me.Stop_RearBUp)
        Me.Controls.Add(Me.Stop_FrontADown)
        Me.Controls.Add(Me.Stop_FrontBUp)
        Me.Controls.Add(Me.Stop_RearAUp)
        Me.Controls.Add(Me.LiftB_GridRearClose)
        Me.Controls.Add(Me.LiftA_GridRearClose)
        Me.Controls.Add(Me.LiftB_GridFrontClose)
        Me.Controls.Add(Me.LiftA_GridFrontClose)
        Me.Controls.Add(Me.LiftB_HomSensor)
        Me.Controls.Add(Me.LiftA_HomSensor)
        Me.Controls.Add(Me.LiftB_SwitchDown)
        Me.Controls.Add(Me.LiftA_SwitchDown)
        Me.Controls.Add(Me.LiftB_SwitchUp)
        Me.Controls.Add(Me.LiftA_SwitchUp)
        Me.Controls.Add(Me.Stop_FrontAUp)
        Me.Controls.Add(Me.StackGrid_Down)
        Me.Controls.Add(Me.StackGrid_Up)
        Me.Controls.Add(Me.StackGrid_HighProdB)
        Me.Controls.Add(Me.StackGrid_HighProdA)
        Me.Controls.Add(Me.PickUp_LimitSwitch0)
        Me.Controls.Add(Me.PressHighProd)
        Me.Controls.Add(Me.btnToggleText)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.plPressHighProduct)
        Me.Controls.Add(Me.plStopRearDownB)
        Me.Controls.Add(Me.plStopRearUpB)
        Me.Controls.Add(Me.plStopRearDownA)
        Me.Controls.Add(Me.plStopRearUpA)
        Me.Controls.Add(Me.plHighProdB)
        Me.Controls.Add(Me.plGridDown)
        Me.Controls.Add(Me.plGridUp)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.plHighProdA)
        Me.Controls.Add(Me.plGrdFiRearCloseB)
        Me.Controls.Add(Me.plGrdFiFrontCloseB)
        Me.Controls.Add(Me.plHomeB)
        Me.Controls.Add(Me.plLimitDownB)
        Me.Controls.Add(Me.plLimitUpB)
        Me.Controls.Add(Me.plStopFrontDownB)
        Me.Controls.Add(Me.plStopFrontUpB)
        Me.Controls.Add(Me.plProdB)
        Me.Controls.Add(Me.plProdA)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.plStopFrontDownA)
        Me.Controls.Add(Me.plStopFrontUpA)
        Me.Controls.Add(Me.plGrdFiRearCloseA)
        Me.Controls.Add(Me.plGrdFiFrontCloseA)
        Me.Controls.Add(Me.plHomeA)
        Me.Controls.Add(Me.plLimitDownA)
        Me.Controls.Add(Me.plLimitUpA)
        Me.Controls.Add(Me.plLimit180)
        Me.Controls.Add(Me.plLimit0)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Name = "IO_Stacker"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "542"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents plLimit0 As KremerControlsWin32.KremerLight
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents plLimit180 As KremerControlsWin32.KremerLight
    Friend WithEvents plLimitUpA As KremerControlsWin32.KremerLight
    Friend WithEvents plLimitDownA As KremerControlsWin32.KremerLight
    Friend WithEvents plHomeA As KremerControlsWin32.KremerLight
    Friend WithEvents plGrdFiFrontCloseA As KremerControlsWin32.KremerLight
    Friend WithEvents plGrdFiRearCloseA As KremerControlsWin32.KremerLight
    Friend WithEvents plStopFrontUpA As KremerControlsWin32.KremerLight
    Friend WithEvents plStopFrontDownA As KremerControlsWin32.KremerLight
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents plProdA As KremerControlsWin32.KremerLight
    Friend WithEvents plProdB As KremerControlsWin32.KremerLight
    Friend WithEvents plStopFrontDownB As KremerControlsWin32.KremerLight
    Friend WithEvents plStopFrontUpB As KremerControlsWin32.KremerLight
    Friend WithEvents plGrdFiRearCloseB As KremerControlsWin32.KremerLight
    Friend WithEvents plGrdFiFrontCloseB As KremerControlsWin32.KremerLight
    Friend WithEvents plHomeB As KremerControlsWin32.KremerLight
    Friend WithEvents plLimitDownB As KremerControlsWin32.KremerLight
    Friend WithEvents plLimitUpB As KremerControlsWin32.KremerLight
    Friend WithEvents plGridDown As KremerControlsWin32.KremerLight
    Friend WithEvents plGridUp As KremerControlsWin32.KremerLight
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents plHighProdA As KremerControlsWin32.KremerLight
    Friend WithEvents plHighProdB As KremerControlsWin32.KremerLight
    Friend WithEvents ixLimit_0 As KremerControlsWin32.KremerVariable
    Friend WithEvents ixLimit_180 As KremerControlsWin32.KremerVariable
    Friend WithEvents ixProductOnHead_A As KremerControlsWin32.KremerVariable
    Friend WithEvents ixProductOnHead_B As KremerControlsWin32.KremerVariable
    Friend WithEvents StopperFront_AUp As KremerControlsWin32.KremerVariable
    Friend WithEvents StopperFront_ADown As KremerControlsWin32.KremerVariable
    Friend WithEvents StopperFront_BUp As KremerControlsWin32.KremerVariable
    Friend WithEvents StopperFront_BDown As KremerControlsWin32.KremerVariable
    Friend WithEvents StopperRear_AUp As KremerControlsWin32.KremerVariable
    Friend WithEvents StopperRear_ADown As KremerControlsWin32.KremerVariable
    Friend WithEvents StopperRear_BUp As KremerControlsWin32.KremerVariable
    Friend WithEvents StopperRear_BDown As KremerControlsWin32.KremerVariable
    Friend WithEvents ixHighProduct_A As KremerControlsWin32.KremerVariable
    Friend WithEvents ixHighProduct_B As KremerControlsWin32.KremerVariable
    Friend WithEvents StackingGridUp As KremerControlsWin32.KremerVariable
    Friend WithEvents StackingGridDown As KremerControlsWin32.KremerVariable
    Friend WithEvents ixLimitPosA As KremerControlsWin32.KremerVariable
    Friend WithEvents ixLimitPosB As KremerControlsWin32.KremerVariable
    Friend WithEvents ixLimitNegA As KremerControlsWin32.KremerVariable
    Friend WithEvents ixLimitNegB As KremerControlsWin32.KremerVariable
    Friend WithEvents ixHomeA As KremerControlsWin32.KremerVariable
    Friend WithEvents plStopRearDownA As KremerControlsWin32.KremerLight
    Friend WithEvents plStopRearUpA As KremerControlsWin32.KremerLight
    Friend WithEvents plStopRearDownB As KremerControlsWin32.KremerLight
    Friend WithEvents plStopRearUpB As KremerControlsWin32.KremerLight
    Friend WithEvents ixHomeB As KremerControlsWin32.KremerVariable
    Friend WithEvents GridFinger_FrontCloseA As KremerControlsWin32.KremerVariable
    Friend WithEvents GridFinger_FrontCloseB As KremerControlsWin32.KremerVariable
    Friend WithEvents GridFinger_RearCloseA As KremerControlsWin32.KremerVariable
    Friend WithEvents GridFinger_RearCloseB As KremerControlsWin32.KremerVariable
    Friend WithEvents PressHighProduct As KremerControlsWin32.KremerVariable
    Friend WithEvents plPressHighProduct As KremerControlsWin32.KremerLight
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnToggleText As KremerControlsWin32.KremerButton
    Friend WithEvents PressHighProd As KremerControlsWin32.KremerStatusBox
    Friend WithEvents PickUp_LimitSwitch0 As KremerControlsWin32.KremerStatusBox
    Friend WithEvents PickUp_LimitSwitch180 As KremerControlsWin32.KremerStatusBox
    Friend WithEvents PickUp_ProdHeadA As KremerControlsWin32.KremerStatusBox
    Friend WithEvents PickUp_ProdHeadB As KremerControlsWin32.KremerStatusBox
    Friend WithEvents StackGrid_HighProdA As KremerControlsWin32.KremerStatusBox
    Friend WithEvents StackGrid_HighProdB As KremerControlsWin32.KremerStatusBox
    Friend WithEvents StackGrid_Up As KremerControlsWin32.KremerStatusBox
    Friend WithEvents StackGrid_Down As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Stop_FrontAUp As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Stop_FrontADown As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Stop_RearAUp As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Stop_RearADown As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Stop_FrontBUp As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Stop_RearBUp As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Stop_FrontBDown As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Stop_RearBDown As KremerControlsWin32.KremerStatusBox
    Friend WithEvents LiftA_SwitchUp As KremerControlsWin32.KremerStatusBox
    Friend WithEvents LiftA_SwitchDown As KremerControlsWin32.KremerStatusBox
    Friend WithEvents LiftA_HomSensor As KremerControlsWin32.KremerStatusBox
    Friend WithEvents LiftA_GridFrontClose As KremerControlsWin32.KremerStatusBox
    Friend WithEvents LiftA_GridRearClose As KremerControlsWin32.KremerStatusBox
    Friend WithEvents LiftB_SwitchUp As KremerControlsWin32.KremerStatusBox
    Friend WithEvents LiftB_SwitchDown As KremerControlsWin32.KremerStatusBox
    Friend WithEvents LiftB_HomSensor As KremerControlsWin32.KremerStatusBox
    Friend WithEvents LiftB_GridFrontClose As KremerControlsWin32.KremerStatusBox
    Friend WithEvents LiftB_GridRearClose As KremerControlsWin32.KremerStatusBox

End Class
