<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnUserLog = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnAppointment = New System.Windows.Forms.Button()
        Me.btnPatient = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtboxUserType = New System.Windows.Forms.TextBox()
        Me.lblUserType = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMain
        '
        Me.panelMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.panelMain.Location = New System.Drawing.Point(334, 0)
        Me.panelMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(1020, 836)
        Me.panelMain.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnUserLog)
        Me.Panel2.Controls.Add(Me.btnLogout)
        Me.Panel2.Controls.Add(Me.btnUser)
        Me.Panel2.Controls.Add(Me.btnEmployee)
        Me.Panel2.Controls.Add(Me.btnAppointment)
        Me.Panel2.Controls.Add(Me.btnPatient)
        Me.Panel2.Controls.Add(Me.btnDashboard)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(5, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(331, 836)
        Me.Panel2.TabIndex = 4
        '
        'btnUserLog
        '
        Me.btnUserLog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserLog.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUserLog.FlatAppearance.BorderSize = 0
        Me.btnUserLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnUserLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserLog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUserLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnUserLog.Image = Global.EDP.My.Resources.Resources.user
        Me.btnUserLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserLog.Location = New System.Drawing.Point(0, 668)
        Me.btnUserLog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUserLog.Name = "btnUserLog"
        Me.btnUserLog.Padding = New System.Windows.Forms.Padding(21, 0, 0, 0)
        Me.btnUserLog.Size = New System.Drawing.Size(331, 82)
        Me.btnUserLog.TabIndex = 11
        Me.btnUserLog.Text = "  User Log"
        Me.btnUserLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUserLog.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnLogout.Image = Global.EDP.My.Resources.Resources.logout
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 767)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(21, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(331, 69)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "  Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnUser
        '
        Me.btnUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnUser.Image = Global.EDP.My.Resources.Resources.user
        Me.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.Location = New System.Drawing.Point(0, 586)
        Me.btnUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Padding = New System.Windows.Forms.Padding(21, 0, 0, 0)
        Me.btnUser.Size = New System.Drawing.Size(331, 82)
        Me.btnUser.TabIndex = 9
        Me.btnUser.Text = "  User"
        Me.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'btnEmployee
        '
        Me.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEmployee.FlatAppearance.BorderSize = 0
        Me.btnEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployee.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEmployee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEmployee.Image = Global.EDP.My.Resources.Resources.teamwork
        Me.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmployee.Location = New System.Drawing.Point(0, 504)
        Me.btnEmployee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Padding = New System.Windows.Forms.Padding(21, 0, 0, 0)
        Me.btnEmployee.Size = New System.Drawing.Size(331, 82)
        Me.btnEmployee.TabIndex = 8
        Me.btnEmployee.Text = "  Employee"
        Me.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'btnAppointment
        '
        Me.btnAppointment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAppointment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAppointment.FlatAppearance.BorderSize = 0
        Me.btnAppointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppointment.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAppointment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAppointment.Image = Global.EDP.My.Resources.Resources.appointment
        Me.btnAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAppointment.Location = New System.Drawing.Point(0, 422)
        Me.btnAppointment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAppointment.Name = "btnAppointment"
        Me.btnAppointment.Padding = New System.Windows.Forms.Padding(21, 0, 0, 0)
        Me.btnAppointment.Size = New System.Drawing.Size(331, 82)
        Me.btnAppointment.TabIndex = 7
        Me.btnAppointment.Text = "  Appointment"
        Me.btnAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAppointment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAppointment.UseVisualStyleBackColor = True
        '
        'btnPatient
        '
        Me.btnPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPatient.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPatient.FlatAppearance.BorderSize = 0
        Me.btnPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPatient.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPatient.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPatient.Image = Global.EDP.My.Resources.Resources.patient__1_
        Me.btnPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPatient.Location = New System.Drawing.Point(0, 340)
        Me.btnPatient.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPatient.Name = "btnPatient"
        Me.btnPatient.Padding = New System.Windows.Forms.Padding(21, 0, 0, 0)
        Me.btnPatient.Size = New System.Drawing.Size(331, 82)
        Me.btnPatient.TabIndex = 6
        Me.btnPatient.Text = "  Patient "
        Me.btnPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPatient.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDashboard.Image = Global.EDP.My.Resources.Resources.dashboard__1_
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 258)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(21, 0, 0, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(331, 82)
        Me.btnDashboard.TabIndex = 5
        Me.btnDashboard.Text = "  Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel5.Controls.Add(Me.txtboxUserType)
        Me.Panel5.Controls.Add(Me.lblUserType)
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(331, 258)
        Me.Panel5.TabIndex = 4
        '
        'txtboxUserType
        '
        Me.txtboxUserType.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtboxUserType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxUserType.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtboxUserType.ForeColor = System.Drawing.Color.White
        Me.txtboxUserType.Location = New System.Drawing.Point(80, 192)
        Me.txtboxUserType.Name = "txtboxUserType"
        Me.txtboxUserType.ReadOnly = True
        Me.txtboxUserType.Size = New System.Drawing.Size(169, 23)
        Me.txtboxUserType.TabIndex = 5
        Me.txtboxUserType.TabStop = False
        Me.txtboxUserType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblUserType
        '
        Me.lblUserType.AutoSize = True
        Me.lblUserType.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblUserType.ForeColor = System.Drawing.Color.White
        Me.lblUserType.Location = New System.Drawing.Point(126, 177)
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(0, 23)
        Me.lblUserType.TabIndex = 4
        Me.lblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EDP.My.Resources.Resources.profile
        Me.PictureBox1.Location = New System.Drawing.Point(80, 37)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(169, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 836)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panelMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MainForm"
        Me.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Text = "Main Window"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMain As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnUser As Button
    Friend WithEvents btnEmployee As Button
    Friend WithEvents btnAppointment As Button
    Friend WithEvents btnPatient As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnUserLog As Button
    Friend WithEvents lblUserType As Label
    Friend WithEvents txtboxUserType As TextBox
End Class
