<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserInfoEditAddForm
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
        Me.grpboxPatientInfo = New System.Windows.Forms.GroupBox()
        Me.txtboxEmpName = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtboxQuestion = New System.Windows.Forms.TextBox()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtboxAnswer = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.chckboxShowPass = New System.Windows.Forms.CheckBox()
        Me.txtboxPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtboxUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblUserAccount = New System.Windows.Forms.Label()
        Me.picboxPatientLogo = New System.Windows.Forms.PictureBox()
        Me.chckboxShowPass2 = New System.Windows.Forms.CheckBox()
        Me.grpboxPatientInfo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picboxPatientLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpboxPatientInfo
        '
        Me.grpboxPatientInfo.Controls.Add(Me.chckboxShowPass2)
        Me.grpboxPatientInfo.Controls.Add(Me.txtboxEmpName)
        Me.grpboxPatientInfo.Controls.Add(Me.btnCancel)
        Me.grpboxPatientInfo.Controls.Add(Me.txtboxQuestion)
        Me.grpboxPatientInfo.Controls.Add(Me.lblQuestion)
        Me.grpboxPatientInfo.Controls.Add(Me.btnSave)
        Me.grpboxPatientInfo.Controls.Add(Me.txtboxAnswer)
        Me.grpboxPatientInfo.Controls.Add(Me.lblAnswer)
        Me.grpboxPatientInfo.Controls.Add(Me.lblEmployeeName)
        Me.grpboxPatientInfo.Controls.Add(Me.chckboxShowPass)
        Me.grpboxPatientInfo.Controls.Add(Me.txtboxPassword)
        Me.grpboxPatientInfo.Controls.Add(Me.lblPassword)
        Me.grpboxPatientInfo.Controls.Add(Me.txtboxUsername)
        Me.grpboxPatientInfo.Controls.Add(Me.lblUsername)
        Me.grpboxPatientInfo.Location = New System.Drawing.Point(10, 66)
        Me.grpboxPatientInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxPatientInfo.Name = "grpboxPatientInfo"
        Me.grpboxPatientInfo.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxPatientInfo.Size = New System.Drawing.Size(337, 446)
        Me.grpboxPatientInfo.TabIndex = 113
        Me.grpboxPatientInfo.TabStop = False
        '
        'txtboxEmpName
        '
        Me.txtboxEmpName.Location = New System.Drawing.Point(18, 49)
        Me.txtboxEmpName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxEmpName.Name = "txtboxEmpName"
        Me.txtboxEmpName.ReadOnly = True
        Me.txtboxEmpName.Size = New System.Drawing.Size(301, 23)
        Me.txtboxEmpName.TabIndex = 85
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.Window
        Me.btnCancel.Location = New System.Drawing.Point(18, 380)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(300, 30)
        Me.btnCancel.TabIndex = 84
        Me.btnCancel.Text = "Cancel (Esc)"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtboxQuestion
        '
        Me.txtboxQuestion.Location = New System.Drawing.Point(18, 242)
        Me.txtboxQuestion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxQuestion.Name = "txtboxQuestion"
        Me.txtboxQuestion.Size = New System.Drawing.Size(301, 23)
        Me.txtboxQuestion.TabIndex = 11
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(14, 222)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(55, 16)
        Me.lblQuestion.TabIndex = 72
        Me.lblQuestion.Text = "Question"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.ForeColor = System.Drawing.SystemColors.Window
        Me.btnSave.Location = New System.Drawing.Point(18, 346)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(300, 30)
        Me.btnSave.TabIndex = 83
        Me.btnSave.Text = "Save (↵)"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtboxAnswer
        '
        Me.txtboxAnswer.Location = New System.Drawing.Point(18, 288)
        Me.txtboxAnswer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxAnswer.Name = "txtboxAnswer"
        Me.txtboxAnswer.Size = New System.Drawing.Size(301, 23)
        Me.txtboxAnswer.TabIndex = 70
        Me.txtboxAnswer.UseSystemPasswordChar = True
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(18, 269)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(46, 16)
        Me.lblAnswer.TabIndex = 73
        Me.lblAnswer.Text = "Answer"
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Location = New System.Drawing.Point(14, 27)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(92, 16)
        Me.lblEmployeeName.TabIndex = 68
        Me.lblEmployeeName.Text = "Employee Name"
        '
        'chckboxShowPass
        '
        Me.chckboxShowPass.AutoSize = True
        Me.chckboxShowPass.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chckboxShowPass.Location = New System.Drawing.Point(18, 172)
        Me.chckboxShowPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chckboxShowPass.Name = "chckboxShowPass"
        Me.chckboxShowPass.Size = New System.Drawing.Size(108, 17)
        Me.chckboxShowPass.TabIndex = 67
        Me.chckboxShowPass.Text = "Show password"
        Me.chckboxShowPass.UseVisualStyleBackColor = True
        '
        'txtboxPassword
        '
        Me.txtboxPassword.Location = New System.Drawing.Point(18, 145)
        Me.txtboxPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxPassword.Name = "txtboxPassword"
        Me.txtboxPassword.Size = New System.Drawing.Size(301, 23)
        Me.txtboxPassword.TabIndex = 64
        Me.txtboxPassword.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(15, 126)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(57, 16)
        Me.lblPassword.TabIndex = 66
        Me.lblPassword.Text = "Password"
        '
        'txtboxUsername
        '
        Me.txtboxUsername.Location = New System.Drawing.Point(18, 93)
        Me.txtboxUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxUsername.Name = "txtboxUsername"
        Me.txtboxUsername.Size = New System.Drawing.Size(301, 23)
        Me.txtboxUsername.TabIndex = 63
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(15, 74)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(59, 16)
        Me.lblUsername.TabIndex = 65
        Me.lblUsername.Text = "Username"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.lblUserAccount)
        Me.Panel1.Controls.Add(Me.picboxPatientLogo)
        Me.Panel1.Location = New System.Drawing.Point(10, 9)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(337, 54)
        Me.Panel1.TabIndex = 114
        '
        'lblUserAccount
        '
        Me.lblUserAccount.AutoSize = True
        Me.lblUserAccount.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblUserAccount.ForeColor = System.Drawing.SystemColors.Window
        Me.lblUserAccount.Location = New System.Drawing.Point(52, 10)
        Me.lblUserAccount.Name = "lblUserAccount"
        Me.lblUserAccount.Size = New System.Drawing.Size(159, 32)
        Me.lblUserAccount.TabIndex = 1
        Me.lblUserAccount.Text = "User Account"
        '
        'picboxPatientLogo
        '
        Me.picboxPatientLogo.Image = Global.EDP.My.Resources.Resources.user2
        Me.picboxPatientLogo.Location = New System.Drawing.Point(11, 10)
        Me.picboxPatientLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picboxPatientLogo.Name = "picboxPatientLogo"
        Me.picboxPatientLogo.Size = New System.Drawing.Size(37, 33)
        Me.picboxPatientLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxPatientLogo.TabIndex = 0
        Me.picboxPatientLogo.TabStop = False
        '
        'chckboxShowPass2
        '
        Me.chckboxShowPass2.AutoSize = True
        Me.chckboxShowPass2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chckboxShowPass2.Location = New System.Drawing.Point(18, 315)
        Me.chckboxShowPass2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chckboxShowPass2.Name = "chckboxShowPass2"
        Me.chckboxShowPass2.Size = New System.Drawing.Size(108, 17)
        Me.chckboxShowPass2.TabIndex = 86
        Me.chckboxShowPass2.Text = "Show password"
        Me.chckboxShowPass2.UseVisualStyleBackColor = True
        '
        'UserInfoEditAddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 521)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grpboxPatientInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserInfoEditAddForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.grpboxPatientInfo.ResumeLayout(False)
        Me.grpboxPatientInfo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picboxPatientLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpboxPatientInfo As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblUserAccount As Label
    Friend WithEvents picboxPatientLogo As PictureBox
    Friend WithEvents chckboxShowPass As CheckBox
    Friend WithEvents txtboxPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtboxUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents lblQuestion As Label
    Friend WithEvents txtboxAnswer As TextBox
    Friend WithEvents lblAnswer As Label
    Friend WithEvents txtboxQuestion As TextBox
    Friend WithEvents txtboxEmpName As TextBox
    Friend WithEvents chckboxShowPass2 As CheckBox
End Class
