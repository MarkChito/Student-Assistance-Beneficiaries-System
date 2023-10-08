<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pending
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Panel1 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        Panel4 = New Panel()
        Label2 = New Label()
        txt_search = New TextBox()
        listview_data = New ListView()
        educational_pending_primary_key = New ColumnHeader()
        educational_pending_admin_primary_key = New ColumnHeader()
        educational_pending_student_primary_key = New ColumnHeader()
        educational_pending_student_name = New ColumnHeader()
        educational_pending_date = New ColumnHeader()
        educational_pending_time = New ColumnHeader()
        educational_pending_category = New ColumnHeader()
        educational_pending_progress = New ColumnHeader()
        educational_pending_status = New ColumnHeader()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
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
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1054, 75)
        Panel1.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        Label4.Location = New Point(874, 27)
        Label4.Name = "Label4"
        Label4.Size = New Size(165, 20)
        Label4.TabIndex = 2
        Label4.Text = "/ Pending Applications"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Cursor = Cursors.Hand
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(123), CByte(255))
        Label3.Location = New Point(789, 27)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 20)
        Label3.TabIndex = 1
        Label3.Text = "Dashboard"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(15, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(287, 31)
        Label1.TabIndex = 0
        Label1.Text = "Pending Applications"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(txt_search)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(15, 75)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1024, 50)
        Panel4.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(723, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 3
        Label2.Text = "Search:"
        ' 
        ' txt_search
        ' 
        txt_search.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txt_search.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_search.Location = New Point(793, 12)
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(225, 26)
        txt_search.TabIndex = 2
        ' 
        ' listview_data
        ' 
        listview_data.BorderStyle = BorderStyle.None
        listview_data.Columns.AddRange(New ColumnHeader() {educational_pending_primary_key, educational_pending_admin_primary_key, educational_pending_student_primary_key, educational_pending_student_name, educational_pending_date, educational_pending_time, educational_pending_category, educational_pending_progress, educational_pending_status})
        listview_data.Dock = DockStyle.Fill
        listview_data.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        listview_data.FullRowSelect = True
        listview_data.GridLines = True
        listview_data.HeaderStyle = ColumnHeaderStyle.Nonclickable
        listview_data.LabelWrap = False
        listview_data.Location = New Point(15, 125)
        listview_data.MultiSelect = False
        listview_data.Name = "listview_data"
        listview_data.ShowItemToolTips = True
        listview_data.Size = New Size(1024, 536)
        listview_data.TabIndex = 7
        listview_data.UseCompatibleStateImageBehavior = False
        listview_data.View = View.Details
        ' 
        ' educational_pending_primary_key
        ' 
        educational_pending_primary_key.Text = ""
        educational_pending_primary_key.Width = 0
        ' 
        ' educational_pending_admin_primary_key
        ' 
        educational_pending_admin_primary_key.Text = ""
        educational_pending_admin_primary_key.Width = 0
        ' 
        ' educational_pending_student_primary_key
        ' 
        educational_pending_student_primary_key.Text = ""
        educational_pending_student_primary_key.Width = 0
        ' 
        ' educational_pending_student_name
        ' 
        educational_pending_student_name.Text = "Student Name"
        ' 
        ' educational_pending_date
        ' 
        educational_pending_date.Text = "Date Competed"
        ' 
        ' educational_pending_time
        ' 
        educational_pending_time.Text = "Time Completed"
        ' 
        ' educational_pending_category
        ' 
        educational_pending_category.Text = ""
        educational_pending_category.Width = 0
        ' 
        ' educational_pending_progress
        ' 
        educational_pending_progress.Text = ""
        educational_pending_progress.Width = 0
        ' 
        ' educational_pending_status
        ' 
        educational_pending_status.Text = ""
        educational_pending_status.Width = 0
        ' 
        ' Pending
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(246), CByte(249))
        Controls.Add(listview_data)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "Pending"
        Size = New Size(1054, 661)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents listview_data As ListView
    Friend WithEvents educational_pending_primary_key As ColumnHeader
    Friend WithEvents educational_pending_admin_primary_key As ColumnHeader
    Friend WithEvents educational_pending_student_primary_key As ColumnHeader
    Friend WithEvents educational_pending_student_name As ColumnHeader
    Friend WithEvents educational_pending_date As ColumnHeader
    Friend WithEvents educational_pending_time As ColumnHeader
    Friend WithEvents educational_pending_category As ColumnHeader
    Friend WithEvents educational_pending_progress As ColumnHeader
    Friend WithEvents educational_pending_status As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
