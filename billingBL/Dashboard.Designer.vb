﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        SideNavbar = New Panel()
        btnPengaturan = New FontAwesome.Sharp.IconButton()
        btnLaporan = New FontAwesome.Sharp.IconButton()
        btnTransaksi = New FontAwesome.Sharp.IconButton()
        btnMenu = New FontAwesome.Sharp.IconButton()
        btnBilling = New FontAwesome.Sharp.IconButton()
        btnDashboard = New FontAwesome.Sharp.IconButton()
        Panel1 = New Panel()
        imgboxlogo = New PictureBox()
        PanelJudul = New Panel()
        textboxAlamat = New TextBox()
        btnLogout = New FontAwesome.Sharp.IconButton()
        SideNavbar.SuspendLayout()
        Panel1.SuspendLayout()
        CType(imgboxlogo, ComponentModel.ISupportInitialize).BeginInit()
        PanelJudul.SuspendLayout()
        SuspendLayout()
        ' 
        ' SideNavbar
        ' 
        SideNavbar.BackColor = SystemColors.MenuHighlight
        SideNavbar.Controls.Add(btnLogout)
        SideNavbar.Controls.Add(btnPengaturan)
        SideNavbar.Controls.Add(btnLaporan)
        SideNavbar.Controls.Add(btnTransaksi)
        SideNavbar.Controls.Add(btnMenu)
        SideNavbar.Controls.Add(btnBilling)
        SideNavbar.Controls.Add(btnDashboard)
        SideNavbar.Controls.Add(Panel1)
        SideNavbar.Dock = DockStyle.Left
        SideNavbar.Location = New Point(0, 0)
        SideNavbar.Name = "SideNavbar"
        SideNavbar.Size = New Size(200, 698)
        SideNavbar.TabIndex = 0
        ' 
        ' btnPengaturan
        ' 
        btnPengaturan.Dock = DockStyle.Top
        btnPengaturan.FlatAppearance.BorderSize = 0
        btnPengaturan.FlatStyle = FlatStyle.Flat
        btnPengaturan.ForeColor = SystemColors.ButtonHighlight
        btnPengaturan.IconChar = FontAwesome.Sharp.IconChar.SignOut
        btnPengaturan.IconColor = Color.White
        btnPengaturan.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnPengaturan.IconSize = 32
        btnPengaturan.ImageAlign = ContentAlignment.MiddleLeft
        btnPengaturan.Location = New Point(0, 530)
        btnPengaturan.Name = "btnPengaturan"
        btnPengaturan.Padding = New Padding(10, 0, 0, 0)
        btnPengaturan.Size = New Size(200, 70)
        btnPengaturan.TabIndex = 7
        btnPengaturan.Text = "Pengaturan"
        btnPengaturan.TextAlign = ContentAlignment.MiddleLeft
        btnPengaturan.TextImageRelation = TextImageRelation.ImageBeforeText
        btnPengaturan.UseVisualStyleBackColor = True
        ' 
        ' btnLaporan
        ' 
        btnLaporan.Dock = DockStyle.Top
        btnLaporan.FlatAppearance.BorderSize = 0
        btnLaporan.FlatStyle = FlatStyle.Flat
        btnLaporan.ForeColor = SystemColors.ButtonHighlight
        btnLaporan.IconChar = FontAwesome.Sharp.IconChar.Gear
        btnLaporan.IconColor = Color.White
        btnLaporan.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnLaporan.IconSize = 32
        btnLaporan.ImageAlign = ContentAlignment.MiddleLeft
        btnLaporan.Location = New Point(0, 460)
        btnLaporan.Name = "btnLaporan"
        btnLaporan.Padding = New Padding(10, 0, 0, 0)
        btnLaporan.Size = New Size(200, 70)
        btnLaporan.TabIndex = 6
        btnLaporan.Text = "Laporan"
        btnLaporan.TextAlign = ContentAlignment.MiddleLeft
        btnLaporan.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLaporan.UseVisualStyleBackColor = True
        ' 
        ' btnTransaksi
        ' 
        btnTransaksi.Dock = DockStyle.Top
        btnTransaksi.FlatAppearance.BorderSize = 0
        btnTransaksi.FlatStyle = FlatStyle.Flat
        btnTransaksi.ForeColor = SystemColors.ButtonHighlight
        btnTransaksi.IconChar = FontAwesome.Sharp.IconChar.Receipt
        btnTransaksi.IconColor = Color.White
        btnTransaksi.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnTransaksi.IconSize = 32
        btnTransaksi.ImageAlign = ContentAlignment.MiddleLeft
        btnTransaksi.Location = New Point(0, 390)
        btnTransaksi.Name = "btnTransaksi"
        btnTransaksi.Padding = New Padding(10, 0, 0, 0)
        btnTransaksi.Size = New Size(200, 70)
        btnTransaksi.TabIndex = 5
        btnTransaksi.Text = "Transaksi"
        btnTransaksi.TextAlign = ContentAlignment.MiddleLeft
        btnTransaksi.TextImageRelation = TextImageRelation.ImageBeforeText
        btnTransaksi.UseVisualStyleBackColor = True
        ' 
        ' btnMenu
        ' 
        btnMenu.Dock = DockStyle.Top
        btnMenu.FlatAppearance.BorderSize = 0
        btnMenu.FlatStyle = FlatStyle.Flat
        btnMenu.ForeColor = SystemColors.ButtonHighlight
        btnMenu.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed
        btnMenu.IconColor = Color.White
        btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnMenu.IconSize = 32
        btnMenu.ImageAlign = ContentAlignment.MiddleLeft
        btnMenu.Location = New Point(0, 320)
        btnMenu.Name = "btnMenu"
        btnMenu.Padding = New Padding(10, 0, 0, 0)
        btnMenu.Size = New Size(200, 70)
        btnMenu.TabIndex = 4
        btnMenu.Text = "Menu"
        btnMenu.TextAlign = ContentAlignment.MiddleLeft
        btnMenu.TextImageRelation = TextImageRelation.ImageBeforeText
        btnMenu.UseVisualStyleBackColor = True
        ' 
        ' btnBilling
        ' 
        btnBilling.Dock = DockStyle.Top
        btnBilling.FlatAppearance.BorderSize = 0
        btnBilling.FlatStyle = FlatStyle.Flat
        btnBilling.ForeColor = SystemColors.ButtonHighlight
        btnBilling.IconChar = FontAwesome.Sharp.IconChar.Table
        btnBilling.IconColor = Color.White
        btnBilling.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnBilling.IconSize = 32
        btnBilling.ImageAlign = ContentAlignment.MiddleLeft
        btnBilling.Location = New Point(0, 250)
        btnBilling.Name = "btnBilling"
        btnBilling.Padding = New Padding(10, 0, 0, 0)
        btnBilling.Size = New Size(200, 70)
        btnBilling.TabIndex = 3
        btnBilling.Text = "Billing"
        btnBilling.TextAlign = ContentAlignment.MiddleLeft
        btnBilling.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBilling.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Dock = DockStyle.Top
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.ForeColor = SystemColors.ButtonHighlight
        btnDashboard.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyWindow
        btnDashboard.IconColor = Color.White
        btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnDashboard.IconSize = 32
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnDashboard.Location = New Point(0, 180)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Padding = New Padding(10, 0, 0, 0)
        btnDashboard.Size = New Size(200, 70)
        btnDashboard.TabIndex = 2
        btnDashboard.Text = "Dashboard"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(imgboxlogo)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 180)
        Panel1.TabIndex = 1
        ' 
        ' imgboxlogo
        ' 
        imgboxlogo.Dock = DockStyle.Fill
        imgboxlogo.Image = My.Resources.Resources.logo21
        imgboxlogo.Location = New Point(0, 0)
        imgboxlogo.Name = "imgboxlogo"
        imgboxlogo.Size = New Size(200, 180)
        imgboxlogo.SizeMode = PictureBoxSizeMode.Zoom
        imgboxlogo.TabIndex = 0
        imgboxlogo.TabStop = False
        ' 
        ' PanelJudul
        ' 
        PanelJudul.BackColor = SystemColors.MenuHighlight
        PanelJudul.Controls.Add(textboxAlamat)
        PanelJudul.Dock = DockStyle.Top
        PanelJudul.Location = New Point(200, 0)
        PanelJudul.Name = "PanelJudul"
        PanelJudul.Size = New Size(737, 100)
        PanelJudul.TabIndex = 1
        ' 
        ' textboxAlamat
        ' 
        textboxAlamat.Dock = DockStyle.Bottom
        textboxAlamat.Location = New Point(0, 77)
        textboxAlamat.Name = "textboxAlamat"
        textboxAlamat.Size = New Size(737, 23)
        textboxAlamat.TabIndex = 0
        textboxAlamat.Text = "Alamat Lokasi"
        textboxAlamat.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnLogout
        ' 
        btnLogout.Dock = DockStyle.Top
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = SystemColors.ButtonHighlight
        btnLogout.IconChar = FontAwesome.Sharp.IconChar.Table
        btnLogout.IconColor = Color.White
        btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnLogout.IconSize = 32
        btnLogout.ImageAlign = ContentAlignment.MiddleLeft
        btnLogout.Location = New Point(0, 600)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(10, 0, 0, 0)
        btnLogout.Size = New Size(200, 70)
        btnLogout.TabIndex = 8
        btnLogout.Text = "Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(937, 698)
        Controls.Add(PanelJudul)
        Controls.Add(SideNavbar)
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        WindowState = FormWindowState.Maximized
        SideNavbar.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(imgboxlogo, ComponentModel.ISupportInitialize).EndInit()
        PanelJudul.ResumeLayout(False)
        PanelJudul.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SideNavbar As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents imgboxlogo As PictureBox
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelJudul As Panel
    Friend WithEvents btnPengaturan As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLaporan As FontAwesome.Sharp.IconButton
    Friend WithEvents btnTransaksi As FontAwesome.Sharp.IconButton
    Friend WithEvents btnBilling As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLogout As FontAwesome.Sharp.IconButton
    Friend WithEvents textboxAlamat As TextBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents btn As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMenu As FontAwesome.Sharp.IconButton
End Class
