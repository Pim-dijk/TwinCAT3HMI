<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConveyorBelt_Manual
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
        Me.Btn_Settings = New KremerControlsWin32.KremerButton()
        Me.Btn_Overview = New KremerControlsWin32.KremerButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.CON_ManFwd = New KremerControlsWin32.KremerVariable(Me.components)
        Me.CON_ManRev = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_Fwd = New KremerControlsWin32.KremerButton()
        Me.Btn_Rev = New KremerControlsWin32.KremerButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Settings
        '
        Me.Btn_Settings.Audit = Nothing
        Me.Btn_Settings.AuditEnabled = False
        Me.Btn_Settings.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_Settings.AuditSource = "KremerPushButton"
        Me.Btn_Settings.BackColorOn = System.Drawing.Color.Empty
        Me.Btn_Settings.BackGroundImageOn = Nothing
        Me.Btn_Settings.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_Settings.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_Settings.Data = False
        Me.Btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Settings.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Settings.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_Settings.Location = New System.Drawing.Point(684, 324)
        Me.Btn_Settings.Name = "Btn_Settings"
        Me.Btn_Settings.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Settings.State = False
        Me.Btn_Settings.StateIsData = True
        Me.Btn_Settings.StateText = New String() {Nothing, Nothing}
        Me.Btn_Settings.TabIndex = 8
        Me.Btn_Settings.Tag = "193"
        Me.Btn_Settings.Text = "Settings"
        Me.Btn_Settings.UserInfo = Nothing
        Me.Btn_Settings.UserLevel = 0
        Me.Btn_Settings.UseStateText = False
        Me.Btn_Settings.UseVisualStyleBackColor = True
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
        Me.Btn_Overview.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Overview.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_Overview.Location = New System.Drawing.Point(684, 380)
        Me.Btn_Overview.Name = "Btn_Overview"
        Me.Btn_Overview.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Overview.State = False
        Me.Btn_Overview.StateIsData = True
        Me.Btn_Overview.StateText = New String() {Nothing, Nothing}
        Me.Btn_Overview.TabIndex = 7
        Me.Btn_Overview.Tag = "194"
        Me.Btn_Overview.Text = "Overview"
        Me.Btn_Overview.UserInfo = Nothing
        Me.Btn_Overview.UserLevel = 0
        Me.Btn_Overview.UseStateText = False
        Me.Btn_Overview.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 435)
        Me.ShapeContainer1.TabIndex = 242
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 25
        Me.LineShape1.X2 = 400
        Me.LineShape1.Y1 = 37
        Me.LineShape1.Y2 = 37
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Me.VarCollector
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.CON_ManFwd)
        Me.VarCollector.Variables.Add(Me.CON_ManRev)
        '
        'CON_ManFwd
        '
        Me.CON_ManFwd.BindControl = Me.Btn_Fwd
        Me.CON_ManFwd.BindProperty = "Data"
        Me.CON_ManFwd.Data = Nothing
        Me.CON_ManFwd.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.CON_ManFwd.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.CON_ManFwd.VariableName = "MAIN.ProductHandling.OutfeedConveyor.Belt.HMI_Forward"
        '
        'CON_ManRev
        '
        Me.CON_ManRev.BindControl = Me.Btn_Rev
        Me.CON_ManRev.BindProperty = "Data"
        Me.CON_ManRev.Data = Nothing
        Me.CON_ManRev.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.CON_ManRev.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.CON_ManRev.VariableName = "MAIN.ProductHandling.OutfeedConveyor.Belt.HMI_Backward"
        '
        'Btn_Fwd
        '
        Me.Btn_Fwd.Audit = Nothing
        Me.Btn_Fwd.AuditEnabled = False
        Me.Btn_Fwd.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_Fwd.AuditSource = "KremerPushButton"
        Me.Btn_Fwd.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Fwd.BackGroundImageOn = Nothing
        Me.Btn_Fwd.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_Fwd.Data = False
        Me.Btn_Fwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Fwd.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Fwd.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_Fwd.Location = New System.Drawing.Point(179, 44)
        Me.Btn_Fwd.Name = "Btn_Fwd"
        Me.Btn_Fwd.Size = New System.Drawing.Size(106, 36)
        Me.Btn_Fwd.State = False
        Me.Btn_Fwd.StateIsData = True
        Me.Btn_Fwd.StateText = New String() {Nothing, Nothing}
        Me.Btn_Fwd.TabIndex = 345
        Me.Btn_Fwd.Tag = "31"
        Me.Btn_Fwd.Text = "Forward"
        Me.Btn_Fwd.UserInfo = Nothing
        Me.Btn_Fwd.UserLevel = 0
        Me.Btn_Fwd.UseStateText = False
        '
        'Btn_Rev
        '
        Me.Btn_Rev.Audit = Nothing
        Me.Btn_Rev.AuditEnabled = False
        Me.Btn_Rev.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_Rev.AuditSource = "KremerPushButton"
        Me.Btn_Rev.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Rev.BackGroundImageOn = Nothing
        Me.Btn_Rev.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_Rev.Data = False
        Me.Btn_Rev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Rev.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Rev.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_Rev.Location = New System.Drawing.Point(289, 44)
        Me.Btn_Rev.Name = "Btn_Rev"
        Me.Btn_Rev.Size = New System.Drawing.Size(106, 36)
        Me.Btn_Rev.State = False
        Me.Btn_Rev.StateIsData = True
        Me.Btn_Rev.StateText = New String() {Nothing, Nothing}
        Me.Btn_Rev.TabIndex = 341
        Me.Btn_Rev.Tag = "32"
        Me.Btn_Rev.Text = "Reverse"
        Me.Btn_Rev.UserInfo = Nothing
        Me.Btn_Rev.UserLevel = 0
        Me.Btn_Rev.UseStateText = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 23)
        Me.Label8.TabIndex = 342
        Me.Label8.Tag = ""
        Me.Label8.Text = "Belt move"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(21, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(329, 23)
        Me.Label9.TabIndex = 351
        Me.Label9.Tag = ""
        Me.Label9.Text = "Conveyor belt"
        '
        'ConveyorBelt_Manual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Btn_Fwd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Btn_Rev)
        Me.Controls.Add(Me.Btn_Settings)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "ConveyorBelt_Manual"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "102"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Settings As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents Btn_Fwd As KremerControlsWin32.KremerButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Btn_Rev As KremerControlsWin32.KremerButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CON_ManFwd As KremerControlsWin32.KremerVariable
    Friend WithEvents CON_ManRev As KremerControlsWin32.KremerVariable

End Class
