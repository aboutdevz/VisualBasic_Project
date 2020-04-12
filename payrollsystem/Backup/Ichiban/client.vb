Public Class client

    
    Private Sub client_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LOAD_CLIENT()
    End Sub

    Public Sub LOAD_CLIENT()

        jokenselect("SELECT id,CLIENTID as [CLIENT ID], CL_NAME as [CLIENT NAME], CL_ADDRESS AS [ADDRESS], CL_RATE AS [RATE], START_DATE AS [START DATE], END_DATE AS [END DATE] FROM tblclient")
        filltable(DataGridView2, "EmpInfo")

        jokenselect("select id, CL_NAME as [CLIENT NAME], START_DATE AS [START DATE],  END_DATE AS [END DATE],  datediff ('d', #10/14/2014#, end_date  ) as [Days Left] from tblclient where datediff ('D', #10/14/2014#, end_date ) < 15 and datediff ('D', #" & Date.Now & "#, end_date ) > 0")
        filltable(DataGridView1, "EmpInfo")



    End Sub



    Private Sub txtClinetName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClinetName.TextChanged
        LBLCLIENTID.Text = txtClinetName.Text & "-" & 678 + 3

    End Sub

    Private Sub btnClientsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientsave.Click
        If btnClientsave.Text = "New" Then

            btnClientsave.Text = "Save"
            cleartext(gbclientinfo)

        Else

            btnClientsave.Text = "New"
           
            If txtClinetName.Text = Nothing Then

                MsgBox("Please fill up Client Name.")

            Else
              
                Dim sql As String
                sql = "select * from tblclient where CLIENTID = '" & LBLCLIENTID.Text & "'"
                jokenfindthis(sql)
                Checkclient("client")

                cleartext(gbclientinfo)
                LOAD_CLIENT()

            End If

        End If
    End Sub

    Private Sub DataGridView2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        ID.Text = DataGridView2.CurrentRow.Cells(0).Value
        LBLCLIENTID.Text = DataGridView2.CurrentRow.Cells(1).Value.ToString
        txtClinetName.Text = DataGridView2.CurrentRow.Cells(2).Value.ToString
        txtClientadd.Text = DataGridView2.CurrentRow.Cells(3).Value.ToString
        txtrate.Text = DataGridView2.CurrentRow.Cells(4).Value

        strtdate.Value = DataGridView2.CurrentRow.Cells(5).Value
        endDate.Value = DataGridView2.CurrentRow.Cells(6).Value

    End Sub


    Private Sub btnUpdateClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateClient.Click
        If ID.Text = "ID" Then
            MsgBox("Please select a client to modify!")
        Else
            jokenupdate("update tblclient set CL_NAME ='" & txtClinetName.Text & _
                              "', CL_ADDRESS ='" & txtClientadd.Text & _
                              "', CL_RATE =" & Val(txtrate.Text) & _
                              ", START_DATE =#" & strtdate.Text & "#, END_DATE =#" & endDate.Text & "# " & _
                              " where ID =" & ID.Text & " ")
            LOAD_CLIENT()
            cleartext(gbclientinfo)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try



            With assign
                .ID.Text = DataGridView2.CurrentRow.Cells(0).Value
                .LBLCLIENTID.Text = DataGridView2.CurrentRow.Cells(1).Value.ToString
                .lblclientName.Text = DataGridView2.CurrentRow.Cells(2).Value.ToString
                .lblAddress.Text = DataGridView2.CurrentRow.Cells(3).Value.ToString
                .lblrate.Text = DataGridView2.CurrentRow.Cells(4).Value
                .lblstart.Text = DataGridView2.CurrentRow.Cells(5).Value
                .lblend.Text = DataGridView2.CurrentRow.Cells(6).Value
            End With
            assign.Show()
        Catch ex As Exception
            MsgBox("Please Select a specific client!")
        End Try
       

    End Sub

    Private Sub txtrate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrate.TextChanged
        If Not IsNumeric(txtrate.Text) = True Then
            txtrate.Text = Nothing

        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class