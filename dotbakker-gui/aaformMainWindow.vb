Public Class aaformMainWindow
    Private Sub buttonAddDotBak_Click(sender As Object, e As EventArgs) Handles buttonAddDotBak.Click
        ' Copy the file in the path textbox and add ".bak#" to it.

        ' Trim the quotes from the file path.
        Dim NoQuotes As String = textboxFilePath.Text.Trim(CChar(""""))

        ' Check if the file exists.
        If IO.File.Exists(NoQuotes) Then
            ' Some code based on this SO answer:
            ' https://stackoverflow.com/a/2216118
            ' Other stuff from MSDN:
            ' https://docs.microsoft.com/en-us/dotnet/api/system.io.path.getdirectoryname?view=netframework-4.8

            ' Assign a variable to store the directory.
            Dim DirectoryToLookIn As New IO.DirectoryInfo(IO.Path.GetDirectoryName(NoQuotes))

            ' Store a list of all the files in the dir.
            Dim FilesList As IO.FileInfo() = DirectoryToLookIn.GetFiles()

            ' FileInfo for later use.
            Dim FileName As IO.FileInfo

            ' Current number to store for later.
            Dim CurrentNumber As Integer = 1

            ' Loop through the files in the directory and find the lowest number.
            For Each FileName In FilesList

                ' Check if a file with the current number exists, and
                ' copy it using the new filename if it doesn't.
                If Not IO.File.Exists(DirectoryToLookIn.ToString & "\" & FileName.ToString & ".bak" & CurrentNumber) Then

                    ' Copy the file using the new name.
                    IO.File.Copy(DirectoryToLookIn.ToString & "\" & FileName.ToString,
                                 DirectoryToLookIn.ToString & "\" & FileName.ToString & ".bak" & CurrentNumber)

                    ' Output text.
                    textboxOutput.AppendText("New file path:")
                    textboxOutput.AppendText(DirectoryToLookIn.ToString & "\" & FileName.ToString & ".bak" & CurrentNumber)
                    textboxOutput.AppendText(vbCrLf)

                    ' 
                End If


            Next
        End If
    End Sub
End Class
