Imports System.Data.OleDb
Imports System.IO
Public Class StaffPosting

    Dim con_grid As New OleDbConnection
    Dim dr As OleDbDataReader
    Dim dx, dy As Integer


    Sub load_all_posting(ByVal strVal As String)

        Dim query As String

        If strVal <> "" Then
            query = "select  (file_number) as [File Number], (firstname) as [First Name] , (surname) as [Surname],  (present_qualification) as [Present Qualification]," &
         " (department) as [Department], (grade_level) as [Grade Level], (cadre_level) as [Cadre],  (designation) as [Designation] from staff_info where firstname like '" & strVal & "%' "

        Else
            query = "select  (file_number) as [File Number], (firstname) as [First Name] , (surname) as [Surname],  (present_qualification) as [Present Qualification]," &
         " (department) as [Department], (grade_level) as [Grade Level], (cadre_level) as [Cadre],  (designation) as [Designation] from staff_info "

        End If






        con_grid.Open()

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter(query, con_grid)
        da.Fill(dt)
        DataGridViewPosting.DataSource = dt.DefaultView

        con_grid.Close()



        Dim dataCount As Integer
        dataCount = DataGridViewPosting.RowCount '- 1
        l_count.Text = dataCount.ToString + " Records"


        con_grid.Close()




    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If TextBox1.Text.Length > 2 Then
            load_all_posting(TextBox1.Text.Trim)

        Else

            load_all_posting("")
        End If



    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Dispose()

    End Sub

    Private Sub StaffPosting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con_grid.ConnectionString = con_grid_conection
        dx = Me.Width
        dy = Me.Height

        load_all_posting("")

    End Sub
End Class