<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatTableForm
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
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.datagridPatientTable = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBirthday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStreet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colContactNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datecreated = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtboxLiveSearch = New System.Windows.Forms.TextBox()
        Me.lblPatientInformation = New System.Windows.Forms.Label()
        Me.picboxPatientLogo = New System.Windows.Forms.PictureBox()
        Me.btnAddPatient = New System.Windows.Forms.Button()
        Me.lblLiveSearch = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnLoadPatients = New System.Windows.Forms.Button()
        Me.btnAddAppointment = New System.Windows.Forms.Button()
        CType(Me.datagridPatientTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxPatientLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.Color.Goldenrod
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.Window
        Me.btnEdit.Location = New System.Drawing.Point(981, 95)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(72, 31)
        Me.btnEdit.TabIndex = 14
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.DarkRed
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.Window
        Me.btnDelete.Location = New System.Drawing.Point(903, 95)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(72, 31)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'datagridPatientTable
        '
        Me.datagridPatientTable.AllowUserToAddRows = False
        Me.datagridPatientTable.AllowUserToDeleteRows = False
        Me.datagridPatientTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datagridPatientTable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridPatientTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridPatientTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridPatientTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colFirstName, Me.colLastName, Me.colGender, Me.colBirthday, Me.colAge, Me.colStreet, Me.colContactNumber, Me.datecreated})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridPatientTable.DefaultCellStyle = DataGridViewCellStyle2
        Me.datagridPatientTable.Location = New System.Drawing.Point(11, 144)
        Me.datagridPatientTable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datagridPatientTable.Name = "datagridPatientTable"
        Me.datagridPatientTable.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridPatientTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datagridPatientTable.RowHeadersVisible = False
        Me.datagridPatientTable.RowHeadersWidth = 51
        Me.datagridPatientTable.RowTemplate.Height = 29
        Me.datagridPatientTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridPatientTable.Size = New System.Drawing.Size(1255, 518)
        Me.datagridPatientTable.TabIndex = 12
        '
        'colID
        '
        Me.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colID.HeaderText = "ID"
        Me.colID.MinimumWidth = 6
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        '
        'colFirstName
        '
        Me.colFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colFirstName.HeaderText = "First Name"
        Me.colFirstName.MinimumWidth = 6
        Me.colFirstName.Name = "colFirstName"
        Me.colFirstName.ReadOnly = True
        '
        'colLastName
        '
        Me.colLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colLastName.HeaderText = "Last Name"
        Me.colLastName.MinimumWidth = 6
        Me.colLastName.Name = "colLastName"
        Me.colLastName.ReadOnly = True
        '
        'colGender
        '
        Me.colGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colGender.HeaderText = "Gender"
        Me.colGender.MinimumWidth = 6
        Me.colGender.Name = "colGender"
        Me.colGender.ReadOnly = True
        '
        'colBirthday
        '
        Me.colBirthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colBirthday.HeaderText = "Birthday"
        Me.colBirthday.MinimumWidth = 6
        Me.colBirthday.Name = "colBirthday"
        Me.colBirthday.ReadOnly = True
        '
        'colAge
        '
        Me.colAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colAge.HeaderText = "Age"
        Me.colAge.MinimumWidth = 6
        Me.colAge.Name = "colAge"
        Me.colAge.ReadOnly = True
        '
        'colStreet
        '
        Me.colStreet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colStreet.HeaderText = "Street"
        Me.colStreet.MinimumWidth = 6
        Me.colStreet.Name = "colStreet"
        Me.colStreet.ReadOnly = True
        '
        'colContactNumber
        '
        Me.colContactNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colContactNumber.HeaderText = "Contact Number"
        Me.colContactNumber.MinimumWidth = 6
        Me.colContactNumber.Name = "colContactNumber"
        Me.colContactNumber.ReadOnly = True
        '
        'datecreated
        '
        Me.datecreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.datecreated.HeaderText = "Date Created/Updated"
        Me.datecreated.MinimumWidth = 6
        Me.datecreated.Name = "datecreated"
        Me.datecreated.ReadOnly = True
        '
        'txtboxLiveSearch
        '
        Me.txtboxLiveSearch.Location = New System.Drawing.Point(11, 98)
        Me.txtboxLiveSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxLiveSearch.Name = "txtboxLiveSearch"
        Me.txtboxLiveSearch.Size = New System.Drawing.Size(233, 27)
        Me.txtboxLiveSearch.TabIndex = 10
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
        'btnAddPatient
        '
        Me.btnAddPatient.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddPatient.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPatient.ForeColor = System.Drawing.SystemColors.Window
        Me.btnAddPatient.Location = New System.Drawing.Point(1158, 95)
        Me.btnAddPatient.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddPatient.Name = "btnAddPatient"
        Me.btnAddPatient.Size = New System.Drawing.Size(109, 31)
        Me.btnAddPatient.TabIndex = 15
        Me.btnAddPatient.Text = "Add Patient"
        Me.btnAddPatient.UseVisualStyleBackColor = False
        '
        'lblLiveSearch
        '
        Me.lblLiveSearch.AutoSize = True
        Me.lblLiveSearch.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLiveSearch.Location = New System.Drawing.Point(247, 99)
        Me.lblLiveSearch.Name = "lblLiveSearch"
        Me.lblLiveSearch.Size = New System.Drawing.Size(95, 23)
        Me.lblLiveSearch.TabIndex = 11
        Me.lblLiveSearch.Text = "Live Search"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.lblPatientInformation)
        Me.Panel1.Controls.Add(Me.picboxPatientLogo)
        Me.Panel1.Location = New System.Drawing.Point(11, 12)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1255, 68)
        Me.Panel1.TabIndex = 9
        '
        'BtnLoadPatients
        '
        Me.BtnLoadPatients.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLoadPatients.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnLoadPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLoadPatients.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnLoadPatients.Location = New System.Drawing.Point(1059, 95)
        Me.BtnLoadPatients.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnLoadPatients.Name = "BtnLoadPatients"
        Me.BtnLoadPatients.Size = New System.Drawing.Size(79, 31)
        Me.BtnLoadPatients.TabIndex = 16
        Me.BtnLoadPatients.Text = "Refresh"
        Me.BtnLoadPatients.UseVisualStyleBackColor = False
        '
        'btnAddAppointment
        '
        Me.btnAddAppointment.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAppointment.ForeColor = System.Drawing.SystemColors.Window
        Me.btnAddAppointment.Location = New System.Drawing.Point(347, 95)
        Me.btnAddAppointment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddAppointment.Name = "btnAddAppointment"
        Me.btnAddAppointment.Size = New System.Drawing.Size(151, 31)
        Me.btnAddAppointment.TabIndex = 17
        Me.btnAddAppointment.Text = "Add Appointment"
        Me.btnAddAppointment.UseVisualStyleBackColor = False
        '
        'PatTableForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1279, 675)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAddAppointment)
        Me.Controls.Add(Me.BtnLoadPatients)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.datagridPatientTable)
        Me.Controls.Add(Me.txtboxLiveSearch)
        Me.Controls.Add(Me.btnAddPatient)
        Me.Controls.Add(Me.lblLiveSearch)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimizeBox = False
        Me.Name = "PatTableForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.datagridPatientTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxPatientLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents datagridPatientTable As DataGridView
    Friend WithEvents txtboxLiveSearch As TextBox
    Friend WithEvents lblPatientInformation As Label
    Friend WithEvents picboxPatientLogo As PictureBox
    Friend WithEvents btnAddPatient As Button
    Friend WithEvents lblLiveSearch As Label
    Friend WithEvents Panel1 As Panel
    Public WithEvents BtnLoadPatients As Button
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colFirstName As DataGridViewTextBoxColumn
    Friend WithEvents colLastName As DataGridViewTextBoxColumn
    Friend WithEvents colGender As DataGridViewTextBoxColumn
    Friend WithEvents colBirthday As DataGridViewTextBoxColumn
    Friend WithEvents colAge As DataGridViewTextBoxColumn
    Friend WithEvents colStreet As DataGridViewTextBoxColumn
    Friend WithEvents colContactNumber As DataGridViewTextBoxColumn
    Friend WithEvents datecreated As DataGridViewTextBoxColumn
    Friend WithEvents btnAddAppointment As Button
End Class
