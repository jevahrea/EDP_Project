Imports System.ComponentModel

Public Class AppointmentUpdate
    Private Sub AppointmentUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True

        sqlstr = "SELECT * FROM appointment JOIN patient ON appointment.idpatient = patient.idpatient WHERE idappointment='" & AppointmentForm.datagridPatientAppoinment.Item(0, AppointmentForm.AppGridIndex).Value & "'"

        Try
            ConnectDatabase()
            With sqlcmd
                .Connection = DBConnection
                .CommandType = CommandType.Text
                .CommandText = sqlstr
            End With

            myreader = sqlcmd.ExecuteReader

            If myreader.Read() Then
                txtboxAppointmentID.Text = myreader.Item("idappointment").ToString
                txtboxPatientName.Text = myreader.Item("firstname").ToString + " " + myreader.Item("lastname").ToString
                cmbboxProcedure.Text = myreader.Item("appprocedure").ToString
                txtboxDescription.Text = myreader.Item("description").ToString
                cmbboxStatus.Text = myreader.Item("status").ToString
            End If
            DatabaseDisconnect()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try



    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub AppointmentUpdate_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MainForm.Enabled = True

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If cmbboxStatus.Text = "Re-Scheduled" Then
            sqlstr = "UPDATE appointment  SET appprocedure='" & cmbboxProcedure.Text & "', description='" & txtboxDescription.Text & "',status='" & cmbboxStatus.Text & "',date='" & datetimepickDate.Text & "',time='" & datetimepickTime.Text & "' WHERE idappointment ='" & txtboxAppointmentID.Text & "' "


            With sqlcmd
                Try
                    ConnectDatabase()
                    .Connection = DBConnection
                    .CommandText = sqlstr
                    .ExecuteNonQuery()
                    MsgBox("Data Successfully Updated", MsgBoxStyle.Information, "Information")
                    DatabaseDisconnect()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try

            End With
        Else
            sqlstr = "UPDATE appointment  SET appprocedure='" & cmbboxProcedure.Text & "', description='" & txtboxDescription.Text & "',status='" & cmbboxStatus.Text & "' WHERE idappointment ='" & txtboxAppointmentID.Text & "' "


            With sqlcmd
                Try
                    ConnectDatabase()
                    .Connection = DBConnection
                    .CommandText = sqlstr
                    .ExecuteNonQuery()
                    MsgBox("Data Successfully Updated", MsgBoxStyle.Information, "Information")
                    DatabaseDisconnect()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try

            End With
        End If



        Me.Close()
        AppointmentForm.BtnLoadAppointment_Click(sender, e)
    End Sub

    Private Sub cmbboxStatus_TextChanged(sender As Object, e As EventArgs) Handles cmbboxStatus.TextChanged
        If cmbboxStatus.Text = "Re-Scheduled" Then
            lblDate.Visible = True
            lblTime.Visible = True
            datetimepickDate.Visible = True
            datetimepickTime.Visible = True
        Else
            lblDate.Visible = False
            lblTime.Visible = False
            datetimepickDate.Visible = False
            datetimepickTime.Visible = False
        End If
    End Sub

    Private Sub AppointmentUpdate_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then btnSave_Click(sender, e)
        If e.KeyCode = Keys.Escape Then btnCancel_Click(sender, e)
    End Sub
End Class