Imports System.Threading

Public Class Loading_Form
    Private Sub Loading_Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        Thread.Sleep(3000)

        Get_DL_Employee() ' Get DL Employee from DLMasterlist Database

        Get_InOut(Form1.DateTimePicker1.Value) 'Get all data yesterday
        Day_Insert_AccessCodes() 'insert all access code to DayShift_tb
        Night_Insert_AccessCodes() 'insert all access code to NightShift_tb

        Day_Update_TimeIn()
        Day_Update_TimeOut()
        DeleteDay()
        UpdateShiftType_Day()

        Day_Get_EmployeeDetails()
        Update_Date_Day()

        Night_Update_TimeIn()

        Get_InOut(Form1.DateTimePicker2.Value) ' Get the time out for Night Shift
        Night_Update_TimeOut()
        DeleteNight()
        UpdateShiftType_Night()

        Night_Get_EmployeeDetails()
        Update_Date_Night()

        UpdateManHours_Day() ' Man Hours computation
        UpdateManHours_Night() ' Man Hours computation

        'TransferDataToMasterList_Dayshift()
        'DeleteRecords_Day()

        'TransferDataToMasterList_Nightshift()
        'DeleteRecords_Night()

        MsgBox("Done getting the data of time in and time out for " & DateForEmail & "!")
        ''Form1.Close()

        'GetDepartmentsWithNullTimes(TimeIn_Date)

        'If departments.Count > 0 Then
        '    'Console.WriteLine("Departments with missing Time_In/Time_Out: " & vbCrLf & "- " & String.Join(vbCrLf & "- ", departments))
        '    Send_Email()
        'Else
        '    Console.WriteLine("No missing entries found for " & DateForEmail)
        'End If

        Me.Close()
    End Sub
End Class