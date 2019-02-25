<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CT_Outfeed
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
        Me.FingerInfeedIn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioFingerInfeedIn = New KremerControlsWin32.KremerIoField(Me.components)
        Me.FingerInfeedOut = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioFingerInfeedOut = New KremerControlsWin32.KremerIoField(Me.components)
        Me.FingerOutfeedIn = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioFingerOutfeedIn = New KremerControlsWin32.KremerIoField(Me.components)
        Me.FingerOutfeedOut = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioFingerOutfeedOut = New KremerControlsWin32.KremerIoField(Me.components)
        Me.LiftUp = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioLiftUp = New KremerControlsWin32.KremerIoField(Me.components)
        Me.LiftDown = New KremerControlsWin32.KremerVariable(Me.components)
        Me.ioLiftDown = New KremerControlsWin32.KremerIoField(Me.components)
        Me.Btn_Overview = New KremerControlsWin32.KremerButton
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.FingerInfeedIn)
        Me.VarCollector.Variables.Add(Me.FingerInfeedOut)
        Me.VarCollector.Variables.Add(Me.FingerOutfeedIn)
        Me.VarCollector.Variables.Add(Me.FingerOutfeedOut)
        Me.VarCollector.Variables.Add(Me.LiftUp)
        Me.VarCollector.Variables.Add(Me.LiftDown)
        '
        'FingerInfeedIn
        '
        Me.FingerInfeedIn.BindControl = Me.ioFingerInfeedIn
        Me.FingerInfeedIn.BindProperty = "Data"
        Me.FingerInfeedIn.Data = Nothing
        Me.FingerInfeedIn.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.FingerInfeedIn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FingerInfeedIn.VariableName = "InlineAutomation.Stacking.BundleOutfeed.OutfeedLift.Finger_Left.Check.LastTime_Ci" & _
            "l_In"
        '
        'ioFingerInfeedIn
        '
        Me.ioFingerInfeedIn.Audit = Nothing
        Me.ioFingerInfeedIn.AuditEnabled = False
        Me.ioFingerInfeedIn.AuditMessage = "KremerIoField changed:"
        Me.ioFingerInfeedIn.AuditSource = "KremerIoField"
        Me.ioFingerInfeedIn.AutoSize = True
        Me.ioFingerInfeedIn.Data = 0
        Me.ioFingerInfeedIn.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioFingerInfeedIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioFingerInfeedIn.InitialValue = True
        Me.ioFingerInfeedIn.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioFingerInfeedIn.Location = New System.Drawing.Point(245, 43)
        Me.ioFingerInfeedIn.LowerBound = 0
        Me.ioFingerInfeedIn.Name = "ioFingerInfeedIn"
        Me.ioFingerInfeedIn.OutputFormat = "0 ms"
        Me.ioFingerInfeedIn.Size = New System.Drawing.Size(41, 18)
        Me.ioFingerInfeedIn.TabIndex = 398
        Me.ioFingerInfeedIn.Text = "0 ms"
        Me.ioFingerInfeedIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioFingerInfeedIn.UpperBound = 1000
        Me.ioFingerInfeedIn.UserInfo = Nothing
        Me.ioFingerInfeedIn.UserLevel = 0
        '
        'FingerInfeedOut
        '
        Me.FingerInfeedOut.BindControl = Me.ioFingerInfeedOut
        Me.FingerInfeedOut.BindProperty = "Data"
        Me.FingerInfeedOut.Data = Nothing
        Me.FingerInfeedOut.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.FingerInfeedOut.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FingerInfeedOut.VariableName = "InlineAutomation.Stacking.BundleOutfeed.OutfeedLift.Finger_Left.Check.LastTime_Ci" & _
            "l_Out"
        '
        'ioFingerInfeedOut
        '
        Me.ioFingerInfeedOut.Audit = Nothing
        Me.ioFingerInfeedOut.AuditEnabled = False
        Me.ioFingerInfeedOut.AuditMessage = "KremerIoField changed:"
        Me.ioFingerInfeedOut.AuditSource = "KremerIoField"
        Me.ioFingerInfeedOut.AutoSize = True
        Me.ioFingerInfeedOut.Data = 0
        Me.ioFingerInfeedOut.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioFingerInfeedOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioFingerInfeedOut.InitialValue = True
        Me.ioFingerInfeedOut.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioFingerInfeedOut.Location = New System.Drawing.Point(245, 68)
        Me.ioFingerInfeedOut.LowerBound = 0
        Me.ioFingerInfeedOut.Name = "ioFingerInfeedOut"
        Me.ioFingerInfeedOut.OutputFormat = "0 ms"
        Me.ioFingerInfeedOut.Size = New System.Drawing.Size(41, 18)
        Me.ioFingerInfeedOut.TabIndex = 399
        Me.ioFingerInfeedOut.Text = "0 ms"
        Me.ioFingerInfeedOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioFingerInfeedOut.UpperBound = 1000
        Me.ioFingerInfeedOut.UserInfo = Nothing
        Me.ioFingerInfeedOut.UserLevel = 0
        '
        'FingerOutfeedIn
        '
        Me.FingerOutfeedIn.BindControl = Me.ioFingerOutfeedIn
        Me.FingerOutfeedIn.BindProperty = "Data"
        Me.FingerOutfeedIn.Data = Nothing
        Me.FingerOutfeedIn.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.FingerOutfeedIn.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FingerOutfeedIn.VariableName = "InlineAutomation.Stacking.BundleOutfeed.OutfeedLift.Finger_Right.Check.LastTime_C" & _
            "il_In"
        '
        'ioFingerOutfeedIn
        '
        Me.ioFingerOutfeedIn.Audit = Nothing
        Me.ioFingerOutfeedIn.AuditEnabled = False
        Me.ioFingerOutfeedIn.AuditMessage = "KremerIoField changed:"
        Me.ioFingerOutfeedIn.AuditSource = "KremerIoField"
        Me.ioFingerOutfeedIn.AutoSize = True
        Me.ioFingerOutfeedIn.Data = 0
        Me.ioFingerOutfeedIn.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioFingerOutfeedIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioFingerOutfeedIn.InitialValue = True
        Me.ioFingerOutfeedIn.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioFingerOutfeedIn.Location = New System.Drawing.Point(245, 93)
        Me.ioFingerOutfeedIn.LowerBound = 0
        Me.ioFingerOutfeedIn.Name = "ioFingerOutfeedIn"
        Me.ioFingerOutfeedIn.OutputFormat = "0 ms"
        Me.ioFingerOutfeedIn.Size = New System.Drawing.Size(41, 18)
        Me.ioFingerOutfeedIn.TabIndex = 400
        Me.ioFingerOutfeedIn.Text = "0 ms"
        Me.ioFingerOutfeedIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioFingerOutfeedIn.UpperBound = 1000
        Me.ioFingerOutfeedIn.UserInfo = Nothing
        Me.ioFingerOutfeedIn.UserLevel = 0
        '
        'FingerOutfeedOut
        '
        Me.FingerOutfeedOut.BindControl = Me.ioFingerOutfeedOut
        Me.FingerOutfeedOut.BindProperty = "Data"
        Me.FingerOutfeedOut.Data = Nothing
        Me.FingerOutfeedOut.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.FingerOutfeedOut.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.FingerOutfeedOut.VariableName = "InlineAutomation.Stacking.BundleOutfeed.OutfeedLift.Finger_Right.Check.LastTime_C" & _
            "il_Out"
        '
        'ioFingerOutfeedOut
        '
        Me.ioFingerOutfeedOut.Audit = Nothing
        Me.ioFingerOutfeedOut.AuditEnabled = False
        Me.ioFingerOutfeedOut.AuditMessage = "KremerIoField changed:"
        Me.ioFingerOutfeedOut.AuditSource = "KremerIoField"
        Me.ioFingerOutfeedOut.AutoSize = True
        Me.ioFingerOutfeedOut.Data = 0
        Me.ioFingerOutfeedOut.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioFingerOutfeedOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioFingerOutfeedOut.InitialValue = True
        Me.ioFingerOutfeedOut.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioFingerOutfeedOut.Location = New System.Drawing.Point(245, 118)
        Me.ioFingerOutfeedOut.LowerBound = 0
        Me.ioFingerOutfeedOut.Name = "ioFingerOutfeedOut"
        Me.ioFingerOutfeedOut.OutputFormat = "0 ms"
        Me.ioFingerOutfeedOut.Size = New System.Drawing.Size(41, 18)
        Me.ioFingerOutfeedOut.TabIndex = 401
        Me.ioFingerOutfeedOut.Text = "0 ms"
        Me.ioFingerOutfeedOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioFingerOutfeedOut.UpperBound = 1000
        Me.ioFingerOutfeedOut.UserInfo = Nothing
        Me.ioFingerOutfeedOut.UserLevel = 0
        '
        'LiftUp
        '
        Me.LiftUp.BindControl = Me.ioLiftUp
        Me.LiftUp.BindProperty = "Data"
        Me.LiftUp.Data = Nothing
        Me.LiftUp.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.LiftUp.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.LiftUp.VariableName = "InlineAutomation.Stacking.BundleOutfeed.OutfeedLift.Cilinder.Check.LastTime_Cil_O" & _
            "ut"
        '
        'ioLiftUp
        '
        Me.ioLiftUp.Audit = Nothing
        Me.ioLiftUp.AuditEnabled = False
        Me.ioLiftUp.AuditMessage = "KremerIoField changed:"
        Me.ioLiftUp.AuditSource = "KremerIoField"
        Me.ioLiftUp.AutoSize = True
        Me.ioLiftUp.Data = 0
        Me.ioLiftUp.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioLiftUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioLiftUp.InitialValue = True
        Me.ioLiftUp.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioLiftUp.Location = New System.Drawing.Point(245, 143)
        Me.ioLiftUp.LowerBound = 0
        Me.ioLiftUp.Name = "ioLiftUp"
        Me.ioLiftUp.OutputFormat = "0 ms"
        Me.ioLiftUp.Size = New System.Drawing.Size(41, 18)
        Me.ioLiftUp.TabIndex = 404
        Me.ioLiftUp.Text = "0 ms"
        Me.ioLiftUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioLiftUp.UpperBound = 1000
        Me.ioLiftUp.UserInfo = Nothing
        Me.ioLiftUp.UserLevel = 0
        '
        'LiftDown
        '
        Me.LiftDown.BindControl = Me.ioLiftDown
        Me.LiftDown.BindProperty = "Data"
        Me.LiftDown.Data = Nothing
        Me.LiftDown.DataType = KremerControlsWin32.KremerVariable.VarDataType.DINT
        Me.LiftDown.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.LiftDown.VariableName = "InlineAutomation.Stacking.BundleOutfeed.OutfeedLift.Cilinder.Check.LastTime_Cil_I" & _
            "n"
        '
        'ioLiftDown
        '
        Me.ioLiftDown.Audit = Nothing
        Me.ioLiftDown.AuditEnabled = False
        Me.ioLiftDown.AuditMessage = "KremerIoField changed:"
        Me.ioLiftDown.AuditSource = "KremerIoField"
        Me.ioLiftDown.AutoSize = True
        Me.ioLiftDown.Data = 0
        Me.ioLiftDown.DataType = KremerControlsWin32.KremerIoField.NumDataType.LREAL
        Me.ioLiftDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ioLiftDown.InitialValue = True
        Me.ioLiftDown.IOType = KremerControlsWin32.KremerIoField.IO_Type.Output
        Me.ioLiftDown.Location = New System.Drawing.Point(245, 168)
        Me.ioLiftDown.LowerBound = 0
        Me.ioLiftDown.Name = "ioLiftDown"
        Me.ioLiftDown.OutputFormat = "0 ms"
        Me.ioLiftDown.Size = New System.Drawing.Size(41, 18)
        Me.ioLiftDown.TabIndex = 405
        Me.ioLiftDown.Text = "0 ms"
        Me.ioLiftDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ioLiftDown.UpperBound = 1000
        Me.ioLiftDown.UserInfo = Nothing
        Me.ioLiftDown.UserLevel = 0
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
        Me.Label12.Text = "Outfeed Lift"
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
        Me.Label2.Text = "Finger infeed side In"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 25)
        Me.Label3.TabIndex = 367
        Me.Label3.Tag = ""
        Me.Label3.Text = "Finger infeed side Out"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 25)
        Me.Label4.TabIndex = 369
        Me.Label4.Tag = ""
        Me.Label4.Text = "Finger outfeed side In"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(196, 25)
        Me.Label9.TabIndex = 371
        Me.Label9.Tag = ""
        Me.Label9.Text = "Finger outfeed side Out"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 25)
        Me.Label1.TabIndex = 403
        Me.Label1.Tag = ""
        Me.Label1.Text = "Lift Down"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 25)
        Me.Label5.TabIndex = 402
        Me.Label5.Tag = ""
        Me.Label5.Text = "Lift Up"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CT_Outfeed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ioLiftDown)
        Me.Controls.Add(Me.ioLiftUp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ioFingerOutfeedOut)
        Me.Controls.Add(Me.ioFingerOutfeedIn)
        Me.Controls.Add(Me.ioFingerInfeedOut)
        Me.Controls.Add(Me.ioFingerInfeedIn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Btn_Overview)
        Me.Name = "CT_Outfeed"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "559"
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
    Friend WithEvents ioFingerOutfeedOut As KremerControlsWin32.KremerIoField
    Friend WithEvents ioFingerOutfeedIn As KremerControlsWin32.KremerIoField
    Friend WithEvents ioFingerInfeedOut As KremerControlsWin32.KremerIoField
    Friend WithEvents ioFingerInfeedIn As KremerControlsWin32.KremerIoField
    Friend WithEvents FingerInfeedIn As KremerControlsWin32.KremerVariable
    Friend WithEvents FingerInfeedOut As KremerControlsWin32.KremerVariable
    Friend WithEvents FingerOutfeedIn As KremerControlsWin32.KremerVariable
    Friend WithEvents FingerOutfeedOut As KremerControlsWin32.KremerVariable
    Friend WithEvents ioLiftDown As KremerControlsWin32.KremerIoField
    Friend WithEvents ioLiftUp As KremerControlsWin32.KremerIoField
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LiftUp As KremerControlsWin32.KremerVariable
    Friend WithEvents LiftDown As KremerControlsWin32.KremerVariable

End Class
