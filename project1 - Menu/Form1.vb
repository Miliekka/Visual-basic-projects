Public Class Form1

    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        Dim O As OpenFileDialog
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub CloseFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseFileToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Dim M As Font
        FontDialog1.ShowDialog()
        M = FontDialog1.Font
        Me.Font = M
    End Sub

    Private Sub PrinterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrinterToolStripMenuItem.Click
        Dim F As PrintDialog
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        Dim S As Color
        ColorDialog1.ShowDialog()
        S = ColorDialog1.Color
        Me.BackColor = S
    End Sub

    Private Sub ServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiceToolStripMenuItem.Click
        Dim newName As String = InputBox("Введите новое имя формы")
        Me.Text = newName
        Dim i As Integer
        i = MsgBox("Закрыть программу?", vbAbort.Abort, "Вывод")
        If i = 6 Then End

    End Sub
End Class
