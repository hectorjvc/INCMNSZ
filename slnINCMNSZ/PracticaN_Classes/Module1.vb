Module Module1

    Sub Main()

        Dim arrPersona(9) As CPersona
        For index = 1 To 10
            Dim p As New CPersona
            p.Nombre = "Hector" + index.ToString
            p.Apaterno = "Valdes"
            p.AMaterno = "Campos"
            arrPersona(index) = p
        Next




    End Sub

End Module
