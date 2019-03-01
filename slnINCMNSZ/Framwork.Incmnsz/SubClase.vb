Public Class SubClase
    Inherits MiClaseAbstractaVoyVoy

    Public Overrides Sub Metodo1()
        Throw New NotImplementedException()
    End Sub

    Public Overrides Function Metodo2(id As Integer) As Integer
        Return 100
    End Function
End Class
