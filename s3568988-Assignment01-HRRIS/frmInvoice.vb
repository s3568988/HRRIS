Option Explicit On
Option Strict On

Imports System.Drawing

Imports System.Data.OleDb
Imports System.IO
' Name:        frmInvoice.vb
' Description: Class containing Invoice description
' Author:      To Quang Khai
' Date:        05/05/2017 


Public Class frmInvoice

    'Open a connection to the database
    Public Const CONNECTION_STRING As String = _
"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=s3568988-HRRIS-Database.accdb"
    Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
    Dim ds As New DataSet
    Dim da As OleDbDataAdapter
    Dim tables As DataTableCollection

    Private Sub frmInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'connect to database
        oConnection.Open()
        Dim oCommand As OleDbCommand = New OleDbCommand
        oCommand.Connection = oConnection


        'dropdown box: to select room number from booking form
        tables = ds.Tables
        da = New OleDbDataAdapter("SELECT booking_id from booking", oConnection)
        da.Fill(ds, "booking")
        Dim view As New DataView(tables(0))
        With cbbBookingId
            .DataSource = ds.Tables("booking")
            .DisplayMember = "booking_id"
            .ValueMember = "booking_id"
            .SelectedIndex = -1
        End With
        oConnection.Close()


        DateTimePicker1.Value = DateTime.Now

    End Sub

    Private Sub cbbBookingId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbBookingId.SelectedIndexChanged
        Try

            If cbbBookingId.SelectedIndex > -1 Then
                oConnection.Open()

                'Dim Price As Double
                Dim oCommand As OleDbCommand = New OleDbCommand("Select total_price from booking where booking_id = " & cbbBookingId.SelectedValue.ToString & "", oConnection)
                Dim readPrice As OleDbDataReader = oCommand.ExecuteReader

                With readPrice
                    .Read()
                    txtAmount.Text = CStr(.GetValue(0))
                End With
                readPrice.Close()

                
            End If
        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            'MsgBox("An error occurred. The record wasn't inserted.")
        Finally
            oConnection.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        
        Dim emptyValid As Boolean = True
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Try

            'check empty or not for all the fields 
            If String.IsNullOrEmpty(cbbBookingId.Text) Then
                picErrorField1.Visible = True
                emptyValid = False
                MessageBox.Show("Do not leave this blank")
            End If


            'insert to database
            If emptyValid Then

                Debug.Print("Connection string: " & oConnection.ConnectionString)

                oConnection.Open()
                Dim oCommand As OleDbCommand = New OleDbCommand
                oCommand.Connection = oConnection

                Dim htData As Hashtable = New Hashtable
                htData("bookingid") = cbbBookingId.SelectedValue
                htData("date") = DateTimePicker1.Text
                htData("amount") = txtAmount.Text
                

                Dim ivController As Controller = New Controller
                ivController.invoiceController(htData)

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

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class