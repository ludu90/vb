<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculatPay
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtHrlyRate = New System.Windows.Forms.TextBox()
        Me.lblCalcYourPay = New System.Windows.Forms.Label()
        Me.radSingleRate = New System.Windows.Forms.RadioButton()
        Me.radFamilyRate = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblHoursWorked = New System.Windows.Forms.Label()
        Me.lblHourlyRate = New System.Windows.Forms.Label()
        Me.lblEmpName = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.lblNameResult = New System.Windows.Forms.Label()
        Me.lblGrossReult = New System.Windows.Forms.Label()
        Me.lblTaxResult = New System.Windows.Forms.Label()
        Me.lblNetResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(14, 318)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(14, 348)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(138, 74)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 2
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(138, 101)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 20)
        Me.txtHours.TabIndex = 3
        '
        'txtHrlyRate
        '
        Me.txtHrlyRate.Location = New System.Drawing.Point(138, 128)
        Me.txtHrlyRate.Name = "txtHrlyRate"
        Me.txtHrlyRate.Size = New System.Drawing.Size(100, 20)
        Me.txtHrlyRate.TabIndex = 4
        '
        'lblCalcYourPay
        '
        Me.lblCalcYourPay.AutoSize = True
        Me.lblCalcYourPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalcYourPay.Location = New System.Drawing.Point(42, 28)
        Me.lblCalcYourPay.Name = "lblCalcYourPay"
        Me.lblCalcYourPay.Size = New System.Drawing.Size(179, 25)
        Me.lblCalcYourPay.TabIndex = 5
        Me.lblCalcYourPay.Text = "Calculate Your Pay"
        '
        'radSingleRate
        '
        Me.radSingleRate.AutoSize = True
        Me.radSingleRate.Location = New System.Drawing.Point(66, 164)
        Me.radSingleRate.Name = "radSingleRate"
        Me.radSingleRate.Size = New System.Drawing.Size(130, 17)
        Me.radSingleRate.TabIndex = 6
        Me.radSingleRate.TabStop = True
        Me.radSingleRate.Text = "Single Rate Tax (18%)"
        Me.radSingleRate.UseVisualStyleBackColor = True
        '
        'radFamilyRate
        '
        Me.radFamilyRate.AutoSize = True
        Me.radFamilyRate.Location = New System.Drawing.Point(66, 188)
        Me.radFamilyRate.Name = "radFamilyRate"
        Me.radFamilyRate.Size = New System.Drawing.Size(130, 17)
        Me.radFamilyRate.TabIndex = 7
        Me.radFamilyRate.TabStop = True
        Me.radFamilyRate.Text = "Family Rate Tax (15%)"
        Me.radFamilyRate.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(94, 280)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 81)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 9
        Me.lblName.Text = "Name"
        '
        'lblHoursWorked
        '
        Me.lblHoursWorked.AutoSize = True
        Me.lblHoursWorked.Location = New System.Drawing.Point(13, 108)
        Me.lblHoursWorked.Name = "lblHoursWorked"
        Me.lblHoursWorked.Size = New System.Drawing.Size(76, 13)
        Me.lblHoursWorked.TabIndex = 10
        Me.lblHoursWorked.Text = "Hours Worked"
        '
        'lblHourlyRate
        '
        Me.lblHourlyRate.AutoSize = True
        Me.lblHourlyRate.Location = New System.Drawing.Point(13, 135)
        Me.lblHourlyRate.Name = "lblHourlyRate"
        Me.lblHourlyRate.Size = New System.Drawing.Size(63, 13)
        Me.lblHourlyRate.TabIndex = 11
        Me.lblHourlyRate.Text = "Hourly Rate"
        '
        'lblEmpName
        '
        Me.lblEmpName.AutoSize = True
        Me.lblEmpName.Location = New System.Drawing.Point(16, 208)
        Me.lblEmpName.Name = "lblEmpName"
        Me.lblEmpName.Size = New System.Drawing.Size(87, 13)
        Me.lblEmpName.TabIndex = 12
        Me.lblEmpName.Text = "Employee Name:"
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Location = New System.Drawing.Point(16, 226)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(58, 13)
        Me.lblGrossPay.TabIndex = 13
        Me.lblGrossPay.Text = "Gross Pay:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(16, 243)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(28, 13)
        Me.lblTax.TabIndex = 14
        Me.lblTax.Text = "Tax:"
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Location = New System.Drawing.Point(16, 260)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(48, 13)
        Me.lblNetPay.TabIndex = 15
        Me.lblNetPay.Text = "Net Pay:"
        '
        'lblNameResult
        '
        Me.lblNameResult.AutoSize = True
        Me.lblNameResult.Location = New System.Drawing.Point(157, 208)
        Me.lblNameResult.Name = "lblNameResult"
        Me.lblNameResult.Size = New System.Drawing.Size(0, 13)
        Me.lblNameResult.TabIndex = 16
        '
        'lblGrossReult
        '
        Me.lblGrossReult.AutoSize = True
        Me.lblGrossReult.Location = New System.Drawing.Point(157, 226)
        Me.lblGrossReult.Name = "lblGrossReult"
        Me.lblGrossReult.Size = New System.Drawing.Size(0, 13)
        Me.lblGrossReult.TabIndex = 17
        '
        'lblTaxResult
        '
        Me.lblTaxResult.AutoSize = True
        Me.lblTaxResult.Location = New System.Drawing.Point(157, 243)
        Me.lblTaxResult.Name = "lblTaxResult"
        Me.lblTaxResult.Size = New System.Drawing.Size(0, 13)
        Me.lblTaxResult.TabIndex = 18
        '
        'lblNetResult
        '
        Me.lblNetResult.AutoSize = True
        Me.lblNetResult.Location = New System.Drawing.Point(157, 260)
        Me.lblNetResult.Name = "lblNetResult"
        Me.lblNetResult.Size = New System.Drawing.Size(0, 13)
        Me.lblNetResult.TabIndex = 19
        '
        'frmCalculatPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(262, 378)
        Me.Controls.Add(Me.lblNetResult)
        Me.Controls.Add(Me.lblTaxResult)
        Me.Controls.Add(Me.lblGrossReult)
        Me.Controls.Add(Me.lblNameResult)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.lblEmpName)
        Me.Controls.Add(Me.lblHourlyRate)
        Me.Controls.Add(Me.lblHoursWorked)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.radFamilyRate)
        Me.Controls.Add(Me.radSingleRate)
        Me.Controls.Add(Me.lblCalcYourPay)
        Me.Controls.Add(Me.txtHrlyRate)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Name = "frmCalculatPay"
        Me.Text = "Calculate Your Pay"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents txtHrlyRate As System.Windows.Forms.TextBox
    Friend WithEvents lblCalcYourPay As System.Windows.Forms.Label
    Friend WithEvents radSingleRate As System.Windows.Forms.RadioButton
    Friend WithEvents radFamilyRate As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblHoursWorked As System.Windows.Forms.Label
    Friend WithEvents lblHourlyRate As System.Windows.Forms.Label
    Friend WithEvents lblEmpName As System.Windows.Forms.Label
    Friend WithEvents lblGrossPay As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblNetPay As System.Windows.Forms.Label
    Friend WithEvents lblNameResult As System.Windows.Forms.Label
    Friend WithEvents lblGrossReult As System.Windows.Forms.Label
    Friend WithEvents lblTaxResult As System.Windows.Forms.Label
    Friend WithEvents lblNetResult As System.Windows.Forms.Label

End Class
