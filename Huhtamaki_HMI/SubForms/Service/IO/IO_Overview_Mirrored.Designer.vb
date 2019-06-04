<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IO_Overview_Mirrored
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
        Me.BtnVerticalDenester = New System.Windows.Forms.Button
        Me.BtnBufferBundleTrack = New System.Windows.Forms.Button
        Me.BtnZipper = New System.Windows.Forms.Button
        Me.BtnBundleOutfeed = New System.Windows.Forms.Button
        Me.BtnStacker = New System.Windows.Forms.Button
        Me.BtnZipperExtended = New System.Windows.Forms.Button
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.ixAirSupply_OK = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plAir = New KremerControlsWin32.KremerLight
        Me.ixVacuum_OK = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plVacuum = New KremerControlsWin32.KremerLight
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.BtnBundleAutom1 = New System.Windows.Forms.Button
        Me.hmiDenesterPresent = New KremerControlsWin32.KremerVariable(Me.components)
        Me.SuspendLayout()
        '
        'BtnVerticalDenester
        '
        Me.BtnVerticalDenester.BackColor = System.Drawing.Color.Transparent
        Me.BtnVerticalDenester.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnVerticalDenester.FlatAppearance.BorderSize = 0
        Me.BtnVerticalDenester.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnVerticalDenester.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnVerticalDenester.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVerticalDenester.Location = New System.Drawing.Point(289, 95)
        Me.BtnVerticalDenester.Name = "BtnVerticalDenester"
        Me.BtnVerticalDenester.Size = New System.Drawing.Size(103, 188)
        Me.BtnVerticalDenester.TabIndex = 2
        Me.BtnVerticalDenester.UseVisualStyleBackColor = False
        '
        'BtnBufferBundleTrack
        '
        Me.BtnBufferBundleTrack.BackColor = System.Drawing.Color.Transparent
        Me.BtnBufferBundleTrack.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnBufferBundleTrack.FlatAppearance.BorderSize = 0
        Me.BtnBufferBundleTrack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnBufferBundleTrack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnBufferBundleTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBufferBundleTrack.Location = New System.Drawing.Point(287, 247)
        Me.BtnBufferBundleTrack.Name = "BtnBufferBundleTrack"
        Me.BtnBufferBundleTrack.Size = New System.Drawing.Size(400, 91)
        Me.BtnBufferBundleTrack.TabIndex = 1
        Me.BtnBufferBundleTrack.UseVisualStyleBackColor = False
        '
        'BtnZipper
        '
        Me.BtnZipper.BackColor = System.Drawing.Color.Transparent
        Me.BtnZipper.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnZipper.FlatAppearance.BorderSize = 0
        Me.BtnZipper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnZipper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnZipper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnZipper.Location = New System.Drawing.Point(394, 162)
        Me.BtnZipper.Name = "BtnZipper"
        Me.BtnZipper.Size = New System.Drawing.Size(293, 80)
        Me.BtnZipper.TabIndex = 0
        Me.BtnZipper.UseVisualStyleBackColor = False
        '
        'BtnBundleOutfeed
        '
        Me.BtnBundleOutfeed.BackColor = System.Drawing.Color.Transparent
        Me.BtnBundleOutfeed.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnBundleOutfeed.FlatAppearance.BorderSize = 0
        Me.BtnBundleOutfeed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnBundleOutfeed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnBundleOutfeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBundleOutfeed.Location = New System.Drawing.Point(180, 182)
        Me.BtnBundleOutfeed.Name = "BtnBundleOutfeed"
        Me.BtnBundleOutfeed.Size = New System.Drawing.Size(90, 155)
        Me.BtnBundleOutfeed.TabIndex = 3
        Me.BtnBundleOutfeed.UseVisualStyleBackColor = False
        '
        'BtnStacker
        '
        Me.BtnStacker.BackColor = System.Drawing.Color.Transparent
        Me.BtnStacker.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnStacker.FlatAppearance.BorderSize = 0
        Me.BtnStacker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnStacker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnStacker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStacker.Location = New System.Drawing.Point(683, 149)
        Me.BtnStacker.Name = "BtnStacker"
        Me.BtnStacker.Size = New System.Drawing.Size(113, 188)
        Me.BtnStacker.TabIndex = 4
        Me.BtnStacker.UseVisualStyleBackColor = False
        '
        'BtnZipperExtended
        '
        Me.BtnZipperExtended.BackColor = System.Drawing.Color.Transparent
        Me.BtnZipperExtended.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnZipperExtended.FlatAppearance.BorderSize = 0
        Me.BtnZipperExtended.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnZipperExtended.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnZipperExtended.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnZipperExtended.Location = New System.Drawing.Point(13, 212)
        Me.BtnZipperExtended.Name = "BtnZipperExtended"
        Me.BtnZipperExtended.Size = New System.Drawing.Size(163, 59)
        Me.BtnZipperExtended.TabIndex = 289
        Me.BtnZipperExtended.UseVisualStyleBackColor = False
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.ixAirSupply_OK)
        Me.VarCollector.Variables.Add(Me.ixVacuum_OK)
        Me.VarCollector.Variables.Add(Me.hmiDenesterPresent)
        '
        'ixAirSupply_OK
        '
        Me.ixAirSupply_OK.BindControl = Me.plAir
        Me.ixAirSupply_OK.BindProperty = "Data"
        Me.ixAirSupply_OK.Data = Nothing
        Me.ixAirSupply_OK.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ixAirSupply_OK.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ixAirSupply_OK.VariableName = "InlineAutomation.ixAirSupply_OK"
        '
        'plAir
        '
        Me.plAir.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plAir.ColorOn = System.Drawing.Color.Lime
        Me.plAir.Data = False
        Me.plAir.Line = True
        Me.plAir.LineSize = 1
        Me.plAir.Location = New System.Drawing.Point(558, 25)
        Me.plAir.Name = "plAir"
        Me.plAir.Size = New System.Drawing.Size(24, 24)
        Me.plAir.TabIndex = 290
        Me.plAir.Text = "KremerLight1"
        Me.plAir.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'ixVacuum_OK
        '
        Me.ixVacuum_OK.BindControl = Me.plVacuum
        Me.ixVacuum_OK.BindProperty = "Data"
        Me.ixVacuum_OK.Data = Nothing
        Me.ixVacuum_OK.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ixVacuum_OK.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ixVacuum_OK.VariableName = "InlineAutomation.ixVacuum_OK"
        '
        'plVacuum
        '
        Me.plVacuum.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plVacuum.ColorOn = System.Drawing.Color.Lime
        Me.plVacuum.Data = False
        Me.plVacuum.Line = True
        Me.plVacuum.LineSize = 1
        Me.plVacuum.Location = New System.Drawing.Point(558, 50)
        Me.plVacuum.Name = "plVacuum"
        Me.plVacuum.Size = New System.Drawing.Size(24, 24)
        Me.plVacuum.TabIndex = 292
        Me.plVacuum.Text = "KremerLight1"
        Me.plVacuum.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(589, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 25)
        Me.Label1.TabIndex = 293
        Me.Label1.Tag = ""
        Me.Label1.Text = "Vacuum Ok"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(589, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 25)
        Me.Label5.TabIndex = 291
        Me.Label5.Tag = ""
        Me.Label5.Text = "Air Supply Ok"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnBundleAutom1
        '
        Me.BtnBundleAutom1.BackColor = System.Drawing.Color.Transparent
        Me.BtnBundleAutom1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnBundleAutom1.FlatAppearance.BorderSize = 0
        Me.BtnBundleAutom1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnBundleAutom1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnBundleAutom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBundleAutom1.Location = New System.Drawing.Point(224, 64)
        Me.BtnBundleAutom1.Name = "BtnBundleAutom1"
        Me.BtnBundleAutom1.Size = New System.Drawing.Size(68, 116)
        Me.BtnBundleAutom1.TabIndex = 294
        Me.BtnBundleAutom1.UseVisualStyleBackColor = False
        '
        'hmiDenesterPresent
        '
        Me.hmiDenesterPresent.BindControl = Nothing
        Me.hmiDenesterPresent.BindProperty = "Data"
        Me.hmiDenesterPresent.Data = Nothing
        Me.hmiDenesterPresent.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.hmiDenesterPresent.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.hmiDenesterPresent.VariableName = "InlineAutomation.MachPar.DenesterPresent"
        '
        'IO_Overview_Mirrored
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.BtnBundleAutom1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.plVacuum)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.plAir)
        Me.Controls.Add(Me.BtnBundleOutfeed)
        Me.Controls.Add(Me.BtnVerticalDenester)
        Me.Controls.Add(Me.BtnBufferBundleTrack)
        Me.Controls.Add(Me.BtnZipper)
        Me.Controls.Add(Me.BtnStacker)
        Me.Controls.Add(Me.BtnZipperExtended)
        Me.Name = "IO_Overview_Mirrored"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "540"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnBufferBundleTrack As System.Windows.Forms.Button
    Friend WithEvents BtnZipper As System.Windows.Forms.Button
    Friend WithEvents BtnVerticalDenester As System.Windows.Forms.Button
    Friend WithEvents BtnBundleOutfeed As System.Windows.Forms.Button
    Friend WithEvents BtnStacker As System.Windows.Forms.Button
    Friend WithEvents BtnZipperExtended As System.Windows.Forms.Button
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents plVacuum As KremerControlsWin32.KremerLight
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents plAir As KremerControlsWin32.KremerLight
    Friend WithEvents ixAirSupply_OK As KremerControlsWin32.KremerVariable
    Friend WithEvents ixVacuum_OK As KremerControlsWin32.KremerVariable
    Friend WithEvents BtnBundleAutom1 As System.Windows.Forms.Button
    Friend WithEvents hmiDenesterPresent As KremerControlsWin32.KremerVariable

End Class
