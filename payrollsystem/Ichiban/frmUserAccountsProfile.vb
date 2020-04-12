Public Class frmUserAccountsProfile

    Public Sub displaymember()
        jokenselect("Select user_id, employee_id, UserName, userusername, userpassword, job_title From tbluseraccounts")
        filltable(DataGridView1, "EmpInfo")

    End Sub

    Private Sub itemdatagrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        lblid.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        txtEmpID.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtname.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        txtuname.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        txtpass.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        cbtype.SelectedItem = DataGridView1.CurrentRow.Cells(5).Value.ToString

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Height = 300
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        If Label6.Text = "Show List of Users" Then
            Me.Height = 500
            displaymember()
            Label6.Text = "Hide list of users"
        ElseIf Label6.Text = "Hide list of users" Then
            Me.Height = 300
            Label6.Text = "Show List of Users"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        clearall(GroupBox1, DataGridView1)
        cbtype.Text = Nothing

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtpass.TextLength < 4 Then

            MsgBox("Password must be more than 8 characters")

        ElseIf txtpass.Text <> txtconfirm.Text Then
            MsgBox("Password Confirmation did not match!", MsgBoxStyle.Information)

        Else
            jokeninsert("INSERT INTO tbluseraccounts ( employee_id, UserName, userusername, userpassword, job_title ) " & _
                 " VALUES('" & txtEmpID.Text & "','" & txtname.Text & "','" & txtuname.Text & "','" & txtpass.Text & "','" & cbtype.SelectedItem & "')")
            displaymember()

        End If


        Button3_Click(sender, e)
    End Sub

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        jokendelete("Delete * from tbluseraccounts where user_id= " & lblid.Text & "")
        displaymember()
        Button3_Click(sender, e)
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click

        If txtpass.Text <> txtconfirm.Text Then
            MsgBox("Password Confirmation did not match!", MsgBoxStyle.Information)
        Else
            jokenupdate("UPDATE tbluseraccounts set UserName ='" & txtname.Text & "' , employee_id = '" & txtEmpID.Text & "', userusername = '" & txtuname.Text & "', userpassword = '" & txtpass.Text & "', job_title= '" & cbtype.SelectedItem & "' where user_id = " & lblid.Text & "")
            displaymember()
        End If
        Button3_Click(sender, e)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    
End Class