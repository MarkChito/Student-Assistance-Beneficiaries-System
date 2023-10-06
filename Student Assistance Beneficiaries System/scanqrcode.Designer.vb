<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scanqrcode
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(scanqrcode))
        Panel1 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Dashboard1 = New Dashboard()
        S = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Dashboard1)
        Panel1.Controls.Add(S)
        Panel1.ForeColor = Color.Black
        Panel1.Location = New Point(0, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1054, 661)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.AppWorkspace
        Label2.Location = New Point(387, 324)
        Label2.Name = "Label2"
        Label2.Size = New Size(274, 37)
        Label2.TabIndex = 3
        Label2.Text = "No Available Data"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(18, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(235, 39)
        Label1.TabIndex = 2
        Label1.Text = "Scan Qr Code"
        ' 
        ' Dashboard1
        ' 
        Dashboard1.Location = New Point(972, 416)
        Dashboard1.Name = "Dashboard1"
        Dashboard1.Size = New Size(12, 32)
        Dashboard1.TabIndex = 1
        ' 
        ' S
        ' 
        S.BackColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        S.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        S.ForeColor = Color.White
        S.Image = CType(resources.GetObject("S.Image"), Image)
        S.ImageAlign = ContentAlignment.MiddleLeft
        S.Location = New Point(894, 23)
        S.Name = "S"
        S.Size = New Size(147, 43)
        S.TabIndex = 0
        S.Text = "    Scan Qr Code"
        S.UseVisualStyleBackColor = False
        ' 
        ' scanqrcode
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Name = "scanqrcode"
        Size = New Size(1054, 661)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents S As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Dashboard1 As Dashboard
    Friend WithEvents Label2 As Label
End Class
