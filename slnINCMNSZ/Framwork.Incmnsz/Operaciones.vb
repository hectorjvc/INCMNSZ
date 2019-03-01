Imports System.IO

Public Class Operaciones

    Public Numero1 As Double
    Public Numero2 As Double

    Public Function Suma() As Double
        Dim result As Double
        result = Numero1 + Numero2
        Return result
    End Function

    Public Function Multiplica() As Double
        Return Numero1 * Numero2
    End Function

    Public Function ConvertirMayusculas(palabra As String) As Resultado
        Dim res As New Resultado
        palabra = palabra.ToUpper
        res.Estatus = Resultado.EstatusOperacion.Activo
        res.FechaEjecucion = DateTime.Now
        res.Mensaje = palabra
        res.OcurrioError = False
        Return res
    End Function

    'c:\test\log.txt
    Public Sub GeneraArchivo(rutas As String)
        Using writer As TextWriter = File.CreateText(rutas)
            writer.WriteLine("Hola mundo")
            writer.WriteLine("Adios mundo")
        End Using

    End Sub

End Class
