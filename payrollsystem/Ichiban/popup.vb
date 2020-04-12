Public Class popup

    Dim sql As String

    Private Sub txtsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearch.TextChanged
        jokenselect("SELECT ASSIGNID,EMPID,CLIENTID,EMP_FULLNAME,CLIENT_RATE,ASSIGN_DATE,STARTDATE,ENDDATE FROM tblassign where EMP_FULLNAME LIKE '%" & txtsearch.Text & "%'")
        filltable(DataGridView4, "EmpInfo")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            With Me
                payroll.payEmpID.Text = .DataGridView4.CurrentRow.Cells(1).Value
                payroll.TXTCLIENTID.Text = .DataGridView4.CurrentRow.Cells(2).Value
                payroll.payEmpName.Text = .DataGridView4.CurrentRow.Cells(3).Value.ToString
                payroll.txtClientRate.Text = .DataGridView4.CurrentRow.Cells(4).Value.ToString

            End With

            sql = "select taxid from tblemployee where empid ='" & Me.DataGridView4.CurrentRow.Cells(1).Value & "'"
            jokenfindthis(sql)
            checkresult("Tax")

            Me.Close()
        Catch ex As Exception
            MsgBox("Please select employee from the table!")
        End Try

    End Sub

   
End Class