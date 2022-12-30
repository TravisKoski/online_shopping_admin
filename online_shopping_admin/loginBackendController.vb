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
    'checks if a user is already in the database, returns
    'accordingly
    Public Function check_user_existence(ByVal userName As String) As Boolean
        Dim user_exists As Boolean = Nothing
        Dim query As String = String.Format("select * from admins where name = 
'{0}' limit 1", userName)
        Try
            connection.Open()
            command.CommandText = query
            Dim rdr As SQLiteDataReader = command.ExecuteReader()
            user_exists = rdr.Read() 'read will always return false if the query returned nothing
            rdr.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            connection.Close()
        End Try
        Return user_exists
    End Function

    Public Sub add_new_admin_user(ByVal userName As String, ByVal password As String)
        'will try to add a new user to the admins table in the db
        'it will reject if the user (same username) already exsists in db
        Dim insert_command = String.Format(" begin transaction;
insert into admins(name,password)
values('{0}','{1}');
commit;", userName, password)
        Try
            Dim exists_already = check_user_existence(userName)
            If exists_already Then
                MsgBox("user with " & userName & " already exists")
            Else
                connection.Open()
                command.CommandText = insert_command
                command.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            connection.Close()
        End Try
    End Sub
End Class
