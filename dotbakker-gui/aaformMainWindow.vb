Public Class aaformMainWindow
    Private Sub buttonAddDotBak_Click(sender As Object, e As EventArgs) Handles buttonAddDotBak.Click
        ' Copy the file in the path textbox and add ".bak#" to it.
        If IO.File.Exists(textboxFilePath.Text) Then
            ' Some code based on this SO answer:
            ' https://stackoverflow.com/a/2216118
            ' Other stuff from MSDN:
            ' https://docs.microsoft.com/en-us/dotnet/api/system.io.path.getdirectoryname?view=netframework-4.8

            ' Assign a variable to store the directory.
            Dim DirectoryToLookIn As New IO.DirectoryInfo(IO.Path.GetDirectoryName(textboxFilePath.Text))

            ' Store a list of all the files in the dir.
            Dim FilesList As IO.FileInfo() = DirectoryToLookIn.GetFiles()

            ' FileInfo for later use.
            Dim FileName As IO.FileInfo

            ' Loop through the files in the directory and find the lowest number.
            For Each FileName In FilesList

            Next
        End If
    End Sub
End Class
