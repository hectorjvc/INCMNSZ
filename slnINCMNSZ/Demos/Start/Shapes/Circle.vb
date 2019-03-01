Public Class Circle
    Private Shared _rand As New Random
    Private _ellipse As Ellipse

    Public Property Radius As Integer
        Get
            Return _ellipse.Width
        End Get
        Set(value As Integer)
            _ellipse.Width = value
            _ellipse.Height = value
        End Set
    End Property

    Public Sub New(radius As Integer)
        _ellipse = New Ellipse
        _ellipse.Width = radius
        _ellipse.Height = radius
        _ellipse.Fill = New SolidColorBrush(Colors.Green)
        _ellipse.Stroke = New SolidColorBrush(Colors.Black)
    End Sub

    Public Sub Draw(canvas As Canvas)
        Dim left = canvas.ActualWidth * _rand.NextDouble()
        Dim top = canvas.ActualHeight * _rand.NextDouble()
        _ellipse.SetValue(canvas.LeftProperty, left)
        _ellipse.SetValue(canvas.TopProperty, top)
        canvas.Children.Add(_ellipse)
    End Sub
End Class
