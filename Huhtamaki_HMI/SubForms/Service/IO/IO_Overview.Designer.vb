<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IO_Overview
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.VarCollector = New KremerControlsWin32.KremerVariableCollector(Me.components)
        Me.KrConnector = New TwincatControlWin32.KremerConnector(Me.components)
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(3, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 98)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Topmolds"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(133, 334)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 98)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Bottommolds"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(263, 334)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 98)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Transfermold"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(393, 334)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(124, 98)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "ProductForming"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(523, 334)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(124, 98)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Product handling"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(653, 334)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(124, 98)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Hydraulics"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'KrConnector
        '
        Me.KrConnector.VarCollector = Nothing
        '
        'IO_Overview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "IO_Overview"
        Me.Size = New System.Drawing.Size(800, 435)
        Me.Tag = "507"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents VarCollector As KremerControlsWin32.KremerVariableCollector
    Friend WithEvents KrConnector As TwincatControlWin32.KremerConnector

End Class
