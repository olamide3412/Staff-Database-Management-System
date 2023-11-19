Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.IO

Public Class MainForm

    Public con As ADODB.Connection
    Public rs As ADODB.Recordset
    Public str As String
    Public photoPath As String
    'Public con_grid_conection As String
    Dim desName As String
    Shared random As New Random()

    Dim con_grid As New OleDbConnection
    Dim dr As OleDbDataReader


    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        con = New ADODB.Connection
        With con
            .ConnectionString = strcon
            .Open()

            str = "select * From staff_info  "
            rs = New ADODB.Recordset
            rs.Open(str, con, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)

            lbStaffCount.Text = rs.RecordCount.ToString + " Staffs"

            .Close()

            'MsgBox("Connection Successful")
        End With



        con_grid.ConnectionString = con_grid_conection
    End Sub





    Private Sub BtnPostingInformation_Click(sender As Object, e As EventArgs) Handles btnPostingInformation.Click
        If isAnotherFormOpen() = True Then

            ' Return
        End If

        With StaffPosting
            .TopLevel = False
            .Dock = DockStyle.Fill
            Panel4.Controls.Add(StaffPosting)

            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If isAnotherFormOpen() = True Then

            ' Return
        End If

        With StaffRecords
            .TopLevel = False
            .Dock = DockStyle.Fill
            Panel4.Controls.Add(StaffRecords)
            .BringToFront()
            .Show()

        End With
    End Sub

    Public Function isAnotherFormOpen() As Boolean


        If Panel4.Controls.Count > 0 Then
            ' MsgBox("Please Kindly close opened form first", MsgBoxStyle.Exclamation, "Unable to open form")

            Panel4.Controls.Clear()

            Return True


        End If

        Return False
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If isAnotherFormOpen() = True Then

            ' Return
        End If

        With AddStaffForm
            .TopLevel = False
            .Dock = DockStyle.Fill
            '.Location = New System.Drawing.Point((Panel4.Height) / 4, 0)
            Panel4.Controls.Add(AddStaffForm)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If isAnotherFormOpen() = True Then

            'Return
        End If

        With UpdateRecord
            .TopLevel = False
            .Dock = DockStyle.Fill
            Panel4.Controls.Add(UpdateRecord)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        login.Show()

    End Sub
End Class