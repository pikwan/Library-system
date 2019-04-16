Public Class SenaraiPelajar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Admin.Show()
        Me.Hide()
    End Sub
    Public INDEXNO As Integer

    Private Sub SenaraiPelajar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataSet1.STUDENTS' table. You can move, or remove it, as needed.
        Me.STUDENTSTableAdapter.Fill(Me.DBDataSet1.STUDENTS)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        INDEXNO = ListBox1.SelectedIndex + 1
        Kemaskini.Show()
        Me.Hide()
    End Sub
End Class