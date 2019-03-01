Module Module1

    Sub Main()

        Dim Name As String
        Dim Age As Integer
        Dim RFC As String
        Dim Message As String

        Console.Write("Enter your name...")
        Name = Console.ReadLine()
        'Validate if Name is Empty
        If String.IsNullOrEmpty(Name) Then
            Message = "Invalid Name" & vbCrLf 'vbCrLf = ENTER
        End If

        Console.Write("Enter your age...")
        Dim ageOut As String
        Integer.TryParse(Console.ReadLine(), ageOut)
        If ageOut > 0 Then
            If ageOut < 18 And ageOut > 60 Then
                Message += "Invalid Name - Range" & vbCrLf 'vbCrLf = ENTER
            End If
        Else
            Message += "Invalid Age - Numeric" & vbCrLf 'vbCrLf = ENTER
        End If

        Console.Write("Enter your RFC...")
        RFC = Console.ReadLine()
        'Validate both is not empty and length
        If String.IsNullOrEmpty(RFC) Or RFC.Length <> 13 Then
            Message += "Invalid RFC" & vbCrLf
        End If

        'If Message is empty means no "error" ocurred
        If Message = String.Empty Then
            Message = "OK"
        End If

        Console.WriteLine($"Message from Administrator: {vbCrLf}{Message}")
        Console.ReadLine()

    End Sub

End Module
