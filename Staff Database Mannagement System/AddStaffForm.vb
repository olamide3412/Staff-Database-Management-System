Imports System.Data.OleDb
Imports System.IO

Public Class AddStaffForm
    Public con As ADODB.Connection
    Public rs As ADODB.Recordset
    Public strcon, str As String
    Public photoPath As String
    Public con_grid_conection As String


    Dim dx, dy As Integer

    Private Sub AddStaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dx = Me.Width
        dy = Me.Height

        strcon = "Data Provider=Microsoft.ACE.OLEDB.12.0;Provider=MSDataShape;Data Source=" _
                       & Application.StartupPath & "\staff_db.accdb"


        con = New ADODB.Connection
        With con
            .ConnectionString = strcon
            .Open()
            .Close()

            'MsgBox("Connection Successful")
        End With


    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        With con
            .Open()

            add_new()

            .Close()


        End With
    End Sub


    Sub add_new()
        If txt_file_number.Text <> "" And txt_firstname.Text <> "" And txt_surname.Text <> "" And combo_marrige.Text <> "" And combo_gender.Text <> "" And
        txt_place_of_birth.Text <> "" And combo_state.Text <> "" And txt_lga.Text <> "" And txt_qualification_at_employment.Text <> "" And txt_present_qualification.Text <> "" And
        txt_next_of_kin.Text <> "" And txt_phone_next_of_kin.Text <> "" And txt_address_next_of_kin.Text <> "" And residential_address.Text <> "" And txt_department.Text <> "" And
        txt_grade_level.Text <> "" And txt_cadre_level.Text <> "" And txt_designation.Text <> "" And txt_firstname.Text <> "" And txt_firstname.Text <> "" Then



            str = "select * From staff_info where file_number='" & txt_file_number.Text & "' "
            rs = New ADODB.Recordset
            rs.Open(str, con, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
            If rs.RecordCount > 0 Then
                MsgBox("Record Already Exist", MsgBoxStyle.Exclamation, "Record Exist")

            Else


                If photoPath <> "" Then





                    If File.Exists(photoPath) Then
                        Dim filename As String = Path.GetFileName(photoPath)
                        Dim destinationPath As String = Path.Combine(Application.StartupPath & "\Photo", filename)
                        If File.Exists(destinationPath) Then
                            File.Delete(destinationPath)
                        End If

                        File.Copy(photoPath, destinationPath)



                        rs.AddNew()
                        rs.Fields.Item("file_number").Value = txt_file_number.Text
                        rs.Fields.Item("firstname").Value = txt_firstname.Text
                        rs.Fields.Item("surname").Value = txt_surname.Text
                        rs.Fields.Item("marital_status").Value = combo_marrige.Text
                        rs.Fields.Item("gender").Value = combo_gender.Text
                        rs.Fields.Item("dob").Value = DateTimePicker_dob.Text

                        rs.Fields.Item("place_of_birth").Value = txt_place_of_birth.Text
                        rs.Fields.Item("state_of_origin").Value = combo_state.Text
                        rs.Fields.Item("lga").Value = txt_lga.Text
                        rs.Fields.Item("qualification_at_employment").Value = txt_qualification_at_employment.Text
                        rs.Fields.Item("present_qualification").Value = txt_present_qualification.Text
                        rs.Fields.Item("next_of_kin").Value = txt_next_of_kin.Text
                        rs.Fields.Item("phone_of_next_kin").Value = txt_phone_next_of_kin.Text
                        rs.Fields.Item("address_of_next_kin").Value = txt_address_next_of_kin.Text
                        rs.Fields.Item("residential_address").Value = residential_address.Text

                        rs.Fields.Item("department").Value = txt_department.Text
                        rs.Fields.Item("grade_level").Value = txt_grade_level.Text
                        rs.Fields.Item("cadre_level").Value = txt_cadre_level.Text
                        rs.Fields.Item("designation").Value = txt_designation.Text
                        rs.Fields.Item("date_of_appointment").Value = DateTimePicker_appointment.Text
                        rs.Fields.Item("date_of_confirmation").Value = txt_designation.Text

                        rs.Fields.Item("date_of_promotion").Value = DateTimePicker_confirmation.Text


                        rs.Fields.Item("photo_path").Value = destinationPath.Replace(Application.StartupPath, "")





                        rs.Update()

                        MsgBox(" Sucessfully Added", MsgBoxStyle.Information, "New Record")

                        FingerPrintForm.ShowDialog()

                        ' MsgBox("File Copied")
                    Else
                        MsgBox("Image Not saved")
                    End If















                Else

                    MsgBox("Select Photo")


                End If





            End If
        Else
            MsgBox("All Field Required", MsgBoxStyle.Exclamation, "All Field Required")

        End If
    End Sub



    Sub clear_all()
        txt_file_number.Clear()
        txt_firstname.Clear()
        txt_surname.Clear()
        combo_marrige.Text = String.Empty

        combo_gender.Text = String.Empty

        txt_place_of_birth.Clear()
        combo_state.Text = String.Empty
        txt_lga.Clear()
        txt_qualification_at_employment.Clear()
        txt_present_qualification.Clear()
        txt_next_of_kin.Clear()
        txt_phone_next_of_kin.Clear()
        txt_address_next_of_kin.Clear()
        residential_address.Clear()

        txt_department.Clear()
        txt_grade_level.Clear()
        txt_cadre_level.Clear()
        txt_designation.Clear()

        txt_designation.Clear()

        photoPath = ""
        PictureBox1.Image = My.Resources.photo
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        clear_all()
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim dialog As New OpenFileDialog()
        dialog.Title = "Browse Picture"
        dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
        If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(dialog.FileName)
            photoPath = dialog.FileName.ToString
        End If
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FingerPrintForm.ShowDialog()
    End Sub

    Private Sub Btn_camera_Click(sender As Object, e As EventArgs) Handles btn_camera.Click
        Camera.ShowDialog()
    End Sub


    Private Sub AddStaffForm_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Dim x, y As Integer

        x = Me.Width / 2

        y = Me.Height / 2

        GroupBox3.Location = New Point(dx / 2 - x, dy / 2 - y)
    End Sub


End Class