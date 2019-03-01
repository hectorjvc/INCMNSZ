Module Module1

    Sub Main()
        ShowDateTime()
        ChangeColor()
        Dim a As Double
        Dim b As Double
        Dim myOperation As Double

        Try
            Console.Write("Number A: ")
            a = Console.ReadLine()
            Console.Write("Number B: ")
            b = Console.ReadLine()
            myOperation = Add(a, b)
            Console.WriteLine(myOperation)
            myOperation = Subtraction(a, b)
            Console.WriteLine(myOperation)
            myOperation = Multiplication(a, b)
            Console.WriteLine(myOperation)
            myOperation = Division(a, b)
            Console.WriteLine(myOperation)
        Catch ex As Exception
            Console.Write("Error with numbers.")
        Finally
            'Liberar recursos
            'Cerrar archivo
        End Try

        Console.ReadLine()
    End Sub

    Function Add(numberA As Double, numberB As Double) As Double
        Return numberA + numberB
    End Function

    Function Subtraction(numberA As Double, numberB As Double) As Double
        Return numberA - numberB
    End Function

    Function Multiplication(numberA As Double, numberB As Double) As Double
        Return numberA * numberB
    End Function

    Function Division(numberA As Double, numberB As Double) As Double
        Return numberA / numberB
    End Function

    Sub ShowDateTime()
        Console.WriteLine(DateTime.Now().ToString("dd/MM/yyyy"))
    End Sub

    Sub ChangeColor()
        Console.BackgroundColor = ConsoleColor.Green
    End Sub

End Module
