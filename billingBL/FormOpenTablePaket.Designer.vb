<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOpenTablePaket
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
        TableLayoutPanel2 = New TableLayoutPanel()
        Label27 = New Label()
        Label26 = New Label()
        Label25 = New Label()
        Label24 = New Label()
        Label23 = New Label()
        Label22 = New Label()
        Label19 = New Label()
        Label17 = New Label()
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
        TableLayoutPanel2.SuspendLayout()
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
        SuspendLayout()
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset
        TableLayoutPanel2.ColumnCount = 7
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 67.39726F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 32.60274F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 133F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 150F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 150F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 109F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100F))
        TableLayoutPanel2.Controls.Add(Label27, 6, 0)
        TableLayoutPanel2.Controls.Add(Label26, 5, 0)
        TableLayoutPanel2.Controls.Add(Label25, 4, 0)
        TableLayoutPanel2.Controls.Add(Label24, 3, 0)
        TableLayoutPanel2.Controls.Add(Label23, 2, 0)
        TableLayoutPanel2.Controls.Add(Label22, 1, 0)
        TableLayoutPanel2.Controls.Add(Label19, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Top
        TableLayoutPanel2.Location = New Point(0, 294)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 11.6935482F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 88.30645F))
        TableLayoutPanel2.Size = New Size(671, 274)
        TableLayoutPanel2.TabIndex = 8
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Dock = DockStyle.Fill
        Label27.Location = New Point(571, 2)
        Label27.Name = "Label27"
        Label27.Size = New Size(95, 31)
        Label27.TabIndex = 6
        Label27.Text = "Disc FnB (%)"
        Label27.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Dock = DockStyle.Fill
        Label26.Location = New Point(460, 2)
        Label26.Name = "Label26"
        Label26.Size = New Size(103, 31)
        Label26.TabIndex = 5
        Label26.Text = "Disc Table (%)"
        Label26.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Dock = DockStyle.Fill
        Label25.Location = New Point(308, 2)
        Label25.Name = "Label25"
        Label25.Size = New Size(144, 31)
        Label25.TabIndex = 4
        Label25.Text = "Akhir Harga Malam"
        Label25.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Dock = DockStyle.Fill
        Label24.Location = New Point(156, 2)
        Label24.Name = "Label24"
        Label24.Size = New Size(144, 31)
        Label24.TabIndex = 3
        Label24.Text = "Akhir Harga Siang"
        Label24.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Dock = DockStyle.Fill
        Label23.Location = New Point(21, 2)
        Label23.Name = "Label23"
        Label23.Size = New Size(127, 31)
        Label23.TabIndex = 2
        Label23.Text = "Harga Malam"
        Label23.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Dock = DockStyle.Fill
        Label22.Location = New Point(15, 2)
        Label22.Name = "Label22"
        Label22.Size = New Size(1, 31)
        Label22.TabIndex = 1
        Label22.Text = "Harga Siang"
        Label22.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Dock = DockStyle.Fill
        Label19.Location = New Point(5, 2)
        Label19.Name = "Label19"
        Label19.Size = New Size(2, 31)
        Label19.TabIndex = 0
        Label19.Text = "Nama Paket"
        Label19.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label17
        ' 
        Label17.BorderStyle = BorderStyle.FixedSingle
        Label17.Dock = DockStyle.Top
        Label17.Location = New Point(0, 274)
        Label17.Name = "Label17"
        Label17.Size = New Size(671, 20)
        Label17.TabIndex = 7
        Label17.Text = "Daftar Paket"
        Label17.TextAlign = ContentAlignment.MiddleCenter
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
        TableLayoutPanel1.Size = New Size(671, 274)
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
        LabelOpenTable.Size = New Size(665, 49)
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
        FlowLayoutPanel1.Controls.Add(btnFixOrder)
        FlowLayoutPanel1.Location = New Point(3, 52)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(663, 218)
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
        labelNoOrder.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
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
        dropdownPilihTable.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
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
        Panel14.Size = New Size(166, 49)
        Panel14.TabIndex = 13
        ' 
        ' textboxNamaTamu
        ' 
        textboxNamaTamu.Location = New Point(20, 10)
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
        labelHargaPaket.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
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
        Label4.Size = New Size(156, 47)
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
        labelDurasiPaket.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
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
        btnFixOrder.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnFixOrder.ForeColor = Color.FromArgb(CByte(51), CByte(153), CByte(255))
        btnFixOrder.Location = New Point(3, 168)
        btnFixOrder.Name = "btnFixOrder"
        btnFixOrder.Size = New Size(321, 48)
        btnFixOrder.TabIndex = 15
        btnFixOrder.Text = "ORDER"
        btnFixOrder.UseVisualStyleBackColor = True
        ' 
        ' FormOpenTablePaket
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(671, 537)
        Controls.Add(TableLayoutPanel2)
        Controls.Add(Label17)
        Controls.Add(TableLayoutPanel1)
        Name = "FormOpenTablePaket"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormOpenTablePaket"
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
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
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
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
End Class
