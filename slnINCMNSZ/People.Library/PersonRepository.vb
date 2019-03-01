Imports Common

Public Class PersonRepository

    Public Function GetPeople() As Persona() 'List(Of Persona)
        Dim lista As New List(Of Persona)
        lista.Add(New Persona() With {.Id = 1, .GivenName = "John", .FamilyName = "Koenig",
                    .StartDate = New DateTime(1975, 5, 2), .Rating = 1})
        lista.Add(New Persona() With {.Id = 2, .GivenName = "Dylan", .FamilyName = "Turanga",
                    .StartDate = New DateTime(1980, 7, 7), .Rating = 2})
        lista.Add(New Persona() With {.Id = 3, .GivenName = "Leela", .FamilyName = "Hunt",
                    .StartDate = New DateTime(1987, 10, 5), .Rating = 4})
        lista.Add(New Persona() With {.Id = 4, .GivenName = "Dave", .FamilyName = "Crichton",
                    .StartDate = New DateTime(1970, 5, 6), .Rating = 6})
        lista.Add(New Persona() With {.Id = 5, .GivenName = "Laura", .FamilyName = "Roslin",
                    .StartDate = New DateTime(1960, 11, 1), .Rating = 5})


        Return lista.ToArray
    End Function

    Public Function GetPerson(id As Integer)
        Return GetPeople().First(Function(c) c.Id = id)
    End Function

End Class
