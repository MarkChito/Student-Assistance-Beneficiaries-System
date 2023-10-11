Public Class Scan_QR_Code
    Public Sub Center_Object(parent_object As Object, child_object As Object)
        Dim centerX As Integer = parent_object.Width \ 2 - child_object.Width \ 2
        Dim centerY As Integer = parent_object.Height \ 2 - child_object.Height \ 2

        child_object.Location = New Point(centerX, centerY)
    End Sub

    Private Sub pnl_body_SizeChanged(sender As Object, e As EventArgs) Handles pnl_body.SizeChanged
        Center_Object(Scan_QR_Code_Message, lbl_message)
    End Sub

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel3.MouseEnter, Panel2.MouseEnter, Panel1.MouseEnter, btn_scan_qr_code.MouseEnter, Panel4.MouseEnter, Label1.MouseEnter, pnl_body.MouseEnter, lbl_message.MouseEnter
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

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click, Panel2.Click, Panel1.Click, Label1.Click, pnl_body.Click, lbl_message.Click
        With Main
            .pnl_account_details_visible = False
            .pnl_account_details.Visible = False
        End With
    End Sub

    Private Sub btn_scan_qr_code_Click(sender As Object, e As EventArgs) Handles btn_scan_qr_code.Click
        With Main
            .pnl_account_details_visible = False
            .pnl_account_details.Visible = False
        End With

        With Scan_QR_Code_Modal
            With .txt_qr_code_data
                .Clear()
                .Focus()
            End With

            With .img_scan_qr_code
                .SizeMode = PictureBoxSizeMode.StretchImage
                .Image = Image.FromFile("dist/img/scan_qr_code_gif.gif")
            End With

            .ShowDialog()
        End With
    End Sub
End Class
