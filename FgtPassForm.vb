Public Class FgtPassForm
    Private Sub FgtPassForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'set fixed border
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        'enable key preview to read key events within form
        Me.KeyPreview = True

        txtboxAnswer.Select()


        sqlstr = "SELECT * FROM users WHERE username='" & LoginForm.username & "'"

        ConnectDatabase()

        Try
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.Text
                .CommandText = sqlstr
            End With

            myreader = sqlcmd.ExecuteReader
            If myreader.Read() Then
                txtboxQuestion.Text = myreader("fgtpassquestion").ToString
            Else
                MessageBox.Show("Account doesn't exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                LoginForm.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "ERROR")
        End Try

        DatabaseDisconnect()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

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

        sqlstr = "SELECT * FROM users WHERE username='" & LoginForm.username & "'"

        ConnectDatabase()

        Try
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.Text
                .CommandText = sqlstr
            End With

            myreader = sqlcmd.ExecuteReader
            If myreader.Read() Then
                If txtboxAnswer.Text = myreader("fgtpassanswer").ToString Then
                    Me.Close()
                    ChangePass.Show()
                Else
                    MessageBox.Show("Wrong Answer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "ERROR")
        End Try

        DatabaseDisconnect()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub FgtPassForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then btnOK_Click(sender, e)
        If e.KeyCode = Keys.Escape Then btnCancel_Click(sender, e)
    End Sub

End Class