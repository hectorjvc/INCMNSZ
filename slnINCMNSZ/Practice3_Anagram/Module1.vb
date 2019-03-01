Module Module1

    Sub Main()

        Console.WriteLine(RevisaAnagrama("iceman", "cinema"))
        Console.WriteLine(RevisaAnagrama("gloria", "gorila"))
        Console.WriteLine(RevisaAnagrama("aabb", "bbaa"))
        Console.WriteLine(RevisaAnagrama("aabb", "abaa"))
        Console.ReadLine()


    End Sub

    Public Function RevisaAnagrama(palabraA As String, palabraB As String) As Boolean

        Dim pal1 As Char() = palabraA.ToLower().ToCharArray()
        Dim pal2 As Char() = palabraB.ToLower().ToCharArray()

        Array.Sort(pal1)
        Array.Sort(pal2)

        Dim testP1 As String = New String(pal1)
        Dim testP2 As String = New String(pal2)

        If testP1.Equals(testP2) Then
            Return True
        Else
            Return False
        End If

    End Function

End Module