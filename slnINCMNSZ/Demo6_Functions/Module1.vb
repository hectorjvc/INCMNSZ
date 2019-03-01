Module Module1

    Sub Main()
        Dim myTest As String
        myTest = SayHello()
        myTest = SayGoodBye("Hello!!")
    End Sub

    Function SayHello() As String
        Return "Hello!!"
    End Function

    Function SayGoodBye(message As String) As String
        Return message
    End Function

End Module
