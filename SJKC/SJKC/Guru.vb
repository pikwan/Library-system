Imports System.Data.OleDb

Public Class Guru
    Public gidf As String
    Public origin As Boolean = False


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FrontPage.Show()
        Me.Hide()
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
                    Welcome.Show()

                    origin = True
                    Pelawat.origin = False
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