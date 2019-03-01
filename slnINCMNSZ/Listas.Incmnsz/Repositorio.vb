
Public Class Repositorio
    Public Function ObtieneEmpleados() As List(Of Empleado)

        Dim lista As New List(Of Empleado)
        lista.Add(New Empleado() With
                  {.Nombre = "H", .Apaterno = "V", .Amaterno = "C", .RFC = "VACH"})
        lista.Add(New Empleado() With
                  {.Nombre = "A", .Apaterno = "Z", .Amaterno = "R", .RFC = "FLASH"})
        lista.Add(New Empleado() With
                  {.Nombre = "D", .Apaterno = "X", .Amaterno = "C", .RFC = "BATMAN"})
        lista.Add(New Empleado() With
                  {.Nombre = "F", .Apaterno = "W", .Amaterno = "W", .RFC = "LOCO"})
        lista.Add(New Empleado() With
                  {.Nombre = "G", .Apaterno = "G", .Amaterno = "Q", .RFC = "SOPE"})
        'Dim e1 As New Empleado
        'e1.Nombre = "Hector"
        'lista.Add(e1)
        Return lista
    End Function
End Class
