<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLoginPengaturan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLoginPengaturan))
        txtUser = New TextBox()
        ToolTip1 = New ToolTip(components)
        FlowLayoutPanel1 = New FlowLayoutPanel()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        PictureBox3 = New PictureBox()
        txtPass = New TextBox()
        Panel1 = New Panel()
        btnLogin = New Button()
        Label1 = New Label()
        FlowLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtUser
        ' 
        txtUser.Dock = DockStyle.Bottom
        txtUser.Font = New Font("Segoe UI", 12F)
        txtUser.Location = New Point(72, 12)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(218, 34)
        txtUser.TabIndex = 1
        txtUser.Text = "Username"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(PictureBox1)
        FlowLayoutPanel1.Controls.Add(txtUser)
        FlowLayoutPanel1.Location = New Point(118, 247)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(302, 51)
        FlowLayoutPanel1.TabIndex = 7
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.Image = My.Resources.Resources.user
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(63, 43)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(26, 29)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(481, 138)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(PictureBox3)
        FlowLayoutPanel2.Controls.Add(txtPass)
        FlowLayoutPanel2.Location = New Point(118, 328)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(302, 51)
        FlowLayoutPanel2.TabIndex = 8
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox3.Image = My.Resources.Resources.padlock
        PictureBox3.Location = New Point(3, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(63, 43)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' txtPass
        ' 
        txtPass.Dock = DockStyle.Bottom
        txtPass.Font = New Font("Segoe UI", 12F)
        txtPass.Location = New Point(72, 12)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(218, 34)
        txtPass.TabIndex = 1
        txtPass.Text = "Password"
        ' 
        ' Panel1
        ' 
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(519, 23)
        Panel1.TabIndex = 10
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.MenuHighlight
        btnLogin.Font = New Font("Segoe UI", 12F)
        btnLogin.ForeColor = SystemColors.InactiveBorder
        btnLogin.Location = New Point(118, 385)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(302, 47)
        btnLogin.TabIndex = 9
        btnLogin.Text = "Sign In"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(143, 184)
        Label1.Name = "Label1"
        Label1.Size = New Size(256, 28)
        Label1.TabIndex = 11
        Label1.Text = "Masuk Pengaturan Admin"
        ' 
        ' FormLoginPengaturan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(519, 447)
        Controls.Add(Label1)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(PictureBox2)
        Controls.Add(FlowLayoutPanel2)
        Controls.Add(Panel1)
        Controls.Add(btnLogin)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormLoginPengaturan"
        Text = "FormLoginPengaturan"
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUser As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
End Class
