Public Class Circle
    Inherits Shape

    Private _radius As Integer

    Public Overrides ReadOnly Property Area As Double
        Get
            Return _radius ^ 2
        End Get
    End Property

    Public Sub New(side As Integer)
        _radius = side
    End Sub

    Public Overrides Function GetXml() As String
        Dim element As New XElement("Circle", _
            New XAttribute("Name", Name), _
            New XAttribute("Radius", _radius))
        Return element.ToString()
    End Function
End Class
