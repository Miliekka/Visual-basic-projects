Public Class Form2
    Dim ww, wh As Integer
    Dim dx, dy As Integer
    Dim ddy As Integer = 10

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dx = 5
        dy = 5
        ww = My.Computer.Screen.WorkingArea.Width
        wh = My.Computer.Screen.WorkingArea.Height
        Me.Width = 300
        Me.Top = wh / 5
        Me.Left = ww / 6

    End Sub

    Private Sub Form2_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Me.Text = Str(MousePosition.Y)
    End Sub

    Private Sub Form2_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Me.Text = DateTime.Now
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Text = DateTime.Now
        Me.Left = Me.Left + dx
        If Me.Left > 467 Then dx = -dx
        If Me.Left < 0 Then dx = -dx
        Me.Top = Me.Top + dy
        If Me.Top > 247 Then dy = -dy
        If Me.Top < 0 Then dy = -dy
        Me.Width += ddy * 2
        If Me.Width >= 500 Then
            Me.Width = 500
            ddy = -1
        ElseIf Me.Width <= 300 Then
            Me.Width = 300
            ddy = 1
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.BackColor = Color.FromArgb(Rnd() * 255, Rnd() * 255, Rnd() * 255)
    End Sub
End Class