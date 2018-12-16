Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim vista, frista, sum As Decimal
        vista = Val(TextBox1.Text) * 5 / 100
        frista = Val(TextBox2.Text) * 10 / 100
        sum = Val(TextBox1.Text) + Val(TextBox2.Text)
        Label5.Text = sum
        Label6.Text = vista + frista
    End Sub
End Class