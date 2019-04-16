Public Class Kemaskini
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Kemaskini_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataSet.STUDENTS' table. You can move, or remove it, as needed.
        Me.STUDENTSTableAdapter.Fill(Me.DBDataSet.STUDENTS)
        ' SenaraiPelajar.INDEXNO
    End Sub

    Private Sub NAMA_TextChanged(sender As Object, e As EventArgs) Handles NAMA.TextChanged

    End Sub

End Class