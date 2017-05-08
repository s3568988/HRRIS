Option Explicit On
Option Strict On

Imports System.Drawing

Imports System.Data.OleDb
Imports System.IO
' Name:        Validation.vb
' Description: Class containing validation methods
' Author:      To Quang Khai
' Date:        26/03/2017 


Public Class frmRoom
    'Open a connection to the database
    Public Const CONNECTION_STRING As String = _
"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=s3568988-HRRIS-Database.accdb"

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim picError() As PictureBox
        Dim txtError() As TextBox
        Dim emptyValid As Boolean = True
        Dim bAllFieldsValid As Boolean = True


        picError = New PictureBox() {picErrorField1, picErrorField3, picErrorField4, picErrorField5}
        txtError = New TextBox() {txtRoomNumber, txtPrice, txtNumOfBed, txtFloor}


        'InsertRecord("Monkey", New Hashtable)

        'Instantiate an OleDbConnection object
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Try
            For iCounter As Integer = 0 To (picError.Length - 1)

                If String.IsNullOrEmpty(txtError(iCounter).Text) Then
                    'MessageBox.Show("Do not leave this blank")
                    emptyValid = False
                    picError(iCounter).Visible = True

                End If
            Next

            If String.IsNullOrEmpty(cbbType.Text) Then
                emptyValid = False
                picErrorField2.Visible = True
            End If

            For iCounter As Integer = 0 To (picError.Length - 1)
                If Not IsNumeric(txtError(iCounter).Text) Then
                    bAllFieldsValid = False
                    picError(iCounter).Visible = True
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
                htData("room_number") = txtRoomNumber.Text
                htData("type") = cbbType.Text
                htData("price") = txtPrice.Text
                htData("num_beds") = txtNumOfBed.Text
                If cbAvailability.Checked = True Then
                    htData("availability") = 1
                Else
                    htData("availability") = 0
                End If
                htData("floor") = txtFloor.Text
                htData("description") = txtDescription.Text



                Dim romController As Controller = New Controller
                romController.roomController(htData)


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

    ''' <summary>
    ''' This function takes a table name, inserts the data based on the key value provided in the parameter. 
    ''' </summary>
    ''' <param name="tableName">Name of the table</param>
    ''' <param name="hashValues">Key as name of the column and value as the value in the column</param>
    ''' <returns>True if successfully inserted the data.</returns>
    ''' <remarks>This function is not thread safe.</remarks>
    Private Function InsertRecord(ByVal tableName As String, ByVal hashValues As Hashtable) As Boolean

       

        Return True

    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub CustomerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem1.Click
        My.Forms.frmCustomer.Show()
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

    Private Sub frmRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtRoomNumber_TextChanged(sender As Object, e As EventArgs) Handles txtRoomNumber.TextChanged
        picErrorField1.Visible = False
    End Sub

    Private Sub cbbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbType.SelectedIndexChanged
        picErrorField2.Visible = False
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        picErrorField3.Visible = False
    End Sub

    Private Sub txtNumOfBed_TextChanged(sender As Object, e As EventArgs) Handles txtNumOfBed.TextChanged
        picErrorField4.Visible = False
    End Sub

    Private Sub txtFloor_TextChanged(sender As Object, e As EventArgs) Handles txtFloor.TextChanged
        picErrorField5.Visible = False
    End Sub
End Class