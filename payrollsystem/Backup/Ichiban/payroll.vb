Public Class payroll

    Dim empTotaltax, empExcesstax, temptax, addtax, finaltax As Decimal

    Private Sub txtClientRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClientRate.TextChanged
        ' Agency Fee
        txtAgencyFee.Text = Val(txtClientRate.Text) * 0.2
        'By Monthly Rate
        txtByMonthlyRate.Text = (Val(txtClientRate.Text) - Val(txtAgencyFee.Text)) / 2
        'Basic Pay
        txtbasicPay.Text = Val(txtByMonthlyRate.Text) / 15
        txtbasicPay.Text = FormatNumber(txtbasicPay.Text, 2)
        'Hourly Rate
        txtHourlyRate.Text = Val(txtbasicPay.Text) / 8

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim salary As Integer = Val(txtGrossPay.Text) * 2
        '  MsgBox(salary)
        Dim EE, ER As Integer
        If salary >= 1000 And salary < 1250 Then
            EE = 36.3
            ER = 83.7
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2

        ElseIf salary >= 1250 And salary < 1750 Then
            EE = 54.5
            ER = 120.5
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 1750 And salary < 2250 Then
            EE = 72.7
            ER = 157.3
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 2250 And salary < 2750 Then
            EE = 90.8
            ER = 194.2
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 2750 And salary < 3250 Then
            EE = 109
            ER = 231
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 3250 And salary < 3750 Then
            EE = 127.2
            ER = 267.8
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 3750 And salary < 4250 Then
            EE = 145.3
            ER = 304.7
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 4250 And salary < 4750 Then
            EE = 163.5
            ER = 341.5
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 4750 And salary < 5250 Then
            EE = 181.7
            ER = 378.3
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 5250 And salary < 5750 Then
            EE = 199.8
            ER = 415.2
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 5750 And salary < 6250 Then
            EE = 218
            ER = 452
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 6250 And salary < 6750 Then
            EE = 236.2
            ER = 488.8
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 6750 And salary < 7250 Then
            EE = 254.3
            ER = 525.7
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 7250 And salary < 7750 Then
            EE = 272.5
            ER = 562.5
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 7750 And salary < 8250 Then
            EE = 290.7
            ER = 599.3
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 8250 And salary < 8750 Then
            EE = 308.8
            ER = 636.2
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 8750 And salary < 9250 Then
            EE = 327
            ER = 673
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 9250 And salary < 9750 Then
            EE = 345.2
            ER = 709.8
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 9750 And salary < 10250 Then
            EE = 363.3
            ER = 746.7
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 10250 And salary < 10750 Then
            EE = 381.5
            ER = 783.5
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 10750 And salary < 11250 Then
            EE = 399.7
            ER = 820.3
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 11250 And salary < 11750 Then
            EE = 417.8
            ER = 857.2
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 11750 And salary < 12250 Then
            EE = 436.0
            ER = 894.0
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 12250 And salary < 12750 Then
            EE = 454.2
            ER = 930.8
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 12750 And salary < 13250 Then
            EE = 472.3
            ER = 967.7
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 13250 And salary < 13750 Then
            EE = 490.5
            ER = 1004.5
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 13750 And salary < 14250 Then
            EE = 508.7
            ER = 1041.3
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 14250 And salary < 14750 Then
            EE = 526.8
            ER = 1078.2
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 14750 And salary < 15250 Then
            EE = 545
            ER = 1135
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 15250 And salary < 15750 Then
            EE = 563.2
            ER = 1171.8
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        ElseIf salary >= 15750 Then
            EE = 581.3
            ER = 1208.7
            txtSSS.Text = EE / 2
            txtSSS_ER.Text = ER / 2
        End If

    End Sub

    Private Sub txtNoHoursWork_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoHoursWork.TextChanged
        'Gross Salary
        GrossSalary.Text = Val(txtHourlyRate.Text) * Val(txtNoHoursWork.Text)
        '  GrossSalary.Text = FormatNumber(GrossSalary.Text, 2)
        'Gross Pay
        '  txtGrossPay.Text = Val(GrossSalary.Text)
        '  txtGrossPay.Text = FormatNumber(txtGrossPay.Text, 2)
        If txtNoHoursWork.Text = Nothing Then
            txtSSS.Text = "0.00"
        End If
        If Not IsNumeric(txtNoHoursWork.Text) Then
            txtNoHoursWork.Text = Nothing
        End If
    End Sub

    Private Sub txtAllowances_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAllowances.TextChanged
        'Gross Pay
        txtGrossPay.Text = Val(GrossSalary.Text) + Val(txtAllowances.Text)
        '   txtGrossPay.Text = FormatNumber(txtGrossPay.Text, 2)
    End Sub

    Private Sub txtAdjustments_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdjustments.TextChanged
        'Gross Pay
        txtGrossPay.Text = Val(txtAdjustments.Text) + Val(txtAllowances.Text) + Val(GrossSalary.Text)
        ' txtGrossPay.Text = FormatNumber(GrossSalary.Text, 2)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        popup.Show()
    End Sub

    Private Sub GrossSalary_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrossSalary.TextChanged
        'txtPagibig.Text = Val(GrossSalary.Text) * 0.02
        txtGrossPay.Text = Math.Round(Val(GrossSalary.Text) + Val(txtAllowances.Text) + Val(txtAdjustments.Text), 2)


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim salary As Integer = Val(txtGrossPay.Text) * 2
        Dim PHIL_EE, PHIL_ER As Integer
        If salary < 9000 Then
            PHIL_EE = 100
            PHIL_ER = 100
            txtPhilhealth.Text = PHIL_EE / 2
            txtPHIL_ER.Text = PHIL_ER / 2
        ElseIf salary >= 9000 And salary < 10000 Then
            PHIL_EE = 112.5
            PHIL_ER = 112.5
            txtPhilhealth.Text = PHIL_EE / 2
            txtPHIL_ER.Text = PHIL_ER / 2
        ElseIf salary >= 10000 And salary < 11000 Then
            PHIL_EE = 125
            PHIL_ER = 125
            txtPhilhealth.Text = PHIL_EE / 2
            txtPHIL_ER.Text = PHIL_ER / 2
        ElseIf salary >= 11000 And salary < 12000 Then
            PHIL_EE = 137.5
            PHIL_ER = 137.5
            txtPhilhealth.Text = PHIL_EE / 2
            txtPHIL_ER.Text = PHIL_ER / 2
        ElseIf salary >= 12000 And salary < 13000 Then
            PHIL_EE = 150
            PHIL_ER = 150
            txtPhilhealth.Text = PHIL_EE / 2
            txtPHIL_ER.Text = PHIL_ER / 2
        ElseIf salary >= 13000 And salary < 14000 Then
            PHIL_EE = 162.5
            PHIL_ER = 162.5
            txtPhilhealth.Text = PHIL_EE / 2
            txtPHIL_ER.Text = PHIL_ER / 2
        ElseIf salary >= 14000 And salary < 15000 Then
            PHIL_EE = 175
            PHIL_ER = 175
            txtPhilhealth.Text = PHIL_EE / 2
            txtPHIL_ER.Text = PHIL_ER / 2
        ElseIf salary >= 15000 And salary < 16000 Then
            PHIL_EE = 187.5
            PHIL_ER = 187.5
            txtPhilhealth.Text = PHIL_EE / 2
            txtPHIL_ER.Text = PHIL_ER / 2

        End If
    End Sub

    Private Sub txtGrossPay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGrossPay.TextChanged
        Call Button2_Click(sender, e)
        Call Button3_Click(sender, e)
        Call Button4_Click(sender, e)
        Call Button5_Click(sender, e)
    End Sub

  

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim RESULT As Integer = Val(txtGrossPay.Text) * 2
        Dim HDMF_EE, HDMF_ER As Integer

        '750 is derived from 1500 earnings per month divided by two'
        If RESULT <= 750 Then '750 is derived from 1500'
            HDMF_EE = RESULT * 0.01
            HDMF_ER = RESULT * 0.02
            txtPagibig.Text = HDMF_EE / 2
            txtPGIBIG_ER.Text = HDMF_ER / 2

        ElseIf RESULT > 750 Then
            HDMF_EE = RESULT * 0.02
            HDMF_ER = RESULT * 0.02
            txtPagibig.Text = HDMF_EE / 2
            txtPGIBIG_ER.Text = HDMF_ER / 2

        End If
    End Sub

    Private Sub txtSSS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSSS.TextChanged

        txttotalDeductions.Text = Val(txtSSS.Text) + Val(txtPagibig.Text) + Val(txtPhilhealth.Text) + Val(txtWtax.Text) + Val(txtSSSLoans.Text) + Val(txtOtherLoans.Text) + Val(txtPagibigLoans.Text)
        txtNetIncome.Text = Val(txtGrossPay.Text) - Val(txttotalDeductions.Text)
    End Sub

    Private Sub txtPagibig_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPagibig.TextChanged



        txttotalDeductions.Text = Val(txtSSS.Text) + Val(txtPagibig.Text) + Val(txtPhilhealth.Text) + Val(txtWtax.Text) + Val(txtSSSLoans.Text) + Val(txtOtherLoans.Text) + Val(txtPagibigLoans.Text)
        txtNetIncome.Text = Val(txtGrossPay.Text) - Val(txttotalDeductions.Text)


    End Sub

    Private Sub txtPhilhealth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhilhealth.TextChanged
        txttotalDeductions.Text = Val(txtSSS.Text) + Val(txtPagibig.Text) + Val(txtPhilhealth.Text) + Val(txtWtax.Text) + Val(txtSSSLoans.Text) + Val(txtOtherLoans.Text) + Val(txtPagibigLoans.Text)
        txtNetIncome.Text = Val(txtGrossPay.Text) - Val(txttotalDeductions.Text)
    End Sub

    Private Sub txtWtax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWtax.TextChanged
        txttotalDeductions.Text = Val(txtSSS.Text) + Val(txtPagibig.Text) + Val(txtPhilhealth.Text) + Val(txtWtax.Text) + Val(txtSSSLoans.Text) + Val(txtOtherLoans.Text) + Val(txtPagibigLoans.Text)
        txtNetIncome.Text = Val(txtGrossPay.Text) - Val(txttotalDeductions.Text)


    End Sub

    Private Sub txtSSSLoans_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSSSLoans.TextChanged
        txttotalDeductions.Text = Val(txtSSS.Text) + Val(txtPagibig.Text) + Val(txtPhilhealth.Text) + Val(txtWtax.Text) + Val(txtSSSLoans.Text) + Val(txtOtherLoans.Text) + Val(txtPagibigLoans.Text)
        txtNetIncome.Text = Val(txtGrossPay.Text) - Val(txttotalDeductions.Text)
    End Sub

    Private Sub txtOtherLoans_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOtherLoans.TextChanged
        txttotalDeductions.Text = Val(txtSSS.Text) + Val(txtPagibig.Text) + Val(txtPhilhealth.Text) + Val(txtWtax.Text) + Val(txtSSSLoans.Text) + Val(txtOtherLoans.Text) + Val(txtPagibigLoans.Text)
        txtNetIncome.Text = Val(txtGrossPay.Text) - Val(txttotalDeductions.Text)
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If payEmpID.Text = Nothing Then
            MsgBox("Please select Guard.")
        Else
            Try
                Dim sql As String

                sql = "select * from tblpayroll where PAYROLLID = '" & lblpayrolid.Text & "' AND EMPID = '" & payEmpID.Text & "'"
                jokenfindthis(sql)
                checkresult("Payroll")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Me.Close()

        End If
        


    End Sub

   

   

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        If emptaxid = "Z" Then

            empTotaltax = Val(txtGrossPay.Text) - (Val(txtSSS.Text) + Val(txtPagibig.Text) + (txtPhilhealth.Text))

            If empTotaltax > 5833 And empTotaltax < 10417 Then

                temptax = 937.5
                empExcesstax = empTotaltax - 5833

                addtax = empExcesstax * 0.25

                finaltax = (temptax + addtax) / 2

                txtWtax.Text = finaltax

            ElseIf empTotaltax < 5833 And empTotaltax > 2917 Then

                temptax = 354.17
                empExcesstax = empTotaltax - 2917

                addtax = empExcesstax * 0.2

                finaltax = (temptax + addtax) / 2

                txtWtax.Text = finaltax

            Else
                finaltax = 0
                txtWtax.Text = finaltax

            End If


        ElseIf emptaxid = "S" Or emptaxid = "M" Then


            If empTotaltax > 5000 And empTotaltax < 7917 Then

                temptax = 354.17
                empExcesstax = empTotaltax - 5000

                addtax = empExcesstax * 0.2

                finaltax = (temptax + addtax) / 2

                txtWtax.Text = finaltax

            ElseIf empTotaltax < 3333 And empTotaltax > 5000 Then

                temptax = 104.17
                empExcesstax = empTotaltax - 3333

                addtax = empExcesstax * 0.15

                finaltax = (temptax + addtax) / 2

                txtWtax.Text = finaltax
            Else

                finaltax = 50
                txtWtax.Text = finaltax

            End If


        ElseIf emptaxid = "S1" Or emptaxid = "M1" Then


            If empTotaltax > 6250 And empTotaltax < 7083 Then

                temptax = 0
                empExcesstax = empTotaltax - 6250

                addtax = empExcesstax * 0.05

                finaltax = (temptax + addtax) / 2

                txtWtax.Text = finaltax

            Else

                finaltax = 75
                txtWtax.Text = finaltax

            End If

        ElseIf emptaxid = "S2" Or emptaxid = "M2" Then


            If empTotaltax > 8333 And empTotaltax < 9167 Then

                temptax = 0
                empExcesstax = empTotaltax - 8333

                addtax = empExcesstax * 0.05

                finaltax = (temptax + addtax) / 2

                txtWtax.Text = finaltax

            Else

                finaltax = 100
                txtWtax.Text = finaltax

            End If

        ElseIf emptaxid = "S3" Or emptaxid = "M3" Then


            If empTotaltax > 10417 And empTotaltax < 11250 Then

                temptax = 0
                empExcesstax = empTotaltax - 10417

                addtax = empExcesstax * 0.05

                finaltax = (temptax + addtax) / 2

                txtWtax.Text = finaltax

            Else

                finaltax = 125
                txtWtax.Text = finaltax

            End If

        ElseIf emptaxid = "S4" Or emptaxid = "M4" Then


            If empTotaltax > 12500 And empTotaltax < 13333 Then

                temptax = 0
                empExcesstax = empTotaltax - 12500

                addtax = empExcesstax * 0.05

                finaltax = (temptax + addtax) / 2

                txtWtax.Text = finaltax

            Else

                finaltax = 150
                txtWtax.Text = finaltax

            End If


        End If
    End Sub

   
  
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Form1.BringToFront()

        Me.Close()

    End Sub

    Private Sub txtPagibigLoans_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPagibigLoans.TextChanged
        txttotalDeductions.Text = Val(txtSSS.Text) + Val(txtPagibig.Text) + Val(txtPhilhealth.Text) + Val(txtWtax.Text) + Val(txtSSSLoans.Text) + Val(txtOtherLoans.Text) + Val(txtPagibigLoans.Text)
        txtNetIncome.Text = Val(txtGrossPay.Text) - Val(txttotalDeductions.Text)

    End Sub

  
    Private Sub payroll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim Msg, Number, StartDate As String   'Declare variables.

        'Dim Months As Double
        'Dim SecondDate As Date
        'Dim IntervalType As DateInterval

        'IntervalType = DateInterval.Month   ' Specifies months as interval.

        'StartDate = InputBox("Enter a date")
        'SecondDate = CDate(StartDate)
        'Number = InputBox("Enter number of months to add")
        'Months = Val(Number)
        'Msg = "New date: " & DateAdd(IntervalType, Months, SecondDate)
        'MsgBox(Msg)

        'Dim offset = New Date(1, 1, 1)
        'Dim dateOne = DateTimePicker1.Value
        'Dim dateTwo = DateTimePicker2.Value
        'Dim diff As TimeSpan = dateTwo - dateOne
        'Dim years = (offset + diff).Year - 1
        'Dim months = (dateTwo.Month - dateOne.Month) + 12 * (dateTwo.Year - dateOne.Year)
        'Dim days = diff.Days
        'TxtYear.Text = years.ToString
        'TxtMonth.Text = months.ToString
        'TxtDays.Text = days.ToString
    End Sub

    Private Sub dtpPeriodStart_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpPeriodStart.TextChanged
        If dtpPeriodStart.Value.Day <= 15 Then

            Dim diffdate As Integer

            diffdate = 15 - dtpPeriodStart.Value.Day
            dtpPeriodEnd.Value = (dtpPeriodStart.Value.AddDays(diffdate))

            lblpayrolid.Text = "ICHI" & dtpPeriodEnd.Value.Month & dtpPeriodEnd.Value.Day & dtpPeriodEnd.Value.Year

        Else
            Dim diffdate As Integer

            diffdate = 30 - dtpPeriodStart.Value.Day
            dtpPeriodEnd.Value = (dtpPeriodStart.Value.AddDays(diffdate))

            lblpayrolid.Text = "ICHI" & dtpPeriodEnd.Value.Month & dtpPeriodEnd.Value.Day & dtpPeriodEnd.Value.Year

        End If
    End Sub
End Class