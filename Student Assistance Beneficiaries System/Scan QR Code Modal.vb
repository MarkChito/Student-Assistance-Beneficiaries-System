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

    Private Sub Check_Application_ID(application_id As String)
        Dim result = Check_Applications()

        For Each row As DataRow In result.Rows
            Dim db_application_id As String = MD5_Hash(row("primary_key"))

            If db_application_id = application_id Then
                Dim student_primary_key = row("student_primary_key")
                Dim status = row("status")

                MsgBox("OK")
            Else
                With Main.Scan_QR_Code
                    .Scan_QR_Code_Message.BringToFront()

                    With .lbl_message
                        .ForeColor = Color.FromArgb(220, 53, 69)
                        .Text = "This Application ID doesn't exists"
                    End With

                    .Center_Object(.Scan_QR_Code_Message, .lbl_message)
                End With
            End If
        Next

        Close()
    End Sub
End Class