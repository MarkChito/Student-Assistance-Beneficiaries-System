<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Main))
        pnl_sidebar = New Panel()
        btn_logout = New Button()
        pnl_scholarship_spacer_3 = New Panel()
        btn_scholarship_rejected = New Button()
        pnl_scholarship_spacer_2 = New Panel()
        btn_scholarship_approved = New Button()
        pnl_scholarship_spacer_1 = New Panel()
        btn_scholarship_pending = New Button()
        pnl_scholarship_spacer = New Panel()
        btn_scholarship = New Button()
        pnl_educational_spacer_3 = New Panel()
        btn_educational_rejected = New Button()
        pnl_educational_spacer_2 = New Panel()
        btn_educational_approved = New Button()
        pnl_educational_spacer_1 = New Panel()
        btn_educational_pending = New Button()
        pnl_educational_spacer = New Panel()
        btn_educational = New Button()
        pnl_scan_qr_code_spacer = New Panel()
        btn_scan_qr_code = New Button()
        pnl_dashboard_spacer = New Panel()
        btn_dashboard = New Button()
        pnl_spacer = New Panel()
        Panel5 = New Panel()
        pnl_logo = New Panel()
        btn_temp = New Button()
        pnl_header = New Panel()
        Panel1 = New Panel()
        img_user_image = New PictureBox()
        btn_account = New Button()
        btn_toggle_sidebar = New PictureBox()
        pnl_footer = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        pnl_body = New Panel()
        Dashboard = New Dashboard()
        pnl_account_details = New Panel()
        btn_logout_2 = New Button()
        btn_developers = New Button()
        btn_account_settings = New Button()
        Scan_QR_Code = New Scan_QR_Code()
        img_loading = New PictureBox()
        Pending = New Pending()
        Approved = New Approved()
        Rejected = New Rejected()
        Timer1 = New Timer(components)
        pnl_sidebar.SuspendLayout()
        pnl_spacer.SuspendLayout()
        pnl_header.SuspendLayout()
        Panel1.SuspendLayout()
        CType(img_user_image, ComponentModel.ISupportInitialize).BeginInit()
        CType(btn_toggle_sidebar, ComponentModel.ISupportInitialize).BeginInit()
        pnl_footer.SuspendLayout()
        pnl_body.SuspendLayout()
        pnl_account_details.SuspendLayout()
        CType(img_loading, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnl_sidebar
        ' 
        pnl_sidebar.AutoScroll = True
        pnl_sidebar.BackColor = Color.FromArgb(CByte(52), CByte(58), CByte(64))
        pnl_sidebar.Controls.Add(btn_logout)
        pnl_sidebar.Controls.Add(pnl_scholarship_spacer_3)
        pnl_sidebar.Controls.Add(btn_scholarship_rejected)
        pnl_sidebar.Controls.Add(pnl_scholarship_spacer_2)
        pnl_sidebar.Controls.Add(btn_scholarship_approved)
        pnl_sidebar.Controls.Add(pnl_scholarship_spacer_1)
        pnl_sidebar.Controls.Add(btn_scholarship_pending)
        pnl_sidebar.Controls.Add(pnl_scholarship_spacer)
        pnl_sidebar.Controls.Add(btn_scholarship)
        pnl_sidebar.Controls.Add(pnl_educational_spacer_3)
        pnl_sidebar.Controls.Add(btn_educational_rejected)
        pnl_sidebar.Controls.Add(pnl_educational_spacer_2)
        pnl_sidebar.Controls.Add(btn_educational_approved)
        pnl_sidebar.Controls.Add(pnl_educational_spacer_1)
        pnl_sidebar.Controls.Add(btn_educational_pending)
        pnl_sidebar.Controls.Add(pnl_educational_spacer)
        pnl_sidebar.Controls.Add(btn_educational)
        pnl_sidebar.Controls.Add(pnl_scan_qr_code_spacer)
        pnl_sidebar.Controls.Add(btn_scan_qr_code)
        pnl_sidebar.Controls.Add(pnl_dashboard_spacer)
        pnl_sidebar.Controls.Add(btn_dashboard)
        pnl_sidebar.Controls.Add(pnl_spacer)
        pnl_sidebar.Controls.Add(pnl_logo)
        pnl_sidebar.Dock = DockStyle.Left
        pnl_sidebar.Location = New Point(0, 0)
        pnl_sidebar.Name = "pnl_sidebar"
        pnl_sidebar.Size = New Size(280, 761)
        pnl_sidebar.TabIndex = 0
        ' 
        ' btn_logout
        ' 
        btn_logout.BackColor = Color.Transparent
        btn_logout.Cursor = Cursors.Hand
        btn_logout.Dock = DockStyle.Top
        btn_logout.FlatAppearance.BorderSize = 0
        btn_logout.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(73), CByte(78), CByte(83))
        btn_logout.FlatStyle = FlatStyle.Flat
        btn_logout.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_logout.ForeColor = Color.White
        btn_logout.Image = CType(resources.GetObject("btn_logout.Image"), Image)
        btn_logout.ImageAlign = ContentAlignment.MiddleLeft
        btn_logout.Location = New Point(0, 790)
        btn_logout.Name = "btn_logout"
        btn_logout.Size = New Size(263, 45)
        btn_logout.TabIndex = 33
        btn_logout.Text = "          Logout"
        btn_logout.TextAlign = ContentAlignment.MiddleLeft
        btn_logout.UseVisualStyleBackColor = False
        ' 
        ' pnl_scholarship_spacer_3
        ' 
        pnl_scholarship_spacer_3.Dock = DockStyle.Top
        pnl_scholarship_spacer_3.Location = New Point(0, 787)
        pnl_scholarship_spacer_3.Name = "pnl_scholarship_spacer_3"
        pnl_scholarship_spacer_3.Size = New Size(263, 3)
        pnl_scholarship_spacer_3.TabIndex = 32
        pnl_scholarship_spacer_3.Visible = False
        ' 
        ' btn_scholarship_rejected
        ' 
        btn_scholarship_rejected.BackColor = Color.Transparent
        btn_scholarship_rejected.Cursor = Cursors.Hand
        btn_scholarship_rejected.Dock = DockStyle.Top
        btn_scholarship_rejected.FlatAppearance.BorderSize = 0
        btn_scholarship_rejected.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(73), CByte(78), CByte(83))
        btn_scholarship_rejected.FlatStyle = FlatStyle.Flat
        btn_scholarship_rejected.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_scholarship_rejected.ForeColor = Color.White
        btn_scholarship_rejected.Image = CType(resources.GetObject("btn_scholarship_rejected.Image"), Image)
        btn_scholarship_rejected.ImageAlign = ContentAlignment.MiddleLeft
        btn_scholarship_rejected.Location = New Point(0, 742)
        btn_scholarship_rejected.Name = "btn_scholarship_rejected"
        btn_scholarship_rejected.Size = New Size(263, 45)
        btn_scholarship_rejected.TabIndex = 31
        btn_scholarship_rejected.Text = "          Rejected"
        btn_scholarship_rejected.TextAlign = ContentAlignment.MiddleLeft
        btn_scholarship_rejected.UseVisualStyleBackColor = False
        btn_scholarship_rejected.Visible = False
        ' 
        ' pnl_scholarship_spacer_2
        ' 
        pnl_scholarship_spacer_2.Dock = DockStyle.Top
        pnl_scholarship_spacer_2.Location = New Point(0, 739)
        pnl_scholarship_spacer_2.Name = "pnl_scholarship_spacer_2"
        pnl_scholarship_spacer_2.Size = New Size(263, 3)
        pnl_scholarship_spacer_2.TabIndex = 30
        pnl_scholarship_spacer_2.Visible = False
        ' 
        ' btn_scholarship_approved
        ' 
        btn_scholarship_approved.BackColor = Color.Transparent
        btn_scholarship_approved.Cursor = Cursors.Hand
        btn_scholarship_approved.Dock = DockStyle.Top
        btn_scholarship_approved.FlatAppearance.BorderSize = 0
        btn_scholarship_approved.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(73), CByte(78), CByte(83))
        btn_scholarship_approved.FlatStyle = FlatStyle.Flat
        btn_scholarship_approved.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_scholarship_approved.ForeColor = Color.White
        btn_scholarship_approved.Image = CType(resources.GetObject("btn_scholarship_approved.Image"), Image)
        btn_scholarship_approved.ImageAlign = ContentAlignment.MiddleLeft
        btn_scholarship_approved.Location = New Point(0, 694)
        btn_scholarship_approved.Name = "btn_scholarship_approved"
        btn_scholarship_approved.Size = New Size(263, 45)
        btn_scholarship_approved.TabIndex = 29
        btn_scholarship_approved.Text = "          Approved"
        btn_scholarship_approved.TextAlign = ContentAlignment.MiddleLeft
        btn_scholarship_approved.UseVisualStyleBackColor = False
        btn_scholarship_approved.Visible = False
        ' 
        ' pnl_scholarship_spacer_1
        ' 
        pnl_scholarship_spacer_1.Dock = DockStyle.Top
        pnl_scholarship_spacer_1.Location = New Point(0, 691)
        pnl_scholarship_spacer_1.Name = "pnl_scholarship_spacer_1"
        pnl_scholarship_spacer_1.Size = New Size(263, 3)
        pnl_scholarship_spacer_1.TabIndex = 28
        pnl_scholarship_spacer_1.Visible = False
        ' 
        ' btn_scholarship_pending
        ' 
        btn_scholarship_pending.BackColor = Color.Transparent
        btn_scholarship_pending.Cursor = Cursors.Hand
        btn_scholarship_pending.Dock = DockStyle.Top
        btn_scholarship_pending.FlatAppearance.BorderSize = 0
        btn_scholarship_pending.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(73), CByte(78), CByte(83))
        btn_scholarship_pending.FlatStyle = FlatStyle.Flat
        btn_scholarship_pending.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_scholarship_pending.ForeColor = Color.White
        btn_scholarship_pending.Image = CType(resources.GetObject("btn_scholarship_pending.Image"), Image)
        btn_scholarship_pending.ImageAlign = ContentAlignment.MiddleLeft
        btn_scholarship_pending.Location = New Point(0, 646)
        btn_scholarship_pending.Name = "btn_scholarship_pending"
        btn_scholarship_pending.Size = New Size(263, 45)
        btn_scholarship_pending.TabIndex = 27
        btn_scholarship_pending.Text = "          Pending"
        btn_scholarship_pending.TextAlign = ContentAlignment.MiddleLeft
        btn_scholarship_pending.UseVisualStyleBackColor = False
        btn_scholarship_pending.Visible = False
        ' 
        ' pnl_scholarship_spacer
        ' 
        pnl_scholarship_spacer.Dock = DockStyle.Top
        pnl_scholarship_spacer.Location = New Point(0, 643)
        pnl_scholarship_spacer.Name = "pnl_scholarship_spacer"
        pnl_scholarship_spacer.Size = New Size(263, 3)
        pnl_scholarship_spacer.TabIndex = 26
        ' 
        ' btn_scholarship
        ' 
        btn_scholarship.BackColor = Color.Transparent
        btn_scholarship.Cursor = Cursors.Hand
        btn_scholarship.Dock = DockStyle.Top
        btn_scholarship.FlatAppearance.BorderSize = 0
        btn_scholarship.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(73), CByte(78), CByte(83))
        btn_scholarship.FlatStyle = FlatStyle.Flat
        btn_scholarship.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_scholarship.ForeColor = Color.White
        btn_scholarship.Image = CType(resources.GetObject("btn_scholarship.Image"), Image)
        btn_scholarship.ImageAlign = ContentAlignment.MiddleLeft
        btn_scholarship.Location = New Point(0, 598)
        btn_scholarship.Name = "btn_scholarship"
        btn_scholarship.Size = New Size(263, 45)
        btn_scholarship.TabIndex = 25
        btn_scholarship.Text = "          Scholarship"
        btn_scholarship.TextAlign = ContentAlignment.MiddleLeft
        btn_scholarship.UseVisualStyleBackColor = False
        ' 
        ' pnl_educational_spacer_3
        ' 
        pnl_educational_spacer_3.Dock = DockStyle.Top
        pnl_educational_spacer_3.Location = New Point(0, 595)
        pnl_educational_spacer_3.Name = "pnl_educational_spacer_3"
        pnl_educational_spacer_3.Size = New Size(263, 3)
        pnl_educational_spacer_3.TabIndex = 24
        pnl_educational_spacer_3.Visible = False
        ' 
        ' btn_educational_rejected
        ' 
        btn_educational_rejected.BackColor = Color.Transparent
        btn_educational_rejected.Cursor = Cursors.Hand
        btn_educational_rejected.Dock = DockStyle.Top
        btn_educational_rejected.FlatAppearance.BorderSize = 0
        btn_educational_rejected.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(73), CByte(78), CByte(83))
        btn_educational_rejected.FlatStyle = FlatStyle.Flat
        btn_educational_rejected.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_educational_rejected.ForeColor = Color.White
        btn_educational_rejected.Image = CType(resources.GetObject("btn_educational_rejected.Image"), Image)
        btn_educational_rejected.ImageAlign = ContentAlignment.MiddleLeft
        btn_educational_rejected.Location = New Point(0, 550)
        btn_educational_rejected.Name = "btn_educational_rejected"
        btn_educational_rejected.Size = New Size(263, 45)
        btn_educational_rejected.TabIndex = 23
        btn_educational_rejected.Text = "          Rejected"
        btn_educational_rejected.TextAlign = ContentAlignment.MiddleLeft
        btn_educational_rejected.UseVisualStyleBackColor = False
        btn_educational_rejected.Visible = False
        ' 
        ' pnl_educational_spacer_2
        ' 
        pnl_educational_spacer_2.Dock = DockStyle.Top
        pnl_educational_spacer_2.Location = New Point(0, 547)
        pnl_educational_spacer_2.Name = "pnl_educational_spacer_2"
        pnl_educational_spacer_2.Size = New Size(263, 3)
        pnl_educational_spacer_2.TabIndex = 22
        pnl_educational_spacer_2.Visible = False
        ' 
        ' btn_educational_approved
        ' 
        btn_educational_approved.BackColor = Color.Transparent
        btn_educational_approved.Cursor = Cursors.Hand
        btn_educational_approved.Dock = DockStyle.Top
        btn_educational_approved.FlatAppearance.BorderSize = 0
        btn_educational_approved.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(73), CByte(78), CByte(83))
        btn_educational_approved.FlatStyle = FlatStyle.Flat
        btn_educational_approved.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_educational_approved.ForeColor = Color.White
        btn_educational_approved.Image = CType(resources.GetObject("btn_educational_approved.Image"), Image)
        btn_educational_approved.ImageAlign = ContentAlignment.MiddleLeft
        btn_educational_approved.Location = New Point(0, 502)
        btn_educational_approved.Name = "btn_educational_approved"
        btn_educational_approved.Size = New Size(263, 45)
        btn_educational_approved.TabIndex = 21
        btn_educational_approved.Text = "          Approved"
        btn_educational_approved.TextAlign = ContentAlignment.MiddleLeft
        btn_educational_approved.UseVisualStyleBackColor = False
        btn_educational_approved.Visible = False
        ' 
        ' pnl_educational_spacer_1
        ' 
        pnl_educational_spacer_1.Dock = DockStyle.Top
        pnl_educational_spacer_1.Location = New Point(0, 499)
        pnl_educational_spacer_1.Name = "pnl_educational_spacer_1"
        pnl_educational_spacer_1.Size = New Size(263, 3)
        pnl_educational_spacer_1.TabIndex = 20
        pnl_educational_spacer_1.Visible = False
        ' 
        ' btn_educational_pending
        ' 
        btn_educational_pending.BackColor = Color.Transparent
        btn_educational_pending.Cursor = Cursors.Hand
        btn_educational_pending.Dock = DockStyle.Top
        btn_educational_pending.FlatAppearance.BorderSize = 0
        btn_educational_pending.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(73), CByte(78), CByte(83))
        btn_educational_pending.FlatStyle = FlatStyle.Flat
        btn_educational_pending.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_educational_pending.ForeColor = Color.White
        btn_educational_pending.Image = CType(resources.GetObject("btn_educational_pending.Image"), Image)
        btn_educational_pending.ImageAlign = ContentAlignment.MiddleLeft
        btn_educational_pending.Location = New Point(0, 454)
        btn_educational_pending.Name = "btn_educational_pending"
        btn_educational_pending.Size = New Size(263, 45)
        btn_educational_pending.TabIndex = 19
        btn_educational_pending.Text = "          Pending"
        btn_educational_pending.TextAlign = ContentAlignment.MiddleLeft
        btn_educational_pending.UseVisualStyleBackColor = False
        btn_educational_pending.Visible = False
        ' 
        ' pnl_educational_spacer
        ' 
        pnl_educational_spacer.Dock = DockStyle.Top
        pnl_educational_spacer.Location = New Point(0, 451)
        pnl_educational_spacer.Name = "pnl_educational_spacer"
        pnl_educational_spacer.Size = New Size(263, 3)
        pnl_educational_spacer.TabIndex = 18
        ' 
        ' btn_educational
        ' 
        btn_educational.BackColor = Color.Transparent
        btn_educational.Cursor = Cursors.Hand
        btn_educational.Dock = DockStyle.Top
        btn_educational.FlatAppearance.BorderSize = 0
        btn_educational.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(73), CByte(78), CByte(83))
        btn_educational.FlatStyle = FlatStyle.Flat
        btn_educational.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_educational.ForeColor = Color.White
        btn_educational.Image = CType(resources.GetObject("btn_educational.Image"), Image)
        btn_educational.ImageAlign = ContentAlignment.MiddleLeft
        btn_educational.Location = New Point(0, 406)
        btn_educational.Name = "btn_educational"
        btn_educational.Size = New Size(263, 45)
        btn_educational.TabIndex = 17
        btn_educational.Text = "          Educational"
        btn_educational.TextAlign = ContentAlignment.MiddleLeft
        btn_educational.UseVisualStyleBackColor = False
        ' 
        ' pnl_scan_qr_code_spacer
        ' 
        pnl_scan_qr_code_spacer.Dock = DockStyle.Top
        pnl_scan_qr_code_spacer.Location = New Point(0, 403)
        pnl_scan_qr_code_spacer.Name = "pnl_scan_qr_code_spacer"
        pnl_scan_qr_code_spacer.Size = New Size(263, 3)
        pnl_scan_qr_code_spacer.TabIndex = 16
        ' 
        ' btn_scan_qr_code
        ' 
        btn_scan_qr_code.BackColor = Color.Transparent
        btn_scan_qr_code.Cursor = Cursors.Hand
        btn_scan_qr_code.Dock = DockStyle.Top
        btn_scan_qr_code.FlatAppearance.BorderSize = 0
        btn_scan_qr_code.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(73), CByte(78), CByte(83))
        btn_scan_qr_code.FlatStyle = FlatStyle.Flat
        btn_scan_qr_code.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_scan_qr_code.ForeColor = Color.White
        btn_scan_qr_code.Image = CType(resources.GetObject("btn_scan_qr_code.Image"), Image)
        btn_scan_qr_code.ImageAlign = ContentAlignment.MiddleLeft
        btn_scan_qr_code.Location = New Point(0, 358)
        btn_scan_qr_code.Name = "btn_scan_qr_code"
        btn_scan_qr_code.Size = New Size(263, 45)
        btn_scan_qr_code.TabIndex = 15
        btn_scan_qr_code.Text = "          Scan QR Code"
        btn_scan_qr_code.TextAlign = ContentAlignment.MiddleLeft
        btn_scan_qr_code.UseVisualStyleBackColor = False
        ' 
        ' pnl_dashboard_spacer
        ' 
        pnl_dashboard_spacer.Dock = DockStyle.Top
        pnl_dashboard_spacer.Location = New Point(0, 355)
        pnl_dashboard_spacer.Name = "pnl_dashboard_spacer"
        pnl_dashboard_spacer.Size = New Size(263, 3)
        pnl_dashboard_spacer.TabIndex = 4
        ' 
        ' btn_dashboard
        ' 
        btn_dashboard.BackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btn_dashboard.Cursor = Cursors.Hand
        btn_dashboard.Dock = DockStyle.Top
        btn_dashboard.FlatAppearance.BorderSize = 0
        btn_dashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(73), CByte(78), CByte(83))
        btn_dashboard.FlatStyle = FlatStyle.Flat
        btn_dashboard.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_dashboard.ForeColor = Color.White
        btn_dashboard.Image = CType(resources.GetObject("btn_dashboard.Image"), Image)
        btn_dashboard.ImageAlign = ContentAlignment.MiddleLeft
        btn_dashboard.Location = New Point(0, 310)
        btn_dashboard.Name = "btn_dashboard"
        btn_dashboard.Size = New Size(263, 45)
        btn_dashboard.TabIndex = 3
        btn_dashboard.Text = "          Dashboard"
        btn_dashboard.TextAlign = ContentAlignment.MiddleLeft
        btn_dashboard.UseVisualStyleBackColor = False
        ' 
        ' pnl_spacer
        ' 
        pnl_spacer.BackColor = Color.Transparent
        pnl_spacer.Controls.Add(Panel5)
        pnl_spacer.Dock = DockStyle.Top
        pnl_spacer.Location = New Point(0, 280)
        pnl_spacer.Name = "pnl_spacer"
        pnl_spacer.Size = New Size(263, 30)
        pnl_spacer.TabIndex = 1
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(263, 1)
        Panel5.TabIndex = 0
        ' 
        ' pnl_logo
        ' 
        pnl_logo.BackColor = Color.Transparent
        pnl_logo.BackgroundImage = CType(resources.GetObject("pnl_logo.BackgroundImage"), Image)
        pnl_logo.BackgroundImageLayout = ImageLayout.Center
        pnl_logo.Dock = DockStyle.Top
        pnl_logo.Location = New Point(0, 0)
        pnl_logo.Name = "pnl_logo"
        pnl_logo.Size = New Size(263, 280)
        pnl_logo.TabIndex = 0
        ' 
        ' btn_temp
        ' 
        btn_temp.Location = New Point(355, -62)
        btn_temp.Name = "btn_temp"
        btn_temp.Size = New Size(75, 23)
        btn_temp.TabIndex = 1
        btn_temp.Text = "Button1"
        btn_temp.UseVisualStyleBackColor = True
        ' 
        ' pnl_header
        ' 
        pnl_header.BackColor = Color.White
        pnl_header.Controls.Add(Panel1)
        pnl_header.Controls.Add(btn_account)
        pnl_header.Controls.Add(btn_toggle_sidebar)
        pnl_header.Dock = DockStyle.Top
        pnl_header.Location = New Point(280, 0)
        pnl_header.Name = "pnl_header"
        pnl_header.Size = New Size(1054, 50)
        pnl_header.TabIndex = 2
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(img_user_image)
        Panel1.Cursor = Cursors.Hand
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(853, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(41, 50)
        Panel1.TabIndex = 2
        ' 
        ' img_user_image
        ' 
        img_user_image.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        img_user_image.Cursor = Cursors.Hand
        img_user_image.Image = CType(resources.GetObject("img_user_image.Image"), Image)
        img_user_image.Location = New Point(3, 8)
        img_user_image.Name = "img_user_image"
        img_user_image.Size = New Size(35, 35)
        img_user_image.SizeMode = PictureBoxSizeMode.StretchImage
        img_user_image.TabIndex = 2
        img_user_image.TabStop = False
        ' 
        ' btn_account
        ' 
        btn_account.AutoSize = True
        btn_account.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btn_account.BackColor = Color.Transparent
        btn_account.Cursor = Cursors.Hand
        btn_account.Dock = DockStyle.Right
        btn_account.FlatAppearance.BorderSize = 0
        btn_account.FlatStyle = FlatStyle.Flat
        btn_account.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_account.ForeColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btn_account.Location = New Point(894, 0)
        btn_account.Name = "btn_account"
        btn_account.Size = New Size(160, 50)
        btn_account.TabIndex = 1
        btn_account.Text = "Super Administrator"
        btn_account.TextAlign = ContentAlignment.MiddleLeft
        btn_account.UseVisualStyleBackColor = False
        ' 
        ' btn_toggle_sidebar
        ' 
        btn_toggle_sidebar.Cursor = Cursors.Hand
        btn_toggle_sidebar.Image = CType(resources.GetObject("btn_toggle_sidebar.Image"), Image)
        btn_toggle_sidebar.Location = New Point(16, 13)
        btn_toggle_sidebar.Name = "btn_toggle_sidebar"
        btn_toggle_sidebar.Size = New Size(25, 25)
        btn_toggle_sidebar.SizeMode = PictureBoxSizeMode.StretchImage
        btn_toggle_sidebar.TabIndex = 0
        btn_toggle_sidebar.TabStop = False
        ' 
        ' pnl_footer
        ' 
        pnl_footer.BackColor = Color.White
        pnl_footer.Controls.Add(Label5)
        pnl_footer.Controls.Add(Label4)
        pnl_footer.Controls.Add(Label3)
        pnl_footer.Controls.Add(Label2)
        pnl_footer.Controls.Add(Label1)
        pnl_footer.Dock = DockStyle.Bottom
        pnl_footer.Location = New Point(280, 711)
        pnl_footer.Name = "pnl_footer"
        pnl_footer.Size = New Size(1054, 50)
        pnl_footer.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(134), CByte(144), CByte(153))
        Label5.Location = New Point(998, 15)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 20)
        Label5.TabIndex = 4
        Label5.Text = "1.0.0"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(134), CByte(144), CByte(153))
        Label4.Location = New Point(932, 15)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 20)
        Label4.TabIndex = 3
        Label4.Text = "Version"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(134), CByte(144), CByte(153))
        Label3.Location = New Point(489, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 20)
        Label3.TabIndex = 2
        Label3.Text = "All rights reserved."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        Label2.Location = New Point(149, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(344, 20)
        Label2.TabIndex = 1
        Label2.Text = "Student Assistance Beneficiaries System."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(134), CByte(144), CByte(153))
        Label1.Location = New Point(6, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 20)
        Label1.TabIndex = 0
        Label1.Text = "Copyright © 2023"
        ' 
        ' pnl_body
        ' 
        pnl_body.BackColor = Color.Transparent
        pnl_body.Controls.Add(Dashboard)
        pnl_body.Controls.Add(pnl_account_details)
        pnl_body.Controls.Add(Scan_QR_Code)
        pnl_body.Controls.Add(img_loading)
        pnl_body.Controls.Add(Pending)
        pnl_body.Controls.Add(Approved)
        pnl_body.Controls.Add(Rejected)
        pnl_body.Dock = DockStyle.Fill
        pnl_body.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        pnl_body.Location = New Point(280, 50)
        pnl_body.Name = "pnl_body"
        pnl_body.Size = New Size(1054, 661)
        pnl_body.TabIndex = 4
        ' 
        ' Dashboard
        ' 
        Dashboard.BackColor = Color.FromArgb(CByte(244), CByte(246), CByte(249))
        Dashboard.Dock = DockStyle.Fill
        Dashboard.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Dashboard.Location = New Point(0, 0)
        Dashboard.Name = "Dashboard"
        Dashboard.Size = New Size(1054, 661)
        Dashboard.TabIndex = 1
        ' 
        ' pnl_account_details
        ' 
        pnl_account_details.BackColor = Color.White
        pnl_account_details.Controls.Add(btn_logout_2)
        pnl_account_details.Controls.Add(btn_developers)
        pnl_account_details.Controls.Add(btn_account_settings)
        pnl_account_details.Location = New Point(894, 6)
        pnl_account_details.Name = "pnl_account_details"
        pnl_account_details.Size = New Size(157, 108)
        pnl_account_details.TabIndex = 0
        pnl_account_details.Visible = False
        ' 
        ' btn_logout_2
        ' 
        btn_logout_2.Cursor = Cursors.Hand
        btn_logout_2.Dock = DockStyle.Top
        btn_logout_2.FlatAppearance.BorderSize = 0
        btn_logout_2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btn_logout_2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(244), CByte(246), CByte(249))
        btn_logout_2.FlatStyle = FlatStyle.Flat
        btn_logout_2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_logout_2.Image = CType(resources.GetObject("btn_logout_2.Image"), Image)
        btn_logout_2.ImageAlign = ContentAlignment.MiddleLeft
        btn_logout_2.Location = New Point(0, 70)
        btn_logout_2.Name = "btn_logout_2"
        btn_logout_2.Size = New Size(157, 35)
        btn_logout_2.TabIndex = 2
        btn_logout_2.Text = "          Logout"
        btn_logout_2.TextAlign = ContentAlignment.MiddleLeft
        btn_logout_2.UseVisualStyleBackColor = True
        ' 
        ' btn_developers
        ' 
        btn_developers.Cursor = Cursors.Hand
        btn_developers.Dock = DockStyle.Top
        btn_developers.FlatAppearance.BorderSize = 0
        btn_developers.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btn_developers.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(244), CByte(246), CByte(249))
        btn_developers.FlatStyle = FlatStyle.Flat
        btn_developers.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_developers.Image = CType(resources.GetObject("btn_developers.Image"), Image)
        btn_developers.ImageAlign = ContentAlignment.MiddleLeft
        btn_developers.Location = New Point(0, 35)
        btn_developers.Name = "btn_developers"
        btn_developers.Size = New Size(157, 35)
        btn_developers.TabIndex = 1
        btn_developers.Text = "          Developers"
        btn_developers.TextAlign = ContentAlignment.MiddleLeft
        btn_developers.UseVisualStyleBackColor = True
        ' 
        ' btn_account_settings
        ' 
        btn_account_settings.Cursor = Cursors.Hand
        btn_account_settings.Dock = DockStyle.Top
        btn_account_settings.FlatAppearance.BorderSize = 0
        btn_account_settings.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btn_account_settings.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(244), CByte(246), CByte(249))
        btn_account_settings.FlatStyle = FlatStyle.Flat
        btn_account_settings.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_account_settings.Image = CType(resources.GetObject("btn_account_settings.Image"), Image)
        btn_account_settings.ImageAlign = ContentAlignment.MiddleLeft
        btn_account_settings.Location = New Point(0, 0)
        btn_account_settings.Name = "btn_account_settings"
        btn_account_settings.Size = New Size(157, 35)
        btn_account_settings.TabIndex = 0
        btn_account_settings.Text = "          Account"
        btn_account_settings.TextAlign = ContentAlignment.MiddleLeft
        btn_account_settings.UseVisualStyleBackColor = True
        ' 
        ' Scan_QR_Code
        ' 
        Scan_QR_Code.BackColor = Color.FromArgb(CByte(244), CByte(246), CByte(249))
        Scan_QR_Code.Dock = DockStyle.Fill
        Scan_QR_Code.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Scan_QR_Code.Location = New Point(0, 0)
        Scan_QR_Code.Name = "Scan_QR_Code"
        Scan_QR_Code.Size = New Size(1054, 661)
        Scan_QR_Code.TabIndex = 0
        Scan_QR_Code.Visible = False
        ' 
        ' img_loading
        ' 
        img_loading.Dock = DockStyle.Fill
        img_loading.Image = CType(resources.GetObject("img_loading.Image"), Image)
        img_loading.Location = New Point(0, 0)
        img_loading.Name = "img_loading"
        img_loading.Size = New Size(1054, 661)
        img_loading.SizeMode = PictureBoxSizeMode.CenterImage
        img_loading.TabIndex = 2
        img_loading.TabStop = False
        ' 
        ' Pending
        ' 
        Pending.BackColor = Color.FromArgb(CByte(244), CByte(246), CByte(249))
        Pending.Dock = DockStyle.Fill
        Pending.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Pending.Location = New Point(0, 0)
        Pending.Name = "Pending"
        Pending.Size = New Size(1054, 661)
        Pending.TabIndex = 0
        ' 
        ' Approved
        ' 
        Approved.BackColor = Color.FromArgb(CByte(244), CByte(246), CByte(249))
        Approved.Dock = DockStyle.Fill
        Approved.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Approved.Location = New Point(0, 0)
        Approved.Name = "Approved"
        Approved.Size = New Size(1054, 661)
        Approved.TabIndex = 0
        ' 
        ' Rejected
        ' 
        Rejected.BackColor = Color.FromArgb(CByte(244), CByte(246), CByte(249))
        Rejected.Dock = DockStyle.Fill
        Rejected.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Rejected.Location = New Point(0, 0)
        Rejected.Name = "Rejected"
        Rejected.Size = New Size(1054, 661)
        Rejected.TabIndex = 0
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 500
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(246), CByte(249))
        ClientSize = New Size(1334, 761)
        Controls.Add(pnl_body)
        Controls.Add(pnl_footer)
        Controls.Add(pnl_header)
        Controls.Add(btn_temp)
        Controls.Add(pnl_sidebar)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(1350, 800)
        Name = "Main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        WindowState = FormWindowState.Maximized
        pnl_sidebar.ResumeLayout(False)
        pnl_spacer.ResumeLayout(False)
        pnl_header.ResumeLayout(False)
        pnl_header.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(img_user_image, ComponentModel.ISupportInitialize).EndInit()
        CType(btn_toggle_sidebar, ComponentModel.ISupportInitialize).EndInit()
        pnl_footer.ResumeLayout(False)
        pnl_footer.PerformLayout()
        pnl_body.ResumeLayout(False)
        pnl_account_details.ResumeLayout(False)
        CType(img_loading, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnl_sidebar As Panel
    Friend WithEvents pnl_logo As Panel
    Friend WithEvents pnl_spacer As Panel
    Friend WithEvents btn_dashboard As Button
    Friend WithEvents btn_temp As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents pnl_educational_spacer As Panel
    Friend WithEvents btn_educational As Button
    Friend WithEvents pnl_scan_qr_code_spacer As Panel
    Friend WithEvents btn_scan_qr_code As Button
    Friend WithEvents pnl_dashboard_spacer As Panel
    Friend WithEvents btn_logout As Button
    Friend WithEvents pnl_scholarship_spacer_3 As Panel
    Friend WithEvents btn_scholarship_rejected As Button
    Friend WithEvents pnl_scholarship_spacer_2 As Panel
    Friend WithEvents btn_scholarship_approved As Button
    Friend WithEvents pnl_scholarship_spacer_1 As Panel
    Friend WithEvents btn_scholarship_pending As Button
    Friend WithEvents pnl_scholarship_spacer As Panel
    Friend WithEvents btn_scholarship As Button
    Friend WithEvents pnl_educational_spacer_3 As Panel
    Friend WithEvents btn_educational_rejected As Button
    Friend WithEvents pnl_educational_spacer_2 As Panel
    Friend WithEvents btn_educational_approved As Button
    Friend WithEvents pnl_educational_spacer_1 As Panel
    Friend WithEvents btn_educational_pending As Button
    Friend WithEvents pnl_header As Panel
    Friend WithEvents pnl_footer As Panel
    Friend WithEvents pnl_body As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_toggle_sidebar As PictureBox
    Friend WithEvents btn_account As Button
    Friend WithEvents img_user_image As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnl_account_details As Panel
    Friend WithEvents btn_account_settings As Button
    Friend WithEvents btn_logout_2 As Button
    Friend WithEvents btn_developers As Button
    Friend WithEvents Dashboard As Dashboard
    Friend WithEvents Scan_QR_Code As Scan_QR_Code
    Friend WithEvents img_loading As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Pending As Pending
    Friend WithEvents Approved As Approved
    Friend WithEvents Rejected As Rejected
End Class
