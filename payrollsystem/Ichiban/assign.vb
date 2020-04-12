Public Class assign

    Private Sub assign_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_data()
        lblrate.Text = FormatNumber(lblrate.Text, 2)
        ' txtbasicPay.Text = FormatNumber(txtbasicPay.Text, 2)
    End Sub
    Public Sub load_data()
        jokenselect("Select ID, EMPID, LNAME & ', ' & FNAME & ' ' & MI as [Guard Name], AGE, BDAY, BPLACE, HEIGHT, WEIGHT,CONTACT, WORKSTATUS from tblemployee where GPOSITION = 'Guard' and WORKSTATUS = 'Active' and ASSIGN = NO")
        filltable(DataGridView3, "EmpInfo")
    End Sub

    Private Sub DataGridView3_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        Try
            ID.Text = DataGridView3.CurrentRow.Cells(0).Value()
            LBLEMPID.Text = DataGridView3.CurrentRow.Cells(1).Value.ToString
            LBLFULLNAME.Text = DataGridView3.CurrentRow.Cells(2).Value.ToString
            LBLAGE.Text = DataGridView3.CurrentRow.Cells(3).Value()
            LBLEMPSTATUS.Text = DataGridView3.CurrentRow.Cells(7).Value.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
  
    End Sub

  
    
    Private Sub BTNASSIGN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNASSIGN.Click
        jokeninsert("INSERT INTO tblassign(EMPID,CLIENTID,EMP_FULLNAME,CLIENT_RATE,ASSIGN_DATE, STARTDATE,ENDDATE) VALUES('" & LBLEMPID.Text & "','" & LBLCLIENTID.Text & "','" & LBLFULLNAME.Text & "','" & lblrate.Text & "', #" & Today & "#, #" & lblstart.Text & "#,#" & lblend.Text & "#)")
        jokenupdate("UPDATE tblemployee set ASSIGN=1 WHERE ID = " & ID.Text & " ")
        MsgBox("Guard has been assigned!")
        load_data()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(Today)
    End Sub
End Class