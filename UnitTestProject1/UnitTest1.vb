Option Explicit On
Option Strict On

' Name:        TestValidation.vb
' Description: Class for testing Validation class
' Author:      Khai To 
' Date:        08/05/2017


Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports s3568988_Assignment01_HRRIS.Validation

<TestClass()> Public Class TestValidation

    <TestInitialize()> Public Sub setup()
        Debug.Print("Setting up ...")
    End Sub

    <TestCleanup()> Public Sub cleanup()
        Debug.Print("Cleaning up ...")
    End Sub


    <TestMethod()> Public Sub TestIsNumericVal_01()
        Dim oValidation As New s3568988_Assignment01_HRRIS.Validation
        Dim sNumeric = "drrt"
        Assert.AreEqual(False, oValidation.isAlphaNumericVal(sNumeric))
    End Sub


    <TestMethod()> Public Sub TestIsNumericVal_02()
        Dim oValidation As New s3568988_Assignment01_HRRIS.Validation
        Dim sNumeric = "123"
        Assert.AreEqual(False, oValidation.isAlphaNumericVal(sNumeric))
    End Sub

    <TestMethod()> Public Sub TestIsNumericVal_03()
        Dim oValidation As New s3568988_Assignment01_HRRIS.Validation
        Dim sAlpha = "drrt"
        Assert.AreEqual(True, oValidation.isAlphaVal(sAlpha))
    End Sub


    <TestMethod()> Public Sub TestIsNumericVal_04()
        Dim oValidation As New s3568988_Assignment01_HRRIS.Validation
        Dim sAlpha = "123"
        Assert.AreEqual(False, oValidation.isAlphaVal(sAlpha))
    End Sub

    <TestMethod()> Public Sub TestIsNumericVal_05()
        Dim oValidation As New s3568988_Assignment01_HRRIS.Validation
        Dim sNumeric = "123abc"
        Dim sNumeric1 = "abc123"
        Assert.AreEqual(True, oValidation.isAlphaNumericVal(sNumeric))
        Assert.AreEqual(True, oValidation.isAlphaNumericVal(sNumeric1))
    End Sub

    <TestMethod()> Public Sub TestIsNumericVal_06()
        Dim oValidation As New s3568988_Assignment01_HRRIS.Validation
        Dim sEmail = "123asd.dwwq"
        Assert.AreEqual(False, oValidation.IsEmail(sEmail))
    End Sub

    <TestMethod()> Public Sub TestIsNumericVal_07()
        Dim oValidation As New s3568988_Assignment01_HRRIS.Validation
        Dim sEmail = "qwe123@gmail.com"
        Assert.AreEqual(True, oValidation.IsEmail(sEmail))
    End Sub


End Class