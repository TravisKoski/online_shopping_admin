<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class item_order_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.warehouse_item_table = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.place_order_button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.warehouse_item_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'warehouse_item_table
        '
        Me.warehouse_item_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.warehouse_item_table.Location = New System.Drawing.Point(12, 30)
        Me.warehouse_item_table.Name = "warehouse_item_table"
        Me.warehouse_item_table.RowHeadersWidth = 62
        Me.warehouse_item_table.RowTemplate.Height = 33
        Me.warehouse_item_table.Size = New System.Drawing.Size(409, 382)
        Me.warehouse_item_table.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.place_order_button)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(427, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 156)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(137, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(150, 31)
        Me.TextBox1.TabIndex = 4
        '
        'place_order_button
        '
        Me.place_order_button.Location = New System.Drawing.Point(19, 94)
        Me.place_order_button.Name = "place_order_button"
        Me.place_order_button.Size = New System.Drawing.Size(112, 34)
        Me.place_order_button.TabIndex = 3
        Me.place_order_button.Text = "place order"
        Me.place_order_button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "order quantity"
        '
        'item_order_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.warehouse_item_table)
        Me.Name = "item_order_form"
        Me.Text = "item_order_form"
        CType(Me.warehouse_item_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents warehouse_item_table As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents place_order_button As Button
    Friend WithEvents Label1 As Label
End Class
