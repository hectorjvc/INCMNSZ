Module Module1

    Sub Main()

        Dim myArray(5) As Integer

        myArray(0) = 1
        myArray(1) = 2
        myArray(2) = 3
        myArray(3) = 4
        myArray(4) = 5
        myArray(5) = 6

        Dim result As Integer
        result = myArray(0) + myArray(1) + myArray(2) + myArray(3) + myArray(5) + myArray(5)

        Dim myStringArray(3) As String
        myStringArray(0) = "Microsoft .NET"
        myStringArray(1) = "ASP.NET Core"
        myStringArray(2) = "VB.NET"
        myStringArray(3) = "Xamarin"

        Dim myNewArray() As Integer
        ReDim myNewArray(3)
        myNewArray(0) = 20
        myNewArray(1) = 30
        myNewArray(2) = 40
        myNewArray(3) = 50

        ReDim Preserve myNewArray(7)
        myNewArray(4) = 60
        myNewArray(5) = 70
        myNewArray(6) = 80
        myNewArray(7) = 90

        Dim multiArray(3, 3) As Integer

        Dim i, j As Integer

        For i = 0 To 3
            For j = 0 To 3
                If i = j Then
                    multiArray(i, j) = 1
                Else
                    multiArray(i, j) = 0
                End If
            Next
        Next

        Array.Reverse(myNewArray)

        Array.Sort(myStringArray)

    End Sub

End Module
