<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scholar_approved
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
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        ListView1 = New ListView()
        scholar_approved_primary_key = New ColumnHeader()
        scholar_approved_admin_primary_key = New ColumnHeader()
        scholar_approved_student_primary_key = New ColumnHeader()
        scholar_approved_date = New ColumnHeader()
        scholar_approved__time = New ColumnHeader()
        scholar_approved_category = New ColumnHeader()
        scholar_approved_progress = New ColumnHeader()
        scholar_approved_status = New ColumnHeader()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(3, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(337, 37)
        Label1.TabIndex = 7
        Label1.Text = "Approved Applications"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(884, 109)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(167, 23)
        TextBox1.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(825, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 16)
        Label2.TabIndex = 10
        Label2.Text = "Search:"
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {scholar_approved_primary_key, scholar_approved_admin_primary_key, scholar_approved_student_primary_key, scholar_approved_date, scholar_approved__time, scholar_approved_category, scholar_approved_progress, scholar_approved_status})
        ListView1.GridLines = True
        ListView1.Location = New Point(0, 140)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1051, 521)
        ListView1.TabIndex = 12
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' scholar_approved_primary_key
        ' 
        scholar_approved_primary_key.Text = "primary"
        scholar_approved_primary_key.Width = 0
        ' 
        ' scholar_approved_admin_primary_key
        ' 
        scholar_approved_admin_primary_key.Width = 0
        ' 
        ' scholar_approved_student_primary_key
        ' 
        scholar_approved_student_primary_key.Width = 0
        ' 
        ' scholar_approved_date
        ' 
        scholar_approved_date.Text = "Date"
        scholar_approved_date.Width = 210
        ' 
        ' scholar_approved__time
        ' 
        scholar_approved__time.Text = "Time"
        scholar_approved__time.Width = 210
        ' 
        ' scholar_approved_category
        ' 
        scholar_approved_category.Text = "Category"
        scholar_approved_category.Width = 210
        ' 
        ' scholar_approved_progress
        ' 
        scholar_approved_progress.Text = "Progress"
        scholar_approved_progress.Width = 210
        ' 
        ' scholar_approved_status
        ' 
        scholar_approved_status.Text = "Status"
        scholar_approved_status.Width = 210
        ' 
        ' scholar_approved
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(ListView1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "scholar_approved"
        Size = New Size(1054, 661)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents scholar_approved_primary_key As ColumnHeader
    Friend WithEvents scholar_approved_admin_primary_key As ColumnHeader
    Friend WithEvents scholar_approved_student_primary_key As ColumnHeader
    Friend WithEvents scholar_approved_date As ColumnHeader
    Friend WithEvents scholar_approved__time As ColumnHeader
    Friend WithEvents scholar_approved_category As ColumnHeader
    Friend WithEvents scholar_approved_progress As ColumnHeader
    Friend WithEvents scholar_approved_status As ColumnHeader
End Class
