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
        Label3 = New Label()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
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
        btnToOnSerialPorts.Location = New Point(668, 288)
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
        btnToOffSerialPorts.Location = New Point(298, 288)
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
        Label1.Location = New Point(668, 495)
        Label1.Name = "Label1"
        Label1.Size = New Size(174, 99)
        Label1.TabIndex = 8
        Label1.Text = "KLIK GAMBAR DIATAS UNTUK MENYAMBUNGKAN KE ALAT"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(274, 495)
        Label2.Name = "Label2"
        Label2.Size = New Size(213, 99)
        Label2.TabIndex = 9
        Label2.Text = "DB BELUM TERKONEKSI"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(987, 364)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 23)
        Label3.TabIndex = 10
        Label3.Text = "SHIFT SEKARANG"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(960, 398)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(201, 31)
        ComboBox1.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.MenuHighlight
        Button1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(960, 483)
        Button1.Name = "Button1"
        Button1.Size = New Size(93, 41)
        Button1.TabIndex = 12
        Button1.Text = "ON"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.MenuHighlight
        Button2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(1068, 483)
        Button2.Name = "Button2"
        Button2.Size = New Size(93, 41)
        Button2.TabIndex = 13
        Button2.Text = "OFF"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' FormDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1566, 999)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnToOnSerialPorts)
        Controls.Add(btnToOffSerialPorts)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormDashboard"
        Padding = New Padding(15)
        Text = "FormDashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnToOnSerialPorts As FontAwesome.Sharp.IconButton
    Friend WithEvents btnToOffSerialPorts As FontAwesome.Sharp.IconButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
