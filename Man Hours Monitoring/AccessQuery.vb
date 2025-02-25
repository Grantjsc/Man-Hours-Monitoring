Imports System.Data.OleDb
Imports System.Data.SqlClient

Module AccessQuery_Module
    Public ACCconnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\WIA\GroupList.accdb"
    Public ACCDbconnection As New OleDbConnection(ACCconnString)

    Sub ACC_ConOpen()
        If ACCDbconnection.State = ConnectionState.Closed Then
            ACCDbconnection.Open()
        End If
    End Sub

    Sub ACC_ConClose()
        If ACCDbconnection.State = ConnectionState.Open Then
            ACCDbconnection.Close()
        End If
    End Sub

    '******************************************< DAY SHIFT QUERY >**********************************

    Sub Day_Insert_AccessCodes()
        Dim existingAccessCodes As New HashSet(Of String)
        Dim validAccessCodes As New HashSet(Of String)(DL_Employee_List) ' Convert list to HashSet for quick checks

        Try
            ACC_ConOpen()

            ' Load existing AccessCodes from database
            Dim selectQuery As String = "SELECT AccessCode FROM DayShift_tb"
            Using selectCmd As New OleDbCommand(selectQuery, ACCDbconnection)
                Using reader As OleDbDataReader = selectCmd.ExecuteReader()
                    While reader.Read()
                        existingAccessCodes.Add(reader.GetString(0))
                    End While
                End Using
            End Using

            ' Insert only if the AccessCode is valid and does not already exist
            For Each accessCode As String In accessControlList
                If validAccessCodes.Contains(accessCode) Then
                    If Not existingAccessCodes.Contains(accessCode) Then
                        Dim insertQuery As String = "INSERT INTO DayShift_tb (AccessCode) VALUES (?)"
                        Using insertCmd As New OleDbCommand(insertQuery, ACCDbconnection)
                            insertCmd.Parameters.AddWithValue("?", accessCode)
                            Dim rowsInserted As Integer = insertCmd.ExecuteNonQuery()
                            Debug.WriteLine($"Inserted {rowsInserted} row(s) for AccessCode: {accessCode}")

                            ' Add to existingAccessCodes to prevent re-checking in the same session
                            existingAccessCodes.Add(accessCode)
                        End Using
                    Else
                        Debug.WriteLine($"AccessCode {accessCode} already exists, skipping insert.")
                    End If
                Else
                    Debug.WriteLine($"AccessCode {accessCode} skipped (not in DL_Employee_List).")
                End If
            Next

            ACC_ConClose()
        Catch ex As Exception
            Debug.WriteLine("Error inserting data: " & ex.Message)
        End Try


    End Sub


    Public TimeIn_Date As String
    Public DateForEmail As String

    Sub Day_Update_TimeIn()
        ACC_ConOpen()

        For i As Integer = 0 To accessControlList.Count - 1
            Dim accessCode As String = accessControlList(i)
            Dim latestDateTime As DateTime = Convert.ToDateTime(timeRecordList(i))
            Dim recordType As String = recordTypeList(i).Trim()

            ' Extract the time part
            Dim recordTime As TimeSpan = latestDateTime.TimeOfDay

            ' Extract and format the date as MM/dd/yyyy
            TimeIn_Date = latestDateTime.ToString("MM/dd/yyyy")
            DateForEmail = latestDateTime.ToString("MMMM dd, yyyy")

            ' Check if the time falls within 4:00 AM to 2:00 PM
            If recordType = "I" AndAlso recordTime >= New TimeSpan(4, 0, 0) AndAlso recordTime <= New TimeSpan(14, 0, 0) Then
                Dim updateQuery As String = "UPDATE DayShift_tb SET Time_In = ? WHERE AccessCode = ?"

                Using updateCmd As New OleDbCommand(updateQuery, ACCDbconnection)
                    updateCmd.Parameters.AddWithValue("?", CDate(latestDateTime))
                    updateCmd.Parameters.AddWithValue("?", accessCode)
                    Dim rowsAffected As Integer = updateCmd.ExecuteNonQuery()
                    Debug.WriteLine($"Updated {rowsAffected} Time_In for AccessCode: {accessCode}, Date: {TimeIn_Date}")
                End Using
            Else
                Debug.WriteLine($"Skipped record for AccessCode: {accessCode}, Time: {latestDateTime}, Date: {TimeIn_Date}")
            End If
        Next

        ACC_ConClose()
    End Sub

    Sub Day_Update_TimeOut()
        ACC_ConOpen()

        For i As Integer = 0 To accessControlList.Count - 1
            Dim accessCode As String = accessControlList(i)
            Dim latestDateTime As DateTime = Convert.ToDateTime(timeRecordList(i))
            Dim recordType As String = recordTypeList(i).Trim()

            ' Extract the time part
            Dim recordTime As TimeSpan = latestDateTime.TimeOfDay

            ' Check if the time falls within 10:00 AM to 10:00 PM
            If recordType = "O" AndAlso recordTime >= New TimeSpan(10, 0, 0) AndAlso recordTime <= New TimeSpan(22, 0, 0) Then
                Dim updateQuery As String = "UPDATE DayShift_tb SET Time_Out = ? WHERE AccessCode = ?"

                Using updateCmd As New OleDbCommand(updateQuery, ACCDbconnection)
                    updateCmd.Parameters.AddWithValue("?", CDate(latestDateTime))
                    updateCmd.Parameters.AddWithValue("?", accessCode)
                    Dim rowsAffected As Integer = updateCmd.ExecuteNonQuery()
                    Debug.WriteLine($"Updated {rowsAffected} Time_Out for AccessCode: {accessCode}")
                End Using
            Else
                Debug.WriteLine($"Skipped record for AccessCode: {accessCode}, Time: {latestDateTime}")
            End If
        Next

        ACC_ConClose()

    End Sub

    Sub DeleteDay()
        ACC_ConOpen()

        Dim deleteQuery As String = "DELETE FROM DayShift_tb WHERE Time_In IS NULL AND Time_Out IS NULL"

        Using deleteCmd As New OleDbCommand(deleteQuery, ACCDbconnection)
            Dim rowsDeleted As Integer = deleteCmd.ExecuteNonQuery()
            Debug.WriteLine($"Deleted {rowsDeleted} records from DayShift_tb with no Time_In and Time_Out.")
        End Using

        ACC_ConClose()
    End Sub

    Sub UpdateShiftType_Day()
        ACC_ConOpen()

        Dim updateQuery As String = "UPDATE DayShift_tb SET ShiftType = 'Day Shift'"

        Using updateCmd As New OleDbCommand(updateQuery, ACCDbconnection)
            Dim rowsUpdated As Integer = updateCmd.ExecuteNonQuery()
            Debug.WriteLine($"Updated {rowsUpdated} records in DayShift_tb, setting ShiftType to 'Day Shift'.")
        End Using

        ACC_ConClose()
    End Sub

    Sub Update_Date_Day()
        ACC_ConOpen()

        Dim dt As Date = TimeIn_Date 'Form1.DateTimePicker1.Value.Date ' Get only the date part
        Dim updateQuery As String = "UPDATE DayShift_tb SET _Date = ?"

        Using updateCmd As New OleDbCommand(updateQuery, ACCDbconnection)
            updateCmd.Parameters.AddWithValue("?", dt) ' Parameterized query
            Dim rowsUpdated As Integer = updateCmd.ExecuteNonQuery()
            Debug.WriteLine($"Updated {rowsUpdated} records in DayShift_tb.")
        End Using

        ACC_ConClose()
    End Sub

    Sub DeleteRecords_Day()
        ACC_ConOpen()

        Dim deleteQuery As String = "DELETE FROM DayShift_tb"

        Using deleteCmd As New OleDbCommand(deleteQuery, ACCDbconnection)
            Dim rowsDeleted As Integer = deleteCmd.ExecuteNonQuery()
            Debug.WriteLine($"Deleted {rowsDeleted} records from DayShift_tb.")
        End Using

        ACC_ConClose()
    End Sub


    '******************************************< Night SHIFT QUERY >**********************************

    Sub Night_Insert_AccessCodes()
        Dim existingAccessCodes As New HashSet(Of String)
        Dim validAccessCodes As New HashSet(Of String)(DL_Employee_List) ' Convert list to HashSet for quick checks

        Try
            ACC_ConOpen()

            ' Load existing AccessCodes from database
            Dim selectQuery As String = "SELECT AccessCode FROM NightShift_tb"
            Using selectCmd As New OleDbCommand(selectQuery, ACCDbconnection)
                Using reader As OleDbDataReader = selectCmd.ExecuteReader()
                    While reader.Read()
                        existingAccessCodes.Add(reader.GetString(0))
                    End While
                End Using
            End Using

            ' Insert only if the AccessCode is valid and does not already exist
            For Each accessCode As String In accessControlList
                If validAccessCodes.Contains(accessCode) Then
                    If Not existingAccessCodes.Contains(accessCode) Then
                        Dim insertQuery As String = "INSERT INTO NightShift_tb (AccessCode) VALUES (?)"
                        Using insertCmd As New OleDbCommand(insertQuery, ACCDbconnection)
                            insertCmd.Parameters.AddWithValue("?", accessCode)
                            Dim rowsInserted As Integer = insertCmd.ExecuteNonQuery()
                            Debug.WriteLine($"Inserted {rowsInserted} row(s) for AccessCode: {accessCode}")

                            ' Add to existingAccessCodes to prevent re-checking in the same session
                            existingAccessCodes.Add(accessCode)
                        End Using
                    Else
                        Debug.WriteLine($"AccessCode {accessCode} already exists, skipping insert.")
                    End If
                Else
                    Debug.WriteLine($"AccessCode {accessCode} skipped (not in DL_Employee_List).")
                End If
            Next

            ACC_ConClose()
        Catch ex As Exception
            Debug.WriteLine("Error inserting data: " & ex.Message)
        End Try


    End Sub

    Sub Night_Update_TimeIn()
        ACC_ConOpen()

        For i As Integer = 0 To accessControlList.Count - 1
            Dim accessCode As String = accessControlList(i)
            Dim latestDateTime As DateTime = Convert.ToDateTime(timeRecordList(i))
            Dim recordType As String = recordTypeList(i).Trim()

            Dim recordTime As TimeSpan = latestDateTime.TimeOfDay

            ' Check if Type is "I" and time is between 3 PM (15:00) and 10 PM (22:00)
            If recordType = "I" AndAlso recordTime >= New TimeSpan(15, 0, 0) AndAlso recordTime <= New TimeSpan(22, 0, 0) Then
                Dim updateQuery As String = "UPDATE NightShift_tb SET Time_In = ? WHERE AccessCode = ?"

                Using updateCmd As New OleDbCommand(updateQuery, ACCDbconnection)
                    updateCmd.Parameters.AddWithValue("?", CDate(latestDateTime))
                    updateCmd.Parameters.AddWithValue("?", accessCode)
                    Dim rowsAffected As Integer = updateCmd.ExecuteNonQuery()
                    Debug.WriteLine($"Updated {rowsAffected} Time_In for AccessCode: {accessCode}")
                End Using
            Else
                Debug.WriteLine($"Skipped record for AccessCode: {accessCode}, Time: {latestDateTime}")
            End If
        Next

        ACC_ConClose()
    End Sub

    Sub Night_Update_TimeOut()
        ACC_ConOpen()

        For i As Integer = 0 To accessControlList.Count - 1
            Dim accessCode As String = accessControlList(i)
            Dim latestDateTime As DateTime = Convert.ToDateTime(timeRecordList(i))
            Dim recordType As String = recordTypeList(i).Trim()

            Dim recordTime As TimeSpan = latestDateTime.TimeOfDay

            ' Check if Type is "O" and time is between 3 AM (03:00) and 10 AM (10:00)
            If recordType = "O" AndAlso recordTime >= New TimeSpan(3, 0, 0) AndAlso recordTime <= New TimeSpan(10, 0, 0) Then
                Dim updateQuery As String = "UPDATE NightShift_tb SET Time_Out = ? WHERE AccessCode = ?"

                Using updateCmd As New OleDbCommand(updateQuery, ACCDbconnection)
                    updateCmd.Parameters.AddWithValue("?", CDate(latestDateTime))
                    updateCmd.Parameters.AddWithValue("?", accessCode)
                    Dim rowsAffected As Integer = updateCmd.ExecuteNonQuery()
                    Debug.WriteLine($"Updated {rowsAffected} Time_Out for AccessCode: {accessCode}")
                End Using
            Else
                Debug.WriteLine($"Skipped record for AccessCode: {accessCode}, Time: {latestDateTime}")
            End If
        Next

        ACC_ConClose()
    End Sub


    Sub DeleteNight()
        ACC_ConOpen()

        Dim deleteQuery As String = "DELETE FROM NightShift_tb WHERE Time_In IS NULL AND Time_Out IS NULL"

        Using deleteCmd As New OleDbCommand(deleteQuery, ACCDbconnection)
            Dim rowsDeleted As Integer = deleteCmd.ExecuteNonQuery()
            Debug.WriteLine($"Deleted {rowsDeleted} records from NightShift_tb with no Time_In and Time_Out.")
        End Using

        ACC_ConClose()
    End Sub

    Sub UpdateShiftType_Night()
        ACC_ConOpen()

        Dim updateQuery As String = "UPDATE NightShift_tb SET ShiftType = 'Night Shift'"

        Using updateCmd As New OleDbCommand(updateQuery, ACCDbconnection)
            Dim rowsUpdated As Integer = updateCmd.ExecuteNonQuery()
            Debug.WriteLine($"Updated {rowsUpdated} records in NightShift_tb, setting ShiftType to 'Night Shift'.")
        End Using

        ACC_ConClose()
    End Sub

    Sub Update_Date_Night()
        ACC_ConOpen()

        Dim dt As Date = TimeIn_Date 'Form1.DateTimePicker1.Value.Date ' Get only the date part
        Dim updateQuery As String = "UPDATE NightShift_tb SET _Date = ?"

        Using updateCmd As New OleDbCommand(updateQuery, ACCDbconnection)
            updateCmd.Parameters.AddWithValue("?", dt) ' Parameterized query
            Dim rowsUpdated As Integer = updateCmd.ExecuteNonQuery()
            Debug.WriteLine($"Updated {rowsUpdated} records in NightShift_tb.")
        End Using

        ACC_ConClose()
    End Sub

    Sub DeleteRecords_Night()
        ACC_ConOpen()

        Dim deleteQuery As String = "DELETE FROM NightShift_tb"

        Using deleteCmd As New OleDbCommand(deleteQuery, ACCDbconnection)
            Dim rowsDeleted As Integer = deleteCmd.ExecuteNonQuery()
            Debug.WriteLine($"Deleted {rowsDeleted} records from NightShift_tb.")
        End Using

        ACC_ConClose()
    End Sub

End Module