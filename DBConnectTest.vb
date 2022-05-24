Imports System.ComponentModel

Public Class DBConnectTest
    Private Sub GetIPaddressForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoginForm.Enabled = False

        Me.FormBorderStyle = FormBorderStyle.Fixed3D
        Me.KeyPreview = True

        txtboxServerIpName.Text = serverIpName
        txtboxUserID.Text = userId
        txtboxPassword.Text = password
        txtboxDBName.Text = dbName

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click



        With DBConnection
            Try

                serverIpName = txtboxServerIpName.Text
                userId = txtboxUserID.Text
                password = txtboxPassword.Text
                dbName = txtboxDBName.Text

                ConnectDatabase()

                If .State = ConnectionState.Open Then
                    MessageBox.Show("Database is connected")
                    Me.Close()
                    LoginForm.Enabled = True
                Else
                    MessageBox.Show("Database is out of reach")
                End If

                DatabaseDisconnect()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End With

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        LoginForm.Enabled = True
    End Sub

    Private Sub DBConnectTest_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        LoginForm.Enabled = True
    End Sub

    Private Sub DBConnectTest_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then btnOK_Click(sender, e)
        If e.KeyCode = Keys.Escape Then btnCancel_Click(sender, e)
    End Sub

End Class