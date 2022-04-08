Imports MySql.Data.MySqlClient

Public Class EmpInfoEditAddForm

    Private Sub EmpInfoEditAddForm_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        txtboxEmployeeID.Select()

        Dim i As Integer
        i = EmployeeForm.datagridEmployeeTable.CurrentRow.Index

        sqlstr = "SELECT * FROM employee WHERE idemployee = '" & EmployeeForm.datagridEmployeeTable.Item(0, i).Value & "'"

        ConnectDatabase()
        With sqlcmd
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = sqlstr
        End With

        myreader = sqlcmd.ExecuteReader

        If myreader.Read() Then
            txtboxEmployeeID.Text = myreader.Item("idemployee").ToString
            txtboxFirstName.Text = myreader.Item("firstname").ToString
            txtboxMiddleName.Text = myreader.Item("middlename").ToString
            txtboxLastName.Text = myreader.Item("lastname").ToString
            datepickBirthday.Text = myreader.Item("dateofbirth").ToString
            txtboxContactNo.Text = myreader.Item("contactno").ToString
            txtboxEmailAdd.Text = myreader.Item("email").ToString
        End If

        DatabaseDisconnect()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim txtbx As Control

        For Each txtbx In Me.Controls
            If TypeOf txtbx Is TextBox Then
                If txtbx.Text = "" Then
                    If Not txtbx Is txtboxMiddleName Then
                        MessageBox.Show("One or more fields have not been completed")
                        txtbx.Select()
                        Exit Sub
                    End If
                End If
            End If
        Next

        Dim i As Integer
        i = EmployeeForm.datagridEmployeeTable.CurrentRow.Index

        sqlstr = "UPDATE employee SET firstname='" & txtboxFirstName.Text & "', middlename='" & txtboxMiddleName.Text & "',lastname='" & txtboxLastName.Text & "',email='" & txtboxEmailAdd.Text & "',contactno='" & txtboxContactNo.Text & "',dateofbirth='" & datepickBirthday.Text & "' WHERE idemployee = '" & txtboxEmployeeID.Text & "'"
        'MsgBox(sqlstr)
        ConnectDatabase()

        With sqlcmd
            Try
                .Connection = DBConnection
                .CommandText = sqlstr
                .ExecuteNonQuery()
                MsgBox("Data Successfully Updated", MsgBoxStyle.Information, "Information")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
            DatabaseDisconnect()
        End With

        'clear textboxes after edit/save

        For Each txtbox In Me.Controls
            If TypeOf txtbox Is TextBox Then
                txtbox.Text = Nothing
            End If
        Next

        'refresh table
        EmployeeForm.BtnLoadEmployee_Click(sender, e)

        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub EmpInfoEditAddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub EmpInfoEditAddForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then btnSave_Click(sender, e)
        If e.KeyCode = Keys.Escape Then btnCancel_Click(sender, e)
    End Sub

    'Private Sub EmpInfoEditAddForm_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
    '    Me.Close()
    'End Sub

    Private Sub EmpInfoEditAddForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MainForm.Enabled = True
        EmployeeForm.BtnLoadEmployee.Select()

    End Sub

    Private Sub EmpInfoEditAddForm_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        'Me.Close()
    End Sub
End Class