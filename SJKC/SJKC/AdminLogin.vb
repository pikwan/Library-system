Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class AdminLogin
    Public cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DB.mdb;")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrontPage.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            Dim username As String
            Dim NoAccmod2 As String
            Dim pass As String

            Dim cmd As OleDbCommand = New OleDbCommand("Select * from ADMIN where UNAME= '" & TextBox1.Text & "' ", cn)


            cn.Open()

            Dim rdr As OleDbDataReader
            rdr = cmd.ExecuteReader
            If rdr.HasRows Then
                rdr.Read()
                username = rdr("UNAME")
                pass = rdr("PASS")
                If (TextBox1.Text = username And TextBox2.Text = pass) Then
                    Admin.Show()
                    Me.Hide()
                Else
                    MsgBox("Incorrect Username/Password")
                    TextBox1.Clear()
                    TextBox2.Clear()

                End If
            Else
                MsgBox("Incorrect Username/Password")
                TextBox1.Clear()
                TextBox2.Clear()
                cn.Close()
            End If
        Catch
            MsgBox("Error logging in, please try again", MsgBoxStyle.Exclamation)
        End Try



    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentChanged

    End Sub

    Private Sub AdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataSet.ADMIN' table. You can move, or remove it, as needed.
        Me.ADMINTableAdapter.Fill(Me.DBDataSet.ADMIN)

    End Sub

    Private Sub BindingSource2_CurrentChanged(sender As Object, e As EventArgs)

    End Sub
End Class