<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DBConnectTest
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
        Me.txtboxServerIpName = New System.Windows.Forms.TextBox()
        Me.lblServerIP = New System.Windows.Forms.Label()
        Me.grpboxGetIP = New System.Windows.Forms.GroupBox()
        Me.txtboxDBName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtboxUserID = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtboxPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.grpboxGetIP.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtboxServerIpName
        '
        Me.txtboxServerIpName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxServerIpName.Location = New System.Drawing.Point(29, 58)
        Me.txtboxServerIpName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxServerIpName.Name = "txtboxServerIpName"
        Me.txtboxServerIpName.Size = New System.Drawing.Size(214, 25)
        Me.txtboxServerIpName.TabIndex = 62
        '
        'lblServerIP
        '
        Me.lblServerIP.AutoSize = True
        Me.lblServerIP.Location = New System.Drawing.Point(26, 41)
        Me.lblServerIP.Name = "lblServerIP"
        Me.lblServerIP.Size = New System.Drawing.Size(88, 16)
        Me.lblServerIP.TabIndex = 61
        Me.lblServerIP.Text = "Server IP/Name"
        '
        'grpboxGetIP
        '
        Me.grpboxGetIP.Controls.Add(Me.txtboxDBName)
        Me.grpboxGetIP.Controls.Add(Me.Label1)
        Me.grpboxGetIP.Controls.Add(Me.btnCancel)
        Me.grpboxGetIP.Controls.Add(Me.btnOK)
        Me.grpboxGetIP.Location = New System.Drawing.Point(10, 9)
        Me.grpboxGetIP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxGetIP.Name = "grpboxGetIP"
        Me.grpboxGetIP.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxGetIP.Size = New System.Drawing.Size(254, 293)
        Me.grpboxGetIP.TabIndex = 86
        Me.grpboxGetIP.TabStop = False
        '
        'txtboxDBName
        '
        Me.txtboxDBName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxDBName.Location = New System.Drawing.Point(19, 188)
        Me.txtboxDBName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxDBName.Name = "txtboxDBName"
        Me.txtboxDBName.Size = New System.Drawing.Size(214, 25)
        Me.txtboxDBName.TabIndex = 92
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Database Name"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.Window
        Me.btnCancel.Location = New System.Drawing.Point(155, 237)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(78, 32)
        Me.btnCancel.TabIndex = 98
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnOK.ForeColor = System.Drawing.SystemColors.Window
        Me.btnOK.Location = New System.Drawing.Point(101, 237)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(46, 32)
        Me.btnOK.TabIndex = 97
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'txtboxUserID
        '
        Me.txtboxUserID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxUserID.Location = New System.Drawing.Point(29, 103)
        Me.txtboxUserID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxUserID.Name = "txtboxUserID"
        Me.txtboxUserID.Size = New System.Drawing.Size(214, 25)
        Me.txtboxUserID.TabIndex = 88
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(26, 86)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(44, 16)
        Me.lblUsername.TabIndex = 87
        Me.lblUsername.Text = "User ID"
        '
        'txtboxPassword
        '
        Me.txtboxPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtboxPassword.Location = New System.Drawing.Point(29, 150)
        Me.txtboxPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxPassword.Name = "txtboxPassword"
        Me.txtboxPassword.Size = New System.Drawing.Size(214, 25)
        Me.txtboxPassword.TabIndex = 90
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(26, 131)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(57, 16)
        Me.lblPassword.TabIndex = 89
        Me.lblPassword.Text = "Password"
        '
        'DBConnectTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 313)
        Me.Controls.Add(Me.txtboxPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtboxUserID)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtboxServerIpName)
        Me.Controls.Add(Me.lblServerIP)
        Me.Controls.Add(Me.grpboxGetIP)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "DBConnectTest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setup Local Database"
        Me.grpboxGetIP.ResumeLayout(False)
        Me.grpboxGetIP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtboxServerIpName As TextBox
    Friend WithEvents lblServerIP As Label
    Friend WithEvents grpboxGetIP As GroupBox
    Friend WithEvents txtboxUserID As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtboxPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents txtboxDBName As TextBox
    Friend WithEvents Label1 As Label
End Class
