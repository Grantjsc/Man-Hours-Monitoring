﻿Imports System.Data.OleDb
Imports System.Data.SqlClient

Module DEV_Query

    Public Dev_connString As String = "Data Source=BTMESSQLDEV03;Initial Catalog=ProdMonitoring;Persist Security Info=True;User ID=mesph;Password=PHFuse;TrustServerCertificate=True"
    Public Dev_Dbconnection As New SqlConnection(Dev_connString)

    Sub Dev_ConOpen()
        If Dev_Dbconnection.State = ConnectionState.Closed Then
            Dev_Dbconnection.Open()
        End If
    End Sub

    Sub Dev_ConClose()
        If Dev_Dbconnection.State = ConnectionState.Open Then
            Dev_Dbconnection.Close()
        End If
    End Sub
    Sub TransferDataToMasterList_Dayshift()
        Try
            ' Open MS Access Connection
            ACC_ConOpen()

            ' Open SQL Server Connection
            Dev_ConOpen()

            ' Step 1: Retrieve data from DayShift_tb in MS Access
            Dim selectQuery As String = "SELECT AccessCode, Employee_Code, [_Date], Time_In, Time_Out, ShiftType, Cost_Center, Manpower_Category, Department FROM DayShift_tb"
            Using accessCmd As New OleDbCommand(selectQuery, ACCDbconnection)
                Using reader As OleDbDataReader = accessCmd.ExecuteReader()
                    If reader.HasRows Then
                        ' Step 2: Prepare SQL Server Insert Query
                        Dim insertQuery As String = "INSERT INTO ProdMon_MasterList_tb (AccessCode, Employee_Code, [_Date], Time_In, Time_Out, ShiftType, Cost_Center, Manpower_Category, Department) " &
                                                "VALUES (@AccessCode, @EmployeeCode, @_Date, @TimeIn, @TimeOut, @ShiftType, @CostCenter, @ManpowerCategory, @Department)"

                        Using sqlCmd As New SqlCommand(insertQuery, Dev_Dbconnection)
                            ' Add parameters for SQL Server
                            sqlCmd.Parameters.Add("@AccessCode", SqlDbType.VarChar)
                            sqlCmd.Parameters.Add("@EmployeeCode", SqlDbType.VarChar)
                            sqlCmd.Parameters.Add("@_Date", SqlDbType.Date)
                            sqlCmd.Parameters.Add("@TimeIn", SqlDbType.DateTime)
                            sqlCmd.Parameters.Add("@TimeOut", SqlDbType.DateTime)
                            sqlCmd.Parameters.Add("@ShiftType", SqlDbType.VarChar)
                            sqlCmd.Parameters.Add("@CostCenter", SqlDbType.VarChar)
                            sqlCmd.Parameters.Add("@ManpowerCategory", SqlDbType.VarChar)
                            sqlCmd.Parameters.Add("@Department", SqlDbType.VarChar)

                            ' Step 3: Process Each Record
                            While reader.Read()
                                sqlCmd.Parameters("@AccessCode").Value = reader("AccessCode")
                                sqlCmd.Parameters("@EmployeeCode").Value = reader("Employee_Code")
                                sqlCmd.Parameters("@_Date").Value = CDate(reader("_Date"))
                                sqlCmd.Parameters("@TimeIn").Value = If(IsDBNull(reader("Time_In")), DBNull.Value, reader("Time_In"))
                                sqlCmd.Parameters("@TimeOut").Value = If(IsDBNull(reader("Time_Out")), DBNull.Value, reader("Time_Out"))
                                sqlCmd.Parameters("@ShiftType").Value = reader("ShiftType")
                                sqlCmd.Parameters("@CostCenter").Value = reader("Cost_Center")
                                sqlCmd.Parameters("@ManpowerCategory").Value = reader("Manpower_Category")
                                sqlCmd.Parameters("@Department").Value = reader("Department")

                                ' Execute Insert for Each Row
                                sqlCmd.ExecuteNonQuery()
                            End While
                        End Using
                    End If
                End Using
            End Using

            Debug.WriteLine("Data transfer completed successfully.")

        Catch ex As Exception
            Debug.WriteLine("Error transferring data: " & ex.Message)
        Finally
            ' Close both connections
            ACC_ConClose()
            Dev_ConClose()
        End Try
    End Sub


    Sub TransferDataToMasterList_Nightshift()
        Try
            ' Open MS Access Connection
            ACC_ConOpen()

            ' Open SQL Server Connection
            Dev_ConOpen()

            ' Step 1: Retrieve data from DayShift_tb in MS Access
            Dim selectQuery As String = "SELECT AccessCode, Employee_Code, [_Date], Time_In, Time_Out, ShiftType, Cost_Center, Manpower_Category, Department FROM NightShift_tb"
            Using accessCmd As New OleDbCommand(selectQuery, ACCDbconnection)
                Using reader As OleDbDataReader = accessCmd.ExecuteReader()
                    If reader.HasRows Then
                        ' Step 2: Prepare SQL Server Insert Query
                        Dim insertQuery As String = "INSERT INTO ProdMon_MasterList_tb (AccessCode, Employee_Code, [_Date], Time_In, Time_Out, ShiftType, Cost_Center, Manpower_Category, Department) " &
                                                "VALUES (@AccessCode, @EmployeeCode, @_Date, @TimeIn, @TimeOut, @ShiftType, @CostCenter, @ManpowerCategory, @Department)"

                        Using sqlCmd As New SqlCommand(insertQuery, Dev_Dbconnection)
                            ' Add parameters for SQL Server
                            sqlCmd.Parameters.Add("@AccessCode", SqlDbType.VarChar)
                            sqlCmd.Parameters.Add("@EmployeeCode", SqlDbType.VarChar)
                            sqlCmd.Parameters.Add("@_Date", SqlDbType.Date)
                            sqlCmd.Parameters.Add("@TimeIn", SqlDbType.DateTime)
                            sqlCmd.Parameters.Add("@TimeOut", SqlDbType.DateTime)
                            sqlCmd.Parameters.Add("@ShiftType", SqlDbType.VarChar)
                            sqlCmd.Parameters.Add("@CostCenter", SqlDbType.VarChar)
                            sqlCmd.Parameters.Add("@ManpowerCategory", SqlDbType.VarChar)
                            sqlCmd.Parameters.Add("@Department", SqlDbType.VarChar)

                            ' Step 3: Process Each Record
                            While reader.Read()
                                sqlCmd.Parameters("@AccessCode").Value = reader("AccessCode")
                                sqlCmd.Parameters("@EmployeeCode").Value = reader("Employee_Code")
                                sqlCmd.Parameters("@_Date").Value = CDate(reader("_Date"))
                                sqlCmd.Parameters("@TimeIn").Value = If(IsDBNull(reader("Time_In")), DBNull.Value, reader("Time_In"))
                                sqlCmd.Parameters("@TimeOut").Value = If(IsDBNull(reader("Time_Out")), DBNull.Value, reader("Time_Out"))
                                sqlCmd.Parameters("@ShiftType").Value = reader("ShiftType")
                                sqlCmd.Parameters("@CostCenter").Value = reader("Cost_Center")
                                sqlCmd.Parameters("@ManpowerCategory").Value = reader("Manpower_Category")
                                sqlCmd.Parameters("@Department").Value = reader("Department")

                                ' Execute Insert for Each Row
                                sqlCmd.ExecuteNonQuery()
                            End While
                        End Using
                    End If
                End Using
            End Using

            Debug.WriteLine("Data transfer completed successfully.")

        Catch ex As Exception
            Debug.WriteLine("Error transferring data: " & ex.Message)
        Finally
            ' Close both connections
            ACC_ConClose()
            Dev_ConClose()
        End Try
    End Sub

    Sub Manual_CheckDate()

        Try

            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            'SQLDbconnection.Open()
            Dev_ConOpen()

            ' Define the SQL query with a parameter placeholder
            MyData = "SELECT * From ProdMon_MasterList_tb WHERE [_Date] LIKE @dt"
            cmd.Connection = Dev_Dbconnection
            cmd.CommandText = MyData

            ' Add the parameter value with wildcard characters
            cmd.Parameters.AddWithValue("@dt", "%" & Form1.DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") & "%")

            adap.SelectCommand = cmd
            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                MsgBox("This date has already been recorded in the system!", MsgBoxStyle.Critical)

            Else
                'MsgBox("This date doesn't exist.", MsgBoxStyle.Information)

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

                TransferDataToMasterList_Dayshift()
                DeleteRecords_Day()

                TransferDataToMasterList_Nightshift()
                DeleteRecords_Night()

                MsgBox("Done getting the data of time in and time out for " & TimeIn_Date & "!")
                Form1.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            Dev_ConClose()
        End Try
    End Sub

    Sub Auto_CheckDate()

        Try

            Dim MyData As String
            Dim cmd As New SqlCommand
            Dim Data As New DataTable
            Dim adap As New SqlDataAdapter
            'SQLDbconnection.Open()
            Dev_ConOpen()

            ' Define the SQL query with a parameter placeholder
            MyData = "SELECT * From ProdMon_MasterList_tb WHERE [_Date] LIKE @dt"
            cmd.Connection = Dev_Dbconnection
            cmd.CommandText = MyData

            ' Add the parameter value with wildcard characters
            cmd.Parameters.AddWithValue("@dt", "%" & Auto_Form.DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") & "%")

            adap.SelectCommand = cmd
            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                MsgBox("This date has already been recorded in the system!", MsgBoxStyle.Critical)

            Else
                'MsgBox("This date doesn't exist.", MsgBoxStyle.Information)

                Get_DL_Employee() ' Get DL Employee from DLMasterlist Database

                Get_InOut(Auto_Form.DateTimePicker1.Value) 'Get all data yesterday
                Day_Insert_AccessCodes() 'insert all access code to DayShift_tb
                Night_Insert_AccessCodes() 'insert all access code to NightShift_tb

                Day_Update_TimeIn()
                Day_Update_TimeOut()
                DeleteDay()
                UpdateShiftType_Day()

                Day_Get_EmployeeDetails()
                Update_Date_Day()

                Night_Update_TimeIn()

                Get_InOut(Auto_Form.DateTimePicker2.Value) ' Get the time out for Night Shift
                Night_Update_TimeOut()
                DeleteNight()
                UpdateShiftType_Night()

                Night_Get_EmployeeDetails()
                Update_Date_Night()

                TransferDataToMasterList_Dayshift()
                DeleteRecords_Day()

                TransferDataToMasterList_Nightshift()
                DeleteRecords_Night()

                Console.WriteLine("Done getting the data of time in and time out for " & TimeIn_Date & "!")

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            'SQLDbconnection.Close()
            Dev_ConClose()
        End Try
    End Sub

End Module