﻿Public Class frmlab1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lblYearSalary.Text = Val(txtSalary.Text) * 12
    End Sub
End Class
