﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_userCashAdvance
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
        Me.components = New System.ComponentModel.Container()
        Me.txt_middleInitial = New System.Windows.Forms.TextBox()
        Me.lbl_middleInitial = New System.Windows.Forms.Label()
        Me.txt_lastName = New System.Windows.Forms.TextBox()
        Me.lbl_lastName = New System.Windows.Forms.Label()
        Me.txt_firstName = New System.Windows.Forms.TextBox()
        Me.lbl_firstName = New System.Windows.Forms.Label()
        Me.txt_salaryLevel = New System.Windows.Forms.TextBox()
        Me.lbl_salaryLevel = New System.Windows.Forms.Label()
        Me.txt_employeeID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_dateToday = New System.Windows.Forms.TextBox()
        Me.lbl_dateToday = New System.Windows.Forms.Label()
        Me.grpbox_input = New System.Windows.Forms.GroupBox()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.txt_amount = New System.Windows.Forms.TextBox()
        Me.lbl_amount = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.Cash_advance_salary_loanDataSet = New cash_advance_salary_loan.cash_advance_salary_loanDataSet()
        Me.CashadvanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cash_advanceTableAdapter = New cash_advance_salary_loan.cash_advance_salary_loanDataSetTableAdapters.cash_advanceTableAdapter()
        Me.grpbox_input.SuspendLayout()
        CType(Me.Cash_advance_salary_loanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CashadvanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_middleInitial
        '
        Me.txt_middleInitial.Enabled = False
        Me.txt_middleInitial.Location = New System.Drawing.Point(372, 71)
        Me.txt_middleInitial.Name = "txt_middleInitial"
        Me.txt_middleInitial.Size = New System.Drawing.Size(56, 22)
        Me.txt_middleInitial.TabIndex = 24
        '
        'lbl_middleInitial
        '
        Me.lbl_middleInitial.AutoSize = True
        Me.lbl_middleInitial.Location = New System.Drawing.Point(277, 76)
        Me.lbl_middleInitial.Name = "lbl_middleInitial"
        Me.lbl_middleInitial.Size = New System.Drawing.Size(89, 17)
        Me.lbl_middleInitial.TabIndex = 23
        Me.lbl_middleInitial.Text = "Middle Initial:"
        '
        'txt_lastName
        '
        Me.txt_lastName.Enabled = False
        Me.txt_lastName.Location = New System.Drawing.Point(372, 43)
        Me.txt_lastName.Name = "txt_lastName"
        Me.txt_lastName.Size = New System.Drawing.Size(147, 22)
        Me.txt_lastName.TabIndex = 22
        '
        'lbl_lastName
        '
        Me.lbl_lastName.AutoSize = True
        Me.lbl_lastName.Location = New System.Drawing.Point(286, 46)
        Me.lbl_lastName.Name = "lbl_lastName"
        Me.lbl_lastName.Size = New System.Drawing.Size(80, 17)
        Me.lbl_lastName.TabIndex = 21
        Me.lbl_lastName.Text = "Last Name:"
        '
        'txt_firstName
        '
        Me.txt_firstName.Enabled = False
        Me.txt_firstName.Location = New System.Drawing.Point(372, 15)
        Me.txt_firstName.Name = "txt_firstName"
        Me.txt_firstName.Size = New System.Drawing.Size(147, 22)
        Me.txt_firstName.TabIndex = 20
        '
        'lbl_firstName
        '
        Me.lbl_firstName.AutoSize = True
        Me.lbl_firstName.Location = New System.Drawing.Point(286, 18)
        Me.lbl_firstName.Name = "lbl_firstName"
        Me.lbl_firstName.Size = New System.Drawing.Size(80, 17)
        Me.lbl_firstName.TabIndex = 19
        Me.lbl_firstName.Text = "First Name:"
        '
        'txt_salaryLevel
        '
        Me.txt_salaryLevel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CashadvanceBindingSource, "salary_level_id", True))
        Me.txt_salaryLevel.Enabled = False
        Me.txt_salaryLevel.Location = New System.Drawing.Point(123, 71)
        Me.txt_salaryLevel.Name = "txt_salaryLevel"
        Me.txt_salaryLevel.Size = New System.Drawing.Size(147, 22)
        Me.txt_salaryLevel.TabIndex = 18
        '
        'lbl_salaryLevel
        '
        Me.lbl_salaryLevel.AutoSize = True
        Me.lbl_salaryLevel.Location = New System.Drawing.Point(27, 74)
        Me.lbl_salaryLevel.Name = "lbl_salaryLevel"
        Me.lbl_salaryLevel.Size = New System.Drawing.Size(90, 17)
        Me.lbl_salaryLevel.TabIndex = 17
        Me.lbl_salaryLevel.Text = "Salary Level:"
        '
        'txt_employeeID
        '
        Me.txt_employeeID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CashadvanceBindingSource, "employee_id", True))
        Me.txt_employeeID.Enabled = False
        Me.txt_employeeID.Location = New System.Drawing.Point(123, 15)
        Me.txt_employeeID.Name = "txt_employeeID"
        Me.txt_employeeID.Size = New System.Drawing.Size(56, 22)
        Me.txt_employeeID.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Employee ID:"
        '
        'txt_dateToday
        '
        Me.txt_dateToday.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CashadvanceBindingSource, "cash_adv_date", True))
        Me.txt_dateToday.Enabled = False
        Me.txt_dateToday.Location = New System.Drawing.Point(123, 43)
        Me.txt_dateToday.Name = "txt_dateToday"
        Me.txt_dateToday.Size = New System.Drawing.Size(147, 22)
        Me.txt_dateToday.TabIndex = 14
        '
        'lbl_dateToday
        '
        Me.lbl_dateToday.AutoSize = True
        Me.lbl_dateToday.Location = New System.Drawing.Point(31, 46)
        Me.lbl_dateToday.Name = "lbl_dateToday"
        Me.lbl_dateToday.Size = New System.Drawing.Size(86, 17)
        Me.lbl_dateToday.TabIndex = 13
        Me.lbl_dateToday.Text = "Date Today:"
        '
        'grpbox_input
        '
        Me.grpbox_input.Controls.Add(Me.txt_status)
        Me.grpbox_input.Controls.Add(Me.lbl_status)
        Me.grpbox_input.Controls.Add(Me.txt_amount)
        Me.grpbox_input.Controls.Add(Me.lbl_amount)
        Me.grpbox_input.Location = New System.Drawing.Point(146, 99)
        Me.grpbox_input.Name = "grpbox_input"
        Me.grpbox_input.Size = New System.Drawing.Size(282, 88)
        Me.grpbox_input.TabIndex = 25
        Me.grpbox_input.TabStop = False
        Me.grpbox_input.Text = "Input"
        '
        'txt_status
        '
        Me.txt_status.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CashadvanceBindingSource, "cash_adv_status", True))
        Me.txt_status.Enabled = False
        Me.txt_status.Location = New System.Drawing.Point(121, 55)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(147, 22)
        Me.txt_status.TabIndex = 19
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Location = New System.Drawing.Point(63, 58)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(52, 17)
        Me.lbl_status.TabIndex = 18
        Me.lbl_status.Text = "Status:"
        '
        'txt_amount
        '
        Me.txt_amount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CashadvanceBindingSource, "cash_adv_amount", True))
        Me.txt_amount.Location = New System.Drawing.Point(121, 30)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(147, 22)
        Me.txt_amount.TabIndex = 15
        '
        'lbl_amount
        '
        Me.lbl_amount.AutoSize = True
        Me.lbl_amount.Location = New System.Drawing.Point(55, 30)
        Me.lbl_amount.Name = "lbl_amount"
        Me.lbl_amount.Size = New System.Drawing.Size(60, 17)
        Me.lbl_amount.TabIndex = 14
        Me.lbl_amount.Text = "Amount:"
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btn_cancel.Location = New System.Drawing.Point(423, 206)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(96, 36)
        Me.btn_cancel.TabIndex = 28
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_submit
        '
        Me.btn_submit.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btn_submit.Location = New System.Drawing.Point(165, 206)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(96, 36)
        Me.btn_submit.TabIndex = 27
        Me.btn_submit.Text = "Submit"
        Me.btn_submit.UseVisualStyleBackColor = False
        '
        'btn_new
        '
        Me.btn_new.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btn_new.Location = New System.Drawing.Point(12, 206)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(96, 36)
        Me.btn_new.TabIndex = 26
        Me.btn_new.Text = "New"
        Me.btn_new.UseVisualStyleBackColor = False
        '
        'Cash_advance_salary_loanDataSet
        '
        Me.Cash_advance_salary_loanDataSet.DataSetName = "cash_advance_salary_loanDataSet"
        Me.Cash_advance_salary_loanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CashadvanceBindingSource
        '
        Me.CashadvanceBindingSource.DataMember = "cash_advance"
        Me.CashadvanceBindingSource.DataSource = Me.Cash_advance_salary_loanDataSet
        '
        'Cash_advanceTableAdapter
        '
        Me.Cash_advanceTableAdapter.ClearBeforeFill = True
        '
        'frm_userCashAdvance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumPurple
        Me.ClientSize = New System.Drawing.Size(541, 254)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.grpbox_input)
        Me.Controls.Add(Me.txt_middleInitial)
        Me.Controls.Add(Me.lbl_middleInitial)
        Me.Controls.Add(Me.txt_lastName)
        Me.Controls.Add(Me.lbl_lastName)
        Me.Controls.Add(Me.txt_firstName)
        Me.Controls.Add(Me.lbl_firstName)
        Me.Controls.Add(Me.txt_salaryLevel)
        Me.Controls.Add(Me.lbl_salaryLevel)
        Me.Controls.Add(Me.txt_employeeID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_dateToday)
        Me.Controls.Add(Me.lbl_dateToday)
        Me.Name = "frm_userCashAdvance"
        Me.Text = "Cash Advance"
        Me.grpbox_input.ResumeLayout(False)
        Me.grpbox_input.PerformLayout()
        CType(Me.Cash_advance_salary_loanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CashadvanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_middleInitial As TextBox
    Friend WithEvents lbl_middleInitial As Label
    Friend WithEvents txt_lastName As TextBox
    Friend WithEvents lbl_lastName As Label
    Friend WithEvents txt_firstName As TextBox
    Friend WithEvents lbl_firstName As Label
    Friend WithEvents txt_salaryLevel As TextBox
    Friend WithEvents lbl_salaryLevel As Label
    Friend WithEvents txt_employeeID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_dateToday As TextBox
    Friend WithEvents lbl_dateToday As Label
    Friend WithEvents grpbox_input As GroupBox
    Friend WithEvents txt_status As TextBox
    Friend WithEvents lbl_status As Label
    Friend WithEvents txt_amount As TextBox
    Friend WithEvents lbl_amount As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_submit As Button
    Friend WithEvents btn_new As Button
    Friend WithEvents Cash_advance_salary_loanDataSet As cash_advance_salary_loanDataSet
    Friend WithEvents CashadvanceBindingSource As BindingSource
    Friend WithEvents Cash_advanceTableAdapter As cash_advance_salary_loanDataSetTableAdapters.cash_advanceTableAdapter
End Class
