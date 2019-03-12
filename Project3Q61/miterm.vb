Public Class miterm
    Dim Number, Time, Area As Double
    Dim N, T, Water As Integer
    Private Sub btnCalulat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalulat.Click
        If Not IsNumeric(txtNumber.Text) Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง")
            txtW.Clear()
            txtH.Clear()
            txtNumber.Clear()
            rad67.Checked = False
            rad75.Checked = False
            rad90.Checked = False
            rad19.Checked = False
            lblArea.Text = ""
            lblWater.Text = ""
            lblTime.Text = ""
        End If

        If rad67.Checked = True Then
            T = 50


        End If
        If rad75.Checked = True Then
            T = 40

        End If
        If rad90.Checked = True Then
            T = 30

        End If
        If rad19.Checked = True Then
            T = 20

        End If
        Number = Val(txtW.Text) * Val(txtH.Text)
        N = Val(txtNumber.Text)
        Area = Val(lblArea.Text)
        Time = ((Area * T) / N) / 60
        Water = Number * 20

        lblArea.Text = Number
        lblWater.Text = Water
        lblTime.Text = Time
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtW.Clear()
        txtH.Clear()
        txtNumber.Clear()
        rad67.Checked = False
        rad75.Checked = False
        rad90.Checked = False
        rad19.Checked = False
        lblArea.Text = ""
        lblWater.Text = ""
        lblTime.Text = ""
    End Sub
End Class