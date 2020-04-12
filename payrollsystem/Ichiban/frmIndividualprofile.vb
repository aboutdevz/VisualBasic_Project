Public Class frmIndividualprofile

    Dim sql As String

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If OpenFileDialog1.ShowDialog = 1 Then

            PictureBox2.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
            TextBox2.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
            'strfilenam = OpenFileDialog1.FileName

            'TextBox2.Text = strfilenam

        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click


        sql = "select * from tblemppic where empid = '" & Label1.Text & "'"
        jokenfindthis(sql)
        checkresult("Pic")


        
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtfname.Text = "" Or txtlname.Text = "" Or txtmname.Text = "" Or txtbplace.Text = "" Or txtage.Text = "" Then
            MsgBox("You must fill up the Required fields.", MsgBoxStyle.Critical)
        Else
            Dim rdo

            If rdomale.Checked = True Then
                rdo = "Male"
            Else
                rdo = "Female"
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

         

            jokenupdate("update tblemployee set FNAME = '" & txtfname.Text & "', LNAME = '" & txtlname.Text & _
                        "', MI = '" & txtmname.Text & "', AGE = " & Val(txtage.Text) & ", GENDER = '" & rdo & "', BDAY = '" & dtpbdate.Value & _
                        "', BPLACE = '" & txtbplace.Text & "', HEIGHT = '" & txtHeight.Text & "', WEIGHT = '" & txtweight.Text & _
                        "', CIVIL_STATUS = '" & cbocivil.Text & "', CONTACT = '" & txtContact.Text & "', RELIGION = '" & txtreligon.Text & _
                        "', SPOUSE = '" & txtnamSpouse.Text & "', SP_ADDRESS = '" & txtsadd.Text & "', CITIZENSHIP = '" & txtcitizen.Text & _
                        "', HIREDDATE = '" & dtpHiredate.Value & "', WORKSTATUS = '" & cboworkstat.Text & "', GPOSITION = '" & cbpositon.Text & _
                        "', TAXID = '" & taxid & "' where ID = " & Label40.Text & "")

            jokenupdate("update tblempbackgrd set MOTHER = '" & txtmothername.Text & "', M_ADDRESS = '" & txtmotheradd.Text & _
                       "', ELEMENTARY = '" & txtelem.Text & "', ELEMYEAR = '" & txtelem_year.Text & "', SECONDARY = '" & txthschool.Text & _
                       "', SECONDARY_YEAR = '" & txthschool_yeAR.Text & "', TERTIARY = '" & txtcollege.Text & "', TERTIARY_YEAR = '" & txtcollegeYear.Text & _
                       "', OTHERS = '" & txtothers.Text & "',  FATHER = '" & txtfathername.Text & "', F_ADDRESS = '" & txtfatheradd.Text & "', GLNO = '" & txtgl.Text & _
                       "', POLCL = '" & txtpc.Text & "',  NBICL = '" & txtnbic.Text & "', WECOMP1 = '" & txtwecom1.Text & "',  WECOMP2 = '" & txtwecom2.Text & "', WECOMP3 = '" & txtwecom3.Text & _
                       "', WEPOS1 = '" & txtwepos1.Text & "', WEPOS2 = '" & txtwepos2.Text & "', WEPOS3 = '" & txtwepos3.Text & _
                       "', WEDATE1 = '" & txtwedate1.Text & "', WEDATE2 = '" & txtwedate2.Text & "', WEDATE3 = '" & txtwedate3.Text & "' where EMPID = '" & txtemp_id.Text & "'")




            MsgBox("The Data Has Been Updated in the Database.")
            cleartext(Me)
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim rdo

        If rdomale.Checked = True Then
            rdo = "Male"
        Else
            rdo = "Female"
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


        jokenupdate("update tblemployee set EMPID = '" & txtemp_id.Text & "', FNAME = '" & txtfname.Text & "', LNAME = '" & txtlname.Text & _
                    "', MI = '" & txtmname.Text & "', AGE = '" & txtage.Text & "', GENDER = '" & rdo & "', BDAY = '" & dtpbdate.Text & _
                    "', BPLACE = '" & txtbplace.Text & "', HEIGHT = '" & txtHeight.Text & "', WEIGHT = '" & txtweight.Text & _
                    "', CIVIL_STATUS = '" & cbocivil.Text & "', CONTACT = '" & txtContact.Text & "', RELIGION = '" & txtreligon.Text & _
                    "', SPOUSE = '" & txtnamSpouse.Text & "', SP_ADDRESS = '" & txtsadd.Text & "', CITIZENSHIP = '" & txtcitizen.Text & _
                    "', HIREDDATE = '" & dtpHiredate.Text & "', WORKSTATUS = '" & cboworkstat.Text & "', GPOSITION = '" & cbpositon.Text & _
                    "', TAXID = '" & taxid & "' where ID = " & Label21.Text & "")

        jokenupdate("update tblempbackgrd set EMPID = '" & txtemp_id.Text & "', MOTHER = '" & txtmothername.Text & "', M_ADDRESS = '" & txtmotheradd.Text & _
                    "', ELEMENTARY = '" & txtelem.Text & "', ELEMYEAR = '" & txtelem_year.Text & "', SECONDARY = '" & txthschool.Text & _
                    "', SECONDARY_YEAR = '" & txthschool_yeAR.Text & "', TERTIARY = '" & txtcollege.Text & "', TERTIARY_YEAR = '" & txtcollegeYear.Text & _
                    "', OTHERS = '" & txtothers.Text & "',  FATHER = '" & txtfathername.Text & "', F_ADDRESS = '" & txtfatheradd.Text & "', GLNO = '" & txtgl.Text & _
                    "', POLCL = '" & txtpc.Text & "',  NBICL = '" & txtnbic.Text & "' where BACKID = " & Label35.Text & "")

        MsgBox("The Data Has Been Updated in the Database.")
        cleartext(Me)

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

    Private Sub frmIndividualprofile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

    Private Sub dtpbdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpbdate.ValueChanged

    End Sub
End Class