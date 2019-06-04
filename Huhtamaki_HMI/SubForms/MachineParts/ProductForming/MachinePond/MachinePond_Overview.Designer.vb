<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MachinePond_Overview
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
        Me.Pnl_Status_init = New System.Windows.Forms.Panel()
        Me.KremerStatusBox1 = New KremerControlsWin32.KremerStatusBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.State_PushA = New KremerControlsWin32.KremerStatusBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Btn_Settings = New KremerControlsWin32.KremerButton()
        Me.Btn_Manual = New KremerControlsWin32.KremerButton()
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.mxAutoMode = New KremerControlsWin32.KremerVariable(Me.components)
        Me.PondPosition = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioPondPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.RodSidePressure = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_RodSide = New KremerControlsWin32.KremerIoField(Me.components)
        Me.BotSidePressure = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_BotSide = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.KremerShape1 = New KremerControlsWin32.KremerShape()
        Me.KremerShape2 = New KremerControlsWin32.KremerShape()
        Me.SupplyVleft = New KremerControlsWin32.KremerShape()
        Me.KremerShape3 = New KremerControlsWin32.KremerShape()
        Me.Btn_Overview = New KremerControlsWin32.KremerButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Pnl_Status_init.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pnl_Status_init
        '
        Me.Pnl_Status_init.BackColor = System.Drawing.Color.White
        Me.Pnl_Status_init.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pnl_Status_init.Controls.Add(Me.KremerStatusBox1)
        Me.Pnl_Status_init.Controls.Add(Me.Label2)
        Me.Pnl_Status_init.Controls.Add(Me.State_PushA)
        Me.Pnl_Status_init.Controls.Add(Me.Label1)
        Me.Pnl_Status_init.Location = New System.Drawing.Point(1, 326)
        Me.Pnl_Status_init.Name = "Pnl_Status_init"
        Me.Pnl_Status_init.Size = New System.Drawing.Size(678, 106)
        Me.Pnl_Status_init.TabIndex = 8
        '
        'KremerStatusBox1
        '
        Me.KremerStatusBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.KremerStatusBox1.BackColorOn = System.Drawing.Color.Lime
        Me.KremerStatusBox1.Data = 0
        Me.KremerStatusBox1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.KremerStatusBox1.ForeColor = System.Drawing.Color.Navy
        Me.KremerStatusBox1.ForeColorOn = System.Drawing.Color.Black
        Me.KremerStatusBox1.Location = New System.Drawing.Point(173, 21)
        Me.KremerStatusBox1.Name = "KremerStatusBox1"
        Me.KremerStatusBox1.Size = New System.Drawing.Size(503, 19)
        Me.KremerStatusBox1.State = False
        Me.KremerStatusBox1.StatusText = Nothing
        Me.KremerStatusBox1.TabIndex = 39
        Me.KremerStatusBox1.Text = "State"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(0, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 19)
        Me.Label2.TabIndex = 38
        Me.Label2.Tag = ""
        Me.Label2.Text = "Forming mold:"
        '
        'State_PushA
        '
        Me.State_PushA.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.State_PushA.BackColorOn = System.Drawing.Color.Lime
        Me.State_PushA.Data = 0
        Me.State_PushA.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.State_PushA.ForeColor = System.Drawing.Color.Navy
        Me.State_PushA.ForeColorOn = System.Drawing.Color.Black
        Me.State_PushA.Location = New System.Drawing.Point(173, 2)
        Me.State_PushA.Name = "State_PushA"
        Me.State_PushA.Size = New System.Drawing.Size(503, 19)
        Me.State_PushA.State = False
        Me.State_PushA.StatusText = Nothing
        Me.State_PushA.TabIndex = 36
        Me.State_PushA.Text = "State"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(0, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 19)
        Me.Label1.TabIndex = 37
        Me.Label1.Tag = ""
        Me.Label1.Text = "Machine pond:"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.ForeColor = System.Drawing.Color.Navy
        Me.lblStatus.Location = New System.Drawing.Point(4, 297)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(675, 26)
        Me.lblStatus.TabIndex = 33
        Me.lblStatus.Tag = "77"
        Me.lblStatus.Text = "Init Cycles"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.Btn_Settings.Location = New System.Drawing.Point(685, 326)
        Me.Btn_Settings.Name = "Btn_Settings"
        Me.Btn_Settings.Size = New System.Drawing.Size(114, 50)
        Me.Btn_Settings.State = False
        Me.Btn_Settings.StateIsData = True
        Me.Btn_Settings.StateText = New String() {Nothing, Nothing}
        Me.Btn_Settings.TabIndex = 7
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
        Me.Btn_Manual.Location = New System.Drawing.Point(685, 382)
        Me.Btn_Manual.Name = "Btn_Manual"
        Me.Btn_Manual.Size = New System.Drawing.Size(114, 50)
        Me.Btn_Manual.State = False
        Me.Btn_Manual.StateIsData = True
        Me.Btn_Manual.StateText = New String() {Nothing, Nothing}
        Me.Btn_Manual.TabIndex = 6
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
        Me.VarCollector.Variables.Add(Me.mxAutoMode)
        Me.VarCollector.Variables.Add(Me.PondPosition)
        Me.VarCollector.Variables.Add(Me.RodSidePressure)
        Me.VarCollector.Variables.Add(Me.BotSidePressure)
        '
        'mxAutoMode
        '
        Me.mxAutoMode.BindControl = Nothing
        Me.mxAutoMode.BindProperty = "Data"
        Me.mxAutoMode.Data = Nothing
        Me.mxAutoMode.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.mxAutoMode.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.mxAutoMode.VariableName = "Main.mxAutoMode"
        '
        'PondPosition
        '
        Me.PondPosition.BindControl = Me.ioPondPos
        Me.PondPosition.BindProperty = "Data"
        Me.PondPosition.Data = Nothing
        Me.PondPosition.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.PondPosition.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PondPosition.VariableName = "MAIN.InMoldDrying.ProductForming.PondHydraulicCilinder.HydraulicPos.Position"
        '
        'ioPondPos
        '
        Me.ioPondPos.Audit = Nothing
        Me.ioPondPos.AuditEnabled = False
        Me.ioPondPos.AuditMessage = "KremerIoField changed:"
        Me.ioPondPos.AuditSource = "KremerIoField"
        Me.ioPondPos.Data = 0R
        Me.ioPondPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioPondPos.InitialValue = True
        Me.ioPondPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioPondPos.Location = New System.Drawing.Point(559, 200)
        Me.ioPondPos.LowerBound = 0R
        Me.ioPondPos.Name = "ioPondPos"
        Me.ioPondPos.OutputFormat = "0.0 mm"
        Me.ioPondPos.Size = New System.Drawing.Size(71, 21)
        Me.ioPondPos.TabIndex = 263
        Me.ioPondPos.Text = "0.0 mm"
        Me.ioPondPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ioPondPos.UpperBound = 1000.0R
        Me.ioPondPos.UserInfo = Nothing
        Me.ioPondPos.UserLevel = 0
        '
        'RodSidePressure
        '
        Me.RodSidePressure.BindControl = Me.IO_RodSide
        Me.RodSidePressure.BindProperty = "Data"
        Me.RodSidePressure.Data = Nothing
        Me.RodSidePressure.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.RodSidePressure.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.RodSidePressure.VariableName = "MAIN.InMoldDrying.ProductForming.PondHydraulicCilinder.RodSidePressure.EngFilt"
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
        Me.IO_RodSide.Location = New System.Drawing.Point(655, 95)
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
        'BotSidePressure
        '
        Me.BotSidePressure.BindControl = Me.IO_BotSide
        Me.BotSidePressure.BindProperty = "Data"
        Me.BotSidePressure.Data = Nothing
        Me.BotSidePressure.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.BotSidePressure.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BotSidePressure.VariableName = "MAIN.InMoldDrying.ProductForming.PondHydraulicCilinder.BottomSidePressure.EngFilt" &
    ""
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
        Me.IO_BotSide.Location = New System.Drawing.Point(655, 111)
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
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 435)
        Me.ShapeContainer1.TabIndex = 34
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.Navy
        Me.LineShape4.BorderWidth = 2
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 275
        Me.LineShape4.X2 = 275
        Me.LineShape4.Y1 = 275
        Me.LineShape4.Y2 = 235
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.Navy
        Me.LineShape3.BorderWidth = 2
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 175
        Me.LineShape3.X2 = 275
        Me.LineShape3.Y1 = 275
        Me.LineShape3.Y2 = 275
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 552
        Me.LineShape2.X2 = 552
        Me.LineShape2.Y1 = 151
        Me.LineShape2.Y2 = 251
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.Control
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 246
        Me.LineShape1.X2 = 539
        Me.LineShape1.Y1 = 84
        Me.LineShape1.Y2 = 84
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.Location = New System.Drawing.Point(242, 85)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(300, 150)
        '
        'KremerShape1
        '
        Me.KremerShape1.Data = False
        Me.KremerShape1.Fill = False
        Me.KremerShape1.FillColor = System.Drawing.SystemColors.Control
        Me.KremerShape1.FillColorOn = System.Drawing.SystemColors.Control
        Me.KremerShape1.FillDirection = KremerControlsWin32.KremerShape.Direction.Up
        Me.KremerShape1.FillLevel = 100.0!
        Me.KremerShape1.FillMaximum = 100.0!
        Me.KremerShape1.FillMinimum = 0!
        Me.KremerShape1.Line = True
        Me.KremerShape1.LineColor = System.Drawing.Color.Black
        Me.KremerShape1.LineColorOn = System.Drawing.Color.Black
        Me.KremerShape1.LineSize = 1
        Me.KremerShape1.Location = New System.Drawing.Point(545, 149)
        Me.KremerShape1.Name = "KremerShape1"
        Me.KremerShape1.Size = New System.Drawing.Size(15, 15)
        Me.KremerShape1.Style = KremerControlsWin32.KremerShape.LineStyle.Solid
        Me.KremerShape1.TabIndex = 261
        Me.KremerShape1.Text = "KremerShape1"
        Me.KremerShape1.Type = KremerControlsWin32.KremerShape.ShapeType.TriangleUp
        '
        'KremerShape2
        '
        Me.KremerShape2.Data = False
        Me.KremerShape2.Fill = False
        Me.KremerShape2.FillColor = System.Drawing.SystemColors.Control
        Me.KremerShape2.FillColorOn = System.Drawing.SystemColors.Control
        Me.KremerShape2.FillDirection = KremerControlsWin32.KremerShape.Direction.Up
        Me.KremerShape2.FillLevel = 100.0!
        Me.KremerShape2.FillMaximum = 100.0!
        Me.KremerShape2.FillMinimum = 0!
        Me.KremerShape2.Line = True
        Me.KremerShape2.LineColor = System.Drawing.Color.Black
        Me.KremerShape2.LineColorOn = System.Drawing.Color.Black
        Me.KremerShape2.LineSize = 1
        Me.KremerShape2.Location = New System.Drawing.Point(545, 237)
        Me.KremerShape2.Name = "KremerShape2"
        Me.KremerShape2.Size = New System.Drawing.Size(15, 15)
        Me.KremerShape2.Style = KremerControlsWin32.KremerShape.LineStyle.Solid
        Me.KremerShape2.TabIndex = 262
        Me.KremerShape2.Text = "KremerShape2"
        Me.KremerShape2.Type = KremerControlsWin32.KremerShape.ShapeType.TriangleDown
        '
        'SupplyVleft
        '
        Me.SupplyVleft.Data = False
        Me.SupplyVleft.Fill = False
        Me.SupplyVleft.FillColor = System.Drawing.SystemColors.Control
        Me.SupplyVleft.FillColorOn = System.Drawing.SystemColors.Control
        Me.SupplyVleft.FillDirection = KremerControlsWin32.KremerShape.Direction.Up
        Me.SupplyVleft.FillLevel = 100.0!
        Me.SupplyVleft.FillMaximum = 100.0!
        Me.SupplyVleft.FillMinimum = 0!
        Me.SupplyVleft.Line = True
        Me.SupplyVleft.LineColor = System.Drawing.Color.Black
        Me.SupplyVleft.LineColorOn = System.Drawing.Color.Black
        Me.SupplyVleft.LineSize = 1
        Me.SupplyVleft.Location = New System.Drawing.Point(125, 263)
        Me.SupplyVleft.Name = "SupplyVleft"
        Me.SupplyVleft.Size = New System.Drawing.Size(25, 25)
        Me.SupplyVleft.Style = KremerControlsWin32.KremerShape.LineStyle.Solid
        Me.SupplyVleft.TabIndex = 264
        Me.SupplyVleft.Text = "KremerShape3"
        Me.SupplyVleft.Type = KremerControlsWin32.KremerShape.ShapeType.TriangleRight
        '
        'KremerShape3
        '
        Me.KremerShape3.Data = False
        Me.KremerShape3.Fill = False
        Me.KremerShape3.FillColor = System.Drawing.SystemColors.Control
        Me.KremerShape3.FillColorOn = System.Drawing.SystemColors.Control
        Me.KremerShape3.FillDirection = KremerControlsWin32.KremerShape.Direction.Up
        Me.KremerShape3.FillLevel = 100.0!
        Me.KremerShape3.FillMaximum = 100.0!
        Me.KremerShape3.FillMinimum = 0!
        Me.KremerShape3.Line = True
        Me.KremerShape3.LineColor = System.Drawing.Color.Black
        Me.KremerShape3.LineColorOn = System.Drawing.Color.Black
        Me.KremerShape3.LineSize = 1
        Me.KremerShape3.Location = New System.Drawing.Point(148, 263)
        Me.KremerShape3.Name = "KremerShape3"
        Me.KremerShape3.Size = New System.Drawing.Size(25, 25)
        Me.KremerShape3.Style = KremerControlsWin32.KremerShape.LineStyle.Solid
        Me.KremerShape3.TabIndex = 265
        Me.KremerShape3.Text = "KremerShape3"
        Me.KremerShape3.Type = KremerControlsWin32.KremerShape.ShapeType.TriangleLeft
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
        Me.Btn_Overview.Location = New System.Drawing.Point(685, 270)
        Me.Btn_Overview.Name = "Btn_Overview"
        Me.Btn_Overview.Size = New System.Drawing.Size(114, 50)
        Me.Btn_Overview.State = False
        Me.Btn_Overview.StateIsData = True
        Me.Btn_Overview.StateText = New String() {Nothing, Nothing}
        Me.Btn_Overview.TabIndex = 274
        Me.Btn_Overview.Tag = "194"
        Me.Btn_Overview.Text = "Overview"
        Me.Btn_Overview.UserInfo = Nothing
        Me.Btn_Overview.UserLevel = 0
        Me.Btn_Overview.UseStateText = False
        Me.Btn_Overview.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(558, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 23)
        Me.Label3.TabIndex = 315
        Me.Label3.Tag = "118"
        Me.Label3.Text = "Position"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label4.Location = New System.Drawing.Point(559, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 320
        Me.Label4.Tag = ""
        Me.Label4.Text = "Rod side:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label5.Location = New System.Drawing.Point(559, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 17)
        Me.Label5.TabIndex = 318
        Me.Label5.Tag = ""
        Me.Label5.Text = "Bottom side:"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(558, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 23)
        Me.Label10.TabIndex = 317
        Me.Label10.Tag = "93"
        Me.Label10.Text = "Pressure"
        '
        'MachinePond_Overview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.IO_RodSide)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.IO_BotSide)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Controls.Add(Me.KremerShape3)
        Me.Controls.Add(Me.SupplyVleft)
        Me.Controls.Add(Me.ioPondPos)
        Me.Controls.Add(Me.KremerShape2)
        Me.Controls.Add(Me.KremerShape1)
        Me.Controls.Add(Me.Pnl_Status_init)
        Me.Controls.Add(Me.Btn_Settings)
        Me.Controls.Add(Me.Btn_Manual)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "MachinePond_Overview"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "87"
        Me.Pnl_Status_init.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Pnl_Status_init As System.Windows.Forms.Panel
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Btn_Settings As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_Manual As KremerControlsWin32.KremerButton
    Friend WithEvents State_PushA As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents KremerShape1 As KremerControlsWin32.KremerShape
    Friend WithEvents KremerShape2 As KremerControlsWin32.KremerShape
    Friend WithEvents ioPondPos As KremerControlsWin32.KremerIoField
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents SupplyVleft As KremerControlsWin32.KremerShape
    Friend WithEvents KremerShape3 As KremerControlsWin32.KremerShape
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents KremerStatusBox1 As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PondPosition As KremerControlsWin32.KremerVariable
    Friend WithEvents mxAutoMode As KremerControlsWin32.KremerVariable
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RodSidePressure As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_RodSide As KremerControlsWin32.KremerIoField
    Friend WithEvents BotSidePressure As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_BotSide As KremerControlsWin32.KremerIoField
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
