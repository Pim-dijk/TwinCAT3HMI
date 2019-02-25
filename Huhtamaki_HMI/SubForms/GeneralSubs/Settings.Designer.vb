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
        Me.Btn1 = New KremerControlsWin32.KremerButton()
        Me.TestBtn2 = New KremerControlsWin32.KremerButton()
        Me.KremerVariable1 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.KremerVariable2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.SuspendLayout()
        '
        'krConnector
        '
        Me.krConnector.VarCollector = Nothing
        '
        'krVarCollector
        '
        Me.krVarCollector.Variables.Add(Me.KremerVariable1)
        Me.krVarCollector.Variables.Add(Me.KremerVariable2)
        '
        'Btn1
        '
        Me.Btn1.Audit = Nothing
        Me.Btn1.AuditEnabled = False
        Me.Btn1.AuditMessage = "KremerPushButton pressed!"
        Me.Btn1.AuditSource = "KremerPushButton"
        Me.Btn1.BackColorOn = System.Drawing.Color.Blue
        Me.Btn1.BackGroundImageOn = Nothing
        Me.Btn1.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn1.Data = False
        Me.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn1.ForeColorOn = System.Drawing.Color.Yellow
        Me.Btn1.Location = New System.Drawing.Point(322, 70)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(106, 36)
        Me.Btn1.State = False
        Me.Btn1.StateIsData = True
        Me.Btn1.StateText = New String() {Nothing, Nothing}
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "TestButton1"
        Me.Btn1.UserInfo = Nothing
        Me.Btn1.UserLevel = 0
        Me.Btn1.UseStateText = False
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'TestBtn2
        '
        Me.TestBtn2.Audit = Nothing
        Me.TestBtn2.AuditEnabled = False
        Me.TestBtn2.AuditMessage = "KremerPushButton pressed!"
        Me.TestBtn2.AuditSource = "KremerPushButton"
        Me.TestBtn2.BackColorOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TestBtn2.BackGroundImageOn = Nothing
        Me.TestBtn2.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.TestBtn2.Data = False
        Me.TestBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TestBtn2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TestBtn2.ForeColorOn = System.Drawing.Color.Yellow
        Me.TestBtn2.Location = New System.Drawing.Point(450, 70)
        Me.TestBtn2.Name = "TestBtn2"
        Me.TestBtn2.Size = New System.Drawing.Size(106, 36)
        Me.TestBtn2.State = False
        Me.TestBtn2.StateIsData = True
        Me.TestBtn2.StateText = New String() {Nothing, Nothing}
        Me.TestBtn2.TabIndex = 268
        Me.TestBtn2.Tag = ""
        Me.TestBtn2.Text = "TestButton2"
        Me.TestBtn2.UserInfo = Nothing
        Me.TestBtn2.UserLevel = 0
        Me.TestBtn2.UseStateText = False
        '
        'KremerVariable1
        '
        Me.KremerVariable1.BindControl = Me.Btn1
        Me.KremerVariable1.BindProperty = "Data"
        Me.KremerVariable1.Data = Nothing
        Me.KremerVariable1.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.KremerVariable1.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.KremerVariable1.VariableName = "MAIN.Testbutton1"
        '
        'KremerVariable2
        '
        Me.KremerVariable2.BindControl = Me.TestBtn2
        Me.KremerVariable2.BindProperty = "Data"
        Me.KremerVariable2.Data = Nothing
        Me.KremerVariable2.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.KremerVariable2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.KremerVariable2.VariableName = "MAIN.Testbutton2"
        '
        'Settings
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.TestBtn2)
        Me.Controls.Add(Me.Btn1)
        Me.Name = "Settings"
        Me.Size = New System.Drawing.Size(800, 441)
        Me.Tag = "4"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents krConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents krVarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents Btn1 As KremerControlsWin32.KremerButton
    Friend WithEvents TestBtn2 As KremerControlsWin32.KremerButton
    Friend WithEvents KremerVariable1 As KremerControlsWin32.KremerVariable
    Friend WithEvents KremerVariable2 As KremerControlsWin32.KremerVariable

End Class
