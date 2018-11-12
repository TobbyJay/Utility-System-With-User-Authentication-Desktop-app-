Public Class GpaCalculator

    Dim CourseUnit As Integer
    Dim TotalScore As Integer
    Dim Grade As String
    Dim GradeValue As Double
    Dim NumberOfCourse As Integer = 0.0
    Dim TotalGradeSum As Integer = 0.0
    Dim UnitSum As Integer = 0
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        CourseUnit = txtUnit.Text
        TotalScore = txtScore.Text

        If TotalScore >= 70 And TotalScore < 100 Then
            Grade = "A"
        ElseIf TotalScore <= 69 And TotalScore >= 60 Then
            Grade = "B"
        ElseIf TotalScore <= 59 And TotalScore >= 50 Then
            Grade = "C"
        ElseIf TotalScore <= 49 And TotalScore >= 40 Then
            Grade = "D"
        ElseIf TotalScore <= 39 And TotalScore >= 30 Then
            Grade = "E"
        ElseIf TotalScore < 30 Then
            Grade = "F"

        ElseIf TotalScore > 100 Then
            MsgBox("Enter A Score From 1 - 100  Only", MsgBoxStyle.Exclamation)
            lstCInfo.Items.Add("")

            End If


        lstCInfo.Items.Add(txtCourse.Text + "           " + txtScore.Text + "           " + Grade)

        txtCourse.Text = ""
        txtScore.Text = ""
        txtUnit.Text = ""


        If Grade = "A" Then
            GradeValue = "4.0"
        ElseIf Grade = "B" Then
            GradeValue = "3.49"
        ElseIf Grade = "C" Then
            GradeValue = "2.99"
        ElseIf Grade = "D" Then
            GradeValue = "2.49"
        ElseIf Grade = "E" Then
            GradeValue = "1.99"
        Else
            GradeValue = "0.00"

        End If

        NumberOfCourse = NumberOfCourse + 1
        TotalGradeSum += GradeValue * CourseUnit
        UnitSum += CourseUnit

    End Sub
    Dim GradePoint As Double = 0
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        txtCourse.Text = ""
        txtScore.Text = ""
        txtUnit.Text = ""
        gprStdGrade.Visible = True
        GroupBox2.Visible = True

        GradePoint = TotalGradeSum / UnitSum

        txtTotalCourses.Text = NumberOfCourse
        txtTotalUnit.Text = UnitSum.ToString()
        txtTotGrade.Text = TotalGradeSum.ToString()
        txtGradePoint.Text = FormatNumber(GradePoint, 2).ToString()


        If txtCourse.Text = "" And txtScore.Text = "" And txtUnit.Text = "" And cmbYear.SelectedIndex = -1 And cmbSemester.SelectedIndex = -1 Then
            MsgBox("Enter Credentials To Calculate", MsgBoxStyle.Information)
            gprStdGrade.Hide()
            GroupBox2.Hide()


        ElseIf cmbYear.SelectedIndex = -1 Then
            MsgBox("Enter Your  Year", MsgBoxStyle.Information)
            gprStdGrade.Hide()
            GroupBox2.Hide()

        ElseIf cmbSemester.SelectedIndex = -1 Then
            MsgBox("Enter Your  Session", MsgBoxStyle.Information)
            gprStdGrade.Hide()
            GroupBox2.Hide()

        ElseIf cmbSemester.SelectedIndex = -1 And cmbYear.SelectedIndex = -1 Then
            MsgBox("Enter Your Year And Session", MsgBoxStyle.Information)
            gprStdGrade.Hide()
            GroupBox2.Hide()

        End If






    End Sub

    Private Sub cmbYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbYear.SelectedIndexChanged
        txtCourse.Text = ""
        txtScore.Text = ""
        txtUnit.Text = ""
        cmbSemester.Text = ""
        lstCInfo.Text = ""
    End Sub

    Private Sub cmbSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSemester.SelectedIndexChanged
        txtCourse.Text = ""
        txtScore.Text = ""
        txtUnit.Text = ""
        cmbSemester.Text = ""
        lstCInfo.Text = ""
    End Sub

    Private Sub txtCourse_TextChanged(sender As Object, e As EventArgs) Handles txtCourse.TextChanged
        txtScore.Text = ""
        txtUnit.Text = ""
    End Sub



    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged
        txtScore.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCourse.Text = ""
        txtGradePoint.Text = ""
        txtScore.Text = ""
        txtTotalCourses.Text = ""
        txtTotalUnit.Text = ""
        txtTotGrade.Text = ""
        txtUnit.Text = ""
        lstCInfo.Items.Clear()


        If txtFirst.Text = "" And txtSecond.Text = "" And txtCgpa.Text = "" Then
            GroupBox2.Visible = False

        End If




        cmbSemester.SelectedIndex = -1

        gprStdGrade.Hide()
        GroupBox2.Hide()

    End Sub

    Private Sub btnMoveToFirst_Click(sender As Object, e As EventArgs) Handles btnMoveToFirst.Click
        Dim first

        first = Val(txtFirst.Text)

        txtFirst.Text = txtGradePoint.Text


        If cmbSemester.SelectedItem = "1" Then
            txtFirst.Text = txtGradePoint.Text

        ElseIf cmbSemester.SelectedItem = "2" Then
            txtSecond.Text = txtGradePoint.Text
        End If
    End Sub

    Private Sub btnMoveToSecond_Click(sender As Object, e As EventArgs) Handles btnMoveToSecond.Click
        Dim second

        second = Val(txtSecond.Text)

        txtSecond.Text = txtGradePoint.Text


    End Sub



    Private Sub BtnCgpa_Click(sender As Object, e As EventArgs) Handles BtnCgpa.Click
        Dim cgpa As Double = 0

        cgpa = (Val(txtFirst.Text) + Val(txtSecond.Text)) / 2
        txtCgpa.Text = cgpa
        txtCgpa.Text = FormatNumber(cgpa, 2).ToString()


        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtFirst.Text = ""
        txtSecond.Text = ""
        txtCgpa.Text = ""


      
    End Sub

    Private Sub GpaCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class