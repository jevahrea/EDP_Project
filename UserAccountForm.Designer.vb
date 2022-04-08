<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserAccountForm
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnLoadEmployee = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.txtboxLiveSearch = New System.Windows.Forms.TextBox()
        Me.lblLiveSearch = New System.Windows.Forms.Label()
        Me.panelUserInformation = New System.Windows.Forms.Panel()
        Me.lblUserAccount = New System.Windows.Forms.Label()
        Me.picboxEmployeeLogo = New System.Windows.Forms.PictureBox()
        Me.datagridUserTable = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUsername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPassword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUserType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSecQuestion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPassAnswer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.panelUserInformation.SuspendLayout()
        CType(Me.picboxEmployeeLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridUserTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLoadEmployee
        '
        Me.BtnLoadEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLoadEmployee.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnLoadEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLoadEmployee.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnLoadEmployee.Location = New System.Drawing.Point(1039, 76)
        Me.BtnLoadEmployee.Name = "BtnLoadEmployee"
        Me.BtnLoadEmployee.Size = New System.Drawing.Size(69, 25)
        Me.BtnLoadEmployee.TabIndex = 30
        Me.BtnLoadEmployee.Text = "Refresh"
        Me.BtnLoadEmployee.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.Color.Goldenrod
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.Window
        Me.btnEdit.Location = New System.Drawing.Point(970, 76)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(63, 25)
        Me.btnEdit.TabIndex = 28
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'txtboxLiveSearch
        '
        Me.txtboxLiveSearch.Location = New System.Drawing.Point(10, 76)
        Me.txtboxLiveSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxLiveSearch.Name = "txtboxLiveSearch"
        Me.txtboxLiveSearch.Size = New System.Drawing.Size(204, 23)
        Me.txtboxLiveSearch.TabIndex = 25
        '
        'lblLiveSearch
        '
        Me.lblLiveSearch.AutoSize = True
        Me.lblLiveSearch.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblLiveSearch.Location = New System.Drawing.Point(217, 76)
        Me.lblLiveSearch.Name = "lblLiveSearch"
        Me.lblLiveSearch.Size = New System.Drawing.Size(77, 19)
        Me.lblLiveSearch.TabIndex = 26
        Me.lblLiveSearch.Text = "Live Search"
        '
        'panelUserInformation
        '
        Me.panelUserInformation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelUserInformation.BackColor = System.Drawing.Color.DodgerBlue
        Me.panelUserInformation.Controls.Add(Me.lblUserAccount)
        Me.panelUserInformation.Controls.Add(Me.picboxEmployeeLogo)
        Me.panelUserInformation.Location = New System.Drawing.Point(10, 10)
        Me.panelUserInformation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelUserInformation.Name = "panelUserInformation"
        Me.panelUserInformation.Size = New System.Drawing.Size(1098, 54)
        Me.panelUserInformation.TabIndex = 32
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
        'picboxEmployeeLogo
        '
        Me.picboxEmployeeLogo.Image = Global.EDP.My.Resources.Resources.user1
        Me.picboxEmployeeLogo.Location = New System.Drawing.Point(11, 10)
        Me.picboxEmployeeLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picboxEmployeeLogo.Name = "picboxEmployeeLogo"
        Me.picboxEmployeeLogo.Size = New System.Drawing.Size(37, 33)
        Me.picboxEmployeeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxEmployeeLogo.TabIndex = 0
        Me.picboxEmployeeLogo.TabStop = False
        '
        'datagridUserTable
        '
        Me.datagridUserTable.AllowUserToAddRows = False
        Me.datagridUserTable.AllowUserToDeleteRows = False
        Me.datagridUserTable.AllowUserToResizeColumns = False
        Me.datagridUserTable.AllowUserToResizeRows = False
        Me.datagridUserTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datagridUserTable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridUserTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datagridUserTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridUserTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colName, Me.colUsername, Me.colPassword, Me.colUserType, Me.colEmail, Me.colSecQuestion, Me.colPassAnswer})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridUserTable.DefaultCellStyle = DataGridViewCellStyle5
        Me.datagridUserTable.Location = New System.Drawing.Point(10, 117)
        Me.datagridUserTable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datagridUserTable.Name = "datagridUserTable"
        Me.datagridUserTable.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridUserTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.datagridUserTable.RowHeadersVisible = False
        Me.datagridUserTable.RowHeadersWidth = 51
        Me.datagridUserTable.RowTemplate.Height = 29
        Me.datagridUserTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridUserTable.Size = New System.Drawing.Size(1098, 414)
        Me.datagridUserTable.TabIndex = 33
        '
        'colID
        '
        Me.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colID.HeaderText = "ID"
        Me.colID.MinimumWidth = 6
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Width = 43
        '
        'colName
        '
        Me.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colName.HeaderText = "Name"
        Me.colName.MinimumWidth = 6
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        '
        'colUsername
        '
        Me.colUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colUsername.HeaderText = "Username"
        Me.colUsername.MinimumWidth = 6
        Me.colUsername.Name = "colUsername"
        Me.colUsername.ReadOnly = True
        '
        'colPassword
        '
        Me.colPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPassword.HeaderText = "Password"
        Me.colPassword.MinimumWidth = 6
        Me.colPassword.Name = "colPassword"
        Me.colPassword.ReadOnly = True
        '
        'colUserType
        '
        Me.colUserType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colUserType.HeaderText = "Type"
        Me.colUserType.MinimumWidth = 6
        Me.colUserType.Name = "colUserType"
        Me.colUserType.ReadOnly = True
        '
        'colEmail
        '
        Me.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colEmail.HeaderText = "Email"
        Me.colEmail.MinimumWidth = 6
        Me.colEmail.Name = "colEmail"
        Me.colEmail.ReadOnly = True
        '
        'colSecQuestion
        '
        Me.colSecQuestion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colSecQuestion.HeaderText = "Security Question"
        Me.colSecQuestion.MinimumWidth = 6
        Me.colSecQuestion.Name = "colSecQuestion"
        Me.colSecQuestion.ReadOnly = True
        '
        'colPassAnswer
        '
        Me.colPassAnswer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPassAnswer.HeaderText = "Answer"
        Me.colPassAnswer.MinimumWidth = 6
        Me.colPassAnswer.Name = "colPassAnswer"
        Me.colPassAnswer.ReadOnly = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.DarkRed
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.Window
        Me.btnDelete.Location = New System.Drawing.Point(902, 76)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(63, 25)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'UserAccountForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 540)
        Me.ControlBox = False
        Me.Controls.Add(Me.datagridUserTable)
        Me.Controls.Add(Me.BtnLoadEmployee)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtboxLiveSearch)
        Me.Controls.Add(Me.lblLiveSearch)
        Me.Controls.Add(Me.panelUserInformation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserAccountForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Information"
        Me.panelUserInformation.ResumeLayout(False)
        Me.panelUserInformation.PerformLayout()
        CType(Me.picboxEmployeeLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagridUserTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents BtnLoadEmployee As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents txtboxLiveSearch As TextBox
    Friend WithEvents lblLiveSearch As Label
    Friend WithEvents panelUserInformation As Panel
    Friend WithEvents lblUserAccount As Label
    Friend WithEvents picboxEmployeeLogo As PictureBox
    Friend WithEvents datagridUserTable As DataGridView
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colUsername As DataGridViewTextBoxColumn
    Friend WithEvents colPassword As DataGridViewTextBoxColumn
    Friend WithEvents colUserType As DataGridViewTextBoxColumn
    Friend WithEvents colEmail As DataGridViewTextBoxColumn
    Friend WithEvents colSecQuestion As DataGridViewTextBoxColumn
    Friend WithEvents colPassAnswer As DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As Button
End Class
