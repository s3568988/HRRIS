Option Explicit On
Option Strict On

Imports System.Drawing

Imports System.Data.OleDb
Imports System.IO

' Name:        FirstReportController.vb
' Description: Class containing first report controller
' Author:      To Quang Khai
' Date:        03/05/2017 

Public Class SecondReportController
    Public Const CONNECTION_STRING As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=s3568988-HRRIS-Database.accdb"

    Public Function findAll() As List(Of Hashtable)

        Dim lsData As New List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)

        Try

            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection
            oCommand.CommandText = _
                    "SELECT * FROM booking ORDER BY booking_id;"
            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("booking_id") = CInt(oDataReader("booking_id"))
                htTempData("booking_date") = CDate(oDataReader("booking_date"))
                htTempData("room_id") = CInt(oDataReader("room_id"))
                htTempData("customer_id") = CInt(oDataReader("customer_id"))
                htTempData("num_days") = CInt(oDataReader("num_days"))
                htTempData("num_guests") = CInt(oDataReader("num_guests"))
                htTempData("checkin_date") = CDate(oDataReader("checkin_date"))
                htTempData("total_price") = CDbl(oDataReader("total_price"))
                htTempData("comments") = CStr(oDataReader("comments"))
                lsData.Add(htTempData)
            Loop


        Catch ex As Exception

            Debug.Print("ERROR: " & ex.Message)

            MsgBox("An error occured!")

        Finally

            oConnection.Close()

        End Try

        Return lsData

    End Function

    Public Function findById(ByVal sId As String) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = _
                "SELECT room_id, booking_date, total_price FROM booking WHERE room_id = ?"
            oCommand.Parameters.Add("room_id", OleDbType.Integer, 8)

            oCommand.Parameters("room_id").Value = CInt(sId)

            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                'htTempData("booking_id") = CInt(oDataReader("booking_id"))
                htTempData("booking_date") = CDate(oDataReader("booking_date"))
                htTempData("room_id") = CInt(oDataReader("room_id"))
                'htTempData("customer_id") = CInt(oDataReader("customer_id"))
                'htTempData("num_days") = CInt(oDataReader("num_days"))
                'htTempData("num_guests") = CInt(oDataReader("num_guests"))
                'htTempData("checkin_date") = CDate(oDataReader("checkin_date"))
                htTempData("total_price") = CDbl(oDataReader("total_price"))
                'htTempData("comments") = CStr(oDataReader("comments"))
                lsData.Add(htTempData)
            Loop

            Debug.Print("The record was found.")

        Catch ex As Exception
            Debug.Print("ERROR: " & ex.Message)
            MsgBox("An error occurred. The record(s) could not be found!")
        Finally
            oConnection.Close()
        End Try

        Return lsData

    End Function


    Public Sub createReport01(ByVal cId As String)
        Debug.Print("CreateReport01 ...")

        'Dim lsData = findAll()
        Dim lsData = findById(cId)

        If CInt(lsData.Count.ToString) > 0 Then
            Dim sReportTitle = "Booking Report by ..."
            Dim sReportContent = generateReport01(lsData, sReportTitle)
            Dim sReportFilename = "BookingReport-01.html"
            saveReport(CStr(sReportContent), sReportFilename)

            Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
            Debug.Print("sParam: " & sParam)
            System.Diagnostics.Process.Start(sParam)
        Else
            MsgBox("This room was not booked during this period of time")
        End If

    End Sub


    Private Function generateReport01(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String) _
  As String

        Debug.Print("GenerateReport01 ...")

        Dim sReportContent As String

        ' 1. Generate the start of the HTML file
        Dim sDoctype As String = "<!DOCTYPE html>"
        Dim sHtmlStartTag As String = "<html lang=""en"">"
        Dim sHeadTitle As String = "<head><title>" & sReportTitle & "</title></head>"
        Dim sBodyStartTag As String = "<body>"
        Dim sReportHeading As String = "<h1>" & sReportTitle & "</h1>"
        sReportContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf _
          & sHeadTitle & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

        ' 2. Generate the product table and its rows
        Dim sTable = generateTable(lsData)
        sReportContent &= sTable & vbCrLf


        ' 3. Generate the end of the HTML file
        Dim sBodyEndTag As String = "</body>"
        Dim sHTMLEndTag As String = "</html>"
        sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag

        Return sReportContent



        Return sReportContent
    End Function


    Private Function generateTable(ByVal lsData As List(Of Hashtable)) As String
        ' Generate the start of the table
        Dim sTable = "<table border=""1"">" & vbCrLf
        Dim htSample As Hashtable = lsData.Item(0)
        'Dim lsKeys = htSample.Keys
        Dim lsKeys As List(Of String) = New List(Of String)
        lsKeys.Add("booking_id")
        lsKeys.Add("booking_date")
        lsKeys.Add("room_id")
        lsKeys.Add("customer_id")
        lsKeys.Add("num_days")
        lsKeys.Add("num_guests")
        lsKeys.Add("checkin_date")
        lsKeys.Add("total_price")
        lsKeys.Add("comments")


        ' Generate the header row
        Dim sHeaderRow = "<tr>" & vbCrLf
        For Each key In lsKeys
            sHeaderRow &= "<th>" & CStr(key) & "</th>" & vbCrLf
        Next
        sHeaderRow &= "</tr>" & vbCrLf
        Debug.Print("sHeaderRow: " & sHeaderRow)
        sTable &= sHeaderRow

        ' Generate the table rows
        For Each record In lsData
            Dim product As Hashtable = record
            Dim sTableRow = "<tr>" & vbCrLf
            For Each key In lsKeys
                sTableRow &= "<td>" & CStr(product(key)) & "</td>" & vbCrLf
            Next
            sTableRow &= "</tr>" & vbCrLf
            Debug.Print("sTableRow: " & sTableRow)
            sTable &= sTableRow
        Next

        ' Generate the end of the table
        sTable &= "</table>" & vbCrLf

        Return sTable
    End Function



    Private Sub saveReport(ByVal sReportContent As String, ByVal sReportFilename As String)
        Debug.Print("saveReport: " & sReportFilename)
        Dim oReportFile As StreamWriter = New StreamWriter(Application.StartupPath & "\" & sReportFilename)

        ' Check if the file is open before starting to write to it
        If Not (oReportFile Is Nothing) Then
            oReportFile.Write(sReportContent)
            oReportFile.Close()
        End If
    End Sub
End Class
