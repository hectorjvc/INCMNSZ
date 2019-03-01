Imports Framwork.Incmnsz

Public Class Form1
    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Dim op As New Operaciones
        Try
            op.Numero1 = CDbl(txtNumero1.Text)
            op.Numero2 = CDbl(txtNumero2.Text)
            MuestraMensaje("El  resultado es:" & op.Suma(), MessageBoxIcon.Exclamation)
        Catch
            MuestraMensaje("Error en la Suma", MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMultiplica_Click(sender As Object, e As EventArgs) Handles btnMultiplica.Click
        Dim op As New Operaciones
        Try
            op.Numero1 = CDbl(txtNumero1.Text)
            op.Numero2 = CDbl(txtNumero2.Text)
            'Throw New CalculadoraException
            MuestraMensaje("El  resultado es:" & op.Multiplica(), MessageBoxIcon.Exclamation)
        Catch ex As CalculadoraException
            MuestraMensaje("Error en la Multiplicacion", MessageBoxIcon.Error)
            'Catch exApp As Exception
            '    MuestraMensaje("Error en la Multiplicacion", MessageBoxIcon.Error)
        End Try
    End Sub

    Sub MuestraMensaje(mensaje As String, tipo As MessageBoxIcon)
        MessageBox.Show(mensaje,
                            "Calculadora",
                            MessageBoxButtons.OK,
                            tipo)
    End Sub

    Private Sub btnMayusculas_Click(sender As Object, e As EventArgs) Handles btnMayusculas.Click
        Dim op As New Operaciones
        Dim res As New Resultado("Iniciando")
        res = op.ConvertirMayusculas(txtMayusculas.Text)
        If res.OcurrioError = False Then
            MuestraMensaje(res.Mensaje, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnGeneraArchivo_Click(sender As Object, e As EventArgs) Handles btnGeneraArchivo.Click
        Dim op As New Operaciones
        op.GeneraArchivo("c:\test\log.txt")
        op = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As New Resultado
        x.NombreOperacion = "Click de un boton"
        x.Mensaje = "Test"
        Dim z As Resultado = ModificaObjeto(x)

        Dim cl As New SubClase
        'Dim dato As Integer = cl.Metodo2(1)
        'Dim cadena As String = cl.Saludo()
        Dim j As New OperacionesConCadena
        j.Saludo()

    End Sub

    Function ModificaObjeto(dato As Resultado) As Resultado
        Dim res As New Resultado()
        res.Mensaje = "SSSS"
        Return res
    End Function

End Class
