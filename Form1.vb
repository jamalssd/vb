Public Class Form1
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With home
            .TopLevel = False
            .TopMost = True
            Panel4.Controls.Add(home)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With form
            .TopLevel = False
            .TopMost = True
            Panel4.Controls.Add(form)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With data
            .TopLevel = False
            .TopMost = True
            Panel4.Controls.Add(data)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With setting
            .TopLevel = False
            .TopMost = True
            Panel4.Controls.Add(setting)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class
