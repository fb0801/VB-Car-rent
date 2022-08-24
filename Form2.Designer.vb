<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Lbl4 = New System.Windows.Forms.Label()
        Me.firstname = New System.Windows.Forms.TextBox()
        Me.Lbl5 = New System.Windows.Forms.Label()
        Me.lastname = New System.Windows.Forms.TextBox()
        Me.Lbl7 = New System.Windows.Forms.Label()
        Me.Cbo4Age = New System.Windows.Forms.ComboBox()
        Me.Lbl8 = New System.Windows.Forms.Label()
        Me.Cbo5gender = New System.Windows.Forms.ComboBox()
        Me.Lbl10 = New System.Windows.Forms.Label()
        Me.Txtbox3email = New System.Windows.Forms.TextBox()
        Me.Lbl9 = New System.Windows.Forms.Label()
        Me.Txtbox4mobilenumber = New System.Windows.Forms.TextBox()
        Me.Lbl11 = New System.Windows.Forms.Label()
        Me.Txtbox5location = New System.Windows.Forms.TextBox()
        Me.Lbl13 = New System.Windows.Forms.Label()
        Me.Cbocartype = New System.Windows.Forms.ComboBox()
        Me.Lbl6 = New System.Windows.Forms.Label()
        Me.Cbo1day = New System.Windows.Forms.ComboBox()
        Me.Cbo2month = New System.Windows.Forms.ComboBox()
        Me.Cbo3year = New System.Windows.Forms.ComboBox()
        Me.Lbl12 = New System.Windows.Forms.Label()
        Me.Txtbox6country = New System.Windows.Forms.TextBox()
        Me.Lblday = New System.Windows.Forms.Label()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.LblMonth = New System.Windows.Forms.Label()
        Me.Lblweek = New System.Windows.Forms.Label()
        Me.lbltotalcost = New System.Windows.Forms.Label()
        Me.Lbldisplaycost = New System.Windows.Forms.Label()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.Chkday = New System.Windows.Forms.CheckBox()
        Me.Chkweek = New System.Windows.Forms.CheckBox()
        Me.Chkmonth = New System.Windows.Forms.CheckBox()
        Me.Btnsubmit = New System.Windows.Forms.Button()
        Me.Btnnext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl4
        '
        Me.Lbl4.AutoSize = True
        Me.Lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl4.Location = New System.Drawing.Point(207, 32)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(81, 18)
        Me.Lbl4.TabIndex = 0
        Me.Lbl4.Text = "First Name"
        '
        'firstname
        '
        Me.firstname.Location = New System.Drawing.Point(305, 29)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(258, 20)
        Me.firstname.TabIndex = 1
        '
        'Lbl5
        '
        Me.Lbl5.AutoSize = True
        Me.Lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl5.Location = New System.Drawing.Point(207, 67)
        Me.Lbl5.Name = "Lbl5"
        Me.Lbl5.Size = New System.Drawing.Size(80, 18)
        Me.Lbl5.TabIndex = 2
        Me.Lbl5.Text = "Last Name"
        '
        'lastname
        '
        Me.lastname.Location = New System.Drawing.Point(305, 68)
        Me.lastname.Name = "lastname"
        Me.lastname.Size = New System.Drawing.Size(258, 20)
        Me.lastname.TabIndex = 3
        '
        'Lbl7
        '
        Me.Lbl7.AutoSize = True
        Me.Lbl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl7.Location = New System.Drawing.Point(207, 140)
        Me.Lbl7.Name = "Lbl7"
        Me.Lbl7.Size = New System.Drawing.Size(33, 18)
        Me.Lbl7.TabIndex = 4
        Me.Lbl7.Text = "Age"
        '
        'Cbo4Age
        '
        Me.Cbo4Age.FormattingEnabled = True
        Me.Cbo4Age.Items.AddRange(New Object() {"17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45"})
        Me.Cbo4Age.Location = New System.Drawing.Point(305, 141)
        Me.Cbo4Age.Name = "Cbo4Age"
        Me.Cbo4Age.Size = New System.Drawing.Size(82, 21)
        Me.Cbo4Age.TabIndex = 5
        '
        'Lbl8
        '
        Me.Lbl8.AutoSize = True
        Me.Lbl8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl8.Location = New System.Drawing.Point(207, 186)
        Me.Lbl8.Name = "Lbl8"
        Me.Lbl8.Size = New System.Drawing.Size(57, 18)
        Me.Lbl8.TabIndex = 6
        Me.Lbl8.Text = "Gender"
        '
        'Cbo5gender
        '
        Me.Cbo5gender.FormattingEnabled = True
        Me.Cbo5gender.Items.AddRange(New Object() {"Male ", "Female"})
        Me.Cbo5gender.Location = New System.Drawing.Point(305, 183)
        Me.Cbo5gender.Name = "Cbo5gender"
        Me.Cbo5gender.Size = New System.Drawing.Size(82, 21)
        Me.Cbo5gender.TabIndex = 7
        '
        'Lbl10
        '
        Me.Lbl10.AutoSize = True
        Me.Lbl10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl10.Location = New System.Drawing.Point(181, 258)
        Me.Lbl10.Name = "Lbl10"
        Me.Lbl10.Size = New System.Drawing.Size(106, 18)
        Me.Lbl10.TabIndex = 8
        Me.Lbl10.Text = "Mobile number"
        '
        'Txtbox3email
        '
        Me.Txtbox3email.Location = New System.Drawing.Point(305, 222)
        Me.Txtbox3email.Name = "Txtbox3email"
        Me.Txtbox3email.Size = New System.Drawing.Size(258, 20)
        Me.Txtbox3email.TabIndex = 9
        '
        'Lbl9
        '
        Me.Lbl9.AutoSize = True
        Me.Lbl9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl9.Location = New System.Drawing.Point(207, 224)
        Me.Lbl9.Name = "Lbl9"
        Me.Lbl9.Size = New System.Drawing.Size(45, 18)
        Me.Lbl9.TabIndex = 10
        Me.Lbl9.Text = "Email"
        '
        'Txtbox4mobilenumber
        '
        Me.Txtbox4mobilenumber.Location = New System.Drawing.Point(305, 258)
        Me.Txtbox4mobilenumber.Name = "Txtbox4mobilenumber"
        Me.Txtbox4mobilenumber.Size = New System.Drawing.Size(258, 20)
        Me.Txtbox4mobilenumber.TabIndex = 11
        '
        'Lbl11
        '
        Me.Lbl11.AutoSize = True
        Me.Lbl11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl11.Location = New System.Drawing.Point(181, 296)
        Me.Lbl11.Name = "Lbl11"
        Me.Lbl11.Size = New System.Drawing.Size(65, 18)
        Me.Lbl11.TabIndex = 12
        Me.Lbl11.Text = "Location"
        '
        'Txtbox5location
        '
        Me.Txtbox5location.Location = New System.Drawing.Point(305, 297)
        Me.Txtbox5location.Name = "Txtbox5location"
        Me.Txtbox5location.Size = New System.Drawing.Size(258, 20)
        Me.Txtbox5location.TabIndex = 13
        '
        'Lbl13
        '
        Me.Lbl13.AutoSize = True
        Me.Lbl13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl13.Location = New System.Drawing.Point(177, 371)
        Me.Lbl13.Name = "Lbl13"
        Me.Lbl13.Size = New System.Drawing.Size(63, 18)
        Me.Lbl13.TabIndex = 14
        Me.Lbl13.Text = "Car type"
        '
        'Cbocartype
        '
        Me.Cbocartype.FormattingEnabled = True
        Me.Cbocartype.Items.AddRange(New Object() {"Small", "Medium", "Mini Bus", "Sports"})
        Me.Cbocartype.Location = New System.Drawing.Point(305, 372)
        Me.Cbocartype.Name = "Cbocartype"
        Me.Cbocartype.Size = New System.Drawing.Size(82, 21)
        Me.Cbocartype.TabIndex = 15
        '
        'Lbl6
        '
        Me.Lbl6.AutoSize = True
        Me.Lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl6.Location = New System.Drawing.Point(207, 103)
        Me.Lbl6.Name = "Lbl6"
        Me.Lbl6.Size = New System.Drawing.Size(41, 18)
        Me.Lbl6.TabIndex = 16
        Me.Lbl6.Text = "DOB"
        '
        'Cbo1day
        '
        Me.Cbo1day.FormattingEnabled = True
        Me.Cbo1day.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.Cbo1day.Location = New System.Drawing.Point(305, 104)
        Me.Cbo1day.Name = "Cbo1day"
        Me.Cbo1day.Size = New System.Drawing.Size(82, 21)
        Me.Cbo1day.TabIndex = 17
        '
        'Cbo2month
        '
        Me.Cbo2month.FormattingEnabled = True
        Me.Cbo2month.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.Cbo2month.Location = New System.Drawing.Point(393, 104)
        Me.Cbo2month.Name = "Cbo2month"
        Me.Cbo2month.Size = New System.Drawing.Size(82, 21)
        Me.Cbo2month.TabIndex = 18
        '
        'Cbo3year
        '
        Me.Cbo3year.FormattingEnabled = True
        Me.Cbo3year.Items.AddRange(New Object() {"1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999"})
        Me.Cbo3year.Location = New System.Drawing.Point(481, 104)
        Me.Cbo3year.Name = "Cbo3year"
        Me.Cbo3year.Size = New System.Drawing.Size(82, 21)
        Me.Cbo3year.TabIndex = 19
        '
        'Lbl12
        '
        Me.Lbl12.AutoSize = True
        Me.Lbl12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl12.Location = New System.Drawing.Point(181, 331)
        Me.Lbl12.Name = "Lbl12"
        Me.Lbl12.Size = New System.Drawing.Size(60, 18)
        Me.Lbl12.TabIndex = 20
        Me.Lbl12.Text = "Country"
        '
        'Txtbox6country
        '
        Me.Txtbox6country.Location = New System.Drawing.Point(305, 332)
        Me.Txtbox6country.Name = "Txtbox6country"
        Me.Txtbox6country.Size = New System.Drawing.Size(258, 20)
        Me.Txtbox6country.TabIndex = 21
        '
        'Lblday
        '
        Me.Lblday.AutoSize = True
        Me.Lblday.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblday.Location = New System.Drawing.Point(162, 408)
        Me.Lblday.Name = "Lblday"
        Me.Lblday.Size = New System.Drawing.Size(97, 18)
        Me.Lblday.TabIndex = 24
        Me.Lblday.Text = "Car Rent Day"
        '
        'Btn3
        '
        Me.Btn3.Location = New System.Drawing.Point(864, 26)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(75, 23)
        Me.Btn3.TabIndex = 36
        Me.Btn3.Text = "Help"
        Me.Btn3.UseVisualStyleBackColor = True
        '
        'LblMonth
        '
        Me.LblMonth.AutoSize = True
        Me.LblMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMonth.Location = New System.Drawing.Point(678, 407)
        Me.LblMonth.Name = "LblMonth"
        Me.LblMonth.Size = New System.Drawing.Size(113, 18)
        Me.LblMonth.TabIndex = 33
        Me.LblMonth.Text = "Car Rent Month"
        '
        'Lblweek
        '
        Me.Lblweek.AutoSize = True
        Me.Lblweek.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblweek.Location = New System.Drawing.Point(425, 408)
        Me.Lblweek.Name = "Lblweek"
        Me.Lblweek.Size = New System.Drawing.Size(110, 18)
        Me.Lblweek.TabIndex = 37
        Me.Lblweek.Text = "Car Rent Week"
        '
        'lbltotalcost
        '
        Me.lbltotalcost.AutoSize = True
        Me.lbltotalcost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalcost.Location = New System.Drawing.Point(207, 463)
        Me.lbltotalcost.Name = "lbltotalcost"
        Me.lbltotalcost.Size = New System.Drawing.Size(140, 18)
        Me.lbltotalcost.TabIndex = 41
        Me.lbltotalcost.Text = "Total Car Rent Cost"
        '
        'Lbldisplaycost
        '
        Me.Lbldisplaycost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbldisplaycost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbldisplaycost.Location = New System.Drawing.Point(373, 462)
        Me.Lbldisplaycost.Name = "Lbldisplaycost"
        Me.Lbldisplaycost.Size = New System.Drawing.Size(140, 27)
        Me.Lbldisplaycost.TabIndex = 42
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(548, 466)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalculate.TabIndex = 43
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'Chkday
        '
        Me.Chkday.AutoSize = True
        Me.Chkday.Location = New System.Drawing.Point(272, 411)
        Me.Chkday.Name = "Chkday"
        Me.Chkday.Size = New System.Drawing.Size(15, 14)
        Me.Chkday.TabIndex = 44
        Me.Chkday.UseVisualStyleBackColor = True
        '
        'Chkweek
        '
        Me.Chkweek.AutoSize = True
        Me.Chkweek.Location = New System.Drawing.Point(548, 411)
        Me.Chkweek.Name = "Chkweek"
        Me.Chkweek.Size = New System.Drawing.Size(15, 14)
        Me.Chkweek.TabIndex = 45
        Me.Chkweek.UseVisualStyleBackColor = True
        '
        'Chkmonth
        '
        Me.Chkmonth.AutoSize = True
        Me.Chkmonth.Location = New System.Drawing.Point(807, 412)
        Me.Chkmonth.Name = "Chkmonth"
        Me.Chkmonth.Size = New System.Drawing.Size(15, 14)
        Me.Chkmonth.TabIndex = 46
        Me.Chkmonth.UseVisualStyleBackColor = True
        '
        'Btnsubmit
        '
        Me.Btnsubmit.Location = New System.Drawing.Point(716, 466)
        Me.Btnsubmit.Name = "Btnsubmit"
        Me.Btnsubmit.Size = New System.Drawing.Size(75, 23)
        Me.Btnsubmit.TabIndex = 47
        Me.Btnsubmit.Text = "Submit"
        Me.Btnsubmit.UseVisualStyleBackColor = True
        '
        'Btnnext
        '
        Me.Btnnext.Location = New System.Drawing.Point(851, 466)
        Me.Btnnext.Name = "Btnnext"
        Me.Btnnext.Size = New System.Drawing.Size(75, 23)
        Me.Btnnext.TabIndex = 48
        Me.Btnnext.Text = "Next"
        Me.Btnnext.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 521)
        Me.Controls.Add(Me.Btnnext)
        Me.Controls.Add(Me.Btnsubmit)
        Me.Controls.Add(Me.Chkmonth)
        Me.Controls.Add(Me.Chkweek)
        Me.Controls.Add(Me.Chkday)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.Lbldisplaycost)
        Me.Controls.Add(Me.lbltotalcost)
        Me.Controls.Add(Me.Lblweek)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.LblMonth)
        Me.Controls.Add(Me.Lblday)
        Me.Controls.Add(Me.Txtbox6country)
        Me.Controls.Add(Me.Lbl12)
        Me.Controls.Add(Me.Cbo3year)
        Me.Controls.Add(Me.Cbo2month)
        Me.Controls.Add(Me.Cbo1day)
        Me.Controls.Add(Me.Lbl6)
        Me.Controls.Add(Me.Cbocartype)
        Me.Controls.Add(Me.Lbl13)
        Me.Controls.Add(Me.Txtbox5location)
        Me.Controls.Add(Me.Lbl11)
        Me.Controls.Add(Me.Txtbox4mobilenumber)
        Me.Controls.Add(Me.Lbl9)
        Me.Controls.Add(Me.Txtbox3email)
        Me.Controls.Add(Me.Lbl10)
        Me.Controls.Add(Me.Cbo5gender)
        Me.Controls.Add(Me.Lbl8)
        Me.Controls.Add(Me.Cbo4Age)
        Me.Controls.Add(Me.Lbl7)
        Me.Controls.Add(Me.lastname)
        Me.Controls.Add(Me.Lbl5)
        Me.Controls.Add(Me.firstname)
        Me.Controls.Add(Me.Lbl4)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl4 As System.Windows.Forms.Label
    Friend WithEvents firstname As System.Windows.Forms.TextBox
    Friend WithEvents Lbl5 As System.Windows.Forms.Label
    Friend WithEvents lastname As System.Windows.Forms.TextBox
    Friend WithEvents Lbl7 As System.Windows.Forms.Label
    Friend WithEvents Cbo4Age As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl8 As System.Windows.Forms.Label
    Friend WithEvents Cbo5gender As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl10 As System.Windows.Forms.Label
    Friend WithEvents Txtbox3email As System.Windows.Forms.TextBox
    Friend WithEvents Lbl9 As System.Windows.Forms.Label
    Friend WithEvents Txtbox4mobilenumber As System.Windows.Forms.TextBox
    Friend WithEvents Lbl11 As System.Windows.Forms.Label
    Friend WithEvents Txtbox5location As System.Windows.Forms.TextBox
    Friend WithEvents Lbl13 As System.Windows.Forms.Label
    Friend WithEvents Cbocartype As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl6 As System.Windows.Forms.Label
    Friend WithEvents Cbo1day As System.Windows.Forms.ComboBox
    Friend WithEvents Cbo2month As System.Windows.Forms.ComboBox
    Friend WithEvents Cbo3year As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl12 As System.Windows.Forms.Label
    Friend WithEvents Txtbox6country As System.Windows.Forms.TextBox
    Friend WithEvents Lblday As System.Windows.Forms.Label
    Friend WithEvents Btn3 As System.Windows.Forms.Button
    Friend WithEvents LblMonth As System.Windows.Forms.Label
    Friend WithEvents Lblweek As System.Windows.Forms.Label
    Friend WithEvents lbltotalcost As System.Windows.Forms.Label
    Friend WithEvents Lbldisplaycost As System.Windows.Forms.Label
    Friend WithEvents BtnCalculate As System.Windows.Forms.Button
    Friend WithEvents Chkday As System.Windows.Forms.CheckBox
    Friend WithEvents Chkweek As System.Windows.Forms.CheckBox
    Friend WithEvents Chkmonth As System.Windows.Forms.CheckBox
    Friend WithEvents Btnsubmit As System.Windows.Forms.Button
    Friend WithEvents Btnnext As System.Windows.Forms.Button
End Class
