Imports System.Data.OleDb

Public Class frmMainDashboard
    Private Sub txtSearchRecentFoundItems_TextChanged(sender As Object, e As EventArgs) Handles txtSearchRecentFoundItems.TextChanged

    End Sub

    Private Sub frmMainDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCLaimItem_Click(sender As Object, e As EventArgs) Handles btnCLaimItem.Click
        TabControl.SelectedTab = TabPDashboard
    End Sub

    Private Sub btnResidents_Click(sender As Object, e As EventArgs) Handles btnResidents.Click
        TabControl.SelectedTab = TabPResidents
    End Sub

    Private Sub BtnIncidents_Click(sender As Object, e As EventArgs) Handles BtnIncidents.Click
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







End Class