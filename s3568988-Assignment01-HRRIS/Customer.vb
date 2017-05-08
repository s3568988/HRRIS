Option Explicit On
Option Strict On

Imports System.Drawing

Imports System.Data.OleDb
Imports System.IO

' Name:        Validation.vb
' Description: Form Customer
' Author:      To Quang Khai
' Date:        26/03/2017 

Public Class frmCustomer
    'Open a connection to the database
    Public Const CONNECTION_STRING As String = _
"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=s3568988-HRRIS-Database.accdb"

    Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)


    

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click


        'validation
        Dim oValidation As New Validation
        Dim emptyValid As Boolean = True
        Dim bAllFieldsValid As Boolean = True
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim picError() As PictureBox
        Dim picError2() As PictureBox
        Dim picError3() As PictureBox
        Dim txtError() As TextBox
        Dim cbbError() As ComboBox
        Dim nameError() As TextBox
        picError = New PictureBox() {picErrorField1, picErrorField2, picErrorField3, picErrorField4, picErrorField5}
        txtError = New TextBox() {txtFirstName, txtLastName, txtPhone, txtAddress, txtEmail}
        cbbError = New ComboBox() {cbbTitle, cbbGender}
        picError2 = New PictureBox() {picErrorField6, picErrorField7}
        nameError = New TextBox() {txtFirstName, txtLastName}
        picError3 = New PictureBox() {picErrorField1, picErrorField2}

        Try

            For iCounter As Integer = 0 To (picError.Length - 1)

                If String.IsNullOrEmpty(txtError(iCounter).Text) Then
                    'MessageBox.Show("Do not leave this blank")
                    emptyValid = False
                    picError(iCounter).Visible = True

                End If
            Next

            For iCounter3 As Integer = 0 To (nameError.Length - 1)
                If Not oValidation.isAlphaVal(nameError(iCounter3).Text) = True Then
                    'MessageBox.Show("Value is invalid")
                    bAllFieldsValid = False
                    picError3(iCounter3).Visible = True
                End If
            Next

            If Not IsNumeric(txtPhone.Text) = True Then
                bAllFieldsValid = False
                picErrorField3.Visible = True
            End If

            If Not oValidation.isAlphaNumericVal(txtAddress.Text) = True Then
                bAllFieldsValid = False
                picErrorField4.Visible = True
            End If

            If Not oValidation.IsEmail(txtEmail.Text) = True Then
                bAllFieldsValid = False
                picErrorField5.Visible = True
            End If

            For iCounter2 As Integer = 0 To (picError2.Length - 1)

                If String.IsNullOrEmpty(cbbError(iCounter2).Text) Then
                    'MessageBox.Show("Do not leave this blank")
                    emptyValid = False
                    picError2(iCounter2).Visible = True
                End If
            Next


            If emptyValid = False Then
                MessageBox.Show("Do not leave this blank")

            ElseIf bAllFieldsValid = False Then
                MessageBox.Show("Value is invalid")
            End If


            If bAllFieldsValid And emptyValid Then

                Debug.Print("Connection string: " & oConnection.ConnectionString)

                oConnection.Open()
                Dim oCommand As OleDbCommand = New OleDbCommand
                oCommand.Connection = oConnection

                Dim htData As Hashtable = New Hashtable
                htData("title") = cbbTitle.Text
                htData("gender") = cbbGender.Text
                htData("firstName") = txtFirstName.Text
                htData("lastName") = txtLastName.Text
                htData("phone") = txtPhone.Text
                htData("address") = txtAddress.Text
                htData("email") = txtEmail.Text
                htData("dob") = Format(DateOfBirth.Value, "dd/MM/yyyy")


                Dim cusController As Controller = New Controller
                cusController.customerController(htData)

               
                MessageBox.Show("The record was inserted.")

            Else : Debug.Print("One of the fields was invalid")

            End If

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. The record wasn't inserted.")
        Finally
            oConnection.Close()
        End Try

        ''clear out the datasource for the Grid view
        'Me.DataGridView1.DataSource = Nothing
        ''refill the table adapter from the dataset table 
        'Me.CustomerTableAdapter.Fill(Me._s3568988_HRRIS_DatabaseDataSet.customer)
        ''reset the datasource from the binding source
        'Me.DataGridView1.DataSource = Me.CustomerBindingSource
        ''should redraw with the new data
        'Me.DataGridView1.Refresh()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_s3568988_HRRIS_DatabaseDataSet.customer' table. You can move, or remove it, as needed.
        'fill in the table adapter from the dataset table
        'Me.CustomerTableAdapter.Fill(Me._s3568988_HRRIS_DatabaseDataSet.customer)

        'cbbTitle.SelectedIndex = -1
        'cbbGender.SelectedIndex = -1
        'txtFirstName.Clear()
        'txtLastName.Clear()
        'txtPhone.Clear()
        'txtAddress.Clear()
        'txtEmail.Clear()
        'DateOfBirth.Format = DateTimePickerFormat.Custom
        'DateOfBirth.CustomFormat = "    "
    End Sub

    Private Sub txtFirstName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstName.TextChanged
        picErrorField1.Visible = False
    End Sub

    
    Private Sub txtLastName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLastName.TextChanged
        picErrorField2.Visible = False
    End Sub

    Private Sub txtPhone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhone.TextChanged
        picErrorField3.Visible = False
    End Sub

    Private Sub txtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress.TextChanged
        picErrorField4.Visible = False
    End Sub

    Private Sub txtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.TextChanged
        picErrorField5.Visible = False
    End Sub

    Private Sub cbbTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbTitle.SelectedIndexChanged
        picErrorField6.Visible = False
    End Sub

    Private Sub cbbGender_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbGender.SelectedIndexChanged
        picErrorField7.Visible = False
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim index As Integer
        'index = e.RowIndex
        'Dim newDataRow As DataGridViewRow
        'newDataRow = DataGridView1.Rows(index)
        'newDataRow.Cells(0).Value=


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)


    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'Dim index As Integer
        'index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = DataGridView1.Rows(index)

        'cbbGender.Text = selectedRow.Cells(0).Value.ToString()
        'cbbTitle.Text = selectedRow.Cells(1).Value.ToString()
        'txtFirstName.Text = selectedRow.Cells(2).Value.ToString()
        'txtLastName.Text = selectedRow.Cells(3).Value.ToString()
        'txtPhone.Text = selectedRow.Cells(4).Value.ToString()
        'txtAddress.Text = selectedRow.Cells(5).Value.ToString()
        'txtEmail.Text = selectedRow.Cells(6).Value.ToString()
        'DateOfBirth.Text = 
        'DateOfBirth.Format = CType(selectedRow.Cells(7).Value.ToString(), DateTimePickerFormat)
    End Sub

    Private Sub RoomToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem1.Click
        My.Forms.frmRoom.Show()
        Me.Hide()
    End Sub

    Private Sub BookingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem1.Click
        My.Forms.frmBooking.Show()
        Me.Hide()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        My.Forms.frmViewCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub RoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem.Click
        My.Forms.frmViewRoom.Show()
        Me.Hide()
    End Sub

    Private Sub BookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem.Click
        My.Forms.frmViewBooking.Show()
        Me.Hide()
    End Sub
End Class
