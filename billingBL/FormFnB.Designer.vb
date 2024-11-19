<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFnB
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel16 = New Panel()
        labDate = New Label()
        labGrandTotal = New Label()
        TimerSaatIni = New Label()
        Label21 = New Label()
        tbSearch = New TextBox()
        PictureBox1 = New PictureBox()
        tbNoOrder = New TextBox()
        Label22 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        btnBatal = New Button()
        btnBayar = New Button()
        btnManageMenu = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Timer1 = New Timer(components)
        DataGridView1 = New DataGridView()
        Column5 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Panel18 = New Panel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        rbtnCash = New RadioButton()
        rbtnQris = New RadioButton()
        rbtnDebit = New RadioButton()
        rbtnTransfer = New RadioButton()
        Panel19 = New Panel()
        tbUangKembalian = New TextBox()
        Label1 = New Label()
        Panel20 = New Panel()
        Panel21 = New Panel()
        tbUangDiterima = New TextBox()
        Label2 = New Label()
        Panel22 = New Panel()
        Panel23 = New Panel()
        tbNamaTamu = New TextBox()
        Label23 = New Label()
        Panel24 = New Panel()
        Panel25 = New Panel()
        labTotal = New Label()
        Label24 = New Label()
        Panel26 = New Panel()
        Panel27 = New Panel()
        labPPN = New Label()
        Label25 = New Label()
        Panel28 = New Panel()
        Panel29 = New Panel()
        labSubtotal = New Label()
        Label26 = New Label()
        Panel16.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel18.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        Panel19.SuspendLayout()
        Panel21.SuspendLayout()
        Panel23.SuspendLayout()
        Panel25.SuspendLayout()
        Panel27.SuspendLayout()
        Panel29.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel16
        ' 
        Panel16.BackColor = SystemColors.MenuHighlight
        Panel16.Controls.Add(labDate)
        Panel16.Controls.Add(labGrandTotal)
        Panel16.Controls.Add(TimerSaatIni)
        Panel16.Controls.Add(Label21)
        Panel16.Controls.Add(tbSearch)
        Panel16.Controls.Add(PictureBox1)
        Panel16.Controls.Add(tbNoOrder)
        Panel16.Controls.Add(Label22)
        Panel16.Dock = DockStyle.Top
        Panel16.Location = New Point(15, 15)
        Panel16.Margin = New Padding(10, 11, 10, 11)
        Panel16.Name = "Panel16"
        Panel16.Size = New Size(1340, 109)
        Panel16.TabIndex = 7
        ' 
        ' labDate
        ' 
        labDate.AutoSize = True
        labDate.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        labDate.Location = New Point(482, 25)
        labDate.Name = "labDate"
        labDate.Size = New Size(0, 23)
        labDate.TabIndex = 8
        ' 
        ' labGrandTotal
        ' 
        labGrandTotal.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        labGrandTotal.AutoSize = True
        labGrandTotal.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        labGrandTotal.Location = New Point(1029, 43)
        labGrandTotal.Name = "labGrandTotal"
        labGrandTotal.Size = New Size(0, 50)
        labGrandTotal.TabIndex = 7
        labGrandTotal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TimerSaatIni
        ' 
        TimerSaatIni.AutoSize = True
        TimerSaatIni.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TimerSaatIni.Location = New Point(482, 24)
        TimerSaatIni.Name = "TimerSaatIni"
        TimerSaatIni.Size = New Size(0, 20)
        TimerSaatIni.TabIndex = 5
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label21.Location = New Point(402, 24)
        Label21.Name = "Label21"
        Label21.Size = New Size(74, 23)
        Label21.TabIndex = 4
        Label21.Text = "Tanggal"
        ' 
        ' tbSearch
        ' 
        tbSearch.Location = New Point(101, 67)
        tbSearch.Name = "tbSearch"
        tbSearch.Size = New Size(273, 27)
        tbSearch.TabIndex = 3
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.magnifier
        PictureBox1.Location = New Point(53, 59)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(32, 35)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' tbNoOrder
        ' 
        tbNoOrder.Enabled = False
        tbNoOrder.Location = New Point(101, 21)
        tbNoOrder.Name = "tbNoOrder"
        tbNoOrder.Size = New Size(273, 27)
        tbNoOrder.TabIndex = 1
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label22.Location = New Point(10, 21)
        Label22.Name = "Label22"
        Label22.Size = New Size(85, 23)
        Label22.TabIndex = 0
        Label22.Text = "No Order"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 7
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel1.Controls.Add(btnBatal, 5, 0)
        TableLayoutPanel1.Controls.Add(btnBayar, 6, 0)
        TableLayoutPanel1.Controls.Add(btnManageMenu, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Bottom
        TableLayoutPanel1.Location = New Point(15, 815)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1340, 57)
        TableLayoutPanel1.TabIndex = 10
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.IndianRed
        btnBatal.Dock = DockStyle.Fill
        btnBatal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(958, 3)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(185, 51)
        btnBatal.TabIndex = 9
        btnBatal.Text = "BATAL"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnBayar
        ' 
        btnBayar.BackColor = SystemColors.MenuHighlight
        btnBayar.Dock = DockStyle.Fill
        btnBayar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBayar.ForeColor = Color.White
        btnBayar.Location = New Point(1149, 3)
        btnBayar.Name = "btnBayar"
        btnBayar.Size = New Size(188, 51)
        btnBayar.TabIndex = 6
        btnBayar.Text = "BAYAR"
        btnBayar.UseVisualStyleBackColor = False
        ' 
        ' btnManageMenu
        ' 
        btnManageMenu.BackColor = SystemColors.MenuHighlight
        btnManageMenu.Dock = DockStyle.Fill
        btnManageMenu.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnManageMenu.ForeColor = Color.White
        btnManageMenu.Location = New Point(3, 3)
        btnManageMenu.Name = "btnManageMenu"
        btnManageMenu.Size = New Size(185, 51)
        btnManageMenu.TabIndex = 0
        btnManageMenu.Text = "MANAGE MENU"
        btnManageMenu.UseVisualStyleBackColor = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Dock = DockStyle.Left
        FlowLayoutPanel1.Location = New Point(15, 124)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(929, 691)
        FlowLayoutPanel1.TabIndex = 11
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
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
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column5, Column1, Column2, Column3, Column4})
        DataGridView1.Dock = DockStyle.Top
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Location = New Point(944, 124)
        DataGridView1.Margin = New Padding(50, 3, 3, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(411, 332)
        DataGridView1.TabIndex = 12
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "No"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 50
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Nama Menu"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "Harga"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 80
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Qty"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 62
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Subtotal"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 95
        ' 
        ' Panel18
        ' 
        Panel18.Controls.Add(FlowLayoutPanel2)
        Panel18.Controls.Add(Panel19)
        Panel18.Controls.Add(Panel20)
        Panel18.Controls.Add(Panel21)
        Panel18.Controls.Add(Panel22)
        Panel18.Controls.Add(Panel23)
        Panel18.Controls.Add(Panel24)
        Panel18.Controls.Add(Panel25)
        Panel18.Controls.Add(Panel26)
        Panel18.Controls.Add(Panel27)
        Panel18.Controls.Add(Panel28)
        Panel18.Controls.Add(Panel29)
        Panel18.Dock = DockStyle.Fill
        Panel18.Location = New Point(944, 456)
        Panel18.Name = "Panel18"
        Panel18.Size = New Size(411, 359)
        Panel18.TabIndex = 16
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(rbtnCash)
        FlowLayoutPanel2.Controls.Add(rbtnQris)
        FlowLayoutPanel2.Controls.Add(rbtnDebit)
        FlowLayoutPanel2.Controls.Add(rbtnTransfer)
        FlowLayoutPanel2.Dock = DockStyle.Top
        FlowLayoutPanel2.Location = New Point(0, 286)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(411, 31)
        FlowLayoutPanel2.TabIndex = 44
        ' 
        ' rbtnCash
        ' 
        rbtnCash.AutoSize = True
        rbtnCash.Dock = DockStyle.Bottom
        rbtnCash.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbtnCash.Location = New Point(3, 3)
        rbtnCash.Name = "rbtnCash"
        rbtnCash.Size = New Size(85, 32)
        rbtnCash.TabIndex = 0
        rbtnCash.TabStop = True
        rbtnCash.Text = "CASH"
        rbtnCash.UseVisualStyleBackColor = True
        ' 
        ' rbtnQris
        ' 
        rbtnQris.AutoSize = True
        rbtnQris.Dock = DockStyle.Bottom
        rbtnQris.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbtnQris.Location = New Point(94, 3)
        rbtnQris.Name = "rbtnQris"
        rbtnQris.Size = New Size(78, 32)
        rbtnQris.TabIndex = 1
        rbtnQris.TabStop = True
        rbtnQris.Text = "QRIS"
        rbtnQris.UseVisualStyleBackColor = True
        ' 
        ' rbtnDebit
        ' 
        rbtnDebit.AutoSize = True
        rbtnDebit.Dock = DockStyle.Bottom
        rbtnDebit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbtnDebit.Location = New Point(178, 3)
        rbtnDebit.Name = "rbtnDebit"
        rbtnDebit.Size = New Size(90, 32)
        rbtnDebit.TabIndex = 2
        rbtnDebit.TabStop = True
        rbtnDebit.Text = "DEBIT"
        rbtnDebit.UseVisualStyleBackColor = True
        ' 
        ' rbtnTransfer
        ' 
        rbtnTransfer.AutoSize = True
        rbtnTransfer.Dock = DockStyle.Bottom
        rbtnTransfer.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbtnTransfer.Location = New Point(274, 3)
        rbtnTransfer.Name = "rbtnTransfer"
        rbtnTransfer.Size = New Size(133, 32)
        rbtnTransfer.TabIndex = 3
        rbtnTransfer.TabStop = True
        rbtnTransfer.Text = "TRANSFER"
        rbtnTransfer.UseVisualStyleBackColor = True
        ' 
        ' Panel19
        ' 
        Panel19.BackColor = SystemColors.MenuHighlight
        Panel19.BorderStyle = BorderStyle.FixedSingle
        Panel19.Controls.Add(tbUangKembalian)
        Panel19.Controls.Add(Label1)
        Panel19.Dock = DockStyle.Top
        Panel19.Location = New Point(0, 249)
        Panel19.Margin = New Padding(7)
        Panel19.Name = "Panel19"
        Panel19.Size = New Size(411, 37)
        Panel19.TabIndex = 43
        ' 
        ' tbUangKembalian
        ' 
        tbUangKembalian.Dock = DockStyle.Right
        tbUangKembalian.Enabled = False
        tbUangKembalian.Font = New Font("Segoe UI", 12F)
        tbUangKembalian.Location = New Point(180, 0)
        tbUangKembalian.Name = "tbUangKembalian"
        tbUangKembalian.Size = New Size(229, 34)
        tbUangKembalian.TabIndex = 29
        tbUangKembalian.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Left
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(205, 28)
        Label1.TabIndex = 1
        Label1.Text = "Uang Kembalian (Rp)"
        Label1.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Panel20
        ' 
        Panel20.BackColor = SystemColors.Control
        Panel20.BorderStyle = BorderStyle.FixedSingle
        Panel20.Dock = DockStyle.Top
        Panel20.Location = New Point(0, 234)
        Panel20.Margin = New Padding(7)
        Panel20.Name = "Panel20"
        Panel20.Size = New Size(411, 15)
        Panel20.TabIndex = 42
        ' 
        ' Panel21
        ' 
        Panel21.BackColor = SystemColors.MenuHighlight
        Panel21.BorderStyle = BorderStyle.FixedSingle
        Panel21.Controls.Add(tbUangDiterima)
        Panel21.Controls.Add(Label2)
        Panel21.Dock = DockStyle.Top
        Panel21.Location = New Point(0, 196)
        Panel21.Margin = New Padding(7)
        Panel21.Name = "Panel21"
        Panel21.Size = New Size(411, 38)
        Panel21.TabIndex = 41
        ' 
        ' tbUangDiterima
        ' 
        tbUangDiterima.Dock = DockStyle.Right
        tbUangDiterima.Font = New Font("Segoe UI", 12F)
        tbUangDiterima.Location = New Point(180, 0)
        tbUangDiterima.Name = "tbUangDiterima"
        tbUangDiterima.Size = New Size(229, 34)
        tbUangDiterima.TabIndex = 29
        tbUangDiterima.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Left
        Label2.Font = New Font("Segoe UI Semibold", 12.2F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(198, 30)
        Label2.TabIndex = 1
        Label2.Text = "Uang Diterima (Rp)"
        Label2.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Panel22
        ' 
        Panel22.BackColor = SystemColors.Control
        Panel22.BorderStyle = BorderStyle.FixedSingle
        Panel22.Dock = DockStyle.Top
        Panel22.Location = New Point(0, 181)
        Panel22.Margin = New Padding(7)
        Panel22.Name = "Panel22"
        Panel22.Size = New Size(411, 15)
        Panel22.TabIndex = 40
        ' 
        ' Panel23
        ' 
        Panel23.BackColor = SystemColors.MenuHighlight
        Panel23.BorderStyle = BorderStyle.FixedSingle
        Panel23.Controls.Add(tbNamaTamu)
        Panel23.Controls.Add(Label23)
        Panel23.Dock = DockStyle.Top
        Panel23.Location = New Point(0, 135)
        Panel23.Margin = New Padding(7)
        Panel23.Name = "Panel23"
        Panel23.Size = New Size(411, 46)
        Panel23.TabIndex = 39
        ' 
        ' tbNamaTamu
        ' 
        tbNamaTamu.Dock = DockStyle.Right
        tbNamaTamu.Font = New Font("Segoe UI", 15F)
        tbNamaTamu.Location = New Point(180, 0)
        tbNamaTamu.Name = "tbNamaTamu"
        tbNamaTamu.Size = New Size(229, 41)
        tbNamaTamu.TabIndex = 28
        tbNamaTamu.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Dock = DockStyle.Left
        Label23.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label23.ForeColor = SystemColors.Control
        Label23.Location = New Point(0, 0)
        Label23.Name = "Label23"
        Label23.Size = New Size(120, 28)
        Label23.TabIndex = 0
        Label23.Text = "Nama Tamu"
        Label23.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Panel24
        ' 
        Panel24.BackColor = SystemColors.Control
        Panel24.BorderStyle = BorderStyle.FixedSingle
        Panel24.Dock = DockStyle.Top
        Panel24.Location = New Point(0, 120)
        Panel24.Margin = New Padding(7)
        Panel24.Name = "Panel24"
        Panel24.Size = New Size(411, 15)
        Panel24.TabIndex = 38
        ' 
        ' Panel25
        ' 
        Panel25.BackColor = SystemColors.MenuHighlight
        Panel25.BorderStyle = BorderStyle.FixedSingle
        Panel25.Controls.Add(labTotal)
        Panel25.Controls.Add(Label24)
        Panel25.Dock = DockStyle.Top
        Panel25.Location = New Point(0, 90)
        Panel25.Margin = New Padding(7)
        Panel25.Name = "Panel25"
        Panel25.Size = New Size(411, 30)
        Panel25.TabIndex = 37
        ' 
        ' labTotal
        ' 
        labTotal.AutoSize = True
        labTotal.Dock = DockStyle.Right
        labTotal.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labTotal.ForeColor = SystemColors.Control
        labTotal.Location = New Point(392, 0)
        labTotal.Name = "labTotal"
        labTotal.Size = New Size(17, 23)
        labTotal.TabIndex = 1
        labTotal.Text = "-"
        labTotal.TextAlign = ContentAlignment.BottomRight
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Dock = DockStyle.Left
        Label24.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label24.ForeColor = SystemColors.Control
        Label24.Location = New Point(0, 0)
        Label24.Name = "Label24"
        Label24.Size = New Size(57, 23)
        Label24.TabIndex = 0
        Label24.Text = "TOTAL"
        Label24.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Panel26
        ' 
        Panel26.BackColor = SystemColors.Control
        Panel26.BorderStyle = BorderStyle.FixedSingle
        Panel26.Dock = DockStyle.Top
        Panel26.Location = New Point(0, 75)
        Panel26.Margin = New Padding(7)
        Panel26.Name = "Panel26"
        Panel26.Size = New Size(411, 15)
        Panel26.TabIndex = 36
        ' 
        ' Panel27
        ' 
        Panel27.BackColor = SystemColors.MenuHighlight
        Panel27.BorderStyle = BorderStyle.FixedSingle
        Panel27.Controls.Add(labPPN)
        Panel27.Controls.Add(Label25)
        Panel27.Dock = DockStyle.Top
        Panel27.Location = New Point(0, 45)
        Panel27.Margin = New Padding(7)
        Panel27.Name = "Panel27"
        Panel27.Size = New Size(411, 30)
        Panel27.TabIndex = 35
        ' 
        ' labPPN
        ' 
        labPPN.AutoSize = True
        labPPN.Dock = DockStyle.Right
        labPPN.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labPPN.ForeColor = SystemColors.Control
        labPPN.Location = New Point(392, 0)
        labPPN.Name = "labPPN"
        labPPN.Size = New Size(17, 23)
        labPPN.TabIndex = 1
        labPPN.Text = "-"
        labPPN.TextAlign = ContentAlignment.BottomRight
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Dock = DockStyle.Left
        Label25.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label25.ForeColor = SystemColors.Control
        Label25.Location = New Point(0, 0)
        Label25.Name = "Label25"
        Label25.Size = New Size(43, 23)
        Label25.TabIndex = 0
        Label25.Text = "PPN"
        Label25.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Panel28
        ' 
        Panel28.BackColor = SystemColors.Control
        Panel28.BorderStyle = BorderStyle.FixedSingle
        Panel28.Dock = DockStyle.Top
        Panel28.Location = New Point(0, 30)
        Panel28.Margin = New Padding(7)
        Panel28.Name = "Panel28"
        Panel28.Size = New Size(411, 15)
        Panel28.TabIndex = 34
        ' 
        ' Panel29
        ' 
        Panel29.BackColor = SystemColors.MenuHighlight
        Panel29.BorderStyle = BorderStyle.FixedSingle
        Panel29.Controls.Add(labSubtotal)
        Panel29.Controls.Add(Label26)
        Panel29.Dock = DockStyle.Top
        Panel29.Location = New Point(0, 0)
        Panel29.Margin = New Padding(7)
        Panel29.Name = "Panel29"
        Panel29.Size = New Size(411, 30)
        Panel29.TabIndex = 33
        ' 
        ' labSubtotal
        ' 
        labSubtotal.AutoSize = True
        labSubtotal.Dock = DockStyle.Right
        labSubtotal.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labSubtotal.ForeColor = SystemColors.Control
        labSubtotal.Location = New Point(392, 0)
        labSubtotal.Name = "labSubtotal"
        labSubtotal.Size = New Size(17, 23)
        labSubtotal.TabIndex = 1
        labSubtotal.Text = "-"
        labSubtotal.TextAlign = ContentAlignment.BottomRight
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Dock = DockStyle.Left
        Label26.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label26.ForeColor = SystemColors.Control
        Label26.Location = New Point(0, 0)
        Label26.Name = "Label26"
        Label26.Size = New Size(87, 23)
        Label26.TabIndex = 0
        Label26.Text = "SUBTOTAL"
        Label26.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' FormFnB
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 887)
        Controls.Add(Panel18)
        Controls.Add(DataGridView1)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Panel16)
        Name = "FormFnB"
        Padding = New Padding(15)
        Text = "FormFnB"
        Panel16.ResumeLayout(False)
        Panel16.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel18.ResumeLayout(False)
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        Panel19.ResumeLayout(False)
        Panel19.PerformLayout()
        Panel21.ResumeLayout(False)
        Panel21.PerformLayout()
        Panel23.ResumeLayout(False)
        Panel23.PerformLayout()
        Panel25.ResumeLayout(False)
        Panel25.PerformLayout()
        Panel27.ResumeLayout(False)
        Panel27.PerformLayout()
        Panel29.ResumeLayout(False)
        Panel29.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel16 As Panel
    Friend WithEvents TimerSaatIni As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tbNoOrder As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents labGrandTotal As Label
    Friend WithEvents btnManageMenu As Button
    Friend WithEvents btnBayar As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents labDate As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Panel18 As Panel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents rbtnCash As RadioButton
    Friend WithEvents rbtnQris As RadioButton
    Friend WithEvents rbtnDebit As RadioButton
    Friend WithEvents rbtnTransfer As RadioButton
    Friend WithEvents Panel19 As Panel
    Friend WithEvents tbUangKembalian As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Panel21 As Panel
    Friend WithEvents tbUangDiterima As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents tbNamaTamu As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Panel24 As Panel
    Friend WithEvents Panel25 As Panel
    Friend WithEvents labTotal As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Panel26 As Panel
    Friend WithEvents Panel27 As Panel
    Friend WithEvents labPPN As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Panel28 As Panel
    Friend WithEvents Panel29 As Panel
    Friend WithEvents labSubtotal As Label
    Friend WithEvents Label26 As Label
End Class
