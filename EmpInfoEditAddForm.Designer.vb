<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpInfoEditAddForm
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
        Me.lblPatientInformation = New System.Windows.Forms.Label()
        Me.picboxPatientLogo = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtboxEmailAdd = New System.Windows.Forms.TextBox()
        Me.lblEmailAdd = New System.Windows.Forms.Label()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.txtboxLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtboxMiddleName = New System.Windows.Forms.TextBox()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.txtboxFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtboxEmployeeID = New System.Windows.Forms.TextBox()
        Me.lblEmployeeID = New System.Windows.Forms.Label()
        Me.datepickBirthday = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grpboxEmployeeInfo = New System.Windows.Forms.GroupBox()
        Me.txtboxContactNo = New System.Windows.Forms.TextBox()
        CType(Me.picboxPatientLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.grpboxEmployeeInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPatientInformation
        '
        Me.lblPatientInformation.AutoSize = True
        Me.lblPatientInformation.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPatientInformation.ForeColor = System.Drawing.SystemColors.Window
        Me.lblPatientInformation.Location = New System.Drawing.Point(59, 12)
        Me.lblPatientInformation.Name = "lblPatientInformation"
        Me.lblPatientInformation.Size = New System.Drawing.Size(324, 41)
        Me.lblPatientInformation.TabIndex = 1
        Me.lblPatientInformation.Text = "Employee Information"
        '
        'picboxPatientLogo
        '
        Me.picboxPatientLogo.Image = Global.EDP.My.Resources.Resources.teamwork1
        Me.picboxPatientLogo.Location = New System.Drawing.Point(13, 12)
        Me.picboxPatientLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picboxPatientLogo.Name = "picboxPatientLogo"
        Me.picboxPatientLogo.Size = New System.Drawing.Size(42, 41)
        Me.picboxPatientLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxPatientLogo.TabIndex = 0
        Me.picboxPatientLogo.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.Window
        Me.btnCancel.Location = New System.Drawing.Point(29, 466)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(519, 38)
        Me.btnCancel.TabIndex = 84
        Me.btnCancel.Text = "Cancel (Esc)"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtboxEmailAdd
        '
        Me.txtboxEmailAdd.Location = New System.Drawing.Point(40, 438)
        Me.txtboxEmailAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxEmailAdd.Name = "txtboxEmailAdd"
        Me.txtboxEmailAdd.Size = New System.Drawing.Size(518, 27)
        Me.txtboxEmailAdd.TabIndex = 101
        '
        'lblEmailAdd
        '
        Me.lblEmailAdd.AutoSize = True
        Me.lblEmailAdd.Location = New System.Drawing.Point(37, 414)
        Me.lblEmailAdd.Name = "lblEmailAdd"
        Me.lblEmailAdd.Size = New System.Drawing.Size(103, 20)
        Me.lblEmailAdd.TabIndex = 100
        Me.lblEmailAdd.Text = "Email Address"
        '
        'lblContactNo
        '
        Me.lblContactNo.AutoSize = True
        Me.lblContactNo.Location = New System.Drawing.Point(362, 358)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(118, 20)
        Me.lblContactNo.TabIndex = 98
        Me.lblContactNo.Text = "Contact Number"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.ForeColor = System.Drawing.SystemColors.Window
        Me.btnSave.Location = New System.Drawing.Point(29, 422)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(519, 38)
        Me.btnSave.TabIndex = 83
        Me.btnSave.Text = "Save (↵)"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Location = New System.Drawing.Point(35, 358)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(64, 20)
        Me.lblBirthday.TabIndex = 96
        Me.lblBirthday.Text = "Birthday"
        '
        'txtboxLastName
        '
        Me.txtboxLastName.Location = New System.Drawing.Point(278, 311)
        Me.txtboxLastName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxLastName.Name = "txtboxLastName"
        Me.txtboxLastName.Size = New System.Drawing.Size(282, 27)
        Me.txtboxLastName.TabIndex = 95
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(273, 290)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(79, 20)
        Me.lblLastName.TabIndex = 94
        Me.lblLastName.Text = "Last Name"
        '
        'txtboxMiddleName
        '
        Me.txtboxMiddleName.Location = New System.Drawing.Point(278, 258)
        Me.txtboxMiddleName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxMiddleName.Name = "txtboxMiddleName"
        Me.txtboxMiddleName.Size = New System.Drawing.Size(282, 27)
        Me.txtboxMiddleName.TabIndex = 93
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Location = New System.Drawing.Point(273, 234)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(100, 20)
        Me.lblMiddleName.TabIndex = 92
        Me.lblMiddleName.Text = "Middle Name"
        '
        'txtboxFirstName
        '
        Me.txtboxFirstName.Location = New System.Drawing.Point(278, 200)
        Me.txtboxFirstName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxFirstName.Name = "txtboxFirstName"
        Me.txtboxFirstName.Size = New System.Drawing.Size(282, 27)
        Me.txtboxFirstName.TabIndex = 91
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(273, 178)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(80, 20)
        Me.lblFirstName.TabIndex = 90
        Me.lblFirstName.Text = "First Name"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox2.Image = Global.EDP.My.Resources.Resources.Profile_Pic
        Me.PictureBox2.Location = New System.Drawing.Point(40, 124)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(226, 212)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 89
        Me.PictureBox2.TabStop = False
        '
        'txtboxEmployeeID
        '
        Me.txtboxEmployeeID.Enabled = False
        Me.txtboxEmployeeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxEmployeeID.Location = New System.Drawing.Point(278, 144)
        Me.txtboxEmployeeID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxEmployeeID.Name = "txtboxEmployeeID"
        Me.txtboxEmployeeID.ReadOnly = True
        Me.txtboxEmployeeID.Size = New System.Drawing.Size(282, 26)
        Me.txtboxEmployeeID.TabIndex = 88
        '
        'lblEmployeeID
        '
        Me.lblEmployeeID.AutoSize = True
        Me.lblEmployeeID.Location = New System.Drawing.Point(273, 118)
        Me.lblEmployeeID.Name = "lblEmployeeID"
        Me.lblEmployeeID.Size = New System.Drawing.Size(94, 20)
        Me.lblEmployeeID.TabIndex = 87
        Me.lblEmployeeID.Text = "Employee ID"
        '
        'datepickBirthday
        '
        Me.datepickBirthday.CustomFormat = "yyyy/MM/dd"
        Me.datepickBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datepickBirthday.Location = New System.Drawing.Point(40, 379)
        Me.datepickBirthday.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datepickBirthday.Name = "datepickBirthday"
        Me.datepickBirthday.Size = New System.Drawing.Size(313, 27)
        Me.datepickBirthday.TabIndex = 97
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.lblPatientInformation)
        Me.Panel1.Controls.Add(Me.picboxPatientLogo)
        Me.Panel1.Location = New System.Drawing.Point(11, 11)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(571, 68)
        Me.Panel1.TabIndex = 86
        '
        'grpboxEmployeeInfo
        '
        Me.grpboxEmployeeInfo.Controls.Add(Me.txtboxContactNo)
        Me.grpboxEmployeeInfo.Controls.Add(Me.btnCancel)
        Me.grpboxEmployeeInfo.Controls.Add(Me.btnSave)
        Me.grpboxEmployeeInfo.Location = New System.Drawing.Point(11, 84)
        Me.grpboxEmployeeInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxEmployeeInfo.Name = "grpboxEmployeeInfo"
        Me.grpboxEmployeeInfo.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxEmployeeInfo.Size = New System.Drawing.Size(571, 555)
        Me.grpboxEmployeeInfo.TabIndex = 112
        Me.grpboxEmployeeInfo.TabStop = False
        '
        'txtboxContactNo
        '
        Me.txtboxContactNo.Location = New System.Drawing.Point(354, 295)
        Me.txtboxContactNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxContactNo.Name = "txtboxContactNo"
        Me.txtboxContactNo.Size = New System.Drawing.Size(191, 27)
        Me.txtboxContactNo.TabIndex = 113
        '
        'EmpInfoEditAddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 651)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtboxEmailAdd)
        Me.Controls.Add(Me.lblEmailAdd)
        Me.Controls.Add(Me.lblContactNo)
        Me.Controls.Add(Me.lblBirthday)
        Me.Controls.Add(Me.txtboxLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtboxMiddleName)
        Me.Controls.Add(Me.lblMiddleName)
        Me.Controls.Add(Me.txtboxFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtboxEmployeeID)
        Me.Controls.Add(Me.lblEmployeeID)
        Me.Controls.Add(Me.datepickBirthday)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grpboxEmployeeInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EmpInfoEditAddForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Information"
        CType(Me.picboxPatientLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grpboxEmployeeInfo.ResumeLayout(False)
        Me.grpboxEmployeeInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPatientInformation As Label
    Friend WithEvents picboxPatientLogo As PictureBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtboxEmailAdd As TextBox
    Friend WithEvents lblEmailAdd As Label
    Friend WithEvents lblContactNo As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents lblBirthday As Label
    Friend WithEvents txtboxLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtboxMiddleName As TextBox
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents txtboxFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtboxEmployeeID As TextBox
    Friend WithEvents lblEmployeeID As Label
    Friend WithEvents datepickBirthday As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents grpboxEmployeeInfo As GroupBox
    Friend WithEvents txtboxContactNo As TextBox
End Class
