<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatInfoEditAddForm
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
        Me.txtboxDateCreated = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblDateCreated = New System.Windows.Forms.Label()
        Me.txtboxStreet = New System.Windows.Forms.TextBox()
        Me.lblStreet = New System.Windows.Forms.Label()
        Me.txtboxCity = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtboxProvince = New System.Windows.Forms.TextBox()
        Me.lblProvince = New System.Windows.Forms.Label()
        Me.txtboxAge = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtboxContactNo = New System.Windows.Forms.TextBox()
        Me.lblContactNo = New System.Windows.Forms.Label()
        Me.cmbboxGender = New System.Windows.Forms.ComboBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.txtboxLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtboxMiddleName = New System.Windows.Forms.TextBox()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.txtboxFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtboxPatientID = New System.Windows.Forms.TextBox()
        Me.lblPatientID = New System.Windows.Forms.Label()
        Me.datepickBirthday = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPatientInformation = New System.Windows.Forms.Label()
        Me.picboxPatientLogo = New System.Windows.Forms.PictureBox()
        Me.grpboxPatientInfo = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picboxPatientLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpboxPatientInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtboxDateCreated
        '
        Me.txtboxDateCreated.Enabled = False
        Me.txtboxDateCreated.Location = New System.Drawing.Point(328, 552)
        Me.txtboxDateCreated.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxDateCreated.Name = "txtboxDateCreated"
        Me.txtboxDateCreated.Size = New System.Drawing.Size(230, 27)
        Me.txtboxDateCreated.TabIndex = 84
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.ForeColor = System.Drawing.SystemColors.Window
        Me.btnSave.Location = New System.Drawing.Point(27, 525)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(519, 38)
        Me.btnSave.TabIndex = 83
        Me.btnSave.Text = "Save (↵)"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblDateCreated
        '
        Me.lblDateCreated.AutoSize = True
        Me.lblDateCreated.Location = New System.Drawing.Point(325, 529)
        Me.lblDateCreated.Name = "lblDateCreated"
        Me.lblDateCreated.Size = New System.Drawing.Size(97, 20)
        Me.lblDateCreated.TabIndex = 82
        Me.lblDateCreated.Text = "Date Created"
        '
        'txtboxStreet
        '
        Me.txtboxStreet.Location = New System.Drawing.Point(39, 552)
        Me.txtboxStreet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxStreet.Name = "txtboxStreet"
        Me.txtboxStreet.Size = New System.Drawing.Size(274, 27)
        Me.txtboxStreet.TabIndex = 81
        '
        'lblStreet
        '
        Me.lblStreet.AutoSize = True
        Me.lblStreet.Location = New System.Drawing.Point(35, 529)
        Me.lblStreet.Name = "lblStreet"
        Me.lblStreet.Size = New System.Drawing.Size(48, 20)
        Me.lblStreet.TabIndex = 80
        Me.lblStreet.Text = "Street"
        '
        'txtboxCity
        '
        Me.txtboxCity.Location = New System.Drawing.Point(328, 496)
        Me.txtboxCity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxCity.Name = "txtboxCity"
        Me.txtboxCity.Size = New System.Drawing.Size(230, 27)
        Me.txtboxCity.TabIndex = 79
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(325, 472)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(34, 20)
        Me.lblCity.TabIndex = 78
        Me.lblCity.Text = "City"
        '
        'txtboxProvince
        '
        Me.txtboxProvince.Location = New System.Drawing.Point(39, 496)
        Me.txtboxProvince.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxProvince.Name = "txtboxProvince"
        Me.txtboxProvince.Size = New System.Drawing.Size(274, 27)
        Me.txtboxProvince.TabIndex = 77
        '
        'lblProvince
        '
        Me.lblProvince.AutoSize = True
        Me.lblProvince.Location = New System.Drawing.Point(35, 472)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(65, 20)
        Me.lblProvince.TabIndex = 76
        Me.lblProvince.Text = "Province"
        '
        'txtboxAge
        '
        Me.txtboxAge.Location = New System.Drawing.Point(401, 438)
        Me.txtboxAge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxAge.Name = "txtboxAge"
        Me.txtboxAge.Size = New System.Drawing.Size(157, 27)
        Me.txtboxAge.TabIndex = 75
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(398, 415)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(36, 20)
        Me.lblAge.TabIndex = 74
        Me.lblAge.Text = "Age"
        '
        'txtboxContactNo
        '
        Me.txtboxContactNo.Location = New System.Drawing.Point(39, 438)
        Me.txtboxContactNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxContactNo.Name = "txtboxContactNo"
        Me.txtboxContactNo.Size = New System.Drawing.Size(348, 27)
        Me.txtboxContactNo.TabIndex = 73
        '
        'lblContactNo
        '
        Me.lblContactNo.AutoSize = True
        Me.lblContactNo.Location = New System.Drawing.Point(35, 415)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(118, 20)
        Me.lblContactNo.TabIndex = 72
        Me.lblContactNo.Text = "Contact Number"
        '
        'cmbboxGender
        '
        Me.cmbboxGender.FormattingEnabled = True
        Me.cmbboxGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbboxGender.Location = New System.Drawing.Point(401, 379)
        Me.cmbboxGender.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbboxGender.Name = "cmbboxGender"
        Me.cmbboxGender.Size = New System.Drawing.Size(157, 28)
        Me.cmbboxGender.TabIndex = 71
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(396, 357)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(57, 20)
        Me.lblGender.TabIndex = 70
        Me.lblGender.Text = "Gender"
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Location = New System.Drawing.Point(34, 358)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(64, 20)
        Me.lblBirthday.TabIndex = 68
        Me.lblBirthday.Text = "Birthday"
        '
        'txtboxLastName
        '
        Me.txtboxLastName.Location = New System.Drawing.Point(277, 312)
        Me.txtboxLastName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxLastName.Name = "txtboxLastName"
        Me.txtboxLastName.Size = New System.Drawing.Size(282, 27)
        Me.txtboxLastName.TabIndex = 67
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(272, 291)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(79, 20)
        Me.lblLastName.TabIndex = 66
        Me.lblLastName.Text = "Last Name"
        '
        'txtboxMiddleName
        '
        Me.txtboxMiddleName.Location = New System.Drawing.Point(277, 258)
        Me.txtboxMiddleName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxMiddleName.Name = "txtboxMiddleName"
        Me.txtboxMiddleName.Size = New System.Drawing.Size(282, 27)
        Me.txtboxMiddleName.TabIndex = 65
        '
        'lblMiddleName
        '
        Me.lblMiddleName.AutoSize = True
        Me.lblMiddleName.Location = New System.Drawing.Point(272, 235)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(100, 20)
        Me.lblMiddleName.TabIndex = 64
        Me.lblMiddleName.Text = "Middle Name"
        '
        'txtboxFirstName
        '
        Me.txtboxFirstName.Location = New System.Drawing.Point(277, 201)
        Me.txtboxFirstName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxFirstName.Name = "txtboxFirstName"
        Me.txtboxFirstName.Size = New System.Drawing.Size(282, 27)
        Me.txtboxFirstName.TabIndex = 63
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(272, 179)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(80, 20)
        Me.lblFirstName.TabIndex = 62
        Me.lblFirstName.Text = "First Name"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox2.Image = Global.EDP.My.Resources.Resources.Profile_Pic
        Me.PictureBox2.Location = New System.Drawing.Point(39, 125)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(226, 212)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 61
        Me.PictureBox2.TabStop = False
        '
        'txtboxPatientID
        '
        Me.txtboxPatientID.Enabled = False
        Me.txtboxPatientID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxPatientID.Location = New System.Drawing.Point(277, 145)
        Me.txtboxPatientID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxPatientID.Name = "txtboxPatientID"
        Me.txtboxPatientID.ReadOnly = True
        Me.txtboxPatientID.Size = New System.Drawing.Size(282, 26)
        Me.txtboxPatientID.TabIndex = 60
        '
        'lblPatientID
        '
        Me.lblPatientID.AutoSize = True
        Me.lblPatientID.Location = New System.Drawing.Point(272, 119)
        Me.lblPatientID.Name = "lblPatientID"
        Me.lblPatientID.Size = New System.Drawing.Size(73, 20)
        Me.lblPatientID.TabIndex = 59
        Me.lblPatientID.Text = "Patient ID"
        '
        'datepickBirthday
        '
        Me.datepickBirthday.CustomFormat = "yyyy/MM/dd"
        Me.datepickBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datepickBirthday.Location = New System.Drawing.Point(39, 380)
        Me.datepickBirthday.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datepickBirthday.Name = "datepickBirthday"
        Me.datepickBirthday.Size = New System.Drawing.Size(348, 27)
        Me.datepickBirthday.TabIndex = 69
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.lblPatientInformation)
        Me.Panel1.Controls.Add(Me.picboxPatientLogo)
        Me.Panel1.Location = New System.Drawing.Point(11, 12)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(571, 68)
        Me.Panel1.TabIndex = 58
        '
        'lblPatientInformation
        '
        Me.lblPatientInformation.AutoSize = True
        Me.lblPatientInformation.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPatientInformation.ForeColor = System.Drawing.SystemColors.Window
        Me.lblPatientInformation.Location = New System.Drawing.Point(59, 12)
        Me.lblPatientInformation.Name = "lblPatientInformation"
        Me.lblPatientInformation.Size = New System.Drawing.Size(287, 41)
        Me.lblPatientInformation.TabIndex = 1
        Me.lblPatientInformation.Text = "Patient Information"
        '
        'picboxPatientLogo
        '
        Me.picboxPatientLogo.Image = Global.EDP.My.Resources.Resources.Patient_Logo
        Me.picboxPatientLogo.Location = New System.Drawing.Point(13, 12)
        Me.picboxPatientLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picboxPatientLogo.Name = "picboxPatientLogo"
        Me.picboxPatientLogo.Size = New System.Drawing.Size(42, 41)
        Me.picboxPatientLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxPatientLogo.TabIndex = 0
        Me.picboxPatientLogo.TabStop = False
        '
        'grpboxPatientInfo
        '
        Me.grpboxPatientInfo.Controls.Add(Me.btnCancel)
        Me.grpboxPatientInfo.Controls.Add(Me.btnSave)
        Me.grpboxPatientInfo.Location = New System.Drawing.Point(11, 85)
        Me.grpboxPatientInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxPatientInfo.Name = "grpboxPatientInfo"
        Me.grpboxPatientInfo.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxPatientInfo.Size = New System.Drawing.Size(571, 618)
        Me.grpboxPatientInfo.TabIndex = 85
        Me.grpboxPatientInfo.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.Window
        Me.btnCancel.Location = New System.Drawing.Point(27, 568)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(519, 38)
        Me.btnCancel.TabIndex = 84
        Me.btnCancel.Text = "Cancel (Esc)"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'PatInfoEditAddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 718)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtboxDateCreated)
        Me.Controls.Add(Me.lblDateCreated)
        Me.Controls.Add(Me.txtboxStreet)
        Me.Controls.Add(Me.lblStreet)
        Me.Controls.Add(Me.txtboxCity)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.txtboxProvince)
        Me.Controls.Add(Me.lblProvince)
        Me.Controls.Add(Me.txtboxAge)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.txtboxContactNo)
        Me.Controls.Add(Me.lblContactNo)
        Me.Controls.Add(Me.cmbboxGender)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblBirthday)
        Me.Controls.Add(Me.txtboxLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtboxMiddleName)
        Me.Controls.Add(Me.lblMiddleName)
        Me.Controls.Add(Me.txtboxFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtboxPatientID)
        Me.Controls.Add(Me.lblPatientID)
        Me.Controls.Add(Me.datepickBirthday)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grpboxPatientInfo)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "PatInfoEditAddForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Information"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picboxPatientLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpboxPatientInfo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtboxDateCreated As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents lblDateCreated As Label
    Friend WithEvents txtboxStreet As TextBox
    Friend WithEvents lblStreet As Label
    Friend WithEvents txtboxCity As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents txtboxProvince As TextBox
    Friend WithEvents lblProvince As Label
    Friend WithEvents txtboxAge As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents txtboxContactNo As TextBox
    Friend WithEvents lblContactNo As Label
    Friend WithEvents cmbboxGender As ComboBox
    Friend WithEvents lblGender As Label
    Friend WithEvents lblBirthday As Label
    Friend WithEvents txtboxLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtboxMiddleName As TextBox
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents txtboxFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtboxPatientID As TextBox
    Friend WithEvents lblPatientID As Label
    Friend WithEvents datepickBirthday As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPatientInformation As Label
    Friend WithEvents picboxPatientLogo As PictureBox
    Friend WithEvents grpboxPatientInfo As GroupBox
    Friend WithEvents btnCancel As Button
End Class
