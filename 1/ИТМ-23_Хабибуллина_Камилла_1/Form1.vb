Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim enteredPassword As String = TextBoxPassword.Text
        If enteredPassword = "secret" Then
            Dim form2 As New Form2()
            form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Неправильный пароль")
        End If
    End Sub


End Class