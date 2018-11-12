Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()


    End Sub
    
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)

        If ProgressBar1.Value = 1 Then
            Label1.Text = "Loading...."

        ElseIf ProgressBar1.Value = 20 Then
            Label1.Text = "Checking Pages...."

        ElseIf ProgressBar1.Value = 40 Then
            Label1.Text = "Identifying Forms...."

        ElseIf ProgressBar1.Value = 60 Then
            Label1.Text = "Setting Up Pages...."


        ElseIf ProgressBar1.Value = 80 Then
            Label1.Text = "Loading Diagnostics...."


        ElseIf ProgressBar1.Value = 90 Then
            Label1.Text = "Welcome...."


        ElseIf ProgressBar1.Value = 100 Then
            Me.Hide()

            LoginPage.Show()
            Timer1.Stop()
        End If

        Label2.Text = ProgressBar1.Value & " %"



    End Sub

End Class
