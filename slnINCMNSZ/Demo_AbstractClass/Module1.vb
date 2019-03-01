Module Module1

    Sub Main()
        Dim x As New MySubClass

    End Sub

End Module

'PASO 1
Public MustInherit Class MyAbstractClass
    Public MustOverride Sub Method1()
    Public MustOverride Function Method2(value As Integer) As Integer

    Public Sub MetodoNoAbstracto()
        Console.WriteLine("Non-Abstract Method")
    End Sub
End Class


'PASO 2
Public Class MySubClass
    Inherits MyAbstractClass

    Public Overrides Sub Method1()
        Throw New NotImplementedException()
    End Sub

    Public Overrides Function Method2(value As Integer) As Integer
        Throw New NotImplementedException()
    End Function
End Class