<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Settings
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Me.FirstVac = New KremerControlsWin32.KremerVariable(Me.components)
        Me.secondVac = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_2Vacuumtime = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.IO_1Vacuumtime = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.IO_TM_DryingTimeA = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IO_TM_DryingTimeB = New KremerControlsWin32.KremerIoField(Me.components)
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.DryingA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.DryingB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.SuspendLayout()
        '
        'krConnector
        '
        Me.krConnector.VarCollector = Nothing
        '
        'krVarCollector
        '
        Me.krVarCollector.Variables.Add(Me.FirstVac)
        Me.krVarCollector.Variables.Add(Me.secondVac)
        Me.krVarCollector.Variables.Add(Me.DryingA)
        Me.krVarCollector.Variables.Add(Me.DryingB)
        '
        'FirstVac
        '
        Me.FirstVac.BindControl = Me.IO_1Vacuumtime
        Me.FirstVac.BindProperty = "Data"
        Me.FirstVac.Data = Nothing
        Me.FirstVac.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.FirstVac.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FirstVac.VariableName = "MAIN.InMoldDrying.MachParameters.ProductForming.FormingMold.VacuumTime"
        '
        'secondVac
        '
        Me.secondVac.BindControl = Me.IO_2Vacuumtime
        Me.secondVac.BindProperty = "Data"
        Me.secondVac.Data = Nothing
        Me.secondVac.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.secondVac.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.secondVac.VariableName = "MAIN.InMoldDrying.MachParameters.ProductForming.FormingMold.SecondVacuum"
        '
        'IO_2Vacuumtime
        '
        Me.IO_2Vacuumtime.Audit = Nothing
        Me.IO_2Vacuumtime.AuditEnabled = False
        Me.IO_2Vacuumtime.AuditMessage = "KremerIoField changed:"
        Me.IO_2Vacuumtime.AuditSource = "KremerIoField"
        Me.IO_2Vacuumtime.BackColor = System.Drawing.Color.White
        Me.IO_2Vacuumtime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_2Vacuumtime.Data = 0.0R
        Me.IO_2Vacuumtime.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_2Vacuumtime.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_2Vacuumtime.InitialValue = True
        Me.IO_2Vacuumtime.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_2Vacuumtime.Location = New System.Drawing.Point(278, 61)
        Me.IO_2Vacuumtime.LowerBound = 0.0R
        Me.IO_2Vacuumtime.Name = "IO_2Vacuumtime"
        Me.IO_2Vacuumtime.OutputFormat = "0.0 ms"
        Me.IO_2Vacuumtime.Size = New System.Drawing.Size(100, 22)
        Me.IO_2Vacuumtime.TabIndex = 405
        Me.IO_2Vacuumtime.Text = "0.0 ms"
        Me.IO_2Vacuumtime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_2Vacuumtime.UpperBound = 15000.0R
        Me.IO_2Vacuumtime.UserInfo = Nothing
        Me.IO_2Vacuumtime.UserLevel = 0
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(24, 62)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(247, 23)
        Me.Label25.TabIndex = 404
        Me.Label25.Tag = "326"
        Me.Label25.Text = "2nd vacuum time"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(25, 40)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(247, 23)
        Me.Label23.TabIndex = 403
        Me.Label23.Tag = "325"
        Me.Label23.Text = "1st vacuum time (forming)"
        '
        'IO_1Vacuumtime
        '
        Me.IO_1Vacuumtime.Audit = Nothing
        Me.IO_1Vacuumtime.AuditEnabled = False
        Me.IO_1Vacuumtime.AuditMessage = "KremerIoField changed:"
        Me.IO_1Vacuumtime.AuditSource = "KremerIoField"
        Me.IO_1Vacuumtime.BackColor = System.Drawing.Color.White
        Me.IO_1Vacuumtime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_1Vacuumtime.Data = 0.0R
        Me.IO_1Vacuumtime.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_1Vacuumtime.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_1Vacuumtime.InitialValue = True
        Me.IO_1Vacuumtime.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_1Vacuumtime.Location = New System.Drawing.Point(278, 39)
        Me.IO_1Vacuumtime.LowerBound = -5000.0R
        Me.IO_1Vacuumtime.Name = "IO_1Vacuumtime"
        Me.IO_1Vacuumtime.OutputFormat = "0.0 ms"
        Me.IO_1Vacuumtime.Size = New System.Drawing.Size(100, 22)
        Me.IO_1Vacuumtime.TabIndex = 402
        Me.IO_1Vacuumtime.Text = "0.0 ms"
        Me.IO_1Vacuumtime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_1Vacuumtime.UpperBound = 10000.0R
        Me.IO_1Vacuumtime.UserInfo = Nothing
        Me.IO_1Vacuumtime.UserLevel = 0
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(25, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(273, 23)
        Me.Label3.TabIndex = 406
        Me.Label3.Tag = ""
        Me.Label3.Text = "Forming settings"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(25, 164)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(247, 23)
        Me.Label19.TabIndex = 408
        Me.Label19.Tag = ""
        Me.Label19.Text = "A side drying time"
        '
        'IO_TM_DryingTimeA
        '
        Me.IO_TM_DryingTimeA.Audit = Nothing
        Me.IO_TM_DryingTimeA.AuditEnabled = False
        Me.IO_TM_DryingTimeA.AuditMessage = "KremerIoField changed:"
        Me.IO_TM_DryingTimeA.AuditSource = "KremerIoField"
        Me.IO_TM_DryingTimeA.BackColor = System.Drawing.Color.White
        Me.IO_TM_DryingTimeA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_TM_DryingTimeA.Data = 0.0R
        Me.IO_TM_DryingTimeA.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TM_DryingTimeA.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TM_DryingTimeA.InitialValue = True
        Me.IO_TM_DryingTimeA.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TM_DryingTimeA.Location = New System.Drawing.Point(278, 162)
        Me.IO_TM_DryingTimeA.LowerBound = 0.0R
        Me.IO_TM_DryingTimeA.Name = "IO_TM_DryingTimeA"
        Me.IO_TM_DryingTimeA.OutputFormat = "0.0 ms"
        Me.IO_TM_DryingTimeA.Size = New System.Drawing.Size(100, 22)
        Me.IO_TM_DryingTimeA.TabIndex = 407
        Me.IO_TM_DryingTimeA.Text = "0.0 ms"
        Me.IO_TM_DryingTimeA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TM_DryingTimeA.UpperBound = 120000.0R
        Me.IO_TM_DryingTimeA.UserInfo = Nothing
        Me.IO_TM_DryingTimeA.UserLevel = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(24, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 23)
        Me.Label1.TabIndex = 409
        Me.Label1.Tag = ""
        Me.Label1.Text = "Drying time settings"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 23)
        Me.Label2.TabIndex = 410
        Me.Label2.Tag = ""
        Me.Label2.Text = "B side drying time"
        '
        'IO_TM_DryingTimeB
        '
        Me.IO_TM_DryingTimeB.Audit = Nothing
        Me.IO_TM_DryingTimeB.AuditEnabled = False
        Me.IO_TM_DryingTimeB.AuditMessage = "KremerIoField changed:"
        Me.IO_TM_DryingTimeB.AuditSource = "KremerIoField"
        Me.IO_TM_DryingTimeB.BackColor = System.Drawing.Color.White
        Me.IO_TM_DryingTimeB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IO_TM_DryingTimeB.Data = 0.0R
        Me.IO_TM_DryingTimeB.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TM_DryingTimeB.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TM_DryingTimeB.InitialValue = True
        Me.IO_TM_DryingTimeB.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TM_DryingTimeB.Location = New System.Drawing.Point(278, 188)
        Me.IO_TM_DryingTimeB.LowerBound = 0.0R
        Me.IO_TM_DryingTimeB.Name = "IO_TM_DryingTimeB"
        Me.IO_TM_DryingTimeB.OutputFormat = "0.0 ms"
        Me.IO_TM_DryingTimeB.Size = New System.Drawing.Size(100, 22)
        Me.IO_TM_DryingTimeB.TabIndex = 411
        Me.IO_TM_DryingTimeB.Text = "0.0 ms"
        Me.IO_TM_DryingTimeB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TM_DryingTimeB.UpperBound = 120000.0R
        Me.IO_TM_DryingTimeB.UserInfo = Nothing
        Me.IO_TM_DryingTimeB.UserLevel = 0
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 30
        Me.LineShape3.X2 = 380
        Me.LineShape3.Y1 = 35
        Me.LineShape3.Y2 = 35
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 275
        Me.LineShape2.X2 = 275
        Me.LineShape2.Y1 = 35
        Me.LineShape2.Y2 = 100
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape1, Me.LineShape2, Me.LineShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 441)
        Me.ShapeContainer1.TabIndex = 412
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 275
        Me.LineShape1.X2 = 275
        Me.LineShape1.Y1 = 158
        Me.LineShape1.Y2 = 223
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 30
        Me.LineShape4.X2 = 380
        Me.LineShape4.Y1 = 158
        Me.LineShape4.Y2 = 158
        '
        'DryingA
        '
        Me.DryingA.BindControl = Me.IO_TM_DryingTimeA
        Me.DryingA.BindProperty = "Data"
        Me.DryingA.Data = Nothing
        Me.DryingA.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.DryingA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.DryingA.VariableName = "MAIN.InMoldDrying.MachParameters.TopMoldA.DryingTime"
        '
        'DryingB
        '
        Me.DryingB.BindControl = Me.IO_TM_DryingTimeB
        Me.DryingB.BindProperty = "Data"
        Me.DryingB.Data = Nothing
        Me.DryingB.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.DryingB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.DryingB.VariableName = "MAIN.InMoldDrying.MachParameters.TopMoldB.DryingTime"
        '
        'Settings
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.IO_TM_DryingTimeB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.IO_TM_DryingTimeA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IO_2Vacuumtime)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.IO_1Vacuumtime)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Settings"
        Me.Size = New System.Drawing.Size(800, 441)
        Me.Tag = "4"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents krConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents krVarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents FirstVac As KremerControlsWin32.KremerVariable
    Friend WithEvents secondVac As KremerControlsWin32.KremerVariable
    Friend WithEvents IO_2Vacuumtime As KremerControlsWin32.KremerIoField
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents IO_1Vacuumtime As KremerControlsWin32.KremerIoField
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents IO_TM_DryingTimeA As KremerControlsWin32.KremerIoField
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents IO_TM_DryingTimeB As KremerControlsWin32.KremerIoField
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents DryingA As KremerControlsWin32.KremerVariable
    Friend WithEvents DryingB As KremerControlsWin32.KremerVariable

End Class
