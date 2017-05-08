Option Explicit On
Option Strict On

Imports System.Text.RegularExpressions

' Name:        Validation.vb
' Description: Class containing validation methods
' Author:      To Quang Khai
' Date:        26/03/2017 

Public Class Validation


    Public Function isAlphaVal(ByVal strVal As String) As Boolean
        Dim pattern As Regex = New Regex("[a-zA-Z ]")
        If strVal.Length > 0 Then
            Return pattern.IsMatch(strVal)
        Else
            Return False
        End If
    End Function

    Public Function isAlphaNumericVal(ByVal strVal As String) As Boolean
        ' Please comment on what this line of code does!! 
        Dim pattern As Regex = New Regex("^[a-zA-Z]+[0-9 _-]")
        Dim pattern2 As Regex = New Regex("^[0-9 _-]+[a-zA-Z]")

        ' Please comment on what this block of code does!! 
        If strVal.Length > 0 Then
            Return pattern.IsMatch(strVal) Or pattern2.IsMatch(strVal)
        Else
            Return False
        End If
    End Function

    Function IsEmail(ByVal email As String) As Boolean
        Static emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")

        Return emailExpression.IsMatch(email)
    End Function



End Class
