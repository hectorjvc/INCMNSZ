Module Module1
    Sub Main()

        Dim log As New CLogger()

        'Set the property
        log.LogName = "AppNET"

        'Use the Function, you can recieve or not the result
        log.WriteLog("This is an Information Message", EventLogEntryType.Information)
        log.WriteLog("This is a Warning Message", EventLogEntryType.Warning)
        Dim flag As Boolean = log.WriteLog("This is a Error Message", EventLogEntryType.Error)

    End Sub

End Module

