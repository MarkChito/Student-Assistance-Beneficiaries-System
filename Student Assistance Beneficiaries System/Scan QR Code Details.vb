Imports System.IO

Public Class Scan_QR_Code_Details
    Public is_processing As Boolean = False

    Private Sub Download_Image(lbl_image As Label, lbl_var_image As Label)
        If Not lbl_image.Text = "No Image Uploaded" Then
            Dim sourceFolderPath As String = "dist/img/user_upload"
            Dim sourceFileName As String = lbl_var_image.Text
            Dim downloadsFolderPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")
            Dim sourceFilePath As String = Path.Combine(sourceFolderPath, sourceFileName)

            If File.Exists(sourceFilePath) Then
                Dim destinationFilePath As String = Path.Combine(downloadsFolderPath, sourceFileName)

                Try
                    File.Copy(sourceFilePath, destinationFilePath, True)

                    MsgBox("Image is downloaded to 'Downloads' Folder.", MsgBoxStyle.Information, "Success")
                Catch ex As Exception
                    MsgBox("Error copying image: " & ex.Message, MsgBoxStyle.Critical, "Error")
                End Try
            Else
                MsgBox("Source file does not exist.", MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub

    Private Sub pnl_body_SizeChanged(sender As Object, e As EventArgs) Handles pnl_body.SizeChanged
        Dim _width As Integer = pnl_body.Width - 40

        pnl_personal_information.Width = _width
        pnl_contact_information.Width = _width
        pnl_uploaded_documents.Width = _width
        pnl_footer.Width = _width

        pnl_personal_info_left.Width = _width / 2
        pnl_contact_info_left.Width = _width / 2
        pnl_uploaded_documents_left.Width = _width / 2
    End Sub

    Private Sub lbl_user_image_Click(sender As Object, e As EventArgs) Handles lbl_user_image.Click
        With Main
            .pnl_account_details_visible = False
            .pnl_account_details.Visible = False
        End With

        Download_Image(lbl_user_image, lbl_var_user_image)
    End Sub

    Private Sub lbl_coe_Click(sender As Object, e As EventArgs) Handles lbl_coe.Click
        With Main
            .pnl_account_details_visible = False
            .pnl_account_details.Visible = False
        End With

        Download_Image(lbl_coe, lbl_var_coe_image)
    End Sub

    Private Sub lbl_report_card_Click(sender As Object, e As EventArgs) Handles lbl_report_card.Click
        With Main
            .pnl_account_details_visible = False
            .pnl_account_details.Visible = False
        End With

        Download_Image(lbl_report_card, lbl_var_report_card_image)
    End Sub

    Private Sub lbl_valid_id_front_Click(sender As Object, e As EventArgs) Handles lbl_valid_id_front.Click
        With Main
            .pnl_account_details_visible = False
            .pnl_account_details.Visible = False
        End With

        Download_Image(lbl_valid_id_front, lbl_var_valid_id_image_front)
    End Sub

    Private Sub lbl_indigency_Click(sender As Object, e As EventArgs) Handles lbl_indigency.Click
        With Main
            .pnl_account_details_visible = False
            .pnl_account_details.Visible = False
        End With

        Download_Image(lbl_indigency, lbl_var_indigency_image)
    End Sub

    Private Sub lbl_psa_Click(sender As Object, e As EventArgs) Handles lbl_psa.Click
        With Main
            .pnl_account_details_visible = False
            .pnl_account_details.Visible = False
        End With

        Download_Image(lbl_psa, lbl_var_psa_image)
    End Sub

    Private Sub lbl_tor_Click(sender As Object, e As EventArgs) Handles lbl_tor.Click
        With Main
            .pnl_account_details_visible = False
            .pnl_account_details.Visible = False
        End With

        Download_Image(lbl_tor, lbl_var_tor_image)
    End Sub

    Private Sub lbl_valid_id_back_Click(sender As Object, e As EventArgs) Handles lbl_valid_id_back.Click
        With Main
            .pnl_account_details_visible = False
            .pnl_account_details.Visible = False
        End With

        Download_Image(lbl_valid_id_back, lbl_var_valid_id_image_back)
    End Sub

    Private Sub pnl_footer_MouseEnter(sender As Object, e As EventArgs) Handles pnl_personal_information.MouseEnter, Panel7.MouseEnter, lbl_sex.MouseEnter, Label10.MouseEnter, lbl_rfid_number.MouseEnter, Label12.MouseEnter, lbl_student_number.MouseEnter, Label14.MouseEnter, pnl_personal_info_left.MouseEnter, lbl_last_name.MouseEnter, Label7.MouseEnter, lbl_middle_name.MouseEnter, Label6.MouseEnter, lbl_first_name.MouseEnter, Label3.MouseEnter, Panel5.MouseEnter, Label2.MouseEnter, PictureBox1.MouseEnter, btn_submit.MouseEnter, pnl_body.MouseEnter, pnl_footer.MouseEnter, pnl_uploaded_documents.MouseEnter, Panel13.MouseEnter, lbl_tor.MouseEnter, lbl_title_tor.MouseEnter, lbl_valid_id_back.MouseEnter, Label33.MouseEnter, lbl_psa.MouseEnter, Label35.MouseEnter, lbl_indigency.MouseEnter, Label37.MouseEnter, pnl_uploaded_documents_left.MouseEnter, lbl_var_valid_id_image_front.MouseEnter, lbl_var_report_card_image.MouseEnter, lbl_var_coe_image.MouseEnter, lbl_var_user_image.MouseEnter, lbl_report_card.MouseEnter, lbl_title_report_card.MouseEnter, lbl_valid_id_front.MouseEnter, Label39.MouseEnter, lbl_coe.MouseEnter, Label41.MouseEnter, lbl_user_image.MouseEnter, Label43.MouseEnter, Panel15.MouseEnter, Label44.MouseEnter, PictureBox3.MouseEnter, pnl_contact_information.MouseEnter, Panel9.MouseEnter, lbl_mother_occupation.MouseEnter, Label31.MouseEnter, lbl_mother_name.MouseEnter, Label16.MouseEnter, lbl_school_address.MouseEnter, Label18.MouseEnter, lbl_address.MouseEnter, Label20.MouseEnter, pnl_contact_info_left.MouseEnter, lbl_school_name.MouseEnter, Label29.MouseEnter, lbl_father_occupation.MouseEnter, Label22.MouseEnter, lbl_father_name.MouseEnter, Label24.MouseEnter, lbl_mobile_number.MouseEnter, Label26.MouseEnter, Panel11.MouseEnter, Label27.MouseEnter, PictureBox2.MouseEnter
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

    Private Sub pnl_footer_Click(sender As Object, e As EventArgs) Handles pnl_personal_information.Click, Panel7.Click, lbl_sex.Click, Label10.Click, lbl_rfid_number.Click, Label12.Click, lbl_student_number.Click, Label14.Click, pnl_personal_info_left.Click, lbl_last_name.Click, Label7.Click, lbl_middle_name.Click, Label6.Click, lbl_first_name.Click, Label3.Click, Panel5.Click, Label2.Click, PictureBox1.Click, pnl_body.Click, pnl_footer.Click, pnl_uploaded_documents.Click, Panel13.Click, lbl_title_tor.Click, Label33.Click, Label35.Click, Label37.Click, pnl_uploaded_documents_left.Click, lbl_var_valid_id_image_front.Click, lbl_var_report_card_image.Click, lbl_var_coe_image.Click, lbl_var_user_image.Click, lbl_title_report_card.Click, Label39.Click, Label41.Click, Label43.Click, Panel15.Click, Label44.Click, PictureBox3.Click, pnl_contact_information.Click, Panel9.Click, lbl_mother_occupation.Click, Label31.Click, lbl_mother_name.Click, Label16.Click, lbl_school_address.Click, Label18.Click, lbl_address.Click, Label20.Click, pnl_contact_info_left.Click, lbl_school_name.Click, Label29.Click, lbl_father_occupation.Click, Label22.Click, lbl_father_name.Click, Label24.Click, lbl_mobile_number.Click, Label26.Click, Panel11.Click, Label27.Click, PictureBox2.Click
        With Main
            .btn_temp.Focus()

            .pnl_account_details_visible = False
            .pnl_account_details.Visible = False
        End With
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        With Main
            .btn_temp.Focus()

            .pnl_account_details_visible = False
            .pnl_account_details.Visible = False
        End With

        If Not is_processing Then
            btn_submit.Text = "       Processing Request..."

            is_processing = True

            Update_Application_Status(lbl_primary_key.Text)

            Main.Mouse_Click(Main.btn_scan_qr_code)

            MsgBox("Successfully released the money.", MsgBoxStyle.Information, "Success")
        End If
    End Sub
End Class
