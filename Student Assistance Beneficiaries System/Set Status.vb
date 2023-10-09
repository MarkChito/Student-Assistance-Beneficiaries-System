Public Class Set_Status
    Private selected_status As String = ""

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

    Private Sub btn_submit_Paint(sender As Object, e As PaintEventArgs) Handles btn_submit.Paint
        Rounded_Button(btn_submit)
    End Sub

    Private Sub btn_close_Paint(sender As Object, e As PaintEventArgs) Handles btn_close.Paint
        Rounded_Button(btn_close)
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Main.btn_temp.Focus()

        Close()
    End Sub

    Private Sub txt_status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_status.SelectedIndexChanged
        If txt_status.SelectedItem = "Approve Application" Then
            selected_status = "Approved"
        End If

        If txt_status.SelectedItem = "Reject Application" Then
            selected_status = "Rejected"
        End If

        If txt_status.SelectedItem = "Revert to Step 1" Then
            selected_status = "Step 1"
        End If

        If txt_status.SelectedItem = "Revert to Step 2" Then
            selected_status = "Step 2"
        End If
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Main.btn_temp.Focus()

        btn_close.Visible = False
        btn_submit.Text = "Processing..."
        btn_submit.Enabled = False

        If Not String.IsNullOrWhiteSpace(txt_status.Text) And Not String.IsNullOrWhiteSpace(txt_message.Text) Then
            Set_Status()
        Else
            btn_close.Visible = True
            btn_submit.Enabled = True
            btn_submit.Text = "&Submit Changes"

            MsgBox("Please complete all the required details!", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub Set_Status()
        Dim date_now As String = DateTime.Now.ToString("MMMM dd, yyyy")
        Dim time_now As String = DateTime.Now.ToString("hh:mm tt")

        With Application_Details
            Dim student_primary_key As String = .lbl_student_primary_key.Text
            Dim admin_primary_key As String = .lbl_admin_primary_key.Text
            Dim status As String = selected_status
            Dim message As String = txt_message.Text
            Dim category As String = .lbl_category.Text
            Dim admin_name As String = .lbl_admin_name.Text

            Dim notification_status As String = "unread"
            Dim transaction_event As String = ""

            Add_Notification(student_primary_key, admin_primary_key, date_now, time_now, message, notification_status)

            Dim result_notification_badge = Get_Notification_Badge(student_primary_key)

            If Not result_notification_badge Then
                Add_Notification_Badge("unclicked", student_primary_key)
            Else
                Update_Notification_Badge("unclicked", student_primary_key)
            End If

            If status = "Approved" Or status = "Rejected" Then
                Dim progress = "Completed"

                Update_Application_Admin(date_now, time_now, admin_primary_key, progress, status, student_primary_key)

                If status = "Approved" Then
                    Dim slot_result = Specific_Slots_Data(category)
                    Dim available_slots As Integer = Integer.Parse(slot_result("slot")) - 1

                    Update_Slot_Category(available_slots.ToString(), category)

                    transaction_event = "Application has been approved by Admin " & admin_name & "."
                Else
                    transaction_event = "Application has been rejected by Admin " & admin_name & "."
                End If
            Else
                Update_Application(date_now, time_now, status, "None", student_primary_key)

                transaction_event = "Admin " & admin_name & " has reverted this application back to " & status & " for further review of certain details."
            End If

            Add_Transaction(student_primary_key, date_now, time_now, transaction_event)

            txt_status.Text = Nothing
            txt_message.Clear()

            btn_close.Visible = True
            btn_submit.Enabled = True
            btn_submit.Text = "&Submit Changes"

            Hide()

            Application_Details.Hide()

            If category = "Educational" Then
                Main.btn_educational_pending.PerformClick()
            Else
                Main.btn_scholarship_pending.PerformClick()
            End If

            MsgBox("Student's status is updated", MsgBoxStyle.Information, "Success")
        End With
    End Sub
End Class