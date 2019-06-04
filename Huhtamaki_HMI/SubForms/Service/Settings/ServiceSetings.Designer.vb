<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiceSettings
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
        Me.GodModeData = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnGodMode = New KremerControlsWin32.KremerButton()
        Me.GodModeState = New KremerControlsWin32.KremerVariable(Me.components)
        Me.RHSR_TRinBTM = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_TR_In_BotTemp = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Settings = New System.Windows.Forms.Button()
        Me.Btn_Settings2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Input_EndOfTrack_Pos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.KremerIoField4 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.KremerIoField1 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.KremerIoField12 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.lbl_puh = New System.Windows.Forms.Label()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'krConnector
        '
        Me.krConnector.VarCollector = Nothing
        '
        'krVarCollector
        '
        Me.krVarCollector.Variables.Add(Me.GodModeData)
        Me.krVarCollector.Variables.Add(Me.GodModeState)
        Me.krVarCollector.Variables.Add(Me.RHSR_TRinBTM)
        '
        'GodModeData
        '
        Me.GodModeData.BindControl = Me.BtnGodMode
        Me.GodModeData.BindProperty = "Data"
        Me.GodModeData.Data = Nothing
        Me.GodModeData.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GodModeData.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GodModeData.VariableName = "MAIN.InMoldDrying.MachParameters.CommisioningMode"
        '
        'BtnGodMode
        '
        Me.BtnGodMode.Audit = Nothing
        Me.BtnGodMode.AuditEnabled = False
        Me.BtnGodMode.AuditMessage = "KremerPushButton pressed!"
        Me.BtnGodMode.AuditSource = "KremerPushButton"
        Me.BtnGodMode.BackColorOn = System.Drawing.Color.Blue
        Me.BtnGodMode.BackGroundImageOn = Nothing
        Me.BtnGodMode.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.BtnGodMode.Data = False
        Me.BtnGodMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGodMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGodMode.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnGodMode.Location = New System.Drawing.Point(325, 43)
        Me.BtnGodMode.Name = "BtnGodMode"
        Me.BtnGodMode.Size = New System.Drawing.Size(104, 47)
        Me.BtnGodMode.State = False
        Me.BtnGodMode.StateIsData = False
        Me.BtnGodMode.StateText = New String() {Nothing, Nothing}
        Me.BtnGodMode.TabIndex = 379
        Me.BtnGodMode.Text = "ON"
        Me.BtnGodMode.UserInfo = Nothing
        Me.BtnGodMode.UserLevel = 0
        Me.BtnGodMode.UseStateText = False
        Me.BtnGodMode.UseVisualStyleBackColor = False
        '
        'GodModeState
        '
        Me.GodModeState.BindControl = Me.BtnGodMode
        Me.GodModeState.BindProperty = "State"
        Me.GodModeState.Data = Nothing
        Me.GodModeState.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GodModeState.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GodModeState.VariableName = "MAIN.InMoldDrying.MachParameters.CommisioningMode"
        '
        'RHSR_TRinBTM
        '
        Me.RHSR_TRinBTM.BindControl = Me.IO_TR_In_BotTemp
        Me.RHSR_TRinBTM.BindProperty = "Data"
        Me.RHSR_TRinBTM.Data = Nothing
        Me.RHSR_TRinBTM.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.RHSR_TRinBTM.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.RHSR_TRinBTM.VariableName = "MAIN.InMoldDrying.MachParameters.MinTempAlowTransferToBot"
        '
        'IO_TR_In_BotTemp
        '
        Me.IO_TR_In_BotTemp.Audit = Nothing
        Me.IO_TR_In_BotTemp.AuditEnabled = False
        Me.IO_TR_In_BotTemp.AuditMessage = "KremerIoField changed:"
        Me.IO_TR_In_BotTemp.AuditSource = "KremerIoField"
        Me.IO_TR_In_BotTemp.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.IO_TR_In_BotTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO_TR_In_BotTemp.Data = 0.0R
        Me.IO_TR_In_BotTemp.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TR_In_BotTemp.InitialValue = True
        Me.IO_TR_In_BotTemp.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TR_In_BotTemp.Location = New System.Drawing.Point(325, 168)
        Me.IO_TR_In_BotTemp.LowerBound = 0.0R
        Me.IO_TR_In_BotTemp.Name = "IO_TR_In_BotTemp"
        Me.IO_TR_In_BotTemp.OutputFormat = "0.0 °C"
        Me.IO_TR_In_BotTemp.Size = New System.Drawing.Size(104, 34)
        Me.IO_TR_In_BotTemp.TabIndex = 383
        Me.IO_TR_In_BotTemp.Text = "0.0 °C"
        Me.IO_TR_In_BotTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IO_TR_In_BotTemp.UpperBound = 400.0R
        Me.IO_TR_In_BotTemp.UserInfo = Nothing
        Me.IO_TR_In_BotTemp.UserLevel = 0
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 441)
        Me.ShapeContainer1.TabIndex = 355
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 18
        Me.LineShape2.X2 = 432
        Me.LineShape2.Y1 = 152
        Me.LineShape2.Y2 = 152
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 15
        Me.LineShape1.X2 = 429
        Me.LineShape1.Y1 = 33
        Me.LineShape1.Y2 = 33
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(-1, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(165, 23)
        Me.Label18.TabIndex = 257
        Me.Label18.Tag = "97"
        Me.Label18.Text = "More Settings"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Btn_Settings)
        Me.Panel1.Controls.Add(Me.Btn_Settings2)
        Me.Panel1.Location = New System.Drawing.Point(632, 332)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(165, 106)
        Me.Panel1.TabIndex = 364
        '
        'Btn_Settings
        '
        Me.Btn_Settings.Enabled = False
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
        Me.Btn_Settings2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Settings2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Settings2.Location = New System.Drawing.Point(84, 26)
        Me.Btn_Settings2.Name = "Btn_Settings2"
        Me.Btn_Settings2.Size = New System.Drawing.Size(75, 75)
        Me.Btn_Settings2.TabIndex = 254
        Me.Btn_Settings2.Text = ">"
        Me.Btn_Settings2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(306, 61)
        Me.Label2.TabIndex = 378
        Me.Label2.Tag = ""
        Me.Label2.Text = "Disables all safety rules, and alows free movement of all parts. But beware, it c" & _
    "an destroy machine parts!"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 23)
        Me.Label1.TabIndex = 380
        Me.Label1.Tag = ""
        Me.Label1.Text = "Godmode"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(12, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 23)
        Me.Label3.TabIndex = 381
        Me.Label3.Tag = ""
        Me.Label3.Text = "Temperature for RHSR"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(304, 78)
        Me.Label4.TabIndex = 382
        Me.Label4.Tag = ""
        Me.Label4.Text = "Minimum temperature at which transfermold can still go into the bottomolds. Below" & _
    " this temperature movement is blocked by safety rule"
        '
        'Input_EndOfTrack_Pos
        '
        Me.Input_EndOfTrack_Pos.Audit = Nothing
        Me.Input_EndOfTrack_Pos.AuditEnabled = False
        Me.Input_EndOfTrack_Pos.AuditMessage = "KremerIoField changed:"
        Me.Input_EndOfTrack_Pos.AuditSource = "KremerIoField"
        Me.Input_EndOfTrack_Pos.BackColor = System.Drawing.Color.White
        Me.Input_EndOfTrack_Pos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Input_EndOfTrack_Pos.Data = 0.0R
        Me.Input_EndOfTrack_Pos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.Input_EndOfTrack_Pos.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input_EndOfTrack_Pos.InitialValue = True
        Me.Input_EndOfTrack_Pos.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.Input_EndOfTrack_Pos.Location = New System.Drawing.Point(290, 350)
        Me.Input_EndOfTrack_Pos.LowerBound = 0.0R
        Me.Input_EndOfTrack_Pos.Name = "Input_EndOfTrack_Pos"
        Me.Input_EndOfTrack_Pos.OutputFormat = "0.0 mm"
        Me.Input_EndOfTrack_Pos.Size = New System.Drawing.Size(100, 22)
        Me.Input_EndOfTrack_Pos.TabIndex = 414
        Me.Input_EndOfTrack_Pos.Text = "0.0 mm"
        Me.Input_EndOfTrack_Pos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Input_EndOfTrack_Pos.UpperBound = 5000.0R
        Me.Input_EndOfTrack_Pos.UserInfo = Nothing
        Me.Input_EndOfTrack_Pos.UserLevel = 800
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 349)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 23)
        Me.Label5.TabIndex = 413
        Me.Label5.Tag = ""
        Me.Label5.Text = "Machine pond Position zero offset"
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
        Me.KremerIoField4.Location = New System.Drawing.Point(290, 327)
        Me.KremerIoField4.LowerBound = 0.0R
        Me.KremerIoField4.Name = "KremerIoField4"
        Me.KremerIoField4.OutputFormat = "0.0 mm"
        Me.KremerIoField4.Size = New System.Drawing.Size(100, 22)
        Me.KremerIoField4.TabIndex = 412
        Me.KremerIoField4.Text = "0.0 mm"
        Me.KremerIoField4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.KremerIoField4.UpperBound = 1000.0R
        Me.KremerIoField4.UserInfo = Nothing
        Me.KremerIoField4.UserLevel = 500
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 326)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(247, 23)
        Me.Label6.TabIndex = 411
        Me.Label6.Tag = ""
        Me.Label6.Text = "Transfermold offset Zero"
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
        Me.KremerIoField1.Location = New System.Drawing.Point(290, 304)
        Me.KremerIoField1.LowerBound = 0.0R
        Me.KremerIoField1.Name = "KremerIoField1"
        Me.KremerIoField1.OutputFormat = "0.0 mm"
        Me.KremerIoField1.Size = New System.Drawing.Size(100, 22)
        Me.KremerIoField1.TabIndex = 410
        Me.KremerIoField1.Text = "0.0 mm"
        Me.KremerIoField1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.KremerIoField1.UpperBound = 1000.0R
        Me.KremerIoField1.UserInfo = Nothing
        Me.KremerIoField1.UserLevel = 500
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(14, 303)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(247, 23)
        Me.Label13.TabIndex = 409
        Me.Label13.Tag = ""
        Me.Label13.Text = "Top mold B offset zero"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(14, 280)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(247, 23)
        Me.Label17.TabIndex = 408
        Me.Label17.Tag = ""
        Me.Label17.Text = "Top mold A offset zero"
        '
        'KremerIoField12
        '
        Me.KremerIoField12.Audit = Nothing
        Me.KremerIoField12.AuditEnabled = False
        Me.KremerIoField12.AuditMessage = "KremerIoField changed:"
        Me.KremerIoField12.AuditSource = "KremerIoField"
        Me.KremerIoField12.BackColor = System.Drawing.Color.White
        Me.KremerIoField12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KremerIoField12.Data = 0.0R
        Me.KremerIoField12.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.KremerIoField12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerIoField12.InitialValue = True
        Me.KremerIoField12.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.KremerIoField12.Location = New System.Drawing.Point(290, 281)
        Me.KremerIoField12.LowerBound = 0.0R
        Me.KremerIoField12.Name = "KremerIoField12"
        Me.KremerIoField12.OutputFormat = "0.0 mm"
        Me.KremerIoField12.Size = New System.Drawing.Size(100, 22)
        Me.KremerIoField12.TabIndex = 407
        Me.KremerIoField12.Text = "0.0 mm"
        Me.KremerIoField12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.KremerIoField12.UpperBound = 1000.0R
        Me.KremerIoField12.UserInfo = Nothing
        Me.KremerIoField12.UserLevel = 500
        '
        'lbl_puh
        '
        Me.lbl_puh.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_puh.Location = New System.Drawing.Point(14, 249)
        Me.lbl_puh.Name = "lbl_puh"
        Me.lbl_puh.Size = New System.Drawing.Size(247, 23)
        Me.lbl_puh.TabIndex = 406
        Me.lbl_puh.Tag = ""
        Me.lbl_puh.Text = "Offset position settings"
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 20
        Me.LineShape3.X2 = 434
        Me.LineShape3.Y1 = 276
        Me.LineShape3.Y2 = 276
        '
        'ServiceSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Input_EndOfTrack_Pos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.KremerIoField4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.KremerIoField1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.KremerIoField12)
        Me.Controls.Add(Me.lbl_puh)
        Me.Controls.Add(Me.IO_TR_In_BotTemp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnGodMode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "ServiceSettings"
        Me.Size = New System.Drawing.Size(800, 441)
        Me.Tag = "503"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents krConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents krVarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btn_Settings As System.Windows.Forms.Button
    Friend WithEvents Btn_Settings2 As System.Windows.Forms.Button
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnGodMode As KremerControlsWin32.KremerButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GodModeData As KremerControlsWin32.KremerVariable
    Friend WithEvents GodModeState As KremerControlsWin32.KremerVariable
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents IO_TR_In_BotTemp As KremerControlsWin32.KremerIoField
    Friend WithEvents RHSR_TRinBTM As KremerControlsWin32.KremerVariable
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Input_EndOfTrack_Pos As KremerControlsWin32.KremerIoField
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents KremerIoField4 As KremerControlsWin32.KremerIoField
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents KremerIoField1 As KremerControlsWin32.KremerIoField
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents KremerIoField12 As KremerControlsWin32.KremerIoField
    Friend WithEvents lbl_puh As System.Windows.Forms.Label

End Class
