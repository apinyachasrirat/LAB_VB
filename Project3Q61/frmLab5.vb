Public Class frmLab5
    Dim dectotal, decDiscount, decNet, decCredit As Double
    Private Sub txtPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.TextChanged
        lblTotal.Text = Val(txtPrice.Text)
    End Sub

    Private Sub txtUnit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnit.TextChanged
            lblTotal.Text = Val(txtPrice.Text) * Val(txtUnit.Text)
    End Sub

    Private Sub radMember_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMember.CheckedChanged
        gpbPaid.Enabled = True
        radPaid.Checked = True
        radCredit.Checked = False
        lblCredit.Text = ""
        lblDiscount.Text = ""
        lblPaid.Text = ""

    End Sub

    Private Sub radOther_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOther.CheckedChanged
        radPaid.Checked = True
        gpbPaid.Enabled = False
        lblCredit.Text = ""
        lblDiscount.Text = ""
        lblPaid.Text = ""
    End Sub

    Private Sub frmLab5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        radOther.Checked = True
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        decTotal = lblTotal.Text
        If txtProduct.Text = "" Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์")
            txtProduct.Clear()
        End If
        If Not IsNumeric(txtPrice.Text) Or Not IsNumeric(txtUnit.Text) Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์")
            txtPrice.Clear()
            txtUnit.Clear()
        End If
        If radMember.Checked = True Then
            If dectotal < 1000 Then
                decDiscount = dectotal * 0
            ElseIf dectotal < 5000 Then
                decDiscount = dectotal * 5 / 100
            ElseIf dectotal < 1000 Then
                decDiscount = dectotal * 10 / 100
            Else
                decDiscount = dectotal * 0.15
            End If
        ElseIf radOther.Checked = True Then

            decDiscount = 0

        End If
        decNet = decTotal - decDiscount
        If radPaid.Checked = True Then
            decCredit = 0
        ElseIf radCredit.Checked = True Then
            decCredit = decTotal

        End If
        lblDiscount.Text = decDiscount
        lblPaid.Text = decNet
        lblCredit.Text = decCredit

        If radCredit.Checked = True Then
            lblDiscount.Text = 0
            lblPaid.Text = decTotal
            lblCredit.Text = decCredit
        End If
    End Sub

   
    
End Class