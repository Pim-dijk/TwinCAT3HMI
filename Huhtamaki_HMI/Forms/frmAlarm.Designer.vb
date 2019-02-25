<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmAlarm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlarm))
        Me.Label1 = New System.Windows.Forms.Label
        Me.krAlarmView = New KremerControlsWin32.KremerAlarmViewer
        Me.btnBack = New KremerControlsWin32.KremerButton
        Me.btnReset = New KremerControlsWin32.KremerButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        Me.Label1.Tag = "11"
        '
        'krAlarmView
        '
        Me.krAlarmView.AlarmData = Nothing
        Me.krAlarmView.ColumnGroupWidth = 100
        Me.krAlarmView.ColumnIdWidth = 40
        Me.krAlarmView.ColumnTimestampWidth = 150
        resources.ApplyResources(Me.krAlarmView, "krAlarmView")
        Me.krAlarmView.GroupFilter = Nothing
        Me.krAlarmView.GroupVisible = True
        Me.krAlarmView.Name = "krAlarmView"
        '
        'btnBack
        '
        Me.btnBack.Audit = Nothing
        Me.btnBack.AuditEnabled = False
        Me.btnBack.AuditMessage = "KremerPushButton pressed!"
        Me.btnBack.AuditSource = "KremerPushButton"
        Me.btnBack.BackColorOn = System.Drawing.Color.Empty
        Me.btnBack.BackGroundImageOn = Nothing
        Me.btnBack.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.btnBack.Data = False
        resources.ApplyResources(Me.btnBack, "btnBack")
        Me.btnBack.ForeColorOn = System.Drawing.Color.Empty
        Me.btnBack.Name = "btnBack"
        Me.btnBack.State = False
        Me.btnBack.StateIsData = True
        Me.btnBack.StateText = New String() {Nothing, Nothing}
        Me.btnBack.Tag = "13"
        Me.btnBack.UserInfo = Nothing
        Me.btnBack.UserLevel = 0
        Me.btnBack.UseStateText = False
        '
        'btnReset
        '
        Me.btnReset.Audit = Nothing
        Me.btnReset.AuditEnabled = False
        Me.btnReset.AuditMessage = "KremerPushButton pressed!"
        Me.btnReset.AuditSource = "KremerPushButton"
        Me.btnReset.BackColorOn = System.Drawing.Color.Empty
        Me.btnReset.BackGroundImageOn = Nothing
        Me.btnReset.ButtonAction = KremerControlsWin32.KremerButton.Action.Momentary
        Me.btnReset.Data = False
        resources.ApplyResources(Me.btnReset, "btnReset")
        Me.btnReset.ForeColorOn = System.Drawing.Color.Empty
        Me.btnReset.Name = "btnReset"
        Me.btnReset.State = False
        Me.btnReset.StateIsData = True
        Me.btnReset.StateText = New String() {Nothing, Nothing}
        Me.btnReset.Tag = "12"
        Me.btnReset.UserInfo = Nothing
        Me.btnReset.UserLevel = 0
        Me.btnReset.UseStateText = False
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.Tag = "350"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmAlarm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        resources.ApplyResources(Me, "$this")
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.krAlarmView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnReset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmAlarm"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnReset As KremerControlsWin32.KremerButton
    Friend WithEvents btnBack As KremerControlsWin32.KremerButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents krAlarmView As KremerControlsWin32.KremerAlarmViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
