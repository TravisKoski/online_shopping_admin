Imports System.Data.SQLite

Public Class loginBackendController
    'following varables are used to make connection to db
    Dim dbName As String
    Dim connSrc As String
    Dim connString As String
    Dim connection As SQLiteConnection
    Dim command As SQLiteCommand
    Public Sub New(ByVal dbName As String)
        'constructor initializes the first connection to sqllite
        dbName = dbName
        connSrc = Application.StartupPath & "\" & dbName
        connString = "Data source=" & connSrc & ";Version=3"
        Try
            connection = New SQLiteConnection(connString)
            MsgBox("connected successfully")
        Catch ex As Exception
            MsgBox("error connecting to db")

        End Try
        command = New SQLiteCommand("", connection)

    End Sub
    'checks if a user is already in the database, returns
    'accordingly
    Public Function check_user_existence(ByVal userName As String) As Boolean
        Dim user_exists As Boolean = Nothing
        Dim query As String = String.Format("select * from admins where name = 
'{0}'", userName)
        Try
            connection.Open()
            command.CommandText = query
            Dim rdr As SQLiteDataReader = command.ExecuteReader()
            user_exists = rdr.Read() 'read will always return false if the query returned nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString)

        End Try
        Return user_exists
    End Function
End Class
