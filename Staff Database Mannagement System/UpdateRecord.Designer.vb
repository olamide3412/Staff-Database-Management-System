<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateRecord
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txt_find_file_number = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.panelS2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_designation = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_department = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_address_next_of_kin = New System.Windows.Forms.TextBox()
        Me.txt_cadre_level = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_phone_next_of_kin = New System.Windows.Forms.TextBox()
        Me.txt_grade_level = New System.Windows.Forms.TextBox()
        Me.DateTimePicker_appointment = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_promotion = New System.Windows.Forms.DateTimePicker()
        Me.txt_next_of_kin = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker_confirmation = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_present_qualification = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.residential_address = New System.Windows.Forms.TextBox()
        Me.panelS1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker_dob = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.combo_gender = New System.Windows.Forms.ComboBox()
        Me.combo_marrige = New System.Windows.Forms.ComboBox()
        Me.txt_firstname = New System.Windows.Forms.TextBox()
        Me.txt_lga = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.combo_state = New System.Windows.Forms.ComboBox()
        Me.txt_surname = New System.Windows.Forms.TextBox()
        Me.txt_place_of_birth = New System.Windows.Forms.TextBox()
        Me.txt_qualification_at_employment = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.panelS2.SuspendLayout()
        Me.panelS1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_find_file_number
        '
        Me.txt_find_file_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_find_file_number.Location = New System.Drawing.Point(111, 17)
        Me.txt_find_file_number.Name = "txt_find_file_number"
        Me.txt_find_file_number.Size = New System.Drawing.Size(154, 24)
        Me.txt_find_file_number.TabIndex = 200
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(11, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 20)
        Me.Label18.TabIndex = 199
        Me.Label18.Text = "File Number"
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.Color.White
        Me.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_search.Location = New System.Drawing.Point(271, 18)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(69, 25)
        Me.btn_search.TabIndex = 201
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_find_file_number)
        Me.Panel1.Controls.Add(Me.btn_search)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(316, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(364, 57)
        Me.Panel1.TabIndex = 202
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox3.Controls.Add(Me.panelS2)
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Controls.Add(Me.panelS1)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(19, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1015, 648)
        Me.GroupBox3.TabIndex = 203
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "UPDATE STAFF INFORMATION"
        '
        'panelS2
        '
        Me.panelS2.Controls.Add(Me.Button4)
        Me.panelS2.Controls.Add(Me.btnUpdate)
        Me.panelS2.Controls.Add(Me.Label12)
        Me.panelS2.Controls.Add(Me.btn_delete)
        Me.panelS2.Controls.Add(Me.Label13)
        Me.panelS2.Controls.Add(Me.Label14)
        Me.panelS2.Controls.Add(Me.txt_designation)
        Me.panelS2.Controls.Add(Me.Label15)
        Me.panelS2.Controls.Add(Me.txt_department)
        Me.panelS2.Controls.Add(Me.Label22)
        Me.panelS2.Controls.Add(Me.Label16)
        Me.panelS2.Controls.Add(Me.txt_address_next_of_kin)
        Me.panelS2.Controls.Add(Me.txt_cadre_level)
        Me.panelS2.Controls.Add(Me.Label7)
        Me.panelS2.Controls.Add(Me.txt_phone_next_of_kin)
        Me.panelS2.Controls.Add(Me.txt_grade_level)
        Me.panelS2.Controls.Add(Me.DateTimePicker_appointment)
        Me.panelS2.Controls.Add(Me.DateTimePicker_promotion)
        Me.panelS2.Controls.Add(Me.txt_next_of_kin)
        Me.panelS2.Controls.Add(Me.Label4)
        Me.panelS2.Controls.Add(Me.DateTimePicker_confirmation)
        Me.panelS2.Controls.Add(Me.Label9)
        Me.panelS2.Controls.Add(Me.txt_present_qualification)
        Me.panelS2.Controls.Add(Me.Label20)
        Me.panelS2.Controls.Add(Me.Label21)
        Me.panelS2.Controls.Add(Me.Label19)
        Me.panelS2.Controls.Add(Me.residential_address)
        Me.panelS2.ForeColor = System.Drawing.Color.Black
        Me.panelS2.Location = New System.Drawing.Point(513, 93)
        Me.panelS2.Name = "panelS2"
        Me.panelS2.Size = New System.Drawing.Size(457, 537)
        Me.panelS2.TabIndex = 205
        Me.panelS2.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(307, 493)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(77, 25)
        Me.Button4.TabIndex = 199
        Me.Button4.Text = "CLEAR"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(103, 493)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(80, 25)
        Me.btnUpdate.TabIndex = 192
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 340)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(160, 20)
        Me.Label12.TabIndex = 171
        Me.Label12.Text = "Date Of Appointment"
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_delete.Location = New System.Drawing.Point(205, 493)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(80, 25)
        Me.btn_delete.TabIndex = 194
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 374)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(159, 20)
        Me.Label13.TabIndex = 173
        Me.Label13.Text = "Date Of Confirmation"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 409)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(141, 20)
        Me.Label14.TabIndex = 175
        Me.Label14.Text = "Date Of Promotion"
        '
        'txt_designation
        '
        Me.txt_designation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_designation.Location = New System.Drawing.Point(243, 297)
        Me.txt_designation.Name = "txt_designation"
        Me.txt_designation.Size = New System.Drawing.Size(215, 26)
        Me.txt_designation.TabIndex = 200
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 236)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 20)
        Me.Label15.TabIndex = 177
        Me.Label15.Text = "Grade Level"
        '
        'txt_department
        '
        Me.txt_department.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_department.Location = New System.Drawing.Point(243, 202)
        Me.txt_department.Multiline = True
        Me.txt_department.Name = "txt_department"
        Me.txt_department.Size = New System.Drawing.Size(214, 21)
        Me.txt_department.TabIndex = 190
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(15, 307)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(94, 20)
        Me.Label22.TabIndex = 199
        Me.Label22.Text = "Designation"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 267)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 20)
        Me.Label16.TabIndex = 179
        Me.Label16.Text = "Cadre Level"
        '
        'txt_address_next_of_kin
        '
        Me.txt_address_next_of_kin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address_next_of_kin.Location = New System.Drawing.Point(244, 128)
        Me.txt_address_next_of_kin.Multiline = True
        Me.txt_address_next_of_kin.Name = "txt_address_next_of_kin"
        Me.txt_address_next_of_kin.Size = New System.Drawing.Size(210, 26)
        Me.txt_address_next_of_kin.TabIndex = 186
        '
        'txt_cadre_level
        '
        Me.txt_cadre_level.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cadre_level.Location = New System.Drawing.Point(243, 264)
        Me.txt_cadre_level.Multiline = True
        Me.txt_cadre_level.Name = "txt_cadre_level"
        Me.txt_cadre_level.Size = New System.Drawing.Size(214, 21)
        Me.txt_cadre_level.TabIndex = 180
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 20)
        Me.Label7.TabIndex = 189
        Me.Label7.Text = "Department"
        '
        'txt_phone_next_of_kin
        '
        Me.txt_phone_next_of_kin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone_next_of_kin.Location = New System.Drawing.Point(242, 96)
        Me.txt_phone_next_of_kin.Multiline = True
        Me.txt_phone_next_of_kin.Name = "txt_phone_next_of_kin"
        Me.txt_phone_next_of_kin.Size = New System.Drawing.Size(210, 26)
        Me.txt_phone_next_of_kin.TabIndex = 184
        '
        'txt_grade_level
        '
        Me.txt_grade_level.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_grade_level.Location = New System.Drawing.Point(243, 233)
        Me.txt_grade_level.Multiline = True
        Me.txt_grade_level.Name = "txt_grade_level"
        Me.txt_grade_level.Size = New System.Drawing.Size(214, 21)
        Me.txt_grade_level.TabIndex = 178
        '
        'DateTimePicker_appointment
        '
        Me.DateTimePicker_appointment.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker_appointment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_appointment.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_appointment.Location = New System.Drawing.Point(244, 332)
        Me.DateTimePicker_appointment.Name = "DateTimePicker_appointment"
        Me.DateTimePicker_appointment.Size = New System.Drawing.Size(214, 26)
        Me.DateTimePicker_appointment.TabIndex = 172
        '
        'DateTimePicker_promotion
        '
        Me.DateTimePicker_promotion.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker_promotion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_promotion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_promotion.Location = New System.Drawing.Point(244, 404)
        Me.DateTimePicker_promotion.Name = "DateTimePicker_promotion"
        Me.DateTimePicker_promotion.Size = New System.Drawing.Size(214, 26)
        Me.DateTimePicker_promotion.TabIndex = 176
        '
        'txt_next_of_kin
        '
        Me.txt_next_of_kin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_next_of_kin.Location = New System.Drawing.Point(242, 64)
        Me.txt_next_of_kin.Multiline = True
        Me.txt_next_of_kin.Name = "txt_next_of_kin"
        Me.txt_next_of_kin.Size = New System.Drawing.Size(210, 26)
        Me.txt_next_of_kin.TabIndex = 182
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 20)
        Me.Label4.TabIndex = 169
        Me.Label4.Text = "Present Qualification"
        '
        'DateTimePicker_confirmation
        '
        Me.DateTimePicker_confirmation.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker_confirmation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_confirmation.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_confirmation.Location = New System.Drawing.Point(244, 366)
        Me.DateTimePicker_confirmation.Name = "DateTimePicker_confirmation"
        Me.DateTimePicker_confirmation.Size = New System.Drawing.Size(214, 26)
        Me.DateTimePicker_confirmation.TabIndex = 174
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 20)
        Me.Label9.TabIndex = 160
        Me.Label9.Text = "Residential Address"
        '
        'txt_present_qualification
        '
        Me.txt_present_qualification.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_present_qualification.Location = New System.Drawing.Point(243, 26)
        Me.txt_present_qualification.Multiline = True
        Me.txt_present_qualification.Name = "txt_present_qualification"
        Me.txt_present_qualification.Size = New System.Drawing.Size(210, 26)
        Me.txt_present_qualification.TabIndex = 170
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 98)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(211, 20)
        Me.Label20.TabIndex = 183
        Me.Label20.Text = "Phone Number of Next of kin"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(16, 131)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(164, 20)
        Me.Label21.TabIndex = 185
        Me.Label21.Text = "Address of Next of kin"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 64)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 20)
        Me.Label19.TabIndex = 181
        Me.Label19.Text = "Next of Kin"
        '
        'residential_address
        '
        Me.residential_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.residential_address.Location = New System.Drawing.Point(244, 165)
        Me.residential_address.Name = "residential_address"
        Me.residential_address.Size = New System.Drawing.Size(210, 26)
        Me.residential_address.TabIndex = 110
        '
        'panelS1
        '
        Me.panelS1.Controls.Add(Me.Panel5)
        Me.panelS1.Controls.Add(Me.Label8)
        Me.panelS1.Controls.Add(Me.DateTimePicker_dob)
        Me.panelS1.Controls.Add(Me.Label5)
        Me.panelS1.Controls.Add(Me.Label23)
        Me.panelS1.Controls.Add(Me.Label45)
        Me.panelS1.Controls.Add(Me.Label10)
        Me.panelS1.Controls.Add(Me.Label11)
        Me.panelS1.Controls.Add(Me.Label1)
        Me.panelS1.Controls.Add(Me.Label2)
        Me.panelS1.Controls.Add(Me.combo_gender)
        Me.panelS1.Controls.Add(Me.combo_marrige)
        Me.panelS1.Controls.Add(Me.txt_firstname)
        Me.panelS1.Controls.Add(Me.txt_lga)
        Me.panelS1.Controls.Add(Me.Label3)
        Me.panelS1.Controls.Add(Me.combo_state)
        Me.panelS1.Controls.Add(Me.txt_surname)
        Me.panelS1.Controls.Add(Me.txt_place_of_birth)
        Me.panelS1.Controls.Add(Me.txt_qualification_at_employment)
        Me.panelS1.ForeColor = System.Drawing.Color.Black
        Me.panelS1.Location = New System.Drawing.Point(29, 93)
        Me.panelS1.Name = "panelS1"
        Me.panelS1.Size = New System.Drawing.Size(478, 537)
        Me.panelS1.TabIndex = 204
        Me.panelS1.Visible = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Location = New System.Drawing.Point(14, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(440, 198)
        Me.Panel5.TabIndex = 201
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Staff_Database_Mannagement_System.My.Resources.Resources.photo
        Me.PictureBox1.Location = New System.Drawing.Point(216, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(217, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 161
        Me.PictureBox1.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(9, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 20)
        Me.Label17.TabIndex = 191
        Me.Label17.Text = "Passport Photo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 308)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 20)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Gender"
        '
        'DateTimePicker_dob
        '
        Me.DateTimePicker_dob.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker_dob.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_dob.Location = New System.Drawing.Point(247, 342)
        Me.DateTimePicker_dob.Name = "DateTimePicker_dob"
        Me.DateTimePicker_dob.Size = New System.Drawing.Size(210, 26)
        Me.DateTimePicker_dob.TabIndex = 203
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "FirstName"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(19, 342)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(102, 20)
        Me.Label23.TabIndex = 202
        Me.Label23.Text = "Date Of Birth"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(19, 276)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(115, 20)
        Me.Label45.TabIndex = 21
        Me.Label45.Text = "Marital Status: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 438)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 20)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "L.G.A"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 406)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 20)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "State Of Origin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 163
        Me.Label1.Text = "Surname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 372)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 165
        Me.Label2.Text = "Place of Birth"
        '
        'combo_gender
        '
        Me.combo_gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_gender.FormattingEnabled = True
        Me.combo_gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.combo_gender.Location = New System.Drawing.Point(245, 308)
        Me.combo_gender.Name = "combo_gender"
        Me.combo_gender.Size = New System.Drawing.Size(210, 28)
        Me.combo_gender.TabIndex = 103
        '
        'combo_marrige
        '
        Me.combo_marrige.BackColor = System.Drawing.Color.White
        Me.combo_marrige.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_marrige.FormattingEnabled = True
        Me.combo_marrige.Items.AddRange(New Object() {"Single", "Maried"})
        Me.combo_marrige.Location = New System.Drawing.Point(246, 276)
        Me.combo_marrige.Name = "combo_marrige"
        Me.combo_marrige.Size = New System.Drawing.Size(210, 28)
        Me.combo_marrige.TabIndex = 109
        '
        'txt_firstname
        '
        Me.txt_firstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_firstname.Location = New System.Drawing.Point(246, 216)
        Me.txt_firstname.Name = "txt_firstname"
        Me.txt_firstname.Size = New System.Drawing.Size(210, 26)
        Me.txt_firstname.TabIndex = 100
        '
        'txt_lga
        '
        Me.txt_lga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lga.Location = New System.Drawing.Point(245, 439)
        Me.txt_lga.Name = "txt_lga"
        Me.txt_lga.Size = New System.Drawing.Size(210, 26)
        Me.txt_lga.TabIndex = 112
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 473)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 20)
        Me.Label3.TabIndex = 167
        Me.Label3.Text = "Qualification At Employment"
        '
        'combo_state
        '
        Me.combo_state.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_state.FormattingEnabled = True
        Me.combo_state.Items.AddRange(New Object() {"States", "Abia", "Adamawa", "Akwa Ibom", "Anambra", "Bauchi", "Bayelsa", "Benue", "Borno", "Cross River", "Delta", "Ebonyi", "Enugu", "Edo", "Ekiti", "Gombe", "Imo", "Jigawa", "Kaduna", "Kano", "Katsina", "Kebbi", "Kogi", "Kwara", "Lagos", "Nasarawa", "Niger", "Ogun", "Ondo", "Osun", "Oyo", "Plateau", "Rivers", "Sokoto", "Taraba", "Yobe", "Zamfara"})
        Me.combo_state.Location = New System.Drawing.Point(245, 406)
        Me.combo_state.Name = "combo_state"
        Me.combo_state.Size = New System.Drawing.Size(210, 28)
        Me.combo_state.TabIndex = 111
        '
        'txt_surname
        '
        Me.txt_surname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_surname.Location = New System.Drawing.Point(246, 246)
        Me.txt_surname.Name = "txt_surname"
        Me.txt_surname.Size = New System.Drawing.Size(210, 26)
        Me.txt_surname.TabIndex = 164
        '
        'txt_place_of_birth
        '
        Me.txt_place_of_birth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_place_of_birth.Location = New System.Drawing.Point(245, 375)
        Me.txt_place_of_birth.Name = "txt_place_of_birth"
        Me.txt_place_of_birth.Size = New System.Drawing.Size(210, 26)
        Me.txt_place_of_birth.TabIndex = 166
        '
        'txt_qualification_at_employment
        '
        Me.txt_qualification_at_employment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qualification_at_employment.Location = New System.Drawing.Point(247, 473)
        Me.txt_qualification_at_employment.Multiline = True
        Me.txt_qualification_at_employment.Name = "txt_qualification_at_employment"
        Me.txt_qualification_at_employment.Size = New System.Drawing.Size(210, 26)
        Me.txt_qualification_at_employment.TabIndex = 168
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(1019, 719)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 26)
        Me.Label6.TabIndex = 204
        Me.Label6.Text = "X"
        '
        'UpdateRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1053, 749)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UpdateRecord"
        Me.Text = "UpdateRecord"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.panelS2.ResumeLayout(False)
        Me.panelS2.PerformLayout()
        Me.panelS1.ResumeLayout(False)
        Me.panelS1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_find_file_number As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents btn_search As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents panelS2 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_designation As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_department As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_cadre_level As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_grade_level As TextBox
    Friend WithEvents DateTimePicker_appointment As DateTimePicker
    Friend WithEvents DateTimePicker_promotion As DateTimePicker
    Friend WithEvents DateTimePicker_confirmation As DateTimePicker
    Friend WithEvents Button4 As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents panelS1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker_dob As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_address_next_of_kin As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_phone_next_of_kin As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_next_of_kin As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents combo_gender As ComboBox
    Friend WithEvents combo_marrige As ComboBox
    Friend WithEvents txt_firstname As TextBox
    Friend WithEvents txt_lga As TextBox
    Friend WithEvents combo_state As ComboBox
    Friend WithEvents residential_address As TextBox
    Friend WithEvents txt_surname As TextBox
    Friend WithEvents txt_place_of_birth As TextBox
    Friend WithEvents txt_qualification_at_employment As TextBox
    Friend WithEvents txt_present_qualification As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label6 As Label
End Class
