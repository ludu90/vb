<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGasCost
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
        Me.txtFuel = New System.Windows.Forms.TextBox()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.cbxYears = New System.Windows.Forms.ComboBox()
        Me.txtSUV = New System.Windows.Forms.TextBox()
        Me.txtCompact = New System.Windows.Forms.TextBox()
        Me.lblFuel = New System.Windows.Forms.Label()
        Me.lblMiles = New System.Windows.Forms.Label()
        Me.lblYears = New System.Windows.Forms.Label()
        Me.lblSUVmpg = New System.Windows.Forms.Label()
        Me.lblCCmpg = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.picGas = New System.Windows.Forms.PictureBox()
        Me.lblSUVCost = New System.Windows.Forms.Label()
        Me.lblCompactCost = New System.Windows.Forms.Label()
        Me.lblDifference = New System.Windows.Forms.Label()
        Me.lblSUVResult = New System.Windows.Forms.Label()
        Me.lblCompactResult = New System.Windows.Forms.Label()
        Me.lblDifferenceResult = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picGas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFuel
        '
        Me.txtFuel.Location = New System.Drawing.Point(527, 43)
        Me.txtFuel.Name = "txtFuel"
        Me.txtFuel.Size = New System.Drawing.Size(100, 20)
        Me.txtFuel.TabIndex = 0
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(527, 78)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(100, 20)
        Me.txtMiles.TabIndex = 1
        '
        'cbxYears
        '
        Me.cbxYears.FormattingEnabled = True
        Me.cbxYears.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbxYears.Location = New System.Drawing.Point(527, 113)
        Me.cbxYears.Name = "cbxYears"
        Me.cbxYears.Size = New System.Drawing.Size(100, 21)
        Me.cbxYears.TabIndex = 3
        '
        'txtSUV
        '
        Me.txtSUV.Location = New System.Drawing.Point(527, 150)
        Me.txtSUV.Name = "txtSUV"
        Me.txtSUV.Size = New System.Drawing.Size(100, 20)
        Me.txtSUV.TabIndex = 4
        '
        'txtCompact
        '
        Me.txtCompact.Location = New System.Drawing.Point(527, 186)
        Me.txtCompact.Name = "txtCompact"
        Me.txtCompact.Size = New System.Drawing.Size(100, 20)
        Me.txtCompact.TabIndex = 5
        '
        'lblFuel
        '
        Me.lblFuel.AutoSize = True
        Me.lblFuel.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuel.ForeColor = System.Drawing.Color.Maroon
        Me.lblFuel.Location = New System.Drawing.Point(320, 43)
        Me.lblFuel.Name = "lblFuel"
        Me.lblFuel.Size = New System.Drawing.Size(144, 20)
        Me.lblFuel.TabIndex = 6
        Me.lblFuel.Text = "Fuel Cost Per Gallon"
        '
        'lblMiles
        '
        Me.lblMiles.AutoSize = True
        Me.lblMiles.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiles.ForeColor = System.Drawing.Color.Maroon
        Me.lblMiles.Location = New System.Drawing.Point(320, 78)
        Me.lblMiles.Name = "lblMiles"
        Me.lblMiles.Size = New System.Drawing.Size(164, 20)
        Me.lblMiles.TabIndex = 7
        Me.lblMiles.Text = "Miles Traveled Per Year"
        '
        'lblYears
        '
        Me.lblYears.AutoSize = True
        Me.lblYears.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYears.ForeColor = System.Drawing.Color.Maroon
        Me.lblYears.Location = New System.Drawing.Point(320, 113)
        Me.lblYears.Name = "lblYears"
        Me.lblYears.Size = New System.Drawing.Size(138, 20)
        Me.lblYears.TabIndex = 8
        Me.lblYears.Text = "Years of Ownership"
        '
        'lblSUVmpg
        '
        Me.lblSUVmpg.AutoSize = True
        Me.lblSUVmpg.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSUVmpg.ForeColor = System.Drawing.Color.Maroon
        Me.lblSUVmpg.Location = New System.Drawing.Point(320, 150)
        Me.lblSUVmpg.Name = "lblSUVmpg"
        Me.lblSUVmpg.Size = New System.Drawing.Size(80, 20)
        Me.lblSUVmpg.TabIndex = 9
        Me.lblSUVmpg.Text = "SUV MPG"
        '
        'lblCCmpg
        '
        Me.lblCCmpg.AutoSize = True
        Me.lblCCmpg.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCCmpg.ForeColor = System.Drawing.Color.Maroon
        Me.lblCCmpg.Location = New System.Drawing.Point(320, 186)
        Me.lblCCmpg.Name = "lblCCmpg"
        Me.lblCCmpg.Size = New System.Drawing.Size(137, 20)
        Me.lblCCmpg.TabIndex = 10
        Me.lblCCmpg.Text = "Compact Car MPG"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Red
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCalculate.Location = New System.Drawing.Point(350, 229)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(261, 39)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Compare Life of Vehicle Cost"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'picGas
        '
        Me.picGas.Image = Global.WindowsApplication1.My.Resources.Resources.gas_can_flowers
        Me.picGas.Location = New System.Drawing.Point(12, 12)
        Me.picGas.Name = "picGas"
        Me.picGas.Size = New System.Drawing.Size(302, 442)
        Me.picGas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGas.TabIndex = 12
        Me.picGas.TabStop = False
        '
        'lblSUVCost
        '
        Me.lblSUVCost.AutoSize = True
        Me.lblSUVCost.Location = New System.Drawing.Point(382, 295)
        Me.lblSUVCost.Name = "lblSUVCost"
        Me.lblSUVCost.Size = New System.Drawing.Size(75, 13)
        Me.lblSUVCost.TabIndex = 13
        Me.lblSUVCost.Text = "SUV Gas Cost"
        Me.lblSUVCost.Visible = False
        '
        'lblCompactCost
        '
        Me.lblCompactCost.AutoSize = True
        Me.lblCompactCost.Location = New System.Drawing.Point(382, 325)
        Me.lblCompactCost.Name = "lblCompactCost"
        Me.lblCompactCost.Size = New System.Drawing.Size(95, 13)
        Me.lblCompactCost.TabIndex = 14
        Me.lblCompactCost.Text = "Compact Gas Cost"
        Me.lblCompactCost.Visible = False
        '
        'lblDifference
        '
        Me.lblDifference.AutoSize = True
        Me.lblDifference.Location = New System.Drawing.Point(382, 356)
        Me.lblDifference.Name = "lblDifference"
        Me.lblDifference.Size = New System.Drawing.Size(91, 13)
        Me.lblDifference.TabIndex = 15
        Me.lblDifference.Text = "Difference in Cost"
        Me.lblDifference.Visible = False
        '
        'lblSUVResult
        '
        Me.lblSUVResult.AutoSize = True
        Me.lblSUVResult.Location = New System.Drawing.Point(538, 295)
        Me.lblSUVResult.Name = "lblSUVResult"
        Me.lblSUVResult.Size = New System.Drawing.Size(39, 13)
        Me.lblSUVResult.TabIndex = 16
        Me.lblSUVResult.Text = "Label4"
        Me.lblSUVResult.Visible = False
        '
        'lblCompactResult
        '
        Me.lblCompactResult.AutoSize = True
        Me.lblCompactResult.Location = New System.Drawing.Point(538, 325)
        Me.lblCompactResult.Name = "lblCompactResult"
        Me.lblCompactResult.Size = New System.Drawing.Size(39, 13)
        Me.lblCompactResult.TabIndex = 17
        Me.lblCompactResult.Text = "Label5"
        Me.lblCompactResult.Visible = False
        '
        'lblDifferenceResult
        '
        Me.lblDifferenceResult.AutoSize = True
        Me.lblDifferenceResult.Location = New System.Drawing.Point(538, 356)
        Me.lblDifferenceResult.Name = "lblDifferenceResult"
        Me.lblDifferenceResult.Size = New System.Drawing.Size(39, 13)
        Me.lblDifferenceResult.TabIndex = 18
        Me.lblDifferenceResult.Text = "Label6"
        Me.lblDifferenceResult.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(350, 393)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(261, 25)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(350, 425)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(261, 23)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmGasCost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(644, 466)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblDifferenceResult)
        Me.Controls.Add(Me.lblCompactResult)
        Me.Controls.Add(Me.lblSUVResult)
        Me.Controls.Add(Me.lblDifference)
        Me.Controls.Add(Me.lblCompactCost)
        Me.Controls.Add(Me.lblSUVCost)
        Me.Controls.Add(Me.picGas)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCCmpg)
        Me.Controls.Add(Me.lblSUVmpg)
        Me.Controls.Add(Me.lblYears)
        Me.Controls.Add(Me.lblMiles)
        Me.Controls.Add(Me.lblFuel)
        Me.Controls.Add(Me.txtCompact)
        Me.Controls.Add(Me.txtSUV)
        Me.Controls.Add(Me.cbxYears)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.txtFuel)
        Me.Name = "frmGasCost"
        Me.Text = "Compare Gas Mileage"
        CType(Me.picGas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFuel As System.Windows.Forms.TextBox
    Friend WithEvents txtMiles As System.Windows.Forms.TextBox
    Friend WithEvents cbxYears As System.Windows.Forms.ComboBox
    Friend WithEvents txtSUV As System.Windows.Forms.TextBox
    Friend WithEvents txtCompact As System.Windows.Forms.TextBox
    Friend WithEvents lblFuel As System.Windows.Forms.Label
    Friend WithEvents lblMiles As System.Windows.Forms.Label
    Friend WithEvents lblYears As System.Windows.Forms.Label
    Friend WithEvents lblSUVmpg As System.Windows.Forms.Label
    Friend WithEvents lblCCmpg As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents picGas As System.Windows.Forms.PictureBox
    Friend WithEvents lblSUVCost As System.Windows.Forms.Label
    Friend WithEvents lblCompactCost As System.Windows.Forms.Label
    Friend WithEvents lblDifference As System.Windows.Forms.Label
    Friend WithEvents lblSUVResult As System.Windows.Forms.Label
    Friend WithEvents lblCompactResult As System.Windows.Forms.Label
    Friend WithEvents lblDifferenceResult As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
