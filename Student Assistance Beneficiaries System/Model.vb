Imports System.Security.Cryptography
Imports System.Text
Imports BCrypt
Imports MySql.Data.MySqlClient
Imports MongoDB.Driver
Imports MongoDB.Bson
Imports System.Net.Http
Imports System.IO

Module Model
    Private connection As New MySqlConnection
    Private command As New MySqlCommand
    Private adapter As New MySqlDataAdapter
    Private table As New DataTable

    Private ReadOnly online_connection = "https://"
    Private ReadOnly localhost_connection = "http://localhost/"

    Public url As String = connection_type & "cdmstudentassistance.ssystem.online/"
    Public primary_key As String = ""

    Private tbl_studentassistance_applications As IMongoCollection(Of BsonDocument) = MongoDB_Table_Name("tbl_studentassistance_applications")
    Private tbl_studentassistance_notificationbadge As IMongoCollection(Of BsonDocument) = MongoDB_Table_Name("tbl_studentassistance_notificationbadge")
    Private tbl_studentassistance_notifications As IMongoCollection(Of BsonDocument) = MongoDB_Table_Name("tbl_studentassistance_notifications")
    Private tbl_studentassistance_procedures As IMongoCollection(Of BsonDocument) = MongoDB_Table_Name("tbl_studentassistance_procedures")
    Private tbl_studentassistance_requirements As IMongoCollection(Of BsonDocument) = MongoDB_Table_Name("tbl_studentassistance_requirements")
    Private tbl_studentassistance_slots As IMongoCollection(Of BsonDocument) = MongoDB_Table_Name("tbl_studentassistance_slots")
    Private tbl_studentassistance_students As IMongoCollection(Of BsonDocument) = MongoDB_Table_Name("tbl_studentassistance_students")
    Private tbl_studentassistance_transactions As IMongoCollection(Of BsonDocument) = MongoDB_Table_Name("tbl_studentassistance_transactions")
    Private tbl_studentassistance_useraccounts As IMongoCollection(Of BsonDocument) = MongoDB_Table_Name("tbl_studentassistance_useraccounts")

    ' CHANGE THIS WHEN CONNECTING ONLINE
    Public ReadOnly connection_type = localhost_connection

    '====================== MongoDB Functions ======================
    Public Function MongoDB_Database_Name()
        Dim online_connectionString As String = "mongodb+srv://admin:admin123@cluster0.aw3fjxd.mongodb.net/?retryWrites=true&w=majority"
        Dim offline_connectionString As String = "mongodb://localhost:27017"
        Dim connectionString As String

        If connection_type = online_connection Then
            connectionString = online_connectionString
        Else
            connectionString = offline_connectionString
        End If

        Dim client As New MongoClient(connectionString)
        Dim database_name As IMongoDatabase = client.GetDatabase("studentassistance")

        Return database_name
    End Function

    Public Function MongoDB_Table_Name(string_table_name As String)
        Dim database_name As IMongoDatabase = MongoDB_Database_Name()
        Dim table_name As IMongoCollection(Of BsonDocument) = database_name.GetCollection(Of BsonDocument)(string_table_name)

        Return table_name
    End Function

    Public Sub MongoDB_Initialize()
        Dim filter = Builders(Of BsonDocument).Filter.And(Builders(Of BsonDocument).Filter.Eq(Of String)("primary_key", "1"))
        Dim existingDocument = tbl_studentassistance_useraccounts.Find(filter).FirstOrDefault()

        If existingDocument Is Nothing Then
            Dim password = Password_Hash("admin123")

            Dim admin_data As New BsonDocument From {
                    {"_id", ObjectId.GenerateNewId()},
                    {"primary_key", "1"},
                    {"rfid_number", ""},
                    {"name", "Administrator"},
                    {"username", "admin"},
                    {"password", password.ToString},
                    {"user_type", "super admin"},
                    {"email", ""}
                }

            tbl_studentassistance_useraccounts.InsertOne(admin_data)
        End If
    End Sub

    '==================== MYSQL FUNCTIONS ===================='
    Public Sub Database_Open()
        ' Database Configuration
        Dim localhost_server = "localhost"
        'Dim online_server = "184.168.101.160"
        Dim online_server = "localhost"
        Dim server As String

        If connection_type = online_connection Then
            server = online_server
        Else
            server = localhost_server
        End If

        Dim port = ""
        Dim username = "all_system_user"
        Dim password = "admin123"
        Dim database = "all_system_database"

        ' Optional Parameters
        Dim pooling = "true"
        Dim connection_timeout = "1000"
        Dim old_guids = "true"

        connection.ConnectionString =
            "server=" & server & ";" &
            "port=" & port & ";" &
            "username=" & username & ";" &
            "password=" & password & ";" &
            "database=" & database & ";" &
            "pooling=" & pooling & ";" &
            "connect timeout=" & connection_timeout & ";" &
            "old guids=" & old_guids & ";"
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
        Catch ex As Exception
            If connection_type = online_connection Then
                MsgBox("Check your internet connection and try again!", MsgBoxStyle.Critical, "Connection Failed")
            Else
                MsgBox("Please run Apache and MySQL connection and try again!", MsgBoxStyle.Critical, "Connection Failed")
            End If

            Login.Close()

            Application.Exit()
        End Try
    End Sub

    Public Sub Database_Close()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub

    '==================== SELECT QUERIES ===================='
    Public Async Sub Load_All_Images()
        Login.Hide()

        Dim result = Await Get_All_Student_Data()

        Dim response_ok As Integer = 0

        If result("response_code") = 200 Then
            response_ok += 1
        End If

        If response_ok = 1 Then
            With Main
                .Show()
                .Mouse_Click(.btn_dashboard)
                .WindowState = FormWindowState.Maximized
            End With

            With Login
                If Not .remember_me.Checked Then
                    .txt_username.Clear()
                    .txt_password.Clear()

                    .remember_me.Checked = False
                End If

                .remember_me.Enabled = True
                .btn_sign_in.Text = "Login"

                .is_loading = False

                Database_Close()

                .Timer1.Stop()
            End With
        End If
    End Sub

    Private Async Function Get_All_Student_Data() As Task(Of Dictionary(Of String, String))
        Dim results As New Dictionary(Of String, String)()
        Dim httpClient As New HttpClient()

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_studentassistance_students` ORDER BY `primary_key` DESC"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        For Each row As DataRow In table.Rows
            Dim db_image_names() As String = {row("indigency_image"), row("psa_image"), row("report_card_image"), row("tor_image"), row("user_image"), row("coe_image"), row("valid_id_image_back"), row("valid_id_image_front")}

            For Each image_name As String In db_image_names
                Dim _image = image_name

                If String.IsNullOrWhiteSpace(image_name) Then
                    image_name = "default_user_image.png"
                End If

                Dim imageUrl As String = connection_type & "cdmstudentassistance.ssystem.online/dist/img/user_upload/" & image_name
                Dim localImagePath As String = "dist/img/user_upload/" & image_name

                If Not File.Exists(localImagePath) Then
                    Try
                        Dim imageBytes As Byte() = Await httpClient.GetByteArrayAsync(imageUrl)
                        File.WriteAllBytes(localImagePath, imageBytes)
                    Catch ex As Exception
                        MsgBox("Check your internet connection and try again!", MsgBoxStyle.Critical, "Connection Failed")

                        Login.Close()

                        Application.Exit()
                    End Try
                End If
            Next
        Next

        results.Add("response_code", 200)

        Return results
    End Function

    Public Function Authenticate(username As String, password As String)
        Dim results As New Dictionary(Of String, String)()

        Dim db_username = ""
        Dim db_password = ""
        Dim db_user_type = ""

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_studentassistance_useraccounts` WHERE `username`='" & username & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        For Each row As DataRow In table.Rows
            db_username = row("username").ToString()
            db_password = row("password").ToString()
            db_user_type = row("user_type").ToString()
        Next

        If db_username = username And Not db_user_type = "student" Then
            Dim isPasswordValid As Boolean = Password_Verify(password, db_password)

            If isPasswordValid Then
                For Each row As DataRow In table.Rows
                    results.Add("response_code", 200)
                    results.Add("primary_key", row("primary_key").ToString())
                    results.Add("rfid_number", row("rfid_number").ToString())
                    results.Add("name", row("name").ToString())
                    results.Add("username", row("username").ToString())
                    results.Add("password", row("password").ToString())
                    results.Add("user_type", row("user_type").ToString())
                    results.Add("email", row("email").ToString())
                Next
            Else
                results.Add("response_code", 404)
            End If
        Else
            results.Add("response_code", 404)
        End If

        Return results
    End Function

    Public Function RFID_Authenticate(rfid_number As String)
        Dim results As New Dictionary(Of String, String)()

        Dim db_rfid_number = ""
        Dim db_user_type = ""

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_studentassistance_useraccounts` WHERE `rfid_number`='" & rfid_number & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        For Each row As DataRow In table.Rows
            db_rfid_number = row("rfid_number").ToString()
            db_user_type = row("user_type").ToString()
        Next

        If db_rfid_number = rfid_number And Not db_user_type = "student" Then
            For Each row As DataRow In table.Rows
                results.Add("response_code", 200)
                results.Add("primary_key", row("primary_key").ToString())
                results.Add("rfid_number", row("rfid_number").ToString())
                results.Add("name", row("name").ToString())
                results.Add("username", row("username").ToString())
                results.Add("password", row("password").ToString())
                results.Add("user_type", row("user_type").ToString())
                results.Add("email", row("email").ToString())
            Next
        Else
            results.Add("response_code", 404)
        End If

        Return results
    End Function

    Public Function Check_Username(username As String, old_username As String)
        Dim results As New Dictionary(Of String, String)()

        Dim db_username = ""

        Database_Open()

        table.Clear()

        With command
            .CommandText = "SELECT `username` FROM `tbl_studentassistance_useraccounts` WHERE `username`='" & username & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        For Each row As DataRow In table.Rows
            db_username = row("username").ToString()
        Next

        Database_Close()

        If Not old_username = username And db_username = username Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function Check_RFID_Number(rfid_number As String, old_rfid_number As String)
        Dim results As New Dictionary(Of String, String)()

        Dim db_rfid_number = ""

        Database_Open()

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_studentassistance_useraccounts` WHERE `rfid_number`='" & rfid_number & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        For Each row As DataRow In table.Rows
            db_rfid_number = row("rfid_number").ToString()
        Next

        Database_Close()

        If Not old_rfid_number = rfid_number And db_rfid_number = rfid_number Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function Get_User_Data(primary_key As String)
        Dim results As New Dictionary(Of String, String)()

        Database_Open()

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_studentassistance_useraccounts` WHERE `primary_key`='" & primary_key & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        For Each row As DataRow In table.Rows
            results.Add("primary_key", row("primary_key").ToString())
            results.Add("rfid_number", row("rfid_number").ToString())
            results.Add("name", row("name").ToString())
            results.Add("username", row("username").ToString())
            results.Add("password", row("password").ToString())
            results.Add("email", row("email").ToString())
            results.Add("user_type", row("user_type").ToString())
        Next

        Database_Close()

        Return results
    End Function

    Public Function Get_Transactions_Data()
        Dim command As New MySqlCommand
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_studentassistance_transactions` ORDER BY `primary_key` DESC"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        Return table
    End Function

    Public Function Search_Transactions_Data(inputted_data As String)
        Dim command As New MySqlCommand
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_studentassistance_transactions` WHERE `date` LIKE '%" & inputted_data & "%' OR `time` LIKE '%" & inputted_data & "%' OR `event` LIKE '%" & inputted_data & "%' ORDER BY `primary_key` DESC"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        Return table
    End Function

    Public Function Get_User_Name(primary_key As String)
        Dim results As New Dictionary(Of String, String)()
        Dim command As New MySqlCommand
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable

        table.Clear()

        With command
            .CommandText = "SELECT `name` FROM `tbl_studentassistance_useraccounts` WHERE `primary_key`='" & primary_key & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        For Each row As DataRow In table.Rows
            results.Add("name", row("name").ToString())
        Next

        Return results
    End Function

    Public Function Get_Applications_Data(category As String, status As String)
        Dim command As New MySqlCommand
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_studentassistance_applications` WHERE `category`='" & category & "' AND `status`='" & status & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        Return table
    End Function

    Public Function Get_Student_Data(login_primary_key As String)
        Dim command As New MySqlCommand
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_studentassistance_students` WHERE `login_primary_key`='" & login_primary_key & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        Return table
    End Function

    Public Function Get_User_RFID_Number(primary_key As String)
        Dim results As New Dictionary(Of String, String)()
        Dim command As New MySqlCommand
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable

        table.Clear()

        With command
            .CommandText = "SELECT `rfid_number` FROM `tbl_studentassistance_useraccounts` WHERE `primary_key`='" & primary_key & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        For Each row As DataRow In table.Rows
            results.Add("rfid_number", row("rfid_number").ToString())
        Next

        Return results
    End Function

    Public Function Get_Notification_Badge(student_primary_key As String)
        Database_Open()

        table.Clear()

        With command
            .CommandText = "SELECT * FROM tbl_studentassistance_notificationbadge WHERE `student_primary_key`='" & student_primary_key & "' AND `status` = 'unclicked'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        Dim rowCount As Integer = CInt(command.ExecuteScalar())

        Database_Close()

        If rowCount > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Specific_Slots_Data(category As String)
        Dim results As New Dictionary(Of String, String)()

        Database_Open()

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_studentassistance_slots` WHERE `category`='" & category & "' ORDER BY `primary_key` ASC"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        For Each row As DataRow In table.Rows
            results.Add("primary_key", row("primary_key").ToString())
            results.Add("category", row("category").ToString())
            results.Add("slot", row("slot").ToString())
        Next

        Database_Close()

        Return results
    End Function

    Public Function Check_Applications()
        Database_Open()

        table.Clear()

        With command
            .CommandText = "SELECT * FROM `tbl_studentassistance_applications`"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        With adapter
            .SelectCommand = command
            .Fill(table)
        End With

        Database_Close()

        Return table
    End Function

    '==================== INSERT QUERIES ===================='
    Public Sub Add_Notification(student_primary_key As String, admin_primary_key As String, date_now As String, time_now As String, message As String, notification_status As String)
        Database_Open()

        With command
            .CommandText = "INSERT INTO `tbl_studentassistance_notifications` (`student_primary_key`, `admin_primary_key`, `date`, `time`, `message`, `status`) VALUES ('" & student_primary_key & "','" & admin_primary_key & "','" & date_now & "','" & time_now & "','" & message & "','" & notification_status & "')"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        Database_Close()

        Dim Document As New BsonDocument() From {
            {"student_primary_key", student_primary_key},
            {"admin_primary_key", admin_primary_key},
            {"date", date_now},
            {"time", time_now},
            {"message", message},
            {"status", notification_status}
        }

        tbl_studentassistance_notifications.InsertOne(Document)
    End Sub

    Public Sub Add_Notification_Badge(status As String, student_primary_key As String)
        Database_Open()

        With command
            .CommandText = "INSERT INTO `tbl_studentassistance_notificationbadge` (`status`, `student_primary_key`) VALUES ('" & status & "','" & student_primary_key & "')"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        Database_Close()

        Dim Document As New BsonDocument() From {
            {"status", status},
            {"student_primary_key", student_primary_key}
        }

        tbl_studentassistance_notificationbadge.InsertOne(Document)
    End Sub

    Public Sub Add_Transaction(student_primary_key As String, date_now As String, time_now As String, transaction_event As String)
        Database_Open()

        With command
            .CommandText = "INSERT INTO `tbl_studentassistance_transactions` (`student_primary_key`, `date`, `time`, `event`) VALUES ('" & student_primary_key & "','" & date_now & "','" & time_now & "','" & transaction_event & "')"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        Database_Close()

        Dim Document As New BsonDocument() From {
            {"student_primary_key", student_primary_key},
            {"date", date_now},
            {"time", time_now},
            {"event", transaction_event}
        }

        tbl_studentassistance_transactions.InsertOne(Document)
    End Sub

    '==================== UPDATE QUERIES ===================='
    Public Sub Update_Notification_Badge(status As String, student_primary_key As String)
        Database_Open()

        With command
            .CommandText = "UPDATE `tbl_studentassistance_notificationbadge` SET `status`='" & status & "' WHERE `student_primary_key`='" & student_primary_key & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        Database_Close()

        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("student_primary_key", student_primary_key)
        Dim update = Builders(Of BsonDocument).Update.Set(Of String)("status", status)

        tbl_studentassistance_notificationbadge.UpdateOne(filter, update)
    End Sub

    Public Sub Update_Account(name As String, rfid_number As String, username As String, password As String, primary_key As String)
        Database_Open()

        With command
            .CommandText = "UPDATE `tbl_studentassistance_useraccounts` SET `name`='" & name & "', `rfid_number`='" & rfid_number & "', `username`='" & username & "', `password`='" & password & "' WHERE `primary_key`='" & primary_key & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        Database_Close()

        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("primary_key", primary_key)
        Dim update = Builders(Of BsonDocument).Update.Set(Of String)("name", name).Set(Of String)("rfid_number", rfid_number).Set(Of String)("username", username).Set(Of String)("password", password)

        tbl_studentassistance_useraccounts.UpdateOne(filter, update)
    End Sub

    Public Sub Update_Application_Admin(date_now As String, time_now As String, admin_primary_key As String, progress As String, status As String, student_primary_key As String)
        Database_Open()

        With command
            .CommandText = "UPDATE `tbl_studentassistance_applications` SET `date`='" & date_now & "', `time`='" & time_now & "', `admin_primary_key`='" & admin_primary_key & "', `progress`='" & progress & "', `status`='" & status & "' WHERE `student_primary_key`='" & student_primary_key & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        Database_Close()

        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("student_primary_key", student_primary_key)
        Dim update = Builders(Of BsonDocument).Update.Set(Of String)("date", date_now).Set(Of String)("time", time_now).Set(Of String)("admin_primary_key", admin_primary_key).Set(Of String)("progress", progress).Set(Of String)("status", status)

        tbl_studentassistance_applications.UpdateOne(filter, update)
    End Sub

    Public Sub Update_Slot_Category(slots As String, category As String)
        Database_Open()

        With command
            .CommandText = "UPDATE `tbl_studentassistance_slots` SET `slot`='" & slots & "' WHERE `category`='" & category & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        Database_Close()

        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("category", category)
        Dim update = Builders(Of BsonDocument).Update.Set(Of String)("slot", slots)

        tbl_studentassistance_slots.UpdateOne(filter, update)
    End Sub

    Public Sub Update_Application(date_now As String, time_now As String, progress As String, status As String, student_primary_key As String)
        Database_Open()

        With command
            .CommandText = "UPDATE `tbl_studentassistance_applications` SET `date`='" & date_now & "', `time`='" & time_now & "', `progress`='" & progress & "', `status`='" & status & "' WHERE `student_primary_key`='" & student_primary_key & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        Database_Close()

        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("student_primary_key", student_primary_key)
        Dim update = Builders(Of BsonDocument).Update.Set(Of String)("date", date_now).Set(Of String)("time", time_now).Set(Of String)("progress", progress).Set(Of String)("status", status)

        tbl_studentassistance_applications.UpdateOne(filter, update)
    End Sub

    Public Sub Update_Application_Status(primary_key As String)
        Database_Open()

        With command
            .CommandText = "UPDATE `tbl_studentassistance_applications` SET `status`='Received' WHERE `primary_key`='" & primary_key & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        Database_Close()

        Dim filter = Builders(Of BsonDocument).Filter.Eq(Of String)("primary_key", primary_key)
        Dim update = Builders(Of BsonDocument).Update.Set(Of String)("status", "Received")

        tbl_studentassistance_applications.UpdateOne(filter, update)
    End Sub

    '==================== PASSWORD FUNCTIONS ===================='
    Private Function Password_Verify(plainTextPassword As String, storedHashedPassword As String) As Boolean
        Dim fixedHashedPassword As String = storedHashedPassword.Replace("$2y$", "$2a$")

        Return Net.BCrypt.Verify(plainTextPassword, fixedHashedPassword)
    End Function

    Public Function Password_Hash(password As String)
        Dim salt As String = Net.BCrypt.GenerateSalt()
        Dim hashedPassword As String = Net.BCrypt.HashPassword(password, salt)

        Return hashedPassword
    End Function

    Public Function MD5_Hash(input As String) As String
        Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(input)
        Dim md5 As MD5 = MD5.Create()
        Dim hashBytes As Byte() = md5.ComputeHash(inputBytes)
        Dim hashStringBuilder As New StringBuilder()

        For Each hashByte As Byte In hashBytes
            hashStringBuilder.Append(hashByte.ToString("x2"))
        Next

        Return hashStringBuilder.ToString()
    End Function
End Module
