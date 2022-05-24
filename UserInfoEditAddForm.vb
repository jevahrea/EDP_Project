Public Class UserInfoEditAddForm
    Private Sub UserInfoEditAddForm_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        txtboxUsername.Select()

        Dim i As Integer
        i = UserAccountForm.datagridUserTable.CurrentRow.Index

        sqlstr = "SELECT firstname,username,password,fgtpassquestion,fgtpassanswer FROM users,employee WHERE users.email = employee.email AND idusers = '" & UserAccountForm.datagridUserTable.Item(0, i).Value & "'"

        ConnectDatabase()
        With sqlcmd
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = sqlstr
        End With

        myreader = sqlcmd.ExecuteReader

        If myreader.Read() Then
            txtboxEmpName.Text = myreader.Item("firstname").ToString
            txtboxUsername.Text = myreader.Item("username").ToString
            txtboxPassword.Text = myreader.Item("password").ToString
            txtboxQuestion.Text = myreader.Item("fgtpassquestion").ToString
            txtboxAnswer.Text = myreader.Item("fgtpassanswer").ToString
        End If

        DatabaseDisconnect()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim txtbx As Control

        For Each txtbx In Me.Controls
            If TypeOf txtbx Is TextBox Then
                If txtbx.Text = "" Then
                    MessageBox.Show("One or more fields have not been completed")
                    txtbx.Select()
                End If
            End If
        Next

        Dim i As Integer
        i = UserAccountForm.datagridUserTable.CurrentRow.Index

        sqlstr = "UPDATE users SET username='" & txtboxUsername.Text & "',password='" & txtboxPassword.Text & "',fgtpassquestion='" & txtboxQuestion.Text & "',fgtpassanswer='" & txtboxAnswer.Text & "' WHERE idusers='" & UserAccountForm.datagridUserTable.Item(0, i).Value & "'"

        ConnectDatabase()

        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandText = sqlstr
                .ExecuteNonQuery()
                MsgBox("Data Successfully Updated", MsgBoxStyle.Information, "Information")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
            DatabaseDisconnect()
        End With

        'clear textboxes after edit/save

        For Each txtbox In Me.Controls
            If TypeOf txtbox Is TextBox Then
                txtbox.Text = Nothing
            End If
        Next

        'refresh table
        UserAccountForm.BtnLoadEmployee_Click(sender, e)

        Me.Close()

    End Sub

    Private Sub UserInfoEditAddForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.Enabled = True
        UserAccountForm.BtnLoadEmployee.Select()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub UserInfoEditAddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub UserInfoEditAddForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then btnSave_Click(sender, e)
        If e.KeyCode = Keys.Escape Then btnCancel_Click(sender, e)
    End Sub

    Private Sub chckboxShowPass_CheckedChanged_1(sender As Object, e As EventArgs) Handles chckboxShowPass2.CheckedChanged, chckboxShowPass.CheckedChanged
        txtboxPassword.UseSystemPasswordChar = Not chckboxShowPass.Checked
        txtboxAnswer.UseSystemPasswordChar = Not chckboxShowPass2.Checked
    End Sub



End Class