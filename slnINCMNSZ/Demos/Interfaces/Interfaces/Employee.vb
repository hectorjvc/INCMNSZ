Public Class Employee
    Implements IXmlExport

    Private _name As String
    Private _birthDate As DateTime

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            If Not String.IsNullOrEmpty(value) Then
                _name = value
            End If
        End Set
    End Property

    Public ReadOnly Property Age As Integer
        Get
            Dim diff = DateTime.Now - _birthDate
            Return diff.Days \ 365
        End Get
    End Property

    Public Property Salaried As Boolean

    Public Sub New()
        Name = "<empty>"
        Salaried = False
    End Sub

    Public Sub New(ByVal name As String, _
        ByVal salaried As Boolean)

        Me.Name = name
        Me.Salaried = salaried
    End Sub

    Public Function GetDescription()
        Return String.Format( _
            "{0} is{1} a salaried employee", _
            Name, IIf(Salaried, "", " not"))
    End Function

    Public Function GetXml() As String Implements IXmlExport.GetXml
        Dim element As New XElement("Employee", _
            New XAttribute("Name", Name), _
            New XAttribute("Salaried", Salaried))
        Return element.ToString()
    End Function
End Class
