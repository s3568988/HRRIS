Public Class frmCustomer

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim oValidation As New Validation
        Dim bIsValid As Boolean
        Dim bAllFieldsValid As Boolean = True

        bIsValid = IsNumeric(txtAddress.Text)

        If Not bIsValid Then
            Debug.Print("Value is not numeric")
            bAllFieldsValid = False
        End If

    End Sub

    Private Sub txtFirstName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstName.TextChanged

    End Sub
End Class
