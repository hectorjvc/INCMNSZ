Module Module1

    Sub Main()
        'ByReference3
        Dim x As Integer = 10
        ByReferenceMethod(x)
        Console.WriteLine(x)
        Console.ReadLine()
    End Sub

    Sub ByReferenceMethod(myX As Integer)
        myX = 50
        Console.WriteLine(myX)
    End Sub
End Module
