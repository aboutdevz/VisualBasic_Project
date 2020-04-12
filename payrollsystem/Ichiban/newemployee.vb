Public Class newemployee

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click


        If txtfname.Text = "" Or txtlname.Text = "" Or txtmname.Text = "" Or txtbplace.Text = "" Or txtage.Text = "" Or txtgl.Text = "" Or txtnbic.Text = "" Or txtothers.Text = "" Then
            MsgBox("You must fill up the Required fields.", MsgBoxStyle.Critical)
        Else
            Dim rdo

            If rdomale.Checked = True Then
                rdo = "Male"
            ElseIf rdofemale.Checked = True Then
                rdo = "Female"
            Else
                MsgBox("Please Select Gender.")
            End If

            If rbdep1.Checked And cbocivil.Text = "Married" Then
                taxid = "M1"
            ElseIf rbdep2.Checked And cbocivil.Text = "Married" Then
                taxid = "M2"
            ElseIf rbdep3.Checked And cbocivil.Text = "Married" Then
                taxid = "M3"
            ElseIf rbdep4.Checked And cbocivil.Text = "Married" Then
                taxid = "M4"
            ElseIf rbdep0.Checked And cbocivil.Text = "Married" Then
                taxid = "M"
            End If

            If rbdep1.Checked And cbocivil.Text = "Single" Then
                taxid = "S1"
            ElseIf rbdep2.Checked And cbocivil.Text = "Single" Then
                taxid = "S2"
            ElseIf rbdep3.Checked And cbocivil.Text = "Single" Then
                taxid = "S3"
            ElseIf rbdep4.Checked And cbocivil.Text = "Single" Then
                taxid = "S4"
            ElseIf rbdep0.Checked And cbocivil.Text = "Single" Then
                taxid = "S"
            End If

            jokeninsert("INSERT INTO tblemployee " & _
           "(EMPID,FNAME,LNAME,MI,AGE,GENDER,BDAY,BPLACE,HEIGHT,WEIGHT,CIVIL_STATUS,CONTACT,RELIGION,SPOUSE,SP_ADDRESS," & _
           "CITIZENSHIP,HIREDDATE,WORKSTATUS,GPOSITION,ASSIGN, TAXID, PHIC, HDMF) " & _
           "VALUES ('" & txtemp_id.Text & "','" & txtfname.Text & "','" & txtlname.Text & "','" & txtmname.Text & _
           "','" & txtage.Text & "','" & rdo & "','" & dtpbdate.Value & "','" & txtbplace.Text & "','" & txtHeight.Text & _
           "','" & txtweight.Text & "','" & cbocivil.Text & "','" & txtContact.Text & "','" & txtreligon.Text & "','" & txtnamSpouse.Text & _
           "','" & txtsadd.Text & "','" & txtcitizen.Text & "','" & dtpHiredate.Value & "','" & cboworkstat.Text & _
           "','" & cbpositon.Text & "',0 ,'" & taxid & "','" & txtPHIC.Text & "','" & txtHDMF.Text & "')")


            jokeninsert("INSERT INTO tblempbackgrd(EMPID,MOTHER,M_ADDRESS,ELEMENTARY,ELEMYEAR,SECONDARY,SECONDARY_YEAR,TERTIARY,TERTIARY_YEAR,OTHERS,FATHER,F_ADDRESS,SPOUSE,SPOUSEADD,GLNO,POLCL,NBICL,WECOMP1,WECOMP2,WECOMP3,WEPOS1,WEPOS2,WEPOS3,WEDATE1,WEDATE2,WEDATE3)" & _
              "VALUES ('" & txtemp_id.Text & "','" & txtmothername.Text & "','" & txtmotheradd.Text & "','" & txtelem.Text & _
              "','" & txtelem_year.Text & "','" & txthschool.Text & "','" & txthschool_yeAR.Text & "','" & txtcollege.Text & "','" & txtcollegeYear.Text & "','" & txtothers.Text & _
              "','" & txtfathername.Text & "','" & txtfatheradd.Text & "','" & txtnamSpouse.Text & "','" & txtsadd.Text & "','" & txtgl.Text & "','" & txtpc.Text & "','" & txtnbic.Text & _
              "','" & txtwecom1.Text & "','" & txtwecom2.Text & "','" & txtwecom3.Text & _
              "','" & txtwepos1.Text & "','" & txtwepos2.Text & "','" & txtwepos3.Text & _
              "','" & txtwedate1.Text & "','" & txtwedate2.Text & "','" & txtwedate3.Text & _
              "')")

            MsgBox("The Data Has Been Saved in the Database.")

            employee.Show()
            Me.Close()



        End If

    End Sub

    Private Sub newemployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim sql As String

        sql = "SELECT EMPID + 3 FROM tblemployee where id=(select max (id) from tblemployee)"
        jokenfindthis(sql)
        checkresult("idincre")


        cbocivil.Text = Nothing
        GroupBox2.Enabled = False
        GroupBox2.Show()

       



    End Sub

    Private Sub cbocivil_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbocivil.TextChanged
        If cbocivil.Text = "Single" Then
            ' GroupBox2.Show()

        ElseIf cbocivil.Text = "Married" Then
            GroupBox2.Enabled = True
            txtnamSpouse.Enabled = True
            txtsadd.Enabled = True
        Else
            GroupBox2.Enabled = False

            taxid = "Z"

        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmCamera.Show()

    End Sub

    Private Sub dtpbdate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpbdate.TextChanged

        Dim offset = New Date(1, 1, 1)

        Dim dateOne = dtpbdate.Value
        Dim dateTwo = Date.Now

        Dim diff As TimeSpan = dateTwo - dateOne

        Dim years = (offset + diff).Year - 1



        If years < 18 And years < 50 Then
            MsgBox("Age requirement must be 18 - 50 years old!")
        Else
            txtage.Text = years.ToString
        End If

    End Sub

    Private Sub txtContact_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContact.TextChanged
        If Not IsNumeric(txtContact.Text) Then
            txtContact.Text = Nothing
        End If

    End Sub

    Private Sub txtHeight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHeight.TextChanged
        If Not IsNumeric(txtHeight.Text) Then
            txtHeight.Text = Nothing
        End If
        If txtHeight.TextLength > 3 Then
            txtHeight.Text = Nothing
        End If
    End Sub

    Private Sub txtweight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtweight.TextChanged
        If Not IsNumeric(txtweight.Text) Then
            txtContact.Text = Nothing
        End If
        If txtweight.TextLength > 3 Then
            txtweight.Text = Nothing
        End If
    End Sub

   
    Private Sub txtmname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmname.TextChanged
        If txtmname.TextLength > 1 Then
            txtmname.Text = Nothing
        End If
    End Sub

   
    Private Sub txtnbic_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnbic.TextChanged
        If Not IsNumeric(txtnbic.Text) Then
            txtnbic.Text = Nothing
            
        End If
        If txtnbic.TextLength > 10 Then
            MsgBox("TIN number must not more than 10 digits.")
        End If
    End Sub

    Private Sub txtothers_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtothers.TextChanged
        If Not IsNumeric(txtothers.Text) Then
            txtothers.Text = Nothing
        End If
        If txtothers.TextLength > 10 Then
            MsgBox("SSS ID number must not more than 10 digits.")
        End If
    End Sub

    Private Sub txtgl_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtgl.TextChanged
        If Not IsNumeric(txtgl.Text) Then
            txtgl.Text = Nothing
        End If
        If txtgl.TextLength > 10 Then
            MsgBox("Guard License number must not more than 10 digits.")
        End If
    End Sub

    Private Sub txtPHIC_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPHIC.TextChanged
        If Not IsNumeric(txtPHIC.Text) Then
            txtPHIC.Text = Nothing
        End If
        If txtPHIC.TextLength > 11 Then
            MsgBox("PHIC ID number must not more than 11 digits.")
        End If
    End Sub

    Private Sub txtHDMF_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHDMF.TextChanged
        If Not IsNumeric(txtHDMF.Text) Then
            txtgl.Text = Nothing
        End If
        If txtHDMF.TextLength > 12 Then
            MsgBox("HDMF ID number must not more than 12 digits.")
        End If
    End Sub

    Private Sub dtpbdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpbdate.ValueChanged

    End Sub
End Class