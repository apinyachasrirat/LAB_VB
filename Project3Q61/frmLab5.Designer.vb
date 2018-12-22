<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab5
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
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radOther = New System.Windows.Forms.RadioButton()
        Me.radMember = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radCredit = New System.Windows.Forms.RadioButton()
        Me.radPaid = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(165, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณการขาย"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชื่อสินค้า"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ราคาขาย"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "จำนวณซื้อ"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "เป็นเงิน"
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(177, 204)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(186, 22)
        Me.lblTotal.TabIndex = 0
        '
        'txtProduct
        '
        Me.txtProduct.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtProduct.Location = New System.Drawing.Point(178, 92)
        Me.txtProduct.Multiline = True
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(185, 21)
        Me.txtProduct.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtPrice.Location = New System.Drawing.Point(178, 129)
        Me.txtPrice.Multiline = True
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(185, 21)
        Me.txtPrice.TabIndex = 1
        '
        'txtUnit
        '
        Me.txtUnit.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtUnit.Location = New System.Drawing.Point(178, 167)
        Me.txtUnit.Multiline = True
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(185, 21)
        Me.txtUnit.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radOther)
        Me.GroupBox1.Controls.Add(Me.radMember)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 258)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(193, 45)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ประเภทลูกค้า"
        '
        'radOther
        '
        Me.radOther.AutoSize = True
        Me.radOther.Location = New System.Drawing.Point(87, 19)
        Me.radOther.Name = "radOther"
        Me.radOther.Size = New System.Drawing.Size(76, 17)
        Me.radOther.TabIndex = 1
        Me.radOther.TabStop = True
        Me.radOther.Text = "ลูกค้าทั่วไป"
        Me.radOther.UseVisualStyleBackColor = True
        '
        'radMember
        '
        Me.radMember.AutoSize = True
        Me.radMember.Location = New System.Drawing.Point(12, 19)
        Me.radMember.Name = "radMember"
        Me.radMember.Size = New System.Drawing.Size(57, 17)
        Me.radMember.TabIndex = 0
        Me.radMember.TabStop = True
        Me.radMember.Text = "สมาชิก"
        Me.radMember.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radCredit)
        Me.GroupBox2.Controls.Add(Me.radPaid)
        Me.GroupBox2.Location = New System.Drawing.Point(275, 258)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(193, 45)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "การชำระเงิน"
        '
        'radCredit
        '
        Me.radCredit.AutoSize = True
        Me.radCredit.Location = New System.Drawing.Point(95, 20)
        Me.radCredit.Name = "radCredit"
        Me.radCredit.Size = New System.Drawing.Size(43, 17)
        Me.radCredit.TabIndex = 1
        Me.radCredit.TabStop = True
        Me.radCredit.Text = "เชื่อ"
        Me.radCredit.UseVisualStyleBackColor = True
        '
        'radPaid
        '
        Me.radPaid.AutoSize = True
        Me.radPaid.Location = New System.Drawing.Point(21, 19)
        Me.radPaid.Name = "radPaid"
        Me.radPaid.Size = New System.Drawing.Size(38, 17)
        Me.radPaid.TabIndex = 0
        Me.radPaid.TabStop = True
        Me.radPaid.Text = "สด"
        Me.radPaid.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(53, 326)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ส่วนลด"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(53, 365)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 22)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "จำนวนเงินต้องชำระ"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(53, 406)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 22)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ยอดค้างชำระ"
        '
        'lblDiscount
        '
        Me.lblDiscount.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDiscount.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(177, 326)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(186, 22)
        Me.lblDiscount.TabIndex = 0
        '
        'lblPaid
        '
        Me.lblPaid.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPaid.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPaid.Location = New System.Drawing.Point(177, 364)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(186, 22)
        Me.lblPaid.TabIndex = 0
        '
        'lblCredit
        '
        Me.lblCredit.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblCredit.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCredit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCredit.Location = New System.Drawing.Point(177, 405)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(186, 22)
        Me.lblCredit.TabIndex = 0
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(194, 454)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(111, 41)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "คำนวณ"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmLab5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 533)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.lblPaid)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab5"
        Me.Text = "frmLab5"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtProduct As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radOther As System.Windows.Forms.RadioButton
    Friend WithEvents radMember As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radCredit As System.Windows.Forms.RadioButton
    Friend WithEvents radPaid As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblPaid As System.Windows.Forms.Label
    Friend WithEvents lblCredit As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
End Class
