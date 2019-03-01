Public Class CPersona

    Public Nombre As String
    Public Apaterno As String
    Public AMaterno As String
    Public NombreCompleto As String

    Function Concatena() As String
        Return Nombre +
            " " + Apaterno + " " +
            AMaterno
    End Function

End Class
