<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CT_Overview_Mirrored
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
        Me.hmiDenesterPresent = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnBundleAutom1 = New System.Windows.Forms.Button
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
        Me.BtnVerticalDenester.Location = New System.Drawing.Point(287, 95)
        Me.BtnVerticalDenester.Name = "BtnVerticalDenester"
        Me.BtnVerticalDenester.Size = New System.Drawing.Size(95, 189)
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
        Me.BtnBufferBundleTrack.Location = New System.Drawing.Point(286, 246)
        Me.BtnBufferBundleTrack.Name = "BtnBufferBundleTrack"
        Me.BtnBufferBundleTrack.Size = New System.Drawing.Size(400, 92)
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
        Me.BtnZipper.Location = New System.Drawing.Point(393, 162)
        Me.BtnZipper.Name = "BtnZipper"
        Me.BtnZipper.Size = New System.Drawing.Size(293, 78)
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
        Me.BtnStacker.Location = New System.Drawing.Point(680, 147)
        Me.BtnStacker.Name = "BtnStacker"
        Me.BtnStacker.Size = New System.Drawing.Size(117, 191)
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
        Me.BtnZipperExtended.Location = New System.Drawing.Point(13, 210)
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
        Me.VarCollector.Variables.Add(Me.hmiDenesterPresent)
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
        'BtnBundleAutom1
        '
        Me.BtnBundleAutom1.BackColor = System.Drawing.Color.Transparent
        Me.BtnBundleAutom1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.BtnBundleAutom1.FlatAppearance.BorderSize = 0
        Me.BtnBundleAutom1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnBundleAutom1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnBundleAutom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBundleAutom1.Location = New System.Drawing.Point(225, 60)
        Me.BtnBundleAutom1.Name = "BtnBundleAutom1"
        Me.BtnBundleAutom1.Size = New System.Drawing.Size(65, 120)
        Me.BtnBundleAutom1.TabIndex = 294
        Me.BtnBundleAutom1.UseVisualStyleBackColor = False
        '
        'CT_Overview_Mirrored
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.BtnBundleAutom1)
        Me.Controls.Add(Me.BtnBundleOutfeed)
        Me.Controls.Add(Me.BtnVerticalDenester)
        Me.Controls.Add(Me.BtnBufferBundleTrack)
        Me.Controls.Add(Me.BtnZipper)
        Me.Controls.Add(Me.BtnStacker)
        Me.Controls.Add(Me.BtnZipperExtended)
        Me.Name = "CT_Overview_Mirrored"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "555"
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
    Friend WithEvents BtnBundleAutom1 As System.Windows.Forms.Button
    Friend WithEvents hmiDenesterPresent As KremerControlsWin32.KremerVariable

End Class
