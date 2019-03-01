Module Module1

    Sub Main()
        Dim c As New ClaseDemo("Liz", "Sistemas")
        Try
            'Some Code
        Catch ex As Exception
            'Some Exception Handling
        Finally
            c.Dispose()
        End Try
    End Sub

End Module

Class ClaseDemo

    Public Nombre As String
    Public Departamento As String
    Sub New(_nombre As String, _departamento As String)
        Nombre = _nombre
        Departamento = _departamento

        Console.WriteLine("Hola desde el constructor")
    End Sub

    Public Sub Dispose()
        Console.WriteLine("Hola desde el dispose")
        ' Dispose() calls Finalize so that you can include all 
        ' the cleanup code in one place.
        Me.Finalize()
        ' Tell the GC that the object doesn't require any cleanup
        GC.SuppressFinalize(Me)
    End Sub

    Protected Overrides Sub Finalize()
        ' Clean up system resources
        Console.WriteLine("Hola desde el destructor")
        Console.ReadLine()
    End Sub


End Class






