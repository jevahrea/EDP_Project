<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeForm
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
        Me.BtnLoadEmployee = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtboxLiveSearch = New System.Windows.Forms.TextBox()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.lblLiveSearch = New System.Windows.Forms.Label()
        Me.datagridEmployeeTable = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblEmployeeInformation = New System.Windows.Forms.Label()
        Me.picboxEmployeeLogo = New System.Windows.Forms.PictureBox()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMiddleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colContactNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBirthday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.datagridEmployeeTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picboxEmployeeLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLoadEmployee
        '
        Me.BtnLoadEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLoadEmployee.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnLoadEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLoadEmployee.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnLoadEmployee.Location = New System.Drawing.Point(1049, 95)
        Me.BtnLoadEmployee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnLoadEmployee.Name = "BtnLoadEmployee"
        Me.BtnLoadEmployee.Size = New System.Drawing.Size(79, 31)
        Me.BtnLoadEmployee.TabIndex = 22
        Me.BtnLoadEmployee.Text = "Refresh"
        Me.BtnLoadEmployee.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.Color.Goldenrod
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.Window
        Me.btnEdit.Location = New System.Drawing.Point(971, 95)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(72, 31)
        Me.btnEdit.TabIndex = 20
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.DarkRed
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.Window
        Me.btnDelete.Location = New System.Drawing.Point(893, 95)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(72, 31)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtboxLiveSearch
        '
        Me.txtboxLiveSearch.Location = New System.Drawing.Point(11, 95)
        Me.txtboxLiveSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxLiveSearch.Name = "txtboxLiveSearch"
        Me.txtboxLiveSearch.Size = New System.Drawing.Size(233, 27)
        Me.txtboxLiveSearch.TabIndex = 17
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddEmployee.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEmployee.ForeColor = System.Drawing.SystemColors.Window
        Me.btnAddEmployee.Location = New System.Drawing.Point(1149, 95)
        Me.btnAddEmployee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(118, 31)
        Me.btnAddEmployee.TabIndex = 21
        Me.btnAddEmployee.Text = "Add Employee"
        Me.btnAddEmployee.UseVisualStyleBackColor = False
        '
        'lblLiveSearch
        '
        Me.lblLiveSearch.AutoSize = True
        Me.lblLiveSearch.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLiveSearch.Location = New System.Drawing.Point(248, 95)
        Me.lblLiveSearch.Name = "lblLiveSearch"
        Me.lblLiveSearch.Size = New System.Drawing.Size(95, 23)
        Me.lblLiveSearch.TabIndex = 18
        Me.lblLiveSearch.Text = "Live Search"
        '
        'datagridEmployeeTable
        '
        Me.datagridEmployeeTable.AllowUserToAddRows = False
        Me.datagridEmployeeTable.AllowUserToDeleteRows = False
        Me.datagridEmployeeTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datagridEmployeeTable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridEmployeeTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridEmployeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridEmployeeTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colFirstName, Me.colMiddleName, Me.colLastName, Me.colEmail, Me.colContactNumber, Me.colBirthday})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridEmployeeTable.DefaultCellStyle = DataGridViewCellStyle2
        Me.datagridEmployeeTable.Location = New System.Drawing.Point(11, 144)
        Me.datagridEmployeeTable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datagridEmployeeTable.Name = "datagridEmployeeTable"
        Me.datagridEmployeeTable.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridEmployeeTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datagridEmployeeTable.RowHeadersVisible = False
        Me.datagridEmployeeTable.RowHeadersWidth = 51
        Me.datagridEmployeeTable.RowTemplate.Height = 29
        Me.datagridEmployeeTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridEmployeeTable.Size = New System.Drawing.Size(1255, 518)
        Me.datagridEmployeeTable.TabIndex = 23
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
        Me.Panel1.TabIndex = 24
        '
        'lblEmployeeInformation
        '
        Me.lblEmployeeInformation.AutoSize = True
        Me.lblEmployeeInformation.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblEmployeeInformation.ForeColor = System.Drawing.SystemColors.Window
        Me.lblEmployeeInformation.Location = New System.Drawing.Point(59, 12)
        Me.lblEmployeeInformation.Name = "lblEmployeeInformation"
        Me.lblEmployeeInformation.Size = New System.Drawing.Size(324, 41)
        Me.lblEmployeeInformation.TabIndex = 1
        Me.lblEmployeeInformation.Text = "Employee Information"
        '
        'picboxEmployeeLogo
        '
        Me.picboxEmployeeLogo.Image = Global.EDP.My.Resources.Resources.teamwork1
        Me.picboxEmployeeLogo.Location = New System.Drawing.Point(13, 12)
        Me.picboxEmployeeLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picboxEmployeeLogo.Name = "picboxEmployeeLogo"
        Me.picboxEmployeeLogo.Size = New System.Drawing.Size(42, 41)
        Me.picboxEmployeeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxEmployeeLogo.TabIndex = 0
        Me.picboxEmployeeLogo.TabStop = False
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
        'colMiddleName
        '
        Me.colMiddleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colMiddleName.HeaderText = "Middle Name"
        Me.colMiddleName.MinimumWidth = 6
        Me.colMiddleName.Name = "colMiddleName"
        Me.colMiddleName.ReadOnly = True
        '
        'colLastName
        '
        Me.colLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colLastName.HeaderText = "Last Name"
        Me.colLastName.MinimumWidth = 6
        Me.colLastName.Name = "colLastName"
        Me.colLastName.ReadOnly = True
        '
        'colEmail
        '
        Me.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colEmail.HeaderText = "Email Address"
        Me.colEmail.MinimumWidth = 6
        Me.colEmail.Name = "colEmail"
        Me.colEmail.ReadOnly = True
        '
        'colContactNumber
        '
        Me.colContactNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colContactNumber.HeaderText = "Contact Number"
        Me.colContactNumber.MinimumWidth = 6
        Me.colContactNumber.Name = "colContactNumber"
        Me.colContactNumber.ReadOnly = True
        '
        'colBirthday
        '
        Me.colBirthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colBirthday.HeaderText = "Birthday"
        Me.colBirthday.MinimumWidth = 6
        Me.colBirthday.Name = "colBirthday"
        Me.colBirthday.ReadOnly = True
        '
        'EmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1279, 675)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.datagridEmployeeTable)
        Me.Controls.Add(Me.BtnLoadEmployee)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtboxLiveSearch)
        Me.Controls.Add(Me.btnAddEmployee)
        Me.Controls.Add(Me.lblLiveSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EmployeeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.datagridEmployeeTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picboxEmployeeLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents BtnLoadEmployee As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtboxLiveSearch As TextBox
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents lblLiveSearch As Label
    Friend WithEvents datagridEmployeeTable As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblEmployeeInformation As Label
    Friend WithEvents picboxEmployeeLogo As PictureBox
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colFirstName As DataGridViewTextBoxColumn
    Friend WithEvents colMiddleName As DataGridViewTextBoxColumn
    Friend WithEvents colLastName As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents colContactNumber As DataGridViewTextBoxColumn
    Friend WithEvents colBirthday As DataGridViewTextBoxColumn
End Class
