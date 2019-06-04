<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IO_ProductHandling
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
        Me.KL_GACollision = New KremerControlsWin32.KremerLight()
        Me.KL_GAEsHorizontalFront = New KremerControlsWin32.KremerLight()
        Me.KL_GAEsHorizontalback = New KremerControlsWin32.KremerLight()
        Me.KL_GAEsverticalUp = New KremerControlsWin32.KremerLight()
        Me.KL_EsVerticalDown = New KremerControlsWin32.KremerLight()
        Me.KL_GAInputVac1 = New KremerControlsWin32.KremerLight()
        Me.KL_GAInputVac2 = New KremerControlsWin32.KremerLight()
        Me.KL_GAInputVac3 = New KremerControlsWin32.KremerLight()
        Me.KL_GAInputVac4 = New KremerControlsWin32.KremerLight()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.KL_GAInputVac5 = New KremerControlsWin32.KremerLight()
        Me.KL_GAInputVac6 = New KremerControlsWin32.KremerLight()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.KL_GAOutputVac1 = New KremerControlsWin32.KremerLight()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.KL_GAOutputVac2 = New KremerControlsWin32.KremerLight()
        Me.KL_GAOutputVac3 = New KremerControlsWin32.KremerLight()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.KL_GAOutputVac4 = New KremerControlsWin32.KremerLight()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.KL_GAOutputVac5 = New KremerControlsWin32.KremerLight()
        Me.KL_GAOutputVac6 = New KremerControlsWin32.KremerLight()
        Me.ACollisionSensor = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AEsHorizontalFront = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AEsHorizontalBack = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AEsVerticalUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AEsVerticalDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AVacSensor1 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AVacSensor2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AVacSensor3 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AVacSensor4 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AVacSensor5 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AVacSensor6 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AVacOutp1 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AVacOutp2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AVacOutp3 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AVacOutp4 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AVacOutp5 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.AVacOutp6 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BcolisionSensor = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BEsHorizontalFront = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BEsHorizontalBack = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BEsVerticalUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BEsVerticalDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BVacSensor1 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BVacSensor2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BVacSensor3 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BVacSensor4 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BVacSensor5 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BVacSensor6 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BVacOutp1 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BVacOutp2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BVacOutp3 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BVacOutp4 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BVacOutp5 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.BVacOutp6 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.KL_BOutputVac4 = New KremerControlsWin32.KremerLight()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.KL_BOutputVac5 = New KremerControlsWin32.KremerLight()
        Me.KL_BOutputVac6 = New KremerControlsWin32.KremerLight()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.KL_BOutputVac1 = New KremerControlsWin32.KremerLight()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.KL_BOutputVac2 = New KremerControlsWin32.KremerLight()
        Me.KL_BOutputVac3 = New KremerControlsWin32.KremerLight()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.KL_BVacSens5 = New KremerControlsWin32.KremerLight()
        Me.KL_BVacSens6 = New KremerControlsWin32.KremerLight()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.KL_BEsVerticalDown = New KremerControlsWin32.KremerLight()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.KL_BColision = New KremerControlsWin32.KremerLight()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.KL_BEsHorizontalFront = New KremerControlsWin32.KremerLight()
        Me.KL_BEsHorizontalBack = New KremerControlsWin32.KremerLight()
        Me.KL_BEsVerticalUp = New KremerControlsWin32.KremerLight()
        Me.KL_BVacSens1 = New KremerControlsWin32.KremerLight()
        Me.KL_BVacSens2 = New KremerControlsWin32.KremerLight()
        Me.KL_BVacSens3 = New KremerControlsWin32.KremerLight()
        Me.KL_BVacSens4 = New KremerControlsWin32.KremerLight()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.ACollisionSensor)
        Me.VarCollector.Variables.Add(Me.AEsHorizontalFront)
        Me.VarCollector.Variables.Add(Me.AEsHorizontalBack)
        Me.VarCollector.Variables.Add(Me.AEsVerticalUp)
        Me.VarCollector.Variables.Add(Me.AEsVerticalDown)
        Me.VarCollector.Variables.Add(Me.AVacSensor1)
        Me.VarCollector.Variables.Add(Me.AVacSensor2)
        Me.VarCollector.Variables.Add(Me.AVacSensor3)
        Me.VarCollector.Variables.Add(Me.AVacSensor4)
        Me.VarCollector.Variables.Add(Me.AVacSensor5)
        Me.VarCollector.Variables.Add(Me.AVacSensor6)
        Me.VarCollector.Variables.Add(Me.AVacOutp1)
        Me.VarCollector.Variables.Add(Me.AVacOutp2)
        Me.VarCollector.Variables.Add(Me.AVacOutp3)
        Me.VarCollector.Variables.Add(Me.AVacOutp4)
        Me.VarCollector.Variables.Add(Me.AVacOutp5)
        Me.VarCollector.Variables.Add(Me.AVacOutp6)
        Me.VarCollector.Variables.Add(Me.BcolisionSensor)
        Me.VarCollector.Variables.Add(Me.BEsHorizontalFront)
        Me.VarCollector.Variables.Add(Me.BEsHorizontalBack)
        Me.VarCollector.Variables.Add(Me.BEsVerticalUp)
        Me.VarCollector.Variables.Add(Me.BEsVerticalDown)
        Me.VarCollector.Variables.Add(Me.BVacSensor1)
        Me.VarCollector.Variables.Add(Me.BVacSensor2)
        Me.VarCollector.Variables.Add(Me.BVacSensor3)
        Me.VarCollector.Variables.Add(Me.BVacSensor4)
        Me.VarCollector.Variables.Add(Me.BVacSensor5)
        Me.VarCollector.Variables.Add(Me.BVacSensor6)
        Me.VarCollector.Variables.Add(Me.BVacOutp1)
        Me.VarCollector.Variables.Add(Me.BVacOutp2)
        Me.VarCollector.Variables.Add(Me.BVacOutp3)
        Me.VarCollector.Variables.Add(Me.BVacOutp4)
        Me.VarCollector.Variables.Add(Me.BVacOutp5)
        Me.VarCollector.Variables.Add(Me.BVacOutp6)
        '
        'KL_GACollision
        '
        Me.KL_GACollision.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_GACollision.ColorOn = System.Drawing.Color.Lime
        Me.KL_GACollision.Data = False
        Me.KL_GACollision.Line = True
        Me.KL_GACollision.LineSize = 1
        Me.KL_GACollision.Location = New System.Drawing.Point(10, 25)
        Me.KL_GACollision.Name = "KL_GACollision"
        Me.KL_GACollision.Size = New System.Drawing.Size(20, 20)
        Me.KL_GACollision.TabIndex = 290
        Me.KL_GACollision.Text = "KL_GACollision"
        Me.KL_GACollision.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_GAEsHorizontalFront
        '
        Me.KL_GAEsHorizontalFront.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_GAEsHorizontalFront.ColorOn = System.Drawing.Color.Lime
        Me.KL_GAEsHorizontalFront.Data = False
        Me.KL_GAEsHorizontalFront.Line = True
        Me.KL_GAEsHorizontalFront.LineSize = 1
        Me.KL_GAEsHorizontalFront.Location = New System.Drawing.Point(10, 46)
        Me.KL_GAEsHorizontalFront.Name = "KL_GAEsHorizontalFront"
        Me.KL_GAEsHorizontalFront.Size = New System.Drawing.Size(20, 20)
        Me.KL_GAEsHorizontalFront.TabIndex = 292
        Me.KL_GAEsHorizontalFront.Text = "KL_GAEsHorizontalFront"
        Me.KL_GAEsHorizontalFront.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_GAEsHorizontalback
        '
        Me.KL_GAEsHorizontalback.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_GAEsHorizontalback.ColorOn = System.Drawing.Color.Lime
        Me.KL_GAEsHorizontalback.Data = False
        Me.KL_GAEsHorizontalback.Line = True
        Me.KL_GAEsHorizontalback.LineSize = 1
        Me.KL_GAEsHorizontalback.Location = New System.Drawing.Point(10, 67)
        Me.KL_GAEsHorizontalback.Name = "KL_GAEsHorizontalback"
        Me.KL_GAEsHorizontalback.Size = New System.Drawing.Size(20, 20)
        Me.KL_GAEsHorizontalback.TabIndex = 294
        Me.KL_GAEsHorizontalback.Text = "KL_GAEsHorizontalback"
        Me.KL_GAEsHorizontalback.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_GAEsverticalUp
        '
        Me.KL_GAEsverticalUp.ColorOff = System.Drawing.Color.Red
        Me.KL_GAEsverticalUp.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_GAEsverticalUp.Data = False
        Me.KL_GAEsverticalUp.Line = True
        Me.KL_GAEsverticalUp.LineSize = 1
        Me.KL_GAEsverticalUp.Location = New System.Drawing.Point(10, 87)
        Me.KL_GAEsverticalUp.Name = "KL_GAEsverticalUp"
        Me.KL_GAEsverticalUp.Size = New System.Drawing.Size(20, 20)
        Me.KL_GAEsverticalUp.TabIndex = 296
        Me.KL_GAEsverticalUp.Text = "KremerLight2"
        Me.KL_GAEsverticalUp.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_EsVerticalDown
        '
        Me.KL_EsVerticalDown.ColorOff = System.Drawing.Color.Red
        Me.KL_EsVerticalDown.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_EsVerticalDown.Data = False
        Me.KL_EsVerticalDown.Line = True
        Me.KL_EsVerticalDown.LineSize = 1
        Me.KL_EsVerticalDown.Location = New System.Drawing.Point(10, 108)
        Me.KL_EsVerticalDown.Name = "KL_EsVerticalDown"
        Me.KL_EsVerticalDown.Size = New System.Drawing.Size(20, 20)
        Me.KL_EsVerticalDown.TabIndex = 298
        Me.KL_EsVerticalDown.Text = "KremerLight9"
        Me.KL_EsVerticalDown.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_GAInputVac1
        '
        Me.KL_GAInputVac1.ColorOff = System.Drawing.Color.Red
        Me.KL_GAInputVac1.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_GAInputVac1.Data = False
        Me.KL_GAInputVac1.Line = True
        Me.KL_GAInputVac1.LineSize = 1
        Me.KL_GAInputVac1.Location = New System.Drawing.Point(10, 129)
        Me.KL_GAInputVac1.Name = "KL_GAInputVac1"
        Me.KL_GAInputVac1.Size = New System.Drawing.Size(20, 20)
        Me.KL_GAInputVac1.TabIndex = 300
        Me.KL_GAInputVac1.Text = "KremerLight10"
        Me.KL_GAInputVac1.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_GAInputVac2
        '
        Me.KL_GAInputVac2.ColorOff = System.Drawing.Color.Red
        Me.KL_GAInputVac2.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_GAInputVac2.Data = False
        Me.KL_GAInputVac2.Line = True
        Me.KL_GAInputVac2.LineSize = 1
        Me.KL_GAInputVac2.Location = New System.Drawing.Point(10, 150)
        Me.KL_GAInputVac2.Name = "KL_GAInputVac2"
        Me.KL_GAInputVac2.Size = New System.Drawing.Size(20, 20)
        Me.KL_GAInputVac2.TabIndex = 302
        Me.KL_GAInputVac2.Text = "KremerLight11"
        Me.KL_GAInputVac2.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_GAInputVac3
        '
        Me.KL_GAInputVac3.ColorOff = System.Drawing.Color.Red
        Me.KL_GAInputVac3.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_GAInputVac3.Data = False
        Me.KL_GAInputVac3.Line = True
        Me.KL_GAInputVac3.LineSize = 1
        Me.KL_GAInputVac3.Location = New System.Drawing.Point(10, 171)
        Me.KL_GAInputVac3.Name = "KL_GAInputVac3"
        Me.KL_GAInputVac3.Size = New System.Drawing.Size(20, 20)
        Me.KL_GAInputVac3.TabIndex = 304
        Me.KL_GAInputVac3.Text = "KremerLight12"
        Me.KL_GAInputVac3.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_GAInputVac4
        '
        Me.KL_GAInputVac4.ColorOff = System.Drawing.Color.Red
        Me.KL_GAInputVac4.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_GAInputVac4.Data = False
        Me.KL_GAInputVac4.Line = True
        Me.KL_GAInputVac4.LineSize = 1
        Me.KL_GAInputVac4.Location = New System.Drawing.Point(10, 192)
        Me.KL_GAInputVac4.Name = "KL_GAInputVac4"
        Me.KL_GAInputVac4.Size = New System.Drawing.Size(20, 20)
        Me.KL_GAInputVac4.TabIndex = 306
        Me.KL_GAInputVac4.Text = "KremerLight13"
        Me.KL_GAInputVac4.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(68, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 20)
        Me.Label5.TabIndex = 291
        Me.Label5.Tag = ""
        Me.Label5.Text = "Collision sensor active"
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
        Me.Label1.Text = "End switch horizontal front"
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
        Me.Label3.Text = "End switch horizontal back"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.KL_GAOutputVac4)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.KL_GAOutputVac5)
        Me.GroupBox1.Controls.Add(Me.KL_GAOutputVac6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.KL_GAOutputVac1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.KL_GAOutputVac2)
        Me.GroupBox1.Controls.Add(Me.KL_GAOutputVac3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.KL_GAInputVac5)
        Me.GroupBox1.Controls.Add(Me.KL_GAInputVac6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.KL_EsVerticalDown)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.KL_GACollision)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.KL_GAEsHorizontalFront)
        Me.GroupBox1.Controls.Add(Me.KL_GAEsHorizontalback)
        Me.GroupBox1.Controls.Add(Me.KL_GAEsverticalUp)
        Me.GroupBox1.Controls.Add(Me.KL_GAInputVac1)
        Me.GroupBox1.Controls.Add(Me.KL_GAInputVac2)
        Me.GroupBox1.Controls.Add(Me.KL_GAInputVac3)
        Me.GroupBox1.Controls.Add(Me.KL_GAInputVac4)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 429)
        Me.GroupBox1.TabIndex = 306
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gantry A"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(242, 20)
        Me.Label8.TabIndex = 314
        Me.Label8.Tag = ""
        Me.Label8.Text = "Outputs"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(68, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(181, 20)
        Me.Label12.TabIndex = 297
        Me.Label12.Tag = ""
        Me.Label12.Text = "End switch vertical up"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(68, 192)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(181, 20)
        Me.Label19.TabIndex = 307
        Me.Label19.Tag = ""
        Me.Label19.Text = "Vacuum sensor 4"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(68, 171)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(181, 20)
        Me.Label18.TabIndex = 305
        Me.Label18.Tag = ""
        Me.Label18.Text = "Vacuum sensor 3"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(68, 150)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(181, 20)
        Me.Label17.TabIndex = 303
        Me.Label17.Tag = ""
        Me.Label17.Text = "Vacuum sensor 2"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(68, 129)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(181, 20)
        Me.Label16.TabIndex = 301
        Me.Label16.Tag = ""
        Me.Label16.Text = "Vacuum sensor 1"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(68, 108)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(181, 20)
        Me.Label15.TabIndex = 299
        Me.Label15.Tag = ""
        Me.Label15.Text = "End switch vertical down"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.KL_BColision)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.KL_BVacSens4)
        Me.GroupBox2.Controls.Add(Me.KL_BOutputVac4)
        Me.GroupBox2.Controls.Add(Me.KL_BVacSens3)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.KL_BVacSens2)
        Me.GroupBox2.Controls.Add(Me.KL_BOutputVac5)
        Me.GroupBox2.Controls.Add(Me.KL_BVacSens1)
        Me.GroupBox2.Controls.Add(Me.KL_BOutputVac6)
        Me.GroupBox2.Controls.Add(Me.KL_BEsVerticalUp)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.KL_BEsHorizontalBack)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.KL_BEsHorizontalFront)
        Me.GroupBox2.Controls.Add(Me.KL_BOutputVac1)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.KL_BOutputVac2)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.KL_BOutputVac3)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.KL_BEsVerticalDown)
        Me.GroupBox2.Controls.Add(Me.KL_BVacSens5)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.KL_BVacSens6)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(267, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 429)
        Me.GroupBox2.TabIndex = 318
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gantry B"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(68, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 20)
        Me.Label4.TabIndex = 321
        Me.Label4.Tag = ""
        Me.Label4.Text = "Vacuum sensor 6"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(68, 212)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(181, 20)
        Me.Label11.TabIndex = 319
        Me.Label11.Tag = ""
        Me.Label11.Text = "Vacuum sensor 5"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_GAInputVac5
        '
        Me.KL_GAInputVac5.ColorOff = System.Drawing.Color.Red
        Me.KL_GAInputVac5.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_GAInputVac5.Data = False
        Me.KL_GAInputVac5.Line = True
        Me.KL_GAInputVac5.LineSize = 1
        Me.KL_GAInputVac5.Location = New System.Drawing.Point(10, 212)
        Me.KL_GAInputVac5.Name = "KL_GAInputVac5"
        Me.KL_GAInputVac5.Size = New System.Drawing.Size(20, 20)
        Me.KL_GAInputVac5.TabIndex = 318
        Me.KL_GAInputVac5.Text = "KremerLight12"
        Me.KL_GAInputVac5.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_GAInputVac6
        '
        Me.KL_GAInputVac6.ColorOff = System.Drawing.Color.Red
        Me.KL_GAInputVac6.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_GAInputVac6.Data = False
        Me.KL_GAInputVac6.Line = True
        Me.KL_GAInputVac6.LineSize = 1
        Me.KL_GAInputVac6.Location = New System.Drawing.Point(10, 233)
        Me.KL_GAInputVac6.Name = "KL_GAInputVac6"
        Me.KL_GAInputVac6.Size = New System.Drawing.Size(20, 20)
        Me.KL_GAInputVac6.TabIndex = 320
        Me.KL_GAInputVac6.Text = "KremerLight13"
        Me.KL_GAInputVac6.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 20)
        Me.Label2.TabIndex = 323
        Me.Label2.Tag = ""
        Me.Label2.Text = "Vacuum valve 1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(68, 297)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(181, 20)
        Me.Label6.TabIndex = 325
        Me.Label6.Tag = ""
        Me.Label6.Text = "Vacuum valve 2"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_GAOutputVac1
        '
        Me.KL_GAOutputVac1.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_GAOutputVac1.ColorOn = System.Drawing.Color.Lime
        Me.KL_GAOutputVac1.Data = False
        Me.KL_GAOutputVac1.Line = True
        Me.KL_GAOutputVac1.LineSize = 1
        Me.KL_GAOutputVac1.Location = New System.Drawing.Point(10, 276)
        Me.KL_GAOutputVac1.Name = "KL_GAOutputVac1"
        Me.KL_GAOutputVac1.Size = New System.Drawing.Size(20, 20)
        Me.KL_GAOutputVac1.TabIndex = 322
        Me.KL_GAOutputVac1.Text = "KremerLight3"
        Me.KL_GAOutputVac1.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(68, 318)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 20)
        Me.Label7.TabIndex = 327
        Me.Label7.Tag = ""
        Me.Label7.Text = "Vacuum valve 3"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_GAOutputVac2
        '
        Me.KL_GAOutputVac2.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_GAOutputVac2.ColorOn = System.Drawing.Color.Lime
        Me.KL_GAOutputVac2.Data = False
        Me.KL_GAOutputVac2.Line = True
        Me.KL_GAOutputVac2.LineSize = 1
        Me.KL_GAOutputVac2.Location = New System.Drawing.Point(10, 297)
        Me.KL_GAOutputVac2.Name = "KL_GAOutputVac2"
        Me.KL_GAOutputVac2.Size = New System.Drawing.Size(20, 20)
        Me.KL_GAOutputVac2.TabIndex = 324
        Me.KL_GAOutputVac2.Text = "KremerLight4"
        Me.KL_GAOutputVac2.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_GAOutputVac3
        '
        Me.KL_GAOutputVac3.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_GAOutputVac3.ColorOn = System.Drawing.Color.Lime
        Me.KL_GAOutputVac3.Data = False
        Me.KL_GAOutputVac3.Line = True
        Me.KL_GAOutputVac3.LineSize = 1
        Me.KL_GAOutputVac3.Location = New System.Drawing.Point(10, 318)
        Me.KL_GAOutputVac3.Name = "KL_GAOutputVac3"
        Me.KL_GAOutputVac3.Size = New System.Drawing.Size(20, 20)
        Me.KL_GAOutputVac3.TabIndex = 326
        Me.KL_GAOutputVac3.Text = "KremerLight5"
        Me.KL_GAOutputVac3.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(68, 338)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(181, 20)
        Me.Label9.TabIndex = 329
        Me.Label9.Tag = ""
        Me.Label9.Text = "Vacuum valve 4"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(68, 359)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(181, 20)
        Me.Label10.TabIndex = 331
        Me.Label10.Tag = ""
        Me.Label10.Text = "Vacuum valve 5"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_GAOutputVac4
        '
        Me.KL_GAOutputVac4.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_GAOutputVac4.ColorOn = System.Drawing.Color.Lime
        Me.KL_GAOutputVac4.Data = False
        Me.KL_GAOutputVac4.Line = True
        Me.KL_GAOutputVac4.LineSize = 1
        Me.KL_GAOutputVac4.Location = New System.Drawing.Point(10, 338)
        Me.KL_GAOutputVac4.Name = "KL_GAOutputVac4"
        Me.KL_GAOutputVac4.Size = New System.Drawing.Size(20, 20)
        Me.KL_GAOutputVac4.TabIndex = 328
        Me.KL_GAOutputVac4.Text = "KremerLight6"
        Me.KL_GAOutputVac4.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(68, 380)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(181, 20)
        Me.Label13.TabIndex = 333
        Me.Label13.Tag = ""
        Me.Label13.Text = "Vacuum valve 6"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_GAOutputVac5
        '
        Me.KL_GAOutputVac5.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_GAOutputVac5.ColorOn = System.Drawing.Color.Lime
        Me.KL_GAOutputVac5.Data = False
        Me.KL_GAOutputVac5.Line = True
        Me.KL_GAOutputVac5.LineSize = 1
        Me.KL_GAOutputVac5.Location = New System.Drawing.Point(10, 359)
        Me.KL_GAOutputVac5.Name = "KL_GAOutputVac5"
        Me.KL_GAOutputVac5.Size = New System.Drawing.Size(20, 20)
        Me.KL_GAOutputVac5.TabIndex = 330
        Me.KL_GAOutputVac5.Text = "KremerLight7"
        Me.KL_GAOutputVac5.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_GAOutputVac6
        '
        Me.KL_GAOutputVac6.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_GAOutputVac6.ColorOn = System.Drawing.Color.Lime
        Me.KL_GAOutputVac6.Data = False
        Me.KL_GAOutputVac6.Line = True
        Me.KL_GAOutputVac6.LineSize = 1
        Me.KL_GAOutputVac6.Location = New System.Drawing.Point(10, 380)
        Me.KL_GAOutputVac6.Name = "KL_GAOutputVac6"
        Me.KL_GAOutputVac6.Size = New System.Drawing.Size(20, 20)
        Me.KL_GAOutputVac6.TabIndex = 332
        Me.KL_GAOutputVac6.Text = "KremerLight8"
        Me.KL_GAOutputVac6.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'ACollisionSensor
        '
        Me.ACollisionSensor.BindControl = Me.KL_GACollision
        Me.ACollisionSensor.BindProperty = "Data"
        Me.ACollisionSensor.Data = Nothing
        Me.ACollisionSensor.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ACollisionSensor.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ACollisionSensor.VariableName = "MAIN.ProductHandling.GantryA.ixCollision"
        '
        'AEsHorizontalFront
        '
        Me.AEsHorizontalFront.BindControl = Me.KL_GAEsHorizontalFront
        Me.AEsHorizontalFront.BindProperty = "Data"
        Me.AEsHorizontalFront.Data = Nothing
        Me.AEsHorizontalFront.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.AEsHorizontalFront.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AEsHorizontalFront.VariableName = "MAIN.ProductHandling.GantryA.ixEndLimitHorFront"
        '
        'AEsHorizontalBack
        '
        Me.AEsHorizontalBack.BindControl = Me.KL_GAEsHorizontalback
        Me.AEsHorizontalBack.BindProperty = "Data"
        Me.AEsHorizontalBack.Data = Nothing
        Me.AEsHorizontalBack.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.AEsHorizontalBack.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AEsHorizontalBack.VariableName = "MAIN.ProductHandling.GantryA.ixEndLimitHorBack"
        '
        'AEsVerticalUp
        '
        Me.AEsVerticalUp.BindControl = Me.KL_GAEsverticalUp
        Me.AEsVerticalUp.BindProperty = "Data"
        Me.AEsVerticalUp.Data = Nothing
        Me.AEsVerticalUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.AEsVerticalUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AEsVerticalUp.VariableName = "MAIN.ProductHandling.GantryA.ixEndLimitVertUp"
        '
        'AEsVerticalDown
        '
        Me.AEsVerticalDown.BindControl = Me.KL_EsVerticalDown
        Me.AEsVerticalDown.BindProperty = "Data"
        Me.AEsVerticalDown.Data = Nothing
        Me.AEsVerticalDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.AEsVerticalDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AEsVerticalDown.VariableName = "MAIN.ProductHandling.GantryA.ixEndLimitVertDown"
        '
        'AVacSensor1
        '
        Me.AVacSensor1.BindControl = Me.KL_GAInputVac1
        Me.AVacSensor1.BindProperty = "Data"
        Me.AVacSensor1.Data = Nothing
        Me.AVacSensor1.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.AVacSensor1.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AVacSensor1.VariableName = "MAIN.ProductHandling.GantryA.ixVacuumSensor[1]"
        '
        'AVacSensor2
        '
        Me.AVacSensor2.BindControl = Me.KL_GAInputVac2
        Me.AVacSensor2.BindProperty = "Data"
        Me.AVacSensor2.Data = Nothing
        Me.AVacSensor2.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.AVacSensor2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AVacSensor2.VariableName = "MAIN.ProductHandling.GantryA.ixVacuumSensor[2]"
        '
        'AVacSensor3
        '
        Me.AVacSensor3.BindControl = Me.KL_GAInputVac3
        Me.AVacSensor3.BindProperty = "Data"
        Me.AVacSensor3.Data = Nothing
        Me.AVacSensor3.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.AVacSensor3.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AVacSensor3.VariableName = "MAIN.ProductHandling.GantryA.ixVacuumSensor[3]"
        '
        'AVacSensor4
        '
        Me.AVacSensor4.BindControl = Me.KL_GAInputVac4
        Me.AVacSensor4.BindProperty = "Data"
        Me.AVacSensor4.Data = Nothing
        Me.AVacSensor4.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.AVacSensor4.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AVacSensor4.VariableName = "MAIN.ProductHandling.GantryA.ixVacuumSensor[4]"
        '
        'AVacSensor5
        '
        Me.AVacSensor5.BindControl = Me.KL_GAInputVac5
        Me.AVacSensor5.BindProperty = "Data"
        Me.AVacSensor5.Data = Nothing
        Me.AVacSensor5.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.AVacSensor5.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AVacSensor5.VariableName = "MAIN.ProductHandling.GantryA.ixVacuumSensor[5]"
        '
        'AVacSensor6
        '
        Me.AVacSensor6.BindControl = Me.KL_GAInputVac6
        Me.AVacSensor6.BindProperty = "Data"
        Me.AVacSensor6.Data = Nothing
        Me.AVacSensor6.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.AVacSensor6.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AVacSensor6.VariableName = "MAIN.ProductHandling.GantryA.ixVacuumSensor[6]"
        '
        'AVacOutp1
        '
        Me.AVacOutp1.BindControl = Me.KL_GAOutputVac1
        Me.AVacOutp1.BindProperty = "Data"
        Me.AVacOutp1.Data = Nothing
        Me.AVacOutp1.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.AVacOutp1.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AVacOutp1.VariableName = "MAIN.ProductHandling.GantryA.VacuumValve[1].Q"
        '
        'AVacOutp2
        '
        Me.AVacOutp2.BindControl = Me.KL_GAOutputVac2
        Me.AVacOutp2.BindProperty = "Data"
        Me.AVacOutp2.Data = Nothing
        Me.AVacOutp2.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.AVacOutp2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AVacOutp2.VariableName = "MAIN.ProductHandling.GantryA.VacuumValve[2].Q"
        '
        'AVacOutp3
        '
        Me.AVacOutp3.BindControl = Me.KL_GAOutputVac3
        Me.AVacOutp3.BindProperty = "Data"
        Me.AVacOutp3.Data = Nothing
        Me.AVacOutp3.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.AVacOutp3.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AVacOutp3.VariableName = "MAIN.ProductHandling.GantryA.VacuumValve[3].Q"
        '
        'AVacOutp4
        '
        Me.AVacOutp4.BindControl = Me.KL_GAOutputVac4
        Me.AVacOutp4.BindProperty = "Data"
        Me.AVacOutp4.Data = Nothing
        Me.AVacOutp4.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.AVacOutp4.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AVacOutp4.VariableName = "MAIN.ProductHandling.GantryA.VacuumValve[4].Q"
        '
        'AVacOutp5
        '
        Me.AVacOutp5.BindControl = Me.KL_GAOutputVac5
        Me.AVacOutp5.BindProperty = "Data"
        Me.AVacOutp5.Data = Nothing
        Me.AVacOutp5.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.AVacOutp5.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AVacOutp5.VariableName = "MAIN.ProductHandling.GantryA.VacuumValve[5].Q"
        '
        'AVacOutp6
        '
        Me.AVacOutp6.BindControl = Me.KL_GAOutputVac6
        Me.AVacOutp6.BindProperty = "Data"
        Me.AVacOutp6.Data = Nothing
        Me.AVacOutp6.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.AVacOutp6.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.AVacOutp6.VariableName = "MAIN.ProductHandling.GantryA.VacuumValve[6].Q"
        '
        'BcolisionSensor
        '
        Me.BcolisionSensor.BindControl = Me.KL_BColision
        Me.BcolisionSensor.BindProperty = "Data"
        Me.BcolisionSensor.Data = Nothing
        Me.BcolisionSensor.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BcolisionSensor.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BcolisionSensor.VariableName = "MAIN.ProductHandling.GantryB.ixCollision"
        '
        'BEsHorizontalFront
        '
        Me.BEsHorizontalFront.BindControl = Me.KL_BEsHorizontalFront
        Me.BEsHorizontalFront.BindProperty = "Data"
        Me.BEsHorizontalFront.Data = Nothing
        Me.BEsHorizontalFront.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BEsHorizontalFront.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BEsHorizontalFront.VariableName = "MAIN.ProductHandling.GantryB.ixEndLimitHorFront"
        '
        'BEsHorizontalBack
        '
        Me.BEsHorizontalBack.BindControl = Me.KL_BEsHorizontalBack
        Me.BEsHorizontalBack.BindProperty = "Data"
        Me.BEsHorizontalBack.Data = Nothing
        Me.BEsHorizontalBack.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BEsHorizontalBack.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BEsHorizontalBack.VariableName = "MAIN.ProductHandling.GantryB.ixEndLimitHorBack"
        '
        'BEsVerticalUp
        '
        Me.BEsVerticalUp.BindControl = Me.KL_BEsVerticalUp
        Me.BEsVerticalUp.BindProperty = "Data"
        Me.BEsVerticalUp.Data = Nothing
        Me.BEsVerticalUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BEsVerticalUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BEsVerticalUp.VariableName = "MAIN.ProductHandling.GantryB.ixEndLimitVertUp"
        '
        'BEsVerticalDown
        '
        Me.BEsVerticalDown.BindControl = Me.KL_BEsVerticalDown
        Me.BEsVerticalDown.BindProperty = "Data"
        Me.BEsVerticalDown.Data = Nothing
        Me.BEsVerticalDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BEsVerticalDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BEsVerticalDown.VariableName = "MAIN.ProductHandling.GantryB.ixEndLimitVertDown"
        '
        'BVacSensor1
        '
        Me.BVacSensor1.BindControl = Me.KL_BVacSens1
        Me.BVacSensor1.BindProperty = "Data"
        Me.BVacSensor1.Data = Nothing
        Me.BVacSensor1.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BVacSensor1.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BVacSensor1.VariableName = "MAIN.ProductHandling.GantryB.ixVacuumSensor[1]"
        '
        'BVacSensor2
        '
        Me.BVacSensor2.BindControl = Me.KL_BVacSens2
        Me.BVacSensor2.BindProperty = "Data"
        Me.BVacSensor2.Data = Nothing
        Me.BVacSensor2.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BVacSensor2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BVacSensor2.VariableName = "MAIN.ProductHandling.GantryB.ixVacuumSensor[2]"
        '
        'BVacSensor3
        '
        Me.BVacSensor3.BindControl = Me.KL_BVacSens3
        Me.BVacSensor3.BindProperty = "Data"
        Me.BVacSensor3.Data = Nothing
        Me.BVacSensor3.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BVacSensor3.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BVacSensor3.VariableName = "MAIN.ProductHandling.GantryB.ixVacuumSensor[3]"
        '
        'BVacSensor4
        '
        Me.BVacSensor4.BindControl = Me.KL_BVacSens4
        Me.BVacSensor4.BindProperty = "Data"
        Me.BVacSensor4.Data = Nothing
        Me.BVacSensor4.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BVacSensor4.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BVacSensor4.VariableName = "MAIN.ProductHandling.GantryB.ixVacuumSensor[4]"
        '
        'BVacSensor5
        '
        Me.BVacSensor5.BindControl = Me.KL_BVacSens5
        Me.BVacSensor5.BindProperty = "Data"
        Me.BVacSensor5.Data = Nothing
        Me.BVacSensor5.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BVacSensor5.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BVacSensor5.VariableName = "MAIN.ProductHandling.GantryB.ixVacuumSensor[5]"
        '
        'BVacSensor6
        '
        Me.BVacSensor6.BindControl = Me.KL_BVacSens6
        Me.BVacSensor6.BindProperty = "Data"
        Me.BVacSensor6.Data = Nothing
        Me.BVacSensor6.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BVacSensor6.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BVacSensor6.VariableName = "MAIN.ProductHandling.GantryB.ixVacuumSensor[6]"
        '
        'BVacOutp1
        '
        Me.BVacOutp1.BindControl = Me.KL_BOutputVac1
        Me.BVacOutp1.BindProperty = "Data"
        Me.BVacOutp1.Data = Nothing
        Me.BVacOutp1.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BVacOutp1.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BVacOutp1.VariableName = "MAIN.ProductHandling.GantryB.VacuumValve[1].Q"
        '
        'BVacOutp2
        '
        Me.BVacOutp2.BindControl = Me.KL_BOutputVac2
        Me.BVacOutp2.BindProperty = "Data"
        Me.BVacOutp2.Data = Nothing
        Me.BVacOutp2.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BVacOutp2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BVacOutp2.VariableName = "MAIN.ProductHandling.GantryB.VacuumValve[2].Q"
        '
        'BVacOutp3
        '
        Me.BVacOutp3.BindControl = Me.KL_BOutputVac3
        Me.BVacOutp3.BindProperty = "Data"
        Me.BVacOutp3.Data = Nothing
        Me.BVacOutp3.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BVacOutp3.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BVacOutp3.VariableName = "MAIN.ProductHandling.GantryB.VacuumValve[3].Q"
        '
        'BVacOutp4
        '
        Me.BVacOutp4.BindControl = Me.KL_BOutputVac4
        Me.BVacOutp4.BindProperty = "Data"
        Me.BVacOutp4.Data = Nothing
        Me.BVacOutp4.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BVacOutp4.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BVacOutp4.VariableName = "MAIN.ProductHandling.GantryB.VacuumValve[4].Q"
        '
        'BVacOutp5
        '
        Me.BVacOutp5.BindControl = Me.KL_BOutputVac5
        Me.BVacOutp5.BindProperty = "Data"
        Me.BVacOutp5.Data = Nothing
        Me.BVacOutp5.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BVacOutp5.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BVacOutp5.VariableName = "MAIN.ProductHandling.GantryB.VacuumValve[5].Q"
        '
        'BVacOutp6
        '
        Me.BVacOutp6.BindControl = Me.KL_BOutputVac6
        Me.BVacOutp6.BindProperty = "Data"
        Me.BVacOutp6.Data = Nothing
        Me.BVacOutp6.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.BVacOutp6.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.BVacOutp6.VariableName = "MAIN.ProductHandling.GantryB.VacuumValve[6].Q"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(64, 338)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(181, 20)
        Me.Label14.TabIndex = 364
        Me.Label14.Tag = ""
        Me.Label14.Text = "Vacuum valve 4"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(64, 359)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(181, 20)
        Me.Label20.TabIndex = 366
        Me.Label20.Tag = ""
        Me.Label20.Text = "Vacuum valve 5"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_BOutputVac4
        '
        Me.KL_BOutputVac4.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BOutputVac4.ColorOn = System.Drawing.Color.Lime
        Me.KL_BOutputVac4.Data = False
        Me.KL_BOutputVac4.Line = True
        Me.KL_BOutputVac4.LineSize = 1
        Me.KL_BOutputVac4.Location = New System.Drawing.Point(6, 338)
        Me.KL_BOutputVac4.Name = "KL_BOutputVac4"
        Me.KL_BOutputVac4.Size = New System.Drawing.Size(20, 20)
        Me.KL_BOutputVac4.TabIndex = 363
        Me.KL_BOutputVac4.Text = "KremerLight6"
        Me.KL_BOutputVac4.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(64, 380)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(181, 20)
        Me.Label21.TabIndex = 368
        Me.Label21.Tag = ""
        Me.Label21.Text = "Vacuum valve 6"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_BOutputVac5
        '
        Me.KL_BOutputVac5.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BOutputVac5.ColorOn = System.Drawing.Color.Lime
        Me.KL_BOutputVac5.Data = False
        Me.KL_BOutputVac5.Line = True
        Me.KL_BOutputVac5.LineSize = 1
        Me.KL_BOutputVac5.Location = New System.Drawing.Point(6, 359)
        Me.KL_BOutputVac5.Name = "KL_BOutputVac5"
        Me.KL_BOutputVac5.Size = New System.Drawing.Size(20, 20)
        Me.KL_BOutputVac5.TabIndex = 365
        Me.KL_BOutputVac5.Text = "KremerLight7"
        Me.KL_BOutputVac5.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_BOutputVac6
        '
        Me.KL_BOutputVac6.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BOutputVac6.ColorOn = System.Drawing.Color.Lime
        Me.KL_BOutputVac6.Data = False
        Me.KL_BOutputVac6.Line = True
        Me.KL_BOutputVac6.LineSize = 1
        Me.KL_BOutputVac6.Location = New System.Drawing.Point(6, 380)
        Me.KL_BOutputVac6.Name = "KL_BOutputVac6"
        Me.KL_BOutputVac6.Size = New System.Drawing.Size(20, 20)
        Me.KL_BOutputVac6.TabIndex = 367
        Me.KL_BOutputVac6.Text = "KremerLight8"
        Me.KL_BOutputVac6.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(64, 276)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(181, 20)
        Me.Label22.TabIndex = 358
        Me.Label22.Tag = ""
        Me.Label22.Text = "Vacuum valve 1"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(64, 297)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(181, 20)
        Me.Label23.TabIndex = 360
        Me.Label23.Tag = ""
        Me.Label23.Text = "Vacuum valve 2"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_BOutputVac1
        '
        Me.KL_BOutputVac1.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BOutputVac1.ColorOn = System.Drawing.Color.Lime
        Me.KL_BOutputVac1.Data = False
        Me.KL_BOutputVac1.Line = True
        Me.KL_BOutputVac1.LineSize = 1
        Me.KL_BOutputVac1.Location = New System.Drawing.Point(6, 276)
        Me.KL_BOutputVac1.Name = "KL_BOutputVac1"
        Me.KL_BOutputVac1.Size = New System.Drawing.Size(20, 20)
        Me.KL_BOutputVac1.TabIndex = 357
        Me.KL_BOutputVac1.Text = "KremerLight3"
        Me.KL_BOutputVac1.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(64, 318)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(181, 20)
        Me.Label24.TabIndex = 362
        Me.Label24.Tag = ""
        Me.Label24.Text = "Vacuum valve 3"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_BOutputVac2
        '
        Me.KL_BOutputVac2.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BOutputVac2.ColorOn = System.Drawing.Color.Lime
        Me.KL_BOutputVac2.Data = False
        Me.KL_BOutputVac2.Line = True
        Me.KL_BOutputVac2.LineSize = 1
        Me.KL_BOutputVac2.Location = New System.Drawing.Point(6, 297)
        Me.KL_BOutputVac2.Name = "KL_BOutputVac2"
        Me.KL_BOutputVac2.Size = New System.Drawing.Size(20, 20)
        Me.KL_BOutputVac2.TabIndex = 359
        Me.KL_BOutputVac2.Text = "KremerLight4"
        Me.KL_BOutputVac2.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_BOutputVac3
        '
        Me.KL_BOutputVac3.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BOutputVac3.ColorOn = System.Drawing.Color.Lime
        Me.KL_BOutputVac3.Data = False
        Me.KL_BOutputVac3.Line = True
        Me.KL_BOutputVac3.LineSize = 1
        Me.KL_BOutputVac3.Location = New System.Drawing.Point(6, 318)
        Me.KL_BOutputVac3.Name = "KL_BOutputVac3"
        Me.KL_BOutputVac3.Size = New System.Drawing.Size(20, 20)
        Me.KL_BOutputVac3.TabIndex = 361
        Me.KL_BOutputVac3.Text = "KremerLight5"
        Me.KL_BOutputVac3.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(64, 233)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(181, 20)
        Me.Label25.TabIndex = 356
        Me.Label25.Tag = ""
        Me.Label25.Text = "Vacuum sensor 6"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(64, 212)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(181, 20)
        Me.Label26.TabIndex = 354
        Me.Label26.Tag = ""
        Me.Label26.Text = "Vacuum sensor 5"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_BVacSens5
        '
        Me.KL_BVacSens5.ColorOff = System.Drawing.Color.Red
        Me.KL_BVacSens5.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BVacSens5.Data = False
        Me.KL_BVacSens5.Line = True
        Me.KL_BVacSens5.LineSize = 1
        Me.KL_BVacSens5.Location = New System.Drawing.Point(6, 212)
        Me.KL_BVacSens5.Name = "KL_BVacSens5"
        Me.KL_BVacSens5.Size = New System.Drawing.Size(20, 20)
        Me.KL_BVacSens5.TabIndex = 353
        Me.KL_BVacSens5.Text = "KremerLight12"
        Me.KL_BVacSens5.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_BVacSens6
        '
        Me.KL_BVacSens6.ColorOff = System.Drawing.Color.Red
        Me.KL_BVacSens6.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BVacSens6.Data = False
        Me.KL_BVacSens6.Line = True
        Me.KL_BVacSens6.LineSize = 1
        Me.KL_BVacSens6.Location = New System.Drawing.Point(6, 233)
        Me.KL_BVacSens6.Name = "KL_BVacSens6"
        Me.KL_BVacSens6.Size = New System.Drawing.Size(20, 20)
        Me.KL_BVacSens6.TabIndex = 355
        Me.KL_BVacSens6.Text = "KremerLight13"
        Me.KL_BVacSens6.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(2, 256)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(242, 20)
        Me.Label27.TabIndex = 352
        Me.Label27.Tag = ""
        Me.Label27.Text = "Outputs"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(64, 25)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(181, 20)
        Me.Label28.TabIndex = 335
        Me.Label28.Tag = ""
        Me.Label28.Text = "Collision sensor active"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(64, 46)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(181, 20)
        Me.Label29.TabIndex = 337
        Me.Label29.Tag = ""
        Me.Label29.Text = "End switch horizontal front"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(64, 87)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(181, 20)
        Me.Label30.TabIndex = 341
        Me.Label30.Tag = ""
        Me.Label30.Text = "End switch vertical up"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(64, 192)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(181, 20)
        Me.Label31.TabIndex = 351
        Me.Label31.Tag = ""
        Me.Label31.Text = "Vacuum sensor 4"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_BEsVerticalDown
        '
        Me.KL_BEsVerticalDown.ColorOff = System.Drawing.Color.Red
        Me.KL_BEsVerticalDown.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BEsVerticalDown.Data = False
        Me.KL_BEsVerticalDown.Line = True
        Me.KL_BEsVerticalDown.LineSize = 1
        Me.KL_BEsVerticalDown.Location = New System.Drawing.Point(6, 108)
        Me.KL_BEsVerticalDown.Name = "KL_BEsVerticalDown"
        Me.KL_BEsVerticalDown.Size = New System.Drawing.Size(20, 20)
        Me.KL_BEsVerticalDown.TabIndex = 342
        Me.KL_BEsVerticalDown.Text = "KremerLight9"
        Me.KL_BEsVerticalDown.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(64, 171)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(181, 20)
        Me.Label32.TabIndex = 349
        Me.Label32.Tag = ""
        Me.Label32.Text = "Vacuum sensor 3"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(64, 150)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(181, 20)
        Me.Label33.TabIndex = 347
        Me.Label33.Tag = ""
        Me.Label33.Text = "Vacuum sensor 2"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_BColision
        '
        Me.KL_BColision.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BColision.ColorOn = System.Drawing.Color.Lime
        Me.KL_BColision.Data = False
        Me.KL_BColision.Line = True
        Me.KL_BColision.LineSize = 1
        Me.KL_BColision.Location = New System.Drawing.Point(6, 25)
        Me.KL_BColision.Name = "KL_BColision"
        Me.KL_BColision.Size = New System.Drawing.Size(20, 20)
        Me.KL_BColision.TabIndex = 334
        Me.KL_BColision.Text = "KremerLight10"
        Me.KL_BColision.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(64, 67)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(181, 20)
        Me.Label34.TabIndex = 339
        Me.Label34.Tag = ""
        Me.Label34.Text = "End switch horizontal back"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(64, 129)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(181, 20)
        Me.Label35.TabIndex = 345
        Me.Label35.Tag = ""
        Me.Label35.Text = "Vacuum sensor 1"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(64, 108)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(181, 20)
        Me.Label36.TabIndex = 343
        Me.Label36.Tag = ""
        Me.Label36.Text = "End switch vertical down"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KL_BEsHorizontalFront
        '
        Me.KL_BEsHorizontalFront.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BEsHorizontalFront.ColorOn = System.Drawing.Color.Lime
        Me.KL_BEsHorizontalFront.Data = False
        Me.KL_BEsHorizontalFront.Line = True
        Me.KL_BEsHorizontalFront.LineSize = 1
        Me.KL_BEsHorizontalFront.Location = New System.Drawing.Point(6, 46)
        Me.KL_BEsHorizontalFront.Name = "KL_BEsHorizontalFront"
        Me.KL_BEsHorizontalFront.Size = New System.Drawing.Size(20, 20)
        Me.KL_BEsHorizontalFront.TabIndex = 336
        Me.KL_BEsHorizontalFront.Text = "KremerLight11"
        Me.KL_BEsHorizontalFront.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_BEsHorizontalBack
        '
        Me.KL_BEsHorizontalBack.ColorOff = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BEsHorizontalBack.ColorOn = System.Drawing.Color.Lime
        Me.KL_BEsHorizontalBack.Data = False
        Me.KL_BEsHorizontalBack.Line = True
        Me.KL_BEsHorizontalBack.LineSize = 1
        Me.KL_BEsHorizontalBack.Location = New System.Drawing.Point(6, 67)
        Me.KL_BEsHorizontalBack.Name = "KL_BEsHorizontalBack"
        Me.KL_BEsHorizontalBack.Size = New System.Drawing.Size(20, 20)
        Me.KL_BEsHorizontalBack.TabIndex = 338
        Me.KL_BEsHorizontalBack.Text = "KremerLight12"
        Me.KL_BEsHorizontalBack.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_BEsVerticalUp
        '
        Me.KL_BEsVerticalUp.ColorOff = System.Drawing.Color.Red
        Me.KL_BEsVerticalUp.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BEsVerticalUp.Data = False
        Me.KL_BEsVerticalUp.Line = True
        Me.KL_BEsVerticalUp.LineSize = 1
        Me.KL_BEsVerticalUp.Location = New System.Drawing.Point(6, 87)
        Me.KL_BEsVerticalUp.Name = "KL_BEsVerticalUp"
        Me.KL_BEsVerticalUp.Size = New System.Drawing.Size(20, 20)
        Me.KL_BEsVerticalUp.TabIndex = 340
        Me.KL_BEsVerticalUp.Text = "KremerLight2"
        Me.KL_BEsVerticalUp.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_BVacSens1
        '
        Me.KL_BVacSens1.ColorOff = System.Drawing.Color.Red
        Me.KL_BVacSens1.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BVacSens1.Data = False
        Me.KL_BVacSens1.Line = True
        Me.KL_BVacSens1.LineSize = 1
        Me.KL_BVacSens1.Location = New System.Drawing.Point(6, 129)
        Me.KL_BVacSens1.Name = "KL_BVacSens1"
        Me.KL_BVacSens1.Size = New System.Drawing.Size(20, 20)
        Me.KL_BVacSens1.TabIndex = 344
        Me.KL_BVacSens1.Text = "KremerLight10"
        Me.KL_BVacSens1.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_BVacSens2
        '
        Me.KL_BVacSens2.ColorOff = System.Drawing.Color.Red
        Me.KL_BVacSens2.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BVacSens2.Data = False
        Me.KL_BVacSens2.Line = True
        Me.KL_BVacSens2.LineSize = 1
        Me.KL_BVacSens2.Location = New System.Drawing.Point(6, 150)
        Me.KL_BVacSens2.Name = "KL_BVacSens2"
        Me.KL_BVacSens2.Size = New System.Drawing.Size(20, 20)
        Me.KL_BVacSens2.TabIndex = 346
        Me.KL_BVacSens2.Text = "KremerLight11"
        Me.KL_BVacSens2.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_BVacSens3
        '
        Me.KL_BVacSens3.ColorOff = System.Drawing.Color.Red
        Me.KL_BVacSens3.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BVacSens3.Data = False
        Me.KL_BVacSens3.Line = True
        Me.KL_BVacSens3.LineSize = 1
        Me.KL_BVacSens3.Location = New System.Drawing.Point(6, 171)
        Me.KL_BVacSens3.Name = "KL_BVacSens3"
        Me.KL_BVacSens3.Size = New System.Drawing.Size(20, 20)
        Me.KL_BVacSens3.TabIndex = 348
        Me.KL_BVacSens3.Text = "KremerLight12"
        Me.KL_BVacSens3.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'KL_BVacSens4
        '
        Me.KL_BVacSens4.ColorOff = System.Drawing.Color.Red
        Me.KL_BVacSens4.ColorOn = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KL_BVacSens4.Data = False
        Me.KL_BVacSens4.Line = True
        Me.KL_BVacSens4.LineSize = 1
        Me.KL_BVacSens4.Location = New System.Drawing.Point(6, 192)
        Me.KL_BVacSens4.Name = "KL_BVacSens4"
        Me.KL_BVacSens4.Size = New System.Drawing.Size(20, 20)
        Me.KL_BVacSens4.TabIndex = 350
        Me.KL_BVacSens4.Text = "KremerLight13"
        Me.KL_BVacSens4.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'IO_ProductHandling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "IO_ProductHandling"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "540"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents KL_GAEsHorizontalFront As KremerControlsWin32.KremerLight
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents KL_GACollision As KremerControlsWin32.KremerLight
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents KL_GAEsHorizontalback As KremerControlsWin32.KremerLight
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents KL_GAInputVac2 As KremerControlsWin32.KremerLight
    Friend WithEvents KL_GAInputVac3 As KremerControlsWin32.KremerLight
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents KL_GAInputVac4 As KremerControlsWin32.KremerLight
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents KL_GAEsverticalUp As KremerControlsWin32.KremerLight
    Friend WithEvents KL_EsVerticalDown As KremerControlsWin32.KremerLight
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents KL_GAInputVac1 As KremerControlsWin32.KremerLight
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents KL_GAOutputVac4 As KremerControlsWin32.KremerLight
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents KL_GAOutputVac5 As KremerControlsWin32.KremerLight
    Friend WithEvents KL_GAOutputVac6 As KremerControlsWin32.KremerLight
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents KL_GAOutputVac1 As KremerControlsWin32.KremerLight
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents KL_GAOutputVac2 As KremerControlsWin32.KremerLight
    Friend WithEvents KL_GAOutputVac3 As KremerControlsWin32.KremerLight
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents KL_GAInputVac5 As KremerControlsWin32.KremerLight
    Friend WithEvents KL_GAInputVac6 As KremerControlsWin32.KremerLight
    Friend WithEvents ACollisionSensor As KremerControlsWin32.KremerVariable
    Friend WithEvents AEsHorizontalFront As KremerControlsWin32.KremerVariable
    Friend WithEvents AEsHorizontalBack As KremerControlsWin32.KremerVariable
    Friend WithEvents AEsVerticalUp As KremerControlsWin32.KremerVariable
    Friend WithEvents AEsVerticalDown As KremerControlsWin32.KremerVariable
    Friend WithEvents AVacSensor1 As KremerControlsWin32.KremerVariable
    Friend WithEvents AVacSensor2 As KremerControlsWin32.KremerVariable
    Friend WithEvents AVacSensor3 As KremerControlsWin32.KremerVariable
    Friend WithEvents AVacSensor4 As KremerControlsWin32.KremerVariable
    Friend WithEvents AVacSensor5 As KremerControlsWin32.KremerVariable
    Friend WithEvents AVacSensor6 As KremerControlsWin32.KremerVariable
    Friend WithEvents AVacOutp1 As KremerControlsWin32.KremerVariable
    Friend WithEvents AVacOutp2 As KremerControlsWin32.KremerVariable
    Friend WithEvents AVacOutp3 As KremerControlsWin32.KremerVariable
    Friend WithEvents AVacOutp4 As KremerControlsWin32.KremerVariable
    Friend WithEvents AVacOutp5 As KremerControlsWin32.KremerVariable
    Friend WithEvents AVacOutp6 As KremerControlsWin32.KremerVariable
    Friend WithEvents BcolisionSensor As KremerControlsWin32.KremerVariable
    Friend WithEvents BEsHorizontalFront As KremerControlsWin32.KremerVariable
    Friend WithEvents BEsHorizontalBack As KremerControlsWin32.KremerVariable
    Friend WithEvents BEsVerticalUp As KremerControlsWin32.KremerVariable
    Friend WithEvents BEsVerticalDown As KremerControlsWin32.KremerVariable
    Friend WithEvents BVacSensor1 As KremerControlsWin32.KremerVariable
    Friend WithEvents BVacSensor2 As KremerControlsWin32.KremerVariable
    Friend WithEvents BVacSensor3 As KremerControlsWin32.KremerVariable
    Friend WithEvents BVacSensor4 As KremerControlsWin32.KremerVariable
    Friend WithEvents BVacSensor5 As KremerControlsWin32.KremerVariable
    Friend WithEvents BVacSensor6 As KremerControlsWin32.KremerVariable
    Friend WithEvents BVacOutp1 As KremerControlsWin32.KremerVariable
    Friend WithEvents BVacOutp2 As KremerControlsWin32.KremerVariable
    Friend WithEvents BVacOutp3 As KremerControlsWin32.KremerVariable
    Friend WithEvents BVacOutp4 As KremerControlsWin32.KremerVariable
    Friend WithEvents BVacOutp5 As KremerControlsWin32.KremerVariable
    Friend WithEvents BVacOutp6 As KremerControlsWin32.KremerVariable
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents KL_BColision As KremerControlsWin32.KremerLight
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents KL_BVacSens4 As KremerControlsWin32.KremerLight
    Friend WithEvents KL_BOutputVac4 As KremerControlsWin32.KremerLight
    Friend WithEvents KL_BVacSens3 As KremerControlsWin32.KremerLight
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents KL_BVacSens2 As KremerControlsWin32.KremerLight
    Friend WithEvents KL_BOutputVac5 As KremerControlsWin32.KremerLight
    Friend WithEvents KL_BVacSens1 As KremerControlsWin32.KremerLight
    Friend WithEvents KL_BOutputVac6 As KremerControlsWin32.KremerLight
    Friend WithEvents KL_BEsVerticalUp As KremerControlsWin32.KremerLight
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents KL_BEsHorizontalBack As KremerControlsWin32.KremerLight
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents KL_BEsHorizontalFront As KremerControlsWin32.KremerLight
    Friend WithEvents KL_BOutputVac1 As KremerControlsWin32.KremerLight
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents KL_BOutputVac2 As KremerControlsWin32.KremerLight
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents KL_BOutputVac3 As KremerControlsWin32.KremerLight
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents KL_BEsVerticalDown As KremerControlsWin32.KremerLight
    Friend WithEvents KL_BVacSens5 As KremerControlsWin32.KremerLight
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents KL_BVacSens6 As KremerControlsWin32.KremerLight
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label

End Class
