Public Class Login
    Dim usuario As String
    Dim contra As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        usuario = TextBox1.Text
        contra = TextBox2.Text

        If usuario = "UnionExcusas" And contra = "UN10N" Then
            Menuvb.Show()
            Me.Hide()
        Else
            MsgBox("El Usuario o Contraseña es incorrecto", vbCritical,)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
