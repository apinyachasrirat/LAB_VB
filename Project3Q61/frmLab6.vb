Public Class frmLab6
    Dim Price As Double
    Dim Message As DialogResult

    Private Sub chkCarForMe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCarForMe.Click
        Dim Free1, Free2, Free3 As Integer
        Free1 = lblFree1.Text
        Free2 = lblFree2.Text
        Free3 = lblFree3.Text
        If chkCarForMe.Checked = False Then
            Message = MessageBox.Show("คุณต้องการยกเลิกการซื้อรถหรือไม่", "***เตือน***", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
            If Message = Windows.Forms.DialogResult.Yes Then
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
                chkItemsAdd1.Checked = False
                chkItemsAdd2.Checked = False

                chkItemsAdd3.Checked = False
                chkItemsAdd4.Checked = False
                chkFree1.Checked = False
                chkFree2.Checked = False
                chkFree3.Checked = False
                lblPaidPrice.Text = ""

            Else
                chkCarForMe.Checked = True
                GroupBox1.Enabled = True
                GroupBox2.Enabled = True
            End If
        Else
            Price = Val(lblSartPrice.Text)
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            lblPaidPrice.Text = Price + Free1 + Free2 + Free3
            Exit Sub
        End If

    End Sub

    Private Sub chkItemsAdd1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd1.CheckedChanged
        Dim ItemsPrice1 As Integer
        ItemsPrice1 = lblItemsPrice1.Text
        If chkItemsAdd1.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + ItemsPrice1
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - ItemsPrice1
        End If

    End Sub

    Private Sub chkItemsAdd2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd2.CheckedChanged
        Dim ItemsPrice2 As Integer
        ItemsPrice2 = lblItemsPrice2.Text
        If chkItemsAdd2.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + ItemsPrice2
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - ItemsPrice2
        End If
    End Sub

    Private Sub chkItemsAdd3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd3.CheckedChanged
        Dim ItemsPrice3 As Integer
        ItemsPrice3 = lblItemsPrice3.Text
        If chkItemsAdd3.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + ItemsPrice3
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - ItemsPrice3
        End If
    End Sub

    Private Sub chkItemsAdd4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd4.CheckedChanged
        Dim ItemsPrice4 As Integer
        ItemsPrice4 = lblItemsPrice4.Text
        If chkItemsAdd4.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + ItemsPrice4
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - ItemsPrice4
        End If
    End Sub

    Private Sub chkFree1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree1.CheckedChanged
        Dim ItemsFree1 As Integer
        ItemsFree1 = lblFree1.Text
        If chkFree1.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - ItemsFree1
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + ItemsFree1
        End If
    End Sub

    Private Sub chkFree2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree2.CheckedChanged
        Dim ItemsFree2 As Integer
        ItemsFree2 = lblFree2.Text
        If chkFree2.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - ItemsFree2
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + ItemsFree2
        End If
    End Sub

    Private Sub chkFree3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree3.CheckedChanged
        Dim ItemsFree3 As Integer
        ItemsFree3 = lblFree3.Text
        If chkFree3.Checked = True Then
            lblPaidPrice.Text = Val(lblPaidPrice.Text) - ItemsFree3
        Else
            lblPaidPrice.Text = Val(lblPaidPrice.Text) + ItemsFree3
        End If
    End Sub

    Private Sub frmLab6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblPaidPrice.Text = ""
    End Sub

End Class