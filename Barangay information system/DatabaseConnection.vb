Imports System.Data.OleDb

Module DatabaseConnection
    Public cn As New OleDbConnection
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public sql As String

    Public Sub Connection()
        cn.Close()
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Josh\Documents\3rd year college plmun\visual studio\Barangay information system\Barangay information system\bin\Debug\BarangayInfo1.accdb"
        MsgBox("Database Connected", MsgBoxStyle.Information)
        cn.Open()
    End Sub

End Module
