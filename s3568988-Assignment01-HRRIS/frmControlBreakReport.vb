Public Class frmControlBreakReport

    Private Sub GroupBox8_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox8.Enter

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            Dim oController As FirstControlBreakReport = New FirstControlBreakReport

            'Dim cId = cbbRoom.Text
            Dim mDate = cbbMonth.Text
            Dim yDate = txtYear.Text
            Dim picError As Boolean = True
            Dim isValid As Boolean = True

            If String.IsNullOrEmpty(cbbMonth.Text) Then
                picError = False
                picErrorField1.Visible = True
            End If

            If String.IsNullOrEmpty(txtYear.Text) Then
                picError = False
                picErrorField2.Visible = True
            End If

            If picError = False Then
                MsgBox("Do not leave this empty")
            End If

            If Not IsNumeric(txtYear.Text) Then
                isValid = False
                picErrorField2.Visible = True
                MsgBox("Invalid value, must be number")
            End If

            If picError And isValid Then
                oController.createBreakReport(CInt(mDate), CInt(yDate))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            Dim oController As SecondControlBreakReport = New SecondControlBreakReport

            oController.createBreakReport()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class