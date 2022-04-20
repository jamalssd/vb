Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces
Imports Newtonsoft.Json

Public Class data
    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "oChqScoKyXyuTuXLvXfZ1ekGL1EqqCdoihSLiOXD",
        .BasePath = "https://configuration-23669-default-rtdb.firebaseio.com/"
    }
    Private client As IFirebaseClient
    Private Sub data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show("there is a problem with your internet")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.Rows.Clear()
        Dim res As FirebaseResponse = client.Get("counter")
        Dim counter = Integer.Parse(res.ResultAs(Of String))
        For i = 1 To counter
            Dim res2 = client.Get("sno/" + Convert.ToString(i) + "studentNumber")
            Dim studentNumber = res2.ResultAs(Of String)

            Dim res3 = client.Get("configuration/" + studentNumber)
            Dim std = res3.ResultAs(Of student)

            If (std.fullname <> "") Then
                DataGridView1.Rows.Add(std.fullname, std.studentNumber, std.math, std.english, std.arabic, std.physics, std.total, std.average, std.GPA, std.comment)
            End If
        Next
    End Sub


End Class