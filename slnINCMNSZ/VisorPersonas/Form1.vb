Imports Datos.Incmnsz
Imports Listas.Incmnsz

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim db As New RepositorioDatos
        Dim lista As New List(Of Empleados)
        lista = db.ObtieneDatos()
        DataGridView1.DataSource = lista

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim db As New RepositorioDatos
        Dim emp As New Empleados
        emp.Nombre = TextBox1.Text
        emp.Apaterno = TextBox2.Text
        db.AgregaPersona(emp)
    End Sub
End Class
