Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Listado_alumnos
    Dim conexion As SqlConnection
    Dim comando As SqlCommand
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conexion.Open()
        Dim consulta As String = " insert into [Listado UNION].[dbo].[alumnos] (Nombre, Identidad, Curso, Seccion, Sexo) values('" & TextBox1.Text & "','" & TextBox2.Text & "',' " & TextBox3.Text & " ',' " & TextBox4.Text & " ','" & TextBox5.Text & "')"
        comando = New SqlCommand(consulta, conexion)
        'comando.Parameters.AddWithValue("@Nombre", TextBox1.Text)
        comando.ExecuteNonQuery()
        MessageBox.Show("los datos han ingresado correctamente")
        conexion.Close()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Menuvb.Show()
        Me.Hide()
    End Sub

    Private Sub Listado_alumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Listado_UNIONDataSet1.alumnos' Puede moverla o quitarla según sea necesario.
        Me.AlumnosTableAdapter.Fill(Me.Listado_UNIONDataSet1.alumnos)
        conexion = New SqlConnection("server=localhost\SQLEXPRESS; database=Listado UNION;integrated security=true")


    End Sub

    Private Sub _BDAlumnosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim conuslta As String = " delete from [Listado UNION].[dbo].[alumnos] where Identidad= '" & TextBox2.Text & "'"

        Dim cant As Integer
        Try
            conexion.Open()
            comando = New SqlCommand(conuslta, conexion)

            cant = comando.ExecuteNonQuery
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            conexion.Close()
        End Try



        If cant = 1 Then

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            MessageBox.Show("EL registro se elimino de manera correcta")

        Else
            MessageBox.Show("No se encontro ningun registro")
        End If
        conexion.Close()
    End Sub
End Class