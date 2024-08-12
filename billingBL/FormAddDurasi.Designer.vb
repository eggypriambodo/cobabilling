<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddDurasi
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnTambahPaket = New Button()
        tbDiscTable = New TextBox()
        Panel6 = New Panel()
        Label3 = New Label()
        Panel5 = New Panel()
        tbHargaMalam = New TextBox()
        Panel4 = New Panel()
        Label2 = New Label()
        Panel3 = New Panel()
        LabelOpenTable = New Label()
        tbHargaSiang = New TextBox()
        Panel2 = New Panel()
        Label1 = New Label()
        Panel1 = New Panel()
        tbNamaPaket = New TextBox()
        Panel14 = New Panel()
        Label18 = New Label()
        Panel13 = New Panel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel7 = New Panel()
        Label4 = New Label()
        Panel8 = New Panel()
        cbAkhirSiang = New ComboBox()
        Panel9 = New Panel()
        Label5 = New Label()
        Panel10 = New Panel()
        cbAkhirMalam = New ComboBox()
        Label17 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        DataGridView1 = New DataGridView()
        namaPaket = New DataGridViewTextBoxColumn()
        hargaSiang = New DataGridViewTextBoxColumn()
        hargaMalam = New DataGridViewTextBoxColumn()
        akhirsiang = New DataGridViewTextBoxColumn()
        akhirMalam = New DataGridViewTextBoxColumn()
        discTable = New DataGridViewTextBoxColumn()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel14.SuspendLayout()
        Panel13.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        Panel9.SuspendLayout()
        Panel10.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnTambahPaket
        ' 
        btnTambahPaket.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnTambahPaket.ForeColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        btnTambahPaket.Location = New Point(3, 84)
        btnTambahPaket.Margin = New Padding(3, 2, 3, 2)
        btnTambahPaket.Name = "btnTambahPaket"
        btnTambahPaket.Size = New Size(281, 36)
        btnTambahPaket.TabIndex = 20
        btnTambahPaket.Text = "TAMBAH PAKET"
        btnTambahPaket.UseVisualStyleBackColor = True
        ' 
        ' tbDiscTable
        ' 
        tbDiscTable.Location = New Point(18, 8)
        tbDiscTable.Margin = New Padding(3, 2, 3, 2)
        tbDiscTable.Name = "tbDiscTable"
        tbDiscTable.Size = New Size(110, 23)
        tbDiscTable.TabIndex = 1
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(tbDiscTable)
        Panel6.Location = New Point(721, 43)
        Panel6.Margin = New Padding(3, 2, 3, 2)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(146, 37)
        Panel6.TabIndex = 19
        ' 
        ' Label3
        ' 
        Label3.Dock = DockStyle.Left
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 35)
        Label3.TabIndex = 0
        Label3.Text = "Disc Table (%)"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(Label3)
        Panel5.Location = New Point(583, 43)
        Panel5.Margin = New Padding(3, 2, 3, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(132, 37)
        Panel5.TabIndex = 18
        ' 
        ' tbHargaMalam
        ' 
        tbHargaMalam.Location = New Point(18, 8)
        tbHargaMalam.Margin = New Padding(3, 2, 3, 2)
        tbHargaMalam.Name = "tbHargaMalam"
        tbHargaMalam.Size = New Size(110, 23)
        tbHargaMalam.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(tbHargaMalam)
        Panel4.Location = New Point(721, 2)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(146, 37)
        Panel4.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Left
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 35)
        Label2.TabIndex = 0
        Label2.Text = "Harga Malam"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(583, 2)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(132, 37)
        Panel3.TabIndex = 16
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
        LabelOpenTable.Size = New Size(874, 37)
        LabelOpenTable.TabIndex = 0
        LabelOpenTable.Text = "TAMBAH PAKET DURASI"
        LabelOpenTable.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' tbHargaSiang
        ' 
        tbHargaSiang.Location = New Point(18, 8)
        tbHargaSiang.Margin = New Padding(3, 2, 3, 2)
        tbHargaSiang.Name = "tbHargaSiang"
        tbHargaSiang.Size = New Size(110, 23)
        tbHargaSiang.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(tbHargaSiang)
        Panel2.Location = New Point(431, 2)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(146, 37)
        Panel2.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Left
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 35)
        Label1.TabIndex = 0
        Label1.Text = "Harga Siang"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(293, 2)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(132, 37)
        Panel1.TabIndex = 14
        ' 
        ' tbNamaPaket
        ' 
        tbNamaPaket.Location = New Point(18, 8)
        tbNamaPaket.Margin = New Padding(3, 2, 3, 2)
        tbNamaPaket.Name = "tbNamaPaket"
        tbNamaPaket.Size = New Size(110, 23)
        tbNamaPaket.TabIndex = 1
        ' 
        ' Panel14
        ' 
        Panel14.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel14.BorderStyle = BorderStyle.FixedSingle
        Panel14.Controls.Add(tbNamaPaket)
        Panel14.Location = New Point(141, 2)
        Panel14.Margin = New Padding(3, 2, 3, 2)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(146, 37)
        Panel14.TabIndex = 13
        ' 
        ' Label18
        ' 
        Label18.Dock = DockStyle.Left
        Label18.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = SystemColors.Control
        Label18.Location = New Point(0, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(100, 35)
        Label18.TabIndex = 0
        Label18.Text = "Nama Paket"
        Label18.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel13.BorderStyle = BorderStyle.FixedSingle
        Panel13.Controls.Add(Label18)
        Panel13.Location = New Point(3, 2)
        Panel13.Margin = New Padding(3, 2, 3, 2)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(132, 37)
        Panel13.TabIndex = 12
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = SystemColors.Control
        FlowLayoutPanel1.Controls.Add(Panel13)
        FlowLayoutPanel1.Controls.Add(Panel14)
        FlowLayoutPanel1.Controls.Add(Panel1)
        FlowLayoutPanel1.Controls.Add(Panel2)
        FlowLayoutPanel1.Controls.Add(Panel3)
        FlowLayoutPanel1.Controls.Add(Panel4)
        FlowLayoutPanel1.Controls.Add(Panel7)
        FlowLayoutPanel1.Controls.Add(Panel8)
        FlowLayoutPanel1.Controls.Add(Panel9)
        FlowLayoutPanel1.Controls.Add(Panel10)
        FlowLayoutPanel1.Controls.Add(Panel5)
        FlowLayoutPanel1.Controls.Add(Panel6)
        FlowLayoutPanel1.Controls.Add(btnTambahPaket)
        FlowLayoutPanel1.Location = New Point(3, 39)
        FlowLayoutPanel1.Margin = New Padding(3, 2, 3, 2)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(874, 140)
        FlowLayoutPanel1.TabIndex = 2
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel7.BorderStyle = BorderStyle.FixedSingle
        Panel7.Controls.Add(Label4)
        Panel7.Location = New Point(3, 43)
        Panel7.Margin = New Padding(3, 2, 3, 2)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(132, 37)
        Panel7.TabIndex = 21
        ' 
        ' Label4
        ' 
        Label4.Dock = DockStyle.Left
        Label4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(0, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(128, 35)
        Label4.TabIndex = 0
        Label4.Text = "Akhir Harga Siang"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel8.BorderStyle = BorderStyle.FixedSingle
        Panel8.Controls.Add(cbAkhirSiang)
        Panel8.Location = New Point(141, 43)
        Panel8.Margin = New Padding(3, 2, 3, 2)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(146, 37)
        Panel8.TabIndex = 22
        ' 
        ' cbAkhirSiang
        ' 
        cbAkhirSiang.FormattingEnabled = True
        cbAkhirSiang.Location = New Point(13, 6)
        cbAkhirSiang.Name = "cbAkhirSiang"
        cbAkhirSiang.Size = New Size(121, 23)
        cbAkhirSiang.TabIndex = 0
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel9.BorderStyle = BorderStyle.FixedSingle
        Panel9.Controls.Add(Label5)
        Panel9.Location = New Point(293, 43)
        Panel9.Margin = New Padding(3, 2, 3, 2)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(132, 37)
        Panel9.TabIndex = 23
        ' 
        ' Label5
        ' 
        Label5.Dock = DockStyle.Left
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(0, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 35)
        Label5.TabIndex = 0
        Label5.Text = "Akhir Harga Malam"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel10.BorderStyle = BorderStyle.FixedSingle
        Panel10.Controls.Add(cbAkhirMalam)
        Panel10.Location = New Point(431, 43)
        Panel10.Margin = New Padding(3, 2, 3, 2)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(146, 37)
        Panel10.TabIndex = 24
        ' 
        ' cbAkhirMalam
        ' 
        cbAkhirMalam.FormattingEnabled = True
        cbAkhirMalam.Location = New Point(12, 6)
        cbAkhirMalam.Name = "cbAkhirMalam"
        cbAkhirMalam.Size = New Size(121, 23)
        cbAkhirMalam.TabIndex = 1
        ' 
        ' Label17
        ' 
        Label17.BorderStyle = BorderStyle.FixedSingle
        Label17.Dock = DockStyle.Top
        Label17.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(0, 204)
        Label17.Name = "Label17"
        Label17.Size = New Size(880, 30)
        Label17.TabIndex = 14
        Label17.Text = "Daftar Paket"
        Label17.TextAlign = ContentAlignment.MiddleCenter
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
        TableLayoutPanel1.Margin = New Padding(3, 2, 3, 2)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 45F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 15F))
        TableLayoutPanel1.Size = New Size(880, 204)
        TableLayoutPanel1.TabIndex = 13
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.MenuHighlight
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.Control
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {namaPaket, hargaSiang, hargaMalam, akhirsiang, akhirMalam, discTable})
        DataGridView1.Dock = DockStyle.Top
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Location = New Point(0, 234)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(880, 177)
        DataGridView1.TabIndex = 15
        ' 
        ' namaPaket
        ' 
        namaPaket.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        namaPaket.FillWeight = 175F
        namaPaket.HeaderText = "Nama Paket"
        namaPaket.MinimumWidth = 6
        namaPaket.Name = "namaPaket"
        namaPaket.ReadOnly = True
        ' 
        ' hargaSiang
        ' 
        hargaSiang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        hargaSiang.HeaderText = "Harga Siang "
        hargaSiang.MinimumWidth = 6
        hargaSiang.Name = "hargaSiang"
        hargaSiang.ReadOnly = True
        ' 
        ' hargaMalam
        ' 
        hargaMalam.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        hargaMalam.HeaderText = "Harga Malam "
        hargaMalam.MinimumWidth = 6
        hargaMalam.Name = "hargaMalam"
        hargaMalam.ReadOnly = True
        ' 
        ' akhirsiang
        ' 
        akhirsiang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        akhirsiang.HeaderText = "Jam Akhir Harga Siang"
        akhirsiang.MinimumWidth = 6
        akhirsiang.Name = "akhirsiang"
        akhirsiang.ReadOnly = True
        ' 
        ' akhirMalam
        ' 
        akhirMalam.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        akhirMalam.HeaderText = "Jam Akhir Harga Malam"
        akhirMalam.MinimumWidth = 6
        akhirMalam.Name = "akhirMalam"
        akhirMalam.ReadOnly = True
        ' 
        ' discTable
        ' 
        discTable.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        discTable.FillWeight = 50F
        discTable.HeaderText = "Disc Table (%)"
        discTable.MinimumWidth = 6
        discTable.Name = "discTable"
        discTable.ReadOnly = True
        ' 
        ' FormAddDurasi
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(880, 407)
        Controls.Add(DataGridView1)
        Controls.Add(Label17)
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "FormAddDurasi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormAddDurasi"
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel14.ResumeLayout(False)
        Panel14.PerformLayout()
        Panel13.ResumeLayout(False)
        FlowLayoutPanel1.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel10.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTambahPaket As Button
    Friend WithEvents tbDiscTable As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents tbHargaMalam As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LabelOpenTable As Label
    Friend WithEvents tbHargaSiang As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbNamaPaket As TextBox
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label17 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents namaPaket As DataGridViewTextBoxColumn
    Friend WithEvents hargaSiang As DataGridViewTextBoxColumn
    Friend WithEvents hargaMalam As DataGridViewTextBoxColumn
    Friend WithEvents akhirsiang As DataGridViewTextBoxColumn
    Friend WithEvents akhirMalam As DataGridViewTextBoxColumn
    Friend WithEvents discTable As DataGridViewTextBoxColumn
    Friend WithEvents cbAkhirSiang As ComboBox
    Friend WithEvents cbAkhirMalam As ComboBox
End Class
