<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invoice
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
        Me.LBLQuote = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblWidth = New System.Windows.Forms.Label()
        Me.TBOutWidth = New System.Windows.Forms.TextBox()
        Me.TBOutLength = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBOutArea = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TBOutRollsCost = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBOutCostWO = New System.Windows.Forms.TextBox()
        Me.TBOutTotalCost = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBOutRollsWO = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBOutRolls = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BTNClose = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLQuote
        '
        Me.LBLQuote.AutoSize = True
        Me.LBLQuote.Font = New System.Drawing.Font("Microsoft YaHei", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLQuote.Location = New System.Drawing.Point(110, 9)
        Me.LBLQuote.Name = "LBLQuote"
        Me.LBLQuote.Size = New System.Drawing.Size(63, 24)
        Me.LBLQuote.TabIndex = 0
        Me.LBLQuote.Text = "Quote"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.Location = New System.Drawing.Point(91, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 2)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LblWidth
        '
        Me.LblWidth.AutoSize = True
        Me.LblWidth.Location = New System.Drawing.Point(47, 44)
        Me.LblWidth.Name = "LblWidth"
        Me.LblWidth.Size = New System.Drawing.Size(177, 13)
        Me.LblWidth.TabIndex = 5
        Me.LblWidth.Text = "Width of Lawn                               m"
        '
        'TBOutWidth
        '
        Me.TBOutWidth.Location = New System.Drawing.Point(163, 41)
        Me.TBOutWidth.MaxLength = 6
        Me.TBOutWidth.Name = "TBOutWidth"
        Me.TBOutWidth.ReadOnly = True
        Me.TBOutWidth.Size = New System.Drawing.Size(43, 20)
        Me.TBOutWidth.TabIndex = 7
        Me.TBOutWidth.Text = "999999"
        '
        'TBOutLength
        '
        Me.TBOutLength.Location = New System.Drawing.Point(164, 71)
        Me.TBOutLength.MaxLength = 6
        Me.TBOutLength.Name = "TBOutLength"
        Me.TBOutLength.ReadOnly = True
        Me.TBOutLength.Size = New System.Drawing.Size(43, 20)
        Me.TBOutLength.TabIndex = 9
        Me.TBOutLength.Text = "999999"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Length of Lawn                               m"
        '
        'TBOutArea
        '
        Me.TBOutArea.Location = New System.Drawing.Point(153, 102)
        Me.TBOutArea.MaxLength = 6
        Me.TBOutArea.Name = "TBOutArea"
        Me.TBOutArea.ReadOnly = True
        Me.TBOutArea.Size = New System.Drawing.Size(83, 20)
        Me.TBOutArea.TabIndex = 11
        Me.TBOutArea.Text = "999999"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Total Area of Lawn                                          m"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox2.Location = New System.Drawing.Point(12, 128)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(250, 2)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'TBOutRollsCost
        '
        Me.TBOutRollsCost.Location = New System.Drawing.Point(193, 136)
        Me.TBOutRollsCost.MaxLength = 6
        Me.TBOutRollsCost.Name = "TBOutRollsCost"
        Me.TBOutRollsCost.ReadOnly = True
        Me.TBOutRollsCost.Size = New System.Drawing.Size(43, 20)
        Me.TBOutRollsCost.TabIndex = 14
        Me.TBOutRollsCost.Text = "999999"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Cost per Roll of 0.6m x 1m Turf: £"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox3.Location = New System.Drawing.Point(12, 219)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(250, 2)
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(228, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Total Cost without 10% Allowance for Wastage"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TBOutCostWO
        '
        Me.TBOutCostWO.Location = New System.Drawing.Point(87, 237)
        Me.TBOutCostWO.MaxLength = 6
        Me.TBOutCostWO.Name = "TBOutCostWO"
        Me.TBOutCostWO.ReadOnly = True
        Me.TBOutCostWO.Size = New System.Drawing.Size(120, 20)
        Me.TBOutCostWO.TabIndex = 17
        Me.TBOutCostWO.Text = "999999"
        '
        'TBOutTotalCost
        '
        Me.TBOutTotalCost.Location = New System.Drawing.Point(87, 276)
        Me.TBOutTotalCost.MaxLength = 6
        Me.TBOutTotalCost.Name = "TBOutTotalCost"
        Me.TBOutTotalCost.ReadOnly = True
        Me.TBOutTotalCost.Size = New System.Drawing.Size(120, 20)
        Me.TBOutTotalCost.TabIndex = 19
        Me.TBOutTotalCost.Text = "999999"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Total Cost with 10% Allowance for Wastage"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TBOutRollsWO
        '
        Me.TBOutRollsWO.Location = New System.Drawing.Point(174, 167)
        Me.TBOutRollsWO.MaxLength = 6
        Me.TBOutRollsWO.Name = "TBOutRollsWO"
        Me.TBOutRollsWO.ReadOnly = True
        Me.TBOutRollsWO.Size = New System.Drawing.Size(90, 20)
        Me.TBOutRollsWO.TabIndex = 21
        Me.TBOutRollsWO.Text = "999999"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Total Number of Rolls Required"
        '
        'TBOutRolls
        '
        Me.TBOutRolls.Location = New System.Drawing.Point(174, 193)
        Me.TBOutRolls.MaxLength = 6
        Me.TBOutRolls.Name = "TBOutRolls"
        Me.TBOutRolls.ReadOnly = True
        Me.TBOutRolls.Size = New System.Drawing.Size(90, 20)
        Me.TBOutRolls.TabIndex = 23
        Me.TBOutRolls.Text = "999999"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "+10% Allowance for Wastage"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(74, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "£"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(74, 279)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "£"
        '
        'BTNClose
        '
        Me.BTNClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTNClose.Location = New System.Drawing.Point(104, 302)
        Me.BTNClose.Name = "BTNClose"
        Me.BTNClose.Size = New System.Drawing.Size(75, 23)
        Me.BTNClose.TabIndex = 26
        Me.BTNClose.Text = "Close"
        Me.BTNClose.UseVisualStyleBackColor = True
        '
        'Invoice
        '
        Me.AcceptButton = Me.BTNClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BTNClose
        Me.ClientSize = New System.Drawing.Size(276, 336)
        Me.Controls.Add(Me.BTNClose)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TBOutRolls)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TBOutRollsWO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TBOutTotalCost)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBOutCostWO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.TBOutRollsCost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TBOutArea)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBOutLength)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBOutWidth)
        Me.Controls.Add(Me.LblWidth)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LBLQuote)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(292, 375)
        Me.MinimumSize = New System.Drawing.Size(292, 375)
        Me.Name = "Invoice"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLQuote As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblWidth As Label
    Friend WithEvents TBOutWidth As TextBox
    Friend WithEvents TBOutLength As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBOutArea As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TBOutRollsCost As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBOutCostWO As TextBox
    Friend WithEvents TBOutTotalCost As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBOutRollsWO As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBOutRolls As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BTNClose As Button
End Class
