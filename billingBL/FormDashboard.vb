Imports System.IO
Imports System.IO.Ports
Imports System.Management
Imports System.Threading

Public Class FormDashboard
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Shared _continue As Boolean
    Public Shared _serialPort As SerialPort
    Public Shared correctPortName As String  ' Variable to store the correct port name

    ' Method to find and initialize the correct serial port based on command
    Sub munculserial(expectedDescription As String)
        Dim foundPort As String = Nothing

        ' Use ManagementObjectSearcher to get detailed information about serial ports
        Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption LIKE '%(COM%'")
        For Each obj As ManagementObject In searcher.Get()
            Dim portName As String = obj("Caption").ToString()
            ' Check if the port description contains the expected description
            If portName.Contains(expectedDescription) Then
                ' Extract the COM port name (e.g., COM3)
                Dim comPort As String = portName.Substring(portName.LastIndexOf("(") + 1).TrimEnd(")"c)
                correctPortName = comPort
                btnToOnSerialPorts.Enabled = False
                Label1.Text = "PORT SUDAH TERSAMBUNG"
                Try
                    connect()

                Catch ex As Exception
                    MsgBox(ex.Message)

                Finally
                    disconnect()
                    Label2.Text = "DATABASE SUDAH TERSAMBUNG"
                End Try

                Exit For

            End If
        Next

    End Sub

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnToOnSerialPorts.Enabled = True
        btnToOffSerialPorts.Enabled = False
    End Sub

    Private Sub btnToOnSerialPorts_Click(sender As Object, e As EventArgs)
        '_serialPort.BaudRate = "9600"
        '_serialPort.PortName = "COM9"
        'btnToOnSerialPorts.Visible = False
        'btnToOffSerialPorts.Visible = True
        'Timer1.Enabled = True
        'If _serialPort.IsOpen = False Then
        '    '_serialPort.Open()


        'End If
    End Sub

    Private Sub btnToOffSerialPorts_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnToOnSerialPorts_Click_1(sender As Object, e As EventArgs) Handles btnToOnSerialPorts.Click
        munculserial("Prolific PL2303GT USB Serial COM Port")

    End Sub
End Class