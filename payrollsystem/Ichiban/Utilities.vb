Public Class Utilities

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim portfolioPath As String = My.Application.Info.DirectoryPath
        FileCopy(Application.StartupPath & "\enterprisedb.mdb", Application.StartupPath & "\backup\enterprisedb.mdb")
        MsgBox("Backup Successful")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim portfolioPath As String = My.Application.Info.DirectoryPath
        If MessageBox.Show("Restoring the database will erase any changes you have made since you last backup. Are you sure you want to do this?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then

            'Restore the database from a backup copy. 
            FileCopy(Application.StartupPath & "\backup\enterprisedb.mdb", Application.StartupPath & "\enterprisedb.mdb")
            MsgBox("Database Restoration Successful")
        End If
    End Sub
End Class