<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoom
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
        Me.lblRoomNumber = New System.Windows.Forms.Label()
        Me.txtRoomNumber = New System.Windows.Forms.TextBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtNumOfBed = New System.Windows.Forms.TextBox()
        Me.lblNumOfBed = New System.Windows.Forms.Label()
        Me.lblAvailability = New System.Windows.Forms.Label()
        Me.txtFloor = New System.Windows.Forms.TextBox()
        Me.lblFloor = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.cbbType = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblRoomNumber
        '
        Me.lblRoomNumber.AutoSize = True
        Me.lblRoomNumber.Location = New System.Drawing.Point(24, 35)
        Me.lblRoomNumber.Name = "lblRoomNumber"
        Me.lblRoomNumber.Size = New System.Drawing.Size(73, 13)
        Me.lblRoomNumber.TabIndex = 27
        Me.lblRoomNumber.Text = "Room number"
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.Location = New System.Drawing.Point(124, 32)
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.Size = New System.Drawing.Size(202, 20)
        Me.txtRoomNumber.TabIndex = 28
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(24, 91)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(31, 13)
        Me.lblType.TabIndex = 29
        Me.lblType.Text = "Type"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(124, 145)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(202, 20)
        Me.txtPrice.TabIndex = 32
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(24, 148)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblPrice.TabIndex = 31
        Me.lblPrice.Text = "Price"
        '
        'txtNumOfBed
        '
        Me.txtNumOfBed.Location = New System.Drawing.Point(124, 201)
        Me.txtNumOfBed.Name = "txtNumOfBed"
        Me.txtNumOfBed.Size = New System.Drawing.Size(202, 20)
        Me.txtNumOfBed.TabIndex = 34
        '
        'lblNumOfBed
        '
        Me.lblNumOfBed.AutoSize = True
        Me.lblNumOfBed.Location = New System.Drawing.Point(24, 204)
        Me.lblNumOfBed.Name = "lblNumOfBed"
        Me.lblNumOfBed.Size = New System.Drawing.Size(82, 13)
        Me.lblNumOfBed.TabIndex = 33
        Me.lblNumOfBed.Text = "Number of beds"
        '
        'lblAvailability
        '
        Me.lblAvailability.AutoSize = True
        Me.lblAvailability.Location = New System.Drawing.Point(24, 265)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.Size = New System.Drawing.Size(56, 13)
        Me.lblAvailability.TabIndex = 35
        Me.lblAvailability.Text = "Availability"
        '
        'txtFloor
        '
        Me.txtFloor.Location = New System.Drawing.Point(124, 321)
        Me.txtFloor.Name = "txtFloor"
        Me.txtFloor.Size = New System.Drawing.Size(202, 20)
        Me.txtFloor.TabIndex = 38
        '
        'lblFloor
        '
        Me.lblFloor.AutoSize = True
        Me.lblFloor.Location = New System.Drawing.Point(24, 324)
        Me.lblFloor.Name = "lblFloor"
        Me.lblFloor.Size = New System.Drawing.Size(30, 13)
        Me.lblFloor.TabIndex = 37
        Me.lblFloor.Text = "Floor"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(24, 381)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 39
        Me.lblDescription.Text = "Description"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(124, 378)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(202, 88)
        Me.RichTextBox1.TabIndex = 42
        Me.RichTextBox1.Text = ""
        '
        'cbbType
        '
        Me.cbbType.FormattingEnabled = True
        Me.cbbType.Location = New System.Drawing.Point(124, 88)
        Me.cbbType.Name = "cbbType"
        Me.cbbType.Size = New System.Drawing.Size(105, 21)
        Me.cbbType.TabIndex = 43
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(238, 507)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(113, 23)
        Me.btnCancel.TabIndex = 45
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(63, 507)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(113, 23)
        Me.btnSave.TabIndex = 44
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(133, 265)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(43, 17)
        Me.RadioButton1.TabIndex = 46
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Yes"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(222, 265)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(39, 17)
        Me.RadioButton2.TabIndex = 47
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "No"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'frmRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 572)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cbbType)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtFloor)
        Me.Controls.Add(Me.lblFloor)
        Me.Controls.Add(Me.lblAvailability)
        Me.Controls.Add(Me.txtNumOfBed)
        Me.Controls.Add(Me.lblNumOfBed)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.txtRoomNumber)
        Me.Controls.Add(Me.lblRoomNumber)
        Me.Name = "frmRoom"
        Me.Text = "Room"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRoomNumber As System.Windows.Forms.Label
    Friend WithEvents txtRoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents txtNumOfBed As System.Windows.Forms.TextBox
    Friend WithEvents lblNumOfBed As System.Windows.Forms.Label
    Friend WithEvents lblAvailability As System.Windows.Forms.Label
    Friend WithEvents txtFloor As System.Windows.Forms.TextBox
    Friend WithEvents lblFloor As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents cbbType As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
End Class
