<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IO_BBT
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
        Me.PusherAixHome = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plPushA_Home = New KremerControlsWin32.KremerLight
        Me.PusherBixHome = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plPushB_Home = New KremerControlsWin32.KremerLight
        Me.PusherAixLimit = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plPushA_Limit = New KremerControlsWin32.KremerLight
        Me.PusherBixLimit = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plPushB_Limit = New KremerControlsWin32.KremerLight
        Me.PusherAixPillarSensor = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plPushA_Pillar = New KremerControlsWin32.KremerLight
        Me.PusherBixPillarSensor = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plPushB_Pillar = New KremerControlsWin32.KremerLight
        Me.PusherAUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plPushA_Up = New KremerControlsWin32.KremerLight
        Me.PusherBUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plPushB_Up = New KremerControlsWin32.KremerLight
        Me.PusherADown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plPushA_Down = New KremerControlsWin32.KremerLight
        Me.PusherBDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plPushB_Down = New KremerControlsWin32.KremerLight
        Me.BundleAtChangeover = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plBundleAtChangeover = New KremerControlsWin32.KremerLight
        Me.Btn_Overview = New KremerControlsWin32.KremerButton
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.BBT_A_HomSensor = New KremerControlsWin32.KremerStatusBox
        Me.btnToggleText = New KremerControlsWin32.KremerButton
        Me.BBT_A_LimitSwitch = New KremerControlsWin32.KremerStatusBox
        Me.BBT_A_PillarSens = New KremerControlsWin32.KremerStatusBox
        Me.BBT_A_Up = New KremerControlsWin32.KremerStatusBox
        Me.BBT_A_Down = New KremerControlsWin32.KremerStatusBox
        Me.BBT_B_HomSensor = New KremerControlsWin32.KremerStatusBox
        Me.BBT_B_LimitSwitch = New KremerControlsWin32.KremerStatusBox
        Me.BBT_B_PillarSens = New KremerControlsWin32.KremerStatusBox
        Me.BBT_B_Up = New KremerControlsWin32.KremerStatusBox
        Me.BBT_B_Down = New KremerControlsWin32.KremerStatusBox
        Me.Bundle_BBT_Lift = New KremerControlsWin32.KremerStatusBox
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.PusherAixHome)
        Me.VarCollector.Variables.Add(Me.PusherBixHome)
        Me.VarCollector.Variables.Add(Me.PusherAixLimit)
        Me.VarCollector.Variables.Add(Me.PusherBixLimit)
        Me.VarCollector.Variables.Add(Me.PusherAixPillarSensor)
        Me.VarCollector.Variables.Add(Me.PusherBixPillarSensor)
        Me.VarCollector.Variables.Add(Me.PusherAUp)
        Me.VarCollector.Variables.Add(Me.PusherBUp)
        Me.VarCollector.Variables.Add(Me.PusherADown)
        Me.VarCollector.Variables.Add(Me.PusherBDown)
        Me.VarCollector.Variables.Add(Me.BundleAtChangeover)
        '
        'PusherAixHome
        '
        Me.PusherAixHome.BindControl = Me.plPushA_Home
        Me.PusherAixHome.BindProperty = "Data"
        Me.PusherAixHome.Data = Nothing
        Me.PusherAixHome.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PusherAixHome.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PusherAixHome.VariableName = "InlineAutomation.Stacking.BundleBufferTrack.PusherA.ixHome"
        '
        'plPushA_Home
        '
        Me.plPushA_Home.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plPushA_Home.ColorOn = System.Drawing.Color.Lime
        Me.plPushA_Home.Data = False
        Me.plPushA_Home.Line = True
        Me.plPushA_Home.LineSize = 1
        Me.plPushA_Home.Location = New System.Drawing.Point(15, 38)
        Me.plPushA_Home.Name = "plPushA_Home"
        Me.plPushA_Home.Size = New System.Drawing.Size(24, 24)
        Me.plPushA_Home.TabIndex = 37
        Me.plPushA_Home.Text = "KremerLight1"
        Me.plPushA_Home.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'PusherBixHome
        '
        Me.PusherBixHome.BindControl = Me.plPushB_Home
        Me.PusherBixHome.BindProperty = "Data"
        Me.PusherBixHome.Data = Nothing
        Me.PusherBixHome.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PusherBixHome.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PusherBixHome.VariableName = "InlineAutomation.Stacking.BundleBufferTrack.PusherB.ixHome"
        '
        'plPushB_Home
        '
        Me.plPushB_Home.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plPushB_Home.ColorOn = System.Drawing.Color.Lime
        Me.plPushB_Home.Data = False
        Me.plPushB_Home.Line = True
        Me.plPushB_Home.LineSize = 1
        Me.plPushB_Home.Location = New System.Drawing.Point(287, 38)
        Me.plPushB_Home.Name = "plPushB_Home"
        Me.plPushB_Home.Size = New System.Drawing.Size(24, 24)
        Me.plPushB_Home.TabIndex = 346
        Me.plPushB_Home.Text = "KremerLight1"
        Me.plPushB_Home.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'PusherAixLimit
        '
        Me.PusherAixLimit.BindControl = Me.plPushA_Limit
        Me.PusherAixLimit.BindProperty = "Data"
        Me.PusherAixLimit.Data = Nothing
        Me.PusherAixLimit.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PusherAixLimit.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PusherAixLimit.VariableName = "InlineAutomation.Stacking.BundleBufferTrack.PusherA.ixLimit"
        '
        'plPushA_Limit
        '
        Me.plPushA_Limit.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plPushA_Limit.ColorOn = System.Drawing.Color.Lime
        Me.plPushA_Limit.Data = False
        Me.plPushA_Limit.Line = True
        Me.plPushA_Limit.LineSize = 1
        Me.plPushA_Limit.Location = New System.Drawing.Point(15, 63)
        Me.plPushA_Limit.Name = "plPushA_Limit"
        Me.plPushA_Limit.Size = New System.Drawing.Size(24, 24)
        Me.plPushA_Limit.TabIndex = 287
        Me.plPushA_Limit.Text = "KremerLight1"
        Me.plPushA_Limit.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'PusherBixLimit
        '
        Me.PusherBixLimit.BindControl = Me.plPushB_Limit
        Me.PusherBixLimit.BindProperty = "Data"
        Me.PusherBixLimit.Data = Nothing
        Me.PusherBixLimit.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PusherBixLimit.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PusherBixLimit.VariableName = "InlineAutomation.Stacking.BundleBufferTrack.PusherB.ixLimit"
        '
        'plPushB_Limit
        '
        Me.plPushB_Limit.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plPushB_Limit.ColorOn = System.Drawing.Color.Lime
        Me.plPushB_Limit.Data = False
        Me.plPushB_Limit.Line = True
        Me.plPushB_Limit.LineSize = 1
        Me.plPushB_Limit.Location = New System.Drawing.Point(287, 63)
        Me.plPushB_Limit.Name = "plPushB_Limit"
        Me.plPushB_Limit.Size = New System.Drawing.Size(24, 24)
        Me.plPushB_Limit.TabIndex = 348
        Me.plPushB_Limit.Text = "KremerLight1"
        Me.plPushB_Limit.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'PusherAixPillarSensor
        '
        Me.PusherAixPillarSensor.BindControl = Me.plPushA_Pillar
        Me.PusherAixPillarSensor.BindProperty = "Data"
        Me.PusherAixPillarSensor.Data = Nothing
        Me.PusherAixPillarSensor.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PusherAixPillarSensor.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PusherAixPillarSensor.VariableName = "InlineAutomation.Stacking.BundleBufferTrack.PusherA.ixPillarSensor"
        '
        'plPushA_Pillar
        '
        Me.plPushA_Pillar.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plPushA_Pillar.ColorOn = System.Drawing.Color.Lime
        Me.plPushA_Pillar.Data = False
        Me.plPushA_Pillar.Line = True
        Me.plPushA_Pillar.LineSize = 1
        Me.plPushA_Pillar.Location = New System.Drawing.Point(15, 87)
        Me.plPushA_Pillar.Name = "plPushA_Pillar"
        Me.plPushA_Pillar.Size = New System.Drawing.Size(24, 24)
        Me.plPushA_Pillar.TabIndex = 340
        Me.plPushA_Pillar.Text = "KremerLight1"
        Me.plPushA_Pillar.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'PusherBixPillarSensor
        '
        Me.PusherBixPillarSensor.BindControl = Me.plPushB_Pillar
        Me.PusherBixPillarSensor.BindProperty = "Data"
        Me.PusherBixPillarSensor.Data = Nothing
        Me.PusherBixPillarSensor.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PusherBixPillarSensor.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PusherBixPillarSensor.VariableName = "InlineAutomation.Stacking.BundleBufferTrack.PusherB.ixPillarSensor"
        '
        'plPushB_Pillar
        '
        Me.plPushB_Pillar.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plPushB_Pillar.ColorOn = System.Drawing.Color.Lime
        Me.plPushB_Pillar.Data = False
        Me.plPushB_Pillar.Line = True
        Me.plPushB_Pillar.LineSize = 1
        Me.plPushB_Pillar.Location = New System.Drawing.Point(287, 87)
        Me.plPushB_Pillar.Name = "plPushB_Pillar"
        Me.plPushB_Pillar.Size = New System.Drawing.Size(24, 24)
        Me.plPushB_Pillar.TabIndex = 351
        Me.plPushB_Pillar.Text = "KremerLight1"
        Me.plPushB_Pillar.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'PusherAUp
        '
        Me.PusherAUp.BindControl = Me.plPushA_Up
        Me.PusherAUp.BindProperty = "Data"
        Me.PusherAUp.Data = Nothing
        Me.PusherAUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PusherAUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PusherAUp.VariableName = "InlineAutomation.Stacking.BundleBufferTrack.PusherA.Cilinder.ixOut"
        '
        'plPushA_Up
        '
        Me.plPushA_Up.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plPushA_Up.ColorOn = System.Drawing.Color.Lime
        Me.plPushA_Up.Data = False
        Me.plPushA_Up.Line = True
        Me.plPushA_Up.LineSize = 1
        Me.plPushA_Up.Location = New System.Drawing.Point(15, 112)
        Me.plPushA_Up.Name = "plPushA_Up"
        Me.plPushA_Up.Size = New System.Drawing.Size(24, 24)
        Me.plPushA_Up.TabIndex = 342
        Me.plPushA_Up.Text = "KremerLight1"
        Me.plPushA_Up.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'PusherBUp
        '
        Me.PusherBUp.BindControl = Me.plPushB_Up
        Me.PusherBUp.BindProperty = "Data"
        Me.PusherBUp.Data = Nothing
        Me.PusherBUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PusherBUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PusherBUp.VariableName = "InlineAutomation.Stacking.BundleBufferTrack.PusherB.Cilinder.ixOut"
        '
        'plPushB_Up
        '
        Me.plPushB_Up.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plPushB_Up.ColorOn = System.Drawing.Color.Lime
        Me.plPushB_Up.Data = False
        Me.plPushB_Up.Line = True
        Me.plPushB_Up.LineSize = 1
        Me.plPushB_Up.Location = New System.Drawing.Point(287, 112)
        Me.plPushB_Up.Name = "plPushB_Up"
        Me.plPushB_Up.Size = New System.Drawing.Size(24, 24)
        Me.plPushB_Up.TabIndex = 353
        Me.plPushB_Up.Text = "KremerLight1"
        Me.plPushB_Up.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'PusherADown
        '
        Me.PusherADown.BindControl = Me.plPushA_Down
        Me.PusherADown.BindProperty = "Data"
        Me.PusherADown.Data = Nothing
        Me.PusherADown.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PusherADown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PusherADown.VariableName = "InlineAutomation.Stacking.BundleBufferTrack.PusherA.Cilinder.ixIn"
        '
        'plPushA_Down
        '
        Me.plPushA_Down.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plPushA_Down.ColorOn = System.Drawing.Color.Lime
        Me.plPushA_Down.Data = False
        Me.plPushA_Down.Line = True
        Me.plPushA_Down.LineSize = 1
        Me.plPushA_Down.Location = New System.Drawing.Point(15, 137)
        Me.plPushA_Down.Name = "plPushA_Down"
        Me.plPushA_Down.Size = New System.Drawing.Size(24, 24)
        Me.plPushA_Down.TabIndex = 344
        Me.plPushA_Down.Text = "KremerLight3"
        Me.plPushA_Down.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'PusherBDown
        '
        Me.PusherBDown.BindControl = Me.plPushB_Down
        Me.PusherBDown.BindProperty = "Data"
        Me.PusherBDown.Data = Nothing
        Me.PusherBDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PusherBDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PusherBDown.VariableName = "InlineAutomation.Stacking.BundleBufferTrack.PusherB.Cilinder.ixIn"
        '
        'plPushB_Down
        '
        Me.plPushB_Down.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plPushB_Down.ColorOn = System.Drawing.Color.Lime
        Me.plPushB_Down.Data = False
        Me.plPushB_Down.Line = True
        Me.plPushB_Down.LineSize = 1
        Me.plPushB_Down.Location = New System.Drawing.Point(287, 137)
        Me.plPushB_Down.Name = "plPushB_Down"
        Me.plPushB_Down.Size = New System.Drawing.Size(24, 24)
        Me.plPushB_Down.TabIndex = 355
        Me.plPushB_Down.Text = "KremerLight3"
        Me.plPushB_Down.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BundleAtChangeover
        '
        Me.BundleAtChangeover.BindControl = Me.plBundleAtChangeover
        Me.BundleAtChangeover.BindProperty = "Data"
        Me.BundleAtChangeover.Data = Nothing
        Me.BundleAtChangeover.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BundleAtChangeover.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BundleAtChangeover.VariableName = "InlineAutomation.Stacking.BundleBufferTrack.ixOutfeedSensor"
        '
        'plBundleAtChangeover
        '
        Me.plBundleAtChangeover.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plBundleAtChangeover.ColorOn = System.Drawing.Color.Lime
        Me.plBundleAtChangeover.Data = False
        Me.plBundleAtChangeover.Line = True
        Me.plBundleAtChangeover.LineSize = 1
        Me.plBundleAtChangeover.Location = New System.Drawing.Point(15, 208)
        Me.plBundleAtChangeover.Name = "plBundleAtChangeover"
        Me.plBundleAtChangeover.Size = New System.Drawing.Size(24, 24)
        Me.plBundleAtChangeover.TabIndex = 364
        Me.plBundleAtChangeover.Text = "KremerLight1"
        Me.plBundleAtChangeover.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
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
        Me.Label29.Text = "BBT Pusher A"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(283, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(231, 25)
        Me.Label6.TabIndex = 350
        Me.Label6.Tag = ""
        Me.Label6.Text = "BBT Pusher B"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BBT_A_HomSensor
        '
        Me.BBT_A_HomSensor.BackColor = System.Drawing.SystemColors.Control
        Me.BBT_A_HomSensor.BackColorOn = System.Drawing.Color.Lime
        Me.BBT_A_HomSensor.Data = 0
        Me.BBT_A_HomSensor.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BBT_A_HomSensor.ForeColor = System.Drawing.Color.Black
        Me.BBT_A_HomSensor.ForeColorOn = System.Drawing.Color.Black
        Me.BBT_A_HomSensor.Location = New System.Drawing.Point(46, 38)
        Me.BBT_A_HomSensor.Name = "BBT_A_HomSensor"
        Me.BBT_A_HomSensor.Size = New System.Drawing.Size(223, 25)
        Me.BBT_A_HomSensor.State = False
        Me.BBT_A_HomSensor.StatusText = Nothing
        Me.BBT_A_HomSensor.TabIndex = 387
        Me.BBT_A_HomSensor.Text = "Pusher A Homing Sensor"
        Me.BBT_A_HomSensor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnToggleText.TabIndex = 388
        Me.btnToggleText.Tag = "547"
        Me.btnToggleText.Text = "Toggle Text"
        Me.btnToggleText.UserInfo = Nothing
        Me.btnToggleText.UserLevel = 0
        Me.btnToggleText.UseStateText = False
        Me.btnToggleText.UseVisualStyleBackColor = True
        '
        'BBT_A_LimitSwitch
        '
        Me.BBT_A_LimitSwitch.BackColor = System.Drawing.SystemColors.Control
        Me.BBT_A_LimitSwitch.BackColorOn = System.Drawing.Color.Lime
        Me.BBT_A_LimitSwitch.Data = 0
        Me.BBT_A_LimitSwitch.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BBT_A_LimitSwitch.ForeColor = System.Drawing.Color.Black
        Me.BBT_A_LimitSwitch.ForeColorOn = System.Drawing.Color.Black
        Me.BBT_A_LimitSwitch.Location = New System.Drawing.Point(46, 63)
        Me.BBT_A_LimitSwitch.Name = "BBT_A_LimitSwitch"
        Me.BBT_A_LimitSwitch.Size = New System.Drawing.Size(223, 25)
        Me.BBT_A_LimitSwitch.State = False
        Me.BBT_A_LimitSwitch.StatusText = Nothing
        Me.BBT_A_LimitSwitch.TabIndex = 387
        Me.BBT_A_LimitSwitch.Text = "Pusher A Limit Switch"
        Me.BBT_A_LimitSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BBT_A_PillarSens
        '
        Me.BBT_A_PillarSens.BackColor = System.Drawing.SystemColors.Control
        Me.BBT_A_PillarSens.BackColorOn = System.Drawing.Color.Lime
        Me.BBT_A_PillarSens.Data = 0
        Me.BBT_A_PillarSens.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BBT_A_PillarSens.ForeColor = System.Drawing.Color.Black
        Me.BBT_A_PillarSens.ForeColorOn = System.Drawing.Color.Black
        Me.BBT_A_PillarSens.Location = New System.Drawing.Point(46, 87)
        Me.BBT_A_PillarSens.Name = "BBT_A_PillarSens"
        Me.BBT_A_PillarSens.Size = New System.Drawing.Size(223, 25)
        Me.BBT_A_PillarSens.State = False
        Me.BBT_A_PillarSens.StatusText = Nothing
        Me.BBT_A_PillarSens.TabIndex = 387
        Me.BBT_A_PillarSens.Text = "Pusher A Pillar Sensor"
        Me.BBT_A_PillarSens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BBT_A_Up
        '
        Me.BBT_A_Up.BackColor = System.Drawing.SystemColors.Control
        Me.BBT_A_Up.BackColorOn = System.Drawing.Color.Lime
        Me.BBT_A_Up.Data = 0
        Me.BBT_A_Up.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BBT_A_Up.ForeColor = System.Drawing.Color.Black
        Me.BBT_A_Up.ForeColorOn = System.Drawing.Color.Black
        Me.BBT_A_Up.Location = New System.Drawing.Point(46, 112)
        Me.BBT_A_Up.Name = "BBT_A_Up"
        Me.BBT_A_Up.Size = New System.Drawing.Size(223, 25)
        Me.BBT_A_Up.State = False
        Me.BBT_A_Up.StatusText = Nothing
        Me.BBT_A_Up.TabIndex = 387
        Me.BBT_A_Up.Text = "Pusher A Up"
        Me.BBT_A_Up.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BBT_A_Down
        '
        Me.BBT_A_Down.BackColor = System.Drawing.SystemColors.Control
        Me.BBT_A_Down.BackColorOn = System.Drawing.Color.Lime
        Me.BBT_A_Down.Data = 0
        Me.BBT_A_Down.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BBT_A_Down.ForeColor = System.Drawing.Color.Black
        Me.BBT_A_Down.ForeColorOn = System.Drawing.Color.Black
        Me.BBT_A_Down.Location = New System.Drawing.Point(46, 137)
        Me.BBT_A_Down.Name = "BBT_A_Down"
        Me.BBT_A_Down.Size = New System.Drawing.Size(223, 25)
        Me.BBT_A_Down.State = False
        Me.BBT_A_Down.StatusText = Nothing
        Me.BBT_A_Down.TabIndex = 387
        Me.BBT_A_Down.Text = "Pusher A Down"
        Me.BBT_A_Down.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BBT_B_HomSensor
        '
        Me.BBT_B_HomSensor.BackColor = System.Drawing.SystemColors.Control
        Me.BBT_B_HomSensor.BackColorOn = System.Drawing.Color.Lime
        Me.BBT_B_HomSensor.Data = 0
        Me.BBT_B_HomSensor.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BBT_B_HomSensor.ForeColor = System.Drawing.Color.Black
        Me.BBT_B_HomSensor.ForeColorOn = System.Drawing.Color.Black
        Me.BBT_B_HomSensor.Location = New System.Drawing.Point(317, 38)
        Me.BBT_B_HomSensor.Name = "BBT_B_HomSensor"
        Me.BBT_B_HomSensor.Size = New System.Drawing.Size(223, 25)
        Me.BBT_B_HomSensor.State = False
        Me.BBT_B_HomSensor.StatusText = Nothing
        Me.BBT_B_HomSensor.TabIndex = 387
        Me.BBT_B_HomSensor.Text = "Pusher B Homing Sensor"
        Me.BBT_B_HomSensor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BBT_B_LimitSwitch
        '
        Me.BBT_B_LimitSwitch.BackColor = System.Drawing.SystemColors.Control
        Me.BBT_B_LimitSwitch.BackColorOn = System.Drawing.Color.Lime
        Me.BBT_B_LimitSwitch.Data = 0
        Me.BBT_B_LimitSwitch.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BBT_B_LimitSwitch.ForeColor = System.Drawing.Color.Black
        Me.BBT_B_LimitSwitch.ForeColorOn = System.Drawing.Color.Black
        Me.BBT_B_LimitSwitch.Location = New System.Drawing.Point(317, 63)
        Me.BBT_B_LimitSwitch.Name = "BBT_B_LimitSwitch"
        Me.BBT_B_LimitSwitch.Size = New System.Drawing.Size(223, 25)
        Me.BBT_B_LimitSwitch.State = False
        Me.BBT_B_LimitSwitch.StatusText = Nothing
        Me.BBT_B_LimitSwitch.TabIndex = 387
        Me.BBT_B_LimitSwitch.Text = "Pusher B Limit Switch"
        Me.BBT_B_LimitSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BBT_B_PillarSens
        '
        Me.BBT_B_PillarSens.BackColor = System.Drawing.SystemColors.Control
        Me.BBT_B_PillarSens.BackColorOn = System.Drawing.Color.Lime
        Me.BBT_B_PillarSens.Data = 0
        Me.BBT_B_PillarSens.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BBT_B_PillarSens.ForeColor = System.Drawing.Color.Black
        Me.BBT_B_PillarSens.ForeColorOn = System.Drawing.Color.Black
        Me.BBT_B_PillarSens.Location = New System.Drawing.Point(317, 87)
        Me.BBT_B_PillarSens.Name = "BBT_B_PillarSens"
        Me.BBT_B_PillarSens.Size = New System.Drawing.Size(223, 25)
        Me.BBT_B_PillarSens.State = False
        Me.BBT_B_PillarSens.StatusText = Nothing
        Me.BBT_B_PillarSens.TabIndex = 387
        Me.BBT_B_PillarSens.Text = "Pusher B Pillar Sensor"
        Me.BBT_B_PillarSens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BBT_B_Up
        '
        Me.BBT_B_Up.BackColor = System.Drawing.SystemColors.Control
        Me.BBT_B_Up.BackColorOn = System.Drawing.Color.Lime
        Me.BBT_B_Up.Data = 0
        Me.BBT_B_Up.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BBT_B_Up.ForeColor = System.Drawing.Color.Black
        Me.BBT_B_Up.ForeColorOn = System.Drawing.Color.Black
        Me.BBT_B_Up.Location = New System.Drawing.Point(317, 112)
        Me.BBT_B_Up.Name = "BBT_B_Up"
        Me.BBT_B_Up.Size = New System.Drawing.Size(223, 25)
        Me.BBT_B_Up.State = False
        Me.BBT_B_Up.StatusText = Nothing
        Me.BBT_B_Up.TabIndex = 387
        Me.BBT_B_Up.Text = "Pusher B Up"
        Me.BBT_B_Up.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BBT_B_Down
        '
        Me.BBT_B_Down.BackColor = System.Drawing.SystemColors.Control
        Me.BBT_B_Down.BackColorOn = System.Drawing.Color.Lime
        Me.BBT_B_Down.Data = 0
        Me.BBT_B_Down.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BBT_B_Down.ForeColor = System.Drawing.Color.Black
        Me.BBT_B_Down.ForeColorOn = System.Drawing.Color.Black
        Me.BBT_B_Down.Location = New System.Drawing.Point(317, 137)
        Me.BBT_B_Down.Name = "BBT_B_Down"
        Me.BBT_B_Down.Size = New System.Drawing.Size(223, 25)
        Me.BBT_B_Down.State = False
        Me.BBT_B_Down.StatusText = Nothing
        Me.BBT_B_Down.TabIndex = 387
        Me.BBT_B_Down.Text = "Pusher B Down"
        Me.BBT_B_Down.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Bundle_BBT_Lift
        '
        Me.Bundle_BBT_Lift.BackColor = System.Drawing.SystemColors.Control
        Me.Bundle_BBT_Lift.BackColorOn = System.Drawing.Color.Lime
        Me.Bundle_BBT_Lift.Data = 0
        Me.Bundle_BBT_Lift.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Bundle_BBT_Lift.ForeColor = System.Drawing.Color.Black
        Me.Bundle_BBT_Lift.ForeColorOn = System.Drawing.Color.Black
        Me.Bundle_BBT_Lift.Location = New System.Drawing.Point(46, 207)
        Me.Bundle_BBT_Lift.Name = "Bundle_BBT_Lift"
        Me.Bundle_BBT_Lift.Size = New System.Drawing.Size(312, 25)
        Me.Bundle_BBT_Lift.State = False
        Me.Bundle_BBT_Lift.StatusText = Nothing
        Me.Bundle_BBT_Lift.TabIndex = 387
        Me.Bundle_BBT_Lift.Text = "Bundle At Changeover BBT/Lift"
        Me.Bundle_BBT_Lift.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IO_BBT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnToggleText)
        Me.Controls.Add(Me.BBT_B_Down)
        Me.Controls.Add(Me.Bundle_BBT_Lift)
        Me.Controls.Add(Me.BBT_A_Down)
        Me.Controls.Add(Me.BBT_B_Up)
        Me.Controls.Add(Me.BBT_B_PillarSens)
        Me.Controls.Add(Me.BBT_A_Up)
        Me.Controls.Add(Me.BBT_B_LimitSwitch)
        Me.Controls.Add(Me.BBT_A_PillarSens)
        Me.Controls.Add(Me.BBT_B_HomSensor)
        Me.Controls.Add(Me.BBT_A_LimitSwitch)
        Me.Controls.Add(Me.BBT_A_HomSensor)
        Me.Controls.Add(Me.plBundleAtChangeover)
        Me.Controls.Add(Me.plPushB_Down)
        Me.Controls.Add(Me.plPushB_Up)
        Me.Controls.Add(Me.plPushB_Pillar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.plPushB_Limit)
        Me.Controls.Add(Me.plPushB_Home)
        Me.Controls.Add(Me.plPushA_Down)
        Me.Controls.Add(Me.plPushA_Up)
        Me.Controls.Add(Me.plPushA_Pillar)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.plPushA_Limit)
        Me.Controls.Add(Me.plPushA_Home)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Name = "IO_BBT"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "543"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents plPushA_Home As KremerControlsWin32.KremerLight
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents plPushA_Limit As KremerControlsWin32.KremerLight
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents plPushA_Up As KremerControlsWin32.KremerLight
    Friend WithEvents plPushA_Pillar As KremerControlsWin32.KremerLight
    Friend WithEvents plPushA_Down As KremerControlsWin32.KremerLight
    Friend WithEvents plPushB_Down As KremerControlsWin32.KremerLight
    Friend WithEvents plPushB_Up As KremerControlsWin32.KremerLight
    Friend WithEvents plPushB_Pillar As KremerControlsWin32.KremerLight
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents plPushB_Limit As KremerControlsWin32.KremerLight
    Friend WithEvents plPushB_Home As KremerControlsWin32.KremerLight
    Friend WithEvents PusherAixHome As KremerControlsWin32.KremerVariable
    Friend WithEvents PusherBixHome As KremerControlsWin32.KremerVariable
    Friend WithEvents PusherAixLimit As KremerControlsWin32.KremerVariable
    Friend WithEvents PusherBixLimit As KremerControlsWin32.KremerVariable
    Friend WithEvents PusherAixPillarSensor As KremerControlsWin32.KremerVariable
    Friend WithEvents PusherBixPillarSensor As KremerControlsWin32.KremerVariable
    Friend WithEvents PusherAUp As KremerControlsWin32.KremerVariable
    Friend WithEvents PusherBUp As KremerControlsWin32.KremerVariable
    Friend WithEvents PusherADown As KremerControlsWin32.KremerVariable
    Friend WithEvents PusherBDown As KremerControlsWin32.KremerVariable
    Friend WithEvents BundleAtChangeover As KremerControlsWin32.KremerVariable
    Friend WithEvents plBundleAtChangeover As KremerControlsWin32.KremerLight
    Friend WithEvents BBT_A_HomSensor As KremerControlsWin32.KremerStatusBox
    Friend WithEvents btnToggleText As KremerControlsWin32.KremerButton
    Friend WithEvents BBT_A_LimitSwitch As KremerControlsWin32.KremerStatusBox
    Friend WithEvents BBT_A_PillarSens As KremerControlsWin32.KremerStatusBox
    Friend WithEvents BBT_A_Up As KremerControlsWin32.KremerStatusBox
    Friend WithEvents BBT_A_Down As KremerControlsWin32.KremerStatusBox
    Friend WithEvents BBT_B_HomSensor As KremerControlsWin32.KremerStatusBox
    Friend WithEvents BBT_B_LimitSwitch As KremerControlsWin32.KremerStatusBox
    Friend WithEvents BBT_B_PillarSens As KremerControlsWin32.KremerStatusBox
    Friend WithEvents BBT_B_Up As KremerControlsWin32.KremerStatusBox
    Friend WithEvents BBT_B_Down As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Bundle_BBT_Lift As KremerControlsWin32.KremerStatusBox

End Class
