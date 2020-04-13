Public Class Form1

    Private defaultCar As New Allcars.Car
    Private defaultSportCar As New Allcars.SportCar
    Private Cars As New ArrayList
    Private SelectedCars As Allcars.Car

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboCarType.SelectedIndex = 0
        defaultCar.CarName = "Avanza"
        defaultSportCar.CarName = "Ferrari"
        Cars.Add(defaultCar)
        Cars.Add(defaultSportCar)
        AddAllCars()
    End Sub

    Private Sub AddAllCars()
        For Each car As Allcars.Car In Cars
            ListCar.Items.Add(car.CarName)
        Next
    End Sub

    Private Sub ShowCarInfo()
        MessageBox.Show(Cars(ListCar.SelectedIndex).ToString(), "Info")
    End Sub

    'Button Click Event
    Private Sub Btn_Name_Click(sender As Object, e As EventArgs) Handles Btn_Name.Click
        Cars(ListCar.SelectedIndex).CarName = InputBox("Please Enter A Name for Your Car" & Environment.NewLine & "Old Car:" & Cars(ListCar.SelectedIndex).CarName, "Name")
        ListCar.Items(ListCar.SelectedIndex) = Cars(ListCar.SelectedIndex).CarName
    End Sub

    Private Sub Btn_Color_Click(sender As Object, e As EventArgs) Handles Btn_Color.Click
        Cars(ListCar.SelectedIndex).Color = InputBox("Please Enter A Color Of Your Car" & Environment.NewLine & "Old Color:" & Cars(ListCar.SelectedIndex).Color, "Color", Cars(ListCar.SelectedIndex).Color)
    End Sub

    Private Sub Btn_ShowInfo_Click(sender As Object, e As EventArgs) Handles Btn_ShowInfo.Click
        ShowCarInfo()
    End Sub

    Private Sub Btn_Door_Click(sender As Object, e As EventArgs) Handles Btn_Door.Click
        Cars(ListCar.SelectedIndex).NumberOfDoor = CType(InputBox("Please Enter The Number Of Doors" & Environment.NewLine & "Old Door:" & CType(Cars(ListCar.SelectedIndex).NumberOfDoor, String), "Doors"), Integer)
    End Sub

    Private Sub Btn_Accelerate_Click(sender As Object, e As EventArgs) Handles Btn_Accelerate.Click
        Cars(ListCar.SelectedIndex).Accelerate(CType(InputBox("Enter A Value", "Accelerate" & Environment.NewLine & "Old Speed:" & CType(Cars(ListCar.SelectedIndex).Speed, String), Cars(ListCar.SelectedIndex).Speed), Integer))
    End Sub

    Private Sub Btn_TWR_Click(sender As Object, e As EventArgs) Handles Btn_TWR.Click
        MessageBox.Show(CType(Cars(ListCar.SelectedIndex).GetTWR, String), "Power To Weight Ratio")
    End Sub

    Private Sub ListCar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListCar.SelectedIndexChanged
        If ListCar.SelectedIndex <> -1 Then
            Cars(ListCar.SelectedIndex) = Cars(ListCar.SelectedIndex)
        End If
    End Sub

    Private Sub Btn_NewCar_Click(sender As Object, e As EventArgs) Handles Btn_NewCar.Click
        AddNewCar()
    End Sub

    Private Sub AddNewCar()
        Dim addNewCar As New NewCar
        addNewCar.VehicleType = ComboCarType.SelectedItem
        addNewCar.ShowDialog()
        Dim newcar1
        If addNewCar.BoolCreate = True Then
            If ComboCarType.SelectedIndex = 0 Then
                newcar1 = New Allcars.Car
            ElseIf ComboCarType.SelectedIndex = 1 Then
                newcar1 = New Allcars.SportCar
            ElseIf ComboCarType.SelectedIndex = 2 Then
                newcar1 = New Allcars.Truck
            End If
            Using newcar1
                With newcar1
                    .CarName = addNewCar.CarName
                    .Color = addNewCar.CarColor
                    .NumberOfDoor = addNewCar.CarDoor
                    .HorsePower = addNewCar.CarHorse
                End With
                Cars.Add(newcar1)
                ListCar.Items.Add(newcar1.CarName)
            End Using
        End If
    End Sub
End Class
