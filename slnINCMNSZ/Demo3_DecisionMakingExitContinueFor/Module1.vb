Module Module1

    Sub Main()
        Dim numberSeq() As Integer = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}

        For Each number As Integer In numberSeq

            If number >= 5 And number <= 8 Then
                Continue For
            End If

            Console.Write(number.ToString & " ")

            If number = 10 Then
                Exit For
            End If
        Next
        Console.WriteLine("")
    End Sub

End Module


