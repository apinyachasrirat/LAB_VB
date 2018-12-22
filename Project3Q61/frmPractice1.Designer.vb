<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice1
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
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtFristName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อ"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "นามสกุล"
        '
        'lblFullName
        '
        Me.lblFullName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblFullName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblFullName.Location = New System.Drawing.Point(150, 218)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(171, 32)
        Me.lblFullName.TabIndex = 0
        '
        'txtFristName
        '
        Me.txtFristName.Location = New System.Drawing.Point(149, 59)
        Me.txtFristName.Name = "txtFristName"
        Me.txtFristName.Size = New System.Drawing.Size(171, 20)
        Me.txtFristName.TabIndex = 1
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(149, 103)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(171, 20)
        Me.txtLastName.TabIndex = 1
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(184, 158)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(87, 27)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "แสดงชื่อ"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'frmPractice1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 285)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFristName)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPractice1"
        Me.Text = "Practice1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents txtFristName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
End Class
