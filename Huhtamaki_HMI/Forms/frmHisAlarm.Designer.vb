<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmHisAlarm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHisAlarm))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Btn_ACT_ALARM = New System.Windows.Forms.Button
        Me.DaysSlider = New System.Windows.Forms.TrackBar
        Me.BTN_SubstractDay = New System.Windows.Forms.Button
        Me.BTN_AddDay = New System.Windows.Forms.Button
        Me.LBL_Older = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LBL_DaysShown = New System.Windows.Forms.Label
        Me.KremerHistoryAlarmViewer1 = New KremerControlsWin32.KremerHistoryAlarmViewer
        CType(Me.DaysSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        Me.Label1.Tag = "351"
        '
        'Btn_ACT_ALARM
        '
        resources.ApplyResources(Me.Btn_ACT_ALARM, "Btn_ACT_ALARM")
        Me.Btn_ACT_ALARM.Name = "Btn_ACT_ALARM"
        Me.Btn_ACT_ALARM.Tag = "354"
        Me.Btn_ACT_ALARM.UseVisualStyleBackColor = True
        '
        'DaysSlider
        '
        resources.ApplyResources(Me.DaysSlider, "DaysSlider")
        Me.DaysSlider.Maximum = 7
        Me.DaysSlider.Minimum = 1
        Me.DaysSlider.Name = "DaysSlider"
        Me.DaysSlider.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.DaysSlider.Value = 1
        '
        'BTN_SubstractDay
        '
        resources.ApplyResources(Me.BTN_SubstractDay, "BTN_SubstractDay")
        Me.BTN_SubstractDay.Name = "BTN_SubstractDay"
        Me.BTN_SubstractDay.UseVisualStyleBackColor = True
        '
        'BTN_AddDay
        '
        resources.ApplyResources(Me.BTN_AddDay, "BTN_AddDay")
        Me.BTN_AddDay.Name = "BTN_AddDay"
        Me.BTN_AddDay.UseVisualStyleBackColor = True
        '
        'LBL_Older
        '
        resources.ApplyResources(Me.LBL_Older, "LBL_Older")
        Me.LBL_Older.Name = "LBL_Older"
        Me.LBL_Older.Tag = "353"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        Me.Label2.Tag = "352"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        Me.Label3.Tag = "355"
        '
        'LBL_DaysShown
        '
        resources.ApplyResources(Me.LBL_DaysShown, "LBL_DaysShown")
        Me.LBL_DaysShown.Name = "LBL_DaysShown"
        '
        'KremerHistoryAlarmViewer1
        '
        Me.KremerHistoryAlarmViewer1.AlarmData = Nothing
        Me.KremerHistoryAlarmViewer1.ColumnDescriptionWidth = 400
        Me.KremerHistoryAlarmViewer1.ColumnGroupWidth = 100
        Me.KremerHistoryAlarmViewer1.ColumnIdWidth = 50
        Me.KremerHistoryAlarmViewer1.ColumnTimestampWidth = 200
        resources.ApplyResources(Me.KremerHistoryAlarmViewer1, "KremerHistoryAlarmViewer1")
        Me.KremerHistoryAlarmViewer1.GroupFilter = Nothing
        Me.KremerHistoryAlarmViewer1.Name = "KremerHistoryAlarmViewer1"
        '
        'frmHisAlarm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        resources.ApplyResources(Me, "$this")
        Me.ControlBox = False
        Me.Controls.Add(Me.LBL_DaysShown)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LBL_Older)
        Me.Controls.Add(Me.BTN_AddDay)
        Me.Controls.Add(Me.BTN_SubstractDay)
        Me.Controls.Add(Me.DaysSlider)
        Me.Controls.Add(Me.Btn_ACT_ALARM)
        Me.Controls.Add(Me.KremerHistoryAlarmViewer1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmHisAlarm"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DaysSlider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KremerHistoryAlarmViewer1 As KremerControlsWin32.KremerHistoryAlarmViewer
    Friend WithEvents Btn_ACT_ALARM As System.Windows.Forms.Button
    Friend WithEvents DaysSlider As System.Windows.Forms.TrackBar
    Friend WithEvents BTN_SubstractDay As System.Windows.Forms.Button
    Friend WithEvents BTN_AddDay As System.Windows.Forms.Button
    Friend WithEvents LBL_Older As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LBL_DaysShown As System.Windows.Forms.Label
End Class
