Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmMainDashboard

    Private Sub frmMainDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connection()
        getCategories()
        LoadResidents()
        LoadResidents2()
        cboCategory.Text = ""
    End Sub
    Public Sub GetResidents()
        sql = "Select Count (StudentID)  from tblStudents "
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            Label4.Text = dr(0)
        End If
    End Sub


    Private Sub getCategories()
        Dim sql As String = "SELECT DISTINCT [ResidentTag] FROM ResidentInfo"
        Dim cmd As New OleDbCommand(sql, cn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        cboCategory.DataSource = dt
        cboCategory.DisplayMember = "ResidentTag"
    End Sub
    Private Sub getCategoriesINView()
        sql = "Select * FROM qryResidentInfos where [ResidentTag] = '" & cboCategory.Text & "'"
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
            ListVDashboard.Items.Add(x)
        Loop
    End Sub

    Private Sub btnCLaimItem_Click(sender As Object, e As EventArgs) Handles btnCLaimItem.Click
        TabControl.SelectedTab = TabPDashboard
    End Sub

    Private Sub btnResidents_Click(sender As Object, e As EventArgs) Handles btnHouseholds.Click
        TabControl.SelectedTab = TabPHouseholds
        LoadHouseholdQuery()
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

    Private Sub LoadResidents()
        sql = "Select * from qryResidentInfos Order By brgyID asc "
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

            ListVDashboard.Items.Add(x)
        Loop

    End Sub
    Private Sub LoadResidents2()
        sql = "Select * from qryResidentInfos Order By brgyID asc "
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem

        ListVDashboard2.Items.Clear()
        Do While dr.Read = True
            x = New ListViewItem(dr(0).ToString)
            x.SubItems.Add(dr(1).ToString)
            x.SubItems.Add(dr(2).ToString)
            x.SubItems.Add(dr(3).ToString)
            x.SubItems.Add(dr(4).ToString)
            x.SubItems.Add(dr(5).ToString)
            x.SubItems.Add(dr(6).ToString)
            x.SubItems.Add(dr(7).ToString)


            ListVDashboard2.Items.Add(x)
        Loop

    End Sub

    Private Sub LoadHouseholdQuery()
        sql = "Select * from Household_query Order By ID asc "
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        Dim x As ListViewItem
        ListVDashboardHH.Items.Clear()
        Do While dr.Read = True
            x = New ListViewItem(dr(0).ToString)
            x.SubItems.Add(dr(1).ToString)
            x.SubItems.Add(dr(2).ToString)
            x.SubItems.Add(dr(3).ToString)
            ListVDashboardHH.Items.Add(x)
        Loop

    End Sub


    Private Sub cboCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCategory.SelectedIndexChanged
        getCategoriesINView()
    End Sub

    Private Sub btnRefresh_Click_1(sender As Object, e As EventArgs) Handles btnRefresh.Click
        cboCategory.Text = ""
        LoadResidents()
    End Sub

    Private Sub btnResidents_Click_1(sender As Object, e As EventArgs) Handles btnResidents.Click
        TabControl.SelectedTab = TabPResidents
    End Sub

End Class