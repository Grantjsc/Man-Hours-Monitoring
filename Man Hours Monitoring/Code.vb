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