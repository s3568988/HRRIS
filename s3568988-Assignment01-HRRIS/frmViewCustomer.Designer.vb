<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewCustomer
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
        Me.DateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._s3568988_HRRIS_DatabaseDataSet1 = New s3568988_Assignment01_HRRIS._s3568988_HRRIS_DatabaseDataSet1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbbGender = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbbTitle = New System.Windows.Forms.ComboBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.picErrorField7 = New System.Windows.Forms.PictureBox()
        Me.picErrorField6 = New System.Windows.Forms.PictureBox()
        Me.picErrorField5 = New System.Windows.Forms.PictureBox()
        Me.picErrorField4 = New System.Windows.Forms.PictureBox()
        Me.picErrorField3 = New System.Windows.Forms.PictureBox()
        Me.picErrorField2 = New System.Windows.Forms.PictureBox()
        Me.picErrorField1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustomeridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerTableAdapter = New s3568988_Assignment01_HRRIS._s3568988_HRRIS_DatabaseDataSet1TableAdapters.customerTableAdapter()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCusId = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._s3568988_HRRIS_DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErrorField7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErrorField6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErrorField5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErrorField4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErrorField3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErrorField2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErrorField1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1267, 24)
        Me.MenuStrip1.TabIndex = 102
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
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Enabled = False
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
        'DateOfBirth
        '
        Me.DateOfBirth.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "dob", True))
        Me.DateOfBirth.Location = New System.Drawing.Point(84, 386)
        Me.DateOfBirth.Name = "DateOfBirth"
        Me.DateOfBirth.Size = New System.Drawing.Size(177, 20)
        Me.DateOfBirth.TabIndex = 84
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me._s3568988_HRRIS_DatabaseDataSet1
        '
        '_s3568988_HRRIS_DatabaseDataSet1
        '
        Me._s3568988_HRRIS_DatabaseDataSet1.DataSetName = "_s3568988_HRRIS_DatabaseDataSet1"
        Me._s3568988_HRRIS_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Title"
        '
        'cbbGender
        '
        Me.cbbGender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "gender", True))
        Me.cbbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbGender.FormattingEnabled = True
        Me.cbbGender.Items.AddRange(New Object() {"Male", "Female", "Others"})
        Me.cbbGender.Location = New System.Drawing.Point(84, 117)
        Me.cbbGender.Name = "cbbGender"
        Me.cbbGender.Size = New System.Drawing.Size(103, 21)
        Me.cbbGender.TabIndex = 78
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "First Name"
        '
        'cbbTitle
        '
        Me.cbbTitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "title", True))
        Me.cbbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbTitle.FormattingEnabled = True
        Me.cbbTitle.Items.AddRange(New Object() {"Ms.", "Mrs.", "Mr."})
        Me.cbbTitle.Location = New System.Drawing.Point(84, 81)
        Me.cbbTitle.Name = "cbbTitle"
        Me.cbbTitle.Size = New System.Drawing.Size(103, 21)
        Me.cbbTitle.TabIndex = 77
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "firstname", True))
        Me.txtFirstName.Location = New System.Drawing.Point(84, 158)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(177, 20)
        Me.txtFirstName.TabIndex = 79
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(31, 508)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(113, 23)
        Me.btnUpdate.TabIndex = 86
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "lastname", True))
        Me.txtLastName.Location = New System.Drawing.Point(84, 201)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(177, 20)
        Me.txtLastName.TabIndex = 80
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 386)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "DOB"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Phone"
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "email", True))
        Me.txtEmail.Location = New System.Drawing.Point(84, 335)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(177, 20)
        Me.txtEmail.TabIndex = 83
        '
        'txtPhone
        '
        Me.txtPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "phone", True))
        Me.txtPhone.Location = New System.Drawing.Point(84, 243)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(177, 20)
        Me.txtPhone.TabIndex = 81
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 338)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "address", True))
        Me.txtAddress.Location = New System.Drawing.Point(84, 288)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(177, 20)
        Me.txtAddress.TabIndex = 82
        '
        'picErrorField7
        '
        Me.picErrorField7.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField7.Location = New System.Drawing.Point(274, 120)
        Me.picErrorField7.Name = "picErrorField7"
        Me.picErrorField7.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField7.TabIndex = 101
        Me.picErrorField7.TabStop = False
        Me.picErrorField7.Visible = False
        '
        'picErrorField6
        '
        Me.picErrorField6.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField6.Location = New System.Drawing.Point(274, 81)
        Me.picErrorField6.Name = "picErrorField6"
        Me.picErrorField6.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField6.TabIndex = 100
        Me.picErrorField6.TabStop = False
        Me.picErrorField6.Visible = False
        '
        'picErrorField5
        '
        Me.picErrorField5.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField5.Location = New System.Drawing.Point(274, 334)
        Me.picErrorField5.Name = "picErrorField5"
        Me.picErrorField5.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField5.TabIndex = 99
        Me.picErrorField5.TabStop = False
        Me.picErrorField5.Visible = False
        '
        'picErrorField4
        '
        Me.picErrorField4.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField4.Location = New System.Drawing.Point(274, 284)
        Me.picErrorField4.Name = "picErrorField4"
        Me.picErrorField4.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField4.TabIndex = 98
        Me.picErrorField4.TabStop = False
        Me.picErrorField4.Visible = False
        '
        'picErrorField3
        '
        Me.picErrorField3.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField3.Location = New System.Drawing.Point(274, 243)
        Me.picErrorField3.Name = "picErrorField3"
        Me.picErrorField3.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField3.TabIndex = 97
        Me.picErrorField3.TabStop = False
        Me.picErrorField3.Visible = False
        '
        'picErrorField2
        '
        Me.picErrorField2.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField2.Location = New System.Drawing.Point(274, 201)
        Me.picErrorField2.Name = "picErrorField2"
        Me.picErrorField2.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField2.TabIndex = 96
        Me.picErrorField2.TabStop = False
        Me.picErrorField2.Visible = False
        '
        'picErrorField1
        '
        Me.picErrorField1.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField1.Location = New System.Drawing.Point(274, 158)
        Me.picErrorField1.Name = "picErrorField1"
        Me.picErrorField1.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField1.TabIndex = 95
        Me.picErrorField1.TabStop = False
        Me.picErrorField1.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomeridDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.DobDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(319, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(936, 325)
        Me.DataGridView1.TabIndex = 103
        '
        'CustomeridDataGridViewTextBoxColumn
        '
        Me.CustomeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.HeaderText = "customer_id"
        Me.CustomeridDataGridViewTextBoxColumn.Name = "CustomeridDataGridViewTextBoxColumn"
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        '
        'PhoneDataGridViewTextBoxColumn
        '
        Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "phone"
        Me.PhoneDataGridViewTextBoxColumn.HeaderText = "phone"
        Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'DobDataGridViewTextBoxColumn
        '
        Me.DobDataGridViewTextBoxColumn.DataPropertyName = "dob"
        Me.DobDataGridViewTextBoxColumn.HeaderText = "dob"
        Me.DobDataGridViewTextBoxColumn.Name = "DobDataGridViewTextBoxColumn"
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Customer ID"
        '
        'txtCusId
        '
        Me.txtCusId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "customer_id", True))
        Me.txtCusId.Location = New System.Drawing.Point(84, 43)
        Me.txtCusId.Name = "txtCusId"
        Me.txtCusId.Size = New System.Drawing.Size(177, 20)
        Me.txtCusId.TabIndex = 106
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(187, 508)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(113, 23)
        Me.btnDelete.TabIndex = 107
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(1133, 39)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(113, 23)
        Me.btnFilter.TabIndex = 108
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(319, 41)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(784, 20)
        Me.txtFilter.TabIndex = 109
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(31, 563)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(113, 23)
        Me.btnFind.TabIndex = 110
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(187, 563)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(113, 23)
        Me.btnClear.TabIndex = 111
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(256, 436)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(69, 23)
        Me.btnLast.TabIndex = 115
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(173, 436)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(69, 23)
        Me.btnNext.TabIndex = 114
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(93, 436)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(69, 23)
        Me.btnPrev.TabIndex = 113
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(11, 436)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(69, 23)
        Me.btnFirst.TabIndex = 112
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'frmViewCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1267, 609)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtCusId)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DateOfBirth)
        Me.Controls.Add(Me.picErrorField7)
        Me.Controls.Add(Me.picErrorField6)
        Me.Controls.Add(Me.picErrorField5)
        Me.Controls.Add(Me.picErrorField4)
        Me.Controls.Add(Me.picErrorField3)
        Me.Controls.Add(Me.picErrorField2)
        Me.Controls.Add(Me.picErrorField1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbbGender)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbbTitle)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAddress)
        Me.Name = "frmViewCustomer"
        Me.Text = "View Customer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._s3568988_HRRIS_DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErrorField7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErrorField6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErrorField5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErrorField4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErrorField3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErrorField2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErrorField1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents DateOfBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents picErrorField7 As System.Windows.Forms.PictureBox
    Friend WithEvents picErrorField6 As System.Windows.Forms.PictureBox
    Friend WithEvents picErrorField5 As System.Windows.Forms.PictureBox
    Friend WithEvents picErrorField4 As System.Windows.Forms.PictureBox
    Friend WithEvents picErrorField3 As System.Windows.Forms.PictureBox
    Friend WithEvents picErrorField2 As System.Windows.Forms.PictureBox
    Friend WithEvents picErrorField1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbbGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbbTitle As System.Windows.Forms.ComboBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents _s3568988_HRRIS_DatabaseDataSet1 As s3568988_Assignment01_HRRIS._s3568988_HRRIS_DatabaseDataSet1
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As s3568988_Assignment01_HRRIS._s3568988_HRRIS_DatabaseDataSet1TableAdapters.customerTableAdapter
    Friend WithEvents CustomeridDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCusId As System.Windows.Forms.TextBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrev As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
End Class
