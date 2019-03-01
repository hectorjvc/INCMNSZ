Public Class Resultado
    Inherits OperacionesBase

    Sub New(mensaje As String)
        Me.Mensaje = mensaje
        OcurrioError = False
        Estatus = EstatusOperacion.Activo
        FechaEjecucion = DateTime.Now.AddDays(-1)
    End Sub

    Protected Overrides Sub Finalize()
        Debug.Write("Esto es el destructor")
    End Sub

    Sub New()
        Mensaje = ""
        OcurrioError = False
        Estatus = EstatusOperacion.Activo
        FechaEjecucion = DateTime.Now.AddDays(-1)
        Debug.Write("Esto es el constructor")
    End Sub

    Public Enum EstatusOperacion
        Activo = 1
        Inactivo = 4
    End Enum


    Public Mensaje As String
    Public OcurrioError As Boolean
    Public Estatus As EstatusOperacion
    Public FechaEjecucion As DateTime

End Class
