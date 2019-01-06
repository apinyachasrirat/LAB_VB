<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice8
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
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSaleTotal = New System.Windows.Forms.Label()
        Me.lblCommTotal = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtYourSale = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(105, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "พนักงานขาย,ยอดขาย,คอมมิชชั่น"
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.Location = New System.Drawing.Point(105, 72)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(292, 238)
        Me.lstData.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(446, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ยอดขายรวม"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(446, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ค่าคอมมิชชั่นรวม"
        '
        'lblSaleTotal
        '
        Me.lblSaleTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSaleTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSaleTotal.Location = New System.Drawing.Point(446, 194)
        Me.lblSaleTotal.Name = "lblSaleTotal"
        Me.lblSaleTotal.Size = New System.Drawing.Size(94, 23)
        Me.lblSaleTotal.TabIndex = 2
        '
        'lblCommTotal
        '
        Me.lblCommTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCommTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommTotal.Location = New System.Drawing.Point(446, 264)
        Me.lblCommTotal.Name = "lblCommTotal"
        Me.lblCommTotal.Size = New System.Drawing.Size(94, 23)
        Me.lblCommTotal.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(112, 330)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(129, 20)
        Me.txtName.TabIndex = 0
        '
        'txtYourSale
        '
        Me.txtYourSale.Location = New System.Drawing.Point(247, 330)
        Me.txtYourSale.Name = "txtYourSale"
        Me.txtYourSale.Size = New System.Drawing.Size(67, 20)
        Me.txtYourSale.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Location = New System.Drawing.Point(320, 325)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(59, 29)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'frmPractice8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 419)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtYourSale)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCommTotal)
        Me.Controls.Add(Me.lblSaleTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstData)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPractice8"
        Me.Text = "frmPractice8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstData As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSaleTotal As System.Windows.Forms.Label
    Friend WithEvents lblCommTotal As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtYourSale As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
End Class
