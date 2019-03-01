Public Class Shape
    Private Shared _rand As New Random
    Protected _element As FrameworkElement

    Public Sub Draw(canvas As Canvas)
        Dim left = canvas.ActualWidth * _rand.NextDouble()
        Dim top = canvas.ActualHeight * _rand.NextDouble()
        _element.SetValue(canvas.LeftProperty, left)
        _element.SetValue(canvas.TopProperty, top)
        canvas.Children.Add(_element)
    End Sub
End Class
