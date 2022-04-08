Public Class AppointmentForm
    Private Sub txtboxLiveSearch_Leave(sender As Object, e As EventArgs) Handles txtboxLiveSearch.Leave
        txtboxClear(txtboxLiveSearch)
    End Sub
End Class