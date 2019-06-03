<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transfermold_Overview
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
        Me.Pnl_Status_init = New System.Windows.Forms.Panel()
        Me.State_HorTransport = New KremerControlsWin32.KremerStatusBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.mxAutomode = New KremerControlsWin32.KremerVariable(Me.components)
        Me.TransfermoldPos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.io_HorTransp_Pos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.RodSidePressure = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_RodSide = New KremerControlsWin32.KremerIoField(Me.components)
        Me.BottomSidePressure = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_BotSide = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.KL_Vac = New KremerControlsWin32.KremerLight()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VacuumOnTransfer = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Pnl_Status_init.SuspendLayout()
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
        Me.Btn_Manual.Location = New System.Drawing.Point(684, 382)
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
        'Pnl_Status_init
        '
        Me.Pnl_Status_init.BackColor = System.Drawing.Color.White
        Me.Pnl_Status_init.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pnl_Status_init.Controls.Add(Me.State_HorTransport)
        Me.Pnl_Status_init.Controls.Add(Me.Label1)
        Me.Pnl_Status_init.Location = New System.Drawing.Point(3, 327)
        Me.Pnl_Status_init.Name = "Pnl_Status_init"
        Me.Pnl_Status_init.Size = New System.Drawing.Size(678, 106)
        Me.Pnl_Status_init.TabIndex = 34
        '
        'State_HorTransport
        '
        Me.State_HorTransport.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.State_HorTransport.BackColorOn = System.Drawing.Color.Lime
        Me.State_HorTransport.Data = 0
        Me.State_HorTransport.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.State_HorTransport.ForeColor = System.Drawing.Color.Navy
        Me.State_HorTransport.ForeColorOn = System.Drawing.Color.Black
        Me.State_HorTransport.Location = New System.Drawing.Point(225, 2)
        Me.State_HorTransport.Name = "State_HorTransport"
        Me.State_HorTransport.Size = New System.Drawing.Size(451, 19)
        Me.State_HorTransport.State = False
        Me.State_HorTransport.StatusText = Nothing
        Me.State_HorTransport.TabIndex = 36
        Me.State_HorTransport.Text = "State"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(0, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 19)
        Me.Label1.TabIndex = 37
        Me.Label1.Tag = ""
        Me.Label1.Text = "Transfer mold:"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.ForeColor = System.Drawing.Color.Navy
        Me.lblStatus.Location = New System.Drawing.Point(6, 298)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(291, 26)
        Me.lblStatus.TabIndex = 35
        Me.lblStatus.Tag = "77"
        Me.lblStatus.Text = "Init Cycles"
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.mxAutomode)
        Me.VarCollector.Variables.Add(Me.VacuumOnTransfer)
        Me.VarCollector.Variables.Add(Me.TransfermoldPos)
        Me.VarCollector.Variables.Add(Me.RodSidePressure)
        Me.VarCollector.Variables.Add(Me.BottomSidePressure)
        '
        'mxAutomode
        '
        Me.mxAutomode.BindControl = Nothing
        Me.mxAutomode.BindProperty = "Data"
        Me.mxAutomode.Data = Nothing
        Me.mxAutomode.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.mxAutomode.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.mxAutomode.VariableName = "MAIN.mxAutomode"
        '
        'TransfermoldPos
        '
        Me.TransfermoldPos.BindControl = Me.io_HorTransp_Pos
        Me.TransfermoldPos.BindProperty = "Data"
        Me.TransfermoldPos.Data = Nothing
        Me.TransfermoldPos.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.TransfermoldPos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TransfermoldPos.VariableName = "MAIN.InMoldDrying.TransferMold.HydraulicCilinder.ActPosition"
        '
        'io_HorTransp_Pos
        '
        Me.io_HorTransp_Pos.Audit = Nothing
        Me.io_HorTransp_Pos.AuditEnabled = False
        Me.io_HorTransp_Pos.AuditMessage = "KremerIoField changed:"
        Me.io_HorTransp_Pos.AuditSource = "KremerIoField"
        Me.io_HorTransp_Pos.Data = 0.0R
        Me.io_HorTransp_Pos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.io_HorTransp_Pos.InitialValue = True
        Me.io_HorTransp_Pos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.io_HorTransp_Pos.Location = New System.Drawing.Point(475, 277)
        Me.io_HorTransp_Pos.LowerBound = 0.0R
        Me.io_HorTransp_Pos.Name = "io_HorTransp_Pos"
        Me.io_HorTransp_Pos.OutputFormat = "0.0 mm"
        Me.io_HorTransp_Pos.Size = New System.Drawing.Size(71, 21)
        Me.io_HorTransp_Pos.TabIndex = 262
        Me.io_HorTransp_Pos.Text = "0,0 mm"
        Me.io_HorTransp_Pos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.io_HorTransp_Pos.UpperBound = 1000.0R
        Me.io_HorTransp_Pos.UserInfo = Nothing
        Me.io_HorTransp_Pos.UserLevel = 0
        '
        'RodSidePressure
        '
        Me.RodSidePressure.BindControl = Me.IO_RodSide
        Me.RodSidePressure.BindProperty = "Data"
        Me.RodSidePressure.Data = Nothing
        Me.RodSidePressure.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.RodSidePressure.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.RodSidePressure.VariableName = "MAIN.InMoldDrying.TransferMold.HydraulicCilinder.RodSidePressure.EngFilt"
        '
        'IO_RodSide
        '
        Me.IO_RodSide.Audit = Nothing
        Me.IO_RodSide.AuditEnabled = False
        Me.IO_RodSide.AuditMessage = "KremerIoField changed:"
        Me.IO_RodSide.AuditSource = "KremerIoField"
        Me.IO_RodSide.Data = 0.0R
        Me.IO_RodSide.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_RodSide.InitialValue = True
        Me.IO_RodSide.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_RodSide.Location = New System.Drawing.Point(571, 68)
        Me.IO_RodSide.LowerBound = 0.0R
        Me.IO_RodSide.Name = "IO_RodSide"
        Me.IO_RodSide.OutputFormat = "0.0 Bar"
        Me.IO_RodSide.Size = New System.Drawing.Size(71, 15)
        Me.IO_RodSide.TabIndex = 314
        Me.IO_RodSide.Text = "0.0 Bar"
        Me.IO_RodSide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IO_RodSide.UpperBound = 1000.0R
        Me.IO_RodSide.UserInfo = Nothing
        Me.IO_RodSide.UserLevel = 0
        '
        'BottomSidePressure
        '
        Me.BottomSidePressure.BindControl = Me.IO_BotSide
        Me.BottomSidePressure.BindProperty = "Data"
        Me.BottomSidePressure.Data = Nothing
        Me.BottomSidePressure.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.BottomSidePressure.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BottomSidePressure.VariableName = "MAIN.InMoldDrying.TransferMold.HydraulicCilinder.BottomSidePressure.EngFilt"
        '
        'IO_BotSide
        '
        Me.IO_BotSide.Audit = Nothing
        Me.IO_BotSide.AuditEnabled = False
        Me.IO_BotSide.AuditMessage = "KremerIoField changed:"
        Me.IO_BotSide.AuditSource = "KremerIoField"
        Me.IO_BotSide.Data = 0.0R
        Me.IO_BotSide.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_BotSide.InitialValue = True
        Me.IO_BotSide.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_BotSide.Location = New System.Drawing.Point(571, 84)
        Me.IO_BotSide.LowerBound = 0.0R
        Me.IO_BotSide.Name = "IO_BotSide"
        Me.IO_BotSide.OutputFormat = "0.0 Bar"
        Me.IO_BotSide.Size = New System.Drawing.Size(71, 15)
        Me.IO_BotSide.TabIndex = 263
        Me.IO_BotSide.Text = "0.0 Bar"
        Me.IO_BotSide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IO_BotSide.UpperBound = 1000.0R
        Me.IO_BotSide.UserInfo = Nothing
        Me.IO_BotSide.UserLevel = 0
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(474, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 23)
        Me.Label10.TabIndex = 311
        Me.Label10.Tag = "93"
        Me.Label10.Text = "Pressure"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(474, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 23)
        Me.Label2.TabIndex = 312
        Me.Label2.Tag = "118"
        Me.Label2.Text = "Position"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label3.Location = New System.Drawing.Point(475, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 313
        Me.Label3.Tag = ""
        Me.Label3.Text = "Bottom side:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label4.Location = New System.Drawing.Point(475, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 315
        Me.Label4.Tag = ""
        Me.Label4.Text = "Rod side:"
        '
        'KL_Vac
        '
        Me.KL_Vac.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.KL_Vac.ColorOn = System.Drawing.Color.Lime
        Me.KL_Vac.Data = False
        Me.KL_Vac.Line = True
        Me.KL_Vac.LineSize = 1
        Me.KL_Vac.Location = New System.Drawing.Point(305, 290)
        Me.KL_Vac.Name = "KL_Vac"
        Me.KL_Vac.Size = New System.Drawing.Size(24, 24)
        Me.KL_Vac.TabIndex = 432
        Me.KL_Vac.Text = "KremerLight1"
        Me.KL_Vac.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(229, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 23)
        Me.Label5.TabIndex = 433
        Me.Label5.Tag = ""
        Me.Label5.Text = "Vacuum active"
        '
        'VacuumOnTransfer
        '
        Me.VacuumOnTransfer.BindControl = Me.KL_Vac
        Me.VacuumOnTransfer.BindProperty = "Data"
        Me.VacuumOnTransfer.Data = Nothing
        Me.VacuumOnTransfer.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.VacuumOnTransfer.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.VacuumOnTransfer.VariableName = "MAIN.InMoldDrying.TransferMold.Vacuum.Q"
        '
        'Transfermold_Overview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.InMoldDrying.My.Resources.Resources.Transfermold
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.KL_Vac)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.IO_RodSide)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.IO_BotSide)
        Me.Controls.Add(Me.io_HorTransp_Pos)
        Me.Controls.Add(Me.Pnl_Status_init)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Btn_Settings)
        Me.Controls.Add(Me.Btn_Manual)
        Me.DoubleBuffered = True
        Me.Name = "Transfermold_Overview"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "95"
        Me.Pnl_Status_init.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Settings As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_Manual As KremerControlsWin32.KremerButton
    Friend WithEvents Pnl_Status_init As System.Windows.Forms.Panel
    Friend WithEvents State_HorTransport As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents mxAutomode As KremerControlsWin32.KremerVariable
    Friend WithEvents io_HorTransp_Pos As KremerControlsWin32.KremerIoField
    Friend WithEvents TransfermoldPos As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_BotSide As KremerControlsWin32.KremerIoField
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RodSidePressure As KremerControlsWin32.KremerVariable
    Friend WithEvents BottomSidePressure As KremerControlsWin32.KremerVariable
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents IO_RodSide As KremerControlsWin32.KremerIoField
    Friend WithEvents KL_Vac As KremerControlsWin32.KremerLight
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents VacuumOnTransfer As KremerControlsWin32.KremerVariable

End Class
