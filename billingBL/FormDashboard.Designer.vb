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
        ddShift = New ComboBox()
        btnOnShift = New Button()
        btnOffShift = New Button()
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
        btnToOnSerialPorts.Location = New Point(584, 216)
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
        btnToOffSerialPorts.Location = New Point(261, 216)
        btnToOffSerialPorts.Name = "btnToOffSerialPorts"
        btnToOffSerialPorts.Size = New Size(152, 177)
        btnToOffSerialPorts.TabIndex = 4
        btnToOffSerialPorts.TextImageRelation = TextImageRelation.ImageAboveText
        btnToOffSerialPorts.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(584, 371)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 74)
        Label1.TabIndex = 8
        Label1.Text = "KLIK GAMBAR DIATAS UNTUK MENYAMBUNGKAN KE ALAT"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(240, 371)
        Label2.Name = "Label2"
        Label2.Size = New Size(186, 74)
        Label2.TabIndex = 9
        Label2.Text = "DB BELUM TERKONEKSI"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(864, 273)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 19)
        Label3.TabIndex = 10
        Label3.Text = "SHIFT SEKARANG"
        ' 
        ' ddShift
        ' 
        ddShift.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ddShift.FormattingEnabled = True
        ddShift.Location = New Point(840, 298)
        ddShift.Margin = New Padding(3, 2, 3, 2)
        ddShift.Name = "ddShift"
        ddShift.Size = New Size(176, 27)
        ddShift.TabIndex = 11
        ' 
        ' btnOnShift
        ' 
        btnOnShift.BackColor = SystemColors.MenuHighlight
        btnOnShift.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOnShift.ForeColor = SystemColors.ButtonHighlight
        btnOnShift.Location = New Point(840, 362)
        btnOnShift.Margin = New Padding(3, 2, 3, 2)
        btnOnShift.Name = "btnOnShift"
        btnOnShift.Size = New Size(81, 31)
        btnOnShift.TabIndex = 12
        btnOnShift.Text = "ON"
        btnOnShift.UseVisualStyleBackColor = False
        ' 
        ' btnOffShift
        ' 
        btnOffShift.BackColor = SystemColors.MenuHighlight
        btnOffShift.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOffShift.ForeColor = SystemColors.ButtonHighlight
        btnOffShift.Location = New Point(934, 362)
        btnOffShift.Margin = New Padding(3, 2, 3, 2)
        btnOffShift.Name = "btnOffShift"
        btnOffShift.Size = New Size(81, 31)
        btnOffShift.TabIndex = 13
        btnOffShift.Text = "OFF"
        btnOffShift.UseVisualStyleBackColor = False
        ' 
        ' FormDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1199, 562)
        Controls.Add(btnOffShift)
        Controls.Add(btnOnShift)
        Controls.Add(ddShift)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnToOnSerialPorts)
        Controls.Add(btnToOffSerialPorts)
        Name = "FormDashboard"
        Padding = New Padding(13, 11, 13, 11)
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
    Friend WithEvents ddShift As ComboBox
    Friend WithEvents btnOnShift As Button
    Friend WithEvents btnOffShift As Button
End Class
