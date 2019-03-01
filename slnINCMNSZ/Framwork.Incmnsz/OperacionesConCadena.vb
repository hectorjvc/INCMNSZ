Imports Framwork.Incmnsz

Public Class OperacionesConCadena
    Implements IOperaciones, IOtra

    Public Function Concatena(p1 As String, p2 As String) As String Implements IOperaciones.Concatena
        Return p1 + p2
    End Function

    Public Function Mayusculas(p1 As String) As String Implements IOperaciones.Mayusculas
        Return p1.ToUpper
    End Function

    Public Function PalabraReversa(p1 As String) As String Implements IOperaciones.PalabraReversa
        Return p1.Reverse
    End Function

    Public Function Saluda2() As String Implements IOtra.Saluda2
        Throw New NotImplementedException()
    End Function

    Public Function Saludo() As String Implements IOperaciones.Saludo
        Throw New NotImplementedException()
    End Function
End Class
