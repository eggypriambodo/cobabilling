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
        btnToOnSerialPorts = New FontAwesome.Sharp.IconButton()
        btnToOffSerialPorts = New FontAwesome.Sharp.IconButton()
        Timer1 = New Timer(components)
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
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
        btnToOnSerialPorts.Location = New Point(762, 288)
        btnToOnSerialPorts.Margin = New Padding(3, 4, 3, 4)
        btnToOnSerialPorts.Name = "btnToOnSerialPorts"
        btnToOnSerialPorts.Size = New Size(174, 236)
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
        btnToOffSerialPorts.Location = New Point(389, 288)
        btnToOffSerialPorts.Margin = New Padding(3, 4, 3, 4)
        btnToOffSerialPorts.Name = "btnToOffSerialPorts"
        btnToOffSerialPorts.Size = New Size(174, 236)
        btnToOffSerialPorts.TabIndex = 4
        btnToOffSerialPorts.TextImageRelation = TextImageRelation.ImageAboveText
        btnToOffSerialPorts.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(762, 495)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 99)
        Label1.TabIndex = 8
        Label1.Text = "KLIK GAMBAR DIATAS UNTUK MENYAMBUNGKAN KE ALAT"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(371, 495)
        Label2.Name = "Label2"
        Label2.Size = New Size(213, 99)
        Label2.TabIndex = 9
        Label2.Text = "DB BELUM TERKONEKSI"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1566, 999)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnToOnSerialPorts)
        Controls.Add(btnToOffSerialPorts)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormDashboard"
        Padding = New Padding(15)
        Text = "FormDashboard"
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnToOnSerialPorts As FontAwesome.Sharp.IconButton
    Friend WithEvents btnToOffSerialPorts As FontAwesome.Sharp.IconButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
