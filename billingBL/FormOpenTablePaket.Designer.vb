<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormOpenTablePaket
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TableLayoutPanel1 = New TableLayoutPanel()
        LabelOpenTable = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel1 = New Panel()
        labelNoOrder = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        labelPaket = New Label()
        Label3 = New Label()
        Panel4 = New Panel()
        Label7 = New Label()
        Panel5 = New Panel()
        dropdownPilihTable = New ComboBox()
        Panel13 = New Panel()
        Label18 = New Label()
        Panel14 = New Panel()
        textboxNamaTamu = New TextBox()
        Panel3 = New Panel()
        labelHargaPaket = New Label()
        Label4 = New Label()
        Panel6 = New Panel()
        labelDurasiPaket = New Label()
        Label5 = New Label()
        btnFixOrder = New Button()
        DataGridView1 = New DataGridView()
        namaPaket = New DataGridViewTextBoxColumn()
        hargaPaket = New DataGridViewTextBoxColumn()
        duration = New DataGridViewTextBoxColumn()
        discTable = New DataGridViewTextBoxColumn()
        Label17 = New Label()
        Panel7 = New Panel()
        labelDiskonPaket = New Label()
        Label6 = New Label()
        TableLayoutPanel1.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel13.SuspendLayout()
        Panel14.SuspendLayout()
        Panel3.SuspendLayout()
        Panel6.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSize = True
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel1.Controls.Add(LabelOpenTable, 0, 0)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel1, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Top
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 45.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20.0F))
        TableLayoutPanel1.Size = New Size(677, 275)
        TableLayoutPanel1.TabIndex = 6
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
        LabelOpenTable.Size = New Size(671, 50)
        LabelOpenTable.TabIndex = 0
        LabelOpenTable.Text = " OPEN TABLE PAKET"
        LabelOpenTable.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = SystemColors.Control
        FlowLayoutPanel1.Controls.Add(Panel1)
        FlowLayoutPanel1.Controls.Add(Panel2)
        FlowLayoutPanel1.Controls.Add(Panel4)
        FlowLayoutPanel1.Controls.Add(Panel5)
        FlowLayoutPanel1.Controls.Add(Panel13)
        FlowLayoutPanel1.Controls.Add(Panel14)
        FlowLayoutPanel1.Controls.Add(Panel3)
        FlowLayoutPanel1.Controls.Add(Panel6)
        FlowLayoutPanel1.Controls.Add(Panel7)
        FlowLayoutPanel1.Controls.Add(btnFixOrder)
        FlowLayoutPanel1.Location = New Point(3, 53)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(670, 219)
        FlowLayoutPanel1.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(labelNoOrder)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(323, 49)
        Panel1.TabIndex = 0
        ' 
        ' labelNoOrder
        ' 
        labelNoOrder.Dock = DockStyle.Right
        labelNoOrder.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        labelNoOrder.ForeColor = SystemColors.Control
        labelNoOrder.Location = New Point(120, 0)
        labelNoOrder.Margin = New Padding(3, 7, 3, 0)
        labelNoOrder.Name = "labelNoOrder"
        labelNoOrder.Size = New Size(201, 47)
        labelNoOrder.TabIndex = 1
        labelNoOrder.Text = "123456789"
        labelNoOrder.TextAlign = ContentAlignment.MiddleRight
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
        labelPaket.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
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
        ' Panel13
        ' 
        Panel13.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel13.BorderStyle = BorderStyle.FixedSingle
        Panel13.Controls.Add(Label18)
        Panel13.Location = New Point(331, 58)
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
        Panel14.Location = New Point(488, 58)
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
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(labelHargaPaket)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(3, 113)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(323, 49)
        Panel3.TabIndex = 16
        ' 
        ' labelHargaPaket
        ' 
        labelHargaPaket.Dock = DockStyle.Right
        labelHargaPaket.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        labelHargaPaket.ForeColor = SystemColors.Control
        labelHargaPaket.Location = New Point(162, 0)
        labelHargaPaket.Margin = New Padding(3, 7, 3, 0)
        labelHargaPaket.Name = "labelHargaPaket"
        labelHargaPaket.Size = New Size(159, 47)
        labelHargaPaket.TabIndex = 1
        labelHargaPaket.Text = "-;-;-"
        labelHargaPaket.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label4
        ' 
        Label4.Dock = DockStyle.Left
        Label4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(0, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(155, 47)
        Label4.TabIndex = 0
        Label4.Text = "Harga"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(labelDurasiPaket)
        Panel6.Controls.Add(Label5)
        Panel6.Location = New Point(332, 113)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(323, 49)
        Panel6.TabIndex = 17
        ' 
        ' labelDurasiPaket
        ' 
        labelDurasiPaket.Dock = DockStyle.Right
        labelDurasiPaket.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        labelDurasiPaket.ForeColor = SystemColors.Control
        labelDurasiPaket.Location = New Point(120, 0)
        labelDurasiPaket.Margin = New Padding(3, 7, 3, 0)
        labelDurasiPaket.Name = "labelDurasiPaket"
        labelDurasiPaket.Size = New Size(201, 47)
        labelDurasiPaket.TabIndex = 1
        labelDurasiPaket.Text = "-;-;-"
        labelDurasiPaket.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label5
        ' 
        Label5.Dock = DockStyle.Left
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(0, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 47)
        Label5.TabIndex = 0
        Label5.Text = "Durasi"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnFixOrder
        ' 
        btnFixOrder.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnFixOrder.ForeColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        btnFixOrder.Location = New Point(332, 168)
        btnFixOrder.Name = "btnFixOrder"
        btnFixOrder.Size = New Size(321, 48)
        btnFixOrder.TabIndex = 15
        btnFixOrder.Text = "ORDER"
        btnFixOrder.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.MenuHighlight
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.Control
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {namaPaket, hargaPaket, duration, discTable})
        DataGridView1.Dock = DockStyle.Top
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Location = New Point(0, 314)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(677, 291)
        DataGridView1.TabIndex = 10
        ' 
        ' namaPaket
        ' 
        namaPaket.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        namaPaket.FillWeight = 175.0F
        namaPaket.HeaderText = "Nama Paket"
        namaPaket.MinimumWidth = 6
        namaPaket.Name = "namaPaket"
        ' 
        ' hargaPaket
        ' 
        hargaPaket.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        hargaPaket.HeaderText = "Harga (Rp)"
        hargaPaket.MinimumWidth = 6
        hargaPaket.Name = "hargaPaket"
        ' 
        ' duration
        ' 
        duration.HeaderText = "Durasi"
        duration.MinimumWidth = 6
        duration.Name = "duration"
        duration.Width = 125
        ' 
        ' discTable
        ' 
        discTable.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        discTable.FillWeight = 50.0F
        discTable.HeaderText = "Disc Table (%)"
        discTable.MinimumWidth = 6
        discTable.Name = "discTable"
        ' 
        ' Label17
        ' 
        Label17.BorderStyle = BorderStyle.FixedSingle
        Label17.Dock = DockStyle.Top
        Label17.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(0, 275)
        Label17.Name = "Label17"
        Label17.Size = New Size(677, 39)
        Label17.TabIndex = 9
        Label17.Text = "Daftar Paket"
        Label17.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        Panel7.BorderStyle = BorderStyle.FixedSingle
        Panel7.Controls.Add(labelDiskonPaket)
        Panel7.Controls.Add(Label6)
        Panel7.Location = New Point(3, 168)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(323, 49)
        Panel7.TabIndex = 18
        ' 
        ' labelDiskonPaket
        ' 
        labelDiskonPaket.Dock = DockStyle.Right
        labelDiskonPaket.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        labelDiskonPaket.ForeColor = SystemColors.Control
        labelDiskonPaket.Location = New Point(166, 0)
        labelDiskonPaket.Margin = New Padding(3, 7, 3, 0)
        labelDiskonPaket.Name = "labelDiskonPaket"
        labelDiskonPaket.Size = New Size(155, 47)
        labelDiskonPaket.TabIndex = 1
        labelDiskonPaket.Text = "-;-;-"
        labelDiskonPaket.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label6
        ' 
        Label6.Dock = DockStyle.Left
        Label6.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(0, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(150, 47)
        Label6.TabIndex = 0
        Label6.Text = "Diskon Table (%)"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' FormOpenTablePaket
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(677, 537)
        Controls.Add(DataGridView1)
        Controls.Add(Label17)
        Controls.Add(TableLayoutPanel1)
        MaximizeBox = False
        Name = "FormOpenTablePaket"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormOpenTablePaket"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel13.ResumeLayout(False)
        Panel14.ResumeLayout(False)
        Panel14.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LabelOpenTable As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents labelNoOrder As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents labelPaket As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents dropdownPilihTable As ComboBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents textboxNamaTamu As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents labelHargaPaket As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnFixOrder As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents labelDurasiPaket As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label17 As Label
    Friend WithEvents namaPaket As DataGridViewTextBoxColumn
    Friend WithEvents hargaPaket As DataGridViewTextBoxColumn
    Friend WithEvents duration As DataGridViewTextBoxColumn
    Friend WithEvents discTable As DataGridViewTextBoxColumn
    Friend WithEvents Panel7 As Panel
    Friend WithEvents labelDiskonPaket As Label
    Friend WithEvents Label6 As Label
End Class