<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppointmentForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblEmployeeInformation = New System.Windows.Forms.Label()
        Me.picboxEmployeeLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.datagridPatientAppoinment = New System.Windows.Forms.DataGridView()
        Me.colPatientID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPatientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProcedureName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelAppointment = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblPatientID = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
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
        Me.btnSaveAppointment = New System.Windows.Forms.Button()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.BtnLoadEmployee = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtboxLiveSearch = New System.Windows.Forms.TextBox()
        Me.lblLiveSearch = New System.Windows.Forms.Label()
        CType(Me.picboxEmployeeLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.datagridPatientAppoinment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAppointment.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEmployeeInformation
        '
        Me.lblEmployeeInformation.AutoSize = True
        Me.lblEmployeeInformation.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblEmployeeInformation.ForeColor = System.Drawing.SystemColors.Window
        Me.lblEmployeeInformation.Location = New System.Drawing.Point(59, 12)
        Me.lblEmployeeInformation.Name = "lblEmployeeInformation"
        Me.lblEmployeeInformation.Size = New System.Drawing.Size(306, 41)
        Me.lblEmployeeInformation.TabIndex = 1
        Me.lblEmployeeInformation.Text = "Patient Appointment"
        '
        'picboxEmployeeLogo
        '
        Me.picboxEmployeeLogo.Image = Global.EDP.My.Resources.Resources.appointment1
        Me.picboxEmployeeLogo.Location = New System.Drawing.Point(13, 12)
        Me.picboxEmployeeLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picboxEmployeeLogo.Name = "picboxEmployeeLogo"
        Me.picboxEmployeeLogo.Size = New System.Drawing.Size(42, 41)
        Me.picboxEmployeeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxEmployeeLogo.TabIndex = 0
        Me.picboxEmployeeLogo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.lblEmployeeInformation)
        Me.Panel1.Controls.Add(Me.picboxEmployeeLogo)
        Me.Panel1.Location = New System.Drawing.Point(11, 12)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1255, 68)
        Me.Panel1.TabIndex = 118
        '
        'datagridPatientAppoinment
        '
        Me.datagridPatientAppoinment.AllowUserToAddRows = False
        Me.datagridPatientAppoinment.AllowUserToDeleteRows = False
        Me.datagridPatientAppoinment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datagridPatientAppoinment.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridPatientAppoinment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridPatientAppoinment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridPatientAppoinment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPatientID, Me.colPatientName, Me.colProcedureName, Me.colDescription, Me.colDate, Me.colTime, Me.colStatus})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridPatientAppoinment.DefaultCellStyle = DataGridViewCellStyle2
        Me.datagridPatientAppoinment.Location = New System.Drawing.Point(359, 146)
        Me.datagridPatientAppoinment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datagridPatientAppoinment.Name = "datagridPatientAppoinment"
        Me.datagridPatientAppoinment.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridPatientAppoinment.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datagridPatientAppoinment.RowHeadersVisible = False
        Me.datagridPatientAppoinment.RowHeadersWidth = 51
        Me.datagridPatientAppoinment.RowTemplate.Height = 29
        Me.datagridPatientAppoinment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridPatientAppoinment.Size = New System.Drawing.Size(907, 518)
        Me.datagridPatientAppoinment.TabIndex = 120
        '
        'colPatientID
        '
        Me.colPatientID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPatientID.HeaderText = "Patient ID"
        Me.colPatientID.MinimumWidth = 6
        Me.colPatientID.Name = "colPatientID"
        Me.colPatientID.ReadOnly = True
        '
        'colPatientName
        '
        Me.colPatientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPatientName.HeaderText = "Patient Name"
        Me.colPatientName.MinimumWidth = 6
        Me.colPatientName.Name = "colPatientName"
        Me.colPatientName.ReadOnly = True
        '
        'colProcedureName
        '
        Me.colProcedureName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colProcedureName.HeaderText = "Procedure Name"
        Me.colProcedureName.MinimumWidth = 6
        Me.colProcedureName.Name = "colProcedureName"
        Me.colProcedureName.ReadOnly = True
        '
        'colDescription
        '
        Me.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.MinimumWidth = 6
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        '
        'colDate
        '
        Me.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDate.HeaderText = "Date"
        Me.colDate.MinimumWidth = 6
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        '
        'colTime
        '
        Me.colTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTime.HeaderText = "Time"
        Me.colTime.MinimumWidth = 6
        Me.colTime.Name = "colTime"
        Me.colTime.ReadOnly = True
        '
        'colStatus
        '
        Me.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.MinimumWidth = 6
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        '
        'PanelAppointment
        '
        Me.PanelAppointment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelAppointment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAppointment.Controls.Add(Me.TextBox3)
        Me.PanelAppointment.Controls.Add(Me.lblPatientID)
        Me.PanelAppointment.Controls.Add(Me.TextBox1)
        Me.PanelAppointment.Controls.Add(Me.lblAppointmentID)
        Me.PanelAppointment.Controls.Add(Me.lblTime)
        Me.PanelAppointment.Controls.Add(Me.datetimepickTime)
        Me.PanelAppointment.Controls.Add(Me.lblDate)
        Me.PanelAppointment.Controls.Add(Me.datetimepickDate)
        Me.PanelAppointment.Controls.Add(Me.txtboxDescription)
        Me.PanelAppointment.Controls.Add(Me.lblDescription)
        Me.PanelAppointment.Controls.Add(Me.txtboxProcedure)
        Me.PanelAppointment.Controls.Add(Me.lblProcedure)
        Me.PanelAppointment.Controls.Add(Me.txtboxPatientName)
        Me.PanelAppointment.Controls.Add(Me.btnSaveAppointment)
        Me.PanelAppointment.Controls.Add(Me.lblPatientName)
        Me.PanelAppointment.Location = New System.Drawing.Point(11, 146)
        Me.PanelAppointment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelAppointment.Name = "PanelAppointment"
        Me.PanelAppointment.Size = New System.Drawing.Size(336, 517)
        Me.PanelAppointment.TabIndex = 127
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(11, 52)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(307, 27)
        Me.TextBox3.TabIndex = 141
        '
        'lblPatientID
        '
        Me.lblPatientID.AutoSize = True
        Me.lblPatientID.Location = New System.Drawing.Point(7, 31)
        Me.lblPatientID.Name = "lblPatientID"
        Me.lblPatientID.Size = New System.Drawing.Size(73, 20)
        Me.lblPatientID.TabIndex = 140
        Me.lblPatientID.Text = "Patient ID"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(11, 104)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(307, 27)
        Me.TextBox1.TabIndex = 139
        '
        'lblAppointmentID
        '
        Me.lblAppointmentID.AutoSize = True
        Me.lblAppointmentID.Location = New System.Drawing.Point(7, 82)
        Me.lblAppointmentID.Name = "lblAppointmentID"
        Me.lblAppointmentID.Size = New System.Drawing.Size(116, 20)
        Me.lblAppointmentID.TabIndex = 138
        Me.lblAppointmentID.Text = "Appointment ID"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(165, 350)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(42, 20)
        Me.lblTime.TabIndex = 137
        Me.lblTime.Text = "Time"
        '
        'datetimepickTime
        '
        Me.datetimepickTime.CustomFormat = "hh:mm tt"
        Me.datetimepickTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetimepickTime.Location = New System.Drawing.Point(170, 372)
        Me.datetimepickTime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datetimepickTime.Name = "datetimepickTime"
        Me.datetimepickTime.ShowUpDown = True
        Me.datetimepickTime.Size = New System.Drawing.Size(149, 27)
        Me.datetimepickTime.TabIndex = 136
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(7, 350)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(41, 20)
        Me.lblDate.TabIndex = 135
        Me.lblDate.Text = "Date"
        '
        'datetimepickDate
        '
        Me.datetimepickDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickDate.Location = New System.Drawing.Point(11, 372)
        Me.datetimepickDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datetimepickDate.Name = "datetimepickDate"
        Me.datetimepickDate.Size = New System.Drawing.Size(149, 27)
        Me.datetimepickDate.TabIndex = 134
        '
        'txtboxDescription
        '
        Me.txtboxDescription.Location = New System.Drawing.Point(11, 270)
        Me.txtboxDescription.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxDescription.Multiline = True
        Me.txtboxDescription.Name = "txtboxDescription"
        Me.txtboxDescription.Size = New System.Drawing.Size(307, 75)
        Me.txtboxDescription.TabIndex = 133
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(7, 248)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(85, 20)
        Me.lblDescription.TabIndex = 132
        Me.lblDescription.Text = "Description"
        '
        'txtboxProcedure
        '
        Me.txtboxProcedure.Location = New System.Drawing.Point(11, 215)
        Me.txtboxProcedure.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxProcedure.Name = "txtboxProcedure"
        Me.txtboxProcedure.Size = New System.Drawing.Size(307, 27)
        Me.txtboxProcedure.TabIndex = 131
        '
        'lblProcedure
        '
        Me.lblProcedure.AutoSize = True
        Me.lblProcedure.Location = New System.Drawing.Point(7, 192)
        Me.lblProcedure.Name = "lblProcedure"
        Me.lblProcedure.Size = New System.Drawing.Size(76, 20)
        Me.lblProcedure.TabIndex = 130
        Me.lblProcedure.Text = "Procedure"
        '
        'txtboxPatientName
        '
        Me.txtboxPatientName.Location = New System.Drawing.Point(11, 160)
        Me.txtboxPatientName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxPatientName.Name = "txtboxPatientName"
        Me.txtboxPatientName.Size = New System.Drawing.Size(307, 27)
        Me.txtboxPatientName.TabIndex = 129
        '
        'btnSaveAppointment
        '
        Me.btnSaveAppointment.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSaveAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveAppointment.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSaveAppointment.ForeColor = System.Drawing.SystemColors.Window
        Me.btnSaveAppointment.Location = New System.Drawing.Point(11, 434)
        Me.btnSaveAppointment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSaveAppointment.Name = "btnSaveAppointment"
        Me.btnSaveAppointment.Size = New System.Drawing.Size(307, 38)
        Me.btnSaveAppointment.TabIndex = 127
        Me.btnSaveAppointment.Text = "Save Appointment (↵)"
        Me.btnSaveAppointment.UseVisualStyleBackColor = False
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Location = New System.Drawing.Point(7, 138)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(98, 20)
        Me.lblPatientName.TabIndex = 128
        Me.lblPatientName.Text = "Patient Name"
        '
        'BtnLoadEmployee
        '
        Me.BtnLoadEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLoadEmployee.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnLoadEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLoadEmployee.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnLoadEmployee.Location = New System.Drawing.Point(1189, 96)
        Me.BtnLoadEmployee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnLoadEmployee.Name = "BtnLoadEmployee"
        Me.BtnLoadEmployee.Size = New System.Drawing.Size(79, 31)
        Me.BtnLoadEmployee.TabIndex = 130
        Me.BtnLoadEmployee.Text = "Refresh"
        Me.BtnLoadEmployee.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.DarkRed
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.Window
        Me.btnDelete.Location = New System.Drawing.Point(1107, 96)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(72, 31)
        Me.btnDelete.TabIndex = 128
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtboxLiveSearch
        '
        Me.txtboxLiveSearch.Location = New System.Drawing.Point(359, 98)
        Me.txtboxLiveSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxLiveSearch.Name = "txtboxLiveSearch"
        Me.txtboxLiveSearch.Size = New System.Drawing.Size(233, 27)
        Me.txtboxLiveSearch.TabIndex = 131
        '
        'lblLiveSearch
        '
        Me.lblLiveSearch.AutoSize = True
        Me.lblLiveSearch.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLiveSearch.Location = New System.Drawing.Point(595, 98)
        Me.lblLiveSearch.Name = "lblLiveSearch"
        Me.lblLiveSearch.Size = New System.Drawing.Size(95, 23)
        Me.lblLiveSearch.TabIndex = 132
        Me.lblLiveSearch.Text = "Live Search"
        '
        'AppointmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1279, 675)
        Me.Controls.Add(Me.txtboxLiveSearch)
        Me.Controls.Add(Me.lblLiveSearch)
        Me.Controls.Add(Me.BtnLoadEmployee)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.datagridPatientAppoinment)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelAppointment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AppointmentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient Appointment "
        CType(Me.picboxEmployeeLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.datagridPatientAppoinment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAppointment.ResumeLayout(False)
        Me.PanelAppointment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEmployeeInformation As Label
    Friend WithEvents picboxEmployeeLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents datagridPatientAppoinment As DataGridView
    Friend WithEvents PanelAppointment As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents datetimepickDate As DateTimePicker
    Friend WithEvents txtboxDescription As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtboxProcedure As TextBox
    Friend WithEvents lblProcedure As Label
    Friend WithEvents txtboxPatientName As TextBox
    Friend WithEvents btnSaveAppointment As Button
    Friend WithEvents lblPatientName As Label
    Public WithEvents BtnLoadEmployee As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblAppointmentID As Label
    Friend WithEvents txtboxLiveSearch As TextBox
    Friend WithEvents lblLiveSearch As Label
    Friend WithEvents datetimepickTime As DateTimePicker
    Friend WithEvents colPatientID As DataGridViewTextBoxColumn
    Friend WithEvents colPatientName As DataGridViewTextBoxColumn
    Friend WithEvents colProcedureName As DataGridViewTextBoxColumn
    Friend WithEvents colDescription As DataGridViewTextBoxColumn
    Friend WithEvents colDate As DataGridViewTextBoxColumn
    Friend WithEvents colTime As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblPatientID As Label
End Class
