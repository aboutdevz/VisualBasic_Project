Module usableselect

    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Public total As Integer
    Public Sub jokenselect(ByVal sql As String)
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
    Public Sub filltable(ByVal dtgrd As Object, ByVal design As String)

        Dim publictable As New DataTable

        


        Try
            da.SelectCommand = cmd
            da.Fill(publictable)
            dtgrd.DataSource = publictable

            Select Case design

                Case "EmpInfo"

                    dtgrd.Columns(0).Visible = False

                Case "EmpPic"

                    dtgrd.Columns(0).Visible = False
                    'dtgrd.Columns(1).Visible = False

                    dtgrd.Columns(2).width = 100
                    dtgrd.Columns(3).width = 100
                    dtgrd.Columns(4).width = 30

                    dtgrd.Columns(5).Visible = False
                    dtgrd.Columns(6).Visible = False
                    dtgrd.Columns(7).Visible = False
                    dtgrd.Columns(8).Visible = False
                    dtgrd.Columns(9).Visible = False
                    dtgrd.Columns(10).Visible = False
                    dtgrd.Columns(11).Visible = False
                    dtgrd.Columns(12).Visible = False
                    dtgrd.Columns(13).Visible = False
                    dtgrd.Columns(14).Visible = False
                    dtgrd.Columns(15).Visible = False
                    dtgrd.Columns(16).Visible = False
                    'dtgrd.Columns(17).Visible = False
                    dtgrd.Columns(18).Visible = False

                    dtgrd.Columns(20).Visible = False
                    dtgrd.Columns(21).Visible = False
                    dtgrd.Columns(22).Visible = False
                    dtgrd.Columns(23).Visible = False
                    dtgrd.Columns(24).Visible = False
                    dtgrd.Columns(25).Visible = False
                    dtgrd.Columns(26).Visible = False
                    dtgrd.Columns(27).Visible = False
                    dtgrd.Columns(28).Visible = False
                    dtgrd.Columns(29).Visible = False
                    dtgrd.Columns(30).Visible = False
                    dtgrd.Columns(31).Visible = False
                    dtgrd.Columns(32).Visible = False
                    dtgrd.Columns(33).Visible = False
                    dtgrd.Columns(34).Visible = False
                    dtgrd.Columns(35).Visible = False
                    dtgrd.Columns(36).Visible = False
                    dtgrd.Columns(37).Visible = False
                    dtgrd.Columns(38).Visible = False
                    dtgrd.Columns(39).Visible = False
                    dtgrd.Columns(40).Visible = False
                    dtgrd.Columns(41).Visible = False
                    dtgrd.Columns(42).Visible = False
                    dtgrd.Columns(43).Visible = False
                    dtgrd.Columns(44).Visible = False
                    dtgrd.Columns(45).Visible = False
                    dtgrd.Columns(46).Visible = False
                    dtgrd.Columns(47).Visible = False
                    dtgrd.Columns(48).Visible = False
                    dtgrd.Columns(49).Visible = False
                    dtgrd.Columns(50).Visible = False
                    dtgrd.Columns(51).Visible = False
                   

            End Select


            da.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Public Sub filltotal_employee()
        Dim ds As New DataSet
        Dim publictable As New DataTable

        da.SelectCommand = cmd
        da.Fill(ds, "EMPNO")
        employee.lbltotalemployee.Text = ds.Tables("EMPNO").Rows(0).Item(0)
    End Sub
    Public Sub filltotal_activeemployee()
        Dim ds As New DataSet
        Dim publictable As New DataTable

        da.SelectCommand = cmd
        da.Fill(ds, "EMPNO")
        employee.lblactive.Text = ds.Tables("EMPNO").Rows(0).Item(0)
    End Sub
    Public Sub filltotal_inactiveemployee()
        Dim ds As New DataSet
        Dim publictable As New DataTable

        da.SelectCommand = cmd
        da.Fill(ds, "EMPNO")
        employee.lblinactive.Text = ds.Tables("EMPNO").Rows(0).Item(0)
    End Sub
    Public Sub filltotal_onduty()
        Dim ds As New DataSet
        Dim publictable As New DataTable

        da.SelectCommand = cmd
        da.Fill(ds, "EMPNO")
        employee.LBLONDUTY.Text = ds.Tables("EMPNO").Rows(0).Item(0)
    End Sub
    Public Sub fillitemtable(ByVal dtgrd As Object)
        Dim publictable As New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(publictable)
            dtgrd.DataSource = publictable
            dtgrd.Columns(0).Visible = False
            dtgrd.Columns(1).width = 60
            dtgrd.Columns(2).width = 90
            dtgrd.Columns(3).width = 50
            dtgrd.Columns(4).width = 15
            dtgrd.Columns(5).visible = False
            dtgrd.Columns(6).visible = False
            dtgrd.Columns(7).visible = False
            dtgrd.Columns(8).visible = False
            dtgrd.Columns(9).visible = False
            dtgrd.Columns(10).visible = False
            dtgrd.Columns(11).visible = False
            dtgrd.Columns(12).visible = False

            da.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

        'total = publictable.Compute("sum([Total Price])", String.Empty)
        'publictable.Rows.Add(Nothing, "", "", "Grand Total", Nothing, Nothing, total)

    End Sub

    Public Sub clearall(ByVal group As Object, ByVal cleardtg As Object)
        For Each ctrl As Control In group.Controls
            If ctrl.GetType Is GetType(TextBox) Then
                ctrl.Text = Nothing
                cleardtg.DataSource = Nothing
            End If
        Next
    End Sub

    Public Sub cleartext(ByVal group As Object)
        For Each ctrl As Control In group.Controls
            If ctrl.GetType Is GetType(TextBox) Then
                ctrl.Text = Nothing

            End If
        Next
    End Sub


End Module


