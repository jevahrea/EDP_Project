
Imports System.ComponentModel

Public Class PatTableForm

    Public PatGridIndex As Integer

    Public Sub BtnLoadPatients_Click(sender As Object, e As EventArgs) Handles BtnLoadPatients.Click
        Me.datagridPatientTable.Rows.Clear()

        sqlstr = "SELECT * FROM patient"

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.Text
                .CommandText = sqlstr
                'MsgBox("Successful", MsgBoxStyle.Information, "Information")

                myreader = sqlcmd.ExecuteReader

                While myreader.Read()
                    Me.datagridPatientTable.Rows.Add(New Object() {myreader.Item("idpatient"), myreader.Item("firstname"), myreader.Item("lastname"), myreader.Item("gender"), myreader.GetDateTime("dateofbirth").ToString("MM/dd/yyyy"), myreader.Item("age"), myreader.Item("street"), myreader.Item("contactno"), myreader.Item("datecreated")})
                End While

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End With



        DatabaseDisconnect()

    End Sub

    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click
        MainForm.Enabled = False

        'Hide patient ID when adding new patient
        PatInfoEditAddForm.lblPatientID.Visible = False
        PatInfoEditAddForm.txtboxPatientID.Visible = False

        PatInfoEditAddForm.Show()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Disable patient table form when edit form is showed
        MainForm.Enabled = False
        PatInfoEditAddForm.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim i As Integer
        i = Me.datagridPatientTable.CurrentRow.Index

        PatInfoEditAddForm.Show()
        sqlstr = "DELETE from patient WHERE idpatient = " & Me.datagridPatientTable.Item(0, i).Value & ""
        'MsgBox(sqlstr)


        With sqlcmd
            Try
                'MsgBox(sqlstr)
                If MessageBox.Show("Are you sure you want to delete this patient with ID '" & PatInfoEditAddForm.txtboxPatientID.Text & "'", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) <> DialogResult.Yes Then
                    Me.Enabled = True
                    Me.BtnLoadPatients.Select()
                    PatInfoEditAddForm.Hide()
                    Exit Sub
                Else
                    ConnectDatabase()
                    .Connection = DBConnection
                    .CommandText = sqlstr
                    .ExecuteNonQuery()
                    MsgBox("Data Successfully Deleted", MsgBoxStyle.Information, "Information")
                    Me.Enabled = True
                    Me.BtnLoadPatients.Select()
                    PatInfoEditAddForm.Hide()
                    DatabaseDisconnect()
                End If


            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try

        End With

        'refresh table
        Me.BtnLoadPatients_Click(sender, e)

    End Sub

    Private Sub PatTableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For index = 0 To 8
            datagridPatientTable.Columns(index).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
            datagridPatientTable.Columns(index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Next

        'MsgBox(LoginForm.username)
        BtnLoadPatients_Click(sender, e)

        'set fixed border
        Me.FormBorderStyle = FormBorderStyle.Fixed3D
        'enable key preview to read key events within form
        Me.KeyPreview = True

        Dim accounttype As String = " "

        sqlstr = "Select * from users Where username = '" & LoginForm.username & "' "

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
                    btnDelete.Visible = True
                Else
                    btnDelete.Visible = False
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try

            DatabaseDisconnect()
        End With

    End Sub

    Private Sub txtboxLiveSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxLiveSearch.TextChanged

        datagridPatientTable.Rows.Clear()

        sqlstr = "SELECT * FROM patient WHERE firstname LIKE '%" & txtboxLiveSearch.Text & "%' OR lastname LIKE '%" & txtboxLiveSearch.Text & "%' OR idpatient Like '%" & txtboxLiveSearch.Text & "%'"

        ConnectDatabase()

        With sqlcmd
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = sqlstr
        End With

        myreader = sqlcmd.ExecuteReader
        While myreader.Read()
            Me.datagridPatientTable.Rows.Add(New Object() {myreader.Item("idpatient"), myreader.Item("firstname"), myreader.Item("lastname"), myreader.Item("gender"), myreader.GetDateTime("dateofbirth").ToString("MM/dd/yyyy"), myreader.Item("age"), myreader.Item("street"), myreader.Item("contactno"), myreader.Item("datecreated")})
        End While
        DatabaseDisconnect()

    End Sub


    Private Sub PatTableForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MessageBox.Show(" Are you sure you want to quit?", "Are you sure?", MessageBoxButtons.YesNoCancel) = DialogResult.Yes Then
            LoginForm.username = ""
            LoginForm.Show()
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub PatTableForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub txtboxLiveSearch_Leave(sender As Object, e As EventArgs) Handles txtboxLiveSearch.Leave
        txtboxClear(txtboxLiveSearch)
    End Sub

    Private Sub btnAddAppointment_Click(sender As Object, e As EventArgs) Handles btnAddAppointment.Click

        PatGridIndex = datagridPatientTable.CurrentRow.Index

        If MessageBox.Show("Do you want to add appointment for '" & Me.datagridPatientTable.Item(1, PatGridIndex).Value & "' ", "Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then

            'ClearMainPanel()

            sqlstr = "SELECT * FROM patient WHERE idpatient='" & Me.datagridPatientTable.Item(0, PatGridIndex).Value & "'"


            Try
                ConnectDatabase()
                With sqlcmd
                    .Connection = DBConnection
                    .CommandType = CommandType.Text
                    .CommandText = sqlstr
                End With

                myreader = sqlcmd.ExecuteReader

                If myreader.Read() Then
                    AppointmentForm.txtboxPatientID.Text = myreader.Item("idpatient").ToString
                    AppointmentForm.txtboxPatientName.Text = myreader.Item("firstname").ToString + " " + myreader.Item("lastname").ToString
                End If
                DatabaseDisconnect()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try


            With AppointmentForm
                .WindowState = FormWindowState.Maximized
                .Dock = DockStyle.Fill And DockStyle.Bottom
                .AutoSize = False
                .TopLevel = False
                MainForm.panelMain.Controls.Add(AppointmentForm)
                .BringToFront()
                .Show()
            End With
        Else
            Exit Sub
        End If
    End Sub

End Class