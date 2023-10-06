<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scholar_pending
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
        scholar_pending_primary_key = New ColumnHeader()
        scholar_pending_admin_primary_key = New ColumnHeader()
        scholar_pending_student_primary_key = New ColumnHeader()
        scholar_pending_date = New ColumnHeader()
        scholar_pending_time = New ColumnHeader()
        scholar_pending_category = New ColumnHeader()
        scholar_pending_progress = New ColumnHeader()
        scholar_pending_status = New ColumnHeader()
        Label2 = New Label()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(13, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(317, 37)
        Label1.TabIndex = 2
        Label1.Text = "Pending Applications"
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {scholar_pending_primary_key, scholar_pending_admin_primary_key, scholar_pending_student_primary_key, scholar_pending_date, scholar_pending_time, scholar_pending_category, scholar_pending_progress, scholar_pending_status})
        ListView1.GridLines = True
        ListView1.Location = New Point(0, 140)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1051, 521)
        ListView1.TabIndex = 6
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' scholar_pending_primary_key
        ' 
        scholar_pending_primary_key.Text = "primary"
        scholar_pending_primary_key.Width = 0
        ' 
        ' scholar_pending_admin_primary_key
        ' 
        scholar_pending_admin_primary_key.Width = 0
        ' 
        ' scholar_pending_student_primary_key
        ' 
        scholar_pending_student_primary_key.Width = 0
        ' 
        ' scholar_pending_date
        ' 
        scholar_pending_date.Text = "Date"
        scholar_pending_date.Width = 210
        ' 
        ' scholar_pending_time
        ' 
        scholar_pending_time.Text = "Time"
        scholar_pending_time.Width = 210
        ' 
        ' scholar_pending_category
        ' 
        scholar_pending_category.Text = "Category"
        scholar_pending_category.Width = 210
        ' 
        ' scholar_pending_progress
        ' 
        scholar_pending_progress.Text = "Progress"
        scholar_pending_progress.Width = 210
        ' 
        ' scholar_pending_status
        ' 
        scholar_pending_status.Text = "Status"
        scholar_pending_status.Width = 210
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(825, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 16)
        Label2.TabIndex = 5
        Label2.Text = "Search:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(884, 98)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(167, 23)
        TextBox1.TabIndex = 7
        ' 
        ' scholar_pending
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(TextBox1)
        Controls.Add(ListView1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "scholar_pending"
        Size = New Size(1054, 661)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents scholar_pending_primary_key As ColumnHeader
    Friend WithEvents scholar_pending_admin_primary_key As ColumnHeader
    Friend WithEvents scholar_pending_student_primary_key As ColumnHeader
    Friend WithEvents scholar_pending_date As ColumnHeader
    Friend WithEvents scholar_pending_time As ColumnHeader
    Friend WithEvents scholar_pending_category As ColumnHeader
    Friend WithEvents scholar_pending_progress As ColumnHeader
    Friend WithEvents scholar_pending_status As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
