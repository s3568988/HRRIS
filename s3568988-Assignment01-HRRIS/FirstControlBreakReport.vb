Option Explicit On
Option Strict On

Imports System.Drawing

Imports System.Data.OleDb
Imports System.IO

' Name:        FirstReportController.vb
' Description: Class containing first report controller
' Author:      To Quang Khai
' Date:        03/05/2017 

Public Class FirstControlBreakReport
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
                    "SELECT * FROM room ORDER BY room_id;"
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

    Public Function findById(ByVal mDate As Integer, ByVal yDate As Integer) As List(Of Hashtable)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        Dim lsData As New List(Of Hashtable)

        Try
            Debug.Print("Connection string: " & oConnection.ConnectionString)

            oConnection.Open()
            Dim oCommand As OleDbCommand = New OleDbCommand
            oCommand.Connection = oConnection

            oCommand.CommandText = _
                "Select room.room_id, room.room_number, room.type, room.price, room.num_beds, room.floor, room.description, booking.booking_id from room inner join booking on room.room_id=booking.room_id where month(booking.booking_date)=? and year (booking.booking_date)=? order by room.room_id"
            'oCommand.Parameters.Add("room_id", OleDbType.Integer, 8)
            oCommand.Parameters.Add("month(booking_date)", OleDbType.Integer, 8)
            oCommand.Parameters.Add("year(booking_date)", OleDbType.Integer, 8)

            'oCommand.Parameters("room_id").Value = CInt(cId)
            oCommand.Parameters("month(booking_date)").Value = CInt(mDate)
            oCommand.Parameters("year(booking_date)").Value = CInt(yDate)

            oCommand.Prepare()
            Dim oDataReader = oCommand.ExecuteReader()

            Dim htTempData As Hashtable
            Do While oDataReader.Read() = True
                htTempData = New Hashtable
                htTempData("room_id") = CInt(oDataReader("room_id"))
                htTempData("room_number") = CInt(oDataReader("room_number"))
                htTempData("type") = CStr(oDataReader("type"))
                htTempData("price") = CDbl(oDataReader("price"))
                htTempData("num_beds") = CInt(oDataReader("num_beds"))
                htTempData("floor") = CInt(oDataReader("floor"))
                htTempData("description") = CStr(oDataReader("description"))
                htTempData("booking_id") = CInt(oDataReader("booking_id"))
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

    Public Sub createBreakReport(ByVal mDate As Integer, ByVal yDate As Integer)
        Debug.Print("CreateBreakReport ...")

        'Dim lsData = findAll()
        Dim lsData = findById(mDate, yDate)
        If CInt(lsData.Count.ToString) > 0 Then
            Dim sReportTitle = "Product Control Break Report"
            Dim sReportContent = generateBreakReport(lsData, sReportTitle)
            Dim sReportFilename = "ProductBreakReport.html"
            saveReport(sReportContent, sReportFilename)

            Dim sParam As String = """" & Application.StartupPath & "\" & sReportFilename & """"
            Debug.Print("sParam: " & sParam)
            System.Diagnostics.Process.Start(sParam)

        Else
            MsgBox("No booking for this room during this time")

        End If

    End Sub



    Private Function generateBreakReport(ByVal lsData As List(Of Hashtable), ByVal sReportTitle As String) As String
        Debug.Print("GenerateBreakReport ...")

        Dim sReportContent As String

        ' 1. Generate the start of the HTML file
        Dim sDoctype As String = "<!DOCTYPE html>"
        Dim sHtmlStartTag As String = "<html lang=""en"">"
        Dim sHeadTitle As String = "<head><title>" & sReportTitle & "</title></head>"
        Dim sBodyStartTag As String = "<body>"
        Dim sReportHeading As String = "</h1>" & sReportTitle & "</h1>"
        sReportContent = sDoctype & vbCrLf & sHtmlStartTag & vbCrLf & sHeadTitle _
         & vbCrLf & sBodyStartTag & vbCrLf & sReportHeading & vbCrLf

        ' 2. Generate the product table and its rows
        Dim sTable = generateControlBreakTable(lsData)
        sReportContent &= sTable & vbCrLf

        ' 3. Generate the end of the HTML file
        Dim sBodyEndTag As String = "</body>"
        Dim sHTMLEndTag As String = "</html>"
        sReportContent &= sBodyEndTag & vbCrLf & sHTMLEndTag

        Return sReportContent

    End Function



    Private Function generateControlBreakTable(ByVal lsData As List(Of Hashtable)) As String

        ' Generate the start of the table
        Dim sTable = "<table border=""1"">" & vbCrLf
        Dim htSample As Hashtable = lsData.Item(0)

        Dim oConnection As OleDbConnection = New OleDbConnection(CONNECTION_STRING)
        'Dim lsData As New List(Of Hashtable)
        Dim sPreviousControlField As String = ""

        'Dim lsKeys = htSample.Keys
        Dim lsKeys As List(Of String) = New List(Of String)
        lsKeys.Add("room_id")
        lsKeys.Add("room_number")
        lsKeys.Add("type")
        lsKeys.Add("price")
        lsKeys.Add("num_beds")
        lsKeys.Add("floor")
        lsKeys.Add("description")
        lsKeys.Add("booking_date")

        ' Generate the header row
        Dim sHeaderRow = "<tr>" & vbCrLf
        For Each key In lsKeys
            sHeaderRow &= "<th>" & CStr(key) & "</th>" & vbCrLf
        Next
        sHeaderRow &= "</tr>" & vbCrLf
        Debug.Print("sHeaderRow: " & sHeaderRow)
        sTable &= sHeaderRow

        ' Generate the table rows
        sTable &= generateTableRows(lsData, lsKeys)

        ' Generate the end of the table
        sTable &= "</table>" & vbCrLf

        Return sTable

    End Function


    Private Function generateTableRows(ByVal lsData As List(Of Hashtable), _
                                       ByVal lsKeys As List(Of String)) As String

        '1. Initialisation
        Dim sRows As String = ""
        Dim sTableRow As String
        Dim iCountRecordsPerRoom As Integer = 0
        Dim bFirstTime As Boolean = True
        Dim sCurrentControlField As String = ""
        Dim sPreviousControlField As String = ""

        '2. Loop through the list of hashtables
        For Each record In lsData

            '2a. Get a room and set the current key
            Dim booking As Hashtable = record
            sCurrentControlField = CStr(booking("room_id"))

            '2b. Do not check for control break on the first iteration of the loop
            If bFirstTime Then
                bFirstTime = False
            Else
                'Output total row if change in control field
                'And reset the total
                If sCurrentControlField <> sPreviousControlField Then
                    sTableRow = "<tr><td colspan = """ & lsKeys.Count & """>" _
                        & " Total booking in " & sPreviousControlField _
                        & " : " & iCountRecordsPerRoom _
                        & "</td></tr>" _
                        & vbCrLf
                    sRows &= sTableRow
                    iCountRecordsPerRoom = 0
                End If
            End If

            ' 2c. Output a normal row for every pass thru' the list
            sTableRow = "<tr>" & vbCrLf
            For Each key In lsKeys
                sTableRow &= "<td>" & CStr(booking(key)) & "</td>" & vbCrLf
            Next
            sTableRow &= "</tr>" & vbCrLf
            Debug.Print("sTableRow: " & sTableRow)
            sRows &= sTableRow

            '2d. Update control field and increment total
            sPreviousControlField = sCurrentControlField
            iCountRecordsPerRoom += 1
        Next

        '3. After the loop, need to output the last total row
        sTableRow = "<tr><td colspan = """ & lsKeys.Count & """>" _
                        & " Total bookings in " & sCurrentControlField _
                        & " : " & iCountRecordsPerRoom _
                        & "</td></tr>" _
                        & vbCrLf
        sRows &= sTableRow

        Return sRows

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
