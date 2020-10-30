Imports Syncfusion.Windows.Forms.Tools

Public Class Form1
    Inherits Form
    Public Sub New()
        InitializeComponent()

        Dim dateTimePickerAdv As New DateTimePickerAdv()
        dateTimePickerAdv.Location = New Point(100, 100)
        dateTimePickerAdv.ShowUpDown = True
        dateTimePickerAdv.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, (CByte(0)))
        Me.Controls.Add(dateTimePickerAdv)
    End Sub
End Class
