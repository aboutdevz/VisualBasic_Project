<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class client
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
        Me.gbclientinfo = New System.Windows.Forms.GroupBox
        Me.endDate = New System.Windows.Forms.DateTimePicker
        Me.strtdate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.LBLCLIENTID = New System.Windows.Forms.Label
        Me.btnUpdateClient = New System.Windows.Forms.Button
        Me.btnClientsave = New System.Windows.Forms.Button
        Me.txtrate = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtClientadd = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtClinetName = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ID = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.gbclientinfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 51)
        Me.Panel1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Location = New System.Drawing.Point(3, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(348, 33)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Client's Information"
        '
        'gbclientinfo
        '
        Me.gbclientinfo.Controls.Add(Me.endDate)
        Me.gbclientinfo.Controls.Add(Me.strtdate)
        Me.gbclientinfo.Controls.Add(Me.Label2)
        Me.gbclientinfo.Controls.Add(Me.Label1)
        Me.gbclientinfo.Controls.Add(Me.LBLCLIENTID)
        Me.gbclientinfo.Controls.Add(Me.btnUpdateClient)
        Me.gbclientinfo.Controls.Add(Me.btnClientsave)
        Me.gbclientinfo.Controls.Add(Me.txtrate)
        Me.gbclientinfo.Controls.Add(Me.Label25)
        Me.gbclientinfo.Controls.Add(Me.txtClientadd)
        Me.gbclientinfo.Controls.Add(Me.Label24)
        Me.gbclientinfo.Controls.Add(Me.txtClinetName)
        Me.gbclientinfo.Controls.Add(Me.Label23)
        Me.gbclientinfo.Location = New System.Drawing.Point(8, 70)
        Me.gbclientinfo.Name = "gbclientinfo"
        Me.gbclientinfo.Size = New System.Drawing.Size(452, 180)
        Me.gbclientinfo.TabIndex = 15
        Me.gbclientinfo.TabStop = False
        Me.gbclientinfo.Text = "Information"
        '
        'endDate
        '
        Me.endDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.endDate.Location = New System.Drawing.Point(252, 112)
        Me.endDate.Name = "endDate"
        Me.endDate.Size = New System.Drawing.Size(92, 20)
        Me.endDate.TabIndex = 26
        '
        'strtdate
        '
        Me.strtdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.strtdate.Location = New System.Drawing.Point(90, 113)
        Me.strtdate.Name = "strtdate"
        Me.strtdate.Size = New System.Drawing.Size(92, 20)
        Me.strtdate.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(188, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "End Date :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Start Date:"
        '
        'LBLCLIENTID
        '
        Me.LBLCLIENTID.AutoSize = True
        Me.LBLCLIENTID.Location = New System.Drawing.Point(327, 20)
        Me.LBLCLIENTID.Name = "LBLCLIENTID"
        Me.LBLCLIENTID.Size = New System.Drawing.Size(18, 13)
        Me.LBLCLIENTID.TabIndex = 22
        Me.LBLCLIENTID.Text = "ID"
        Me.LBLCLIENTID.Visible = False
        '
        'btnUpdateClient
        '
        Me.btnUpdateClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdateClient.Location = New System.Drawing.Point(363, 145)
        Me.btnUpdateClient.Name = "btnUpdateClient"
        Me.btnUpdateClient.Size = New System.Drawing.Size(83, 29)
        Me.btnUpdateClient.TabIndex = 21
        Me.btnUpdateClient.Text = "Update"
        Me.btnUpdateClient.UseVisualStyleBackColor = True
        '
        'btnClientsave
        '
        Me.btnClientsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClientsave.Location = New System.Drawing.Point(274, 145)
        Me.btnClientsave.Name = "btnClientsave"
        Me.btnClientsave.Size = New System.Drawing.Size(83, 29)
        Me.btnClientsave.TabIndex = 20
        Me.btnClientsave.Text = "New"
        Me.btnClientsave.UseVisualStyleBackColor = True
        '
        'txtrate
        '
        Me.txtrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrate.Location = New System.Drawing.Point(90, 74)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(228, 22)
        Me.txtrate.TabIndex = 19
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(8, 79)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(76, 26)
        Me.Label25.TabIndex = 18
        Me.Label25.Text = "Contract Price" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(monthly basis)"
        '
        'txtClientadd
        '
        Me.txtClientadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientadd.Location = New System.Drawing.Point(91, 46)
        Me.txtClientadd.Name = "txtClientadd"
        Me.txtClientadd.Size = New System.Drawing.Size(329, 22)
        Me.txtClientadd.TabIndex = 15
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(8, 54)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 13)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "Client Address :"
        '
        'txtClinetName
        '
        Me.txtClinetName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClinetName.Location = New System.Drawing.Point(91, 18)
        Me.txtClinetName.Name = "txtClinetName"
        Me.txtClinetName.Size = New System.Drawing.Size(228, 22)
        Me.txtClinetName.TabIndex = 13
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(15, 23)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(70, 13)
        Me.Label23.TabIndex = 14
        Me.Label23.Text = "Client Name :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 256)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 201)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 16)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(451, 182)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.DataGridView2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(443, 156)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "List of Client"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(335, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 29)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Assign Guard"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(11, 6)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(426, 109)
        Me.DataGridView2.TabIndex = 16
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(443, 156)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Reminders"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(426, 144)
        Me.DataGridView1.TabIndex = 17
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(11, 54)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(18, 13)
        Me.ID.TabIndex = 27
        Me.ID.Text = "ID"
        Me.ID.Visible = False
        '
        'client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 473)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbclientinfo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "client"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.gbclientinfo.ResumeLayout(False)
        Me.gbclientinfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbclientinfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtrate As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtClientadd As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtClinetName As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdateClient As System.Windows.Forms.Button
    Friend WithEvents btnClientsave As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LBLCLIENTID As System.Windows.Forms.Label
    Friend WithEvents endDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents strtdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
