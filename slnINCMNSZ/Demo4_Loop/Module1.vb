﻿Module Module1

    Sub Main()

        Dim index As Integer = 0

        Do
            Debug.Write(index.ToString & " ")
            index += 1
        Loop Until index > 10
        Debug.WriteLine("")
        ' Output: 0 1 2 3 4 5 6 7 8 9 10 

        Do While index <= 10
            Debug.Write(index.ToString & " ")
            index += 1
        Loop
        Debug.WriteLine("")
        ' Output: 0 1 2 3 4 5 6 7 8 9 10 

    End Sub

End Module
