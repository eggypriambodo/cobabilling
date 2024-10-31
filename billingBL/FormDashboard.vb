Imports System.IO
Imports System.IO.Ports
Imports System.Threading

Public Class FormDashboard
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Shared _continue As Boolean
    Public Shared _serialPort As SerialPort
    Public Shared correctPortName As String  ' Variable to store the correct port name

    ' Method to find and initialize the correct serial port based on command
    Sub munculserial(command As String)
        If command = "1k" Then
            ' Check available serial ports
            Dim availablePorts As String() = SerialPort.GetPortNames()

            ' Loop through available ports and attempt to open the correct one
            For Each portName In availablePorts
                Try
                    _serialPort = New SerialPort(portName)
                    _serialPort.BaudRate = 9600  ' Set your baud rate here
                    _serialPort.Open()

                    ' Send "1k" command and check response
                    _serialPort.WriteLine("1k")
                    Dim response As String = _serialPort.ReadLine()

                    ' If response is valid, save the port name and break the loop
                    If response.Contains("ACK") Then ' Adjust "ACK" to the expected response
                        correctPortName = portName
                        Console.WriteLine($"Correct port found: {correctPortName}")
                        Exit For
                    Else
                        _serialPort.Close()
                    End If
                Catch ex As Exception
                    Console.WriteLine($"Port {portName} not valid or in use.")
                End Try
            Next

            ' If correct port is not found
            If correctPortName Is Nothing Then
                Console.WriteLine("No valid port found responding to '1k' command.")
            End If
        Else
            Console.WriteLine("Command not recognized.")
        End If


    End Sub

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each AvailableSerialPorts As String In System.IO.Ports.SerialPort.GetPortNames()
            cbSerialPort.Items.Add(AvailableSerialPorts)
            cbSerialPort.Text = AvailableSerialPorts
            '_serialPort.ReadTimeout = 2000

            TextBox1.ScrollBars = ScrollBars.Vertical
        Next
        btnToOnSerialPorts.Visible = True
        btnToOffSerialPorts.Visible = False
    End Sub

    Private Sub btnToOnSerialPorts_Click(sender As Object, e As EventArgs)
        _serialPort.BaudRate = "9600"
        _serialPort.PortName = cbSerialPort.SelectedItem
        btnToOnSerialPorts.Visible = False
        btnToOffSerialPorts.Visible = True
        Timer1.Enabled = True
        If _serialPort.IsOpen = False Then
            _serialPort.Open()
        End If
    End Sub

    Private Sub btnToOffSerialPorts_Click(sender As Object, e As EventArgs)

    End Sub

End Class