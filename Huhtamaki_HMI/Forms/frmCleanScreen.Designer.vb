<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmCleanScreen
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCleanScreen))
        Me.tmrClean = New System.Windows.Forms.Timer(Me.components)
        Me.pbRemaining = New System.Windows.Forms.ProgressBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblTime = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblKremer = New System.Windows.Forms.Label
        Me.Labelthanks = New System.Windows.Forms.Label
        Me.picEaster = New System.Windows.Forms.PictureBox
        CType(Me.picEaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrClean
        '
        Me.tmrClean.Interval = 1000
        '
        'pbRemaining
        '
        Me.pbRemaining.Location = New System.Drawing.Point(19, 542)
        Me.pbRemaining.Maximum = 30
        Me.pbRemaining.Name = "pbRemaining"
        Me.pbRemaining.Size = New System.Drawing.Size(748, 30)
        Me.pbRemaining.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(66, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(344, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Tag = "56"
        Me.Label1.Text = "Cleanscreen closes in"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTime.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.lblTime.ForeColor = System.Drawing.Color.Black
        Me.lblTime.Location = New System.Drawing.Point(408, 34)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(72, 28)
        Me.lblTime.TabIndex = 3
        Me.lblTime.Text = "30"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(479, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 28)
        Me.Label3.TabIndex = 4
        Me.Label3.Tag = "57"
        Me.Label3.Text = "seconds !!"
        '
        'lblKremer
        '
        Me.lblKremer.BackColor = System.Drawing.Color.White
        Me.lblKremer.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.lblKremer.Location = New System.Drawing.Point(487, 575)
        Me.lblKremer.Name = "lblKremer"
        Me.lblKremer.Size = New System.Drawing.Size(280, 16)
        Me.lblKremer.TabIndex = 2
        Me.lblKremer.Text = "Industrial Automation Kremer BV "
        Me.lblKremer.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Labelthanks
        '
        Me.Labelthanks.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Labelthanks.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.Labelthanks.Location = New System.Drawing.Point(212, 75)
        Me.Labelthanks.Name = "Labelthanks"
        Me.Labelthanks.Size = New System.Drawing.Size(378, 50)
        Me.Labelthanks.TabIndex = 1
        Me.Labelthanks.Text = "THE KING IS ALIVE  !!"
        Me.Labelthanks.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picEaster
        '
        Me.picEaster.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.picEaster.Image = CType(resources.GetObject("picEaster.Image"), System.Drawing.Image)
        Me.picEaster.Location = New System.Drawing.Point(315, 137)
        Me.picEaster.Name = "picEaster"
        Me.picEaster.Size = New System.Drawing.Size(177, 205)
        Me.picEaster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picEaster.TabIndex = 0
        Me.picEaster.TabStop = False
        Me.picEaster.Visible = False
        '
        'frmCleanScreen
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.picEaster)
        Me.Controls.Add(Me.Labelthanks)
        Me.Controls.Add(Me.lblKremer)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbRemaining)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCleanScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCleanScreen"
        Me.TopMost = True
        CType(Me.picEaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrClean As System.Windows.Forms.Timer
    Friend WithEvents pbRemaining As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblKremer As System.Windows.Forms.Label
    Friend WithEvents Labelthanks As System.Windows.Forms.Label
    Friend WithEvents picEaster As System.Windows.Forms.PictureBox
End Class
