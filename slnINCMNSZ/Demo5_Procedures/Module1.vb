Module Module1
    Sub Main()
        SayHello()
        SayGoodBye("Bye!!!!")
    End Sub

    Sub SayHello()
        Console.WriteLine("Hello!")
    End Sub

    Sub SayGoodBye(message As String)
        Console.WriteLine(message)
    End Sub

End Module
