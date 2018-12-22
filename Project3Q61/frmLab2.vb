Public Class frmLab2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim vista, frista, sum As Decimal
      

        vista = Val(txtVista.Text) * 5 / 100
        frista = Val(txtFrist.Text) * 10 / 100
        sum = Val(txtVista.Text) + Val(txtFrist.Text)
        

        lblSaLe.Text = sum
        lblVista.Text = vista
        lblFrist.Text = frista
        lblCommis.Text = vista + frista

    End Sub
End Class