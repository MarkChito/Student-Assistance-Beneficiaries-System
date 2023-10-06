<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class educ_rejected
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
        TextBox1 = New TextBox()
        ListView1 = New ListView()
        rejected_primary_key = New ColumnHeader()
        rejected_admin_primary_key = New ColumnHeader()
        rejected_student_primary_key = New ColumnHeader()
        rejected_date = New ColumnHeader()
        rejected_time = New ColumnHeader()
        rejected_category = New ColumnHeader()
        rejected_progress = New ColumnHeader()
        rejected_status = New ColumnHeader()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(0), CByte(15), CByte(255), CByte(255))
        Label1.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(3, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(323, 37)
        Label1.TabIndex = 7
        Label1.Text = "Rejected Applications"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(825, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 16)
        Label2.TabIndex = 9
        Label2.Text = "Search:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(884, 92)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(167, 23)
        TextBox1.TabIndex = 10
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {rejected_primary_key, rejected_admin_primary_key, rejected_student_primary_key, rejected_date, rejected_time, rejected_category, rejected_progress, rejected_status})
        ListView1.GridLines = True
        ListView1.Location = New Point(0, 140)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1051, 521)
        ListView1.TabIndex = 11
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' rejected_primary_key
        ' 
        rejected_primary_key.Text = "primary"
        rejected_primary_key.Width = 0
        ' 
        ' rejected_admin_primary_key
        ' 
        rejected_admin_primary_key.Width = 0
        ' 
        ' rejected_student_primary_key
        ' 
        rejected_student_primary_key.Width = 0
        ' 
        ' rejected_date
        ' 
        rejected_date.Text = "Date"
        rejected_date.Width = 210
        ' 
        ' rejected_time
        ' 
        rejected_time.Text = "Time"
        rejected_time.Width = 210
        ' 
        ' rejected_category
        ' 
        rejected_category.Text = "Category"
        rejected_category.Width = 210
        ' 
        ' rejected_progress
        ' 
        rejected_progress.Text = "Progress"
        rejected_progress.Width = 210
        ' 
        ' rejected_status
        ' 
        rejected_status.Text = "Status"
        rejected_status.Width = 210
        ' 
        ' educ_rejected
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(ListView1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "educ_rejected"
        Size = New Size(1054, 661)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents rejected_primary_key As ColumnHeader
    Friend WithEvents rejected_admin_primary_key As ColumnHeader
    Friend WithEvents rejected_student_primary_key As ColumnHeader
    Friend WithEvents rejected_date As ColumnHeader
    Friend WithEvents rejected_time As ColumnHeader
    Friend WithEvents rejected_category As ColumnHeader
    Friend WithEvents rejected_progress As ColumnHeader
    Friend WithEvents rejected_status As ColumnHeader
End Class
