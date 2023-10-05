Public Class RFID_Login
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

    Private Sub btn_sign_in_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        With txt_rfid_number
            .Clear()
            .Focus()
        End With

        Me.Close()
    End Sub

    Private Sub btn_close_Paint(sender As Object, e As PaintEventArgs) Handles btn_close.Paint
        Rounded_Button(btn_close)
    End Sub

    Private Sub txt_rfid_number_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_rfid_number.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not String.IsNullOrWhiteSpace(txt_rfid_number.Text) Then
                Login.is_loading = True

                Dim results = RFID_Authenticate(txt_rfid_number.Text)

                Dim response_code = results("response_code")

                If response_code = 200 Then
                    primary_key = results("primary_key")

                    With txt_rfid_number
                        .Clear()
                        .Focus()
                    End With

                    Me.Hide()

                    With Main
                        .Show()
                        .Mouse_Click(.btn_dashboard)
                        .WindowState = FormWindowState.Maximized
                    End With

                    With Login
                        .remember_me.Enabled = True
                        .btn_sign_in.Text = "Login"

                        .is_loading = False

                        .pnl_notification.Hide()

                        .txt_username.Clear()
                        .txt_password.Clear()

                        .remember_me.Checked = False

                        .Hide()
                    End With

                    Me.Close()
                Else
                    Login.is_loading = False

                    Me.Hide()

                    With Login
                        .pnl_parent.Height = .pnl_login_form.Height + 61

                        With .pnl_notification
                            .Show()
                            .BackColor = Color.FromArgb(220, 53, 69)
                            .Location = New Point(0, 0)
                        End With

                        .lbl_notification.Text = "Invalid RFID Card"

                        .Center_Object(.pnl_notification, .lbl_notification)

                        .Center_Object(.ClientSize, .pnl_parent)
                    End With

                    With txt_rfid_number
                        .Clear()
                        .Focus()
                    End With

                    Me.Close()
                End If
            Else
                With txt_rfid_number
                    .Clear()
                    .Focus()
                End With
            End If
        End If
    End Sub
End Class