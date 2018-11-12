Public Class SetupMenu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FacultyMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        DepartmentMenu.Show()
        DepartmentMenu.ComboBox1.SelectedItem = -1
        Me.Hide()



    End Sub

  
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CourseReg1.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("This Section Is Still Under Construction", MsgBoxStyle.Information)
    End Sub

    
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()


    End Sub

   
End Class