﻿Imports System.Data.OleDb

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
            ' MsgBox("DBERROR : Error getting data, please try again", MsgBoxStyle.Exclamation)
        End Try

        Try
            Dim username As String
            Dim cn2 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DB.mdb;")
            Dim cmd2 As OleDbCommand = New OleDbCommand("Select ruang,count(ID) as JUMLAH from survey group by ruang", cn2)
            cn2.Open()
            Dim rdrw As OleDbDataReader
            rdrw = cmd2.ExecuteReader
            Do While (rdrw.HasRows)
                rdrw.Read()
                ListBox4.Items.Add(rdrw("ruang"))
                ListBox3.Items.Add(rdrw("JUMLAH"))
            Loop
            cn2.Close()

        Catch
            'MsgBox("DBERROR : Error getting data, please try again", MsgBoxStyle.Exclamation)
        End Try

        Try
            Dim username As String
            Dim cn3 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DB.mdb;")
            Dim cmd3 As OleDbCommand = New OleDbCommand("Select UID,count(ID) as JUMLAH from checkin group by UID", cn3)
            cn3.Open()
            Dim rdrw3 As OleDbDataReader
            rdrw3 = cmd3.ExecuteReader
            Do While (rdrw3.HasRows)
                rdrw3.Read()
                ListBox6.Items.Add(rdrw3("UID"))
                ListBox5.Items.Add(rdrw3("JUMLAH"))
            Loop
            cn3.Close()

        Catch
            'MsgBox("DBERROR : Error getting data, please try again", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class