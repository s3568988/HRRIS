Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.OleDb

Imports System.Data.Odbc
Imports System.Data.DataTable

' Name:        frmViewCustomer.vb
' Description: Form to view Customer
' Author:      To Quang Khai
' Date:        26/03/2017 

Public Class frmViewCustomer

    Dim oConnection As New OleDbConnection(Controller.CONNECTION_STRING)

    'navigation
    Dim lsData As New List(Of Hashtable)
    Dim iCurrentIndex As Integer


    'Dim conreader As OleDbDataReader
    'Dim concmd As New OleDbCommand
    Dim index As Integer

    Dim ds As DataSet = New DataSet
    Dim da As OleDbDataAdapter
    Dim tables As DataTableCollection = ds.Tables
    Dim source1 As New BindingSource()
    Dim table As New DataTable()

    Private Sub frmViewCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_s3568988_HRRIS_DatabaseDataSet1.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me._s3568988_HRRIS_DatabaseDataSet1.customer)

        DataGridView1.EditMode = CType(False, DataGridViewEditMode)
        oConnection.Open()
        loadGrid()
        oConnection.Close()

        'navigation
        showData(index)

        'Load all the product when form load
        Dim oController As CustomerController = New CustomerController
        Dim lsData = oController.findAll()
        lsData = oController.findAll()



    End Sub

    Private Sub loadGrid()

        Dim access As String
        access = "select * from customer"
        Dim DataTab As New DataTable
        Dim DataAdap As New OleDbDataAdapter(access, oConnection)
        DataAdap.Fill(DataTab)
        DataGridView1.DataSource = DataTab
    End Sub

    Private Sub CustomerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem1.Click
        My.Forms.frmCustomer.Show()
        Me.Hide()
    End Sub



    Private Sub RoomToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem1.Click
        My.Forms.frmRoom.Show()
        Me.Hide()
    End Sub

    Private Sub BookingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem1.Click
        My.Forms.frmBooking.Show()
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim access As String
        Dim oValidation As New Validation
        Dim emptyValid As Boolean = True
        Dim bAllFieldsValid As Boolean = True
        Dim oConnection As OleDbConnection = New OleDbConnection(Controller.CONNECTION_STRING)
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

        'run loop to validate numeric, empty
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

            'use boolean because the number of msgbox will show according to the number of error 
            If emptyValid = False Then
                MessageBox.Show("Do not leave this blank")

            ElseIf bAllFieldsValid = False Then
                MessageBox.Show("Value is invalid")
            End If


            'if no error, update record
            If bAllFieldsValid And emptyValid Then

                Debug.Print("Connection string: " & oConnection.ConnectionString)

                'update record
                oConnection.Open()
                access = "UPDATE customer SET title = '" & cbbTitle.Text & "', gender = '" & cbbGender.Text & _
                    "', firstname ='" & txtFirstName.Text & "' , lastname ='" & txtLastName.Text & "' , phone = '" & txtPhone.Text & _
                    "', address = '" & txtAddress.Text & "', email = '" & txtEmail.Text & "', dob = '" & DateOfBirth.Value.ToShortDateString & _
                    "' where customer_id=" & txtCusId.Text & ""
                Dim cmd As New OleDbCommand(access, oConnection)
                cmd.ExecuteNonQuery()
                oConnection.Close()

                MsgBox("The record is successfully updated")

                loadGrid()
                txtCusId.Clear()
                cbbTitle.SelectedIndex = -1
                cbbGender.SelectedIndex = -1
                txtFirstName.Clear()
                txtLastName.Clear()
                txtPhone.Clear()
                txtAddress.Clear()
                txtEmail.Clear()
                DateOfBirth.CustomFormat = ""
                DateOfBirth.Format = DateTimePickerFormat.Custom
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            oConnection.Close()
        End Try
        


    End Sub

   
    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer

        'click on each cell on the datagridview will show data on text box
        i = DataGridView1.CurrentRow.Index
        Try
            txtCusId.Text = CStr(CInt(DataGridView1.Item(0, i).Value))
            cbbTitle.Text = CStr(DataGridView1.Item(1, i).Value)
            cbbGender.Text = CStr(DataGridView1.Item(2, i).Value)
            txtFirstName.Text = CStr(DataGridView1.Item(3, i).Value)
            txtLastName.Text = CStr(DataGridView1.Item(4, i).Value)
            txtPhone.Text = CStr(DataGridView1.Item(5, i).Value)
            txtAddress.Text = CStr(DataGridView1.Item(6, i).Value)
            txtEmail.Text = CStr(DataGridView1.Item(7, i).Value)
            DateOfBirth.Text = CStr(DataGridView1.Item(8, i).Value.ToString)
           
        Catch ex As Exception
            Debug.Print("error is" & ex.Message)

        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            oConnection.Open()

            'delete record
            If MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim delcmd As New OleDbCommand("delete from customer where customer_id=" & txtCusId.Text & " ", oConnection)
                delcmd.ExecuteNonQuery()
                oConnection.Close()
                MsgBox("Record is deleted")

                loadGrid()
                txtCusId.Clear()
                cbbTitle.SelectedIndex = -1
                cbbGender.SelectedIndex = -1
                txtFirstName.Clear()
                txtLastName.Clear()
                txtPhone.Clear()
                txtAddress.Clear()
                txtEmail.Clear()
                DateOfBirth.CustomFormat = ""
                DateOfBirth.Format = DateTimePickerFormat.Custom
            End If

            
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            oConnection.Close()
        End Try
        
    End Sub

    Public Sub FilterData(ByVal valueToSearch As String)

        'searching
        Dim searchQuery As String = "select * from customer where customer_id like '%" & txtFilter.Text & _
            "%' or gender like '%" & txtFilter.Text & "%' Or firstname like '%" & txtFilter.Text & _
            "%' or lastname like '%" & txtFilter.Text & "%' or phone like '%" & txtFilter.Text & _
            "%' or address like '%" & txtFilter.Text & "%' or email like '%" & txtFilter.Text & "%';"

        Dim command As New OleDbCommand(searchQuery, oConnection)
        Dim adapter As New OleDbDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)

        DataGridView1.DataSource = table


    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        
        FilterData(txtFilter.Text)

    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oController As CustomerController = New CustomerController

        Dim cId = txtCusId.Text
        Dim firstname = txtFirstName.Text
        Dim lsData = oController.findById(cId)
        Dim lsData1 = oController.findByFirstname(firstname)

        If lsData.Count = 1 Then
            populateFormFields(lsData.Item(0))
        Else
            Debug.Print("No records were found")
        End If

        If lsData1.Count = 1 Then
            populateFormFields(lsData1.Item(0))
        Else
            Debug.Print("No records were found")
        End If

    End Sub

    Private Sub populateFormFields(ByVal htdata As Hashtable)
        txtCusId.Text = CStr(htdata("customer_id"))
        cbbTitle.Text = CStr(htdata("title"))
        cbbGender.Text = CStr(htdata("gender"))
        txtFirstName.Text = CStr(htdata("firstname"))
        txtLastName.Text = CStr(htdata("lastname"))
        txtPhone.Text = CStr(htdata("phone"))
        txtAddress.Text = CStr(htdata("address"))
        txtEmail.Text = CStr(htdata("email"))
        DateOfBirth.Text = CStr(CDate(htdata("dob")))

    End Sub


    Public Sub showData(ByVal position As Integer)
        Dim oCommand As New OleDbCommand("select * from customer", oConnection)
        Dim adapter As New OleDbDataAdapter(oCommand)



        adapter.Fill(table)

        txtCusId.Text = table.Rows(position)(0).ToString()
        cbbTitle.Text = table.Rows(position)(1).ToString()
        cbbGender.Text = table.Rows(position)(2).ToString()
        txtFirstName.Text = table.Rows(position)(3).ToString()
        txtLastName.Text = table.Rows(position)(4).ToString()
        txtPhone.Text = table.Rows(position)(5).ToString()
        txtAddress.Text = table.Rows(position)(6).ToString()
        txtEmail.Text = table.Rows(position)(7).ToString()
        DateOfBirth.Text = table.Rows(position)(8).ToString()

    End Sub




    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        index += 1

        If index > table.Rows.Count() - 1 Then
            index = table.Rows.Count() - 1

        End If

        showData(index)


    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click

        index = table.Rows.Count() - 1
        showData(index)

    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
       
        index = 0
        showData(index)


    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click

        'Me.CustomerBindingSource.MovePrevious()

        Try
            index -= 1
            If index > 0 Then
                index = 0
            End If

            If index < 0 Then
                MsgBox("No more record")
                index = 0
            End If

            showData(index)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        

    End Sub
End Class

























