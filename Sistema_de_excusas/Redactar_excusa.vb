Public Class Redactar_excusa
    Dim a, b As Graphics
    Dim bmp As Bitmap

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Menuvb.Show()
        Me.Hide()
    End Sub

    Private Sub Redactar_excusa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" Then
            MsgBox("SUS DATOS HAN SIDO GURDADOS", vbInformation,)
        Else
            MsgBox("SUS DATOS NO SE GUARDARONa", vbCritical,)
        End If
    End Sub


End Class