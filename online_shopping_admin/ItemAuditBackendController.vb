Imports System.Data.SQLite
Imports System.Net.Security
Imports System.Runtime.CompilerServices

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
        connSrc = "C:\Users\tmkoski\source\repos\online_shopping_admin\online_shopping_admin\online_shopping.db"
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
    Public Sub add_new_item_to_warehouse(ByVal name As String,
                                         ByVal category As String, ByVal price As Double, ByVal on_hand As Integer, ByVal casepack As Integer)
        'This method retrieves all required data of a new item from the new item form,
        'then attempts to add it to the warehouse. ALready existing items will be rejected

        Dim insert_command As String = String.Format("
begin transaction;
insert into items(
name, category, price, on_hand, case_quantity) values('{0}', '{1}', {2},{3},{4});
commit;", name, category, price, on_hand, casepack)
        'NOTE: no need to check for item existence manually, because the db is enforcing
        'uniqueness on the item name
        Try
            connection.Open()
            command.CommandText = insert_command
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            connection.Close()

        End Try
    End Sub



End Class
