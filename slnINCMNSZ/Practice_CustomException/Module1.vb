Module Module1

    Sub Main()

        Try
            GeneraExcepcion()
        Catch customEx As CustomExeption
            Console.WriteLine(customEx.Message)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadLine()

    End Sub

    Sub GeneraExcepcion()
        Throw New CustomExeption("Ha ocurrido un error")
    End Sub

End Module

Class CustomExeption
    Inherits Exception

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal message As String)
        MyBase.New(message)
    End Sub
    Public Sub New(ByVal message As String, ByVal InnerExecption As Exception)
        MyBase.New(message, InnerExecption)
    End Sub
    Public Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
        MyBase.New(info, context)
    End Sub

End Class
