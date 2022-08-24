<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.Lbl3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(220, 332)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(130, 60)
        Me.Btn1.TabIndex = 0
        Me.Btn1.Text = "Yes"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Btn2
        '
        Me.Btn2.Location = New System.Drawing.Point(581, 332)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(130, 60)
        Me.Btn2.TabIndex = 1
        Me.Btn2.Text = "No"
        Me.Btn2.UseVisualStyleBackColor = True
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.Location = New System.Drawing.Point(228, 127)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(498, 20)
        Me.Lbl1.TabIndex = 2
        Me.Lbl1.Text = "Before using this application are you above 17 years old to rent a car?"
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl2.Location = New System.Drawing.Point(108, 302)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(308, 20)
        Me.Lbl2.TabIndex = 3
        Me.Lbl2.Text = "Click here to confrim you are 17 and above"
        '
        'Lbl3
        '
        Me.Lbl3.AutoSize = True
        Me.Lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl3.Location = New System.Drawing.Point(483, 302)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(342, 20)
        Me.Lbl3.TabIndex = 4
        Me.Lbl3.Text = "Click here to end application if you are under 17"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 521)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn1 As System.Windows.Forms.Button
    Friend WithEvents Btn2 As System.Windows.Forms.Button
    Friend WithEvents Lbl1 As System.Windows.Forms.Label
    Friend WithEvents Lbl2 As System.Windows.Forms.Label
    Friend WithEvents Lbl3 As System.Windows.Forms.Label

End Class
