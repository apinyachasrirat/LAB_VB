Public Class frmLab8
    Dim sumScore, sumCredit As Integer
    Private Sub getNewGPA(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblOldTotalScore.Text = "150"
        lblOldTotalCredit.Text = "50"
        lblOldGPA.Text = "3.00"
    End Sub

    Private Sub btnClaer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClaer.Click
        lstSubject.Items.Clear()
        lstScore.Items.Clear()
        lstCredit.Items.Clear()
        lstGrade.Items.Clear()
        txtCredit.Clear()
        txtScore.Clear()
        txtSubject.Clear()
        lblNewGPA.Text = ""
        Call getNewGPA(e, sender)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim Grade As String
        If txtSubject.Text.Trim() = "" Or txtScore.Text.Trim() = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "Error...", MessageBoxButtons.OK)
            txtSubject.Focus()
            Exit Sub
        Else
            lstSubject.Items.Add(txtSubject.Text.Trim())
            lstCredit.Items.Add(txtCredit.Text.Trim())
            Grade = getNewGrade(CDec(txtScore.Text.Trim()))
            lstScore.Items.Add(txtScore.Text.Trim())
            lstGrade.Items.Add(Grade)
            txtScore.Clear()
            txtCredit.Clear()
            txtSubject.Clear()
            txtSubject.Focus()
        End If
        lstSubject.SelectedIndex = lstSubject.Items.Count - 1
        Call callNewData()

    End Sub
    Private Function getNewGrade(ByVal score As Decimal) As String

        Dim Grade As String
        If score < 50 Then
            Grade = "F"
        ElseIf score < 55 Then
            Grade = "D"
        ElseIf score < 60 Then
            Grade = "D+"
        ElseIf score < 65 Then
            Grade = "C"
        ElseIf score < 70 Then
            Grade = "C+"
        ElseIf score < 75 Then
            Grade = "B"
        ElseIf score < 80 Then
            Grade = "B+"
        Else
            Grade = "A"
        End If
        Return Grade
    End Function

    Private Sub lstSubject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSubject.SelectedIndexChanged
        lstCredit.SelectedIndex = lstSubject.SelectedIndex
        lstScore.SelectedIndex = lstSubject.SelectedIndex
        lstGrade.SelectedIndex = lstSubject.SelectedIndex
    End Sub

    Private Sub lstScore_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstScore.SelectedIndexChanged
        lstSubject.SelectedIndex = lstScore.SelectedIndex
    End Sub

    Private Sub lstCredit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCredit.SelectedIndexChanged
        lstSubject.SelectedIndex = lstCredit.SelectedIndex
    End Sub

    Private Sub lstGrade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstGrade.SelectedIndexChanged
        lstSubject.SelectedIndex = lstGrade.SelectedIndex
    End Sub
    Private Sub callNewData()
        Dim Number As Integer = 0
        Dim NewGrade, Credit, Score As Decimal
        Do Until Number > lstGrade.Items.Count - 1
            Select Case lstGrade.Items(Number)
                Case "F" : Score = 0
                Case "D" : Score = 1
                Case "D+" : Score = 1.5
                Case "C" : Score = 2
                Case "C+" : Score = 2.5
                Case "B" : Score = 3
                Case "B+" : Score = 3.5
                Case "A" : Score = 4
            End Select
            NewGrade += Score * lstCredit.Items(Number)
            Credit += lstCredit.Items(Number)
            Number += 1

        Loop
        sumScore = 150 + NewGrade
        sumCredit = 50 + Credit
        lblNewGPA.Text = FormatNumber(sumScore / sumCredit, 2)
    End Sub

    Private Sub txtScore_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtScore.KeyPress
        Dim keyint As Integer = Asc(e.KeyChar)
        If (keyint >= 48 And keyint <= 57) Or keyint = 46 Or keyint = 8 Then
            Exit Sub
        Else
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtCredit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCredit.KeyPress
        Dim keyint As Integer = Asc(e.KeyChar)
        If (keyint >= 48 And keyint <= 57) Or keyint = 46 Or keyint = 8 Then
            Exit Sub
        Else
            e.KeyChar = Nothing
        End If
    End Sub
End Class



