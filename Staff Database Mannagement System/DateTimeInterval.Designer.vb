<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DateTimeInterval
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
        Me.dateIn = New System.Windows.Forms.DateTimePicker()
        Me.dateOut = New System.Windows.Forms.DateTimePicker()
        Me.btnRange = New System.Windows.Forms.Button()
        Me.labelRange = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dateIn
        '
        Me.dateIn.CustomFormat = "ddd dd-MMM-yyyy  hh:mm tt"
        Me.dateIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateIn.Location = New System.Drawing.Point(59, 99)
        Me.dateIn.MinDate = New Date(2023, 1, 1, 0, 0, 0, 0)
        Me.dateIn.Name = "dateIn"
        Me.dateIn.Size = New System.Drawing.Size(263, 27)
        Me.dateIn.TabIndex = 25
        '
        'dateOut
        '
        Me.dateOut.CustomFormat = "ddd dd-MMM-yyyy  hh:mm tt"
        Me.dateOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateOut.Location = New System.Drawing.Point(59, 155)
        Me.dateOut.MinDate = New Date(2023, 1, 1, 0, 0, 0, 0)
        Me.dateOut.Name = "dateOut"
        Me.dateOut.Size = New System.Drawing.Size(263, 27)
        Me.dateOut.TabIndex = 27
        '
        'btnRange
        '
        Me.btnRange.Location = New System.Drawing.Point(59, 307)
        Me.btnRange.Name = "btnRange"
        Me.btnRange.Size = New System.Drawing.Size(263, 30)
        Me.btnRange.TabIndex = 28
        Me.btnRange.Text = "Date Range"
        Me.btnRange.UseVisualStyleBackColor = True
        '
        'labelRange
        '
        Me.labelRange.AutoSize = True
        Me.labelRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelRange.Location = New System.Drawing.Point(146, 221)
        Me.labelRange.Name = "labelRange"
        Me.labelRange.Size = New System.Drawing.Size(71, 25)
        Me.labelRange.TabIndex = 29
        Me.labelRange.Text = "Label1"
        '
        'DateTimeInterval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 411)
        Me.Controls.Add(Me.labelRange)
        Me.Controls.Add(Me.btnRange)
        Me.Controls.Add(Me.dateOut)
        Me.Controls.Add(Me.dateIn)
        Me.Name = "DateTimeInterval"
        Me.Text = "DateTimeInterval"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dateIn As DateTimePicker
    Friend WithEvents dateOut As DateTimePicker
    Friend WithEvents btnRange As Button
    Friend WithEvents labelRange As Label
End Class
