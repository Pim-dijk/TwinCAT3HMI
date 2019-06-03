<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormingMold_Settings
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
        Me.Btn_Overview = New KremerControlsWin32.KremerButton()
        Me.Btn_Manual = New KremerControlsWin32.KremerButton()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.KremerIoField7 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.KremerIoField6 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.KremerIoField1 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.KremerIoField2 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.KremerIoField4 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
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
        Me.Btn_Overview.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_Overview.Data = False
        Me.Btn_Overview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Overview.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Overview.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_Overview.Location = New System.Drawing.Point(683, 326)
        Me.Btn_Overview.Name = "Btn_Overview"
        Me.Btn_Overview.Size = New System.Drawing.Size(114, 50)
        Me.Btn_Overview.State = False
        Me.Btn_Overview.StateIsData = True
        Me.Btn_Overview.StateText = New String() {Nothing, Nothing}
        Me.Btn_Overview.TabIndex = 242
        Me.Btn_Overview.Tag = "194"
        Me.Btn_Overview.Text = "Overview"
        Me.Btn_Overview.UserInfo = Nothing
        Me.Btn_Overview.UserLevel = 0
        Me.Btn_Overview.UseStateText = False
        Me.Btn_Overview.UseVisualStyleBackColor = True
        '
        'Btn_Manual
        '
        Me.Btn_Manual.Audit = Nothing
        Me.Btn_Manual.AuditEnabled = False
        Me.Btn_Manual.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_Manual.AuditSource = "KremerPushButton"
        Me.Btn_Manual.BackColorOn = System.Drawing.Color.Empty
        Me.Btn_Manual.BackGroundImageOn = Nothing
        Me.Btn_Manual.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_Manual.Data = False
        Me.Btn_Manual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Manual.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Manual.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_Manual.Location = New System.Drawing.Point(683, 382)
        Me.Btn_Manual.Name = "Btn_Manual"
        Me.Btn_Manual.Size = New System.Drawing.Size(114, 50)
        Me.Btn_Manual.State = False
        Me.Btn_Manual.StateIsData = True
        Me.Btn_Manual.StateText = New String() {Nothing, Nothing}
        Me.Btn_Manual.TabIndex = 241
        Me.Btn_Manual.Tag = "192"
        Me.Btn_Manual.Text = "Manual Control"
        Me.Btn_Manual.UserInfo = Nothing
        Me.Btn_Manual.UserLevel = 0
        Me.Btn_Manual.UseStateText = False
        Me.Btn_Manual.UseVisualStyleBackColor = True
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 25
        Me.LineShape4.X2 = 375
        Me.LineShape4.Y1 = 50
        Me.LineShape4.Y2 = 50
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.LineShape4})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 435)
        Me.ShapeContainer1.TabIndex = 272
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 270
        Me.LineShape1.X2 = 270
        Me.LineShape1.Y1 = 50
        Me.LineShape1.Y2 = 175
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(21, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 23)
        Me.Label3.TabIndex = 319
        Me.Label3.Tag = ""
        Me.Label3.Text = "Timing:"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(21, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(247, 23)
        Me.Label11.TabIndex = 343
        Me.Label11.Tag = ""
        Me.Label11.Text = "Forming mold after blow time"
        '
        'KremerIoField7
        '
        Me.KremerIoField7.Audit = Nothing
        Me.KremerIoField7.AuditEnabled = False
        Me.KremerIoField7.AuditMessage = "KremerIoField changed:"
        Me.KremerIoField7.AuditSource = "KremerIoField"
        Me.KremerIoField7.BackColor = System.Drawing.Color.White
        Me.KremerIoField7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KremerIoField7.Data = 0.0R
        Me.KremerIoField7.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.KremerIoField7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerIoField7.InitialValue = True
        Me.KremerIoField7.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.KremerIoField7.Location = New System.Drawing.Point(274, 143)
        Me.KremerIoField7.LowerBound = 0.0R
        Me.KremerIoField7.Name = "KremerIoField7"
        Me.KremerIoField7.OutputFormat = "0.0 ms"
        Me.KremerIoField7.Size = New System.Drawing.Size(100, 22)
        Me.KremerIoField7.TabIndex = 342
        Me.KremerIoField7.Text = "0.0 ms"
        Me.KremerIoField7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.KremerIoField7.UpperBound = 5000.0R
        Me.KremerIoField7.UserInfo = Nothing
        Me.KremerIoField7.UserLevel = 800
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(247, 23)
        Me.Label10.TabIndex = 341
        Me.Label10.Tag = ""
        Me.Label10.Text = "Forming mold blow off time"
        '
        'KremerIoField6
        '
        Me.KremerIoField6.Audit = Nothing
        Me.KremerIoField6.AuditEnabled = False
        Me.KremerIoField6.AuditMessage = "KremerIoField changed:"
        Me.KremerIoField6.AuditSource = "KremerIoField"
        Me.KremerIoField6.BackColor = System.Drawing.Color.White
        Me.KremerIoField6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KremerIoField6.Data = 0.0R
        Me.KremerIoField6.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.KremerIoField6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerIoField6.InitialValue = True
        Me.KremerIoField6.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.KremerIoField6.Location = New System.Drawing.Point(274, 120)
        Me.KremerIoField6.LowerBound = 0.0R
        Me.KremerIoField6.Name = "KremerIoField6"
        Me.KremerIoField6.OutputFormat = "0.0 ms"
        Me.KremerIoField6.Size = New System.Drawing.Size(100, 22)
        Me.KremerIoField6.TabIndex = 340
        Me.KremerIoField6.Text = "0.0 ms"
        Me.KremerIoField6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.KremerIoField6.UpperBound = 5000.0R
        Me.KremerIoField6.UserInfo = Nothing
        Me.KremerIoField6.UserLevel = 800
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 23)
        Me.Label4.TabIndex = 339
        Me.Label4.Tag = ""
        Me.Label4.Text = "Forming mold vac. time flash"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 23)
        Me.Label5.TabIndex = 338
        Me.Label5.Tag = ""
        Me.Label5.Text = "Forming mold bubble time"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(247, 23)
        Me.Label7.TabIndex = 337
        Me.Label7.Tag = ""
        Me.Label7.Text = "Forming mold vacuum time"
        '
        'KremerIoField1
        '
        Me.KremerIoField1.Audit = Nothing
        Me.KremerIoField1.AuditEnabled = False
        Me.KremerIoField1.AuditMessage = "KremerIoField changed:"
        Me.KremerIoField1.AuditSource = "KremerIoField"
        Me.KremerIoField1.BackColor = System.Drawing.Color.White
        Me.KremerIoField1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KremerIoField1.Data = 0.0R
        Me.KremerIoField1.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.KremerIoField1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerIoField1.InitialValue = True
        Me.KremerIoField1.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.KremerIoField1.Location = New System.Drawing.Point(274, 75)
        Me.KremerIoField1.LowerBound = 0.0R
        Me.KremerIoField1.Name = "KremerIoField1"
        Me.KremerIoField1.OutputFormat = "0.0 ms"
        Me.KremerIoField1.Size = New System.Drawing.Size(100, 22)
        Me.KremerIoField1.TabIndex = 336
        Me.KremerIoField1.Text = "0.0 ms"
        Me.KremerIoField1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.KremerIoField1.UpperBound = 5000.0R
        Me.KremerIoField1.UserInfo = Nothing
        Me.KremerIoField1.UserLevel = 800
        '
        'KremerIoField2
        '
        Me.KremerIoField2.Audit = Nothing
        Me.KremerIoField2.AuditEnabled = False
        Me.KremerIoField2.AuditMessage = "KremerIoField changed:"
        Me.KremerIoField2.AuditSource = "KremerIoField"
        Me.KremerIoField2.BackColor = System.Drawing.Color.White
        Me.KremerIoField2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KremerIoField2.Data = 0.0R
        Me.KremerIoField2.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.KremerIoField2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerIoField2.InitialValue = True
        Me.KremerIoField2.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.KremerIoField2.Location = New System.Drawing.Point(274, 97)
        Me.KremerIoField2.LowerBound = 0.0R
        Me.KremerIoField2.Name = "KremerIoField2"
        Me.KremerIoField2.OutputFormat = "0.0 ms"
        Me.KremerIoField2.Size = New System.Drawing.Size(100, 22)
        Me.KremerIoField2.TabIndex = 335
        Me.KremerIoField2.Text = "0.0 ms"
        Me.KremerIoField2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.KremerIoField2.UpperBound = 5000.0R
        Me.KremerIoField2.UserInfo = Nothing
        Me.KremerIoField2.UserLevel = 800
        '
        'KremerIoField4
        '
        Me.KremerIoField4.Audit = Nothing
        Me.KremerIoField4.AuditEnabled = False
        Me.KremerIoField4.AuditMessage = "KremerIoField changed:"
        Me.KremerIoField4.AuditSource = "KremerIoField"
        Me.KremerIoField4.BackColor = System.Drawing.Color.White
        Me.KremerIoField4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KremerIoField4.Data = 0.0R
        Me.KremerIoField4.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.KremerIoField4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerIoField4.InitialValue = True
        Me.KremerIoField4.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.KremerIoField4.Location = New System.Drawing.Point(274, 52)
        Me.KremerIoField4.LowerBound = 0.0R
        Me.KremerIoField4.Name = "KremerIoField4"
        Me.KremerIoField4.OutputFormat = "0.0 ms"
        Me.KremerIoField4.Size = New System.Drawing.Size(100, 22)
        Me.KremerIoField4.TabIndex = 334
        Me.KremerIoField4.Text = "0.0 ms"
        Me.KremerIoField4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.KremerIoField4.UpperBound = 500.0R
        Me.KremerIoField4.UserInfo = Nothing
        Me.KremerIoField4.UserLevel = 800
        '
        'FormingMold_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.KremerIoField7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.KremerIoField6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.KremerIoField1)
        Me.Controls.Add(Me.KremerIoField2)
        Me.Controls.Add(Me.KremerIoField4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Controls.Add(Me.Btn_Manual)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "FormingMold_Settings"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "100"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_Manual As KremerControlsWin32.KremerButton
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents KremerIoField7 As KremerControlsWin32.KremerIoField
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents KremerIoField6 As KremerControlsWin32.KremerIoField
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents KremerIoField1 As KremerControlsWin32.KremerIoField
    Friend WithEvents KremerIoField2 As KremerControlsWin32.KremerIoField
    Friend WithEvents KremerIoField4 As KremerControlsWin32.KremerIoField

End Class
