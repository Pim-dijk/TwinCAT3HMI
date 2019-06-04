<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CT_BBT
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
        Me.components = New System.ComponentModel.Container
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.PusherAUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioPusherAUp = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PusherADown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioPusherADown = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PusherBUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioPusherBUp = New KremerControlsWin32.KremerIoField(Me.components)
        Me.PusherBDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioPusherBDown = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Btn_Overview = New KremerControlsWin32.KremerButton
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.PusherAUp)
        Me.VarCollector.Variables.Add(Me.PusherADown)
        Me.VarCollector.Variables.Add(Me.PusherBUp)
        Me.VarCollector.Variables.Add(Me.PusherBDown)
        '
        'PusherAUp
        '
        Me.PusherAUp.BindControl = Me.ioPusherAUp
        Me.PusherAUp.BindProperty = "Data"
        Me.PusherAUp.Data = Nothing
        Me.PusherAUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.PusherAUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PusherAUp.VariableName = "InlineAutomation.Stacking.BundleBufferTrack.PusherA.Cilinder.Check.LastTime_Cil_O" & _
            "ut"
        '
        'ioPusherAUp
        '
        Me.ioPusherAUp.Audit = Nothing
        Me.ioPusherAUp.AuditEnabled = False
        Me.ioPusherAUp.AuditMessage = "KremerIoField changed:"
        Me.ioPusherAUp.AuditSource = "KremerIoField"
        Me.ioPusherAUp.AutoSize = True
        Me.ioPusherAUp.Data = 0
        Me.ioPusherAUp.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioPusherAUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioPusherAUp.InitialValue = True
        Me.ioPusherAUp.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioPusherAUp.Location = New System.Drawing.Point(201, 45)
        Me.ioPusherAUp.LowerBound = 0
        Me.ioPusherAUp.Name = "ioPusherAUp"
        Me.ioPusherAUp.OutputFormat = "0 ms"
        Me.ioPusherAUp.Size = New System.Drawing.Size(41, 18)
        Me.ioPusherAUp.TabIndex = 404
        Me.ioPusherAUp.Text = "0 ms"
        Me.ioPusherAUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioPusherAUp.UpperBound = 1000
        Me.ioPusherAUp.UserInfo = Nothing
        Me.ioPusherAUp.UserLevel = 0
        '
        'PusherADown
        '
        Me.PusherADown.BindControl = Me.ioPusherADown
        Me.PusherADown.BindProperty = "Data"
        Me.PusherADown.Data = Nothing
        Me.PusherADown.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.PusherADown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PusherADown.VariableName = "InlineAutomation.Stacking.BundleBufferTrack.PusherA.Cilinder.Check.LastTime_Cil_I" & _
            "n"
        '
        'ioPusherADown
        '
        Me.ioPusherADown.Audit = Nothing
        Me.ioPusherADown.AuditEnabled = False
        Me.ioPusherADown.AuditMessage = "KremerIoField changed:"
        Me.ioPusherADown.AuditSource = "KremerIoField"
        Me.ioPusherADown.AutoSize = True
        Me.ioPusherADown.Data = 0
        Me.ioPusherADown.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioPusherADown.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioPusherADown.InitialValue = True
        Me.ioPusherADown.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioPusherADown.Location = New System.Drawing.Point(201, 70)
        Me.ioPusherADown.LowerBound = 0
        Me.ioPusherADown.Name = "ioPusherADown"
        Me.ioPusherADown.OutputFormat = "0 ms"
        Me.ioPusherADown.Size = New System.Drawing.Size(41, 18)
        Me.ioPusherADown.TabIndex = 405
        Me.ioPusherADown.Text = "0 ms"
        Me.ioPusherADown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioPusherADown.UpperBound = 1000
        Me.ioPusherADown.UserInfo = Nothing
        Me.ioPusherADown.UserLevel = 0
        '
        'PusherBUp
        '
        Me.PusherBUp.BindControl = Me.ioPusherBUp
        Me.PusherBUp.BindProperty = "Data"
        Me.PusherBUp.Data = Nothing
        Me.PusherBUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.PusherBUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PusherBUp.VariableName = "InlineAutomation.Stacking.BundleBufferTrack.PusherB.Cilinder.Check.LastTime_Cil_O" & _
            "ut"
        '
        'ioPusherBUp
        '
        Me.ioPusherBUp.Audit = Nothing
        Me.ioPusherBUp.AuditEnabled = False
        Me.ioPusherBUp.AuditMessage = "KremerIoField changed:"
        Me.ioPusherBUp.AuditSource = "KremerIoField"
        Me.ioPusherBUp.AutoSize = True
        Me.ioPusherBUp.Data = 0
        Me.ioPusherBUp.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioPusherBUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioPusherBUp.InitialValue = True
        Me.ioPusherBUp.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioPusherBUp.Location = New System.Drawing.Point(455, 45)
        Me.ioPusherBUp.LowerBound = 0
        Me.ioPusherBUp.Name = "ioPusherBUp"
        Me.ioPusherBUp.OutputFormat = "0 ms"
        Me.ioPusherBUp.Size = New System.Drawing.Size(41, 18)
        Me.ioPusherBUp.TabIndex = 406
        Me.ioPusherBUp.Text = "0 ms"
        Me.ioPusherBUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioPusherBUp.UpperBound = 1000
        Me.ioPusherBUp.UserInfo = Nothing
        Me.ioPusherBUp.UserLevel = 0
        '
        'PusherBDown
        '
        Me.PusherBDown.BindControl = Me.ioPusherBDown
        Me.PusherBDown.BindProperty = "Data"
        Me.PusherBDown.Data = Nothing
        Me.PusherBDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.PusherBDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PusherBDown.VariableName = "InlineAutomation.Stacking.BundleBufferTrack.PusherB.Cilinder.Check.LastTime_Cil_I" & _
            "n"
        '
        'ioPusherBDown
        '
        Me.ioPusherBDown.Audit = Nothing
        Me.ioPusherBDown.AuditEnabled = False
        Me.ioPusherBDown.AuditMessage = "KremerIoField changed:"
        Me.ioPusherBDown.AuditSource = "KremerIoField"
        Me.ioPusherBDown.AutoSize = True
        Me.ioPusherBDown.Data = 0
        Me.ioPusherBDown.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioPusherBDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioPusherBDown.InitialValue = True
        Me.ioPusherBDown.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioPusherBDown.Location = New System.Drawing.Point(455, 70)
        Me.ioPusherBDown.LowerBound = 0
        Me.ioPusherBDown.Name = "ioPusherBDown"
        Me.ioPusherBDown.OutputFormat = "0 ms"
        Me.ioPusherBDown.Size = New System.Drawing.Size(41, 18)
        Me.ioPusherBDown.TabIndex = 407
        Me.ioPusherBDown.Text = "0 ms"
        Me.ioPusherBDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioPusherBDown.UpperBound = 1000
        Me.ioPusherBDown.UserInfo = Nothing
        Me.ioPusherBDown.UserLevel = 0
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
        Me.Btn_Overview.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Overview.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_Overview.Location = New System.Drawing.Point(684, 382)
        Me.Btn_Overview.Name = "Btn_Overview"
        Me.Btn_Overview.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Overview.State = False
        Me.Btn_Overview.StateIsData = True
        Me.Btn_Overview.StateText = New String() {Nothing, Nothing}
        Me.Btn_Overview.TabIndex = 5
        Me.Btn_Overview.Tag = "194"
        Me.Btn_Overview.Text = "Overview"
        Me.Btn_Overview.UserInfo = Nothing
        Me.Btn_Overview.UserLevel = 0
        Me.Btn_Overview.UseStateText = False
        Me.Btn_Overview.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(11, 10)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(231, 25)
        Me.Label29.TabIndex = 339
        Me.Label29.Tag = ""
        Me.Label29.Text = "BBT Pusher A"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(11, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 25)
        Me.Label14.TabIndex = 343
        Me.Label14.Tag = ""
        Me.Label14.Text = "Pusher A Up"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(11, 65)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(140, 25)
        Me.Label30.TabIndex = 345
        Me.Label30.Tag = ""
        Me.Label30.Text = "Pusher A Down"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 25)
        Me.Label2.TabIndex = 356
        Me.Label2.Tag = ""
        Me.Label2.Text = "Pusher B Down"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(284, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 25)
        Me.Label3.TabIndex = 354
        Me.Label3.Tag = ""
        Me.Label3.Text = "Pusher B Up"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(284, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(231, 25)
        Me.Label6.TabIndex = 350
        Me.Label6.Tag = ""
        Me.Label6.Text = "BBT Pusher B"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CT_BBT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Controls.Add(Me.Btn_Overview)
        Me.Name = "CT_BBT"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "558"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PusherAUp As KremerControlsWin32.KremerVariable
    Friend WithEvents ioPusherAUp As KremerControlsWin32.KremerIoField
    Friend WithEvents PusherADown As KremerControlsWin32.KremerVariable
    Friend WithEvents ioPusherADown As KremerControlsWin32.KremerIoField
    Friend WithEvents PusherBUp As KremerControlsWin32.KremerVariable
    Friend WithEvents ioPusherBUp As KremerControlsWin32.KremerIoField
    Friend WithEvents PusherBDown As KremerControlsWin32.KremerVariable
    Friend WithEvents ioPusherBDown As KremerControlsWin32.KremerIoField

End Class
