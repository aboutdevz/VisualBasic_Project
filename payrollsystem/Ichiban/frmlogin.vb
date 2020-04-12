

Public Class frmlogin

    Dim sql As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        sql = "select * from tbluseraccounts where userusername ='" & txtusername.Text & "' and userpassword = '" & txtpassword.Text & "'"
        jokenfindthis(sql)
        checkresult("Login")

    End Sub
End Class