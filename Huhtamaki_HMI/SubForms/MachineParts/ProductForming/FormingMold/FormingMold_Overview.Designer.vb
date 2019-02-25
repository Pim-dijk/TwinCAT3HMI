<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormingMold_Overview
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
        Me.State_Zipper = New KremerControlsWin32.KremerStatusBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Btn_Settings = New KremerControlsWin32.KremerButton()
        Me.Btn_Manual = New KremerControlsWin32.KremerButton()
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.io_HorTransp_Pos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Btn_Overview = New KremerControlsWin32.KremerButton()
        Me.SuspendLayout()
        '
        'Pnl_Status_init
        '
        Me.Pnl_Status_init.BackColor = System.Drawing.Color.White
        Me.Pnl_Status_init.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pnl_Status_init.Location = New System.Drawing.Point(3, 326)
        Me.Pnl_Status_init.Name = "Pnl_Status_init"
        Me.Pnl_Status_init.Size = New System.Drawing.Size(675, 106)
        Me.Pnl_Status_init.TabIndex = 5
        '
        'State_Zipper
        '
        Me.State_Zipper.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.State_Zipper.BackColorOn = System.Drawing.Color.Lime
        Me.State_Zipper.Data = 0
        Me.State_Zipper.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.State_Zipper.ForeColor = System.Drawing.Color.Navy
        Me.State_Zipper.ForeColorOn = System.Drawing.Color.Black
        Me.State_Zipper.Location = New System.Drawing.Point(245, 330)
        Me.State_Zipper.Name = "State_Zipper"
        Me.State_Zipper.Size = New System.Drawing.Size(433, 19)
        Me.State_Zipper.State = False
        Me.State_Zipper.StatusText = Nothing
        Me.State_Zipper.TabIndex = 37
        Me.State_Zipper.Text = "State"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(5, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 19)
        Me.Label1.TabIndex = 36
        Me.Label1.Tag = ""
        Me.Label1.Text = "Forming mold:"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.ForeColor = System.Drawing.Color.Navy
        Me.lblStatus.Location = New System.Drawing.Point(3, 299)
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
        Me.Btn_Settings.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Settings.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_Settings.Location = New System.Drawing.Point(684, 326)
        Me.Btn_Settings.Name = "Btn_Settings"
        Me.Btn_Settings.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Settings.State = False
        Me.Btn_Settings.StateIsData = True
        Me.Btn_Settings.StateText = New String() {Nothing, Nothing}
        Me.Btn_Settings.TabIndex = 4
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
        Me.Btn_Manual.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Manual.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_Manual.Location = New System.Drawing.Point(684, 382)
        Me.Btn_Manual.Name = "Btn_Manual"
        Me.Btn_Manual.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Manual.State = False
        Me.Btn_Manual.StateIsData = True
        Me.Btn_Manual.StateText = New String() {Nothing, Nothing}
        Me.Btn_Manual.TabIndex = 3
        Me.Btn_Manual.Tag = "192"
        Me.Btn_Manual.Text = "Manual" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Control"
        Me.Btn_Manual.UserInfo = Nothing
        Me.Btn_Manual.UserLevel = 0
        Me.Btn_Manual.UseStateText = False
        Me.Btn_Manual.UseVisualStyleBackColor = True
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
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
        Me.io_HorTransp_Pos.Location = New System.Drawing.Point(681, 191)
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
        Me.Btn_Overview.Location = New System.Drawing.Point(683, 270)
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
        'FormingMold_Overview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Btn_Overview)
        Me.Controls.Add(Me.io_HorTransp_Pos)
        Me.Controls.Add(Me.State_Zipper)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Pnl_Status_init)
        Me.Controls.Add(Me.Btn_Settings)
        Me.Controls.Add(Me.Btn_Manual)
        Me.Controls.Add(Me.lblStatus)
        Me.Name = "FormingMold_Overview"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "98"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pnl_Status_init As System.Windows.Forms.Panel
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Btn_Settings As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_Manual As KremerControlsWin32.KremerButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents State_Zipper As KremerControlsWin32.KremerStatusBox
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents io_HorTransp_Pos As KremerControlsWin32.KremerIoField
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton

End Class
