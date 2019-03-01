Module Module1
    ''' <summary>
    ''' Esto es un bla bla bla
    ''' </summary>
    Sub Main()
        Dim Number1 As Double
        Dim Number2 As Double
        Dim Result As Double

        Console.Write("Number 1: ")
        Number1 = Console.ReadLine()
        Console.Write("Number 2: ")
        Number2 = Console.ReadLine()

        Result = Number1 + Number2
        Console.WriteLine("The operation {0} + {1} = {2}", Number1, Number2, Result)
        Console.ReadLine()


        Console.WriteLine(Number1 = Number2)
        Console.WriteLine(Number1 <> Number2)
        Console.WriteLine(Number1 > Number2)
        Console.WriteLine(Number1 >= Number2)
        Console.WriteLine(Number1 < Number2)
        Console.WriteLine(Number1 <= Number2)
        Console.ReadLine()

        Number1 += 10
        Console.WriteLine(Number1)

        Number2 -= 3
        Console.WriteLine(Number2)

        Console.ReadLine()

        Dim FirstName As String
        Dim LastName As String
        Dim CompleteName As String

        FirstName = Console.ReadLine()
        LastName = Console.ReadLine()
        CompleteName = "Hello " & FirstName & " " & LastName
        Console.WriteLine(CompleteName)
        Console.ReadLine()

        'CompleteName = $"Hello {FirstName}  {LastName}"
        'Console.WriteLine(CompleteName)

        'CompleteName = String.Format("Hello {0} {1}", FirstName, LastName)
        'Console.WriteLine(CompleteName)

    End Sub
End Module
