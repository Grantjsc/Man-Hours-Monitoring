Imports System.Data.OleDb
Imports System.Reflection.Emit

Module MAsterListQuery_Module
    Public MLconnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\WIA\DLMasterlist.accdb;Persist Security Info=True;Jet OLEDB:Database Password=p25!"
    Public MLDbconnection As New OleDbConnection(MLconnString)

    Sub ML_ConOpen()
        If MLDbconnection.State = ConnectionState.Closed Then
            MLDbconnection.Open()
        End If
    End Sub

    Sub ML_ConClose()
        If MLDbconnection.State = ConnectionState.Open Then
            MLDbconnection.Close()
        End If
    End Sub

    Public DL_Employee_List As New List(Of String)()
    Sub Get_DL_Employee()
        Try
            DL_Employee_List.Clear()

            Dim query As String = "SELECT Access_Code FROM AccessCode_tb"

            ML_ConOpen()

            Using command As New OleDbCommand(query, MLDbconnection)
                Using reader As OleDbDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim EmpCode As String = reader("Access_Code").ToString()

                        DL_Employee_List.Add(EmpCode)
                        ' Print to Console
                        Console.WriteLine($"Employee Code: {EmpCode}")
                    End While
                End Using
            End Using

            ML_ConClose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Code_List As New List(Of String)()
    Public AccCode_List As New List(Of String)()

    '******************************************< Saving Day Shift >**********************************
    Sub Day_Get_EmployeeDetails()
        Try
            ' Open ACC Database Connection
            ML_ConOpen()

            ' Loop through Code_List to get Employee Details
            For i As Integer = 0 To DL_Employee_List.Count - 1
                Dim accessCode As String = DL_Employee_List(i) ' Get corresponding AccessCode

                ' SQL Query to fetch employee details
                Dim query As String = "SELECT Code, Manpower_Category, Cost_Center_Code, Department " &
                                  "FROM AccessCode_tb WHERE Access_Code = ?"

                Using cmd As New OleDbCommand(query, MLDbconnection)
                    cmd.Parameters.AddWithValue("?", accessCode)

                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim employeeCode As String = reader("Code").ToString()
                            Dim manpowerCategory As String = reader("Manpower_Category").ToString()
                            Dim costCenter As String = reader("Cost_Center_Code").ToString()
                            Dim Depart As String = reader("Department").ToString()

                            ' Call Update_AccessCodeTB using AccessCode as reference
                            Day_Update_AccessCodeTB(accessCode, employeeCode, costCenter, manpowerCategory, Depart)
                        End If
                    End Using
                End Using
            Next

            ' Close ACC Database Connection
            ML_ConClose()

        Catch ex As Exception
            Debug.WriteLine("Error retrieving employee details: " & ex.Message)
        End Try
    End Sub

    Sub Day_Update_AccessCodeTB(accessCode As String, empCode As String, costCenter As String, manpowerCategory As String, Depart As String)
        Try
            ' Open the ML Database connection
            ACC_ConOpen()

            ' Update query for AccessCode_tb using Access_Code as reference
            Dim updateQuery As String = "UPDATE DayShift_tb SET " &
                                        "Employee_Code = ?, Cost_Center = ?, " &
                                        "Manpower_Category = ?, Department = ? " &
                                        "WHERE AccessCode = ?"

            Using cmd As New OleDbCommand(updateQuery, ACCDbconnection)
                cmd.Parameters.AddWithValue("?", empCode)
                cmd.Parameters.AddWithValue("?", costCenter)
                cmd.Parameters.AddWithValue("?", manpowerCategory)
                cmd.Parameters.AddWithValue("?", Depart)
                cmd.Parameters.AddWithValue("?", accessCode) ' Reference column

                Dim rowsUpdated As Integer = cmd.ExecuteNonQuery()
                Debug.WriteLine($"Updated {rowsUpdated} row(s) for Access_Code: {accessCode}")
            End Using

            ' Close ML Database connection
            'ACC_ConClose()

        Catch ex As Exception
            Debug.WriteLine("Error updating AccessCode_tb: " & ex.Message)
        End Try
    End Sub


    '******************************************< Saving Night Shift >**********************************
    Sub Night_Get_EmployeeDetails()
        Try
            ' Open ACC Database Connection
            ML_ConOpen()

            ' Loop through Code_List to get Employee Details
            For i As Integer = 0 To DL_Employee_List.Count - 1
                Dim accessCode As String = DL_Employee_List(i) ' Get corresponding AccessCode

                ' SQL Query to fetch employee details
                Dim query As String = "SELECT Code, Manpower_Category, Cost_Center_Code, Department " &
                                  "FROM AccessCode_tb WHERE Access_Code = ?"

                Using cmd As New OleDbCommand(query, MLDbconnection)
                    cmd.Parameters.AddWithValue("?", accessCode)

                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim employeeCode As String = reader("Code").ToString()
                            Dim manpowerCategory As String = reader("Manpower_Category").ToString()
                            Dim costCenter As String = reader("Cost_Center_Code").ToString()
                            Dim Depart As String = reader("Department").ToString()

                            ' Call Update_AccessCodeTB using AccessCode as reference
                            Night_Update_AccessCodeTB(accessCode, employeeCode, costCenter, manpowerCategory, Depart)
                        End If
                    End Using
                End Using
            Next

            ' Close ACC Database Connection
            ML_ConClose()

        Catch ex As Exception
            Debug.WriteLine("Error retrieving employee details: " & ex.Message)
        End Try
    End Sub

    Sub Night_Update_AccessCodeTB(accessCode As String, empCode As String, costCenter As String, manpowerCategory As String, Depart As String)
        Try
            ' Open the ML Database connection
            ACC_ConOpen()

            ' Update query for AccessCode_tb using Access_Code as reference
            Dim updateQuery As String = "UPDATE NightShift_tb SET " &
                                        "Employee_Code = ?, Cost_Center = ?, " &
                                        "Manpower_Category = ?, Department = ? " &
                                        "WHERE AccessCode = ?"

            Using cmd As New OleDbCommand(updateQuery, ACCDbconnection)
                cmd.Parameters.AddWithValue("?", empCode)
                cmd.Parameters.AddWithValue("?", costCenter)
                cmd.Parameters.AddWithValue("?", manpowerCategory)
                cmd.Parameters.AddWithValue("?", Depart)
                cmd.Parameters.AddWithValue("?", accessCode) ' Reference column

                Dim rowsUpdated As Integer = cmd.ExecuteNonQuery()
                Debug.WriteLine($"Updated {rowsUpdated} row(s) for Access_Code: {accessCode}")
            End Using

            ' Close ML Database connection
            'ACC_ConClose()

        Catch ex As Exception
            Debug.WriteLine("Error updating AccessCode_tb: " & ex.Message)
        End Try
    End Sub
End Module