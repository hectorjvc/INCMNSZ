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

    Public Overrides ReadOnly Property Area As Double
        Get
            Return Math.PI * Radius ^ 2
        End Get
    End Property

    Public Sub New(radius As Integer)
        Dim ellipse As New Ellipse
        ellipse.Width = radius
        ellipse.Height = radius
        SetColors(ellipse)
        _element = ellipse
    End Sub

    Protected Overrides Sub SetColors(shape As System.Windows.Shapes.Shape)
        MyBase.SetColors(shape)
        shape.Fill = New SolidColorBrush(Colors.Red)
    End Sub
End Class
