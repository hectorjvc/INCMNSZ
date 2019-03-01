Class MainWindow 

    Private Sub Window_Loaded(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        For index = 1 To 100
            Dim shape As Shape
            If (index Mod 2 = 0) Then
                shape = New Square(10)
            Else
                shape = New Circle(10)
            End If
            shape.Draw(DrawingCanvas)
        Next
    End Sub

End Class
