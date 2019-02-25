<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HisAlarmsSub
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
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.LBL_DaysShown = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.KremerHistoryAlarmViewer1 = New KremerControlsWin32.KremerHistoryAlarmViewer
        Me.Label2 = New System.Windows.Forms.Label
        Me.LBL_Older = New System.Windows.Forms.Label
        Me.BTN_AddDay = New System.Windows.Forms.Button
        Me.BTN_SubstractDay = New System.Windows.Forms.Button
        Me.DaysSlider = New System.Windows.Forms.TrackBar
        CType(Me.DaysSlider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'LBL_DaysShown
        '
        Me.LBL_DaysShown.AutoSize = True
        Me.LBL_DaysShown.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LBL_DaysShown.Location = New System.Drawing.Point(12, 415)
        Me.LBL_DaysShown.Name = "LBL_DaysShown"
        Me.LBL_DaysShown.Size = New System.Drawing.Size(21, 13)
        Me.LBL_DaysShown.TabIndex = 19
        Me.LBL_DaysShown.Text = "##"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(12, 399)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Tag = "355"
        Me.Label3.Text = "Number of days history showing:"
        '
        'KremerHistoryAlarmViewer1
        '
        Me.KremerHistoryAlarmViewer1.AlarmData = Nothing
        Me.KremerHistoryAlarmViewer1.ColumnDescriptionWidth = 455
        Me.KremerHistoryAlarmViewer1.ColumnGroupWidth = 100
        Me.KremerHistoryAlarmViewer1.ColumnIdWidth = 40
        Me.KremerHistoryAlarmViewer1.ColumnTimestampWidth = 200
        Me.KremerHistoryAlarmViewer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.KremerHistoryAlarmViewer1.GroupFilter = Nothing
        Me.KremerHistoryAlarmViewer1.Location = New System.Drawing.Point(0, 64)
        Me.KremerHistoryAlarmViewer1.MaxNumberOfAlarmShown = 500
        Me.KremerHistoryAlarmViewer1.Name = "KremerHistoryAlarmViewer1"
        Me.KremerHistoryAlarmViewer1.Size = New System.Drawing.Size(800, 332)
        Me.KremerHistoryAlarmViewer1.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(731, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Tag = "352"
        Me.Label2.Text = "newer"
        '
        'LBL_Older
        '
        Me.LBL_Older.AutoSize = True
        Me.LBL_Older.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LBL_Older.Location = New System.Drawing.Point(37, 3)
        Me.LBL_Older.Name = "LBL_Older"
        Me.LBL_Older.Size = New System.Drawing.Size(32, 13)
        Me.LBL_Older.TabIndex = 25
        Me.LBL_Older.Tag = "353"
        Me.LBL_Older.Text = "Older"
        '
        'BTN_AddDay
        '
        Me.BTN_AddDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!)
        Me.BTN_AddDay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_AddDay.Location = New System.Drawing.Point(729, 19)
        Me.BTN_AddDay.Name = "BTN_AddDay"
        Me.BTN_AddDay.Size = New System.Drawing.Size(40, 40)
        Me.BTN_AddDay.TabIndex = 24
        Me.BTN_AddDay.Text = ">"
        Me.BTN_AddDay.UseVisualStyleBackColor = True
        '
        'BTN_SubstractDay
        '
        Me.BTN_SubstractDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!)
        Me.BTN_SubstractDay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BTN_SubstractDay.Location = New System.Drawing.Point(33, 19)
        Me.BTN_SubstractDay.Name = "BTN_SubstractDay"
        Me.BTN_SubstractDay.Size = New System.Drawing.Size(40, 40)
        Me.BTN_SubstractDay.TabIndex = 23
        Me.BTN_SubstractDay.Text = "<"
        Me.BTN_SubstractDay.UseVisualStyleBackColor = True
        '
        'DaysSlider
        '
        Me.DaysSlider.Enabled = False
        Me.DaysSlider.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DaysSlider.Location = New System.Drawing.Point(77, 19)
        Me.DaysSlider.Maximum = 7
        Me.DaysSlider.Minimum = 1
        Me.DaysSlider.Name = "DaysSlider"
        Me.DaysSlider.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DaysSlider.Size = New System.Drawing.Size(646, 42)
        Me.DaysSlider.TabIndex = 22
        Me.DaysSlider.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.DaysSlider.Value = 1
        '
        'HisAlarmsSub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LBL_Older)
        Me.Controls.Add(Me.BTN_AddDay)
        Me.Controls.Add(Me.BTN_SubstractDay)
        Me.Controls.Add(Me.DaysSlider)
        Me.Controls.Add(Me.KremerHistoryAlarmViewer1)
        Me.Controls.Add(Me.LBL_DaysShown)
        Me.Controls.Add(Me.Label3)
        Me.Name = "HisAlarmsSub"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "351"
        CType(Me.DaysSlider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents LBL_DaysShown As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents KremerHistoryAlarmViewer1 As KremerControlsWin32.KremerHistoryAlarmViewer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LBL_Older As System.Windows.Forms.Label
    Friend WithEvents BTN_AddDay As System.Windows.Forms.Button
    Friend WithEvents BTN_SubstractDay As System.Windows.Forms.Button
    Friend WithEvents DaysSlider As System.Windows.Forms.TrackBar

End Class
