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
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblNumOfBed = New System.Windows.Forms.Label()
        Me.txtNumOfBed = New System.Windows.Forms.TextBox()
        Me.lblAvailability = New System.Windows.Forms.Label()
        Me.lblFloor = New System.Windows.Forms.Label()
        Me.txtFloor = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.RichTextBox()
        Me.cbbType = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cbAvailability = New System.Windows.Forms.CheckBox()
        Me.picErrorField1 = New System.Windows.Forms.PictureBox()
        Me.picErrorField2 = New System.Windows.Forms.PictureBox()
        Me.picErrorField3 = New System.Windows.Forms.PictureBox()
        Me.picErrorField4 = New System.Windows.Forms.PictureBox()
        Me.picErrorField5 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picErrorField1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErrorField2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErrorField3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErrorField4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErrorField5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRoomNumber
        '
        Me.lblRoomNumber.AutoSize = True
        Me.lblRoomNumber.Location = New System.Drawing.Point(24, 45)
        Me.lblRoomNumber.Name = "lblRoomNumber"
        Me.lblRoomNumber.Size = New System.Drawing.Size(73, 13)
        Me.lblRoomNumber.TabIndex = 27
        Me.lblRoomNumber.Text = "Room number"
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.Location = New System.Drawing.Point(124, 42)
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.Size = New System.Drawing.Size(202, 20)
        Me.txtRoomNumber.TabIndex = 28
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(24, 88)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(31, 13)
        Me.lblType.TabIndex = 29
        Me.lblType.Text = "Type"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(24, 137)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblPrice.TabIndex = 31
        Me.lblPrice.Text = "Price"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(124, 134)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(202, 20)
        Me.txtPrice.TabIndex = 32
        '
        'lblNumOfBed
        '
        Me.lblNumOfBed.AutoSize = True
        Me.lblNumOfBed.Location = New System.Drawing.Point(24, 188)
        Me.lblNumOfBed.Name = "lblNumOfBed"
        Me.lblNumOfBed.Size = New System.Drawing.Size(82, 13)
        Me.lblNumOfBed.TabIndex = 33
        Me.lblNumOfBed.Text = "Number of beds"
        '
        'txtNumOfBed
        '
        Me.txtNumOfBed.Location = New System.Drawing.Point(124, 185)
        Me.txtNumOfBed.Name = "txtNumOfBed"
        Me.txtNumOfBed.Size = New System.Drawing.Size(202, 20)
        Me.txtNumOfBed.TabIndex = 34
        '
        'lblAvailability
        '
        Me.lblAvailability.AutoSize = True
        Me.lblAvailability.Location = New System.Drawing.Point(24, 241)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.Size = New System.Drawing.Size(56, 13)
        Me.lblAvailability.TabIndex = 35
        Me.lblAvailability.Text = "Availability"
        '
        'lblFloor
        '
        Me.lblFloor.AutoSize = True
        Me.lblFloor.Location = New System.Drawing.Point(24, 294)
        Me.lblFloor.Name = "lblFloor"
        Me.lblFloor.Size = New System.Drawing.Size(30, 13)
        Me.lblFloor.TabIndex = 37
        Me.lblFloor.Text = "Floor"
        '
        'txtFloor
        '
        Me.txtFloor.Location = New System.Drawing.Point(124, 291)
        Me.txtFloor.Name = "txtFloor"
        Me.txtFloor.Size = New System.Drawing.Size(202, 20)
        Me.txtFloor.TabIndex = 38
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(24, 348)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 39
        Me.lblDescription.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(124, 345)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(202, 88)
        Me.txtDescription.TabIndex = 42
        Me.txtDescription.Text = ""
        '
        'cbbType
        '
        Me.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbType.FormattingEnabled = True
        Me.cbbType.Items.AddRange(New Object() {"Standard", "Deluxe"})
        Me.cbbType.Location = New System.Drawing.Point(124, 85)
        Me.cbbType.Name = "cbbType"
        Me.cbbType.Size = New System.Drawing.Size(105, 21)
        Me.cbbType.TabIndex = 43
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(63, 474)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(113, 23)
        Me.btnSave.TabIndex = 44
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(238, 474)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(113, 23)
        Me.btnCancel.TabIndex = 45
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cbAvailability
        '
        Me.cbAvailability.AutoSize = True
        Me.cbAvailability.Location = New System.Drawing.Point(124, 241)
        Me.cbAvailability.Name = "cbAvailability"
        Me.cbAvailability.Size = New System.Drawing.Size(15, 14)
        Me.cbAvailability.TabIndex = 47
        Me.cbAvailability.UseVisualStyleBackColor = True
        '
        'picErrorField1
        '
        Me.picErrorField1.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField1.Location = New System.Drawing.Point(357, 42)
        Me.picErrorField1.Name = "picErrorField1"
        Me.picErrorField1.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField1.TabIndex = 52
        Me.picErrorField1.TabStop = False
        Me.picErrorField1.Visible = False
        '
        'picErrorField2
        '
        Me.picErrorField2.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField2.Location = New System.Drawing.Point(357, 81)
        Me.picErrorField2.Name = "picErrorField2"
        Me.picErrorField2.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField2.TabIndex = 53
        Me.picErrorField2.TabStop = False
        Me.picErrorField2.Visible = False
        '
        'picErrorField3
        '
        Me.picErrorField3.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField3.Location = New System.Drawing.Point(357, 129)
        Me.picErrorField3.Name = "picErrorField3"
        Me.picErrorField3.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField3.TabIndex = 54
        Me.picErrorField3.TabStop = False
        Me.picErrorField3.Visible = False
        '
        'picErrorField4
        '
        Me.picErrorField4.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField4.Location = New System.Drawing.Point(357, 180)
        Me.picErrorField4.Name = "picErrorField4"
        Me.picErrorField4.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField4.TabIndex = 55
        Me.picErrorField4.TabStop = False
        Me.picErrorField4.Visible = False
        '
        'picErrorField5
        '
        Me.picErrorField5.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField5.Location = New System.Drawing.Point(357, 286)
        Me.picErrorField5.Name = "picErrorField5"
        Me.picErrorField5.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField5.TabIndex = 56
        Me.picErrorField5.TabStop = False
        Me.picErrorField5.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(411, 24)
        Me.MenuStrip1.TabIndex = 76
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem1, Me.RoomToolStripMenuItem1, Me.BookingToolStripMenuItem1})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.EditToolStripMenuItem.Text = "Add"
        '
        'CustomerToolStripMenuItem1
        '
        Me.CustomerToolStripMenuItem1.Name = "CustomerToolStripMenuItem1"
        Me.CustomerToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.CustomerToolStripMenuItem1.Text = "Customer"
        '
        'RoomToolStripMenuItem1
        '
        Me.RoomToolStripMenuItem1.Enabled = False
        Me.RoomToolStripMenuItem1.Name = "RoomToolStripMenuItem1"
        Me.RoomToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.RoomToolStripMenuItem1.Text = "Room"
        '
        'BookingToolStripMenuItem1
        '
        Me.BookingToolStripMenuItem1.Name = "BookingToolStripMenuItem1"
        Me.BookingToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.BookingToolStripMenuItem1.Text = "Booking"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem, Me.RoomToolStripMenuItem, Me.BookingToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'RoomToolStripMenuItem
        '
        Me.RoomToolStripMenuItem.Name = "RoomToolStripMenuItem"
        Me.RoomToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.RoomToolStripMenuItem.Text = "Room"
        '
        'BookingToolStripMenuItem
        '
        Me.BookingToolStripMenuItem.Name = "BookingToolStripMenuItem"
        Me.BookingToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.BookingToolStripMenuItem.Text = "Booking"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.AboutUsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ViewHelpToolStripMenuItem.Text = "View help"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AboutUsToolStripMenuItem.Text = "About us"
        '
        'frmRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 549)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.picErrorField5)
        Me.Controls.Add(Me.picErrorField4)
        Me.Controls.Add(Me.picErrorField3)
        Me.Controls.Add(Me.picErrorField2)
        Me.Controls.Add(Me.picErrorField1)
        Me.Controls.Add(Me.cbAvailability)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cbbType)
        Me.Controls.Add(Me.txtDescription)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room"
        CType(Me.picErrorField1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErrorField2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErrorField3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErrorField4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErrorField5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRoomNumber As Label
    Friend WithEvents txtRoomNumber As TextBox
    Friend WithEvents lblType As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblNumOfBed As Label
    Friend WithEvents txtNumOfBed As TextBox
    Friend WithEvents lblAvailability As Label
    Friend WithEvents lblFloor As Label
    Friend WithEvents txtFloor As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtDescription As RichTextBox
    Friend WithEvents cbbType As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents cbAvailability As System.Windows.Forms.CheckBox
    Friend WithEvents picErrorField1 As System.Windows.Forms.PictureBox
    Friend WithEvents picErrorField2 As System.Windows.Forms.PictureBox
    Friend WithEvents picErrorField3 As System.Windows.Forms.PictureBox
    Friend WithEvents picErrorField4 As System.Windows.Forms.PictureBox
    Friend WithEvents picErrorField5 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
