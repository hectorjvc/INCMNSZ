' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.vb at the Solution Explorer and start debugging.
Imports Datos.Incmnsz
Imports ServicioWCF

Public Class Service1
    Implements IService1

    Public Function GetEmployees() As List(Of Empleados) Implements IService1.GetEmployees
        Dim z As New Datos.Incmnsz.RepositorioDatos

        Dim lista As List(Of Empleados) = z.ObtieneDatos()

        Return lista
    End Function
End Class
