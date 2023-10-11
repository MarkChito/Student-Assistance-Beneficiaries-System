<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scan_QR_Code_Modal
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Scan_QR_Code_Modal))
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        txt_qr_code_data = New TextBox()
        btn_close = New Button()
        img_scan_qr_code = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(img_scan_qr_code, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(400, 45)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(125, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 24)
        Label1.TabIndex = 0
        Label1.Text = "Scan QR Code"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(txt_qr_code_data)
        Panel2.Controls.Add(btn_close)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 455)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(400, 45)
        Panel2.TabIndex = 2
        ' 
        ' txt_qr_code_data
        ' 
        txt_qr_code_data.Location = New Point(19, 67)
        txt_qr_code_data.Name = "txt_qr_code_data"
        txt_qr_code_data.Size = New Size(255, 21)
        txt_qr_code_data.TabIndex = 0
        ' 
        ' btn_close
        ' 
        btn_close.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_close.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btn_close.Cursor = Cursors.Hand
        btn_close.FlatStyle = FlatStyle.Flat
        btn_close.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_close.ForeColor = Color.White
        btn_close.Location = New Point(304, 4)
        btn_close.Name = "btn_close"
        btn_close.Size = New Size(83, 34)
        btn_close.TabIndex = 5
        btn_close.Text = "&Close"
        btn_close.UseVisualStyleBackColor = False
        ' 
        ' img_scan_qr_code
        ' 
        img_scan_qr_code.BackColor = Color.Transparent
        img_scan_qr_code.BorderStyle = BorderStyle.FixedSingle
        img_scan_qr_code.Dock = DockStyle.Fill
        img_scan_qr_code.Image = CType(resources.GetObject("img_scan_qr_code.Image"), Image)
        img_scan_qr_code.Location = New Point(0, 45)
        img_scan_qr_code.Name = "img_scan_qr_code"
        img_scan_qr_code.Size = New Size(400, 410)
        img_scan_qr_code.SizeMode = PictureBoxSizeMode.StretchImage
        img_scan_qr_code.TabIndex = 3
        img_scan_qr_code.TabStop = False
        ' 
        ' Scan_QR_Code_Modal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(400, 500)
        Controls.Add(img_scan_qr_code)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Name = "Scan_QR_Code_Modal"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(img_scan_qr_code, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_qr_code_data As TextBox
    Friend WithEvents btn_close As Button
    Friend WithEvents img_scan_qr_code As PictureBox
End Class
