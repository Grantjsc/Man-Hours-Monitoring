Imports System.Data.OleDb
Imports System.Data.SqlClient

Module Query_Module
    Public connString As String = "DATA SOURCE=BTMESSQLQA03;INITIAL CATALOG=Local_Access_Control;USER ID=mesph;PASSWORD=PHFuse;Persist Security Info=True;"
    Public Dbconnection As New SqlConnection(connString)

    Sub ConOpen()
        If Dbconnection.State = ConnectionState.Closed Then
            Dbconnection.Open()
        End If
    End Sub

    Sub ConClose()
        If Dbconnection.State = ConnectionState.Open Then
            Dbconnection.Close()
        End If
    End Sub

    Public accessControlList As New List(Of String)()
    Public timeRecordList As New List(Of String)()
    Public recordTypeList As New List(Of String)()

    Sub Get_InOut(selectedDate As DateTime)
        Try
            ' Clear previous data
            accessControlList.Clear()
            timeRecordList.Clear()
            recordTypeList.Clear()
            departments.Clear()

            ' SQL Query to get all records for the selected date
            Dim query As String = "SELECT AccessCode, DateTime, Type FROM tblDownloadData " &
                          "WHERE CONVERT(DATE, DateTime) = @SelectedDate " &
                          "ORDER BY AccessCode, DateTime"
            ConOpen()

            Using command As New SqlCommand(query, Dbconnection)
                ' Add parameter for selected date
                command.Parameters.AddWithValue("@SelectedDate", selectedDate.Date)

                ' Read data
                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim accessCode As String = reader("AccessCode").ToString()
                        Dim latestDateTime As String = reader("DateTime").ToString()
                        Dim recordType As String = reader("Type").ToString()

                        accessControlList.Add(accessCode)
                        timeRecordList.Add(latestDateTime)
                        recordTypeList.Add(recordType)

                        ' Print to Console
                        Console.WriteLine($"AccessCode: {accessCode} | TimeRecord: {latestDateTime} | Type: {recordType}")
                    End While
                End Using
            End Using

            ConClose()

            'MsgBox("Done!")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Module