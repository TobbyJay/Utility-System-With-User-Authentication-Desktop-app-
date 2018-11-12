Public Class CourseReg1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" Then
            Label5.Text = "Please Enter Credentials"

        ElseIf TextBox1.Text = "" Then
            Label5.Text = "Enter Course Name "
        ElseIf TextBox2.Text = "" Then
            Label5.Text = "Enter Course Code"

        ElseIf TextBox3.Text = "" Then
            Label5.Text = "Enter Unit"

        ElseIf MsgBox("Are You Sure About Your Information And Want To Submit ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then


            Timer1.Start()
            CourseReg2.Show()
        Else



        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Label5.Text = ""

        CourseReg2.TextBox1.Text = TextBox1.Text


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Label5.Text = ""
        CourseReg2.TextBox2.Text = TextBox2.Text

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Label5.Text = ""
        CourseReg2.TextBox3.Text = TextBox3.Text

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        SetupMenu.Show()

    End Sub
End Class