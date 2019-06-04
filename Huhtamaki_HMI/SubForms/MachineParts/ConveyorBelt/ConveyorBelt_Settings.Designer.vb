<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConveyorBelt_Settings
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Btn_Overview = New KremerControlsWin32.KremerButton()
        Me.Btn_Manual = New KremerControlsWin32.KremerButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape10 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.mxAutoMode = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ConManVelo = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_ConManVelo = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ConAutoVelo = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_ConAutoVelo = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        Me.Btn_Overview.Location = New System.Drawing.Point(684, 326)
        Me.Btn_Overview.Name = "Btn_Overview"
        Me.Btn_Overview.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Overview.State = False
        Me.Btn_Overview.StateIsData = True
        Me.Btn_Overview.StateText = New String() {Nothing, Nothing}
        Me.Btn_Overview.TabIndex = 8
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
        Me.Btn_Manual.Location = New System.Drawing.Point(684, 382)
        Me.Btn_Manual.Name = "Btn_Manual"
        Me.Btn_Manual.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Manual.State = False
        Me.Btn_Manual.StateIsData = True
        Me.Btn_Manual.StateText = New String() {Nothing, Nothing}
        Me.Btn_Manual.TabIndex = 7
        Me.Btn_Manual.Tag = "192"
        Me.Btn_Manual.Text = "Manual Control"
        Me.Btn_Manual.UserInfo = Nothing
        Me.Btn_Manual.UserLevel = 0
        Me.Btn_Manual.UseStateText = False
        Me.Btn_Manual.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape10, Me.LineShape9})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 435)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape10
        '
        Me.LineShape10.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape10.Name = "LineShape10"
        Me.LineShape10.X1 = 23
        Me.LineShape10.X2 = 373
        Me.LineShape10.Y1 = 36
        Me.LineShape10.Y2 = 36
        '
        'LineShape9
        '
        Me.LineShape9.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape9.Name = "LineShape9"
        Me.LineShape9.X1 = 268
        Me.LineShape9.X2 = 268
        Me.LineShape9.Y1 = 36
        Me.LineShape9.Y2 = 90
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.mxAutoMode)
        Me.VarCollector.Variables.Add(Me.ConManVelo)
        Me.VarCollector.Variables.Add(Me.ConAutoVelo)
        '
        'mxAutoMode
        '
        Me.mxAutoMode.BindControl = Nothing
        Me.mxAutoMode.BindProperty = "Data"
        Me.mxAutoMode.Data = Nothing
        Me.mxAutoMode.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.mxAutoMode.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.mxAutoMode.VariableName = "Main.mxAutomode"
        '
        'ConManVelo
        '
        Me.ConManVelo.BindControl = Me.IO_ConManVelo
        Me.ConManVelo.BindProperty = "Data"
        Me.ConManVelo.Data = Nothing
        Me.ConManVelo.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.ConManVelo.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ConManVelo.VariableName = "MAIN.ProductHandling.OutfeedConveyor.MachParameters.VelocityManual"
        '
        'IO_ConManVelo
        '
        Me.IO_ConManVelo.Audit = Nothing
        Me.IO_ConManVelo.AuditEnabled = False
        Me.IO_ConManVelo.AuditMessage = "KremerIoField changed:"
        Me.IO_ConManVelo.AuditSource = "KremerIoField"
        Me.IO_ConManVelo.BackColor = System.Drawing.Color.White
        Me.IO_ConManVelo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_ConManVelo.Data = 0R
        Me.IO_ConManVelo.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_ConManVelo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_ConManVelo.InitialValue = True
        Me.IO_ConManVelo.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_ConManVelo.Location = New System.Drawing.Point(272, 39)
        Me.IO_ConManVelo.LowerBound = -5000.0R
        Me.IO_ConManVelo.Name = "IO_ConManVelo"
        Me.IO_ConManVelo.OutputFormat = "0.0 mm/s"
        Me.IO_ConManVelo.Size = New System.Drawing.Size(100, 22)
        Me.IO_ConManVelo.TabIndex = 397
        Me.IO_ConManVelo.Text = "0.0 mm/s"
        Me.IO_ConManVelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_ConManVelo.UpperBound = 5000.0R
        Me.IO_ConManVelo.UserInfo = Nothing
        Me.IO_ConManVelo.UserLevel = 0
        '
        'ConAutoVelo
        '
        Me.ConAutoVelo.BindControl = Me.IO_ConAutoVelo
        Me.ConAutoVelo.BindProperty = "Data"
        Me.ConAutoVelo.Data = Nothing
        Me.ConAutoVelo.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.ConAutoVelo.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ConAutoVelo.VariableName = "MAIN.ProductHandling.OutfeedConveyor.MachParameters.VelocityAuto"
        '
        'IO_ConAutoVelo
        '
        Me.IO_ConAutoVelo.Audit = Nothing
        Me.IO_ConAutoVelo.AuditEnabled = False
        Me.IO_ConAutoVelo.AuditMessage = "KremerIoField changed:"
        Me.IO_ConAutoVelo.AuditSource = "KremerIoField"
        Me.IO_ConAutoVelo.BackColor = System.Drawing.Color.White
        Me.IO_ConAutoVelo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_ConAutoVelo.Data = 0R
        Me.IO_ConAutoVelo.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_ConAutoVelo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_ConAutoVelo.InitialValue = True
        Me.IO_ConAutoVelo.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_ConAutoVelo.Location = New System.Drawing.Point(272, 62)
        Me.IO_ConAutoVelo.LowerBound = -5000.0R
        Me.IO_ConAutoVelo.Name = "IO_ConAutoVelo"
        Me.IO_ConAutoVelo.OutputFormat = "0.0 mm/s"
        Me.IO_ConAutoVelo.Size = New System.Drawing.Size(100, 22)
        Me.IO_ConAutoVelo.TabIndex = 399
        Me.IO_ConAutoVelo.Text = "0.0 mm/s"
        Me.IO_ConAutoVelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_ConAutoVelo.UpperBound = 5000.0R
        Me.IO_ConAutoVelo.UserInfo = Nothing
        Me.IO_ConAutoVelo.UserLevel = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(19, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 23)
        Me.Label2.TabIndex = 372
        Me.Label2.Tag = "117"
        Me.Label2.Text = "Conveyor belt settings"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(19, 62)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(247, 23)
        Me.Label17.TabIndex = 398
        Me.Label17.Tag = "108"
        Me.Label17.Text = "Automatic velocity"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 23)
        Me.Label1.TabIndex = 396
        Me.Label1.Tag = "107"
        Me.Label1.Text = "Manual velocity"
        '
        'ConveyorBelt_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.IO_ConAutoVelo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.IO_ConManVelo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Controls.Add(Me.Btn_Manual)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "ConveyorBelt_Settings"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "117"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_Manual As KremerControlsWin32.KremerButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents LineShape10 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape9 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ConManVelo As KremerControlsWin32.KremerVariable
    Friend WithEvents ConAutoVelo As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_ConAutoVelo As KremerControlsWin32.KremerIoField
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents IO_ConManVelo As KremerControlsWin32.KremerIoField
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mxAutoMode As KremerControlsWin32.KremerVariable
End Class
