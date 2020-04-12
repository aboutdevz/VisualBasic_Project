Public Class employee

    Dim sql As String

    Private Sub employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Timer1.Start()

        'jokenselect("SELECT EMPID AS [EMPLOYEE ID],(LNAME & ', ' &  FNAME   ) AS [EMPLOYEE NAME],GENDER,AGE,BDAY AS [BIRTHDAY],BPLACE AS [BIRTH PALCE],SP_ADDRESS AS [ADDRESS] FROM tblemployee where ASSIGN = NO")
        'filltable(dtgEmplist, "EmpInfo")
        load_basic_info()

        jokenselect("SELECT tblemployee.*, tblempbackgrd.* FROM tblempbackgrd INNER JOIN tblemployee ON tblempbackgrd.EMPID = tblemployee.EMPID where WORKSTATUS = 'Active'")
        filltable(DataGridView1, "EmpPic")

    End Sub

    Public Sub load_basic_info()
        jokenselect("SELECT COUNT(*) FROM tblemployee")
        filltotal_employee()

        jokenselect("SELECT COUNT(*) FROM tblemployee where WORKSTATUS = 'Active'")
        filltotal_activeemployee()
        jokenselect("SELECT COUNT(*) FROM tblemployee where WORKSTATUS = 'Inactive'")
        filltotal_inactiveemployee()
        jokenselect("SELECT COUNT(*) FROM tblemployee where ASSIGN = YES")
        filltotal_onduty()

    End Sub

   

    Private Sub BTNNEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNNEW.Click
        newemployee.Show()
        Me.Close()

    End Sub


    Private Sub dtgEmplist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        newemployee.Show()
        newemployee.txtemp_id.Text = DataGridView1.CurrentRow.Cells(0).Value

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label3.Text = TimeOfDay
        Label9.Text = Today
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If lblEMployeeID.Text = "EMployeeID" Then
            MsgBox("Please Select employee to Deactivate!")
        Else
            jokenupdate("UPDATE tblemployee set WORKSTATUS='Inactive' where ID=" & Val(lblEMployeeID.Text) & " ")
            Call employee_Load(sender, e)
            lblEMployeeID.Text = "EMployeeID"
        End If
      
    End Sub

    

    Private Sub TXTSEARCH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTSEARCH.TextChanged
        jokenselect("SELECT tblemployee.*, tblempbackgrd.* FROM tblempbackgrd INNER JOIN tblemployee ON tblempbackgrd.EMPID = tblemployee.EMPID WHERE tblemployee.EMPID LIKE '%" & TXTSEARCH.Text & "%' OR LNAME LIKE '%" & TXTSEARCH.Text & "%' OR FNAME LIKE '%" & TXTSEARCH.Text & "%' AND ASSIGN = NO")
        filltable(DataGridView1, "EmpPic")
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        frmIndividualprofile.Show()

        With frmIndividualprofile



            .Label40.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
            .Label35.Text = DataGridView1.CurrentRow.Cells(23).Value.ToString

            .Label1.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
            .txtemp_id.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString

            .txtlname.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
            .txtfname.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
            .txtmname.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString

            If DataGridView1.CurrentRow.Cells(5).Value.ToString = "Male" Then
                .rdomale.Select()
            Else
                .rdofemale.Select()
            End If

            .txtage.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
            .dtpbdate.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
            .txtbplace.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString

            .txtHeight.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
            .txtweight.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
            .cbocivil.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString
            .txtContact.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString
            .txtreligon.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString
            .txtnamSpouse.Text = DataGridView1.CurrentRow.Cells(14).Value.ToString
            .txtsadd.Text = DataGridView1.CurrentRow.Cells(15).Value.ToString
            .txtcitizen.Text = DataGridView1.CurrentRow.Cells(16).Value.ToString
            .dtpHiredate.Text = DataGridView1.CurrentRow.Cells(17).Value.ToString
            .cboworkstat.Text = DataGridView1.CurrentRow.Cells(18).Value.ToString
            .cbpositon.Text = DataGridView1.CurrentRow.Cells(19).Value.ToString

            If DataGridView1.CurrentRow.Cells(21).Value.ToString = "Z" Then
                .cbocivil.Text = "Zero Exemption"
                .rbdep0.Select()
            ElseIf DataGridView1.CurrentRow.Cells(21).Value.ToString = "S" Then
                .cbocivil.Text = "Single"
                .rbdep0.Select()
            ElseIf DataGridView1.CurrentRow.Cells(21).Value.ToString = "M" Then
                .cbocivil.Text = "Single"
                .rbdep0.Select()
            ElseIf DataGridView1.CurrentRow.Cells(21).Value.ToString = "S1" Then
                .cbocivil.Text = "Single"
                .rbdep1.Select()
            ElseIf DataGridView1.CurrentRow.Cells(21).Value.ToString = "S2" Then
                .cbocivil.Text = "Single"
                .rbdep2.Select()
            ElseIf DataGridView1.CurrentRow.Cells(21).Value.ToString = "S3" Then
                .cbocivil.Text = "Single"
                .rbdep3.Select()
            ElseIf DataGridView1.CurrentRow.Cells(21).Value.ToString = "S4" Then
                .cbocivil.Text = "Single"
                .rbdep4.Select()
            ElseIf DataGridView1.CurrentRow.Cells(21).Value.ToString = "M1" Then
                .cbocivil.Text = "Married"
                .rbdep1.Select()
            ElseIf DataGridView1.CurrentRow.Cells(21).Value.ToString = "M2" Then
                .cbocivil.Text = "Married"
                .rbdep2.Select()
            ElseIf DataGridView1.CurrentRow.Cells(21).Value.ToString = "M3" Then
                .cbocivil.Text = "Married"
                .rbdep3.Select()
            ElseIf DataGridView1.CurrentRow.Cells(21).Value.ToString = "M4" Then
                .cbocivil.Text = "Married"
                .rbdep4.Select()
            End If


            .txtmothername.Text = DataGridView1.CurrentRow.Cells(25).Value.ToString
            .txtmotheradd.Text = DataGridView1.CurrentRow.Cells(26).Value.ToString
            .txtfathername.Text = DataGridView1.CurrentRow.Cells(27).Value.ToString
            .txtfatheradd.Text = DataGridView1.CurrentRow.Cells(28).Value.ToString
            .txtelem.Text = DataGridView1.CurrentRow.Cells(29).Value.ToString
            .txtelem_year.Text = DataGridView1.CurrentRow.Cells(30).Value.ToString
            .txthschool.Text = DataGridView1.CurrentRow.Cells(31).Value.ToString
            .txthschool_yeAR.Text = DataGridView1.CurrentRow.Cells(32).Value.ToString
            .txtcollege.Text = DataGridView1.CurrentRow.Cells(33).Value.ToString
            .txtcollegeYear.Text = DataGridView1.CurrentRow.Cells(34).Value.ToString

            .txtothers.Text = DataGridView1.CurrentRow.Cells(37).Value.ToString
            .txtgl.Text = DataGridView1.CurrentRow.Cells(40).Value.ToString
            .txtpc.Text = DataGridView1.CurrentRow.Cells(41).Value.ToString
            .txtnbic.Text = DataGridView1.CurrentRow.Cells(42).Value.ToString

            .txtwecom1.Text = DataGridView1.CurrentRow.Cells(43).Value.ToString
            .txtwecom2.Text = DataGridView1.CurrentRow.Cells(44).Value.ToString
            .txtwecom3.Text = DataGridView1.CurrentRow.Cells(45).Value.ToString
            .txtwepos1.Text = DataGridView1.CurrentRow.Cells(46).Value.ToString
            .txtwepos2.Text = DataGridView1.CurrentRow.Cells(47).Value.ToString
            .txtwepos3.Text = DataGridView1.CurrentRow.Cells(48).Value.ToString
            .txtwedate1.Text = DataGridView1.CurrentRow.Cells(49).Value.ToString
            .txtwedate2.Text = DataGridView1.CurrentRow.Cells(50).Value.ToString
            .txtwedate3.Text = DataGridView1.CurrentRow.Cells(51).Value.ToString

            .txtPHIC.Text = DataGridView1.CurrentRow.Cells(23).Value.ToString
            .txtHDMF.Text = DataGridView1.CurrentRow.Cells(24).Value.ToString



            sql = "select picfile from tblemppic where empid ='" & .Label1.Text & "'"
            jokenfindthis(sql)
            checkresult("picload")

        End With
    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        lblEMployeeID.Text = DataGridView1.CurrentRow.Cells(0).Value
    End Sub
End Class