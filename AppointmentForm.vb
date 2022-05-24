Public Class AppointmentForm

    Public AppGridIndex As Integer

    Private Sub txtboxLiveSearch_Leave(sender As Object, e As EventArgs) Handles txtboxLiveSearch.Leave
        txtboxClear(txtboxLiveSearch)
    End Sub



    Private Sub AppointmentForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        BtnLoadAppointment_Click(sender, e)
    End Sub

    Public Sub BtnLoadAppointment_Click(sender As Object, e As EventArgs) Handles BtnLoadAppoinment.Click

        Me.datagridPatientAppoinment.Rows.Clear()

        sqlstr = "SELECT appointment.idappointment, patient.firstname, patient.middlename, patient.lastname, appointment.appprocedure, appointment.description, appointment.date, appointment.time, appointment.status FROM appointment INNER JOIN patient ON patient.idpatient = appointment.idpatient"

        ConnectDatabase()
        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandType = CommandType.Text
                .CommandText = sqlstr

                myreader = database.sqlcmd.ExecuteReader

                While myreader.Read()

                    Me.datagridPatientAppoinment.Rows.Add(New Object() {myreader.Item("idappointment"), myreader.Item("firstname") + " " + myreader.Item("middlename") + " " + myreader.Item("lastname"), myreader.Item("appprocedure"), myreader.Item("description"), myreader.GetDateTime("date").ToString("MM/dd/yyyy"), myreader.Item("time"), myreader.Item("status")})
                End While

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End With

    End Sub

    Private Sub btnSaveAppointment_Click(sender As Object, e As EventArgs) Handles btnSaveAppointment.Click

        sqlstr = "INSERT INTO appointment(idpatient, appprocedure, description, date, time, status, datecreated) VALUES('" & txtboxPatientID.Text & "','" & cmbboxProcedure.Text & "','" & txtboxDescription.Text & "', '" & datetimepickDate.Text & "','" & datetimepickTime.Text & "','Scheduled', '" & Now().ToString("yyyy-MM-dd HH:mm:ss") & "' ) "
        'MsgBox(sqlstr)
        With sqlcmd
            ConnectDatabase()
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

        BtnLoadAppointment_Click(sender, e)

    End Sub

    Private Sub txtboxLiveSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxLiveSearch.TextChanged

        datagridPatientAppoinment.Rows.Clear()
        sqlstr = "SELECT patient.idpatient, firstname, middlename, lastname, appprocedure, description, date, time, status FROM appointment INNER JOIN patient ON patient.idpatient = appointment.idpatient WHERE firstname LIKE '%" & txtboxLiveSearch.Text & "%' OR lastname LIKE '%" & txtboxLiveSearch.Text & "%' OR patient.idpatient Like '%" & txtboxLiveSearch.Text & "%' OR status Like '%" & txtboxLiveSearch.Text & "%' OR appprocedure Like '%" & txtboxLiveSearch.Text & "%'"


        ConnectDatabase()

        With sqlcmd
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = sqlstr
        End With

        myreader = sqlcmd.ExecuteReader
        While myreader.Read()
            Me.datagridPatientAppoinment.Rows.Add(New Object() {myreader.Item("idpatient"), myreader.Item("firstname") + " " + myreader.Item("middlename") + " " + myreader.Item("lastname"), myreader.Item("appprocedure"), myreader.Item("description"), myreader.GetDateTime("date").ToString("MM/dd/yyyy"), myreader.Item("time"), myreader.Item("status")})
        End While

        DatabaseDisconnect()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        MainForm.Enabled = False

        AppGridIndex = datagridPatientAppoinment.CurrentRow.Index

        AppointmentUpdate.Show()
    End Sub

End Class