Module Module1

    Sub Main()
        Dim s As ClaseShared = New ClaseShared
        s.count()
        s.count()
        s.count()
        Console.WriteLine(ClaseShared.getNum())
        Console.ReadLine()

        For index = 1 To 10
            Dim p As New Persona()
            p.Nombre = $"Hector {index} "
            ClaseShared.AddRecord(p)
            Console.WriteLine(p.Nombre)
        Next
        Console.ReadLine()
    End Sub

End Module

Public Class ClaseShared
    Public Shared num As Integer
    Public Sub count()
        num += 1
    End Sub
    Public Shared Function getNum()
        Return num
    End Function
    Public Shared Function AddRecord(persona As Persona) As Boolean
        persona.Nombre += "_PROCESADO"
        Return True
    End Function
End Class

Public Class Persona
    Public Nombre As String
End Class


