<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminPass
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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.chckboxShowPass = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtboxAdminPass = New System.Windows.Forms.TextBox()
        Me.txtboxAdminUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.groupboxAdminPass = New System.Windows.Forms.GroupBox()
        Me.groupboxAdminPass.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(97, 188)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(89, 39)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'chckboxShowPass
        '
        Me.chckboxShowPass.AutoSize = True
        Me.chckboxShowPass.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chckboxShowPass.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chckboxShowPass.Location = New System.Drawing.Point(21, 150)
        Me.chckboxShowPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chckboxShowPass.Name = "chckboxShowPass"
        Me.chckboxShowPass.Size = New System.Drawing.Size(126, 23)
        Me.chckboxShowPass.TabIndex = 0
        Me.chckboxShowPass.Text = "Show Password"
        Me.chckboxShowPass.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(19, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Admin Password"
        '
        'txtboxAdminPass
        '
        Me.txtboxAdminPass.Location = New System.Drawing.Point(21, 115)
        Me.txtboxAdminPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtboxAdminPass.Name = "txtboxAdminPass"
        Me.txtboxAdminPass.Size = New System.Drawing.Size(268, 27)
        Me.txtboxAdminPass.TabIndex = 2
        Me.txtboxAdminPass.UseSystemPasswordChar = True
        '
        'txtboxAdminUsername
        '
        Me.txtboxAdminUsername.Location = New System.Drawing.Point(21, 56)
        Me.txtboxAdminUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtboxAdminUsername.Name = "txtboxAdminUsername"
        Me.txtboxAdminUsername.Size = New System.Drawing.Size(268, 27)
        Me.txtboxAdminUsername.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(19, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Admin Username"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(200, 188)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 39)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'groupboxAdminPass
        '
        Me.groupboxAdminPass.Controls.Add(Me.btnSubmit)
        Me.groupboxAdminPass.Controls.Add(Me.btnCancel)
        Me.groupboxAdminPass.Controls.Add(Me.txtboxAdminPass)
        Me.groupboxAdminPass.Controls.Add(Me.txtboxAdminUsername)
        Me.groupboxAdminPass.Controls.Add(Me.chckboxShowPass)
        Me.groupboxAdminPass.Controls.Add(Me.Label2)
        Me.groupboxAdminPass.Controls.Add(Me.Label1)
        Me.groupboxAdminPass.ForeColor = System.Drawing.Color.MediumBlue
        Me.groupboxAdminPass.Location = New System.Drawing.Point(14, 15)
        Me.groupboxAdminPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupboxAdminPass.Name = "groupboxAdminPass"
        Me.groupboxAdminPass.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.groupboxAdminPass.Size = New System.Drawing.Size(314, 248)
        Me.groupboxAdminPass.TabIndex = 6
        Me.groupboxAdminPass.TabStop = False
        '
        'AdminPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(342, 276)
        Me.ControlBox = False
        Me.Controls.Add(Me.groupboxAdminPass)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AdminPass"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminPass"
        Me.groupboxAdminPass.ResumeLayout(False)
        Me.groupboxAdminPass.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents chckboxShowPass As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtboxAdminPass As TextBox
    Friend WithEvents txtboxAdminUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents groupboxAdminPass As GroupBox
End Class
