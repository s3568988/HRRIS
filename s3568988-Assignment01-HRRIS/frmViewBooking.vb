Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.OleDb

Imports System.Data.Odbc
Imports System.Data.DataTable

' Name:        frmViewBooking.vb
' Description: Form to view Booking
' Author:      To Quang Khai
' Date:        06/05/2017 

Public Class frmViewBooking

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

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        My.Forms.frmViewCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub RoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem.Click
        My.Forms.frmViewRoom.Show()
        Me.Hide()
    End Sub

    Private Sub frmViewBooking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_s3568988_HRRIS_DatabaseDataSet3.booking' table. You can move, or remove it, as needed.
        Me.BookingTableAdapter.Fill(Me._s3568988_HRRIS_DatabaseDataSet3.booking)
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

        DateTimePicker1.Value = DateTime.Now


        'connect to database
        oConnection.Open()
        Dim oCommand As OleDbCommand = New OleDbCommand
        oCommand.Connection = oConnection


        'dropdown box: to select room number from booking form
        tables = ds.Tables
        da = New OleDbDataAdapter("SELECT room_id, room_number from room", oConnection)
        da.Fill(ds, "room")
        Dim view As New DataView(tables(0))
        With cbbRoomId
            .DataSource = ds.Tables("room")
            .DisplayMember = "room_id"
            .ValueMember = "room_id"
            .SelectedIndex = 0
        End With
        oConnection.Close()


    End Sub

    Private Sub loadGrid()

        Dim access As String
        access = "select * from booking"
        Dim DataTab As New DataTable
        Dim DataAdap As New OleDbDataAdapter(access, oConnection)
        DataAdap.Fill(DataTab)
        DataGridView1.DataSource = DataTab
    End Sub

    Public Sub showData(ByVal position As Integer)
        Dim oCommand As New OleDbCommand("select * from booking", oConnection)
        Dim adapter As New OleDbDataAdapter(oCommand)



        adapter.Fill(table)

        txtBookingId.Text = table.Rows(position)(0).ToString()
        DateTimePicker1.Text = table.Rows(position)(1).ToString()
        cbbRoomId.Text = table.Rows(position)(2).ToString()
        txtCusId.Text = table.Rows(position)(3).ToString()
        txtNumOfDay.Text = table.Rows(position)(4).ToString()
        txtNumOfGuest.Text = table.Rows(position)(5).ToString()
        'DateTimePicker2.Text = table.Rows(position)(6).ToString()
        txtTotalPrice.Text = table.Rows(position)(7).ToString()
        txtComments.Text = table.Rows(position)(8).ToString()

    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.BookingBindingSource.MoveLast()
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        Me.BookingBindingSource.MoveFirst()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Me.BookingBindingSource.MoveNext()
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        Me.BookingBindingSource.MovePrevious()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer

        i = DataGridView1.CurrentRow.Index
        Try
            txtBookingId.Text = CStr(CInt(DataGridView1.Item(0, i).Value))
            DateTimePicker1.Text = CStr(CDate(DataGridView1.Item(1, i).Value))
            cbbRoomId.Text = CStr(CInt(DataGridView1.Item(2, i).Value))
            txtCusId.Text = CStr(CInt(DataGridView1.Item(3, i).Value))
            txtNumOfDay.Text = CStr(CInt(DataGridView1.Item(4, i).Value))
            txtNumOfGuest.Text = CStr(CInt(DataGridView1.Item(5, i).Value))
            DateTimePicker2.Text = CStr(CDate(DataGridView1.Item(6, i).Value))
            txtTotalPrice.Text = CStr(CInt(DataGridView1.Item(7, i).Value))
            txtComments.Text = CStr(DataGridView1.Item(8, i).Value.ToString)

        Catch ex As Exception
            Debug.Print("error is" & ex.Message)

        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click


        Dim access As String
        Dim txtError() As TextBox
        Dim picError() As PictureBox
        Dim emptyValid As Boolean = True
        Dim bAllFieldsValid As Boolean = True

        txtError = New TextBox() {txtCusId, txtNumOfDay, txtNumOfGuest}

        picError = New PictureBox() {picErrorField2, picErrorField3, picErrorField4}


        Dim oConnection As OleDbConnection = New OleDbConnection(Controller.CONNECTION_STRING)

            'check empty or not for all the fields 
            For iCounter As Integer = 0 To (picError.Length - 1)

                If String.IsNullOrEmpty(txtError(iCounter).Text) Then
                    emptyValid = False
                    picError(iCounter).Visible = True

                End If

                If String.IsNullOrEmpty(cbbRoomId.Text) Then
                    emptyValid = False
                    picErrorField1.Visible = True

                End If

            Next

            For iCounter2 As Integer = 0 To (txtError.Length - 1)
                If Not IsNumeric(txtError(iCounter2).Text) = True Then
                    bAllFieldsValid = False
                    picError(iCounter2).Visible = True
                End If
            Next

            If txtNumOfDay.Text = "0" Then
                bAllFieldsValid = True
            End If



            If emptyValid = False Then
                MessageBox.Show("Do not leave this blank")

            ElseIf bAllFieldsValid = False Then
                MessageBox.Show("Value is invalid")

            End If


            oConnection.Open()

            Dim check As New OleDbCommand("Select customer_id from customer where customer_id=" & txtCusId.Text.ToString & ";", oConnection)
            Dim check1 As OleDbDataReader = check.ExecuteReader
            Dim rowCount As Integer = 0

            If (check1.HasRows) Then
                While check1.Read
                    rowCount = rowCount + 1
                End While
            ElseIf rowCount <= 1 Then
                MessageBox.Show("Customer ID does not exist.")
            End If


            oConnection.Close()


        Try
            If bAllFieldsValid And emptyValid Then
                oConnection.Open()
                access = "UPDATE booking SET booking_date = '" & DateTimePicker1.Value.ToShortDateString & "', room_id = " & cbbRoomId.Text & _
                    ", customer_id =" & txtCusId.Text & " , num_days =" & txtNumOfDay.Text & " , num_guests = " & txtNumOfGuest.Text & _
                    ", checkin_date = '" & DateTimePicker2.Value.ToShortDateString & "', comments = '" & txtComments.Text & _
                    "' where booking_id=" & txtBookingId.Text & ""
                Dim cmd As New OleDbCommand(access, oConnection)
                cmd.ExecuteNonQuery()
                oConnection.Close()
                MsgBox("The record is successfully updated")

                loadGrid()
                txtBookingId.Clear()
                DateTimePicker1.CustomFormat = ""
                DateTimePicker1.Format = DateTimePickerFormat.Custom
                cbbRoomId.SelectedIndex = -1
                txtCusId.Clear()
                txtNumOfDay.Clear()
                txtNumOfGuest.Clear()
                DateTimePicker2.CustomFormat = ""
                DateTimePicker2.Format = DateTimePickerFormat.Custom
                txtTotalPrice.Clear()
                txtComments.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            oConnection.Close()
        End Try



    End Sub

    Private Sub txtNumOfDay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumOfDay.TextChanged

        picErrorField3.Visible = False
        Try

            If cbbRoomId.SelectedIndex > -1 Then
                oConnection.Open()

                Dim roomPrice As Double
                Dim oCommand As OleDbCommand = New OleDbCommand("Select price from room where room_id = " & cbbRoomId.SelectedValue.ToString & "", oConnection)
                Dim readPrice As OleDbDataReader = oCommand.ExecuteReader
                'oCommand.Connection = oConnection

                While readPrice.Read
                    roomPrice = CDbl(readPrice("price"))
                    txtTotalPrice.Text = CStr(CInt(txtNumOfDay.Text) * roomPrice)
                End While

            End If
        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            'MsgBox("An error occurred. The record wasn't inserted.")
        Finally
            oConnection.Close()
        End Try
    End Sub

    Private Sub cbbRoomId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbRoomId.SelectedIndexChanged
        Try

            If cbbRoomId.SelectedIndex > -1 Then
                oConnection.Open()

                Dim roomPrice As Double
                Dim oCommand As OleDbCommand = New OleDbCommand("Select price from room where room_id = " & cbbRoomId.SelectedValue.ToString & "", oConnection)
                Dim readPrice As OleDbDataReader = oCommand.ExecuteReader
                'oCommand.Connection = oConnection

                While readPrice.Read
                    roomPrice = CDbl(readPrice("price"))
                    txtTotalPrice.Text = CStr(CInt(txtNumOfDay.Text) * roomPrice)
                End While

            End If
        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            'MsgBox("An error occurred. The record wasn't inserted.")
        Finally
            oConnection.Close()
        End Try

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            oConnection.Open()

            If MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim delcmd As New OleDbCommand("delete from booking where booking_id=" & txtBookingId.Text & " ", oConnection)
                delcmd.ExecuteNonQuery()
                oConnection.Close()
                MsgBox("Record is deleted")

                loadGrid()
                txtBookingId.Clear()
                DateTimePicker1.CustomFormat = ""
                DateTimePicker1.Format = DateTimePickerFormat.Custom
                cbbRoomId.SelectedIndex = -1
                txtCusId.Clear()
                txtNumOfDay.Clear()
                txtNumOfGuest.Clear()
                DateTimePicker2.CustomFormat = ""
                DateTimePicker2.Format = DateTimePickerFormat.Custom
                txtTotalPrice.Clear()
                txtComments.Clear()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            oConnection.Close()
        End Try
    End Sub

    Public Sub FilterData(ByVal valueToSearch As String)

        Dim searchQuery As String = "select * from booking where booking_id like '%" & txtFilter.Text & _
            "%' or booking_date like '%" & txtFilter.Text & "%' Or room_id like '%" & txtFilter.Text & _
            "%' or customer_id like '%" & txtFilter.Text & "%' or num_days like '%" & txtFilter.Text & _
            "%' or num_guests like '%" & txtFilter.Text & "%' or checkin_date like '%" & txtFilter.Text & "%' or total_price like '%" & txtFilter.Text & "%' or comments like '%" & txtFilter.Text & "%' ;"

        Dim command As New OleDbCommand(searchQuery, oConnection)
        Dim adapter As New OleDbDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)

        DataGridView1.DataSource = table


    End Sub


    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click

        Try
            FilterData(txtFilter.Text)
        Catch ex As Exception
            MsgBox("No record was found")
        End Try

    End Sub

    Private Sub txtCusId_TextChanged(sender As Object, e As EventArgs) Handles txtCusId.TextChanged
        picErrorField2.Visible = False
    End Sub

    Private Sub txtNumOfGuest_TextChanged(sender As Object, e As EventArgs) Handles txtNumOfGuest.TextChanged
        picErrorField4.Visible = False
    End Sub
End Class