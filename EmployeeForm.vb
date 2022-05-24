Imports MySql.Data.MySqlClient

Public Class EmployeeForm

    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        For index = 0 To 4
            datagridEmployeeTable.Columns(index).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            datagridEmployeeTable.Columns(index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Next
        BtnLoadEmployee_Click(sender, e)

        'set fixed border
        Me.FormBorderStyle = FormBorderStyle.Fixed3D
        'enable key preview to read key events within form
        Me.KeyPreview = True

        Dim accounttype As String = " "

        sqlstr = "SELECT * FROM users WHERE username = '" & LoginForm.username & "' "


    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim i As Integer
        i = Me.datagridEmployeeTable.CurrentRow.Index

        EmpInfoEditAddForm.Show()
        sqlstr = "DELETE userlogs FROM userlogs
                    JOIN users ON users.username = userlogs.username
                    JOIN employee ON employee.email = users.email
                  WHERE idemployee = '" & datagridEmployeeTable.Item(0, i).Value & "';

                  DELETE users FROM users
                    JOIN employee ON employee.email = users.email
                  WHERE idemployee = '" & datagridEmployeeTable.Item(0, i).Value & "';

                  DELETE FROM employee
                  WHERE idemployee = '" & datagridEmployeeTable.Item(0, i).Value & "';"
        'MsgBox(sqlstr)

        With sqlcmd

            Try
                If MessageBox.Show("Are you sure you want to delete this employee with ID '" & EmpInfoEditAddForm.txtboxEmployeeID.Text & "' and its corresponding USERS and USERLOGS data?", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) <> DialogResult.Yes Then
                    Me.Enabled = True
                    Me.BtnLoadEmployee.Select()
                    EmpInfoEditAddForm.Hide()
                    Exit Sub
                Else
                    ConnectDatabase()
                    .Connection = DBConnection
                    .CommandText = sqlstr
                    .ExecuteNonQuery()
                    MsgBox("Data Successfully Deleted", MsgBoxStyle.Information, "Information")
                    Me.Enabled = True
                    Me.BtnLoadEmployee.Select()
                    EmpInfoEditAddForm.Hide()
                    DatabaseDisconnect()
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try

        End With

        'refresh table
        Me.BtnLoadEmployee_Click(sender, e)

    End Sub


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        'Disable main form when edit form is showed 
        MainForm.Enabled = False
        EmpInfoEditAddForm.Show()

    End Sub

    Public Sub BtnLoadEmployee_Click(sender As Object, e As EventArgs) Handles BtnLoadEmployee.Click

        Me.datagridEmployeeTable.Rows.Clear()

        sqlstr = "SELECT * FROM employee"

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.Text
                .CommandText = sqlstr

                myreader = database.sqlcmd.ExecuteReader

                While myreader.Read()
                    Me.datagridEmployeeTable.Rows.Add(New Object() {myreader.Item("idemployee"), myreader.Item("firstname"), myreader.Item("middlename"), myreader.Item("lastname"), myreader.Item("email"), myreader.Item("contactno"), myreader.GetDateTime("dateofbirth").ToString("MM/dd/yyyy")})
                End While

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End With

        database.DatabaseDisconnect()

    End Sub


    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        MainForm.Enabled = False

        RegisterForm.Show()

    End Sub


    Private Sub txtboxLiveSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxLiveSearch.TextChanged

        datagridEmployeeTable.Rows.Clear()

        sqlstr = "SELECT * FROM employee WHERE firstname LIKE '%" & txtboxLiveSearch.Text & "%' OR lastname LIKE '%" & txtboxLiveSearch.Text & "%' OR idemployee LIKE '%" & txtboxLiveSearch.Text & "%'"

        ConnectDatabase()
        With sqlcmd
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = sqlstr
        End With

        myreader = sqlcmd.ExecuteReader

        While myreader.Read()
            Me.datagridEmployeeTable.Rows.Add(New Object() {myreader.Item("idemployee"), myreader.Item("firstname"), myreader.Item("middlename"), myreader.Item("lastname"), myreader.Item("email"), myreader.Item("contactno"), myreader.GetDateTime("dateofbirth").ToString("MM/dd/yyyy")})
        End While

        DatabaseDisconnect()

    End Sub

    Private Sub txtboxLiveSearch_Leave(sender As Object, e As EventArgs) Handles txtboxLiveSearch.Leave
        txtboxClear(txtboxLiveSearch)
    End Sub
End Class