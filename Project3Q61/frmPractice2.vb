Public Class frmPractice2

    Private Sub radUs_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radUs.CheckedChanged
        lblResult.Text = Val(txtBaht.Text) / 39
    End Sub

    Private Sub radFrench_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radFrench.CheckedChanged
        lblResult.Text = Val(txtBaht.Text) / 37
    End Sub

    Private Sub radKorea_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radKorea.CheckedChanged
        lblResult.Text = Val(txtBaht.Text) / 30
    End Sub

    Private Sub redLock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles redLock.CheckedChanged
        txtBaht.Enabled = False
        radUs.Enabled = False
        radFrench.Enabled = False
        radKorea.Enabled = False
    End Sub

    Private Sub redUnlock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles redUnlock.CheckedChanged
        txtBaht.Enabled = True
        radUs.Enabled = True
        radFrench.Enabled = True
        radKorea.Enabled = True
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class