Public Class Randomized
    Private Messages As New ArrayList

    Public Sub addMessage(ByVal Message As String)
        Messages.Add(Message)
    End Sub
    Public Sub ShowMessage()
        Dim randomNum As New Random
        Dim rand As Integer
        rand = randomNum.Next(0, Messages.Count - 1)
        MsgBox(Messages.Item(rand), MsgBoxStyle.Information)
    End Sub
End Class
