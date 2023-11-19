Imports System.Data.OleDb
Imports System.IO
Public Class StaffRecords

    Dim con_grid As New OleDbConnection
    Dim dr As OleDbDataReader


    Sub load_all_user(ByVal strVal As String)
        Dim query As String

        'Dim query As String = "select (ID) as [ID], (full_name) as [Full Name] , (dob) as [DOB] , (age) as [Age], (gender) as [Gender],  (phone) as [Phone Number], (height) as [Height], (nationality) as [Nationality], (marital_status) as [Marital Status], (qualification) as [Qualification], (address) as [Residential Address], " &
        '"(state) as [State], (lga) as [LGA], (department) as [Department], (rank) as [Rank], (date_recruited) as [Date Recruited], (kin_full_name) as [Next Of Kin Full Name], (kin_phone) as [Next Of Kin Phone], (kin_occupation) as [Next Of Kin Occupation] from tb "

        If strVal <> "" Then
            query = "select  (file_number) as [File Number], (firstname) as [First Name] , (surname) as [Surname], (gender) as [Gender],  (present_qualification) as [Present Qualification]," &
         " (grade_level) as [Grade Level], (designation) as [Designation]," &
         " (department) as [Department], (cadre_level) as [Cadre], (residential_address) as [Residential Address]  from staff_info where firstname like '" & strVal & "%' "

        Else
            query = "select  (file_number) as [File Number], (firstname) as [First Name] , (surname) as [Surname], (gender) as [Gender],  (present_qualification) as [Present Qualification]," &
         " (grade_level) as [Grade Level], (designation) as [Designation]," &
         " (department) as [Department], (cadre_level) as [Cadre], (residential_address) as [Residential Address]  from staff_info "


        End If


        'Dim query As String = "select  (kin_full_name) as [Next Of Kin Full Name], (kin_phone) as [Next Of Kin Phone]  from tb "


        con_grid.Open()

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter(query, con_grid)
        da.Fill(dt)
        DG.DataSource = dt.DefaultView

        con_grid.Close()



        Dim dataCount As Integer
        dataCount = DG.RowCount '- 1
        l_count.Text = dataCount


        con_grid.Close()

        'SetFontAndColors()


    End Sub

    Private Sub StaffRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con_grid.ConnectionString = con_grid_conection
        load_all_user("")
        'SetFontAndColors()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Dispose()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length > 2 Then
            load_all_user(TextBox1.Text.Trim)

        Else

            load_all_user("")
        End If
    End Sub

    Private Sub SetFontAndColors()

        With Me.DG.DefaultCellStyle
            .Font = New Font("Tahoma", 15)
            .ForeColor = Color.Blue
            .BackColor = Color.Beige
            .SelectionForeColor = Color.Yellow
            .SelectionBackColor = Color.Black

        End With

    End Sub

End Class