Imports System.Data.SQLite

Public Class ItemAuditBackendController
    Dim dbName As String
    Dim connSrc As String
    Dim connString As String
    Dim connection As SQLiteConnection
    Dim command As SQLiteCommand
    Public Sub New(ByVal dbName As String)
        'this class contains every backend related logic which both the new_item
        'and item_order forms will interact with.

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

    'takes in an item name, and sees if its already in the database. Returns a boolean
    Public Function item_exists(ByVal item_name As String)
        Dim exists As Boolean = Nothing
        Dim query As String = String.Format("select * from items where
name = '{0}' limit 1;", item_name)
        Try
            connection.Open()
            command.CommandText = query
            Dim rdr As SQLiteDataReader = command.ExecuteReader()
            'try to read a row that the query returns, if there is nothing to read,
            'rdr will return false
            exists = rdr.Read()
            rdr.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            connection.Close()

        End Try
        Return exists
    End Function


End Class
