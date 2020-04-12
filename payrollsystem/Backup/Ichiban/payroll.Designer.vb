<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payroll
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtpPeriodEnd = New System.Windows.Forms.DateTimePicker
        Me.dtpPeriodStart = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label44 = New System.Windows.Forms.Label
        Me.payEmpName = New System.Windows.Forms.TextBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtPHIL_ER = New System.Windows.Forms.TextBox
        Me.txtPGIBIG_ER = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtSSS_ER = New System.Windows.Forms.TextBox
        Me.txtPagibigLoans = New System.Windows.Forms.TextBox
        Me.txttotalDeductions = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtOtherLoans = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtSSSLoans = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtWtax = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.txtPhilhealth = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtPagibig = New System.Windows.Forms.TextBox
        Me.txtSSS = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.btncancel = New System.Windows.Forms.Button
        Me.btnsave = New System.Windows.Forms.Button
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtNetIncome = New System.Windows.Forms.TextBox
        Me.txtClientRate = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtAgencyFee = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtByMonthlyRate = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtHourlyRate = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GrossSalary = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtGrossPay = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtbasicPay = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtNoHoursWork = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtAllowances = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtAdjustments = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.payEmpID = New System.Windows.Forms.TextBox
        Me.TXTCLIENTID = New System.Windows.Forms.TextBox
        Me.TXTCLIENTNAME = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.lblpayrolid = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(724, 51)
        Me.Panel1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Location = New System.Drawing.Point(3, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 33)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Payroll"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(162, 71)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 89
        Me.Label15.Text = "Period End :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(30, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 88
        Me.Label14.Text = "Period Start :"
        '
        'dtpPeriodEnd
        '
        Me.dtpPeriodEnd.Enabled = False
        Me.dtpPeriodEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPeriodEnd.Location = New System.Drawing.Point(159, 87)
        Me.dtpPeriodEnd.Name = "dtpPeriodEnd"
        Me.dtpPeriodEnd.Size = New System.Drawing.Size(126, 20)
        Me.dtpPeriodEnd.TabIndex = 10
        '
        'dtpPeriodStart
        '
        Me.dtpPeriodStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPeriodStart.Location = New System.Drawing.Point(27, 87)
        Me.dtpPeriodStart.Name = "dtpPeriodStart"
        Me.dtpPeriodStart.Size = New System.Drawing.Size(126, 20)
        Me.dtpPeriodStart.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(291, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 32)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Open List"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(30, 125)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(73, 13)
        Me.Label44.TabIndex = 24
        Me.Label44.Text = "Employee ID :"
        '
        'payEmpName
        '
        Me.payEmpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payEmpName.Location = New System.Drawing.Point(159, 141)
        Me.payEmpName.Name = "payEmpName"
        Me.payEmpName.ReadOnly = True
        Me.payEmpName.Size = New System.Drawing.Size(200, 22)
        Me.payEmpName.TabIndex = 25
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(163, 126)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(55, 13)
        Me.Label45.TabIndex = 26
        Me.Label45.Text = "Fullname :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPHIL_ER)
        Me.GroupBox1.Controls.Add(Me.txtPGIBIG_ER)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtSSS_ER)
        Me.GroupBox1.Location = New System.Drawing.Point(249, 508)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(132, 62)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deduction"
        '
        'txtPHIL_ER
        '
        Me.txtPHIL_ER.Location = New System.Drawing.Point(18, 87)
        Me.txtPHIL_ER.Name = "txtPHIL_ER"
        Me.txtPHIL_ER.ReadOnly = True
        Me.txtPHIL_ER.Size = New System.Drawing.Size(78, 20)
        Me.txtPHIL_ER.TabIndex = 86
        Me.txtPHIL_ER.Text = "0.00"
        '
        'txtPGIBIG_ER
        '
        Me.txtPGIBIG_ER.Location = New System.Drawing.Point(18, 64)
        Me.txtPGIBIG_ER.Name = "txtPGIBIG_ER"
        Me.txtPGIBIG_ER.ReadOnly = True
        Me.txtPGIBIG_ER.Size = New System.Drawing.Size(78, 20)
        Me.txtPGIBIG_ER.TabIndex = 85
        Me.txtPGIBIG_ER.Text = "100"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(59, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 13)
        Me.Label12.TabIndex = 84
        Me.Label12.Text = "ER"
        '
        'txtSSS_ER
        '
        Me.txtSSS_ER.Location = New System.Drawing.Point(18, 32)
        Me.txtSSS_ER.Name = "txtSSS_ER"
        Me.txtSSS_ER.ReadOnly = True
        Me.txtSSS_ER.Size = New System.Drawing.Size(78, 20)
        Me.txtSSS_ER.TabIndex = 83
        Me.txtSSS_ER.Text = "0.00"
        '
        'txtPagibigLoans
        '
        Me.txtPagibigLoans.Location = New System.Drawing.Point(342, 327)
        Me.txtPagibigLoans.Name = "txtPagibigLoans"
        Me.txtPagibigLoans.Size = New System.Drawing.Size(80, 20)
        Me.txtPagibigLoans.TabIndex = 89
        Me.txtPagibigLoans.Text = "0.00"
        Me.txtPagibigLoans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttotalDeductions
        '
        Me.txttotalDeductions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalDeductions.Location = New System.Drawing.Point(335, 414)
        Me.txttotalDeductions.Name = "txttotalDeductions"
        Me.txttotalDeductions.ReadOnly = True
        Me.txttotalDeductions.Size = New System.Drawing.Size(87, 22)
        Me.txttotalDeductions.TabIndex = 81
        Me.txttotalDeductions.Text = "0.00"
        Me.txttotalDeductions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(33, 420)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(141, 16)
        Me.Label27.TabIndex = 80
        Me.Label27.Text = "TOTAL DEDUCTION :"
        '
        'txtOtherLoans
        '
        Me.txtOtherLoans.Location = New System.Drawing.Point(342, 356)
        Me.txtOtherLoans.Name = "txtOtherLoans"
        Me.txtOtherLoans.Size = New System.Drawing.Size(80, 20)
        Me.txtOtherLoans.TabIndex = 24
        Me.txtOtherLoans.Text = "0.00"
        Me.txtOtherLoans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(256, 331)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 13)
        Me.Label16.TabIndex = 90
        Me.Label16.Text = "Pag-ibig Loans :"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(258, 307)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(66, 13)
        Me.Label30.TabIndex = 25
        Me.Label30.Text = "SSS Loans :"
        '
        'txtSSSLoans
        '
        Me.txtSSSLoans.Location = New System.Drawing.Point(342, 301)
        Me.txtSSSLoans.Name = "txtSSSLoans"
        Me.txtSSSLoans.Size = New System.Drawing.Size(80, 20)
        Me.txtSSSLoans.TabIndex = 23
        Me.txtSSSLoans.Text = "0.00"
        Me.txtSSSLoans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(256, 356)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(71, 13)
        Me.Label29.TabIndex = 26
        Me.Label29.Text = "Other Loans :"
        '
        'txtWtax
        '
        Me.txtWtax.BackColor = System.Drawing.SystemColors.Control
        Me.txtWtax.Location = New System.Drawing.Point(157, 379)
        Me.txtWtax.Name = "txtWtax"
        Me.txtWtax.Size = New System.Drawing.Size(80, 20)
        Me.txtWtax.TabIndex = 22
        Me.txtWtax.Text = "0.00"
        Me.txtWtax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(33, 382)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(47, 13)
        Me.Label33.TabIndex = 21
        Me.Label33.Text = "W/Tax :"
        '
        'txtPhilhealth
        '
        Me.txtPhilhealth.Location = New System.Drawing.Point(159, 353)
        Me.txtPhilhealth.Name = "txtPhilhealth"
        Me.txtPhilhealth.ReadOnly = True
        Me.txtPhilhealth.Size = New System.Drawing.Size(78, 20)
        Me.txtPhilhealth.TabIndex = 19
        Me.txtPhilhealth.Text = "0.00"
        Me.txtPhilhealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(33, 355)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(59, 13)
        Me.Label31.TabIndex = 20
        Me.Label31.Text = "Philhealth :"
        '
        'txtPagibig
        '
        Me.txtPagibig.Location = New System.Drawing.Point(159, 327)
        Me.txtPagibig.Name = "txtPagibig"
        Me.txtPagibig.ReadOnly = True
        Me.txtPagibig.Size = New System.Drawing.Size(78, 20)
        Me.txtPagibig.TabIndex = 17
        Me.txtPagibig.Text = "100"
        Me.txtPagibig.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSSS
        '
        Me.txtSSS.Location = New System.Drawing.Point(159, 301)
        Me.txtSSS.Name = "txtSSS"
        Me.txtSSS.ReadOnly = True
        Me.txtSSS.Size = New System.Drawing.Size(78, 20)
        Me.txtSSS.TabIndex = 15
        Me.txtSSS.Text = "0.00"
        Me.txtSSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(33, 307)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(34, 13)
        Me.Label32.TabIndex = 18
        Me.Label32.Text = "SSS :"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(33, 326)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(54, 13)
        Me.Label34.TabIndex = 16
        Me.Label34.Text = "Pag- ibig :"
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(609, 438)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(88, 34)
        Me.btncancel.TabIndex = 88
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(519, 438)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(88, 34)
        Me.btnsave.TabIndex = 87
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(264, 239)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(69, 13)
        Me.Label28.TabIndex = 79
        Me.Label28.Text = "Total Salary :"
        '
        'txtNetIncome
        '
        Me.txtNetIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetIncome.Location = New System.Drawing.Point(335, 452)
        Me.txtNetIncome.Name = "txtNetIncome"
        Me.txtNetIncome.ReadOnly = True
        Me.txtNetIncome.Size = New System.Drawing.Size(87, 22)
        Me.txtNetIncome.TabIndex = 82
        Me.txtNetIncome.Text = "0.00"
        Me.txtNetIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtClientRate
        '
        Me.txtClientRate.Location = New System.Drawing.Point(129, 25)
        Me.txtClientRate.Name = "txtClientRate"
        Me.txtClientRate.ReadOnly = True
        Me.txtClientRate.Size = New System.Drawing.Size(80, 20)
        Me.txtClientRate.TabIndex = 57
        Me.txtClientRate.Text = "0.00"
        Me.txtClientRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Client Rate :"
        '
        'txtAgencyFee
        '
        Me.txtAgencyFee.Location = New System.Drawing.Point(129, 51)
        Me.txtAgencyFee.Name = "txtAgencyFee"
        Me.txtAgencyFee.ReadOnly = True
        Me.txtAgencyFee.Size = New System.Drawing.Size(80, 20)
        Me.txtAgencyFee.TabIndex = 59
        Me.txtAgencyFee.Text = "0.00"
        Me.txtAgencyFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Agency Fee :"
        '
        'txtByMonthlyRate
        '
        Me.txtByMonthlyRate.Location = New System.Drawing.Point(129, 77)
        Me.txtByMonthlyRate.Name = "txtByMonthlyRate"
        Me.txtByMonthlyRate.ReadOnly = True
        Me.txtByMonthlyRate.Size = New System.Drawing.Size(80, 20)
        Me.txtByMonthlyRate.TabIndex = 61
        Me.txtByMonthlyRate.Text = "0.00"
        Me.txtByMonthlyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "By Monthly Rate :"
        '
        'txtHourlyRate
        '
        Me.txtHourlyRate.Location = New System.Drawing.Point(129, 135)
        Me.txtHourlyRate.Name = "txtHourlyRate"
        Me.txtHourlyRate.ReadOnly = True
        Me.txtHourlyRate.Size = New System.Drawing.Size(80, 20)
        Me.txtHourlyRate.TabIndex = 63
        Me.txtHourlyRate.Text = "0.00"
        Me.txtHourlyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Hourly Rate :"
        '
        'GrossSalary
        '
        Me.GrossSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrossSalary.Location = New System.Drawing.Point(342, 182)
        Me.GrossSalary.Name = "GrossSalary"
        Me.GrossSalary.ReadOnly = True
        Me.GrossSalary.Size = New System.Drawing.Size(80, 21)
        Me.GrossSalary.TabIndex = 65
        Me.GrossSalary.Text = "0.00"
        Me.GrossSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(264, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Basic Pay :"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(168, 538)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 67
        Me.Button2.Text = "SSS"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrossPay.Location = New System.Drawing.Point(342, 236)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.ReadOnly = True
        Me.txtGrossPay.Size = New System.Drawing.Size(80, 20)
        Me.txtGrossPay.TabIndex = 68
        Me.txtGrossPay.Text = "0.00"
        Me.txtGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 452)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(171, 20)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Net Pay for the Period :"
        '
        'txtbasicPay
        '
        Me.txtbasicPay.Location = New System.Drawing.Point(129, 109)
        Me.txtbasicPay.Name = "txtbasicPay"
        Me.txtbasicPay.ReadOnly = True
        Me.txtbasicPay.Size = New System.Drawing.Size(80, 20)
        Me.txtbasicPay.TabIndex = 70
        Me.txtbasicPay.Text = "0.00"
        Me.txtbasicPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(53, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Basic Pay :"
        '
        'txtNoHoursWork
        '
        Me.txtNoHoursWork.Location = New System.Drawing.Point(159, 180)
        Me.txtNoHoursWork.Name = "txtNoHoursWork"
        Me.txtNoHoursWork.Size = New System.Drawing.Size(80, 20)
        Me.txtNoHoursWork.TabIndex = 72
        Me.txtNoHoursWork.Text = "0.00"
        Me.txtNoHoursWork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "No. Hours Worked :"
        '
        'txtAllowances
        '
        Me.txtAllowances.Location = New System.Drawing.Point(159, 206)
        Me.txtAllowances.Name = "txtAllowances"
        Me.txtAllowances.Size = New System.Drawing.Size(80, 20)
        Me.txtAllowances.TabIndex = 74
        Me.txtAllowances.Text = "0.00"
        Me.txtAllowances.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 213)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Allowances :"
        '
        'txtAdjustments
        '
        Me.txtAdjustments.Location = New System.Drawing.Point(159, 232)
        Me.txtAdjustments.Name = "txtAdjustments"
        Me.txtAdjustments.Size = New System.Drawing.Size(80, 20)
        Me.txtAdjustments.TabIndex = 76
        Me.txtAdjustments.Text = "0.00"
        Me.txtAdjustments.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 239)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = " Adjustments :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtClientRate)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtAgencyFee)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtByMonthlyRate)
        Me.GroupBox2.Controls.Add(Me.txtbasicPay)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtHourlyRate)
        Me.GroupBox2.Location = New System.Drawing.Point(451, 182)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(246, 174)
        Me.GroupBox2.TabIndex = 78
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Income"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 512)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 79
        Me.TextBox1.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(9, 538)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 80
        Me.Button3.Text = "PHIC"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(127, 512)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 81
        Me.TextBox2.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(470, 543)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 15)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "Client ID :"
        Me.Label13.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(249, 520)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(81, 15)
        Me.Label23.TabIndex = 82
        Me.Label23.Text = "Client Name :"
        Me.Label23.Visible = False
        '
        'payEmpID
        '
        Me.payEmpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payEmpID.Location = New System.Drawing.Point(27, 140)
        Me.payEmpID.Name = "payEmpID"
        Me.payEmpID.ReadOnly = True
        Me.payEmpID.Size = New System.Drawing.Size(126, 22)
        Me.payEmpID.TabIndex = 23
        '
        'TXTCLIENTID
        '
        Me.TXTCLIENTID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCLIENTID.Location = New System.Drawing.Point(535, 540)
        Me.TXTCLIENTID.Name = "TXTCLIENTID"
        Me.TXTCLIENTID.ReadOnly = True
        Me.TXTCLIENTID.Size = New System.Drawing.Size(125, 22)
        Me.TXTCLIENTID.TabIndex = 85
        Me.TXTCLIENTID.Visible = False
        '
        'TXTCLIENTNAME
        '
        Me.TXTCLIENTNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCLIENTNAME.Location = New System.Drawing.Point(252, 538)
        Me.TXTCLIENTNAME.Name = "TXTCLIENTNAME"
        Me.TXTCLIENTNAME.ReadOnly = True
        Me.TXTCLIENTNAME.Size = New System.Drawing.Size(210, 22)
        Me.TXTCLIENTNAME.TabIndex = 86
        Me.TXTCLIENTNAME.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(87, 538)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 87
        Me.Button4.Text = "HDMF"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(13, 282)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(140, 16)
        Me.Label17.TabIndex = 91
        Me.Label17.Text = "LESS DEDUCTIONS :"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(473, 511)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 92
        Me.Button5.Text = "Tax"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'lblpayrolid
        '
        Me.lblpayrolid.AutoSize = True
        Me.lblpayrolid.Location = New System.Drawing.Point(577, 72)
        Me.lblpayrolid.Name = "lblpayrolid"
        Me.lblpayrolid.Size = New System.Drawing.Size(43, 13)
        Me.lblpayrolid.TabIndex = 94
        Me.lblpayrolid.Text = "payrolid"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(516, 72)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 13)
        Me.Label18.TabIndex = 95
        Me.Label18.Text = "Payroll ID:"
        '
        'payroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(724, 493)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblpayrolid)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.txtPagibigLoans)
        Me.Controls.Add(Me.txttotalDeductions)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtWtax)
        Me.Controls.Add(Me.txtOtherLoans)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.txtPhilhealth)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.dtpPeriodEnd)
        Me.Controls.Add(Me.txtSSSLoans)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.txtPagibig)
        Me.Controls.Add(Me.dtpPeriodStart)
        Me.Controls.Add(Me.txtSSS)
        Me.Controls.Add(Me.txtAdjustments)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtNetIncome)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXTCLIENTID)
        Me.Controls.Add(Me.txtAllowances)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXTCLIENTNAME)
        Me.Controls.Add(Me.GrossSalary)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtNoHoursWork)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.payEmpID)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.payEmpName)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "payroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents payEmpName As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOtherLoans As System.Windows.Forms.TextBox
    Friend WithEvents txtSSSLoans As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtWtax As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtPhilhealth As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtPagibig As System.Windows.Forms.TextBox
    Friend WithEvents txtSSS As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtClientRate As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAgencyFee As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtByMonthlyRate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtHourlyRate As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GrossSalary As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtGrossPay As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtbasicPay As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNoHoursWork As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAllowances As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAdjustments As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtNetIncome As System.Windows.Forms.TextBox
    Friend WithEvents txttotalDeductions As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpPeriodStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPHIL_ER As System.Windows.Forms.TextBox
    Friend WithEvents txtPGIBIG_ER As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtSSS_ER As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents payEmpID As System.Windows.Forms.TextBox
    Friend WithEvents TXTCLIENTID As System.Windows.Forms.TextBox
    Friend WithEvents TXTCLIENTNAME As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpPeriodEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPagibigLoans As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents lblpayrolid As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
