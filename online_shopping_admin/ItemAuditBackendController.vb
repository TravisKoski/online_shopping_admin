Imports System.Data.SQLite

Public Class ItemAuditBackendController
    Dim dbName As String
    Dim connSrc As String
    Dim connString As String
    Dim connection As SQLiteConnection
    Dim command As SQLiteCommand
    Public Sub New(ByVal dbName As String)
        'constructor initializes the first connection to sqllite
        dbName = dbName
        connSrc = "C:\Users\tmkos\Source\Repos\online_shopping_admin\online_shopping_admin\online_shopping.db"
        connString = "Data source=" & connSrc & ";Version=3"
        Try
            connection = New SQLiteConnection(connString)
            MsgBox("connected successfully")
        Catch ex As Exception
            MsgBox("error connecting to db")

        End Try
        command = New SQLiteCommand("", connection)
    End Sub


End Class
