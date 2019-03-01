Module Module1

    Sub Main()
        Dim src As String = "abrozalazorra"
        Dim palindrome As Boolean = True
        For i As Integer = 0 To src.Length \ 2
            If src(i) <> src(src.Length - i - 1) Then
                palindrome = False
                Exit For
            End If
        Next


        Dim srcAux = StrReverse(src)
        If src.Equals(srcAux) Then
            palindrome = True
        Else
            palindrome = False
        End If


    End Sub

End Module
