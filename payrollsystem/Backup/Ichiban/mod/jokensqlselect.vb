Module jokensqlselect
    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter

    Public Sub jokenfindthis(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        con.Close()
        da.Dispose()

    End Sub
    Public Sub Checkclient(ByVal var As String)

        Dim table As New DataTable

        Try
            da.SelectCommand = cmd
            da.Fill(table)

            If table.Rows.Count > 0 Then

                Select Case var

                    Case "employee"

                        MsgBox("Employee ID already exist.")

                    Case "client"

                        MsgBox("Client ID already exist.")






                End Select

            Else

                Select Case var


                    Case "employee"

                        'With frmemployee

                        '    ejbinsert("insert into tblemployee (EMPID, FNAME, LNAME, MI, AGE, BDAY, BPLACE, HEIGHT, WEIGHT, CIVIL_STATUS, CONTACT, RELIGION, SPOUSE, SP_ADDRESS, CITIZENSHIP, HIREDDATE, WORKSTATUS, GPOSITION) values ('" & _
                        '              .txtempid.Text & "','" & .txtfname.Text & "','" & .txtlname.Text & "','" & _
                        '                     .txtmi.Text & "'," & Val(.txtage.Text) & ",#" & .dtpbirthdate.Text & "#,'" & _
                        '                     .txtbirthplace.Text & "','" & .txtheight.Text & "','" & .txtweight.Text & "','" & _
                        '                     .cbcivilstatus.Text & "','" & .txtcontact.Text & "','" & .txtreligion.Text & "','" & _
                        '                     .txtspouse.Text & "','" & .txtspouseadd.Text & "','" & .txtcitezenship.Text & "',#" & .dtphireddate.Text & "#,'" & .cbworkstatus.Text & "','" & .cbpositon.Text & "')")

                        'End With


                    Case "client"

                        With client

                            jokeninsert("insert into tblclient (CLIENTID, CL_NAME, CL_ADDRESS, CL_RATE, START_DATE, END_DATE) values ('" & _
                                      .LBLCLIENTID.Text & "','" & .txtClinetName.Text & "','" & .txtClientadd.Text & "'," & _
                                      Val(.txtrate.Text) & ", #" & .strtdate.Text & "#, #" & .endDate.Text & "#)")

                        End With


                        'Case "guard"

                        '    ejbinsert("insert into tblassign (empid, clientid, ASSGSTATUS, ASSIGN_DATE) values ('" & stringEmpID & "','" & frmassign.cbclientnameselect.SelectedValue & "', 'Active', '" & Date.Today.ToString & "' )")
                        '    ejbupdate("update tblemployee set ASSIGN = YES where EMPID = '" & stringEmpID & "'")

                End Select

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Public Sub checkresult(ByVal moodle As String)

        Dim table As New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(table)

            If table.Rows.Count > 0 Then

                Select Case moodle

                    Case "Login"

                        Nname = table.Rows(0).Item(5)
                        Ngposition = table.Rows(0).Item(4)

                        If Ngposition = "Administrator" Then
                            Form1.lbllogname.Text = "Welcome, " & Nname

                            With Form1

                                .lbllogname.Visible = True
                                .Button1.Enabled = True
                                .Button2.Enabled = True
                                .Button4.Enabled = True
                                .Button5.Enabled = True
                                .Button6.Enabled = True
                                .Button7.Enabled = True

                            End With

                        ElseIf Ngposition = "Finance Officer" Then

                            Form1.lbllogname.Text = "Welcome, " & Nname

                            With Form1

                                .lbllogname.Visible = True
                                '.Button1.Enabled = True
                                '.Button2.Enabled = True
                                .Button4.Enabled = True
                                .Button5.Enabled = True
                                '.Button6.Enabled = True

                            End With

                        ElseIf Ngposition = "HR" Then

                            Form1.lbllogname.Text = "Welcome, " & Nname

                            With Form1

                                .lbllogname.Visible = True
                                .Button1.Enabled = True
                                '.Button2.Enabled = True
                                '.Button4.Enabled = True
                                '.Button5.Enabled = True
                                .Button6.Enabled = True

                            End With


                           

                        End If


                        frmlogin.Close()
                        Form1.Button3.Text = "Logout"



                    Case "Tax"


                        emptaxid = table.Rows(0).Item(0)
                       
                    Case "Pic"

                        Dim path As String

                        path = table.Rows(0).Item(2)

                        jokenupdate("UPDATE tblemppic SET picfile='" & frmIndividualprofile.TextBox2.Text & "'  where empid = '" & frmIndividualprofile.Label1.Text & "'")
                        MsgBox("Picture Updated")

                    Case "picload"
                        Dim path As String

                        path = table.Rows(0).Item(0)

                        ' MsgBox(Application.StartupPath & "\pictures" & "\" & path)
                        frmIndividualprofile.PictureBox2.Image = Image.FromFile("" & Application.StartupPath & "\pictures" & "\" & path & "")

                    Case "idincre"

                        Dim newid As String

                        newid = CStr(table.Rows(0).Item(0))

                        newemployee.txtemp_id.Text = newid
                    Case "Payroll"

                        MsgBox("Payrol record already exist")


                End Select

            Else

                Select Case moodle

                    Case "Login"
                        MsgBox("Contact administrator to registered!")

                    Case "picload"

                        frmIndividualprofile.PictureBox2.Image = Nothing

                    Case "Pic"
                        Dim path As String

                        path = frmIndividualprofile.TextBox2.Text

                        jokeninsert("insert into tblemppic (picfile, empid) values ('" & path & "','" & frmIndividualprofile.Label1.Text & "')")
                        MsgBox("Picture Uploaded")

                    Case "Payroll"

                        With payroll
                            jokeninsert("INSERT INTO tblpayroll ( CLIENTID,  EMPID, CLIENT_RATE, AGENCY_FEE, MONTHLY_RATE," & _
                                  " BASIC_PAY, HOURLY_RATE, HOURS_WORK, GROSS_SAL, ALLOWANCE," & _
                                  " ADJUSTMENTS, GROSS_PAY,SSS, SSS_ER, HDMF, HDMF_ER, " & _
                                  " PHIC, PHIC_ER, WTAX, SSS_LOANS, OTHER_LOANS, TOTAL_DED, " & _
                                  " NET_INCOME, PERIOD_START, PERIOD_END, ENCODED_BY, BY_POSITION, PAGLOANS, PAYROLLID )" & _
                                  " VALUES('" & .TXTCLIENTID.Text & "','" & .payEmpID.Text & "'," & Val(.txtClientRate.Text) & "," & Val(.txtAgencyFee.Text) & "," & Val(.txtByMonthlyRate.Text) & ", " & _
                                  " " & Val(.txtbasicPay.Text) & ", " & Val(.txtHourlyRate.Text) & ", " & Val(.txtNoHoursWork.Text) & ", " & Val(.GrossSalary.Text) & ", " & Val(.txtAllowances.Text) & ", " & _
                                  " " & Val(.txtAdjustments.Text) & ", " & Val(.txtGrossPay.Text) & ", " & Val(.txtSSS.Text) & ", " & Val(.txtSSS_ER.Text) & ", " & Val(.txtPagibig.Text) & ", " & Val(.txtPGIBIG_ER.Text) & ", " & _
                                  " " & Val(.txtPhilhealth.Text) & ", " & Val(.txtPHIL_ER.Text) & ", " & Val(.txtWtax.Text) & ", " & Val(.txtSSSLoans.Text) & ", " & Val(.txtOtherLoans.Text) & ", " & Val(.txttotalDeductions.Text) & "," & _
                                  " " & Val(.txtNetIncome.Text) & ",#" & .dtpPeriodStart.Text & "#,#" & .dtpPeriodEnd.Text & "#,'" & Nname & "','" & Ngposition & "'," & Val(.txtPagibigLoans.Text) & ",'" & .lblpayrolid.Text & "')")
                            MsgBox("Payroll has successfully created!")

                        End With

                End Select




            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub
End Module
