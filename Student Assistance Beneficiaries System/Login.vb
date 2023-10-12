Imports System.Net

Public Class Login
    Public is_loading As Boolean = False

    Public Sub Center_Object(parent_object As Object, child_object As Object)
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

    Private Sub Login_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Center_Object(ClientSize, pnl_parent)

        pnl_notification.Location = New Point(pnl_login_form.Location.X, pnl_login_form.Location.Y - 53)
    End Sub

    Private Sub btn_sign_in_Paint(sender As Object, e As PaintEventArgs) Handles btn_sign_in.Paint
        Rounded_Button(btn_sign_in)
    End Sub

    Private Sub btn_sign_in_using_rfid_card_Paint(sender As Object, e As PaintEventArgs) Handles btn_sign_in_using_rfid_card.Paint
        Rounded_Button(btn_sign_in_using_rfid_card)
    End Sub

    Private Sub txt_username_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_username.KeyDown
        If Not is_loading Then
            If e.KeyCode = Keys.Enter Then
                With txt_password
                    .Clear()
                    .Focus()
                End With
            End If
        End If
    End Sub

    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If Not is_loading Then
            If e.KeyCode = Keys.Enter Then
                btn_sign_in.Text = "Processing..."
                remember_me.Enabled = False

                btn_temp.Focus()

                Timer1.Start()
            End If
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Database_Open()
        Database_Close()

        pnl_parent.Height = pnl_login_form.Height

        Center_Object(ClientSize, pnl_parent)
    End Sub

    Private Sub btn_sign_in_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_sign_in.MouseDown
        btn_sign_in.Text = "Processing..."
        remember_me.Enabled = False

        btn_temp.Focus()

        Timer1.Start()
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not is_loading Then
            If String.IsNullOrWhiteSpace(txt_username.Text) Then
                btn_sign_in.Text = "Login"
                remember_me.Enabled = True

                Timer1.Stop()

                MessageBox.Show("Please fill in the Username field.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)

                txt_username.Focus()
            ElseIf String.IsNullOrWhiteSpace(txt_password.Text) Then
                btn_sign_in.Text = "Login"
                remember_me.Enabled = True

                Timer1.Stop()

                MessageBox.Show("Please fill in the Password field.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)

                txt_password.Focus()
            Else
                Database_Open()

                is_loading = True

                Dim results = Authenticate(txt_username.Text, txt_password.Text)

                Dim response_code = results("response_code")

                If response_code = 200 Then
                    primary_key = results("primary_key")

                    Load_All_Images()
                Else
                    pnl_parent.Height = pnl_login_form.Height + 61

                    With pnl_notification
                        .Show()
                        .BackColor = Color.FromArgb(220, 53, 69)
                        .Location = New Point(0, 0)
                    End With

                    lbl_notification.Text = "Invalid Username or Password"

                    Center_Object(pnl_notification, lbl_notification)

                    txt_username.Clear()
                    txt_password.Clear()

                    Center_Object(ClientSize, pnl_parent)

                    remember_me.Enabled = True
                    btn_sign_in.Text = "Login"

                    is_loading = False

                    Database_Close()

                    Timer1.Stop()
                End If
            End If
        End If
    End Sub

    Private Sub remember_me_CheckedChanged(sender As Object, e As EventArgs) Handles remember_me.CheckedChanged
        btn_temp.Focus()
    End Sub
End Class
