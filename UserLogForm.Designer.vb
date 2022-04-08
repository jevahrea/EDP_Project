<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserLogForm
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
        Me.datagridUserLogs = New System.Windows.Forms.DataGridView()
        Me.BtnLoadUserLogs = New System.Windows.Forms.Button()
        Me.txtboxLiveSearch = New System.Windows.Forms.TextBox()
        Me.lblLiveSearch = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblUserLogs = New System.Windows.Forms.Label()
        Me.picboxEmployeeLogo = New System.Windows.Forms.PictureBox()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUsername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUserType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateTimeIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateTimeOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.datagridUserLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picboxEmployeeLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datagridUserLogs
        '
        Me.datagridUserLogs.AllowUserToAddRows = False
        Me.datagridUserLogs.AllowUserToDeleteRows = False
        Me.datagridUserLogs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.datagridUserLogs.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridUserLogs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridUserLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridUserLogs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colUsername, Me.colUserType, Me.colDateTimeIn, Me.colDateTimeOut})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridUserLogs.DefaultCellStyle = DataGridViewCellStyle2
        Me.datagridUserLogs.Location = New System.Drawing.Point(10, 115)
        Me.datagridUserLogs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datagridUserLogs.Name = "datagridUserLogs"
        Me.datagridUserLogs.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridUserLogs.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datagridUserLogs.RowHeadersVisible = False
        Me.datagridUserLogs.RowHeadersWidth = 51
        Me.datagridUserLogs.RowTemplate.Height = 29
        Me.datagridUserLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridUserLogs.Size = New System.Drawing.Size(1098, 414)
        Me.datagridUserLogs.TabIndex = 31
        '
        'BtnLoadUserLogs
        '
        Me.BtnLoadUserLogs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnLoadUserLogs.BackColor = System.Drawing.Color.ForestGreen
        Me.BtnLoadUserLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLoadUserLogs.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnLoadUserLogs.Location = New System.Drawing.Point(1039, 75)
        Me.BtnLoadUserLogs.Name = "BtnLoadUserLogs"
        Me.BtnLoadUserLogs.Size = New System.Drawing.Size(69, 25)
        Me.BtnLoadUserLogs.TabIndex = 30
        Me.BtnLoadUserLogs.Text = "Refresh"
        Me.BtnLoadUserLogs.UseVisualStyleBackColor = False
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
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.lblUserLogs)
        Me.Panel1.Controls.Add(Me.picboxEmployeeLogo)
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1098, 54)
        Me.Panel1.TabIndex = 32
        '
        'lblUserLogs
        '
        Me.lblUserLogs.AutoSize = True
        Me.lblUserLogs.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblUserLogs.ForeColor = System.Drawing.SystemColors.Window
        Me.lblUserLogs.Location = New System.Drawing.Point(52, 10)
        Me.lblUserLogs.Name = "lblUserLogs"
        Me.lblUserLogs.Size = New System.Drawing.Size(246, 32)
        Me.lblUserLogs.TabIndex = 1
        Me.lblUserLogs.Text = "User Log Information"
        '
        'picboxEmployeeLogo
        '
        Me.picboxEmployeeLogo.Image = Global.EDP.My.Resources.Resources.teamwork1
        Me.picboxEmployeeLogo.Location = New System.Drawing.Point(11, 10)
        Me.picboxEmployeeLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picboxEmployeeLogo.Name = "picboxEmployeeLogo"
        Me.picboxEmployeeLogo.Size = New System.Drawing.Size(37, 33)
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
        'colUsername
        '
        Me.colUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colUsername.HeaderText = "Username"
        Me.colUsername.MinimumWidth = 6
        Me.colUsername.Name = "colUsername"
        Me.colUsername.ReadOnly = True
        '
        'colUserType
        '
        Me.colUserType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colUserType.HeaderText = "Type"
        Me.colUserType.MinimumWidth = 6
        Me.colUserType.Name = "colUserType"
        Me.colUserType.ReadOnly = True
        '
        'colDateTimeIn
        '
        Me.colDateTimeIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDateTimeIn.HeaderText = "Date Time In"
        Me.colDateTimeIn.MinimumWidth = 6
        Me.colDateTimeIn.Name = "colDateTimeIn"
        Me.colDateTimeIn.ReadOnly = True
        '
        'colDateTimeOut
        '
        Me.colDateTimeOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDateTimeOut.HeaderText = "Date Time Out"
        Me.colDateTimeOut.MinimumWidth = 6
        Me.colDateTimeOut.Name = "colDateTimeOut"
        Me.colDateTimeOut.ReadOnly = True
        '
        'UserLogForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 540)
        Me.ControlBox = False
        Me.Controls.Add(Me.datagridUserLogs)
        Me.Controls.Add(Me.BtnLoadUserLogs)
        Me.Controls.Add(Me.txtboxLiveSearch)
        Me.Controls.Add(Me.lblLiveSearch)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserLogForm"
        CType(Me.datagridUserLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picboxEmployeeLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents datagridUserLogs As DataGridView
    Public WithEvents BtnLoadUserLogs As Button
    Friend WithEvents txtboxLiveSearch As TextBox
    Friend WithEvents lblLiveSearch As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblUserLogs As Label
    Friend WithEvents picboxEmployeeLogo As PictureBox
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colUsername As DataGridViewTextBoxColumn
    Friend WithEvents colUserType As DataGridViewTextBoxColumn
    Friend WithEvents colDateTimeIn As DataGridViewTextBoxColumn
    Friend WithEvents colDateTimeOut As DataGridViewTextBoxColumn
End Class
