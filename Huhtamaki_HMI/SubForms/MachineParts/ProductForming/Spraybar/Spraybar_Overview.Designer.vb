<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Spraybar_overview
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
        Me.Btn_Manual = New KremerControlsWin32.KremerButton()
        Me.Btn_Settings = New KremerControlsWin32.KremerButton()
        Me.Pnl_Status_init = New System.Windows.Forms.Panel()
        Me.State_Pickuphead = New KremerControlsWin32.KremerStatusBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.mxAutoMode = New KremerControlsWin32.KremerVariable(Me.components)
        Me.actPos = New KremerControlsWin32.KremerVariable(Me.components)
        Me.IOActPos = New KremerControlsWin32.KremerIoField(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Flash = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Li_RestBack = New KremerControlsWin32.KremerLight()
        Me.Li_RestFront = New KremerControlsWin32.KremerLight()
        Me.Btn_Overview = New KremerControlsWin32.KremerButton()
        Me.SBisFront = New KremerControlsWin32.KremerVariable(Me.components)
        Me.SBisBack = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Pnl_Status_init.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Btn_Manual.Location = New System.Drawing.Point(684, 377)
        Me.Btn_Manual.Name = "Btn_Manual"
        Me.Btn_Manual.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Manual.State = False
        Me.Btn_Manual.StateIsData = True
        Me.Btn_Manual.StateText = New String() {Nothing, Nothing}
        Me.Btn_Manual.TabIndex = 0
        Me.Btn_Manual.Tag = "192"
        Me.Btn_Manual.Text = "Manual Control"
        Me.Btn_Manual.UserInfo = Nothing
        Me.Btn_Manual.UserLevel = 0
        Me.Btn_Manual.UseStateText = False
        Me.Btn_Manual.UseVisualStyleBackColor = True
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
        Me.Btn_Settings.Data = False
        Me.Btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Settings.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Settings.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_Settings.Location = New System.Drawing.Point(684, 321)
        Me.Btn_Settings.Name = "Btn_Settings"
        Me.Btn_Settings.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Settings.State = False
        Me.Btn_Settings.StateIsData = True
        Me.Btn_Settings.StateText = New String() {Nothing, Nothing}
        Me.Btn_Settings.TabIndex = 1
        Me.Btn_Settings.Tag = "193"
        Me.Btn_Settings.Text = "Settings"
        Me.Btn_Settings.UserInfo = Nothing
        Me.Btn_Settings.UserLevel = 0
        Me.Btn_Settings.UseStateText = False
        Me.Btn_Settings.UseVisualStyleBackColor = True
        '
        'Pnl_Status_init
        '
        Me.Pnl_Status_init.BackColor = System.Drawing.Color.White
        Me.Pnl_Status_init.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pnl_Status_init.Controls.Add(Me.State_Pickuphead)
        Me.Pnl_Status_init.Controls.Add(Me.Label2)
        Me.Pnl_Status_init.Location = New System.Drawing.Point(3, 321)
        Me.Pnl_Status_init.Name = "Pnl_Status_init"
        Me.Pnl_Status_init.Size = New System.Drawing.Size(675, 106)
        Me.Pnl_Status_init.TabIndex = 2
        '
        'State_Pickuphead
        '
        Me.State_Pickuphead.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.State_Pickuphead.BackColorOn = System.Drawing.Color.Lime
        Me.State_Pickuphead.Data = 0
        Me.State_Pickuphead.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.State_Pickuphead.ForeColor = System.Drawing.Color.Navy
        Me.State_Pickuphead.ForeColorOn = System.Drawing.Color.Black
        Me.State_Pickuphead.Location = New System.Drawing.Point(230, 2)
        Me.State_Pickuphead.Name = "State_Pickuphead"
        Me.State_Pickuphead.Size = New System.Drawing.Size(443, 19)
        Me.State_Pickuphead.State = False
        Me.State_Pickuphead.StatusText = Nothing
        Me.State_Pickuphead.TabIndex = 38
        Me.State_Pickuphead.Text = "State"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(0, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 20)
        Me.Label2.TabIndex = 39
        Me.Label2.Tag = ""
        Me.Label2.Text = "Spraybar:"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblStatus.ForeColor = System.Drawing.Color.Navy
        Me.lblStatus.Location = New System.Drawing.Point(2, 292)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(675, 26)
        Me.lblStatus.TabIndex = 33
        Me.lblStatus.Tag = "77"
        Me.lblStatus.Text = "Init Cycles"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Me.VarCollector
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.mxAutoMode)
        Me.VarCollector.Variables.Add(Me.actPos)
        Me.VarCollector.Variables.Add(Me.SBisFront)
        Me.VarCollector.Variables.Add(Me.SBisBack)
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
        'actPos
        '
        Me.actPos.BindControl = Me.IOActPos
        Me.actPos.BindProperty = "Data"
        Me.actPos.Data = Nothing
        Me.actPos.DataType = KremerControlsWin32.KremerVariable.VarDataType.LREAL
        Me.actPos.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.actPos.VariableName = "MAIN.InMoldDrying.ProductForming.SprayBarMotor.ActPosition"
        '
        'IOActPos
        '
        Me.IOActPos.Audit = Nothing
        Me.IOActPos.AuditEnabled = False
        Me.IOActPos.AuditMessage = "KremerIoField changed:"
        Me.IOActPos.AuditSource = "KremerIoField"
        Me.IOActPos.Data = 0.0R
        Me.IOActPos.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IOActPos.InitialValue = True
        Me.IOActPos.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.IOActPos.Location = New System.Drawing.Point(561, 131)
        Me.IOActPos.LowerBound = 0.0R
        Me.IOActPos.Name = "IOActPos"
        Me.IOActPos.OutputFormat = "0.0 mm"
        Me.IOActPos.Size = New System.Drawing.Size(71, 21)
        Me.IOActPos.TabIndex = 272
        Me.IOActPos.Text = "0.0 mm"
        Me.IOActPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IOActPos.UpperBound = 1000.0R
        Me.IOActPos.UserInfo = Nothing
        Me.IOActPos.UserLevel = 0
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(800, 430)
        Me.ShapeContainer1.TabIndex = 34
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.RectangleShape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape3.CornerRadius = 10
        Me.RectangleShape3.Location = New System.Drawing.Point(213, 98)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(331, 20)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.RectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape2.CornerRadius = 10
        Me.RectangleShape2.Location = New System.Drawing.Point(212, 67)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(331, 20)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.Location = New System.Drawing.Point(228, 45)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(300, 200)
        '
        'Flash
        '
        Me.Flash.AutoSize = True
        Me.Flash.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Flash.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Flash.Location = New System.Drawing.Point(362, 71)
        Me.Flash.Name = "Flash"
        Me.Flash.Size = New System.Drawing.Size(41, 16)
        Me.Flash.TabIndex = 35
        Me.Flash.Text = "Flash"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(362, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 16)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Wire"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(596, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 23)
        Me.Label9.TabIndex = 271
        Me.Label9.Tag = ""
        Me.Label9.Text = "Rest front"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(595, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 23)
        Me.Label8.TabIndex = 270
        Me.Label8.Tag = ""
        Me.Label8.Text = "Rest back"
        '
        'Li_RestBack
        '
        Me.Li_RestBack.ColorOff = System.Drawing.Color.LightGray
        Me.Li_RestBack.ColorOn = System.Drawing.Color.Lime
        Me.Li_RestBack.Data = False
        Me.Li_RestBack.Line = True
        Me.Li_RestBack.LineSize = 1
        Me.Li_RestBack.Location = New System.Drawing.Point(564, 252)
        Me.Li_RestBack.Name = "Li_RestBack"
        Me.Li_RestBack.Size = New System.Drawing.Size(25, 25)
        Me.Li_RestBack.TabIndex = 265
        Me.Li_RestBack.Text = "KremerLight2"
        Me.Li_RestBack.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Li_RestFront
        '
        Me.Li_RestFront.ColorOff = System.Drawing.Color.LightGray
        Me.Li_RestFront.ColorOn = System.Drawing.Color.Lime
        Me.Li_RestFront.Data = False
        Me.Li_RestFront.Line = True
        Me.Li_RestFront.LineSize = 1
        Me.Li_RestFront.Location = New System.Drawing.Point(564, 14)
        Me.Li_RestFront.Name = "Li_RestFront"
        Me.Li_RestFront.Size = New System.Drawing.Size(25, 25)
        Me.Li_RestFront.TabIndex = 264
        Me.Li_RestFront.Text = "KremerLight1"
        Me.Li_RestFront.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
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
        Me.Btn_Overview.Location = New System.Drawing.Point(683, 265)
        Me.Btn_Overview.Name = "Btn_Overview"
        Me.Btn_Overview.Size = New System.Drawing.Size(114, 50)
        Me.Btn_Overview.State = False
        Me.Btn_Overview.StateIsData = True
        Me.Btn_Overview.StateText = New String() {Nothing, Nothing}
        Me.Btn_Overview.TabIndex = 273
        Me.Btn_Overview.Tag = "194"
        Me.Btn_Overview.Text = "Overview"
        Me.Btn_Overview.UserInfo = Nothing
        Me.Btn_Overview.UserLevel = 0
        Me.Btn_Overview.UseStateText = False
        Me.Btn_Overview.UseVisualStyleBackColor = True
        '
        'SBisFront
        '
        Me.SBisFront.BindControl = Me.Li_RestFront
        Me.SBisFront.BindProperty = "Data"
        Me.SBisFront.Data = Nothing
        Me.SBisFront.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.SBisFront.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SBisFront.VariableName = "MAIN.InMoldDrying.ProductForming.mxSprayBarAtRestPosFront"
        '
        'SBisBack
        '
        Me.SBisBack.BindControl = Me.Li_RestBack
        Me.SBisBack.BindProperty = "Data"
        Me.SBisBack.Data = Nothing
        Me.SBisBack.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.SBisBack.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.SBisBack.VariableName = "MAIN.InMoldDrying.ProductForming.mxSprayBarAtRestPosBack"
        '
        'Spraybar_overview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Btn_Overview)
        Me.Controls.Add(Me.IOActPos)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Li_RestBack)
        Me.Controls.Add(Me.Li_RestFront)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Flash)
        Me.Controls.Add(Me.Pnl_Status_init)
        Me.Controls.Add(Me.Btn_Settings)
        Me.Controls.Add(Me.Btn_Manual)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Spraybar_overview"
        Me.Size = New System.Drawing.Size(800, 430)
        Me.Tag = "90"
        Me.Pnl_Status_init.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Manual As KremerControlsWin32.KremerButton
    Friend WithEvents Btn_Settings As KremerControlsWin32.KremerButton
    Friend WithEvents Pnl_Status_init As System.Windows.Forms.Panel
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents State_Pickuphead As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Flash As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IOActPos As KremerControlsWin32.KremerIoField
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Li_RestBack As KremerControlsWin32.KremerLight
    Friend WithEvents Li_RestFront As KremerControlsWin32.KremerLight
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents actPos As KremerControlsWin32.KremerVariable
    Friend WithEvents mxAutoMode As KremerControlsWin32.KremerVariable
    Friend WithEvents SBisFront As KremerControlsWin32.KremerVariable
    Friend WithEvents SBisBack As KremerControlsWin32.KremerVariable

End Class
