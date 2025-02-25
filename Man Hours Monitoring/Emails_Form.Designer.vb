<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Emails_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Emails_Form))
        Me.Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel2.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2CustomGradientPanel2
        '
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Guna2GroupBox1)
        Me.Guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CustomGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Me.Guna2CustomGradientPanel2.Size = New System.Drawing.Size(693, 352)
        Me.Guna2CustomGradientPanel2.TabIndex = 174
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.BorderRadius = 15
        Me.Guna2GroupBox1.BorderThickness = 5
        Me.Guna2GroupBox1.Controls.Add(Me.btnClose)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.btnUpdate)
        Me.Guna2GroupBox1.Controls.Add(Me.txtEmail)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(25, 12)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(639, 317)
        Me.Guna2GroupBox1.TabIndex = 171
        Me.Guna2GroupBox1.Text = "Recipient"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BorderColor = System.Drawing.Color.Transparent
        Me.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClose.FillColor = System.Drawing.Color.Transparent
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnClose.Location = New System.Drawing.Point(13, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.PressedColor = System.Drawing.Color.Transparent
        Me.btnClose.Size = New System.Drawing.Size(38, 37)
        Me.btnClose.TabIndex = 174
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(103, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(283, 17)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Note: (don't put a semicolon on the last recipient)"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnUpdate.BorderRadius = 10
        Me.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdate.FillColor = System.Drawing.Color.Orange
        Me.btnUpdate.FillColor2 = System.Drawing.Color.Moccasin
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(269, 248)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.ShadowDecoration.BorderRadius = 10
        Me.btnUpdate.ShadowDecoration.Depth = 17
        Me.btnUpdate.ShadowDecoration.Enabled = True
        Me.btnUpdate.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.btnUpdate.Size = New System.Drawing.Size(104, 38)
        Me.btnUpdate.TabIndex = 88
        Me.btnUpdate.Text = "Update"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.Transparent
        Me.txtEmail.BorderColor = System.Drawing.Color.Black
        Me.txtEmail.BorderRadius = 20
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(45, 84)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(6)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PlaceholderText = ""
        Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.ShadowDecoration.BorderRadius = 20
        Me.txtEmail.ShadowDecoration.Depth = 15
        Me.txtEmail.ShadowDecoration.Enabled = True
        Me.txtEmail.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.txtEmail.Size = New System.Drawing.Size(557, 141)
        Me.txtEmail.TabIndex = 86
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(45, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 26)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Email:"
        '
        'Emails_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 352)
        Me.Controls.Add(Me.Guna2CustomGradientPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Emails_Form"
        Me.Text = "Emails_Form"
        Me.Guna2CustomGradientPanel2.ResumeLayout(False)
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
End Class
