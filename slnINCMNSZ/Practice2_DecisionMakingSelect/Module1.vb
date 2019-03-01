Module Module1

    Enum Status
        Active = 1
        Deleted = 2
        Updated = 3
        Selected = 4
        Unknown = 5
    End Enum

    Sub Main()



        Dim x As Integer
        Dim y As String = "MEX"
        Dim z As Boolean

        If x = 0 Then
            Select Case x
                Case "MEX"
                    If z Then
                        Console.Write("")
                    Else
                        Console.Write("")
                    End If
                Case "USA"
                    If z = False Then
                        Console.Write("")
                    Else
                        Console.Write("")
                    End If
                Case Else
            End Select
        End If


        Dim number As Integer = 8
        Select Case number
            Case 1 To 5
                Console.WriteLine("Between 1 and 5, inclusive")
        ' The following is the only Case clause that evaluates to True.
            Case 6, 7, 8
                Console.WriteLine("Between 6 and 8, inclusive")
            Case 9 To 10
                Console.WriteLine("Equal to 9 or 10")
            Case Else
                Console.WriteLine("Not between 1 and 10, inclusive")
        End Select

        Console.ReadLine()

        Dim myStatus As Status = Status.Active

        Select Case myStatus
            Case Status.Active
                Console.WriteLine("Status = Active")
            Case Status.Deleted
                Console.WriteLine("Status = Deleted")
            Case Status.Unknown
                Console.WriteLine("Status = Unknown")
            Case Status.Selected
                Console.WriteLine("Status = Selected")
            Case Status.Updated
                Console.WriteLine("Status = Updated")
            Case Else

        End Select

        Console.ReadLine()

    End Sub


End Module
