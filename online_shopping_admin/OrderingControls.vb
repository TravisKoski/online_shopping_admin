Imports System.Data.SQLite

Public Class OrderingControls
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

        Catch ex As Exception
            MsgBox("error connecting to db")

        End Try
        command = New SQLiteCommand("", connection)
    End Sub

    Public Sub place_order(ByVal item_id As Integer)
        'TODO: make an update call to the db using the id as the reference
    End Sub
    Public Function view_warehouse_items() As DataTable
        'retrieves the items stored in the warehouse,
        'only displays the id name, category
        Dim resultingData As New DataTable()
        command.CommandText = String.Format("select id, name, category from items")
        Try
            connection.Open()
            Dim adapter As New SQLiteDataAdapter(command)
            adapter.Fill(resultingData)
        Catch ex As Exception
            MsgBox("error viewing warehouse items")
        Finally
            connection.Close()
        End Try
        Return resultingData

    End Function

End Class
