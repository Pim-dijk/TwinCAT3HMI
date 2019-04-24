<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Spraybar_Manual
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
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Lbl_Valves = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.WireOn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnWireOn = New KremerControlsWin32.KremerButton()
        Me.FlashOn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnFlashOn = New KremerControlsWin32.KremerButton()
        Me.Fwd = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnFwd = New KremerControlsWin32.KremerButton()
        Me.Bwd = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnBwd = New KremerControlsWin32.KremerButton()
        Me.BarPos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_BarPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Btn_Settings = New KremerControlsWin32.KremerButton()
        Me.Btn_Overview = New KremerControlsWin32.KremerButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 21
        Me.LineShape4.X2 = 371
        Me.LineShape4.Y1 = 28
        Me.LineShape4.Y2 = 28
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.LineShape4})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 435)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 22
        Me.LineShape1.X2 = 372
        Me.LineShape1.Y1 = 164
        Me.LineShape1.Y2 = 164
        '
        'Lbl_Valves
        '
        Me.Lbl_Valves.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Valves.Location = New System.Drawing.Point(20, 2)
        Me.Lbl_Valves.Name = "Lbl_Valves"
        Me.Lbl_Valves.Size = New System.Drawing.Size(275, 23)
        Me.Lbl_Valves.TabIndex = 205
        Me.Lbl_Valves.Tag = ""
        Me.Lbl_Valves.Text = "Valves"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 23)
        Me.Label1.TabIndex = 206
        Me.Label1.Tag = ""
        Me.Label1.Text = "Wire spray valve"
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Me.VarCollector
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.WireOn)
        Me.VarCollector.Variables.Add(Me.FlashOn)
        Me.VarCollector.Variables.Add(Me.Fwd)
        Me.VarCollector.Variables.Add(Me.Bwd)
        Me.VarCollector.Variables.Add(Me.BarPos)
        '
        'WireOn
        '
        Me.WireOn.BindControl = Me.BtnWireOn
        Me.WireOn.BindProperty = "Data"
        Me.WireOn.Data = Nothing
        Me.WireOn.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.WireOn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.WireOn.VariableName = "MAIN.InMoldDrying.ProductForming.WireSprayValve.mxHMI_On"
        '
        'BtnWireOn
        '
        Me.BtnWireOn.Audit = Nothing
        Me.BtnWireOn.AuditEnabled = False
        Me.BtnWireOn.AuditMessage = "KremerPushButton pressed!"
        Me.BtnWireOn.AuditSource = "KremerPushButton"
        Me.BtnWireOn.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnWireOn.BackGroundImageOn = Nothing
        Me.BtnWireOn.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.BtnWireOn.Data = False
        Me.BtnWireOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnWireOn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnWireOn.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnWireOn.Location = New System.Drawing.Point(266, 33)
        Me.BtnWireOn.Name = "BtnWireOn"
        Me.BtnWireOn.Size = New System.Drawing.Size(106, 36)
        Me.BtnWireOn.State = False
        Me.BtnWireOn.StateIsData = True
        Me.BtnWireOn.StateText = New String() {Nothing, Nothing}
        Me.BtnWireOn.TabIndex = 289
        Me.BtnWireOn.Tag = "26"
        Me.BtnWireOn.Text = "On"
        Me.BtnWireOn.UserInfo = Nothing
        Me.BtnWireOn.UserLevel = 0
        Me.BtnWireOn.UseStateText = False
        '
        'FlashOn
        '
        Me.FlashOn.BindControl = Me.BtnFlashOn
        Me.FlashOn.BindProperty = "Data"
        Me.FlashOn.Data = Nothing
        Me.FlashOn.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.FlashOn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FlashOn.VariableName = "MAIN.InMoldDrying.ProductForming.FlashSprayValve.mxHMI_On"
        '
        'BtnFlashOn
        '
        Me.BtnFlashOn.Audit = Nothing
        Me.BtnFlashOn.AuditEnabled = False
        Me.BtnFlashOn.AuditMessage = "KremerPushButton pressed!"
        Me.BtnFlashOn.AuditSource = "KremerPushButton"
        Me.BtnFlashOn.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnFlashOn.BackGroundImageOn = Nothing
        Me.BtnFlashOn.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.BtnFlashOn.Data = False
        Me.BtnFlashOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFlashOn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnFlashOn.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnFlashOn.Location = New System.Drawing.Point(266, 75)
        Me.BtnFlashOn.Name = "BtnFlashOn"
        Me.BtnFlashOn.Size = New System.Drawing.Size(106, 36)
        Me.BtnFlashOn.State = False
        Me.BtnFlashOn.StateIsData = True
        Me.BtnFlashOn.StateText = New String() {Nothing, Nothing}
        Me.BtnFlashOn.TabIndex = 291
        Me.BtnFlashOn.Tag = "26"
        Me.BtnFlashOn.Text = "On"
        Me.BtnFlashOn.UserInfo = Nothing
        Me.BtnFlashOn.UserLevel = 0
        Me.BtnFlashOn.UseStateText = False
        '
        'Fwd
        '
        Me.Fwd.BindControl = Me.BtnFwd
        Me.Fwd.BindProperty = "Data"
        Me.Fwd.Data = Nothing
        Me.Fwd.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Fwd.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Fwd.VariableName = "MAIN.InMoldDrying.ProductForming.SprayBarMotor.HMI_Forward"
        '
        'BtnFwd
        '
        Me.BtnFwd.Audit = Nothing
        Me.BtnFwd.AuditEnabled = False
        Me.BtnFwd.AuditMessage = "KremerPushButton pressed!"
        Me.BtnFwd.AuditSource = "KremerPushButton"
        Me.BtnFwd.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnFwd.BackGroundImageOn = Nothing
        Me.BtnFwd.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnFwd.Data = False
        Me.BtnFwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFwd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnFwd.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnFwd.Location = New System.Drawing.Point(151, 170)
        Me.BtnFwd.Name = "BtnFwd"
        Me.BtnFwd.Size = New System.Drawing.Size(106, 36)
        Me.BtnFwd.State = False
        Me.BtnFwd.StateIsData = True
        Me.BtnFwd.StateText = New String() {Nothing, Nothing}
        Me.BtnFwd.TabIndex = 296
        Me.BtnFwd.Tag = ""
        Me.BtnFwd.Text = "Forward"
        Me.BtnFwd.UserInfo = Nothing
        Me.BtnFwd.UserLevel = 0
        Me.BtnFwd.UseStateText = False
        '
        'Bwd
        '
        Me.Bwd.BindControl = Me.BtnBwd
        Me.Bwd.BindProperty = "Data"
        Me.Bwd.Data = Nothing
        Me.Bwd.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Bwd.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Bwd.VariableName = "MAIN.InMoldDrying.ProductForming.SprayBarMotor.HMI_Backward"
        '
        'BtnBwd
        '
        Me.BtnBwd.Audit = Nothing
        Me.BtnBwd.AuditEnabled = False
        Me.BtnBwd.AuditMessage = "KremerPushButton pressed!"
        Me.BtnBwd.AuditSource = "KremerPushButton"
        Me.BtnBwd.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnBwd.BackGroundImageOn = Nothing
        Me.BtnBwd.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnBwd.Data = False
        Me.BtnBwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBwd.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBwd.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnBwd.Location = New System.Drawing.Point(263, 170)
        Me.BtnBwd.Name = "BtnBwd"
        Me.BtnBwd.Size = New System.Drawing.Size(106, 36)
        Me.BtnBwd.State = False
        Me.BtnBwd.StateIsData = True
        Me.BtnBwd.StateText = New String() {Nothing, Nothing}
        Me.BtnBwd.TabIndex = 294
        Me.BtnBwd.Tag = ""
        Me.BtnBwd.Text = "Backward"
        Me.BtnBwd.UserInfo = Nothing
        Me.BtnBwd.UserLevel = 0
        Me.BtnBwd.UseStateText = False
        '
        'BarPos
        '
        Me.BarPos.BindControl = Me.IO_BarPos
        Me.BarPos.BindProperty = "Data"
        Me.BarPos.Data = Nothing
        Me.BarPos.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.BarPos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BarPos.VariableName = "MAIN.InMoldDrying.ProductForming.SprayBarMotor.ActPosition"
        '
        'IO_BarPos
        '
        Me.IO_BarPos.Audit = Nothing
        Me.IO_BarPos.AuditEnabled = False
        Me.IO_BarPos.AuditMessage = "KremerIoField changed:"
        Me.IO_BarPos.AuditSource = "KremerIoField"
        Me.IO_BarPos.Data = 0.0R
        Me.IO_BarPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_BarPos.InitialValue = True
        Me.IO_BarPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_BarPos.Location = New System.Drawing.Point(302, 144)
        Me.IO_BarPos.LowerBound = 0.0R
        Me.IO_BarPos.Name = "IO_BarPos"
        Me.IO_BarPos.OutputFormat = "0.0 mm"
        Me.IO_BarPos.Size = New System.Drawing.Size(71, 18)
        Me.IO_BarPos.TabIndex = 284
        Me.IO_BarPos.Text = "0,0 mm"
        Me.IO_BarPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IO_BarPos.UpperBound = 1000.0R
        Me.IO_BarPos.UserInfo = Nothing
        Me.IO_BarPos.UserLevel = 0
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
        Me.Btn_Settings.Data = False
        Me.Btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Settings.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Settings.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_Settings.Location = New System.Drawing.Point(685, 326)
        Me.Btn_Settings.Name = "Btn_Settings"
        Me.Btn_Settings.Size = New System.Drawing.Size(114, 50)
        Me.Btn_Settings.State = False
        Me.Btn_Settings.StateIsData = True
        Me.Btn_Settings.StateText = New String() {Nothing, Nothing}
        Me.Btn_Settings.TabIndex = 271
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
        Me.Btn_Overview.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Overview.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_Overview.Location = New System.Drawing.Point(685, 382)
        Me.Btn_Overview.Name = "Btn_Overview"
        Me.Btn_Overview.Size = New System.Drawing.Size(114, 50)
        Me.Btn_Overview.State = False
        Me.Btn_Overview.StateIsData = True
        Me.Btn_Overview.StateText = New String() {Nothing, Nothing}
        Me.Btn_Overview.TabIndex = 270
        Me.Btn_Overview.Tag = "194"
        Me.Btn_Overview.Text = "Overview"
        Me.Btn_Overview.UserInfo = Nothing
        Me.Btn_Overview.UserLevel = 0
        Me.Btn_Overview.UseStateText = False
        Me.Btn_Overview.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 23)
        Me.Label2.TabIndex = 290
        Me.Label2.Tag = ""
        Me.Label2.Text = "Flash spray valve"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(17, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(275, 23)
        Me.Label5.TabIndex = 292
        Me.Label5.Tag = ""
        Me.Label5.Text = "Bar Movement"
        '
        'Spraybar_Manual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnFwd)
        Me.Controls.Add(Me.BtnBwd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnFlashOn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnWireOn)
        Me.Controls.Add(Me.IO_BarPos)
        Me.Controls.Add(Me.Btn_Settings)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl_Valves)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Spraybar_Manual"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "89"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Lbl_Valves As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents Btn_Settings As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents IO_BarPos As KremerControlsWin32.KremerIoField
    Friend WithEvents BtnWireOn As KremerControlsWin32.KremerButton
    Friend WithEvents BtnFlashOn As KremerControlsWin32.KremerButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents WireOn As KremerControlsWin32.KremerVariable
    Friend WithEvents FlashOn As KremerControlsWin32.KremerVariable
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents BtnFwd As KremerControlsWin32.KremerButton
    Friend WithEvents BtnBwd As KremerControlsWin32.KremerButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Fwd As KremerControlsWin32.KremerVariable
    Friend WithEvents Bwd As KremerControlsWin32.KremerVariable
    Friend WithEvents BarPos As KremerControlsWin32.KremerVariable

End Class
