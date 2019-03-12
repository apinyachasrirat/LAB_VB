Public Class frmLab4
    Dim decR_BONUS As Decimal = 0.2
    Dim decR_TEX As Decimal = 0.07
    Dim decR_ALLOW As Decimal = 0.01
    Dim Salary, Sale, YearSalary, Bonus, Allincome, Allowance, Tex As Double
    Dim Today As Date = Date.Now
   
    Private Sub btnCalTax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalTax.Click
        Salary = Val(txtSalary.Text)
        Sale = Val(txtSale.Text)
        YearSalary = Salary * 12
        Bonus = Sale * decR_BONUS
        Allincome = Bonus + YearSalary
        Allowance = Allincome * decR_ALLOW
        Tex = (Allincome - Allowance) * decR_TEX


        lblYearSalary.Text = FormatNumber(Sale, 2)
        lblBonus.Text = FormatNumber(Bonus, 2)
        lblAllIncome.Text = FormatNumber(Allincome, 2)
        lblAllowance.Text = FormatNumber(Allowance, 2)
        lblTax.Text = FormatNumber(Tex, 2)

    End Sub

    Private Sub frmLab4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDate.Text = FormatDateTime(Today, DateFormat.ShortDate)
    End Sub

    Private Sub radDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLongDate.CheckedChanged
        lblDate.Text = FormatDateTime(Today, DateFormat.LongDate)
    End Sub

    Private Sub radGenDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGenDate.CheckedChanged
        lblDate.Text = FormatDateTime(Today, DateFormat.GeneralDate)
    End Sub

    Private Sub radShortDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radShortDate.CheckedChanged
        lblDate.Text = FormatDateTime(Today, DateFormat.ShortDate)
    End Sub
End Class