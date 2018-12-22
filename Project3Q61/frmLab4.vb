Public Class frmLab4
    Const decR_BONUS As Decimal = 0.25
    Const decR_TAX As Decimal = 0.07
    Dim datNowDate As Date = Date.Now
    Dim dblSumSalary As Double
    Dim dblBonus As Double
    Dim dblIncome As Double
    Dim dblTax As Double
    Dim dblAllowance As Double
    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click

        dblSumSalary = (Val(txtSalary.Text) * 12)
        lblSumSalary.Text = dblSumSalary.ToString("n")
        dblBonus = Val(txtSale.Text) * decR_BONUS
        lblBonus.Text = dblBonus.ToString("n")
        dblIncome = dblSumSalary + dblBonus
        lblIncome.Text = dblIncome.ToString("n")
        dblAllowance = dblIncome * 0.01
        lblAllowance.Text = dblAllowance.ToString("n")
        dblTax = (dblIncome - dblAllowance) * decR_TAX
        lblTax.Text = dblTax.ToString("n")
    End Sub

    Private Sub frmAssign4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDate.Text = FormatDateTime(datNowDate, DateFormat.GeneralDate)
    End Sub

    Private Sub radDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radDate.CheckedChanged
        lblDate.Text = FormatDateTime(datNowDate, DateFormat.LongDate)
    End Sub

    Private Sub radGenDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGenDate.CheckedChanged
        lblDate.Text = FormatDateTime(datNowDate, DateFormat.GeneralDate)
    End Sub

    Private Sub radShortDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radShortDate.CheckedChanged
        lblDate.Text = FormatDateTime(datNowDate, DateFormat.ShortDate)
    End Sub
End Class