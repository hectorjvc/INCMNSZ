Class MainWindow 

    Private Sub Window_Loaded(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        For index = 1 To 50
            Dim square As New Square(10)
            square.Draw(DrawingCanvas)
        Next
        For index = 1 To 50
            Dim circle As New Circle(10)
            circle.Draw(DrawingCanvas)
        Next
    End Sub

End Class
