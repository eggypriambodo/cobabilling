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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        TabControl1 = New TabControl()
        tpBilling = New TabPage()
        Panel4 = New Panel()
        Label3 = New Label()
        labelPemasukanBilling = New Label()
        Panel3 = New Panel()
        DataGridView1 = New DataGridView()
        no = New DataGridViewTextBoxColumn()
        noOrder = New DataGridViewTextBoxColumn()
        durasi = New DataGridViewTextBoxColumn()
        totalHarga = New DataGridViewTextBoxColumn()
        metodebayar = New DataGridViewTextBoxColumn()
        tpFnB = New TabPage()
        Panel5 = New Panel()
        Label2 = New Label()
        labelPemasukanFnB = New Label()
        DataGridView2 = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        TabControl1.SuspendLayout()
        tpBilling.SuspendLayout()
        Panel4.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        tpFnB.SuspendLayout()
        Panel5.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(15, 15)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1303, 80)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1303, 80)
        Label1.TabIndex = 13
        Label1.Text = "TRANSAKSI HARIAN"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        Label1.UseCompatibleTextRendering = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(TabControl1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(15, 95)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1303, 639)
        Panel2.TabIndex = 1
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tpBilling)
        TabControl1.Controls.Add(tpFnB)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1303, 639)
        TabControl1.TabIndex = 0
        ' 
        ' tpBilling
        ' 
        tpBilling.BackColor = SystemColors.Control
        tpBilling.Controls.Add(Panel4)
        tpBilling.Controls.Add(Panel3)
        tpBilling.Controls.Add(DataGridView1)
        tpBilling.Location = New Point(4, 29)
        tpBilling.Name = "tpBilling"
        tpBilling.Padding = New Padding(3)
        tpBilling.Size = New Size(1295, 606)
        tpBilling.TabIndex = 0
        tpBilling.Text = "TRANSAKSI BILLING"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.MenuHighlight
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(labelPemasukanBilling)
        Panel4.Location = New Point(1104, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(188, 97)
        Panel4.TabIndex = 21
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(181, 28)
        Label3.TabIndex = 16
        Label3.Text = "Pemasukan Harian"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelPemasukanBilling
        ' 
        labelPemasukanBilling.AutoSize = True
        labelPemasukanBilling.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelPemasukanBilling.ForeColor = SystemColors.ControlLightLight
        labelPemasukanBilling.Location = New Point(46, 53)
        labelPemasukanBilling.Name = "labelPemasukanBilling"
        labelPemasukanBilling.Size = New Size(0, 25)
        labelPemasukanBilling.TabIndex = 15
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.Control
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(1095, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(197, 600)
        Panel3.TabIndex = 15
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
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
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {no, noOrder, durasi, totalHarga, metodebayar})
        DataGridView1.Dock = DockStyle.Left
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Location = New Point(3, 3)
        DataGridView1.Margin = New Padding(50, 3, 3, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1062, 600)
        DataGridView1.TabIndex = 14
        ' 
        ' no
        ' 
        no.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        no.FillWeight = 30F
        no.HeaderText = "No"
        no.MinimumWidth = 6
        no.Name = "no"
        no.ReadOnly = True
        no.Width = 59
        ' 
        ' noOrder
        ' 
        noOrder.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        noOrder.FillWeight = 150F
        noOrder.HeaderText = "No Order"
        noOrder.MinimumWidth = 4
        noOrder.Name = "noOrder"
        noOrder.ReadOnly = True
        ' 
        ' durasi
        ' 
        durasi.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        durasi.FillWeight = 75F
        durasi.HeaderText = "Durasi (menit)"
        durasi.MinimumWidth = 6
        durasi.Name = "durasi"
        durasi.ReadOnly = True
        durasi.Width = 124
        ' 
        ' totalHarga
        ' 
        totalHarga.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        totalHarga.HeaderText = "Total Harga"
        totalHarga.MinimumWidth = 6
        totalHarga.Name = "totalHarga"
        totalHarga.ReadOnly = True
        totalHarga.Width = 108
        ' 
        ' metodebayar
        ' 
        metodebayar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        metodebayar.HeaderText = "Metode Bayar"
        metodebayar.MinimumWidth = 6
        metodebayar.Name = "metodebayar"
        metodebayar.ReadOnly = True
        metodebayar.Width = 123
        ' 
        ' tpFnB
        ' 
        tpFnB.BackColor = SystemColors.Control
        tpFnB.Controls.Add(Panel5)
        tpFnB.Controls.Add(DataGridView2)
        tpFnB.Location = New Point(4, 29)
        tpFnB.Name = "tpFnB"
        tpFnB.Padding = New Padding(3)
        tpFnB.Size = New Size(1295, 606)
        tpFnB.TabIndex = 1
        tpFnB.Text = "TRANSAKSI FnB"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.MenuHighlight
        Panel5.Controls.Add(Label2)
        Panel5.Controls.Add(labelPemasukanFnB)
        Panel5.Location = New Point(1104, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(188, 97)
        Panel5.TabIndex = 23
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(181, 28)
        Label2.TabIndex = 16
        Label2.Text = "Pemasukan Harian"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' labelPemasukanFnB
        ' 
        labelPemasukanFnB.AutoSize = True
        labelPemasukanFnB.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelPemasukanFnB.ForeColor = SystemColors.ControlLightLight
        labelPemasukanFnB.Location = New Point(46, 53)
        labelPemasukanFnB.Name = "labelPemasukanFnB"
        labelPemasukanFnB.Size = New Size(0, 25)
        labelPemasukanFnB.TabIndex = 15
        ' 
        ' DataGridView2
        ' 
        DataGridView2.BackgroundColor = SystemColors.Control
        DataGridView2.BorderStyle = BorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.MenuHighlight
        DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.Control
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, Column1, DataGridViewTextBoxColumn5})
        DataGridView2.Dock = DockStyle.Left
        DataGridView2.EnableHeadersVisualStyles = False
        DataGridView2.Location = New Point(3, 3)
        DataGridView2.Margin = New Padding(50, 3, 3, 3)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowHeadersVisible = False
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(1062, 600)
        DataGridView2.TabIndex = 22
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn1.FillWeight = 30F
        DataGridViewTextBoxColumn1.HeaderText = "No"
        DataGridViewTextBoxColumn1.MinimumWidth = 6
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        DataGridViewTextBoxColumn1.Width = 59
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.FillWeight = 200F
        DataGridViewTextBoxColumn2.HeaderText = "No Order"
        DataGridViewTextBoxColumn2.MinimumWidth = 4
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        DataGridViewTextBoxColumn2.Width = 200
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn3.FillWeight = 300F
        DataGridViewTextBoxColumn3.HeaderText = "Nama Menu"
        DataGridViewTextBoxColumn3.MinimumWidth = 6
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn4.HeaderText = "Qty"
        DataGridViewTextBoxColumn4.MinimumWidth = 6
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        DataGridViewTextBoxColumn4.ReadOnly = True
        DataGridViewTextBoxColumn4.Width = 62
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Harga"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 130
        ' 
        ' DataGridViewTextBoxColumn5
        ' 
        DataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn5.HeaderText = "Metode Bayar"
        DataGridViewTextBoxColumn5.MinimumWidth = 6
        DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        DataGridViewTextBoxColumn5.ReadOnly = True
        DataGridViewTextBoxColumn5.Width = 123
        ' 
        ' FormTransaksi
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1333, 749)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "FormTransaksi"
        Padding = New Padding(15)
        Text = "FormTransaksi"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        tpBilling.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        tpFnB.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents bayar As DataGridViewTextBoxColumn
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpBilling As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents labelPemasukanBilling As Label
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents noOrder As DataGridViewTextBoxColumn
    Friend WithEvents durasi As DataGridViewTextBoxColumn
    Friend WithEvents totalHarga As DataGridViewTextBoxColumn
    Friend WithEvents metodebayar As DataGridViewTextBoxColumn
    Friend WithEvents tpFnB As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents labelPemasukanFnB As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
