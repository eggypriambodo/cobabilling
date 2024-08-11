<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPengaturan
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel6 = New Panel()
        btnTambahDurasi = New Button()
        btnHapusDurasi = New Button()
        DataGridView4 = New DataGridView()
        namaDurasi = New DataGridViewTextBoxColumn()
        hargaSiang = New DataGridViewTextBoxColumn()
        hargaMalam = New DataGridViewTextBoxColumn()
        akhirsiang = New DataGridViewTextBoxColumn()
        akhirMalam = New DataGridViewTextBoxColumn()
        discDurasi = New DataGridViewTextBoxColumn()
        Label4 = New Label()
        Panel4 = New Panel()
        btnTambahPromo = New Button()
        btnHapusPromo = New Button()
        DataGridView2 = New DataGridView()
        namaPaket = New DataGridViewTextBoxColumn()
        hargaPaket = New DataGridViewTextBoxColumn()
        durationPaket = New DataGridViewTextBoxColumn()
        discPaket = New DataGridViewTextBoxColumn()
        Label2 = New Label()
        Panel2 = New Panel()
        Panel5 = New Panel()
        btnTambahLos = New Button()
        btnHapusLos = New Button()
        DataGridView3 = New DataGridView()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn6 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn7 = New DataGridViewTextBoxColumn()
        discTable = New DataGridViewTextBoxColumn()
        Label3 = New Label()
        Panel1.SuspendLayout()
        Panel6.SuspendLayout()
        CType(DataGridView4, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1184, 41)
        Label1.TabIndex = 2
        Label1.Text = "Menu Admin"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(DataGridView4)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(DataGridView2)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(0, 44)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(580, 596)
        Panel1.TabIndex = 3
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(btnTambahDurasi)
        Panel6.Controls.Add(btnHapusDurasi)
        Panel6.Dock = DockStyle.Top
        Panel6.Location = New Point(0, 460)
        Panel6.Margin = New Padding(3, 2, 3, 2)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(580, 34)
        Panel6.TabIndex = 18
        ' 
        ' btnTambahDurasi
        ' 
        btnTambahDurasi.Dock = DockStyle.Right
        btnTambahDurasi.Location = New Point(416, 0)
        btnTambahDurasi.Margin = New Padding(3, 2, 3, 2)
        btnTambahDurasi.Name = "btnTambahDurasi"
        btnTambahDurasi.Size = New Size(82, 34)
        btnTambahDurasi.TabIndex = 1
        btnTambahDurasi.Text = "Tambah"
        btnTambahDurasi.UseVisualStyleBackColor = True
        ' 
        ' btnHapusDurasi
        ' 
        btnHapusDurasi.Dock = DockStyle.Right
        btnHapusDurasi.Location = New Point(498, 0)
        btnHapusDurasi.Margin = New Padding(3, 2, 3, 2)
        btnHapusDurasi.Name = "btnHapusDurasi"
        btnHapusDurasi.Size = New Size(82, 34)
        btnHapusDurasi.TabIndex = 0
        btnHapusDurasi.Text = "Hapus"
        btnHapusDurasi.UseVisualStyleBackColor = True
        ' 
        ' DataGridView4
        ' 
        DataGridView4.BackgroundColor = SystemColors.Control
        DataGridView4.BorderStyle = BorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.MenuHighlight
        DataGridViewCellStyle4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.Control
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridView4.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView4.Columns.AddRange(New DataGridViewColumn() {namaDurasi, hargaSiang, hargaMalam, akhirsiang, akhirMalam, discDurasi})
        DataGridView4.Dock = DockStyle.Top
        DataGridView4.EnableHeadersVisualStyles = False
        DataGridView4.Location = New Point(0, 270)
        DataGridView4.Margin = New Padding(3, 2, 3, 2)
        DataGridView4.Name = "DataGridView4"
        DataGridView4.ReadOnly = True
        DataGridView4.RowHeadersVisible = False
        DataGridView4.RowHeadersWidth = 51
        DataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView4.Size = New Size(580, 190)
        DataGridView4.TabIndex = 17
        ' 
        ' namaDurasi
        ' 
        namaDurasi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        namaDurasi.FillWeight = 175F
        namaDurasi.HeaderText = "Nama Paket"
        namaDurasi.MinimumWidth = 6
        namaDurasi.Name = "namaDurasi"
        namaDurasi.ReadOnly = True
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
        ' discDurasi
        ' 
        discDurasi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        discDurasi.FillWeight = 50F
        discDurasi.HeaderText = "Disc Table (%)"
        discDurasi.MinimumWidth = 6
        discDurasi.Name = "discDurasi"
        discDurasi.ReadOnly = True
        ' 
        ' Label4
        ' 
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Dock = DockStyle.Top
        Label4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(0, 247)
        Label4.Name = "Label4"
        Label4.Size = New Size(580, 23)
        Label4.TabIndex = 16
        Label4.Text = "Daftar Paket Durasi"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(btnTambahPromo)
        Panel4.Controls.Add(btnHapusPromo)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 213)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(580, 34)
        Panel4.TabIndex = 14
        ' 
        ' btnTambahPromo
        ' 
        btnTambahPromo.Dock = DockStyle.Right
        btnTambahPromo.Location = New Point(416, 0)
        btnTambahPromo.Margin = New Padding(3, 2, 3, 2)
        btnTambahPromo.Name = "btnTambahPromo"
        btnTambahPromo.Size = New Size(82, 34)
        btnTambahPromo.TabIndex = 1
        btnTambahPromo.Text = "Tambah"
        btnTambahPromo.UseVisualStyleBackColor = True
        ' 
        ' btnHapusPromo
        ' 
        btnHapusPromo.Dock = DockStyle.Right
        btnHapusPromo.Location = New Point(498, 0)
        btnHapusPromo.Margin = New Padding(3, 2, 3, 2)
        btnHapusPromo.Name = "btnHapusPromo"
        btnHapusPromo.Size = New Size(82, 34)
        btnHapusPromo.TabIndex = 0
        btnHapusPromo.Text = "Hapus"
        btnHapusPromo.UseVisualStyleBackColor = True
        ' 
        ' DataGridView2
        ' 
        DataGridView2.BackgroundColor = SystemColors.Control
        DataGridView2.BorderStyle = BorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.MenuHighlight
        DataGridViewCellStyle5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = SystemColors.Control
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {namaPaket, hargaPaket, durationPaket, discPaket})
        DataGridView2.Dock = DockStyle.Top
        DataGridView2.EnableHeadersVisualStyles = False
        DataGridView2.Location = New Point(0, 23)
        DataGridView2.Margin = New Padding(3, 2, 3, 2)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowHeadersVisible = False
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.Size = New Size(580, 190)
        DataGridView2.TabIndex = 13
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
        ' hargaPaket
        ' 
        hargaPaket.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        hargaPaket.HeaderText = "Harga (Rp)"
        hargaPaket.MinimumWidth = 6
        hargaPaket.Name = "hargaPaket"
        hargaPaket.ReadOnly = True
        ' 
        ' durationPaket
        ' 
        durationPaket.HeaderText = "Durasi"
        durationPaket.MinimumWidth = 6
        durationPaket.Name = "durationPaket"
        durationPaket.ReadOnly = True
        durationPaket.Width = 125
        ' 
        ' discPaket
        ' 
        discPaket.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        discPaket.FillWeight = 50F
        discPaket.HeaderText = "Disc Table (%)"
        discPaket.MinimumWidth = 6
        discPaket.Name = "discPaket"
        discPaket.ReadOnly = True
        ' 
        ' Label2
        ' 
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Dock = DockStyle.Top
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(580, 23)
        Label2.TabIndex = 12
        Label2.Text = "Daftar Paket Promo"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(DataGridView3)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(585, 44)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(580, 596)
        Panel2.TabIndex = 4
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(btnTambahLos)
        Panel5.Controls.Add(btnHapusLos)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 213)
        Panel5.Margin = New Padding(3, 2, 3, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(580, 34)
        Panel5.TabIndex = 14
        ' 
        ' btnTambahLos
        ' 
        btnTambahLos.Dock = DockStyle.Right
        btnTambahLos.Location = New Point(416, 0)
        btnTambahLos.Margin = New Padding(3, 2, 3, 2)
        btnTambahLos.Name = "btnTambahLos"
        btnTambahLos.Size = New Size(82, 34)
        btnTambahLos.TabIndex = 1
        btnTambahLos.Text = "Tambah"
        btnTambahLos.UseVisualStyleBackColor = True
        ' 
        ' btnHapusLos
        ' 
        btnHapusLos.Dock = DockStyle.Right
        btnHapusLos.Location = New Point(498, 0)
        btnHapusLos.Margin = New Padding(3, 2, 3, 2)
        btnHapusLos.Name = "btnHapusLos"
        btnHapusLos.Size = New Size(82, 34)
        btnHapusLos.TabIndex = 0
        btnHapusLos.Text = "Hapus"
        btnHapusLos.UseVisualStyleBackColor = True
        ' 
        ' DataGridView3
        ' 
        DataGridView3.BackgroundColor = SystemColors.Control
        DataGridView3.BorderStyle = BorderStyle.None
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.MenuHighlight
        DataGridViewCellStyle6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = SystemColors.Control
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5, DataGridViewTextBoxColumn6, DataGridViewTextBoxColumn7, discTable})
        DataGridView3.Dock = DockStyle.Top
        DataGridView3.EnableHeadersVisualStyles = False
        DataGridView3.Location = New Point(0, 23)
        DataGridView3.Margin = New Padding(3, 2, 3, 2)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.ReadOnly = True
        DataGridView3.RowHeadersVisible = False
        DataGridView3.RowHeadersWidth = 51
        DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView3.Size = New Size(580, 190)
        DataGridView3.TabIndex = 13
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn3.FillWeight = 175F
        DataGridViewTextBoxColumn3.HeaderText = "Nama Paket"
        DataGridViewTextBoxColumn3.MinimumWidth = 6
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn4.HeaderText = "Harga Siang "
        DataGridViewTextBoxColumn4.MinimumWidth = 6
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        DataGridViewTextBoxColumn4.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn5
        ' 
        DataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn5.HeaderText = "Harga Malam "
        DataGridViewTextBoxColumn5.MinimumWidth = 6
        DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        DataGridViewTextBoxColumn5.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn6
        ' 
        DataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn6.HeaderText = "Jam Akhir Harga Siang"
        DataGridViewTextBoxColumn6.MinimumWidth = 6
        DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        DataGridViewTextBoxColumn6.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn7
        ' 
        DataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn7.HeaderText = "Jam Akhir Harga Malam"
        DataGridViewTextBoxColumn7.MinimumWidth = 6
        DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        DataGridViewTextBoxColumn7.ReadOnly = True
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
        ' Label3
        ' 
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Dock = DockStyle.Top
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(580, 23)
        Label3.TabIndex = 9
        Label3.Text = "Daftar Paket Los Time"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormPengaturan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1184, 561)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "FormPengaturan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormPengaturan"
        Panel1.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        CType(DataGridView4, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnTambahPromo As Button
    Friend WithEvents btnHapusPromo As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents namaPaket As DataGridViewTextBoxColumn
    Friend WithEvents hargaPaket As DataGridViewTextBoxColumn
    Friend WithEvents durationPaket As DataGridViewTextBoxColumn
    Friend WithEvents discPaket As DataGridViewTextBoxColumn
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnTambahDurasi As Button
    Friend WithEvents btnHapusDurasi As Button
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents namaDurasi As DataGridViewTextBoxColumn
    Friend WithEvents hargaSiang As DataGridViewTextBoxColumn
    Friend WithEvents hargaMalam As DataGridViewTextBoxColumn
    Friend WithEvents akhirsiang As DataGridViewTextBoxColumn
    Friend WithEvents akhirMalam As DataGridViewTextBoxColumn
    Friend WithEvents discDurasi As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnTambahLos As Button
    Friend WithEvents btnHapusLos As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents discTable As DataGridViewTextBoxColumn
End Class
