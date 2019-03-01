Public Class Persona
    Public Id As Integer
    Public GivenName As String
    Public FamilyName As String
    Public StartDate As DateTime
    Public Rating As Integer
    Public FormatString As String

    Public Overrides Function ToString() As String
        If String.IsNullOrEmpty(FormatString) Then
            FormatString = "{0} {1}"
        End If
        Return String.Format(FormatString, GivenName, FamilyName)
    End Function

End Class
