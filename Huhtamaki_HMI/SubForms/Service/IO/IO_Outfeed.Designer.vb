<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IO_Outfeed
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
        Me.ixBundleInLift = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plBndlInLift = New KremerControlsWin32.KremerLight
        Me.ixHome = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plHorHome = New KremerControlsWin32.KremerLight
        Me.ixLimit = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plHorLimit = New KremerControlsWin32.KremerLight
        Me.ixPosition = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plLiftInPos = New KremerControlsWin32.KremerLight
        Me.ixBundleInFingers = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plBndlInFingers = New KremerControlsWin32.KremerLight
        Me.LiftFingerLeftIn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plLiftFingerLeftIn = New KremerControlsWin32.KremerLight
        Me.LiftFingerLeftOut = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plLiftFingerLeftOut = New KremerControlsWin32.KremerLight
        Me.LiftFingerRightIn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plLiftFingerRightIn = New KremerControlsWin32.KremerLight
        Me.LiftFingerRightOut = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plLiftFingerRightOut = New KremerControlsWin32.KremerLight
        Me.LiftIsUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plLiftIsUp = New KremerControlsWin32.KremerLight
        Me.LiftIsDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plLiftIsDown = New KremerControlsWin32.KremerLight
        Me.Btn_Overview = New KremerControlsWin32.KremerButton
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnToggleText = New KremerControlsWin32.KremerButton
        Me.Outfeed_BundleInLift = New KremerControlsWin32.KremerStatusBox
        Me.Outfeed_LimitSwitch1 = New KremerControlsWin32.KremerStatusBox
        Me.Outfeed_LimitSwitch2 = New KremerControlsWin32.KremerStatusBox
        Me.Outfeed_LiftInPosition = New KremerControlsWin32.KremerStatusBox
        Me.Outfeed_BundleInFingers = New KremerControlsWin32.KremerStatusBox
        Me.Outfeed_FingerLeftIn = New KremerControlsWin32.KremerStatusBox
        Me.Outfeed_FingerLeftOut = New KremerControlsWin32.KremerStatusBox
        Me.Oufteed_FingerRightIn = New KremerControlsWin32.KremerStatusBox
        Me.Oufteed_FingerRightOut = New KremerControlsWin32.KremerStatusBox
        Me.Outfeed_LiftIsUp = New KremerControlsWin32.KremerStatusBox
        Me.Outfeed_LiftIsDown = New KremerControlsWin32.KremerStatusBox
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.ixBundleInLift)
        Me.VarCollector.Variables.Add(Me.ixHome)
        Me.VarCollector.Variables.Add(Me.ixLimit)
        Me.VarCollector.Variables.Add(Me.ixPosition)
        Me.VarCollector.Variables.Add(Me.ixBundleInFingers)
        Me.VarCollector.Variables.Add(Me.LiftFingerLeftIn)
        Me.VarCollector.Variables.Add(Me.LiftFingerLeftOut)
        Me.VarCollector.Variables.Add(Me.LiftFingerRightIn)
        Me.VarCollector.Variables.Add(Me.LiftFingerRightOut)
        Me.VarCollector.Variables.Add(Me.LiftIsUp)
        Me.VarCollector.Variables.Add(Me.LiftIsDown)
        '
        'ixBundleInLift
        '
        Me.ixBundleInLift.BindControl = Me.plBndlInLift
        Me.ixBundleInLift.BindProperty = "Data"
        Me.ixBundleInLift.Data = Nothing
        Me.ixBundleInLift.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ixBundleInLift.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ixBundleInLift.VariableName = "InlineAutomation.Stacking.BundleOutfeed.ixBundleInLift"
        '
        'plBndlInLift
        '
        Me.plBndlInLift.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plBndlInLift.ColorOn = System.Drawing.Color.Lime
        Me.plBndlInLift.Data = False
        Me.plBndlInLift.Line = True
        Me.plBndlInLift.LineSize = 1
        Me.plBndlInLift.Location = New System.Drawing.Point(15, 38)
        Me.plBndlInLift.Name = "plBndlInLift"
        Me.plBndlInLift.Size = New System.Drawing.Size(24, 24)
        Me.plBndlInLift.TabIndex = 37
        Me.plBndlInLift.Text = "KremerLight1"
        Me.plBndlInLift.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'ixHome
        '
        Me.ixHome.BindControl = Me.plHorHome
        Me.ixHome.BindProperty = "Data"
        Me.ixHome.Data = Nothing
        Me.ixHome.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ixHome.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ixHome.VariableName = "InlineAutomation.Stacking.BundleOutfeed.OutfeedHorizontalTransport.ixHome"
        '
        'plHorHome
        '
        Me.plHorHome.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plHorHome.ColorOn = System.Drawing.Color.Lime
        Me.plHorHome.Data = False
        Me.plHorHome.Line = True
        Me.plHorHome.LineSize = 1
        Me.plHorHome.Location = New System.Drawing.Point(274, 38)
        Me.plHorHome.Name = "plHorHome"
        Me.plHorHome.Size = New System.Drawing.Size(24, 24)
        Me.plHorHome.TabIndex = 346
        Me.plHorHome.Text = "KremerLight1"
        Me.plHorHome.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'ixLimit
        '
        Me.ixLimit.BindControl = Me.plHorLimit
        Me.ixLimit.BindProperty = "Data"
        Me.ixLimit.Data = Nothing
        Me.ixLimit.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ixLimit.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ixLimit.VariableName = "InlineAutomation.Stacking.BundleOutfeed.OutfeedHorizontalTransport.ixLimit"
        '
        'plHorLimit
        '
        Me.plHorLimit.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plHorLimit.ColorOn = System.Drawing.Color.Lime
        Me.plHorLimit.Data = False
        Me.plHorLimit.Line = True
        Me.plHorLimit.LineSize = 1
        Me.plHorLimit.Location = New System.Drawing.Point(274, 63)
        Me.plHorLimit.Name = "plHorLimit"
        Me.plHorLimit.Size = New System.Drawing.Size(24, 24)
        Me.plHorLimit.TabIndex = 348
        Me.plHorLimit.Text = "KremerLight1"
        Me.plHorLimit.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'ixPosition
        '
        Me.ixPosition.BindControl = Me.plLiftInPos
        Me.ixPosition.BindProperty = "Data"
        Me.ixPosition.Data = Nothing
        Me.ixPosition.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ixPosition.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ixPosition.VariableName = "InlineAutomation.Stacking.BundleOutfeed.OutfeedLift.ixPosition"
        '
        'plLiftInPos
        '
        Me.plLiftInPos.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plLiftInPos.ColorOn = System.Drawing.Color.Lime
        Me.plLiftInPos.Data = False
        Me.plLiftInPos.Line = True
        Me.plLiftInPos.LineSize = 1
        Me.plLiftInPos.Location = New System.Drawing.Point(535, 38)
        Me.plLiftInPos.Name = "plLiftInPos"
        Me.plLiftInPos.Size = New System.Drawing.Size(24, 24)
        Me.plLiftInPos.TabIndex = 357
        Me.plLiftInPos.Text = "KremerLight1"
        Me.plLiftInPos.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'ixBundleInFingers
        '
        Me.ixBundleInFingers.BindControl = Me.plBndlInFingers
        Me.ixBundleInFingers.BindProperty = "Data"
        Me.ixBundleInFingers.Data = Nothing
        Me.ixBundleInFingers.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ixBundleInFingers.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ixBundleInFingers.VariableName = "InlineAutomation.Stacking.BundleOutfeed.OutfeedLift.ixBundlePresent"
        '
        'plBndlInFingers
        '
        Me.plBndlInFingers.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plBndlInFingers.ColorOn = System.Drawing.Color.Lime
        Me.plBndlInFingers.Data = False
        Me.plBndlInFingers.Line = True
        Me.plBndlInFingers.LineSize = 1
        Me.plBndlInFingers.Location = New System.Drawing.Point(535, 63)
        Me.plBndlInFingers.Name = "plBndlInFingers"
        Me.plBndlInFingers.Size = New System.Drawing.Size(24, 24)
        Me.plBndlInFingers.TabIndex = 359
        Me.plBndlInFingers.Text = "KremerLight1"
        Me.plBndlInFingers.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'LiftFingerLeftIn
        '
        Me.LiftFingerLeftIn.BindControl = Me.plLiftFingerLeftIn
        Me.LiftFingerLeftIn.BindProperty = "Data"
        Me.LiftFingerLeftIn.Data = Nothing
        Me.LiftFingerLeftIn.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.LiftFingerLeftIn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.LiftFingerLeftIn.VariableName = "InlineAutomation.Stacking.BundleOutfeed.OutfeedLift.Finger_Left.ixIn"
        '
        'plLiftFingerLeftIn
        '
        Me.plLiftFingerLeftIn.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plLiftFingerLeftIn.ColorOn = System.Drawing.Color.Lime
        Me.plLiftFingerLeftIn.Data = False
        Me.plLiftFingerLeftIn.Line = True
        Me.plLiftFingerLeftIn.LineSize = 1
        Me.plLiftFingerLeftIn.Location = New System.Drawing.Point(535, 88)
        Me.plLiftFingerLeftIn.Name = "plLiftFingerLeftIn"
        Me.plLiftFingerLeftIn.Size = New System.Drawing.Size(24, 24)
        Me.plLiftFingerLeftIn.TabIndex = 364
        Me.plLiftFingerLeftIn.Text = "KremerLight1"
        Me.plLiftFingerLeftIn.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'LiftFingerLeftOut
        '
        Me.LiftFingerLeftOut.BindControl = Me.plLiftFingerLeftOut
        Me.LiftFingerLeftOut.BindProperty = "Data"
        Me.LiftFingerLeftOut.Data = Nothing
        Me.LiftFingerLeftOut.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.LiftFingerLeftOut.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.LiftFingerLeftOut.VariableName = "InlineAutomation.Stacking.BundleOutfeed.OutfeedLift.Finger_Left.ixOut"
        '
        'plLiftFingerLeftOut
        '
        Me.plLiftFingerLeftOut.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plLiftFingerLeftOut.ColorOn = System.Drawing.Color.Lime
        Me.plLiftFingerLeftOut.Data = False
        Me.plLiftFingerLeftOut.Line = True
        Me.plLiftFingerLeftOut.LineSize = 1
        Me.plLiftFingerLeftOut.Location = New System.Drawing.Point(535, 115)
        Me.plLiftFingerLeftOut.Name = "plLiftFingerLeftOut"
        Me.plLiftFingerLeftOut.Size = New System.Drawing.Size(24, 24)
        Me.plLiftFingerLeftOut.TabIndex = 366
        Me.plLiftFingerLeftOut.Text = "KremerLight2"
        Me.plLiftFingerLeftOut.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'LiftFingerRightIn
        '
        Me.LiftFingerRightIn.BindControl = Me.plLiftFingerRightIn
        Me.LiftFingerRightIn.BindProperty = "Data"
        Me.LiftFingerRightIn.Data = Nothing
        Me.LiftFingerRightIn.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.LiftFingerRightIn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.LiftFingerRightIn.VariableName = "InlineAutomation.Stacking.BundleOutfeed.OutfeedLift.Finger_Right.ixIn"
        '
        'plLiftFingerRightIn
        '
        Me.plLiftFingerRightIn.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plLiftFingerRightIn.ColorOn = System.Drawing.Color.Lime
        Me.plLiftFingerRightIn.Data = False
        Me.plLiftFingerRightIn.Line = True
        Me.plLiftFingerRightIn.LineSize = 1
        Me.plLiftFingerRightIn.Location = New System.Drawing.Point(535, 140)
        Me.plLiftFingerRightIn.Name = "plLiftFingerRightIn"
        Me.plLiftFingerRightIn.Size = New System.Drawing.Size(24, 24)
        Me.plLiftFingerRightIn.TabIndex = 368
        Me.plLiftFingerRightIn.Text = "KremerLight3"
        Me.plLiftFingerRightIn.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'LiftFingerRightOut
        '
        Me.LiftFingerRightOut.BindControl = Me.plLiftFingerRightOut
        Me.LiftFingerRightOut.BindProperty = "Data"
        Me.LiftFingerRightOut.Data = Nothing
        Me.LiftFingerRightOut.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.LiftFingerRightOut.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.LiftFingerRightOut.VariableName = "InlineAutomation.Stacking.BundleOutfeed.OutfeedLift.Finger_Right.ixOut"
        '
        'plLiftFingerRightOut
        '
        Me.plLiftFingerRightOut.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plLiftFingerRightOut.ColorOn = System.Drawing.Color.Lime
        Me.plLiftFingerRightOut.Data = False
        Me.plLiftFingerRightOut.Line = True
        Me.plLiftFingerRightOut.LineSize = 1
        Me.plLiftFingerRightOut.Location = New System.Drawing.Point(535, 165)
        Me.plLiftFingerRightOut.Name = "plLiftFingerRightOut"
        Me.plLiftFingerRightOut.Size = New System.Drawing.Size(24, 24)
        Me.plLiftFingerRightOut.TabIndex = 370
        Me.plLiftFingerRightOut.Text = "KremerLight4"
        Me.plLiftFingerRightOut.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'LiftIsUp
        '
        Me.LiftIsUp.BindControl = Me.plLiftIsUp
        Me.LiftIsUp.BindProperty = "Data"
        Me.LiftIsUp.Data = Nothing
        Me.LiftIsUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.LiftIsUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.LiftIsUp.VariableName = "InlineAutomation.Stacking.BundleOutfeed.OutfeedLift.Cilinder.ixOut"
        '
        'plLiftIsUp
        '
        Me.plLiftIsUp.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plLiftIsUp.ColorOn = System.Drawing.Color.Lime
        Me.plLiftIsUp.Data = False
        Me.plLiftIsUp.Line = True
        Me.plLiftIsUp.LineSize = 1
        Me.plLiftIsUp.Location = New System.Drawing.Point(535, 190)
        Me.plLiftIsUp.Name = "plLiftIsUp"
        Me.plLiftIsUp.Size = New System.Drawing.Size(24, 24)
        Me.plLiftIsUp.TabIndex = 372
        Me.plLiftIsUp.Text = "KremerLight3"
        Me.plLiftIsUp.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'LiftIsDown
        '
        Me.LiftIsDown.BindControl = Me.plLiftIsDown
        Me.LiftIsDown.BindProperty = "Data"
        Me.LiftIsDown.Data = Nothing
        Me.LiftIsDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.LiftIsDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.LiftIsDown.VariableName = "InlineAutomation.Stacking.BundleOutfeed.OutfeedLift.Cilinder.ixIn"
        '
        'plLiftIsDown
        '
        Me.plLiftIsDown.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plLiftIsDown.ColorOn = System.Drawing.Color.Lime
        Me.plLiftIsDown.Data = False
        Me.plLiftIsDown.Line = True
        Me.plLiftIsDown.LineSize = 1
        Me.plLiftIsDown.Location = New System.Drawing.Point(535, 215)
        Me.plLiftIsDown.Name = "plLiftIsDown"
        Me.plLiftIsDown.Size = New System.Drawing.Size(24, 24)
        Me.plLiftIsDown.TabIndex = 374
        Me.plLiftIsDown.Text = "KremerLight4"
        Me.plLiftIsDown.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
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
        Me.Label29.Location = New System.Drawing.Point(11, 10)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(231, 25)
        Me.Label29.TabIndex = 339
        Me.Label29.Tag = ""
        Me.Label29.Text = "Outfeed"
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
        Me.Label6.Text = "Horizontal Transport"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(531, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(231, 25)
        Me.Label12.TabIndex = 361
        Me.Label12.Tag = ""
        Me.Label12.Text = "Outfeed Lift"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnToggleText.TabIndex = 386
        Me.btnToggleText.Tag = "547"
        Me.btnToggleText.Text = "Toggle Text"
        Me.btnToggleText.UserInfo = Nothing
        Me.btnToggleText.UserLevel = 0
        Me.btnToggleText.UseStateText = False
        Me.btnToggleText.UseVisualStyleBackColor = True
        '
        'Outfeed_BundleInLift
        '
        Me.Outfeed_BundleInLift.BackColor = System.Drawing.SystemColors.Control
        Me.Outfeed_BundleInLift.BackColorOn = System.Drawing.Color.Lime
        Me.Outfeed_BundleInLift.Data = 0
        Me.Outfeed_BundleInLift.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Outfeed_BundleInLift.ForeColor = System.Drawing.Color.Black
        Me.Outfeed_BundleInLift.ForeColorOn = System.Drawing.Color.Black
        Me.Outfeed_BundleInLift.Location = New System.Drawing.Point(47, 38)
        Me.Outfeed_BundleInLift.Name = "Outfeed_BundleInLift"
        Me.Outfeed_BundleInLift.Size = New System.Drawing.Size(195, 25)
        Me.Outfeed_BundleInLift.State = False
        Me.Outfeed_BundleInLift.StatusText = Nothing
        Me.Outfeed_BundleInLift.TabIndex = 395
        Me.Outfeed_BundleInLift.Text = "Bundle In Lift"
        Me.Outfeed_BundleInLift.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Outfeed_LimitSwitch1
        '
        Me.Outfeed_LimitSwitch1.BackColor = System.Drawing.SystemColors.Control
        Me.Outfeed_LimitSwitch1.BackColorOn = System.Drawing.Color.Lime
        Me.Outfeed_LimitSwitch1.Data = 0
        Me.Outfeed_LimitSwitch1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Outfeed_LimitSwitch1.ForeColor = System.Drawing.Color.Black
        Me.Outfeed_LimitSwitch1.ForeColorOn = System.Drawing.Color.Black
        Me.Outfeed_LimitSwitch1.Location = New System.Drawing.Point(306, 38)
        Me.Outfeed_LimitSwitch1.Name = "Outfeed_LimitSwitch1"
        Me.Outfeed_LimitSwitch1.Size = New System.Drawing.Size(195, 25)
        Me.Outfeed_LimitSwitch1.State = False
        Me.Outfeed_LimitSwitch1.StatusText = Nothing
        Me.Outfeed_LimitSwitch1.TabIndex = 396
        Me.Outfeed_LimitSwitch1.Text = "Limit Switch 1"
        Me.Outfeed_LimitSwitch1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Outfeed_LimitSwitch2
        '
        Me.Outfeed_LimitSwitch2.BackColor = System.Drawing.SystemColors.Control
        Me.Outfeed_LimitSwitch2.BackColorOn = System.Drawing.Color.Lime
        Me.Outfeed_LimitSwitch2.Data = 0
        Me.Outfeed_LimitSwitch2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Outfeed_LimitSwitch2.ForeColor = System.Drawing.Color.Black
        Me.Outfeed_LimitSwitch2.ForeColorOn = System.Drawing.Color.Black
        Me.Outfeed_LimitSwitch2.Location = New System.Drawing.Point(306, 63)
        Me.Outfeed_LimitSwitch2.Name = "Outfeed_LimitSwitch2"
        Me.Outfeed_LimitSwitch2.Size = New System.Drawing.Size(195, 25)
        Me.Outfeed_LimitSwitch2.State = False
        Me.Outfeed_LimitSwitch2.StatusText = Nothing
        Me.Outfeed_LimitSwitch2.TabIndex = 396
        Me.Outfeed_LimitSwitch2.Text = "Limit Switch 2"
        Me.Outfeed_LimitSwitch2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Outfeed_LiftInPosition
        '
        Me.Outfeed_LiftInPosition.BackColor = System.Drawing.SystemColors.Control
        Me.Outfeed_LiftInPosition.BackColorOn = System.Drawing.Color.Lime
        Me.Outfeed_LiftInPosition.Data = 0
        Me.Outfeed_LiftInPosition.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Outfeed_LiftInPosition.ForeColor = System.Drawing.Color.Black
        Me.Outfeed_LiftInPosition.ForeColorOn = System.Drawing.Color.Black
        Me.Outfeed_LiftInPosition.Location = New System.Drawing.Point(567, 38)
        Me.Outfeed_LiftInPosition.Name = "Outfeed_LiftInPosition"
        Me.Outfeed_LiftInPosition.Size = New System.Drawing.Size(216, 25)
        Me.Outfeed_LiftInPosition.State = False
        Me.Outfeed_LiftInPosition.StatusText = Nothing
        Me.Outfeed_LiftInPosition.TabIndex = 396
        Me.Outfeed_LiftInPosition.Text = "Lift in Position"
        Me.Outfeed_LiftInPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Outfeed_BundleInFingers
        '
        Me.Outfeed_BundleInFingers.BackColor = System.Drawing.SystemColors.Control
        Me.Outfeed_BundleInFingers.BackColorOn = System.Drawing.Color.Lime
        Me.Outfeed_BundleInFingers.Data = 0
        Me.Outfeed_BundleInFingers.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Outfeed_BundleInFingers.ForeColor = System.Drawing.Color.Black
        Me.Outfeed_BundleInFingers.ForeColorOn = System.Drawing.Color.Black
        Me.Outfeed_BundleInFingers.Location = New System.Drawing.Point(567, 63)
        Me.Outfeed_BundleInFingers.Name = "Outfeed_BundleInFingers"
        Me.Outfeed_BundleInFingers.Size = New System.Drawing.Size(216, 25)
        Me.Outfeed_BundleInFingers.State = False
        Me.Outfeed_BundleInFingers.StatusText = Nothing
        Me.Outfeed_BundleInFingers.TabIndex = 396
        Me.Outfeed_BundleInFingers.Text = "Bundle in Fingers"
        Me.Outfeed_BundleInFingers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Outfeed_FingerLeftIn
        '
        Me.Outfeed_FingerLeftIn.BackColor = System.Drawing.SystemColors.Control
        Me.Outfeed_FingerLeftIn.BackColorOn = System.Drawing.Color.Lime
        Me.Outfeed_FingerLeftIn.Data = 0
        Me.Outfeed_FingerLeftIn.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Outfeed_FingerLeftIn.ForeColor = System.Drawing.Color.Black
        Me.Outfeed_FingerLeftIn.ForeColorOn = System.Drawing.Color.Black
        Me.Outfeed_FingerLeftIn.Location = New System.Drawing.Point(567, 88)
        Me.Outfeed_FingerLeftIn.Name = "Outfeed_FingerLeftIn"
        Me.Outfeed_FingerLeftIn.Size = New System.Drawing.Size(216, 25)
        Me.Outfeed_FingerLeftIn.State = False
        Me.Outfeed_FingerLeftIn.StatusText = Nothing
        Me.Outfeed_FingerLeftIn.TabIndex = 396
        Me.Outfeed_FingerLeftIn.Text = "Finger infeed side Is In"
        Me.Outfeed_FingerLeftIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Outfeed_FingerLeftOut
        '
        Me.Outfeed_FingerLeftOut.BackColor = System.Drawing.SystemColors.Control
        Me.Outfeed_FingerLeftOut.BackColorOn = System.Drawing.Color.Lime
        Me.Outfeed_FingerLeftOut.Data = 0
        Me.Outfeed_FingerLeftOut.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Outfeed_FingerLeftOut.ForeColor = System.Drawing.Color.Black
        Me.Outfeed_FingerLeftOut.ForeColorOn = System.Drawing.Color.Black
        Me.Outfeed_FingerLeftOut.Location = New System.Drawing.Point(567, 115)
        Me.Outfeed_FingerLeftOut.Name = "Outfeed_FingerLeftOut"
        Me.Outfeed_FingerLeftOut.Size = New System.Drawing.Size(216, 25)
        Me.Outfeed_FingerLeftOut.State = False
        Me.Outfeed_FingerLeftOut.StatusText = Nothing
        Me.Outfeed_FingerLeftOut.TabIndex = 396
        Me.Outfeed_FingerLeftOut.Text = "Finger infeed side Is Out"
        Me.Outfeed_FingerLeftOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Oufteed_FingerRightIn
        '
        Me.Oufteed_FingerRightIn.BackColor = System.Drawing.SystemColors.Control
        Me.Oufteed_FingerRightIn.BackColorOn = System.Drawing.Color.Lime
        Me.Oufteed_FingerRightIn.Data = 0
        Me.Oufteed_FingerRightIn.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Oufteed_FingerRightIn.ForeColor = System.Drawing.Color.Black
        Me.Oufteed_FingerRightIn.ForeColorOn = System.Drawing.Color.Black
        Me.Oufteed_FingerRightIn.Location = New System.Drawing.Point(567, 140)
        Me.Oufteed_FingerRightIn.Name = "Oufteed_FingerRightIn"
        Me.Oufteed_FingerRightIn.Size = New System.Drawing.Size(216, 25)
        Me.Oufteed_FingerRightIn.State = False
        Me.Oufteed_FingerRightIn.StatusText = Nothing
        Me.Oufteed_FingerRightIn.TabIndex = 396
        Me.Oufteed_FingerRightIn.Text = "Finger outfeed side Is In"
        Me.Oufteed_FingerRightIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Oufteed_FingerRightOut
        '
        Me.Oufteed_FingerRightOut.BackColor = System.Drawing.SystemColors.Control
        Me.Oufteed_FingerRightOut.BackColorOn = System.Drawing.Color.Lime
        Me.Oufteed_FingerRightOut.Data = 0
        Me.Oufteed_FingerRightOut.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Oufteed_FingerRightOut.ForeColor = System.Drawing.Color.Black
        Me.Oufteed_FingerRightOut.ForeColorOn = System.Drawing.Color.Black
        Me.Oufteed_FingerRightOut.Location = New System.Drawing.Point(567, 165)
        Me.Oufteed_FingerRightOut.Name = "Oufteed_FingerRightOut"
        Me.Oufteed_FingerRightOut.Size = New System.Drawing.Size(216, 25)
        Me.Oufteed_FingerRightOut.State = False
        Me.Oufteed_FingerRightOut.StatusText = Nothing
        Me.Oufteed_FingerRightOut.TabIndex = 396
        Me.Oufteed_FingerRightOut.Text = "Finger outfeed side Is Out"
        Me.Oufteed_FingerRightOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Outfeed_LiftIsUp
        '
        Me.Outfeed_LiftIsUp.BackColor = System.Drawing.SystemColors.Control
        Me.Outfeed_LiftIsUp.BackColorOn = System.Drawing.Color.Lime
        Me.Outfeed_LiftIsUp.Data = 0
        Me.Outfeed_LiftIsUp.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Outfeed_LiftIsUp.ForeColor = System.Drawing.Color.Black
        Me.Outfeed_LiftIsUp.ForeColorOn = System.Drawing.Color.Black
        Me.Outfeed_LiftIsUp.Location = New System.Drawing.Point(567, 190)
        Me.Outfeed_LiftIsUp.Name = "Outfeed_LiftIsUp"
        Me.Outfeed_LiftIsUp.Size = New System.Drawing.Size(216, 25)
        Me.Outfeed_LiftIsUp.State = False
        Me.Outfeed_LiftIsUp.StatusText = Nothing
        Me.Outfeed_LiftIsUp.TabIndex = 396
        Me.Outfeed_LiftIsUp.Text = "Lift is Up"
        Me.Outfeed_LiftIsUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Outfeed_LiftIsDown
        '
        Me.Outfeed_LiftIsDown.BackColor = System.Drawing.SystemColors.Control
        Me.Outfeed_LiftIsDown.BackColorOn = System.Drawing.Color.Lime
        Me.Outfeed_LiftIsDown.Data = 0
        Me.Outfeed_LiftIsDown.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Outfeed_LiftIsDown.ForeColor = System.Drawing.Color.Black
        Me.Outfeed_LiftIsDown.ForeColorOn = System.Drawing.Color.Black
        Me.Outfeed_LiftIsDown.Location = New System.Drawing.Point(567, 214)
        Me.Outfeed_LiftIsDown.Name = "Outfeed_LiftIsDown"
        Me.Outfeed_LiftIsDown.Size = New System.Drawing.Size(216, 25)
        Me.Outfeed_LiftIsDown.State = False
        Me.Outfeed_LiftIsDown.StatusText = Nothing
        Me.Outfeed_LiftIsDown.TabIndex = 396
        Me.Outfeed_LiftIsDown.Text = "Lift is Down"
        Me.Outfeed_LiftIsDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IO_Outfeed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Outfeed_LimitSwitch2)
        Me.Controls.Add(Me.Outfeed_LiftIsDown)
        Me.Controls.Add(Me.Outfeed_LiftIsUp)
        Me.Controls.Add(Me.Oufteed_FingerRightOut)
        Me.Controls.Add(Me.Oufteed_FingerRightIn)
        Me.Controls.Add(Me.Outfeed_FingerLeftOut)
        Me.Controls.Add(Me.Outfeed_FingerLeftIn)
        Me.Controls.Add(Me.Outfeed_BundleInFingers)
        Me.Controls.Add(Me.Outfeed_LiftInPosition)
        Me.Controls.Add(Me.Outfeed_LimitSwitch1)
        Me.Controls.Add(Me.Outfeed_BundleInLift)
        Me.Controls.Add(Me.btnToggleText)
        Me.Controls.Add(Me.plLiftIsDown)
        Me.Controls.Add(Me.plLiftIsUp)
        Me.Controls.Add(Me.plLiftFingerRightOut)
        Me.Controls.Add(Me.plLiftFingerRightIn)
        Me.Controls.Add(Me.plLiftFingerLeftOut)
        Me.Controls.Add(Me.plLiftFingerLeftIn)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.plBndlInFingers)
        Me.Controls.Add(Me.plLiftInPos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.plHorLimit)
        Me.Controls.Add(Me.plHorHome)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.plBndlInLift)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Name = "IO_Outfeed"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "544"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents plBndlInLift As KremerControlsWin32.KremerLight
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents plHorLimit As KremerControlsWin32.KremerLight
    Friend WithEvents plHorHome As KremerControlsWin32.KremerLight
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents plBndlInFingers As KremerControlsWin32.KremerLight
    Friend WithEvents plLiftInPos As KremerControlsWin32.KremerLight
    Friend WithEvents ixBundleInLift As KremerControlsWin32.KremerVariable
    Friend WithEvents ixHome As KremerControlsWin32.KremerVariable
    Friend WithEvents ixLimit As KremerControlsWin32.KremerVariable
    Friend WithEvents ixPosition As KremerControlsWin32.KremerVariable
    Friend WithEvents ixBundleInFingers As KremerControlsWin32.KremerVariable
    Friend WithEvents plLiftFingerLeftIn As KremerControlsWin32.KremerLight
    Friend WithEvents plLiftFingerLeftOut As KremerControlsWin32.KremerLight
    Friend WithEvents plLiftFingerRightIn As KremerControlsWin32.KremerLight
    Friend WithEvents plLiftFingerRightOut As KremerControlsWin32.KremerLight
    Friend WithEvents LiftFingerLeftIn As KremerControlsWin32.KremerVariable
    Friend WithEvents LiftFingerLeftOut As KremerControlsWin32.KremerVariable
    Friend WithEvents LiftFingerRightIn As KremerControlsWin32.KremerVariable
    Friend WithEvents LiftFingerRightOut As KremerControlsWin32.KremerVariable
    Friend WithEvents plLiftIsDown As KremerControlsWin32.KremerLight
    Friend WithEvents plLiftIsUp As KremerControlsWin32.KremerLight
    Friend WithEvents LiftIsUp As KremerControlsWin32.KremerVariable
    Friend WithEvents LiftIsDown As KremerControlsWin32.KremerVariable
    Friend WithEvents btnToggleText As KremerControlsWin32.KremerButton
    Friend WithEvents Outfeed_BundleInLift As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Outfeed_LimitSwitch1 As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Outfeed_LimitSwitch2 As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Outfeed_LiftInPosition As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Outfeed_BundleInFingers As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Outfeed_FingerLeftIn As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Outfeed_FingerLeftOut As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Oufteed_FingerRightIn As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Oufteed_FingerRightOut As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Outfeed_LiftIsUp As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Outfeed_LiftIsDown As KremerControlsWin32.KremerStatusBox

End Class
