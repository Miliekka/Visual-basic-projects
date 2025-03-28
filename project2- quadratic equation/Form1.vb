Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Aa, Bb, Cc, Xx1, Xx2, Yy1, Errr, Dd As Single
        Aa = TextBox1.Text
        Bb = TextBox2.Text
        Cc = TextBox3.Text
        Yy1 = 0
        Xx1 = 0
        Xx2 = 0

        Dd = Bb ^ 2 - 4 * Aa * Cc
        If Dd > 0 Then
            Xx1 = Math.Round((-Bb + Math.Sqrt(Dd)) / (2 * Aa), 1)
            Xx2 = Math.Round((-Bb - Math.Sqrt(Dd)) / (2 * Aa), 1)
            Call Abcx1x2(Aa, Bb, Cc, Xx1, Yy1, Dd, Errr)
            MessageBox.Show($"В уравнении 2 корня: x1 = {Xx1}, x2 = {Xx2}")
        ElseIf Dd = 0 Then
            Xx1 = -Bb / (2 * Aa)
            Call Abcx1x2(Aa, Bb, Cc, Xx1, Yy1, Dd, Errr)
            MessageBox.Show($"В уравнении 1 корень: x1 = {Xx1}")
        Else
            MessageBox.Show("В уравнении нет корней")
        End If
    End Sub
    Private Sub Abcx1x2(ByVal A As Single, ByVal B As Single, ByVal C As Single, ByRef x As Single,
        ByRef y As Single, ByVal D As Single, ByRef ER As Integer)

        y = A * x * x + B * x + C
    End Sub


End Class
