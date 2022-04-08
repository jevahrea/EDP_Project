Imports MySql.Data.MySqlClient

Public Class UserAccountForm
    Private Sub UserAccountForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        For index = 0 To 7
            datagridUserTable.Columns(index).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            datagridUserTable.Columns(index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Next
        BtnLoadEmployee_Click(sender, e)

    End Sub

    Public Sub BtnLoadEmployee_Click(sender As Object, e As EventArgs) Handles BtnLoadEmployee.Click
        Me.datagridUserTable.Rows.Clear()

        sqlstr = "SELECT idusers,firstname,lastname,username,password,usertype,users.email,fgtpassquestion,fgtpassanswer FROM users,employee WHERE users.email = employee.email"

        ConnectDatabase()

        With sqlcmd

            Try
                .Connection = DBConnection
                .CommandType = CommandType.Text
                .CommandText = sqlstr

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()
                    Me.datagridUserTable.Rows.Add(New Object() {myreader.Item("idusers"), myreader.Item("firstname") + " " + myreader.Item("lastname"), myreader.Item("username"), myreader.Item("password"), myreader.Item("usertype"), myreader.Item("email"), myreader.Item("fgtpassquestion"), myreader.Item("fgtpassanswer")})
                End While

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try

            DatabaseDisconnect()


        End With

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        MainForm.Enabled = False

        UserInfoEditAddForm.Show()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim i As Integer
        i = Me.datagridUserTable.CurrentRow.Index

        UserInfoEditAddForm.Show()
        sqlstr = "DELETE from users WHERE idusers ='" & Me.datagridUserTable.Item(0, i).Value & "'"

        With sqlcmd
            Try

                If MessageBox.Show("Are you sure you want to delete this USER with ID '" & Me.datagridUserTable.Item(0, i).Value & "'", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) <> DialogResult.Yes Then
                    Me.Enabled = True
                    Me.BtnLoadEmployee.Select()
                    UserInfoEditAddForm.Close()
                    Exit Sub
                Else
                    ConnectDatabase()
                    .Connection = DBConnection
                    .CommandText = sqlstr
                    .ExecuteNonQuery()
                    MsgBox("Data Successfully Deleted", MsgBoxStyle.Information, "Information")
                    Me.Enabled = True
                    Me.BtnLoadEmployee.Select()
                    UserInfoEditAddForm.Close()
                    DatabaseDisconnect()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try

        End With
        Me.BtnLoadEmployee_Click(sender, e)
    End Sub

    Private Sub txtboxLiveSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxLiveSearch.TextChanged

        datagridUserTable.Rows.Clear()
        sqlstr = "SELECT * FROM users INNER JOIN employee ON users.email = employee.email WHERE lastname LIKE '%" & txtboxLiveSearch.Text & "%' OR firstname LIKE '%" & txtboxLiveSearch.Text & "%' OR username LIKE '%" & txtboxLiveSearch.Text & "%' OR idusers Like '%" & txtboxLiveSearch.Text & "%' AND users.email = employee.email"

        ConnectDatabase()
        With sqlcmd
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = sqlstr
        End With

        myreader = sqlcmd.ExecuteReader
        While myreader.Read()
            Me.datagridUserTable.Rows.Add(New Object() {myreader.Item("idusers"), myreader.Item("firstname") + " " + myreader.Item("lastname"), myreader.Item("username"), myreader.Item("password"), myreader.Item("usertype"), myreader.Item("email"), myreader.Item("fgtpassquestion"), myreader.Item("fgtpassanswer")})
        End While
        DatabaseDisconnect()

    End Sub

    Private Sub txtboxLiveSearch_Leave(sender As Object, e As EventArgs) Handles txtboxLiveSearch.Leave
        txtboxClear(txtboxLiveSearch)
    End Sub
End Class