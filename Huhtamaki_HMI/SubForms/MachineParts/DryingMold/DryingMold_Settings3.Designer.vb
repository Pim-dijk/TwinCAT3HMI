<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DryingMoldSettings3
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
        Me.mxAutomode = New KremerControlsWin32.KremerVariable(Me.components)
        Me.FlowIn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_FlowIn = New KremerControlsWin32.KremerIoField(Me.components)
        Me.FlowInSlow = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_FlowInSlow = New KremerControlsWin32.KremerIoField(Me.components)
        Me.FlowOut = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_FlowOut = New KremerControlsWin32.KremerIoField(Me.components)
        Me.FlowOutSlow = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_FlowOutSlow = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Btn_Overview = New KremerControlsWin32.KremerButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Settings = New System.Windows.Forms.Button()
        Me.Btn_Settings2 = New System.Windows.Forms.Button()
        Me.Btn_Manual = New KremerControlsWin32.KremerButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Me.VarCollector
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.mxAutomode)
        Me.VarCollector.Variables.Add(Me.FlowIn)
        Me.VarCollector.Variables.Add(Me.FlowInSlow)
        Me.VarCollector.Variables.Add(Me.FlowOut)
        Me.VarCollector.Variables.Add(Me.FlowOutSlow)
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
        'FlowIn
        '
        Me.FlowIn.BindControl = Me.IO_FlowIn
        Me.FlowIn.BindProperty = "Data"
        Me.FlowIn.Data = Nothing
        Me.FlowIn.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.FlowIn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FlowIn.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].PressFlowRampTimeIn.Flow"
        '
        'IO_FlowIn
        '
        Me.IO_FlowIn.Audit = Nothing
        Me.IO_FlowIn.AuditEnabled = False
        Me.IO_FlowIn.AuditMessage = "KremerIoField changed:"
        Me.IO_FlowIn.AuditSource = "KremerIoField"
        Me.IO_FlowIn.BackColor = System.Drawing.Color.White
        Me.IO_FlowIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_FlowIn.Data = 0.0R
        Me.IO_FlowIn.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_FlowIn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_FlowIn.InitialValue = True
        Me.IO_FlowIn.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_FlowIn.Location = New System.Drawing.Point(278, 37)
        Me.IO_FlowIn.LowerBound = -10000.0R
        Me.IO_FlowIn.Name = "IO_FlowIn"
        Me.IO_FlowIn.OutputFormat = "0.0 '%'"
        Me.IO_FlowIn.Size = New System.Drawing.Size(100, 22)
        Me.IO_FlowIn.TabIndex = 406
        Me.IO_FlowIn.Text = "0.0 %"
        Me.IO_FlowIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_FlowIn.UpperBound = 10000.0R
        Me.IO_FlowIn.UserInfo = Nothing
        Me.IO_FlowIn.UserLevel = 0
        '
        'FlowInSlow
        '
        Me.FlowInSlow.BindControl = Me.IO_FlowInSlow
        Me.FlowInSlow.BindProperty = "Data"
        Me.FlowInSlow.Data = Nothing
        Me.FlowInSlow.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.FlowInSlow.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FlowInSlow.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].PressFlowRampTimeInSlow.Flow"
        '
        'IO_FlowInSlow
        '
        Me.IO_FlowInSlow.Audit = Nothing
        Me.IO_FlowInSlow.AuditEnabled = False
        Me.IO_FlowInSlow.AuditMessage = "KremerIoField changed:"
        Me.IO_FlowInSlow.AuditSource = "KremerIoField"
        Me.IO_FlowInSlow.BackColor = System.Drawing.Color.White
        Me.IO_FlowInSlow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_FlowInSlow.Data = 0.0R
        Me.IO_FlowInSlow.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_FlowInSlow.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_FlowInSlow.InitialValue = True
        Me.IO_FlowInSlow.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_FlowInSlow.Location = New System.Drawing.Point(278, 60)
        Me.IO_FlowInSlow.LowerBound = -10000.0R
        Me.IO_FlowInSlow.Name = "IO_FlowInSlow"
        Me.IO_FlowInSlow.OutputFormat = "0.0 '%'"
        Me.IO_FlowInSlow.Size = New System.Drawing.Size(100, 22)
        Me.IO_FlowInSlow.TabIndex = 407
        Me.IO_FlowInSlow.Text = "0.0 %"
        Me.IO_FlowInSlow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_FlowInSlow.UpperBound = 10000.0R
        Me.IO_FlowInSlow.UserInfo = Nothing
        Me.IO_FlowInSlow.UserLevel = 0
        '
        'FlowOut
        '
        Me.FlowOut.BindControl = Me.IO_FlowOut
        Me.FlowOut.BindProperty = "Data"
        Me.FlowOut.Data = Nothing
        Me.FlowOut.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.FlowOut.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FlowOut.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].PressFlowRampTimeOut.Flow"
        '
        'IO_FlowOut
        '
        Me.IO_FlowOut.Audit = Nothing
        Me.IO_FlowOut.AuditEnabled = False
        Me.IO_FlowOut.AuditMessage = "KremerIoField changed:"
        Me.IO_FlowOut.AuditSource = "KremerIoField"
        Me.IO_FlowOut.BackColor = System.Drawing.Color.White
        Me.IO_FlowOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_FlowOut.Data = 0.0R
        Me.IO_FlowOut.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_FlowOut.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_FlowOut.InitialValue = True
        Me.IO_FlowOut.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_FlowOut.Location = New System.Drawing.Point(278, 83)
        Me.IO_FlowOut.LowerBound = -10000.0R
        Me.IO_FlowOut.Name = "IO_FlowOut"
        Me.IO_FlowOut.OutputFormat = "0.0 '%'"
        Me.IO_FlowOut.Size = New System.Drawing.Size(100, 22)
        Me.IO_FlowOut.TabIndex = 408
        Me.IO_FlowOut.Text = "0.0 %"
        Me.IO_FlowOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_FlowOut.UpperBound = 10000.0R
        Me.IO_FlowOut.UserInfo = Nothing
        Me.IO_FlowOut.UserLevel = 0
        '
        'FlowOutSlow
        '
        Me.FlowOutSlow.BindControl = Me.IO_FlowOutSlow
        Me.FlowOutSlow.BindProperty = "Data"
        Me.FlowOutSlow.Data = Nothing
        Me.FlowOutSlow.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.FlowOutSlow.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FlowOutSlow.VariableName = "MAIN.InMoldDrying.MachParameters.Bottom[Position1].PressFlowRampTimeOutSlow.Flow"
        '
        'IO_FlowOutSlow
        '
        Me.IO_FlowOutSlow.Audit = Nothing
        Me.IO_FlowOutSlow.AuditEnabled = False
        Me.IO_FlowOutSlow.AuditMessage = "KremerIoField changed:"
        Me.IO_FlowOutSlow.AuditSource = "KremerIoField"
        Me.IO_FlowOutSlow.BackColor = System.Drawing.Color.White
        Me.IO_FlowOutSlow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_FlowOutSlow.Data = 0.0R
        Me.IO_FlowOutSlow.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_FlowOutSlow.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_FlowOutSlow.InitialValue = True
        Me.IO_FlowOutSlow.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_FlowOutSlow.Location = New System.Drawing.Point(278, 107)
        Me.IO_FlowOutSlow.LowerBound = -10000.0R
        Me.IO_FlowOutSlow.Name = "IO_FlowOutSlow"
        Me.IO_FlowOutSlow.OutputFormat = "0.0 '%'"
        Me.IO_FlowOutSlow.Size = New System.Drawing.Size(100, 22)
        Me.IO_FlowOutSlow.TabIndex = 409
        Me.IO_FlowOutSlow.Text = "0.0 %"
        Me.IO_FlowOutSlow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_FlowOutSlow.UpperBound = 10000.0R
        Me.IO_FlowOutSlow.UserInfo = Nothing
        Me.IO_FlowOutSlow.UserLevel = 0
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
        Me.Btn_Overview.Location = New System.Drawing.Point(685, 385)
        Me.Btn_Overview.Name = "Btn_Overview"
        Me.Btn_Overview.Size = New System.Drawing.Size(114, 50)
        Me.Btn_Overview.State = False
        Me.Btn_Overview.StateIsData = True
        Me.Btn_Overview.StateText = New String() {Nothing, Nothing}
        Me.Btn_Overview.TabIndex = 307
        Me.Btn_Overview.Tag = "194"
        Me.Btn_Overview.Text = "Overview"
        Me.Btn_Overview.UserInfo = Nothing
        Me.Btn_Overview.UserLevel = 0
        Me.Btn_Overview.UseStateText = False
        Me.Btn_Overview.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Btn_Settings)
        Me.Panel1.Controls.Add(Me.Btn_Settings2)
        Me.Panel1.Location = New System.Drawing.Point(514, 329)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(165, 106)
        Me.Panel1.TabIndex = 390
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 23)
        Me.Label1.TabIndex = 257
        Me.Label1.Tag = "80"
        Me.Label1.Text = "More Settings"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_Settings
        '
        Me.Btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Settings.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Settings.Location = New System.Drawing.Point(3, 26)
        Me.Btn_Settings.Name = "Btn_Settings"
        Me.Btn_Settings.Size = New System.Drawing.Size(75, 75)
        Me.Btn_Settings.TabIndex = 255
        Me.Btn_Settings.Text = "<"
        Me.Btn_Settings.UseVisualStyleBackColor = True
        '
        'Btn_Settings2
        '
        Me.Btn_Settings2.Enabled = False
        Me.Btn_Settings2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Settings2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Settings2.Location = New System.Drawing.Point(84, 26)
        Me.Btn_Settings2.Name = "Btn_Settings2"
        Me.Btn_Settings2.Size = New System.Drawing.Size(75, 75)
        Me.Btn_Settings2.TabIndex = 254
        Me.Btn_Settings2.Text = ">"
        Me.Btn_Settings2.UseVisualStyleBackColor = True
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
        Me.Btn_Manual.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Manual.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_Manual.Location = New System.Drawing.Point(685, 329)
        Me.Btn_Manual.Name = "Btn_Manual"
        Me.Btn_Manual.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Manual.State = False
        Me.Btn_Manual.StateIsData = True
        Me.Btn_Manual.StateText = New String() {Nothing, Nothing}
        Me.Btn_Manual.TabIndex = 391
        Me.Btn_Manual.Tag = "192"
        Me.Btn_Manual.Text = "Manual" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Control"
        Me.Btn_Manual.UserInfo = Nothing
        Me.Btn_Manual.UserLevel = 0
        Me.Btn_Manual.UseStateText = False
        Me.Btn_Manual.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 23)
        Me.Label4.TabIndex = 395
        Me.Label4.Tag = "496"
        Me.Label4.Text = "Flow out slow"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(247, 23)
        Me.Label6.TabIndex = 394
        Me.Label6.Tag = "495"
        Me.Label6.Text = "Flow out"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(247, 23)
        Me.Label7.TabIndex = 393
        Me.Label7.Tag = "494"
        Me.Label7.Text = "Flow in slow"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(247, 23)
        Me.Label9.TabIndex = 392
        Me.Label9.Tag = "493"
        Me.Label9.Text = "Flow in"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(27, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(352, 23)
        Me.Label10.TabIndex = 398
        Me.Label10.Tag = "334"
        Me.Label10.Text = "Bottom mold flow"
        '
        'DryingMoldSettings3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.IO_FlowOutSlow)
        Me.Controls.Add(Me.IO_FlowOut)
        Me.Controls.Add(Me.IO_FlowInSlow)
        Me.Controls.Add(Me.IO_FlowIn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Btn_Manual)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Name = "DryingMoldSettings3"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "79"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents mxAutomode As KremerControlsWin32.KremerVariable
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Btn_Settings As System.Windows.Forms.Button
    Friend WithEvents Btn_Settings2 As System.Windows.Forms.Button
    Friend WithEvents Btn_Manual As KremerControlsWin32.KremerButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents FlowIn As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_FlowIn As KremerControlsWin32.KremerIoField
    Friend WithEvents FlowInSlow As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_FlowInSlow As KremerControlsWin32.KremerIoField
    Friend WithEvents FlowOut As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_FlowOut As KremerControlsWin32.KremerIoField
    Friend WithEvents FlowOutSlow As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_FlowOutSlow As KremerControlsWin32.KremerIoField

End Class
