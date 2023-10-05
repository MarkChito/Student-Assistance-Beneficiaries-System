<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        pnl_login_form = New Panel()
        Panel4 = New Panel()
        btn_sign_in_using_rfid_card = New Button()
        btn_sign_in = New Button()
        remember_me = New CheckBox()
        PictureBox3 = New PictureBox()
        txt_password = New TextBox()
        PictureBox2 = New PictureBox()
        txt_username = New TextBox()
        Label2 = New Label()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Label3 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        btn_temp = New Button()
        pnl_notification = New Panel()
        lbl_notification = New Label()
        pnl_parent = New Panel()
        Timer1 = New Timer(components)
        pnl_login_form.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnl_notification.SuspendLayout()
        pnl_parent.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnl_login_form
        ' 
        pnl_login_form.BackColor = Color.Transparent
        pnl_login_form.Controls.Add(Panel4)
        pnl_login_form.Controls.Add(Panel3)
        pnl_login_form.Controls.Add(Panel2)
        pnl_login_form.Dock = DockStyle.Bottom
        pnl_login_form.Location = New Point(0, 61)
        pnl_login_form.MaximumSize = New Size(400, 524)
        pnl_login_form.MinimumSize = New Size(400, 524)
        pnl_login_form.Name = "pnl_login_form"
        pnl_login_form.Size = New Size(400, 524)
        pnl_login_form.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(btn_sign_in_using_rfid_card)
        Panel4.Controls.Add(btn_sign_in)
        Panel4.Controls.Add(remember_me)
        Panel4.Controls.Add(PictureBox3)
        Panel4.Controls.Add(txt_password)
        Panel4.Controls.Add(PictureBox2)
        Panel4.Controls.Add(txt_username)
        Panel4.Controls.Add(Label2)
        Panel4.Dock = DockStyle.Fill
        Panel4.Location = New Point(0, 246)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(400, 278)
        Panel4.TabIndex = 3
        ' 
        ' btn_sign_in_using_rfid_card
        ' 
        btn_sign_in_using_rfid_card.BackColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
        btn_sign_in_using_rfid_card.Cursor = Cursors.Hand
        btn_sign_in_using_rfid_card.FlatAppearance.BorderSize = 0
        btn_sign_in_using_rfid_card.FlatStyle = FlatStyle.Flat
        btn_sign_in_using_rfid_card.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_sign_in_using_rfid_card.ForeColor = Color.White
        btn_sign_in_using_rfid_card.Location = New Point(28, 209)
        btn_sign_in_using_rfid_card.Name = "btn_sign_in_using_rfid_card"
        btn_sign_in_using_rfid_card.Size = New Size(344, 40)
        btn_sign_in_using_rfid_card.TabIndex = 5
        btn_sign_in_using_rfid_card.Text = "Sign in using &RFID Card"
        btn_sign_in_using_rfid_card.UseVisualStyleBackColor = False
        ' 
        ' btn_sign_in
        ' 
        btn_sign_in.BackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btn_sign_in.Cursor = Cursors.Hand
        btn_sign_in.FlatAppearance.BorderSize = 0
        btn_sign_in.FlatStyle = FlatStyle.Flat
        btn_sign_in.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_sign_in.ForeColor = Color.White
        btn_sign_in.Location = New Point(222, 153)
        btn_sign_in.Name = "btn_sign_in"
        btn_sign_in.Size = New Size(150, 40)
        btn_sign_in.TabIndex = 4
        btn_sign_in.Text = "Sign &In"
        btn_sign_in.UseVisualStyleBackColor = False
        ' 
        ' remember_me
        ' 
        remember_me.AutoSize = True
        remember_me.Cursor = Cursors.Hand
        remember_me.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        remember_me.Location = New Point(28, 153)
        remember_me.Name = "remember_me"
        remember_me.Size = New Size(127, 20)
        remember_me.TabIndex = 3
        remember_me.Text = "&Remember Me"
        remember_me.UseVisualStyleBackColor = True
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        PictureBox3.BorderStyle = BorderStyle.FixedSingle
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(346, 111)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(26, 26)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 4
        PictureBox3.TabStop = False
        ' 
        ' txt_password
        ' 
        txt_password.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_password.Location = New Point(28, 111)
        txt_password.Name = "txt_password"
        txt_password.PlaceholderText = "Password"
        txt_password.Size = New Size(319, 26)
        txt_password.TabIndex = 2
        txt_password.UseSystemPasswordChar = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.FromArgb(CByte(233), CByte(236), CByte(239))
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(346, 69)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(26, 26)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' txt_username
        ' 
        txt_username.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_username.Location = New Point(28, 69)
        txt_username.Name = "txt_username"
        txt_username.PlaceholderText = "Username"
        txt_username.Size = New Size(319, 26)
        txt_username.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(132, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 20)
        Label2.TabIndex = 0
        Label2.Text = "Sign in to proceed"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Gray
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 245)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(400, 1)
        Panel3.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(400, 245)
        Panel2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(44, 197)
        Label3.Name = "Label3"
        Label3.Size = New Size(312, 37)
        Label3.TabIndex = 2
        Label3.Text = "Beneficiaries System"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(55, 160)
        Label1.Name = "Label1"
        Label1.Size = New Size(291, 37)
        Label1.TabIndex = 1
        Label1.Text = "Student Assistance"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(125, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 150)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btn_temp
        ' 
        btn_temp.Location = New Point(155, -61)
        btn_temp.Name = "btn_temp"
        btn_temp.Size = New Size(75, 23)
        btn_temp.TabIndex = 0
        btn_temp.Text = "Button3"
        btn_temp.UseVisualStyleBackColor = True
        ' 
        ' pnl_notification
        ' 
        pnl_notification.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        pnl_notification.Controls.Add(lbl_notification)
        pnl_notification.Dock = DockStyle.Top
        pnl_notification.Location = New Point(0, 0)
        pnl_notification.MaximumSize = New Size(400, 50)
        pnl_notification.Name = "pnl_notification"
        pnl_notification.Size = New Size(400, 50)
        pnl_notification.TabIndex = 1
        pnl_notification.Visible = False
        ' 
        ' lbl_notification
        ' 
        lbl_notification.AutoSize = True
        lbl_notification.BackColor = Color.Transparent
        lbl_notification.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_notification.ForeColor = Color.White
        lbl_notification.Location = New Point(89, 15)
        lbl_notification.Name = "lbl_notification"
        lbl_notification.Size = New Size(223, 20)
        lbl_notification.TabIndex = 0
        lbl_notification.Text = "Invalid Username or Password"
        ' 
        ' pnl_parent
        ' 
        pnl_parent.AutoSize = True
        pnl_parent.BackColor = Color.Transparent
        pnl_parent.Controls.Add(pnl_notification)
        pnl_parent.Controls.Add(pnl_login_form)
        pnl_parent.Location = New Point(17, 13)
        pnl_parent.Name = "pnl_parent"
        pnl_parent.Size = New Size(400, 585)
        pnl_parent.TabIndex = 2
        ' 
        ' Timer1
        ' 
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(249), CByte(255))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(434, 611)
        Controls.Add(pnl_parent)
        Controls.Add(btn_temp)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(450, 650)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Administrator Login"
        pnl_login_form.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnl_notification.ResumeLayout(False)
        pnl_notification.PerformLayout()
        pnl_parent.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnl_login_form As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents remember_me As CheckBox
    Friend WithEvents btn_sign_in As Button
    Friend WithEvents btn_sign_in_using_rfid_card As Button
    Friend WithEvents btn_temp As Button
    Friend WithEvents pnl_notification As Panel
    Friend WithEvents lbl_notification As Label
    Friend WithEvents pnl_parent As Panel
    Friend WithEvents Timer1 As Timer
End Class
