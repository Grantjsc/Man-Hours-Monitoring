Public Class Emails_Form
    Private Sub Emails_Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Get_SupervisorsEmail()

        txtEmail.Text = Supervisors_Emails
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(txtEmail.Text) Then
            MsgBox("Please enter email address", MsgBoxStyle.Critical)
        Else
            New_Emails = txtEmail.Text
            Update_Supervisors_Email()
            MsgBox("Emails are now up to date", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub
End Class