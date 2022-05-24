Public Class UserLogForm
    Private Sub UserLogForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        For index = 0 To 4
            datagridUserLogs.Columns(index).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            datagridUserLogs.Columns(index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Next

        BtnLoadUserLogs_Click(sender, e)

    End Sub

    Private Sub BtnLoadUserLogs_Click(sender As Object, e As EventArgs) Handles BtnLoadUserLogs.Click
        Me.datagridUserLogs.Rows.Clear()

        sqlstr = "SELECT * FROM userlogs ORDER BY dateTimeIn Desc"

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.Text
                .CommandText = sqlstr

                myreader = database.sqlcmd.ExecuteReader

                While myreader.Read()
                    Me.datagridUserLogs.Rows.Add(New Object() {myreader.Item("iduserlogs"), myreader.Item("username"), myreader.Item("usertype"), myreader.Item("dateTimeIn"), myreader.Item("dateTimeOut")})
                End While

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End With

        database.DatabaseDisconnect()
    End Sub

    Private Sub txtboxLiveSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxLiveSearch.TextChanged

        datagridUserLogs.Rows.Clear()

        sqlstr = "SELECT * FROM userlogs WHERE username LIKE '%" & txtboxLiveSearch.Text & "%' OR iduserlogs LIKE '%" & txtboxLiveSearch.Text & "%' OR usertype LIKE '%" & txtboxLiveSearch.Text & "%'"

        ConnectDatabase()
        With sqlcmd
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = sqlstr
        End With

        myreader = sqlcmd.ExecuteReader

        While myreader.Read()
            Me.datagridUserLogs.Rows.Add(New Object() {myreader.Item("iduserlogs"), myreader.Item("username"), myreader.Item("usertype"), myreader.Item("dateTimeIn"), myreader.Item("dateTimeOut")})
        End While

        DatabaseDisconnect()

    End Sub

    Private Sub txtboxLiveSearch_Leave(sender As Object, e As EventArgs) Handles txtboxLiveSearch.Leave
        txtboxClear(txtboxLiveSearch)
    End Sub

End Class