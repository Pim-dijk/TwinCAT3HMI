<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Trend
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Me.krConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.krVarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.TrendChannel1 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.TrendChannel2 = New KremerControlsWin32.KremerVariable(Me.components)
        Me.krTrend = New KremerControlsWin32.KremerTrend(Me.components)
        Me.Channel1 = New KremerControlsWin32.KremerChannel
        Me.Channel2 = New KremerControlsWin32.KremerChannel
        Me.TC = New Steema.TeeChart.TChart
        Me.SuspendLayout()
        '
        'krConnector
        '
        Me.krConnector.VarCollector = Nothing
        '
        'krVarCollector
        '
        Me.krVarCollector.Variables.Add(Me.TrendChannel1)
        Me.krVarCollector.Variables.Add(Me.TrendChannel2)
        '
        'TrendChannel1
        '
        Me.TrendChannel1.BindControl = Nothing
        Me.TrendChannel1.BindProperty = "Data"
        Me.TrendChannel1.Data = Nothing
        Me.TrendChannel1.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.TrendChannel1.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TrendChannel1.VariableName = ""
        '
        'TrendChannel2
        '
        Me.TrendChannel2.BindControl = Nothing
        Me.TrendChannel2.BindProperty = "Data"
        Me.TrendChannel2.Data = Nothing
        Me.TrendChannel2.DataType = KremerControlsWin32.KremerVariable.VarDataType.REAL
        Me.TrendChannel2.UpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged
        Me.TrendChannel2.VariableName = ""
        '
        'krTrend
        '
        Me.krTrend.AutoScale = False
        Me.krTrend.Channels.Add(Me.Channel1)
        Me.krTrend.Channels.Add(Me.Channel2)
        Me.krTrend.Maximum = 100
        Me.krTrend.Minimum = 0
        Me.krTrend.NrOfSamples = 100
        Me.krTrend.TeeChart = Me.TC
        '
        'Channel1
        '
        Me.Channel1.LineColor = System.Drawing.Color.Red
        Me.Channel1.Tag = Nothing
        Me.Channel1.Text = "Channel 1"
        Me.Channel1.TrendData = Nothing
        Me.Channel1.Variable = Me.TrendChannel1
        '
        'Channel2
        '
        Me.Channel2.LineColor = System.Drawing.Color.Lime
        Me.Channel2.Tag = Nothing
        Me.Channel2.Text = "Channel 2"
        Me.Channel2.TrendData = Nothing
        Me.Channel2.Variable = Me.TrendChannel2
        '
        'TC
        '
        '
        '
        '
        Me.TC.Aspect.ElevationFloat = 345
        Me.TC.Aspect.RotationFloat = 345
        Me.TC.Aspect.View3D = False
        '
        '
        '
        '
        '
        '
        Me.TC.Axes.Bottom.Automatic = True
        '
        '
        '
        Me.TC.Axes.Bottom.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.TC.Axes.Bottom.Grid.ZPosition = 0
        '
        '
        '
        Me.TC.Axes.Bottom.Labels.Visible = False
        '
        '
        '
        Me.TC.Axes.Depth.Automatic = True
        '
        '
        '
        Me.TC.Axes.Depth.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.TC.Axes.Depth.Grid.ZPosition = 0
        '
        '
        '
        Me.TC.Axes.DepthTop.Automatic = True
        '
        '
        '
        Me.TC.Axes.DepthTop.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.TC.Axes.DepthTop.Grid.ZPosition = 0
        '
        '
        '
        Me.TC.Axes.Left.AutomaticMaximum = False
        Me.TC.Axes.Left.AutomaticMinimum = False
        '
        '
        '
        Me.TC.Axes.Left.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.TC.Axes.Left.Grid.ZPosition = 0
        Me.TC.Axes.Left.Maximum = 100
        Me.TC.Axes.Left.Minimum = 0
        '
        '
        '
        Me.TC.Axes.Right.Automatic = True
        '
        '
        '
        Me.TC.Axes.Right.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.TC.Axes.Right.Grid.ZPosition = 0
        '
        '
        '
        Me.TC.Axes.Top.Automatic = True
        '
        '
        '
        Me.TC.Axes.Top.Grid.Style = System.Drawing.Drawing2D.DashStyle.Dash
        Me.TC.Axes.Top.Grid.ZPosition = 0
        Me.TC.Dock = System.Windows.Forms.DockStyle.Fill
        '
        '
        '
        Me.TC.Header.Lines = New String() {""}
        '
        '
        '
        '
        '
        '
        Me.TC.Legend.Shadow.Visible = True
        '
        '
        '
        '
        '
        '
        Me.TC.Legend.Title.Font.Bold = True
        '
        '
        '
        Me.TC.Legend.Title.Pen.Visible = False
        Me.TC.Location = New System.Drawing.Point(0, 0)
        Me.TC.Name = "TC"
        '
        '
        '
        '
        '
        '
        Me.TC.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None
        Me.TC.Size = New System.Drawing.Size(1024, 606)
        Me.TC.TabIndex = 0
        '
        '
        '
        '
        '
        '
        Me.TC.Walls.Back.AutoHide = False
        '
        '
        '
        Me.TC.Walls.Bottom.AutoHide = False
        '
        '
        '
        Me.TC.Walls.Left.AutoHide = False
        '
        '
        '
        Me.TC.Walls.Right.AutoHide = False
        '
        'Trend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.TC)
        Me.Name = "Trend"
        Me.Size = New System.Drawing.Size(1024, 606)
        Me.Tag = "2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents krConnector As TwincatControlWin32.KremerConnector
    Friend WithEvents krVarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents krTrend As KremerControlsWin32.KremerTrend
    Friend WithEvents TrendChannel1 As KremerControlsWin32.KremerVariable
    Friend WithEvents TrendChannel2 As KremerControlsWin32.KremerVariable
    Friend WithEvents Channel1 As KremerControlsWin32.KremerChannel
    Friend WithEvents Channel2 As KremerControlsWin32.KremerChannel
    Friend WithEvents TC As Steema.TeeChart.TChart

End Class
