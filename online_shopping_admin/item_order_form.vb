Public Class item_order_form
    Dim order_controller As New OrderingControls("online_shopping.db")
    Dim current_item_id As Integer
    Private Sub item_order_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: display all warehouse items in datagrid
        Dim warehouse_items As DataTable = order_controller.view_warehouse_items()
        warehouse_item_table.DataSource = warehouse_items
        GroupBox1.Hide()
    End Sub

    Private Sub place_order_button_Click(sender As Object, e As EventArgs)
        'TODO: on button click, update the PI of the item ordered
        'as quantity_ordered * case_quantity
    End Sub

    Private Sub warehouse_item_table_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles warehouse_item_table.CellContentClick
        'allows the user to select a row in the table (represents an item).
        'it saves the id in a variable, then uses that id when making the order call
        Dim rowPos As Integer = e.RowIndex
        current_item_id = warehouse_item_table.Rows(rowPos).Cells(0).Value
        MsgBox(current_item_id
               )
    End Sub
End Class