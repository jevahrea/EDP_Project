Imports System.ComponentModel

Public Class LoginForm
    Public username As String
    Public iduserlog As String
    Public timenow As String
    Public type As String
    Dim txtbox As Control
    Dim grpbox As Control

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        PatTableForm.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        For Each txtbox In Me.Controls
            If TypeOf txtbox Is TextBox Then
                If txtbox.Text = "" Then
                    MessageBox.Show("One or more fields have not been completed", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtbox.Select()
                    Exit Sub
                End If
            End If
        Next

        sqlstr = "SELECT * FROM USERS WHERE username ='" & txtboxUsername.Text & "' AND password ='" & txtboxPassword.Text & "'"

        'MsgBox(sqlstr)

        ConnectDatabase()

        With sqlcmd
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = sqlstr
        End With

        myreader = sqlcmd.ExecuteReader
        If myreader.Read Then
            Me.Hide()
            username = txtboxUsername.Text
            DatabaseDisconnect()


            'USERTYPE
            sqlstr = "SELECT * FROM users WHERE username = '" & username & "' "
            ConnectDatabase()
            With sqlcmd
                Try
                    .Connection = DBConnection
                    .CommandType = CommandType.Text
                    .CommandText = sqlstr
                    'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                    myreader = sqlcmd.ExecuteReader

                    If myreader.Read() Then
                        type = myreader.Item("usertype")
                    End If
                    DatabaseDisconnect()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try
            End With


            'USERLOGS!

            timenow = Now().ToString("yyyy-MM-dd HH:mm:ss")
            iduserlog = Now().ToString("yyyyMMddHHmmss")
            sqlstr = "INSERT INTO userlogs(iduserlogs, username, usertype, dateTimeIn) VALUES('" & iduserlog & "', '" & txtboxUsername.Text & "', '" & type & "', '" & timenow & "')"
            ConnectDatabase()
            With sqlcmd
                Try
                    .Connection = DBConnection
                    .CommandText = sqlstr
                    .ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try
            End With
            DatabaseDisconnect()



            For Each txtbox In Me.Controls
                If TypeOf txtbox Is TextBox Then
                    txtbox.Text = Nothing
                End If
            Next

            'LOGGED IN
            MainForm.Show()
        Else
            MessageBox.Show("Incorrect username or password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        DatabaseDisconnect()






    End Sub

    Private Sub chckboxShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxShowPass.CheckedChanged
        txtboxPassword.UseSystemPasswordChar = Not chckboxShowPass.Checked
    End Sub

    Private Sub lblRegisterAccount_Click(sender As Object, e As EventArgs) Handles lblRegisterAccount.Click

        Me.Hide()
        AdminPass.Show()

    End Sub

    Private Sub lblForgotPass_Click(sender As Object, e As EventArgs) Handles lblForgotPass.Click

        username = InputBox("Enter Username", "Forgot Password")
        If String.IsNullOrEmpty(username) Then
            MsgBox("Invalid Credentials", MsgBoxStyle.Information, "Forgot Password")
            Exit Sub
        End If
        Me.Hide()
        FgtPassForm.Show()

    End Sub

    Private Sub LoginForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MessageBox.Show(" Are you sure you want to quit", "Are you sure?", MessageBoxButtons.YesNoCancel) <> DialogResult.Yes Then
            e.Cancel = True
        End If

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Set fixed border
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D

        txtboxUsername.Select()

    End Sub

    Private Sub LoginForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then btnLogin_Click(sender, e)
    End Sub

    Private Sub btnTestCon_Click(sender As Object, e As EventArgs) Handles btnTestCon.Click

        DBConnectTest.Show()

    End Sub

    Private Sub LoginForm_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        txtboxUsername.Select()
    End Sub

End Class
