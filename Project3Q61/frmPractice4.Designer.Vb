﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice4
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblProId = New System.Windows.Forms.Label()
        Me.lblProName = New System.Windows.Forms.Label()
        Me.lblProPrice = New System.Windows.Forms.Label()
        Me.txtProAmount = New System.Windows.Forms.TextBox()
        Me.lblProTotal = New System.Windows.Forms.Label()
        Me.lblProNet = New System.Windows.Forms.Label()
        Me.radProCash = New System.Windows.Forms.RadioButton()
        Me.radProCredit = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(64, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสสินค้า"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(64, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชื่อสินค้า"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(64, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ราคาต่อหน่วย"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(64, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "จำนวน"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(64, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "เป็นเงิน"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(64, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 25)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "การชำระเงิน"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(64, 342)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ยอดชำระ"
        '
        'lblProId
        '
        Me.lblProId.BackColor = System.Drawing.SystemColors.Control
        Me.lblProId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProId.Location = New System.Drawing.Point(188, 60)
        Me.lblProId.Name = "lblProId"
        Me.lblProId.Size = New System.Drawing.Size(184, 25)
        Me.lblProId.TabIndex = 0
        Me.lblProId.Text = "P001"
        '
        'lblProName
        '
        Me.lblProName.BackColor = System.Drawing.SystemColors.Control
        Me.lblProName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProName.Location = New System.Drawing.Point(188, 101)
        Me.lblProName.Name = "lblProName"
        Me.lblProName.Size = New System.Drawing.Size(184, 25)
        Me.lblProName.TabIndex = 0
        Me.lblProName.Text = "Computer"
        '
        'lblProPrice
        '
        Me.lblProPrice.BackColor = System.Drawing.SystemColors.Control
        Me.lblProPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProPrice.Location = New System.Drawing.Point(188, 139)
        Me.lblProPrice.Name = "lblProPrice"
        Me.lblProPrice.Size = New System.Drawing.Size(184, 25)
        Me.lblProPrice.TabIndex = 0
        Me.lblProPrice.Text = "55000"
        Me.lblProPrice.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtProAmount
        '
        Me.txtProAmount.Location = New System.Drawing.Point(187, 178)
        Me.txtProAmount.Name = "txtProAmount"
        Me.txtProAmount.Size = New System.Drawing.Size(184, 20)
        Me.txtProAmount.TabIndex = 1
        '
        'lblProTotal
        '
        Me.lblProTotal.BackColor = System.Drawing.SystemColors.Control
        Me.lblProTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProTotal.Location = New System.Drawing.Point(187, 217)
        Me.lblProTotal.Name = "lblProTotal"
        Me.lblProTotal.Size = New System.Drawing.Size(184, 25)
        Me.lblProTotal.TabIndex = 0
        '
        'lblProNet
        '
        Me.lblProNet.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblProNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProNet.Location = New System.Drawing.Point(188, 327)
        Me.lblProNet.Name = "lblProNet"
        Me.lblProNet.Size = New System.Drawing.Size(184, 53)
        Me.lblProNet.TabIndex = 0
        '
        'radProCash
        '
        Me.radProCash.AutoSize = True
        Me.radProCash.Location = New System.Drawing.Point(190, 276)
        Me.radProCash.Name = "radProCash"
        Me.radProCash.Size = New System.Drawing.Size(56, 17)
        Me.radProCash.TabIndex = 2
        Me.radProCash.TabStop = True
        Me.radProCash.Text = "เงินสด"
        Me.radProCash.UseVisualStyleBackColor = True
        '
        'radProCredit
        '
        Me.radProCredit.AutoSize = True
        Me.radProCredit.Location = New System.Drawing.Point(281, 276)
        Me.radProCredit.Name = "radProCredit"
        Me.radProCredit.Size = New System.Drawing.Size(61, 17)
        Me.radProCredit.TabIndex = 3
        Me.radProCredit.TabStop = True
        Me.radProCredit.Text = "เงินเชื่อ"
        Me.radProCredit.UseVisualStyleBackColor = True
        '
        'frmPractice4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 416)
        Me.Controls.Add(Me.radProCredit)
        Me.Controls.Add(Me.radProCash)
        Me.Controls.Add(Me.txtProAmount)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblProNet)
        Me.Controls.Add(Me.lblProTotal)
        Me.Controls.Add(Me.lblProPrice)
        Me.Controls.Add(Me.lblProName)
        Me.Controls.Add(Me.lblProId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPractice4"
        Me.Text = "frmPractice4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblProId As System.Windows.Forms.Label
    Friend WithEvents lblProName As System.Windows.Forms.Label
    Friend WithEvents lblProPrice As System.Windows.Forms.Label
    Friend WithEvents txtProAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblProTotal As System.Windows.Forms.Label
    Friend WithEvents lblProNet As System.Windows.Forms.Label
    Friend WithEvents radProCash As System.Windows.Forms.RadioButton
    Friend WithEvents radProCredit As System.Windows.Forms.RadioButton
End Class
