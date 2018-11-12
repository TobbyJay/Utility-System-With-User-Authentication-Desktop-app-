Public Class FacultyMenu

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If TextBox1.Text = "" Then

            Label1.Text = "Enter Your Faculty ,  e.g (School Of Technology)"

        Else

            MsgBox(" Thank You, You Will Be Directed To The Departmental Page", MsgBoxStyle.Information)
            DepartmentMenu.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()

        SetupMenu.Show()


    End Sub
End Class