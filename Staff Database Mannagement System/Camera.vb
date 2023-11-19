Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.ComponentModel
Imports System.IO
Public Class Camera
    Dim CAMERA As VideoCaptureDevice
    Dim bmp As Bitmap
    Private Sub Camera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
            If cameras.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                CAMERA = cameras.VideoDevice
                AddHandler CAMERA.NewFrame, New NewFrameEventHandler(AddressOf Captured)
                CAMERA.Start()
            Else
                Me.Dispose()


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        Try
            bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
            PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Camera_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try


            If CAMERA.IsRunning = True Then
                CAMERA.Stop()

            End If




        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Try
            If CAMERA.IsRunning = True Then
                CAMERA.Stop()
                Button1.Text = "Re-Capture"
            Else
                CAMERA.Start()
                Button1.Text = "Capture"
            End If
        Catch ex As Exception

        End Try



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If CAMERA.IsRunning = False Then
                AddStaffForm.PictureBox1.Image = PictureBox1.Image
            End If

            Me.Dispose()
        Catch ex As Exception

        End Try

    End Sub
End Class