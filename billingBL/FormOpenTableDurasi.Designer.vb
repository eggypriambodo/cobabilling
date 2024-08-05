<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormOpenTableDurasi
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TableLayoutPanel1 = New TableLayoutPanel()
        LabelOpenTable = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel1 = New Panel()
        LabelNoOrder = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        labelPaket = New Label()
        Label3 = New Label()
        Panel3 = New Panel()
        labelAkhirHargaSiang = New Label()
        Label5 = New Label()
        Panel4 = New Panel()
        Label7 = New Label()
        Panel5 = New Panel()
        dropdownPilihTable = New ComboBox()
        Panel6 = New Panel()
        labelHargaSiang = New Label()
        Label9 = New Label()
        Panel7 = New Panel()
        labelAkhirHargaMalam = New Label()
        Label11 = New Label()
        Panel11 = New Panel()
        Label16 = New Label()
        Panel12 = New Panel()
        textboxDurasiMain = New TextBox()
        labelHargaMalam = New Panel()
        labelisihargamalam = New Label()
        Label15 = New Label()
        Panel13 = New Panel()
        Label18 = New Label()
        Panel14 = New Panel()
        textboxNamaTamu = New TextBox()
        Panel15 = New Panel()
        labelDiskonDurasi = New Label()
        Label21 = New Label()
        btnFixOrder = New Button()
        Label17 = New Label()
        DataGridView1 = New DataGridView()
        namaPaket = New DataGridViewTextBoxColumn()
        hargaSiang = New DataGridViewTextBoxColumn()
        hargaMalam = New DataGridViewTextBoxColumn()
        akhirsiang = New DataGridViewTextBoxColumn()
        akhirMalam = New DataGridViewTextBoxColumn()
        discTable = New DataGridViewTextBoxColumn()
        TableLayoutPanel1.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        Panel11.SuspendLayout()
        Panel12.SuspendLayout()
        labelHargaMalam.SuspendLayout()
        Panel13.SuspendLayout()
        Panel14.SuspendLayout()
        Panel15.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(LabelOpenTable, 0, 0)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel1, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 45F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(1000, 277)
        TableLayoutPanel1.TabIndex = 0
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
        LabelOpenTable.Size = New Size(994, 50)
        LabelOpenTable.TabIndex = 0
        LabelOpenTable.Text = " OPEN TABLE DURASI"
        LabelOpenTable.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = SystemColors.Control
        FlowLayoutPanel1.Controls.Add(Panel1)
        FlowLayoutPanel1.Controls.Add(Panel2)
        FlowLayoutPanel1.Controls.Add(Panel3)
        FlowLayoutPanel1.Controls.Add(Panel4)
        FlowLayoutPanel1.Controls.Add(Panel5)
        FlowLayoutPanel1.Controls.Add(Panel6)
        FlowLayoutPanel1.Controls.Add(Panel7)
        FlowLayoutPanel1.Controls.Add(Panel11)
        FlowLayoutPanel1.Controls.Add(Panel12)
        FlowLayoutPanel1.Controls.Add(labelHargaMalam)
        FlowLayoutPanel1.Controls.Add(Panel13)
        FlowLayoutPanel1.Controls.Add(Panel14)
        FlowLayoutPanel1.Controls.Add(Panel15)
        FlowLayoutPanel1.Controls.Add(btnFixOrder)
        FlowLayoutPanel1.Location = New Point(3, 53)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(993, 221)
        FlowLayoutPanel1.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(LabelNoOrder)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(323, 49)
        Panel1.TabIndex = 0
        ' 
        ' LabelNoOrder
        ' 
        LabelNoOrder.Dock = DockStyle.Right
        LabelNoOrder.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        LabelNoOrder.ForeColor = SystemColors.Control
        LabelNoOrder.Location = New Point(120, 0)
        LabelNoOrder.Margin = New Padding(3, 7, 3, 0)
        LabelNoOrder.Name = "LabelNoOrder"
        LabelNoOrder.Size = New Size(201, 47)
        LabelNoOrder.TabIndex = 1
        LabelNoOrder.Text = "-;-;-"
        LabelNoOrder.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Left
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 47)
        Label1.TabIndex = 0
        Label1.Text = "No. Order"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(labelPaket)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(332, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(323, 49)
        Panel2.TabIndex = 1
        ' 
        ' labelPaket
        ' 
        labelPaket.Dock = DockStyle.Right
        labelPaket.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        labelPaket.ForeColor = SystemColors.Control
        labelPaket.Location = New Point(120, 0)
        labelPaket.Margin = New Padding(3, 7, 3, 0)
        labelPaket.Name = "labelPaket"
        labelPaket.Size = New Size(201, 47)
        labelPaket.TabIndex = 1
        labelPaket.Text = "-;-;-"
        labelPaket.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label3
        ' 
        Label3.Dock = DockStyle.Left
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(0, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 47)
        Label3.TabIndex = 0
        Label3.Text = "Paket"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(labelAkhirHargaSiang)
        Panel3.Controls.Add(Label5)
        Panel3.Location = New Point(661, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(323, 49)
        Panel3.TabIndex = 2
        ' 
        ' labelAkhirHargaSiang
        ' 
        labelAkhirHargaSiang.Dock = DockStyle.Right
        labelAkhirHargaSiang.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelAkhirHargaSiang.ForeColor = SystemColors.Control
        labelAkhirHargaSiang.Location = New Point(208, 0)
        labelAkhirHargaSiang.Margin = New Padding(3, 7, 3, 0)
        labelAkhirHargaSiang.Name = "labelAkhirHargaSiang"
        labelAkhirHargaSiang.Size = New Size(113, 47)
        labelAkhirHargaSiang.TabIndex = 1
        labelAkhirHargaSiang.Text = "-;-;-"
        labelAkhirHargaSiang.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label5
        ' 
        Label5.Dock = DockStyle.Left
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(0, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(202, 47)
        Label5.TabIndex = 0
        Label5.Text = "Akhir Harga Siang"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Label7)
        Panel4.Location = New Point(3, 58)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(151, 49)
        Panel4.TabIndex = 3
        ' 
        ' Label7
        ' 
        Label7.Dock = DockStyle.Left
        Label7.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.Control
        Label7.Location = New Point(0, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(114, 47)
        Label7.TabIndex = 0
        Label7.Text = "Table"
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(dropdownPilihTable)
        Panel5.Location = New Point(160, 58)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(165, 49)
        Panel5.TabIndex = 4
        ' 
        ' dropdownPilihTable
        ' 
        dropdownPilihTable.FormattingEnabled = True
        dropdownPilihTable.Location = New Point(9, 11)
        dropdownPilihTable.Name = "dropdownPilihTable"
        dropdownPilihTable.Size = New Size(151, 28)
        dropdownPilihTable.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(labelHargaSiang)
        Panel6.Controls.Add(Label9)
        Panel6.Location = New Point(331, 58)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(323, 49)
        Panel6.TabIndex = 5
        ' 
        ' labelHargaSiang
        ' 
        labelHargaSiang.Dock = DockStyle.Right
        labelHargaSiang.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        labelHargaSiang.ForeColor = SystemColors.Control
        labelHargaSiang.Location = New Point(120, 0)
        labelHargaSiang.Margin = New Padding(3, 7, 3, 0)
        labelHargaSiang.Name = "labelHargaSiang"
        labelHargaSiang.Size = New Size(201, 47)
        labelHargaSiang.TabIndex = 1
        labelHargaSiang.Text = "-;-;-"
        labelHargaSiang.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label9
        ' 
        Label9.Dock = DockStyle.Left
        Label9.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.Control
        Label9.Location = New Point(0, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(114, 47)
        Label9.TabIndex = 0
        Label9.Text = "Harga Siang"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel7.BorderStyle = BorderStyle.FixedSingle
        Panel7.Controls.Add(labelAkhirHargaMalam)
        Panel7.Controls.Add(Label11)
        Panel7.Location = New Point(660, 58)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(323, 49)
        Panel7.TabIndex = 6
        ' 
        ' labelAkhirHargaMalam
        ' 
        labelAkhirHargaMalam.Dock = DockStyle.Right
        labelAkhirHargaMalam.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelAkhirHargaMalam.ForeColor = SystemColors.Control
        labelAkhirHargaMalam.Location = New Point(208, 0)
        labelAkhirHargaMalam.Margin = New Padding(3, 7, 3, 0)
        labelAkhirHargaMalam.Name = "labelAkhirHargaMalam"
        labelAkhirHargaMalam.Size = New Size(113, 47)
        labelAkhirHargaMalam.TabIndex = 2
        labelAkhirHargaMalam.Text = "-;-;-"
        labelAkhirHargaMalam.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label11
        ' 
        Label11.Dock = DockStyle.Left
        Label11.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = SystemColors.Control
        Label11.Location = New Point(0, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(213, 47)
        Label11.TabIndex = 0
        Label11.Text = "Akhir Harga Malam"
        Label11.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel11.BorderStyle = BorderStyle.FixedSingle
        Panel11.Controls.Add(Label16)
        Panel11.Location = New Point(3, 113)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(151, 49)
        Panel11.TabIndex = 10
        ' 
        ' Label16
        ' 
        Label16.Dock = DockStyle.Left
        Label16.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = SystemColors.Control
        Label16.Location = New Point(0, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(114, 47)
        Label16.TabIndex = 0
        Label16.Text = "Durasi (Jam)"
        Label16.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel12.BorderStyle = BorderStyle.FixedSingle
        Panel12.Controls.Add(textboxDurasiMain)
        Panel12.Location = New Point(160, 113)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(165, 49)
        Panel12.TabIndex = 11
        ' 
        ' textboxDurasiMain
        ' 
        textboxDurasiMain.Location = New Point(18, 11)
        textboxDurasiMain.Name = "textboxDurasiMain"
        textboxDurasiMain.Size = New Size(125, 27)
        textboxDurasiMain.TabIndex = 0
        ' 
        ' labelHargaMalam
        ' 
        labelHargaMalam.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        labelHargaMalam.BorderStyle = BorderStyle.FixedSingle
        labelHargaMalam.Controls.Add(labelisihargamalam)
        labelHargaMalam.Controls.Add(Label15)
        labelHargaMalam.Location = New Point(331, 113)
        labelHargaMalam.Name = "labelHargaMalam"
        labelHargaMalam.Size = New Size(323, 49)
        labelHargaMalam.TabIndex = 9
        ' 
        ' labelisihargamalam
        ' 
        labelisihargamalam.Dock = DockStyle.Right
        labelisihargamalam.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        labelisihargamalam.ForeColor = SystemColors.Control
        labelisihargamalam.Location = New Point(121, 0)
        labelisihargamalam.Margin = New Padding(3, 7, 3, 0)
        labelisihargamalam.Name = "labelisihargamalam"
        labelisihargamalam.Size = New Size(200, 47)
        labelisihargamalam.TabIndex = 1
        labelisihargamalam.Text = "-;-;-"
        labelisihargamalam.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label15
        ' 
        Label15.Dock = DockStyle.Left
        Label15.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = SystemColors.Control
        Label15.Location = New Point(0, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(123, 47)
        Label15.TabIndex = 0
        Label15.Text = "Harga Malam"
        Label15.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel13.BorderStyle = BorderStyle.FixedSingle
        Panel13.Controls.Add(Label18)
        Panel13.Location = New Point(660, 113)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(151, 49)
        Panel13.TabIndex = 12
        ' 
        ' Label18
        ' 
        Label18.Dock = DockStyle.Left
        Label18.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = SystemColors.Control
        Label18.Location = New Point(0, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(114, 47)
        Label18.TabIndex = 0
        Label18.Text = "Nama Tamu"
        Label18.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel14
        ' 
        Panel14.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel14.BorderStyle = BorderStyle.FixedSingle
        Panel14.Controls.Add(textboxNamaTamu)
        Panel14.Location = New Point(817, 113)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(167, 49)
        Panel14.TabIndex = 13
        ' 
        ' textboxNamaTamu
        ' 
        textboxNamaTamu.Location = New Point(21, 11)
        textboxNamaTamu.Name = "textboxNamaTamu"
        textboxNamaTamu.Size = New Size(125, 27)
        textboxNamaTamu.TabIndex = 1
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel15.BorderStyle = BorderStyle.FixedSingle
        Panel15.Controls.Add(labelDiskonDurasi)
        Panel15.Controls.Add(Label21)
        Panel15.Location = New Point(3, 168)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(323, 49)
        Panel15.TabIndex = 14
        ' 
        ' labelDiskonDurasi
        ' 
        labelDiskonDurasi.Dock = DockStyle.Right
        labelDiskonDurasi.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        labelDiskonDurasi.ForeColor = SystemColors.Control
        labelDiskonDurasi.Location = New Point(255, 0)
        labelDiskonDurasi.Margin = New Padding(3, 7, 3, 0)
        labelDiskonDurasi.Name = "labelDiskonDurasi"
        labelDiskonDurasi.Size = New Size(66, 47)
        labelDiskonDurasi.TabIndex = 1
        labelDiskonDurasi.Text = "-;-;-"
        labelDiskonDurasi.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label21
        ' 
        Label21.Dock = DockStyle.Left
        Label21.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = SystemColors.Control
        Label21.Location = New Point(0, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(185, 47)
        Label21.TabIndex = 0
        Label21.Text = "Diskon Paket (%)"
        Label21.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnFixOrder
        ' 
        btnFixOrder.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnFixOrder.ForeColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        btnFixOrder.Location = New Point(332, 168)
        btnFixOrder.Name = "btnFixOrder"
        btnFixOrder.Size = New Size(321, 48)
        btnFixOrder.TabIndex = 15
        btnFixOrder.Text = "ORDER"
        btnFixOrder.UseVisualStyleBackColor = True
        ' 
        ' Label17
        ' 
        Label17.BorderStyle = BorderStyle.FixedSingle
        Label17.Dock = DockStyle.Top
        Label17.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(0, 277)
        Label17.Name = "Label17"
        Label17.Size = New Size(1000, 30)
        Label17.TabIndex = 1
        Label17.Text = "Daftar Paket"
        Label17.TextAlign = ContentAlignment.MiddleCenter
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
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {namaPaket, hargaSiang, hargaMalam, akhirsiang, akhirMalam, discTable})
        DataGridView1.Dock = DockStyle.Top
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Location = New Point(0, 307)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1000, 313)
        DataGridView1.TabIndex = 6
        ' 
        ' namaPaket
        ' 
        namaPaket.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        namaPaket.FillWeight = 175F
        namaPaket.HeaderText = "Nama Paket"
        namaPaket.MinimumWidth = 6
        namaPaket.Name = "namaPaket"
        ' 
        ' hargaSiang
        ' 
        hargaSiang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        hargaSiang.HeaderText = "Harga Siang "
        hargaSiang.MinimumWidth = 6
        hargaSiang.Name = "hargaSiang"
        ' 
        ' hargaMalam
        ' 
        hargaMalam.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        hargaMalam.HeaderText = "Harga Malam "
        hargaMalam.MinimumWidth = 6
        hargaMalam.Name = "hargaMalam"
        ' 
        ' akhirsiang
        ' 
        akhirsiang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        akhirsiang.HeaderText = "Jam Akhir Harga Siang"
        akhirsiang.MinimumWidth = 6
        akhirsiang.Name = "akhirsiang"
        ' 
        ' akhirMalam
        ' 
        akhirMalam.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        akhirMalam.HeaderText = "Jam Akhir Harga Malam"
        akhirMalam.MinimumWidth = 6
        akhirMalam.Name = "akhirMalam"
        ' 
        ' discTable
        ' 
        discTable.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        discTable.FillWeight = 50F
        discTable.HeaderText = "Disc Table (%)"
        discTable.MinimumWidth = 6
        discTable.Name = "discTable"
        ' 
        ' FormOpenTableDurasi
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 548)
        Controls.Add(DataGridView1)
        Controls.Add(Label17)
        Controls.Add(TableLayoutPanel1)
        MaximizeBox = False
        Name = "FormOpenTableDurasi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormOpenTable"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        Panel12.ResumeLayout(False)
        Panel12.PerformLayout()
        labelHargaMalam.ResumeLayout(False)
        Panel13.ResumeLayout(False)
        Panel14.ResumeLayout(False)
        Panel14.PerformLayout()
        Panel15.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelOpenTable As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelNoOrder As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents labelPaket As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents labelAkhirHargaSiang As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents labelHargaSiang As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents labelAkhirHargaMalam As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents labelHargaMalam As Panel
    Friend WithEvents labelisihargamalam As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents textboxDurasiMain As TextBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents textboxNamaTamu As TextBox
    Friend WithEvents Panel15 As Panel
    Friend WithEvents labelDiskonDurasi As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents btnFixOrder As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents dropdownPilihTable As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents namaPaket As DataGridViewTextBoxColumn
    Friend WithEvents hargaSiang As DataGridViewTextBoxColumn
    Friend WithEvents hargaMalam As DataGridViewTextBoxColumn
    Friend WithEvents akhirsiang As DataGridViewTextBoxColumn
    Friend WithEvents akhirMalam As DataGridViewTextBoxColumn
    Friend WithEvents discTable As DataGridViewTextBoxColumn
End Class
