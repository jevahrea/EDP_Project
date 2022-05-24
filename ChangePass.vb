
Public Class ChangePass
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click

        Dim grpbox As Control
        Dim txtbox As Control

        For Each grpbox In Me.Controls
            For Each txtbox In grpbox.Controls
                If TypeOf txtbox Is TextBox Then
                    If txtbox.Text = "" Then
                        MessageBox.Show("One or more fields have not been completed")
                        txtbox.Select()
                        Exit Sub
                    End If
                End If
            Next
        Next



        If txtboxNewPass.Text <> txtboxConfirmPass.Text Then
            MessageBox.Show("Password do not match", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        database.sqlstr = "UPDATE users SET password='" & txtboxConfirmPass.Text & "' WHERE username='" & LoginForm.username & "'"

        database.ConnectDatabase()


        With database.sqlcmd
            Try
                .Connection = DBConnection
                .CommandText = database.sqlstr
                .ExecuteNonQuery()
                MsgBox("Password Changed Succesfully", MsgBoxStyle.Information, "Information")
                Me.Close()
                LoginForm.Show()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

            database.DatabaseDisconnect()

        End With

    End Sub

    Private Sub chckboxShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxShowPass.CheckedChanged
        txtboxNewPass.UseSystemPasswordChar = Not chckboxShowPass.Checked
        txtboxConfirmPass.UseSystemPasswordChar = Not chckboxShowPass.Checked
    End Sub

    Private Sub ChangePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set fixed border
        Me.FormBorderStyle = FormBorderStyle.Fixed3D
        'enable key preview to read key events within form
        Me.KeyPreview = True
    End Sub

    Private Sub ChangePass_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then BtnOK_Click(sender, e)
    End Sub

End Class