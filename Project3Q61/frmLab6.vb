Public Class frmLab6
    Dim Price As Double
    Dim message As DialogResult

    Private Sub chkCarForMe_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCarForMe.CheckedChanged

        If chkCarForMe.Checked = False Then
            message = MessageBox.Show("คุณต้องการยกเลิกการซื้อรถใช่หรือไม่", "****คำเตือน****", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If message = Windows.Forms.DialogResult.Yes Then
                lblPaidPrice.Text = ""
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
            Else
                chkCarForMe.Checked = True
                GroupBox1.Enabled = True
                GroupBox2.Enabled = True
            End If
        Else
            Price = Val(lblSartPrice.Text)
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            lblPaidPrice.Text = Price + 25000 + 15000 + 35000
            Exit Sub
        End If

    End Sub

    Private Sub chkItemsAdd1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd1.CheckedChanged
        If chkItemsAdd1.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + 40000
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - 40000
        End If

    End Sub

    Private Sub chkItemsAdd2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd2.CheckedChanged

        If chkItemsAdd2.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + 50000
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - 50000
        End If
    End Sub

    Private Sub chkItemsAdd3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd3.CheckedChanged
       
        If chkItemsAdd3.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + 20000
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - 20000
        End If
    End Sub

    Private Sub chkItemsAdd4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd4.CheckedChanged
        If chkItemsAdd4.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + 30000
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - 30000
        End If
    End Sub

    Private Sub chkFree1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree1.CheckedChanged
        If chkFree1.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - 25000
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + 25000
        End If
    End Sub

    Private Sub chkFree2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree2.CheckedChanged
        If chkFree2.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - 15000
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + 15000
        End If
    End Sub

    Private Sub chkFree3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree3.CheckedChanged
        If chkFree3.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - 35000
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + 35000
        End If
    End Sub

    Private Sub frmLab6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblPaidPrice.Text = ""
    End Sub
End Class