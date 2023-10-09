Public Class Pending
    Private Sub listview_data_SizeChanged(sender As Object, e As EventArgs) Handles listview_data.SizeChanged
        Dim listview_width As Integer = listview_data.Width

        listview_data.Columns(3).Width = listview_width * 0.5
        listview_data.Columns(4).Width = listview_width * 0.3
        listview_data.Columns(5).Width = listview_width * 0.2
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Main.Mouse_Click(Main.btn_dashboard)
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel3.Click, Panel2.Click, Panel1.Click, Label4.Click, Label1.Click, Panel4.Click, Label2.Click, txt_search.Click
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

    Private Sub listview_data_Click(sender As Object, e As EventArgs) Handles listview_data.Click
        Database_Open()

        Dim results = Get_Student_Data(listview_data.SelectedItems(0).SubItems(2).Text)

        For Each row As DataRow In results.Rows
            With Application_Details
                Dim row_2 = Get_User_RFID_Number(row("login_primary_key").ToString())

                .lbl_student_primary_key.Text = row("login_primary_key").ToString()
                .lbl_admin_primary_key.Text = listview_data.SelectedItems(0).SubItems(1).Text
                .lbl_category.Text = listview_data.SelectedItems(0).SubItems(6).Text
                .lbl_admin_name.Text = Main.btn_account.Text

                If listview_data.SelectedItems(0).SubItems(6).Text = "Educational" Then
                    .lbl_title_report_card.Hide()
                    .lbl_report_card.Hide()
                    .lbl_title_tor.Hide()
                    .lbl_tor.Hide()

                    .pnl_uploaded_documents.Height = 198
                    .Height = 763
                Else
                    .Height = 800
                    .pnl_uploaded_documents.Height = 235

                    .lbl_title_report_card.Show()
                    .lbl_report_card.Show()
                    .lbl_title_tor.Show()
                    .lbl_tor.Show()
                End If

                .lbl_first_name.Text = row("first_name")
                .lbl_middle_name.Text = row("middle_name")
                .lbl_last_name.Text = row("last_name")
                .lbl_student_number.Text = row("student_number")
                .lbl_rfid_number.Text = row_2("rfid_number")
                .lbl_sex.Text = row("sex")

                .lbl_mobile_number.Text = row("mobile_number")
                .lbl_address.Text = row("address")
                .lbl_school_name.Text = row("school_name")
                .lbl_school_address.Text = row("school_address")
                .lbl_father_name.Text = row("father_name")
                .lbl_father_occupation.Text = row("father_occupation")
                .lbl_mother_name.Text = row("mother_name")
                .lbl_mother_occupation.Text = row("mother_occupation")

                Dim img_labels() As Object = { .lbl_user_image, .lbl_coe, .lbl_report_card, .lbl_valid_id_front, .lbl_indigency, .lbl_psa, .lbl_tor, .lbl_valid_id_back}
                Dim img_vars() As Object = { .lbl_var_user_image, .lbl_var_coe_image, .lbl_var_report_card_image, .lbl_var_valid_id_image_front, .lbl_var_indigency_image, .lbl_var_psa_image, .lbl_var_tor_image, .lbl_var_valid_id_image_back}
                Dim img_names() As String = {row("user_image"), row("coe_image"), row("report_card_image"), row("valid_id_image_front"), row("indigency_image"), row("psa_image"), row("tor_image"), row("valid_id_image_back")}
                Dim img_label_index As Integer = 0

                For Each img_label As Object In img_labels
                    With img_label
                        .Cursor = Cursors.Default
                        .Text = "No Image Uploaded"
                        .ForeColor = Color.Black
                    End With
                Next

                For Each img_name As String In img_names
                    If Not img_name = "" Then
                        With img_labels(img_label_index)
                            .Cursor = Cursors.Hand
                            .Text = "Download Image"
                            .ForeColor = Color.FromArgb(0, 123, 255)
                        End With

                        img_vars(img_label_index).Text = img_name
                    End If

                    img_label_index += 1
                Next
            End With
        Next

        Database_Close()

        Application_Details.ShowDialog()
    End Sub
End Class
