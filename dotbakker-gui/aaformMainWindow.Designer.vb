<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aaformMainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.textboxFilePath = New System.Windows.Forms.TextBox()
        Me.buttonBrowse = New System.Windows.Forms.Button()
        Me.buttonAddDotBak = New System.Windows.Forms.Button()
        Me.textboxOutput = New System.Windows.Forms.TextBox()
        Me.OpenFileDialogBrowse = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'textboxFilePath
        '
        Me.textboxFilePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxFilePath.Location = New System.Drawing.Point(13, 13)
        Me.textboxFilePath.Name = "textboxFilePath"
        Me.textboxFilePath.Size = New System.Drawing.Size(334, 20)
        Me.textboxFilePath.TabIndex = 0
        '
        'buttonBrowse
        '
        Me.buttonBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonBrowse.Location = New System.Drawing.Point(353, 13)
        Me.buttonBrowse.Name = "buttonBrowse"
        Me.buttonBrowse.Size = New System.Drawing.Size(75, 23)
        Me.buttonBrowse.TabIndex = 1
        Me.buttonBrowse.Text = "Browse..."
        Me.buttonBrowse.UseVisualStyleBackColor = True
        '
        'buttonAddDotBak
        '
        Me.buttonAddDotBak.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonAddDotBak.Location = New System.Drawing.Point(13, 39)
        Me.buttonAddDotBak.Name = "buttonAddDotBak"
        Me.buttonAddDotBak.Size = New System.Drawing.Size(415, 39)
        Me.buttonAddDotBak.TabIndex = 2
        Me.buttonAddDotBak.Text = "Copy and add "".bak#"""
        Me.buttonAddDotBak.UseVisualStyleBackColor = True
        '
        'textboxOutput
        '
        Me.textboxOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxOutput.Location = New System.Drawing.Point(12, 86)
        Me.textboxOutput.Multiline = True
        Me.textboxOutput.Name = "textboxOutput"
        Me.textboxOutput.ReadOnly = True
        Me.textboxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxOutput.Size = New System.Drawing.Size(416, 173)
        Me.textboxOutput.TabIndex = 3
        '
        'OpenFileDialogBrowse
        '
        Me.OpenFileDialogBrowse.Filter = "All files|*.*"
        Me.OpenFileDialogBrowse.RestoreDirectory = True
        Me.OpenFileDialogBrowse.Title = "Browse"
        '
        'aaformMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(440, 271)
        Me.Controls.Add(Me.textboxOutput)
        Me.Controls.Add(Me.buttonAddDotBak)
        Me.Controls.Add(Me.buttonBrowse)
        Me.Controls.Add(Me.textboxFilePath)
        Me.Name = "aaformMainWindow"
        Me.Text = "dotbakker-gui"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textboxFilePath As TextBox
    Friend WithEvents buttonBrowse As Button
    Friend WithEvents buttonAddDotBak As Button
    Friend WithEvents textboxOutput As TextBox
    Friend WithEvents OpenFileDialogBrowse As OpenFileDialog
End Class
