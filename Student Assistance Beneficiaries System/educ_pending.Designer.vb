<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class educ_pending
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
        Label2 = New Label()
        ListView1 = New ListView()
        pending_primary_key = New ColumnHeader()
        pending_admin_primary_key = New ColumnHeader()
        pending_student_primary_key = New ColumnHeader()
        pending_date = New ColumnHeader()
        pending_time = New ColumnHeader()
        pending_category = New ColumnHeader()
        pending_progress = New ColumnHeader()
        pending_status = New ColumnHeader()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(3, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(317, 37)
        Label1.TabIndex = 1
        Label1.Text = "Pending Applications"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(815, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 16)
        Label2.TabIndex = 3
        Label2.Text = "Search:"
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {pending_primary_key, pending_admin_primary_key, pending_student_primary_key, pending_date, pending_time, pending_category, pending_progress, pending_status})
        ListView1.GridLines = True
        ListView1.Location = New Point(0, 140)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1051, 521)
        ListView1.TabIndex = 4
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' pending_primary_key
        ' 
        pending_primary_key.Text = "primary"
        pending_primary_key.Width = 0
        ' 
        ' pending_admin_primary_key
        ' 
        pending_admin_primary_key.Width = 0
        ' 
        ' pending_student_primary_key
        ' 
        pending_student_primary_key.Width = 0
        ' 
        ' pending_date
        ' 
        pending_date.Text = "Date"
        pending_date.Width = 210
        ' 
        ' pending_time
        ' 
        pending_time.Text = "Time"
        pending_time.Width = 210
        ' 
        ' pending_category
        ' 
        pending_category.Text = "Category"
        pending_category.Width = 210
        ' 
        ' pending_progress
        ' 
        pending_progress.Text = "Progress"
        pending_progress.Width = 210
        ' 
        ' pending_status
        ' 
        pending_status.Text = "Status"
        pending_status.Width = 210
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(874, 94)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(167, 23)
        TextBox1.TabIndex = 5
        ' 
        ' educ_pending
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        Controls.Add(TextBox1)
        Controls.Add(ListView1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "educ_pending"
        Size = New Size(1054, 661)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents pending_primary_key As ColumnHeader
    Friend WithEvents pending_admin_primary_key As ColumnHeader
    Friend WithEvents pending_student_primary_key As ColumnHeader
    Friend WithEvents pending_date As ColumnHeader
    Friend WithEvents pending_time As ColumnHeader
    Friend WithEvents pending_category As ColumnHeader
    Friend WithEvents pending_progress As ColumnHeader
    Friend WithEvents pending_status As ColumnHeader
    Friend WithEvents TextBox1 As TextBox
End Class
