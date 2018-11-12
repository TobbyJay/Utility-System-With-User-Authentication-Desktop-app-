<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration_Page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registration_Page))
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblFaculty = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblProgramme = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblSession = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblMatric = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Sex1RadioButton = New System.Windows.Forms.RadioButton()
        Me.StudentTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentUtilityDataSet1 = New student_portal.StudentUtilityDataSet1()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.OtherNameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.DateOfBirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FacultyComboBox = New System.Windows.Forms.ComboBox()
        Me.LevelComboBox = New System.Windows.Forms.ComboBox()
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.SexRadioButton = New System.Windows.Forms.RadioButton()
        Me.SessionComboBox = New System.Windows.Forms.ComboBox()
        Me.SemesterComboBox = New System.Windows.Forms.ComboBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.ProgrammeComboBox = New System.Windows.Forms.ComboBox()
        Me.MatricNoTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StudentTableTableAdapter = New student_portal.StudentUtilityDataSet1TableAdapters.StudentTableTableAdapter()
        Me.TableAdapterManager = New student_portal.StudentUtilityDataSet1TableAdapters.TableAdapterManager()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        PasswordLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.StudentTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentUtilityDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        PasswordLabel.ForeColor = System.Drawing.Color.RoyalBlue
        PasswordLabel.Location = New System.Drawing.Point(38, 516)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(78, 19)
        PasswordLabel.TabIndex = 30
        PasswordLabel.Text = "Password:"
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Silver
        Me.RectangleShape2.Enabled = False
        Me.RectangleShape2.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central
        Me.RectangleShape2.Location = New System.Drawing.Point(21, 131)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(221, 1)
        Me.RectangleShape2.Visible = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1036, 642)
        Me.ShapeContainer2.TabIndex = 3
        Me.ShapeContainer2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(286, 641)
        Me.Panel1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.Location = New System.Drawing.Point(81, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "WELCOME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(60, 347)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = " Get Started.."
        Me.Label2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(30, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(242, 247)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.Red
        Me.label5.Location = New System.Drawing.Point(65, 204)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(0, 15)
        Me.label5.TabIndex = 11
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Gray
        Me.CheckBox1.Location = New System.Drawing.Point(51, 605)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(123, 22)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(679, 11)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 29)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 2
        Me.PictureBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(61, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 19)
        Me.Label1.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(35, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 19)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Personal Details"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Red
        Me.Label25.Location = New System.Drawing.Point(38, 412)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(120, 19)
        Me.Label25.TabIndex = 46
        Me.Label25.Text = "Account  Details"
        '
        'txtConfirm
        '
        Me.txtConfirm.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirm.ForeColor = System.Drawing.Color.Black
        Me.txtConfirm.Location = New System.Drawing.Point(181, 560)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.Size = New System.Drawing.Size(191, 26)
        Me.txtConfirm.TabIndex = 49
        Me.txtConfirm.UseSystemPasswordChar = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Blue
        Me.lblError.Location = New System.Drawing.Point(277, 41)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 19)
        Me.lblError.TabIndex = 59
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.Lavender
        Me.panel2.Controls.Add(Me.Label22)
        Me.panel2.Controls.Add(Me.Label21)
        Me.panel2.Controls.Add(Me.Label20)
        Me.panel2.Controls.Add(Me.lblFaculty)
        Me.panel2.Controls.Add(Me.lblLevel)
        Me.panel2.Controls.Add(Me.lblDepartment)
        Me.panel2.Controls.Add(Me.Label16)
        Me.panel2.Controls.Add(Me.Label15)
        Me.panel2.Controls.Add(Me.lblProgramme)
        Me.panel2.Controls.Add(Me.lblSemester)
        Me.panel2.Controls.Add(Me.lblSession)
        Me.panel2.Controls.Add(Me.Label7)
        Me.panel2.Controls.Add(Me.lblMatric)
        Me.panel2.Controls.Add(Me.btnSubmit)
        Me.panel2.Controls.Add(Me.ComboBox1)
        Me.panel2.Controls.Add(Me.Label6)
        Me.panel2.Controls.Add(Me.CheckBox1)
        Me.panel2.Controls.Add(Me.txtConfirm)
        Me.panel2.Controls.Add(Me.Label4)
        Me.panel2.Controls.Add(Me.Label25)
        Me.panel2.Controls.Add(Me.Sex1RadioButton)
        Me.panel2.Controls.Add(Me.Label14)
        Me.panel2.Controls.Add(Me.FirstNameTextBox)
        Me.panel2.Controls.Add(Me.OtherNameTextBox)
        Me.panel2.Controls.Add(Me.PhoneTextBox)
        Me.panel2.Controls.Add(Me.DateOfBirthDateTimePicker)
        Me.panel2.Controls.Add(Me.FacultyComboBox)
        Me.panel2.Controls.Add(Me.LevelComboBox)
        Me.panel2.Controls.Add(Me.DepartmentComboBox)
        Me.panel2.Controls.Add(Me.SexRadioButton)
        Me.panel2.Controls.Add(Me.SessionComboBox)
        Me.panel2.Controls.Add(Me.SemesterComboBox)
        Me.panel2.Controls.Add(Me.EmailTextBox)
        Me.panel2.Controls.Add(Me.ProgrammeComboBox)
        Me.panel2.Controls.Add(Me.MatricNoTextBox)
        Me.panel2.Controls.Add(PasswordLabel)
        Me.panel2.Controls.Add(Me.PasswordTextBox)
        Me.panel2.Controls.Add(Me.lblError)
        Me.panel2.Controls.Add(Me.Label1)
        Me.panel2.Controls.Add(Me.PictureBox5)
        Me.panel2.Controls.Add(Me.label5)
        Me.panel2.Controls.Add(Me.ShapeContainer1)
        Me.panel2.Controls.Add(Me.GroupBox1)
        Me.panel2.Controls.Add(Me.Button1)
        Me.panel2.ForeColor = System.Drawing.Color.Transparent
        Me.panel2.Location = New System.Drawing.Point(286, 1)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(750, 641)
        Me.panel2.TabIndex = 2
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label22.Location = New System.Drawing.Point(390, 149)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(107, 19)
        Me.Label22.TabIndex = 79
        Me.Label22.Text = "Other Names :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label21.Location = New System.Drawing.Point(55, 192)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(61, 19)
        Me.Label21.TabIndex = 78
        Me.Label21.Text = "Phone :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label20.Location = New System.Drawing.Point(391, 192)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 19)
        Me.Label20.TabIndex = 77
        Me.Label20.Text = "E-Mail :"
        '
        'lblFaculty
        '
        Me.lblFaculty.AutoSize = True
        Me.lblFaculty.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaculty.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblFaculty.Location = New System.Drawing.Point(55, 240)
        Me.lblFaculty.Name = "lblFaculty"
        Me.lblFaculty.Size = New System.Drawing.Size(66, 19)
        Me.lblFaculty.TabIndex = 76
        Me.lblFaculty.Text = "Faculty :"
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblLevel.Location = New System.Drawing.Point(391, 243)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(52, 19)
        Me.lblLevel.TabIndex = 75
        Me.lblLevel.Text = "Level :"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblDepartment.Location = New System.Drawing.Point(53, 288)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(100, 19)
        Me.lblDepartment.TabIndex = 74
        Me.lblDepartment.Text = "Department :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.Location = New System.Drawing.Point(393, 288)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 19)
        Me.Label16.TabIndex = 73
        Me.Label16.Text = "Sex :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label15.Location = New System.Drawing.Point(50, 336)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 19)
        Me.Label15.TabIndex = 72
        Me.Label15.Text = "Date Of Birth :"
        '
        'lblProgramme
        '
        Me.lblProgramme.AutoSize = True
        Me.lblProgramme.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgramme.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblProgramme.Location = New System.Drawing.Point(50, 377)
        Me.lblProgramme.Name = "lblProgramme"
        Me.lblProgramme.Size = New System.Drawing.Size(97, 19)
        Me.lblProgramme.TabIndex = 71
        Me.lblProgramme.Text = "Programme :"
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemester.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblSemester.Location = New System.Drawing.Point(393, 377)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(80, 19)
        Me.lblSemester.TabIndex = 70
        Me.lblSemester.Text = "Semester :"
        '
        'lblSession
        '
        Me.lblSession.AutoSize = True
        Me.lblSession.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSession.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblSession.Location = New System.Drawing.Point(393, 339)
        Me.lblSession.Name = "lblSession"
        Me.lblSession.Size = New System.Drawing.Size(67, 19)
        Me.lblSession.TabIndex = 69
        Me.lblSession.Text = "Session :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Location = New System.Drawing.Point(55, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 19)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "First Name :"
        '
        'lblMatric
        '
        Me.lblMatric.AutoSize = True
        Me.lblMatric.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatric.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblMatric.Location = New System.Drawing.Point(40, 459)
        Me.lblMatric.Name = "lblMatric"
        Me.lblMatric.Size = New System.Drawing.Size(90, 19)
        Me.lblMatric.TabIndex = 64
        Me.lblMatric.Text = "Matric No. :"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(523, 595)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(119, 33)
        Me.btnSubmit.TabIndex = 63
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"", "Student", "Admin", "Support", "Extras"})
        Me.ComboBox1.Location = New System.Drawing.Point(159, 102)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(127, 23)
        Me.ComboBox1.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(55, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 19)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "ROLE :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(38, 566)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 19)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Confirm Password :"
        '
        'Sex1RadioButton
        '
        Me.Sex1RadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.StudentTableBindingSource, "Sex1", True))
        Me.Sex1RadioButton.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sex1RadioButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Sex1RadioButton.Location = New System.Drawing.Point(580, 280)
        Me.Sex1RadioButton.Name = "Sex1RadioButton"
        Me.Sex1RadioButton.Size = New System.Drawing.Size(89, 24)
        Me.Sex1RadioButton.TabIndex = 19
        Me.Sex1RadioButton.Text = "Female"
        Me.Sex1RadioButton.UseVisualStyleBackColor = True
        '
        'StudentTableBindingSource
        '
        Me.StudentTableBindingSource.DataMember = "StudentTable"
        Me.StudentTableBindingSource.DataSource = Me.StudentUtilityDataSet1
        '
        'StudentUtilityDataSet1
        '
        Me.StudentUtilityDataSet1.DataSetName = "StudentUtilityDataSet1"
        Me.StudentUtilityDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentTableBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.ForeColor = System.Drawing.Color.Black
        Me.FirstNameTextBox.Location = New System.Drawing.Point(159, 146)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.FirstNameTextBox.TabIndex = 3
        '
        'OtherNameTextBox
        '
        Me.OtherNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentTableBindingSource, "OtherName", True))
        Me.OtherNameTextBox.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OtherNameTextBox.ForeColor = System.Drawing.Color.Black
        Me.OtherNameTextBox.Location = New System.Drawing.Point(504, 146)
        Me.OtherNameTextBox.Name = "OtherNameTextBox"
        Me.OtherNameTextBox.Size = New System.Drawing.Size(214, 26)
        Me.OtherNameTextBox.TabIndex = 5
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentTableBindingSource, "Phone", True))
        Me.PhoneTextBox.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTextBox.ForeColor = System.Drawing.Color.Black
        Me.PhoneTextBox.Location = New System.Drawing.Point(159, 189)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(200, 26)
        Me.PhoneTextBox.TabIndex = 7
        '
        'DateOfBirthDateTimePicker
        '
        Me.DateOfBirthDateTimePicker.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOfBirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StudentTableBindingSource, "DateOfBirth", True))
        Me.DateOfBirthDateTimePicker.Location = New System.Drawing.Point(163, 335)
        Me.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker"
        Me.DateOfBirthDateTimePicker.Size = New System.Drawing.Size(196, 20)
        Me.DateOfBirthDateTimePicker.TabIndex = 9
        Me.DateOfBirthDateTimePicker.Value = New Date(2017, 10, 13, 0, 0, 0, 0)
        '
        'FacultyComboBox
        '
        Me.FacultyComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.FacultyComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentTableBindingSource, "Faculty", True))
        Me.FacultyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FacultyComboBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacultyComboBox.FormattingEnabled = True
        Me.FacultyComboBox.Items.AddRange(New Object() {"", "School of Art, Designing & Prnting ", "School of Engineering", "School of Environmental Studies", "School of Liberal Studies", "School of Management & Business Studies ", "School of Science", "School of Technology", "School of Technical Education"})
        Me.FacultyComboBox.Location = New System.Drawing.Point(159, 241)
        Me.FacultyComboBox.Name = "FacultyComboBox"
        Me.FacultyComboBox.Size = New System.Drawing.Size(213, 23)
        Me.FacultyComboBox.TabIndex = 11
        '
        'LevelComboBox
        '
        Me.LevelComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.LevelComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentTableBindingSource, "Level", True))
        Me.LevelComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LevelComboBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelComboBox.FormattingEnabled = True
        Me.LevelComboBox.Items.AddRange(New Object() {"", "ND1", "ND2", "ND3" & Global.Microsoft.VisualBasic.ChrW(9), "HND1", "HND2", "HND3"})
        Me.LevelComboBox.Location = New System.Drawing.Point(503, 240)
        Me.LevelComboBox.Name = "LevelComboBox"
        Me.LevelComboBox.Size = New System.Drawing.Size(69, 23)
        Me.LevelComboBox.TabIndex = 13
        '
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.DepartmentComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentTableBindingSource, "Department", True))
        Me.DepartmentComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DepartmentComboBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Items.AddRange(New Object() {"", "Computer Technology", "Electrical Engineering"})
        Me.DepartmentComboBox.Location = New System.Drawing.Point(159, 286)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(213, 23)
        Me.DepartmentComboBox.TabIndex = 15
        '
        'SexRadioButton
        '
        Me.SexRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.StudentTableBindingSource, "Sex", True))
        Me.SexRadioButton.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SexRadioButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SexRadioButton.Location = New System.Drawing.Point(509, 280)
        Me.SexRadioButton.Name = "SexRadioButton"
        Me.SexRadioButton.Size = New System.Drawing.Size(200, 24)
        Me.SexRadioButton.TabIndex = 17
        Me.SexRadioButton.Text = "Male"
        Me.SexRadioButton.UseVisualStyleBackColor = True
        '
        'SessionComboBox
        '
        Me.SessionComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.SessionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentTableBindingSource, "Session", True))
        Me.SessionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SessionComboBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SessionComboBox.FormattingEnabled = True
        Me.SessionComboBox.Items.AddRange(New Object() {"", "2010/2011", "2011/2012", "2012/2013", "2013/2014", "2014/2015", "2015/2016", "2016/2017", "2017/2018", "2018/2019", "2019/2020"})
        Me.SessionComboBox.Location = New System.Drawing.Point(504, 334)
        Me.SessionComboBox.Name = "SessionComboBox"
        Me.SessionComboBox.Size = New System.Drawing.Size(79, 23)
        Me.SessionComboBox.TabIndex = 21
        '
        'SemesterComboBox
        '
        Me.SemesterComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.SemesterComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentTableBindingSource, "Semester", True))
        Me.SemesterComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SemesterComboBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SemesterComboBox.FormattingEnabled = True
        Me.SemesterComboBox.Items.AddRange(New Object() {"", "1", "2"})
        Me.SemesterComboBox.Location = New System.Drawing.Point(503, 375)
        Me.SemesterComboBox.Name = "SemesterComboBox"
        Me.SemesterComboBox.Size = New System.Drawing.Size(80, 23)
        Me.SemesterComboBox.TabIndex = 23
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentTableBindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.ForeColor = System.Drawing.Color.Black
        Me.EmailTextBox.Location = New System.Drawing.Point(504, 186)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(214, 26)
        Me.EmailTextBox.TabIndex = 25
        '
        'ProgrammeComboBox
        '
        Me.ProgrammeComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ProgrammeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentTableBindingSource, "Programme", True))
        Me.ProgrammeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ProgrammeComboBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgrammeComboBox.FormattingEnabled = True
        Me.ProgrammeComboBox.Items.AddRange(New Object() {"", "FULL TIME"})
        Me.ProgrammeComboBox.Location = New System.Drawing.Point(163, 375)
        Me.ProgrammeComboBox.Name = "ProgrammeComboBox"
        Me.ProgrammeComboBox.Size = New System.Drawing.Size(200, 23)
        Me.ProgrammeComboBox.TabIndex = 27
        '
        'MatricNoTextBox
        '
        Me.MatricNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentTableBindingSource, "MatricNo", True))
        Me.MatricNoTextBox.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatricNoTextBox.ForeColor = System.Drawing.Color.Gray
        Me.MatricNoTextBox.Location = New System.Drawing.Point(146, 457)
        Me.MatricNoTextBox.Name = "MatricNoTextBox"
        Me.MatricNoTextBox.Size = New System.Drawing.Size(191, 26)
        Me.MatricNoTextBox.TabIndex = 29
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentTableBindingSource, "Password", True))
        Me.PasswordTextBox.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.ForeColor = System.Drawing.Color.Black
        Me.PasswordTextBox.Location = New System.Drawing.Point(163, 508)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(191, 26)
        Me.PasswordTextBox.TabIndex = 31
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.AutoScroll = True
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(750, 641)
        Me.ShapeContainer1.TabIndex = 28
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Gray
        Me.RectangleShape1.Location = New System.Drawing.Point(-187, -7)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(1, 552)
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(6, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(722, 24)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SIGN-UP"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(-148, 596)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 33)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Done"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'StudentTableTableAdapter
        '
        Me.StudentTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StudentTableTableAdapter = Me.StudentTableTableAdapter
        Me.TableAdapterManager.UpdateOrder = student_portal.StudentUtilityDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Timer1
        '
        '
        'Registration_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1036, 642)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.ShapeContainer2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registration_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration_Page"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.StudentTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentUtilityDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents lblError As System.Windows.Forms.Label
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents StudentUtilityDataSet1 As student_portal.StudentUtilityDataSet1
    Friend WithEvents StudentTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableTableAdapter As student_portal.StudentUtilityDataSet1TableAdapters.StudentTableTableAdapter
    Friend WithEvents TableAdapterManager As student_portal.StudentUtilityDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OtherNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateOfBirthDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FacultyComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LevelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DepartmentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SexRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Sex1RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SessionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SemesterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProgrammeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MatricNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblMatric As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblFaculty As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblProgramme As System.Windows.Forms.Label
    Friend WithEvents lblSemester As System.Windows.Forms.Label
    Friend WithEvents lblSession As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
