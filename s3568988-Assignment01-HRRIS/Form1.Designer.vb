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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cbbGender = New System.Windows.Forms.ComboBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.cbbTitle = New System.Windows.Forms.ComboBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblDob = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cbbType = New System.Windows.Forms.ComboBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtFloor = New System.Windows.Forms.TextBox()
        Me.lblFloor = New System.Windows.Forms.Label()
        Me.lblAvailability = New System.Windows.Forms.Label()
        Me.txtNumOfBed = New System.Windows.Forms.TextBox()
        Me.lblNumOfBed = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.txtRoomNumber = New System.Windows.Forms.TextBox()
        Me.lblRoomNumber = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(431, 561)
        Me.TabControl1.TabIndex = 28
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblTitle)
        Me.TabPage1.Controls.Add(Me.cbbGender)
        Me.TabPage1.Controls.Add(Me.lblGender)
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.lblFirstName)
        Me.TabPage1.Controls.Add(Me.cbbTitle)
        Me.TabPage1.Controls.Add(Me.txtFirstName)
        Me.TabPage1.Controls.Add(Me.btnCancel)
        Me.TabPage1.Controls.Add(Me.lblLastName)
        Me.TabPage1.Controls.Add(Me.btnSubmit)
        Me.TabPage1.Controls.Add(Me.txtLastName)
        Me.TabPage1.Controls.Add(Me.lblDob)
        Me.TabPage1.Controls.Add(Me.lblPhone)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.txtPhone)
        Me.TabPage1.Controls.Add(Me.lblEmail)
        Me.TabPage1.Controls.Add(Me.lblAddress)
        Me.TabPage1.Controls.Add(Me.txtAddress)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(423, 535)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(25, 34)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Title"
        '
        'cbbGender
        '
        Me.cbbGender.FormattingEnabled = True
        Me.cbbGender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.cbbGender.Location = New System.Drawing.Point(141, 67)
        Me.cbbGender.Name = "cbbGender"
        Me.cbbGender.Size = New System.Drawing.Size(105, 21)
        Me.cbbGender.TabIndex = 26
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(25, 70)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(42, 13)
        Me.lblGender.TabIndex = 4
        Me.lblGender.Text = "Gender"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(141, 328)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(202, 20)
        Me.DateTimePicker1.TabIndex = 25
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(25, 111)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 6
        Me.lblFirstName.Text = "First Name"
        '
        'cbbTitle
        '
        Me.cbbTitle.FormattingEnabled = True
        Me.cbbTitle.Items.AddRange(New Object() {"Ms.", "Mrs.", "Mr."})
        Me.cbbTitle.Location = New System.Drawing.Point(141, 31)
        Me.cbbTitle.Name = "cbbTitle"
        Me.cbbTitle.Size = New System.Drawing.Size(105, 21)
        Me.cbbTitle.TabIndex = 24
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(141, 108)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(202, 20)
        Me.txtFirstName.TabIndex = 7
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(230, 420)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(113, 23)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(25, 154)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 8
        Me.lblLastName.Text = "Last Name"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(55, 420)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(113, 23)
        Me.btnSubmit.TabIndex = 20
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(141, 151)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(202, 20)
        Me.txtLastName.TabIndex = 9
        '
        'lblDob
        '
        Me.lblDob.AutoSize = True
        Me.lblDob.Location = New System.Drawing.Point(25, 336)
        Me.lblDob.Name = "lblDob"
        Me.lblDob.Size = New System.Drawing.Size(30, 13)
        Me.lblDob.TabIndex = 16
        Me.lblDob.Text = "DOB"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(25, 196)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(38, 13)
        Me.lblPhone.TabIndex = 10
        Me.lblPhone.Text = "Phone"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(141, 285)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(202, 20)
        Me.txtEmail.TabIndex = 15
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(141, 193)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(202, 20)
        Me.txtPhone.TabIndex = 11
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(25, 288)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 14
        Me.lblEmail.Text = "Email"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(25, 241)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 12
        Me.lblAddress.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(141, 238)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(202, 20)
        Me.txtAddress.TabIndex = 13
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RadioButton2)
        Me.TabPage2.Controls.Add(Me.RadioButton1)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.btnSave)
        Me.TabPage2.Controls.Add(Me.cbbType)
        Me.TabPage2.Controls.Add(Me.RichTextBox1)
        Me.TabPage2.Controls.Add(Me.lblDescription)
        Me.TabPage2.Controls.Add(Me.txtFloor)
        Me.TabPage2.Controls.Add(Me.lblFloor)
        Me.TabPage2.Controls.Add(Me.lblAvailability)
        Me.TabPage2.Controls.Add(Me.txtNumOfBed)
        Me.TabPage2.Controls.Add(Me.lblNumOfBed)
        Me.TabPage2.Controls.Add(Me.txtPrice)
        Me.TabPage2.Controls.Add(Me.lblPrice)
        Me.TabPage2.Controls.Add(Me.lblType)
        Me.TabPage2.Controls.Add(Me.txtRoomNumber)
        Me.TabPage2.Controls.Add(Me.lblRoomNumber)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(423, 535)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(240, 253)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(39, 17)
        Me.RadioButton2.TabIndex = 64
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "No"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(146, 253)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(43, 17)
        Me.RadioButton1.TabIndex = 63
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Yes"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(227, 476)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 23)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(52, 476)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(113, 23)
        Me.btnSave.TabIndex = 61
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cbbType
        '
        Me.cbbType.FormattingEnabled = True
        Me.cbbType.Location = New System.Drawing.Point(137, 111)
        Me.cbbType.Name = "cbbType"
        Me.cbbType.Size = New System.Drawing.Size(105, 21)
        Me.cbbType.TabIndex = 60
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(137, 355)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(202, 88)
        Me.RichTextBox1.TabIndex = 59
        Me.RichTextBox1.Text = ""
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(37, 358)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 58
        Me.lblDescription.Text = "Description"
        '
        'txtFloor
        '
        Me.txtFloor.Location = New System.Drawing.Point(137, 303)
        Me.txtFloor.Name = "txtFloor"
        Me.txtFloor.Size = New System.Drawing.Size(202, 20)
        Me.txtFloor.TabIndex = 57
        '
        'lblFloor
        '
        Me.lblFloor.AutoSize = True
        Me.lblFloor.Location = New System.Drawing.Point(37, 306)
        Me.lblFloor.Name = "lblFloor"
        Me.lblFloor.Size = New System.Drawing.Size(30, 13)
        Me.lblFloor.TabIndex = 56
        Me.lblFloor.Text = "Floor"
        '
        'lblAvailability
        '
        Me.lblAvailability.AutoSize = True
        Me.lblAvailability.Location = New System.Drawing.Point(37, 253)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.Size = New System.Drawing.Size(56, 13)
        Me.lblAvailability.TabIndex = 55
        Me.lblAvailability.Text = "Availability"
        '
        'txtNumOfBed
        '
        Me.txtNumOfBed.Location = New System.Drawing.Point(137, 202)
        Me.txtNumOfBed.Name = "txtNumOfBed"
        Me.txtNumOfBed.Size = New System.Drawing.Size(202, 20)
        Me.txtNumOfBed.TabIndex = 54
        '
        'lblNumOfBed
        '
        Me.lblNumOfBed.AutoSize = True
        Me.lblNumOfBed.Location = New System.Drawing.Point(37, 205)
        Me.lblNumOfBed.Name = "lblNumOfBed"
        Me.lblNumOfBed.Size = New System.Drawing.Size(82, 13)
        Me.lblNumOfBed.TabIndex = 53
        Me.lblNumOfBed.Text = "Number of beds"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(137, 156)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(202, 20)
        Me.txtPrice.TabIndex = 52
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(37, 159)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblPrice.TabIndex = 51
        Me.lblPrice.Text = "Price"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(37, 114)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(31, 13)
        Me.lblType.TabIndex = 50
        Me.lblType.Text = "Type"
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.Location = New System.Drawing.Point(137, 71)
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.Size = New System.Drawing.Size(202, 20)
        Me.txtRoomNumber.TabIndex = 49
        '
        'lblRoomNumber
        '
        Me.lblRoomNumber.AutoSize = True
        Me.lblRoomNumber.Location = New System.Drawing.Point(37, 74)
        Me.lblRoomNumber.Name = "lblRoomNumber"
        Me.lblRoomNumber.Size = New System.Drawing.Size(73, 13)
        Me.lblRoomNumber.TabIndex = 48
        Me.lblRoomNumber.Text = "Room number"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 681)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lblTitle As Label
    Friend WithEvents cbbGender As ComboBox
    Friend WithEvents lblGender As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblFirstName As Label
    Friend WithEvents cbbTitle As ComboBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblLastName As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblDob As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cbbType As ComboBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtFloor As TextBox
    Friend WithEvents lblFloor As Label
    Friend WithEvents lblAvailability As Label
    Friend WithEvents txtNumOfBed As TextBox
    Friend WithEvents lblNumOfBed As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblType As Label
    Friend WithEvents txtRoomNumber As TextBox
    Friend WithEvents lblRoomNumber As Label
End Class
