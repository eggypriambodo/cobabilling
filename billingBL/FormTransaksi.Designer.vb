<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DataGridView1 = New DataGridView()
        no = New DataGridViewTextBoxColumn()
        jamMasuk = New DataGridViewTextBoxColumn()
        jamKeluar = New DataGridViewTextBoxColumn()
        durasi = New DataGridViewTextBoxColumn()
        totalHarga = New DataGridViewTextBoxColumn()
        bayar = New DataGridViewTextBoxColumn()
        kembalian = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.MenuHighlight
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.Control
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {no, jamMasuk, jamKeluar, durasi, totalHarga, bayar, kembalian})
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Location = New Point(59, 99)
        DataGridView1.Margin = New Padding(50, 3, 3, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1273, 499)
        DataGridView1.TabIndex = 11
        ' 
        ' no
        ' 
        no.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        no.FillWeight = 30F
        no.HeaderText = "No"
        no.MinimumWidth = 6
        no.Name = "no"
        ' 
        ' jamMasuk
        ' 
        jamMasuk.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        jamMasuk.FillWeight = 150F
        jamMasuk.HeaderText = "Jam Masuk"
        jamMasuk.MinimumWidth = 6
        jamMasuk.Name = "jamMasuk"
        ' 
        ' jamKeluar
        ' 
        jamKeluar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        jamKeluar.FillWeight = 150F
        jamKeluar.HeaderText = "Jam Keluar"
        jamKeluar.MinimumWidth = 6
        jamKeluar.Name = "jamKeluar"
        ' 
        ' durasi
        ' 
        durasi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        durasi.FillWeight = 75F
        durasi.HeaderText = "Durasi"
        durasi.MinimumWidth = 6
        durasi.Name = "durasi"
        ' 
        ' totalHarga
        ' 
        totalHarga.HeaderText = "Total Harga"
        totalHarga.MinimumWidth = 6
        totalHarga.Name = "totalHarga"
        totalHarga.Width = 125
        ' 
        ' bayar
        ' 
        bayar.HeaderText = "Bayar"
        bayar.MinimumWidth = 6
        bayar.Name = "bayar"
        bayar.Width = 125
        ' 
        ' kembalian
        ' 
        kembalian.HeaderText = "Kembali"
        kembalian.MinimumWidth = 6
        kembalian.Name = "kembalian"
        kembalian.Width = 125
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(59, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(1273, 46)
        Label1.TabIndex = 10
        Label1.Text = "DATA TRANSAKSI"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        Label1.UseCompatibleTextRendering = True
        ' 
        ' FormTransaksi
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1332, 853)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Name = "FormTransaksi"
        Text = "FormTransaksi"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents jamMasuk As DataGridViewTextBoxColumn
    Friend WithEvents jamKeluar As DataGridViewTextBoxColumn
    Friend WithEvents durasi As DataGridViewTextBoxColumn
    Friend WithEvents totalHarga As DataGridViewTextBoxColumn
    Friend WithEvents bayar As DataGridViewTextBoxColumn
    Friend WithEvents kembalian As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
