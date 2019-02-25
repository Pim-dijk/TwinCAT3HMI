<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlarmsSub
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
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnSortChrono = New System.Windows.Forms.Button()
        Me.btnSortType = New System.Windows.Forms.Button()
        Me.krAlarmView = New KremerControlsWin32.KremerAlarmViewer()
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.UserLevel = New KremerControlsWin32.KremerVariable(Me.components)
        Me.SuspendLayout()
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'btnHistory
        '
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistory.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnHistory.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnHistory.Location = New System.Drawing.Point(1, 385)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(114, 50)
        Me.btnHistory.TabIndex = 7
        Me.btnHistory.Tag = "350"
        Me.btnHistory.Text = "History"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(115, 385)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 50)
        Me.Button2.TabIndex = 7
        Me.Button2.Tag = ""
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(229, 385)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 50)
        Me.Button3.TabIndex = 7
        Me.Button3.Tag = ""
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button4.Location = New System.Drawing.Point(343, 385)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(114, 50)
        Me.Button4.TabIndex = 7
        Me.Button4.Tag = ""
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button5.Location = New System.Drawing.Point(457, 385)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(114, 50)
        Me.Button5.TabIndex = 7
        Me.Button5.Tag = ""
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnSortChrono
        '
        Me.btnSortChrono.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSortChrono.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSortChrono.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSortChrono.Location = New System.Drawing.Point(571, 385)
        Me.btnSortChrono.Name = "btnSortChrono"
        Me.btnSortChrono.Size = New System.Drawing.Size(114, 50)
        Me.btnSortChrono.TabIndex = 7
        Me.btnSortChrono.Tag = ""
        Me.btnSortChrono.Text = "Sort" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Chronological"
        Me.btnSortChrono.UseVisualStyleBackColor = True
        '
        'btnSortType
        '
        Me.btnSortType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSortType.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSortType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSortType.Location = New System.Drawing.Point(685, 385)
        Me.btnSortType.Name = "btnSortType"
        Me.btnSortType.Size = New System.Drawing.Size(114, 50)
        Me.btnSortType.TabIndex = 7
        Me.btnSortType.Tag = ""
        Me.btnSortType.Text = "Sort By Type"
        Me.btnSortType.UseVisualStyleBackColor = True
        '
        'krAlarmView
        '
        Me.krAlarmView.AlarmData = Nothing
        Me.krAlarmView.ColumnGroupWidth = 100
        Me.krAlarmView.ColumnIdWidth = 40
        Me.krAlarmView.ColumnTimestampWidth = 150
        Me.krAlarmView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.krAlarmView.GroupFilter = Nothing
        Me.krAlarmView.GroupVisible = True
        Me.krAlarmView.Location = New System.Drawing.Point(0, 0)
        Me.krAlarmView.Name = "krAlarmView"
        Me.krAlarmView.SelectRow = True
        Me.krAlarmView.Size = New System.Drawing.Size(800, 382)
        Me.krAlarmView.SortOrderString = "KremerAlarmTypes, TimeStamp DESC"
        Me.krAlarmView.TabIndex = 5
        '
        'VarCollector
        '
        Me.VarCollector.Variables.Add(Me.UserLevel)
        '
        'UserLevel
        '
        Me.UserLevel.BindControl = Nothing
        Me.UserLevel.BindProperty = "Data"
        Me.UserLevel.Data = Nothing
        Me.UserLevel.DataType = KremerControlsWin32.KremerVariable.VarDataType.INT
        Me.UserLevel.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.UserLevel.VariableName = "HMI.miUserLevel"
        '
        'AlarmsSub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnSortType)
        Me.Controls.Add(Me.btnSortChrono)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.krAlarmView)
        Me.Name = "AlarmsSub"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "11"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents btnHistory As System.Windows.Forms.Button
    Friend WithEvents krAlarmView As KremerControlsWin32.KremerAlarmViewer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnSortChrono As System.Windows.Forms.Button
    Friend WithEvents btnSortType As System.Windows.Forms.Button
    Friend WithEvents UserLevel As KremerControlsWin32.KremerVariable

End Class
