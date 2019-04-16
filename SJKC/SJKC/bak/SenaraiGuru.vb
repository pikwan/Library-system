Public Class SenaraiGuru
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub SenaraiGuru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
<<<<<<< HEAD

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub
=======
        'TODO: This line of code loads data into the 'DBDataSet.GURU' table. You can move, or remove it, as needed.
        Me.GURUTableAdapter.Fill(Me.DBDataSet.GURU)
        'TODO: This line of code loads data into the 'DBDataSet.CheckIn' table. You can move, or remove it, as needed.
        ' Me.CheckInTableAdapter.Fill('Me.DBDataSet.CheckIn)

    End Sub
>>>>>>> 32eca1f0418fd9574b5b1d6b4d89a86f567bcecd
End Class