Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmMainDashboard
    Private Sub txtSearchRecentFoundItems_TextChanged(sender As Object, e As EventArgs) Handles txtSearchRecentFoundItems.TextChanged

    End Sub

    Private Sub frmMainDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connection()
        LoadResidents()

    End Sub
    Public Sub GetResidents()
        sql = "Select Count (StudentID)  from tblStudents "
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            Label4.Text = dr(0)
        End If
    End Sub
    Private Sub btnCLaimItem_Click(sender As Object, e As EventArgs) Handles btnCLaimItem.Click
        TabControl.SelectedTab = TabPDashboard
    End Sub

    Private Sub btnResidents_Click(sender As Object, e As EventArgs) Handles btnResidents.Click
        TabControl.SelectedTab = TabPResidents
    End Sub

    Private Sub BtnIncidents_Click(sender As Object, e As EventArgs)
        ' TabControl.SelectedTab = TabPIncidents
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        TabControl.SelectedTab = TabPUsers
    End Sub

    Private Sub BtnManageResidents_Click(sender As Object, e As EventArgs) Handles BtnManageResidents.Click
        TabControl.SelectedTab = TabPManageResidents
    End Sub

    Private Sub btnManageUsers_Click(sender As Object, e As EventArgs) Handles btnManageUsers.Click
        TabControl.SelectedTab = TabPManageUsers
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub LoadResidents()
        sql = "Select * from BarangayInfo Order By brgyID asc "
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListVDashboard.Items.Clear()
        Do While dr.Read = True
            x = New ListViewItem(dr(0).ToString)
            x.SubItems.Add(dr(1).ToString)
            x.SubItems.Add(dr(2).ToString)
            x.SubItems.Add(dr(3).ToString)
            x.SubItems.Add(dr(4).ToString)
            x.SubItems.Add(dr(5).ToString)
            x.SubItems.Add(dr(6).ToString)
            x.SubItems.Add(dr(7).ToString)
            x.SubItems.Add(dr(8).ToString)
            x.SubItems.Add(dr(9).ToString)
            x.SubItems.Add(dr(10).ToString)
            x.SubItems.Add(dr(11).ToString)

            ListVDashboard.Items.Add(x)
        Loop

    End Sub





End Class