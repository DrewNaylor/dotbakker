Public Class aaformMainWindow
    Private Sub buttonAddDotBak_Click(sender As Object, e As EventArgs) Handles buttonAddDotBak.Click
        ' Copy the file in the path textbox and add ".bak#" to it.
        If IO.File.Exists(textboxFilePath.Text) Then
            ' Loop through the files in the directory and find the lowest number.
            Dim DirectoryToLookIn As String = IO.Path.GetDirectoryName(textboxFilePath.Text)


        End If
    End Sub
End Class
