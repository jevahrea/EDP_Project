Imports System.Net.Mail

Public Class RegisterForm

    Private Sub btnRegisterAccount_Click(sender As Object, e As EventArgs) Handles btnRegisterAccount.Click

        'empty control validation
        Dim txtbox As Control
        Dim grpbox As Control
        For Each grpbox In Me.Controls
            For Each txtbox In grpbox.Controls
                If TypeOf txtbox Is TextBox Then
                    If txtbox.Text = "" Then
                        If Not txtbox Is txtboxMiddleName Then
                            MessageBox.Show("One or more fields have not been completed", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            txtbox.Select()
                            Exit Sub
                        End If
                    End If
                End If
            Next
        Next

        For Each txtbox In Me.Controls
            If TypeOf txtbox Is TextBox Then
                If txtbox.Text = "" Then
                    MessageBox.Show("One or more fields have not been completed", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtbox.Select()
                    Exit Sub
                End If
            End If
        Next

        If cmbboxAccountType.Text = "" Then
            MessageBox.Show("One or more fields have not been completed", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmbboxAccountType.Select()
            Exit Sub
        End If
        'end of validation

        database.sqlstr = "INSERT into employee(idemployee, firstname, middlename, lastname, email, contactno, dateofbirth) VALUES('" & txtboxEmpID.Text & "','" & txtboxFirstName.Text & "','" & txtboxMiddleName.Text & "','" & txtboxLastName.Text & "','" & txtboxEmailAddress.Text & "','" & txtboxMobileNumber.Text & "','" & datepickBirthday.Text & "')"
        database.sqlstr2 = "INSERT into users(username, password, usertype, email, fgtpassquestion, fgtpassanswer) VALUES('" & txtboxUsername.Text & "', '" & txtboxPassword.Text & "','" & cmbboxAccountType.Text & "','" & txtboxEmailAddress.Text & "','" & txtboxQuestion.Text & "','" & txtboxAnswer.Text & "')"

        Dim QueryString As String = String.Concat(sqlstr, ";", sqlstr2)
        'MsgBox(QueryString)
        database.ConnectDatabase()

        Try
            With database.sqlcmd
                .Connection = DBConnection
                .CommandText = QueryString
                .ExecuteNonQuery()
                MsgBox("Registered Successfully", MsgBoxStyle.Information, "Register")
                Me.Close()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        database.DatabaseDisconnect()
    End Sub

    Private Sub txtboxName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxFirstName.KeyPress,
        txtboxMiddleName.KeyPress, txtboxLastName.KeyPress

        If (Not (Asc(e.KeyChar) = 8)) And (Not (Asc(e.KeyChar) = 13)) And (Not (Asc(e.KeyChar) = 27)) And (Not (Asc(e.KeyChar) = 32)) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                MessageBox.Show("Integer not allowed", "Warning")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtboxMobileNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtboxMobileNumber.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Number input only", "Warning")
            e.Handled = True
        End If
    End Sub

    Private Sub chckboxShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxShowPass.CheckedChanged
        txtboxPassword.UseSystemPasswordChar = Not chckboxShowPass.Checked
    End Sub

    Private Sub chckboxShowAns_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxShowAns.CheckedChanged
        txtboxAnswer.UseSystemPasswordChar = Not chckboxShowAns.Checked
    End Sub

    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        Me.Close()
    End Sub

    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Set fixed border
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        'enable key preview to read key events within form
        Me.KeyPreview = True

        txtboxEmpID.Select()

    End Sub

    Private Sub RegisterForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then btnRegisterAccount_Click(sender, e)
        If e.KeyCode = Keys.Escape Then btnCancel_Click(sender, e)
    End Sub

    Private Sub RegisterForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MainForm.Enabled = False Then
            MainForm.Enabled = True
        Else
            If MessageBox.Show("Proceed To Cancel?", "Are you sure?", MessageBoxButtons.YesNoCancel) = DialogResult.Yes Then
                LoginForm.Show()
            Else
                e.Cancel = True
            End If
        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtboxEmailAddress_Leave(sender As Object, e As EventArgs) Handles txtboxEmailAddress.Leave

        Try
            Dim email = New MailAddress(txtboxEmailAddress.Text)
        Catch ex As Exception
            MessageBox.Show("Please enter your email address correctly", "Incorrect Email Entry")
            txtboxEmailAddress.Text = ""
        End Try

    End Sub

End Class