Imports System.Text
Imports System.Xml

Public Class Form1

    Dim ruta As String = "C:\Users\v-hevald\Desktop\InstallShield\DEMOCODE\MOD01\Employee.xml"
    Dim xmlDoc As New XmlDocument

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        xmlDoc.Load(ruta)
        RichTextBox1.Text = xmlDoc.InnerXml.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        xmlDoc.Load(ruta)
        RichTextBox1.Text = xmlDoc.DocumentElement.InnerXml.ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        xmlDoc.Load(ruta)
        RichTextBox1.Text = xmlDoc.DocumentElement.ChildNodes(1).InnerXml.ToString
    End Sub
End Class
