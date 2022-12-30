<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.username_box = New System.Windows.Forms.TextBox()
        Me.password_box = New System.Windows.Forms.TextBox()
        Me.login_button = New System.Windows.Forms.Button()
        Me.create_account_button = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.new_user_button = New System.Windows.Forms.Button()
        Me.new_username_entry = New System.Windows.Forms.TextBox()
        Me.new_user_password_entry = New System.Windows.Forms.TextBox()
        Me.new_user_password_reEntry = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(313, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(313, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "password"
        '
        'username_box
        '
        Me.username_box.Location = New System.Drawing.Point(408, 51)
        Me.username_box.Name = "username_box"
        Me.username_box.Size = New System.Drawing.Size(150, 31)
        Me.username_box.TabIndex = 2
        '
        'password_box
        '
        Me.password_box.Location = New System.Drawing.Point(410, 109)
        Me.password_box.Name = "password_box"
        Me.password_box.Size = New System.Drawing.Size(150, 31)
        Me.password_box.TabIndex = 3
        '
        'login_button
        '
        Me.login_button.Location = New System.Drawing.Point(410, 160)
        Me.login_button.Name = "login_button"
        Me.login_button.Size = New System.Drawing.Size(112, 34)
        Me.login_button.TabIndex = 4
        Me.login_button.Text = "login"
        Me.login_button.UseVisualStyleBackColor = True
        '
        'create_account_button
        '
        Me.create_account_button.AutoSize = True
        Me.create_account_button.Location = New System.Drawing.Point(410, 216)
        Me.create_account_button.Name = "create_account_button"
        Me.create_account_button.Size = New System.Drawing.Size(261, 35)
        Me.create_account_button.TabIndex = 5
        Me.create_account_button.Text = "first time? Create account here"
        Me.create_account_button.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(370, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "new username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(362, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "enter password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(340, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "re-enter password"
        '
        'new_user_button
        '
        Me.new_user_button.AutoSize = True
        Me.new_user_button.Location = New System.Drawing.Point(412, 374)
        Me.new_user_button.Name = "new_user_button"
        Me.new_user_button.Size = New System.Drawing.Size(136, 35)
        Me.new_user_button.TabIndex = 9
        Me.new_user_button.Text = "create account"
        Me.new_user_button.UseVisualStyleBackColor = True
        '
        'new_username_entry
        '
        Me.new_username_entry.Location = New System.Drawing.Point(502, 266)
        Me.new_username_entry.Name = "new_username_entry"
        Me.new_username_entry.Size = New System.Drawing.Size(150, 31)
        Me.new_username_entry.TabIndex = 10
        '
        'new_user_password_entry
        '
        Me.new_user_password_entry.Location = New System.Drawing.Point(502, 304)
        Me.new_user_password_entry.Name = "new_user_password_entry"
        Me.new_user_password_entry.Size = New System.Drawing.Size(150, 31)
        Me.new_user_password_entry.TabIndex = 11
        '
        'new_user_password_reEntry
        '
        Me.new_user_password_reEntry.Location = New System.Drawing.Point(502, 337)
        Me.new_user_password_reEntry.Name = "new_user_password_reEntry"
        Me.new_user_password_reEntry.Size = New System.Drawing.Size(150, 31)
        Me.new_user_password_reEntry.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.new_user_password_reEntry)
        Me.Controls.Add(Me.new_user_password_entry)
        Me.Controls.Add(Me.new_username_entry)
        Me.Controls.Add(Me.new_user_button)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.create_account_button)
        Me.Controls.Add(Me.login_button)
        Me.Controls.Add(Me.password_box)
        Me.Controls.Add(Me.username_box)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents username_box As TextBox
    Friend WithEvents password_box As TextBox
    Friend WithEvents login_button As Button
    Friend WithEvents create_account_button As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents new_user_button As Button
    Friend WithEvents new_username_entry As TextBox
    Friend WithEvents new_user_password_entry As TextBox
    Friend WithEvents new_user_password_reEntry As TextBox
End Class
