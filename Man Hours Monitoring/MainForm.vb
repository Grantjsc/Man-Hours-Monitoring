Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(110, 0, 0, 0)

        TimerCloseProg.Enabled = True
        'LoadManual()
        LoadAuto()
    End Sub
    Private Sub TimerCloseProg_Tick(sender As Object, e As EventArgs) Handles TimerCloseProg.Tick
        Me.Hide()
        TimerCloseProg.Enabled = False
    End Sub

    Private Sub NotifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        LoadManual()
    End Sub

    Private Sub UpdateEmailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateEmailsToolStripMenuItem.Click
        LoadEmailsForm()
    End Sub
End Class