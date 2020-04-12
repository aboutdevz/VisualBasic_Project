Public Class frmCamera


    Private Sub OpenPreviewWindow()
        Dim iHeight As Integer = PictureBox1.Height
        Dim iWidth As Integer = PictureBox1.Width
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, 480, PictureBox1.Handle.ToInt32, 0)
        If SendMessage(hHwnd, WM_Cap_Paki_CONNECT, iDevice, 0) Then
            SendMessage(hHwnd, WM_Cap_SET_SCALE, True, 0)
            SendMessage(hHwnd, WM_Cap_SET_PREVIEWRATE, 66, 0)
            SendMessage(hHwnd, WM_Cap_SET_PREVIEW, True, 0)
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, PictureBox1.Width, PictureBox1.Height, SWP_NOMOVE Or SWP_NOZORDER)
        Else
            DestroyWindow(hHwnd)
        End If
    End Sub

    Private Sub ClosePreviewWindow()
        SendMessage(hHwnd, WM_Cap_Paki_DISCONNECT, iDevice, 0)
        DestroyWindow(hHwnd)
    End Sub

   


    

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call OpenPreviewWindow()
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Button4.Text = "Capture" Then

            Button4.Text = "Save"

            Dim Data As IDataObject
            Dim Bmap As Image
            SendMessage(hHwnd, WM_Cap_EDIT_COPY, 0, 0)
            Data = Clipboard.GetDataObject()

            If Data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
                Bmap = CType(Data.GetData(GetType(System.Drawing.Bitmap)), Image)
                PictureBox1.Image = Bmap
                ClosePreviewWindow()

            End If

        ElseIf Button4.Text = "Save" Then

            Dim savefiledialog1 As New SaveFileDialog

            savefiledialog1.Title = "save File"
            savefiledialog1.FileName = "*.bmp"
            savefiledialog1.Filter = "Bitmap |*.bmp* "

            If savefiledialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PictureBox1.Image.Save(savefiledialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp)

            End If

            Me.Close()

        End If
    End Sub
End Class