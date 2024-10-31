Public Class FormPrincipal
    'Declaramos 4 variables:
    'Tres decimales, en los cuales guardaremos los números que usaremos para operar'
    'Un String en el que guardaremos el signo para después elegir la operación deseada'
    Dim memoria1 As Decimal
    Dim memoria2 As Decimal
    Dim signo As String
    Dim resultado As Decimal

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Esta función se utiliza para rellenar el TextBox en función del número que pulses. Esta función maneja todos los números del 0 al 9, y también maneja la coma'
    Private Sub Button1_Click(sender As Button, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click, Button0.Click
        TextBoxDisplay.Text += sender.Text
    End Sub

    'Esta función se utiliza para rellenar el TextBox cuando pulsamos la coma.'
    'Ponemos un control de errores en la que nos cercioramos de que no exista ya una coma.'
    'Si ya existe, no hace nada, pero si no existe y entra en el else, añade una coma al texto'
    Private Sub ButtonDecimal_Click(sender As Object, e As EventArgs) Handles ButtonDecimal.Click
        If TextBoxDisplay.Text.Contains(",") Then

        Else
            TextBoxDisplay.Text += sender.Text
        End If
    End Sub
    'Subtarea para borrar el contenido del TextBox'
    Private Sub ButtonBorrar_Click(sender As Object, e As EventArgs) Handles ButtonBorrar.Click
        TextBoxDisplay.Clear()
    End Sub

    'Subtarea que realiza la operación de sumar'
    'Con un Try controlamos la excepción de error, y dentro hacemos un condicional:
    'Si el display del textbox no está vacío, guardamos en la variable global memoria1 el valor del display parseado a decimal, y pasamos el signo +'
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
    'Subtarea que realiza la operación de restar'
    'Con un Try controlamos la excepción de error, y dentro hacemos un condicional:
    'Si el display del textbox no está vacío, guardamos en la variable global memoria1 el valor del display parseado a decimal, y pasamos el signo -'
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
    'Subtarea que realiza la operación de multiplicar'
    'Con un Try controlamos la excepción de error, y dentro hacemos un condicional:
    'Si el display del textbox no está vacío, guardamos en la variable global memoria1 el valor del display parseado a decimal, y pasamos el signo *'
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
    'Subtarea que realiza la operación de dividir'
    'Con un Try controlamos la excepción de error, y dentro hacemos un condicional:
    'Si el display del textbox no está vacío, guardamos en la variable global memoria1 el valor del display parseado a decimal, y pasamos el signo /'
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
    'Subtarea que realiza la operación del exponencial'
    'Con un Try controlamos la excepción de error, y dentro hacemos un condicional:
    'Si el display del textbox no está vacío, guardamos en la variable global memoria1 el valor del display parseado a decimal, y pasamos el signo ^'
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
    'Subtarea que realiza la igualación de la operación'
    'Con un Try controlamos la excepción de error, y dentro hacemos un condicional:
    'Si el display del textbox no está vacío y el valor guardado en la memoria1 es distinto de 0, guardamos en la variable global memoria2 el valor actual del display parseado a decimal, y ejecutamos la función calcular, en la cual detectará el signo'
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
    'En esta función planteamos un switch case para que rescate el valor de la variable global signo. Una vez rescatado el signo, se realiza la operación correspondiente al case en el que entre'
    'Por último, guardamos en la variable resultado la operación, y la retornamos para futuros usos'
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
