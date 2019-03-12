<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class miterm
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
        Me.txtW = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtH = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rad19 = New System.Windows.Forms.RadioButton()
        Me.rad90 = New System.Windows.Forms.RadioButton()
        Me.rad75 = New System.Windows.Forms.RadioButton()
        Me.rad67 = New System.Windows.Forms.RadioButton()
        Me.btnCalulat = New System.Windows.Forms.Button()
        Me.lblWater = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtW
        '
        Me.txtW.Location = New System.Drawing.Point(114, 100)
        Me.txtW.Name = "txtW"
        Me.txtW.Size = New System.Drawing.Size(138, 20)
        Me.txtW.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(214, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "โปรแกรมคำนวณการโปรยละองน้ำไล่ฝุ่น PM.25"
        '
        'txtH
        '
        Me.txtH.Location = New System.Drawing.Point(339, 100)
        Me.txtH.Name = "txtH"
        Me.txtH.Size = New System.Drawing.Size(138, 20)
        Me.txtH.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ความกว้าง"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(270, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ความยาว"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.rad19)
        Me.GroupBox1.Controls.Add(Me.rad90)
        Me.GroupBox1.Controls.Add(Me.rad75)
        Me.GroupBox1.Controls.Add(Me.rad67)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(46, 155)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 106)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ชนิดเครื่องบิน"
        '
        'rad19
        '
        Me.rad19.AutoSize = True
        Me.rad19.Location = New System.Drawing.Point(191, 72)
        Me.rad19.Name = "rad19"
        Me.rad19.Size = New System.Drawing.Size(154, 17)
        Me.rad19.TabIndex = 0
        Me.rad19.TabStop = True
        Me.rad19.Text = "BT-19 บรรจุน้ำได้  300 ลิตร"
        Me.rad19.UseVisualStyleBackColor = True
        '
        'rad90
        '
        Me.rad90.AutoSize = True
        Me.rad90.Location = New System.Drawing.Point(18, 72)
        Me.rad90.Name = "rad90"
        Me.rad90.Size = New System.Drawing.Size(154, 17)
        Me.rad90.TabIndex = 0
        Me.rad90.TabStop = True
        Me.rad90.Text = "BT-90 บรรจุน้ำได้  200 ลิตร"
        Me.rad90.UseVisualStyleBackColor = True
        '
        'rad75
        '
        Me.rad75.AutoSize = True
        Me.rad75.Location = New System.Drawing.Point(191, 37)
        Me.rad75.Name = "rad75"
        Me.rad75.Size = New System.Drawing.Size(151, 17)
        Me.rad75.TabIndex = 0
        Me.rad75.TabStop = True
        Me.rad75.Text = "BT-75 บรรจุน้ำได้ 150 ลิตร"
        Me.rad75.UseVisualStyleBackColor = True
        '
        'rad67
        '
        Me.rad67.AutoSize = True
        Me.rad67.Location = New System.Drawing.Point(18, 37)
        Me.rad67.Name = "rad67"
        Me.rad67.Size = New System.Drawing.Size(151, 17)
        Me.rad67.TabIndex = 0
        Me.rad67.TabStop = True
        Me.rad67.Text = "BT-67 บรรจุน้ำได้ 100 ลิตร"
        Me.rad67.UseVisualStyleBackColor = True
        '
        'btnCalulat
        '
        Me.btnCalulat.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCalulat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalulat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCalulat.Location = New System.Drawing.Point(535, 302)
        Me.btnCalulat.Name = "btnCalulat"
        Me.btnCalulat.Size = New System.Drawing.Size(106, 49)
        Me.btnCalulat.TabIndex = 3
        Me.btnCalulat.Text = "คำนวณ"
        Me.btnCalulat.UseVisualStyleBackColor = False
        '
        'lblWater
        '
        Me.lblWater.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblWater.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWater.Location = New System.Drawing.Point(194, 328)
        Me.lblWater.Name = "lblWater"
        Me.lblWater.Size = New System.Drawing.Size(194, 23)
        Me.lblWater.TabIndex = 1
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(455, 192)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(147, 20)
        Me.txtNumber.TabIndex = 2
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTime.Location = New System.Drawing.Point(194, 362)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(194, 23)
        Me.lblTime.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 23)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "ปริมาณน้ำที่ต้องใช้ทั้งหมด"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(477, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 23)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "จำนวนเครื่องบิน"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 362)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 23)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "ชั่วโมงที่ต้องบิน"
        '
        'lblArea
        '
        Me.lblArea.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblArea.Location = New System.Drawing.Point(194, 292)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(194, 23)
        Me.lblArea.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "พื้นที่"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(492, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ตารางกิโลเมตร"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(608, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 23)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "ลำ"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(406, 292)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 23)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "ตารางกิโลเมตร"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(406, 328)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 23)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "ลิตร/ตารางกิโลเมตร"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(406, 362)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 23)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "นาที/ตารางกิโลเมตร"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClear.Location = New System.Drawing.Point(535, 374)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(103, 47)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "เคียร์"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'miterm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 443)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalulat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.lblWater)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.txtH)
        Me.Controls.Add(Me.txtW)
        Me.Name = "miterm"
        Me.Text = "miterm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtW As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtH As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rad19 As System.Windows.Forms.RadioButton
    Friend WithEvents rad90 As System.Windows.Forms.RadioButton
    Friend WithEvents rad75 As System.Windows.Forms.RadioButton
    Friend WithEvents rad67 As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalulat As System.Windows.Forms.Button
    Friend WithEvents lblWater As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
