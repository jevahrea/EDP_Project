Imports MySql.Data.MySqlClient

Module database

    Public sqlcmd As New MySqlCommand
    Public sqlstr As String
    Public sqlstr2 As String
    Public myreader As MySqlDataReader

    Public serverIpName As String = "localhost"
    Public userId As String = "root"
    Public password As String = "041801"
    Public dbName As String = "edpproject"

    Public DBConnection As New MySqlConnection

    Public Sub ConnectDatabase()

        Dim DBConnectionString As String = "server=" & serverIpName & ";user id=" & userId & ";password=" & password & ";database=" & dbName & ""

        With DBConnection

            Try
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = DBConnectionString
                .Open()
            Catch ex As Exception
                Call DatabaseDisconnect()
            End Try

        End With

    End Sub

    Public Sub DatabaseDisconnect()
        With DBConnection
            .Close()
            .Dispose()
        End With
    End Sub

End Module
