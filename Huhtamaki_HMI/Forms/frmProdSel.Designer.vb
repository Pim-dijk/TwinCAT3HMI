<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmProdSel
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
        Me.lstProducts = New System.Windows.Forms.ListView
        Me.clmID = New System.Windows.Forms.ColumnHeader
        Me.clmProductName = New System.Windows.Forms.ColumnHeader
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnLoad = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lstProducts
        '
        Me.lstProducts.BackColor = System.Drawing.Color.White
        Me.lstProducts.Columns.Add(Me.clmID)
        Me.lstProducts.Columns.Add(Me.clmProductName)
        Me.lstProducts.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lstProducts.FullRowSelect = True
        Me.lstProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstProducts.Location = New System.Drawing.Point(4, 3)
        Me.lstProducts.Name = "lstProducts"
        Me.lstProducts.Size = New System.Drawing.Size(390, 170)
        Me.lstProducts.TabIndex = 9
        Me.lstProducts.View = System.Windows.Forms.View.Details
        '
        'clmID
        '
        Me.clmID.Text = "ID"
        Me.clmID.Width = 53
        '
        'clmProductName
        '
        Me.clmProductName.Text = "Product Name"
        Me.clmProductName.Width = 305
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.Location = New System.Drawing.Point(272, 179)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(123, 48)
        Me.btnCancel.TabIndex = 96
        Me.btnCancel.Tag = "39"
        Me.btnCancel.Text = "Cancel"
        '
        'btnLoad
        '
        Me.btnLoad.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnLoad.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLoad.Location = New System.Drawing.Point(4, 179)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(123, 48)
        Me.btnLoad.TabIndex = 95
        Me.btnLoad.Tag = "38"
        Me.btnLoad.Text = "Load"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.Location = New System.Drawing.Point(139, 179)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(123, 48)
        Me.btnDelete.TabIndex = 97
        Me.btnDelete.Tag = "63"
        Me.btnDelete.Text = "Delete"
        '
        'frmProdSel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(398, 235)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.lstProducts)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProdSel"
        Me.Text = "Product Selection"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstProducts As System.Windows.Forms.ListView
    Friend WithEvents clmID As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmProductName As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
