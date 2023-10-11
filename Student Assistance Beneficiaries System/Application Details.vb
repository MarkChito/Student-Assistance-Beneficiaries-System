Imports System.IO

Public Class Application_Details
    Private status As String = ""

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

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Main.btn_temp.Focus()

        Close()
    End Sub

    Private Sub btn_submit_Paint(sender As Object, e As PaintEventArgs) Handles btn_submit.Paint
        Rounded_Button(btn_submit)
    End Sub

    Private Sub btn_close_Paint(sender As Object, e As PaintEventArgs) Handles btn_close.Paint
        Rounded_Button(btn_close)
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Set_Status.ShowDialog()
    End Sub

    Private Sub lbl_user_image_Click(sender As Object, e As EventArgs) Handles lbl_user_image.Click
        Download_Image(lbl_user_image, lbl_var_user_image)
    End Sub

    Private Sub lbl_coe_Click(sender As Object, e As EventArgs) Handles lbl_coe.Click
        Download_Image(lbl_coe, lbl_var_coe_image)
    End Sub

    Private Sub lbl_report_card_Click(sender As Object, e As EventArgs) Handles lbl_report_card.Click
        Download_Image(lbl_report_card, lbl_var_report_card_image)
    End Sub

    Private Sub lbl_valid_id_front_Click(sender As Object, e As EventArgs) Handles lbl_valid_id_front.Click
        Download_Image(lbl_valid_id_front, lbl_var_valid_id_image_front)
    End Sub

    Private Sub lbl_indigency_Click(sender As Object, e As EventArgs) Handles lbl_indigency.Click
        Download_Image(lbl_indigency, lbl_var_indigency_image)
    End Sub

    Private Sub lbl_psa_Click(sender As Object, e As EventArgs) Handles lbl_psa.Click
        Download_Image(lbl_psa, lbl_var_psa_image)
    End Sub

    Private Sub lbl_tor_Click(sender As Object, e As EventArgs) Handles lbl_tor.Click
        Download_Image(lbl_tor, lbl_var_tor_image)
    End Sub

    Private Sub lbl_valid_id_back_Click(sender As Object, e As EventArgs) Handles lbl_valid_id_back.Click
        Download_Image(lbl_valid_id_back, lbl_var_valid_id_image_back)
    End Sub
End Class