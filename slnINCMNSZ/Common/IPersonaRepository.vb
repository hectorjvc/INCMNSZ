Public Interface IPersonaRepository

    Function GetPeople() As IEnumerable(Of Persona)

    Function GetPerson(id As Integer) As Persona

End Interface
