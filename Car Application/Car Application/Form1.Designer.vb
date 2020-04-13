<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Btn_Name = New System.Windows.Forms.Button()
        Me.Btn_Color = New System.Windows.Forms.Button()
        Me.Btn_ShowInfo = New System.Windows.Forms.Button()
        Me.Btn_Door = New System.Windows.Forms.Button()
        Me.Btn_Accelerate = New System.Windows.Forms.Button()
        Me.Btn_TWR = New System.Windows.Forms.Button()
        Me.ListCar = New System.Windows.Forms.ListBox()
        Me.Btn_NewCar = New System.Windows.Forms.Button()
        Me.ComboCarType = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Btn_Name
        '
        Me.Btn_Name.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Name.Location = New System.Drawing.Point(502, 100)
        Me.Btn_Name.Name = "Btn_Name"
        Me.Btn_Name.Size = New System.Drawing.Size(160, 49)
        Me.Btn_Name.TabIndex = 0
        Me.Btn_Name.Text = "Name"
        Me.Btn_Name.UseVisualStyleBackColor = True
        '
        'Btn_Color
        '
        Me.Btn_Color.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Color.Location = New System.Drawing.Point(502, 155)
        Me.Btn_Color.Name = "Btn_Color"
        Me.Btn_Color.Size = New System.Drawing.Size(160, 49)
        Me.Btn_Color.TabIndex = 0
        Me.Btn_Color.Text = "Color"
        Me.Btn_Color.UseVisualStyleBackColor = True
        '
        'Btn_ShowInfo
        '
        Me.Btn_ShowInfo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ShowInfo.Location = New System.Drawing.Point(502, 375)
        Me.Btn_ShowInfo.Name = "Btn_ShowInfo"
        Me.Btn_ShowInfo.Size = New System.Drawing.Size(160, 49)
        Me.Btn_ShowInfo.TabIndex = 0
        Me.Btn_ShowInfo.Text = "Show Info"
        Me.Btn_ShowInfo.UseVisualStyleBackColor = True
        '
        'Btn_Door
        '
        Me.Btn_Door.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Door.Location = New System.Drawing.Point(502, 210)
        Me.Btn_Door.Name = "Btn_Door"
        Me.Btn_Door.Size = New System.Drawing.Size(160, 49)
        Me.Btn_Door.TabIndex = 1
        Me.Btn_Door.Text = "Door"
        Me.Btn_Door.UseVisualStyleBackColor = True
        '
        'Btn_Accelerate
        '
        Me.Btn_Accelerate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Accelerate.Location = New System.Drawing.Point(502, 265)
        Me.Btn_Accelerate.Name = "Btn_Accelerate"
        Me.Btn_Accelerate.Size = New System.Drawing.Size(160, 49)
        Me.Btn_Accelerate.TabIndex = 2
        Me.Btn_Accelerate.Text = "Accelerate"
        Me.Btn_Accelerate.UseVisualStyleBackColor = True
        '
        'Btn_TWR
        '
        Me.Btn_TWR.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_TWR.Location = New System.Drawing.Point(502, 320)
        Me.Btn_TWR.Name = "Btn_TWR"
        Me.Btn_TWR.Size = New System.Drawing.Size(160, 49)
        Me.Btn_TWR.TabIndex = 3
        Me.Btn_TWR.Text = "TWR"
        Me.Btn_TWR.UseVisualStyleBackColor = True
        '
        'ListCar
        '
        Me.ListCar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListCar.FormattingEnabled = True
        Me.ListCar.ItemHeight = 21
        Me.ListCar.Location = New System.Drawing.Point(13, 45)
        Me.ListCar.Name = "ListCar"
        Me.ListCar.Size = New System.Drawing.Size(483, 382)
        Me.ListCar.TabIndex = 4
        '
        'Btn_NewCar
        '
        Me.Btn_NewCar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_NewCar.Location = New System.Drawing.Point(502, 45)
        Me.Btn_NewCar.Name = "Btn_NewCar"
        Me.Btn_NewCar.Size = New System.Drawing.Size(160, 49)
        Me.Btn_NewCar.TabIndex = 5
        Me.Btn_NewCar.Text = "New Car"
        Me.Btn_NewCar.UseVisualStyleBackColor = True
        '
        'ComboCarType
        '
        Me.ComboCarType.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboCarType.FormattingEnabled = True
        Me.ComboCarType.Items.AddRange(New Object() {"Car", "SportCar", "Truck"})
        Me.ComboCarType.Location = New System.Drawing.Point(667, 53)
        Me.ComboCarType.Name = "ComboCarType"
        Me.ComboCarType.Size = New System.Drawing.Size(121, 33)
        Me.ComboCarType.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboCarType)
        Me.Controls.Add(Me.Btn_NewCar)
        Me.Controls.Add(Me.ListCar)
        Me.Controls.Add(Me.Btn_TWR)
        Me.Controls.Add(Me.Btn_Accelerate)
        Me.Controls.Add(Me.Btn_Door)
        Me.Controls.Add(Me.Btn_ShowInfo)
        Me.Controls.Add(Me.Btn_Color)
        Me.Controls.Add(Me.Btn_Name)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_Name As Button
    Friend WithEvents Btn_Color As Button
    Friend WithEvents Btn_ShowInfo As Button
    Friend WithEvents Btn_Door As Button
    Friend WithEvents Btn_Accelerate As Button
    Friend WithEvents Btn_TWR As Button
    Friend WithEvents ListCar As ListBox
    Friend WithEvents Btn_NewCar As Button
    Friend WithEvents ComboCarType As ComboBox
End Class
