<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Label2 = New Label()
        txt_search = New TextBox()
        listview_data = New ListView()
        dashboard_primary_key = New ColumnHeader()
        dashboard_student_primary_key = New ColumnHeader()
        dashboard_date = New ColumnHeader()
        dashboard_time = New ColumnHeader()
        dashboard_student_name = New ColumnHeader()
        dashboard_event = New ColumnHeader()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1054, 75)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(15, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 31)
        Label1.TabIndex = 0
        Label1.Text = "Dashboard"
        ' 
        ' Panel2
        ' 
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 75)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(15, 586)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Right
        Panel3.Location = New Point(1039, 75)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(15, 586)
        Panel3.TabIndex = 2
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
        Panel4.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(723, 15)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 1
        Label2.Text = "Search:"
        ' 
        ' txt_search
        ' 
        txt_search.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txt_search.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txt_search.Location = New Point(793, 12)
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(225, 26)
        txt_search.TabIndex = 0
        ' 
        ' listview_data
        ' 
        listview_data.BorderStyle = BorderStyle.None
        listview_data.Columns.AddRange(New ColumnHeader() {dashboard_primary_key, dashboard_student_primary_key, dashboard_date, dashboard_time, dashboard_student_name, dashboard_event})
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
        listview_data.TabIndex = 5
        listview_data.UseCompatibleStateImageBehavior = False
        listview_data.View = View.Details
        ' 
        ' dashboard_primary_key
        ' 
        dashboard_primary_key.Text = ""
        dashboard_primary_key.Width = 0
        ' 
        ' dashboard_student_primary_key
        ' 
        dashboard_student_primary_key.Text = ""
        dashboard_student_primary_key.Width = 0
        ' 
        ' dashboard_date
        ' 
        dashboard_date.Text = "Date"
        ' 
        ' dashboard_time
        ' 
        dashboard_time.Text = "Time"
        ' 
        ' dashboard_student_name
        ' 
        dashboard_student_name.Text = "Student Name"
        ' 
        ' dashboard_event
        ' 
        dashboard_event.Text = "Transaction Event"
        ' 
        ' Dashboard
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
        Name = "Dashboard"
        Size = New Size(1054, 661)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents listview_data As ListView
    Friend WithEvents dashboard_primary_key As ColumnHeader
    Friend WithEvents dashboard_student_primary_key As ColumnHeader
    Friend WithEvents dashboard_date As ColumnHeader
    Friend WithEvents dashboard_time As ColumnHeader
    Friend WithEvents dashboard_student_name As ColumnHeader
    Friend WithEvents dashboard_event As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_search As TextBox
End Class
