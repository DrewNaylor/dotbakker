Public Class aaformMainWindow
    Private Sub buttonAddDotBak_Click(sender As Object, e As EventArgs) Handles buttonAddDotBak.Click
        ' Copy the file in the path textbox and add ".bak#" to it.
        If IO.File.Exists(textboxFilePath.Text) Then
            ' Assign a variable to store the directory.
            Dim DirectoryToLookIn As String = IO.Path.GetDirectoryName(textboxFilePath.Text)

            ' Loop through the files in the directory and find the lowest number.
            ' Some code based on this SO answer:
            ' https://stackoverflow.com/a/2216118
            For Each FileInDir As 
        End If
    End Sub
End Class
