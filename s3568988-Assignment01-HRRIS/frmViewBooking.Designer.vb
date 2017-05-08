<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewBooking
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
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.BookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._s3568988_HRRIS_DatabaseDataSet3 = New s3568988_Assignment01_HRRIS._s3568988_HRRIS_DatabaseDataSet3()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picErrorField4 = New System.Windows.Forms.PictureBox()
        Me.picErrorField3 = New System.Windows.Forms.PictureBox()
        Me.picErrorField2 = New System.Windows.Forms.PictureBox()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtCusId = New System.Windows.Forms.TextBox()
        Me.picErrorField1 = New System.Windows.Forms.PictureBox()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lblCheckinDate = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtNumOfGuest = New System.Windows.Forms.TextBox()
        Me.lblNumOfGuest = New System.Windows.Forms.Label()
        Me.cbbRoomId = New System.Windows.Forms.ComboBox()
        Me.txtNumOfDay = New System.Windows.Forms.TextBox()
        Me.lblNumOfDay = New System.Windows.Forms.Label()
        Me.lblCustomerId = New System.Windows.Forms.Label()
        Me.lblRoomId = New System.Windows.Forms.Label()
        Me.lblBookingDate = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BookingidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomeridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumdaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumguestsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckindateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookingTableAdapter = New s3568988_Assignment01_HRRIS._s3568988_HRRIS_DatabaseDataSet3TableAdapters.bookingTableAdapter()
        Me.txtBookingId = New System.Windows.Forms.TextBox()
        Me.lblBookingId = New System.Windows.Forms.Label()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._s3568988_HRRIS_DatabaseDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErrorField4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErrorField3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErrorField2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErrorField1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AboutUsToolStripMenuItem.Text = "About us"
        '
        'txtComments
        '
        Me.txtComments.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "comments", True))
        Me.txtComments.Location = New System.Drawing.Point(121, 430)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(202, 56)
        Me.txtComments.TabIndex = 97
        '
        'BookingBindingSource
        '
        Me.BookingBindingSource.DataMember = "booking"
        Me.BookingBindingSource.DataSource = Me._s3568988_HRRIS_DatabaseDataSet3
        '
        '_s3568988_HRRIS_DatabaseDataSet3
        '
        Me._s3568988_HRRIS_DatabaseDataSet3.DataSetName = "_s3568988_HRRIS_DatabaseDataSet3"
        Me._s3568988_HRRIS_DatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ViewHelpToolStripMenuItem.Text = "View help"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
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
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.AboutUsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'RoomToolStripMenuItem
        '
        Me.RoomToolStripMenuItem.Name = "RoomToolStripMenuItem"
        Me.RoomToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.RoomToolStripMenuItem.Text = "Room"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem, Me.RoomToolStripMenuItem, Me.BookingToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'BookingToolStripMenuItem
        '
        Me.BookingToolStripMenuItem.Enabled = False
        Me.BookingToolStripMenuItem.Name = "BookingToolStripMenuItem"
        Me.BookingToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.BookingToolStripMenuItem.Text = "Booking"
        '
        'picErrorField4
        '
        Me.picErrorField4.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField4.Location = New System.Drawing.Point(329, 259)
        Me.picErrorField4.Name = "picErrorField4"
        Me.picErrorField4.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField4.TabIndex = 95
        Me.picErrorField4.TabStop = False
        Me.picErrorField4.Visible = False
        '
        'picErrorField3
        '
        Me.picErrorField3.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField3.Location = New System.Drawing.Point(329, 211)
        Me.picErrorField3.Name = "picErrorField3"
        Me.picErrorField3.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField3.TabIndex = 94
        Me.picErrorField3.TabStop = False
        Me.picErrorField3.Visible = False
        '
        'picErrorField2
        '
        Me.picErrorField2.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField2.Location = New System.Drawing.Point(329, 162)
        Me.picErrorField2.Name = "picErrorField2"
        Me.picErrorField2.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField2.TabIndex = 93
        Me.picErrorField2.TabStop = False
        Me.picErrorField2.Visible = False
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'txtCusId
        '
        Me.txtCusId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "customer_id", True))
        Me.txtCusId.Location = New System.Drawing.Point(121, 171)
        Me.txtCusId.Name = "txtCusId"
        Me.txtCusId.Size = New System.Drawing.Size(202, 20)
        Me.txtCusId.TabIndex = 96
        '
        'picErrorField1
        '
        Me.picErrorField1.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField1.Location = New System.Drawing.Point(329, 115)
        Me.picErrorField1.Name = "picErrorField1"
        Me.picErrorField1.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField1.TabIndex = 92
        Me.picErrorField1.TabStop = False
        Me.picErrorField1.Visible = False
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Location = New System.Drawing.Point(21, 433)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(51, 13)
        Me.lblComment.TabIndex = 89
        Me.lblComment.Text = "Comment"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtTotalPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "total_price", True))
        Me.txtTotalPrice.Location = New System.Drawing.Point(121, 376)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(202, 20)
        Me.txtTotalPrice.TabIndex = 88
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Location = New System.Drawing.Point(21, 380)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalPrice.TabIndex = 87
        Me.lblTotalPrice.Text = "Total Price"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "checkin_date", True))
        Me.DateTimePicker2.Location = New System.Drawing.Point(121, 323)
        Me.DateTimePicker2.MinDate = New Date(2017, 3, 31, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(202, 20)
        Me.DateTimePicker2.TabIndex = 86
        '
        'lblCheckinDate
        '
        Me.lblCheckinDate.AutoSize = True
        Me.lblCheckinDate.Location = New System.Drawing.Point(21, 323)
        Me.lblCheckinDate.Name = "lblCheckinDate"
        Me.lblCheckinDate.Size = New System.Drawing.Size(75, 13)
        Me.lblCheckinDate.TabIndex = 85
        Me.lblCheckinDate.Text = "Check in Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "booking_date", True))
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(121, 85)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(202, 20)
        Me.DateTimePicker1.TabIndex = 84
        '
        'txtNumOfGuest
        '
        Me.txtNumOfGuest.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "num_guests", True))
        Me.txtNumOfGuest.Location = New System.Drawing.Point(121, 269)
        Me.txtNumOfGuest.Name = "txtNumOfGuest"
        Me.txtNumOfGuest.Size = New System.Drawing.Size(202, 20)
        Me.txtNumOfGuest.TabIndex = 83
        '
        'lblNumOfGuest
        '
        Me.lblNumOfGuest.AutoSize = True
        Me.lblNumOfGuest.Location = New System.Drawing.Point(21, 272)
        Me.lblNumOfGuest.Name = "lblNumOfGuest"
        Me.lblNumOfGuest.Size = New System.Drawing.Size(90, 13)
        Me.lblNumOfGuest.TabIndex = 82
        Me.lblNumOfGuest.Text = "Number of guests"
        '
        'cbbRoomId
        '
        Me.cbbRoomId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "room_id", True))
        Me.cbbRoomId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbRoomId.FormattingEnabled = True
        Me.cbbRoomId.Location = New System.Drawing.Point(121, 124)
        Me.cbbRoomId.Name = "cbbRoomId"
        Me.cbbRoomId.Size = New System.Drawing.Size(105, 21)
        Me.cbbRoomId.TabIndex = 81
        '
        'txtNumOfDay
        '
        Me.txtNumOfDay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "num_days", True))
        Me.txtNumOfDay.Location = New System.Drawing.Point(121, 221)
        Me.txtNumOfDay.Name = "txtNumOfDay"
        Me.txtNumOfDay.Size = New System.Drawing.Size(202, 20)
        Me.txtNumOfDay.TabIndex = 80
        '
        'lblNumOfDay
        '
        Me.lblNumOfDay.AutoSize = True
        Me.lblNumOfDay.Location = New System.Drawing.Point(21, 224)
        Me.lblNumOfDay.Name = "lblNumOfDay"
        Me.lblNumOfDay.Size = New System.Drawing.Size(81, 13)
        Me.lblNumOfDay.TabIndex = 79
        Me.lblNumOfDay.Text = "Number of days"
        '
        'lblCustomerId
        '
        Me.lblCustomerId.AutoSize = True
        Me.lblCustomerId.Location = New System.Drawing.Point(21, 174)
        Me.lblCustomerId.Name = "lblCustomerId"
        Me.lblCustomerId.Size = New System.Drawing.Size(65, 13)
        Me.lblCustomerId.TabIndex = 78
        Me.lblCustomerId.Text = "Customer ID"
        '
        'lblRoomId
        '
        Me.lblRoomId.AutoSize = True
        Me.lblRoomId.Location = New System.Drawing.Point(21, 127)
        Me.lblRoomId.Name = "lblRoomId"
        Me.lblRoomId.Size = New System.Drawing.Size(75, 13)
        Me.lblRoomId.TabIndex = 77
        Me.lblRoomId.Text = "Room Number"
        '
        'lblBookingDate
        '
        Me.lblBookingDate.AutoSize = True
        Me.lblBookingDate.Location = New System.Drawing.Point(21, 85)
        Me.lblBookingDate.Name = "lblBookingDate"
        Me.lblBookingDate.Size = New System.Drawing.Size(72, 13)
        Me.lblBookingDate.TabIndex = 76
        Me.lblBookingDate.Text = "Booking Date"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1284, 24)
        Me.MenuStrip1.TabIndex = 98
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookingidDataGridViewTextBoxColumn, Me.BookingdateDataGridViewTextBoxColumn, Me.RoomidDataGridViewTextBoxColumn, Me.CustomeridDataGridViewTextBoxColumn, Me.NumdaysDataGridViewTextBoxColumn, Me.NumguestsDataGridViewTextBoxColumn, Me.CheckindateDataGridViewTextBoxColumn, Me.TotalpriceDataGridViewTextBoxColumn, Me.CommentsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BookingBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(370, 85)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(907, 361)
        Me.DataGridView1.TabIndex = 99
        '
        'BookingidDataGridViewTextBoxColumn
        '
        Me.BookingidDataGridViewTextBoxColumn.DataPropertyName = "booking_id"
        Me.BookingidDataGridViewTextBoxColumn.HeaderText = "booking_id"
        Me.BookingidDataGridViewTextBoxColumn.Name = "BookingidDataGridViewTextBoxColumn"
        '
        'BookingdateDataGridViewTextBoxColumn
        '
        Me.BookingdateDataGridViewTextBoxColumn.DataPropertyName = "booking_date"
        Me.BookingdateDataGridViewTextBoxColumn.HeaderText = "booking_date"
        Me.BookingdateDataGridViewTextBoxColumn.Name = "BookingdateDataGridViewTextBoxColumn"
        '
        'RoomidDataGridViewTextBoxColumn
        '
        Me.RoomidDataGridViewTextBoxColumn.DataPropertyName = "room_id"
        Me.RoomidDataGridViewTextBoxColumn.HeaderText = "room_id"
        Me.RoomidDataGridViewTextBoxColumn.Name = "RoomidDataGridViewTextBoxColumn"
        '
        'CustomeridDataGridViewTextBoxColumn
        '
        Me.CustomeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.HeaderText = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.Name = "CustomeridDataGridViewTextBoxColumn"
        '
        'NumdaysDataGridViewTextBoxColumn
        '
        Me.NumdaysDataGridViewTextBoxColumn.DataPropertyName = "num_days"
        Me.NumdaysDataGridViewTextBoxColumn.HeaderText = "num_days"
        Me.NumdaysDataGridViewTextBoxColumn.Name = "NumdaysDataGridViewTextBoxColumn"
        '
        'NumguestsDataGridViewTextBoxColumn
        '
        Me.NumguestsDataGridViewTextBoxColumn.DataPropertyName = "num_guests"
        Me.NumguestsDataGridViewTextBoxColumn.HeaderText = "num_guests"
        Me.NumguestsDataGridViewTextBoxColumn.Name = "NumguestsDataGridViewTextBoxColumn"
        '
        'CheckindateDataGridViewTextBoxColumn
        '
        Me.CheckindateDataGridViewTextBoxColumn.DataPropertyName = "checkin_date"
        Me.CheckindateDataGridViewTextBoxColumn.HeaderText = "checkin_date"
        Me.CheckindateDataGridViewTextBoxColumn.Name = "CheckindateDataGridViewTextBoxColumn"
        '
        'TotalpriceDataGridViewTextBoxColumn
        '
        Me.TotalpriceDataGridViewTextBoxColumn.DataPropertyName = "total_price"
        Me.TotalpriceDataGridViewTextBoxColumn.HeaderText = "total_price"
        Me.TotalpriceDataGridViewTextBoxColumn.Name = "TotalpriceDataGridViewTextBoxColumn"
        '
        'CommentsDataGridViewTextBoxColumn
        '
        Me.CommentsDataGridViewTextBoxColumn.DataPropertyName = "comments"
        Me.CommentsDataGridViewTextBoxColumn.HeaderText = "comments"
        Me.CommentsDataGridViewTextBoxColumn.Name = "CommentsDataGridViewTextBoxColumn"
        '
        'BookingTableAdapter
        '
        Me.BookingTableAdapter.ClearBeforeFill = True
        '
        'txtBookingId
        '
        Me.txtBookingId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookingBindingSource, "booking_id", True))
        Me.txtBookingId.Location = New System.Drawing.Point(122, 39)
        Me.txtBookingId.Name = "txtBookingId"
        Me.txtBookingId.Size = New System.Drawing.Size(202, 20)
        Me.txtBookingId.TabIndex = 101
        '
        'lblBookingId
        '
        Me.lblBookingId.AutoSize = True
        Me.lblBookingId.Location = New System.Drawing.Point(22, 42)
        Me.lblBookingId.Name = "lblBookingId"
        Me.lblBookingId.Size = New System.Drawing.Size(60, 13)
        Me.lblBookingId.TabIndex = 100
        Me.lblBookingId.Text = "Booking ID"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(285, 513)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(69, 23)
        Me.btnLast.TabIndex = 119
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(202, 513)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(69, 23)
        Me.btnNext.TabIndex = 118
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(122, 513)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(69, 23)
        Me.btnPrev.TabIndex = 117
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(40, 513)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(69, 23)
        Me.btnFirst.TabIndex = 116
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(370, 39)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(768, 20)
        Me.txtFilter.TabIndex = 121
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(1169, 37)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(105, 23)
        Me.btnFilter.TabIndex = 120
        Me.btnFilter.Text = "Search"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(277, 564)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(77, 23)
        Me.btnClear.TabIndex = 125
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(160, 564)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 23)
        Me.btnDelete.TabIndex = 123
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(40, 564)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(83, 23)
        Me.btnUpdate.TabIndex = 122
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'frmViewBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 672)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.txtBookingId)
        Me.Controls.Add(Me.lblBookingId)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.picErrorField4)
        Me.Controls.Add(Me.picErrorField3)
        Me.Controls.Add(Me.picErrorField2)
        Me.Controls.Add(Me.txtCusId)
        Me.Controls.Add(Me.picErrorField1)
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
        Me.MaximumSize = New System.Drawing.Size(1400, 710)
        Me.MinimumSize = New System.Drawing.Size(1278, 710)
        Me.Name = "frmViewBooking"
        Me.Text = "View Booking"
        CType(Me.BookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._s3568988_HRRIS_DatabaseDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErrorField4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErrorField3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErrorField2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErrorField1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AboutUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents ViewHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picErrorField4 As System.Windows.Forms.PictureBox
    Friend WithEvents picErrorField3 As System.Windows.Forms.PictureBox
    Friend WithEvents picErrorField2 As System.Windows.Forms.PictureBox
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtCusId As System.Windows.Forms.TextBox
    Friend WithEvents picErrorField1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblComment As System.Windows.Forms.Label
    Friend WithEvents txtTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCheckinDate As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNumOfGuest As System.Windows.Forms.TextBox
    Friend WithEvents lblNumOfGuest As System.Windows.Forms.Label
    Friend WithEvents cbbRoomId As System.Windows.Forms.ComboBox
    Friend WithEvents txtNumOfDay As System.Windows.Forms.TextBox
    Friend WithEvents lblNumOfDay As System.Windows.Forms.Label
    Friend WithEvents lblCustomerId As System.Windows.Forms.Label
    Friend WithEvents lblRoomId As System.Windows.Forms.Label
    Friend WithEvents lblBookingDate As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents _s3568988_HRRIS_DatabaseDataSet3 As s3568988_Assignment01_HRRIS._s3568988_HRRIS_DatabaseDataSet3
    Friend WithEvents BookingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BookingTableAdapter As s3568988_Assignment01_HRRIS._s3568988_HRRIS_DatabaseDataSet3TableAdapters.bookingTableAdapter
    Friend WithEvents BookingidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookingdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomeridDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumdaysDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumguestsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckindateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalpriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommentsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtBookingId As System.Windows.Forms.TextBox
    Friend WithEvents lblBookingId As System.Windows.Forms.Label
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
End Class
