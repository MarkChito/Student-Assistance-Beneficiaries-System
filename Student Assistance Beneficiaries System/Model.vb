Imports BCrypt
Imports MySql.Data.MySqlClient

Module Model
    Private connection As New MySqlConnection
    Private command As New MySqlCommand
    Private adapter As New MySqlDataAdapter
    Private table As New DataTable

    Private ReadOnly online_connection = "https://"
    Private ReadOnly localhost_connection = "http://localhost/"

    ' Change this when connecting online
    Public ReadOnly connection_type = localhost_connection

    Public url As String = connection_type & "cdmstudentassistance.ssystem.online/"
    Public primary_key As String = ""

    '==================== MYSQL FUNCTIONS ===================='
    Public Sub Database_Open()
        ' Database Configuration
        Dim localhost_server = "localhost"
        Dim online_server = "184.168.101.160"
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
            connection.Open()
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
        connection.Close()
    End Sub

    '==================== SELECT QUERIES ===================='
    Public Function Authenticate(username As String, password As String)
        Dim results As New Dictionary(Of String, String)()

        Dim db_username = ""
        Dim db_password = ""
        Dim db_user_type = ""

        Database_Open()

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

        Database_Close()

        Return results
    End Function

    Public Function RFID_Authenticate(rfid_number As String)
        Dim results As New Dictionary(Of String, String)()

        Dim db_rfid_number = ""
        Dim db_user_type = ""

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

        Database_Close()

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

    '==================== UPDATE QUERIES ===================='
    Public Sub Update_Account(name As String, rfid_number As String, username As String, password As String, primary_key As String)
        Database_Open()

        With command
            .CommandText = "UPDATE `tbl_studentassistance_useraccounts` SET `name`='" & name & "', `rfid_number`='" & rfid_number & "', `username`='" & username & "', `password`='" & password & "' WHERE `primary_key`='" & primary_key & "'"
            .Connection = connection
            .ExecuteNonQuery()
        End With

        Database_Close()
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
End Module
