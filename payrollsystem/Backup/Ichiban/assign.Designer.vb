<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class assign
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridView3 = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.gbclientinfo = New System.Windows.Forms.GroupBox
        Me.lblend = New System.Windows.Forms.Label
        Me.lblstart = New System.Windows.Forms.Label
        Me.ID = New System.Windows.Forms.Label
        Me.lblrate = New System.Windows.Forms.Label
        Me.lblAddress = New System.Windows.Forms.Label
        Me.lblclientName = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LBLCLIENTID = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LBLEMPSTATUS = New System.Windows.Forms.Label
        Me.LBLAGE = New System.Windows.Forms.Label
        Me.LBLFULLNAME = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.LBLEMPID = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.BTNASSIGN = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gbclientinfo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(590, 225)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of Available Guard(s)"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(19, 19)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(565, 190)
        Me.DataGridView3.TabIndex = 56
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(614, 51)
        Me.Panel1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Location = New System.Drawing.Point(3, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(348, 33)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Assigning of Guard to Client"
        '
        'gbclientinfo
        '
        Me.gbclientinfo.Controls.Add(Me.lblend)
        Me.gbclientinfo.Controls.Add(Me.lblstart)
        Me.gbclientinfo.Controls.Add(Me.ID)
        Me.gbclientinfo.Controls.Add(Me.lblrate)
        Me.gbclientinfo.Controls.Add(Me.lblAddress)
        Me.gbclientinfo.Controls.Add(Me.lblclientName)
        Me.gbclientinfo.Controls.Add(Me.Label1)
        Me.gbclientinfo.Controls.Add(Me.LBLCLIENTID)
        Me.gbclientinfo.Controls.Add(Me.Label25)
        Me.gbclientinfo.Controls.Add(Me.Label24)
        Me.gbclientinfo.Controls.Add(Me.Label23)
        Me.gbclientinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbclientinfo.Location = New System.Drawing.Point(12, 288)
        Me.gbclientinfo.Name = "gbclientinfo"
        Me.gbclientinfo.Size = New System.Drawing.Size(292, 209)
        Me.gbclientinfo.TabIndex = 16
        Me.gbclientinfo.TabStop = False
        Me.gbclientinfo.Text = "Client Inforamtion"
        '
        'lblend
        '
        Me.lblend.AutoSize = True
        Me.lblend.Location = New System.Drawing.Point(137, 22)
        Me.lblend.Name = "lblend"
        Me.lblend.Size = New System.Drawing.Size(57, 20)
        Me.lblend.TabIndex = 30
        Me.lblend.Text = "Label3"
        Me.lblend.Visible = False
        '
        'lblstart
        '
        Me.lblstart.AutoSize = True
        Me.lblstart.Location = New System.Drawing.Point(53, 22)
        Me.lblstart.Name = "lblstart"
        Me.lblstart.Size = New System.Drawing.Size(57, 20)
        Me.lblstart.TabIndex = 29
        Me.lblstart.Text = "Label3"
        Me.lblstart.Visible = False
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(6, 22)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(26, 20)
        Me.ID.TabIndex = 28
        Me.ID.Text = "ID"
        Me.ID.Visible = False
        '
        'lblrate
        '
        Me.lblrate.AutoSize = True
        Me.lblrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrate.Location = New System.Drawing.Point(127, 132)
        Me.lblrate.Name = "lblrate"
        Me.lblrate.Size = New System.Drawing.Size(103, 20)
        Me.lblrate.TabIndex = 26
        Me.lblrate.Text = "Client Name :"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(127, 98)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(103, 20)
        Me.lblAddress.TabIndex = 25
        Me.lblAddress.Text = "Client Name :"
        '
        'lblclientName
        '
        Me.lblclientName.AutoSize = True
        Me.lblclientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclientName.Location = New System.Drawing.Point(127, 67)
        Me.lblclientName.Name = "lblclientName"
        Me.lblclientName.Size = New System.Drawing.Size(103, 20)
        Me.lblclientName.TabIndex = 24
        Me.lblclientName.Text = "Client Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Client ID :"
        '
        'LBLCLIENTID
        '
        Me.LBLCLIENTID.AutoSize = True
        Me.LBLCLIENTID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCLIENTID.Location = New System.Drawing.Point(127, 42)
        Me.LBLCLIENTID.Name = "LBLCLIENTID"
        Me.LBLCLIENTID.Size = New System.Drawing.Size(26, 20)
        Me.LBLCLIENTID.TabIndex = 22
        Me.LBLCLIENTID.Text = "ID"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(6, 132)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(115, 40)
        Me.Label25.TabIndex = 18
        Me.Label25.Text = "Contract Price" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(monthly basis)"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(5, 98)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(120, 20)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "Client Address :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(12, 67)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(103, 20)
        Me.Label23.TabIndex = 14
        Me.Label23.Text = "Client Name :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.LBLEMPSTATUS)
        Me.GroupBox2.Controls.Add(Me.LBLAGE)
        Me.GroupBox2.Controls.Add(Me.LBLFULLNAME)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.LBLEMPID)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(310, 288)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 171)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Guard Information"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(63, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 20)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Age :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "ID"
        Me.Label2.Visible = False
        '
        'LBLEMPSTATUS
        '
        Me.LBLEMPSTATUS.AutoSize = True
        Me.LBLEMPSTATUS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLEMPSTATUS.Location = New System.Drawing.Point(119, 119)
        Me.LBLEMPSTATUS.Name = "LBLEMPSTATUS"
        Me.LBLEMPSTATUS.Size = New System.Drawing.Size(103, 20)
        Me.LBLEMPSTATUS.TabIndex = 26
        Me.LBLEMPSTATUS.Text = "Client Name :"
        '
        'LBLAGE
        '
        Me.LBLAGE.AutoSize = True
        Me.LBLAGE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLAGE.Location = New System.Drawing.Point(115, 89)
        Me.LBLAGE.Name = "LBLAGE"
        Me.LBLAGE.Size = New System.Drawing.Size(103, 20)
        Me.LBLAGE.TabIndex = 25
        Me.LBLAGE.Text = "Client Name :"
        '
        'LBLFULLNAME
        '
        Me.LBLFULLNAME.AutoSize = True
        Me.LBLFULLNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFULLNAME.Location = New System.Drawing.Point(115, 67)
        Me.LBLFULLNAME.Name = "LBLFULLNAME"
        Me.LBLFULLNAME.Size = New System.Drawing.Size(103, 20)
        Me.LBLFULLNAME.TabIndex = 24
        Me.LBLFULLNAME.Text = "Client Name :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 20)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Employee ID :"
        '
        'LBLEMPID
        '
        Me.LBLEMPID.AutoSize = True
        Me.LBLEMPID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLEMPID.Location = New System.Drawing.Point(115, 42)
        Me.LBLEMPID.Name = "LBLEMPID"
        Me.LBLEMPID.Size = New System.Drawing.Size(26, 20)
        Me.LBLEMPID.TabIndex = 22
        Me.LBLEMPID.Text = "ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Work Status :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 20)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Full Name :"
        '
        'BTNASSIGN
        '
        Me.BTNASSIGN.Location = New System.Drawing.Point(489, 468)
        Me.BTNASSIGN.Name = "BTNASSIGN"
        Me.BTNASSIGN.Size = New System.Drawing.Size(113, 29)
        Me.BTNASSIGN.TabIndex = 30
        Me.BTNASSIGN.Text = "Assign Guard"
        Me.BTNASSIGN.UseVisualStyleBackColor = True
        '
        'assign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 503)
        Me.Controls.Add(Me.BTNASSIGN)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbclientinfo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "assign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.gbclientinfo.ResumeLayout(False)
        Me.gbclientinfo.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbclientinfo As System.Windows.Forms.GroupBox
    Friend WithEvents LBLCLIENTID As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblrate As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblclientName As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LBLEMPSTATUS As System.Windows.Forms.Label
    Friend WithEvents LBLAGE As System.Windows.Forms.Label
    Friend WithEvents LBLFULLNAME As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LBLEMPID As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BTNASSIGN As System.Windows.Forms.Button
    Friend WithEvents lblend As System.Windows.Forms.Label
    Friend WithEvents lblstart As System.Windows.Forms.Label
End Class
