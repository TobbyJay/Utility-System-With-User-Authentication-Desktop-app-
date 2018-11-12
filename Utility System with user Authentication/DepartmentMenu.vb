Public Class DepartmentMenu
    Private Sub DepartmentMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fill retrieves rows from the data source by using the SELECT statement
        OleDbDataAdapter1.Fill(DataSet21)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim i As Integer
        Dim NewRow As DataRow
        'Add a new row to the Student table.
        NewRow = DataSet21.Tables(0).NewRow

        NewRow.Item("FACULTY") = ComboBox1.SelectedItem
        NewRow.Item("DEPARTMENT") = txtDepartment.Text
        Try
            DataSet21.Tables(0).Rows.Add(NewRow)
            'Update the Student table in the testdb database.
            i = OleDbDataAdapter1.Update(DataSet21)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MsgBox("Your Information Has Been Saved ", MsgBoxStyle.Information)
    End Sub

   

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim i As Integer
        Dim rno As Integer
        rno = InputBox("Enter the Row no to be deleted: Row no starts from 0")
        Try
            'Delete a row from the Student table.
            DataSet21.Tables(0).Rows(rno).Delete()
            'Update the Student table in the testdb database.
            i = OleDbDataAdapter1.Update(DataSet21)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Displays number of rows updated. 
        MsgBox("no of rows Deleted = " & i, MsgBoxStyle.Information)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

        Me.Hide()

        SetupMenu.Show()

    End Sub
End Class