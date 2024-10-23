Public Class FormPrincipal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnToCV_Click(sender As Object, e As EventArgs) Handles BtnToCV.Click
        Dim FILE_NAME As String = "C:\Users\Alumno\Desktop\19081997.pdf"

        If System.IO.File.Exists(FILE_NAME) = True Then
            Process.Start(FILE_NAME)
        Else
            MsgBox("File Does Not Exist")
        End If
    End Sub

    Private Sub BtnToWeb_Click(sender As Object, e As EventArgs) Handles BtnToWeb.Click
        WebBrowser1.Navigate(New Uri("http://www.google.de"))
        'También se podría hacer de con el objeto Process:
        'Process.Start("http://www.google.de")'
    End Sub

    Private Sub BtnToImage_Click(sender As Object, e As EventArgs) Handles BtnToImage.Click
        PictureBox1.Image = Image.FromFile("C:\Users\Alumno\Desktop\1121.jpg")
        'También se podría hacer de con el objeto Process:
        'Process.Start("C:\Users\Alumno\Desktop\1121.jpg")'
    End Sub

    Private Sub ButtonBtnToInternFile_Click(sender As Object, e As EventArgs) Handles BtnToInternFile.Click
        Process.Start("D:\Repos David\DAM2--Servicios y procesos")
    End Sub
End Class
