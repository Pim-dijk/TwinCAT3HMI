<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CT
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
        Me.hmiDenesterPresent = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioPusherBDown = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ioPusherBUp = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ioPusherADown = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ioPusherAUp = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.KremerIoField1 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.KremerIoField2 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.hmiDenesterPresent)
        '
        'hmiDenesterPresent
        '
        Me.hmiDenesterPresent.BindControl = Nothing
        Me.hmiDenesterPresent.BindProperty = "Data"
        Me.hmiDenesterPresent.Data = Nothing
        Me.hmiDenesterPresent.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.hmiDenesterPresent.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.hmiDenesterPresent.VariableName = "InlineAutomation.MachPar.DenesterPresent"
        '
        'ioPusherBDown
        '
        Me.ioPusherBDown.Audit = Nothing
        Me.ioPusherBDown.AuditEnabled = False
        Me.ioPusherBDown.AuditMessage = "KremerIoField changed:"
        Me.ioPusherBDown.AuditSource = "KremerIoField"
        Me.ioPusherBDown.AutoSize = True
        Me.ioPusherBDown.Data = 0.0R
        Me.ioPusherBDown.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioPusherBDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioPusherBDown.InitialValue = True
        Me.ioPusherBDown.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioPusherBDown.Location = New System.Drawing.Point(458, 71)
        Me.ioPusherBDown.LowerBound = 0.0R
        Me.ioPusherBDown.Name = "ioPusherBDown"
        Me.ioPusherBDown.OutputFormat = "0 ms"
        Me.ioPusherBDown.Size = New System.Drawing.Size(41, 18)
        Me.ioPusherBDown.TabIndex = 417
        Me.ioPusherBDown.Text = "0 ms"
        Me.ioPusherBDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioPusherBDown.UpperBound = 1000.0R
        Me.ioPusherBDown.UserInfo = Nothing
        Me.ioPusherBDown.UserLevel = 0
        '
        'ioPusherBUp
        '
        Me.ioPusherBUp.Audit = Nothing
        Me.ioPusherBUp.AuditEnabled = False
        Me.ioPusherBUp.AuditMessage = "KremerIoField changed:"
        Me.ioPusherBUp.AuditSource = "KremerIoField"
        Me.ioPusherBUp.AutoSize = True
        Me.ioPusherBUp.Data = 0.0R
        Me.ioPusherBUp.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioPusherBUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioPusherBUp.InitialValue = True
        Me.ioPusherBUp.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioPusherBUp.Location = New System.Drawing.Point(458, 46)
        Me.ioPusherBUp.LowerBound = 0.0R
        Me.ioPusherBUp.Name = "ioPusherBUp"
        Me.ioPusherBUp.OutputFormat = "0 ms"
        Me.ioPusherBUp.Size = New System.Drawing.Size(41, 18)
        Me.ioPusherBUp.TabIndex = 416
        Me.ioPusherBUp.Text = "0 ms"
        Me.ioPusherBUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioPusherBUp.UpperBound = 1000.0R
        Me.ioPusherBUp.UserInfo = Nothing
        Me.ioPusherBUp.UserLevel = 0
        '
        'ioPusherADown
        '
        Me.ioPusherADown.Audit = Nothing
        Me.ioPusherADown.AuditEnabled = False
        Me.ioPusherADown.AuditMessage = "KremerIoField changed:"
        Me.ioPusherADown.AuditSource = "KremerIoField"
        Me.ioPusherADown.AutoSize = True
        Me.ioPusherADown.Data = 0.0R
        Me.ioPusherADown.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioPusherADown.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioPusherADown.InitialValue = True
        Me.ioPusherADown.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioPusherADown.Location = New System.Drawing.Point(204, 71)
        Me.ioPusherADown.LowerBound = 0.0R
        Me.ioPusherADown.Name = "ioPusherADown"
        Me.ioPusherADown.OutputFormat = "0 ms"
        Me.ioPusherADown.Size = New System.Drawing.Size(41, 18)
        Me.ioPusherADown.TabIndex = 415
        Me.ioPusherADown.Text = "0 ms"
        Me.ioPusherADown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioPusherADown.UpperBound = 1000.0R
        Me.ioPusherADown.UserInfo = Nothing
        Me.ioPusherADown.UserLevel = 0
        '
        'ioPusherAUp
        '
        Me.ioPusherAUp.Audit = Nothing
        Me.ioPusherAUp.AuditEnabled = False
        Me.ioPusherAUp.AuditMessage = "KremerIoField changed:"
        Me.ioPusherAUp.AuditSource = "KremerIoField"
        Me.ioPusherAUp.AutoSize = True
        Me.ioPusherAUp.Data = 0.0R
        Me.ioPusherAUp.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioPusherAUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioPusherAUp.InitialValue = True
        Me.ioPusherAUp.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioPusherAUp.Location = New System.Drawing.Point(204, 46)
        Me.ioPusherAUp.LowerBound = 0.0R
        Me.ioPusherAUp.Name = "ioPusherAUp"
        Me.ioPusherAUp.OutputFormat = "0 ms"
        Me.ioPusherAUp.Size = New System.Drawing.Size(41, 18)
        Me.ioPusherAUp.TabIndex = 414
        Me.ioPusherAUp.Text = "0 ms"
        Me.ioPusherAUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioPusherAUp.UpperBound = 1000.0R
        Me.ioPusherAUp.UserInfo = Nothing
        Me.ioPusherAUp.UserLevel = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(287, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 25)
        Me.Label2.TabIndex = 413
        Me.Label2.Tag = ""
        Me.Label2.Text = "Pusher B Down"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(287, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 25)
        Me.Label3.TabIndex = 412
        Me.Label3.Tag = ""
        Me.Label3.Text = "Pusher B Up"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(287, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(231, 25)
        Me.Label6.TabIndex = 411
        Me.Label6.Tag = ""
        Me.Label6.Text = "BBT Pusher B"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(14, 66)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(140, 25)
        Me.Label30.TabIndex = 410
        Me.Label30.Tag = ""
        Me.Label30.Text = "Pusher A Down"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(14, 41)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 25)
        Me.Label14.TabIndex = 409
        Me.Label14.Tag = ""
        Me.Label14.Text = "Pusher A Up"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(14, 11)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(231, 25)
        Me.Label29.TabIndex = 408
        Me.Label29.Tag = ""
        Me.Label29.Text = "BBT Pusher A"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KremerIoField1
        '
        Me.KremerIoField1.Audit = Nothing
        Me.KremerIoField1.AuditEnabled = False
        Me.KremerIoField1.AuditMessage = "KremerIoField changed:"
        Me.KremerIoField1.AuditSource = "KremerIoField"
        Me.KremerIoField1.AutoSize = True
        Me.KremerIoField1.Data = 0.0R
        Me.KremerIoField1.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.KremerIoField1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerIoField1.InitialValue = True
        Me.KremerIoField1.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.KremerIoField1.Location = New System.Drawing.Point(711, 71)
        Me.KremerIoField1.LowerBound = 0.0R
        Me.KremerIoField1.Name = "KremerIoField1"
        Me.KremerIoField1.OutputFormat = "0 ms"
        Me.KremerIoField1.Size = New System.Drawing.Size(41, 18)
        Me.KremerIoField1.TabIndex = 422
        Me.KremerIoField1.Text = "0 ms"
        Me.KremerIoField1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.KremerIoField1.UpperBound = 1000.0R
        Me.KremerIoField1.UserInfo = Nothing
        Me.KremerIoField1.UserLevel = 0
        '
        'KremerIoField2
        '
        Me.KremerIoField2.Audit = Nothing
        Me.KremerIoField2.AuditEnabled = False
        Me.KremerIoField2.AuditMessage = "KremerIoField changed:"
        Me.KremerIoField2.AuditSource = "KremerIoField"
        Me.KremerIoField2.AutoSize = True
        Me.KremerIoField2.Data = 0.0R
        Me.KremerIoField2.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.KremerIoField2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KremerIoField2.InitialValue = True
        Me.KremerIoField2.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.KremerIoField2.Location = New System.Drawing.Point(711, 46)
        Me.KremerIoField2.LowerBound = 0.0R
        Me.KremerIoField2.Name = "KremerIoField2"
        Me.KremerIoField2.OutputFormat = "0 ms"
        Me.KremerIoField2.Size = New System.Drawing.Size(41, 18)
        Me.KremerIoField2.TabIndex = 421
        Me.KremerIoField2.Text = "0 ms"
        Me.KremerIoField2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.KremerIoField2.UpperBound = 1000.0R
        Me.KremerIoField2.UserInfo = Nothing
        Me.KremerIoField2.UserLevel = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(540, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 25)
        Me.Label1.TabIndex = 420
        Me.Label1.Tag = ""
        Me.Label1.Text = "Pusher B Down"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(540, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 25)
        Me.Label4.TabIndex = 419
        Me.Label4.Tag = ""
        Me.Label4.Text = "Pusher B Up"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(540, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(231, 25)
        Me.Label5.TabIndex = 418
        Me.Label5.Tag = ""
        Me.Label5.Text = "BBT Pusher B"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.KremerIoField1)
        Me.Controls.Add(Me.KremerIoField2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ioPusherBDown)
        Me.Controls.Add(Me.ioPusherBUp)
        Me.Controls.Add(Me.ioPusherADown)
        Me.Controls.Add(Me.ioPusherAUp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label29)
        Me.Name = "CT"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "555"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents hmiDenesterPresent As KremerControlsWin32.KremerVariable
    Friend WithEvents ioPusherBDown As KremerControlsWin32.KremerIoField
    Friend WithEvents ioPusherBUp As KremerControlsWin32.KremerIoField
    Friend WithEvents ioPusherADown As KremerControlsWin32.KremerIoField
    Friend WithEvents ioPusherAUp As KremerControlsWin32.KremerIoField
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents KremerIoField1 As KremerControlsWin32.KremerIoField
    Friend WithEvents KremerIoField2 As KremerControlsWin32.KremerIoField
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
