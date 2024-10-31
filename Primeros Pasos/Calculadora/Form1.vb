Public Class FormPrincipal

    Dim memoria1 As Decimal
    Dim memoria2 As Decimal
    Dim signo As String
    Dim resultado As Decimal

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Button, e As EventArgs) Handles ButtonDecimal.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click, Button0.Click
        TextBoxDisplay.Text += sender.Text
    End Sub

    Private Sub ButtonBorrar_Click(sender As Object, e As EventArgs) Handles ButtonBorrar.Click
        TextBoxDisplay.Clear()
    End Sub

    Private Sub ButtonSumar_Click(sender As Button, e As EventArgs) Handles ButtonSumar.Click
        Try
            If TextBoxDisplay.Text <> "" Then
                memoria1 = Decimal.Parse(TextBoxDisplay.Text)
                signo = "+"
                TextBoxDisplay.Clear()
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ButtonMenos_Click(sender As Object, e As EventArgs) Handles ButtonMenos.Click
        Try
            If TextBoxDisplay.Text <> "" Then
                memoria1 = Decimal.Parse(TextBoxDisplay.Text)
                signo = "-"
                TextBoxDisplay.Clear()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonMult_Click(sender As Object, e As EventArgs) Handles ButtonMult.Click
        Try
            If TextBoxDisplay.Text <> "" Then
                memoria1 = Decimal.Parse(TextBoxDisplay.Text)
                signo = "*"
                TextBoxDisplay.Clear()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ButtonDiv_Click(sender As Object, e As EventArgs) Handles ButtonDiv.Click
        Try
            If TextBoxDisplay.Text <> "" Then
                memoria1 = Decimal.Parse(TextBoxDisplay.Text)
                signo = "/"
                TextBoxDisplay.Clear()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ButtonExp_Click(sender As Object, e As EventArgs) Handles ButtonExp.Click
        Try
            If TextBoxDisplay.Text <> "" Then
                memoria1 = Decimal.Parse(TextBoxDisplay.Text)
                signo = "^"
                TextBoxDisplay.Clear()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ButtonIgual_Click(sender As Button, e As EventArgs) Handles ButtonIgual.Click
        Try
            If TextBoxDisplay.Text <> "" And memoria1 <> 0.0 Then
                memoria2 = Decimal.Parse(TextBoxDisplay.Text)
                Calcular()

            End If

        Catch ex As Exception

        End Try
    End Sub

    'SI QUEREMOS RETORNAR UN VALOR EN VB TENEMOS QUE CREAR UNA FUNCIÓN Y NO UNA SUBRUTINA'
    Private Function Calcular()
        Select Case signo
            Case "+"
                TextBoxDisplay.Text = memoria1 + memoria2
                resultado += TextBoxDisplay.Text
            Case "-"
                TextBoxDisplay.Text = memoria1 - memoria2
                resultado += TextBoxDisplay.Text
            Case "*"
                TextBoxDisplay.Text = memoria1 * memoria2
                resultado += TextBoxDisplay.Text
            Case "/"
                TextBoxDisplay.Text = memoria1 / memoria2
                resultado += TextBoxDisplay.Text
            Case "^"
                TextBoxDisplay.Text = memoria1 ^ memoria2
                resultado += TextBoxDisplay.Text
        End Select
        Return resultado
    End Function

End Class
