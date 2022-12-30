Imports System.Collections.ObjectModel
Imports System.Data.SQLite
Public Class Form1
    Dim loginControls As loginBackendController
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'give access to the backend, and then hide each component regarding
        'creating a new user unless the user specifies to
        loginControls = New loginBackendController("online_shopping.db")
        hide_new_user_fields()

    End Sub

    Private Sub show_new_user_fields()
        Label3.Show()
        Label4.Show()
        Label5.Show()
        new_username_entry.Show()
        new_user_password_entry.Show()
        new_user_password_reEntry.Show()
        new_user_button.Show()
    End Sub

    Private Sub hide_new_user_fields()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        new_username_entry.Hide()
        new_user_password_entry.Hide()
        new_user_password_reEntry.Hide()
        new_user_button.Hide()
    End Sub

    Private Sub create_account_button_Click(sender As Object, e As EventArgs) Handles create_account_button.Click
        show_new_user_fields()
    End Sub

    Private Sub new_user_button_Click(sender As Object, e As EventArgs) Handles new_user_button.Click

        'extract name,and password from the text boxes, and insert the new user into the db
        Dim new_username As String = new_username_entry.Text
        Dim new_user_password As String = new_user_password_entry.Text
        Dim new_user_password_reTyped = new_user_password_reEntry.Text
        'the passwords must match to successfully create account
        If new_user_password <> new_user_password_reTyped Then
            MsgBox("mismatch in password entries")
        Else
            'enter the details of the user in db
            loginControls.add_new_admin_user(new_username, new_user_password)
        End If

    End Sub
End Class
