Option Explicit On
Option Strict On

Imports System.Drawing

Imports System.Data.OleDb
Imports System.IO

' Name:        Validation.vb
' Description: Class containing validation methods
' Author:      To Quang Khai
' Date:        26/03/2017 

Public Class Controller
    Public Const CONNECTION_STRING As String = _
"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=s3568988-HRRIS-Database.accdb"

    Public Sub customerController(ByVal htdata As Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim oCommand As OleDbCommand = New OleDbCommand

        oConnection.Open()

        oCommand.Connection = oConnection


        oCommand.CommandText =
                     "INSERT INTO customer (title, gender, firstname, lastname, phone, address, email, dob) VALUES (?, ?, ?, ?, ?, ?, ?, ?);"

        oCommand.Parameters.Add("title", OleDbType.VarChar, 255)
        oCommand.Parameters.Add("gender", OleDbType.VarChar, 255)
        oCommand.Parameters.Add("firstName", OleDbType.VarChar, 255)
        oCommand.Parameters.Add("lastName", OleDbType.VarChar, 255)
        oCommand.Parameters.Add("phone", OleDbType.VarChar, 255)
        oCommand.Parameters.Add("address", OleDbType.VarChar, 255)
        oCommand.Parameters.Add("email", OleDbType.VarChar, 255)
        oCommand.Parameters.Add("dob", OleDbType.Date)

        oCommand.Parameters("title").Value = CStr(htdata("title"))
        oCommand.Parameters("gender").Value = CStr(htdata("gender"))
        oCommand.Parameters("firstName").Value = CStr(htdata("firstName"))
        oCommand.Parameters("lastName").Value = CStr(htdata("lastName"))
        oCommand.Parameters("phone").Value = CStr(htdata("phone"))
        oCommand.Parameters("address").Value = CStr(htdata("address"))
        oCommand.Parameters("email").Value = CStr(htdata("email"))
        oCommand.Parameters("dob").Value = CDate(htdata("dob"))

        oCommand.Prepare()

        Debug.Print("SQL: " & oCommand.CommandText)

        oCommand.ExecuteNonQuery()

        oConnection.Close()
    End Sub


    Public Sub roomController(ByVal htdata As Hashtable)
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim oCommand As OleDbCommand = New OleDbCommand

        oConnection.Open()

        oCommand.Connection = oConnection

        oCommand.CommandText = _
                 "INSERT INTO room (room_number, type, price, num_beds, availability, floor, description) VALUES (?, ?, ?, ?, ?, ?, ?);"

        oCommand.Parameters.Add("room_number", OleDbType.VarChar, 255)
        oCommand.Parameters.Add("type", OleDbType.VarChar, 255)
        oCommand.Parameters.Add("price", OleDbType.Double, 8)
        oCommand.Parameters.Add("num_beds", OleDbType.Integer, 4)
        oCommand.Parameters.Add("availability", OleDbType.Integer, 1)
        oCommand.Parameters.Add("floor", OleDbType.Integer, 8)
        oCommand.Parameters.Add("description", OleDbType.VarChar, 255)


        oCommand.Parameters("room_number").Value = CStr(htdata("room_number"))
        oCommand.Parameters("type").Value = CStr(htdata("type"))
        oCommand.Parameters("price").Value = CDbl(htdata("price"))
        oCommand.Parameters("num_beds").Value = CInt(htdata("num_beds"))
        oCommand.Parameters("availability").Value = CInt(htdata("availability"))
        oCommand.Parameters("floor").Value = CInt(htdata("floor"))
        oCommand.Parameters("description").Value = CStr(htdata("description"))


        oCommand.Prepare()

        Debug.Print("SQL: " & oCommand.CommandText)

        oCommand.ExecuteNonQuery()

        oConnection.Close()

    End Sub


    Public Sub bookingController(ByVal htdata As Hashtable)
        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim oCommand As OleDbCommand = New OleDbCommand

        oConnection.Open()

        oCommand.Connection = oConnection

        oCommand.CommandText = _
                     "INSERT INTO booking (booking_date, room_id, customer_id, num_days, num_guests, checkin_date, total_price, comments) VALUES (?, ?, ?, ?, ?, ?, ?, ?);"

        oCommand.Parameters.Add("booking_date", OleDbType.Date)
        oCommand.Parameters.Add("room_id", OleDbType.Integer, 10)
        oCommand.Parameters.Add("customer_id", OleDbType.Integer, 10)
        oCommand.Parameters.Add("num_days", OleDbType.Integer, 10)
        oCommand.Parameters.Add("num_guests", OleDbType.Integer, 10)
        oCommand.Parameters.Add("checkin_date", OleDbType.Date)
        oCommand.Parameters.Add("total_price", OleDbType.Double, 8)
        oCommand.Parameters.Add("comments", OleDbType.VarChar, 255)

        oCommand.Parameters("booking_date").Value = CDate(htdata("booking_date"))
        oCommand.Parameters("room_id").Value = CInt(htdata("room_id"))
        oCommand.Parameters("customer_id").Value = CInt(htdata("customer_id"))
        oCommand.Parameters("num_days").Value = CInt(htdata("num_days"))
        oCommand.Parameters("num_guests").Value = CInt(htdata("num_guests"))
        oCommand.Parameters("checkin_date").Value = CDate(htdata("checkin_date"))
        oCommand.Parameters("total_price").Value = CDbl(htdata("total_price"))
        oCommand.Parameters("comments").Value = CStr(htdata("comments"))

        oCommand.Prepare()

        Debug.Print("SQL: " & oCommand.CommandText)

        oCommand.ExecuteNonQuery()
        oConnection.Close()

    End Sub


    Public Sub invoiceController(ByVal htdata As Hashtable)
        Dim oConnection As New OleDbConnection(CONNECTION_STRING)
        Dim oCommand As New OleDbCommand

        oConnection.Open()
        Try
            oCommand.Connection = oConnection

            oCommand.CommandText = _
                         "INSERT INTO invoice (booking_id, idate, amount) VALUES (?,?,?);"

            oCommand.Parameters.Add("booking_id", OleDbType.Integer, 255)
            oCommand.Parameters.Add("idate", OleDbType.Date, 255)
            oCommand.Parameters.Add("amount", OleDbType.VarChar, 255)


            oCommand.Parameters("booking_id").Value = CInt(htdata("bookingid"))
            oCommand.Parameters("idate").Value = CDate(htdata("date"))
            oCommand.Parameters("amount").Value = CStr(htdata("amount"))


            oCommand.Prepare()

            Debug.Print("SQL: " & oCommand.CommandText)

            oCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Dulicated invoice: The record was not inserted")
        Finally
            oConnection.Close()
        End Try
        


    End Sub


End Class
