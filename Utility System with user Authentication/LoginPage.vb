Public Class LoginPage

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked And txtPassword.UseSystemPasswordChar = True Then
            CheckBox1.Text = "Hide Password"
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
            CheckBox1.Text = "Show Password"
        End If
    End Sub


    Private Sub txtUserId_TextChanged(sender As Object, e As EventArgs) Handles txtUserId.TextChanged
        lblError.Text = ""
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        lblError.Text = ""
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Registration_Page.StudentTableBindingSource.AddNew()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If MsgBox("Do You Want To Exit Program??", MsgBoxStyle.YesNo, MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Close()

        Else


        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Registration_Page.txtConfirm.Text = ""
        Registration_Page.ComboBox1.SelectedIndex = -1

        Registration_Page.StudentTableBindingSource.AddNew()

        Registration_Page.Show()
        Me.Hide()
        txtPassword.Text = ""
        txtUserId.Text = ""
        lblError.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form3.Show()


    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUserId.Text <> My.Settings.username And My.Settings.password <> txtPassword.Text Then
            lblError.Text = "Check Credentials and try again !!"

        ElseIf txtPassword.Text = "" And txtUserId.Text = My.Settings.username Then
            lblError.Text = "Please Enter Password And Try Again"

        ElseIf txtUserId.Text = "" And txtPassword.Text = My.Settings.password Then
            lblError.Text = "Please Enter User ID And Try Again"


        ElseIf txtUserId.Text = My.Settings.username And txtPassword.Text = My.Settings.password Then
            MsgBox("Welcome To Your Personal Profile", MsgBoxStyle.Information)
            HomePage.Label2.Text = Me.txtUserId.Text
            Me.Hide()

            HomePage.Show()


            txtPassword.Text = ""

            lblError.Text = ""
        End If







        Timer1.Start()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form3.Show()

        Me.Hide()

    End Sub
End Class