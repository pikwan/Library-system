Public Class Pelawat
    Public gidf As String
    Public origin As Boolean = False
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FrontPage.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gidf = TextBox1.Text
        Try
            Dim sqlconn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand
            Dim connString As String

            connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DB.mdb"
            sqlconn.ConnectionString = connString
            sqlquery.Connection = sqlconn
            sqlconn.Open()
            sqlquery.CommandText = "INSERT INTO PELAWAT([PNAMA], [PMAJIKAN], [ORIGIN])VALUES(@Username, @comp, @neg)"
            sqlquery.Parameters.AddWithValue("@Username", TextBox1.Text)
            sqlquery.Parameters.AddWithValue("@comp", TextBox2.Text)
            sqlquery.Parameters.AddWithValue("@neg", ComboBox1.Text)
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
            Welcome.Show()
            origin = True
            Guru.origin = False
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Pelawat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataSet.PELAWAT' table. You can move, or remove it, as needed.


    End Sub
End Class