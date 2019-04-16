Imports System.Data.OleDb

Public Class Guru
    Public gidf As String
    Public origin As Boolean = False


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FrontPage.Show()
        Me.Hide()
    End Sub
    Public Sub insert(UID As String)
        Try
            Dim sqlconn As New OleDb.OleDbConnection
            Dim sqlquery As New OleDb.OleDbCommand
            Dim connString As String
            Dim dt As Date = Today
            connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DB.mdb"
            sqlconn.ConnectionString = connString
            sqlquery.Connection = sqlconn
            sqlconn.Open()
            sqlquery.CommandText = "INSERT INTO checkin([UID], [DateT])VALUES(@UID, @DT)"
            sqlquery.Parameters.AddWithValue("@UID", UID)
            sqlquery.Parameters.AddWithValue("@DT", dt)
            sqlquery.ExecuteNonQuery()
            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim username As String
            Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DB.mdb;")
            Dim cmd As OleDbCommand = New OleDbCommand("Select * from GURU where GID= '" & TextBox1.Text & "' ", cn)
            cn.Open()

            Dim rdr As OleDbDataReader
            rdr = cmd.ExecuteReader
            If rdr.HasRows Then
                rdr.Read()
                username = rdr("GID")
                Name = rdr("NAMA")
                gidf = Name

                If (TextBox1.Text = username) Then
                    insert(username)
                    origin = True
                    Pelawat.origin = False
                    Welcome.Show()
                    Me.Close()
                Else
                    MsgBox("Incorrect ID")
                    TextBox1.Clear()
                    cn.Close()
                End If
            Else
                MsgBox("Incorrect ID")
                TextBox1.Clear()
                cn.Close()
            End If
        Catch
            MsgBox("DBERROR : Error logging in, please try again", MsgBoxStyle.Exclamation)
        End Try
    End Sub
End Class