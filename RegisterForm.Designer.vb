<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Me.txtboxLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpboxEmployeeInfo = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbboxAccountType = New System.Windows.Forms.ComboBox()
        Me.txtboxFirstName = New System.Windows.Forms.TextBox()
        Me.txtboxMiddleName = New System.Windows.Forms.TextBox()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.txtboxEmailAddress = New System.Windows.Forms.TextBox()
        Me.lblAccountType = New System.Windows.Forms.Label()
        Me.lblMobileNumber = New System.Windows.Forms.Label()
        Me.datepickBirthday = New System.Windows.Forms.DateTimePicker()
        Me.txtboxMobileNumber = New System.Windows.Forms.TextBox()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.txtboxEmpID = New System.Windows.Forms.TextBox()
        Me.txtboxUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtboxPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.chckboxShowPass = New System.Windows.Forms.CheckBox()
        Me.btnRegisterAccount = New System.Windows.Forms.Button()
        Me.grpboxUserInfo = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtboxAnswer = New System.Windows.Forms.TextBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.grpboxSecurityQuest = New System.Windows.Forms.GroupBox()
        Me.chckboxShowAns = New System.Windows.Forms.CheckBox()
        Me.txtboxQuestion = New System.Windows.Forms.TextBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblAlreadyhaveaccount = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpboxEmployeeInfo.SuspendLayout()
        Me.grpboxUserInfo.SuspendLayout()
        Me.grpboxSecurityQuest.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtboxLastName
        '
        Me.txtboxLastName.Location = New System.Drawing.Point(373, 128)
        Me.txtboxLastName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxLastName.Name = "txtboxLastName"
        Me.txtboxLastName.Size = New System.Drawing.Size(165, 27)
        Me.txtboxLastName.TabIndex = 4
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLastName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLastName.Location = New System.Drawing.Point(369, 105)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(79, 20)
        Me.lblLastName.TabIndex = 45
        Me.lblLastName.Text = "Last Name"
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMiddleName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMiddleName.Location = New System.Drawing.Point(193, 105)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(100, 20)
        Me.lblMiddleName.TabIndex = 43
        Me.lblMiddleName.Text = "Middle Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFirstName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFirstName.Location = New System.Drawing.Point(16, 105)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(80, 20)
        Me.lblFirstName.TabIndex = 41
        Me.lblFirstName.Text = "First Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EDP.My.Resources.Resources.Dental_Clinic
        Me.PictureBox1.Location = New System.Drawing.Point(11, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(321, 572)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'grpboxEmployeeInfo
        '
        Me.grpboxEmployeeInfo.Controls.Add(Me.Label1)
        Me.grpboxEmployeeInfo.Controls.Add(Me.cmbboxAccountType)
        Me.grpboxEmployeeInfo.Controls.Add(Me.lblFirstName)
        Me.grpboxEmployeeInfo.Controls.Add(Me.txtboxFirstName)
        Me.grpboxEmployeeInfo.Controls.Add(Me.lblMiddleName)
        Me.grpboxEmployeeInfo.Controls.Add(Me.txtboxMiddleName)
        Me.grpboxEmployeeInfo.Controls.Add(Me.lblLastName)
        Me.grpboxEmployeeInfo.Controls.Add(Me.txtboxLastName)
        Me.grpboxEmployeeInfo.Controls.Add(Me.lblEmailAddress)
        Me.grpboxEmployeeInfo.Controls.Add(Me.txtboxEmailAddress)
        Me.grpboxEmployeeInfo.Controls.Add(Me.lblAccountType)
        Me.grpboxEmployeeInfo.Controls.Add(Me.lblMobileNumber)
        Me.grpboxEmployeeInfo.Controls.Add(Me.datepickBirthday)
        Me.grpboxEmployeeInfo.Controls.Add(Me.txtboxMobileNumber)
        Me.grpboxEmployeeInfo.Controls.Add(Me.lblBirthday)
        Me.grpboxEmployeeInfo.Controls.Add(Me.txtboxEmpID)
        Me.grpboxEmployeeInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpboxEmployeeInfo.ForeColor = System.Drawing.Color.MediumBlue
        Me.grpboxEmployeeInfo.Location = New System.Drawing.Point(350, 12)
        Me.grpboxEmployeeInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxEmployeeInfo.Name = "grpboxEmployeeInfo"
        Me.grpboxEmployeeInfo.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxEmployeeInfo.Size = New System.Drawing.Size(559, 309)
        Me.grpboxEmployeeInfo.TabIndex = 48
        Me.grpboxEmployeeInfo.TabStop = False
        Me.grpboxEmployeeInfo.Text = "Employee Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Employee ID"
        '
        'cmbboxAccountType
        '
        Me.cmbboxAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxAccountType.FormattingEnabled = True
        Me.cmbboxAccountType.Items.AddRange(New Object() {"admin", "staff"})
        Me.cmbboxAccountType.Location = New System.Drawing.Point(338, 182)
        Me.cmbboxAccountType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbboxAccountType.Name = "cmbboxAccountType"
        Me.cmbboxAccountType.Size = New System.Drawing.Size(201, 28)
        Me.cmbboxAccountType.TabIndex = 6
        '
        'txtboxFirstName
        '
        Me.txtboxFirstName.Location = New System.Drawing.Point(21, 128)
        Me.txtboxFirstName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxFirstName.Name = "txtboxFirstName"
        Me.txtboxFirstName.Size = New System.Drawing.Size(165, 27)
        Me.txtboxFirstName.TabIndex = 2
        '
        'txtboxMiddleName
        '
        Me.txtboxMiddleName.Location = New System.Drawing.Point(197, 128)
        Me.txtboxMiddleName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxMiddleName.Name = "txtboxMiddleName"
        Me.txtboxMiddleName.Size = New System.Drawing.Size(165, 27)
        Me.txtboxMiddleName.TabIndex = 3
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblEmailAddress.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEmailAddress.Location = New System.Drawing.Point(16, 162)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(103, 20)
        Me.lblEmailAddress.TabIndex = 49
        Me.lblEmailAddress.Text = "Email Address"
        '
        'txtboxEmailAddress
        '
        Me.txtboxEmailAddress.Location = New System.Drawing.Point(21, 184)
        Me.txtboxEmailAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxEmailAddress.Name = "txtboxEmailAddress"
        Me.txtboxEmailAddress.Size = New System.Drawing.Size(305, 27)
        Me.txtboxEmailAddress.TabIndex = 5
        '
        'lblAccountType
        '
        Me.lblAccountType.AutoSize = True
        Me.lblAccountType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAccountType.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAccountType.Location = New System.Drawing.Point(333, 161)
        Me.lblAccountType.Name = "lblAccountType"
        Me.lblAccountType.Size = New System.Drawing.Size(98, 20)
        Me.lblAccountType.TabIndex = 51
        Me.lblAccountType.Text = "Account Type"
        '
        'lblMobileNumber
        '
        Me.lblMobileNumber.AutoSize = True
        Me.lblMobileNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMobileNumber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMobileNumber.Location = New System.Drawing.Point(16, 218)
        Me.lblMobileNumber.Name = "lblMobileNumber"
        Me.lblMobileNumber.Size = New System.Drawing.Size(114, 20)
        Me.lblMobileNumber.TabIndex = 53
        Me.lblMobileNumber.Text = "Mobile Number"
        '
        'datepickBirthday
        '
        Me.datepickBirthday.CustomFormat = "yyyy/MM/dd"
        Me.datepickBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datepickBirthday.Location = New System.Drawing.Point(338, 241)
        Me.datepickBirthday.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datepickBirthday.Name = "datepickBirthday"
        Me.datepickBirthday.Size = New System.Drawing.Size(201, 27)
        Me.datepickBirthday.TabIndex = 8
        '
        'txtboxMobileNumber
        '
        Me.txtboxMobileNumber.Location = New System.Drawing.Point(21, 241)
        Me.txtboxMobileNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxMobileNumber.Name = "txtboxMobileNumber"
        Me.txtboxMobileNumber.Size = New System.Drawing.Size(305, 27)
        Me.txtboxMobileNumber.TabIndex = 7
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblBirthday.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblBirthday.Location = New System.Drawing.Point(333, 218)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(64, 20)
        Me.lblBirthday.TabIndex = 55
        Me.lblBirthday.Text = "Birthday"
        '
        'txtboxEmpID
        '
        Me.txtboxEmpID.Location = New System.Drawing.Point(21, 70)
        Me.txtboxEmpID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtboxEmpID.Name = "txtboxEmpID"
        Me.txtboxEmpID.Size = New System.Drawing.Size(519, 27)
        Me.txtboxEmpID.TabIndex = 1
        '
        'txtboxUsername
        '
        Me.txtboxUsername.Location = New System.Drawing.Point(370, 381)
        Me.txtboxUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxUsername.Name = "txtboxUsername"
        Me.txtboxUsername.Size = New System.Drawing.Size(238, 27)
        Me.txtboxUsername.TabIndex = 9
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(366, 358)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(75, 20)
        Me.lblUsername.TabIndex = 58
        Me.lblUsername.Text = "Username"
        '
        'txtboxPassword
        '
        Me.txtboxPassword.Location = New System.Drawing.Point(370, 436)
        Me.txtboxPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxPassword.Name = "txtboxPassword"
        Me.txtboxPassword.Size = New System.Drawing.Size(238, 27)
        Me.txtboxPassword.TabIndex = 10
        Me.txtboxPassword.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(366, 412)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(70, 20)
        Me.lblPassword.TabIndex = 60
        Me.lblPassword.Text = "Password"
        '
        'chckboxShowPass
        '
        Me.chckboxShowPass.AutoSize = True
        Me.chckboxShowPass.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chckboxShowPass.Location = New System.Drawing.Point(370, 470)
        Me.chckboxShowPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chckboxShowPass.Name = "chckboxShowPass"
        Me.chckboxShowPass.Size = New System.Drawing.Size(122, 21)
        Me.chckboxShowPass.TabIndex = 62
        Me.chckboxShowPass.Text = "Show password"
        Me.chckboxShowPass.UseVisualStyleBackColor = True
        '
        'btnRegisterAccount
        '
        Me.btnRegisterAccount.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRegisterAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegisterAccount.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRegisterAccount.ForeColor = System.Drawing.SystemColors.Window
        Me.btnRegisterAccount.Location = New System.Drawing.Point(22, 169)
        Me.btnRegisterAccount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegisterAccount.Name = "btnRegisterAccount"
        Me.btnRegisterAccount.Size = New System.Drawing.Size(238, 38)
        Me.btnRegisterAccount.TabIndex = 13
        Me.btnRegisterAccount.Text = "Register account (↵)"
        Me.btnRegisterAccount.UseVisualStyleBackColor = False
        '
        'grpboxUserInfo
        '
        Me.grpboxUserInfo.Controls.Add(Me.btnCancel)
        Me.grpboxUserInfo.Controls.Add(Me.btnRegisterAccount)
        Me.grpboxUserInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpboxUserInfo.ForeColor = System.Drawing.Color.MediumBlue
        Me.grpboxUserInfo.Location = New System.Drawing.Point(349, 328)
        Me.grpboxUserInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxUserInfo.Name = "grpboxUserInfo"
        Me.grpboxUserInfo.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxUserInfo.Size = New System.Drawing.Size(280, 258)
        Me.grpboxUserInfo.TabIndex = 49
        Me.grpboxUserInfo.TabStop = False
        Me.grpboxUserInfo.Text = "User Information"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.Window
        Me.btnCancel.Location = New System.Drawing.Point(22, 211)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(238, 38)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel (Esc)"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtboxAnswer
        '
        Me.txtboxAnswer.Location = New System.Drawing.Point(671, 436)
        Me.txtboxAnswer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxAnswer.Name = "txtboxAnswer"
        Me.txtboxAnswer.Size = New System.Drawing.Size(214, 27)
        Me.txtboxAnswer.TabIndex = 12
        Me.txtboxAnswer.UseSystemPasswordChar = True
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(666, 412)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(57, 20)
        Me.lblAnswer.TabIndex = 66
        Me.lblAnswer.Text = "Answer"
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(666, 358)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(68, 20)
        Me.lblQuestion.TabIndex = 64
        Me.lblQuestion.Text = "Question"
        '
        'grpboxSecurityQuest
        '
        Me.grpboxSecurityQuest.Controls.Add(Me.chckboxShowAns)
        Me.grpboxSecurityQuest.Controls.Add(Me.txtboxQuestion)
        Me.grpboxSecurityQuest.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpboxSecurityQuest.ForeColor = System.Drawing.Color.MediumBlue
        Me.grpboxSecurityQuest.Location = New System.Drawing.Point(648, 328)
        Me.grpboxSecurityQuest.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxSecurityQuest.Name = "grpboxSecurityQuest"
        Me.grpboxSecurityQuest.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxSecurityQuest.Size = New System.Drawing.Size(261, 180)
        Me.grpboxSecurityQuest.TabIndex = 50
        Me.grpboxSecurityQuest.TabStop = False
        Me.grpboxSecurityQuest.Text = "Security Question"
        '
        'chckboxShowAns
        '
        Me.chckboxShowAns.AutoSize = True
        Me.chckboxShowAns.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chckboxShowAns.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chckboxShowAns.Location = New System.Drawing.Point(23, 144)
        Me.chckboxShowAns.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chckboxShowAns.Name = "chckboxShowAns"
        Me.chckboxShowAns.Size = New System.Drawing.Size(122, 21)
        Me.chckboxShowAns.TabIndex = 70
        Me.chckboxShowAns.Text = "Show password"
        Me.chckboxShowAns.UseVisualStyleBackColor = True
        '
        'txtboxQuestion
        '
        Me.txtboxQuestion.Location = New System.Drawing.Point(23, 52)
        Me.txtboxQuestion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxQuestion.Name = "txtboxQuestion"
        Me.txtboxQuestion.Size = New System.Drawing.Size(214, 27)
        Me.txtboxQuestion.TabIndex = 11
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLogin.ForeColor = System.Drawing.Color.Red
        Me.lblLogin.Location = New System.Drawing.Point(840, 535)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(51, 20)
        Me.lblLogin.TabIndex = 15
        Me.lblLogin.Text = "Log in"
        '
        'lblAlreadyhaveaccount
        '
        Me.lblAlreadyhaveaccount.AutoSize = True
        Me.lblAlreadyhaveaccount.Location = New System.Drawing.Point(666, 535)
        Me.lblAlreadyhaveaccount.Name = "lblAlreadyhaveaccount"
        Me.lblAlreadyhaveaccount.Size = New System.Drawing.Size(178, 20)
        Me.lblAlreadyhaveaccount.TabIndex = 68
        Me.lblAlreadyhaveaccount.Text = "Already have an account?"
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 599)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.lblAlreadyhaveaccount)
        Me.Controls.Add(Me.txtboxAnswer)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.chckboxShowPass)
        Me.Controls.Add(Me.txtboxPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtboxUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpboxEmployeeInfo)
        Me.Controls.Add(Me.grpboxUserInfo)
        Me.Controls.Add(Me.grpboxSecurityQuest)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "RegisterForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register Account"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpboxEmployeeInfo.ResumeLayout(False)
        Me.grpboxEmployeeInfo.PerformLayout()
        Me.grpboxUserInfo.ResumeLayout(False)
        Me.grpboxSecurityQuest.ResumeLayout(False)
        Me.grpboxSecurityQuest.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtboxLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpboxEmployeeInfo As GroupBox
    Friend WithEvents txtboxFirstName As TextBox
    Friend WithEvents txtboxMiddleName As TextBox
    Friend WithEvents lblAccountType As Label
    Friend WithEvents txtboxEmailAddress As TextBox
    Friend WithEvents lblEmailAddress As Label
    Friend WithEvents cmbboxAccountType As ComboBox
    Friend WithEvents txtboxMobileNumber As TextBox
    Friend WithEvents lblMobileNumber As Label
    Friend WithEvents lblBirthday As Label
    Friend WithEvents datepickBirthday As DateTimePicker
    Friend WithEvents txtboxUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtboxPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents chckboxShowPass As CheckBox
    Friend WithEvents btnRegisterAccount As Button
    Friend WithEvents grpboxUserInfo As GroupBox
    Friend WithEvents txtboxAnswer As TextBox
    Friend WithEvents lblAnswer As Label
    Friend WithEvents lblQuestion As Label
    Friend WithEvents grpboxSecurityQuest As GroupBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblAlreadyhaveaccount As Label
    Friend WithEvents txtboxEmpID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtboxQuestion As TextBox
    Friend WithEvents chckboxShowAns As CheckBox
    Friend WithEvents btnCancel As Button
End Class
