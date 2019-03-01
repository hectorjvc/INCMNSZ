Public MustInherit Class Shape
    Implements IXmlExport

    Public Property Name As String
    Public MustOverride ReadOnly Property Area As Double

    Public MustOverride Function GetXml() As String Implements IXmlExport.GetXml
End Class
