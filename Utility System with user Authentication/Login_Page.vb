Public Class Form2

    Private Sub linkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Form3.Show()
        Me.Hide()
        label5.Text = " "

    End Sub


    Private Sub textBox2_TextChanged(sender As Object, e As EventArgs) Handles textBox2.TextChanged
        label5.Text = ""
    End Sub

    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs) Handles textBox1.TextChanged
        label5.Text = ""
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()

        If textBox2.Text <> My.Settings.username And My.Settings.password <> textBox1.Text Then
            label5.Text = "Check Credentials and try again !!"

        ElseIf textBox2.Text = My.Settings.username And textBox1.Text = My.Settings.password Then
            MsgBox("Welcome To Your Personal Profile", MsgBoxStyle.Information)

            Me.Hide()

            Form4.Show()
            textBox1.Text = ""
            textBox2.Text = ""
            label5.Text = ""
        End If


    End Sub

   
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked And textBox1.UseSystemPasswordChar = True Then
            CheckBox1.Text = "Hide Password"
            textBox1.UseSystemPasswordChar = False
        Else
            textBox1.UseSystemPasswordChar = True
            CheckBox1.Text = "Show Password"
        End If
    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
       
    End Sub

   
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        Registration_Page.Show()
        Me.Hide()
        textBox1.Text = ""
        textBox2.Text = ""
        label5.Text = ""



        'Registration_Page.MatricNoTextBox.Text = ""
        'Registration_Page.PasswordTextBox.Text = ""

    End Sub

   
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

     

       
    End Sub
End Class