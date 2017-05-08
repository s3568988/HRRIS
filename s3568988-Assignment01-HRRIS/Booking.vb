Option Explicit On
Option Strict On

Imports System.Drawing

Imports System.Data.OleDb
Imports System.IO
' Name:        Booking.vb
' Description: Class containing validation methods
' Author:      To Quang Khai
' Date:        26/03/2017 


Public Class frmBooking

    'Open a connection to the database
    Public Const CONNECTION_STRING As String = _
"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=s3568988-HRRIS-Database.accdb"
    Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
    Dim ds As New DataSet
    Dim da As OleDbDataAdapter
    Dim tables As DataTableCollection

    Private Sub frmBooking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
            .DisplayMember = "room_number"
            .ValueMember = "room_id"
            .SelectedIndex = 0
        End With
        oConnection.Close()

        DateTimePicker1.Value = DateTime.Now

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim txtError() As TextBox
        Dim picError() As PictureBox
        Dim emptyValid As Boolean = True
        Dim bAllFieldsValid As Boolean = True

        txtError = New TextBox() {txtCusId, txtNumOfDay, txtNumOfGuest}

        picError = New PictureBox() {picErrorField2, picErrorField3, picErrorField4}


        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Try

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

            'insert to database
            If bAllFieldsValid And emptyValid Then

                Debug.Print("Connection string: " & oConnection.ConnectionString)

                oConnection.Open()
                Dim oCommand As OleDbCommand = New OleDbCommand
                oCommand.Connection = oConnection

                Dim htData As Hashtable = New Hashtable
                htData("booking_date") = Format(DateTimePicker1.Value, "dd/MM/yyyy")
                htData("room_id") = cbbRoomId.SelectedValue
                htData("customer_id") = txtCusId.Text
                htData("num_days") = txtNumOfDay.Text
                htData("num_guests") = txtNumOfGuest.Text
                htData("checkin_date") = Format(DateTimePicker2.Value, "dd/MM/yyyy")
                htData("total_price") = txtTotalPrice.Text
                htData("comments") = txtComments.Text



                Dim bokController As Controller = New Controller
                bokController.bookingController(htData)

                MessageBox.Show("The record was inserted.")

            Else : Debug.Print("One of the fields was invalid")

            End If

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. The record wasn't inserted.")
        Finally
            oConnection.Close()
        End Try



    End Sub


    Private Sub txtTotalPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalPrice.TextChanged

        

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
        picErrorField1.Visible = False
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

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RoomToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem1.Click
        My.Forms.frmRoom.Show()
        'Me.Hide()
    End Sub

    Private Sub CustomerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem1.Click
        My.Forms.frmCustomer.Show()
        'Me.Hide()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        My.Forms.frmViewCustomer.Show()
        'Me.Hide()
    End Sub

    Private Sub RoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem.Click
        My.Forms.frmViewRoom.Show()
        'Me.Hide()
    End Sub

    Private Sub BookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem.Click
        My.Forms.frmViewBooking.Show()
        'Me.Hide()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportToolStripMenuItem.Click
        
    End Sub

    Private Sub InvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceToolStripMenuItem.Click
        My.Forms.frmInvoice.Show()
    End Sub

    Private Sub ViewHelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewHelpToolStripMenuItem.Click
        Dim url As String = System.IO.Path.GetFullPath("help.html")
        Process.Start(url)
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutUsToolStripMenuItem.Click
        Dim url As String = System.IO.Path.GetFullPath("about.html")
        Process.Start(url)
    End Sub

    Private Sub NormalReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormalReportToolStripMenuItem.Click
        My.Forms.frmReport.Show()
        'Me.Hide()
    End Sub

    Private Sub ControlBreakReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlBreakReportToolStripMenuItem.Click
        My.Forms.frmControlBreakReport.Show()

    End Sub

    Private Sub txtCusId_TextChanged(sender As Object, e As EventArgs) Handles txtCusId.TextChanged
        picErrorField2.Visible = False
    End Sub

    Private Sub txtNumOfGuest_TextChanged(sender As Object, e As EventArgs) Handles txtNumOfGuest.TextChanged
        picErrorField4.Visible = False
    End Sub
End Class