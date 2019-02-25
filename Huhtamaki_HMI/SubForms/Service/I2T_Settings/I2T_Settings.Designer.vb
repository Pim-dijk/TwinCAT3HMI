<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class I2T_Settings
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
        Me.ioI2tZipperWarning = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ioI2tZipperError = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ioI2tZipperActValue = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ioI2tPickupHeadWarning = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ioI2tPickupHeadError = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ioI2tPickupHeadActValue = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape11 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'krConnector
        '
        Me.krConnector.VarCollector = Nothing
        '
        'ioI2tZipperWarning
        '
        Me.ioI2tZipperWarning.Audit = Nothing
        Me.ioI2tZipperWarning.AuditEnabled = False
        Me.ioI2tZipperWarning.AuditMessage = "KremerIoField changed:"
        Me.ioI2tZipperWarning.AuditSource = "KremerIoField"
        Me.ioI2tZipperWarning.BackColor = System.Drawing.Color.White
        Me.ioI2tZipperWarning.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ioI2tZipperWarning.Data = 0.0R
        Me.ioI2tZipperWarning.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioI2tZipperWarning.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioI2tZipperWarning.InitialValue = True
        Me.ioI2tZipperWarning.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.ioI2tZipperWarning.Location = New System.Drawing.Point(280, 37)
        Me.ioI2tZipperWarning.LowerBound = 0.0R
        Me.ioI2tZipperWarning.Name = "ioI2tZipperWarning"
        Me.ioI2tZipperWarning.OutputFormat = "0 '%'"
        Me.ioI2tZipperWarning.Size = New System.Drawing.Size(100, 22)
        Me.ioI2tZipperWarning.TabIndex = 389
        Me.ioI2tZipperWarning.Text = "0 %"
        Me.ioI2tZipperWarning.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioI2tZipperWarning.UpperBound = 100.0R
        Me.ioI2tZipperWarning.UserInfo = Nothing
        Me.ioI2tZipperWarning.UserLevel = 800
        '
        'ioI2tZipperError
        '
        Me.ioI2tZipperError.Audit = Nothing
        Me.ioI2tZipperError.AuditEnabled = False
        Me.ioI2tZipperError.AuditMessage = "KremerIoField changed:"
        Me.ioI2tZipperError.AuditSource = "KremerIoField"
        Me.ioI2tZipperError.BackColor = System.Drawing.Color.White
        Me.ioI2tZipperError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ioI2tZipperError.Data = 0.0R
        Me.ioI2tZipperError.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioI2tZipperError.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioI2tZipperError.InitialValue = True
        Me.ioI2tZipperError.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.ioI2tZipperError.Location = New System.Drawing.Point(280, 60)
        Me.ioI2tZipperError.LowerBound = 0.0R
        Me.ioI2tZipperError.Name = "ioI2tZipperError"
        Me.ioI2tZipperError.OutputFormat = "0 '%'"
        Me.ioI2tZipperError.Size = New System.Drawing.Size(100, 22)
        Me.ioI2tZipperError.TabIndex = 391
        Me.ioI2tZipperError.Text = "0 %"
        Me.ioI2tZipperError.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioI2tZipperError.UpperBound = 100.0R
        Me.ioI2tZipperError.UserInfo = Nothing
        Me.ioI2tZipperError.UserLevel = 800
        '
        'ioI2tZipperActValue
        '
        Me.ioI2tZipperActValue.Audit = Nothing
        Me.ioI2tZipperActValue.AuditEnabled = False
        Me.ioI2tZipperActValue.AuditMessage = "KremerIoField changed:"
        Me.ioI2tZipperActValue.AuditSource = "KremerIoField"
        Me.ioI2tZipperActValue.BackColor = System.Drawing.SystemColors.Control
        Me.ioI2tZipperActValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ioI2tZipperActValue.Data = 0.0R
        Me.ioI2tZipperActValue.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioI2tZipperActValue.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioI2tZipperActValue.InitialValue = True
        Me.ioI2tZipperActValue.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioI2tZipperActValue.Location = New System.Drawing.Point(10, 60)
        Me.ioI2tZipperActValue.LowerBound = 0.0R
        Me.ioI2tZipperActValue.Name = "ioI2tZipperActValue"
        Me.ioI2tZipperActValue.OutputFormat = "0.0 '%'"
        Me.ioI2tZipperActValue.Size = New System.Drawing.Size(76, 22)
        Me.ioI2tZipperActValue.TabIndex = 392
        Me.ioI2tZipperActValue.Text = "0.0 %"
        Me.ioI2tZipperActValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioI2tZipperActValue.UpperBound = 100.0R
        Me.ioI2tZipperActValue.UserInfo = Nothing
        Me.ioI2tZipperActValue.UserLevel = 999
        '
        'ioI2tPickupHeadWarning
        '
        Me.ioI2tPickupHeadWarning.Audit = Nothing
        Me.ioI2tPickupHeadWarning.AuditEnabled = False
        Me.ioI2tPickupHeadWarning.AuditMessage = "KremerIoField changed:"
        Me.ioI2tPickupHeadWarning.AuditSource = "KremerIoField"
        Me.ioI2tPickupHeadWarning.BackColor = System.Drawing.Color.White
        Me.ioI2tPickupHeadWarning.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ioI2tPickupHeadWarning.Data = 0.0R
        Me.ioI2tPickupHeadWarning.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioI2tPickupHeadWarning.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioI2tPickupHeadWarning.InitialValue = True
        Me.ioI2tPickupHeadWarning.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.ioI2tPickupHeadWarning.Location = New System.Drawing.Point(680, 37)
        Me.ioI2tPickupHeadWarning.LowerBound = 0.0R
        Me.ioI2tPickupHeadWarning.Name = "ioI2tPickupHeadWarning"
        Me.ioI2tPickupHeadWarning.OutputFormat = "0 '%'"
        Me.ioI2tPickupHeadWarning.Size = New System.Drawing.Size(100, 22)
        Me.ioI2tPickupHeadWarning.TabIndex = 430
        Me.ioI2tPickupHeadWarning.Text = "0 %"
        Me.ioI2tPickupHeadWarning.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioI2tPickupHeadWarning.UpperBound = 100.0R
        Me.ioI2tPickupHeadWarning.UserInfo = Nothing
        Me.ioI2tPickupHeadWarning.UserLevel = 800
        '
        'ioI2tPickupHeadError
        '
        Me.ioI2tPickupHeadError.Audit = Nothing
        Me.ioI2tPickupHeadError.AuditEnabled = False
        Me.ioI2tPickupHeadError.AuditMessage = "KremerIoField changed:"
        Me.ioI2tPickupHeadError.AuditSource = "KremerIoField"
        Me.ioI2tPickupHeadError.BackColor = System.Drawing.Color.White
        Me.ioI2tPickupHeadError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ioI2tPickupHeadError.Data = 0.0R
        Me.ioI2tPickupHeadError.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioI2tPickupHeadError.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioI2tPickupHeadError.InitialValue = True
        Me.ioI2tPickupHeadError.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.ioI2tPickupHeadError.Location = New System.Drawing.Point(680, 60)
        Me.ioI2tPickupHeadError.LowerBound = 0.0R
        Me.ioI2tPickupHeadError.Name = "ioI2tPickupHeadError"
        Me.ioI2tPickupHeadError.OutputFormat = "0 '%'"
        Me.ioI2tPickupHeadError.Size = New System.Drawing.Size(100, 22)
        Me.ioI2tPickupHeadError.TabIndex = 431
        Me.ioI2tPickupHeadError.Text = "0 %"
        Me.ioI2tPickupHeadError.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioI2tPickupHeadError.UpperBound = 100.0R
        Me.ioI2tPickupHeadError.UserInfo = Nothing
        Me.ioI2tPickupHeadError.UserLevel = 800
        '
        'ioI2tPickupHeadActValue
        '
        Me.ioI2tPickupHeadActValue.Audit = Nothing
        Me.ioI2tPickupHeadActValue.AuditEnabled = False
        Me.ioI2tPickupHeadActValue.AuditMessage = "KremerIoField changed:"
        Me.ioI2tPickupHeadActValue.AuditSource = "KremerIoField"
        Me.ioI2tPickupHeadActValue.BackColor = System.Drawing.SystemColors.Control
        Me.ioI2tPickupHeadActValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ioI2tPickupHeadActValue.Data = 0.0R
        Me.ioI2tPickupHeadActValue.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioI2tPickupHeadActValue.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioI2tPickupHeadActValue.InitialValue = True
        Me.ioI2tPickupHeadActValue.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioI2tPickupHeadActValue.Location = New System.Drawing.Point(410, 60)
        Me.ioI2tPickupHeadActValue.LowerBound = 0.0R
        Me.ioI2tPickupHeadActValue.Name = "ioI2tPickupHeadActValue"
        Me.ioI2tPickupHeadActValue.OutputFormat = "0.0 '%'"
        Me.ioI2tPickupHeadActValue.Size = New System.Drawing.Size(76, 22)
        Me.ioI2tPickupHeadActValue.TabIndex = 433
        Me.ioI2tPickupHeadActValue.Text = "0.0 %"
        Me.ioI2tPickupHeadActValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioI2tPickupHeadActValue.UpperBound = 100.0R
        Me.ioI2tPickupHeadActValue.UserInfo = Nothing
        Me.ioI2tPickupHeadActValue.UserLevel = 999
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.LineShape11})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 441)
        Me.ShapeContainer1.TabIndex = 355
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 400
        Me.LineShape1.X2 = 400
        Me.LineShape1.Y1 = 34
        Me.LineShape1.Y2 = 330
        '
        'LineShape11
        '
        Me.LineShape11.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape11.Name = "LineShape11"
        Me.LineShape11.X1 = 10
        Me.LineShape11.X2 = 790
        Me.LineShape11.Y1 = 33
        Me.LineShape11.Y2 = 33
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(10, 9)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(349, 23)
        Me.Label19.TabIndex = 366
        Me.Label19.Tag = ""
        Me.Label19.Text = "I2t Settings/Values:"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(10, 39)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(121, 23)
        Me.Label23.TabIndex = 367
        Me.Label23.Tag = ""
        Me.Label23.Text = "Zipper"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(170, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 23)
        Me.Label1.TabIndex = 390
        Me.Label1.Tag = ""
        Me.Label1.Text = "Error:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(170, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 23)
        Me.Label2.TabIndex = 407
        Me.Label2.Tag = ""
        Me.Label2.Text = "Warning:"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(563, 39)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 23)
        Me.Label20.TabIndex = 434
        Me.Label20.Tag = ""
        Me.Label20.Text = "Warning:"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(563, 62)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(94, 23)
        Me.Label21.TabIndex = 432
        Me.Label21.Tag = ""
        Me.Label21.Text = "Error:"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(410, 39)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(147, 23)
        Me.Label22.TabIndex = 429
        Me.Label22.Tag = ""
        Me.Label22.Text = "PickupHead"
        '
        'I2T_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.ioI2tPickupHeadActValue)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.ioI2tPickupHeadError)
        Me.Controls.Add(Me.ioI2tPickupHeadWarning)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ioI2tZipperActValue)
        Me.Controls.Add(Me.ioI2tZipperError)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ioI2tZipperWarning)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "I2T_Settings"
        Me.Size = New System.Drawing.Size(800, 441)
        Me.Tag = "531"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents krConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents krVarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape11 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents ioI2tZipperWarning As KremerControlsWin32.KremerIoField
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ioI2tZipperError As KremerControlsWin32.KremerIoField
    Friend WithEvents ioI2tZipperActValue As KremerControlsWin32.KremerIoField
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ioI2tPickupHeadActValue As KremerControlsWin32.KremerIoField
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ioI2tPickupHeadError As KremerControlsWin32.KremerIoField
    Friend WithEvents ioI2tPickupHeadWarning As KremerControlsWin32.KremerIoField
    Friend WithEvents Label22 As System.Windows.Forms.Label

End Class
