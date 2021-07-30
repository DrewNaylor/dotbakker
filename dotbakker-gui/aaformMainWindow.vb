' dotbakker-gui - Copy a file and append ".bak#" to it, where
'                 "#" is the lowest number that doesn't have
'                 a filename that exists in the directory yet.
' Copyright (C) 2021 Drew Naylor
' (Note that the copyright years include the years left out by the hyphen.)
'
' This file is a part of the dotbakker project.
'
'
'   Licensed under the Apache License, Version 2.0 (the "License");
'   you may not use this file except in compliance with the License.
'   You may obtain a copy of the License at
'
'     http://www.apache.org/licenses/LICENSE-2.0
'
'   Unless required by applicable law or agreed to in writing, software
'   distributed under the License is distributed on an "AS IS" BASIS,
'   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
'   See the License for the specific language governing permissions and
'   limitations under the License.



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
                If Not FileIO.FileSystem.FileExists(DirectoryToLookIn.ToString & NoQuotes.Replace(DirectoryToLookIn.ToString, String.Empty) & ".bak" & CurrentNumber) Then

                    ' Copy the file using the new name.
                    FileIO.FileSystem.CopyFile(DirectoryToLookIn.ToString & NoQuotes.Replace(DirectoryToLookIn.ToString, String.Empty),
                                 DirectoryToLookIn.ToString & NoQuotes.Replace(DirectoryToLookIn.ToString, String.Empty) & ".bak" & CurrentNumber)

                    ' Output text.
                    textboxOutput.AppendText("New file path:" & vbCrLf)
                    textboxOutput.AppendText(DirectoryToLookIn.ToString & NoQuotes.Replace(DirectoryToLookIn.ToString, String.Empty) & ".bak" & CurrentNumber)
                    textboxOutput.AppendText(vbCrLf)

                    ' Exit the For loop to prevent copying to more files than intended.
                    Exit For

                Else

                    ' Increase integer if the file exists.
                    CurrentNumber = CurrentNumber + 1
                End If


            Next
        End If
    End Sub

    Private Sub buttonBrowse_Click(sender As Object, e As EventArgs) Handles buttonBrowse.Click
        ' Get the file from the OpenFileDialog.

        If OpenFileDialogBrowse.ShowDialog = DialogResult.OK Then
            ' Put the filepath into the textbox.
            textboxFilePath.Text = OpenFileDialogBrowse.FileName
        End If
    End Sub
End Class
