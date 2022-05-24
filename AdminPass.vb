Imports System.ComponentModel

Public Class AdminPass
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim txtbox As Control
        For Each txtbox In Me.Controls
            If TypeOf txtbox Is TextBox Then
                If txtbox.Text = "" Then
                    MessageBox.Show("One or more fields have not been completed")
                    txtbox.Select()
                    Exit Sub
                End If
            End If
        Next

        database.sqlstr = "SELECT * FROM USERS WHERE usertype ='admin' AND username ='" & txtboxAdminUsername.Text & "' AND password ='" & txtboxAdminPass.Text & "'"
        'MsgBox(sqlstr)
        database.ConnectDatabase()

        Try
            With database.sqlcmd
                .Connection = database.DBConnection
                .CommandType = CommandType.Text
                .CommandText = database.sqlstr
            End With

            myreader = database.sqlcmd.ExecuteReader
            If myreader.HasRows Then
                Me.Close()
                RegisterForm.Show()
            Else
                MessageBox.Show("Registration is facilitated by admins", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                LoginForm.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "ERROR")
        End Try
        database.DatabaseDisconnect()

    End Sub

    Private Sub chckboxShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxShowPass.CheckedChanged
        txtboxAdminPass.UseSystemPasswordChar = Not chckboxShowPass.Checked
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub AdminPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set Fixed Border
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True

        txtboxAdminUsername.Select()
    End Sub

    Private Sub AdminPass_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then btnSubmit_Click(sender, e)
        If e.KeyCode = Keys.Escape Then btnCancel_Click(sender, e)
    End Sub

    Private Sub groupboxAdminPass_Enter(sender As Object, e As EventArgs) Handles groupboxAdminPass.Enter

    End Sub
End Class