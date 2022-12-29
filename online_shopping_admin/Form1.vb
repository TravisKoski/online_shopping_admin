Imports System.Collections.ObjectModel
Imports System.Data.SQLite
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loginControls As loginBackendController = New loginBackendController("online_shopping.db")
    End Sub
End Class
