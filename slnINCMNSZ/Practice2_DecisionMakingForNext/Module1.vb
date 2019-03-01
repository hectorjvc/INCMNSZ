Module Module1
    Sub Main()
        For indexA = 1 To 3
            Dim sb As New System.Text.StringBuilder()
            For indexB = 20 To 1 Step -3
                sb.Append(indexB.ToString)
                sb.Append(" ")
            Next indexB
            Console.WriteLine(sb.ToString)
        Next indexA
        Console.ReadLine()

        Dim names(10) As String
        For i = 0 To 10
            names(i) = "Name " + i.ToString()
        Next
        For Each item As String In names
            Console.WriteLine(item)
        Next
        Console.ReadLine()
    End Sub
End Module
