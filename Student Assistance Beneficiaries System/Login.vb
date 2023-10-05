Imports System.Net

Public Class Login
    Public is_loading As Boolean = False

    Private Sub CenterPanel(parent_object As Object, child_object As Object)
        Dim centerX As Integer = parent_object.Width \ 2 - child_object.Width \ 2
        Dim centerY As Integer = parent_object.Height \ 2 - child_object.Height \ 2

        child_object.Location = New Point(centerX, centerY)
    End Sub

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

    Private Sub Sign_In()
        btn_temp.Focus()

        If String.IsNullOrWhiteSpace(txt_username.Text) Then
            btn_sign_in.Text = "Login"
            remember_me.Enabled = True

            MessageBox.Show("Please fill in the Username field.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)

            txt_username.Focus()
        ElseIf String.IsNullOrWhiteSpace(txt_password.Text) Then
            btn_sign_in.Text = "Login"
            remember_me.Enabled = True

            MessageBox.Show("Please fill in the Password field.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)

            txt_password.Focus()
        Else
            is_loading = True

            Dim results = Authenticate(txt_username.Text, txt_password.Text)

            Dim response_code = results("response_code")

            If response_code = 200 Then
                primary_key = results("primary_key")

                Me.Hide()

                With Main
                    .Show()
                    .WindowState = FormWindowState.Maximized
                End With

                remember_me.Enabled = True
                btn_sign_in.Text = "Login"

                is_loading = False

                pnl_notification.Hide()
            Else
                is_loading = False

                remember_me.Enabled = True
                btn_sign_in.Text = "Login"

                With pnl_notification
                    .Location = New Point(pnl_login_form.Location.X, pnl_login_form.Location.Y - 53)
                    pnl_notification.Show()
                End With
            End If
        End If
    End Sub

    Private Sub Login_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        CenterPanel(ClientSize, pnl_login_form)

        pnl_notification.Location = New Point(pnl_login_form.Location.X, pnl_login_form.Location.Y - 53)
    End Sub

    Private Sub btn_sign_in_Paint(sender As Object, e As PaintEventArgs) Handles btn_sign_in.Paint
        Rounded_Button(btn_sign_in)
    End Sub

    Private Sub btn_sign_in_using_rfid_card_Paint(sender As Object, e As PaintEventArgs) Handles btn_sign_in_using_rfid_card.Paint
        Rounded_Button(btn_sign_in_using_rfid_card)
    End Sub

    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If Not is_loading Then
            If e.KeyCode = Keys.Enter Then
                btn_sign_in.Text = "Processing..."
                remember_me.Enabled = False

                Sign_In()
            End If
        End If
    End Sub

    Private Sub btn_sign_in_Click(sender As Object, e As EventArgs) Handles btn_sign_in.Click
        If Not is_loading Then
            Sign_In()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Database_Open()
        Database_Close()
    End Sub

    Private Sub btn_sign_in_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_sign_in.MouseDown
        btn_sign_in.Text = "Processing..."
        remember_me.Enabled = False
    End Sub

    Private Sub btn_sign_in_using_rfid_card_Click(sender As Object, e As EventArgs) Handles btn_sign_in_using_rfid_card.Click
        If Not is_loading Then
            btn_temp.Focus()

            With RFID_Login
                .ShowDialog()
                .txt_rfid_number.Focus()
            End With
        End If
    End Sub
End Class
