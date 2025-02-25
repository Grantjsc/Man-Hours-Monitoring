Imports System.Configuration
Imports System.Net.Mail

Module Function_Module

    Public Year As String = Date.Now.ToString("yyyy")
    Public Month As String = Date.Now.ToString("MMMM")
    Public DateToday As String = Date.Now.ToString("dd")
    Public DT As String = Date.Now.ToString("MM")
    Public FolderPath_Day As String = "C:\Backup\Man Hours Monitoring\" & Year & "\" & Month & "\" & Month & "Fuse Resistance Buy-off Biometric History.csv"

    Sub ExportDaySHift()

    End Sub

    Sub LoadManual()
        With Form1
            .TopLevel = False
            MainForm.MasterPanel.Controls.Add(Form1)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With
    End Sub

    Sub LoadAuto()
        With Auto_Form
            .TopLevel = False
            MainForm.MasterPanel.Controls.Add(Auto_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With
    End Sub

    Sub LoadEmailsForm()
        With Emails_Form
            .TopLevel = False
            MainForm.MasterPanel.Controls.Add(Emails_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With
    End Sub


    '============================= < CODE FOR AUTO_FORM > ===================================

    Public CheckOnce As Boolean = False

    Sub AutoTimer_Condition()
        Dim currentTime As DateTime = DateTime.Now

        'If (currentTime.TimeOfDay >= New TimeSpan(11, 30, 0) AndAlso currentTime.TimeOfDay < New TimeSpan(12, 0, 0)) Then
        'If currentTime.Hour = 11 AndAlso currentTime.Minute = 30 Then

        If (currentTime.TimeOfDay >= New TimeSpan(11, 30, 0) AndAlso currentTime.TimeOfDay < New TimeSpan(12, 0, 0)) Then

            If CheckOnce = False Then
                CheckOnce = True

                Auto_CheckDate()

                'Get_DL_Employee() ' Get DL Employee from DLMasterlist Database

                'Get_InOut(DateTimePicker1.Value) 'Get all data yesterday
                'Day_Insert_AccessCodes() 'insert all access code to DayShift_tb
                'Night_Insert_AccessCodes() 'insert all access code to NightShift_tb

                'Day_Update_TimeIn()
                'Day_Update_TimeOut()
                'DeleteDay()
                'UpdateShiftType_Day()

                'Day_Get_EmployeeDetails()
                'Update_Date_Day()

                'Night_Update_TimeIn()

                'Get_InOut(DateTimePicker2.Value) ' Get the time out for Night Shift
                'Night_Update_TimeOut()
                'DeleteNight()
                'UpdateShiftType_Night()

                'Night_Get_EmployeeDetails()
                'Update_Date_Night()

                'TransferDataToMasterList_Dayshift()
                'DeleteRecords_Day()

                'TransferDataToMasterList_Nightshift()
                'DeleteRecords_Night()

                'Console.WriteLine("Done getting the data of time in and time out for " & TimeIn_Date & "!")
            End If

        Else
            CheckOnce = False
            Console.WriteLine("The Time is not 11:30 AM - 12:00 NN!")
        End If
    End Sub


    '============================= < CODE FOR Form1 / MANUAL > ===================================

    Sub Manual_Transfer()
        Dim tdy As String = Date.Now.ToString("MM/dd/yyyy")

        Dim result As DialogResult = MsgBox("Please ensure that your request is not duplicated for today's date." & vbNewLine & vbNewLine &
                                            "Date today: " & tdy & vbNewLine &
                                            "Request date: " & Form1.DateTimePicker1.Value.Date, MsgBoxStyle.OkCancel)


        If result = DialogResult.OK Then

            Manual_CheckDate()

            'Get_DL_Employee() ' Get DL Employee from DLMasterlist Database

            'Get_InOut(DateTimePicker1.Value) 'Get all data yesterday
            'Day_Insert_AccessCodes() 'insert all access code to DayShift_tb
            'Night_Insert_AccessCodes() 'insert all access code to NightShift_tb

            'Day_Update_TimeIn()
            'Day_Update_TimeOut()
            'DeleteDay()
            'UpdateShiftType_Day()

            'Day_Get_EmployeeDetails()
            'Update_Date_Day()

            'Night_Update_TimeIn()

            'Get_InOut(DateTimePicker2.Value) ' Get the time out for Night Shift
            'Night_Update_TimeOut()
            'DeleteNight()
            'UpdateShiftType_Night()

            'Night_Get_EmployeeDetails()
            'Update_Date_Night()

            'TransferDataToMasterList_Dayshift()
            'DeleteRecords_Day()

            'TransferDataToMasterList_Nightshift()
            'DeleteRecords_Night()

            'MsgBox("Done getting the data of time in and time out for " & TimeIn_Date & "!")
            'Me.Close()

        ElseIf result = DialogResult.Cancel Then
            Exit Sub
        End If
    End Sub
End Module

Module AppConfig_Module

    Public config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

    Public Supervisors_Emails As String
    Public New_Emails As String
    '=======================< Get Supervisors Email >=======================
    Sub Get_SupervisorsEmail()
        Dim value As String = System.Configuration.ConfigurationManager.AppSettings("SP_Emails")
        Console.WriteLine("SP Emails: " & value)

        Supervisors_Emails = value
    End Sub

    '=======================< Update Supervisors Email >=======================
    Sub Update_Supervisors_Email()
        config.AppSettings.Settings("SP_Emails").Value = New_Emails
        config.Save(ConfigurationSaveMode.Modified)

        ConfigurationManager.RefreshSection("appSettings")
    End Sub
End Module

Module Send_Email_Module
    Public Email As MailMessage

    Sub Send_Email()

        Get_SupervisorsEmail()

        Dim news_Mes As String
        news_Mes = "Here's the list of departments that have a missing time in/time out on <b>" & DateForEmail & "</b>:"
        Dim Department_List As String = "- " & String.Join("<br>" & "- ", departments)

        Dim Body_Mes As String = news_Mes & "<br>" & "<br>" & Department_List

        Try
            'Dim EmailAdd As String = "gcatapang@littelfuse.com; bmadlangbayan@littelfuse.com; jburog@littelfuse.com; mroxas2@littelfuse.com"
            Dim Recipients As String() = Supervisors_Emails.Split(";"c)
            Dim SMTP As New SmtpClient

            Email = New MailMessage

            For Each Reciever As String In Recipients
                Email.To.Add(New MailAddress(Reciever.ToString()))
            Next


            Email.From = New MailAddress("ProductivityMonitoring@littelfuse.com")
            Email.Subject = "Departments with Missing Time In/Time Out"
            Email.Body = "<div style='font-family: Arial, sans-serif; font-size: 12pt;'>Good day,<br><br>" &
                                     Body_Mes &
                                    "<br></div>
                          <br> <small style='color:Gray;'><i> This is a system generated mail. Please do not reply.</i></small>"
            Email.IsBodyHtml = True
            ' Set high importance
            Email.Priority = MailPriority.High

            'AddHandler SMTP.SendCompleted, AddressOf SendCompletedCallback

            SMTP.Host = "mailrelay.america.littelfuse.com"
            SMTP.SendAsync(Email, Nothing)

            'departments.Clear()

        Catch ex As Exception

            Console.WriteLine("An error occurred: " & ex.Message)
        End Try
    End Sub
End Module