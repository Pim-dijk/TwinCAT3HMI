<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmUsers
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
        Me.btnOK = New System.Windows.Forms.Button
        Me.lstUsers = New System.Windows.Forms.ListView
        Me.clmUser = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.txtNewLogin = New System.Windows.Forms.Button
        Me.txtConfirmLogin = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.Location = New System.Drawing.Point(229, 179)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(123, 48)
        Me.btnCancel.TabIndex = 99
        Me.btnCancel.Tag = "39"
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnOK.Location = New System.Drawing.Point(78, 179)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(123, 48)
        Me.btnOK.TabIndex = 98
        Me.btnOK.Tag = "68"
        Me.btnOK.Text = "OK"
        '
        'lstUsers
        '
        Me.lstUsers.BackColor = System.Drawing.Color.White
        Me.lstUsers.Columns.Add(Me.clmUser)
        Me.lstUsers.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lstUsers.FullRowSelect = True
        Me.lstUsers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstUsers.Location = New System.Drawing.Point(3, 3)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(203, 170)
        Me.lstUsers.TabIndex = 97
        Me.lstUsers.View = System.Windows.Forms.View.Details
        '
        'clmUser
        '
        Me.clmUser.Text = "User"
        Me.clmUser.Width = 200
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(222, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 22)
        Me.Label1.Tag = "71"
        Me.Label1.Text = "New Login code:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(222, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 22)
        Me.Label2.Tag = "72"
        Me.Label2.Text = "Confirm Login code:"
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Tahoma", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblUser.Location = New System.Drawing.Point(212, 7)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(204, 22)
        Me.lblUser.Tag = "69"
        Me.lblUser.Text = "User"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNewLogin
        '
        Me.txtNewLogin.BackColor = System.Drawing.Color.White
        Me.txtNewLogin.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtNewLogin.Location = New System.Drawing.Point(221, 75)
        Me.txtNewLogin.Name = "txtNewLogin"
        Me.txtNewLogin.Size = New System.Drawing.Size(182, 26)
        Me.txtNewLogin.TabIndex = 107
        Me.txtNewLogin.Text = "****"
        '
        'txtConfirmLogin
        '
        Me.txtConfirmLogin.BackColor = System.Drawing.Color.White
        Me.txtConfirmLogin.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtConfirmLogin.Location = New System.Drawing.Point(221, 147)
        Me.txtConfirmLogin.Name = "txtConfirmLogin"
        Me.txtConfirmLogin.Size = New System.Drawing.Size(182, 26)
        Me.txtConfirmLogin.TabIndex = 108
        Me.txtConfirmLogin.Text = "****"
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(417, 233)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtConfirmLogin)
        Me.Controls.Add(Me.txtNewLogin)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lstUsers)
        Me.MaximizeBox = False
        Me.Name = "frmUsers"
        Me.Text = "Login Code Users"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lstUsers As System.Windows.Forms.ListView
    Friend WithEvents clmUser As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents txtNewLogin As System.Windows.Forms.Button
    Friend WithEvents txtConfirmLogin As System.Windows.Forms.Button
End Class
