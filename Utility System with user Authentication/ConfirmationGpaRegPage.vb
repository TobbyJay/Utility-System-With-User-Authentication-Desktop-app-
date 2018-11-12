Public Class ConfirmationGpaRegPage

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        If TextBox1.Text = My.Settings.username Then
            MsgBox("You Can Have Access To Use The Calculator", MsgBoxStyle.Information)

            GpaCalculator.Show()
            Me.Hide()


        Else
            MsgBox("Check User ID And Try Again!!", MsgBoxStyle.Exclamation)
            Label3.Text = "Your Login ID is Your User ID"

        End If
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Label3.Text = ""

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()

    End Sub
End Class