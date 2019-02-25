<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EtherCatTopology
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EtherCatTopology))
        Me.krConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.krVarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.VarDeviceID = New KremerControlsWin32.KremerVariable(Me.components)
        Me.VarAmsNetID = New KremerControlsWin32.KremerVariable(Me.components)
        Me.Btn_Zoom = New KremerControlsWin32.KremerButton()
        Me.AxEcTopologyCtrl1 = New AxECTOPOLOGYLib.AxEcTopologyCtrl()
        CType(Me.AxEcTopologyCtrl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'krConnector
        '
        Me.krConnector.VarCollector = Nothing
        '
        'krVarCollector
        '
        Me.krVarCollector.Variables.Add(Me.VarDeviceID)
        Me.krVarCollector.Variables.Add(Me.VarAmsNetID)
        '
        'VarDeviceID
        '
        Me.VarDeviceID.BindControl = Nothing
        Me.VarDeviceID.BindProperty = "Data"
        Me.VarDeviceID.Data = Nothing
        Me.VarDeviceID.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.VarDeviceID.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.VarDeviceID.VariableName = "Main.DeviceID"
        '
        'VarAmsNetID
        '
        Me.VarAmsNetID.BindControl = Nothing
        Me.VarAmsNetID.BindProperty = "Data"
        Me.VarAmsNetID.Data = Nothing
        Me.VarAmsNetID.DataType = KremerControlsWin32.KremerVariable.VarDataType.TEXT
        Me.VarAmsNetID.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.VarAmsNetID.VariableName = "Main.AmsNetID"
        '
        'Btn_Zoom
        '
        Me.Btn_Zoom.Audit = Nothing
        Me.Btn_Zoom.AuditEnabled = False
        Me.Btn_Zoom.AuditMessage = "KremerPushButton pressed!"
        Me.Btn_Zoom.AuditSource = "KremerPushButton"
        Me.Btn_Zoom.BackColorOn = System.Drawing.Color.Empty
        Me.Btn_Zoom.BackGroundImageOn = Nothing
        Me.Btn_Zoom.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.Btn_Zoom.Data = False
        Me.Btn_Zoom.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Zoom.ForeColorOn = System.Drawing.Color.Empty
        Me.Btn_Zoom.Location = New System.Drawing.Point(10, 380)
        Me.Btn_Zoom.Name = "Btn_Zoom"
        Me.Btn_Zoom.Size = New System.Drawing.Size(113, 50)
        Me.Btn_Zoom.State = False
        Me.Btn_Zoom.StateIsData = True
        Me.Btn_Zoom.StateText = New String() {Nothing, Nothing}
        Me.Btn_Zoom.TabIndex = 6
        Me.Btn_Zoom.Tag = ""
        Me.Btn_Zoom.Text = "Zoom"
        Me.Btn_Zoom.UserInfo = Nothing
        Me.Btn_Zoom.UserLevel = 0
        Me.Btn_Zoom.UseStateText = False
        Me.Btn_Zoom.UseVisualStyleBackColor = True
        '
        'AxEcTopologyCtrl1
        '
        Me.AxEcTopologyCtrl1.Enabled = True
        Me.AxEcTopologyCtrl1.Location = New System.Drawing.Point(10, 10)
        Me.AxEcTopologyCtrl1.MaximumSize = New System.Drawing.Size(780, 360)
        Me.AxEcTopologyCtrl1.Name = "AxEcTopologyCtrl1"
        Me.AxEcTopologyCtrl1.OcxState = CType(resources.GetObject("AxEcTopologyCtrl1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxEcTopologyCtrl1.Size = New System.Drawing.Size(779, 360)
        Me.AxEcTopologyCtrl1.TabIndex = 1
        '
        'EtherCatTopology
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Btn_Zoom)
        Me.Controls.Add(Me.AxEcTopologyCtrl1)
        Me.Name = "EtherCatTopology"
        Me.Size = New System.Drawing.Size(800, 441)
        Me.Tag = "500"
        CType(Me.AxEcTopologyCtrl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxEcTopologyCtrl1 As AxECTOPOLOGYLib.AxEcTopologyCtrl
    Friend WithEvents krConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents krVarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents Btn_Zoom As KremerControlsWin32.KremerButton
    Friend WithEvents VarDeviceID As KremerControlsWin32.KremerVariable
    Friend WithEvents VarAmsNetID As KremerControlsWin32.KremerVariable

End Class
