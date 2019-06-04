<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CT_BundleAutomation
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
        Me.FingerInfeedOpen = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioFingerInfeedOpen = New KremerControlsWin32.KremerIoField(Me.components)
        Me.FingerInfeedClose = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioFingerInfeedClose = New KremerControlsWin32.KremerIoField(Me.components)
        Me.FingerOutfeedOpen = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioFingerOutfeedOpen = New KremerControlsWin32.KremerIoField(Me.components)
        Me.FingerOutfeedClose = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioFingerOutfeedClose = New KremerControlsWin32.KremerIoField(Me.components)
        Me.DoorInfeedOpen = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioDoorInfeedOpen = New KremerControlsWin32.KremerIoField(Me.components)
        Me.DoorInfeedClose = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioDoorInfeedClose = New KremerControlsWin32.KremerIoField(Me.components)
        Me.DoorOutfeedOpen = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioDoorOutfeedOpen = New KremerControlsWin32.KremerIoField(Me.components)
        Me.DoorOutfeedClose = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioDoorOutfeedClose = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Btn_Overview = New KremerControlsWin32.KremerButton
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.FingerInfeedOpen)
        Me.VarCollector.Variables.Add(Me.FingerInfeedClose)
        Me.VarCollector.Variables.Add(Me.FingerOutfeedOpen)
        Me.VarCollector.Variables.Add(Me.FingerOutfeedClose)
        Me.VarCollector.Variables.Add(Me.DoorInfeedOpen)
        Me.VarCollector.Variables.Add(Me.DoorInfeedClose)
        Me.VarCollector.Variables.Add(Me.DoorOutfeedOpen)
        Me.VarCollector.Variables.Add(Me.DoorOutfeedClose)
        '
        'FingerInfeedOpen
        '
        Me.FingerInfeedOpen.BindControl = Me.ioFingerInfeedOpen
        Me.FingerInfeedOpen.BindProperty = "Data"
        Me.FingerInfeedOpen.Data = Nothing
        Me.FingerInfeedOpen.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.FingerInfeedOpen.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FingerInfeedOpen.VariableName = "InlineAutomation.Inline.Zipper.BundleAutomation.Gripper.FingerLeft.Check.LastTime" & _
            "_Cil_In"
        '
        'ioFingerInfeedOpen
        '
        Me.ioFingerInfeedOpen.Audit = Nothing
        Me.ioFingerInfeedOpen.AuditEnabled = False
        Me.ioFingerInfeedOpen.AuditMessage = "KremerIoField changed:"
        Me.ioFingerInfeedOpen.AuditSource = "KremerIoField"
        Me.ioFingerInfeedOpen.AutoSize = True
        Me.ioFingerInfeedOpen.Data = 0
        Me.ioFingerInfeedOpen.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioFingerInfeedOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioFingerInfeedOpen.InitialValue = True
        Me.ioFingerInfeedOpen.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioFingerInfeedOpen.Location = New System.Drawing.Point(254, 45)
        Me.ioFingerInfeedOpen.LowerBound = 0
        Me.ioFingerInfeedOpen.Name = "ioFingerInfeedOpen"
        Me.ioFingerInfeedOpen.OutputFormat = "0 ms"
        Me.ioFingerInfeedOpen.Size = New System.Drawing.Size(41, 18)
        Me.ioFingerInfeedOpen.TabIndex = 402
        Me.ioFingerInfeedOpen.Text = "0 ms"
        Me.ioFingerInfeedOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioFingerInfeedOpen.UpperBound = 1000
        Me.ioFingerInfeedOpen.UserInfo = Nothing
        Me.ioFingerInfeedOpen.UserLevel = 0
        '
        'FingerInfeedClose
        '
        Me.FingerInfeedClose.BindControl = Me.ioFingerInfeedClose
        Me.FingerInfeedClose.BindProperty = "Data"
        Me.FingerInfeedClose.Data = Nothing
        Me.FingerInfeedClose.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.FingerInfeedClose.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FingerInfeedClose.VariableName = "InlineAutomation.Inline.Zipper.BundleAutomation.Gripper.FingerLeft.Check.LastTime" & _
            "_Cil_Out"
        '
        'ioFingerInfeedClose
        '
        Me.ioFingerInfeedClose.Audit = Nothing
        Me.ioFingerInfeedClose.AuditEnabled = False
        Me.ioFingerInfeedClose.AuditMessage = "KremerIoField changed:"
        Me.ioFingerInfeedClose.AuditSource = "KremerIoField"
        Me.ioFingerInfeedClose.AutoSize = True
        Me.ioFingerInfeedClose.Data = 0
        Me.ioFingerInfeedClose.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioFingerInfeedClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioFingerInfeedClose.InitialValue = True
        Me.ioFingerInfeedClose.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioFingerInfeedClose.Location = New System.Drawing.Point(254, 70)
        Me.ioFingerInfeedClose.LowerBound = 0
        Me.ioFingerInfeedClose.Name = "ioFingerInfeedClose"
        Me.ioFingerInfeedClose.OutputFormat = "0 ms"
        Me.ioFingerInfeedClose.Size = New System.Drawing.Size(41, 18)
        Me.ioFingerInfeedClose.TabIndex = 403
        Me.ioFingerInfeedClose.Text = "0 ms"
        Me.ioFingerInfeedClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioFingerInfeedClose.UpperBound = 1000
        Me.ioFingerInfeedClose.UserInfo = Nothing
        Me.ioFingerInfeedClose.UserLevel = 0
        '
        'FingerOutfeedOpen
        '
        Me.FingerOutfeedOpen.BindControl = Me.ioFingerOutfeedOpen
        Me.FingerOutfeedOpen.BindProperty = "Data"
        Me.FingerOutfeedOpen.Data = Nothing
        Me.FingerOutfeedOpen.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.FingerOutfeedOpen.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FingerOutfeedOpen.VariableName = "InlineAutomation.Inline.Zipper.BundleAutomation.Gripper.FingerRight.Check.LastTim" & _
            "e_Cil_In"
        '
        'ioFingerOutfeedOpen
        '
        Me.ioFingerOutfeedOpen.Audit = Nothing
        Me.ioFingerOutfeedOpen.AuditEnabled = False
        Me.ioFingerOutfeedOpen.AuditMessage = "KremerIoField changed:"
        Me.ioFingerOutfeedOpen.AuditSource = "KremerIoField"
        Me.ioFingerOutfeedOpen.AutoSize = True
        Me.ioFingerOutfeedOpen.Data = 0
        Me.ioFingerOutfeedOpen.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioFingerOutfeedOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioFingerOutfeedOpen.InitialValue = True
        Me.ioFingerOutfeedOpen.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioFingerOutfeedOpen.Location = New System.Drawing.Point(254, 95)
        Me.ioFingerOutfeedOpen.LowerBound = 0
        Me.ioFingerOutfeedOpen.Name = "ioFingerOutfeedOpen"
        Me.ioFingerOutfeedOpen.OutputFormat = "0 ms"
        Me.ioFingerOutfeedOpen.Size = New System.Drawing.Size(41, 18)
        Me.ioFingerOutfeedOpen.TabIndex = 404
        Me.ioFingerOutfeedOpen.Text = "0 ms"
        Me.ioFingerOutfeedOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioFingerOutfeedOpen.UpperBound = 1000
        Me.ioFingerOutfeedOpen.UserInfo = Nothing
        Me.ioFingerOutfeedOpen.UserLevel = 0
        '
        'FingerOutfeedClose
        '
        Me.FingerOutfeedClose.BindControl = Me.ioFingerOutfeedClose
        Me.FingerOutfeedClose.BindProperty = "Data"
        Me.FingerOutfeedClose.Data = Nothing
        Me.FingerOutfeedClose.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.FingerOutfeedClose.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FingerOutfeedClose.VariableName = "InlineAutomation.Inline.Zipper.BundleAutomation.Gripper.FingerRight.Check.LastTim" & _
            "e_Cil_Out"
        '
        'ioFingerOutfeedClose
        '
        Me.ioFingerOutfeedClose.Audit = Nothing
        Me.ioFingerOutfeedClose.AuditEnabled = False
        Me.ioFingerOutfeedClose.AuditMessage = "KremerIoField changed:"
        Me.ioFingerOutfeedClose.AuditSource = "KremerIoField"
        Me.ioFingerOutfeedClose.AutoSize = True
        Me.ioFingerOutfeedClose.Data = 0
        Me.ioFingerOutfeedClose.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioFingerOutfeedClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioFingerOutfeedClose.InitialValue = True
        Me.ioFingerOutfeedClose.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioFingerOutfeedClose.Location = New System.Drawing.Point(254, 120)
        Me.ioFingerOutfeedClose.LowerBound = 0
        Me.ioFingerOutfeedClose.Name = "ioFingerOutfeedClose"
        Me.ioFingerOutfeedClose.OutputFormat = "0 ms"
        Me.ioFingerOutfeedClose.Size = New System.Drawing.Size(41, 18)
        Me.ioFingerOutfeedClose.TabIndex = 405
        Me.ioFingerOutfeedClose.Text = "0 ms"
        Me.ioFingerOutfeedClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioFingerOutfeedClose.UpperBound = 1000
        Me.ioFingerOutfeedClose.UserInfo = Nothing
        Me.ioFingerOutfeedClose.UserLevel = 0
        '
        'DoorInfeedOpen
        '
        Me.DoorInfeedOpen.BindControl = Me.ioDoorInfeedOpen
        Me.DoorInfeedOpen.BindProperty = "Data"
        Me.DoorInfeedOpen.Data = Nothing
        Me.DoorInfeedOpen.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.DoorInfeedOpen.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.DoorInfeedOpen.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.BundleStorage.BackdoorSupport.Che" & _
            "ck.LastTime_Cil_In"
        '
        'ioDoorInfeedOpen
        '
        Me.ioDoorInfeedOpen.Audit = Nothing
        Me.ioDoorInfeedOpen.AuditEnabled = False
        Me.ioDoorInfeedOpen.AuditMessage = "KremerIoField changed:"
        Me.ioDoorInfeedOpen.AuditSource = "KremerIoField"
        Me.ioDoorInfeedOpen.AutoSize = True
        Me.ioDoorInfeedOpen.Data = 0
        Me.ioDoorInfeedOpen.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioDoorInfeedOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioDoorInfeedOpen.InitialValue = True
        Me.ioDoorInfeedOpen.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioDoorInfeedOpen.Location = New System.Drawing.Point(564, 45)
        Me.ioDoorInfeedOpen.LowerBound = 0
        Me.ioDoorInfeedOpen.Name = "ioDoorInfeedOpen"
        Me.ioDoorInfeedOpen.OutputFormat = "0 ms"
        Me.ioDoorInfeedOpen.Size = New System.Drawing.Size(41, 18)
        Me.ioDoorInfeedOpen.TabIndex = 406
        Me.ioDoorInfeedOpen.Text = "0 ms"
        Me.ioDoorInfeedOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioDoorInfeedOpen.UpperBound = 1000
        Me.ioDoorInfeedOpen.UserInfo = Nothing
        Me.ioDoorInfeedOpen.UserLevel = 0
        '
        'DoorInfeedClose
        '
        Me.DoorInfeedClose.BindControl = Me.ioDoorInfeedClose
        Me.DoorInfeedClose.BindProperty = "Data"
        Me.DoorInfeedClose.Data = Nothing
        Me.DoorInfeedClose.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.DoorInfeedClose.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.DoorInfeedClose.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.BundleStorage.BackdoorSupport.Che" & _
            "ck.LastTime_Cil_Out"
        '
        'ioDoorInfeedClose
        '
        Me.ioDoorInfeedClose.Audit = Nothing
        Me.ioDoorInfeedClose.AuditEnabled = False
        Me.ioDoorInfeedClose.AuditMessage = "KremerIoField changed:"
        Me.ioDoorInfeedClose.AuditSource = "KremerIoField"
        Me.ioDoorInfeedClose.AutoSize = True
        Me.ioDoorInfeedClose.Data = 0
        Me.ioDoorInfeedClose.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioDoorInfeedClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioDoorInfeedClose.InitialValue = True
        Me.ioDoorInfeedClose.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioDoorInfeedClose.Location = New System.Drawing.Point(564, 70)
        Me.ioDoorInfeedClose.LowerBound = 0
        Me.ioDoorInfeedClose.Name = "ioDoorInfeedClose"
        Me.ioDoorInfeedClose.OutputFormat = "0 ms"
        Me.ioDoorInfeedClose.Size = New System.Drawing.Size(41, 18)
        Me.ioDoorInfeedClose.TabIndex = 407
        Me.ioDoorInfeedClose.Text = "0 ms"
        Me.ioDoorInfeedClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioDoorInfeedClose.UpperBound = 1000
        Me.ioDoorInfeedClose.UserInfo = Nothing
        Me.ioDoorInfeedClose.UserLevel = 0
        '
        'DoorOutfeedOpen
        '
        Me.DoorOutfeedOpen.BindControl = Me.ioDoorOutfeedOpen
        Me.DoorOutfeedOpen.BindProperty = "Data"
        Me.DoorOutfeedOpen.Data = Nothing
        Me.DoorOutfeedOpen.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.DoorOutfeedOpen.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.DoorOutfeedOpen.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.BundleStorage.BackdoorSupportR.Ch" & _
            "eck.LastTime_Cil_In"
        '
        'ioDoorOutfeedOpen
        '
        Me.ioDoorOutfeedOpen.Audit = Nothing
        Me.ioDoorOutfeedOpen.AuditEnabled = False
        Me.ioDoorOutfeedOpen.AuditMessage = "KremerIoField changed:"
        Me.ioDoorOutfeedOpen.AuditSource = "KremerIoField"
        Me.ioDoorOutfeedOpen.AutoSize = True
        Me.ioDoorOutfeedOpen.Data = 0
        Me.ioDoorOutfeedOpen.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioDoorOutfeedOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioDoorOutfeedOpen.InitialValue = True
        Me.ioDoorOutfeedOpen.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioDoorOutfeedOpen.Location = New System.Drawing.Point(564, 95)
        Me.ioDoorOutfeedOpen.LowerBound = 0
        Me.ioDoorOutfeedOpen.Name = "ioDoorOutfeedOpen"
        Me.ioDoorOutfeedOpen.OutputFormat = "0 ms"
        Me.ioDoorOutfeedOpen.Size = New System.Drawing.Size(41, 18)
        Me.ioDoorOutfeedOpen.TabIndex = 408
        Me.ioDoorOutfeedOpen.Text = "0 ms"
        Me.ioDoorOutfeedOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioDoorOutfeedOpen.UpperBound = 1000
        Me.ioDoorOutfeedOpen.UserInfo = Nothing
        Me.ioDoorOutfeedOpen.UserLevel = 0
        '
        'DoorOutfeedClose
        '
        Me.DoorOutfeedClose.BindControl = Me.ioDoorOutfeedClose
        Me.DoorOutfeedClose.BindProperty = "Data"
        Me.DoorOutfeedClose.Data = Nothing
        Me.DoorOutfeedClose.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.DoorOutfeedClose.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.DoorOutfeedClose.VariableName = "InlineAutomation.Inline.Zipper.VerticalDenester.BundleStorage.BackdoorSupportR.Ch" & _
            "eck.LastTime_Cil_Out"
        '
        'ioDoorOutfeedClose
        '
        Me.ioDoorOutfeedClose.Audit = Nothing
        Me.ioDoorOutfeedClose.AuditEnabled = False
        Me.ioDoorOutfeedClose.AuditMessage = "KremerIoField changed:"
        Me.ioDoorOutfeedClose.AuditSource = "KremerIoField"
        Me.ioDoorOutfeedClose.AutoSize = True
        Me.ioDoorOutfeedClose.Data = 0
        Me.ioDoorOutfeedClose.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioDoorOutfeedClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioDoorOutfeedClose.InitialValue = True
        Me.ioDoorOutfeedClose.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioDoorOutfeedClose.Location = New System.Drawing.Point(564, 120)
        Me.ioDoorOutfeedClose.LowerBound = 0
        Me.ioDoorOutfeedClose.Name = "ioDoorOutfeedClose"
        Me.ioDoorOutfeedClose.OutputFormat = "0 ms"
        Me.ioDoorOutfeedClose.Size = New System.Drawing.Size(41, 18)
        Me.ioDoorOutfeedClose.TabIndex = 409
        Me.ioDoorOutfeedClose.Text = "0 ms"
        Me.ioDoorOutfeedClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioDoorOutfeedClose.UpperBound = 1000
        Me.ioDoorOutfeedClose.UserInfo = Nothing
        Me.ioDoorOutfeedClose.UserLevel = 0
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
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(11, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(231, 25)
        Me.Label12.TabIndex = 361
        Me.Label12.Tag = ""
        Me.Label12.Text = "Gripper"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 25)
        Me.Label2.TabIndex = 365
        Me.Label2.Tag = ""
        Me.Label2.Text = "Finger infeed side open"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 25)
        Me.Label3.TabIndex = 367
        Me.Label3.Tag = ""
        Me.Label3.Text = "Finger infeed side close"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 25)
        Me.Label4.TabIndex = 369
        Me.Label4.Tag = ""
        Me.Label4.Text = "Finger outfeed side open"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(212, 25)
        Me.Label9.TabIndex = 371
        Me.Label9.Tag = ""
        Me.Label9.Text = "Finger outfeed side close"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(325, 90)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(196, 26)
        Me.Label18.TabIndex = 390
        Me.Label18.Tag = ""
        Me.Label18.Text = "Door outfeed side is open"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(325, 65)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(196, 26)
        Me.Label19.TabIndex = 388
        Me.Label19.Tag = ""
        Me.Label19.Text = "Door infeed side is close"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(325, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(196, 26)
        Me.Label20.TabIndex = 386
        Me.Label20.Tag = ""
        Me.Label20.Text = "Door infeed side is open"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(325, 10)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(231, 26)
        Me.Label21.TabIndex = 384
        Me.Label21.Tag = ""
        Me.Label21.Text = "Backdoor Support"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(325, 115)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(212, 26)
        Me.Label16.TabIndex = 392
        Me.Label16.Tag = ""
        Me.Label16.Text = "Door outfeed side is close"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CT_BundleAutomation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ioDoorOutfeedClose)
        Me.Controls.Add(Me.ioDoorOutfeedOpen)
        Me.Controls.Add(Me.ioDoorInfeedClose)
        Me.Controls.Add(Me.ioDoorInfeedOpen)
        Me.Controls.Add(Me.ioFingerOutfeedClose)
        Me.Controls.Add(Me.ioFingerOutfeedOpen)
        Me.Controls.Add(Me.ioFingerInfeedClose)
        Me.Controls.Add(Me.ioFingerInfeedOpen)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Name = "CT_BundleAutomation"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "561"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents Btn_Overview As KremerControlsWin32.KremerButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents FingerInfeedOpen As KremerControlsWin32.KremerVariable
    Friend WithEvents FingerInfeedClose As KremerControlsWin32.KremerVariable
    Friend WithEvents FingerOutfeedOpen As KremerControlsWin32.KremerVariable
    Friend WithEvents FingerOutfeedClose As KremerControlsWin32.KremerVariable
    Friend WithEvents DoorInfeedOpen As KremerControlsWin32.KremerVariable
    Friend WithEvents DoorInfeedClose As KremerControlsWin32.KremerVariable
    Friend WithEvents DoorOutfeedOpen As KremerControlsWin32.KremerVariable
    Friend WithEvents DoorOutfeedClose As KremerControlsWin32.KremerVariable
    Friend WithEvents ioFingerOutfeedClose As KremerControlsWin32.KremerIoField
    Friend WithEvents ioFingerOutfeedOpen As KremerControlsWin32.KremerIoField
    Friend WithEvents ioFingerInfeedClose As KremerControlsWin32.KremerIoField
    Friend WithEvents ioFingerInfeedOpen As KremerControlsWin32.KremerIoField
    Friend WithEvents ioDoorOutfeedClose As KremerControlsWin32.KremerIoField
    Friend WithEvents ioDoorOutfeedOpen As KremerControlsWin32.KremerIoField
    Friend WithEvents ioDoorInfeedClose As KremerControlsWin32.KremerIoField
    Friend WithEvents ioDoorInfeedOpen As KremerControlsWin32.KremerIoField

End Class
