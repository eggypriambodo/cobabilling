<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDetailTable
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        labelNoTable = New Label()
        labelWaktuSelesai = New Label()
        labelWaktuMulai = New Label()
        labelJenisPaket = New Label()
        labelPaket = New Label()
        labelNoOrder = New Label()
        labelTanggal = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        labelDuration = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        tbNamaTamu = New TextBox()
        Label39 = New Label()
        tbUangKembalian = New TextBox()
        Label38 = New Label()
        tbUangDiterima = New TextBox()
        Label37 = New Label()
        tboxKeterangan = New TextBox()
        Label19 = New Label()
        tboxGrandTotal = New TextBox()
        Label36 = New Label()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        rbtnCash = New RadioButton()
        rbtnQRIS = New RadioButton()
        rbtnDebit = New RadioButton()
        rbtnTransfer = New RadioButton()
        btnCetak = New Button()
        btnBayar = New Button()
        TableLayoutPanel3 = New TableLayoutPanel()
        labelPPn = New Label()
        labelTaxService = New Label()
        labelTotalTable = New Label()
        labelDiskonTable = New Label()
        labelSubtotalTable = New Label()
        Label49 = New Label()
        Label54 = New Label()
        Label55 = New Label()
        Label47 = New Label()
        Label48 = New Label()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(905, 70)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Top
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(0, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(903, 15)
        Label2.TabIndex = 1
        Label2.Text = "Jl. MT. Haryono No.195-197, Dinoyo, Kec. Lowokwaru, Kota Malang, Jawa Timur 65144"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI Semibold", 25.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(903, 44)
        Label1.TabIndex = 0
        Label1.Text = "XYZ BILLIARD"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 34.20366F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65.79634F))
        TableLayoutPanel1.Controls.Add(labelNoTable, 1, 6)
        TableLayoutPanel1.Controls.Add(labelWaktuSelesai, 1, 5)
        TableLayoutPanel1.Controls.Add(labelWaktuMulai, 1, 4)
        TableLayoutPanel1.Controls.Add(labelJenisPaket, 1, 3)
        TableLayoutPanel1.Controls.Add(labelPaket, 1, 2)
        TableLayoutPanel1.Controls.Add(labelNoOrder, 1, 1)
        TableLayoutPanel1.Controls.Add(labelTanggal, 1, 0)
        TableLayoutPanel1.Controls.Add(Label4, 0, 1)
        TableLayoutPanel1.Controls.Add(Label5, 0, 2)
        TableLayoutPanel1.Controls.Add(Label3, 0, 0)
        TableLayoutPanel1.Controls.Add(labelDuration, 1, 7)
        TableLayoutPanel1.Controls.Add(Label10, 0, 3)
        TableLayoutPanel1.Controls.Add(Label9, 0, 7)
        TableLayoutPanel1.Controls.Add(Label7, 0, 4)
        TableLayoutPanel1.Controls.Add(Label6, 0, 6)
        TableLayoutPanel1.Controls.Add(Label8, 0, 5)
        TableLayoutPanel1.Location = New Point(10, 74)
        TableLayoutPanel1.Margin = New Padding(3, 2, 3, 2)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 8
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5006237F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5006247F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5006247F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5006247F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5006247F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5006247F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5006237F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.4956264F))
        TableLayoutPanel1.Size = New Size(262, 243)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' labelNoTable
        ' 
        labelNoTable.AutoSize = True
        labelNoTable.Dock = DockStyle.Right
        labelNoTable.Font = New Font("Segoe UI", 8F)
        labelNoTable.Location = New Point(238, 180)
        labelNoTable.Name = "labelNoTable"
        labelNoTable.Size = New Size(21, 30)
        labelNoTable.TabIndex = 23
        labelNoTable.Text = ";-;-"
        labelNoTable.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelWaktuSelesai
        ' 
        labelWaktuSelesai.AutoSize = True
        labelWaktuSelesai.Dock = DockStyle.Right
        labelWaktuSelesai.Font = New Font("Segoe UI", 8F)
        labelWaktuSelesai.Location = New Point(238, 150)
        labelWaktuSelesai.Name = "labelWaktuSelesai"
        labelWaktuSelesai.Size = New Size(21, 30)
        labelWaktuSelesai.TabIndex = 22
        labelWaktuSelesai.Text = ";-;-"
        labelWaktuSelesai.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelWaktuMulai
        ' 
        labelWaktuMulai.AutoSize = True
        labelWaktuMulai.Dock = DockStyle.Right
        labelWaktuMulai.Font = New Font("Segoe UI", 8F)
        labelWaktuMulai.Location = New Point(238, 120)
        labelWaktuMulai.Name = "labelWaktuMulai"
        labelWaktuMulai.Size = New Size(21, 30)
        labelWaktuMulai.TabIndex = 21
        labelWaktuMulai.Text = ";-;-"
        labelWaktuMulai.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelJenisPaket
        ' 
        labelJenisPaket.AutoSize = True
        labelJenisPaket.Dock = DockStyle.Right
        labelJenisPaket.Font = New Font("Segoe UI", 8F)
        labelJenisPaket.Location = New Point(238, 90)
        labelJenisPaket.Name = "labelJenisPaket"
        labelJenisPaket.Size = New Size(21, 30)
        labelJenisPaket.TabIndex = 20
        labelJenisPaket.Text = ";-;-"
        labelJenisPaket.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelPaket
        ' 
        labelPaket.AutoSize = True
        labelPaket.Dock = DockStyle.Right
        labelPaket.Font = New Font("Segoe UI", 8F)
        labelPaket.Location = New Point(238, 60)
        labelPaket.Name = "labelPaket"
        labelPaket.Size = New Size(21, 30)
        labelPaket.TabIndex = 19
        labelPaket.Text = ";-;-"
        labelPaket.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelNoOrder
        ' 
        labelNoOrder.AutoSize = True
        labelNoOrder.Dock = DockStyle.Right
        labelNoOrder.Font = New Font("Segoe UI", 8F)
        labelNoOrder.Location = New Point(238, 30)
        labelNoOrder.Name = "labelNoOrder"
        labelNoOrder.Size = New Size(21, 30)
        labelNoOrder.TabIndex = 18
        labelNoOrder.Text = ";-;-"
        labelNoOrder.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelTanggal
        ' 
        labelTanggal.AutoSize = True
        labelTanggal.Dock = DockStyle.Right
        labelTanggal.Font = New Font("Segoe UI", 8F)
        labelTanggal.Location = New Point(238, 0)
        labelTanggal.Name = "labelTanggal"
        labelTanggal.Size = New Size(21, 30)
        labelTanggal.TabIndex = 17
        labelTanggal.Text = ";-;-"
        labelTanggal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 8F)
        Label4.Location = New Point(3, 30)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 30)
        Label4.TabIndex = 1
        Label4.Text = "No Order:"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 8F)
        Label5.Location = New Point(3, 60)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 30)
        Label5.TabIndex = 2
        Label5.Text = "Paket:"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 8F)
        Label3.Location = New Point(3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 30)
        Label3.TabIndex = 0
        Label3.Text = "Tanggal:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' labelDuration
        ' 
        labelDuration.AutoSize = True
        labelDuration.Dock = DockStyle.Right
        labelDuration.Font = New Font("Segoe UI", 8F)
        labelDuration.Location = New Point(238, 210)
        labelDuration.Name = "labelDuration"
        labelDuration.Size = New Size(21, 33)
        labelDuration.TabIndex = 25
        labelDuration.Text = ";-;-"
        labelDuration.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Segoe UI", 8F)
        Label10.Location = New Point(3, 90)
        Label10.Name = "Label10"
        Label10.Size = New Size(83, 30)
        Label10.TabIndex = 24
        Label10.Text = "Jenis Paket:"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Segoe UI", 8F)
        Label9.Location = New Point(3, 210)
        Label9.Name = "Label9"
        Label9.Size = New Size(83, 33)
        Label9.TabIndex = 6
        Label9.Text = "Durasi:"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Segoe UI", 8F)
        Label7.Location = New Point(3, 120)
        Label7.Name = "Label7"
        Label7.Size = New Size(83, 30)
        Label7.TabIndex = 4
        Label7.Text = "Mulai:"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Segoe UI", 8F)
        Label6.Location = New Point(3, 180)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 30)
        Label6.TabIndex = 3
        Label6.Text = "Table:"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Segoe UI", 8F)
        Label8.Location = New Point(3, 150)
        Label8.Name = "Label8"
        Label8.Size = New Size(83, 30)
        Label8.TabIndex = 5
        Label8.Text = "Selesai:"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(tbNamaTamu, 1, 4)
        TableLayoutPanel2.Controls.Add(Label39, 0, 4)
        TableLayoutPanel2.Controls.Add(tbUangKembalian, 1, 3)
        TableLayoutPanel2.Controls.Add(Label38, 0, 3)
        TableLayoutPanel2.Controls.Add(tbUangDiterima, 1, 2)
        TableLayoutPanel2.Controls.Add(Label37, 0, 2)
        TableLayoutPanel2.Controls.Add(tboxKeterangan, 1, 1)
        TableLayoutPanel2.Controls.Add(Label19, 0, 0)
        TableLayoutPanel2.Controls.Add(tboxGrandTotal, 1, 0)
        TableLayoutPanel2.Controls.Add(Label36, 0, 1)
        TableLayoutPanel2.Location = New Point(565, 74)
        TableLayoutPanel2.Margin = New Padding(3, 2, 3, 2)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 5
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0000038F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0000038F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 19.9999981F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 19.9999981F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 19.9999981F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 15F))
        TableLayoutPanel2.Size = New Size(316, 243)
        TableLayoutPanel2.TabIndex = 3
        ' 
        ' tbNamaTamu
        ' 
        tbNamaTamu.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tbNamaTamu.Enabled = False
        tbNamaTamu.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbNamaTamu.Location = New Point(161, 201)
        tbNamaTamu.Margin = New Padding(3, 9, 3, 2)
        tbNamaTamu.Name = "tbNamaTamu"
        tbNamaTamu.Size = New Size(152, 26)
        tbNamaTamu.TabIndex = 11
        tbNamaTamu.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label39
        ' 
        Label39.AutoSize = True
        Label39.Dock = DockStyle.Fill
        Label39.Font = New Font("Segoe UI", 9F)
        Label39.Location = New Point(3, 192)
        Label39.Name = "Label39"
        Label39.Size = New Size(152, 51)
        Label39.TabIndex = 10
        Label39.Text = "Nama Tamu"
        Label39.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' tbUangKembalian
        ' 
        tbUangKembalian.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tbUangKembalian.Enabled = False
        tbUangKembalian.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbUangKembalian.Location = New Point(161, 153)
        tbUangKembalian.Margin = New Padding(3, 9, 3, 2)
        tbUangKembalian.Name = "tbUangKembalian"
        tbUangKembalian.Size = New Size(152, 26)
        tbUangKembalian.TabIndex = 9
        tbUangKembalian.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Dock = DockStyle.Fill
        Label38.Font = New Font("Segoe UI", 9F)
        Label38.Location = New Point(3, 144)
        Label38.Name = "Label38"
        Label38.Size = New Size(152, 48)
        Label38.TabIndex = 8
        Label38.Text = "Uang Kembalian (Rp)"
        Label38.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' tbUangDiterima
        ' 
        tbUangDiterima.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tbUangDiterima.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbUangDiterima.Location = New Point(161, 105)
        tbUangDiterima.Margin = New Padding(3, 9, 3, 2)
        tbUangDiterima.Name = "tbUangDiterima"
        tbUangDiterima.Size = New Size(152, 26)
        tbUangDiterima.TabIndex = 7
        tbUangDiterima.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Dock = DockStyle.Fill
        Label37.Font = New Font("Segoe UI", 9F)
        Label37.Location = New Point(3, 96)
        Label37.Name = "Label37"
        Label37.Size = New Size(152, 48)
        Label37.TabIndex = 6
        Label37.Text = "Uang Diterima (Rp)"
        Label37.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' tboxKeterangan
        ' 
        tboxKeterangan.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tboxKeterangan.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tboxKeterangan.Location = New Point(161, 57)
        tboxKeterangan.Margin = New Padding(3, 9, 3, 2)
        tboxKeterangan.Multiline = True
        tboxKeterangan.Name = "tboxKeterangan"
        tboxKeterangan.Size = New Size(152, 37)
        tboxKeterangan.TabIndex = 5
        tboxKeterangan.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Dock = DockStyle.Fill
        Label19.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(3, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(152, 48)
        Label19.TabIndex = 0
        Label19.Text = "Grand Total (Rp)"
        Label19.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' tboxGrandTotal
        ' 
        tboxGrandTotal.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tboxGrandTotal.Enabled = False
        tboxGrandTotal.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tboxGrandTotal.Location = New Point(161, 9)
        tboxGrandTotal.Margin = New Padding(3, 9, 3, 2)
        tboxGrandTotal.Name = "tboxGrandTotal"
        tboxGrandTotal.Size = New Size(152, 26)
        tboxGrandTotal.TabIndex = 2
        tboxGrandTotal.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Dock = DockStyle.Fill
        Label36.Font = New Font("Segoe UI", 9F)
        Label36.Location = New Point(3, 48)
        Label36.Name = "Label36"
        Label36.Size = New Size(152, 48)
        Label36.TabIndex = 4
        Label36.Text = "Keterangan"
        Label36.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(rbtnCash)
        FlowLayoutPanel2.Controls.Add(rbtnQRIS)
        FlowLayoutPanel2.Controls.Add(rbtnDebit)
        FlowLayoutPanel2.Controls.Add(rbtnTransfer)
        FlowLayoutPanel2.Location = New Point(298, 267)
        FlowLayoutPanel2.Margin = New Padding(3, 2, 3, 2)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(260, 23)
        FlowLayoutPanel2.TabIndex = 4
        ' 
        ' rbtnCash
        ' 
        rbtnCash.AutoSize = True
        rbtnCash.Dock = DockStyle.Bottom
        rbtnCash.Location = New Point(3, 2)
        rbtnCash.Margin = New Padding(3, 2, 3, 2)
        rbtnCash.Name = "rbtnCash"
        rbtnCash.Size = New Size(51, 19)
        rbtnCash.TabIndex = 0
        rbtnCash.TabStop = True
        rbtnCash.Text = "Cash"
        rbtnCash.UseVisualStyleBackColor = True
        ' 
        ' rbtnQRIS
        ' 
        rbtnQRIS.AutoSize = True
        rbtnQRIS.Dock = DockStyle.Bottom
        rbtnQRIS.Location = New Point(60, 2)
        rbtnQRIS.Margin = New Padding(3, 2, 3, 2)
        rbtnQRIS.Name = "rbtnQRIS"
        rbtnQRIS.Size = New Size(50, 19)
        rbtnQRIS.TabIndex = 1
        rbtnQRIS.TabStop = True
        rbtnQRIS.Text = "QRIS"
        rbtnQRIS.UseVisualStyleBackColor = True
        ' 
        ' rbtnDebit
        ' 
        rbtnDebit.AutoSize = True
        rbtnDebit.Dock = DockStyle.Bottom
        rbtnDebit.Location = New Point(116, 2)
        rbtnDebit.Margin = New Padding(3, 2, 3, 2)
        rbtnDebit.Name = "rbtnDebit"
        rbtnDebit.Size = New Size(53, 19)
        rbtnDebit.TabIndex = 2
        rbtnDebit.TabStop = True
        rbtnDebit.Text = "Debit"
        rbtnDebit.UseVisualStyleBackColor = True
        ' 
        ' rbtnTransfer
        ' 
        rbtnTransfer.AutoSize = True
        rbtnTransfer.Dock = DockStyle.Bottom
        rbtnTransfer.Location = New Point(175, 2)
        rbtnTransfer.Margin = New Padding(3, 2, 3, 2)
        rbtnTransfer.Name = "rbtnTransfer"
        rbtnTransfer.Size = New Size(66, 19)
        rbtnTransfer.TabIndex = 3
        rbtnTransfer.TabStop = True
        rbtnTransfer.Text = "Transfer"
        rbtnTransfer.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(724, 334)
        btnCetak.Margin = New Padding(3, 2, 3, 2)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(78, 30)
        btnCetak.TabIndex = 2
        btnCetak.Text = "CETAK"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' btnBayar
        ' 
        btnBayar.Location = New Point(807, 334)
        btnBayar.Margin = New Padding(3, 2, 3, 2)
        btnBayar.Name = "btnBayar"
        btnBayar.Size = New Size(74, 30)
        btnBayar.TabIndex = 13
        btnBayar.Text = "BAYAR"
        btnBayar.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 44.14716F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 55.8528442F))
        TableLayoutPanel3.Controls.Add(labelPPn, 1, 4)
        TableLayoutPanel3.Controls.Add(labelTaxService, 1, 3)
        TableLayoutPanel3.Controls.Add(labelTotalTable, 1, 2)
        TableLayoutPanel3.Controls.Add(labelDiskonTable, 1, 1)
        TableLayoutPanel3.Controls.Add(labelSubtotalTable, 1, 0)
        TableLayoutPanel3.Controls.Add(Label49, 0, 2)
        TableLayoutPanel3.Controls.Add(Label54, 0, 3)
        TableLayoutPanel3.Controls.Add(Label55, 0, 4)
        TableLayoutPanel3.Controls.Add(Label47, 0, 1)
        TableLayoutPanel3.Controls.Add(Label48, 0, 0)
        TableLayoutPanel3.Location = New Point(298, 74)
        TableLayoutPanel3.Margin = New Padding(3, 2, 3, 2)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 5
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 19.9999981F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0000019F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0000019F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 19.9999981F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0000019F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 15F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 15F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 15F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Absolute, 15F))
        TableLayoutPanel3.Size = New Size(262, 178)
        TableLayoutPanel3.TabIndex = 6
        ' 
        ' labelPPn
        ' 
        labelPPn.AutoSize = True
        labelPPn.Dock = DockStyle.Right
        labelPPn.Font = New Font("Segoe UI", 8F)
        labelPPn.Location = New Point(238, 140)
        labelPPn.Name = "labelPPn"
        labelPPn.Size = New Size(21, 38)
        labelPPn.TabIndex = 32
        labelPPn.Text = ";-;-"
        labelPPn.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelTaxService
        ' 
        labelTaxService.AutoSize = True
        labelTaxService.Dock = DockStyle.Right
        labelTaxService.Font = New Font("Segoe UI", 8F)
        labelTaxService.Location = New Point(238, 105)
        labelTaxService.Name = "labelTaxService"
        labelTaxService.Size = New Size(21, 35)
        labelTaxService.TabIndex = 31
        labelTaxService.Text = ";-;-"
        labelTaxService.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelTotalTable
        ' 
        labelTotalTable.AutoSize = True
        labelTotalTable.Dock = DockStyle.Right
        labelTotalTable.Font = New Font("Segoe UI", 8F)
        labelTotalTable.Location = New Point(238, 70)
        labelTotalTable.Name = "labelTotalTable"
        labelTotalTable.Size = New Size(21, 35)
        labelTotalTable.TabIndex = 26
        labelTotalTable.Text = ";-;-"
        labelTotalTable.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelDiskonTable
        ' 
        labelDiskonTable.AutoSize = True
        labelDiskonTable.Dock = DockStyle.Right
        labelDiskonTable.Font = New Font("Segoe UI", 8F)
        labelDiskonTable.Location = New Point(238, 35)
        labelDiskonTable.Name = "labelDiskonTable"
        labelDiskonTable.Size = New Size(21, 35)
        labelDiskonTable.TabIndex = 25
        labelDiskonTable.Text = ";-;-"
        labelDiskonTable.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelSubtotalTable
        ' 
        labelSubtotalTable.AutoSize = True
        labelSubtotalTable.Dock = DockStyle.Right
        labelSubtotalTable.Font = New Font("Segoe UI", 8F)
        labelSubtotalTable.Location = New Point(238, 0)
        labelSubtotalTable.Name = "labelSubtotalTable"
        labelSubtotalTable.Size = New Size(21, 35)
        labelSubtotalTable.TabIndex = 24
        labelSubtotalTable.Text = ";-;-"
        labelSubtotalTable.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label49
        ' 
        Label49.Font = New Font("Segoe UI", 8F)
        Label49.Location = New Point(3, 70)
        Label49.Name = "Label49"
        Label49.Size = New Size(109, 35)
        Label49.TabIndex = 9
        Label49.Text = "Total Table (Rp)"
        Label49.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label54
        ' 
        Label54.Font = New Font("Segoe UI", 8F)
        Label54.Location = New Point(3, 105)
        Label54.Name = "Label54"
        Label54.Size = New Size(109, 35)
        Label54.TabIndex = 14
        Label54.Text = "Tax Service 5%"
        Label54.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label55
        ' 
        Label55.Font = New Font("Segoe UI", 8F)
        Label55.Location = New Point(3, 140)
        Label55.Name = "Label55"
        Label55.Size = New Size(109, 37)
        Label55.TabIndex = 15
        Label55.Text = "PPn 11%"
        Label55.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label47
        ' 
        Label47.Font = New Font("Segoe UI", 8F)
        Label47.Location = New Point(3, 35)
        Label47.Name = "Label47"
        Label47.Size = New Size(109, 35)
        Label47.TabIndex = 7
        Label47.Text = "Diskon Table (%)"
        Label47.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label48
        ' 
        Label48.Font = New Font("Segoe UI", 8F)
        Label48.Location = New Point(3, 0)
        Label48.Name = "Label48"
        Label48.Size = New Size(109, 35)
        Label48.TabIndex = 8
        Label48.Text = "Subtotal Table (Rp)"
        Label48.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' FormDetailTable
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(905, 373)
        Controls.Add(btnCetak)
        Controls.Add(TableLayoutPanel3)
        Controls.Add(btnBayar)
        Controls.Add(FlowLayoutPanel2)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        Name = "FormDetailTable"
        Text = "FormDetailTable"
        Panel1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents labelNoTable As Label
    Friend WithEvents labelWaktuSelesai As Label
    Friend WithEvents labelWaktuMulai As Label
    Friend WithEvents labelJenisPaket As Label
    Friend WithEvents labelPaket As Label
    Friend WithEvents labelNoOrder As Label
    Friend WithEvents labelTanggal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label19 As Label
    Friend WithEvents tboxGrandTotal As TextBox
    Friend WithEvents tbNamaTamu As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents tbUangKembalian As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents tbUangDiterima As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents tboxKeterangan As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents rbtnCash As RadioButton
    Friend WithEvents rbtnQRIS As RadioButton
    Friend WithEvents rbtnDebit As RadioButton
    Friend WithEvents rbtnTransfer As RadioButton
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnBayar As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents labelPPn As Label
    Friend WithEvents labelTaxService As Label
    Friend WithEvents labelTotalTable As Label
    Friend WithEvents labelDiskonTable As Label
    Friend WithEvents labelSubtotalTable As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents labelDuration As Label
    Friend WithEvents Label10 As Label
End Class