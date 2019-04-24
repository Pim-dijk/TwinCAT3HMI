<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductForming_Overview
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
        Me.MachinePondActPos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_MachinePondPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.SpraybarActPos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IO_SprayBarPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Me.VarCollector
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.mxAutomode)
        Me.VarCollector.Variables.Add(Me.MachinePondActPos)
        Me.VarCollector.Variables.Add(Me.SpraybarActPos)
        '
        'mxAutomode
        '
        Me.mxAutomode.BindControl = Nothing
        Me.mxAutomode.BindProperty = "Data"
        Me.mxAutomode.Data = Nothing
        Me.mxAutomode.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.mxAutomode.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.mxAutomode.VariableName = "HMI.mxAutomode"
        '
        'MachinePondActPos
        '
        Me.MachinePondActPos.BindControl = Me.IO_MachinePondPos
        Me.MachinePondActPos.BindProperty = "Data"
        Me.MachinePondActPos.Data = Nothing
        Me.MachinePondActPos.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.MachinePondActPos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.MachinePondActPos.VariableName = "MAIN.InMoldDrying.ProductForming.PondHydraulicCilinder.ActPosition"
        '
        'IO_MachinePondPos
        '
        Me.IO_MachinePondPos.Audit = Nothing
        Me.IO_MachinePondPos.AuditEnabled = False
        Me.IO_MachinePondPos.AuditMessage = "KremerIoField changed:"
        Me.IO_MachinePondPos.AuditSource = "KremerIoField"
        Me.IO_MachinePondPos.Data = 0.0R
        Me.IO_MachinePondPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_MachinePondPos.InitialValue = True
        Me.IO_MachinePondPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_MachinePondPos.Location = New System.Drawing.Point(639, 322)
        Me.IO_MachinePondPos.LowerBound = 0.0R
        Me.IO_MachinePondPos.Name = "IO_MachinePondPos"
        Me.IO_MachinePondPos.OutputFormat = "0.0 mm"
        Me.IO_MachinePondPos.Size = New System.Drawing.Size(71, 21)
        Me.IO_MachinePondPos.TabIndex = 304
        Me.IO_MachinePondPos.Text = "0,0 mm"
        Me.IO_MachinePondPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IO_MachinePondPos.UpperBound = 1000.0R
        Me.IO_MachinePondPos.UserInfo = Nothing
        Me.IO_MachinePondPos.UserLevel = 0
        '
        'SpraybarActPos
        '
        Me.SpraybarActPos.BindControl = Me.IO_SprayBarPos
        Me.SpraybarActPos.BindProperty = "Data"
        Me.SpraybarActPos.Data = Nothing
        Me.SpraybarActPos.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.SpraybarActPos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SpraybarActPos.VariableName = "MAIN.InMoldDrying.ProductForming.SprayBarMotor.ActPosition"
        '
        'IO_SprayBarPos
        '
        Me.IO_SprayBarPos.Audit = Nothing
        Me.IO_SprayBarPos.AuditEnabled = False
        Me.IO_SprayBarPos.AuditMessage = "KremerIoField changed:"
        Me.IO_SprayBarPos.AuditSource = "KremerIoField"
        Me.IO_SprayBarPos.Data = 0.0R
        Me.IO_SprayBarPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_SprayBarPos.InitialValue = True
        Me.IO_SprayBarPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IO_SprayBarPos.Location = New System.Drawing.Point(639, 18)
        Me.IO_SprayBarPos.LowerBound = 0.0R
        Me.IO_SprayBarPos.Name = "IO_SprayBarPos"
        Me.IO_SprayBarPos.OutputFormat = "0.0 mm"
        Me.IO_SprayBarPos.Size = New System.Drawing.Size(71, 21)
        Me.IO_SprayBarPos.TabIndex = 302
        Me.IO_SprayBarPos.Text = "0,0 mm"
        Me.IO_SprayBarPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IO_SprayBarPos.UpperBound = 1000.0R
        Me.IO_SprayBarPos.UserInfo = Nothing
        Me.IO_SprayBarPos.UserLevel = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(177, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(447, 363)
        Me.Panel2.TabIndex = 37
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(177, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(447, 51)
        Me.Panel3.TabIndex = 301
        '
        'ProductForming_Overview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.InMoldDrying.My.Resources.Resources.Spraybar_Formingmolds_Machinepond
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.IO_MachinePondPos)
        Me.Controls.Add(Me.IO_SprayBarPos)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.Name = "ProductForming_Overview"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "92"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents mxAutomode As KremerControlsWin32.KremerVariable
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents IO_SprayBarPos As KremerControlsWin32.KremerIoField
    Friend WithEvents IO_MachinePondPos As KremerControlsWin32.KremerIoField
    Friend WithEvents MachinePondActPos As KremerControlsWin32.KremerVariable
    Friend WithEvents SpraybarActPos As KremerControlsWin32.KremerVariable

End Class
