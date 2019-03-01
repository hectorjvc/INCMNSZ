' NOTE: You can use the "Rename" command on the context menu to change the interface name "IService1" in both code and config file together.
Imports Datos.Incmnsz

<ServiceContract()>
Public Interface IService1

    <OperationContract()>
    Function GetEmployees() As List(Of Empleados)


End Interface

' Use a data contract as illustrated in the sample below to add composite types to service operations.
