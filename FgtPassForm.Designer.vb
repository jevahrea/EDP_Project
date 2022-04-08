<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FgtPassForm
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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.txtboxAnswer = New System.Windows.Forms.TextBox()
        Me.grpboxSecurityQuest = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.txtboxQuestion = New System.Windows.Forms.TextBox()
        Me.grpboxSecurityQuest.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnOK.ForeColor = System.Drawing.SystemColors.Window
        Me.btnOK.Location = New System.Drawing.Point(125, 132)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(46, 32)
        Me.btnOK.TabIndex = 36
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblAnswer.ForeColor = System.Drawing.Color.Black
        Me.lblAnswer.Location = New System.Drawing.Point(18, 76)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(46, 15)
        Me.lblAnswer.TabIndex = 33
        Me.lblAnswer.Text = "Answer"
        '
        'txtboxAnswer
        '
        Me.txtboxAnswer.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtboxAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxAnswer.Location = New System.Drawing.Point(22, 94)
        Me.txtboxAnswer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxAnswer.Name = "txtboxAnswer"
        Me.txtboxAnswer.Size = New System.Drawing.Size(236, 23)
        Me.txtboxAnswer.TabIndex = 34
        '
        'grpboxSecurityQuest
        '
        Me.grpboxSecurityQuest.Controls.Add(Me.btnCancel)
        Me.grpboxSecurityQuest.Controls.Add(Me.txtboxAnswer)
        Me.grpboxSecurityQuest.Controls.Add(Me.lblAnswer)
        Me.grpboxSecurityQuest.Controls.Add(Me.btnOK)
        Me.grpboxSecurityQuest.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.grpboxSecurityQuest.ForeColor = System.Drawing.Color.MediumBlue
        Me.grpboxSecurityQuest.Location = New System.Drawing.Point(10, 10)
        Me.grpboxSecurityQuest.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxSecurityQuest.Name = "grpboxSecurityQuest"
        Me.grpboxSecurityQuest.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grpboxSecurityQuest.Size = New System.Drawing.Size(278, 179)
        Me.grpboxSecurityQuest.TabIndex = 50
        Me.grpboxSecurityQuest.TabStop = False
        Me.grpboxSecurityQuest.Text = "Security Question"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Gray
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.Window
        Me.btnCancel.Location = New System.Drawing.Point(180, 132)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(78, 32)
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblQuestion.Location = New System.Drawing.Point(27, 39)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(55, 15)
        Me.lblQuestion.TabIndex = 31
        Me.lblQuestion.Text = "Question"
        '
        'txtboxQuestion
        '
        Me.txtboxQuestion.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtboxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtboxQuestion.Location = New System.Drawing.Point(32, 58)
        Me.txtboxQuestion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtboxQuestion.Name = "txtboxQuestion"
        Me.txtboxQuestion.ReadOnly = True
        Me.txtboxQuestion.Size = New System.Drawing.Size(236, 23)
        Me.txtboxQuestion.TabIndex = 32
        '
        'FgtPassForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 201)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtboxQuestion)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.grpboxSecurityQuest)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "FgtPassForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forgot Password"
        Me.grpboxSecurityQuest.ResumeLayout(False)
        Me.grpboxSecurityQuest.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtboxYourAnswer As TextBox
    Friend WithEvents lblYourAnswer As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents lblAnswer As Label
    Friend WithEvents txtboxAnswer As TextBox
    Friend WithEvents grpboxSecurityQuest As GroupBox
    Friend WithEvents lblQuestion As Label
    Friend WithEvents txtboxQuestion As TextBox
    Friend WithEvents btnCancel As Button
End Class
