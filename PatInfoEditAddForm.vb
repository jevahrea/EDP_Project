Public Class PatInfoEditAddForm

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim txtbox As Control

        If txtboxPatientID.Visible = False Then

            For Each txtbox In Me.Controls
                If TypeOf txtbox Is TextBox Then
                    If Not txtbox Is txtboxPatientID Then 'exclude Patient id in textbox empty validation
                        If Not txtbox Is txtboxMiddleName Then
                            If txtbox.Text = "" Then
                                MessageBox.Show("One or more fields have not been completed")
                                txtbox.Select()
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            Next

            sqlstr = "Insert into patient(firstname, middlename, lastname, gender, dateofbirth, age, province, city, street, contactno, datecreated) values('" & Me.txtboxFirstName.Text & "', '" & Me.txtboxMiddleName.Text & "', '" & Me.txtboxLastName.Text & "', '" & Me.cmbboxGender.Text & "', '" & Me.datepickBirthday.Text & "', '" & Me.txtboxAge.Text & "', '" & Me.txtboxProvince.Text & "', '" & Me.txtboxCity.Text & "', '" & Me.txtboxStreet.Text & "', '" & Me.txtboxContactNo.Text & "', '" & Me.txtboxDateCreated.Text & "')"
            'MsgBox(sqlstr)
            ConnectDatabase()

            With sqlcmd
                Try
                    .Connection = DBConnection
                    .CommandText = sqlstr
                    .ExecuteNonQuery()
                    MsgBox("Data Successfully Saved", MsgBoxStyle.Information, "Information")
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try
                DatabaseDisconnect()
            End With

        Else

            For Each txtbox In Me.Controls
                If TypeOf txtbox Is TextBox Then
                    If txtbox.Text = "" Then
                        If Not txtbox Is txtboxMiddleName Then
                            MessageBox.Show("One or more fields have not been completed")
                            txtbox.Select()
                            Exit Sub
                        End If
                    End If
                End If
            Next

            sqlstr = "UPDATE patient SET firstname='" & txtboxFirstName.Text & "',middlename='" & txtboxMiddleName.Text & "',lastname='" & txtboxLastName.Text & "',gender='" & cmbboxGender.Text & "',dateofbirth='" & datepickBirthday.Text & "',age='" & txtboxAge.Text & "',province='" & txtboxProvince.Text & "',city='" & txtboxCity.Text & "',street='" & txtboxStreet.Text & "',contactno='" & txtboxContactNo.Text & "',datecreated='" & txtboxDateCreated.Text & "' WHERE idpatient='" & txtboxPatientID.Text & "'"
            'MsgBox(sqlstr)
            ConnectDatabase()

            With sqlcmd
                Try
                    .Connection = DBConnection
                    .CommandText = sqlstr
                    MsgBox("Data Successfully Updated", MsgBoxStyle.Information, "Information")
                    .ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try
                DatabaseDisconnect()
            End With

        End If


        'clear textboxes after edit/save

        For Each txtbox In Me.Controls
            If TypeOf txtbox Is TextBox Then
                txtbox.Text = Nothing
            End If
        Next

        'revert patient id visibility after clicking save
        txtboxPatientID.Visible = True
        lblPatientID.Visible = True

        'enable patienttable form and set focus
        PatTableForm.Enabled = True
        PatTableForm.BtnLoadPatients.Select()

        'refresh table
        PatTableForm.BtnLoadPatients_Click(sender, e)

        Me.Close()

    End Sub

    Private Sub PatInfoEditAddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set Fixed Border
        Me.FormBorderStyle = FormBorderStyle.Fixed3D
        'enable key preview to read key events within form
        Me.KeyPreview = True

    End Sub

    Private Sub txtboxAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtboxAge.KeyPress, txtboxContactNo.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Number input only", "Warning")
            e.Handled = True
        End If
    End Sub

    Private Sub txtboxName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtboxFirstName.KeyPress,
        txtboxMiddleName.KeyPress, txtboxLastName.KeyPress, txtboxProvince.KeyPress, txtboxCity.KeyPress

        If Not (Asc(e.KeyChar) = 8) And (Not (Asc(e.KeyChar) = 13)) And (Not (Asc(e.KeyChar) = 27)) And (Not (Asc(e.KeyChar) = 32)) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                MessageBox.Show("Integer not allowed", "Warning")
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PatInfoEditAddForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.Enabled = True
        PatTableForm.BtnLoadPatients.Select()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub PatInfoEditAddForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then btnSave_Click(sender, e)
        If e.KeyCode = Keys.Escape Then btnCancel_Click(sender, e)
    End Sub

    Private Sub PatInfoEditAddForm_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        txtboxFirstName.Select()

        Dim datenow As DateTime = Now
        txtboxDateCreated.Text = datenow.ToString("yyyy/MM/dd HH:mm:ss")


        If txtboxPatientID.Visible = True Then

            Dim i As Integer
            i = PatTableForm.datagridPatientTable.CurrentRow.Index

            sqlstr = "SELECT * FROM patient WHERE idpatient='" & PatTableForm.datagridPatientTable.Item(0, i).Value & "'"
            'MsgBox(sqlstr)
            ConnectDatabase()

            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.Text
                .CommandText = sqlstr
            End With

            myreader = sqlcmd.ExecuteReader

            If myreader.Read() Then
                txtboxPatientID.Text = myreader.Item("idpatient").ToString
                txtboxFirstName.Text = myreader.Item("firstname").ToString
                txtboxMiddleName.Text = myreader.Item("middlename").ToString
                txtboxLastName.Text = myreader.Item("lastname").ToString
                cmbboxGender.Text = myreader.Item("gender").ToString
                datepickBirthday.Text = myreader.Item("dateofbirth").ToString
                txtboxAge.Text = myreader.Item("age").ToString
                txtboxProvince.Text = myreader.Item("province").ToString
                txtboxCity.Text = myreader.Item("city").ToString
                txtboxStreet.Text = myreader.Item("street").ToString
                txtboxContactNo.Text = myreader.Item("contactno").ToString
            End If

            DatabaseDisconnect()
        End If

    End Sub

End Class