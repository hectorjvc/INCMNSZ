Imports System.Data.SqlClient

Public Class RepositorioDatos

    Public Function AgregaPersona(objEmp As Empleados) As Boolean
        Dim strCn As String
        Dim cn As New SqlConnection
        Dim cmd As New SqlCommand
        Try
            strCn = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Incmnsz;Data Source=."
            cn.ConnectionString = strCn
            cmd.Connection = cn
            Dim sql As String
            sql = "INSERT INTO Empleados (Nombre,Apaterno) Values " &
                "('" & objEmp.Nombre & "','" & objEmp.Apaterno & "')"

            cmd.CommandText = sql
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
        Finally
            cn.Dispose()
            cmd.Dispose()
        End Try
        Return True
    End Function

    Public Function ObtieneDatos() As List(Of Empleados)

        Dim miLista As New List(Of Empleados)
        Dim strCn As String
        Dim cn As New SqlConnection
        Dim cmd As New SqlCommand
        Dim reader As SqlDataReader
        Try
            strCn = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Incmnsz;Data Source=."
            cn.ConnectionString = strCn
            cmd.Connection = cn
            cmd.CommandText = "SELECT * FROM Empleados"
            cn.Open()
            reader = cmd.ExecuteReader
            While reader.Read
                miLista.Add(New Empleados() With
                            {.Id = reader("Id"), .Nombre = reader(1), .Apaterno = reader(2)})
            End While
            cn.Close()
        Catch ex As Exception
        Finally
            cn.Dispose()
            cmd.Dispose()
        End Try
        Return miLista
    End Function

End Class
