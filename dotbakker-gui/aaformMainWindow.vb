Public Class aaformMainWindow
    Private Sub buttonAddDotBak_Click(sender As Object, e As EventArgs) Handles buttonAddDotBak.Click
        ' Copy the file in the path textbox and add ".bak#" to it.
        If IO.File.Exists(textboxFilePath.Text) Then

        End If
    End Sub
End Class
