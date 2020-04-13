Namespace Allcars
    'Car SuperClass
    Class Car
        Implements IDisposable

        'public and private number
        Public CarName As String
        Public Color As String
        Private intNumberOfDoor As Integer
        Private intSpeed As Integer
        Private intHorsePower As Integer

        'Add Contructor
        Sub New()
            Color = "White"
            intNumberOfDoor = 4
            intSpeed = 0
        End Sub
        'formated Message
        Public Overrides Function ToString() As String
            Return "Car Name: " & CarName & Environment.NewLine & "Car Color: " & Color & Environment.NewLine & "Number Of Door: " & intNumberOfDoor & Environment.NewLine & "Car Speed: " & intSpeed
        End Function
        'get speed
        Public ReadOnly Property Speed() As Integer
            Get
                Return intSpeed
            End Get
        End Property
        'Get HorsePower
        Public Property HorsePower() As Integer
            Get
                Return intHorsePower
            End Get
            Set(value As Integer)
                intHorsePower = value
            End Set
        End Property
        'to accelerate
        Public Sub Accelerate(ByVal AccelerateBy As Integer)
            intSpeed += AccelerateBy
        End Sub
        'Get Number Of door
        Public Property NumberOfDoor() As Integer
            Get
                Return intNumberOfDoor
            End Get
            Set(value As Integer)
                If value >= 2 And value <= 5 Then
                    intNumberOfDoor = value
                Else
                    MsgBox("Number Of door you enter not valid")
                End If
            End Set
        End Property
        'Is Moving??
        Public Function isMoving() As Boolean
            If Speed = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    ' TODO: dispose managed state (managed objects).
                End If

                ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
                ' TODO: set large fields to null.
            End If
            disposedValue = True
        End Sub

        ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
        'Protected Overrides Sub Finalize()
        '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        '    Dispose(False)
        '    MyBase.Finalize()
        'End Sub

        ' This code added by Visual Basic to correctly implement the disposable pattern.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
            Dispose(True)
            ' TODO: uncomment the following line if Finalize() is overridden above.
            ' GC.SuppressFinalize(Me)
        End Sub
#End Region
    End Class
    'SportCar Class
    Class SportCar
        Inherits Car
        Sub New()
            Color = "Red"
            NumberOfDoor = 2
            HorsePower = 500.0
            Weight = 1000.0
        End Sub
        Private Weight As Integer
        'get SportCar Info
        Public Function GetSportCarInfo() As String
            Return "Car Name: " & CarName & Environment.NewLine & "Car Color: " & Color & Environment.NewLine & "Number Of Door: " & NumberOfDoor & Environment.NewLine & "Car Speed: " & Speed & Environment.NewLine & "Horsepower: " & HorsePower()
        End Function
        'Get Power to Weight Ratio
        Public Function GetTWR() As Double
            Return CType(HorsePower, Double) / CType(Weight, Double)
        End Function
    End Class
    'Truck Class
    Class Truck
        Inherits Car
        Private TruckBedLenght As BedLenght
        Private TruckCabLenght As CabLenght

        Public Property TheBedLenght() As BedLenght
            Get
                Return TruckBedLenght
            End Get
            Set(value As BedLenght)
                If value >= 0 And value <= 0 Then
                    TruckBedLenght = value
                End If
            End Set
        End Property

        Public Property TheCabLenght As CabLenght
            Get
                Return TruckCabLenght
            End Get
            Set(value As CabLenght)
                If value >= 0 And value <= 0 Then
                    TruckCabLenght = value
                End If
            End Set
        End Property
        'Bedlenght Enumeration: Short,Medium,Long
        Enum BedLenght As Integer
            ShortBed = 0
            MediumBed = 1
            LongBed = 2
        End Enum
        'Cab Lenght Enumeration
        Enum CabLenght As Integer
            SingleCab = 0
            ExtendCab = 1
            CrewMax = 2
        End Enum
        Public Function GetTruckInfo() As String
            Return "Car Name: " & CarName & Environment.NewLine & "Car Color: " & Color & Environment.NewLine & "Number Of Door: " & NumberOfDoor & Environment.NewLine & "Car Speed: " & Speed & Environment.NewLine & "Truck Bed Size: " & TruckBedLenght & Environment.NewLine & "Truck Cab Size: " & TruckCabLenght
        End Function
    End Class
End Namespace