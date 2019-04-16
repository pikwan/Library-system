Public Class Welcome
    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Guru.origin = True) Then
            Label1.Text = Guru.gidf
        ElseIf (Pelawat.origin = True) Then
            Label1.Text = Pelawat.gidf
        Else
            Label1.Text = Pelajar.GIDF
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrontPage.Show()
        Me.Close()
    End Sub
End Class