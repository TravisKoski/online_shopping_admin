Public Class item_order_form
    Dim order_controller As New OrderingControls("online_shopping.db")
    Private Sub item_order_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: display all warehouse items in datagrid
        Dim warehouse_items As DataTable = order_controller.view_warehouse_items()
        DataGridView1.DataSource = warehouse_items
        GroupBox1.Hide()
    End Sub

    Private Sub place_order_button_Click(sender As Object, e As EventArgs)
        'TODO: on button click, update the PI of the item ordered
        'as quantity_ordered * case_quantity
    End Sub
End Class