Public Class Square
    Inherits Shape

    Public Property Side As Integer
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
            Return Side ^ 2
        End Get
    End Property

    Public Sub New(side As Integer)
        Dim rect As New Rectangle()
        rect.Width = side
        rect.Height = side
        SetColors(rect)
        _element = rect
    End Sub
End Class
