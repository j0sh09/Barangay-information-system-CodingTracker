Imports System.Data.OleDb

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connection()
    End Sub

    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        If txtUsername.Text = "" Or TxtPassword.Text = "" Then
            MsgBox("Please enter your Username and Password tanginamo", MsgBoxStyle.Exclamation)
        Else
            Call Login()
        End If
    End Sub

    Private Sub Login()
        sql = "Select * from UsersTB where Username = '" & txtUsername.Text & "' and Password = '" & TxtPassword.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            ' frmMainDashboard.tssEmpName.Text = dr("Lastname").ToString & "," & dr("Firstname").ToString
            '  frmMainDashboard.tssEmpPosition.Text = dr("Role")
            MsgBox("Access Granted", MsgBoxStyle.Information)
            Me.Hide()
            Dim dashboard As New frmMainDashboard()
            dashboard.Show()
            Me.Hide()


        Else
            MsgBox("Access denied", MsgBoxStyle.Critical)
            Call ClearText()
            txtUsername.Select()
        End If
    End Sub
    Private Sub ClearText()
        TxtPassword.Clear()
        txtUsername.Clear()

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        sql = "Select [role] from UsersTB where Username = '" & txtUsername.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblRole.Text = dr(0).ToString
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            TxtPassword.UseSystemPasswordChar = False
        Else
            TxtPassword.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub pictureBox3_Click(sender As Object, e As EventArgs) Handles pictureBox3.Click

    End Sub
End Class
