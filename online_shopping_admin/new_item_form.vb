Public Class new_item_form
    Dim item_audit_controls As ItemAuditBackendController
    Private Sub add_item_button_Click(sender As Object, e As EventArgs) Handles add_item_button.Click
        Dim item_name As String = item_name_entry.Text
        Dim item_category As String = category_entry.Text
        Dim price As Double = price_entry.Text
        Dim on_hand As Integer = on_hand_entry.Text
        Dim case_quantity As Integer = case_quantity_entry.Text
        item_audit_controls.add_new_item_to_warehouse(item_name, item_category,
price, on_hand, case_quantity)
    End Sub

    Private Sub new_item_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        item_audit_controls = New ItemAuditBackendController("online_shopping.db")
    End Sub
End Class