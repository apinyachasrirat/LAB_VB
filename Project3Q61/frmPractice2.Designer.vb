<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPractice2
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
        Me.txtBaht = New System.Windows.Forms.TextBox()
        Me.radUs = New System.Windows.Forms.RadioButton()
        Me.radFrench = New System.Windows.Forms.RadioButton()
        Me.radKorea = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.redUnlock = New System.Windows.Forms.RadioButton()
        Me.redLock = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(216, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณอัตราแลกเปลี่ยน"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "เงินไทย"
        '
        'txtBaht
        '
        Me.txtBaht.Location = New System.Drawing.Point(160, 84)
        Me.txtBaht.Multiline = True
        Me.txtBaht.Name = "txtBaht"
        Me.txtBaht.Size = New System.Drawing.Size(191, 51)
        Me.txtBaht.TabIndex = 1
        '
        'radUs
        '
        Me.radUs.AutoSize = True
        Me.radUs.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.radUs.Location = New System.Drawing.Point(191, 171)
        Me.radUs.Name = "radUs"
        Me.radUs.Size = New System.Drawing.Size(64, 18)
        Me.radUs.TabIndex = 2
        Me.radUs.TabStop = True
        Me.radUs.Text = "US(39)"
        Me.radUs.UseVisualStyleBackColor = True
        '
        'radFrench
        '
        Me.radFrench.AutoSize = True
        Me.radFrench.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.radFrench.Location = New System.Drawing.Point(191, 204)
        Me.radFrench.Name = "radFrench"
        Me.radFrench.Size = New System.Drawing.Size(82, 18)
        Me.radFrench.TabIndex = 2
        Me.radFrench.TabStop = True
        Me.radFrench.Text = "French(37)"
        Me.radFrench.UseVisualStyleBackColor = True
        '
        'radKorea
        '
        Me.radKorea.AutoSize = True
        Me.radKorea.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.radKorea.Location = New System.Drawing.Point(191, 237)
        Me.radKorea.Name = "radKorea"
        Me.radKorea.Size = New System.Drawing.Size(77, 18)
        Me.radKorea.TabIndex = 2
        Me.radKorea.TabStop = True
        Me.radKorea.Text = "Korea(30)"
        Me.radKorea.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "แลกได้"
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblResult.Location = New System.Drawing.Point(160, 312)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(191, 64)
        Me.lblResult.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.redUnlock)
        Me.GroupBox1.Controls.Add(Me.redLock)
        Me.GroupBox1.Location = New System.Drawing.Point(385, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 87)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ควบคุม"
        '
        'redUnlock
        '
        Me.redUnlock.AutoSize = True
        Me.redUnlock.Location = New System.Drawing.Point(42, 57)
        Me.redUnlock.Name = "redUnlock"
        Me.redUnlock.Size = New System.Drawing.Size(59, 17)
        Me.redUnlock.TabIndex = 1
        Me.redUnlock.TabStop = True
        Me.redUnlock.Text = "Unlock"
        Me.redUnlock.UseVisualStyleBackColor = True
        '
        'redLock
        '
        Me.redLock.AutoSize = True
        Me.redLock.Location = New System.Drawing.Point(42, 24)
        Me.redLock.Name = "redLock"
        Me.redLock.Size = New System.Drawing.Size(49, 17)
        Me.redLock.TabIndex = 0
        Me.redLock.TabStop = True
        Me.redLock.Text = "Lock"
        Me.redLock.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(415, 313)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 62)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "ปิด"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmPractice2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 405)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.radKorea)
        Me.Controls.Add(Me.radFrench)
        Me.Controls.Add(Me.radUs)
        Me.Controls.Add(Me.txtBaht)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPractice2"
        Me.Text = "frmPractice2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBaht As System.Windows.Forms.TextBox
    Friend WithEvents radUs As System.Windows.Forms.RadioButton
    Friend WithEvents radFrench As System.Windows.Forms.RadioButton
    Friend WithEvents radKorea As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents redLock As System.Windows.Forms.RadioButton
    Friend WithEvents redUnlock As System.Windows.Forms.RadioButton
End Class
