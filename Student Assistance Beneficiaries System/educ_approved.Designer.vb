<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class educ_approved
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
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        ListView1 = New ListView()
        approved_primary_key = New ColumnHeader()
        approved_admin_primary_key = New ColumnHeader()
        approved_student_primary_key = New ColumnHeader()
        approved_date = New ColumnHeader()
        approved_time = New ColumnHeader()
        approved_category = New ColumnHeader()
        approved_progress = New ColumnHeader()
        approved_status = New ColumnHeader()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(874, 97)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(167, 23)
        TextBox1.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(815, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 16)
        Label2.TabIndex = 7
        Label2.Text = "Search:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(3, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(337, 37)
        Label1.TabIndex = 6
        Label1.Text = "Approved Applications"
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {approved_primary_key, approved_admin_primary_key, approved_student_primary_key, approved_date, approved_time, approved_category, approved_progress, approved_status})
        ListView1.GridLines = True
        ListView1.Location = New Point(0, 140)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1051, 521)
        ListView1.TabIndex = 9
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' approved_primary_key
        ' 
        approved_primary_key.Text = "primary"
        approved_primary_key.Width = 0
        ' 
        ' approved_admin_primary_key
        ' 
        approved_admin_primary_key.Width = 0
        ' 
        ' approved_student_primary_key
        ' 
        approved_student_primary_key.Width = 0
        ' 
        ' approved_date
        ' 
        approved_date.Text = "Date"
        approved_date.Width = 210
        ' 
        ' approved_time
        ' 
        approved_time.Text = "Time"
        approved_time.Width = 210
        ' 
        ' approved_category
        ' 
        approved_category.Text = "Category"
        approved_category.Width = 210
        ' 
        ' approved_progress
        ' 
        approved_progress.Text = "Progress"
        approved_progress.Width = 210
        ' 
        ' approved_status
        ' 
        approved_status.Text = "Status"
        approved_status.Width = 210
        ' 
        ' educ_approved
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(ListView1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "educ_approved"
        Size = New Size(1054, 661)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents approved_primary_key As ColumnHeader
    Friend WithEvents approved_admin_primary_key As ColumnHeader
    Friend WithEvents approved_student_primary_key As ColumnHeader
    Friend WithEvents approved_date As ColumnHeader
    Friend WithEvents approved_time As ColumnHeader
    Friend WithEvents approved_category As ColumnHeader
    Friend WithEvents approved_progress As ColumnHeader
    Friend WithEvents approved_status As ColumnHeader
End Class
