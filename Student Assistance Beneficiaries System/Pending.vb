Public Class Pending
    Private Sub listview_data_SizeChanged(sender As Object, e As EventArgs) Handles listview_data.SizeChanged
        Dim listview_width As Integer = listview_data.Width

        listview_data.Columns(3).Width = listview_width * 0.5
        listview_data.Columns(4).Width = listview_width * 0.25
        listview_data.Columns(5).Width = listview_width * 0.55
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Main.Mouse_Click(Main.btn_dashboard)
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel3.Click, Panel2.Click, Panel1.Click, Label4.Click, Label1.Click, Panel4.Click, Label2.Click, txt_search.Click, listview_data.Click
        With Main
            .pnl_account_details_visible = False
            .pnl_account_details.Visible = False
        End With
    End Sub

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel3.MouseEnter, Panel2.MouseEnter, Panel1.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label1.MouseEnter, Panel4.MouseEnter, Label2.MouseEnter, txt_search.MouseEnter, listview_data.MouseEnter
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
End Class
