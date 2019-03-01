Module Module1

    Sub Main()

        Dim valor As String
        Console.Write("Escribe el codigo: ")
        valor = Console.ReadLine()

        Dim exito As Resultado

        Try
            exito = ProcesaClave(valor)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadLine()

    End Sub

    Function ProcesaClave(mensaje As String) As Resultado
        If mensaje.Equals("Ironman") Then
            Return New Resultado With
            {
                .Mensaje = "Clave Correcta",
                .Estatus = True,
                .HoraOperacion = DateTime.Now,
                .Operacion = "ProcesaMensaje"
            }
        Else
            Return New Resultado With
            {
                .Mensaje = "Clave InCorrecta",
                .Estatus = False,
                .HoraOperacion = DateTime.Now,
                .Operacion = "ProcesaMensaje"
            }
        End If
    End Function
End Module

Class Resultado
    Inherits OperacionesBase

    Public Estatus As Boolean
    Public HoraOperacion As DateTime
    Public Mensaje As String
End Class

Class OperacionesBase
    Public Operacion As String
End Class

