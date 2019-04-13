Public Class Admin
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AdminLogin.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SenaraiPelajar.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SenaraiPelawat.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SenaraiGuru.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AnalisisPengguna.Show()
        Me.Hide()
    End Sub
End Class