Module GlobalFunctions
    Public Sub ClearMainPanel()
        While MainForm.panelMain.Controls.Count > 0
            MainForm.panelMain.Controls(0).Dispose()
        End While
    End Sub

End Module
