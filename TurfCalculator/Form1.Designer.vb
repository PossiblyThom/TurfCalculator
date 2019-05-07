<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBInLength = New System.Windows.Forms.TextBox()
        Me.TBInWidth = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button
        '
        Me.Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button.Location = New System.Drawing.Point(70, 79)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(75, 23)
        Me.Button.TabIndex = 0
        Me.Button.Text = "Calculate"
        Me.Button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Length of area to cover:                 m"
        '
        'TBInLength
        '
        Me.TBInLength.Location = New System.Drawing.Point(145, 18)
        Me.TBInLength.MaxLength = 6
        Me.TBInLength.Name = "TBInLength"
        Me.TBInLength.Size = New System.Drawing.Size(43, 20)
        Me.TBInLength.TabIndex = 2
        '
        'TBInWidth
        '
        Me.TBInWidth.Location = New System.Drawing.Point(145, 53)
        Me.TBInWidth.MaxLength = 6
        Me.TBInWidth.Name = "TBInWidth"
        Me.TBInWidth.Size = New System.Drawing.Size(43, 20)
        Me.TBInWidth.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Width of area to cover:                   m"
        '
        'Form1
        '
        Me.AcceptButton = Me.Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 123)
        Me.Controls.Add(Me.TBInWidth)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBInLength)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(238, 162)
        Me.MinimumSize = New System.Drawing.Size(238, 162)
        Me.Name = "Form1"
        Me.Text = "Turf Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TBInLength As TextBox
    Friend WithEvents TBInWidth As TextBox
    Friend WithEvents Label2 As Label
End Class
