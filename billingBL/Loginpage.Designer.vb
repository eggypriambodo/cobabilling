<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Loginpage
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
        components = New ComponentModel.Container()
        ToolTip1 = New ToolTip(components)
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        PictureBox1 = New PictureBox()
        txtUser = New TextBox()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        PictureBox3 = New PictureBox()
        txtPass = New TextBox()
        btnLogin = New Button()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Top
        PictureBox2.Image = My.Resources.Resources.logobl
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(537, 148)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(0, 148)
        Label1.Name = "Label1"
        Label1.Size = New Size(537, 46)
        Label1.TabIndex = 1
        Label1.Text = "Sign In"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(PictureBox1)
        FlowLayoutPanel1.Controls.Add(txtUser)
        FlowLayoutPanel1.Location = New Point(118, 211)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(302, 50)
        FlowLayoutPanel1.TabIndex = 2
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
        ' txtUser
        ' 
        txtUser.Dock = DockStyle.Bottom
        txtUser.Font = New Font("Segoe UI", 12.0F)
        txtUser.Location = New Point(72, 12)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(218, 34)
        txtUser.TabIndex = 1
        txtUser.Text = "Username"
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(PictureBox3)
        FlowLayoutPanel2.Controls.Add(txtPass)
        FlowLayoutPanel2.Location = New Point(118, 287)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(302, 50)
        FlowLayoutPanel2.TabIndex = 3
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
        txtPass.Font = New Font("Segoe UI", 12.0F)
        txtPass.Location = New Point(72, 12)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(218, 34)
        txtPass.TabIndex = 1
        txtPass.Text = "Password"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.DeepSkyBlue
        btnLogin.Font = New Font("Segoe UI", 12.0F)
        btnLogin.Location = New Point(118, 350)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(302, 47)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Sign In"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Loginpage
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.White
        ClientSize = New Size(537, 437)
        Controls.Add(Label1)
        Controls.Add(btnLogin)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(FlowLayoutPanel2)
        Controls.Add(PictureBox2)
        ForeColor = Color.White
        MaximizeBox = False
        Name = "Loginpage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Page"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnLogin As Button

End Class
