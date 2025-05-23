﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Date.Now.AddDays(-1)
        DateTimePicker2.Value = Date.Now

        TimerForBtn.Enabled = True

        Get_DL_Employee() ' Get DL Employee from DLMasterlist Database
    End Sub

    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGetDS.Click
        Get_InOut(DateTimePicker1.Value)
    End Sub

    Private Sub btnRecDS_Click(sender As Object, e As EventArgs) Handles btnRecDS.Click
        Day_Insert_AccessCodes()

        Day_Update_TimeIn()
        Day_Update_TimeOut()
        DeleteDay()
        UpdateShiftType_Day()
    End Sub

    Private Sub btnUpdateDS_Click(sender As Object, e As EventArgs) Handles btnUpdateDS.Click
        Day_Get_EmployeeDetails()
        Update_Date_Day()
    End Sub

    Private Sub btnGetNS_Click(sender As Object, e As EventArgs) Handles btnGetNS.Click
        Get_InOut(DateTimePicker1.Value)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Night_Insert_AccessCodes()

        Night_Update_TimeIn()

        Get_InOut(DateTimePicker2.Value) ' Get the time out for Night Shift
        Night_Update_TimeOut()
        DeleteNight()
        UpdateShiftType_Night()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Night_Get_EmployeeDetails()
        Update_Date_Night()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'TransferDataToMasterList_Dayshift()
        'DeleteRecords_Day()

        'TransferDataToMasterList_Nightshift()
        'DeleteRecords_Night()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub TimerForBtn_Tick(sender As Object, e As EventArgs) Handles TimerForBtn.Tick
        Dim currentTime As DateTime = DateTime.Now

        If (currentTime.TimeOfDay >= New TimeSpan(11, 40, 0) AndAlso currentTime.TimeOfDay < New TimeSpan(12, 0, 0)) Then
            btnTransfer.Enabled = True
        Else
            btnTransfer.Enabled = False
        End If
    End Sub

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        Manual_Transfer()
    End Sub
End Class
