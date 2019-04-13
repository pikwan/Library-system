Public Class AdminLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrontPage.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Admin.Show()
        Me.Hide()
    End Sub
End Class