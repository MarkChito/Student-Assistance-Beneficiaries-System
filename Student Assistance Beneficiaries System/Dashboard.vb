Public Class Dashboard
    Private Sub Get_Search_Transactions_Data()
        Database_Open()

        Dim results = Search_Transactions_Data(txt_search.Text)

        listview_data.Items.Clear()

        For Each row As DataRow In results.Rows
            Dim lvi As ListViewItem
            Dim row_2 = Get_User_Name(row("student_primary_key").ToString())

            lvi = listview_data.Items.Add(row("primary_key").ToString())
            lvi.SubItems.Add(row("student_primary_key").ToString())
            lvi.SubItems.Add(row("date").ToString())
            lvi.SubItems.Add(row("time").ToString())
            lvi.SubItems.Add(row_2("name").ToString())
            lvi.SubItems.Add(row("event").ToString())
        Next

        Database_Close()
    End Sub

    Private Sub listview_data_SizeChanged(sender As Object, e As EventArgs) Handles listview_data.SizeChanged
        Dim listview_width As Integer = listview_data.Width

        listview_data.Columns(2).Width = listview_width * 0.15
        listview_data.Columns(3).Width = listview_width * 0.1
        listview_data.Columns(4).Width = listview_width * 0.2
        listview_data.Columns(5).Width = listview_width * 0.55
    End Sub

    Private Sub txt_search_GotFocus(sender As Object, e As EventArgs) Handles txt_search.GotFocus
        With Main
            .pnl_account_details_visible = False
            .pnl_account_details.Visible = False
        End With
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Panel1.Click, Label1.Click, Panel2.Click, Panel3.Click, Panel4.Click, Label2.Click, listview_data.Click
        With Main
            .pnl_account_details_visible = False
            .pnl_account_details.Visible = False
        End With
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter, Label1.MouseEnter, Panel2.MouseEnter, Panel3.MouseEnter, Panel4.MouseEnter, Label2.MouseEnter, txt_search.MouseEnter, listview_data.MouseEnter
        With Main
            If Not .is_sidebar_open Then
                .pnl_sidebar.Width = 80

                .btn_dashboard.ImageAlign = ContentAlignment.MiddleCenter
                .btn_scan_qr_code.ImageAlign = ContentAlignment.MiddleCenter
                .btn_educational.ImageAlign = ContentAlignment.MiddleCenter
                .btn_educational_pending.ImageAlign = ContentAlignment.MiddleCenter
                .btn_educational_approved.ImageAlign = ContentAlignment.MiddleCenter
                .btn_educational_rejected.ImageAlign = ContentAlignment.MiddleCenter
                .btn_scholarship.ImageAlign = ContentAlignment.MiddleCenter
                .btn_scholarship_pending.ImageAlign = ContentAlignment.MiddleCenter
                .btn_scholarship_approved.ImageAlign = ContentAlignment.MiddleCenter
                .btn_scholarship_rejected.ImageAlign = ContentAlignment.MiddleCenter
                .btn_logout.ImageAlign = ContentAlignment.MiddleCenter
            End If
        End With
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If Not String.IsNullOrWhiteSpace(txt_search.Text) Then
            Get_Search_Transactions_Data()
        Else
            Main.Get_All_Transactions_Data()
        End If
    End Sub
End Class
