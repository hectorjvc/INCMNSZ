Public Class Square
    Inherits Shape

    Private _side As Integer

    Public Overrides ReadOnly Property Area As Double
        Get
            Return _side ^ 2
        End Get
    End Property

    Public Sub New(side As Integer)
        _side = side
    End Sub

    Public Overrides Function GetXml() As String
        Dim element As New XElement("Square", _
            New XAttribute("Name", Name), _
            New XAttribute("Side", _side))
        Return element.ToString()
    End Function
End Class
