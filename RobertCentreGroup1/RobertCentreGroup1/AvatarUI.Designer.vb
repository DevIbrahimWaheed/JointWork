<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AvatarUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Home = New System.Windows.Forms.Button()
        Me.NavPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NavPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Home
        '
        Me.Home.BackColor = System.Drawing.Color.DarkViolet
        Me.Home.BackgroundImage = Global.RobertCentreGroup1.My.Resources.Resources.HomeLogo
        Me.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo
        Me.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Home.Location = New System.Drawing.Point(42, 3)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(213, 145)
        Me.Home.TabIndex = 0
        Me.Home.UseVisualStyleBackColor = False
        '
        'NavPanel
        '
        Me.NavPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.NavPanel.Controls.Add(Me.Label1)
        Me.NavPanel.Controls.Add(Me.Home)
        Me.NavPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.NavPanel.Location = New System.Drawing.Point(0, 0)
        Me.NavPanel.Name = "NavPanel"
        Me.NavPanel.Size = New System.Drawing.Size(1200, 160)
        Me.NavPanel.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kristen ITC", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(403, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(685, 88)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose Your Avatar"
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.PictureBox1.BackgroundImage = Global.RobertCentreGroup1.My.Resources.Resources.AvaterEU
        Me.PictureBox1.Location = New System.Drawing.Point(69, 229)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(261, 269)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'AvatarUI
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NavPanel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AvatarUI"
        Me.Text = "AvatarUI"
        Me.NavPanel.ResumeLayout(False)
        Me.NavPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Home As System.Windows.Forms.Button
    Friend WithEvents NavPanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
