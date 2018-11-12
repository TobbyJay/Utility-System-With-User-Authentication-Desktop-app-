Public Class HomePage

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        If MsgBox(" Do You Want To Exit This Page?! ", MsgBoxStyle.YesNo + MsgBoxStyle.Information, " LOG  OFF") = MsgBoxResult.Yes Then
            Me.Close()
            LoginPage.Show()

        Else

        End If

    End Sub

  

    Private Sub label3_Click(sender As Object, e As EventArgs) Handles label3.Click
        Dim d As Date = TimeOfDay

        MsgBox("This Section Is Still Under Construction, VOLUNTARY " + d, MsgBoxStyle.Information, "DASKBOARD")

    End Sub

    Private Sub label6_Click(sender As Object, e As EventArgs) Handles label6.Click
        Dim d As Date = TimeOfDay


        MsgBox("This Section Is Still Under Construction " + d, MsgBoxStyle.Information, "ABOUT")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked

        If MsgBox("Have You Registered Your Courses", MsgBoxStyle.YesNo, MsgBoxStyle.Information) = MsgBoxResult.Yes Then

            ConfirmationGpaRegPage.Show()
        Else
            MsgBox("You Will Be Redirected The Course Registration Page", MsgBoxStyle.Information)
            CourseReg1.Show()

        End If

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        SetupMenu.Show()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        CourseReg2.Show()

    End Sub

    Private Sub linkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked

    End Sub


    
   
End Class