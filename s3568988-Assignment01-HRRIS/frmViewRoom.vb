Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.OleDb

Imports System.Data.Odbc
Imports System.Data.DataTable

' Name:        frmViewRoom.vb
' Description: Form to view Room
' Author:      To Quang Khai
' Date:        30/04/2017 



Public Class frmViewRoom

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


    Private Sub frmViewRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_s3568988_HRRIS_DatabaseDataSet2.room' table. You can move, or remove it, as needed.
        Me.RoomTableAdapter.Fill(Me._s3568988_HRRIS_DatabaseDataSet2.room)


        RoomDataGridView1.EditMode = CType(False, DataGridViewEditMode)
        'oConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=s3568988-HRRIS-Database.accdb"
        oConnection.Open()
        loadGrid()
        oConnection.Close()

        'FilterData("")

        'navigation
        showData(index)

        'Load all the product when form load
        Dim oController As CustomerController = New CustomerController
        'Dim lsData = oController.findAll()
        lsData = oController.findAll()


    End Sub

    Private Sub loadGrid()

        Dim access As String
        access = "select * from room"
        Dim DataTab As New DataTable
        Dim DataAdap As New OleDbDataAdapter(access, oConnection)
        DataAdap.Fill(DataTab)
        RoomDataGridView1.DataSource = DataTab
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

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        My.Forms.frmViewCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub BookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem.Click
        My.Forms.frmViewBooking.Show()
        Me.Hide()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Dim access As String
        Dim picError() As PictureBox
        Dim txtError() As TextBox
        Dim emptyValid As Boolean = True
        Dim bAllFieldsValid As Boolean = True


        picError = New PictureBox() {picErrorField1, picErrorField3, picErrorField4, picErrorField5}
        txtError = New TextBox() {txtRoomNumber, txtPrice, txtNumOfBed, txtFloor}


        'InsertRecord("Monkey", New Hashtable)

        'Instantiate an OleDbConnection object
        Dim oConnection As OleDbConnection = New OleDbConnection(Controller.CONNECTION_STRING)




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
                access = "UPDATE room SET room_number = " & txtRoomNumber.Text & ", type = '" & cbbType.Text & _
                    "', price =" & txtPrice.Text & " , num_beds =" & txtNumOfBed.Text & " , floor = " & txtFloor.Text & ", description = '" & txtDescription.Text & "' where room_id=" & txtRoomId.Text & ""
                Dim cmd As New OleDbCommand(access, oConnection)
                cmd.ExecuteNonQuery()
                oConnection.Close()

                MsgBox("The record is successfully updated")

                loadGrid()
                txtRoomId.Clear()
                txtRoomNumber.Clear()
                cbbType.SelectedIndex = -1
                txtPrice.Clear()
                txtNumOfBed.Clear()
                cbAvailability.Checked = False
                txtFloor.Clear()
                txtDescription.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            oConnection.Close()
        End Try

    End Sub





    Public Sub showData(ByVal position As Integer)
        Dim oCommand As New OleDbCommand("select * from room", oConnection)
        Dim adapter As New OleDbDataAdapter(oCommand)



        adapter.Fill(table)

        txtRoomId.Text = table.Rows(position)(0).ToString()
        txtRoomNumber.Text = table.Rows(position)(1).ToString()
        cbbType.Text = table.Rows(position)(2).ToString()
        txtPrice.Text = table.Rows(position)(3).ToString()
        txtNumOfBed.Text = table.Rows(position)(4).ToString()
        cbAvailability.Checked = CBool(table.Rows(position)(5).ToString())
        txtFloor.Text = table.Rows(position)(6).ToString()
        txtDescription.Text = table.Rows(position)(7).ToString()
        
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            oConnection.Open()

            If MsgBox("Do you want to delete this record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim delcmd As New OleDbCommand("delete from room where room_id=" & txtRoomId.Text & " ", oConnection)
                delcmd.ExecuteNonQuery()
                oConnection.Close()
                MsgBox("Record is deleted")

                loadGrid()
                txtRoomId.Clear()
                txtRoomNumber.Clear()
                cbbType.SelectedIndex = -1
                txtPrice.Clear()
                txtNumOfBed.Clear()
                cbAvailability.Checked = False
                txtFloor.Clear()
                txtDescription.Clear()
                
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            oConnection.Close()
        End Try

    End Sub

    Public Sub FilterData(ByVal valueToSearch As String)

        Dim searchQuery As String = "select * from room where room_id like '%" & txtFilter.Text & _
            "%' or room_number like '%" & txtFilter.Text & "%' Or type like '%" & txtFilter.Text & _
            "%' or price like '%" & txtFilter.Text & "%' or num_beds like '%" & txtFilter.Text & _
            "%' or floor like '%" & txtFilter.Text & "%' or description like '%" & txtFilter.Text & "%';"

        Dim command As New OleDbCommand(searchQuery, oConnection)
        Dim adapter As New OleDbDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)

        RoomDataGridView1.DataSource = table


    End Sub


    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        FilterData(txtFilter.Text)
    End Sub

    Private Sub RoomDataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles RoomDataGridView1.CellClick
        Dim i As Integer

        i = RoomDataGridView1.CurrentRow.Index
        Try
            txtRoomId.Text = CStr(CInt(RoomDataGridView1.Item(0, i).Value))
            txtRoomNumber.Text = CStr(RoomDataGridView1.Item(1, i).Value)
            cbbType.Text = CStr(RoomDataGridView1.Item(2, i).Value)
            txtPrice.Text = CStr(RoomDataGridView1.Item(3, i).Value)
            txtNumOfBed.Text = CStr(RoomDataGridView1.Item(4, i).Value)
            cbAvailability.Checked = CBool(CStr(RoomDataGridView1.Item(5, i).Value))
            txtFloor.Text = CStr(RoomDataGridView1.Item(6, i).Value)
            txtDescription.Text = CStr(RoomDataGridView1.Item(7, i).Value)

        Catch ex As Exception
            Debug.Print("error is" & ex.Message)

        End Try
    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        Me.RoomBindingSource.MoveFirst()
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        Me.RoomBindingSource.MoveLast()
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        Me.RoomBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Me.RoomBindingSource.MoveNext()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtRoomId.Clear()
        txtRoomNumber.Clear()
        cbbType.SelectedIndex = -1
        txtPrice.Clear()
        txtNumOfBed.Clear()
        cbAvailability.Checked = False
        txtFloor.Clear()
        txtDescription.Clear()
    End Sub
End Class