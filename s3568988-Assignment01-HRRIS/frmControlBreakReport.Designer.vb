<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlBreakReport
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
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.picErrorField2 = New System.Windows.Forms.PictureBox()
        Me.picErrorField1 = New System.Windows.Forms.PictureBox()
        Me.cbbMonth = New System.Windows.Forms.ComboBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.picErrorField2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picErrorField1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox8.Controls.Add(Me.Button8)
        Me.GroupBox8.Location = New System.Drawing.Point(16, 218)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(343, 181)
        Me.GroupBox8.TabIndex = 15
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "All invoice in the current year broken down by month"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(94, 119)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(104, 23)
        Me.Button8.TabIndex = 3
        Me.Button8.Text = "Generate"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox7.Controls.Add(Me.picErrorField2)
        Me.GroupBox7.Controls.Add(Me.picErrorField1)
        Me.GroupBox7.Controls.Add(Me.cbbMonth)
        Me.GroupBox7.Controls.Add(Me.txtYear)
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Controls.Add(Me.Button7)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Location = New System.Drawing.Point(16, 10)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(343, 189)
        Me.GroupBox7.TabIndex = 14
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Booking was made for a given time according to room number"
        '
        'picErrorField2
        '
        Me.picErrorField2.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField2.Location = New System.Drawing.Point(303, 73)
        Me.picErrorField2.Name = "picErrorField2"
        Me.picErrorField2.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField2.TabIndex = 71
        Me.picErrorField2.TabStop = False
        Me.picErrorField2.Visible = False
        '
        'picErrorField1
        '
        Me.picErrorField1.Image = Global.s3568988_Assignment01_HRRIS.My.Resources.Resources.Button_Close_icon
        Me.picErrorField1.Location = New System.Drawing.Point(303, 36)
        Me.picErrorField1.Name = "picErrorField1"
        Me.picErrorField1.Size = New System.Drawing.Size(25, 25)
        Me.picErrorField1.TabIndex = 70
        Me.picErrorField1.TabStop = False
        Me.picErrorField1.Visible = False
        '
        'cbbMonth
        '
        Me.cbbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbMonth.FormattingEnabled = True
        Me.cbbMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbbMonth.Location = New System.Drawing.Point(121, 36)
        Me.cbbMonth.Name = "cbbMonth"
        Me.cbbMonth.Size = New System.Drawing.Size(169, 21)
        Me.cbbMonth.TabIndex = 10
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(121, 76)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(169, 20)
        Me.txtYear.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Year"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(103, 137)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(104, 23)
        Me.Button7.TabIndex = 3
        Me.Button7.Text = "Generate"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Month"
        '
        'frmControlBreakReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 412)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Name = "frmControlBreakReport"
        Me.Text = "frmControlBreakReport"
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.picErrorField2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picErrorField1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents cbbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents picErrorField1 As System.Windows.Forms.PictureBox
    Friend WithEvents picErrorField2 As System.Windows.Forms.PictureBox
End Class
