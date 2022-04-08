<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppointmentUpdate
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPatientInformation = New System.Windows.Forms.Label()
        Me.picboxPatientLogo = New System.Windows.Forms.PictureBox()
        Me.grpboxEmployeeInfo = New System.Windows.Forms.GroupBox()
        Me.txtboxPatientID = New System.Windows.Forms.TextBox()
        Me.lblPatientID = New System.Windows.Forms.Label()
        Me.txtboxAppointmentID = New System.Windows.Forms.TextBox()
        Me.lblAppointmentID = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.datetimepickTime = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.datetimepickDate = New System.Windows.Forms.DateTimePicker()
        Me.txtboxDescription = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtboxProcedure = New System.Windows.Forms.TextBox()
        Me.lblProcedure = New System.Windows.Forms.Label()
        Me.txtboxPatientName = New System.Windows.Forms.TextBox()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbboxStatus = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.picboxPatientLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.lblPatientInformation)
        Me.Panel1.Controls.Add(Me.picboxPatientLogo)
        Me.Panel1.Location = New System.Drawing.Point(13, 11)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(405, 68)
        Me.Panel1.TabIndex = 87
        '
        'lblPatientInformation
        '
        Me.lblPatientInformation.AutoSize = True
        Me.lblPatientInformation.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPatientInformation.ForeColor = System.Drawing.SystemColors.Window
        Me.lblPatientInformation.Location = New System.Drawing.Point(59, 12)
        Me.lblPatientInformation.Name = "lblPatientInformation"
        Me.lblPatientInformation.Size = New System.Drawing.Size(309, 41)
        Me.lblPatientInformation.TabIndex = 1
        Me.lblPatientInformation.Text = "Appointment Update"
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
        'grpboxEmployeeInfo
        '
        Me.grpboxEmployeeInfo.Location = New System.Drawing.Point(13, 83)
        Me.grpboxEmployeeInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxEmployeeInfo.Name = "grpboxEmployeeInfo"
        Me.grpboxEmployeeInfo.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxEmployeeInfo.Size = New System.Drawing.Size(405, 610)
        Me.grpboxEmployeeInfo.TabIndex = 113
        Me.grpboxEmployeeInfo.TabStop = False
        '
        'txtboxPatientID
        '
        Me.txtboxPatientID.Location = New System.Drawing.Point(62, 135)
        Me.txtboxPatientID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxPatientID.Name = "txtboxPatientID"
        Me.txtboxPatientID.Size = New System.Drawing.Size(307, 27)
        Me.txtboxPatientID.TabIndex = 155
        '
        'lblPatientID
        '
        Me.lblPatientID.AutoSize = True
        Me.lblPatientID.Location = New System.Drawing.Point(58, 114)
        Me.lblPatientID.Name = "lblPatientID"
        Me.lblPatientID.Size = New System.Drawing.Size(73, 20)
        Me.lblPatientID.TabIndex = 154
        Me.lblPatientID.Text = "Patient ID"
        '
        'txtboxAppointmentID
        '
        Me.txtboxAppointmentID.Location = New System.Drawing.Point(62, 187)
        Me.txtboxAppointmentID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxAppointmentID.Name = "txtboxAppointmentID"
        Me.txtboxAppointmentID.Size = New System.Drawing.Size(307, 27)
        Me.txtboxAppointmentID.TabIndex = 153
        '
        'lblAppointmentID
        '
        Me.lblAppointmentID.AutoSize = True
        Me.lblAppointmentID.Location = New System.Drawing.Point(58, 165)
        Me.lblAppointmentID.Name = "lblAppointmentID"
        Me.lblAppointmentID.Size = New System.Drawing.Size(116, 20)
        Me.lblAppointmentID.TabIndex = 152
        Me.lblAppointmentID.Text = "Appointment ID"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(216, 490)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(42, 20)
        Me.lblTime.TabIndex = 151
        Me.lblTime.Text = "Time"
        '
        'datetimepickTime
        '
        Me.datetimepickTime.CustomFormat = "hh:mm tt"
        Me.datetimepickTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetimepickTime.Location = New System.Drawing.Point(221, 512)
        Me.datetimepickTime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datetimepickTime.Name = "datetimepickTime"
        Me.datetimepickTime.ShowUpDown = True
        Me.datetimepickTime.Size = New System.Drawing.Size(149, 27)
        Me.datetimepickTime.TabIndex = 150
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(58, 490)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(41, 20)
        Me.lblDate.TabIndex = 149
        Me.lblDate.Text = "Date"
        '
        'datetimepickDate
        '
        Me.datetimepickDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickDate.Location = New System.Drawing.Point(62, 512)
        Me.datetimepickDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datetimepickDate.Name = "datetimepickDate"
        Me.datetimepickDate.Size = New System.Drawing.Size(149, 27)
        Me.datetimepickDate.TabIndex = 148
        '
        'txtboxDescription
        '
        Me.txtboxDescription.Location = New System.Drawing.Point(62, 353)
        Me.txtboxDescription.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxDescription.Multiline = True
        Me.txtboxDescription.Name = "txtboxDescription"
        Me.txtboxDescription.Size = New System.Drawing.Size(307, 75)
        Me.txtboxDescription.TabIndex = 147
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(58, 331)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(85, 20)
        Me.lblDescription.TabIndex = 146
        Me.lblDescription.Text = "Description"
        '
        'txtboxProcedure
        '
        Me.txtboxProcedure.Location = New System.Drawing.Point(62, 298)
        Me.txtboxProcedure.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxProcedure.Name = "txtboxProcedure"
        Me.txtboxProcedure.Size = New System.Drawing.Size(307, 27)
        Me.txtboxProcedure.TabIndex = 145
        '
        'lblProcedure
        '
        Me.lblProcedure.AutoSize = True
        Me.lblProcedure.Location = New System.Drawing.Point(58, 275)
        Me.lblProcedure.Name = "lblProcedure"
        Me.lblProcedure.Size = New System.Drawing.Size(76, 20)
        Me.lblProcedure.TabIndex = 144
        Me.lblProcedure.Text = "Procedure"
        '
        'txtboxPatientName
        '
        Me.txtboxPatientName.Location = New System.Drawing.Point(62, 243)
        Me.txtboxPatientName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxPatientName.Name = "txtboxPatientName"
        Me.txtboxPatientName.Size = New System.Drawing.Size(307, 27)
        Me.txtboxPatientName.TabIndex = 143
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Location = New System.Drawing.Point(58, 221)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(98, 20)
        Me.lblPatientName.TabIndex = 142
        Me.lblPatientName.Text = "Patient Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 434)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "Status"
        '
        'cmbboxStatus
        '
        Me.cmbboxStatus.FormattingEnabled = True
        Me.cmbboxStatus.Items.AddRange(New Object() {"No Show", "Cancelled", "Completed", "Scheduled", "Re-Scheduled"})
        Me.cmbboxStatus.Location = New System.Drawing.Point(62, 456)
        Me.cmbboxStatus.Name = "cmbboxStatus"
        Me.cmbboxStatus.Size = New System.Drawing.Size(307, 28)
        Me.cmbboxStatus.TabIndex = 158
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.Window
        Me.btnCancel.Location = New System.Drawing.Point(62, 621)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(308, 38)
        Me.btnCancel.TabIndex = 160
        Me.btnCancel.Text = "Cancel (Esc)"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.ForeColor = System.Drawing.SystemColors.Window
        Me.btnSave.Location = New System.Drawing.Point(62, 577)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(308, 38)
        Me.btnSave.TabIndex = 159
        Me.btnSave.Text = "Update (↵)"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'AppointmentUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 704)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbboxStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtboxPatientID)
        Me.Controls.Add(Me.lblPatientID)
        Me.Controls.Add(Me.txtboxAppointmentID)
        Me.Controls.Add(Me.lblAppointmentID)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.datetimepickTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.datetimepickDate)
        Me.Controls.Add(Me.txtboxDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtboxProcedure)
        Me.Controls.Add(Me.lblProcedure)
        Me.Controls.Add(Me.txtboxPatientName)
        Me.Controls.Add(Me.lblPatientName)
        Me.Controls.Add(Me.grpboxEmployeeInfo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AppointmentUpdate"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picboxPatientLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPatientInformation As Label
    Friend WithEvents picboxPatientLogo As PictureBox
    Friend WithEvents grpboxEmployeeInfo As GroupBox
    Friend WithEvents txtboxPatientID As TextBox
    Friend WithEvents lblPatientID As Label
    Friend WithEvents txtboxAppointmentID As TextBox
    Friend WithEvents lblAppointmentID As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents datetimepickTime As DateTimePicker
    Friend WithEvents lblDate As Label
    Friend WithEvents datetimepickDate As DateTimePicker
    Friend WithEvents txtboxDescription As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtboxProcedure As TextBox
    Friend WithEvents lblProcedure As Label
    Friend WithEvents txtboxPatientName As TextBox
    Friend WithEvents lblPatientName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbboxStatus As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
End Class
