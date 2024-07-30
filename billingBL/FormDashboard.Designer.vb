<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        TextBox1 = New TextBox()
        cbSerialPort = New ComboBox()
        btnToOnSerialPorts = New FontAwesome.Sharp.IconButton()
        btnToOffSerialPorts = New FontAwesome.Sharp.IconButton()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(340, 399)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(152, 23)
        TextBox1.TabIndex = 7
        ' 
        ' cbSerialPort
        ' 
        cbSerialPort.FormattingEnabled = True
        cbSerialPort.Location = New Point(667, 399)
        cbSerialPort.Name = "cbSerialPort"
        cbSerialPort.Size = New Size(152, 23)
        cbSerialPort.TabIndex = 6
        ' 
        ' btnToOnSerialPorts
        ' 
        btnToOnSerialPorts.FlatAppearance.BorderSize = 0
        btnToOnSerialPorts.FlatStyle = FlatStyle.Flat
        btnToOnSerialPorts.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnToOnSerialPorts.IconChar = FontAwesome.Sharp.IconChar.Computer
        btnToOnSerialPorts.IconColor = Color.Black
        btnToOnSerialPorts.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnToOnSerialPorts.IconSize = 128
        btnToOnSerialPorts.Location = New Point(667, 216)
        btnToOnSerialPorts.Name = "btnToOnSerialPorts"
        btnToOnSerialPorts.Size = New Size(152, 177)
        btnToOnSerialPorts.TabIndex = 5
        btnToOnSerialPorts.TextImageRelation = TextImageRelation.ImageAboveText
        btnToOnSerialPorts.UseVisualStyleBackColor = True
        ' 
        ' btnToOffSerialPorts
        ' 
        btnToOffSerialPorts.FlatAppearance.BorderSize = 0
        btnToOffSerialPorts.FlatStyle = FlatStyle.Flat
        btnToOffSerialPorts.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnToOffSerialPorts.IconChar = FontAwesome.Sharp.IconChar.Server
        btnToOffSerialPorts.IconColor = Color.Black
        btnToOffSerialPorts.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnToOffSerialPorts.IconSize = 128
        btnToOffSerialPorts.Location = New Point(340, 216)
        btnToOffSerialPorts.Name = "btnToOffSerialPorts"
        btnToOffSerialPorts.Size = New Size(152, 177)
        btnToOffSerialPorts.TabIndex = 4
        btnToOffSerialPorts.TextImageRelation = TextImageRelation.ImageAboveText
        btnToOffSerialPorts.UseVisualStyleBackColor = True
        ' 
        ' FormDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 749)
        Controls.Add(TextBox1)
        Controls.Add(cbSerialPort)
        Controls.Add(btnToOnSerialPorts)
        Controls.Add(btnToOffSerialPorts)
        Name = "FormDashboard"
        Text = "FormDashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cbSerialPort As ComboBox
    Friend WithEvents btnToOnSerialPorts As FontAwesome.Sharp.IconButton
    Friend WithEvents btnToOffSerialPorts As FontAwesome.Sharp.IconButton
    Friend WithEvents Timer1 As Timer
End Class
