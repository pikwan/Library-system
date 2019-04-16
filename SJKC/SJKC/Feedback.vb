Public Class Feedback
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrontPage.Show()
        Me.Hide()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim sqlconn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand
            Dim connString As String

            connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DB.mdb"
            sqlconn.ConnectionString = connString
            sqlquery.Connection = sqlconn
            sqlconn.Open()
            sqlquery.CommandText = "INSERT INTO survey([ruang], [kepuasan], [ulasan])VALUES(@ruang, @kepuasan, @ulasan)"
            Dim chkstring As String
            If chkP.Checked = True Then
                chkstring = chkP.Text
            ElseIf chkI.Checked = True Then
                chkstring = chkI.Text
            ElseIf chkA.Checked = True Then
                chkstring = chkA.Text
            ElseIf chkPam.Checked = True Then
                chkstring = chkPam.Text
            ElseIf chkS.Checked = True Then
                chkstring = chkS.Text
            End If

            sqlquery.Parameters.AddWithValue("@ruang", chkstring)

            Dim chkstring2 As String
            If rbA.Checked = True Then
                chkstring2 = rbA.Text
            ElseIf rbB.Checked = True Then
                chkstring2 = rbB.Text
            ElseIf rbC.Checked = True Then
                chkstring2 = rbC.Text
            ElseIf rbD.Checked = True Then
                chkstring2 = rbD.Text
            End If

            sqlquery.Parameters.AddWithValue("@kepuasan", chkstring2)
            sqlquery.Parameters.AddWithValue("@ulasan", RichTextBox1.Text)
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
            MsgBox("Thank You!")
            FrontPage.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class