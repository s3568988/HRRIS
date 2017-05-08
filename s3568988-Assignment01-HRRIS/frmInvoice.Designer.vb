<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoice
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
        Me.lblBookingId = New System.Windows.Forms.Label()
        Me.cbbBookingId = New System.Windows.Forms.ComboBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.picErrorField1 = New System.Windows.Forms.PictureBox()
        CType(Me.picErrorField1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBookingId
        '
        Me.lblBookingId.AutoSize = True
        Me.lblBookingId.Location = New System.Drawing.Point(24, 22)
        Me.lblBookingId.Name = "lblBookingId"
        Me.lblBookingId.Size = New System.Drawing.Size(60, 13)
        Me.lblBookingId.TabIndex = 0
        Me.lblBookingId.Text = "Booking ID"
        '
        'cbbBookingId
        '
        Me.cbbBookingId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbBookingId.FormattingEnabled = True
        Me.cbbBookingId.Location = New System.Drawing.Point(141, 19)
        Me.cbbBookingId.Name = "cbbBookingId"
        Me.cbbBookingId.Size = New System.Drawing.Size(200, 21)
        Me.cbbBookingId.TabIndex = 1
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(24, 87)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(24, 160)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(43, 13)
        Me.lblAmount.TabIndex = 3
        Me.lblAmount.Text = "Amount"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(141, 87)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtAmount.Location = New System.Drawing.Point(141, 160)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(200, 20)
        Me.txtAmount.TabIndex = 5
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(68, 247)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 6
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(244, 247)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'picErrorField1
        '
        Me.picErrorField1.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField1.Location = New System.Drawing.Point(365, 19)
        Me.picErrorField1.Name = "picErrorField1"
        Me.picErrorField1.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField1.TabIndex = 72
        Me.picErrorField1.TabStop = False
        Me.picErrorField1.Visible = False
        '
        'frmInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 308)
        Me.Controls.Add(Me.picErrorField1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.cbbBookingId)
        Me.Controls.Add(Me.lblBookingId)
        Me.MaximumSize = New System.Drawing.Size(450, 347)
        Me.MinimumSize = New System.Drawing.Size(450, 347)
        Me.Name = "frmInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice"
        CType(Me.picErrorField1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBookingId As System.Windows.Forms.Label
    Friend WithEvents cbbBookingId As System.Windows.Forms.ComboBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents picErrorField1 As System.Windows.Forms.PictureBox
End Class
