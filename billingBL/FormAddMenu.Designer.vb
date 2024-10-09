<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddMenu
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
        Panel1 = New Panel()
        Label1 = New Label()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        DataGridView1 = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        PictureBox2 = New PictureBox()
        TabPage2 = New TabPage()
        Panel17 = New Panel()
        btnAddMenu = New Button()
        tbHargaMenu = New TextBox()
        Label4 = New Label()
        tbNamaMenu = New TextBox()
        Label2 = New Label()
        picFoodImg = New CirclePicturBox()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        Panel17.SuspendLayout()
        CType(picFoodImg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.MenuHighlight
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(623, 61)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(623, 61)
        Label1.TabIndex = 0
        Label1.Text = "List Menu"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 61)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(623, 463)
        TabControl1.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(DataGridView1)
        TabPage1.Controls.Add(Panel2)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(615, 430)
        TabPage1.TabIndex = 0
        TabPage1.Text = "LIST MENU"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ControlLightLight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn3})
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(3, 67)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(609, 360)
        DataGridView1.TabIndex = 12
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn1.HeaderText = "Nama Menu"
        DataGridViewTextBoxColumn1.MinimumWidth = 6
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn3.HeaderText = "Harga"
        DataGridViewTextBoxColumn3.MinimumWidth = 6
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(3, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(609, 64)
        Panel2.TabIndex = 11
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 10F)
        TextBox1.Location = New Point(60, 19)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(273, 30)
        TextBox1.TabIndex = 5
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.magnifier
        PictureBox2.Location = New Point(12, 15)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(32, 34)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Panel17)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(615, 430)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TAMBAH MENU"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Panel17
        ' 
        Panel17.Controls.Add(btnAddMenu)
        Panel17.Controls.Add(tbHargaMenu)
        Panel17.Controls.Add(Label4)
        Panel17.Controls.Add(tbNamaMenu)
        Panel17.Controls.Add(Label2)
        Panel17.Controls.Add(picFoodImg)
        Panel17.Dock = DockStyle.Top
        Panel17.Location = New Point(3, 3)
        Panel17.Name = "Panel17"
        Panel17.Size = New Size(609, 424)
        Panel17.TabIndex = 11
        ' 
        ' btnAddMenu
        ' 
        btnAddMenu.BackColor = SystemColors.MenuHighlight
        btnAddMenu.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddMenu.ForeColor = SystemColors.Control
        btnAddMenu.Location = New Point(338, 249)
        btnAddMenu.Name = "btnAddMenu"
        btnAddMenu.Size = New Size(197, 53)
        btnAddMenu.TabIndex = 7
        btnAddMenu.Text = "ADD MENU"
        btnAddMenu.UseVisualStyleBackColor = False
        ' 
        ' tbHargaMenu
        ' 
        tbHargaMenu.Font = New Font("Segoe UI", 10F)
        tbHargaMenu.Location = New Point(338, 186)
        tbHargaMenu.Name = "tbHargaMenu"
        tbHargaMenu.Size = New Size(220, 30)
        tbHargaMenu.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(338, 163)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 23)
        Label4.TabIndex = 5
        Label4.Text = "Harga"
        ' 
        ' tbNamaMenu
        ' 
        tbNamaMenu.Font = New Font("Segoe UI", 10F)
        tbNamaMenu.Location = New Point(338, 123)
        tbNamaMenu.Name = "tbNamaMenu"
        tbNamaMenu.Size = New Size(220, 30)
        tbNamaMenu.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(338, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 23)
        Label2.TabIndex = 1
        Label2.Text = "Nama Menu"
        ' 
        ' picFoodImg
        ' 
        picFoodImg.BackColor = Color.LightGray
        picFoodImg.Location = New Point(104, 100)
        picFoodImg.Name = "picFoodImg"
        picFoodImg.Size = New Size(155, 136)
        picFoodImg.TabIndex = 0
        picFoodImg.TabStop = False
        ' 
        ' FormAddMenu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(623, 524)
        Controls.Add(TabControl1)
        Controls.Add(Panel1)
        MaximizeBox = False
        Name = "FormAddMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormAddMenu"
        Panel1.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        Panel17.ResumeLayout(False)
        Panel17.PerformLayout()
        CType(picFoodImg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel17 As Panel
    Friend WithEvents tbHargaMenu As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbNamaMenu As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents picFoodImg As CirclePicturBox
    Friend WithEvents btnAddMenu As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
