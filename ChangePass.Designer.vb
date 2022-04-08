<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePass
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
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtboxNewPass = New System.Windows.Forms.TextBox()
        Me.txtboxConfirmPass = New System.Windows.Forms.TextBox()
        Me.chckboxShowPass = New System.Windows.Forms.CheckBox()
        Me.groupboxChangePass = New System.Windows.Forms.GroupBox()
        Me.groupboxChangePass.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnOK
        '
        Me.BtnOK.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOK.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnOK.ForeColor = System.Drawing.Color.White
        Me.BtnOK.Location = New System.Drawing.Point(178, 150)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(78, 32)
        Me.BtnOK.TabIndex = 3
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(17, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "New Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(18, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Confirm Password"
        '
        'txtboxNewPass
        '
        Me.txtboxNewPass.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtboxNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxNewPass.Location = New System.Drawing.Point(20, 50)
        Me.txtboxNewPass.Name = "txtboxNewPass"
        Me.txtboxNewPass.Size = New System.Drawing.Size(236, 23)
        Me.txtboxNewPass.TabIndex = 1
        Me.txtboxNewPass.UseSystemPasswordChar = True
        '
        'txtboxConfirmPass
        '
        Me.txtboxConfirmPass.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtboxConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxConfirmPass.Location = New System.Drawing.Point(21, 97)
        Me.txtboxConfirmPass.Name = "txtboxConfirmPass"
        Me.txtboxConfirmPass.Size = New System.Drawing.Size(235, 23)
        Me.txtboxConfirmPass.TabIndex = 2
        Me.txtboxConfirmPass.UseSystemPasswordChar = True
        '
        'chckboxShowPass
        '
        Me.chckboxShowPass.AutoSize = True
        Me.chckboxShowPass.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chckboxShowPass.Location = New System.Drawing.Point(21, 125)
        Me.chckboxShowPass.Name = "chckboxShowPass"
        Me.chckboxShowPass.Size = New System.Drawing.Size(108, 20)
        Me.chckboxShowPass.TabIndex = 4
        Me.chckboxShowPass.Text = "Show Password"
        Me.chckboxShowPass.UseVisualStyleBackColor = True
        '
        'groupboxChangePass
        '
        Me.groupboxChangePass.Controls.Add(Me.chckboxShowPass)
        Me.groupboxChangePass.Controls.Add(Me.txtboxConfirmPass)
        Me.groupboxChangePass.Controls.Add(Me.txtboxNewPass)
        Me.groupboxChangePass.Controls.Add(Me.Label2)
        Me.groupboxChangePass.Controls.Add(Me.Label1)
        Me.groupboxChangePass.Controls.Add(Me.BtnOK)
        Me.groupboxChangePass.ForeColor = System.Drawing.Color.MediumBlue
        Me.groupboxChangePass.Location = New System.Drawing.Point(12, 13)
        Me.groupboxChangePass.Name = "groupboxChangePass"
        Me.groupboxChangePass.Size = New System.Drawing.Size(275, 198)
        Me.groupboxChangePass.TabIndex = 0
        Me.groupboxChangePass.TabStop = False
        Me.groupboxChangePass.Text = "Change Password"
        '
        'ChangePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 221)
        Me.ControlBox = False
        Me.Controls.Add(Me.groupboxChangePass)
        Me.Name = "ChangePass"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.groupboxChangePass.ResumeLayout(False)
        Me.groupboxChangePass.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnOK As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtboxNewPass As TextBox
    Friend WithEvents txtboxConfirmPass As TextBox
    Friend WithEvents chckboxShowPass As CheckBox
    Friend WithEvents groupboxChangePass As GroupBox
End Class
