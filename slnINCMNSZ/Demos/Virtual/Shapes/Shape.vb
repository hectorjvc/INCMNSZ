Public MustInherit Class Shape
    Private Shared _rand As New Random
    Protected _element As FrameworkElement

    Public MustOverride ReadOnly Property Area As Double

    Public Sub Draw(canvas As Canvas)
        Dim left = canvas.ActualWidth * _rand.NextDouble()
        Dim top = canvas.ActualHeight * _rand.NextDouble()
        _element.SetValue(canvas.LeftProperty, left)
        _element.SetValue(canvas.TopProperty, top)
        canvas.Children.Add(_element)
    End Sub

    Protected Overridable Sub SetColors(shape As System.Windows.Shapes.Shape)
        shape.Fill = New SolidColorBrush(Colors.Green)
        shape.Stroke = New SolidColorBrush(Colors.Black)
    End Sub
End Class
