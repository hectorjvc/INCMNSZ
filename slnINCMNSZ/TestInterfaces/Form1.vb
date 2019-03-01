Imports Common
Imports People.Library

Public Class Form1

    Dim repository As New PersonRepository

    Private Sub btnDirecto_Click(sender As Object, e As EventArgs) Handles btnDirecto.Click
        Dim people As Persona() = repository.GetPeople
        For Each item As Persona In people
            lvPersons.Items.Add(item.GivenName)
        Next
    End Sub

    Private Sub btnInterfaz_Click(sender As Object, e As EventArgs) Handles btnInterfaz.Click
        Dim people As IEnumerable(Of Persona) = repository.GetPeople
        For Each item As Persona In people
            lvPersons.Items.Add(item.GivenName)
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As IncmnszEntities = New IncmnszEntities
        Dim emps = From s In db.Empleados
        DataGridView1.DataSource = emps.ToArray
    End Sub
End Class
