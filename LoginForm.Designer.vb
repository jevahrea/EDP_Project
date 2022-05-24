<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Me.txtboxPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtboxUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblRegisterAccount = New System.Windows.Forms.Label()
        Me.lblDonthaveaccount = New System.Windows.Forms.Label()
        Me.lblForgotPass = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.chckboxShowPass = New System.Windows.Forms.CheckBox()
        Me.grpbxLogin = New System.Windows.Forms.GroupBox()
        Me.btnTestCon = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtboxPassword
        '
        Me.txtboxPassword.Location = New System.Drawing.Point(487, 216)
        Me.txtboxPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxPassword.Name = "txtboxPassword"
        Me.txtboxPassword.Size = New System.Drawing.Size(282, 27)
        Me.txtboxPassword.TabIndex = 68
        Me.txtboxPassword.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(483, 192)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(70, 20)
        Me.lblPassword.TabIndex = 67
        Me.lblPassword.Text = "Password"
        '
        'txtboxUsername
        '
        Me.txtboxUsername.Location = New System.Drawing.Point(487, 160)
        Me.txtboxUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxUsername.Name = "txtboxUsername"
        Me.txtboxUsername.Size = New System.Drawing.Size(282, 27)
        Me.txtboxUsername.TabIndex = 66
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(483, 138)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(75, 20)
        Me.lblUsername.TabIndex = 65
        Me.lblUsername.Text = "Username"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EDP.My.Resources.Resources.Dental_Clinic
        Me.PictureBox1.Location = New System.Drawing.Point(11, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(321, 500)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'lblRegisterAccount
        '
        Me.lblRegisterAccount.AutoSize = True
        Me.lblRegisterAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRegisterAccount.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRegisterAccount.ForeColor = System.Drawing.Color.Red
        Me.lblRegisterAccount.Location = New System.Drawing.Point(650, 448)
        Me.lblRegisterAccount.Name = "lblRegisterAccount"
        Me.lblRegisterAccount.Size = New System.Drawing.Size(122, 20)
        Me.lblRegisterAccount.TabIndex = 63
        Me.lblRegisterAccount.Text = "Register account"
        '
        'lblDonthaveaccount
        '
        Me.lblDonthaveaccount.AutoSize = True
        Me.lblDonthaveaccount.Location = New System.Drawing.Point(489, 448)
        Me.lblDonthaveaccount.Name = "lblDonthaveaccount"
        Me.lblDonthaveaccount.Size = New System.Drawing.Size(163, 20)
        Me.lblDonthaveaccount.TabIndex = 62
        Me.lblDonthaveaccount.Text = "Don't have an account?"
        '
        'lblForgotPass
        '
        Me.lblForgotPass.AutoSize = True
        Me.lblForgotPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblForgotPass.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblForgotPass.Location = New System.Drawing.Point(118, 299)
        Me.lblForgotPass.Name = "lblForgotPass"
        Me.lblForgotPass.Size = New System.Drawing.Size(130, 20)
        Me.lblForgotPass.TabIndex = 61
        Me.lblForgotPass.Text = "Forgot password?"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(487, 309)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(285, 40)
        Me.btnLogin.TabIndex = 60
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'chckboxShowPass
        '
        Me.chckboxShowPass.AutoSize = True
        Me.chckboxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chckboxShowPass.Location = New System.Drawing.Point(487, 249)
        Me.chckboxShowPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chckboxShowPass.Name = "chckboxShowPass"
        Me.chckboxShowPass.Size = New System.Drawing.Size(130, 24)
        Me.chckboxShowPass.TabIndex = 59
        Me.chckboxShowPass.Text = "Show password"
        Me.chckboxShowPass.UseVisualStyleBackColor = True
        '
        'grpbxLogin
        '
        Me.grpbxLogin.Controls.Add(Me.lblForgotPass)
        Me.grpbxLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpbxLogin.ForeColor = System.Drawing.Color.MediumBlue
        Me.grpbxLogin.Location = New System.Drawing.Point(459, 72)
        Me.grpbxLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpbxLogin.Name = "grpbxLogin"
        Me.grpbxLogin.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpbxLogin.Size = New System.Drawing.Size(339, 348)
        Me.grpbxLogin.TabIndex = 58
        Me.grpbxLogin.TabStop = False
        Me.grpbxLogin.Text = "Log in"
        '
        'btnTestCon
        '
        Me.btnTestCon.BackColor = System.Drawing.Color.Goldenrod
        Me.btnTestCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTestCon.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnTestCon.ForeColor = System.Drawing.Color.White
        Me.btnTestCon.Location = New System.Drawing.Point(832, 12)
        Me.btnTestCon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTestCon.Name = "btnTestCon"
        Me.btnTestCon.Size = New System.Drawing.Size(77, 28)
        Me.btnTestCon.TabIndex = 69
        Me.btnTestCon.Text = "Database"
        Me.btnTestCon.UseVisualStyleBackColor = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 524)
        Me.Controls.Add(Me.btnTestCon)
        Me.Controls.Add(Me.txtboxPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtboxUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblRegisterAccount)
        Me.Controls.Add(Me.lblDonthaveaccount)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.chckboxShowPass)
        Me.Controls.Add(Me.grpbxLogin)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Account"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxLogin.ResumeLayout(False)
        Me.grpbxLogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtboxPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtboxUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblRegisterAccount As Label
    Friend WithEvents lblDonthaveaccount As Label
    Friend WithEvents lblForgotPass As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents chckboxShowPass As CheckBox
    Friend WithEvents grpbxLogin As GroupBox
    Friend WithEvents btnTestCon As Button
End Class
