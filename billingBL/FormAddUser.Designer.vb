<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddUser
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
        Panel13 = New Panel()
        Label18 = New Label()
        Panel14 = New Panel()
        tbNamaUser = New TextBox()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        tbPasswordUser = New TextBox()
        LabelOpenTable = New Label()
        btnTambahUser = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel13.SuspendLayout()
        Panel14.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel13.BorderStyle = BorderStyle.FixedSingle
        Panel13.Controls.Add(Label18)
        Panel13.Location = New Point(3, 3)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(151, 49)
        Panel13.TabIndex = 12
        ' 
        ' Label18
        ' 
        Label18.Dock = DockStyle.Left
        Label18.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = SystemColors.Control
        Label18.Location = New Point(0, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(114, 47)
        Label18.TabIndex = 0
        Label18.Text = "Nama User"
        Label18.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel14
        ' 
        Panel14.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel14.BorderStyle = BorderStyle.FixedSingle
        Panel14.Controls.Add(tbNamaUser)
        Panel14.Location = New Point(160, 3)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(167, 49)
        Panel14.TabIndex = 13
        ' 
        ' tbNamaUser
        ' 
        tbNamaUser.Location = New Point(21, 11)
        tbNamaUser.Name = "tbNamaUser"
        tbNamaUser.Size = New Size(125, 27)
        tbNamaUser.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(333, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(151, 49)
        Panel1.TabIndex = 14
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Left
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 47)
        Label1.TabIndex = 0
        Label1.Text = "Password User"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(tbPasswordUser)
        Panel2.Location = New Point(490, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(167, 49)
        Panel2.TabIndex = 15
        ' 
        ' tbPasswordUser
        ' 
        tbPasswordUser.Location = New Point(21, 11)
        tbPasswordUser.Name = "tbPasswordUser"
        tbPasswordUser.Size = New Size(125, 27)
        tbPasswordUser.TabIndex = 1
        ' 
        ' LabelOpenTable
        ' 
        LabelOpenTable.AutoSize = True
        LabelOpenTable.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        LabelOpenTable.Dock = DockStyle.Fill
        LabelOpenTable.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelOpenTable.ForeColor = SystemColors.Control
        LabelOpenTable.Location = New Point(3, 0)
        LabelOpenTable.Name = "LabelOpenTable"
        LabelOpenTable.Size = New Size(665, 46)
        LabelOpenTable.TabIndex = 0
        LabelOpenTable.Text = "TAMBAH USER KASIR"
        LabelOpenTable.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnTambahUser
        ' 
        btnTambahUser.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnTambahUser.ForeColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        btnTambahUser.Location = New Point(3, 58)
        btnTambahUser.Name = "btnTambahUser"
        btnTambahUser.Size = New Size(321, 48)
        btnTambahUser.TabIndex = 20
        btnTambahUser.Text = "TAMBAH USER"
        btnTambahUser.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = SystemColors.Control
        FlowLayoutPanel1.Controls.Add(Panel13)
        FlowLayoutPanel1.Controls.Add(Panel14)
        FlowLayoutPanel1.Controls.Add(Panel1)
        FlowLayoutPanel1.Controls.Add(Panel2)
        FlowLayoutPanel1.Controls.Add(btnTambahUser)
        FlowLayoutPanel1.Location = New Point(3, 49)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(665, 187)
        FlowLayoutPanel1.TabIndex = 2
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel1, 0, 1)
        TableLayoutPanel1.Controls.Add(LabelOpenTable, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 45F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(671, 253)
        TableLayoutPanel1.TabIndex = 13
        ' 
        ' FormAddUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(671, 160)
        Controls.Add(TableLayoutPanel1)
        Name = "FormAddUser"
        Text = "FormAddUser"
        Panel13.ResumeLayout(False)
        Panel14.ResumeLayout(False)
        Panel14.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents tbNamaUser As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbPasswordUser As TextBox
    Friend WithEvents LabelOpenTable As Label
    Friend WithEvents btnTambahUser As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
