Module Module1

    Sub Main()
        'ByValue
        Dim x As Integer = 10
        ByValueMethod(x)
        Console.WriteLine(x)
        Console.ReadLine()
    End Sub

    Sub ByValueMethod(myX As Integer)
        myX = 50
        Console.WriteLine(myX)
    End Sub

End Module
