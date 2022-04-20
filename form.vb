Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Public Class form
    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "oChqScoKyXyuTuXLvXfZ1ekGL1EqqCdoihSLiOXD",
        .BasePath = "https://configuration-23669-default-rtdb.firebaseio.com/"
    }
    Private client As IFirebaseClient



    Private Sub form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show("there was a problem with the internet connection ")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            'PictureBox1.Image = image.FromFile(opf.FileName)
            Label11.Text = ""
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim std As New student() With
            {
            .fullname = TextBox1.Text,
            .studentNumber = TextBox2.Text,
            .math = TextBox3.Text,
            .english = TextBox4.Text,
            .arabic = TextBox5.Text,
            .physics = TextBox6.Text,
            .total = TextBox7.Text,
            .average = TextBox8.Text,
            .GPA = TextBox9.Text,
            .comment = TextBox10.Text
        }
        Dim setter = client.Update("configuration/" + TextBox2.Text, std)
        MessageBox.Show("data updated successfully")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""






    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox7.Text = Val(TextBox3.Text) + Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text)
        TextBox8.Text = Val(TextBox7.Text) / 4
        Try

            If (TextBox8.Text) >= 80 Then
                TextBox9.Text = "A"
            ElseIf (TextBox8.Text) >= 75 Then
                TextBox9.Text = "B+"
            ElseIf (TextBox8.Text) >= 70 Then
                TextBox9.Text = "B"
            ElseIf (TextBox8.Text) >= 65 Then
                TextBox9.Text = "C+"
            ElseIf (TextBox8.Text) >= 60 Then
                TextBox9.Text = "C"
            ElseIf (TextBox8.Text) >= 55 Then
                TextBox9.Text = "D+"
            ElseIf (TextBox8.Text) >= 50 Then
                TextBox9.Text = "D"
            Else : TextBox9.Text = "F"

            End If

        Catch ex As Exception

        End Try

        Try
            If (TextBox8.Text) >= 80 Then
                TextBox10.Text = "DISTINCTION"
            ElseIf (TextBox8.Text) >= 65 Then
                TextBox10.Text = "CREDIT"
            ElseIf (TextBox8.Text) >= 50 Then
                TextBox10.Text = "PASS"
            Else : TextBox10.Text = "Fail"
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub insertBtn_Click(sender As Object, e As EventArgs) Handles insertBtn.Click
        Dim std As New student() With
            {
            .fullname = TextBox1.Text,
            .studentNumber = TextBox2.Text,
            .math = TextBox3.Text,
            .english = TextBox4.Text,
            .arabic = TextBox5.Text,
            .physics = TextBox6.Text,
            .total = TextBox7.Text,
            .average = TextBox8.Text,
            .GPA = TextBox9.Text,
            .comment = TextBox10.Text
        }
        Dim setter = client.Set("configuration/" + TextBox2.Text, std)
        MessageBox.Show("data stored successfully")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim res = client.Get("configuration/" + TextBox2.Text)
        Dim std As New student()
        std = res.ResultAs(Of student)
        TextBox1.Text = std.fullname
        TextBox2.Text = std.studentNumber
        TextBox3.Text = std.math
        TextBox4.Text = std.english
        TextBox5.Text = std.arabic
        TextBox6.Text = std.physics
        TextBox7.Text = std.total
        TextBox8.Text = std.average
        TextBox9.Text = std.GPA
        TextBox10.Text = std.comment
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim res = client.Delete("configuration/" + TextBox2.Text)
        MessageBox.Show("data deleted successfully")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class