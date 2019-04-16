Imports System.Data.OleDb

Public Class AnalisisPengguna
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub SurveyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SurveyBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SurveyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBDataSet)

    End Sub

    Private Sub AnalisisPengguna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataSet.survey' table. You can move, or remove it, as needed.
        Me.SurveyTableAdapter.Fill(Me.DBDataSet.survey)

        Try
            Dim username As String
            Dim cn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DB.mdb;")
            Dim cmd As OleDbCommand = New OleDbCommand("Select kepuasan,count(ID) as JUMLAH from survey group by kepuasan", cn)
            cn.Open()
            Dim rdr As OleDbDataReader
            rdr = cmd.ExecuteReader
            Do While (rdr.HasRows)
                rdr.Read()
                ListBox1.Items.Add(rdr("kepuasan"))
                ListBox2.Items.Add(rdr("JUMLAH"))
            Loop
            cn.Close()

        Catch
            MsgBox("DBERROR : Error getting data, please try again", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class