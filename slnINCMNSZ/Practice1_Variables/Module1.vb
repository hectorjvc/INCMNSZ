
Module Module1
    Sub Main()
        Dim IdEmployee As Integer
        Dim FirstName As String
        Dim LastName As String
        Dim Age As SByte
        Dim Active As Boolean = True

        IdEmployee = 1
        FirstName = "[A_Name]"
        LastName = "[A_LastName]"
        Age = 35
        Active = True

        Console.WriteLine("Hello {0} {1}", FirstName, LastName)
        Console.WriteLine("Your age is" & Age)

        Console.WriteLine("Your superheroe name?")
        FirstName = Console.ReadLine()
        Console.WriteLine("Hello {0}", FirstName)

        Console.ReadLine() 'Pause de program execution

    End Sub
End Module
