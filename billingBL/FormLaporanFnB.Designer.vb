<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanFnB
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
        Label2 = New Label()
        Label1 = New Label()
        labelTotalPemasukan = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        btnFilter = New Button()
        datePickerAfter = New DateTimePicker()
        datePickerBefore = New DateTimePicker()
        btnExport = New Button()
        DataGridView1 = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(83, 164)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 28)
        Label2.TabIndex = 24
        Label2.Text = "Pilih Tahun"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(83, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(1167, 45)
        Label1.TabIndex = 23
        Label1.Text = "DATA LAPORAN FnB"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        Label1.UseCompatibleTextRendering = True
        ' 
        ' labelTotalPemasukan
        ' 
        labelTotalPemasukan.AutoSize = True
        labelTotalPemasukan.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelTotalPemasukan.ForeColor = SystemColors.ControlLightLight
        labelTotalPemasukan.Location = New Point(32, 53)
        labelTotalPemasukan.Name = "labelTotalPemasukan"
        labelTotalPemasukan.Size = New Size(0, 25)
        labelTotalPemasukan.TabIndex = 15
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.MenuHighlight
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(labelTotalPemasukan)
        Panel1.Location = New Point(1053, 117)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(197, 99)
        Panel1.TabIndex = 28
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(32, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(165, 28)
        Label3.TabIndex = 16
        Label3.Text = "Total Pemasukan"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btnFilter
        ' 
        btnFilter.BackColor = SystemColors.MenuHighlight
        btnFilter.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFilter.ForeColor = SystemColors.Control
        btnFilter.Location = New Point(571, 158)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(103, 41)
        btnFilter.TabIndex = 22
        btnFilter.Text = "FILTER"
        btnFilter.UseVisualStyleBackColor = False
        ' 
        ' datePickerAfter
        ' 
        datePickerAfter.Location = New Point(398, 164)
        datePickerAfter.Name = "datePickerAfter"
        datePickerAfter.Size = New Size(166, 27)
        datePickerAfter.TabIndex = 27
        ' 
        ' datePickerBefore
        ' 
        datePickerBefore.Location = New Point(215, 164)
        datePickerBefore.Name = "datePickerBefore"
        datePickerBefore.Size = New Size(166, 27)
        datePickerBefore.TabIndex = 26
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = Color.Green
        btnExport.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExport.ForeColor = SystemColors.Control
        btnExport.Location = New Point(679, 158)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(103, 41)
        btnExport.TabIndex = 29
        btnExport.Text = "EXPORT"
        btnExport.UseVisualStyleBackColor = False
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
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, Column1, DataGridViewTextBoxColumn5, Column2})
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.Location = New Point(83, 239)
        DataGridView1.Margin = New Padding(50, 3, 3, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1167, 510)
        DataGridView1.TabIndex = 30
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
        DataGridViewTextBoxColumn5.Width = 134
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "Tanggal Transaksi"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 145
        ' 
        ' FormLaporanFnB
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1333, 749)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(btnFilter)
        Controls.Add(datePickerAfter)
        Controls.Add(datePickerBefore)
        Controls.Add(btnExport)
        Name = "FormLaporanFnB"
        Text = "FormLaporanFnB"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents labelTotalPemasukan As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnFilter As Button
    Friend WithEvents datePickerAfter As DateTimePicker
    Friend WithEvents datePickerBefore As DateTimePicker
    Friend WithEvents btnExport As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
