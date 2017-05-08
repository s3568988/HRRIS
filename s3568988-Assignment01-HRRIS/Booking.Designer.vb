<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooking
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
        Me.components = New System.ComponentModel.Container()
        Me.cbbRoomId = New System.Windows.Forms.ComboBox()
        Me.txtNumOfDay = New System.Windows.Forms.TextBox()
        Me.lblNumOfDay = New System.Windows.Forms.Label()
        Me.lblCustomerId = New System.Windows.Forms.Label()
        Me.lblRoomId = New System.Windows.Forms.Label()
        Me.lblBookingDate = New System.Windows.Forms.Label()
        Me.txtNumOfGuest = New System.Windows.Forms.TextBox()
        Me.lblNumOfGuest = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lblCheckinDate = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.picErrorField1 = New System.Windows.Forms.PictureBox()
        Me.picErrorField2 = New System.Windows.Forms.PictureBox()
        Me.picErrorField3 = New System.Windows.Forms.PictureBox()
        Me.picErrorField4 = New System.Windows.Forms.PictureBox()
        Me.txtCusId = New System.Windows.Forms.TextBox()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlBreakReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picErrorField1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErrorField2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErrorField3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErrorField4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbbRoomId
        '
        Me.cbbRoomId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbRoomId.FormattingEnabled = True
        Me.cbbRoomId.Location = New System.Drawing.Point(121, 102)
        Me.cbbRoomId.Name = "cbbRoomId"
        Me.cbbRoomId.Size = New System.Drawing.Size(105, 21)
        Me.cbbRoomId.TabIndex = 55
        '
        'txtNumOfDay
        '
        Me.txtNumOfDay.Location = New System.Drawing.Point(121, 199)
        Me.txtNumOfDay.Name = "txtNumOfDay"
        Me.txtNumOfDay.Size = New System.Drawing.Size(202, 20)
        Me.txtNumOfDay.TabIndex = 50
        '
        'lblNumOfDay
        '
        Me.lblNumOfDay.AutoSize = True
        Me.lblNumOfDay.Location = New System.Drawing.Point(21, 202)
        Me.lblNumOfDay.Name = "lblNumOfDay"
        Me.lblNumOfDay.Size = New System.Drawing.Size(81, 13)
        Me.lblNumOfDay.TabIndex = 49
        Me.lblNumOfDay.Text = "Number of days"
        '
        'lblCustomerId
        '
        Me.lblCustomerId.AutoSize = True
        Me.lblCustomerId.Location = New System.Drawing.Point(21, 152)
        Me.lblCustomerId.Name = "lblCustomerId"
        Me.lblCustomerId.Size = New System.Drawing.Size(65, 13)
        Me.lblCustomerId.TabIndex = 47
        Me.lblCustomerId.Text = "Customer ID"
        '
        'lblRoomId
        '
        Me.lblRoomId.AutoSize = True
        Me.lblRoomId.Location = New System.Drawing.Point(21, 105)
        Me.lblRoomId.Name = "lblRoomId"
        Me.lblRoomId.Size = New System.Drawing.Size(75, 13)
        Me.lblRoomId.TabIndex = 46
        Me.lblRoomId.Text = "Room Number"
        '
        'lblBookingDate
        '
        Me.lblBookingDate.AutoSize = True
        Me.lblBookingDate.Location = New System.Drawing.Point(21, 63)
        Me.lblBookingDate.Name = "lblBookingDate"
        Me.lblBookingDate.Size = New System.Drawing.Size(72, 13)
        Me.lblBookingDate.TabIndex = 44
        Me.lblBookingDate.Text = "Booking Date"
        '
        'txtNumOfGuest
        '
        Me.txtNumOfGuest.Location = New System.Drawing.Point(121, 247)
        Me.txtNumOfGuest.Name = "txtNumOfGuest"
        Me.txtNumOfGuest.Size = New System.Drawing.Size(202, 20)
        Me.txtNumOfGuest.TabIndex = 58
        '
        'lblNumOfGuest
        '
        Me.lblNumOfGuest.AutoSize = True
        Me.lblNumOfGuest.Location = New System.Drawing.Point(21, 250)
        Me.lblNumOfGuest.Name = "lblNumOfGuest"
        Me.lblNumOfGuest.Size = New System.Drawing.Size(90, 13)
        Me.lblNumOfGuest.TabIndex = 57
        Me.lblNumOfGuest.Text = "Number of guests"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(121, 63)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(202, 20)
        Me.DateTimePicker1.TabIndex = 59
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(121, 301)
        Me.DateTimePicker2.MinDate = New Date(2017, 3, 31, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(202, 20)
        Me.DateTimePicker2.TabIndex = 61
        '
        'lblCheckinDate
        '
        Me.lblCheckinDate.AutoSize = True
        Me.lblCheckinDate.Location = New System.Drawing.Point(21, 301)
        Me.lblCheckinDate.Name = "lblCheckinDate"
        Me.lblCheckinDate.Size = New System.Drawing.Size(75, 13)
        Me.lblCheckinDate.TabIndex = 60
        Me.lblCheckinDate.Text = "Check in Date"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(121, 354)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(202, 20)
        Me.txtTotalPrice.TabIndex = 63
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Location = New System.Drawing.Point(21, 358)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalPrice.TabIndex = 62
        Me.lblTotalPrice.Text = "Total Price"
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Location = New System.Drawing.Point(21, 411)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(51, 13)
        Me.lblComment.TabIndex = 64
        Me.lblComment.Text = "Comment"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(231, 532)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(113, 23)
        Me.btnCancel.TabIndex = 67
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(56, 532)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(113, 23)
        Me.btnSave.TabIndex = 66
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'picErrorField1
        '
        Me.picErrorField1.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField1.Location = New System.Drawing.Point(358, 98)
        Me.picErrorField1.Name = "picErrorField1"
        Me.picErrorField1.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField1.TabIndex = 69
        Me.picErrorField1.TabStop = False
        Me.picErrorField1.Visible = False
        '
        'picErrorField2
        '
        Me.picErrorField2.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField2.Location = New System.Drawing.Point(358, 145)
        Me.picErrorField2.Name = "picErrorField2"
        Me.picErrorField2.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField2.TabIndex = 70
        Me.picErrorField2.TabStop = False
        Me.picErrorField2.Visible = False
        '
        'picErrorField3
        '
        Me.picErrorField3.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField3.Location = New System.Drawing.Point(358, 194)
        Me.picErrorField3.Name = "picErrorField3"
        Me.picErrorField3.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField3.TabIndex = 71
        Me.picErrorField3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picErrorField3, "The number of days must not be less than 1 and must be numeric")
        Me.picErrorField3.Visible = False
        '
        'picErrorField4
        '
        Me.picErrorField4.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField4.Location = New System.Drawing.Point(358, 242)
        Me.picErrorField4.Name = "picErrorField4"
        Me.picErrorField4.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField4.TabIndex = 72
        Me.picErrorField4.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picErrorField4, "The number of days must not be less than 1 and must be numeric")
        Me.picErrorField4.Visible = False
        '
        'txtCusId
        '
        Me.txtCusId.Location = New System.Drawing.Point(121, 149)
        Me.txtCusId.Name = "txtCusId"
        Me.txtCusId.Size = New System.Drawing.Size(202, 20)
        Me.txtCusId.TabIndex = 73
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(121, 408)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(202, 80)
        Me.txtComments.TabIndex = 74
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(420, 24)
        Me.MenuStrip1.TabIndex = 75
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem1, Me.RoomToolStripMenuItem1, Me.BookingToolStripMenuItem1, Me.InvoiceToolStripMenuItem})
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
        Me.RoomToolStripMenuItem1.Name = "RoomToolStripMenuItem1"
        Me.RoomToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.RoomToolStripMenuItem1.Text = "Room"
        '
        'BookingToolStripMenuItem1
        '
        Me.BookingToolStripMenuItem1.Enabled = False
        Me.BookingToolStripMenuItem1.Name = "BookingToolStripMenuItem1"
        Me.BookingToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.BookingToolStripMenuItem1.Text = "Booking"
        '
        'InvoiceToolStripMenuItem
        '
        Me.InvoiceToolStripMenuItem.Name = "InvoiceToolStripMenuItem"
        Me.InvoiceToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.InvoiceToolStripMenuItem.Text = "Invoice"
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
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalReportToolStripMenuItem, Me.ControlBreakReportToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'NormalReportToolStripMenuItem
        '
        Me.NormalReportToolStripMenuItem.Name = "NormalReportToolStripMenuItem"
        Me.NormalReportToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.NormalReportToolStripMenuItem.Text = "Normal Report"
        '
        'ControlBreakReportToolStripMenuItem
        '
        Me.ControlBreakReportToolStripMenuItem.Name = "ControlBreakReportToolStripMenuItem"
        Me.ControlBreakReportToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ControlBreakReportToolStripMenuItem.Text = "Control Break Report"
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
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 100
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 20
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Be cautious"
        '
        'frmBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 593)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.txtCusId)
        Me.Controls.Add(Me.picErrorField4)
        Me.Controls.Add(Me.picErrorField3)
        Me.Controls.Add(Me.picErrorField2)
        Me.Controls.Add(Me.picErrorField1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.lblCheckinDate)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtNumOfGuest)
        Me.Controls.Add(Me.lblNumOfGuest)
        Me.Controls.Add(Me.cbbRoomId)
        Me.Controls.Add(Me.txtNumOfDay)
        Me.Controls.Add(Me.lblNumOfDay)
        Me.Controls.Add(Me.lblCustomerId)
        Me.Controls.Add(Me.lblRoomId)
        Me.Controls.Add(Me.lblBookingDate)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking"
        CType(Me.picErrorField1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErrorField2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErrorField3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErrorField4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbbRoomId As System.Windows.Forms.ComboBox
    Friend WithEvents txtNumOfDay As System.Windows.Forms.TextBox
    Friend WithEvents lblNumOfDay As System.Windows.Forms.Label
    Friend WithEvents lblCustomerId As System.Windows.Forms.Label
    Friend WithEvents lblRoomId As System.Windows.Forms.Label
    Friend WithEvents lblBookingDate As System.Windows.Forms.Label
    Friend WithEvents txtNumOfGuest As System.Windows.Forms.TextBox
    Friend WithEvents lblNumOfGuest As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCheckinDate As System.Windows.Forms.Label
    Friend WithEvents txtTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents lblComment As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents picErrorField1 As System.Windows.Forms.PictureBox
    Friend WithEvents picErrorField2 As System.Windows.Forms.PictureBox
    Friend WithEvents picErrorField3 As System.Windows.Forms.PictureBox
    Friend WithEvents picErrorField4 As System.Windows.Forms.PictureBox
    Friend WithEvents txtCusId As System.Windows.Forms.TextBox
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents InvoiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NormalReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlBreakReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
