Module Module1

    Sub Main()
        Dim objects(2) As IXmlExport
        objects(0) = New Employee("Rob", False)
        objects(1) = New Square(10) With {.Name = "MySquare"}
        objects(2) = New Circle(20) With {.Name = "MyCircle"}

        For Each obj In objects
            Console.WriteLine(obj.GetXml())
        Next
    End Sub

End Module
