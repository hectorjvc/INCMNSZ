Module Module1
    Enum Size
        Small = 100
        Medium = 200
        Big = 300
    End Enum

    Sub Main()
        Const PI = 3.14149
        Dim radius As Single
        Dim area As Single

        radius = 10
        area = PI * radius * radius
        Console.WriteLine("Area = " & Str(area))

        If area <= Size.Small Then
            Console.WriteLine("The size is Small")
        ElseIf area > Size.Small And area < Size.Medium Then
            Console.WriteLine("The size is Medium")
        Else
            Console.WriteLine("The size is Big")
        End If

        Console.ReadKey()

    End Sub
End Module
