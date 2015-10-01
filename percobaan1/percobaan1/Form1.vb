Public Class Form1

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If Me.BackColor = Color.Black Then
            Me.BackColor = Color.Blue
        Else
            Me.BackColor = Color.Black
        End If
    End Sub
End Class
