<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmLangSel
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
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnLoad = New System.Windows.Forms.Button
        Me.lstLang = New System.Windows.Forms.ListView
        Me.clmID = New System.Windows.Forms.ColumnHeader
        Me.clmLanguage = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.Location = New System.Drawing.Point(271, 180)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(123, 48)
        Me.btnCancel.TabIndex = 99
        Me.btnCancel.Tag = "39"
        Me.btnCancel.Text = "Cancel"
        '
        'btnLoad
        '
        Me.btnLoad.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnLoad.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnLoad.Location = New System.Drawing.Point(2, 180)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(123, 48)
        Me.btnLoad.TabIndex = 98
        Me.btnLoad.Tag = "38"
        Me.btnLoad.Text = "Load"
        '
        'lstLang
        '
        Me.lstLang.BackColor = System.Drawing.Color.White
        Me.lstLang.Columns.Add(Me.clmID)
        Me.lstLang.Columns.Add(Me.clmLanguage)
        Me.lstLang.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lstLang.FullRowSelect = True
        Me.lstLang.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstLang.Location = New System.Drawing.Point(3, 3)
        Me.lstLang.Name = "lstLang"
        Me.lstLang.Size = New System.Drawing.Size(390, 170)
        Me.lstLang.TabIndex = 97
        Me.lstLang.View = System.Windows.Forms.View.Details
        '
        'clmID
        '
        Me.clmID.Text = "ID"
        Me.clmID.Width = 53
        '
        'clmLanguage
        '
        Me.clmLanguage.Text = "Language"
        Me.clmLanguage.Width = 305
        '
        'frmLangSel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(398, 233)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.lstLang)
        Me.MaximizeBox = False
        Me.Name = "frmLangSel"
        Me.Text = "Language Selection"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents lstLang As System.Windows.Forms.ListView
    Friend WithEvents clmID As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmLanguage As System.Windows.Forms.ColumnHeader
End Class
