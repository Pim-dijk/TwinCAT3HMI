<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IO_ProductForming
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
        Me.IO_BotSidePressure = New KremerControlsWin32.KremerIoField(Me.components)
        Me.IO_RodSidePress = New KremerControlsWin32.KremerIoField(Me.components)
        Me.KL_FpvOpened = New KremerControlsWin32.KremerLight()
        Me.KL_FpvClosed = New KremerControlsWin32.KremerLight()
        Me.KL_Pulp01Selected = New KremerControlsWin32.KremerLight()
        Me.KL_Pulp02Selected = New KremerControlsWin32.KremerLight()
        Me.KL_Blowoff = New KremerControlsWin32.KremerLight()
        Me.KL_Vacuum = New KremerControlsWin32.KremerLight()
        Me.KL_ValveUp = New KremerControlsWin32.KremerLight()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.IO_TankLvl2 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.IO_TankLvl1 = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.KL_ValveDown = New KremerControlsWin32.KremerLight()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.KL_ValveSlow = New KremerControlsWin32.KremerLight()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.KL_Flash = New KremerControlsWin32.KremerLight()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.KL_Wire = New KremerControlsWin32.KremerLight()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.KL_FpvClose = New KremerControlsWin32.KremerLight()
        Me.KL_FpvOpen = New KremerControlsWin32.KremerLight()
        Me.FPV_Openend = New KremerControlsWin32.KremerVariable(Me.components)
        Me.FPV_Closed = New KremerControlsWin32.KremerVariable(Me.components)
        Me.PulpTank01Selected = New KremerControlsWin32.KremerVariable(Me.components)
        Me.PulpTank02Selected = New KremerControlsWin32.KremerVariable(Me.components)
        Me.RodSide = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BotSide = New KremerControlsWin32.KremerVariable(Me.components)
        Me.TankLevel01 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.TankLevel02 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Blowoff = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Vacuum = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ValveUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ValveDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ValveSlow = New KremerControlsWin32.KremerVariable(Me.components)
        Me.FpvOpen = New KremerControlsWin32.KremerVariable(Me.components)
        Me.FpvClose = New KremerControlsWin32.KremerVariable(Me.components)
        Me.WireSprayValve = New KremerControlsWin32.KremerVariable(Me.components)
        Me.FlashSprayValve = New KremerControlsWin32.KremerVariable(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.RodSide)
        Me.VarCollector.Variables.Add(Me.BotSide)
        Me.VarCollector.Variables.Add(Me.TankLevel02)
        Me.VarCollector.Variables.Add(Me.TankLevel01)
        Me.VarCollector.Variables.Add(Me.FPV_Openend)
        Me.VarCollector.Variables.Add(Me.FPV_Closed)
        Me.VarCollector.Variables.Add(Me.PulpTank01Selected)
        Me.VarCollector.Variables.Add(Me.PulpTank02Selected)
        Me.VarCollector.Variables.Add(Me.Blowoff)
        Me.VarCollector.Variables.Add(Me.Vacuum)
        Me.VarCollector.Variables.Add(Me.ValveUp)
        Me.VarCollector.Variables.Add(Me.ValveDown)
        Me.VarCollector.Variables.Add(Me.ValveSlow)
        Me.VarCollector.Variables.Add(Me.FpvOpen)
        Me.VarCollector.Variables.Add(Me.FpvClose)
        Me.VarCollector.Variables.Add(Me.WireSprayValve)
        Me.VarCollector.Variables.Add(Me.FlashSprayValve)
        '
        'IO_BotSidePressure
        '
        Me.IO_BotSidePressure.Audit = Nothing
        Me.IO_BotSidePressure.AuditEnabled = False
        Me.IO_BotSidePressure.AuditMessage = "KremerIoField changed:"
        Me.IO_BotSidePressure.AuditSource = "KremerIoField"
        Me.IO_BotSidePressure.AutoSize = True
        Me.IO_BotSidePressure.Data = 0.0R
        Me.IO_BotSidePressure.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_BotSidePressure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_BotSidePressure.InitialValue = True
        Me.IO_BotSidePressure.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_BotSidePressure.Location = New System.Drawing.Point(7, 146)
        Me.IO_BotSidePressure.LowerBound = 0.0R
        Me.IO_BotSidePressure.Name = "IO_BotSidePressure"
        Me.IO_BotSidePressure.OutputFormat = "0.0 "
        Me.IO_BotSidePressure.Size = New System.Drawing.Size(28, 16)
        Me.IO_BotSidePressure.TabIndex = 308
        Me.IO_BotSidePressure.Text = "0.0 "
        Me.IO_BotSidePressure.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_BotSidePressure.UpperBound = 1000.0R
        Me.IO_BotSidePressure.UserInfo = Nothing
        Me.IO_BotSidePressure.UserLevel = 0
        '
        'IO_RodSidePress
        '
        Me.IO_RodSidePress.Audit = Nothing
        Me.IO_RodSidePress.AuditEnabled = False
        Me.IO_RodSidePress.AuditMessage = "KremerIoField changed:"
        Me.IO_RodSidePress.AuditSource = "KremerIoField"
        Me.IO_RodSidePress.AutoSize = True
        Me.IO_RodSidePress.Data = 0.0R
        Me.IO_RodSidePress.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_RodSidePress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_RodSidePress.InitialValue = True
        Me.IO_RodSidePress.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_RodSidePress.Location = New System.Drawing.Point(7, 128)
        Me.IO_RodSidePress.LowerBound = 0.0R
        Me.IO_RodSidePress.Name = "IO_RodSidePress"
        Me.IO_RodSidePress.OutputFormat = "0.0 "
        Me.IO_RodSidePress.Size = New System.Drawing.Size(28, 16)
        Me.IO_RodSidePress.TabIndex = 307
        Me.IO_RodSidePress.Text = "0.0 "
        Me.IO_RodSidePress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_RodSidePress.UpperBound = 1000.0R
        Me.IO_RodSidePress.UserInfo = Nothing
        Me.IO_RodSidePress.UserLevel = 0
        '
        'KL_FpvOpened
        '
        Me.KL_FpvOpened.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_FpvOpened.ColorOn = System.Drawing.Color.Lime
        Me.KL_FpvOpened.Data = False
        Me.KL_FpvOpened.Line = True
        Me.KL_FpvOpened.LineSize = 1
        Me.KL_FpvOpened.Location = New System.Drawing.Point(10, 25)
        Me.KL_FpvOpened.Name = "KL_FpvOpened"
        Me.KL_FpvOpened.Size = New System.Drawing.Size(20, 20)
        Me.KL_FpvOpened.TabIndex = 290
        Me.KL_FpvOpened.Text = "KL_TMA_EsA"
        Me.KL_FpvOpened.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_FpvClosed
        '
        Me.KL_FpvClosed.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_FpvClosed.ColorOn = System.Drawing.Color.Lime
        Me.KL_FpvClosed.Data = False
        Me.KL_FpvClosed.Line = True
        Me.KL_FpvClosed.LineSize = 1
        Me.KL_FpvClosed.Location = New System.Drawing.Point(10, 46)
        Me.KL_FpvClosed.Name = "KL_FpvClosed"
        Me.KL_FpvClosed.Size = New System.Drawing.Size(20, 20)
        Me.KL_FpvClosed.TabIndex = 292
        Me.KL_FpvClosed.Text = "KL_TMA_EsB"
        Me.KL_FpvClosed.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_Pulp01Selected
        '
        Me.KL_Pulp01Selected.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_Pulp01Selected.ColorOn = System.Drawing.Color.Lime
        Me.KL_Pulp01Selected.Data = False
        Me.KL_Pulp01Selected.Line = True
        Me.KL_Pulp01Selected.LineSize = 1
        Me.KL_Pulp01Selected.Location = New System.Drawing.Point(10, 67)
        Me.KL_Pulp01Selected.Name = "KL_Pulp01Selected"
        Me.KL_Pulp01Selected.Size = New System.Drawing.Size(20, 20)
        Me.KL_Pulp01Selected.TabIndex = 294
        Me.KL_Pulp01Selected.Text = "KL_TMA_MspaRTO"
        Me.KL_Pulp01Selected.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_Pulp02Selected
        '
        Me.KL_Pulp02Selected.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_Pulp02Selected.ColorOn = System.Drawing.Color.Lime
        Me.KL_Pulp02Selected.Data = False
        Me.KL_Pulp02Selected.Line = True
        Me.KL_Pulp02Selected.LineSize = 1
        Me.KL_Pulp02Selected.Location = New System.Drawing.Point(10, 87)
        Me.KL_Pulp02Selected.Name = "KL_Pulp02Selected"
        Me.KL_Pulp02Selected.Size = New System.Drawing.Size(20, 20)
        Me.KL_Pulp02Selected.TabIndex = 296
        Me.KL_Pulp02Selected.Text = "KremerLight2"
        Me.KL_Pulp02Selected.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_Blowoff
        '
        Me.KL_Blowoff.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_Blowoff.ColorOn = System.Drawing.Color.Lime
        Me.KL_Blowoff.Data = False
        Me.KL_Blowoff.Line = True
        Me.KL_Blowoff.LineSize = 1
        Me.KL_Blowoff.Location = New System.Drawing.Point(10, 214)
        Me.KL_Blowoff.Name = "KL_Blowoff"
        Me.KL_Blowoff.Size = New System.Drawing.Size(20, 20)
        Me.KL_Blowoff.TabIndex = 290
        Me.KL_Blowoff.Text = "KremerLight2"
        Me.KL_Blowoff.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_Vacuum
        '
        Me.KL_Vacuum.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_Vacuum.ColorOn = System.Drawing.Color.Lime
        Me.KL_Vacuum.Data = False
        Me.KL_Vacuum.Line = True
        Me.KL_Vacuum.LineSize = 1
        Me.KL_Vacuum.Location = New System.Drawing.Point(10, 234)
        Me.KL_Vacuum.Name = "KL_Vacuum"
        Me.KL_Vacuum.Size = New System.Drawing.Size(20, 20)
        Me.KL_Vacuum.TabIndex = 292
        Me.KL_Vacuum.Text = "KremerLight4"
        Me.KL_Vacuum.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_ValveUp
        '
        Me.KL_ValveUp.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_ValveUp.ColorOn = System.Drawing.Color.Lime
        Me.KL_ValveUp.Data = False
        Me.KL_ValveUp.Line = True
        Me.KL_ValveUp.LineSize = 1
        Me.KL_ValveUp.Location = New System.Drawing.Point(10, 254)
        Me.KL_ValveUp.Name = "KL_ValveUp"
        Me.KL_ValveUp.Size = New System.Drawing.Size(20, 20)
        Me.KL_ValveUp.TabIndex = 294
        Me.KL_ValveUp.Text = "KremerLight3"
        Me.KL_ValveUp.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(68, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 20)
        Me.Label5.TabIndex = 291
        Me.Label5.Tag = ""
        Me.Label5.Text = "Feeding pulp valve open"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 20)
        Me.Label1.TabIndex = 293
        Me.Label1.Tag = ""
        Me.Label1.Text = "Feeding pulp valve close"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 20)
        Me.Label3.TabIndex = 295
        Me.Label3.Tag = ""
        Me.Label3.Text = "Pulp tank 1 selected"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.KL_ValveSlow)
        Me.GroupBox1.Controls.Add(Me.KL_Flash)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.KL_ValveDown)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Controls.Add(Me.IO_TankLvl2)
        Me.GroupBox1.Controls.Add(Me.KL_Wire)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.KL_FpvOpen)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.IO_TankLvl1)
        Me.GroupBox1.Controls.Add(Me.KL_FpvClose)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.KL_Blowoff)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.KL_ValveUp)
        Me.GroupBox1.Controls.Add(Me.IO_BotSidePressure)
        Me.GroupBox1.Controls.Add(Me.KL_Vacuum)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.IO_RodSidePress)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.KL_FpvOpened)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.KL_FpvClosed)
        Me.GroupBox1.Controls.Add(Me.KL_Pulp01Selected)
        Me.GroupBox1.Controls.Add(Me.KL_Pulp02Selected)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 429)
        Me.GroupBox1.TabIndex = 306
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product forming"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(242, 20)
        Me.Label8.TabIndex = 314
        Me.Label8.Tag = ""
        Me.Label8.Text = "Outputs"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(241, 20)
        Me.Label4.TabIndex = 313
        Me.Label4.Tag = ""
        Me.Label4.Text = "Analog inputs"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 20)
        Me.Label2.TabIndex = 295
        Me.Label2.Tag = ""
        Me.Label2.Text = "Up valve"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(68, 124)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(180, 20)
        Me.Label11.TabIndex = 309
        Me.Label11.Tag = ""
        Me.Label11.Text = "Rod side pressure"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(67, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 20)
        Me.Label6.TabIndex = 293
        Me.Label6.Tag = ""
        Me.Label6.Text = "Vacuum"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(67, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 20)
        Me.Label7.TabIndex = 291
        Me.Label7.Tag = ""
        Me.Label7.Text = "Blowoff"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(68, 142)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(181, 20)
        Me.Label13.TabIndex = 310
        Me.Label13.Tag = ""
        Me.Label13.Text = "Bot side pressure"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(68, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(181, 20)
        Me.Label12.TabIndex = 297
        Me.Label12.Tag = ""
        Me.Label12.Text = "Pulp tank 2 selected"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(68, 158)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(180, 20)
        Me.Label14.TabIndex = 320
        Me.Label14.Tag = ""
        Me.Label14.Text = "Tank level 1"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IO_TankLvl2
        '
        Me.IO_TankLvl2.Audit = Nothing
        Me.IO_TankLvl2.AuditEnabled = False
        Me.IO_TankLvl2.AuditMessage = "KremerIoField changed:"
        Me.IO_TankLvl2.AuditSource = "KremerIoField"
        Me.IO_TankLvl2.AutoSize = True
        Me.IO_TankLvl2.Data = 0.0R
        Me.IO_TankLvl2.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TankLvl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TankLvl2.InitialValue = True
        Me.IO_TankLvl2.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TankLvl2.Location = New System.Drawing.Point(7, 180)
        Me.IO_TankLvl2.LowerBound = 0.0R
        Me.IO_TankLvl2.Name = "IO_TankLvl2"
        Me.IO_TankLvl2.OutputFormat = "0.0 "
        Me.IO_TankLvl2.Size = New System.Drawing.Size(28, 16)
        Me.IO_TankLvl2.TabIndex = 319
        Me.IO_TankLvl2.Text = "0.0 "
        Me.IO_TankLvl2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TankLvl2.UpperBound = 1000.0R
        Me.IO_TankLvl2.UserInfo = Nothing
        Me.IO_TankLvl2.UserLevel = 0
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(68, 176)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(181, 20)
        Me.Label15.TabIndex = 321
        Me.Label15.Tag = ""
        Me.Label15.Text = "Tank level 2"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IO_TankLvl1
        '
        Me.IO_TankLvl1.Audit = Nothing
        Me.IO_TankLvl1.AuditEnabled = False
        Me.IO_TankLvl1.AuditMessage = "KremerIoField changed:"
        Me.IO_TankLvl1.AuditSource = "KremerIoField"
        Me.IO_TankLvl1.AutoSize = True
        Me.IO_TankLvl1.Data = 0.0R
        Me.IO_TankLvl1.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.IO_TankLvl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IO_TankLvl1.InitialValue = True
        Me.IO_TankLvl1.IOType = KremerControlsWin32.KremerIoField.IO_Type.InputOutput
        Me.IO_TankLvl1.Location = New System.Drawing.Point(7, 162)
        Me.IO_TankLvl1.LowerBound = 0.0R
        Me.IO_TankLvl1.Name = "IO_TankLvl1"
        Me.IO_TankLvl1.OutputFormat = "0.0 "
        Me.IO_TankLvl1.Size = New System.Drawing.Size(28, 16)
        Me.IO_TankLvl1.TabIndex = 318
        Me.IO_TankLvl1.Text = "0.0 "
        Me.IO_TankLvl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IO_TankLvl1.UpperBound = 1000.0R
        Me.IO_TankLvl1.UserInfo = Nothing
        Me.IO_TankLvl1.UserLevel = 0
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(67, 275)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(181, 20)
        Me.Label16.TabIndex = 323
        Me.Label16.Tag = ""
        Me.Label16.Text = "Down valve"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_ValveDown
        '
        Me.KL_ValveDown.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_ValveDown.ColorOn = System.Drawing.Color.Lime
        Me.KL_ValveDown.Data = False
        Me.KL_ValveDown.Line = True
        Me.KL_ValveDown.LineSize = 1
        Me.KL_ValveDown.Location = New System.Drawing.Point(10, 274)
        Me.KL_ValveDown.Name = "KL_ValveDown"
        Me.KL_ValveDown.Size = New System.Drawing.Size(20, 20)
        Me.KL_ValveDown.TabIndex = 322
        Me.KL_ValveDown.Text = "KremerLight3"
        Me.KL_ValveDown.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(67, 295)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(181, 20)
        Me.Label17.TabIndex = 325
        Me.Label17.Tag = ""
        Me.Label17.Text = "Slow valve"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_ValveSlow
        '
        Me.KL_ValveSlow.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_ValveSlow.ColorOn = System.Drawing.Color.Lime
        Me.KL_ValveSlow.Data = False
        Me.KL_ValveSlow.Line = True
        Me.KL_ValveSlow.LineSize = 1
        Me.KL_ValveSlow.Location = New System.Drawing.Point(10, 294)
        Me.KL_ValveSlow.Name = "KL_ValveSlow"
        Me.KL_ValveSlow.Size = New System.Drawing.Size(20, 20)
        Me.KL_ValveSlow.TabIndex = 324
        Me.KL_ValveSlow.Text = "KremerLight3"
        Me.KL_ValveSlow.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(67, 376)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(181, 20)
        Me.Label18.TabIndex = 333
        Me.Label18.Tag = ""
        Me.Label18.Text = "Flash spray valve"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_Flash
        '
        Me.KL_Flash.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_Flash.ColorOn = System.Drawing.Color.Lime
        Me.KL_Flash.Data = False
        Me.KL_Flash.Line = True
        Me.KL_Flash.LineSize = 1
        Me.KL_Flash.Location = New System.Drawing.Point(10, 375)
        Me.KL_Flash.Name = "KL_Flash"
        Me.KL_Flash.Size = New System.Drawing.Size(20, 20)
        Me.KL_Flash.TabIndex = 332
        Me.KL_Flash.Text = "KremerLight3"
        Me.KL_Flash.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(67, 356)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(181, 20)
        Me.Label19.TabIndex = 331
        Me.Label19.Tag = ""
        Me.Label19.Text = "Wire spray valve"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_Wire
        '
        Me.KL_Wire.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_Wire.ColorOn = System.Drawing.Color.Lime
        Me.KL_Wire.Data = False
        Me.KL_Wire.Line = True
        Me.KL_Wire.LineSize = 1
        Me.KL_Wire.Location = New System.Drawing.Point(10, 355)
        Me.KL_Wire.Name = "KL_Wire"
        Me.KL_Wire.Size = New System.Drawing.Size(20, 20)
        Me.KL_Wire.TabIndex = 330
        Me.KL_Wire.Text = "KremerLight3"
        Me.KL_Wire.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(67, 336)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(181, 20)
        Me.Label28.TabIndex = 329
        Me.Label28.Tag = ""
        Me.Label28.Text = "Feeding pulp valve close"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(67, 315)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(181, 20)
        Me.Label39.TabIndex = 327
        Me.Label39.Tag = ""
        Me.Label39.Text = "Feeding pulp valve open"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_FpvClose
        '
        Me.KL_FpvClose.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_FpvClose.ColorOn = System.Drawing.Color.Lime
        Me.KL_FpvClose.Data = False
        Me.KL_FpvClose.Line = True
        Me.KL_FpvClose.LineSize = 1
        Me.KL_FpvClose.Location = New System.Drawing.Point(10, 335)
        Me.KL_FpvClose.Name = "KL_FpvClose"
        Me.KL_FpvClose.Size = New System.Drawing.Size(20, 20)
        Me.KL_FpvClose.TabIndex = 328
        Me.KL_FpvClose.Text = "KremerLight3"
        Me.KL_FpvClose.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_FpvOpen
        '
        Me.KL_FpvOpen.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_FpvOpen.ColorOn = System.Drawing.Color.Lime
        Me.KL_FpvOpen.Data = False
        Me.KL_FpvOpen.Line = True
        Me.KL_FpvOpen.LineSize = 1
        Me.KL_FpvOpen.Location = New System.Drawing.Point(10, 315)
        Me.KL_FpvOpen.Name = "KL_FpvOpen"
        Me.KL_FpvOpen.Size = New System.Drawing.Size(20, 20)
        Me.KL_FpvOpen.TabIndex = 326
        Me.KL_FpvOpen.Text = "KremerLight4"
        Me.KL_FpvOpen.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'FPV_Openend
        '
        Me.FPV_Openend.BindControl = Me.KL_FpvOpened
        Me.FPV_Openend.BindProperty = "Data"
        Me.FPV_Openend.Data = Nothing
        Me.FPV_Openend.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.FPV_Openend.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FPV_Openend.VariableName = "MAIN.InMoldDrying.ProductForming.FeedingPulp.IxIsIn"
        '
        'FPV_Closed
        '
        Me.FPV_Closed.BindControl = Me.KL_FpvClosed
        Me.FPV_Closed.BindProperty = "Data"
        Me.FPV_Closed.Data = Nothing
        Me.FPV_Closed.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.FPV_Closed.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FPV_Closed.VariableName = "MAIN.InMoldDrying.ProductForming.FeedingPulp.IxIsOut"
        '
        'PulpTank01Selected
        '
        Me.PulpTank01Selected.BindControl = Me.KL_Pulp01Selected
        Me.PulpTank01Selected.BindProperty = "Data"
        Me.PulpTank01Selected.Data = Nothing
        Me.PulpTank01Selected.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PulpTank01Selected.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PulpTank01Selected.VariableName = "MAIN.InMoldDrying.ProductForming.ixPulpTank01"
        '
        'PulpTank02Selected
        '
        Me.PulpTank02Selected.BindControl = Me.KL_Pulp02Selected
        Me.PulpTank02Selected.BindProperty = "Data"
        Me.PulpTank02Selected.Data = Nothing
        Me.PulpTank02Selected.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.PulpTank02Selected.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.PulpTank02Selected.VariableName = "MAIN.InMoldDrying.ProductForming.ixPulpTank02"
        '
        'RodSide
        '
        Me.RodSide.BindControl = Me.IO_RodSidePress
        Me.RodSide.BindProperty = "Data"
        Me.RodSide.Data = Nothing
        Me.RodSide.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.RodSide.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.RodSide.VariableName = "MAIN.InMoldDrying.ProductForming.PondHydraulicCilinder.RodSidePressure.RawInput"
        '
        'BotSide
        '
        Me.BotSide.BindControl = Me.IO_BotSidePressure
        Me.BotSide.BindProperty = "Data"
        Me.BotSide.Data = Nothing
        Me.BotSide.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.BotSide.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BotSide.VariableName = "MAIN.InMoldDrying.ProductForming.PondHydraulicCilinder.BottomSidePressure.RawInpu" & _
    "t"
        '
        'TankLevel01
        '
        Me.TankLevel01.BindControl = Me.IO_TankLvl1
        Me.TankLevel01.BindProperty = "Data"
        Me.TankLevel01.Data = Nothing
        Me.TankLevel01.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.TankLevel01.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TankLevel01.VariableName = "MAIN.InMoldDrying.ProductForming.TankLevel01.RawInput"
        '
        'TankLevel02
        '
        Me.TankLevel02.BindControl = Me.IO_TankLvl2
        Me.TankLevel02.BindProperty = "Data"
        Me.TankLevel02.Data = Nothing
        Me.TankLevel02.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.TankLevel02.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TankLevel02.VariableName = "MAIN.InMoldDrying.ProductForming.TankLevel02.RawInput"
        '
        'Blowoff
        '
        Me.Blowoff.BindControl = Me.KL_Blowoff
        Me.Blowoff.BindProperty = "Data"
        Me.Blowoff.Data = Nothing
        Me.Blowoff.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Blowoff.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Blowoff.VariableName = "MAIN.InMoldDrying.ProductForming.MoldBlowOff.Q"
        '
        'Vacuum
        '
        Me.Vacuum.BindControl = Me.KL_Vacuum
        Me.Vacuum.BindProperty = "Data"
        Me.Vacuum.Data = Nothing
        Me.Vacuum.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Vacuum.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Vacuum.VariableName = "MAIN.InMoldDrying.ProductForming.MoldVacuum.Q"
        '
        'ValveUp
        '
        Me.ValveUp.BindControl = Me.KL_ValveUp
        Me.ValveUp.BindProperty = "Data"
        Me.ValveUp.Data = Nothing
        Me.ValveUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ValveUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ValveUp.VariableName = "MAIN.InMoldDrying.ProductForming.PondHydraulicCilinder.HydraulicIn.Q"
        '
        'ValveDown
        '
        Me.ValveDown.BindControl = Me.KL_ValveDown
        Me.ValveDown.BindProperty = "Data"
        Me.ValveDown.Data = Nothing
        Me.ValveDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ValveDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ValveDown.VariableName = "MAIN.InMoldDrying.ProductForming.PondHydraulicCilinder.HydraulicOut.Q"
        '
        'ValveSlow
        '
        Me.ValveSlow.BindControl = Me.KL_ValveSlow
        Me.ValveSlow.BindProperty = "Data"
        Me.ValveSlow.Data = Nothing
        Me.ValveSlow.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ValveSlow.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ValveSlow.VariableName = "MAIN.InMoldDrying.ProductForming.PondHydraulicCilinder.HydraulicSlow.Q"
        '
        'FpvOpen
        '
        Me.FpvOpen.BindControl = Me.KL_FpvOpen
        Me.FpvOpen.BindProperty = "Data"
        Me.FpvOpen.Data = Nothing
        Me.FpvOpen.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.FpvOpen.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FpvOpen.VariableName = "MAIN.InMoldDrying.ProductForming.FeedingPulp.QxIn"
        '
        'FpvClose
        '
        Me.FpvClose.BindControl = Me.KL_FpvClose
        Me.FpvClose.BindProperty = "Data"
        Me.FpvClose.Data = Nothing
        Me.FpvClose.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.FpvClose.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FpvClose.VariableName = "MAIN.InMoldDrying.ProductForming.FeedingPulp.QxOut"
        '
        'WireSprayValve
        '
        Me.WireSprayValve.BindControl = Me.KL_Wire
        Me.WireSprayValve.BindProperty = "Data"
        Me.WireSprayValve.Data = Nothing
        Me.WireSprayValve.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.WireSprayValve.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.WireSprayValve.VariableName = "MAIN.InMoldDrying.ProductForming.WireSprayValve.Q"
        '
        'FlashSprayValve
        '
        Me.FlashSprayValve.BindControl = Me.KL_Flash
        Me.FlashSprayValve.BindProperty = "Data"
        Me.FlashSprayValve.Data = Nothing
        Me.FlashSprayValve.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.FlashSprayValve.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FlashSprayValve.VariableName = "MAIN.InMoldDrying.ProductForming.FlashSprayValve.Q"
        '
        'IO_ProductForming
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "IO_ProductForming"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "540"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents KL_FpvClosed As KremerControlsWin32.KremerLight
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents KL_FpvOpened As KremerControlsWin32.KremerLight
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents KL_Pulp01Selected As KremerControlsWin32.KremerLight
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents KL_Pulp02Selected As KremerControlsWin32.KremerLight
    Friend WithEvents IO_BotSidePressure As KremerControlsWin32.KremerIoField
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents IO_RodSidePress As KremerControlsWin32.KremerIoField
    Friend WithEvents KL_Blowoff As KremerControlsWin32.KremerLight
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents KL_ValveUp As KremerControlsWin32.KremerLight
    Friend WithEvents KL_Vacuum As KremerControlsWin32.KremerLight
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents KL_ValveSlow As KremerControlsWin32.KremerLight
    Friend WithEvents KL_Flash As KremerControlsWin32.KremerLight
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents KL_ValveDown As KremerControlsWin32.KremerLight
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents IO_TankLvl2 As KremerControlsWin32.KremerIoField
    Friend WithEvents KL_Wire As KremerControlsWin32.KremerLight
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents KL_FpvOpen As KremerControlsWin32.KremerLight
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents IO_TankLvl1 As KremerControlsWin32.KremerIoField
    Friend WithEvents KL_FpvClose As KremerControlsWin32.KremerLight
    Friend WithEvents RodSide As KremerControlsWin32.KremerVariable
    Friend WithEvents BotSide As KremerControlsWin32.KremerVariable
    Friend WithEvents TankLevel02 As KremerControlsWin32.KremerVariable
    Friend WithEvents TankLevel01 As KremerControlsWin32.KremerVariable
    Friend WithEvents FPV_Openend As KremerControlsWin32.KremerVariable
    Friend WithEvents FPV_Closed As KremerControlsWin32.KremerVariable
    Friend WithEvents PulpTank01Selected As KremerControlsWin32.KremerVariable
    Friend WithEvents PulpTank02Selected As KremerControlsWin32.KremerVariable
    Friend WithEvents Blowoff As KremerControlsWin32.KremerVariable
    Friend WithEvents Vacuum As KremerControlsWin32.KremerVariable
    Friend WithEvents ValveUp As KremerControlsWin32.KremerVariable
    Friend WithEvents ValveDown As KremerControlsWin32.KremerVariable
    Friend WithEvents ValveSlow As KremerControlsWin32.KremerVariable
    Friend WithEvents FpvOpen As KremerControlsWin32.KremerVariable
    Friend WithEvents FpvClose As KremerControlsWin32.KremerVariable
    Friend WithEvents WireSprayValve As KremerControlsWin32.KremerVariable
    Friend WithEvents FlashSprayValve As KremerControlsWin32.KremerVariable

End Class
