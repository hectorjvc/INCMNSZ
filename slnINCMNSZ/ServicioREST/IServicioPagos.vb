Imports System.ServiceModel
Imports Datos.Incmnsz

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IServicioPagos" in both code and config file together.
<ServiceContract()>
Public Interface IServicioPagos

    <OperationContract()>
    <WebInvoke(Method:="GET",
               UriTemplate:="/SayHello/",
               BodyStyle:=WebMessageBodyStyle.Wrapped,
               RequestFormat:=WebMessageFormat.Json,
               ResponseFormat:=WebMessageFormat.Json)>
    Function SayHello()

    <OperationContract()>
    <WebInvoke(Method:="GET",
               UriTemplate:="/Empleados/",
               BodyStyle:=WebMessageBodyStyle.Wrapped,
               RequestFormat:=WebMessageFormat.Json,
               ResponseFormat:=WebMessageFormat.Json)>
    Function GetEmployees() As List(Of Empleados)

End Interface
