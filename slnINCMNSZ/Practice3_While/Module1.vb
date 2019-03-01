Imports System.IO

Module Module1
    Sub Main()
        Dim path As String
        Console.Write("File location? >>")
        path = Console.ReadLine()
        If File.Exists(path) = False Then
            Console.WriteLine("File not found:" & path)
        Else
            Dim sr As StreamReader = File.OpenText(path)
            While sr.Peek() >= 0
                Console.WriteLine(sr.ReadLine())
            End While
            sr.Close()
            Console.ReadLine()
        End If
    End Sub
End Module
