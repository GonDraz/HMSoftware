Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.IO

Public Class Model
    Public dbCommand As String = ""
    Public bindingSrc As BindingSource
    Public dbName As String = "hmsoftware_database.db"
    Public dbPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & dbName
    Public connString As String = "Data Source=" & dbPath & "; Version=3 ;PRAGMA legacy_file_format = TRUE; Integrated Security=true"
    Public connection As New SQLiteConnection(connString)
    Public command As New SQLiteCommand("", connection)

    Public table As New DataTable


    Public Sub ConnectDataBase()
        If File.Exists(dbPath) = False Then
            File.Create(dbPath)

            Debug.Print("Đã tạo file tại " & dbPath)
        Else

        End If
        Debug.Print("database tại : " & dbPath)
    End Sub
End Class