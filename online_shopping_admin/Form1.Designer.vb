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
        Me.create_account_button.Size = New System.Drawing.Size(136, 35)
        Me.create_account_button.TabIndex = 5
        Me.create_account_button.Text = "create account"
        Me.create_account_button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
