Public Class FormPrincipal
    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Button, e As EventArgs) Handles ButtonDecimal.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click, Button0.Click
        TextBoxDisplay.Text += sender.Text
    End Sub

    Private Sub ButtonBorrar_Click(sender As Object, e As EventArgs) Handles ButtonBorrar.Click
        TextBoxDisplay.Text = ""
    End Sub

    Private Sub ButtonSumar_Click(sender As Button, e As EventArgs) Handles ButtonSumar.Click
        Dim numero As Integer = TextBoxDisplay.Text
        TextBoxOperations.Text = numero
        TextBoxDisplay.Text = ""

    End Sub

    Private Sub ButtonIgual_Click(sender As Button, e As EventArgs) Handles ButtonIgual.Click

    End Sub
End Class
