Public Class Login
    Private is_loading As Boolean = False

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

        btn_sign_in.Text = "Processing..."
    End Sub

    Private Sub Login_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        CenterPanel(ClientSize, pnl_parent)
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
                Sign_In()
            End If
        End If
    End Sub
End Class
