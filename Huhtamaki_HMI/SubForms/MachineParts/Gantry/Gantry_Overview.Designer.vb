<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gantry_Overview
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
        Me.Btn_Manual = New KremerControlsWin32.KremerButton()
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.mxAutomode = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Vac1En = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Vac2En = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Vac3En = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Vac4En = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Vac5En = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Vac6En = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Vac1Ok = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Vac2Ok = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Vac3Ok = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Vac4Ok = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Vac5Ok = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Vac6Ok = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Image = New System.Windows.Forms.PictureBox()
        CType(Me.Image, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Btn_Settings.Location = New System.Drawing.Point(684, 326)
        Me.Btn_Settings.Name = "Btn_Settings"
        Me.Btn_Settings.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Settings.State = False
        Me.Btn_Settings.StateIsData = True
        Me.Btn_Settings.StateText = New String() {Nothing, Nothing}
        Me.Btn_Settings.TabIndex = 6
        Me.Btn_Settings.Tag = "193"
        Me.Btn_Settings.Text = "Settings"
        Me.Btn_Settings.UserInfo = Nothing
        Me.Btn_Settings.UserLevel = 0
        Me.Btn_Settings.UseStateText = False
        Me.Btn_Settings.UseVisualStyleBackColor = True
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
        Me.Btn_Manual.Location = New System.Drawing.Point(684, 378)
        Me.Btn_Manual.Name = "Btn_Manual"
        Me.Btn_Manual.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Manual.State = False
        Me.Btn_Manual.StateIsData = True
        Me.Btn_Manual.StateText = New String() {Nothing, Nothing}
        Me.Btn_Manual.TabIndex = 5
        Me.Btn_Manual.Tag = "192"
        Me.Btn_Manual.Text = "Manual Control"
        Me.Btn_Manual.UserInfo = Nothing
        Me.Btn_Manual.UserLevel = 0
        Me.Btn_Manual.UseStateText = False
        Me.Btn_Manual.UseVisualStyleBackColor = True
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.mxAutomode)
        Me.VarCollector.Variables.Add(Me.Vac1En)
        Me.VarCollector.Variables.Add(Me.Vac2En)
        Me.VarCollector.Variables.Add(Me.Vac3En)
        Me.VarCollector.Variables.Add(Me.Vac4En)
        Me.VarCollector.Variables.Add(Me.Vac5En)
        Me.VarCollector.Variables.Add(Me.Vac6En)
        Me.VarCollector.Variables.Add(Me.Vac1Ok)
        Me.VarCollector.Variables.Add(Me.Vac2Ok)
        Me.VarCollector.Variables.Add(Me.Vac3Ok)
        Me.VarCollector.Variables.Add(Me.Vac4Ok)
        Me.VarCollector.Variables.Add(Me.Vac5Ok)
        Me.VarCollector.Variables.Add(Me.Vac6Ok)
        '
        'mxAutomode
        '
        Me.mxAutomode.BindControl = Nothing
        Me.mxAutomode.BindProperty = "Data"
        Me.mxAutomode.Data = Nothing
        Me.mxAutomode.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.mxAutomode.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.mxAutomode.VariableName = "Main.mxAutomode"
        '
        'Vac1En
        '
        Me.Vac1En.BindControl = Nothing
        Me.Vac1En.BindProperty = "Data"
        Me.Vac1En.Data = Nothing
        Me.Vac1En.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Vac1En.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Vac1En.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].EnableVacuumSection[1]"
        '
        'Vac2En
        '
        Me.Vac2En.BindControl = Nothing
        Me.Vac2En.BindProperty = "Data"
        Me.Vac2En.Data = Nothing
        Me.Vac2En.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Vac2En.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Vac2En.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].EnableVacuumSection[2]"
        '
        'Vac3En
        '
        Me.Vac3En.BindControl = Nothing
        Me.Vac3En.BindProperty = "Data"
        Me.Vac3En.Data = Nothing
        Me.Vac3En.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Vac3En.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Vac3En.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].EnableVacuumSection[3]"
        '
        'Vac4En
        '
        Me.Vac4En.BindControl = Nothing
        Me.Vac4En.BindProperty = "Data"
        Me.Vac4En.Data = Nothing
        Me.Vac4En.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Vac4En.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Vac4En.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].EnableVacuumSection[4]"
        '
        'Vac5En
        '
        Me.Vac5En.BindControl = Nothing
        Me.Vac5En.BindProperty = "Data"
        Me.Vac5En.Data = Nothing
        Me.Vac5En.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Vac5En.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Vac5En.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].EnableVacuumSection[5]"
        '
        'Vac6En
        '
        Me.Vac6En.BindControl = Nothing
        Me.Vac6En.BindProperty = "Data"
        Me.Vac6En.Data = Nothing
        Me.Vac6En.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Vac6En.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Vac6En.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].EnableVacuumSection[6]"
        '
        'Vac1Ok
        '
        Me.Vac1Ok.BindControl = Nothing
        Me.Vac1Ok.BindProperty = "Data"
        Me.Vac1Ok.Data = Nothing
        Me.Vac1Ok.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Vac1Ok.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Vac1Ok.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].EnableVacuumSection[1]"
        '
        'Vac2Ok
        '
        Me.Vac2Ok.BindControl = Nothing
        Me.Vac2Ok.BindProperty = "Data"
        Me.Vac2Ok.Data = Nothing
        Me.Vac2Ok.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Vac2Ok.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Vac2Ok.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].EnableVacuumSection[1]"
        '
        'Vac3Ok
        '
        Me.Vac3Ok.BindControl = Nothing
        Me.Vac3Ok.BindProperty = "Data"
        Me.Vac3Ok.Data = Nothing
        Me.Vac3Ok.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Vac3Ok.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Vac3Ok.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].EnableVacuumSection[1]"
        '
        'Vac4Ok
        '
        Me.Vac4Ok.BindControl = Nothing
        Me.Vac4Ok.BindProperty = "Data"
        Me.Vac4Ok.Data = Nothing
        Me.Vac4Ok.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Vac4Ok.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Vac4Ok.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].EnableVacuumSection[1]"
        '
        'Vac5Ok
        '
        Me.Vac5Ok.BindControl = Nothing
        Me.Vac5Ok.BindProperty = "Data"
        Me.Vac5Ok.Data = Nothing
        Me.Vac5Ok.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Vac5Ok.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Vac5Ok.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].EnableVacuumSection[1]"
        '
        'Vac6Ok
        '
        Me.Vac6Ok.BindControl = Nothing
        Me.Vac6Ok.BindProperty = "Data"
        Me.Vac6Ok.Data = Nothing
        Me.Vac6Ok.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Vac6Ok.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Vac6Ok.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].EnableVacuumSection[1]"
        '
        'Image
        '
        Me.Image.Image = Global.InMoldDrying.My.Resources.Resources.Gantry___B_side_side
        Me.Image.Location = New System.Drawing.Point(234, 73)
        Me.Image.Name = "Image"
        Me.Image.Size = New System.Drawing.Size(300, 248)
        Me.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Image.TabIndex = 278
        Me.Image.TabStop = False
        '
        'Gantry_Overview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Image)
        Me.Controls.Add(Me.Btn_Settings)
        Me.Controls.Add(Me.Btn_Manual)
        Me.Name = "Gantry_Overview"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "101"
        CType(Me.Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Settings As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_Manual As KremerControlsWin32.KremerButton
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents mxAutomode As KremerControlsWin32.KremerVariable
    Friend WithEvents Vac1En As KremerControlsWin32.KremerVariable
    Friend WithEvents Vac2En As KremerControlsWin32.KremerVariable
    Friend WithEvents Vac3En As KremerControlsWin32.KremerVariable
    Friend WithEvents Vac4En As KremerControlsWin32.KremerVariable
    Friend WithEvents Vac5En As KremerControlsWin32.KremerVariable
    Friend WithEvents Vac6En As KremerControlsWin32.KremerVariable
    Friend WithEvents Vac1Ok As KremerControlsWin32.KremerVariable
    Friend WithEvents Vac2Ok As KremerControlsWin32.KremerVariable
    Friend WithEvents Vac3Ok As KremerControlsWin32.KremerVariable
    Friend WithEvents Vac4Ok As KremerControlsWin32.KremerVariable
    Friend WithEvents Vac5Ok As KremerControlsWin32.KremerVariable
    Friend WithEvents Vac6Ok As KremerControlsWin32.KremerVariable
    Friend WithEvents Image As System.Windows.Forms.PictureBox

End Class
