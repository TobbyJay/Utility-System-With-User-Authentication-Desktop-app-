Public Class Form3

    
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

        Dim one As String
        Dim two, three As String


        one = Label7.Text
        two = Label8.Text
        three = Label9.Text


        If TextBox2.Text <> TextBox4.Text Then
            label4.Text = "Check Both Passwords And Try Again"

        ElseIf TextBox2.Text = "" And TextBox4.Text = "" Then
            label4.Text = "Input Credentials And Try Again"


        ElseIf TextBox1.Text <> Label7.Text + Label8.Text + Label9.Text Then
            MsgBox("Please Enter Captcha Text Amd Try Again", MsgBoxStyle.Exclamation)

        ElseIf TextBox1.Text = Label7.Text And TextBox1.Text = Label8.Text And TextBox1.Text = Label9.Text Then


        Else

            MsgBox("Password Successfully Changed!", MsgBoxStyle.Information)
            Me.Hide()
            Form2.Show()
            TextBox2.Text = ""
            TextBox4.Text = ""

            label4.Text = ""
        End If
    End Sub

    Private Sub linkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabel3.LinkClicked

        If TextBox2.UseSystemPasswordChar = True Then

            Me.linkLabel3.Hide()
            TextBox4.UseSystemPasswordChar = False
            TextBox2.UseSystemPasswordChar = False


        ElseIf TextBox2.UseSystemPasswordChar = False Then

            Me.linkLabel2.Hide()

        End If
    End Sub

    Private Sub linkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabel2.LinkClicked

        If TextBox2.UseSystemPasswordChar = False Then

            Me.linkLabel2.Show()
            TextBox4.UseSystemPasswordChar = True
            TextBox2.UseSystemPasswordChar = True


        ElseIf TextBox2.UseSystemPasswordChar = True Then

            Me.linkLabel3.Show()
        End If



    End Sub

    Private Sub linkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked
        Me.Hide()
        Form2.Show()

        TextBox2.Text = ""
        TextBox4.Text = ""

        If TextBox2.Text = "" And TextBox4.Text = "" Then
            Me.Hide()
            Form2.Show()

        End If

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        label4.Text = ""
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        label4.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        label4.Text = ""
    End Sub
End Class