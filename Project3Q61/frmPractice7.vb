Public Class frmPractice7

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtAdd.Text.Trim() = "" Then
            MessageBox.Show("กรุณาป้อนข้อมูล")
        ElseIf Not IsNumeric(txtAdd.Text) Then
            MessageBox.Show("กรุณาป้อนตัวเลข")
        Else
            lstNumber.Items.Add(txtAdd.Text)
            Call cal_sys()

        End If
        txtAdd.Clear()
        txtAdd.Focus()

    End Sub

    Private Sub cal_sys()
        Dim i, Total, Max, Min, Average As Single
        Max = lstNumber.Items(0)
        Min = lstNumber.Items(0)
        For i = 0 To lstNumber.Items.Count - 1
            Total += Val(lstNumber.Items(i))

            If Max < Val(lstNumber.Items(i)) Then
                Max = Val(lstNumber.Items(i))
            End If
            If Min > Val(lstNumber.Items(i)) Then
                Min = Val(lstNumber.Items(i))
            End If

        Next i
        Average = Total / lstNumber.Items.Count
        lblTotal.Text = Total
        lblMax.Text = Max
        lblMin.Text = Min
        lblAverage.Text = FormatNumber(Average)


    End Sub
End Class

