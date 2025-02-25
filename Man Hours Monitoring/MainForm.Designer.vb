<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblfooter2 = New System.Windows.Forms.Label()
        Me.lblfooter1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.UpdateEmailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.MasterPanel = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.TimerCloseProg = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Guna2ContextMenuStrip1.SuspendLayout()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SettingsToolStripMenuItem.Text = "Manual Saving"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClose.FillColor = System.Drawing.Color.Transparent
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageSize = New System.Drawing.Size(50, 50)
        Me.btnClose.Location = New System.Drawing.Point(637, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PressedColor = System.Drawing.Color.DarkGray
        Me.btnClose.PressedDepth = 0
        Me.btnClose.Size = New System.Drawing.Size(45, 45)
        Me.btnClose.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Impact", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(207, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(384, 43)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "DL Attendance Moniotring"
        '
        'lblfooter2
        '
        Me.lblfooter2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblfooter2.AutoSize = True
        Me.lblfooter2.BackColor = System.Drawing.Color.Transparent
        Me.lblfooter2.Font = New System.Drawing.Font("Nirmala UI", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfooter2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lblfooter2.Location = New System.Drawing.Point(9, 391)
        Me.lblfooter2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfooter2.Name = "lblfooter2"
        Me.lblfooter2.Size = New System.Drawing.Size(108, 12)
        Me.lblfooter2.TabIndex = 127
        Me.lblfooter2.Text = "© LF Philipines - TSG 2024"
        '
        'lblfooter1
        '
        Me.lblfooter1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblfooter1.AutoSize = True
        Me.lblfooter1.BackColor = System.Drawing.Color.Transparent
        Me.lblfooter1.Font = New System.Drawing.Font("Nirmala UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfooter1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lblfooter1.Location = New System.Drawing.Point(11, 380)
        Me.lblfooter1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfooter1.Name = "lblfooter1"
        Me.lblfooter1.Size = New System.Drawing.Size(133, 12)
        Me.lblfooter1.TabIndex = 126
        Me.lblfooter1.Text = "LITTELFUSE PHILIPPINES INC." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(693, 61)
        Me.Panel1.TabIndex = 9
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.UpdateEmailsToolStripMenuItem})
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(153, 48)
        '
        'UpdateEmailsToolStripMenuItem
        '
        Me.UpdateEmailsToolStripMenuItem.Name = "UpdateEmailsToolStripMenuItem"
        Me.UpdateEmailsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UpdateEmailsToolStripMenuItem.Text = "Update emails"
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.MasterPanel)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblfooter2)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblfooter1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Panel1)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(693, 413)
        Me.Guna2CustomGradientPanel1.TabIndex = 1
        '
        'MasterPanel
        '
        Me.MasterPanel.ContextMenuStrip = Me.Guna2ContextMenuStrip1
        Me.MasterPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MasterPanel.FillColor = System.Drawing.SystemColors.Control
        Me.MasterPanel.FillColor2 = System.Drawing.SystemColors.Control
        Me.MasterPanel.FillColor3 = System.Drawing.SystemColors.Control
        Me.MasterPanel.FillColor4 = System.Drawing.SystemColors.Control
        Me.MasterPanel.Location = New System.Drawing.Point(0, 61)
        Me.MasterPanel.Name = "MasterPanel"
        Me.MasterPanel.Size = New System.Drawing.Size(693, 352)
        Me.MasterPanel.TabIndex = 128
        '
        'TimerCloseProg
        '
        '
        'NotifyIcon
        '
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "Man Hours Monitoring"
        Me.NotifyIcon.Visible = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 413)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Guna2ContextMenuStrip1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblfooter2 As Label
    Friend WithEvents lblfooter1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents MasterPanel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents TimerCloseProg As Timer
    Friend WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents UpdateEmailsToolStripMenuItem As ToolStripMenuItem
End Class
