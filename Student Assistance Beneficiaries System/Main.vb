Public Class Main
    Private is_educational_open As Boolean = False
    Private is_educational_selected As Boolean = False
    Private is_scholarship_open As Boolean = False
    Private is_scholarship_selected As Boolean = False
    Private is_sidebar_open As Boolean = True

    Public Sub Mouse_Click(button As Button)
        btn_temp.Focus()

        If button.Name = "btn_educational" Or button.Name = "btn_scholarship" Then
            If button.Name = "btn_educational" Then
                If Not is_educational_open Then
                    pnl_educational_spacer_3.Show()
                    pnl_educational_spacer_3.Dock = DockStyle.Top
                    btn_educational_rejected.Show()

                    pnl_educational_spacer_2.Show()
                    pnl_educational_spacer_2.Dock = DockStyle.Top
                    btn_educational_approved.Show()

                    pnl_educational_spacer_1.Show()
                    pnl_educational_spacer_1.Dock = DockStyle.Top
                    btn_educational_pending.Show()

                    is_educational_open = True

                    If Not is_educational_selected Then
                        btn_educational.BackColor = Color.FromArgb(73, 78, 83)
                    End If
                Else
                    pnl_educational_spacer_3.Hide()
                    btn_educational_rejected.Hide()

                    pnl_educational_spacer_2.Hide()
                    btn_educational_approved.Hide()

                    pnl_educational_spacer_1.Hide()
                    btn_educational_pending.Hide()

                    is_educational_open = False

                    If Not is_educational_selected Then
                        btn_educational.BackColor = Color.Transparent
                    End If
                End If
            End If

            If button.Name = "btn_scholarship" Then
                If Not is_scholarship_open Then
                    pnl_scholarship_spacer_3.Show()
                    pnl_scholarship_spacer_3.Dock = DockStyle.Top
                    btn_scholarship_rejected.Show()

                    pnl_scholarship_spacer_2.Show()
                    pnl_scholarship_spacer_2.Dock = DockStyle.Top
                    btn_scholarship_approved.Show()

                    pnl_scholarship_spacer_1.Show()
                    pnl_scholarship_spacer_1.Dock = DockStyle.Top
                    btn_scholarship_pending.Show()

                    is_scholarship_open = True

                    If Not is_scholarship_selected Then
                        btn_scholarship.BackColor = Color.FromArgb(73, 78, 83)
                    End If
                Else
                    pnl_scholarship_spacer_3.Hide()
                    btn_scholarship_rejected.Hide()

                    pnl_scholarship_spacer_2.Hide()
                    btn_scholarship_approved.Hide()

                    pnl_scholarship_spacer_1.Hide()
                    btn_scholarship_pending.Hide()

                    is_scholarship_open = False

                    If Not is_scholarship_selected Then
                        btn_scholarship.BackColor = Color.Transparent
                    End If
                End If
            End If
        Else
            is_educational_open = False
            is_educational_selected = False

            is_scholarship_open = False
            is_scholarship_selected = False

            With btn_dashboard
                .BackColor = Color.Transparent
                .FlatAppearance.MouseDownBackColor = .BackColor
                .FlatAppearance.MouseOverBackColor = Color.FromArgb(73, 78, 83)
            End With

            With btn_scan_qr_code
                .BackColor = Color.Transparent
                .FlatAppearance.MouseDownBackColor = .BackColor
                .FlatAppearance.MouseOverBackColor = Color.FromArgb(73, 78, 83)
            End With

            With btn_educational_pending
                .Image = Image.FromFile("dist/img/circle_white.png")
                .ForeColor = Color.White
                .BackColor = Color.Transparent
                .FlatAppearance.MouseDownBackColor = .BackColor
                .FlatAppearance.MouseOverBackColor = Color.FromArgb(73, 78, 83)
            End With

            With btn_educational_approved
                .Image = Image.FromFile("dist/img/circle_white.png")
                .ForeColor = Color.White
                .BackColor = Color.Transparent
                .FlatAppearance.MouseDownBackColor = .BackColor
                .FlatAppearance.MouseOverBackColor = Color.FromArgb(73, 78, 83)
            End With

            With btn_educational_rejected
                .Image = Image.FromFile("dist/img/circle_white.png")
                .ForeColor = Color.White
                .BackColor = Color.Transparent
                .FlatAppearance.MouseDownBackColor = .BackColor
                .FlatAppearance.MouseOverBackColor = Color.FromArgb(73, 78, 83)
            End With

            With btn_scholarship_pending
                .Image = Image.FromFile("dist/img/circle_white.png")
                .ForeColor = Color.White
                .BackColor = Color.Transparent
                .FlatAppearance.MouseDownBackColor = .BackColor
                .FlatAppearance.MouseOverBackColor = Color.FromArgb(73, 78, 83)
            End With

            With btn_scholarship_approved
                .Image = Image.FromFile("dist/img/circle_white.png")
                .ForeColor = Color.White
                .BackColor = Color.Transparent
                .FlatAppearance.MouseDownBackColor = .BackColor
                .FlatAppearance.MouseOverBackColor = Color.FromArgb(73, 78, 83)
            End With

            With btn_scholarship_rejected
                .Image = Image.FromFile("dist/img/circle_white.png")
                .ForeColor = Color.White
                .BackColor = Color.Transparent
                .FlatAppearance.MouseDownBackColor = .BackColor
                .FlatAppearance.MouseOverBackColor = Color.FromArgb(73, 78, 83)
            End With

            With btn_educational
                .BackColor = Color.Transparent
                .FlatAppearance.MouseDownBackColor = .BackColor
                .FlatAppearance.MouseOverBackColor = Color.FromArgb(73, 78, 83)

                pnl_educational_spacer_3.Hide()
                btn_educational_rejected.Hide()

                pnl_educational_spacer_2.Hide()
                btn_educational_approved.Hide()

                pnl_educational_spacer_1.Hide()
                btn_educational_pending.Hide()

                is_educational_open = False
            End With

            With btn_scholarship
                .BackColor = Color.Transparent
                .FlatAppearance.MouseDownBackColor = .BackColor
                .FlatAppearance.MouseOverBackColor = Color.FromArgb(73, 78, 83)

                pnl_scholarship_spacer_3.Hide()
                btn_scholarship_rejected.Hide()

                pnl_scholarship_spacer_2.Hide()
                btn_scholarship_approved.Hide()

                pnl_scholarship_spacer_1.Hide()
                btn_scholarship_pending.Hide()

                is_scholarship_open = False
            End With

            If button.Name = "btn_educational_pending" Or button.Name = "btn_educational_approved" Or button.Name = "btn_educational_rejected" Then
                pnl_educational_spacer_3.Show()
                pnl_educational_spacer_3.Dock = DockStyle.Top
                btn_educational_rejected.Show()

                pnl_educational_spacer_2.Show()
                pnl_educational_spacer_2.Dock = DockStyle.Top
                btn_educational_approved.Show()

                pnl_educational_spacer_1.Show()
                pnl_educational_spacer_1.Dock = DockStyle.Top
                btn_educational_pending.Show()

                is_educational_open = True
                is_educational_selected = True

                With btn_educational
                    .BackColor = Color.FromArgb(0, 123, 255)
                    .FlatAppearance.MouseDownBackColor = .BackColor
                    .FlatAppearance.MouseOverBackColor = .BackColor
                End With

                button.BackColor = Color.FromArgb(235, 236, 236)

                With button
                    .Image = Image.FromFile("dist/img/circle_black.png")
                    .ForeColor = Color.Black
                    .FlatAppearance.MouseDownBackColor = .BackColor
                    .FlatAppearance.MouseOverBackColor = .BackColor
                End With

                Text = button.Text.Replace("          ", "") & " Educational Applications"
            ElseIf button.Name = "btn_scholarship_pending" Or button.Name = "btn_scholarship_approved" Or button.Name = "btn_scholarship_rejected" Then
                pnl_scholarship_spacer_3.Show()
                pnl_scholarship_spacer_3.Dock = DockStyle.Top
                btn_scholarship_rejected.Show()

                pnl_scholarship_spacer_2.Show()
                pnl_scholarship_spacer_2.Dock = DockStyle.Top
                btn_scholarship_approved.Show()

                pnl_scholarship_spacer_1.Show()
                pnl_scholarship_spacer_1.Dock = DockStyle.Top
                btn_scholarship_pending.Show()

                is_scholarship_open = True
                is_scholarship_selected = True

                With btn_scholarship
                    .BackColor = Color.FromArgb(0, 123, 255)
                    .FlatAppearance.MouseDownBackColor = .BackColor
                    .FlatAppearance.MouseOverBackColor = .BackColor
                End With

                button.BackColor = Color.FromArgb(235, 236, 236)

                With button
                    .Image = Image.FromFile("dist/img/circle_black.png")
                    .ForeColor = Color.Black
                    .FlatAppearance.MouseDownBackColor = .BackColor
                    .FlatAppearance.MouseOverBackColor = .BackColor
                End With

                Text = button.Text.Replace("          ", "") & " Scholarship Applications"
            Else
                button.BackColor = Color.FromArgb(0, 123, 255)

                With button
                    .FlatAppearance.MouseDownBackColor = .BackColor
                    .FlatAppearance.MouseOverBackColor = .BackColor
                End With

                Text = button.Text.Replace("          ", "")
            End If
        End If
    End Sub

    Private Sub Logout()
        btn_temp.Focus()

        primary_key = Nothing

        Me.Hide()

        If is_educational_open Then
            pnl_educational_spacer_3.Hide()
            btn_educational_rejected.Hide()

            pnl_educational_spacer_2.Hide()
            btn_educational_approved.Hide()

            pnl_educational_spacer_1.Hide()
            btn_educational_pending.Hide()

            is_educational_open = False

            btn_educational.BackColor = Color.Transparent
        End If

        If is_scholarship_open Then
            pnl_scholarship_spacer_3.Hide()
            btn_scholarship_rejected.Hide()

            pnl_scholarship_spacer_2.Hide()
            btn_scholarship_approved.Hide()

            pnl_scholarship_spacer_1.Hide()
            btn_scholarship_pending.Hide()

            is_scholarship_open = False

            btn_scholarship.BackColor = Color.Transparent
        End If

        If Not is_sidebar_open Then
            pnl_sidebar.Width = 280

            With pnl_logo
                .BackgroundImage = Image.FromFile("dist/img/logo_big.png")
                .Height = pnl_sidebar.Width
            End With

            btn_dashboard.ImageAlign = ContentAlignment.MiddleLeft
            btn_scan_qr_code.ImageAlign = ContentAlignment.MiddleLeft
            btn_educational.ImageAlign = ContentAlignment.MiddleLeft
            btn_educational_pending.ImageAlign = ContentAlignment.MiddleLeft
            btn_educational_approved.ImageAlign = ContentAlignment.MiddleLeft
            btn_educational_rejected.ImageAlign = ContentAlignment.MiddleLeft
            btn_scholarship.ImageAlign = ContentAlignment.MiddleLeft
            btn_scholarship_pending.ImageAlign = ContentAlignment.MiddleLeft
            btn_scholarship_approved.ImageAlign = ContentAlignment.MiddleLeft
            btn_scholarship_rejected.ImageAlign = ContentAlignment.MiddleLeft
            btn_logout.ImageAlign = ContentAlignment.MiddleLeft

            is_sidebar_open = True
        End If

        With Login
            .pnl_parent.Height = .pnl_login_form.Height + 61

            With .pnl_notification
                .Show()
                .BackColor = Color.FromArgb(40, 167, 69)
                .Location = New Point(0, 0)
            End With

            .lbl_notification.Text = "You've been successfully signed out"

            .Center_Object(.pnl_notification, .lbl_notification)

            .Show()
            .btn_temp.Focus()
            .WindowState = FormWindowState.Normal

            .Center_Object(.ClientSize, .pnl_parent)
        End With
    End Sub

    Private Sub btn_educational_Click(sender As Object, e As EventArgs) Handles btn_educational.Click
        Mouse_Click(btn_educational)
    End Sub

    Private Sub btn_scholarship_Click(sender As Object, e As EventArgs) Handles btn_scholarship.Click
        Mouse_Click(btn_scholarship)
    End Sub

    Private Sub btn_dashboard_Click(sender As Object, e As EventArgs) Handles btn_dashboard.Click
        Mouse_Click(btn_dashboard)
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_educational.FlatAppearance.MouseDownBackColor = btn_scholarship.BackColor
        btn_scholarship.FlatAppearance.MouseDownBackColor = btn_scholarship.BackColor
        btn_logout.FlatAppearance.MouseDownBackColor = btn_logout.BackColor
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog_result = MessageBox.Show(Me, "Are you sure?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog_result = DialogResult.No Then
            e.Cancel = True
        Else
            Login.Close()
        End If
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        Logout()
    End Sub

    Private Sub btn_scan_qr_code_Click(sender As Object, e As EventArgs) Handles btn_scan_qr_code.Click
        Mouse_Click(btn_scan_qr_code)
    End Sub

    Private Sub btn_educational_pending_Click(sender As Object, e As EventArgs) Handles btn_educational_pending.Click
        Mouse_Click(btn_educational_pending)
    End Sub

    Private Sub btn_educational_approved_Click(sender As Object, e As EventArgs) Handles btn_educational_approved.Click
        Mouse_Click(btn_educational_approved)
    End Sub

    Private Sub btn_educational_rejected_Click(sender As Object, e As EventArgs) Handles btn_educational_rejected.Click
        Mouse_Click(btn_educational_rejected)
    End Sub

    Private Sub btn_scholarship_pending_Click(sender As Object, e As EventArgs) Handles btn_scholarship_pending.Click
        Mouse_Click(btn_scholarship_pending)
    End Sub

    Private Sub btn_scholarship_approved_Click(sender As Object, e As EventArgs) Handles btn_scholarship_approved.Click
        Mouse_Click(btn_scholarship_approved)
    End Sub

    Private Sub btn_scholarship_rejected_Click(sender As Object, e As EventArgs) Handles btn_scholarship_rejected.Click
        Mouse_Click(btn_scholarship_rejected)
    End Sub

    Private Sub btn_toggle_sidebar_Click(sender As Object, e As EventArgs) Handles btn_toggle_sidebar.Click
        If is_sidebar_open Then
            pnl_sidebar.Width = 80

            With pnl_logo
                .BackgroundImage = Image.FromFile("dist/img/logo_small.png")
                .Height = pnl_sidebar.Width
            End With

            btn_dashboard.ImageAlign = ContentAlignment.MiddleCenter
            btn_scan_qr_code.ImageAlign = ContentAlignment.MiddleCenter
            btn_educational.ImageAlign = ContentAlignment.MiddleCenter
            btn_educational_pending.ImageAlign = ContentAlignment.MiddleCenter
            btn_educational_approved.ImageAlign = ContentAlignment.MiddleCenter
            btn_educational_rejected.ImageAlign = ContentAlignment.MiddleCenter
            btn_scholarship.ImageAlign = ContentAlignment.MiddleCenter
            btn_scholarship_pending.ImageAlign = ContentAlignment.MiddleCenter
            btn_scholarship_approved.ImageAlign = ContentAlignment.MiddleCenter
            btn_scholarship_rejected.ImageAlign = ContentAlignment.MiddleCenter
            btn_logout.ImageAlign = ContentAlignment.MiddleCenter

            is_sidebar_open = False
        Else
            pnl_sidebar.Width = 280

            With pnl_logo
                .BackgroundImage = Image.FromFile("dist/img/logo_big.png")
                .Height = pnl_sidebar.Width
            End With

            btn_dashboard.ImageAlign = ContentAlignment.MiddleLeft
            btn_scan_qr_code.ImageAlign = ContentAlignment.MiddleLeft
            btn_educational.ImageAlign = ContentAlignment.MiddleLeft
            btn_educational_pending.ImageAlign = ContentAlignment.MiddleLeft
            btn_educational_approved.ImageAlign = ContentAlignment.MiddleLeft
            btn_educational_rejected.ImageAlign = ContentAlignment.MiddleLeft
            btn_scholarship.ImageAlign = ContentAlignment.MiddleLeft
            btn_scholarship_pending.ImageAlign = ContentAlignment.MiddleLeft
            btn_scholarship_approved.ImageAlign = ContentAlignment.MiddleLeft
            btn_scholarship_rejected.ImageAlign = ContentAlignment.MiddleLeft
            btn_logout.ImageAlign = ContentAlignment.MiddleLeft

            is_sidebar_open = True
        End If
    End Sub

    Private Sub pnl_sidebar_MouseEnter(sender As Object, e As EventArgs) Handles pnl_sidebar.MouseEnter, pnl_logo.MouseEnter, btn_dashboard.MouseEnter, btn_scan_qr_code.MouseEnter, btn_educational.MouseEnter, btn_educational_pending.MouseEnter, btn_educational_approved.MouseEnter, btn_educational_rejected.MouseEnter, btn_scholarship.MouseEnter, btn_scholarship_pending.MouseEnter, btn_scholarship_approved.MouseEnter, btn_scholarship_rejected.MouseEnter, btn_logout.MouseEnter, pnl_dashboard_spacer.MouseEnter, pnl_scan_qr_code_spacer.MouseEnter, pnl_educational_spacer.MouseEnter, pnl_educational_spacer_1.MouseEnter, pnl_educational_spacer_2.MouseEnter, pnl_educational_spacer_3.MouseEnter, pnl_scholarship_spacer.MouseEnter, pnl_scholarship_spacer_1.MouseEnter, pnl_scholarship_spacer_2.MouseEnter, pnl_scholarship_spacer_3.MouseEnter, pnl_spacer.MouseEnter
        If Not is_sidebar_open Then
            pnl_sidebar.Width = 280

            btn_dashboard.ImageAlign = ContentAlignment.MiddleLeft
            btn_scan_qr_code.ImageAlign = ContentAlignment.MiddleLeft
            btn_educational.ImageAlign = ContentAlignment.MiddleLeft
            btn_educational_pending.ImageAlign = ContentAlignment.MiddleLeft
            btn_educational_approved.ImageAlign = ContentAlignment.MiddleLeft
            btn_educational_rejected.ImageAlign = ContentAlignment.MiddleLeft
            btn_scholarship.ImageAlign = ContentAlignment.MiddleLeft
            btn_scholarship_pending.ImageAlign = ContentAlignment.MiddleLeft
            btn_scholarship_approved.ImageAlign = ContentAlignment.MiddleLeft
            btn_scholarship_rejected.ImageAlign = ContentAlignment.MiddleLeft
            btn_logout.ImageAlign = ContentAlignment.MiddleLeft
        End If
    End Sub

    Private Sub pnl_header_MouseEnter(sender As Object, e As EventArgs) Handles pnl_header.MouseEnter, pnl_footer.MouseEnter, pnl_body.MouseEnter
        If Not is_sidebar_open Then
            pnl_sidebar.Width = 80

            btn_dashboard.ImageAlign = ContentAlignment.MiddleCenter
            btn_scan_qr_code.ImageAlign = ContentAlignment.MiddleCenter
            btn_educational.ImageAlign = ContentAlignment.MiddleCenter
            btn_educational_pending.ImageAlign = ContentAlignment.MiddleCenter
            btn_educational_approved.ImageAlign = ContentAlignment.MiddleCenter
            btn_educational_rejected.ImageAlign = ContentAlignment.MiddleCenter
            btn_scholarship.ImageAlign = ContentAlignment.MiddleCenter
            btn_scholarship_pending.ImageAlign = ContentAlignment.MiddleCenter
            btn_scholarship_approved.ImageAlign = ContentAlignment.MiddleCenter
            btn_scholarship_rejected.ImageAlign = ContentAlignment.MiddleCenter
            btn_logout.ImageAlign = ContentAlignment.MiddleCenter
        End If
    End Sub
End Class