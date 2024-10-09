<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporan
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
        Label1 = New Label()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        no = New DataGridViewTextBoxColumn()
        noOrder = New DataGridViewTextBoxColumn()
        durasi = New DataGridViewTextBoxColumn()
        totalHarga = New DataGridViewTextBoxColumn()
        metodebayar = New DataGridViewTextBoxColumn()
        TanggalTransaksi = New DataGridViewTextBoxColumn()
        labelTotalPemasukan = New Label()
        datePickerBefore = New DateTimePicker()
        datePickerAfter = New DateTimePicker()
        btnFilter = New Button()
        Panel1 = New Panel()
        Label3 = New Label()
        btnExport = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(77, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(1167, 45)
        Label1.TabIndex = 11
        Label1.Text = "DATA LAPORAN"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        Label1.UseCompatibleTextRendering = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(77, 178)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 28)
        Label2.TabIndex = 12
        Label2.Text = "Pilih Tahun"
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
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {no, noOrder, durasi, totalHarga, metodebayar, TanggalTransaksi})
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Location = New Point(77, 236)
        DataGridView1.Margin = New Padding(50, 3, 3, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1167, 499)
        DataGridView1.TabIndex = 13
        ' 
        ' no
        ' 
        no.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        no.FillWeight = 30F
        no.HeaderText = "No"
        no.MinimumWidth = 6
        no.Name = "no"
        no.ReadOnly = True
        ' 
        ' noOrder
        ' 
        noOrder.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        noOrder.FillWeight = 150F
        noOrder.HeaderText = "No Order"
        noOrder.MinimumWidth = 3
        noOrder.Name = "noOrder"
        noOrder.ReadOnly = True
        ' 
        ' durasi
        ' 
        durasi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        durasi.FillWeight = 75F
        durasi.HeaderText = "Durasi (menit)"
        durasi.MinimumWidth = 6
        durasi.Name = "durasi"
        durasi.ReadOnly = True
        ' 
        ' totalHarga
        ' 
        totalHarga.HeaderText = "Total Harga"
        totalHarga.MinimumWidth = 6
        totalHarga.Name = "totalHarga"
        totalHarga.ReadOnly = True
        totalHarga.Width = 125
        ' 
        ' metodebayar
        ' 
        metodebayar.HeaderText = "Metode Bayar"
        metodebayar.MinimumWidth = 6
        metodebayar.Name = "metodebayar"
        metodebayar.ReadOnly = True
        metodebayar.Width = 125
        ' 
        ' TanggalTransaksi
        ' 
        TanggalTransaksi.HeaderText = "Tanggal Transaksi"
        TanggalTransaksi.MinimumWidth = 6
        TanggalTransaksi.Name = "TanggalTransaksi"
        TanggalTransaksi.ReadOnly = True
        TanggalTransaksi.Width = 125
        ' 
        ' labelTotalPemasukan
        ' 
        labelTotalPemasukan.AutoSize = True
        labelTotalPemasukan.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelTotalPemasukan.ForeColor = SystemColors.ControlLightLight
        labelTotalPemasukan.Location = New Point(32, 53)
        labelTotalPemasukan.Name = "labelTotalPemasukan"
        labelTotalPemasukan.Size = New Size(0, 25)
        labelTotalPemasukan.TabIndex = 15
        ' 
        ' datePickerBefore
        ' 
        datePickerBefore.Location = New Point(209, 178)
        datePickerBefore.Name = "datePickerBefore"
        datePickerBefore.Size = New Size(166, 27)
        datePickerBefore.TabIndex = 16
        ' 
        ' datePickerAfter
        ' 
        datePickerAfter.Location = New Point(392, 178)
        datePickerAfter.Name = "datePickerAfter"
        datePickerAfter.Size = New Size(166, 27)
        datePickerAfter.TabIndex = 17
        ' 
        ' btnFilter
        ' 
        btnFilter.BackColor = SystemColors.MenuHighlight
        btnFilter.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFilter.ForeColor = SystemColors.Control
        btnFilter.Location = New Point(564, 173)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(103, 41)
        btnFilter.TabIndex = 0
        btnFilter.Text = "FILTER"
        btnFilter.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.MenuHighlight
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(labelTotalPemasukan)
        Panel1.Location = New Point(1047, 132)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(197, 98)
        Panel1.TabIndex = 20
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(32, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(165, 28)
        Label3.TabIndex = 16
        Label3.Text = "Total Pemasukan"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.Green
        btnExport.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExport.ForeColor = SystemColors.Control
        btnExport.Location = New Point(673, 173)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(103, 41)
        btnExport.TabIndex = 21
        btnExport.Text = "EXPORT"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' FormLaporan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1333, 749)
        Controls.Add(btnExport)
        Controls.Add(Panel1)
        Controls.Add(btnFilter)
        Controls.Add(datePickerAfter)
        Controls.Add(datePickerBefore)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormLaporan"
        Text = "FormLaporan"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents labelTotalPemasukan As Label
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents noOrder As DataGridViewTextBoxColumn
    Friend WithEvents durasi As DataGridViewTextBoxColumn
    Friend WithEvents totalHarga As DataGridViewTextBoxColumn
    Friend WithEvents metodebayar As DataGridViewTextBoxColumn
    Friend WithEvents TanggalTransaksi As DataGridViewTextBoxColumn
    Friend WithEvents datePickerBefore As DateTimePicker
    Friend WithEvents datePickerAfter As DateTimePicker
    Friend WithEvents btnFilter As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExport As Button
End Class
