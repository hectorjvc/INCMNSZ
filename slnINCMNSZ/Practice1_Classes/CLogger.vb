Public Class CLogger
    Public LogName As String

    Public Function WriteLog(message As String, logType As EventLogEntryType) As Boolean
        Try
            Dim source As String = LogName
            Dim systemEventLog As New EventLog("System")
            If (Not EventLog.SourceExists(source)) Then
                EventLog.CreateEventSource(source, "System")
            End If
            systemEventLog.Source = source
            systemEventLog.WriteEntry(message, logType)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
