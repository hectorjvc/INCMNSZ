Public Class Square
    Private Shared _rand As New Random
    Private _rect As Rectangle

    Public Property Side As Integer
        Get
            Return _rect.Width
        End Get
        Set(value As Integer)
            _rect.Width = value
            _rect.Height = value
        End Set
    End Property

    Public Sub New(side As Integer)
        _rect = New Rectangle()
        _rect.Width = side
        _rect.Height = side
        _rect.Fill = New SolidColorBrush(Colors.Green)
        _rect.Stroke = New SolidColorBrush(Colors.Black)
    End Sub

    Public Sub Draw(canvas As Canvas)
        Dim left = canvas.ActualWidth * _rand.NextDouble()
        Dim top = canvas.ActualHeight * _rand.NextDouble()
        _rect.SetValue(canvas.LeftProperty, left)
        _rect.SetValue(canvas.TopProperty, top)
        canvas.Children.Add(_rect)
    End Sub
End Class
