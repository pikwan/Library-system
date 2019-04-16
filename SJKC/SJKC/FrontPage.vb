Public Class FrontPage
    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        Guru.Show()
        Me.Hide()
    End Sub

    Private Sub btnPwt_Click(sender As Object, e As EventArgs) Handles btnPwt.Click
        Pelawat.Show()
        Me.Hide()
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        Pelajar.Show()
        Me.Hide()
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        AdminLogin.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Feedback.Show()
        Me.Hide()
    End Sub

    Private Sub FrontPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub
End Class
