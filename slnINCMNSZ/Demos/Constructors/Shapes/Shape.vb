Public MustInherit Class Shape
    Private Shared _rand As New Random
    Protected _element As FrameworkElement
    Private _canvas As Canvas

    Public MustOverride ReadOnly Property Area As Double

    Public Sub New(canvas As Canvas)
        _canvas = canvas
    End Sub

    Public Sub Draw()
        Dim left = _canvas.ActualWidth * _rand.NextDouble()
        Dim top = _canvas.ActualHeight * _rand.NextDouble()
        _element.SetValue(Canvas.LeftProperty, left)
        _element.SetValue(Canvas.TopProperty, top)
        _canvas.Children.Add(_element)
    End Sub

    Protected Overridable Sub SetColors(shape As System.Windows.Shapes.Shape)
        shape.Fill = New SolidColorBrush(Colors.Green)
        shape.Stroke = New SolidColorBrush(Colors.Black)
    End Sub
End Class


