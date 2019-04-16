Public Class SenaraiPelawat
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub SenaraiPelawat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataSet.PELAWAT' table. You can move, or remove it, as needed.
        Me.PELAWATTableAdapter.Fill(Me.DBDataSet.PELAWAT)

    End Sub
End Class