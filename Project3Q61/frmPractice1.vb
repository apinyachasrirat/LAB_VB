Public Class frmPractice1

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        lblFullName.Text = txtFristName.Text & " " & txtLastName.Text
    End Sub
End Class