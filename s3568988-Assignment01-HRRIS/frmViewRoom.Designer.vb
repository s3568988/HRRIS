<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewRoom
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
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picErrorField5 = New System.Windows.Forms.PictureBox()
        Me.picErrorField4 = New System.Windows.Forms.PictureBox()
        Me.picErrorField3 = New System.Windows.Forms.PictureBox()
        Me.picErrorField2 = New System.Windows.Forms.PictureBox()
        Me.picErrorField1 = New System.Windows.Forms.PictureBox()
        Me.cbAvailability = New System.Windows.Forms.CheckBox()
        Me.RoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._s3568988_HRRIS_DatabaseDataSet2 = New s3568988_Assignment01_HRRIS._s3568988_HRRIS_DatabaseDataSet2()
        Me.cbbType = New System.Windows.Forms.ComboBox()
        Me.txtDescription = New System.Windows.Forms.RichTextBox()
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
        Me.RoomDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RoomidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomnumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumbedsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvailabilityDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FloorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomTableAdapter = New s3568988_Assignment01_HRRIS._s3568988_HRRIS_DatabaseDataSet2TableAdapters.roomTableAdapter()
        Me.txtRoomId = New System.Windows.Forms.TextBox()
        Me.lblRoomId = New System.Windows.Forms.Label()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picErrorField5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErrorField4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErrorField3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErrorField2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErrorField1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._s3568988_HRRIS_DatabaseDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1266, 24)
        Me.MenuStrip1.TabIndex = 98
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
        'RoomToolStripMenuItem
        '
        Me.RoomToolStripMenuItem.Enabled = False
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
        'picErrorField5
        '
        Me.picErrorField5.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField5.Location = New System.Drawing.Point(347, 360)
        Me.picErrorField5.Name = "picErrorField5"
        Me.picErrorField5.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField5.TabIndex = 97
        Me.picErrorField5.TabStop = False
        Me.picErrorField5.Visible = False
        '
        'picErrorField4
        '
        Me.picErrorField4.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField4.Location = New System.Drawing.Point(347, 254)
        Me.picErrorField4.Name = "picErrorField4"
        Me.picErrorField4.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField4.TabIndex = 96
        Me.picErrorField4.TabStop = False
        Me.picErrorField4.Visible = False
        '
        'picErrorField3
        '
        Me.picErrorField3.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField3.Location = New System.Drawing.Point(347, 203)
        Me.picErrorField3.Name = "picErrorField3"
        Me.picErrorField3.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField3.TabIndex = 95
        Me.picErrorField3.TabStop = False
        Me.picErrorField3.Visible = False
        '
        'picErrorField2
        '
        Me.picErrorField2.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField2.Location = New System.Drawing.Point(347, 155)
        Me.picErrorField2.Name = "picErrorField2"
        Me.picErrorField2.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField2.TabIndex = 94
        Me.picErrorField2.TabStop = False
        Me.picErrorField2.Visible = False
        '
        'picErrorField1
        '
        Me.picErrorField1.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField1.Location = New System.Drawing.Point(347, 116)
        Me.picErrorField1.Name = "picErrorField1"
        Me.picErrorField1.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField1.TabIndex = 93
        Me.picErrorField1.TabStop = False
        Me.picErrorField1.Visible = False
        '
        'cbAvailability
        '
        Me.cbAvailability.AutoSize = True
        Me.cbAvailability.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "availability", True))
        Me.cbAvailability.Location = New System.Drawing.Point(114, 315)
        Me.cbAvailability.Name = "cbAvailability"
        Me.cbAvailability.Size = New System.Drawing.Size(15, 14)
        Me.cbAvailability.TabIndex = 6
        Me.cbAvailability.UseVisualStyleBackColor = True
        '
        'RoomBindingSource
        '
        Me.RoomBindingSource.DataMember = "room"
        Me.RoomBindingSource.DataSource = Me._s3568988_HRRIS_DatabaseDataSet2
        '
        '_s3568988_HRRIS_DatabaseDataSet2
        '
        Me._s3568988_HRRIS_DatabaseDataSet2.DataSetName = "_s3568988_HRRIS_DatabaseDataSet2"
        Me._s3568988_HRRIS_DatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbbType
        '
        Me.cbbType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "type", True))
        Me.cbbType.FormattingEnabled = True
        Me.cbbType.Items.AddRange(New Object() {"Standard", "Deluxe"})
        Me.cbbType.Location = New System.Drawing.Point(114, 159)
        Me.cbbType.Name = "cbbType"
        Me.cbbType.Size = New System.Drawing.Size(105, 21)
        Me.cbbType.TabIndex = 3
        '
        'txtDescription
        '
        Me.txtDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "description", True))
        Me.txtDescription.Location = New System.Drawing.Point(114, 419)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(202, 88)
        Me.txtDescription.TabIndex = 8
        Me.txtDescription.Text = ""
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(14, 422)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 87
        Me.lblDescription.Text = "Description"
        '
        'txtFloor
        '
        Me.txtFloor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "floor", True))
        Me.txtFloor.Location = New System.Drawing.Point(114, 365)
        Me.txtFloor.Name = "txtFloor"
        Me.txtFloor.Size = New System.Drawing.Size(202, 20)
        Me.txtFloor.TabIndex = 7
        '
        'lblFloor
        '
        Me.lblFloor.AutoSize = True
        Me.lblFloor.Location = New System.Drawing.Point(14, 368)
        Me.lblFloor.Name = "lblFloor"
        Me.lblFloor.Size = New System.Drawing.Size(30, 13)
        Me.lblFloor.TabIndex = 85
        Me.lblFloor.Text = "Floor"
        '
        'lblAvailability
        '
        Me.lblAvailability.AutoSize = True
        Me.lblAvailability.Location = New System.Drawing.Point(14, 315)
        Me.lblAvailability.Name = "lblAvailability"
        Me.lblAvailability.Size = New System.Drawing.Size(56, 13)
        Me.lblAvailability.TabIndex = 84
        Me.lblAvailability.Text = "Availability"
        '
        'txtNumOfBed
        '
        Me.txtNumOfBed.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "num_beds", True))
        Me.txtNumOfBed.Location = New System.Drawing.Point(114, 259)
        Me.txtNumOfBed.Name = "txtNumOfBed"
        Me.txtNumOfBed.Size = New System.Drawing.Size(202, 20)
        Me.txtNumOfBed.TabIndex = 5
        '
        'lblNumOfBed
        '
        Me.lblNumOfBed.AutoSize = True
        Me.lblNumOfBed.Location = New System.Drawing.Point(14, 262)
        Me.lblNumOfBed.Name = "lblNumOfBed"
        Me.lblNumOfBed.Size = New System.Drawing.Size(82, 13)
        Me.lblNumOfBed.TabIndex = 82
        Me.lblNumOfBed.Text = "Number of beds"
        '
        'txtPrice
        '
        Me.txtPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "price", True))
        Me.txtPrice.Location = New System.Drawing.Point(114, 208)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(202, 20)
        Me.txtPrice.TabIndex = 4
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(14, 211)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblPrice.TabIndex = 80
        Me.lblPrice.Text = "Price"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(14, 162)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(31, 13)
        Me.lblType.TabIndex = 79
        Me.lblType.Text = "Type"
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "room_number", True))
        Me.txtRoomNumber.Location = New System.Drawing.Point(114, 116)
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.Size = New System.Drawing.Size(202, 20)
        Me.txtRoomNumber.TabIndex = 2
        '
        'lblRoomNumber
        '
        Me.lblRoomNumber.AutoSize = True
        Me.lblRoomNumber.Location = New System.Drawing.Point(14, 119)
        Me.lblRoomNumber.Name = "lblRoomNumber"
        Me.lblRoomNumber.Size = New System.Drawing.Size(73, 13)
        Me.lblRoomNumber.TabIndex = 77
        Me.lblRoomNumber.Text = "Room number"
        '
        'RoomDataGridView1
        '
        Me.RoomDataGridView1.AutoGenerateColumns = False
        Me.RoomDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RoomDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoomidDataGridViewTextBoxColumn, Me.RoomnumberDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.NumbedsDataGridViewTextBoxColumn, Me.AvailabilityDataGridViewCheckBoxColumn, Me.FloorDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.RoomDataGridView1.DataSource = Me.RoomBindingSource
        Me.RoomDataGridView1.Location = New System.Drawing.Point(410, 116)
        Me.RoomDataGridView1.Name = "RoomDataGridView1"
        Me.RoomDataGridView1.Size = New System.Drawing.Size(844, 391)
        Me.RoomDataGridView1.TabIndex = 99
        '
        'RoomidDataGridViewTextBoxColumn
        '
        Me.RoomidDataGridViewTextBoxColumn.DataPropertyName = "room_id"
        Me.RoomidDataGridViewTextBoxColumn.HeaderText = "room_id"
        Me.RoomidDataGridViewTextBoxColumn.Name = "RoomidDataGridViewTextBoxColumn"
        '
        'RoomnumberDataGridViewTextBoxColumn
        '
        Me.RoomnumberDataGridViewTextBoxColumn.DataPropertyName = "room_number"
        Me.RoomnumberDataGridViewTextBoxColumn.HeaderText = "room_number"
        Me.RoomnumberDataGridViewTextBoxColumn.Name = "RoomnumberDataGridViewTextBoxColumn"
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'NumbedsDataGridViewTextBoxColumn
        '
        Me.NumbedsDataGridViewTextBoxColumn.DataPropertyName = "num_beds"
        Me.NumbedsDataGridViewTextBoxColumn.HeaderText = "num_beds"
        Me.NumbedsDataGridViewTextBoxColumn.Name = "NumbedsDataGridViewTextBoxColumn"
        '
        'AvailabilityDataGridViewCheckBoxColumn
        '
        Me.AvailabilityDataGridViewCheckBoxColumn.DataPropertyName = "availability"
        Me.AvailabilityDataGridViewCheckBoxColumn.HeaderText = "availability"
        Me.AvailabilityDataGridViewCheckBoxColumn.Name = "AvailabilityDataGridViewCheckBoxColumn"
        '
        'FloorDataGridViewTextBoxColumn
        '
        Me.FloorDataGridViewTextBoxColumn.DataPropertyName = "floor"
        Me.FloorDataGridViewTextBoxColumn.HeaderText = "floor"
        Me.FloorDataGridViewTextBoxColumn.Name = "FloorDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'RoomTableAdapter
        '
        Me.RoomTableAdapter.ClearBeforeFill = True
        '
        'txtRoomId
        '
        Me.txtRoomId.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtRoomId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RoomBindingSource, "room_id", True))
        Me.txtRoomId.Location = New System.Drawing.Point(114, 70)
        Me.txtRoomId.Name = "txtRoomId"
        Me.txtRoomId.ReadOnly = True
        Me.txtRoomId.Size = New System.Drawing.Size(202, 20)
        Me.txtRoomId.TabIndex = 1
        '
        'lblRoomId
        '
        Me.lblRoomId.AutoSize = True
        Me.lblRoomId.Location = New System.Drawing.Point(14, 73)
        Me.lblRoomId.Name = "lblRoomId"
        Me.lblRoomId.Size = New System.Drawing.Size(49, 13)
        Me.lblRoomId.TabIndex = 100
        Me.lblRoomId.Text = "Room ID"
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(272, 556)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(69, 23)
        Me.btnLast.TabIndex = 123
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(189, 556)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(69, 23)
        Me.btnNext.TabIndex = 122
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(109, 556)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(69, 23)
        Me.btnPrev.TabIndex = 121
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(27, 556)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(69, 23)
        Me.btnFirst.TabIndex = 120
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(207, 628)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(92, 23)
        Me.btnDelete.TabIndex = 117
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(66, 628)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(83, 23)
        Me.btnUpdate.TabIndex = 116
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(410, 70)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(707, 20)
        Me.txtFilter.TabIndex = 125
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(1141, 68)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(113, 23)
        Me.btnFilter.TabIndex = 124
        Me.btnFilter.Text = "Search"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'frmViewRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1266, 741)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtRoomId)
        Me.Controls.Add(Me.lblRoomId)
        Me.Controls.Add(Me.RoomDataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.picErrorField5)
        Me.Controls.Add(Me.picErrorField4)
        Me.Controls.Add(Me.picErrorField3)
        Me.Controls.Add(Me.picErrorField2)
        Me.Controls.Add(Me.picErrorField1)
        Me.Controls.Add(Me.cbAvailability)
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
        Me.Name = "frmViewRoom"
        Me.Text = "View Room"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picErrorField5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErrorField4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErrorField3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErrorField2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErrorField1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._s3568988_HRRIS_DatabaseDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picErrorField5 As System.Windows.Forms.PictureBox
    Friend WithEvents picErrorField4 As System.Windows.Forms.PictureBox
    Friend WithEvents picErrorField3 As System.Windows.Forms.PictureBox
    Friend WithEvents picErrorField2 As System.Windows.Forms.PictureBox
    Friend WithEvents picErrorField1 As System.Windows.Forms.PictureBox
    Friend WithEvents cbAvailability As System.Windows.Forms.CheckBox
    Friend WithEvents cbbType As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtFloor As System.Windows.Forms.TextBox
    Friend WithEvents lblFloor As System.Windows.Forms.Label
    Friend WithEvents lblAvailability As System.Windows.Forms.Label
    Friend WithEvents txtNumOfBed As System.Windows.Forms.TextBox
    Friend WithEvents lblNumOfBed As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents txtRoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblRoomNumber As System.Windows.Forms.Label
    Friend WithEvents RoomDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents _s3568988_HRRIS_DatabaseDataSet2 As s3568988_Assignment01_HRRIS._s3568988_HRRIS_DatabaseDataSet2
    Friend WithEvents RoomBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RoomTableAdapter As s3568988_Assignment01_HRRIS._s3568988_HRRIS_DatabaseDataSet2TableAdapters.roomTableAdapter
    Friend WithEvents RoomidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomnumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumbedsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AvailabilityDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FloorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtRoomId As System.Windows.Forms.TextBox
    Friend WithEvents lblRoomId As System.Windows.Forms.Label
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents btnFilter As System.Windows.Forms.Button
End Class
