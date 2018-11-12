Public Class Registration_Page

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        txtConfirm.Text = ""

      
        Form2.Show()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs)

        '    If txtPhone.Text = "" And txtEmail.Text = "" And txtFirst.Text = "" And txtMatric.Text = "" And txtOther.Text = "" Then
        'lblError.Text = "Please Enter Credentials"
        'ElseIf txtConfirm.Text <> txtPassword.Text Then
        'lblError.Text = "Check Passwords And Try Again"

        '     ElseIf txtPhone.Text = "" Then
        '    lblError.Text = "Please Enter Phone Number"

        '        ElseIf txtEmail.Text = "" Then
        '       lblError.Text = "Please Enter E-mail Address"


        '        ElseIf txtMatric.Text = "" Then
        '       lblError.Text = "Please Enter Matric No "

        '        ElseIf txtFirst.Text = "" Then
        '       lblError.Text = "Please Enter First Name "

        '        ElseIf txtOther.Text = "" Then
        '       lblError.Text = "Please Enter Other Names "

        '        ElseIf txtPassword.Text = "" Or txtConfirm.Text = "" Then

        'lblError.Text = "Please Enter Password"


        '        ElseIf rdbMale.Checked = False And rdbFemale.Checked = False Then
        '       MsgBox("Click On Your Gender ", MsgBoxStyle.Information)

        '        ElseIf cmbDept..Visible = False  Or cmbFac..Visible = False  Or cmbLevel..Visible = False  Then
        '       lblError.Text = "Please Choose Missing Dropdown Options"

        '        ElseIf cmbProgramme..Visible = False  Or cmbSemester..Visible = False  Or cmbSession..Visible = False  Then
        '       lblError.Text = "Please Choose Missing Dropdown Options"


        '        Else

        '        MsgBox("Thanks For Registering", MsgBoxStyle.Information)

        '    Form2.Show()
        '   txtConfirm.Text = ""
        '   txtEmail.Text = ""
        '  txtFirst.Text = ""
        ' txtMatric.Text = ""
        '     txtFirst.Text = ""
        '    txtOther.Text = ""
        '   txtPassword.Text = ""
        '  txtPhone.Text = ""
        ' cmbDept..Visible = False 
        '    cmbFac..Visible = False 
        '   cmbLevel..Visible = False 
        '  cmbProgramme..Visible = False 
        ' cmbSemester..Visible = False 
        '      cmbSession..Visible = False 
        '
        '
        '   Me.Hide()

        ' End If




      



    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
     
        If CheckBox1.Checked And PasswordTextBox.UseSystemPasswordChar = True And txtConfirm.UseSystemPasswordChar = True Then
            CheckBox1.Text = "Hide Password"

            PasswordTextBox.UseSystemPasswordChar = False
            txtConfirm.UseSystemPasswordChar = False

        Else
            PasswordTextBox.UseSystemPasswordChar = True
            txtConfirm.UseSystemPasswordChar = True
            CheckBox1.Text = "Show Password"

        End If

    End Sub



    Private Sub StudentTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StudentTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentUtilityDataSet1)
        MsgBox("Your Account Has Been Created Successfully", MsgBoxStyle.Information)



        'FirstNameTextBox.Text = ""
        'PhoneTextBox.Text = ""

        'OtherNameTextBox.Text = ""

        'EmailTextBox.Text = ""
        'FacultyComboBox.SelectedItem = -1

        'LevelComboBox.SelectedItem = -1
        'DepartmentComboBox.SelectedItem = -1
        'SessionComboBox.SelectedItem = -1

        'SemesterComboBox.SelectedItem = -1
        'ProgrammeComboBox.SelectedItem = -1

        'txtConfirm.Text = ""

        Form2.Show()
        Me.Hide()



    End Sub

    Private Sub Registration_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentUtilityDataSet1.StudentTable' table.  can move, or remove it, as needed.
        Me.StudentTableTableAdapter.Fill(Me.StudentUtilityDataSet1.StudentTable)
        StudentTableBindingSource.AddNew()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Try
            StudentTableBindingSource.EndEdit()

            TableAdapterManager.UpdateAll(StudentUtilityDataSet1)
            MsgBox("Successfully Saved!!", MsgBoxStyle.Information)
            Form2.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


        'FirstNameTextBox.Text = ""
        'PhoneTextBox.Text = ""

        'OtherNameTextBox.Text = ""

        'EmailTextBox.Text = ""
        'FacultyComboBox.SelectedItem = -1

        'LevelComboBox.SelectedItem = -1
        'DepartmentComboBox.SelectedItem = -1
        'SessionComboBox.SelectedItem = -1

        'SemesterComboBox.SelectedItem = -1
        'ProgrammeComboBox.SelectedItem = -1
        'MatricNoTextBox.Text = ""
        'txtConfirm.Text = ""

    End Sub


   

    Private Sub LevelComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LevelComboBox.SelectedIndexChanged
        lblError.Text = ""
    End Sub

    Private Sub DepartmentComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DepartmentComboBox.SelectedIndexChanged
        lblError.Text = ""
    End Sub

    Private Sub SessionComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SessionComboBox.SelectedIndexChanged
        lblError.Text = ""
    End Sub

    Private Sub SemesterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SemesterComboBox.SelectedIndexChanged
        lblError.Text = ""
    End Sub

    Private Sub ProgrammeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProgrammeComboBox.SelectedIndexChanged
        lblError.Text = ""
    End Sub

    Private Sub MatricNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles MatricNoTextBox.TextChanged
        lblError.Text = ""
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
        lblError.Text = ""

    End Sub

    Private Sub txtConfirm_TextChanged(sender As Object, e As EventArgs) Handles txtConfirm.TextChanged
        lblError.Text = ""
    End Sub

    Private Sub FacultyComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FacultyComboBox.SelectedIndexChanged
        lblError.Text = ""
    End Sub

    Private Sub PhoneTextBox_TextChanged(sender As Object, e As EventArgs) Handles PhoneTextBox.TextChanged
        lblError.Text = ""
    End Sub

    Private Sub EmailTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmailTextBox.TextChanged
        lblError.Text = ""
    End Sub

    Private Sub FirstNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstNameTextBox.TextChanged
        lblError.Text = ""
    End Sub

    Private Sub OtherNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles OtherNameTextBox.TextChanged
        lblError.Text = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Admin" Then

            lblMatric.Text = "User ID :"
            lblDepartment.Text = ""
            DepartmentComboBox.Visible = False
            FacultyComboBox.Visible = False
            LevelComboBox.Visible = False
            ProgrammeComboBox.Visible = False
            SemesterComboBox.Visible = False
            SessionComboBox.Visible = False
            lblDepartment.Text = ""
            lblFaculty.Text = ""
            lblLevel.Text = ""
            lblProgramme.Text = ""
            lblSemester.Text = ""
            lblSession.Text = ""
            LoginPage.lblLoginMess.Text = "ADMIN " + "LOGIN"

        ElseIf ComboBox1.SelectedItem = "Support" Then
            lblMatric.Text = "User ID :"
            lblDepartment.Text = ""
            DepartmentComboBox.Visible = False
            FacultyComboBox.Visible = False
            LevelComboBox.Visible = False
            ProgrammeComboBox.Visible = False
            SemesterComboBox.Visible = False
            SessionComboBox.Visible = False
            lblDepartment.Text = ""
            lblFaculty.Text = ""
            lblLevel.Text = ""
            lblProgramme.Text = ""
            lblSemester.Text = ""
            lblSession.Text = ""
            LoginPage.lblLoginMess.Text = "SUPPORT" + "LOGIN "

        ElseIf ComboBox1.SelectedItem = "Student" Then
            lblMatric.Text = "Matric No. :"
            LoginPage.lblLoginMess.Text = "STUDENT " + "LOGIN"
            lblDepartment.Text = "Department :"
            lblFaculty.Text = "Faculty :"
            lblLevel.Text = "Level :"
            lblProgramme.Text = "Programme :"
            lblSemester.Text = "Semester :"
            lblSession.Text = "Session :"

            DepartmentComboBox.Visible = True
            FacultyComboBox.Visible = True
            LevelComboBox.Visible = True
            ProgrammeComboBox.Visible = True
            SemesterComboBox.Visible = True
            SessionComboBox.Visible = True


        ElseIf ComboBox1.SelectedItem = "Extras" Then
            MsgBox("Selected Position is Extras")

        End If



    End Sub

   
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        LoginPage.Show()

    End Sub

   
    
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnSubmit.Click
      



        Try
            Me.Validate()
            Me.StudentTableBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.StudentUtilityDataSet1)
            MsgBox("Your Account Has Been Created Successfully", MsgBoxStyle.Information)


           

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try



        My.Settings.username = MatricNoTextBox.Text
        My.Settings.password = PasswordTextBox.Text


        My.Settings.Save()
        Me.Hide()
        LoginPage.Show()
    End Sub
End Class