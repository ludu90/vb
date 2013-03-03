'Program: Pay Calculator 
'Programer: Joel Hillin
'Purpose: This program is designed to calculate an employees pay. It also calculates tax and net pay.
'Date: Oct. 7, 2012

Option Strict On
Public Class frmCalculatPay
    Const cdecSingleRate As Decimal = 0.18D
    Const cdecFamilyRate As Decimal = 0.15D
    Const cdecMinHours As Decimal = 5D
    Const cdecMaxHours As Decimal = 60D
    Const cdecMinRate As Decimal = 8D
    Const cdecMaxRate As Decimal = 40D


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'This button closes the program.
        Close()
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'This button performs the calculations stipulated in the program description. Then it displays the results.

        'Declerations.
        Dim decHoursWorked As Decimal
        Dim decHourlyRate As Decimal
        Dim decTaxRate As Decimal
        Dim decGrossPay As Decimal
        Dim decTax As Decimal
        Dim decNetPay As Decimal

        If txtHours.Text = "" Or txtHrlyRate.Text = "" Or txtName.Text = "" Then
            MessageBox.Show("Please fill all text boxes.", "Input Error")
            Me.txtName.Focus()
        Else
            If IsNumeric(Me.txtHours.Text) Or IsNumeric(Me.txtHrlyRate.Text) Then
                decHourlyRate = Convert.ToDecimal(txtHrlyRate.Text)
                decHoursWorked = Convert.ToDecimal(txtHours.Text)
                If decHoursWorked < cdecMinHours Then
                    MessageBox.Show("Hours worked must be greater than or equal to 5.", "Input Error")
                    Me.txtHours.Text = ""
                    Me.txtHours.Focus()
                ElseIf decHoursWorked > cdecMaxHours Then
                    MessageBox.Show("Hours worked cannot exceed more than 60.", "Input Error")
                    Me.txtHours.Text = ""
                    Me.txtHours.Focus()
                ElseIf decHourlyRate < cdecMinRate Then
                    MessageBox.Show("Hourly rate must be greater than or equal to 8.", "Input Error")
                    Me.txtHrlyRate.Text = ""
                    Me.txtHrlyRate.Focus()
                ElseIf decHourlyRate > cdecMaxRate Then
                    MessageBox.Show("Hourly Rate cannot exceed more that 40.", "Input Error")
                    Me.txtHrlyRate.Text = ""
                    Me.txtHrlyRate.Focus()
                Else
                    If Me.radFamilyRate.Checked Then
                        decTaxRate = cdecFamilyRate
                        decGrossPay = decHourlyRate * decHoursWorked
                        decTax = decGrossPay * decTaxRate
                        decNetPay = decGrossPay - decTax
                        Me.lblGrossReult.Text = decGrossPay.ToString("C")
                        Me.lblNameResult.Text = txtName.Text
                        Me.lblTaxResult.Text = decTax.ToString("C")
                        Me.lblNetResult.Text = decNetPay.ToString("C")
                    ElseIf Me.radSingleRate.Checked Then
                        decTaxRate = cdecSingleRate
                        decGrossPay = decHourlyRate * decHoursWorked
                        decTax = decGrossPay * decTaxRate
                        decNetPay = decGrossPay - decTax
                        Me.lblGrossReult.Text = decGrossPay.ToString("C")
                        Me.lblNameResult.Text = txtName.Text
                        Me.lblTaxResult.Text = decTax.ToString("C")
                        Me.lblNetResult.Text = decNetPay.ToString("C")
                    End If
                End If
            Else
                MessageBox.Show("You must input a numeric value for Hours Worked and Hourly Rate.", "Input Error")
                Me.txtHrlyRate.Text = ""
                Me.txtHours.Text = ""
                Me.txtHours.Focus()
            End If
        End If
        decHourlyRate = 0
        decHoursWorked = 0
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'This button clears all results and entered text.
        Me.lblNameResult.Text = ""
        Me.lblNetResult.Text = ""
        Me.lblGrossReult.Text = ""
        Me.lblTaxResult.Text = ""
        Me.txtHours.Clear()
        Me.txtHrlyRate.Clear()
        Me.txtName.Clear()
        Me.txtName.Focus()
        Me.radFamilyRate.Checked = False
        Me.radSingleRate.Checked = False
    End Sub
End Class
