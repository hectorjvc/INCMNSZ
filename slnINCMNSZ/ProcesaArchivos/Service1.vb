Imports System.Timers
Imports System.Configuration
Public Class Service1

    Shared aTimer As Timer
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Protected Overrides Sub OnStart(ByVal args() As String)
        aTimer = New Timer With {.Enabled = True}
        AddHandler aTimer.Elapsed,
            New ElapsedEventHandler(AddressOf Handler)
        Dim tiempo As Integer = 0
        Integer.TryParse(ConfigurationManager.AppSettings("tiempo"), tiempo)
        aTimer.Interval = tiempo
        aTimer.Start()
    End Sub

    Protected Overrides Sub OnStop()
        ' Add code here to perform any tear-down necessary to stop your service.
    End Sub

    Shared Sub Handler(ByVal sender As Object, ByVal e As ElapsedEventArgs)
        Dim hora As Integer
        Dim minuto As Integer
        Dim segundo As Integer
        hora = DateTime.Now.Hour
        minuto = DateTime.Now.Minute
        segundo = DateTime.Now.Second
        My.Computer.FileSystem.MoveFile(
            ConfigurationManager.AppSettings("ruta1") & "Empleados.txt",
            ConfigurationManager.AppSettings("ruta2") & "Empleados{" + hora + "}_{" + minuto + "}_{" + segundo + "}.txt"
            )
    End Sub
End Class
