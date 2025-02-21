<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Auto_Form
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.TimerCheckTime = New System.Windows.Forms.Timer(Me.components)
        Me.TimerDisplay = New System.Windows.Forms.Timer(Me.components)
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblHrs = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2CustomGradientPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(161, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 25)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "Yesterday"
        Me.Label1.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(19, 284)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 12)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "© LF Philipines - TSG 2025"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.BackColor = System.Drawing.Color.Transparent
        Me.DateTimePicker2.BorderRadius = 10
        Me.DateTimePicker2.Checked = True
        Me.DateTimePicker2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.ForeColor = System.Drawing.Color.White
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(351, 36)
        Me.DateTimePicker2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 36)
        Me.DateTimePicker2.TabIndex = 164
        Me.DateTimePicker2.Value = New Date(2025, 2, 17, 0, 0, 0, 0)
        Me.DateTimePicker2.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.BackColor = System.Drawing.Color.Transparent
        Me.DateTimePicker1.BorderRadius = 10
        Me.DateTimePicker1.Checked = True
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.ForeColor = System.Drawing.Color.White
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(110, 36)
        Me.DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 36)
        Me.DateTimePicker1.TabIndex = 158
        Me.DateTimePicker1.Value = New Date(2025, 2, 16, 0, 0, 0, 0)
        Me.DateTimePicker1.Visible = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(21, 273)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 12)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "LITTELFUSE PHILIPPINES INC." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(418, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 25)
        Me.Label2.TabIndex = 167
        Me.Label2.Text = "Today"
        Me.Label2.Visible = False
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.BorderRadius = 15
        Me.Guna2GroupBox1.BorderThickness = 5
        Me.Guna2GroupBox1.Controls.Add(Me.lblDay)
        Me.Guna2GroupBox1.Controls.Add(Me.lblDate)
        Me.Guna2GroupBox1.Controls.Add(Me.lblHrs)
        Me.Guna2GroupBox1.Controls.Add(Me.Label1)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.Guna2GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.CustomBorderThickness = New System.Windows.Forms.Padding(0)
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(25, 12)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(639, 317)
        Me.Guna2GroupBox1.TabIndex = 171
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
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
        Me.Guna2CustomGradientPanel2.TabIndex = 173
        '
        'TimerCheckTime
        '
        Me.TimerCheckTime.Interval = 1000
        '
        'TimerDisplay
        '
        '
        'lblDay
        '
        Me.lblDay.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDay.BackColor = System.Drawing.Color.Transparent
        Me.lblDay.Font = New System.Drawing.Font("Lucida Fax", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDay.Location = New System.Drawing.Point(166, 141)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(291, 30)
        Me.lblDay.TabIndex = 169
        Me.lblDay.Text = "Day"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDate.Location = New System.Drawing.Point(166, 190)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(291, 19)
        Me.lblDate.TabIndex = 168
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHrs
        '
        Me.lblHrs.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHrs.BackColor = System.Drawing.Color.Transparent
        Me.lblHrs.Font = New System.Drawing.Font("Lucida Fax", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHrs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblHrs.Location = New System.Drawing.Point(105, 75)
        Me.lblHrs.Name = "lblHrs"
        Me.lblHrs.Size = New System.Drawing.Size(412, 75)
        Me.lblHrs.TabIndex = 170
        Me.lblHrs.Text = "00:00:00 tt"
        Me.lblHrs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Auto_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 352)
        Me.Controls.Add(Me.Guna2CustomGradientPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Auto_Form"
        Me.Text = "Auto_Form"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.Guna2CustomGradientPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents TimerCheckTime As Timer
    Friend WithEvents TimerDisplay As Timer
    Friend WithEvents lblDay As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblHrs As Label
End Class
