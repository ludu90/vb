Public Class frmSpecials

    Private Sub btnDaily_Click(sender As System.Object, e As System.EventArgs) Handles btnDaily.Click
        'This button selects the daily special. It also enables the Add to Cart Button.
        Me.picDaily.Visible = True
        Me.picWeekly.Visible = False
        Me.picHoliday.Visible = False
        Me.lblDailyreg.Visible = True
        Me.lblDailySpecial.Visible = True
        Me.lblWeeklyReg.Visible = False
        Me.lblWeeklySpecial.Visible = False
        Me.lblHolidayReg.Visible = False
        Me.lblHolidaySpecial.Visible = False
        Me.btnAddToCart.Enabled = True
    End Sub

    Private Sub btnWeekly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWeekly.Click
        Me.picDaily.Visible = False
        Me.picWeekly.Visible = True
        Me.picHoliday.Visible = False
        Me.lblDailyreg.Visible = False
        Me.lblDailySpecial.Visible = False
        Me.lblWeeklyReg.Visible = True
        Me.lblWeeklySpecial.Visible = True
        Me.lblHolidayReg.Visible = False
        Me.lblHolidaySpecial.Visible = False
        Me.btnAddToCart.Enabled = True
    End Sub

    Private Sub btnHoliday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHoliday.Click
        Me.picDaily.Visible = False
        Me.picWeekly.Visible = False
        Me.picHoliday.Visible = True
        Me.lblDailyreg.Visible = False
        Me.lblDailySpecial.Visible = False
        Me.lblWeeklyReg.Visible = False
        Me.lblWeeklySpecial.Visible = False
        Me.lblHolidayReg.Visible = True
        Me.lblHolidaySpecial.Visible = True
        Me.btnAddToCart.Enabled = True
    End Sub

    Private Sub btnAddToCart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddToCart.Click
        Me.lblShoppingCart.Visible = True
        Me.btnHoliday.Enabled = False
        Me.btnDaily.Enabled = False
        Me.btnWeekly.Enabled = False
        Me.btnAddToCart.Enabled = False
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
