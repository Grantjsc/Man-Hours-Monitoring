Public Class Auto_Form

    Private Sub Auto_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
        TimerCheckTime.Enabled = True
        TimerDisplay.Enabled = True

        Get_DL_Employee() ' Get DL Employee from DLMasterlist Database
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateTimePicker1.Value = Date.Now.AddDays(-1)
        DateTimePicker2.Value = Date.Now
    End Sub

    Private Sub TimerCheckTime_Tick(sender As Object, e As EventArgs) Handles TimerCheckTime.Tick
        AutoTimer_Condition()
    End Sub

    Private Sub TimerDisplay_Tick(sender As Object, e As EventArgs) Handles TimerDisplay.Tick
        lblDate.Text = Date.Now.ToString("MMMM dd, yyyy")
        lblDay.Text = Date.Now.ToString("| dddd |")
        lblHrs.Text = Date.Now.ToString("- hh:mm:ss tt -")
    End Sub
End Class