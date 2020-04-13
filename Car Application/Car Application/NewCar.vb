Public Class NewCar
    Public CarName As String
    Public CarColor As String
    Public CarDoor As Integer
    Public CarHorse As String
    Public BoolCreate As Boolean = False
    Public VehicleType As String

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        CarName = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        CarColor = TextBox2.Text
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        CarDoor = NumericUpDown1.Value
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        CarHorse = TextBox3.Text
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        BoolCreate = True
        Me.Close()
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub NewCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Name Of A " & VehicleType
        Label2.Text = "Color Of A" & VehicleType
    End Sub
End Class