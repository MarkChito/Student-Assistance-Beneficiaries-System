<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scholar_rejectedvb
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
        ListView1 = New ListView()
        scholar_rejected_primary_key = New ColumnHeader()
        scholar_rejected_admin_primary_key = New ColumnHeader()
        scholar_rejected_student_primary_key = New ColumnHeader()
        scholar_rejected_date = New ColumnHeader()
        scholar_rejected_time = New ColumnHeader()
        scholar_rejected_category = New ColumnHeader()
        scholar_rejected_progress = New ColumnHeader()
        scholar_rejected_status = New ColumnHeader()
        Label2 = New Label()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(0), CByte(15), CByte(255), CByte(255))
        Label1.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(3, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(323, 37)
        Label1.TabIndex = 8
        Label1.Text = "Rejected Applications"
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {scholar_rejected_primary_key, scholar_rejected_admin_primary_key, scholar_rejected_student_primary_key, scholar_rejected_date, scholar_rejected_time, scholar_rejected_category, scholar_rejected_progress, scholar_rejected_status})
        ListView1.GridLines = True
        ListView1.Location = New Point(3, 137)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1051, 521)
        ListView1.TabIndex = 12
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' scholar_rejected_primary_key
        ' 
        scholar_rejected_primary_key.Text = "primary"
        scholar_rejected_primary_key.Width = 0
        ' 
        ' scholar_rejected_admin_primary_key
        ' 
        scholar_rejected_admin_primary_key.Width = 0
        ' 
        ' scholar_rejected_student_primary_key
        ' 
        scholar_rejected_student_primary_key.Width = 0
        ' 
        ' scholar_rejected_date
        ' 
        scholar_rejected_date.Text = "Date"
        scholar_rejected_date.Width = 210
        ' 
        ' scholar_rejected_time
        ' 
        scholar_rejected_time.Text = "Time"
        scholar_rejected_time.Width = 210
        ' 
        ' scholar_rejected_category
        ' 
        scholar_rejected_category.Text = "Category"
        scholar_rejected_category.Width = 210
        ' 
        ' scholar_rejected_progress
        ' 
        scholar_rejected_progress.Text = "Progress"
        scholar_rejected_progress.Width = 210
        ' 
        ' scholar_rejected_status
        ' 
        scholar_rejected_status.Text = "Status"
        scholar_rejected_status.Width = 210
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(825, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 16)
        Label2.TabIndex = 13
        Label2.Text = "Search:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(884, 96)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(167, 23)
        TextBox1.TabIndex = 14
        ' 
        ' scholar_rejectedvb
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(ListView1)
        Controls.Add(Label1)
        Name = "scholar_rejectedvb"
        Size = New Size(1054, 661)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents scholar_rejected_primary_key As ColumnHeader
    Friend WithEvents scholar_rejected_admin_primary_key As ColumnHeader
    Friend WithEvents scholar_rejected_student_primary_key As ColumnHeader
    Friend WithEvents scholar_rejected_date As ColumnHeader
    Friend WithEvents scholar_rejected_time As ColumnHeader
    Friend WithEvents scholar_rejected_category As ColumnHeader
    Friend WithEvents scholar_rejected_progress As ColumnHeader
    Friend WithEvents scholar_rejected_status As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
