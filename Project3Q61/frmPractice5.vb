Public Class frmPractice5
    Dim decTotal, decDiscount, decNet As Decimal
    Private Sub txtPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.TextChanged
        Call btnCalculate_Click(sender, e)
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        decTotal = Val(txtPrice.Text) * Val(txtUnit.Text)
        If decTotal < 1000 Then
            decDiscount = 0
        ElseIf decTotal < 5000 Then
            decDiscount = 300
        ElseIf decTotal < 10000 Then
            decDiscount = 500
        Else
            decDiscount = 1000
        End If
        decNet = decTotal - decDiscount
        lblTotal.Text = FormatNumber(decTotal)
        lblDiscount.Text = FormatNumber(decDiscount)
        lblNet.Text = FormatNumber(decNet)
    End Sub

    Private Sub txtUnit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnit.TextChanged
        Call btnCalculate_Click(sender, e)
    End Sub
End Class