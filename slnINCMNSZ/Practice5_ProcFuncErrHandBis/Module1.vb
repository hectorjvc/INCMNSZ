Module Module1

    Sub Main()
        Dim result As Double
        Try
            EscribeMensaje("Procesando")
            result = Suma(5.2, 6.3)
            result = Division(5, 0)
        Catch ex2 As System.IO.DirectoryNotFoundException
            Console.WriteLine("Ocurrió un error " + ex2.Message)
        Catch ex As Exception
            Console.WriteLine("Ocurrió un error " + ex.Message)
        End Try

        Console.ReadLine()

    End Sub

    Function Division(a As Double, b As Double) As Double
        Return a / b
    End Function

    Function Suma(a As Double, b As Double) As Double
        Return a + b
    End Function
    Function EscribeMensaje(mensaje As String) As Boolean
        Console.WriteLine(mensaje)
        'Throw New Exception("Algo muy malo")
        Return True
    End Function

End Module
