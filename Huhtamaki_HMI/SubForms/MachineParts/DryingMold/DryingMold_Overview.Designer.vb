<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DryingMold_Overview
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
        Me.VacuumActive = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KL_Vac = New KremerControlsWin32.KremerLight()
        Me.BottomSide = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_BotSide = New KremerControlsWin32.KremerIoField(Me.components)
        Me.RodSide = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_RodSide = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PnlBottomMold = New System.Windows.Forms.Panel()
        Me.Btn_BSettings = New KremerControlsWin32.KremerButton()
        Me.PanelTopMold = New System.Windows.Forms.Panel()
        Me.Btn_Manual = New KremerControlsWin32.KremerButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Me.VarCollector
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.mxAutomode)
        Me.VarCollector.Variables.Add(Me.VacuumActive)
        Me.VarCollector.Variables.Add(Me.BottomSide)
        Me.VarCollector.Variables.Add(Me.RodSide)
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
        'VacuumActive
        '
        Me.VacuumActive.BindControl = Me.KL_Vac
        Me.VacuumActive.BindProperty = "Data"
        Me.VacuumActive.Data = Nothing
        Me.VacuumActive.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.VacuumActive.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.VacuumActive.VariableName = "MAIN.InMoldDrying.Bottom[Position1].Vacuum.Q"
        '
        'KL_Vac
        '
        Me.KL_Vac.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.KL_Vac.ColorOn = System.Drawing.Color.Lime
        Me.KL_Vac.Data = False
        Me.KL_Vac.Line = True
        Me.KL_Vac.LineSize = 1
        Me.KL_Vac.Location = New System.Drawing.Point(181, 317)
        Me.KL_Vac.Name = "KL_Vac"
        Me.KL_Vac.Size = New System.Drawing.Size(24, 24)
        Me.KL_Vac.TabIndex = 434
        Me.KL_Vac.Text = "KremerLight1"
        Me.KL_Vac.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BottomSide
        '
        Me.BottomSide.BindControl = Me.IO_BotSide
        Me.BottomSide.BindProperty = "Data"
        Me.BottomSide.Data = Nothing
        Me.BottomSide.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.BottomSide.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BottomSide.VariableName = "MAIN.InMoldDrying.Top[Position1].HydraulicCilinder.BottomSidePressure.EngFilt"
        '
        'IO_BotSide
        '
        Me.IO_BotSide.Audit = Nothing
        Me.IO_BotSide.AuditEnabled = False
        Me.IO_BotSide.AuditMessage = "KremerIoField changed:"
        Me.IO_BotSide.AuditSource = "KremerIoField"
        Me.IO_BotSide.Data = 0R
        Me.IO_BotSide.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_BotSide.InitialValue = True
        Me.IO_BotSide.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_BotSide.Location = New System.Drawing.Point(718, 78)
        Me.IO_BotSide.LowerBound = 0R
        Me.IO_BotSide.Name = "IO_BotSide"
        Me.IO_BotSide.OutputFormat = "0.0 Bar"
        Me.IO_BotSide.Size = New System.Drawing.Size(71, 15)
        Me.IO_BotSide.TabIndex = 316
        Me.IO_BotSide.Text = "0.0 Bar"
        Me.IO_BotSide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IO_BotSide.UpperBound = 1000.0R
        Me.IO_BotSide.UserInfo = Nothing
        Me.IO_BotSide.UserLevel = 0
        '
        'RodSide
        '
        Me.RodSide.BindControl = Me.IO_RodSide
        Me.RodSide.BindProperty = "Data"
        Me.RodSide.Data = Nothing
        Me.RodSide.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.RodSide.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.RodSide.VariableName = "MAIN.InMoldDrying.Top[Position1].HydraulicCilinder.RodSidePressure.EngFilt"
        '
        'IO_RodSide
        '
        Me.IO_RodSide.Audit = Nothing
        Me.IO_RodSide.AuditEnabled = False
        Me.IO_RodSide.AuditMessage = "KremerIoField changed:"
        Me.IO_RodSide.AuditSource = "KremerIoField"
        Me.IO_RodSide.Data = 0R
        Me.IO_RodSide.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_RodSide.InitialValue = True
        Me.IO_RodSide.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_RodSide.Location = New System.Drawing.Point(718, 62)
        Me.IO_RodSide.LowerBound = 0R
        Me.IO_RodSide.Name = "IO_RodSide"
        Me.IO_RodSide.OutputFormat = "0.0 Bar"
        Me.IO_RodSide.Size = New System.Drawing.Size(71, 15)
        Me.IO_RodSide.TabIndex = 319
        Me.IO_RodSide.Text = "0.0 Bar"
        Me.IO_RodSide.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IO_RodSide.UpperBound = 1000.0R
        Me.IO_RodSide.UserInfo = Nothing
        Me.IO_RodSide.UserLevel = 0
        '
        'PnlBottomMold
        '
        Me.PnlBottomMold.BackColor = System.Drawing.Color.Transparent
        Me.PnlBottomMold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlBottomMold.Location = New System.Drawing.Point(211, 269)
        Me.PnlBottomMold.Name = "PnlBottomMold"
        Me.PnlBottomMold.Size = New System.Drawing.Size(404, 122)
        Me.PnlBottomMold.TabIndex = 37
        '
        'Btn_BSettings
        '
        Me.Btn_BSettings.Audit = Nothing
        Me.Btn_BSettings.AuditEnabled = False
        Me.Btn_BSettings.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_BSettings.AuditSource = "KremerPushButton"
        Me.Btn_BSettings.BackColorOn = System.Drawing.Color.Empty
        Me.Btn_BSettings.BackGroundImageOn = Nothing
        Me.Btn_BSettings.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_BSettings.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btn_BSettings.Data = False
        Me.Btn_BSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BSettings.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_BSettings.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_BSettings.Location = New System.Drawing.Point(683, 329)
        Me.Btn_BSettings.Name = "Btn_BSettings"
        Me.Btn_BSettings.Size = New System.Drawing.Size(114, 50)
        Me.Btn_BSettings.State = False
        Me.Btn_BSettings.StateIsData = True
        Me.Btn_BSettings.StateText = New String() {Nothing, Nothing}
        Me.Btn_BSettings.TabIndex = 307
        Me.Btn_BSettings.Tag = "193"
        Me.Btn_BSettings.Text = "Settings"
        Me.Btn_BSettings.UserInfo = Nothing
        Me.Btn_BSettings.UserLevel = 0
        Me.Btn_BSettings.UseStateText = False
        Me.Btn_BSettings.UseVisualStyleBackColor = True
        '
        'PanelTopMold
        '
        Me.PanelTopMold.BackColor = System.Drawing.Color.Transparent
        Me.PanelTopMold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTopMold.Location = New System.Drawing.Point(211, 42)
        Me.PanelTopMold.Name = "PanelTopMold"
        Me.PanelTopMold.Size = New System.Drawing.Size(404, 221)
        Me.PanelTopMold.TabIndex = 36
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
        Me.Btn_Manual.Location = New System.Drawing.Point(683, 382)
        Me.Btn_Manual.Name = "Btn_Manual"
        Me.Btn_Manual.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Manual.State = False
        Me.Btn_Manual.StateIsData = True
        Me.Btn_Manual.StateText = New String() {Nothing, Nothing}
        Me.Btn_Manual.TabIndex = 308
        Me.Btn_Manual.Tag = "192"
        Me.Btn_Manual.Text = "Manual" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Control"
        Me.Btn_Manual.UserInfo = Nothing
        Me.Btn_Manual.UserLevel = 0
        Me.Btn_Manual.UseStateText = False
        Me.Btn_Manual.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label4.Location = New System.Drawing.Point(622, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 320
        Me.Label4.Tag = ""
        Me.Label4.Text = "Rod side:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label3.Location = New System.Drawing.Point(622, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 318
        Me.Label3.Tag = ""
        Me.Label3.Text = "Bottom side:"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(621, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 23)
        Me.Label10.TabIndex = 317
        Me.Label10.Tag = "226"
        Me.Label10.Text = "Pressure"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(105, 317)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 23)
        Me.Label5.TabIndex = 435
        Me.Label5.Tag = ""
        Me.Label5.Text = "Vacuum active"
        '
        'DryingMold_Overview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.InMoldDrying.My.Resources.Resources.Top_Dryingmold_A_side
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.KL_Vac)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.IO_RodSide)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.IO_BotSide)
        Me.Controls.Add(Me.Btn_Manual)
        Me.Controls.Add(Me.PanelTopMold)
        Me.Controls.Add(Me.Btn_BSettings)
        Me.Controls.Add(Me.PnlBottomMold)
        Me.DoubleBuffered = True
        Me.Name = "DryingMold_Overview"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "80"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents mxAutomode As KremerControlsWin32.KremerVariable
    Friend WithEvents PnlBottomMold As System.Windows.Forms.Panel
    Friend WithEvents Btn_BSettings As KremerControlsWin32.KremerButton
    Friend WithEvents PanelTopMold As System.Windows.Forms.Panel
    Friend WithEvents Btn_Manual As KremerControlsWin32.KremerButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents IO_RodSide As KremerControlsWin32.KremerIoField
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents IO_BotSide As KremerControlsWin32.KremerIoField
    Friend WithEvents BottomSide As KremerControlsWin32.KremerVariable
    Friend WithEvents RodSide As KremerControlsWin32.KremerVariable
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents KL_Vac As KremerControlsWin32.KremerLight
    Friend WithEvents VacuumActive As KremerControlsWin32.KremerVariable

End Class
