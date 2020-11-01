Module Message
    Public Sub displayError(ByVal message As String)
        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub displayInformation(ByVal title As String, ByVal message As String)
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Module
