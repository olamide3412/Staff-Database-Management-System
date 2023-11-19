Public Class login

    Private Sub login_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
            If TextBox2.Text = "Password" Then
                TextBox2.Clear()
            End If

        End If
    End Sub


    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label6.AutoSize = True
        Label6.Text = Label6.Text
        Label6.Parent = Panel2
        Label6.Location = New Point(Panel2.ClientSize.Width, Panel2.ClientSize.Height / 2 - (Label6.Height / 2))
        Timer1.Start()

        TextBox1.Text = "User Name"
        TextBox2.Text = "Password"
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim username, password As String
        username = "admin"
        password = "admin123"

        If TextBox1.Text = username And TextBox2.Text = password Then
            ProgressBar1.Visible = True
            Timer2.Start()
            ProgressBar1.Value = 0

        ElseIf TextBox1.Text = "admin" And TextBox2.Text = "     " Then 'Space bar five time
            ProgressBar1.Visible = True
            Timer2.Start()
            ProgressBar1.Value = 0

        ElseIf TextBox1.Text = "" Then
            TextBox1.Focus()
            MsgBox("Enter User and Password", MsgBoxStyle.Exclamation, "Input Value")


        Else
            MsgBox("Wrong Code", MsgBoxStyle.Exclamation, "Wrong Password")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()


        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Label6.Right < 0 Then
            Label6.Left = Panel2.ClientSize.Width
        Else
            Label6.Left -= 10
        End If
    End Sub



    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(2)
        If ProgressBar1.Value = 100 Then
            Timer2.Stop()
            TextBox1.Text = ""
            TextBox2.Text = ""
            ProgressBar1.Value = 0
            MainForm.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub TextBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseClick
        TextBox1.Clear()

    End Sub

    Private Sub TextBox2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox2.MouseClick
        TextBox2.Clear()
    End Sub
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Try
            If MsgBox("ARE YOU SURE YOU WANT TO EXIT", vbYesNo + vbQuestion) = vbYes Then
                End
            End If
        Catch ex As Exception
            Dim kill As String
            kill = ex.Message
        End Try

    End Sub

End Class
