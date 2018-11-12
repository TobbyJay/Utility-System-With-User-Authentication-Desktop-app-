Public Class Form4

    Private Sub linkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked



    End Sub

    Private Sub pictureBox3_Click(sender As Object, e As EventArgs) Handles pictureBox3.Click
        If MsgBox(" Do You Want To Exit This Page?! ", MsgBoxStyle.YesNo + MsgBoxStyle.Information, " LOG  OFF") = MsgBoxResult.Yes Then
            Me.Close()
            Form2.Show()

        Else

        End If


    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
      
    End Sub


    


    '' Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    '  If TextBox1.Text = "60" Then


    '  ElseIf TextBox1.Text = "300" Then


    'ElseIf TextBox1.Text = "600" Then

    ' MsgBox("Just A Reminder That 10 minute  Have Gone By ", MsgBoxStyle.Information)

    'ElseIf TextBox1.Text = "720" Then

    '  Timer1.Stop()
    ' MsgBox("Your Session Has Ended ", MsgBoxStyle.Critical)
    ' Close()
    'Form2.Show()

    '  End If
    'End Sub

    ' Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '  TextBox1.Text = TextBox1.Text + 1

    'End Sub




    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked


        If MsgBox("Have You Registered Your Courses ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ConfirmationGpaRegPage.Show()


        Else
            MsgBox("Kindly Register Your Courses And Try Again", MsgBoxStyle.Information)
            CourseReg2.Show()

        End If

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        SetupMenu.Show()

    End Sub


    Dim d As Date = TimeOfDay
    Private Sub label6_Click(sender As Object, e As EventArgs) Handles label6.Click

        MsgBox("THIS SECTION IS STILL UNDER CONSTRUCTION SINCE " & d, MessageBoxIcon.Error, "About")

    End Sub

    Private Sub LinkLabel2_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        CourseReg2.Show()

    End Sub



    Private Sub label3_Click(sender As Object, e As EventArgs) Handles label3.Click

        Dim d As Date = TimeOfDay
        MsgBox("THIS PAGE IS STILL UNDER CONSTRUCTION" + d, MsgBoxStyle.Information)

    End Sub

End Class