Public Class CalculadoraException
    Inherits Exception

    Sub LogeaElError()
        'Que haga algo
    End Sub
    'Throw New CalculadoraException()
    Public Sub New()
        MyBase.New()
        LogeaElError()
    End Sub

    'Throw New CalculadoraException("Algo paso")
    'Public Sub New(mensajeError As String)
    '    MyBase.New(mensajeError)
    '    LogeaElError()
    'End Sub

End Class


