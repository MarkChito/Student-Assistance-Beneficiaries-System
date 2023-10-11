<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scan_QR_Code
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Scan_QR_Code))
        Panel3 = New Panel()
        Panel2 = New Panel()
        Panel1 = New Panel()
        btn_scan_qr_code = New Button()
        Panel4 = New Panel()
        Label1 = New Label()
        pnl_body = New Panel()
        Scan_QR_Code_Message = New Panel()
        lbl_message = New Label()
        Scan_QR_Code_Details = New Scan_QR_Code_Details()
        Panel1.SuspendLayout()
        pnl_body.SuspendLayout()
        Scan_QR_Code_Message.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(1039, 75)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(15, 586)
        Panel3.TabIndex = 5
        ' 
        ' Panel2
        ' 
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 75)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(15, 586)
        Panel2.TabIndex = 4
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btn_scan_qr_code)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1054, 75)
        Panel1.TabIndex = 3
        ' 
        ' btn_scan_qr_code
        ' 
        btn_scan_qr_code.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_scan_qr_code.BackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        btn_scan_qr_code.Cursor = Cursors.Hand
        btn_scan_qr_code.FlatAppearance.BorderSize = 0
        btn_scan_qr_code.FlatStyle = FlatStyle.Flat
        btn_scan_qr_code.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_scan_qr_code.ForeColor = Color.White
        btn_scan_qr_code.Image = CType(resources.GetObject("btn_scan_qr_code.Image"), Image)
        btn_scan_qr_code.ImageAlign = ContentAlignment.MiddleLeft
        btn_scan_qr_code.Location = New Point(876, 17)
        btn_scan_qr_code.Name = "btn_scan_qr_code"
        btn_scan_qr_code.Size = New Size(157, 40)
        btn_scan_qr_code.TabIndex = 7
        btn_scan_qr_code.Text = "        &Scan QR Code"
        btn_scan_qr_code.TextAlign = ContentAlignment.MiddleLeft
        btn_scan_qr_code.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Right
        Panel4.Location = New Point(1039, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(15, 75)
        Panel4.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(15, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(208, 31)
        Label1.TabIndex = 0
        Label1.Text = "Scan QR Code"
        ' 
        ' pnl_body
        ' 
        pnl_body.Controls.Add(Scan_QR_Code_Message)
        pnl_body.Controls.Add(Scan_QR_Code_Details)
        pnl_body.Dock = DockStyle.Fill
        pnl_body.Location = New Point(15, 75)
        pnl_body.Name = "pnl_body"
        pnl_body.Size = New Size(1024, 586)
        pnl_body.TabIndex = 6
        ' 
        ' Scan_QR_Code_Message
        ' 
        Scan_QR_Code_Message.Controls.Add(lbl_message)
        Scan_QR_Code_Message.Dock = DockStyle.Fill
        Scan_QR_Code_Message.Location = New Point(0, 0)
        Scan_QR_Code_Message.Name = "Scan_QR_Code_Message"
        Scan_QR_Code_Message.Size = New Size(1024, 586)
        Scan_QR_Code_Message.TabIndex = 1
        ' 
        ' lbl_message
        ' 
        lbl_message.AutoSize = True
        lbl_message.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_message.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        lbl_message.Location = New Point(367, 275)
        lbl_message.Name = "lbl_message"
        lbl_message.Size = New Size(291, 37)
        lbl_message.TabIndex = 0
        lbl_message.Text = "No Available Data"
        ' 
        ' Scan_QR_Code_Details
        ' 
        Scan_QR_Code_Details.BackColor = Color.FromArgb(CByte(244), CByte(246), CByte(249))
        Scan_QR_Code_Details.Dock = DockStyle.Fill
        Scan_QR_Code_Details.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Scan_QR_Code_Details.Location = New Point(0, 0)
        Scan_QR_Code_Details.Name = "Scan_QR_Code_Details"
        Scan_QR_Code_Details.Size = New Size(1024, 586)
        Scan_QR_Code_Details.TabIndex = 2
        ' 
        ' Scan_QR_Code
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(246), CByte(249))
        Controls.Add(pnl_body)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "Scan_QR_Code"
        Size = New Size(1054, 661)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        pnl_body.ResumeLayout(False)
        Scan_QR_Code_Message.ResumeLayout(False)
        Scan_QR_Code_Message.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnl_body As Panel
    Friend WithEvents lbl_message As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn_scan_qr_code As Button
    Friend WithEvents Scan_QR_Code_Message As Panel
    Friend WithEvents Scan_QR_Code_Details As Scan_QR_Code_Details
End Class
