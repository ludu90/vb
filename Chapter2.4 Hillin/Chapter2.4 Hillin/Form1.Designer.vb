<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpecials
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
        Me.btnDaily = New System.Windows.Forms.Button()
        Me.btnWeekly = New System.Windows.Forms.Button()
        Me.btnHoliday = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblShoppingCart = New System.Windows.Forms.Label()
        Me.lblDailyreg = New System.Windows.Forms.Label()
        Me.lblWeeklyReg = New System.Windows.Forms.Label()
        Me.lblHolidayReg = New System.Windows.Forms.Label()
        Me.lblDailySpecial = New System.Windows.Forms.Label()
        Me.lblWeeklySpecial = New System.Windows.Forms.Label()
        Me.lblHolidaySpecial = New System.Windows.Forms.Label()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.picHoliday = New System.Windows.Forms.PictureBox()
        Me.picWeekly = New System.Windows.Forms.PictureBox()
        Me.picDaily = New System.Windows.Forms.PictureBox()
        CType(Me.picHoliday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWeekly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDaily, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDaily
        '
        Me.btnDaily.BackColor = System.Drawing.Color.Salmon
        Me.btnDaily.Location = New System.Drawing.Point(12, 80)
        Me.btnDaily.Name = "btnDaily"
        Me.btnDaily.Size = New System.Drawing.Size(75, 23)
        Me.btnDaily.TabIndex = 0
        Me.btnDaily.Text = "Daily"
        Me.btnDaily.UseVisualStyleBackColor = False
        '
        'btnWeekly
        '
        Me.btnWeekly.BackColor = System.Drawing.Color.Salmon
        Me.btnWeekly.Location = New System.Drawing.Point(12, 183)
        Me.btnWeekly.Name = "btnWeekly"
        Me.btnWeekly.Size = New System.Drawing.Size(75, 23)
        Me.btnWeekly.TabIndex = 1
        Me.btnWeekly.Text = "Weekly"
        Me.btnWeekly.UseVisualStyleBackColor = False
        '
        'btnHoliday
        '
        Me.btnHoliday.BackColor = System.Drawing.Color.Salmon
        Me.btnHoliday.Location = New System.Drawing.Point(12, 284)
        Me.btnHoliday.Name = "btnHoliday"
        Me.btnHoliday.Size = New System.Drawing.Size(75, 23)
        Me.btnHoliday.TabIndex = 2
        Me.btnHoliday.Text = "Holiday"
        Me.btnHoliday.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnExit.Location = New System.Drawing.Point(411, 577)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblHeading.Location = New System.Drawing.Point(319, 35)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(218, 24)
        Me.lblHeading.TabIndex = 4
        Me.lblHeading.Text = "OnLine Store Specials"
        '
        'lblShoppingCart
        '
        Me.lblShoppingCart.AutoSize = True
        Me.lblShoppingCart.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblShoppingCart.Location = New System.Drawing.Point(371, 466)
        Me.lblShoppingCart.Name = "lblShoppingCart"
        Me.lblShoppingCart.Size = New System.Drawing.Size(155, 13)
        Me.lblShoppingCart.TabIndex = 5
        Me.lblShoppingCart.Text = "Items have been added to cart."
        Me.lblShoppingCart.Visible = False
        '
        'lblDailyreg
        '
        Me.lblDailyreg.AutoSize = True
        Me.lblDailyreg.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblDailyreg.Location = New System.Drawing.Point(12, 106)
        Me.lblDailyreg.Name = "lblDailyreg"
        Me.lblDailyreg.Size = New System.Drawing.Size(93, 13)
        Me.lblDailyreg.TabIndex = 9
        Me.lblDailyreg.Text = "Reg Price: $99.95"
        Me.lblDailyreg.Visible = False
        '
        'lblWeeklyReg
        '
        Me.lblWeeklyReg.AutoSize = True
        Me.lblWeeklyReg.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblWeeklyReg.Location = New System.Drawing.Point(12, 209)
        Me.lblWeeklyReg.Name = "lblWeeklyReg"
        Me.lblWeeklyReg.Size = New System.Drawing.Size(99, 13)
        Me.lblWeeklyReg.TabIndex = 10
        Me.lblWeeklyReg.Text = "Reg Price: $129.95"
        Me.lblWeeklyReg.Visible = False
        '
        'lblHolidayReg
        '
        Me.lblHolidayReg.AutoSize = True
        Me.lblHolidayReg.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblHolidayReg.Location = New System.Drawing.Point(12, 310)
        Me.lblHolidayReg.Name = "lblHolidayReg"
        Me.lblHolidayReg.Size = New System.Drawing.Size(99, 13)
        Me.lblHolidayReg.TabIndex = 11
        Me.lblHolidayReg.Text = "Reg Price: $259.95" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblHolidayReg.Visible = False
        '
        'lblDailySpecial
        '
        Me.lblDailySpecial.AutoSize = True
        Me.lblDailySpecial.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblDailySpecial.Location = New System.Drawing.Point(12, 123)
        Me.lblDailySpecial.Name = "lblDailySpecial"
        Me.lblDailySpecial.Size = New System.Drawing.Size(108, 13)
        Me.lblDailySpecial.TabIndex = 12
        Me.lblDailySpecial.Text = "Special Price: $84.50"
        Me.lblDailySpecial.Visible = False
        '
        'lblWeeklySpecial
        '
        Me.lblWeeklySpecial.AutoSize = True
        Me.lblWeeklySpecial.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblWeeklySpecial.Location = New System.Drawing.Point(12, 226)
        Me.lblWeeklySpecial.Name = "lblWeeklySpecial"
        Me.lblWeeklySpecial.Size = New System.Drawing.Size(114, 13)
        Me.lblWeeklySpecial.TabIndex = 13
        Me.lblWeeklySpecial.Text = "Special Price: $101.47"
        Me.lblWeeklySpecial.Visible = False
        '
        'lblHolidaySpecial
        '
        Me.lblHolidaySpecial.AutoSize = True
        Me.lblHolidaySpecial.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblHolidaySpecial.Location = New System.Drawing.Point(12, 327)
        Me.lblHolidaySpecial.Name = "lblHolidaySpecial"
        Me.lblHolidaySpecial.Size = New System.Drawing.Size(114, 13)
        Me.lblHolidaySpecial.TabIndex = 14
        Me.lblHolidaySpecial.Text = "Special Price: $203.19"
        Me.lblHolidaySpecial.Visible = False
        '
        'btnAddToCart
        '
        Me.btnAddToCart.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnAddToCart.Enabled = False
        Me.btnAddToCart.Location = New System.Drawing.Point(411, 482)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(75, 23)
        Me.btnAddToCart.TabIndex = 15
        Me.btnAddToCart.Text = "Add To Cart"
        Me.btnAddToCart.UseVisualStyleBackColor = False
        '
        'picHoliday
        '
        Me.picHoliday.Image = Global.Chapter2._4_Hillin.My.Resources.Resources.Casio_Exilim_EX_Z8_Digital_Camera
        Me.picHoliday.Location = New System.Drawing.Point(620, 80)
        Me.picHoliday.Name = "picHoliday"
        Me.picHoliday.Size = New System.Drawing.Size(226, 299)
        Me.picHoliday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHoliday.TabIndex = 8
        Me.picHoliday.TabStop = False
        Me.picHoliday.Visible = False
        '
        'picWeekly
        '
        Me.picWeekly.Image = Global.Chapter2._4_Hillin.My.Resources.Resources.imgres
        Me.picWeekly.Location = New System.Drawing.Point(385, 80)
        Me.picWeekly.Name = "picWeekly"
        Me.picWeekly.Size = New System.Drawing.Size(229, 299)
        Me.picWeekly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWeekly.TabIndex = 7
        Me.picWeekly.TabStop = False
        Me.picWeekly.Visible = False
        '
        'picDaily
        '
        Me.picDaily.Image = Global.Chapter2._4_Hillin.My.Resources.Resources._10160175_hiphone_chinese_brand_cell_phones_cell_phones
        Me.picDaily.Location = New System.Drawing.Point(135, 80)
        Me.picDaily.Name = "picDaily"
        Me.picDaily.Size = New System.Drawing.Size(244, 299)
        Me.picDaily.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDaily.TabIndex = 6
        Me.picDaily.TabStop = False
        Me.picDaily.Visible = False
        '
        'frmSpecials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(858, 612)
        Me.Controls.Add(Me.btnAddToCart)
        Me.Controls.Add(Me.lblHolidaySpecial)
        Me.Controls.Add(Me.lblWeeklySpecial)
        Me.Controls.Add(Me.lblDailySpecial)
        Me.Controls.Add(Me.lblHolidayReg)
        Me.Controls.Add(Me.lblWeeklyReg)
        Me.Controls.Add(Me.lblDailyreg)
        Me.Controls.Add(Me.picHoliday)
        Me.Controls.Add(Me.picWeekly)
        Me.Controls.Add(Me.picDaily)
        Me.Controls.Add(Me.lblShoppingCart)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHoliday)
        Me.Controls.Add(Me.btnWeekly)
        Me.Controls.Add(Me.btnDaily)
        Me.Name = "frmSpecials"
        Me.Text = "OnLine Store Specials"
        CType(Me.picHoliday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWeekly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDaily, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDaily As System.Windows.Forms.Button
    Friend WithEvents btnWeekly As System.Windows.Forms.Button
    Friend WithEvents btnHoliday As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents lblShoppingCart As System.Windows.Forms.Label
    Friend WithEvents picDaily As System.Windows.Forms.PictureBox
    Friend WithEvents picWeekly As System.Windows.Forms.PictureBox
    Friend WithEvents picHoliday As System.Windows.Forms.PictureBox
    Friend WithEvents lblDailyreg As System.Windows.Forms.Label
    Friend WithEvents lblWeeklyReg As System.Windows.Forms.Label
    Friend WithEvents lblHolidayReg As System.Windows.Forms.Label
    Friend WithEvents lblDailySpecial As System.Windows.Forms.Label
    Friend WithEvents lblWeeklySpecial As System.Windows.Forms.Label
    Friend WithEvents lblHolidaySpecial As System.Windows.Forms.Label
    Friend WithEvents btnAddToCart As System.Windows.Forms.Button

End Class
