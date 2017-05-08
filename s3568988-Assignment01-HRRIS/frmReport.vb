Option Explicit On
Option Strict On

Imports System.Drawing

Imports System.Data.OleDb
Imports System.IO
' Name:        Booking.vb
' Description: Class containing validation methods
' Author:      To Quang Khai
' Date:        26/03/2017 

Public Class frmReport
    'Open a connection to the database
    Public Const CONNECTION_STRING As String = _
"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=s3568988-HRRIS-Database.accdb"
    Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
    Dim ds As New DataSet
    Dim da As OleDbDataAdapter
    Dim tables As DataTableCollection

    Private Sub frmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        'connect to database
        oConnection.Open()
        Dim oCommand As OleDbCommand = New OleDbCommand
        oCommand.Connection = oConnection


        'dropdown box: to select room number from booking form
        tables = ds.Tables
        da = New OleDbDataAdapter("SELECT distinct customer_id from booking", oConnection)
        da.Fill(ds, "booking")
        Dim view As New DataView(tables(0))
        With cbbCustomerId
            .DataSource = ds.Tables("booking")
            .DisplayMember = "customer_id"
            .ValueMember = "customer_id"
            .SelectedIndex = -1
        End With
        oConnection.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim oController As FirstReportController = New FirstReportController
            oController.createReport01(cId:=cbbCustomerId.Text)
            Dim cusId = cbbCustomerId.Text
            'Dim lsData = oController.findAll()
            Dim lsData = oController.findById(cusId)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter
        'connect to database
        oConnection.Open()
        Dim oCommand As OleDbCommand = New OleDbCommand
        oCommand.Connection = oConnection


        'dropdown box: to select room number from booking form
        tables = ds.Tables
        da = New OleDbDataAdapter("SELECT distinct room_id from booking", oConnection)
        da.Fill(ds, "room")
        Dim view As New DataView(tables(0))
        With cbbRoomNum
            .DataSource = ds.Tables("room")
            .DisplayMember = "room_id"
            .ValueMember = "room_id"
            .SelectedIndex = 0
        End With
        oConnection.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim oController As SecondReportController = New SecondReportController
            oController.createReport01(cId:=cbbRoomNum.Text)
            Dim roomNum = cbbRoomNum.Text
            'Dim lsData = oController.findAll()
            Dim lsData = oController.findById(roomNum)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter
        'connect to database
        oConnection.Open()
        Dim oCommand As OleDbCommand = New OleDbCommand
        oCommand.Connection = oConnection


        'dropdown box: to select customer_id 
        tables = ds.Tables
        da = New OleDbDataAdapter("SELECT distinct customer_id from booking", oConnection)
        da.Fill(ds, "customer")
        Dim view As New DataView(tables(0))
        With cbbCusId
            .DataSource = ds.Tables("customer")
            .DisplayMember = "customer_id"
            .ValueMember = "customer_id"
            .SelectedIndex = 0
        End With
        oConnection.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim oController As ThirdReportController = New ThirdReportController
            
            Dim cId = cbbCusId.Text
            Dim mDate = cbbBookingMonth.Text
            Dim yDate = txtBookingYear.Text
            Dim picError As Boolean = True
            Dim isValid As Boolean = True

            If String.IsNullOrEmpty(txtBookingYear.Text) Then
                picError = False
                picErrorField1.Visible = True
            End If

            If String.IsNullOrEmpty(cbbCusId.Text) Then
                picError = False
                PictureBox1.Visible = True
            End If

            If String.IsNullOrEmpty(cbbBookingMonth.Text) Then
                picError = False
                PictureBox2.Visible = True
            End If

            If picError = False Then
                MsgBox("Do not leave this empty")
            End If

            If Not IsNumeric(txtBookingYear.Text) Then
                isValid = False
                picErrorField1.Visible = True

            End If

            If isValid = False Then
                MsgBox("Invalid value, must be number")
            End If

            If isValid = True And picError = True Then
                oController.createReport01(CStr(CInt(cId)), CInt(mDate), CInt(yDate))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Try
            Dim oController As FourthReportController = New FourthReportController
           
            Dim mDate = cbbBookingMonth2.Text
            Dim yDate = txtBookingYear1.Text
            Dim picError As Boolean = True
            Dim isValid As Boolean = True

            If String.IsNullOrEmpty(cbbBookingMonth2.Text) Then
                picError = False
                PictureBox3.Visible = True
            End If

            If String.IsNullOrEmpty(txtBookingYear1.Text) Then
                picError = False
                picErrorField2.Visible = True
            End If

            If picError = False Then
                MsgBox("Do not leave this empty")
            End If

            If Not IsNumeric(txtBookingYear1.Text) Then
                isValid = False
                picErrorField2.Visible = True

            End If

            If isValid = False Then
                MsgBox("Invalid value, must be number")
            End If

            If picError = True And isValid = True Then
                oController.createReport01(CInt(mDate), CInt(yDate))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter
        'connect to database
        oConnection.Open()
        Dim oCommand As OleDbCommand = New OleDbCommand
        oCommand.Connection = oConnection


        'dropdown box: to select room number from booking form
        tables = ds.Tables
        da = New OleDbDataAdapter("SELECT distinct room_id from booking", oConnection)
        da.Fill(ds, "room")
        Dim view As New DataView(tables(0))
        With cbbRoomNumber1
            .DataSource = ds.Tables("room")
            .DisplayMember = "room_id"
            .ValueMember = "room_id"
            .SelectedIndex = 0
        End With
        oConnection.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Dim oController As SixthReportController = New SixthReportController
           
            Dim cId = cbbRoomNumber1.Text
            Dim mDate = cbbBookingMonth3.Text
            Dim yDate = txtBookingYear3.Text

            Dim picError As Boolean = True
            Dim isValid As Boolean = True

            If String.IsNullOrEmpty(cbbRoomNumber1.Text) Then
                picError = False
                PictureBox5.Visible = True
            End If

            If String.IsNullOrEmpty(cbbBookingMonth3.Text) Then
                picError = False
                PictureBox6.Visible = True
            End If

            If String.IsNullOrEmpty(txtBookingYear3.Text) Then
                picError = False
                picErrorField4.Visible = True
            End If

            If picError = False Then
                MsgBox("Do not leave this empty")
            End If

            If Not IsNumeric(txtBookingYear3.Text) Then
                isValid = False
                picErrorField4.Visible = True
                MsgBox("Invalid value, must be number")
            End If

            If picError And isValid Then
                oController.createReport01(CStr(CInt(cId)), CInt(mDate), CInt(yDate))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GroupBox7_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim oController As SecondControlBreakReport = New SecondControlBreakReport

            oController.createBreakReport()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Dim oController As FifthReportController = New FifthReportController

            'Dim cId = cbbRoom.Text
            Dim mDate = ComboBox1.Text
            Dim yDate = TextBox1.Text
            Dim picError As Boolean = True
            Dim isValid As Boolean = True

            If String.IsNullOrEmpty(ComboBox1.Text) Then
                picError = False
                PictureBox4.Visible = True
            End If

            If String.IsNullOrEmpty(TextBox1.Text) Then
                picError = False
                picErrorField3.Visible = True
            End If

            If picError = False Then
                MsgBox("Do not leave this empty")
            End If

            If Not IsNumeric(TextBox1.Text) Then
                isValid = False
                picErrorField3.Visible = True
                MsgBox("Invalid value, must be number")
            End If

            If picError And isValid Then
                oController.createReport01(CInt(mDate), CInt(yDate))
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GroupBox6_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox6.Enter

    End Sub
End Class