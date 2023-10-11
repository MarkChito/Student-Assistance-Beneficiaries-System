Public Class Scan_QR_Code_Modal
    Private Sub Rounded_Button(button_name As Object)
        Dim path As New Drawing2D.GraphicsPath()
        Dim cornerRadius As Integer = &B10100

        path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90)
        path.AddArc(button_name.Width - (cornerRadius * 2), 0, cornerRadius * 2, cornerRadius * 2, 270, 90)
        path.AddArc(button_name.Width - (cornerRadius * 2), button_name.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90)
        path.AddArc(0, button_name.Height - (cornerRadius * 2), cornerRadius * 2, cornerRadius * 2, 90, 90)
        path.CloseFigure()

        button_name.Region = New Region(path)
    End Sub

    Private Sub Check_Application_ID(application_id As String)
        Main.btn_temp.Focus()

        Dim result = Check_Applications()

        For Each row As DataRow In result.Rows
            Dim db_application_id As String = MD5_Hash(row("primary_key"))

            If db_application_id = application_id Then
                Dim primary_key = row("primary_key")
                Dim student_primary_key = row("student_primary_key")
                Dim status = row("status")

                If Not status = "Approved" Then
                    If status = "Received" Then
                        Error_Message_Display("This Application ID has already received cash")
                    ElseIf status = "Pending" Or status = "Rejected" Then
                        Error_Message_Display("This Application ID has not been approved")
                    End If
                Else
                    With Main.Scan_QR_Code
                        Database_Open()

                        Dim results = Get_Student_Data(student_primary_key)

                        For Each row_2 As DataRow In results.Rows
                            With .Scan_QR_Code_Details
                                Dim row_3 = Get_User_RFID_Number(row_2("login_primary_key").ToString())

                                .lbl_primary_key.Text = primary_key

                                .lbl_first_name.Text = row_2("first_name")
                                .lbl_middle_name.Text = row_2("middle_name")
                                .lbl_last_name.Text = row_2("last_name")
                                .lbl_student_number.Text = row_2("student_number")
                                .lbl_rfid_number.Text = row_3("rfid_number")
                                .lbl_sex.Text = row_2("sex")

                                .lbl_mobile_number.Text = row_2("mobile_number")
                                .lbl_address.Text = row_2("address")
                                .lbl_school_name.Text = row_2("school_name")
                                .lbl_school_address.Text = row_2("school_address")
                                .lbl_father_name.Text = row_2("father_name")
                                .lbl_father_occupation.Text = row_2("father_occupation")
                                .lbl_mother_name.Text = row_2("mother_name")
                                .lbl_mother_occupation.Text = row_2("mother_occupation")

                                Dim img_labels() As Object = { .lbl_user_image, .lbl_coe, .lbl_report_card, .lbl_valid_id_front, .lbl_indigency, .lbl_psa, .lbl_tor, .lbl_valid_id_back}
                                Dim img_vars() As Object = { .lbl_var_user_image, .lbl_var_coe_image, .lbl_var_report_card_image, .lbl_var_valid_id_image_front, .lbl_var_indigency_image, .lbl_var_psa_image, .lbl_var_tor_image, .lbl_var_valid_id_image_back}
                                Dim img_names() As String = {row_2("user_image"), row_2("coe_image"), row_2("report_card_image"), row_2("valid_id_image_front"), row_2("indigency_image"), row_2("psa_image"), row_2("tor_image"), row_2("valid_id_image_back")}
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

                        .btn_scan_qr_code.Hide()
                        .Scan_QR_Code_Message.Hide()

                        With .Scan_QR_Code_Details
                            .is_processing = False
                            .btn_submit.Text = "       &Release Money"

                            .BringToFront()
                            .Show()
                        End With
                    End With

                End If
            Else
                Error_Message_Display("This Application ID doesn't exists")
            End If
        Next

        Close()
    End Sub

    Private Sub Error_Message_Display(message As String)
        With Main.Scan_QR_Code
            .Scan_QR_Code_Details.Hide()

            With .Scan_QR_Code_Message
                .Show()
                .BringToFront()
            End With

            With .lbl_message
                .ForeColor = Color.FromArgb(220, 53, 69)
                .Text = message
            End With

            .Center_Object(.Scan_QR_Code_Message, .lbl_message)
        End With
    End Sub

    Private Sub btn_close_Paint(sender As Object, e As PaintEventArgs) Handles btn_close.Paint
        Rounded_Button(btn_close)
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        With txt_qr_code_data
            .Clear()
            .Focus()
        End With

        With img_scan_qr_code
            .SizeMode = PictureBoxSizeMode.StretchImage
            .Image = Image.FromFile("dist/img/scan_qr_code_gif.gif")
        End With

        Me.Close()
    End Sub

    Private Sub txt_qr_code_data_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_qr_code_data.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not String.IsNullOrWhiteSpace(txt_qr_code_data.Text) Then
                With img_scan_qr_code
                    .SizeMode = PictureBoxSizeMode.CenterImage
                    .Image = Image.FromFile("dist/img/loading.gif")
                End With

                Check_Application_ID(txt_qr_code_data.Text)
            End If
        End If
    End Sub
End Class