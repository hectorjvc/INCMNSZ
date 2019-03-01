Public Class Circle
    Inherits Shape

    Public Property Radius As Integer
        Get
            Return _element.Width
        End Get
        Set(value As Integer)
            _element.Width = value
            _element.Height = value
        End Set
    End Property

    Public Sub New(radius As Integer)
        Dim ellipse As New Ellipse
        ellipse.Width = radius
        ellipse.Height = radius
        ellipse.Fill = New SolidColorBrush(Colors.Green)
        ellipse.Stroke = New SolidColorBrush(Colors.Black)
        _element = ellipse
    End Sub
End Class
