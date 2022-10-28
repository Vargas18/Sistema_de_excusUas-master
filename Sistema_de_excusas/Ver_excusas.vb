Public Class Ver_excusas
    Dim a, b As Graphics
    Dim bmp As Bitmap

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Menuvb.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = CreateGraphics()
        bmp = New Bitmap(Size.Width, Size.Height, a)
        b = Graphics.FromImage(bmp)
        b.CopyFromScreen(Location.X, Location.Y, 0, 0, Size)
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintPreviewDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub
End Class