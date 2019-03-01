Module Module1
    Sub Main()
        Try
            Dim path As String = "c:\test\countries.txt"
            Dim sr As System.IO.StreamReader = System.IO.File.OpenText(path)
            While sr.Peek() >= 0
                Console.WriteLine(sr.ReadLine())
            End While
            sr.Close()

            Dim A, B, C As Integer
            A = B / C
            Console.WriteLine("OK")
        Catch ex As System.IO.IOException
            Console.WriteLine($"Error: {ex.Message}")
        Catch ex2 As Exception
            Console.WriteLine($"Error: {ex2.Message}")
        End Try
        Console.ReadLine()
    End Sub
End Module