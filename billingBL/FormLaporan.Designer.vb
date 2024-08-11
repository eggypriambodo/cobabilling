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
        comboBoxYears = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        no = New DataGridViewTextBoxColumn()
        noOrder = New DataGridViewTextBoxColumn()
        durasi = New DataGridViewTextBoxColumn()
        totalHarga = New DataGridViewTextBoxColumn()
        metodebayar = New DataGridViewTextBoxColumn()
        TanggalTransaksi = New DataGridViewTextBoxColumn()
        Label3 = New Label()
        labelTotalPemasukan = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' comboBoxYears
        ' 
        comboBoxYears.FormattingEnabled = True
        comboBoxYears.Location = New Point(550, 88)
        comboBoxYears.Name = "comboBoxYears"
        comboBoxYears.Size = New Size(180, 23)
        comboBoxYears.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(67, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(1021, 34)
        Label1.TabIndex = 11
        Label1.Text = "DATA LAPORAN PER TAHUN"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        Label1.UseCompatibleTextRendering = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(427, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 21)
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
        DataGridView1.Location = New Point(67, 177)
        DataGridView1.Margin = New Padding(44, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1021, 374)
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
        TanggalTransaksi.Name = "TanggalTransaksi"
        TanggalTransaksi.ReadOnly = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(818, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 21)
        Label3.TabIndex = 14
        Label3.Text = "Total Pemasukan :"
        ' 
        ' labelTotalPemasukan
        ' 
        labelTotalPemasukan.AutoSize = True
        labelTotalPemasukan.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelTotalPemasukan.Location = New Point(956, 150)
        labelTotalPemasukan.Name = "labelTotalPemasukan"
        labelTotalPemasukan.Size = New Size(0, 21)
        labelTotalPemasukan.TabIndex = 15
        ' 
        ' FormLaporan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1166, 562)
        Controls.Add(labelTotalPemasukan)
        Controls.Add(Label3)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(comboBoxYears)
        Name = "FormLaporan"
        Text = "FormLaporan"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents comboBoxYears As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents labelTotalPemasukan As Label
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents noOrder As DataGridViewTextBoxColumn
    Friend WithEvents durasi As DataGridViewTextBoxColumn
    Friend WithEvents totalHarga As DataGridViewTextBoxColumn
    Friend WithEvents metodebayar As DataGridViewTextBoxColumn
    Friend WithEvents TanggalTransaksi As DataGridViewTextBoxColumn
End Class
