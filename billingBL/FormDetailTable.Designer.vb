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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label41 = New Label()
        DataGridView1 = New DataGridView()
        namaFnB = New DataGridViewTextBoxColumn()
        hargaFnB = New DataGridViewTextBoxColumn()
        qtyFnB = New DataGridViewTextBoxColumn()
        totalFnB = New DataGridViewTextBoxColumn()
        TableLayoutPanel1 = New TableLayoutPanel()
        labelPPn = New Label()
        labelTaxService = New Label()
        labelSubtotal = New Label()
        labelTotalFnB = New Label()
        labelDiskonFnB = New Label()
        labelSubtotalFnB = New Label()
        labelTotalTable = New Label()
        labelDiskonTable = New Label()
        labelSubtotalTable = New Label()
        labelDuration = New Label()
        labelWaktuSelesai = New Label()
        labelWaktuMulai = New Label()
        labelNoTable = New Label()
        labelPaket = New Label()
        labelNoOrder = New Label()
        labelTanggal = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        TableLayoutPanel2 = New TableLayoutPanel()
        tbNamaTamu = New TextBox()
        Label39 = New Label()
        tbUangKembalian = New TextBox()
        Label38 = New Label()
        tbUangDiterima = New TextBox()
        Label37 = New Label()
        tboxKeterangan = New TextBox()
        tboxDiskonKhusus = New TextBox()
        Label19 = New Label()
        cboxDiskonKhusus = New CheckBox()
        tboxGrandTotal = New TextBox()
        Label36 = New Label()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        rbtnCash = New RadioButton()
        rbtnQRIS = New RadioButton()
        rbtnDebit = New RadioButton()
        rbtnTransfer = New RadioButton()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        Label40 = New Label()
        tbReferensi = New TextBox()
        btnCetak = New Button()
        btnBayar = New Button()
        Panel1.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        FlowLayoutPanel3.SuspendLayout()
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
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1034, 93)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Top
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(0, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(1032, 20)
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
        Label1.Size = New Size(1032, 59)
        Label1.TabIndex = 0
        Label1.Text = "XYZ BILLIARD"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(Label41)
        FlowLayoutPanel1.Controls.Add(DataGridView1)
        FlowLayoutPanel1.Location = New Point(1, 99)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(336, 324)
        FlowLayoutPanel1.TabIndex = 1
        ' 
        ' Label41
        ' 
        Label41.BackColor = SystemColors.Control
        Label41.BorderStyle = BorderStyle.FixedSingle
        Label41.Location = New Point(3, 0)
        Label41.Name = "Label41"
        Label41.Size = New Size(333, 25)
        Label41.TabIndex = 1
        Label41.Text = "Daftar FnB"
        Label41.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {namaFnB, hargaFnB, qtyFnB, totalFnB})
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Location = New Point(3, 28)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(330, 285)
        DataGridView1.TabIndex = 0
        ' 
        ' namaFnB
        ' 
        namaFnB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        namaFnB.HeaderText = "Nama"
        namaFnB.MinimumWidth = 6
        namaFnB.Name = "namaFnB"
        ' 
        ' hargaFnB
        ' 
        hargaFnB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        hargaFnB.FillWeight = 75F
        hargaFnB.HeaderText = "Harga"
        hargaFnB.MinimumWidth = 6
        hargaFnB.Name = "hargaFnB"
        ' 
        ' qtyFnB
        ' 
        qtyFnB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        qtyFnB.FillWeight = 50F
        qtyFnB.HeaderText = "Qty"
        qtyFnB.MinimumWidth = 6
        qtyFnB.Name = "qtyFnB"
        ' 
        ' totalFnB
        ' 
        totalFnB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        totalFnB.FillWeight = 75F
        totalFnB.HeaderText = "Total"
        totalFnB.MinimumWidth = 6
        totalFnB.Name = "totalFnB"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 34.2036552F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 65.79634F))
        TableLayoutPanel1.Controls.Add(labelPPn, 1, 15)
        TableLayoutPanel1.Controls.Add(labelTaxService, 1, 14)
        TableLayoutPanel1.Controls.Add(labelSubtotal, 1, 13)
        TableLayoutPanel1.Controls.Add(labelTotalFnB, 1, 12)
        TableLayoutPanel1.Controls.Add(labelDiskonFnB, 1, 11)
        TableLayoutPanel1.Controls.Add(labelSubtotalFnB, 1, 10)
        TableLayoutPanel1.Controls.Add(labelTotalTable, 1, 9)
        TableLayoutPanel1.Controls.Add(labelDiskonTable, 1, 8)
        TableLayoutPanel1.Controls.Add(labelSubtotalTable, 1, 7)
        TableLayoutPanel1.Controls.Add(labelDuration, 1, 6)
        TableLayoutPanel1.Controls.Add(labelWaktuSelesai, 1, 5)
        TableLayoutPanel1.Controls.Add(labelWaktuMulai, 1, 4)
        TableLayoutPanel1.Controls.Add(labelNoTable, 1, 3)
        TableLayoutPanel1.Controls.Add(labelPaket, 1, 2)
        TableLayoutPanel1.Controls.Add(labelNoOrder, 1, 1)
        TableLayoutPanel1.Controls.Add(labelTanggal, 1, 0)
        TableLayoutPanel1.Controls.Add(Label3, 0, 0)
        TableLayoutPanel1.Controls.Add(Label4, 0, 1)
        TableLayoutPanel1.Controls.Add(Label5, 0, 2)
        TableLayoutPanel1.Controls.Add(Label6, 0, 3)
        TableLayoutPanel1.Controls.Add(Label7, 0, 4)
        TableLayoutPanel1.Controls.Add(Label8, 0, 5)
        TableLayoutPanel1.Controls.Add(Label9, 0, 6)
        TableLayoutPanel1.Controls.Add(Label10, 0, 8)
        TableLayoutPanel1.Controls.Add(Label11, 0, 7)
        TableLayoutPanel1.Controls.Add(Label12, 0, 9)
        TableLayoutPanel1.Controls.Add(Label13, 0, 10)
        TableLayoutPanel1.Controls.Add(Label14, 0, 11)
        TableLayoutPanel1.Controls.Add(Label15, 0, 12)
        TableLayoutPanel1.Controls.Add(Label16, 0, 13)
        TableLayoutPanel1.Controls.Add(Label17, 0, 14)
        TableLayoutPanel1.Controls.Add(Label18, 0, 15)
        TableLayoutPanel1.Location = New Point(341, 99)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 16
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5.88235235F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5.88235235F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5.88235235F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5.88235235F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5.88235235F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5.88235235F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5.88235235F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5.88235235F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5.88235235F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5.88235235F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5.88235235F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5.88235235F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5.88235235F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5.88235235F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5.88235235F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 5.88235235F))
        TableLayoutPanel1.Size = New Size(299, 324)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' labelPPn
        ' 
        labelPPn.AutoSize = True
        labelPPn.Dock = DockStyle.Right
        labelPPn.Font = New Font("Segoe UI", 8F)
        labelPPn.Location = New Point(269, 300)
        labelPPn.Name = "labelPPn"
        labelPPn.Size = New Size(27, 24)
        labelPPn.TabIndex = 32
        labelPPn.Text = ";-;-"
        labelPPn.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelTaxService
        ' 
        labelTaxService.AutoSize = True
        labelTaxService.Dock = DockStyle.Right
        labelTaxService.Font = New Font("Segoe UI", 8F)
        labelTaxService.Location = New Point(269, 280)
        labelTaxService.Name = "labelTaxService"
        labelTaxService.Size = New Size(27, 20)
        labelTaxService.TabIndex = 31
        labelTaxService.Text = ";-;-"
        labelTaxService.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelSubtotal
        ' 
        labelSubtotal.AutoSize = True
        labelSubtotal.Dock = DockStyle.Right
        labelSubtotal.Font = New Font("Segoe UI", 8F)
        labelSubtotal.Location = New Point(269, 260)
        labelSubtotal.Name = "labelSubtotal"
        labelSubtotal.Size = New Size(27, 20)
        labelSubtotal.TabIndex = 30
        labelSubtotal.Text = ";-;-"
        labelSubtotal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelTotalFnB
        ' 
        labelTotalFnB.AutoSize = True
        labelTotalFnB.Dock = DockStyle.Right
        labelTotalFnB.Font = New Font("Segoe UI", 8F)
        labelTotalFnB.Location = New Point(269, 240)
        labelTotalFnB.Name = "labelTotalFnB"
        labelTotalFnB.Size = New Size(27, 20)
        labelTotalFnB.TabIndex = 29
        labelTotalFnB.Text = ";-;-"
        labelTotalFnB.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelDiskonFnB
        ' 
        labelDiskonFnB.AutoSize = True
        labelDiskonFnB.Dock = DockStyle.Right
        labelDiskonFnB.Font = New Font("Segoe UI", 8F)
        labelDiskonFnB.Location = New Point(269, 220)
        labelDiskonFnB.Name = "labelDiskonFnB"
        labelDiskonFnB.Size = New Size(27, 20)
        labelDiskonFnB.TabIndex = 28
        labelDiskonFnB.Text = ";-;-"
        labelDiskonFnB.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelSubtotalFnB
        ' 
        labelSubtotalFnB.AutoSize = True
        labelSubtotalFnB.Dock = DockStyle.Right
        labelSubtotalFnB.Font = New Font("Segoe UI", 8F)
        labelSubtotalFnB.Location = New Point(269, 200)
        labelSubtotalFnB.Name = "labelSubtotalFnB"
        labelSubtotalFnB.Size = New Size(27, 20)
        labelSubtotalFnB.TabIndex = 27
        labelSubtotalFnB.Text = ";-;-"
        labelSubtotalFnB.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelTotalTable
        ' 
        labelTotalTable.AutoSize = True
        labelTotalTable.Dock = DockStyle.Right
        labelTotalTable.Font = New Font("Segoe UI", 8F)
        labelTotalTable.Location = New Point(269, 180)
        labelTotalTable.Name = "labelTotalTable"
        labelTotalTable.Size = New Size(27, 20)
        labelTotalTable.TabIndex = 26
        labelTotalTable.Text = ";-;-"
        labelTotalTable.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelDiskonTable
        ' 
        labelDiskonTable.AutoSize = True
        labelDiskonTable.Dock = DockStyle.Right
        labelDiskonTable.Font = New Font("Segoe UI", 8F)
        labelDiskonTable.Location = New Point(269, 160)
        labelDiskonTable.Name = "labelDiskonTable"
        labelDiskonTable.Size = New Size(27, 20)
        labelDiskonTable.TabIndex = 25
        labelDiskonTable.Text = ";-;-"
        labelDiskonTable.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelSubtotalTable
        ' 
        labelSubtotalTable.AutoSize = True
        labelSubtotalTable.Dock = DockStyle.Right
        labelSubtotalTable.Font = New Font("Segoe UI", 8F)
        labelSubtotalTable.Location = New Point(269, 140)
        labelSubtotalTable.Name = "labelSubtotalTable"
        labelSubtotalTable.Size = New Size(27, 20)
        labelSubtotalTable.TabIndex = 24
        labelSubtotalTable.Text = ";-;-"
        labelSubtotalTable.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelDuration
        ' 
        labelDuration.AutoSize = True
        labelDuration.Dock = DockStyle.Right
        labelDuration.Font = New Font("Segoe UI", 8F)
        labelDuration.Location = New Point(269, 120)
        labelDuration.Name = "labelDuration"
        labelDuration.Size = New Size(27, 20)
        labelDuration.TabIndex = 23
        labelDuration.Text = ";-;-"
        labelDuration.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelWaktuSelesai
        ' 
        labelWaktuSelesai.AutoSize = True
        labelWaktuSelesai.Dock = DockStyle.Right
        labelWaktuSelesai.Font = New Font("Segoe UI", 8F)
        labelWaktuSelesai.Location = New Point(269, 100)
        labelWaktuSelesai.Name = "labelWaktuSelesai"
        labelWaktuSelesai.Size = New Size(27, 20)
        labelWaktuSelesai.TabIndex = 22
        labelWaktuSelesai.Text = ";-;-"
        labelWaktuSelesai.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelWaktuMulai
        ' 
        labelWaktuMulai.AutoSize = True
        labelWaktuMulai.Dock = DockStyle.Right
        labelWaktuMulai.Font = New Font("Segoe UI", 8F)
        labelWaktuMulai.Location = New Point(269, 80)
        labelWaktuMulai.Name = "labelWaktuMulai"
        labelWaktuMulai.Size = New Size(27, 20)
        labelWaktuMulai.TabIndex = 21
        labelWaktuMulai.Text = ";-;-"
        labelWaktuMulai.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelNoTable
        ' 
        labelNoTable.AutoSize = True
        labelNoTable.Dock = DockStyle.Right
        labelNoTable.Font = New Font("Segoe UI", 8F)
        labelNoTable.Location = New Point(269, 60)
        labelNoTable.Name = "labelNoTable"
        labelNoTable.Size = New Size(27, 20)
        labelNoTable.TabIndex = 20
        labelNoTable.Text = ";-;-"
        labelNoTable.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelPaket
        ' 
        labelPaket.AutoSize = True
        labelPaket.Dock = DockStyle.Right
        labelPaket.Font = New Font("Segoe UI", 8F)
        labelPaket.Location = New Point(269, 40)
        labelPaket.Name = "labelPaket"
        labelPaket.Size = New Size(27, 20)
        labelPaket.TabIndex = 19
        labelPaket.Text = ";-;-"
        labelPaket.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelNoOrder
        ' 
        labelNoOrder.AutoSize = True
        labelNoOrder.Dock = DockStyle.Right
        labelNoOrder.Font = New Font("Segoe UI", 8F)
        labelNoOrder.Location = New Point(269, 20)
        labelNoOrder.Name = "labelNoOrder"
        labelNoOrder.Size = New Size(27, 20)
        labelNoOrder.TabIndex = 18
        labelNoOrder.Text = ";-;-"
        labelNoOrder.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelTanggal
        ' 
        labelTanggal.AutoSize = True
        labelTanggal.Dock = DockStyle.Right
        labelTanggal.Font = New Font("Segoe UI", 8F)
        labelTanggal.Location = New Point(269, 0)
        labelTanggal.Name = "labelTanggal"
        labelTanggal.Size = New Size(27, 20)
        labelTanggal.TabIndex = 17
        labelTanggal.Text = ";-;-"
        labelTanggal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 8F)
        Label3.Location = New Point(3, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 19)
        Label3.TabIndex = 0
        Label3.Text = "Tanggal:"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 8F)
        Label4.Location = New Point(3, 20)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 19)
        Label4.TabIndex = 1
        Label4.Text = "No Order:"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 8F)
        Label5.Location = New Point(3, 40)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 19)
        Label5.TabIndex = 2
        Label5.Text = "Paket:"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 8F)
        Label6.Location = New Point(3, 60)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 19)
        Label6.TabIndex = 3
        Label6.Text = "Table:"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 8F)
        Label7.Location = New Point(3, 80)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 19)
        Label7.TabIndex = 4
        Label7.Text = "Mulai:"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 8F)
        Label8.Location = New Point(3, 100)
        Label8.Name = "Label8"
        Label8.Size = New Size(52, 19)
        Label8.TabIndex = 5
        Label8.Text = "Selesai:"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 8F)
        Label9.Location = New Point(3, 120)
        Label9.Name = "Label9"
        Label9.Size = New Size(51, 19)
        Label9.TabIndex = 6
        Label9.Text = "Durasi:"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 8F)
        Label10.Location = New Point(3, 160)
        Label10.Name = "Label10"
        Label10.Size = New Size(89, 20)
        Label10.TabIndex = 7
        Label10.Text = "Diskon Table (%)"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 8F)
        Label11.Location = New Point(3, 140)
        Label11.Name = "Label11"
        Label11.Size = New Size(94, 20)
        Label11.TabIndex = 8
        Label11.Text = "Subtotal Table (Rp)"
        Label11.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 8F)
        Label12.Location = New Point(3, 180)
        Label12.Name = "Label12"
        Label12.Size = New Size(76, 20)
        Label12.TabIndex = 9
        Label12.Text = "Total Table (Rp)"
        Label12.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 8F)
        Label13.Location = New Point(3, 200)
        Label13.Name = "Label13"
        Label13.Size = New Size(91, 20)
        Label13.TabIndex = 10
        Label13.Text = "Subtotal FnB (Rp)"
        Label13.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 8F)
        Label14.Location = New Point(3, 220)
        Label14.Name = "Label14"
        Label14.Size = New Size(82, 20)
        Label14.TabIndex = 11
        Label14.Text = "Diskon FnB (%)"
        Label14.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 8F)
        Label15.Location = New Point(3, 240)
        Label15.Name = "Label15"
        Label15.Size = New Size(93, 19)
        Label15.TabIndex = 12
        Label15.Text = "Total FnB (Rp)"
        Label15.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 8F)
        Label16.Location = New Point(3, 260)
        Label16.Name = "Label16"
        Label16.Size = New Size(88, 19)
        Label16.TabIndex = 13
        Label16.Text = "Subtotal (Rp)"
        Label16.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 8F)
        Label17.Location = New Point(3, 280)
        Label17.Name = "Label17"
        Label17.Size = New Size(96, 19)
        Label17.TabIndex = 14
        Label17.Text = "Tax Service 5%"
        Label17.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 8F)
        Label18.Location = New Point(3, 300)
        Label18.Name = "Label18"
        Label18.Size = New Size(64, 19)
        Label18.TabIndex = 15
        Label18.Text = "PPn 11%"
        Label18.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(tbNamaTamu, 1, 5)
        TableLayoutPanel2.Controls.Add(Label39, 0, 5)
        TableLayoutPanel2.Controls.Add(tbUangKembalian, 1, 4)
        TableLayoutPanel2.Controls.Add(Label38, 0, 4)
        TableLayoutPanel2.Controls.Add(tbUangDiterima, 1, 3)
        TableLayoutPanel2.Controls.Add(Label37, 0, 3)
        TableLayoutPanel2.Controls.Add(tboxKeterangan, 1, 2)
        TableLayoutPanel2.Controls.Add(tboxDiskonKhusus, 1, 1)
        TableLayoutPanel2.Controls.Add(Label19, 0, 0)
        TableLayoutPanel2.Controls.Add(cboxDiskonKhusus, 0, 1)
        TableLayoutPanel2.Controls.Add(tboxGrandTotal, 1, 0)
        TableLayoutPanel2.Controls.Add(Label36, 0, 2)
        TableLayoutPanel2.Location = New Point(646, 99)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 6
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.Size = New Size(361, 324)
        TableLayoutPanel2.TabIndex = 3
        ' 
        ' tbNamaTamu
        ' 
        tbNamaTamu.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tbNamaTamu.Enabled = False
        tbNamaTamu.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbNamaTamu.Location = New Point(183, 282)
        tbNamaTamu.Margin = New Padding(3, 12, 3, 3)
        tbNamaTamu.Name = "tbNamaTamu"
        tbNamaTamu.Size = New Size(175, 30)
        tbNamaTamu.TabIndex = 11
        tbNamaTamu.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label39
        ' 
        Label39.AutoSize = True
        Label39.Dock = DockStyle.Fill
        Label39.Font = New Font("Segoe UI", 9F)
        Label39.Location = New Point(3, 270)
        Label39.Name = "Label39"
        Label39.Size = New Size(174, 54)
        Label39.TabIndex = 10
        Label39.Text = "Nama Tamu"
        Label39.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' tbUangKembalian
        ' 
        tbUangKembalian.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tbUangKembalian.Enabled = False
        tbUangKembalian.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbUangKembalian.Location = New Point(183, 228)
        tbUangKembalian.Margin = New Padding(3, 12, 3, 3)
        tbUangKembalian.Name = "tbUangKembalian"
        tbUangKembalian.Size = New Size(175, 30)
        tbUangKembalian.TabIndex = 9
        tbUangKembalian.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Dock = DockStyle.Fill
        Label38.Font = New Font("Segoe UI", 9F)
        Label38.Location = New Point(3, 216)
        Label38.Name = "Label38"
        Label38.Size = New Size(174, 54)
        Label38.TabIndex = 8
        Label38.Text = "Uang Kembalian (Rp)"
        Label38.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' tbUangDiterima
        ' 
        tbUangDiterima.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tbUangDiterima.Enabled = False
        tbUangDiterima.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbUangDiterima.Location = New Point(183, 174)
        tbUangDiterima.Margin = New Padding(3, 12, 3, 3)
        tbUangDiterima.Name = "tbUangDiterima"
        tbUangDiterima.Size = New Size(175, 30)
        tbUangDiterima.TabIndex = 7
        tbUangDiterima.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Dock = DockStyle.Fill
        Label37.Font = New Font("Segoe UI", 9F)
        Label37.Location = New Point(3, 162)
        Label37.Name = "Label37"
        Label37.Size = New Size(174, 54)
        Label37.TabIndex = 6
        Label37.Text = "Uang Diterima (Rp)"
        Label37.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' tboxKeterangan
        ' 
        tboxKeterangan.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tboxKeterangan.Enabled = False
        tboxKeterangan.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tboxKeterangan.Location = New Point(183, 120)
        tboxKeterangan.Margin = New Padding(3, 12, 3, 3)
        tboxKeterangan.Name = "tboxKeterangan"
        tboxKeterangan.Size = New Size(175, 30)
        tboxKeterangan.TabIndex = 5
        tboxKeterangan.TextAlign = HorizontalAlignment.Right
        ' 
        ' tboxDiskonKhusus
        ' 
        tboxDiskonKhusus.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tboxDiskonKhusus.Enabled = False
        tboxDiskonKhusus.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tboxDiskonKhusus.Location = New Point(183, 66)
        tboxDiskonKhusus.Margin = New Padding(3, 12, 3, 3)
        tboxDiskonKhusus.Name = "tboxDiskonKhusus"
        tboxDiskonKhusus.Size = New Size(175, 30)
        tboxDiskonKhusus.TabIndex = 3
        tboxDiskonKhusus.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Dock = DockStyle.Fill
        Label19.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(3, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(174, 54)
        Label19.TabIndex = 0
        Label19.Text = "Grand Total (Rp)"
        Label19.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboxDiskonKhusus
        ' 
        cboxDiskonKhusus.AutoSize = True
        cboxDiskonKhusus.Dock = DockStyle.Fill
        cboxDiskonKhusus.Location = New Point(3, 57)
        cboxDiskonKhusus.Name = "cboxDiskonKhusus"
        cboxDiskonKhusus.Size = New Size(174, 48)
        cboxDiskonKhusus.TabIndex = 1
        cboxDiskonKhusus.Text = "Diskon Khusus"
        cboxDiskonKhusus.UseVisualStyleBackColor = True
        ' 
        ' tboxGrandTotal
        ' 
        tboxGrandTotal.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tboxGrandTotal.Enabled = False
        tboxGrandTotal.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tboxGrandTotal.Location = New Point(183, 12)
        tboxGrandTotal.Margin = New Padding(3, 12, 3, 3)
        tboxGrandTotal.Name = "tboxGrandTotal"
        tboxGrandTotal.Size = New Size(175, 30)
        tboxGrandTotal.TabIndex = 2
        tboxGrandTotal.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Dock = DockStyle.Fill
        Label36.Font = New Font("Segoe UI", 9F)
        Label36.Location = New Point(3, 108)
        Label36.Name = "Label36"
        Label36.Size = New Size(174, 54)
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
        FlowLayoutPanel2.Location = New Point(343, 441)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(297, 31)
        FlowLayoutPanel2.TabIndex = 4
        ' 
        ' rbtnCash
        ' 
        rbtnCash.AutoSize = True
        rbtnCash.Dock = DockStyle.Bottom
        rbtnCash.Location = New Point(3, 3)
        rbtnCash.Name = "rbtnCash"
        rbtnCash.Size = New Size(61, 24)
        rbtnCash.TabIndex = 0
        rbtnCash.TabStop = True
        rbtnCash.Text = "Cash"
        rbtnCash.UseVisualStyleBackColor = True
        ' 
        ' rbtnQRIS
        ' 
        rbtnQRIS.AutoSize = True
        rbtnQRIS.Dock = DockStyle.Bottom
        rbtnQRIS.Location = New Point(70, 3)
        rbtnQRIS.Name = "rbtnQRIS"
        rbtnQRIS.Size = New Size(62, 24)
        rbtnQRIS.TabIndex = 1
        rbtnQRIS.TabStop = True
        rbtnQRIS.Text = "QRIS"
        rbtnQRIS.UseVisualStyleBackColor = True
        ' 
        ' rbtnDebit
        ' 
        rbtnDebit.AutoSize = True
        rbtnDebit.Dock = DockStyle.Bottom
        rbtnDebit.Location = New Point(138, 3)
        rbtnDebit.Name = "rbtnDebit"
        rbtnDebit.Size = New Size(67, 24)
        rbtnDebit.TabIndex = 2
        rbtnDebit.TabStop = True
        rbtnDebit.Text = "Debit"
        rbtnDebit.UseVisualStyleBackColor = True
        ' 
        ' rbtnTransfer
        ' 
        rbtnTransfer.AutoSize = True
        rbtnTransfer.Dock = DockStyle.Bottom
        rbtnTransfer.Location = New Point(211, 3)
        rbtnTransfer.Name = "rbtnTransfer"
        rbtnTransfer.Size = New Size(82, 24)
        rbtnTransfer.TabIndex = 3
        rbtnTransfer.TabStop = True
        rbtnTransfer.Text = "Transfer"
        rbtnTransfer.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.Controls.Add(Label40)
        FlowLayoutPanel3.Controls.Add(tbReferensi)
        FlowLayoutPanel3.Controls.Add(btnCetak)
        FlowLayoutPanel3.Controls.Add(btnBayar)
        FlowLayoutPanel3.Location = New Point(646, 429)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(387, 56)
        FlowLayoutPanel3.TabIndex = 5
        ' 
        ' Label40
        ' 
        Label40.Location = New Point(3, 0)
        Label40.Name = "Label40"
        Label40.Size = New Size(40, 55)
        Label40.TabIndex = 0
        Label40.Text = "Ref"
        Label40.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' tbReferensi
        ' 
        tbReferensi.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tbReferensi.Enabled = False
        tbReferensi.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbReferensi.Location = New Point(49, 12)
        tbReferensi.Margin = New Padding(3, 12, 3, 3)
        tbReferensi.Name = "tbReferensi"
        tbReferensi.Size = New Size(124, 30)
        tbReferensi.TabIndex = 12
        tbReferensi.TextAlign = HorizontalAlignment.Right
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(179, 3)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(89, 40)
        btnCetak.TabIndex = 2
        btnCetak.Text = "CETAK"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' btnBayar
        ' 
        btnBayar.Location = New Point(274, 3)
        btnBayar.Name = "btnBayar"
        btnBayar.Size = New Size(85, 40)
        btnBayar.TabIndex = 13
        btnBayar.Text = "BAYAR"
        btnBayar.UseVisualStyleBackColor = True
        ' 
        ' FormDetailTable
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(1034, 497)
        Controls.Add(FlowLayoutPanel3)
        Controls.Add(FlowLayoutPanel2)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Panel1)
        MaximizeBox = False
        Name = "FormDetailTable"
        Text = "FormDetailTable"
        Panel1.ResumeLayout(False)
        FlowLayoutPanel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        FlowLayoutPanel3.ResumeLayout(False)
        FlowLayoutPanel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents labelPPn As Label
    Friend WithEvents labelTaxService As Label
    Friend WithEvents labelSubtotal As Label
    Friend WithEvents labelTotalFnB As Label
    Friend WithEvents labelDiskonFnB As Label
    Friend WithEvents labelSubtotalFnB As Label
    Friend WithEvents labelTotalTable As Label
    Friend WithEvents labelDiskonTable As Label
    Friend WithEvents labelSubtotalTable As Label
    Friend WithEvents labelDuration As Label
    Friend WithEvents labelWaktuSelesai As Label
    Friend WithEvents labelWaktuMulai As Label
    Friend WithEvents labelNoTable As Label
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
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label19 As Label
    Friend WithEvents cboxDiskonKhusus As CheckBox
    Friend WithEvents tboxGrandTotal As TextBox
    Friend WithEvents tbNamaTamu As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents tbUangKembalian As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents tbUangDiterima As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents tboxKeterangan As TextBox
    Friend WithEvents tboxDiskonKhusus As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents rbtnCash As RadioButton
    Friend WithEvents rbtnQRIS As RadioButton
    Friend WithEvents rbtnDebit As RadioButton
    Friend WithEvents rbtnTransfer As RadioButton
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents Label40 As Label
    Friend WithEvents btnCetak As Button
    Friend WithEvents tbReferensi As TextBox
    Friend WithEvents btnBayar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label41 As Label
    Friend WithEvents namaFnB As DataGridViewTextBoxColumn
    Friend WithEvents hargaFnB As DataGridViewTextBoxColumn
    Friend WithEvents qtyFnB As DataGridViewTextBoxColumn
    Friend WithEvents totalFnB As DataGridViewTextBoxColumn
End Class