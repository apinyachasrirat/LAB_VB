<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice5
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
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(80, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ราคาสินค้า"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(80, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "จำนวน"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(80, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "เป็นเงิน"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(80, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ส่วนลด"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(80, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ราคาสิทธิ"
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTotal.BackColor = System.Drawing.SystemColors.Control
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(197, 129)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(152, 29)
        Me.lblTotal.TabIndex = 0
        '
        'lblDiscount
        '
        Me.lblDiscount.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDiscount.BackColor = System.Drawing.SystemColors.Control
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscount.Location = New System.Drawing.Point(196, 174)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(153, 29)
        Me.lblDiscount.TabIndex = 0
        '
        'lblNet
        '
        Me.lblNet.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblNet.BackColor = System.Drawing.SystemColors.Control
        Me.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNet.Location = New System.Drawing.Point(196, 216)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(153, 29)
        Me.lblNet.TabIndex = 0
        '
        'txtPrice
        '
        Me.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtPrice.Location = New System.Drawing.Point(196, 55)
        Me.txtPrice.Multiline = True
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(153, 30)
        Me.txtPrice.TabIndex = 0
        '
        'txtUnit
        '
        Me.txtUnit.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtUnit.Location = New System.Drawing.Point(196, 91)
        Me.txtUnit.Multiline = True
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(153, 30)
        Me.txtUnit.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(192, 295)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(157, 52)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "คำนวณ"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmPractice5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 405)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPractice5"
        Me.Text = "คำนวณ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblNet As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
End Class
