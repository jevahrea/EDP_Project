Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True

        Dim accounttype As String = " "

        sqlstr = "SELECT * FROM users WHERE username = '" & LoginForm.username & "' "

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.Text
                .CommandText = sqlstr
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                If myreader.Read() Then
                    accounttype = myreader.Item("usertype")

                End If

                If accounttype = "admin" Then
                    btnEmployee.Visible = True
                    btnUser.Visible = True
                    btnUserLog.Visible = True
                    txtboxUserType.Text = "Administrator"
                Else
                    btnEmployee.Visible = False
                    btnUser.Visible = False
                    btnUserLog.Visible = False
                    txtboxUserType.Text = "Staff"
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try

            DatabaseDisconnect()
        End With

    End Sub

    Private Sub btnPatient_Click(sender As Object, e As EventArgs) Handles btnPatient.Click
        ClearMainPanel()

        With PatTableForm
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = True
            .TopLevel = False
            panelMain.Controls.Add(PatTableForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        ClearMainPanel()

        With EmployeeForm
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = False
            .TopLevel = False
            panelMain.Controls.Add(EmployeeForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        ClearMainPanel()

        With UserAccountForm
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = False
            .TopLevel = False
            panelMain.Controls.Add(UserAccountForm)
            .BringToFront()
            .Show()
        End With


    End Sub

    Private Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click
        ClearMainPanel()

        With AppointmentForm
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = False
            .TopLevel = False
            panelMain.Controls.Add(AppointmentForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnUserLog_Click(sender As Object, e As EventArgs) Handles btnUserLog.Click
        ClearMainPanel()

        With UserLogForm
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill And DockStyle.Bottom
            .AutoSize = False
            .TopLevel = False
            panelMain.Controls.Add(UserLogForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show(" Are you sure you want to quit?", "Are you sure?", MessageBoxButtons.YesNoCancel) = DialogResult.Yes Then
            LoginForm.username = ""

            Dim timenow As String = Now().ToString("yyyy-MM-dd HH:mm:ss")

            sqlstr = "UPDATE userlogs set dateTimeOut = '" & timenow & "' WHERE iduserlogs = '" & LoginForm.iduserlog & "'"

            ConnectDatabase()

            With sqlcmd
                Try
                    .Connection = DBConnection
                    .CommandText = sqlstr
                    .ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try
                DatabaseDisconnect()
            End With

            LoginForm.Show()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

End Class