Imports System.Collections.ObjectModel
Imports System.Data.SQLite
Public Class Form1
    Dim loginControls As loginBackendController
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'give access to the backend, and then hide each component regarding
        'creating a new user unless the user specifies to
        loginControls = New loginBackendController("online_shopping.db")
        hide_new_user_fields()
        add_item_button.Hide()
        order_item_button.Hide()

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

    Private Sub create_account_button_Click(sender As Object, e As EventArgs)
        show_new_user_fields()
    End Sub

    Private Sub new_user_button_Click(sender As Object, e As EventArgs)

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

    Private Sub login_button_Click(sender As Object, e As EventArgs) Handles login_button.Click
        'checks the username password combo from the db, and tries to log the user in
        'on suceess, the user can see the buttons to add, and order items
        Dim user_name As String = username_box.Text
        Dim guessed_password As String = password_box.Text
        Dim actual_password As String = loginControls.find_password_by_name(user_name)
        If actual_password = guessed_password Then
            add_item_button.Show()
            order_item_button.Show()
            MsgBox("login successful")
        Else
            MsgBox("login failed")
        End If
    End Sub

    Private Sub add_item_button_Click(sender As Object, e As EventArgs) Handles add_item_button.Click
        'opens the add item form
        new_item_form.Show()
    End Sub

    Private Sub order_item_button_Click(sender As Object, e As EventArgs) Handles order_item_button.Click
        item_order_form.Show()
    End Sub
End Class
