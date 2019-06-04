<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IO_Zipper
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
        Me.ZipperHome = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plZipper_Home = New KremerControlsWin32.KremerLight
        Me.ZipperHigh = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plZipperHighProduct = New KremerControlsWin32.KremerLight
        Me.UpperHomeA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plUppInfHoming_A = New KremerControlsWin32.KremerLight
        Me.UpperHomeB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plUppInfHoming_B = New KremerControlsWin32.KremerLight
        Me.CartonsAtStopper1 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plCartonAtStopper1 = New KremerControlsWin32.KremerLight
        Me.CartonAtStopper2A = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plCartonAtStopper2_A = New KremerControlsWin32.KremerLight
        Me.CartonAtStopper2B = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plCartonAtStopper2_B = New KremerControlsWin32.KremerLight
        Me.Stopper1UpA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plStopper1Up_A = New KremerControlsWin32.KremerLight
        Me.Stopper1UpB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plStopper1Up_B = New KremerControlsWin32.KremerLight
        Me.Stopper1DownA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plStopper1Down_A = New KremerControlsWin32.KremerLight
        Me.Stopper1DownB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plStopper1Down_B = New KremerControlsWin32.KremerLight
        Me.Stopper2UpA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plStopper2Up_A = New KremerControlsWin32.KremerLight
        Me.Stopper2UpB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plStopper2Up_B = New KremerControlsWin32.KremerLight
        Me.Stopper2DownA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plStopper2Down_A = New KremerControlsWin32.KremerLight
        Me.Stopper2DownB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plStopper2Down_B = New KremerControlsWin32.KremerLight
        Me.TIBProductFree = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plTIBProdFree = New KremerControlsWin32.KremerLight
        Me.TIBProd1 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plTIBProd1 = New KremerControlsWin32.KremerLight
        Me.TIBProd2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plTIBProd2 = New KremerControlsWin32.KremerLight
        Me.TIBProd3 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plTIBProd3 = New KremerControlsWin32.KremerLight
        Me.TIBProd4 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plTIBProd4 = New KremerControlsWin32.KremerLight
        Me.TIBProd5 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plTIBProd5 = New KremerControlsWin32.KremerLight
        Me.TIBProd6 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plTIBProd6 = New KremerControlsWin32.KremerLight
        Me.TIBStopperUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plTIBStopperUp = New KremerControlsWin32.KremerLight
        Me.TIBStopperDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plTIBStopperDown = New KremerControlsWin32.KremerLight
        Me.TelixHome = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plTelHome = New KremerControlsWin32.KremerLight
        Me.TelixLimit = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plTelLimit = New KremerControlsWin32.KremerLight
        Me.TelixBeltIsIn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plTelBeltIsIn = New KremerControlsWin32.KremerLight
        Me.CartonInPocketA = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plCartonInPocketA = New KremerControlsWin32.KremerLight
        Me.CartonInPocketB = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plCartonInPocketB = New KremerControlsWin32.KremerLight
        Me.UpperInfeedIsUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plUpperInfeedIsUp = New KremerControlsWin32.KremerLight
        Me.UpperInfeedIsDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.plUpperInfeedIsDown = New KremerControlsWin32.KremerLight
        Me.Btn_Overview = New KremerControlsWin32.KremerButton
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.ZipperHomingSensor = New KremerControlsWin32.KremerStatusBox
        Me.ZipperHighProduct = New KremerControlsWin32.KremerStatusBox
        Me.btnToggleText = New KremerControlsWin32.KremerButton
        Me.UpperInfHomSensA = New KremerControlsWin32.KremerStatusBox
        Me.UpperInfHomSensB = New KremerControlsWin32.KremerStatusBox
        Me.UpperInfIsUp = New KremerControlsWin32.KremerStatusBox
        Me.UpperInfIsDown = New KremerControlsWin32.KremerStatusBox
        Me.TelHomingSensor = New KremerControlsWin32.KremerStatusBox
        Me.TelLimitSwitch = New KremerControlsWin32.KremerStatusBox
        Me.TelBeltIn = New KremerControlsWin32.KremerStatusBox
        Me.CartonAtStop1 = New KremerControlsWin32.KremerStatusBox
        Me.CartonAtStop2A = New KremerControlsWin32.KremerStatusBox
        Me.CartonAtStop2B = New KremerControlsWin32.KremerStatusBox
        Me.Stop1UpA = New KremerControlsWin32.KremerStatusBox
        Me.Stop1UpB = New KremerControlsWin32.KremerStatusBox
        Me.Stop1DownA = New KremerControlsWin32.KremerStatusBox
        Me.Stop1DownB = New KremerControlsWin32.KremerStatusBox
        Me.Stop2UpA = New KremerControlsWin32.KremerStatusBox
        Me.Stop2UpB = New KremerControlsWin32.KremerStatusBox
        Me.Stop2DownA = New KremerControlsWin32.KremerStatusBox
        Me.Stop2DownB = New KremerControlsWin32.KremerStatusBox
        Me.CartonInPockA = New KremerControlsWin32.KremerStatusBox
        Me.CartonInPockB = New KremerControlsWin32.KremerStatusBox
        Me.TIB_ProdFree = New KremerControlsWin32.KremerStatusBox
        Me.TIB_ProdSens1 = New KremerControlsWin32.KremerStatusBox
        Me.TIB_ProdSens2 = New KremerControlsWin32.KremerStatusBox
        Me.TIB_ProdSens3 = New KremerControlsWin32.KremerStatusBox
        Me.TIB_ProdSens4 = New KremerControlsWin32.KremerStatusBox
        Me.TIB_ProdSens5 = New KremerControlsWin32.KremerStatusBox
        Me.TIB_ProdSens6 = New KremerControlsWin32.KremerStatusBox
        Me.TIB_StopperUp = New KremerControlsWin32.KremerStatusBox
        Me.TIB_StopperDown = New KremerControlsWin32.KremerStatusBox
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.ZipperHome)
        Me.VarCollector.Variables.Add(Me.ZipperHigh)
        Me.VarCollector.Variables.Add(Me.UpperHomeA)
        Me.VarCollector.Variables.Add(Me.UpperHomeB)
        Me.VarCollector.Variables.Add(Me.CartonsAtStopper1)
        Me.VarCollector.Variables.Add(Me.CartonAtStopper2A)
        Me.VarCollector.Variables.Add(Me.CartonAtStopper2B)
        Me.VarCollector.Variables.Add(Me.Stopper1UpA)
        Me.VarCollector.Variables.Add(Me.Stopper1UpB)
        Me.VarCollector.Variables.Add(Me.Stopper1DownA)
        Me.VarCollector.Variables.Add(Me.Stopper1DownB)
        Me.VarCollector.Variables.Add(Me.Stopper2UpA)
        Me.VarCollector.Variables.Add(Me.Stopper2UpB)
        Me.VarCollector.Variables.Add(Me.Stopper2DownA)
        Me.VarCollector.Variables.Add(Me.Stopper2DownB)
        Me.VarCollector.Variables.Add(Me.TIBProductFree)
        Me.VarCollector.Variables.Add(Me.TIBProd1)
        Me.VarCollector.Variables.Add(Me.TIBProd2)
        Me.VarCollector.Variables.Add(Me.TIBProd3)
        Me.VarCollector.Variables.Add(Me.TIBProd4)
        Me.VarCollector.Variables.Add(Me.TIBProd5)
        Me.VarCollector.Variables.Add(Me.TIBProd6)
        Me.VarCollector.Variables.Add(Me.TIBStopperUp)
        Me.VarCollector.Variables.Add(Me.TIBStopperDown)
        Me.VarCollector.Variables.Add(Me.TelixHome)
        Me.VarCollector.Variables.Add(Me.TelixLimit)
        Me.VarCollector.Variables.Add(Me.TelixBeltIsIn)
        Me.VarCollector.Variables.Add(Me.CartonInPocketA)
        Me.VarCollector.Variables.Add(Me.CartonInPocketB)
        Me.VarCollector.Variables.Add(Me.UpperInfeedIsUp)
        Me.VarCollector.Variables.Add(Me.UpperInfeedIsDown)
        '
        'ZipperHome
        '
        Me.ZipperHome.BindControl = Me.plZipper_Home
        Me.ZipperHome.BindProperty = "Data"
        Me.ZipperHome.Data = Nothing
        Me.ZipperHome.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ZipperHome.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ZipperHome.VariableName = "InlineAutomation.Inline.Zipper.ixHome"
        '
        'plZipper_Home
        '
        Me.plZipper_Home.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plZipper_Home.ColorOn = System.Drawing.Color.Lime
        Me.plZipper_Home.Data = False
        Me.plZipper_Home.Line = True
        Me.plZipper_Home.LineSize = 1
        Me.plZipper_Home.Location = New System.Drawing.Point(15, 38)
        Me.plZipper_Home.Name = "plZipper_Home"
        Me.plZipper_Home.Size = New System.Drawing.Size(24, 24)
        Me.plZipper_Home.TabIndex = 37
        Me.plZipper_Home.Text = "KremerLight1"
        Me.plZipper_Home.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'ZipperHigh
        '
        Me.ZipperHigh.BindControl = Me.plZipperHighProduct
        Me.ZipperHigh.BindProperty = "Data"
        Me.ZipperHigh.Data = Nothing
        Me.ZipperHigh.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.ZipperHigh.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.ZipperHigh.VariableName = "InlineAutomation.Inline.Zipper.ixHighProduct"
        '
        'plZipperHighProduct
        '
        Me.plZipperHighProduct.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plZipperHighProduct.ColorOn = System.Drawing.Color.Lime
        Me.plZipperHighProduct.Data = False
        Me.plZipperHighProduct.Line = True
        Me.plZipperHighProduct.LineSize = 1
        Me.plZipperHighProduct.Location = New System.Drawing.Point(15, 63)
        Me.plZipperHighProduct.Name = "plZipperHighProduct"
        Me.plZipperHighProduct.Size = New System.Drawing.Size(24, 24)
        Me.plZipperHighProduct.TabIndex = 287
        Me.plZipperHighProduct.Text = "KremerLight1"
        Me.plZipperHighProduct.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'UpperHomeA
        '
        Me.UpperHomeA.BindControl = Me.plUppInfHoming_A
        Me.UpperHomeA.BindProperty = "Data"
        Me.UpperHomeA.Data = Nothing
        Me.UpperHomeA.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.UpperHomeA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.UpperHomeA.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.Belt_A.ixHome"
        '
        'plUppInfHoming_A
        '
        Me.plUppInfHoming_A.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plUppInfHoming_A.ColorOn = System.Drawing.Color.Lime
        Me.plUppInfHoming_A.Data = False
        Me.plUppInfHoming_A.Line = True
        Me.plUppInfHoming_A.LineSize = 1
        Me.plUppInfHoming_A.Location = New System.Drawing.Point(15, 138)
        Me.plUppInfHoming_A.Name = "plUppInfHoming_A"
        Me.plUppInfHoming_A.Size = New System.Drawing.Size(24, 24)
        Me.plUppInfHoming_A.TabIndex = 311
        Me.plUppInfHoming_A.Text = "KremerLight1"
        Me.plUppInfHoming_A.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'UpperHomeB
        '
        Me.UpperHomeB.BindControl = Me.plUppInfHoming_B
        Me.UpperHomeB.BindProperty = "Data"
        Me.UpperHomeB.Data = Nothing
        Me.UpperHomeB.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.UpperHomeB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.UpperHomeB.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.Belt_B.ixHome"
        '
        'plUppInfHoming_B
        '
        Me.plUppInfHoming_B.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plUppInfHoming_B.ColorOn = System.Drawing.Color.Lime
        Me.plUppInfHoming_B.Data = False
        Me.plUppInfHoming_B.Line = True
        Me.plUppInfHoming_B.LineSize = 1
        Me.plUppInfHoming_B.Location = New System.Drawing.Point(15, 163)
        Me.plUppInfHoming_B.Name = "plUppInfHoming_B"
        Me.plUppInfHoming_B.Size = New System.Drawing.Size(24, 24)
        Me.plUppInfHoming_B.TabIndex = 313
        Me.plUppInfHoming_B.Text = "KremerLight1"
        Me.plUppInfHoming_B.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'CartonsAtStopper1
        '
        Me.CartonsAtStopper1.BindControl = Me.plCartonAtStopper1
        Me.CartonsAtStopper1.BindProperty = "Data"
        Me.CartonsAtStopper1.Data = Nothing
        Me.CartonsAtStopper1.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.CartonsAtStopper1.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.CartonsAtStopper1.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.ixCartonsAtStopper1"
        '
        'plCartonAtStopper1
        '
        Me.plCartonAtStopper1.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plCartonAtStopper1.ColorOn = System.Drawing.Color.Lime
        Me.plCartonAtStopper1.Data = False
        Me.plCartonAtStopper1.Line = True
        Me.plCartonAtStopper1.LineSize = 1
        Me.plCartonAtStopper1.Location = New System.Drawing.Point(284, 38)
        Me.plCartonAtStopper1.Name = "plCartonAtStopper1"
        Me.plCartonAtStopper1.Size = New System.Drawing.Size(24, 24)
        Me.plCartonAtStopper1.TabIndex = 289
        Me.plCartonAtStopper1.Text = "KremerLight1"
        Me.plCartonAtStopper1.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'CartonAtStopper2A
        '
        Me.CartonAtStopper2A.BindControl = Me.plCartonAtStopper2_A
        Me.CartonAtStopper2A.BindProperty = "Data"
        Me.CartonAtStopper2A.Data = Nothing
        Me.CartonAtStopper2A.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.CartonAtStopper2A.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.CartonAtStopper2A.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.Stoppers_A.ixCartonAtStopper2"
        '
        'plCartonAtStopper2_A
        '
        Me.plCartonAtStopper2_A.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plCartonAtStopper2_A.ColorOn = System.Drawing.Color.Lime
        Me.plCartonAtStopper2_A.Data = False
        Me.plCartonAtStopper2_A.Line = True
        Me.plCartonAtStopper2_A.LineSize = 1
        Me.plCartonAtStopper2_A.Location = New System.Drawing.Point(284, 63)
        Me.plCartonAtStopper2_A.Name = "plCartonAtStopper2_A"
        Me.plCartonAtStopper2_A.Size = New System.Drawing.Size(24, 24)
        Me.plCartonAtStopper2_A.TabIndex = 291
        Me.plCartonAtStopper2_A.Text = "KremerLight1"
        Me.plCartonAtStopper2_A.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'CartonAtStopper2B
        '
        Me.CartonAtStopper2B.BindControl = Me.plCartonAtStopper2_B
        Me.CartonAtStopper2B.BindProperty = "Data"
        Me.CartonAtStopper2B.Data = Nothing
        Me.CartonAtStopper2B.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.CartonAtStopper2B.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.CartonAtStopper2B.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.Stoppers_B.ixCartonAtStopper2"
        '
        'plCartonAtStopper2_B
        '
        Me.plCartonAtStopper2_B.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plCartonAtStopper2_B.ColorOn = System.Drawing.Color.Lime
        Me.plCartonAtStopper2_B.Data = False
        Me.plCartonAtStopper2_B.Line = True
        Me.plCartonAtStopper2_B.LineSize = 1
        Me.plCartonAtStopper2_B.Location = New System.Drawing.Point(284, 88)
        Me.plCartonAtStopper2_B.Name = "plCartonAtStopper2_B"
        Me.plCartonAtStopper2_B.Size = New System.Drawing.Size(24, 24)
        Me.plCartonAtStopper2_B.TabIndex = 293
        Me.plCartonAtStopper2_B.Text = "KremerLight1"
        Me.plCartonAtStopper2_B.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Stopper1UpA
        '
        Me.Stopper1UpA.BindControl = Me.plStopper1Up_A
        Me.Stopper1UpA.BindProperty = "Data"
        Me.Stopper1UpA.Data = Nothing
        Me.Stopper1UpA.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Stopper1UpA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Stopper1UpA.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.Stoppers_A.Stopper1.ixOut"
        '
        'plStopper1Up_A
        '
        Me.plStopper1Up_A.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plStopper1Up_A.ColorOn = System.Drawing.Color.Lime
        Me.plStopper1Up_A.Data = False
        Me.plStopper1Up_A.Line = True
        Me.plStopper1Up_A.LineSize = 1
        Me.plStopper1Up_A.Location = New System.Drawing.Point(284, 113)
        Me.plStopper1Up_A.Name = "plStopper1Up_A"
        Me.plStopper1Up_A.Size = New System.Drawing.Size(24, 24)
        Me.plStopper1Up_A.TabIndex = 295
        Me.plStopper1Up_A.Text = "KremerLight1"
        Me.plStopper1Up_A.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Stopper1UpB
        '
        Me.Stopper1UpB.BindControl = Me.plStopper1Up_B
        Me.Stopper1UpB.BindProperty = "Data"
        Me.Stopper1UpB.Data = Nothing
        Me.Stopper1UpB.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Stopper1UpB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Stopper1UpB.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.Stoppers_B.Stopper1.ixOut"
        '
        'plStopper1Up_B
        '
        Me.plStopper1Up_B.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plStopper1Up_B.ColorOn = System.Drawing.Color.Lime
        Me.plStopper1Up_B.Data = False
        Me.plStopper1Up_B.Line = True
        Me.plStopper1Up_B.LineSize = 1
        Me.plStopper1Up_B.Location = New System.Drawing.Point(284, 138)
        Me.plStopper1Up_B.Name = "plStopper1Up_B"
        Me.plStopper1Up_B.Size = New System.Drawing.Size(24, 24)
        Me.plStopper1Up_B.TabIndex = 297
        Me.plStopper1Up_B.Text = "KremerLight1"
        Me.plStopper1Up_B.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Stopper1DownA
        '
        Me.Stopper1DownA.BindControl = Me.plStopper1Down_A
        Me.Stopper1DownA.BindProperty = "Data"
        Me.Stopper1DownA.Data = Nothing
        Me.Stopper1DownA.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Stopper1DownA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Stopper1DownA.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.Stoppers_A.Stopper1.ixIn"
        '
        'plStopper1Down_A
        '
        Me.plStopper1Down_A.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plStopper1Down_A.ColorOn = System.Drawing.Color.Lime
        Me.plStopper1Down_A.Data = False
        Me.plStopper1Down_A.Line = True
        Me.plStopper1Down_A.LineSize = 1
        Me.plStopper1Down_A.Location = New System.Drawing.Point(284, 163)
        Me.plStopper1Down_A.Name = "plStopper1Down_A"
        Me.plStopper1Down_A.Size = New System.Drawing.Size(24, 24)
        Me.plStopper1Down_A.TabIndex = 299
        Me.plStopper1Down_A.Text = "KremerLight1"
        Me.plStopper1Down_A.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Stopper1DownB
        '
        Me.Stopper1DownB.BindControl = Me.plStopper1Down_B
        Me.Stopper1DownB.BindProperty = "Data"
        Me.Stopper1DownB.Data = Nothing
        Me.Stopper1DownB.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Stopper1DownB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Stopper1DownB.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.Stoppers_B.Stopper1.ixIn"
        '
        'plStopper1Down_B
        '
        Me.plStopper1Down_B.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plStopper1Down_B.ColorOn = System.Drawing.Color.Lime
        Me.plStopper1Down_B.Data = False
        Me.plStopper1Down_B.Line = True
        Me.plStopper1Down_B.LineSize = 1
        Me.plStopper1Down_B.Location = New System.Drawing.Point(284, 188)
        Me.plStopper1Down_B.Name = "plStopper1Down_B"
        Me.plStopper1Down_B.Size = New System.Drawing.Size(24, 24)
        Me.plStopper1Down_B.TabIndex = 301
        Me.plStopper1Down_B.Text = "KremerLight1"
        Me.plStopper1Down_B.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Stopper2UpA
        '
        Me.Stopper2UpA.BindControl = Me.plStopper2Up_A
        Me.Stopper2UpA.BindProperty = "Data"
        Me.Stopper2UpA.Data = Nothing
        Me.Stopper2UpA.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Stopper2UpA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Stopper2UpA.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.Stoppers_A.Stopper2.ixIn"
        '
        'plStopper2Up_A
        '
        Me.plStopper2Up_A.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plStopper2Up_A.ColorOn = System.Drawing.Color.Lime
        Me.plStopper2Up_A.Data = False
        Me.plStopper2Up_A.Line = True
        Me.plStopper2Up_A.LineSize = 1
        Me.plStopper2Up_A.Location = New System.Drawing.Point(284, 214)
        Me.plStopper2Up_A.Name = "plStopper2Up_A"
        Me.plStopper2Up_A.Size = New System.Drawing.Size(24, 24)
        Me.plStopper2Up_A.TabIndex = 303
        Me.plStopper2Up_A.Text = "KremerLight1"
        Me.plStopper2Up_A.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Stopper2UpB
        '
        Me.Stopper2UpB.BindControl = Me.plStopper2Up_B
        Me.Stopper2UpB.BindProperty = "Data"
        Me.Stopper2UpB.Data = Nothing
        Me.Stopper2UpB.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Stopper2UpB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Stopper2UpB.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.Stoppers_B.Stopper2.ixIn"
        '
        'plStopper2Up_B
        '
        Me.plStopper2Up_B.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plStopper2Up_B.ColorOn = System.Drawing.Color.Lime
        Me.plStopper2Up_B.Data = False
        Me.plStopper2Up_B.Line = True
        Me.plStopper2Up_B.LineSize = 1
        Me.plStopper2Up_B.Location = New System.Drawing.Point(284, 239)
        Me.plStopper2Up_B.Name = "plStopper2Up_B"
        Me.plStopper2Up_B.Size = New System.Drawing.Size(24, 24)
        Me.plStopper2Up_B.TabIndex = 305
        Me.plStopper2Up_B.Text = "KremerLight1"
        Me.plStopper2Up_B.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Stopper2DownA
        '
        Me.Stopper2DownA.BindControl = Me.plStopper2Down_A
        Me.Stopper2DownA.BindProperty = "Data"
        Me.Stopper2DownA.Data = Nothing
        Me.Stopper2DownA.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Stopper2DownA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Stopper2DownA.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.Stoppers_A.Stopper2.ixOut"
        '
        'plStopper2Down_A
        '
        Me.plStopper2Down_A.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plStopper2Down_A.ColorOn = System.Drawing.Color.Lime
        Me.plStopper2Down_A.Data = False
        Me.plStopper2Down_A.Line = True
        Me.plStopper2Down_A.LineSize = 1
        Me.plStopper2Down_A.Location = New System.Drawing.Point(284, 264)
        Me.plStopper2Down_A.Name = "plStopper2Down_A"
        Me.plStopper2Down_A.Size = New System.Drawing.Size(24, 24)
        Me.plStopper2Down_A.TabIndex = 307
        Me.plStopper2Down_A.Text = "KremerLight1"
        Me.plStopper2Down_A.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'Stopper2DownB
        '
        Me.Stopper2DownB.BindControl = Me.plStopper2Down_B
        Me.Stopper2DownB.BindProperty = "Data"
        Me.Stopper2DownB.Data = Nothing
        Me.Stopper2DownB.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.Stopper2DownB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.Stopper2DownB.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.Stoppers_B.Stopper2.ixOut"
        '
        'plStopper2Down_B
        '
        Me.plStopper2Down_B.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plStopper2Down_B.ColorOn = System.Drawing.Color.Lime
        Me.plStopper2Down_B.Data = False
        Me.plStopper2Down_B.Line = True
        Me.plStopper2Down_B.LineSize = 1
        Me.plStopper2Down_B.Location = New System.Drawing.Point(284, 289)
        Me.plStopper2Down_B.Name = "plStopper2Down_B"
        Me.plStopper2Down_B.Size = New System.Drawing.Size(24, 24)
        Me.plStopper2Down_B.TabIndex = 309
        Me.plStopper2Down_B.Text = "KremerLight1"
        Me.plStopper2Down_B.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TIBProductFree
        '
        Me.TIBProductFree.BindControl = Me.plTIBProdFree
        Me.TIBProductFree.BindProperty = "Data"
        Me.TIBProductFree.Data = Nothing
        Me.TIBProductFree.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TIBProductFree.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TIBProductFree.VariableName = "InlineAutomation.Inline.TimingInfeed.ixProductSensor[1]"
        '
        'plTIBProdFree
        '
        Me.plTIBProdFree.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plTIBProdFree.ColorOn = System.Drawing.Color.Lime
        Me.plTIBProdFree.Data = False
        Me.plTIBProdFree.Line = True
        Me.plTIBProdFree.LineSize = 1
        Me.plTIBProdFree.Location = New System.Drawing.Point(554, 38)
        Me.plTIBProdFree.Name = "plTIBProdFree"
        Me.plTIBProdFree.Size = New System.Drawing.Size(24, 24)
        Me.plTIBProdFree.TabIndex = 359
        Me.plTIBProdFree.Text = "KremerLight1"
        Me.plTIBProdFree.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TIBProd1
        '
        Me.TIBProd1.BindControl = Me.plTIBProd1
        Me.TIBProd1.BindProperty = "Data"
        Me.TIBProd1.Data = Nothing
        Me.TIBProd1.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TIBProd1.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TIBProd1.VariableName = "InlineAutomation.Inline.TimingInfeed.ixProductSensor[2]"
        '
        'plTIBProd1
        '
        Me.plTIBProd1.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plTIBProd1.ColorOn = System.Drawing.Color.Lime
        Me.plTIBProd1.Data = False
        Me.plTIBProd1.Line = True
        Me.plTIBProd1.LineSize = 1
        Me.plTIBProd1.Location = New System.Drawing.Point(554, 63)
        Me.plTIBProd1.Name = "plTIBProd1"
        Me.plTIBProd1.Size = New System.Drawing.Size(24, 24)
        Me.plTIBProd1.TabIndex = 317
        Me.plTIBProd1.Text = "KremerLight1"
        Me.plTIBProd1.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TIBProd2
        '
        Me.TIBProd2.BindControl = Me.plTIBProd2
        Me.TIBProd2.BindProperty = "Data"
        Me.TIBProd2.Data = Nothing
        Me.TIBProd2.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TIBProd2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TIBProd2.VariableName = "InlineAutomation.Inline.TimingInfeed.ixProductSensor[3]"
        '
        'plTIBProd2
        '
        Me.plTIBProd2.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plTIBProd2.ColorOn = System.Drawing.Color.Lime
        Me.plTIBProd2.Data = False
        Me.plTIBProd2.Line = True
        Me.plTIBProd2.LineSize = 1
        Me.plTIBProd2.Location = New System.Drawing.Point(554, 88)
        Me.plTIBProd2.Name = "plTIBProd2"
        Me.plTIBProd2.Size = New System.Drawing.Size(24, 24)
        Me.plTIBProd2.TabIndex = 319
        Me.plTIBProd2.Text = "KremerLight1"
        Me.plTIBProd2.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TIBProd3
        '
        Me.TIBProd3.BindControl = Me.plTIBProd3
        Me.TIBProd3.BindProperty = "Data"
        Me.TIBProd3.Data = Nothing
        Me.TIBProd3.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TIBProd3.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TIBProd3.VariableName = "InlineAutomation.Inline.TimingInfeed.ixProductSensor[4]"
        '
        'plTIBProd3
        '
        Me.plTIBProd3.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plTIBProd3.ColorOn = System.Drawing.Color.Lime
        Me.plTIBProd3.Data = False
        Me.plTIBProd3.Line = True
        Me.plTIBProd3.LineSize = 1
        Me.plTIBProd3.Location = New System.Drawing.Point(554, 113)
        Me.plTIBProd3.Name = "plTIBProd3"
        Me.plTIBProd3.Size = New System.Drawing.Size(24, 24)
        Me.plTIBProd3.TabIndex = 321
        Me.plTIBProd3.Text = "KremerLight1"
        Me.plTIBProd3.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TIBProd4
        '
        Me.TIBProd4.BindControl = Me.plTIBProd4
        Me.TIBProd4.BindProperty = "Data"
        Me.TIBProd4.Data = Nothing
        Me.TIBProd4.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TIBProd4.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TIBProd4.VariableName = "InlineAutomation.Inline.TimingInfeed.ixProductSensor[5]"
        '
        'plTIBProd4
        '
        Me.plTIBProd4.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plTIBProd4.ColorOn = System.Drawing.Color.Lime
        Me.plTIBProd4.Data = False
        Me.plTIBProd4.Line = True
        Me.plTIBProd4.LineSize = 1
        Me.plTIBProd4.Location = New System.Drawing.Point(554, 138)
        Me.plTIBProd4.Name = "plTIBProd4"
        Me.plTIBProd4.Size = New System.Drawing.Size(24, 24)
        Me.plTIBProd4.TabIndex = 323
        Me.plTIBProd4.Text = "KremerLight1"
        Me.plTIBProd4.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TIBProd5
        '
        Me.TIBProd5.BindControl = Me.plTIBProd5
        Me.TIBProd5.BindProperty = "Data"
        Me.TIBProd5.Data = Nothing
        Me.TIBProd5.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TIBProd5.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TIBProd5.VariableName = "InlineAutomation.Inline.TimingInfeed.ixProductSensor[6]"
        '
        'plTIBProd5
        '
        Me.plTIBProd5.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plTIBProd5.ColorOn = System.Drawing.Color.Lime
        Me.plTIBProd5.Data = False
        Me.plTIBProd5.Line = True
        Me.plTIBProd5.LineSize = 1
        Me.plTIBProd5.Location = New System.Drawing.Point(554, 163)
        Me.plTIBProd5.Name = "plTIBProd5"
        Me.plTIBProd5.Size = New System.Drawing.Size(24, 24)
        Me.plTIBProd5.TabIndex = 357
        Me.plTIBProd5.Text = "KremerLight1"
        Me.plTIBProd5.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TIBProd6
        '
        Me.TIBProd6.BindControl = Me.plTIBProd6
        Me.TIBProd6.BindProperty = "Data"
        Me.TIBProd6.Data = Nothing
        Me.TIBProd6.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TIBProd6.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TIBProd6.VariableName = "InlineAutomation.Inline.TimingInfeed.ixProductSensor[7]"
        '
        'plTIBProd6
        '
        Me.plTIBProd6.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plTIBProd6.ColorOn = System.Drawing.Color.Lime
        Me.plTIBProd6.Data = False
        Me.plTIBProd6.Line = True
        Me.plTIBProd6.LineSize = 1
        Me.plTIBProd6.Location = New System.Drawing.Point(554, 187)
        Me.plTIBProd6.Name = "plTIBProd6"
        Me.plTIBProd6.Size = New System.Drawing.Size(24, 24)
        Me.plTIBProd6.TabIndex = 315
        Me.plTIBProd6.Text = "KremerLight1"
        Me.plTIBProd6.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TIBStopperUp
        '
        Me.TIBStopperUp.BindControl = Me.plTIBStopperUp
        Me.TIBStopperUp.BindProperty = "Data"
        Me.TIBStopperUp.Data = Nothing
        Me.TIBStopperUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TIBStopperUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TIBStopperUp.VariableName = "InlineAutomation.Inline.TimingInfeed.Stopper2.Stopper.ixOut"
        '
        'plTIBStopperUp
        '
        Me.plTIBStopperUp.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plTIBStopperUp.ColorOn = System.Drawing.Color.Lime
        Me.plTIBStopperUp.Data = False
        Me.plTIBStopperUp.Line = True
        Me.plTIBStopperUp.LineSize = 1
        Me.plTIBStopperUp.Location = New System.Drawing.Point(554, 212)
        Me.plTIBStopperUp.Name = "plTIBStopperUp"
        Me.plTIBStopperUp.Size = New System.Drawing.Size(24, 24)
        Me.plTIBStopperUp.TabIndex = 333
        Me.plTIBStopperUp.Text = "KremerLight1"
        Me.plTIBStopperUp.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TIBStopperDown
        '
        Me.TIBStopperDown.BindControl = Me.plTIBStopperDown
        Me.TIBStopperDown.BindProperty = "Data"
        Me.TIBStopperDown.Data = Nothing
        Me.TIBStopperDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TIBStopperDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TIBStopperDown.VariableName = "InlineAutomation.Inline.TimingInfeed.Stopper2.Stopper.ixIn"
        '
        'plTIBStopperDown
        '
        Me.plTIBStopperDown.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plTIBStopperDown.ColorOn = System.Drawing.Color.Lime
        Me.plTIBStopperDown.Data = False
        Me.plTIBStopperDown.Line = True
        Me.plTIBStopperDown.LineSize = 1
        Me.plTIBStopperDown.Location = New System.Drawing.Point(554, 237)
        Me.plTIBStopperDown.Name = "plTIBStopperDown"
        Me.plTIBStopperDown.Size = New System.Drawing.Size(24, 24)
        Me.plTIBStopperDown.TabIndex = 335
        Me.plTIBStopperDown.Text = "KremerLight1"
        Me.plTIBStopperDown.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TelixHome
        '
        Me.TelixHome.BindControl = Me.plTelHome
        Me.TelixHome.BindProperty = "Data"
        Me.TelixHome.Data = Nothing
        Me.TelixHome.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TelixHome.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TelixHome.VariableName = "InlineAutomation.Inline.Infeed.Telescopic.ixHome"
        '
        'plTelHome
        '
        Me.plTelHome.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plTelHome.ColorOn = System.Drawing.Color.Lime
        Me.plTelHome.Data = False
        Me.plTelHome.Line = True
        Me.plTelHome.LineSize = 1
        Me.plTelHome.Location = New System.Drawing.Point(15, 289)
        Me.plTelHome.Name = "plTelHome"
        Me.plTelHome.Size = New System.Drawing.Size(24, 24)
        Me.plTelHome.TabIndex = 341
        Me.plTelHome.Text = "KremerLight1"
        Me.plTelHome.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TelixLimit
        '
        Me.TelixLimit.BindControl = Me.plTelLimit
        Me.TelixLimit.BindProperty = "Data"
        Me.TelixLimit.Data = Nothing
        Me.TelixLimit.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TelixLimit.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TelixLimit.VariableName = "InlineAutomation.Inline.Infeed.Telescopic.ixLimit"
        '
        'plTelLimit
        '
        Me.plTelLimit.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plTelLimit.ColorOn = System.Drawing.Color.Lime
        Me.plTelLimit.Data = False
        Me.plTelLimit.Line = True
        Me.plTelLimit.LineSize = 1
        Me.plTelLimit.Location = New System.Drawing.Point(15, 314)
        Me.plTelLimit.Name = "plTelLimit"
        Me.plTelLimit.Size = New System.Drawing.Size(24, 24)
        Me.plTelLimit.TabIndex = 343
        Me.plTelLimit.Text = "KremerLight1"
        Me.plTelLimit.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'TelixBeltIsIn
        '
        Me.TelixBeltIsIn.BindControl = Me.plTelBeltIsIn
        Me.TelixBeltIsIn.BindProperty = "Data"
        Me.TelixBeltIsIn.Data = Nothing
        Me.TelixBeltIsIn.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.TelixBeltIsIn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TelixBeltIsIn.VariableName = "InlineAutomation.Inline.Infeed.Telescopic.ixBeltIsIn"
        '
        'plTelBeltIsIn
        '
        Me.plTelBeltIsIn.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plTelBeltIsIn.ColorOn = System.Drawing.Color.Lime
        Me.plTelBeltIsIn.Data = False
        Me.plTelBeltIsIn.Line = True
        Me.plTelBeltIsIn.LineSize = 1
        Me.plTelBeltIsIn.Location = New System.Drawing.Point(15, 339)
        Me.plTelBeltIsIn.Name = "plTelBeltIsIn"
        Me.plTelBeltIsIn.Size = New System.Drawing.Size(24, 24)
        Me.plTelBeltIsIn.TabIndex = 346
        Me.plTelBeltIsIn.Text = "KremerLight3"
        Me.plTelBeltIsIn.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'CartonInPocketA
        '
        Me.CartonInPocketA.BindControl = Me.plCartonInPocketA
        Me.CartonInPocketA.BindProperty = "Data"
        Me.CartonInPocketA.Data = Nothing
        Me.CartonInPocketA.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.CartonInPocketA.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.CartonInPocketA.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.ixCartonInPocket_A"
        '
        'plCartonInPocketA
        '
        Me.plCartonInPocketA.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plCartonInPocketA.ColorOn = System.Drawing.Color.Lime
        Me.plCartonInPocketA.Data = False
        Me.plCartonInPocketA.Line = True
        Me.plCartonInPocketA.LineSize = 1
        Me.plCartonInPocketA.Location = New System.Drawing.Point(284, 314)
        Me.plCartonInPocketA.Name = "plCartonInPocketA"
        Me.plCartonInPocketA.Size = New System.Drawing.Size(24, 24)
        Me.plCartonInPocketA.TabIndex = 348
        Me.plCartonInPocketA.Text = "KremerLight1"
        Me.plCartonInPocketA.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'CartonInPocketB
        '
        Me.CartonInPocketB.BindControl = Me.plCartonInPocketB
        Me.CartonInPocketB.BindProperty = "Data"
        Me.CartonInPocketB.Data = Nothing
        Me.CartonInPocketB.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.CartonInPocketB.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.CartonInPocketB.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.ixCartonInPocket_B"
        '
        'plCartonInPocketB
        '
        Me.plCartonInPocketB.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plCartonInPocketB.ColorOn = System.Drawing.Color.Lime
        Me.plCartonInPocketB.Data = False
        Me.plCartonInPocketB.Line = True
        Me.plCartonInPocketB.LineSize = 1
        Me.plCartonInPocketB.Location = New System.Drawing.Point(284, 339)
        Me.plCartonInPocketB.Name = "plCartonInPocketB"
        Me.plCartonInPocketB.Size = New System.Drawing.Size(24, 24)
        Me.plCartonInPocketB.TabIndex = 350
        Me.plCartonInPocketB.Text = "KremerLight1"
        Me.plCartonInPocketB.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'UpperInfeedIsUp
        '
        Me.UpperInfeedIsUp.BindControl = Me.plUpperInfeedIsUp
        Me.UpperInfeedIsUp.BindProperty = "Data"
        Me.UpperInfeedIsUp.Data = Nothing
        Me.UpperInfeedIsUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.UpperInfeedIsUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.UpperInfeedIsUp.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.Cilinder.ixOut"
        '
        'plUpperInfeedIsUp
        '
        Me.plUpperInfeedIsUp.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plUpperInfeedIsUp.ColorOn = System.Drawing.Color.Lime
        Me.plUpperInfeedIsUp.Data = False
        Me.plUpperInfeedIsUp.Line = True
        Me.plUpperInfeedIsUp.LineSize = 1
        Me.plUpperInfeedIsUp.Location = New System.Drawing.Point(15, 188)
        Me.plUpperInfeedIsUp.Name = "plUpperInfeedIsUp"
        Me.plUpperInfeedIsUp.Size = New System.Drawing.Size(24, 24)
        Me.plUpperInfeedIsUp.TabIndex = 352
        Me.plUpperInfeedIsUp.Text = "KremerLight1"
        Me.plUpperInfeedIsUp.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
        '
        'UpperInfeedIsDown
        '
        Me.UpperInfeedIsDown.BindControl = Me.plUpperInfeedIsDown
        Me.UpperInfeedIsDown.BindProperty = "Data"
        Me.UpperInfeedIsDown.Data = Nothing
        Me.UpperInfeedIsDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.BOOL
        Me.UpperInfeedIsDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.UpperInfeedIsDown.VariableName = "InlineAutomation.Inline.Zipper.UpperInfeed.Cilinder.ixIn"
        '
        'plUpperInfeedIsDown
        '
        Me.plUpperInfeedIsDown.ColorOff = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.plUpperInfeedIsDown.ColorOn = System.Drawing.Color.Lime
        Me.plUpperInfeedIsDown.Data = False
        Me.plUpperInfeedIsDown.Line = True
        Me.plUpperInfeedIsDown.LineSize = 1
        Me.plUpperInfeedIsDown.Location = New System.Drawing.Point(15, 213)
        Me.plUpperInfeedIsDown.Name = "plUpperInfeedIsDown"
        Me.plUpperInfeedIsDown.Size = New System.Drawing.Size(24, 24)
        Me.plUpperInfeedIsDown.TabIndex = 354
        Me.plUpperInfeedIsDown.Text = "KremerLight1"
        Me.plUpperInfeedIsDown.Type = KremerControlsWin32.KremerLight.GraphicType.Ellipse
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
        Me.Btn_Overview.Location = New System.Drawing.Point(685, 385)
        Me.Btn_Overview.Name = "Btn_Overview"
        Me.Btn_Overview.Size = New System.Drawing.Size(114, 50)
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
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(550, 10)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(231, 25)
        Me.Label27.TabIndex = 337
        Me.Label27.Tag = ""
        Me.Label27.Text = "Timing Infeed Belt"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(280, 10)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(231, 25)
        Me.Label28.TabIndex = 338
        Me.Label28.Tag = ""
        Me.Label28.Text = "Stoppers Infeed"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(11, 10)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(231, 25)
        Me.Label29.TabIndex = 339
        Me.Label29.Tag = ""
        Me.Label29.Text = "Zipper"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(11, 113)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(231, 25)
        Me.Label30.TabIndex = 340
        Me.Label30.Tag = ""
        Me.Label30.Text = "Upper Infeed"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(11, 264)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(231, 25)
        Me.Label31.TabIndex = 345
        Me.Label31.Tag = ""
        Me.Label31.Text = "Telescopic Belt"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ZipperHomingSensor
        '
        Me.ZipperHomingSensor.BackColor = System.Drawing.SystemColors.Control
        Me.ZipperHomingSensor.BackColorOn = System.Drawing.Color.Lime
        Me.ZipperHomingSensor.Data = 0
        Me.ZipperHomingSensor.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ZipperHomingSensor.ForeColor = System.Drawing.Color.Black
        Me.ZipperHomingSensor.ForeColorOn = System.Drawing.Color.Black
        Me.ZipperHomingSensor.Location = New System.Drawing.Point(46, 38)
        Me.ZipperHomingSensor.Name = "ZipperHomingSensor"
        Me.ZipperHomingSensor.Size = New System.Drawing.Size(196, 25)
        Me.ZipperHomingSensor.State = False
        Me.ZipperHomingSensor.StatusText = Nothing
        Me.ZipperHomingSensor.TabIndex = 369
        Me.ZipperHomingSensor.Text = "Zipper Homing Sensor"
        Me.ZipperHomingSensor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ZipperHighProduct
        '
        Me.ZipperHighProduct.BackColor = System.Drawing.SystemColors.Control
        Me.ZipperHighProduct.BackColorOn = System.Drawing.Color.Lime
        Me.ZipperHighProduct.Data = 0
        Me.ZipperHighProduct.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ZipperHighProduct.ForeColor = System.Drawing.Color.Black
        Me.ZipperHighProduct.ForeColorOn = System.Drawing.Color.Black
        Me.ZipperHighProduct.Location = New System.Drawing.Point(46, 63)
        Me.ZipperHighProduct.Name = "ZipperHighProduct"
        Me.ZipperHighProduct.Size = New System.Drawing.Size(196, 25)
        Me.ZipperHighProduct.State = False
        Me.ZipperHighProduct.StatusText = New String() {"Jeroen", "Marijn"}
        Me.ZipperHighProduct.TabIndex = 369
        Me.ZipperHighProduct.Text = "Zipper High Product"
        Me.ZipperHighProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnToggleText
        '
        Me.btnToggleText.Audit = Nothing
        Me.btnToggleText.AuditEnabled = False
        Me.btnToggleText.AuditMessage = "KremerPushButton pressed!"
        Me.btnToggleText.AuditSource = "KremerPushButton"
        Me.btnToggleText.BackColorOn = System.Drawing.Color.Empty
        Me.btnToggleText.BackGroundImageOn = Nothing
        Me.btnToggleText.ButtonAction = KremerControlsWin32.KremerButton.Action.ToggleBool
        Me.btnToggleText.Data = False
        Me.btnToggleText.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnToggleText.ForeColorOn = System.Drawing.Color.Empty
        Me.btnToggleText.Location = New System.Drawing.Point(571, 385)
        Me.btnToggleText.Name = "btnToggleText"
        Me.btnToggleText.Size = New System.Drawing.Size(114, 50)
        Me.btnToggleText.State = False
        Me.btnToggleText.StateIsData = True
        Me.btnToggleText.StateText = New String() {Nothing, Nothing}
        Me.btnToggleText.TabIndex = 370
        Me.btnToggleText.Tag = "547"
        Me.btnToggleText.Text = "Toggle Text"
        Me.btnToggleText.UserInfo = Nothing
        Me.btnToggleText.UserLevel = 0
        Me.btnToggleText.UseStateText = False
        Me.btnToggleText.UseVisualStyleBackColor = True
        '
        'UpperInfHomSensA
        '
        Me.UpperInfHomSensA.BackColor = System.Drawing.SystemColors.Control
        Me.UpperInfHomSensA.BackColorOn = System.Drawing.Color.Lime
        Me.UpperInfHomSensA.Data = 0
        Me.UpperInfHomSensA.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.UpperInfHomSensA.ForeColor = System.Drawing.Color.Black
        Me.UpperInfHomSensA.ForeColorOn = System.Drawing.Color.Black
        Me.UpperInfHomSensA.Location = New System.Drawing.Point(46, 138)
        Me.UpperInfHomSensA.Name = "UpperInfHomSensA"
        Me.UpperInfHomSensA.Size = New System.Drawing.Size(227, 25)
        Me.UpperInfHomSensA.State = False
        Me.UpperInfHomSensA.StatusText = New String() {"Jeroen", "Marijn"}
        Me.UpperInfHomSensA.TabIndex = 369
        Me.UpperInfHomSensA.Text = "UpperInf. Homing Sensor A"
        Me.UpperInfHomSensA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UpperInfHomSensB
        '
        Me.UpperInfHomSensB.BackColor = System.Drawing.SystemColors.Control
        Me.UpperInfHomSensB.BackColorOn = System.Drawing.Color.Lime
        Me.UpperInfHomSensB.Data = 0
        Me.UpperInfHomSensB.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.UpperInfHomSensB.ForeColor = System.Drawing.Color.Black
        Me.UpperInfHomSensB.ForeColorOn = System.Drawing.Color.Black
        Me.UpperInfHomSensB.Location = New System.Drawing.Point(46, 163)
        Me.UpperInfHomSensB.Name = "UpperInfHomSensB"
        Me.UpperInfHomSensB.Size = New System.Drawing.Size(227, 25)
        Me.UpperInfHomSensB.State = False
        Me.UpperInfHomSensB.StatusText = New String() {"Jeroen", "Marijn"}
        Me.UpperInfHomSensB.TabIndex = 369
        Me.UpperInfHomSensB.Text = "UpperInf. Homing Sensor B"
        Me.UpperInfHomSensB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UpperInfIsUp
        '
        Me.UpperInfIsUp.BackColor = System.Drawing.SystemColors.Control
        Me.UpperInfIsUp.BackColorOn = System.Drawing.Color.Lime
        Me.UpperInfIsUp.Data = 0
        Me.UpperInfIsUp.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.UpperInfIsUp.ForeColor = System.Drawing.Color.Black
        Me.UpperInfIsUp.ForeColorOn = System.Drawing.Color.Black
        Me.UpperInfIsUp.Location = New System.Drawing.Point(45, 188)
        Me.UpperInfIsUp.Name = "UpperInfIsUp"
        Me.UpperInfIsUp.Size = New System.Drawing.Size(227, 25)
        Me.UpperInfIsUp.State = False
        Me.UpperInfIsUp.StatusText = New String() {"Jeroen", "Marijn"}
        Me.UpperInfIsUp.TabIndex = 369
        Me.UpperInfIsUp.Text = "UpperInfeed is Up"
        Me.UpperInfIsUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UpperInfIsDown
        '
        Me.UpperInfIsDown.BackColor = System.Drawing.SystemColors.Control
        Me.UpperInfIsDown.BackColorOn = System.Drawing.Color.Lime
        Me.UpperInfIsDown.Data = 0
        Me.UpperInfIsDown.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.UpperInfIsDown.ForeColor = System.Drawing.Color.Black
        Me.UpperInfIsDown.ForeColorOn = System.Drawing.Color.Black
        Me.UpperInfIsDown.Location = New System.Drawing.Point(45, 212)
        Me.UpperInfIsDown.Name = "UpperInfIsDown"
        Me.UpperInfIsDown.Size = New System.Drawing.Size(227, 25)
        Me.UpperInfIsDown.State = False
        Me.UpperInfIsDown.StatusText = New String() {"Jeroen", "Marijn"}
        Me.UpperInfIsDown.TabIndex = 369
        Me.UpperInfIsDown.Text = "UpperInfeed is Down"
        Me.UpperInfIsDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TelHomingSensor
        '
        Me.TelHomingSensor.BackColor = System.Drawing.SystemColors.Control
        Me.TelHomingSensor.BackColorOn = System.Drawing.Color.Lime
        Me.TelHomingSensor.Data = 0
        Me.TelHomingSensor.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TelHomingSensor.ForeColor = System.Drawing.Color.Black
        Me.TelHomingSensor.ForeColorOn = System.Drawing.Color.Black
        Me.TelHomingSensor.Location = New System.Drawing.Point(46, 289)
        Me.TelHomingSensor.Name = "TelHomingSensor"
        Me.TelHomingSensor.Size = New System.Drawing.Size(227, 25)
        Me.TelHomingSensor.State = False
        Me.TelHomingSensor.StatusText = New String() {"Jeroen", "Marijn"}
        Me.TelHomingSensor.TabIndex = 369
        Me.TelHomingSensor.Text = "Telescopic Homing Sensor"
        Me.TelHomingSensor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TelLimitSwitch
        '
        Me.TelLimitSwitch.BackColor = System.Drawing.SystemColors.Control
        Me.TelLimitSwitch.BackColorOn = System.Drawing.Color.Lime
        Me.TelLimitSwitch.Data = 0
        Me.TelLimitSwitch.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TelLimitSwitch.ForeColor = System.Drawing.Color.Black
        Me.TelLimitSwitch.ForeColorOn = System.Drawing.Color.Black
        Me.TelLimitSwitch.Location = New System.Drawing.Point(45, 314)
        Me.TelLimitSwitch.Name = "TelLimitSwitch"
        Me.TelLimitSwitch.Size = New System.Drawing.Size(227, 25)
        Me.TelLimitSwitch.State = False
        Me.TelLimitSwitch.StatusText = New String() {"Jeroen", "Marijn"}
        Me.TelLimitSwitch.TabIndex = 369
        Me.TelLimitSwitch.Text = "Telescopic Limit Switch"
        Me.TelLimitSwitch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TelBeltIn
        '
        Me.TelBeltIn.BackColor = System.Drawing.SystemColors.Control
        Me.TelBeltIn.BackColorOn = System.Drawing.Color.Lime
        Me.TelBeltIn.Data = 0
        Me.TelBeltIn.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TelBeltIn.ForeColor = System.Drawing.Color.Black
        Me.TelBeltIn.ForeColorOn = System.Drawing.Color.Black
        Me.TelBeltIn.Location = New System.Drawing.Point(45, 339)
        Me.TelBeltIn.Name = "TelBeltIn"
        Me.TelBeltIn.Size = New System.Drawing.Size(227, 25)
        Me.TelBeltIn.State = False
        Me.TelBeltIn.StatusText = New String() {"Jeroen", "Marijn"}
        Me.TelBeltIn.TabIndex = 369
        Me.TelBeltIn.Text = "Telescopic Belt is In"
        Me.TelBeltIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CartonAtStop1
        '
        Me.CartonAtStop1.BackColor = System.Drawing.SystemColors.Control
        Me.CartonAtStop1.BackColorOn = System.Drawing.Color.Lime
        Me.CartonAtStop1.Data = 0
        Me.CartonAtStop1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.CartonAtStop1.ForeColor = System.Drawing.Color.Black
        Me.CartonAtStop1.ForeColorOn = System.Drawing.Color.Black
        Me.CartonAtStop1.Location = New System.Drawing.Point(315, 38)
        Me.CartonAtStop1.Name = "CartonAtStop1"
        Me.CartonAtStop1.Size = New System.Drawing.Size(196, 25)
        Me.CartonAtStop1.State = False
        Me.CartonAtStop1.StatusText = Nothing
        Me.CartonAtStop1.TabIndex = 369
        Me.CartonAtStop1.Text = "Carton At Stopper 1"
        Me.CartonAtStop1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CartonAtStop2A
        '
        Me.CartonAtStop2A.BackColor = System.Drawing.SystemColors.Control
        Me.CartonAtStop2A.BackColorOn = System.Drawing.Color.Lime
        Me.CartonAtStop2A.Data = 0
        Me.CartonAtStop2A.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.CartonAtStop2A.ForeColor = System.Drawing.Color.Black
        Me.CartonAtStop2A.ForeColorOn = System.Drawing.Color.Black
        Me.CartonAtStop2A.Location = New System.Drawing.Point(315, 63)
        Me.CartonAtStop2A.Name = "CartonAtStop2A"
        Me.CartonAtStop2A.Size = New System.Drawing.Size(196, 25)
        Me.CartonAtStop2A.State = False
        Me.CartonAtStop2A.StatusText = Nothing
        Me.CartonAtStop2A.TabIndex = 369
        Me.CartonAtStop2A.Text = "Carton At Stopper 2 A"
        Me.CartonAtStop2A.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CartonAtStop2B
        '
        Me.CartonAtStop2B.BackColor = System.Drawing.SystemColors.Control
        Me.CartonAtStop2B.BackColorOn = System.Drawing.Color.Lime
        Me.CartonAtStop2B.Data = 0
        Me.CartonAtStop2B.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.CartonAtStop2B.ForeColor = System.Drawing.Color.Black
        Me.CartonAtStop2B.ForeColorOn = System.Drawing.Color.Black
        Me.CartonAtStop2B.Location = New System.Drawing.Point(315, 88)
        Me.CartonAtStop2B.Name = "CartonAtStop2B"
        Me.CartonAtStop2B.Size = New System.Drawing.Size(196, 25)
        Me.CartonAtStop2B.State = False
        Me.CartonAtStop2B.StatusText = Nothing
        Me.CartonAtStop2B.TabIndex = 369
        Me.CartonAtStop2B.Text = "Carton At Stopper 2 B"
        Me.CartonAtStop2B.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Stop1UpA
        '
        Me.Stop1UpA.BackColor = System.Drawing.SystemColors.Control
        Me.Stop1UpA.BackColorOn = System.Drawing.Color.Lime
        Me.Stop1UpA.Data = 0
        Me.Stop1UpA.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Stop1UpA.ForeColor = System.Drawing.Color.Black
        Me.Stop1UpA.ForeColorOn = System.Drawing.Color.Black
        Me.Stop1UpA.Location = New System.Drawing.Point(315, 114)
        Me.Stop1UpA.Name = "Stop1UpA"
        Me.Stop1UpA.Size = New System.Drawing.Size(196, 25)
        Me.Stop1UpA.State = False
        Me.Stop1UpA.StatusText = Nothing
        Me.Stop1UpA.TabIndex = 369
        Me.Stop1UpA.Text = "Stopper 1 Up A"
        Me.Stop1UpA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Stop1UpB
        '
        Me.Stop1UpB.BackColor = System.Drawing.SystemColors.Control
        Me.Stop1UpB.BackColorOn = System.Drawing.Color.Lime
        Me.Stop1UpB.Data = 0
        Me.Stop1UpB.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Stop1UpB.ForeColor = System.Drawing.Color.Black
        Me.Stop1UpB.ForeColorOn = System.Drawing.Color.Black
        Me.Stop1UpB.Location = New System.Drawing.Point(315, 139)
        Me.Stop1UpB.Name = "Stop1UpB"
        Me.Stop1UpB.Size = New System.Drawing.Size(196, 25)
        Me.Stop1UpB.State = False
        Me.Stop1UpB.StatusText = Nothing
        Me.Stop1UpB.TabIndex = 369
        Me.Stop1UpB.Text = "Stopper 1 Up B"
        Me.Stop1UpB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Stop1DownA
        '
        Me.Stop1DownA.BackColor = System.Drawing.SystemColors.Control
        Me.Stop1DownA.BackColorOn = System.Drawing.Color.Lime
        Me.Stop1DownA.Data = 0
        Me.Stop1DownA.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Stop1DownA.ForeColor = System.Drawing.Color.Black
        Me.Stop1DownA.ForeColorOn = System.Drawing.Color.Black
        Me.Stop1DownA.Location = New System.Drawing.Point(315, 164)
        Me.Stop1DownA.Name = "Stop1DownA"
        Me.Stop1DownA.Size = New System.Drawing.Size(196, 25)
        Me.Stop1DownA.State = False
        Me.Stop1DownA.StatusText = Nothing
        Me.Stop1DownA.TabIndex = 369
        Me.Stop1DownA.Text = "Stopper 1 Down A"
        Me.Stop1DownA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Stop1DownB
        '
        Me.Stop1DownB.BackColor = System.Drawing.SystemColors.Control
        Me.Stop1DownB.BackColorOn = System.Drawing.Color.Lime
        Me.Stop1DownB.Data = 0
        Me.Stop1DownB.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Stop1DownB.ForeColor = System.Drawing.Color.Black
        Me.Stop1DownB.ForeColorOn = System.Drawing.Color.Black
        Me.Stop1DownB.Location = New System.Drawing.Point(315, 189)
        Me.Stop1DownB.Name = "Stop1DownB"
        Me.Stop1DownB.Size = New System.Drawing.Size(196, 25)
        Me.Stop1DownB.State = False
        Me.Stop1DownB.StatusText = Nothing
        Me.Stop1DownB.TabIndex = 369
        Me.Stop1DownB.Text = "Stopper 1 Down B"
        Me.Stop1DownB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Stop2UpA
        '
        Me.Stop2UpA.BackColor = System.Drawing.SystemColors.Control
        Me.Stop2UpA.BackColorOn = System.Drawing.Color.Lime
        Me.Stop2UpA.Data = 0
        Me.Stop2UpA.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Stop2UpA.ForeColor = System.Drawing.Color.Black
        Me.Stop2UpA.ForeColorOn = System.Drawing.Color.Black
        Me.Stop2UpA.Location = New System.Drawing.Point(315, 214)
        Me.Stop2UpA.Name = "Stop2UpA"
        Me.Stop2UpA.Size = New System.Drawing.Size(196, 25)
        Me.Stop2UpA.State = False
        Me.Stop2UpA.StatusText = Nothing
        Me.Stop2UpA.TabIndex = 369
        Me.Stop2UpA.Text = "Stopper 2 Up A"
        Me.Stop2UpA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Stop2UpB
        '
        Me.Stop2UpB.BackColor = System.Drawing.SystemColors.Control
        Me.Stop2UpB.BackColorOn = System.Drawing.Color.Lime
        Me.Stop2UpB.Data = 0
        Me.Stop2UpB.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Stop2UpB.ForeColor = System.Drawing.Color.Black
        Me.Stop2UpB.ForeColorOn = System.Drawing.Color.Black
        Me.Stop2UpB.Location = New System.Drawing.Point(315, 239)
        Me.Stop2UpB.Name = "Stop2UpB"
        Me.Stop2UpB.Size = New System.Drawing.Size(196, 25)
        Me.Stop2UpB.State = False
        Me.Stop2UpB.StatusText = Nothing
        Me.Stop2UpB.TabIndex = 369
        Me.Stop2UpB.Text = "Stopper 2 Up B"
        Me.Stop2UpB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Stop2DownA
        '
        Me.Stop2DownA.BackColor = System.Drawing.SystemColors.Control
        Me.Stop2DownA.BackColorOn = System.Drawing.Color.Lime
        Me.Stop2DownA.Data = 0
        Me.Stop2DownA.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Stop2DownA.ForeColor = System.Drawing.Color.Black
        Me.Stop2DownA.ForeColorOn = System.Drawing.Color.Black
        Me.Stop2DownA.Location = New System.Drawing.Point(315, 264)
        Me.Stop2DownA.Name = "Stop2DownA"
        Me.Stop2DownA.Size = New System.Drawing.Size(196, 25)
        Me.Stop2DownA.State = False
        Me.Stop2DownA.StatusText = Nothing
        Me.Stop2DownA.TabIndex = 369
        Me.Stop2DownA.Text = "Stopper 2 Down A"
        Me.Stop2DownA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Stop2DownB
        '
        Me.Stop2DownB.BackColor = System.Drawing.SystemColors.Control
        Me.Stop2DownB.BackColorOn = System.Drawing.Color.Lime
        Me.Stop2DownB.Data = 0
        Me.Stop2DownB.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Stop2DownB.ForeColor = System.Drawing.Color.Black
        Me.Stop2DownB.ForeColorOn = System.Drawing.Color.Black
        Me.Stop2DownB.Location = New System.Drawing.Point(315, 289)
        Me.Stop2DownB.Name = "Stop2DownB"
        Me.Stop2DownB.Size = New System.Drawing.Size(196, 25)
        Me.Stop2DownB.State = False
        Me.Stop2DownB.StatusText = Nothing
        Me.Stop2DownB.TabIndex = 369
        Me.Stop2DownB.Text = "Stopper 2 Down B"
        Me.Stop2DownB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CartonInPockA
        '
        Me.CartonInPockA.BackColor = System.Drawing.SystemColors.Control
        Me.CartonInPockA.BackColorOn = System.Drawing.Color.Lime
        Me.CartonInPockA.Data = 0
        Me.CartonInPockA.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.CartonInPockA.ForeColor = System.Drawing.Color.Black
        Me.CartonInPockA.ForeColorOn = System.Drawing.Color.Black
        Me.CartonInPockA.Location = New System.Drawing.Point(315, 314)
        Me.CartonInPockA.Name = "CartonInPockA"
        Me.CartonInPockA.Size = New System.Drawing.Size(196, 25)
        Me.CartonInPockA.State = False
        Me.CartonInPockA.StatusText = Nothing
        Me.CartonInPockA.TabIndex = 369
        Me.CartonInPockA.Text = "Carton In Pocket A"
        Me.CartonInPockA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CartonInPockB
        '
        Me.CartonInPockB.BackColor = System.Drawing.SystemColors.Control
        Me.CartonInPockB.BackColorOn = System.Drawing.Color.Lime
        Me.CartonInPockB.Data = 0
        Me.CartonInPockB.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.CartonInPockB.ForeColor = System.Drawing.Color.Black
        Me.CartonInPockB.ForeColorOn = System.Drawing.Color.Black
        Me.CartonInPockB.Location = New System.Drawing.Point(315, 339)
        Me.CartonInPockB.Name = "CartonInPockB"
        Me.CartonInPockB.Size = New System.Drawing.Size(196, 25)
        Me.CartonInPockB.State = False
        Me.CartonInPockB.StatusText = Nothing
        Me.CartonInPockB.TabIndex = 369
        Me.CartonInPockB.Text = "Carton In Pocket B"
        Me.CartonInPockB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TIB_ProdFree
        '
        Me.TIB_ProdFree.BackColor = System.Drawing.SystemColors.Control
        Me.TIB_ProdFree.BackColorOn = System.Drawing.Color.Lime
        Me.TIB_ProdFree.Data = 0
        Me.TIB_ProdFree.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TIB_ProdFree.ForeColor = System.Drawing.Color.Black
        Me.TIB_ProdFree.ForeColorOn = System.Drawing.Color.Black
        Me.TIB_ProdFree.Location = New System.Drawing.Point(585, 38)
        Me.TIB_ProdFree.Name = "TIB_ProdFree"
        Me.TIB_ProdFree.Size = New System.Drawing.Size(212, 25)
        Me.TIB_ProdFree.State = False
        Me.TIB_ProdFree.StatusText = Nothing
        Me.TIB_ProdFree.TabIndex = 369
        Me.TIB_ProdFree.Text = "TIB Product Free"
        Me.TIB_ProdFree.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TIB_ProdSens1
        '
        Me.TIB_ProdSens1.BackColor = System.Drawing.SystemColors.Control
        Me.TIB_ProdSens1.BackColorOn = System.Drawing.Color.Lime
        Me.TIB_ProdSens1.Data = 0
        Me.TIB_ProdSens1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TIB_ProdSens1.ForeColor = System.Drawing.Color.Black
        Me.TIB_ProdSens1.ForeColorOn = System.Drawing.Color.Black
        Me.TIB_ProdSens1.Location = New System.Drawing.Point(585, 63)
        Me.TIB_ProdSens1.Name = "TIB_ProdSens1"
        Me.TIB_ProdSens1.Size = New System.Drawing.Size(212, 25)
        Me.TIB_ProdSens1.State = False
        Me.TIB_ProdSens1.StatusText = Nothing
        Me.TIB_ProdSens1.TabIndex = 369
        Me.TIB_ProdSens1.Text = "TIB Product Sensor 1"
        Me.TIB_ProdSens1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TIB_ProdSens2
        '
        Me.TIB_ProdSens2.BackColor = System.Drawing.SystemColors.Control
        Me.TIB_ProdSens2.BackColorOn = System.Drawing.Color.Lime
        Me.TIB_ProdSens2.Data = 0
        Me.TIB_ProdSens2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TIB_ProdSens2.ForeColor = System.Drawing.Color.Black
        Me.TIB_ProdSens2.ForeColorOn = System.Drawing.Color.Black
        Me.TIB_ProdSens2.Location = New System.Drawing.Point(585, 87)
        Me.TIB_ProdSens2.Name = "TIB_ProdSens2"
        Me.TIB_ProdSens2.Size = New System.Drawing.Size(212, 25)
        Me.TIB_ProdSens2.State = False
        Me.TIB_ProdSens2.StatusText = Nothing
        Me.TIB_ProdSens2.TabIndex = 369
        Me.TIB_ProdSens2.Text = "TIB Product Sensor 2"
        Me.TIB_ProdSens2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TIB_ProdSens3
        '
        Me.TIB_ProdSens3.BackColor = System.Drawing.SystemColors.Control
        Me.TIB_ProdSens3.BackColorOn = System.Drawing.Color.Lime
        Me.TIB_ProdSens3.Data = 0
        Me.TIB_ProdSens3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TIB_ProdSens3.ForeColor = System.Drawing.Color.Black
        Me.TIB_ProdSens3.ForeColorOn = System.Drawing.Color.Black
        Me.TIB_ProdSens3.Location = New System.Drawing.Point(585, 112)
        Me.TIB_ProdSens3.Name = "TIB_ProdSens3"
        Me.TIB_ProdSens3.Size = New System.Drawing.Size(212, 25)
        Me.TIB_ProdSens3.State = False
        Me.TIB_ProdSens3.StatusText = Nothing
        Me.TIB_ProdSens3.TabIndex = 369
        Me.TIB_ProdSens3.Text = "TIB Product Sensor 3"
        Me.TIB_ProdSens3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TIB_ProdSens4
        '
        Me.TIB_ProdSens4.BackColor = System.Drawing.SystemColors.Control
        Me.TIB_ProdSens4.BackColorOn = System.Drawing.Color.Lime
        Me.TIB_ProdSens4.Data = 0
        Me.TIB_ProdSens4.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TIB_ProdSens4.ForeColor = System.Drawing.Color.Black
        Me.TIB_ProdSens4.ForeColorOn = System.Drawing.Color.Black
        Me.TIB_ProdSens4.Location = New System.Drawing.Point(585, 138)
        Me.TIB_ProdSens4.Name = "TIB_ProdSens4"
        Me.TIB_ProdSens4.Size = New System.Drawing.Size(212, 25)
        Me.TIB_ProdSens4.State = False
        Me.TIB_ProdSens4.StatusText = Nothing
        Me.TIB_ProdSens4.TabIndex = 369
        Me.TIB_ProdSens4.Text = "TIB Product Sensor 4"
        Me.TIB_ProdSens4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TIB_ProdSens5
        '
        Me.TIB_ProdSens5.BackColor = System.Drawing.SystemColors.Control
        Me.TIB_ProdSens5.BackColorOn = System.Drawing.Color.Lime
        Me.TIB_ProdSens5.Data = 0
        Me.TIB_ProdSens5.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TIB_ProdSens5.ForeColor = System.Drawing.Color.Black
        Me.TIB_ProdSens5.ForeColorOn = System.Drawing.Color.Black
        Me.TIB_ProdSens5.Location = New System.Drawing.Point(585, 162)
        Me.TIB_ProdSens5.Name = "TIB_ProdSens5"
        Me.TIB_ProdSens5.Size = New System.Drawing.Size(212, 25)
        Me.TIB_ProdSens5.State = False
        Me.TIB_ProdSens5.StatusText = Nothing
        Me.TIB_ProdSens5.TabIndex = 369
        Me.TIB_ProdSens5.Text = "TIB Product Sensor 5"
        Me.TIB_ProdSens5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TIB_ProdSens6
        '
        Me.TIB_ProdSens6.BackColor = System.Drawing.SystemColors.Control
        Me.TIB_ProdSens6.BackColorOn = System.Drawing.Color.Lime
        Me.TIB_ProdSens6.Data = 0
        Me.TIB_ProdSens6.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TIB_ProdSens6.ForeColor = System.Drawing.Color.Black
        Me.TIB_ProdSens6.ForeColorOn = System.Drawing.Color.Black
        Me.TIB_ProdSens6.Location = New System.Drawing.Point(585, 189)
        Me.TIB_ProdSens6.Name = "TIB_ProdSens6"
        Me.TIB_ProdSens6.Size = New System.Drawing.Size(212, 25)
        Me.TIB_ProdSens6.State = False
        Me.TIB_ProdSens6.StatusText = Nothing
        Me.TIB_ProdSens6.TabIndex = 369
        Me.TIB_ProdSens6.Text = "TIB Product Sensor 6 (Jam)"
        Me.TIB_ProdSens6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TIB_StopperUp
        '
        Me.TIB_StopperUp.BackColor = System.Drawing.SystemColors.Control
        Me.TIB_StopperUp.BackColorOn = System.Drawing.Color.Lime
        Me.TIB_StopperUp.Data = 0
        Me.TIB_StopperUp.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TIB_StopperUp.ForeColor = System.Drawing.Color.Black
        Me.TIB_StopperUp.ForeColorOn = System.Drawing.Color.Black
        Me.TIB_StopperUp.Location = New System.Drawing.Point(585, 212)
        Me.TIB_StopperUp.Name = "TIB_StopperUp"
        Me.TIB_StopperUp.Size = New System.Drawing.Size(212, 25)
        Me.TIB_StopperUp.State = False
        Me.TIB_StopperUp.StatusText = Nothing
        Me.TIB_StopperUp.TabIndex = 369
        Me.TIB_StopperUp.Text = "Stopper Up"
        Me.TIB_StopperUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TIB_StopperDown
        '
        Me.TIB_StopperDown.BackColor = System.Drawing.SystemColors.Control
        Me.TIB_StopperDown.BackColorOn = System.Drawing.Color.Lime
        Me.TIB_StopperDown.Data = 0
        Me.TIB_StopperDown.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TIB_StopperDown.ForeColor = System.Drawing.Color.Black
        Me.TIB_StopperDown.ForeColorOn = System.Drawing.Color.Black
        Me.TIB_StopperDown.Location = New System.Drawing.Point(585, 236)
        Me.TIB_StopperDown.Name = "TIB_StopperDown"
        Me.TIB_StopperDown.Size = New System.Drawing.Size(212, 25)
        Me.TIB_StopperDown.State = False
        Me.TIB_StopperDown.StatusText = Nothing
        Me.TIB_StopperDown.TabIndex = 369
        Me.TIB_StopperDown.Text = "Stopper Down"
        Me.TIB_StopperDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IO_Zipper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnToggleText)
        Me.Controls.Add(Me.TelBeltIn)
        Me.Controls.Add(Me.TelLimitSwitch)
        Me.Controls.Add(Me.TelHomingSensor)
        Me.Controls.Add(Me.UpperInfIsDown)
        Me.Controls.Add(Me.UpperInfIsUp)
        Me.Controls.Add(Me.UpperInfHomSensB)
        Me.Controls.Add(Me.UpperInfHomSensA)
        Me.Controls.Add(Me.ZipperHighProduct)
        Me.Controls.Add(Me.Stop1UpB)
        Me.Controls.Add(Me.Stop1DownB)
        Me.Controls.Add(Me.CartonInPockB)
        Me.Controls.Add(Me.CartonInPockA)
        Me.Controls.Add(Me.Stop2DownB)
        Me.Controls.Add(Me.Stop2DownA)
        Me.Controls.Add(Me.Stop1DownA)
        Me.Controls.Add(Me.Stop2UpB)
        Me.Controls.Add(Me.Stop2UpA)
        Me.Controls.Add(Me.Stop1UpA)
        Me.Controls.Add(Me.CartonAtStop2B)
        Me.Controls.Add(Me.CartonAtStop2A)
        Me.Controls.Add(Me.TIB_StopperDown)
        Me.Controls.Add(Me.TIB_StopperUp)
        Me.Controls.Add(Me.TIB_ProdSens6)
        Me.Controls.Add(Me.TIB_ProdSens5)
        Me.Controls.Add(Me.TIB_ProdSens4)
        Me.Controls.Add(Me.TIB_ProdSens3)
        Me.Controls.Add(Me.TIB_ProdSens2)
        Me.Controls.Add(Me.TIB_ProdSens1)
        Me.Controls.Add(Me.TIB_ProdFree)
        Me.Controls.Add(Me.CartonAtStop1)
        Me.Controls.Add(Me.ZipperHomingSensor)
        Me.Controls.Add(Me.plTIBProdFree)
        Me.Controls.Add(Me.plTIBProd5)
        Me.Controls.Add(Me.plUpperInfeedIsDown)
        Me.Controls.Add(Me.plUpperInfeedIsUp)
        Me.Controls.Add(Me.plCartonInPocketB)
        Me.Controls.Add(Me.plCartonInPocketA)
        Me.Controls.Add(Me.plTelBeltIsIn)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.plTelLimit)
        Me.Controls.Add(Me.plTelHome)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.plTIBStopperDown)
        Me.Controls.Add(Me.plTIBStopperUp)
        Me.Controls.Add(Me.plTIBProd4)
        Me.Controls.Add(Me.plTIBProd3)
        Me.Controls.Add(Me.plTIBProd2)
        Me.Controls.Add(Me.plTIBProd1)
        Me.Controls.Add(Me.plTIBProd6)
        Me.Controls.Add(Me.plUppInfHoming_B)
        Me.Controls.Add(Me.plUppInfHoming_A)
        Me.Controls.Add(Me.plStopper2Down_B)
        Me.Controls.Add(Me.plStopper2Down_A)
        Me.Controls.Add(Me.plStopper2Up_B)
        Me.Controls.Add(Me.plStopper2Up_A)
        Me.Controls.Add(Me.plStopper1Down_B)
        Me.Controls.Add(Me.plStopper1Down_A)
        Me.Controls.Add(Me.plStopper1Up_B)
        Me.Controls.Add(Me.plStopper1Up_A)
        Me.Controls.Add(Me.plCartonAtStopper2_B)
        Me.Controls.Add(Me.plCartonAtStopper2_A)
        Me.Controls.Add(Me.plCartonAtStopper1)
        Me.Controls.Add(Me.plZipperHighProduct)
        Me.Controls.Add(Me.plZipper_Home)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Name = "IO_Zipper"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "541"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents plZipper_Home As KremerControlsWin32.KremerLight
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents plZipperHighProduct As KremerControlsWin32.KremerLight
    Friend WithEvents plCartonAtStopper1 As KremerControlsWin32.KremerLight
    Friend WithEvents plCartonAtStopper2_A As KremerControlsWin32.KremerLight
    Friend WithEvents plCartonAtStopper2_B As KremerControlsWin32.KremerLight
    Friend WithEvents plStopper1Up_A As KremerControlsWin32.KremerLight
    Friend WithEvents plStopper1Up_B As KremerControlsWin32.KremerLight
    Friend WithEvents plStopper1Down_B As KremerControlsWin32.KremerLight
    Friend WithEvents plStopper1Down_A As KremerControlsWin32.KremerLight
    Friend WithEvents plStopper2Down_B As KremerControlsWin32.KremerLight
    Friend WithEvents plStopper2Down_A As KremerControlsWin32.KremerLight
    Friend WithEvents plStopper2Up_B As KremerControlsWin32.KremerLight
    Friend WithEvents plStopper2Up_A As KremerControlsWin32.KremerLight
    Friend WithEvents plUppInfHoming_A As KremerControlsWin32.KremerLight
    Friend WithEvents plUppInfHoming_B As KremerControlsWin32.KremerLight
    Friend WithEvents plTIBProd4 As KremerControlsWin32.KremerLight
    Friend WithEvents plTIBProd3 As KremerControlsWin32.KremerLight
    Friend WithEvents plTIBProd2 As KremerControlsWin32.KremerLight
    Friend WithEvents plTIBProd1 As KremerControlsWin32.KremerLight
    Friend WithEvents plTIBProd6 As KremerControlsWin32.KremerLight
    Friend WithEvents plTIBStopperDown As KremerControlsWin32.KremerLight
    Friend WithEvents plTIBStopperUp As KremerControlsWin32.KremerLight
    Friend WithEvents ZipperHome As KremerControlsWin32.KremerVariable
    Friend WithEvents ZipperHigh As KremerControlsWin32.KremerVariable
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents UpperHomeA As KremerControlsWin32.KremerVariable
    Friend WithEvents UpperHomeB As KremerControlsWin32.KremerVariable
    Friend WithEvents CartonsAtStopper1 As KremerControlsWin32.KremerVariable
    Friend WithEvents CartonAtStopper2A As KremerControlsWin32.KremerVariable
    Friend WithEvents CartonAtStopper2B As KremerControlsWin32.KremerVariable
    Friend WithEvents Stopper1UpA As KremerControlsWin32.KremerVariable
    Friend WithEvents Stopper1UpB As KremerControlsWin32.KremerVariable
    Friend WithEvents Stopper1DownA As KremerControlsWin32.KremerVariable
    Friend WithEvents Stopper1DownB As KremerControlsWin32.KremerVariable
    Friend WithEvents Stopper2UpA As KremerControlsWin32.KremerVariable
    Friend WithEvents Stopper2UpB As KremerControlsWin32.KremerVariable
    Friend WithEvents Stopper2DownA As KremerControlsWin32.KremerVariable
    Friend WithEvents Stopper2DownB As KremerControlsWin32.KremerVariable
    Friend WithEvents TIBProd1 As KremerControlsWin32.KremerVariable
    Friend WithEvents TIBProd2 As KremerControlsWin32.KremerVariable
    Friend WithEvents TIBProd3 As KremerControlsWin32.KremerVariable
    Friend WithEvents TIBProd4 As KremerControlsWin32.KremerVariable
    Friend WithEvents TIBProd5 As KremerControlsWin32.KremerVariable
    Friend WithEvents TIBStopperUp As KremerControlsWin32.KremerVariable
    Friend WithEvents TIBStopperDown As KremerControlsWin32.KremerVariable
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents plTelLimit As KremerControlsWin32.KremerLight
    Friend WithEvents plTelHome As KremerControlsWin32.KremerLight
    Friend WithEvents plTelBeltIsIn As KremerControlsWin32.KremerLight
    Friend WithEvents TelixHome As KremerControlsWin32.KremerVariable
    Friend WithEvents TelixLimit As KremerControlsWin32.KremerVariable
    Friend WithEvents TelixBeltIsIn As KremerControlsWin32.KremerVariable
    Friend WithEvents plCartonInPocketB As KremerControlsWin32.KremerLight
    Friend WithEvents plCartonInPocketA As KremerControlsWin32.KremerLight
    Friend WithEvents CartonInPocketA As KremerControlsWin32.KremerVariable
    Friend WithEvents CartonInPocketB As KremerControlsWin32.KremerVariable
    Friend WithEvents UpperInfeedIsUp As KremerControlsWin32.KremerVariable
    Friend WithEvents plUpperInfeedIsUp As KremerControlsWin32.KremerLight
    Friend WithEvents UpperInfeedIsDown As KremerControlsWin32.KremerVariable
    Friend WithEvents plUpperInfeedIsDown As KremerControlsWin32.KremerLight
    Friend WithEvents plTIBProd5 As KremerControlsWin32.KremerLight
    Friend WithEvents TIBProd6 As KremerControlsWin32.KremerVariable
    Friend WithEvents TIBProductFree As KremerControlsWin32.KremerVariable
    Friend WithEvents plTIBProdFree As KremerControlsWin32.KremerLight
    Friend WithEvents ZipperHomingSensor As KremerControlsWin32.KremerStatusBox
    Friend WithEvents ZipperHighProduct As KremerControlsWin32.KremerStatusBox
    Friend WithEvents btnToggleText As KremerControlsWin32.KremerButton
    Friend WithEvents UpperInfHomSensA As KremerControlsWin32.KremerStatusBox
    Friend WithEvents UpperInfHomSensB As KremerControlsWin32.KremerStatusBox
    Friend WithEvents UpperInfIsUp As KremerControlsWin32.KremerStatusBox
    Friend WithEvents UpperInfIsDown As KremerControlsWin32.KremerStatusBox
    Friend WithEvents TelHomingSensor As KremerControlsWin32.KremerStatusBox
    Friend WithEvents TelLimitSwitch As KremerControlsWin32.KremerStatusBox
    Friend WithEvents TelBeltIn As KremerControlsWin32.KremerStatusBox
    Friend WithEvents CartonAtStop1 As KremerControlsWin32.KremerStatusBox
    Friend WithEvents CartonAtStop2A As KremerControlsWin32.KremerStatusBox
    Friend WithEvents CartonAtStop2B As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Stop1UpA As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Stop1UpB As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Stop1DownA As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Stop1DownB As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Stop2UpA As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Stop2UpB As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Stop2DownA As KremerControlsWin32.KremerStatusBox
    Friend WithEvents Stop2DownB As KremerControlsWin32.KremerStatusBox
    Friend WithEvents CartonInPockA As KremerControlsWin32.KremerStatusBox
    Friend WithEvents CartonInPockB As KremerControlsWin32.KremerStatusBox
    Friend WithEvents TIB_ProdFree As KremerControlsWin32.KremerStatusBox
    Friend WithEvents TIB_ProdSens1 As KremerControlsWin32.KremerStatusBox
    Friend WithEvents TIB_ProdSens2 As KremerControlsWin32.KremerStatusBox
    Friend WithEvents TIB_ProdSens3 As KremerControlsWin32.KremerStatusBox
    Friend WithEvents TIB_ProdSens4 As KremerControlsWin32.KremerStatusBox
    Friend WithEvents TIB_ProdSens5 As KremerControlsWin32.KremerStatusBox
    Friend WithEvents TIB_ProdSens6 As KremerControlsWin32.KremerStatusBox
    Friend WithEvents TIB_StopperUp As KremerControlsWin32.KremerStatusBox
    Friend WithEvents TIB_StopperDown As KremerControlsWin32.KremerStatusBox

End Class
