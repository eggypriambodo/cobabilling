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
        Panel16 = New Panel()
        labGrandTotal = New Label()
        labTotalAtas = New Label()
        TimerSaatIni = New Label()
        Label21 = New Label()
        tbSearch = New TextBox()
        PictureBox1 = New PictureBox()
        tbNoOrder = New TextBox()
        Label22 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        btnBatal = New Button()
        btnBayar = New Button()
        btnOrderList = New Button()
        btnOrderBaru = New Button()
        btnManageMenu = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        rbtnCash = New RadioButton()
        rbtnQris = New RadioButton()
        rbtnDebit = New RadioButton()
        rbtnTransfer = New RadioButton()
        Panel13 = New Panel()
        tbUangKembalian = New TextBox()
        Label19 = New Label()
        Panel9 = New Panel()
        Panel8 = New Panel()
        tbUangDiterima = New TextBox()
        Label18 = New Label()
        Panel7 = New Panel()
        Panel6 = New Panel()
        tbNamaTamu = New TextBox()
        Label6 = New Label()
        Panel5 = New Panel()
        Panel4 = New Panel()
        labTotal = New Label()
        Label4 = New Label()
        Panel2 = New Panel()
        Panel12 = New Panel()
        labPPN = New Label()
        Label17 = New Label()
        Panel11 = New Panel()
        Panel10 = New Panel()
        labSubtotal = New Label()
        Label13 = New Label()
        Timer1 = New Timer(components)
        Panel16.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        Panel13.SuspendLayout()
        Panel8.SuspendLayout()
        Panel6.SuspendLayout()
        Panel4.SuspendLayout()
        Panel12.SuspendLayout()
        Panel10.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel16
        ' 
        Panel16.BackColor = SystemColors.MenuHighlight
        Panel16.Controls.Add(labGrandTotal)
        Panel16.Controls.Add(labTotalAtas)
        Panel16.Controls.Add(TimerSaatIni)
        Panel16.Controls.Add(Label21)
        Panel16.Controls.Add(tbSearch)
        Panel16.Controls.Add(PictureBox1)
        Panel16.Controls.Add(tbNoOrder)
        Panel16.Controls.Add(Label22)
        Panel16.Dock = DockStyle.Top
        Panel16.Location = New Point(15, 15)
        Panel16.Margin = New Padding(10)
        Panel16.Name = "Panel16"
        Panel16.Size = New Size(1392, 110)
        Panel16.TabIndex = 7
        ' 
        ' labGrandTotal
        ' 
        labGrandTotal.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        labGrandTotal.AutoSize = True
        labGrandTotal.Font = New Font("Segoe UI", 22F, FontStyle.Bold)
        labGrandTotal.Location = New Point(1081, 43)
        labGrandTotal.Name = "labGrandTotal"
        labGrandTotal.Size = New Size(308, 50)
        labGrandTotal.TabIndex = 7
        labGrandTotal.Text = "Rp. 9.999.999,00"
        labGrandTotal.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labTotalAtas
        ' 
        labTotalAtas.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        labTotalAtas.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        labTotalAtas.Location = New Point(3256, 44)
        labTotalAtas.Name = "labTotalAtas"
        labTotalAtas.Size = New Size(363, 71)
        labTotalAtas.TabIndex = 6
        labTotalAtas.Text = "Rp. 100.000,00"
        labTotalAtas.TextAlign = ContentAlignment.MiddleRight
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
        tbSearch.Location = New Point(101, 66)
        tbSearch.Name = "tbSearch"
        tbSearch.Size = New Size(273, 27)
        tbSearch.TabIndex = 3
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.magnifier
        PictureBox1.Location = New Point(53, 59)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(32, 34)
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
        TableLayoutPanel1.Controls.Add(btnOrderList, 2, 0)
        TableLayoutPanel1.Controls.Add(btnOrderBaru, 1, 0)
        TableLayoutPanel1.Controls.Add(btnManageMenu, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Bottom
        TableLayoutPanel1.Location = New Point(15, 807)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(1392, 57)
        TableLayoutPanel1.TabIndex = 10
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.IndianRed
        btnBatal.Dock = DockStyle.Fill
        btnBatal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(993, 3)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(192, 51)
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
        btnBayar.Location = New Point(1191, 3)
        btnBayar.Name = "btnBayar"
        btnBayar.Size = New Size(198, 51)
        btnBayar.TabIndex = 6
        btnBayar.Text = "BAYAR"
        btnBayar.UseVisualStyleBackColor = False
        ' 
        ' btnOrderList
        ' 
        btnOrderList.BackColor = SystemColors.MenuHighlight
        btnOrderList.Dock = DockStyle.Fill
        btnOrderList.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOrderList.ForeColor = Color.White
        btnOrderList.Location = New Point(399, 3)
        btnOrderList.Name = "btnOrderList"
        btnOrderList.Size = New Size(192, 51)
        btnOrderList.TabIndex = 2
        btnOrderList.Text = "ORDER LIST"
        btnOrderList.UseVisualStyleBackColor = False
        ' 
        ' btnOrderBaru
        ' 
        btnOrderBaru.BackColor = SystemColors.MenuHighlight
        btnOrderBaru.Dock = DockStyle.Fill
        btnOrderBaru.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOrderBaru.ForeColor = Color.White
        btnOrderBaru.Location = New Point(201, 3)
        btnOrderBaru.Name = "btnOrderBaru"
        btnOrderBaru.Size = New Size(192, 51)
        btnOrderBaru.TabIndex = 1
        btnOrderBaru.Text = "ORDER BARU"
        btnOrderBaru.UseVisualStyleBackColor = False
        ' 
        ' btnManageMenu
        ' 
        btnManageMenu.BackColor = SystemColors.MenuHighlight
        btnManageMenu.Dock = DockStyle.Fill
        btnManageMenu.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnManageMenu.ForeColor = Color.White
        btnManageMenu.Location = New Point(3, 3)
        btnManageMenu.Name = "btnManageMenu"
        btnManageMenu.Size = New Size(192, 51)
        btnManageMenu.TabIndex = 0
        btnManageMenu.Text = "MANAGE MENU"
        btnManageMenu.UseVisualStyleBackColor = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Dock = DockStyle.Left
        FlowLayoutPanel1.Location = New Point(15, 125)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(881, 682)
        FlowLayoutPanel1.TabIndex = 11
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.ColumnHeadersHeight = 30
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridView1.Dock = DockStyle.Top
        DataGridView1.Location = New Point(896, 125)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(511, 326)
        DataGridView1.TabIndex = 13
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
        Column2.Width = 79
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column3.HeaderText = "Qty"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 61
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column4.HeaderText = "Total"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 71
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(FlowLayoutPanel2)
        Panel1.Controls.Add(Panel13)
        Panel1.Controls.Add(Panel9)
        Panel1.Controls.Add(Panel8)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel12)
        Panel1.Controls.Add(Panel11)
        Panel1.Controls.Add(Panel10)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(896, 451)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(511, 356)
        Panel1.TabIndex = 14
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(rbtnCash)
        FlowLayoutPanel2.Controls.Add(rbtnQris)
        FlowLayoutPanel2.Controls.Add(rbtnDebit)
        FlowLayoutPanel2.Controls.Add(rbtnTransfer)
        FlowLayoutPanel2.Dock = DockStyle.Top
        FlowLayoutPanel2.Location = New Point(0, 291)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(511, 31)
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
        ' Panel13
        ' 
        Panel13.BackColor = SystemColors.MenuHighlight
        Panel13.BorderStyle = BorderStyle.FixedSingle
        Panel13.Controls.Add(tbUangKembalian)
        Panel13.Controls.Add(Label19)
        Panel13.Dock = DockStyle.Top
        Panel13.Location = New Point(0, 254)
        Panel13.Margin = New Padding(7)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(511, 37)
        Panel13.TabIndex = 43
        ' 
        ' tbUangKembalian
        ' 
        tbUangKembalian.Dock = DockStyle.Right
        tbUangKembalian.Enabled = False
        tbUangKembalian.Font = New Font("Segoe UI", 12F)
        tbUangKembalian.Location = New Point(280, 0)
        tbUangKembalian.Name = "tbUangKembalian"
        tbUangKembalian.Size = New Size(229, 34)
        tbUangKembalian.TabIndex = 29
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Dock = DockStyle.Left
        Label19.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label19.ForeColor = SystemColors.Control
        Label19.Location = New Point(0, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(205, 28)
        Label19.TabIndex = 1
        Label19.Text = "Uang Kembalian (Rp)"
        Label19.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = SystemColors.Control
        Panel9.BorderStyle = BorderStyle.FixedSingle
        Panel9.Dock = DockStyle.Top
        Panel9.Location = New Point(0, 238)
        Panel9.Margin = New Padding(7)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(511, 16)
        Panel9.TabIndex = 42
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = SystemColors.MenuHighlight
        Panel8.BorderStyle = BorderStyle.FixedSingle
        Panel8.Controls.Add(tbUangDiterima)
        Panel8.Controls.Add(Label18)
        Panel8.Dock = DockStyle.Top
        Panel8.Location = New Point(0, 200)
        Panel8.Margin = New Padding(7)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(511, 38)
        Panel8.TabIndex = 41
        ' 
        ' tbUangDiterima
        ' 
        tbUangDiterima.Dock = DockStyle.Right
        tbUangDiterima.Font = New Font("Segoe UI", 12F)
        tbUangDiterima.Location = New Point(280, 0)
        tbUangDiterima.Name = "tbUangDiterima"
        tbUangDiterima.Size = New Size(229, 34)
        tbUangDiterima.TabIndex = 29
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Dock = DockStyle.Left
        Label18.Font = New Font("Segoe UI Semibold", 12.2F, FontStyle.Bold)
        Label18.ForeColor = SystemColors.Control
        Label18.Location = New Point(0, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(198, 30)
        Label18.TabIndex = 1
        Label18.Text = "Uang Diterima (Rp)"
        Label18.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.Control
        Panel7.BorderStyle = BorderStyle.FixedSingle
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(0, 184)
        Panel7.Margin = New Padding(7)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(511, 16)
        Panel7.TabIndex = 40
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.MenuHighlight
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(tbNamaTamu)
        Panel6.Controls.Add(Label6)
        Panel6.Dock = DockStyle.Top
        Panel6.Location = New Point(0, 138)
        Panel6.Margin = New Padding(7)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(511, 46)
        Panel6.TabIndex = 39
        ' 
        ' tbNamaTamu
        ' 
        tbNamaTamu.Dock = DockStyle.Right
        tbNamaTamu.Font = New Font("Segoe UI", 15F)
        tbNamaTamu.Location = New Point(280, 0)
        tbNamaTamu.Name = "tbNamaTamu"
        tbNamaTamu.Size = New Size(229, 41)
        tbNamaTamu.TabIndex = 28
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Dock = DockStyle.Left
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(0, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(120, 28)
        Label6.TabIndex = 0
        Label6.Text = "Nama Tamu"
        Label6.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.Control
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 122)
        Panel5.Margin = New Padding(7)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(511, 16)
        Panel5.TabIndex = 38
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.MenuHighlight
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(labTotal)
        Panel4.Controls.Add(Label4)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 92)
        Panel4.Margin = New Padding(7)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(511, 30)
        Panel4.TabIndex = 37
        ' 
        ' labTotal
        ' 
        labTotal.AutoSize = True
        labTotal.Dock = DockStyle.Right
        labTotal.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labTotal.ForeColor = SystemColors.Control
        labTotal.Location = New Point(492, 0)
        labTotal.Name = "labTotal"
        labTotal.Size = New Size(17, 23)
        labTotal.TabIndex = 1
        labTotal.Text = "-"
        labTotal.TextAlign = ContentAlignment.BottomRight
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Left
        Label4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(0, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 23)
        Label4.TabIndex = 0
        Label4.Text = "TOTAL"
        Label4.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 76)
        Panel2.Margin = New Padding(7)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(511, 16)
        Panel2.TabIndex = 36
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = SystemColors.MenuHighlight
        Panel12.BorderStyle = BorderStyle.FixedSingle
        Panel12.Controls.Add(labPPN)
        Panel12.Controls.Add(Label17)
        Panel12.Dock = DockStyle.Top
        Panel12.Location = New Point(0, 46)
        Panel12.Margin = New Padding(7)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(511, 30)
        Panel12.TabIndex = 35
        ' 
        ' labPPN
        ' 
        labPPN.AutoSize = True
        labPPN.Dock = DockStyle.Right
        labPPN.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labPPN.ForeColor = SystemColors.Control
        labPPN.Location = New Point(492, 0)
        labPPN.Name = "labPPN"
        labPPN.Size = New Size(17, 23)
        labPPN.TabIndex = 1
        labPPN.Text = "-"
        labPPN.TextAlign = ContentAlignment.BottomRight
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Dock = DockStyle.Left
        Label17.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = SystemColors.Control
        Label17.Location = New Point(0, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(43, 23)
        Label17.TabIndex = 0
        Label17.Text = "PPN"
        Label17.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = SystemColors.Control
        Panel11.BorderStyle = BorderStyle.FixedSingle
        Panel11.Dock = DockStyle.Top
        Panel11.Location = New Point(0, 30)
        Panel11.Margin = New Padding(7)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(511, 16)
        Panel11.TabIndex = 34
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = SystemColors.MenuHighlight
        Panel10.BorderStyle = BorderStyle.FixedSingle
        Panel10.Controls.Add(labSubtotal)
        Panel10.Controls.Add(Label13)
        Panel10.Dock = DockStyle.Top
        Panel10.Location = New Point(0, 0)
        Panel10.Margin = New Padding(7)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(511, 30)
        Panel10.TabIndex = 33
        ' 
        ' labSubtotal
        ' 
        labSubtotal.AutoSize = True
        labSubtotal.Dock = DockStyle.Right
        labSubtotal.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labSubtotal.ForeColor = SystemColors.Control
        labSubtotal.Location = New Point(492, 0)
        labSubtotal.Name = "labSubtotal"
        labSubtotal.Size = New Size(17, 23)
        labSubtotal.TabIndex = 1
        labSubtotal.Text = "-"
        labSubtotal.TextAlign = ContentAlignment.BottomRight
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Dock = DockStyle.Left
        Label13.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = SystemColors.Control
        Label13.Location = New Point(0, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(87, 23)
        Label13.TabIndex = 0
        Label13.Text = "SUBTOTAL"
        Label13.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Timer1
        ' 
        ' 
        ' FormFnB
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1422, 879)
        Controls.Add(Panel1)
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
        Panel1.ResumeLayout(False)
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        Panel13.ResumeLayout(False)
        Panel13.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel12.ResumeLayout(False)
        Panel12.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel16 As Panel
    Friend WithEvents labTotalAtas As Label
    Friend WithEvents TimerSaatIni As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tbNoOrder As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents labGrandTotal As Label
    Friend WithEvents btnManageMenu As Button
    Friend WithEvents btnBayar As Button
    Friend WithEvents btnOrderList As Button
    Friend WithEvents btnOrderBaru As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Panel12 As Panel
    Friend WithEvents labPPN As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents labSubtotal As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents labTotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents tbNamaTamu As TextBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents rbtnCash As RadioButton
    Friend WithEvents rbtnQris As RadioButton
    Friend WithEvents rbtnDebit As RadioButton
    Friend WithEvents rbtnTransfer As RadioButton
    Friend WithEvents tbUangKembalian As TextBox
    Friend WithEvents tbUangDiterima As TextBox
    Friend WithEvents Timer1 As Timer
End Class
