<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormingMold_Manual
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
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lbl_puh = New System.Windows.Forms.Label()
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.btn_Settings = New KremerControlsWin32.KremerButton()
        Me.Btn_Overview = New KremerControlsWin32.KremerButton()
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.tmrMouseState = New System.Windows.Forms.Timer(Me.components)
        Me.io_HorTransp_Pos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.btn_TelescopBeltDir_BWD = New KremerControlsWin32.KremerButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KremerButton1 = New KremerControlsWin32.KremerButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 435)
        Me.ShapeContainer1.TabIndex = 205
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 21
        Me.LineShape1.X2 = 391
        Me.LineShape1.Y1 = 43
        Me.LineShape1.Y2 = 43
        '
        'lbl_puh
        '
        Me.lbl_puh.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_puh.Location = New System.Drawing.Point(20, 19)
        Me.lbl_puh.Name = "lbl_puh"
        Me.lbl_puh.Size = New System.Drawing.Size(291, 23)
        Me.lbl_puh.TabIndex = 206
        Me.lbl_puh.Tag = ""
        Me.lbl_puh.Text = "Valves"
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'btn_Settings
        '
        Me.btn_Settings.Audit = Nothing
        Me.btn_Settings.AuditEnabled = False
        Me.btn_Settings.AuditMessage = "KremerPushButton pressed!"
        Me.btn_Settings.AuditSource = "KremerPushButton"
        Me.btn_Settings.BackColorOn = System.Drawing.Color.Empty
        Me.btn_Settings.BackGroundImageOn = Nothing
        Me.btn_Settings.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.btn_Settings.Data = False
        Me.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Settings.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Settings.ForeColorOn = System.Drawing.Color.Empty
        Me.btn_Settings.Location = New System.Drawing.Point(684, 324)
        Me.btn_Settings.Name = "btn_Settings"
        Me.btn_Settings.Size = New System.Drawing.Size(113, 50)
        Me.btn_Settings.State = False
        Me.btn_Settings.StateIsData = True
        Me.btn_Settings.StateText = New String() {Nothing, Nothing}
        Me.btn_Settings.TabIndex = 4
        Me.btn_Settings.Tag = "193"
        Me.btn_Settings.Text = "Settings"
        Me.btn_Settings.UserInfo = Nothing
        Me.btn_Settings.UserLevel = 0
        Me.btn_Settings.UseStateText = False
        Me.btn_Settings.UseVisualStyleBackColor = True
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
        Me.Btn_Overview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Overview.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Overview.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_Overview.Location = New System.Drawing.Point(684, 380)
        Me.Btn_Overview.Name = "Btn_Overview"
        Me.Btn_Overview.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Overview.State = False
        Me.Btn_Overview.StateIsData = True
        Me.Btn_Overview.StateText = New String() {Nothing, Nothing}
        Me.Btn_Overview.TabIndex = 2
        Me.Btn_Overview.Tag = "194"
        Me.Btn_Overview.Text = "Overview"
        Me.Btn_Overview.UserInfo = Nothing
        Me.Btn_Overview.UserLevel = 0
        Me.Btn_Overview.UseStateText = False
        Me.Btn_Overview.UseVisualStyleBackColor = True
        '
        'tmrMouseState
        '
        Me.tmrMouseState.Enabled = True
        Me.tmrMouseState.Interval = 200
        '
        'io_HorTransp_Pos
        '
        Me.io_HorTransp_Pos.Audit = Nothing
        Me.io_HorTransp_Pos.AuditEnabled = False
        Me.io_HorTransp_Pos.AuditMessage = "KremerIoField changed:"
        Me.io_HorTransp_Pos.AuditSource = "KremerIoField"
        Me.io_HorTransp_Pos.Data = 0.0R
        Me.io_HorTransp_Pos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.io_HorTransp_Pos.InitialValue = True
        Me.io_HorTransp_Pos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.io_HorTransp_Pos.Location = New System.Drawing.Point(321, 19)
        Me.io_HorTransp_Pos.LowerBound = 0.0R
        Me.io_HorTransp_Pos.Name = "io_HorTransp_Pos"
        Me.io_HorTransp_Pos.OutputFormat = "0.0 mm"
        Me.io_HorTransp_Pos.Size = New System.Drawing.Size(71, 21)
        Me.io_HorTransp_Pos.TabIndex = 262
        Me.io_HorTransp_Pos.Text = "0,0 mm"
        Me.io_HorTransp_Pos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.io_HorTransp_Pos.UpperBound = 1000.0R
        Me.io_HorTransp_Pos.UserInfo = Nothing
        Me.io_HorTransp_Pos.UserLevel = 0
        '
        'btn_TelescopBeltDir_BWD
        '
        Me.btn_TelescopBeltDir_BWD.Audit = Nothing
        Me.btn_TelescopBeltDir_BWD.AuditEnabled = False
        Me.btn_TelescopBeltDir_BWD.AuditMessage = "KremerPushButton pressed!"
        Me.btn_TelescopBeltDir_BWD.AuditSource = "KremerPushButton"
        Me.btn_TelescopBeltDir_BWD.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_TelescopBeltDir_BWD.BackGroundImageOn = Nothing
        Me.btn_TelescopBeltDir_BWD.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.btn_TelescopBeltDir_BWD.Data = False
        Me.btn_TelescopBeltDir_BWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_TelescopBeltDir_BWD.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_TelescopBeltDir_BWD.ForeColorOn = System.Drawing.Color.Yellow
        Me.btn_TelescopBeltDir_BWD.Location = New System.Drawing.Point(266, 52)
        Me.btn_TelescopBeltDir_BWD.Name = "btn_TelescopBeltDir_BWD"
        Me.btn_TelescopBeltDir_BWD.Size = New System.Drawing.Size(106, 36)
        Me.btn_TelescopBeltDir_BWD.State = False
        Me.btn_TelescopBeltDir_BWD.StateIsData = True
        Me.btn_TelescopBeltDir_BWD.StateText = New String() {Nothing, Nothing}
        Me.btn_TelescopBeltDir_BWD.TabIndex = 291
        Me.btn_TelescopBeltDir_BWD.Tag = ""
        Me.btn_TelescopBeltDir_BWD.Text = "Open"
        Me.btn_TelescopBeltDir_BWD.UserInfo = Nothing
        Me.btn_TelescopBeltDir_BWD.UserLevel = 0
        Me.btn_TelescopBeltDir_BWD.UseStateText = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 23)
        Me.Label1.TabIndex = 290
        Me.Label1.Tag = ""
        Me.Label1.Text = "Vacuum valve"
        '
        'KremerButton1
        '
        Me.KremerButton1.Audit = Nothing
        Me.KremerButton1.AuditEnabled = False
        Me.KremerButton1.AuditMessage = "KremerPushButton pressed!"
        Me.KremerButton1.AuditSource = "KremerPushButton"
        Me.KremerButton1.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.KremerButton1.BackGroundImageOn = Nothing
        Me.KremerButton1.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.KremerButton1.Data = False
        Me.KremerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KremerButton1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.KremerButton1.ForeColorOn = System.Drawing.Color.Yellow
        Me.KremerButton1.Location = New System.Drawing.Point(266, 92)
        Me.KremerButton1.Name = "KremerButton1"
        Me.KremerButton1.Size = New System.Drawing.Size(106, 36)
        Me.KremerButton1.State = False
        Me.KremerButton1.StateIsData = True
        Me.KremerButton1.StateText = New String() {Nothing, Nothing}
        Me.KremerButton1.TabIndex = 293
        Me.KremerButton1.Tag = ""
        Me.KremerButton1.Text = "Open"
        Me.KremerButton1.UserInfo = Nothing
        Me.KremerButton1.UserLevel = 0
        Me.KremerButton1.UseStateText = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 23)
        Me.Label2.TabIndex = 292
        Me.Label2.Tag = ""
        Me.Label2.Text = "Blowoff valve"
        '
        'FormingMold_Manual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.KremerButton1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_TelescopBeltDir_BWD)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.io_HorTransp_Pos)
        Me.Controls.Add(Me.lbl_puh)
        Me.Controls.Add(Me.btn_Settings)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "FormingMold_Manual"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "99"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents btn_Settings As KremerControlsWin32.KremerButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lbl_puh As System.Windows.Forms.Label
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents tmrMouseState As System.Windows.Forms.Timer
    Friend WithEvents io_HorTransp_Pos As KremerControlsWin32.KremerIoField
    Friend WithEvents btn_TelescopBeltDir_BWD As KremerControlsWin32.KremerButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KremerButton1 As KremerControlsWin32.KremerButton
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
