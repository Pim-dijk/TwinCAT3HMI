<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZeroAbsEncoder
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
        Me.io_GantryAHor_Pos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Btn_ZeroGantryAHor = New KremerControlsWin32.KremerButton()
        Me.lbl_puh = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LiftLine = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.io_GantryAVert_Pos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Btn_ZeroGantryAVert = New KremerControlsWin32.KremerButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.krVarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.GA_HorZero = New KremerControlsWin32.KremerVariable(Me.components)
        Me.GA_VertZero = New KremerControlsWin32.KremerVariable(Me.components)
        Me.GB_HorZero = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnZeroGantryBHor = New KremerControlsWin32.KremerButton()
        Me.GB_VertZero = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnZeroGantryBVert = New KremerControlsWin32.KremerButton()
        Me.BMA_Zero = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnZeroBMA = New KremerControlsWin32.KremerButton()
        Me.BMB_Zero = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BtnZeroBMB = New KremerControlsWin32.KremerButton()
        Me.SB_Zero = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_ZeroSB = New KremerControlsWin32.KremerButton()
        Me.PC_Zero = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_ZeroPc = New KremerControlsWin32.KremerButton()
        Me.GA_HorDone = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plGantryAHorDone = New KremerControlsWin32.KremerLight()
        Me.GA_VerDone = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plGantryAVertDone = New KremerControlsWin32.KremerLight()
        Me.GB_HorDone = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plGantryBHorDone = New KremerControlsWin32.KremerLight()
        Me.GB_VertDone = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plGantryBVertDone = New KremerControlsWin32.KremerLight()
        Me.BMA_Done = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plBMADone = New KremerControlsWin32.KremerLight()
        Me.BMB_Done = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plBMBDone = New KremerControlsWin32.KremerLight()
        Me.SP_Done = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plSbDone = New KremerControlsWin32.KremerLight()
        Me.PC_Done = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plPcDone = New KremerControlsWin32.KremerLight()
        Me.GA_Hor_AxDis = New KremerControlsWin32.KremerVariable(Me.components)
        Me.GA_Vert_AxDis = New KremerControlsWin32.KremerVariable(Me.components)
        Me.GB_Hor_AxDis = New KremerControlsWin32.KremerVariable(Me.components)
        Me.GB_Vert_AxDis = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BMA_AxDis = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BMB_AxDis = New KremerControlsWin32.KremerVariable(Me.components)
        Me.SB_AxDis = New KremerControlsWin32.KremerVariable(Me.components)
        Me.PC_AxDis = New KremerControlsWin32.KremerVariable(Me.components)
        Me.GA_HorPos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.GA_VertPos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.GB_HorPos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_GantryBHorActPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.GB_VertPos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_GantryBVertActPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.BMA_Pos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_BMAActPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.BMB_Pos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_BMBActPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.SB_Pos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.io_SBPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PC_Pos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.io_PcPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.GA_VertHomePos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_HomingPosVertA = New KremerControlsWin32.KremerIoField(Me.components)
        Me.GB_VertHomePos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IOHomingPosVertB = New KremerControlsWin32.KremerIoField(Me.components)
        Me.GA_HorHomePos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IOHomePosHorA = New KremerControlsWin32.KremerIoField(Me.components)
        Me.GB_HorHomePos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IOHomePosHorB = New KremerControlsWin32.KremerIoField(Me.components)
        Me.SB_HomePos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_SBZeroPosValue = New KremerControlsWin32.KremerIoField(Me.components)
        Me.BMA_HomePos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IOHomingPosBMA = New KremerControlsWin32.KremerIoField(Me.components)
        Me.BMB_HomePos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IOHomingPosBMB = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'io_GantryAHor_Pos
        '
        Me.io_GantryAHor_Pos.Audit = Nothing
        Me.io_GantryAHor_Pos.AuditEnabled = False
        Me.io_GantryAHor_Pos.AuditMessage = "KremerIoField changed:"
        Me.io_GantryAHor_Pos.AuditSource = "KremerIoField"
        Me.io_GantryAHor_Pos.Data = 0.0R
        Me.io_GantryAHor_Pos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.io_GantryAHor_Pos.InitialValue = True
        Me.io_GantryAHor_Pos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.io_GantryAHor_Pos.Location = New System.Drawing.Point(310, 52)
        Me.io_GantryAHor_Pos.LowerBound = 0.0R
        Me.io_GantryAHor_Pos.Name = "io_GantryAHor_Pos"
        Me.io_GantryAHor_Pos.OutputFormat = "0.0 mm"
        Me.io_GantryAHor_Pos.Size = New System.Drawing.Size(71, 21)
        Me.io_GantryAHor_Pos.TabIndex = 319
        Me.io_GantryAHor_Pos.Text = "0.0 mm"
        Me.io_GantryAHor_Pos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.io_GantryAHor_Pos.UpperBound = 180.0R
        Me.io_GantryAHor_Pos.UserInfo = Nothing
        Me.io_GantryAHor_Pos.UserLevel = 999
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(16, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(234, 27)
        Me.Label9.TabIndex = 318
        Me.Label9.Tag = "170"
        Me.Label9.Text = "Zero Encoder:"
        '
        'Btn_ZeroGantryAHor
        '
        Me.Btn_ZeroGantryAHor.Audit = Nothing
        Me.Btn_ZeroGantryAHor.AuditEnabled = False
        Me.Btn_ZeroGantryAHor.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_ZeroGantryAHor.AuditSource = "KremerPushButton"
        Me.Btn_ZeroGantryAHor.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_ZeroGantryAHor.BackGroundImageOn = Nothing
        Me.Btn_ZeroGantryAHor.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_ZeroGantryAHor.Data = False
        Me.Btn_ZeroGantryAHor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ZeroGantryAHor.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_ZeroGantryAHor.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_ZeroGantryAHor.Location = New System.Drawing.Point(26, 80)
        Me.Btn_ZeroGantryAHor.Name = "Btn_ZeroGantryAHor"
        Me.Btn_ZeroGantryAHor.Size = New System.Drawing.Size(106, 36)
        Me.Btn_ZeroGantryAHor.State = False
        Me.Btn_ZeroGantryAHor.StateIsData = False
        Me.Btn_ZeroGantryAHor.StateText = New String() {Nothing, Nothing}
        Me.Btn_ZeroGantryAHor.TabIndex = 317
        Me.Btn_ZeroGantryAHor.Tag = ""
        Me.Btn_ZeroGantryAHor.Text = "Zero"
        Me.Btn_ZeroGantryAHor.UserInfo = Nothing
        Me.Btn_ZeroGantryAHor.UserLevel = 500
        Me.Btn_ZeroGantryAHor.UseStateText = False
        Me.Btn_ZeroGantryAHor.UseVisualStyleBackColor = False
        '
        'lbl_puh
        '
        Me.lbl_puh.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_puh.Location = New System.Drawing.Point(21, 54)
        Me.lbl_puh.Name = "lbl_puh"
        Me.lbl_puh.Size = New System.Drawing.Size(286, 23)
        Me.lbl_puh.TabIndex = 320
        Me.lbl_puh.Tag = ""
        Me.lbl_puh.Text = "Gantry A Horizontal:"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape7, Me.LineShape6, Me.LineShape5, Me.LineShape4, Me.LineShape3, Me.LineShape1, Me.LineShape2, Me.LiftLine})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 435)
        Me.ShapeContainer1.TabIndex = 321
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape7
        '
        Me.LineShape7.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 429
        Me.LineShape7.X2 = 789
        Me.LineShape7.Y1 = 215
        Me.LineShape7.Y2 = 215
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 430
        Me.LineShape6.X2 = 790
        Me.LineShape6.Y1 = 300
        Me.LineShape6.Y2 = 300
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 428
        Me.LineShape5.X2 = 788
        Me.LineShape5.Y1 = 129
        Me.LineShape5.Y2 = 129
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 427
        Me.LineShape4.X2 = 787
        Me.LineShape4.Y1 = 44
        Me.LineShape4.Y2 = 44
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 10
        Me.LineShape3.X2 = 370
        Me.LineShape3.Y1 = 306
        Me.LineShape3.Y2 = 306
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 16
        Me.LineShape1.X2 = 376
        Me.LineShape1.Y1 = 215
        Me.LineShape1.Y2 = 215
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 13
        Me.LineShape2.X2 = 373
        Me.LineShape2.Y1 = 129
        Me.LineShape2.Y2 = 129
        '
        'LiftLine
        '
        Me.LiftLine.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LiftLine.Name = "LiftLine"
        Me.LiftLine.X1 = 14
        Me.LiftLine.X2 = 374
        Me.LiftLine.Y1 = 44
        Me.LiftLine.Y2 = 44
        '
        'io_GantryAVert_Pos
        '
        Me.io_GantryAVert_Pos.Audit = Nothing
        Me.io_GantryAVert_Pos.AuditEnabled = False
        Me.io_GantryAVert_Pos.AuditMessage = "KremerIoField changed:"
        Me.io_GantryAVert_Pos.AuditSource = "KremerIoField"
        Me.io_GantryAVert_Pos.Data = 0.0R
        Me.io_GantryAVert_Pos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.io_GantryAVert_Pos.InitialValue = True
        Me.io_GantryAVert_Pos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.io_GantryAVert_Pos.Location = New System.Drawing.Point(310, 140)
        Me.io_GantryAVert_Pos.LowerBound = 0.0R
        Me.io_GantryAVert_Pos.Name = "io_GantryAVert_Pos"
        Me.io_GantryAVert_Pos.OutputFormat = "0.0 mm"
        Me.io_GantryAVert_Pos.Size = New System.Drawing.Size(71, 21)
        Me.io_GantryAVert_Pos.TabIndex = 324
        Me.io_GantryAVert_Pos.Text = "0,0 mm"
        Me.io_GantryAVert_Pos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.io_GantryAVert_Pos.UpperBound = 1000.0R
        Me.io_GantryAVert_Pos.UserInfo = Nothing
        Me.io_GantryAVert_Pos.UserLevel = 999
        '
        'Btn_ZeroGantryAVert
        '
        Me.Btn_ZeroGantryAVert.Audit = Nothing
        Me.Btn_ZeroGantryAVert.AuditEnabled = False
        Me.Btn_ZeroGantryAVert.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_ZeroGantryAVert.AuditSource = "KremerPushButton"
        Me.Btn_ZeroGantryAVert.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_ZeroGantryAVert.BackGroundImageOn = Nothing
        Me.Btn_ZeroGantryAVert.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_ZeroGantryAVert.Data = False
        Me.Btn_ZeroGantryAVert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ZeroGantryAVert.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_ZeroGantryAVert.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_ZeroGantryAVert.Location = New System.Drawing.Point(26, 164)
        Me.Btn_ZeroGantryAVert.Name = "Btn_ZeroGantryAVert"
        Me.Btn_ZeroGantryAVert.Size = New System.Drawing.Size(106, 36)
        Me.Btn_ZeroGantryAVert.State = False
        Me.Btn_ZeroGantryAVert.StateIsData = False
        Me.Btn_ZeroGantryAVert.StateText = New String() {Nothing, Nothing}
        Me.Btn_ZeroGantryAVert.TabIndex = 322
        Me.Btn_ZeroGantryAVert.Tag = ""
        Me.Btn_ZeroGantryAVert.Text = "Zero"
        Me.Btn_ZeroGantryAVert.UserInfo = Nothing
        Me.Btn_ZeroGantryAVert.UserLevel = 500
        Me.Btn_ZeroGantryAVert.UseStateText = False
        Me.Btn_ZeroGantryAVert.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(21, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 23)
        Me.Label1.TabIndex = 325
        Me.Label1.Tag = ""
        Me.Label1.Text = "Gantry A Vertical"
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'krVarCollector
        '
        Me.krVarCollector.Variables.Add(Me.GA_HorZero)
        Me.krVarCollector.Variables.Add(Me.GA_VertZero)
        Me.krVarCollector.Variables.Add(Me.GB_HorZero)
        Me.krVarCollector.Variables.Add(Me.GB_VertZero)
        Me.krVarCollector.Variables.Add(Me.BMA_Zero)
        Me.krVarCollector.Variables.Add(Me.BMB_Zero)
        Me.krVarCollector.Variables.Add(Me.SB_Zero)
        Me.krVarCollector.Variables.Add(Me.PC_Zero)
        Me.krVarCollector.Variables.Add(Me.GA_HorDone)
        Me.krVarCollector.Variables.Add(Me.GA_VerDone)
        Me.krVarCollector.Variables.Add(Me.GB_HorDone)
        Me.krVarCollector.Variables.Add(Me.GB_VertDone)
        Me.krVarCollector.Variables.Add(Me.BMA_Done)
        Me.krVarCollector.Variables.Add(Me.BMB_Done)
        Me.krVarCollector.Variables.Add(Me.SP_Done)
        Me.krVarCollector.Variables.Add(Me.PC_Done)
        Me.krVarCollector.Variables.Add(Me.GA_Hor_AxDis)
        Me.krVarCollector.Variables.Add(Me.GA_Vert_AxDis)
        Me.krVarCollector.Variables.Add(Me.GB_Hor_AxDis)
        Me.krVarCollector.Variables.Add(Me.GB_Vert_AxDis)
        Me.krVarCollector.Variables.Add(Me.BMA_AxDis)
        Me.krVarCollector.Variables.Add(Me.BMB_AxDis)
        Me.krVarCollector.Variables.Add(Me.SB_AxDis)
        Me.krVarCollector.Variables.Add(Me.PC_AxDis)
        Me.krVarCollector.Variables.Add(Me.GA_HorPos)
        Me.krVarCollector.Variables.Add(Me.GA_VertPos)
        Me.krVarCollector.Variables.Add(Me.GB_HorPos)
        Me.krVarCollector.Variables.Add(Me.GB_VertPos)
        Me.krVarCollector.Variables.Add(Me.BMA_Pos)
        Me.krVarCollector.Variables.Add(Me.BMB_Pos)
        Me.krVarCollector.Variables.Add(Me.SB_Pos)
        Me.krVarCollector.Variables.Add(Me.PC_Pos)
        Me.krVarCollector.Variables.Add(Me.GA_VertHomePos)
        Me.krVarCollector.Variables.Add(Me.GB_VertHomePos)
        Me.krVarCollector.Variables.Add(Me.GA_HorHomePos)
        Me.krVarCollector.Variables.Add(Me.GB_HorHomePos)
        Me.krVarCollector.Variables.Add(Me.SB_HomePos)
        Me.krVarCollector.Variables.Add(Me.BMA_HomePos)
        Me.krVarCollector.Variables.Add(Me.BMB_HomePos)
        '
        'GA_HorZero
        '
        Me.GA_HorZero.BindControl = Me.Btn_ZeroGantryAHor
        Me.GA_HorZero.BindProperty = "Data"
        Me.GA_HorZero.Data = Nothing
        Me.GA_HorZero.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GA_HorZero.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GA_HorZero.VariableName = "MAIN.ProductHandling.GantryA.HorizontalAxis.mxZeroCommand"
        '
        'GA_VertZero
        '
        Me.GA_VertZero.BindControl = Me.Btn_ZeroGantryAVert
        Me.GA_VertZero.BindProperty = "Data"
        Me.GA_VertZero.Data = Nothing
        Me.GA_VertZero.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GA_VertZero.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GA_VertZero.VariableName = "MAIN.ProductHandling.GantryA.VerticalAxis.mxZeroCommand"
        '
        'GB_HorZero
        '
        Me.GB_HorZero.BindControl = Me.BtnZeroGantryBHor
        Me.GB_HorZero.BindProperty = "Data"
        Me.GB_HorZero.Data = Nothing
        Me.GB_HorZero.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GB_HorZero.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GB_HorZero.VariableName = "MAIN.ProductHandling.GantryB.HorizontalAxis.mxZeroCommand"
        '
        'BtnZeroGantryBHor
        '
        Me.BtnZeroGantryBHor.Audit = Nothing
        Me.BtnZeroGantryBHor.AuditEnabled = False
        Me.BtnZeroGantryBHor.AuditMessage = "KremerPushButton pressed!"
        Me.BtnZeroGantryBHor.AuditSource = "KremerPushButton"
        Me.BtnZeroGantryBHor.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnZeroGantryBHor.BackGroundImageOn = Nothing
        Me.BtnZeroGantryBHor.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnZeroGantryBHor.Data = False
        Me.BtnZeroGantryBHor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnZeroGantryBHor.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnZeroGantryBHor.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnZeroGantryBHor.Location = New System.Drawing.Point(444, 80)
        Me.BtnZeroGantryBHor.Name = "BtnZeroGantryBHor"
        Me.BtnZeroGantryBHor.Size = New System.Drawing.Size(106, 36)
        Me.BtnZeroGantryBHor.State = False
        Me.BtnZeroGantryBHor.StateIsData = False
        Me.BtnZeroGantryBHor.StateText = New String() {Nothing, Nothing}
        Me.BtnZeroGantryBHor.TabIndex = 357
        Me.BtnZeroGantryBHor.Tag = ""
        Me.BtnZeroGantryBHor.Text = "Zero"
        Me.BtnZeroGantryBHor.UserInfo = Nothing
        Me.BtnZeroGantryBHor.UserLevel = 500
        Me.BtnZeroGantryBHor.UseStateText = False
        Me.BtnZeroGantryBHor.UseVisualStyleBackColor = False
        '
        'GB_VertZero
        '
        Me.GB_VertZero.BindControl = Me.BtnZeroGantryBVert
        Me.GB_VertZero.BindProperty = "Data"
        Me.GB_VertZero.Data = Nothing
        Me.GB_VertZero.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GB_VertZero.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GB_VertZero.VariableName = "MAIN.ProductHandling.GantryB.VerticalAxis.mxZeroCommand"
        '
        'BtnZeroGantryBVert
        '
        Me.BtnZeroGantryBVert.Audit = Nothing
        Me.BtnZeroGantryBVert.AuditEnabled = False
        Me.BtnZeroGantryBVert.AuditMessage = "KremerPushButton pressed!"
        Me.BtnZeroGantryBVert.AuditSource = "KremerPushButton"
        Me.BtnZeroGantryBVert.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnZeroGantryBVert.BackGroundImageOn = Nothing
        Me.BtnZeroGantryBVert.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnZeroGantryBVert.Data = False
        Me.BtnZeroGantryBVert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnZeroGantryBVert.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnZeroGantryBVert.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnZeroGantryBVert.Location = New System.Drawing.Point(444, 164)
        Me.BtnZeroGantryBVert.Name = "BtnZeroGantryBVert"
        Me.BtnZeroGantryBVert.Size = New System.Drawing.Size(106, 36)
        Me.BtnZeroGantryBVert.State = False
        Me.BtnZeroGantryBVert.StateIsData = False
        Me.BtnZeroGantryBVert.StateText = New String() {Nothing, Nothing}
        Me.BtnZeroGantryBVert.TabIndex = 361
        Me.BtnZeroGantryBVert.Tag = ""
        Me.BtnZeroGantryBVert.Text = "Zero"
        Me.BtnZeroGantryBVert.UserInfo = Nothing
        Me.BtnZeroGantryBVert.UserLevel = 500
        Me.BtnZeroGantryBVert.UseStateText = False
        Me.BtnZeroGantryBVert.UseVisualStyleBackColor = False
        '
        'BMA_Zero
        '
        Me.BMA_Zero.BindControl = Me.BtnZeroBMA
        Me.BMA_Zero.BindProperty = "Data"
        Me.BMA_Zero.Data = Nothing
        Me.BMA_Zero.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BMA_Zero.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMA_Zero.VariableName = "MAIN.InMoldDrying.BottomMoldA.HorizontalAxis.mxZeroCommand"
        '
        'BtnZeroBMA
        '
        Me.BtnZeroBMA.Audit = Nothing
        Me.BtnZeroBMA.AuditEnabled = False
        Me.BtnZeroBMA.AuditMessage = "KremerPushButton pressed!"
        Me.BtnZeroBMA.AuditSource = "KremerPushButton"
        Me.BtnZeroBMA.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnZeroBMA.BackGroundImageOn = Nothing
        Me.BtnZeroBMA.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnZeroBMA.Data = False
        Me.BtnZeroBMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnZeroBMA.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnZeroBMA.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnZeroBMA.Location = New System.Drawing.Point(444, 254)
        Me.BtnZeroBMA.Name = "BtnZeroBMA"
        Me.BtnZeroBMA.Size = New System.Drawing.Size(106, 36)
        Me.BtnZeroBMA.State = False
        Me.BtnZeroBMA.StateIsData = False
        Me.BtnZeroBMA.StateText = New String() {Nothing, Nothing}
        Me.BtnZeroBMA.TabIndex = 375
        Me.BtnZeroBMA.Tag = ""
        Me.BtnZeroBMA.Text = "Zero"
        Me.BtnZeroBMA.UserInfo = Nothing
        Me.BtnZeroBMA.UserLevel = 500
        Me.BtnZeroBMA.UseStateText = False
        Me.BtnZeroBMA.UseVisualStyleBackColor = False
        '
        'BMB_Zero
        '
        Me.BMB_Zero.BindControl = Me.BtnZeroBMB
        Me.BMB_Zero.BindProperty = "Data"
        Me.BMB_Zero.Data = Nothing
        Me.BMB_Zero.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BMB_Zero.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMB_Zero.VariableName = "MAIN.InMoldDrying.BottomMoldB.HorizontalAxis.mxZeroCommand"
        '
        'BtnZeroBMB
        '
        Me.BtnZeroBMB.Audit = Nothing
        Me.BtnZeroBMB.AuditEnabled = False
        Me.BtnZeroBMB.AuditMessage = "KremerPushButton pressed!"
        Me.BtnZeroBMB.AuditSource = "KremerPushButton"
        Me.BtnZeroBMB.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnZeroBMB.BackGroundImageOn = Nothing
        Me.BtnZeroBMB.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.BtnZeroBMB.Data = False
        Me.BtnZeroBMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnZeroBMB.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnZeroBMB.ForeColorOn = System.Drawing.Color.Yellow
        Me.BtnZeroBMB.Location = New System.Drawing.Point(444, 346)
        Me.BtnZeroBMB.Name = "BtnZeroBMB"
        Me.BtnZeroBMB.Size = New System.Drawing.Size(106, 36)
        Me.BtnZeroBMB.State = False
        Me.BtnZeroBMB.StateIsData = False
        Me.BtnZeroBMB.StateText = New String() {Nothing, Nothing}
        Me.BtnZeroBMB.TabIndex = 381
        Me.BtnZeroBMB.Tag = ""
        Me.BtnZeroBMB.Text = "Zero"
        Me.BtnZeroBMB.UserInfo = Nothing
        Me.BtnZeroBMB.UserLevel = 500
        Me.BtnZeroBMB.UseStateText = False
        Me.BtnZeroBMB.UseVisualStyleBackColor = False
        '
        'SB_Zero
        '
        Me.SB_Zero.BindControl = Me.Btn_ZeroSB
        Me.SB_Zero.BindProperty = "Data"
        Me.SB_Zero.Data = Nothing
        Me.SB_Zero.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.SB_Zero.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SB_Zero.VariableName = "MAIN.InMoldDrying.ProductForming.SprayBarMotor.mxZeroCommand"
        '
        'Btn_ZeroSB
        '
        Me.Btn_ZeroSB.Audit = Nothing
        Me.Btn_ZeroSB.AuditEnabled = False
        Me.Btn_ZeroSB.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_ZeroSB.AuditSource = "KremerPushButton"
        Me.Btn_ZeroSB.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_ZeroSB.BackGroundImageOn = Nothing
        Me.Btn_ZeroSB.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_ZeroSB.Data = False
        Me.Btn_ZeroSB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ZeroSB.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_ZeroSB.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_ZeroSB.Location = New System.Drawing.Point(26, 254)
        Me.Btn_ZeroSB.Name = "Btn_ZeroSB"
        Me.Btn_ZeroSB.Size = New System.Drawing.Size(106, 36)
        Me.Btn_ZeroSB.State = False
        Me.Btn_ZeroSB.StateIsData = False
        Me.Btn_ZeroSB.StateText = New String() {Nothing, Nothing}
        Me.Btn_ZeroSB.TabIndex = 353
        Me.Btn_ZeroSB.Tag = ""
        Me.Btn_ZeroSB.Text = "Zero"
        Me.Btn_ZeroSB.UserInfo = Nothing
        Me.Btn_ZeroSB.UserLevel = 500
        Me.Btn_ZeroSB.UseStateText = False
        Me.Btn_ZeroSB.UseVisualStyleBackColor = False
        '
        'PC_Zero
        '
        Me.PC_Zero.BindControl = Me.Btn_ZeroPc
        Me.PC_Zero.BindProperty = "Data"
        Me.PC_Zero.Data = Nothing
        Me.PC_Zero.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PC_Zero.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PC_Zero.VariableName = "MAIN.ProductHandling.OutfeedConveyor.Belt.mxZeroCommand"
        '
        'Btn_ZeroPc
        '
        Me.Btn_ZeroPc.Audit = Nothing
        Me.Btn_ZeroPc.AuditEnabled = False
        Me.Btn_ZeroPc.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_ZeroPc.AuditSource = "KremerPushButton"
        Me.Btn_ZeroPc.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_ZeroPc.BackGroundImageOn = Nothing
        Me.Btn_ZeroPc.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_ZeroPc.Data = False
        Me.Btn_ZeroPc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ZeroPc.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_ZeroPc.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn_ZeroPc.Location = New System.Drawing.Point(26, 346)
        Me.Btn_ZeroPc.Name = "Btn_ZeroPc"
        Me.Btn_ZeroPc.Size = New System.Drawing.Size(106, 36)
        Me.Btn_ZeroPc.State = False
        Me.Btn_ZeroPc.StateIsData = False
        Me.Btn_ZeroPc.StateText = New String() {Nothing, Nothing}
        Me.Btn_ZeroPc.TabIndex = 349
        Me.Btn_ZeroPc.Tag = ""
        Me.Btn_ZeroPc.Text = "Zero"
        Me.Btn_ZeroPc.UserInfo = Nothing
        Me.Btn_ZeroPc.UserLevel = 500
        Me.Btn_ZeroPc.UseStateText = False
        Me.Btn_ZeroPc.UseVisualStyleBackColor = False
        '
        'GA_HorDone
        '
        Me.GA_HorDone.BindControl = Me.plGantryAHorDone
        Me.GA_HorDone.BindProperty = "Data"
        Me.GA_HorDone.Data = Nothing
        Me.GA_HorDone.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GA_HorDone.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GA_HorDone.VariableName = "MAIN.ProductHandling.GantryA.HorizontalAxis.SignalLightStatus"
        '
        'plGantryAHorDone
        '
        Me.plGantryAHorDone.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plGantryAHorDone.ColorOn = System.Drawing.Color.Lime
        Me.plGantryAHorDone.Data = False
        Me.plGantryAHorDone.Line = True
        Me.plGantryAHorDone.LineSize = 1
        Me.plGantryAHorDone.Location = New System.Drawing.Point(313, 86)
        Me.plGantryAHorDone.Name = "plGantryAHorDone"
        Me.plGantryAHorDone.Size = New System.Drawing.Size(24, 24)
        Me.plGantryAHorDone.TabIndex = 347
        Me.plGantryAHorDone.Text = "KremerLight1"
        Me.plGantryAHorDone.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'GA_VerDone
        '
        Me.GA_VerDone.BindControl = Me.plGantryAVertDone
        Me.GA_VerDone.BindProperty = "Data"
        Me.GA_VerDone.Data = Nothing
        Me.GA_VerDone.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GA_VerDone.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GA_VerDone.VariableName = "MAIN.ProductHandling.GantryA.VerticalAxis.SignalLightStatus"
        '
        'plGantryAVertDone
        '
        Me.plGantryAVertDone.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plGantryAVertDone.ColorOn = System.Drawing.Color.Lime
        Me.plGantryAVertDone.Data = False
        Me.plGantryAVertDone.Line = True
        Me.plGantryAVertDone.LineSize = 1
        Me.plGantryAVertDone.Location = New System.Drawing.Point(313, 171)
        Me.plGantryAVertDone.Name = "plGantryAVertDone"
        Me.plGantryAVertDone.Size = New System.Drawing.Size(24, 24)
        Me.plGantryAVertDone.TabIndex = 348
        Me.plGantryAVertDone.Text = "KremerLight1"
        Me.plGantryAVertDone.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'GB_HorDone
        '
        Me.GB_HorDone.BindControl = Me.plGantryBHorDone
        Me.GB_HorDone.BindProperty = "Data"
        Me.GB_HorDone.Data = Nothing
        Me.GB_HorDone.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GB_HorDone.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GB_HorDone.VariableName = "MAIN.ProductHandling.GantryB.HorizontalAxis.SignalLightStatus"
        '
        'plGantryBHorDone
        '
        Me.plGantryBHorDone.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plGantryBHorDone.ColorOn = System.Drawing.Color.Lime
        Me.plGantryBHorDone.Data = False
        Me.plGantryBHorDone.Line = True
        Me.plGantryBHorDone.LineSize = 1
        Me.plGantryBHorDone.Location = New System.Drawing.Point(731, 86)
        Me.plGantryBHorDone.Name = "plGantryBHorDone"
        Me.plGantryBHorDone.Size = New System.Drawing.Size(24, 24)
        Me.plGantryBHorDone.TabIndex = 360
        Me.plGantryBHorDone.Text = "KremerLight1"
        Me.plGantryBHorDone.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'GB_VertDone
        '
        Me.GB_VertDone.BindControl = Me.plGantryBVertDone
        Me.GB_VertDone.BindProperty = "Data"
        Me.GB_VertDone.Data = Nothing
        Me.GB_VertDone.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GB_VertDone.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GB_VertDone.VariableName = "MAIN.ProductHandling.GantryB.VerticalAxis.SignalLightStatus"
        '
        'plGantryBVertDone
        '
        Me.plGantryBVertDone.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plGantryBVertDone.ColorOn = System.Drawing.Color.Lime
        Me.plGantryBVertDone.Data = False
        Me.plGantryBVertDone.Line = True
        Me.plGantryBVertDone.LineSize = 1
        Me.plGantryBVertDone.Location = New System.Drawing.Point(731, 171)
        Me.plGantryBVertDone.Name = "plGantryBVertDone"
        Me.plGantryBVertDone.Size = New System.Drawing.Size(24, 24)
        Me.plGantryBVertDone.TabIndex = 364
        Me.plGantryBVertDone.Text = "KremerLight1"
        Me.plGantryBVertDone.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BMA_Done
        '
        Me.BMA_Done.BindControl = Me.plBMADone
        Me.BMA_Done.BindProperty = "Data"
        Me.BMA_Done.Data = Nothing
        Me.BMA_Done.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BMA_Done.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMA_Done.VariableName = "MAIN.InMoldDrying.BottomMoldA.HorizontalAxis.SignalLightStatus"
        '
        'plBMADone
        '
        Me.plBMADone.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plBMADone.ColorOn = System.Drawing.Color.Lime
        Me.plBMADone.Data = False
        Me.plBMADone.Line = True
        Me.plBMADone.LineSize = 1
        Me.plBMADone.Location = New System.Drawing.Point(731, 261)
        Me.plBMADone.Name = "plBMADone"
        Me.plBMADone.Size = New System.Drawing.Size(24, 24)
        Me.plBMADone.TabIndex = 378
        Me.plBMADone.Text = "KremerLight1"
        Me.plBMADone.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'BMB_Done
        '
        Me.BMB_Done.BindControl = Me.plBMBDone
        Me.BMB_Done.BindProperty = "Data"
        Me.BMB_Done.Data = Nothing
        Me.BMB_Done.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BMB_Done.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMB_Done.VariableName = "MAIN.InMoldDrying.BottomMoldB.HorizontalAxis.SignalLightStatus"
        '
        'plBMBDone
        '
        Me.plBMBDone.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plBMBDone.ColorOn = System.Drawing.Color.Lime
        Me.plBMBDone.Data = False
        Me.plBMBDone.Line = True
        Me.plBMBDone.LineSize = 1
        Me.plBMBDone.Location = New System.Drawing.Point(731, 353)
        Me.plBMBDone.Name = "plBMBDone"
        Me.plBMBDone.Size = New System.Drawing.Size(24, 24)
        Me.plBMBDone.TabIndex = 384
        Me.plBMBDone.Text = "KremerLight1"
        Me.plBMBDone.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'SP_Done
        '
        Me.SP_Done.BindControl = Me.plSbDone
        Me.SP_Done.BindProperty = "Data"
        Me.SP_Done.Data = Nothing
        Me.SP_Done.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.SP_Done.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SP_Done.VariableName = "MAIN.InMoldDrying.ProductForming.SprayBarMotor.SignalLightStatus"
        '
        'plSbDone
        '
        Me.plSbDone.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plSbDone.ColorOn = System.Drawing.Color.Lime
        Me.plSbDone.Data = False
        Me.plSbDone.Line = True
        Me.plSbDone.LineSize = 1
        Me.plSbDone.Location = New System.Drawing.Point(313, 258)
        Me.plSbDone.Name = "plSbDone"
        Me.plSbDone.Size = New System.Drawing.Size(24, 24)
        Me.plSbDone.TabIndex = 352
        Me.plSbDone.Text = "KremerLight1"
        Me.plSbDone.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'PC_Done
        '
        Me.PC_Done.BindControl = Me.plPcDone
        Me.PC_Done.BindProperty = "Data"
        Me.PC_Done.Data = Nothing
        Me.PC_Done.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PC_Done.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PC_Done.VariableName = "MAIN.ProductHandling.OutfeedConveyor.Belt.SignalLightStatus"
        '
        'plPcDone
        '
        Me.plPcDone.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plPcDone.ColorOn = System.Drawing.Color.Lime
        Me.plPcDone.Data = False
        Me.plPcDone.Line = True
        Me.plPcDone.LineSize = 1
        Me.plPcDone.Location = New System.Drawing.Point(313, 350)
        Me.plPcDone.Name = "plPcDone"
        Me.plPcDone.Size = New System.Drawing.Size(24, 24)
        Me.plPcDone.TabIndex = 356
        Me.plPcDone.Text = "KremerLight1"
        Me.plPcDone.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'GA_Hor_AxDis
        '
        Me.GA_Hor_AxDis.BindControl = Nothing
        Me.GA_Hor_AxDis.BindProperty = "Data"
        Me.GA_Hor_AxDis.Data = Nothing
        Me.GA_Hor_AxDis.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GA_Hor_AxDis.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GA_Hor_AxDis.VariableName = "MAIN.ProductHandling.GantryA.HorizontalAxis.axAxis.Status.Disabled"
        '
        'GA_Vert_AxDis
        '
        Me.GA_Vert_AxDis.BindControl = Nothing
        Me.GA_Vert_AxDis.BindProperty = "Data"
        Me.GA_Vert_AxDis.Data = Nothing
        Me.GA_Vert_AxDis.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GA_Vert_AxDis.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GA_Vert_AxDis.VariableName = "MAIN.ProductHandling.GantryA.VerticalAxis.axAxis.Status.Disabled"
        '
        'GB_Hor_AxDis
        '
        Me.GB_Hor_AxDis.BindControl = Nothing
        Me.GB_Hor_AxDis.BindProperty = "Data"
        Me.GB_Hor_AxDis.Data = Nothing
        Me.GB_Hor_AxDis.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GB_Hor_AxDis.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GB_Hor_AxDis.VariableName = "MAIN.ProductHandling.GantryB.HorizontalAxis.axAxis.Status.Disabled"
        '
        'GB_Vert_AxDis
        '
        Me.GB_Vert_AxDis.BindControl = Nothing
        Me.GB_Vert_AxDis.BindProperty = "Data"
        Me.GB_Vert_AxDis.Data = Nothing
        Me.GB_Vert_AxDis.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.GB_Vert_AxDis.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GB_Vert_AxDis.VariableName = "MAIN.ProductHandling.GantryB.VerticalAxis.axAxis.Status.Disabled"
        '
        'BMA_AxDis
        '
        Me.BMA_AxDis.BindControl = Nothing
        Me.BMA_AxDis.BindProperty = "Data"
        Me.BMA_AxDis.Data = Nothing
        Me.BMA_AxDis.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BMA_AxDis.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMA_AxDis.VariableName = "MAIN.InMoldDrying.BottommoldA.HorizontalAxis.axAxis.Status.Disabled"
        '
        'BMB_AxDis
        '
        Me.BMB_AxDis.BindControl = Nothing
        Me.BMB_AxDis.BindProperty = "Data"
        Me.BMB_AxDis.Data = Nothing
        Me.BMB_AxDis.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BMB_AxDis.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMB_AxDis.VariableName = "MAIN.InMoldDrying.BottommoldB.HorizontalAxis.axAxis.Status.Disabled"
        '
        'SB_AxDis
        '
        Me.SB_AxDis.BindControl = Nothing
        Me.SB_AxDis.BindProperty = "Data"
        Me.SB_AxDis.Data = Nothing
        Me.SB_AxDis.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.SB_AxDis.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SB_AxDis.VariableName = "MAIN.InMoldDrying.ProductForming.SprayBarMotor.axAxis.Status.Disabled"
        '
        'PC_AxDis
        '
        Me.PC_AxDis.BindControl = Nothing
        Me.PC_AxDis.BindProperty = "Data"
        Me.PC_AxDis.Data = Nothing
        Me.PC_AxDis.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PC_AxDis.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PC_AxDis.VariableName = "MAIN.ProductHandling.OutfeedConveyor.Belt.axAxis.Status.Disabled"
        '
        'GA_HorPos
        '
        Me.GA_HorPos.BindControl = Me.io_GantryAHor_Pos
        Me.GA_HorPos.BindProperty = "Data"
        Me.GA_HorPos.Data = Nothing
        Me.GA_HorPos.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.GA_HorPos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GA_HorPos.VariableName = "MAIN.ProductHandling.GantryA.HorizontalAxis.ActPosition"
        '
        'GA_VertPos
        '
        Me.GA_VertPos.BindControl = Me.io_GantryAVert_Pos
        Me.GA_VertPos.BindProperty = "Data"
        Me.GA_VertPos.Data = Nothing
        Me.GA_VertPos.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.GA_VertPos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GA_VertPos.VariableName = "MAIN.ProductHandling.GantryA.VerticalAxis.ActPosition"
        '
        'GB_HorPos
        '
        Me.GB_HorPos.BindControl = Me.IO_GantryBHorActPos
        Me.GB_HorPos.BindProperty = "Data"
        Me.GB_HorPos.Data = Nothing
        Me.GB_HorPos.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.GB_HorPos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GB_HorPos.VariableName = "MAIN.ProductHandling.GantryB.HorizontalAxis.ActPosition"
        '
        'IO_GantryBHorActPos
        '
        Me.IO_GantryBHorActPos.Audit = Nothing
        Me.IO_GantryBHorActPos.AuditEnabled = False
        Me.IO_GantryBHorActPos.AuditMessage = "KremerIoField changed:"
        Me.IO_GantryBHorActPos.AuditSource = "KremerIoField"
        Me.IO_GantryBHorActPos.Data = 0.0R
        Me.IO_GantryBHorActPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_GantryBHorActPos.InitialValue = True
        Me.IO_GantryBHorActPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_GantryBHorActPos.Location = New System.Drawing.Point(728, 52)
        Me.IO_GantryBHorActPos.LowerBound = 0.0R
        Me.IO_GantryBHorActPos.Name = "IO_GantryBHorActPos"
        Me.IO_GantryBHorActPos.OutputFormat = "0.0 mm"
        Me.IO_GantryBHorActPos.Size = New System.Drawing.Size(71, 21)
        Me.IO_GantryBHorActPos.TabIndex = 358
        Me.IO_GantryBHorActPos.Text = "0.0 mm"
        Me.IO_GantryBHorActPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IO_GantryBHorActPos.UpperBound = 180.0R
        Me.IO_GantryBHorActPos.UserInfo = Nothing
        Me.IO_GantryBHorActPos.UserLevel = 999
        '
        'GB_VertPos
        '
        Me.GB_VertPos.BindControl = Me.IO_GantryBVertActPos
        Me.GB_VertPos.BindProperty = "Data"
        Me.GB_VertPos.Data = Nothing
        Me.GB_VertPos.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.GB_VertPos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GB_VertPos.VariableName = "MAIN.ProductHandling.GantryB.VerticalAxis.ActPosition"
        '
        'IO_GantryBVertActPos
        '
        Me.IO_GantryBVertActPos.Audit = Nothing
        Me.IO_GantryBVertActPos.AuditEnabled = False
        Me.IO_GantryBVertActPos.AuditMessage = "KremerIoField changed:"
        Me.IO_GantryBVertActPos.AuditSource = "KremerIoField"
        Me.IO_GantryBVertActPos.Data = 0.0R
        Me.IO_GantryBVertActPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_GantryBVertActPos.InitialValue = True
        Me.IO_GantryBVertActPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_GantryBVertActPos.Location = New System.Drawing.Point(723, 136)
        Me.IO_GantryBVertActPos.LowerBound = 0.0R
        Me.IO_GantryBVertActPos.Name = "IO_GantryBVertActPos"
        Me.IO_GantryBVertActPos.OutputFormat = "0.0 mm"
        Me.IO_GantryBVertActPos.Size = New System.Drawing.Size(76, 21)
        Me.IO_GantryBVertActPos.TabIndex = 362
        Me.IO_GantryBVertActPos.Text = "0,0 mm"
        Me.IO_GantryBVertActPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IO_GantryBVertActPos.UpperBound = 1000.0R
        Me.IO_GantryBVertActPos.UserInfo = Nothing
        Me.IO_GantryBVertActPos.UserLevel = 999
        '
        'BMA_Pos
        '
        Me.BMA_Pos.BindControl = Me.IO_BMAActPos
        Me.BMA_Pos.BindProperty = "Data"
        Me.BMA_Pos.Data = Nothing
        Me.BMA_Pos.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.BMA_Pos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMA_Pos.VariableName = "MAIN.InMoldDrying.BottomMoldA.HorizontalAxis.ActPosition"
        '
        'IO_BMAActPos
        '
        Me.IO_BMAActPos.Audit = Nothing
        Me.IO_BMAActPos.AuditEnabled = False
        Me.IO_BMAActPos.AuditMessage = "KremerIoField changed:"
        Me.IO_BMAActPos.AuditSource = "KremerIoField"
        Me.IO_BMAActPos.Data = 0.0R
        Me.IO_BMAActPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_BMAActPos.InitialValue = True
        Me.IO_BMAActPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_BMAActPos.Location = New System.Drawing.Point(723, 226)
        Me.IO_BMAActPos.LowerBound = 0.0R
        Me.IO_BMAActPos.Name = "IO_BMAActPos"
        Me.IO_BMAActPos.OutputFormat = "0.0 mm"
        Me.IO_BMAActPos.Size = New System.Drawing.Size(76, 21)
        Me.IO_BMAActPos.TabIndex = 376
        Me.IO_BMAActPos.Text = "0,0 mm"
        Me.IO_BMAActPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IO_BMAActPos.UpperBound = 1000.0R
        Me.IO_BMAActPos.UserInfo = Nothing
        Me.IO_BMAActPos.UserLevel = 999
        '
        'BMB_Pos
        '
        Me.BMB_Pos.BindControl = Me.IO_BMBActPos
        Me.BMB_Pos.BindProperty = "Data"
        Me.BMB_Pos.Data = Nothing
        Me.BMB_Pos.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.BMB_Pos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMB_Pos.VariableName = "MAIN.InMoldDrying.BottomMoldB.HorizontalAxis.ActPosition"
        '
        'IO_BMBActPos
        '
        Me.IO_BMBActPos.Audit = Nothing
        Me.IO_BMBActPos.AuditEnabled = False
        Me.IO_BMBActPos.AuditMessage = "KremerIoField changed:"
        Me.IO_BMBActPos.AuditSource = "KremerIoField"
        Me.IO_BMBActPos.Data = 0.0R
        Me.IO_BMBActPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_BMBActPos.InitialValue = True
        Me.IO_BMBActPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_BMBActPos.Location = New System.Drawing.Point(723, 318)
        Me.IO_BMBActPos.LowerBound = 0.0R
        Me.IO_BMBActPos.Name = "IO_BMBActPos"
        Me.IO_BMBActPos.OutputFormat = "0.0 mm"
        Me.IO_BMBActPos.Size = New System.Drawing.Size(76, 21)
        Me.IO_BMBActPos.TabIndex = 382
        Me.IO_BMBActPos.Text = "0,0 mm"
        Me.IO_BMBActPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IO_BMBActPos.UpperBound = 1000.0R
        Me.IO_BMBActPos.UserInfo = Nothing
        Me.IO_BMBActPos.UserLevel = 999
        '
        'SB_Pos
        '
        Me.SB_Pos.BindControl = Me.io_SBPos
        Me.SB_Pos.BindProperty = "Data"
        Me.SB_Pos.Data = Nothing
        Me.SB_Pos.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.SB_Pos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SB_Pos.VariableName = "MAIN.InMoldDrying.ProductForming.SprayBarMotor.ActPosition"
        '
        'io_SBPos
        '
        Me.io_SBPos.Audit = Nothing
        Me.io_SBPos.AuditEnabled = False
        Me.io_SBPos.AuditMessage = "KremerIoField changed:"
        Me.io_SBPos.AuditSource = "KremerIoField"
        Me.io_SBPos.Data = 0.0R
        Me.io_SBPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.io_SBPos.InitialValue = True
        Me.io_SBPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.io_SBPos.Location = New System.Drawing.Point(310, 230)
        Me.io_SBPos.LowerBound = 0.0R
        Me.io_SBPos.Name = "io_SBPos"
        Me.io_SBPos.OutputFormat = "0.0 mm"
        Me.io_SBPos.Size = New System.Drawing.Size(71, 21)
        Me.io_SBPos.TabIndex = 350
        Me.io_SBPos.Text = "0,0 mm"
        Me.io_SBPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.io_SBPos.UpperBound = 1000.0R
        Me.io_SBPos.UserInfo = Nothing
        Me.io_SBPos.UserLevel = 999
        '
        'PC_Pos
        '
        Me.PC_Pos.BindControl = Me.io_PcPos
        Me.PC_Pos.BindProperty = "Data"
        Me.PC_Pos.Data = Nothing
        Me.PC_Pos.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.PC_Pos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PC_Pos.VariableName = "MAIN.ProductHandling.OutfeedConveyor.Belt.ActPosition"
        '
        'io_PcPos
        '
        Me.io_PcPos.Audit = Nothing
        Me.io_PcPos.AuditEnabled = False
        Me.io_PcPos.AuditMessage = "KremerIoField changed:"
        Me.io_PcPos.AuditSource = "KremerIoField"
        Me.io_PcPos.Data = 0.0R
        Me.io_PcPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.io_PcPos.InitialValue = True
        Me.io_PcPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.io_PcPos.Location = New System.Drawing.Point(310, 322)
        Me.io_PcPos.LowerBound = 0.0R
        Me.io_PcPos.Name = "io_PcPos"
        Me.io_PcPos.OutputFormat = "0.0 mm"
        Me.io_PcPos.Size = New System.Drawing.Size(71, 21)
        Me.io_PcPos.TabIndex = 354
        Me.io_PcPos.Text = "0.0 mm"
        Me.io_PcPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.io_PcPos.UpperBound = 180.0R
        Me.io_PcPos.UserInfo = Nothing
        Me.io_PcPos.UserLevel = 999
        '
        'GA_VertHomePos
        '
        Me.GA_VertHomePos.BindControl = Me.IO_HomingPosVertA
        Me.GA_VertHomePos.BindProperty = "Data"
        Me.GA_VertHomePos.Data = Nothing
        Me.GA_VertHomePos.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.GA_VertHomePos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GA_VertHomePos.VariableName = "MAIN.ProductHandling.GantryA.MachParameters.Vert_PositionHome"
        '
        'IO_HomingPosVertA
        '
        Me.IO_HomingPosVertA.Audit = Nothing
        Me.IO_HomingPosVertA.AuditEnabled = False
        Me.IO_HomingPosVertA.AuditMessage = "KremerIoField changed:"
        Me.IO_HomingPosVertA.AuditSource = "KremerIoField"
        Me.IO_HomingPosVertA.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.IO_HomingPosVertA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO_HomingPosVertA.Data = 0.0R
        Me.IO_HomingPosVertA.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_HomingPosVertA.InitialValue = True
        Me.IO_HomingPosVertA.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_HomingPosVertA.Location = New System.Drawing.Point(179, 178)
        Me.IO_HomingPosVertA.LowerBound = -2500.0R
        Me.IO_HomingPosVertA.Name = "IO_HomingPosVertA"
        Me.IO_HomingPosVertA.OutputFormat = "0.0 mm"
        Me.IO_HomingPosVertA.Size = New System.Drawing.Size(71, 21)
        Me.IO_HomingPosVertA.TabIndex = 365
        Me.IO_HomingPosVertA.Text = "0,0 mm"
        Me.IO_HomingPosVertA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IO_HomingPosVertA.UpperBound = 2500.0R
        Me.IO_HomingPosVertA.UserInfo = Nothing
        Me.IO_HomingPosVertA.UserLevel = 0
        '
        'GB_VertHomePos
        '
        Me.GB_VertHomePos.BindControl = Me.IOHomingPosVertB
        Me.GB_VertHomePos.BindProperty = "Data"
        Me.GB_VertHomePos.Data = Nothing
        Me.GB_VertHomePos.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.GB_VertHomePos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GB_VertHomePos.VariableName = "MAIN.ProductHandling.GantryB.MachParameters.Vert_PositionHome"
        '
        'IOHomingPosVertB
        '
        Me.IOHomingPosVertB.Audit = Nothing
        Me.IOHomingPosVertB.AuditEnabled = False
        Me.IOHomingPosVertB.AuditMessage = "KremerIoField changed:"
        Me.IOHomingPosVertB.AuditSource = "KremerIoField"
        Me.IOHomingPosVertB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.IOHomingPosVertB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IOHomingPosVertB.Data = 0.0R
        Me.IOHomingPosVertB.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IOHomingPosVertB.InitialValue = True
        Me.IOHomingPosVertB.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IOHomingPosVertB.Location = New System.Drawing.Point(601, 178)
        Me.IOHomingPosVertB.LowerBound = -2500.0R
        Me.IOHomingPosVertB.Name = "IOHomingPosVertB"
        Me.IOHomingPosVertB.OutputFormat = "0.0 mm"
        Me.IOHomingPosVertB.Size = New System.Drawing.Size(71, 21)
        Me.IOHomingPosVertB.TabIndex = 366
        Me.IOHomingPosVertB.Text = "0,0 mm"
        Me.IOHomingPosVertB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IOHomingPosVertB.UpperBound = 2500.0R
        Me.IOHomingPosVertB.UserInfo = Nothing
        Me.IOHomingPosVertB.UserLevel = 0
        '
        'GA_HorHomePos
        '
        Me.GA_HorHomePos.BindControl = Me.IOHomePosHorA
        Me.GA_HorHomePos.BindProperty = "Data"
        Me.GA_HorHomePos.Data = Nothing
        Me.GA_HorHomePos.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.GA_HorHomePos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GA_HorHomePos.VariableName = "MAIN.ProductHandling.GantryA.MachParameters.Hor_PositionHome"
        '
        'IOHomePosHorA
        '
        Me.IOHomePosHorA.Audit = Nothing
        Me.IOHomePosHorA.AuditEnabled = False
        Me.IOHomePosHorA.AuditMessage = "KremerIoField changed:"
        Me.IOHomePosHorA.AuditSource = "KremerIoField"
        Me.IOHomePosHorA.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.IOHomePosHorA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IOHomePosHorA.Data = 0.0R
        Me.IOHomePosHorA.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IOHomePosHorA.InitialValue = True
        Me.IOHomePosHorA.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IOHomePosHorA.Location = New System.Drawing.Point(179, 90)
        Me.IOHomePosHorA.LowerBound = -2500.0R
        Me.IOHomePosHorA.Name = "IOHomePosHorA"
        Me.IOHomePosHorA.OutputFormat = "0.0 mm"
        Me.IOHomePosHorA.Size = New System.Drawing.Size(71, 21)
        Me.IOHomePosHorA.TabIndex = 367
        Me.IOHomePosHorA.Text = "0,0 mm"
        Me.IOHomePosHorA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IOHomePosHorA.UpperBound = 2500.0R
        Me.IOHomePosHorA.UserInfo = Nothing
        Me.IOHomePosHorA.UserLevel = 0
        '
        'GB_HorHomePos
        '
        Me.GB_HorHomePos.BindControl = Me.IOHomePosHorB
        Me.GB_HorHomePos.BindProperty = "Data"
        Me.GB_HorHomePos.Data = Nothing
        Me.GB_HorHomePos.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.GB_HorHomePos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.GB_HorHomePos.VariableName = "MAIN.ProductHandling.GantryB.MachParameters.Hor_PositionHome"
        '
        'IOHomePosHorB
        '
        Me.IOHomePosHorB.Audit = Nothing
        Me.IOHomePosHorB.AuditEnabled = False
        Me.IOHomePosHorB.AuditMessage = "KremerIoField changed:"
        Me.IOHomePosHorB.AuditSource = "KremerIoField"
        Me.IOHomePosHorB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.IOHomePosHorB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IOHomePosHorB.Data = 0.0R
        Me.IOHomePosHorB.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IOHomePosHorB.InitialValue = True
        Me.IOHomePosHorB.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IOHomePosHorB.Location = New System.Drawing.Point(601, 90)
        Me.IOHomePosHorB.LowerBound = -2500.0R
        Me.IOHomePosHorB.Name = "IOHomePosHorB"
        Me.IOHomePosHorB.OutputFormat = "0.0 mm"
        Me.IOHomePosHorB.Size = New System.Drawing.Size(71, 21)
        Me.IOHomePosHorB.TabIndex = 368
        Me.IOHomePosHorB.Text = "0,0 mm"
        Me.IOHomePosHorB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IOHomePosHorB.UpperBound = 2500.0R
        Me.IOHomePosHorB.UserInfo = Nothing
        Me.IOHomePosHorB.UserLevel = 0
        '
        'SB_HomePos
        '
        Me.SB_HomePos.BindControl = Me.IO_SBZeroPosValue
        Me.SB_HomePos.BindProperty = "Data"
        Me.SB_HomePos.Data = Nothing
        Me.SB_HomePos.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.SB_HomePos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SB_HomePos.VariableName = "MAIN.InMoldDrying.ProductForming.MachParameters.SprayBar.PositionHome"
        '
        'IO_SBZeroPosValue
        '
        Me.IO_SBZeroPosValue.Audit = Nothing
        Me.IO_SBZeroPosValue.AuditEnabled = False
        Me.IO_SBZeroPosValue.AuditMessage = "KremerIoField changed:"
        Me.IO_SBZeroPosValue.AuditSource = "KremerIoField"
        Me.IO_SBZeroPosValue.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.IO_SBZeroPosValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IO_SBZeroPosValue.Data = 0.0R
        Me.IO_SBZeroPosValue.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_SBZeroPosValue.InitialValue = True
        Me.IO_SBZeroPosValue.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_SBZeroPosValue.Location = New System.Drawing.Point(179, 258)
        Me.IO_SBZeroPosValue.LowerBound = -2500.0R
        Me.IO_SBZeroPosValue.Name = "IO_SBZeroPosValue"
        Me.IO_SBZeroPosValue.OutputFormat = "0.0 mm"
        Me.IO_SBZeroPosValue.Size = New System.Drawing.Size(71, 21)
        Me.IO_SBZeroPosValue.TabIndex = 373
        Me.IO_SBZeroPosValue.Text = "0,0 mm"
        Me.IO_SBZeroPosValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IO_SBZeroPosValue.UpperBound = 2500.0R
        Me.IO_SBZeroPosValue.UserInfo = Nothing
        Me.IO_SBZeroPosValue.UserLevel = 0
        '
        'BMA_HomePos
        '
        Me.BMA_HomePos.BindControl = Me.IOHomingPosBMA
        Me.BMA_HomePos.BindProperty = "Data"
        Me.BMA_HomePos.Data = Nothing
        Me.BMA_HomePos.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.BMA_HomePos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMA_HomePos.VariableName = "MAIN.InMoldDrying.MachParameters.BottomMoldA.AxisPositionHome"
        '
        'IOHomingPosBMA
        '
        Me.IOHomingPosBMA.Audit = Nothing
        Me.IOHomingPosBMA.AuditEnabled = False
        Me.IOHomingPosBMA.AuditMessage = "KremerIoField changed:"
        Me.IOHomingPosBMA.AuditSource = "KremerIoField"
        Me.IOHomingPosBMA.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.IOHomingPosBMA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IOHomingPosBMA.Data = 0.0R
        Me.IOHomingPosBMA.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IOHomingPosBMA.InitialValue = True
        Me.IOHomingPosBMA.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IOHomingPosBMA.Location = New System.Drawing.Point(601, 268)
        Me.IOHomingPosBMA.LowerBound = -2500.0R
        Me.IOHomingPosBMA.Name = "IOHomingPosBMA"
        Me.IOHomingPosBMA.OutputFormat = "0.0 mm"
        Me.IOHomingPosBMA.Size = New System.Drawing.Size(71, 21)
        Me.IOHomingPosBMA.TabIndex = 379
        Me.IOHomingPosBMA.Text = "0,0 mm"
        Me.IOHomingPosBMA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IOHomingPosBMA.UpperBound = 2500.0R
        Me.IOHomingPosBMA.UserInfo = Nothing
        Me.IOHomingPosBMA.UserLevel = 0
        '
        'BMB_HomePos
        '
        Me.BMB_HomePos.BindControl = Me.IOHomingPosBMB
        Me.BMB_HomePos.BindProperty = "Data"
        Me.BMB_HomePos.Data = Nothing
        Me.BMB_HomePos.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.BMB_HomePos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BMB_HomePos.VariableName = "MAIN.InMoldDrying.MachParameters.BottomMoldB.AxisPositionHome"
        '
        'IOHomingPosBMB
        '
        Me.IOHomingPosBMB.Audit = Nothing
        Me.IOHomingPosBMB.AuditEnabled = False
        Me.IOHomingPosBMB.AuditMessage = "KremerIoField changed:"
        Me.IOHomingPosBMB.AuditSource = "KremerIoField"
        Me.IOHomingPosBMB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.IOHomingPosBMB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IOHomingPosBMB.Data = 0.0R
        Me.IOHomingPosBMB.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IOHomingPosBMB.InitialValue = True
        Me.IOHomingPosBMB.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IOHomingPosBMB.Location = New System.Drawing.Point(601, 360)
        Me.IOHomingPosBMB.LowerBound = -2500.0R
        Me.IOHomingPosBMB.Name = "IOHomingPosBMB"
        Me.IOHomingPosBMB.OutputFormat = "0.0 mm"
        Me.IOHomingPosBMB.Size = New System.Drawing.Size(71, 21)
        Me.IOHomingPosBMB.TabIndex = 385
        Me.IOHomingPosBMB.Text = "0,0 mm"
        Me.IOHomingPosBMB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IOHomingPosBMB.UpperBound = 2500.0R
        Me.IOHomingPosBMB.UserInfo = Nothing
        Me.IOHomingPosBMB.UserLevel = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(339, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(449, 39)
        Me.Label2.TabIndex = 326
        Me.Label2.Tag = ""
        Me.Label2.Text = "The gates need to be open in order to ""Zero"" the Encoder. When the zeroing succee" & _
    "ded, the light next to the button will turn green."
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(21, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(286, 23)
        Me.Label3.TabIndex = 351
        Me.Label3.Tag = ""
        Me.Label3.Text = "Spraybar"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(21, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(286, 23)
        Me.Label4.TabIndex = 355
        Me.Label4.Tag = ""
        Me.Label4.Text = "Product conveyor"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(439, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(286, 23)
        Me.Label5.TabIndex = 359
        Me.Label5.Tag = ""
        Me.Label5.Text = "Gantry B Horizontal:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(439, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(286, 23)
        Me.Label6.TabIndex = 363
        Me.Label6.Tag = ""
        Me.Label6.Text = "Gantry B Vertical"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(166, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 369
        Me.Label7.Text = "Zero position value"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(166, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 13)
        Me.Label8.TabIndex = 370
        Me.Label8.Text = "Zero position value"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(585, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 372
        Me.Label10.Text = "Zero position value"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(585, 162)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 13)
        Me.Label11.TabIndex = 371
        Me.Label11.Text = "Zero position value"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(166, 241)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 13)
        Me.Label12.TabIndex = 374
        Me.Label12.Text = "Zero position value"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(585, 252)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 13)
        Me.Label13.TabIndex = 380
        Me.Label13.Text = "Zero position value"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(439, 228)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(286, 23)
        Me.Label14.TabIndex = 377
        Me.Label14.Tag = ""
        Me.Label14.Text = "Bottommold A"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(585, 344)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 13)
        Me.Label15.TabIndex = 386
        Me.Label15.Text = "Zero position value"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(439, 320)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(286, 23)
        Me.Label16.TabIndex = 383
        Me.Label16.Tag = ""
        Me.Label16.Text = "Bottommold B"
        '
        'ZeroAbsEncoder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.IOHomingPosBMB)
        Me.Controls.Add(Me.plBMBDone)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.IO_BMBActPos)
        Me.Controls.Add(Me.BtnZeroBMB)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.IOHomingPosBMA)
        Me.Controls.Add(Me.plBMADone)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.IO_BMAActPos)
        Me.Controls.Add(Me.BtnZeroBMA)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.IO_SBZeroPosValue)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.IOHomePosHorB)
        Me.Controls.Add(Me.IOHomePosHorA)
        Me.Controls.Add(Me.IOHomingPosVertB)
        Me.Controls.Add(Me.IO_HomingPosVertA)
        Me.Controls.Add(Me.plGantryBVertDone)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.IO_GantryBVertActPos)
        Me.Controls.Add(Me.BtnZeroGantryBVert)
        Me.Controls.Add(Me.plGantryBHorDone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.IO_GantryBHorActPos)
        Me.Controls.Add(Me.BtnZeroGantryBHor)
        Me.Controls.Add(Me.plPcDone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.io_PcPos)
        Me.Controls.Add(Me.Btn_ZeroSB)
        Me.Controls.Add(Me.plSbDone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.io_SBPos)
        Me.Controls.Add(Me.Btn_ZeroPc)
        Me.Controls.Add(Me.plGantryAVertDone)
        Me.Controls.Add(Me.plGantryAHorDone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.io_GantryAVert_Pos)
        Me.Controls.Add(Me.Btn_ZeroGantryAVert)
        Me.Controls.Add(Me.lbl_puh)
        Me.Controls.Add(Me.io_GantryAHor_Pos)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Btn_ZeroGantryAHor)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "ZeroAbsEncoder"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "79"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents io_GantryAHor_Pos As KremerControlsWin32.KremerIoField
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Btn_ZeroGantryAHor As KremerControlsWin32.KremerButton
    Friend WithEvents lbl_puh As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents io_GantryAVert_Pos As KremerControlsWin32.KremerIoField
    Friend WithEvents Btn_ZeroGantryAVert As KremerControlsWin32.KremerButton
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents krVarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents plGantryAHorDone As KremerControlsWin32.KremerLight
    Friend WithEvents plGantryAVertDone As KremerControlsWin32.KremerLight
    Friend WithEvents LiftLine As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents plSbDone As KremerControlsWin32.KremerLight
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents io_SBPos As KremerControlsWin32.KremerIoField
    Friend WithEvents Btn_ZeroPc As KremerControlsWin32.KremerButton
    Friend WithEvents plPcDone As KremerControlsWin32.KremerLight
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents io_PcPos As KremerControlsWin32.KremerIoField
    Friend WithEvents Btn_ZeroSB As KremerControlsWin32.KremerButton
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents plGantryBHorDone As KremerControlsWin32.KremerLight
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents IO_GantryBHorActPos As KremerControlsWin32.KremerIoField
    Friend WithEvents BtnZeroGantryBHor As KremerControlsWin32.KremerButton
    Friend WithEvents plGantryBVertDone As KremerControlsWin32.KremerLight
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents IO_GantryBVertActPos As KremerControlsWin32.KremerIoField
    Friend WithEvents BtnZeroGantryBVert As KremerControlsWin32.KremerButton
    Friend WithEvents GA_HorZero As KremerControlsWin32.KremerVariable
    Friend WithEvents GA_VertZero As KremerControlsWin32.KremerVariable
    Friend WithEvents GB_HorZero As KremerControlsWin32.KremerVariable
    Friend WithEvents GB_VertZero As KremerControlsWin32.KremerVariable
    Friend WithEvents SB_Zero As KremerControlsWin32.KremerVariable
    Friend WithEvents PC_Zero As KremerControlsWin32.KremerVariable
    Friend WithEvents GA_HorDone As KremerControlsWin32.KremerVariable
    Friend WithEvents GA_VerDone As KremerControlsWin32.KremerVariable
    Friend WithEvents GB_HorDone As KremerControlsWin32.KremerVariable
    Friend WithEvents GB_VertDone As KremerControlsWin32.KremerVariable
    Friend WithEvents SP_Done As KremerControlsWin32.KremerVariable
    Friend WithEvents PC_Done As KremerControlsWin32.KremerVariable
    Friend WithEvents GA_HorPos As KremerControlsWin32.KremerVariable
    Friend WithEvents GA_VertPos As KremerControlsWin32.KremerVariable
    Friend WithEvents GB_HorPos As KremerControlsWin32.KremerVariable
    Friend WithEvents GB_VertPos As KremerControlsWin32.KremerVariable
    Friend WithEvents SB_Pos As KremerControlsWin32.KremerVariable
    Friend WithEvents PC_Pos As KremerControlsWin32.KremerVariable
    Friend WithEvents GA_Hor_AxDis As KremerControlsWin32.KremerVariable
    Friend WithEvents GA_Vert_AxDis As KremerControlsWin32.KremerVariable
    Friend WithEvents GB_Hor_AxDis As KremerControlsWin32.KremerVariable
    Friend WithEvents GB_Vert_AxDis As KremerControlsWin32.KremerVariable
    Friend WithEvents SB_AxDis As KremerControlsWin32.KremerVariable
    Friend WithEvents PC_AxDis As KremerControlsWin32.KremerVariable
    Friend WithEvents GA_VertHomePos As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_HomingPosVertA As KremerControlsWin32.KremerIoField
    Friend WithEvents GB_VertHomePos As KremerControlsWin32.KremerVariable
    Friend WithEvents IOHomingPosVertB As KremerControlsWin32.KremerIoField
    Friend WithEvents GA_HorHomePos As KremerControlsWin32.KremerVariable
    Friend WithEvents IOHomePosHorA As KremerControlsWin32.KremerIoField
    Friend WithEvents GB_HorHomePos As KremerControlsWin32.KremerVariable
    Friend WithEvents IOHomePosHorB As KremerControlsWin32.KremerIoField
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents SB_HomePos As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_SBZeroPosValue As KremerControlsWin32.KremerIoField
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LineShape7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents IOHomingPosBMA As KremerControlsWin32.KremerIoField
    Friend WithEvents plBMADone As KremerControlsWin32.KremerLight
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents IO_BMAActPos As KremerControlsWin32.KremerIoField
    Friend WithEvents BtnZeroBMA As KremerControlsWin32.KremerButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents IOHomingPosBMB As KremerControlsWin32.KremerIoField
    Friend WithEvents plBMBDone As KremerControlsWin32.KremerLight
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents IO_BMBActPos As KremerControlsWin32.KremerIoField
    Friend WithEvents BtnZeroBMB As KremerControlsWin32.KremerButton
    Friend WithEvents BMA_Zero As KremerControlsWin32.KremerVariable
    Friend WithEvents BMB_Zero As KremerControlsWin32.KremerVariable
    Friend WithEvents BMA_Done As KremerControlsWin32.KremerVariable
    Friend WithEvents BMB_Done As KremerControlsWin32.KremerVariable
    Friend WithEvents BMA_AxDis As KremerControlsWin32.KremerVariable
    Friend WithEvents BMB_AxDis As KremerControlsWin32.KremerVariable
    Friend WithEvents BMA_Pos As KremerControlsWin32.KremerVariable
    Friend WithEvents BMB_Pos As KremerControlsWin32.KremerVariable
    Friend WithEvents BMA_HomePos As KremerControlsWin32.KremerVariable
    Friend WithEvents BMB_HomePos As KremerControlsWin32.KremerVariable

End Class
