' NOTE: You can use the "Rename" command on the context menu to change the class name "ServicioPagos" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select ServicioPagos.svc or ServicioPagos.svc.vb at the Solution Explorer and start debugging.
Imports Datos.Incmnsz
Imports ServicioREST

Public Class ServicioPagos
    Implements IServicioPagos

    Public Function GetEmployees() As List(Of Empleados) Implements IServicioPagos.GetEmployees
        Dim z As New Datos.Incmnsz.RepositorioDatos

        Dim lista As List(Of Empleados) = z.ObtieneDatos()

        Return lista

    End Function

    Public Function SayHello() Implements IServicioPagos.SayHello
        Return "Hello World"
    End Function
End Class
