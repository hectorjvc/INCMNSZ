Public MustInherit Class MiClaseAbstractaVoyVoy
    Public MustOverride Sub Metodo1()

    Public MustOverride Function Metodo2(id As Integer) As Integer

    Public Function Saludo()
        Return "Hola desde lo abstracto"
    End Function

End Class
