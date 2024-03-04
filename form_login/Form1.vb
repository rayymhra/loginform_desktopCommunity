Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = ("RayyaMahira") And TextBox2.Text = ("secret123") Then
            Form2.Show()
            MsgBox("DONE")
            Me.Hide()

        Else
            MsgBox("ERROR")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
