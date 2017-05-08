Public Class frmRoom


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        InsertRecord("Monkey", New Hashtable)

    End Sub

    ''' <summary>
    ''' This function takes a table name, inserts the data based on the key value provided in the parameter. 
    ''' </summary>
    ''' <param name="tableName">Name of the table</param>
    ''' <param name="hashValues">Key as name of the column and value as the value in the column</param>
    ''' <returns>True if successfully inserted the data.</returns>
    ''' <remarks>This function is not thread safe.</remarks>
    Private Function InsertRecord(ByVal tableName As String, ByVal hashValues As Hashtable) As Boolean

        'CHECKTHIS: this monkey eats lots of banana, he should be given apples.
        'Throw New FunctionNotDefined("This function is not yet developed. Code or remove.")

        Return True

    End Function

End Class