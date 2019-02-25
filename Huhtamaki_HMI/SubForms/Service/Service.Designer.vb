<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Service
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
        Me.Btn_SeqStat = New KremerControlsWin32.KremerButton()
        Me.Btn_IOStat = New KremerControlsWin32.KremerButton()
        Me.Btn_Zero = New KremerControlsWin32.KremerButton()
        Me.Btn_EtherCat_Topology = New KremerControlsWin32.KremerButton()
        Me.Btn_CilinderTimes = New KremerControlsWin32.KremerButton()
        Me.Btn_SeqInitStat = New KremerControlsWin32.KremerButton()
        Me.Btn_ServiceSettings = New KremerControlsWin32.KremerButton()
        Me.Btn_I2T = New KremerControlsWin32.KremerButton()
        Me.SuspendLayout()
        '
        'krConnector
        '
        Me.krConnector.VarCollector = Nothing
        '
        'Btn_SeqStat
        '
        Me.Btn_SeqStat.Audit = Nothing
        Me.Btn_SeqStat.AuditEnabled = False
        Me.Btn_SeqStat.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_SeqStat.AuditSource = "KremerPushButton"
        Me.Btn_SeqStat.BackColorOn = System.Drawing.Color.Empty
        Me.Btn_SeqStat.BackGroundImageOn = Nothing
        Me.Btn_SeqStat.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_SeqStat.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_SeqStat.Data = False
        Me.Btn_SeqStat.Enabled = False
        Me.Btn_SeqStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SeqStat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_SeqStat.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_SeqStat.Location = New System.Drawing.Point(44, 34)
        Me.Btn_SeqStat.Name = "Btn_SeqStat"
        Me.Btn_SeqStat.Size = New System.Drawing.Size(300, 75)
        Me.Btn_SeqStat.State = False
        Me.Btn_SeqStat.StateIsData = True
        Me.Btn_SeqStat.StateText = New String() {Nothing, Nothing}
        Me.Btn_SeqStat.TabIndex = 39
        Me.Btn_SeqStat.Tag = ""
        Me.Btn_SeqStat.Text = "Sequences Status"
        Me.Btn_SeqStat.UserInfo = Nothing
        Me.Btn_SeqStat.UserLevel = 0
        Me.Btn_SeqStat.UseStateText = False
        Me.Btn_SeqStat.UseVisualStyleBackColor = True
        '
        'Btn_IOStat
        '
        Me.Btn_IOStat.Audit = Nothing
        Me.Btn_IOStat.AuditEnabled = False
        Me.Btn_IOStat.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_IOStat.AuditSource = "KremerPushButton"
        Me.Btn_IOStat.BackColorOn = System.Drawing.Color.Empty
        Me.Btn_IOStat.BackGroundImageOn = Nothing
        Me.Btn_IOStat.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_IOStat.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_IOStat.Data = False
        Me.Btn_IOStat.Enabled = False
        Me.Btn_IOStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_IOStat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_IOStat.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_IOStat.Location = New System.Drawing.Point(44, 232)
        Me.Btn_IOStat.Name = "Btn_IOStat"
        Me.Btn_IOStat.Size = New System.Drawing.Size(300, 75)
        Me.Btn_IOStat.State = False
        Me.Btn_IOStat.StateIsData = True
        Me.Btn_IOStat.StateText = New String() {Nothing, Nothing}
        Me.Btn_IOStat.TabIndex = 40
        Me.Btn_IOStat.Tag = ""
        Me.Btn_IOStat.Text = "I/O Status"
        Me.Btn_IOStat.UserInfo = Nothing
        Me.Btn_IOStat.UserLevel = 0
        Me.Btn_IOStat.UseStateText = False
        Me.Btn_IOStat.UseVisualStyleBackColor = True
        '
        'Btn_Zero
        '
        Me.Btn_Zero.Audit = Nothing
        Me.Btn_Zero.AuditEnabled = False
        Me.Btn_Zero.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_Zero.AuditSource = "KremerPushButton"
        Me.Btn_Zero.BackColorOn = System.Drawing.Color.Empty
        Me.Btn_Zero.BackGroundImageOn = Nothing
        Me.Btn_Zero.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_Zero.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_Zero.Data = False
        Me.Btn_Zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Zero.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_Zero.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_Zero.Location = New System.Drawing.Point(433, 34)
        Me.Btn_Zero.Name = "Btn_Zero"
        Me.Btn_Zero.Size = New System.Drawing.Size(300, 75)
        Me.Btn_Zero.State = False
        Me.Btn_Zero.StateIsData = True
        Me.Btn_Zero.StateText = New String() {Nothing, Nothing}
        Me.Btn_Zero.TabIndex = 42
        Me.Btn_Zero.Tag = ""
        Me.Btn_Zero.Text = "Zero Absolute Encoders"
        Me.Btn_Zero.UserInfo = Nothing
        Me.Btn_Zero.UserLevel = 0
        Me.Btn_Zero.UseStateText = False
        Me.Btn_Zero.UseVisualStyleBackColor = True
        '
        'Btn_EtherCat_Topology
        '
        Me.Btn_EtherCat_Topology.Audit = Nothing
        Me.Btn_EtherCat_Topology.AuditEnabled = False
        Me.Btn_EtherCat_Topology.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_EtherCat_Topology.AuditSource = "KremerPushButton"
        Me.Btn_EtherCat_Topology.BackColorOn = System.Drawing.Color.Empty
        Me.Btn_EtherCat_Topology.BackGroundImageOn = Nothing
        Me.Btn_EtherCat_Topology.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_EtherCat_Topology.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_EtherCat_Topology.Data = False
        Me.Btn_EtherCat_Topology.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_EtherCat_Topology.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_EtherCat_Topology.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_EtherCat_Topology.Location = New System.Drawing.Point(433, 133)
        Me.Btn_EtherCat_Topology.Name = "Btn_EtherCat_Topology"
        Me.Btn_EtherCat_Topology.Size = New System.Drawing.Size(300, 75)
        Me.Btn_EtherCat_Topology.State = False
        Me.Btn_EtherCat_Topology.StateIsData = True
        Me.Btn_EtherCat_Topology.StateText = New String() {Nothing, Nothing}
        Me.Btn_EtherCat_Topology.TabIndex = 43
        Me.Btn_EtherCat_Topology.Tag = ""
        Me.Btn_EtherCat_Topology.Text = "EtherCat Topology"
        Me.Btn_EtherCat_Topology.UserInfo = Nothing
        Me.Btn_EtherCat_Topology.UserLevel = 0
        Me.Btn_EtherCat_Topology.UseStateText = False
        Me.Btn_EtherCat_Topology.UseVisualStyleBackColor = True
        '
        'Btn_CilinderTimes
        '
        Me.Btn_CilinderTimes.Audit = Nothing
        Me.Btn_CilinderTimes.AuditEnabled = False
        Me.Btn_CilinderTimes.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_CilinderTimes.AuditSource = "KremerPushButton"
        Me.Btn_CilinderTimes.BackColorOn = System.Drawing.Color.Empty
        Me.Btn_CilinderTimes.BackGroundImageOn = Nothing
        Me.Btn_CilinderTimes.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_CilinderTimes.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_CilinderTimes.Data = False
        Me.Btn_CilinderTimes.Enabled = False
        Me.Btn_CilinderTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_CilinderTimes.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_CilinderTimes.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_CilinderTimes.Location = New System.Drawing.Point(44, 331)
        Me.Btn_CilinderTimes.Name = "Btn_CilinderTimes"
        Me.Btn_CilinderTimes.Size = New System.Drawing.Size(300, 75)
        Me.Btn_CilinderTimes.State = False
        Me.Btn_CilinderTimes.StateIsData = True
        Me.Btn_CilinderTimes.StateText = New String() {Nothing, Nothing}
        Me.Btn_CilinderTimes.TabIndex = 44
        Me.Btn_CilinderTimes.Tag = ""
        Me.Btn_CilinderTimes.Text = "Cilinder Times"
        Me.Btn_CilinderTimes.UserInfo = Nothing
        Me.Btn_CilinderTimes.UserLevel = 0
        Me.Btn_CilinderTimes.UseStateText = False
        Me.Btn_CilinderTimes.UseVisualStyleBackColor = True
        '
        'Btn_SeqInitStat
        '
        Me.Btn_SeqInitStat.Audit = Nothing
        Me.Btn_SeqInitStat.AuditEnabled = False
        Me.Btn_SeqInitStat.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_SeqInitStat.AuditSource = "KremerPushButton"
        Me.Btn_SeqInitStat.BackColorOn = System.Drawing.Color.Empty
        Me.Btn_SeqInitStat.BackGroundImageOn = Nothing
        Me.Btn_SeqInitStat.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_SeqInitStat.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_SeqInitStat.Data = False
        Me.Btn_SeqInitStat.Enabled = False
        Me.Btn_SeqInitStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SeqInitStat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_SeqInitStat.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_SeqInitStat.Location = New System.Drawing.Point(44, 133)
        Me.Btn_SeqInitStat.Name = "Btn_SeqInitStat"
        Me.Btn_SeqInitStat.Size = New System.Drawing.Size(300, 75)
        Me.Btn_SeqInitStat.State = False
        Me.Btn_SeqInitStat.StateIsData = True
        Me.Btn_SeqInitStat.StateText = New String() {Nothing, Nothing}
        Me.Btn_SeqInitStat.TabIndex = 45
        Me.Btn_SeqInitStat.Tag = ""
        Me.Btn_SeqInitStat.Text = "Init" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sequences Status"
        Me.Btn_SeqInitStat.UserInfo = Nothing
        Me.Btn_SeqInitStat.UserLevel = 0
        Me.Btn_SeqInitStat.UseStateText = False
        Me.Btn_SeqInitStat.UseVisualStyleBackColor = True
        '
        'Btn_ServiceSettings
        '
        Me.Btn_ServiceSettings.Audit = Nothing
        Me.Btn_ServiceSettings.AuditEnabled = False
        Me.Btn_ServiceSettings.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_ServiceSettings.AuditSource = "KremerPushButton"
        Me.Btn_ServiceSettings.BackColorOn = System.Drawing.Color.Empty
        Me.Btn_ServiceSettings.BackGroundImageOn = Nothing
        Me.Btn_ServiceSettings.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_ServiceSettings.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_ServiceSettings.Data = False
        Me.Btn_ServiceSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ServiceSettings.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_ServiceSettings.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_ServiceSettings.Location = New System.Drawing.Point(433, 331)
        Me.Btn_ServiceSettings.Name = "Btn_ServiceSettings"
        Me.Btn_ServiceSettings.Size = New System.Drawing.Size(300, 75)
        Me.Btn_ServiceSettings.State = False
        Me.Btn_ServiceSettings.StateIsData = True
        Me.Btn_ServiceSettings.StateText = New String() {Nothing, Nothing}
        Me.Btn_ServiceSettings.TabIndex = 46
        Me.Btn_ServiceSettings.Tag = ""
        Me.Btn_ServiceSettings.Text = "Programmer settings list"
        Me.Btn_ServiceSettings.UserInfo = Nothing
        Me.Btn_ServiceSettings.UserLevel = 900
        Me.Btn_ServiceSettings.UseStateText = False
        Me.Btn_ServiceSettings.UseVisualStyleBackColor = True
        '
        'Btn_I2T
        '
        Me.Btn_I2T.Audit = Nothing
        Me.Btn_I2T.AuditEnabled = False
        Me.Btn_I2T.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_I2T.AuditSource = "KremerPushButton"
        Me.Btn_I2T.BackColorOn = System.Drawing.Color.Empty
        Me.Btn_I2T.BackGroundImageOn = Nothing
        Me.Btn_I2T.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_I2T.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_I2T.Data = False
        Me.Btn_I2T.Enabled = False
        Me.Btn_I2T.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_I2T.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_I2T.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_I2T.Location = New System.Drawing.Point(433, 232)
        Me.Btn_I2T.Name = "Btn_I2T"
        Me.Btn_I2T.Size = New System.Drawing.Size(300, 75)
        Me.Btn_I2T.State = False
        Me.Btn_I2T.StateIsData = True
        Me.Btn_I2T.StateText = New String() {Nothing, Nothing}
        Me.Btn_I2T.TabIndex = 47
        Me.Btn_I2T.Tag = ""
        Me.Btn_I2T.Text = "I2T settings"
        Me.Btn_I2T.UserInfo = Nothing
        Me.Btn_I2T.UserLevel = 0
        Me.Btn_I2T.UseStateText = False
        Me.Btn_I2T.UseVisualStyleBackColor = True
        '
        'Service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Btn_I2T)
        Me.Controls.Add(Me.Btn_ServiceSettings)
        Me.Controls.Add(Me.Btn_SeqInitStat)
        Me.Controls.Add(Me.Btn_CilinderTimes)
        Me.Controls.Add(Me.Btn_EtherCat_Topology)
        Me.Controls.Add(Me.Btn_Zero)
        Me.Controls.Add(Me.Btn_IOStat)
        Me.Controls.Add(Me.Btn_SeqStat)
        Me.Name = "Service"
        Me.Size = New System.Drawing.Size(800, 441)
        Me.Tag = "51"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents krConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents krVarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents Btn_SeqStat As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_IOStat As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_Zero As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_EtherCat_Topology As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_CilinderTimes As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_SeqInitStat As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_ServiceSettings As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_I2T As KremerControlsWin32.KremerButton

End Class
