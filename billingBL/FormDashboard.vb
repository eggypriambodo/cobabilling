Imports System.IO
Imports System.IO.Ports
Imports System.Threading

Public Class FormDashboard
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Shared _continue As Boolean
    Shared _serialPort As SerialPort
    Sub munculserial()

    End Sub

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each AvailableSerialPorts As String In System.IO.Ports.SerialPort.GetPortNames()
            cbSerialPort.Items.Add(AvailableSerialPorts)
            cbSerialPort.Text = AvailableSerialPorts
            _serialPort.ReadTimeout = 2000

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