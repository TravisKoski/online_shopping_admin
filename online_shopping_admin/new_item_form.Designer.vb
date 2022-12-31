<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class new_item_form
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.item_name_entry = New System.Windows.Forms.TextBox()
        Me.category_entry = New System.Windows.Forms.TextBox()
        Me.price_entry = New System.Windows.Forms.TextBox()
        Me.on_hand_entry = New System.Windows.Forms.TextBox()
        Me.case_quantity_entry = New System.Windows.Forms.TextBox()
        Me.add_item_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "category"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 115)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 157)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "initital_on-hand"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 199)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "case quantity"
        '
        'item_name_entry
        '
        Me.item_name_entry.Location = New System.Drawing.Point(91, 20)
        Me.item_name_entry.Margin = New System.Windows.Forms.Padding(2)
        Me.item_name_entry.Name = "item_name_entry"
        Me.item_name_entry.Size = New System.Drawing.Size(149, 31)
        Me.item_name_entry.TabIndex = 5
        '
        'category_entry
        '
        Me.category_entry.Location = New System.Drawing.Point(114, 66)
        Me.category_entry.Margin = New System.Windows.Forms.Padding(2)
        Me.category_entry.Name = "category_entry"
        Me.category_entry.Size = New System.Drawing.Size(149, 31)
        Me.category_entry.TabIndex = 6
        '
        'price_entry
        '
        Me.price_entry.Location = New System.Drawing.Point(85, 116)
        Me.price_entry.Margin = New System.Windows.Forms.Padding(2)
        Me.price_entry.Name = "price_entry"
        Me.price_entry.Size = New System.Drawing.Size(149, 31)
        Me.price_entry.TabIndex = 7
        '
        'on_hand_entry
        '
        Me.on_hand_entry.Location = New System.Drawing.Point(154, 158)
        Me.on_hand_entry.Margin = New System.Windows.Forms.Padding(2)
        Me.on_hand_entry.Name = "on_hand_entry"
        Me.on_hand_entry.Size = New System.Drawing.Size(149, 31)
        Me.on_hand_entry.TabIndex = 8
        '
        'case_quantity_entry
        '
        Me.case_quantity_entry.Location = New System.Drawing.Point(147, 199)
        Me.case_quantity_entry.Margin = New System.Windows.Forms.Padding(2)
        Me.case_quantity_entry.Name = "case_quantity_entry"
        Me.case_quantity_entry.Size = New System.Drawing.Size(149, 31)
        Me.case_quantity_entry.TabIndex = 9
        '
        'add_item_button
        '
        Me.add_item_button.AutoSize = True
        Me.add_item_button.Location = New System.Drawing.Point(164, 237)
        Me.add_item_button.Margin = New System.Windows.Forms.Padding(2)
        Me.add_item_button.Name = "add_item_button"
        Me.add_item_button.Size = New System.Drawing.Size(165, 35)
        Me.add_item_button.TabIndex = 10
        Me.add_item_button.Text = "add to warehouse"
        Me.add_item_button.UseVisualStyleBackColor = True
        '
        'new_item_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 274)
        Me.Controls.Add(Me.add_item_button)
        Me.Controls.Add(Me.case_quantity_entry)
        Me.Controls.Add(Me.on_hand_entry)
        Me.Controls.Add(Me.price_entry)
        Me.Controls.Add(Me.category_entry)
        Me.Controls.Add(Me.item_name_entry)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "new_item_form"
        Me.Text = "new_item_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents item_name_entry As TextBox
    Friend WithEvents category_entry As TextBox
    Friend WithEvents price_entry As TextBox
    Friend WithEvents on_hand_entry As TextBox
    Friend WithEvents case_quantity_entry As TextBox
    Friend WithEvents add_item_button As Button
End Class
