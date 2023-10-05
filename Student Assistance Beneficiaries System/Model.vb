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

    Public Function Authenticate(username As String, password As String)
        Dim results As New Dictionary(Of String, String)()

        Dim db_username = ""
        Dim db_password = ""

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
        Next

        If db_username = username Then
            Dim isPasswordValid As Boolean = Password_Verify(password, db_password)

            If isPasswordValid Then
                For Each row As DataRow In table.Rows
                    results.Add("response_code", 200)
                    results.Add("primary_key", row("primary_key").ToString())
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

    Private Function Password_Verify(plainTextPassword As String, storedHashedPassword As String) As Boolean
        Dim fixedHashedPassword As String = storedHashedPassword.Replace("$2y$", "$2a$")

        Return Net.BCrypt.Verify(plainTextPassword, fixedHashedPassword)
    End Function

    Public Function RFID_Authenticate(rfid_number As String)
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

        If db_rfid_number = rfid_number Then
            For Each row As DataRow In table.Rows
                results.Add("response_code", 200)
                results.Add("primary_key", row("primary_key").ToString())
            Next
        Else
            results.Add("response_code", 404)
        End If

        Database_Close()

        Return results
    End Function
End Module
