<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.txtLabScore = New System.Windows.Forms.TextBox()
        Me.txtMidterm = New System.Windows.Forms.TextBox()
        Me.txtFinal = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSumScore = New System.Windows.Forms.Label()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(164, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณผลการเรียน"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(39, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชื่อนักศึกษา"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(39, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "คะแนนเก็บ(40)"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(39, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "คะแนนกลางภาค(30)"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(39, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "คะแนนปลายภาค(30)"
        '
        'txtStudentName
        '
        Me.txtStudentName.Location = New System.Drawing.Point(178, 103)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(174, 20)
        Me.txtStudentName.TabIndex = 0
        '
        'txtLabScore
        '
        Me.txtLabScore.Location = New System.Drawing.Point(178, 151)
        Me.txtLabScore.Name = "txtLabScore"
        Me.txtLabScore.Size = New System.Drawing.Size(145, 20)
        Me.txtLabScore.TabIndex = 1
        '
        'txtMidterm
        '
        Me.txtMidterm.Location = New System.Drawing.Point(178, 197)
        Me.txtMidterm.Name = "txtMidterm"
        Me.txtMidterm.Size = New System.Drawing.Size(145, 20)
        Me.txtMidterm.TabIndex = 2
        '
        'txtFinal
        '
        Me.txtFinal.Location = New System.Drawing.Point(178, 235)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(145, 20)
        Me.txtFinal.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(44, 304)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(95, 77)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "คำนวณเกรด"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(175, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "คะแนนรวม(100)"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(175, 358)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "เกรดที่ได้"
        '
        'lblSumScore
        '
        Me.lblSumScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSumScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSumScore.Location = New System.Drawing.Point(294, 304)
        Me.lblSumScore.Name = "lblSumScore"
        Me.lblSumScore.Size = New System.Drawing.Size(158, 23)
        Me.lblSumScore.TabIndex = 0
        '
        'lblGrade
        '
        Me.lblGrade.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrade.Location = New System.Drawing.Point(294, 357)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(158, 23)
        Me.lblGrade.TabIndex = 0
        '
        'frmPractice6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 427)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtFinal)
        Me.Controls.Add(Me.txtMidterm)
        Me.Controls.Add(Me.txtLabScore)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.lblSumScore)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPractice6"
        Me.Text = "frmPractice6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtStudentName As System.Windows.Forms.TextBox
    Friend WithEvents txtLabScore As System.Windows.Forms.TextBox
    Friend WithEvents txtMidterm As System.Windows.Forms.TextBox
    Friend WithEvents txtFinal As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblSumScore As System.Windows.Forms.Label
    Friend WithEvents lblGrade As System.Windows.Forms.Label
End Class
