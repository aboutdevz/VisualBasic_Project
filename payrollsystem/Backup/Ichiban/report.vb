Public Class report
    Dim acscmd As New OleDb.OleDbCommand
    Dim acsda As New OleDb.OleDbDataAdapter
    Dim acscon As OleDb.OleDbConnection = myconn()
    Dim acsds As New DataSet
    Dim strsql As String
    Dim strreportname As String
    Dim token As String
    Private Sub report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub
    Public Sub report(ByVal sql As String, ByVal rptname As String)
        Try
            acsds = New DataSet
            strsql = sql
            acscmd.CommandText = strsql
            acscmd.Connection = acscon
            acsda.SelectCommand = acscmd
            acsda.Fill(acsds)

            strreportname = rptname
            Dim strreportpath As String = Application.StartupPath & "\reports\" & strreportname & ".rpt"
            '  Dim strreportpath As String = "C:\Users\DELL\Documents\Visual Studio 2008\Projects\mytest\mytest\bin\reports\" & strreportname & ".rpt"
            If Not IO.File.Exists(strreportpath) Then
                MsgBox("Unable to locate file:" & vbCrLf & strreportpath)

            End If
            Dim reportdoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument

            reportdoc.Load(strreportpath)
            reportdoc.SetDataSource(acsds.Tables(0))

            CrystalReportViewer1.ShowRefreshButton = False
            CrystalReportViewer1.ShowCloseButton = False
            CrystalReportViewer1.ShowGroupTreeButton = False
            CrystalReportViewer1.ReportSource = reportdoc
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        report("select * from overallpayrol order by period_start", "detailed")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        report("select * from payslip where PERIOD_START  between #" & dtpPeriodStart.Text & "#  and #" & dtpPeriodEnd.Text & "#", "PaySlipVer1")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        report("select * from empdetails", "EmployeeInfo")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        report("select * from clientdetails", "clientDetails")

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        report("select * from overallpayrol where PERIOD_START between #" & dtpPeriodStart.Text & "# AND #" & dtpPeriodEnd.Text & "# ORDER by period_start", "detailed")

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        report("select * from clientguard", "clientguard")

    End Sub
End Class