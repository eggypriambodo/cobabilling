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
        namaFnB = New DataGridViewTextBoxColumn()
        hargaFnB = New DataGridViewTextBoxColumn()
        qtyFnB = New DataGridViewTextBoxColumn()
        totalFnB = New DataGridViewTextBoxColumn()
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
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(882, 70)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Top
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(0, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(880, 15)
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
        Label1.Size = New Size(880, 44)
        Label1.TabIndex = 0
        Label1.Text = "XYZ BILLIARD"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(Label41)
        FlowLayoutPanel1.Controls.Add(DataGridView1)
        FlowLayoutPanel1.Location = New Point(1, 74)
        FlowLayoutPanel1.Margin = New Padding(3, 2, 3, 2)
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
        DataGridView1.BackgroundColor = SystemColors.GradientActiveCaption
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {namaFnB, hargaFnB, qtyFnB, totalFnB})
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Location = New Point(3, 28)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(330, 286)
        DataGridView1.TabIndex = 0
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
        TableLayoutPanel1.Location = New Point(340, 99)
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
        TableLayoutPanel1.Size = New Size(300, 324)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' labelPPn
        ' 
        labelPPn.AutoSize = True
        labelPPn.Dock = DockStyle.Right
        labelPPn.Font = New Font("Segoe UI", 8.0F)
        labelPPn.Location = New Point(270, 300)
        labelPPn.Name = "labelPPn"
        labelPPn.Size = New Size(27, 24)
        labelPPn.TabIndex = 32
        labelPPn.Text = ";-;-"
        labelPPn.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelTaxService
        ' 
        Label34.AutoSize = True
        Label34.Dock = DockStyle.Right
        Label34.Font = New Font("Segoe UI", 8.0F)
        Label34.Location = New Point(353, 280)
        Label34.Name = "Label34"
        Label34.Size = New Size(27, 20)
        Label34.TabIndex = 31
        Label34.Text = ";-;-"
        labelTaxService.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelSubtotal
        ' 
        labelSubtotal.AutoSize = True
        labelSubtotal.Dock = DockStyle.Right
        labelSubtotal.Font = New Font("Segoe UI", 8.0F)
        labelSubtotal.Location = New Point(270, 260)
        labelSubtotal.Name = "labelSubtotal"
        Label33.Size = New Size(27, 20)
        Label33.TabIndex = 30
        Label33.Text = ";-;-"
        Label33.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelTotalFnB
        ' 
        Label32.AutoSize = True
        Label32.Dock = DockStyle.Right
        Label32.Font = New Font("Segoe UI", 8.0F)
        Label32.Location = New Point(353, 240)
        labelTotalFnB.Name = "labelTotalFnB"
        labelTotalFnB.Size = New Size(27, 20)
        labelTotalFnB.TabIndex = 29
        labelTotalFnB.Text = ";-;-"
        labelTotalFnB.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelDiskonFnB
        ' 
        labelDiskonFnB.AutoSize = True
        Label31.Dock = DockStyle.Right
        Label31.Font = New Font("Segoe UI", 8.0F)
        Label31.Location = New Point(353, 220)
        labelDiskonFnB.Name = "labelDiskonFnB"
        labelDiskonFnB.Size = New Size(27, 20)
        labelDiskonFnB.TabIndex = 28
        labelDiskonFnB.Text = ";-;-"
        labelDiskonFnB.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelSubtotalFnB
        ' 
        labelSubtotalFnB.AutoSize = True
        Label30.Dock = DockStyle.Right
        Label30.Font = New Font("Segoe UI", 8.0F)
        Label30.Location = New Point(353, 200)
        labelSubtotalFnB.Name = "labelSubtotalFnB"
        labelSubtotalFnB.Size = New Size(27, 20)
        labelSubtotalFnB.TabIndex = 27
        labelSubtotalFnB.Text = ";-;-"
        labelSubtotalFnB.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelTotalTable
        ' 
        labelTotalTable.AutoSize = True
        Label29.Dock = DockStyle.Right
        Label29.Font = New Font("Segoe UI", 8.0F)
        Label29.Location = New Point(353, 180)
        labelTotalTable.Name = "labelTotalTable"
        labelTotalTable.Size = New Size(27, 20)
        labelTotalTable.TabIndex = 26
        labelTotalTable.Text = ";-;-"
        labelTotalTable.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelDiskonTable
        ' 
        labelDiskonTable.AutoSize = True
        Label28.Dock = DockStyle.Right
        Label28.Font = New Font("Segoe UI", 8.0F)
        Label28.Location = New Point(353, 160)
        labelDiskonTable.Name = "labelDiskonTable"
        labelDiskonTable.Size = New Size(27, 20)
        labelDiskonTable.TabIndex = 25
        labelDiskonTable.Text = ";-;-"
        labelDiskonTable.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelSubtotalTable
        ' 
        labelSubtotalTable.AutoSize = True
        Label27.Dock = DockStyle.Right
        Label27.Font = New Font("Segoe UI", 8.0F)
        Label27.Location = New Point(353, 140)
        labelSubtotalTable.Name = "labelSubtotalTable"
        labelSubtotalTable.Size = New Size(27, 20)
        labelSubtotalTable.TabIndex = 24
        labelSubtotalTable.Text = ";-;-"
        labelSubtotalTable.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelDuration
        ' 
        labelDuration.AutoSize = True
        Label26.Dock = DockStyle.Right
        Label26.Font = New Font("Segoe UI", 8.0F)
        Label26.Location = New Point(353, 120)
        labelDuration.Name = "labelDuration"
        labelDuration.Size = New Size(27, 20)
        labelDuration.TabIndex = 23
        labelDuration.Text = ";-;-"
        labelDuration.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelWaktuSelesai
        ' 
        labelWaktuSelesai.AutoSize = True
        Label25.Dock = DockStyle.Right
        Label25.Font = New Font("Segoe UI", 8.0F)
        Label25.Location = New Point(353, 100)
        labelWaktuSelesai.Name = "labelWaktuSelesai"
        labelWaktuSelesai.Size = New Size(27, 20)
        labelWaktuSelesai.TabIndex = 22
        labelWaktuSelesai.Text = ";-;-"
        labelWaktuSelesai.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelWaktuMulai
        ' 
        labelWaktuMulai.AutoSize = True
        Label24.Dock = DockStyle.Right
        Label24.Font = New Font("Segoe UI", 8.0F)
        Label24.Location = New Point(353, 80)
        labelWaktuMulai.Name = "labelWaktuMulai"
        labelWaktuMulai.Size = New Size(27, 20)
        labelWaktuMulai.TabIndex = 21
        labelWaktuMulai.Text = ";-;-"
        labelWaktuMulai.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelNoTable
        ' 
        labelNoTable.AutoSize = True
        Label23.Dock = DockStyle.Right
        Label23.Font = New Font("Segoe UI", 8.0F)
        Label23.Location = New Point(353, 60)
        labelNoTable.Name = "labelNoTable"
        labelNoTable.Size = New Size(27, 20)
        labelNoTable.TabIndex = 20
        labelNoTable.Text = ";-;-"
        labelNoTable.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelPaket
        ' 
        labelPaket.AutoSize = True
        Label22.Dock = DockStyle.Right
        Label22.Font = New Font("Segoe UI", 8.0F)
        Label22.Location = New Point(353, 40)
        labelPaket.Name = "labelPaket"
        labelPaket.Size = New Size(27, 20)
        labelPaket.TabIndex = 19
        labelPaket.Text = ";-;-"
        labelPaket.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelNoOrder
        ' 
        labelNoOrder.AutoSize = True
        Label21.Dock = DockStyle.Right
        Label21.Font = New Font("Segoe UI", 8.0F)
        Label21.Location = New Point(353, 20)
        labelNoOrder.Name = "labelNoOrder"
        labelNoOrder.Size = New Size(27, 20)
        labelNoOrder.TabIndex = 18
        labelNoOrder.Text = ";-;-"
        labelNoOrder.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelTanggal
        ' 
        labelTanggal.AutoSize = True
        Label20.Dock = DockStyle.Right
        Label20.Font = New Font("Segoe UI", 8.0F)
        Label20.Location = New Point(353, 0)
        labelTanggal.Name = "labelTanggal"
        labelTanggal.Size = New Size(27, 20)
        labelTanggal.TabIndex = 17
        labelTanggal.Text = ";-;-"
        labelTanggal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 8.0F)
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
        Label4.Font = New Font("Segoe UI", 8.0F)
        Label4.Location = New Point(3, 15)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 13)
        Label4.TabIndex = 1
        Label4.Text = "No Order:"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 8.0F)
        Label5.Location = New Point(3, 30)
        Label5.Name = "Label5"
        Label5.Size = New Size(38, 13)
        Label5.TabIndex = 2
        Label5.Text = "Paket:"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 8.0F)
        Label6.Location = New Point(3, 45)
        Label6.Name = "Label6"
        Label6.Size = New Size(37, 13)
        Label6.TabIndex = 3
        Label6.Text = "Table:"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 8.0F)
        Label7.Location = New Point(3, 60)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 13)
        Label7.TabIndex = 4
        Label7.Text = "Mulai:"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 8.0F)
        Label8.Location = New Point(3, 75)
        Label8.Name = "Label8"
        Label8.Size = New Size(45, 13)
        Label8.TabIndex = 5
        Label8.Text = "Selesai:"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 8.0F)
        Label9.Location = New Point(3, 90)
        Label9.Name = "Label9"
        Label9.Size = New Size(43, 13)
        Label9.TabIndex = 6
        Label9.Text = "Durasi:"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 8.0F)
        Label10.Location = New Point(3, 120)
        Label10.Name = "Label10"
        Label10.Size = New Size(108, 19)
        Label10.TabIndex = 7
        Label10.Text = "Diskon Table (%)"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 8.0F)
        Label11.Location = New Point(3, 105)
        Label11.Name = "Label11"
        Label11.Size = New Size(122, 19)
        Label11.TabIndex = 8
        Label11.Text = "Subtotal Table (Rp)"
        Label11.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 8.0F)
        Label12.Location = New Point(3, 135)
        Label12.Name = "Label12"
        Label12.Size = New Size(100, 19)
        Label12.TabIndex = 9
        Label12.Text = "Total Table (Rp)"
        Label12.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 8.0F)
        Label13.Location = New Point(3, 150)
        Label13.Name = "Label13"
        Label13.Size = New Size(115, 19)
        Label13.TabIndex = 10
        Label13.Text = "Subtotal FnB (Rp)"
        Label13.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 8.0F)
        Label14.Location = New Point(3, 165)
        Label14.Name = "Label14"
        Label14.Size = New Size(101, 19)
        Label14.TabIndex = 11
        Label14.Text = "Diskon FnB (%)"
        Label14.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 8.0F)
        Label15.Location = New Point(3, 180)
        Label15.Name = "Label15"
        Label15.Size = New Size(77, 13)
        Label15.TabIndex = 12
        Label15.Text = "Total FnB (Rp)"
        Label15.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 8.0F)
        Label16.Location = New Point(3, 195)
        Label16.Name = "Label16"
        Label16.Size = New Size(74, 13)
        Label16.TabIndex = 13
        Label16.Text = "Subtotal (Rp)"
        Label16.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI", 8.0F)
        Label17.Location = New Point(3, 210)
        Label17.Name = "Label17"
        Label17.Size = New Size(79, 13)
        Label17.TabIndex = 14
        Label17.Text = "Tax Service 5%"
        Label17.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 8.0F)
        Label18.Location = New Point(3, 225)
        Label18.Name = "Label18"
        Label18.Size = New Size(50, 13)
        Label18.TabIndex = 15
        Label18.Text = "PPn 11%"
        Label18.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
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
        TableLayoutPanel2.Location = New Point(565, 74)
        TableLayoutPanel2.Margin = New Padding(3, 2, 3, 2)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 6
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel2.Size = New Size(316, 243)
        TableLayoutPanel2.TabIndex = 3
        ' 
        ' tbNamaTamu
        ' 
        TextBox6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox6.Enabled = False
        TextBox6.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(183, 282)
        TextBox6.Margin = New Padding(3, 12, 3, 3)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(175, 30)
        TextBox6.TabIndex = 11
        TextBox6.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label39
        ' 
        Label39.AutoSize = True
        Label39.Dock = DockStyle.Fill
        Label39.Font = New Font("Segoe UI", 9.0F)
        Label39.Location = New Point(3, 200)
        Label39.Name = "Label39"
        Label39.Size = New Size(152, 43)
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
        Label38.Font = New Font("Segoe UI", 9.0F)
        Label38.Location = New Point(3, 160)
        Label38.Name = "Label38"
        Label38.Size = New Size(152, 40)
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
        Label37.Font = New Font("Segoe UI", 9.0F)
        Label37.Location = New Point(3, 120)
        Label37.Name = "Label37"
        Label37.Size = New Size(152, 40)
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
        TextBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox2.Enabled = False
        TextBox2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(183, 66)
        TextBox2.Margin = New Padding(3, 12, 3, 3)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(175, 30)
        TextBox2.TabIndex = 3
        TextBox2.TextAlign = HorizontalAlignment.Right
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
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.Enabled = False
        TextBox1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(183, 12)
        TextBox1.Margin = New Padding(3, 12, 3, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(175, 30)
        TextBox1.TabIndex = 2
        TextBox1.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label36
        ' 
        Label36.AutoSize = True
        Label36.Dock = DockStyle.Fill
        Label36.Font = New Font("Segoe UI", 9.0F)
        Label36.Location = New Point(3, 108)
        Label36.Name = "Label36"
        Label36.Size = New Size(174, 54)
        Label36.TabIndex = 4
        Label36.Text = "Keterangan"
        Label36.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(RadioButton1)
        FlowLayoutPanel2.Controls.Add(RadioButton2)
        FlowLayoutPanel2.Controls.Add(RadioButton3)
        FlowLayoutPanel2.Controls.Add(RadioButton4)
        FlowLayoutPanel2.Location = New Point(257, 441)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(383, 31)
        FlowLayoutPanel2.TabIndex = 4
        ' 
        ' rbtnCash
        ' 
        rbtnCash.AutoSize = True
        rbtnCash.Dock = DockStyle.Bottom
        rbtnCash.Location = New Point(3, 3)
        rbtnCash.Name = "rbtnCash"
        rbtnCash.Size = New Size(61, 24)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Cash"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' rbtnQRIS
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Dock = DockStyle.Bottom
        RadioButton2.Location = New Point(70, 3)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(62, 24)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "QRIS"
        rbtnQRIS.UseVisualStyleBackColor = True
        ' 
        ' rbtnDebit
        ' 
        rbtnDebit.AutoSize = True
        RadioButton3.Dock = DockStyle.Bottom
        rbtnDebit.Location = New Point(138, 3)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(67, 24)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        rbtnDebit.Text = "Debit"
        rbtnDebit.UseVisualStyleBackColor = True
        ' 
        ' rbtnTransfer
        ' 
        rbtnTransfer.AutoSize = True
        rbtnTransfer.Dock = DockStyle.Bottom
        rbtnTransfer.Location = New Point(211, 3)
        rbtnTransfer.Name = "rbtnTransfer"
        RadioButton4.Size = New Size(82, 24)
        RadioButton4.TabIndex = 3
        RadioButton4.TabStop = True
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
        FlowLayoutPanel3.Size = New Size(317, 32)
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
        btnBayar.Size = New Size(84, 40)
        btnBayar.TabIndex = 13
        btnBayar.Text = "BAYAR"
        btnBayar.UseVisualStyleBackColor = True
        ' 
        ' namaFnB
        ' 
        namaFnB.HeaderText = "Nama"
        namaFnB.MinimumWidth = 6
        namaFnB.Name = "namaFnB"
        namaFnB.Width = 125
        ' 
        ' hargaFnB
        ' 
        TextBox8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox8.Enabled = False
        TextBox8.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox8.Location = New Point(49, 12)
        TextBox8.Margin = New Padding(3, 12, 3, 3)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(124, 30)
        TextBox8.TabIndex = 12
        TextBox8.TextAlign = HorizontalAlignment.Right
        ' 
        ' qtyFnB
        ' 
        Button1.Location = New Point(179, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(71, 40)
        Button1.TabIndex = 2
        Button1.Text = "CETAK"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' totalFnB
        ' 
        Button2.Location = New Point(256, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(71, 40)
        Button2.TabIndex = 13
        Button2.Text = "BAYAR"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' FormDetailTable
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        Name = "FormDetailTable"
        Text = "FormDetailTable"
        Panel1.ResumeLayout(False)
        FlowLayoutPanel1.ResumeLayout(False)
        Name = "FormDetailTable"
        Text = "FormDetailTable"
        Panel1.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        FlowLayoutPanel3.ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
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
