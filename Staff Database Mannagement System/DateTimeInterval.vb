Public Class DateTimeInterval
    Private Sub BtnRange_Click(sender As Object, e As EventArgs) Handles btnRange.Click
        Dim input1, input2 As String

        input1 = dateIn.Text
        input2 = dateOut.Text

        Dim d1 As DateTime = DateTime.Parse(input1).Date
        Dim d2 As DateTime = DateTime.Parse(input2).Date

        Dim days As Single = (d2 - d1).TotalDays
        If days <= 0 Then
            days = 1
        End If
        labelRange.Text = days
    End Sub
End Class