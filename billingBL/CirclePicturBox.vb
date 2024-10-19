Imports System.Drawing.Drawing2D

Class CirclePicturBox
    Inherits PictureBox

    ' Constructor to set default SizeMode
    Public Sub New()
        Me.SizeMode = PictureBoxSizeMode.Zoom  ' Set SizeMode to Zoom by default
    End Sub

    Protected Overrides Sub OnPaint(pe As PaintEventArgs)
        ' Create a circular clipping region
        Dim graph As GraphicsPath = New GraphicsPath
        graph.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height)
        Me.Region = New Region(graph)

        ' Call the base class OnPaint to handle image drawing
        MyBase.OnPaint(pe)
    End Sub

End Class
